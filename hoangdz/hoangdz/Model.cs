using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace hoangdz
{
    class Model
    {
        public SqlConnection GetConnection()
        {
            return new SqlConnection(@"Data Source=DESKTOP-GFOAS18\SQLEXPRESS;Initial Catalog=QLHH;Integrated Security=True");
        }

        public DataTable GetTable(string sql)
        {
            SqlConnection conn = GetConnection();
            SqlDataAdapter adapter = new SqlDataAdapter(sql, conn); // đã có dữ liệu 
            DataTable table = new DataTable(); // bang rong
            adapter.Fill(table); 
            return table;
        }

        public void ExecuteNonQuery(string sql)
        {
            SqlConnection conn = GetConnection();
            conn.Open();
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
        }
    }
}
