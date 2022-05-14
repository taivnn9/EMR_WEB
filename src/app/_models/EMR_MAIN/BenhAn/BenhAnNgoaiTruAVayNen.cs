using EMR.KyDienTu;
using EMR_MAIN.DATABASE;
using PMS.Access;
using System;

namespace EMR_MAIN
{
    public class BenhAnNgoaiTruAVayNen : BenhAnBase, IBase
    {
        public int IDMauPhieu { get; set; } = (int)DanhMucPhieu.BANgTruAVN;
        public string TenMauPhieu { get; set; } = DanhMucPhieu.BANgTruAVN.Description();
        public int HB_TGPhatBenh { set; get; }
        public string HB_TrieuTrungDauTien { set; get; }
        public int HB_TGBiDayDa { set; get; }
        public string HB_QuaTrinhBenhLy { set; get; }
        public string HB_DieuTriTruocDay { set; get; }
        public string HB_TSBT_TGMacBenh { set; get; }
        public string HB_TSBT_BenhDaKhac { set; get; }
        public string HB_TSBT_BenhNoiKhoaKhac { set; get; }
        public string HB_TienSuGiaDinh { set; get; }
        public string HB_TrieuCoNang { set; get; }
        public string HB_LS_Mach { set; get; }
        public string HB_LS_HuyetAp { set; get; }
        public string HB_LS_NhietDo { set; get; }
        public string HB_LS_NhipTho { set; get; }
        public string HB_LS_TimMach { set; get; }
        public string HB_LS_HoHap { set; get; }
        public string HB_LS_TieuHoa { set; get; }
        public string HB_LS_ThanTietNieu { set; get; }
        public string HB_LS_CoXuongKhop { set; get; }
        public string HB_LS_BoPhanKhac { set; get; }
        public string HB_LS_TTDaKichThuoc { set; get; }
        public int DatDo_KichThuoc { set; get; }
        public int DatDo_HinhDang { set; get; }
        public int DatDo_RanhGioi { set; get; }
        public int DatDo_MauSac { set; get; }
        public int VayDa { set; get; }
        public string DatDo_HinhDang_Khac { set; get; }
        public string DatDo_MauSac_Khac { set; get; }
        public string ViTri_Khac { set; get; }
        public int ViTri { set; get; }
        public int PhanBo { set; get; }
        public string PhanBo_Khac { set; get; }
        public int PoKi { set; get; }
        public int DHGanXi { set; get; }
        public string CTM1 { set; get; }
        public string CTM2 { set; get; }
        public string CTM3 { set; get; }
        public string CTM4 { set; get; }
        public string CTM5 { set; get; }
        public string MauLang1 { set; get; }
        public string MauLang2 { set; get; }
        public string SHM1 { set; get; }
        public string SHM2 { set; get; }
        public string SHM3 { set; get; }
        public string SHM4 { set; get; }
        public string SHM5 { set; get; }
        public string SHM6 { set; get; }
        public string SHM7 { set; get; }
        public string SHM8 { set; get; }
        public string SHM9 { set; get; }
        public string SHM10 { set; get; }
        public string SHM11 { set; get; }
        public string SHM12 { set; get; }
        public string SHM13 { set; get; }
        public string SHM14 { set; get; }
        public int ST_TB { set; get; }
        public string ST_TB_LoaiTeBao { set; get; }
        public int ST_TrungBi { set; get; }
        public int HoaMoMienDich { set; get;}
        public string NuocTieu_Protein { set; get; }
        public string NuocTieu_Duong { set; get; }
        public string NuocTieu_HC { set; get; }
        public string NuocTieu_BC { set; get; }
        public string NuocTieu_NIT { set; get; }
        public string NuocTieu_TBTru { set; get; }
        public string HIV { set; get; }
        public string HB_CacXetNghiemKhac { set; get; }
        public int ChanDoan { set; get; }
        public string HB_DieuTri { set; get; }
        public DateTime NgayTaiKham { set; get; }
        public string KB_Mach { set; get; }
        public string KB_NhipTho { set; get; }
        public string KB_HuyetAp { set; get; }
        public string BoPhan_ThuongTonDa { set; get; }
        public string KB_TimMach { set; get; }
        public string KB_HoHap { set; get; }
        public string KB_TieuHoa { set; get; }
        public string KB_ThanTietNieu { set; get; }
        public string KB_CoXuongKhop { set; get; }
        public string KB_BoPhanKhac { set; get; }
        public string KB_CTM1 { set; get; }
        public string KB_CTM2 { set; get; }
        public string KB_CTM3 { set; get; }
        public string KB_CTM4 { set; get; }
        public string KB_CTM5 { set; get; }
        public string KB_MauLang1 { set; get; }
        public string KB_MauLang2 { set; get; }
        public string KB_SHM1 { set; get; }
        public string KB_SHM2 { set; get; }
        public string KB_SHM3 { set; get; }
        public string KB_SHM4 { set; get; }
        public string KB_SHM5 { set; get; }
        public string KB_SHM6 { set; get; }
        public string KB_SHM7 { set; get; }
        public string KB_SHM8 { set; get; }
        public string KB_SHM9 { set; get; }
        public string KB_SHM10 { set; get; }
        public string KB_SHM11 { set; get; }
        public string KB_SHM12 { set; get; }
        public string KB_SHM13 { set; get; }
        public string KB_SHM14 { set; get; }
        public string KB_NuocTieu_Protein { set; get; }
        public string KB_NuocTieu_Duong { set; get; }
        public string KB_NuocTieu_HC { set; get; }
        public string KB_NuocTieu_BC { set; get; }
        public string KB_NuocTieu_NIT { set; get; }
        public string KB_NuocTieu_TBTru { set; get; }
        public int KB_ST_TB { set; get; }
        public string KB_ST_TB_LoaiTeBao { set; get; }
        public int KB_ST_TrungBi { set; get; }
        public string KB_CacXetNghiemKhac { set; get; }
        public string KB_DieuTri { set; get; }
        public string ChanDoan_BenhKemTheo { set; get; }
        public string ChanDoan_BenhChinh { set; get; }

        public DateTime KB_NgayTaiKham { set; get; }
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
