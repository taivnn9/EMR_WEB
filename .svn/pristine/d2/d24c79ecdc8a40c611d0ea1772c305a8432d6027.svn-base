using EMR.KyDienTu;
using EMR_MAIN.DATABASE;
using PMS.Access;
using System;

namespace EMR_MAIN
{
    public class BenhAnNgoaiTruPemphigoid : BenhAnBase, IBase
    {
        public int IDMauPhieu { get; set; } = (int)DanhMucPhieu.BANgoaiTruHTSS;
        public string TenMauPhieu { get; set; } = DanhMucPhieu.BANgoaiTruHTSS.Description();
        // Phần chung Hành chính
        public decimal MaQuanLy { get; set; }
        public DateTime? DieuTriNgoaiTruTu { get; set; }
        public DateTime? DieuTriNgoaiTruDen { get; set; }
        public string SoCMND { get; set; }
        public DateTime? BaoHiem { get; set; }
        public string ChanDoan_TuyenTruoc { get; set; }
        public string ChanDoanBanDau { get; set; }
        public string ChanDoanTaiKham1 { get; set; }
        public string ChanDoanTaiKham2 { get; set; }
        public string ChanDoanTaiKham3 { get; set; }
        public string ChanDoanTaiKham4 { get; set; }
        public string BenhPhu { get; set; }
        public int KetQuaDieuTri { get; set; }
        public string BienChung_Text { get; set; }
        public string GDPhongKeHoach { get; set; }
        public string GDPhongKhamBenh { get; set; }
        // Phần hỏi bệnh
        public string HB_TGPhatBenh { set; get; }
        public string HB_TuoiBiBenh { set; get; }
        public string HB_LanVaoVien { set; get; }
        public string HB_TrieuChungDauTien { set; get; }
        public string HB_TrieuChung_Khac { set; get; }
        public string HB_QuaTrinhBenhLy { set; get; }
        public string HB_DieuTriTruocDay { set; get; }
        public string HB_TSBT_DiUngThuoc { set; get; }
        public string HB_TSBT_BenhNoiKhoaKhac { set; get; }
        public string HB_TienSuGiaDinh { set; get; }
        public string HB_ToanThan { set; get; }
        public string HB_CacBoPhan { set; get; }
        public string HB_LS_Mach { set; get; }
        public string HB_LS_HuyetAp { set; get; }
        public string HB_LS_NhietDo { set; get; }
        public string HB_LS_NhipTho { set; get; }
        public string HB_LS_CanNang { set; get; }
        public string HB_LS_ChieuCao { set; get; }
        public string HB_LS_BMI { set; get; }
        public int HB_TrieuChungCoNang_Arr { set; get; }
        public string HB_KB_DauHieuKhac { set; get; }
        public int TTD_BongNuoc { set; get; }
        public int TTD_DichBongNuoc { set; get; }
        public int TTD_NDBongNuoc { set; get; }
        public string BongNuoc_KichThuoc { set; get; }
        public string BongNuoc_SoLuong { set; get; }
        public int TTD_VetTrot { set; get; }
        public string VetTrot_SoLuong { set; get; }
        public int TTD_VayTiet { set; get; }
        public int TTD_Sui { set; get; }
        public string TTD_ViTriTT { set; get; }
        public string TTD_DauHieu { set; get; }
        public string TTD_DiemPDAI { set; get; }
        public string TTD_DiemCLCS { set; get; }
        public int HB_CLS_CTM { set; get; }
        public string HB_CLS_CTM_Text { set; get; }
        public int HB_CLS_SHM { set; get; }
        public string HB_CLS_SHM_Text { set; get; }
        public int HB_CLS_PTNT { set; get; }
        public string HB_CLS_PTNT_Text { set; get; }
        public int HB_CLS_XQN { set; get; }
        public string HB_CLS_XQN_Text { set; get; }
        public int HB_CLS_SAOB { set; get; }
        public string HB_CLS_SAOB_Text { set; get; }
        public int HB_CLS_STTB { set; get; }
        public string HB_CLS_XetNghiemTB { set; get; }
        public string HB_CLS_MienDichTT { set; get; }
        public string HB_CLS_MienDichGT { set; get; }
        public string HB_CLS_SinhThietDa { set; get; }
        public string HB_CacXetNghiemKhac { set; get; }
        public string HB_ChanDoan { set; get; }
        public string HB_DieuTri { set; get; }
        public DateTime? NgayTaiKham { set; get; }
        public string KB_Mach { set; get; }
        public int KB_LS_DaNiemMac { set; get; }
        public string KB_Than { set; get; }
        public string KB_Phoi { set; get; }
        public string KB_TieuHoa { set; get; }
        public string KB_Tim { set; get; }
        public string KB_ThanKinh { set; get; }
        public string KB_CoXuongKhop { set; get; }
        public string KB_CoQuanKhac { set; get; }
        public string KB_CanLamSang { set; get; }
        public string KB_TacDungPhu { set; get; }
        public string KB_HuongDieuTri { set; get; }
        public DateTime? KB_NgayTaiKham { set; get; }

        // Phần tổng kết
        public string TomTatKetQua { get; set; }
        public string MaBenhChinh { get; set; }
        public string MaBenhKemTheo { get; set; }
        public string TinhTrangRaVien { get; set; }
        public string TongKet_BacSyDieuTri { get; set; }
        public string TongKet_MaBacSyDieuTri { get; set; }


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
