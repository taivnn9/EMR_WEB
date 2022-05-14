using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EMR.KyDienTu;
using PMS.Access;
using System;

namespace EMR_MAIN.DATABASE.BenhAn
{
    public class BenhAnVayNenTheKhop : IBase
    {
        public int IDMauPhieu { get; set; } = (int)DanhMucPhieu.BADTNTVNTK;
        public string TenMauPhieu { get; set; } = DanhMucPhieu.BADTNTVNTK.Description();
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
        // 1. BỆNH SỬ - TIỀN SỬ
        // 1.1. Tiền sử bản thân:
        // a. Bệnh vảy nến:
        [MoTaDuLieu("Thời gian khởi phát")]
        public string ThoiGianKhoiPhat { get; set; }
        [MoTaDuLieu("Vị trí khởi phát")]
        public string ViTriKhoiPhat { get; set; }
        [MoTaDuLieu("Triệu chứng đầu tiên")]
        public string TrieuChungDauTien { get; set; }
        [MoTaDuLieu("Số lần trong 1 năm qua bệnh nhân nhập viện ")]
        public string NhapVienLan { get; set; }
        [MoTaDuLieu("Mùa nào cảm thấy bệnh nặng hơn? xuân")]
        public int BenhVayNen_Xuan { get; set; }
        [MoTaDuLieu("Mùa nào cảm thấy bệnh nặng hơn? hạ")]
        public int BenhVayNen_Ha { get; set; }
        [MoTaDuLieu("Mùa nào cảm thấy bệnh nặng hơn? thu")]
        public int BenhVayNen_Thu { get; set; }
        [MoTaDuLieu("Mùa nào cảm thấy bệnh nặng hơn? đông")]
        public int BenhVayNen_Dong { get; set; }
        [MoTaDuLieu("Quá trình điều trị từ trước đến nay:")]
        public string QuaTrinhDieuTri { get; set; }
        [MoTaDuLieu("b. Bệnh khác:")]
        public string BenhKhac { get; set; }
        [MoTaDuLieu("c. Thói quen cá nhân( Nghiện rượu, hút thuốc,…)")]
        public string ThoiQuenCaNhan { get; set; }
        [MoTaDuLieu("d. Yếu tố tinh thần khi khởi phát bệnh (căng thẳng, lo âu, mất ngủ)")]
        public string YeuToTinhThan { get; set; }
        //1.2. Tiền sử gia đình:
        [MoTaDuLieu("Tiền sử gia đình có người mắc bệnh vảy nến:  1 -> có, 2 -> không, 3 -> không biết")]
        public int TienSuGiaDinhMacVN { get; set; }
        [MoTaDuLieu("Tiền sử gia đình có người mắc bệnh vảy nến:  số người")]
        public string TienSuGiaDinhMacVN_Co { get; set; }
        [MoTaDuLieu("Mùa nào cảm thấy bệnh nặng hơn? xuân")]
        public int TienSuGiaDinh_Xuan { get; set; }
        [MoTaDuLieu("Mùa nào cảm thấy bệnh nặng hơn? hạ")]
        public int TienSuGiaDinh_Ha { get; set; }
        [MoTaDuLieu("Mùa nào cảm thấy bệnh nặng hơn? thu")]
        public int TienSuGiaDinh_Thu { get; set; }
        [MoTaDuLieu("Mùa nào cảm thấy bệnh nặng hơn? đông")]
        public int TienSuGiaDinh_Dong { get; set; }
        [MoTaDuLieu("Bảng câu hỏi tầm soát viêm khớp vảy nến (PEST), Bạn có bao giờ bị sưng một hoặc nhiều khớp")]
        public int PEST_1 { get; set; }
        [MoTaDuLieu("Bảng câu hỏi tầm soát viêm khớp vảy nến (PEST), Bác sĩ có nói cho bạn biết là bạn bị viêm khớp")]
        public int PEST_2 { get; set; }
        [MoTaDuLieu("Bảng câu hỏi tầm soát viêm khớp vảy nến (PEST), Móng tay hoặc móng chân bạn có lỗ hoặc bị rỗ móng")]
        public int PEST_3 { get; set; }
        [MoTaDuLieu("Bảng câu hỏi tầm soát viêm khớp vảy nến (PEST), Bạn có bị đau gót chân")]
        public int PEST_4 { get; set; }
        [MoTaDuLieu("Bảng câu hỏi tầm soát viêm khớp vảy nến (PEST), Ngón tay hoặc ngón chân bạn có lúc nào bị sung và đau mà không có lý do rõ ràng")]
        public int PEST_5 { get; set; }
        // 2. SÀNG LỌC CÁC BỆNH ĐỒNG MẮC VÀ HƯỚNG DẪN XỬ TRÍ:
        [MoTaDuLieu("Nguy cơ mắc các bệnh đồng mắc, 1-> Nguy cơ cao, 2 -> Có yếu tố nguy cơ")]
        public int NguyCoMacBenhDongMac { get; set; }
        // 3. TOÀN TRẠNG	
        [MoTaDuLieu("Nhiệt độ")]
        public string NhietDo { get; set; }
        [MoTaDuLieu("Mạch")]
        public string Mach { get; set; }
        [MoTaDuLieu("HA")]
        public string HA { get; set; }
        [MoTaDuLieu("Cân")]
        public string Can { get; set; }
        [MoTaDuLieu("Cao")]
        public string Cao { get; set; }
        [MoTaDuLieu("Triệu chứng cơ năng")]
        public string TrieuChungCoNang { get; set; }
        //4. TỔN THƯƠNG DA
        [MoTaDuLieu("4. TỔN THƯƠNG DA")]
        public int TonThuongDa { get; set; }
        [MoTaDuLieu("4. TỔN THƯƠNG DA, biểu hiện")]
        public string TonThuongDa_BieuHien { get; set; }
        [MoTaDuLieu("4. TỔN THƯƠNG DA, Tổng PASI")]
        public string TonThuongDa_TongDiemPASI { get; set; }
        //5. BIỂU HIỆN MÓNG
        [MoTaDuLieu("BIỂU HIỆN MÓNG")]
        public int BieuHienMong { get; set; }
        [MoTaDuLieu("BIỂU HIỆN MÓNG, Biểu hiện")]
        public string BieuHienMong_BieuHien { get; set; }
        [MoTaDuLieu("BIỂU HIỆN MÓNG, Tổng NAPSI")]
        public string BieuHienMong_TongDiemPASI { get; set; }
        //5. BIỂU HIỆN KHỚP
        [MoTaDuLieu("Số khớp đau:")]
        public string SoKhopDau { get; set; }
        [MoTaDuLieu("Số khớp sưng:")]
        public string SoKhopSung { get; set; }
        [MoTaDuLieu("DAS28:")]
        public string DAS28 { get; set; }
        [MoTaDuLieu("Viêm một khớp")]
        public int ViemMotKhop { get; set; }
        [MoTaDuLieu("Viêm khớp cột sống")]
        public int ViemKhopCotSong { get; set; }
        [MoTaDuLieu("Viêm đa khớpLoại biến dạng")]
        public int ViemDaKhopLoaiBienDang { get; set; }
        [MoTaDuLieu("Biến dạng khớp, 1-> có, 2-> không")]
        public int BienDangKhop { get; set; }
        [MoTaDuLieu("Loại biến dạng")]
        public string LoaiBienDang { get; set; }
        [MoTaDuLieu("6. BIỂU HIỆN NIÊM MẠC, 1-> có, 2-> không")]
        public int BieuHienNiemMac { get; set; }
        [MoTaDuLieu("6. BIỂU HIỆN NIÊM MẠC, vị trí")]
        public string BieuHienNiemMac_ViTri { get; set; }
        //7. Các biểu hiện lâm sàng khác:
        [MoTaDuLieu("Tim mạch")]
        public string TimMach { get; set; }
        [MoTaDuLieu("Hô hấp")]
        public string HoHap { get; set; }
        [MoTaDuLieu("Tiêu hóa")]
        public string TieuHoa { get; set; }
        [MoTaDuLieu("Tâm thần")]
        public string TamThan { get; set; }
        //8. ĐIỂM DLQI (Dermatology Life Quality Index)
        [MoTaDuLieu("8. ĐIỂM DLQI (Dermatology Life Quality Index)")]
        public string DiemDLQI { get; set; }
        //9. Ghi chú
        [MoTaDuLieu("9. Ghi chú")]
        public string GhiChu { get; set; }
        //10. Bộ câu hỏi đánh giá tình trạng sức khỏe（HAQ）dành cho bệnh nhân
        [MoTaDuLieu("10. Bộ câu hỏi đánh giá tình trạng sức khỏe（HAQ）dành cho bệnh nhân")]
        public string Diem_HAQ { get; set; }
        //11. Bác sỹ đánh giá tình trạng hạn chế chức năng khớp
        [MoTaDuLieu("Chức năng khớp")]
        public int ChucNangKhop { get; set; }
        [MoTaDuLieu("Mức độ triệu chứng của các khớp bị ảnh hưởng")]
        public int MucDoTrieuChung { get; set; }
        //12. Tiêu chuẩn viêm khớp vảy nến CASPAR 2015
        [MoTaDuLieu("12. Tiêu chuẩn viêm khớp vảy nến CASPAR 2015")]
        public string TieuChuanViemKhop_Diem { get; set; }
        //13. Điều trị (Ghi rõ phương pháp điều trị và thuốc điều trị của lần khám)
        [MoTaDuLieu("13. Điều trị (Ghi rõ phương pháp điều trị và thuốc điều trị của lần khám)")]
        public string DieuTri_CuThe { get; set; }
        [MoTaDuLieu("Hẹn khám lại")]
        public DateTime? HenKhamLai { get; set; }
        [MoTaDuLieu("Bác sĩ khám bệnh")]
        public string BacSiKhamBenh { get; set; }
        // TÁI KHÁM BỆNH VẢY NẾN THỂ KHỚP
        [MoTaDuLieu("Họ tên ")]
        public string TK_HoTen { get; set; }
        [MoTaDuLieu("Số bệnh án điện tử ")]
        public string TK_SoBenhAnDienTu { get; set; }
        [MoTaDuLieu("Ngày tái khám")]
        public DateTime? TK_Ngay { get; set; }
        [MoTaDuLieu("Số lưu trữ ")]
        public string TK_SoLuuTru { get; set; }
        // I. TOÀN TRẠNG	
        [MoTaDuLieu("Nhiệt độ")]
        public string TK_NhietDo { get; set; }
        [MoTaDuLieu("Mạch")]
        public string TK_Mach { get; set; }
        [MoTaDuLieu("HA")]
        public string TK_HA { get; set; }
        [MoTaDuLieu("Cân")]
        public string TK_Can { get; set; }
        [MoTaDuLieu("Cao")]
        public string TK_Cao { get; set; }
        [MoTaDuLieu("Triệu chứng cơ năng")]
        public string TK_TrieuChungCoNang { get; set; }
        // 2. TIỀN SỬ
        // Từ lần khám trước có thêm bệnh gì không? 
        [MoTaDuLieu("2. TIỀN SỬ")]
        public string TK_TienSu { get; set; }
        [MoTaDuLieu("3.Tổn thương da")]
        public string TK_TonThuongDa { get; set; }
        [MoTaDuLieu("Tổng điểm PASI")]
        public string TK_TongDiemPASI { get; set; }
        public string TK_TonThuongMong { get; set; }
        //5. BIỂU HIỆN KHỚP
        [MoTaDuLieu("Số khớp đau:")]
        public string TK_SoKhopDau { get; set; }
        [MoTaDuLieu("Số khớp sưng:")]
        public string TK_SoKhopSung { get; set; }
        [MoTaDuLieu("DAS28:")]
        public string TK_DAS28 { get; set; }
        [MoTaDuLieu("Viêm một khớp")]
        public int TK_ViemMotKhop { get; set; }
        [MoTaDuLieu("Viêm khớp cột sống")]
        public int TK_ViemKhopCotSong { get; set; }
        [MoTaDuLieu("Viêm đa khớpLoại biến dạng")]
        public int TK_ViemDaKhopLoaiBienDang { get; set; }
        [MoTaDuLieu("Biến dạng khớp, 1-> có, 2-> không")]
        public int TK_BienDangKhop { get; set; }
        [MoTaDuLieu("Loại biến dạng")]
        public string TK_LoaiBienDang { get; set; }
        //7. Bác sỹ đánh giá tình trạng hạn chế chức năng khớp
        [MoTaDuLieu("Chức năng khớp")]
        public int TK_ChucNangKhop { get; set; }
        [MoTaDuLieu("Mức độ triệu chứng của các khớp bị ảnh hưởng")]
        public int TK_MucDoTrieuChung { get; set; }

