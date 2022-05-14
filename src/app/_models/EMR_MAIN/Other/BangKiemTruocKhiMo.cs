using EMR.KyDienTu;
using System;
using System.Collections.Generic;
using System.Data;
using PMS.Access;
using PMS.Access;
namespace EMR_MAIN.DATABASE.Other
{
    public class BangKiemTruocKhiMo : ThongTinKy
    {
        public BangKiemTruocKhiMo()
        {
            TableName = "BangKiemTruocKhiMo";
            TablePrimaryKeyName = "ID";
            IDMauPhieu = (int)DanhMucPhieu.BKTKM;
            TenMauPhieu = DanhMucPhieu.BKTKM.Description();
        }
        [MoTaDuLieu("Mã định danh")]
		public long ID { get; set; }
        [MoTaDuLieu("Mã quản lý: mã duy nhất trong 1 đợt khám chữa bệnh (kcb), không trùng giữa các đợt kcb khác nhau","",1)]
		public decimal MaQuanLy { get; set; }
        [MoTaDuLieu("Mã bệnh nhân")]
		public string MaBenhNhan { get; set; }
        [MoTaDuLieu("Ngày mổ")]
        public DateTime NgayMo { get; set; }
        [MoTaDuLieu("Giờ mổ")]
        public DateTime GioMo { get; set; }
        [MoTaDuLieu("Chẩn đoán bệnh")]
		public string ChanDoan { get; set; }
        [MoTaDuLieu("Danh sách các loại phẩu thuật")]
        public bool[] PhauThuatArray { get; } = new bool[] { false, false, false };
        [MoTaDuLieu("Phẫu thuật")]
        public int PhauThuat
        {
            get
            {
                return Array.IndexOf(PhauThuatArray, true) + 1;
            }
            set
            {
                for (int i = 0; i < 3; i++)
                {
                    if (i == (value - 1)) PhauThuatArray[i] = true;
                    else PhauThuatArray[i] = false;
                }
            }
        }

        public bool[] CTMArray { get; } = new bool[] { false, false };
        [MoTaDuLieu("CTM")]
        public int CTM
        {
            get
            {
                return Array.IndexOf(CTMArray, true) + 1;
            }
            set
            {
                for (int i = 0; i < 2; i++)
                {
                    if (i == (value - 1)) CTMArray[i] = true;
                    else CTMArray[i] = false;
                }
            }
        }

        public bool[] TQTCKArray { get; } = new bool[] { false, false };
        [MoTaDuLieu("TQ-TCK")]
        public int TQTCK
        {
            get
            {
                return Array.IndexOf(TQTCKArray, true) + 1;
            }
            set
            {
                for (int i = 0; i < 2; i++)
                {
                    if (i == (value - 1)) TQTCKArray[i] = true;
                    else TQTCKArray[i] = false;
                }
            }
        }
        public bool[] NhomMauArray { get; } = new bool[] { false, false };
        [MoTaDuLieu("Nhóm máu")]
        public int NhomMau
        {
            get
            {
                return Array.IndexOf(NhomMauArray, true) + 1;
            }
            set
            {
                for (int i = 0; i < 2; i++)
                {
                    if (i == (value - 1)) NhomMauArray[i] = true;
                    else NhomMauArray[i] = false;
                }
            }
        }

        public bool[] DuongMauArray { get; } = new bool[] { false, false };
        [MoTaDuLieu("Đường máu")]
        public int DuongMau
        {
            get
            {
                return Array.IndexOf(DuongMauArray, true) + 1;
            }
            set
            {
                for (int i = 0; i < 2; i++)
                {
                    if (i == (value - 1)) DuongMauArray[i] = true;
                    else DuongMauArray[i] = false;
                }
            }
        }

        public bool[] UreCreatiminArray { get; } = new bool[] { false, false };
        [MoTaDuLieu("Urée, Créatimin")]
        public int UreCreatimin
        {
            get
            {
                return Array.IndexOf(UreCreatiminArray, true) + 1;
            }
            set
            {
                for (int i = 0; i < 2; i++)
                {
                    if (i == (value - 1)) UreCreatiminArray[i] = true;
                    else UreCreatiminArray[i] = false;
                }
            }
        }

        public bool[] IonDoArray { get; } = new bool[] { false, false };
        [MoTaDuLieu("Ion đồ")]
        public int IonDo
        {
            get
            {
                return Array.IndexOf(IonDoArray, true) + 1;
            }
            set
            {
                for (int i = 0; i < 2; i++)
                {
                    if (i == (value - 1)) IonDoArray[i] = true;
                    else IonDoArray[i] = false;
                }
            }
        }

