using EMR.KyDienTu;
using PMS.Access;
using System;

namespace EMR_MAIN.DATABASE.BenhAn
{
    public class BenhAnPHCNII : BenhAnBase, IBase
    {
        public int IDMauPhieu { get; set; } = (int)DanhMucPhieu.BAPHCNII;
        public string TenMauPhieu { get; set; } = DanhMucPhieu.BAPHCNII.Description();
        public bool[] LoaiDieuTriArray { get; } = new bool[] { false, false};
        public string LoaiDieuTri
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < LoaiDieuTriArray.Length; i++)
                    temp += (LoaiDieuTriArray[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        LoaiDieuTriArray[i] = intTemp == 1;
                    }
                }
            }
        }
        public string TienSuDiUng { get; set; }
        public string TinhTrangDau { get; set; }
        public string KeHoach_KhoKhan { get; set; }
        public string KeHoach_MucTieu { get; set; }
        public string KeHoach_ChuongTrinh { get; set; }
        public string KeHoach_DieuTri { get; set; }

        public string TinhTrang_VanDong { get; set; }
        public string TinhTrang_ChucNang { get; set; }
        public string TinhTrang_NhanThuc { get; set; }
        public string TinhTrang_ChucNangKhac { get; set; }
        public string TinhTrang_SuThamGia { get; set; }
        public string TinhTrang_YeuToMoiTruong { get; set; }
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