        [MoTaDuLieu("8. BIỂU HIỆN NIÊM MẠC, 1-> có, 2-> không")]
        public int TK_BieuHienNiemMac { get; set; }
        [MoTaDuLieu("8. BIỂU HIỆN NIÊM MẠC, vị trí")]
        public string TK_BieuHienNiemMac_ViTri { get; set; }
        //9. Các biểu hiện lâm sàng khác:
        [MoTaDuLieu("Tim mạch")]
        public string TK_TimMach { get; set; }
        [MoTaDuLieu("Hô hấp")]
        public string TK_HoHap { get; set; }
        [MoTaDuLieu("Tiêu hóa")]
        public string TK_TieuHoa { get; set; }
        [MoTaDuLieu("Tâm thần")]
        public string TK_TamThan { get; set; }
        [MoTaDuLieu("Lâm sàng khác")]
        public string TK_LamSangKhac { get; set; }
        [MoTaDuLieu("8. Tác dụng phụ của thuốc  ")]
        public string TK_TacDungPhuCuaThuoc { get; set; }
        [MoTaDuLieu("9.  GHI CHÚ: ")]
        public string TK_GhiChu { get; set; }
        [MoTaDuLieu("14. ĐIỀU TRỊ ")]
        public string TK_DieuTri { get; set; }

