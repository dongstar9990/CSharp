using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace hoangdz
{
    class Controller
    {
        private Model db = new Model();

        public DataTable GetAllProduct()
        {
            string sql = "select * from HangHoa";
            DataTable table = new DataTable(); // bảng rỗng
            table = db.GetTable(sql); // Model - có giá trị
            return table;
        }

        public DataTable GetAllNote()
        {
            string sql = "select * from LuuY";
            DataTable table = new DataTable();
            table = db.GetTable(sql);
            return table;
        }

        public void InsertProduct(int maHang, string tenHang, string ngaySX, int soLuong, int maLuuY)
        {
            String sql = "Insert Into HangHoa Values('" + maHang + "', '" + tenHang + "', '" + ngaySX + "', '" + soLuong + "', '" + maLuuY + "')";
            db.ExecuteNonQuery(sql);
              
        }
    }
}
