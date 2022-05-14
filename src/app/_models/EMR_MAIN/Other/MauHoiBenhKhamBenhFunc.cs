
using EMR_MAIN.DATABASE.BenhAn;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using EMR.KyDienTu;

namespace EMR_MAIN.DATABASE.Other
{
    public class MauHoiBenhKhamBenh
    {
        [MoTaDuLieu("Mã định danh")]
		public int ID { get; set; }
        public string TenMau { get; set; }
        public LoaiBenhAnEMR LoaiBenhAn { get; set; }
        public string NoiDungMau { get; set; }
        public int LoaiMau { get; set; }
        public int LoaiBA { get; set; }
        [MoTaDuLieu("Mã khoa")]
		public string MaKhoa { get; set; }
        [MoTaDuLieu("Tên khoa")]
		public string TenKhoa { get; set; }
    }
    //bong, Dalieu, HuyetHocTruyenMau, Mat,NgoaiKhoa,NgoaiTru,PhucHoiChucNangYHCT,LuuCapCuu
    //NgoaiTruRangHamMat,NgoaiTruTaiMuiHong,NoiKhoa,RangHamMat, TaiMuiHong, UngBuou, XaPhuong
    public class BABase_HoiBenh
    {
        public string LyDoVaoVien { get; set; }
        public string QuaTrinhBenhLy { get; set; }
        public string TienSuBenhBanThan { get; set; }
        public DacDiemLienQuanBenh DacDiemLienQuanBenh { get; set; }
        public string TienSuBenhGiaDinh { get; set; }
    }
    public class BACMU_HoiBenh
    {
        public string NoiGioiThieu { get; set; }
        public bool TuDen { get; set; }
        public string LyDoKhamBenh { get; set; }
        public string TrieuChungKhac { get; set; }
        public bool KhongHut { get; set; }
        public bool hutNhungDaCai { get; set; }
        public string CaiBaoLau { get; set; }
        public int? SoBaoDaHutNam { get; set; }
        public bool DangHut { get; set; }
        public int? SoBaoHutNam { get; set; }
        public string TienSuBenhh { get; set; }
        public int DoCNHH { get; set; }
        public string BenhKhac { get; set; }
        public string TienSuGiaDinh { get; set; }
        public string TienSuBanThan { get; set; }
        public int? TienSuSoLanVaoBV { get; set; }
        public string TienSuBV { get; set; }
        public bool LaoPhoi { get; set; }
        public int CoPhaiThuMay { get; set; }
        public int TrieuChung { get; set; }
        public double? DiemACT { get; set; }
        public int KS { get; set; }
        public int YeuToLienQuan { get; set; }
        public string YeuToNao { get; set; }
        public string YeuToKhac { get; set; }
        public int BenhCoGiam { get; set; }
        public double? FEV1_Nhe { get; set; }
        public double? FEV1_TrungBinh { get; set; }
        public double? FEV1_Nang { get; set; }
        public double? FEV1_RatNang { get; set; }
        public string ThuocDaSuDung { get; set; }
        public string Thuoc_Khac { get; set; }
        public string DangThuoc { get; set; }
        public string CacThuocDuPhong { get; set; }
        public string CacThuocDuPhong_Khac { get; set; }
        public int KyNang { get; set; }
        public int TuanThu { get; set; }
        public double? Mach { get; set; }
        public double? NhietDo { get; set; }
        [MoTaDuLieu("Huyết áp")]
		public string HuyetAp { get; set; }
        public double? NhipTho { get; set; }
        public string HoHapKhamThucThe { get; set; }
        public string HoHap_Khac { get; set; }
        public string TimMach { get; set; }
        public string CacBoPhanKhac { get; set; }
    }
    public class BAMatBanPhanTruoc_HoiBenh : BABase_HoiBenh
    {
        public string ThoiGianXuatHienBenh { get; set; }
        public string NguyenNhan_BenhSu { get; set; }
        public string CacPhuongPhapDaDieuTri_BenhSu { get; set; }
        public string TienSuBenhBanThan_Mat { get; set; }
        public string TienSuBenhGiaDinh_Mat { get; set; }
        public string KhongKinh_ThiLuc_MP { get; set; }
        public string QuaLo_ThiLuc_MP { get; set; }
        public string CoChinhKinh_ThiLuc_MP { get; set; }
        public string NhinGan_ThiLuc_MP { get; set; }
        public string NhanAp_MP { get; set; }
        public string LacVaVanNhan_MP { get; set; }
        public bool ThoatNuocTot_MP { get; set; }
        public bool TraoLeQuanDoiDien_MP { get; set; }
        public bool TraoLeQuanTaiCho_MP { get; set; }
        public string ThoatNuocTot_MP_Text { get; set; }
        public string TraoLeQuanDoiDien_MP_Text { get; set; }
        public string TraoLeQuanTaiCho_MP_Text { get; set; }
        public string MiMat_P { get; set; }
        public string Khac_MiMat_MP { get; set; }
        public bool UMi_MP { get; set; }
        public string TinhChatU_UMi_MP { get; set; }
        public string ViTri_UMi_MP { get; set; }
        public string KichThuoc_UMi_MP { get; set; }
        public int iQuam_MiMat_MP { get; set; }
        public bool Quam_MiMat_MP { get; set; }
        public int MiTren_MiMat_MP { get; set; }
        public int MiDuoi_MiMat_MP { get; set; }
        public bool HoMi_MiMat_MP { get; set; }
        public bool TreMi_MiMat_MP { get; set; }
        public int KhuyetMi_MiMat_MP { get; set; }
        public int TuyetBoMi_MiMat_MP { get; set; }
        public bool ViemBoMi_MiMat_MP { get; set; }
        public string TonThuongKhac_MiMat_MP { get; set; }
        public int CuongTu_KetMac_MP { get; set; }
        public bool PhuNe_KetMac_MP { get; set; }
        public bool XuatHuyet_KetMac_MP { get; set; }
        public bool SungHoa_KetMac_MP { get; set; }
        public bool Nhu_KetMac_MP { get; set; }
        public bool Hot_KetMac_MP { get; set; }
        public bool Seo_KetMac_MP { get; set; }
        public bool TietToMu_KetMac_MP { get; set; }
        public bool TietToTrong_KetMac_MP { get; set; }
        public bool GiaMac_KetMac_MP { get; set; }
        public bool BatMauFluor_KetMac_MP { get; set; }
        public string TinhChat_UKetMac_MP { get; set; }
        public string ViTri_UKetMac_MP { get; set; }
        public string KichThuoc_UKetMac_MP { get; set; }
        public int CungDo_KetMac_MP { get; set; }
        public int ChieuCaoCuaCauDinh_KetMac_MP { get; set; }
        public int DoRongCuaCauDinh_KetMac_MP { get; set; }
        public string TonThuongKhac_KetMac_MP { get; set; }
        public int iQuam_MiMat_MT { get; set; }
        public string KhongKinh_ThiLuc_MT { get; set; }
        public string QuaLo_ThiLuc_MT { get; set; }
        public string CoChinhKinh_ThiLuc_MT { get; set; }
        public string NhinGan_ThiLuc_MT { get; set; }
        public string NhanAp_MT { get; set; }
        public string LacVaVanNhan_MT { get; set; }
        public bool ThoatNuocTot_MT { get; set; }
        public bool TraoLeQuanDoiDien_MT { get; set; }
        public bool TraoLeQuanTaiCho_MT { get; set; }
        public int MiMat_MT { get; set; }
        public string Khac_MiMat_MT { get; set; }
        public bool UMi_MT { get; set; }
        public string ThoatNuocTot_MT_Text { get; set; }
        public string TraoLeQuanDoiDien_MT_Text { get; set; }
        public string TraoLeQuanTaiCho_MT_Text { get; set; }
        public string MiMat_T { get; set; }
        public string TinhChatU_UMi_MT { get; set; }
        public string ViTri_UMi_MT { get; set; }
        public string KichThuoc_UMi_MT { get; set; }
        public bool Quam_MiMat_MT { get; set; }
        public int MiTren_MiMat_MT { get; set; }
        public int MiDuoi_MiMat_MT { get; set; }
        public bool HoMi_MiMat_MT { get; set; }
        public bool TreMi_MiMat_MT { get; set; }
        public int KhuyetMi_MiMat_MT { get; set; }
        public int TuyetBoMi_MiMat_MT { get; set; }
        public bool ViemBoMi_MiMat_MT { get; set; }
        public string TonThuongKhac_MiMat_MT { get; set; }
        public int CuongTu_KetMac_MT { get; set; }
        public bool PhuNe_KetMac_MT { get; set; }
        public bool XuatHuyet_KetMac_MT { get; set; }
        public bool SungHoa_KetMac_MT { get; set; }
        public bool Nhu_KetMac_MT { get; set; }
        public bool Hot_KetMac_MT { get; set; }
        public bool Seo_KetMac_MT { get; set; }
        public bool TietToMu_KetMac_MT { get; set; }
        public bool TietToTrong_KetMac_MT { get; set; }
        public bool GiaMac_KetMac_MT { get; set; }
        public bool BatMauFluor_KetMac_MT { get; set; }
        public string TinhChat_UKetMac_MT { get; set; }
        public string ViTri_UKetMac_MT { get; set; }
        public string KichThuoc_UKetMac_MT { get; set; }
        public int CungDo_KetMac_MT { get; set; }
        public int ChieuCaoCuaCauDinh_KetMac_MT { get; set; }
        public int DoRongCuaCauDinh_KetMac_MT { get; set; }
        public string TonThuongKhac_KetMac_MT { get; set; }
        public int KichThuoc_GiacMac_MP { get; set; }
        public int HinhDang_GiacMac_MP { get; set; }
        public bool BieuMo_GiacMac_MP { get; set; }
        public int PhuBongBieuMo_GiacMac_MP { get; set; }
        public int MatBieuMo_GiacMac_MP { get; set; }
        public int MatBieuMoKhoangCach_MP { get; set; }
        public int BoTonThuong_GM_MP { get; set; }
        public bool ThoaiThoaDaiBang_MP { get; set; }
        public bool LangDongThuoc_MP { get; set; }
        public string TonThuongKhac_BieuMo_GM_MP { get; set; }
        public int Phu_NhuMo_GiacMac_MP { get; set; }
        public int ThamLau_NhuMo_GiacMac_MP { get; set; }
        public int ThamLau_Vtri_NhuMo_GiacMac_MP { get; set; }
        public int TieuMong_NhuMo_GiacMac_MP { get; set; }
        public int TieuMong_Vtri_NhuMo_GiacMac_MP { get; set; }
        public string TonThuongKhac_NhuMo_GiacMac_MP { get; set; }
        public int NepGap_NoiMo_GiacMac_MP { get; set; }
        public bool TuaSacToMacSauGM_MP { get; set; }
        public bool MuMatSau_NoiMo_MP { get; set; }
        public bool XuatTietMatSau_NoiMo_MP { get; set; }
        public bool Guttata_NoiMo_MP { get; set; }
        public bool RanMangDescemet_NoiMo_MP { get; set; }
        public bool CuonDescemet_NoiMo_MP { get; set; }
        public string TonThuongKhac_NoiMo_MP { get; set; }
        public bool DoaThung_GiacMac_MP { get; set; }
        public bool KetMongMat_GiacMac_MP { get; set; }
        public int ThungGiacMac_MP { get; set; }
        public bool Seidel_MP { get; set; }
        public string DuongKinhThungGiacMac_MP { get; set; }
        public bool ThungBit_GM_MP { get; set; }
        public int CamGiacGiacMac_MP { get; set; }
        public int TanMach_GiacMac_MP { get; set; }
        public int MucDo_TanMach_GiacMac_MP { get; set; }
        public bool SuyTeBaoNguon_MP { get; set; }
        public bool ThoaiHoaGia_MP { get; set; }
        public bool LangDongCanXi_MP { get; set; }
        public string BatThuongKhac_GiacMac_MP { get; set; }
        public int Viem_CungMac_MP { get; set; }
        public bool Viem_NongSau_CungMac_MP { get; set; }
        public bool ViemThuongCungMac_MP { get; set; }
        public int GianLoi_TieuMong_HoaiTu_MP { get; set; }
        public string ChiTietKhac_CungMac_MP { get; set; }
        public int TienPhong_MP { get; set; }
        public string Mu_TienPhong_MP { get; set; }
        public bool Tydal_MP { get; set; }
        public bool MangXuatTiet_MP { get; set; }
        public string Mau_TienPhong_MP { get; set; }
        public string TonThuongKhac_TienPhong_MP { get; set; }
        public bool NauXop_MP { get; set; }
        public bool XoTeo_MP { get; set; }
        public bool CuongTu_MP { get; set; }
        public bool TanMach_MP { get; set; }
        public bool Phoi_MP { get; set; }
        public bool Ket_MP { get; set; }
        public string DuongKinh_DongTu_MP { get; set; }
        public int DongTuTronMeoDinh_MP { get; set; }
        public string ViTriDinh_DongTu_MP { get; set; }
        public int PhanXaDongTu_MP { get; set; }
        public string TonThuongKhac_DongTu_MP { get; set; }
        public bool ThuyTinhThe_MP { get; set; }
        public string HinhThaiDuc_ThuyTinhthe_MP { get; set; }
        public int IOL_CanLechDuc_MP { get; set; }
        public bool IOL_TrongTPHP_MP { get; set; }
        public string TonThuongKhac_ThuyTinhthe_MP { get; set; }
        public int AnhDongTu_MP { get; set; }
        public int DichKinh_MP { get; set; }
        public string TonThuongKhac_DichKinh_MP { get; set; }
        public int DayMat_MP { get; set; }
        public string CD_DayMat_MP { get; set; }
        public bool PhuGai_MP { get; set; }
        public bool BacMauGaiThi_MP { get; set; }
        public string VongMac_DayMat_MP { get; set; }
        public string HeMachMau_DayMat_MP { get; set; }
        public string TonThuongKhac_DayMat_MP { get; set; }
        public int KichThuoc_GiacMac_MT { get; set; }
        public int HinhDang_GiacMac_MT { get; set; }
        public bool BieuMo_GiacMac_MT { get; set; }
        public int PhuBongBieuMo_GiacMac_MT { get; set; }
        public int MatBieuMo_GiacMac_MT { get; set; }
        public int MatBieuMoKhoangCach_MT { get; set; }
        public int BoTonThuong_GM_MT { get; set; }
        public bool ThoaiThoaDaiBang_MT { get; set; }
        public bool LangDongThuoc_MT { get; set; }
        public string TonThuongKhac_BieuMo_GM_MT_TXT { get; set; }
        public int Phu_NhuMo_GiacMac_MT { get; set; }
        public int ThamLau_NhuMo_GiacMac_MT { get; set; }
        public int ThamLau_Vtri_NhuMo_GiacMac_MT { get; set; }
        public int TieuMong_NhuMo_GiacMac_MT { get; set; }
        public int TieuMong_Vtri_NhuMo_GiacMac_MT { get; set; }
        public string TonThuongKhac_NhuMo_GiacMac_MT { get; set; }
        public int NepGap_NoiMo_GiacMac_MT { get; set; }
        public bool TuaSacToMacSauGM_MT { get; set; }
        public bool MuMatSau_NoiMo_MT { get; set; }
        public bool XuatTietMatSau_NoiMo_MT { get; set; }
        public bool Guttata_NoiMo_MT { get; set; }
        public bool RanMangDescemet_NoiMo_MT { get; set; }
        public bool CuonDescemet_NoiMo_MT { get; set; }
        public string TonThuongKhac_NoiMo_MT { get; set; }
        public bool DoaThung_GiacMac_MT { get; set; }
        public bool KetMongMat_GiacMac_MT { get; set; }
        public int ThungGiacMac_MT { get; set; }
        public bool Seidel_MT { get; set; }
        public string DuongKinhThungGiacMac_MT { get; set; }
        public bool ThungBit_GM_MT { get; set; }
        public int CamGiacGiacMac_MT { get; set; }
        public int TanMach_GiacMac_MT { get; set; }
        public int MucDo_TanMach_GiacMac_MT { get; set; }
        public bool SuyTeBaoNguon_MT { get; set; }
        public bool ThoaiHoaGia_MT { get; set; }
        public bool LangDongCanXi_MT { get; set; }
        public string BatThuongKhac_GiacMac_MT { get; set; }
        public int Viem_CungMac_MT { get; set; }
        public bool Viem_NongSau_CungMac_MT { get; set; }
        public bool ViemThuongCungMac_MT { get; set; }
        public int GianLoi_TieuMong_HoaiTu_MT { get; set; }
        public string ChiTietKhac_CungMac_MT { get; set; }
        public int TienPhong_MT { get; set; }
        public string Mu_TienPhong_MT { get; set; }
        public bool Tydal_MT { get; set; }
        public bool MangXuatTiet_MT { get; set; }
        public string Mau_TienPhong_MT { get; set; }
        public string TonThuongKhac_TienPhong_MT { get; set; }
        public bool NauXop_MT { get; set; }
        public bool XoTeo_MT { get; set; }
        public bool CuongTu_MT { get; set; }
        public bool TanMach_MT { get; set; }
        public bool Phoi_MT { get; set; }
        public bool Ket_MT { get; set; }
        public string DuongKinh_DongTu_MT { get; set; }
        public int DongTuTronMeoDinh_MT { get; set; }
        public string ViTriDinh_DongTu_MT { get; set; }
        public int PhanXaDongTu_MT { get; set; }
        public string TonThuongKhac_DongTu_MT { get; set; }
        public bool ThuyTinhThe_MT { get; set; }
        public string HinhThaiDuc_ThuyTinhthe_MT { get; set; }
        public int IOL_CanLechDuc_MT { get; set; }
        public bool IOL_TrongTPHP_MT { get; set; }
        public string TonThuongKhac_ThuyTinhthe_MT { get; set; }
        public int AnhDongTu_MT { get; set; }
        public int DichKinh_MT { get; set; }
        public string TonThuongKhac_DichKinh_MT { get; set; }
        public int DayMat_MT { get; set; }
        public string CD_DayMat_MT { get; set; }
        public bool PhuGai_MT { get; set; }
        public bool BacMauGaiThi_MT { get; set; }
        public string VongMac_DayMat_MT { get; set; }
        public string HeMachMau_DayMat_MT { get; set; }
        public string TonThuongKhac_DayMat_MT { get; set; }
    }
    public class BAMatChanThuong_HoiBenh : BABase_HoiBenh
    {
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

    }
    public class BAMatDayMat_HoiBenh : BABase_HoiBenh
    {
        public int iMiMat_MP { get; set; }
        public int iMiMat_MT { get; set; }
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
    }
    public class BAMatGlocom_HoiBenh : BABase_HoiBenh
    {
        public bool LyDoDiKham_MP { get; set; }
        public bool LyDoDiKham_MT { get; set; }
        public bool LyDoDiKham_2Mat { get; set; }
        public bool NhucMat_DuDoi { get; set; }
        public bool NhucMat_Vua { get; set; }
        public bool NhucMat_Nhe { get; set; }
        public bool NhucMat_Khong { get; set; }
        public bool Nhin_MoDotNgot { get; set; }
        public bool Nhin_MoTungLuc { get; set; }
        public bool Nhin_SuongMu { get; set; }
        public bool Nhin_KhongMo { get; set; }
        public bool Nhin_MoTangDan { get; set; }
        public bool Nhin_NhinThuHep { get; set; }
        public bool Nhin_QuanTanSac { get; set; }
        public bool SoAnhSangChayNuocMat_Co { get; set; }
        public bool SoAnhSangChayNuocMat_Khong { get; set; }
        public bool DoMat_Co { get; set; }
        public bool DoMat_Khong { get; set; }
        public bool ToanThan_DauDau { get; set; }
        public bool ToanThan_Non { get; set; }
        public bool ToanThan_BuonNon { get; set; }
        public bool ToanThan_Khong { get; set; }
        public string CacTrieuChungKhac { get; set; }
        public string ThoiGianXuatHienBenh { get; set; }
        public bool DaKhamChuaBenh_Huyen { get; set; }
        public bool DaKhamChuaBenh_Tinh { get; set; }
        public bool DaKhamChuaBenh_TrungUong { get; set; }
        public bool DaKhamChuaBenh_Khac { get; set; }
        public bool PhuongPhapDieuTri_PhauThuat { get; set; }
        public bool PhuongPhapDieuTri_Thuoc { get; set; }
        public bool PhuongPhapDieuTri_Laser { get; set; }
        public string PTTTMP_Loai1 { get; set; }
        public string PTTTMP_Loai2 { get; set; }
        public string PTTTMP_Loai3 { get; set; }
        public string PTTTMP_Loai4 { get; set; }
        public string PTTTMT_Loai1 { get; set; }
        public string PTTTMT_Loai2 { get; set; }
        public string PTTTMT_Loai3 { get; set; }
        public string PTTTMT_Loai4 { get; set; }
        public string PTTTMP_ThoiDiem1 { get; set; }
        public string PTTTMP_ThoiDiem2 { get; set; }
        public string PTTTMP_ThoiDiem3 { get; set; }
        public string PTTTMP_ThoiDiem4 { get; set; }
        public string PTTTMT_ThoiDiem1 { get; set; }
        public string PTTTMT_ThoiDiem2 { get; set; }
        public string PTTTMT_ThoiDiem3 { get; set; }
        public string PTTTMT_ThoiDiem4 { get; set; }
        public string PTTTMP_Noi1 { get; set; }
        public string PTTTMP_Noi2 { get; set; }
        public string PTTTMP_Noi3 { get; set; }
        public string PTTTMP_Noi4 { get; set; }
        public string PTTTMT_Noi1 { get; set; }
        public string PTTTMT_Noi2 { get; set; }
        public string PTTTMT_Noi3 { get; set; }
        public string PTTTMT_Noi4 { get; set; }
        public bool ThuocHaNhanAp_Uong { get; set; }
        public bool ThuocHaNhanAp_TraMat { get; set; }
        public bool ThuocHaNhanAp_Tiem { get; set; }
        public bool ThuocHaNhanAp_1Thuoc { get; set; }
        public bool ThuocHaNhanAp_2Thuoc { get; set; }
        public bool ThuocHaNhanAp_3Thuoc { get; set; }
        public bool ThuocHaNhanAp_4Thuoc { get; set; }
        public List<ThuocHaNhanApDaDungs> ThuocHaNhanApDaDung { get; set; }
        public string CacThuocKhac { get; set; }
        public string TienTrinhDieuTri { get; set; }
        public int TienSuKhac { get; set; }
        public bool TienSuKhac_CanThi { get; set; }
        public bool TienSuKhac_VienThi { get; set; }
        public bool TienSuKhac_TranThuong { get; set; }
        public bool TienSuKhac_VienMangBoDao { get; set; }
        public bool TienSuKhac_VienPhanTruocNhaCau { get; set; }
        public bool TienSuKhac_TacTMTTVM { get; set; }
        public bool TienSuKhac_DaPTMat { get; set; }
        public string TienSuKhac_DaPTMat_Text { get; set; }
        public bool TienSuKhac_BenhKhac { get; set; }
        public string TienSuKhac_BenhKhac_Text { get; set; }
        public string TienSuKhac_Corticosteroid { get; set; }
        public bool TienSuKhac_Cor { get; set; }
        public string ThoiGianSuDung_Corticosteroid { get; set; }
        public bool Corticosteroid_TraMat { get; set; }
        public bool Corticosteroid_TiemMat { get; set; }
        public bool Corticosteroid_ToanThan { get; set; }
        public bool Corticosteroid_TheoCDCuaBacSi { get; set; }
        public bool Corticosteroid_BNTuDungThuoc { get; set; }
        public bool TienSuToanThan_TimMach { get; set; }
        public bool TienSuToanThan_HuyetAp { get; set; }
        public bool TienSuToanThan_DaiDuong { get; set; }
        public bool TienSuToanThan_RoDongMachCanh { get; set; }
        public bool TienSuToanThan_BenhKhac { get; set; }
        public string TienSuBenhToanThan_BenhKhac { get; set; }
        public bool TienSuGlocomGiaDinh_OngBa { get; set; }
        public bool TienSuGlocomGiaDinh_BoMe { get; set; }
        public bool TienSuGlocomGiaDinh_AnhChiEm { get; set; }
        public bool TienSuGlocomGiaDinh_CoDiChuBac { get; set; }
    }
    public class BAMatLac_HoiBenh : BABase_HoiBenh
    {
        public string ThiLucKhiVaoVien_KhongKinh_MP { get; set; }
        public string ThiLucKhiVaoVien_KhongKinh_MT { get; set; }
        public string ThiLucKhiVaoVien_CoKinh_MP { get; set; }
        public string ThiLucKhiVaoVien_CoKinh_MT { get; set; }
        public string NhanApVaoVien_MT { get; set; }
        public string NhanApVaoVien_MP { get; set; }
        public string ThiTruong_MP { get; set; }
        public string ThiTruong_MT { get; set; }
        public bool LyDoVaoVien_Lac { get; set; }
        public bool LyDoVaoVien_SupMi { get; set; }
        public bool LyDoVaoVien_Khac { get; set; }
        public bool QuaTrinhBenhLy_NguyenNhan { get; set; }
        public string NguyenNhan_TuBaoGio { get; set; }
        public int TrieuChungChinh { get; set; }
        public bool TrieuChung_SupMi { get; set; }
        public bool TrieuChung_RungGiatNhanCau { get; set; }
        public bool TrieuChung_Khac { get; set; }
        public string TrieuChung_Khac_Text { get; set; }
        public bool DaDieuTri_TapNhuocThi { get; set; }
        public string TapNhuocThi_PhuongPhap { get; set; }
        public int TapNhuocThi_KetQua { get; set; }
        public bool DaDieuTri_PhauThuat { get; set; }
        public string DaDieuTri_PhauThuat_PhuongPhap { get; set; }
        public bool KetQua_PhauThuat_Tot { get; set; }
        public bool KetQua_PhauThuat_MoNon { get; set; }
        public string KetQua_PhauThuat_MoNon_Text { get; set; }
        public bool KetQua_PhauThuat_MoGia { get; set; }
        public string KetQua_PhauThuat_MoGiaText { get; set; }
        public bool TienSuBenhBanThan_Tick { get; set; }
        public bool TienSuBenhGiaDinh_Tick { get; set; }
        public string KhucXaMay_TruocAtropine_MP { get; set; }
        public string KhucXaMay_SauAtropine_MP { get; set; }
        public string KhucXaMay_SauAtropine_MT { get; set; }
        public string KhucXaMay_TruocAtropine_MT { get; set; }
        public bool VanNhanNoiTai_MP { get; set; }
        public string VanNhanNoiTai_Text_MP { get; set; }
        public bool VanNhanNoiTai_MT { get; set; }
        public string VanNhanNoiTai_TextMT { get; set; }
        public bool DiemCanQuyTu { get; set; }
        public string DiemCanQuyTu_Text { get; set; }
        public bool RungGiatNhanCau { get; set; }
        public string RungGiatNhanCau_Text { get; set; }
        public string KieuRGNC { get; set; }
        public bool GocHam { get; set; }
        public int ThiNghiemCheMat { get; set; }
        public string HinhThaiVaTinhChatLac { get; set; }
        public string Hirschberg_Truoc_atropine { get; set; }
        public string Hirschberg_Sau_atropine { get; set; }
        public string LangKinh_Truoc_atropine { get; set; }
        public string LangKinh_Sau_atropine { get; set; }
        public string NhinGan { get; set; }
        public string NhinLen { get; set; }
        public string NhinXa { get; set; }
        public string NhinXuong { get; set; }
        public string HoiChung { get; set; }
        public string Synoptophore_KhacQuan { get; set; }
        public string Synoptophore_ChuQuan { get; set; }
        public int TinhTrangThiGiacHaiMat { get; set; }
        public string TinhTrangThiGiacHaiMat_Text { get; set; }
        public string BienDoHopThi { get; set; }
        public bool TuongUngVongMac { get; set; }
        public bool SongThi { get; set; }
        public string SongThi_Text { get; set; }
        public bool TuTheBuTru { get; set; }
        public string TuTheBuTru_Text { get; set; }
    }
    public class BAMatTreEm_HoiBenh : BABase_HoiBenh
    {
        public bool DaDieuTri_NoiKhoa { get; set; }
        public string DaDieuTri_PhauThuat { get; set; }
        public bool NguyenNhan_BamSinh { get; set; }
        public string NguyenNhan_TuBaoGio { get; set; }
        public bool TrieuChung_NhinMo { get; set; }
        public bool TrieuChung_DauNhuc { get; set; }
        public bool TrieuChung_DoMat { get; set; }
        public bool TrieuChung_ChoiMat { get; set; }
        public bool TienSuBenhBanThan_Tick { get; set; }
        public bool TienSuBenhGiaDinh_Tick { get; set; }
        public bool TienSuThaiNghenBenhLy { get; set; }
        public string TienSuThaiNghenBenhLy_Text { get; set; }
        public bool PhatTrienTriTue { get; set; }
        public string PhatTrienTriTue_BenhLyText { get; set; }
        public string ThiLucKhiVaoVien_KhongKinh_MP { get; set; }
        public string ThiLucKhiVaoVien_KhongKinh_MT { get; set; }
        public string ThiLucKhiVaoVien_CoKinh_MP { get; set; }
        public string ThiLucKhiVaoVien_CoKinh_MT { get; set; }
        public string NhanApVaoVien_MT { get; set; }
        public string NhanApVaoVien_MP { get; set; }
        public string ThiTruong_MP { get; set; }
        public string ThiTruong_MT { get; set; }
        public bool VanNhanNoiTai_MP { get; set; }
        public string VanNhanNoiTai_Text_MP { get; set; }
        public bool VanNhanNoiTai_MT { get; set; }
        public string VanNhanNoiTai_Text_MT { get; set; }
        public bool VanNhanNgoaiLai_MP { get; set; }
        public string VanNhanNgoaiLai_Text_MP { get; set; }
        public bool VanNhanNgoaiLai_MT { get; set; }
        public string VanNhanNgoaiLai_Text_MT { get; set; }
        public bool RungGiatNhanCau { get; set; }
        public string RungGiatNhanCau_Text { get; set; }
        public bool MiMat_Quam_MP { get; set; }
        public bool MIMat_Epicanthus { get; set; }
        public bool MiMat_SupMi_MP { get; set; }
        public bool MiMat_U_MP { get; set; }
        public string MiMat_Khac_MP { get; set; }
        public string LeDao_MP { get; set; }
        public bool KetMac_CuongTu_MP { get; set; }
        public bool KetMac_XuatHuyet_MP { get; set; }
        public bool KetMac_XuatTiet_MP { get; set; }
        public bool KetMac_U_MP { get; set; }
        public string KetMac_Khac_MP { get; set; }
        public bool GiacMac_Trong_MP { get; set; }
        public string GiacMac_Trong_Text_MP { get; set; }
        public bool GiacMac_LoaiDuong_MP { get; set; }
        public string GiacMac_LoanDuong_Text_MP { get; set; }
        public bool GiacMac_ThoaiHoa_MP { get; set; }
        public string GiacMac_ThoaiHoa_Text_MP { get; set; }
        public string GiacMac_PhuNe_MP { get; set; }
        public string GiacMac_U_MP { get; set; }
        public string GiacMac_Tua_MP { get; set; }
        public string GiacMac_Loet_MP { get; set; }
        public string GiacMac_DiTat_MP { get; set; }
        public string GiacMac_DuongKinhGM_MP { get; set; }
        public string GiacMac_VungRia_MP { get; set; }
        public string GiacMac_Khac_MP { get; set; }
        public bool CungMac_GianLoi_MP { get; set; }
        public bool CungMac_SeoMo_MP { get; set; }
        public string CungMac_CuongTu_MP { get; set; }
        public string CungMac_Viem_MP { get; set; }
        public string CungMac_Khac_MP { get; set; }
        public bool MiMat_Quam_MT { get; set; }
        public bool MIMat_EpicanthusMT { get; set; }
        public bool MiMat_SupMi_MT { get; set; }
        public bool MiMat_U_MT { get; set; }
        public string MiMat_Khac_MT { get; set; }
        public string LeDao_MT { get; set; }
        public bool KetMac_CuongTu_MT { get; set; }
        public bool KetMac_XuatHuyet_MT { get; set; }
        public bool KetMac_XuatTiet_MT { get; set; }
        public bool KetMac_U_MT { get; set; }
        public string KetMac_Khac_MT { get; set; }
        public bool GiacMac_Trong_MT { get; set; }
        public string GiacMac_Trong_Text_MT { get; set; }
        public bool GiacMac_LoaiDuong_MT { get; set; }
        public string GiacMac_LoanDuong_Text_MT { get; set; }
        public bool GiacMac_ThoaiHoa_MT { get; set; }
        public string GiacMac_ThoaiHoa_Text_MT { get; set; }
        public string GiacMac_PhuNe_MT { get; set; }
        public string GiacMac_U_MT { get; set; }
        public string GiacMac_Tua_MT { get; set; }
        public string GiacMac_Loet_MT { get; set; }
        public string GiacMac_DiTat_MT { get; set; }
        public string GiacMac_DuongKinhGM_MT { get; set; }
        public string GiacMac_VungRia_MT { get; set; }
        public string GiacMac_Khac_MT { get; set; }
        public bool CungMac_GianLoi_MT { get; set; }
        public bool CungMac_SeoMo_MT { get; set; }
        public string CungMac_CuongTu_MT { get; set; }
        public string CungMac_Viem_MT { get; set; }
        public string CungMac_Khac_MT { get; set; }
    }
    public class BANgoaiTruYHCT_HoiBenh : BABase_HoiBenh
    {
        public string BenhSu { get; set; }
        public string TomTatKetQuaCanLamSang { set; get; }
        public string MotaTienSuBanThan { get; set; }
        public string ToanThan { get; set; }
        public string TuanHoan { get; set; }
        public string HoHap { get; set; }
        public string TieuHoa { get; set; }
        public string ThanTietNieuSinhDuc { get; set; }
        public string ThanKinh { get; set; }
        public string CoXuongKhop { get; set; }
        public string TaiMuiHong { get; set; }
        public string Mat { get; set; }
        public string Khac_CacCoQuan { get; set; }
        public string BenhChinh { get; set; }
        public string BenhKemTheo { get; set; }
        public string MICD_BenhChinh { set; get; }
        public string MICD_BenhKemTheo { set; get; }
        public string PhanBiet { get; set; }
    }
    public class BANhiKhoa_HoiBenh : BABase_HoiBenh
    {
        public int ConThuMay { get; set; }
        public string ParaSinh { get; set; }
        public string ParaSom { get; set; }
        public string ParaSay { get; set; }
        public string ParaSong { get; set; }
        public int TinhTrangKhiSinhID { get; set; }
        public decimal CanNangLucSinh { get; set; }
        public string DiTatBamSinh_Text { get; set; }
        public bool DiTatBamSinh { get; set; }
        public string PhatTrienTinhThan { get; set; }
        public string PhatTrienVanDong { get; set; }
        public string CacBenhLyKhac { get; set; }
        public int NuoiDuongID { get; set; }
        public int CaiSuaThang { get; set; }
        public bool ChamSocID { get; set; }
        public string BenhKhacDuocTiemChungKhac { get; set; }
        public bool Lao { get; set; }
        public bool BaiLiet { get; set; }
        public bool Soi { get; set; }
        public bool HoGa { get; set; }
        public bool UonVan { get; set; }
        public bool BachHau { get; set; }
        public bool TiemChungKhac { get; set; }
    }
    public class BANoiTruYHCT_HoiBenh : BABase_HoiBenh
    {
        public string BenhSu { get; set; }
        public string MotaTienSuBanThan { get; set; }
        public string ToanThan { get; set; }
        public string TuanHoan { get; set; }
        public string HoHap { get; set; }
        public string TieuHoa { get; set; }
        public string ThanTietNieuSinhDuc { get; set; }
        public string ThanKinh { get; set; }
        public string CoXuongKhop { get; set; }
        public string TaiMuiHong { get; set; }
        public string RangHamMat { get; set; }
        public string Mat { get; set; }
        public string Khac_CacCoQuan { get; set; }
        public string CacXetNghiemCanLamSangCanLam { get; set; }
        public string TomTatBenhAn { get; set; }
        public string BenhChinh { get; set; }
        public string BenhKemTheo { get; set; }
        public string MICD_BenhChinh { set; get; }
        public string MICD_BenhKemTheo { set; get; }
        public string PhanBiet { get; set; }
    }
    public class BAPhaThaiI_HoiBenh : BABase_HoiBenh
    {
        public TienSuSanPhuKhoa TienSuSanPhuKhoa { get; set; }
        public string TienThaiPara { get; set; }
    }
    public class BAPhaThaiII_HoiBenh : BABase_HoiBenh
    {
        public TienSuSanPhuKhoa TienSuSanPhuKhoa { get; set; }
        public string TienThaiPara { get; set; }
    }
    public class BAPhaThaiIII_HoiBenh : BABase_HoiBenh
    {
        public string LyDoPhaThai { get; set; }
        public string TienSuSanPhuKhoa { get; set; }
        public int? SoConHienCo { get; set; }
        public int? SoConTrai { get; set; }
        public int? SoConGai { get; set; }
        public int? SoLanPhauThuatLayThai { get; set; }
        public string NamPhauThuatLayThaiCuoi { get; set; }
        public string CacPhauThuatTCKhac { get; set; }
        public string CacPhauThuatTCKhac_Nam { get; set; }
        public int? SoLanPhaThai { get; set; }
        public string BienPhapTTDangSuDung { get; set; }
        public string TieuSuBenh { get; set; }
        public int TinhTrangHonNhan { get; set; }
        public string DUThuoc_Ten { get; set; }
        public string DUThuoc_CoSoLan { get; set; }
        public bool DUThuoc_Khong { get; set; }
        public string DUThuoc_BieuHien { get; set; }
        public string DUConTrung_Ten { get; set; }
        public string DUConTrung_CoSoLan { get; set; }
        public bool DUConTrung_Khong { get; set; }
        public string DUConTrung_BieuHien { get; set; }
        public string DUThucPham_Ten { get; set; }
        public string DUThucPham_CoSoLan { get; set; }
        public bool DUThucPham_Khong { get; set; }
        public string DUThucPham_BieuHien { get; set; }
        public string DUTacNhanKhac_Ten { get; set; }
        public string DUTacNhanKhac_CoSoLan { get; set; }
        public bool DUTacNhanKhac_Khong { get; set; }
        public string DUTacNhanKhac_BieuHien { get; set; }
        public string DUCaNhanKhac_Ten { get; set; }
        public string DUCaNhanKhac_CoSoLan { get; set; }
        public bool DUCaNhanKhac_Khong { get; set; }
        public string DUCaNhanKhac_BieuHien { get; set; }
        public string DUDiTruyen_Ten { get; set; }
        public string DUDiTruyen_CoSoLan { get; set; }
        public bool DUDiTruyen_Khong { get; set; }
        public string DUDiTruyen_BieuHien { get; set; }

    }
    public class BAPhucHoiChucNang_HoiBenh : BABase_HoiBenh
    {
        public int AnUong { get; set; }
        public int ChaiToc { get; set; }
        public int DanhRang { get; set; }
        public int Tam { get; set; }
        public int MacQuanAo { get; set; }
        public int DiVeSinh { get; set; }
        public int NamNguaSap { get; set; }
        public int NamNguaNgoi { get; set; }
        public int DungNgoi { get; set; }
        public int TuSanDungLen { get; set; }
        public int DungCuTroGiup { get; set; }
        public int KhaNangDiChuyen { get; set; }
        public string Khac_ChucNangSinhHoat { get; set; }
    }
    public class BAPhuKhoa_HoiBenh : BABase_HoiBenh
    {
        public TienSuSanPhuKhoa TienSuSanPhuKhoa { get; set; }
        public int TienThaiPara { get; set; }
        public string ChiSoPara1 { get; set; }
        public string ChiSoPara2 { get; set; }
        public string ChiSoPara3 { get; set; }
        public string ChiSoPara4 { get; set; }
    }
    public class BASanKhoa_HoiBenh : BABase_HoiBenh
    {
        public bool KhongNhoNgayKinhCuoi { get; set; }
        public string KinhKhacThuong { get; set; }
        public int TuoiThai { get; set; }
        public int NgayThai { get; set; }
        public string KhamThaiTai { get; set; }
        public bool TiemPhongUonVan { get; set; }
        public bool Phu { get; set; }
        public int DuocTiem { get; set; }
        public string DauHieuLucDau { get; set; }
        public string BienChuyen { get; set; }
        public int BatDauThayKinhNam { get; set; }
        public int TuoiThayKinh { get; set; }
        public string TinhChatKinhNguyet { get; set; }
        public int ChuKy { get; set; }
        public string LuongKinh { get; set; }
        public int LayChongNam { get; set; }
        public int TuoiLayChong { get; set; }
        public string NhungBenhPhuKhoaDaDieuTri { get; set; }
        public int TreSoSinh_LoaiThai { get; set; } = 2;
        public int TreSoSinh_GioiTinh { get; set; } = 2;
        public int TreSoSinh_SongChet { get; set; } = 2;
        public int TreSoSinh_DiTat { get; set; } = 2;
        public int? TreSoSinh_CanNang { get; set; }
    }
    public class BASoSinh_HoiBenh : BABase_HoiBenh
    {
        public string HoiBenh { get; set; }
        public string MauSac { get; set; }
        public bool CachDeID { get; set; }
        public string LyDoCanThiep { get; set; }
        public string NguoiDoDe { get; set; }
        public string Apgar1 { get; set; }
        public string Apgar5 { get; set; }
        public string Apgar10 { get; set; }
        public double CanNang { get; set; }
        public string TinhTrangDinhDuong { get; set; }
        public bool HutDich { get; set; }
        public bool XoaBopTim { get; set; }
        public bool ThoO2 { get; set; }
        public bool DatNoiKhiQuan { get; set; }
        public bool BopBongO2 { get; set; }
        public bool Khac { get; set; }
    }
    public class BATamThan_HoiBenh : BABase_HoiBenh
    {
        public string ToanThan { get; set; }
        public string TuanHoan { get; set; }
        public string HoHap { get; set; }
        public string TieuHoa { get; set; }
        public string ThanTietNieuSinhDuc { get; set; }
        public string ThanKinh { get; set; }
        public string CoXuongKhop { get; set; }
        public string TaiMuiHong { get; set; }
        public string RangHamMat { get; set; }
        public string Mat { get; set; }
        public string Khac_CacCoQuan { get; set; }
    }
    public class BATayChanMieng_HoiBenh : BABase_HoiBenh
    {
        public string TrieuTrung { get; set; }
        public string TrieuTrung_GiatMinh_SoLan { get; set; }
        public string BenhLy_DauHieuKhac { get; set; }
        public string BenhLy_DichTe { get; set; }
        public int DichTe_DiHoc { get; set; }
        public string DichTe_DiaChiTruong { get; set; }
        public string DichTe { get; set; }
        public string DieuTriTuyenTruoc { get; set; }
        public string BenhLy_Khac { get; set; }
        public string TenThuoc1 { set; get; }
        public int TSDU1 { set; get; }
        public string SoLan1 { set; get; }
        public string BHLS1 { set; get; }
        public string TenThuoc2 { set; get; }
        public int TSDU2 { set; get; }
        public string SoLan2 { set; get; }
        public string BHLS2 { set; get; }
        public string TenThuoc3 { set; get; }
        public int TSDU3 { set; get; }
        public string SoLan3 { set; get; }
        public string BHLS3 { set; get; }
        public string TenThuoc4 { set; get; }
        public int TSDU4 { set; get; }
        public string SoLan4 { set; get; }
        public string BHLS4 { set; get; }
        public string TenThuoc5 { set; get; }
        public int TSDU5 { set; get; }
        public string SoLan5 { set; get; }
        public string BHLS5 { set; get; }
        public string TenThuoc6 { set; get; }
        public int TSDU6 { set; get; }
        public string SoLan6 { set; get; }
        public string BHLS6 { set; get; }
        public int DiTatBamSinh_Co { set; get; }
        public int SinhTruong_ConThuMay { get; set; }
        public string TienThaiPara { set; get; }
        public int TTKhiSinh { get; set; }
        public int CanNangLucSinh { get; set; }
        public string DiTatBamSinh { get; set; }
        public string PTTinhThan { get; set; }
        public string PTVanDong { get; set; }
        public string CacBenhLyKhac { get; set; }
        public string NuoiDuong { set; get; }
        public string NuoiDuong_CaiSua { get; set; }
        public int ChamSoc { get; set; }
        public string TiemChung { set; get; }
        public string SinhTruong_Khac { get; set; }
    }
    public class BAThanNhanTao_HoiBenh : BABase_HoiBenh
    {
        public string TheTrang { get; set; }
        public string YThuc { get; set; }
        public string DaNiemMac { get; set; }
        #region TietNieu
        public bool Is_DaiMau { get; set; }
        public bool Is_DaiDuc { get; set; }
        public bool Is_DaiRaHB { get; set; }
        public bool Is_DaiRat { get; set; }
        public bool Is_DaiBuot { get; set; }
        public bool Is_ConDauQuanThan { get; set; }
        public bool Is_ThanTo { get; set; }
        #endregion
        #region HoiChungThuaNuoc
        public bool Is_Phu { get; set; }
        public bool Is_TranDichMangBung { get; set; }
        public bool Is_TranDichMangPhoi { get; set; }
        public bool Is_TranDichMangTim { get; set; }
        #endregion
        [MoTaDuLieu("Nhịp tim")]
		public string NhipTim { get; set; }
        public string LoaiNhipTim { get; set; }
        public string TiengThoi { get; set; }
        public string SuyTim { get; set; }
        public string KieuTho { get; set; }
        public string RalesOPhoi { get; set; }
        public bool Is_DauHieuKhoTho { get; set; }
        public bool Is_DauHieuPhuPhoi { get; set; }
        #region TieuHoa
        public bool Is_VangDa { get; set; }
        public bool Is_GanTo { get; set; }
        public bool Is_VangMat { get; set; }
        public bool Is_LachTo { get; set; }
        #endregion
        #region TrieuChungTrayMau
        public bool Is_NonMau { get; set; }
        public bool Is_DiNgoaiPhanDen { get; set; }
        public bool Is_XuatHuyetDuoiDaVaNiemMac { get; set; }
        #endregion
    }
    public class BATim_HoiBenh : BABase_HoiBenh
    {
        public string CacThuocDangDung { get; set; }
        public int TienSuPKhiSinh { get; set; }
        public string BenhLyMeTrongThaiky { get; set; }
        public string SuDungThuocMeTrongThaiKy { get; set; }
        public NguyCoMachVanh YeuToNguyCoMachVanh { get; set; }
        public BenhNoiKhoa BenhNoiKhoa { get; set; }
    }
    public class BATruyenNhiem_HoiBenh : BABase_HoiBenh
    {
        public string DichTe { get; set; }
        public string BenhCapTinhDangLuuHanh { get; set; }
        public string DaNoiONoiNao { get; set; }
        public string ThoiGianSongONoiPhatHienBenh { get; set; }
        public string MoiSinh { get; set; }
    }
    public class BATruyenNhiemII_HoiBenh : BABase_HoiBenh
    {
        public string DichTe { get; set; }
        public string BenhCapTinhDangLuuHanh { get; set; }
        public string DaNoiONoiNao { get; set; }
        public string ThoiGianSongONoiPhatHienBenh { get; set; }
        public string MoiSinh { get; set; }
        public ObservableCollection<TienSuDiUng> TienSuDiUngs { get; set; }
    }
    public class BANgoaiTruPKy_KhamBenh
    {
        public string BenhCoHoiKemTheo { set; get; }
        public int GDLamSangHIV { set; get; }
        public string CD4 { set; get; }
        public string Hb { set; get; }
        public string ALT { set; get; }
        public string HBsAg { set; get; }
        public string AntiHCV { set; get; }
        public string Creatinine { set; get; }
        public string XetNghiemKhac { set; get; }
        public string KetQua1 { set; get; }
        public string KetQua2 { set; get; }
        public int XuTru1 { set; get; }
        public int XuTru2 { set; get; }
        public int XuTru3 { set; get; }
        public string NDXuTru3 { set; get; }
        public int XuTru4 { set; get; }
        public string NDXuTru4 { set; get; }
        public int XuTru5 { set; get; }
        public int XuTru6 { set; get; }
        public int XuTru7 { set; get; }
        public string NDXuTru7 { set; get; }
        public List<TheoDoiDieuTriHIV_ChiTietTbl> LstTTChiTiet { get; set; }
    }
    public class BADieuTriBanNgay_KhamBenh : BANoiTruYHCT_KhamBenh
    {
        [MoTaDuLieu("Trưởng khoa")]
		public string TruongKhoa { get; set; }
    }
    public class BACMU_KhamBenh
    {
        public string XQuang_Nguc { get; set; }
        public string FCG { get; set; }
        public ObservableCollection<XetNghiemCMU> XetNghiemCMUs { get; set; }
        public string PH { get; set; }
        public string PaCO2 { get; set; }
        public string PO2 { get; set; }
        public string SaO2 { get; set; }
        [MoTaDuLieu("Nồng độ Oxy trong máu")]
		public string SpO2 { get; set; }
        public string XNMau { get; set; }
        public string Hct { get; set; }
        public string Hgb_dl { get; set; }
        public string SieuAmTim { get; set; }
        public string XetNghiemKhac { get; set; }
        public bool ChanDoanHen { get; set; }
        public int MucKiemSoat { get; set; }
        public bool ChanDoanCopd { get; set; }
        public int GiaiDoan { get; set; }
        public string BenhKetHop { get; set; }
        public string HuongXuTri_TuVan { get; set; }
        public string HuongXuTri_DieuTri { get; set; }
        public string HuongXuTri_Khac { get; set; }
        [MoTaDuLieu("Bác sỹ")]
		public string BacSy { get; set; }
        [MoTaDuLieu("Mã bác sỹ")]
		public string MaBacSy { get; set; }
    }
    public class BADaLieu_KhamBenh : BABase_KhamBenh
    {
        public string QuaTrinhBenhLy { get; set; }
        public string PhuongPhapDieuTri { get; set; }
        [MoTaDuLieu("Trưởng khoa")]
		public string TruongKhoa { get; set; }
        [MoTaDuLieu("Bác sỹ điều trị")]
		public string BacSyDieuTri { get; set; }
    }
    public class BAHuyetHocTruyenMau_KhamBenh : BABase_KhamBenh
    {
        public string TinhThanCuaNguoiBenh { set; get; }
        public string HinhDangTuThe { set; get; }
        public string DaNiemMac { set; get; }
        public string TrieuChungXuatHuyet { set; get; }
        public string HeThongLong_Toc_Mong { set; get; }
        public string TrieuChungPhu { set; get; }
        public string TuyenGiap { set; get; }
        public string KichThuoc_Gan { get; set; }
        public string MatDo_Gan { get; set; }
        public string Bo_Gan { get; set; }
        public string MatGan_Gan { get; set; }
        public string Dau_Gan { get; set; }
        public string KichThuoc_Lach { get; set; }
        public string MatDo_Lach { get; set; }
        public string Bo_Lach { get; set; }
        public string MatGan_Lach { get; set; }
        public string Dau_Lach { get; set; }
        public string ViTri_Hach { get; set; }
        public string KichThuoc_Hach { get; set; }
        public string SoLuong_Hach { get; set; }
        public string DoDiDong_Hach { get; set; }
        public string MatHach_Hach { get; set; }
        public string Dau_Hach { get; set; }
        public bool HuyetDo { get; set; }
        public bool TuyDo { get; set; }
        public bool SinhThietTuy { get; set; }
        public bool SinhThietHach { get; set; }
        public bool DongMauToanBo { get; set; }
        public bool DinhLuongYeuToMauDong { get; set; }
        public bool DienDiHST { get; set; }
        public bool NhiemSacThe { get; set; }
        public bool NhomMau { get; set; }
        public bool CoombsTest { get; set; }
        public bool KhangTheBatThuong { get; set; }
        public bool SinhHoa { get; set; }
        public bool GPB { get; set; }
        public bool ViSinh { get; set; }
        public bool XQuang { get; set; }
        public int KhoiHongCau { get; set; }
        public int HuyetTuuong { get; set; }
        public int HongCauRua { get; set; }
        public int HuyetTuongDongLanh { get; set; }
        public int KhoiTieuCau { get; set; }
        public int TuaVIII { get; set; }
        public int KhoiBachCauHat { get; set; }
        public int TruyenMauToanPhan { get; set; }
        public int CacPhanUngKhiTruyenMau { get; set; }
        public bool PhanTichTeBao { get; set; }
    }
    public class BALuuCapCuu_KhamBenh : BABase_KhamBenh
    {
        public string CacBoPhan { set; get; }
        public string TomTatKetQuaCanLamSang { set; get; }
        [MoTaDuLieu("Chẩn đoán bệnh ban đầu")]
		public string ChanDoanBanDau { set; get; }
        public string DaXuLy { set; get; }
        [MoTaDuLieu("Chẩn đoán bệnh khi ra viện")]
		public string ChanDoanKhiRaVien { set; get; }
        public bool KeToa { get; set; }
        public bool Khoi { get; set; }
        public bool TronVien { get; set; }
        public string MAIDC_ChanDoanKhiRaVien { set; get; }
        public ObservableCollection<ThongTinYLenh> ThongTinYLenhs { get; set; }
    }
    public class BAMat_KhamBenh : BABase_KhamBenh
    {
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
    }
    public class BANgoaiTruMat_KhamBenh : BABase_KhamBenh
    {
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
    }
    public class BAMatBanPhanTruoc_KhamBenh : BABase_KhamBenh
    {
        public bool ChuaThayBenhLy { get; set; }
        public bool BenhLy { get; set; }
        public string BenhLy_Text { get; set; }
    }
    public class BAMatChanThuong_KhamBenh : BABase_KhamBenh
    {
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
        public bool ThayBenhLy { get; set; }
        public bool ChuaThayBenhLy { get; set; }

    }
    public class BAMatDayMat_KhamBenh : BABase_KhamBenh
    {
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
        public int TanMachHacMac_MP { get; set; }
        public bool DiaThi_VongMac_MP { get; set; }
        public int DiaThiID_VongMac_MP { get; set; }
        public bool TanMachGai_VongMac_MP { get; set; }
        public int TanMachGaiID_VongMac_MP { get; set; }
        public bool HoangDiem_VongMac_MP { get; set; }
        public int HoangDiem_Phu_VongMac_MP { get; set; }
        public int HoangDiem_Lo_VongMac_MP { get; set; }
        public string HoangDiem_Lo_Do_VongMac_MP { get; set; }
        public bool HoangDiem_Seo_VongMac_MP { get; set; }
        public int ThoaiHoa_VongMac_MP { get; set; }
        public string ThoaiHoa_VongMac_MP_Text { get; set; }
        public int XuatHuyet_VongMac_MP { get; set; }
        public int XuatTiet_VongMac_MP { get; set; }
        public int BongThanhDich_VongMac_MP { get; set; }
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
        public int TanMachHacMac_MT { get; set; }
        public bool DiaThi_VongMac_MT { get; set; }
        public int DiaThiID_VongMac_MT { get; set; }
        public bool TanMachGai_VongMac_MT { get; set; }
        public int TanMachGaiID_VongMac_MT { get; set; }
        public bool HoangDiem_VongMac_MT { get; set; }
        public int HoangDiem_Phu_VongMac_MT { get; set; }
        public int HoangDiem_Lo_VongMac_MT { get; set; }
        public string HoangDiem_Lo_Do_VongMac_MT { get; set; }
        public bool HoangDiem_Seo_VongMac_MT { get; set; }
        public int ThoaiHoa_VongMac_MT { get; set; }
        public string ThoaiHoa_VongMac_MT_Text { get; set; }
        public int XuatHuyet_VongMac_MT { get; set; }
        public int XuatTiet_VongMac_MT { get; set; }
        public int BongThanhDich_VongMac_MT { get; set; }
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
        public string BenhLy { get; set; }
    }
    public class BAMatGlocom_KhamBenh : BABase_KhamBenh
    {
        public string ThiLucVaoVienMP_KhongKinh { get; set; }
        public string ThiLucVaoVienMT_KhongKinh { get; set; }
        public string ThiLucVaoVienMP_CoKinh { get; set; }
        public string ThiLucVaoVienMT_CoKinh { get; set; }
        public string NhaApMP { get; set; }
        public string NhaApMT { get; set; }
        public bool MiMatSungNeMP_Khong { get; set; }
        public bool MiMatSungNeMP_Co { get; set; }
        public bool MiMatSungNeMT_Khong { get; set; }
        public bool MiMatSungNeMT_Co { get; set; }
        public string NhanApMP_Khac { get; set; }
        public string NhanApMT_Khac { get; set; }
        public bool KetMacCuongTuMP_Khong { get; set; }
        public bool KetMacCuongTuMP_Co { get; set; }
        public bool KetMacCuongTuMT_Khong { get; set; }
        public bool KetMacCuongTuMT_Co { get; set; }
        public bool KetMacSeoMoCuMP_Khong { get; set; }
        public bool KetMacSeoMoCuMP_Co { get; set; }
        public string KetMacSeoMoCuMP { get; set; }
        public bool KetMacSeoMoCuMT_Khong { get; set; }
        public bool KetMacSeoMoCuMT_Co { get; set; }
        public string KetMacSeoMoCuMT { get; set; }
        public bool KetMacBonDoMP_Tot { get; set; }
        public bool KetMacBonDoMP_Dep { get; set; }
        public bool KetMacBonDoMP_Xo { get; set; }
        public bool KetMacBonDoMP_Mong { get; set; }
        public bool KetMacBonDoMP_QuaPhat { get; set; }
        public bool KetMacBonDoMT_Tot { get; set; }
        public bool KetMacBonDoMT_Dep { get; set; }
        public bool KetMacBonDoMT_Xo { get; set; }
        public bool KetMacBonDoMT_Mong { get; set; }
        public bool KetMacBonDoMT_QuaPhat { get; set; }
        public bool GiacMacTrongSuatMP_Trong { get; set; }
        public bool GiacMacTrongSuatMP_Seo { get; set; }
        public bool GiacMacTrongSuatMP_LoanDuong { get; set; }
        public bool GiacMacPhuNeMP_Khong { get; set; }
        public bool GiacMacPhuNeMP_Co { get; set; }
        public string GiacMacPhuNeMP { get; set; }
        public bool GiacMacTrongSuatMT_Trong { get; set; }
        public bool GiacMacTrongSuatMT_Seo { get; set; }
        public bool GiacMacTrongSuatMT_LoanDuong { get; set; }
        public bool GiacMacPhuNeMT_Khong { get; set; }
        public bool GiacMacPhuNeMT_Co { get; set; }
        public string GiacMacPhuNeMT { get; set; }
        public string GiacMacDoDayGiacMacMP { get; set; }
        public string GiacMacDoDayGiacMacMT { get; set; }
        public string GiacMacTuMP { get; set; }
        public string GiacMacTuMT { get; set; }
        public string GiacMacDuongKinhGiacMacMP { get; set; }
        public string GiacMacDuongKinhGiacMacMT { get; set; }
        public bool CungMacDanLoiMP_Khong { get; set; }
        public bool CungMacDanLoiMP_Co { get; set; }
        public bool CungMacDanLoiMT_Khong { get; set; }
        public bool CungMacDanLoiMT_Co { get; set; }
        public bool CungMaSeoMoMP_Khong { get; set; }
        public bool CungMaSeoMoMP_Co { get; set; }
        public string CungMaSeoMoMP { get; set; }
        public bool CungMaSeoMoMT_Khong { get; set; }
        public bool CungMaSeoMoMT_Co { get; set; }
        public string CungMaSeoMoMT { get; set; }
        public string TienPhongDoSauMP { get; set; }
        public string TienPhongDoSauMT { get; set; }
        public string GocTienPhongDauHieuKhacMP { get; set; }
        public string GocTienPhongDauHieuKhacMT { get; set; }
        public string MongMatMauSacMP { get; set; }
        public string MongMatMauSacMT { get; set; }
        public bool MongMatThaiHoaMP_Khong { get; set; }
        public bool MongMatThaiHoaMP_Co { get; set; }
        public string MongMatThaiHoaMP { get; set; }
        public bool MongMatThaiHoaMT_Khong { get; set; }
        public bool MongMatThaiHoaMT_Co { get; set; }
        public string MongMatThaiHoaMT { get; set; }
        public bool MongMatTanMachMP_Khong { get; set; }
        public bool MongMatTanMachMP_Co { get; set; }
        public bool MongMatTanMachMT_Khong { get; set; }
        public bool MongMatTanMachMT_Co { get; set; }
        public bool DongTuMP_Tron { get; set; }
        public bool DongTuMP_Meo { get; set; }
        public bool DongTuMT_Tron { get; set; }
        public bool DongTuMT_Meo { get; set; }
        public string DongTuDuongKinhMP { get; set; }
        public string DongTuDuongKinhMT { get; set; }
        public string DongTuVienSacToMP { get; set; }
        public string DongTuVienSacToMT { get; set; }
        public bool DongTuPhanXaMP_BinhThuong { get; set; }
        public bool DongTuPhanXaMP_Giam { get; set; }
        public bool DongTuPhanXaMP_Mat { get; set; }
        public bool DongTuPhanXaMT_BinhThuong { get; set; }
        public bool DongTuPhanXaMT_Giam { get; set; }
        public bool DongTuPhanXaMT_Mat { get; set; }
        public bool TheThuyTinhMP_Trong { get; set; }
        public bool TheThuyTinhMP_Duc { get; set; }
        public bool TheThuyTinhMT_Trong { get; set; }
        public bool TheThuyTinhMT_Duc { get; set; }
        public bool TheThuyTinhMP_Nhan { get; set; }
        public bool TheThuyTinhMP_Vo { get; set; }
        public bool TheThuyTinhMP_DuoiBao { get; set; }
        public bool TheThuyTinhMP_ToanBo { get; set; }
        public bool TheThuyTinhMT_Nhan { get; set; }
        public bool TheThuyTinhMT_Vo { get; set; }
        public bool TheThuyTinhMT_DuoiBao { get; set; }
        public bool TheThuyTinhMT_ToanBo { get; set; }
        public string DichMP { get; set; }
        public string DichMT { get; set; }
        public string DayMatVongMacMP { get; set; }
        public string DayMatVongMacMT { get; set; }
        public string DayMatHoangDiemMP { get; set; }
        public string DayMatHoangDiemMT { get; set; }
        public bool DayMatTanMachMP_Khong { get; set; }
        public bool DayMatTanMachMP_Co { get; set; }
        public bool DayMatTanMachMT_Khong { get; set; }
        public bool DayMatTanMachMT_Co { get; set; }
        public bool DayMatXuatHuyetMP_Khong { get; set; }
        public bool DayMatXuatHuyetMP_Co { get; set; }
        public bool DayMatXuatHuyetMT_Khong { get; set; }
        public bool DayMatXuatHuyetMT_Co { get; set; }
        public bool DayMatVienThanKinhMP_Khong { get; set; }
        public bool DayMatVienThanKinhMP_Co { get; set; }
        public bool DayMatVienThanKinhMT_Khong { get; set; }
        public bool DayMatVienThanKinhMT_Co { get; set; }
        public bool DiaThiGiaVienThanKinhMP_Duoi { get; set; }
        public bool DiaThiGiaVienThanKinhMP_Tren { get; set; }
        public bool DiaThiGiaVienThanKinhMP_Mui { get; set; }
        public bool DiaThiGiaVienThanKinhMP_TDuong { get; set; }
        public bool DiaThiGiaVienThanKinhMT_Duoi { get; set; }
        public bool DiaThiGiaVienThanKinhMT_Tren { get; set; }
        public bool DiaThiGiaVienThanKinhMT_Mui { get; set; }
        public bool DiaThiGiaVienThanKinhMT_TDuong { get; set; }
        public string DiaThiGiacMauSacMP { get; set; }
        public string DiaThiGiacMauSacMT { get; set; }
        public string DiaThiGiacCDMP { get; set; }
        public string DiaThiGiacCDMT { get; set; }
        public bool DiaThiGiacMachMauMP_BinhThuong { get; set; }
        public bool DiaThiGiacMachMauMP_ChHuong { get; set; }
        public bool DiaThiGiacMachMauMP_GapGoc { get; set; }
        public bool DiaThiGiacMachMauMT_BinhThuong { get; set; }
        public bool DiaThiGiacMachMauMT_ChHuong { get; set; }
        public bool DiaThiGiacMachMauMT_GapGoc { get; set; }
        public bool DiaThiGiacXuatHuetMP_Khong { get; set; }
        public bool DiaThiGiacXuatHuetMP_Co { get; set; }
        public bool DiaThiGiacXuatHuetMT_Khong { get; set; }
        public bool DiaThiGiacXuatHuetMT_Co { get; set; }
        public bool DiaThiGiacTeoCanhGaiMP_Khong { get; set; }
        public bool DiaThiGiacTeoCanhGaiMP_Co { get; set; }
        public bool DiaThiGiacTeoCanhGaiMT_Khong { get; set; }
        public bool DiaThiGiacTeoCanhGaiMT_Co { get; set; }
        public string VanNhanMP { get; set; }
        public string VanNhanMT { get; set; }
        public bool NhanCauMP_BinhThuong { get; set; }
        public bool NhanCauMP_DanNoi { get; set; }
        public bool NhanCauMP_To { get; set; }
        public bool NhanCauMP_Nho { get; set; }
        public bool NhanCauMT_BinhThuong { get; set; }
        public bool NhanCauMT_DanNoi { get; set; }
        public bool NhanCauMT_To { get; set; }
        public bool NhanCauMT_Nho { get; set; }
        public string HocMatMP { get; set; }
        public string HocMatMT { get; set; }
        public bool ChuaThayBenhLy { get; set; }
        public bool BenhLy { get; set; }
        public string BenhLy_Text { get; set; }
    }
    public class BAMatLac_KhamBenh : BABase_KhamBenh
    {
        public bool MiMat_MP { get; set; }
        public bool SupMi_MP { get; set; }
        public int SupMi_MucDo_MP { get; set; }
        public bool Epicanthus_MP { get; set; }
        public int CoNangMi_MP { get; set; }
        public bool Marcusgunn_MP { get; set; }
        public bool Bell_MP { get; set; }
        public string Khac_MiMat_MP { get; set; }
        public bool KetMac_MP { get; set; }
        public string KetMac_Text_MP { get; set; }
        public bool PhanNhanCauTruoc_MP { get; set; }
        public string PhanNhanCauTruoc_Text_MP { get; set; }
        public bool PhanNhanCauSau_MP { get; set; }
        public string PhanNhanCauSau_Text_MP { get; set; }
        public int DinhThi_MP { get; set; }
        public bool MiMat_MT { get; set; }
        public bool SupMi_MT { get; set; }
        public int SupMi_MucDo_MT { get; set; }
        public bool Epicanthus_MT { get; set; }
        public int CoNangMi_MT { get; set; }
        public bool Marcusgunn_MT { get; set; }
        public bool Bell_MT { get; set; }
        public string Khac_MiMat_MT { get; set; }
        public bool KetMac_MT { get; set; }
        public string KetMac_Text_MT { get; set; }
        public bool PhanNhanCauTruoc_MT { get; set; }
        public string PhanNhanCauTruoc_Text_MT { get; set; }
        public bool PhanNhanCauSau_MT { get; set; }
        public string PhanNhanCauSau_Text_MT { get; set; }
        public int DinhThi_MT { get; set; }
        public bool ChuaThayBenhLy { get; set; }
        public bool BenhLy { get; set; }
        public string BenhLy_Text { get; set; }
        public string MaICD_BenhChinh { get; set; }
        public string MaICD_BenhKemTheo { get; set; }
        public string PhuongPhapChinh { get; set; }
        public string CheDoAnUong { get; set; }
        public string CheDoChamSoc { get; set; }
    }
    public class BAMatTreEm_KhamBenh : BABase_KhamBenh
    {
        public string TienPhong_DoSau_MP { get; set; }
        public bool TienPhong_Tydall_MP { get; set; }
        public bool TienPhong_Mu_MP { get; set; }
        public string TienPhong_Mau_MP { get; set; }
        public string TienPhong_GocTienPhong_MP { get; set; }
        public string MongMat_MP { get; set; }
        public string MongMat_MauSac_MP { get; set; }
        public bool MongMat_TinhTrang_MP { get; set; }
        public bool MongMat_TanMach_MP { get; set; }
        public bool MongMat_CamGiac_MP { get; set; }
        public string MongMat_U_MP { get; set; }
        public string MongMat_DiDang_MP { get; set; }
        public int DongTu_Trong_MP { get; set; }
        public string DongTu_DuongKinh_MP { get; set; }
        public string DongTu_VienSacTo_MP { get; set; }
        public int DongTu_PhanXa_MP { get; set; }
        public string DongTu_DiDang_MP { get; set; }
        public int TheThuyTinh_MP { get; set; }
        public bool DichKinh_MP { get; set; }
        public string DichKinh_Text_MP { get; set; }
        public string DayMat_VongMac_MP { get; set; }
        public string DayMat_HoangDiem_MP { get; set; }
        public string DayMat_MachMau_MP { get; set; }
        public string DayMat_DiaThi_MP { get; set; }
        public string DayMat_U_MP { get; set; }
        public bool NhanCau_Mem_MP { get; set; }
        public int NhanCau_To_MP { get; set; }
        public string TienPhong_DoSau_MT { get; set; }
        public bool TienPhong_Tydall_MT { get; set; }
        public bool TienPhong_Mu_MT { get; set; }
        public string TienPhong_Mau_MT { get; set; }
        public string TienPhong_GocTienPhong_MT { get; set; }
        public string MongMat_MT { get; set; }
        public string MongMat_MauSac_MT { get; set; }
        public bool MongMat_TinhTrang_MT { get; set; }
        public bool MongMat_TanMach_MT { get; set; }
        public bool MongMat_CamGiac_MT { get; set; }
        public string MongMat_U_MT { get; set; }
        public string MongMat_DiDang_MT { get; set; }
        public int DongTu_Trong_MT { get; set; }
        public string DongTu_DuongKinh_MT { get; set; }
        public string DongTu_VienSacTo_MT { get; set; }
        public int DongTu_PhanXa_MT { get; set; }
        public string DongTu_DiDang_MT { get; set; }
        public int TheThuyTinh_MT { get; set; }
        public bool DichKinh_MT { get; set; }
        public string DichKinh_Text_MT { get; set; }
        public string DayMat_VongMac_MT { get; set; }
        public string DayMat_HoangDiem_MT { get; set; }
        public string DayMat_MachMau_MT { get; set; }
        public string DayMat_DiaThi_MT { get; set; }
        public string DayMat_U_MT { get; set; }
        public bool NhanCau_Mem_MT { get; set; }
        public int NhanCau_To_MT { get; set; }
        public bool ChuaThayBenhLy { get; set; }
        public bool BenhLy { get; set; }
        public string BenhLy_Text { get; set; }
        public string BenhChinh_MatPhai { get; set; }
        public string BenhChinh_MatTrai { get; set; }
        public string PhuongPhapChinh { get; set; }
        public string CheDoAnUong { get; set; }
        public string CheDoChamSoc { get; set; }
    }
    public class BANgoaiTru_KhamBenh : BABase_KhamBenh
    {
        public string CacBoPhan { set; get; }
        public string TomTatKetQuaCanLamSang { set; get; }
        [MoTaDuLieu("Chẩn đoán bệnh ban đầu")]
		public string ChanDoanBanDau { set; get; }
        public string DaXuLy { set; get; }
        [MoTaDuLieu("Chẩn đoán bệnh khi ra viện")]
		public string ChanDoanKhiRaVien { set; get; }
    }
    public class BANgoaiTruRangHamMat_KhamBenh : BABase_KhamBenh
    {
        public string BenhChuyenKhoa { set; get; }
        public string Phai_HinhVe { set; get; }
        public string Thang_HinhVe { set; get; }
        public string Trai_HinhVe { set; get; }
        public string HamTrenVaHong_HinhVe { set; get; }
        public string HamDuoi_HinhVe { set; get; }
        public string PhanLoai_HinhVe { set; get; }
        public string ChuanDoanCuaKhoaKhamBenh { set; get; }
        public string DaXuLyCuaTuyenDuoi { set; get; }
    }
    public class BANgoaiTruTaiMuiHong_KhamBenh : BABase_KhamBenh
    {
        public string BenhChuyenKhoa { set; get; }
        public string ManNhiPhai_HinhAnh { set; get; }
        public string ManNhiTrai_HinhAnh { set; get; }
        public string MuiTruoc_HinhAnh { set; get; }
        public string MuiSau_HinhAnh { set; get; }
        public string ThanhQuan_HinhAnh { set; get; }
        public string Hong_HinhAnh { set; get; }
        public string CoNghiengPhai_HinhAnh { set; get; }
        public string CoNghiengTrai_HinhAnh { set; get; }
        public string ChuanDoanPhongKham { set; get; }
        public string DaXuLy { set; get; }
    }
    public class BANgoaiTruYHCT_KhamBenh
    {
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
        public string TienLuong { set; get; }
        public string BacSyLamBenhAn { set; get; }

    }
    public class BANhiKhoa_KhamBenh : BABase_KhamBenh
    {
        public string DinhDuong { get; set; }
    }
    public class BANoiTruYHCT_KhamBenh
    {
        //Base trừ tuanhoan
        public string SinhDuc { set; get; }
        public string ToanThan { get; set; }
        public string TonThuongBong { set; get; }
        public string HoHap { get; set; }
        public string TieuHoa { get; set; }
        public string ThanTietNieuSinhDuc { get; set; }
        public string ThanKinh { get; set; }
        public string CoXuongKhop { get; set; }
        public string TaiMuiHong { get; set; }
        public string RangHamMat { get; set; }
        public string Mat { get; set; }
        public string Khac_CacCoQuan { get; set; }
        public string CacXetNghiemCanLamSangCanLam { get; set; }
        public string TomTatBenhAn { get; set; }
        public string BenhChinh { get; set; }
        public string BenhKemTheo { get; set; }
        public string PhanBiet { get; set; }
        public string TienLuong { get; set; }
        public string HuongDieuTri { get; set; }
        public string BacSyLamBenhAn { get; set; }
        //
        public bool HinhThai_Gay { get; set; }
        public bool HinhThai_Beo { get; set; }
        public bool HinhThai_CanDoi { get; set; }
        public bool HinhThai_NamCo { get; set; }
        public bool HinhThai_UaTinh { get; set; }
        public bool HinhThai_NamDuoi { get; set; }
        public bool HinhThai_HieuDong { get; set; }
        public bool HinhThai_Khac { get; set; }
        public bool Than_ConThan { get; set; }
        public bool Than_KhongConThan { get; set; }
        public bool Than_Khac { get; set; }
        public bool Sac_BechTrang { get; set; }
        public bool Sac_Do { get; set; }
        public bool Sac_Vang { get; set; }
        public bool Sac_Xanh { get; set; }
        public bool Sac_Den { get; set; }
        public bool Sac_Khac { get; set; }
        public bool Sac_BinhThuong { get; set; }
        public bool Trach_TuoiNhuan { get; set; }
        public bool Trach_Kho { get; set; }
        public bool Trach_Khac { get; set; }
        public bool ChatLuoi_BinhThuong { get; set; }
        public bool ChatLuoi_Beu { get; set; }
        public bool ChatLuoi_GayMong { get; set; }
        public bool ChatLuoi_Nut { get; set; }
        public bool ChatLuoi_Cung { get; set; }
        public bool ChatLuoi_Loet { get; set; }
        public bool ChatLuoi_Lech { get; set; }
        public bool ChatLuoi_Rut { get; set; }
        public bool ChatLuoi_Khac { get; set; }
        public bool SacLuoi_Hong { get; set; }
        public bool SacLuoi_Nhot { get; set; }
        public bool SacLuoi_Do { get; set; }
        public bool SacLuoi_DoSam { get; set; }
        public bool SacLuoi_XanhTim { get; set; }
        public bool SacLuoi_DamUHuyet { get; set; }
        public bool SacLuoi_Kho { get; set; }
        public bool SacLuoi_Nhuan { get; set; }
        public bool SacLuoi_Khac { get; set; }
        public bool ReuLuoi_Co { get; set; }
        public bool ReuLuoi_Khong { get; set; }
        public bool ReuLuoi_Bong { get; set; }
        public bool ReuLuoi_Day { get; set; }
        public bool ReuLuoi_Mong { get; set; }
        public bool ReuLuoi_Uot { get; set; }
        public bool ReuLuoi_Kho { get; set; }
        public bool ReuLuoi_Dinh { get; set; }
        public bool ReuLuoi_Trang { get; set; }
        public bool ReuLuoi_Vang { get; set; }
        public bool ReuLuoi_Den { get; set; }
        public bool ReuLuoi_Khac { get; set; }
        public string MoTaVongChan { get; set; }
        public bool TiengNoi_BinhThuong { get; set; }
        public bool TiengNoi_To { get; set; }
        public bool TiengNoi_Nho { get; set; }
        public bool TiengNoi_DutQuang { get; set; }
        public bool TiengNoi_Khan { get; set; }
        public bool TiengNoi_Ngong { get; set; }
        public bool TiengNoi_Mat { get; set; }
        public bool TiengNoi_Khac { get; set; }
        public bool HoiTho_BinhThuong { get; set; }
        public bool HoiTho_DutQuang { get; set; }
        public bool HoiTho_Ngan { get; set; }
        public bool HoiTho_Manh { get; set; }
        public bool HoiTho_Yeu { get; set; }
        public bool HoiTho_Tho { get; set; }
        public bool HoiTho_Rit { get; set; }
        public bool HoiTho_KhoKhe { get; set; }
        public bool HoiTho_Cham { get; set; }
        public bool HoiTho_Gap { get; set; }
        public bool HoiTho_Khac { get; set; }
        public bool Ho { get; set; }
        public bool Ho_HoLienTuc { get; set; }
        public bool Ho_Con { get; set; }
        public bool Ho_It { get; set; }
        public bool Ho_Nhieu { get; set; }
        public bool Ho_Khan { get; set; }
        public bool Ho_CoDom { get; set; }
        public bool Ho_Khac { get; set; }
        public bool O { get; set; }
        public bool Nac { get; set; }
        public bool MuiCoThe { get; set; }
        public bool MuiCoThe_Chua { get; set; }
        public bool MuiCoThe_Kham { get; set; }
        public bool MuiCoThe_Tanh { get; set; }
        public bool MuiCoThe_Thoi { get; set; }
        public bool MuiCoThe_Hoi { get; set; }
        public bool MuiCoThe_Khac { get; set; }
        public bool ChatThaiBieuHienBenhLy { get; set; }
        public bool ChatThai_Dom { get; set; }
        public bool ChatThai_ChatNon { get; set; }
        public bool ChatThai_Phan { get; set; }
        public bool ChatThai_NuocTieu { get; set; }
        public bool ChatThai_KhiHu { get; set; }
        public bool ChatThai_KinhNguyet { get; set; }
        public bool ChatThai_Khac { get; set; }
        public string MoTaVanChan { get; set; }
        public bool HanNhiet_BinhThuong { get; set; }
        public bool HanNhiet_Han { get; set; }
        public bool HanNhiet_Nhiet { get; set; }
        public bool HanNhiet_Khac { get; set; }
        public bool HanNhiet_ThichNong { get; set; }
        public bool HanNhiet_SoNong { get; set; }
        public bool HanNhiet_ThichMat { get; set; }
        public bool HanNhiet_SoLanh { get; set; }
        public bool HanNhiet_TrongNguoiNong { get; set; }
        public bool HanNhiet_TrongNguoiLanh { get; set; }
        public bool HanNhiet_RetRun { get; set; }
        public bool HanNhiet_HanNhietVangLai { get; set; }
        public bool HanNhiet_Khac2 { get; set; }
        public bool MoHoi_BinhThuong { get; set; }
        public bool MoHoi_BinhThuong_ThietChan { get; set; }
        public bool MoHoi_KhongCoMoHoi { get; set; }
        public bool MoHoi_TuHan { get; set; }
        public bool MoHoi_DaoHan { get; set; }
        public bool MoHoi_Nhieu { get; set; }
        public bool MoHoi_It { get; set; }
        public bool MoHoi_Khac { get; set; }
        public bool DauMat { get; set; }
        public bool DauDau_MotCho { get; set; }
        public bool DauDau_NuaDau { get; set; }
        public bool DauDau_CaDau { get; set; }
        public bool DauDau_DiChuyen { get; set; }
        public bool DauDau_EAmNhuBiBuocLai { get; set; }
        public bool DauDau_Nhoi { get; set; }
        public bool DauDau_Cang { get; set; }
        public bool DauDau_NangDau { get; set; }
        public bool Mat_HoaMatChongMat { get; set; }
        public bool Mat_NhinKhongRo { get; set; }
        public bool Tai_U { get; set; }
        public bool Tai_Diec { get; set; }
        public bool Tai_Nang { get; set; }
        public bool Tai_ { get; set; }
        public bool Tai_Dau { get; set; }
        public bool Mui_Ngat { get; set; }
        public bool Mui_ChayNuoc { get; set; }
        public bool Mui_ChayMauCam { get; set; }
        public bool Mui_Dau { get; set; }
        public bool Hong_Dau { get; set; }
        public bool Hong_Kho { get; set; }
        public bool CoVai_Moi { get; set; }
        public bool CoVai_Dau { get; set; }
        public bool CoVai_KhoVanDong { get; set; }
        public bool CoVai_Khac { get; set; }
        public bool Lung { get; set; }
        public bool Lung_Dau { get; set; }
        public bool Lung_KhoVanDong { get; set; }
        public bool Lung_CoCungCo { get; set; }
        public bool Lung_Khac { get; set; }
        public bool BungVaUc { get; set; }
        public bool BungNguc_Tuc { get; set; }
        public bool BungNguc_Dau { get; set; }
        public bool BungNguc_Soi { get; set; }
        public bool BungNguc_NongRuot { get; set; }
        public bool BungNguc_DayTruong { get; set; }
        public bool BungNguc_NgotNgatKhoTho { get; set; }
        public bool BungNguc_DauTucCanhSuon { get; set; }
        public bool BungNguc_BonChonKhongYen { get; set; }
        public bool BungNguc_DanhTrongNguc { get; set; }
        public bool BungNguc_Khac { get; set; }
        public bool ChanTay { get; set; }
        public bool An { get; set; }
        public bool An_ThichNong { get; set; }
        public bool An_ThichMat { get; set; }
        public bool An_AnNhieu { get; set; }
        public bool An_AnIt { get; set; }
        public bool An_DangMieng { get; set; }
        public bool An_NhatMieng { get; set; }
        public bool An_ThemAn { get; set; }
        public bool An_ChanAn { get; set; }
        public bool An_AnVaoBungChuong { get; set; }
        public bool An_Khac { get; set; }
        public bool Uong { get; set; }
        public bool Uong_Mat { get; set; }
        public bool Uong_AmNong { get; set; }
        public bool Uong_Nhieu { get; set; }
        public bool Uong_It { get; set; }
        public bool Uong_Khac { get; set; }
        public bool DaiTieuTien { get; set; }
        public bool Tieutien_Vang { get; set; }
        public bool Tieutien_Do { get; set; }
        public bool Tieutien_Duc { get; set; }
        public bool Tieutien_Buot { get; set; }
        public bool Tieutien_Dat { get; set; }
        public bool Tieutien_KhongTuChu { get; set; }
        public bool Tieutien_Bi { get; set; }
        public bool Tieutien_Khac { get; set; }
        public bool Daitien_Tao { get; set; }
        public bool Daitien_Nhao { get; set; }
        public bool Daitien_Song { get; set; }
        public bool Daitien_ToanNuoc { get; set; }
        public bool Daitien_NhayMui { get; set; }
        public bool Daitien_Bi { get; set; }
        public bool Daitien_Khac { get; set; }
        public bool Ngu { get; set; }
        public bool Ngu_KhoVaoGiacNgu { get; set; }
        public bool Ngu_HayTinh { get; set; }
        public bool Ngu_DaySom { get; set; }
        public bool Ngu_HayMo { get; set; }
        public bool Ngu_Khac { get; set; }
        public bool KinhNguyet { get; set; }
        public bool KinhNguyet_DenTruocKy { get; set; }
        public bool KinhNguyet_DenSauKy { get; set; }
        public bool KinhNguyet_LucDenTruocLucDenS { get; set; }
        public bool KinhNguyet_TacKinh { get; set; }
        public bool KinhNguyet_Khac { get; set; }
        public bool ThongKinh_DauTruocKy { get; set; }
        public bool ThongKinh_DauTrongKy { get; set; }
        public bool ThongKinh_DauSauKy { get; set; }
        public bool ThongKinh_Khac { get; set; }
        public bool DoiHa_Vang { get; set; }
        public bool DoiHa_Trang { get; set; }
        public bool DoiHa_Hoi { get; set; }
        public bool DoiHa_Hong { get; set; }
        public bool DoiHa_Khac { get; set; }
        public int RoiHanKhaNangSinhDuc { get; set; }
        public bool Nam_YeuKhiGiaoHop { get; set; }
        public bool Nam_LietDuong { get; set; }
        public bool Nam_DiTinh { get; set; }
        public bool Nam_HoatTinh { get; set; }
        public bool Nam_MongTinh { get; set; }
        public bool Nam_LanhTinh { get; set; }
        public bool Nu_KhongThuThai { get; set; }
        public bool Nu_SayThai_DongThai { get; set; }
        public bool Nu_SayThaiLienTiep { get; set; }
        public bool Nu_Khac { get; set; }
        public bool DieuKienXuatHienBenh { get; set; }
        public string MoTaVaanChan { get; set; }
        public bool Da_BinhThuong { get; set; }
        public bool Da_Kho { get; set; }
        public bool Da_Nong { get; set; }
        public bool Da_Lanh { get; set; }
        public bool Da_Uot { get; set; }
        public bool Da_ChanTayNong { get; set; }
        public bool Da_ChanTayLanh { get; set; }
        public bool Da_AnLom { get; set; }
        public bool Da_AnDau { get; set; }
        public bool Da_CucCung { get; set; }
        public bool Da_Khac { get; set; }
        public bool MoHoi_ToanThan { get; set; }
        public bool MoHoi_Tran { get; set; }
        public bool MoHoi_TayChan { get; set; }
        public bool MoHoi_KhacXucChan { get; set; }
        public bool CoXuongKhop_SanChac { get; set; }
        public bool CoXuongKhop_Mem { get; set; }
        public bool CoXuongKhop_CangCung { get; set; }
        public bool CoXuongKhop_CoCoAnDau { get; set; }
        public bool CoXuongKhop_GanDau { get; set; }
        public bool CoXuongKhop_XuongKhopDau { get; set; }
        public bool CoXuongKhop_Khac { get; set; }
        public bool Bung_Mem { get; set; }
        public bool Bung_Chuong { get; set; }
        public bool Bung_CoChuong { get; set; }
        public bool Bung_CoHonCuc { get; set; }
        public bool Bung_DauThienAn { get; set; }
        public bool Bung_DauCuAn { get; set; }
        public bool Bung_Khac { get; set; }
        public bool MacChan_Phu { get; set; }
        public bool MacChan_Tram { get; set; }
        public bool MacChan_Tri { get; set; }
        public bool MacChan_Sac { get; set; }
        public bool MacChan_Te { get; set; }
        public bool MacChan_Huyen { get; set; }
        public bool MacChan_Hoat { get; set; }
        public bool MacChan_VoLuc { get; set; }
        public bool MacChan_CoLuc { get; set; }
        public bool MacChan_Khac { get; set; }
        public string BenPhai_TongKhan { get; set; }
        public string BenTrai_TongKhan { get; set; }
        public string Ma_BenPhai_TongKhan { get; set; }
        public string Ma_BenTrai_TongKhan { get; set; }
        public int? MachTayTrai_Thon1 { get; set; }
        public int? MachTayTrai_Thon2 { get; set; }
        public int? MachTayTrai_Thon3 { get; set; }
        public int? MachTayTrai_Thon4 { get; set; }
        public int? MachTayTrai_Quan1 { get; set; }
        public int? MachTayTrai_Quan2 { get; set; }
        public int? MachTayTrai_Quan3 { get; set; }
        public int? MachTayTrai_Quan4 { get; set; }
        public int? MachTayTrai_Xich1 { get; set; }
        public int? MachTayTrai_Xich2 { get; set; }
        public int? MachTayTrai_Xich3 { get; set; }
        public int? MachTayTrai_Xich4 { get; set; }
        public int? MachTayPhai_Thon1 { get; set; }
        public int? MachTayPhai_Thon2 { get; set; }
        public int? MachTayPhai_Thon3 { get; set; }
        public int? MachTayPhai_Thon4 { get; set; }
        public int? MachTayPhai_Quan1 { get; set; }
        public int? MachTayPhai_Quan2 { get; set; }
        public int? MachTayPhai_Quan3 { get; set; }
        public int? MachTayPhai_Quan4 { get; set; }
        public int? MachTayPhai_Xich1 { get; set; }
        public int? MachTayPhai_Xich2 { get; set; }
        public int? MachTayPhai_Xich3 { get; set; }
        public int? MachTayPhai_Xich4 { get; set; }
        public string MoTaThietChan { get; set; }
        public string TomTatTuChan { set; get; }
        public string BienPhapLuanTri { set; get; }
        public string BietDanh { set; get; }
        public string BatCuong { set; get; }
        public string TangPhuKinhLac { set; get; }
        public string PhapDieuTri { set; get; }
        public string PhuongThuoc { set; get; }
        public string PPKhongDungThuoc { get; set; }
        public string PPKhac { get; set; }
        public string DieuTriKetHopVoiYHHD_Text { set; get; }
        public bool CheDoDinhDuong_Long { get; set; }
        public bool CheDoDinhDuong_Dac { get; set; }
        public bool CheDoDinhDuong_Kieng { get; set; }
        public bool CheDoDinhDuong_Khac { get; set; }
        public bool CheDoChamSoc_1 { get; set; }
        public bool CheDoChamSoc_2 { get; set; }
        public bool CheDoChamSoc_3 { get; set; }
    }
    public class BAPhaThaiI_KhamBenh
    {
        public string GayTe { get; set; }
        public string GayMe { get; set; }
        public int? HutThaiChanKhongBang { get; set; }
        public int? MangOi { get; set; }
        public int? RauThai { get; set; }
        public int? MoThai { get; set; }
        public int? TuongXungVoiTuoiThai { get; set; }
        public string ThaiBatThuong { get; set; }
        public string ThuocSuDungTruocTrongSau { get; set; }
        public string TaiBienTrongQuaTrinhThuThuat { get; set; }
        public string ToanTrang { get; set; }
        public int? RaMauAmDao { get; set; }
        public string DanhGiaKetQua { get; set; }
        public int? BienPhapTranhThaiSauPhaThai { get; set; }
        public string NguoiLamThuThuat { get; set; }
    }
    public class BAPhaThaiII_KhamBenh
    {
        public string TenThuocUong { get; set; }
        public string BacSyChiDinh { get; set; }
        public int? CacTacDungSauKhiUongThuoc { get; set; }
        public string CacTacDungSauKhiUongText { get; set; }
        public string TenThuocSuDung { get; set; }
        public int? DiaDiemSuDung { get; set; }
        public string DuongDung { get; set; }
        public string BacSyChiDinhSuDung { get; set; }
        public int? CacTacDungSauKhiDungThuoc { get; set; }
        public string CacTacDungSauKhiDungText { get; set; }
        public string KhamLaiBatThuong_Text { get; set; }
        public string KhamLaiBatThuong_BacSy { get; set; }
        public int? NhinThayThaiSay { get; set; }
        public int? TranThaiSayThai { get; set; }
        public string CanGhiRo { get; set; }
        public string DanhGiaKetQua { get; set; }
        public string KetQuaXuTri { get; set; }
        public int? BienPhapTranhThaiSauPhaThai { get; set; }
        public DateTime? NgayThangNamTr2 { get; set; }
        public string NguoiLamThuThuat { get; set; }
    }
    public class BAPhaThaiIII_KhamBenh : BABase_KhamBenh
    {
        public string CacBoPhan { get; set; }
        public int? TuoiThai { get; set; }
        public string AmHo { get; set; }
        public string AmDao { get; set; }
        public string CoTuCung { get; set; }
        public string TuCungChiTiet { get; set; }
        public string PhanPhuPhai { get; set; }
        public string PhanPhuTrai { get; set; }
        public string CacXetNghiemCanLam { get; set; }
        public int? ChanDoanTuoiThai { get; set; }
        public string PhuongPhapPhaThai { get; set; }
    }
    public class BAPhucHoiChucNang_KhamBenh : BABase_KhamBenh
    {
        public string CanDoiCacBoPhan { set; get; }
        public string CacKhuyetTatDacBiet { set; get; }
        public string VanDong { set; get; }
        public string CamGiac { set; get; }
        public string PhanXa { set; get; }
        public string CoTron { set; get; }
        public string ThanKinhSoNao { set; get; }
        public string RoiLoanChucNang { set; get; }
        [MoTaDuLieu("Nhịp tim")]
		public string NhipTim { set; get; }
        public string TiengTim { set; get; }
        public string RoiLoanChucNangTimMach { set; get; }
        public string LongNguc { set; get; }
        public string TheTichKhi { set; get; }
        public string TinhTrangBenhLy_HoHap { set; get; }
        public string RoiLoanChucNangHoHap { set; get; }
        public string TinhTrangBenhLy_TieuHoa { set; get; }
        public string RoiLoanChucNang_TieuHoa { set; get; }
        public string HinhTheCacKhop { set; get; }
        public string TamHoatDongCacKhopLucVaoVien { set; get; }
        public string TamHoatDongCacKhopLucRaVien { set; get; }
        public string TinhTrangBenhLy_Co { set; get; }
        public string RoiLoanChucNang_Co { set; get; }
        public string CoDuocThu { set; get; }
        public int BatCoThu { set; get; }
        public string TinhTrangBenhLy_CotSong { set; get; }
        public string Schober { set; get; }
        public string Stibor { set; get; }
        public string RoiLoanChucNang_CotSong { set; get; }
        public string HinhVeTonThuongKhiVaoVien { set; get; }
        public string CacVanDeKhiemkhuyet { set; get; }
        public string DaVaMoDuoiDa { set; get; }
        public string MucDichDieuTri { set; get; }
    }
    public class BAPhucHoiChucNangYHCT_KhamBenh : BANoiTruYHCT_KhamBenh
    {
        public string CanDoiCacBoPhan { set; get; }
        public string CacKhuyetTatDacBiet { set; get; }
        public string VanDong { set; get; }
        public string CamGiac { set; get; }
        public string PhanXa { set; get; }
        public string CoTron { set; get; }
        public string ThanKinhSoNao { set; get; }
        public string RoiLoanChucNang { set; get; }
        [MoTaDuLieu("Nhịp tim")]
		public string NhipTim { set; get; }
        public string TiengTim { set; get; }
        public string RoiLoanChucNangTimMach { set; get; }
        public string LongNguc { set; get; }
        public string TheTichKhi { set; get; }
        public string TinhTrangBenhLy_HoHap { set; get; }
        public string RoiLoanChucNangHoHap { set; get; }
        public string TinhTrangBenhLy_TieuHoa { set; get; }
        public string RoiLoanChucNang_TieuHoa { set; get; }
        public string HinhTheCacKhop { set; get; }
        public string TamHoatDongCacKhopLucVaoVien { set; get; }
        public string TamHoatDongCacKhopLucRaVien { set; get; }
        public string TinhTrangBenhLy_Co { set; get; }
        public string RoiLoanChucNang_Co { set; get; }
        public string CoDuocThu { set; get; }
        public int BatCoThu { set; get; }
        public string TinhTrangBenhLy_CotSong { set; get; }
        public string Schober { set; get; }
        public string Stibor { set; get; }
        public string RoiLoanChucNang_CotSong { set; get; }
        public string HinhVeTonThuongKhiVaoVien { set; get; }
        public string CacVanDeKhiemkhuyet { set; get; }
        public string DaVaMoDuoiDa { set; get; }
        public string MucDichDieuTri { set; get; }
    }
    public class BAPhuKhoa_KhamBenh : BABase_KhamBenh
    {
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
    }
    public class BARangHamMat_KhamBenh : BABase_KhamBenh
    {
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
    }
    public class BADaLieuTW_KhamBenh : BABase_KhamBenh
    {
        public string Phai_HinhVe { set; get; }
        public string Trai_HinhVe { set; get; }
        public string DUThuoc_Ten { get; set; }
        public string TonThuongCoBan { get; set; }
        public string TrieuChungCoBan { get; set; }
        public string DUThuoc_CoSoLan { get; set; }
        public bool DUThuoc_Khong { get; set; }
        public string DUThuoc_BieuHien { get; set; }
        public string DUConTrung_Ten { get; set; }
        public string DUConTrung_CoSoLan { get; set; }
        public bool DUConTrung_Khong { get; set; }
        public string DUConTrung_BieuHien { get; set; }
        public string DUThucPham_Ten { get; set; }
        public string DUThucPham_CoSoLan { get; set; }
        public bool DUThucPham_Khong { get; set; }
        public string DUThucPham_BieuHien { get; set; }
        public string DUTacNhanKhac_Ten { get; set; }
        public string DUTacNhanKhac_CoSoLan { get; set; }
        public bool DUTacNhanKhac_Khong { get; set; }
        public string DUTacNhanKhac_BieuHien { get; set; }
        public string DUCaNhanKhac_Ten { get; set; }
        public string DUCaNhanKhac_CoSoLan { get; set; }
        public bool DUCaNhanKhac_Khong { get; set; }
        public string DUCaNhanKhac_BieuHien { get; set; }
        public string DUDiTruyen_Ten { get; set; }
        public string DUDiTruyen_CoSoLan { get; set; }
        public bool DUDiTruyen_Khong { get; set; }
        public string DUDiTruyen_BieuHien { get; set; }
    }
    public class BASanKhoa_KhamBenh : BABase_KhamBenh
    {
        public bool BungCoSeoPhauThuatCu { get; set; }
        public string HinhDangTuCung { get; set; }
        public string TuThe { get; set; }
        public double ChieuCaoTC { get; set; }
        public double VongBung { get; set; }
        public string ConCoTC { get; set; }
        public int TimThai { get; set; }
        public string Vu { get; set; }
        [MoTaDuLieu("Chẩn đoán bệnh khi vào khoa")]
		public string ChanDoanKhiVaoKhoa { get; set; }
        public double ChiSoBishop { get; set; }
        public string AmHo { get; set; }
        public string AmDao { get; set; }
        public string TangSinhMon { get; set; }
        public string CoTuCung { get; set; }
        public string PhanPhu { get; set; }
        public int? TinhTrangOiID { get; set; }
        public bool OiVoID { get; set; }
        public string MauSacNuocOi { get; set; }
        public string NuocOiNhieuHayIt { get; set; }
        public string Ngoi { get; set; }
        public string The_KhamTrong { get; set; }
        public string KieuThe { get; set; }
        public int DoLotID { get; set; }
        public string DuongKinhNhoHaVe { get; set; }
        public string KhiVaoKhoa { get; set; }
        public string PhuongPhapChinh { get; set; }
    }
    public class BASoSinh_KhamBenh : BABase_KhamBenh
    {
        public string NguoiChuyenSoSinh { set; get; }
        public bool DiTatBamSinh { set; get; }
        public bool CoHauMon { set; get; }
        public string CuTheDiTat { set; get; }
        public string TinhHinhSoSinhKhiVaoKhoa { set; get; }
        public string TinhTrangToanThan { set; get; }
        public int MauSacDaID { set; get; }
        public string MauSacDa { set; get; }
        public int ChieuDai { get; set; }
        public int VongDau { get; set; }
        public int NhipTho { get; set; }
        public int NhietDo { get; set; }
        public string NghePhoi { set; get; }
        public float ChiSoSilverman { set; get; }
        public int SuDanNoLongNgucID { get; set; }
        public int CoKeoCoLienSuonID { get; set; }
        public int CoKeoMuiUcID { get; set; }
        public int DapCanhMuiID { get; set; }
        public int RenRiID { get; set; }
        public string Bung { set; get; }
        public string PhanXa { set; get; }
        public string TruongLucCo { set; get; }
        public int NhipTim { get; set; }
        public int TinhTrangSoSinhKRDID { get; set; }
        public string ChiDinhTheoDoi { get; set; }
    }
    public class BATaiMuiHong_KhamBenh : BABase_KhamBenh
    {
        public string BenhChuyenKhoa { set; get; }
        public string DaVaMoDuoiDa { set; get; }
        public string ManNhiPhai_HinhAnh { set; get; }
        public string ManNhiTrai_HinhAnh { set; get; }
        public string MuiTruoc_HinhAnh { set; get; }
        public string MuiSau_HinhAnh { set; get; }
        public string ThanhQuan_HinhAnh { set; get; }
        public string Hong_HinhAnh { set; get; }
        public string CoNghiengPhai_HinhAnh { set; get; }
        public string CoNghiengTrai_HinhAnh { set; get; }
    }
    public class BATamThan_KhamBenh
    {
        // base trừ tuan hoàn
        public string SinhDuc { set; get; }
        public string ToanThan { get; set; }
        public string TonThuongBong { set; get; }
        public string HoHap { get; set; }
        public string TieuHoa { get; set; }
        public string ThanTietNieuSinhDuc { get; set; }
        public string ThanKinh { get; set; }
        public string CoXuongKhop { get; set; }
        public string TaiMuiHong { get; set; }
        public string RangHamMat { get; set; }
        public string Mat { get; set; }
        public string Khac_CacCoQuan { get; set; }
        public string CacXetNghiemCanLamSangCanLam { get; set; }
        public string TomTatBenhAn { get; set; }
        public string BenhChinh { get; set; }
        public string BenhKemTheo { get; set; }
        public string PhanBiet { get; set; }
        public string TienLuong { get; set; }
        public string HuongDieuTri { get; set; }
        public string BacSyLamBenhAn { get; set; }
        //
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
        public string HoatDongBanNang { set; get; }
        public string NhoMayMoc { set; get; }
        public string NhoThongHieu { set; get; }
        public string KhaNangPhanTich { set; get; }
        public string KhaNangTongHop { set; get; }
        public string ChuY { set; get; }
    }
    public class BATayChanMieng_KhamBenh : BABase_KhamBenh
    {
        [MoTaDuLieu("Chiều cao")]
		public string ChieuCao { get; set; }
        public string VongNguc { get; set; }
        public string VongDau { get; set; }
        public string SPO2 { get; set; }
        public string TriGiac { get; set; }
        public int GanTo_TieuHoaCo { set; get; }
        public string ToanThan_Khac { set; get; }
        public int TuanHoan_Tim { get; set; }
        public string TuanHoan_TimAmThoi { get; set; }
        public string ThoiGianDayMaoMach { get; set; }
        public int DauHieuTinhMach { get; set; }
        public int VaMoHoi { get; set; }
        public int DaNoiBong { get; set; }
        public string DauHieuKhac_Tim { get; set; }
        public string CacCoQuan_HoHap { get; set; }
        public string RanPhoi { get; set; }
        public string DauHieuKhac_HoHap { get; set; }
        public string GanTo_TieuHoa { get; set; }
        public string DBS_TieuHoa { get; set; }
        public string DauHieuKhac_TieuHoa { get; set; }
        public string DongTu { get; set; }
        public string PXAS { get; set; }
        public string CacCoQuan_ThanKinh { get; set; }
        public string DauHieuKhac_ThanKinh { get; set; }
        public string TMHRHMCoQuanKhac { get; set; }
        public string CacXNCanLamSang { get; set; }
        public int NgayBenh { get; set; }
        public string TTBenhAn { get; set; }
        public string DauHieuKhac_TTBenhAn { get; set; }
        [MoTaDuLieu("Chẩn đoán bệnh")]
		public string ChanDoanBenhChinh { get; set; }
        public string MaICD10 { get; set; }
        public string BenhKem_ChanDoan { get; set; }
        public string MaICD10BenhKem { get; set; }
        public string PhanBiet_ChanDoan { get; set; }
        public string HuongDieuTriArr { get; set; }
        public string HuongDieuTriKhac { get; set; }
    }
    public class BAThanNhanTao_KhamBenh
    {
        #region TrieuChungThanKinhTamThan
        public bool Is_RoiLoanVanDong { get; set; }
        public bool Is_HoiChungMangNao { get; set; }
        public bool Is_RoiLoanCamGiac { get; set; }
        public bool Is_HoiChungTienDinhTieuNao { get; set; }
        public bool Is_TamThanPhanLiet { get; set; }
        public bool Is_HoiChungCacDayTKSoNao { get; set; }
        public bool Is_HoiChungTramCam { get; set; }
        public bool Is_ViemCacDayTKNgoaiVi { get; set; }
        #endregion
        #region CacTrieuChungKhac
        public string DaLieu { get; set; }
        #endregion
        #region XetNghiemSinhHoa
        public string UreMau { get; set; }
        public string CreatinineMau { get; set; }
        public string Na { get; set; }
        public string DuongMau { get; set; }
        public string K { get; set; }
        public string ProtidMau { get; set; }
        public string Ca { get; set; }
        public string AcidUricMau { get; set; }
        public string Cl { get; set; }
        public string CholesterolTF { get; set; }
        public string Phospho { get; set; }
        public string BilirubineTF { get; set; }
        public string Sat { get; set; }
        public string BilirubineTT { get; set; }
        public string BilirubineGT { get; set; }
        public string PhMau { get; set; }
        public string ApLucThamThauMau { get; set; }
        public string SGOT { get; set; }
        public string MucLocCauThan { get; set; }
        public string SGPT { get; set; }
        #endregion
        #region XetNghiemHuyetHoc
        [MoTaDuLieu("Hồng cầu")]
		public string HongCau { get; set; }
        public string AntiHbC { get; set; }
        [MoTaDuLieu("Bạch cầu")]
		public string BachCau { get; set; }
        public string HbeAg { get; set; }
        public string BachCauTrungTinh { get; set; }
        public string BachCauAiToan { get; set; }
        public string BachCauAiKiem { get; set; }
        public string AntiHbeAg { get; set; }
        public string HbsAg { get; set; }
        public string AntiHbsAg { get; set; }
        [MoTaDuLieu("Tiểu cầu")]
		public string TieuCau { get; set; }
        public string AntiHCV { get; set; }
        public string HemoGlobine { get; set; }
        public string KSTSotRet { get; set; }
        public string Hematocrite { get; set; }
        public string DocChat { get; set; }
        [MoTaDuLieu("HIV")]
		public string HIV { get; set; }
        #endregion
    }
    public class BATim_KhamBenh : BABase_KhamBenh
    {
        public string DaNiemMac { get; set; }
        public string Phu { get; set; }
        public string NgonTayChanDuiTrong { get; set; }
        public string HachNgoaiBienTuyenGiap { get; set; }
        public TrieuChungCoNang TrieuChungCoNang { get; set; }
        public string LongNguc { get; set; }
        public string ViTriMomTim { get; set; }
        public string TiengTim { get; set; }
        public string TiengThoiMachCanh { get; set; }
        public string TiengThoiTaiTim { get; set; }
        public string TiengThoiTaiViTriKhac { get; set; }
        public string Bung { get; set; }
        public string CacCoQuanKhac { get; set; }
        [MoTaDuLieu("Chẩn đoán bệnh sơ bộ")]
		public string ChanDoanSoBo { get; set; }
        public string KetQuaXetNghiem { get; set; }
        [MoTaDuLieu("Chẩn đoán bệnh xác định")]
		public string ChanDoanXacDinh { get; set; }
        public string BoXungBenhAn { get; set; }
    }
    public class BAUngBuou_KhamBenh : BABase_KhamBenh
    {
        public string BoPhanTonThuong { set; get; }
        public string BoPhanTonThuongHinhAnh { set; get; }
        public string BoPhanTonThuongMoTa { set; get; }
        public string BenhChinhT { set; get; }
        public string BenhChinhM { set; get; }
        public string BenhChinhN { set; get; }
        public string GiaiDoan { set; get; }
    }
    public class BANgoaiKhoa_KhamBenh : BABase_KhamBenh
    {
        public string BenhNgoaiKhoa { set; get; }
    }
    //bong, dalieu, NgoaiKhoa,NoiKhoa,TruyenNhiem, XaPhuong
    public class BABase_KhamBenh
    {

