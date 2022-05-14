using EMR.KyDienTu;
using EMR_MAIN.DATABASE;
using PMS.Access;

namespace EMR_MAIN
{
    public class BenhAnMatChanThuong : BenhAnBase, IBase
    {
        public int IDMauPhieu { get; set; }=(int)DanhMucPhieu.BAMCT;
        public string TenMauPhieu { get; set; } = DanhMucPhieu.BAMCT.Description();
        public string ThiLucKhiVaoVien_KhongKinh_MP { get; set; }
        public string ThiLucKhiVaoVien_KhongKinh_MT { get; set; }
        public string ThiLucKhiVaoVien_CoKinh_MP { get; set; }
        public string ThiLucKhiVaoVien_CoKinh_MT { get; set; }
        public string NhanApVaoVien_MT { get; set; }
        public string NhanApVaoVien_MP { get; set; }
        public string ThiTruong_MP { get; set; }
        public string ThiTruong_MT { get; set; }
        public int MiMat_MP { get; set; }
        public bool SupMi_MP { get; set; }
        public string SupMi_MP_Text { get; set; }
        public int RachMi_MP { get; set; }
        public int RachMi_Khau_MP { get; set; }
        public int LeQuan_MP { get; set; }
        public int LeQuan_ID_MP { get; set; }
        public bool SeoMi_MP { get; set; }
        public string SeoMi_MP_Text { get; set; }
        public string CacTonThuongKhac_MiMat_MP { get; set; }
        public int KetMac_MP { get; set; }
        public bool XuatHuyet_MP { get; set; }
        public string XuatHuyet_MP_Text { get; set; }
        public bool RachKetMac_MP { get; set; }
        public string RachKetMac_MP_Text { get; set; }
        public bool ThieuMau_MP { get; set; }
        public string ThieuMau_MP_Text { get; set; }
        public string TonThuongKhac_KetMac_MP { get; set; }
        public string HinhVeMoTaTonThuongKVV_MP { get; set; }
        public int GiacMac_MP { get; set; }
        public bool GiacMac_Seo_MP { get; set; }
        public string GiacMac_Seo_MP_Text { get; set; }
        public bool GiacMac_DiVat_MP { get; set; }
        public string GiacMac_DiVat_MP_Text { get; set; }
        public int TuaSauGiacMac_MP { get; set; }
        public int TuaSauGiacMac_ID_MP { get; set; }
        public bool RachGiacMac_MP { get; set; }
        public string RachGiacMac_MP_Text { get; set; }
        public string RachGiacMac_MP_Text2 { get; set; }
        public int RachGiacMac_ID_MP { get; set; }
        public bool DaKhauGiacMac_MP { get; set; }
        public int DungGiaiPhauGiacMac_MP { get; set; }
        public string TonThuongKhac_GiacMac_MP { get; set; }
        public int CungMac_MP { get; set; }
        public bool RachCungMac_MP { get; set; }
        public string RachCungMac_MP_Text { get; set; }
        public string RachCungMac_MP_Text2 { get; set; }
        public int DaKhauCungMac_MP { get; set; }
        public bool KetToChucCungMac_MP { get; set; }
        public string TonThuongKhac_CungMac_MP { get; set; }
        public int TienPhong_MP { get; set; }
        public bool XuatTiet_TienPhong_MP { get; set; }
        public string XuatTiet_TienPhong_Text_MP { get; set; }
        public bool DiVat_TienPhong_MP { get; set; }
        public string DiVat_TienPhong_Text_MP { get; set; }
        public string TonThuongKhac_TienPhong_MP { get; set; }
        public int MongMat_MP { get; set; }
        public bool DutChanMongMat_MP { get; set; }
        public string DutChanMongMat_Text_MP { get; set; }
        public bool MatMongMat_MP { get; set; }
        public string MatMongMat_Text_MP { get; set; }
        public bool ThungMongMat_MP { get; set; }
        public string ThungMongMat_Text_MP { get; set; }
        public string KichThuoc_DongTu_MP { get; set; }
        public int PXDT_MP { get; set; }
        public int TronMeo_DongTu_MP { get; set; }
        public bool Dinh_DongTu_MP { get; set; }
        public string ViTri_DongTu_MP { get; set; }
        public bool GianLiet_DongTu_MP { get; set; }
        public string AnhDongTu_MP { get; set; }
        public bool KhongQuanSatDuoc_ADT_MP { get; set; }
        public int TheThuyTinh_MP { get; set; }
        public bool DiVat_TheThuyTinh_MP { get; set; }
        public bool SaLech_TheThuyTinh_MP { get; set; }
        public int SaLechID_TheThuyTinh_MP { get; set; }
        public bool ViemMu_TheThuyTinh_MP { get; set; }
        public bool DaDatIOL_TheThuyTinh_MP { get; set; }
        public string DaDatIOL_TheThuyTinh_Text_MP { get; set; }
        public string TonThuongKhac_TheThuyTinh_MP { get; set; }
        public bool Duc_DichKinh_MP { get; set; }
        public bool ViemMu_DichKinh_MP { get; set; }
        public bool XuatHuyet_DichKinh_MP { get; set; }
        public bool ToChucHoa_DichKinh_MP { get; set; }
        public bool Bong_DichKinh_MP { get; set; }
        public bool DiVat_DichKinh_MP { get; set; }
        public string TonThuongKhac_DichKinh_MP { get; set; }
        public string HeMach_DichKinh_MP { get; set; }
        public string DiaThi_DichKinh_MP { get; set; }
        public bool Phu_VongMac_MP { get; set; }
        public string Phu_VongMac_Text_MP { get; set; }
        public bool XuatHuyet_VongMac_MP { get; set; }
        public string XuatHuyet_VongMac_Text_MP { get; set; }
        public int Bong_VongMac_MP { get; set; }
        public string Bong_VongMac_Text_MP { get; set; }
        public int Rach_VongMac_MP { get; set; }
        public string Rach_VongMac_Text_MP { get; set; }
        public string ViTriRach_VongMac_Text_MP { get; set; }
        public string HinhThaiRach_VongMac_Text_MP { get; set; }
        public bool DiVat_VongMac_MP { get; set; }
        public string DiVat_VongMac_Text_MP { get; set; }
        public string DiVat_VongMac_Text2_MP { get; set; }
        public string TonThuongKhac_VongMac_MP { get; set; }
        public int HocMat_MP { get; set; }
        public string HocMat_Text_MP { get; set; }
        public bool DiVat_HocMat_MP { get; set; }
        public string DiVat_HocMat_Text_MP { get; set; }
        public int VanNhan_MP { get; set; }
        public string VanNhan_Text_MP { get; set; }
        public int NhanCau_MP { get; set; }
        public string NhanCau_Text_MP { get; set; }
        public int MiMat_MT { get; set; }
        public bool SupMi_MT { get; set; }
        public string SupMi_MT_Text { get; set; }
        public int RachMi_MT { get; set; }
        public int RachMi_Khau_MT { get; set; }
        public int LeQuan_MT { get; set; }
        public int LeQuan_ID_MT { get; set; }
        public bool SeoMi_MT { get; set; }
        public string SeoMi_MT_Text { get; set; }
        public string CacTonThuongKhac_MiMat_MT { get; set; }
        public int KetMac_MT { get; set; }
        public bool XuatHuyet_MT { get; set; }
        public string XuatHuyet_MT_Text { get; set; }
        public bool RachKetMac_MT { get; set; }
        public string RachKetMac_MT_Text { get; set; }
        public bool ThieuMau_MT { get; set; }
        public string ThieuMau_MT_Text { get; set; }
        public string TonThuongKhac_KetMac_MT { get; set; }
        public string HinhVeMoTaTonThuongKVV_MT { get; set; }
        public int GiacMac_MT { get; set; }
        public bool GiacMac_Seo_MT { get; set; }
        public string GiacMac_Seo_MT_Text { get; set; }
        public bool GiacMac_DiVat_MT { get; set; }
        public string GiacMac_DiVat_MT_Text { get; set; }
        public int TuaSauGiacMac_MT { get; set; }
        public int TuaSauGiacMac_ID_MT { get; set; }
        public bool RachGiacMac_MT { get; set; }
        public string RachGiacMac_MT_Text { get; set; }
        public string RachGiacMac_MT_Text2 { get; set; }
        public int RachGiacMac_ID_MT { get; set; }
        public bool DaKhauGiacMac_MT { get; set; }
        public int DungGiaiPhauGiacMac_MT { get; set; }
        public string TonThuongKhac_GiacMac_MT { get; set; }
        public int CungMac_MT { get; set; }
        public bool RachCungMac_MT { get; set; }
        public string RachCungMac_MT_Text { get; set; }
        public string RachCungMac_MT_Text2 { get; set; }
        public int DaKhauCungMac_MT { get; set; }
        public bool KetToChucCungMac_MT { get; set; }
        public string TonThuongKhac_CungMac_MT { get; set; }
        public int TienPhong_MT { get; set; }
        public bool XuatTiet_TienPhong_MT { get; set; }
        public string XuatTiet_TienPhong_Text_MT { get; set; }
        public bool DiVat_TienPhong_MT { get; set; }
        public string DiVat_TienPhong_Text_MT { get; set; }
        public string TonThuongKhac_TienPhong_MT { get; set; }
        public int MongMat_MT { get; set; }
        public bool DutChanMongMat_MT { get; set; }
        public string DutChanMongMat_Text_MT { get; set; }
        public bool MatMongMat_MT { get; set; }
        public string MatMongMat_Text_MT { get; set; }
        public bool ThungMongMat_MT { get; set; }
        public string ThungMongMat_Text_MT { get; set; }
        public string KichThuoc_DongTu_MT { get; set; }
        public int PXDT_MT { get; set; }
        public int TronMeo_DongTu_MT { get; set; }
        public bool Dinh_DongTu_MT { get; set; }
        public string ViTri_DongTu_MT { get; set; }
        public bool GianLiet_DongTu_MT { get; set; }
        public string AnhDongTu_MT { get; set; }
        public bool KhongQuanSatDuoc_ADT_MT { get; set; }
        public int TheThuyTinh_MT { get; set; }
        public bool DiVat_TheThuyTinh_MT { get; set; }
        public bool SaLech_TheThuyTinh_MT { get; set; }
        public int SaLechID_TheThuyTinh_MT { get; set; }
        public bool ViemMu_TheThuyTinh_MT { get; set; }
        public bool DaDatIOL_TheThuyTinh_MT { get; set; }
        public string DaDatIOL_TheThuyTinh_Text_MT { get; set; }
        public string TonThuongKhac_TheThuyTinh_MT { get; set; }
        public bool Duc_DichKinh_MT { get; set; }
        public bool ViemMu_DichKinh_MT { get; set; }
        public bool XuatHuyet_DichKinh_MT { get; set; }
        public bool ToChucHoa_DichKinh_MT { get; set; }
        public bool Bong_DichKinh_MT { get; set; }
        public bool DiVat_DichKinh_MT { get; set; }
        public string TonThuongKhac_DichKinh_MT { get; set; }
        public string HeMach_DichKinh_MT { get; set; }
        public string DiaThi_DichKinh_MT { get; set; }
        public bool Phu_VongMac_MT { get; set; }
        public string Phu_VongMac_Text_MT { get; set; }
        public bool XuatHuyet_VongMac_MT { get; set; }
        public string XuatHuyet_VongMac_Text_MT { get; set; }
        public int Bong_VongMac_MT { get; set; }
        public string Bong_VongMac_Text_MT { get; set; }
        public int Rach_VongMac_MT { get; set; }
        public string Rach_VongMac_Text_MT { get; set; }
        public string ViTriRach_VongMac_Text_MT { get; set; }
        public string HinhThaiRach_VongMac_Text_MT { get; set; }
        public bool DiVat_VongMac_MT { get; set; }
        public string DiVat_VongMac_Text_MT { get; set; }
        public string DiVat_VongMac_Text2_MT { get; set; }
        public string TonThuongKhac_VongMac_MT { get; set; }
        public int HocMat_MT { get; set; }
        public string HocMat_Text_MT { get; set; }
        public bool DiVat_HocMat_MT { get; set; }
        public string DiVat_HocMat_Text_MT { get; set; }
        public int VanNhan_MT { get; set; }
        public string VanNhan_Text_MT { get; set; }
        public int NhanCau_MT { get; set; }
        public string NhanCau_Text_MT { get; set; }
        public string HinhVe_VongMac_MP { get; set; }
        public string HinhVe_VongMac_MT { get; set; }
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
        public bool TuaMoi_MP { get; set; }
        public string TuaMoi_MP_Text { get; set; }
        public bool TuaMoi_MT { get; set; }
        public string TuaMoi_MT_Text { get; set; }
        public bool TuaCu_MP { get; set; }
        public string TuaCu_MP_Text { get; set; }
        public bool TuaCu_MT { get; set; }
        public string TuaCu_MT_Text { get; set; }

