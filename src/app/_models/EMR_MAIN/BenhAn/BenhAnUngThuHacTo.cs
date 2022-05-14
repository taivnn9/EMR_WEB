using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EMR.KyDienTu;
using PMS.Access;
using System;
using System.Collections.ObjectModel;

namespace EMR_MAIN.DATABASE.BenhAn
{
    public class BenhAnUngThuHacTo : IBase
    {
        public int IDMauPhieu { get; set; } = (int)DanhMucPhieu.BAUTDHT;
        public string TenMauPhieu { get; set; } = DanhMucPhieu.BAUTDHT.Description();
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
        // Hỏi bệnh
        [MoTaDuLieu("1. Thời gian từ khi khởi phát bệnh")]
        public string HB_TGPhatBenh { get; set; }
        [MoTaDuLieu("2. Triệu trứng đầu tiên")]
        public string HB_TrieuTrungDauTien { get; set; }
        [MoTaDuLieu("3. Xuất hiện trên vùng da/niêm mạc: 1-> có, 2 -> không")]
        public int XuatHienTrenVungDa { get; set; }
        [MoTaDuLieu("4. Quá trình bệnh lý")]
        public string HB_QuaTrinhBenhLy { get; set; }
        [MoTaDuLieu("5. Điều trị trước đây")]
        public int DieuTriTruocDay { get; set; }
        [MoTaDuLieu("Phương pháp điều trị")]
        public string HB_PhuongPhapDieuTri { get; set; }
        [MoTaDuLieu("Phương pháp điều trị")]
        public string HB_KetQuaDieuTri { get; set; }
        [MoTaDuLieu("Tiền sử bản thân:")]
        public string TienSuBanThan { get; set; }
        [MoTaDuLieu("Tiền sử bệnh lí nội ngoại khoa khác")]
        public string TienSuBenhLyNoiNgoai { get; set; }
        [MoTaDuLieu("Viêm môi ánh nắng")]
        public int ViemMoiAnhNang { get; set; }
        [MoTaDuLieu("Viêm da ánh nắng")]
        public int ViemDaAnhNang { get; set; }
        [MoTaDuLieu("Viêm da tia xạ")]
        public int ViemDaTiaXa { get; set; }
        [MoTaDuLieu("Dầy sừng ánh nắng")]
        public int DaySungAnhNang { get; set; }
        [MoTaDuLieu("Lupus ban đỏ hệ thống/đĩa/....")]
        public int LupusBanDoHeThong { get; set; }
        [MoTaDuLieu("Lichen phẳng/xơ teo/...")]
        public int LichenPhang { get; set; }
        [MoTaDuLieu("Sẹo bỏng")]
        public int SeoBong { get; set; }
        [MoTaDuLieu("Loét mạn tính")]
        public int LoetManTinh { get; set; }
        [MoTaDuLieu("Nốt ruồi không điển hình/>100 nốt ruồi")]
        public int NotRuoiKhongDienHinh { get; set; }
        [MoTaDuLieu("Bớt không điển hình (nævus atypique)")]
        public int BotKhongDienHinh { get; set; }
        [MoTaDuLieu("Bớt sắc tố bẩm sinh")]
        public int BotSacToBamSinh { get; set; }
        [MoTaDuLieu("Bạch tạng")]
        public int BachTang { get; set; }
        [MoTaDuLieu("Bạch biến")]
        public int BachBien { get; set; }
        [MoTaDuLieu("Khô da sắc tố")]
        public int KhoDaSacTo { get; set; }
        [MoTaDuLieu("Loạn sản thượng bì dạng hạt cơm")]
        public int LoanSanThuongBi { get; set; }
        [MoTaDuLieu("Hội chứng Gorlin (Basal cell neavus syndrome)")]
        public int HoiChungGorlin { get; set; }
        [MoTaDuLieu("Hội chứng Bazex (Acrokeratosis paraneoplastica)")]
        public int HoiChungBazex { get; set; }
        [MoTaDuLieu("Bạch sản")]
        public int BachSan { get; set; }
        [MoTaDuLieu("Tổn thương tiền ung thư")]
        public string TonThuongTienUngThu_Khac { get; set; }
        [MoTaDuLieu("Hoạt động dưới ánh nắng mặt trời")]
        public int HoatDongDuoiAnhNang { get; set; }
        [MoTaDuLieu("Tần suất")]
        public string TanSuat { get; set; }
        [MoTaDuLieu("Thời gian")]
        public string ThoiGian { get; set; }
        [MoTaDuLieu("Thời điểm 10-16h")]
        public int ThoiDiem1016h { get; set; }
        [MoTaDuLieu("Thời điểm khác")]
        public string ThoiDiem_Khac { get; set; }
        [MoTaDuLieu("Biện pháp bảo vệ, 1 -> có, 2 -> không")]
        public int BienPhapBaoVe { get; set; }
        [MoTaDuLieu("Quần áo")]
        public int QuanAo { get; set; }
        [MoTaDuLieu("Kem chống nắng")]
        public int KemChongNang { get; set; }
        [MoTaDuLieu("Phương pháp khác")]
        public int PhuongPhapKhac { get; set; }
        [MoTaDuLieu("Dùng thuốc ƯCMD")]
        public int DungThuocUCMD { get; set; }
        [MoTaDuLieu("Ghép tạng (cụ thể)")]
        public int GhepTangCuThe { get; set; }
        [MoTaDuLieu("Nhiễm HIV/AIDS")]
        public int NhiemHIVAIDS { get; set; }
        [MoTaDuLieu("Suy giảm miễn dịch, khác")]
        public string SuyGiamMienDich_Khac { get; set; }
        [MoTaDuLieu("Có người bị ung thư da")]
        public int CoNguoiBiUngThuDa { get; set; }
        [MoTaDuLieu("Loại ung thư da")]
        public string LoaiUngThuDa { get; set; }
        [MoTaDuLieu("Có người bị ung thư khác")]
        public int CoNguoiBiUngThuKhac { get; set; }
        [MoTaDuLieu("Loại ung thư khác")]
        public string LoaiUngThuKhac { get; set; }
        [MoTaDuLieu("Tiền sử gia đình khác")]
        public string TienSuGiaDinh_Khac { get; set; }
        // khám bệnh
        [MoTaDuLieu("Toàn thân")]
        public string ToanThan { get; set; }
        [MoTaDuLieu("Các bộ phận")]
        public string CacBoPhan { get; set; }
        [MoTaDuLieu("Týp da ")]
        public int TypDa { get; set; }
        [MoTaDuLieu("Thương tổn cơ bản")]
        public string ThuongTonCoBan { get; set; }
        [MoTaDuLieu("Đối xứng (A)")]
        public int DoiXung { get; set; }
        [MoTaDuLieu("Bờ (B)")]
        public int Bo { get; set; }
        [MoTaDuLieu("Màu sắc")]
        public int MauSac { get; set; }
        [MoTaDuLieu("Đường kính")]
        public int DuongKinh { get; set; }
        [MoTaDuLieu("Tiến triển")]
        public int TienTrien { get; set; }
        [MoTaDuLieu("Loét")]
        public int Loet { get; set; }
        [MoTaDuLieu("Ranh giới")]
        public int RanhGioi { get; set; }
        [MoTaDuLieu("Kích thước")]
        public string KichThuoc { get; set; }
        [MoTaDuLieu("Số lượng")]
        public string SoLuong { get; set; }

