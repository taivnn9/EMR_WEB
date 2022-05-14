using Cda2Fhir;
using EMR.KyDienTu;
using EMR_MAIN.DATABASE;
using Newtonsoft.Json;
using PMS.Access;
using System;

namespace EMR_MAIN
{
    public interface IBenhAnMatBanPhanTruoc
    {
        int IDMauPhieu { get; set; }
        string TenMauPhieu { get; set; }
        string ThoiGianXuatHienBenh { get; set; }
        string NguyenNhan_BenhSu { get; set; }
        string CacPhuongPhapDaDieuTri_BenhSu { get; set; }
        string TienSuBenhBanThan_Mat { get; set; }
        string TienSuBenhGiaDinh_Mat { get; set; }
        string KhongKinh_ThiLuc_MP { get; set; }
        string QuaLo_ThiLuc_MP { get; set; }
        string CoChinhKinh_ThiLuc_MP { get; set; }
        string NhinGan_ThiLuc_MP { get; set; }
        string NhanAp_MP { get; set; }
        string LacVaVanNhan_MP { get; set; }
        bool ThoatNuocTot_MP { get; set; }
        bool TraoLeQuanDoiDien_MP { get; set; }
        bool TraoLeQuanTaiCho_MP { get; set; }
        int MiMat_MP { get; set; }
        string Khac_MiMat_MP { get; set; }
        bool UMi_MP { get; set; }
        string TinhChatU_UMi_MP { get; set; }
        string ViTri_UMi_MP { get; set; }
        string KichThuoc_UMi_MP { get; set; }
        bool Quam_MiMat_MP { get; set; }
        int MiTren_MiMat_MP { get; set; }
        int MiDuoi_MiMat_MP { get; set; }
        bool HoMi_MiMat_MP { get; set; }
        bool TreMi_MiMat_MP { get; set; }
        int KhuyetMi_MiMat_MP { get; set; }
        int TuyetBoMi_MiMat_MP { get; set; }
        bool ViemBoMi_MiMat_MP { get; set; }
        string TonThuongKhac_MiMat_MP { get; set; }
        int CuongTu_KetMac_MP { get; set; }
        bool PhuNe_KetMac_MP { get; set; }
        bool XuatHuyet_KetMac_MP { get; set; }
        bool SungHoa_KetMac_MP { get; set; }
        bool Nhu_KetMac_MP { get; set; }
        bool Hot_KetMac_MP { get; set; }
        bool Seo_KetMac_MP { get; set; }
        bool TietToMu_KetMac_MP { get; set; }
        bool TietToTrong_KetMac_MP { get; set; }
        bool GiaMac_KetMac_MP { get; set; }
        bool BatMauFluor_KetMac_MP { get; set; }
        string TinhChat_UKetMac_MP { get; set; }
        string ViTri_UKetMac_MP { get; set; }
        string KichThuoc_UKetMac_MP { get; set; }
        int CungDo_KetMac_MP { get; set; }
        int ChieuCaoCuaCauDinh_KetMac_MP { get; set; }
        int DoRongCuaCauDinh_KetMac_MP { get; set; }
        string TonThuongKhac_KetMac_MP { get; set; }
        int KichThuoc_GiacMac_MP { get; set; }
        int HinhDang_GiacMac_MP { get; set; }
        bool BieuMo_GiacMac_MP { get; set; }
        int PhuBongBieuMo_GiacMac_MP { get; set; }
        int MatBieuMo_GiacMac_MP { get; set; }
        int MatBieuMoKhoangCach_MP { get; set; }
        int BoTonThuong_GM_MP { get; set; }
        bool ThoaiThoaDaiBang_MP { get; set; }
        bool LangDongThuoc_MP { get; set; }
        string TonThuongKhac_BieuMo_GM_MP { get; set; }
        int Phu_NhuMo_GiacMac_MP { get; set; }
        int ThamLau_NhuMo_GiacMac_MP { get; set; }
        int ThamLau_Vtri_NhuMo_GiacMac_MP { get; set; }
        int TieuMong_NhuMo_GiacMac_MP { get; set; }
        int TieuMong_Vtri_NhuMo_GiacMac_MP { get; set; }
        string TonThuongKhac_NhuMo_GiacMac_MP { get; set; }
        int NepGap_NoiMo_GiacMac_MP { get; set; }
        bool TuaSacToMacSauGM_MP { get; set; }
        bool MuMatSau_NoiMo_MP { get; set; }
        bool XuatTietMatSau_NoiMo_MP { get; set; }
        bool Guttata_NoiMo_MP { get; set; }
        bool RanMangDescemet_NoiMo_MP { get; set; }
        bool CuonDescemet_NoiMo_MP { get; set; }
        string TonThuongKhac_NoiMo_MP { get; set; }
        bool DoaThung_GiacMac_MP { get; set; }
        bool KetMongMat_GiacMac_MP { get; set; }
        int ThungGiacMac_MP { get; set; }
        bool Seidel_MP { get; set; }
        string DuongKinhThungGiacMac_MP { get; set; }
        bool ThungBit_GM_MP { get; set; }
        int CamGiacGiacMac_MP { get; set; }
        int TanMach_GiacMac_MP { get; set; }
        int MucDo_TanMach_GiacMac_MP { get; set; }
        bool SuyTeBaoNguon_MP { get; set; }
        bool ThoaiHoaGia_MP { get; set; }
        bool LangDongCanXi_MP { get; set; }
        string BatThuongKhac_GiacMac_MP { get; set; }
        int Viem_CungMac_MP { get; set; }
        bool Viem_NongSau_CungMac_MP { get; set; }
        bool ViemThuongCungMac_MP { get; set; }
        int GianLoi_TieuMong_HoaiTu_MP { get; set; }
        string ChiTietKhac_CungMac_MP { get; set; }
        int TienPhong_MP { get; set; }
        string Mu_TienPhong_MP { get; set; }
        bool Tydal_MP { get; set; }
        bool MangXuatTiet_MP { get; set; }
        string Mau_TienPhong_MP { get; set; }
        string TonThuongKhac_TienPhong_MP { get; set; }
        bool NauXop_MP { get; set; }
        bool XoTeo_MP { get; set; }
        bool CuongTu_MP { get; set; }
        bool TanMach_MP { get; set; }
        bool Phoi_MP { get; set; }
        bool Ket_MP { get; set; }
        string DuongKinh_DongTu_MP { get; set; }
        int DongTuTronMeoDinh_MP { get; set; }
        string ViTriDinh_DongTu_MP { get; set; }
        int PhanXaDongTu_MP { get; set; }
        string TonThuongKhac_DongTu_MP { get; set; }
        bool ThuyTinhThe_MP { get; set; }
        string HinhThaiDuc_ThuyTinhthe_MP { get; set; }
        int IOL_CanLechDuc_MP { get; set; }
        bool IOL_TrongTPHP_MP { get; set; }
        string TonThuongKhac_ThuyTinhthe_MP { get; set; }
        int AnhDongTu_MP { get; set; }
        int DichKinh_MP { get; set; }
        string TonThuongKhac_DichKinh_MP { get; set; }
        int DayMat_MP { get; set; }
        string CD_DayMat_MP { get; set; }
        bool PhuGai_MP { get; set; }
        bool BacMauGaiThi_MP { get; set; }
        string VongMac_DayMat_MP { get; set; }
        string HeMachMau_DayMat_MP { get; set; }
        string TonThuongKhac_DayMat_MP { get; set; }
        string KhongKinh_ThiLuc_MT { get; set; }
        string QuaLo_ThiLuc_MT { get; set; }
        string CoChinhKinh_ThiLuc_MT { get; set; }
        string NhinGan_ThiLuc_MT { get; set; }
        string NhanAp_MT { get; set; }
        string LacVaVanNhan_MT { get; set; }
        bool ThoatNuocTot_MT { get; set; }
        bool TraoLeQuanDoiDien_MT { get; set; }
        bool TraoLeQuanTaiCho_MT { get; set; }
        int MiMat_MT { get; set; }
        string Khac_MiMat_MT { get; set; }
        bool UMi_MT { get; set; }
        string TinhChatU_UMi_MT { get; set; }
        string ViTri_UMi_MT { get; set; }
        string KichThuoc_UMi_MT { get; set; }
        bool Quam_MiMat_MT { get; set; }
        int MiTren_MiMat_MT { get; set; }
        int MiDuoi_MiMat_MT { get; set; }
        bool HoMi_MiMat_MT { get; set; }
        bool TreMi_MiMat_MT { get; set; }
        int KhuyetMi_MiMat_MT { get; set; }
        int TuyetBoMi_MiMat_MT { get; set; }
        bool ViemBoMi_MiMat_MT { get; set; }
        string TonThuongKhac_MiMat_MT { get; set; }
        int CuongTu_KetMac_MT { get; set; }
        bool PhuNe_KetMac_MT { get; set; }
        bool XuatHuyet_KetMac_MT { get; set; }
        bool SungHoa_KetMac_MT { get; set; }
        bool Nhu_KetMac_MT { get; set; }
        bool Hot_KetMac_MT { get; set; }
        bool Seo_KetMac_MT { get; set; }
        bool TietToMu_KetMac_MT { get; set; }
        bool TietToTrong_KetMac_MT { get; set; }
        bool GiaMac_KetMac_MT { get; set; }
        bool BatMauFluor_KetMac_MT { get; set; }
        string TinhChat_UKetMac_MT { get; set; }
        string ViTri_UKetMac_MT { get; set; }
        string KichThuoc_UKetMac_MT { get; set; }
        int CungDo_KetMac_MT { get; set; }
        int ChieuCaoCuaCauDinh_KetMac_MT { get; set; }
        int DoRongCuaCauDinh_KetMac_MT { get; set; }
        string TonThuongKhac_KetMac_MT { get; set; }
        int KichThuoc_GiacMac_MT { get; set; }
        int HinhDang_GiacMac_MT { get; set; }
        bool BieuMo_GiacMac_MT { get; set; }
        int PhuBongBieuMo_GiacMac_MT { get; set; }
        int MatBieuMo_GiacMac_MT { get; set; }
        int MatBieuMoKhoangCach_MT { get; set; }
        int BoTonThuong_GM_MT { get; set; }
        bool ThoaiThoaDaiBang_MT { get; set; }
        bool LangDongThuoc_MT { get; set; }
        string TonThuongKhac_BieuMo_GM_MT_TXT { get; set; }
        int Phu_NhuMo_GiacMac_MT { get; set; }
        int ThamLau_NhuMo_GiacMac_MT { get; set; }
        int ThamLau_Vtri_NhuMo_GiacMac_MT { get; set; }
        int TieuMong_NhuMo_GiacMac_MT { get; set; }
        int TieuMong_Vtri_NhuMo_GiacMac_MT { get; set; }
        string TonThuongKhac_NhuMo_GiacMac_MT { get; set; }
        int NepGap_NoiMo_GiacMac_MT { get; set; }
        bool TuaSacToMacSauGM_MT { get; set; }
        bool MuMatSau_NoiMo_MT { get; set; }
        bool XuatTietMatSau_NoiMo_MT { get; set; }
        bool Guttata_NoiMo_MT { get; set; }
        bool RanMangDescemet_NoiMo_MT { get; set; }
        bool CuonDescemet_NoiMo_MT { get; set; }
        string TonThuongKhac_NoiMo_MT { get; set; }
        bool DoaThung_GiacMac_MT { get; set; }
        bool KetMongMat_GiacMac_MT { get; set; }
        int ThungGiacMac_MT { get; set; }
        bool Seidel_MT { get; set; }
        string DuongKinhThungGiacMac_MT { get; set; }
        bool ThungBit_GM_MT { get; set; }
        int CamGiacGiacMac_MT { get; set; }
        int TanMach_GiacMac_MT { get; set; }
        int MucDo_TanMach_GiacMac_MT { get; set; }
        bool SuyTeBaoNguon_MT { get; set; }
        bool ThoaiHoaGia_MT { get; set; }
        bool LangDongCanXi_MT { get; set; }
        string BatThuongKhac_GiacMac_MT { get; set; }
        int Viem_CungMac_MT { get; set; }
        bool Viem_NongSau_CungMac_MT { get; set; }
        bool ViemThuongCungMac_MT { get; set; }
        int GianLoi_TieuMong_HoaiTu_MT { get; set; }
        string ChiTietKhac_CungMac_MT { get; set; }
        int TienPhong_MT { get; set; }
        string Mu_TienPhong_MT { get; set; }
        bool Tydal_MT { get; set; }
        bool MangXuatTiet_MT { get; set; }
        string Mau_TienPhong_MT { get; set; }
        string TonThuongKhac_TienPhong_MT { get; set; }
        bool NauXop_MT { get; set; }
        bool XoTeo_MT { get; set; }
        bool CuongTu_MT { get; set; }
        bool TanMach_MT { get; set; }
        bool Phoi_MT { get; set; }
        bool Ket_MT { get; set; }
        string DuongKinh_DongTu_MT { get; set; }
        int DongTuTronMeoDinh_MT { get; set; }
        string ViTriDinh_DongTu_MT { get; set; }
        int PhanXaDongTu_MT { get; set; }
        string TonThuongKhac_DongTu_MT { get; set; }
        bool ThuyTinhThe_MT { get; set; }
        string HinhThaiDuc_ThuyTinhthe_MT { get; set; }
        int IOL_CanLechDuc_MT { get; set; }
        bool IOL_TrongTPHP_MT { get; set; }
        string TonThuongKhac_ThuyTinhthe_MT { get; set; }
        int AnhDongTu_MT { get; set; }
        int DichKinh_MT { get; set; }
        string TonThuongKhac_DichKinh_MT { get; set; }
        int DayMat_MT { get; set; }
        string CD_DayMat_MT { get; set; }
        bool PhuGai_MT { get; set; }
        bool BacMauGaiThi_MT { get; set; }
        string VongMac_DayMat_MT { get; set; }
        string HeMachMau_DayMat_MT { get; set; }
        string TonThuongKhac_DayMat_MT { get; set; }
        string HuyetAp_ToanThan { get; set; }
        string NhietDo_ToanThan { get; set; }
        string Mach_ToanThan { get; set; }
        bool NoiTiet_Tick { get; set; }
        string NoiTiet { get; set; }
        bool ThanKinh_Tick { get; set; }
        bool TuanHoan_Tick { get; set; }
        bool HoHap_Tick { get; set; }
        bool TieuHoa_Tick { get; set; }
        bool CoXuongKhop_Tick { get; set; }
        bool ThanTietNieu_Tick { get; set; }
        string BenhChinh_MatPhai { get; set; }
        string BenhChinh_MatTrai { get; set; }
        string PhuongPhapChinh { get; set; }
        string CheDoAnUong { get; set; }
        string CheDoChamSoc { get; set; }
        string ChanDoanBenhChinh_LamSang { get; set; }
        string ChanDoanBenhChinh_NguyenNhan { get; set; }
        string QuaTrinhDieuTri_NoiKhoa { get; set; }
        string QuaTrinhDieuTri_KetQua { get; set; }
        string QuaTrinhDieuTri_BienChung { get; set; }
        string HuongDieuTriTiep { get; set; }
        int iQuam_MiMat_MP { get; set; }
        int iQuam_MiMat_MT { get; set; }
        int iThungBit_GM_MP { get; set; }
        int iThungBit_GM_MT { get; set; }
        int iViem_NongSau_CungMac_MP { get; set; }
        int iViem_NongSau_CungMac_MT { get; set; }
        int iThuyTinhThe_MP { get; set; }
        int iThuyTinhThe_MT { get; set; }
        int iIOL_TrongTPHP_MP { get; set; }
        int iIOL_TrongTPHP_MT { get; set; }
        bool ChuaThayBenhLy { get; set; }
        bool BenhLy { get; set; }
        string BenhLy_Text { get; set; }
        bool PhauThuat { set; get; }
        bool ThuThuat { get; set; }
        string ThiLucKhiRaVien_KhongKinh_MP { get; set; }
        string ThiLucKhiRaVien_KhongKinh_MT { get; set; }
        string ThiLucKhiRaVien_CoKinh_MP { get; set; }
        string ThiLucKhiRaVien_CoKinh_MT { get; set; }
        string NhanApRaVien_MT { get; set; }
        string NhanApRaVien_MP { get; set; }
        bool[] MiMat_P_Array { get; } 
        string MiMat_P { get; set; }
        bool[] MiMat_T_Array { get; } 
        string MiMat_T { get; set; }
        string ThoatNuocTot_MP_Text { get; set; }
        string ThoatNuocTot_MT_Text { get; set; }
        string TraoLeQuanDoiDien_MP_Text { get; set; }
        string TraoLeQuanDoiDien_MT_Text { get; set; }
        string TraoLeQuanTaiCho_MP_Text { get; set; }
        string TraoLeQuanTaiCho_MT_Text { get; set; }
        int KetMac_Mong_MP { get; set; }
        int KetMac_Mong_MT { get; set; }
        bool GhepGiacMac_MP { get; set; }
        bool GhepGiacMac_MT { get; set; }
        bool BieuMo_GiacMac_BT_MP { get; set; }
        bool BieuMo_GiacMac_BT_MT { get; set; }
        bool NhuMo_GiacMac_BT_MP { get; set; }
        bool NhuMo_GiacMac_BT_MT { get; set; }
        bool NoiMo_GiacMac_BT_MP { get; set; }
        bool NoiMo_GiacMac_BT_MT { get; set; }
        bool CungMac_BT_MP { get; set; }
        bool CungMac_BT_MT { get; set; }
        bool Khuyet_MP { get; set; }
        bool Khuyet_MT { get; set; }
        string Khac_MongMat_MP { get; set; }
        string Khac_MongMat_MT { get; set; }
        bool[] NoiTiet_Array { get; } 
        int NoiTietCheck { get; set; }
        string NoiTiet_Text { get; set; }
        bool[] ThanKinh_Array { get; } 
        int ThanKinhCheck { get; set; }
        string ThanKinh_Text { get; set; }
        bool[] TuanHoan_Array { get; } 
        int TuanHoanCheck { get; set; }
        string TuanHoan_Text { get; set; }
        bool[] HoHap_Array { get; } 
        int HoHapCheck { get; set; }
        string HoHap_Text { get; set; }
        bool[] TieuHoa_Array { get; } 
        int TieuHoaCheck { get; set; }
        string TieuHoa_Text { get; set; }
        bool[] CoXuongKhop_Array { get; } 
        int CoXuongKhopCheck { get; set; }
        string CoXuongKhop_Text { get; set; }
        bool[] TietNieuSinhDuc_Array { get; } 
        int TietNieuSinhDucCheck { get; set; }
        string TietNieuSinhDuc_Text { get; set; }
        string KhamBenhToanThan_Khac { get; set; }
        string LyDoVaoVien { get; set; }
        string TienSuBenhBanThan { get; set; }
        string TienSuBenhGiaDinh { get; set; }
    }

