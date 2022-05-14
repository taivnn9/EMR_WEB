using EMR.KyDienTu;
using EMR_MAIN.DATABASE;
using PMS.Access;

namespace EMR_MAIN
{
    public class TienSuSanPhuKhoa
    {
        public int BatDauThayKinhNam { get; set; }
        public int TuoiThayKinh { get; set; }
        public string TinhChatKinhNguyet { get; set; }
        public int ChuKy { get; set; }
        public int SoNgayThayKinh { get; set; }
        public string LuongKinh { get; set; }
        public int KinhLanCuoiNgay { get; set; }
        public bool DauBung { get; set; }
        public int LayChongNam { get; set; }
        public int TuoiLayChong { get; set; }
        public int HetKinhNam { get; set; }
        public int TuoiHetKinh { get; set; }
        public bool Truoc { get; set; }
        public bool Sau { get; set; }
        public bool Trong { get; set; }
        public string NhungBenhPhuKhoaDaDieuTri { get; set; }
    }
    public class BenhAnPhuKhoa : BenhAnBase, IBase
    {
        public int IDMauPhieu { get; set; } = (int)DanhMucPhieu.BAPK;
        public string TenMauPhieu { get; set; } = DanhMucPhieu.BAPK.Description();
        public TienSuSanPhuKhoa TienSuSanPhuKhoa { get; set; }
        public int TienThaiPara { get; set; }
        public string ChiSoPara1 { get; set; }
        public string ChiSoPara2 { get; set; }
        public string ChiSoPara3 { get; set; }
        public string ChiSoPara4 { get; set; }
        public string Hach { get; set; }
        public string Vu { get; set; }
        public string CacDauHieuSinhDucThuPhat { set; get; }
        public string MoiLon { set; get; }
        public string MoiBe { set; get; }
        public string AmVat { set; get; }
        public string AmHo { set; get; }
        public string MangTrinh { set; get; }
        public string TangSinhMon { set; get; }
        public string AmDao { set; get; }
        public string CoTuCung { set; get; }
        public string ThanTuCung { set; get; }
        public string PhanPhu { set; get; }
        public string CacTuiCung { set; get; }
        public bool PhauThuat { set; get; }
        public bool ThuThuat { set; get; }
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
