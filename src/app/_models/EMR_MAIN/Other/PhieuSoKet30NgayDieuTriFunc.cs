
using EMR.KyDienTu;
using PMS.Access;
using System;
using System.Collections.Generic;

namespace EMR_MAIN.DATABASE.Other
{
    public class PhieuSoKet30NgayDieuTriFunc
    {
        public const string TableName = "PhieuSoKet30NgayDieuTri";
        public const string TablePrimaryKeyName = "id";

        public static long InsertOrUpdate(MDB.MDBConnection MyConnection, PhieuSoKet30NgayDieuTri PhieuSoKet30NgayDieuTri)
        {
            try
            {
                string sql = @"SELECT * FROM PhieuSoKet30NgayDieuTri WHERE ID = :ID";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
                Command.Parameters.Add(new MDB.MDBParameter("ID", PhieuSoKet30NgayDieuTri.ID));
                MDB.MDBDataReader DataReader = Command.ExecuteReader();
                int rowCount = 0;
                while (DataReader.Read()) rowCount++;
                if (rowCount == 1)
                    sql = "UPDATE PhieuSoKet30NgayDieuTri SET MAQUANLY = :MAQUANLY, THOIGIANTAO = :THOIGIANTAO, THOIGIANBATDAU = :THOIGIANBATDAU, THOIGIANKETTHUC = :THOIGIANKETTHUC, SOYTE = :SOYTE, BENHVIEN = :BENHVIEN, MASO = :MASO, SOVAOVIEN = :SOVAOVIEN, HOTEN = :HOTEN, TUOI = :TUOI, GIOITINH = :GIOITINH, DIACHI = :DIACHI, KHOA = :KHOA, Buong = :Buong, Giuong = :Giuong, CHANDOAN = :CHANDOAN, DIENBIENLAMSANG = :DIENBIENLAMSANG, XETNGHIEM = :XETNGHIEM, QUATRINHDIEUTRI = :QUATRINHDIEUTRI, DANHGIAKETQUA = :DANHGIAKETQUA, HUONGDIEUTRI = :HUONGDIEUTRI, TRUONGKHOA_NGAY = :TRUONGKHOA_NGAY, TRUONGKHOA_THANG = :TRUONGKHOA_THANG, TRUONGKHOA_NAM = :TRUONGKHOA_NAM, TRUONGKHOA = :TRUONGKHOA, BACSI_NGAY = :BACSI_NGAY, BACSI_THANG = :BACSI_THANG, BACSI_NAM = :BACSI_NAM, BACSIDIEUTRI = :BACSIDIEUTRI, MANVBACSIDIEUTRI = :MANVBACSIDIEUTRI, MANVTRUONGKHOA = :MANVTRUONGKHOA, NgayTruongKhoaKy = :NgayTruongKhoaKy, NgayBacSiKy = :NgayBacSiKy WHERE ID = :ID";
                else
                    sql = "INSERT INTO PhieuSoKet30NgayDieuTri (MAQUANLY, THOIGIANTAO, THOIGIANBATDAU, THOIGIANKETTHUC, SOYTE, BENHVIEN, MASO, SOVAOVIEN, HOTEN, TUOI, GIOITINH, DIACHI, KHOA, Buong, Giuong, CHANDOAN, DIENBIENLAMSANG, XETNGHIEM, QUATRINHDIEUTRI, DANHGIAKETQUA, HUONGDIEUTRI, TRUONGKHOA_NGAY, TRUONGKHOA_THANG, TRUONGKHOA_NAM, TRUONGKHOA, BACSI_NGAY, BACSI_THANG, BACSI_NAM, BACSIDIEUTRI, MANVBACSIDIEUTRI, MANVTRUONGKHOA, NgayTruongKhoaKy, NgayBacSiKy) VALUES (:MAQUANLY, :THOIGIANTAO, :THOIGIANBATDAU, :THOIGIANKETTHUC, :SOYTE, :BENHVIEN, :MASO, :SOVAOVIEN, :HOTEN, :TUOI, :GIOITINH, :DIACHI, :KHOA, :Buong, :Giuong, :CHANDOAN, :DIENBIENLAMSANG, :XETNGHIEM, :QUATRINHDIEUTRI, :DANHGIAKETQUA, :HUONGDIEUTRI, :TRUONGKHOA_NGAY, :TRUONGKHOA_THANG, :TRUONGKHOA_NAM, :TRUONGKHOA, :BACSI_NGAY, :BACSI_THANG, :BACSI_NAM, :BACSIDIEUTRI, :MANVBACSIDIEUTRI, :MANVTRUONGKHOA, :NgayTruongKhoaKy, :NgayBacSiKy) RETURNING ID INTO :ID";
                Command = new MDB.MDBCommand(sql, MyConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MAQUANLY", PhieuSoKet30NgayDieuTri.MaQuanLy));
                Command.Parameters.Add(new MDB.MDBParameter("THOIGIANTAO", PhieuSoKet30NgayDieuTri.ThoiGianTao));
                Command.Parameters.Add(new MDB.MDBParameter("THOIGIANBATDAU", PhieuSoKet30NgayDieuTri.ThoiGianBatDau));
                Command.Parameters.Add(new MDB.MDBParameter("THOIGIANKETTHUC", PhieuSoKet30NgayDieuTri.ThoiGianKetThuc));
                Command.Parameters.Add(new MDB.MDBParameter("SOYTE", PhieuSoKet30NgayDieuTri.SoYTe));
                Command.Parameters.Add(new MDB.MDBParameter("BENHVIEN", PhieuSoKet30NgayDieuTri.BenhVien));
                Command.Parameters.Add(new MDB.MDBParameter("MASO", PhieuSoKet30NgayDieuTri.MaSo));
                Command.Parameters.Add(new MDB.MDBParameter("SOVAOVIEN", PhieuSoKet30NgayDieuTri.SoVaoVien));
                Command.Parameters.Add(new MDB.MDBParameter("HOTEN", PhieuSoKet30NgayDieuTri.HoTen));
                Command.Parameters.Add(new MDB.MDBParameter("TUOI", PhieuSoKet30NgayDieuTri.Tuoi));
                Command.Parameters.Add(new MDB.MDBParameter("GIOITINH", PhieuSoKet30NgayDieuTri.GioiTinh));
                Command.Parameters.Add(new MDB.MDBParameter("DIACHI", PhieuSoKet30NgayDieuTri.DiaChi));
                Command.Parameters.Add(new MDB.MDBParameter("KHOA", PhieuSoKet30NgayDieuTri.Khoa));
                Command.Parameters.Add(new MDB.MDBParameter("Buong", PhieuSoKet30NgayDieuTri.Buong));
                Command.Parameters.Add(new MDB.MDBParameter("Giuong", PhieuSoKet30NgayDieuTri.Giuong));
                Command.Parameters.Add(new MDB.MDBParameter("CHANDOAN", PhieuSoKet30NgayDieuTri.ChanDoan));
                Command.Parameters.Add(new MDB.MDBParameter("DIENBIENLAMSANG", PhieuSoKet30NgayDieuTri.DienBienLamSang));
                Command.Parameters.Add(new MDB.MDBParameter("XETNGHIEM", PhieuSoKet30NgayDieuTri.XetNghiem));
                Command.Parameters.Add(new MDB.MDBParameter("QUATRINHDIEUTRI", PhieuSoKet30NgayDieuTri.QuaTrinhDieuTri));
                Command.Parameters.Add(new MDB.MDBParameter("DANHGIAKETQUA", PhieuSoKet30NgayDieuTri.DanhGiaKetQua));
                Command.Parameters.Add(new MDB.MDBParameter("HUONGDIEUTRI", PhieuSoKet30NgayDieuTri.HuongDieuTri));
                Command.Parameters.Add(new MDB.MDBParameter("TRUONGKHOA_NGAY", ""));
                Command.Parameters.Add(new MDB.MDBParameter("TRUONGKHOA_THANG", ""));
                Command.Parameters.Add(new MDB.MDBParameter("TRUONGKHOA_NAM", ""));
                Command.Parameters.Add(new MDB.MDBParameter("TRUONGKHOA", PhieuSoKet30NgayDieuTri.TruongKhoa));
                Command.Parameters.Add(new MDB.MDBParameter("BACSI_NGAY", ""));
                Command.Parameters.Add(new MDB.MDBParameter("BACSI_THANG", ""));
                Command.Parameters.Add(new MDB.MDBParameter("BACSI_NAM", ""));
                Command.Parameters.Add(new MDB.MDBParameter("BACSIDIEUTRI", PhieuSoKet30NgayDieuTri.BacSiDieuTri));
                Command.Parameters.Add(new MDB.MDBParameter("MANVBACSIDIEUTRI", PhieuSoKet30NgayDieuTri.MaNVBacSiDieuTri));
                Command.Parameters.Add(new MDB.MDBParameter("MANVTRUONGKHOA", PhieuSoKet30NgayDieuTri.MaNVTruongKhoa));
                Command.Parameters.Add(new MDB.MDBParameter("NgayTruongKhoaKy", PhieuSoKet30NgayDieuTri.NgayTruongKhoaKy));
                Command.Parameters.Add(new MDB.MDBParameter("NgayBacSiKy", PhieuSoKet30NgayDieuTri.NgayBacSiKy));
                Command.Parameters.Add(new MDB.MDBParameter("ID", PhieuSoKet30NgayDieuTri.ID));
                int n = Command.ExecuteNonQuery();
                long nextval = Convert.ToInt64((Command.Parameters["ID"] as MDB.MDBParameter).Value);
                return n > 0 ? nextval : 0;
            }
            catch (Exception ex) { XuLyLoi.Handle(ex); }
            return 0;
        }
        public static List<PhieuSoKet30NgayDieuTri> getData(MDB.MDBConnection MyConnection, string MaQuanLy)
        {
            List<PhieuSoKet30NgayDieuTri> lstData = new List<PhieuSoKet30NgayDieuTri>();
            try
            {
                string sql = "SELECT * FROM PhieuSoKet30NgayDieuTri WHERE MAQUANLY = :MAQUANLY";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MAQUANLY", MaQuanLy));
                MDB.MDBDataReader DataReader = Command.ExecuteReader();
                while (DataReader.Read())
                {
                    PhieuSoKet30NgayDieuTri data = new PhieuSoKet30NgayDieuTri();
                    data.ID = Convert.ToInt64(DataReader.GetLong("ID"));
                    data.MaQuanLy = Convert.ToDecimal(DataReader.GetDecimal("MAQUANLY"));
                    data.ThoiGianTao = Convert.ToDateTime(DataReader.GetDate("THOIGIANTAO"));
                    data.ThoiGianBatDau = Convert.ToDateTime(DataReader.GetDate("THOIGIANBATDAU"));
                    data.ThoiGianKetThuc = Convert.ToDateTime(DataReader.GetDate("THOIGIANKETTHUC"));
                    data.SoYTe = DataReader["SOYTE"].ToString();
                    data.BenhVien = DataReader["BENHVIEN"].ToString();
                    data.MaSo = DataReader["MASO"].ToString();
                    data.SoVaoVien = DataReader["SOVAOVIEN"].ToString();
                    data.HoTen = DataReader["HOTEN"].ToString();
                    data.Tuoi = DataReader["TUOI"].ToString();
                    data.GioiTinh = DataReader["GIOITINH"].ToString();
                    data.DiaChi = DataReader["DIACHI"].ToString();
                    data.Khoa = DataReader["KHOA"].ToString();
                    data.Buong = DataReader["Buong"].ToString();
                    data.Giuong = DataReader["Giuong"].ToString();
                    data.ChanDoan = DataReader["CHANDOAN"].ToString();
                    data.DienBienLamSang = DataReader["DIENBIENLAMSANG"].ToString();
                    data.XetNghiem = DataReader["XETNGHIEM"].ToString();
                    data.QuaTrinhDieuTri = DataReader["QUATRINHDIEUTRI"].ToString();
                    data.DanhGiaKetQua = DataReader["DANHGIAKETQUA"].ToString();
                    data.HuongDieuTri = DataReader["HUONGDIEUTRI"].ToString();
                    data.TruongKhoa = DataReader["TRUONGKHOA"].ToString();
                    data.BacSiDieuTri = DataReader["BACSIDIEUTRI"].ToString();
                    data.MaNVBacSiDieuTri = DataReader["MANVBACSIDIEUTRI"].ToString();
                    data.MaNVTruongKhoa = DataReader["MANVTRUONGKHOA"].ToString();
                    if (DataReader["NgayTruongKhoaKy"] != DBNull.Value)
                    {
                        data.NgayTruongKhoaKy = Convert.ToDateTime(DataReader["NgayTruongKhoaKy"]);
                    }
                    else
                    {
                        try
                        {
                            string Nam = DataReader["TRUONGKHOA_NAM"].ToString();
                            int NamInt = string.IsNullOrEmpty(Nam) ? DateTime.Now.Year : Convert.ToInt16(Nam);
                            string Thang = DataReader["TRUONGKHOA_THANG"].ToString();
                            int ThangInt = string.IsNullOrEmpty(Thang) ? DateTime.Now.Month : Convert.ToInt16(Thang);
                            string Ngay = DataReader["TRUONGKHOA_NGAY"].ToString();
                            int NgayInt = string.IsNullOrEmpty(Ngay) ? DateTime.Now.Day : Convert.ToInt16(Ngay);
                            data.NgayTruongKhoaKy = new DateTime(NamInt, ThangInt, NgayInt);
                        }
                        catch { }
                    }
                    if (DataReader["NgayBacSiKy"] != DBNull.Value)
                    {
                        data.NgayBacSiKy = Convert.ToDateTime(DataReader["NgayBacSiKy"]);
                    }
                    else
                    {
                        try
                        {
                            string Nam = DataReader["BACSI_NAM"].ToString();
                            int NamInt = string.IsNullOrEmpty(Nam) ? DateTime.Now.Year : Convert.ToInt16(Nam);
                            string Thang = DataReader["BACSI_THANG"].ToString();
                            int ThangInt = string.IsNullOrEmpty(Thang) ? DateTime.Now.Month : Convert.ToInt16(Thang);
                            string Ngay = DataReader["BACSI_NGAY"].ToString();
                            int NgayInt = string.IsNullOrEmpty(Ngay) ? DateTime.Now.Day : Convert.ToInt16(Ngay);
                            data.NgayBacSiKy = new DateTime(NamInt, ThangInt, NgayInt);
                        }
                        catch { }
                    }
                    data.MaSoKy = DataReader["masokyten"].ToString();
                    data.DaKy = !string.IsNullOrEmpty(data.MaSoKy) ? true : false;
                    lstData.Add(data);
                }
            }
            catch (Exception ex) { XuLyLoi.Handle(ex); }
            return lstData;
        }
        public static bool delete(MDB.MDBConnection MyConnection, PhieuSoKet30NgayDieuTri PhieuSoKet30NgayDieuTri)
        {
            try
            {
                string sql = "DELETE PhieuSoKet30NgayDieuTri WHERE ID = :ID";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
                Command.Parameters.Add(new MDB.MDBParameter("ID", PhieuSoKet30NgayDieuTri.ID));
                int n = Command.ExecuteNonQuery();
                return n > 0 ? true : false;
            }
            catch (Exception ex) { XuLyLoi.Handle(ex); }
            return false;
        }
    }
    public class PhieuSoKet30NgayDieuTri : ThongTinKy
    {
        public PhieuSoKet30NgayDieuTri()
        {
            TableName = "PHIEUSOKET30NGAYDIEUTRI";
            TablePrimaryKeyName = "ID";
            IDMauPhieu = (int)DanhMucPhieu.SK30NDT;
            TenMauPhieu = DanhMucPhieu.SK30NDT.Description();
        }
        [MoTaDuLieu("Mã định danh")]
		public long ID { get; set; }
        [MoTaDuLieu("Mã quản lý: mã duy nhất trong 1 đợt khám chữa bệnh (kcb), không trùng giữa các đợt kcb khác nhau","",1)]
		public decimal MaQuanLy { get; set; }
        public DateTime ThoiGianTao { get; set; }
        public DateTime ThoiGianBatDau { get; set; }
        public DateTime ThoiGianKetThuc { get; set; }
		[MoTaDuLieu("Sở Y Tế")]
		public string SoYTe { get; set; }
        [MoTaDuLieu("Bệnh viện")]
		public string BenhVien { get; set; }
        public string MaSo { get; set; }
        public string SoVaoVien { get; set; }
        public string HoTen { get; set; }
        [MoTaDuLieu("Tuổi bệnh nhân")]
		public string Tuoi { get; set; }
        [MoTaDuLieu("Giới tính bệnh nhân")]
		public string GioiTinh { get; set; }
        [MoTaDuLieu("Địa chỉ nhà bệnh nhân")]
		public string DiaChi { get; set; }
        [MoTaDuLieu("Khoa")]
		public string Khoa { get; set; }
        [MoTaDuLieu("Buồng")]
		public string Buong { get; set; }
        [MoTaDuLieu("Giường")]
		public string Giuong { get; set; }
        [MoTaDuLieu("Chẩn đoán bệnh")]
		public string ChanDoan { get; set; }
        public string DienBienLamSang { get; set; }
        public string XetNghiem { get; set; }
        public string QuaTrinhDieuTri { get; set; }
        public string DanhGiaKetQua { get; set; }
        public string HuongDieuTri { get; set; }
        [MoTaDuLieu("Trưởng khoa")]
		public string TruongKhoa { get; set; }
        [MoTaDuLieu("Bác sỹ điều trị")]
		public string BacSiDieuTri { get; set; }
        [MoTaDuLieu("Mã trưởng khoa")]
		public string MaNVTruongKhoa { get; set; }
        [MoTaDuLieu("Mã bác sỹ điều trị")]
		public string MaNVBacSiDieuTri { get; set; }
        public DateTime NgayTruongKhoaKy { get; set; }
        public DateTime NgayBacSiKy { get; set; }

        //public string MaSoKyTen { get; set; }
        [MoTaDuLieu("Đã ký", null, 0, 0)]
		public bool DaKy { get; set; }
    }
}
