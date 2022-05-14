using EMR.KyDienTu;
using PMS.Access;
using System;
using System.Collections.Generic;
using System.Data;

namespace EMR_MAIN.DATABASE.Other
{
    public class TaiKhamViemGanBManTinh : ThongTinKy
    {
        // bắt buộc tạo contructor
        public TaiKhamViemGanBManTinh()
        {
            TableName = "TaiKhamViemGanBManTinh";
            TablePrimaryKeyName = "ID";
            IDMauPhieu = (int)DanhMucPhieu.TKBAVGBMT;
            TenMauPhieu = DanhMucPhieu.TKBAVGBMT.Description();
        }
        // bắt buộc phải có trường, ID, MaQuanLy, MaBenhNhan
        [MoTaDuLieu("Mã định danh")]
        public long ID { get; set; }
        [MoTaDuLieu("Mã quản lý: mã duy nhất trong 1 đợt khám chữa bệnh (kcb), không trùng giữa các đợt kcb khác nhau", "", 1)]
        public decimal MaQuanLy { get; set; }
        [MoTaDuLieu("Mã bệnh nhân")]
        public string MaBenhNhan { get; set; }
        public string HoTenBenhNhan { get; set; }
        [MoTaDuLieu("Tuổi bệnh nhân")]
        public string Tuoi { get; set; }
        [MoTaDuLieu("Giới tính bệnh nhân")]
        public string GioiTinh { get; set; }
        [MoTaDuLieu("Tái khám lần")]
        public string TaiKhamLan { get; set; }
        public DateTime? NgayKham { get; set; }
        [MoTaDuLieu("1. Toàn thân: Cao")]
        public string Cao { get; set; }
        [MoTaDuLieu("1. Toàn thân: Nặng")]
        public string Nang { get; set; }
        //2. Triệu chứng cơ năng:
        [MoTaDuLieu("Sốt: 1-> không, 2-> có")]
        public int Sot { get; set; }
        [MoTaDuLieu("Đau HSP: 1-> không, 2-> có")]
        public int DauHSP { get; set; }
        [MoTaDuLieu("Mệt mỏi: 1-> không, 2-> có")]
        public int MetMoi { get; set; }
        [MoTaDuLieu("Chán ăn: 1-> không, 2-> có")]
        public int ChanAn { get; set; }
        [MoTaDuLieu("Sụt cân: 1-> không, 2-> có")]
        public int SutCan { get; set; }
        [MoTaDuLieu("Triệu chứng khác")]
        public string TCCN_TrieuChungKhac { get; set; }
        //3. Khám bộ phận
        [MoTaDuLieu("- Nhịp tim")]
        public string NhipTim { get; set; }
        [MoTaDuLieu("- HA")]
        public string HA { get; set; }
        [MoTaDuLieu("- Vàng da: 1-> không, 2-> có")]
        public int VangDa { get; set; }
        [MoTaDuLieu("- Sao mạch: 1-> không, 2-> có")]
        public int SaoMach { get; set; }
        [MoTaDuLieu("- XHDD: 1-> không, 2-> có")]
        public int XHDD { get; set; }
        [MoTaDuLieu("- Cổ chướng: 1-> không, 2-> có")]
        public int CoChuong { get; set; }
        [MoTaDuLieu("- Phù: 1-> không, 2-> có")]
        public int Phu { get; set; }
        [MoTaDuLieu("- Gan to: 1-> không, 2-> có")]
        public int GanTo { get; set; }
        [MoTaDuLieu("- Lách to: 1-> không, 2-> có")]
        public int LachTo { get; set; }
        [MoTaDuLieu("- Triệu chứng khác: 1-> không, 2-> có")]
        public int KBP_TrieuChungKhac { get; set; }
        [MoTaDuLieu("- Các bộ phận khác")]
        public string CacBoPhanKhac { get; set; }
        // E. CẬN LÂM SÀNG:
        // 1. Máu:
        [MoTaDuLieu("HB s Ag:")]
        public string HBsAg { get; set; }
        [MoTaDuLieu("AntiHB s:")]
        public string AntiHBs { get; set; }
        [MoTaDuLieu("HB e Ag:")]
        public string HBeAg { get; set; }
        [MoTaDuLieu("HBV-DNA:")]
        public string HBVDNA { get; set; }
        [MoTaDuLieu("AntiHBeAg:")]
        public string AntiHBeAg { get; set; }
        [MoTaDuLieu("Anti-HVC:")]
        public string AntiHVC { get; set; }
        [MoTaDuLieu("HIV")]
        public string HIV { get; set; }
        [MoTaDuLieu("AST")]
        public string AST { get; set; }
        [MoTaDuLieu("ALT")]
        public string ALT { get; set; }
        [MoTaDuLieu("Bilirubin TP")]
        public string Bilirubin_TP { get; set; }
        [MoTaDuLieu("Bilirubin TT")]
        public string Bilirubin_TT { get; set; }
        [MoTaDuLieu("GT")]
        public string GT { get; set; }
        [MoTaDuLieu("PT")]
        public string PT { get; set; }
        [MoTaDuLieu("Albumin")]
        public string Albumin { get; set; }
        [MoTaDuLieu("αFP")]
        public string AlphaFP { get; set; }
        [MoTaDuLieu("Creatinin")]
        public string Creatinin { get; set; }
        [MoTaDuLieu("Đường máu")]
        public string DuongMau { get; set; }
        [MoTaDuLieu("CTM: HC")]
        public string CTM_HC { get; set; }
        [MoTaDuLieu("CTM: BC")]
        public string CTM_BC { get; set; }
        [MoTaDuLieu("CTM: TC")]
        public string CTM_TC { get; set; }
        [MoTaDuLieu("CTM: HB")]
        public string CTM_HB { get; set; }
        [MoTaDuLieu("2. Siêu âm bụng: Gan")]
        public string SieuAmBung_Gan { get; set; }
        [MoTaDuLieu("TMC")]
        public string TMC { get; set; }
        [MoTaDuLieu("Lách")]
        public string Lach { get; set; }
        [MoTaDuLieu("TML")]
        public string TML { get; set; }
        [MoTaDuLieu("3. Soi dạ dày - thực quản, 1-> không, 2-> có")]
        public int SoiDaDayThucQuan { get; set; }
        [MoTaDuLieu("Giãn TMTQ, 1-> không, 2-> có")]
        public int GianTMTQ { get; set; }
        [MoTaDuLieu("4. Xét nghiệm khác")]
        public string XetNghiemKhac { get; set; }
        //F. CHẨN ĐOÁN
        [MoTaDuLieu("- Mang HbsAg mạn")]
        public int MangHbsAgMan { get; set; }

