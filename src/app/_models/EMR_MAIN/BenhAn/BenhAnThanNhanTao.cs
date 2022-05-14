using EMR.KyDienTu;
using PMS.Access;

namespace EMR_MAIN.DATABASE.BenhAn
{
    public class BenhAnThanNhanTao : BenhAnBase, IBase
    {
        public int IDMauPhieu { get; set; } = (int)DanhMucPhieu.BATNT;
        public string TenMauPhieu { get; set; } = DanhMucPhieu.BATNT.Description();
        public string TheTrang { get; set; }
        public string YThuc { get; set; }
        public string DaNiemMac { get; set; }
        #region TietNieu
        public bool Is_DaiMau { get; set; }
        public bool Is_DaiDuc { get; set; }
        public bool Is_DaiRaHB { get; set; }
        public bool Is_DaiRat { get; set; }
        public bool Is_DaiBuot { get; set; }
        public bool Is_ConDauQuanThan { get; set; }
        public bool Is_ThanTo { get; set; }
        #endregion
        #region HoiChungThuaNuoc
        public bool Is_Phu { get; set; }
        public bool Is_TranDichMangBung { get; set; }
        public bool Is_TranDichMangPhoi { get; set; }
        public bool Is_TranDichMangTim { get; set; }
        #endregion
        public string NhipTim { get; set; }
        public string LoaiNhipTim { get; set; }
        public string TiengThoi { get; set; }
        public string SuyTim { get; set; }
        public string KieuTho { get; set; }
        public string RalesOPhoi { get; set; }
        public bool Is_DauHieuKhoTho { get; set; }
        public bool Is_DauHieuPhuPhoi { get; set; }
        #region TieuHoa
        public bool Is_VangDa { get; set; }
        public bool Is_GanTo { get; set; }
        public bool Is_VangMat { get; set; }
        public bool Is_LachTo { get; set; }
        #endregion
        #region TrieuChungTrayMau
        public bool Is_NonMau { get; set; }
        public bool Is_DiNgoaiPhanDen { get; set; }
        public bool Is_XuatHuyetDuoiDaVaNiemMac { get; set; }
        #endregion
        #region TrieuChungThanKinhTamThan
        public bool Is_RoiLoanVanDong { get; set; }
        public bool Is_HoiChungMangNao { get; set; }
        public bool Is_RoiLoanCamGiac { get; set; }
        public bool Is_HoiChungTienDinhTieuNao { get; set; }
        public bool Is_TamThanPhanLiet { get; set; }
        public bool Is_HoiChungCacDayTKSoNao { get; set; }
        public bool Is_HoiChungTramCam { get; set; }
        public bool Is_ViemCacDayTKNgoaiVi { get; set; }
        #endregion
        #region CacTrieuChungKhac
        public string DaLieu { get; set; }
        #endregion
        #region XetNghiemSinhHoa
        public string UreMau { get; set; }
        public string CreatinineMau { get; set; }
        public string Na { get; set; }
        public string DuongMau { get; set; }
        public string K { get; set; }
        public string ProtidMau { get; set; }
        public string Ca { get; set; }
        public string AcidUricMau { get; set; }
        public string Cl { get; set; }
        public string CholesterolTF { get; set; }
        public string Phospho { get; set; }
        public string BilirubineTF { get; set; }
        public string Sat { get; set; }
        public string BilirubineTT { get; set; }
        public string BilirubineGT { get; set; }
        public string PhMau { get; set; }
        public string ApLucThamThauMau { get; set; }
        public string SGOT { get; set; }
        public string MucLocCauThan { get; set; }
        public string SGPT { get; set; }
        #endregion
        #region XetNghiemHuyetHoc
        public string HongCau { get; set; }
        public string AntiHbC { get; set; }
        public string BachCau { get; set; }
        public string HbeAg { get; set; }
        public string BachCauTrungTinh { get; set; }
        public string BachCauAiToan { get; set; }
        public string BachCauAiKiem { get; set; }
        public string AntiHbeAg { get; set; }
        public string HbsAg { get; set; }
        public string AntiHbsAg { get; set; }
        public string TieuCau { get; set; }
        public string AntiHCV { get; set; }
        public string HemoGlobine { get; set; }
        public string KSTSotRet { get; set; }
        public string Hematocrite { get; set; }
        public string DocChat { get; set; }
        public string HIV { get; set; }
        #endregion
        #region XetNghiemNuocTieu
        public string ProteineNieu { get; set; }
        public string UreNieu { get; set; }
        public string BachCauNieu { get; set; }
        public string Creatinine { get; set; }
        public string TruNieu { get; set; }
        public string NaNieu { get; set; }
        public string HemoglobineNieu { get; set; }
        public string GlucoseNieu { get; set; }
        #endregion
        #region CacThamDoKhac
        public string X_Quang { get; set; }
        public string SieuAm { get; set; }
        public string DienTim { get; set; }
        public string SinhThiet { get; set; }
        #endregion
        [MoTaDuLieu("", "", 0, 0)]
        public string MaSoKyTen { set; get; }
        [MoTaDuLieu("", "", 0, 0)]
        public string MaSoKyTen_KB { set; get; }
        [MoTaDuLieu("", "", 0, 0)]
        public string MaSoKyTen_TK { set; get; }
        [MoTaDuLieu("", "", 0, 0)]
        public bool DaKy
        {
            get
            {
                return !MaSoKyTen.IsNullOrEmpty();
            }
            set
            {
            }
        }
        [MoTaDuLieu("", "", 0, 0)]
        public bool DaKy_KB
        {
            get
            {
                return !MaSoKyTen.IsNullOrEmpty();
            }
            set
            {
            }
        }
        [MoTaDuLieu("", "", 0, 0)]
        public bool DaKy_TK
        {
            get
            {
                return !MaSoKyTen.IsNullOrEmpty();
            }
            set
            {
            }
        }
    }
}
