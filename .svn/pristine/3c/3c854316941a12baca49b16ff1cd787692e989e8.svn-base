
using EMR.KyDienTu;
using PMS.Access;
using System;
using System.Collections.Generic;
using System.Data;

namespace EMR_MAIN.DATABASE.Other
{
    public class PhieuTomTatThongTinDieuTri : ThongTinKy
    {
        public PhieuTomTatThongTinDieuTri()
        {
            TableName = "PhieuTTThongTinDieuTri";
            TablePrimaryKeyName = "ID";
            IDMauPhieu = (int)DanhMucPhieu.PTTTTDT;
            TenMauPhieu = DanhMucPhieu.PTTTTDT.Description();
        }
        [MoTaDuLieu("Mã định danh")]
		public long ID { get; set; }
        [MoTaDuLieu("Mã quản lý: mã duy nhất trong 1 đợt khám chữa bệnh (kcb), không trùng giữa các đợt kcb khác nhau","",1)]
		public decimal MaQuanLy { get; set; }
        [MoTaDuLieu("Mã bệnh nhân")]
		public string MaBenhNhan { get; set; }
        [MoTaDuLieu("Mã bệnh án")]
		public string MaBenhAn { get; set; }
        [MoTaDuLieu("Sở Y Tế")]
		public string SoYTe { get; set; }
        [MoTaDuLieu("Bệnh viện")]
		public string BenhVien { get; set; }
        public string MaSo { get; set; }
        public string SoVaoVien { get; set; }
        [MoTaDuLieu("Họ và tên bệnh nhân")]
		public string TenBenhNhan { get; set; }
        [MoTaDuLieu("Tuổi bệnh nhân")]
		public string Tuoi { get; set; }
        public DateTime? NgaySinh { get; set; }
        [MoTaDuLieu("Giới tính bệnh nhân")]
		public string GioiTinh { get; set; }
        [MoTaDuLieu("Nghề nghiệp")]
		public string NgheNghiep { get; set; }
        public string SoNha { get; set; }
        public string ThonPho { get; set; }
        public string XaPhuong { get; set; }
        public string QuanHuyen { get; set; }
        public string TinhThanhPho { get; set; }
        [MoTaDuLieu("Chẩn đoán bệnh")]
		public string ChanDoan { get; set; }
        public string TaiBien { get; set; }
        public string DieuTri { get; set; }

        public DateTime? NgayVaoVien { get; set; }
        public DateTime? NgayVaoVien_Gio { get; set; }
        [MoTaDuLieu("Mã trưởng khoa")]
		public string MaNVTruongKhoa { get; set; }
        [MoTaDuLieu("Mã bác sỹ điều trị")]
		public string MaNVBacSiDieuTri { get; set; }
        [MoTaDuLieu("Trưởng khoa")]
		public string TruongKhoa { get; set; }
        [MoTaDuLieu("Bác sỹ điều trị")]
		public string BacSiDieuTri { get; set; }
        [MoTaDuLieu("Người tạo", null, 0, 0)]
		public string NguoiTao { get; set; }
        [MoTaDuLieu("Người sửa", null, 0, 0)]
		public string NguoiSua { get; set; }
        [MoTaDuLieu("Ngày tạo", null, 0, 0)]
		public DateTime NgayTao { get; set; }
        [MoTaDuLieu("Ngày sửa", null, 0, 0)]
		public DateTime NgaySua { get; set; }
        [MoTaDuLieu("Chọn", null, 0, 0)]
		public bool Chon { get; set; }
        //public string MaSoKyTen { get; set; }
        [MoTaDuLieu("Đã ký", null, 0, 0)]
		public bool DaKy { get; set; }
    }
    public class PhieuTomTatThongTinDieuTriFunc
    {
        public const string TableName = "PhieuTTThongTinDieuTri";
        public const string TablePrimaryKeyName = "ID";