    public class BenhAnMatBanPhanTruoc : IBenhAnMatBanPhanTruoc, IBenhAnBase, IBase 
    {
        public int IDMauPhieu { get; set; } = (int)DanhMucPhieu.BAMBPT;
        public string TenMauPhieu { get; set; } = DanhMucPhieu.BAMBPT.Description();
        [MoTaDuLieu("Mã quản lý: mã duy nhất trong 1 đợt khám chữa bệnh (kcb), không trùng giữa các đợt kcb khác nhau", "", 1)]
        public decimal MaQuanLy { get; set; }

        [MoTaDuLieu("Lý do vào viện")]
        [CodeHL7("46239-0", "46239-0", "Chief complaint+Reason for visit")]
        [NhomThongTin(NhomThongTinBenhAn.HoiBenh)]
        public string LyDoVaoVien { get; set; }

        [MoTaDuLieu("Thời gian vào viện là ngày thứ mấy của bệnh")]
        [NhomThongTin(NhomThongTinBenhAn.HoiBenh)]
        public int VaoNgayThu { get; set; }

        [CodeHL7("10164-2", "10164-2", "History of Present illness Narrative", "370135005", "370135005", "Pathological process")]
        [MoTaDuLieu("Quá trình bệnh lý")]
        [NhomThongTin(NhomThongTinBenhAn.HoiBenh)]
        public string QuaTrinhBenhLy { get; set; }

