using EMR.KyDienTu;
using EMR_MAIN.DATABASE;
using PMS.Access;
using System;

namespace EMR_MAIN
{
    public class BenhAnNgoaiTruYHCT : BenhAnBase, IBase
    {
        public int IDMauPhieu { get; set; } = (int)DanhMucPhieu.BANgTruYHCT;
        public string TenMauPhieu { get; set; } = DanhMucPhieu.BANgTruTMH.Description();
        public string MaICD_NoiChuyenDen { set; get; }
        public string MICD_BenhChinh { set; get; }
        public string MICD_BenhKemTheo { set; get; }
        public string KinhMach { set; get; }
        public string DinhViBenh { set; get; }
        public string MICDVaoVienTheoYHHD { set; get; }
        public string CDBenhKemtheoVVYHHD { set; get; }
        public string MICDBenhKemtheoVVYHHD { set; get; }
        public string MICDBenhChinhVVYHCT { set; get; }
        public string CDBenhKemtheoVVYHCT { set; get; }
        public string MICDBenhKemTheoVVYHCT { set; get; }
        public string MICDRaVienTheoYHHD { set; get; }
        public string CDBenhKemTheoRVYHHD { set; get; }
        public string MICDbenhKemTheoRaVienYHCT { set; get; }
        public string MICDBenhChinhRVYHCT { set; get; }
        public string CDBenhKemTheoRaVienTheoYHCT { set; get; }
        public string MICDbenhKemTheoRaVienYHHD { set; get; }
        public string MaICD_BenhKemTheo_RV_YHCT { set; get; }
        public string MaICD_NoiChuyenDen_YHCT { set; get; }
        public string ChanDoan_KKB_CapCuu_YHCT { set; get; }
        public string MaICD_KKB_CapCuu_YHCT { set; get; }
        public string MaICD_BenhChinh_YHCT { set; get; }
        public string BenhKemTheo_YHCT { set; get; }
        public string MaICD_BenhKemTheo_YHCT { set; get; }
        public string MaICD_BenhChinh_RV_YHCT { set; get; }
        public string BenhKemTheo_RV_YHCT { set; get; }
        public string MaICD_BenhKemTheo_YHHD { set; get; }
        public bool TRUCTIEPVAO { get; set; }
        public bool TaiBien_YHCT { get; set; }
        public bool BienChung_YHCT { get; set; }
        public bool ThuThuat_YHCT { get; set; }
        public string BenhSu { get; set; }
        public string CacBoPhan { set; get; }
        public string TomTatKetQuaCanLamSang { set; get; }
        public string MoTa_VongChan { set; get; }
        public string MoTa_VanChan { set; get; }
        public string MoTa_VaanChan { set; get; }
        public string MoTa_XucChan { set; get; }
        public string MachTayTrai { set; get; }
        public string MachTayPhai { set; get; }
        public string TomTatTuChan { set; get; }
        public string BienPhapLuanTri { set; get; }
        public string BietDanh { set; get; }
        public string BatCuong { set; get; }
        public string TangPhuKinhLac { set; get; }
        public string NguyenNhan { set; get; }
        public bool DieuTriYHCT { set; get; }
        public string PhapDieuTri { set; get; }
        public string PhuongThuoc { set; get; }
        public string PhuongHuyet { set; get; }
        public bool DieuTriKetHopVoiYHHD { set; get; }
        public string DieuTriKetHopVoiYHHD_Text { set; get; }
        public string CheDoDinhDuongTaiNha { set; get; }
        public string CheDoHoLyTaiNha { set; get; }
        public string KetQuaXetNghiemCanLamSang { set; get; }
        public string ChanDoanVaoVienTheoYHCT { set; get; }
        public string ChanDoanVaoVienTheoYHHD { set; get; }
        public string PhuongPhapDieuTriTheoYHHD { set; get; }
        public string PhuongPhapDieuTriTheoYHCT { set; get; }
        public string ChanDoanRaVienTheoYHCT { set; get; }
        public string ChanDoanRaVienTheoYHHD { set; get; }
        public string MotaTienSuBanThan { get; set; }
        public int KetQuaDieuTriID { get; set; }
        public string TinhTrangNguoiBenhKhiRavien { set; get; }
        public int ThoiGianDieuTri { set; get; }
        public DateTime ThoiGianDieuTriTuNgay { set; get; }
        public DateTime ThoiGianDieuTriDenNgay { set; get; }
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
