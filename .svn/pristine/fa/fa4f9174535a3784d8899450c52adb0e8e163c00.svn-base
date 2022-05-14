using EMR.KyDienTu;
using PMS.Access;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMR_MAIN.DATABASE.Other
{
    public class PhieuKiemTraBenhAn : ThongTinKy
    {
        public PhieuKiemTraBenhAn()
        {
            TableName = "PhieuKiemTraBenhAn";
            TablePrimaryKeyName = "ID";
            IDMauPhieu = (int)DanhMucPhieu.PKTBA;
            TenMauPhieu = DanhMucPhieu.PKTBA.Description();
        }
        [MoTaDuLieu("Chọn", null, 0, 0)]
		public bool Chon { get; set; }
        [MoTaDuLieu("Mã định danh")]
		public long ID { get; set; }
        public string SoYTe
        {
            get
            {
                return XemBenhAn._HanhChinhBenhNhan.SoYTe;
            }
        }
        public string BenhVien
        {
            get
            {
                return XemBenhAn._HanhChinhBenhNhan.BenhVien;
            }
        }
        public string Khoa
        {
            get
            {
                return XemBenhAn._ThongTinDieuTri.Khoa;
            }
        }
        [MoTaDuLieu("Họ và tên bệnh nhân")]
		public string TenBenhNhan
        {
            get
            {
                return XemBenhAn._HanhChinhBenhNhan.TenBenhNhan;
            }
        }
        [MoTaDuLieu("Tuổi bệnh nhân")]
		public string Tuoi
        {
            get
            {
                return XemBenhAn._HanhChinhBenhNhan.Tuoi;
            }
        }
        [MoTaDuLieu("Giới tính bệnh nhân")]
		public string GioiTinh
        {
            get
            {
                return XemBenhAn._HanhChinhBenhNhan.GioiTinh.Description();
            }
        }
        [MoTaDuLieu("Mã quản lý: mã duy nhất trong 1 đợt khám chữa bệnh (kcb), không trùng giữa các đợt kcb khác nhau","",1)]
		public decimal MaQuanLy { get; set; }
        public DateTime ThoiGianVaoVien { get; set; }
        public DateTime ThoiGianRaVien { get; set; }
        [MoTaDuLieu("Mã bác sỹ điều trị")]
		public string MaBacSyDieuTri { get; set; }
        [MoTaDuLieu("Bác sỹ điều trị")]
		public string BacSyDieuTri { get; set; }
        public string HanhChinh1 { get; set; }
        public string HanhChinh2 { get; set; }
        public string HanhChinh3 { get; set; }
        public string HanhChinh4 { get; set; }
        public string HoiBenhSu { get; set; }
        public string HoiBenhSu2 { get; set; }
        public string KhamToanDien { get; set; }
        public string KhamToanDien2 { get; set; }
        public string LamXetNghiem { get; set; }
        public string LamXetNghiem2 { get; set; }
        [MoTaDuLieu("Chẩn đoán sơ bộ")]
		public string ChanDoanSoBo { get; set; }
        [MoTaDuLieu("Chẩn đoán sơ bộ 2")]
		public string ChanDoanSoBo2 { get; set; }
        [MoTaDuLieu("Chẩn đoán xác định")]
		public string ChanDoanXacDinh { get; set; }
        [MoTaDuLieu("Chẩn đoán xác định 2")]
		public string ChanDoanXacDinh2 { get; set; }
        public string HoiChan { get; set; }
        public string HoiChan2 { get; set; }
        public string GhiDienBien { get; set; }
        public string GhiDienBien2 { get; set; }
        public string ChoThuocHangNgay { get; set; }
        public string ChoThuocHangNgay2 { get; set; }
        public string ChoThuocHopLy { get; set; }
        public string ChoThuocHopLy2 { get; set; }
        public string GhiDungDanhPhap { get; set; }
        public string GhiDungDanhPhap2 { get; set; }
        public string SoKet { get; set; }
        public string SoKet2 { get; set; }
        public string RaVien { get; set; }
        public string RaVien2 { get; set; }
        public DateTime ThoiGian { get; set; }
        public string MaNguoiKiemTra { get; set; }
        public string NguoiKiemTra { get; set; }
        public string NhanXet { get; set; }
        [MoTaDuLieu("Đã ký", null, 0, 0)]
		public bool DaKy { get; set; }
        [MoTaDuLieu("Người tạo", null, 0, 0)]
		public string NguoiTao { get; set; }
        [MoTaDuLieu("Người sửa", null, 0, 0)]
		public string NguoiSua { get; set; }
        [MoTaDuLieu("Ngày tạo", null, 0, 0)]
		public DateTime NgayTao { get; set; }
        [MoTaDuLieu("Ngày sửa", null, 0, 0)]
		public DateTime NgaySua { get; set; }
        public string XepLoai { get; set; }
        public double ChatLuongChanDoan
        {
            get
            {
                try
                {
                    return Math.Round(ParseStringToDouble(HoiBenhSu) + ParseStringToDouble(KhamToanDien) + ParseStringToDouble(LamXetNghiem) + ParseStringToDouble(ChanDoanSoBo) + ParseStringToDouble(ChanDoanXacDinh) + ParseStringToDouble(HoiChan), 1);
                }
                catch { return 0.0; }
            }
            set
            {

            }
        }
        public double ChatLuongDieuTri
        {
            get
            {
                try
                {
                    return Math.Round(ParseStringToDouble(GhiDienBien) + ParseStringToDouble(ChoThuocHangNgay) + ParseStringToDouble(ChoThuocHopLy) + ParseStringToDouble(GhiDungDanhPhap) + ParseStringToDouble(SoKet) + ParseStringToDouble(RaVien), 1);
                }
                catch { return 0.0; }
            }
            set
            {

            }
        }
        public double DiemTong
        {
            get
            {
                return Math.Round(ChatLuongChanDoan + ChatLuongDieuTri, 1);
            }
            set
            {

            }
        }
        private double ParseStringToDouble(string data)
        {
            try
            {
                if (string.IsNullOrEmpty(data))
                {
                    return 0;
                }
                return Convert.ToDouble(data);
            }
            catch { return 0; }
        }
    }
    public class PhieuKiemTraBenhAnFunc
    {
        public const string TableName = "PhieuKiemTraBenhAn";
        public const string TablePrimaryKeyName = "ID";
        public static PhieuKiemTraBenhAn GetListData_Phieu(MDB.MDBConnection _OracleConnection, long ID)
        {
            PhieuKiemTraBenhAn data = new PhieuKiemTraBenhAn();
            try
            {
                string sql = @"SELECT * FROM PhieuKiemTraBenhAn where ID = :ID";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, _OracleConnection);
                Command.Parameters.Add(new MDB.MDBParameter("ID", ID));
                MDB.MDBDataReader DataReader = Command.ExecuteReader();
                while (DataReader.Read())
                {
                    data.ID = Convert.ToInt64(DataReader.GetLong("ID").ToString());
                    data.MaQuanLy = DataReader.GetDecimal("MaQuanLy");
                    data.ThoiGianVaoVien = Convert.ToDateTime(DataReader["ThoiGianVaoVien"] == DBNull.Value ? DateTime.Now : DataReader["ThoiGianVaoVien"]);
                    data.ThoiGianRaVien = Convert.ToDateTime(DataReader["ThoiGianRaVien"] == DBNull.Value ? DateTime.Now : DataReader["ThoiGianRaVien"]);
                    data.MaBacSyDieuTri = DataReader["MaBacSyDieuTri"].ToString();
                    data.BacSyDieuTri = DataReader["BacSyDieuTri"].ToString();
                    data.HanhChinh1 = DataReader["HanhChinh1"].ToString();
                    data.HanhChinh2 = DataReader["HanhChinh2"].ToString();
                    data.HanhChinh3 = DataReader["HanhChinh3"].ToString();
                    data.HanhChinh4 = DataReader["HanhChinh4"].ToString();
                    data.HoiBenhSu = DataReader["HoiBenhSu"].ToString();
                    data.HoiBenhSu2 = DataReader["HoiBenhSu2"].ToString();
                    data.KhamToanDien = DataReader["KhamToanDien"].ToString();
                    data.KhamToanDien2 = DataReader["KhamToanDien2"].ToString();
                    data.LamXetNghiem = DataReader["LamXetNghiem"].ToString();
                    data.LamXetNghiem2 = DataReader["LamXetNghiem2"].ToString();
                    data.ChanDoanSoBo = DataReader["ChanDoanSoBo"].ToString();
                    data.ChanDoanSoBo2 = DataReader["ChanDoanSoBo2"].ToString();
                    data.ChanDoanXacDinh = DataReader["ChanDoanXacDinh"].ToString();
                    data.ChanDoanXacDinh2 = DataReader["ChanDoanXacDinh2"].ToString();
                    data.HoiChan = DataReader["HoiChan"].ToString();
                    data.HoiChan2 = DataReader["HoiChan2"].ToString();
                    data.GhiDienBien = DataReader["GhiDienBien"].ToString();
                    data.GhiDienBien2 = DataReader["GhiDienBien2"].ToString();
                    data.ChoThuocHangNgay = DataReader["ChoThuocHangNgay"].ToString();
                    data.ChoThuocHangNgay2 = DataReader["ChoThuocHangNgay2"].ToString();
                    data.ChoThuocHopLy = DataReader["ChoThuocHopLy"].ToString();
                    data.ChoThuocHopLy2 = DataReader["ChoThuocHopLy2"].ToString();
                    data.GhiDungDanhPhap = DataReader["GhiDungDanhPhap"].ToString();
                    data.GhiDungDanhPhap2 = DataReader["GhiDungDanhPhap2"].ToString();
                    data.SoKet = DataReader["SoKet"].ToString();
                    data.SoKet2 = DataReader["SoKet2"].ToString();
                    data.RaVien = DataReader["RaVien"].ToString();
                    data.RaVien2 = DataReader["RaVien2"].ToString();
                    data.ThoiGian = Convert.ToDateTime(DataReader["ThoiGian"] == DBNull.Value ? DateTime.Now : DataReader["ThoiGian"]);
                    data.NguoiKiemTra = DataReader["NguoiKiemTra"].ToString();
                    data.MaNguoiKiemTra = DataReader["MaNguoiKiemTra"].ToString();
                    data.NhanXet = DataReader["NhanXet"].ToString();
                    data.XepLoai = DataReader["XepLoai"].ToString();
                    data.NgayTao = Convert.ToDateTime(DataReader["NgayTao"] == DBNull.Value ? DateTime.Now : DataReader["NgayTao"]);
                    data.NguoiTao = DataReader["NguoiTao"].ToString();
                    data.NgaySua = Convert.ToDateTime(DataReader["NgaySua"] == DBNull.Value ? DateTime.Now : DataReader["NgaySua"]);
                    data.NguoiSua = DataReader["NguoiSua"].ToString();
                    data.MaSoKy = DataReader["masokyten"].ToString();
                    data.DaKy = !string.IsNullOrEmpty(data.MaSoKy);
                }
            }
            catch (Exception ex) { XuLyLoi.Handle(ex); }
            return data;
        }
        public static List<PhieuKiemTraBenhAn> GetListData(MDB.MDBConnection _OracleConnection, decimal maquanly)
        {
            List<PhieuKiemTraBenhAn> list = new List<PhieuKiemTraBenhAn>();
            try
            {
                string sql = @"SELECT * FROM PhieuKiemTraBenhAn where MaQuanLy = :MaQuanLy";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, _OracleConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", maquanly));
                MDB.MDBDataReader DataReader = Command.ExecuteReader();
                while (DataReader.Read())
                {
                    PhieuKiemTraBenhAn data = new PhieuKiemTraBenhAn();
                    data.ID = Convert.ToInt64(DataReader.GetLong("ID").ToString());
                    data.MaQuanLy = maquanly;
                    data.ThoiGianVaoVien = Convert.ToDateTime(DataReader["ThoiGianVaoVien"] == DBNull.Value ? DateTime.Now : DataReader["ThoiGianVaoVien"]);
                    data.ThoiGianRaVien = Convert.ToDateTime(DataReader["ThoiGianRaVien"] == DBNull.Value ? DateTime.Now : DataReader["ThoiGianRaVien"]);
                    data.MaBacSyDieuTri = DataReader["MaBacSyDieuTri"].ToString();
                    data.BacSyDieuTri = DataReader["BacSyDieuTri"].ToString();
                    data.HanhChinh1 = DataReader["HanhChinh1"].ToString();
                    data.HanhChinh2 = DataReader["HanhChinh2"].ToString();
                    data.HanhChinh3 = DataReader["HanhChinh3"].ToString();
                    data.HanhChinh4 = DataReader["HanhChinh4"].ToString();
                    data.HoiBenhSu = DataReader["HoiBenhSu"].ToString();
                    data.HoiBenhSu2 = DataReader["HoiBenhSu2"].ToString();
                    data.KhamToanDien = DataReader["KhamToanDien"].ToString();
                    data.KhamToanDien2 = DataReader["KhamToanDien2"].ToString();
                    data.LamXetNghiem = DataReader["LamXetNghiem"].ToString();
                    data.LamXetNghiem2 = DataReader["LamXetNghiem2"].ToString();
                    data.ChanDoanSoBo = DataReader["ChanDoanSoBo"].ToString();
                    data.ChanDoanSoBo2 = DataReader["ChanDoanSoBo2"].ToString();
                    data.ChanDoanXacDinh = DataReader["ChanDoanXacDinh"].ToString();
                    data.ChanDoanXacDinh2 = DataReader["ChanDoanXacDinh2"].ToString();
                    data.HoiChan = DataReader["HoiChan"].ToString();
                    data.HoiChan2 = DataReader["HoiChan2"].ToString();
                    data.GhiDienBien = DataReader["GhiDienBien"].ToString();
                    data.GhiDienBien2 = DataReader["GhiDienBien2"].ToString();
                    data.ChoThuocHangNgay = DataReader["ChoThuocHangNgay"].ToString();
                    data.ChoThuocHangNgay2 = DataReader["ChoThuocHangNgay2"].ToString();
                    data.ChoThuocHopLy = DataReader["ChoThuocHopLy"].ToString();
                    data.ChoThuocHopLy2 = DataReader["ChoThuocHopLy2"].ToString();
                    data.GhiDungDanhPhap = DataReader["GhiDungDanhPhap"].ToString();
                    data.GhiDungDanhPhap2 = DataReader["GhiDungDanhPhap2"].ToString();
                    data.SoKet = DataReader["SoKet"].ToString();
                    data.SoKet2 = DataReader["SoKet2"].ToString();
                    data.RaVien = DataReader["RaVien"].ToString();
                    data.RaVien2 = DataReader["RaVien2"].ToString();
                    data.ThoiGian = Convert.ToDateTime(DataReader["ThoiGian"] == DBNull.Value ? DateTime.Now : DataReader["ThoiGian"]);
                    data.NguoiKiemTra = DataReader["NguoiKiemTra"].ToString();
                    data.MaNguoiKiemTra = DataReader["MaNguoiKiemTra"].ToString();
                    data.NhanXet = DataReader["NhanXet"].ToString();
                    data.XepLoai = DataReader["XepLoai"].ToString();
                    data.NgayTao = Convert.ToDateTime(DataReader["NgayTao"] == DBNull.Value ? DateTime.Now : DataReader["NgayTao"]);
                    data.NguoiTao = DataReader["NguoiTao"].ToString();
                    data.NgaySua = Convert.ToDateTime(DataReader["NgaySua"] == DBNull.Value ? DateTime.Now : DataReader["NgaySua"]);
                    data.NguoiSua = DataReader["NguoiSua"].ToString();
                    data.MaSoKy = DataReader["masokyten"].ToString();
                    data.DaKy = !string.IsNullOrEmpty(data.MaSoKy);
                    list.Add(data);
                }
            }
            catch (Exception ex) { XuLyLoi.Handle(ex); }
            return list;
        }
        public static bool InsertOrUpdate(MDB.MDBConnection MyConnection, ref PhieuKiemTraBenhAn data)
        {
            try
            {
                string sql = @"INSERT INTO PhieuKiemTraBenhAn
                (
                    MaQuanLy,
                    ThoiGianVaoVien,
                    ThoiGianRaVien,
                    MaBacSyDieuTri,
                    BacSyDieuTri,
                    HanhChinh1,
                    HanhChinh2,
                    HanhChinh3,
                    HanhChinh4,
                    HoiBenhSu,
                    HoiBenhSu2,
                    KhamToanDien,
                    KhamToanDien2,
                    LamXetNghiem,
                    LamXetNghiem2,
                    ChanDoanSoBo,
                    ChanDoanSoBo2,
                    ChanDoanXacDinh,
                    ChanDoanXacDinh2,
                    HoiChan,
                    HoiChan2,
                    GhiDienBien,
                    GhiDienBien2,
                    ChoThuocHangNgay,
                    ChoThuocHangNgay2,
                    ChoThuocHopLy,
                    ChoThuocHopLy2,
                    GhiDungDanhPhap,
                    GhiDungDanhPhap2,
                    SoKet,
                    SoKet2,
                    RaVien,
                    RaVien2,
                    ThoiGian,
                    MaNguoiKiemTra,
                    NguoiKiemTra,
                    NhanXet,
                    XepLoai,
                    NguoiTao,
                    NguoiSua,
                    NgayTao,
                    NgaySua)  VALUES
                 (
				    :MaQuanLy,
                    :ThoiGianVaoVien,
                    :ThoiGianRaVien,
                    :MaBacSyDieuTri,
                    :BacSyDieuTri,
                    :HanhChinh1,
                    :HanhChinh2,
                    :HanhChinh3,
                    :HanhChinh4,
                    :HoiBenhSu,
                    :HoiBenhSu2,
                    :KhamToanDien,
                    :KhamToanDien2,
                    :LamXetNghiem,
                    :LamXetNghiem2,
                    :ChanDoanSoBo,
                    :ChanDoanSoBo2,
                    :ChanDoanXacDinh,
                    :ChanDoanXacDinh2,
                    :HoiChan,
                    :HoiChan2,
                    :GhiDienBien,
                    :GhiDienBien2,
                    :ChoThuocHangNgay,
                    :ChoThuocHangNgay2,
                    :ChoThuocHopLy,
                    :ChoThuocHopLy2,
                    :GhiDungDanhPhap,
                    :GhiDungDanhPhap2,
                    :SoKet,
                    :SoKet2,
                    :RaVien,
                    :RaVien2,
                    :ThoiGian,
                    :MaNguoiKiemTra,
                    :NguoiKiemTra,
                    :NhanXet,
                    :XepLoai,
                    :NguoiTao,
                    :NguoiSua,
                    :NgayTao,
                    :NgaySua
                 )  RETURNING ID INTO :ID";
                if (data.ID != 0)
                {
                    sql = @"UPDATE PhieuKiemTraBenhAn SET 
                    MaQuanLy=:MaQuanLy,
                    ThoiGianVaoVien=:ThoiGianVaoVien,
                    ThoiGianRaVien=:ThoiGianRaVien,
                    MaBacSyDieuTri=:MaBacSyDieuTri,
                    BacSyDieuTri=:BacSyDieuTri,
                    HanhChinh1=:HanhChinh1,
                    HanhChinh2=:HanhChinh2,
                    HanhChinh3=:HanhChinh3,
                    HanhChinh4=:HanhChinh4,
                    HoiBenhSu=:HoiBenhSu,
                    HoiBenhSu2=:HoiBenhSu2,
                    KhamToanDien=:KhamToanDien,
                    KhamToanDien2=:KhamToanDien2,
                    LamXetNghiem=:LamXetNghiem,
                    LamXetNghiem2=:LamXetNghiem2,
                    ChanDoanSoBo=:ChanDoanSoBo,
                    ChanDoanSoBo2=:ChanDoanSoBo2,
                    ChanDoanXacDinh=:ChanDoanXacDinh,
                    ChanDoanXacDinh2=:ChanDoanXacDinh2,
                    HoiChan=:HoiChan,
                    HoiChan2=:HoiChan2,
                    GhiDienBien=:GhiDienBien,
                    GhiDienBien2=:GhiDienBien2,
                    ChoThuocHangNgay=:ChoThuocHangNgay,
                    ChoThuocHangNgay2=:ChoThuocHangNgay2,
                    ChoThuocHopLy=:ChoThuocHopLy,
                    ChoThuocHopLy2=:ChoThuocHopLy2,
                    GhiDungDanhPhap=:GhiDungDanhPhap,
                    GhiDungDanhPhap2=:GhiDungDanhPhap2,
                    SoKet=:SoKet,
                    SoKet2=:SoKet2,
                    RaVien=:RaVien,
                    RaVien2=:RaVien2,
                    ThoiGian=:ThoiGian,
                    MaNguoiKiemTra=:MaNguoiKiemTra,
                    NguoiKiemTra=:NguoiKiemTra,
                    NhanXet=:NhanXet,
                    XepLoai = :XepLoai,
                    NGUOISUA= :NGUOISUA,
                    NGAYSUA = :NGAYSUA 
                    WHERE ID = " + data.ID;
                }
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", data.MaQuanLy));
                Command.Parameters.Add(new MDB.MDBParameter("ThoiGianVaoVien", data.ThoiGianVaoVien));
                Command.Parameters.Add(new MDB.MDBParameter("ThoiGianRaVien", data.ThoiGianRaVien));
                Command.Parameters.Add(new MDB.MDBParameter("MaBacSyDieuTri", data.MaBacSyDieuTri));
                Command.Parameters.Add(new MDB.MDBParameter("BacSyDieuTri", data.BacSyDieuTri));
                Command.Parameters.Add(new MDB.MDBParameter("HanhChinh1", data.HanhChinh1));
                Command.Parameters.Add(new MDB.MDBParameter("HanhChinh2", data.HanhChinh2));
                Command.Parameters.Add(new MDB.MDBParameter("HanhChinh3", data.HanhChinh3));
                Command.Parameters.Add(new MDB.MDBParameter("HanhChinh4", data.HanhChinh4));
                Command.Parameters.Add(new MDB.MDBParameter("HoiBenhSu", data.HoiBenhSu));
                Command.Parameters.Add(new MDB.MDBParameter("HoiBenhSu2", data.HoiBenhSu2));
                Command.Parameters.Add(new MDB.MDBParameter("KhamToanDien", data.KhamToanDien));
                Command.Parameters.Add(new MDB.MDBParameter("KhamToanDien2", data.KhamToanDien2));
                Command.Parameters.Add(new MDB.MDBParameter("LamXetNghiem", data.LamXetNghiem));
                Command.Parameters.Add(new MDB.MDBParameter("LamXetNghiem2", data.LamXetNghiem2));
                Command.Parameters.Add(new MDB.MDBParameter("ChanDoanSoBo", data.ChanDoanSoBo));
                Command.Parameters.Add(new MDB.MDBParameter("ChanDoanSoBo2", data.ChanDoanSoBo2));
                Command.Parameters.Add(new MDB.MDBParameter("ChanDoanXacDinh", data.ChanDoanXacDinh));
                Command.Parameters.Add(new MDB.MDBParameter("ChanDoanXacDinh2", data.ChanDoanXacDinh2));
                Command.Parameters.Add(new MDB.MDBParameter("HoiChan", data.HoiChan));
                Command.Parameters.Add(new MDB.MDBParameter("HoiChan2", data.HoiChan2));
                Command.Parameters.Add(new MDB.MDBParameter("GhiDienBien", data.GhiDienBien));
                Command.Parameters.Add(new MDB.MDBParameter("GhiDienBien2", data.GhiDienBien2));
                Command.Parameters.Add(new MDB.MDBParameter("ChoThuocHangNgay", data.ChoThuocHangNgay));
                Command.Parameters.Add(new MDB.MDBParameter("ChoThuocHangNgay2", data.ChoThuocHangNgay2));
                Command.Parameters.Add(new MDB.MDBParameter("ChoThuocHopLy", data.ChoThuocHopLy));
                Command.Parameters.Add(new MDB.MDBParameter("ChoThuocHopLy2", data.ChoThuocHopLy2));
                Command.Parameters.Add(new MDB.MDBParameter("GhiDungDanhPhap", data.GhiDungDanhPhap));
                Command.Parameters.Add(new MDB.MDBParameter("GhiDungDanhPhap2", data.GhiDungDanhPhap2));
                Command.Parameters.Add(new MDB.MDBParameter("SoKet", data.SoKet));
                Command.Parameters.Add(new MDB.MDBParameter("SoKet2", data.SoKet2));
                Command.Parameters.Add(new MDB.MDBParameter("RaVien", data.RaVien));
                Command.Parameters.Add(new MDB.MDBParameter("RaVien2", data.RaVien2));
                Command.Parameters.Add(new MDB.MDBParameter("ThoiGian", data.ThoiGian));
                Command.Parameters.Add(new MDB.MDBParameter("MaNguoiKiemTra", data.MaNguoiKiemTra));
                Command.Parameters.Add(new MDB.MDBParameter("NguoiKiemTra", data.NguoiKiemTra));
                Command.Parameters.Add(new MDB.MDBParameter("NhanXet", data.NhanXet));
                Command.Parameters.Add(new MDB.MDBParameter("XepLoai", data.XepLoai));
                Command.Parameters.Add(new MDB.MDBParameter("NGUOISUA", data.NguoiSua));
                Command.Parameters.Add(new MDB.MDBParameter("NGAYSUA", data.NgaySua));
                if (data.ID == 0)
                {
                    Command.Parameters.Add(new MDB.MDBParameter("ID", data.ID));
                    Command.Parameters.Add(new MDB.MDBParameter("NGUOITAO", data.NguoiTao));
                    Command.Parameters.Add(new MDB.MDBParameter("NGAYTAO", data.NgayTao));
                }
                Command.BindByName = true;
                int n = Command.ExecuteNonQuery();
                if (data.ID == 0)
                {
                    long nextval = Convert.ToInt64((Command.Parameters["ID"] as MDB.MDBParameter).Value);
                    data.ID = nextval;
                }
                return n > 0;
            }
            catch (Exception ex)
            {
                XuLyLoi.Handle(ex);
            }
            return false;
        }
        public static bool Delete(MDB.MDBConnection MyConnection, long id)
        {
            try
            {
                string sql = "DELETE FROM PhieuKiemTraBenhAn WHERE ID = :ID";
                MDB.MDBCommand command = new MDB.MDBCommand(sql, MyConnection);
                command.Parameters.Add(new MDB.MDBParameter("ID", id));
                command.BindByName = true;
                int n = command.ExecuteNonQuery();
                return n > 0;
            }
            catch (Exception ex)
            {
                XuLyLoi.Handle(ex);
            }
            return false;
        }
        public static DataSet GetDataSet(MDB.MDBConnection MyConnection, long id)
        {
            string sql = @"SELECT
                B.*,
                '' MABENHAN,
	            '' TENBENHNHAN,
                '' TUOI
            FROM
                PhieuKiemTraBenhAn B
            WHERE
                ID = " + id;

            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
            MDB.MDBDataAdapter adt = new MDB.MDBDataAdapter(Command);
            var ds = new DataSet();
            adt.Fill(ds, "BK");
            if (ds != null || ds.Tables[0].Rows.Count > 0)
            {
                ds.Tables[0].Rows[0]["MaBenhAn"] = XemBenhAn._ThongTinDieuTri.MaBenhAn;
                ds.Tables[0].Rows[0]["TenBenhNhan"] = XemBenhAn._HanhChinhBenhNhan.TenBenhNhan;
                ds.Tables[0].Rows[0]["TUOI"] = XemBenhAn._HanhChinhBenhNhan.Tuoi;
            }
            return ds;
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
    }

}