        [MoTaDuLieu("Tiền sử bệnh bản thân")]
        [NhomThongTin(NhomThongTinBenhAn.HoiBenh)]
        [CodeHL7("67437-4", "67437-4", "Disease history")]
        public string TienSuBenhBanThan { get; set; }

        [CodeHL7("10157-6", "10157-6", "History of family member diseases", "137667000", "137667000", "Family history")]
        [MoTaDuLieu("Tiền sử bệnh gia đình")]
        [NhomThongTin(NhomThongTinBenhAn.HoiBenh)]
        public string TienSuBenhGiaDinh { get; set; }

        [NhomThongTin(NhomThongTinBenhAn.HoiBenh)]
        [MoTaDuLieu("Đặc điểm liên quan bệnh")]
        public DacDiemLienQuanBenh DacDiemLienQuanBenh { get; set; }

        [CodeHL7("8716-3", "8716-3", "Vital signs", "", "", "")]
        [NhomThongTin(NhomThongTinBenhAn.KhamBenh)]
        [MoTaDuLieu("Dấu sinh tồn")]
        public DauSinhTon DauSinhTon { get; set; }

        [MoTaDuLieu("Khám toàn thân")]
        [NhomThongTin(NhomThongTinBenhAn.KhamBenh)]
        [CodeHL7("55286-9", "55286-9", "Physical exam by body areas", "", "", "")]
        public string ToanThan { get; set; }