        public bool[] ChucNangGanArray { get; } = new bool[] { false, false };
        [MoTaDuLieu("Chức năng gan")]
        public int ChucNangGan
        {
            get
            {
                return Array.IndexOf(ChucNangGanArray, true) + 1;
            }
            set
            {
                for (int i = 0; i < 2; i++)
                {
                    if (i == (value - 1)) ChucNangGanArray[i] = true;
                    else ChucNangGanArray[i] = false;
                }
            }
        }

        public bool[] ChucNangTuyenGiapArray { get; } = new bool[] { false, false };
        [MoTaDuLieu("Chức năng tuyến giáp")]
        public int ChucNangTuyenGiap
        {
            get
            {
                return Array.IndexOf(ChucNangTuyenGiapArray, true) + 1;
            }
            set
            {
                for (int i = 0; i < 2; i++)
                {
                    if (i == (value - 1)) ChucNangTuyenGiapArray[i] = true;
                    else ChucNangTuyenGiapArray[i] = false;
                }
            }
        }

        public bool[] TestNhanhHIVArray { get; } = new bool[] { false, false };
        [MoTaDuLieu("Test nhanh HIV")]
        public int TestNhanhHIV
        {
            get
            {
                return Array.IndexOf(TestNhanhHIVArray, true) + 1;
            }
            set
            {
                for (int i = 0; i < 2; i++)
                {
                    if (i == (value - 1)) TestNhanhHIVArray[i] = true;
                    else TestNhanhHIVArray[i] = false;
                }
            }
        }
        [MoTaDuLieu("Các xét nghiệm khác")]
        public string CacXetNghiemKhac { get; set; }
        public bool[] ECGArray { get; } = new bool[] { false, false };
        [MoTaDuLieu("ECG")]
        public int ECG
        {
            get
            {
                return Array.IndexOf(ECGArray, true) + 1;
            }
            set
            {
                for (int i = 0; i < 2; i++)
                {
                    if (i == (value - 1)) ECGArray[i] = true;
                    else ECGArray[i] = false;
                }
            }
        }

        public bool[] ChupTimPhoiArray { get; } = new bool[] { false, false };
        [MoTaDuLieu(" Chụp tim phổi")]
        public int ChupTimPhoi
        {
            get
            {
                return Array.IndexOf(ChupTimPhoiArray, true) + 1;
            }
            set
            {
                for (int i = 0; i < 2; i++)
                {
                    if (i == (value - 1)) ChupTimPhoiArray[i] = true;
                    else ChupTimPhoiArray[i] = false;
                }
            }
        }

        public bool[] SieuAmBungTongQuatArray { get; } = new bool[] { false, false };
        [MoTaDuLieu("Siêu âm bụng tổng quát")]
        public int SieuAmBungTongQuat
        {
            get
            {
                return Array.IndexOf(SieuAmBungTongQuatArray, true) + 1;
            }
            set
            {
                for (int i = 0; i < 2; i++)
                {
                    if (i == (value - 1)) SieuAmBungTongQuatArray[i] = true;
                    else SieuAmBungTongQuatArray[i] = false;
                }
            }
        }

        public bool[] CTScannerArray { get; } = new bool[] { false, false };
        [MoTaDuLieu("CT Scanner")]
        public int CTScanner
        {
            get
            {
                return Array.IndexOf(CTScannerArray, true) + 1;
            }
            set
            {
                for (int i = 0; i < 2; i++)
                {
                    if (i == (value - 1)) CTScannerArray[i] = true;
                    else CTScannerArray[i] = false;
                }
            }
        }

        public bool[] DuTruMauArray { get; } = new bool[] { false, false };
        [MoTaDuLieu("Dự trù máu")]
        public int DuTruMau
        {
            get
            {
                return Array.IndexOf(DuTruMauArray, true) + 1;
            }
            set
            {
                for (int i = 0; i < 2; i++)
                {
                    if (i == (value - 1)) DuTruMauArray[i] = true;
                    else DuTruMauArray[i] = false;
                }
            }
        }

        [MoTaDuLieu("Xét nghiệm chuyên biệt")]
        public string XetNghiemChuyenBiet { get; set; }
        [MoTaDuLieu("Dự trù máu đã có sẵn chưa?")]
        public string DuTruMauDaCoSan { get; set; }
        [MoTaDuLieu("Dự trù máu ở đâu?")]
        public string DuTruMauODau { get; set; }

