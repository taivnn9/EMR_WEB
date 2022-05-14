using EMR.KyDienTu;
using PMS.Access;
using System;
using System.Collections.Generic;
using System.Data;


namespace EMR_MAIN.DATABASE.Other
{
    public class BABNDieuTriCovid19NTP: ThongTinKy
    {
        public BABNDieuTriCovid19NTP()
        {
            TableName = "BABNDieuTriCovid19NTP";
            TablePrimaryKeyName = "ID";
            IDMauPhieu = (int)DanhMucPhieu.BACV19NTP;
            TenMauPhieu = DanhMucPhieu.BACV19NTP.Description();
        }
        [MoTaDuLieu("Mã định danh")]
        public long ID { get; set; }
        [MoTaDuLieu("Mã quản lý: mã duy nhất trong 1 đợt khám chữa bệnh (kcb), không trùng giữa các đợt kcb khác nhau", "", 1)]
        public decimal MaQuanLy { get; set; }
        [MoTaDuLieu("Mã bệnh nhân")]
        public string MaBenhNhan { get; set; }
        [MoTaDuLieu("1. Họ và tên ")]
        public string HoTenBenhNhan { get; set; }
        [MoTaDuLieu("2. Ngày sinh")]
        public DateTime? NgaySinh { get; set; }
        [MoTaDuLieu("3. Giới")]
        public string GioiTinh { get; set; }
        // phần lưu trữ db
        [MoTaDuLieu("Số lưu trữ")]
        public string SoLuuTru { get; set;}
        [MoTaDuLieu("Mã YT ")]
        public string MaYT { get; set; }
        [MoTaDuLieu("4. Nơi đang sinh sống")]
        public string NoiDangSinhSong { get; set; }
        [MoTaDuLieu("5. Người bảo hộ (nếu người bệnh là trẻ em): ")]
        public string NguoiBaoHo { get; set; }
        [MoTaDuLieu("6. Nghề nghiệp: ")]
        public string NgheNghiep { get; set; }
        [MoTaDuLieu("7. Nơi làm việc: ")]
        public string NoiLamViec { get; set; }
        [MoTaDuLieu("8. CMND/CCCD/Hộ chiếu: ")]
        public string CMND { get; set; }
        [MoTaDuLieu("9. Số điện thoại: ")]
        public string SoDienThoai { get; set; }
        public DateTime? NgayTiepNhanF0 { get; set; }
        [MoTaDuLieu("Ngày xuất hiện triệu chứng đầu tiên/sớm nhất: ")]
        public DateTime? NgayXuatHienTrieuChung { get; set; }
        [MoTaDuLieu("Test nhanh, 1-> có, 2-> không ")]
        public int TestNhanh { get; set; }
        [MoTaDuLieu("Test nhanh, Text")]
        public string TestNhanh_Text { get; set; }
        [MoTaDuLieu("Test PCR, 1-> có, 2-> không ")]
        public int TestPCR { get; set; }
        [MoTaDuLieu("Test PCR, Text")]
        public string TestPCR_Text { get; set; }

        //HỎI BỆNH, TIỀN SỬ, BỆNH NỀN VÀ CÁC YẾU TỐ NGUY CƠ
        [MoTaDuLieu("mang mai, 1-> có, 2-> không ")]
        public int MangThai { get; set; }
        [MoTaDuLieu("Nếu CÓ: Đánh giá số tuần mang thai: ")]
        public string SoTuanThai { get; set; }
        [MoTaDuLieu("Hậu sản (trong vòng 06 tuần): , 1-> có, 2-> không ")]
        public int HauSan { get; set; }
        [MoTaDuLieu("Trẻ sơ sinh đã được xét nghiệm COVID-19/SARS-CoV-2: , 1-> có, 2-> không ")]
        public int TreSoSinhDuocXNCovid19 { get; set; }
        [MoTaDuLieu("Nếu CÓ, kết quả xét nghiệm:, 1-> dương tính, 2-> âm tính, 3-> chưa có kết quả ")]
        public int KetQuaXN { get; set; }
        [MoTaDuLieu("Tăng huyết áp, 1-> có, 2-> không")]
        public int TangHuyetAp { get; set; }
        [MoTaDuLieu("Ung thư, 1-> có, 2-> không")]
        public int UngThu { get; set; }
        [MoTaDuLieu("Đái tháo đường, 1-> có, typ 1, 2-> có, typ 2, 3-> có, thai kỳ, 4 -> không")]
        public int DaiThaoDuong { get; set; }
        [MoTaDuLieu("Nếu CÓ, kết quả HBA1c (trong vòng 6 tháng) ")]
        public string KetQuaHBA1c { get; set; }
        [MoTaDuLieu("Đơn vị: 1 -> mmol/mol, 2-> mmol/L, 3-> %")]
        public int DonVi { get; set; }
        [MoTaDuLieu("AIDS / HIV, 1-> có, đang điều trị, 2-> có, không điều trị, 3 -> không")]
        public int AIDS_HIV { get; set; }
        [MoTaDuLieu("Bênh tim mạch(suy tim, động mạch vành hoặc cơ tim), 1-> có, 2 -> không")]
        public int BenhTimMach { get; set; }
        [MoTaDuLieu("Bệnh thấp, 1-> có, 2 -> không")]
        public int BenhThap { get; set; }
        [MoTaDuLieu("Bệnh lý mạch máu não, 1-> có, 2 -> không")]
        public int BenhLyMachMauNao { get; set; }
        [MoTaDuLieu("Bệnh gan, 1-> có, 2 -> không")]
        public int BenhGan { get; set; }
        [MoTaDuLieu("Bệnh thận mạn tính, 1-> có, 2 -> không")]
        public int BenhThanManTinh { get; set; }
        [MoTaDuLieu("Hội chứng down, 1-> có, 2 -> không")]
        public int HoiChungDown { get; set; }
        [MoTaDuLieu("Bệnh hen suyển(chẩn đoán bởi bác sĩ), 1-> có, 2 -> không")]
        public int BenhHenSuyen { get; set; }
        [MoTaDuLieu("Rối loạn sử dụng chất gây nghiện, 1-> có, 2 -> không")]
        public int RoiLoanSuDungChatGayNghien { get; set; }
        [MoTaDuLieu("Béo phì ( xác nhận bởi nhân viên y tế), 1-> có, 2 -> không")]
        public int BeoPhi { get; set; }
        [MoTaDuLieu("Ghép tạng hoặc cáy ghép tế bào gốc tạo máu, 1-> có, 2 -> không")]
        public int GhepTang { get; set; }
        [MoTaDuLieu("Thiếu hụt miễn dịch, 1-> có, 2 -> không")]
        public int ThieuHutMienDich { get; set; }
        [MoTaDuLieu("Các loại bệnh hệ thống, 1-> có, 2 -> không")]
        public int CacLoaiBenhHeThong { get; set; }
        [MoTaDuLieu("Sử dụng corticosteroid hoặc các thuốc ức chế miễn dich  khác, 1-> có, 2 -> không")]
        public int SuDungcorticosteroid { get; set; }
        [MoTaDuLieu("Bệnh hệ thần kinh mạn tính, bao gồm sa sút trí tuệ, 1-> có, 2 -> không")]
        public int BenhHeThanKinh { get; set; }
        [MoTaDuLieu("Bệnh phổi tắc nghẽn mãn tính và các bệnh phổi khác(không phải hen suyển), 1-> có, 2 -> không")]
        public int BengPhoiTacNghen { get; set; }
        //CÁC THUỐC ĐÃ SỬ DỤNG TRƯỚC KHI NHẬP VIỆN
        [MoTaDuLieu("Steroid, 1-> có, 2 -> không")]
        public int Steroid { get; set; }
        [MoTaDuLieu("Steroid đường uống, 1-> có, 2 -> không")]
        public int Steroid_DuongUong { get; set; }
        [MoTaDuLieu("Steroid đường hít, 1-> có, 2 -> không")]
        public int Steroid_DuongHit { get; set; }
        [MoTaDuLieu("Steroid chưa rõ, 1-> có, 2 -> không")]
        public int Steroi_ChuaRo { get; set; }
        [MoTaDuLieu("Các thuốc ức chế miễn dịch khác (Không phải steroid đường uống), 1-> có, 2 -> không")]
        public int CacThuocUcCheKhac { get; set; }
        [MoTaDuLieu("Kháng sinh, 1-> có, 2 -> không")]
        public int KhangSinh { get; set; }
        [MoTaDuLieu("Kháng sinh, ghi rõ loại")]
        public string KhangSinh_GhiRoLoai { get; set; }
        [MoTaDuLieu("Kháng virus, 1-> có, 2 -> không")]
        public int KhangViRus { get; set; }
        [MoTaDuLieu("Kháng virus, ghi rõ loại")]
        public string KhangVirus_GhiRo { get; set; }
        [MoTaDuLieu("Các loại thuốc điều trị COVID-19 khác, 1-> có, 2 -> không")]
        public int CacLoaiThuocKhac { get; set; }
        [MoTaDuLieu("Các loại thuốc khác, ghi rõ loại")]
        public string CacLoaiThuocKhac_GhiRo { get; set; }
        [MoTaDuLieu("TIÊM VẮC XIN PHÒNG COVID-19: 1 -> có, 2-> không")]
        public int TiemVacXinPhongCovid19 { get; set; }
        [MoTaDuLieu("Thời gian tiêm: 1 -> không rõ")]
        public int ThoiGianTiemMui_1 { get; set; }
        [MoTaDuLieu("Loại vắc-xin mũi 1: 1 AstraZeneca  2 Moderna  3 Pfizer/BioNTech  4 Vero Cell (Sinopharm)  5 AstraZeneca (Catalant)  6 Vaccine AstraZeneca (SKBio)  7 Vaccine Gam - COVID - Vac (SPUTNIK V)  8 Novavax  9 Janssens (Johnson & Johnson)  10 Sinopharm  11 Sinovac  12 Covaxin  13 Chưa rõ  14 khác")]
        public int LoaiVacxinMui_1 { get; set; }
        [MoTaDuLieu("Loại vắc-xin mũi 1, khác cụ thể")]
        public string LoaiVacxinMui_1_CuThe { get; set; }
        [MoTaDuLieu("Thời gian tiêm: 2 -> không rõ")]
        public int ThoiGianTiemMui_2 { get; set; }
        [MoTaDuLieu("Loại vắc-xin mũi 2: 1 AstraZeneca  2 Moderna  3 Pfizer/BioNTech  4 Vero Cell (Sinopharm)  5 AstraZeneca (Catalant)  6 Vaccine AstraZeneca (SKBio)  7 Vaccine Gam - COVID - Vac (SPUTNIK V)  8 Novavax  9 Janssens (Johnson & Johnson)  10 Sinopharm  11 Sinovac  12 Covaxin  13 Chưa rõ  14 khác")]
        public int LoaiVacxinMui_2 { get; set; }
        [MoTaDuLieu("Loại vắc-xin mũi 2, khác cụ thể")]
        public string LoaiVacxinMui_2_CuThe { get; set; }
        [MoTaDuLieu("Thời gian tiêm: 3 -> không rõ")]
        public int ThoiGianTiemMui_3 { get; set; }
        [MoTaDuLieu("Loại vắc-xin mũi 3: 1 AstraZeneca  2 Moderna  3 Pfizer/BioNTech  4 Vero Cell (Sinopharm)  5 AstraZeneca (Catalant)  6 Vaccine AstraZeneca (SKBio)  7 Vaccine Gam - COVID - Vac (SPUTNIK V)  8 Novavax  9 Janssens (Johnson & Johnson)  10 Sinopharm  11 Sinovac  12 Covaxin  13 Chưa rõ  14 khác")]
        public int LoaiVacxinMui_3 { get; set; }
        [MoTaDuLieu("Loại vắc-xin mũi 3, khác cụ thể")]
        public string LoaiVacxinMui_3_CuThe { get; set; }
        //II. TÌNH TRẠNG LÚC NHẬP VIỆN
        [MoTaDuLieu("Nhiệt độ")]
        public string NhietDo { get; set; }
        [MoTaDuLieu("Nhịp tim")]
        public string NhipTim { get; set; }
        [MoTaDuLieu("Nhịp thở")]
        public string NhipTho { get; set; }
        [MoTaDuLieu("Huyết áp tâm thu")]
        public string HuyetApTamThu { get; set; }
        [MoTaDuLieu("Huyết áp tâm trương")]
        public string HuyetApTamTruong { get; set; }
        [MoTaDuLieu("Độ bão hòa Oxy máu")]
        public string DoBaoHoaOxy { get; set; }
        [MoTaDuLieu("Chiều cao")]
        public string ChieuCao { get; set; }
        [MoTaDuLieu("Cân nặng")]
        public string CanNang { get; set; }
        [MoTaDuLieu("Sốt, 1-> có, 2-> không")]
        public int Sot { get; set; }
        [MoTaDuLieu("Kiệt sức/ mệt mỏi, 1-> có, 2-> không")]
        public int KietSucMetMoi { get; set; }
        [MoTaDuLieu("Ho, 1-> có, 2-> không")]
        public int Ho { get; set; }

        [MoTaDuLieu("Chán ăn, 1-> có, 2-> không")]
        public int ChanAn { get; set; }
        [MoTaDuLieu("Chán ăn, 1-> có, 2-> không")]
        public int DauHong { get; set; }
        [MoTaDuLieu("Thay đổi tri giác (lơ mơ), 1-> có, 2-> không")]
        public int ThayDoiTriGiac { get; set; }
        [MoTaDuLieu("Sổ mũi, 1-> có, 2-> không")]
        public int SoMui { get; set; }
        [MoTaDuLieu("Đau cơ, 1-> có, 2-> không")]
        public int DauCo { get; set; }
        [MoTaDuLieu("Khó thở, 1-> có, 2-> không")]
        public int KhoTho { get; set; }
        [MoTaDuLieu("Đau khớp, 1-> có, 2-> không")]
        public int DauKhop { get; set; }
        [MoTaDuLieu("Đau ngực, 1-> có, 2-> không")]
        public int DauNguc { get; set; }
        [MoTaDuLieu("Mất khả năng đi lại, 1-> có, 2-> không")]
        public int MatKhaNangDiLai { get; set; }
        [MoTaDuLieu("Viêm kết mạc (Mắt đỏ), 1-> có, 2-> không")]
        public int ViemKetMac { get; set; }
        [MoTaDuLieu("Đau bụng, 1-> có, 2-> không")]
        public int DauBung { get; set; }
        [MoTaDuLieu("Nổi hạch ngoại vi, 1-> có, 2-> không")]
        public int NoiHachNgoaiVi { get; set; }
        [MoTaDuLieu("Tiêu chảy, 1-> có, 2-> không")]
        public int TieuChay { get; set; }
        [MoTaDuLieu("Đau đầu, 1-> có, 2-> không")]
        public int DauDau { get; set; }
        [MoTaDuLieu("Nôn/buồn nôn, 1-> có, 2-> không")]
        public int BuonNon { get; set; }

        [MoTaDuLieu("Mất khứu giác, 1-> có, 2-> không")]
        public int MatKhuuGiac { get; set; }
        [MoTaDuLieu("Mất khứu giác, 1-> có, 2-> không")]
        public int PhatBan { get; set; }
        [MoTaDuLieu("Mất vị giác, 1-> có, 2-> không")]
        public int MatViGiac { get; set; }
        [MoTaDuLieu("Chảy máu (Xuất huyết):  , 1-> có, 2-> không")]
        public int ChayMau { get; set; }
        [MoTaDuLieu("Chảy máu (Xuất huyết): Nếu CÓ, cụ thể vị trí: ")]
        public string ChayMau_ViTriCuThe { get; set; }
        [MoTaDuLieu("Co giật:  , 1-> có, 2-> không")]
        public int CoGiat { get; set; }
        [MoTaDuLieu("Triệu chứng khác:  , 1-> có, 2-> không")]
        public int TrieuChungKhac { get; set; }
        [MoTaDuLieu("Triệu chứng khác:  , Nếu có, cụ thể")]
        public string TrieuChungKhac_NeuCoCuThe { get; set; }
        [MoTaDuLieu("Chẩn đoán lúc nhập viện")]
        public string ChanDoanLucNhapVien { get; set; }
        [MoTaDuLieu("Đánh giá tình trạng bệnh lý COVID-19 lúc nhập viện, 1-> không triệu chứng, 2 -> mức độ nhẹ, 3-> mức độ trung bình, 4 -> Mức độ nặng, 5 -> Mức độ nguy kịch")]
        public int DanhGiaTinhTrangBenhLy { get; set; }

