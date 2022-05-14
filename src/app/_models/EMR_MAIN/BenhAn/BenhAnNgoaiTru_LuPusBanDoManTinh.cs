using EMR.KyDienTu;
using PMS.Access;
using System;

namespace EMR_MAIN.DATABASE.BenhAn
{
    public class BenhAnNgoaiTru_LuPusBanDoManTinh : IBase
    {
        public int IDMauPhieu { get; set; } = (int)DanhMucPhieu.BANgoaiTruLuPusBDMT;
        public string TenMauPhieu { get; set; } = DanhMucPhieu.BANgoaiTruLuPusBDMT.Description();
        public decimal IDBenhAnNTLuPus { get; set; }
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

        // hoibenh
        // 1. Bệnh sử - tiền sử
        public string HB_CanNang { get; set; }
        public string HB_ChieuCao { get; set; }
        public string TG_KhoiPhatBenh { get; set; }
        public string TrieuChungDauTien { get; set; }
        public int TSCN_BenhKhac { get; set; }
        public int CollagenOrTuMien { get; set; }
        public int XoCungBi { get; set; }
        public int ViemDaCoViemBiCo { get; set; }
        public int HoiChungSjogren { get; set; }
        public int XoGanMatTienPhat { get; set; }
        public int ViemTuyenGiapHashimoto { get; set; }
        public int HoiChungPhospholipid { get; set; }
        public int TSCN_BenhTuMienKhac { get; set; }
        public int TSCN_SoNguoiBenhTuMien { get; set; }
        public string TSCN_NoiDungKhac { get; set; }
        public string TSCN_CacBenhKhac { get; set; }
        public int TSCN_CacBenhKhac_Check { get; set; }
        public int TSGD_BenhTuMien { get; set; }
        public string TSGD_NoiDungBenhTuMien { get; set; }
        public string TSGD_NoiDungKhac { get; set; }
        public bool[] ToanTrangCoNangArray { get; } = new bool[] { false, false, false, false, false, false};
        public string ToanTrangCoNang
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < ToanTrangCoNangArray.Length; i++)
                    temp += (ToanTrangCoNangArray[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        ToanTrangCoNangArray[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public string TTCN_HuyetAp { get; set; }
        public string TTCN_NoiDungKhac { get; set; }
        public bool[] TonThuongDaNiemMacArray { get; } = new bool[] { false, false, false, false, false};
        public string TonThuongDaNiemMac
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < TonThuongDaNiemMacArray.Length; i++)
                    temp += (TonThuongDaNiemMacArray[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        TonThuongDaNiemMacArray[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public string TonThuongKhac { get; set; }
        public bool[] ViTriTonThuongArray { get; } = new bool[] { false, false, false, false, false };
        public string ViTriTonThuong
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < ViTriTonThuongArray.Length; i++)
                    temp += (ViTriTonThuongArray[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        ViTriTonThuongArray[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public string ViTriKhac { get; set; }
        public string DiemHoatDong { get; set; }
        public string DiemThietHai { get; set; }
        public string KCQKTimMach { get; set; }
        public string KCQKThanTietNieu { get; set; }
        public string KCQKHoHap { get; set; }
        public string KCQK_CXK { get; set; }
        public string KCQKTieuHoa { get; set; }
        public string KCQK_TKTT { get; set; }
        public string KCQKCacBoPhanKhac { get; set; }
        public string CTM_BachCau { get; set; }
        public string CTM_LymPho { get; set; }
        public string CTM_HC { get; set; }
        public string CTM_HB { get; set; }
        public string CTM_TieuCau { get; set; }
        public string MauLang1 { get; set; }
        public string MauLang2 { get; set; }
        public string SH_Creatimin { get; set; }
        public string SH_Ure { get; set; }
        public string SH_CRPhs { get; set; }
        public string SH_Protein { get; set; }
        public string SH_ALB { get; set; }
        public string SH_Cholesterol { get; set; }
        public string SH_Tri { get; set; }
        public string SH_GOT { get; set; }
        public string SH_GPT { get; set; }
        public int ProteinNieu { get; set; }
        public int TruNieu { get; set; }
        public int HCNieu { get; set; }
        public string NuocTieu24H { get; set; }
        public int BCNieu { get; set; }
        public int MienDich_ANA { get; set; }
        public string TXTMienDich_ANA { get; set; }
        public int MienDich_AntiDNA { get; set; }
        public string TXTMienDich_AntiDNA { get; set; }
        public int MienDich_PhosphoLiPid { get; set; }
        public string TXTMienDich_PhosphoLiPid { get; set; }
        public int MienDich_AntiSM { get; set; }
        public string TXTMienDich_AntiSM { get; set; }
        public int MienDich_Cardiolipin { get; set; }
        public string TXTMienDich_Cardiolipin { get; set; }
        public int MienDich_AntiSSA { get; set; }
        public string TXTMienDich_AntiSSA { get; set; }
        public int MienDich_KhangDongLuPus { get; set; }
        public string TXTMienDich_KhangDongLuPus { get; set; }
        public int MienDich_AntiSSB { get; set; }
        public string TXTMienDich_AntiSSB { get; set; }
        public int MienDich_Glycoptotein { get; set; }
        public string TXTMienDich_Glycoptotein { get; set; }
        public int MienDich_U1 { get; set; }
        public string TXTMienDich_U1 { get; set; }
        public int MienDich_Histone { get; set; }
        public string TXTMienDich_Histone { get; set; }
        public string TXTMienDich_KTKhac { get; set; }
        public string BT_C3 { get; set; }
        public string BT_C4 { get; set; }
        public int BTC4 { get; set; }
        public int BTC3 { get; set; }
        public int SinhThiet_Check { get; set; }
        public DateTime? SinhThiet_NgayLam { get; set; }
        public bool[] SinhThietDa_KQArray { get; } = new bool[] { false, false, false, false, false, false, false };
        public string SinhThietDa_KQ
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < SinhThietDa_KQArray.Length; i++)
                    temp += (SinhThietDa_KQArray[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        SinhThietDa_KQArray[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public string SinhThietDa_Khac { get; set; }
        public int LupusTest { get; set; }
        public int Lupus_NeuCo { get; set; }
        public string LupusMoTaDuongtinh { get; set; }
        public DateTime? KQKhamMat_Ngay { get; set; }
        public string KQKhamMat { get; set; }
        public string CacXetNghiemKhac { get; set; }
        public bool[] ChanDoanArray { get; } = new bool[] { false, false, false, false, false, false, false };
        public string ChanDoan
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < ChanDoanArray.Length; i++)
                    temp += (ChanDoanArray[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        ChanDoanArray[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public string ChanDoanKhac { get; set; }
        public string DieuTri { get; set; }
        public DateTime? HB_HenKhamLai { get; set; }
        public string MaBacSyKhamBenh { get; set; }
        public string BacSyKhamBenh { get; set; }

        //2. Khám bệnh
        public string TK_SoBADienTu { get; set; }
        public string TK_SoLuuTru { get; set; }
        public string TK_BacSiKham_LuuTru { get; set; }
        public DateTime? TK_NgayLuuTru { get; set; }
        public DateTime? TK_NgayLuuHuyetThanh { get; set; }
        public string TK_TienSu { get; set; }
        public string TK_Mach { get; set; }
        public string TK_HuyetAp { get; set; }
        public string TK_NhietDo { get; set; }
        public string TK_NhipTho { get; set; }
        public string TK_LamSangKhac { get; set; }
        public string TK_TonThuongDaNiemMac { get; set; }
        public string TK_DiemHoatDong { get; set; }
        public string TK_DiemThietHai { get; set; }
        public string TK_TimMach { get; set; }
        public string TK_ThanTietNieu { get; set; }
        public string TK_HoHap { get; set; }
        public string TK_CXK { get; set; }
        public string TK_TieuHoa { get; set; }
        public string TK_TKTT { get; set; }
        public string TK_CacBoPhanKhac { get; set; }
        public string TK_BachCau { get; set; }
        public string TK_LymPho { get; set; }
        public string TK_HC { get; set; }
        public string TK_HB { get; set; }
        public string TK_TieuCau { get; set; }
        public string TK_MauLang1 { get; set; }
        public string TK_MauLang2 { get; set; }
        public string TK_Creatimin { get; set; }
        public string TK_Ure { get; set; }
        public string TK_CRPhs { get; set; }
        public string TK_Protein { get; set; }
        public string TK_ALB { get; set; }
        public string TK_Cholesterol { get; set; }
        public string TK_Tri { get; set; }
        public string TK_GOT { get; set; }
        public string TK_GPT { get; set; }
        public int TK_ProteinNieu { get; set; }
        public int TK_TruNieu { get; set; }
        public int TK_HCNieu { get; set; }
        public int TK_BCNieu { get; set; }
        public string TK_NuocTieu24H { get; set; }
        public int TKMienDich_ANA { get; set; }
        public string TK_TXTMienDich_ANA { get; set; }
        public int TKMienDich_AntiDNA { get; set; }
        public string TK_TXTMienDich_AntiDNA { get; set; }
        public int TKMienDich_PhosphoLiPid { get; set; }
        public string TK_TXTMienDich_PhosphoLiPid { get; set; }
        public int TKMienDich_AntiSM { get; set; }
        public string TK_TXTMienDich_AntiSM { get; set; }
        public int TKMienDich_Cardiolipin { get; set; }
        public string TK_TXTMienDich_Cardiolipin { get; set; }
        public int TKMienDich_AntiSSA { get; set; }
        public string TK_TXTMienDich_AntiSSA { get; set; }
        public int TKMienDich_KhangDongLuPus { get; set; }
        public string TK_TXTMienDich_KhangDongLuPus { get; set; }
        public int TKMienDich_AntiSSB { get; set; }
        public string TK_TXTMienDich_AntiSSB { get; set; }
        public int TKMienDich_Glycoptotein { get; set; }
        public string TK_TXTMienDich_Glycoptotein { get; set; }
        public int TKMienDich_U1 { get; set; }
        public string TK_TXTMienDich_U1 { get; set; }
        public int TKMienDich_Histone { get; set; }
        public string TK_TXTMienDich_Histone { get; set; }
        public string TK_TXTMienDich_KTKhac { get; set; }
        public DateTime? TKKhamMat_Ngay { get; set; }
        public string TK_KhamMat { get; set; }
        public string TK_CacXetNghiemKhac { get; set; }
        public string TK_ChuY { get; set; }
        public string TK_DieuTri { get; set; }
        public DateTime? TK_HenKhamLai { get; set; }
        public string TK_MaBacSyDieuTri { get; set; }
        public string TK_BacSyDieuTri { get; set; }

        // Tổng kết bệnh án
        public string TK_QuaTrinhBenhLy { get; set; }
        public string TK_TomTatKetQua { get; set; }
        public string TK_BenhChinh { get; set; }
        public string TK_MaBenhChinh { get; set; }
        public string TK_BenhKemTheo { get; set; }
        public string TK_MaBenhKemTheo { get; set; }
        public string TK_PhuongPhapDieuTri { get; set; }
        public string TK_TinhTrangRaVien { get; set; }
        public string TK_HuongDieuTri { get; set; }
        public string NguoiNhanHoSo { get; set; }
        public string NguoiGiaoHoSo { get; set; }
        public DateTime? NgayTongKet { get; set; }
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