        public string TuanHoan { set; get; }
        public string SinhDuc { set; get; }
        public string ToanThan { get; set; }
        public string TonThuongBong { set; get; }
        public string HoHap { get; set; }
        public string TieuHoa { get; set; }
        public string ThanTietNieuSinhDuc { get; set; }
        public string ThanKinh { get; set; }
        public string CoXuongKhop { get; set; }
        public string TaiMuiHong { get; set; }
        public string RangHamMat { get; set; }
        public string Mat { get; set; }
        public string Khac_CacCoQuan { get; set; }
        public string CacXetNghiemCanLamSangCanLam { get; set; }
        public string TomTatBenhAn { get; set; }
        public string BenhChinh { get; set; }
        public string BenhKemTheo { get; set; }
        public string PhanBiet { get; set; }
        public string TienLuong { get; set; }
        public string HuongDieuTri { get; set; }
        public string BacSyLamBenhAn { get; set; }
    }

    public class BAMat_TongKet
    {
        [MoTaDuLieu("Chẩn đoán bệnh chính lâm sàng")]
		public string ChanDoanBenhChinh_LamSang { get; set; }
        [MoTaDuLieu("Chẩn đoán bệnh chính nguyên nhân")]
		public string ChanDoanBenhChinh_NguyenNhan { get; set; }
        public string QuaTrinhDieuTri_NoiKhoa { get; set; }
        public bool PhauThuat { set; get; }
        public bool ThuThuat { get; set; }
        public string TinhTrangNguoiBenhRaVien { get; set; }
        public string ThiLucKhiRaVien_KhongKinh_MP { get; set; }
        public string ThiLucKhiRaVien_KhongKinh_MT { get; set; }
        public string ThiLucKhiRaVien_CoKinh_MP { get; set; }
        public string ThiLucKhiRaVien_CoKinh_MT { get; set; }
        public string NhanApRaVien_MT { get; set; }
        public string NhanApRaVien_MP { get; set; }
        public string HuongDieuTriVaCacCheDoTiepTheo { get; set; }
        public string NguoiNhanHoSo { get; set; }
        public string NguoiGiaoHoSo { get; set; }
        [MoTaDuLieu("Bác sỹ điều trị")]
		public string BacSyDieuTri { get; set; }
    }
    public class BANgoaiTruMat_TongKet : BAMat_TongKet
    {

    }
    public class BAMatBanPhanTruoc_TongKet : BAMat_TongKet
    {

    }
    public class BAMatChanThuong_TongKet : BAMat_TongKet
    {

    }
    public class BAMatDayMat_TongKet : BAMat_TongKet
    {

    }
    public class BAMatGlocom_TongKet : BAMat_TongKet
    {

    }
    public class BAMatLac_TongKet : BAMat_TongKet
    {

    }
    public class BAMatTreEm_TongKet : BAMat_TongKet
    {

    }
    public class BANgoaiTru_TongKet : BABase_TongKet
    {
        public string BenhChinh { get; set; }
        public string BenhKemTheo { get; set; }
    }
    public class BANgoaiTruRangHamMat_TongKet : BANgoaiTru_TongKet
    {
    }
    public class BANgoaiTruTaiMuiHong_TongKet : BANgoaiTru_TongKet
    {
    }
    public class BANgoaiTruYHCT_TongKet : BANgoaiTru_TongKet
    {
        public string LyDoVaoVien { get; set; }
        public string KetQuaXetNghiemCanLamSang { set; get; }
        [MoTaDuLieu("Chẩn đoán bệnh vào viện theo y học hiện đại")]
		public string ChanDoanVaoVienTheoYHHD { set; get; }
        public string MICDVaoVienTheoYHHD { set; get; }
        public string CDBenhKemtheoVVYHHD { set; get; }
        public string MICDBenhKemtheoVVYHHD { set; get; }
        [MoTaDuLieu("Chẩn đoán bệnh vào viện theo y học cổ truyền")]
		public string ChanDoanVaoVienTheoYHCT { set; get; }
        public string MICDBenhChinhVVYHCT { set; get; }
        public string CDBenhKemtheoVVYHCT { set; get; }
        public string MICDBenhKemTheoVVYHCT { set; get; }
        public string PhuongPhapDieuTriTheoYHHD { set; get; }
        public string PhuongPhapDieuTriTheoYHCT { set; get; }
        public int KetQuaDieuTriID { get; set; }
        [MoTaDuLieu("Chẩn đoán bệnh theo y học hiện đại")]
		public string ChanDoanRaVienTheoYHHD { set; get; }
        public string MICDRaVienTheoYHHD { set; get; }
        public string CDBenhKemTheoRVYHHD { set; get; }
        public string MICDbenhKemTheoRaVienYHHD { set; get; }
        [MoTaDuLieu("Chẩn đoán bệnh y học cổ truyền")]
		public string ChanDoanRaVienTheoYHCT { set; get; }
        public string MICDBenhChinhRVYHCT { set; get; }
        public string CDBenhKemTheoRaVienTheoYHCT { set; get; }
        public string MICDbenhKemTheoRaVienYHCT { set; get; }
        public string TinhTrangNguoiBenhKhiRavien { set; get; }
        public int ThoiGianDieuTri { set; get; }
    }
    public class BANoiTruYHCT_TongKet : BABase_TongKet
    {
        public string LyDoVaoVien { get; set; }
        [MoTaDuLieu("Chẩn đoán bệnh chính")]
		public string ChanDoanVVYHHD_BenhChinh { get; set; }
        public string MaICDVVYHD_BenhChinh { get; set; }
        [MoTaDuLieu("Chẩn đoán bệnh kèm theo")]
		public string ChanDoanVVYHD_KemTheo { get; set; }
        public string MaICDChanDoanVVYHD_KemTheo { get; set; }
        [MoTaDuLieu("Chẩn đoán bệnh kèm theo")]
		public string ChanDoanVVYHCT_BenhChinh { get; set; }
        public string MaICDChanDoanVVYHCT_BenhChinh { get; set; }
        [MoTaDuLieu("Chẩn đoán bệnh kèm theo")]
		public string ChanDoanVVYHCT_KemTheo { get; set; }
        public string MaICDChanDoanVVYHCT_KemTheo { get; set; }
        public string PhuongPhapDieuTriTheoYHHD { set; get; }
        public string PhuongPhapDieuTriTheoYHCT { set; get; }
        public int KetQuaDieuTriID { get; set; }
        [MoTaDuLieu("Chẩn đoán bệnh chính")]
		public string ChanDoanRVYHHD_BenhChinh { get; set; }
        public string MaICDRVYHD_BenhChinh { get; set; }
        [MoTaDuLieu("Chẩn đoán bệnh kèm theo")]
		public string ChanDoanRVYHD_KemTheo { get; set; }
        public string MaICDChanDoanRVYHD_KemTheo { get; set; }
        [MoTaDuLieu("Chẩn đoán bệnh chính")]
		public string ChanDoanRVYHCT_BenhChinh { get; set; }
        public string MaICDChanDoanRVYHCT_BenhChinh { get; set; }
        [MoTaDuLieu("Chẩn đoán bệnh kèm theo")]
		public string ChanDoanRVYHCT_KemTheo { get; set; }
        public string MaICDChanDoanRVYHCT_KemTheo { get; set; }
    }
    //PhaThaiI, PhaThaiII, PhaThaiIII
    public class BAPhaThaiI_TongKet : BABase_TongKet
    {
        public string Thai { get; set; }
        public int? PhuongPhapPhaThaiTK { get; set; }
        public int? TinhTrangSauKhiPhaThai { get; set; }
        public int? TaiBien { get; set; }
        public string TongSo { get; set; }
        public int? RaVe { get; set; }
        public string LyDoNhapVien { get; set; }
        public string LyDoChuyenTuyen { get; set; }
        public int? BienPhapTranhThaiSauPhaThaiTK { get; set; }
        public string KhamLaiBatThuong { get; set; }
        public string KhamLaiTheoHen { get; set; }
        public string KetLuan { get; set; }
        public string LanhDaoDonVi { get; set; }
        public string NguoiTongKet { get; set; }
    }
    public class BAPhucHoiChucNangYHCT_TongKet : BABase_TongKet
    {
    }
    public class BASanKhoa_TongKet : BABase_TongKet
    {
        public string TenNguoiTheoDoi { get; set; }
        public string ChucDanh { get; set; }
        public string Apgar_1 { get; set; }
        public string Apgar_5 { get; set; }
        public string Apgar_10 { get; set; }
        public double CanNang { get; set; }
        public double CanNangRau { get; set; }
        public double Cao { get; set; }
        public double VongDau { get; set; }
        public bool? DonThai { get; set; }
        public bool? DaThai { get; set; }
        public bool TatBamSinh { get; set; }
        public bool CoHauMon { get; set; }
        public string CuTheDiTatBamSinh { get; set; }
        public string TinhTrangSoSinhSauKhiDe { get; set; }
        public string XuLyVaKetQua { get; set; }
        public bool Rau { get; set; }
        public bool RauCuonCo { get; set; }
        public string CachSoRau { get; set; }
        public string MatMang { get; set; }
        public string MatMui { get; set; }
        public string BanhRau { get; set; }
        public double CanNangSoRau { get; set; }
        public double RauCuonDai { get; set; }
        public double CoChayMauSauSo { get; set; }
        public double LuongMauMat { get; set; }
        public bool KiemSoatTuCung { get; set; }
        public string XuLyVaKetQuaSoRau { get; set; }
        public string DaNiemMac { get; set; }
        public int PhuongPhapDeID { get; set; }
        public string LyDoCanThiep { get; set; }
        public int TangSinhMonID { get; set; }
        public string PhuongPhapKhauChi { get; set; }
        public string ChuanDoanTruocPhauThuat { get; set; }
        public string ChuanDoanSauPhauThuat { get; set; }
        public int CoTuCungID { get; set; }
        public bool TaiBienPhauThuat { get; set; }
        public bool BienChung { get; set; }
        public int LyDoBienChung { get; set; }
        public int iOiVoID { get; set; }
        public int iRau { get; set; }
        public int iDaThai { get; set; }
        public int iDonThai { get; set; }
    }
    public class BAThanNhanTao_TongKet
    {
        #region XetNghiemNuocTieu
        public string ProteineNieu { get; set; }
        public string UreNieu { get; set; }
        public string BachCauNieu { get; set; }
        public string Creatinine { get; set; }
        public string TruNieu { get; set; }
        public string NaNieu { get; set; }
        public string HemoglobineNieu { get; set; }
        public string GlucoseNieu { get; set; }
        #endregion
        #region CacThamDoKhac
        public string X_Quang { get; set; }
        public string SieuAm { get; set; }
        public string DienTim { get; set; }
        public string SinhThiet { get; set; }
        #endregion
        public string BenhChinh { get; set; }
        public string HuongDieuTri { get; set; }
        public string BacSyLamBenhAn { get; set; }
    }
    public class BAUngBuou_TongKet : BABase_TongKet
    {
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
        public string TiaXaHauPhauTaiU { set; get; }
        public string TiaXaHauPhauTaiHach { set; get; }
        public string HoaChat { set; get; }
        public string SoDot { set; get; }
        public string DapUng { set; get; }
        public int DapUngID { set; get; }
        public string DieuTriKhac { set; get; }
    }