        [CodeHL7("", "", "", "256864008", "256864008", "Entire nerve")]
        [MoTaDuLieu("Khám thần kinh")]
        [JsonProperty("ThanKinh")]
        [NhomThongTin(NhomThongTinBenhAn.KhamBenh)]
        public string ThanKinh { get; set; }

        [MoTaDuLieu("Khám tuần hoàn")]
        [NhomThongTin(NhomThongTinBenhAn.KhamBenh)]
        [CodeHL7("20201-0", "20201-0", "Circulatory system")]
        public string TuanHoan { get; set; }

        [CodeHL7("53756-3", "53756-3", "Respiratory status", "714324006", "714324006", "Entire organ in respiratory system")]
        [MoTaDuLieu("Khám hô hấp")]
        [NhomThongTin(NhomThongTinBenhAn.KhamBenh)]
        public string HoHap { get; set; }

        [CodeHL7("", "", "", "272627002", "272627002", "Entire digestive orga")]
        [MoTaDuLieu("Khám tiêu hóa")]
        [NhomThongTin(NhomThongTinBenhAn.KhamBenh)]
        public string TieuHoa { get; set; }

        [CodeHL7("", "", "", "244716004,302536002", "244716004", "Entire skeletal muscle (organ)")]
        [MoTaDuLieu("Khám cơ xương khớp")]
        [NhomThongTin(NhomThongTinBenhAn.KhamBenh)]
        public string CoXuongKhop { get; set; }

