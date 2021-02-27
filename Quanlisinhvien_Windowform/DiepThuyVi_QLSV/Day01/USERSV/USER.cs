using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day01
{
    class USER
    {
        MyDB mydb = new MyDB();
       public DataTable getUserbyId(Int32 userid)
        {
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            SqlCommand command = new SqlCommand("Select * from hr where id =@userid", mydb.getConnection);
            command.Parameters.Add("@userid", SqlDbType.Int).Value = userid;
            adapter.SelectCommand = command;
            adapter.Fill(table);
            return table;
        }
        public bool insertUser(int id,string fname,string lname,string username,string password,MemoryStream picture )
        {
            SqlCommand command = new SqlCommand("insert into hr (id,fname,lname,uname,pwd,fig) values (@id,@fn,@ln,@un,@pwd,@pic)", mydb.getConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = id;
            command.Parameters.Add("@fn", SqlDbType.NVarChar).Value = fname;
            command.Parameters.Add("@ln", SqlDbType.NVarChar).Value = lname;
            command.Parameters.Add("@un", SqlDbType.NChar).Value = username;
            command.Parameters.Add("@pwd", SqlDbType.NChar).Value = password;
            command.Parameters.Add("@pic", SqlDbType.Image).Value = picture.ToArray();

            mydb.openConnection();
            if(command.ExecuteNonQuery()==1)
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
        public bool usernameExist(string username,string operation,int userid=0)
        {
            string query = "";
            if(operation == "register")
            {
                query = "select * from hr where uname =@un";

            }
            else if(operation == "edit")
            {
                query = "select * from hr where uname = @un and id<>@uid";
            }
            SqlCommand command = new SqlCommand(query, mydb.getConnection);
            command.Parameters.Add("@un", SqlDbType.VarChar).Value = username;
            command.Parameters.Add("@uid", SqlDbType.Int).Value = userid;

            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            adapter.SelectCommand = command;
            adapter.Fill(table);
            if(table.Rows.Count >0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool updateUser(int userid,string fname,string lname,string username,string password,MemoryStream picture)
        {
            SqlCommand command = new SqlCommand("Update hr set fname=@fn,lname=@ln,uname=@un,pwd=@pass,fig=@pic where id=@uid",mydb.getConnection);
            command.Parameters.Add("@fn", SqlDbType.NVarChar).Value = fname;
            command.Parameters.Add("@ln", SqlDbType.NVarChar).Value = lname;
            command.Parameters.Add("@un", SqlDbType.NChar).Value = username;
            command.Parameters.Add("@pass", SqlDbType.NChar).Value = password;
            command.Parameters.Add("@pic", SqlDbType.Image).Value = picture.ToArray();
            command.Parameters.Add("@uid", SqlDbType.Int).Value = userid;
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
    }
}