        //Tổng kết III. QUÁ TRÌNH ĐIỀU TRỊ
        [MoTaDuLieu("Liệu pháp Oxy :  , 1-> có, 2-> không")]
        public int LieuPhapOxy { get; set; }
        [MoTaDuLieu("Liệu pháp Oxy : Nếu có, tổng thời gian")]
        public string LieuPhapOxy_TTG { get; set; }
        [MoTaDuLieu("Lưu lượng oxy tối đa: : 1 <2 L/phút  2 <2.5 L/phút  3 6-10 L/phút  4 11-15 L/phút  5 >15 L/phút	")]
        public int LuuLuongOxyToiDa { get; set; }
        [MoTaDuLieu("Thở máy không xâm nhập  :  , 1-> có, 2-> không")]
        public int ThoMayKhongXamNhap { get; set; }
        [MoTaDuLieu("Thở máy không xâm nhập : Nếu có, tổng thời gian")]
        public string ThoMayKhongXamNhap_TTG { get; set; }
        [MoTaDuLieu("Thở máy xâm nhập  :  , 1-> có, 2-> không")]
        public int ThoMayXamNhap { get; set; }
        [MoTaDuLieu("Thở máy xâm nhập : Nếu có, tổng thời gian")]
        public string ThoMayXamNhap_TTG { get; set; }
        [MoTaDuLieu("Liệu pháp oxy dòng cao qua mũi  : 1-> có, 2-> không")]
        public int LPOXDCQM { get; set; }
        [MoTaDuLieu("Liệu pháp oxy dòng cao qua mũi: Nếu có, tổng thời gian")]
        public string LPOXDCQM_TTG { get; set; }
        [MoTaDuLieu("Thông khí nằm sấp : 1-> có, 2-> không")]
        public int ThongKhiNamSap { get; set; }
        [MoTaDuLieu("Khai khí đạo: 1-> có, 2-> không")]
        public int KhaiKhiDao { get; set; }
        [MoTaDuLieu("ECMO: 1-> có, 2-> không")]
        public int ECMO { get; set; }
        [MoTaDuLieu("ECMO: Nếu có, tổng thời gian")]
        public string ECMO_TTG { get; set; }
        [MoTaDuLieu("Lọc máu, 1-> có, 2-> không ")]
        public int LocMau { get; set; }
        [MoTaDuLieu("Lọc máu,Nếu có, tổng thời gian")]
        public string LocMau_TTG { get; set; }

        [MoTaDuLieu("Thuốc vận mạch, 1-> có, 2-> không ")]
        public int ThuocVanMach { get; set; }
        [MoTaDuLieu("Nhập ICU, 1-> có, 2-> không ")]
        public int NhapICU { get; set; }
        [MoTaDuLieu("Nhập ICU: Nếu có, tổng thời gian")]
        public string NhapICU_TTG { get; set; }
        // XÉT NGHIỆM CHẨN ĐOÁN
        [MoTaDuLieu("XÉT NGHIỆM RT- PCR SARS-CoV-2, 1-> dương, 2 -> âm, 3 -> không làm")]
        public int XetNghiemRT_PCR { get; set; }
        //+ CẤY VI KHUẨN
        [MoTaDuLieu("Vi khuẩn:, 1-> dương, 2 -> âm, 3 -> không làm")]
        public int ViKhuan { get; set; }
        [MoTaDuLieu("Vi khuẩn:  Nếu dương, hãy định danh")]
        public string ViKhuan_DinhDanh { get; set; }
        [MoTaDuLieu("Các mầm bệnh khác được phát hiện:, 1-> có, 2 -> không")]
        public int CacMamBenhKhac { get; set; }
        [MoTaDuLieu("Các mầm bệnh khác được phát hiện:  Nếu dương, hãy định danh")]
        public string CacMamBenhKhac_DinhDanh { get; set; }
        //  + HÌNH ẢNH HỌC
        [MoTaDuLieu("Bệnh viêm phổi được chẩn đoán trên lâm sàng :, 1-> có, 2 -> không")]
        public int BVPDCDTLS { get; set; }
        [MoTaDuLieu("Chụp X-Quang phổi :, 1-> có, 2 -> không")]
        public int ChupXQuangPhoi { get; set; }
        [MoTaDuLieu("Chụp X-Quang phổi Có thâm nhiễm :, 1-> có, 2 -> không")]
        public int ChupXQuangPhoi_CoThamNhiem { get; set; }
        [MoTaDuLieu("Chụp CT ngực :, 1-> có, 2 -> không")]
        public int ChupCTNguc { get; set; }
        [MoTaDuLieu("Chụp CT ngực Có thâm nhiễm :, 1-> có, 2 -> không")]
        public int ChupCTNguc_CoThamNhiem { get; set; }
        //CÁC LOẠI THUỐC SỬ DỤNG TRONG QUÁ TRÌNH ĐIỀU TRỊ:
        [MoTaDuLieu("Molnupiravir :, 1-> có, 2 -> không")]
        public int Molnupiravir { get; set; }
        [MoTaDuLieu("Molnupiravir :, Ngày bắt đầu")]
        public DateTime? Molnupiravir_NgayBatDau { get; set; }
        [MoTaDuLieu("Molnupiravir :, Thời gian :  ngày ")]
        public string Molnupiravir_ThoiGian { get; set; }
        [MoTaDuLieu("Ribavirin :, 1-> có, 2 -> không")]
        public int Ribavirin { get; set; }
        [MoTaDuLieu("Ribavirin :, Ngày bắt đầu")]
        public DateTime? Ribavirin_NgayBatDau { get; set; }
        [MoTaDuLieu("Ribavirin :, Thời gian :  ngày ")]
        public string Ribavirin_ThoiGian { get; set; }
        [MoTaDuLieu("Lopinavir :, 1-> có, 2 -> không")]
        public int Lopinavir { get; set; }
        [MoTaDuLieu("Lopinavir :, Ngày bắt đầu")]
        public DateTime? Lopinavir_NgayBatDau { get; set; }
        [MoTaDuLieu("Lopinavir :, Thời gian :  ngày ")]
        public string Lopinavir_ThoiGian { get; set; }
        [MoTaDuLieu("Remdesivir :, 1-> có, 2 -> không")]
        public int Remdesivir { get; set; }
        [MoTaDuLieu("Remdesivir :, Ngày bắt đầu")]
        public DateTime? Remdesivir_NgayBatDau { get; set; }
        [MoTaDuLieu("Remdesivir :, Thời gian :  ngày ")]
        public string Remdesivir_ThoiGian { get; set; }
        [MoTaDuLieu("Interferon_alpha :, 1-> có, 2 -> không")]
        public int Interferon_alpha { get; set; }
        [MoTaDuLieu("Interferon_alpha :, Ngày bắt đầu")]
        public DateTime? Interferon_alpha_NgayBatDau { get; set; }
        [MoTaDuLieu("Interferon_alpha :, Thời gian :  ngày ")]
        public string Interferon_alpha_ThoiGian { get; set; }
        [MoTaDuLieu("Interferon_beta :, 1-> có, 2 -> không")]
        public int Interferon_beta { get; set; }
        [MoTaDuLieu("Interferon_beta :, Ngày bắt đầu")]
        public DateTime? Interferon_beta_NgayBatDau { get; set; }
        [MoTaDuLieu("Interferon_beta :, Thời gian :  ngày ")]
        public string Interferon_beta_ThoiGian { get; set; }
        [MoTaDuLieu("Kháng Interleukin-6 (IL-6)")]
        public int Khang_Interleukin { get; set; }
        [MoTaDuLieu("Tocilizumab")]
        public int Tocilizumab { get; set; }
        [MoTaDuLieu("Sarilumab")]
        public int Sarilumab { get; set; }
        [MoTaDuLieu("Kháng Interleukin-6, khác")]
        public int Khang_Interleukin_Khac { get; set; }
        [MoTaDuLieu("Kháng Interleukin-6 (IL-6), ngày bắt đầu")]
        public DateTime? Khang_Interleukin_NgayBatDau { get; set; }
        [MoTaDuLieu("Kháng Interleukin-6 (IL-6), Thời gian")]
        public string Khang_Interleukin_ThoiGian { get; set; }
        [MoTaDuLieu("Truyền huyết tương :, 1-> có, 2 -> không")]
        public int TruyenHuyetTuong { get; set; }
        [MoTaDuLieu("Truyền huyết tương :, Ngày bắt đầu")]
        public DateTime? TruyenHuyetTuong_NgayBatDau { get; set; }
        [MoTaDuLieu("Truyền huyết tương :, Thời gian :  ngày ")]
        public string TruyenHuyetTuong_ThoiGian { get; set; }
        [MoTaDuLieu("Thuốc kháng khác :, 1-> có, 2 -> không")]
        public int ThuocKhang_Khac { get; set; }
        [MoTaDuLieu("Thuốc kháng khác : ghi rõ")]
        public string ThuocKhang_Khac_Text { get; set; }
        [MoTaDuLieu("Thuốc kháng khác : Ngày bắt đầu")]
        public DateTime? ThuocKhang_Khac_NgayBatDau { get; set; }

        [MoTaDuLieu("Thuốc kháng khác : thời gian")]
        public string ThuocKhang_Khac_ThoiGian { get; set; }
        //KHÁNG SINH
        [MoTaDuLieu("Beta-lactam :, 1-> có, 2 -> không")]
        public int Beta_lactam { get; set; }
        [MoTaDuLieu("Beta-lactam :, Ngày bắt đầu")]
        public DateTime? Beta_lactam_NgayBatDau { get; set; }
        [MoTaDuLieu("Beta-lactam :, Thời gian :  ngày ")]
        public string Beta_lactam_ThoiGian { get; set; }
        [MoTaDuLieu("Aminoglycosid :, 1-> có, 2 -> không")]
        public int Aminoglycosid { get; set; }
        [MoTaDuLieu("Aminoglycosid :, Ngày bắt đầu")]
        public DateTime? Aminoglycosid_NgayBatDau { get; set; }
        [MoTaDuLieu("Aminoglycosid :, Thời gian :  ngày ")]
        public string Aminoglycosid_ThoiGian { get; set; }
        [MoTaDuLieu("Macrolid :, 1-> có, 2 -> không")]
        public int Macrolid { get; set; }
        [MoTaDuLieu("Macrolid :, Ngày bắt đầu")]
        public DateTime? Macrolid_NgayBatDau { get; set; }
        [MoTaDuLieu("Macrolid :, Thời gian :  ngày ")]
        public string Macrolid_ThoiGian { get; set; }
        [MoTaDuLieu("Lincosamid :, 1-> có, 2 -> không")]
        public int Lincosamid { get; set; }
        [MoTaDuLieu("Lincosamid :, Ngày bắt đầu")]
        public DateTime? Lincosamid_NgayBatDau { get; set; }
        [MoTaDuLieu("Lincosamid :, Thời gian :  ngày ")]
        public string Lincosamid_ThoiGian { get; set; }
        [MoTaDuLieu("Phenicol :, 1-> có, 2 -> không")]
        public int Phenicol { get; set; }
        [MoTaDuLieu("Phenicol :, Ngày bắt đầu")]
        public DateTime? Phenicol_NgayBatDau { get; set; }
        [MoTaDuLieu("Phenicol :, Thời gian :  ngày ")]
        public string Phenicol_ThoiGian { get; set; }
        [MoTaDuLieu("Tetracyclin :, 1-> có, 2 -> không")]
        public int Tetracyclin { get; set; }
        [MoTaDuLieu("Tetracyclin :, Ngày bắt đầu")]
        public DateTime? Tetracyclin_NgayBatDau { get; set; }
        [MoTaDuLieu("Tetracyclin :, Thời gian :  ngày ")]
        public string Tetracyclin_ThoiGian { get; set; }
        [MoTaDuLieu("Peptid :, 1-> có, 2 -> không")]
        public int Peptid { get; set; }
        [MoTaDuLieu("Peptid :, Ngày bắt đầu")]
        public DateTime? Peptid_NgayBatDau { get; set; }
        [MoTaDuLieu("Peptid :, Thời gian :  ngày ")]
        public string Peptid_ThoiGian { get; set; }
        [MoTaDuLieu("Quinolon :, 1-> có, 2 -> không")]
        public int Quinolon { get; set; }
        [MoTaDuLieu("Quinolon :, Ngày bắt đầu")]
        public DateTime? Quinolon_NgayBatDau { get; set; }
        [MoTaDuLieu("Quinolon :, Thời gian :  ngày ")]
        public string Quinolon_ThoiGian { get; set; }
        [MoTaDuLieu("Kháng sinh khác :, 1-> có, 2 -> không")]
        public int KhangSinhKhac { get; set; }
        [MoTaDuLieu("Kháng sinh khác :, ghi rõ")]
        public string KhangSinhKhac_Text { get; set; }
        [MoTaDuLieu("Kháng sinh khác :, Ngày bắt đầu")]
        public DateTime? KhangSinhKhac_NgayBatDau { get; set; }
        [MoTaDuLieu("Kháng sinh khác :, Thời gian :  ngày ")]
        public string KhangSinhKhac_ThoiGian { get; set; }
        [MoTaDuLieu("CORTICOSTEROID :, 1-> có, 2 -> không")]
        public int CORTICOSTEROID { get; set; }
        [MoTaDuLieu("Prednisolone :, 1-> có, 2 -> không")]
        public int Prednisolone { get; set; }
        [MoTaDuLieu("Hydrocortisone   :, 1-> có, 2 -> không")]
        public int Hydrocortisone { get; set; }