    // XaPhuong,CMU,LuuCapCuu,Tim,Bong,DaLieu,
    //HuyetHocTruyenMau,NgoaiKhoa,NhiKhoa,NoiKhoa,PhucHoiChucNang,PhuKhoa,RangHamMat,
    //SoSinh,TaiMuiHong,TamThan ,TayChanMieng, TruyenNhiem, XaPhuong
    public class BABase_TongKet
    {
        public string QuaTrinhBenhLyVaDienBien { get; set; }
        public string TomTatKetQuaXetNghiem { get; set; }
        public string PhuongPhapDieuTri { get; set; }
        public bool PhauThuat { set; get; }
        public bool ThuThuat { get; set; }
        public string TinhTrangNguoiBenhRaVien { get; set; }
        public string HuongDieuTriVaCacCheDoTiepTheo { get; set; }
        public string NguoiNhanHoSo { get; set; }
        public string NguoiGiaoHoSo { get; set; }
        [MoTaDuLieu("Bác sỹ điều trị")]
		public string BacSyDieuTri { get; set; }
    }
    public class BADaLieuTW_TongKet : BABase_TongKet
    {
        public string KQDTDG { get; set; }
        public string TyLe { get; set; }
        public string KQDT_BienChung { get; set; }
        public string KQDT_ChuyenVien { get; set; }
        public string KQDT_TuVong { get; set; }

    }
    //public class NoiDungMau_KhamBenh
    //{
    ////Bệnh án nội khoa
    //public string ToanThan { get; set; }
    //public string TuanHoan { get; set; }
    //public string HoHap { get; set; }
    //public string TieuHoa { get; set; }
    //public string ThanTietNieuSinhDuc { get; set; }
    //public string ThanKinh { get; set; }
    //public string CoXuongKhop { get; set; }
    //public string TaiMuiHong { get; set; }
    //public string RangHamMat { get; set; }
    //public string Mat { get; set; }
    //public string Khac_CacCoQuan { get; set; }
    //public string CacXetNghiemCanLamSangCanLam { get; set; }
    //public string TomTatBenhAn { get; set; }
    //public string BenhChinh { get; set; }
    //public string BenhKemTheo { get; set; }
    //public string PhanBiet { get; set; }
    //public string TienLuong { get; set; }
    //public string HuongDieuTri { get; set; }
    //public string BacSyLamBenhAn { get; set; }
    //}

