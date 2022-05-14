
using EMR.KyDienTu;
using PMS.Access;
using System;
using System.Collections.Generic;
using System.Data;

namespace EMR_MAIN.DATABASE.Other
{
    public class BienBanXacNhanNguoiBenhTuVong : ThongTinKy
    {
        public BienBanXacNhanNguoiBenhTuVong()
        {
            TableName = "BienBanXacNhanNBTuVong";
            TablePrimaryKeyName = "ID";
            IDMauPhieu = (int)DanhMucPhieu.BBXNNBTV;
            TenMauPhieu = DanhMucPhieu.BBXNNBTV.Description();
        }
        [MoTaDuLieu("Mã định danh")]
		public long ID { get; set; }
        [MoTaDuLieu("Mã quản lý: mã duy nhất trong 1 đợt khám chữa bệnh (kcb), không trùng giữa các đợt kcb khác nhau","",1)]
		public decimal MaQuanLy { get; set; }
        [MoTaDuLieu("Mã bệnh nhân")]
		public string MaBenhNhan { get; set; }
        [MoTaDuLieu("Giờ lập biên bản")]
        public DateTime? ThoiGian_Gio { get; set; }
        [MoTaDuLieu("Ngày lập biên bản")]
        public DateTime? ThoiGian { get; set; }
        [MoTaDuLieu("Mã bác sỹ")]
		public string MaBacSy { get; set; }
        [MoTaDuLieu("Tên bác sỹ ")]
        public string BacSy { get; set; }
        [MoTaDuLieu("Mã y tá điều dưỡng")]
        public string MaYTaDieuDuong { get; set; }
        [MoTaDuLieu("Tên y tá điều dưỡng")]
		public string YTaDieuDuong { get; set; }
        [MoTaDuLieu("Mã hộ lý")]
		public string MaHoLy { get; set; }
        [MoTaDuLieu("Tên hộ lý")]
		public string HoLy { get; set; }
        [MoTaDuLieu("Họ tên người có quan hệ với người bệnh")]
		public string HoTenQHBenhNhan { get; set; }
        [MoTaDuLieu("Họ tên người có quan hệ với người bệnh 2")]
		public string HoTenQHBenhNhan1 { get; set; }
        [MoTaDuLieu("Nội dung có quan hệ với người bệnh")]
		public string QHNguoiBenh { get; set; }
        [MoTaDuLieu("Nội dung có quan hệ với người bệnh 2")]
		public string QHNguoiBenh1 { get; set; }
        [MoTaDuLieu("Họ tên bệnh nhân")]
		public string HoTenBenhNhan { get; set; }
        [MoTaDuLieu("Tuổi bệnh nhân")]
        public string Tuoi { get; set; }
        [MoTaDuLieu("Giới tính bệnh nhân")]
		public string GioiTinh { get; set; }
        [MoTaDuLieu("Địa chỉ nhà bệnh nhân")]
		public string DiaChi { get; set; }
        [MoTaDuLieu("Nghê nghiệp")]
        public string NgheNghiep { get; set; }
        [MoTaDuLieu("Giờ nhập viện")]
        public DateTime? NgayVaoVien_Gio { get; set; }
        [MoTaDuLieu("Ngày nhập viện")]
        public DateTime? NgayVaoVien { get; set; }
        [MoTaDuLieu("Quá trình diễn biến bệnh từ lúc bị đến khi vào viện")]
        public string TomTatBenh { get; set; }
        [MoTaDuLieu("Tình trạng người bệnh lúc vào viện")]
		public string TTVaoVien { get; set; }
        [MoTaDuLieu("Cách xử trí")]
        public string CachXuTri { get; set; }
        [MoTaDuLieu("Thời gian tử vong")]
        public DateTime? TGTuVong_Gio { get; set; }
        [MoTaDuLieu("Ngày tử vong")]
        public DateTime? TGTuVong_Ngay { get; set; }
        [MoTaDuLieu("Nguyên nhân chính gây tử vong")]
		public string NguyenNhanChinh { get; set; }
        [MoTaDuLieu("Liệt kê tài sản người bệnh")]
        public string TSNguoiBenh { get; set; }
        [MoTaDuLieu("Họ tên người giữ tài sản giúp bệnh nhân")]
        public string HoTenNguoiGiuTS { get; set; }
        [MoTaDuLieu("Nội dung liệt kê tài sản nhận giữ hộ bệnh nhân")]
        public string NguoiGiuTS { get; set; }
        [MoTaDuLieu("Đại diện cho người bệnh ký biên bản")]
        public string NguoiDaiDienBN { get; set; }
        [MoTaDuLieu("Đại diện cho thường trực cấp cứu của bệnh viện")]
        public string MaDaiDienXacNhan { get; set; }
        [MoTaDuLieu("Đại diện cho thường trực cấp cứu của bệnh viện")]
        public string DaiDienXacNhan { get; set; }

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

