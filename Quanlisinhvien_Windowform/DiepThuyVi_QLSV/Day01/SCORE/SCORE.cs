using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day01.SCORE
{
    class SCORES
    {
        MyDB mydb = new MyDB();
        public bool insertScore(int studentID, int courseID,float scoreValue,string description)
        {
            SqlCommand command = new SqlCommand("INSERT into score (student_id, course_id,student_score,description) values(@sid,@cid,@scr,@des)", mydb.getConnection);
            command.Parameters.Add("@sid", SqlDbType.Int).Value = studentID;
            command.Parameters.Add("@cid", SqlDbType.Int).Value = courseID;
            command.Parameters.Add("@scr", SqlDbType.Float).Value = scoreValue;
            command.Parameters.Add("@des", SqlDbType.VarChar).Value = description;
            mydb.openConnection();
            if(command.ExecuteNonQuery()==1)
            {
                return true;
            }else
            {
                return false;
            }

        }
        public bool studentScoreExist(int studentID, int courseID)
        {
            SqlCommand command = new SqlCommand("select * from score where student_id = @sid and course_id = @cid", mydb.getConnection);
            command.Parameters.Add("@sid", SqlDbType.Int).Value = studentID;
            command.Parameters.Add("@cid", SqlDbType.Int).Value = courseID;

            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            if (table.Rows.Count == 0)
                return false;
            else
                return true;
        }
        public DataTable getAvgScoreByCourse()
        {
            SqlCommand command = new SqlCommand();
            command.Connection = mydb.getConnection;
            command.CommandText = "select Course.label, avg(score.student_score) as averageGrade from course, score where course.id = score.course_id Group by course.label ";
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        public bool deleteScore(int studentID, int courseID)
        {
            SqlCommand command = new SqlCommand("Delete from score where student_id=@sid and course_id=@cid", mydb.getConnection);
            command.Parameters.Add("@sid", SqlDbType.Int).Value = studentID;
            command.Parameters.Add("@cid", SqlDbType.Int).Value = courseID;
           
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
        public DataTable getStudentScore()
        {
            SqlCommand command = new SqlCommand();
            command.Connection = mydb.getConnection;
            command.CommandText = "select score.student_id, std.fname, std.lname,score.course_id , course.label, score.student_score from std INNER JOIN score on std.id = score.student_id INNER JOIN course on score.course_id = course.id";
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        public DataTable getCourseScores(int courseid)
        {
            SqlCommand command = new SqlCommand();
            command.Connection = mydb.getConnection;
            command.CommandText="Select score.student_id,std.fname,std.lname,score.course_id,course.label,score.student_score from std inner join score on std.id=score.student_id inner join course on score.course_id = course.id where score.course_id ="+courseid;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        public DataTable getStudentScore(int studentID)
        {
            SqlCommand command = new SqlCommand();
            command.Connection = mydb.getConnection;
            command.CommandText = "Select score.student_id,std.fname,std.lname,score.course_id,course.label,score.student_score from std inner join score on std.id=score.student_id inner join course on score.course_id = course.id where score.student_id =" + studentID;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        public DataTable getresult ()
        {
            SqlCommand command = new SqlCommand();
            command.Connection = mydb.getConnection;
            command.CommandText = "Select score.student_id, std.fname,std.lname, sum(case when course.label = N'Toán 2' then student_score else 0 end) as 'Toán 2' ,sum(case when course.label = N'Kỹ thuật lập trình' then student_score else 0 end) as 'Kỹ thuật lập trình',sum(case when course.label = N'Lập trình hướng đối tượng' then student_score else 0 end) as'OOP' , sum(case when course.label = N'Lập trình Windows' then student_score else 0 end) as'Lập trình Windows',avg(score.student_score) as ĐTB from std INNER JOIN score on std.id = score.student_id INNER JOIN course on score.course_id = course.id group by student_id, fname,lname ";
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        public DataTable getfind(SqlCommand command)
        {
            command.Connection = mydb.getConnection;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table1 = new DataTable();
            adapter.Fill(table1);
            return table1;
        }
        string execCount(string query)
        {
            SqlCommand command = new SqlCommand(query, mydb.getConnection);
            mydb.openConnection();
            string count = command.ExecuteScalar().ToString();
            return count;
        }
        public string totalFail()
        {
            return execCount("select count(*) from ( Select score.student_id, std.fname,std.lname, sum(case when course.label = N'Toán 2' then student_score else 0 end) as 'Toán 2' ,sum(case when course.label = N'Kỹ thuật lập trình' then student_score else 0 end) as 'Kỹ thuật lập trình',sum(case when course.label = N'Lập trình hướng đối tượng' then student_score else 0 end) as'Lập trình hướng đối tượng' ,sum(case when course.label = N'Lập trình Windows' then student_score else 0 end) as'Lập trình Windows',avg(score.student_score) as ĐTB from std INNER JOIN score on std.id = score.student_id INNER JOIN course on score.course_id = course.id group by student_id, fname,lname) as a where a.ĐTB <5");

        }
        public string totalOrdinary()
        {
            return execCount("select count(*) from ( Select score.student_id, std.fname,std.lname, sum(case when course.label = N'Toán 2' then student_score else 0 end) as 'Toán 2' ,sum(case when course.label = N'Kỹ thuật lập trình' then student_score else 0 end) as 'Kỹ thuật lập trình',sum(case when course.label = N'Lập trình hướng đối tượng' then student_score else 0 end) as'Lập trình hướng đối tượng' ,sum(case when course.label = N'Lập trình Windows' then student_score else 0 end) as'Lập trình Windows',avg(score.student_score) as ĐTB from std INNER JOIN score on std.id = score.student_id INNER JOIN course on score.course_id = course.id group by student_id, fname,lname) as a where a.ĐTB >=5 and a.ĐTB <6.5");

        }
        public string totalGood()
        {
            return execCount("select count(*) from ( Select score.student_id, std.fname,std.lname, sum(case when course.label = N'Toán 2' then student_score else 0 end) as 'Toán 2' ,sum(case when course.label = N'Kỹ thuật lập trình' then student_score else 0 end) as 'Kỹ thuật lập trình',sum(case when course.label = N'Lập trình hướng đối tượng' then student_score else 0 end) as'Lập trình hướng đối tượng' ,sum(case when course.label = N'Lập trình Windows' then student_score else 0 end) as'Lập trình Windows',avg(score.student_score) as ĐTB from std INNER JOIN score on std.id = score.student_id INNER JOIN course on score.course_id = course.id group by student_id, fname,lname) as a where a.ĐTB >= 6.5 and a.ĐTB < 8");
        }
        public string totalVerygood()
        {
            return execCount("select count(*) from ( Select score.student_id, std.fname,std.lname, sum(case when course.label = N'Toán 2' then student_score else 0 end) as 'Toán 2' ,sum(case when course.label = N'Kỹ thuật lập trình' then student_score else 0 end) as 'Kỹ thuật lập trình',sum(case when course.label = N'Lập trình hướng đối tượng' then student_score else 0 end) as'Lập trình hướng đối tượng' ,sum(case when course.label = N'Lập trình Windows' then student_score else 0 end) as'Lập trình Windows',avg(score.student_score) as ĐTB from std INNER JOIN score on std.id = score.student_id INNER JOIN course on score.course_id = course.id group by student_id, fname,lname) as a where a.ĐTB >= 8");
        }
    }
}