        [MoTaDuLieu("Khám thận - tiết niệu - sinh dục")]
        [NhomThongTin(NhomThongTinBenhAn.KhamBenh)]
        [CodeHL7("46944-5", "46944-5", "Urinary Function Status")]
        public string ThanTietNieuSinhDuc { get; set; }

        [MoTaDuLieu("Khác")]
        [JsonProperty("ThongTinKhamBenhKhac")]
        [NhomThongTin(NhomThongTinBenhAn.KhamBenh)]
        public string Khac_CacCoQuan { get; set; }

        [NhomThongTin(NhomThongTinBenhAn.KhamBenh)]
        [MoTaDuLieu("Các xét nghiệm cận lâm sàng cần làm")]
        [CodeHL7("22032-7", "22032-7", "Lab tests.total")]
        public string CacXetNghiemCanLamSangCanLam { get; set; }

        [CodeHL7("55108-5", "55108-5", "Clinical presentation")]
        [MoTaDuLieu("Tóm tắt bệnh án", "", 0, 1, 1)]
        [NhomThongTin(NhomThongTinBenhAn.KhamBenh)]
        public string TomTatBenhAn { get; set; }

        [CodeHL7("42347-5", "42347-5", "Admission diagnosis")]
        [MoTaDuLieu("Bệnh chính", "", 0, 1, 1)]
        //[NhomThongTin(NhomThongTinBenhAn.ChanDoan_KhiVaoKDT)]
        public string BenhChinh { get; set; }