        public bool[] KhamTienMeArray { get; } = new bool[] { false, false };
        [MoTaDuLieu("Khám tiền mê")]
        public int KhamTienMe
        {
            get
            {
                return Array.IndexOf(KhamTienMeArray, true) + 1;
            }
            set
            {
                for (int i = 0; i < 2; i++)
                {
                    if (i == (value - 1)) KhamTienMeArray[i] = true;
                    else KhamTienMeArray[i] = false;
                }
            }
        }

        public bool[] TimMachArray { get; } = new bool[] { false, false };
        [MoTaDuLieu("Tim mạch")]
        public int TimMach
        {
            get
            {
                return Array.IndexOf(TimMachArray, true) + 1;
            }
            set
            {
                for (int i = 0; i < 2; i++)
                {
                    if (i == (value - 1)) TimMachArray[i] = true;
                    else TimMachArray[i] = false;
                }
            }
        }

        public bool[] TaiMuiHongArray { get; } = new bool[] { false, false };
        [MoTaDuLieu("Tai mũi họng")]
        public int TaiMuiHong
        {
            get
            {
                return Array.IndexOf(TaiMuiHongArray, true) + 1;
            }
            set
            {
                for (int i = 0; i < 2; i++)
                {
                    if (i == (value - 1)) TaiMuiHongArray[i] = true;
                    else TaiMuiHongArray[i] = false;
                }
            }
        }

        public bool[] BienBanHoiChanPhauThuatArray { get; } = new bool[] { false, false };
        [MoTaDuLieu("Biên bản hội chuẩn phẫu thuật")]
        public int BienBanHoiChanPhauThuat
        {
            get
            {
                return Array.IndexOf(BienBanHoiChanPhauThuatArray, true) + 1;
            }
            set
            {
                for (int i = 0; i < 2; i++)
                {
                    if (i == (value - 1)) BienBanHoiChanPhauThuatArray[i] = true;
                    else BienBanHoiChanPhauThuatArray[i] = false;
                }
            }
        }

        public bool[] KyGiayCamKetMoArray { get; } = new bool[] { false, false };
        [MoTaDuLieu("Ký giấy cam kết mổ")]
        public int KyGiayCamKetMo
        {
            get
            {
                return Array.IndexOf(KyGiayCamKetMoArray, true) + 1;
            }
            set
            {
                for (int i = 0; i < 2; i++)
                {
                    if (i == (value - 1)) KyGiayCamKetMoArray[i] = true;
                    else KyGiayCamKetMoArray[i] = false;
                }
            }
        }

        public bool[] ChuanBiRuotArray { get; } = new bool[] { false, false };
        [MoTaDuLieu("Chuẩn bị ruột bệnh nhân trước khi mổ")]
        public int ChuanBiRuot
        {
            get
            {
                return Array.IndexOf(ChuanBiRuotArray, true) + 1;
            }
            set
            {
                for (int i = 0; i < 2; i++)
                {
                    if (i == (value - 1)) ChuanBiRuotArray[i] = true;
                    else ChuanBiRuotArray[i] = false;
                }
            }
        }

        [MoTaDuLieu("Tình trạng bệnh nhân thụt tháo")]
        public string TinhTrangThutThao { get; set; }
        public bool[] ChuanBiVungDaTruocMoArray { get; } = new bool[] { false, false };
        [MoTaDuLieu("Chuẩn bị vùng da trước mổ")]
        public int ChuanBiVungDaTruocMo
        {
            get
            {
                return Array.IndexOf(ChuanBiVungDaTruocMoArray, true) + 1;
            }
            set
            {
                for (int i = 0; i < 2; i++)
                {
                    if (i == (value - 1)) ChuanBiVungDaTruocMoArray[i] = true;
                    else ChuanBiVungDaTruocMoArray[i] = false;
                }
            }
        }
        [MoTaDuLieu("Dấu hiệu sinh tồn")]
        public int DHST_M { get; set; }
        [MoTaDuLieu("Dấu hiệu sinh tồn M")]
        public double DHST_HA { get; set; }
        [MoTaDuLieu("Dấu hiệu sinh tồn T")]
        public double DHST_T { get; set; }
        [MoTaDuLieu("Dấu hiệu sinh tồn NT")]
        public double DHST_NT { get; set; }
        [MoTaDuLieu("Dấu hiệu sinh tồn Tri giác")]
        public string DHST_TriGiac { get; set; }