    //public class NoiDungMau_TongKet
    //{
    //    //Bệnh án nội khoa
    //    public string QuaTrinhBenhLyVaDienBien { get; set; }
    //    public string TomTatKetQuaXetNghiem { get; set; }
    //    public string PhuongPhapDieuTri { get; set; }
    //    public string TinhTrangNguoiBenhRaVien { get; set; }
    //    public string HuongDieuTriVaCacCheDoTiepTheo { get; set; }
    //    public string NguoiNhanHoSo { get; set; }
    //    public string NguoiGiaoHoSo { get; set; }
    //}
    //public class NoiDungMau
    //{
    //    #region
    //    //public string QuaTrinhBenhLy { get; set; }
    //    //public string TienSuBenhBanThan { get; set; }
    //    //public string TienSuBenhGiaDinh { get; set; }

    //    ////MatBanPhanTruoc
    //    //public string NguyenNhan_BenhSu { get; set; }
    //    //public string CacPhuongPhapDaDieuTri_BenhSu { get; set; }
    //    //public string TienSuBenhBanThan_Mat { get; set; }
    //    //public string TienSuBenhGiaDinh_Mat { get; set; }

    //    ////MatChanThuong
    //    //public string Mat { get; set; }

    //    //// MatTreEm
    //    //public string TienSuThaiNghenBenhLy_Text { get; set; }
    //    //public string PhatTrienTriTue_BenhLyText { get; set; }

    //    ////NoiTruYHCT
    //    //public string LyDoVaoVien { get; set; }
    //    //public string BenhSu { get; set; }
    //    //public string ToanThan { get; set; }
    //    //public string TuanHoan { get; set; }
    //    //public string HoHap { get; set; }
    //    //public string TieuHoa { get; set; }
    //    //public string ThanTietNieuSinhDuc { get; set; }
    //    //public string ThanKinh { get; set; }
    //    //public string CoXuongKhop { get; set; }
    //    //public string TaiMuiHong { get; set; }
    //    //public string RangHamMat { get; set; }
    //    //public string Khac_CacCoQuan { get; set; }
    //    //public string MoTaChiTietCoQuanBenhLy { get; set; }
    //    //public string TomTatBenhAn { get; set; }

    //    ////NgoaiTruYHCT
    //    //public string CacBoPhan { get; set; }
    //    //public string TomTatKetQuaCanLamSang { get; set; }

    //    ////SoSinh
    //    //public string HoiBenh { get; set; }