        [MoTaDuLieu("Methylprednisolone     :, 1-> có, 2 -> không")]
        public int Methylprednisolone { get; set; }
        [MoTaDuLieu("CORTICOSTEROID_Khac:, 1-> có, 2 -> không")]
        public int CORTICOSTEROID_Khac { get; set; }
        [MoTaDuLieu("CORTICOSTEROID_Khac:, ghi rõ")]
        public string CORTICOSTEROID_Khac_Text { get; set; }
        [MoTaDuLieu("Đường dùng: 1-> uống, 2 -> tiêm tĩnh mạch")]
        public int CORTICOSTEROID_DuongDung { get; set; }
        [MoTaDuLieu("THUỐC KHÁNG ĐÔNG:, 1-> có, 2 -> không")]
        public int ThuocKhangDong { get; set; }
        [MoTaDuLieu("THUỐC KHÁNG ĐÔNG:, Loại")]
        public string ThuocKhangDong_Loai { get; set; }
        [MoTaDuLieu("Đường dùng: 1-> uống, 2 -> tiêm dưới da, 3 -> Tiêm tĩnh mạch ")]
        public int ThuocKhangDong_DuongDung { get; set; }
        [MoTaDuLieu("Chỉ định, Điều trị(Điều trị huyết khối) ")]
        public int ChiDinh_DieuTri { get; set; }
        [MoTaDuLieu("Chỉ định, Dự phòng tăng cường Covid-19 ")]
        public int ChiDinh_DuPhongTangCuong { get; set; }
        [MoTaDuLieu("Chỉ định, Dự phòng bệnh nền")]
        public int ChiDinh_DuPhongBenhNen { get; set; }
        [MoTaDuLieu("THUỐC KHÁNG NẤM : 1-> có, 2 -> không")]
        public int ThuocKhangNam { get; set; }
        [MoTaDuLieu("THUỐC KHÁNG NẤM : Loại")]
        public string ThuocKhangNam_Loai { get; set; }
        [MoTaDuLieu("THUỐC KHÁNG NẤM : thời gian")]
        public string ThuocKhangNam_ThoiGian { get; set; }
        //BIẾN CHỨNG TRONG QUÁ TRÌNH ĐIỀU TRỊ:
        [MoTaDuLieu("Viêm phổi do vi rút : 1 -> có, 2 -> không")]
        public int ViemPhoiRoVirus { get; set; }
        [MoTaDuLieu("Viêm màng não / viêm não : 1 -> có, 2 -> không")]
        public int ViemMangNao { get; set; }
        [MoTaDuLieu("Viêm phổi do vi khuẩn: 1 -> có, 2 -> không")]
        public int ViemPhoiDoViKhuan { get; set; }
        [MoTaDuLieu("Nhiễm trùng huyết: 1 -> có, 2 -> không")]
        public int NhiemTrungHuyet { get; set; }
        [MoTaDuLieu("Hội chứng suy giảm hô hấp cấp tính: 1 -> có, 2 -> không")]
        public int HCSGHHCT { get; set; }
        [MoTaDuLieu("Rối loạn đông máu / DIC: 1 -> có, 2 -> không")]
        public int RLDMDIC { get; set; }
        [MoTaDuLieu("Tràn khí màng phổi: 1 -> có, 2 -> không")]
        public int TranKhiMangPhoi { get; set; }
        [MoTaDuLieu("Thuyên tắc phổi: 1 -> có, 2 -> không")]
        public int ThuyenTacPhoi { get; set; }
        [MoTaDuLieu("Tràn dịch màng phổi: 1 -> có, 2 -> không")]
        public int TranDichMangPhoi { get; set; }
        [MoTaDuLieu("Huyết khối tĩnh mạch sâu: 1 -> có, 2 -> không")]
        public int HuyetKhoiTinhMachSau { get; set; }
        [MoTaDuLieu("Nhồi máu cơ tim: 1 -> có, 2 -> không")]
        public int NhoiMauCoTim { get; set; }
        [MoTaDuLieu("Huyết khối tắc mạch khác : 1 -> có, 2 -> không")]
        public int HuyetKhoiTacMachKhac { get; set; }
        [MoTaDuLieu("Rối loạn nhịp tim: 1 -> có, 2 -> không")]
        public int RoiLoanNhipTim { get; set; }
        [MoTaDuLieu("Thiếu máu: 1 -> có, 2 -> không")]
        public int ThieuMau { get; set; }
        [MoTaDuLieu("Viêm cơ tim / viêm màng ngoài tim: 1 -> có, 2 -> không")]
        public int ViemCoTim { get; set; }
        [MoTaDuLieu("Tiêu cơ vân / Viêm cơ: 1 -> có, 2 -> không")]
        public int TieuCoVan { get; set; }
        [MoTaDuLieu("Viêm nội tâm mạc: 1 -> có, 2 -> không")]
        public int ViemNoiTamMac { get; set; }
        [MoTaDuLieu("Tổn thương thận cấp tính / Suy thận cấp tính: 1 -> có, 2 -> không")]
        public int TonThuongThanCapTinh { get; set; }
        [MoTaDuLieu("Bệnh cơ tim: 1 -> có, 2 -> không")]
        public int BenhCoTim { get; set; }
        [MoTaDuLieu("Xuất huyết đường tiêu hóa: 1 -> có, 2 -> không")]
        public int XuatHuyetDuongTieuHoa { get; set; }
        [MoTaDuLieu("Suy tim sung huyết: 1 -> có, 2 -> không")]
        public int SuyTimSungHuyet { get; set; }
        [MoTaDuLieu("Viêm tụy: 1 -> có, 2 -> không")]
        public int ViemTuy { get; set; }
        [MoTaDuLieu("Viêm tụy: 1 -> có, 2 -> không")]
        public int BienChung_CoGiat { get; set; }
        [MoTaDuLieu("Viêm tụy: 1 -> có, 2 -> không")]
        public int RoiLoanChucNangGan { get; set; }
        [MoTaDuLieu("Tai biến mạch máu não / đột quỵ: 1 -> có, 2 -> không")]
        public int TaiBienMachMauNao { get; set; }
        [MoTaDuLieu("Tăng đường huyết: 1 -> có, 2 -> không")]
        public int TangDuongHuyet { get; set; }
        [MoTaDuLieu("Hạ đường huyết: 1 -> có, 2 -> không")]
        public int HaDuongHuyet { get; set; }
        [MoTaDuLieu("Biến chứng khác: 1 -> có, 2 -> không")]
        public int BienChung_Khac { get; set; }
        [MoTaDuLieu("Biến chứng khác: text")]
        public string BienChung_Khac_Text { get; set; }
        // KẾT CỤC
        [MoTaDuLieu("Xuất viện, 1 -> có, 2 -> không")]
        public int XuatVien { get; set; }
        [MoTaDuLieu("Chuyển đi cơ sở khác , 1 -> có, 2 -> không")]
        public int ChuyenDiCoSoKhac { get; set; }
        [MoTaDuLieu("Tên cơ sở chuyển đi")]
        public string TenCoSoChuyenDi { get; set; }
        [MoTaDuLieu("Tử vong , 1 -> có, 2 -> không")]
        public int TuVong { get; set; }
        [MoTaDuLieu("Xuất viện với tình trạng nguy kịch")]
        public int XVVTTNK { get; set; }
        [MoTaDuLieu("Nếu tử vong, nguyên nhân tử vong nghĩ đến nhiều nhất")]
        public string NguyenNhanTuVong { get; set; }
        [MoTaDuLieu("Ngày tổng kết")]
        public DateTime? NgayTongKet { get; set; }
        [MoTaDuLieu("Bác sỹ ")]
        public string BacSy { get; set; }