        [MoTaDuLieu("- VGSVB mạn TT:")]
        public int VGSVBManTT { get; set; }
        [MoTaDuLieu("- VGSVB mạn - xơ gan còn bù:")]
        public int VGSVBManXoGanConBu { get; set; }
        [MoTaDuLieu("- VGSVB mạn - xơ gan mất bù:")]
        public int VGSVBManXoGanMatBu { get; set; }
        [MoTaDuLieu("- VGSVB mạn - K gan, 1-> không, 2-> có")]
        public int VGSVBManKGan { get; set; }
        [MoTaDuLieu("G. Điều trị")]
        public string DieuTri { get; set; }
        [MoTaDuLieu("Ngừng thuốc")]
        public string NgungThuocLyDo { get; set; }
        [MoTaDuLieu("chuyển thuốc")]
        public string ChuyenThuocLyDo { get; set; }
        [MoTaDuLieu("thêm thuốc")]
        public string ThemThuoc { get; set; }
        [MoTaDuLieu("Vào viện")]
        public string VaoVien { get; set; }
        [MoTaDuLieu("Lý do BN bỏ hẹn khám")]
        public string LyDoBNBoHenKham { get; set; }

        [MoTaDuLieu("Hẹn khám lại")]
        public DateTime? HenKhamLai { get; set; }
        [MoTaDuLieu("Hẹn xét nghiệm lại")]
        public DateTime? HenXetNghiemLai { get; set; }
        [MoTaDuLieu("Bác sỹ điều trị")]
        public string BacSyDieuTri { get; set; }

