
using EMR.KyDienTu;
using System;
using System.Collections.Generic;
using PMS.Access;

namespace EMR_MAIN.DATABASE.Other
{
    public class PhieuCamDoanKhangSinh : ThongTinKy
    {
        public PhieuCamDoanKhangSinh()
        {
            TableName = "PHIEUCAMDOANKHANGSINH";
            TablePrimaryKeyName = "ID";
            IDMauPhieu = (int)DanhMucPhieu.CDKS;
            TenMauPhieu = DanhMucPhieu.CDKS.Description();
        }
        [MoTaDuLieu("Mã định danh")]
		public long ID { get; set; }
        [MoTaDuLieu("Mã quản lý: mã duy nhất trong 1 đợt khám chữa bệnh (kcb), không trùng giữa các đợt kcb khác nhau","",1)]
		public decimal MaQuanLy { get; set; }
        public string TenBenhVien { get; set; }
        public string KhoaPhong { get; set; }
        public string SoVaoVien { get; set; }
        public string NguoiNha_HoTen { get; set; }
        public string NguoiNha_Tuoi { get; set; }
        public string NguoiNha_GioiTinh { get; set; }
        public string NguoiNha_DanToc { get; set; }
        public string NguoiNha_NgoaiKieu { get; set; }
        public string NguoiNha_NgheNghiep { get; set; }
        public string NguoiNha_NoiLamViec { get; set; }
        public string NguoiNha_DiaChi { get; set; }
        public string HoTen { get; set; }
        public bool DongY { get; set; }
        public bool KhongDongY { get; set; }
        [MoTaDuLieu("Ngày tạo", null, 0, 0)]
		public DateTime NgayTao { get; set; }

        //public string MaSoKyTen { get; set; }
        //[MoTaDuLieu("Đã ký", null, 0, 0)]
		public bool DaKy { get; set; }
    }
    public class PhieuCamDoanKhangSinhFunc
    {
        public const string TableName = "PHIEUCAMDOANKHANGSINH";
        public const string TablePrimaryKeyName = "ID";

