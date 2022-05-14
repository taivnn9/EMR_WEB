using EMR.KyDienTu;
using EMR_MAIN.DATABASE;
using PMS.Access;
using System;

namespace EMR_MAIN
{
    public class BenhAnMatTreEm : BenhAnBase, IBase
    {
        public int IDMauPhieu { get; set; } = (int)DanhMucPhieu.BAMTE;
        public string TenMauPhieu { get; set; } = DanhMucPhieu.BAMTE.Description();
        public bool DaDieuTri_NoiKhoa { get; set; }
        public string DaDieuTri_PhauThuat { get; set; }
        public bool NguyenNhan_BamSinh { get; set; }
        public string NguyenNhan_TuBaoGio { get; set; }
        public bool TrieuChung_NhinMo { get; set; }
        public bool TrieuChung_DauNhuc { get; set; }
        public bool TrieuChung_DoMat { get; set; }
        public bool TrieuChung_ChoiMat { get; set; }
        public bool TienSuBenhBanThan_Tick { get; set; }
        public bool TienSuBenhGiaDinh_Tick { get; set; }
        public bool TienSuThaiNghenBenhLy { get; set; }
        public string TienSuThaiNghenBenhLy_Text { get; set; }
        public bool PhatTrienTriTue { get; set; }
        public string PhatTrienTriTue_BenhLyText { get; set; }
        public string ThiLucKhiVaoVien_KhongKinh_MP { get; set; }
        public string ThiLucKhiVaoVien_KhongKinh_MT { get; set; }
        public string ThiLucKhiVaoVien_CoKinh_MP { get; set; }
        public string ThiLucKhiVaoVien_CoKinh_MT { get; set; }
        public string NhanApVaoVien_MT { get; set; }
        public string NhanApVaoVien_MP { get; set; }
        public string ThiTruong_MP { get; set; }
        public string ThiTruong_MT { get; set; }
        public bool VanNhanNoiTai_MP { get; set; }
        public string VanNhanNoiTai_Text_MP { get; set; }
        public bool VanNhanNoiTai_MT { get; set; }
        public string VanNhanNoiTai_Text_MT { get; set; }
        public bool VanNhanNgoaiLai_MP { get; set; }
        public string VanNhanNgoaiLai_Text_MP { get; set; }
        public bool VanNhanNgoaiLai_MT { get; set; }
        public string VanNhanNgoaiLai_Text_MT { get; set; }
        public bool RungGiatNhanCau { get; set; }
        public string RungGiatNhanCau_Text { get; set; }
        public bool MiMat_Quam_MP { get; set; }
        public bool MIMat_Epicanthus { get; set; }
        public bool MiMat_SupMi_MP { get; set; }
        public bool MiMat_U_MP { get; set; }
        public string MiMat_Khac_MP { get; set; }
        public string LeDao_MP { get; set; }
        public bool KetMac_CuongTu_MP { get; set; }
        public bool KetMac_XuatHuyet_MP { get; set; }
        public bool KetMac_XuatTiet_MP { get; set; }
        public bool KetMac_U_MP { get; set; }
        public string KetMac_Khac_MP { get; set; }
        public bool GiacMac_Trong_MP { get; set; }
        public string GiacMac_Trong_Text_MP { get; set; }
        public bool GiacMac_LoaiDuong_MP { get; set; }
        public string GiacMac_LoanDuong_Text_MP { get; set; }
        public bool GiacMac_ThoaiHoa_MP { get; set; }
        public string GiacMac_ThoaiHoa_Text_MP { get; set; }
        public string GiacMac_PhuNe_MP { get; set; }
        public string GiacMac_U_MP { get; set; }
        public string GiacMac_Tua_MP { get; set; }
        public string GiacMac_Loet_MP { get; set; }
        public string GiacMac_DiTat_MP { get; set; }
        public string GiacMac_DuongKinhGM_MP { get; set; }
        public string GiacMac_VungRia_MP { get; set; }
        public string GiacMac_Khac_MP { get; set; }
        public bool CungMac_GianLoi_MP { get; set; }
        public bool CungMac_SeoMo_MP { get; set; }
        public string CungMac_CuongTu_MP { get; set; }
        public string CungMac_Viem_MP { get; set; }
        public string CungMac_Khac_MP { get; set; }
        public string TienPhong_DoSau_MP { get; set; }
        public bool TienPhong_Tydall_MP { get; set; }
        public bool TienPhong_Mu_MP { get; set; }
        public string TienPhong_Mau_MP { get; set; }
        public string TienPhong_GocTienPhong_MP { get; set; }
        public string MongMat_MP { get; set; }
        public string MongMat_MauSac_MP { get; set; }
        public bool MongMat_TinhTrang_MP { get; set; }
        public bool MongMat_TanMach_MP { get; set; }
        public bool MongMat_CamGiac_MP { get; set; }
        public string MongMat_U_MP { get; set; }
        public string MongMat_DiDang_MP { get; set; }
        public bool[] DongTu_Trong_MPArray { get; } = new bool[] { false, false };
        public int DongTu_Trong_MP
        {
            get
            {
                return Array.IndexOf(DongTu_Trong_MPArray, true) + 1;
            }
            set
            {
                for (int i = 0; i < 2; i++)
                {
                    if (i == value - 1) DongTu_Trong_MPArray[i] = true;
                    else DongTu_Trong_MPArray[i] = false;
                }
            }
        }
        public string DongTu_DuongKinh_MP { get; set; }
        public string DongTu_VienSacTo_MP { get; set; }
        public int DongTu_PhanXa_MP { get; set; }
        public string DongTu_DiDang_MP { get; set; }
        public int TheThuyTinh_MP { get; set; }
        public bool DichKinh_MP { get; set; }
        public string DichKinh_Text_MP { get; set; }
        public string DayMat_VongMac_MP { get; set; }
        public string DayMat_HoangDiem_MP { get; set; }
        public string DayMat_MachMau_MP { get; set; }
        public string DayMat_DiaThi_MP { get; set; }
        public string DayMat_U_MP { get; set; }
        public bool NhanCau_Mem_MP { get; set; }
        public int NhanCau_To_MP { get; set; }
        public bool MiMat_Quam_MT { get; set; }
        public bool MIMat_EpicanthusMT { get; set; }
        public bool MiMat_SupMi_MT { get; set; }
        public bool MiMat_U_MT { get; set; }
        public string MiMat_Khac_MT { get; set; }
        public string LeDao_MT { get; set; }
        public bool KetMac_CuongTu_MT { get; set; }
        public bool KetMac_XuatHuyet_MT { get; set; }
        public bool KetMac_XuatTiet_MT { get; set; }
        public bool KetMac_U_MT { get; set; }
        public string KetMac_Khac_MT { get; set; }
        public bool GiacMac_Trong_MT { get; set; }
        public string GiacMac_Trong_Text_MT { get; set; }
        public bool GiacMac_LoaiDuong_MT { get; set; }
        public string GiacMac_LoanDuong_Text_MT { get; set; }
        public bool GiacMac_ThoaiHoa_MT { get; set; }
        public string GiacMac_ThoaiHoa_Text_MT { get; set; }
        public string GiacMac_PhuNe_MT { get; set; }
        public string GiacMac_U_MT { get; set; }
        public string GiacMac_Tua_MT { get; set; }
        public string GiacMac_Loet_MT { get; set; }
        public string GiacMac_DiTat_MT { get; set; }
        public string GiacMac_DuongKinhGM_MT { get; set; }
        public string GiacMac_VungRia_MT { get; set; }
        public string GiacMac_Khac_MT { get; set; }
        public bool CungMac_GianLoi_MT { get; set; }
        public bool CungMac_SeoMo_MT { get; set; }
        public string CungMac_CuongTu_MT { get; set; }
        public string CungMac_Viem_MT { get; set; }
        public string CungMac_Khac_MT { get; set; }
        public string TienPhong_DoSau_MT { get; set; }
        public bool TienPhong_Tydall_MT { get; set; }
        public bool TienPhong_Mu_MT { get; set; }
        public string TienPhong_Mau_MT { get; set; }
        public string TienPhong_GocTienPhong_MT { get; set; }
        public string MongMat_MT { get; set; }
        public string MongMat_MauSac_MT { get; set; }
        public bool MongMat_TinhTrang_MT { get; set; }
        public bool MongMat_TanMach_MT { get; set; }
        public bool MongMat_CamGiac_MT { get; set; }
        public string MongMat_U_MT { get; set; }
        public string MongMat_DiDang_MT { get; set; }
        public bool[] DongTu_Trong_MTArray { get; } = new bool[] { false, false };
        public int DongTu_Trong_MT
        {
            get
            {
                return Array.IndexOf(DongTu_Trong_MTArray, true) + 1;
            }
            set
            {
                for (int i = 0; i < 2; i++)
                {
                    if (i == value - 1) DongTu_Trong_MTArray[i] = true;
                    else DongTu_Trong_MTArray[i] = false;
                }
            }
        }
        public string DongTu_DuongKinh_MT { get; set; }
        public string DongTu_VienSacTo_MT { get; set; }
        public int DongTu_PhanXa_MT { get; set; }
        public string DongTu_DiDang_MT { get; set; }
        public int TheThuyTinh_MT { get; set; }
        public bool DichKinh_MT { get; set; }
        public string DichKinh_Text_MT { get; set; }
        public string DayMat_VongMac_MT { get; set; }
        public string DayMat_HoangDiem_MT { get; set; }
        public string DayMat_MachMau_MT { get; set; }
        public string DayMat_DiaThi_MT { get; set; }
        public string DayMat_U_MT { get; set; }
        public bool NhanCau_Mem_MT { get; set; }
        public int NhanCau_To_MT { get; set; }
        public string HuyetAp_ToanThan { get; set; }
        public string NhietDo_ToanThan { get; set; }
        public string Mach_ToanThan { get; set; }
        public bool NoiTiet_Tick { get; set; }
        public string NoiTiet { get; set; }
        public bool ThanKinh_Tick { get; set; }
        public bool TuanHoan_Tick { get; set; }
        public bool HoHap_Tick { get; set; }
        public bool TieuHoa_Tick { get; set; }
        public bool CoXuongKhop_Tick { get; set; }
        public bool ThanTietNieu_Tick { get; set; }
        public string BenhChinh_MatPhai { get; set; }
        public string BenhChinh_MatTrai { get; set; }
        public string PhuongPhapChinh { get; set; }
        public string CheDoAnUong { get; set; }
        public string CheDoChamSoc { get; set; }
        public string ChanDoanBenhChinh_LamSang { get; set; }
        public string ChanDoanBenhChinh_NguyenNhan { get; set; }
        public string QuaTrinhDieuTri_NoiKhoa { get; set; }
        public string QuaTrinhDieuTri_KetQua { get; set; }
        public string QuaTrinhDieuTri_BienChung { get; set; }
        public string HuongDieuTriTiep { get; set; }
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

        //https://redmine.vietsens.vn/redmine/issues/70008
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
}