        // bắt buộc
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
    public class TaiKhamViemGanBManTinhFunc
    {
        public const string TableName = "TaiKhamViemGanBManTinh";
        public const string TablePrimaryKeyName = "ID";
        public static List<TaiKhamViemGanBManTinh> GetListData(MDB.MDBConnection _OracleConnection, decimal maquanly)
        {
            List<TaiKhamViemGanBManTinh> list = new List<TaiKhamViemGanBManTinh>();
            try
            {
                string sql = @"SELECT * FROM TaiKhamViemGanBManTinh where MaQuanLy = :MaQuanLy";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, _OracleConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", maquanly));
                MDB.MDBDataReader DataReader = Command.ExecuteReader();
                while (DataReader.Read())
                {
                    TaiKhamViemGanBManTinh data = new TaiKhamViemGanBManTinh();
                    data.ID = Convert.ToInt64(DataReader.GetLong("ID").ToString());
                    data.MaQuanLy = maquanly;
                    data.MaBenhNhan = DataReader["MaBenhNhan"].ToString();
                    data.HoTenBenhNhan = XemBenhAn._HanhChinhBenhNhan.TenBenhNhan;
                    data.Tuoi = XemBenhAn._HanhChinhBenhNhan.Tuoi;
                    data.GioiTinh = XemBenhAn._HanhChinhBenhNhan.GioiTinh.Description();
                    data.TaiKhamLan = DataReader["TaiKhamLan"].ToString();
                    data.NgayKham = DataReader["NgayKham"] != DBNull.Value ? (DateTime?)Convert.ToDateTime(DataReader["NgayKham"].ToString()) : null;

                    data.Cao = DataReader["Cao"].ToString();
                    data.Nang = DataReader["Nang"].ToString();
                    data.Sot = DataReader.GetInt("Sot");
                    data.DauHSP = DataReader.GetInt("DauHSP");
                    data.MetMoi = DataReader.GetInt("MetMoi");
                    data.ChanAn = DataReader.GetInt("ChanAn");
                    data.SutCan = DataReader.GetInt("SutCan");
                    data.TCCN_TrieuChungKhac = DataReader["TCCN_TrieuChungKhac"].ToString();
                    data.NhipTim = DataReader["NhipTim"].ToString();
                    data.HA = DataReader["HA"].ToString();
                    data.VangDa = DataReader.GetInt("VangDa");
                    data.SaoMach = DataReader.GetInt("SaoMach");
                    data.XHDD = DataReader.GetInt("XHDD");
                    data.CoChuong = DataReader.GetInt("CoChuong");
                    data.Phu = DataReader.GetInt("Phu");
                    data.GanTo = DataReader.GetInt("GanTo");
                    data.LachTo = DataReader.GetInt("LachTo");
                    data.KBP_TrieuChungKhac = DataReader.GetInt("KBP_TrieuChungKhac");
                    data.CacBoPhanKhac = DataReader["CacBoPhanKhac"].ToString();
                    data.HBsAg = DataReader["HBsAg"].ToString();
                    data.AntiHBs = DataReader["AntiHBs"].ToString();
                    data.HBeAg = DataReader["HBeAg"].ToString();
                    data.HBVDNA = DataReader["HBVDNA"].ToString();
                    data.AntiHBeAg = DataReader["AntiHBeAg"].ToString();
                    data.AntiHVC = DataReader["AntiHVC"].ToString();
                    data.HIV = DataReader["HIV"].ToString();
                    data.AST = DataReader["AST"].ToString();
                    data.ALT = DataReader["ALT"].ToString();
                    data.Bilirubin_TP = DataReader["Bilirubin_TP"].ToString();
                    data.Bilirubin_TT = DataReader["Bilirubin_TT"].ToString();
                    data.GT = DataReader["GT"].ToString();
                    data.PT = DataReader["PT"].ToString();
                    data.Albumin = DataReader["Albumin"].ToString();
                    data.AlphaFP = DataReader["AlphaFP"].ToString();
                    data.Creatinin = DataReader["Creatinin"].ToString();
                    data.DuongMau = DataReader["DuongMau"].ToString();
                    data.CTM_HC = DataReader["CTM_HC"].ToString();
                    data.CTM_BC = DataReader["CTM_BC"].ToString();
                    data.CTM_TC = DataReader["CTM_TC"].ToString();
                    data.CTM_HB = DataReader["CTM_HB"].ToString();
                    data.SieuAmBung_Gan = DataReader["SieuAmBung_Gan"].ToString();
                    data.TMC = DataReader["TMC"].ToString();
                    data.Lach = DataReader["Lach"].ToString();
                    data.TML = DataReader["TML"].ToString();
                    data.SoiDaDayThucQuan = DataReader.GetInt("SoiDaDayThucQuan");
                    data.GianTMTQ = DataReader.GetInt("GianTMTQ");
                    data.XetNghiemKhac = DataReader["XetNghiemKhac"].ToString();
                    data.MangHbsAgMan = DataReader.GetInt("MangHbsAgMan");
                    data.VGSVBManTT = DataReader.GetInt("VGSVBManTT");
                    data.VGSVBManXoGanConBu = DataReader.GetInt("VGSVBManXoGanConBu");
                    data.VGSVBManXoGanMatBu = DataReader.GetInt("VGSVBManXoGanMatBu");
                    data.VGSVBManKGan = DataReader.GetInt("VGSVBManKGan");
                    data.DieuTri = DataReader["DieuTri"].ToString();
                    data.HenKhamLai = DataReader["HenKhamLai"] != DBNull.Value ? (DateTime?)Convert.ToDateTime(DataReader["HenKhamLai"]) : null;
                    data.HenXetNghiemLai = DataReader["HenXetNghiemLai"] != DBNull.Value ? (DateTime?)Convert.ToDateTime(DataReader["HenXetNghiemLai"]) : null;
                    data.BacSyDieuTri = DataReader["BacSyDieuTri"].ToString();

                    data.NgungThuocLyDo = DataReader["NgungThuocLyDo"].ToString();
                    data.ChuyenThuocLyDo = DataReader["ChuyenThuocLyDo"].ToString();
                    data.ThemThuoc = DataReader["ThemThuoc"].ToString();
                    data.VaoVien = DataReader["VaoVien"].ToString();
                    data.LyDoBNBoHenKham = DataReader["LyDoBNBoHenKham"].ToString();

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
        public static bool InsertOrUpdate(MDB.MDBConnection MyConnection, ref TaiKhamViemGanBManTinh ketQua)
        {
            try
            {
                string sql = @"INSERT INTO TaiKhamViemGanBManTinh
                (
                    MAQUANLY,
                    MaBenhNhan,
                    TaiKhamLan,
                    NgayKham,
                    Cao,
                    Nang,
                    Sot,
                    DauHSP,
                    MetMoi,
                    ChanAn,
                    SutCan,
                    TCCN_TrieuChungKhac,
                    NhipTim,
                    HA,
                    VangDa,
                    SaoMach,
                    XHDD,
                    CoChuong,
                    Phu,
                    GanTo,
                    LachTo,
                    KBP_TrieuChungKhac,
                    CacBoPhanKhac,
                    HBsAg,
                    AntiHBs,
                    HBeAg,
                    HBVDNA,
                    AntiHBeAg,
                    AntiHVC,
                    HIV,
                    AST,
                    ALT,
                    Bilirubin_TP,
                    Bilirubin_TT,
                    GT,
                    PT,
                    Albumin,
                    AlphaFP,
                    Creatinin,
                    DuongMau,
                    CTM_HC,
                    CTM_BC,
                    CTM_TC,
                    CTM_HB,
                    SieuAmBung_Gan,
                    TMC,
                    Lach,
                    TML,
                    SoiDaDayThucQuan,
                    GianTMTQ,
                    XetNghiemKhac,
                    MangHbsAgMan,
                    VGSVBManTT,
                    VGSVBManXoGanConBu,
                    VGSVBManXoGanMatBu,
                    VGSVBManKGan,
                    DieuTri,
                    HenKhamLai,
                    HenXetNghiemLai,
                    BacSyDieuTri,
                    NgungThuocLyDo,
                    ChuyenThuocLyDo,
                    ThemThuoc,
                    VaoVien,
                    LyDoBNBoHenKham,
                    NGUOITAO,
                    NGUOISUA,
                    NGAYTAO,
                    NGAYSUA)  VALUES
                 (
				    :MAQUANLY,
                    :MaBenhNhan,
                    :TaiKhamLan,
                    :NgayKham,
                    :Cao,
                    :Nang,
                    :Sot,
                    :DauHSP,
                    :MetMoi,
                    :ChanAn,
                    :SutCan,
                    :TCCN_TrieuChungKhac,
                    :NhipTim,
                    :HA,
                    :VangDa,
                    :SaoMach,
                    :XHDD,
                    :CoChuong,
                    :Phu,
                    :GanTo,
                    :LachTo,
                    :KBP_TrieuChungKhac,
                    :CacBoPhanKhac,
                    :HBsAg,
                    :AntiHBs,
                    :HBeAg,
                    :HBVDNA,
                    :AntiHBeAg,
                    :AntiHVC,
                    :HIV,
                    :AST,
                    :ALT,
                    :Bilirubin_TP,
                    :Bilirubin_TT,
                    :GT,
                    :PT,
                    :Albumin,
                    :AlphaFP,
                    :Creatinin,
                    :DuongMau,
                    :CTM_HC,
                    :CTM_BC,
                    :CTM_TC,
                    :CTM_HB,
                    :SieuAmBung_Gan,
                    :TMC,
                    :Lach,
                    :TML,
                    :SoiDaDayThucQuan,
                    :GianTMTQ,
                    :XetNghiemKhac,
                    :MangHbsAgMan,
                    :VGSVBManTT,
                    :VGSVBManXoGanConBu,
                    :VGSVBManXoGanMatBu,
                    :VGSVBManKGan,
                    :DieuTri,
                    :HenKhamLai,
                    :HenXetNghiemLai,
                    :BacSyDieuTri,
                    :NgungThuocLyDo,
                    :ChuyenThuocLyDo,
                    :ThemThuoc,
                    :VaoVien,
                    :LyDoBNBoHenKham,
                    :NGUOITAO,
                    :NGUOISUA,
                    :NGAYTAO,
                    :NGAYSUA
                 )  RETURNING ID INTO :ID";
                if (ketQua.ID != 0)
                {
                    sql = @"UPDATE TaiKhamViemGanBManTinh SET 
                    MAQUANLY = :MAQUANLY,
                    MaBenhNhan = :MaBenhNhan,
                    TaiKhamLan = :TaiKhamLan,
                    NgayKham = :NgayKham,
                    Cao=:Cao,
                    Nang=:Nang,
                    Sot=:Sot,
                    DauHSP=:DauHSP,
                    MetMoi=:MetMoi,
                    ChanAn=:ChanAn,
                    SutCan=:SutCan,
                    TCCN_TrieuChungKhac=:TCCN_TrieuChungKhac,
                    NhipTim=:NhipTim,
                    HA=:HA,
                    VangDa=:VangDa,
                    SaoMach=:SaoMach,
                    XHDD=:XHDD,
                    CoChuong=:CoChuong,
                    Phu=:Phu,
                    GanTo=:GanTo,
                    LachTo=:LachTo,
                    KBP_TrieuChungKhac=:KBP_TrieuChungKhac,
                    CacBoPhanKhac=:CacBoPhanKhac,
                    HBsAg=:HBsAg,
                    AntiHBs=:AntiHBs,
                    HBeAg=:HBeAg,
                    HBVDNA=:HBVDNA,
                    AntiHBeAg=:AntiHBeAg,
                    AntiHVC=:AntiHVC,
                    HIV=:HIV,
                    AST=:AST,
                    ALT=:ALT,
                    Bilirubin_TP=:Bilirubin_TP,
                    Bilirubin_TT=:Bilirubin_TT,
                    GT=:GT,
                    PT=:PT,
                    Albumin=:Albumin,
                    AlphaFP=:AlphaFP,
                    Creatinin=:Creatinin,
                    DuongMau=:DuongMau,
                    CTM_HC=:CTM_HC,
                    CTM_BC=:CTM_BC,
                    CTM_TC=:CTM_TC,
                    CTM_HB=:CTM_HB,
                    SieuAmBung_Gan=:SieuAmBung_Gan,
                    TMC=:TMC,
                    Lach=:Lach,
                    TML=:TML,
                    SoiDaDayThucQuan=:SoiDaDayThucQuan,
                    GianTMTQ=:GianTMTQ,
                    XetNghiemKhac=:XetNghiemKhac,
                    MangHbsAgMan=:MangHbsAgMan,
                    VGSVBManTT=:VGSVBManTT,
                    VGSVBManXoGanConBu=:VGSVBManXoGanConBu,
                    VGSVBManXoGanMatBu=:VGSVBManXoGanMatBu,
                    VGSVBManKGan=:VGSVBManKGan,
                    DieuTri=:DieuTri,
                    HenKhamLai=:HenKhamLai,
                    HenXetNghiemLai=:HenXetNghiemLai,
                    BacSyDieuTri=:BacSyDieuTri,
                    NgungThuocLyDo = :NgungThuocLyDo,
                    ChuyenThuocLyDo = :ChuyenThuocLyDo,
                    ThemThuoc = :ThemThuoc,
                    VaoVien = :VaoVien,
                    LyDoBNBoHenKham = :LyDoBNBoHenKham,
                    NGUOISUA = :NGUOISUA,
                    NGAYSUA = :NGAYSUA
                    WHERE ID = " + ketQua.ID;
                }
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MAQUANLY", ketQua.MaQuanLy));
                Command.Parameters.Add(new MDB.MDBParameter("MaBenhNhan", ketQua.MaBenhNhan));
                Command.Parameters.Add(new MDB.MDBParameter("TaiKhamLan", ketQua.TaiKhamLan));
                Command.Parameters.Add(new MDB.MDBParameter("NgayKham", ketQua.NgayKham));

                Command.Parameters.Add(new MDB.MDBParameter("Cao", ketQua.Cao));
                Command.Parameters.Add(new MDB.MDBParameter("Nang", ketQua.Nang));
                Command.Parameters.Add(new MDB.MDBParameter("Sot", ketQua.Sot));
                Command.Parameters.Add(new MDB.MDBParameter("DauHSP", ketQua.DauHSP));
                Command.Parameters.Add(new MDB.MDBParameter("MetMoi", ketQua.MetMoi));
                Command.Parameters.Add(new MDB.MDBParameter("ChanAn", ketQua.ChanAn));
                Command.Parameters.Add(new MDB.MDBParameter("SutCan", ketQua.SutCan));
                Command.Parameters.Add(new MDB.MDBParameter("TCCN_TrieuChungKhac", ketQua.TCCN_TrieuChungKhac));
                Command.Parameters.Add(new MDB.MDBParameter("NhipTim", ketQua.NhipTim));
                Command.Parameters.Add(new MDB.MDBParameter("HA", ketQua.HA));
                Command.Parameters.Add(new MDB.MDBParameter("VangDa", ketQua.VangDa));
                Command.Parameters.Add(new MDB.MDBParameter("SaoMach", ketQua.SaoMach));
                Command.Parameters.Add(new MDB.MDBParameter("XHDD", ketQua.XHDD));
                Command.Parameters.Add(new MDB.MDBParameter("CoChuong", ketQua.CoChuong));
                Command.Parameters.Add(new MDB.MDBParameter("Phu", ketQua.Phu));
                Command.Parameters.Add(new MDB.MDBParameter("GanTo", ketQua.GanTo));
                Command.Parameters.Add(new MDB.MDBParameter("LachTo", ketQua.LachTo));
                Command.Parameters.Add(new MDB.MDBParameter("KBP_TrieuChungKhac", ketQua.KBP_TrieuChungKhac));
                Command.Parameters.Add(new MDB.MDBParameter("CacBoPhanKhac", ketQua.CacBoPhanKhac));
                Command.Parameters.Add(new MDB.MDBParameter("HBsAg", ketQua.HBsAg));
                Command.Parameters.Add(new MDB.MDBParameter("AntiHBs", ketQua.AntiHBs));
                Command.Parameters.Add(new MDB.MDBParameter("HBeAg", ketQua.HBeAg));
                Command.Parameters.Add(new MDB.MDBParameter("HBVDNA", ketQua.HBVDNA));
                Command.Parameters.Add(new MDB.MDBParameter("AntiHBeAg", ketQua.AntiHBeAg));
                Command.Parameters.Add(new MDB.MDBParameter("AntiHVC", ketQua.AntiHVC));
                Command.Parameters.Add(new MDB.MDBParameter("HIV", ketQua.HIV));
                Command.Parameters.Add(new MDB.MDBParameter("AST", ketQua.AST));
                Command.Parameters.Add(new MDB.MDBParameter("ALT", ketQua.ALT));
                Command.Parameters.Add(new MDB.MDBParameter("Bilirubin_TP", ketQua.Bilirubin_TP));
                Command.Parameters.Add(new MDB.MDBParameter("Bilirubin_TT", ketQua.Bilirubin_TT));
                Command.Parameters.Add(new MDB.MDBParameter("GT", ketQua.GT));
                Command.Parameters.Add(new MDB.MDBParameter("PT", ketQua.PT));
                Command.Parameters.Add(new MDB.MDBParameter("Albumin", ketQua.Albumin));
                Command.Parameters.Add(new MDB.MDBParameter("AlphaFP", ketQua.AlphaFP));
                Command.Parameters.Add(new MDB.MDBParameter("Creatinin", ketQua.Creatinin));
                Command.Parameters.Add(new MDB.MDBParameter("DuongMau", ketQua.DuongMau));
                Command.Parameters.Add(new MDB.MDBParameter("CTM_HC", ketQua.CTM_HC));
                Command.Parameters.Add(new MDB.MDBParameter("CTM_BC", ketQua.CTM_BC));
                Command.Parameters.Add(new MDB.MDBParameter("CTM_TC", ketQua.CTM_TC));
                Command.Parameters.Add(new MDB.MDBParameter("CTM_HB", ketQua.CTM_HB));
                Command.Parameters.Add(new MDB.MDBParameter("SieuAmBung_Gan", ketQua.SieuAmBung_Gan));
                Command.Parameters.Add(new MDB.MDBParameter("TMC", ketQua.TMC));
                Command.Parameters.Add(new MDB.MDBParameter("Lach", ketQua.Lach));
                Command.Parameters.Add(new MDB.MDBParameter("TML", ketQua.TML));
                Command.Parameters.Add(new MDB.MDBParameter("SoiDaDayThucQuan", ketQua.SoiDaDayThucQuan));
                Command.Parameters.Add(new MDB.MDBParameter("GianTMTQ", ketQua.GianTMTQ));
                Command.Parameters.Add(new MDB.MDBParameter("XetNghiemKhac", ketQua.XetNghiemKhac));
                Command.Parameters.Add(new MDB.MDBParameter("MangHbsAgMan", ketQua.MangHbsAgMan));
                Command.Parameters.Add(new MDB.MDBParameter("VGSVBManTT", ketQua.VGSVBManTT));
                Command.Parameters.Add(new MDB.MDBParameter("VGSVBManXoGanConBu", ketQua.VGSVBManXoGanConBu));
                Command.Parameters.Add(new MDB.MDBParameter("VGSVBManXoGanMatBu", ketQua.VGSVBManXoGanMatBu));
                Command.Parameters.Add(new MDB.MDBParameter("VGSVBManKGan", ketQua.VGSVBManKGan));
                Command.Parameters.Add(new MDB.MDBParameter("DieuTri", ketQua.DieuTri));
                Command.Parameters.Add(new MDB.MDBParameter("HenKhamLai", ketQua.HenKhamLai));
                Command.Parameters.Add(new MDB.MDBParameter("HenXetNghiemLai", ketQua.HenXetNghiemLai));
                Command.Parameters.Add(new MDB.MDBParameter("BacSyDieuTri", ketQua.BacSyDieuTri));


                Command.Parameters.Add(new MDB.MDBParameter("NgungThuocLyDo", ketQua.NgungThuocLyDo));
                Command.Parameters.Add(new MDB.MDBParameter("ChuyenThuocLyDo", ketQua.ChuyenThuocLyDo));
                Command.Parameters.Add(new MDB.MDBParameter("ThemThuoc", ketQua.ThemThuoc));
                Command.Parameters.Add(new MDB.MDBParameter("VaoVien", ketQua.VaoVien));
                Command.Parameters.Add(new MDB.MDBParameter("LyDoBNBoHenKham", ketQua.LyDoBNBoHenKham));

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
                string sql = "DELETE FROM TaiKhamViemGanBManTinh WHERE ID = :ID";
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
                TaiKhamViemGanBManTinh P
            WHERE
                ID = " + id;

            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
            MDB.MDBDataAdapter adt = new MDB.MDBDataAdapter(Command);
            var ds = new DataSet();

            adt.Fill(ds);

            ds.Tables[0].AddColumn("TenBenhNhan", typeof(string));
            ds.Tables[0].AddColumn("Tuoi", typeof(string));
            ds.Tables[0].AddColumn("NamSinh", typeof(string));
            ds.Tables[0].AddColumn("GioiTinh", typeof(int));
            ds.Tables[0].AddColumn("SOYTE", typeof(string));
            ds.Tables[0].AddColumn("BENHVIEN", typeof(string));
            ds.Tables[0].AddColumn("KHOA", typeof(string));

            ds.Tables[0].Rows[0]["TenBenhNhan"] = XemBenhAn._HanhChinhBenhNhan.TenBenhNhan;
            ds.Tables[0].Rows[0]["Tuoi"] = XemBenhAn._HanhChinhBenhNhan.Tuoi;
            ds.Tables[0].Rows[0]["NamSinh"] = XemBenhAn._HanhChinhBenhNhan.NgaySinh.HasValue ? XemBenhAn._HanhChinhBenhNhan.NgaySinh.Value.Year + "" : "";
            ds.Tables[0].Rows[0]["GioiTinh"] = (int)XemBenhAn._HanhChinhBenhNhan.GioiTinh;
            ds.Tables[0].Rows[0]["SOYTE"] = XemBenhAn._HanhChinhBenhNhan.SoYTe;
            ds.Tables[0].Rows[0]["BENHVIEN"] = XemBenhAn._HanhChinhBenhNhan.BenhVien;
            ds.Tables[0].Rows[0]["KHOA"] = XemBenhAn._ThongTinDieuTri.Khoa;

            return ds;
        }
    }
}