        [CodeHL7("54545-9", "54545-9", "Additional diagnoses")]
        //[NhomThongTin(NhomThongTinBenhAn.ChanDoan_KhiVaoKDT)]
        [MoTaDuLieu("Chẩn đoán bệnh kèm theo")]
        public string BenhKemTheo { get; set; }

        //[NhomThongTin(NhomThongTinBenhAn.ChanDoan_KhiVaoKDT)]
        [MoTaDuLieu("Chẩn đoán phân biệt")]
        [CodeHL7("92238-5", "92238-5", "Differential diagnosis")]
        public string PhanBiet { get; set; }

        [MoTaDuLieu("Tiên lượng")]
        [CodeHL7("75328-5", "75328-5", "Prognosis")]
        public string TienLuong { get; set; }

        [MoTaDuLieu("Hướng điều trị")]
        [CodeHL7("18657-7", "18657-7", "Plan of treatment")]
        public string HuongDieuTri { get; set; }

        [MoTaDuLieu("Bác sĩ làm bệnh án", "", 0, 1, 1)]
        [JsonProperty("BacSiLamBenhAn")]
        public string BacSyLamBenhAn { get; set; }

        [CodeHL7("10164-2", "10164-2", "History of Present illness Narrative", "370135005", "370135005", "Pathological process")]
        [JsonProperty("QuaTrinhBenhLyVaDienBienLamSang")]
        [NhomThongTin(NhomThongTinBenhAn.TongKet)]
        [MoTaDuLieu("Quá trình bệnh lý và diễn biến lâm sàng")]
        public string QuaTrinhBenhLyVaDienBien { get; set; }

        [CodeHL7("96552-5", "96552-5", "Result of most recent lab test for condition of interest", "74314007", "74314007", "Subclinical")]
        [NhomThongTin(NhomThongTinBenhAn.TongKet)]
        [MoTaDuLieu("Tóm tắt kết quả xét nghiệm cận lâm sàng có gia trị chẩn đoán")]
        public string TomTatKetQuaXetNghiem { get; set; }

        [CodeHL7("52468-6", "52468-6", "Major Treatments")]
        [NhomThongTin(NhomThongTinBenhAn.TongKet)]
        [MoTaDuLieu("Phương pháp điều trị")]
        public string PhuongPhapDieuTri { get; set; }

        [NhomThongTin(NhomThongTinBenhAn.TongKet)]
        [MoTaDuLieu("Tình trạng người bệnh ra viện")]
        [CodeHL7("52523-8", "52523-8", "Discharge status")]
        public string TinhTrangNguoiBenhRaVien { get; set; }

        [NhomThongTin(NhomThongTinBenhAn.TongKet)]
        [MoTaDuLieu("Hướng điều trị và các chế độ tiếp theo")]
        [CodeHL7("60513-9", "60513-9", "Treatment-subsequent & other section")]
        public string HuongDieuTriVaCacCheDoTiepTheo { get; set; }

        [MoTaDuLieu("Thông tin hồ sơ")]
        [NhomThongTin(NhomThongTinBenhAn.TongKet)]
        public HoSo HoSo { get; set; }

        [NhomThongTin(NhomThongTinBenhAn.TongKet)]
        [MoTaDuLieu("Người nhận hồ sơ")]
        public string NguoiNhanHoSo { get; set; }

        [NhomThongTin(NhomThongTinBenhAn.TongKet)]
        [MoTaDuLieu("Người giao hồ sơ")]
        public string NguoiGiaoHoSo { get; set; }

