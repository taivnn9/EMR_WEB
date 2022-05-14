using EMR.KyDienTu;
using PMS.Access;
using System;
using System.Collections.Generic;
using System.Data;

namespace EMR_MAIN.DATABASE.Other
{
    public class TaiKhamBABenhBaseDow : ThongTinKy
    {
        public TaiKhamBABenhBaseDow()
        {
            TableName = "TaiKhamBABenhBaseDow";
            TablePrimaryKeyName = "ID";
            IDMauPhieu = (int)DanhMucPhieu.TKBASDMV;
            TenMauPhieu = DanhMucPhieu.TKBASDMV.Description();
        }
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
        [MoTaDuLieu("TÁI KHÁM LẦN")]
        public string TaiKhamLan { get; set; }
        [MoTaDuLieu("Ngày khám")]
        public DateTime? NgayKham { get; set; }
        [MoTaDuLieu("Cân nặng")]
        public string CanNang { get; set; }
        // DHST
        [MoTaDuLieu("Mạch")]
        public string Mach { get; set; }
        [MoTaDuLieu("Nhiệt độ")]
        public string NhietDo { get; set; }
        [MoTaDuLieu("HA")]
        public string HuyetAp { get; set; }
        [MoTaDuLieu("Nhịp thở")]
        public string NhipTho { get; set; }

        [MoTaDuLieu("Tỉnh, 1-> có, 2-> không")]
        public int ToanThan_Tinh { get; set; }
        [MoTaDuLieu("Da nóng ẩm, 1-> có, 2-> không")]
        public int ToanThan_DaNongAm { get; set; }
        [MoTaDuLieu("Da, niêm mạc mắt vàng , 1-> có, 2-> không")]
        public int ToanThan_DaNiemMacMatVang { get; set; }
        [MoTaDuLieu("Run tay , 1-> có, 2-> không")]
        public int ToanThan_RunTay { get; set; }
        [MoTaDuLieu("Khác , 1-> có, 2-> không")]
        public int ToanThan_Khac { get; set; }
        //2. Bộ phận
        [MoTaDuLieu("Tuần hoàn: nhịp tim")]
        public string NhipTim { get; set; }
        [MoTaDuLieu("Nhịp tim, 1-> đều, 2 -> không đều")]
        public int NhipTim_Deu { get; set; }
        [MoTaDuLieu("Tiếng tim")]
        public string TiengTim { get; set; }
        [MoTaDuLieu("HA")]
        public string HA { get; set; }
        [MoTaDuLieu("Tuyến giáp: to độ, Ia-> 1, Ib -> 2, II ->3, III->4")]
        public int TuyenGiap { get; set; }
        [MoTaDuLieu("Mật độ: Mềm")]
        public int MatDo_Mem { get; set; }
        [MoTaDuLieu("Mật độ: Chắc")]
        public int MatDo_Chac { get; set; }
        [MoTaDuLieu("Bướu lan tỏa")]
        public int BuouLanToa { get; set; }
        [MoTaDuLieu("Nhân thùy phải")]
        public int NhanThuyPhai { get; set; }
        [MoTaDuLieu("Nhân thùy trái")]
        public int NhanThuyTrai { get; set; }
        [MoTaDuLieu("Nhân 2 thùy")]
        public int Nhan2Thuy { get; set; }
        [MoTaDuLieu("Tiếng thổi tâm thu: Thùy phải")]
        public int TTTT_ThuyPhai { get; set; }
        [MoTaDuLieu("Tiếng thổi tâm thu: Thùy trái")]
        public int TTTT_ThuyTrai { get; set; }
        [MoTaDuLieu("Tiếng thổi tâm thu: không có")]
        public int TTTT_KhongCo { get; set; }
        [MoTaDuLieu("Tiếng thổi liên tục: Thùy phải")]
        public int TTLT_ThuyPhai { get; set; }
        [MoTaDuLieu("Tiếng thổi liên tục: Thùy trái")]
        public int TTLT_ThuyTrai { get; set; }
        [MoTaDuLieu("Tiếng thổi liên tục: không có")]
        public int TTLT_KhongCo { get; set; }
        [MoTaDuLieu("Mắt phải NO SPECS độ")]
        public string MatPhaiNOSPECSDo { get; set; }
        [MoTaDuLieu("Mắt trái NO SPECS độ")]
        public string MatTraiNOSPECSDo { get; set; }
        [MoTaDuLieu("Hô hấp")]
        public string HoHap { get; set; }
        [MoTaDuLieu("Thần kinh")]
        public string ThanKinh { get; set; }
        [MoTaDuLieu("Bụng")]
        public string Bung { get; set; }
        [MoTaDuLieu("Bộ phận khác")]
        public string BoPhanKhac { get; set; }
        //V. CẬN LÂM SÀNG
        //1. Sinh hóa máu
        [MoTaDuLieu("Ure")]
        public string Ure { get; set; }
        [MoTaDuLieu("Glucose")]
        public string Glucose { get; set; }
        [MoTaDuLieu("Creatinin")]
        public string Creatinin { get; set; }
        [MoTaDuLieu("Cholesterol TP")]
        public string Cholesterol_TP { get; set; }
        [MoTaDuLieu("TG")]
        public string TG { get; set; }
        [MoTaDuLieu("HDL-C")]
        public string HDL_C { get; set; }
        [MoTaDuLieu("LDL-C")]
        public string LDL_C { get; set; }
        [MoTaDuLieu("Acid")]
        public string Acid { get; set; }
        [MoTaDuLieu("SGOT")]
        public string SGOT { get; set; }
        [MoTaDuLieu("SGPT")]
        public string SGPT { get; set; }
        [MoTaDuLieu("Protein")]
        public string Protein { get; set; }
        [MoTaDuLieu("Albumin")]
        public string Albumin { get; set; }
        [MoTaDuLieu("Na")]
        public string Na { get; set; }
        [MoTaDuLieu("K")]
        public string K { get; set; }
        [MoTaDuLieu("Cl")]
        public string Cl { get; set; }

