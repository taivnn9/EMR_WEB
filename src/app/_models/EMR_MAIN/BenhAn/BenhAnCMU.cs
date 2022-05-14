using EMR.KyDienTu;
using PMS.Access;
using System;
using System.Collections.ObjectModel;

namespace EMR_MAIN.DATABASE.BenhAn
{
    public class XetNghiemCMU
    {
        public string ThongSo { get; set; }
        public string GiaTri_Truoc { get; set; }
        public double? Per_Truoc { get; set; }
        public string GiaTri_Sau { get; set; }
        public double? Per_Sau { get; set; }
        public double? ThayDoi { get; set; }
        public string KetQua { get; set; }
    }
    public class BenhAnCMU : BenhAnBase, IBase
    {
        public int IDMauPhieu { get; set; } = (int)DanhMucPhieu.BACMU;
        public string TenMauPhieu { get; set; } = DanhMucPhieu.BACMU.Description();
        public string NgheNghiepDiLamLauNhat { get; set; }
        public string DienThoaiDiDong { get; set; }
        public DateTime? NgayLaphoSo { get; set; }
        public string NoiGioiThieu { get; set; }
        public bool TuDen { get; set; }
        public bool[] LyDoKhamBenhArray { get; } = new bool[] { false, false, false, false, false };
        public string LyDoKhamBenh
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < LyDoKhamBenhArray.Length; i++)
                    temp += (LyDoKhamBenhArray[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        LyDoKhamBenhArray[i] = intTemp == 1;
                    }
                }
            }
        }
        public string TrieuChungKhac { get; set; }
        public bool KhongHut { get; set; }
        public bool hutNhungDaCai { get; set; }
        public string CaiBaoLau { get; set; }
        public int? SoBaoDaHutNam { get; set; }
        public bool DangHut { get; set; }
        public int? SoBaoHutNam { get; set; }
        public bool[] TienSuBenhhArray { get; } = new bool[] { false, false, false };
        public string TienSuBenhh
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < TienSuBenhhArray.Length; i++)
                    temp += (TienSuBenhhArray[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        TienSuBenhhArray[i] = intTemp == 1;
                    }
                }
            }
        }
        public DateTime? ChuanDoanTu { get; set; }
        public bool[] DoCNHHArray { get; } = new bool[] { false, false };
        public int DoCNHH
        {
            get
            {
                return Array.IndexOf(DoCNHHArray, true) + 1;
            }
            set
            {
                for (int i = 0; i < 2; i++)
                {
                    if (i == (value - 1)) DoCNHHArray[i] = true;
                    else DoCNHHArray[i] = false;
                }
            }
        }
        public bool LaoPhoi { get; set; }
        public int? SoLanDieuTriLaoPhoi { get; set; }
        public DateTime? ThoiGianLaoPhoi { get; set; }
        public string BenhKhac { get; set; }
        public bool[] TienSuGiaDinhArray { get; } = new bool[] { false, false };
        public string TienSuGiaDinh
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < TienSuGiaDinhArray.Length; i++)
                    temp += (TienSuGiaDinhArray[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        TienSuGiaDinhArray[i] = intTemp == 1;
                    }
                }
            }
        }
        public bool[] TienSuBanThanArray { get; } = new bool[] { false, false };
        public string TienSuBanThan
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < TienSuBanThanArray.Length; i++)
                    temp += (TienSuBanThanArray[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        TienSuBanThanArray[i] = intTemp == 1;
                    }
                }
            }
        }
        public int? TienSuSoLanVaoBV { get; set; }
        public string TienSuBV { get; set; }
        public bool[] CoPhaiThuMayArray { get; } = new bool[] { false, false };
        public int CoPhaiThuMay
        {
            get
            {
                return Array.IndexOf(CoPhaiThuMayArray, true) + 1;
            }
            set
            {
                for (int i = 0; i < CoPhaiThuMayArray.Length; i++)
                {
                    if (i == (value - 1)) CoPhaiThuMayArray[i] = true;
                    else CoPhaiThuMayArray[i] = false;
                }
            }
        }
        public bool[] TrieuChungArray { get; } = new bool[] { false, false };
        public int TrieuChung
        {
            get
            {
                return Array.IndexOf(TrieuChungArray, true) + 1;
            }
            set
            {
                for (int i = 0; i < TrieuChungArray.Length; i++)
                {
                    if (i == (value - 1)) TrieuChungArray[i] = true;
                    else TrieuChungArray[i] = false;
                }
            }
        }
        public double? DiemACT { get; set; }
        public bool[] KSArray { get; } = new bool[] { false, false, false };
        public int KS
        {
            get
            {
                return Array.IndexOf(KSArray, true) + 1;
            }
            set
            {
                for (int i = 0; i < KSArray.Length; i++)
                {
                    if (i == (value - 1)) KSArray[i] = true;
                    else KSArray[i] = false;
                }
            }
        }
        public bool[] YeuToLienQuanArray { get; } = new bool[] { false, false };
        public int YeuToLienQuan
        {
            get
            {
                return Array.IndexOf(YeuToLienQuanArray, true) + 1;
            }
            set
            {
                for (int i = 0; i < YeuToLienQuanArray.Length; i++)
                {
                    if (i == (value - 1)) YeuToLienQuanArray[i] = true;
                    else YeuToLienQuanArray[i] = false;
                }
            }
        }
        public bool[] YeuToNaoArray { get; } = new bool[] { false, false, false, false, false, false, false };
        public string YeuToNao
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < YeuToNaoArray.Length; i++)
                    temp += (YeuToNaoArray[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        YeuToNaoArray[i] = intTemp == 1;
                    }
                }
            }
        }
        public string YeuToKhac { get; set; }
        public bool[] BenhCoGiamArray { get; } = new bool[] { false, false };
        public int BenhCoGiam
        {
            get
            {
                return Array.IndexOf(BenhCoGiamArray, true) + 1;
            }
            set
            {
                for (int i = 0; i < BenhCoGiamArray.Length; i++)
                {
                    if (i == (value - 1)) BenhCoGiamArray[i] = true;
                    else BenhCoGiamArray[i] = false;
                }
            }
        }
        public DateTime? ThoiGianConDauTien { get; set; }
        public double? FEV1_Nhe { get; set; }
        public double? FEV1_TrungBinh { get; set; }
        public double? FEV1_Nang { get; set; }
        public double? FEV1_RatNang { get; set; }
        public bool[] ThuocDaSuDungArray { get; } = new bool[] { false, false, false, false, false, false };
        public string ThuocDaSuDung
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < ThuocDaSuDungArray.Length; i++)
                    temp += (ThuocDaSuDungArray[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        ThuocDaSuDungArray[i] = intTemp == 1;
                    }
                }
            }
        }
        public string Thuoc_Khac { get; set; }
        public bool[] DangThuocArray { get; } = new bool[] { false, false, false, false, false };
        public string DangThuoc
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < DangThuocArray.Length; i++)
                    temp += (DangThuocArray[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        DangThuocArray[i] = intTemp == 1;
                    }
                }
            }
        }
        public bool[] CacThuocDuPhongArray { get; } = new bool[] { false, false, false, false };
        public string CacThuocDuPhong
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < CacThuocDuPhongArray.Length; i++)
                    temp += (CacThuocDuPhongArray[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        CacThuocDuPhongArray[i] = intTemp == 1;
                    }
                }
            }
        }
        public string CacThuocDuPhong_Khac { get; set; }
        public bool[] KyNangArray { get; } = new bool[] { false, false };
        public int KyNang
        {
            get
            {
                return Array.IndexOf(KyNangArray, true) + 1;
            }
            set
            {
                for (int i = 0; i < KyNangArray.Length; i++)
                {
                    if (i == (value - 1)) KyNangArray[i] = true;
                    else KyNangArray[i] = false;
                }
            }
        }
        public bool[] TuanThuArray { get; } = new bool[] { false, false };
        public int TuanThu
        {
            get
            {
                return Array.IndexOf(TuanThuArray, true) + 1;
            }
            set
            {
                for (int i = 0; i < TuanThuArray.Length; i++)
                {
                    if (i == (value - 1)) TuanThuArray[i] = true;
                    else TuanThuArray[i] = false;
                }
            }
        }


        public double? Mach { get; set; }
        public double? NhietDo { get; set; }
        public string HuyetAp { get; set; }
        public double? NhipTho { get; set; }

        public bool[] HoHapArray { get; } = new bool[] { false, false, false, false, false };
        public string HoHapKhamThucThe
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < HoHapArray.Length; i++)
                    temp += (HoHapArray[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        HoHapArray[i] = intTemp == 1;
                    }
                }
            }
        }
        public string HoHap_Khac { get; set; }
        public string TimMach { get; set; }
        public string CacBoPhanKhac { get; set; }
        public string XQuang_Nguc { get; set; }
        public string FCG { get; set; }
        public DateTime? NgayDoKhongKhiPhoi { get; set; }
        public string Tuoi { get; set; }
        public string Gioi { get; set; }
        public double? CanNang { get; set; }
        public double? ChieuCao { get; set; }
        public double? BMI { get; set; }
        public ObservableCollection<XetNghiemCMU> XetNghiemCMUs { get; set; }
        public DateTime? NgayXNKhiMauDongMach { get; set; }
        public string PH { get; set; }
        public string PaCO2 { get; set; }
        public string PO2 { get; set; }
        public string SaO2 { get; set; }
        public string SpO2 { get; set; }
        public string XNMau { get; set; }
        public string Hct { get; set; }
        public string Hgb_dl {get;set;}
        public string SieuAmTim { get; set; }
        public string XetNghiemKhac { get; set; }
        public bool ChanDoanHen { get; set; }
        public bool[] MucKiemSoatArray { get; } = new bool[] { false, false, false };
        public int MucKiemSoat
        {
            get
            {
                return Array.IndexOf(MucKiemSoatArray, true) + 1;
            }
            set
            {
                for (int i = 0; i < MucKiemSoatArray.Length; i++)
                {
                    if (i == (value - 1)) MucKiemSoatArray[i] = true;
                    else MucKiemSoatArray[i] = false;
                }
            }
        }
        public bool ChanDoanCopd { get; set; }
        public bool[] GiaiDoanArray { get; } = new bool[] { false, false, false, false };
        public int GiaiDoan
        {
            get
            {
                return Array.IndexOf(GiaiDoanArray, true) + 1;
            }
            set
            {
                for (int i = 0; i < GiaiDoanArray.Length; i++)
                {
                    if (i == (value - 1)) GiaiDoanArray[i] = true;
                    else GiaiDoanArray[i] = false;
                }
            }
        }
        public string BenhKetHop { get; set;}

        public bool[] HuongXuTri_TuVan_Array { get; } = new bool[] { false, false, false };
        public string HuongXuTri_TuVan
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < HuongXuTri_TuVan_Array.Length; i++)
                    temp += (HuongXuTri_TuVan_Array[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        HuongXuTri_TuVan_Array[i] = intTemp == 1;
                    }
                }
            }
        }
        public bool[] HuongXuTri_DieuTri_Array { get; } = new bool[] { false, false, false };
        public string HuongXuTri_DieuTri
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < HuongXuTri_DieuTri_Array.Length; i++)
                    temp += (HuongXuTri_DieuTri_Array[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        HuongXuTri_DieuTri_Array[i] = intTemp == 1;
                    }
                }
            }
        }
        public string HuongXuTri_Khac { get; set; }
        public string BacSy { get; set; }
        public string MaBacSy { get; set; }
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
