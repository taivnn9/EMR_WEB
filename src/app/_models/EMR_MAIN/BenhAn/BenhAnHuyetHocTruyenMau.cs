using EMR.KyDienTu;
using EMR_MAIN.DATABASE;
using PMS.Access;

namespace EMR_MAIN
{
    public class BenhAnHuyetHocTruyenMau : BenhAnBase, IBase
    {
        public int IDMauPhieu { get; set; } = (int)DanhMucPhieu.BAHHTM;
        public string TenMauPhieu { get; set; }= DanhMucPhieu.BAHHTM.Description();
        public string TinhThanCuaNguoiBenh { set; get; }
        public string HinhDangTuThe { set; get; }
        public string DaNiemMac { set; get; }
        public string TrieuChungXuatHuyet { set; get; }
        public string HeThongLong_Toc_Mong { set; get; }
        public string TrieuChungPhu { set; get; }
        public string TuyenGiap { set; get; }
        public string KichThuoc_Gan { get; set; }
        public string MatDo_Gan { get; set; }
        public string Bo_Gan { get; set; }
        public string MatGan_Gan { get; set; }
        public string Dau_Gan { get; set; }
        public string KichThuoc_Lach { get; set; }
        public string MatDo_Lach { get; set; }
        public string Bo_Lach { get; set; }
        public string MatGan_Lach { get; set; }
        public string Dau_Lach { get; set; }
        public string ViTri_Hach { get; set; }
        public string KichThuoc_Hach { get; set; }
        public string SoLuong_Hach { get; set; }
        public string DoDiDong_Hach { get; set; }
        public string MatHach_Hach { get; set; }
        public string Dau_Hach { get; set; }
        public bool HuyetDo { get; set; }
        public bool TuyDo { get; set; }
        public bool SinhThietTuy { get; set; }
        public bool SinhThietHach { get; set; }
        public bool DongMauToanBo { get; set; }
        public bool DinhLuongYeuToMauDong { get; set; }
        public bool DienDiHST { get; set; }
        public bool NhiemSacThe { get; set; }
        public bool NhomMau { get; set; }
        public bool CoombsTest { get; set; }
        public bool KhangTheBatThuong { get; set; }
        public bool SinhHoa { get; set; }
        public bool GPB { get; set; }
        public bool ViSinh { get; set; }
        public bool XQuang { get; set; }
        public int KhoiHongCau { get; set; }
        public int HuyetTuuong { get; set; }
        public int HongCauRua { get; set; }
        public int HuyetTuongDongLanh { get; set; }
        public int KhoiTieuCau { get; set; }
        public int TuaVIII { get; set; }
        public int KhoiBachCauHat { get; set; }
        public int TruyenMauToanPhan { get; set; }
        public int CacPhanUngKhiTruyenMau { get; set; }
        public bool PhanTichTeBao { get; set; }
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
