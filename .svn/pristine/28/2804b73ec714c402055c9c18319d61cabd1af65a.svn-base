using EMR.KyDienTu;
using EMR_MAIN.DATABASE;
using PMS.Access;

namespace EMR_MAIN
{
    public class BenhAnTaiMuiHong : BenhAnBase, IBase
    {
        public int IDMauPhieu { get; set; } = (int)DanhMucPhieu.BATMH;
        public string TenMauPhieu { get; set; } = DanhMucPhieu.BATMH.Description();
        public bool PhauThuat { set; get; }
        public bool ThuThuat { set; get; }
        public string BenhChuyenKhoa { set; get; }
        public string DaVaMoDuoiDa{ set; get; }
        public string ManNhiPhai_HinhAnh { set; get; }
        public string ManNhiTrai_HinhAnh { set; get; }
        public string MuiTruoc_HinhAnh { set; get; }
        public string MuiSau_HinhAnh { set; get; }
        public string ThanhQuan_HinhAnh { set; get; }
        public string Hong_HinhAnh { set; get; }
        public string CoNghiengPhai_HinhAnh { set; get; }
        public string CoNghiengTrai_HinhAnh { set; get; }
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