    //    //public string TonThuongBong { get; set; }
    //    //public string SinhDuc { get; set; }
    //    //public string TienLuong { get; set; }
    //    //public string HuongDieuTri { get; set; }
    //    //public string CacXetNghiemCanLamSangCanLam { get; set; }
    //    //public string TrieuChungCoNang { get; set; }
    //    //public string TonThuongCanBan { get; set; }
    //    //public string TinhThanCuaNguoiBenh { get; set; }
    //    //public string HinhDangTuThe { get; set; }
    //    //public string DaNiemMac { get; set; }
    //    //public string TrieuChungXuatHuyet { get; set; }
    //    //public string HeThongLong_Toc_Mong { get; set; }
    //    //public string TrieuChungPhu { get; set; }
    //    //public string TuyenGiap { get; set; }
    //    //public string NoiTiet { get; set; }
    //    //public string ChuaCoBieuHienBenhLy { get; set; }
    //    //public string BenhLy { get; set; }
    //    //public string KetMac_Text_MP { get; set; }
    //    //public string PhanNhanCauTruoc_Text_MP { get; set; }
    //    //public string PhanNhanCauSau_Text_MP { get; set; }
    //    //public string KetMac_MT { get; set; }
    //    //public string PhanNhanCauTruoc_Text_MT { get; set; }
    //    //public string PhanNhanCauSau_Text_MT { get; set; }
    //    //public string MoTaVongChan { get; set; }
    //    //public string MoTaVanChan { get; set; }
    //    //public string MoTaThietChan { get; set; }
    //    //public string TomTatTuChan { get; set; }
    //    //public string BienPhapLuanTri { get; set; }
    //public string ChanDoanBanDau { get; set; }
    //    //public string BenhChuyenKhoa { get; set; }
    //    //public string ChuanDoanCuaKhoaKhamBenh { get; set; }
    //    //public string DaXuLyCuaTuyenDuoi { get; set; }
    //    //public string ChuanDoanPhongKham { get; set; }
    //    //public string MoTa_VanChan { get; set; }
    //    //public string MoTa_VongChan { get; set; }
    //    //public string MoTa_VaanChan { get; set; }
    //    //public string MoTa_XucChan { get; set; }
    //    #endregion
    //    public string LyDoVaoVien { get; set; }
    //    public string QuaTrinhBenhLy { get; set; }
    //    public string TienSuBenhBanThan { get; set; }
    //    public string TienSuBenhGiaDinh { get; set; }
    //    public string ToanThan { get; set; }
    //    public string TuanHoan { get; set; }
    //    public string HoHap { get; set; }
    //    public string TieuHoa { get; set; }
    //    public string ThanTietNieuSinhDuc { get; set; }
    //    public string ThanKinh { get; set; }
    //    public string CoXuongKhop { get; set; }
    //    public string TaiMuiHong { get; set; }
    //    public string RangHamMat { get; set; }
    //    public string Mat { get; set; }
    //    public string Khac_CacCoQuan { get; set; }
    //    public string CacXetNghiemCanLamSangCanLam { get; set; }
    //    public string TomTatBenhAn { get; set; }
    //    public string BenhChinh { get; set; }
    //    public string BenhKemTheo { get; set; }
    //    public string PhanBiet { get; set; }
    //    public string TienLuong { get; set; }
    //    public string HuongDieuTri { get; set; }
    //    public string BacSyLamBenhAn { get; set; }
    //    public string QuaTrinhBenhLyVaDienBien { get; set; }
    //    public string TomTatKetQuaXetNghiem { get; set; }
    //    public string PhuongPhapDieuTri { get; set; }
    //    public string TinhTrangNguoiBenhRaVien { get; set; }
    //    public string HuongDieuTriVaCacCheDoTiepTheo { get; set; }
    //    public string NguoiNhanHoSo { get; set; }
    //    public string NguoiGiaoHoSo { get; set; }
    //    public DacDiemLienQuanBenh DacDiemLienQuanBenh { get; set; }
    //    public string SinhDuc { set; get; }
    //    public string TonThuongBong { set; get; }
    //    public string HinhAnhHoacVe { get; set; }
    //    public bool PhauThuat { set; get; }
    //    public bool ThuThuat { get; set; }
    //    public string TrieuChungCoNang { set; get; }
    //    public string TonThuongCanBan { set; get; }
    //    public string TinhThanCuaNguoiBenh { set; get; }
    //    public string HinhDangTuThe { set; get; }
    //    public string DaNiemMac { set; get; }
    //    public string TrieuChungXuatHuyet { set; get; }
    //    public string HeThongLong_Toc_Mong { set; get; }
    //    public string TrieuChungPhu { set; get; }
    //    public string TuyenGiap { set; get; }
    //    public string KichThuoc_Gan { get; set; }
    //    public string MatDo_Gan { get; set; }
    //    public string Bo_Gan { get; set; }
    //    public string MatGan_Gan { get; set; }
    //    public string Dau_Gan { get; set; }
    //    public string KichThuoc_Lach { get; set; }
    //    public string MatDo_Lach { get; set; }
    //    public string Bo_Lach { get; set; }
    //    public string MatGan_Lach { get; set; }
    //    public string Dau_Lach { get; set; }
    //    public string ViTri_Hach { get; set; }
    //    public string KichThuoc_Hach { get; set; }
    //    public string SoLuong_Hach { get; set; }
    //    public string DoDiDong_Hach { get; set; }
    //    public string MatHach_Hach { get; set; }
    //    public string Dau_Hach { get; set; }
    //    public bool HuyetDo { get; set; }
    //    public bool TuyDo { get; set; }
    //    public bool SinhThietTuy { get; set; }
    //    public bool SinhThietHach { get; set; }
    //    public bool DongMauToanBo { get; set; }
    //    public bool DinhLuongYeuToMauDong { get; set; }
    //    public bool DienDiHST { get; set; }
    //    public bool NhiemSacThe { get; set; }
    //    public bool NhomMau { get; set; }
    //    public bool CoombsTest { get; set; }
    //    public bool KhangTheBatThuong { get; set; }
    //    public bool SinhHoa { get; set; }
    //    public bool GPB { get; set; }
    //    public bool ViSinh { get; set; }
    //    public bool XQuang { get; set; }
    //    public int KhoiHongCau { get; set; }
    //    public int HuyetTuuong { get; set; }
    //    public int HongCauRua { get; set; }
    //    public int HuyetTuongDongLanh { get; set; }
    //    public int KhoiTieuCau { get; set; }
    //    public int TuaVIII { get; set; }
    //    public int KhoiBachCauHat { get; set; }
    //    public int TruyenMauToanPhan { get; set; }
    //    public int CacPhanUngKhiTruyenMau { get; set; }
    //    public string ThoiGianXuatHienBenh { get; set; }
    //    public string NguyenNhan_BenhSu { get; set; }
    //    public string CacPhuongPhapDaDieuTri_BenhSu { get; set; }
    //    public string TienSuBenhBanThan_Mat { get; set; }
    //    public string TienSuBenhGiaDinh_Mat { get; set; }
    //    public string KhongKinh_ThiLuc_MP { get; set; }
    //    public string QuaLo_ThiLuc_MP { get; set; }
    //    public string CoChinhKinh_ThiLuc_MP { get; set; }
    //    public string NhinGan_ThiLuc_MP { get; set; }
    //    public string NhanAp_MP { get; set; }
    //    public string LacVaVanNhan_MP { get; set; }
    //    public bool ThoatNuocTot_MP { get; set; }
    //    public bool TraoLeQuanDoiDien_MP { get; set; }
    //    public bool TraoLeQuanTaiCho_MP { get; set; }
    //    public string MiMat_MP { get; set; }//dunglm
    //    //public int MiMat_MP { get; set; }
    //    public string Khac_MiMat_MP { get; set; }
    //    public bool UMi_MP { get; set; }
    //    public string TinhChatU_UMi_MP { get; set; }
    //    public string ViTri_UMi_MP { get; set; }
    //    public string KichThuoc_UMi_MP { get; set; }
    //    public bool Quam_MiMat_MP { get; set; }
    //    public int MiTren_MiMat_MP { get; set; }
    //    public int MiDuoi_MiMat_MP { get; set; }
    //    public bool HoMi_MiMat_MP { get; set; }
    //    public bool TreMi_MiMat_MP { get; set; }
    //    public int KhuyetMi_MiMat_MP { get; set; }
    //    public int TuyetBoMi_MiMat_MP { get; set; }
    //    public bool ViemBoMi_MiMat_MP { get; set; }
    //    public string TonThuongKhac_MiMat_MP { get; set; }
    //    public int CuongTu_KetMac_MP { get; set; }
    //    public bool PhuNe_KetMac_MP { get; set; }
    //    public bool XuatHuyet_KetMac_MP { get; set; }
    //    public bool SungHoa_KetMac_MP { get; set; }
    //    public bool Nhu_KetMac_MP { get; set; }
    //    public bool Hot_KetMac_MP { get; set; }
    //    public bool Seo_KetMac_MP { get; set; }
    //    public bool TietToMu_KetMac_MP { get; set; }
    //    public bool TietToTrong_KetMac_MP { get; set; }
    //    public bool GiaMac_KetMac_MP { get; set; }
    //    public bool BatMauFluor_KetMac_MP { get; set; }
    //    public string TinhChat_UKetMac_MP { get; set; }
    //    public string ViTri_UKetMac_MP { get; set; }
    //    public string KichThuoc_UKetMac_MP { get; set; }
    //    public int CungDo_KetMac_MP { get; set; }
    //    public int ChieuCaoCuaCauDinh_KetMac_MP { get; set; }
    //    public int DoRongCuaCauDinh_KetMac_MP { get; set; }
    //    public string TonThuongKhac_KetMac_MP { get; set; }
    //    public int KichThuoc_GiacMac_MP { get; set; }
    //    public int HinhDang_GiacMac_MP { get; set; }
    //    public bool BieuMo_GiacMac_MP { get; set; }
    //    public int PhuBongBieuMo_GiacMac_MP { get; set; }
    //    public int MatBieuMo_GiacMac_MP { get; set; }
    //    public int MatBieuMoKhoangCach_MP { get; set; }
    //    public int BoTonThuong_GM_MP { get; set; }
    //    public bool ThoaiThoaDaiBang_MP { get; set; }
    //    public bool LangDongThuoc_MP { get; set; }
    //    public string TonThuongKhac_BieuMo_GM_MP { get; set; }
    //    public int Phu_NhuMo_GiacMac_MP { get; set; }
    //    public int ThamLau_NhuMo_GiacMac_MP { get; set; }
    //    public int ThamLau_Vtri_NhuMo_GiacMac_MP { get; set; }
    //    public int TieuMong_NhuMo_GiacMac_MP { get; set; }
    //    public int TieuMong_Vtri_NhuMo_GiacMac_MP { get; set; }
    //    public string TonThuongKhac_NhuMo_GiacMac_MP { get; set; }
    //    public int NepGap_NoiMo_GiacMac_MP { get; set; }
    //    public bool TuaSacToMacSauGM_MP { get; set; }
    //    public bool MuMatSau_NoiMo_MP { get; set; }
    //    public bool XuatTietMatSau_NoiMo_MP { get; set; }
    //    public bool Guttata_NoiMo_MP { get; set; }
    //    public bool RanMangDescemet_NoiMo_MP { get; set; }
    //    public bool CuonDescemet_NoiMo_MP { get; set; }
    //    public string TonThuongKhac_NoiMo_MP { get; set; }
    //    public bool DoaThung_GiacMac_MP { get; set; }
    //    public bool KetMongMat_GiacMac_MP { get; set; }
    //    public int ThungGiacMac_MP { get; set; }
    //    public bool Seidel_MP { get; set; }
    //    public string DuongKinhThungGiacMac_MP { get; set; }
    //    public bool ThungBit_GM_MP { get; set; }
    //    public int CamGiacGiacMac_MP { get; set; }
    //    public int TanMach_GiacMac_MP { get; set; }
    //    public int MucDo_TanMach_GiacMac_MP { get; set; }
    //    public bool SuyTeBaoNguon_MP { get; set; }
    //    public bool ThoaiHoaGia_MP { get; set; }
    //    public bool LangDongCanXi_MP { get; set; }
    //    public string BatThuongKhac_GiacMac_MP { get; set; }
    //    public int Viem_CungMac_MP { get; set; }
    //    public bool Viem_NongSau_CungMac_MP { get; set; }
    //    public bool ViemThuongCungMac_MP { get; set; }
    //    public int GianLoi_TieuMong_HoaiTu_MP { get; set; }
    //    public string ChiTietKhac_CungMac_MP { get; set; }
    //    public string TienPhong_MP { get; set; }//dunglm
    //    //public int TienPhong_MP { get; set; }
    //    public string Mu_TienPhong_MP { get; set; }
    //    public bool Tydal_MP { get; set; }
    //    public bool MangXuatTiet_MP { get; set; }
    //    public string Mau_TienPhong_MP { get; set; }
    //    public string TonThuongKhac_TienPhong_MP { get; set; }
    //    public bool NauXop_MP { get; set; }
    //    public bool XoTeo_MP { get; set; }
    //    public bool CuongTu_MP { get; set; }
    //    public bool TanMach_MP { get; set; }
    //    public bool Phoi_MP { get; set; }
    //    public bool Ket_MP { get; set; }
    //    public string DuongKinh_DongTu_MP { get; set; }
    //    public int DongTuTronMeoDinh_MP { get; set; }
    //    public string ViTriDinh_DongTu_MP { get; set; }
    //    public int PhanXaDongTu_MP { get; set; }
    //    public string TonThuongKhac_DongTu_MP { get; set; }
    //    public string ThuyTinhThe_MP { get; set; }//dunglm
    //    //public bool ThuyTinhThe_MP { get; set; }
    //    public string HinhThaiDuc_ThuyTinhthe_MP { get; set; }
    //    public int IOL_CanLechDuc_MP { get; set; }
    //    public bool IOL_TrongTPHP_MP { get; set; }
    //    public string TonThuongKhac_ThuyTinhthe_MP { get; set; }
    //    public int AnhDongTu_MP { get; set; }
    //    public int DichKinh_MP { get; set; }
    //    public string TonThuongKhac_DichKinh_MP { get; set; }
    //    public string DayMat_MP { get; set; }//dunglm
    //    //public int DayMat_MP { get; set; }
    //    public string CD_DayMat_MP { get; set; }
    //    public bool PhuGai_MP { get; set; }
    //    public bool BacMauGaiThi_MP { get; set; }
    //    public string VongMac_DayMat_MP { get; set; }
    //    public string HeMachMau_DayMat_MP { get; set; }
    //    public string TonThuongKhac_DayMat_MP { get; set; }
    //    public string KhongKinh_ThiLuc_MT { get; set; }
    //    public string QuaLo_ThiLuc_MT { get; set; }
    //    public string CoChinhKinh_ThiLuc_MT { get; set; }
    //    public string NhinGan_ThiLuc_MT { get; set; }
    //    public string NhanAp_MT { get; set; }
    //    public string LacVaVanNhan_MT { get; set; }
    //    public bool ThoatNuocTot_MT { get; set; }
    //    public bool TraoLeQuanDoiDien_MT { get; set; }
    //    public bool TraoLeQuanTaiCho_MT { get; set; }
    //    public string MiMat_MT { get; set; }//dunglm
    //    //public int MiMat_MT { get; set; }
    //    public string Khac_MiMat_MT { get; set; }
    //    public bool UMi_MT { get; set; }
    //    public string TinhChatU_UMi_MT { get; set; }
    //    public string ViTri_UMi_MT { get; set; }
    //    public string KichThuoc_UMi_MT { get; set; }
    //    public bool Quam_MiMat_MT { get; set; }
    //    public int MiTren_MiMat_MT { get; set; }
    //    public int MiDuoi_MiMat_MT { get; set; }
    //    public bool HoMi_MiMat_MT { get; set; }
    //    public bool TreMi_MiMat_MT { get; set; }
    //    public int KhuyetMi_MiMat_MT { get; set; }
    //    public int TuyetBoMi_MiMat_MT { get; set; }
    //    public bool ViemBoMi_MiMat_MT { get; set; }
    //    public string TonThuongKhac_MiMat_MT { get; set; }
    //    public int CuongTu_KetMac_MT { get; set; }
    //    public bool PhuNe_KetMac_MT { get; set; }
    //    public bool XuatHuyet_KetMac_MT { get; set; }
    //    public bool SungHoa_KetMac_MT { get; set; }
    //    public bool Nhu_KetMac_MT { get; set; }
    //    public bool Hot_KetMac_MT { get; set; }
    //    public bool Seo_KetMac_MT { get; set; }
    //    public bool TietToMu_KetMac_MT { get; set; }
    //    public bool TietToTrong_KetMac_MT { get; set; }
    //    public bool GiaMac_KetMac_MT { get; set; }
    //    public bool BatMauFluor_KetMac_MT { get; set; }
    //    public string TinhChat_UKetMac_MT { get; set; }
    //    public string ViTri_UKetMac_MT { get; set; }
    //    public string KichThuoc_UKetMac_MT { get; set; }
    //    public int CungDo_KetMac_MT { get; set; }
    //    public int ChieuCaoCuaCauDinh_KetMac_MT { get; set; }
    //    public int DoRongCuaCauDinh_KetMac_MT { get; set; }
    //    public string TonThuongKhac_KetMac_MT { get; set; }
    //    public int KichThuoc_GiacMac_MT { get; set; }
    //    public int HinhDang_GiacMac_MT { get; set; }
    //    public bool BieuMo_GiacMac_MT { get; set; }
    //    public int PhuBongBieuMo_GiacMac_MT { get; set; }
    //    public int MatBieuMo_GiacMac_MT { get; set; }
    //    public int MatBieuMoKhoangCach_MT { get; set; }
    //    public int BoTonThuong_GM_MT { get; set; }
    //    public bool ThoaiThoaDaiBang_MT { get; set; }
    //    public bool LangDongThuoc_MT { get; set; }
    //    public string TonThuongKhac_BieuMo_GM_MT_TXT { get; set; }
    //    public int Phu_NhuMo_GiacMac_MT { get; set; }
    //    public int ThamLau_NhuMo_GiacMac_MT { get; set; }
    //    public int ThamLau_Vtri_NhuMo_GiacMac_MT { get; set; }
    //    public int TieuMong_NhuMo_GiacMac_MT { get; set; }
    //    public int TieuMong_Vtri_NhuMo_GiacMac_MT { get; set; }
    //    public string TonThuongKhac_NhuMo_GiacMac_MT { get; set; }
    //    public int NepGap_NoiMo_GiacMac_MT { get; set; }
    //    public bool TuaSacToMacSauGM_MT { get; set; }
    //    public bool MuMatSau_NoiMo_MT { get; set; }
    //    public bool XuatTietMatSau_NoiMo_MT { get; set; }
    //    public bool Guttata_NoiMo_MT { get; set; }
    //    public bool RanMangDescemet_NoiMo_MT { get; set; }
    //    public bool CuonDescemet_NoiMo_MT { get; set; }
    //    public string TonThuongKhac_NoiMo_MT { get; set; }
    //    public bool DoaThung_GiacMac_MT { get; set; }
    //    public bool KetMongMat_GiacMac_MT { get; set; }
    //    public int ThungGiacMac_MT { get; set; }
    //    public bool Seidel_MT { get; set; }
    //    public string DuongKinhThungGiacMac_MT { get; set; }
    //    public bool ThungBit_GM_MT { get; set; }
    //    public int CamGiacGiacMac_MT { get; set; }
    //    public int TanMach_GiacMac_MT { get; set; }
    //    public int MucDo_TanMach_GiacMac_MT { get; set; }
    //    public bool SuyTeBaoNguon_MT { get; set; }
    //    public bool ThoaiHoaGia_MT { get; set; }
    //    public bool LangDongCanXi_MT { get; set; }
    //    public string BatThuongKhac_GiacMac_MT { get; set; }
    //    public int Viem_CungMac_MT { get; set; }
    //    public bool Viem_NongSau_CungMac_MT { get; set; }
    //    public bool ViemThuongCungMac_MT { get; set; }
    //    public int GianLoi_TieuMong_HoaiTu_MT { get; set; }
    //    public string ChiTietKhac_CungMac_MT { get; set; }
    //    public string TienPhong_MT { get; set; }//dunglm
    //    //public int TienPhong_MT { get; set; }
    //    public string Mu_TienPhong_MT { get; set; }
    //    public bool Tydal_MT { get; set; }
    //    public bool MangXuatTiet_MT { get; set; }
    //    public string Mau_TienPhong_MT { get; set; }
    //    public string TonThuongKhac_TienPhong_MT { get; set; }
    //    public bool NauXop_MT { get; set; }
    //    public bool XoTeo_MT { get; set; }
    //    public bool CuongTu_MT { get; set; }
    //    public bool TanMach_MT { get; set; }
    //    public bool Phoi_MT { get; set; }
    //    public bool Ket_MT { get; set; }
    //    public string DuongKinh_DongTu_MT { get; set; }
    //    public int DongTuTronMeoDinh_MT { get; set; }
    //    public string ViTriDinh_DongTu_MT { get; set; }
    //    public int PhanXaDongTu_MT { get; set; }
    //    public string TonThuongKhac_DongTu_MT { get; set; }
    //    public string ThuyTinhThe_MT { get; set; }//dunglm
    //    //public bool ThuyTinhThe_MT { get; set; }
    //    public string HinhThaiDuc_ThuyTinhthe_MT { get; set; }
    //    public int IOL_CanLechDuc_MT { get; set; }
    //    public bool IOL_TrongTPHP_MT { get; set; }
    //    public string TonThuongKhac_ThuyTinhthe_MT { get; set; }
    //    public int AnhDongTu_MT { get; set; }
    //    public int DichKinh_MT { get; set; }
    //    public string TonThuongKhac_DichKinh_MT { get; set; }
    //    public string DayMat_MT { get; set; }//dunglm
    //    //public int DayMat_MT { get; set; }
    //    public string CD_DayMat_MT { get; set; }
    //    public bool PhuGai_MT { get; set; }
    //    public bool BacMauGaiThi_MT { get; set; }
    //    public string VongMac_DayMat_MT { get; set; }
    //    public string HeMachMau_DayMat_MT { get; set; }
    //    public string TonThuongKhac_DayMat_MT { get; set; }
    //    public string HuyetAp_ToanThan { get; set; }
    //    public string NhietDo_ToanThan { get; set; }
    //    public string Mach_ToanThan { get; set; }
    //    public bool NoiTiet_Tick { get; set; }
    //    public string NoiTiet { get; set; }
    //    public bool ThanKinh_Tick { get; set; }
    //    public bool TuanHoan_Tick { get; set; }
    //    public bool HoHap_Tick { get; set; }
    //    public bool TieuHoa_Tick { get; set; }
    //    public bool CoXuongKhop_Tick { get; set; }
    //    public bool ThanTietNieu_Tick { get; set; }
    //    public string BenhChinh_MatPhai { get; set; }
    //    public string BenhChinh_MatTrai { get; set; }
    //    public string PhuongPhapChinh { get; set; }
    //    public string CheDoAnUong { get; set; }
    //    public string CheDoChamSoc { get; set; }
    //public string ChanDoanBenhChinh_LamSang { get; set; }
    //public string ChanDoanBenhChinh_NguyenNhan { get; set; }
    //    public string QuaTrinhDieuTri_NoiKhoa { get; set; }
    //    public string QuaTrinhDieuTri_KetQua { get; set; }
    //    public string QuaTrinhDieuTri_BienChung { get; set; }
    //    public string HuongDieuTriTiep { get; set; }
    //    public string ThiLucKhiVaoVien_KhongKinh_MP { get; set; }
    //    public string ThiLucKhiVaoVien_KhongKinh_MT { get; set; }
    //    public string ThiLucKhiVaoVien_CoKinh_MP { get; set; }
    //    public string ThiLucKhiVaoVien_CoKinh_MT { get; set; }
    //    public string NhanApVaoVien_MT { get; set; }
    //    public string NhanApVaoVien_MP { get; set; }
    //    public string ThiTruong_MP { get; set; }
    //    public string ThiTruong_MT { get; set; }
    //    public bool SupMi_MP { get; set; }
    //    public string SupMi_MP_Text { get; set; }
    //    public int RachMi_MP { get; set; }
    //    public bool RachMi_Khau_MP { get; set; }
    //    public bool LeQuan_MP { get; set; }
    //    public int LeQuan_ID_MP { get; set; }
    //    public bool SeoMi_MP { get; set; }
    //    public string SeoMi_MP_Text { get; set; }
    //    public string CacTonThuongKhac_MiMat_MP { get; set; }
    //    public string KetMac_MP { get; set; }//dunglm
    //    //public bool KetMac_MP { get; set; }
    //    public bool XuatHuyet_MP { get; set; }
    //    public string XuatHuyet_MP_Text { get; set; }
    //    public bool RachKetMac_MP { get; set; }
    //    public string RachKetMac_MP_Text { get; set; }
    //    public bool ThieuMau_MP { get; set; }
    //    public string ThieuMau_MP_Text { get; set; }
    //    public string HinhVeMoTaTonThuongKVV_MP { get; set; }
    //    public string GiacMac_MP { get; set; }//dunglm
    //    //public bool GiacMac_MP { get; set; }
    //    public bool GiacMac_Seo_MP { get; set; }
    //    public string GiacMac_Seo_MP_Text { get; set; }
    //    public bool GiacMac_DiVat_MP { get; set; }
    //    public string GiacMac_DiVat_MP_Text { get; set; }
    //    public bool TuaSauGiacMac_MP { get; set; }
    //    public int TuaSauGiacMac_ID_MP { get; set; }
    //    public bool RachGiacMac_MP { get; set; }
    //    public string RachGiacMac_MP_Text { get; set; }
    //    public string RachGiacMac_MP_Text2 { get; set; }
    //    public int RachGiacMac_ID_MP { get; set; }
    //    public bool DaKhauGiacMac_MP { get; set; }
    //    public bool DungGiaiPhauGiacMac_MP { get; set; }
    //    public string TonThuongKhac_GiacMac_MP { get; set; }
    //    public string CungMac_MP { get; set; }//dunglm
    //    //public bool CungMac_MP { get; set; }
    //    public bool RachCungMac_MP { get; set; }
    //    public string RachCungMac_MP_Text { get; set; }
    //    public string RachCungMac_MP_Text2 { get; set; }
    //    public bool DaKhauCungMac_MP { get; set; }
    //    public bool KetToChucCungMac_MP { get; set; }
    //    public string TonThuongKhac_CungMac_MP { get; set; }
    //    public bool XuatTiet_TienPhong_MP { get; set; }
    //    public string XuatTiet_TienPhong_Text_MP { get; set; }
    //    public bool DiVat_TienPhong_MP { get; set; }
    //    public string DiVat_TienPhong_Text_MP { get; set; }
    //    public string MongMat_MP { get; set; }//dunglm
    //    //public bool MongMat_MP { get; set; }
    //    public bool DutChanMongMat_MP { get; set; }
    //    public string DutChanMongMat_Text_MP { get; set; }
    //    public bool MatMongMat_MP { get; set; }
    //    public string MatMongMat_Text_MP { get; set; }
    //    public bool ThungMongMat_MP { get; set; }
    //    public string ThungMongMat_Text_MP { get; set; }
    //    public string KichThuoc_DongTu_MP { get; set; }
    //    public bool PXDT_MP { get; set; }
    //    public bool TronMeo_DongTu_MP { get; set; }
    //    public bool Dinh_DongTu_MP { get; set; }
    //    public string ViTri_DongTu_MP { get; set; }
    //    public bool GianLiet_DongTu_MP { get; set; }
    //    public bool KhongQuanSatDuoc_ADT_MP { get; set; }
    //    public bool TheThuyTinh_MP { get; set; }
    //    public bool DiVat_TheThuyTinh_MP { get; set; }
    //    public bool SaLech_TheThuyTinh_MP { get; set; }
    //    public bool SaLechID_TheThuyTinh_MP { get; set; }
    //    public bool ViemMu_TheThuyTinh_MP { get; set; }
    //    public bool DaDatIOL_TheThuyTinh_MP { get; set; }
    //    public string DaDatIOL_TheThuyTinh_Text_MP { get; set; }
    //    public string TonThuongKhac_TheThuyTinh_MP { get; set; }
    //    public bool Duc_DichKinh_MP { get; set; }
    //    public bool ViemMu_DichKinh_MP { get; set; }
    //    public bool XuatHuyet_DichKinh_MP { get; set; }
    //    public bool ToChucHoa_DichKinh_MP { get; set; }
    //    public bool Bong_DichKinh_MP { get; set; }
    //    public bool DiVat_DichKinh_MP { get; set; }
    //    public string HeMach_DichKinh_MP { get; set; }
    //    public string DiaThi_DichKinh_MP { get; set; }
    //    public bool Phu_VongMac_MP { get; set; }
    //    public string Phu_VongMac_Text_MP { get; set; }
    //    public bool XuatHuyet_VongMac_MP { get; set; }
    //    public string XuatHuyet_VongMac_Text_MP { get; set; }
    //    public bool Bong_VongMac_MP { get; set; }
    //    public string Bong_VongMac_Text_MP { get; set; }
    //    public bool Rach_VongMac_MP { get; set; }
    //    public string Rach_VongMac_Text_MP { get; set; }
    //    public string ViTriRach_VongMac_Text_MP { get; set; }
    //    public string HinhThaiRach_VongMac_Text_MP { get; set; }
    //    public bool DiVat_VongMac_MP { get; set; }
    //    public string DiVat_VongMac_Text_MP { get; set; }
    //    public string DiVat_VongMac_Text2_MP { get; set; }
    //    public string TonThuongKhac_VongMac_MP { get; set; }
    //    public string HocMat_MP { get; set; }//dunglm
    //    //public bool? HocMat_MP { get; set; }
    //    public string HocMat_Text_MP { get; set; }
    //    public bool DiVat_HocMat_MP { get; set; }
    //    public string DiVat_HocMat_Text_MP { get; set; }
    //    public bool VanNhan_MP { get; set; }
    //    public string VanNhan_Text_MP { get; set; }
    //    public bool NhanCau_MP { get; set; }
    //    public string NhanCau_Text_MP { get; set; }
    //    public bool SupMi_MT { get; set; }
    //    public string SupMi_MT_Text { get; set; }
    //    public int RachMi_MT { get; set; }
    //    public bool RachMi_Khau_MT { get; set; }
    //    public bool LeQuan_MT { get; set; }
    //    public int LeQuan_ID_MT { get; set; }
    //    public bool SeoMi_MT { get; set; }
    //    public string SeoMi_MT_Text { get; set; }
    //    public string CacTonThuongKhac_MiMat_MT { get; set; }
    //    public string KetMac_MT { get; set; }//dunglm
    //    //public bool KetMac_MT { get; set; }
    //    public bool XuatHuyet_MT { get; set; }
    //    public string XuatHuyet_MT_Text { get; set; }
    //    public bool RachKetMac_MT { get; set; }
    //    public string RachKetMac_MT_Text { get; set; }
    //    public bool ThieuMau_MT { get; set; }
    //    public string ThieuMau_MT_Text { get; set; }
    //    public string HinhVeMoTaTonThuongKVV_MT { get; set; }
    //    public string GiacMac_MT { get; set; }//dunglm
    //    //public bool GiacMac_MT { get; set; }
    //    public bool GiacMac_Seo_MT { get; set; }
    //    public string GiacMac_Seo_MT_Text { get; set; }
    //    public bool GiacMac_DiVat_MT { get; set; }
    //    public string GiacMac_DiVat_MT_Text { get; set; }
    //    public bool TuaSauGiacMac_MT { get; set; }
    //    public int TuaSauGiacMac_ID_MT { get; set; }
    //    public bool RachGiacMac_MT { get; set; }
    //    public string RachGiacMac_MT_Text { get; set; }
    //    public string RachGiacMac_MT_Text2 { get; set; }
    //    public int RachGiacMac_ID_MT { get; set; }
    //    public bool DaKhauGiacMac_MT { get; set; }
    //    public bool DungGiaiPhauGiacMac_MT { get; set; }
    //    public string TonThuongKhac_GiacMac_MT { get; set; }
    //    public string CungMac_MT { get; set; }//dunglm
    //    //public bool CungMac_MT { get; set; }
    //    public bool RachCungMac_MT { get; set; }
    //    public string RachCungMac_MT_Text { get; set; }
    //    public string RachCungMac_MT_Text2 { get; set; }
    //    public bool DaKhauCungMac_MT { get; set; }
    //    public bool KetToChucCungMac_MT { get; set; }
    //    public string TonThuongKhac_CungMac_MT { get; set; }
    //    public bool XuatTiet_TienPhong_MT { get; set; }
    //    public string XuatTiet_TienPhong_Text_MT { get; set; }
    //    public bool DiVat_TienPhong_MT { get; set; }
    //    public string DiVat_TienPhong_Text_MT { get; set; }
    //    public string MongMat_MT { get; set; }//dunglm
    //    //public bool MongMat_MT { get; set; }
    //    public bool DutChanMongMat_MT { get; set; }
    //    public string DutChanMongMat_Text_MT { get; set; }
    //    public bool MatMongMat_MT { get; set; }
    //    public string MatMongMat_Text_MT { get; set; }
    //    public bool ThungMongMat_MT { get; set; }
    //    public string ThungMongMat_Text_MT { get; set; }
    //    public string KichThuoc_DongTu_MT { get; set; }
    //    public bool PXDT_MT { get; set; }
    //    public bool TronMeo_DongTu_MT { get; set; }
    //    public bool Dinh_DongTu_MT { get; set; }
    //    public string ViTri_DongTu_MT { get; set; }
    //    public bool GianLiet_DongTu_MT { get; set; }
    //    public bool KhongQuanSatDuoc_ADT_MT { get; set; }
    //    public bool TheThuyTinh_MT { get; set; }
    //    public bool DiVat_TheThuyTinh_MT { get; set; }
    //    public bool SaLech_TheThuyTinh_MT { get; set; }
    //    public bool SaLechID_TheThuyTinh_MT { get; set; }
    //    public bool ViemMu_TheThuyTinh_MT { get; set; }
    //    public bool DaDatIOL_TheThuyTinh_MT { get; set; }
    //    public string DaDatIOL_TheThuyTinh_Text_MT { get; set; }
    //    public string TonThuongKhac_TheThuyTinh_MT { get; set; }
    //    public bool Duc_DichKinh_MT { get; set; }
    //    public bool ViemMu_DichKinh_MT { get; set; }
    //    public bool XuatHuyet_DichKinh_MT { get; set; }
    //    public bool ToChucHoa_DichKinh_MT { get; set; }
    //    public bool Bong_DichKinh_MT { get; set; }
    //    public bool DiVat_DichKinh_MT { get; set; }
    //    public string HeMach_DichKinh_MT { get; set; }
    //    public string DiaThi_DichKinh_MT { get; set; }
    //    public bool Phu_VongMac_MT { get; set; }
    //    public string Phu_VongMac_Text_MT { get; set; }
    //    public bool XuatHuyet_VongMac_MT { get; set; }
    //    public string XuatHuyet_VongMac_Text_MT { get; set; }
    //    public bool Bong_VongMac_MT { get; set; }
    //    public string Bong_VongMac_Text_MT { get; set; }
    //    public bool Rach_VongMac_MT { get; set; }
    //    public string Rach_VongMac_Text_MT { get; set; }
    //    public string ViTriRach_VongMac_Text_MT { get; set; }
    //    public string HinhThaiRach_VongMac_Text_MT { get; set; }
    //    public bool DiVat_VongMac_MT { get; set; }
    //    public string DiVat_VongMac_Text_MT { get; set; }
    //    public string DiVat_VongMac_Text2_MT { get; set; }
    //    public string TonThuongKhac_VongMac_MT { get; set; }
    //    public string HocMat_MT { get; set; }//dunglm
    //    //public bool HocMat_MT { get; set; }
    //    public string HocMat_Text_MT { get; set; }
    //    public bool DiVat_HocMat_MT { get; set; }
    //    public string DiVat_HocMat_Text_MT { get; set; }
    //    public bool VanNhan_MT { get; set; }
    //    public string VanNhan_Text_MT { get; set; }
    //    public bool NhanCau_MT { get; set; }
    //    public string NhanCau_Text_MT { get; set; }
    //    public string HinhVe_VongMac_MP { get; set; }
    //    public string HinhVe_VongMac_MT { get; set; }
    //    public string ChuaCoBieuHienBenhLy { get; set; }
    //    public string BenhLy { get; set; }
    //    public string ThiLucRaVienKhongKinhMPTongKet { get; set; }
    //    public string ThiLucRaVienKhongKinhMTTongKet { get; set; }
    //    public string ThiLucRaVienCoKinhMPTongKet { get; set; }
    //    public string ThiLucRaVienCoKinhMTTongKet { get; set; }
    //    public string NhanApRaVienMPTongKet { get; set; }
    //    public string NhanApRaVienMTTongKet { get; set; }
    //    public bool PhanUngTheMi_MP { get; set; }
    //    public string BenhLyKhac_MP { get; set; }
    //    public bool SeoKetMac_MP { get; set; }
    //    public string SeoKetMac_MP_Text { get; set; }
    //    public string BenhLyKhac_KetMac_MP { get; set; }
    //    public bool GiacMac_Trong_MP { get; set; }
    //    public bool GiacMac_Phu_MP { get; set; }
    //    public bool TuaSauGiacMac_MoiCu_MP { get; set; }
    //    public bool TuaSauGiacMac_MoCuu_MP { get; set; }
    //    public bool TuaSauGiacMac_SacTo_MP { get; set; }
    //    public string ViTriTua_MP { get; set; }
    //    public bool SeoGiacMac_MP { get; set; }
    //    public string BenhLyKhac_GiacMac_MP { get; set; }
    //    public string BenhLyKhac_CungMac_MP { get; set; }
    //    public bool TienPhong_SauSach_MP { get; set; }
    //    public bool TienPhong_XepTienPhong_MP { get; set; }
    //    public bool XuatHuyet_TienPhong_MP { get; set; }
    //    public string XuatHuyet_TienPhong_Text_MP { get; set; }
    //    public bool XuatTuyet_TienPhong_MP { get; set; }
    //    public string XuatTuyet_TienPhong_Text_MP { get; set; }
    //    public bool Tyndall_TienPhong_MP { get; set; }
    //    public string Tyndall_TienPhong_Text_MP { get; set; }
    //    public int GocTienPhong_MP { get; set; }
    //    public bool TanMachMongMat_MP { get; set; }
    //    public string TanMachMongMat_Text_MP { get; set; }
    //    public bool HatKoeppiMongMat_MP { get; set; }
    //    public string HatKoeppiMongMat_Text_MP { get; set; }
    //    public bool HatBussacaMongMat_MP { get; set; }
    //    public string HatBussacaMongMat_Text_MP { get; set; }
    //    public string AnhDongTu_DongTu_MP { get; set; }
    //    public string BenhLyKhac_DongTu_MP { get; set; }
    //    public bool DinhSacTo_TheThuyTinh_MP { get; set; }
    //    public string DichKinh_MP_Text { get; set; }
    //    public string ViemMu_DichKinh_MP_Text { get; set; }
    //    public bool HeMach_VongMac_MP { get; set; }
    //    public int TacDM_VongMac_MP { get; set; }
    //    public int TacTM_VongMac_MP { get; set; }
    //    public bool TacTM_Phu_VongMac_MP { get; set; }
    //    public bool TacTM_ThieuMau_VongMac_MP { get; set; }
    //    public bool TacTM_HonHop_VongMac_MP { get; set; }
    //    public bool ViemMaoMach_VongMac_MP { get; set; }
    //    public bool TanMach_VongMac_MP { get; set; }
    //    public bool TanMachHacMac_MP { get; set; }
    //    public bool DiaThi_VongMac_MP { get; set; }
    //    public int DiaThiID_VongMac_MP { get; set; }
    //    public bool TanMachGai_VongMac_MP { get; set; }
    //    public int TanMachGaiID_VongMac_MP { get; set; }
    //    public bool HoangDiem_VongMac_MP { get; set; }
    //    public bool HoangDiem_Phu_VongMac_MP { get; set; }
    //    public bool HoangDiem_Lo_VongMac_MP { get; set; }
    //    public string HoangDiem_Lo_Do_VongMac_MP { get; set; }
    //    public bool HoangDiem_Seo_VongMac_MP { get; set; }
    //    public bool ThoaiHoa_VongMac_MP { get; set; }
    //    public string ThoaiHoa_VongMac_MP_Text { get; set; }
    //    public bool XuatTiet_VongMac_MP { get; set; }
    //    public bool BongThanhDich_VongMac_MP { get; set; }
    //    public bool OViemHacHac_MP { get; set; }
    //    public string OViemHacHac_MPText1 { get; set; }
    //    public string OViemHacHac_MPText2 { get; set; }
    //    public bool BongVongMac_MP { get; set; }
    //    public string BongVongMac_MP_Text { get; set; }
    //    public bool RachVongMac_MP { get; set; }
    //    public string RachVongMac_MP_Text { get; set; }
    //    public string RachVongMac_MP_Text1 { get; set; }
    //    public string RachVongMac_MP_Text2 { get; set; }
    //    public string RachVongMac_MP_Text3 { get; set; }
    //    public string TonThuongPhoiHop_MP { get; set; }
    //    public string BenhLyKhac_VongMac_MP { get; set; }
    //    public bool PhanUngTheMi_MT { get; set; }
    //    public string BenhLyKhac_MT { get; set; }
    //    public bool SeoKetMac_MT { get; set; }
    //    public string SeoKetMac_MT_Text { get; set; }
    //    public string BenhLyKhac_KetMac_MT { get; set; }
    //    public bool GiacMac_Trong_MT { get; set; }
    //    public bool GiacMac_Phu_MT { get; set; }
    //    public bool TuaSauGiacMac_MoiCu_MT { get; set; }
    //    public bool TuaSauGiacMac_MoCuu_MT { get; set; }
    //    public bool TuaSauGiacMac_SacTo_MT { get; set; }
    //    public string ViTriTua_MT { get; set; }
    //    public bool SeoGiacMac_MT { get; set; }
    //    public string BenhLyKhac_GiacMac_MT { get; set; }
    //    public string BenhLyKhac_CungMac_MT { get; set; }
    //    public bool TienPhong_SauSach_MT { get; set; }
    //    public bool TienPhong_XepTienPhong_MT { get; set; }
    //    public bool XuatHuyet_TienPhong_MT { get; set; }
    //    public string XuatHuyet_TienPhong_Text_MT { get; set; }
    //    public bool XuatTuyet_TienPhong_MT { get; set; }
    //    public string XuatTuyet_TienPhong_Text_MT { get; set; }
    //    public bool Tyndall_TienPhong_MT { get; set; }
    //    public string Tyndall_TienPhong_Text_MT { get; set; }
    //    public int GocTienPhong_MT { get; set; }
    //    public bool TanMachMongMat_MT { get; set; }
    //    public string TanMachMongMat_Text_MT { get; set; }
    //    public bool HatKoeppiMongMat_MT { get; set; }
    //    public string HatKoeppiMongMat_Text_MT { get; set; }
    //    public bool HatBussacaMongMat_MT { get; set; }
    //    public string HatBussacaMongMat_Text_MT { get; set; }
    //    public string AnhDongTu_DongTu_MT { get; set; }
    //    public string BenhLyKhac_DongTu_MT { get; set; }
    //    public bool DinhSacTo_TheThuyTinh_MT { get; set; }
    //    public string DichKinh_MT_Text { get; set; }
    //    public string ViemMu_DichKinh_MT_Text { get; set; }
    //    public bool HeMach_VongMac_MT { get; set; }
    //    public int TacDM_VongMac_MT { get; set; }
    //    public int TacTM_VongMac_MT { get; set; }
    //    public bool TacTM_Phu_VongMac_MT { get; set; }
    //    public bool TacTM_ThieuMau_VongMac_MT { get; set; }
    //    public bool TacTM_HonHop_VongMac_MT { get; set; }
    //    public bool ViemMaoMach_VongMac_MT { get; set; }
    //    public bool TanMach_VongMac_MT { get; set; }
    //    public bool TanMachHacMac_MT { get; set; }
    //    public bool DiaThi_VongMac_MT { get; set; }
    //    public int DiaThiID_VongMac_MT { get; set; }
    //    public bool TanMachGai_VongMac_MT { get; set; }
    //    public int TanMachGaiID_VongMac_MT { get; set; }
    //    public bool HoangDiem_VongMac_MT { get; set; }
    //    public bool HoangDiem_Phu_VongMac_MT { get; set; }
    //    public bool HoangDiem_Lo_VongMac_MT { get; set; }
    //    public string HoangDiem_Lo_Do_VongMac_MT { get; set; }
    //    public bool HoangDiem_Seo_VongMac_MT { get; set; }
    //    public bool ThoaiHoa_VongMac_MT { get; set; }
    //    public string ThoaiHoa_VongMac_MT_Text { get; set; }
    //    public bool XuatTiet_VongMac_MT { get; set; }
    //    public bool BongThanhDich_VongMac_MT { get; set; }
    //    public bool OViemHacHac_MT { get; set; }
    //    public bool OViemHacHac_MTText1 { get; set; }
    //    public bool OViemHacHac_MTText2 { get; set; }
    //    public bool BongVongMac_MT { get; set; }
    //    public string BongVongMac_MT_Text { get; set; }
    //    public bool RachVongMac_MT { get; set; }
    //    public string RachVongMac_MT_Text { get; set; }
    //    public string RachVongMac_MT_Text1 { get; set; }
    //    public string RachVongMac_MT_Text2 { get; set; }
    //    public string RachVongMac_MT_Text3 { get; set; }
    //    public string TonThuongPhoiHop_MT { get; set; }
    //    public string BenhLyKhac_VongMac_MT { get; set; }
    //    public int NhucMat { get; set; }
    //    public int Nhin { get; set; }
    //    public bool SoAnhSang { get; set; }
    //    public bool DoMat { get; set; }
    //    public int ToanThan_LDDK { get; set; }
    //    public string Khac_LDDK { get; set; }
    //    public bool CoSoDaDieuTri_Huyen { get; set; }
    //    public bool CoSoDaDieuTri_Tinh { get; set; }
    //    public bool CoSoDaDieuTri_TrungUong { get; set; }
    //    public bool CoSoDaDieuTri_Khac { get; set; }
    //    public bool PhuongPhapDaDieuTri_Thuoc { get; set; }
    //    public bool PhuongPhapDaDieuTri_PhauThuat { get; set; }
    //    public bool PhuongPhapDaDieuTri_Laser { get; set; }
    //    public int LoaiPhauThuatMatLan1_MP { get; set; }
    //    public string ThoiDiemPhauThuatLan1_MP { get; set; }
    //    public int NoiPhauThuatLan1_MP { get; set; }
    //    public int LoaiPhauThuatMatLan2_MP { get; set; }
    //    public string ThoiDiemPhauThuatLan2_MP { get; set; }
    //    public int NoiPhauThuatLan2_MP { get; set; }
    //    public int LoaiPhauThuatMatLan3_MP { get; set; }
    //    public string ThoiDiemPhauThuatLan3_MP { get; set; }
    //    public int NoiPhauThuatLan3_MP { get; set; }
    //    public int LoaiPhauThuatMatLan4_MP { get; set; }
    //    public string ThoiDiemPhauThuatLan4_MP { get; set; }
    //    public int NoiPhauThuatLan4_MP { get; set; }
    //    public int NoiPhauThuatLan1_MT { get; set; }
    //    public int LoaiPhauThuatMatLan2_MT { get; set; }
    //    public string ThoiDieMThauThuatLan2_MT { get; set; }
    //    public int NoiPhauThuatLan2_MT { get; set; }
    //    public int LoaiPhauThuatMatLan3_MT { get; set; }
    //    public string ThoiDieMThauThuatLan3_MT { get; set; }
    //    public int NoiPhauThuatLan3_MT { get; set; }
    //    public int LoaiPhauThuatMatLan4_MT { get; set; }
    //    public string ThoiDieMThauThuatLan4_MT { get; set; }
    //    public int NoiPhauThuatLan4_MT { get; set; }
    //    public int ThuocHaNhanApDaDung_Loai { get; set; }
    //    public int ThuocHaNhanApDaDung_SoLuong { get; set; }
    //    public string CacThuocKhac { get; set; }
    //    public string TienTrinhDieuTri { get; set; }
    //    public bool TienSuBenhMat_CanThi { get; set; }
    //    public bool TienSuBenhMat_VienThi { get; set; }
    //    public bool TienSuBenhMat_ChanThuong { get; set; }
    //    public bool TienSuBenhMat_VienMangBoDao { get; set; }
    //    public bool TienSuBenhMat_ViemPhanTruoc { get; set; }
    //    public bool TienSuBenhMat_TacTMTTVM { get; set; }
    //    public bool TienSuBenhMat_DaPhauThuat { get; set; }
    //    public string TienSuBenhMat_DaPhauThuat_Text { get; set; }
    //    public bool TienSuBenhMat_BenhKhac { get; set; }
    //    public string TienSuBenhMat_BenhKhac_Text { get; set; }
    //    public string Corticosteroid_TenThuoc { get; set; }
    //    public string Corticosteroid_ThoiGianSuDung { get; set; }
    //    public int Corticosteroid_DuongDung { get; set; }
    //    public bool Corticosteroid_TheoBacSy { get; set; }
    //    public bool TienSuBenhTT_TimMach { get; set; }
    //    public bool TienSuBenhTT_HuyetAp { get; set; }
    //    public bool TienSuBenhTT_DaiDuong { get; set; }
    //    public bool TienSuBenhTT_RoDongMachCanh { get; set; }
    //    public bool TienSuBenhTT_BenhKhac { get; set; }
    //    public string TienSuBenhTT_BenhKhac_Text { get; set; }
    //    public bool TienSuBenhGD_OngBa { get; set; }
    //    public bool TienSuBenhGD_BoMe { get; set; }
    //    public bool TienSuBenhGD_AnhChiEm { get; set; }
    //    public bool TienSuBenhGD_CoDiChuBac { get; set; }
    //    public string ThiLucVaoVien_KoKinh_MP { get; set; }
    //    public string ThiLucVaoVien_CoKinh_MP { get; set; }
    //    public bool MiMat_SungNe_MP { get; set; }
    //    public string MiMat_Khac_MP { get; set; }
    //    public bool KetMac_CuongTu_MP { get; set; }
    //    public bool KetMac_SeoMoCu_MP { get; set; }
    //    public string KetMac_SeoMoCu_Text_MP { get; set; }
    //    public int KetMac_BongDo_MP { get; set; }
    //    public int GiacMac_TTTrongSuot_MP { get; set; }
    //    public bool GiacMac_PhuNe_MP { get; set; }
    //    public string GiacMac_PhuNe_Text_MP { get; set; }
    //    public string GiacMac_DoDay_MP { get; set; }
    //    public string GiacMac_Tua_MP { get; set; }
    //    public string GiacMac_DuongKinh_MP { get; set; }
    //    public bool CungMac_DanLoi_MP { get; set; }
    //    public bool CungMac_SeoMo_MP { get; set; }
    //    public string CungMac_SeoMo_Text_MP { get; set; }
    //    public string TienPhong_DoSau_MP { get; set; }
    //    public int TienPhong_Herick_MP { get; set; }
    //    public string GocTienPhong_HinhAnh_MP { get; set; }
    //    public string GocTienPhong_DauHieuKhac_MP { get; set; }
    //    public string MongMat_MauSac_MP { get; set; }
    //    public bool MongMat_TTThoaiHoa_MP { get; set; }
    //    public string MongMat_TTThoaiHoa_Text_MP { get; set; }
    //    public bool MongMat_TanMach_MP { get; set; }
    //    public bool DongTu_MP { get; set; }
    //    public string DongTu_DuongKinh_MP { get; set; }
    //    public string DongTu_VienSacTo_MP { get; set; }
    //    public int DongTu_PhanXa_MP { get; set; }
    //    public bool TheThuyTinh_TrongDuc_MP { get; set; }
    //    public int TheThuyTinh_ViTri_MP { get; set; }
    //    public string DayMat_VongMac_MP { get; set; }
    //    public string DayMat_HoangDiem_MP { get; set; }
    //    public bool DayMat_TanMach_MP { get; set; }
    //    public bool DayMat_XuatHuyet_MP { get; set; }
    //    public bool DiaThiGiac_VienTK_MP { get; set; }
    //    public int DiaThiGiac_VienTKVTri_MP { get; set; }
    //    public string DiaThiGiac_MauSac_MP { get; set; }
    //    public string DiaThiGiac_CD_MP { get; set; }
    //    public int DiaThiGiac_MachMau_MP { get; set; }
    //    public bool DiaThiGiac_XuatHuyet_MP { get; set; }
    //    public bool DiaThiGiac_TeoCanhGai_MP { get; set; }
    //    public string ThiLucVaoVien_KoKinh_MT { get; set; }
    //    public string ThiLucVaoVien_CoKinh_MT { get; set; }
    //    public bool MiMat_SungNe_MT { get; set; }
    //    public string MiMat_Khac_MT { get; set; }
    //    public bool KetMac_CuongTu_MT { get; set; }
    //    public bool KetMac_SeoMoCu_MT { get; set; }
    //    public string KetMac_SeoMoCu_Text_MT { get; set; }
    //    public int KetMac_BongDo_MT { get; set; }
    //    public int GiacMac_TTTrongSuot_MT { get; set; }
    //    public bool GiacMac_PhuNe_MT { get; set; }
    //    public string GiacMac_PhuNe_Text_MT { get; set; }
    //    public string GiacMac_DoDay_MT { get; set; }
    //    public string GiacMac_Tua_MT { get; set; }
    //    public string GiacMac_DuongKinh_MT { get; set; }
    //    public bool CungMac_DanLoi_MT { get; set; }
    //    public bool CungMac_SeoMo_MT { get; set; }
    //    public string CungMac_SeoMo_Text_MT { get; set; }
    //    public string TienPhong_DoSau_MT { get; set; }
    //    public int TienPhong_Herick_MT { get; set; }
    //    public string GocTienPhong_HinhAnh_MT { get; set; }
    //    public string GocTienPhong_DauHieuKhac_MT { get; set; }
    //    public string MongMat_MauSac_MT { get; set; }
    //    public bool MongMat_TTThoaiHoa_MT { get; set; }
    //    public string MongMat_TTThoaiHoa_Text_MT { get; set; }
    //    public bool MongMat_TanMach_MT { get; set; }
    //    public bool DongTu_MT { get; set; }
    //    public string DongTu_DuongKinh_MT { get; set; }
    //    public string DongTu_VienSacTo_MT { get; set; }
    //    public int DongTu_PhanXa_MT { get; set; }
    //    public bool TheThuyTinh_TrongDuc_MT { get; set; }
    //    public int TheThuyTinh_ViTri_MT { get; set; }
    //    public string DayMat_VongMac_MT { get; set; }
    //    public string DayMat_HoangDiem_MT { get; set; }
    //    public bool DayMat_TanMach_MT { get; set; }
    //    public bool DayMat_XuatHuyet_MT { get; set; }
    //    public bool DiaThiGiac_VienTK_MT { get; set; }
    //    public int DiaThiGiac_VienTKVTri_MT { get; set; }
    //    public string DiaThiGiac_MauSac_MT { get; set; }
    //    public string DiaThiGiac_CD_MT { get; set; }
    //    public int DiaThiGiac_MachMau_MT { get; set; }
    //    public bool DiaThiGiac_XuatHuyet_MT { get; set; }
    //    public bool DiaThiGiac_TeoCanhGai_MT { get; set; }       
    //    public string BenhKemTheo_MatPhai { get; set; }
    //    public string BenhKemTheo_MatTrai { get; set; }
    //    public string BenhToanThan { get; set; }
    //    public string ChiDinhDieuTri { get; set; }
    //    [MoTaDuLieu("Chẩn đoán bệnh")]
    //public string ChanDoanKhiRV_MatPhai { get; set; }
    //    public string MaICDChanDoanKhiRV_MatPhai { get; set; }
    //    [MoTaDuLieu("Chẩn đoán bệnh")]
    //public string ChanDoanKhiRV_MatTrai { get; set; }
    //    public string MaICDChanDoanKhiRV_MatTrai { get; set; }
    //    public string PhuongPhapDieuTri_PhauThuat { get; set; }
    //    public bool PhuongPhapDieuTri_PThuat_Tick { get; set; }
    //    public string PhuongPhapDieuTri_Laser { get; set; }
    //    public bool PhuongPhapDieuTri_Laser_Tick { get; set; }
    //    public string PhuongPhapDieuTri_Thuoc { get; set; }
    //    public bool PhuongPhapDieuTri_Thuoc_Tick { get; set; }
    //    public string TinhTrangRaVienMP { get; set; }
    //    public string TinhTrangRaVienMT { get; set; }       
    //    public string HuongDieuTriTiep_TheoDoi { get; set; }
    //    public bool HuongDieuTriTiep_TheoDoi_Tick { get; set; }
    //    public string HuongDieuTriTiep_PhauThuat { get; set; }
    //    public bool HuongDieuTriTiep_PThuat_Tick { get; set; }
    //    public string HuongDieuTriTiep_Laser { get; set; }
    //    public bool HuongDieuTriTiep_Laser_Tick { get; set; }
    //    public string HuongDieuTriTiep_Thuoc { get; set; }
    //    public bool HuongDieuTriTiep_Thuoc_Tick { get; set; }       
    //    public bool LyDoVaoVien_Lac { get; set; }
    //    public bool LyDoVaoVien_SupMi { get; set; }
    //    public bool LyDoVaoVien_Khac { get; set; }
    //    public bool QuaTrinhBenhLy_NguyenNhan { get; set; }
    //    public string NguyenNhan_TuBaoGio { get; set; }
    //    public int TrieuChungChinh { get; set; }
    //    public bool TrieuChung_SupMi { get; set; }
    //    public bool TrieuChung_RungGiatNhanCau { get; set; }
    //    public bool TrieuChung_Khac { get; set; }
    //    public string TrieuChung_Khac_Text { get; set; }
    //    public bool DaDieuTri_TapNhuocThi { get; set; }
    //    public string TapNhuocThi_PhuongPhap { get; set; }
    //    public int TapNhuocThi_KetQua { get; set; }
    //    public bool DaDieuTri_PhauThuat { get; set; }
    //    public string DaDieuTri_PhauThuat_PhuongPhap { get; set; }
    //    public bool KetQua_PhauThuat_Tot { get; set; }
    //    public bool KetQua_PhauThuat_MoNon { get; set; }
    //    public string KetQua_PhauThuat_MoNon_Text { get; set; }
    //    public bool KetQua_PhauThuat_MoGia { get; set; }
    //    public string KetQua_PhauThuat_MoGiaText { get; set; }
    //    public bool TienSuBenhBanThan_Tick { get; set; }
    //    public bool TienSuBenhGiaDinh_Tick { get; set; }
    //    public string KhucXaMay_TruocAtropine_MP { get; set; }
    //    public string KhucXaMay_SauAtropine_MP { get; set; }
    //    public string KhucXaMay_SauAtropine_MT { get; set; }
    //    public string KhucXaMay_TruocAtropine_MT { get; set; }
    //    public bool VanNhanNoiTai_MP { get; set; }
    //    public string VanNhanNoiTai_Text_MP { get; set; }
    //    public bool VanNhanNoiTai_MT { get; set; }
    //    public string VanNhanNoiTai_TextMT { get; set; }
    //    public bool DiemCanQuyTu { get; set; }
    //    public string DiemCanQuyTu_Text { get; set; }
    //    public bool RungGiatNhanCau { get; set; }
    //    public string RungGiatNhanCau_Text { get; set; }
    //    public string KieuRGNC { get; set; }
    //    public bool GocHam { get; set; }
    //    public int ThiNghiemCheMat { get; set; }
    //    public string HinhThaiVaTinhChatLac { get; set; }
    //    public string Hirschberg_Truoc_atropine { get; set; }
    //    public string Hirschberg_Sau_atropine { get; set; }
    //    public string LangKinh_Truoc_atropine { get; set; }
    //    public string LangKinh_Sau_atropine { get; set; }
    //    public string NhinGan { get; set; }
    //    public string NhinLen { get; set; }
    //    public string NhinXa { get; set; }
    //    public string NhinXuong { get; set; }
    //    public string HoiChung { get; set; }
    //    public string Synoptophore_KhacQuan { get; set; }
    //    public string Synoptophore_ChuQuan { get; set; }
    //    public int TinhTrangThiGiacHaiMat { get; set; }
    //    public string TinhTrangThiGiacHaiMat_Text { get; set; }
    //    public string BienDoHopThi { get; set; }
    //    public bool TuongUngVongMac { get; set; }
    //    public bool SongThi { get; set; }
    //    public string SongThi_Text { get; set; }
    //    public bool TuTheBuTru { get; set; }
    //    public string TuTheBuTru_Text { get; set; }
    //    public int SupMi_MucDo_MP { get; set; }
    //    public bool Epicanthus_MP { get; set; }
    //    public int CoNangMi_MP { get; set; }
    //    public bool Marcusgunn_MP { get; set; }
    //    public bool Bell_MP { get; set; }
    //    public string KetMac_Text_MP { get; set; }
    //    public bool PhanNhanCauTruoc_MP { get; set; }
    //    public string PhanNhanCauTruoc_Text_MP { get; set; }
    //    public bool PhanNhanCauSau_MP { get; set; }
    //    public string PhanNhanCauSau_Text_MP { get; set; }
    //    public int DinhThi_MP { get; set; }
    //    public int SupMi_MucDo_MT { get; set; }
    //    public bool Epicanthus_MT { get; set; }
    //    public int CoNangMi_MT { get; set; }
    //    public bool Marcusgunn_MT { get; set; }
    //    public bool Bell_MT { get; set; }
    //    public string KetMac_Text_MT { get; set; }
    //    public bool PhanNhanCauTruoc_MT { get; set; }
    //    public string PhanNhanCauTruoc_Text_MT { get; set; }
    //    public bool PhanNhanCauSau_MT { get; set; }
    //    public string PhanNhanCauSau_Text_MT { get; set; }
    //    public int DinhThi_MT { get; set; }
    //    public string MaICD_BenhChinh { get; set; }
    //    public string MaICD_BenhKemTheo { get; set; }
    //    public bool DaDieuTri_NoiKhoa { get; set; }
    //    public bool NguyenNhan_BamSinh { get; set; }
    //    public bool TrieuChung_NhinMo { get; set; }
    //    public bool TrieuChung_DauNhuc { get; set; }
    //    public bool TrieuChung_DoMat { get; set; }
    //    public bool TrieuChung_ChoiMat { get; set; }
    //    public bool TienSuThaiNghenBenhLy { get; set; }
    //    public string TienSuThaiNghenBenhLy_Text { get; set; }
    //    public bool PhatTrienTriTue { get; set; }
    //    public string PhatTrienTriTue_BenhLyText { get; set; }        
    //    public string VanNhanNoiTai_Text_MT { get; set; }
    //    public bool VanNhanNgoaiLai_MP { get; set; }
    //    public string VanNhanNgoaiLai_Text_MP { get; set; }
    //    public bool VanNhanNgoaiLai_MT { get; set; }
    //    public string VanNhanNgoaiLai_Text_MT { get; set; }
    //    public bool MiMat_Quam_MP { get; set; }
    //    public bool MIMat_Epicanthus { get; set; }
    //    public bool MiMat_SupMi_MP { get; set; }
    //    public bool MiMat_U_MP { get; set; }
    //    public string LeDao_MP { get; set; }
    //    public bool KetMac_XuatHuyet_MP { get; set; }
    //    public bool KetMac_XuatTiet_MP { get; set; }
    //    public bool KetMac_U_MP { get; set; }
    //    public string KetMac_Khac_MP { get; set; }
    //    public string GiacMac_Trong_Text_MP { get; set; }
    //    public bool GiacMac_LoaiDuong_MP { get; set; }
    //    public string GiacMac_LoanDuong_Text_MP { get; set; }
    //    public bool GiacMac_ThoaiHoa_MP { get; set; }
    //    public string GiacMac_ThoaiHoa_Text_MP { get; set; }
    //    public string GiacMac_U_MP { get; set; }
    //    public string GiacMac_Loet_MP { get; set; }
    //    public string GiacMac_DiTat_MP { get; set; }
    //    public string GiacMac_DuongKinhGM_MP { get; set; }
    //    public string GiacMac_VungRia_MP { get; set; }
    //    public string GiacMac_Khac_MP { get; set; }
    //    public bool CungMac_GianLoi_MP { get; set; }
    //    public string CungMac_CuongTu_MP { get; set; }
    //    public string CungMac_Viem_MP { get; set; }
    //    public string CungMac_Khac_MP { get; set; }
    //    public bool TienPhong_Tydall_MP { get; set; }
    //    public bool TienPhong_Mu_MP { get; set; }
    //    public string TienPhong_Mau_MP { get; set; }
    //    public string TienPhong_GocTienPhong_MP { get; set; }
    //    public bool MongMat_TinhTrang_MP { get; set; }
    //    public bool MongMat_CamGiac_MP { get; set; }
    //    public string MongMat_U_MP { get; set; }
    //    public string MongMat_DiDang_MP { get; set; }
    //    public bool DongTu_Trong_MP { get; set; }
    //    public string DongTu_DiDang_MP { get; set; }
    //    public string DichKinh_Text_MP { get; set; }
    //    public string DayMat_MachMau_MP { get; set; }
    //    public string DayMat_DiaThi_MP { get; set; }
    //    public string DayMat_U_MP { get; set; }
    //    public bool NhanCau_Mem_MP { get; set; }
    //    public int NhanCau_To_MP { get; set; }
    //    public bool MiMat_Quam_MT { get; set; }
    //    public bool MIMat_EpicanthusMT { get; set; }
    //    public bool MiMat_SupMi_MT { get; set; }
    //    public bool MiMat_U_MT { get; set; }
    //    public string LeDao_MT { get; set; }
    //    public bool KetMac_XuatHuyet_MT { get; set; }
    //    public bool KetMac_XuatTiet_MT { get; set; }
    //    public bool KetMac_U_MT { get; set; }
    //    public string KetMac_Khac_MT { get; set; }
    //    public string GiacMac_Trong_Text_MT { get; set; }
    //    public bool GiacMac_LoaiDuong_MT { get; set; }
    //    public string GiacMac_LoanDuong_Text_MT { get; set; }
    //    public bool GiacMac_ThoaiHoa_MT { get; set; }
    //    public string GiacMac_ThoaiHoa_Text_MT { get; set; }
    //    public string GiacMac_U_MT { get; set; }
    //    public string GiacMac_Loet_MT { get; set; }
    //    public string GiacMac_DiTat_MT { get; set; }
    //    public string GiacMac_DuongKinhGM_MT { get; set; }
    //    public string GiacMac_VungRia_MT { get; set; }
    //    public string GiacMac_Khac_MT { get; set; }
    //    public bool CungMac_GianLoi_MT { get; set; }
    //    public string CungMac_CuongTu_MT { get; set; }
    //    public string CungMac_Viem_MT { get; set; }
    //    public string CungMac_Khac_MT { get; set; }
    //    public bool TienPhong_Tydall_MT { get; set; }
    //    public bool TienPhong_Mu_MT { get; set; }
    //    public string TienPhong_Mau_MT { get; set; }
    //    public string TienPhong_GocTienPhong_MT { get; set; }
    //    public bool MongMat_TinhTrang_MT { get; set; }
    //    public bool MongMat_CamGiac_MT { get; set; }
    //    public string MongMat_U_MT { get; set; }
    //    public string MongMat_DiDang_MT { get; set; }
    //    public bool DongTu_Trong_MT { get; set; }
    //    public string DongTu_DiDang_MT { get; set; }
    //    public string DichKinh_Text_MT { get; set; }       
    //    public string DayMat_MachMau_MT { get; set; }
    //    public string DayMat_DiaThi_MT { get; set; }
    //    public string DayMat_U_MT { get; set; }
    //    public bool NhanCau_Mem_MT { get; set; }
    //    public int NhanCau_To_MT { get; set; }
    //    public string BenhSu { get; set; }
    //    public string MoTaChiTietCoQuanBenhLy { get; set; }
    //    public bool HinhThai_Gay { get; set; }
    //    public bool HinhThai_Beo { get; set; }
    //    public bool HinhThai_CanDoi { get; set; }
    //    public bool HinhThai_NamCo { get; set; }
    //    public bool HinhThai_UaTinh { get; set; }
    //    public bool HinhThai_NamDuoi { get; set; }
    //    public bool HinhThai_HieuDong { get; set; }
    //    public bool HinhThai_Khac { get; set; }
    //    public bool Than_ConThan { get; set; }
    //    public bool Than_KhongConThan { get; set; }
    //    public bool Than_Khac { get; set; }
    //    public bool Sac_BechTrang { get; set; }
    //    public bool Sac_Do { get; set; }
    //    public bool Sac_Vang { get; set; }
    //    public bool Sac_Xanh { get; set; }
    //    public bool Sac_Den { get; set; }
    //    public bool Sac_Khac { get; set; }
    //    public bool Sac_BinhThuong { get; set; }
    //    public bool Trach_TuoiNhuan { get; set; }
    //    public bool Trach_Kho { get; set; }
    //    public bool Trach_Khac { get; set; }
    //    public bool ChatLuoi_BinhThuong { get; set; }
    //    public bool ChatLuoi_Beu { get; set; }
    //    public bool ChatLuoi_GayMong { get; set; }
    //    public bool ChatLuoi_Nut { get; set; }
    //    public bool ChatLuoi_Cung { get; set; }
    //    public bool ChatLuoi_Loet { get; set; }
    //    public bool ChatLuoi_Lech { get; set; }
    //    public bool ChatLuoi_Rut { get; set; }
    //    public bool ChatLuoi_Khac { get; set; }
    //    public bool SacLuoi_Hong { get; set; }
    //    public bool SacLuoi_Nhot { get; set; }
    //    public bool SacLuoi_Do { get; set; }
    //    public bool SacLuoi_DoSam { get; set; }
    //    public bool SacLuoi_XanhTim { get; set; }
    //    public bool SacLuoi_DamUHuyet { get; set; }
    //    public bool SacLuoi_Kho { get; set; }
    //    public bool SacLuoi_Nhuan { get; set; }
    //    public bool SacLuoi_Khac { get; set; }
    //    public bool ReuLuoi_Co { get; set; }
    //    public bool ReuLuoi_Khong { get; set; }
    //    public bool ReuLuoi_Bong { get; set; }
    //    public bool ReuLuoi_Day { get; set; }
    //    public bool ReuLuoi_Mong { get; set; }
    //    public bool ReuLuoi_Uot { get; set; }
    //    public bool ReuLuoi_Kho { get; set; }
    //    public bool ReuLuoi_Dinh { get; set; }
    //    public bool ReuLuoi_Trang { get; set; }
    //    public bool ReuLuoi_Vang { get; set; }
    //    public bool ReuLuoi_Den { get; set; }
    //    public bool ReuLuoi_Khac { get; set; }
    //    public string MoTaVongChan { get; set; }
    //    public bool TiengNoi_BinhThuong { get; set; }
    //    public bool TiengNoi_To { get; set; }
    //    public bool TiengNoi_Nho { get; set; }
    //    public bool TiengNoi_DutQuang { get; set; }
    //    public bool TiengNoi_Khan { get; set; }
    //    public bool TiengNoi_Ngong { get; set; }
    //    public bool TiengNoi_Mat { get; set; }
    //    public bool TiengNoi_Khac { get; set; }
    //    public bool HoiTho_BinhThuong { get; set; }
    //    public bool HoiTho_DutQuang { get; set; }
    //    public bool HoiTho_Ngan { get; set; }
    //    public bool HoiTho_Manh { get; set; }
    //    public bool HoiTho_Yeu { get; set; }
    //    public bool HoiTho_Tho { get; set; }
    //    public bool HoiTho_Rit { get; set; }
    //    public bool HoiTho_KhoKhe { get; set; }
    //    public bool HoiTho_Cham { get; set; }
    //    public bool HoiTho_Gap { get; set; }
    //    public bool HoiTho_Khac { get; set; }
    //    public bool Ho { get; set; }
    //    public bool Ho_HoLienTuc { get; set; }
    //    public bool Ho_Con { get; set; }
    //    public bool Ho_It { get; set; }
    //    public bool Ho_Nhieu { get; set; }
    //    public bool Ho_Khan { get; set; }
    //    public bool Ho_CoDom { get; set; }
    //    public bool Ho_Khac { get; set; }
    //    public bool O { get; set; }
    //    public bool Nac { get; set; }
    //    public bool MuiCoThe { get; set; }
    //    public bool MuiCoThe_Chua { get; set; }
    //    public bool MuiCoThe_Kham { get; set; }
    //    public bool MuiCoThe_Tanh { get; set; }
    //    public bool MuiCoThe_Thoi { get; set; }
    //    public bool MuiCoThe_Hoi { get; set; }
    //    public bool MuiCoThe_Khac { get; set; }
    //    public bool ChatThaiBieuHienBenhLy { get; set; }
    //    public bool ChatThai_Dom { get; set; }
    //    public bool ChatThai_ChatNon { get; set; }
    //    public bool ChatThai_Phan { get; set; }
    //    public bool ChatThai_NuocTieu { get; set; }
    //    public bool ChatThai_KhiHu { get; set; }
    //    public bool ChatThai_KinhNguyet { get; set; }
    //    public bool ChatThai_Khac { get; set; }
    //    public string MoTaVanChan { get; set; }
    //    public bool HanNhiet_BinhThuong { get; set; }
    //    public bool HanNhiet_Han { get; set; }
    //    public bool HanNhiet_Nhiet { get; set; }
    //    public bool HanNhiet_Khac { get; set; }
    //    public bool HanNhiet_ThichNong { get; set; }
    //    public bool HanNhiet_SoNong { get; set; }
    //    public bool HanNhiet_ThichMat { get; set; }
    //    public bool HanNhiet_SoLanh { get; set; }
    //    public bool HanNhiet_TrongNguoiNong { get; set; }
    //    public bool HanNhiet_TrongNguoiLanh { get; set; }
    //    public bool HanNhiet_RetRun { get; set; }
    //    public bool HanNhiet_HanNhietVangLai { get; set; }
    //    public bool HanNhiet_Khac2 { get; set; }
    //    public bool MoHoi_BinhThuong { get; set; }
    //    public bool MoHoi_KhongCoMoHoi { get; set; }
    //    public bool MoHoi_TuHan { get; set; }
    //    public bool MoHoi_DaoHan { get; set; }
    //    public bool MoHoi_Nhieu { get; set; }
    //    public bool MoHoi_It { get; set; }
    //    public bool MoHoi_Khac { get; set; }
    //    public bool DauMat { get; set; }
    //    public bool DauDau_MotCho { get; set; }
    //    public bool DauDau_NuaDau { get; set; }
    //    public bool DauDau_CaDau { get; set; }
    //    public bool DauDau_DiChuyen { get; set; }
    //    public bool DauDau_EAmNhuBiBuocLai { get; set; }
    //    public bool DauDau_Nhoi { get; set; }
    //    public bool DauDau_Cang { get; set; }
    //    public bool DauDau_NangDau { get; set; }
    //    public bool Mat_HoaMatChongMat { get; set; }
    //    public bool Mat_NhinKhongRo { get; set; }
    //    public bool Tai_U { get; set; }
    //    public bool Tai_Diec { get; set; }
    //    public bool Tai_Nang { get; set; }
    //    public bool Tai_ { get; set; }
    //    public bool Tai_Dau { get; set; }
    //    public bool Mui_Ngat { get; set; }
    //    public bool Mui_ChayNuoc { get; set; }
    //    public bool Mui_ChayMauCam { get; set; }
    //    public bool Mui_Dau { get; set; }
    //    public bool Hong_Dau { get; set; }
    //    public bool Hong_Kho { get; set; }
    //    public bool CoVai_Moi { get; set; }
    //    public bool CoVai_Dau { get; set; }
    //    public bool CoVai_KhoVanDong { get; set; }
    //    public bool CoVai_Khac { get; set; }
    //    public bool Lung { get; set; }
    //    public bool Lung_Dau { get; set; }
    //    public bool Lung_KhoVanDong { get; set; }
    //    public bool Lung_CoCungCo { get; set; }
    //    public bool Lung_Khac { get; set; }
    //    public bool BungVaUc { get; set; }
    //    public bool BungNguc_Tuc { get; set; }
    //    public bool BungNguc_Dau { get; set; }
    //    public bool BungNguc_Soi { get; set; }
    //    public bool BungNguc_NongRuot { get; set; }
    //    public bool BungNguc_DayTruong { get; set; }
    //    public bool BungNguc_NgotNgatKhoTho { get; set; }
    //    public bool BungNguc_DauTucCanhSuon { get; set; }
    //    public bool BungNguc_BonChonKhongYen { get; set; }
    //    public bool BungNguc_DanhTrongNguc { get; set; }
    //    public bool BungNguc_Khac { get; set; }
    //    public bool ChanTay { get; set; }
    //    public bool An { get; set; }
    //    public bool An_ThichNong { get; set; }
    //    public bool An_ThichMat { get; set; }
    //    public bool An_AnNhieu { get; set; }
    //    public bool An_AnIt { get; set; }
    //    public bool An_DangMieng { get; set; }
    //    public bool An_NhatMieng { get; set; }
    //    public bool An_ThemAn { get; set; }
    //    public bool An_ChanAn { get; set; }
    //    public bool An_AnVaoBungChuong { get; set; }
    //    public bool An_Khac { get; set; }
    //    public bool Uong { get; set; }
    //    public bool Uong_Mat { get; set; }
    //    public bool Uong_AmNong { get; set; }
    //    public bool Uong_Nhieu { get; set; }
    //    public bool Uong_It { get; set; }
    //    public bool Uong_Khac { get; set; }
    //    public bool DaiTieuTien { get; set; }
    //    public bool Tieutien_Vang { get; set; }
    //    public bool Tieutien_Do { get; set; }
    //    public bool Tieutien_Duc { get; set; }
    //    public bool Tieutien_Buot { get; set; }
    //    public bool Tieutien_Dat { get; set; }
    //    public bool Tieutien_KhongTuChu { get; set; }
    //    public bool Tieutien_Bi { get; set; }
    //    public bool Tieutien_Khac { get; set; }
    //    public bool Daitien_Tao { get; set; }
    //    public bool Daitien_Nhao { get; set; }
    //    public bool Daitien_Song { get; set; }
    //    public bool Daitien_ToanNuoc { get; set; }
    //    public bool Daitien_NhayMui { get; set; }
    //    public bool Daitien_Bi { get; set; }
    //    public bool Daitien_Khac { get; set; }
    //    public bool Ngu { get; set; }
    //    public bool Ngu_KhoVaoGiacNgu { get; set; }
    //    public bool Ngu_HayTinh { get; set; }
    //    public bool Ngu_DaySom { get; set; }
    //    public bool Ngu_HayMo { get; set; }
    //    public bool Ngu_Khac { get; set; }
    //    public bool KinhNguyet { get; set; }
    //    public bool KinhNguyet_DenTruocKy { get; set; }
    //    public bool KinhNguyet_DenSauKy { get; set; }
    //    public bool KinhNguyet_LucDenTruocLucDenS { get; set; }
    //    public bool KinhNguyet_TacKinh { get; set; }
    //    public bool KinhNguyet_Khac { get; set; }
    //    public bool ThongKinh_DauTruocKy { get; set; }
    //    public bool ThongKinh_DauTrongKy { get; set; }
    //    public bool ThongKinh_DauSauKy { get; set; }
    //    public bool ThongKinh_Khac { get; set; }
    //    public bool DoiHa_Vang { get; set; }
    //    public bool DoiHa_Trang { get; set; }
    //    public bool DoiHa_Hoi { get; set; }
    //    public bool DoiHa_Hong { get; set; }
    //    public bool DoiHa_Khac { get; set; }
    //    public bool RoiHanKhaNangSinhDuc { get; set; }
    //    public bool Nam_YeuKhiGiaoHop { get; set; }
    //    public bool Nam_LietDuong { get; set; }
    //    public bool Nam_DiTinh { get; set; }
    //    public bool Nam_HoatTinh { get; set; }
    //    public bool Nam_MongTinh { get; set; }
    //    public bool Nam_LanhTinh { get; set; }
    //    public bool Nu_KhongThuThai { get; set; }
    //    public bool Nu_SayThai_DongThai { get; set; }
    //    public bool Nu_SayThaiLienTiep { get; set; }
    //    public bool Nu_Khac { get; set; }
    //    public bool DieuKienXuatHienBenh { get; set; }
    //    public string MoTaVaanChan { get; set; }
    //    public bool Da_BinhThuong { get; set; }
    //    public bool Da_Kho { get; set; }
    //    public bool Da_Nong { get; set; }
    //    public bool Da_Lanh { get; set; }
    //    public bool Da_Uot { get; set; }
    //    public bool Da_ChanTayNong { get; set; }
    //    public bool Da_ChanTayLanh { get; set; }
    //    public bool Da_AnLom { get; set; }
    //    public bool Da_AnDau { get; set; }
    //    public bool Da_CucCung { get; set; }
    //    public bool Da_Khac { get; set; }
    //    public bool MoHoi_ToanThan { get; set; }
    //    public bool MoHoi_Tran { get; set; }
    //    public bool MoHoi_TayChan { get; set; }
    //    public bool MoHoi_KhacXucChan { get; set; }
    //    public bool CoXuongKhop_SanChac { get; set; }
    //    public bool CoXuongKhop_Mem { get; set; }
    //    public bool CoXuongKhop_CangCung { get; set; }
    //    public bool CoXuongKhop_CoCoAnDau { get; set; }
    //    public bool CoXuongKhop_GanDau { get; set; }
    //    public bool CoXuongKhop_XuongKhopDau { get; set; }
    //    public bool CoXuongKhop_Khac { get; set; }
    //    public bool Bung_Mem { get; set; }
    //    public bool Bung_Chuong { get; set; }
    //    public bool Bung_CoChuong { get; set; }
    //    public bool Bung_CoHonCuc { get; set; }
    //    public bool Bung_DauThienAn { get; set; }
    //    public bool Bung_DauCuAn { get; set; }
    //    public bool Bung_Khac { get; set; }
    //    public bool MacChan_Phu { get; set; }
    //    public bool MacChan_Tram { get; set; }
    //    public bool MacChan_Tri { get; set; }
    //    public bool MacChan_Sac { get; set; }
    //    public bool MacChan_Te { get; set; }
    //    public bool MacChan_Huyen { get; set; }
    //    public bool MacChan_Hoat { get; set; }
    //    public bool MacChan_VoLuc { get; set; }
    //    public bool MacChan_CoLuc { get; set; }
    //    public bool MacChan_Khac { get; set; }
    //    public string BenPhai_TongKhan { get; set; }
    //    public string BenTrai_TongKhan { get; set; }
    //    public bool MachTayTrai_Thon1 { get; set; }
    //    public bool MachTayTrai_Thon2 { get; set; }
    //    public bool MachTayTrai_Thon3 { get; set; }
    //    public bool MachTayTrai_Quan1 { get; set; }
    //    public bool MachTayTrai_Quan2 { get; set; }
    //    public bool MachTayTrai_Quan3 { get; set; }
    //    public bool MachTayTrai_Xich1 { get; set; }
    //    public bool MachTayTrai_Xich2 { get; set; }
    //    public bool MachTayTrai_Xich3 { get; set; }
    //    public bool MachTayPhai_Thon1 { get; set; }
    //    public bool MachTayPhai_Thon2 { get; set; }
    //    public bool MachTayPhai_Thon3 { get; set; }
    //    public bool MachTayPhai_Quan1 { get; set; }
    //    public bool MachTayPhai_Quan2 { get; set; }
    //    public bool MachTayPhai_Quan3 { get; set; }
    //    public bool MachTayPhai_Xich1 { get; set; }
    //    public bool MachTayPhai_Xich2 { get; set; }
    //    public bool MachTayPhai_Xich3 { get; set; }
    //    public string MoTaThietChan { get; set; }
    //    public string TomTatTuChan { set; get; }
    //    public string BienPhapLuanTri { set; get; }
    //    public string BietDanh { set; get; }
    //    public string BatCuong { set; get; }
    //    public string TangPhuKinhLac { set; get; }
    //    public string NguyenNhan { set; get; }
    //    public bool DieuTriYHCT { set; get; }
    //    public string PhapDieuTri { set; get; }
    //    public string PhuongThuoc { set; get; }
    //    public string PhuongHuyet { set; get; }
    //    public string XoaBopBamHuyet { set; get; }
    //    public string Khac_DieuTri { set; get; }
    //    public bool DieuTriKetHopVoiYHHD { set; get; }
    //    public string DieuTriKetHopVoiYHHD_Text { set; get; }
    //    public int CheDoDinhDuong { get; set; }
    //public string ChanDoanVaoVienTheoYHCT { set; get; }
    //public string ChanDoanVaoVienTheoYHHD { set; get; }
    //    public string PhuongPhapDieuTriTheoYHHD { set; get; }
    //    public string PhuongPhapDieuTriTheoYHCT { set; get; }
    //public string ChanDoanRaVienTheoYHCT { set; get; }
    //public string ChanDoanRaVienTheoYHHD { set; get; }
    //    public int KetQuaDieuTriID { get; set; }
    //    public string TinhTrangNguoiBenhKhiRavien { set; get; }
    //    public string BenhNgoaiKhoa { set; get; }
    //public string TenKhoa { set; get; }
    //    public string CacBoPhan { set; get; }
    //    public string TomTatKetQuaCanLamSang { set; get; }
    //    public string DaXuLy { set; get; }
    //    public string BenhChuyenKhoa { set; get; }
    //    public string Phai_HinhVe { set; get; }
    //    public string Thang_HinhVe { set; get; }
    //    public string Trai_HinhVe { set; get; }
    //    public string HamTrenVaHong_HinhVe { set; get; }
    //    public string HamDuoi_HinhVe { set; get; }
    //    public string PhanLoai_HinhVe { set; get; }
    //    public string ChuanDoanCuaKhoaKhamBenh { set; get; }
    //    public string DaXuLyCuaTuyenDuoi { set; get; }
    //    public string ManNhiPhai_HinhAnh { set; get; }
    //    public string ManNhiTrai_HinhAnh { set; get; }
    //    public string MuiTruoc_HinhAnh { set; get; }
    //    public string MuiSau_HinhAnh { set; get; }
    //    public string ThanhQuan_HinhAnh { set; get; }
    //    public string Hong_HinhAnh { set; get; }
    //    public string CoNghiengPhai_HinhAnh { set; get; }
    //    public string CoNghiengTrai_HinhAnh { set; get; }
    //    public string ChuanDoanPhongKham { set; get; }
    //    public string TaiCho { set; get; }
    //    public string MoTa_VongChan { set; get; }
    //    public string MoTa_VanChan { set; get; }
    //    public string MoTa_VaanChan { set; get; }
    //    public string MoTa_XucChan { set; get; }
    //    public string MachTayTrai { set; get; }
    //    public string MachTayPhai { set; get; }
    //    public string CheDoDinhDuongTaiNha { set; get; }
    //    public string CheDoHoLyTaiNha { set; get; }
    //    public string KetQuaXetNghiemCanLamSang { set; get; }
    //    public int ThoiGianDieuTri { set; get; }
    //    public int ConThuMay { get; set; }
    //    public int TienThaiPara { get; set; }
    //    public int TinhTrangKhiSinhID { get; set; }
    //    public double CanNangLucSinh { get; set; }
    //    public string DiTatBamSinh_Text { get; set; }
    //    public bool DiTatBamSinh { get; set; }
    //    public string PhatTrienTinhThan { get; set; }
    //    public string PhatTrienVanDong { get; set; }
    //    public string CacBenhLyKhac { get; set; }
    //    public int NuoiDuongID { get; set; }
    //    public int CaiSuaThang { get; set; }
    //    public bool ChamSocID { get; set; }
    //    public string BenhKhacDuocTiemChungKhac { get; set; }
    //    public double ChieuCao { set; get; }
    //    public double VongNguc { set; get; }
    //    public double VongDau { set; get; }
    //    public bool Lao { get; set; }
    //    public bool BaiLiet { get; set; }
    //    public bool Soi { get; set; }
    //    public bool HoGa { get; set; }
    //    public bool UonVan { get; set; }
    //    public bool BachHau { get; set; }
    //    public bool TiemChungKhac { get; set; }
    //    public string NoiGioiThieu { get; set; }
    //    public int? NoiGioiThieuYTe { get; set; }
    //public string ChanDoanNoiGioiThieu { get; set; }
    //    public string SoConHienCo { get; set; }
    //    public string Trai { get; set; }
    //    public string Gai { get; set; }
    //    public string DaPhauThuatLayThai { get; set; }
    //    public string NamPhauThuatLanCuoi { get; set; }
    //    public string CacPhauThuatTCKhac { get; set; }
    //    public string CacPhauThuatTCKhac_Nam { get; set; }
    //    public string SoLanPhaThai { get; set; }
    //    public string LanPhaThaiGanNhat_Thang { get; set; }
    //    public string LanPhaThaiGanNhat_Nam { get; set; }
    //    public int? BienPhapTTDangSuDung { get; set; }
    //    public string TienSuBenh { get; set; }
    //    public string TienSuBenh_S { get; set; }
    //    public int? TinhTrangHonNhan { get; set; }
    //    public string NgayDauKyKinhCuoi { get; set; }
    //public string TuoiThai { get; set; }
    //    public string AmHo { get; set; }
    //    public string AmDao { get; set; }
    //    public string CoTuCung { get; set; }
    //    public string TuCung { get; set; }
    //    public string PhanPhuPhai { get; set; }
    //    public string PhanPhuTrai { get; set; }
    //    public string CacXetNghiemCanLam { get; set; }
    //public string ChanDoanTuoiThai { get; set; }
    //    public string PhuongPhapPhaThai { get; set; }
    //    public string GayTe { get; set; }
    //    public string GayMe { get; set; }
    //    public int? PhuongPhapPhaThaitr2 { get; set; }
    //    public int? HutThaiChanKhongBang { get; set; }
    //    public string SoLuong { get; set; }
    //    public int? MangOi { get; set; }
    //    public int? RauThai { get; set; }
    //    public int? MoThai { get; set; }
    //    public int? TuongXungVoiTuoiThai { get; set; }
    //    public string ThaiBatThuong { get; set; }
    //    public string ThuocSuDungTruocTrongSau { get; set; }
    //    public string TaiBienTrongQuaTrinhThuThuat { get; set; }
    //    public string ToanTrang { get; set; }
    //public string Mach { get; set; }
    //public string HuyetAp { get; set; }
    //    public int? RaMauAmDao { get; set; }
    //    public string DanhGiaKetQua { get; set; }
    //    public int? BienPhapTranhThaiSauPhaThai { get; set; }
    //    public string NguoiLamThuThuat { get; set; }
    //    public string Thai { get; set; }
    //    public int? PhuongPhapPhaThaiTK { get; set; }
    //    public int? TinhTrangSauKhiPhaThai { get; set; }
    //    public int? TaiBien { get; set; }
    //    public string TongSo { get; set; }
    //    public int? RaVe { get; set; }
    //    public string LyDoNhapVien { get; set; }
    //    public string LyDoChuyenTuyen { get; set; }
    //    public int? BienPhapTranhThaiSauPhaThaiTK { get; set; }
    //    public string KhamLaiBatThuong { get; set; }
    //    public string KhamLaiTheoHen { get; set; }
    //    public string KetLuan { get; set; }
    //    public string TenThuocUong { get; set; }
    //    public string BacSyChiDinh { get; set; }
    //    public int? CacTacDungSauKhiUongThuoc { get; set; }
    //    public string CacTacDungSauKhiUongText { get; set; }
    //    public string TenThuocSuDung { get; set; }
    //    public int? DiaDiemSuDung { get; set; }
    //    public string DuongDung { get; set; }
    //    public string BacSyChiDinhSuDung { get; set; }
    //    public int? CacTacDungSauKhiDungThuoc { get; set; }
    //    public string CacTacDungSauKhiDungText { get; set; }
    //    public string KhamLaiBatThuong_Text { get; set; }
    //    public string KhamLaiBatThuong_BacSy { get; set; }
    //    public int? NhinThayThaiSay { get; set; }
    //    public int? TranThaiSayThai { get; set; }
    //    public string CanGhiRo { get; set; }
    //    public string KetQuaXuTri { get; set; }
    //    public int AnUong { get; set; }
    //    public int ChaiToc { get; set; }
    //    public int DanhRang { get; set; }
    //    public int Tam { get; set; }
    //    public int MacQuanAo { get; set; }
    //    public int DiVeSinh { get; set; }
    //    public int NamNguaSap { get; set; }
    //    public int NamNguaNgoi { get; set; }
    //    public int DungNgoi { get; set; }
    //    public int TuSanDungLen { get; set; }
    //    public int DungCuTroGiup { get; set; }
    //    public int KhaNangDiChuyen { get; set; }
    //    public string Khac_ChucNangSinhHoat { get; set; }
    //    public string CanDoiCacBoPhan { set; get; }
    //    public string CacKhuyetTatDacBiet { set; get; }
    //    public string VanDong { set; get; }
    //    public string CamGiac { set; get; }
    //    public string PhanXa { set; get; }
    //    public string CoTron { set; get; }
    //    public string ThanKinhSoNao { set; get; }
    //    public string RoiLoanChucNang { set; get; }
    //    public string NhipTim { set; get; }
    //    public string TiengTim { set; get; }
    //    public string RoiLoanChucNangTimMach { set; get; }
    //    public string LongNguc { set; get; }
    //    public string TheTichKhi { set; get; }
    //    public string TinhTrangBenhLy_HoHap { set; get; }
    //    public string RoiLoanChucNangHoHap { set; get; }
    //    public string TinhTrangBenhLy_TieuHoa { set; get; }
    //    public string RoiLoanChucNang_TieuHoa { set; get; }
    //    public string HinhTheCacKhop { set; get; }
    //    public string TamHoatDongCacKhopLucVaoVien { set; get; }
    //    public string TamHoatDongCacKhopLucRaVien { set; get; }
    //    public string TinhTrangBenhLy_Co { set; get; }
    //    public string RoiLoanChucNang_Co { set; get; }
    //    public string CoDuocThu { set; get; }
    //    public int BatCoThu { set; get; }
    //    public string TinhTrangBenhLy_CotSong { set; get; }
    //    public string Schober { set; get; }
    //    public string Stibor { set; get; }
    //    public string RoiLoanChucNang_CotSong { set; get; }
    //    public string HinhVeTonThuongKhiVaoVien { set; get; }
    //    public string CacVanDeKhiemkhuyet { set; get; }
    //    public string DaVaMoDuoiDa { set; get; }
    //    public string MucDichDieuTri { set; get; }
    //    public TienSuSanPhuKhoa TienSuSanPhuKhoa { get; set; }
    //    public string Hach { get; set; }
    //    public string Vu { get; set; }
    //    public string CacDauHieuSinhDucThuPhat { set; get; }
    //    public string MoiLon { set; get; }
    //    public string MoiBe { set; get; }
    //    public string AmVat { set; get; }
    //    public string MangTrinh { set; get; }
    //    public string TangSinhMon { set; get; }
    //    public string ThanTuCung { set; get; }
    //    public string PhanPhu { set; get; }
    //    public string CacTuiCung { set; get; }
    //    public int NgayThai { get; set; }
    //    public string KhamThaiTai { get; set; }
    //    public bool TiemPhongUonVan { get; set; }
    //    public bool Phu { get; set; }
    //    public int DuocTiem { get; set; }
    //    public int SoMuiKhau { get; set; }
    //    public string DauHieuLucDau { get; set; }
    //    public string BienChuyen { get; set; }
    //    public int BatDauThayKinhNam { get; set; }
    //    public int TuoiThayKinh { get; set; }
    //    public string TinhChatKinhNguyet { get; set; }
    //    public int ChuKy { get; set; }
    //    public int SoNgayThayKinh { get; set; }
    //    public string LuongKinh { get; set; }
    //    public int KinhLanCuoiNgay { get; set; }
    //    public bool DauBung { get; set; }
    //    public int LayChongNam { get; set; }
    //    public int TuoiLayChong { get; set; }
    //    public int HetKinhNam { get; set; }
    //    public int TuoiHetKinh { get; set; }
    //    public bool Truoc { get; set; }
    //    public bool Sau { get; set; }
    //    public bool Trong { get; set; }
    //    public string NhungBenhPhuKhoaDaDieuTri { get; set; }
    //    public bool ToanTrang_Phu { get; set; }
    //    public bool BungCoSeoPhauThuatCu { get; set; }
    //    public string HinhDangTuCung { get; set; }
    //    public string TuThe { get; set; }
    //    public double ChieuCaoTC { get; set; }
    //    public double VongBung { get; set; }
    //    public string ConCoTC { get; set; }
    //    public int TimThai { get; set; }
    //public string ChanDoanKhiVaoKhoa { get; set; }
    //    public double ChiSoBishop { get; set; }
    //    public int? TinhTrangOiID { get; set; }
    //    public bool OiVoID { get; set; }
    //    public string MauSacNuocOi { get; set; }
    //    public string NuocOiNhieuHayIt { get; set; }
    //    public string Ngoi { get; set; }
    //    public string The_KhamTrong { get; set; }
    //    public string KieuThe { get; set; }
    //    public int DoLotID { get; set; }
    //    public string DuongKinhNhoHaVe { get; set; }
    //    public string KhiVaoKhoa { get; set; }
    //    public string TenNguoiTheoDoi { get; set; }
    //    public string ChucDanh { get; set; }
    //    public string Apgar_1 { get; set; }
    //    public string Apgar_5 { get; set; }
    //    public string Apgar_10 { get; set; }
    //    public double CanNang { get; set; }
    //    public double Cao { get; set; }
    //    public bool? DonThai { get; set; }
    //    public bool? DaThai { get; set; }
    //    public bool TatBamSinh { get; set; }
    //    public bool CoHauMon { get; set; }
    //    public string CuTheDiTatBamSinh { get; set; }
    //    public string TinhTrangSoSinhSauKhiDe { get; set; }
    //    public string XuLyVaKetQua { get; set; }
    //    public bool Rau { get; set; }
    //    public bool RauCuonCo { get; set; }
    //    public string CachSoRau { get; set; }
    //    public string MatMang { get; set; }
    //    public string MatMui { get; set; }
    //    public string BanhRau { get; set; }
    //    public double CanNangSoRau { get; set; }
    //    public double RauCuonDai { get; set; }
    //    public double CoChayMauSauSo { get; set; }
    //    public double LuongMauMat { get; set; }
    //    public bool KiemSoatTuCung { get; set; }
    //    public string XuLyVaKetQuaSoRau { get; set; }
    //    public int PhuongPhapDeID { get; set; }
    //    public string LyDoCanThiep { get; set; }
    //    public int TangSinhMonID { get; set; }
    //    public string PhuongPhapKhauChi { get; set; }
    //    public string ChuanDoanTruocPhauThuat { get; set; }
    //    public string ChuanDoanSauPhauThuat { get; set; }
    //    public int CoTuCungID { get; set; }
    //    public bool TaiBienPhauThuat { get; set; }
    //    public bool BienChung { get; set; }
    //    public int LyDoBienChung { get; set; }
    //    public string HoiBenh { get; set; }
    //    public string MauSac { get; set; }
    //    public bool CachDeID { get; set; }
    //    public string NguoiDoDe { get; set; }
    //    public string Apgar1 { get; set; }
    //    public string Apgar5 { get; set; }
    //    public string Apgar10 { get; set; }
    //    public string TinhTrangDinhDuong { get; set; }
    //    public bool HutDich { get; set; }
    //    public bool XoaBopTim { get; set; }
    //    public bool ThoO2 { get; set; }
    //    public bool DatNoiKhiQuan { get; set; }
    //    public bool BopBongO2 { get; set; }
    //    public bool Khac { get; set; }
    //    public string NguoiChuyenSoSinh { set; get; }
    //    public string CuTheDiTat { set; get; }
    //    public string TinhHinhSoSinhKhiVaoKhoa { set; get; }
    //    public string TinhTrangToanThan { set; get; }
    //    public int MauSacDaID { set; get; }
    //    public string MauSacDa { set; get; }
    //    public int ChieuDai { get; set; }
    //    public string NghePhoi { set; get; }
    //    public float ChiSoSilverman { set; get; }
    //    public int SuDanNoLongNgucID { get; set; }
    //    public int CoKeoCoLienSuonID { get; set; }
    //    public int CoKeoMuiUcID { get; set; }
    //    public int DapCanhMuiID { get; set; }
    //    public int RenRiID { get; set; }
    //    public string Bung { set; get; }
    //    public string TruongLucCo { set; get; }
    //    public int TinhTrangSoSinhKRDID { get; set; }
    //    public string ChiDinhTheoDoi { get; set; }
    //    public string DayThanKinhSoNao { set; get; }
    //    public string DayMat { set; get; }
    //    public string BieuHienChung { set; get; }
    //    public string KhongGian { set; get; }
    //    public string ThoiGian { set; get; }
    //    public string BanThan { set; get; }
    //    public string TinhCamCamXuc { set; get; }
    //    public string TriGiac { set; get; }
    //    public string HinhThuc { set; get; }
    //    public string NoiDung { set; get; }
    //    public string HoatDongCoYChi { set; get; }
    //    public string HoatDongBanNang { set; get; }
    //    public string NhoMayMoc { set; get; }
    //    public string NhoThongHieu { set; get; }
    //    public string KhaNangPhanTich { set; get; }
    //    public string KhaNangTongHop { set; get; }
    //    public string ChuY { set; get; }
    //    public string GiaiPhauBenh { set; get; }
    //    public int GiaiPhauBenhID { set; get; }
    //    public string DichTe { get; set; }
    //    public string BenhCapTinhDangLuuHanh { get; set; }
    //    public string DaNoiONoiNao { get; set; }
    //    public string ThoiGianSongONoiPhatHienBenh { get; set; }
    //    public string MoiSinh { get; set; }
    //    public string BoPhanTonThuong { set; get; }
    //    public string BoPhanTonThuongHinhAnh { set; get; }
    //    public string BoPhanTonThuongMoTa { set; get; }
    //    public string BenhChinhT { set; get; }
    //    public string BenhChinhM { set; get; }
    //    public string BenhChinhN { set; get; }
    //    public string GiaiDoan { set; get; }
    //    public string XNMau { set; get; }
    //    public string XNTeBao { set; get; }
    //    public string XNBLGP { set; get; }
    //    public string Xquang { set; get; }
    //    public string SieuAm { set; get; }
    //    public string XNKhac { set; get; }
    //    public bool DieuTriTrietDe { set; get; }
    //    public bool DieuTriTrieuChung { set; get; }
    //    public string TiaXaTienPhauTaiU { set; get; }
    //    public string TiaXaTienPhauTaiHach { set; get; }
    //    public string TiaXaDonThuanTaiU { set; get; }
    //    public string TiaXaDonThuanTaiHach { set; get; }
    //    public string TiaXaHauPhauTaiU { set; get; }
    //    public string TiaXaHauPhauTaiHach { set; get; }
    //    public string HoaChat { set; get; }
    //    public string SoDot { set; get; }
    //    public string DapUng { set; get; }
    //    public int DapUngID { set; get; }
    //    public string DieuTriKhac { set; get; }
    //    public string CacCoQuan { set; get; }
    //    public bool LyDoDiKham_MP { get; set; }
    //    public bool LyDoDiKham_MT { get; set; }
    //    public bool LyDoDiKham_2Mat { get; set; }
    //    public bool NhucMat_DuDoi { get; set; }
    //    public bool NhucMat_Vua { get; set; }
    //    public bool NhucMat_Nhe { get; set; }
    //    public bool NhucMat_Khong { get; set; }
    //    public bool Nhin_MoDotNgot { get; set; }
    //    public bool Nhin_MoTungLuc { get; set; }
    //    public bool Nhin_SuongMu { get; set; }
    //    public bool Nhin_KhongMo { get; set; }
    //    public bool Nhin_MoTangDan { get; set; }
    //    public bool Nhin_NhinThuHep { get; set; }
    //    public bool Nhin_QuanTanSac { get; set; }
    //    public bool SoAnhSangChayNuocMat_Co { get; set; }
    //    public bool SoAnhSangChayNuocMat_Khong { get; set; }
    //    public bool DoMat_Co { get; set; }
    //    public bool DoMat_Khong { get; set; }
    //    public bool ToanThan_DauDau { get; set; }
    //    public bool ToanThan_Non { get; set; }
    //    public bool ToanThan_BuonNon { get; set; }
    //    public bool ToanThan_Khong { get; set; }
    //    public string CacTrieuChungKhac { get; set; }
    //    public bool DaKhamChuaBenh_Huyen { get; set; }
    //    public bool DaKhamChuaBenh_Tinh { get; set; }
    //    public bool DaKhamChuaBenh_TrungUong { get; set; }
    //    public bool DaKhamChuaBenh_Khac { get; set; }
    //    public string PTTTMP_Loai1 { get; set; }
    //    public string PTTTMP_Loai2 { get; set; }
    //    public string PTTTMP_Loai3 { get; set; }
    //    public string PTTTMP_Loai4 { get; set; }
    //    public string PTTTMT_Loai1 { get; set; }
    //    public string PTTTMT_Loai2 { get; set; }
    //    public string PTTTMT_Loai3 { get; set; }
    //    public string PTTTMT_Loai4 { get; set; }
    //    public string PTTTMP_ThoiDiem1 { get; set; }
    //    public string PTTTMP_ThoiDiem2 { get; set; }
    //    public string PTTTMP_ThoiDiem3 { get; set; }
    //    public string PTTTMP_ThoiDiem4 { get; set; }
    //    public string PTTTMT_ThoiDiem1 { get; set; }
    //    public string PTTTMT_ThoiDiem2 { get; set; }
    //    public string PTTTMT_ThoiDiem3 { get; set; }
    //    public string PTTTMT_ThoiDiem4 { get; set; }
    //    public string PTTTMP_Noi1 { get; set; }
    //    public string PTTTMP_Noi2 { get; set; }
    //    public string PTTTMP_Noi3 { get; set; }
    //    public string PTTTMP_Noi4 { get; set; }
    //    public string PTTTMT_Noi1 { get; set; }
    //    public string PTTTMT_Noi2 { get; set; }
    //    public string PTTTMT_Noi3 { get; set; }
    //    public string PTTTMT_Noi4 { get; set; }
    //    public bool ThuocHaNhanAp_Uong { get; set; }
    //    public bool ThuocHaNhanAp_TraMat { get; set; }
    //    public bool ThuocHaNhanAp_Tiem { get; set; }
    //    public bool ThuocHaNhanAp_1Thuoc { get; set; }
    //    public bool ThuocHaNhanAp_2Thuoc { get; set; }
    //    public bool ThuocHaNhanAp_3Thuoc { get; set; }
    //    public bool ThuocHaNhanAp_4Thuoc { get; set; }
    //    public bool TienSuKhac_CanThi { get; set; }
    //    public bool TienSuKhac_VienThi { get; set; }
    //    public bool TienSuKhac_TranThuong { get; set; }
    //    public bool TienSuKhac_VienMangBoDao { get; set; }
    //    public bool TienSuKhac_VienPhanTruocNhaCau { get; set; }
    //    public bool TienSuKhac_TacTMTTVM { get; set; }
    //    public bool TienSuKhac_DaPTMat { get; set; }
    //    public string TienSuKhac_DaPTMat_Text { get; set; }
    //    public bool TienSuKhac_BenhKhac { get; set; }
    //    public string TienSuKhac_BenhKhac_Text { get; set; }
    //    public string TienSuKhac_Corticosteroid { get; set; }
    //    public bool TienSuKhac_Cor { get; set; }
    //    public string ThoiGianSuDung_Corticosteroid { get; set; }
    //    public bool Corticosteroid_TraMat { get; set; }
    //    public bool Corticosteroid_TiemMat { get; set; }
    //    public bool Corticosteroid_ToanThan { get; set; }
    //    public bool Corticosteroid_TheoCDCuaBacSi { get; set; }
    //    public bool Corticosteroid_BNTuDungThuoc { get; set; }
    //    public bool TienSuToanThan_TimMach { get; set; }
    //    public bool TienSuToanThan_HuyetAp { get; set; }
    //    public bool TienSuToanThan_DaiDuong { get; set; }
    //    public bool TienSuToanThan_RoDongMachCanh { get; set; }
    //    public bool TienSuToanThan_BenhKhac { get; set; }
    //    public string TienSuBenhToanThan_BenhKhac { get; set; }
    //    public bool TienSuGlocomGiaDinh_OngBa { get; set; }
    //    public bool TienSuGlocomGiaDinh_BoMe { get; set; }
    //    public bool TienSuGlocomGiaDinh_AnhChiEm { get; set; }
    //    public bool TienSuGlocomGiaDinh_CoDiChuBac { get; set; }
    //    public string ThiLucVaoVienMP_KhongKinh { get; set; }
    //    public string ThiLucVaoVienMT_KhongKinh { get; set; }
    //    public string ThiLucVaoVienMP_CoKinh { get; set; }
    //    public string ThiLucVaoVienMT_CoKinh { get; set; }
    //    public string NhaApMP { get; set; }
    //    public string NhaApMT { get; set; }
    //    public bool MiMatSungNeMP_Khong { get; set; }
    //    public bool MiMatSungNeMP_Co { get; set; }
    //    public bool MiMatSungNeMT_Khong { get; set; }
    //    public bool MiMatSungNeMT_Co { get; set; }
    //    public string NhanApMP_Khac { get; set; }
    //    public string NhanApMT_Khac { get; set; }
    //    public bool KetMacCuongTuMP_Khong { get; set; }
    //    public bool KetMacCuongTuMP_Co { get; set; }
    //    public bool KetMacCuongTuMT_Khong { get; set; }
    //    public bool KetMacCuongTuMT_Co { get; set; }
    //    public bool KetMacSeoMoCuMP_Khong { get; set; }
    //    public bool KetMacSeoMoCuMP_Co { get; set; }
    //    public string KetMacSeoMoCuMP { get; set; }
    //    public bool KetMacSeoMoCuMT_Khong { get; set; }
    //    public bool KetMacSeoMoCuMT_Co { get; set; }
    //    public string KetMacSeoMoCuMT { get; set; }
    //    public bool KetMacBonDoMP_Tot { get; set; }
    //    public bool KetMacBonDoMP_Dep { get; set; }
    //    public bool KetMacBonDoMP_Xo { get; set; }
    //    public bool KetMacBonDoMP_Mong { get; set; }
    //    public bool KetMacBonDoMP_QuaPhat { get; set; }
    //    public bool KetMacBonDoMT_Tot { get; set; }
    //    public bool KetMacBonDoMT_Dep { get; set; }
    //    public bool KetMacBonDoMT_Xo { get; set; }
    //    public bool KetMacBonDoMT_Mong { get; set; }
    //    public bool KetMacBonDoMT_QuaPhat { get; set; }
    //    public bool GiacMacTrongSuatMP_Trong { get; set; }
    //    public bool GiacMacTrongSuatMP_Seo { get; set; }
    //    public bool GiacMacTrongSuatMP_LoanDuong { get; set; }
    //    public bool GiacMacPhuNeMP_Khong { get; set; }
    //    public bool GiacMacPhuNeMP_Co { get; set; }
    //    public string GiacMacPhuNeMP { get; set; }
    //    public bool GiacMacTrongSuatMT_Trong { get; set; }
    //    public bool GiacMacTrongSuatMT_Seo { get; set; }
    //    public bool GiacMacTrongSuatMT_LoanDuong { get; set; }
    //    public bool GiacMacPhuNeMT_Khong { get; set; }
    //    public bool GiacMacPhuNeMT_Co { get; set; }
    //    public string GiacMacPhuNeMT { get; set; }
    //    public string GiacMacDoDayGiacMacMP { get; set; }
    //    public string GiacMacDoDayGiacMacMT { get; set; }
    //    public string GiacMacTuMP { get; set; }
    //    public string GiacMacTuMT { get; set; }
    //    public string GiacMacDuongKinhGiacMacMP { get; set; }
    //    public string GiacMacDuongKinhGiacMacMT { get; set; }
    //    public bool CungMacDanLoiMP_Khong { get; set; }
    //    public bool CungMacDanLoiMP_Co { get; set; }
    //    public bool CungMacDanLoiMT_Khong { get; set; }
    //    public bool CungMacDanLoiMT_Co { get; set; }
    //    public bool CungMaSeoMoMP_Khong { get; set; }
    //    public bool CungMaSeoMoMP_Co { get; set; }
    //    public string CungMaSeoMoMP { get; set; }
    //    public bool CungMaSeoMoMT_Khong { get; set; }
    //    public bool CungMaSeoMoMT_Co { get; set; }
    //    public string CungMaSeoMoMT { get; set; }
    //    public string TienPhongDoSauMP { get; set; }
    //    public string TienPhongDoSauMT { get; set; }
    //    public string GocTienPhongDauHieuKhacMP { get; set; }
    //    public string GocTienPhongDauHieuKhacMT { get; set; }
    //    public string MongMatMauSacMP { get; set; }
    //    public string MongMatMauSacMT { get; set; }
    //    public bool MongMatThaiHoaMP_Khong { get; set; }
    //    public bool MongMatThaiHoaMP_Co { get; set; }
    //    public string MongMatThaiHoaMP { get; set; }
    //    public bool MongMatThaiHoaMT_Khong { get; set; }
    //    public bool MongMatThaiHoaMT_Co { get; set; }
    //    public string MongMatThaiHoaMT { get; set; }
    //    public bool MongMatTanMachMP_Khong { get; set; }
    //    public bool MongMatTanMachMP_Co { get; set; }
    //    public bool MongMatTanMachMT_Khong { get; set; }
    //    public bool MongMatTanMachMT_Co { get; set; }
    //    public bool DongTuMP_Tron { get; set; }
    //    public bool DongTuMP_Meo { get; set; }
    //    public bool DongTuMT_Tron { get; set; }
    //    public bool DongTuMT_Meo { get; set; }
    //    public string DongTuDuongKinhMP { get; set; }
    //    public string DongTuDuongKinhMT { get; set; }
    //    public string DongTuVienSacToMP { get; set; }
    //    public string DongTuVienSacToMT { get; set; }
    //    public bool DongTuPhanXaMP_BinhThuong { get; set; }
    //    public bool DongTuPhanXaMP_Giam { get; set; }
    //    public bool DongTuPhanXaMP_Mat { get; set; }
    //    public bool DongTuPhanXaMT_BinhThuong { get; set; }
    //    public bool DongTuPhanXaMT_Giam { get; set; }
    //    public bool DongTuPhanXaMT_Mat { get; set; }
    //    public bool TheThuyTinhMP_Trong { get; set; }
    //    public bool TheThuyTinhMP_Duc { get; set; }
    //    public bool TheThuyTinhMT_Trong { get; set; }
    //    public bool TheThuyTinhMT_Duc { get; set; }
    //    public bool TheThuyTinhMP_Nhan { get; set; }
    //    public bool TheThuyTinhMP_Vo { get; set; }
    //    public bool TheThuyTinhMP_DuoiBao { get; set; }
    //    public bool TheThuyTinhMP_ToanBo { get; set; }
    //    public bool TheThuyTinhMT_Nhan { get; set; }
    //    public bool TheThuyTinhMT_Vo { get; set; }
    //    public bool TheThuyTinhMT_DuoiBao { get; set; }
    //    public bool TheThuyTinhMT_ToanBo { get; set; }
    //    public string DichMP { get; set; }
    //    public string DichMT { get; set; }
    //    public string DayMatVongMacMP { get; set; }
    //    public string DayMatVongMacMT { get; set; }
    //    public string DayMatHoangDiemMP { get; set; }
    //    public string DayMatHoangDiemMT { get; set; }
    //    public bool DayMatTanMachMP_Khong { get; set; }
    //    public bool DayMatTanMachMP_Co { get; set; }
    //    public bool DayMatTanMachMT_Khong { get; set; }
    //    public bool DayMatTanMachMT_Co { get; set; }
    //    public bool DayMatXuatHuyetMP_Khong { get; set; }
    //    public bool DayMatXuatHuyetMP_Co { get; set; }
    //    public bool DayMatXuatHuyetMT_Khong { get; set; }
    //    public bool DayMatXuatHuyetMT_Co { get; set; }
    //    public bool DayMatVienThanKinhMP_Khong { get; set; }
    //    public bool DayMatVienThanKinhMP_Co { get; set; }
    //    public bool DayMatVienThanKinhMT_Khong { get; set; }
    //    public bool DayMatVienThanKinhMT_Co { get; set; }
    //    public bool DiaThiGiaVienThanKinhMP_Duoi { get; set; }
    //    public bool DiaThiGiaVienThanKinhMP_Tren { get; set; }
    //    public bool DiaThiGiaVienThanKinhMP_Mui { get; set; }
    //    public bool DiaThiGiaVienThanKinhMP_TDuong { get; set; }
    //    public bool DiaThiGiaVienThanKinhMT_Duoi { get; set; }
    //    public bool DiaThiGiaVienThanKinhMT_Tren { get; set; }
    //    public bool DiaThiGiaVienThanKinhMT_Mui { get; set; }
    //    public bool DiaThiGiaVienThanKinhMT_TDuong { get; set; }
    //    public string DiaThiGiacMauSacMP { get; set; }
    //    public string DiaThiGiacMauSacMT { get; set; }
    //    public string DiaThiGiacCDMP { get; set; }
    //    public string DiaThiGiacCDMT { get; set; }
    //    public bool DiaThiGiacMachMauMP_BinhThuong { get; set; }
    //    public bool DiaThiGiacMachMauMP_ChHuong { get; set; }
    //    public bool DiaThiGiacMachMauMP_GapGoc { get; set; }
    //    public bool DiaThiGiacMachMauMT_BinhThuong { get; set; }
    //    public bool DiaThiGiacMachMauMT_ChHuong { get; set; }
    //    public bool DiaThiGiacMachMauMT_GapGoc { get; set; }
    //    public bool DiaThiGiacXuatHuetMP_Khong { get; set; }
    //    public bool DiaThiGiacXuatHuetMP_Co { get; set; }
    //    public bool DiaThiGiacXuatHuetMT_Khong { get; set; }
    //    public bool DiaThiGiacXuatHuetMT_Co { get; set; }
    //    public bool DiaThiGiacTeoCanhGaiMP_Khong { get; set; }
    //    public bool DiaThiGiacTeoCanhGaiMP_Co { get; set; }
    //    public bool DiaThiGiacTeoCanhGaiMT_Khong { get; set; }
    //    public bool DiaThiGiacTeoCanhGaiMT_Co { get; set; }
    //    public string VanNhanMP { get; set; }
    //    public string VanNhanMT { get; set; }
    //    public bool NhanCauMP_BinhThuong { get; set; }
    //    public bool NhanCauMP_DanNoi { get; set; }
    //    public bool NhanCauMP_To { get; set; }
    //    public bool NhanCauMP_Nho { get; set; }
    //    public bool NhanCauMT_BinhThuong { get; set; }
    //    public bool NhanCauMT_DanNoi { get; set; }
    //    public bool NhanCauMT_To { get; set; }
    //    public bool NhanCauMT_Nho { get; set; }
    //    public string HocMatMP { get; set; }
    //    public string HocMatMT { get; set; }
    //    public string ToanThanHuyetAp { get; set; }
    //    public string ToanThanNhietDo { get; set; }
    //    public string ToanThanMach { get; set; }
    //    public bool NoiTiet_BinhThuong { get; set; }
    //    public bool NoiTiet_CoBenh { get; set; }
    //    public bool ThanKinh_BinhThuong { get; set; }
    //    public bool ThanKinh_CoBenh { get; set; }
    //    public bool TuanHoan_BinhThuong { get; set; }
    //    public bool TuanHoan_CoBenh { get; set; }
    //    public bool HoHap_BinhThuong { get; set; }
    //    public bool HoHap_CoBenh { get; set; }
    //    public bool TieuHoa_BinhThuong { get; set; }
    //    public bool TieuHoa_CoBenh { get; set; }
    //    public bool CoXuongKhop_BinhThuong { get; set; }
    //    public bool CoXuongKhop_CoBenh { get; set; }
    //    public bool TietNieuSinhDuc_BinhThuong { get; set; }
    //    public bool TietNieuSinhDuc_CoBenh { get; set; }
    //    public string BenhChinhMP { get; set; }
    //    public string BenhChinhMT { get; set; }
    //    public string BenhKemTheoMP { get; set; }
    //    public string BenhKemTheoMT { get; set; }
    //public string ChanDoanRaVien_MatPhai { get; set; }
    //    public string MaChanDoanRaVien_MatPhai { get; set; }
    //public string ChanDoanRaVien_MatTrai { get; set; }
    //    public string MaChanDoanRaVien_MatTrai { get; set; }
    //    public bool PPDT_PhauThuat { get; set; }
    //    public string PPDT_PhauThuatText { get; set; }
    //    public bool PPDT_Thuoc { get; set; }
    //    public string PPDT_ThuocText { get; set; }
    //    public bool PPDT_Laser { get; set; }
    //    public string PPDT_LaserText { get; set; }
    //    public string TrinhTrangRaVien_MatPhai { get; set; }
    //    public string TrinhTrangRaVien_MatTrai { get; set; }
    //    public string RaVienMP_KhongKinh { get; set; }
    //    public string RaVienMT_KhongKinh { get; set; }
    //    public string RaVienMP_CoKinh { get; set; }
    //    public string RaVienMT_CoKinh { get; set; }
    //    public string RaVienNhanApMP { get; set; }
    //    public string RaVienNhanApMT { get; set; }
    //    public bool HuongDieuTri_TheoDoi { get; set; }
    //    public string HuongDieuTri_TheoDoiText { get; set; }
    //    public bool HuongDieuTri_PhauThuat { get; set; }
    //    public string HuongDieuTri_PhauThuatText { get; set; }
    //    public bool HuongDieuTri_Laser { get; set; }
    //    public string HuongDieuTri_LaserText { get; set; }
    //    public bool HuongDieuTri_Thuoc { get; set; }
    //    public string HuongDieuTri_ThuocText { get; set; }
    //    public List<ThuocHaNhanApDaDungs> ThuocHaNhanApDaDung { get; set; }
    //}
    public class MauHoiBenhKhamBenhFunc
    {
        public static bool saveTemplate(object _BenhAn, object HoiBenh)
        {
            try
            {
                PropertyCopier<object, object>.CopyProperty(_BenhAn, HoiBenh);
            }
            catch (Exception ex) { XuLyLoi.Handle(ex); }
            return false;
        }
        public static int InsertOrUpdate(MDB.MDBConnection MyConnection, MauHoiBenhKhamBenh MauHoiBenh, int LoaiMau)
        {
            try
            {
                string sql = "";
                if (MauHoiBenh.ID != 0)
                    sql = "UPDATE MAUHOIBENHKHAMBENH SET TENMAU = :TENMAU, NOIDUNG = :NOIDUNG, LOAIBENHAN = :LOAIBENHAN, IDKHOA = :IDKHOA, TENKHOA = :TENKHOA, LoaiMau =:LoaiMau WHERE ID = :ID";
                else
                    sql = "INSERT INTO MAUHOIBENHKHAMBENH (TENMAU, NOIDUNG, LOAIBENHAN, IDKHOA, TENKHOA, LoaiMau) VALUES (:TENMAU, :NOIDUNG, :LOAIBENHAN, :IDKHOA, :TENKHOA, :LoaiMau) RETURNING ID INTO :ID";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
                Command.Parameters.Add(new MDB.MDBParameter("TENMAU", MauHoiBenh.TenMau));
                Command.Parameters.Add(new MDB.MDBParameter("NOIDUNG", MauHoiBenh.NoiDungMau));
                Command.Parameters.Add(new MDB.MDBParameter("LOAIBENHAN", (int)MauHoiBenh.LoaiBenhAn));
                Command.Parameters.Add(new MDB.MDBParameter("IDKHOA", MauHoiBenh.MaKhoa));
                Command.Parameters.Add(new MDB.MDBParameter("TENKHOA", MauHoiBenh.TenKhoa));
                Command.Parameters.Add(new MDB.MDBParameter("LoaiMau", LoaiMau));
                Command.Parameters.Add(new MDB.MDBParameter("ID", MauHoiBenh.ID));

                int n = Command.ExecuteNonQuery();
                int nextval = Convert.ToInt32((Command.Parameters["ID"] as MDB.MDBParameter).Value.ToString());
                return n > 0 ? nextval : 0;
            }
            catch (Exception ex) { XuLyLoi.Handle(ex); }
            return 0;
        }
        public static int CheckForDuplication(MDB.MDBConnection MyConnection, string TenMau, LoaiBenhAnEMR LoaiBenhAn, string sMaKhoa, int LoaiMau)
        {
            int rowCount = 0;
            try
            {
                string sql = "Select ID from MAUHOIBENHKHAMBENH WHERE LOAIBENHAN = :LOAIBENHAN AND (IDKHOA = :IDKHOA OR IDKHOA = '' OR IDKHOA IS NULL) AND TENMAU = :TENMAU AND (LoaiMau = :LoaiMau  OR  LoaiMau IS NULL)";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
                Command.Parameters.Add(new MDB.MDBParameter("LOAIBENHAN", (int)LoaiBenhAn));
                Command.Parameters.Add(new MDB.MDBParameter("IDKHOA", sMaKhoa));
                Command.Parameters.Add(new MDB.MDBParameter("TENMAU", TenMau));
                Command.Parameters.Add(new MDB.MDBParameter("LoaiMau", LoaiMau));
                MDB.MDBDataReader DataReader = Command.ExecuteReader();
                while (DataReader.Read())
                {
                    rowCount = Convert.ToInt32(DataReader.GetLong("ID"));
                };
            }
            catch (Exception ex) { XuLyLoi.Handle(ex); }
            return rowCount;
        }
        public static List<MauHoiBenhKhamBenh> GetData(MDB.MDBConnection MyConnection, LoaiBenhAnEMR LoaiBenhAn, string sMaKhoa, int LoaiMau)
        {
            List<MauHoiBenhKhamBenh> lstData = new List<MauHoiBenhKhamBenh>();
            try
            {
                string sql = "Select * from MAUHOIBENHKHAMBENH WHERE LOAIBENHAN = :LOAIBENHAN AND (IDKHOA = :IDKHOA OR IDKHOA = '' OR IDKHOA IS NULL) AND (LoaiMau = :LoaiMau  OR  LoaiMau IS NULL)";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
                Command.Parameters.Add(new MDB.MDBParameter("LOAIBENHAN", (int)LoaiBenhAn));
                Command.Parameters.Add(new MDB.MDBParameter("IDKHOA", sMaKhoa));
                Command.Parameters.Add(new MDB.MDBParameter("LoaiMau", LoaiMau));
                MDB.MDBDataReader DataReader = Command.ExecuteReader();
                while (DataReader.Read())
                {
                    MauHoiBenhKhamBenh mauHoiBenh = new MauHoiBenhKhamBenh();
                    mauHoiBenh.ID = Convert.ToInt32(DataReader.GetLong("ID"));
                    mauHoiBenh.TenMau = DataReader["TENMAU"].ToString();
                    mauHoiBenh.NoiDungMau = DataReader["NOIDUNG"].ToString();
                    mauHoiBenh.LoaiBA = Convert.ToInt32(DataReader.GetLong("LOAIBENHAN").ToString());
                    mauHoiBenh.MaKhoa = DataReader["IDKHOA"].ToString();
                    mauHoiBenh.TenKhoa = DataReader["TENKHOA"].ToString();
                    mauHoiBenh.LoaiMau = Common.ConDB_Int(DataReader["LoaiMau"].ToString());
                    lstData.Add(mauHoiBenh);
                }
            }
            catch (Exception ex) { XuLyLoi.Handle(ex); }
            return lstData;
        }
        //public static MauHoiBenhKhamBenh SelectItem(MDB.MDBConnection MyConnection, string ID)
        //{
        //    MauHoiBenhKhamBenh getItem = new MauHoiBenhKhamBenh();
        //    try
        //    {
        //        string sql = "SELECT * FROM MAUHOIBENHKHAMBENH WHERE ID = :ID";
        //        MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
        //        Command.Parameters.Add(new MDB.MDBParameter("ID", ID));
        //        MDB.MDBDataReader DataReader = Command.ExecuteReader();
        //        while (DataReader.Read())
        //        {
        //            getItem.ID = Convert.ToInt32(DataReader.GetLong("ID"));
        //            getItem.TenMau = DataReader["TENMAU"].ToString();
        //            getItem.LoaiBA = Convert.ToInt32(DataReader.GetLong("LOAIBENHAN").ToString());
        //            getItem.NoiDungMau = DataReader["NOIDUNG"].ToString();
        //            getItem.LoaiMau = Common.ConDB_Int(DataReader.GetLong("LoaiMau").ToString());
        //        }
        //    }
        //    catch (Exception ex) { XuLyLoi.Handle(ex); }
        //    return getItem;
        //}
        public static int DeleteItem(MDB.MDBConnection MyConnection, int ID)
        {
            int n = 0;
            try
            {
                string sql = "DELETE MAUHOIBENHKHAMBENH WHERE ID = :ID";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
                Command.Parameters.Add(new MDB.MDBParameter("ID", ID));
                return n = Command.ExecuteNonQuery();
            }
            catch (Exception ex) { XuLyLoi.Handle(ex); }
            return n;
        }
        public enum LoaiMau
        {
            HoiBenh = 1,
            KhamBenh = 2,
            TongKet = 3
        }
    }
    public class PropertyCopier<TParent, TChild> where TParent : class where TChild : class
    {
        public static void CopyProperty(TParent parent, TChild child)
        {
            var parentProperties = parent.GetType().GetProperties();
            var childProperties = child.GetType().GetProperties();

            foreach (var parentProperty in parentProperties)
            {
                foreach (var childProperty in childProperties)
                {
                    if (parentProperty.Name == childProperty.Name && parentProperty.PropertyType == childProperty.PropertyType)
                    {
                        childProperty.SetValue(child, parentProperty.GetValue(parent));
                        break;
                    }
                }
            }
        }
    }
}
