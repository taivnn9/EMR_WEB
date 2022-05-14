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
    public class PhieuKhamTienPhau : ThongTinKy
    {
        public PhieuKhamTienPhau()
        {
            TableName = "PhieuKhamTienPhau";
            TablePrimaryKeyName = "ID";
            IDMauPhieu = (int)DanhMucPhieu.GDKBPDV;
            TenMauPhieu = DanhMucPhieu.GDKBPDV.Description();
        }
        // Phần chung
        [MoTaDuLieu("Mã định danh")]
        public long ID { get; set; }
        [MoTaDuLieu("Mã quản lý: mã duy nhất trong 1 đợt khám chữa bệnh (kcb), không trùng giữa các đợt kcb khác nhau", "", 1)]
        public decimal MaQuanLy { get; set; }
        [MoTaDuLieu("Mã bệnh nhân")]
        public string MaBenhNhan { get; set; }
        [MoTaDuLieu("Ngày tạo", null, 0, 0)]
        public DateTime NgayTao { get; set; }
        [MoTaDuLieu("Người tạo", null, 0, 0)]
        public string NguoiTao { get; set; }
        [MoTaDuLieu("Ngày sửa", null, 0, 0)]
        public DateTime NgaySua { get; set; }
        [MoTaDuLieu("Người sửa", null, 0, 0)]
        public string NguoiSua { get; set; }
        [MoTaDuLieu("Đã ký", null, 0, 0)]
        public bool DaKy { get; set; }
        [MoTaDuLieu("Chọn", null, 0, 0)]
        public bool Chon { get; set; }
        // End Phần chung 

        public string BenhVien { get; set; }
        public string Khoa { get; set; }
        public DateTime Gio { get; set; }
        public DateTime Ngay { get; set; }
        public string HoVaTen { get; set; }
        public string Tuoi { get; set; }
        public string Gioi { get; set; }
        public string CanNang { get; set; }
        public int Phai { get; set; } //1 nam 2 nu
        public string ChuanDoanTruocMo { get; set; }
        public string ChuanDoanSauMo { get; set; }

        // Lam sang truoc mo
        public int TongTrang { get; set; } // 1 to 2 trungbinh 3 kem
        public string DiUngThuoc { get; set; }
        public string LanGayMeTruoc { get; set; }
        public int TruyenMau { get; set; } // 1 da truyen , 2 chua truyen

        // Ho Hap
        public int HenSuyen { get; set; }
        public int HutThuoc { get; set; }
        public int LaoPhoi { get; set; }
        public int ViemPhoi { get; set; }
        public int Ran { get; set; }
        public string KhangSinhDangSuDung { get; set; }
        public string VanDeKhacHoHap { get; set; }

        //TuanHoan
        public int CaoHuyetAp { get; set; }
        public int Phu { get; set; }
        public int DauThatNguc { get; set; }
        public int NhoiMauCoTim { get; set; } // 1 co , 2 khong 3 moi
        public string Mach { get; set; }
        public string HuyetAp { get; set; }
        public string NhipTim { get; set; }
        public string ThuocTimMachDangSuDung { get; set; }
        public string VanDeKhacTuanHoan { get; set; }

        // TieuHoa
        public int XoGanCoChuong { get; set; }
        public int ViemGanSieuVi { get; set; }
        public int VangDaMem { get; set; }
        public int BungBang { get; set; }
        public string VanDeKhacTieuHoa { get; set; }


        // HuyetHoc
        public string TienCanChayMau { get; set; }
        public int Heparin { get; set; }
        public int Aspirin { get; set; }
        public int ThuocKhangVitK { get; set; }
        public int ThuocKhac { get; set; }
        public string ThuocKhacNote { get; set; }

        // Noi Tiet
        public int BuouCo { get; set; }
        public int TieuDuong { get; set; }
        public string DungCorrticoide { get; set; }
        public string VanDeKhacNoiTiet { get; set; }


        // XetNghiem
        public string HC { get; set; }
        public string BC { get; set; }
        public string HET { get; set; }
        public string HB { get; set; }
        public string Protid { get; set; }
        public string XQPhoi { get; set; }
        public string TSH { get; set; }
        public string T3 { get; set; }
        public string T4 { get; set; }
        public string ECG { get; set; }
        public string TQ { get; set; }
        public string TCK { get; set; }
        public string SGOT { get; set; }
        public string SGPT { get; set; }
        public string AG { get; set; }
        public string NhomMau { get; set; }
        public string DuongHuyet { get; set; }
        public string DuongNieu { get; set; }
        public string Bun { get; set; }
        public string Creatinine { get; set; }

        // Kham khong khi quan
        public string TinhTrangRang { get; set; }
        public string XepLoai { get; set; }
        public string DoMoMieng { get; set; }
        public string KhoangCach { get; set; }
        public string DoNguaCo { get; set; }

        // Tong ket
        public string DacDiemLamSang { get; set; }
        public string PhanLoai { get; set; }
        public string PPVC { get; set; }
        public string ThuocMe { get; set; }

        // DeNghiThem
        public string XetNghiem { get; set; }
        public string KhamChuyenKhoa { get; set; }
        public string MaBSGayMe { get; set; }
        public string TenBSGayMe { get; set; }
        public string TietNieu { get; set; }
    }

    public class PhieuKhamTienPhauFunc
    {
        public const string TableName = "PhieuKhamTienPhauFunc";
        public const string TablePrimaryKeyName = "ID";
        public static List<PhieuKhamTienPhau> GetListData(MDB.MDBConnection _OracleConnection, decimal maquanly)
        {
            List<PhieuKhamTienPhau> list = new List<PhieuKhamTienPhau>();
            try
            {
                string sql = @"SELECT * FROM PhieuKhamTienPhau where MaQuanLy = :MaQuanLy";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, _OracleConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", maquanly));
                MDB.MDBDataReader DataReader = Command.ExecuteReader();
                while (DataReader.Read())
                {
                    PhieuKhamTienPhau data = new PhieuKhamTienPhau();
                    data.ID = Convert.ToInt64(DataReader.GetLong("ID").ToString());
                    data.MaQuanLy = maquanly;
                    data.MaBenhNhan = DataReader["MaBenhNhan"].ToString();


                    data.BenhVien = DataReader["BenhVien"].ToString();
                    data.Khoa = DataReader["Khoa"].ToString();
                    data.Gio = Convert.ToDateTime(DataReader["Gio"] == DBNull.Value ? DateTime.Now : DataReader["Gio"]);
                    data.Ngay = Convert.ToDateTime(DataReader["Ngay"] == DBNull.Value ? DateTime.Now : DataReader["Ngay"]);
                    data.HoVaTen = DataReader["HoVaTen"].ToString();
                    data.Tuoi = DataReader["Tuoi"].ToString();
                    data.Gioi = DataReader["Gioi"].ToString();
                    data.CanNang = DataReader["CanNang"].ToString();
                    data.Phai = DataReader.GetInt("Phai");
                    data.ChuanDoanTruocMo = DataReader["ChuanDoanTruocMo"].ToString();
                    data.ChuanDoanSauMo = DataReader["ChuanDoanSauMo"].ToString();

                    data.TongTrang = DataReader.GetInt("TongTrang");
                    data.DiUngThuoc = DataReader["DiUngThuoc"].ToString();
                    data.LanGayMeTruoc = DataReader["LanGayMeTruoc"].ToString();
                    data.TruyenMau = DataReader.GetInt("TruyenMau");

                    data.HenSuyen = DataReader.GetInt("HenSuyen");
                    data.HutThuoc = DataReader.GetInt("HutThuoc");
                    data.LaoPhoi = DataReader.GetInt("LaoPhoi");
                    data.ViemPhoi = DataReader.GetInt("ViemPhoi");
                    data.Ran = DataReader.GetInt("Ran");
                    data.KhangSinhDangSuDung = DataReader["KhangSinhDangSuDung"].ToString();
                    data.VanDeKhacHoHap = DataReader["VanDeKhacHoHap"].ToString();

                    data.CaoHuyetAp = DataReader.GetInt("CaoHuyetAp");
                    data.Phu = DataReader.GetInt("Phu");
                    data.DauThatNguc = DataReader.GetInt("DauThatNguc");
                    data.NhoiMauCoTim = DataReader.GetInt("NhoiMauCoTim");
                    data.Mach = DataReader["Mach"].ToString();
                    data.HuyetAp = DataReader["HuyetAp"].ToString();
                    data.NhipTim = DataReader["NhipTim"].ToString();
                    data.ThuocTimMachDangSuDung = DataReader["ThuocTimMachDangSuDung"].ToString();
                    data.VanDeKhacTuanHoan = DataReader["VanDeKhacTuanHoan"].ToString();

                    data.XoGanCoChuong = DataReader.GetInt("XoGanCoChuong");
                    data.ViemGanSieuVi = DataReader.GetInt("ViemGanSieuVi");
                    data.VangDaMem = DataReader.GetInt("VangDaMem");
                    data.BungBang = DataReader.GetInt("BungBang");
                    data.VanDeKhacTieuHoa = DataReader["VanDeKhacTieuHoa"].ToString();

                    data.TienCanChayMau = DataReader["TienCanChayMau"].ToString();
                    data.Heparin = DataReader.GetInt("Heparin");
                    data.Aspirin = DataReader.GetInt("Aspirin");
                    data.ThuocKhangVitK = DataReader.GetInt("ThuocKhangVitK");
                    data.ThuocKhac = DataReader.GetInt("ThuocKhac");
                    data.ThuocKhacNote = DataReader["ThuocKhacNote"].ToString();

                    data.BuouCo = DataReader.GetInt("BuouCo");
                    data.TieuDuong = DataReader.GetInt("TieuDuong");
                    data.DungCorrticoide = DataReader["DungCorrticoide"].ToString();
                    data.VanDeKhacNoiTiet = DataReader["VanDeKhacNoiTiet"].ToString();

                    data.HC = DataReader["HC"].ToString();
                    data.BC = DataReader["BC"].ToString();
                    data.HET = DataReader["HET"].ToString();
                    data.HB = DataReader["HB"].ToString();
                    data.Protid = DataReader["Protid"].ToString();
                    data.XQPhoi = DataReader["XQPhoi"].ToString();
                    data.TSH = DataReader["TSH"].ToString();
                    data.T3 = DataReader["T3"].ToString();
                    data.T4 = DataReader["T4"].ToString();
                    data.ECG = DataReader["ECG"].ToString();
                    data.TQ = DataReader["TQ"].ToString();
                    data.TCK = DataReader["TCK"].ToString();
                    data.SGOT = DataReader["SGOT"].ToString();
                    data.SGPT = DataReader["SGPT"].ToString();
                    data.AG = DataReader["AG"].ToString();
                    data.NhomMau = DataReader["NhomMau"].ToString();
                    data.DuongHuyet = DataReader["DuongHuyet"].ToString();
                    data.DuongNieu = DataReader["DuongNieu"].ToString();
                    data.Bun = DataReader["Bun"].ToString();
                    data.Creatinine = DataReader["Creatinine"].ToString();

                    data.TinhTrangRang = DataReader["TinhTrangRang"].ToString();
                    data.XepLoai = DataReader["XepLoai"].ToString();
                    data.DoMoMieng = DataReader["DoMoMieng"].ToString();
                    data.KhoangCach = DataReader["KhoangCach"].ToString();
                    data.DoNguaCo = DataReader["DoNguaCo"].ToString();

                    data.DacDiemLamSang = DataReader["DacDiemLamSang"].ToString();
                    data.PhanLoai = DataReader["PhanLoai"].ToString();
                    data.PPVC = DataReader["PPVC"].ToString();
                    data.ThuocMe = DataReader["ThuocMe"].ToString();

                    data.XetNghiem = DataReader["XetNghiem"].ToString();
                    data.KhamChuyenKhoa = DataReader["KhamChuyenKhoa"].ToString();
                    data.MaBSGayMe = DataReader["MaBSGayMe"].ToString();
                    data.TenBSGayMe = DataReader["TenBSGayMe"].ToString();

                    data.NgayTao = Convert.ToDateTime(DataReader["NgayTao"] == DBNull.Value ? DateTime.Now : DataReader["NgayTao"]);
                    data.NguoiTao = DataReader["NguoiTao"].ToString();
                    data.NgaySua = Convert.ToDateTime(DataReader["NgaySua"] == DBNull.Value ? DateTime.Now : DataReader["NgaySua"]);
                    data.NguoiSua = DataReader["NguoiSua"].ToString();
                    data.TietNieu = DataReader["TietNieu"].ToString();

                    data.MaSoKy = DataReader["masokyten"].ToString();
                    data.DaKy = !string.IsNullOrEmpty(data.MaSoKy) ? true : false;

                    list.Add(data);
                }
            }
            catch (Exception ex) { XuLyLoi.Handle(ex); }
            return list;
        }
        public static bool InsertOrUpdate(MDB.MDBConnection MyConnection, ref PhieuKhamTienPhau ketQua)
        {
            try
            {
                string sql = @"INSERT INTO PhieuKhamTienPhau
                (
                    MAQUANLY,
                    MaBenhNhan,

                    BenhVien, 
                    Khoa, 
                    Gio, 
                    Ngay, 
                    HoVaTen ,
                    Tuoi ,
                    Gioi ,
                    CanNang ,
                    Phai , 
                    ChuanDoanTruocMo ,
                    ChuanDoanSauMo ,

                    TongTrang , 
                    DiUngThuoc ,
                    LanGayMeTruoc ,
                    TruyenMau,  

                    HenSuyen, 
                    HutThuoc ,
                    LaoPhoi ,
                    ViemPhoi ,
                    Ran ,
                    KhangSinhDangSuDung, 
                    VanDeKhacHoHap ,

                    CaoHuyetAp ,
                    Phu ,
                    DauThatNguc ,
                    NhoiMauCoTim ,
                    Mach ,
                    HuyetAp ,
                    NhipTim ,
                    ThuocTimMachDangSuDung ,
                    VanDeKhacTuanHoan ,

                    XoGanCoChuong, 
                    ViemGanSieuVi ,
                    VangDaMem, 
                    BungBang ,
                    VanDeKhacTieuHoa ,

                    TienCanChayMau ,
                    Heparin ,
                    Aspirin ,
                    ThuocKhangVitK ,
                    ThuocKhac,
                    ThuocKhacNote,

                    BuouCo ,
                    TieuDuong ,
                    DungCorrticoide ,
                    VanDeKhacNoiTiet ,

                    HC ,
                    BC ,
                    HET ,
                    HB ,
                    Protid,
                    XQPhoi ,
                    TSH ,
                    T3 ,
                    T4 ,
                    ECG ,
                    TQ ,
                    TCK ,
                    SGOT ,
                    SGPT ,
                    AG ,
                    NhomMau ,
                    DuongHuyet ,
                    DuongNieu ,
                    Bun ,
                    Creatinine ,

                    TinhTrangRang ,
                    XepLoai ,
                    DoMoMieng ,
                    KhoangCach ,
                    DoNguaCo ,

                    DacDiemLamSang ,
                    PhanLoai ,
                    PPVC ,
                    ThuocMe ,

                    XetNghiem ,
                    KhamChuyenKhoa ,
                    MaBSGayMe ,
                    TenBSGayMe ,
                    TietNieu,

                    NGUOITAO,
                    NGUOISUA,
                    NGAYTAO,
                    NGAYSUA)  VALUES
                 (
				    :MAQUANLY,
                    :MaBenhNhan,

                    :BenhVien, 
                    :Khoa, 
                    :Gio, 
                    :Ngay, 
                    :HoVaTen ,
                    :Tuoi ,
                    :Gioi ,
                    :CanNang ,
                    :Phai , 
                    :ChuanDoanTruocMo ,
                    :ChuanDoanSauMo ,

                    :TongTrang , 
                    :DiUngThuoc ,
                    :LanGayMeTruoc ,
                    :TruyenMau,  

                    :HenSuyen, 
                    :HutThuoc ,
                    :LaoPhoi ,
                    :ViemPhoi ,
                    :Ran ,
                    :KhangSinhDangSuDung, 
                    :VanDeKhacHoHap ,

                    :CaoHuyetAp ,
                    :Phu ,
                    :DauThatNguc ,
                    :NhoiMauCoTim ,
                    :Mach ,
                    :HuyetAp ,
                    :NhipTim ,
                    :ThuocTimMachDangSuDung ,
                    :VanDeKhacTuanHoan ,

                    :XoGanCoChuong, 
                    :ViemGanSieuVi ,
                    :VangDaMem, 
                    :BungBang ,
                    :VanDeKhacTieuHoa ,

                    :TienCanChayMau ,
                    :Heparin ,
                    :Aspirin ,
                    :ThuocKhangVitK ,
                    :ThuocKhac,
                    :ThuocKhacNote,

                    :BuouCo ,
                    :TieuDuong ,
                    :DungCorrticoide ,
                    :VanDeKhacNoiTiet ,

                    :HC ,
                    :BC ,
                    :HET ,
                    :HB ,
                    :Protid,
                    :XQPhoi ,
                    :TSH ,
                    :T3 ,
                    :T4 ,
                    :ECG ,
                    :TQ ,
                    :TCK ,
                    :SGOT ,
                    :SGPT ,
                    :AG ,
                    :NhomMau ,
                    :DuongHuyet ,
                    :DuongNieu ,
                    :Bun ,
                    :Creatinine ,

                    :TinhTrangRang ,
                    :XepLoai ,
                    :DoMoMieng ,
                    :KhoangCach ,
                    :DoNguaCo ,

                    :DacDiemLamSang ,
                    :PhanLoai ,
                    :PPVC ,
                    :ThuocMe ,

                    :XetNghiem ,
                    :KhamChuyenKhoa ,
                    :MaBSGayMe ,
                    :TenBSGayMe ,
                    :TietNieu,

                    :NGUOITAO,
                    :NGUOISUA,
                    :NGAYTAO,
                    :NGAYSUA
                 )  RETURNING ID INTO :ID";
                if (ketQua.ID != 0)
                {
                    sql = @"UPDATE PhieuKhamTienPhau SET 
                    MAQUANLY = :MAQUANLY,
                    MaBenhNhan = :MaBenhNhan,
                    
					BenhVien =:BenhVien, 
                    Khoa =:Khoa, 
                    Gio=:Gio, 
                    Ngay= :Ngay, 
                    HoVaTen =:HoVaTen ,
                    Tuoi =:Tuoi ,
                    Gioi =:Gioi ,
                    CanNang =:CanNang ,
                    Phai = :Phai , 
                    ChuanDoanTruocMo =:ChuanDoanTruocMo ,
                    ChuanDoanSauMo =:ChuanDoanSauMo ,

                    TongTrang = :TongTrang , 
                    DiUngThuoc =:DiUngThuoc ,
                    LanGayMeTruoc =:LanGayMeTruoc ,
                    TruyenMau=  :TruyenMau,  

                    HenSuyen= :HenSuyen, 
                    HutThuoc =:HutThuoc ,
                    LaoPhoi =:LaoPhoi ,
                    ViemPhoi =:ViemPhoi ,
                    Ran =:Ran ,
                    KhangSinhDangSuDung=:KhangSinhDangSuDung, 
                    VanDeKhacHoHap =:VanDeKhacHoHap ,

                    CaoHuyetAp =:CaoHuyetAp ,
                    Phu =:Phu ,
                    DauThatNguc =:DauThatNguc ,
                    NhoiMauCoTim =:NhoiMauCoTim ,
                    Mach =:Mach ,
                    HuyetAp =:HuyetAp ,
                    NhipTim =:NhipTim ,
                    ThuocTimMachDangSuDung=:ThuocTimMachDangSuDung ,
                    VanDeKhacTuanHoan =:VanDeKhacTuanHoan ,

                    XoGanCoChuong=:XoGanCoChuong, 
                    ViemGanSieuVi =:ViemGanSieuVi ,
                    VangDaMem=:VangDaMem, 
                    BungBang =:BungBang ,
                    VanDeKhacTieuHoa =:VanDeKhacTieuHoa ,

                    TienCanChayMau =:TienCanChayMau ,
                    Heparin=:Heparin ,
                    Aspirin =:Aspirin ,
                    ThuocKhangVitK =:ThuocKhangVitK ,
                    ThuocKhac=:ThuocKhac,
                    ThuocKhacNote=:ThuocKhacNote,

                    BuouCo =:BuouCo ,
                    TieuDuong =:TieuDuong ,
                    DungCorrticoide =:DungCorrticoide ,
                    VanDeKhacNoiTiet =:VanDeKhacNoiTiet ,

                    HC =:HC ,
                    BC =:BC ,
                    HET =:HET ,
                    HB =:HB ,
                    Protid=:Protid,
                    XQPhoi =:XQPhoi ,
                    TSH =:TSH ,
                    T3 =:T3 ,
                    T4 =:T4 ,
                    ECG =:ECG ,
                    TQ =:TQ ,
                    TCK =:TCK ,
                    SGOT =:SGOT ,
                    SGPT =:SGPT ,
                    AG =:AG ,
                    NhomMau =:NhomMau ,
                    DuongHuyet =:DuongHuyet ,
                    DuongNieu =:DuongNieu ,
                    Bun =:Bun ,
                    Creatinine =:Creatinine ,

                    TinhTrangRang =:TinhTrangRang ,
                    XepLoai =:XepLoai ,
                    DoMoMieng =:DoMoMieng ,
                    KhoangCach =:KhoangCach ,
                    DoNguaCo =:DoNguaCo ,

                    DacDiemLamSang =:DacDiemLamSang ,
                    PhanLoai =:PhanLoai ,
                    PPVC =:PPVC ,
                    ThuocMe =:ThuocMe ,

                    XetNghiem =:XetNghiem ,
                    KhamChuyenKhoa =:KhamChuyenKhoa ,
                    MaBSGayMe =:MaBSGayMe ,
                    TenBSGayMe =:TenBSGayMe ,
                    TietNieu=:TietNieu,


                    NGUOISUA = :NGUOISUA,
                    NGAYSUA = :NGAYSUA
                    WHERE ID = " + ketQua.ID;
                }
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MAQUANLY", ketQua.MaQuanLy));
                Command.Parameters.Add(new MDB.MDBParameter("MaBenhNhan", ketQua.MaBenhNhan));


                Command.Parameters.Add(new MDB.MDBParameter("BenhVien", ketQua.BenhVien));
                Command.Parameters.Add(new MDB.MDBParameter("Khoa", ketQua.Khoa));
                Command.Parameters.Add(new MDB.MDBParameter("Gio", ketQua.Gio));
                Command.Parameters.Add(new MDB.MDBParameter("Ngay", ketQua.Ngay));
                Command.Parameters.Add(new MDB.MDBParameter("HoVaTen", ketQua.HoVaTen));
                Command.Parameters.Add(new MDB.MDBParameter("Tuoi", ketQua.Tuoi));
                Command.Parameters.Add(new MDB.MDBParameter("Gioi", ketQua.Gioi));
                Command.Parameters.Add(new MDB.MDBParameter("CanNang", ketQua.CanNang));
                Command.Parameters.Add(new MDB.MDBParameter("Phai", ketQua.Phai));
                Command.Parameters.Add(new MDB.MDBParameter("ChuanDoanTruocMo", ketQua.ChuanDoanTruocMo));
                Command.Parameters.Add(new MDB.MDBParameter("ChuanDoanSauMo", ketQua.ChuanDoanSauMo));

                Command.Parameters.Add(new MDB.MDBParameter("TongTrang", ketQua.TongTrang));
                Command.Parameters.Add(new MDB.MDBParameter("DiUngThuoc", ketQua.DiUngThuoc));
                Command.Parameters.Add(new MDB.MDBParameter("LanGayMeTruoc", ketQua.LanGayMeTruoc));
                Command.Parameters.Add(new MDB.MDBParameter("TruyenMau", ketQua.TruyenMau));
                Command.Parameters.Add(new MDB.MDBParameter("HenSuyen", ketQua.HenSuyen));
                Command.Parameters.Add(new MDB.MDBParameter("HutThuoc", ketQua.HutThuoc));
                Command.Parameters.Add(new MDB.MDBParameter("LaoPhoi", ketQua.LaoPhoi));
                Command.Parameters.Add(new MDB.MDBParameter("ViemPhoi", ketQua.ViemPhoi));

                Command.Parameters.Add(new MDB.MDBParameter("Ran", ketQua.Ran));
                Command.Parameters.Add(new MDB.MDBParameter("KhangSinhDangSuDung", ketQua.KhangSinhDangSuDung));
                Command.Parameters.Add(new MDB.MDBParameter("VanDeKhacHoHap", ketQua.VanDeKhacHoHap));
                Command.Parameters.Add(new MDB.MDBParameter("CaoHuyetAp", ketQua.CaoHuyetAp));
                Command.Parameters.Add(new MDB.MDBParameter("Phu", ketQua.Phu));
                Command.Parameters.Add(new MDB.MDBParameter("DauThatNguc", ketQua.DauThatNguc));
                Command.Parameters.Add(new MDB.MDBParameter("NhoiMauCoTim", ketQua.NhoiMauCoTim));
                Command.Parameters.Add(new MDB.MDBParameter("Mach", ketQua.Mach));
                Command.Parameters.Add(new MDB.MDBParameter("HuyetAp", ketQua.HuyetAp));
                Command.Parameters.Add(new MDB.MDBParameter("NhipTim", ketQua.NhipTim));
                Command.Parameters.Add(new MDB.MDBParameter("ThuocTimMachDangSuDung", ketQua.ThuocTimMachDangSuDung));

                Command.Parameters.Add(new MDB.MDBParameter("VanDeKhacTuanHoan", ketQua.VanDeKhacTuanHoan));
                Command.Parameters.Add(new MDB.MDBParameter("XoGanCoChuong", ketQua.XoGanCoChuong));
                Command.Parameters.Add(new MDB.MDBParameter("ViemGanSieuVi", ketQua.ViemGanSieuVi));
                Command.Parameters.Add(new MDB.MDBParameter("VangDaMem", ketQua.VangDaMem));
                Command.Parameters.Add(new MDB.MDBParameter("BungBang", ketQua.BungBang));
                Command.Parameters.Add(new MDB.MDBParameter("VanDeKhacTieuHoa", ketQua.VanDeKhacTieuHoa));
                Command.Parameters.Add(new MDB.MDBParameter("TienCanChayMau", ketQua.TienCanChayMau));

                Command.Parameters.Add(new MDB.MDBParameter("Heparin", ketQua.Heparin));
                Command.Parameters.Add(new MDB.MDBParameter("Aspirin", ketQua.Aspirin));
                Command.Parameters.Add(new MDB.MDBParameter("ThuocKhangVitK", ketQua.ThuocKhangVitK));
                Command.Parameters.Add(new MDB.MDBParameter("BuouCo", ketQua.BuouCo));
                Command.Parameters.Add(new MDB.MDBParameter("TieuDuong", ketQua.TieuDuong));
                Command.Parameters.Add(new MDB.MDBParameter("DungCorrticoide", ketQua.DungCorrticoide));
                Command.Parameters.Add(new MDB.MDBParameter("VanDeKhacNoiTiet", ketQua.VanDeKhacNoiTiet));

                Command.Parameters.Add(new MDB.MDBParameter("HC", ketQua.HC));
                Command.Parameters.Add(new MDB.MDBParameter("BC", ketQua.BC));
                Command.Parameters.Add(new MDB.MDBParameter("HET", ketQua.HET));
                Command.Parameters.Add(new MDB.MDBParameter("HB", ketQua.HB));
                Command.Parameters.Add(new MDB.MDBParameter("Protid", ketQua.Protid));
                Command.Parameters.Add(new MDB.MDBParameter("XQPhoi", ketQua.XQPhoi));
                Command.Parameters.Add(new MDB.MDBParameter("TSH", ketQua.TSH));
                Command.Parameters.Add(new MDB.MDBParameter("T3", ketQua.T3));
                Command.Parameters.Add(new MDB.MDBParameter("T4", ketQua.T4));
                Command.Parameters.Add(new MDB.MDBParameter("ECG", ketQua.ECG));
                Command.Parameters.Add(new MDB.MDBParameter("TQ", ketQua.TQ));
                Command.Parameters.Add(new MDB.MDBParameter("TCK", ketQua.TCK));
                Command.Parameters.Add(new MDB.MDBParameter("SGOT", ketQua.SGOT));
                Command.Parameters.Add(new MDB.MDBParameter("SGPT", ketQua.SGPT));
                Command.Parameters.Add(new MDB.MDBParameter("AG", ketQua.AG));
                Command.Parameters.Add(new MDB.MDBParameter("NhomMau", ketQua.NhomMau));
                Command.Parameters.Add(new MDB.MDBParameter("DuongHuyet", ketQua.DuongHuyet));
                Command.Parameters.Add(new MDB.MDBParameter("DuongNieu", ketQua.DuongNieu));
                Command.Parameters.Add(new MDB.MDBParameter("Bun", ketQua.Bun));
                Command.Parameters.Add(new MDB.MDBParameter("Creatinine", ketQua.Creatinine));

                Command.Parameters.Add(new MDB.MDBParameter("TinhTrangRang", ketQua.TinhTrangRang));
                Command.Parameters.Add(new MDB.MDBParameter("XepLoai", ketQua.XepLoai));
                Command.Parameters.Add(new MDB.MDBParameter("DoMoMieng", ketQua.DoMoMieng));
                Command.Parameters.Add(new MDB.MDBParameter("KhoangCach", ketQua.KhoangCach));
                Command.Parameters.Add(new MDB.MDBParameter("DoNguaCo", ketQua.DoNguaCo));

                Command.Parameters.Add(new MDB.MDBParameter("DacDiemLamSang", ketQua.DacDiemLamSang));
                Command.Parameters.Add(new MDB.MDBParameter("PhanLoai", ketQua.PhanLoai));
                Command.Parameters.Add(new MDB.MDBParameter("PPVC", ketQua.PPVC));
                Command.Parameters.Add(new MDB.MDBParameter("ThuocMe", ketQua.ThuocMe));

                Command.Parameters.Add(new MDB.MDBParameter("XetNghiem", ketQua.XetNghiem));
                Command.Parameters.Add(new MDB.MDBParameter("KhamChuyenKhoa", ketQua.KhamChuyenKhoa));

                Command.Parameters.Add(new MDB.MDBParameter("MaBSGayMe", ketQua.MaBSGayMe));
                var TenBSGayMe = getTen(MyConnection, ketQua.MaBSGayMe);
                Command.Parameters.Add(new MDB.MDBParameter("TenBSGayMe", TenBSGayMe));
                Command.Parameters.Add(new MDB.MDBParameter("ThuocKhac", ketQua.ThuocKhac));
                Command.Parameters.Add(new MDB.MDBParameter("ThuocKhacNote", ketQua.ThuocKhac));
                Command.Parameters.Add(new MDB.MDBParameter("TietNieu", ketQua.TietNieu));

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
        public static string getTen(MDB.MDBConnection MyConnection, string maNhanVien)
        {
            try
            {
                var result = "";
                string sql = "Select HoVaTen From  NhanVien WHERE MaNhanVien = :maNhanVien";
                MDB.MDBCommand command = new MDB.MDBCommand(sql, MyConnection);
                command.Parameters.Add(new MDB.MDBParameter("maNhanVien", maNhanVien));
                command.BindByName = true;
                MDB.MDBDataReader DataReader = command.ExecuteReader();
                while (DataReader.Read())
                {
                    result = DataReader["HoVaTen"].ToString();
                }
                return result;
            }
            catch (Exception ex)
            {
                XuLyLoi.Handle(ex);
            }
            return "";
        }
        public static bool delete(MDB.MDBConnection MyConnection, long id)
        {
            try
            {
                string sql = "DELETE FROM PhieuKhamTienPhau WHERE ID = :ID";
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
                PhieuKhamTienPhau P
            WHERE
                ID = " + id;

            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
            MDB.MDBDataAdapter adt = new MDB.MDBDataAdapter(Command);
            var ds = new DataSet();

            adt.Fill(ds, "KQ");

            return ds;
        }
    }
}