        public bool[] TamTruocKhiMoArray { get; } = new bool[] { false, false };
        [MoTaDuLieu(" Tắm trước khi mổ")]
        public int TamTruocKhiMo
        {
            get
            {
                return Array.IndexOf(TamTruocKhiMoArray, true) + 1;
            }
            set
            {
                for (int i = 0; i < 2; i++)
                {
                    if (i == (value - 1)) TamTruocKhiMoArray[i] = true;
                    else TamTruocKhiMoArray[i] = false;
                }
            }
        }

        [MoTaDuLieu("Họ tên điều dưỡng bàn giao")]
		public string DieuDuongBanGiao { get; set; }
        [MoTaDuLieu("Mã điều dưỡng bàn giao")]
		public string MaDieuDuongBanGiao { get; set; }
        [MoTaDuLieu("")]
        public string BacSyGayMe { get; set; }
        [MoTaDuLieu("")]
        public string MaBacSyGayMe { get; set; }
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
    public class BangKiemTruocKhiMoFunc
    {
        public const string TableName = "BangKiemTruocKhiMo";
        public const string TablePrimaryKeyName = "ID";
        public static List<BangKiemTruocKhiMo> GetListData(MDB.MDBConnection _OracleConnection, decimal maquanly)
        {
            List<BangKiemTruocKhiMo> list = new List<BangKiemTruocKhiMo>();
            try
            {
                string sql = @"SELECT * FROM BangKiemTruocKhiMo where MaQuanLy = :MaQuanLy";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, _OracleConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", maquanly));
                MDB.MDBDataReader DataReader = Command.ExecuteReader();
                while (DataReader.Read())
                {
                    BangKiemTruocKhiMo data = new BangKiemTruocKhiMo();
                    data.ID = Convert.ToInt64(DataReader.GetLong("ID").ToString());
                    data.MaQuanLy = maquanly;
                    data.MaBenhNhan = DataReader["MaBenhNhan"].ToString();
                    data.NgayMo = Convert.ToDateTime(DataReader["NgayGioMo"] == DBNull.Value ? DateTime.Now : DataReader["NgayGioMo"]);
                    data.GioMo = Convert.ToDateTime(DataReader["NgayGioMo"] == DBNull.Value ? DateTime.Now : DataReader["NgayGioMo"]);
                    data.ChanDoan = DataReader["ChanDoan"].ToString();
                   
                    int tempInt = -1;
                    int.TryParse(DataReader["PhauThuat"].ToString(), out tempInt);
                    data.PhauThuat = tempInt;

                    tempInt = -1;
                    int.TryParse(DataReader["CTM"].ToString(), out tempInt);
                    data.CTM = tempInt;

                    tempInt = -1;
                    int.TryParse(DataReader["TQTCK"].ToString(), out tempInt);
                    data.TQTCK = tempInt;

                    tempInt = -1;
                    int.TryParse(DataReader["NhomMau"].ToString(), out tempInt);
                    data.NhomMau = tempInt;

                    tempInt = -1;
                    int.TryParse(DataReader["DuongMau"].ToString(), out tempInt);
                    data.DuongMau = tempInt;

                    tempInt = -1;
                    int.TryParse(DataReader["UreCreatimin"].ToString(), out tempInt);
                    data.UreCreatimin = tempInt;

                    tempInt = -1;
                    int.TryParse(DataReader["IonDo"].ToString(), out tempInt);
                    data.IonDo = tempInt;

                    tempInt = -1;
                    int.TryParse(DataReader["ChucNangGan"].ToString(), out tempInt);
                    data.ChucNangGan = tempInt;

                    tempInt = -1;
                    int.TryParse(DataReader["ChucNangTuyenGiap"].ToString(), out tempInt);
                    data.ChucNangTuyenGiap = tempInt;

                    tempInt = -1;
                    int.TryParse(DataReader["TestNhanhHIV"].ToString(), out tempInt);
                    data.TestNhanhHIV = tempInt;

                    data.CacXetNghiemKhac = DataReader["CacXetNghiemKhac"].ToString();

                    tempInt = -1;
                    int.TryParse(DataReader["ECG"].ToString(), out tempInt);
                    data.ECG = tempInt;

                    tempInt = -1;
                    int.TryParse(DataReader["ChupTimPhoi"].ToString(), out tempInt);
                    data.ChupTimPhoi = tempInt;

                    tempInt = -1;
                    int.TryParse(DataReader["SieuAmBungTongQuat"].ToString(), out tempInt);
                    data.SieuAmBungTongQuat = tempInt;

                    tempInt = -1;
                    int.TryParse(DataReader["CTScanner"].ToString(), out tempInt);
                    data.CTScanner = tempInt;

                    tempInt = -1;
                    int.TryParse(DataReader["DuTruMau"].ToString(), out tempInt);
                    data.DuTruMau = tempInt;

                    data.XetNghiemChuyenBiet = DataReader["XetNghiemChuyenBiet"].ToString();
                    data.DuTruMauDaCoSan = DataReader["DuTruMauDaCoSan"].ToString();
                    data.DuTruMauODau = DataReader["DuTruMauODau"].ToString();

                    tempInt = -1;
                    int.TryParse(DataReader["KhamTienMe"].ToString(), out tempInt);
                    data.KhamTienMe = tempInt;

                    tempInt = -1;
                    int.TryParse(DataReader["TimMach"].ToString(), out tempInt);
                    data.TimMach = tempInt;

                    tempInt = -1;
                    int.TryParse(DataReader["TaiMuiHong"].ToString(), out tempInt);
                    data.TaiMuiHong = tempInt;

                    tempInt = -1;
                    int.TryParse(DataReader["BienBanHoiChanPhauThuat"].ToString(), out tempInt);
                    data.BienBanHoiChanPhauThuat = tempInt;

                    tempInt = -1;
                    int.TryParse(DataReader["KyGiayCamKetMo"].ToString(), out tempInt);
                    data.KyGiayCamKetMo = tempInt;

                    tempInt = -1;
                    int.TryParse(DataReader["ChuanBiRuot"].ToString(), out tempInt);
                    data.ChuanBiRuot = tempInt;

                    data.TinhTrangThutThao = DataReader["TinhTrangThutThao"].ToString();

                    tempInt = -1;
                    int.TryParse(DataReader["ChuanBiVungDaTruocMo"].ToString(), out tempInt);
                    data.ChuanBiVungDaTruocMo = tempInt;

                    tempInt = -1;
                    int.TryParse(DataReader["DHST_M"].ToString(), out tempInt);
                    data.DHST_M = tempInt;

                    double tempDouble = 0;
                    double.TryParse(DataReader["DHST_HA"].ToString(), out tempDouble);
                    data.DHST_HA = tempDouble;

                    tempDouble = 0;
                    double.TryParse(DataReader["DHST_T"].ToString(), out tempDouble);
                    data.DHST_T = tempDouble;

                    tempDouble = 0;
                    double.TryParse(DataReader["DHST_NT"].ToString(), out tempDouble);
                    data.DHST_NT = tempDouble;

                    data.DHST_TriGiac = DataReader["DHST_TriGiac"].ToString();

                    tempInt = -1;
                    int.TryParse(DataReader["TamTruocKhiMo"].ToString(), out tempInt);
                    data.TamTruocKhiMo = tempInt;

                    data.DieuDuongBanGiao = DataReader["DieuDuongBanGiao"].ToString();
                    data.MaDieuDuongBanGiao = DataReader["MaDieuDuongBanGiao"].ToString();
                    data.BacSyGayMe = DataReader["BacSyGayMe"].ToString();
                    data.MaBacSyGayMe = DataReader["MaBacSyGayMe"].ToString();

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
        public static bool InsertOrUpdate(MDB.MDBConnection MyConnection, ref BangKiemTruocKhiMo bangKiemTruocKhiMo)
        {
            try
            {
                string sql = @"INSERT INTO BangKiemTruocKhiMo
                (
                    MAQUANLY,
                    MaBenhNhan,
                    NgayGioMo,
                    ChanDoan,
                    PhauThuat,
                    CTM,
                    TQTCK,
                    NhomMau,
                    DuongMau,
                    UreCreatimin,
                    IonDo,
                    ChucNangGan,
                    ChucNangTuyenGiap,
                    TestNhanhHIV,
                    CacXetNghiemKhac,
                    ECG,
                    ChupTimPhoi,
                    SieuAmBungTongQuat,
                    CTScanner,
                    DuTruMau,
                    XetNghiemChuyenBiet,
                    DuTruMauDaCoSan,
                    DuTruMauODau,
                    KhamTienMe,
                    TimMach,
                    TaiMuiHong,
                    BienBanHoiChanPhauThuat,
                    KyGiayCamKetMo,
                    ChuanBiRuot,
                    TinhTrangThutThao,
                    ChuanBiVungDaTruocMo,
                    DHST_M,
                    DHST_HA,
                    DHST_T,
                    DHST_NT,
                    DHST_TriGiac,
                    TamTruocKhiMo,
                    DieuDuongBanGiao,
                    MaDieuDuongBanGiao,
                    BacSyGayMe,
                    MaBacSyGayMe,
                    NGUOITAO,
                    NGUOISUA,
                    NGAYTAO,
                    NGAYSUA)  VALUES
                 (
				    :MAQUANLY,
                    :MaBenhNhan,
                    :NgayGioMo,
                    :ChanDoan,
                    :PhauThuat,
                    :CTM,
                    :TQTCK,
                    :NhomMau,
                    :DuongMau,
                    :UreCreatimin,
                    :IonDo,
                    :ChucNangGan,
                    :ChucNangTuyenGiap,
                    :TestNhanhHIV,
                    :CacXetNghiemKhac,
                    :ECG,
                    :ChupTimPhoi,
                    :SieuAmBungTongQuat,
                    :CTScanner,
                    :DuTruMau,
                    :XetNghiemChuyenBiet,
                    :DuTruMauDaCoSan,
                    :DuTruMauODau,
                    :KhamTienMe,
                    :TimMach,
                    :TaiMuiHong,
                    :BienBanHoiChanPhauThuat,
                    :KyGiayCamKetMo,
                    :ChuanBiRuot,
                    :TinhTrangThutThao,
                    :ChuanBiVungDaTruocMo,
                    :DHST_M,
                    :DHST_HA,
                    :DHST_T,
                    :DHST_NT,
                    :DHST_TriGiac,
                    :TamTruocKhiMo,
                    :DieuDuongBanGiao,
                    :MaDieuDuongBanGiao,
                    :BacSyGayMe,
                    :MaBacSyGayMe,
                    :NGUOITAO,
                    :NGUOISUA,
                    :NGAYTAO,
                    :NGAYSUA
                 )  RETURNING ID INTO :ID";
                if (bangKiemTruocKhiMo.ID != 0)
                {
                    sql = @"UPDATE BangKiemTruocKhiMo SET 
                    MAQUANLY = :MAQUANLY,
                    MaBenhNhan = :MaBenhNhan,
                    NgayGioMo = :NgayGioMo,
                    ChanDoan = :ChanDoan,
                    PhauThuat = :PhauThuat,
                    CTM = :CTM,
                    TQTCK = :TQTCK,
                    NhomMau = :NhomMau,
                    DuongMau = :DuongMau,
                    UreCreatimin = :UreCreatimin,
                    IonDo = :IonDo,
                    ChucNangGan = :ChucNangGan,
                    ChucNangTuyenGiap = :ChucNangTuyenGiap,
                    TestNhanhHIV = :TestNhanhHIV,
                    CacXetNghiemKhac = :CacXetNghiemKhac,
                    ECG = :ECG,
                    ChupTimPhoi = :ChupTimPhoi,
                    SieuAmBungTongQuat = :SieuAmBungTongQuat,
                    CTScanner = :CTScanner,
                    DuTruMau = :DuTruMau,
                    XetNghiemChuyenBiet = :XetNghiemChuyenBiet,
                    DuTruMauDaCoSan = :DuTruMauDaCoSan,
                    DuTruMauODau = :DuTruMauODau,
                    KhamTienMe = :KhamTienMe,
                    TimMach = :TimMach,
                    TaiMuiHong = :TaiMuiHong,
                    BienBanHoiChanPhauThuat = :BienBanHoiChanPhauThuat,
                    KyGiayCamKetMo = :KyGiayCamKetMo,
                    ChuanBiRuot = :ChuanBiRuot,
                    TinhTrangThutThao = :TinhTrangThutThao,
                    ChuanBiVungDaTruocMo = :ChuanBiVungDaTruocMo,
                    DHST_M = :DHST_M,
                    DHST_HA = :DHST_HA,
                    DHST_T = :DHST_T,
                    DHST_NT = :DHST_NT,
                    DHST_TriGiac = :DHST_TriGiac,
                    TamTruocKhiMo = :TamTruocKhiMo,
                    DieuDuongBanGiao = :DieuDuongBanGiao,
                    MaDieuDuongBanGiao = :MaDieuDuongBanGiao,
                    BacSyGayMe = :BacSyGayMe,
                    MaBacSyGayMe = :MaBacSyGayMe,
                    NGUOISUA = :NGUOISUA,
                    NGAYSUA = :NGAYSUA 
                    WHERE ID = " + bangKiemTruocKhiMo.ID;
                }
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MAQUANLY", bangKiemTruocKhiMo.MaQuanLy));
                Command.Parameters.Add(new MDB.MDBParameter("MaBenhNhan", bangKiemTruocKhiMo.MaBenhNhan));
                var Ngay = bangKiemTruocKhiMo.NgayMo.Date.Add(new TimeSpan(0, 0, 0));
                var Gio = bangKiemTruocKhiMo.GioMo != null ? bangKiemTruocKhiMo.GioMo.TimeOfDay : DateTime.Now.TimeOfDay;
                var NgayGioMo = Ngay + Gio;
                Command.Parameters.Add(new MDB.MDBParameter("NgayGioMo", NgayGioMo));
                Command.Parameters.Add(new MDB.MDBParameter("ChanDoan", bangKiemTruocKhiMo.ChanDoan));
                Command.Parameters.Add(new MDB.MDBParameter("PhauThuat", bangKiemTruocKhiMo.PhauThuat));
                Command.Parameters.Add(new MDB.MDBParameter("CTM", bangKiemTruocKhiMo.CTM));
                Command.Parameters.Add(new MDB.MDBParameter("TQTCK", bangKiemTruocKhiMo.TQTCK));
                Command.Parameters.Add(new MDB.MDBParameter("NhomMau", bangKiemTruocKhiMo.NhomMau));
                Command.Parameters.Add(new MDB.MDBParameter("DuongMau", bangKiemTruocKhiMo.DuongMau));
                Command.Parameters.Add(new MDB.MDBParameter("UreCreatimin", bangKiemTruocKhiMo.UreCreatimin));
                Command.Parameters.Add(new MDB.MDBParameter("IonDo", bangKiemTruocKhiMo.IonDo));
                Command.Parameters.Add(new MDB.MDBParameter("ChucNangGan", bangKiemTruocKhiMo.ChucNangGan));
                Command.Parameters.Add(new MDB.MDBParameter("ChucNangTuyenGiap", bangKiemTruocKhiMo.ChucNangTuyenGiap));
                Command.Parameters.Add(new MDB.MDBParameter("TestNhanhHIV", bangKiemTruocKhiMo.TestNhanhHIV));
                Command.Parameters.Add(new MDB.MDBParameter("CacXetNghiemKhac", bangKiemTruocKhiMo.CacXetNghiemKhac));
                Command.Parameters.Add(new MDB.MDBParameter("ECG", bangKiemTruocKhiMo.ECG));
                Command.Parameters.Add(new MDB.MDBParameter("ChupTimPhoi", bangKiemTruocKhiMo.ChupTimPhoi));
                Command.Parameters.Add(new MDB.MDBParameter("SieuAmBungTongQuat", bangKiemTruocKhiMo.SieuAmBungTongQuat));
                Command.Parameters.Add(new MDB.MDBParameter("CTScanner", bangKiemTruocKhiMo.CTScanner));
                Command.Parameters.Add(new MDB.MDBParameter("DuTruMau", bangKiemTruocKhiMo.DuTruMau));
                Command.Parameters.Add(new MDB.MDBParameter("XetNghiemChuyenBiet", bangKiemTruocKhiMo.XetNghiemChuyenBiet));
                Command.Parameters.Add(new MDB.MDBParameter("DuTruMauDaCoSan", bangKiemTruocKhiMo.DuTruMauDaCoSan));
                Command.Parameters.Add(new MDB.MDBParameter("DuTruMauODau", bangKiemTruocKhiMo.DuTruMauODau));
                Command.Parameters.Add(new MDB.MDBParameter("KhamTienMe", bangKiemTruocKhiMo.KhamTienMe));
                Command.Parameters.Add(new MDB.MDBParameter("TimMach", bangKiemTruocKhiMo.TimMach));
                Command.Parameters.Add(new MDB.MDBParameter("TaiMuiHong", bangKiemTruocKhiMo.TaiMuiHong));
                Command.Parameters.Add(new MDB.MDBParameter("BienBanHoiChanPhauThuat", bangKiemTruocKhiMo.BienBanHoiChanPhauThuat));
                Command.Parameters.Add(new MDB.MDBParameter("KyGiayCamKetMo", bangKiemTruocKhiMo.KyGiayCamKetMo));
                Command.Parameters.Add(new MDB.MDBParameter("ChuanBiRuot", bangKiemTruocKhiMo.ChuanBiRuot));
                Command.Parameters.Add(new MDB.MDBParameter("TinhTrangThutThao", bangKiemTruocKhiMo.TinhTrangThutThao));
                Command.Parameters.Add(new MDB.MDBParameter("ChuanBiVungDaTruocMo", bangKiemTruocKhiMo.ChuanBiVungDaTruocMo));
                Command.Parameters.Add(new MDB.MDBParameter("DHST_M", bangKiemTruocKhiMo.DHST_M));
                Command.Parameters.Add(new MDB.MDBParameter("DHST_HA", bangKiemTruocKhiMo.DHST_HA));
                Command.Parameters.Add(new MDB.MDBParameter("DHST_T", bangKiemTruocKhiMo.DHST_T));
                Command.Parameters.Add(new MDB.MDBParameter("DHST_NT", bangKiemTruocKhiMo.DHST_NT));
                Command.Parameters.Add(new MDB.MDBParameter("DHST_TriGiac", bangKiemTruocKhiMo.DHST_TriGiac));
                Command.Parameters.Add(new MDB.MDBParameter("TamTruocKhiMo", bangKiemTruocKhiMo.TamTruocKhiMo));
                Command.Parameters.Add(new MDB.MDBParameter("DieuDuongBanGiao", bangKiemTruocKhiMo.DieuDuongBanGiao));
                Command.Parameters.Add(new MDB.MDBParameter("MaDieuDuongBanGiao", bangKiemTruocKhiMo.MaDieuDuongBanGiao));
                Command.Parameters.Add(new MDB.MDBParameter("BacSyGayMe", bangKiemTruocKhiMo.BacSyGayMe));
                Command.Parameters.Add(new MDB.MDBParameter("MaBacSyGayMe", bangKiemTruocKhiMo.MaBacSyGayMe));
                Command.Parameters.Add(new MDB.MDBParameter("NGUOISUA", bangKiemTruocKhiMo.NguoiSua));
                Command.Parameters.Add(new MDB.MDBParameter("NGAYSUA", bangKiemTruocKhiMo.NgaySua));
                if (bangKiemTruocKhiMo.ID == 0)
                {
                    Command.Parameters.Add(new MDB.MDBParameter("ID", bangKiemTruocKhiMo.ID));
                    Command.Parameters.Add(new MDB.MDBParameter("NGUOITAO", bangKiemTruocKhiMo.NguoiTao));
                    Command.Parameters.Add(new MDB.MDBParameter("NGAYTAO", bangKiemTruocKhiMo.NgayTao));
                }
                Command.BindByName = true;
                int n = Command.ExecuteNonQuery();
                if (bangKiemTruocKhiMo.ID == 0)
                {
                    long nextval = Convert.ToInt64((Command.Parameters["ID"] as MDB.MDBParameter).Value);
                    bangKiemTruocKhiMo.ID = nextval;
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
                string sql = "DELETE FROM BangKiemTruocKhiMo WHERE ID = :ID";
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
                B.*,
                T.MABENHAN,
	            H.TENBENHNHAN,
                H.TUOI
            FROM
                BangKiemTruocKhiMo B
                JOIN THONGTINDIEUTRI T ON B.MAQUANLY = T.MAQUANLY
                JOIN HANHCHINHBENHNHAN H ON T.MABENHNHAN = H.MABENHNHAN
            WHERE
                ID = " + id;

            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);

            MDB.MDBDataAdapter adt = new MDB.MDBDataAdapter(Command);
            var ds = new DataSet();

            adt.Fill(ds, "BK");

            /*DataTable thongTinVien = new DataTable("HEADER");

            thongTinVien.Columns.Add("BENHVIEN");
            thongTinVien.Columns.Add("KHOA");
			if (XemBenhAn._HanhChinhBenhNhan == null) XemBenhAn._HanhChinhBenhNhan = new HanhChinhBenhNhan();
            if (XemBenhAn._ThongTinDieuTri == null) XemBenhAn._ThongTinDieuTri = new ThongTinDieuTri();
            thongTinVien.Rows.Add(XemBenhAn._HanhChinhBenhNhan.BenhVien, XemBenhAn._ThongTinDieuTri.Khoa);
            ds.Tables.Add(thongTinVien);*/

            return ds;
        }
    }

}
