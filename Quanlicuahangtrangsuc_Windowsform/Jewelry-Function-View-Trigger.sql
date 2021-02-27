use DiamondGroup
--Đăng kí tài khoản nhân viên
create proc addaccount @username varchar(50), @pass varchar(50), @feature int, @phone char(50), @id int
asi
begin
	DECLARE @sql varchar(MAX),@cmd varchar(4000)
	if @phone in (select phone from Staff)
	begin
		if @id in (select id from Staff)
		begin
		 insert into Account values(  @username,  @pass, @feature, @id )
		end
	end	
end
drop proc addaccount


execute addaccount 'vidiep','123',1,'123456', 2

--Kiểm tra đăng nhập 
create function loginacc (@username char(50), @pass char(50))  returns @table table (id int null, feature int null)
as
begin
	insert @table select id,feature
			      from Account
				  where  username = @username and pass =@pass
	return
end

drop function loginacc

select * from dbo.loginacc('vidiep','123')
go


--Kiểm tra số điện thoại khách hàng 
create trigger checkphone on Bill --ok
after insert as
begin
	declare @phone char(20)
	select @phone= ne.phone
	from inserted ne
	if @phone not in (select phone from Customer)
	begin
		insert into Customer values (@phone,1,1)
	end
end

--Lấy số điện thoại của khách hàng
create function getPhone() returns table as --ok
return (
		select *
		from Customer
		where name = '1' and addr='1'
)

--Thêm đơn hàng vào bill cập nhật số lượng sản phẩm
create trigger addbill on Bill --ok
after insert as
begin
	declare @sl int, @id int, @sl1 int
	select @sl = ne.amount, @id = ne.idpro
	from inserted ne
	update Product
	set curnumber = curnumber - @sl
	where id = @id
	select @sl1 = curnumber
	from Product
	where id = @id
	if @sl1 = 0
		update Product set state = 0 where id = @id
	else 
		update Product set state = 1 where id = @id
end

--Xóa đơn hàng vào bill cập nhật số lượng sản phẩm
create trigger deletebill on Bill --ok
after delete as
begin
	declare @sl int, @id int, @sl1 int
	select @sl= de.amount, @id = de.idpro
	from deleted de
	update Product
	set curnumber = curnumber + @sl 
	where id = @id
	select @sl1 = curnumber
	from Product
	where id = @id
	if @sl1 = 0
		update Product set state = 0 where id = @id
	else 
		update Product set state = 1 where id = @id
end
--Tìm kiếm theo keyword
create function findkey (@key nvarchar(MAX)) returns table
as return (
	select * 
	from Product
	where state = 1 and type=@key
)

--Tăng lương theo số lượng hàng được bán
create trigger tangluong on Bill 
after insert as
begin
	declare @idnv int, @sl int ,@tongtien int
	select @idnv= ne.manv
	from inserted ne
	select @sl = COUNT(id), @tongtien = SUM(total)
	from Bill 
	where manv = @idnv 
	if @sl > 5 and @sl < 10 and @tongtien < 5000000
		update Position set NumSalary += 0.5 where id = @idnv
	else if @sl > 10 and @tongtien > 5000000
		update Position set NumSalary += 1 where id = @idnv
end


--Nhân viên được tăng lương thì admin cũng tăng 1 lượng tương ứng
create trigger tangNQL on Position
after update as 
begin
	declare @id int, @numn int, @numo int, @tang int
	select @id = ne.id, @numn= ne.NumSalary 
	from inserted ne
	select @numo= ol.NumSalary
	from deleted ol
	where ol.id = @id
	set @tang = @numn - @numo 
	update Position
	set NumSalary += @tang
	where id = 1
end
-- Lấy thông tin về sản phẩm mà khách hàng đã chọn
create proc thongtinsanpham 
@idpr int
as
begin
	select *
	from Product
	where @idpr=Product.id
end
go
-- Lấy tất cả record trong bảng Bill của 1 ngày nhất định
create proc recordoder1ngay @ngay date
as
begin
	select *
	from Bill
	where Bill.daytime = @ngay
end
go
-- Lấy tất cả record trong bảng Bill trong vòng 1 tháng
create proc recordoder1thang
@thang int
as
begin
	select *
	from Bill
	where month(daytime) = @thang
end
go
-- Liệt kê thông tin của nhân viên thông qua id
Create proc thongtinnhanvien
@id int
as
begin
	select nv.id, nv.firstname, nv.lastname,nv.phone, nv.gender, nv.addr, nv.idpos
	from Staff nv	
	where nv.id = @id
end
go
-- Nhập vào ngày, xuất ra các nhân viên đi làm trong ngày đó
Create proc nhanviendilamtheongay
@ngaydilam datetime
as
begin
	select nv.id, nv.firstname, nv.lastname, nl.checkin, nl.checkout
	from Timekeeping nl inner join Staff nv on nl.id = nv.id
	where  convert(date,nl.Timedate) = @ngaydilam AND nl.currstate = ‘P’
end

-- Nhập vào tháng, xuất ra nhân viên có lương cao nhất tháng đó
create proc luongcaonhattheothang
@thang int
as
begin
	select nv.id, nv.firstname, nv.lastname, l.salary
	from Salary l inner join Staff nv on nv.id = l.id
	where l.month = @thang and l.salary = (select max(salary) from Salary)
end
go

-- Xem bảng lương nhân viên theo tháng
create proc xembangluongtheothang
@thang int
as
begin
	select *
	from Salary l
	where l.month = @thang
end

-- Xử lý tăng lương 10% cho các nhân viên
create proc tang10phantramluong
As
begin
	update Salary
	set salary = salary*1.1
