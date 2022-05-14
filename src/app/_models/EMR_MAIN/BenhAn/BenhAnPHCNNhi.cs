using EMR.KyDienTu;
using PMS.Access;
using System;

namespace EMR_MAIN.DATABASE.BenhAn
{
    public class BenhAnPHCNNhi : BenhAnBase, IBase
    {
        public int IDMauPhieu { get; set; } = (int)DanhMucPhieu.BAPHCNNhi;
        public string TenMauPhieu { get; set; } = DanhMucPhieu.BAPHCNNhi.Description();
        public bool[] LoaiDieuTriArray { get; } = new bool[] { false, false, false };
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
        public bool[] TienSuSanKhoa_MeArray { get; } = new bool[] { false, false, false, false };
        public string TienSuSanKhoa_Me
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < TienSuSanKhoa_MeArray.Length; i++)
                    temp += (TienSuSanKhoa_MeArray[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        TienSuSanKhoa_MeArray[i] = intTemp == 1;
                    }
                }
            }
        }
        public string TuoiMeKhiSinhTre { get; set; }
        public string TinhTranMeMangThai { get; set; }
        public string ConThu { get; set; }
        public string TuoiThai { get; set; }
        public bool[] TuoiThaiCheckArray { get; } = new bool[] { false, false, false};
        public string TuoiThaiCheck
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < TuoiThaiCheckArray.Length; i++)
                    temp += (TuoiThaiCheckArray[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        TuoiThaiCheckArray[i] = intTemp == 1;
                    }
                }
            }
        }
        public string CanNangKhiSinh { get; set; }
        public bool[] CanNangKhiSinhCheckArray { get; } = new bool[] { false, false, false };
        public string CanNangKhiSinhCheck
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < CanNangKhiSinhCheckArray.Length; i++)
                    temp += (CanNangKhiSinhCheckArray[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        CanNangKhiSinhCheckArray[i] = intTemp == 1;
                    }
                }
            }
        }
        public bool[] TinhTrangKhiSinhArray { get; } = new bool[] { false, false, false, false, false };
        public string TinhTrangKhiSinh
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < TinhTrangKhiSinhArray.Length; i++)
                    temp += (TinhTrangKhiSinhArray[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        TinhTrangKhiSinhArray[i] = intTemp == 1;
                    }
                }
            }
        }
        public string TinhTrangSauSinh { get; set; }
        public string TiemPhongVacxin { get; set; }
        public string SoConTrongGiaDinh { get; set; }
        public string SoTreCoBatThuong { get; set; }
        public string GiaDinhCoNhiemCDDC { get; set; }
        public string VongDau { set; get; }
        public string ChiDinhDieuTri { get; set; }
        public string DieuTriBenhLy { get; set; }
        public string CheDoChamSoc { get; set; }
        public string HoiNhapXaHoi { get; set; }
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
