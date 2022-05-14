using EMR.KyDienTu;
using PMS.Access;
using System;
using System.Collections.Generic;
using System.Data;

namespace EMR_MAIN.DATABASE.Other
{
    public class TaiKhamBenhAnTangHuyetAp : ThongTinKy
    {
        public TaiKhamBenhAnTangHuyetAp()
        {
            TableName = "TaiKhamBenhAnTangHuyetAp";
            TablePrimaryKeyName = "ID";
            IDMauPhieu = (int)DanhMucPhieu.TKBATHA;
            TenMauPhieu = DanhMucPhieu.TKBATHA.Description();
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
        [MoTaDuLieu("1. CHỈ SỐ HA")]
        public string ChiSoHA { get; set; }
        //2. KHÁM TOÀN THÂN
        [MoTaDuLieu("Cân nặng")]
        public string CanNang { get; set; }
        [MoTaDuLieu("Chiều cao")]
        public string ChieuCao { get; set; }
        [MoTaDuLieu("Vòng bụng")]
        public string VongBung { get; set; }
        //3. TRIỆU CHỨNG CƠ NĂNG
        [MoTaDuLieu("Đau đầu, chóng mặt, 1-> có, 2 -> không")]
        public int DauDau { get; set; }
        [MoTaDuLieu("Ho khan, 1-> có, 2 -> không")]
        public int HoKhan { get; set; }
        [MoTaDuLieu("Khó thở khi gắng sức, 1-> có, 2 -> không")]
        public int KhoThoKhiGangSuc { get; set; }
        [MoTaDuLieu("Hồi hộp đánh trống ngực, 1-> có, 2 -> không")]
        public int HoiHopDanhTrongNguc { get; set; }
        [MoTaDuLieu("Ù tai, 1-> có, 2 -> không")]
        public int UTai { get; set; }
        [MoTaDuLieu("Nói giọng, 1-> có, 2 -> không")]
        public int NoiGiong { get; set; }
        [MoTaDuLieu("Đau ngực, 1-> có, 2 -> không")]
        public int DauNguc { get; set; }
        [MoTaDuLieu("Mất ngủ , 1-> có, 2 -> không")]
        public int MatNgu { get; set; }
        //4. TRIỆU CHỨNG THỰC THỂ
        [MoTaDuLieu("Phù hai chân, 1-> có, 2 -> không")]
        public int PhuHaiChan { get; set; }
        [MoTaDuLieu("Méo mồm, 1-> có, 2 -> không")]
        public int MeoMom { get; set; }
        [MoTaDuLieu("Liệt nửa người, 1-> có, 2 -> không")]
        public int LietNuaNguoi { get; set; }
        [MoTaDuLieu("Gáy cứng, 1-> có, 2 -> không")]
        public int GayCung { get; set; }
        //5. CÁC CÂU HỎI KÈM THEO
        [MoTaDuLieu("Tuân thủ điều trị, 1-> có, 2 -> không")]
        public int TuanThuDieuTri { get; set; }
        [MoTaDuLieu("Thực hiện chế độ (ăn kiêng, tập luyện), 1-> có, 2 -> không")]
        public int ThucHienCheDo { get; set; }
        [MoTaDuLieu("Hút thuốc, 1-> có, 2 -> không")]
        public int HutThuoc { get; set; }
        [MoTaDuLieu("Hút thuốc, điếu/ngày")]
        public string HutThuoc_Dieu { get; set; }
        [MoTaDuLieu("Uống rượu, 1-> có, 2 -> không")]
        public int UongRuou { get; set; }
        [MoTaDuLieu("Uống rượu, ml/ngày")]
        public string UongRuou_Ml { get; set; }
        [MoTaDuLieu("6. CÁC TRIỆU CHỨNG KHÁC:")]
        public string CacTrieuChungKhac { get; set; }
        //7. XÉT NGHIỆM
        // Lipid máu
        [MoTaDuLieu("Cholesterol TP ")]
        public string Cholesterol_TP { get; set; }
        [MoTaDuLieu("TG")]
        public string TG { get; set; }
        [MoTaDuLieu("HDL")]
        public string HDL { get; set; }
        [MoTaDuLieu("LDL")]
        public string LDL { get; set; }
        [MoTaDuLieu("Glucose máu")]
        public string GlucoseMau { get; set; }
        [MoTaDuLieu("Đạm niệu")]
        public string DamNiem { get; set; }
        [MoTaDuLieu("Creatinin máu")]
        public string CreatininMau { get; set; }
        [MoTaDuLieu("Siêu âm tim")]
        public string SieuAmTim { get; set; }
        [MoTaDuLieu("Siêu âm tim, Dày thất trái")]
        public string SAT_DayThatTrai { get; set; }
        [MoTaDuLieu("Điện tâm đồ")]
        public string DienTamDo { get; set; }
        [MoTaDuLieu("Trục điện tim")]
        public string TrucDienTim { get; set; }
        [MoTaDuLieu("Điện tâm đồ, Dày thất trái")]
        public string DTD_DayThatTrai { get; set; }
        [MoTaDuLieu("Xquang tim- phổi")]
        public string XQuangTimPhoi { get; set; }
        // 8. CHẨN ĐOÁN
        [MoTaDuLieu("A - Mức độ tăng HA")]
        public string MucDoTangHA { get; set; }
        [MoTaDuLieu("B - Giai đoạn tăng HA")]
        public string GiaiDoanTangHA { get; set; }
        [MoTaDuLieu("C - Các bệnh phối hợp")]
        public string CacBenhPhoiHop { get; set; }

        // 9. ĐIỆU TRỊ
        [MoTaDuLieu("Thực hiện chế độ thay đổi lối sống")]
        public string THCDTDLS { get; set; }
        [MoTaDuLieu("Thuốc điều trị")]
        public string ThuocDieuTri { get; set; }
        [MoTaDuLieu("Lý do thêm thay đổi thuốc")]
        public string LyDoThemThayDoiThuoc { get; set; }
        [MoTaDuLieu("Lý do bệnh nhân bỏ hẹn khám, XN")]
        public string LyDoBNBoKham { get; set; }
        [MoTaDuLieu("Hẹn tái khám ngày")]
        public DateTime? HenTaiKham { get; set; }
        [MoTaDuLieu("Bác sỹ")]
        public string BacSy { get; set; }

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
    public class TaiKhamBenhAnTangHuyetApFunc
    {
        public const string TableName = "TaiKhamBenhAnTangHuyetAp";
        public const string TablePrimaryKeyName = "ID";
        public static List<TaiKhamBenhAnTangHuyetAp> GetListData(MDB.MDBConnection _OracleConnection, decimal maquanly)
        {
            List<TaiKhamBenhAnTangHuyetAp> list = new List<TaiKhamBenhAnTangHuyetAp>();
            try
            {
                string sql = @"SELECT * FROM TaiKhamBenhAnTangHuyetAp where MaQuanLy = :MaQuanLy";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, _OracleConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", maquanly));
                MDB.MDBDataReader DataReader = Command.ExecuteReader();
                while (DataReader.Read())
                {
                    TaiKhamBenhAnTangHuyetAp data = new TaiKhamBenhAnTangHuyetAp();
                    data.ID = Convert.ToInt64(DataReader.GetLong("ID").ToString());
                    data.MaQuanLy = maquanly;
                    data.MaBenhNhan = DataReader["MaBenhNhan"].ToString();
                    data.HoTenBenhNhan = XemBenhAn._HanhChinhBenhNhan.TenBenhNhan;
                    data.Tuoi = XemBenhAn._HanhChinhBenhNhan.Tuoi;
                    data.GioiTinh = XemBenhAn._HanhChinhBenhNhan.GioiTinh.Description();
                    data.TaiKhamLan = DataReader["TaiKhamLan"].ToString();
                    data.NgayKham = DataReader["NgayKham"] != DBNull.Value ? (DateTime?) Convert.ToDateTime(DataReader["NgayKham"].ToString()) : null;

                    data.ChiSoHA = DataReader["ChiSoHA"].ToString();
                    data.CanNang = DataReader["CanNang"].ToString();
                    data.ChieuCao = DataReader["ChieuCao"].ToString();
                    data.VongBung = DataReader["VongBung"].ToString();
                    data.DauDau = DataReader.GetInt("DauDau");
                    data.HoKhan = DataReader.GetInt("HoKhan");
                    data.KhoThoKhiGangSuc = DataReader.GetInt("KhoThoKhiGangSuc");
                    data.HoiHopDanhTrongNguc = DataReader.GetInt("HoiHopDanhTrongNguc");
                    data.UTai = DataReader.GetInt("UTai");
                    data.NoiGiong = DataReader.GetInt("NoiGiong");
                    data.DauNguc = DataReader.GetInt("DauNguc");
                    data.MatNgu = DataReader.GetInt("MatNgu");
                    data.PhuHaiChan = DataReader.GetInt("PhuHaiChan");
                    data.MeoMom = DataReader.GetInt("MeoMom");
                    data.LietNuaNguoi = DataReader.GetInt("LietNuaNguoi");
                    data.GayCung = DataReader.GetInt("GayCung");
                    data.TuanThuDieuTri = DataReader.GetInt("TuanThuDieuTri");
                    data.ThucHienCheDo = DataReader.GetInt("ThucHienCheDo");
                    data.HutThuoc = DataReader.GetInt("HutThuoc");
                    data.HutThuoc_Dieu = DataReader["HutThuoc_Dieu"].ToString();
                    data.UongRuou = DataReader.GetInt("UongRuou");
                    data.UongRuou_Ml = DataReader["UongRuou_Ml"].ToString();
                    data.CacTrieuChungKhac = DataReader["CacTrieuChungKhac"].ToString();
                    data.Cholesterol_TP = DataReader["Cholesterol_TP"].ToString();
                    data.TG = DataReader["TG"].ToString();
                    data.HDL = DataReader["HDL"].ToString();
                    data.LDL = DataReader["LDL"].ToString();
                    data.GlucoseMau = DataReader["GlucoseMau"].ToString();
                    data.DamNiem = DataReader["DamNiem"].ToString();
                    data.CreatininMau = DataReader["CreatininMau"].ToString();
                    data.SieuAmTim = DataReader["SieuAmTim"].ToString();
                    data.SAT_DayThatTrai = DataReader["SAT_DayThatTrai"].ToString();
                    data.DienTamDo = DataReader["DienTamDo"].ToString();
                    data.TrucDienTim = DataReader["TrucDienTim"].ToString();
                    data.DTD_DayThatTrai = DataReader["DTD_DayThatTrai"].ToString();
                    data.XQuangTimPhoi = DataReader["XQuangTimPhoi"].ToString();
                    data.MucDoTangHA = DataReader["MucDoTangHA"].ToString();
                    data.GiaiDoanTangHA = DataReader["GiaiDoanTangHA"].ToString();
                    data.CacBenhPhoiHop = DataReader["CacBenhPhoiHop"].ToString();
                    data.THCDTDLS = DataReader["THCDTDLS"].ToString();
                    data.ThuocDieuTri = DataReader["ThuocDieuTri"].ToString();
                    data.HenTaiKham = DataReader["HenTaiKham"] != DBNull.Value ? (DateTime?)Convert.ToDateTime(DataReader["HenTaiKham"]) : null;
                    data.BacSy = DataReader["BacSy"].ToString();

                    data.LyDoThemThayDoiThuoc = DataReader["LyDoThemThayDoiThuoc"].ToString();
                    data.LyDoBNBoKham = DataReader["LyDoBNBoKham"].ToString();
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
        public static bool InsertOrUpdate(MDB.MDBConnection MyConnection, ref TaiKhamBenhAnTangHuyetAp ketQua)
        {
            try
            {
                string sql = @"INSERT INTO TaiKhamBenhAnTangHuyetAp
                (
                    MAQUANLY,
                    MaBenhNhan,
                    TaiKhamLan,
                    NgayKham,
                    ChiSoHA,
                    CanNang,
                    ChieuCao,
                    VongBung,
                    DauDau,
                    HoKhan,
                    KhoThoKhiGangSuc,
                    HoiHopDanhTrongNguc,
                    UTai,
                    NoiGiong,
                    DauNguc,
                    MatNgu,
                    PhuHaiChan,
                    MeoMom,
                    LietNuaNguoi,
                    GayCung,
                    TuanThuDieuTri,
                    ThucHienCheDo,
                    HutThuoc,
                    HutThuoc_Dieu,
                    UongRuou,
                    UongRuou_Ml,
                    CacTrieuChungKhac,
                    Cholesterol_TP,
                    TG,
                    HDL,
                    LDL,
                    GlucoseMau,
                    DamNiem,
                    CreatininMau,
                    SieuAmTim,
                    SAT_DayThatTrai,
                    DienTamDo,
                    TrucDienTim,
                    DTD_DayThatTrai,
                    XQuangTimPhoi,
                    MucDoTangHA,
                    GiaiDoanTangHA,
                    CacBenhPhoiHop,
                    THCDTDLS,
                    ThuocDieuTri,
                    HenTaiKham,
                    BacSy,
                    LyDoThemThayDoiThuoc,
	                LyDoBNBoKham,
                    NGUOITAO,
                    NGUOISUA,
                    NGAYTAO,
                    NGAYSUA)  VALUES
                 (
				    :MAQUANLY,
                    :MaBenhNhan,
                    :TaiKhamLan,
                    :NgayKham,
                    :ChiSoHA,
                    :CanNang,
                    :ChieuCao,
                    :VongBung,
                    :DauDau,
                    :HoKhan,
                    :KhoThoKhiGangSuc,
                    :HoiHopDanhTrongNguc,
                    :UTai,
                    :NoiGiong,
                    :DauNguc,
                    :MatNgu,
                    :PhuHaiChan,
                    :MeoMom,
                    :LietNuaNguoi,
                    :GayCung,
                    :TuanThuDieuTri,
                    :ThucHienCheDo,
                    :HutThuoc,
                    :HutThuoc_Dieu,
                    :UongRuou,
                    :UongRuou_Ml,
                    :CacTrieuChungKhac,
                    :Cholesterol_TP,
                    :TG,
                    :HDL,
                    :LDL,
                    :GlucoseMau,
                    :DamNiem,
                    :CreatininMau,
                    :SieuAmTim,
                    :SAT_DayThatTrai,
                    :DienTamDo,
                    :TrucDienTim,
                    :DTD_DayThatTrai,
                    :XQuangTimPhoi,
                    :MucDoTangHA,
                    :GiaiDoanTangHA,
                    :CacBenhPhoiHop,
                    :THCDTDLS,
                    :ThuocDieuTri,
                    :HenTaiKham,
                    :BacSy,         
                    :LyDoThemThayDoiThuoc,
	                :LyDoBNBoKham,
                    :NGUOITAO,
                    :NGUOISUA,
                    :NGAYTAO,
                    :NGAYSUA
                 )  RETURNING ID INTO :ID";
                if (ketQua.ID != 0)
                {
                    sql = @"UPDATE TaiKhamBenhAnTangHuyetAp SET 
                    MAQUANLY = :MAQUANLY,
                    MaBenhNhan = :MaBenhNhan,
                    TaiKhamLan = :TaiKhamLan,
                    NgayKham = :NgayKham,
                    ChiSoHA=:ChiSoHA,
                    CanNang=:CanNang,
                    ChieuCao=:ChieuCao,
                    VongBung=:VongBung,
                    DauDau=:DauDau,
                    HoKhan=:HoKhan,
                    KhoThoKhiGangSuc=:KhoThoKhiGangSuc,
                    HoiHopDanhTrongNguc=:HoiHopDanhTrongNguc,
                    UTai=:UTai,
                    NoiGiong=:NoiGiong,
                    DauNguc=:DauNguc,
                    MatNgu=:MatNgu,
                    PhuHaiChan=:PhuHaiChan,
                    MeoMom=:MeoMom,
                    LietNuaNguoi=:LietNuaNguoi,
                    GayCung=:GayCung,
                    TuanThuDieuTri=:TuanThuDieuTri,
                    ThucHienCheDo=:ThucHienCheDo,
                    HutThuoc=:HutThuoc,
                    HutThuoc_Dieu=:HutThuoc_Dieu,
                    UongRuou=:UongRuou,
                    UongRuou_Ml=:UongRuou_Ml,
                    CacTrieuChungKhac=:CacTrieuChungKhac,
                    Cholesterol_TP=:Cholesterol_TP,
                    TG=:TG,
                    HDL=:HDL,
                    LDL=:LDL,
                    GlucoseMau=:GlucoseMau,
                    DamNiem=:DamNiem,
                    CreatininMau=:CreatininMau,
                    SieuAmTim=:SieuAmTim,
                    SAT_DayThatTrai=:SAT_DayThatTrai,
                    DienTamDo=:DienTamDo,
                    TrucDienTim=:TrucDienTim,
                    DTD_DayThatTrai=:DTD_DayThatTrai,
                    XQuangTimPhoi=:XQuangTimPhoi,
                    MucDoTangHA=:MucDoTangHA,
                    GiaiDoanTangHA=:GiaiDoanTangHA,
                    CacBenhPhoiHop=:CacBenhPhoiHop,
                    THCDTDLS=:THCDTDLS,
                    ThuocDieuTri=:ThuocDieuTri,
                    HenTaiKham=:HenTaiKham,
                    BacSy=:BacSy,
                    LyDoThemThayDoiThuoc = :LyDoThemThayDoiThuoc,
	                LyDoBNBoKham = :LyDoBNBoKham,
                    NGUOISUA = :NGUOISUA,
                    NGAYSUA = :NGAYSUA
                    WHERE ID = " + ketQua.ID;
                }
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MAQUANLY", ketQua.MaQuanLy));
                Command.Parameters.Add(new MDB.MDBParameter("MaBenhNhan", ketQua.MaBenhNhan));
                Command.Parameters.Add(new MDB.MDBParameter("TaiKhamLan", ketQua.TaiKhamLan));
                Command.Parameters.Add(new MDB.MDBParameter("NgayKham", ketQua.NgayKham));
                Command.Parameters.Add(new MDB.MDBParameter("ChiSoHA", ketQua.ChiSoHA));
                Command.Parameters.Add(new MDB.MDBParameter("CanNang", ketQua.CanNang));
                Command.Parameters.Add(new MDB.MDBParameter("ChieuCao", ketQua.ChieuCao));
                Command.Parameters.Add(new MDB.MDBParameter("VongBung", ketQua.VongBung));
                Command.Parameters.Add(new MDB.MDBParameter("DauDau", ketQua.DauDau));
                Command.Parameters.Add(new MDB.MDBParameter("HoKhan", ketQua.HoKhan));
                Command.Parameters.Add(new MDB.MDBParameter("KhoThoKhiGangSuc", ketQua.KhoThoKhiGangSuc));
                Command.Parameters.Add(new MDB.MDBParameter("HoiHopDanhTrongNguc", ketQua.HoiHopDanhTrongNguc));
                Command.Parameters.Add(new MDB.MDBParameter("UTai", ketQua.UTai));
                Command.Parameters.Add(new MDB.MDBParameter("NoiGiong", ketQua.NoiGiong));
                Command.Parameters.Add(new MDB.MDBParameter("DauNguc", ketQua.DauNguc));
                Command.Parameters.Add(new MDB.MDBParameter("MatNgu", ketQua.MatNgu));
                Command.Parameters.Add(new MDB.MDBParameter("PhuHaiChan", ketQua.PhuHaiChan));
                Command.Parameters.Add(new MDB.MDBParameter("MeoMom", ketQua.MeoMom));
                Command.Parameters.Add(new MDB.MDBParameter("LietNuaNguoi", ketQua.LietNuaNguoi));
                Command.Parameters.Add(new MDB.MDBParameter("GayCung", ketQua.GayCung));
                Command.Parameters.Add(new MDB.MDBParameter("TuanThuDieuTri", ketQua.TuanThuDieuTri));
                Command.Parameters.Add(new MDB.MDBParameter("ThucHienCheDo", ketQua.ThucHienCheDo));
                Command.Parameters.Add(new MDB.MDBParameter("HutThuoc", ketQua.HutThuoc));
                Command.Parameters.Add(new MDB.MDBParameter("HutThuoc_Dieu", ketQua.HutThuoc_Dieu));
                Command.Parameters.Add(new MDB.MDBParameter("UongRuou", ketQua.UongRuou));
                Command.Parameters.Add(new MDB.MDBParameter("UongRuou_Ml", ketQua.UongRuou_Ml));
                Command.Parameters.Add(new MDB.MDBParameter("CacTrieuChungKhac", ketQua.CacTrieuChungKhac));
                Command.Parameters.Add(new MDB.MDBParameter("Cholesterol_TP", ketQua.Cholesterol_TP));
                Command.Parameters.Add(new MDB.MDBParameter("TG", ketQua.TG));
                Command.Parameters.Add(new MDB.MDBParameter("HDL", ketQua.HDL));
                Command.Parameters.Add(new MDB.MDBParameter("LDL", ketQua.LDL));
                Command.Parameters.Add(new MDB.MDBParameter("GlucoseMau", ketQua.GlucoseMau));
                Command.Parameters.Add(new MDB.MDBParameter("DamNiem", ketQua.DamNiem));
                Command.Parameters.Add(new MDB.MDBParameter("CreatininMau", ketQua.CreatininMau));
                Command.Parameters.Add(new MDB.MDBParameter("SieuAmTim", ketQua.SieuAmTim));
                Command.Parameters.Add(new MDB.MDBParameter("SAT_DayThatTrai", ketQua.SAT_DayThatTrai));
                Command.Parameters.Add(new MDB.MDBParameter("DienTamDo", ketQua.DienTamDo));
                Command.Parameters.Add(new MDB.MDBParameter("TrucDienTim", ketQua.TrucDienTim));
                Command.Parameters.Add(new MDB.MDBParameter("DTD_DayThatTrai", ketQua.DTD_DayThatTrai));
                Command.Parameters.Add(new MDB.MDBParameter("XQuangTimPhoi", ketQua.XQuangTimPhoi));
                Command.Parameters.Add(new MDB.MDBParameter("MucDoTangHA", ketQua.MucDoTangHA));
                Command.Parameters.Add(new MDB.MDBParameter("GiaiDoanTangHA", ketQua.GiaiDoanTangHA));
                Command.Parameters.Add(new MDB.MDBParameter("CacBenhPhoiHop", ketQua.CacBenhPhoiHop));
                Command.Parameters.Add(new MDB.MDBParameter("THCDTDLS", ketQua.THCDTDLS));
                Command.Parameters.Add(new MDB.MDBParameter("ThuocDieuTri", ketQua.ThuocDieuTri));
                Command.Parameters.Add(new MDB.MDBParameter("HenTaiKham", ketQua.HenTaiKham));
                Command.Parameters.Add(new MDB.MDBParameter("BacSy", ketQua.BacSy));

                Command.Parameters.Add(new MDB.MDBParameter("LyDoThemThayDoiThuoc", ketQua.LyDoThemThayDoiThuoc));
                Command.Parameters.Add(new MDB.MDBParameter("LyDoBNBoKham", ketQua.LyDoBNBoKham));
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
                string sql = "DELETE FROM TaiKhamBenhAnTangHuyetAp WHERE ID = :ID";
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
                TaiKhamBenhAnTangHuyetAp P
            left join nhanvien f on P.BacSy = f.manhanvien     
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
