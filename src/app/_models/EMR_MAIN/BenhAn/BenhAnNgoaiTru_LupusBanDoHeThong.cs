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
    public class BenhAnNgoaiTru_LupusBanDoHeThong : IBase
    {
        public int IDMauPhieu { get; set; } = (int)DanhMucPhieu.BANgoaiTruLuPusBDMT;
        public string TenMauPhieu { get; set; } = DanhMucPhieu.BANgoaiTruLuPusBDMT.Description();
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
        public string Can { get; set; }
        public string Cao { get; set; }
        public string ThoiGianTuKhiKhoiPhat { get; set; }
        public string TrieuChungDauTien { get; set; }
        public int TienSuCoBenhTuMienKhac { get; set; }
        public int CoBenhCollagen { get; set; }
        public int XoCungBi { get; set; }
        public int ViemDaCo { get; set; }
        public int HoiChungSjogren { get; set; }
        public int XoGanMatTienPhat { get; set; }
        public int ViemTuyenGiap { get; set; }
        public int HoiChungKhangPhospholipid { get; set; }
        public string TienSuCoBenh_Khac { get; set; }
        public int TienSuCaNhan { get; set; }
        public string TienSuCaNhan_Co { get; set; }
        public int TienSuGiaDinh { get; set; }
        public string TienSuGiaDinh_Co { get; set; }
        public string TienSuGiaDinh_NeuCo { get; set; }
        //2. TOÀN TRẠNG
        [MoTaDuLieu("Trạng thái sốt, 1 -> có , 2 -> không")]
        public int Sot { get; set; }
        public int HachTo { get; set; }
        public int MetMoi { get; set; }
        public int LachTo { get; set; }
        public string HA { get; set; }
        //3. LÂM SÀNG DA, NIÊM MẠC
        public bool[] LamSangDaNiemMac_Array { get; } = new bool[] { false, false, false, false, false, false, false, false, false, false, false, false, false, false, false };
        public string LamSangDaNiemMac
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < LamSangDaNiemMac_Array.Length; i++)
                    temp += (LamSangDaNiemMac_Array[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        LamSangDaNiemMac_Array[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public string TonThuongKhac { get; set; }
        //4. BIỂU HIỆN CƠ	 
        public int YeuCoGoc { get; set; }
        public int TangCpk { get; set; }
        public string TangCpk_Co { get; set; }
        public int DienCoBatThuong { get; set; }
        public int SinhThietCoBatThuong { get; set; }
        //5. BIỂU HIỆN KHỚP
        public int DauKhop { get; set; }
        public string DauKhop_ViTri { get; set; }
        public string DauKhop_SoLuong { get; set; }
        public int SungKhop { get; set; }
        public string SungKhop_ViTri { get; set; }
        public string SungKhop_SoLuong { get; set; }
        public int CungKhop { get; set; }
        public string CungKhop_ViTri { get; set; }
        public string CungKhop_SoLuong { get; set; }
        //6. BIỂU HIỆN THẦN KINH
        public int DauDauNuaDau { get; set; }
        public int ViemMangNaoVoKhuan { get; set; }
        public int BenhMachNao { get; set; }
        public int MuaGiat { get; set; }
        public int DongKinh { get; set; }
        public int TrangThaiLuLanCapTinh { get; set; }
        public int RoiLoanLoAu { get; set; }
        public int RoiLoanChucNangNhanThuc { get; set; }
        public int TramCam { get; set; }
        public int AoTuongAoGiac { get; set; }
        public int HoiChungGuillainBarre { get; set; }
        public int RoiLoanThanKinhTuDong { get; set; }
        public int NhuocCoNang { get; set; }
        public int ViemDonDayThanKinh { get; set; }
        public int ViemDaDayThanKinh { get; set; }
        //7. TIM MẠCH
        public int ViemMangTim { get; set; }
        public int TranDichMangNgoaiTim { get; set; }
        public int DauHieuSuyTim { get; set; }
        public int BenhCoTim { get; set; }
        public int BenhVanTim { get; set; }
        public string BenhVanTim_NeuCo { get; set; }
        //8. HÔ HẤP
        public int ViemMangPhoi { get; set; }
        public int TranDichMangPhoi { get; set; }
        public int ViemPhoiCapTinh { get; set; }
        public int ViemPhoiKe { get; set; }
        public int ViemPheQuanTacNghen { get; set; }
        public int NhoiMauPhoi { get; set; }
        public int KhoiUAcTinhTaiPhoi { get; set; }
        //9. BIỂU HIỆN TIÊU HÓA
        public int Non { get; set; }
        public int DauHoiKhoTieu { get; set; }
        public int TieuChay { get; set; }
        public int DauBung { get; set; }
        public string BieuHienTieuHoa_Khac { get; set; }
        //10. XÉT NGHIỆM:
        public string CongThucMau_BachCau { get; set; }
        public string CongThucMau_Lympho { get; set; }
        public string CongThucMau_Hc { get; set; }
        public string CongThucMau_Hb { get; set; }
        public string CongThucMau_TieuCau { get; set; }
        public string TestCoombTrucTiep { get; set; }
        public string MauLang_1h { get; set; }
        public string MauLang_2h { get; set; }
        public string SinhHoa_Creatinin { get; set; }
        public string SinhHoa_Ure { get; set; }
        public string SinhHoa_ProteinToanPhan { get; set; }
        public string SinhHoa_Alb { get; set; }
        public string SinhHoa_Cholesterol { get; set; }
        public string SinhHoa_Tri { get; set; }
        public string SinhHoa_GOT { get; set; }
        public string SinhHoa_GPT { get; set; }
        public int NuocTieu_ProteinNieu { get; set; }
        public int NuocTieu_TruNieu { get; set; }
        public int NuocTieu_HCNieu { get; set; }
        public int NuocTieu_BCNieu { get; set; }
        public string NuocTieu_ProteinNieu24h { get; set; }
        public int TeBaoHargaves { get; set; }
        public string YeuToDangThapCARF { get; set; }

        //10.7. Xét nghiệm miễn dịch: 
        public int Ana { get; set; }
        public string Ana_Co { get; set; }
        public int AntidsDNA { get; set; }
        public string AntidsDNA_Co { get; set; }
        public int AntiPhospholipid { get; set; }
        public string AntiPhospholipid_Co { get; set; }
        public int AntiSm { get; set; }
        public string AntiSm_Co { get; set; }
        public int AntiCardiolipin { get; set; }
        public string AntiCardiolipin_Co { get; set; }
        public int AntiSSA { get; set; }
        public string AntiSSA_Co { get; set; }
        public int KhangDongLupus { get; set; }
        public string KhangDongLupus_Co { get; set; }
        public int AntiSSB { get; set; }
        public string AntiSSB_Co { get; set; }
        public int AntiB2Glycoptotein { get; set; }
        public string AntiB2Glycoptotein_Co { get; set; }
        public int AntiU1 { get; set; }
        public string AntiU1_Co { get; set; }
        public int AntiHistone { get; set; }
        public string AntiHistone_Co { get; set; }
        public string KTKhac { get; set; }
        public string TuKhangTheNeuCo { get; set; }
        public string TotalIgG { get; set; }
        public string C3_Text { get; set; }
        public int C3 { get; set; }
        public string C4_Text { get; set; }
        public int C4 { get; set; }
        public int SinhThietDa { get; set; }
        public int SinhThietDa_NeuCo { get; set; }
        public int LupusBandTest { get; set; }
        public int LupusBandTest_NeuCo { get; set; }
        public string LupusBandTest_DuongTinh { get; set; }
        public string SinhThietThan { get; set; }
        public DateTime? KhamMat_NgayKham { get; set; }
        public string KhamMat_KetQua { get; set; }
        //11. TIÊU CHUẨN CHẨN ĐOÁN
        //* ACR 1997
        public int BanDoHinhCanhBuom { get; set; }
        public int BanDoHinhDia { get; set; }
        public int NhayCamAnhSang { get; set; }
        public int LoetMieng { get; set; }
        public int ViemKhop { get; set; }
        public int ViemTranDichThanhMac { get; set; }
        public int RoiLoanChucNangThan { get; set; }
        public int RoiLoanThanKinhTamThan { get; set; }
        public int RoiLoanVeMau { get; set; }
        public int RoiLoanMienDich { get; set; }
        public int AnaDuongTinh { get; set; }
        public string Tong11TieuChuan { get; set; }
        //* SLICC 2012		Tiêu chuẩn lâm sàng
        public bool[] TieuChuanLamSang_Array { get; } = new bool[] { false, false, false, false, false, false, false, false, false, false, false };
        public string TieuChuanLamSang
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < TieuChuanLamSang_Array.Length; i++)
                    temp += (TieuChuanLamSang_Array[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        TieuChuanLamSang_Array[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        //* SLICC 2012 Tiêu chuẩn cận lâm sàng
        public bool[] TieuChuanCanLamSang_Array { get; } = new bool[] { false, false, false, false, false, false};
        public string TieuChuanCanLamSang
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < TieuChuanCanLamSang_Array.Length; i++)
                    temp += (TieuChuanCanLamSang_Array[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        TieuChuanCanLamSang_Array[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public string Tong17TieuChuan { get; set; }
        //12. ĐIỂM SLEDAI,
        //Thiết kế mỗi mục là một checkbox và gắn với biến int, dùng converter để chuyển từ trạng thái check về điểm, tổng điểm được tính theo tổng của các biến
        public int DiemSLEDAI_1 { get; set; }
        public int DiemSLEDAI_2 { get; set; }
        public int DiemSLEDAI_3 { get; set; }
        public int DiemSLEDAI_4 { get; set; }
        public int DiemSLEDAI_5 { get; set; }
        public int DiemSLEDAI_6 { get; set; }
        public int DiemSLEDAI_7 { get; set; }
        public int DiemSLEDAI_8 { get; set; }
        public int DiemSLEDAI_9 { get; set; }
        public int DiemSLEDAI_10 { get; set; }
        public int DiemSLEDAI_11 { get; set; }
        public int DiemSLEDAI_12 { get; set; }
        public int DiemSLEDAI_13 { get; set; }
        public int DiemSLEDAI_14 { get; set; }
        public int DiemSLEDAI_15 { get; set; }
        public int DiemSLEDAI_16 { get; set; }
        public int DiemSLEDAI_17 { get; set; }
        public int DiemSLEDAI_18 { get; set; }
        public int DiemSLEDAI_19 { get; set; }
        public int DiemSLEDAI_20 { get; set; }
        public int DiemSLEDAI_21 { get; set; }
        public int DiemSLEDAI_22 { get; set; }
        public int DiemSLEDAI_23 { get; set; }
        public int DiemSLEDAI_24 { get; set; }
        public string DiemSLEDAI_TongDiem { get; set; }
        // 13. ĐIỂM SLEQOL, lưu điểm của mỗi mục
        public int DiemSLEQOL_1 { get; set; }
        public int DiemSLEQOL_2 { get; set; }
        public int DiemSLEQOL_3 { get; set; }
        public int DiemSLEQOL_4 { get; set; }
        public int DiemSLEQOL_5 { get; set; }
        public int DiemSLEQOL_6 { get; set; }
        public int DiemSLEQOL_7 { get; set; }
        public int DiemSLEQOL_8 { get; set; }
        public int DiemSLEQOL_9 { get; set; }
        public int DiemSLEQOL_10 { get; set; }
        public int DiemSLEQOL_11 { get; set; }
        public int DiemSLEQOL_12 { get; set; }
        public int DiemSLEQOL_13 { get; set; }
        public int DiemSLEQOL_14 { get; set; }
        public int DiemSLEQOL_15 { get; set; }
        public int DiemSLEQOL_16 { get; set; }
        public int DiemSLEQOL_17 { get; set; }
        public int DiemSLEQOL_18 { get; set; }
        public int DiemSLEQOL_19 { get; set; }
        public int DiemSLEQOL_20 { get; set; }
        public int DiemSLEQOL_21 { get; set; }
        public int DiemSLEQOL_22 { get; set; }
        public int DiemSLEQOL_23 { get; set; }
        public int DiemSLEQOL_24 { get; set; }
        public int DiemSLEQOL_25 { get; set; }
        public int DiemSLEQOL_26 { get; set; }
        public int DiemSLEQOL_27 { get; set; }
        public int DiemSLEQOL_28 { get; set; }
        public int DiemSLEQOL_29 { get; set; }
        public int DiemSLEQOL_30 { get; set; }
        public int DiemSLEQOL_31 { get; set; }
        public int DiemSLEQOL_32 { get; set; }
        public int DiemSLEQOL_33 { get; set; }
        public int DiemSLEQOL_34 { get; set; }
        public int DiemSLEQOL_35 { get; set; }
        public int DiemSLEQOL_36 { get; set; }
        public int DiemSLEQOL_37 { get; set; }
        public int DiemSLEQOL_38 { get; set; }
        public int DiemSLEQOL_39 { get; set; }
        public int DiemSLEQOL_40 { get; set; }
        public string DiemSLEQOL_1_Text { get; set; }
        public string DiemSLEQOL_2_Text { get; set; }
        public string DiemSLEQOL_3_Text { get; set; }
        public string DiemSLEQOL_4_Text { get; set; }
        public string DiemSLEQOL_5_Text { get; set; }
        public string DiemSLEQOL_6_Text { get; set; }
        public string DiemSLEQOL_7_Text { get; set; }
        public string DiemSLEQOL_8_Text { get; set; }
        public string DiemSLEQOL_9_Text { get; set; }
        public string DiemSLEQOL_10_Text { get; set; }
        public string DiemSLEQOL_11_Text { get; set; }
        public string DiemSLEQOL_12_Text { get; set; }
        public string DiemSLEQOL_13_Text { get; set; }
        public string DiemSLEQOL_14_Text { get; set; }
        public string DiemSLEQOL_15_Text { get; set; }
        public string DiemSLEQOL_16_Text { get; set; }
        public string DiemSLEQOL_17_Text { get; set; }
        public string DiemSLEQOL_18_Text { get; set; }
        public string DiemSLEQOL_19_Text { get; set; }
        public string DiemSLEQOL_20_Text { get; set; }
        public string DiemSLEQOL_21_Text { get; set; }
        public string DiemSLEQOL_22_Text { get; set; }
        public string DiemSLEQOL_23_Text { get; set; }
        public string DiemSLEQOL_24_Text { get; set; }
        public string DiemSLEQOL_25_Text { get; set; }
        public string DiemSLEQOL_26_Text { get; set; }
        public string DiemSLEQOL_27_Text { get; set; }
        public string DiemSLEQOL_28_Text { get; set; }
        public string DiemSLEQOL_29_Text { get; set; }
        public string DiemSLEQOL_30_Text { get; set; }
        public string DiemSLEQOL_31_Text { get; set; }
        public string DiemSLEQOL_32_Text { get; set; }
        public string DiemSLEQOL_33_Text { get; set; }
        public string DiemSLEQOL_34_Text { get; set; }
        public string DiemSLEQOL_35_Text { get; set; }
        public string DiemSLEQOL_36_Text { get; set; }
        public string DiemSLEQOL_37_Text { get; set; }
        public string DiemSLEQOL_38_Text { get; set; }
        public string DiemSLEQOL_39_Text { get; set; }
        public string DiemSLEQOL_40_Text { get; set; }
        public string DiemSLEQOL_TongDiem { get; set; }
        // 14. ĐIỀU TRỊ
        // 14.1. Nhóm thuốc làm thay đổi tiến triển bệnh (dùng trong những năm trước)
        public ThuocToanThan Corticosteroid { get; set; }
        public ThuocToanThan KhangSotRet { get; set; }
        public ThuocToanThan Cyclophosphamide { get; set; }
        public ThuocToanThan CyclophosphamideLieuCao { get; set; }
        public ThuocToanThan Azathioprine { get; set; }
        public ThuocToanThan Methotrexate { get; set; }
        public ThuocToanThan CyclosporineA { get; set; }
        public ThuocToanThan ThuocKhac { get; set; }
        public string DieuTriHienTai { get; set; }
        public DateTime? HenKham { get; set; }
        public string BacSiDieuTri { get; set; }

        // phần TÁI KHÁM BỆNH LUPUS BAN ĐỎ HỆ THỐNG
        public string TK_SoBenhAnDienTu { get; set; }
        public string TK_SoLuuTru { get; set; }
        public DateTime? NgayKham { get; set; }
        public DateTime? NgayLuuHuyetThanh { get; set; }
        public string BacSiKham { get; set; }
        public string MaBacSiKham { get; set; }
        [MoTaDuLieu("Trạng thái sốt, 1 -> có , 2 -> không")]
        public int TK_Sot { get; set; }
        public int TK_HachTo { get; set; }
        public int TK_MetMoi { get; set; }
        public int TK_LachTo { get; set; }
        public string TK_HA { get; set; }
        public string TK_TienSu_BenhThem { get; set; }
        // phần 3. Lâm sàng
        public string TK_Da { get; set; }
        public string TK_Co { get; set; }
        public string TK_Khop { get; set; }
        public string TK_ThanKinh { get; set; }
        public string TK_TimMach { get; set; }
        public string TK_HoHap { get; set; }
        public string TK_TieuHoa { get; set; }
        public string TK_TrieuChungKhac { get; set; }
        //10. XÉT NGHIỆM:
        public string TK_CongThucMau_BachCau { get; set; }
        public string TK_CongThucMau_Lympho { get; set; }
        public string TK_CongThucMau_Hc { get; set; }
        public string TK_CongThucMau_Hb { get; set; }
        public string TK_CongThucMau_TieuCau { get; set; }
        public string TK_TestCoombTrucTiep { get; set; }
        public string TK_MauLang_1h { get; set; }
        public string TK_MauLang_2h { get; set; }
        public string TK_SinhHoa_Creatinin { get; set; }
        public string TK_SinhHoa_Ure { get; set; }
        public string TK_SinhHoa_ProteinToanPhan { get; set; }
        public string TK_SinhHoa_Alb { get; set; }
        public string TK_SinhHoa_Cholesterol { get; set; }
        public string TK_SinhHoa_Tri { get; set; }
        public string TK_SinhHoa_GOT { get; set; }
        public string TK_SinhHoa_GPT { get; set; }
        public int TK_NuocTieu_ProteinNieu { get; set; }
        public int TK_NuocTieu_TruNieu { get; set; }
        public int TK_NuocTieu_HCNieu { get; set; }
        public int TK_NuocTieu_BCNieu { get; set; }
        public string TK_NuocTieu_ProteinNieu24h { get; set; }
        public string TK_YeuToDangThap_Text { get; set; }
        public int TK_YeuToDangThap_Khong { get; set; }
        public string XuatHienTuKhangThe { get; set; }
        public DateTime? TK_KhamMat { get; set; }
        public string TK_KhamMat_KetQua { get; set; }
        public string TK_XetNghiemKhac { get; set; }
        public string TK_DiemSLEQOL_TongDiem { get; set; }
        public string TK_ChuY { get; set; }
        public string TK_DieuTri { get; set; }
        public DateTime? TK_HenKham { get; set; }
        public string TK_BacSiDieuTri { get; set; }
        public string TK_MaBacSiDieuTri { get; set; }

        // Phần tổng kết
        public string QuaTrinhBenhLy { get; set; }
        public string TomTatKetQua { get; set; }
        public string BenhChinh { get; set; }
        public string MaBenhChinh { get; set; }
        public string BenhKemTheo { get; set; }
        public string MaBenhKemTheo { get; set; }
        public string PhuongPhapDieuTri { get; set; }
        public string TinhTrangRaVien { get; set; }
        public string HuongDieuTri { get; set; }
        public string NguoiNhanHoSo { get; set; }
        public string NguoiGiaoHoSo { get; set; }
        public DateTime NgayTongKet { get; set; }
        public string TongKet_BacSyDieuTri { get; set; }
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
