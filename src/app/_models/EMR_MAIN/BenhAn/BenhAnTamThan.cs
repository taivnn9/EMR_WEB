using EMR.KyDienTu;
using EMR_MAIN.DATABASE;
using PMS.Access;

namespace EMR_MAIN
{
    public class BenhAnTamThan : BenhAnBase, IBase
    {
        public int IDMauPhieu { get; set; } = (int)DanhMucPhieu.BATT;
        public string TenMauPhieu { get; set; } = DanhMucPhieu.BATT.Description();
        public string DayThanKinhSoNao { set; get; }
        public string DayMat { set; get; }
        public string VanDong { set; get; }
        public string TruongLucCo { set; get; }
        public string CamGiac { set; get; }
        public string PhanXa { set; get; }
        public string BieuHienChung { set; get; }
        public string KhongGian { set; get; }
        public string ThoiGian { set; get; }
        public string BanThan { set; get; }
        public string TinhCamCamXuc { set; get; }
        public string TriGiac { set; get; }
        public string HinhThuc { set; get; }
        public string NoiDung { set; get; }
        public string HoatDongCoYChi { set; get; }
        public string HoatDongBanNang{ set; get; }
        public string NhoMayMoc { set; get; }
        public string NhoThongHieu { set; get; }
        public string KhaNangPhanTich { set; get; }
        public string KhaNangTongHop { set; get; }
        public string ChuY { set; get; }
        public string GiaiPhauBenh { set; get; }
        public int GiaiPhauBenhID { set; get; }
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
