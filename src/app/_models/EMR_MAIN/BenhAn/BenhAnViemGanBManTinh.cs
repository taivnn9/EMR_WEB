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
    public class BenhAnViemGanBManTinh : IBase
    {
        public int IDMauPhieu { get; set; } = (int)DanhMucPhieu.BAVGBMT;
        public string TenMauPhieu { get; set; } = DanhMucPhieu.BAVGBMT.Description();
        // Phần chung Hành chính
        [MoTaDuLieu("Mã quản lý bệnh nhân")]
        public decimal MaQuanLy { get; set; }
        [MoTaDuLieu("Lý do nhận vào N/C")]
        public string LyDoNhanVaoNC { get; set; }
        //A. TIỀN SỬ BẢN THÂN
        //1. Các yếu tố nguy cơ:
        [MoTaDuLieu("- Mẹ HB Ag(+), 1-> không, 2-> có, 3 -> không biết")]
        public int MeHbAg { get; set; }
        [MoTaDuLieu("- Vợ, chồng, bạn tình HB Ag(+), 1-> không, 2-> có, 3 -> không biết")]
        public int VoChongBanTinhHb { get; set; }
        [MoTaDuLieu("- Truyền máu:, 1-> không, 2-> có, 3 -> không biết")]
        public int TruyenMau { get; set; }
        [MoTaDuLieu("- Tổn thương do kim đâm, 1-> không, 2-> có, 3 -> không biết")]
        public int TonThuongDoKimDam { get; set; }
        [MoTaDuLieu("2. Đồng nhiễm VR viêm gan khác, 1-> không, 2-> có, 3 -> không biết")]
        public int DongNhiemVR { get; set; }
        //3. Hoàn cảnh phát hiện bệnh:
        [MoTaDuLieu("Có triệu chứng:, 1-> không, 2-> có,")]
        public int CoTrieuChung { get; set; }
        [MoTaDuLieu("Khám SK định kỳ, 1-> không, 2-> có,")]
        public int KhamSKDinhKy { get; set; }
        [MoTaDuLieu("Tình cờ, 1-> không, 2-> có,")]
        public int TinhCo { get; set; }
        //4. Thời điểm phát hiện bệnh
        [MoTaDuLieu("4. Thời điểm phát hiện bệnh")]
        public DateTime? TDPHB_HBsAg { get; set; }
        [MoTaDuLieu("VGSVB mạn")]
        public DateTime? VGSVBMan { get; set; }
        [MoTaDuLieu("5. Đã điều trị VGSVB mạn, 1-> không, 2-> có")]
        public int DaDieuTriVGSVBMan { get; set; }
        [MoTaDuLieu("ghi rõ thuốc điều trị")]
        public string GhiRoThuocDieuTri { get; set; }
        [MoTaDuLieu("6. Tiền sử sinh đẻ")]
        public string TienSuSinhDe { get; set; }
        [MoTaDuLieu("Con đã tiêm phòng, 1-> đã tiêm, 2-> chưa tiêm")]
        public int ConDaTiemPhong { get; set; }
        [MoTaDuLieu("7. Bản thân đã tiêm phòng: , 1-> không, 2-> có")]
        public int BanThanDaTiemPhong { get; set; }
        [MoTaDuLieu("7. Bản thân đã tiêm phòng: năm")]
        public string BanThanDaTiemPhong_Nam { get; set; }
        [MoTaDuLieu("8. Uống rượu: 1-> không, 2-> có")]
        public int UongRuou { get; set; }
        [MoTaDuLieu("8. Uống rượu: ghi rõ")]
        public string UongRuou_GhiRo { get; set; }
        [MoTaDuLieu("Bệnh khác: 1-> không, 2-> có")]
        public int BenhKhac { get; set; }
        [MoTaDuLieu("Bệnh khác: ghi rõ")]
        public string BenhKhac_GhiRo { get; set; }
        //B. TIỀN SỬ GIA ĐÌNH:
        [MoTaDuLieu("1. Có người bị viêm gan: 1-> không, 2-> có")]
        public int CoNguoiBiViemGanB { get; set; }
        [MoTaDuLieu("1. Có người bị viêm gan: ghi rõ")]
        public string CoNguoiBiViemGanB_GhiRo { get; set; }
        [MoTaDuLieu("2. Có người bị K gan: 1-> không, 2-> có")]
        public int CoNguoiBiKGan { get; set; }
        [MoTaDuLieu("2. Có người bị K gan: ghi rõ")]
        public string CoNguoiBiKGan_GhiRo { get; set; }
        [MoTaDuLieu("C. BỆNH SỬ:")]
        public string BenhSu { get; set; }
        //D. KHÁM LÂM SÀNG
        //1. Toàn thân:
        [MoTaDuLieu("1. Toàn thân: Cao")]
        public string Cao { get; set; }
        [MoTaDuLieu("1. Toàn thân: Nặng")]
        public string Nang { get; set; }
        //2. Triệu chứng cơ năng:
        [MoTaDuLieu("Sốt: 1-> không, 2-> có")]
        public int Sot { get; set; }
        [MoTaDuLieu("Đau HSP: 1-> không, 2-> có")]
        public int DauHSP { get; set; }
        [MoTaDuLieu("Mệt mỏi: 1-> không, 2-> có")]
        public int MetMoi { get; set; }
        [MoTaDuLieu("Chán ăn: 1-> không, 2-> có")]
        public int ChanAn { get; set; }
        [MoTaDuLieu("Sụt cân: 1-> không, 2-> có")]
        public int SutCan { get; set; }
        [MoTaDuLieu("Triệu chứng khác")]
        public string TCCN_TrieuChungKhac { get; set; }
        //3. Khám bộ phận
        [MoTaDuLieu("- Nhịp tim")]
        public string NhipTim { get; set; }
        [MoTaDuLieu("- HA")]
        public string HA { get; set; }
        [MoTaDuLieu("- Vàng da: 1-> không, 2-> có")]
        public int VangDa { get; set; }
        [MoTaDuLieu("- Sao mạch: 1-> không, 2-> có")]
        public int SaoMach { get; set; }
        [MoTaDuLieu("- XHDD: 1-> không, 2-> có")]
        public int XHDD { get; set; }
        [MoTaDuLieu("- Cổ chướng: 1-> không, 2-> có")]
        public int CoChuong { get; set; }
        [MoTaDuLieu("- Phù: 1-> không, 2-> có")]
        public int Phu { get; set; }
        [MoTaDuLieu("- Gan to: 1-> không, 2-> có")]
        public int GanTo { get; set; }
        [MoTaDuLieu("- Lách to: 1-> không, 2-> có")]
        public int LachTo { get; set; }
        [MoTaDuLieu("- Triệu chứng khác: 1-> không, 2-> có")]
        public int KBP_TrieuChungKhac { get; set; }
        [MoTaDuLieu("- Các bộ phận khác")]
        public string CacBoPhanKhac { get; set; }
        // E. CẬN LÂM SÀNG:
        // 1. Máu:
        [MoTaDuLieu("HB s Ag:")]
        public string HBsAg { get; set; }
        [MoTaDuLieu("AntiHB s:")]
        public string AntiHBs { get; set; }
        [MoTaDuLieu("HB e Ag:")]
        public string HBeAg { get; set; }
        [MoTaDuLieu("HBV-DNA:")]
        public string HBVDNA { get; set; }
        [MoTaDuLieu("AntiHBeAg:")]
        public string AntiHBeAg { get; set; }
        [MoTaDuLieu("Anti-HVC:")]
        public string AntiHVC { get; set; }
        [MoTaDuLieu("HIV")]
        public string HIV { get; set; }
        [MoTaDuLieu("AST")]
        public string AST { get; set; }
        [MoTaDuLieu("ALT")]
        public string ALT { get; set; }
        [MoTaDuLieu("Bilirubin TP")]
        public string Bilirubin_TP { get; set; }
        [MoTaDuLieu("Bilirubin TT")]
        public string Bilirubin_TT { get; set; }
        [MoTaDuLieu("GT")]
        public string GT { get; set; }
        [MoTaDuLieu("PT")]
        public string PT { get; set; }
        [MoTaDuLieu("Albumin")]
        public string Albumin { get; set; }
        [MoTaDuLieu("αFP")]
        public string AlphaFP { get; set; }
        [MoTaDuLieu("Creatinin")]
        public string Creatinin { get; set; }
        [MoTaDuLieu("Đường máu")]
        public string DuongMau { get; set; }
        [MoTaDuLieu("CTM: HC")]
        public string CTM_HC { get; set; }
        [MoTaDuLieu("CTM: BC")]
        public string CTM_BC { get; set; }
        [MoTaDuLieu("CTM: TC")]
        public string CTM_TC { get; set; }
        [MoTaDuLieu("CTM: HB")]
        public string CTM_HB { get; set; }
        [MoTaDuLieu("2. Siêu âm bụng: Gan")]
        public string SieuAmBung_Gan { get; set; }
        [MoTaDuLieu("TMC")]
        public string TMC { get; set; }
        [MoTaDuLieu("Lách")]
        public string Lach { get; set; }
        [MoTaDuLieu("TML")]
        public string TML { get; set; }
        [MoTaDuLieu("3. Soi dạ dày - thực quản, 1-> không, 2-> có")]
        public int SoiDaDayThucQuan { get; set; }
        [MoTaDuLieu("Giãn TMTQ, 1-> không, 2-> có")]
        public int GianTMTQ { get; set; }
        [MoTaDuLieu("4. Xét nghiệm khác")]
        public string XetNghiemKhac { get; set; }
        //F. CHẨN ĐOÁN
        [MoTaDuLieu("- Mang HbsAg mạn")]
        public int MangHbsAgMan { get; set; }

        [MoTaDuLieu("- VGSVB mạn TT:")]
        public int VGSVBManTT { get; set; }
        [MoTaDuLieu("- VGSVB mạn - xơ gan còn bù:")]
        public int VGSVBManXoGanConBu { get; set; }
        [MoTaDuLieu("- VGSVB mạn - xơ gan mất bù:")]
        public int VGSVBManXoGanMatBu { get; set; }
        [MoTaDuLieu("- VGSVB mạn - K gan, 1-> không, 2-> có")]
        public int VGSVBManKGan { get; set; }
        [MoTaDuLieu("G. Điều trị")]
        public string DieuTri { get; set; }
        [MoTaDuLieu("Hẹn khám lại")]
        public DateTime? HenKhamLai { get; set; }
        [MoTaDuLieu("Hẹn xét nghiệm lại")]
        public DateTime? HenXetNghiemLai { get; set; }
        [MoTaDuLieu("Bác sỹ điều trị")]
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
