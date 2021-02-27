using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day01.COURSE
{
    public class COURSES
    {
        MyDB mydb = new MyDB();
        public bool insertCourse (int id, string label , int period , string description)
        {
            SqlCommand command = new SqlCommand("insert into course(id,label,period,description) " +
                "values(@id,@label,@pe,@des)", mydb.getConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = id;
            command.Parameters.Add("@label", SqlDbType.NVarChar).Value = label;
            command.Parameters.Add("@pe", SqlDbType.Int).Value = period;
            command.Parameters.Add("@des", SqlDbType.NVarChar).Value = description;

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
        public bool updateCourse(int id, string label,int period, string description)
        {
            SqlCommand command = new SqlCommand("update course set label=@label,period =@pe,description=@des where id=@id", mydb.getConnection);

            command.Parameters.Add("@id", SqlDbType.Int).Value = id;
            command.Parameters.Add("@label", SqlDbType.NVarChar).Value = label;
            command.Parameters.Add("@pe", SqlDbType.Int).Value = period;
            command.Parameters.Add("@des", SqlDbType.NVarChar).Value = description;

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
        
        public bool removeCourse(int id)
        {
            SqlCommand command = new SqlCommand("Delete from course where id=@id", mydb.getConnection);

            command.Parameters.Add("@id", SqlDbType.Int).Value = id;
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
        //tìm course trùng tên
        public bool checkCourseName(string label,int id =0 )
        {
            SqlCommand command = new SqlCommand("Select * from course where label=@label and id <>@id", mydb.getConnection);
            command.Parameters.Add("@label", SqlDbType.NVarChar).Value = label;
            command.Parameters.Add("@id", SqlDbType.Int).Value = id;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            if (table.Rows.Count > 0)
                return false;
            else
                return true;
      
        }


        public DataTable getAllCourses()
        {
            SqlCommand command = new SqlCommand("select * from course ", mydb.getConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;

        }

        public DataTable getCourseById(int id)
        {
            SqlCommand command = new SqlCommand("select * from course where id=@id", mydb.getConnection);
            command.Parameters.Add("@id", SqlDbType.VarChar).Value = id;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;

        }
        string execCount(string query)
        {
            SqlCommand command = new SqlCommand(query, mydb.getConnection);
            mydb.openConnection();
            string count = command.ExecuteScalar().ToString();
            return count;
        }
        public string totalCourses()
        {
            return execCount("SELECT COUNT(*) FROM course");
        }
    }
}
