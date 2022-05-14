using EMR.KyDienTu;
using PMS.Access;
using System;

namespace EMR_MAIN.DATABASE.BenhAn
{
    public class BenhAnPhaThaiIII : BenhAnBase, IBase
    {
        public int IDMauPhieu { get; set; } = (int)DanhMucPhieu.BAPhaThaiIII;
        public string TenMauPhieu { get; set; } = DanhMucPhieu.BAPhaThaiIII.Description();
        public string LyDoPhaThai { get; set; }
        public string TienSuSanPhuKhoa { get; set; }
        public int? SoConHienCo { get; set; }
        public int? SoConTrai { get; set; }
        public int? SoConGai { get; set; }
        public int? SoLanPhauThuatLayThai { get; set; }
        public string NamPhauThuatLayThaiCuoi { get; set; }
        public string CacPhauThuatTCKhac { get; set; }
        public string CacPhauThuatTCKhac_Nam { get; set; }
        public int? SoLanPhaThai { get; set; }
        public DateTime? NgayPhaThaiGanNhat { get; set; }
        public bool[] BienPhapTTDangSuDungArray { get; } = new bool[] { false, false, false, false, false, false, false , false };
        public string BienPhapTTDangSuDung
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < BienPhapTTDangSuDungArray.Length; i++)
                    temp += (BienPhapTTDangSuDungArray[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        BienPhapTTDangSuDungArray[i] = intTemp == 1;
                    }
                }
            }
        }
        public string TieuSuBenh { get; set; }
        public bool[] TinhTrangHonNhanArray { get; } = new bool[] { false, false };
        public int TinhTrangHonNhan
        {
            get
            {
                return Array.IndexOf(TinhTrangHonNhanArray, true) + 1;
            }
            set
            {
                for (int i = 0; i < TinhTrangHonNhanArray.Length; i++)
                {
                    if (i == (value - 1)) TinhTrangHonNhanArray[i] = true;
                    else TinhTrangHonNhanArray[i] = false;
                }
            }
        }
        public string DUThuoc_Ten { get; set; }
        public string DUThuoc_CoSoLan { get; set; }
        public bool DUThuoc_Khong { get; set; }
        public string DUThuoc_BieuHien { get; set; }
        public string DUConTrung_Ten { get; set; }
        public string DUConTrung_CoSoLan { get; set; }
        public bool DUConTrung_Khong { get; set; }
        public string DUConTrung_BieuHien { get; set; }
        public string DUThucPham_Ten { get; set; }
        public string DUThucPham_CoSoLan { get; set; }
        public bool DUThucPham_Khong { get; set; }
        public string DUThucPham_BieuHien { get; set; }
        public string DUTacNhanKhac_Ten { get; set; }
        public string DUTacNhanKhac_CoSoLan { get; set; }
        public bool DUTacNhanKhac_Khong { get; set; }
        public string DUTacNhanKhac_BieuHien { get; set; }
        public string DUCaNhanKhac_Ten { get; set; }
        public string DUCaNhanKhac_CoSoLan { get; set; }
        public bool DUCaNhanKhac_Khong { get; set; }
        public string DUCaNhanKhac_BieuHien { get; set; }
        public string DUDiTruyen_Ten { get; set; }
        public string DUDiTruyen_CoSoLan { get; set; }
        public bool DUDiTruyen_Khong { get; set; }
        public string DUDiTruyen_BieuHien { get; set; }
        public string CacBoPhan { get; set; }
        public DateTime? NgayDauKyKinhCuoi { get; set; }
        public int? TuoiThai { get; set; }
        public string AmHo { get; set; }
        public string AmDao { get; set; }
        public string CoTuCung { get; set; }
        public string TuCungChiTiet { get; set; }
        public string PhanPhuPhai { get; set; }
        public string PhanPhuTrai { get; set; }
        public string CacXetNghiemCanLam { get; set; }
        public int? ChanDoanTuoiThai { get; set; }  
        public string PhuongPhapPhaThai { get; set; }
        // tongket
        public string ChanDoanTuanThaiTongKet { get; set; }
        public bool[] PhuongPhapPhaThaiArray { get; } = new bool[] { false, false, false, false };
        public int PhuongPhapPhaThaiTongKet
        {
            get
            {
                return Array.IndexOf(PhuongPhapPhaThaiArray, true) + 1;
            }
            set
            {
                for (int i = 0; i < PhuongPhapPhaThaiArray.Length; i++)
                {
                    if (i == (value - 1)) PhuongPhapPhaThaiArray[i] = true;
                    else PhuongPhapPhaThaiArray[i] = false;
                }
            }
        }
        public bool[] TinhTrangSauKhiPhaThaiArray { get; } = new bool[] { false, false };
        public int TinhTrangSauKhiPhaThai
        {
            get
            {
                return Array.IndexOf(TinhTrangSauKhiPhaThaiArray, true) + 1;
            }
            set
            {
                for (int i = 0; i < TinhTrangSauKhiPhaThaiArray.Length; i++)
                {
                    if (i == (value - 1)) TinhTrangSauKhiPhaThaiArray[i] = true;
                    else TinhTrangSauKhiPhaThaiArray[i] = false;
                }
            }
        }
        public bool[] TaiBienArray { get; } = new bool[] { false, false };
        public int TaiBien
        {
            get
            {
                return Array.IndexOf(TaiBienArray, true) + 1;
            }
            set
            {
                for (int i = 0; i < TaiBienArray.Length; i++)
                {
                    if (i == (value - 1)) TaiBienArray[i] = true;
                    else TaiBienArray[i] = false;
                }
            }
        }
        public double? TongSoGio { get; set; }
        public bool[] RaVeArray { get; } = new bool[] { false, false };
        public int RaVe
        {
            get
            {
                return Array.IndexOf(RaVeArray, true) + 1;
            }
            set
            {
                for (int i = 0; i < RaVeArray.Length; i++)
                {
                    if (i == (value - 1)) RaVeArray[i] = true;
                    else RaVeArray[i] = false;
                }
            }
        }
        public DateTime? ChuyenTuyenLuc { get; set; }
        public string LyDoNhapVien { get; set; }
        public string LyDoChuyenTuyen { get; set; }
        public bool[] BienPhapTranhThaiSauPhaThaiTKArray { get; } = new bool[] { false, false, false, false, false, false, false, false };
        public string BienPhapTranhThaiSauPhaThaiTK
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < BienPhapTranhThaiSauPhaThaiTKArray.Length; i++)
                    temp += (BienPhapTranhThaiSauPhaThaiTKArray[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        BienPhapTranhThaiSauPhaThaiTKArray[i] = intTemp == 1;
                    }
                }
            }
        }
        public string KhamLaiBatThuong { get; set; }
        public string KhamLaiTheoHen { get; set; }
        public string KetLuan { get; set; }
        public string LanhDaoDonVi { get; set; }
        public string NguoiTongKet { get; set; }
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
