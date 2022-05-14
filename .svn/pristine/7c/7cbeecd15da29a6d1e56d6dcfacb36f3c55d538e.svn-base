using EMR.KyDienTu;
using EMR_MAIN.DATABASE;
using PMS.Access;
using System;

namespace EMR_MAIN
{

    public class BenhAnTayChanMieng : BenhAnBase, IBase
    {
        public int IDMauPhieu { get; set; } = (int)DanhMucPhieu.BATCM;
        public string TenMauPhieu { get; set; } = DanhMucPhieu.BATCM.Description();
        public long ID { get; set; }
        public bool[] TrieuTrungArray { get; } = new bool[] { false, false, false, false, false,false,false };
        public string TrieuTrung
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < TrieuTrungArray.Length; i++)
                    temp += (TrieuTrungArray[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        TrieuTrungArray[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public string TrieuTrung_GiatMinh_SoLan { get; set; }
        public string BenhLy_DauHieuKhac { get; set; }
        public string BenhLy_DichTe { get; set; }
        public int DichTe_DiHoc { get; set; }
        public string DichTe_DiaChiTruong { get; set; }
        public bool[] DichTeArray { get; } = new bool[] { false, false, false };
        public string DichTe
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < DichTeArray.Length; i++)
                    temp += (DichTeArray[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        DichTeArray[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public string DieuTriTuyenTruoc { get; set; }
        public string BenhLy_Khac { get; set; }
        //public string TienSuBenhBanThan { get; set; }
        public string TenThuoc1 { set; get; }
        public int TSDU1 { set; get; }
        public string SoLan1 { set; get; }
        public string BHLS1 { set; get; }
        public string TenThuoc2 { set; get; }
        public int TSDU2 { set; get; }
        public string SoLan2 { set; get; }
        public string BHLS2 { set; get; }
        public string TenThuoc3 { set; get; }
        public int TSDU3 { set; get; }
        public string SoLan3 { set; get; }
        public string BHLS3 { set; get; }
        public string TenThuoc4 { set; get; }
        public int TSDU4 { set; get; }
        public string SoLan4 { set; get; }
        public string BHLS4 { set; get; }
        public string TenThuoc5 { set; get; }
        public int TSDU5 { set; get; }
        public string SoLan5 { set; get; }
        public string BHLS5 { set; get; }
        public string TenThuoc6 { set; get; }
        public int TSDU6 { set; get; }
        public string SoLan6 { set; get; }
        public string BHLS6 { set; get; }
        public int DiTatBamSinh_Co { set; get; }
        public string ToanThan_Khac { set; get; }
        public int GanTo_TieuHoaCo { set; get; }
        //public string QuaTrinhBenhLyVaDienBien { set; get; }
        //public string TomTatKetQuaXetNghiem { set; get; }
        //public string PhuongPhapDieuTri { set; get; }
        //public string TinhTrangNguoiBenhRaVien { set; get; }
        //public string HuongDieuTriVaCacCheDoTiepTheo { set; get; }
        //public string NguoiGiaoHoSo { set; get; }
        //public string NguoiNhanHoSo { set; get; }
        //public string BacSyDieuTri { set; get; }
        //public string TienSuBenhGiaDinh { get; set; }
        public int SinhTruong_ConThuMay { get; set; }
        public bool[] TienThaiParaArray { get; } = new bool[] { false, false, false,false };
        public string TienThaiPara
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < TienThaiParaArray.Length; i++)
                    temp += (TienThaiParaArray[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        TienThaiParaArray[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public int TTKhiSinh { get; set; }
        public int CanNangLucSinh { get; set; }
        public string DiTatBamSinh { get; set; }
        public string PTTinhThan { get; set; }
        public string PTVanDong { get; set; }
        public string CacBenhLyKhac { get; set; }
        public bool[] NuoiDuongArray { get; } = new bool[] { false, false, false };
        public string NuoiDuong
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < NuoiDuongArray.Length; i++)
                    temp += (NuoiDuongArray[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        NuoiDuongArray[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public string NuoiDuong_CaiSua { get; set; }
        public int ChamSoc { get; set; }
        public bool[] TiemChungArray { get; } = new bool[] { false, false, false, false, false, false, false };
        public string TiemChung
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < TiemChungArray.Length; i++)
                    temp += (TiemChungArray[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        TiemChungArray[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public string SinhTruong_Khac { get; set; }
        public string ChieuCao { get; set; }
        public string VongNguc { get; set; }
        public string VongDau { get; set; }
        public string SPO2 { get; set; }
        public bool[] TriGiacArray { get; } = new bool[] { false, false, false , false};
        public string TriGiac
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < TriGiacArray.Length; i++)
                    temp += (TriGiacArray[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        TriGiacArray[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        //public string ToanThan_Khac { get; set; }
        public int TuanHoan_Tim { get; set; }
        public string TuanHoan_TimAmThoi { get; set; }
        public string ThoiGianDayMaoMach { get; set; }
        public int DauHieuTinhMach { get; set; }
        public int VaMoHoi { get; set; }
        public int DaNoiBong { get; set; }
        public string DauHieuKhac_Tim { get; set; }
        public bool[] HoHapArray { get; } = new bool[] { false, false, false, false, false, false, false };
        public string CacCoQuan_HoHap
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
                        HoHapArray[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public string RanPhoi { get; set; }
        public string DauHieuKhac_HoHap { get; set; }
        public string GanTo_TieuHoa { get; set; }
        public string DBS_TieuHoa { get; set; }
        public string DauHieuKhac_TieuHoa { get; set; }
        //public string ThanTietNieuSinhDuc { get; set; }
        public string DongTu { get; set; }
        public string PXAS { get; set; }
        public bool[] ThanKinhArray { get; } = new bool[] { false, false, false, false, false, false, false, false };
        public string CacCoQuan_ThanKinh
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < ThanKinhArray.Length; i++)
                    temp += (ThanKinhArray[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        ThanKinhArray[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }

        public string DauHieuKhac_ThanKinh { get; set; }
        //public string CoXuongKhop { get; set; }
        public string TMHRHMCoQuanKhac { get; set; }
        public string CacXNCanLamSang { get; set; }
        public int NgayBenh { get; set; }
        public bool[] TTBenhAnArray { get; } = new bool[] { false, false, false, false, false, false, 
            false, false, false, false, false, false, false, false };
        public string TTBenhAn
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < TTBenhAnArray.Length; i++)
                    temp += (TTBenhAnArray[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        TTBenhAnArray[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }

        public string DauHieuKhac_TTBenhAn { get; set; }
        public string ChanDoanBenhChinh { get; set; }
        public string MaICD10 { get; set; }
        public string BenhKem_ChanDoan { get; set; }
        public string MaICD10BenhKem { get; set; }
        public string PhanBiet_ChanDoan { get; set; }
        public bool[] HuongDieuTriArray { get; } = new bool[] { false, false, false, false, false, false };
        public string HuongDieuTriArr
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < HuongDieuTriArray.Length; i++)
                    temp += (HuongDieuTriArray[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        HuongDieuTriArray[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        //public string TienLuong { get; set; }
        public string HuongDieuTriKhac { get; set; }
        public string HinhVeTonThuongKhiVaoVien { get; set; }
        //public DateTime NgayKhamBenh { get; set; }
        //public string BacSyLamBenhAn { get; set; }
        public string MaNVBacSyLamBenhAn { get; set; }
        public string TongKet_KetQuaXetNghiem { get; set; }
        public string TongKet_QuaTrinhBenhLy { get; set; }
        public string TongKet_DieuTri { get; set; }
        public string TongKet_TTRaVien { get; set; }
        public string TongKet_HuongDieuTri { get; set; }
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
