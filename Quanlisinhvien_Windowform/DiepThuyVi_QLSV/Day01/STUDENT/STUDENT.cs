using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace Day01
{
    public class STUDENT
    {
        MyDB mydb = new MyDB();
        public bool insertStudent(int Id,string fname,string lname, DateTime bdate, string gender, string phone, string address,MemoryStream picture)
        {
          
            SqlCommand command = new SqlCommand("INSERT INTO std(id,fname,lname,bdate,gender,phone,address,picture)" +
                "VALUES(@id,@fn,@ln,@bdt,@gdr,@phn,@adrs,@pic)", mydb.getConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = Id;
            command.Parameters.Add("@fn", SqlDbType.NVarChar).Value = fname;
            command.Parameters.Add("@ln", SqlDbType.NVarChar).Value = lname;
            command.Parameters.Add("@bdt", SqlDbType.DateTime).Value = bdate;
            command.Parameters.Add("@gdr", SqlDbType.VarChar).Value = gender;
            command.Parameters.Add("@phn", SqlDbType.VarChar).Value = phone;
            command.Parameters.Add("@adrs", SqlDbType.NVarChar).Value = address;
            command.Parameters.Add("@pic", SqlDbType.Image).Value = picture.ToArray();
            mydb.openConnection();

            if(command.ExecuteNonQuery() == 1)
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
       public DataTable getStudents(SqlCommand command)
        {
            command.Connection = mydb.getConnection;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table1 = new DataTable();
            adapter.Fill(table1);
            return table1;
        }

        public bool updateStudent(int Id, string fname, string lname, DateTime bdate, string gender, string phone, string address, MemoryStream picture)
        {
            SqlCommand command = new SqlCommand("UPDATE std SET fname=@fn,lname=@ln,bdate=@bdt,gender=@gdr,phone=@phn,address=@adrs,picture=@pic WHERE id=@ID", mydb.getConnection);

            command.Parameters.Add("@ID", SqlDbType.Int).Value = Id;
            command.Parameters.Add("@fn", SqlDbType.NVarChar).Value = fname;
            command.Parameters.Add("@ln", SqlDbType.NVarChar).Value = lname;
            command.Parameters.Add("@bdt", SqlDbType.DateTime).Value = bdate;
            command.Parameters.Add("@gdr", SqlDbType.VarChar).Value = gender;
            command.Parameters.Add("@phn", SqlDbType.VarChar).Value = phone;
            command.Parameters.Add("@adrs", SqlDbType.NVarChar).Value = address;
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


        public bool deleteStudent(int id)
        {
            SqlCommand command = new SqlCommand("DELETE FROM std WHERE id=@id", mydb.getConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = id;
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


        string execCount(string query)
        {
            SqlCommand command = new SqlCommand(query, mydb.getConnection);
            mydb.openConnection();
            string count = command.ExecuteScalar().ToString();
            return count;
        }
        public string totalStudent()
        {
            return execCount("SELECT COUNT(*) FROM STD");
        }
        public string totalMaleStudent()
        {
            return execCount("SELECT COUNT(*) FROM std WHERE gender ='Male'");
        }
        public string totalFemaleStudent()
        {
            return execCount("SELECT COUNT(*) FROM std WHERE gender ='Female'");
        }
    }
}
