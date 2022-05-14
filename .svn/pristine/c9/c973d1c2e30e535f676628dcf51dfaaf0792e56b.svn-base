using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EMR.KyDienTu;
using PMS.Access;
using System;
using System.Collections.ObjectModel;

namespace EMR_MAIN.DATABASE.BenhAn
{
    public class BenhAnPhoiTacNghenManTinh:IBase
    {
        public int IDMauPhieu { get; set; } = (int)DanhMucPhieu.BAPTNMT;
        public string TenMauPhieu { get; set; } = DanhMucPhieu.BAPTNMT.Description();
        // Phần chung Hành chính
        [MoTaDuLieu("Mã quản lý bệnh nhân")]
        public decimal MaQuanLy { get; set; }
        [MoTaDuLieu("SHS")]
        public string SHS { get; set; }
        [MoTaDuLieu("Ngày lập hồ sơ")]
        public DateTime? NgayLapHoSo { get; set; }
        [MoTaDuLieu("Điện thoại nhà riêng")]
        public string DienThoaiNhaRieng { get; set; }
        [MoTaDuLieu("Bác sỹ phụ trách bệnh nhân")]
        public string BacSyPhuTrach { get; set; }
        //I. LÝ DO KHÁM BỆNH:
        [MoTaDuLieu("1.Ho")]
        public int Ho { get; set; }
        [MoTaDuLieu("2.Khò khè")]
        public int KhoKhe { get; set; }
        [MoTaDuLieu("3.Nặng ngực ")]
        public int NangNguc { get; set; }
        [MoTaDuLieu("4. Khó thở")]
        public int KhoTho { get; set; }
        [MoTaDuLieu("5. Khạc đờm")]
        public int KhacDom { get; set; }
        [MoTaDuLieu("6. Triệu chứng khác")]
        public int TrieuChungKhac { get; set; }
        [MoTaDuLieu("6. Triệu chứng khác, ghi rõ")]
        public string TrieuChungKhac_Text { get; set; }
        //II. BỆNH SỬ
        [MoTaDuLieu("1.Thời gian khởi phát bệnh kéo dài bao lâu?")]
        public string ThoiGianKhoiPhat { get; set; }
        [MoTaDuLieu("2. BN có biết được chẩn đoán bệnh COPD trước khi đến khám?, 1-> có, 2-> không biết")]
        public int BNBietChanDoanCopd { get; set; }
        [MoTaDuLieu("3. BN được BSCK hô hấp khám và quản lý bệnh không?, 1-> có, 2-> không")]
        public int BNDuocBSCK { get; set; }
        [MoTaDuLieu("3. BN được BSCK hô hấp khám và quản lý bệnh không? trong bao lâu")]
        public string BNDuocBSCK_TrongBaoLau { get; set; }
        [MoTaDuLieu("4. Số lần mắc đợt cấp trong năm vừa qua:")]
        public string SoLanMacTrongNam { get; set; }
        [MoTaDuLieu("5. Đã nhập viện vì bệnh COPD?, 1-> có, 2-> không")]
        public int DaNhapVienViCopd { get; set; }
        [MoTaDuLieu("5. Đã nhập viện vì bệnh COPD?, bao nhiêu lần")]
        public string NhapVienBaoLan { get; set; }
        [MoTaDuLieu("5. Đã nhập viện vì bệnh COPD?, có thở máy lần")]
        public string CoThoMay { get; set; }
        //6. Thuốc đã sử dụng điều trị trước đây
        [MoTaDuLieu("SABA, Có sử dụng")]
        public string SABA_CoSuDung { get; set; }
        [MoTaDuLieu("SABA, cách dùng")]
        public string SABA_CachDung { get; set; }
        [MoTaDuLieu("LABA, Có sử dụng")]
        public string LABA_CoSuDung { get; set; }
        [MoTaDuLieu("LABA, cách dùng")]
        public string LABA_CachDung { get; set; }
        [MoTaDuLieu("Corticoid, Có sử dụng")]
        public string Corticoid_CoSuDung { get; set; }
        [MoTaDuLieu("Corticoid, cách dùng")]
        public string Corticoid_CachDung { get; set; }
        [MoTaDuLieu("Corticoid/LABA, Có sử dụng")]
        public string Corticoid_LABA_CoSuDung { get; set; }
        [MoTaDuLieu("Corticoid/LABA, cách dùng")]
        public string Corticoid_LABA_CachDung { get; set; }
        [MoTaDuLieu("Xanthine, Có sử dụng")]
        public string Xanthine_CoSuDung { get; set; }
        [MoTaDuLieu("Xanthine, cách dùng")]
        public string Xanthine_CachDung { get; set; }
        [MoTaDuLieu("Khác, Có sử dụng")]
        public string Khac_CoSuDung { get; set; }
        [MoTaDuLieu("Khác, cách dùng")]
        public string Khac_CachDung { get; set; }
        [MoTaDuLieu("7. Yếu tố liên quan đến khởi phát đợt cấp: 1-> biết rõ, 2-> không biết rõ")]
        public int YeuToLienQuanDenDotCap { get; set; }
        [MoTaDuLieu("Thay đổi thời tiết, có")]
        public string ThayDoiThoiTiet_Co { get; set; }
        [MoTaDuLieu("Thay đổi thời tiết, không")]
        public string ThayDoiThoiTiet_Khong { get; set; }
        [MoTaDuLieu("Không tuân thủ điều trị : Có")]
        public string KhongTuanThuDieuTri_Co { get; set; }
        [MoTaDuLieu("Không tuân thủ điều trị : Không")]
        public string KhongTuanThuDieuTri_Khong { get; set; }
        [MoTaDuLieu("Viêm hô hấp: Có")]
        public string ViemHoHap_Co { get; set; }
        [MoTaDuLieu("Viêm hô hấp: không")]
        public string ViemHoHap_Khong { get; set; }
        [MoTaDuLieu("Bệnh phổi hợp: có")]
        public string BenhPhoiHop_Co { get; set; }
        [MoTaDuLieu("Bệnh phổi hợp: không")]
        public string BenhPhoiHop_Khong { get; set; }
        [MoTaDuLieu("Khói thuốc: có")]
        public string KhoiThuoc_Co { get; set; }
        [MoTaDuLieu("Khói thuốc: không")]
        public string KhoiThuoc_Khong { get; set; }
        [MoTaDuLieu("Bụi: có")]
        public string Bui_Co { get; set; }
        [MoTaDuLieu("Bụi: không")]
        public string Bui_Khong { get; set; }
        [MoTaDuLieu("Hóa chất: có")]
        public string HoaChat_Co { get; set; }
        [MoTaDuLieu("Hóa chất: không")]
        public string HoaChat_Khong { get; set; }
        [MoTaDuLieu("Thuốc: có")]
        public string Thuoc_Co { get; set; }
        [MoTaDuLieu("Thuốc: không")]
        public string Thuoc_Khong { get; set; }
        [MoTaDuLieu("Thức ăn: có")]
        public string ThucAn_Co { get; set; }
        [MoTaDuLieu("Thức ăn: không")]
        public string ThucAn_Khong { get; set; }
        [MoTaDuLieu("Gắng sức: có")]
        public string GangSuc_Co { get; set; }
        [MoTaDuLieu("Gắng sức: không")]
        public string GangSuc_Khong { get; set; }
        [MoTaDuLieu("Khác: có")]
        public string Khac_Co { get; set; }
        [MoTaDuLieu("Khác: không")]
        public string Khac_Khong { get; set; }
        //Triệu chứng bệnh:
        [MoTaDuLieu("Triệu chứng bệnh, ho, 1-> không, 2-> ít, 3-> nhiều")]
        public int TrieuChungBenh_Ho { get; set; }
        [MoTaDuLieu("Triệu chứng bệnh, Khạc đờm, 1-> không, 2-> ít, 3-> nhiều")]
        public int TrieuChungBenh_KhacDom { get; set; }
        [MoTaDuLieu("Triệu chứng bệnh, Dờm màu")]
        public string TrieuChungBenh_DomMau { get; set; }
        [MoTaDuLieu("Triệu chứng bệnh, Khò khè, 1-> không, 2-> ít, 3-> nhiều")]
        public int TrieuChungBenh_KhoKhe { get; set; }
        [MoTaDuLieu("Triệu chứng bệnh, Khó thở, 1-> không, 2-> ít, 3-> nhiều")]
        public int TrieuChungBenh_KhoTho { get; set; }
        [MoTaDuLieu("Triệu chứng bệnh, nặng ngực, 1-> không, 2-> ít, 3-> nhiều")]
        public int TrieuChungBenh_NangNguc { get; set; }
        [MoTaDuLieu("8. Mức độ khó thở phân theo loại Medical Research Council:")]
        public int MucDoKhoTho { get; set; }
        //III. TIỀN SỬ
        //1. Bản thân
        [MoTaDuLieu("a. Hút thuốc Lá/Lào: 1 -> đang hút, 2 -> hút thụ động, 3 -> đã từng hút, 4 -> không hút")]
        public int HutThuoc { get; set; }
        [MoTaDuLieu("Hút thuốc thụ động, năm")]
        public string HutThuocThuDong_Nam { get; set; }
        [MoTaDuLieu("Số thuốc hút trên năm")]
        public string HutThuocBaoTrenNam { get; set; }
        [MoTaDuLieu("Ghi chú")]
        public string HutThuoc_GhiChu { get; set; }
        //Cơ địa dị ứng
        [MoTaDuLieu("Viêm mũi dị ứng, có")]
        public string ViemMuiDiUng_Co { get; set; }

