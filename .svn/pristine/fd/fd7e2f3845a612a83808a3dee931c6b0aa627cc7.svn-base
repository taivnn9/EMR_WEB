using EMR.KyDienTu;
using EMR_MAIN.DATABASE;
using PMS.Access;

namespace EMR_MAIN
{
    public class BenhAnMatDayMat : BenhAnBase, IBase
    {
        public int IDMauPhieu { get; set; }=(int)DanhMucPhieu.BAMDM;
        public string TenMauPhieu { get; set; } = DanhMucPhieu.BAMDM.Description();
        public string ThiLucKhiVaoVien_KhongKinh_MP { get; set; }
        public string ThiLucKhiVaoVien_KhongKinh_MT { get; set; }
        public string ThiLucKhiVaoVien_CoKinh_MP { get; set; }
        public string ThiLucKhiVaoVien_CoKinh_MT { get; set; }
        public string NhanApVaoVien_MT { get; set; }
        public string NhanApVaoVien_MP { get; set; }
        public string ThiTruong_MP { get; set; }
        public string ThiTruong_MT { get; set; }
        public bool MiMat_MP { get; set; }
        public bool PhanUngTheMi_MP { get; set; }
        public string BenhLyKhac_MP { get; set; }
        public int KetMac_MP { get; set; }
        public bool XuatHuyet_MP { get; set; }
        public string XuatHuyet_MP_Text { get; set; }
        public bool SeoKetMac_MP { get; set; }
        public string SeoKetMac_MP_Text { get; set; }
        public string BenhLyKhac_KetMac_MP { get; set; }
        public bool GiacMac_Trong_MP { get; set; }
        public bool GiacMac_Phu_MP { get; set; }
        public bool GiacMac_Seo_MP { get; set; }
        public bool TuaSauGiacMac_MoiCu_MP { get; set; }
        public bool TuaSauGiacMac_MoCuu_MP { get; set; }
        public bool TuaSauGiacMac_SacTo_MP { get; set; }
        public string ViTriTua_MP { get; set; }
        public bool SeoGiacMac_MP { get; set; }
        public string BenhLyKhac_GiacMac_MP { get; set; }
        public bool CungMac_MP { get; set; }
        public string BenhLyKhac_CungMac_MP { get; set; }
        public bool TienPhong_SauSach_MP { get; set; }
        public bool TienPhong_XepTienPhong_MP { get; set; }
        public bool XuatHuyet_TienPhong_MP { get; set; }
        public string XuatHuyet_TienPhong_Text_MP { get; set; }
        public bool XuatTuyet_TienPhong_MP { get; set; }
        public string XuatTuyet_TienPhong_Text_MP { get; set; }
        public bool Tyndall_TienPhong_MP { get; set; }
        public string Tyndall_TienPhong_Text_MP { get; set; }
        public int GocTienPhong_MP { get; set; }
        public string TonThuongKhac_TienPhong_MP { get; set; }
        public bool MongMat_MP { get; set; }
        public bool TanMachMongMat_MP { get; set; }
        public string TanMachMongMat_Text_MP { get; set; }
        public bool HatKoeppiMongMat_MP { get; set; }
        public string HatKoeppiMongMat_Text_MP { get; set; }
        public bool HatBussacaMongMat_MP { get; set; }
        public string HatBussacaMongMat_Text_MP { get; set; }
        public string KichThuoc_DongTu_MP { get; set; }
        public string AnhDongTu_DongTu_MP { get; set; }
        public bool TronMeo_DongTu_MP { get; set; }
        public bool Dinh_DongTu_MP { get; set; }
        public string ViTri_DongTu_MP { get; set; }
        public bool PXDT_MP { get; set; }
        public bool GianLiet_DongTu_MP { get; set; }
        public string BenhLyKhac_DongTu_MP { get; set; }
        public int TheThuyTinh_MP { get; set; }
        public bool DiVat_TheThuyTinh_MP { get; set; }
        public bool SaLech_TheThuyTinh_MP { get; set; }
        public bool SaLechID_TheThuyTinh_MP { get; set; }
        public bool DinhSacTo_TheThuyTinh_MP { get; set; }
        public bool ViemMu_TheThuyTinh_MP { get; set; }
        public string TonThuongKhac_TheThuyTinh_MP { get; set; }
        public bool DichKinh_MP { get; set; }
        public string DichKinh_MP_Text { get; set; }
        public bool ViemMu_DichKinh_MP { get; set; }
        public string ViemMu_DichKinh_MP_Text { get; set; }
        public bool XuatHuyet_DichKinh_MP { get; set; }
        public bool ToChucHoa_DichKinh_MP { get; set; }
        public bool Bong_DichKinh_MP { get; set; }
        public string TonThuongKhac_DichKinh_MP { get; set; }
        public bool HeMach_VongMac_MP { get; set; }
        public int TacDM_VongMac_MP { get; set; }
        public int TacTM_VongMac_MP { get; set; }
        public bool TacTM_Phu_VongMac_MP { get; set; }
        public bool TacTM_ThieuMau_VongMac_MP { get; set; }
        public bool TacTM_HonHop_VongMac_MP { get; set; }
        public bool ViemMaoMach_VongMac_MP { get; set; }
        public bool TanMach_VongMac_MP { get; set; }
        public int TanMachHacMac_MP { get; set; } //20210803 Tunght Edit
        public bool DiaThi_VongMac_MP { get; set; }
        public int DiaThiID_VongMac_MP { get; set; }
        public bool TanMachGai_VongMac_MP { get; set; }
        public int TanMachGaiID_VongMac_MP { get; set; }
        public bool HoangDiem_VongMac_MP { get; set; }
        public int HoangDiem_Phu_VongMac_MP { get; set; } //20210803 Tunght Edit
        public int HoangDiem_Lo_VongMac_MP { get; set; }//20210803 Tunght Edit
        public string HoangDiem_Lo_Do_VongMac_MP { get; set; }
        public bool HoangDiem_Seo_VongMac_MP { get; set; }
        public int ThoaiHoa_VongMac_MP { get; set; }//20210803 Tunght Edit
        public string ThoaiHoa_VongMac_MP_Text { get; set; }
        public int XuatHuyet_VongMac_MP { get; set; }
        public int XuatTiet_VongMac_MP { get; set; }//20210803 Tunght Edit
        public int BongThanhDich_VongMac_MP { get; set; }//20210803 Tunght Edit
        public bool OViemHacHac_MP { get; set; }
        public string OViemHacHac_MPText1 { get; set; }
        public string OViemHacHac_MPText2 { get; set; }
        public bool BongVongMac_MP { get; set; }
        public string BongVongMac_MP_Text { get; set; }
        public bool RachVongMac_MP { get; set; }
        public string RachVongMac_MP_Text { get; set; }
        public string RachVongMac_MP_Text1 { get; set; }
        public string RachVongMac_MP_Text2 { get; set; }
        public string RachVongMac_MP_Text3 { get; set; }
        public string TonThuongPhoiHop_MP { get; set; }
        public string BenhLyKhac_VongMac_MP { get; set; }
        public bool HocMat_MP { get; set; }
        public string HocMat_Text_MP { get; set; }
        public bool VanNhan_MP { get; set; }
        public string VanNhan_Text_MP { get; set; }
        public bool MiMat_MT { get; set; }
        public bool PhanUngTheMi_MT { get; set; }
        public string BenhLyKhac_MT { get; set; }
        public int KetMac_MT { get; set; }
        public bool XuatHuyet_MT { get; set; }
        public string XuatHuyet_MT_Text { get; set; }
        public bool SeoKetMac_MT { get; set; }
        public string SeoKetMac_MT_Text { get; set; }
        public string BenhLyKhac_KetMac_MT { get; set; }
        public bool GiacMac_Trong_MT { get; set; }
        public bool GiacMac_Phu_MT { get; set; }
        public bool GiacMac_Seo_MT { get; set; }
        public bool TuaSauGiacMac_MoiCu_MT { get; set; }
        public bool TuaSauGiacMac_MoCuu_MT { get; set; }
        public bool TuaSauGiacMac_SacTo_MT { get; set; }
        public string ViTriTua_MT { get; set; }
        public bool SeoGiacMac_MT { get; set; }
        public string BenhLyKhac_GiacMac_MT { get; set; }
        public bool CungMac_MT { get; set; }
        public string BenhLyKhac_CungMac_MT { get; set; }
        public bool TienPhong_SauSach_MT { get; set; }
        public bool TienPhong_XepTienPhong_MT { get; set; }
        public bool XuatHuyet_TienPhong_MT { get; set; }
        public string XuatHuyet_TienPhong_Text_MT { get; set; }
        public bool XuatTuyet_TienPhong_MT { get; set; }
        public string XuatTuyet_TienPhong_Text_MT { get; set; }
        public bool Tyndall_TienPhong_MT { get; set; }
        public string Tyndall_TienPhong_Text_MT { get; set; }
        public int GocTienPhong_MT { get; set; }
        public string TonThuongKhac_TienPhong_MT { get; set; }
        public bool MongMat_MT { get; set; }
        public bool TanMachMongMat_MT { get; set; }
        public string TanMachMongMat_Text_MT { get; set; }
        public bool HatKoeppiMongMat_MT { get; set; }
        public string HatKoeppiMongMat_Text_MT { get; set; }
        public bool HatBussacaMongMat_MT { get; set; }
        public string HatBussacaMongMat_Text_MT { get; set; }
        public string KichThuoc_DongTu_MT { get; set; }
        public string AnhDongTu_DongTu_MT { get; set; }
        public bool TronMeo_DongTu_MT { get; set; }
        public bool Dinh_DongTu_MT { get; set; }
        public string ViTri_DongTu_MT { get; set; }
        public bool PXDT_MT { get; set; }
        public bool GianLiet_DongTu_MT { get; set; }
        public string BenhLyKhac_DongTu_MT { get; set; }
        public int TheThuyTinh_MT { get; set; }
        public bool DiVat_TheThuyTinh_MT { get; set; }
        public bool SaLech_TheThuyTinh_MT { get; set; }
        public bool SaLechID_TheThuyTinh_MT { get; set; }
        public bool DinhSacTo_TheThuyTinh_MT { get; set; }
        public bool ViemMu_TheThuyTinh_MT { get; set; }
        public string TonThuongKhac_TheThuyTinh_MT { get; set; }
        public bool DichKinh_MT { get; set; }
        public string DichKinh_MT_Text { get; set; }
        public bool ViemMu_DichKinh_MT { get; set; }
        public string ViemMu_DichKinh_MT_Text { get; set; }
        public bool XuatHuyet_DichKinh_MT { get; set; }
        public bool ToChucHoa_DichKinh_MT { get; set; }
        public bool Bong_DichKinh_MT { get; set; }
        public string TonThuongKhac_DichKinh_MT { get; set; }
        public bool HeMach_VongMac_MT { get; set; }
        public int TacDM_VongMac_MT { get; set; }
        public int TacTM_VongMac_MT { get; set; }
        public bool TacTM_Phu_VongMac_MT { get; set; }
        public bool TacTM_ThieuMau_VongMac_MT { get; set; }
        public bool TacTM_HonHop_VongMac_MT { get; set; }
        public bool ViemMaoMach_VongMac_MT { get; set; }
        public bool TanMach_VongMac_MT { get; set; }
        public int TanMachHacMac_MT { get; set; } //20210803 Tunght Edit
        public bool DiaThi_VongMac_MT { get; set; }
        public int DiaThiID_VongMac_MT { get; set; }
        public bool TanMachGai_VongMac_MT { get; set; }
        public int TanMachGaiID_VongMac_MT { get; set; }
        public bool HoangDiem_VongMac_MT { get; set; }
        public int HoangDiem_Phu_VongMac_MT { get; set; } //20210803 Tunght Edit
        public int HoangDiem_Lo_VongMac_MT { get; set; }//20210803 Tunght Edit
        public string HoangDiem_Lo_Do_VongMac_MT { get; set; }
        public bool HoangDiem_Seo_VongMac_MT { get; set; }
        public int ThoaiHoa_VongMac_MT { get; set; }//20210803 Tunght Edit
        public string ThoaiHoa_VongMac_MT_Text { get; set; }
        public int XuatHuyet_VongMac_MT { get; set; }
        public int XuatTiet_VongMac_MT { get; set; }//20210803 Tunght Edit
        public int BongThanhDich_VongMac_MT { get; set; }//20210803 Tunght Edit
        public bool OViemHacHac_MT { get; set; }
        public bool OViemHacHac_MTText1 { get; set; }
        public bool OViemHacHac_MTText2 { get; set; }
        public bool BongVongMac_MT { get; set; }
        public string BongVongMac_MT_Text { get; set; }
        public bool RachVongMac_MT { get; set; }
        public string RachVongMac_MT_Text { get; set; }
        public string RachVongMac_MT_Text1 { get; set; }
        public string RachVongMac_MT_Text2 { get; set; }
        public string RachVongMac_MT_Text3 { get; set; }
        public string TonThuongPhoiHop_MT { get; set; }
        public string BenhLyKhac_VongMac_MT { get; set; }
        public bool HocMat_MT { get; set; }
        public string HocMat_Text_MT { get; set; }
        public bool VanNhan_MT { get; set; }
        public string VanNhan_Text_MT { get; set; }
        public string ChuaCoBieuHienBenhLy { get; set; }
        public string BenhLy { get; set; }
        public string ChanDoanBenhChinh_LamSang { get; set; }
        public string ChanDoanBenhChinh_NguyenNhan { get; set; }
        public string QuaTrinhDieuTri_NoiKhoa { get; set; }
        public bool PhauThuat { get; set; }
        public bool ThuThuat { get; set; }
        public string ThiLucRaVienKhongKinhMPTongKet { get; set; }
        public string ThiLucRaVienKhongKinhMTTongKet { get; set; }
        public string ThiLucRaVienCoKinhMPTongKet { get; set; }
        public string ThiLucRaVienCoKinhMTTongKet { get; set; }
        public string NhanApRaVienMPTongKet { get; set; }
        public string NhanApRaVienMTTongKet { get; set; }
        public string HuongDieuTriTiep { get; set; }
        public int iMiMat_MP { get; set; }
        public int iMiMat_MT { get; set; }
        public int iTuaSauGiacMac_MoiCu_MP { get; set; }
        public int iTuaSauGiacMac_MoiCu_MT { get; set; }
        public int iCungMac_MP { get; set; }
        public int iCungMac_MT { get; set; }
        public int iTronMeo_DongTu_MP { get; set; }
        public int iTronMeo_DongTu_MT { get; set; }
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
        public bool ThayBenhLy {get; set;}
        public bool ChuaThayBenhLy { get; set; }
        public int VongMac_BenhLy_MP { get; set; }
        public string VongMac_BenhLy_MP_Text { get; set; }
        public int VongMac_BenhLy_MT { get; set; }
        public string VongMac_BenhLy_MT_Text { get; set; }
    }
}
