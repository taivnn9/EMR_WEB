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
    public class BenhAnUngThuKhongHacTo : IBase
    {
        public int IDMauPhieu { get; set; } = (int)DanhMucPhieu.BAUTDKHT;
        public string TenMauPhieu { get; set; } = DanhMucPhieu.BAUTDKHT.Description();
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
        // phần hỏi bệnh
        [MoTaDuLieu("1. Thời gian từ khi khởi phát bệnh")]
        public string HB_TGPhatBenh { get; set; }
        [MoTaDuLieu("2. Triệu trứng đầu tiên")]
        public string HB_TrieuTrungDauTien { get; set; }
        [MoTaDuLieu("3. Xuất hiện trên vùng da/niêm mạc: 1-> lành, 2 -> có thương tổn cũ")]
        public int XuatHienTrenVungDa { get; set; }
        [MoTaDuLieu("4. Quá trình bệnh lý")]
        public string HB_QuaTrinhBenhLy { get; set; }
        [MoTaDuLieu("5. Điều trị trước đây: 1-> có, 2 -> không")]
        public int DieuTriTruocDay { get; set; }
        [MoTaDuLieu("Phương pháp điều trị")]
        public string HB_PhuongPhapDieuTri { get; set; }
        [MoTaDuLieu("Phương pháp điều trị")]
        public string HB_KetQuaDieuTri { get; set; }
        [MoTaDuLieu("Tiền sử bản thân:")]
        public string TienSuBanThan { get; set; }
        [MoTaDuLieu("Tiền sử bệnh lí nội ngoại khoa khác")]
        public string TienSuBenhLyNoiNgoai { get; set; }
        // a. Tiền sử bệnh lí da mạn tính khác:
        [MoTaDuLieu("Tiền sử bệnh lí da mạn tính khác")]
        public string TienSuBenhLyDaManTinh { get; set; }
        //b. Thói quen sinh hoạt
        [MoTaDuLieu("Hút thuốc lá , 1-> có, 2 -> không")]
        public int HutThuocLa { get; set; }
        [MoTaDuLieu("Hút thuốc lá số bao trên năm")]
        public string HutThuocLa_SoBao { get; set; }
        [MoTaDuLieu("Ăn trầu  , 1-> có, 2 -> không")]
        public int AnTrau { get; set; }
        [MoTaDuLieu("Ăn trầu số năm")]
        public string AnTrau_SoNam { get; set; }
        [MoTaDuLieu("Uống rượu , 1-> có, 2 -> không")]
        public int UongRuou { get; set; }
        [MoTaDuLieu("Uống rượu ml/ngày")]
        public string UongRuou_Ml { get; set; }
        [MoTaDuLieu("Thói quen sinh hoạt: khác")]
        public string ThoiQuenSinhHoat_Khac { get; set; }
        //c. Tiền sử tiếp xúc ánh nắng mặt trời 
        [MoTaDuLieu("Tiền sử tiếp xúc ánh nắng mặt trời ")]
        public int TienSuTiepXucMatTroi { get; set; }
        [MoTaDuLieu("Tần suất")]
        public string TanSuat_TiepXucMatTroi { get; set; }
        [MoTaDuLieu("Tần suất")]
        public string ThoiGian_TiepXucMatTroi { get; set; }
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
        //d. Tiền sử tiếp xúc với hắc ín 
        [MoTaDuLieu("Làm in, photo")]
        public int LamInPhoTo { get; set; }
        [MoTaDuLieu("Tiếp xúc nhựa đường")]
        public int TiepXucNhuaDuong { get; set; }
        [MoTaDuLieu("Sử dụng bếp than tổ ong")]
        public int SuDungBepThanToOng { get; set; }
        [MoTaDuLieu("Biện pháp bảo vệ ")]
        public int BienPhapBaoVe_HacIn { get; set; }
        //e. Tiền sử tiếp xúc với arsen
        [MoTaDuLieu("Dùng thuốc chứa arsen")]
        public int DungThuocChuaArsen { get; set; }
        [MoTaDuLieu("Dùng nước giếng khoan")]
        public int DungNuocGiengKhoan { get; set; }
        [MoTaDuLieu("Dùng tấm lợp fibro xi măng")]
        public int DungTamLopFibroXiMang { get; set; }
        [MoTaDuLieu("Tiền sử tiếp xúc với arsen, khac")]
        public string TienSuTiepXucArsen_Khac { get; set; }
        //f. Tiền sử tiếp xúc với chất phóng xạ
        [MoTaDuLieu("Tiền sử tiếp xúc với chất phóng xạ, 1-> thường xuyên, 2 -> không thường xuyên")]
        public int TienSuTiepXucPhongXa { get; set; }
        [MoTaDuLieu("Tiền sử tiếp xúc với chất phóng xạ, tần suất")]
        public string TanSuat_TiepXucPhongXa { get; set; }
        [MoTaDuLieu("Tiền sử tiếp xúc với chất phóng xạ, Thời gian ")]
        public string ThoiGian_TiepXucPhongXa { get; set; }
        //g. Tiền sử tiếp xúc với hóa chất khác
        [MoTaDuLieu("Môi trường ô nhiễm ")]
        public int MoiTruongONhiem { get; set; }
        [MoTaDuLieu("Thuốc diệt nấm")]
        public int ThuocDietNam { get; set; }
        [MoTaDuLieu("Hóa chất khác")]
        public int HoaChatKhac { get; set; }
        [MoTaDuLieu("Chất diệt cỏ")]
        public int ChatDietCo { get; set; }
        [MoTaDuLieu("Thuốc trừ sâu")]
        public int ThuocTruSau { get; set; }
        [MoTaDuLieu("Thời gian tiếp xúc")]
        public string ThoiGianTiepXuc { get; set; }
        //h. Suy giảm miễn dịch do       
        [MoTaDuLieu("Dùng thuốc ƯCMD ")]
        public int DungThuocUCMD { get; set; }
        [MoTaDuLieu("Ghép tạng")]
        public int GhepTang { get; set; }
        [MoTaDuLieu("Ghép tạng (cụ thể) ")]
        public string GhepTang_CuThe { get; set; }
        [MoTaDuLieu("Nhiễm HIV/AIDS")]
        public int NhiemHIVAIDS { get; set; }
        [MoTaDuLieu("Suy giảm miễn dịch do, khác")]
        public string SuyGiamMienDich_Khac { get; set; }
        //6.2.Tiền sử gia đình
        public int CoNguoiBiUngThuDa { get; set; }
        [MoTaDuLieu("Loại ung thư da")]
        public string LoaiUngThuDa { get; set; }
        [MoTaDuLieu("Có người bị ung thư khác")]
        public int CoNguoiBiUngThuKhac { get; set; }
        [MoTaDuLieu("Loại ung thư khác")]
        public string LoaiUngThuKhac { get; set; }
        [MoTaDuLieu("Tiền sử gia đình khác")]
        public string TienSuGiaDinh_Khac { get; set; }
        // Khám bệnh
        [MoTaDuLieu("Toàn thân")]
        public string ToanThan { get; set; }
        [MoTaDuLieu("Các bộ phận")]
        public string CacBoPhan { get; set; }
        [MoTaDuLieu("Týp da ")]
        public int TypDa { get; set; }
        //4. Thương tổn cơ bản
        [MoTaDuLieu("Thương tổn cơ bản")]
        public string ThuongTonCoBan { get; set; }
        [MoTaDuLieu("Tăng sắc tố ,1-> Đồng nhất")]
        //Tăng sắc tố 
        public int TangSacTo_DongNhat { get; set; }
        [MoTaDuLieu("Tăng sắc tố ,1-> Không đồng nhất")]
        public int TangSacTo_KhongDongNhat { get; set; }
        [MoTaDuLieu("Tăng sắc tố ,1-> Không")]
        public int TangSacTo_Khong { get; set; }
        //Bờ thương tổn
        [MoTaDuLieu("Bờ thương tổn ,1-> Đều")]
        public int BoThuongTon_Deu { get; set; }
        [MoTaDuLieu("Bờ thương tổn ,1-> Đều")]
        public int BoThuongTon_KhongDeu { get; set; }
        [MoTaDuLieu("Bờ thương tổn ,1-> Nổi cao")]
        public int BoThuongTon_NoiCao { get; set; }
        [MoTaDuLieu("Bờ thương tổn ,1-> Bằng phẳng")]
        public int BoThuongTon_BangPhang { get; set; }

        [MoTaDuLieu("Bờ thương tổn ,1-> Có hạt ngọc ung thư")]
        public int BoThuongTon_CoHatNgoc { get; set; }

        //Đối xứng 
        [MoTaDuLieu("Đối xứng, 1-> có, 2-> không")]
        public int DoiXung { get; set; }
        [MoTaDuLieu("Tiến triển trong thời gian gần đây, 1 -> nhanh, 2 -> chậm")]
        public int TienTrienTrongThoiGian { get; set; }
        [MoTaDuLieu("Giãn mạch quanh thương tổn , 1 -> có, 2 -> không")]
        public int GianMachQuanhThuongTon { get; set; }
        [MoTaDuLieu("Kích thước")]
        public string KichThuoc { get; set; }
        [MoTaDuLieu("Số lượng")]
        public string SoLuong { get; set; }
        [MoTaDuLieu("Biến dạng các cơ quan  , 1 -> không, 2 -> có")]
        public int BienDangCacCoQuan { get; set; }
        [MoTaDuLieu("tình trạng biến dạng")]
        public string TinhTrangBienDang { get; set; }
        [MoTaDuLieu("Hạch, 1-> không sờ thấy, 2 -> sờ thấy")]
        public int Hach { get; set; }
        [MoTaDuLieu("Vị trí, số lượng hạch")]
        public string ViTriSoLuongHach { get; set; }
        [MoTaDuLieu("Bất thường bộ phận khác")]
        public string BatThuongBoPhanKhac { get; set; }
        // Chẩn đoán
        // 1.	Loại ung thư: 
        // Ung thư biểu mô tế bào đáy
        [MoTaDuLieu("Thể u (nodule)")]
        public int TheU { get; set; }
        [MoTaDuLieu("Thể nang (cystic)")]
        public int TheNang { get; set; }
        [MoTaDuLieu("Thể xơ hóa")] 
        public int TheXoHoa { get; set; }
        [MoTaDuLieu("Thể nông")]
        public int TheNong { get; set; }
        [MoTaDuLieu("Ung thư biểu mô tế bào đáy, khác")]
        public string UngThuBieuMo_Khac { get; set; }
        // Ung thư biểu mô tế bào gai
        [MoTaDuLieu("SCC sùi")]
        public int SCCSui { get; set; }
        [MoTaDuLieu("SCC sinh dục/hậu môn")]
        public int SCCSinhDucHauMon { get; set; }
        [MoTaDuLieu("Loét Marjolin")]
        public int LoetMarjolin { get; set; }
        [MoTaDuLieu("SCC quanh móng")]
        public int SCCQuanhMong { get; set; }
        [MoTaDuLieu("SCC quanh miệng")]
        public int SCCQuanhMieng { get; set; }
        [MoTaDuLieu("Bowen")]
        public int Bowen { get; set; }
        [MoTaDuLieu("Keratoacanthoma")]
        public int Keratoacanthoma { get; set; }
        [MoTaDuLieu("Ung thư biểu mô tế bào gai khác")]
        public string UngThuBieuMoTeBao_Khac { get; set; }
        [MoTaDuLieu("Thể ung thư")]
        public string TheUngThu { get; set; }
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
        [MoTaDuLieu("Tự liền ")]
        public int TuLien { get; set; }
        [MoTaDuLieu("Đóng trực tiếp  ")]
        public int DongTrucTiep { get; set; }
        [MoTaDuLieu("Vạt tại chỗ")]
        public int VatTaiCho { get; set; }
        [MoTaDuLieu("Vạt xa")]
        public int VatXa { get; set; }
        [MoTaDuLieu("Vạt vi phẫu")]
        public int VatViPhau { get; set; }
        [MoTaDuLieu("Ghép da")]
        public int GhepDa { get; set; }
        [MoTaDuLieu("b.	Tạo hình khuyết da, khác")]
        public string TaoHinhKhuyetDa_Khac { get; set; }
        [MoTaDuLieu("Nạo vét hạch, toàn bộ")]
        public int NaoVetHach_ToanBo { get; set; }
        [MoTaDuLieu("Nạo vét hạch,  Hạch gác   ")]
        public int NaoVetHach_HachGac { get; set; }
        [MoTaDuLieu("d.	Tia xạ  hoặc hóa chất: ")]
        public string TiaXaHoacHoaChat { get; set; }
        public string DieuTri_PhuongPhapKhac { get; set; }
        [MoTaDuLieu("Phẫu thuật lạnh")]
        public int PhauThuatLanh { get; set; }
        [MoTaDuLieu("Hóa chất tại chỗ")]
        public int HoaChatTaiCho { get; set; }
        [MoTaDuLieu("Tên thuốc")]
        public string TenThuoc { get; set; }
        [MoTaDuLieu("Phá hủy bằng nhiệt (plasma/laserCO2)")]
        public int PhaHuyBangNhiet { get; set; }

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
}
