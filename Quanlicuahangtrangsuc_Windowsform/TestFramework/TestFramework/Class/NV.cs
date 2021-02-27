using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.IO;

namespace TestFramework.Class
{
    class NV
    {
        MyData mydb = new MyData();
        public bool insertStaff(string manv, string holot, string ten, string gioitinh, string diachi, MemoryStream hinh, int sodienthoai, int machucvu)
        {
            SqlCommand command = new SqlCommand("INSERT INTO Staff(id, firstname, lastname, gender, addr, picture, phone, idpos)" +
                "VALUES (@manv, @holot, @ten, @gioitinh, @diachi, @hinh, @sodienthoai, @machucvu)", mydb.GetConnection);
            command.Parameters.Add("@manv", SqlDbType.VarChar).Value = manv;
            command.Parameters.Add("@holot", SqlDbType.NVarChar).Value = holot;
            command.Parameters.Add("@ten", SqlDbType.NVarChar).Value = ten;
            command.Parameters.Add("@gioitinh", SqlDbType.NVarChar).Value = gioitinh;
            command.Parameters.Add("@diachi", SqlDbType.NVarChar).Value = diachi;
            command.Parameters.Add("@hinh", SqlDbType.Image).Value = hinh.ToArray();
            command.Parameters.Add("@sodienthoai", SqlDbType.Int).Value = sodienthoai;
            command.Parameters.Add("@machucvu", SqlDbType.Int).Value = machucvu;
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
        public DataTable getStaff(SqlCommand command)
        {
            command.Connection = mydb.GetConnection;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        public DataTable getStafffill(SqlCommand command)
        {
            command.Connection = mydb.GetConnection;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        public bool deleteStaff(string manv)
        {
            SqlCommand command = new SqlCommand("DELETE FROM Staff WHERE id=@manv", mydb.GetConnection);
            command.Parameters.Add("@manv", SqlDbType.VarChar).Value = manv;
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
        public bool updateStaff(string manv, string holot, string ten, string gioitinh, string diachi, MemoryStream hinh, int sodienthoai, int machucvu)
        {
            SqlCommand command = new SqlCommand("UPDATE Staff SET firstname=@holot, lastname=@ten, gender=@gioitinh, addr=@diachi, picture=@hinh, phone=@sodienthoai, idpos=@machucvu WHERE id=@manv", mydb.GetConnection);
            command.Parameters.Add("@manv", SqlDbType.VarChar).Value = manv;
            command.Parameters.Add("@holot", SqlDbType.NVarChar).Value = holot;
            command.Parameters.Add("@ten", SqlDbType.NVarChar).Value = ten;
            command.Parameters.Add("@gioitinh", SqlDbType.NVarChar).Value = gioitinh;
            command.Parameters.Add("@diachi", SqlDbType.NVarChar).Value = diachi;
            command.Parameters.Add("@hinh", SqlDbType.Image).Value = hinh.ToArray();
            command.Parameters.Add("@sodienthoai", SqlDbType.Int).Value = sodienthoai;
            command.Parameters.Add("@machucvu", SqlDbType.Int).Value = machucvu;

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
        public string totalStaff()
        {
            return execCount("exec TongNhanVien");
        }
        public string totalNamStaff()
        {
            return execCount("exec TongNhanVienNam");
        }
        public string totalNuStaff()
        {
            return execCount("exec TongNhanVienNu");
        }

        public DataTable getAllCV()
        {
            SqlCommand command = new SqlCommand("SELECT * FROM Position", mydb.GetConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        public DataTable getName()
        {
            SqlCommand command = new SqlCommand("select id,  CONCAT_WS(' ',firstname,lastname) as FullName from Staff", mydb.GetConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
    }
}
