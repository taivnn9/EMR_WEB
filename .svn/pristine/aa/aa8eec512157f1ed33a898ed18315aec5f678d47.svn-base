
using EMR.KyDienTu;
using PMS.Access;
using System;
using System.Collections.Generic;
using System.Data;

namespace EMR_MAIN.DATABASE.Other
{
    public class ThuThuatDatCatheterTMDui : ThongTinKy
    {
        public ThuThuatDatCatheterTMDui()
        {
            TableName = "ThuThuatDatCatheterTMDui";
            TablePrimaryKeyName = "ID";
            IDMauPhieu = (int)DanhMucPhieu.PTTTDCTMD;
            TenMauPhieu = DanhMucPhieu.PTTTDCTMD.Description();
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
        [MoTaDuLieu("Khoa")]
		public string Khoa { get; set; }
        [MoTaDuLieu("Bệnh viện")]
		public string BenhVien { get; set; }
        public string MaSo { get; set; }
        public string SoVaoVien { get; set; }
        [MoTaDuLieu("Họ và tên bệnh nhân")]
		public string TenBenhNhan { get; set; }
        [MoTaDuLieu("Tuổi bệnh nhân")]
		public string Tuoi { get; set; }
        [MoTaDuLieu("Giới tính bệnh nhân")]
		public string GioiTinh { get; set; }
        [MoTaDuLieu("Buồng")]
		public string Buong { get; set; }
        [MoTaDuLieu("Giường")]
		public string Giuong { get; set; }
        public DateTime? ThuThuatLuc { get; set; }
        public DateTime? ThuThuatLuc_Gio { get; set; }
        public DateTime? VaoVienLuc { get; set; }
        public DateTime? VaoVienLuc_Gio { get; set; }
        [MoTaDuLieu("Chẩn đoán trước khi làm thủ thuật")]
		public string ChanDoanTruocTT { get; set; }
        [MoTaDuLieu("Chẩn đoán bệnh sau khi làm thủ thuật")]
		public string ChanDoanSauTT { get; set; }
        public string PhuongPhapThuThuat { get; set; }
        public string LoaiThuThuat { get; set; }
        public string PhuongPhapVoCam { get; set; }
        public string BacSiThuThuat { get; set; }
        public string MaBacSiThuThuat { get; set; }
        public string BacSiGayMe { get; set; }
        public string MaBacSiGayMe { get; set; }
        public string DanLuu { get; set; }
        public string Bac { get; set; }
        public DateTime? NgayRut { get; set; }
        public DateTime? NgayCatChi { get; set; }
        public string Khac { get; set; }
        public string LuonCatheter { get; set; }
        public string Fr { get; set; }

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
    public class ThuThuatDatCatheterTMDuiFunc
    {
        public const string TableName = "ThuThuatDatCatheterTMDui";
        public const string TablePrimaryKeyName = "ID";

        public static List<ThuThuatDatCatheterTMDui> GetListData(MDB.MDBConnection _OracleConnection, decimal maquanly)
        {
            List<ThuThuatDatCatheterTMDui> list = new List<ThuThuatDatCatheterTMDui>();
            try
            {
                string sql = @"SELECT * FROM ThuThuatDatCatheterTMDui where MaQuanLy = :MaQuanLy";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, _OracleConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", maquanly));
                MDB.MDBDataReader DataReader = Command.ExecuteReader();
                while (DataReader.Read())
                {
                    ThuThuatDatCatheterTMDui data = new ThuThuatDatCatheterTMDui();
                    data.ID = Convert.ToInt64(DataReader.GetLong("ID").ToString());
                    data.MaQuanLy = maquanly;

                    data.MaBenhNhan = XemBenhAn._HanhChinhBenhNhan.MaBenhNhan;
                    data.MaBenhAn = XemBenhAn._ThongTinDieuTri.MaBenhAn;
                    data.TenBenhNhan = XemBenhAn._HanhChinhBenhNhan.TenBenhNhan;
                    data.SoVaoVien = XemBenhAn._ThongTinDieuTri.SoNhapVien;
                    data.GioiTinh = XemBenhAn._HanhChinhBenhNhan.GioiTinh.Description();
                    data.Khoa = XemBenhAn._ThongTinDieuTri.Khoa;
                    data.Tuoi = XemBenhAn._HanhChinhBenhNhan.Tuoi;
                    data.ThuThuatLuc = Convert.ToDateTime(DataReader["ThuThuatLuc"] == DBNull.Value ? DateTime.Now : DataReader["ThuThuatLuc"]);
                    data.ThuThuatLuc_Gio = data.ThuThuatLuc;
                    data.VaoVienLuc = Convert.ToDateTime(DataReader["VaoVienLuc"] == DBNull.Value ? DateTime.Now : DataReader["VaoVienLuc"]);
                    data.VaoVienLuc_Gio = data.VaoVienLuc;

                    data.Buong = DataReader["Buong"].ToString();
                    data.Giuong = DataReader["Giuong"].ToString();
                    data.ChanDoanTruocTT = DataReader["ChanDoanTruocTT"].ToString();
                    data.ChanDoanSauTT = DataReader["ChanDoanSauTT"].ToString();
                    data.PhuongPhapThuThuat = DataReader["PhuongPhapThuThuat"].ToString();
                    data.LoaiThuThuat = DataReader["LoaiThuThuat"].ToString();
                    data.PhuongPhapVoCam = DataReader["PhuongPhapVoCam"].ToString();
                    data.BacSiThuThuat = DataReader["BacSiThuThuat"].ToString();
                    data.MaBacSiThuThuat = DataReader["MaBacSiThuThuat"].ToString();
                    data.MaBacSiGayMe = DataReader["MaBacSiGayMe"].ToString();
                    data.BacSiGayMe = DataReader["BacSiGayMe"].ToString();

                    data.DanLuu = DataReader["DanLuu"].ToString();
                    data.Bac = DataReader["Bac"].ToString();
                    data.NgayRut = Convert.ToDateTime(DataReader["NgayRut"] == DBNull.Value ? DateTime.Now : DataReader["NgayRut"]);
                    data.NgayCatChi = Convert.ToDateTime(DataReader["NgayCatChi"] == DBNull.Value ? DateTime.Now : DataReader["NgayCatChi"]);
                    data.Khac = DataReader["Khac"].ToString();

                    data.LuonCatheter = DataReader["LuonCatheter"].ToString();
                    data.Fr = DataReader["Fr"].ToString();

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
                MDB.MDBCommand oracleCommand;
                string sql = @"DELETE FROM ThuThuatDatCatheterTMDui WHERE ID =" + IDBienBan;
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
            string sql = @"SELECT P.*, T.SoNhapVien, T.Khoa,  T.MaKhoa, T.MaBenhAn, H.BENHVIEN, H.SoYTe,  H.TenBenhNhan, H.Tuoi
			  FROM ThuThuatDatCatheterTMDui P 
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
            adt.Fill(ds, "KQ");

            ds.Tables[0].AddColumn("ThongTinNgayThang", typeof(string));
            ds.Tables[0].Rows[0]["ThongTinNgayThang"] = "Ngày  " + DateTime.Now.Day + " tháng " + DateTime.Now.Month + " năm " + DateTime.Now.Year;
            DateTime ThuThuatLuc = Convert.ToDateTime(ds.Tables[0].Rows[0]["ThuThuatLuc"]);
            ds.Tables[0].AddColumn("ThuThuatLucFormat", typeof(string));
            ds.Tables[0].Rows[0]["ThuThuatLucFormat"] = ThuThuatLuc.Hour + " giờ  " + ThuThuatLuc.Minute + " phút, ngày " +
                ThuThuatLuc.Day + " tháng "+ ThuThuatLuc.Month + " năm " + ThuThuatLuc.Year;

            DateTime VaoVienLuc = Convert.ToDateTime(ds.Tables[0].Rows[0]["VaoVienLuc"]);
            ds.Tables[0].AddColumn("VaoVienLucFormat", typeof(string));
            ds.Tables[0].Rows[0]["VaoVienLucFormat"] = VaoVienLuc.Hour + " giờ  " + VaoVienLuc.Minute + " phút, ngày " +
                VaoVienLuc.Day + " tháng " + VaoVienLuc.Month + " năm " + VaoVienLuc.Year;

            ds.Tables[0].AddColumn("GioiTinh", typeof(string));
            ds.Tables[0].Rows[0]["GioiTinh"] = XemBenhAn._HanhChinhBenhNhan.GioiTinh.Description();
            return ds;
        }
        public static bool InsertOrUpdate(MDB.MDBConnection MyConnection, ref ThuThuatDatCatheterTMDui ketQua)
        {
            try
            {
                string sql = @"INSERT INTO ThuThuatDatCatheterTMDui
                (
                    MaQuanLy,
                    Buong,
                    Giuong,
                    ThuThuatLuc,
                    VaoVienLuc,
                    ChanDoanTruocTT,
                    ChanDoanSauTT,
                    PhuongPhapThuThuat,
                    LoaiThuThuat,
                    PhuongPhapVoCam,
                    BacSiThuThuat,
                    BacSiGayMe,
                    MaBacSiGayMe,
                    DanLuu,
                    Bac,
                    NgayRut,
                    NgayCatChi,
                    Khac,
                    LuonCatheter,
                    Fr,
                    NGUOITAO,
                    NGUOISUA,
                    NGAYTAO,
                    NGAYSUA)  VALUES
                 (
				    :MaQuanLy,
				    :Buong,
                    :Giuong,
                    :ThuThuatLuc,
                    :VaoVienLuc,
                    :ChanDoanTruocTT,
                    :ChanDoanSauTT,
                    :PhuongPhapThuThuat,
                    :LoaiThuThuat,
                    :PhuongPhapVoCam,
                    :BacSiThuThuat,
                    :BacSiGayMe,
                    :MaBacSiGayMe,
                    :DanLuu,
                    :Bac,
                    :NgayRut,
                    :NgayCatChi,
                    :Khac,
                    :LuonCatheter,
                    :Fr,
                    :NGUOITAO,
                    :NGUOISUA,
                    :NGAYTAO,
                    :NGAYSUA
                 )  RETURNING ID INTO :ID";
                if (ketQua.ID != 0)
                {
                    sql = @"UPDATE ThuThuatDatCatheterTMDui SET 
                    MaQuanLy = :MaQuanLy,
                    Buong = :Buong,
                    Giuong = :Giuong,
                    ThuThuatLuc = :ThuThuatLuc,
                    VaoVienLuc = :VaoVienLuc,
                    ChanDoanTruocTT = :ChanDoanTruocTT,
                    ChanDoanSauTT = :ChanDoanSauTT,
                    PhuongPhapThuThuat = :PhuongPhapThuThuat,
                    LoaiThuThuat = :LoaiThuThuat,
                    PhuongPhapVoCam = :PhuongPhapVoCam,
                    BacSiThuThuat = :BacSiThuThuat,
                    BacSiGayMe = :BacSiGayMe,
                    MaBacSiGayMe = :MaBacSiGayMe,
                    DanLuu = :DanLuu,
                    Bac = :Bac,
                    NgayRut = :NgayRut,
                    NgayCatChi = :NgayCatChi,
                    Khac = :Khac,
                    LuonCatheter = :LuonCatheter,
                    Fr = :Fr,
                    NGUOISUA = :NGUOISUA,
                    NGAYSUA = :NGAYSUA 
                    WHERE ID = " + ketQua.ID;
                }
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);

                Command.Parameters.Add(new MDB.MDBParameter("NGUOISUA", ketQua.NguoiSua));
                Command.Parameters.Add(new MDB.MDBParameter("NGAYSUA", ketQua.NgaySua));

                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", ketQua.MaQuanLy));
                Command.Parameters.Add(new MDB.MDBParameter("Buong", ketQua.Buong));
                Command.Parameters.Add(new MDB.MDBParameter("Giuong", ketQua.Giuong));

                DateTime? ThuThuatLuc = ketQua.ThuThuatLuc.HasValue ? ketQua.ThuThuatLuc.Value.Date : (DateTime?)null;
                var ThoiGian = ThuThuatLuc;
                if (ThuThuatLuc != null)
                {
                    var ThuThuatLucGio = ketQua.ThuThuatLuc_Gio.HasValue ? ketQua.ThuThuatLuc_Gio.Value.TimeOfDay : new TimeSpan(0, 0, 0);
                    ThoiGian = ThuThuatLuc + ThuThuatLucGio;
                }
                Command.Parameters.Add(new MDB.MDBParameter("ThuThuatLuc", ThoiGian));

                DateTime? VaoVienLuc = ketQua.VaoVienLuc.HasValue ? ketQua.VaoVienLuc.Value.Date : (DateTime?)null;
                var ThoiGianVaoVien = VaoVienLuc;
                if (VaoVienLuc != null)
                {
                    var VaoVienLucGio = ketQua.VaoVienLuc_Gio.HasValue ? ketQua.VaoVienLuc_Gio.Value.TimeOfDay : new TimeSpan(0, 0, 0);
                    ThoiGianVaoVien = VaoVienLuc + VaoVienLucGio;
                }
                Command.Parameters.Add(new MDB.MDBParameter("VaoVienLuc", ThoiGianVaoVien));

                Command.Parameters.Add(new MDB.MDBParameter("ChanDoanTruocTT", ketQua.ChanDoanTruocTT));
                Command.Parameters.Add(new MDB.MDBParameter("ChanDoanSauTT", ketQua.ChanDoanSauTT));
                Command.Parameters.Add(new MDB.MDBParameter("PhuongPhapThuThuat", ketQua.PhuongPhapThuThuat));
                Command.Parameters.Add(new MDB.MDBParameter("LoaiThuThuat", ketQua.LoaiThuThuat));
                Command.Parameters.Add(new MDB.MDBParameter("PhuongPhapVoCam", ketQua.PhuongPhapVoCam));
                Command.Parameters.Add(new MDB.MDBParameter("BacSiThuThuat", ketQua.BacSiThuThuat));
                Command.Parameters.Add(new MDB.MDBParameter("MaBacSiThuThuat", ketQua.MaBacSiThuThuat));
                Command.Parameters.Add(new MDB.MDBParameter("MaBacSiGayMe", ketQua.MaBacSiGayMe));
                Command.Parameters.Add(new MDB.MDBParameter("BacSiGayMe", ketQua.BacSiGayMe));

                Command.Parameters.Add(new MDB.MDBParameter("DanLuu", ketQua.DanLuu));
                Command.Parameters.Add(new MDB.MDBParameter("Bac", ketQua.Bac));
                Command.Parameters.Add(new MDB.MDBParameter("NgayCatChi", ketQua.NgayCatChi));
                Command.Parameters.Add(new MDB.MDBParameter("NgayRut", ketQua.NgayRut));
                Command.Parameters.Add(new MDB.MDBParameter("Khac", ketQua.Khac));
                Command.Parameters.Add(new MDB.MDBParameter("LuonCatheter", ketQua.LuonCatheter));
                Command.Parameters.Add(new MDB.MDBParameter("Fr", ketQua.Fr));

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
    }
}
