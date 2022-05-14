using EMR.KyDienTu;
using PMS.Access;

namespace EMR_MAIN.DATABASE.BenhAn
{
    public class NguyCoMachVanh
    {
        public bool NamTren5Tuoi { get; set; }
        public bool HutThuocLa { get; set; }
        public bool DaiThaoDuong { get; set; }
        public bool CaoHuyetAp { get; set; }
        public bool RoiLoanMoMau { get; set; }
        public bool YeuToGiaDinh { get; set; }
        public bool NuManKinh { get; set; }
    }
    public class TrieuChungCoNang
    {
        public bool KhoThoNYHA { get; set; }
        public bool HoRaMau { get; set; }
        public bool DauNguc { get; set; }
        public bool Tim { get; set; }
        public bool NgoiXom { get; set; }
        public bool Ngat { get; set; }
        public bool HoiHop { get; set; }
        public string CacDauHieuKhac { get; set; }

    }
    public class BenhNoiKhoa
    {
        public bool ViemLoetDaDayHT2 { get; set; }
        public bool HenFQ { get; set; }
        public bool ThapTim { get; set; }
        public bool BenhPhoiMan { get; set; }
        public string BenhKhac { get; set; }
    }
    public class BenhAnTim : BenhAnBase, IBase
    {
        public int IDMauPhieu { get; set; } = (int)DanhMucPhieu.BATim;
        public string TenMauPhieu { get; set; } = DanhMucPhieu.BATim.Description();
        public string CacThuocDangDung { get; set; }
        public int TienSuPKhiSinh { get; set; }
        public string BenhLyMeTrongThaiky { get; set; }
        public string SuDungThuocMeTrongThaiKy { get; set; }
        public NguyCoMachVanh YeuToNguyCoMachVanh { get; set; }
        public BenhNoiKhoa BenhNoiKhoa { get; set; }
        // tham kham
        public string DaNiemMac { get; set; }
        public string Phu { get; set; }
        public string NgonTayChanDuiTrong { get; set; }
        public string HachNgoaiBienTuyenGiap { get; set; }
        public TrieuChungCoNang TrieuChungCoNang { get; set; }
        public string LongNguc { get; set; }
        public string ViTriMomTim { get; set; }
        public string TiengTim { get; set; }
        public string TiengThoiMachCanh { get; set; }
        public string TiengThoiTaiTim { get; set; }
        public string TiengThoiTaiViTriKhac { get; set; }
        public string Bung { get; set; }
        public string CacCoQuanKhac { get; set; }
        public string ChanDoanSoBo { get; set; }
        public string KetQuaXetNghiem { get; set; }
        public string ChanDoanXacDinh { get; set; }
        public string BoXungBenhAn { get; set; }
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