end

-- Xử lý tăng lương x% cho các nhân viên là Quản lý
create proc tangXphantramluongql
@x int
as
begin
	update Salary
	set salary *=(100+@x)*1.0/100
	where Salary.id IN (select	Staff.id
				from Staff inner join Position on Staff.idpos = Position.id where Position.Nameposition = N'Quản lý');
end

-- View thể hiện trạng thái của nhân viên trong một ngày nhất định (checkin/checkout/absent)
create proc HienTrangNhanVien(@ngay Date) as
	select Timekeeping.id as EmployeeID, firstname,lastname, currstate as Status,checkin as Checkin, checkout as Checkout 
	from Timekeeping inner join Staff on Staff.id =Timekeeping.id 
	WHERE convert(date,Timedate) =@ngay

-- Xem trạng thái tất cả các ngày trong tháng của một nhân viên
create proc nhanvientrongthang @id int, @thang int as
select Staff.id, lastname, firstname, Timedate, currstate, checkin, checkout
from Staff inner join Timekeeping on Staff.id=Timekeeping.id
where Staff.id=@id and MONTH(timedate)=@thang

-- Function hiển thị danh sách số ngày công, lương cơ bảng và hệ số lương của nhân viên trong tháng nhân viên
Create function TinhLuong(@thang int, @nam int) returns table
as
return 
	(select employeeid, salary.month, salary.year,count(*) as workdays,pos, basicsa, NumSalary, Salary.salary 
	from (select Staff.id as employeeid, Position.id as pos, Position.salary as basicsa, numsalary,currstate, checkin, checkout 
			from Position inner join Staff on Position.id = Staff.idpos inner join Timekeeping on Timekeeping.id = Staff.id 
			where month(Timedate) = @thang and year(Timedate) = @nam and currstate='P') as A, Salary 
	where a.employeeid = Salary.id 
    group by employeeid,pos, basicsa, NumSalary, Salary.salary,salary.month, salary.year)

-- Tìm mã sản phẩm và số lượng đã bán của nó
Create function timsanpham(@idsp int) returns table
as return select id,name, (amount - curnumber) as N'Số sản phẩm đã bán'
		from Product
		where id = @idsp
go

-- Phân loại sản phẩm và số lượng bán được trong 1 tháng theo loại sản phẩm
Create function phanloaisp() returns table
as return select type, (sum(amount) -sum(curnumber)) as N'Tổng sản phẩm đã bán'
			from Product
			group by type
go

-- Tính doanh thu trong 1 tháng theo loại sản phẩm
Create function doanhthuthang(@mo int) returns table
as return 	select type, sum(Bill.total) as N'Tổng doanh thu'
			from Bill inner join Product on Bill.idpro = Product.id 
			where MONTH(Bill.daytime)=@mo
			group by type, daytime	 

-- Lấy thông tin sản phẩm dựa trên mã sản phẩm
Create function thongtinsp(@idsp int) returns table
as return select *
		from Product
		where Product.id=@idsp
go

-- Hàm lấy thông tin loại sản phẩm có doanh thu cao nhất tháng
create function LoaiSPDoanhSoCao(@thang int) returns table as
return
select type, (sum(Product.amount) -sum(curnumber)) as N'Tổng sản phẩm đã bán', total
from Bill inner join Product on Product.id=Bill.idpro		
where total =(select MAX(total) as MaxDoanhSo from 
		(select type,  total
		from Bill inner join Product on   Product.id=Bill.idpro
	       where MONTH(daytime)=@thang)as A) 
group by type, total
drop function LoaiSPDoanhSoCao

-- Liệt kê sản phẩm mới nhập (ngày nhập tới hiện tại <=30 ngày)
create view lkspmoi as select * from product sp where DATEDIFF(day, sp.inputday, GETDATE()) <= 30;
Go
-- Lấy tất cả các record trong bảng Bill
create view thongtinbill as select * 
from Bill  
        Go
-- Lấy thông tin của những sản phẩm còn hàng
create view thongtinsanphamconhang as
select * from Product
where Product.curnumber>0
        Go
-- Lấy thông tin về tất cả khách hàng
Create view thongtinkhachhang as
select * from Customer
        Go
-- Lấy thông tin của nhân viên là Quản lý
create view thongtinquanly
as
select id, firstname, lastname, phone, gender, addr
from Staff
where idpos=1
-- Hàm lấy thông tin cho biết đã có bao nhiêu nhân viên checkin trong ngày hiện tại
create view nhanviendacheckin as
select Staff.id as EmployeeID, lastname as Lastname, firstname as Firstname, Timedate as Date, currstate as Status 
      from Staff inner join Timekeeping on Staff.id=Timekeeping.id 
      where convert(date,Timedate)=convert(date, GETDATE())
-- Xem tất cả chương trình sales mà cửa hàng áp dụng
create view chuongtrinhsale as
select name, startdate, finishdate, sale  from Sales
where sale <> 0
-- View xem thông tin và lương của tất cả nhân viên trong tất cả các tháng
create view luongnhanvien as
	select Staff.id, lastname, firstname, month, salary
	from Staff inner join Salary on Salary.id=Staff.id
-- Xem số ngày công và lương tháng tương ứng của nhân viên
create view xemluong as
	select employeeid, count(*) as workdays,Salary.salary, month, year
	from (select Staff.id as employeeid,  checkin, checkout from Position inner join Staff on Position.id=Staff.idpos inner join Timekeeping on Timekeeping.id=Staff.id )as A, Salary
	where a.employeeid=Salary.id 
	GROUP BY employeeid, Salary.salary, month, year