        [MoTaDuLieu("Hạch, 1-> không sờ thấy, 2 -> sờ thấy")]
        public int Hach { get; set; }
        [MoTaDuLieu("Vị trí, số lượng hạch")]
        public string ViTriSoLuongHach { get; set; }
        [MoTaDuLieu("Bất thường bộ phận khác")]
        public string BatThuongBoPhanKhac { get; set; }
        [MoTaDuLieu("Hc")]
        public string HC { get; set; }
        [MoTaDuLieu("Hb")]
        public string Hb { get; set; }
        [MoTaDuLieu("BC")]
        public string BC { get; set; }
        [MoTaDuLieu("Lympho")]
        public string Lympho { get; set; }
        [MoTaDuLieu("TC")]
        public string TC { get; set; }
        [MoTaDuLieu("Nhóm máu")]
        public string NhomMau { get; set; }
        [MoTaDuLieu("Glucose")]
        public string Glucose { get; set; }
        [MoTaDuLieu("Ure")]
        public string Ure { get; set; }
        [MoTaDuLieu("Creatinin")]
        public string Creatinin { get; set; }
        [MoTaDuLieu("Cholesterol")]
        public string Cholesterol { get; set; }
        [MoTaDuLieu("Triglycerid")]
        public string Triglycerid { get; set; }
        [MoTaDuLieu("HDL-C")]
        public string HDLC { get; set; }
        [MoTaDuLieu("LDL-C")]
        public string LDLC { get; set; }
        [MoTaDuLieu("GOT")]
        public string GOT { get; set; }
        [MoTaDuLieu("GPT")]
        public string GPT { get; set; }
        [MoTaDuLieu("Protein TP")]
        public string ProteinTP { get; set; }
        [MoTaDuLieu("Albumin")]
        public string Albumin { get; set; }
        [MoTaDuLieu("Na+")]
        public string Na { get; set; }
        [MoTaDuLieu("K+")]
        public string K { get; set; }
        [MoTaDuLieu("Cl+")]
        public string Cl { get; set; }
        [MoTaDuLieu("Hình ảnh Dermoscopy")]
        public string HinhAnhDermoscopy { get; set; }
        [MoTaDuLieu("Xquang")]
        public string XQuang { get; set; }
        [MoTaDuLieu("Siêu âm (hạch/ổ bụng)")]
        public string SieuAm { get; set; }
        [MoTaDuLieu("CLVT/CHT")]
        public string CLVT { get; set; }
        [MoTaDuLieu("PET CT")]
        public string PET { get; set; }
        [MoTaDuLieu("Chẩn đoán hình ảnh khác")]
        public string ChanDoanHinhAnh_Khac { get; set; }
        [MoTaDuLieu("Thể mô học")]
        public int TheMoHoc { get; set; }
        [MoTaDuLieu("Độ biệt hóa")]
        public int DoBietHoa { get; set; }
        [MoTaDuLieu("Xâm lấn thần kinh")]
        public int XamLanThanKinh { get; set; }
        [MoTaDuLieu("Xâm lấn mạch máu")]
        public int XamLanMachMau { get; set; }
        [MoTaDuLieu("Chỉ số phân bào")]
        public string ChiSoPhanBao { get; set; }
        [MoTaDuLieu("Chỉ số Breslow")]
        public string ChiSoBreslow { get; set; }
        [MoTaDuLieu("Chỉ số Clark")]
        public string ChiSoClark { get; set; }
        [MoTaDuLieu("Loét vi thể")]
        public int LoetViThe { get; set; }
        [MoTaDuLieu("Tổn thương vệ tinh")]
        public int TonThuongVeTinh { get; set; }
        [MoTaDuLieu("S 100")]
        public int S100 { get; set; }
        [MoTaDuLieu("Ki 67")]
        public int Ki67 { get; set; }
        [MoTaDuLieu("Vimentine")]
        public int Vimentine { get; set; }
        [MoTaDuLieu("HMB 45")]
        public int HMB45 { get; set; }
        [MoTaDuLieu("CD 34")]
        public int CD34 { get; set; }
        [MoTaDuLieu("CK")]
        public int CK { get; set; }
        [MoTaDuLieu("Hóa mô miên dịch khác")]
        public string HoaMoMienDich_Khac { get; set; }
        [MoTaDuLieu("Hạch viêm")]
        public int ChocHutTeBao_HachViem { get; set; }
        [MoTaDuLieu("Hạch di căn")]
        public int ChocHutTeBao_HachDiCan { get; set; }
        [MoTaDuLieu("Chọc hút tế bào hạch, vị trí")]
        public string ChocHutTeBaoHach_ViTri { get; set; }
        [MoTaDuLieu("Sinh thiết hạch, hạch viêm")]
        public int SinhThietHach_HachViem { get; set; }
        [MoTaDuLieu("Sinh thiết hạch, Hạch di căn")]
        public int SinhThietHach_HachDiCan { get; set; }
        [MoTaDuLieu("Sinh thiết hạch, vị trí")]
        public string SinhThietHach_ViTri { get; set; }
        [MoTaDuLieu("Số lượng hạch di căn/Tổng số hạch lấy được")]
        public string SoLuongHachDican { get; set; }
        [MoTaDuLieu("BRAF")]
        public int BRAF { get; set; }
        [MoTaDuLieu("p53")]
        public int p53 { get; set; }
        [MoTaDuLieu("Patched")]
        public int Patched { get; set; }
        [MoTaDuLieu("Gen khác")]
        public string Gen_Khac { get; set; }
        [MoTaDuLieu(" Các xét nghiệm khác")]
        public string CacXetNghiemKhac { get; set; }
        [MoTaDuLieu("Thể nông (SMM)")]
        public int TheNongSMM { get; set; }
        [MoTaDuLieu("Thể của Dubreuih")]
        public int TheCuaDubreuih { get; set; }
        [MoTaDuLieu("Thể đầu cực (ALM : acral lentiginous melanoma)")]
        public int TheDauCuc { get; set; }
        [MoTaDuLieu("Thể U")]
        public int TheU { get; set; }
        [MoTaDuLieu("1. Thể ung thư tế bào hắc tố, khác")]
        public string TheUngThu_Khac { get; set; }
        [MoTaDuLieu("Chỉ số Breslow")]
        public string TheUngThu_ChiSoBreslow { get; set; }
        [MoTaDuLieu("TNM, T")]
        public string TNM_T { get; set; }
        [MoTaDuLieu("TNM, N")]
        public string TNM_N { get; set; }
        [MoTaDuLieu("TNM, M")]
        public string TNM_M { get; set; }
        [MoTaDuLieu("Phân loại giai đoạn bệnh theo hệ thống TNM")]
        public int PhanLoaiGiaiDoan_TNM { get; set; }
        [MoTaDuLieu("Cắt rộng cổ điển")]
        public int CatRongCoDien { get; set; }
        [MoTaDuLieu("Cách bờ thương tổn ")]
        public string CatBoThuongTon { get; set; }
        [MoTaDuLieu("Mosh")]
        public int Mosh { get; set; }
        [MoTaDuLieu("Số lớp cắt Mosh")]
        public string SoLuongCatMosh { get; set; }
        [MoTaDuLieu("Tự liền")]
        public int TuLien { get; set; }
        [MoTaDuLieu("Ghép da")]
        public int GhepDa { get; set; }
        [MoTaDuLieu("Vạt tại chỗ")]
        public int VatTaiCho { get; set; }
        [MoTaDuLieu("Vạt xa")]
        public int VatXa { get; set; }
        [MoTaDuLieu("Vạt tự do")]
        public int VatTuDo { get; set; }
        [MoTaDuLieu("Tạo hình khuyết da, khác")]
        public string TaoHinhKhuyetDa_Khac { get; set; }
        [MoTaDuLieu("Nạo vét hạch, toàn bộ")]
        public int NaoVetHach_ToanBo { get; set; }
        [MoTaDuLieu("Nạo vét hạch, chọn lọc")]
        public int NaoVetHach_ChonLoc { get; set; }
        [MoTaDuLieu("Tia xạ/Hóa chất")]
        public string TiaXaHoaChat { get; set; }
        [MoTaDuLieu("Phương pháp khác")]
        public string DieuTri_PhuongPhapKhac { get; set; }
        [MoTaDuLieu("Phẫu thuật lạnh")]
        public int PhauThuatLanh { get; set; }
        [MoTaDuLieu("Hóa chất tại chỗ")]
        public int HoaChatTaiCho { get; set; }
        [MoTaDuLieu("Tên thuốc")]
        public string TenThuoc { get; set; }
        [MoTaDuLieu("Phá hủy bằng nhiệt (plasma/laserCO2)")]
        public int PhaHuyBangNhiet { get; set; }
        [MoTaDuLieu("Bảng theo dõi điều trị")]

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
        public DateTime? NgayTongKet { get; set; }
        [MoTaDuLieu("Bác sỹ điều trị")]
        public string TongKet_BacSyDieuTri { get; set; }
        [MoTaDuLieu("Mã Bác sỹ điều trị")]
        public string TongKet_MaBacSyDieuTri { get; set; }
        [MoTaDuLieu("Bảng theo dõi điều trị")]
        public ObservableCollection<TheoDoiDieuTri_BAUngThuDaHacTo> TheoDoiDieuTris { get; set; }
        [MoTaDuLieu("Thời gian sống sau điều trị")]
        public int ThoiGianSongSauDieuTri { get; set; }
        [MoTaDuLieu("Chảy máu")]
        public int ChayMau { get; set; }
        [MoTaDuLieu("Tụ máu")]
        public int TuMau { get; set; }
        [MoTaDuLieu("Nhiễm trùng")]
        public int NhiemTrung { get; set; }
        [MoTaDuLieu("Lâu liền vết mổ")]
        public int LauLienVetMo { get; set; }
        [MoTaDuLieu("Sẹo xấu")]
        public int SeoXau { get; set; }
        [MoTaDuLieu("Phù bạch mạch")]
        public int PhuBachMach { get; set; }
        [MoTaDuLieu("Ảnh hưởng chức năng")]
        public int AnhHuongChucNang { get; set; }
        [MoTaDuLieu("2.	Biến chứng xa, khác")]
        public string BienChungXa_Khac { get; set; }
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
    public class TheoDoiDieuTri_BAUngThuDaHacTo
    {
        public string ThoiGian { get; set; }
        public string TaiPhat { get; set; }
        public string SieuAmHach { get; set; }
        public string XQuangNguc { get; set; }
        public string DiCanHach { get; set; }
        public string XnKhac { get; set; }
        public string CDTNM { get; set; }
    }
}
