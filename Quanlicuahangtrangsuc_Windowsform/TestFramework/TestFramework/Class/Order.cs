using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace TestFramework
{
    class Order
    {
        MyData mydb = new MyData();
        //trực tiếp
        public bool addbill(int id, string phone, int amount, string product,  int price,  int total, DateTime daytime, int sale, int manv , int idpro)
        {
            SqlCommand command = new SqlCommand("insert into Bill(id,phone,amount,product,price,total,daytime,sale, manv,idpro) " +
                "values(@id,@phone,@amount, @product, @price, @total, @daytime, @sale, @manv,@idpro)", mydb.GetConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = id;
            command.Parameters.Add("@phone", SqlDbType.VarChar).Value = phone;
            command.Parameters.Add("@amount", SqlDbType.Int).Value = amount;
            command.Parameters.Add("@product", SqlDbType.NVarChar).Value = product;
            command.Parameters.Add("@price", SqlDbType.Float).Value = price;
            command.Parameters.Add("@total", SqlDbType.Float).Value = total;
            command.Parameters.Add("@daytime", SqlDbType.DateTime).Value = daytime;
            command.Parameters.Add("@sale", SqlDbType.Int).Value = sale;
            command.Parameters.Add("@manv", SqlDbType.Int).Value = manv;
            command.Parameters.Add("@idpro", SqlDbType.Int).Value = idpro;
            mydb.openConnection();

            if (command.ExecuteNonQuery() >= 1)
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

        public bool editbill(int id, int phone, int amount, string product, int price, int total, DateTime daytime, int sale, int manv)
        {
            SqlCommand command = new SqlCommand("update Bill set amount=@amount,product=@product,price=@price,total=@total,daytime=@daytime,sale=@sale,manv=@manv where id=@id", mydb.GetConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = id;
            command.Parameters.Add("@amount", SqlDbType.Int).Value = amount;
            command.Parameters.Add("@product", SqlDbType.NVarChar).Value = product;
            command.Parameters.Add("@price", SqlDbType.Float).Value = price;
            command.Parameters.Add("@total", SqlDbType.Float).Value = total;
            command.Parameters.Add("@daytime", SqlDbType.DateTime).Value = daytime;
            command.Parameters.Add("@sale", SqlDbType.Int).Value = sale;
            command.Parameters.Add("@manv", SqlDbType.Int).Value = manv;
            
            mydb.openConnection();
            if (command.ExecuteNonQuery() >= 1)
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
        public bool delteBill(int id)
        {
            SqlCommand command = new SqlCommand("delete from Bill where id=@id", mydb.GetConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = id;
            mydb.openConnection();
            if (command.ExecuteNonQuery() >= 1)
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
        public DataTable getBill(SqlCommand command)
        {
            command.Connection = mydb.GetConnection;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        public DataTable getOrders(SqlCommand command)
        {
            command.Connection = mydb.GetConnection;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        public bool updateCus(string phone, string name, string address)
        {
            SqlCommand command = new SqlCommand("update Customer set name =@name, addr =@address where phone=@phone", mydb.GetConnection);
            command.Parameters.Add("@address", SqlDbType.NVarChar).Value = address;
            command.Parameters.Add("@name", SqlDbType.NVarChar).Value = name;
            command.Parameters.Add("@phone", SqlDbType.NVarChar).Value = phone;
            mydb.openConnection();
            if (command.ExecuteNonQuery() >= 1)
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
