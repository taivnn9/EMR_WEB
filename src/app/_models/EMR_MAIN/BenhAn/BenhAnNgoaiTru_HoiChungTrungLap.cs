using EMR.KyDienTu;
using PMS.Access;
using System;

namespace EMR_MAIN.DATABASE.BenhAn
{
    public class BenhAnNgoaiTru_HoiChungTrungLap : IBase
    {
        public int IDMauPhieu { get; set; } = (int)DanhMucPhieu.BADTNTHCTL;
        public string TenMauPhieu { get; set; } = DanhMucPhieu.BADTNTHCTL.Description();
        // Phần chung Hành chính
        public decimal MaQuanLy { get; set; }
        public DateTime? DieuTriNgoaiTruTu { get; set; }
        public DateTime? DieuTriNgoaiTruDen { get; set; }
        public string SoCMND { get; set; }
        public DateTime? BaoHiem { get; set; }
        public string ChanDoan_TuyenTruoc { get; set; }
        public string ChanDoanBanDau { get; set; }
        public string ChanDoanTaiKham1 { get; set; }
        public string ChanDoanTaiKham2 { get; set; }
        public string ChanDoanTaiKham3 { get; set; }
        public string ChanDoanTaiKham4 { get; set; }
        public string BenhPhu { get; set; }
        public int KetQuaDieuTri { get; set; }
        public string BienChung_Text { get; set; }
        public string GDPhongKeHoach { get; set; }
        public string GDPhongKhamBenh { get; set; }
        // hoibenh
        //1. PHẦN TIỀN SỬ- BỆNH SỬ
        [MoTaDuLieu("Tuổi khởi phát")]
        public string TuoiKhoiPhat { get; set; }
        [MoTaDuLieu("Thời gian từ khi khởi phát bệnh")]
        public string ThoiGianKhoiPhatBenh { get; set; }
        [MoTaDuLieu("Triệu chứng đầu tiên")]
        public string TrieuChungDauTien { get; set; }
        [MoTaDuLieu("Tiền sử có bệnh tự miễn khác: 1-> có, 2 -> không")]
        public int TienSuCoBenhTuMien { get; set; }
        [MoTaDuLieu("Tiền sử có bệnh tự miễn khác: Nếu có")]
        public string TienSuCoBenhTuMien_Text { get; set; }
        [MoTaDuLieu("Tiền sử cá nhân bị các bệnh khác: 1-> có, 2-> không")]
        public int TSCNBiCacBenhKhac { get; set; }
        [MoTaDuLieu("Tiền sử cá nhân bị các bệnh khác:: nếu có")]
        public string TSCNBiCacBenhKhac_Text { get; set; }
        [MoTaDuLieu("Tiền sử gia đình có người mắc bệnh tự miễn, 1-> có, 2 -> không")]
        public int TSGDBenhTuMien { get; set; }
        [MoTaDuLieu("Tiền sử gia đình có người mắc bệnh tự miễn, Nếu có (ai bị, bị bệnh gì?): ")]
        public string TSGDBenhTuMien_Text { get; set; }
        [MoTaDuLieu("Bệnh sử")]
        public string BenhSu { get; set; }
        //2.ĐIỀU TRỊ TRƯỚC ĐÂY
        [MoTaDuLieu("Chưa điều trị")]
        public int ChuaDieuTri { get; set; }
        [MoTaDuLieu("Nhóm thuốc làm thay đổi tiến triển bệnh ")]
        public string NhomThuoc { get; set; }
        [MoTaDuLieu("Nhóm thuốc làm thay đổi tiến triển bệnh ")]
        public string DungTrongBaoLau { get; set; }
        [MoTaDuLieu("Tác dụng phụ của thuốc: 1-> có, 2 -> không")]
        public int TacDungPhuCuaThuoc { get; set; }
        [MoTaDuLieu("Tác dụng phụ của thuốc: Có")]
        public string TacDungPhuCuaThuoc_Text { get; set; }
        //3. TOÀN TRẠNG
        [MoTaDuLieu("Sốt: 1->Có, 2-> không")]
        public int Sot { get; set; }
        [MoTaDuLieu("Sốt: Có")]
        public string Sot_Text { get; set; }
        [MoTaDuLieu("Mệt mỏi: 1->Có, 2-> không")]
        public int MetMoi { get; set; }
        [MoTaDuLieu("Mạch")]
        public string Mach { get; set; }
        [MoTaDuLieu("Huyết áp")]
        public string HuyetAp { get; set; }
        [MoTaDuLieu("Hạch to, 1 -> có, 2-> không")]
        public int HachTo { get; set; }
        [MoTaDuLieu("Hạch to, vị trí")]
        public string HachTo_Vitri { get; set; }
        //4.LÂM SÀNG DA-NIÊM MẠC-LÔNG TÓC MÓNG	
        [MoTaDuLieu("Ban cánh bướm")]
        public int BanCanhBuom { get; set; }
        [MoTaDuLieu("Nhạy cảm ánh sáng")]
        public int NhayCamAnhSang { get; set; }
        [MoTaDuLieu("Loét miệng")]
        public int LoetMieng { get; set; }
        [MoTaDuLieu("Hiện tượng Raynaud")]
        public int HienTuongRaynaud { get; set; }
        [MoTaDuLieu("Mặt phù nề")]
        public int MatPhuNe { get; set; }
        [MoTaDuLieu("Ban Heliotrope")]
        public int BanHeliotrope { get; set; }
        [MoTaDuLieu("Gottron sign")]
        public int GottronSign { get; set; }
        [MoTaDuLieu("Gottron papules")]
        public int GottronPapules { get; set; }
        [MoTaDuLieu("Michanic hand")]
        public int MichanicHand { get; set; }
        [MoTaDuLieu("Xơ cứng da đầu ngón")]
        public int XoCungDaDauNgon { get; set; }
        [MoTaDuLieu("Xơ cứng da")]
        public int XoCungDa { get; set; }
        [MoTaDuLieu("Triệu chứng khác")]
        public string TrieuChungKhac { get; set; }
        //5.TRIỆU CHỨNG CƠ
        [MoTaDuLieu("5.1.Đau cơ (hỏi), 1-> có, 2-> không")]
        public int DauCo { get; set; }
        [MoTaDuLieu("5.1.Đau cơ (hỏi), Vị trí")]
        public string DauCo_ViTri { get; set; }
        [MoTaDuLieu("5.2.Bóp cơ, 1-> có, 2-> không")]
        public int BopCo { get; set; }
        [MoTaDuLieu("5.2.Bóp cơ,  Vị trí")]
        public string BopCo_ViTri { get; set; }
        [MoTaDuLieu("5.3. Teo cơ, 1-> có, 2-> không")]
        public int TeoCo { get; set; }
        [MoTaDuLieu("5.3. Teo cơ,  Vị trí")]
        public string TeoCo_ViTri { get; set; }
        // 6.TRIỆU CHỨNG KHỚP
        [MoTaDuLieu("6.TRIỆU CHỨNG KHỚP")]
        public int TrieuChungKhop { get; set; }
        [MoTaDuLieu("6.TRIỆU CHỨNG KHỚP, Đau")]
        public int TrieuChungKhop_Dau { get; set; }
        [MoTaDuLieu("6.TRIỆU CHỨNG KHỚP, sưng")]
        public int TrieuChungKhop_Sung { get; set; }
        [MoTaDuLieu("6.TRIỆU CHỨNG KHỚP, Biến dạng khớp")]
        public int TrieuChungKhop_BienDang { get; set; }
        [MoTaDuLieu("6.TRIỆU CHỨNG KHỚP, ghi chú")]
        public string TrieuChungKhop_Text { get; set; }
        //7.PHỔI                   
        [MoTaDuLieu("7.PHỔI, 1-> có, 2-> không")]
        public int Phoi { get; set; }
        [MoTaDuLieu("7.PHỔI, ghi chú")]
        public string Phoi_Text { get; set; }
        //8.TIM
        [MoTaDuLieu("8.TIM, 1-> có, 2-> không")]
        public int Tim { get; set; }
        [MoTaDuLieu("8.TIM, ghi chú")]
        public string Tim_Text { get; set; }
        //9.ĐƯỜNG TIÊU HÓA     
        [MoTaDuLieu("9.ĐƯỜNG TIÊU HÓA, 1-> có, 2-> không")]
        public int DuongTieuHoa { get; set; }
        [MoTaDuLieu("9.ĐƯỜNG TIÊU HÓA, ghi chú")]
        public string DuongTieuHoa_Text { get; set; }
        //10. Thận- tiết niệu
        [MoTaDuLieu("10.1. Phù")]
        public int Phu { get; set; }
        [MoTaDuLieu("10.2. Tiểu ít")]
        public int TieuIt { get; set; }
        [MoTaDuLieu("10.3. Tiểu hồng")]
        public int TieuHong { get; set; }
        [MoTaDuLieu("10.4. Khác")]
        public string ThanTietNieu_Khac { get; set; }
        //11.CẬN LÂM SÀNG: 
        [MoTaDuLieu("11.1.Công thức máu:")]
        public string CongThucMau { get; set; }
        [MoTaDuLieu("11.2.Máu lắng: 1h")]
        public string MauLang_1h { get; set; }
        [MoTaDuLieu("11.2.Máu lắng: 2h")]
        public string MauLang_2h { get; set; }
        [MoTaDuLieu("11.3.Sinh hóa")]
        public string SinhHoa { get; set; }
        [MoTaDuLieu("11.4.Nước tiểu ")]
        public string NuocTieu { get; set; }
        //11.5.CNHH           
        [MoTaDuLieu("Ngày làm:")]
        public DateTime? CNHH_NgayLam { get; set; }
        [MoTaDuLieu("FVC")]
        public string CNHH_FVC { get; set; }
        [MoTaDuLieu("FEV1")]
        public string CNHH_FEV1 { get; set; }
        [MoTaDuLieu("DLco")]
        public string CNHH_DLco { get; set; }
        [MoTaDuLieu("% dự đoán FVC")]
        public string CNHH_DuDoanFVC { get; set; }
        [MoTaDuLieu("FEV1/FVC")]
        public string CNHH_FEV1_FVC { get; set; }
        [MoTaDuLieu("% dự đoán DLco")]
        public string CNHH_DuDoanDLco { get; set; }
        //11.6.XQ tp (ghi cụ thể)
        [MoTaDuLieu("11.6.XQ tp (ghi cụ thể)")]
        public string XQtp { get; set; }
        [MoTaDuLieu("11.7.HRCT (ghi cụ thể), ngày làm")]
        public DateTime? HRCT_NgayLam { get; set; }
        [MoTaDuLieu("11.7.HRCT (ghi cụ thể)")]
        public string HRCT_Text { get; set; }
        [MoTaDuLieu("11.8.SA ổ bụng")]
        public string SAOBung { get; set; }
        //11.11.Các tự kháng thể
        [MoTaDuLieu("11.11.Các tự kháng thể, ANA")]
        public string Ana { get; set; }
        [MoTaDuLieu("11.11.Các tự kháng thể, Các tự kháng thể khác  ")]
        public string CacTheTuKhangKhac { get; set; }
        //11.12: Khám mắt  
        [MoTaDuLieu("11.12: Khám mắt  Ngày làm")]
        public DateTime? KhamMat_NgayLam { get; set; }
        [MoTaDuLieu("11.12: Khám mắt ghi chú")]
        public string KhamMat_Text { get; set; }
        [MoTaDuLieu("11.13. Điện cơ kim ")]
        public string DienCoKim { get; set; }
        [MoTaDuLieu("11.14. Sinh thiết cơ , ngày làm")]
        public DateTime? SinhThietCo_NgayLam { get; set; }
        [MoTaDuLieu("11.14. Sinh thiết cơ , ghi chú")]
        public string SinhThietCo_Text { get; set; }
        //12.TIÊU CHUẨN CHẨN ĐOÁN 		
        [MoTaDuLieu("12.1. Bệnh mô liên kết lẫn lộn (Mixed connective tissue disease – MCTD), 1-> có, 2 -> không")]
        public int BenhMoLienKet { get; set; }
        [MoTaDuLieu("Tiêu chuẩn bắt buộc: tăng nồng độ anti-U1-RNP, 1-> có, 2 -> không")]
        public int TieuChuanBatBuoc { get; set; }
        [MoTaDuLieu("Phù bàn tay, 1-> có, 2 -> không")]
        public int PhuBanTay { get; set; }
        [MoTaDuLieu("Viêm đa màng, 1-> có, 2 -> không")]
        public int ViemDaMang { get; set; }
        [MoTaDuLieu("Viêm cơ, 1-> có, 2 -> không")]
        public int ViemCo { get; set; }
        [MoTaDuLieu("Hiện tượng Raynaud  , 1-> có, 2 -> không")]
        public int TCLS_HienTuongRaynaud { get; set; }
        [MoTaDuLieu("Xơ cứng đầu chi, 1-> có, 2 -> không")]
        public int XoCungDauChi { get; set; }
        [MoTaDuLieu("12.2. Hội chứng kháng enzyme tổng hợp (Anti-aminoacyl tRNA Synthetase: ARS), 1-> có, 2 -> không")]
        public int HoiChungEnzyme { get; set; }
        //Tiêu chuẩn bắt buộc
        [MoTaDuLieu("Tiêu chuẩn bắt buộc: anti ARS dương tính, 1-> có, 2 -> không")]
        public int AntiARSDuongTinh { get; set; }
        //Tiêu chuẩn chính	
        [MoTaDuLieu("Bệnh lý phổi kẽ: loại trừ nguyên nhân do yếu tố môi trường, thuốc, nghề nghiệp, 1-> có, 2 -> không")]
        public int BenhLyPhoiKe { get; set; }
        [MoTaDuLieu("Viêm đa cơ hoặc viêm bì cơ, thuốc, nghề nghiệp, 1-> có, 2 -> không")]
        public int ViemDaCoViemBiCo { get; set; }
        //Tiêu chuẩn phụ
        [MoTaDuLieu("Viêm khớp, 1-> có, 2 -> không")]
        public int ViemKhop { get; set; }
        [MoTaDuLieu("Hiện tượng Raynaud, 1-> có, 2 -> không")]
        public int TCP_HienTuongRaynaud { get; set; }
        [MoTaDuLieu("Bàn tay người thợ cơ khí, 1-> có, 2 -> không")]
        public int TCP_BanTayThoCoKhi { get; set; }
        //BỆNH TỔ CHỨC LIÊN  KẾT TỰ MIỄN HỖN HỢP KHÔNG CÓ TỰ KHÁNG THỂ ĐẶC HIỆU
        [MoTaDuLieu("12.3. Xơ cứng bì hệ thống, 1-> có, 2 -> không")]
        public int XoCungBiHeThong { get; set; }
        //Tiêu chuẩn ACR và EULAR 2013 (Chẩn đoán khi tổng điểm ≥ 9)
        //Tiêu chuẩn đầy đủ
        [MoTaDuLieu("Thương tổn da vùng ngón tay cả hai bên, lan đến gần khớp đốt bàn), 1-> có, 2 -> không")]
        public int ThuongTonDaVungNgonTay { get; set; }
        //Các tiêu chuẩn khác
        //	Dày da ngón tay (chỉ tính điểm cao nhất)
        [MoTaDuLieu("Dày da ngón tay (chỉ tính điểm cao nhất), 2-> Phù nề đầu ngón,")]
        public int DayDaNgonTay_1 { get; set; }
        [MoTaDuLieu("Dày da ngón tay (chỉ tính điểm cao nhất), 4 -> Xơ cứng da đầu ngón (chưa đến khớp đốt bàn nhưng gần đến vùng khớp ngón gần)")]
        public int DayDaNgonTay_2 { get; set; }

