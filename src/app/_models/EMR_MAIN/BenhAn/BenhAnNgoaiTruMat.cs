using EMR.KyDienTu;
using PMS.Access;

namespace EMR_MAIN.DATABASE.BenhAn
{
    public class BenhAnNgoaiTruMat : BenhAnBase, IBase
    {
        public int IDMauPhieu { get; set; } = (int)DanhMucPhieu.BANgTruMat;
        public string TenMauPhieu { get; set; } = DanhMucPhieu.BANgTruMat.Description();
        public string BenhChuyenKhoa { get; set; }
        public string ThiLucKhiVaoVien_KhongKinh_MP { get; set; }
        public string ThiLucKhiVaoVien_KhongKinh_MT { get; set; }
        public string ThiLucKhiVaoVien_CoKinh_MP { get; set; }
        public string ThiLucKhiVaoVien_CoKinh_MT { get; set; }
        public string NhanApVaoVien_MT { get; set; }
        public string NhanApVaoVien_MP { get; set; }
        public string ThiTruong_MP { get; set; }
        public string ThiTruong_MT { get; set; }
        public string LeDao_MP { get; set; }
        public string LeDao_MT { get; set; }
        public string MiMat_MP { get; set; }
        public string MiMat_MT { get; set; }
        public string KetMac_MP { get; set; }
        public string KetMac_MT { get; set; }
        public string TinhHinhMatHot_MP { get; set; }
        public string TinhHinhMatHot_MT { get; set; }
        public string GiacMac_MP { get; set; }
        public string GiacMac_MT { get; set; }
        public string CungMac_MT { get; set; }
        public string CungMac_MP { get; set; }
        public string TienPhong_MP { get; set; }
        public string TienPhong_MT { get; set; }
        public string MongMat_MT { get; set; }
        public string MongMat_MP { get; set; }
        public string DongTuPhanXa_MP { get; set; }
        public string DongTuPhanXa_MT { get; set; }
        public string ThuyTinhThe_MT { get; set; }
        public string ThuyTinhThe_MP { get; set; }
        public string ThuyTinhDich_MT { get; set; }
        public string ThuyTinhDich_MP { get; set; }
        public string SoiAnhDongTu_MP { get; set; }
        public string SoiAnhDongTu_MT { get; set; }
        public string TinhHinhNhanCau_MT { get; set; }
        public string TinhHinhNhanCau_MP { get; set; }
        public string HocMat_MP { get; set; }
        public string HocMat_MT { get; set; }
        public string DayMat_MT { get; set; }
        public string DayMat_MP { get; set; }
        public string NoiTiet { get; set; }
        public string ThiLucKhiRaVien_KhongKinh_MP { get; set; }
        public string ThiLucKhiRaVien_KhongKinh_MT { get; set; }
        public string ThiLucKhiRaVien_CoKinh_MP { get; set; }
        public string ThiLucKhiRaVien_CoKinh_MT { get; set; }
        public string NhanApRaVien_MT { get; set; }
        public string NhanApRaVien_MP { get; set; }
        public bool PhauThuat { set; get; }
        public bool ThuThuat { get; set; }
        public string ChanDoanBenhChinh_LamSang { get; set; }
        public string ChanDoanBenhChinh_NguyenNhan { get; set; }
        public string QuaTrinhDieuTri_NoiKhoa { get; set; }
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
