using EMR.KyDienTu;
using EMR_MAIN.DATABASE;
using PMS.Access;
using System;

namespace EMR_MAIN
{
    public class BenhAnNgoaiTruRangHamMat : BenhAnBase, IBase
    {
        public int IDMauPhieu { get; set; } = (int)DanhMucPhieu.BANgTruRHM;
        public string TenMauPhieu { get; set; } = DanhMucPhieu.BANgTruRHM.Description();
        public bool PhauThuat { set; get; }
        public bool ThuThuat { set; get; }
        public string MaICD_BenhChinh { set; get; }
        public string MaICD_BenhKemTheo { set; get; }
        public string BenhChuyenKhoa { set; get; }
        public string Phai_HinhVe { set; get; }
        public string Thang_HinhVe { set; get; }
        public string Trai_HinhVe { set; get; }
        public string HamTrenVaHong_HinhVe { set; get; }
        public string HamDuoi_HinhVe { set; get; }
        public string PhanLoai_HinhVe { set; get; }
        public string ChuanDoanCuaKhoaKhamBenh { set; get; }
        public string DaXuLyCuaTuyenDuoi { set; get; }
        public DateTime DieuTriNgoaiTru_TuNgay { set; get; }
        public DateTime DieuTriNgoaiTru_DenNgay { set; get; }
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