        public static List<PhieuTomTatThongTinDieuTri> GetListData(MDB.MDBConnection _OracleConnection, decimal maquanly)
        {
            List<PhieuTomTatThongTinDieuTri> list = new List<PhieuTomTatThongTinDieuTri>();
            try
            {
                string sql = @"SELECT * FROM PhieuTTThongTinDieuTri where MaQuanLy = :MaQuanLy";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, _OracleConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", maquanly));
                MDB.MDBDataReader DataReader = Command.ExecuteReader();
                while (DataReader.Read())
                {
                    PhieuTomTatThongTinDieuTri data = new PhieuTomTatThongTinDieuTri();
                    data.ID = Convert.ToInt64(DataReader.GetLong("ID").ToString());
                    data.MaQuanLy = maquanly;

                    data.MaBenhNhan = XemBenhAn._HanhChinhBenhNhan.MaBenhNhan;
                    data.MaBenhAn = XemBenhAn._ThongTinDieuTri.MaBenhAn;
                    data.TenBenhNhan = XemBenhAn._HanhChinhBenhNhan.TenBenhNhan;
                    data.Tuoi = XemBenhAn._HanhChinhBenhNhan.Tuoi;
                    data.NgaySinh = XemBenhAn._HanhChinhBenhNhan.NgaySinh;
                    data.GioiTinh = XemBenhAn._HanhChinhBenhNhan.GioiTinh.Description();
                    data.BenhVien = XemBenhAn._HanhChinhBenhNhan.BenhVien;
                    data.SoVaoVien = XemBenhAn._ThongTinDieuTri.SoNhapVien;
                    data.SoYTe = XemBenhAn._HanhChinhBenhNhan.SoYTe;


                    data.DieuTri = DataReader["DieuTri"].ToString();
                    data.TaiBien = DataReader["TaiBien"].ToString();
                    data.ChanDoan = DataReader["ChanDoan"].ToString();
                    data.NgheNghiep = DataReader["NgheNghiep"].ToString();

                    data.SoNha = DataReader["SoNha"].ToString();
                    data.ThonPho = DataReader["ThonPho"].ToString();
                    data.XaPhuong = DataReader["XaPhuong"].ToString();
                    data.QuanHuyen = DataReader["QuanHuyen"].ToString();
                    data.TinhThanhPho = DataReader["TinhThanhPho"].ToString();

                    data.MaNVTruongKhoa = DataReader["MaNVTruongKhoa"].ToString();
                    data.MaNVBacSiDieuTri = DataReader["MaNVBacSiDieuTri"].ToString();
                    data.TruongKhoa = DataReader["TruongKhoa"].ToString();
                    data.BacSiDieuTri = DataReader["BacSiDieuTri"].ToString();

                    data.NgayVaoVien = Convert.ToDateTime(DataReader["NgayVaoVien"] == DBNull.Value ? DateTime.Now : DataReader["NgayVaoVien"]);
                    data.NgayVaoVien_Gio = data.NgayVaoVien;

                    data.NgayTao = Convert.ToDateTime(DataReader["NGAYTAO"] == DBNull.Value ? DateTime.Now : DataReader["NGAYTAO"]);
                    data.NguoiTao = DataReader["NGUOITAO"].ToString();
                    data.NgaySua = Convert.ToDateTime(DataReader["NGAYSUA"] == DBNull.Value ? DateTime.Now : DataReader["NGAYSUA"]);
                    data.NguoiSua = DataReader["NGUOISUA"].ToString();

                    data.MaSoKy = DataReader["masokyten"].ToString();
                    data.DaKy = !string.IsNullOrEmpty(data.MaSoKy) ? true : false;
                    list.Add(data);
                }
            }
            catch (Exception ex) { XuLyLoi.Handle(ex); }
            return list;
        }
        public static bool DeleteByIDPhieu(MDB.MDBConnection oracleConnection, decimal IDBienBan)
        {
            try
            {
                string sql = "";
                MDB.MDBCommand oracleCommand;
                sql = @"DELETE FROM PhieuTTThongTinDieuTri WHERE ID =" + IDBienBan;
                using (oracleCommand = new MDB.MDBCommand(sql, oracleConnection))
                {
                    oracleCommand.ExecuteNonQuery();
                }
                return true;
            }
            catch (Exception ex)
            {
                XuLyLoi.LogError(ex);
            }
            return false;
        }
        public static DataSet GetDataSet(MDB.MDBConnection MyConnection, long IDBienBan)
        {
            string sql = @"SELECT P.*, T.SoNhapVien, T.Khoa , T.NgayVaoVien ,  T.MaKhoa, T.MaBenhAn,     
				H.TUOI,H.SoYTe, H.BENHVIEN, 
				 H.GIOITINH,  H.TenBenhNhan, H.maBenhNhan
			  FROM PhieuTTThongTinDieuTri P 
				Left JOIN THONGTINDIEUTRI T ON P.MAQUANLY = T.MAQUANLY
				Left JOIN HANHCHINHBENHNHAN H ON T.MABENHNHAN = H.MABENHNHAN
			  where ID = :IDPhieu";
            MDB.MDBCommand Command;
            MDB.MDBDataAdapter adt;
            using (Command = new MDB.MDBCommand(sql, MyConnection))
            {
                Command.Parameters.Add(new MDB.MDBParameter("IDPhieu", IDBienBan));
                adt = new MDB.MDBDataAdapter(Command);
            }
            var ds = new DataSet();
            adt.Fill(ds, "TBL");

            DateTime NgayVaoVien = Convert.ToDateTime(ds.Tables[0].Rows[0]["NgayVaoVien"]);
            ds.Tables[0].AddColumn("GioiTinh", typeof(int));
            ds.Tables[0].Rows[0]["GioiTinh"] = XemBenhAn._HanhChinhBenhNhan.GioiTinh;

            ds.Tables[0].AddColumn("Gio", typeof(int));
            ds.Tables[0].Rows[0]["Gio"] = NgayVaoVien.Hour;

            ds.Tables[0].AddColumn("Phut", typeof(int));
            ds.Tables[0].Rows[0]["Phut"] = NgayVaoVien.Minute;

            ds.Tables[0].AddColumn("NgayKhamBenh", typeof(string));
            ds.Tables[0].Rows[0]["NgayKhamBenh"] = NgayVaoVien.ToString("dd/MM/yyyy");

            ds.Tables[0].AddColumn("ThongTinNgayThang", typeof(string));
            ds.Tables[0].Rows[0]["ThongTinNgayThang"] = "Ngày " + DateTime.Now.Day + " tháng " + DateTime.Now.Month + " năm " + DateTime.Now.Year;

            ds.Tables[0].AddColumn("Tuoi1", typeof(int));
            ds.Tables[0].AddColumn("Tuoi2", typeof(int));

            string Tuoi = XemBenhAn._HanhChinhBenhNhan.Tuoi;
            ds.Tables[0].Rows[0]["Tuoi1"] = Tuoi.Length < 7 ? "0" : Tuoi.Substring(0, 1);
            ds.Tables[0].Rows[0]["Tuoi2"] = Tuoi.Length < 7 ? Tuoi.Substring(0, 1) : Tuoi.Substring(1, 1);

            ds.Tables[0].AddColumn("Ngay1", typeof(int));
            ds.Tables[0].AddColumn("Ngay2", typeof(int));
            ds.Tables[0].AddColumn("Thang1", typeof(int));
            ds.Tables[0].AddColumn("Thang2", typeof(int));
            ds.Tables[0].AddColumn("Nam1", typeof(int));
            ds.Tables[0].AddColumn("Nam2", typeof(int));
            ds.Tables[0].AddColumn("Nam3", typeof(int));
            ds.Tables[0].AddColumn("Nam4", typeof(int));

            string NgaySinh = XemBenhAn._HanhChinhBenhNhan.NgaySinh?.ToString("dd/MM/yyyy");
            ds.Tables[0].Rows[0]["Ngay1"] = NgaySinh.Split('/')[0].Substring(0, 1);
            ds.Tables[0].Rows[0]["Ngay2"] = NgaySinh.Split('/')[0].Substring(1, 1);

            ds.Tables[0].Rows[0]["Thang1"] = NgaySinh.Split('/')[1].Substring(0, 1);
            ds.Tables[0].Rows[0]["Thang2"] = NgaySinh.Split('/')[1].Substring(1, 1);

            ds.Tables[0].Rows[0]["Nam1"] = NgaySinh.Split('/')[2].Substring(0, 1);
            ds.Tables[0].Rows[0]["Nam2"] = NgaySinh.Split('/')[2].Substring(1, 1);
            ds.Tables[0].Rows[0]["Nam3"] = NgaySinh.Split('/')[2].Substring(2, 1);
            ds.Tables[0].Rows[0]["Nam4"] = NgaySinh.Split('/')[2].Substring(3, 1);

            return ds;
        }
        public static bool InsertOrUpdate(MDB.MDBConnection MyConnection, ref PhieuTomTatThongTinDieuTri ketQua)
        {
            try
            {
                string sql = @"INSERT INTO PhieuTTThongTinDieuTri
                (
                    MaQuanLy,
                    NgheNghiep,
                    SoNha,
                    ThonPho,
                    XaPhuong,
                    QuanHuyen,
                    TinhThanhPho,
                    NgayVaoVien,
                    ChanDoan,
                    DieuTri,
                    TaiBien,
                    MaNVTruongKhoa,
                    MaNVBacSiDieuTri,
                    TruongKhoa,
                    BacSiDieuTri,
                    NGUOITAO,
                    NGUOISUA,
                    NGAYTAO,
                    NGAYSUA)  VALUES
                 (
				    :MaQuanLy,
                    :NgheNghiep,
                    :SoNha,
                    :ThonPho,
                    :XaPhuong,
                    :QuanHuyen,
                    :TinhThanhPho,
                    :NgayVaoVien,
                    :ChanDoan,
                    :DieuTri,
                    :TaiBien,
                    :MaNVTruongKhoa,
                    :MaNVBacSiDieuTri,
                    :TruongKhoa,
                    :BacSiDieuTri,
                    :NGUOITAO,
                    :NGUOISUA,
                    :NGAYTAO,
                    :NGAYSUA
                 )  RETURNING ID INTO :ID";
                if (ketQua.ID != 0)
                {
                    sql = @"UPDATE PhieuTTThongTinDieuTri SET 
                    MaQuanLy = :MaQuanLy,
                    NgheNghiep = :NgheNghiep,
                    SoNha = :SoNha,
                    ThonPho = :ThonPho,
                    XaPhuong = :XaPhuong,
                    QuanHuyen = :QuanHuyen,
                    TinhThanhPho = :TinhThanhPho,
                    NgayVaoVien = :NgayVaoVien,
                    ChanDoan = :ChanDoan,
                    DieuTri = :DieuTri,
                    TaiBien = :TaiBien,
                    MaNVTruongKhoa = :MaNVTruongKhoa,
                    MaNVBacSiDieuTri = :MaNVBacSiDieuTri,
                    TruongKhoa = :TruongKhoa,
                    BacSiDieuTri = :BacSiDieuTri,
                    NGUOISUA = :NGUOISUA,
                    NGAYSUA = :NGAYSUA 
                    WHERE ID = " + ketQua.ID;
                }
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);

                Command.Parameters.Add(new MDB.MDBParameter("NGUOISUA", ketQua.NguoiSua));
                Command.Parameters.Add(new MDB.MDBParameter("NGAYSUA", ketQua.NgaySua));

                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", ketQua.MaQuanLy));

                Command.Parameters.Add(new MDB.MDBParameter("NgheNghiep", ketQua.NgheNghiep));
                Command.Parameters.Add(new MDB.MDBParameter("SoNha", ketQua.SoNha));
                Command.Parameters.Add(new MDB.MDBParameter("ThonPho", ketQua.ThonPho));
                Command.Parameters.Add(new MDB.MDBParameter("XaPhuong", ketQua.XaPhuong));
                Command.Parameters.Add(new MDB.MDBParameter("QuanHuyen", ketQua.QuanHuyen));
                Command.Parameters.Add(new MDB.MDBParameter("TinhThanhPho", ketQua.TinhThanhPho));
                DateTime? NgayVaoVien = ketQua.NgayVaoVien.HasValue ? ketQua.NgayVaoVien.Value.Add(new TimeSpan(0, 0, 0)) : (DateTime?)null;
                var NgayGio = NgayVaoVien;
                if (NgayVaoVien != null)
                {
                    var Gio = ketQua.NgayVaoVien_Gio.HasValue ? ketQua.NgayVaoVien_Gio.Value.TimeOfDay : new TimeSpan(0, 0, 0);
                    NgayGio = NgayVaoVien + Gio;
                }
                Command.Parameters.Add(new MDB.MDBParameter("NgayVaoVien", NgayGio));

                Command.Parameters.Add(new MDB.MDBParameter("ChanDoan", ketQua.ChanDoan));
                Command.Parameters.Add(new MDB.MDBParameter("DieuTri", ketQua.DieuTri));
                Command.Parameters.Add(new MDB.MDBParameter("TaiBien", ketQua.TaiBien));
                Command.Parameters.Add(new MDB.MDBParameter("MaNVTruongKhoa", ketQua.MaNVTruongKhoa));
                Command.Parameters.Add(new MDB.MDBParameter("MaNVBacSiDieuTri", ketQua.MaNVBacSiDieuTri));
                Command.Parameters.Add(new MDB.MDBParameter("TruongKhoa", ketQua.TruongKhoa));
                Command.Parameters.Add(new MDB.MDBParameter("BacSiDieuTri", ketQua.BacSiDieuTri));

                if (ketQua.ID == 0)
                {
                    Command.Parameters.Add(new MDB.MDBParameter("ID", ketQua.ID));
                    Command.Parameters.Add(new MDB.MDBParameter("NGUOITAO", ketQua.NguoiTao));
                    Command.Parameters.Add(new MDB.MDBParameter("NGAYTAO", ketQua.NgayTao));
                }
                Command.BindByName = true;
                int n = Command.ExecuteNonQuery();
                if (ketQua.ID == 0)
                {
                    long nextval = Convert.ToInt64((Command.Parameters["ID"] as MDB.MDBParameter).Value);
                    ketQua.ID = nextval;
                }
                return n > 0 ? true : false;
            }
            catch (Exception ex)
            {
                XuLyLoi.LogError(ex);
            }
            return false;
        }
       
        public static string ConDBNull(object dbVal)
        {
            string ret = "";
            if (dbVal == null)
            {
                return ret;
            }
            ret = dbVal.ToString();
            return ret;
        }
        public static decimal ConDB_Decimal(object dbVal, decimal valDefault = 0)
        {
            decimal ret = valDefault;
            if (dbVal == null)
            {
                return ret;
            }
            bool isSuccess = decimal.TryParse(dbVal.ToString(), out ret);
            if (!isSuccess)
            {
                return valDefault;
            }
            return ret;
        }
        public static int ConDB_Int(object dbVal, int valDefault = 0)
        {
            int ret = valDefault;
            if (dbVal == null)
            {
                return ret;
            }
            bool isSuccess = int.TryParse(dbVal.ToString(), out ret);
            if (!isSuccess)
            {
                return valDefault;
            }
            return ret;
        }
        public static DateTime ConDB_DateTime(object dbVal)
        {
            DateTime ret = DateTime.MinValue;
            if (dbVal == null)
            {
                return ret;
            }
            bool isSuccess = DateTime.TryParse(dbVal.ToString(), out ret);
            return ret;
        }
    }
}
