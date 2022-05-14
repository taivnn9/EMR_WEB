using EMR.KyDienTu;
using EMR_MAIN.DATABASE;
using PMS.Access;

namespace EMR_MAIN
{
    public class BenhAnUngBuou : BenhAnBase, IBase
    {
        public int IDMauPhieu { get; set; } = (int)DanhMucPhieu.BAUB;
        public string TenMauPhieu { get; set; } = DanhMucPhieu.BAUB.Description();
        public string SinhDuc{ set; get; }
        public string BoPhanTonThuong { set; get; }
        public string BoPhanTonThuongHinhAnh { set; get; }
        public string BoPhanTonThuongMoTa { set; get; }
        public string BenhChinhT { set; get; }
        public string BenhChinhM { set; get; }
        public string BenhChinhN { set; get; }
        public string GiaiDoan { set; get; }
        public string XNMau { set; get; }
        public string XNTeBao { set; get; }
        public string XNBLGP { set; get; }
        public string Xquang { set; get; }
        public string SieuAm { set; get; }
        public string XNKhac { set; get; }
        public bool DieuTriTrietDe { set; get; }
        public bool DieuTriTrieuChung { set; get; }
        public string TiaXaTienPhauTaiU { set; get; }
        public string TiaXaTienPhauTaiHach { set; get; }
        public string TiaXaDonThuanTaiU { set; get; }
        public string TiaXaDonThuanTaiHach { set; get; }
        public string PhauThuat { set; get; }
        public string TiaXaHauPhauTaiU { set; get; }
        public string TiaXaHauPhauTaiHach { set; get; }
        public string HoaChat { set; get; }
        public string SoDot { set; get; }
        public string DapUng { set; get; }
        public int DapUngID { set; get; }
        public string DieuTriKhac { set; get; }
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
