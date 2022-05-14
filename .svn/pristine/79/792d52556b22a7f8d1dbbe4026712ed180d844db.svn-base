using EMR.KyDienTu;
using PMS.Access;
using System;

namespace EMR_MAIN.DATABASE.BenhAn
{
    public class BenhAnNgoaiTruPHCN : BenhAnBase, IBase
    {
        public int IDMauPhieu { get; set; } = (int)DanhMucPhieu.BANgTruPHCN;
        public string TenMauPhieu { get; set; } = DanhMucPhieu.BANgTruPHCN.Description();
        public string TienSuBenhDiUng { set; get; }
        public string TenKhoa { set; get; }
        public string CacBoPhan { set; get; }
        public string TomTatKetQuaCanLamSang { set; get; }
        public string ChanDoanBanDau { set; get; }
        public string DaXuLy { set; get; }
        public string ChanDoanKhiRaVien { set; get; }
        public DateTime DieuTriNgoaiTru_TuNgay { set; get; }
        public DateTime DieuTriNgoaiTru_DenNgay { set; get; }
        public string IDGiamDoc { set; get; }
        public string MaICD_BenhChinh { set; get; }
        public string MaICD_BenhKemTheo { set; get; }
        public string MAIDC_ChanDoanKhiRaVien { set; get; }
        public bool[] CNKhuyetTatArray { get; } = new bool[] { false, false };
        public int CNKhuyetTat
        {
            get
            {
                return Array.IndexOf(CNKhuyetTatArray, true) + 1;
            }
            set
            {
                for (int i = 0; i < CNKhuyetTatArray.Length; i++)
                {
                    if (i == (value - 1)) CNKhuyetTatArray[i] = true;
                    else CNKhuyetTatArray[i] = false;
                }
            }
        }
        public string DangKhuyetTuat { get; set; }
        public string MucDoKT { get; set; }
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