        public string TienPhongMP_Sau_Text { get; set; }
        public string TienPhongMP_Mu_Text { get; set; }
        public string TienPhongMP_XuatTiet_Text { get; set; }
        public string TienPhongMP_Tydall_Text { get; set; }

        public string TienPhongMT_Sau_Text { get; set; }
        public string TienPhongMT_Mu_Text { get; set; }
        public string TienPhongMT_XuatTiet_Text { get; set; }
        public string TienPhongMT_Tydall_Text { get; set; }

        public bool Trong_DichKinh_MP { get; set; }
        public string Duc_DichKinh_MP_Text { get; set; }
        public string XuatHuyet_DichKinh_MP_Text { get; set; }
        public bool Trong_DichKinh_MT { get; set; }
        public string Duc_DichKinh_MT_Text { get; set; }
        public string XuatHuyet_DichKinh_MT_Text { get; set; }

        public int VongMac_BenhLy_MP { get; set; }
        public int VongMac_BenhLy_MT { get; set; }

        public bool VoXuong_HocMat_MP { get; set; }
        public string VoXuong_HocMat_Text_MP { get; set; }
        public bool VoXuong_HocMat_MT { get; set; }
        public string VoXuong_HocMat_Text_MT { get; set; }
        public string ViTri_Khau_MP { get; set; }
        public string ViTri_Khau_MT { get; set; }
        public bool ThayBenhLy { get; set; }
        public bool ChuaThayBenhLy { get; set; }
    }
}
