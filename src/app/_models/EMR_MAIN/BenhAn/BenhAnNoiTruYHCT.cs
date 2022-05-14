using EMR.KyDienTu;
using EMR_MAIN.DATABASE;
using PMS.Access;

namespace EMR_MAIN
{
    public class BenhAnNoiTruYHCT : BenhAnBase, IBase
    {
        public int IDMauPhieu { get; set; } = (int)DanhMucPhieu.BANoiTruYHCT;
        public string TenMauPhieu { get; set; } = DanhMucPhieu.BANoiTruYHCT.Description();
        public string BenhSu { get; set; }
        public string MoTaChiTietCoQuanBenhLy { get; set; }
        public bool HinhThai_Gay { get; set; }
        public string ChanDoan_NoiChuyenDen_YHCT { get; set; }
        public string MaICD_NoiChuyenDen_YHCT { get; set; }
        public string ChanDoan_KKB_CapCuu_YHCT { get; set; }
        public string MaICD_KKB_CapCuu_YHCT { get; set; }
        public string BenhChinh_YHCT { get; set; }
        public string MaICD_BenhChinh_YHCT { get; set; }
        public string BenhKemTheo_YHCT { get; set; }
        public string MaICD_BenhKemTheo_YHCT { get; set; }
        public bool ThuThuat_YHCT { get; set; }
        public bool PhauThuat_YHCT { get; set; }
        public string BenhChinh_RV_YHCT { get; set; }
        public string MaICD_BenhChinh_RV_YHCT { get; set; }
        public string BenhKemTheo_RV_YHCT { get; set; }
        public string MaICD_BenhKemTheo_RV_YHCT { get; set; }
        public bool TaiBien_YHCT { get; set; }
        public bool BienChung_YHCT { get; set; }
        public string MaICD_BenhKemTheo_YHHD { get; set; }
        // add
        public string MaICD_BenhChinh_YHHD_CD { get; set; }
        public string MaICD_BenhKemTheo_YHHD_CD { get; set; }
        public bool Bung_Dau { get; set; }
        public bool ChanTay_Dau { get; set; }
        public bool ChanTay_Te { get; set; }
        public bool ChanTay_Buon { get; set; }
        public bool ChanTay_Moi { get; set; }
        public bool ChanTay_Nhuc { get; set; }
        public bool ChanTay_Nong { get; set; }
        public bool ChanTay_Lanh { get; set; }
        public bool ChanTay_Khac { get; set; }
        public bool Nam_Khac { get; set; }
        public bool Nu_DongThai { get; set; }
        public bool Nu_SayThai { get; set; }
        public bool MacChan_Nhu { get; set; }
        public bool DinhViBenhTheo_Ve { get; set; }
        public bool DinhViBenhTheo_Khi { get; set; }
        public bool DinhViBenhTheo_Dinh { get; set; }
        public bool DinhViBenhTheo_Huyet { get; set; }
        public bool NguyenNhan_NoiNhan { get; set; }
        public bool NguyenNhan_NgoaiNhan { get; set; }
        public bool NguyenNhan_BatNoiNgoai { get; set; }
        public bool TangPhu_Tam { get; set; }
        public bool TangPhu_Lan { get; set; }
        public bool TangPhu_Ty { get; set; }
        public bool TangPhu_Phe { get; set; }
        public bool TangPhu_Than { get; set; }
        public bool TangPhu_TamBao { get; set; }
        public bool TangPhu_TieuTruong { get; set; }
        public bool TangPhu_Dom { get; set; }
        public bool TangPhu_Vi { get; set; }
        public bool TangPhu_DaiTruong { get; set; }
        public bool TangPhu_BangQuang { get; set; }
        public bool TangPhu_TamTieu { get; set; }
        public bool TangPhu_PhuKyHang { get; set; }
        public bool KinhMach_Tam { get; set; }
        public bool DauDau_DauThat { get; set; }
        public bool DauDau_Khac { get; set; }
        public bool Mat_Dau { get; set; }
        public bool Mat_Khac { get; set; }
        public bool Mui_Khac { get; set; }
        public bool Hong_Khac { get; set; }
        public bool KinhMach_Lan { get; set; }
        public bool KinhMach_Ty { get; set; }
        public bool KinhMach_Phe { get; set; }
        public bool KinhMach_Than { get; set; }
        public bool KinhMach_TamBao { get; set; }
        public bool KinhMach_TieuTruong { get; set; }
        public bool KinhMach_Dom { get; set; }
        public bool KinhMach_Vi { get; set; }
        public bool KinhMach_DaiTruong { get; set; }
        public bool KinhMach_BangQuang { get; set; }
        public bool KinhMach_TamTieu { get; set; }
        public bool KinhMach_MachDoc { get; set; }
        public bool KinhMach_MachNham { get; set; }
        public bool BatCuong_Bieu { get; set; }
        public bool BatCuong_Ly { get; set; }
        public bool BatCuong_Hu { get; set; }
        public bool BatCuong_Thuc { get; set; }
        public bool BatCuong_Han { get; set; }
        public bool BatCuong_Nhiet { get; set; }
        public bool BatCuong_Am { get; set; }
        public bool BatCuong_Duong { get; set; }