        [NhomThongTin(NhomThongTinBenhAn.TongKet)]
        [MoTaDuLieu("Ngày tổng kết")]
        [CodeHL7("71504-5", "71504-5", "Date closed")]
        public DateTime NgayTongKet { get; set; }

        [MoTaDuLieu("Bác sĩ điều trị")]
        [NhomThongTin(NhomThongTinBenhAn.TongKet)]
        [JsonProperty("BacSiDieuTri")]
        [CodeHL7("56854-3", "56854-3", "Inpatient practitioner")]
        public string BacSyDieuTri { get; set; }

        [CodeHL7("71392-5", "71392-5", "CMS - ear-nose-mouth-throat exam panel")]
        public string TaiMuiHong { get; set; }
        public string RangHamMat { get; set; }

        [CodeHL7("29271-4", "29271-4", "Eye physical examination")]
        public string Mat { get; set; }
        public DateTime NgayKhamBenh { get; set; }

        [MoTaDuLieu("Bác sĩ khám bệnh")]
        [JsonProperty("BacSiKhamBenh")]
        public string BacSyKhamBenh { get; set; }
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
        public int MiMat_MP { get; set; }
        public string Khac_MiMat_MP { get; set; }
        public bool UMi_MP { get; set; }
        public string TinhChatU_UMi_MP { get; set; }
        public string ViTri_UMi_MP { get; set; }
        public string KichThuoc_UMi_MP { get; set; }
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
        public string HuyetAp_ToanThan { get; set; }
        public string NhietDo_ToanThan { get; set; }
        public string Mach_ToanThan { get; set; }
        public bool NoiTiet_Tick { get; set; }
        public string NoiTiet { get; set; }
        public bool ThanKinh_Tick { get; set; }
        public bool TuanHoan_Tick { get; set; }
        public bool HoHap_Tick { get; set; }
        public bool TieuHoa_Tick { get; set; }
        public bool CoXuongKhop_Tick { get; set; }
        public bool ThanTietNieu_Tick { get; set; }
        public string BenhChinh_MatPhai { get; set; }
        public string BenhChinh_MatTrai { get; set; }
        public string PhuongPhapChinh { get; set; }
        public string CheDoAnUong { get; set; }
        public string CheDoChamSoc { get; set; }
        public string ChanDoanBenhChinh_LamSang { get; set; }
        public string ChanDoanBenhChinh_NguyenNhan { get; set; }
        public string QuaTrinhDieuTri_NoiKhoa { get; set; }
        public string QuaTrinhDieuTri_KetQua { get; set; }
        public string QuaTrinhDieuTri_BienChung { get; set; }
        public string HuongDieuTriTiep { get; set; }
        public int iQuam_MiMat_MP { get; set; }
        public int iQuam_MiMat_MT { get; set; }
        public int iThungBit_GM_MP { get; set; }
        public int iThungBit_GM_MT { get; set; }
        public int iViem_NongSau_CungMac_MP { get; set; }
        public int iViem_NongSau_CungMac_MT { get; set; }
        public int iThuyTinhThe_MP { get; set; }
        public int iThuyTinhThe_MT { get; set; }
        public int iIOL_TrongTPHP_MP { get; set; }
        public int iIOL_TrongTPHP_MT { get; set; }
        public bool ChuaThayBenhLy { get; set; }
        public bool BenhLy { get; set; }
        public string BenhLy_Text { get; set; }
        public bool PhauThuat { set; get; }
        public bool ThuThuat { get; set; }
        public string ThiLucKhiRaVien_KhongKinh_MP { get; set; }
        public string ThiLucKhiRaVien_KhongKinh_MT { get; set; }
        public string ThiLucKhiRaVien_CoKinh_MP { get; set; }
        public string ThiLucKhiRaVien_CoKinh_MT { get; set; }
        public string NhanApRaVien_MT { get; set; }
        public string NhanApRaVien_MP { get; set; }
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
        // bactv changed : 
        public bool[] MiMat_P_Array { get; } = new bool[] { false, false, false, false, false, false };
        public string MiMat_P
        {
            get
            {
                string temp = string.Empty;
                for (int i = 0; i < MiMat_P_Array.Length; i++)
                    temp += (MiMat_P_Array[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        MiMat_P_Array[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public bool[] MiMat_T_Array { get; } = new bool[] { false, false, false, false, false, false };
        public string MiMat_T
        {
            get
            {
                string temp = string.Empty;
                for (int i = 0; i < MiMat_T_Array.Length; i++)
                    temp += (MiMat_T_Array[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        MiMat_T_Array[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        // bactv added
        public string ThoatNuocTot_MP_Text { get; set; }
        public string ThoatNuocTot_MT_Text { get; set; }
        public string TraoLeQuanDoiDien_MP_Text { get; set; }
        public string TraoLeQuanDoiDien_MT_Text { get; set; }
        public string TraoLeQuanTaiCho_MP_Text { get; set; }
        public string TraoLeQuanTaiCho_MT_Text { get; set; }
        public int KetMac_Mong_MP { get; set; }
        public int KetMac_Mong_MT { get; set; }
        public bool GhepGiacMac_MP { get; set; }
        public bool GhepGiacMac_MT { get; set; }
        public bool BieuMo_GiacMac_BT_MP { get; set; }
        public bool BieuMo_GiacMac_BT_MT { get; set; }
        public bool NhuMo_GiacMac_BT_MP { get; set; }
        public bool NhuMo_GiacMac_BT_MT { get; set; }
        public bool NoiMo_GiacMac_BT_MP { get; set; }
        public bool NoiMo_GiacMac_BT_MT { get; set; }
        public bool CungMac_BT_MP { get; set; }
        public bool CungMac_BT_MT { get; set; }
        public bool Khuyet_MP { get; set; }
        public bool Khuyet_MT { get; set; }
        public string Khac_MongMat_MP { get; set; }
        public string Khac_MongMat_MT { get; set; }
        //https://redmine.vietsens.vn/redmine/issues/70709
        public bool[] NoiTiet_Array { get; } = new bool[] { false, false };
        public int NoiTietCheck
        {
            get
            {
                return Array.IndexOf(NoiTiet_Array, true) + 1;
            }
            set
            {
                for (int i = 0; i < NoiTiet_Array.Length; i++)
                {
                    if (i == (value - 1)) NoiTiet_Array[i] = true;
                    else NoiTiet_Array[i] = false;
                }
            }
        }
        public string NoiTiet_Text { get; set; }
        public bool[] ThanKinh_Array { get; } = new bool[] { false, false };
        public int ThanKinhCheck
        {
            get
            {
                return Array.IndexOf(ThanKinh_Array, true) + 1;
            }
            set
            {
                for (int i = 0; i < ThanKinh_Array.Length; i++)
                {
                    if (i == (value - 1)) ThanKinh_Array[i] = true;
                    else ThanKinh_Array[i] = false;
                }
            }
        }
        public string ThanKinh_Text { get; set; }
        public bool[] TuanHoan_Array { get; } = new bool[] { false, false };
        public int TuanHoanCheck
        {
            get
            {
                return Array.IndexOf(TuanHoan_Array, true) + 1;
            }
            set
            {
                for (int i = 0; i < TuanHoan_Array.Length; i++)
                {
                    if (i == (value - 1)) TuanHoan_Array[i] = true;
                    else TuanHoan_Array[i] = false;
                }
            }
        }
        public string TuanHoan_Text { get; set; }
        public bool[] HoHap_Array { get; } = new bool[] { false, false };
        public int HoHapCheck
        {
            get
            {
                return Array.IndexOf(HoHap_Array, true) + 1;
            }
            set
            {
                for (int i = 0; i < HoHap_Array.Length; i++)
                {
                    if (i == (value - 1)) HoHap_Array[i] = true;
                    else HoHap_Array[i] = false;
                }
            }
        }
        public string HoHap_Text { get; set; }
        public bool[] TieuHoa_Array { get; } = new bool[] { false, false };
        public int TieuHoaCheck
        {
            get
            {
                return Array.IndexOf(TieuHoa_Array, true) + 1;
            }
            set
            {
                for (int i = 0; i < TieuHoa_Array.Length; i++)
                {
                    if (i == (value - 1)) TieuHoa_Array[i] = true;
                    else TieuHoa_Array[i] = false;
                }
            }
        }
        public string TieuHoa_Text { get; set; }
        public bool[] CoXuongKhop_Array { get; } = new bool[] { false, false };
        public int CoXuongKhopCheck
        {
            get
            {
                return Array.IndexOf(CoXuongKhop_Array, true) + 1;
            }
            set
            {
                for (int i = 0; i < CoXuongKhop_Array.Length; i++)
                {
                    if (i == (value - 1)) CoXuongKhop_Array[i] = true;
                    else CoXuongKhop_Array[i] = false;
                }
            }
        }
        public string CoXuongKhop_Text { get; set; }
        public bool[] TietNieuSinhDuc_Array { get; } = new bool[] { false, false };
        public int TietNieuSinhDucCheck
        {
            get
            {
                return Array.IndexOf(TietNieuSinhDuc_Array, true) + 1;
            }
            set
            {
                for (int i = 0; i < TietNieuSinhDuc_Array.Length; i++)
                {
                    if (i == (value - 1)) TietNieuSinhDuc_Array[i] = true;
                    else TietNieuSinhDuc_Array[i] = false;
                }
            }
        }
        public string TietNieuSinhDuc_Text { get; set; }
        public string KhamBenhToanThan_Khac { get; set; }
        public string SoLuuTru { get; set; }
    }
}
