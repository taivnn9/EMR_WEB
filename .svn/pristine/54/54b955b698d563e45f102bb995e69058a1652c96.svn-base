using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EMR.KyDienTu;

namespace EMR_MAIN.DATABASE.Other
{
    public class KeHoachChamSocNguoiBenh_PhieuMau
    {
        [MoTaDuLieu("Mã nhân viên")]
		public string MaNhanVien { get; set; }
        [MoTaDuLieu("Mã phiếu mẫu")]
		public int MaPhieuMau { get; set; }
        public string TenPhieuMau { get; set; }
        [MoTaDuLieu("Diễn biến bệnh")]
		public string DienBienBenh { get; set; }
        [MoTaDuLieu("Y lệnh")]
		public string YLenh { get; set; }
        [MoTaDuLieu("Thực hiện y lệnh")]
		public string ThucHienYLenh { get; set; }
    }

    public class KeHoachChamSocNguoiBenh_PhieuMauFunc
    {
        public static bool InsertOrUpdate(MDB.MDBConnection MyConnection, KeHoachChamSocNguoiBenh_PhieuMau data)
        {
            string sqlSearch = @"SELECT * FROM KEHOACHCHAMSOCNGUOIBENH_PM WHERE MANHANVIEN = :MANHANVIEN AND MAPHIEUMAU = :MAPHIEUMAU";
            MDB.MDBCommand CommandSearch = new MDB.MDBCommand(sqlSearch, MyConnection);
            CommandSearch.Parameters.Add(new MDB.MDBParameter("MANHANVIEN", data.MaNhanVien));
            CommandSearch.Parameters.Add(new MDB.MDBParameter("MAPHIEUMAU", data.MaPhieuMau));
            int count = CommandSearch.ExecuteNonQuery();
            string sql;
            if (count > 0)
            {
                sql = "UPDATE KEHOACHCHAMSOCNGUOIBENH_PM SET"
                    + " TENPHIEUMAU = :TENPHIEUMAU"
                    + " DIENBIENBENH = :DIENBIENBENH"
                    + " YLENH = :YLENH"
                    + " THUCHIENYLENH = :THUCHIENYLENH"
                    + " WHERE MANHANVIEN = :MANHANVIEN"
                    + " AND MAPHIEUMAU = :MAPHIEUMAU";
            }
            else
            {
                sql = "INSERT INTO KEHOACHCHAMSOCNGUOIBENH_PM"
                    + " (MANHANVIEN, MAPHIEUMAU, TENPHIEUMAU, DIENBIENBENH, YLENH, THUCHIENYLENH)"
                    + " VALUES (:MANHANVIEN, :MAPHIEUMAU, :TENPHIEUMAU, :DIENBIENBENH, :YLENH, :THUCHIENYLENH)";
            }
            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
            Command.Parameters.Add(new MDB.MDBParameter("MANHANVIEN", data.MaNhanVien));
            Command.Parameters.Add(new MDB.MDBParameter("MAPHIEUMAU", data.MaPhieuMau));
            Command.Parameters.Add(new MDB.MDBParameter("TENPHIEUMAU", data.TenPhieuMau));
            Command.Parameters.Add(new MDB.MDBParameter("DIENBIENBENH", data.DienBienBenh));
            Command.Parameters.Add(new MDB.MDBParameter("YLENH", data.YLenh));
            Command.Parameters.Add(new MDB.MDBParameter("THUCHIENYLENH", data.ThucHienYLenh));
            return Command.ExecuteNonQuery() > 0;
        }
        public static bool Delete(MDB.MDBConnection MyConnection, string MaNhanVien, string MaPhieuMau)
        {
            string sql = @"DELETE FROM KEHOACHCHAMSOCNGUOIBENH_PM WHERE MANHANVIEN = :MANHANVIEN AND MAPHIEUMAU = :MAPHIEUMAU";
            MDB.MDBCommand cmd = new MDB.MDBCommand(sql, MyConnection);
            cmd.Parameters.Add(new MDB.MDBParameter("MANHANVIEN", MaNhanVien));
            cmd.Parameters.Add(new MDB.MDBParameter("MAPHIEUMAU", MaPhieuMau));
            return cmd.ExecuteNonQuery() > 0;
        }
        public static bool DeleteByUser(MDB.MDBConnection MyConnection, string MaNhanVien)
        {
            string sql = @"DELETE FROM KEHOACHCHAMSOCNGUOIBENH_PM WHERE MANHANVIEN = :MANHANVIEN";
            MDB.MDBCommand cmd = new MDB.MDBCommand(sql, MyConnection);
            cmd.Parameters.Add(new MDB.MDBParameter("MANHANVIEN", MaNhanVien));
            return cmd.ExecuteNonQuery() > 0;
        }
        public static int GetLatestID(MDB.MDBConnection MyConnection, string MaNhanVien)
        {
            try
            {
                string sql = string.Format("SELECT * FROM ({0}) WHERE ROWNUM = 1",
                    "SELECT MAPHIEUMAU FROM KEHOACHCHAMSOCNGUOIBENH_PM WHERE MANHANVIEN = :MANHANVIEN ORDER BY MAPHIEUMAU DESC");
                MDB.MDBCommand cmd = new MDB.MDBCommand(sql, MyConnection);
                cmd.Parameters.Add(new MDB.MDBParameter("MANHANVIEN", MaNhanVien));
                var latestID = cmd.ExecuteScalar();
                return Convert.ToInt32(latestID);
            }
            catch { return 1; }
        }
        public static List<KeHoachChamSocNguoiBenh_PhieuMau> GetData(MDB.MDBConnection MyConnection, string MaNhanVien)
        {
            List<KeHoachChamSocNguoiBenh_PhieuMau> lstData = new List<KeHoachChamSocNguoiBenh_PhieuMau>();
            string sql = "SELECT * FROM KEHOACHCHAMSOCNGUOIBENH_PM WHERE MANHANVIEN = :MANHANVIEN ORDER BY TENPHIEUMAU";
            MDB.MDBCommand cmd = new MDB.MDBCommand(sql, MyConnection);
            cmd.Parameters.Add(new MDB.MDBParameter("MANHANVIEN", MaNhanVien));
            MDB.MDBDataReader DataReader = cmd.ExecuteReader();
            int intTemp = 0;
            while (DataReader.Read())
            {
                lstData.Add(new KeHoachChamSocNguoiBenh_PhieuMau
                {
                    MaNhanVien = DataReader["MaNhanVien"].ToString(),
                    MaPhieuMau = int.TryParse(DataReader["MaPhieuMau"].ToString(), out intTemp) ? intTemp : 0,
                    TenPhieuMau = DataReader["TenPhieuMau"].ToString(),
                    DienBienBenh = DataReader["DIENBIENBENH"].ToString(),
                    YLenh = DataReader["YLENH"].ToString(),
                    ThucHienYLenh = DataReader["ThucHienYLENH"].ToString(),
                });
            }
            return lstData;
        }
        public static List<KeHoachChamSocNguoiBenh_PhieuMau> GetData(MDB.MDBConnection MyConnection, string MaNhanVien, string MaPhieuMau)
        {
            List<KeHoachChamSocNguoiBenh_PhieuMau> lstData = new List<KeHoachChamSocNguoiBenh_PhieuMau>();
            string sql = "SELECT * FROM KEHOACHCHAMSOCNGUOIBENH_PM WHERE MANHANVIEN = :MANHANVIEN AND MAPHIEUMAU = :MAPHIEUMAU ORDER BY TENPHIEUMAU";
            MDB.MDBCommand cmd = new MDB.MDBCommand(sql, MyConnection);
            cmd.Parameters.Add(new MDB.MDBParameter("MANHANVIEN", MaNhanVien));
            cmd.Parameters.Add(new MDB.MDBParameter("MAPHIEUMAU", MaPhieuMau));
            MDB.MDBDataReader DataReader = cmd.ExecuteReader();
            while (DataReader.Read())
            {
                lstData.Add(new KeHoachChamSocNguoiBenh_PhieuMau
                {
                    MaNhanVien = DataReader["MaNhanVien"].ToString(),
                    MaPhieuMau = int.Parse(DataReader["MaPhieuMau"].ToString()),
                    TenPhieuMau = DataReader["TenPhieuMau"].ToString(),
                    DienBienBenh = DataReader["DIENBIENBENH"].ToString(),
                    YLenh = DataReader["YLENH"].ToString(),
                    ThucHienYLenh = DataReader["ThucHienYLENH"].ToString(),
                });
            }
            return lstData;
        }
    }
}