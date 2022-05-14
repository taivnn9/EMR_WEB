using EMR.KyDienTu;
using PMS.Access;
using System;

namespace EMR_MAIN.DATABASE.BenhAn
{
    public class BenhAnNgoaiTru_VayPhanDoNangLong : IBase
    {
        public int IDMauPhieu { get; set; } = (int)DanhMucPhieu.BABVPDNL;
        public string TenMauPhieu { get; set; } = DanhMucPhieu.BABVPDNL.Description();
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
        // IV. HỎI BỆNH
        public string ThoiGianKhoiPhatBenh { get; set; }
        public string TrieuChungDauTien { get; set; }
        public string ThoiGianBiDayDa { get; set; }
        public string QuaTrinhBenhLy { get; set; }
        public string DieuTriTruocDay { get; set; }
        // phần 6. TIỀN SỬ BỆNH:
        [MoTaDuLieu("Tiền sử bản thân:Dị ứng thuốc")]
        public string TSBT_DiUngThuoc { get; set; }
        [MoTaDuLieu("Tiền sử bản thân:BenhKhac")]
        public string TSBT_BenhKhac { get; set; }
        [MoTaDuLieu("Tiền sử gia đình: Bệnh khác")]
        public string TSGD_Khac { get; set; }
        public string TSGD_DiUngThuoc { get; set; }
        // V. KHÁM BỆNH:
        public string ToanThan { get; set; }
        public string CacBoPhan { get; set; }
        public string Khop { get; set; }
        public string TieuHoa { get; set; }
        public string PhoiVaMachMauOPhoi { get; set; }
        public string Co { get; set; }
        public string TimMach { get; set; }
        public string Than { get; set; }
        public string CacBoPhanKhac { get; set; }
        public string DiemDanhGia { get; set; }
        // 3. Triệu chứng cơ năng :  
        public bool[] TrieuChungCoNang_Array { get; } = new bool[] { false, false, false, false, false };
        public string TrieuChungCoNang
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < TrieuChungCoNang_Array.Length; i++)
                    temp += (TrieuChungCoNang_Array[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        TrieuChungCoNang_Array[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public string TrieuChungCoNang_Khac { get; set; }
        // 4.Thương tổn da
        public bool[] SanNangLong_ViTri_Array { get; } = new bool[] { false, false, false, false, false, false, false, false };
        public string SanNangLong_ViTri
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < SanNangLong_ViTri_Array.Length; i++)
                    temp += (SanNangLong_ViTri_Array[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        SanNangLong_ViTri_Array[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public string SanNangLong_ViTri_Khac { get; set; }
        public string SanNangLong_KichThuoc { get; set; }
        public bool[] SanNangLong_KeuTapTrung_Array { get; } = new bool[] { false, false, false };
        public string SanNangLong_KeuTapTrung
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < SanNangLong_KeuTapTrung_Array.Length; i++)
                    temp += (SanNangLong_KeuTapTrung_Array[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        SanNangLong_KeuTapTrung_Array[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public bool[] VayDa_Array { get; } = new bool[] { false, false, false, false, false, false, false, false };
        public string VayDa
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < VayDa_Array.Length; i++)
                    temp += (VayDa_Array[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        VayDa_Array[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public string VayDa_Khac { get; set; }
        public bool[] DoDa_Array { get; } = new bool[] { false, false, false};
        public string DoDa
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < DoDa_Array.Length; i++)
                    temp += (DoDa_Array[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        DoDa_Array[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public int LichenHoa { get; set; }
        public int DoDaLanh { get; set; }
        public int RungToc { get; set; }
        public string DaySung_ViTri { get; set; }
        public bool[] DaySung_Array { get; } = new bool[] { false, false };
        public string DaySung
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < DaySung_Array.Length; i++)
                    temp += (DaySung_Array[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        DaySung_Array[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public bool[] ThuongTonMong_Array { get; } = new bool[] { false, false, false };
        public string ThuongTonMong
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < ThuongTonMong_Array.Length; i++)
                    temp += (ThuongTonMong_Array[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        ThuongTonMong_Array[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }

        public bool[] ChanDoanVaPhanThe_Array { get; } = new bool[] { false, false, false, false, false, false };
        public string ChanDoanVaPhanThe
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < ChanDoanVaPhanThe_Array.Length; i++)
                    temp += (ChanDoanVaPhanThe_Array[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        ChanDoanVaPhanThe_Array[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public string DieuTri { get; set; }
        public DateTime? HenTaiKham { get; set; }
        public string BacSiDieuTri { get; set; }
        // phần tái khám
        public DateTime? TK_NgayTaiKham { get; set; }
        // phần lưu trữ
        public string TK_HoTen { get; set; }
        public string TK_SoBenhAn { get; set; }
        public string TK_SoLuuTru { get; set; }
        // phần khám lại
        public string TK_Mach { get; set; }
        public string TK_HA { get; set; }
        public string TK_NhietDo { get; set; }
        public bool[] TK_BNTuDanhGia_Array { get; } = new bool[] { false, false, false, false};
        public string TK_BNTuDanhGia
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < TK_BNTuDanhGia_Array.Length; i++)
                    temp += (TK_BNTuDanhGia_Array[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        TK_BNTuDanhGia_Array[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public string TK_BNTuDanhGia_ChuY { get; set; }
        // Lâm sàng da
        public string TK_LamSangDa { get; set; }
        // LÂM SÀNG NỘI TẠNG
        public string TK_Khop { get; set; }
        public string TK_Than { get; set; }
        public string TK_TieuHoa { get; set; }
        public string TK_Phoi { get; set; }
        public string TK_Co { get; set; }
        public string TK_Tim { get; set; }
        public string TK_LamSangNoiTang_Khac { get; set; }
        public string TK_HAQ { get; set; }
        public string TK_TDPCuaThuoc { get; set; }
        public string TK_HuongDieuTriTiepTheo { get; set; }
        public DateTime? TK_HenTaiKham { get; set; }
        public string TK_BacSiDieuTri { get; set; }

        // Phần tổng kết
        public string TongKet_QuaTrinhBenhLy { get; set; }
        public string TomTatKetQua { get; set; }
        public string BenhChinh { get; set; }
        public string MaBenhChinh { get; set; }
        public string BenhKemTheo { get; set; }
        public string MaBenhKemTheo { get; set; }
        public string PhuongPhapDieuTri { get; set; }
        public string TinhTrangRaVien { get; set; }
        public string HuongDieuTri { get; set; }
        public string NguoiNhanHoSo { get; set; }
        public string NguoiGiaoHoSo { get; set; }
        public DateTime NgayTongKet { get; set; }
        public string TongKet_BacSyDieuTri { get; set; }
        public string TongKet_MaBacSyDieuTri { get; set; }
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
