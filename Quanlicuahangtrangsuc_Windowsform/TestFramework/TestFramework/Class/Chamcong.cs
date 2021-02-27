using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace TestFramework.Class
{
    class Chamcong
    {
        MyData mydb = new MyData();

        public DataTable LoadCCngay(DateTime ngay)
        {
            SqlCommand command = new SqlCommand();
            command.Connection = mydb.GetConnection;
            command.CommandText = ("select id as EmployeeID, currstate as Status,checkin as Checkin, checkout as Checkout from Timekeeping WHERE Timedate='" + ngay + "'");
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        public DataTable LoadCCthang(int thang, int manv)
        {
            SqlCommand command = new SqlCommand();
            command.Connection = mydb.GetConnection;
            command.CommandText = ("Select Timekeeping.id as EmployeeID, Timedate, checkin, checkout from Timekeeping where MONTH(Timedate)=" + thang + " and id=" + manv);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;

        }
        public DataTable Laysongaycong(DateTime ngaylam, int manv)
        {
            SqlCommand command = new SqlCommand();
            command.Connection = mydb.GetConnection;
            command.CommandText = ("select id as ID, checkin, CONVERT(time,checkin) as checkin, checkout,CONVERT(time,checkout) as checkout from Timekeeping where Timedate='" + ngaylam + "' and id=" + manv);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;

        }

        public bool ktcheckin(DateTime ngaylam, int manv)
        {
            SqlCommand command = new SqlCommand("SELECT Timedate, id FROM Timekeeping WHERE Timedate=@ngaylam and id=@manv and  checkin IS NOT NULL", mydb.GetConnection);
            command.Parameters.Add("@ngaylam", SqlDbType.DateTime).Value = ngaylam;
            command.Parameters.Add("@manv", SqlDbType.Int).Value = manv;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);

            if ((table.Rows.Count > 0))
            {
                return false;
            }
            else
            {
                return true;
            }

        }

        public bool ktcheckout(DateTime ngaylam, int manv)
        {
            SqlCommand command = new SqlCommand("SELECT Timedate, id FROM Timekeeping WHERE Timedate=@ngaylam and id=@manv and  checkout IS NOT NULL", mydb.GetConnection);
            command.Parameters.Add("@ngaylam", SqlDbType.Date).Value = ngaylam;
            command.Parameters.Add("@manv", SqlDbType.Int).Value = manv;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);

            if ((table.Rows.Count > 0))
            {
                return false;
            }
            else
            {
                return true;
            }

        }
        

        public bool checkin(DateTime ngaylam, int manv, string trangthai, DateTime checkin)
        {
            SqlCommand command = new SqlCommand("INSERT INTO Timekeeping (Timedate, id, currstate, checkin) VALUES (@ngaylam, @manv, @trangthai, @checkin)", mydb.GetConnection);
            command.Parameters.Add("@ngaylam", SqlDbType.DateTime).Value = ngaylam;
            command.Parameters.Add("@manv", SqlDbType.Int).Value = manv;
            command.Parameters.Add("@trangthai", SqlDbType.Char).Value = trangthai;
            command.Parameters.Add("@checkin", SqlDbType.DateTime).Value = checkin;
            //command.Parameters.Add("@checkout", SqlDbType.DateTime).Value = checkout;
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
        public bool insertchamcong(DateTime ngaylam, int manv, string trangthai, DateTime checkin)
        {
            SqlCommand command = new SqlCommand("INSERT into Timekeeping(Timedate, id, currstate, checkin) values (@ngaylam, @manv, @trangthai, @checkin)", mydb.GetConnection);
            command.Parameters.Add("@ngaylam", SqlDbType.DateTime).Value = ngaylam;
            command.Parameters.Add("@manv", SqlDbType.Int).Value = manv;
            command.Parameters.Add("@trangthai", SqlDbType.Char).Value = trangthai;
            command.Parameters.Add("@checkin", SqlDbType.DateTime).Value = checkin;
            //command.Parameters.Add("@checkout", SqlDbType.DateTime).Value = checkout;

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


        public bool insertchamcongA(DateTime ngaylam, int manv, string trangthai)
        {
            SqlCommand command = new SqlCommand("INSERT into Timekeeping(Timedate, id, currstate) values (@ngaylam, @manv, @trangthai)", mydb.GetConnection);
            command.Parameters.Add("@ngaylam", SqlDbType.DateTime).Value = ngaylam;
            command.Parameters.Add("@manv", SqlDbType.Int).Value = manv;
            command.Parameters.Add("@trangthai", SqlDbType.Char).Value = trangthai;

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
        public bool checkout(DateTime ngaylam, int manv, DateTime checkout)
        {
            SqlCommand command = new SqlCommand("update Timekeeping set checkout=@checkout where Timedate=@ngaylam and id=@manv", mydb.GetConnection);
            command.Parameters.Add("@ngaylam", SqlDbType.DateTime).Value = ngaylam;
            command.Parameters.Add("@manv", SqlDbType.Int).Value = manv;
            command.Parameters.Add("@checkout", SqlDbType.DateTime).Value = checkout;
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
        




        string execCount(string query)
        {
            mydb.openConnection();
            SqlCommand command = new SqlCommand(query, mydb.GetConnection);
            String count = command.ExecuteScalar().ToString();
            mydb.closeConnection();
            return count;
        }

        public bool checkCC(DateTime ngaylam, int manv)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM Timekeeping WHERE Timedate=@ngaylam and id=@manv ", mydb.GetConnection);
            command.Parameters.Add("@ngaylam", SqlDbType.DateTime).Value = ngaylam;
            command.Parameters.Add("@manv", SqlDbType.Int).Value = manv;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);

            if ((table.Rows.Count > 0))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public DataTable Loadfulllistdk(DateTime ngaylam)
        {
            SqlCommand command = new SqlCommand();
            command.Connection = mydb.GetConnection;
            command.CommandText = ("select Staff.id as EmployeeID, lastname as Lastname, firstname as Firstname, Timedate as Date, currstate as Status " +
                "from Staff inner join Timekeeping on Staff.id=Timekeeping.id " +
                "where Timedate=" + ngaylam);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        public DataTable Loadfulllist()
        {
            SqlCommand command = new SqlCommand();
            command.Connection = mydb.GetConnection;
            command.CommandText = ("select Staff.id as EmployeeID, lastname as Lastname, firstname as Firstname, Timedate as Date, currstate as Status from Staff inner join Timekeeping on Staff.id = Timekeeping.id");
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;

        }
    }
}
