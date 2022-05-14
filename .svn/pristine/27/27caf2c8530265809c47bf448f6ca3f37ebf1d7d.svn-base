using EMR.KyDienTu;
using EMR_MAIN.DATABASE;
using PMS.Access;

namespace EMR_MAIN
{
    public class BenhAnNhiKhoa : BenhAnBase, IBase
    {
        public int IDMauPhieu { get; set; } = (int)DanhMucPhieu.BANhiKhoa;
        public string TenMauPhieu { get; set; } = DanhMucPhieu.BANhiKhoa.Description();
        public string DinhDuong { get; set; }
        public int ConThuMay { get; set; }
        public string TienThaiPara { get; set; }
        public bool TienThaiParaSinh
        {
            get
            {
                try
                {
                    if (string.IsNullOrEmpty(TienThaiPara))
                        return false;
                    return TienThaiPara.Contains("1");
                }
                catch { return false; }
            }
            set
            {
                try
                {
                    if (value)
                        TienThaiPara += "1";
                    else if(TienThaiPara != null)
                        TienThaiPara = TienThaiPara.Replace("1", "");
                }
                catch { }
            }
        }
        public bool TienThaiParaSom
        {
            get
            {
                try
                {
                    if (string.IsNullOrEmpty(TienThaiPara))
                        return false;
                    return TienThaiPara.Contains("2");
                }
                catch { return false; }
            }
            set
            {
                try
                {
                    if (value)
                        TienThaiPara += "2";
                    else if (TienThaiPara != null)
                        TienThaiPara = TienThaiPara.Replace("2", "");
                }
                catch { }
            }
        }
        public bool TienThaiParaSay
        {
            get
            {
                try
                {
                    if (string.IsNullOrEmpty(TienThaiPara))
                        return false;
                    return TienThaiPara.Contains("3");
                }
                catch { return false; }
            }
            set
            {
                try
                {
                    if (value)
                        TienThaiPara += "3";
                    else if (TienThaiPara != null)
                        TienThaiPara = TienThaiPara.Replace("3", "");
                }
                catch { }
            }
        }
        public bool TienThaiParaSong
        {
            get
            {
                try
                {
                    if (string.IsNullOrEmpty(TienThaiPara))
                        return false;
                    return TienThaiPara.Contains("4");
                }
                catch { return false; }
            }
            set
            {
                try
                {
                    if (value)
                        TienThaiPara += "4";
                    else if (TienThaiPara != null)
                        TienThaiPara = TienThaiPara.Replace("4", "");
                }
                catch { }
            }
        }
        public int TinhTrangKhiSinhID { get; set; }
        public decimal CanNangLucSinh { get; set; }
        public string DiTatBamSinh_Text { get; set; }
        public bool DiTatBamSinh { get; set; }
        public string PhatTrienTinhThan { get; set; }
        public string PhatTrienVanDong { get; set; }
        public string CacBenhLyKhac { get; set; }
        public int NuoiDuongID { get; set; }
        public int CaiSuaThang { get; set; }
        public bool ChamSocID { get; set; }
        public string BenhKhacDuocTiemChungKhac { get; set; }
        public double ChieuCao { set; get; }
        public double VongNguc { set; get; }
        public double VongDau { set; get; }
        public bool Lao { get; set; }
        public bool BaiLiet { get; set; }
        public bool Soi { get; set; }
        public bool HoGa { get; set; }
        public bool UonVan { get; set; }
        public bool BachHau { get; set; }
        public bool TiemChungKhac { get; set; }
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
        public string ParaSinh { get; set; }
        public string ParaSom { get; set; }
        public string ParaSay { get; set; }
        public string ParaSong { get; set; }
        public string HoVaTenBo { get; set; }
        public string HoVaTenMe { get; set; }
    }
}
