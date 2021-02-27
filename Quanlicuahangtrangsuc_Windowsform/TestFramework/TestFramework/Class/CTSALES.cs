using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;


namespace TestFramework
{
    class CTSALES
    {
        MyData mydb = new MyData();
        public bool insertsale(int id, DateTime startdate, DateTime finishdate, string name, int sale)
        {
            SqlCommand command = new SqlCommand("insert into Sales(saleid,startdate,finishdate,name,sale) values (@id,@sd,@fd,@name,@sale)", mydb.GetConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = id;
            command.Parameters.Add("@sd", SqlDbType.DateTime).Value = startdate;
            command.Parameters.Add("@fd", SqlDbType.DateTime).Value = finishdate;
            command.Parameters.Add("@name", SqlDbType.NVarChar).Value = name;
            command.Parameters.Add("@sale", SqlDbType.Int).Value = sale;
   

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

        public bool updatesale(DateTime startdate, DateTime finishdate, string name, int sale)
        {
            SqlCommand command = new SqlCommand("update Sales set startdate =@sd, finishdate =@fd,sale=@sale where name =@name", mydb.GetConnection);

            command.Parameters.Add("@sd", SqlDbType.DateTime).Value = startdate;
            command.Parameters.Add("@fd", SqlDbType.DateTime).Value = finishdate;
            command.Parameters.Add("@name", SqlDbType.NVarChar).Value = name;
            command.Parameters.Add("@sale", SqlDbType.Int).Value = sale;
 
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

        public bool deleteProduct(string name)
        {
            SqlCommand command = new SqlCommand("delete from Sales where name=@name", mydb.GetConnection);
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

        public DataTable getAllSales(SqlCommand command)
        {
            command.Connection = mydb.GetConnection;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        public DataTable getInf(int id)
        {
            SqlCommand command = new SqlCommand("select sale from Sales where saleid=@id", mydb.GetConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = id;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;

        }
    
        public DataTable getall()
        {
            SqlCommand command = new SqlCommand("select saleid,name from Sales", mydb.GetConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
    }
}