    public class BienBanXacNhanNguoiBenhTuVongFunc
    {
        public const string TableName = "BienBanXacNhanNBTuVong";
        public const string TablePrimaryKeyName = "ID";

        public static List<BienBanXacNhanNguoiBenhTuVong> GetListData(MDB.MDBConnection _OracleConnection, decimal maquanly)
        {
            List<BienBanXacNhanNguoiBenhTuVong> list = new List<BienBanXacNhanNguoiBenhTuVong>();
            try
            {
                string sql = @"SELECT * FROM BienBanXacNhanNBTuVong where MaQuanLy = :MaQuanLy";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, _OracleConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", maquanly));
                MDB.MDBDataReader DataReader = Command.ExecuteReader();
                while (DataReader.Read())
                {
                    BienBanXacNhanNguoiBenhTuVong data = new BienBanXacNhanNguoiBenhTuVong();
                    data.ID = DataReader.GetLong("ID");
                    data.MaQuanLy = maquanly;
                    data.MaBenhNhan = XemBenhAn._HanhChinhBenhNhan.MaBenhNhan;
                    data.ThoiGian = Convert.ToDateTime(DataReader["ThoiGian"] == DBNull.Value ? DateTime.Now : DataReader["ThoiGian"]);
                    data.ThoiGian_Gio = data.ThoiGian;
                    data.MaBacSy = DataReader["MaBacSy"].ToString();
                    data.BacSy = DataReader["BacSy"].ToString();
                    data.MaYTaDieuDuong = DataReader["MaYTaDieuDuong"].ToString();
                    data.YTaDieuDuong = DataReader["YTaDieuDuong"].ToString();
                    data.MaHoLy = DataReader["MaHoLy"].ToString();
                    data.HoLy = DataReader["HoLy"].ToString();
                    data.HoTenQHBenhNhan = DataReader["HoTenQHBenhNhan"].ToString();
                    data.HoTenQHBenhNhan1 = DataReader["HoTenQHBenhNhan1"].ToString();
                    data.QHNguoiBenh = DataReader["QHNguoiBenh"].ToString();
                    data.QHNguoiBenh1 = DataReader["QHNguoiBenh1"].ToString();
                    data.HoTenBenhNhan = DataReader["HoTenBenhNhan"].ToString();
                    data.Tuoi = DataReader["Tuoi"].ToString();
                    data.GioiTinh = DataReader["GioiTinh"].ToString();
                    data.DiaChi = DataReader["DiaChi"].ToString();
                    data.NgheNghiep = DataReader["NgheNghiep"].ToString();
                    data.NgayVaoVien = Convert.ToDateTime(DataReader["NgayVaoVien"] == DBNull.Value ? DateTime.Now : DataReader["NgayVaoVien"]);
                    data.NgayVaoVien_Gio = data.NgayVaoVien;
                    data.TomTatBenh = DataReader["TomTatBenh"].ToString();
                    data.TTVaoVien = DataReader["TTVaoVien"].ToString();
                    data.CachXuTri = DataReader["CachXuTri"].ToString();
                    data.TGTuVong_Ngay = Convert.ToDateTime(DataReader["TGTuVong_Ngay"] == DBNull.Value ? DateTime.Now : DataReader["TGTuVong_Ngay"]);
                    data.TGTuVong_Gio = data.TGTuVong_Ngay;
                    data.NguyenNhanChinh = DataReader["NguyenNhanChinh"].ToString();
                    data.TSNguoiBenh = DataReader["TSNguoiBenh"].ToString();
                    data.HoTenNguoiGiuTS = DataReader["HoTenNguoiGiuTS"].ToString();
                    data.NguoiGiuTS = DataReader["NguoiGiuTS"].ToString();
                    data.NguoiDaiDienBN = DataReader["NguoiDaiDienBN"].ToString();
                    data.MaDaiDienXacNhan = DataReader["MaDaiDienXacNhan"].ToString();
                    data.DaiDienXacNhan = DataReader["DaiDienXacNhan"].ToString();
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
                sql = @"DELETE FROM BienBanXacNhanNBTuVong WHERE ID =" + IDBienBan;
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
                D.*,
	            T.MABENHNHAN,
	            H.SOYTE,
	            H.BENHVIEN
            FROM
                BienBanXacNhanNBTuVong D
                LEFT JOIN THONGTINDIEUTRI T ON D.MAQUANLY = T.MAQUANLY
                LEFT JOIN HANHCHINHBENHNHAN H ON T.MABENHNHAN = H.MABENHNHAN
            WHERE
                ID = " + IDBienBan;

            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
            MDB.MDBDataAdapter adt = new MDB.MDBDataAdapter(Command);
            var ds = new DataSet();

            adt.Fill(ds, "TB");

            return ds;
        }
        public static bool InsertOrUpdate(MDB.MDBConnection MyConnection, ref BienBanXacNhanNguoiBenhTuVong ketQua)
        {
            try
            {
                string sql = @"INSERT INTO BienBanXacNhanNBTuVong
                (
                    MaQuanLy,
                    MaBenhNhan,
                    ThoiGian,
                    MaBacSy,
                    BacSy,
                    MaYTaDieuDuong,
                    YTaDieuDuong,
                    MaHoLy,
                    HoLy,
                    HoTenQHBenhNhan,
                    HoTenQHBenhNhan1,
                    QHNguoiBenh,
                    QHNguoiBenh1,
                    HoTenBenhNhan,
                    Tuoi,
                    GioiTinh,
                    DiaChi,
                    NgheNghiep,
                    NgayVaoVien,
                    TomTatBenh,
                    TTVaoVien,
                    CachXuTri,
                    TGTuVong_Ngay,
                    NguyenNhanChinh,
                    TSNguoiBenh,
                    HoTenNguoiGiuTS,
                    NguoiGiuTS,
                    NguoiDaiDienBN,
                    MaDaiDienXacNhan,
                    DaiDienXacNhan,
                    NGUOITAO,
                    NGUOISUA,
                    NGAYTAO,
                    NGAYSUA)  VALUES
                 (
                    :MaQuanLy,
                    :MaBenhNhan,
                    :ThoiGian,
                    :MaBacSy,
                    :BacSy,
                    :MaYTaDieuDuong,
                    :YTaDieuDuong,
                    :MaHoLy,
                    :HoLy,
                    :HoTenQHBenhNhan,
                    :HoTenQHBenhNhan1,
                    :QHNguoiBenh,
                    :QHNguoiBenh1,
                    :HoTenBenhNhan,
                    :Tuoi,
                    :GioiTinh,
                    :DiaChi,
                    :NgheNghiep,
                    :NgayVaoVien,
                    :TomTatBenh,
                    :TTVaoVien,
                    :CachXuTri,
                    :TGTuVong_Ngay,
                    :NguyenNhanChinh,
                    :TSNguoiBenh,
                    :HoTenNguoiGiuTS,
                    :NguoiGiuTS,
                    :NguoiDaiDienBN,
                    :MaDaiDienXacNhan,
                    :DaiDienXacNhan,
                    :NGUOITAO,
                    :NGUOISUA,
                    :NGAYTAO,
                    :NGAYSUA
                 )  RETURNING ID INTO :ID";
                if (ketQua.ID != 0)
                {
                    sql = @"UPDATE BienBanXacNhanNBTuVong SET 
                    MaQuanLy=:MaQuanLy,
                    ThoiGian=:ThoiGian,
                    MaBacSy=:MaBacSy,
                    BacSy=:BacSy,
                    MaYTaDieuDuong=:MaYTaDieuDuong,
                    YTaDieuDuong=:YTaDieuDuong,
                    MaHoLy=:MaHoLy,
                    HoLy=:HoLy,
                    HoTenQHBenhNhan=:HoTenQHBenhNhan,
                    HoTenQHBenhNhan1=:HoTenQHBenhNhan1,
                    QHNguoiBenh=:QHNguoiBenh,
                    QHNguoiBenh1=:QHNguoiBenh1,
                    HoTenBenhNhan=:HoTenBenhNhan,
                    Tuoi=:Tuoi,
                    GioiTinh=:GioiTinh,
                    DiaChi=:DiaChi,
                    NgheNghiep=:NgheNghiep,
                    NgayVaoVien=:NgayVaoVien,
                    TomTatBenh=:TomTatBenh,
                    TTVaoVien=:TTVaoVien,
                    CachXuTri=:CachXuTri,
                    TGTuVong_Ngay=:TGTuVong_Ngay,
                    NguyenNhanChinh=:NguyenNhanChinh,
                    TSNguoiBenh=:TSNguoiBenh,
                    HoTenNguoiGiuTS=:HoTenNguoiGiuTS,
                    NguoiGiuTS=:NguoiGiuTS,
                    NguoiDaiDienBN=:NguoiDaiDienBN,
                    MaDaiDienXacNhan=:MaDaiDienXacNhan,
                    DaiDienXacNhan=:DaiDienXacNhan,
                    NGUOISUA = :NGUOISUA,
                    NGAYSUA = :NGAYSUA 
                    WHERE ID = " + ketQua.ID;
                }
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);

                Command.Parameters.Add(new MDB.MDBParameter("NGUOISUA", ketQua.NguoiSua));
                Command.Parameters.Add(new MDB.MDBParameter("NGAYSUA", ketQua.NgaySua));

                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", ketQua.MaQuanLy));

                DateTime? ThoiGian = ketQua.ThoiGian.HasValue ? ketQua.ThoiGian.Value.Date : (DateTime?)null;
                var ThoiGianFull = ThoiGian;
                if (ThoiGian != null)
                {
                    var ThoiGian_Gio = ketQua.ThoiGian_Gio.HasValue ? ketQua.ThoiGian_Gio.Value.TimeOfDay : new TimeSpan(0, 0, 0);
                    ThoiGianFull = ThoiGian + ThoiGian_Gio;
                }
                Command.Parameters.Add(new MDB.MDBParameter("ThoiGian", ThoiGianFull));

                Command.Parameters.Add(new MDB.MDBParameter("MaBenhNhan", ketQua.MaBenhNhan));
                Command.Parameters.Add(new MDB.MDBParameter("MaBacSy", ketQua.MaBacSy));
                Command.Parameters.Add(new MDB.MDBParameter("BacSy", ketQua.BacSy));
                Command.Parameters.Add(new MDB.MDBParameter("MaYTaDieuDuong", ketQua.MaYTaDieuDuong));
                Command.Parameters.Add(new MDB.MDBParameter("YTaDieuDuong", ketQua.YTaDieuDuong));
                Command.Parameters.Add(new MDB.MDBParameter("MaHoLy", ketQua.MaHoLy));
                Command.Parameters.Add(new MDB.MDBParameter("HoLy", ketQua.HoLy));
                Command.Parameters.Add(new MDB.MDBParameter("HoTenQHBenhNhan", ketQua.HoTenQHBenhNhan));
                Command.Parameters.Add(new MDB.MDBParameter("HoTenQHBenhNhan1", ketQua.HoTenQHBenhNhan1));
                Command.Parameters.Add(new MDB.MDBParameter("QHNguoiBenh", ketQua.QHNguoiBenh));
                Command.Parameters.Add(new MDB.MDBParameter("QHNguoiBenh1", ketQua.QHNguoiBenh1));
                Command.Parameters.Add(new MDB.MDBParameter("HoTenBenhNhan", ketQua.HoTenBenhNhan));
                Command.Parameters.Add(new MDB.MDBParameter("Tuoi", ketQua.Tuoi));
                Command.Parameters.Add(new MDB.MDBParameter("GioiTinh", ketQua.GioiTinh));
                Command.Parameters.Add(new MDB.MDBParameter("DiaChi", ketQua.DiaChi));
                Command.Parameters.Add(new MDB.MDBParameter("NgheNghiep", ketQua.NgheNghiep));
                DateTime? NgayVaoVien = ketQua.NgayVaoVien.HasValue ? ketQua.NgayVaoVien.Value.Date : (DateTime?)null;
                var NgayVaoVienFull = NgayVaoVien;
                if (NgayVaoVien != null)
                {
                    var NgayVaoVien_Gio = ketQua.NgayVaoVien_Gio.HasValue ? ketQua.NgayVaoVien_Gio.Value.TimeOfDay : new TimeSpan(0, 0, 0);
                    NgayVaoVienFull = NgayVaoVien + NgayVaoVien_Gio;
                }
                Command.Parameters.Add(new MDB.MDBParameter("NgayVaoVien", NgayVaoVienFull));

                Command.Parameters.Add(new MDB.MDBParameter("TomTatBenh", ketQua.TomTatBenh));
                Command.Parameters.Add(new MDB.MDBParameter("TTVaoVien", ketQua.TTVaoVien));
                Command.Parameters.Add(new MDB.MDBParameter("CachXuTri", ketQua.CachXuTri));
                DateTime? NgayTuVong = ketQua.TGTuVong_Ngay.HasValue ? ketQua.TGTuVong_Ngay.Value.Date : (DateTime?)null;
                var NgayTuVongFull = NgayTuVong;
                if (NgayTuVong != null)
                {
                    var NgayTuVong_Gio = ketQua.TGTuVong_Gio.HasValue ? ketQua.TGTuVong_Gio.Value.TimeOfDay : new TimeSpan(0, 0, 0);
                    NgayTuVongFull = NgayTuVong + NgayTuVong_Gio;
                }
                Command.Parameters.Add(new MDB.MDBParameter("TGTuVong_Ngay", NgayTuVongFull));

                Command.Parameters.Add(new MDB.MDBParameter("NguyenNhanChinh", ketQua.NguyenNhanChinh));
                Command.Parameters.Add(new MDB.MDBParameter("TSNguoiBenh", ketQua.TSNguoiBenh));
                Command.Parameters.Add(new MDB.MDBParameter("HoTenNguoiGiuTS", ketQua.HoTenNguoiGiuTS));
                Command.Parameters.Add(new MDB.MDBParameter("NguoiGiuTS", ketQua.NguoiGiuTS));
                Command.Parameters.Add(new MDB.MDBParameter("NguoiDaiDienBN", ketQua.NguoiDaiDienBN));
                Command.Parameters.Add(new MDB.MDBParameter("MaDaiDienXacNhan", ketQua.MaDaiDienXacNhan));
                Command.Parameters.Add(new MDB.MDBParameter("DaiDienXacNhan", ketQua.DaiDienXacNhan));

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