        // bắt buộc
        [MoTaDuLieu("Đã ký", null, 0, 0)]
        public bool DaKy { get; set; }
        [MoTaDuLieu("Ngày tạo", null, 0, 0)]
        public DateTime NgayTao { get; set; }
        [MoTaDuLieu("Người tạo", null, 0, 0)]
        public string NguoiTao { get; set; }
        [MoTaDuLieu("Ngày sửa", null, 0, 0)]
        public DateTime NgaySua { get; set; }
        [MoTaDuLieu("Người sửa", null, 0, 0)]
        public string NguoiSua { get; set; }
        [MoTaDuLieu("Chọn", null, 0, 0)]
        public bool Chon { get; set; }
    }
    public class BABNDieuTriCovid19NTPFunc
    {
        public const string TableName = "BABNDieuTriCovid19NTP";
        public const string TablePrimaryKeyName = "ID";
        public static List<BABNDieuTriCovid19NTP> GetListData(MDB.MDBConnection _OracleConnection, decimal maquanly)
        {
            List<BABNDieuTriCovid19NTP> list = new List<BABNDieuTriCovid19NTP>();
            try
            {
                string sql = @"SELECT * FROM BABNDieuTriCovid19NTP where MaQuanLy = :MaQuanLy";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, _OracleConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", maquanly));
                MDB.MDBDataReader DataReader = Command.ExecuteReader();
                while (DataReader.Read())
                {
                    BABNDieuTriCovid19NTP data = new BABNDieuTriCovid19NTP();
                    data.ID = Convert.ToInt64(DataReader.GetLong("ID").ToString());
                    data.MaQuanLy = maquanly;
                    data.MaBenhNhan = DataReader["MaBenhNhan"].ToString();
                    data.HoTenBenhNhan = XemBenhAn._HanhChinhBenhNhan.TenBenhNhan;
                    data.NgaySinh = XemBenhAn._HanhChinhBenhNhan.NgaySinh;
                    data.GioiTinh = XemBenhAn._HanhChinhBenhNhan.GioiTinh.Description();

                    data.SoLuuTru = DataReader["SoLuuTru"].ToString();
                    data.MaYT = DataReader["MaYT"].ToString();
                    data.NoiDangSinhSong = DataReader["NoiDangSinhSong"].ToString();
                    data.NguoiBaoHo = DataReader["NguoiBaoHo"].ToString();
                    data.NgheNghiep = DataReader["NgheNghiep"].ToString();
                    data.NoiLamViec = DataReader["NoiLamViec"].ToString();
                    data.CMND = DataReader["CMND"].ToString();
                    data.SoDienThoai = DataReader["SoDienThoai"].ToString();
                    data.NgayTiepNhanF0 = DataReader["NgayTiepNhanF0"] != DBNull.Value ? (DateTime?)Convert.ToDateTime(DataReader["NgayTiepNhanF0"].ToString()) : null;
                    data.NgayXuatHienTrieuChung = DataReader["NgayXuatHienTrieuChung"] != DBNull.Value ? (DateTime?)Convert.ToDateTime(DataReader["NgayXuatHienTrieuChung"].ToString()) : null;
                    data.TestNhanh = DataReader.GetInt("TestNhanh");
                    data.TestNhanh_Text = DataReader["TestNhanh_Text"].ToString();
                    data.TestPCR = DataReader.GetInt("TestPCR");
                    data.TestPCR_Text = DataReader["TestPCR_Text"].ToString();
                    data.MangThai = DataReader.GetInt("MangThai");
                    data.SoTuanThai = DataReader["SoTuanThai"].ToString();
                    data.HauSan = DataReader.GetInt("HauSan");
                    data.TreSoSinhDuocXNCovid19 = DataReader.GetInt("TreSoSinhDuocXNCovid19");
                    data.KetQuaXN = DataReader.GetInt("KetQuaXN");
                    data.TangHuyetAp = DataReader.GetInt("TangHuyetAp");
                    data.UngThu = DataReader.GetInt("UngThu");
                    data.DaiThaoDuong = DataReader.GetInt("DaiThaoDuong");
                    data.KetQuaHBA1c = DataReader["KetQuaHBA1c"].ToString();
                    data.DonVi = DataReader.GetInt("DonVi");
                    data.AIDS_HIV = DataReader.GetInt("AIDS_HIV");
                    data.BenhTimMach = DataReader.GetInt("BenhTimMach");
                    data.BenhThap = DataReader.GetInt("BenhThap");
                    data.BenhLyMachMauNao = DataReader.GetInt("BenhLyMachMauNao");
                    data.BenhGan = DataReader.GetInt("BenhGan");
                    data.BenhThanManTinh = DataReader.GetInt("BenhThanManTinh");
                    data.HoiChungDown = DataReader.GetInt("HoiChungDown");
                    data.BenhHenSuyen = DataReader.GetInt("BenhHenSuyen");
                    data.RoiLoanSuDungChatGayNghien = DataReader.GetInt("RoiLoanSuDungChatGayNghien");
                    data.BeoPhi = DataReader.GetInt("BeoPhi");
                    data.GhepTang = DataReader.GetInt("GhepTang");
                    data.ThieuHutMienDich = DataReader.GetInt("ThieuHutMienDich");
                    data.CacLoaiBenhHeThong = DataReader.GetInt("CacLoaiBenhHeThong");
                    data.SuDungcorticosteroid = DataReader.GetInt("SuDungcorticosteroid");
                    data.BenhHeThanKinh = DataReader.GetInt("BenhHeThanKinh");
                    data.BengPhoiTacNghen = DataReader.GetInt("BengPhoiTacNghen");
                    data.Steroid = DataReader.GetInt("Steroid");
                    data.Steroid_DuongUong = DataReader.GetInt("Steroid_DuongUong");
                    data.Steroid_DuongHit = DataReader.GetInt("Steroid_DuongHit");
                    data.Steroi_ChuaRo = DataReader.GetInt("Steroi_ChuaRo");
                    data.CacThuocUcCheKhac = DataReader.GetInt("CacThuocUcCheKhac");
                    data.KhangSinh = DataReader.GetInt("KhangSinh");
                    data.KhangSinh_GhiRoLoai = DataReader["KhangSinh_GhiRoLoai"].ToString();
                    data.KhangViRus = DataReader.GetInt("KhangViRus");
                    data.KhangVirus_GhiRo = DataReader["KhangVirus_GhiRo"].ToString();
                    data.CacLoaiThuocKhac = DataReader.GetInt("CacLoaiThuocKhac");
                    data.CacLoaiThuocKhac_GhiRo = DataReader["CacLoaiThuocKhac_GhiRo"].ToString();
                    data.TiemVacXinPhongCovid19 = DataReader.GetInt("TiemVacXinPhongCovid19");
                    data.ThoiGianTiemMui_1 = DataReader.GetInt("ThoiGianTiemMui_1");
                    data.LoaiVacxinMui_1 = DataReader.GetInt("LoaiVacxinMui_1");
                    data.LoaiVacxinMui_1_CuThe = DataReader["LoaiVacxinMui_1_CuThe"].ToString();
                    data.ThoiGianTiemMui_2 = DataReader.GetInt("ThoiGianTiemMui_2");
                    data.LoaiVacxinMui_2 = DataReader.GetInt("LoaiVacxinMui_2");
                    data.LoaiVacxinMui_2_CuThe = DataReader["LoaiVacxinMui_2_CuThe"].ToString();
                    data.ThoiGianTiemMui_3 = DataReader.GetInt("ThoiGianTiemMui_3");
                    data.LoaiVacxinMui_3 = DataReader.GetInt("LoaiVacxinMui_3");
                    data.LoaiVacxinMui_3_CuThe = DataReader["LoaiVacxinMui_3_CuThe"].ToString();
                    data.NhietDo = DataReader["NhietDo"].ToString();
                    data.NhipTim = DataReader["NhipTim"].ToString();
                    data.NhipTho = DataReader["NhipTho"].ToString();
                    data.HuyetApTamThu = DataReader["HuyetApTamThu"].ToString();
                    data.HuyetApTamTruong = DataReader["HuyetApTamTruong"].ToString();
                    data.DoBaoHoaOxy = DataReader["DoBaoHoaOxy"].ToString();
                    data.ChieuCao = DataReader["ChieuCao"].ToString();
                    data.CanNang = DataReader["CanNang"].ToString();
                    data.Sot = DataReader.GetInt("Sot");
                    data.KietSucMetMoi = DataReader.GetInt("KietSucMetMoi");
                    data.Ho = DataReader.GetInt("Ho");
                    data.ChanAn = DataReader.GetInt("ChanAn");
                    data.DauHong = DataReader.GetInt("DauHong");
                    data.ThayDoiTriGiac = DataReader.GetInt("ThayDoiTriGiac");
                    data.SoMui = DataReader.GetInt("SoMui");
                    data.DauCo = DataReader.GetInt("DauCo");
                    data.KhoTho = DataReader.GetInt("KhoTho");
                    data.DauKhop = DataReader.GetInt("DauKhop");
                    data.DauNguc = DataReader.GetInt("DauNguc");
                    data.MatKhaNangDiLai = DataReader.GetInt("MatKhaNangDiLai");
                    data.ViemKetMac = DataReader.GetInt("ViemKetMac");
                    data.DauBung = DataReader.GetInt("DauBung");
                    data.NoiHachNgoaiVi = DataReader.GetInt("NoiHachNgoaiVi");
                    data.TieuChay = DataReader.GetInt("TieuChay");
                    data.DauDau = DataReader.GetInt("DauDau");
                    data.BuonNon = DataReader.GetInt("BuonNon");
                    data.MatKhuuGiac = DataReader.GetInt("MatKhuuGiac");
                    data.PhatBan = DataReader.GetInt("PhatBan");
                    data.MatViGiac = DataReader.GetInt("MatViGiac");
                    data.ChayMau = DataReader.GetInt("ChayMau");
                    data.ChayMau_ViTriCuThe = DataReader["ChayMau_ViTriCuThe"].ToString();
                    data.CoGiat = DataReader.GetInt("CoGiat");
                    data.TrieuChungKhac = DataReader.GetInt("TrieuChungKhac");
                    data.TrieuChungKhac_NeuCoCuThe = DataReader["TrieuChungKhac_NeuCoCuThe"].ToString();
                    data.ChanDoanLucNhapVien = DataReader["ChanDoanLucNhapVien"].ToString();
                    data.DanhGiaTinhTrangBenhLy = DataReader.GetInt("DanhGiaTinhTrangBenhLy");
                    data.LieuPhapOxy = DataReader.GetInt("LieuPhapOxy");
                    data.LieuPhapOxy_TTG = DataReader["LieuPhapOxy_TTG"].ToString();
                    data.LuuLuongOxyToiDa = DataReader.GetInt("LuuLuongOxyToiDa");
                    data.ThoMayKhongXamNhap = DataReader.GetInt("ThoMayKhongXamNhap");
                    data.ThoMayKhongXamNhap_TTG = DataReader["ThoMayKhongXamNhap_TTG"].ToString();
                    data.ThoMayXamNhap = DataReader.GetInt("ThoMayXamNhap");
                    data.ThoMayXamNhap_TTG = DataReader["ThoMayXamNhap_TTG"].ToString();
                    data.LPOXDCQM = DataReader.GetInt("LPOXDCQM");
                    data.LPOXDCQM_TTG = DataReader["LPOXDCQM_TTG"].ToString();
                    data.ThongKhiNamSap = DataReader.GetInt("ThongKhiNamSap");
                    data.KhaiKhiDao = DataReader.GetInt("KhaiKhiDao");
                    data.ECMO = DataReader.GetInt("ECMO");
                    data.ECMO_TTG = DataReader["ECMO_TTG"].ToString();
                    data.LocMau = DataReader.GetInt("LocMau");
                    data.LocMau_TTG = DataReader["LocMau_TTG"].ToString();
                    data.ThuocVanMach = DataReader.GetInt("ThuocVanMach");
                    data.NhapICU = DataReader.GetInt("NhapICU");
                    data.NhapICU_TTG = DataReader["NhapICU_TTG"].ToString();
                    data.XetNghiemRT_PCR = DataReader.GetInt("XetNghiemRT_PCR");
                    data.ViKhuan = DataReader.GetInt("ViKhuan");
                    data.ViKhuan_DinhDanh = DataReader["ViKhuan_DinhDanh"].ToString();
                    data.CacMamBenhKhac = DataReader.GetInt("CacMamBenhKhac");
                    data.CacMamBenhKhac_DinhDanh = DataReader["CacMamBenhKhac_DinhDanh"].ToString();
                    data.BVPDCDTLS = DataReader.GetInt("BVPDCDTLS");
                    data.ChupXQuangPhoi = DataReader.GetInt("ChupXQuangPhoi");
                    data.ChupXQuangPhoi_CoThamNhiem = DataReader.GetInt("ChupXQuangPhoi_CoThamNhiem");
                    data.ChupCTNguc = DataReader.GetInt("ChupCTNguc");
                    data.ChupCTNguc_CoThamNhiem = DataReader.GetInt("ChupCTNguc_CoThamNhiem");
                    data.Molnupiravir = DataReader.GetInt("Molnupiravir");
                    data.Molnupiravir_NgayBatDau = DataReader["Molnupiravir_NgayBatDau"] != DBNull.Value ? (DateTime?)Convert.ToDateTime(DataReader["Molnupiravir_NgayBatDau"].ToString()) : null;
                    data.Molnupiravir_ThoiGian = DataReader["Molnupiravir_ThoiGian"].ToString();
                    data.Ribavirin = DataReader.GetInt("Ribavirin");
                    data.Ribavirin_NgayBatDau = DataReader["Ribavirin_NgayBatDau"] != DBNull.Value ? (DateTime?)Convert.ToDateTime(DataReader["Ribavirin_NgayBatDau"].ToString()) : null;
                    data.Ribavirin_ThoiGian = DataReader["Ribavirin_ThoiGian"].ToString();
                    data.Lopinavir = DataReader.GetInt("Lopinavir");
                    data.Lopinavir_NgayBatDau = DataReader["Lopinavir_NgayBatDau"] != DBNull.Value ? (DateTime?)Convert.ToDateTime(DataReader["Lopinavir_NgayBatDau"].ToString()) : null;
                    data.Lopinavir_ThoiGian = DataReader["Lopinavir_ThoiGian"].ToString();
                    data.Remdesivir = DataReader.GetInt("Remdesivir");
                    data.Remdesivir_NgayBatDau = DataReader["Remdesivir_NgayBatDau"] != DBNull.Value ? (DateTime?)Convert.ToDateTime(DataReader["Remdesivir_NgayBatDau"].ToString()) : null;
                    data.Remdesivir_ThoiGian = DataReader["Remdesivir_ThoiGian"].ToString();
                    data.Interferon_alpha = DataReader.GetInt("Interferon_alpha");
                    data.Interferon_alpha_NgayBatDau = DataReader["Interferon_alpha_NgayBatDau"] != DBNull.Value ? (DateTime?)Convert.ToDateTime(DataReader["Interferon_alpha_NgayBatDau"].ToString()) : null;
                    data.Interferon_alpha_ThoiGian = DataReader["Interferon_alpha_ThoiGian"].ToString();
                    data.Interferon_beta = DataReader.GetInt("Interferon_beta");
                    data.Interferon_beta_NgayBatDau = DataReader["Interferon_beta_NgayBatDau"] != DBNull.Value ? (DateTime?)Convert.ToDateTime(DataReader["Interferon_beta_NgayBatDau"].ToString()) : null;
                    data.Interferon_beta_ThoiGian = DataReader["Interferon_beta_ThoiGian"].ToString();
                    data.Khang_Interleukin = DataReader.GetInt("Khang_Interleukin");
                    data.Tocilizumab = DataReader.GetInt("Tocilizumab");
                    data.Sarilumab = DataReader.GetInt("Sarilumab");
                    data.Khang_Interleukin_Khac = DataReader.GetInt("Khang_Interleukin_Khac");
                    data.Khang_Interleukin_NgayBatDau = DataReader["Khang_Interleukin_NgayBatDau"] != DBNull.Value ? (DateTime?)Convert.ToDateTime(DataReader["Khang_Interleukin_NgayBatDau"].ToString()) : null;
                    data.Khang_Interleukin_ThoiGian = DataReader["Khang_Interleukin_ThoiGian"].ToString();
                    data.TruyenHuyetTuong = DataReader.GetInt("TruyenHuyetTuong");
                    data.TruyenHuyetTuong_NgayBatDau = DataReader["TruyenHuyetTuong_NgayBatDau"] != DBNull.Value ? (DateTime?)Convert.ToDateTime(DataReader["TruyenHuyetTuong_NgayBatDau"].ToString()) : null;
                    data.TruyenHuyetTuong_ThoiGian = DataReader["TruyenHuyetTuong_ThoiGian"].ToString();
                    data.ThuocKhang_Khac = DataReader.GetInt("ThuocKhang_Khac");
                    data.ThuocKhang_Khac_Text = DataReader["ThuocKhang_Khac_Text"].ToString();
                    data.ThuocKhang_Khac_NgayBatDau = DataReader["ThuocKhang_Khac_NgayBatDau"] != DBNull.Value ? (DateTime?)Convert.ToDateTime(DataReader["ThuocKhang_Khac_NgayBatDau"].ToString()) : null;
                    data.ThuocKhang_Khac_ThoiGian = DataReader["ThuocKhang_Khac_ThoiGian"].ToString();
                    data.Beta_lactam = DataReader.GetInt("Beta_lactam");
                    data.Beta_lactam_NgayBatDau = DataReader["Beta_lactam_NgayBatDau"] != DBNull.Value ? (DateTime?)Convert.ToDateTime(DataReader["Beta_lactam_NgayBatDau"].ToString()) : null;
                    data.Beta_lactam_ThoiGian = DataReader["Beta_lactam_ThoiGian"].ToString();
                    data.Aminoglycosid = DataReader.GetInt("Aminoglycosid");
                    data.Aminoglycosid_NgayBatDau = DataReader["Aminoglycosid_NgayBatDau"] != DBNull.Value ? (DateTime?)Convert.ToDateTime(DataReader["Aminoglycosid_NgayBatDau"].ToString()) : null;
                    data.Aminoglycosid_ThoiGian = DataReader["Aminoglycosid_ThoiGian"].ToString();
                    data.Macrolid = DataReader.GetInt("Macrolid");
                    data.Macrolid_NgayBatDau = DataReader["Macrolid_NgayBatDau"] != DBNull.Value ? (DateTime?)Convert.ToDateTime(DataReader["Macrolid_NgayBatDau"].ToString()) : null;
                    data.Macrolid_ThoiGian = DataReader["Macrolid_ThoiGian"].ToString();
                    data.Lincosamid = DataReader.GetInt("Lincosamid");
                    data.Lincosamid_NgayBatDau = DataReader["Lincosamid_NgayBatDau"] != DBNull.Value ? (DateTime?)Convert.ToDateTime(DataReader["Lincosamid_NgayBatDau"].ToString()) : null;
                    data.Lincosamid_ThoiGian = DataReader["Lincosamid_ThoiGian"].ToString();
                    data.Phenicol = DataReader.GetInt("Phenicol");
                    data.Phenicol_NgayBatDau = DataReader["Phenicol_NgayBatDau"] != DBNull.Value ? (DateTime?)Convert.ToDateTime(DataReader["Phenicol_NgayBatDau"].ToString()) : null;
                    data.Phenicol_ThoiGian = DataReader["Phenicol_ThoiGian"].ToString();
                    data.Tetracyclin = DataReader.GetInt("Tetracyclin");
                    data.Tetracyclin_NgayBatDau = DataReader["Tetracyclin_NgayBatDau"] != DBNull.Value ? (DateTime?)Convert.ToDateTime(DataReader["Tetracyclin_NgayBatDau"].ToString()) : null;
                    data.Tetracyclin_ThoiGian = DataReader["Tetracyclin_ThoiGian"].ToString();
                    data.Peptid = DataReader.GetInt("Peptid");
                    data.Peptid_NgayBatDau = DataReader["Peptid_NgayBatDau"] != DBNull.Value ? (DateTime?)Convert.ToDateTime(DataReader["Peptid_NgayBatDau"].ToString()) : null;
                    data.Peptid_ThoiGian = DataReader["Peptid_ThoiGian"].ToString();
                    data.Quinolon = DataReader.GetInt("Quinolon");
                    data.Quinolon_NgayBatDau = DataReader["Quinolon_NgayBatDau"] != DBNull.Value ? (DateTime?)Convert.ToDateTime(DataReader["Quinolon_NgayBatDau"].ToString()) : null;
                    data.Quinolon_ThoiGian = DataReader["Quinolon_ThoiGian"].ToString();
                    data.KhangSinhKhac = DataReader.GetInt("KhangSinhKhac");
                    data.KhangSinhKhac_Text = DataReader["KhangSinhKhac_Text"].ToString();
                    data.KhangSinhKhac_NgayBatDau = DataReader["KhangSinhKhac_NgayBatDau"] != DBNull.Value ? (DateTime?)Convert.ToDateTime(DataReader["KhangSinhKhac_NgayBatDau"].ToString()) : null;
                    data.KhangSinhKhac_ThoiGian = DataReader["KhangSinhKhac_ThoiGian"].ToString();
                    data.CORTICOSTEROID = DataReader.GetInt("CORTICOSTEROID");
                    data.Prednisolone = DataReader.GetInt("Prednisolone");
                    data.Hydrocortisone = DataReader.GetInt("Hydrocortisone");
                    data.Methylprednisolone = DataReader.GetInt("Methylprednisolone");
                    data.CORTICOSTEROID_Khac = DataReader.GetInt("CORTICOSTEROID_Khac");
                    data.CORTICOSTEROID_Khac_Text = DataReader["CORTICOSTEROID_Khac_Text"].ToString();
                    data.CORTICOSTEROID_DuongDung = DataReader.GetInt("CORTICOSTEROID_DuongDung");
                    data.ThuocKhangDong = DataReader.GetInt("ThuocKhangDong");
                    data.ThuocKhangDong_Loai = DataReader["ThuocKhangDong_Loai"].ToString();
                    data.ThuocKhangDong_DuongDung = DataReader.GetInt("ThuocKhangDong_DuongDung");
                    data.ChiDinh_DieuTri = DataReader.GetInt("ChiDinh_DieuTri");
                    data.ChiDinh_DuPhongTangCuong = DataReader.GetInt("ChiDinh_DuPhongTangCuong");
                    data.ChiDinh_DuPhongBenhNen = DataReader.GetInt("ChiDinh_DuPhongBenhNen");
                    data.ThuocKhangNam = DataReader.GetInt("ThuocKhangNam");
                    data.ThuocKhangNam_Loai = DataReader["ThuocKhangNam_Loai"].ToString();
                    data.ThuocKhangNam_ThoiGian = DataReader["ThuocKhangNam_ThoiGian"].ToString();
                    data.ViemPhoiRoVirus = DataReader.GetInt("ViemPhoiRoVirus");
                    data.ViemMangNao = DataReader.GetInt("ViemMangNao");
                    data.ViemPhoiDoViKhuan = DataReader.GetInt("ViemPhoiDoViKhuan");
                    data.NhiemTrungHuyet = DataReader.GetInt("NhiemTrungHuyet");
                    data.HCSGHHCT = DataReader.GetInt("HCSGHHCT");
                    data.RLDMDIC = DataReader.GetInt("RLDMDIC");
                    data.TranKhiMangPhoi = DataReader.GetInt("TranKhiMangPhoi");
                    data.ThuyenTacPhoi = DataReader.GetInt("ThuyenTacPhoi");
                    data.TranDichMangPhoi = DataReader.GetInt("TranDichMangPhoi");
                    data.HuyetKhoiTinhMachSau = DataReader.GetInt("HuyetKhoiTinhMachSau");
                    data.NhoiMauCoTim = DataReader.GetInt("NhoiMauCoTim");
                    data.HuyetKhoiTacMachKhac = DataReader.GetInt("HuyetKhoiTacMachKhac");
                    data.RoiLoanNhipTim = DataReader.GetInt("RoiLoanNhipTim");
                    data.ThieuMau = DataReader.GetInt("ThieuMau");
                    data.ViemCoTim = DataReader.GetInt("ViemCoTim");
                    data.TieuCoVan = DataReader.GetInt("TieuCoVan");
                    data.ViemNoiTamMac = DataReader.GetInt("ViemNoiTamMac");
                    data.TonThuongThanCapTinh = DataReader.GetInt("TonThuongThanCapTinh");
                    data.BenhCoTim = DataReader.GetInt("BenhCoTim");
                    data.XuatHuyetDuongTieuHoa = DataReader.GetInt("XuatHuyetDuongTieuHoa");
                    data.SuyTimSungHuyet = DataReader.GetInt("SuyTimSungHuyet");
                    data.ViemTuy = DataReader.GetInt("ViemTuy");
                    data.BienChung_CoGiat = DataReader.GetInt("BienChung_CoGiat");
                    data.RoiLoanChucNangGan = DataReader.GetInt("RoiLoanChucNangGan");
                    data.TaiBienMachMauNao = DataReader.GetInt("TaiBienMachMauNao");
                    data.TangDuongHuyet = DataReader.GetInt("TangDuongHuyet");
                    data.HaDuongHuyet = DataReader.GetInt("HaDuongHuyet");
                    data.BienChung_Khac = DataReader.GetInt("BienChung_Khac");
                    data.BienChung_Khac_Text = DataReader["BienChung_Khac_Text"].ToString();
                    data.XuatVien = DataReader.GetInt("XuatVien");
                    data.ChuyenDiCoSoKhac = DataReader.GetInt("ChuyenDiCoSoKhac");
                    data.TenCoSoChuyenDi = DataReader["TenCoSoChuyenDi"].ToString();
                    data.TuVong = DataReader.GetInt("TuVong");
                    data.XVVTTNK = DataReader.GetInt("XVVTTNK");
                    data.NguyenNhanTuVong = DataReader["NguyenNhanTuVong"].ToString();
                    data.NgayTongKet = DataReader["NgayTongKet"] != DBNull.Value ? (DateTime?)Convert.ToDateTime(DataReader["NgayTongKet"].ToString()) : null;
                    data.BacSy = DataReader["BacSy"].ToString();



                    data.NgayTao = Convert.ToDateTime(DataReader["NgayTao"] == DBNull.Value ? DateTime.Now : DataReader["NgayTao"]);
                    data.NguoiTao = DataReader["NguoiTao"].ToString();
                    data.NgaySua = Convert.ToDateTime(DataReader["NgaySua"] == DBNull.Value ? DateTime.Now : DataReader["NgaySua"]);
                    data.NguoiSua = DataReader["NguoiSua"].ToString();

                    data.MaSoKy = DataReader["masokyten"].ToString();
                    data.DaKy = !string.IsNullOrEmpty(data.MaSoKy) ? true : false;
                    list.Add(data);
                }
            }
            catch (Exception ex) { XuLyLoi.Handle(ex); }
            return list;
        }
        public static bool InsertOrUpdate(MDB.MDBConnection MyConnection, ref BABNDieuTriCovid19NTP ketQua)
        {
            try
            {
                string sql = @"INSERT INTO BABNDieuTriCovid19NTP
                (
                    MAQUANLY,
                    MaBenhNhan,
                    SoLuuTru,
                    MaYT,
                    NoiDangSinhSong,
                    NguoiBaoHo,
                    NgheNghiep,
                    NoiLamViec,
                    CMND,
                    SoDienThoai,
                    NgayTiepNhanF0,
                    NgayXuatHienTrieuChung,
                    TestNhanh,
                    TestNhanh_Text,
                    TestPCR,
                    TestPCR_Text,
                    MangThai,
                    SoTuanThai,
                    HauSan,
                    TreSoSinhDuocXNCovid19,
                    KetQuaXN,
                    TangHuyetAp,
                    UngThu,
                    DaiThaoDuong,
                    KetQuaHBA1c,
                    DonVi,
                    AIDS_HIV,
                    BenhTimMach,
                    BenhThap,
                    BenhLyMachMauNao,
                    BenhGan,
                    BenhThanManTinh,
                    HoiChungDown,
                    BenhHenSuyen,
                    RoiLoanSuDungChatGayNghien,
                    BeoPhi,
                    GhepTang,
                    ThieuHutMienDich,
                    CacLoaiBenhHeThong,
                    SuDungcorticosteroid,
                    BenhHeThanKinh,
                    BengPhoiTacNghen,
                    Steroid,
                    Steroid_DuongUong,
                    Steroid_DuongHit,
                    Steroi_ChuaRo,
                    CacThuocUcCheKhac,
                    KhangSinh,
                    KhangSinh_GhiRoLoai,
                    KhangViRus,
                    KhangVirus_GhiRo,
                    CacLoaiThuocKhac,
                    CacLoaiThuocKhac_GhiRo,
                    TiemVacXinPhongCovid19,
                    ThoiGianTiemMui_1,
                    LoaiVacxinMui_1,
                    LoaiVacxinMui_1_CuThe,
                    ThoiGianTiemMui_2,
                    LoaiVacxinMui_2,
                    LoaiVacxinMui_2_CuThe,
                    ThoiGianTiemMui_3,
                    LoaiVacxinMui_3,
                    LoaiVacxinMui_3_CuThe,
                    NhietDo,
                    NhipTim,
                    NhipTho,
                    HuyetApTamThu,
                    HuyetApTamTruong,
                    DoBaoHoaOxy,
                    ChieuCao,
                    CanNang,
                    Sot,
                    KietSucMetMoi,
                    Ho,
                    ChanAn,
                    DauHong,
                    ThayDoiTriGiac,
                    SoMui,
                    DauCo,
                    KhoTho,
                    DauKhop,
                    DauNguc,
                    MatKhaNangDiLai,
                    ViemKetMac,
                    DauBung,
                    NoiHachNgoaiVi,
                    TieuChay,
                    DauDau,
                    BuonNon,
                    MatKhuuGiac,
                    PhatBan,
                    MatViGiac,
                    ChayMau,
                    ChayMau_ViTriCuThe,
                    CoGiat,
                    TrieuChungKhac,
                    TrieuChungKhac_NeuCoCuThe,
                    ChanDoanLucNhapVien,
                    DanhGiaTinhTrangBenhLy,
                    LieuPhapOxy,
                    LieuPhapOxy_TTG,
                    LuuLuongOxyToiDa,
                    ThoMayKhongXamNhap,
                    ThoMayKhongXamNhap_TTG,
                    ThoMayXamNhap,
                    ThoMayXamNhap_TTG,
                    LPOXDCQM,
                    LPOXDCQM_TTG,
                    ThongKhiNamSap,
                    KhaiKhiDao,
                    ECMO,
                    ECMO_TTG,
                    LocMau,
                    LocMau_TTG,
                    ThuocVanMach,
                    NhapICU,
                    NhapICU_TTG,
                    XetNghiemRT_PCR,
                    ViKhuan,
                    ViKhuan_DinhDanh,
                    CacMamBenhKhac,
                    CacMamBenhKhac_DinhDanh,
                    BVPDCDTLS,
                    ChupXQuangPhoi,
                    ChupXQuangPhoi_CoThamNhiem,
                    ChupCTNguc,
                    ChupCTNguc_CoThamNhiem,
                    Molnupiravir,
                    Molnupiravir_NgayBatDau,
                    Molnupiravir_ThoiGian,
                    Ribavirin,
                    Ribavirin_NgayBatDau,
                    Ribavirin_ThoiGian,
                    Lopinavir,
                    Lopinavir_NgayBatDau,
                    Lopinavir_ThoiGian,
                    Remdesivir,
                    Remdesivir_NgayBatDau,
                    Remdesivir_ThoiGian,
                    Interferon_alpha,
                    Interferon_alpha_NgayBatDau,
                    Interferon_alpha_ThoiGian,
                    Interferon_beta,
                    Interferon_beta_NgayBatDau,
                    Interferon_beta_ThoiGian,
                    Khang_Interleukin,
                    Tocilizumab,
                    Sarilumab,
                    Khang_Interleukin_Khac,
                    Khang_Interleukin_NgayBatDau,
                    Khang_Interleukin_ThoiGian,
                    TruyenHuyetTuong,
                    TruyenHuyetTuong_NgayBatDau,
                    TruyenHuyetTuong_ThoiGian,
                    ThuocKhang_Khac,
                    ThuocKhang_Khac_Text,
                    ThuocKhang_Khac_NgayBatDau,
                    ThuocKhang_Khac_ThoiGian,
                    Beta_lactam,
                    Beta_lactam_NgayBatDau,
                    Beta_lactam_ThoiGian,
                    Aminoglycosid,
                    Aminoglycosid_NgayBatDau,
                    Aminoglycosid_ThoiGian,
                    Macrolid,
                    Macrolid_NgayBatDau,
                    Macrolid_ThoiGian,
                    Lincosamid,
                    Lincosamid_NgayBatDau,
                    Lincosamid_ThoiGian,
                    Phenicol,
                    Phenicol_NgayBatDau,
                    Phenicol_ThoiGian,
                    Tetracyclin,
                    Tetracyclin_NgayBatDau,
                    Tetracyclin_ThoiGian,
                    Peptid,
                    Peptid_NgayBatDau,
                    Peptid_ThoiGian,
                    Quinolon,
                    Quinolon_NgayBatDau,
                    Quinolon_ThoiGian,
                    KhangSinhKhac,
                    KhangSinhKhac_Text,
                    KhangSinhKhac_NgayBatDau,
                    KhangSinhKhac_ThoiGian,
                    CORTICOSTEROID,
                    Prednisolone,
                    Hydrocortisone,
                    Methylprednisolone,
                    CORTICOSTEROID_Khac,
                    CORTICOSTEROID_Khac_Text,
                    CORTICOSTEROID_DuongDung,
                    ThuocKhangDong,
                    ThuocKhangDong_Loai,
                    ThuocKhangDong_DuongDung,
                    ChiDinh_DieuTri,
                    ChiDinh_DuPhongTangCuong,
                    ChiDinh_DuPhongBenhNen,
                    ThuocKhangNam,
                    ThuocKhangNam_Loai,
                    ThuocKhangNam_ThoiGian,
                    ViemPhoiRoVirus,
                    ViemMangNao,
                    ViemPhoiDoViKhuan,
                    NhiemTrungHuyet,
                    HCSGHHCT,
                    RLDMDIC,
                    TranKhiMangPhoi,
                    ThuyenTacPhoi,
                    TranDichMangPhoi,
                    HuyetKhoiTinhMachSau,
                    NhoiMauCoTim,
                    HuyetKhoiTacMachKhac,
                    RoiLoanNhipTim,
                    ThieuMau,
                    ViemCoTim,
                    TieuCoVan,
                    ViemNoiTamMac,
                    TonThuongThanCapTinh,
                    BenhCoTim,
                    XuatHuyetDuongTieuHoa,
                    SuyTimSungHuyet,
                    ViemTuy,
                    BienChung_CoGiat,
                    RoiLoanChucNangGan,
                    TaiBienMachMauNao,
                    TangDuongHuyet,
                    HaDuongHuyet,
                    BienChung_Khac,
                    BienChung_Khac_Text,
                    XuatVien,
                    ChuyenDiCoSoKhac,
                    TenCoSoChuyenDi,
                    TuVong,
                    XVVTTNK,
                    NguyenNhanTuVong,
                    NgayTongKet,
                    BacSy,
                    NGUOITAO,
                    NGUOISUA,
                    NGAYTAO,
                    NGAYSUA)  VALUES
                 (
				    :MAQUANLY,
                    :MaBenhNhan,
                    :SoLuuTru,
                    :MaYT,
                    :NoiDangSinhSong,
                    :NguoiBaoHo,
                    :NgheNghiep,
                    :NoiLamViec,
                    :CMND,
                    :SoDienThoai,
                    :NgayTiepNhanF0,
                    :NgayXuatHienTrieuChung,
                    :TestNhanh,
                    :TestNhanh_Text,
                    :TestPCR,
                    :TestPCR_Text,
                    :MangThai,
                    :SoTuanThai,
                    :HauSan,
                    :TreSoSinhDuocXNCovid19,
                    :KetQuaXN,
                    :TangHuyetAp,
                    :UngThu,
                    :DaiThaoDuong,
                    :KetQuaHBA1c,
                    :DonVi,
                    :AIDS_HIV,
                    :BenhTimMach,
                    :BenhThap,
                    :BenhLyMachMauNao,
                    :BenhGan,
                    :BenhThanManTinh,
                    :HoiChungDown,
                    :BenhHenSuyen,
                    :RoiLoanSuDungChatGayNghien,
                    :BeoPhi,
                    :GhepTang,
                    :ThieuHutMienDich,
                    :CacLoaiBenhHeThong,
                    :SuDungcorticosteroid,
                    :BenhHeThanKinh,
                    :BengPhoiTacNghen,
                    :Steroid,
                    :Steroid_DuongUong,
                    :Steroid_DuongHit,
                    :Steroi_ChuaRo,
                    :CacThuocUcCheKhac,
                    :KhangSinh,
                    :KhangSinh_GhiRoLoai,
                    :KhangViRus,
                    :KhangVirus_GhiRo,
                    :CacLoaiThuocKhac,
                    :CacLoaiThuocKhac_GhiRo,
                    :TiemVacXinPhongCovid19,
                    :ThoiGianTiemMui_1,
                    :LoaiVacxinMui_1,
                    :LoaiVacxinMui_1_CuThe,
                    :ThoiGianTiemMui_2,
                    :LoaiVacxinMui_2,
                    :LoaiVacxinMui_2_CuThe,
                    :ThoiGianTiemMui_3,
                    :LoaiVacxinMui_3,
                    :LoaiVacxinMui_3_CuThe,
                    :NhietDo,
                    :NhipTim,
                    :NhipTho,
                    :HuyetApTamThu,
                    :HuyetApTamTruong,
                    :DoBaoHoaOxy,
                    :ChieuCao,
                    :CanNang,
                    :Sot,
                    :KietSucMetMoi,
                    :Ho,
                    :ChanAn,
                    :DauHong,
                    :ThayDoiTriGiac,
                    :SoMui,
                    :DauCo,
                    :KhoTho,
                    :DauKhop,
                    :DauNguc,
                    :MatKhaNangDiLai,
                    :ViemKetMac,
                    :DauBung,
                    :NoiHachNgoaiVi,
                    :TieuChay,
                    :DauDau,
                    :BuonNon,
                    :MatKhuuGiac,
                    :PhatBan,
                    :MatViGiac,
                    :ChayMau,
                    :ChayMau_ViTriCuThe,
                    :CoGiat,
                    :TrieuChungKhac,
                    :TrieuChungKhac_NeuCoCuThe,
                    :ChanDoanLucNhapVien,
                    :DanhGiaTinhTrangBenhLy,
                    :LieuPhapOxy,
                    :LieuPhapOxy_TTG,
                    :LuuLuongOxyToiDa,
                    :ThoMayKhongXamNhap,
                    :ThoMayKhongXamNhap_TTG,
                    :ThoMayXamNhap,
                    :ThoMayXamNhap_TTG,
                    :LPOXDCQM,
                    :LPOXDCQM_TTG,
                    :ThongKhiNamSap,
                    :KhaiKhiDao,
                    :ECMO,
                    :ECMO_TTG,
                    :LocMau,
                    :LocMau_TTG,
                    :ThuocVanMach,
                    :NhapICU,
                    :NhapICU_TTG,
                    :XetNghiemRT_PCR,
                    :ViKhuan,
                    :ViKhuan_DinhDanh,
                    :CacMamBenhKhac,
                    :CacMamBenhKhac_DinhDanh,
                    :BVPDCDTLS,
                    :ChupXQuangPhoi,
                    :ChupXQuangPhoi_CoThamNhiem,
                    :ChupCTNguc,
                    :ChupCTNguc_CoThamNhiem,
                    :Molnupiravir,
                    :Molnupiravir_NgayBatDau,
                    :Molnupiravir_ThoiGian,
                    :Ribavirin,
                    :Ribavirin_NgayBatDau,
                    :Ribavirin_ThoiGian,
                    :Lopinavir,
                    :Lopinavir_NgayBatDau,
                    :Lopinavir_ThoiGian,
                    :Remdesivir,
                    :Remdesivir_NgayBatDau,
                    :Remdesivir_ThoiGian,
                    :Interferon_alpha,
                    :Interferon_alpha_NgayBatDau,
                    :Interferon_alpha_ThoiGian,
                    :Interferon_beta,
                    :Interferon_beta_NgayBatDau,
                    :Interferon_beta_ThoiGian,
                    :Khang_Interleukin,
                    :Tocilizumab,
                    :Sarilumab,
                    :Khang_Interleukin_Khac,
                    :Khang_Interleukin_NgayBatDau,
                    :Khang_Interleukin_ThoiGian,
                    :TruyenHuyetTuong,
                    :TruyenHuyetTuong_NgayBatDau,
                    :TruyenHuyetTuong_ThoiGian,
                    :ThuocKhang_Khac,
                    :ThuocKhang_Khac_Text,
                    :ThuocKhang_Khac_NgayBatDau,
                    :ThuocKhang_Khac_ThoiGian,
                    :Beta_lactam,
                    :Beta_lactam_NgayBatDau,
                    :Beta_lactam_ThoiGian,
                    :Aminoglycosid,
                    :Aminoglycosid_NgayBatDau,
                    :Aminoglycosid_ThoiGian,
                    :Macrolid,
                    :Macrolid_NgayBatDau,
                    :Macrolid_ThoiGian,
                    :Lincosamid,
                    :Lincosamid_NgayBatDau,
                    :Lincosamid_ThoiGian,
                    :Phenicol,
                    :Phenicol_NgayBatDau,
                    :Phenicol_ThoiGian,
                    :Tetracyclin,
                    :Tetracyclin_NgayBatDau,
                    :Tetracyclin_ThoiGian,
                    :Peptid,
                    :Peptid_NgayBatDau,
                    :Peptid_ThoiGian,
                    :Quinolon,
                    :Quinolon_NgayBatDau,
                    :Quinolon_ThoiGian,
                    :KhangSinhKhac,
                    :KhangSinhKhac_Text,
                    :KhangSinhKhac_NgayBatDau,
                    :KhangSinhKhac_ThoiGian,
                    :CORTICOSTEROID,
                    :Prednisolone,
                    :Hydrocortisone,
                    :Methylprednisolone,
                    :CORTICOSTEROID_Khac,
                    :CORTICOSTEROID_Khac_Text,
                    :CORTICOSTEROID_DuongDung,
                    :ThuocKhangDong,
                    :ThuocKhangDong_Loai,
                    :ThuocKhangDong_DuongDung,
                    :ChiDinh_DieuTri,
                    :ChiDinh_DuPhongTangCuong,
                    :ChiDinh_DuPhongBenhNen,
                    :ThuocKhangNam,
                    :ThuocKhangNam_Loai,
                    :ThuocKhangNam_ThoiGian,
                    :ViemPhoiRoVirus,
                    :ViemMangNao,
                    :ViemPhoiDoViKhuan,
                    :NhiemTrungHuyet,
                    :HCSGHHCT,
                    :RLDMDIC,
                    :TranKhiMangPhoi,
                    :ThuyenTacPhoi,
                    :TranDichMangPhoi,
                    :HuyetKhoiTinhMachSau,
                    :NhoiMauCoTim,
                    :HuyetKhoiTacMachKhac,
                    :RoiLoanNhipTim,
                    :ThieuMau,
                    :ViemCoTim,
                    :TieuCoVan,
                    :ViemNoiTamMac,
                    :TonThuongThanCapTinh,
                    :BenhCoTim,
                    :XuatHuyetDuongTieuHoa,
                    :SuyTimSungHuyet,
                    :ViemTuy,
                    :BienChung_CoGiat,
                    :RoiLoanChucNangGan,
                    :TaiBienMachMauNao,
                    :TangDuongHuyet,
                    :HaDuongHuyet,
                    :BienChung_Khac,
                    :BienChung_Khac_Text,
                    :XuatVien,
                    :ChuyenDiCoSoKhac,
                    :TenCoSoChuyenDi,
                    :TuVong,
                    :XVVTTNK,
                    :NguyenNhanTuVong,
                    :NgayTongKet,
                    :BacSy,
                    :NGUOITAO,
                    :NGUOISUA,
                    :NGAYTAO,
                    :NGAYSUA
                 )  RETURNING ID INTO :ID";
                if (ketQua.ID != 0)
                {
                    sql = @"UPDATE BABNDieuTriCovid19NTP SET 
                    MAQUANLY = :MAQUANLY,
                    MaBenhNhan = :MaBenhNhan,
                    SoLuuTru = :SoLuuTru,
                    MaYT = :MaYT,
                    NoiDangSinhSong=:NoiDangSinhSong,
                    NguoiBaoHo=:NguoiBaoHo,
                    NgheNghiep=:NgheNghiep,
                    NoiLamViec=:NoiLamViec,
                    CMND=:CMND,
                    SoDienThoai=:SoDienThoai,
                    NgayTiepNhanF0=:NgayTiepNhanF0,
                    NgayXuatHienTrieuChung=:NgayXuatHienTrieuChung,
                    TestNhanh=:TestNhanh,
                    TestNhanh_Text=:TestNhanh_Text,
                    TestPCR=:TestPCR,
                    TestPCR_Text=:TestPCR_Text,
                    MangThai=:MangThai,
                    SoTuanThai=:SoTuanThai,
                    HauSan=:HauSan,
                    TreSoSinhDuocXNCovid19=:TreSoSinhDuocXNCovid19,
                    KetQuaXN=:KetQuaXN,
                    TangHuyetAp=:TangHuyetAp,
                    UngThu=:UngThu,
                    DaiThaoDuong=:DaiThaoDuong,
                    KetQuaHBA1c=:KetQuaHBA1c,
                    DonVi=:DonVi,
                    AIDS_HIV=:AIDS_HIV,
                    BenhTimMach=:BenhTimMach,
                    BenhThap=:BenhThap,
                    BenhLyMachMauNao=:BenhLyMachMauNao,
                    BenhGan=:BenhGan,
                    BenhThanManTinh=:BenhThanManTinh,
                    HoiChungDown=:HoiChungDown,
                    BenhHenSuyen=:BenhHenSuyen,
                    RoiLoanSuDungChatGayNghien=:RoiLoanSuDungChatGayNghien,
                    BeoPhi=:BeoPhi,
                    GhepTang=:GhepTang,
                    ThieuHutMienDich=:ThieuHutMienDich,
                    CacLoaiBenhHeThong=:CacLoaiBenhHeThong,
                    SuDungcorticosteroid=:SuDungcorticosteroid,
                    BenhHeThanKinh=:BenhHeThanKinh,
                    BengPhoiTacNghen=:BengPhoiTacNghen,
                    Steroid=:Steroid,
                    Steroid_DuongUong=:Steroid_DuongUong,
                    Steroid_DuongHit=:Steroid_DuongHit,
                    Steroi_ChuaRo=:Steroi_ChuaRo,
                    CacThuocUcCheKhac=:CacThuocUcCheKhac,
                    KhangSinh=:KhangSinh,
                    KhangSinh_GhiRoLoai=:KhangSinh_GhiRoLoai,
                    KhangViRus=:KhangViRus,
                    KhangVirus_GhiRo=:KhangVirus_GhiRo,
                    CacLoaiThuocKhac=:CacLoaiThuocKhac,
                    CacLoaiThuocKhac_GhiRo=:CacLoaiThuocKhac_GhiRo,
                    TiemVacXinPhongCovid19=:TiemVacXinPhongCovid19,
                    ThoiGianTiemMui_1=:ThoiGianTiemMui_1,
                    LoaiVacxinMui_1=:LoaiVacxinMui_1,
                    LoaiVacxinMui_1_CuThe=:LoaiVacxinMui_1_CuThe,
                    ThoiGianTiemMui_2=:ThoiGianTiemMui_2,
                    LoaiVacxinMui_2=:LoaiVacxinMui_2,
                    LoaiVacxinMui_2_CuThe=:LoaiVacxinMui_2_CuThe,
                    ThoiGianTiemMui_3=:ThoiGianTiemMui_3,
                    LoaiVacxinMui_3=:LoaiVacxinMui_3,
                    LoaiVacxinMui_3_CuThe=:LoaiVacxinMui_3_CuThe,
                    NhietDo=:NhietDo,
                    NhipTim=:NhipTim,
                    NhipTho = :NhipTho,
                    HuyetApTamThu=:HuyetApTamThu,
                    HuyetApTamTruong=:HuyetApTamTruong,
                    DoBaoHoaOxy=:DoBaoHoaOxy,
                    ChieuCao=:ChieuCao,
                    CanNang=:CanNang,
                    Sot=:Sot,
                    KietSucMetMoi=:KietSucMetMoi,
                    Ho=:Ho,
                    ChanAn=:ChanAn,
                    DauHong=:DauHong,
                    ThayDoiTriGiac=:ThayDoiTriGiac,
                    SoMui=:SoMui,
                    DauCo=:DauCo,
                    KhoTho=:KhoTho,
                    DauKhop=:DauKhop,
                    DauNguc=:DauNguc,
                    MatKhaNangDiLai=:MatKhaNangDiLai,
                    ViemKetMac=:ViemKetMac,
                    DauBung=:DauBung,
                    NoiHachNgoaiVi=:NoiHachNgoaiVi,
                    TieuChay=:TieuChay,
                    DauDau=:DauDau,
                    BuonNon=:BuonNon,
                    MatKhuuGiac=:MatKhuuGiac,
                    PhatBan=:PhatBan,
                    MatViGiac=:MatViGiac,
                    ChayMau=:ChayMau,
                    ChayMau_ViTriCuThe=:ChayMau_ViTriCuThe,
                    CoGiat=:CoGiat,
                    TrieuChungKhac=:TrieuChungKhac,
                    TrieuChungKhac_NeuCoCuThe=:TrieuChungKhac_NeuCoCuThe,
                    ChanDoanLucNhapVien=:ChanDoanLucNhapVien,
                    DanhGiaTinhTrangBenhLy=:DanhGiaTinhTrangBenhLy,
                    LieuPhapOxy=:LieuPhapOxy,
                    LieuPhapOxy_TTG=:LieuPhapOxy_TTG,
                    LuuLuongOxyToiDa=:LuuLuongOxyToiDa,
                    ThoMayKhongXamNhap=:ThoMayKhongXamNhap,
                    ThoMayKhongXamNhap_TTG=:ThoMayKhongXamNhap_TTG,
                    ThoMayXamNhap=:ThoMayXamNhap,
                    ThoMayXamNhap_TTG=:ThoMayXamNhap_TTG,
                    LPOXDCQM=:LPOXDCQM,
                    LPOXDCQM_TTG=:LPOXDCQM_TTG,
                    ThongKhiNamSap=:ThongKhiNamSap,
                    KhaiKhiDao=:KhaiKhiDao,
                    ECMO=:ECMO,
                    ECMO_TTG=:ECMO_TTG,
                    LocMau=:LocMau,
                    LocMau_TTG = :LocMau_TTG,
                    ThuocVanMach=:ThuocVanMach,
                    NhapICU=:NhapICU,
                    NhapICU_TTG=:NhapICU_TTG,
                    XetNghiemRT_PCR=:XetNghiemRT_PCR,
                    ViKhuan=:ViKhuan,
                    ViKhuan_DinhDanh=:ViKhuan_DinhDanh,
                    CacMamBenhKhac=:CacMamBenhKhac,
                    CacMamBenhKhac_DinhDanh=:CacMamBenhKhac_DinhDanh,
                    BVPDCDTLS=:BVPDCDTLS,
                    ChupXQuangPhoi=:ChupXQuangPhoi,
                    ChupXQuangPhoi_CoThamNhiem=:ChupXQuangPhoi_CoThamNhiem,
                    ChupCTNguc=:ChupCTNguc,
                    ChupCTNguc_CoThamNhiem=:ChupCTNguc_CoThamNhiem,
                    Molnupiravir=:Molnupiravir,
                    Molnupiravir_NgayBatDau=:Molnupiravir_NgayBatDau,
                    Molnupiravir_ThoiGian=:Molnupiravir_ThoiGian,
                    Ribavirin=:Ribavirin,
                    Ribavirin_NgayBatDau=:Ribavirin_NgayBatDau,
                    Ribavirin_ThoiGian=:Ribavirin_ThoiGian,
                    Lopinavir=:Lopinavir,
                    Lopinavir_NgayBatDau=:Lopinavir_NgayBatDau,
                    Lopinavir_ThoiGian=:Lopinavir_ThoiGian,
                    Remdesivir=:Remdesivir,
                    Remdesivir_NgayBatDau=:Remdesivir_NgayBatDau,
                    Remdesivir_ThoiGian=:Remdesivir_ThoiGian,
                    Interferon_alpha=:Interferon_alpha,
                    Interferon_alpha_NgayBatDau=:Interferon_alpha_NgayBatDau,
                    Interferon_alpha_ThoiGian=:Interferon_alpha_ThoiGian,
                    Interferon_beta=:Interferon_beta,
                    Interferon_beta_NgayBatDau=:Interferon_beta_NgayBatDau,
                    Interferon_beta_ThoiGian=:Interferon_beta_ThoiGian,
                    Khang_Interleukin=:Khang_Interleukin,
                    Tocilizumab=:Tocilizumab,
                    Sarilumab=:Sarilumab,
                    Khang_Interleukin_Khac=:Khang_Interleukin_Khac,
                    Khang_Interleukin_NgayBatDau=:Khang_Interleukin_NgayBatDau,
                    Khang_Interleukin_ThoiGian=:Khang_Interleukin_ThoiGian,
                    TruyenHuyetTuong=:TruyenHuyetTuong,
                    TruyenHuyetTuong_NgayBatDau=:TruyenHuyetTuong_NgayBatDau,
                    TruyenHuyetTuong_ThoiGian=:TruyenHuyetTuong_ThoiGian,
                    ThuocKhang_Khac=:ThuocKhang_Khac,
                    ThuocKhang_Khac_Text=:ThuocKhang_Khac_Text,
                    ThuocKhang_Khac_NgayBatDau=:ThuocKhang_Khac_NgayBatDau,
                    ThuocKhang_Khac_ThoiGian=:ThuocKhang_Khac_ThoiGian,
                    Beta_lactam=:Beta_lactam,
                    Beta_lactam_NgayBatDau=:Beta_lactam_NgayBatDau,
                    Beta_lactam_ThoiGian=:Beta_lactam_ThoiGian,
                    Aminoglycosid=:Aminoglycosid,
                    Aminoglycosid_NgayBatDau=:Aminoglycosid_NgayBatDau,
                    Aminoglycosid_ThoiGian=:Aminoglycosid_ThoiGian,
                    Macrolid=:Macrolid,
                    Macrolid_NgayBatDau=:Macrolid_NgayBatDau,
                    Macrolid_ThoiGian=:Macrolid_ThoiGian,
                    Lincosamid=:Lincosamid,
                    Lincosamid_NgayBatDau=:Lincosamid_NgayBatDau,
                    Lincosamid_ThoiGian=:Lincosamid_ThoiGian,
                    Phenicol=:Phenicol,
                    Phenicol_NgayBatDau=:Phenicol_NgayBatDau,
                    Phenicol_ThoiGian=:Phenicol_ThoiGian,
                    Tetracyclin=:Tetracyclin,
                    Tetracyclin_NgayBatDau=:Tetracyclin_NgayBatDau,
                    Tetracyclin_ThoiGian=:Tetracyclin_ThoiGian,
                    Peptid=:Peptid,
                    Peptid_NgayBatDau=:Peptid_NgayBatDau,
                    Peptid_ThoiGian=:Peptid_ThoiGian,
                    Quinolon=:Quinolon,
                    Quinolon_NgayBatDau=:Quinolon_NgayBatDau,
                    Quinolon_ThoiGian=:Quinolon_ThoiGian,
                    KhangSinhKhac=:KhangSinhKhac,
                    KhangSinhKhac_Text=:KhangSinhKhac_Text,
                    KhangSinhKhac_NgayBatDau=:KhangSinhKhac_NgayBatDau,
                    KhangSinhKhac_ThoiGian=:KhangSinhKhac_ThoiGian,
                    CORTICOSTEROID=:CORTICOSTEROID,
                    Prednisolone=:Prednisolone,
                    Hydrocortisone=:Hydrocortisone,
                    Methylprednisolone=:Methylprednisolone,
                    CORTICOSTEROID_Khac=:CORTICOSTEROID_Khac,
                    CORTICOSTEROID_Khac_Text=:CORTICOSTEROID_Khac_Text,
                    CORTICOSTEROID_DuongDung=:CORTICOSTEROID_DuongDung,
                    ThuocKhangDong=:ThuocKhangDong,
                    ThuocKhangDong_Loai=:ThuocKhangDong_Loai,
                    ThuocKhangDong_DuongDung=:ThuocKhangDong_DuongDung,
                    ChiDinh_DieuTri=:ChiDinh_DieuTri,
                    ChiDinh_DuPhongTangCuong=:ChiDinh_DuPhongTangCuong,
                    ChiDinh_DuPhongBenhNen=:ChiDinh_DuPhongBenhNen,
                    ThuocKhangNam=:ThuocKhangNam,
                    ThuocKhangNam_Loai=:ThuocKhangNam_Loai,
                    ThuocKhangNam_ThoiGian=:ThuocKhangNam_ThoiGian,
                    ViemPhoiRoVirus=:ViemPhoiRoVirus,
                    ViemMangNao=:ViemMangNao,
                    ViemPhoiDoViKhuan=:ViemPhoiDoViKhuan,
                    NhiemTrungHuyet=:NhiemTrungHuyet,
                    HCSGHHCT=:HCSGHHCT,
                    RLDMDIC=:RLDMDIC,
                    TranKhiMangPhoi=:TranKhiMangPhoi,
                    ThuyenTacPhoi=:ThuyenTacPhoi,
                    TranDichMangPhoi=:TranDichMangPhoi,
                    HuyetKhoiTinhMachSau=:HuyetKhoiTinhMachSau,
                    NhoiMauCoTim=:NhoiMauCoTim,
                    HuyetKhoiTacMachKhac=:HuyetKhoiTacMachKhac,
                    RoiLoanNhipTim=:RoiLoanNhipTim,
                    ThieuMau=:ThieuMau,
                    ViemCoTim=:ViemCoTim,
                    TieuCoVan=:TieuCoVan,
                    ViemNoiTamMac=:ViemNoiTamMac,
                    TonThuongThanCapTinh=:TonThuongThanCapTinh,
                    BenhCoTim=:BenhCoTim,
                    XuatHuyetDuongTieuHoa=:XuatHuyetDuongTieuHoa,
                    SuyTimSungHuyet=:SuyTimSungHuyet,
                    ViemTuy=:ViemTuy,
                    BienChung_CoGiat=:BienChung_CoGiat,
                    RoiLoanChucNangGan=:RoiLoanChucNangGan,
                    TaiBienMachMauNao=:TaiBienMachMauNao,
                    TangDuongHuyet=:TangDuongHuyet,
                    HaDuongHuyet=:HaDuongHuyet,
                    BienChung_Khac=:BienChung_Khac,
                    BienChung_Khac_Text=:BienChung_Khac_Text,
                    XuatVien=:XuatVien,
                    ChuyenDiCoSoKhac=:ChuyenDiCoSoKhac,
                    TenCoSoChuyenDi=:TenCoSoChuyenDi,
                    TuVong=:TuVong,
                    XVVTTNK=:XVVTTNK,
                    NguyenNhanTuVong=:NguyenNhanTuVong,
                    NgayTongKet=:NgayTongKet,
                    BacSy=:BacSy,
                    NGUOISUA = :NGUOISUA,
                    NGAYSUA = :NGAYSUA
                    WHERE ID = " + ketQua.ID;
                }
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MAQUANLY", ketQua.MaQuanLy));
                Command.Parameters.Add(new MDB.MDBParameter("MaBenhNhan", ketQua.MaBenhNhan));
                Command.Parameters.Add(new MDB.MDBParameter("SoLuuTru", ketQua.SoLuuTru));
                Command.Parameters.Add(new MDB.MDBParameter("MaYT", ketQua.MaYT));
                Command.Parameters.Add(new MDB.MDBParameter("NoiDangSinhSong", ketQua.NoiDangSinhSong));
                Command.Parameters.Add(new MDB.MDBParameter("NguoiBaoHo", ketQua.NguoiBaoHo));
                Command.Parameters.Add(new MDB.MDBParameter("NgheNghiep", ketQua.NgheNghiep));
                Command.Parameters.Add(new MDB.MDBParameter("NoiLamViec", ketQua.NoiLamViec));
                Command.Parameters.Add(new MDB.MDBParameter("CMND", ketQua.CMND));
                Command.Parameters.Add(new MDB.MDBParameter("SoDienThoai", ketQua.SoDienThoai));
                Command.Parameters.Add(new MDB.MDBParameter("NgayTiepNhanF0", ketQua.NgayTiepNhanF0));
                Command.Parameters.Add(new MDB.MDBParameter("NgayXuatHienTrieuChung", ketQua.NgayXuatHienTrieuChung));
                Command.Parameters.Add(new MDB.MDBParameter("TestNhanh", ketQua.TestNhanh));
                Command.Parameters.Add(new MDB.MDBParameter("TestNhanh_Text", ketQua.TestNhanh_Text));
                Command.Parameters.Add(new MDB.MDBParameter("TestPCR", ketQua.TestPCR));
                Command.Parameters.Add(new MDB.MDBParameter("TestPCR_Text", ketQua.TestPCR_Text));
                Command.Parameters.Add(new MDB.MDBParameter("MangThai", ketQua.MangThai));
                Command.Parameters.Add(new MDB.MDBParameter("SoTuanThai", ketQua.SoTuanThai));
                Command.Parameters.Add(new MDB.MDBParameter("HauSan", ketQua.HauSan));
                Command.Parameters.Add(new MDB.MDBParameter("TreSoSinhDuocXNCovid19", ketQua.TreSoSinhDuocXNCovid19));
                Command.Parameters.Add(new MDB.MDBParameter("KetQuaXN", ketQua.KetQuaXN));
                Command.Parameters.Add(new MDB.MDBParameter("TangHuyetAp", ketQua.TangHuyetAp));
                Command.Parameters.Add(new MDB.MDBParameter("UngThu", ketQua.UngThu));
                Command.Parameters.Add(new MDB.MDBParameter("DaiThaoDuong", ketQua.DaiThaoDuong));
                Command.Parameters.Add(new MDB.MDBParameter("KetQuaHBA1c", ketQua.KetQuaHBA1c));
                Command.Parameters.Add(new MDB.MDBParameter("DonVi", ketQua.DonVi));
                Command.Parameters.Add(new MDB.MDBParameter("AIDS_HIV", ketQua.AIDS_HIV));
                Command.Parameters.Add(new MDB.MDBParameter("BenhTimMach", ketQua.BenhTimMach));
                Command.Parameters.Add(new MDB.MDBParameter("BenhThap", ketQua.BenhThap));
                Command.Parameters.Add(new MDB.MDBParameter("BenhLyMachMauNao", ketQua.BenhLyMachMauNao));
                Command.Parameters.Add(new MDB.MDBParameter("BenhGan", ketQua.BenhGan));
                Command.Parameters.Add(new MDB.MDBParameter("BenhThanManTinh", ketQua.BenhThanManTinh));
                Command.Parameters.Add(new MDB.MDBParameter("HoiChungDown", ketQua.HoiChungDown));
                Command.Parameters.Add(new MDB.MDBParameter("BenhHenSuyen", ketQua.BenhHenSuyen));
                Command.Parameters.Add(new MDB.MDBParameter("RoiLoanSuDungChatGayNghien", ketQua.RoiLoanSuDungChatGayNghien));
                Command.Parameters.Add(new MDB.MDBParameter("BeoPhi", ketQua.BeoPhi));
                Command.Parameters.Add(new MDB.MDBParameter("GhepTang", ketQua.GhepTang));
                Command.Parameters.Add(new MDB.MDBParameter("ThieuHutMienDich", ketQua.ThieuHutMienDich));
                Command.Parameters.Add(new MDB.MDBParameter("CacLoaiBenhHeThong", ketQua.CacLoaiBenhHeThong));
                Command.Parameters.Add(new MDB.MDBParameter("SuDungcorticosteroid", ketQua.SuDungcorticosteroid));
                Command.Parameters.Add(new MDB.MDBParameter("BenhHeThanKinh", ketQua.BenhHeThanKinh));
                Command.Parameters.Add(new MDB.MDBParameter("BengPhoiTacNghen", ketQua.BengPhoiTacNghen));
                Command.Parameters.Add(new MDB.MDBParameter("Steroid", ketQua.Steroid));
                Command.Parameters.Add(new MDB.MDBParameter("Steroid_DuongUong", ketQua.Steroid_DuongUong));
                Command.Parameters.Add(new MDB.MDBParameter("Steroid_DuongHit", ketQua.Steroid_DuongHit));
                Command.Parameters.Add(new MDB.MDBParameter("Steroi_ChuaRo", ketQua.Steroi_ChuaRo));
                Command.Parameters.Add(new MDB.MDBParameter("CacThuocUcCheKhac", ketQua.CacThuocUcCheKhac));
                Command.Parameters.Add(new MDB.MDBParameter("KhangSinh", ketQua.KhangSinh));
                Command.Parameters.Add(new MDB.MDBParameter("KhangSinh_GhiRoLoai", ketQua.KhangSinh_GhiRoLoai));
                Command.Parameters.Add(new MDB.MDBParameter("KhangViRus", ketQua.KhangViRus));
                Command.Parameters.Add(new MDB.MDBParameter("KhangVirus_GhiRo", ketQua.KhangVirus_GhiRo));
                Command.Parameters.Add(new MDB.MDBParameter("CacLoaiThuocKhac", ketQua.CacLoaiThuocKhac));
                Command.Parameters.Add(new MDB.MDBParameter("CacLoaiThuocKhac_GhiRo", ketQua.CacLoaiThuocKhac_GhiRo));
                Command.Parameters.Add(new MDB.MDBParameter("TiemVacXinPhongCovid19", ketQua.TiemVacXinPhongCovid19));
                Command.Parameters.Add(new MDB.MDBParameter("ThoiGianTiemMui_1", ketQua.ThoiGianTiemMui_1));
                Command.Parameters.Add(new MDB.MDBParameter("LoaiVacxinMui_1", ketQua.LoaiVacxinMui_1));
                Command.Parameters.Add(new MDB.MDBParameter("LoaiVacxinMui_1_CuThe", ketQua.LoaiVacxinMui_1_CuThe));
                Command.Parameters.Add(new MDB.MDBParameter("ThoiGianTiemMui_2", ketQua.ThoiGianTiemMui_2));
                Command.Parameters.Add(new MDB.MDBParameter("LoaiVacxinMui_2", ketQua.LoaiVacxinMui_2));
                Command.Parameters.Add(new MDB.MDBParameter("LoaiVacxinMui_2_CuThe", ketQua.LoaiVacxinMui_2_CuThe));
                Command.Parameters.Add(new MDB.MDBParameter("ThoiGianTiemMui_3", ketQua.ThoiGianTiemMui_3));
                Command.Parameters.Add(new MDB.MDBParameter("LoaiVacxinMui_3", ketQua.LoaiVacxinMui_3));
                Command.Parameters.Add(new MDB.MDBParameter("LoaiVacxinMui_3_CuThe", ketQua.LoaiVacxinMui_3_CuThe));
                Command.Parameters.Add(new MDB.MDBParameter("NhietDo", ketQua.NhietDo));
                Command.Parameters.Add(new MDB.MDBParameter("NhipTim", ketQua.NhipTim));
                Command.Parameters.Add(new MDB.MDBParameter("NhipTho", ketQua.NhipTho));
                Command.Parameters.Add(new MDB.MDBParameter("HuyetApTamThu", ketQua.HuyetApTamThu));
                Command.Parameters.Add(new MDB.MDBParameter("HuyetApTamTruong", ketQua.HuyetApTamTruong));
                Command.Parameters.Add(new MDB.MDBParameter("DoBaoHoaOxy", ketQua.DoBaoHoaOxy));
                Command.Parameters.Add(new MDB.MDBParameter("ChieuCao", ketQua.ChieuCao));
                Command.Parameters.Add(new MDB.MDBParameter("CanNang", ketQua.CanNang));
                Command.Parameters.Add(new MDB.MDBParameter("Sot", ketQua.Sot));
                Command.Parameters.Add(new MDB.MDBParameter("KietSucMetMoi", ketQua.KietSucMetMoi));
                Command.Parameters.Add(new MDB.MDBParameter("Ho", ketQua.Ho));
                Command.Parameters.Add(new MDB.MDBParameter("ChanAn", ketQua.ChanAn));
                Command.Parameters.Add(new MDB.MDBParameter("DauHong", ketQua.DauHong));
                Command.Parameters.Add(new MDB.MDBParameter("ThayDoiTriGiac", ketQua.ThayDoiTriGiac));
                Command.Parameters.Add(new MDB.MDBParameter("SoMui", ketQua.SoMui));
                Command.Parameters.Add(new MDB.MDBParameter("DauCo", ketQua.DauCo));
                Command.Parameters.Add(new MDB.MDBParameter("KhoTho", ketQua.KhoTho));
                Command.Parameters.Add(new MDB.MDBParameter("DauKhop", ketQua.DauKhop));
                Command.Parameters.Add(new MDB.MDBParameter("DauNguc", ketQua.DauNguc));
                Command.Parameters.Add(new MDB.MDBParameter("MatKhaNangDiLai", ketQua.MatKhaNangDiLai));
                Command.Parameters.Add(new MDB.MDBParameter("ViemKetMac", ketQua.ViemKetMac));
                Command.Parameters.Add(new MDB.MDBParameter("DauBung", ketQua.DauBung));
                Command.Parameters.Add(new MDB.MDBParameter("NoiHachNgoaiVi", ketQua.NoiHachNgoaiVi));
                Command.Parameters.Add(new MDB.MDBParameter("TieuChay", ketQua.TieuChay));
                Command.Parameters.Add(new MDB.MDBParameter("DauDau", ketQua.DauDau));
                Command.Parameters.Add(new MDB.MDBParameter("BuonNon", ketQua.BuonNon));
                Command.Parameters.Add(new MDB.MDBParameter("MatKhuuGiac", ketQua.MatKhuuGiac));
                Command.Parameters.Add(new MDB.MDBParameter("PhatBan", ketQua.PhatBan));
                Command.Parameters.Add(new MDB.MDBParameter("MatViGiac", ketQua.MatViGiac));
                Command.Parameters.Add(new MDB.MDBParameter("ChayMau", ketQua.ChayMau));
                Command.Parameters.Add(new MDB.MDBParameter("ChayMau_ViTriCuThe", ketQua.ChayMau_ViTriCuThe));
                Command.Parameters.Add(new MDB.MDBParameter("CoGiat", ketQua.CoGiat));
                Command.Parameters.Add(new MDB.MDBParameter("TrieuChungKhac", ketQua.TrieuChungKhac));
                Command.Parameters.Add(new MDB.MDBParameter("TrieuChungKhac_NeuCoCuThe", ketQua.TrieuChungKhac_NeuCoCuThe));
                Command.Parameters.Add(new MDB.MDBParameter("ChanDoanLucNhapVien", ketQua.ChanDoanLucNhapVien));
                Command.Parameters.Add(new MDB.MDBParameter("DanhGiaTinhTrangBenhLy", ketQua.DanhGiaTinhTrangBenhLy));
                Command.Parameters.Add(new MDB.MDBParameter("LieuPhapOxy", ketQua.LieuPhapOxy));
                Command.Parameters.Add(new MDB.MDBParameter("LieuPhapOxy_TTG", ketQua.LieuPhapOxy_TTG));
                Command.Parameters.Add(new MDB.MDBParameter("LuuLuongOxyToiDa", ketQua.LuuLuongOxyToiDa));
                Command.Parameters.Add(new MDB.MDBParameter("ThoMayKhongXamNhap", ketQua.ThoMayKhongXamNhap));
                Command.Parameters.Add(new MDB.MDBParameter("ThoMayKhongXamNhap_TTG", ketQua.ThoMayKhongXamNhap_TTG));
                Command.Parameters.Add(new MDB.MDBParameter("ThoMayXamNhap", ketQua.ThoMayXamNhap));
                Command.Parameters.Add(new MDB.MDBParameter("ThoMayXamNhap_TTG", ketQua.ThoMayXamNhap_TTG));
                Command.Parameters.Add(new MDB.MDBParameter("LPOXDCQM", ketQua.LPOXDCQM));
                Command.Parameters.Add(new MDB.MDBParameter("LPOXDCQM_TTG", ketQua.LPOXDCQM_TTG));
                Command.Parameters.Add(new MDB.MDBParameter("ThongKhiNamSap", ketQua.ThongKhiNamSap));
                Command.Parameters.Add(new MDB.MDBParameter("KhaiKhiDao", ketQua.KhaiKhiDao));
                Command.Parameters.Add(new MDB.MDBParameter("ECMO", ketQua.ECMO));
                Command.Parameters.Add(new MDB.MDBParameter("ECMO_TTG", ketQua.ECMO_TTG));
                Command.Parameters.Add(new MDB.MDBParameter("LocMau", ketQua.LocMau));
                Command.Parameters.Add(new MDB.MDBParameter("LocMau_TTG", ketQua.LocMau_TTG));
                Command.Parameters.Add(new MDB.MDBParameter("ThuocVanMach", ketQua.ThuocVanMach));
                Command.Parameters.Add(new MDB.MDBParameter("NhapICU", ketQua.NhapICU));
                Command.Parameters.Add(new MDB.MDBParameter("NhapICU_TTG", ketQua.NhapICU_TTG));
                Command.Parameters.Add(new MDB.MDBParameter("XetNghiemRT_PCR", ketQua.XetNghiemRT_PCR));
                Command.Parameters.Add(new MDB.MDBParameter("ViKhuan", ketQua.ViKhuan));
                Command.Parameters.Add(new MDB.MDBParameter("ViKhuan_DinhDanh", ketQua.ViKhuan_DinhDanh));
                Command.Parameters.Add(new MDB.MDBParameter("CacMamBenhKhac", ketQua.CacMamBenhKhac));
                Command.Parameters.Add(new MDB.MDBParameter("CacMamBenhKhac_DinhDanh", ketQua.CacMamBenhKhac_DinhDanh));
                Command.Parameters.Add(new MDB.MDBParameter("BVPDCDTLS", ketQua.BVPDCDTLS));
                Command.Parameters.Add(new MDB.MDBParameter("ChupXQuangPhoi", ketQua.ChupXQuangPhoi));
                Command.Parameters.Add(new MDB.MDBParameter("ChupXQuangPhoi_CoThamNhiem", ketQua.ChupXQuangPhoi_CoThamNhiem));
                Command.Parameters.Add(new MDB.MDBParameter("ChupCTNguc", ketQua.ChupCTNguc));
                Command.Parameters.Add(new MDB.MDBParameter("ChupCTNguc_CoThamNhiem", ketQua.ChupCTNguc_CoThamNhiem));
                Command.Parameters.Add(new MDB.MDBParameter("Molnupiravir", ketQua.Molnupiravir));
                Command.Parameters.Add(new MDB.MDBParameter("Molnupiravir_NgayBatDau", ketQua.Molnupiravir_NgayBatDau));
                Command.Parameters.Add(new MDB.MDBParameter("Molnupiravir_ThoiGian", ketQua.Molnupiravir_ThoiGian));
                Command.Parameters.Add(new MDB.MDBParameter("Ribavirin", ketQua.Ribavirin));
                Command.Parameters.Add(new MDB.MDBParameter("Ribavirin_NgayBatDau", ketQua.Ribavirin_NgayBatDau));
                Command.Parameters.Add(new MDB.MDBParameter("Ribavirin_ThoiGian", ketQua.Ribavirin_ThoiGian));
                Command.Parameters.Add(new MDB.MDBParameter("Lopinavir", ketQua.Lopinavir));
                Command.Parameters.Add(new MDB.MDBParameter("Lopinavir_NgayBatDau", ketQua.Lopinavir_NgayBatDau));
                Command.Parameters.Add(new MDB.MDBParameter("Lopinavir_ThoiGian", ketQua.Lopinavir_ThoiGian));
                Command.Parameters.Add(new MDB.MDBParameter("Remdesivir", ketQua.Remdesivir));
                Command.Parameters.Add(new MDB.MDBParameter("Remdesivir_NgayBatDau", ketQua.Remdesivir_NgayBatDau));
                Command.Parameters.Add(new MDB.MDBParameter("Remdesivir_ThoiGian", ketQua.Remdesivir_ThoiGian));
                Command.Parameters.Add(new MDB.MDBParameter("Interferon_alpha", ketQua.Interferon_alpha));
                Command.Parameters.Add(new MDB.MDBParameter("Interferon_alpha_NgayBatDau", ketQua.Interferon_alpha_NgayBatDau));
                Command.Parameters.Add(new MDB.MDBParameter("Interferon_alpha_ThoiGian", ketQua.Interferon_alpha_ThoiGian));
                Command.Parameters.Add(new MDB.MDBParameter("Interferon_beta", ketQua.Interferon_beta));
                Command.Parameters.Add(new MDB.MDBParameter("Interferon_beta_NgayBatDau", ketQua.Interferon_beta_NgayBatDau));
                Command.Parameters.Add(new MDB.MDBParameter("Interferon_beta_ThoiGian", ketQua.Interferon_beta_ThoiGian));
                Command.Parameters.Add(new MDB.MDBParameter("Khang_Interleukin", ketQua.Khang_Interleukin));
                Command.Parameters.Add(new MDB.MDBParameter("Tocilizumab", ketQua.Tocilizumab));
                Command.Parameters.Add(new MDB.MDBParameter("Sarilumab", ketQua.Sarilumab));
                Command.Parameters.Add(new MDB.MDBParameter("Khang_Interleukin_Khac", ketQua.Khang_Interleukin_Khac));
                Command.Parameters.Add(new MDB.MDBParameter("Khang_Interleukin_NgayBatDau", ketQua.Khang_Interleukin_NgayBatDau));
                Command.Parameters.Add(new MDB.MDBParameter("Khang_Interleukin_ThoiGian", ketQua.Khang_Interleukin_ThoiGian));
                Command.Parameters.Add(new MDB.MDBParameter("TruyenHuyetTuong", ketQua.TruyenHuyetTuong));
                Command.Parameters.Add(new MDB.MDBParameter("TruyenHuyetTuong_NgayBatDau", ketQua.TruyenHuyetTuong_NgayBatDau));
                Command.Parameters.Add(new MDB.MDBParameter("TruyenHuyetTuong_ThoiGian", ketQua.TruyenHuyetTuong_ThoiGian));
                Command.Parameters.Add(new MDB.MDBParameter("ThuocKhang_Khac", ketQua.ThuocKhang_Khac));
                Command.Parameters.Add(new MDB.MDBParameter("ThuocKhang_Khac_Text", ketQua.ThuocKhang_Khac_Text));
                Command.Parameters.Add(new MDB.MDBParameter("ThuocKhang_Khac_NgayBatDau", ketQua.ThuocKhang_Khac_NgayBatDau));
                Command.Parameters.Add(new MDB.MDBParameter("ThuocKhang_Khac_ThoiGian", ketQua.ThuocKhang_Khac_ThoiGian));
                Command.Parameters.Add(new MDB.MDBParameter("Beta_lactam", ketQua.Beta_lactam));
                Command.Parameters.Add(new MDB.MDBParameter("Beta_lactam_NgayBatDau", ketQua.Beta_lactam_NgayBatDau));
                Command.Parameters.Add(new MDB.MDBParameter("Beta_lactam_ThoiGian", ketQua.Beta_lactam_ThoiGian));
                Command.Parameters.Add(new MDB.MDBParameter("Aminoglycosid", ketQua.Aminoglycosid));
                Command.Parameters.Add(new MDB.MDBParameter("Aminoglycosid_NgayBatDau", ketQua.Aminoglycosid_NgayBatDau));
                Command.Parameters.Add(new MDB.MDBParameter("Aminoglycosid_ThoiGian", ketQua.Aminoglycosid_ThoiGian));
                Command.Parameters.Add(new MDB.MDBParameter("Macrolid", ketQua.Macrolid));
                Command.Parameters.Add(new MDB.MDBParameter("Macrolid_NgayBatDau", ketQua.Macrolid_NgayBatDau));
                Command.Parameters.Add(new MDB.MDBParameter("Macrolid_ThoiGian", ketQua.Macrolid_ThoiGian));
                Command.Parameters.Add(new MDB.MDBParameter("Lincosamid", ketQua.Lincosamid));
                Command.Parameters.Add(new MDB.MDBParameter("Lincosamid_NgayBatDau", ketQua.Lincosamid_NgayBatDau));
                Command.Parameters.Add(new MDB.MDBParameter("Lincosamid_ThoiGian", ketQua.Lincosamid_ThoiGian));
                Command.Parameters.Add(new MDB.MDBParameter("Phenicol", ketQua.Phenicol));
                Command.Parameters.Add(new MDB.MDBParameter("Phenicol_NgayBatDau", ketQua.Phenicol_NgayBatDau));
                Command.Parameters.Add(new MDB.MDBParameter("Phenicol_ThoiGian", ketQua.Phenicol_ThoiGian));
                Command.Parameters.Add(new MDB.MDBParameter("Tetracyclin", ketQua.Tetracyclin));
                Command.Parameters.Add(new MDB.MDBParameter("Tetracyclin_NgayBatDau", ketQua.Tetracyclin_NgayBatDau));
                Command.Parameters.Add(new MDB.MDBParameter("Tetracyclin_ThoiGian", ketQua.Tetracyclin_ThoiGian));
                Command.Parameters.Add(new MDB.MDBParameter("Peptid", ketQua.Peptid));
                Command.Parameters.Add(new MDB.MDBParameter("Peptid_NgayBatDau", ketQua.Peptid_NgayBatDau));
                Command.Parameters.Add(new MDB.MDBParameter("Peptid_ThoiGian", ketQua.Peptid_ThoiGian));
                Command.Parameters.Add(new MDB.MDBParameter("Quinolon", ketQua.Quinolon));
                Command.Parameters.Add(new MDB.MDBParameter("Quinolon_NgayBatDau", ketQua.Quinolon_NgayBatDau));
                Command.Parameters.Add(new MDB.MDBParameter("Quinolon_ThoiGian", ketQua.Quinolon_ThoiGian));
                Command.Parameters.Add(new MDB.MDBParameter("KhangSinhKhac", ketQua.KhangSinhKhac));
                Command.Parameters.Add(new MDB.MDBParameter("KhangSinhKhac_Text", ketQua.KhangSinhKhac_Text));
                Command.Parameters.Add(new MDB.MDBParameter("KhangSinhKhac_NgayBatDau", ketQua.KhangSinhKhac_NgayBatDau));
                Command.Parameters.Add(new MDB.MDBParameter("KhangSinhKhac_ThoiGian", ketQua.KhangSinhKhac_ThoiGian));
                Command.Parameters.Add(new MDB.MDBParameter("CORTICOSTEROID", ketQua.CORTICOSTEROID));
                Command.Parameters.Add(new MDB.MDBParameter("Prednisolone", ketQua.Prednisolone));
                Command.Parameters.Add(new MDB.MDBParameter("Hydrocortisone", ketQua.Hydrocortisone));
                Command.Parameters.Add(new MDB.MDBParameter("Methylprednisolone", ketQua.Methylprednisolone));
                Command.Parameters.Add(new MDB.MDBParameter("CORTICOSTEROID_Khac", ketQua.CORTICOSTEROID_Khac));
                Command.Parameters.Add(new MDB.MDBParameter("CORTICOSTEROID_Khac_Text", ketQua.CORTICOSTEROID_Khac_Text));
                Command.Parameters.Add(new MDB.MDBParameter("CORTICOSTEROID_DuongDung", ketQua.CORTICOSTEROID_DuongDung));
                Command.Parameters.Add(new MDB.MDBParameter("ThuocKhangDong", ketQua.ThuocKhangDong));
                Command.Parameters.Add(new MDB.MDBParameter("ThuocKhangDong_Loai", ketQua.ThuocKhangDong_Loai));
                Command.Parameters.Add(new MDB.MDBParameter("ThuocKhangDong_DuongDung", ketQua.ThuocKhangDong_DuongDung));
                Command.Parameters.Add(new MDB.MDBParameter("ChiDinh_DieuTri", ketQua.ChiDinh_DieuTri));
                Command.Parameters.Add(new MDB.MDBParameter("ChiDinh_DuPhongTangCuong", ketQua.ChiDinh_DuPhongTangCuong));
                Command.Parameters.Add(new MDB.MDBParameter("ChiDinh_DuPhongBenhNen", ketQua.ChiDinh_DuPhongBenhNen));
                Command.Parameters.Add(new MDB.MDBParameter("ThuocKhangNam", ketQua.ThuocKhangNam));
                Command.Parameters.Add(new MDB.MDBParameter("ThuocKhangNam_Loai", ketQua.ThuocKhangNam_Loai));
                Command.Parameters.Add(new MDB.MDBParameter("ThuocKhangNam_ThoiGian", ketQua.ThuocKhangNam_ThoiGian));
                Command.Parameters.Add(new MDB.MDBParameter("ViemPhoiRoVirus", ketQua.ViemPhoiRoVirus));
                Command.Parameters.Add(new MDB.MDBParameter("ViemMangNao", ketQua.ViemMangNao));
                Command.Parameters.Add(new MDB.MDBParameter("ViemPhoiDoViKhuan", ketQua.ViemPhoiDoViKhuan));
                Command.Parameters.Add(new MDB.MDBParameter("NhiemTrungHuyet", ketQua.NhiemTrungHuyet));
                Command.Parameters.Add(new MDB.MDBParameter("HCSGHHCT", ketQua.HCSGHHCT));
                Command.Parameters.Add(new MDB.MDBParameter("RLDMDIC", ketQua.RLDMDIC));
                Command.Parameters.Add(new MDB.MDBParameter("TranKhiMangPhoi", ketQua.TranKhiMangPhoi));
                Command.Parameters.Add(new MDB.MDBParameter("ThuyenTacPhoi", ketQua.ThuyenTacPhoi));
                Command.Parameters.Add(new MDB.MDBParameter("TranDichMangPhoi", ketQua.TranDichMangPhoi));
                Command.Parameters.Add(new MDB.MDBParameter("HuyetKhoiTinhMachSau", ketQua.HuyetKhoiTinhMachSau));
                Command.Parameters.Add(new MDB.MDBParameter("NhoiMauCoTim", ketQua.NhoiMauCoTim));
                Command.Parameters.Add(new MDB.MDBParameter("HuyetKhoiTacMachKhac", ketQua.HuyetKhoiTacMachKhac));
                Command.Parameters.Add(new MDB.MDBParameter("RoiLoanNhipTim", ketQua.RoiLoanNhipTim));
                Command.Parameters.Add(new MDB.MDBParameter("ThieuMau", ketQua.ThieuMau));
                Command.Parameters.Add(new MDB.MDBParameter("ViemCoTim", ketQua.ViemCoTim));
                Command.Parameters.Add(new MDB.MDBParameter("TieuCoVan", ketQua.TieuCoVan));
                Command.Parameters.Add(new MDB.MDBParameter("ViemNoiTamMac", ketQua.ViemNoiTamMac));
                Command.Parameters.Add(new MDB.MDBParameter("TonThuongThanCapTinh", ketQua.TonThuongThanCapTinh));
                Command.Parameters.Add(new MDB.MDBParameter("BenhCoTim", ketQua.BenhCoTim));
                Command.Parameters.Add(new MDB.MDBParameter("XuatHuyetDuongTieuHoa", ketQua.XuatHuyetDuongTieuHoa));
                Command.Parameters.Add(new MDB.MDBParameter("SuyTimSungHuyet", ketQua.SuyTimSungHuyet));
                Command.Parameters.Add(new MDB.MDBParameter("ViemTuy", ketQua.ViemTuy));
                Command.Parameters.Add(new MDB.MDBParameter("BienChung_CoGiat", ketQua.BienChung_CoGiat));
                Command.Parameters.Add(new MDB.MDBParameter("RoiLoanChucNangGan", ketQua.RoiLoanChucNangGan));
                Command.Parameters.Add(new MDB.MDBParameter("TaiBienMachMauNao", ketQua.TaiBienMachMauNao));
                Command.Parameters.Add(new MDB.MDBParameter("TangDuongHuyet", ketQua.TangDuongHuyet));
                Command.Parameters.Add(new MDB.MDBParameter("HaDuongHuyet", ketQua.HaDuongHuyet));
                Command.Parameters.Add(new MDB.MDBParameter("BienChung_Khac", ketQua.BienChung_Khac));
                Command.Parameters.Add(new MDB.MDBParameter("BienChung_Khac_Text", ketQua.BienChung_Khac_Text));
                Command.Parameters.Add(new MDB.MDBParameter("XuatVien", ketQua.XuatVien));
                Command.Parameters.Add(new MDB.MDBParameter("ChuyenDiCoSoKhac", ketQua.ChuyenDiCoSoKhac));
                Command.Parameters.Add(new MDB.MDBParameter("TenCoSoChuyenDi", ketQua.TenCoSoChuyenDi));
                Command.Parameters.Add(new MDB.MDBParameter("TuVong", ketQua.TuVong));
                Command.Parameters.Add(new MDB.MDBParameter("XVVTTNK", ketQua.XVVTTNK));
                Command.Parameters.Add(new MDB.MDBParameter("NguyenNhanTuVong", ketQua.NguyenNhanTuVong));
                Command.Parameters.Add(new MDB.MDBParameter("NgayTongKet", ketQua.NgayTongKet));
                Command.Parameters.Add(new MDB.MDBParameter("BacSy", ketQua.BacSy));

                Command.Parameters.Add(new MDB.MDBParameter("NGUOISUA", ketQua.NguoiSua));
                Command.Parameters.Add(new MDB.MDBParameter("NGAYSUA", ketQua.NgaySua));
                if (ketQua.ID == 0)
                {
                    Command.Parameters.Add(new MDB.MDBParameter("ID", ketQua.ID));
                    Command.Parameters.Add(new MDB.MDBParameter("NGUOITAO", ketQua.NguoiTao));
                    Command.Parameters.Add(new MDB.MDBParameter("NGAYTAO", ketQua.NgayTao));
                }
                Command.BindByName = true;
                int n = Command.ExecuteNonQuery();
                if (ketQua.ID == 0)
                {
                    long nextval = Convert.ToInt64((Command.Parameters["ID"] as MDB.MDBParameter).Value);
                    ketQua.ID = nextval;
                }
                return n > 0 ? true : false;
            }
            catch (Exception ex)
            {
                XuLyLoi.Handle(ex);
            }
            return false;
        }
        public static bool delete(MDB.MDBConnection MyConnection, long id)
        {
            try
            {
                string sql = "DELETE FROM BABNDieuTriCovid19NTP WHERE ID = :ID";
                MDB.MDBCommand command = new MDB.MDBCommand(sql, MyConnection);
                command.Parameters.Add(new MDB.MDBParameter("ID", id));
                command.BindByName = true;
                int n = command.ExecuteNonQuery();
                return n > 0 ? true : false;
            }
            catch (Exception ex)
            {
                XuLyLoi.Handle(ex);
            }
            return false;
        }
        public static DataSet getDataSet(MDB.MDBConnection MyConnection, long id)
        {
            string sql = @"SELECT
                P.*, f.hovaten BacSyDieuTriHoVaTen
            FROM
                BABNDieuTriCovid19NTP P
            left join nhanvien f on P.BacSy = f.manhanvien 
            WHERE
                P.ID = " + id;

            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
            MDB.MDBDataAdapter adt = new MDB.MDBDataAdapter(Command);
            var ds = new DataSet();

            adt.Fill(ds, "KQ");

            ds.Tables[0].AddColumn("TenBenhNhan", typeof(string));
            ds.Tables[0].AddColumn("Tuoi", typeof(string));
            ds.Tables[0].AddColumn("NamSinh", typeof(string));
            ds.Tables[0].AddColumn("GioiTinh", typeof(int));
            ds.Tables[0].AddColumn("SOYTE", typeof(string));
            ds.Tables[0].AddColumn("BENHVIEN", typeof(string));
            ds.Tables[0].AddColumn("KHOA", typeof(string));

            ds.Tables[0].Rows[0]["TenBenhNhan"] = XemBenhAn._HanhChinhBenhNhan.TenBenhNhan;
            ds.Tables[0].Rows[0]["Tuoi"] = XemBenhAn._HanhChinhBenhNhan.Tuoi;
            ds.Tables[0].Rows[0]["NamSinh"] = XemBenhAn._HanhChinhBenhNhan.NgaySinh.HasValue ? XemBenhAn._HanhChinhBenhNhan.NgaySinh.Value.Year + "" : "";
            ds.Tables[0].Rows[0]["GioiTinh"] = (int)XemBenhAn._HanhChinhBenhNhan.GioiTinh;
            ds.Tables[0].Rows[0]["SOYTE"] = XemBenhAn._HanhChinhBenhNhan.SoYTe;
            ds.Tables[0].Rows[0]["BENHVIEN"] = XemBenhAn._HanhChinhBenhNhan.BenhVien;
            ds.Tables[0].Rows[0]["KHOA"] = XemBenhAn._ThongTinDieuTri.Khoa;

            return ds;
        }
    }
}