        [MoTaDuLieu("Thương tổn đầu ngón (chỉ tính điểm cao nhất), 2-> Loét đầu ngón")]
        public int ThuongTonDauNgon_1 { get; set; }
        [MoTaDuLieu("Thương tổn đầu ngón (chỉ tính điểm cao nhất), 3 -> Sẹo rỗ đầu ngón")]
        public int ThuongTonDauNgon_2 { get; set; }
        [MoTaDuLieu("Giãn mạch, 2 điềm ")]
        public int GianMach { get; set; }
        [MoTaDuLieu("Bất thường mao mạch nền móng, 2 điểm")]
        public int BatThuongMaoMach { get; set; }
        [MoTaDuLieu("Tăng áp lực động mạch phổi và/hoặc bệnh phổi kẽ (điểm tối đa là 2), Tăng áp lực động mạch phổi")]
        public int TangApLucDongMach_1 { get; set; }
        [MoTaDuLieu("Tăng áp lực động mạch phổi và/hoặc bệnh phổi kẽ (điểm tối đa là 2),Bệnh phổi kẽ")]
        public int TangApLucDongMach_2 { get; set; }
        [MoTaDuLieu("Hiện tượng Raynaud's, 3 điểm")]
        public int HienTuongRaynauds { get; set; }
        [MoTaDuLieu("Các tự kháng thể liên quan đến XCBHT (điểm tối đa là 3), Anti-Centromere")]
        public int Anti_Centromere { get; set; }
        [MoTaDuLieu("Các tự kháng thể liên quan đến XCBHT (điểm tối đa là 3), Anti-Topoisomerase I")]
        public int Anti_TopoisomeraseI { get; set; }
        [MoTaDuLieu("Các tự kháng thể liên quan đến XCBHT (điểm tối đa là 3), Anti-RNApolymerase  III")]
        public int Anti_RNApolymeraseIII { get; set; }
        // 12.4. Viêm khớp dạng thấp
        // Tiêu chuẩn của ACR/EULAR 2010	
        [MoTaDuLieu("Biểu hiện tại khớp")]
        public int BieuHienTaiKhop { get; set; }
        [MoTaDuLieu("Huyết thanh (ít nhất phải làm một xét nghiệm)")]
        public int HuyetThanh { get; set; }
        [MoTaDuLieu("Các yếu tố phản ứng pha cấp (cần ít nhất một xét nghiệm)")]
        public int CacYeuToPhanUng { get; set; }
        [MoTaDuLieu("Thời gian biểu hiện các triệu chứng")]
        public int ThoiGianBieuHien { get; set; }
        //12.5.TANIMOTO 1995
        [MoTaDuLieu("1.TT da: Dát Helitrope, Gottron's sign, ban đỏ thành dải ở mặt duỗi")]
        public int TANIMOTO_1 { get; set; }
        [MoTaDuLieu("2.Yếu cơ gốc chi: cánh tay, đùi, thân mình")]
        public int TANIMOTO_2 { get; set; }
        [MoTaDuLieu("3.Tăng CK hoặc Aldolase")]
        public int TANIMOTO_3 { get; set; }
        [MoTaDuLieu("4.Đau cơ")]
        public int TANIMOTO_4 { get; set; }
        [MoTaDuLieu("5.Điên cơ: TT bệnh lý cơ")]
        public int TANIMOTO_5 { get; set; }
        [MoTaDuLieu("6.Anti Jo-1 (+)")]
        public int TANIMOTO_6 { get; set; }
        [MoTaDuLieu("7.Viêm hoặc đau khớp không phá hủy khớp")]
        public int TANIMOTO_7 { get; set; }
        [MoTaDuLieu("8.Dấu hiệu viêm hệ thống: tăng CRP hoặc máu lắng, sốt > 37 độ (nách)")]
        public int TANIMOTO_8 { get; set; }
        [MoTaDuLieu("9.ST cơ: Viêm cơ")]
        public int TANIMOTO_9 { get; set; }
        [MoTaDuLieu("Viêm bì cơ: 1 + ≥ 4/8 (từ 2-9)")]
        public int ViemBiCo_1 { get; set; }
        [MoTaDuLieu("Viêm đa cơ: ≥ 4/8 (từ 2-9)")]
        public int ViemBiCo_2 { get; set; }
        [MoTaDuLieu("13. Chú ý:")]
        public string ChuY { get; set; }
        [MoTaDuLieu("14. ĐIỀU TRỊ, 14.1. Tại chỗ: ")]
        public string DieuTri_TaiCho { get; set; }
        [MoTaDuLieu("14. ĐIỀU TRỊ, 14.2 Toàn thân:")]
        public string DieuTri_ToanThan { get; set; }
        [MoTaDuLieu("Hẹn khám")]
        public DateTime? HenKham { get; set; }
        [MoTaDuLieu("Bác sĩ khám bệnh")]
        public string BacSiKhamBenh { get; set; }
        // phần tái khám
        //1. PHẦN LƯU TRỮ
        [MoTaDuLieu("Số bệnh án điện tử")]
        public string TK_SoBenhAnDienTu { get; set; }
        [MoTaDuLieu("Số lưu trữ")]
        public string TK_SoLuuTru { get; set; }
        //2. TOÀN TRẠNG
        //3. TOÀN TRẠNG
        [MoTaDuLieu("Sốt: 1->Có, 2-> không")]
        public int TK_Sot { get; set; }
        [MoTaDuLieu("Sốt: Có")]
        public string TK_Sot_Text { get; set; }
        [MoTaDuLieu("Mệt mỏi: 1->Có, 2-> không")]
        public int TK_MetMoi { get; set; }
        [MoTaDuLieu("Mạch")]
        public string TK_Mach { get; set; }
        [MoTaDuLieu("Huyết áp")]
        public string TK_HuyetAp { get; set; }
        [MoTaDuLieu("Hạch to, 1 -> có, 2-> không")]
        public int TK_HachTo { get; set; }
        [MoTaDuLieu("Hạch to, vị trí")]
        public string TK_HachTo_Vitri { get; set; }
        [MoTaDuLieu("* TIỀN SỬ: có thêm bệnh gì so với lần khám trước ")]
        public string TK_TienSu { get; set; }
        //3. LÂM SÀNG DA-NIÊM MẠC-LÔNG TÓC MÓNG
        [MoTaDuLieu("Nhóm tổn thương da do lupus ban đỏ hệ thống")]
        public string TK_NTTDDLupusBanDoHT { get; set; }
        [MoTaDuLieu("Nhóm tổn thương da do bệnh xơ cứng bì")]
        public string TK_NTTDDBenhXoCungBi { get; set; }
        [MoTaDuLieu("Nhóm tổn thương da do bệnh viêm da cơ/viêm đa cơ")]
        public string TK_NTTDDBenhViemDaCo { get; set; }
        [MoTaDuLieu("Tổn thương da, niêm mạc khác")]
        public string TK_TonThuongDaKhac { get; set; }
        //4. TRIỆU CHỨNG CƠ
        [MoTaDuLieu("5.1.Đau cơ (hỏi), 1-> có, 2-> không")]
        public int TK_DauCo { get; set; }
        [MoTaDuLieu("5.1.Đau cơ (hỏi), Vị trí")]
        public string TK_DauCo_ViTri { get; set; }
        [MoTaDuLieu("5.2.Bóp cơ, 1-> có, 2-> không")]
        public int TK_BopCo { get; set; }
        [MoTaDuLieu("5.2.Bóp cơ,  Vị trí")]
        public string TK_BopCo_ViTri { get; set; }
        [MoTaDuLieu("5.3. Teo cơ, 1-> có, 2-> không")]
        public int TK_TeoCo { get; set; }
        [MoTaDuLieu("5.3. Teo cơ,  Vị trí")]
        public string TK_TeoCo_ViTri { get; set; }
        [MoTaDuLieu("4.4. Khác:")]
        public string TK_TrieuChungCo_Khac { get; set; }
        //5.TRIỆU CHỨNG KHỚP
        [MoTaDuLieu("5.1. Đau khớp")]
        public int TK_DauKhop { get; set; }
        [MoTaDuLieu("5.2. Sưng khớp")]
        public int TK_SungKhop { get; set; }
        [MoTaDuLieu("5.3. Biến dạng khớp")]
        public int TK_BienDangKhop { get; set; }
        //6.PHỔI                   
        [MoTaDuLieu("6.PHỔI ")]
        public int TK_Phoi { get; set; }
        [MoTaDuLieu("So với lần trước:")]
        public int TK_Phoi_SoVoiLanTruoc { get; set; }
        [MoTaDuLieu("6.TRIỆU CHỨNG KHỚP, ghi chú")]
        public string TK_Phoi_Text { get; set; }
        //7.TIM                    
        [MoTaDuLieu("7.TIM")]
        public int TK_Tim { get; set; }
        [MoTaDuLieu("7.TIM, So với lần trước")]
        public int TK_Tim_SoVoiLanTruoc { get; set; }
        [MoTaDuLieu("7.TIM, ghi chú")]
        public string TK_Tim_Text { get; set; }
        //8.ĐƯỜNG TIÊU HÓA     
        [MoTaDuLieu("8.ĐƯỜNG TIÊU HÓA")]
        public int TK_DTH { get; set; }
        [MoTaDuLieu("8.ĐƯỜNG TIÊU HÓA, So với lần trước")]
        public int TK_DTH_SoVoiLanTruoc { get; set; }
        [MoTaDuLieu("8.ĐƯỜNG TIÊU HÓA, ghi chú")]
        public string TK_DTH_Text { get; set; }
        //9. CẬN LÂM SÀNG
        [MoTaDuLieu("9.1. Công thức máu: ")]
        public string TK_CongThucMau { get; set; }
        [MoTaDuLieu("9.2. Máu lắng ")]
        public string TK_MauLang { get; set; }
        [MoTaDuLieu("9.3. Sinh hóa:")]
        public string TK_SinhHoa { get; set; }
        [MoTaDuLieu("9.4 Nước tiểu:")]
        public string TK_NuocTieu { get; set; }
        [MoTaDuLieu("9.5 Các tự kháng thể, Làm lại sau ")]
        public string TK_CacTuKhangThe_LamLaiSau { get; set; }
        [MoTaDuLieu("9.5 Các tự kháng thể, Kết quả")]
        public string TK_CacTuKhangThe_KetQua { get; set; }
        [MoTaDuLieu("10.CHÚ Ý")]
        public string TK_ChuY { get; set; }
        [MoTaDuLieu("14. ĐIỀU TRỊ, Tại chỗ: ")]
        public string TK_DieuTri_TaiCho { get; set; }
        [MoTaDuLieu("14. ĐIỀU TRỊ, Toàn thân")]
        public string TK_DieuTri_ToanThan { get; set; }
        [MoTaDuLieu("12. TÁC DỤNG PHỤ CỦA THUỐC")]
        public string TK_TacDungPhuCuaThuoc { get; set; }
        [MoTaDuLieu("Hẹn khám")]
        public DateTime? TK_HenKham { get; set; }
        [MoTaDuLieu("Bác sĩ khám bệnh")]
        public string TK_BacSiKhamBenh { get; set; }
        // Phần tổng kết
        public string QuaTrinhBenhLy { get; set; }
        public string TomTatKetQua { get; set; }
        public string BenhChinh { get; set; }
        public string MaBenhChinh { get; set; }
        public string BenhKemTheo { get; set; }
        public string MaBenhKemTheo { get; set; }
        public string PhuongPhapDieuTri { get; set; }
        public string TinhTrangRaVien { get; set; }
        public string HuongDieuTri { get; set; }
        public string NguoiNhanHoSo { get; set; }
        public string NguoiGiaoHoSo { get; set; }
        public DateTime NgayTongKet { get; set; }
        public string TongKet_BacSyDieuTri { get; set; }
        public string TongKet_MaBacSyDieuTri { get; set; }


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
