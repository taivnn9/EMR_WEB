using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EMR.KyDienTu;
using PMS.Access;

namespace EMR_MAIN.DATABASE.Other
{
    public class PhieuChanDoanNguyenNhanTuVong : ThongTinKy
    {
        public PhieuChanDoanNguyenNhanTuVong()
        {
            TableName = "PhieuCDNguyenNhanTuVong";
            TablePrimaryKeyName = "ID";
            IDMauPhieu = (int)DanhMucPhieu.PCDNNTV;
            TenMauPhieu = DanhMucPhieu.PCDNNTV.Description();
        }
        [MoTaDuLieu("Mã định danh")]
        public long ID { get; set; }
        [MoTaDuLieu("Mã quản lý: mã duy nhất trong 1 đợt khám chữa bệnh (kcb), không trùng giữa các đợt kcb khác nhau", "", 1)]
        public decimal MaQuanLy { get; set; }
        [MoTaDuLieu("Mã bệnh nhân")]
        public string MaBenhNhan { get; set; }
        public string ThongTuSo { get; set; }
        public string HoVaTen { get; set; }
        public int GioiTinh { get; set; }
        public DateTime? NgaySinh { get; set; }
        public DateTime? NgayTuVong { get; set; }
        [MoTaDuLieu("Mục 1, hàng 1, cột 1")]
        public string Muc1_Ra_C1 { get; set; }
        [MoTaDuLieu("Mục 1, hàng 1, cột 2")]
        public string Muc1_Ra_C2 { get; set; }
        [MoTaDuLieu("Mục 1, hàng 2, cột 1")]
        public string Muc1_Rb_C1 { get; set; }
        [MoTaDuLieu("Mục 1, hàng 2, cột 2")]
        public string Muc1_Rb_C2 { get; set; }
        [MoTaDuLieu("Mục 1, hàng 3, cột 1")]
        public string Muc1_Rc_C1 { get; set; }
        [MoTaDuLieu("Mục 1, hàng 3, cột 2")]
        public string Muc1_Rc_C2 { get; set; }
        [MoTaDuLieu("Mục 1, hàng 4, cột 1")]
        public string Muc1_Rd_C1 { get; set; }
        [MoTaDuLieu("Mục 1, hàng 4, cột 2")]
        public string Muc1_Rd_C2 { get; set; }
        [MoTaDuLieu("Mục 2, cột 1")]
        public string Muc2_C1 { get; set; }
        [MoTaDuLieu("Mục 2, cột 2")]
        public string Muc2_C2 { get; set; }
        [MoTaDuLieu("Phần B, mục 1: 1: có, 2: không, 3: không biết")]
        public int PhanB_1 { get; set; }
        public DateTime? PhanB_11 { get; set; }
        public string PhanB_12 { get; set; }

