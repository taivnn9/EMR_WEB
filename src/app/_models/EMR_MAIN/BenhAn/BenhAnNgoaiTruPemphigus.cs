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
    public class BenhAnNgoaiTruPemphigus : IBase
    {
        public int IDMauPhieu { get; set; } = (int)DanhMucPhieu.BADTNTBP;
        public string TenMauPhieu { get; set; } = DanhMucPhieu.BADTNTBP.Description();
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
        public string KhoiPhatBenh { get; set; }
        [MoTaDuLieu("2.Tuổi bắt đầu bị bệnh")]
        public string TuoiBatDauBiBenh { get; set; }
        [MoTaDuLieu("3. Vào viện lần thứ")]
        public string VaoVienLanThu { get; set; }
        [MoTaDuLieu("4. Triệu chứng khởi phát đầu tiên")]
        public string TrieuChungKhoiPhatDauTien { get; set; }
        [MoTaDuLieu("5.Quá trình bệnh lý")]
        public string QuaTrinhBenhLy { get; set; }
        [MoTaDuLieu("6.Điều trị trước đây")]
        public string DieuTriTruocDay { get; set; }
        [MoTaDuLieu("Dị ứng thuốc")]
        public string DiUngThuoc { get; set; }
        [MoTaDuLieu("Bệnh khác (nếu có)")]
        public string TSBT_BenhKhac { get; set; }
        [MoTaDuLieu("Tiền sử gia đình, khác")]
        public string TSGD_BenhKhac { get; set; }
        [MoTaDuLieu("1. Toàn thân")]
        public string KhamBenh_ToanThan { get; set; }
        //2.Các bộ phận
        [MoTaDuLieu("2.Các bộ phận")]
        public string KhamBenh_CacBoPhan { get; set; }
        // 3. Triệu chứng cơ năng
        [MoTaDuLieu("Ngứa")]
        public int Ngua { get; set; }
        [MoTaDuLieu("Sút cân")]
        public int SutCan { get; set; }
        [MoTaDuLieu("Kém ăn")]
        public int KemAn { get; set; }
        [MoTaDuLieu("Mệt")]
        public int Met { get; set; }
        [MoTaDuLieu("Đau rát")]
        public int DauRat { get; set; }
        [MoTaDuLieu("Các dấu hiệu khác")]
        public string TrieuChungCoNang_Khac { get; set; }
        //4. Thương tổn da
        // Bọng nước
        [MoTaDuLieu("Bọng nước, Nhăn nheo")]
        public int BongNuoc_NhanNheo { get; set; }
        [MoTaDuLieu("Bọng nước, Nhăn nheo")]
        public int BongNuoc_Cang { get; set; }
        [MoTaDuLieu("Bọng nước, Dịch bong nước")]
        public int BongNuoc_DichBongNuoc { get; set; }
        [MoTaDuLieu("Bọng nước, Dịch xuất huyết")]
        public int BongNuoc_DichXuatHuyet { get; set; }
        [MoTaDuLieu("Bọng nước, Dịch trong")]
        public int BongNuoc_DichTrong { get; set; }
        [MoTaDuLieu("Bọng nước, Dịch mủ")]
        public int BongNuoc_DichMu { get; set; }
        [MoTaDuLieu("Bọng nước, Nền da bọng nước")]
        public int BongNuoc_NenDaBongNuoc { get; set; }
        [MoTaDuLieu("Bọng nước, Trên nền da lành")]
        public int BongNuoc_TrenNenDaLanh { get; set; }
        [MoTaDuLieu("Bọng nước, Trên nền da đỏ")]
        public int BongNuoc_TrenNenDaDo { get; set; }
        [MoTaDuLieu("Bọng nước, Kích thước")]
        public string BongNuoc_KichThuoc { get; set; }
        [MoTaDuLieu("Bọng nước, Số lượng")]
        public string BongNuoc_SoLuong { get; set; }
        [MoTaDuLieu("Vết trợt, 1 -> khô, đóng vảy, 2 -> ướt")]
        public int VetTrot { get; set; }
        [MoTaDuLieu("Vết trợt, Số lượng")]
        public string VetTrot_SoLuong { get; set; }
        [MoTaDuLieu("Vảy tiết, 1 -> Màu vàng ẩm, 2 -> Màu nâu,đen")]
        public int VayTiet { get; set; }
        [MoTaDuLieu("Sùi, 1 -> Màu vàng ẩm")]
        public int Sui { get; set; }
        [MoTaDuLieu("Vị trí tổn thương")]
        public string ViTriTonThuong { get; set; }
        [MoTaDuLieu("Dấu hiệu Nikolsky")]
        public string DauHieuNikolsky { get; set; }
        [MoTaDuLieu("Tổng điểm Absis")]
        public string TongDiemAbsis { get; set; }
        [MoTaDuLieu("Tổng điểm PVAS")]
        public string TongDiemPVAS { get; set; }

        [MoTaDuLieu("Điểm đánh giá chất lượng cuộc sống")]
        public string DiemDanhGiaChatLuongCuocSong { get; set; }
        [MoTaDuLieu("Ghi chú")]
        public string GhiChu { get; set; }
        //VI. Cận lâm sàng
        [MoTaDuLieu("Công thức máu, 1 -> bình thương, 2 -> bất thường")]
        public int CongThucMau { get; set; }
        [MoTaDuLieu("Công thức máu, bất thường")]
        public string CongThucMau_Text { get; set; }
        [MoTaDuLieu("Sinh hóa máu, 1 -> bình thương, 2 -> bất thường")]
        public int SinhHoaMau { get; set; }
        [MoTaDuLieu("Sinh hóa máu, bất thường")]
        public string SinhHoaMau_Text { get; set; }
        [MoTaDuLieu("Tổng phân tích nước tiểu, 1 -> bình thương, 2 -> bất thường")]
        public int TongPhanTichNuocTieu { get; set; }
        [MoTaDuLieu("Tổng phân tích nước tiểu, bất thường")]
        public string TongPhanTichNuocTieu_Text { get; set; }
        [MoTaDuLieu("Xquang ngực, 1 -> bình thương, 2 -> bất thường")]
        public int XquangNguc { get; set; }
        [MoTaDuLieu("Xquang ngực, bất thường")]
        public string XquangNguc_Text { get; set; }
        [MoTaDuLieu("Siêu âm ổ bụng, 1 -> bình thương, 2 -> bất thường")]
        public int SieuAmOBung { get; set; }
        [MoTaDuLieu("Siêu âm ổ bụng, bất thường")]
        public string SieuAmOBung_Text { get; set; }
        [MoTaDuLieu("Soi tươi tìm nấm, 1 -> bình thương, 2 -> bất thường")]
        public int SoiTuoiTimNam { get; set; }
        [MoTaDuLieu("Xét nghiệm tế bào Tzanck")]
        public string XetNghiemTeBaoTzanck { get; set; }
        [MoTaDuLieu("Miện dịch huỳnh quang trực tiếp")]
        public string MienDichHuynhQuangTrucTiep { get; set; }
        [MoTaDuLieu("Miện dịch huỳnh quang gián tiếp")]
        public string MienDichHuynhQuangGianTiep { get; set; }
        [MoTaDuLieu("Sinh thiết da")]
        public string SinhThietDa { get; set; }
        [MoTaDuLieu("Xét nghiệm khác")]
        public string XetNghiemKhac { get; set; }
        [MoTaDuLieu("Pemphigus thông thường")]
        public int PemphigusThongThuong { get; set; }
        [MoTaDuLieu("Pemphigus sùi")]
        public int PemphigusSui { get; set; }
        [MoTaDuLieu("Pemphigus vảy lá")]
        public int PemphigusVayLa { get; set; }
        [MoTaDuLieu("Pemphigus da mỡ")]
        public int PemphigusDaMo { get; set; }
        [MoTaDuLieu("Pemphigus gia đình")]
        public int PemphigusGiaDinh { get; set; }
        [MoTaDuLieu("Pemphigus á u")]
        public int PemphigusAU { get; set; }
        [MoTaDuLieu("Pemphigus do thuốc")]
        public int PemphigusDoThuoc { get; set; }
        [MoTaDuLieu("VIII. ĐIỀU TRỊ")]
        public string DieuTri { get; set; }
        [MoTaDuLieu("Hẹn khám lại ngày")]
        public DateTime? HenKhamLai { get; set; }
        [MoTaDuLieu("Bác sỹ điều trị")]
        public string BacSyDieuTri { get; set; }
        // phần khám bệnh
        [MoTaDuLieu("Họ và tên")]
        public string TK_HoTen { get; set; }
        [MoTaDuLieu("Ngày tái khám")]
        public DateTime? TK_Ngay { get; set; }
        [MoTaDuLieu("Mạch")]
        public string Mach { get; set; }
        [MoTaDuLieu("BN tự đánh giá so với lần trước")]
        public string BenhNhanTuDanhGia { get; set; }
        [MoTaDuLieu("LÂM SÀNG DA NIÊM MẠC")]
        public int LamSangDaNiemMac { get; set; }
        [MoTaDuLieu("Toàn thân, thận")]
        public string ToanThan_Than { get; set; }
        [MoTaDuLieu("Toàn thân, phổi")]
        public string ToanThan_Phoi { get; set; }
        [MoTaDuLieu("Toàn thân, Tiêu hóa")]
        public string ToanThan_TieuHoa { get; set; }
        [MoTaDuLieu("Toàn thân, tim")]
        public string ToanThan_Tim { get; set; }
        [MoTaDuLieu("Toàn thân, thần kinh")]
        public string ToanThan_ThanKinh { get; set; }
        [MoTaDuLieu("Toàn thân, cơ xương khớp")]
        public string ToanThan_CoXuongKhop { get; set; }
        [MoTaDuLieu("Toàn thân, Cơ quan khác")]
        public string ToanThan_CoQuanKhac { get; set; }
        [MoTaDuLieu("Cận lâm sàng")]
        public string CanLamSang { get; set; }
        [MoTaDuLieu("TÁC DỤNG PHỤ CỦA THUỐC")]
        public string TacDungPhuCuaThuoc { get; set; }
        public string HuongDieuTriTiepTheo { get; set; }
        [MoTaDuLieu("Ngày hẹn tái khám")]
        public DateTime? TK_HenKhamLai { get; set; }
        [MoTaDuLieu("Bác sỹ điều trị tái khám")]
        public string TK_BacSyDieuTri { get; set; }
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