        [MoTaDuLieu("Hẹn khám lại")]
        public DateTime? TK_HenKhamLai { get; set; }
        [MoTaDuLieu("Bác sĩ khám bệnh")]
        public string TK_BacSiKhamBenh { get; set; }

        // Phần tổng kết
        [MoTaDuLieu("1. Quá trình bệnh lý và diễn biến lâm sàng")]
        public string QuaTrinhBenhLy { get; set; }
        [MoTaDuLieu("2.Tóm tắt kết quả xét nghiệm cận lâm sàng có giá trị chẩn đoán")]
        public string TomTatKetQua { get; set; }
        [MoTaDuLieu("- Bệnh chính:")]
        public string BenhChinh { get; set; }
        [MoTaDuLieu("- Mã Bệnh chính:")]
        public string MaBenhChinh { get; set; }
        [MoTaDuLieu("- Bệnh kèm theo (nếu có):")]
        public string BenhKemTheo { get; set; }
        [MoTaDuLieu("- Mã Bệnh kèm theo (nếu có):")]
        public string MaBenhKemTheo { get; set; }
        [MoTaDuLieu("4. Phương pháp điều trị:")]
        public string PhuongPhapDieuTri { get; set; }
        [MoTaDuLieu("5. Tình trạng người bệnh ra viện:")]
        public string TinhTrangRaVien { get; set; }
        [MoTaDuLieu("6. Hướng điều trị và các chế độ tiếp theo")]
        public string HuongDieuTri { get; set; }
        [MoTaDuLieu("Người nhận hồ sơ")]
        public string NguoiNhanHoSo { get; set; }
        [MoTaDuLieu("Người giao hồ sơ")]
        public string NguoiGiaoHoSo { get; set; }
        [MoTaDuLieu("Ngày tổng kết")]
        public DateTime NgayTongKet { get; set; }
        [MoTaDuLieu("Bác sỹ điều trị")]
        public string TongKet_BacSyDieuTri { get; set; }
        [MoTaDuLieu("Mã Bác sỹ điều trị")]
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