        [MoTaDuLieu("Ca")]
        public string Ca { get; set; }
        //2. Công thức máu
        [MoTaDuLieu("HC")]
        public string HC { get; set; }
        [MoTaDuLieu("Hb")]
        public string Hb { get; set; }
        [MoTaDuLieu("HCT")]
        public string HCT { get; set; }
        [MoTaDuLieu("BC")]
        public string BC { get; set; }
        [MoTaDuLieu("TT")]
        public string TT { get; set; }
        [MoTaDuLieu("lympho")]
        public string lympho { get; set; }
        [MoTaDuLieu("TC")]
        public string TC { get; set; }
        //3. Miễn dịch
        [MoTaDuLieu("T3")]
        public string T3 { get; set; }
        [MoTaDuLieu("FT3")]
        public string FT3 { get; set; }
        [MoTaDuLieu("FT4")]
        public string FT4 { get; set; }
        [MoTaDuLieu("TSH")]
        public string TSH { get; set; }
        [MoTaDuLieu("Anti TPO")]
        public string Anti_TPO { get; set; }
        [MoTaDuLieu("TRAb")]
        public string TRAb { get; set; }
        [MoTaDuLieu(" Siêu âm tuyến giáp")]
        public string SieuAmTuyenGiap { get; set; }
        [MoTaDuLieu(" Độ tập trung I131")]
        public string DoTapTrungI131 { get; set; }
        [MoTaDuLieu(" Xạ hình tuyến giáp")]
        public string XaHinhTuyenGiap { get; set; }
        [MoTaDuLieu(" Điện tim")]
        public string DienTim { get; set; }
        [MoTaDuLieu(" Siêu âm Dopple tim, mạch máu")]
        public string SieuAmDopple { get; set; }
        [MoTaDuLieu(" 9. XQ tim phổi")]
        public string XQTimPhoi { get; set; }
        [MoTaDuLieu(" Chẩn đoán bệnh")]
        public string ChanDoan_Benh { get; set; }
        [MoTaDuLieu(" Chẩn đoán biến chứng")]
        public string ChanDoan_BienChung { get; set; }
        [MoTaDuLieu(" Chẩn đoán bệnh phối hợp")]
        public string ChanDoan_BenhPhoiHop { get; set; }
        [MoTaDuLieu(" VII. Điều trị")]
        public string DieuTri { get; set; }
        [MoTaDuLieu(" Lý do thêm, thay đổi thuốc")]
        public string LyDoThemThayThuoc { get; set; }
        [MoTaDuLieu(" Hẹn khám lại ngày")]
        public DateTime? HenKhamLaiNgay { get; set; }
        [MoTaDuLieu(" Hẹn XN lại ngày")]
        public DateTime? HenXNLaiNgay { get; set; }
        [MoTaDuLieu(" Bác sỹ điều trị")]
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
    public class TaiKhamBABenhBaseDowFunc
    {
        public const string TableName = "TaiKhamBABenhBaseDow";
        public const string TablePrimaryKeyName = "ID";
        public static List<TaiKhamBABenhBaseDow> GetListData(MDB.MDBConnection _OracleConnection, decimal maquanly)
        {
            List<TaiKhamBABenhBaseDow> list = new List<TaiKhamBABenhBaseDow>();
            try
            {
                string sql = @"SELECT * FROM TaiKhamBABenhBaseDow where MaQuanLy = :MaQuanLy";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, _OracleConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", maquanly));
                MDB.MDBDataReader DataReader = Command.ExecuteReader();
                while (DataReader.Read())
                {
                    TaiKhamBABenhBaseDow data = new TaiKhamBABenhBaseDow();
                    data.ID = Convert.ToInt64(DataReader.GetLong("ID").ToString());
                    data.MaQuanLy = maquanly;
                    data.MaBenhNhan = DataReader["MaBenhNhan"].ToString();
                    data.HoTenBenhNhan = XemBenhAn._HanhChinhBenhNhan.TenBenhNhan;
                    data.Tuoi = XemBenhAn._HanhChinhBenhNhan.Tuoi;
                    data.GioiTinh = XemBenhAn._HanhChinhBenhNhan.GioiTinh.Description();
                    data.TaiKhamLan = DataReader["TaiKhamLan"].ToString();
                    data.NgayKham = DataReader["NgayKham"] != DBNull.Value ? (DateTime?) Convert.ToDateTime(DataReader["NgayKham"].ToString()) : null;
                    data.CanNang = DataReader["CanNang"].ToString();
                    data.Mach = DataReader["Mach"].ToString();
                    data.NhietDo = DataReader["NhietDo"].ToString();
                    data.HuyetAp = DataReader["HuyetAp"].ToString();
                    data.NhipTho = DataReader["NhipTho"].ToString();
                    data.ToanThan_Tinh = DataReader.GetInt("ToanThan_Tinh");
                    data.ToanThan_DaNongAm = DataReader.GetInt("ToanThan_DaNongAm");
                    data.ToanThan_DaNiemMacMatVang = DataReader.GetInt("ToanThan_DaNiemMacMatVang");
                    data.ToanThan_RunTay = DataReader.GetInt("ToanThan_RunTay");
                    data.ToanThan_Khac = DataReader.GetInt("ToanThan_Khac");
                    data.NhipTim = DataReader["NhipTim"].ToString();
                    data.NhipTim_Deu = DataReader.GetInt("NhipTim_Deu");
                    data.TiengTim = DataReader["TiengTim"].ToString();
                    data.HA = DataReader["HA"].ToString();
                    data.TuyenGiap = DataReader.GetInt("TuyenGiap");
                    data.MatDo_Mem = DataReader.GetInt("MatDo_Mem");
                    data.MatDo_Chac = DataReader.GetInt("MatDo_Chac");
                    data.BuouLanToa = DataReader.GetInt("BuouLanToa");
                    data.NhanThuyPhai = DataReader.GetInt("NhanThuyPhai");
                    data.NhanThuyTrai = DataReader.GetInt("NhanThuyTrai");
                    data.Nhan2Thuy = DataReader.GetInt("Nhan2Thuy");
                    data.TTTT_ThuyPhai = DataReader.GetInt("TTTT_ThuyPhai");
                    data.TTTT_ThuyTrai = DataReader.GetInt("TTTT_ThuyTrai");
                    data.TTTT_KhongCo = DataReader.GetInt("TTTT_KhongCo");
                    data.TTLT_ThuyPhai = DataReader.GetInt("TTLT_ThuyPhai");
                    data.TTLT_ThuyTrai = DataReader.GetInt("TTLT_ThuyTrai");
                    data.TTLT_KhongCo = DataReader.GetInt("TTLT_KhongCo");
                    data.MatPhaiNOSPECSDo = DataReader["MatPhaiNOSPECSDo"].ToString();
                    data.MatTraiNOSPECSDo = DataReader["MatTraiNOSPECSDo"].ToString();
                    data.HoHap = DataReader["HoHap"].ToString();
                    data.ThanKinh = DataReader["ThanKinh"].ToString();
                    data.Bung = DataReader["Bung"].ToString();
                    data.BoPhanKhac = DataReader["BoPhanKhac"].ToString();
                    data.Ure = DataReader["Ure"].ToString();
                    data.Glucose = DataReader["Glucose"].ToString();
                    data.Creatinin = DataReader["Creatinin"].ToString();
                    data.Cholesterol_TP = DataReader["Cholesterol_TP"].ToString();
                    data.TG = DataReader["TG"].ToString();
                    data.HDL_C = DataReader["HDL_C"].ToString();
                    data.LDL_C = DataReader["LDL_C"].ToString();
                    data.Acid = DataReader["Acid"].ToString();
                    data.SGOT = DataReader["SGOT"].ToString();
                    data.SGPT = DataReader["SGPT"].ToString();
                    data.Protein = DataReader["Protein"].ToString();
                    data.Albumin = DataReader["Albumin"].ToString();
                    data.Na = DataReader["Na"].ToString();
                    data.K = DataReader["K"].ToString();
                    data.Cl = DataReader["Cl"].ToString();
                    data.Ca = DataReader["Ca"].ToString();
                    data.HC = DataReader["HC"].ToString();
                    data.Hb = DataReader["Hb"].ToString();
                    data.HCT = DataReader["HCT"].ToString();
                    data.BC = DataReader["BC"].ToString();
                    data.TT = DataReader["TT"].ToString();
                    data.lympho = DataReader["lympho"].ToString();
                    data.TC = DataReader["TC"].ToString();
                    data.T3 = DataReader["T3"].ToString();
                    data.FT3 = DataReader["FT3"].ToString();
                    data.FT4 = DataReader["FT4"].ToString();
                    data.TSH = DataReader["TSH"].ToString();
                    data.Anti_TPO = DataReader["Anti_TPO"].ToString();
                    data.TRAb = DataReader["TRAb"].ToString();
                    data.SieuAmTuyenGiap = DataReader["SieuAmTuyenGiap"].ToString();
                    data.DoTapTrungI131 = DataReader["DoTapTrungI131"].ToString();
                    data.XaHinhTuyenGiap = DataReader["XaHinhTuyenGiap"].ToString();
                    data.DienTim = DataReader["DienTim"].ToString();
                    data.SieuAmDopple = DataReader["SieuAmDopple"].ToString();
                    data.XQTimPhoi = DataReader["XQTimPhoi"].ToString();
                    data.ChanDoan_Benh = DataReader["ChanDoan_Benh"].ToString();
                    data.ChanDoan_BienChung = DataReader["ChanDoan_BienChung"].ToString();
                    data.ChanDoan_BenhPhoiHop = DataReader["ChanDoan_BenhPhoiHop"].ToString();
                    data.DieuTri = DataReader["DieuTri"].ToString();
                    data.LyDoThemThayThuoc = DataReader["LyDoThemThayThuoc"].ToString();
                    data.HenKhamLaiNgay = DataReader["HenKhamLaiNgay"] != DBNull.Value ? (DateTime?)Convert.ToDateTime(DataReader["HenKhamLaiNgay"]) : null;
                    data.HenXNLaiNgay = DataReader["HenXNLaiNgay"] != DBNull.Value ? (DateTime?)Convert.ToDateTime(DataReader["HenXNLaiNgay"]) : null;
                    data.BacSyDieuTri = DataReader["BacSyDieuTri"].ToString();
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
        public static bool InsertOrUpdate(MDB.MDBConnection MyConnection, ref TaiKhamBABenhBaseDow ketQua)
        {
            try
            {
                string sql = @"INSERT INTO TaiKhamBABenhBaseDow
                (
                    MAQUANLY,
                    MaBenhNhan,
                    TaiKhamLan,
                    NgayKham,
                    CanNang,
                    Mach,
                    NhietDo,
                    HuyetAp,
                    NhipTho,
                    ToanThan_Tinh,
                    ToanThan_DaNongAm,
                    ToanThan_DaNiemMacMatVang,
                    ToanThan_RunTay,
                    ToanThan_Khac,
                    NhipTim,
                    NhipTim_Deu,
                    TiengTim,
                    HA,
                    TuyenGiap,
                    MatDo_Mem,
                    MatDo_Chac,
                    BuouLanToa,
                    NhanThuyPhai,
                    NhanThuyTrai,
                    Nhan2Thuy,
                    TTTT_ThuyPhai,
                    TTTT_ThuyTrai,
                    TTTT_KhongCo,
                    TTLT_ThuyPhai,
                    TTLT_ThuyTrai,
                    TTLT_KhongCo,
                    MatPhaiNOSPECSDo,
                    MatTraiNOSPECSDo,
                    HoHap,
                    ThanKinh,
                    Bung,
                    BoPhanKhac,
                    Ure,
                    Glucose,
                    Creatinin,
                    Cholesterol_TP,
                    TG,
                    HDL_C,
                    LDL_C,
                    Acid,
                    SGOT,
                    SGPT,
                    Protein,
                    Albumin,
                    Na,
                    K,
                    Cl,
                    Ca,
                    HC,
                    Hb,
                    HCT,
                    BC,
                    TT,
                    lympho,
                    TC,
                    T3,
                    FT3,
                    FT4,
                    TSH,
                    Anti_TPO,
                    TRAb,
                    SieuAmTuyenGiap,
                    DoTapTrungI131,
                    XaHinhTuyenGiap,
                    DienTim,
                    SieuAmDopple,
                    XQTimPhoi,
                    ChanDoan_Benh,
                    ChanDoan_BienChung,
                    ChanDoan_BenhPhoiHop,
                    DieuTri,
                    LyDoThemThayThuoc,
                    HenKhamLaiNgay,
                    HenXNLaiNgay,
                    BacSyDieuTri,
                    NGUOITAO,
                    NGUOISUA,
                    NGAYTAO,
                    NGAYSUA)  VALUES
                 (
				    :MAQUANLY,
                    :MaBenhNhan,
                    :TaiKhamLan,
                    :NgayKham,
                    :CanNang,
                    :Mach,
                    :NhietDo,
                    :HuyetAp,
                    :NhipTho,
                    :ToanThan_Tinh,
                    :ToanThan_DaNongAm,
                    :ToanThan_DaNiemMacMatVang,
                    :ToanThan_RunTay,
                    :ToanThan_Khac,
                    :NhipTim,
                    :NhipTim_Deu,
                    :TiengTim,
                    :HA,
                    :TuyenGiap,
                    :MatDo_Mem,
                    :MatDo_Chac,
                    :BuouLanToa,
                    :NhanThuyPhai,
                    :NhanThuyTrai,
                    :Nhan2Thuy,
                    :TTTT_ThuyPhai,
                    :TTTT_ThuyTrai,
                    :TTTT_KhongCo,
                    :TTLT_ThuyPhai,
                    :TTLT_ThuyTrai,
                    :TTLT_KhongCo,
                    :MatPhaiNOSPECSDo,
                    :MatTraiNOSPECSDo,
                    :HoHap,
                    :ThanKinh,
                    :Bung,
                    :BoPhanKhac,
                    :Ure,
                    :Glucose,
                    :Creatinin,
                    :Cholesterol_TP,
                    :TG,
                    :HDL_C,
                    :LDL_C,
                    :Acid,
                    :SGOT,
                    :SGPT,
                    :Protein,
                    :Albumin,
                    :Na,
                    :K,
                    :Cl,
                    :Ca,
                    :HC,
                    :Hb,
                    :HCT,
                    :BC,
                    :TT,
                    :lympho,
                    :TC,
                    :T3,
                    :FT3,
                    :FT4,
                    :TSH,
                    :Anti_TPO,
                    :TRAb,
                    :SieuAmTuyenGiap,
                    :DoTapTrungI131,
                    :XaHinhTuyenGiap,
                    :DienTim,
                    :SieuAmDopple,
                    :XQTimPhoi,
                    :ChanDoan_Benh,
                    :ChanDoan_BienChung,
                    :ChanDoan_BenhPhoiHop,
                    :DieuTri,
                    :LyDoThemThayThuoc,
                    :HenKhamLaiNgay,
                    :HenXNLaiNgay,
                    :BacSyDieuTri,     
                    :NGUOITAO,
                    :NGUOISUA,
                    :NGAYTAO,
                    :NGAYSUA
                 )  RETURNING ID INTO :ID";
                if (ketQua.ID != 0)
                {
                    sql = @"UPDATE TaiKhamBABenhBaseDow SET 
                    MAQUANLY = :MAQUANLY,
                    MaBenhNhan = :MaBenhNhan,
                    TaiKhamLan = :TaiKhamLan,
                    NgayKham = :NgayKham,
                    CanNang=:CanNang,
                    Mach=:Mach,
                    NhietDo=:NhietDo,
                    HuyetAp=:HuyetAp,
                    NhipTho=:NhipTho,
                    ToanThan_Tinh=:ToanThan_Tinh,
                    ToanThan_DaNongAm=:ToanThan_DaNongAm,
                    ToanThan_DaNiemMacMatVang=:ToanThan_DaNiemMacMatVang,
                    ToanThan_RunTay=:ToanThan_RunTay,
                    ToanThan_Khac=:ToanThan_Khac,
                    NhipTim=:NhipTim,
                    NhipTim_Deu=:NhipTim_Deu,
                    TiengTim=:TiengTim,
                    HA=:HA,
                    TuyenGiap=:TuyenGiap,
                    MatDo_Mem=:MatDo_Mem,
                    MatDo_Chac=:MatDo_Chac,
                    BuouLanToa=:BuouLanToa,
                    NhanThuyPhai=:NhanThuyPhai,
                    NhanThuyTrai=:NhanThuyTrai,
                    Nhan2Thuy=:Nhan2Thuy,
                    TTTT_ThuyPhai=:TTTT_ThuyPhai,
                    TTTT_ThuyTrai=:TTTT_ThuyTrai,
                    TTTT_KhongCo=:TTTT_KhongCo,
                    TTLT_ThuyPhai=:TTLT_ThuyPhai,
                    TTLT_ThuyTrai=:TTLT_ThuyTrai,
                    TTLT_KhongCo=:TTLT_KhongCo,
                    MatPhaiNOSPECSDo=:MatPhaiNOSPECSDo,
                    MatTraiNOSPECSDo=:MatTraiNOSPECSDo,
                    HoHap=:HoHap,
                    ThanKinh=:ThanKinh,
                    Bung=:Bung,
                    BoPhanKhac=:BoPhanKhac,
                    Ure=:Ure,
                    Glucose=:Glucose,
                    Creatinin=:Creatinin,
                    Cholesterol_TP=:Cholesterol_TP,
                    TG=:TG,
                    HDL_C=:HDL_C,
                    LDL_C=:LDL_C,
                    Acid=:Acid,
                    SGOT=:SGOT,
                    SGPT=:SGPT,
                    Protein=:Protein,
                    Albumin=:Albumin,
                    Na=:Na,
                    K=:K,
                    Cl=:Cl,
                    Ca=:Ca,
                    HC=:HC,
                    Hb=:Hb,
                    HCT=:HCT,
                    BC=:BC,
                    TT=:TT,
                    lympho=:lympho,
                    TC=:TC,
                    T3=:T3,
                    FT3=:FT3,
                    FT4=:FT4,
                    TSH=:TSH,
                    Anti_TPO=:Anti_TPO,
                    TRAb=:TRAb,
                    SieuAmTuyenGiap=:SieuAmTuyenGiap,
                    DoTapTrungI131=:DoTapTrungI131,
                    XaHinhTuyenGiap=:XaHinhTuyenGiap,
                    DienTim=:DienTim,
                    SieuAmDopple=:SieuAmDopple,
                    XQTimPhoi=:XQTimPhoi,
                    ChanDoan_Benh=:ChanDoan_Benh,
                    ChanDoan_BienChung=:ChanDoan_BienChung,
                    ChanDoan_BenhPhoiHop=:ChanDoan_BenhPhoiHop,
                    DieuTri=:DieuTri,
                    LyDoThemThayThuoc=:LyDoThemThayThuoc,
                    HenKhamLaiNgay=:HenKhamLaiNgay,
                    HenXNLaiNgay=:HenXNLaiNgay,
                    BacSyDieuTri=:BacSyDieuTri,
                    NGUOISUA = :NGUOISUA,
                    NGAYSUA = :NGAYSUA
                    WHERE ID = " + ketQua.ID;
                }
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MAQUANLY", ketQua.MaQuanLy));
                Command.Parameters.Add(new MDB.MDBParameter("MaBenhNhan", ketQua.MaBenhNhan));
                Command.Parameters.Add(new MDB.MDBParameter("TaiKhamLan", ketQua.TaiKhamLan));
                Command.Parameters.Add(new MDB.MDBParameter("NgayKham", ketQua.NgayKham));
                Command.Parameters.Add(new MDB.MDBParameter("CanNang", ketQua.CanNang));
                Command.Parameters.Add(new MDB.MDBParameter("Mach", ketQua.Mach));
                Command.Parameters.Add(new MDB.MDBParameter("NhietDo", ketQua.NhietDo));
                Command.Parameters.Add(new MDB.MDBParameter("HuyetAp", ketQua.HuyetAp));
                Command.Parameters.Add(new MDB.MDBParameter("NhipTho", ketQua.NhipTho));
                Command.Parameters.Add(new MDB.MDBParameter("ToanThan_Tinh", ketQua.ToanThan_Tinh));
                Command.Parameters.Add(new MDB.MDBParameter("ToanThan_DaNongAm", ketQua.ToanThan_DaNongAm));
                Command.Parameters.Add(new MDB.MDBParameter("ToanThan_DaNiemMacMatVang", ketQua.ToanThan_DaNiemMacMatVang));
                Command.Parameters.Add(new MDB.MDBParameter("ToanThan_RunTay", ketQua.ToanThan_RunTay));
                Command.Parameters.Add(new MDB.MDBParameter("ToanThan_Khac", ketQua.ToanThan_Khac));
                Command.Parameters.Add(new MDB.MDBParameter("NhipTim", ketQua.NhipTim));
                Command.Parameters.Add(new MDB.MDBParameter("NhipTim_Deu", ketQua.NhipTim_Deu));
                Command.Parameters.Add(new MDB.MDBParameter("TiengTim", ketQua.TiengTim));
                Command.Parameters.Add(new MDB.MDBParameter("HA", ketQua.HA));
                Command.Parameters.Add(new MDB.MDBParameter("TuyenGiap", ketQua.TuyenGiap));
                Command.Parameters.Add(new MDB.MDBParameter("MatDo_Mem", ketQua.MatDo_Mem));
                Command.Parameters.Add(new MDB.MDBParameter("MatDo_Chac", ketQua.MatDo_Chac));
                Command.Parameters.Add(new MDB.MDBParameter("BuouLanToa", ketQua.BuouLanToa));
                Command.Parameters.Add(new MDB.MDBParameter("NhanThuyPhai", ketQua.NhanThuyPhai));
                Command.Parameters.Add(new MDB.MDBParameter("NhanThuyTrai", ketQua.NhanThuyTrai));
                Command.Parameters.Add(new MDB.MDBParameter("Nhan2Thuy", ketQua.Nhan2Thuy));
                Command.Parameters.Add(new MDB.MDBParameter("TTTT_ThuyPhai", ketQua.TTTT_ThuyPhai));
                Command.Parameters.Add(new MDB.MDBParameter("TTTT_ThuyTrai", ketQua.TTTT_ThuyTrai));
                Command.Parameters.Add(new MDB.MDBParameter("TTTT_KhongCo", ketQua.TTTT_KhongCo));
                Command.Parameters.Add(new MDB.MDBParameter("TTLT_ThuyPhai", ketQua.TTLT_ThuyPhai));
                Command.Parameters.Add(new MDB.MDBParameter("TTLT_ThuyTrai", ketQua.TTLT_ThuyTrai));
                Command.Parameters.Add(new MDB.MDBParameter("TTLT_KhongCo", ketQua.TTLT_KhongCo));
                Command.Parameters.Add(new MDB.MDBParameter("MatPhaiNOSPECSDo", ketQua.MatPhaiNOSPECSDo));
                Command.Parameters.Add(new MDB.MDBParameter("MatTraiNOSPECSDo", ketQua.MatTraiNOSPECSDo));
                Command.Parameters.Add(new MDB.MDBParameter("HoHap", ketQua.HoHap));
                Command.Parameters.Add(new MDB.MDBParameter("ThanKinh", ketQua.ThanKinh));
                Command.Parameters.Add(new MDB.MDBParameter("Bung", ketQua.Bung));
                Command.Parameters.Add(new MDB.MDBParameter("BoPhanKhac", ketQua.BoPhanKhac));
                Command.Parameters.Add(new MDB.MDBParameter("Ure", ketQua.Ure));
                Command.Parameters.Add(new MDB.MDBParameter("Glucose", ketQua.Glucose));
                Command.Parameters.Add(new MDB.MDBParameter("Creatinin", ketQua.Creatinin));
                Command.Parameters.Add(new MDB.MDBParameter("Cholesterol_TP", ketQua.Cholesterol_TP));
                Command.Parameters.Add(new MDB.MDBParameter("TG", ketQua.TG));
                Command.Parameters.Add(new MDB.MDBParameter("HDL_C", ketQua.HDL_C));
                Command.Parameters.Add(new MDB.MDBParameter("LDL_C", ketQua.LDL_C));
                Command.Parameters.Add(new MDB.MDBParameter("Acid", ketQua.Acid));
                Command.Parameters.Add(new MDB.MDBParameter("SGOT", ketQua.SGOT));
                Command.Parameters.Add(new MDB.MDBParameter("SGPT", ketQua.SGPT));
                Command.Parameters.Add(new MDB.MDBParameter("Protein", ketQua.Protein));
                Command.Parameters.Add(new MDB.MDBParameter("Albumin", ketQua.Albumin));
                Command.Parameters.Add(new MDB.MDBParameter("Na", ketQua.Na));
                Command.Parameters.Add(new MDB.MDBParameter("K", ketQua.K));
                Command.Parameters.Add(new MDB.MDBParameter("Cl", ketQua.Cl));
                Command.Parameters.Add(new MDB.MDBParameter("Ca", ketQua.Ca));
                Command.Parameters.Add(new MDB.MDBParameter("HC", ketQua.HC));
                Command.Parameters.Add(new MDB.MDBParameter("Hb", ketQua.Hb));
                Command.Parameters.Add(new MDB.MDBParameter("HCT", ketQua.HCT));
                Command.Parameters.Add(new MDB.MDBParameter("BC", ketQua.BC));
                Command.Parameters.Add(new MDB.MDBParameter("TT", ketQua.TT));
                Command.Parameters.Add(new MDB.MDBParameter("lympho", ketQua.lympho));
                Command.Parameters.Add(new MDB.MDBParameter("TC", ketQua.TC));
                Command.Parameters.Add(new MDB.MDBParameter("T3", ketQua.T3));
                Command.Parameters.Add(new MDB.MDBParameter("FT3", ketQua.FT3));
                Command.Parameters.Add(new MDB.MDBParameter("FT4", ketQua.FT4));
                Command.Parameters.Add(new MDB.MDBParameter("TSH", ketQua.TSH));
                Command.Parameters.Add(new MDB.MDBParameter("Anti_TPO", ketQua.Anti_TPO));
                Command.Parameters.Add(new MDB.MDBParameter("TRAb", ketQua.TRAb));
                Command.Parameters.Add(new MDB.MDBParameter("SieuAmTuyenGiap", ketQua.SieuAmTuyenGiap));
                Command.Parameters.Add(new MDB.MDBParameter("DoTapTrungI131", ketQua.DoTapTrungI131));
                Command.Parameters.Add(new MDB.MDBParameter("XaHinhTuyenGiap", ketQua.XaHinhTuyenGiap));
                Command.Parameters.Add(new MDB.MDBParameter("DienTim", ketQua.DienTim));
                Command.Parameters.Add(new MDB.MDBParameter("SieuAmDopple", ketQua.SieuAmDopple));
                Command.Parameters.Add(new MDB.MDBParameter("XQTimPhoi", ketQua.XQTimPhoi));
                Command.Parameters.Add(new MDB.MDBParameter("ChanDoan_Benh", ketQua.ChanDoan_Benh));
                Command.Parameters.Add(new MDB.MDBParameter("ChanDoan_BienChung", ketQua.ChanDoan_BienChung));
                Command.Parameters.Add(new MDB.MDBParameter("ChanDoan_BenhPhoiHop", ketQua.ChanDoan_BenhPhoiHop));
                Command.Parameters.Add(new MDB.MDBParameter("DieuTri", ketQua.DieuTri));
                Command.Parameters.Add(new MDB.MDBParameter("LyDoThemThayThuoc", ketQua.LyDoThemThayThuoc));
                Command.Parameters.Add(new MDB.MDBParameter("HenKhamLaiNgay", ketQua.HenKhamLaiNgay));
                Command.Parameters.Add(new MDB.MDBParameter("HenXNLaiNgay", ketQua.HenXNLaiNgay));
                Command.Parameters.Add(new MDB.MDBParameter("BacSyDieuTri", ketQua.BacSyDieuTri));
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
                string sql = "DELETE FROM TaiKhamBABenhBaseDow WHERE ID = :ID";
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
                P.*, f.hovaten BacSyHoVaTen 
            FROM
                TaiKhamBABenhBaseDow P
            left join nhanvien f on P.BacSyDieuTri = f.manhanvien     
            WHERE P.ID = " + id;

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