        [MoTaDuLieu("Phần B, mục 2: 1: có, 2: không, 3: không biết")]
        public int PhanB_2 { get; set; }
        [MoTaDuLieu("Phần B, mục 2.1: 1: có, 2: không, 3: không biết")]
        public int PhanB_21 { get; set; }
        public bool[] HinhThucTuVongArray { get; } = new bool[] { false, false, false, false, false, false, false, false, false };
        public string HinhThucTuVong
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < HinhThucTuVongArray.Length; i++)
                    temp += (HinhThucTuVongArray[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        HinhThucTuVongArray[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public DateTime? NgayBiChanThuong { get; set; }
        public string MoTaNguyenNhan { get; set; }
        public bool[] NoiXayRaArray { get; } = new bool[] { false, false, false, false, false, false, false, false, false, false };
        public string NoiXayRa
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < NoiXayRaArray.Length; i++)
                    temp += (NoiXayRaArray[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        NoiXayRaArray[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public string DiaDiemKhac { get; set; }
        [MoTaDuLieu("Đa thai: 1: có, 2: không, 3: không biết")]
        public int DaThai { get; set; }
        [MoTaDuLieu("Sinh non: 1: có, 2: không, 3: không biết")]
        public int SinhNon { get; set; }
        [MoTaDuLieu("Nếu chết trong vòng 24h, ghi rõ số giờ sống sót sau sinh")]
        public string SoGioSongSot { get; set; }
        [MoTaDuLieu("Cân nặng khi sinh ( gram)")]
        public string CanNangKhiSinh { get; set; }
        [MoTaDuLieu("Số tuần mang thai của thai kỳ")]
        public string SoTuanMangThai { get; set; }
        [MoTaDuLieu("Tuổi của mẹ (năm)")]
        public string TuoiCuaMe { get; set; }
        [MoTaDuLieu("Tuổi của mẹ (năm)Nếu là chết chu sinh, xin vui lòng cho biết tình trạng của người mẹ có ảnh hưởng đến thai nhi và trẻ sơ sinh")]
        public string TinhTrangMe { get; set; }
        [MoTaDuLieu("Người chết có đang mang thai không ?: 1: cơ, 2: không, 3: không biết")]
        public int DangMangThai { get; set; }
        public bool[] ThoiDiemTuVongArray { get; } = new bool[] { false, false, false, false};
        public string ThoiDiemTuVong
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < ThoiDiemTuVongArray.Length; i++)
                    temp += (ThoiDiemTuVongArray[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        ThoiDiemTuVongArray[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        [MoTaDuLieu("Việc mang thai có góp phần gây ra tử vong không ?: 1: Có, 2: Không, 3: Không biết")]
        public int ViecMangThai { get; set; }
        public string ChanDoanChinh { get; set; }
        public string MaICD { get; set; }
        public string NguoiLapPhieu { get; set; }
        public string MaNguoiLapPhieu { get; set; }
        public string ThuTruongCoQuan { get; set; }
        public string MaThuTruongCoQuan { get; set; }
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
    public class PhieuChanDoanNguyenNhanTuVongFunc
    {
        public const string TableName = "PhieuCDNguyenNhanTuVong";
        public const string TablePrimaryKeyName = "ID";
        public static List<PhieuChanDoanNguyenNhanTuVong> GetListData(MDB.MDBConnection _OracleConnection, decimal maquanly)
        {
            List<PhieuChanDoanNguyenNhanTuVong> list = new List<PhieuChanDoanNguyenNhanTuVong>();
            try
            {
                string sql = @"SELECT * FROM PhieuCDNguyenNhanTuVong where MaQuanLy = :MaQuanLy";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, _OracleConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", maquanly));
                MDB.MDBDataReader DataReader = Command.ExecuteReader();
                while (DataReader.Read())
                {
                    PhieuChanDoanNguyenNhanTuVong data = new PhieuChanDoanNguyenNhanTuVong();
                    data.ID = Convert.ToInt64(DataReader.GetLong("ID").ToString());
                    data.MaQuanLy = maquanly;
                    data.MaBenhNhan = DataReader["MaBenhNhan"].ToString();
                    data.ThongTuSo = DataReader["ThongTuSo"].ToString();
                    data.HoVaTen = XemBenhAn._HanhChinhBenhNhan.TenBenhNhan;
                    data.GioiTinh = (int) XemBenhAn._HanhChinhBenhNhan.GioiTinh;
                    data.NgaySinh = DataReader["NgaySinh"] != DBNull.Value ? (DateTime?)Convert.ToDateTime(DataReader["NgaySinh"].ToString()) : null;
                    data.NgayTuVong = DataReader["NgayTuVong"] != DBNull.Value ? (DateTime?)Convert.ToDateTime(DataReader["NgayTuVong"].ToString()) : null;
                    data.Muc1_Ra_C1 = DataReader["Muc1_Ra_C1"].ToString();
                    data.Muc1_Ra_C2 = DataReader["Muc1_Ra_C2"].ToString();
                    data.Muc1_Rb_C1 = DataReader["Muc1_Rb_C1"].ToString();
                    data.Muc1_Rb_C2 = DataReader["Muc1_Rb_C2"].ToString();
                    data.Muc1_Rc_C1 = DataReader["Muc1_Rc_C1"].ToString();
                    data.Muc1_Rc_C2 = DataReader["Muc1_Rc_C2"].ToString();
                    data.Muc1_Rd_C1 = DataReader["Muc1_Rd_C1"].ToString();
                    data.Muc1_Rd_C2 = DataReader["Muc1_Rd_C2"].ToString();
                    data.Muc2_C1 = DataReader["Muc2_C1"].ToString();
                    data.Muc2_C2 = DataReader["Muc2_C2"].ToString();
                    data.PhanB_1 = DataReader.GetInt("PhanB_1");
                    data.PhanB_11 = DataReader["PhanB_11"] != DBNull.Value ? (DateTime?)Convert.ToDateTime(DataReader["PhanB_11"].ToString()) : null;
                    data.PhanB_12 = DataReader["PhanB_12"].ToString();
                    data.PhanB_2 = DataReader.GetInt("PhanB_2");
                    data.PhanB_21 = DataReader.GetInt("PhanB_21");
                    data.HinhThucTuVong = DataReader["HinhThucTuVong"].ToString();
                    data.NgayBiChanThuong = DataReader["NgayBiChanThuong"] != DBNull.Value ? (DateTime?)Convert.ToDateTime(DataReader["NgayBiChanThuong"].ToString()) : null;
                    data.MoTaNguyenNhan = DataReader["MoTaNguyenNhan"].ToString();
                    data.NoiXayRa = DataReader["NoiXayRa"].ToString();
                    data.DiaDiemKhac = DataReader["DiaDiemKhac"].ToString();
                    data.DaThai = DataReader.GetInt("DaThai");
                    data.SinhNon = DataReader.GetInt("SinhNon");
                    data.SoGioSongSot = DataReader["SoGioSongSot"].ToString();
                    data.CanNangKhiSinh = DataReader["CanNangKhiSinh"].ToString();
                    data.SoTuanMangThai = DataReader["SoTuanMangThai"].ToString();
                    data.TuoiCuaMe = DataReader["TuoiCuaMe"].ToString();
                    data.TinhTrangMe = DataReader["TinhTrangMe"].ToString();
                    data.DangMangThai = DataReader.GetInt("DangMangThai");
                    data.ThoiDiemTuVong = DataReader["ThoiDiemTuVong"].ToString();
                    data.ViecMangThai = DataReader.GetInt("ViecMangThai");
                    data.ChanDoanChinh = DataReader["ChanDoanChinh"].ToString();
                    data.MaICD = DataReader["MaICD"].ToString();
                    data.NguoiLapPhieu = DataReader["NguoiLapPhieu"].ToString();
                    data.MaNguoiLapPhieu = DataReader["MaNguoiLapPhieu"].ToString();
                    data.ThuTruongCoQuan = DataReader["ThuTruongCoQuan"].ToString();
                    data.MaThuTruongCoQuan = DataReader["MaThuTruongCoQuan"].ToString();

                    data.NgayTao = Convert.ToDateTime(DataReader["NgayTao"] == DBNull.Value ? DateTime.Now : DataReader["NgayTao"]);
                    data.NguoiTao = DataReader["NguoiTao"].ToString();
                    data.NgaySua = Convert.ToDateTime(DataReader["NgaySua"] == DBNull.Value ? DateTime.Now : DataReader["NgaySua"]);
                    data.NguoiSua = DataReader["NguoiSua"].ToString();

                    data.MaSoKy = DataReader["masokyten"].ToString();
                    data.DaKy = !string.IsNullOrEmpty(data.MaSoKy) ? true : false;
                    list.Add(data);
                }
            }
            catch (Exception ex) { XuLyLoi.Handle(ex); }
            return list;
        }
        public static bool InsertOrUpdate(MDB.MDBConnection MyConnection, ref PhieuChanDoanNguyenNhanTuVong ketQua)
        {
            try
            {
                string sql = @"INSERT INTO PhieuCDNguyenNhanTuVong
                (
                    MAQUANLY,
                    MaBenhNhan,
                    ThongTuSo,
                    NgaySinh,
                    NgayTuVong,
                    Muc1_Ra_C1,
                    Muc1_Ra_C2,
                    Muc1_Rb_C1,
                    Muc1_Rb_C2,
                    Muc1_Rc_C1,
                    Muc1_Rc_C2,
                    Muc1_Rd_C1,
                    Muc1_Rd_C2,
                    Muc2_C1,
                    Muc2_C2,
                    PhanB_1,
                    PhanB_11,
                    PhanB_12,
                    PhanB_2,
                    PhanB_21,
                    HinhThucTuVong,
                    NgayBiChanThuong,
                    MoTaNguyenNhan,
                    NoiXayRa,
                    DiaDiemKhac,
                    DaThai,
                    SinhNon,
                    SoGioSongSot,
                    CanNangKhiSinh,
                    SoTuanMangThai,
                    TuoiCuaMe,
                    TinhTrangMe,
                    DangMangThai,
                    ThoiDiemTuVong,
                    ViecMangThai,
                    ChanDoanChinh,
                    MaICD,
                    NguoiLapPhieu,
                    MaNguoiLapPhieu,
                    ThuTruongCoQuan,
                    MaThuTruongCoQuan,
                    NGUOITAO,
                    NGUOISUA,
                    NGAYTAO,
                    NGAYSUA)  VALUES
                 (
				    :MAQUANLY,
                    :MaBenhNhan,
                    :ThongTuSo,            
                    :NgaySinh,
                    :NgayTuVong,
                    :Muc1_Ra_C1,
                    :Muc1_Ra_C2,
                    :Muc1_Rb_C1,
                    :Muc1_Rb_C2,
                    :Muc1_Rc_C1,
                    :Muc1_Rc_C2,
                    :Muc1_Rd_C1,
                    :Muc1_Rd_C2,
                    :Muc2_C1,
                    :Muc2_C2,
                    :PhanB_1,
                    :PhanB_11,
                    :PhanB_12,
                    :PhanB_2,
                    :PhanB_21,
                    :HinhThucTuVong,
                    :NgayBiChanThuong,
                    :MoTaNguyenNhan,
                    :NoiXayRa,
                    :DiaDiemKhac,
                    :DaThai,
                    :SinhNon,
                    :SoGioSongSot,
                    :CanNangKhiSinh,
                    :SoTuanMangThai,
                    :TuoiCuaMe,
                    :TinhTrangMe,
                    :DangMangThai,
                    :ThoiDiemTuVong,
                    :ViecMangThai,
                    :ChanDoanChinh,
                    :MaICD,
                    :NguoiLapPhieu,
                    :MaNguoiLapPhieu,
                    :ThuTruongCoQuan,
                    :MaThuTruongCoQuan,
                    :NGUOITAO,
                    :NGUOISUA,
                    :NGAYTAO,
                    :NGAYSUA
                 )  RETURNING ID INTO :ID";
                if (ketQua.ID != 0)
                {
                    sql = @"UPDATE PhieuCDNguyenNhanTuVong SET 
                    MAQUANLY = :MAQUANLY,
                    MaBenhNhan = :MaBenhNhan,
                    ThongTuSo=:ThongTuSo,
                    NgaySinh=:NgaySinh,
                    NgayTuVong=:NgayTuVong,
                    Muc1_Ra_C1=:Muc1_Ra_C1,
                    Muc1_Ra_C2=:Muc1_Ra_C2,
                    Muc1_Rb_C1=:Muc1_Rb_C1,
                    Muc1_Rb_C2=:Muc1_Rb_C2,
                    Muc1_Rc_C1=:Muc1_Rc_C1,
                    Muc1_Rc_C2=:Muc1_Rc_C2,
                    Muc1_Rd_C1=:Muc1_Rd_C1,
                    Muc1_Rd_C2=:Muc1_Rd_C2,
                    Muc2_C1=:Muc2_C1,
                    Muc2_C2=:Muc2_C2,
                    PhanB_1=:PhanB_1,
                    PhanB_11=:PhanB_11,
                    PhanB_12=:PhanB_12,
                    PhanB_2=:PhanB_2,
                    PhanB_21=:PhanB_21,
                    HinhThucTuVong=:HinhThucTuVong,
                    NgayBiChanThuong=:NgayBiChanThuong,
                    MoTaNguyenNhan=:MoTaNguyenNhan,
                    NoiXayRa=:NoiXayRa,
                    DiaDiemKhac = :DiaDiemKhac,
                    DaThai=:DaThai,
                    SinhNon=:SinhNon,
                    SoGioSongSot=:SoGioSongSot,
                    CanNangKhiSinh=:CanNangKhiSinh,
                    SoTuanMangThai=:SoTuanMangThai,
                    TuoiCuaMe=:TuoiCuaMe,
                    TinhTrangMe=:TinhTrangMe,
                    DangMangThai=:DangMangThai,
                    ThoiDiemTuVong=:ThoiDiemTuVong,
                    ViecMangThai=:ViecMangThai,
                    ChanDoanChinh=:ChanDoanChinh,
                    MaICD=:MaICD,
                    NguoiLapPhieu=:NguoiLapPhieu,
                    MaNguoiLapPhieu=:MaNguoiLapPhieu,
                    ThuTruongCoQuan=:ThuTruongCoQuan,
                    MaThuTruongCoQuan=:MaThuTruongCoQuan,
                    NGUOISUA = :NGUOISUA,
                    NGAYSUA = :NGAYSUA
                    WHERE ID = " + ketQua.ID;
                }
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MAQUANLY", ketQua.MaQuanLy));
                Command.Parameters.Add(new MDB.MDBParameter("MaBenhNhan", ketQua.MaBenhNhan));
                Command.Parameters.Add(new MDB.MDBParameter("ThongTuSo", ketQua.ThongTuSo));
                Command.Parameters.Add(new MDB.MDBParameter("NgaySinh", ketQua.NgaySinh));
                Command.Parameters.Add(new MDB.MDBParameter("NgayTuVong", ketQua.NgayTuVong));
                Command.Parameters.Add(new MDB.MDBParameter("Muc1_Ra_C1", ketQua.Muc1_Ra_C1));
                Command.Parameters.Add(new MDB.MDBParameter("Muc1_Ra_C2", ketQua.Muc1_Ra_C2));
                Command.Parameters.Add(new MDB.MDBParameter("Muc1_Rb_C1", ketQua.Muc1_Rb_C1));
                Command.Parameters.Add(new MDB.MDBParameter("Muc1_Rb_C2", ketQua.Muc1_Rb_C2));
                Command.Parameters.Add(new MDB.MDBParameter("Muc1_Rc_C1", ketQua.Muc1_Rc_C1));
                Command.Parameters.Add(new MDB.MDBParameter("Muc1_Rc_C2", ketQua.Muc1_Rc_C2));
                Command.Parameters.Add(new MDB.MDBParameter("Muc1_Rd_C1", ketQua.Muc1_Rd_C1));
                Command.Parameters.Add(new MDB.MDBParameter("Muc1_Rd_C2", ketQua.Muc1_Rd_C2));
                Command.Parameters.Add(new MDB.MDBParameter("Muc2_C1", ketQua.Muc2_C1));
                Command.Parameters.Add(new MDB.MDBParameter("Muc2_C2", ketQua.Muc2_C2));
                Command.Parameters.Add(new MDB.MDBParameter("PhanB_1", ketQua.PhanB_1));
                Command.Parameters.Add(new MDB.MDBParameter("PhanB_11", ketQua.PhanB_11));
                Command.Parameters.Add(new MDB.MDBParameter("PhanB_12", ketQua.PhanB_12));
                Command.Parameters.Add(new MDB.MDBParameter("PhanB_2", ketQua.PhanB_2));
                Command.Parameters.Add(new MDB.MDBParameter("PhanB_21", ketQua.PhanB_21));
                Command.Parameters.Add(new MDB.MDBParameter("HinhThucTuVong", ketQua.HinhThucTuVong));
                Command.Parameters.Add(new MDB.MDBParameter("NgayBiChanThuong", ketQua.NgayBiChanThuong));
                Command.Parameters.Add(new MDB.MDBParameter("MoTaNguyenNhan", ketQua.MoTaNguyenNhan));
                Command.Parameters.Add(new MDB.MDBParameter("NoiXayRa", ketQua.NoiXayRa));
                Command.Parameters.Add(new MDB.MDBParameter("DiaDiemKhac", ketQua.DiaDiemKhac));
                Command.Parameters.Add(new MDB.MDBParameter("DaThai", ketQua.DaThai));
                Command.Parameters.Add(new MDB.MDBParameter("SinhNon", ketQua.SinhNon));
                Command.Parameters.Add(new MDB.MDBParameter("SoGioSongSot", ketQua.SoGioSongSot));
                Command.Parameters.Add(new MDB.MDBParameter("CanNangKhiSinh", ketQua.CanNangKhiSinh));
                Command.Parameters.Add(new MDB.MDBParameter("SoTuanMangThai", ketQua.SoTuanMangThai));
                Command.Parameters.Add(new MDB.MDBParameter("TuoiCuaMe", ketQua.TuoiCuaMe));
                Command.Parameters.Add(new MDB.MDBParameter("TinhTrangMe", ketQua.TinhTrangMe));
                Command.Parameters.Add(new MDB.MDBParameter("DangMangThai", ketQua.DangMangThai));
                Command.Parameters.Add(new MDB.MDBParameter("ThoiDiemTuVong", ketQua.ThoiDiemTuVong));
                Command.Parameters.Add(new MDB.MDBParameter("ViecMangThai", ketQua.ViecMangThai));
                Command.Parameters.Add(new MDB.MDBParameter("ChanDoanChinh", ketQua.ChanDoanChinh));
                Command.Parameters.Add(new MDB.MDBParameter("MaICD", ketQua.MaICD));
                Command.Parameters.Add(new MDB.MDBParameter("NguoiLapPhieu", ketQua.NguoiLapPhieu));
                Command.Parameters.Add(new MDB.MDBParameter("MaNguoiLapPhieu", ketQua.MaNguoiLapPhieu));
                Command.Parameters.Add(new MDB.MDBParameter("ThuTruongCoQuan", ketQua.ThuTruongCoQuan));
                Command.Parameters.Add(new MDB.MDBParameter("MaThuTruongCoQuan", ketQua.MaThuTruongCoQuan));
                Command.Parameters.Add(new MDB.MDBParameter("NGUOISUA", ketQua.NguoiSua));
                Command.Parameters.Add(new MDB.MDBParameter("NGAYSUA", ketQua.NgaySua));
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
                XuLyLoi.Handle(ex);
            }
            return false;
        }
        public static bool delete(MDB.MDBConnection MyConnection, long id)
        {
            try
            {
                string sql = "DELETE FROM PhieuCDNguyenNhanTuVong WHERE ID = :ID";
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
        public static DataSet getDataSet(MDB.MDBConnection MyConnection, long id)
        {
            string sql = @"SELECT
                P.* 
            FROM
                PhieuCDNguyenNhanTuVong P
            WHERE
                ID = " + id;

            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
            MDB.MDBDataAdapter adt = new MDB.MDBDataAdapter(Command);
            var ds = new DataSet();

            adt.Fill(ds, "KQ");

            ds.Tables[0].AddColumn("TenBenhNhan", typeof(string));
            ds.Tables[0].AddColumn("GioiTinh", typeof(int));
            ds.Tables[0].AddColumn("SOYTE", typeof(string));
            ds.Tables[0].AddColumn("BENHVIEN", typeof(string));

            ds.Tables[0].Rows[0]["TenBenhNhan"] = XemBenhAn._HanhChinhBenhNhan.TenBenhNhan;
            ds.Tables[0].Rows[0]["GioiTinh"] = (int)XemBenhAn._HanhChinhBenhNhan.GioiTinh;
            ds.Tables[0].Rows[0]["SOYTE"] = XemBenhAn._HanhChinhBenhNhan.SoYTe;
            ds.Tables[0].Rows[0]["BENHVIEN"] = XemBenhAn._HanhChinhBenhNhan.BenhVien;

            return ds;
        }
    }
}
