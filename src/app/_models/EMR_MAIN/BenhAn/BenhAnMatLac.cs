using EMR.KyDienTu;
using EMR_MAIN.DATABASE;
using PMS.Access;
using System;

namespace EMR_MAIN
{
    public class BenhAnMatLac : BenhAnBase, IBase
    {
        public int IDMauPhieu { get; set; } = (int)DanhMucPhieu.BAMLac;
        public string TenMauPhieu { get; set; } = DanhMucPhieu.BAMLac.Description();
        public string ThiLucKhiVaoVien_KhongKinh_MP { get; set; }
        public string ThiLucKhiVaoVien_KhongKinh_MT { get; set; }
        public string ThiLucKhiVaoVien_CoKinh_MP { get; set; }
        public string ThiLucKhiVaoVien_CoKinh_MT { get; set; }
        public string NhanApVaoVien_MT { get; set; }
        public string NhanApVaoVien_MP { get; set; }
        public string ThiTruong_MP { get; set; }
        public string ThiTruong_MT { get; set; }
        public bool LyDoVaoVien_Lac { get; set; }
        public bool LyDoVaoVien_SupMi { get; set; }
        public bool LyDoVaoVien_Khac { get; set; }
        public bool QuaTrinhBenhLy_NguyenNhan { get; set; }
        public string NguyenNhan_TuBaoGio { get; set; }
        public int TrieuChungChinh { get; set; }
        public bool TrieuChung_SupMi { get; set; }
        public bool TrieuChung_RungGiatNhanCau { get; set; }
        public bool TrieuChung_Khac { get; set; }
        public string TrieuChung_Khac_Text { get; set; }
        public bool DaDieuTri_TapNhuocThi { get; set; }
        public string TapNhuocThi_PhuongPhap { get; set; }
        public int TapNhuocThi_KetQua { get; set; }
        public bool DaDieuTri_PhauThuat { get; set; }
        public string DaDieuTri_PhauThuat_PhuongPhap { get; set; }
        public bool KetQua_PhauThuat_Tot { get; set; }
        public bool KetQua_PhauThuat_MoNon { get; set; }
        public string KetQua_PhauThuat_MoNon_Text { get; set; }
        public bool KetQua_PhauThuat_MoGia { get; set; }
        public string KetQua_PhauThuat_MoGiaText { get; set; }
        public bool TienSuBenhBanThan_Tick { get; set; }
        public bool TienSuBenhGiaDinh_Tick { get; set; }
        public string KhucXaMay_TruocAtropine_MP { get; set; }
        public string KhucXaMay_SauAtropine_MP { get; set; }
        public string KhucXaMay_SauAtropine_MT { get; set; }
        public string KhucXaMay_TruocAtropine_MT { get; set; }
        public bool VanNhanNoiTai_MP { get; set; }
        public string VanNhanNoiTai_Text_MP { get; set; }
        public bool VanNhanNoiTai_MT { get; set; }
        public string VanNhanNoiTai_TextMT { get; set; }
        public bool DiemCanQuyTu { get; set; }
        public string DiemCanQuyTu_Text { get; set; }
        public bool RungGiatNhanCau { get; set; }
        public string RungGiatNhanCau_Text { get; set; }
        public string KieuRGNC { get; set; }
        public bool GocHam { get; set; }
        public int ThiNghiemCheMat { get; set; }
        public string HinhThaiVaTinhChatLac { get; set; }
        public string Hirschberg_Truoc_atropine { get; set; }
        public string Hirschberg_Sau_atropine { get; set; }
        public string LangKinh_Truoc_atropine { get; set; }
        public string LangKinh_Sau_atropine { get; set; }
        public string NhinGan { get; set; }
        public string NhinLen { get; set; }
        public string NhinXa { get; set; }
        public string NhinXuong { get; set; }
        public string HoiChung { get; set; }
        public string Synoptophore_KhacQuan { get; set; }
        public string Synoptophore_ChuQuan { get; set; }
        public int TinhTrangThiGiacHaiMat { get; set; }
        public string TinhTrangThiGiacHaiMat_Text { get; set; }
        public string BienDoHopThi { get; set; }
        public bool TuongUngVongMac { get; set; }
        public bool SongThi { get; set; }
        public string SongThi_Text { get; set; }
        public bool TuTheBuTru { get; set; }
        public string TuTheBuTru_Text { get; set; }
        public bool MiMat_MP { get; set; }
        public bool SupMi_MP { get; set; }
        public int SupMi_MucDo_MP { get; set; }
        public bool Epicanthus_MP { get; set; }
        public int CoNangMi_MP { get; set; }
        public bool Marcusgunn_MP { get; set; }
        public bool Bell_MP { get; set; }
        public string Khac_MiMat_MP { get; set; }
        public bool KetMac_MP { get; set; }
        public string KetMac_Text_MP { get; set; }
        public bool PhanNhanCauTruoc_MP { get; set; }
        public string PhanNhanCauTruoc_Text_MP { get; set; }
        public bool PhanNhanCauSau_MP { get; set; }
        public string PhanNhanCauSau_Text_MP { get; set; }
        public int DinhThi_MP { get; set; }
        public bool MiMat_MT { get; set; }
        public bool SupMi_MT { get; set; }
        public int SupMi_MucDo_MT { get; set; }
        public bool Epicanthus_MT { get; set; }
        public int CoNangMi_MT { get; set; }
        public bool Marcusgunn_MT { get; set; }
        public bool Bell_MT { get; set; }
        public string Khac_MiMat_MT { get; set; }
        public bool KetMac_MT { get; set; }
        public string KetMac_Text_MT { get; set; }
        public bool PhanNhanCauTruoc_MT { get; set; }
        public string PhanNhanCauTruoc_Text_MT { get; set; }
        public bool PhanNhanCauSau_MT { get; set; }
        public string PhanNhanCauSau_Text_MT { get; set; }
        public int DinhThi_MT { get; set; }
        public string HuyetAp_ToanThan { get; set; }
        public string NhietDo_ToanThan { get; set; }
        public string Mach_ToanThan { get; set; }
        public bool NoiTiet_Tick { get; set; }
        public string NoiTiet { get; set; }
        public bool ThanKinh_Tick { get; set; }
        public bool TuanHoan_Tick { get; set; }
        public bool HoHap_Tick { get; set; }
        public bool TieuHoa_Tick { get; set; }
        public bool CoXuongKhop_Tick { get; set; }
        public bool ThanTietNieu_Tick { get; set; }
        public string MaICD_BenhChinh { get; set; }
        public string MaICD_BenhKemTheo { get; set; }
        public string PhuongPhapChinh { get; set; }
        public string CheDoAnUong { get; set; }
        public string CheDoChamSoc { get; set; }
        public string ChanDoanBenhChinh_LamSang { get; set; }
        public string ChanDoanBenhChinh_NguyenNhan { get; set; }
        public string QuaTrinhDieuTri_NoiKhoa { get; set; }
        public bool PhauThuat { get; set; }
        public bool ThuThuat { get; set; }
        public string ThiLucRaVienKhongKinhMPTongKet { get; set; }
        public string ThiLucRaVienKhongKinhMTTongKet { get; set; }
        public string ThiLucRaVienCoKinhMPTongKet { get; set; }
        public string ThiLucRaVienCoKinhMTTongKet { get; set; }
        public string NhanApRaVienMPTongKet { get; set; }
        public string NhanApRaVienMTTongKet { get; set; }
        public string HuongDieuTriTiep { get; set; }
        public bool ChuaThayBenhLy { get; set; }
        public bool BenhLy { get; set; }
        public string BenhLy_Text { get; set; }
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
        //https://redmine.vietsens.vn/redmine/issues/69896
        public bool[] NoiTiet_Array { get; } = new bool[] { false, false };
        public int NoiTietCheck
        {
            get
            {
                return Array.IndexOf(NoiTiet_Array, true) + 1;
            }
            set
            {
                for (int i = 0; i < NoiTiet_Array.Length; i++)
                {
                    if (i == (value - 1)) NoiTiet_Array[i] = true;
                    else NoiTiet_Array[i] = false;
                }
            }
        }
        public string NoiTiet_Text { get; set; }
        public bool[] ThanKinh_Array { get; } = new bool[] { false, false };
        public int ThanKinhCheck
        {
            get
            {
                return Array.IndexOf(ThanKinh_Array, true) + 1;
            }
            set
            {
                for (int i = 0; i < ThanKinh_Array.Length; i++)
                {
                    if (i == (value - 1)) ThanKinh_Array[i] = true;
                    else ThanKinh_Array[i] = false;
                }
            }
        }
        public string ThanKinh_Text { get; set; }
        public bool[] TuanHoan_Array { get; } = new bool[] { false, false };
        public int TuanHoanCheck
        {
            get
            {
                return Array.IndexOf(TuanHoan_Array, true) + 1;
            }
            set
            {
                for (int i = 0; i < TuanHoan_Array.Length; i++)
                {
                    if (i == (value - 1)) TuanHoan_Array[i] = true;
                    else TuanHoan_Array[i] = false;
                }
            }
        }
        public string TuanHoan_Text { get; set; }
        public bool[] HoHap_Array { get; } = new bool[] { false, false };
        public int HoHapCheck
        {
            get
            {
                return Array.IndexOf(HoHap_Array, true) + 1;
            }
            set
            {
                for (int i = 0; i < HoHap_Array.Length; i++)
                {
                    if (i == (value - 1)) HoHap_Array[i] = true;
                    else HoHap_Array[i] = false;
                }
            }
        }
        public string HoHap_Text { get; set; }
        public bool[] TieuHoa_Array { get; } = new bool[] { false, false };
        public int TieuHoaCheck
        {
            get
            {
                return Array.IndexOf(TieuHoa_Array, true) + 1;
            }
            set
            {
                for (int i = 0; i < TieuHoa_Array.Length; i++)
                {
                    if (i == (value - 1)) TieuHoa_Array[i] = true;
                    else TieuHoa_Array[i] = false;
                }
            }
        }
        public string TieuHoa_Text { get; set; }
        public bool[] CoXuongKhop_Array { get; } = new bool[] { false, false };
        public int CoXuongKhopCheck
        {
            get
            {
                return Array.IndexOf(CoXuongKhop_Array, true) + 1;
            }
            set
            {
                for (int i = 0; i < CoXuongKhop_Array.Length; i++)
                {
                    if (i == (value - 1)) CoXuongKhop_Array[i] = true;
                    else CoXuongKhop_Array[i] = false;
                }
            }
        }
        public string CoXuongKhop_Text { get; set; }
        public bool[] TietNieuSinhDuc_Array { get; } = new bool[] { false, false };
        public int TietNieuSinhDucCheck
        {
            get
            {
                return Array.IndexOf(TietNieuSinhDuc_Array, true) + 1;
            }
            set
            {
                for (int i = 0; i < TietNieuSinhDuc_Array.Length; i++)
                {
                    if (i == (value - 1)) TietNieuSinhDuc_Array[i] = true;
                    else TietNieuSinhDuc_Array[i] = false;
                }
            }
        }
        public string TietNieuSinhDuc_Text { get; set; }
        public string KhamBenhToanThan_Khac { get; set; }
    }
}
