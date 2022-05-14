using EMR.KyDienTu;
using EMR_MAIN.DATABASE;
using PMS.Access;

namespace EMR_MAIN
{
    public class BenhAnRangHamMat : BenhAnBase, IBase
    {
        public int IDMauPhieu { get; set; } = (int)DanhMucPhieu.BARHM;
        public string TenMauPhieu { get; set; } = DanhMucPhieu.BARHM.Description();
        public bool PhauThuat { set; get; }
        public bool ThuThuat { set; get; }
        public string Phai_HinhVe { set; get; }
        public string Thang_HinhVe { set; get; }
        public string Trai_HinhVe { set; get; }
        public string HamTrenVaHong_HinhVe { set; get; }
        public string HamDuoi_HinhVe { set; get; }
        public string PhanLoai_HinhVe { set; get; }
        public string RangHamMatDinhDuong { set; get; }
        public string DinhDuong { set; get; }
        public string DaVaMoDuoiDa { set; get; }
        public string BenhChuyenKhoa { set; get; }
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
