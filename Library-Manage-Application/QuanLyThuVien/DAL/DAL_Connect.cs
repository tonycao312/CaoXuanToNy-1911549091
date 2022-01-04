using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class DAL_Connect
    {
        public SqlConnection _con = new SqlConnection("Data Source=LAPTOP-2E1V7TIA\\SQLEXPRESS;Initial Catalog=QuanLyThuVien;Integrated Security=True");
    }
}
