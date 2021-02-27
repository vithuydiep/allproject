using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace TestFramework.Class
{
    class KH
    {
        MyData mydb = new MyData();
        public DataTable getName()
        {
            SqlCommand command = new SqlCommand("select id, name from Customer", mydb.GetConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
    }
}
