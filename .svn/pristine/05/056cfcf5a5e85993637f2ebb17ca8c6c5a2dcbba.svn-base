using EMR.KyDienTu;
using EMR_MAIN.DATABASE;
using PMS.Access;
using System;

namespace EMR_MAIN
{
    public class BenhAnNgoaiTru : BenhAnBase, IBase
    {
        public int IDMauPhieu { get; set; } = (int)DanhMucPhieu.BANgTru;
        public string TenMauPhieu { get; set; } = DanhMucPhieu.BANgTru.Description();
        public string TenKhoa { set; get; }
        public string CacBoPhan { set; get; }
        public string TomTatKetQuaCanLamSang { set; get; }
        public string ChanDoanBanDau { set; get; }
        public string DaXuLy { set; get; }
        public string ChanDoanKhiRaVien { set; get; }
        public DateTime DieuTriNgoaiTru_TuNgay { set; get; }
        public DateTime DieuTriNgoaiTru_DenNgay { set; get; }
        public int IDGiamDoc { set; get; }
        public string MaICD_BenhChinh { set; get; }
        public string MaICD_BenhKemTheo { set; get; }
        public string MAIDC_ChanDoanKhiRaVien { set; get; }
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
