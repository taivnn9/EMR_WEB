using EMR.KyDienTu;
using EMR_MAIN.DATABASE;
using PMS.Access;
using System;
using System.Collections.ObjectModel;

namespace EMR_MAIN
{
    public class ThongTinYLenh
    {
        public DateTime NgayGio { get; set; }
        public string DienBienBenh { get; set; }
        public string YLenh { get; set; }
    }
    public class BenhAnLuuCapCuu : BenhAnBase, IBase
    {
        public int IDMauPhieu { get; set; } = (int)DanhMucPhieu.BALCC;
        public string TenMauPhieu { get; set; } = DanhMucPhieu.BALCC.Description();
        public string TenKhoa { set; get; }
        public string CacBoPhan { set; get; }
        public string TomTatKetQuaCanLamSang { set; get; }
        public string ChanDoanBanDau { set; get; }
        public string DaXuLy { set; get; }
        public string ChanDoanKhiRaVien { set; get; }
        public DateTime RaVienLuc { set; get; }
        public bool KeToa { get; set; }
        public bool Khoi { get; set; }
        public bool TronVien { get; set; }
        public string MAIDC_ChanDoanKhiRaVien { set; get; }
        public ObservableCollection<ThongTinYLenh> ThongTinYLenhs { get; set; }
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
