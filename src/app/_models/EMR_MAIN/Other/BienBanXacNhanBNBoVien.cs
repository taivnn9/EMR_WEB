
using EMR.KyDienTu;
using PMS.Access;
using System;
using System.Collections.Generic;
using System.Data;

namespace EMR_MAIN.DATABASE.Other
{
    public class BienBanXacNhanBNBoVien : ThongTinKy
    {
        public BienBanXacNhanBNBoVien()
        {
            TableName = "BienBanXacNhanBNBoVien";
            TablePrimaryKeyName = "ID";
            IDMauPhieu = (int)DanhMucPhieu.BBXNBNBV;
            TenMauPhieu = DanhMucPhieu.BBXNBNBV.Description();
        }
        [MoTaDuLieu("Mã định danh")]
		public long ID { get; set; }
        [MoTaDuLieu("Mã quản lý: mã duy nhất trong 1 đợt khám chữa bệnh (kcb), không trùng giữa các đợt kcb khác nhau","",1)]
		public decimal MaQuanLy { get; set; }
        [MoTaDuLieu("Mã bệnh nhân")]
		public string MaBenhNhan { get; set; }
        [MoTaDuLieu("Nơi làm")]
        public string NoiLam { get; set; }
        [MoTaDuLieu("Giờ lập biên bản")]
        public DateTime? ThoiGian_Gio { get; set; }
        [MoTaDuLieu("Ngày lập biên bản")]
        public DateTime? ThoiGian { get; set; }
        [MoTaDuLieu("Khoa")]
		public string Khoa { get; set; }
        [MoTaDuLieu("Mã lãnh đạo trực")]
        public string MaLanhDao { get; set; }
        [MoTaDuLieu("Họ tên lãnh đạo trực")]
        public string LanhDao { get; set; }
        [MoTaDuLieu("Trưởng khoa")]
		public string TruongKhoa { get; set; }
        [MoTaDuLieu("Mã trưởng khoa")]
		public string MaTruongKhoa { get; set; }
        [MoTaDuLieu("Họ tên bác sỹ")]
		public string BacSi { get; set; }
        [MoTaDuLieu("Mã bác sỹ")]
		public string MaBacSi { get; set; }
        [MoTaDuLieu("Họ tên điều dưỡng")]
		public string DieuDuong { get; set; }
        [MoTaDuLieu("Mã điều dưỡng")]
		public string MaDieuDuong { get; set; }
        [MoTaDuLieu("Họ và tên bệnh nhân")]
		public string TenBenhNhan { get; set; }
        [MoTaDuLieu("Tuổi bệnh nhân")]
		public string Tuoi { get; set; }
        [MoTaDuLieu("Giới tính bệnh nhân")]
		public string GioiTinh { get; set; }
        [MoTaDuLieu("Địa chỉ nhà bệnh nhân")]
		public string DiaChi { get; set; }
        [MoTaDuLieu("Phòng bệnh")]
        public string PhongBenh { get; set; }
        [MoTaDuLieu("Giường bệnh")]
        public string GiuongBenh { get; set; }
        [MoTaDuLieu("Mã bệnh án")]
		public string MaBenhAn { get; set; }
        [MoTaDuLieu("Ngày vào viện")]
        public DateTime? NgayVaoVien { get; set; }
        [MoTaDuLieu("Giờ vào viện")]
        public DateTime? NgayVaoVien_Gio { get; set; }
        [MoTaDuLieu("Chẩn đoán bệnh")]
		public string ChanDoan { get; set; }
        [MoTaDuLieu("Tư trang, giấy tờ tuỳ thân kèm theo của người bệnh để lại")]
        public string TuTrang { get; set; }
        [MoTaDuLieu("Tóm tắt quá trình điều trị")]
        public string TomTat { get; set; }
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

    public class BienBanXacNhanBNBoVienFunc
    {
        public const string TableName = "BienBanXacNhanBNBoVien";
        public const string TablePrimaryKeyName = "ID";

