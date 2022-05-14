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
    public class BenhAnNgoaiTruDuhringBrocq : IBase
    {
        public int IDMauPhieu { get; set; } = (int)DanhMucPhieu.BANTBDB;
        public string TenMauPhieu { get; set; } = DanhMucPhieu.BANTBDB.Description();
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
        //IV. HỎI BỆNH	
        [MoTaDuLieu("1.Thời gian từ khi khởi phát bệnh")]
        public string ThoiGianKhoiPhatBenh { get; set; }
        [MoTaDuLieu("2. Tuổi bắt đầu bị bệnh.")]
        public string TuoiBatDauDieutri { get; set; }
        [MoTaDuLieu("3. Vào viện lần thứ")]
        public string VaoVienLanThuMay { get; set; }
        [MoTaDuLieu("4. Triệu chứng khởi phát đầu tiên")]
        public string TrieuChungKhoiPhat { get; set; }
        [MoTaDuLieu("5. Quá trình bệnh lý ")]
        public string QuaTrinhBenhLy { get; set; }
        [MoTaDuLieu("6. Điều trị trước đây")]
        public string DieuTriTruocDay { get; set; }
        [MoTaDuLieu("7.1.Tiền sử bản thân: Dị ứng thuốc")]
        //V. KHÁM BỆNH
        public string TienSuBanThan_DiUngThuoc { get; set; }
        [MoTaDuLieu("7.1.Tiền sử bản thân: Bệnh khác (nếu có)")]
        public string TienSuBanThan_BenhKhac { get; set; }
        [MoTaDuLieu("7.2.Tiền sử gia đình")]
        public string TienSuGiaDinh_Khac { get; set; }
        [MoTaDuLieu("Toàn thân")]
        public string ToanThan { get; set; }
        [MoTaDuLieu("Các bộ phận")]
        public string CacBoPhan { get; set; }
        [MoTaDuLieu("3. Triệu chứng cơ năng, ngứa")]
        public int Ngua { get; set; }
        [MoTaDuLieu("3. Triệu chứng cơ năng, sut cân")]
        public int SutCan { get; set; }
        [MoTaDuLieu("3. Triệu chứng cơ năng, kém ăn")]
        public int KemAn { get; set; }
        [MoTaDuLieu("3. Triệu chứng cơ năng, mệt")]
        public int Met { get; set; }
        [MoTaDuLieu("3. Triệu chứng cơ năng, đau rát")]
        public int DauRat { get; set; }
        [MoTaDuLieu("3. Triệu chứng cơ năng, khác")]
        public string TrieuChungCoNang_Khac { get; set; }
        // 4. Thương tổn da
        // Bọng nước 
        [MoTaDuLieu("Bọng nước , Nhăn nheo")]
        public int NhanNheo { get; set; }
        [MoTaDuLieu("Bọng nước , căng")]
        public int Cang { get; set; }
        [MoTaDuLieu("Dịch Bọng nước , Dịch xuất huyết")]
        public int DichXuatHuyet { get; set; }
        [MoTaDuLieu("Dịch Bọng nước , Dịch trong")]
        public int DichTrong { get; set; }
        [MoTaDuLieu("Dịch Bọng nước , Dịch mủ")]
        public int DichMu { get; set; }
        [MoTaDuLieu("Nền da bọng nước, Trên nền da lành")]
        public int TrenNenDaLanh { get; set; }
        [MoTaDuLieu("Nền da bọng nước, Trên nền da đỏ")]
        public int TrenNenDaDo { get; set; }
        [MoTaDuLieu("Bọng nước, kích thước")]
        public string BongNuoc_KichThuoc { get; set; }
        [MoTaDuLieu("Bọng nước, số lượng")]
        public string BongNuoc_SoLuong { get; set; }
        //Vết trợt 
        [MoTaDuLieu("Vết trợt, khô đóng vảy")]
        public int KhoDongVay { get; set; }
        [MoTaDuLieu("Vết trợt, ướt")]
        public int Uot { get; set; }
        [MoTaDuLieu("Vết trợt, số lượng")]
        public string VetTrot_SoLuong { get; set; }
        //vảy tiết
        [MoTaDuLieu("Vảy tiết, màu vàng ẩm")]
        public int MauVangAm { get; set; }
        [MoTaDuLieu("Vảy tiết, màu nâu đen")]
        public int MauNauDen { get; set; }
        //sùi
        [MoTaDuLieu("Sùi, có")]
        public int Sui_Co { get; set; }
        [MoTaDuLieu("Vị trí tổn thương")]
        public string ViTriTonThuong { get; set; }
        [MoTaDuLieu("Dấu hiệu Nikolsky")]
        public string DauHieuNikolsky { get; set; }
        [MoTaDuLieu("5. Ghi chú")]
        public string GhiChu { get; set; }
        //VI.CẬN LÂM SÀNG
        //Công thức máu: 
        [MoTaDuLieu("Công thức máu: 1 -> bình thường, 2-> bất thường")]
        public int CongThucMau { get; set; }
        [MoTaDuLieu("Công thức máu")]
        public string CongThucMau_Text { get; set; }
        [MoTaDuLieu("Sinh hóa máu: 1 -> bình thường, 2-> bất thường")]
        public int SinhHoaMau { get; set; }
        [MoTaDuLieu("Sinh hóa máu")]
        public string SinhHoaMau_Text { get; set; }
        [MoTaDuLieu("Tổng phân tích nước tiểu: 1 -> bình thường, 2-> bất thường")]
        public int TongPhanTichNuocTieu { get; set; }
        [MoTaDuLieu("Tổng phân tích nước tiểu")]
        public string TongPhanTichNuocTieu_Text { get; set; }
        [MoTaDuLieu("Xquang ngực: 1 -> bình thường, 2-> bất thường")]
        public int XQuanNguc { get; set; }
        [MoTaDuLieu("Xquang ngực")]
        public string XQuanNguc_Text { get; set; }
        [MoTaDuLieu("Siêu âm ổ bụng: 1 -> bình thường, 2-> bất thường")]
        public int SieuAmOBung { get; set; }
        [MoTaDuLieu("Siêu âm ổ bụng")]
        public string SieuAmOBung_Text { get; set; }
        [MoTaDuLieu("Soi tươi tìm nấm: 1 -> dương tính, 2 -> âm tính")]
        public int SoiTuoiTimNam { get; set; }
        [MoTaDuLieu("Xét nghiệm tế bào Tzanck")]
        public string XetNghiemTeBaoTzanck { get; set; }
        [MoTaDuLieu("Miện dịch huỳnh quang trực tiếp: ")]
        public string MDHuynhQuangTrucTiep { get; set; }
        [MoTaDuLieu("Miện dịch huỳnh quang gián tiếp: ")]
        public string MDHuynhQuangGianTiep { get; set; }
        [MoTaDuLieu("Sinh thiết da")]
        public string SinhThietDa { get; set; }
        [MoTaDuLieu("PCR herpes")]
        public string PCRHerpes { get; set; }
        [MoTaDuLieu("Xét nghiệm khác")]
        public string XetNghiemKhac { get; set; }
        [MoTaDuLieu("VII. CHẨN ĐOÁN")]
        public string ChanDoan { get; set; }
        [MoTaDuLieu("VIII. ĐIỀU TRỊ ")]
        public string DieuTri { get; set; }
        [MoTaDuLieu("Hẹn tái khám")]
        public DateTime? HenTaiKham { get; set; }
        [MoTaDuLieu("Bác sĩ điều trị")]
        public string BacSiDieuTri { get; set; }
        // phần tái khám
        [MoTaDuLieu("Ngày tái khám")]
        public DateTime? TK_NgayTaiKham { get; set; }
        [MoTaDuLieu("Họ tên")]
        public string TK_HoTen { get; set; }
        [MoTaDuLieu("Mạch")]
        public string TK_Mach { get; set; }
        [MoTaDuLieu("BN tự đánh giá so với lần trước")]
        public string TK_BenhNhanTuDanhGia { get; set; }
        [MoTaDuLieu("LÂM SÀNG DA NIÊM MẠC, 1 -> LÂM SÀNG DA NIÊM MẠC, 2-> Tổn thương cũ chưa liền, không có tổn thương mới, 3-> Tổn thương cũ chưa liền, xuất hiện thêm 1 số tổn thương mới, 4->Xuất hiện thêm nhiều tổn thương mới")]
        public int TK_LamSangDaNiemMac { get; set; }
        // phần tái khám, TOÀN THÂN
        [MoTaDuLieu("phần tái khám, thận")] 
        public string TK_Than { get; set; }
        [MoTaDuLieu(" phần tái khám, phổi")]
        public string TK_Phoi { get; set; }
        [MoTaDuLieu("phần tái khám, tiêu hóa")]
        public string TK_TieuHoa { get; set; }
        [MoTaDuLieu("phần tái khám, tim")]
        public string TK_Tim { get; set; }
        [MoTaDuLieu("phần tái khám, thần kinh")]
        public string TK_ThanKinh { get; set; }
        [MoTaDuLieu("phần tái khám, cơ xương khớp")]
        public string TK_CoXuongKhop { get; set; }
        [MoTaDuLieu("phần tái khám, các cơ quan khác")]
        public string TK_CacCoQuanKhac { get; set; }
        [MoTaDuLieu("CẬN LÂM SÀNG")]
        public string TK_CanLamSang { get; set; }
        [MoTaDuLieu("TÁC DỤNG PHỤ CỦA THUỐC ")]
        public string TK_TacDungPhuCuaThuoc { get; set; }

        [MoTaDuLieu("THƯỚNG ĐIỀU TRỊ TIẾP THEO")]
        public string TK_HuongDieuTriTiepTheo { get; set; }
        [MoTaDuLieu("Hẹn tái khám")]
        public DateTime? TK_HenTaiKham { get; set; }
        [MoTaDuLieu("Bác sĩ điều trị")]
        public string TK_BacSiDieuTri { get; set; }

        // Phần tổng kết
        [MoTaDuLieu("1. Quá trình bệnh lý và diễn biến lâm sàng")]
        public string TongKet_QuaTrinhBenhLy { get; set; }
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
