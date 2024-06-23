using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace NCKH_WinformScan
{
    internal class dbConnection
    {
        SqlConnection sqlconn;
        string data = @"Data Source=LAPTOP-0G7N6LVV\TRANBATRIEU;Initial Catalog=ChuyenDiemSinhVien;Integrated Security=True";

        public dbConnection()
        {
            sqlconn = new SqlConnection(data);
            try
            {
                sqlconn.Open();
            }
            catch (Exception e)
            {
                DialogResult result = MessageBox.Show("Connect Database Fail","Connect DB",MessageBoxButtons.OK,MessageBoxIcon.Error);
                if (result == DialogResult.OK)
                {
                    sqlconn.Close();
                }
                throw e;
            }
        }

        /// <summary>
        /// Lấy tất cả các bảng
        /// </summary>
        /// <param name="tenBang"></param>
        /// <returns></returns>
        public DataTable getBang(string tenBang)
        {
            DataTable dt = new DataTable();
            SqlCommand sqlcmdBang = new SqlCommand("sp_get_table", sqlconn);

            sqlcmdBang.CommandType = CommandType.StoredProcedure;
            sqlcmdBang.Parameters.AddWithValue("@TableName", tenBang);
            try
            {
                SqlDataAdapter adapter = new SqlDataAdapter(sqlcmdBang);
                adapter.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Chua Lay Duoc Du Lieu Bang");
                throw ex;
            }
            return dt;
        }

        /// <summary>
        /// Lấy tên Khóa học mới
        /// </summary>
        /// <returns></returns>
        public DataTable KHMoi()
        {
            DataTable dt = new DataTable();
            SqlCommand sqlcmd = new SqlCommand("getTenKHNew", sqlconn);
            sqlcmd.CommandType = CommandType.StoredProcedure;

            try
            {
                SqlDataAdapter adapt = new SqlDataAdapter(sqlcmd);
                adapt.Fill(dt);
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return dt;
        }

        /// <summary>
        /// Lấy tên khóa học mới
        /// </summary>
        /// <param name="khoaMoi"></param>
        /// <returns></returns>
        public DataTable KHOld(string khoaMoi)
        {
            DataTable dt = new DataTable();
            SqlCommand sqlcmd = new SqlCommand("getTenKHOld", sqlconn);
            sqlcmd.CommandType = CommandType.StoredProcedure;
            sqlcmd.Parameters.AddWithValue("@KhoaMoi", khoaMoi);
            try
            {
                SqlDataAdapter adap = new SqlDataAdapter(sqlcmd);
                adap.Fill(dt);
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return dt;
        }

        /// <summary>
        /// Lấy thông tin học phần theo khóa
        /// </summary>
        /// <param name="tenKH"></param>
        /// <param name="maCN"></param>
        /// <returns></returns>
        public DataTable getInfoHP(string tenKH, string maCN)
        {
            DataTable dt = new DataTable();
            SqlCommand sqlcmd = new SqlCommand("InfoHP", sqlconn);
            sqlcmd.CommandType = CommandType.StoredProcedure;
            sqlcmd.Parameters.AddWithValue("@TenKH", tenKH);
            sqlcmd.Parameters.AddWithValue("@MaCN", maCN);
            try
            {
                SqlDataAdapter adap = new SqlDataAdapter(sqlcmd);
                adap.Fill(dt);  
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return dt;
        }

        /// <summary>
        /// Lấy tên Các học phần
        /// </summary>
        /// <param name="maHP"></param>
        /// <returns></returns>
        public string getTenHP(string maHP)
        {
            string tenHP = "";
            SqlCommand sqlcmd = new SqlCommand("getTenHP",sqlconn);

            sqlcmd.CommandType = CommandType.StoredProcedure;
            sqlcmd.Parameters.AddWithValue("@MaHP", maHP);
            try
            {
                tenHP = (string)sqlcmd.ExecuteScalar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Chưa Lấy Được Dữ Liệu Tên Học Phần");
                throw ex;
            }
            return tenHP;
        }


        /// <summary>
        /// Thông tin Sinh viên chuyển điểm
        /// </summary>
        /// <param name="maSV"></param>
        /// <param name="hoTen"></param>
        /// <param name="ngaySinh"></param>
        /// <param name="lop"></param>
        /// <param name="nghanh"></param>
        /// <param name="khoa"></param>
        /// <param name="bac"></param>
        /// <param name="quequan"></param>
        /// <param name="dclienlac"></param>
        /// <param name="email"></param>
        /// <param name="sodt"></param>
        /// <param name="maHP"></param>
        /// <param name="maHPC"></param>
        /// <returns></returns>
        public int ThongTinSinhVien(string maSV, string hoTen, string ngaySinh, string lop, string nghanh, string khoa, string bac, string quequan, string dclienlac,string email, string sodt)
        {
            int ketQua = -1;
            SqlCommand sqlcmdInfo = new SqlCommand("ThemSinhVien", sqlconn);
            sqlcmdInfo.CommandType = CommandType.StoredProcedure;
            sqlcmdInfo.Parameters.AddWithValue("@MaSV", maSV);
            sqlcmdInfo.Parameters.AddWithValue("@HoTen", hoTen);
            sqlcmdInfo.Parameters.AddWithValue("@NgaySinh", DbType.DateTime).Value = DateTime.ParseExact(ngaySinh,"dd/MM/yyyy",CultureInfo.InvariantCulture);
            sqlcmdInfo.Parameters.AddWithValue("@Lop", lop);
            sqlcmdInfo.Parameters.AddWithValue("@Nghanh", nghanh);
            sqlcmdInfo.Parameters.AddWithValue("@Khoa", khoa);
            sqlcmdInfo.Parameters.AddWithValue("@Bac", bac);
            sqlcmdInfo.Parameters.AddWithValue("@QueQuan", quequan);
            sqlcmdInfo.Parameters.AddWithValue("@DiaChiLienHe", dclienlac);
            sqlcmdInfo.Parameters.AddWithValue("@Email", email);
            sqlcmdInfo.Parameters.AddWithValue("@DienThoai", sodt);
            try
            {
                ketQua = sqlcmdInfo.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return ketQua;
        }
        
        /// <summary>
        /// Hàm Chuyển Điểm Sinh viên
        /// </summary>
        /// <param name="maSV"></param>
        /// <param name="maHP"></param>
        /// <param name="diem"></param>
        /// <returns></returns>
        public int SinhVienChuyenDiem(string maSV, string maHP, float diem)
        {
            int ketQua = -1;
            SqlCommand sqlcmdSinhVienCD = new SqlCommand("ThemSVCN", sqlconn);
            sqlcmdSinhVienCD.CommandType = CommandType.StoredProcedure;
            sqlcmdSinhVienCD.Parameters.AddWithValue("@MaSV", maSV);
            sqlcmdSinhVienCD.Parameters.AddWithValue("@MaHP", maHP);
            sqlcmdSinhVienCD.Parameters.AddWithValue("@Diem", diem);
            try
            {
                ketQua = sqlcmdSinhVienCD.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return ketQua;
        }
        

    }
}
