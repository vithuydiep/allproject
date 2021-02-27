using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.IO;

namespace TestFramework
{
    class PRODUCT
    {
        MyData mydb = new MyData();
        public bool addProduct(int id, string name, int price, string description, string type, DateTime inputday, int amount, MemoryStream picture)
        {
            SqlCommand command = new SqlCommand("insert into Product (id,name,price,description,type,inputday,amount, curnumber ,picture,state) values(@id,@name,@price,@des,@ty,@ind,@am ,@cur,@pic,@state)", mydb.GetConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = id;
            command.Parameters.Add("@name", SqlDbType.NVarChar).Value = name;
            command.Parameters.Add("@price", SqlDbType.Int).Value = price;
            command.Parameters.Add("@des", SqlDbType.NVarChar).Value = description;
            command.Parameters.Add("@ty", SqlDbType.NVarChar).Value = type;
            command.Parameters.Add("@ind", SqlDbType.DateTime).Value = inputday;
            command.Parameters.Add("@am", SqlDbType.Int).Value = amount;
            command.Parameters.Add("@cur", SqlDbType.Int).Value = amount;
            command.Parameters.Add("@pic", SqlDbType.Image).Value = picture.ToArray();
            command.Parameters.Add("@state", SqlDbType.Int).Value = 1;
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

        public bool updateProduct(int id, string name, int price, string description, string type, DateTime inputday, int amount, MemoryStream picture)
        {
            SqlCommand command = new SqlCommand("update Product set name=@name, price=@price, description=@des,type=@ty,inputday =@ind,amount=@am,picture =@pic where id=@id ", mydb.GetConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = id;
            command.Parameters.Add("@name", SqlDbType.VarChar).Value = name;
            command.Parameters.Add("@price", SqlDbType.Int).Value = price;
            command.Parameters.Add("@des", SqlDbType.NVarChar).Value = description;
            command.Parameters.Add("@ty", SqlDbType.NVarChar).Value = type;
            command.Parameters.Add("@ind", SqlDbType.DateTime).Value = inputday;
            command.Parameters.Add("@am", SqlDbType.Int).Value = amount;
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
        public bool updateSLsale(int id, int number)
        {
            SqlCommand command = new SqlCommand("update Product set curnumber = @cur where id=@id", mydb.GetConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = id;
            command.Parameters.Add("@cur", SqlDbType.Int).Value = number;

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




        public bool deleteProduct(int id)
        {
            SqlCommand command = new SqlCommand("update Product set state = 0 where id =@id ", mydb.GetConnection);
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
        string execCount(string query)
        {
            SqlCommand command = new SqlCommand(query, mydb.GetConnection);
            mydb.openConnection();
            string count = command.ExecuteScalar().ToString();
            return count;
        }

        public DataTable getProducts(SqlCommand command)
        {
            command.Connection = mydb.GetConnection;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        public DataTable getAllProducts()
        {
            SqlCommand command = new SqlCommand("select DISTINCT type from Product ", mydb.GetConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        public DataTable getProductById(int id)
        {
            SqlCommand command = new SqlCommand("select * from Product where id=@id", mydb.GetConnection);
            command.Parameters.Add("@id", SqlDbType.VarChar).Value = id;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;

        }
        public DataTable getInfbyPc(MemoryStream picture)
        {
            SqlCommand command = new SqlCommand(" select * from foo where convert(varbinary,picture.img) = convert(varbinary,@pic.img)", mydb.GetConnection);
            command.Parameters.Add("@pic", SqlDbType.Image).Value = picture.ToArray();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;

        }
    }
}
