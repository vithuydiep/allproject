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
    class Contact
    {
        MyDB mydb = new MyDB();
        public bool insertContact(int id,string fname,string lname,string phone,string address, string email,int userid,string groupid,MemoryStream picture)
        {
            SqlCommand command = new SqlCommand("insert into mycontact(id,fname,lname,phone,address,email,groupid,picture,userid) values(@id,@fn,@ln,@phn,@adrs,@mail,@grp,@pic,@uid)", mydb.getConnection);
            command.Parameters.Add("@fn", SqlDbType.NVarChar).Value = fname;
            command.Parameters.Add("@ln", SqlDbType.NVarChar).Value = lname;
            command.Parameters.Add("@grp", SqlDbType.VarChar).Value = groupid;
            command.Parameters.Add("@phn", SqlDbType.VarChar).Value = phone;
            command.Parameters.Add("@mail", SqlDbType.NVarChar).Value = email;
            command.Parameters.Add("@adrs", SqlDbType.NVarChar).Value = address;
            command.Parameters.Add("@id", SqlDbType.Int).Value = id;
            command.Parameters.Add("@pic", SqlDbType.Image).Value = picture.ToArray();
            command.Parameters.Add("@uid", SqlDbType.Int).Value = userid;

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



        public bool updateContact(int contactid,string fname, string lname, string phone, string address, string email, int userid, string groupid, MemoryStream picture)
        {
            SqlCommand command = new SqlCommand("update mycontact set fname= @fn,lname=@ln,groupid=@grp,phone=@phn,email=@mail,address=@adrs,picture= @pic,userid=@uid where id=@id", mydb.getConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = contactid;
            command.Parameters.Add("@fn", SqlDbType.NVarChar).Value = fname;
            command.Parameters.Add("@ln", SqlDbType.NVarChar).Value = lname;
            command.Parameters.Add("@grp", SqlDbType.VarChar).Value = groupid;
            command.Parameters.Add("@phn", SqlDbType.VarChar).Value = phone;
            command.Parameters.Add("@mail", SqlDbType.VarChar).Value = email;
            command.Parameters.Add("@adrs", SqlDbType.NVarChar).Value = address;
            command.Parameters.Add("@uid", SqlDbType.Int).Value = userid;
            command.Parameters.Add("@pic", SqlDbType.Image).Value = picture.ToArray();

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


        public bool deleteContact(int contactid)
        {
            SqlCommand command = new SqlCommand("delete from mycontact where id =@id", mydb.getConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = contactid;
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


        public DataTable SelectContactList(SqlCommand command)
        {
            command.Connection = mydb.getConnection;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        public DataTable GetContactById(int contactid)
        {
            SqlCommand command = new SqlCommand("select id,fname,lname,phone,address,email,groupid,picture from mycontact where id=@id", mydb.getConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = contactid;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        public DataTable SelectContact(int contactid)
        {
            SqlCommand command = new SqlCommand("select id,fname,lname,groupid from mycontact where id=@id", mydb.getConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = contactid;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
    }
}
