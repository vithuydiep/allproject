using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOANCUOIKI
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime t1 = new DateTime(2019, 10, 12, 13, 10, 56);
            DateTime t2 = new DateTime(2019, 12, 6, 8, 9, 10);
            DateTime t3 = new DateTime(2019, 10, 12, 10, 30, 00);
            DateTime t4 = new DateTime(2019, 12, 11, 14, 3, 45);
            List<DateTime> dst1 = new List<DateTime>();
            dst1.Add(t1);
            dst1.Add(t2);
            List<DateTime> dst2 = new List<DateTime>();
            dst2.Add(t3);
            dst2.Add(t4);

            Console.OutputEncoding = Encoding.UTF8;

            DienThoai kh1 = new KhachHang("Lưu Thị Kim Ngân", 2000, "111", "0901342943", "0277345245", "Thủ Đức", 15);
            DienThoai kh2 = new KhachHang("Dương Thanh Trang", 1998, "112", "0938443856", "0233325657", "Cần Thơ", 3);
            DienThoai nv1 = new BaoVe("Diệp Thúy Vi", 2001, "113", "0898018964", "027738546519", "Quận 9", "vvn");
            DienThoai nv2 = new ThuNgan("Cao Thị Mai Trâm", 2000, "114", "0839907387", "022267365", "Thủ Đức", "Lê Văn Việt");
            DienThoai tv1 = new KHTuVan("Nguyễn Như Ngọc", 1999, "115", "0942911853", "0232523995", "Quận 3", dst1);
            DienThoai tv2 = new KHTuVan("Nguyễn Thị Mỹ Hiền", 2002, "116", "094435854", "0722352513", "Tân Bình", dst2);
            KhachHang kh11 = new KhachHang("Lưu Thị Kim Ngân", 2000, "111", "0901342943", "0277345245", "Thủ Đức", 12);
            KhachHang kh22 = new KhachHang("Dương Thanh Trang", 1998, "112", "0938443856", "0233325657", "Cần Thơ", 3);

            List<KhachHang> lkh = new List<KhachHang>();
            lkh.Add(kh11);
            lkh.Add(kh22);

            List<DienThoai> ldt = new List<DienThoai>();
            ldt.Add(kh1);
            ldt.Add(kh2);
            ldt.Add(nv1);
            ldt.Add(nv2);
            ldt.Add(tv1);
            ldt.Add(tv2);

            Quanli ql = new Quanli(ldt,lkh);
    
            int choose;
            Console.WriteLine("\t\t\t\t__________________________________________________ ");
            Console.WriteLine("\t\t\t\t------------------QUẢN LÍ DANH BẠ-----------------");
            Console.WriteLine("\t\t\t\t|  1. In danh bạ                                 |");
            Console.WriteLine("\t\t\t\t|  2. Tìm kiếm thông tin                         |");
            Console.WriteLine("\t\t\t\t|  3. Thêm thông tin                             |");
            Console.WriteLine("\t\t\t\t|  4. Xóa thông tin điện thoại                   |");
            Console.WriteLine("\t\t\t\t|  5. Chỉnh sửa thông tin                        |");
            Console.WriteLine("\t\t\t\t|  6. Sắp xếp thông tin theo năm sinh            |");
            Console.WriteLine("\t\t\t\t|  7. Sắp xếp khách hàng theo số lần giao dịch   |");
            Console.WriteLine("\t\t\t\t|  8. Chương trình ưu đãi                        |");
            Console.WriteLine("\t\t\t\t|  9. In danh sách khách hàng                    |");
            Console.WriteLine("\t\t\t\t|  10. Khách hàng giao dịch nhiêu nhất           |");
            Console.WriteLine("\t\t\t\t|  11. Thoát                                     |");
            Console.WriteLine("\t\t\t\t--------------------------------------------------");
            Console.WriteLine("\t\t\t\t__________________________________________________ ");
            do
            {
                Console.Write("\t\tNhập lựa chọn của bạn: ");
                choose = Convert.ToInt32(Console.ReadLine());
                switch (choose)
                {
                    case 1:
                        ql.Xuat();
                        break;
                    case 2:
                        Console.Write("\t\tNhap số điện thoại: ");
                        string sdt = Console.ReadLine();
                        ql.Search(sdt);
                        break;
                    case 3:
                        Console.Clear();
                        int chon;
                        Console.WriteLine("\t\t\t\t_______________________________________");
                        Console.WriteLine("\t\t\t\t************THÊM NHÂN VIÊN*************");
                        Console.WriteLine("\t\t\t\t* 1. Thêm nhân viên bảo vệ            *");
                        Console.WriteLine("\t\t\t\t* 2. Thêm nhân viên thu ngân          *");
                        Console.WriteLine("\t\t\t\t* 3. Thêm khách hàng                  *");
                        Console.WriteLine("\t\t\t\t* 4. Thêm thông tin tư vấn            *");
                        Console.WriteLine("\t\t\t\t* 5. Quay lại                         *");
                        Console.WriteLine("\t\t\t\t***************************************");

                        do
                        {
                            Console.Write("\t\tNhập lựa chọn: ");
                            chon = Convert.ToInt32(Console.ReadLine());
                            switch (chon)
                            {
                                case 1:
                                    ql.Addnvbv();
                                    break;
                                case 2:
                                    ql.Addnvtn();
                                    break;
                                case 3:
                                    ql.Addkh();
                                    break;
                                case 4:
                                    ql.Addtv();
                                    break;
                            }
                        } while (chon != 5);
                        Console.Clear();
                        break;
                    case 4:
                        Console.Write("\t\tNhap số điện thoại: ");
                        string std = Console.ReadLine();
                        ql.Delete(std);
                        break;
                    case 5:
                        Console.Write("\t\tNhập số điện thoại : ");
                        int c, i;
                        string SDT = Console.ReadLine();
                        for (i = 0; i < ldt.Count; i++)
                        {
                            if (ldt[i].DTDĐ == SDT)
                            {
                                Console.Clear();
                                Console.WriteLine("\t\t\t\t__________________________________________________");
                                Console.WriteLine("\t\t\t\t----------------CHỈNH SỬA THÔNG TIN---------------");
                                Console.WriteLine("\t\t\t\t|  1. Số điện thoại                              |");
                                Console.WriteLine("\t\t\t\t|  2. Địa chỉ                                    |");
                                Console.WriteLine("\t\t\t\t|  3. Cập nhật thông tin                         |");
                                Console.WriteLine("\t\t\t\t|  4. Thêm thời gian tư vấn                      |");
                                Console.WriteLine("\t\t\t\t|  5. Quay lại                                   |");
                                Console.WriteLine("\t\t\t\t--------------------------------------------------");
                                do
                                {
                                    Console.Write("\t\tNhập lựa chọn: ");
                                    c = Convert.ToInt32(Console.ReadLine());
                                    switch (c)
                                    {
                                        case 1:
                                            ldt[i].editsđt();
                                            break;
                                        case 2:
                                            ldt[i].editđc();
                                            break;
                                        case 3:
                                            ldt[i].update();
                                            break;
                                        case 4:
                                            ldt[i].edittime();
                                            break;


                                    }

                                } while (c != 5);
                            }

                        }
                        if (i >= ldt.Count )
                            Console.WriteLine("Không tồn tại số điện thoại này! ");
                        break;
                    case 6:
                        ql.Sort();
                        break;
                    case 7:
                        ql.Sortgd();
                        break;
                    case 8:
                        ql.discount1();
                        break;
                    case 9:
                        ql.Xuatkh();
                        break;
                    case 10:
                        ql.First();
                        break;


                }

            } while (choose != 11);

        }
    }
}
