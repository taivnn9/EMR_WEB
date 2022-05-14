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
    public class BenhAnTangHuyetAp:IBase
    {
        public int IDMauPhieu { get; set; } = (int)DanhMucPhieu.BATHA;
        public string TenMauPhieu { get; set; } = DanhMucPhieu.BATHA.Description();
        [MoTaDuLieu("Mã quản lý bệnh nhân")]
        public decimal MaQuanLy { get; set; }
        [MoTaDuLieu("Số lưu")]
        public string SoLuu { get; set; }
        [MoTaDuLieu("I - LÍ DO VÀO VIỆN")]
        public string LyDoVaoVien { get; set; }
        [MoTaDuLieu("II - BỆNH SỬ")]
        public string BenhSu { get; set; }
        [MoTaDuLieu("III - TIỀN SỬ")]
        public string TienSu { get; set; }
        public DateTime? LanKhamDauTien_Ngay { get; set; }
        [MoTaDuLieu("1. CHỈ SỐ HA")]
        public string ChiSoHA { get; set; }
        //2. KHÁM TOÀN THÂN
        [MoTaDuLieu("Cân nặng")]
        public string CanNang { get; set; }
        [MoTaDuLieu("Chiều cao")]
        public string ChieuCao { get; set; }
        [MoTaDuLieu("Vòng bụng")]
        public string VongBung { get; set; }
        //3. TRIỆU CHỨNG CƠ NĂNG
        [MoTaDuLieu("Đau đầu, chóng mặt, 1-> có, 2 -> không")]
        public int DauDau { get; set; }
        [MoTaDuLieu("Ho khan, 1-> có, 2 -> không")]
        public int HoKhan { get; set; }
        [MoTaDuLieu("Khó thở khi gắng sức, 1-> có, 2 -> không")]
        public int KhoThoKhiGangSuc { get; set; }
        [MoTaDuLieu("Hồi hộp đánh trống ngực, 1-> có, 2 -> không")]
        public int HoiHopDanhTrongNguc { get; set; }
        //4. TRIỆU CHỨNG THỰC THỂ
        [MoTaDuLieu("Phù hai chân, 1-> có, 2 -> không")]
        public int PhuHaiChan { get; set; }
        [MoTaDuLieu("Méo mồm, 1-> có, 2 -> không")]
        public int MeoMom { get; set; }
        //5. CÁC CÂU HỎI KÈM THEO
        [MoTaDuLieu("Tuân thủ điều trị, 1-> có, 2 -> không")]
        public int TuanThuDieuTri { get; set; }
        [MoTaDuLieu("Thực hiện chế độ (ăn kiêng, tập luyện), 1-> có, 2 -> không")]
        public int ThucHienCheDo { get; set; }
        [MoTaDuLieu("Hút thuốc, 1-> có, 2 -> không")]
        public int HutThuoc { get; set; }
        [MoTaDuLieu("Hút thuốc, điếu/ngày")]
        public string HutThuoc_Dieu { get; set; }
        [MoTaDuLieu("Uống rượu, 1-> có, 2 -> không")]
        public int UongRuou { get; set; }
        [MoTaDuLieu("Uống rượu, ml/ngày")]
        public string UongRuou_Ml { get; set; }
        [MoTaDuLieu("6. CÁC TRIỆU CHỨNG KHÁC:")]
        public string CacTrieuChungKhac { get; set; }
        //7. XÉT NGHIỆM
        // Lipid máu
        [MoTaDuLieu("Cholesterol TP ")]
        public string Cholesterol_TP { get; set; }
        [MoTaDuLieu("TG")]
        public string TG { get; set; }
        [MoTaDuLieu("HDL")]
        public string HDL { get; set; }
        [MoTaDuLieu("LDL")]
        public string LDL { get; set; }
        [MoTaDuLieu("Glucose máu")]
        public string GlucoseMau { get; set; }
        [MoTaDuLieu("Đạm niệu")]
        public string DamNiem { get; set; }
        [MoTaDuLieu("Creatinin máu")]
        public string CreatininMau { get; set; }
        [MoTaDuLieu("Siêu âm tim")]
        public string SieuAmTim { get; set; }
        [MoTaDuLieu("Siêu âm tim, Dày thất trái")]
        public string SAT_DayThatTrai { get; set; }
        [MoTaDuLieu("Điện tâm đồ")]
        public string DienTamDo { get; set; }
        [MoTaDuLieu("Trục điện tim")]
        public string TrucDienTim { get; set; }
        [MoTaDuLieu("Điện tâm đồ, Dày thất trái")]
        public string DTD_DayThatTrai { get; set; }
        [MoTaDuLieu("Xquang tim- phổi")]
        public string XQuangTimPhoi { get; set; }
        // 8. CHẨN ĐOÁN
        [MoTaDuLieu("A - Mức độ tăng HA")]
        public string MucDoTangHA { get; set; }
        [MoTaDuLieu("B - Giai đoạn tăng HA")]
        public string GiaiDoanTangHA { get; set; }
        [MoTaDuLieu("C - Các bệnh phối hợp")]
        public string CacBenhPhoiHop { get; set; }

        // 9. ĐIỆU TRỊ
        [MoTaDuLieu("Thực hiện chế độ thay đổi lối sống")]
        public string THCDTDLS { get; set; }
        [MoTaDuLieu("Thuốc điều trị")]
        public string ThuocDieuTri { get; set; }
        [MoTaDuLieu("Hẹn tái khám ngày")]
        public DateTime? HenTaiKham { get; set; }
        [MoTaDuLieu("Bác sỹ")]
        public string BacSy { get; set; }




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