        public static long InsertOrUpDate(PhieuCamDoanKhangSinh PhieuCamDoanKhangSinh, MDB.MDBConnection MyConnection)
        {
            try
            {
                string sql = @"SELECT * FROM PHIEUCAMDOANKHANGSINH WHERE ID = :ID";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
                Command.Parameters.Add(new MDB.MDBParameter("ID", PhieuCamDoanKhangSinh.ID));
                MDB.MDBDataReader DataReader = Command.ExecuteReader();
                int rowCount = 0;
                while (DataReader.Read()) rowCount++;
                if (rowCount == 1)
                    sql = "UPDATE PHIEUCAMDOANKHANGSINH SET MAQUANLY = :MAQUANLY, TENBENHVIEN = :TENBENHVIEN, KHOAPHONG = :KHOAPHONG, SOVAOVIEN = :SOVAOVIEN, NGUOINHA_HOTEN = :NGUOINHA_HOTEN, NGUOINHA_TUOI = :NGUOINHA_TUOI, NGUOINHA_GIOITINH = :NGUOINHA_GIOITINH, NGUOINHA_DANTOC = :NGUOINHA_DANTOC, NGUOINHA_NGOAIKIEU = :NGUOINHA_NGOAIKIEU, NGUOINHA_NGHENGHIEP = :NGUOINHA_NGHENGHIEP, NGUOINHA_NOILAMVIEC = :NGUOINHA_NOILAMVIEC, NGUOINHA_DIACHI = :NGUOINHA_DIACHI, HOTEN = :HOTEN, DONGY = :DONGY, KHONGDONGY = :KHONGDONGY, NGAYTAO = :NGAYTAO WHERE ID = :ID";
                else
                    sql = "INSERT INTO PHIEUCAMDOANKHANGSINH (MAQUANLY, TENBENHVIEN, KHOAPHONG, SOVAOVIEN, NGUOINHA_HOTEN, NGUOINHA_TUOI, NGUOINHA_GIOITINH, NGUOINHA_DANTOC, NGUOINHA_NGOAIKIEU, NGUOINHA_NGHENGHIEP, NGUOINHA_NOILAMVIEC, NGUOINHA_DIACHI, HOTEN, DONGY, KHONGDONGY, NGAYTAO) VALUES (:MAQUANLY, :TENBENHVIEN, :KHOAPHONG, :SOVAOVIEN, :NGUOINHA_HOTEN, :NGUOINHA_TUOI, :NGUOINHA_GIOITINH, :NGUOINHA_DANTOC, :NGUOINHA_NGOAIKIEU, :NGUOINHA_NGHENGHIEP, :NGUOINHA_NOILAMVIEC, :NGUOINHA_DIACHI, :HOTEN, :DONGY, :KHONGDONGY, :NGAYTAO) RETURNING ID INTO :ID";
                Command = new MDB.MDBCommand(sql, MyConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MAQUANLY", PhieuCamDoanKhangSinh.MaQuanLy));
                Command.Parameters.Add(new MDB.MDBParameter("TENBENHVIEN", PhieuCamDoanKhangSinh.TenBenhVien));
                Command.Parameters.Add(new MDB.MDBParameter("KHOAPHONG", PhieuCamDoanKhangSinh.KhoaPhong));
                Command.Parameters.Add(new MDB.MDBParameter("SOVAOVIEN", PhieuCamDoanKhangSinh.SoVaoVien));
                Command.Parameters.Add(new MDB.MDBParameter("NGUOINHA_HOTEN", PhieuCamDoanKhangSinh.NguoiNha_HoTen));
                Command.Parameters.Add(new MDB.MDBParameter("NGUOINHA_TUOI", PhieuCamDoanKhangSinh.NguoiNha_Tuoi));
                Command.Parameters.Add(new MDB.MDBParameter("NGUOINHA_GIOITINH", PhieuCamDoanKhangSinh.NguoiNha_GioiTinh));
                Command.Parameters.Add(new MDB.MDBParameter("NGUOINHA_DANTOC", PhieuCamDoanKhangSinh.NguoiNha_DanToc));
                Command.Parameters.Add(new MDB.MDBParameter("NGUOINHA_NGOAIKIEU", PhieuCamDoanKhangSinh.NguoiNha_NgoaiKieu));
                Command.Parameters.Add(new MDB.MDBParameter("NGUOINHA_NGHENGHIEP", PhieuCamDoanKhangSinh.NguoiNha_NgheNghiep));
                Command.Parameters.Add(new MDB.MDBParameter("NGUOINHA_NOILAMVIEC", PhieuCamDoanKhangSinh.NguoiNha_NoiLamViec));
                Command.Parameters.Add(new MDB.MDBParameter("NGUOINHA_DIACHI", PhieuCamDoanKhangSinh.NguoiNha_DiaChi));
                Command.Parameters.Add(new MDB.MDBParameter("HOTEN", PhieuCamDoanKhangSinh.HoTen));
                Command.Parameters.Add(new MDB.MDBParameter("DONGY", PhieuCamDoanKhangSinh.DongY == true ? 1 : 0));
                Command.Parameters.Add(new MDB.MDBParameter("KHONGDONGY", PhieuCamDoanKhangSinh.KhongDongY == true ? 1 : 0));
                Command.Parameters.Add(new MDB.MDBParameter("NGAYTAO", PhieuCamDoanKhangSinh.NgayTao));
                Command.Parameters.Add(new MDB.MDBParameter("ID", PhieuCamDoanKhangSinh.ID));
                int n = Command.ExecuteNonQuery();
                long nextval = Convert.ToInt64((Command.Parameters["ID"] as MDB.MDBParameter).Value.ToString());
                return n > 0 ? nextval : 0;
            }
            catch (Exception ex)
            {
                XuLyLoi.Handle(ex);
            }
            return 0;
        }
        public static bool Delete(PhieuCamDoanKhangSinh PhieuCamDoanKhangSinh, MDB.MDBConnection MyConnection)
        {
            try
            {
                string sql = "DELETE PHIEUCAMDOANKHANGSINH WHERE ID = :ID";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
                Command.Parameters.Add(new MDB.MDBParameter("ID", PhieuCamDoanKhangSinh.ID));
                int n = Command.ExecuteNonQuery();
                return n > 0 ? true : false;
            }
            catch (Exception ex) { XuLyLoi.Handle(ex); }
            return false;
        }
        public static List<PhieuCamDoanKhangSinh> getlstData(MDB.MDBConnection MyConnection, string MaQuanLy)
        {
            List<PhieuCamDoanKhangSinh> lstData = new List<PhieuCamDoanKhangSinh>();
            try
            {
                string sql = "SELECT * FROM PHIEUCAMDOANKHANGSINH WHERE MAQUANLY = :MAQUANLY";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MAQUANLY", MaQuanLy));
                MDB.MDBDataReader DataReader = Command.ExecuteReader();
                while (DataReader.Read())
                {
                    PhieuCamDoanKhangSinh data = new PhieuCamDoanKhangSinh();
                    data.ID = Convert.ToInt64(DataReader.GetLong("ID"));
                    data.MaQuanLy = Convert.ToDecimal(DataReader.GetDecimal("MAQUANLY"));
                    data.TenBenhVien = DataReader["TENBENHVIEN"].ToString();
                    data.KhoaPhong = DataReader["KHOAPHONG"].ToString();
                    data.SoVaoVien = DataReader["SOVAOVIEN"].ToString();
                    data.NguoiNha_HoTen = DataReader["NGUOINHA_HOTEN"].ToString();
                    data.NguoiNha_Tuoi = DataReader["NGUOINHA_TUOI"].ToString();
                    data.NguoiNha_GioiTinh = DataReader["NGUOINHA_GIOITINH"].ToString();
                    data.NguoiNha_DanToc = DataReader["NGUOINHA_DANTOC"].ToString();
                    data.NguoiNha_NgoaiKieu = DataReader["NGUOINHA_NGOAIKIEU"].ToString();
                    data.NguoiNha_NgheNghiep = DataReader["NGUOINHA_NGHENGHIEP"].ToString();
                    data.NguoiNha_NoiLamViec = DataReader["NGUOINHA_NOILAMVIEC"].ToString();
                    data.NguoiNha_DiaChi = DataReader["NGUOINHA_DIACHI"].ToString();
                    data.HoTen = DataReader["HOTEN"].ToString();
                    data.DongY = DataReader["DONGY"].ToString().Equals("1") ? true : false;
                    data.KhongDongY = DataReader["KHONGDONGY"].ToString().Equals("1") ? true : false;
                    data.NgayTao = Convert.ToDateTime(DataReader.GetDate("NGAYTAO").ToString());
                    //data.MaSoKyTen = DataReader["masokyten"].ToString();
                    //data.DaKy = !string.IsNullOrEmpty(data.MaSoKyTen) ? true : false;
                    lstData.Add(data);
                }
            }
            catch (Exception ex) { XuLyLoi.Handle(ex); }
            return lstData;
        }
        public static PhieuCamDoanKhangSinh getData(MDB.MDBConnection MyConnection, string ID)
        {
            PhieuCamDoanKhangSinh data = new PhieuCamDoanKhangSinh();
            try
            {
                string sql = "SELECT * FROM PHIEUCAMDOANKHANGSINH WHERE ID = :ID";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
                Command.Parameters.Add(new MDB.MDBParameter("ID", ID));
                MDB.MDBDataReader DataReader = Command.ExecuteReader();
                while (DataReader.Read())
                {
                    data.ID = Convert.ToInt64(DataReader.GetLong("ID"));
                    data.MaQuanLy = Convert.ToDecimal(DataReader.GetDecimal("MAQUANLY"));
                    data.TenBenhVien = DataReader["TENBENHVIEN"].ToString();
                    data.KhoaPhong = DataReader["KHOAPHONG"].ToString();
                    data.SoVaoVien = DataReader["SOVAOVIEN"].ToString();
                    data.NguoiNha_HoTen = DataReader["NGUOINHA_HOTEN"].ToString();
                    data.NguoiNha_Tuoi = DataReader["NGUOINHA_TUOI"].ToString();
                    data.NguoiNha_GioiTinh = DataReader["NGUOINHA_GIOITINH"].ToString();
                    data.NguoiNha_DanToc = DataReader["NGUOINHA_DANTOC"].ToString();
                    data.NguoiNha_NgoaiKieu = DataReader["NGUOINHA_NGOAIKIEU"].ToString();
                    data.NguoiNha_NgheNghiep = DataReader["NGUOINHA_NGHENGHIEP"].ToString();
                    data.NguoiNha_NoiLamViec = DataReader["NGUOINHA_NOILAMVIEC"].ToString();
                    data.NguoiNha_DiaChi = DataReader["NGUOINHA_DIACHI"].ToString();
                    data.HoTen = DataReader["HOTEN"].ToString();
                    data.DongY = DataReader["DONGY"].ToString().Equals("1") ? true : false;
                    data.KhongDongY = DataReader["KHONGDONGY"].ToString().Equals("1") ? true : false;
                    data.NgayTao = Convert.ToDateTime(DataReader.GetDate("NGAYTAO").ToString());
                    //data.MaSoKyTen = DataReader["masokyten"].ToString();
                    //data.DaKy = !string.IsNullOrEmpty(data.MaSoKyTen) ? true : false;
                }
            }
            catch (Exception ex) { XuLyLoi.Handle(ex); }
            return data;
        }
    }
}
