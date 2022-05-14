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
    public class BenhAnBenhBaseDow: IBase
    {
        public int IDMauPhieu { get; set; } = (int)DanhMucPhieu.BATDDTBBD;
        public string TenMauPhieu { get; set; } = DanhMucPhieu.BATDDTBBD.Description();
        // Phần chung Hành chính
        [MoTaDuLieu("Mã quản lý bệnh nhân")]
        public decimal MaQuanLy { get; set; }
        // phần hỏi bệnh
        // II.LÝ DO VÀO VIỆN
        [MoTaDuLieu("1. Mệt mỏi, 1-> có, 2-> không")]
        public int MetMoi { get; set; }
        [MoTaDuLieu("2. Gầy sút cân, 1-> có, 2-> không")]
        public int GaySutCan { get; set; }
        [MoTaDuLieu("3.Run chân tay, 1-> có, 2-> không")]
        public int RunChanTay { get; set; }
        [MoTaDuLieu("4. Cổ to, 1-> có, 2-> không")]
        public int CoTo { get; set; }
        [MoTaDuLieu("5. Lồi mắt , 1-> có, 2-> không")]
        public int LoiMat { get; set; }
        [MoTaDuLieu("6. Hồi hộp, tức ngực , 1-> có, 2-> không")]
        public int HoiHopTucNguc { get; set; }
        [MoTaDuLieu("7.Khác, 1-> có, 2-> không")]
        public int LyDoKhac { get; set; }
        // III. HỎI BỆNH
        // 1. Tiền sử bệnh
        // 1.1 Tiền sử bản thân
        [MoTaDuLieu("Hen phế quản, 1-> có, 2-> không")]
        public int HenPheQuan { get; set; }
        [MoTaDuLieu("Bệnh lý dạ dày, 1-> có, 2-> không")]
        public int BenhLyDaDay { get; set; }
        [MoTaDuLieu("Kinh nguyệt:, 1-> đều, 2-> không đều")]
        public int KinhNguyet { get; set; }
        //1.2 Tiền sử gia đình (bố, mẹ, anh chị em ruột)
        [MoTaDuLieu("Basedow:, 1-> có, 2-> không")]
        public int Basedow { get; set; }
        [MoTaDuLieu("Bướu cổ:, 1-> có, 2-> không")]
        public int BuouCo { get; set; }
        [MoTaDuLieu("Bệnh khác:, 1-> có, 2-> không")]
        public int BenhKhac { get; set; }
        //2. Bệnh sử:
        [MoTaDuLieu("Quá trình bệnh lý")]
        public string QuaTrinhBenhLy { get; set; }
        [MoTaDuLieu("Diễn biến bệnh")]
        public string DienBienBenh { get; set; }
        [MoTaDuLieu("Chẩn đoán bệnh năm")]
        public string ChanDoanBenh_Nam { get; set; }
        [MoTaDuLieu("Nơi chẩn đoán")]
        public string NoiChanDoan { get; set; }
        [MoTaDuLieu("Điều trị:, 1-> đều, 2-> không đều")]
        public int BenhSu_DieuTri { get; set; }
        [MoTaDuLieu("Thuốc đang điều trị")]
        public string ThuocDangDieuTri { get; set; }
        [MoTaDuLieu("Điều trị I131")]
        public int DieuTriI131 { get; set; }
        [MoTaDuLieu("Điều trị bằng phẫu thuật")]
        public int DieuTriBangPhauThuat { get; set; }
        // Hiện tại
        [MoTaDuLieu("Mệt mỏi, 1-> có, 2-> không")]
        public int HienTai_MetMoi { get; set; }
        [MoTaDuLieu("Gầy sút cân, 1-> có, 2-> không")]
        public int HienTai_GaySutCan { get; set; }
        [MoTaDuLieu("Run tay chân, 1-> có, 2-> không")]
        public int HienTai_RunTayChan { get; set; }
        [MoTaDuLieu("Cổ to, 1-> có, 2-> không")]
        public int HienTai_CoTo { get; set; }
        [MoTaDuLieu("Mắt lồi, 1-> có, 2-> không")]
        public int HienTai_MatLoi { get; set; }
        [MoTaDuLieu("Người nóng bức, 1-> có, 2-> không")]
        public int HienTai_NguoiNongBuc { get; set; }
        [MoTaDuLieu("Rối loạn tiêu hóa, 1-> có, 2-> không")]
        public int HienTai_RoiLoanTieuHoa { get; set; }
        [MoTaDuLieu("Khác, 1-> có, 2-> không")]
        public int HienTai_Khac { get; set; }
        //IV. KHÁM BỆNH LẦN ĐẦU
        [MoTaDuLieu("Ngày khám")]
        public DateTime? NgayKham { get; set; }
        // 1. Toàn thân
        [MoTaDuLieu("Cân nặng")]
        public string CanNang { get; set; }
        [MoTaDuLieu("Tỉnh, 1-> có, 2-> không")]
        public int ToanThan_Tinh { get; set; }
        [MoTaDuLieu("Da nóng ẩm, 1-> có, 2-> không")]
        public int ToanThan_DaNongAm { get; set; }
        [MoTaDuLieu("Da, niêm mạc mắt vàng , 1-> có, 2-> không")]
        public int ToanThan_DaNiemMacMatVang { get; set; }
        [MoTaDuLieu("Run tay , 1-> có, 2-> không")]
        public int ToanThan_RunTay { get; set; }
        [MoTaDuLieu("Khác , 1-> có, 2-> không")]
        public int ToanThan_Khac { get; set; }
        //2. Bộ phận
        [MoTaDuLieu("Tuần hoàn: nhịp tim")]
        public string NhipTim { get; set; }
        [MoTaDuLieu("Nhịp tim, 1-> đều, 2 -> không đều")]
        public int NhipTim_Deu { get; set; }
        [MoTaDuLieu("Tiếng tim")]
        public string TiengTim { get; set; }
        [MoTaDuLieu("HA")]
        public string HA { get; set; }
        [MoTaDuLieu("Tuyến giáp: to độ, Ia-> 1, Ib -> 2, II ->3, III->4")]
        public int TuyenGiap { get; set; }
        [MoTaDuLieu("Mật độ: Mềm")]
        public int MatDo_Mem { get; set; }
        [MoTaDuLieu("Mật độ: Chắc")]
        public int MatDo_Chac { get; set; }
        [MoTaDuLieu("Bướu lan tỏa")]
        public int BuouLanToa { get; set; }
        [MoTaDuLieu("Nhân thùy phải")]
        public int NhanThuyPhai { get; set; }
        [MoTaDuLieu("Nhân thùy trái")]
        public int NhanThuyTrai { get; set; }
        [MoTaDuLieu("Nhân 2 thùy")]
        public int Nhan2Thuy { get; set; }
        [MoTaDuLieu("Tiếng thổi tâm thu: Thùy phải")]
        public int TTTT_ThuyPhai { get; set; }
        [MoTaDuLieu("Tiếng thổi tâm thu: Thùy trái")]
        public int TTTT_ThuyTrai { get; set; }
        [MoTaDuLieu("Tiếng thổi tâm thu: không có")]
        public int TTTT_KhongCo { get; set; }
        [MoTaDuLieu("Tiếng thổi liên tục: Thùy phải")]
        public int TTLT_ThuyPhai { get; set; }
        [MoTaDuLieu("Tiếng thổi liên tục: Thùy trái")]
        public int TTLT_ThuyTrai { get; set; }
        [MoTaDuLieu("Tiếng thổi liên tục: không có")]
        public int TTLT_KhongCo { get; set; }
        [MoTaDuLieu("Mắt phải NO SPECS độ")]
        public string MatPhaiNOSPECSDo { get; set; }
        [MoTaDuLieu("Mắt trái NO SPECS độ")]
        public string MatTraiNOSPECSDo { get; set; }
        [MoTaDuLieu("Hô hấp")]
        public string HoHap { get; set; }
        [MoTaDuLieu("Thần kinh")]
        public string ThanKinh { get; set; }
        [MoTaDuLieu("Bụng")]
        public string Bung { get; set; }
        [MoTaDuLieu("Bộ phận khác")]
        public string BoPhanKhac { get; set; }
        //V. CẬN LÂM SÀNG
        //1. Sinh hóa máu
        [MoTaDuLieu("Ure")]
        public string Ure { get; set; }
        [MoTaDuLieu("Glucose")]
        public string Glucose { get; set; }
        [MoTaDuLieu("Creatinin")]
        public string Creatinin { get; set; }
        [MoTaDuLieu("Cholesterol TP")]
        public string Cholesterol_TP { get; set; }
        [MoTaDuLieu("TG")]
        public string TG { get; set; }
        [MoTaDuLieu("HDL-C")]
        public string HDL_C { get; set; }
        [MoTaDuLieu("LDL-C")]
        public string LDL_C { get; set; }
        [MoTaDuLieu("Acid")]
        public string Acid { get; set; }
        [MoTaDuLieu("SGOT")]
        public string SGOT { get; set; }
        [MoTaDuLieu("SGPT")]
        public string SGPT { get; set; }
        [MoTaDuLieu("Protein")]
        public string Protein { get; set; }
        [MoTaDuLieu("Albumin")]
        public string Albumin { get; set; }
        [MoTaDuLieu("Na")]
        public string Na { get; set; }
        [MoTaDuLieu("K")]
        public string K { get; set; }
        [MoTaDuLieu("Cl")]
        public string Cl { get; set; }

        [MoTaDuLieu("Ca")]
        public string Ca { get; set; }
        //2. Công thức máu
        [MoTaDuLieu("HC")]
        public string HC { get; set; }
        [MoTaDuLieu("Hb")]
        public string Hb { get; set; }
        [MoTaDuLieu("HCT")]
        public string HCT { get; set; }
        [MoTaDuLieu("BC")]
        public string BC { get; set; }
        [MoTaDuLieu("TT")]
        public string TT { get; set; }
        [MoTaDuLieu("lympho")]
        public string lympho { get; set; }
        [MoTaDuLieu("TC")]
        public string TC { get; set; }
        //3. Miễn dịch
        [MoTaDuLieu("T3")]
        public string T3 { get; set; }
        [MoTaDuLieu("FT3")]
        public string FT3 { get; set; }
        [MoTaDuLieu("FT4")]
        public string FT4 { get; set; }
        [MoTaDuLieu("TSH")]
        public string TSH { get; set; }
        [MoTaDuLieu("Anti TPO")]
        public string Anti_TPO { get; set; }
        [MoTaDuLieu("TRAb")]
        public string TRAb { get; set; }
        [MoTaDuLieu(" Siêu âm tuyến giáp")]
        public string SieuAmTuyenGiap { get; set; }
        [MoTaDuLieu(" Độ tập trung I131")]
        public string DoTapTrungI131 { get; set; }
        [MoTaDuLieu(" Xạ hình tuyến giáp")]
        public string XaHinhTuyenGiap { get; set; }
        [MoTaDuLieu(" Điện tim")]
        public string DienTim { get; set; }
        [MoTaDuLieu(" Siêu âm Dopple tim, mạch máu")]
        public string SieuAmDopple { get; set; }
        [MoTaDuLieu(" 9. XQ tim phổi")]
        public string XQTimPhoi { get; set; }
        [MoTaDuLieu(" Chẩn đoán bệnh")]
        public string ChanDoan_Benh { get; set; }
        [MoTaDuLieu(" Chẩn đoán biến chứng")]
        public string ChanDoan_BienChung { get; set; }
        [MoTaDuLieu(" Chẩn đoán bệnh phối hợp")]
        public string ChanDoan_BenhPhoiHop { get; set; }
        [MoTaDuLieu(" VII. Điều trị")]
        public string DieuTri { get; set; }
        [MoTaDuLieu(" Lý do thêm, thay đổi thuốc")]
        public string LyDoThemThayThuoc { get; set; }
        [MoTaDuLieu(" Hẹn khám lại ngày")]
        public DateTime? HenKhamLaiNgay { get; set; }
        [MoTaDuLieu(" Hẹn XN lại ngày")]
        public DateTime? HenXNLaiNgay { get; set; }
        [MoTaDuLieu(" Bác sỹ điều trị")]
        public string BacSyDieuTri { get; set; }

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
