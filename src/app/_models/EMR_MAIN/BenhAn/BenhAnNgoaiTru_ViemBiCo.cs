using EMR.KyDienTu;
using PMS.Access;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMR_MAIN.DATABASE.BenhAn
{
    public class BenhAnNgoaiTru_ViemBiCo : IBase
    {
        public int IDMauPhieu { get; set; } = (int)DanhMucPhieu.BANgoaiTruHTSS;
        public string TenMauPhieu { get; set; } = DanhMucPhieu.BANgoaiTruHTSS.Description();
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
        // phần 1. bệnh sử, tiền sử
        public string Can { get; set; }
        public string GaySut_Kg { get; set; }
        public string GaySut_Thang { get; set; }
        public string GaySut_PhanTram { get; set; }
        public string Cao { get; set; }
        public string TuoiKhoiPhat { get; set; }
        [MoTaDuLieu("Thời gian từ khi khởi phát bệnh (tháng)")]
        public string TGTKKPB { get; set; }
        public string TrieuChungDauTien { get; set; }
        public int LupusBanDo { get; set; }
        public int XoCungBi { get; set; }
        public int ViemKhopDangThap { get; set; }
        public int HoiChungSjogren { get; set; }
        public int ViemBiCo { get; set; }
        public string TienSuBenhTuMien_Khac { get; set; }
        [MoTaDuLieu("Tiền sử cá nhân bị các bệnh khác")]
        public string TSCNBCBK_Text { get; set; }
        public int TSCNBCBK { get; set; }
        [MoTaDuLieu("Tiền sử gia đình có người bị bệnh tự miễn")]
        public int TSGDCNBBTM { get; set; }
        [MoTaDuLieu("Tiền sử gia đình có người bị bệnh tự miễn, nếu có")]
        public string TSGDCNBBTM_NeuCo { get; set; }
        public string BenhSu { get; set; }
        // phần 2.ĐIỀU TRỊ TRƯỚC ĐÂY
        [MoTaDuLieu("Chưa điều trị, 1 -> có, 0 -> không")]
        public int ChuaDieuTri { get; set; }
        [MoTaDuLieu("Nhóm thuốc làm thay đổi tiến triển bệnh (dùng trong những năm trước)")]
        // giá  trị bằng 1 -> Có, 2 -> Không, 3 -> không biết
        public int Dpenicillamine { get; set; }
        public string Dpenicillamine_CachDung { get; set; }
        public int Corticosteroid { get; set; }
        public string Corticosteroid_CachDung { get; set; }
        public int Cyclophosphamide { get; set; }
        public string Cyclophosphamide_CachDung { get; set; }
        public int Azathioprine { get; set; }
        public string Azathioprine_CachDung { get; set; }
        public int Methotrexate { get; set; }
        public string Methotrexate_CachDung { get; set; }
        public int ThuocKha { get; set; }
        public string ThuocKhac_CachDung { get; set; }
        public int TacDungPhuThuoc { get; set; }
        public string TacDungPhuThuoc_Co { get; set; }

        //3. TOÀN TRẠNG
        [MoTaDuLieu("Trạng thái sốt, 1 -> có , 2 -> không")]
        public int Sot { get; set; }
        public string Sot_Do { get; set; }
        public int MetMoi { get; set; }
        public string Mach { get; set; }
        public string HuyetAp { get; set; }
        public int HachTo { get; set; }
        public string HachTo_ViTri { get; set; }

        // 4.LÂM SÀNG DA-NIÊM MẠC-LÔNG TÓC MÓNG
        public int DatDo { get; set; }
        public string DatDo_ViTri { get; set; }
        public string MauSac_ViTri { get; set; }
        public int RuouVang { get; set; }
        public int DoTuoi { get; set; }
        public int DoTham { get; set; }
        public int MatPhuNe { get; set; }
        public int BanHeliotrope { get; set; }
        public int VSign { get; set; }
        public int HoslterSign { get; set; }
        public int ShawlSign { get; set; }
        public int LangDongCanxiODa { get; set; }
        public int GottronSign_BanTay { get; set; }
        public int GottronSign_KhuyuTay { get; set; }
        public int GottronSign_DauGoi { get; set; }
        public int GottronPapules_BanTay { get; set; }
        public int GottronPapules_KhuyuTay { get; set; }
        public int GottronPapules_DauGoi { get; set; }
        public int GianMachQuanhMong { get; set; }
        public int XuatHuyetQuanhMong { get; set; }
        public int NutNeQuanhMong { get; set; }
        public int MichanicHand { get; set; }
        public int RamLongTrenNenDatDo { get; set; }
        public string RamLongTrenNenDatDo_ViTri { get; set; }
        public int HienTuongRaynaud { get; set; }
        public int DauHieuPoikiloderma { get; set; }
        public string DauHieuPoikiloderma_ViTri { get; set; }
        public int VetLoetTrenDa { get; set; }
        public string VetLoetTrenDa_ViTri { get; set; }
        public string LamSangDa_Khac { get; set; }

        // 5.TRIỆU CHỨNG CƠ
        public int DauCo { get; set; }
        public string DauCo_Diem { get; set; }
        public string DauCo_ViTri { get; set; }
        public int BopCo { get; set; }
        public string BopCo_ViTri { get; set; }
        public int YeuCo { get; set; }
        public int TeoCo { get; set; }
        // 5.5 Cơ lực
        //Cơ gấp cánh tay 
        public TrieuChungCo CoGapCanhTay { get; set; }
        //Cơ duỗi cánh tay
        public TrieuChungCo CoDuoiCanhTay { get; set; }
        //Cơ gấp đùi
        public TrieuChungCo CoGapDui { get; set; }
        // Co duỗi đùi
        public TrieuChungCo CoDuoiDui { get; set; }

        // 6. Triệu chứng khớp
        public int DauKhop { get; set; }
        public string DauKhop_SoLuong { get; set; }
        public string DauKhop_ViTri { get; set; }
        public int SungKhop { get; set; }
        public string SungKhop_SoLuong { get; set; }
        public string SungKhop_ViTri { get; set; }
        public int BienDangKhop { get; set; }
        public string BienDangKhop_SoLuong { get; set; }
        public string BienDangKhop_ViTri { get; set; }

        // 7. PHỔI
        public bool[] KhoThoKhiGangSuc_Array { get; } = new bool[] { false, false, false, false };
        public string KhoThoKhiGangSuc
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < KhoThoKhiGangSuc_Array.Length; i++)
                    temp += (KhoThoKhiGangSuc_Array[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        KhoThoKhiGangSuc_Array[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public int KhoThoKhiNghiNgoi { get; set; }
        public int HoKhanKeoDai { get; set; }
        public int RanPhoiDoiXung { get; set; }
        public string Phoi_Khac { get; set; }


        // 8.TIM
        public int DanhTrongNguc { get; set; }
        public int NhipTim { get; set; }
        public string NhipTim_Khac { get; set; }
        public int DauHieuSuyTim { get; set; }
        public string DauHieuSuyTim_Co { get; set; }
        public string Tim_Khac { get; set; }

        // 9.ĐƯỜNG TIÊU HÓA
        public int NuotKhoNghenThucAnRan { get; set; }
        public int NuotKhoThucAnLongNuoc { get; set; }
        public int ONong { get; set; }
        public int ONongDauNguc { get; set; }
        public int DangChuaMieng { get; set; }
        public int NoiKhanDauViemHong { get; set; }
        public int HoKhiAn { get; set; }
        public int TaoBon { get; set; }
        public int TaoLongXenKe { get; set; }
        public string DuongTieuHoa_Khac { get; set; }

        //10. Thận- tiết niệu
        public int Phu { get; set; }
        public int TieuIt { get; set; }
        public int TieuMau { get; set; }
        public string ThanTietNieu_Khac { get; set; }

        //11.CẬN LÂM SÀNG
        public string CongThucMau_Bc { get; set; }
        public string CongThucMau_Tt { get; set; }
        public string CongThucMau_Lym { get; set; }
        public string CongThucMau_At { get; set; }
        public string CongThucMau_Hc { get; set; }
        public string CongThucMau_Hct { get; set; }
        public string CongThucMau_Hb { get; set; }
        public string CongThucMau_Tc { get; set; }
        public string MauLang_1h { get; set; }
        public string MauLang_2h { get; set; }
        public string SinhHoa_Ure { get; set; }
        public string SinhHoa_Choles { get; set; }
        public string SinhHoa_Na { get; set; }
        public string SinhHoa_Creatinin { get; set; }
        public string SinhHoa_Trigly { get; set; }
        public string SinhHoa_K { get; set; }
        public string SinhHoa_Glucose { get; set; }
        public string SinhHoa_Ldl { get; set; }
        public string SinhHoa_Cl { get; set; }
        public string SinhHoa_Uric { get; set; }
        public string SinhHoa_Hdl { get; set; }
        public string SinhHoa_Ast { get; set; }
        public string SinhHoa_BiltP { get; set; }
        public string SinhHoa_Pro { get; set; }
        public string SinhHoa_ALT { get; set; }
        public string SinhHoa_BiltT { get; set; }
        public string SinhHoa_Alb { get; set; }
        public string SinhHoa_Ck { get; set; }
        public string SinhHoa_CrpHs { get; set; }
        public string SinhHoa_CkMb { get; set; }
        public string SinhHoa_Khac { get; set; }
        public int NuocTieu_Protein { get; set; }
        public string NuocTieu_ProteinNieu24h { get; set; }
        public int NuocTieu_Hc { get; set; }
        public int NuocTieu_Bc { get; set; }
        public string NuocTieu_Khac { get; set; }
        public string CNHH_FVC { get; set; }
        public string CNHH_FEV1 { get; set; }
        public string CNHH_DuDoanFVC { get; set; }
        public string CNHH_FEV1FVC { get; set; }
        public string CNHH_DlCo { get; set; }
        public string CNHH_DuDoanDlCo { get; set; }
        public string XqTp { get; set; }
        public string HrCt { get; set; }
        public string SaOBung { get; set; }
        public string DienTim_TanSo { get; set; }
        public string DienTim_Nhip { get; set; }
        public string DienTim_Truc { get; set; }
        public string DiemTim_Khac { get; set; }
        public string SaTimEF { get; set; }
        public string SaTimPdmp { get; set; }
        public string SaTim_Khac { get; set; }

        // Các tự kháng thể
        public int KhangThe_Ana { get; set; }
        public string KhangThe_Ana_Duong { get; set; }
        public string KhangThe_Ana_Am { get; set; }
        public int KhangThe_Anti155140 { get; set; }
        public string KhangThe_Anti155140_Duong { get; set; }
        public string KhangThe_Anti155140_Am { get; set; }
        public int KhangThe_AntiPMScl { get; set; }
        public string KhangThe_AntiPMScl_Duong { get; set; }
        public string KhangThe_AntiPMScl_Am { get; set; }
        public int KhangThe_AntiARS { get; set; }
        public string KhangThe_AntiARS_Duong { get; set; }
        public string KhangThe_AntiARS_Am { get; set; }
        public int KhangThe_AntiCadm { get; set; }
        public string KhangThe_AntiCadm_Duong { get; set; }
        public string KhangThe_AntiCadm_Am { get; set; }
        public int KhangThe_Ku { get; set; }
        public string KhangThe_Ku_Duong { get; set; }
        public string KhangThe_Ku_Am { get; set; }
        public int KhangThe_dsDNA { get; set; }
        public string KhangThe_dsDNA_Duong { get; set; }
        public string KhangThe_dsDNA_Am { get; set; }
        public int KhangThe_AntiU1RNP { get; set; }
        public string KhangThe_AntiU1RNP_Duong { get; set; }
        public string KhangThe_AntiU1RNP_Am { get; set; }
        public int KhangThe_TIF1 { get; set; }
        public string KhangThe_TIF1_Duong { get; set; }
        public string KhangThe_TIF1_Am { get; set; }
        public int KhangThe_AntiJ01 { get; set; }
        public string KhangThe_AntiJ01_Duong { get; set; }
        public string KhangThe_AntiJ01_Am { get; set; }
        public int KhangThe_AntiSRP { get; set; }
        public string KhangThe_AntiSRP_Duong { get; set; }
        public string KhangThe_AntiSRP_Am { get; set; }
        public int KhangThe_antiNXP2 { get; set; }
        public string KhangThe_antiNXP2_Duong { get; set; }
        public string KhangThe_antiNXP2_Am { get; set; }
        public int KhangThe_AntiMi2 { get; set; }
        public string KhangThe_AntiMi2_Duong { get; set; }
        public string KhangThe_AntiMi2_Am { get; set; }
        public int KhangThe_AntiMDA5 { get; set; }
        public string KhangThe_AntiMDA5_Duong { get; set; }
        public string KhangThe_AntiMDA5_Am { get; set; }
        public int KhangThe_antiSAE { get; set; }
        public string KhangThe_antiSAE_Duong { get; set; }
        public string KhangThe_antiSAE_Am { get; set; }
        public string KhangThe_Khac { get; set; }
        public string KhamMat { get; set; }
        public string DienCoKim { get; set; }
        public string SinhThietCo { get; set; }
        // 12.TIÊU CHUẨN CHẨN ĐOÁN
        public bool[] BohanPeter_Array { get; } = new bool[] { false, false, false, false, false, false, false, false, false, false, false };
        public string BohanPeter
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < BohanPeter_Array.Length; i++)
                    temp += (BohanPeter_Array[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        BohanPeter_Array[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public bool[] Tanimoto_Array { get; } = new bool[] { false, false, false, false, false, false, false, false, false, false, false };
        public string Tanimoto
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < Tanimoto_Array.Length; i++)
                    temp += (Tanimoto_Array[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        Tanimoto_Array[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public bool[] MotSoThe_Array { get; } = new bool[] { false, false, false, false, false, false, false, false, false, false, false };
        public string MotSoThe
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < MotSoThe_Array.Length; i++)
                    temp += (MotSoThe_Array[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        MotSoThe_Array[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public string MotSoThe_Khac { get; set; }

        //14. ĐIỀU TRỊ	
        public TienSuDieuTri TS_Corticosteroid { get; set; }
        public TienSuDieuTri TS_Cyclophosphamid { get; set; }
        public TienSuDieuTri TS_CyclophosphamidLieuCao { get; set; }
        public TienSuDieuTri TS_Azathioprine { get; set; }
        public TienSuDieuTri TS_Methotrexate { get; set; }
        public TienSuDieuTri TS_CyclosporineA { get; set; }
        public string ThuocKhac { get; set; }
        public string DieuTriHienTai { get; set; }

        public DateTime? HenKham { get; set; }
        public string BacSyDieuTri { get; set; }
        public string MaBacSyDieuTri { get; set; }

        // Phần tái khám 
        //1. PHẦN LƯU TRỮ
        public string TK_SoBenhAnDienTu { get; set; }
        public string TK_SoLuuTru { get; set; }
        public DateTime? NgayKham { get; set; }
        public DateTime? NgayLuuHuyetThanh { get; set; }
        public string BacSiKham { get; set; }
        public string MaBacSiKham { get; set; }
        //2. TOÀN TRẠNG
        [MoTaDuLieu("Trạng thái sốt, 1 -> có , 2 -> không")]
        public int TK_Sot { get; set; }
        public string TK_Sot_Do { get; set; }
        public int TK_MetMoi { get; set; }
        public string TK_Mach { get; set; }
        public string TK_HuyetAp { get; set; }
        public int TK_HachTo { get; set; }
        public string TK_HachTo_ViTri { get; set; }
        //3. TIỀN SỬ
        public string TK_CoThemBenhGi { get; set; }

        //4.LÂM SÀNG DA-NIÊM MẠC-LÔNG TÓC MÓNG
        public int TK_DatDo { get; set; }
        public string TK_DatDo_ViTri { get; set; }
        public string TK_MauSac_ViTri { get; set; }
        public int TK_RuouVang { get; set; }
        public int TK_DoTuoi { get; set; }
        public int TK_DoTham { get; set; }
        public int TK_MatPhuNe { get; set; }
        public int TK_BanHeliotrope { get; set; }
        public int TK_VSign { get; set; }
        public int TK_HoslterSign { get; set; }
        public int TK_ShawlSign { get; set; }
        public int TK_LangDongCanxiODa { get; set; }
        public int TK_GottronSign_BanTay { get; set; }
        public int TK_GottronSign_KhuyuTay { get; set; }
        public int TK_GottronSign_DauGoi { get; set; }
        public int TK_GottronPapules_BanTay { get; set; }
        public int TK_GottronPapules_KhuyuTay { get; set; }
        public int TK_GottronPapules_DauGoi { get; set; }
        public int TK_GianMachQuanhMong { get; set; }
        public int TK_XuatHuyetQuanhMong { get; set; }
        public int TK_NutNeQuanhMong { get; set; }
        public int TK_MichanicHand { get; set; }
        public int TK_RamLongTrenNenDatDo { get; set; }
        public string TK_RamLongTrenNenDatDo_ViTri { get; set; }
        public int TK_HienTuongRaynaud { get; set; }
        public int TK_DauHieuPoikiloderma { get; set; }
        public string TK_DauHieuPoikiloderma_ViTri { get; set; }
        public int TK_VetLoetTrenDa { get; set; }
        public string TK_VetLoetTrenDa_ViTri { get; set; }
        //5.TRIỆU CHỨNG CƠ
        public int TK_DauCo { get; set; }
        public string TK_DauCo_Diem { get; set; }
        public string TK_DauCo_ViTri { get; set; }
        public int TK_BopCo { get; set; }
        public string TK_BopCo_ViTri { get; set; }
        public int TK_YeuCo { get; set; }
        public int TK_TeoCo { get; set; }
        // 5.5 Cơ lực
        //Cơ gấp cánh tay 
        public TrieuChungCo TK_CoGapCanhTay { get; set; }
        //Cơ duỗi cánh tay
        public TrieuChungCo TK_CoDuoiCanhTay { get; set; }
        //Cơ gấp đùi
        public TrieuChungCo TK_CoGapDui { get; set; }
        // Co duỗi đùi
        public TrieuChungCo TK_CoDuoiDui { get; set; }
        //6. Triệu chứng khớp
        public int TK_DauKhop { get; set; }
        public string TK_DauKhop_SoLuong { get; set; }
        public string TK_DauKhop_ViTri { get; set; }
        public int TK_SungKhop { get; set; }
        public string TK_SungKhop_SoLuong { get; set; }
        public string TK_SungKhop_ViTri { get; set; }
        public int TK_BienDangKhop { get; set; }
        public string TK_BienDangKhop_SoLuong { get; set; }
        public string TK_BienDangKhop_ViTri { get; set; }
        // 7. Phổi
        public bool[] TK_KhoThoKhiGangSuc_Array { get; } = new bool[] { false, false, false, false };
        public string TK_KhoThoKhiGangSuc
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < TK_KhoThoKhiGangSuc_Array.Length; i++)
                    temp += (TK_KhoThoKhiGangSuc_Array[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        TK_KhoThoKhiGangSuc_Array[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public int TK_KhoThoKhiNghiNgoi { get; set; }
        public int TK_HoKhanKeoDai { get; set; }
        public int TK_RanPhoiDoiXung { get; set; }
        public string TK_Phoi_Khac { get; set; }
        // 8.TIM
        public int TK_DanhTrongNguc { get; set; }
        public int TK_NhipTim { get; set; }
        public string TK_NhipTim_Khac { get; set; }
        public int TK_DauHieuSuyTim { get; set; }
        public string TK_DauHieuSuyTim_Co { get; set; }
        public string TK_Tim_Khac { get; set; }
        // 9. ĐƯỜNG TIÊU HÓA
        public int TK_NuotKhoNghenThucAnRan { get; set; }
        public int TK_NuotKhoThucAnLongNuoc { get; set; }
        public int TK_ONong { get; set; }
        public int TK_ONongDauNguc { get; set; }
        public int TK_DangChuaMieng { get; set; }
        public int TK_NoiKhanDauViemHong { get; set; }
        public int TK_HoKhiAn { get; set; }
        public int TK_TaoBon { get; set; }
        public int TK_TaoLongXenKe { get; set; }
        public string TK_DuongTieuHoa_Khac { get; set; }
        //11.CẬN LÂM SÀNG
        public string TK_CongThucMau_Bc { get; set; }
        public string TK_CongThucMau_Tt { get; set; }
        public string TK_CongThucMau_Lym { get; set; }
        public string TK_CongThucMau_At { get; set; }
        public string TK_CongThucMau_Hc { get; set; }
        public string TK_CongThucMau_Hct { get; set; }
        public string TK_CongThucMau_Hb { get; set; }
        public string TK_CongThucMau_Tc { get; set; }
        public string TK_MauLang_1h { get; set; }
        public string TK_MauLang_2h { get; set; }
        public string TK_SinhHoa_Ure { get; set; }
        public string TK_SinhHoa_Choles { get; set; }
        public string TK_SinhHoa_Na { get; set; }
        public string TK_SinhHoa_Creatinin { get; set; }
        public string TK_SinhHoa_Trigly { get; set; }
        public string TK_SinhHoa_K { get; set; }
        public string TK_SinhHoa_Glucose { get; set; }
        public string TK_SinhHoa_Ldl { get; set; }
        public string TK_SinhHoa_Cl { get; set; }
        public string TK_SinhHoa_Uric { get; set; }
        public string TK_SinhHoa_Hdl { get; set; }
        public string TK_SinhHoa_Ast { get; set; }
        public string TK_SinhHoa_BiltP { get; set; }
        public string TK_SinhHoa_Pro { get; set; }
        public string TK_SinhHoa_ALT { get; set; }
        public string TK_SinhHoa_BiltT { get; set; }
        public string TK_SinhHoa_Alb { get; set; }
        public string TK_SinhHoa_Ck { get; set; }
        public string TK_SinhHoa_CrpHs { get; set; }
        public string TK_SinhHoa_CkMb { get; set; }
        public string TK_SinhHoa_Khac { get; set; }
        public int TK_NuocTieu_Protein { get; set; }
        public string TK_NuocTieu_ProteinNieu24h { get; set; }
        public int TK_NuocTieu_Hc { get; set; }
        public int TK_NuocTieu_Bc { get; set; }
        public string TK_NuocTieu_Khac { get; set; }
        public string TK_CNHH_FVC { get; set; }
        public string TK_CNHH_FEV1 { get; set; }
        public string TK_CNHH_DuDoanFVC { get; set; }
        public string TK_CNHH_FEV1FVC { get; set; }
        public string TK_CNHH_DlCo { get; set; }
        public string TK_CNHH_DuDoanDlCo { get; set; }
        public string TK_XqTp { get; set; }
        public string TK_HrCt { get; set; }
        public string TK_SaOBung { get; set; }
        public string TK_DienTim_TanSo { get; set; }
        public string TK_DienTim_Nhip { get; set; }
        public string TK_DienTim_Truc { get; set; }
        public string TK_DiemTim_Khac { get; set; }
        public string TK_SaTimEF { get; set; }
        public string TK_SaTimPdmp { get; set; }
        public string TK_SaTim_Khac { get; set; }

        // Các tự kháng thể
        public int TK_KhangThe_Ana { get; set; }
        public string TK_KhangThe_Ana_Duong { get; set; }
        public string TK_KhangThe_Ana_Am { get; set; }
        public int TK_KhangThe_Anti155140 { get; set; }
        public string TK_KhangThe_Anti155140_Duong { get; set; }
        public string TK_KhangThe_Anti155140_Am { get; set; }
        public int TK_KhangThe_AntiPMScl { get; set; }
        public string TK_KhangThe_AntiPMScl_Duong { get; set; }
        public string TK_KhangThe_AntiPMScl_Am { get; set; }
        public int TK_KhangThe_AntiARS { get; set; }
        public string TK_KhangThe_AntiARS_Duong { get; set; }
        public string TK_KhangThe_AntiARS_Am { get; set; }
        public int TK_KhangThe_AntiCadm { get; set; }
        public string TK_KhangThe_AntiCadm_Duong { get; set; }
        public string TK_KhangThe_AntiCadm_Am { get; set; }
        public int TK_KhangThe_Ku { get; set; }
        public string TK_KhangThe_Ku_Duong { get; set; }
        public string TK_KhangThe_Ku_Am { get; set; }
        public int TK_KhangThe_dsDNA { get; set; }
        public string TK_KhangThe_dsDNA_Duong { get; set; }
        public string TK_KhangThe_dsDNA_Am { get; set; }
        public int TK_KhangThe_AntiU1RNP { get; set; }
        public string TK_KhangThe_AntiU1RNP_Duong { get; set; }
        public string TK_KhangThe_AntiU1RNP_Am { get; set; }
        public int TK_KhangThe_TIF1 { get; set; }
        public string TK_KhangThe_TIF1_Duong { get; set; }
        public string TK_KhangThe_TIF1_Am { get; set; }
        public int TK_KhangThe_AntiJ01 { get; set; }
        public string TK_KhangThe_AntiJ01_Duong { get; set; }
        public string TK_KhangThe_AntiJ01_Am { get; set; }
        public int TK_KhangThe_AntiSRP { get; set; }
        public string TK_KhangThe_AntiSRP_Duong { get; set; }
        public string TK_KhangThe_AntiSRP_Am { get; set; }
        public int TK_KhangThe_antiNXP2 { get; set; }
        public string TK_KhangThe_antiNXP2_Duong { get; set; }
        public string TK_KhangThe_antiNXP2_Am { get; set; }
        public int TK_KhangThe_AntiMi2 { get; set; }
        public string TK_KhangThe_AntiMi2_Duong { get; set; }
        public string TK_KhangThe_AntiMi2_Am { get; set; }
        public int TK_KhangThe_AntiMDA5 { get; set; }
        public string TK_KhangThe_AntiMDA5_Duong { get; set; }
        public string TK_KhangThe_AntiMDA5_Am { get; set; }
        public int TK_KhangThe_antiSAE { get; set; }
        public string TK_KhangThe_antiSAE_Duong { get; set; }
        public string TK_KhangThe_antiSAE_Am { get; set; }
        public string TK_KhangThe_Khac { get; set; }
        public string TK_KhamMat { get; set; }

        public string TK_ChuY { get; set; }
        public string TK_DieuTri { get; set; }
        public string TK_TacDungPhuCuaThuoc { get; set; }
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
    public class TrieuChungCo
    {
        public string CoLuc_0_P { get; set; }
        public string CoLuc_0_T { get; set; }
        public string CoLuc_1_P { get; set; }
        public string CoLuc_1_T { get; set; }
        public string CoLuc_2_P { get; set; }
        public string CoLuc_2_T { get; set; }
        public string CoLuc_3_P { get; set; }
        public string CoLuc_3_T { get; set; }
        public string CoLuc_4_P { get; set; }
        public string CoLuc_4_T { get; set; }
        public string CoLuc_5_P { get; set; }
        public string CoLuc_5_T { get; set; }
    }
    public class TienSuDieuTri
    {
        public int Co { get; set; }
        public int HienTaiConDung { get; set; }
        public string LieuHienTai { get; set; }
        public DateTime? NgayBatDau { get; set; }
        public string LieuKetThuc { get; set; }
        public DateTime? NgayKetThuc { get; set; }

    }
}
