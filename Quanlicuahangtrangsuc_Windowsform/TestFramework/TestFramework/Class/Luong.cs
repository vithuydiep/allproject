using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace TestFramework.Class
{
    class Luong
    {
        MyData mydb = new MyData();

        public bool TinhLuong(int manv, int thang, int nam, double luong)
        {
            SqlCommand command = new SqlCommand("INSERT INTO Salary(id, month, year, salary)" +
                "VALUES (@manv, @thang, @nam, @luong)", mydb.GetConnection);
            command.Parameters.Add(@"manv", SqlDbType.Int).Value = manv;
            command.Parameters.Add(@"thang", SqlDbType.Int).Value = thang;
            command.Parameters.Add(@"nam", SqlDbType.Int).Value = nam;
            command.Parameters.Add(@"luong", SqlDbType.Float).Value = luong;

            mydb.openConnection();
            if ((command.ExecuteNonQuery() == 1))
            {
                mydb.closeConnection();
                return true;
            }
            else
            {
                mydb.closeConnection();
                return false;
            }
        }
        public bool checktinhluong(int thang, int nam)
        {
            SqlCommand command = new SqlCommand("SELECT DISTINCT month, year FROM Salary WHERE year=@cnam AND month=@cthang", mydb.GetConnection);
            command.Parameters.Add(@"cthang", SqlDbType.Int).Value = thang;
            command.Parameters.Add(@"cnam", SqlDbType.Int).Value = nam;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                mydb.closeConnection();
                return false;
            }
            else
            {
                mydb.closeConnection();
                return true;
            }
        }

        public DataTable LoadLuong(int thang, int nam)
        {
            SqlCommand command = new SqlCommand();
            command.Connection = mydb.GetConnection;
            command.CommandText = ("select employeeid, count(*) as workdays,pos, basicsa, NumSalary from (select Staff.id as employeeid, Position.id as pos, Position.salary as basicsa , numsalary ,currstate, checkin, checkout from Position inner join Staff on Position.id=Staff.idpos inner join Timekeeping on Timekeeping.id=Staff.id where month(Timedate)=" + thang + " and year(Timedate)=" + nam + " and currstate='P') as A GROUP BY employeeid,pos, basicsa, NumSalary ");
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        public DataTable LoadLuongcc(int thang, int nam)
        {
            SqlCommand command = new SqlCommand();
            command.Connection = mydb.GetConnection;
            command.CommandText = ("select Staff.id as employeeid, Position.id as pos, Timedate, checkin, checkout from Position inner join Staff on Position.id=Staff.idpos inner join Timekeeping on Timekeeping.id=Staff.id where month(Timedate)=" + thang + " and year(Timedate)=" + nam);

            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        public DataTable Loadgrid2(int thang, int nam)
        {
            SqlCommand command = new SqlCommand();
            command.Connection = mydb.GetConnection;
            command.CommandText = ("select Salary.id, firstname, salary from Staff inner join Salary on Staff.id=Salary.id where Salary.month =" + thang + " and Salary.year =" + nam + " group by Salary.id, Salary.month, Salary.year, firstname, lastname, salary");
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        
        public DataTable Load(SqlCommand command)
        {
            command.Connection = mydb.GetConnection;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        public DataTable Loadsalarystaffdk(int thang, int nam)
        {
            SqlCommand command = new SqlCommand();
            command.Connection = mydb.GetConnection;
            command.CommandText = ("select employeeid,salary.month, salary.year, count(*) as workdays,pos, basicsa, NumSalary, Salary.salary" +
                                    " from(select Staff.id as employeeid, Position.id as pos, Position.salary as basicsa, numsalary, checkin, checkout from Position inner join Staff on Position.id = Staff.idpos inner join Timekeeping on Timekeeping.id = Staff.id where month(Timedate) = 12 and year(Timedate) = 2020) as A, Salary" +
                                    " where a.employeeid = Salary.id and month =" + thang + " and year =" + nam +
                                    " GROUP BY employeeid,pos, basicsa, NumSalary, Salary.salary,salary.month, salary.year" +
                                    " order by employeeid");
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
    }
}
