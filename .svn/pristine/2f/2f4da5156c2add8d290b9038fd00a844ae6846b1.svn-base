using EMR.KyDienTu;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PMS.Access;

namespace EMR_MAIN.DATABASE.Other
{
    public class KhamTruocMe_PhuLuc1
    {
        public string Mallampatti { get; set; }
        public string ASA { get; set; }
        public string NYHA { get; set; }
    }
    public class KhamTruocMe_PhuLuc2
    {
        [MoTaDuLieu("Hồng cầu")]
		public string HongCau { get; set; }
        public string HuyetSacTo { get; set; }
        public string Hct { get; set; }
        [MoTaDuLieu("Bạch cầu")]
		public string BachCau { get; set; }
        public double? DoanTrungTinh { get; set; }
        public double? DoanAxit { get; set; }
        public double? Lympho { get; set; }
        [MoTaDuLieu("Tiểu cầu")]
		public string TieuCau { get; set; }
        public string Khac { get; set; }
    }
    public class KhamTruocMe_PhuLuc3
    {
        public double? PT { get; set; }
        public string INR { get; set; }
        public string aPPT { get; set; }
        public string Fibrinogen { get; set; }
        public string Khac { get; set; }
    }
    public class KhamTruocMe_PhuLuc4
    {
        public string Ure { get; set; }
        public string Duong { get; set; }
        public string Creatimin { get; set; }
        public string Bilirubin_TP { get; set; }
        public string Bilirubin_TT { get; set; }
        public string Bilirubin_GT { get; set; }
        public string Albumin { get; set; }
        public string Khac { get; set; }
        public string Na { get; set; }
        public string K { get; set; }
        public string Cl { get; set; }
        public string SGOT { get; set; }
        public string SGPT { get; set; }
        public string CK { get; set; }
        public string CKMB { get; set; }
    }
    public class KhamTruocMe_PhuLuc5
    {
        public string HbsAg { get; set; }
        public string HCV { get; set; }
        [MoTaDuLieu("HIV")]
		public string HIV { get; set; }
        public string VDRL { get; set; }
        public string Khac { get; set; }

    }
    public class PhieuKhamTruocGayMe : ThongTinKy
    {
        public PhieuKhamTruocGayMe()
        {
            TableName = "PhieuKhamTruocGayMe";
            TablePrimaryKeyName = "ID";
            IDMauPhieu = (int)DanhMucPhieu.PKTGM;
            TenMauPhieu = DanhMucPhieu.PKTGM.Description();
        }
        [MoTaDuLieu("Mã định danh")]
		public long ID { get; set; }
        [MoTaDuLieu("Mã quản lý: mã duy nhất trong 1 đợt khám chữa bệnh (kcb), không trùng giữa các đợt kcb khác nhau","",1)]
		public decimal MaQuanLy { get; set; }
        [MoTaDuLieu("Mã bệnh nhân")]
		public string MaBenhNhan { get; set; }
        public DateTime? NgayKham { get; set; }
        [MoTaDuLieu("Mã bác sỹ khám")]
        public string MaBacSyKham { get; set; }
        [MoTaDuLieu("Bác sỹ khám")]
        public string BacSyKham { get; set; }
        public string HoVaTen { get; set; }
        [MoTaDuLieu("Tuổi bệnh nhân")]
		public string Tuoi { get; set; }
        public string Gioi { get; set; }
        public double? CanNang { get; set; }
        public double? ChieuCao { get; set; }
        public double? DienTichDa { get; set; }
        public DateTime? NgayPTDuKien { get; set; }
        [MoTaDuLieu("Chẩn đoán bệnh")]
		public string ChanDoanTruocKhiMo { get; set; }
        public string PhuongPhapPTDuKien { get; set; }
        public string MaPhauThuatVien { get; set; }
        public string PhauThuatVien { get; set; }
        public string PhuongPhapVoCam { get; set; }
        [MoTaDuLieu("Nhóm máu")]
		public string NhomMau { get; set; }
        // tien su benh nhan
        public string DauNguc { get; set; }
        public string HoMau { get; set; }
        public string HoiHopTrongNguc { get; set; }
        public string Ngat { get; set; }
        public string MetKhiGangSuc { get; set; }
        public string KhoTho { get; set; }
        public string Hen { get; set; }
        public string TruyenMau { get; set; }
        public string DiUng { get; set; }
        public string DdTaTrang { get; set; }
        public string CaoHA { get; set; }
        public string DaiDuong { get; set; }
        public string Nghien { get; set; }
        public string NoiKhoa_Khac { get; set; }
        public string NgoaiKhoa { get; set; }
        public string DieuTriHienTai { get; set; }
        // Kham hien tai
        public string ToanTrang { get; set; }
        public string Tim { get; set; }
        public string TinhTrangMachMau { get; set; }
        public string TestAllenPhai { get; set; }
        public string TestAllenTrai { get; set; }
        public string Phoi { get; set; }
        public string TieuHoa { get; set; }
        public string TietNieu_SinhDuc { get; set; }
        public string ThanKinh { get; set; }
        public string CoXuongKhop { get; set; }
        public string RHM { get; set; }
        public string THM { get; set; }
        public string DienTamDo { get; set; }
        public string XQuangTimPhoi { get; set; }
        public string SieuAmTim { get; set; }
        public string KhamHienTai_Khac { get; set; }
        public string ThuocTienMe { get; set; }
        public KhamTruocMe_PhuLuc1 PhuLuc1 { get; set; }
        public KhamTruocMe_PhuLuc2 PhuLuc2 { get; set; }
        public KhamTruocMe_PhuLuc3 PhuLuc3 { get; set; }
        public KhamTruocMe_PhuLuc4 PhuLuc4 { get; set; }
        public KhamTruocMe_PhuLuc5 PhuLuc5 { get; set; }
        public DateTime? KhamLaiTruocMo { get; set; }
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
        [MoTaDuLieu("Chọn", null, 0, 0)]
		public bool Chon { get; set; }
    }
    public class PhieuKhamTruocGayMeFunc
    {
        public const string TableName = "PhieuKhamTruocGayMe";
        public const string TablePrimaryKeyName = "ID";
        public const string MaPhieu = "PKTGM";
        public static List<PhieuKhamTruocGayMe> GetListData(MDB.MDBConnection _OracleConnection, decimal maquanly)
        {
            List<PhieuKhamTruocGayMe> list = new List<PhieuKhamTruocGayMe>();
            try
            {
                string sql = @"SELECT * FROM PhieuKhamTruocGayMe where MaQuanLy = :MaQuanLy";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, _OracleConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", maquanly));
                MDB.MDBDataReader DataReader = Command.ExecuteReader();
                while (DataReader.Read())
                {
                    PhieuKhamTruocGayMe data = new PhieuKhamTruocGayMe();
                    data.ID = Convert.ToInt64(DataReader.GetLong("ID").ToString());
                    data.MaQuanLy = maquanly;
                    data.MaBenhNhan = DataReader["MaBenhNhan"].ToString();
                    data.NgayKham = DataReader["NgayKham"] == DBNull.Value ? (DateTime?) null : DataReader.GetDate("NgayKham");
                    data.MaBacSyKham = DataReader["MaBacSyKham"].ToString();
                    data.BacSyKham = DataReader["BacSyKham"].ToString();
                    data.HoVaTen = DataReader["HoVaTen"].ToString();
                    data.Tuoi = DataReader["Tuoi"].ToString();
                    data.Gioi = DataReader["Gioi"].ToString();
                    double tempDouble = 0;
                    data.CanNang = double.TryParse(DataReader["CanNang"].ToString(), out tempDouble) ? (double?) tempDouble : null;
                    tempDouble = 0;
                    data.ChieuCao = double.TryParse(DataReader["ChieuCao"].ToString(), out tempDouble) ? (double?)tempDouble : null;
                    tempDouble = 0;
                    data.DienTichDa = double.TryParse(DataReader["DienTichDa"].ToString(), out tempDouble) ? (double?)tempDouble : null;
                    data.NgayPTDuKien = DataReader["NgayPTDuKien"] == DBNull.Value ? (DateTime?)null : DataReader.GetDate("NgayPTDuKien");
                    data.ChanDoanTruocKhiMo = DataReader["ChanDoanTruocKhiMo"].ToString();
                    data.PhuongPhapPTDuKien = DataReader["PhuongPhapPTDuKien"].ToString();
                    data.MaPhauThuatVien = DataReader["MaPhauThuatVien"].ToString();
                    data.PhauThuatVien = DataReader["PhauThuatVien"].ToString();
                    data.PhuongPhapVoCam = DataReader["PhuongPhapVoCam"].ToString();
                    data.NhomMau = DataReader["NhomMau"].ToString();
                    data.DauNguc = DataReader["DauNguc"].ToString();
                    data.HoMau = DataReader["HoMau"].ToString();
                    data.HoiHopTrongNguc = DataReader["HoiHopTrongNguc"].ToString();
                    data.Ngat = DataReader["Ngat"].ToString();
                    data.MetKhiGangSuc = DataReader["MetKhiGangSuc"].ToString();
                    data.KhoTho = DataReader["KhoTho"].ToString();
                    data.Hen = DataReader["Hen"].ToString();
                    data.TruyenMau = DataReader["TruyenMau"].ToString();
                    data.DiUng = DataReader["DiUng"].ToString();
                    data.DdTaTrang = DataReader["DdTaTrang"].ToString();
                    data.CaoHA = DataReader["CaoHA"].ToString();
                    data.DaiDuong = DataReader["DaiDuong"].ToString();
                    data.Nghien = DataReader["Nghien"].ToString();
                    data.NoiKhoa_Khac = DataReader["NoiKhoa_Khac"].ToString();
                    data.NgoaiKhoa = DataReader["NgoaiKhoa"].ToString();
                    data.DieuTriHienTai = DataReader["DieuTriHienTai"].ToString();
                    data.ToanTrang = DataReader["ToanTrang"].ToString();
                    data.Tim = DataReader["Tim"].ToString();
                    data.TinhTrangMachMau = DataReader["TinhTrangMachMau"].ToString();
                    data.TestAllenPhai = DataReader["TestAllenPhai"].ToString();
                    data.TestAllenTrai = DataReader["TestAllenTrai"].ToString();
                    data.Phoi = DataReader["Phoi"].ToString();
                    data.TieuHoa = DataReader["TieuHoa"].ToString();
                    data.TietNieu_SinhDuc = DataReader["TietNieu_SinhDuc"].ToString();
                    data.ThanKinh = DataReader["ThanKinh"].ToString();
                    data.CoXuongKhop = DataReader["CoXuongKhop"].ToString();
                    data.RHM = DataReader["RHM"].ToString();
                    data.THM = DataReader["THM"].ToString();
                    data.DienTamDo = DataReader["DienTamDo"].ToString();
                    data.XQuangTimPhoi = DataReader["XQuangTimPhoi"].ToString();
                    data.SieuAmTim = DataReader["SieuAmTim"].ToString();
                    data.KhamHienTai_Khac = DataReader["KhamHienTai_Khac"].ToString();
                    data.ThuocTienMe = DataReader["ThuocTienMe"].ToString();
                    data.PhuLuc1 = JsonConvert.DeserializeObject<KhamTruocMe_PhuLuc1>(DataReader["PhuLuc1"].ToString());
                    data.PhuLuc2 = JsonConvert.DeserializeObject<KhamTruocMe_PhuLuc2>(DataReader["PhuLuc2"].ToString());
                    data.PhuLuc3 = JsonConvert.DeserializeObject<KhamTruocMe_PhuLuc3>(DataReader["PhuLuc3"].ToString());
                    data.PhuLuc4 = JsonConvert.DeserializeObject<KhamTruocMe_PhuLuc4>(DataReader["PhuLuc4"].ToString());
                    data.PhuLuc5 = JsonConvert.DeserializeObject<KhamTruocMe_PhuLuc5>(DataReader["PhuLuc5"].ToString());
                    data.KhamLaiTruocMo = DataReader["KhamLaiTruocMo"] == DBNull.Value ? (DateTime?)null : DataReader.GetDate("KhamLaiTruocMo");

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
        public static bool InsertOrUpdate(MDB.MDBConnection MyConnection, ref PhieuKhamTruocGayMe bangKiem)
        {
            try
            {
                string sql = @"INSERT INTO PhieuKhamTruocGayMe
                (
                    MAQUANLY,
                    MaBenhNhan,
                    NgayKham,
                    MaBacSyKham,
                    BacSyKham,
                    HoVaTen,
                    Tuoi,
                    Gioi,
                    CanNang,
                    ChieuCao,
                    DienTichDa,
                    NgayPTDuKien,
                    ChanDoanTruocKhiMo,
                    PhuongPhapPTDuKien,
                    MaPhauThuatVien,
                    PhauThuatVien,
                    PhuongPhapVoCam,
                    NhomMau,
                    DauNguc,
                    HoMau,
                    HoiHopTrongNguc,
                    Ngat,
                    MetKhiGangSuc,
                    KhoTho,
                    Hen,
                    TruyenMau,
                    DiUng,
                    DdTaTrang,
                    CaoHA,
                    DaiDuong,
                    Nghien,
                    NoiKhoa_Khac,
                    NgoaiKhoa,
                    DieuTriHienTai,
                    ToanTrang,
                    Tim,
                    TinhTrangMachMau,
                    TestAllenPhai,
                    TestAllenTrai,
                    Phoi,
                    TieuHoa,
                    TietNieu_SinhDuc,
                    ThanKinh,
                    CoXuongKhop,
                    RHM,
                    THM,
                    DienTamDo,
                    XQuangTimPhoi,
                    SieuAmTim,
                    KhamHienTai_Khac,
                    ThuocTienMe,
                    PhuLuc1,
                    PhuLuc2,
                    PhuLuc3,
                    PhuLuc4,
                    PhuLuc5,
                    KhamLaiTruocMo,
                    NGUOITAO,
                    NGUOISUA,
                    NGAYTAO,
                    NGAYSUA)  VALUES
                 (
				    :MAQUANLY,
                    :MaBenhNhan,
                    :NgayKham,
                    :MaBacSyKham,
                    :BacSyKham,
                    :HoVaTen,
                    :Tuoi,
                    :Gioi,
                    :CanNang,
                    :ChieuCao,
                    :DienTichDa,
                    :NgayPTDuKien,
                    :ChanDoanTruocKhiMo,
                    :PhuongPhapPTDuKien,
                    :MaPhauThuatVien,
                    :PhauThuatVien,
                    :PhuongPhapVoCam,
                    :NhomMau,
                    :DauNguc,
                    :HoMau,
                    :HoiHopTrongNguc,
                    :Ngat,
                    :MetKhiGangSuc,
                    :KhoTho,
                    :Hen,
                    :TruyenMau,
                    :DiUng,
                    :DdTaTrang,
                    :CaoHA,
                    :DaiDuong,
                    :Nghien,
                    :NoiKhoa_Khac,
                    :NgoaiKhoa,
                    :DieuTriHienTai,
                    :ToanTrang,
                    :Tim,
                    :TinhTrangMachMau,
                    :TestAllenPhai,
                    :TestAllenTrai,
                    :Phoi,
                    :TieuHoa,
                    :TietNieu_SinhDuc,
                    :ThanKinh,
                    :CoXuongKhop,
                    :RHM,
                    :THM,
                    :DienTamDo,
                    :XQuangTimPhoi,
                    :SieuAmTim,
                    :KhamHienTai_Khac,
                    :ThuocTienMe,
                    :PhuLuc1,
                    :PhuLuc2,
                    :PhuLuc3,
                    :PhuLuc4,
                    :PhuLuc5,
                    :KhamLaiTruocMo,
                    :NGUOITAO,
                    :NGUOISUA,
                    :NGAYTAO,
                    :NGAYSUA
                 )  RETURNING ID INTO :ID";
                if (bangKiem.ID != 0)
                {
                    sql = @"UPDATE PhieuKhamTruocGayMe SET 
                    MAQUANLY = :MAQUANLY,
                    MaBenhNhan = :MaBenhNhan,
                    NgayKham = :NgayKham,
                    MaBacSyKham = :MaBacSyKham,
                    BacSyKham = :BacSyKham,
                    HoVaTen = :HoVaTen,
                    Tuoi = :Tuoi,
                    Gioi = :Gioi,
                    CanNang = :CanNang,
                    ChieuCao = :ChieuCao,
                    DienTichDa = :DienTichDa,
                    NgayPTDuKien = :NgayPTDuKien,
                    ChanDoanTruocKhiMo = :ChanDoanTruocKhiMo,
                    PhuongPhapPTDuKien = :PhuongPhapPTDuKien,
                    MaPhauThuatVien = :MaPhauThuatVien,
                    PhauThuatVien = :PhauThuatVien,
                    PhuongPhapVoCam = :PhuongPhapVoCam,
                    NhomMau = :NhomMau,
                    DauNguc = :DauNguc,
                    HoMau = :HoMau,
                    HoiHopTrongNguc = :HoiHopTrongNguc,
                    Ngat = :Ngat,
                    MetKhiGangSuc = :MetKhiGangSuc,
                    KhoTho = :KhoTho,
                    Hen = :Hen,
                    TruyenMau = :TruyenMau,
                    DiUng = :DiUng,
                    DdTaTrang = :DdTaTrang,
                    CaoHA = :CaoHA,
                    DaiDuong = :DaiDuong,
                    Nghien = :Nghien,
                    NoiKhoa_Khac = :NoiKhoa_Khac,
                    NgoaiKhoa = :NgoaiKhoa,
                    DieuTriHienTai = :DieuTriHienTai,
                    ToanTrang = :ToanTrang,
                    Tim = :Tim,
                    TinhTrangMachMau = :TinhTrangMachMau,
                    TestAllenPhai = :TestAllenPhai,
                    TestAllenTrai = :TestAllenTrai,
                    Phoi = :Phoi,
                    TieuHoa = :TieuHoa,
                    TietNieu_SinhDuc = :TietNieu_SinhDuc,
                    ThanKinh = :ThanKinh,
                    CoXuongKhop = :CoXuongKhop,
                    RHM = :RHM,
                    THM = :THM,
                    DienTamDo = :DienTamDo,
                    XQuangTimPhoi = :XQuangTimPhoi,
                    SieuAmTim = :SieuAmTim,
                    KhamHienTai_Khac = :KhamHienTai_Khac,
                    ThuocTienMe = :ThuocTienMe,
                    PhuLuc1 = :PhuLuc1,
                    PhuLuc2 = :PhuLuc2,
                    PhuLuc3 = :PhuLuc3,
                    PhuLuc4 = :PhuLuc4,
                    PhuLuc5 = :PhuLuc5,
                    KhamLaiTruocMo = :KhamLaiTruocMo,
                    NGUOISUA = :NGUOISUA,
                    NGAYSUA = :NGAYSUA 
                    WHERE ID = " + bangKiem.ID;
                }
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MAQUANLY", bangKiem.MaQuanLy));
                Command.Parameters.Add(new MDB.MDBParameter("MaBenhNhan", bangKiem.MaBenhNhan));
                Command.Parameters.Add(new MDB.MDBParameter("NgayKham", bangKiem.NgayKham));
                Command.Parameters.Add(new MDB.MDBParameter("MaBacSyKham", bangKiem.MaBacSyKham));
                Command.Parameters.Add(new MDB.MDBParameter("BacSyKham", bangKiem.BacSyKham));
                Command.Parameters.Add(new MDB.MDBParameter("HoVaTen", bangKiem.HoVaTen));
                Command.Parameters.Add(new MDB.MDBParameter("Tuoi", bangKiem.Tuoi));
                Command.Parameters.Add(new MDB.MDBParameter("Gioi", bangKiem.Gioi));
                Command.Parameters.Add(new MDB.MDBParameter("CanNang", bangKiem.CanNang));
                Command.Parameters.Add(new MDB.MDBParameter("ChieuCao", bangKiem.ChieuCao));
                Command.Parameters.Add(new MDB.MDBParameter("DienTichDa", bangKiem.DienTichDa));
                Command.Parameters.Add(new MDB.MDBParameter("NgayPTDuKien", bangKiem.NgayPTDuKien));
                Command.Parameters.Add(new MDB.MDBParameter("ChanDoanTruocKhiMo", bangKiem.ChanDoanTruocKhiMo));
                Command.Parameters.Add(new MDB.MDBParameter("PhuongPhapPTDuKien", bangKiem.PhuongPhapPTDuKien));
                Command.Parameters.Add(new MDB.MDBParameter("MaPhauThuatVien", bangKiem.MaPhauThuatVien));
                Command.Parameters.Add(new MDB.MDBParameter("PhauThuatVien", bangKiem.PhauThuatVien));
                Command.Parameters.Add(new MDB.MDBParameter("PhuongPhapVoCam", bangKiem.PhuongPhapVoCam));
                Command.Parameters.Add(new MDB.MDBParameter("NhomMau", bangKiem.NhomMau));
                Command.Parameters.Add(new MDB.MDBParameter("DauNguc", bangKiem.DauNguc));
                Command.Parameters.Add(new MDB.MDBParameter("HoMau", bangKiem.HoMau));
                Command.Parameters.Add(new MDB.MDBParameter("HoiHopTrongNguc", bangKiem.HoiHopTrongNguc));
                Command.Parameters.Add(new MDB.MDBParameter("Ngat", bangKiem.Ngat));
                Command.Parameters.Add(new MDB.MDBParameter("MetKhiGangSuc", bangKiem.MetKhiGangSuc));
                Command.Parameters.Add(new MDB.MDBParameter("KhoTho", bangKiem.KhoTho));
                Command.Parameters.Add(new MDB.MDBParameter("Hen", bangKiem.Hen));
                Command.Parameters.Add(new MDB.MDBParameter("TruyenMau", bangKiem.TruyenMau));
                Command.Parameters.Add(new MDB.MDBParameter("DiUng", bangKiem.DiUng));
                Command.Parameters.Add(new MDB.MDBParameter("DdTaTrang", bangKiem.DdTaTrang));
                Command.Parameters.Add(new MDB.MDBParameter("CaoHA", bangKiem.CaoHA));
                Command.Parameters.Add(new MDB.MDBParameter("DaiDuong", bangKiem.DaiDuong));
                Command.Parameters.Add(new MDB.MDBParameter("Nghien", bangKiem.Nghien));
                Command.Parameters.Add(new MDB.MDBParameter("NoiKhoa_Khac", bangKiem.NoiKhoa_Khac));
                Command.Parameters.Add(new MDB.MDBParameter("NgoaiKhoa", bangKiem.NgoaiKhoa));
                Command.Parameters.Add(new MDB.MDBParameter("DieuTriHienTai", bangKiem.DieuTriHienTai));
                Command.Parameters.Add(new MDB.MDBParameter("ToanTrang", bangKiem.ToanTrang));
                Command.Parameters.Add(new MDB.MDBParameter("Tim", bangKiem.Tim));
                Command.Parameters.Add(new MDB.MDBParameter("TinhTrangMachMau", bangKiem.TinhTrangMachMau));
                Command.Parameters.Add(new MDB.MDBParameter("TestAllenPhai", bangKiem.TestAllenPhai));
                Command.Parameters.Add(new MDB.MDBParameter("TestAllenTrai", bangKiem.TestAllenTrai));
                Command.Parameters.Add(new MDB.MDBParameter("Phoi", bangKiem.Phoi));
                Command.Parameters.Add(new MDB.MDBParameter("TieuHoa", bangKiem.TieuHoa));
                Command.Parameters.Add(new MDB.MDBParameter("TietNieu_SinhDuc", bangKiem.TietNieu_SinhDuc));
                Command.Parameters.Add(new MDB.MDBParameter("ThanKinh", bangKiem.ThanKinh));
                Command.Parameters.Add(new MDB.MDBParameter("CoXuongKhop", bangKiem.CoXuongKhop));
                Command.Parameters.Add(new MDB.MDBParameter("RHM", bangKiem.RHM));
                Command.Parameters.Add(new MDB.MDBParameter("THM", bangKiem.THM));
                Command.Parameters.Add(new MDB.MDBParameter("DienTamDo", bangKiem.DienTamDo));
                Command.Parameters.Add(new MDB.MDBParameter("XQuangTimPhoi", bangKiem.XQuangTimPhoi));
                Command.Parameters.Add(new MDB.MDBParameter("SieuAmTim", bangKiem.SieuAmTim));
                Command.Parameters.Add(new MDB.MDBParameter("KhamHienTai_Khac", bangKiem.KhamHienTai_Khac));
                Command.Parameters.Add(new MDB.MDBParameter("ThuocTienMe", bangKiem.ThuocTienMe));
                Command.Parameters.Add(new MDB.MDBParameter("PhuLuc1", JsonConvert.SerializeObject(bangKiem.PhuLuc1)));
                Command.Parameters.Add(new MDB.MDBParameter("PhuLuc2", JsonConvert.SerializeObject(bangKiem.PhuLuc2)));
                Command.Parameters.Add(new MDB.MDBParameter("PhuLuc3", JsonConvert.SerializeObject(bangKiem.PhuLuc3)));
                Command.Parameters.Add(new MDB.MDBParameter("PhuLuc4", JsonConvert.SerializeObject(bangKiem.PhuLuc4)));
                Command.Parameters.Add(new MDB.MDBParameter("PhuLuc5", JsonConvert.SerializeObject(bangKiem.PhuLuc5)));
                Command.Parameters.Add(new MDB.MDBParameter("KhamLaiTruocMo",bangKiem.KhamLaiTruocMo));


                Command.Parameters.Add(new MDB.MDBParameter("NGUOISUA", bangKiem.NguoiSua));
                Command.Parameters.Add(new MDB.MDBParameter("NGAYSUA", bangKiem.NgaySua));
                if (bangKiem.ID == 0)
                {
                    Command.Parameters.Add(new MDB.MDBParameter("ID", bangKiem.ID));
                    Command.Parameters.Add(new MDB.MDBParameter("NGUOITAO", bangKiem.NguoiTao));
                    Command.Parameters.Add(new MDB.MDBParameter("NGAYTAO", bangKiem.NgayTao));
                }
                Command.BindByName = true;
                int n = Command.ExecuteNonQuery();
                if (bangKiem.ID == 0)
                {
                    long nextval = Convert.ToInt64((Command.Parameters["ID"] as MDB.MDBParameter).Value);
                    bangKiem.ID = nextval;
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
                string sql = "DELETE FROM PhieuKhamTruocGayMe WHERE ID = :ID";
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
                B.MAQUANLY,
                B.MaBenhNhan,
                B.NgayKham,
                B.MaBacSyKham,
                B.BacSyKham,
                B.HoVaTen,
                B.Tuoi,
                B.Gioi,
                B.CanNang,
                B.ChieuCao,
                B.DienTichDa,
                B.NgayPTDuKien,
                B.ChanDoanTruocKhiMo,
                B.PhuongPhapPTDuKien,
                B.MaPhauThuatVien,
                B.PhauThuatVien,
                B.PhuongPhapVoCam,
                B.NhomMau,
                B.DauNguc,
                B.HoMau,
                B.HoiHopTrongNguc,
                B.Ngat,
                B.MetKhiGangSuc,
                B.KhoTho,
                B.Hen,
                B.TruyenMau,
                B.DiUng,
                B.DdTaTrang,
                B.CaoHA,
                B.DaiDuong,
                B.Nghien,
                B.NoiKhoa_Khac,
                B.NgoaiKhoa,
                B.DieuTriHienTai,
                B.ToanTrang,
                B.Tim,
                B.TinhTrangMachMau,
                B.TestAllenPhai,
                B.TestAllenTrai,
                B.Phoi,
                B.TieuHoa,
                B.TietNieu_SinhDuc,
                B.ThanKinh,
                B.CoXuongKhop,
                B.RHM,
                B.THM,
                B.DienTamDo,
                B.XQuangTimPhoi,
                B.SieuAmTim,
                B.KhamHienTai_Khac,
                B.ThuocTienMe,
                B.KhamLaiTruocMo,
                H.SOYTE,
                H.BENHVIEN,
                T.KHOA,
                T.MaBenhAn 
            FROM
                PhieuKhamTruocGayMe B
                LEFT JOIN HANHCHINHBENHNHAN H ON B.MABENHNHAN = H.MABENHNHAN
                LEFT JOIN THONGTINDIEUTRI T ON B.MAQUANLY = T.MAQUANLY
            WHERE
                ID = " + id;

            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
            MDB.MDBDataAdapter adt = new MDB.MDBDataAdapter(Command);
            var ds = new DataSet();

            adt.Fill(ds, "PK");
            sql = @"SELECT
                B.PhuLuc1, B.PhuLuc2, B.PhuLuc3, B.PhuLuc4, B.PhuLuc5
            FROM
                PhieuKhamTruocGayMe B
                
            WHERE
                ID = " + id;

            Command = new MDB.MDBCommand(sql, MyConnection);
            MDB.MDBDataReader DataReader = Command.ExecuteReader();
            KhamTruocMe_PhuLuc1 PhuLuc1 = new KhamTruocMe_PhuLuc1();
            KhamTruocMe_PhuLuc2 PhuLuc2 = new KhamTruocMe_PhuLuc2();
            KhamTruocMe_PhuLuc3 PhuLuc3 = new KhamTruocMe_PhuLuc3();
            KhamTruocMe_PhuLuc4 PhuLuc4 = new KhamTruocMe_PhuLuc4();
            KhamTruocMe_PhuLuc5 PhuLuc5 = new KhamTruocMe_PhuLuc5();
            while (DataReader.Read())
            {
                PhuLuc1 = JsonConvert.DeserializeObject<KhamTruocMe_PhuLuc1>(DataReader["PhuLuc1"].ToString());
                PhuLuc2 = JsonConvert.DeserializeObject<KhamTruocMe_PhuLuc2>(DataReader["PhuLuc2"].ToString());
                PhuLuc3 = JsonConvert.DeserializeObject<KhamTruocMe_PhuLuc3>(DataReader["PhuLuc3"].ToString());
                PhuLuc4 = JsonConvert.DeserializeObject<KhamTruocMe_PhuLuc4>(DataReader["PhuLuc4"].ToString());
                PhuLuc5 = JsonConvert.DeserializeObject<KhamTruocMe_PhuLuc5>(DataReader["PhuLuc5"].ToString());
                break;
            }
            DataTable PL1 = new DataTable("PL1");
            PL1.Columns.Add("Mallampatti");
            PL1.Columns.Add("ASA");
            PL1.Columns.Add("NYHA");
            
            PL1.Rows.Add(PhuLuc1.Mallampatti, PhuLuc1.ASA, PhuLuc1.NYHA);


            DataTable PL2 = new DataTable("PL2");
            PL2.Columns.Add("HongCau");
            PL2.Columns.Add("HuyetSacTo");
            PL2.Columns.Add("Hct");
            PL2.Columns.Add("BachCau");
            PL2.Columns.Add("DoanTrungTinh");
            PL2.Columns.Add("DoanAxit");
            PL2.Columns.Add("Lympho");
            PL2.Columns.Add("TieuCau");
            PL2.Columns.Add("Khac");

            PL2.Rows.Add(PhuLuc2.HongCau, PhuLuc2.HuyetSacTo, PhuLuc2.Hct, PhuLuc2.BachCau, PhuLuc2.DoanTrungTinh, PhuLuc2.DoanAxit, PhuLuc2.Lympho, PhuLuc2.TieuCau, PhuLuc2.Khac);

            DataTable PL3 = new DataTable("PL3");
            PL3.Columns.Add("PT");
            PL3.Columns.Add("INR");
            PL3.Columns.Add("aPPT");
            PL3.Columns.Add("Fibrinogen");
            PL3.Columns.Add("Khac");

            PL3.Rows.Add(PhuLuc3.PT, PhuLuc3.INR, PhuLuc3.aPPT, PhuLuc3.Fibrinogen, PhuLuc3.Khac);


            DataTable PL4 = new DataTable("PL4");
            PL4.Columns.Add("Ure");
            PL4.Columns.Add("Duong");
            PL4.Columns.Add("Creatimin");
            PL4.Columns.Add("Bilirubin_TP");
            PL4.Columns.Add("Bilirubin_TT");
            PL4.Columns.Add("Bilirubin_GT");
            PL4.Columns.Add("Albumin");
            PL4.Columns.Add("Khac");
            PL4.Columns.Add("Na");
            PL4.Columns.Add("K");
            PL4.Columns.Add("Cl");
            PL4.Columns.Add("SGOT");
            PL4.Columns.Add("SGPT");
            PL4.Columns.Add("CK");
            PL4.Columns.Add("CKMB");
            PL4.Rows.Add(PhuLuc4.Ure, PhuLuc4.Duong, PhuLuc4.Creatimin, PhuLuc4.Bilirubin_TP, PhuLuc4.Bilirubin_TT,
                PhuLuc4.Bilirubin_GT, PhuLuc4.Albumin, PhuLuc4.Khac, PhuLuc4.Na, PhuLuc4.K,
                PhuLuc4.Cl, PhuLuc4.SGOT, PhuLuc4.SGPT, PhuLuc4.CK, PhuLuc4.CKMB);

            DataTable PL5 = new DataTable("PL5");
            PL5.Columns.Add("HbsAg");
            PL5.Columns.Add("HCV");
            PL5.Columns.Add("HIV");
            PL5.Columns.Add("VDRL");
            PL5.Columns.Add("Khac");

            PL5.Rows.Add(PhuLuc5.HbsAg, PhuLuc5.HCV, PhuLuc5.HIV, PhuLuc5.VDRL, PhuLuc5.Khac);

            ds.Tables.Add(PL1);
            ds.Tables.Add(PL2);
            ds.Tables.Add(PL3);
            ds.Tables.Add(PL4);
            ds.Tables.Add(PL5);
            return ds;
        }
    }
}