        public bool Bung { get; set; }
        public bool DoiHa { get; set; }
        public bool CoXuongKhop_BinhThuong { get; set; }
        public bool Bung_BinhThuong { get; set; }

        public string PPKhongDungThuoc { get; set; }
        public string PPKhac { get; set; }
        public string MotaTienSuBanThan { get; set; }
        public string ChanDoanVVYHCT_BenhChinh { get; set; }
        public string ChanDoanVVYHCT_KemTheo { get; set; }
        public string MaICDChanDoanVVYHCT_BenhChinh { get; set; }
        public string MaICDChanDoanVVYHCT_KemTheo { get; set; }
        public string ChanDoanVVYHHD_BenhChinh { get; set; }
        public string ChanDoanVVYHD_KemTheo { get; set; }
        public string MaICDVVYHD_BenhChinh { get; set; }
        public string MaICDChanDoanVVYHD_KemTheo { get; set; }
        public string ChanDoanRVYHCT_BenhChinh { get; set; }
        public string ChanDoanRVYHCT_KemTheo { get; set; }
        public string MaICDChanDoanRVYHCT_BenhChinh { get; set; }
        public string MaICDChanDoanRVYHCT_KemTheo { get; set; }
        public string ChanDoanRVYHHD_BenhChinh { get; set; }
        public string ChanDoanRVYHD_KemTheo { get; set; }
        public string MaICDRVYHD_BenhChinh { get; set; }
        public string MaICDChanDoanRVYHD_KemTheo { get; set; }
        public string HOSOKQ_XQUANG { get; set; }
        public string HOSOKQ_CTSCANNER { get; set; }
        public string HOSOKQ_MRI { get; set; }
        public string HOSOKQ_KHAC_TXT { get; set; }
        public string HOSOKQ_KHAC { get; set; }
        public string HOSOKQ_TOANBOHOSO { get; set; }
        public bool CheDoDinhDuong_Long { get; set; }
        public bool CheDoDinhDuong_Dac { get; set; }
        public bool CheDoDinhDuong_Kieng { get; set; }
        public bool CheDoDinhDuong_Khac { get; set; }
        public bool CheDoChamSoc_1 { get; set; }
        public bool CheDoChamSoc_2 { get; set; }
        public bool CheDoChamSoc_3 { get; set; }


        //
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
        public string NguyenNhan { set; get; }
        public bool DieuTriYHCT { set; get; }
        public string PhapDieuTri { set; get; }
        public string PhuongThuoc { set; get; }
        public string PhuongHuyet { set; get; }
        public string XoaBopBamHuyet { set; get; }
        public string Khac_DieuTri { set; get; }
        public bool DieuTriKetHopVoiYHHD { set; get; }
        public string DieuTriKetHopVoiYHHD_Text { set; get; }
        public int CheDoDinhDuong { get; set; }
        public int CheDoChamSoc { get; set; }
        public string ChanDoanVaoVienTheoYHCT { set; get; }
        public string ChanDoanVaoVienTheoYHHD { set; get; }
        public string PhuongPhapDieuTriTheoYHHD { set; get; }
        public string PhuongPhapDieuTriTheoYHCT { set; get; }
        public string ChanDoanRaVienTheoYHCT { set; get; }
        public string ChanDoanRaVienTheoYHHD { set; get; }
        public int KetQuaDieuTriID { get; set; }
        public string TinhTrangNguoiBenhKhiRavien { set; get; }
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