        [MoTaDuLieu("Viêm mũi dị ứng, không")]
        public string ViemMuiDiUng_Khong { get; set; }
        [MoTaDuLieu("Mề đay, có")]
        public string MeDay_Co { get; set; }
        [MoTaDuLieu("Mề đay, không")]
        public string MeDay_Khong { get; set; }
        [MoTaDuLieu("Chàm, có")]
        public string Cham_Co { get; set; }
        [MoTaDuLieu("Chàm, không")]
        public string Cham_Khong { get; set; }
        [MoTaDuLieu("Cơ địa dị ứng khác, có")]
        public string CoDiaDiUng_Khac_Co { get; set; }
        [MoTaDuLieu("Cơ địa dị ứng khác, không")]
        public string CoDiaDiUng_Khac_Khong { get; set; }
        [MoTaDuLieu("Dị nguyên:")]
        public string DiNguyen { get; set; }
        //b. Bệnh tim mạch:
        [MoTaDuLieu("Bệnh động mạch vành")]
        public int BenhDongMachVanh { get; set; }
        [MoTaDuLieu("Nhồi máu cơ tim")]
        public int NhoiMauCoTim { get; set; }
        [MoTaDuLieu("Loạn nhịp tim")]
        public int LoanNhipTim { get; set; }
        [MoTaDuLieu("Suy tim xung huyết")]
        public int XuyTimXungHuyet { get; set; }
        //c. Bệnh mạch máu: 
        [MoTaDuLieu("Tăng huyết áp")]
        public int TangHuyetAp { get; set; }
        [MoTaDuLieu("Tai biến mạch máu não")]
        public int TaiBienMachMaoNao { get; set; }
        //d. Rối loạn nội tiết
        [MoTaDuLieu("Hội chứng Cushing")]
        public int HoiChungCushing { get; set; }
        [MoTaDuLieu("Suy thượng thận")]
        public int SuyThuongThan { get; set; }
        //e. Bệnh về mắt:
        [MoTaDuLieu("Cườm mắt")]
        public int CuomMat { get; set; }
        [MoTaDuLieu("Tăng nhãn áp")]
        public int TangNhanAp { get; set; }
        //f. Sự chuyển hóa và rối loạn dinh dưỡng:
        [MoTaDuLieu("Tăng cholesterol máu")]
        public int TangCholesteronMau { get; set; }
        [MoTaDuLieu("Đái tháo đường")]
        public int DaiThaoDuong { get; set; }
        [MoTaDuLieu("Loãng xương")]
        public int LoangXuong { get; set; }
        //g.Nhiễm trùng và bệnh do nhiễm trùng: 
        [MoTaDuLieu("Viêm phổi")]
        public int ViemPhoi { get; set; }
        //2. Gia đình
        [MoTaDuLieu("0. Không có bệnh")]
        public int GiaDinh_KhongCoBenh { get; set; }
        [MoTaDuLieu("1. Hen")]
        public int GiaDinh_Hen { get; set; }
        [MoTaDuLieu("1. Viêm mũi dị ứng")]
        public int GiaDinh_ViemMuiDiUng { get; set; }
        [MoTaDuLieu("3.Mề đay")]
        public int GiaDinh_MeDay { get; set; }
        [MoTaDuLieu("4. Chàm")]
        public int GiaDinh_Cham { get; set; }
        [MoTaDuLieu("5.Khác")]
        public int GiaDinh_Khac { get; set; }
        [MoTaDuLieu("5.Khác (cụ thể)")]
        public string GiaDinh_Khac_CuThe { get; set; }
        [MoTaDuLieu("- Ai mắc bệnh:")]
        public string AiMacBenh { get; set; }
        //IV. KHÁM LÂM SÀNG
        [MoTaDuLieu("Phổi, bình thường")]
        public int Phoi_BinhThuong { get; set; }
        [MoTaDuLieu("Phổi, 1.RRFN giảm")]
        public int Phoi_RRFNGiam { get; set; }
        [MoTaDuLieu("Phổi, 2.Ran rít, ran ngáy")]
        public int Phoi_RanRitRanNgay { get; set; }
        [MoTaDuLieu("Phổi, 2.Ran nổ, ẩm")]
        public int Phoi_RanNoAm { get; set; }
        [MoTaDuLieu("Phổi, 4. Khác")]
        public int Phoi_Khac { get; set; }
        [MoTaDuLieu("Phổi, 4. Khác (cụ thể)")]
        public string Phoi_Khac_CuThe { get; set; }
        [MoTaDuLieu("Cơ quan khác:")]
        public string CoQuanKhac { get; set; }
        //V. CẬN LÂM SÀNG:
        [MoTaDuLieu("1. Đo phế dung")]
        public ObservableCollection<DoPheDung> DoPheDungs { get; set; }
        [MoTaDuLieu("2. Đo chức năng hô hấp (% so với chỉ số dự đoán)")]
        public ObservableCollection<DoChucNangHoHap> DoChucNangHoHaps { get; set; }
        [MoTaDuLieu("3. X-quang phổi")]
        public string XQuangPhoi { get; set; }
        [MoTaDuLieu("4. Điện tâm đồ/Siêu âm tim")]
        public string DTD_SAT { get; set; }
        [MoTaDuLieu("5. Xét nghiệm khác")]
        public string XetNghiemKhac { get; set; }
        //VI. CHẨN ĐOÁN:
        [MoTaDuLieu("1. Chẩn đoán xác định: COPD, giai đoạn 1")]
        public int ChanDoan_COPD_1 { get; set; }
        [MoTaDuLieu("1. Chẩn đoán xác định: COPD, giai đoạn 2")]
        public int ChanDoan_COPD_2 { get; set; }
        [MoTaDuLieu("1. Chẩn đoán xác định: COPD, giai đoạn 3")]
        public int ChanDoan_COPD_3 { get; set; }
        [MoTaDuLieu("1. Chẩn đoán xác định: COPD, giai đoạn 4")]
        public int ChanDoan_COPD_4 { get; set; }
        [MoTaDuLieu("2. Bệnh phối hợp:")]
        public string BenhPhoiHop { get; set; }
        [MoTaDuLieu("VII. ĐIỀU TRỊ:")]
        public string DieuTri { get; set; }


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
    public class DoPheDung
    {
        public string Cot_1 { get; set; }
        public string Cot_2 { get; set; }
        public string Cot_3 { get; set; }
    }
    public class DoChucNangHoHap
    {
        public string ChucNang { get; set; }
        public string TT_TriSo { get; set; }
        public string TT_Per { get; set; }
        public string ST_TriSo { get; set; }
        public string ST_Per { get; set; }
        public string PerThayDoi { get; set; }
    }
}
