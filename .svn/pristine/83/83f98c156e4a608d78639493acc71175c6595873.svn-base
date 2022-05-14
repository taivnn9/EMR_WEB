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
    public class PhieuChuanBiTruocCanThiep : ThongTinKy
    {
        public PhieuChuanBiTruocCanThiep()
        {
            TableName = "PhieuChuanBiTruocCanThiep";
            TablePrimaryKeyName = "ID";
            IDMauPhieu = (int)DanhMucPhieu.PCBTCTCDD;
            TenMauPhieu = DanhMucPhieu.PCBTCTCDD.Description();
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
        [MoTaDuLieu("Chẩn đoán bệnh")]
		public string ChanDoan
        {
            get
            {
                return XemBenhAn._ThongTinDieuTri.ChanDoan_KhiVaoKhoaDieuTri;
            }
        }
        public string Khoa
        {
            get
            {
                return XemBenhAn._ThongTinDieuTri.Khoa;
            }
        }
        [MoTaDuLieu("Mã quản lý: mã duy nhất trong 1 đợt khám chữa bệnh (kcb), không trùng giữa các đợt kcb khác nhau","",1)]
		public decimal MaQuanLy { get; set; }
        [MoTaDuLieu("Mã bệnh nhân")]
		public string MaBenhNhan { get; set; }
        public DateTime ThoiGian { get; set; }
        public string DiUngVoiThuoc { get; set; }
        public int VeSinh { get; set; }
        public int ThaoDoTrangSuc { get; set; }
        public int ThaoRangGia { get; set; }
        public int PhieuCamDoan { get; set; }
        public int DongTienDu { get; set; }
        public int PhimChupPhoi { get; set; }
        public int CacLoaiPhimKhac { get; set; }
        public int SieuAm { get; set; }
        public int DienTim { get; set; }
        public int CaoLong { get; set; }
        public int BienBanHoiChuan { get; set; }
        public int BsKhamTienMe { get; set; }
        public int NhinAn { get; set; }
        public int HoSoCu { get; set; }
        public int HoSoBenhAnDu { get; set; }
        [MoTaDuLieu("Mạch")]
		public string Mach { get; set; }
        [MoTaDuLieu("Nhiệt độ")]
		public string NhietDo { get; set; }
        [MoTaDuLieu("Huyết áp")]
		public string HuyetAp { get; set; }
        [MoTaDuLieu("Nhịp thở")]
		public string NhipTho { get; set; }
        [MoTaDuLieu("Chiều cao")]
		public string ChieuCao { get; set; }
        [MoTaDuLieu("Cân nặng")]
		public string CanNang { get; set; }
        [MoTaDuLieu("Nhóm máu")]
		public string NhomMau { get; set; }
        [MoTaDuLieu("HIV")]
		public string HIV { get; set; }
        public string HBS { get; set; }
        public string TestKS { get; set; }
        public string Ure { get; set; }
        public string Glucose { get; set; }
        public string Cretinin { get; set; }
        public string NaK { get; set; }
        public string AST { get; set; }
        public string ALT { get; set; }
        public DateTime ThoiGianVaoPhong { get; set; }
        public string YKien { get; set; }
        [MoTaDuLieu("Họ tên điều dưỡng")]
		public string DieuDuongChuanBi { get; set; }
        [MoTaDuLieu("Mã điều dưỡng")]
		public string MaDieuDuongChuanBi { get; set; }
        [MoTaDuLieu("Họ tên điều dưỡng")]
		public string DieuDuongNhan { get; set; }
        [MoTaDuLieu("Mã điều dưỡng")]
		public string MaDieuDuongNhan { get; set; }
        [MoTaDuLieu("Đã ký", null, 0, 0)]
		public bool DaKy { get; set; }
        [MoTaDuLieu("Ngày tạo", null, 0, 0)]
		public DateTime NgayTao { get; set; }
        [MoTaDuLieu("Người tạo", null, 0, 0)]
		public string NguoiTao { get; set; }
        [MoTaDuLieu("Ngày sửa", null, 0, 0)]
		public DateTime NgaySua { get; set; }
        [MoTaDuLieu("Người sửa", null, 0, 0)]
		public string NguoiSua { get; set; }

    }
    public class PhieuChuanBiTruocCanThiepFunc
    {
        public const string TableName = "PhieuChuanBiTruocCanThiep";
        public const string TablePrimaryKeyName = "ID";
        public static PhieuChuanBiTruocCanThiep GetListData_Phieu(MDB.MDBConnection _OracleConnection, long ID)
        {
            PhieuChuanBiTruocCanThiep data = new PhieuChuanBiTruocCanThiep();
            try
            {
                string sql = @"SELECT * FROM PhieuChuanBiTruocCanThiep where ID = :ID";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, _OracleConnection);
                Command.Parameters.Add(new MDB.MDBParameter("ID", ID));
                MDB.MDBDataReader DataReader = Command.ExecuteReader();
                while (DataReader.Read())
                {
                    data.ID = Convert.ToInt64(DataReader.GetLong("ID").ToString());
                    data.MaQuanLy = DataReader.GetDecimal("MaQuanLy");
                    data.MaBenhNhan = DataReader["MaBenhNhan"].ToString();
                    data.ThoiGian = Convert.ToDateTime(DataReader["ThoiGian"] == DBNull.Value ? DateTime.Now : DataReader["ThoiGian"]);
                    data.DiUngVoiThuoc = DataReader["DiUngVoiThuoc"].ToString();
                    data.VeSinh = ConDB_Int(DataReader["VeSinh"]);
                    data.ThaoDoTrangSuc = ConDB_Int(DataReader["ThaoDoTrangSuc"]);
                    data.ThaoRangGia = ConDB_Int(DataReader["ThaoRangGia"]);
                    data.PhieuCamDoan = ConDB_Int(DataReader["PhieuCamDoan"]);
                    data.DongTienDu = ConDB_Int(DataReader["DongTienDu"]);
                    data.PhimChupPhoi = ConDB_Int(DataReader["PhimChupPhoi"]);
                    data.CacLoaiPhimKhac = ConDB_Int(DataReader["CacLoaiPhimKhac"]);
                    data.SieuAm = ConDB_Int(DataReader["SieuAm"]);
                    data.DienTim = ConDB_Int(DataReader["DienTim"]);
                    data.CaoLong = ConDB_Int(DataReader["CaoLong"]);
                    data.BienBanHoiChuan = ConDB_Int(DataReader["BienBanHoiChuan"]);
                    data.BsKhamTienMe = ConDB_Int(DataReader["BsKhamTienMe"]);
                    data.NhinAn = ConDB_Int(DataReader["NhinAn"]);
                    data.HoSoCu = ConDB_Int(DataReader["HoSoCu"]);
                    data.HoSoBenhAnDu = ConDB_Int(DataReader["HoSoBenhAnDu"]);
                    data.Mach = DataReader["Mach"].ToString();
                    data.NhietDo = DataReader["NhietDo"].ToString();
                    data.HuyetAp = DataReader["HuyetAp"].ToString();
                    data.NhipTho = DataReader["NhipTho"].ToString();
                    data.ChieuCao = DataReader["ChieuCao"].ToString();
                    data.CanNang = DataReader["CanNang"].ToString();
                    data.NhomMau = DataReader["NhomMau"].ToString();
                    data.HIV = DataReader["HIV"].ToString();
                    data.HBS = DataReader["HBS"].ToString();
                    data.TestKS = DataReader["TestKS"].ToString();
                    data.Ure = DataReader["Ure"].ToString();
                    data.Glucose = DataReader["Glucose"].ToString();
                    data.Cretinin = DataReader["Cretinin"].ToString();
                    data.NaK = DataReader["NaK"].ToString();
                    data.AST = DataReader["AST"].ToString();
                    data.ALT = DataReader["ALT"].ToString();
                    data.ThoiGianVaoPhong = Convert.ToDateTime(DataReader["ThoiGianVaoPhong"] == DBNull.Value ? DateTime.Now : DataReader["ThoiGianVaoPhong"]);
                    data.YKien = DataReader["YKien"].ToString();
                    data.DieuDuongChuanBi = DataReader["DieuDuongChuanBi"].ToString();
                    data.MaDieuDuongChuanBi = DataReader["MaDieuDuongChuanBi"].ToString();
                    data.DieuDuongNhan = DataReader["DieuDuongNhan"].ToString();
                    data.MaDieuDuongNhan = DataReader["MaDieuDuongNhan"].ToString();

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
        public static List<PhieuChuanBiTruocCanThiep> GetListData(MDB.MDBConnection _OracleConnection, decimal maquanly)
        {
            List<PhieuChuanBiTruocCanThiep> list = new List<PhieuChuanBiTruocCanThiep>();
            try
            {
                string sql = @"SELECT * FROM PhieuChuanBiTruocCanThiep where MaQuanLy = :MaQuanLy";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, _OracleConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", maquanly));
                MDB.MDBDataReader DataReader = Command.ExecuteReader();
                while (DataReader.Read())
                {
                    PhieuChuanBiTruocCanThiep data = new PhieuChuanBiTruocCanThiep();
                    data.ID = Convert.ToInt64(DataReader.GetLong("ID").ToString());
                    data.MaQuanLy = maquanly;
                    data.MaBenhNhan = DataReader["MaBenhNhan"].ToString();
                    data.ThoiGian = Convert.ToDateTime(DataReader["ThoiGian"] == DBNull.Value ? DateTime.Now : DataReader["ThoiGian"]);
                    data.DiUngVoiThuoc = DataReader["DiUngVoiThuoc"].ToString();
                    data.VeSinh = ConDB_Int(DataReader["VeSinh"]);
                    data.ThaoDoTrangSuc = ConDB_Int(DataReader["ThaoDoTrangSuc"]);
                    data.ThaoRangGia = ConDB_Int(DataReader["ThaoRangGia"]);
                    data.PhieuCamDoan = ConDB_Int(DataReader["PhieuCamDoan"]);
                    data.DongTienDu = ConDB_Int(DataReader["DongTienDu"]);
                    data.PhimChupPhoi = ConDB_Int(DataReader["PhimChupPhoi"]);
                    data.CacLoaiPhimKhac = ConDB_Int(DataReader["CacLoaiPhimKhac"]);
                    data.SieuAm = ConDB_Int(DataReader["SieuAm"]);
                    data.DienTim = ConDB_Int(DataReader["DienTim"]);
                    data.CaoLong = ConDB_Int(DataReader["CaoLong"]);
                    data.BienBanHoiChuan = ConDB_Int(DataReader["BienBanHoiChuan"]);
                    data.BsKhamTienMe = ConDB_Int(DataReader["BsKhamTienMe"]);
                    data.NhinAn = ConDB_Int(DataReader["NhinAn"]);
                    data.HoSoCu = ConDB_Int(DataReader["HoSoCu"]);
                    data.HoSoBenhAnDu = ConDB_Int(DataReader["HoSoBenhAnDu"]);
                    data.Mach = DataReader["Mach"].ToString();
                    data.NhietDo = DataReader["NhietDo"].ToString();
                    data.HuyetAp = DataReader["HuyetAp"].ToString();
                    data.NhipTho = DataReader["NhipTho"].ToString();
                    data.ChieuCao = DataReader["ChieuCao"].ToString();
                    data.CanNang = DataReader["CanNang"].ToString();
                    data.NhomMau = DataReader["NhomMau"].ToString();
                    data.HIV = DataReader["HIV"].ToString();
                    data.HBS = DataReader["HBS"].ToString();
                    data.TestKS = DataReader["TestKS"].ToString();
                    data.Ure = DataReader["Ure"].ToString();
                    data.Glucose = DataReader["Glucose"].ToString();
                    data.Cretinin = DataReader["Cretinin"].ToString();
                    data.NaK = DataReader["NaK"].ToString();
                    data.AST = DataReader["AST"].ToString();
                    data.ALT = DataReader["ALT"].ToString();
                    data.ThoiGianVaoPhong = Convert.ToDateTime(DataReader["ThoiGianVaoPhong"] == DBNull.Value ? DateTime.Now : DataReader["ThoiGianVaoPhong"]);
                    data.YKien = DataReader["YKien"].ToString();
                    data.DieuDuongChuanBi = DataReader["DieuDuongChuanBi"].ToString();
                    data.MaDieuDuongChuanBi = DataReader["MaDieuDuongChuanBi"].ToString();
                    data.DieuDuongNhan = DataReader["DieuDuongNhan"].ToString();
                    data.MaDieuDuongNhan = DataReader["MaDieuDuongNhan"].ToString();

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
        public static bool InsertOrUpdate(MDB.MDBConnection MyConnection, ref PhieuChuanBiTruocCanThiep data)
        {
            try
            {
                string sql = @"INSERT INTO PhieuChuanBiTruocCanThiep
                (
                    MaQuanLy,
                    MaBenhNhan,
                    ThoiGian,
                    DiUngVoiThuoc,
                    VeSinh,
                    ThaoDoTrangSuc,
                    ThaoRangGia,
                    PhieuCamDoan,
                    DongTienDu,
                    PhimChupPhoi,
                    CacLoaiPhimKhac,
                    SieuAm,
                    DienTim,
                    CaoLong,
                    BienBanHoiChuan,
                    BsKhamTienMe,
                    NhinAn,
                    HoSoCu,
                    HoSoBenhAnDu,
                    Mach,
                    NhietDo,
                    HuyetAp,
                    NhipTho,
                    ChieuCao,
                    CanNang,
                    NhomMau,
                    HIV,
                    HBS,
                    TestKS,
                    Ure,
                    Glucose,
                    Cretinin,
                    NaK,
                    AST,
                    ALT,
                    ThoiGianVaoPhong,
                    YKien,
                    DieuDuongChuanBi,
                    MaDieuDuongChuanBi,
                    DieuDuongNhan,
                    MaDieuDuongNhan,
                    NGUOITAO,
                    NGUOISUA,
                    NGAYTAO,
                    NGAYSUA)  VALUES
                 (
				    :MaQuanLy,
                    :MaBenhNhan,
                    :ThoiGian,
                    :DiUngVoiThuoc,
                    :VeSinh,
                    :ThaoDoTrangSuc,
                    :ThaoRangGia,
                    :PhieuCamDoan,
                    :DongTienDu,
                    :PhimChupPhoi,
                    :CacLoaiPhimKhac,
                    :SieuAm,
                    :DienTim,
                    :CaoLong,
                    :BienBanHoiChuan,
                    :BsKhamTienMe,
                    :NhinAn,
                    :HoSoCu,
                    :HoSoBenhAnDu,
                    :Mach,
                    :NhietDo,
                    :HuyetAp,
                    :NhipTho,
                    :ChieuCao,
                    :CanNang,
                    :NhomMau,
                    :HIV,
                    :HBS,
                    :TestKS,
                    :Ure,
                    :Glucose,
                    :Cretinin,
                    :NaK,
                    :AST,
                    :ALT,
                    :ThoiGianVaoPhong,
                    :YKien,
                    :DieuDuongChuanBi,
                    :MaDieuDuongChuanBi,
                    :DieuDuongNhan,
                    :MaDieuDuongNhan,
                    :NGUOITAO,
                    :NGUOISUA,
                    :NGAYTAO,
                    :NGAYSUA
                 )  RETURNING ID INTO :ID";
                if (data.ID != 0)
                {
                    sql = @"UPDATE PhieuChuanBiTruocCanThiep SET 
                    MaQuanLy=:MaQuanLy,
                    MaBenhNhan=:MaBenhNhan,
                    ThoiGian=:ThoiGian,
                    DiUngVoiThuoc=:DiUngVoiThuoc,
                    VeSinh=:VeSinh,
                    ThaoDoTrangSuc=:ThaoDoTrangSuc,
                    ThaoRangGia=:ThaoRangGia,
                    PhieuCamDoan=:PhieuCamDoan,
                    DongTienDu=:DongTienDu,
                    PhimChupPhoi=:PhimChupPhoi,
                    CacLoaiPhimKhac=:CacLoaiPhimKhac,
                    SieuAm=:SieuAm,
                    DienTim=:DienTim,
                    CaoLong=:CaoLong,
                    BienBanHoiChuan=:BienBanHoiChuan,
                    BsKhamTienMe=:BsKhamTienMe,
                    NhinAn=:NhinAn,
                    HoSoCu=:HoSoCu,
                    HoSoBenhAnDu=:HoSoBenhAnDu,
                    Mach=:Mach,
                    NhietDo=:NhietDo,
                    HuyetAp=:HuyetAp,
                    NhipTho=:NhipTho,
                    ChieuCao=:ChieuCao,
                    CanNang=:CanNang,
                    NhomMau=:NhomMau,
                    HIV=:HIV,
                    HBS=:HBS,
                    TestKS=:TestKS,
                    Ure=:Ure,
                    Glucose=:Glucose,
                    Cretinin=:Cretinin,
                    NaK=:NaK,
                    AST=:AST,
                    ALT=:ALT,
                    ThoiGianVaoPhong=:ThoiGianVaoPhong,
                    YKien=:YKien,
                    DieuDuongChuanBi=:DieuDuongChuanBi,
                    MaDieuDuongChuanBi=:MaDieuDuongChuanBi,
                    DieuDuongNhan=:DieuDuongNhan,
                    MaDieuDuongNhan=:MaDieuDuongNhan,
                    NGUOISUA= :NGUOISUA,
                    NGAYSUA = :NGAYSUA 
                    WHERE ID = " + data.ID;
                }
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", data.MaQuanLy));
                Command.Parameters.Add(new MDB.MDBParameter("MaBenhNhan", data.MaBenhNhan));
                Command.Parameters.Add(new MDB.MDBParameter("ThoiGian", data.ThoiGian));
                Command.Parameters.Add(new MDB.MDBParameter("DiUngVoiThuoc", data.DiUngVoiThuoc));
                Command.Parameters.Add(new MDB.MDBParameter("VeSinh", data.VeSinh));
                Command.Parameters.Add(new MDB.MDBParameter("ThaoDoTrangSuc", data.ThaoDoTrangSuc));
                Command.Parameters.Add(new MDB.MDBParameter("ThaoRangGia", data.ThaoRangGia));
                Command.Parameters.Add(new MDB.MDBParameter("PhieuCamDoan", data.PhieuCamDoan));
                Command.Parameters.Add(new MDB.MDBParameter("DongTienDu", data.DongTienDu));
                Command.Parameters.Add(new MDB.MDBParameter("PhimChupPhoi", data.PhimChupPhoi));
                Command.Parameters.Add(new MDB.MDBParameter("CacLoaiPhimKhac", data.CacLoaiPhimKhac));
                Command.Parameters.Add(new MDB.MDBParameter("SieuAm", data.SieuAm));
                Command.Parameters.Add(new MDB.MDBParameter("DienTim", data.DienTim));
                Command.Parameters.Add(new MDB.MDBParameter("CaoLong", data.CaoLong));
                Command.Parameters.Add(new MDB.MDBParameter("BienBanHoiChuan", data.BienBanHoiChuan));
                Command.Parameters.Add(new MDB.MDBParameter("BsKhamTienMe", data.BsKhamTienMe));
                Command.Parameters.Add(new MDB.MDBParameter("NhinAn", data.NhinAn));
                Command.Parameters.Add(new MDB.MDBParameter("HoSoCu", data.HoSoCu));
                Command.Parameters.Add(new MDB.MDBParameter("HoSoBenhAnDu", data.HoSoBenhAnDu));
                Command.Parameters.Add(new MDB.MDBParameter("Mach", data.Mach));
                Command.Parameters.Add(new MDB.MDBParameter("NhietDo", data.NhietDo));
                Command.Parameters.Add(new MDB.MDBParameter("HuyetAp", data.HuyetAp));
                Command.Parameters.Add(new MDB.MDBParameter("NhipTho", data.NhipTho));
                Command.Parameters.Add(new MDB.MDBParameter("ChieuCao", data.ChieuCao));
                Command.Parameters.Add(new MDB.MDBParameter("CanNang", data.CanNang));
                Command.Parameters.Add(new MDB.MDBParameter("NhomMau", data.NhomMau));
                Command.Parameters.Add(new MDB.MDBParameter("HIV", data.HIV));
                Command.Parameters.Add(new MDB.MDBParameter("HBS", data.HBS));
                Command.Parameters.Add(new MDB.MDBParameter("TestKS", data.TestKS));
                Command.Parameters.Add(new MDB.MDBParameter("Ure", data.Ure));
                Command.Parameters.Add(new MDB.MDBParameter("Glucose", data.Glucose));
                Command.Parameters.Add(new MDB.MDBParameter("Cretinin", data.Cretinin));
                Command.Parameters.Add(new MDB.MDBParameter("NaK", data.NaK));
                Command.Parameters.Add(new MDB.MDBParameter("AST", data.AST));
                Command.Parameters.Add(new MDB.MDBParameter("ALT", data.ALT));
                Command.Parameters.Add(new MDB.MDBParameter("ThoiGianVaoPhong", data.ThoiGianVaoPhong));
                Command.Parameters.Add(new MDB.MDBParameter("YKien", data.YKien));
                Command.Parameters.Add(new MDB.MDBParameter("DieuDuongChuanBi", data.DieuDuongChuanBi));
                Command.Parameters.Add(new MDB.MDBParameter("MaDieuDuongChuanBi", data.MaDieuDuongChuanBi));
                Command.Parameters.Add(new MDB.MDBParameter("DieuDuongNhan", data.DieuDuongNhan));
                Command.Parameters.Add(new MDB.MDBParameter("MaDieuDuongNhan", data.MaDieuDuongNhan));

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
                string sql = "DELETE FROM PhieuChuanBiTruocCanThiep WHERE ID = :ID";
                MDB.MDBCommand command = new MDB.MDBCommand(sql, MyConnection);
                command.Parameters.Add(new MDB.MDBParameter("ID", id));
                command.BindByName = true;
                int n = command.ExecuteNonQuery();
                return n > 0 ? true : false;
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
                PhieuChuanBiTruocCanThiep B
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