        public static List<BienBanXacNhanBNBoVien> GetListData(MDB.MDBConnection _OracleConnection, decimal maquanly)
        {
            List<BienBanXacNhanBNBoVien> list = new List<BienBanXacNhanBNBoVien>();
            try
            {
                string sql = @"SELECT * FROM BienBanXacNhanBNBoVien where MaQuanLy = :MaQuanLy";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, _OracleConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", maquanly));
                MDB.MDBDataReader DataReader = Command.ExecuteReader();
                while (DataReader.Read())
                {
                    BienBanXacNhanBNBoVien data = new BienBanXacNhanBNBoVien();
                    data.ID = Convert.ToInt64(DataReader.GetLong("ID").ToString());
                    data.MaQuanLy = maquanly;

                    data.MaBenhNhan = XemBenhAn._HanhChinhBenhNhan.MaBenhNhan;
                    data.NoiLam = DataReader["NoiLam"].ToString();
                    data.Khoa = DataReader["Khoa"].ToString();
                    data.LanhDao = DataReader["LanhDao"].ToString();
                    data.MaLanhDao = DataReader["MaLanhDao"].ToString();
                    data.TruongKhoa = DataReader["TruongKhoa"].ToString();
                    data.MaTruongKhoa = DataReader["MaTruongKhoa"].ToString();
                    data.BacSi = DataReader["BacSi"].ToString();
                    data.MaBacSi = DataReader["MaBacSi"].ToString();
                    data.DieuDuong = DataReader["DieuDuong"].ToString();
                    data.MaDieuDuong = DataReader["MaDieuDuong"].ToString();
                    data.TenBenhNhan = DataReader["TenBenhNhan"].ToString();
                    data.Tuoi = DataReader["Tuoi"].ToString();
                    data.GioiTinh = DataReader["GioiTinh"].ToString();
                    data.DiaChi = DataReader["DiaChi"].ToString();
                    data.PhongBenh = DataReader["PhongBenh"].ToString();
                    data.GiuongBenh = DataReader["GiuongBenh"].ToString();
                    data.MaBenhAn = DataReader["MaBenhAn"].ToString();
                    data.ChanDoan = DataReader["ChanDoan"].ToString();
                    data.TuTrang = DataReader["TuTrang"].ToString();
                    data.TomTat = DataReader["TomTat"].ToString();

                    data.ThoiGian = Convert.ToDateTime(DataReader["ThoiGian"] == DBNull.Value ? DateTime.Now : DataReader["ThoiGian"]);
                    data.ThoiGian_Gio = data.ThoiGian;

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
                sql = @"DELETE FROM BienBanXacNhanBNBoVien WHERE ID =" + IDBienBan;
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
            string sql = @"SELECT
                P.* 
            FROM
                BienBanXacNhanBNBoVien P
            WHERE
                ID = " + IDBienBan;

            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
            MDB.MDBDataAdapter adt = new MDB.MDBDataAdapter(Command);
            var ds = new DataSet();

            adt.Fill(ds, "TB");

            ds.Tables[0].AddColumn("BENHVIEN", typeof(string));

            ds.Tables[0].Rows[0]["BENHVIEN"] = XemBenhAn._HanhChinhBenhNhan.BenhVien;

            return ds;
        }
        public static bool InsertOrUpdate(MDB.MDBConnection MyConnection, ref BienBanXacNhanBNBoVien ketQua)
        {
            try
            {
                string sql = @"INSERT INTO BienBanXacNhanBNBoVien
                (
                    MaQuanLy,
                    NoiLam,
                    ThoiGian,
                    Khoa,
                    LanhDao,
                    MaLanhDao,
                    TruongKhoa,
                    MaTruongKhoa,
                    BacSi,
                    MaBacSi,
                    DieuDuong,
                    MaDieuDuong,
                    TenBenhNhan,
                    Tuoi,
                    GioiTinh,
                    DiaChi,
                    PhongBenh,
                    GiuongBenh,
                    MaBenhAn,
                    NgayVaoVien,
                    ChanDoan,
                    TuTrang,
                    TomTat,
                    NGUOITAO,
                    NGUOISUA,
                    NGAYTAO,
                    NGAYSUA)  VALUES
                 (
				    :MaQuanLy,
                    :NoiLam,
                    :ThoiGian,
                    :Khoa,
                    :LanhDao,
                    :MaLanhDao,
                    :TruongKhoa,
                    :MaTruongKhoa,
                    :BacSi,
                    :MaBacSi,
                    :DieuDuong,
                    :MaDieuDuong,
                    :TenBenhNhan,
                    :Tuoi,
                    :GioiTinh,
                    :DiaChi,
                    :PhongBenh,
                    :GiuongBenh,
                    :MaBenhAn,
                    :NgayVaoVien,
                    :ChanDoan,
                    :TuTrang,
                    :TomTat,
                    :NGUOITAO,
                    :NGUOISUA,
                    :NGAYTAO,
                    :NGAYSUA
                 )  RETURNING ID INTO :ID";
                if (ketQua.ID != 0)
                {
                    sql = @"UPDATE BienBanXacNhanBNBoVien SET 
                    MaQuanLy = :MaQuanLy,
                    NoiLam = :NoiLam,
                    ThoiGian = :ThoiGian,
                    Khoa = :Khoa,
                    LanhDao = :LanhDao,
                    MaLanhDao = :MaLanhDao,
                    TruongKhoa = :TruongKhoa,
                    MaTruongKhoa = :MaTruongKhoa,
                    BacSi = :BacSi,
                    MaBacSi = :MaBacSi,
                    DieuDuong = :DieuDuong,
                    MaDieuDuong = :MaDieuDuong,
                    TenBenhNhan = :TenBenhNhan,
                    Tuoi = :Tuoi,
                    GioiTinh = :GioiTinh,
                    DiaChi = :DiaChi,
                    PhongBenh = :PhongBenh,
                    GiuongBenh = :GiuongBenh,
                    MaBenhAn = :MaBenhAn,
                    NgayVaoVien = :NgayVaoVien,
                    ChanDoan = :ChanDoan,
                    TuTrang = :TuTrang,
                    TomTat = :TomTat,
                    NGUOISUA = :NGUOISUA,
                    NGAYSUA = :NGAYSUA 
                    WHERE ID = " + ketQua.ID;
                }
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);

                Command.Parameters.Add(new MDB.MDBParameter("NGUOISUA", ketQua.NguoiSua));
                Command.Parameters.Add(new MDB.MDBParameter("NGAYSUA", ketQua.NgaySua));

                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", ketQua.MaQuanLy));

                Command.Parameters.Add(new MDB.MDBParameter("NoiLam", ketQua.NoiLam));
                DateTime? ThoiGian = ketQua.ThoiGian.HasValue ? ketQua.ThoiGian.Value.Date : (DateTime?)null;
                var ThoiGianFull = ThoiGian;
                if (ThoiGian != null)
                {
                    var ThoiGian_Gio = ketQua.ThoiGian_Gio.HasValue ? ketQua.ThoiGian_Gio.Value.TimeOfDay : new TimeSpan(0, 0, 0);
                    ThoiGianFull = ThoiGian + ThoiGian_Gio;
                }
                Command.Parameters.Add(new MDB.MDBParameter("ThoiGian", ThoiGianFull));

                Command.Parameters.Add(new MDB.MDBParameter("Khoa", ketQua.Khoa));
                Command.Parameters.Add(new MDB.MDBParameter("LanhDao", ketQua.LanhDao));
                Command.Parameters.Add(new MDB.MDBParameter("MaLanhDao", ketQua.MaLanhDao));
                Command.Parameters.Add(new MDB.MDBParameter("TruongKhoa", ketQua.TruongKhoa));
                Command.Parameters.Add(new MDB.MDBParameter("MaTruongKhoa", ketQua.MaTruongKhoa));
                Command.Parameters.Add(new MDB.MDBParameter("BacSi", ketQua.BacSi));
                Command.Parameters.Add(new MDB.MDBParameter("MaBacSi", ketQua.MaBacSi));
                Command.Parameters.Add(new MDB.MDBParameter("DieuDuong", ketQua.DieuDuong));
                Command.Parameters.Add(new MDB.MDBParameter("MaDieuDuong", ketQua.MaDieuDuong));
                Command.Parameters.Add(new MDB.MDBParameter("TenBenhNhan", ketQua.TenBenhNhan));
                Command.Parameters.Add(new MDB.MDBParameter("Tuoi", ketQua.Tuoi));
                Command.Parameters.Add(new MDB.MDBParameter("GioiTinh", ketQua.GioiTinh));
                Command.Parameters.Add(new MDB.MDBParameter("DiaChi", ketQua.DiaChi));
                Command.Parameters.Add(new MDB.MDBParameter("PhongBenh", ketQua.PhongBenh));
                Command.Parameters.Add(new MDB.MDBParameter("GiuongBenh", ketQua.GiuongBenh));
                Command.Parameters.Add(new MDB.MDBParameter("MaBenhAn", ketQua.MaBenhAn));

                DateTime? NgayVaoVien = ketQua.NgayVaoVien.HasValue ? ketQua.NgayVaoVien.Value.Date : (DateTime?)null;
                var NgayVaoVienFull = NgayVaoVien;
                if (NgayVaoVien != null)
                {
                    var NgayVaoVien_Gio = ketQua.NgayVaoVien_Gio.HasValue ? ketQua.NgayVaoVien_Gio.Value.TimeOfDay : new TimeSpan(0, 0, 0);
                    NgayVaoVienFull = NgayVaoVien + NgayVaoVien_Gio;
                }
                Command.Parameters.Add(new MDB.MDBParameter("NgayVaoVien", NgayVaoVienFull));
                Command.Parameters.Add(new MDB.MDBParameter("ChanDoan", ketQua.ChanDoan));
                Command.Parameters.Add(new MDB.MDBParameter("TuTrang", ketQua.TuTrang));
                Command.Parameters.Add(new MDB.MDBParameter("TomTat", ketQua.TomTat));

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
