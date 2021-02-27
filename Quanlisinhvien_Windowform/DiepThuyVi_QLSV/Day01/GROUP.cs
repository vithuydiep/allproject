using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day01
{
    class GROUP
    {
        MyDB mydb = new MyDB();
        public bool insertgroup(string id, string name)
        {
            SqlCommand command = new SqlCommand("insert into groupct (id,namegroup) values(@id,@name)", mydb.getConnection);
            command.Parameters.Add("@id", SqlDbType.NChar).Value = id;
            command.Parameters.Add("@name", SqlDbType.NVarChar).Value = name;
            mydb.openConnection();
            if (command.ExecuteNonQuery() == 1)
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

        public bool editgroup(string id, string name)
        {
            SqlCommand command = new SqlCommand("update groupct set namegroup=@name where id=@id", mydb.getConnection);
            command.Parameters.Add("@id", SqlDbType.NChar).Value = id;
            command.Parameters.Add("@name", SqlDbType.NVarChar).Value = name;
            mydb.openConnection();
            if (command.ExecuteNonQuery() == 1)
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
        public bool removegroup(string id)
        {
            SqlCommand command = new SqlCommand("delete from groupct where id =@id", mydb.getConnection);
            command.Parameters.Add("@id", SqlDbType.VarChar).Value = id;
            mydb.openConnection();
            if (command.ExecuteNonQuery() == 1)
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
        public DataTable SelectGroupList()
        {
            SqlCommand command = new SqlCommand("select * from groupct");
            command.Connection = mydb.getConnection;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
    }
}
