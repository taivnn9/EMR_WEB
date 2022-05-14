using EMR.KyDienTu;
using EMR_MAIN.DATABASE;
using PMS.Access;
using System;
using System.Collections.Generic;

namespace EMR_MAIN
{
    public class BenhAnMatGlocom : BenhAnBase, IBase
    {
        public int IDMauPhieu { get; set; } = (int)DanhMucPhieu.BAMGlocom;
        public string TenMauPhieu { get; set; } = DanhMucPhieu.BAMGlocom.Description();
        public bool LyDoDiKham_MP { get; set; }
        public bool LyDoDiKham_MT { get; set; }
        public bool LyDoDiKham_2Mat { get; set; }
        public bool NhucMat_DuDoi { get; set; }
        public bool NhucMat_Vua { get; set; }
        public bool NhucMat_Nhe { get; set; }
        public bool NhucMat_Khong { get; set; }
        public bool Nhin_MoDotNgot { get; set; }
        public bool Nhin_MoTungLuc { get; set; }
        public bool Nhin_SuongMu { get; set; }
        public bool Nhin_KhongMo { get; set; }
        public bool Nhin_MoTangDan { get; set; }
        public bool Nhin_NhinThuHep { get; set; }
        public bool Nhin_QuanTanSac { get; set; }
        public bool SoAnhSangChayNuocMat_Co { get; set; }
        public bool SoAnhSangChayNuocMat_Khong { get; set; }
        public bool DoMat_Co { get; set; }
        public bool DoMat_Khong { get; set; }
        public bool ToanThan_DauDau { get; set; }
        public bool ToanThan_Non { get; set; }
        public bool ToanThan_BuonNon { get; set; }
        public bool ToanThan_Khong { get; set; }
        public string CacTrieuChungKhac { get; set; }
        public string ThoiGianXuatHienBenh { get; set; }
        public bool DaKhamChuaBenh_Huyen { get; set; }
        public bool DaKhamChuaBenh_Tinh { get; set; }
        public bool DaKhamChuaBenh_TrungUong { get; set; }
        public bool DaKhamChuaBenh_Khac { get; set; }
        public bool PhuongPhapDieuTri_PhauThuat { get; set; }
        public bool PhuongPhapDieuTri_Thuoc { get; set; }
        public bool PhuongPhapDieuTri_Laser { get; set; }
        public string PTTTMP_Loai1 { get; set; }
        public string PTTTMP_Loai2 { get; set; }
        public string PTTTMP_Loai3 { get; set; }
        public string PTTTMP_Loai4 { get; set; }
        public string PTTTMT_Loai1 { get; set; }
        public string PTTTMT_Loai2 { get; set; }
        public string PTTTMT_Loai3 { get; set; }
        public string PTTTMT_Loai4 { get; set; }
        public string PTTTMP_ThoiDiem1 { get; set; }
        public string PTTTMP_ThoiDiem2 { get; set; }
        public string PTTTMP_ThoiDiem3 { get; set; }
        public string PTTTMP_ThoiDiem4 { get; set; }
        public string PTTTMT_ThoiDiem1 { get; set; }
        public string PTTTMT_ThoiDiem2 { get; set; }
        public string PTTTMT_ThoiDiem3 { get; set; }
        public string PTTTMT_ThoiDiem4 { get; set; }
        public string PTTTMP_Noi1 { get; set; }
        public string PTTTMP_Noi2 { get; set; }
        public string PTTTMP_Noi3 { get; set; }
        public string PTTTMP_Noi4 { get; set; }
        public string PTTTMT_Noi1 { get; set; }
        public string PTTTMT_Noi2 { get; set; }
        public string PTTTMT_Noi3 { get; set; }
        public string PTTTMT_Noi4 { get; set; }
        public bool ThuocHaNhanAp_Uong { get; set; }
        public bool ThuocHaNhanAp_TraMat { get; set; }
        public bool ThuocHaNhanAp_Tiem { get; set; }
        public bool ThuocHaNhanAp_1Thuoc { get; set; }
        public bool ThuocHaNhanAp_2Thuoc { get; set; }
        public bool ThuocHaNhanAp_3Thuoc { get; set; }
        public bool ThuocHaNhanAp_4Thuoc { get; set; }
        public List<ThuocHaNhanApDaDungs> ThuocHaNhanApDaDung { get; set; }
        public string CacThuocKhac { get; set; }
        public string TienTrinhDieuTri { get; set; }
        public int TienSuKhac { get; set; }
        public bool TienSuKhac_CanThi { get; set; }
        public bool TienSuKhac_VienThi { get; set; }
        public bool TienSuKhac_TranThuong { get; set; }
        public bool TienSuKhac_VienMangBoDao { get; set; }
        public bool TienSuKhac_VienPhanTruocNhaCau { get; set; }
        public bool TienSuKhac_TacTMTTVM { get; set; }
        public bool TienSuKhac_DaPTMat { get; set; }
        public string TienSuKhac_DaPTMat_Text { get; set; }
        public bool TienSuKhac_BenhKhac { get; set; }
        public string TienSuKhac_BenhKhac_Text { get; set; }
        public string TienSuKhac_Corticosteroid { get; set; }
        public bool TienSuKhac_Cor { get; set; }
        public string ThoiGianSuDung_Corticosteroid { get; set; }
        public bool Corticosteroid_TraMat { get; set; }
        public bool Corticosteroid_TiemMat { get; set; }
        public bool Corticosteroid_ToanThan { get; set; }
        public bool Corticosteroid_TheoCDCuaBacSi { get; set; }
        public bool Corticosteroid_BNTuDungThuoc { get; set; }
        public bool TienSuToanThan_TimMach { get; set; }
        public bool TienSuToanThan_HuyetAp { get; set; }
        public bool TienSuToanThan_DaiDuong { get; set; }
        public bool TienSuToanThan_RoDongMachCanh { get; set; }
        public bool TienSuToanThan_BenhKhac { get; set; }
        public string TienSuBenhToanThan_BenhKhac { get; set; }
        public bool TienSuGlocomGiaDinh_OngBa { get; set; }
        public bool TienSuGlocomGiaDinh_BoMe { get; set; }
        public bool TienSuGlocomGiaDinh_AnhChiEm { get; set; }
        public bool TienSuGlocomGiaDinh_CoDiChuBac { get; set; }
        public string ThiLucVaoVienMP_KhongKinh { get; set; }
        public string ThiLucVaoVienMT_KhongKinh { get; set; }
        public string ThiLucVaoVienMP_CoKinh { get; set; }
        public string ThiLucVaoVienMT_CoKinh { get; set; }
        public string NhaApMP { get; set; }
        public string NhaApMT { get; set; }
        public bool MiMatSungNeMP_Khong { get; set; }
        public bool MiMatSungNeMP_Co { get; set; }
        public bool MiMatSungNeMT_Khong { get; set; }
        public bool MiMatSungNeMT_Co { get; set; }
        public string NhanApMP_Khac { get; set; }
        public string NhanApMT_Khac { get; set; }
        public bool KetMacCuongTuMP_Khong { get; set; }
        public bool KetMacCuongTuMP_Co { get; set; }
        public bool KetMacCuongTuMT_Khong { get; set; }
        public bool KetMacCuongTuMT_Co { get; set; }
        public bool KetMacSeoMoCuMP_Khong { get; set; }
        public bool KetMacSeoMoCuMP_Co { get; set; }
        public string KetMacSeoMoCuMP { get; set; }
        public bool KetMacSeoMoCuMT_Khong { get; set; }
        public bool KetMacSeoMoCuMT_Co { get; set; }
        public string KetMacSeoMoCuMT { get; set; }
        public bool KetMacBonDoMP_Tot { get; set; }
        public bool KetMacBonDoMP_Dep { get; set; }
        public bool KetMacBonDoMP_Xo { get; set; }
        public bool KetMacBonDoMP_Mong { get; set; }
        public bool KetMacBonDoMP_QuaPhat { get; set; }
        public bool KetMacBonDoMT_Tot { get; set; }
        public bool KetMacBonDoMT_Dep { get; set; }
        public bool KetMacBonDoMT_Xo { get; set; }
        public bool KetMacBonDoMT_Mong { get; set; }
        public bool KetMacBonDoMT_QuaPhat { get; set; }
        public bool GiacMacTrongSuatMP_Trong { get; set; }
        public bool GiacMacTrongSuatMP_Seo { get; set; }
        public bool GiacMacTrongSuatMP_LoanDuong { get; set; }
        public bool GiacMacPhuNeMP_Khong { get; set; }
        public bool GiacMacPhuNeMP_Co { get; set; }
        public string GiacMacPhuNeMP { get; set; }
        public bool GiacMacTrongSuatMT_Trong { get; set; }
        public bool GiacMacTrongSuatMT_Seo { get; set; }
        public bool GiacMacTrongSuatMT_LoanDuong { get; set; }
        public bool GiacMacPhuNeMT_Khong { get; set; }
        public bool GiacMacPhuNeMT_Co { get; set; }
        public string GiacMacPhuNeMT { get; set; }
        public string GiacMacDoDayGiacMacMP { get; set; }
        public string GiacMacDoDayGiacMacMT { get; set; }
        public string GiacMacTuMP { get; set; }
        public string GiacMacTuMT { get; set; }
        public string GiacMacDuongKinhGiacMacMP { get; set; }
        public string GiacMacDuongKinhGiacMacMT { get; set; }
        public bool CungMacDanLoiMP_Khong { get; set; }
        public bool CungMacDanLoiMP_Co { get; set; }
        public bool CungMacDanLoiMT_Khong { get; set; }
        public bool CungMacDanLoiMT_Co { get; set; }
        public bool CungMaSeoMoMP_Khong { get; set; }
        public bool CungMaSeoMoMP_Co { get; set; }
        public string CungMaSeoMoMP { get; set; }
        public bool CungMaSeoMoMT_Khong { get; set; }
        public bool CungMaSeoMoMT_Co { get; set; }
        public string CungMaSeoMoMT { get; set; }
        public string TienPhongDoSauMP { get; set; }
        public string TienPhongDoSauMT { get; set; }
        public string GocTienPhongDauHieuKhacMP { get; set; }
        public string GocTienPhongDauHieuKhacMT { get; set; }
        public string MongMatMauSacMP { get; set; }
        public string MongMatMauSacMT { get; set; }
        public bool MongMatThaiHoaMP_Khong { get; set; }
        public bool MongMatThaiHoaMP_Co { get; set; }
        public string MongMatThaiHoaMP { get; set; }
        public bool MongMatThaiHoaMT_Khong { get; set; }
        public bool MongMatThaiHoaMT_Co { get; set; }
        public string MongMatThaiHoaMT { get; set; }
        public bool MongMatTanMachMP_Khong { get; set; }
        public bool MongMatTanMachMP_Co { get; set; }
        public bool MongMatTanMachMT_Khong { get; set; }
        public bool MongMatTanMachMT_Co { get; set; }
        public bool DongTuMP_Tron { get; set; }
        public bool DongTuMP_Meo { get; set; }
        public bool DongTuMT_Tron { get; set; }
        public bool DongTuMT_Meo { get; set; }
        public string DongTuDuongKinhMP { get; set; }
        public string DongTuDuongKinhMT { get; set; }
        public string DongTuVienSacToMP { get; set; }
        public string DongTuVienSacToMT { get; set; }
        public bool DongTuPhanXaMP_BinhThuong { get; set; }
        public bool DongTuPhanXaMP_Giam { get; set; }
        public bool DongTuPhanXaMP_Mat { get; set; }
        public bool DongTuPhanXaMT_BinhThuong { get; set; }
        public bool DongTuPhanXaMT_Giam { get; set; }
        public bool DongTuPhanXaMT_Mat { get; set; }
        public bool TheThuyTinhMP_Trong { get; set; }
        public bool TheThuyTinhMP_Duc { get; set; }
        public bool TheThuyTinhMT_Trong { get; set; }
        public bool TheThuyTinhMT_Duc { get; set; }
        public bool TheThuyTinhMP_Nhan { get; set; }
        public bool TheThuyTinhMP_Vo { get; set; }
        public bool TheThuyTinhMP_DuoiBao { get; set; }
        public bool TheThuyTinhMP_ToanBo { get; set; }
        public bool TheThuyTinhMT_Nhan { get; set; }
        public bool TheThuyTinhMT_Vo { get; set; }
        public bool TheThuyTinhMT_DuoiBao { get; set; }
        public bool TheThuyTinhMT_ToanBo { get; set; }
        public string DichMP { get; set; }
        public string DichMT { get; set; }
        public string DayMatVongMacMP { get; set; }
        public string DayMatVongMacMT { get; set; }
        public string DayMatHoangDiemMP { get; set; }
        public string DayMatHoangDiemMT { get; set; }
        public bool DayMatTanMachMP_Khong { get; set; }
        public bool DayMatTanMachMP_Co { get; set; }
        public bool DayMatTanMachMT_Khong { get; set; }
        public bool DayMatTanMachMT_Co { get; set; }
        public bool DayMatXuatHuyetMP_Khong { get; set; }
        public bool DayMatXuatHuyetMP_Co { get; set; }
        public bool DayMatXuatHuyetMT_Khong { get; set; }
        public bool DayMatXuatHuyetMT_Co { get; set; }
        public bool DayMatVienThanKinhMP_Khong { get; set; }
        public bool DayMatVienThanKinhMP_Co { get; set; }
        public bool DayMatVienThanKinhMT_Khong { get; set; }
        public bool DayMatVienThanKinhMT_Co { get; set; }
        public bool DiaThiGiaVienThanKinhMP_Duoi { get; set; }
        public bool DiaThiGiaVienThanKinhMP_Tren { get; set; }
        public bool DiaThiGiaVienThanKinhMP_Mui { get; set; }
        public bool DiaThiGiaVienThanKinhMP_TDuong { get; set; }
        public bool DiaThiGiaVienThanKinhMT_Duoi { get; set; }
        public bool DiaThiGiaVienThanKinhMT_Tren { get; set; }
        public bool DiaThiGiaVienThanKinhMT_Mui { get; set; }
        public bool DiaThiGiaVienThanKinhMT_TDuong { get; set; }
        public string DiaThiGiacMauSacMP { get; set; }
        public string DiaThiGiacMauSacMT { get; set; }
        public string DiaThiGiacCDMP { get; set; }
        public string DiaThiGiacCDMT { get; set; }
        public bool DiaThiGiacMachMauMP_BinhThuong { get; set; }
        public bool DiaThiGiacMachMauMP_ChHuong { get; set; }
        public bool DiaThiGiacMachMauMP_GapGoc { get; set; }
        public bool DiaThiGiacMachMauMT_BinhThuong { get; set; }
        public bool DiaThiGiacMachMauMT_ChHuong { get; set; }
        public bool DiaThiGiacMachMauMT_GapGoc { get; set; }
        public bool DiaThiGiacXuatHuetMP_Khong { get; set; }
        public bool DiaThiGiacXuatHuetMP_Co { get; set; }
        public bool DiaThiGiacXuatHuetMT_Khong { get; set; }
        public bool DiaThiGiacXuatHuetMT_Co { get; set; }
        public bool DiaThiGiacTeoCanhGaiMP_Khong { get; set; }
        public bool DiaThiGiacTeoCanhGaiMP_Co { get; set; }
        public bool DiaThiGiacTeoCanhGaiMT_Khong { get; set; }
        public bool DiaThiGiacTeoCanhGaiMT_Co { get; set; }
        public string VanNhanMP { get; set; }
        public string VanNhanMT { get; set; }
        public bool NhanCauMP_BinhThuong { get; set; }
        public bool NhanCauMP_DanNoi { get; set; }
        public bool NhanCauMP_To { get; set; }
        public bool NhanCauMP_Nho { get; set; }
        public bool NhanCauMT_BinhThuong { get; set; }
        public bool NhanCauMT_DanNoi { get; set; }
        public bool NhanCauMT_To { get; set; }
        public bool NhanCauMT_Nho { get; set; }
        public string HocMatMP { get; set; }
        public string HocMatMT { get; set; }
        public string ToanThanHuyetAp { get; set; }
        public string ToanThanNhietDo { get; set; }
        public string ToanThanMach { get; set; }
        public bool NoiTiet_BinhThuong { get; set; }
        public bool NoiTiet_CoBenh { get; set; }
        public string NoiTiet { get; set; }
        public bool ThanKinh_BinhThuong { get; set; }
        public bool ThanKinh_CoBenh { get; set; }
        public bool TuanHoan_BinhThuong { get; set; }
        public bool TuanHoan_CoBenh { get; set; }
        public bool HoHap_BinhThuong { get; set; }
        public bool HoHap_CoBenh { get; set; }
        public bool TieuHoa_BinhThuong { get; set; }
        public bool TieuHoa_CoBenh { get; set; }
        public bool CoXuongKhop_BinhThuong { get; set; }
        public bool CoXuongKhop_CoBenh { get; set; }
        public bool TietNieuSinhDuc_BinhThuong { get; set; }
        public bool TietNieuSinhDuc_CoBenh { get; set; }
        public string BenhChinhMP { get; set; }
        public string BenhChinhMT { get; set; }
        public string BenhKemTheoMP { get; set; }
        public string BenhKemTheoMT { get; set; }
        public string BenhToanThan { get; set; }
        public string ChiDinhDieuTri { get; set; }
        // bactv add
        public string ChanDoanRaVien { get; set; }
        public string ChanDoanRaVien_MatPhai { get; set; }
        public string MaChanDoanRaVien_MatPhai { get; set; }
        public string ChanDoanRaVien_MatTrai { get; set; }
        public string MaChanDoanRaVien_MatTrai { get; set; }
        public bool PPDT_PhauThuat { get; set; }
        public string PPDT_PhauThuatText { get; set; }
        public bool PPDT_Thuoc { get; set; }
        public string PPDT_ThuocText { get; set; }
        public bool PPDT_Laser { get; set; }
        public string PPDT_LaserText { get; set; }
        public string TinhTrangRaVien_MatPhai { get; set; }
        public string TinhTrangRaVien_MatTrai { get; set; }
        public string RaVienMP_KhongKinh { get; set; }
        public string RaVienMT_KhongKinh { get; set; }
        public string RaVienMP_CoKinh { get; set; }
        public string RaVienMT_CoKinh { get; set; }
        public string RaVienNhanApMP { get; set; }
        public string RaVienNhanApMT { get; set; }
        public bool HuongDieuTri_TheoDoi { get; set; }
        public string HuongDieuTri_TheoDoiText { get; set; }
        public bool HuongDieuTri_PhauThuat { get; set; }
        public string HuongDieuTri_PhauThuatText { get; set; }
        public bool HuongDieuTri_Laser { get; set; }
        public string HuongDieuTri_LaserText { get; set; }
        public bool HuongDieuTri_Thuoc { get; set; }
        public string HuongDieuTri_ThuocText { get; set; }
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
        public bool ChuaThayBenhLy { get; set; }
        public bool BenhLy { get; set; }
        public string BenhLy_Text { get; set; }
        public bool PhauThuat { set; get; }
        public bool ThuThuat { get; set; }
        public string ThiLucKhiRaVien_KhongKinh_MP { get; set; }
        public string ThiLucKhiRaVien_KhongKinh_MT { get; set; }
        public string ThiLucKhiRaVien_CoKinh_MP { get; set; }
        public string ThiLucKhiRaVien_CoKinh_MT { get; set; }
        public string NhanApRaVien_MT { get; set; }
        public string NhanApRaVien_MP { get; set; }
        // bactv add
        public bool[] NoiTiet_Array { get; } = new bool[] { false, false };
        public int NoiTietCheck
        {
            get
            {
                return Array.IndexOf(NoiTiet_Array, true) + 1;
            }
            set
            {
                for (int i = 0; i < NoiTiet_Array.Length; i++)
                {
                    if (i == (value - 1)) NoiTiet_Array[i] = true;
                    else NoiTiet_Array[i] = false;
                }
            }
        }
        public string NoiTiet_Text { get; set; }
        public bool[] ThanKinh_Array { get; } = new bool[] { false, false };
        public int ThanKinhCheck
        {
            get
            {
                return Array.IndexOf(ThanKinh_Array, true) + 1;
            }
            set
            {
                for (int i = 0; i < ThanKinh_Array.Length; i++)
                {
                    if (i == (value - 1)) ThanKinh_Array[i] = true;
                    else ThanKinh_Array[i] = false;
                }
            }
        }
        public string ThanKinh_Text { get; set; }
        public bool[] TuanHoan_Array { get; } = new bool[] { false, false };
        public int TuanHoanCheck
        {
            get
            {
                return Array.IndexOf(TuanHoan_Array, true) + 1;
            }
            set
            {
                for (int i = 0; i < TuanHoan_Array.Length; i++)
                {
                    if (i == (value - 1)) TuanHoan_Array[i] = true;
                    else TuanHoan_Array[i] = false;
                }
            }
        }
        public string TuanHoan_Text { get; set; }
        public bool[] HoHap_Array { get; } = new bool[] { false, false };
        public int HoHapCheck
        {
            get
            {
                return Array.IndexOf(HoHap_Array, true) + 1;
            }
            set
            {
                for (int i = 0; i < HoHap_Array.Length; i++)
                {
                    if (i == (value - 1)) HoHap_Array[i] = true;
                    else HoHap_Array[i] = false;
                }
            }
        }
        public string HoHap_Text { get; set; }
        public bool[] TieuHoa_Array { get; } = new bool[] { false, false };
        public int TieuHoaCheck
        {
            get
            {
                return Array.IndexOf(TieuHoa_Array, true) + 1;
            }
            set
            {
                for (int i = 0; i < TieuHoa_Array.Length; i++)
                {
                    if (i == (value - 1)) TieuHoa_Array[i] = true;
                    else TieuHoa_Array[i] = false;
                }
            }
        }
        public string TieuHoa_Text { get; set; }
        public bool[] CoXuongKhop_Array { get; } = new bool[] { false, false };
        public int CoXuongKhopCheck
        {
            get
            {
                return Array.IndexOf(CoXuongKhop_Array, true) + 1;
            }
            set
            {
                for (int i = 0; i < CoXuongKhop_Array.Length; i++)
                {
                    if (i == (value - 1)) CoXuongKhop_Array[i] = true;
                    else CoXuongKhop_Array[i] = false;
                }
            }
        }
        public string CoXuongKhop_Text { get; set; }
        public bool[] TietNieuSinhDuc_Array { get; } = new bool[] { false, false };
        public int TietNieuSinhDucCheck
        {
            get
            {
                return Array.IndexOf(TietNieuSinhDuc_Array, true) + 1;
            }
            set
            {
                for (int i = 0; i < TietNieuSinhDuc_Array.Length; i++)
                {
                    if (i == (value - 1)) TietNieuSinhDuc_Array[i] = true;
                    else TietNieuSinhDuc_Array[i] = false;
                }
            }
        }
        public string TietNieuSinhDuc_Text { get; set; }
        public string KhamBenhToanThan_Khac { get; set; }
    }
    public class ThuocHaNhanApDaDungs
    {
        public int ID { get; set; }
        public string Mat { get; set; }
        public string TenThuoc { get; set; }
        public string DuongDung { get; set; }
        public string LieuDung { get; set; }
        public string ThoiGianDung { get; set; }
        public string GhiChu { get; set; }
    }
}
