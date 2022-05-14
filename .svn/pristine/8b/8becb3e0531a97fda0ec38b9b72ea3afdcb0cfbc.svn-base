using EMR.KyDienTu;
using PMS.Access;
using System;

namespace EMR_MAIN.DATABASE.BenhAn
{
    public class BenhAnNgoaiTru_BenhVayNenThongThuong : IBase
    {
        public int IDMauPhieu { get; set; } = (int)DanhMucPhieu.BANgTruBVNTT;
        public string TenMauPhieu { get; set; } = DanhMucPhieu.BANgTruBVNTT.Description();
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

        // hoibenh
        // 1. Bệnh sử - tiền sử
        public string KhoiPhatBenh { get; set; }
        public string TrieuChungDauTien { get; set; }
        public string LanNhapVien { get; set; }
        public int TSGD_MacVayNen { get; set; }
        public string TSGD_MacVayNen_Text { get; set; }
        public int TSCN_BenhKhac { get; set; }
        public bool[] TienSuCaNhanArray { get; } = new bool[] { false, false, false, false, false, false, false, false, false, false, false, false, false, false, false };
        public string TienSuCaNhan
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < TienSuCaNhanArray.Length; i++)
                    temp += (TienSuCaNhanArray[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        TienSuCaNhanArray[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public string TienSuCaNhan_Khac { get; set; }
        public bool[] ThoiQuenCaNhanArray { get; } = new bool[] { false, false, false };
        public string ThoiQuenCaNhan
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < ThoiQuenCaNhanArray.Length; i++)
                    temp += (ThoiQuenCaNhanArray[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        ThoiQuenCaNhanArray[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public string ThoiQuenCaNhan_Khac { get; set; }
        public int YeuToTinhThan { get; set; }
        public bool[] ViTriKhoiPhatArray { get; } = new bool[] { false, false, false, false };
        public string ViTriKhoiPhat
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < ViTriKhoiPhatArray.Length; i++)
                    temp += (ViTriKhoiPhatArray[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        ViTriKhoiPhatArray[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public string ViTriKhoiPhat_Khac { get; set; }
        public bool[] ThoiQuenCaNhan2Array { get; } = new bool[] { false, false, false };
        public string ThoiQuenCaNhan2
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < ThoiQuenCaNhan2Array.Length; i++)
                    temp += (ThoiQuenCaNhan2Array[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        ThoiQuenCaNhan2Array[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public string ThoiQuenCaNhan2_Khac { get; set; }
        public int YeuToTinhThan2 { get; set; }
        public bool[] ViTriKhoiPha2tArray { get; } = new bool[] { false, false, false, false };
        public string ViTriKhoiPhat2
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < ViTriKhoiPha2tArray.Length; i++)
                    temp += (ViTriKhoiPha2tArray[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        ViTriKhoiPha2tArray[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public string ViTriKhoiPhat2_Khac { get; set; }
        public bool[] MuaNangArray { get; } = new bool[] { false, false, false, false };
        public string MuaNang
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < MuaNangArray.Length; i++)
                    temp += (MuaNangArray[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        MuaNangArray[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        // 3. Toàn trạng
        public int Sot { get; set; }
        public string Sot_Do { get; set; }
        public int Hach { get; set; }
        public int MetMoi { get; set; }

        public string HA { get; set; }
        public string Mach { get; set; }

        public bool[] TrieuChungCoNangArray { get; } = new bool[] { false, false, false };
        public string TrieuChungCoNang
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < TrieuChungCoNangArray.Length; i++)
                    temp += (TrieuChungCoNangArray[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        TrieuChungCoNangArray[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public string Can { get; set; }
        public string Cao { get; set; }
        public string VongBung { get; set; }
        // 4. Lâm sàng da
        public bool[] PhanLoaiTheoKTArray { get; } = new bool[] { false, false, false, false };
        public string PhanLoaiTheoKT
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < PhanLoaiTheoKTArray.Length; i++)
                    temp += (PhanLoaiTheoKTArray[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        PhanLoaiTheoKTArray[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public bool[] PhanLoaiTheoVTArray { get; } = new bool[] { false, false, false, false, false };
        public string PhanLoaiTheoVT
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < PhanLoaiTheoVTArray.Length; i++)
                    temp += (PhanLoaiTheoVTArray[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        PhanLoaiTheoVTArray[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public bool[] PhanLoaiTheoMDArray { get; } = new bool[] { false, false, false };
        public string PhanLoaiTheoMD
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < PhanLoaiTheoMDArray.Length; i++)
                    temp += (PhanLoaiTheoMDArray[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        PhanLoaiTheoMDArray[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public DateTime? NgayDanhGiaPASI { get; set; }
        public string DiemPasi1 { get; set; }
        public string DiemPasi2 { get; set; }
        public string DiemPasi3 { get; set; }
        public string DiemPasi4 { get; set; }
        public string DiemPasi { get; set; }
        public string DiemPasi_Text { get; set; }
        public bool[] DanhGiaPASIArray { get; } = new bool[] { false, false };
        public string DanhGiaPASI
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < DanhGiaPASIArray.Length; i++)
                    temp += (DanhGiaPASIArray[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        DanhGiaPASIArray[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        // 5. biểu hiện móng
        public int RoMong { get; set; }
        public string RoMong_Text { get; set; }
        public int MongDay_Mun { get; set; }
        public int DuongVanNgang { get; set; }
        public int LiemMong { get; set; }
        public int TachMong { get; set; }
        public string TachMong_Text { get; set; }
        public int DaySung { get; set; }
        public int DauHieuGiotDau { get; set; }
        public string DauHieuGiotDau_Text { get; set; }
        public int XuatHuyet { get; set; }
        public int ViemQuanhMong { get; set; }
        public DiemNAPSI NAPSI_TayPhai { get; set; }
        public DiemNAPSI NAPSI_TayTrai { get; set; }
        public DiemNAPSI NAPSI_ChanPhai { get; set; }
        public DiemNAPSI NAPSI_ChanTrai { get; set; }
        public string TongDiemNAPSI { get; set; }
        //6. bieu hien khop
        public string SoKhopDau { get; set; }
        public string SoKhopSung { get; set; }
        public string DAS28 { get; set; }
        public bool[] ViemKhopArray { get; } = new bool[] { false, false, false };
        public string ViemKhop
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < ViemKhopArray.Length; i++)
                    temp += (ViemKhopArray[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        ViemKhopArray[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }

        public int BienDangKhop { get; set; }
        public string BienDangKhop_Text { get; set; }
        // 7. biểu hiện niêm mạc
        public int BieuHienNiemMac { get; set; }
        public string BieuHienNiemMac_ViTri { get; set; }
        //8. Các biểu hiện lâm sàng khác
        public string BieuHienKhac_TimMach { get; set; }
        public string BieuHienKhac_HoHap { get; set; }
        public string BieuHienKhac_TieuHoa { get; set; }
        public string BieuHienKhac_TamThan { get; set; }
        // 9. ĐIỂM DLQI (Dermatology life Quality index)
        public int DiemDLQI_1 { get; set; }
        public int DiemDLQI_2 { get; set; }
        public int DiemDLQI_3 { get; set; }
        public int DiemDLQI_4 { get; set; }
        public int DiemDLQI_5 { get; set; }
        public int DiemDLQI_6 { get; set; }
        public int DiemDLQI_7 { get; set; }
        public int DiemDLQI_8 { get; set; }
        public int DiemDLQI_9 { get; set; }
        public int DiemDLQI_10 { get; set; }
        public string TongDiem { get; set; }
        // 10. xét nghiệm
        public string CTM_HC { get; set; }
        public string CTM_Hb { get; set; }
        public string CTM_HCT { get; set; }
        public string CTM_TieuCau { get; set; }
        public string CTM_BachCau { get; set; }
        public string CTM_Lympho { get; set; }
        public string CTM_TT { get; set; }
        public string CTM_Mono { get; set; }
        public string MauLang_1 { get; set; }
        public string MauLang_2 { get; set; }
        public string SinhHoa_Ure { get; set; }
        public string SinhHoa_Cre1 { get; set; }
        public string SinhHoa_Glu { get; set; }
        public string SinhHoa_Cre2 { get; set; }
        public string SinhHoa_Uric { get; set; }
        public string SinhHoa_TP { get; set; }
        public string SinhHoa_TT { get; set; }
        public string SinhHoa_GT { get; set; }
        public string SinhHoa_ProteinTP { get; set; }
        public string SinhHoa_Alb { get; set; }
        public string SinhHoa_Cholesterol { get; set; }
        public string SinhHoa_Tri { get; set; }
        public string SinhHoa_HDL { get; set; }
        public string SinhHoa_LDL { get; set; }
        public string SinhHoa_GOT { get; set; }
        public string SinhHoa_GPT { get; set; }
        public string SinhHoa_CK { get; set; }
        public string SinhHoa_DGD_Na { get; set; }
        public string SinhHoa_DGD_K { get; set; }
        public string SinhHoa_DGD_Cl { get; set; }
        public string SinhHoa_DGD_Ca { get; set; }
        public string SinhHoa_DGD_CaIonHoa { get; set; }
        public string SinhHoa_DGD_HbA1c { get; set; }
        public int ProteinNieu { get; set; }
        public int TruNieu { get; set; }
        public int HCNieu { get; set; }
        public int BCNieu { get; set; }
        public int NuocTieu24H { get; set; }
        public string XQXuongKhop { get; set; }
        public DateTime? SinhThiet_NgayLam { get; set; }
        public string SinhThiet_ViTri { get; set; }
        public int ThuongBi_ASung { get; set; }
        public int ThuongBi_TangSung { get; set; }
        public int ThuongBi_GiamLopHat { get; set; }
        public int ThuongBi_PhiaTrenNhuBi { get; set; }
        public int ThuongBi_ViApsxe { get; set; }
        public int ThuongBi_MunMu { get; set; }
        public int ThuongBi_QuaSan { get; set; }
        public int ThuongBi_GianMachMau { get; set; }
        public int TrungBi_ThamNhiem { get; set; }
        public int TrungBi_Lympho { get; set; }
        public string TrungBi_Khac { get; set; }
        public string SinhThietMong { get; set; }
        public DateTime? Interleukin_NgayLayMau { get; set; }
        public string Interleukin_IL17 { get; set; }
        public string Interleukin_IL23 { get; set; }
        public string XetNghiemKhac { get; set; }
        // 11. Điều trị 
        public int ThuocTieuSung { get; set; }
        public int ThuocGiuAm { get; set; }
        public int Corticorid { get; set; }
        public int Calcipotriol { get; set; }
        public int VitaminA { get; set; }
        public int Tarcrolimus { get; set; }
        public string ThuocBoi_Khac { get; set; }
        public ThuocToanThan Methotrexate { get; set; }
        public ThuocToanThan VitaminAAcid { get; set; }
        public ThuocToanThan Cyclosporine { get; set; }
        public ThuocToanThan Corticosteroid { get; set; }
        public ThuocToanThan ChePhamSinhHoc1 { get; set; }
        public ThuocToanThan ChePhamSinhHoc2 { get; set; }
        public ThuocToanThan ChePhamSinhHoc3 { get; set; }
        public ThuocToanThan YHocCoTruyen { get; set; }
        public ThuocToanThan ThuocKhac { get; set; }
        public int DieuTriAnhSang { get; set; }
        public bool[] DieuTriAnhSang_Co_Array { get; } = new bool[] { false, false, false, false };
        public string DieuTriAnhSang_Co
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < DieuTriAnhSang_Co_Array.Length; i++)
                    temp += (DieuTriAnhSang_Co_Array[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        DieuTriAnhSang_Co_Array[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        //13. Điều trị 
        public bool[] PPDieuTri_Array { get; } = new bool[] { false, false, false };
        public string PPDieuTri
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < PPDieuTri_Array.Length; i++)
                    temp += (PPDieuTri_Array[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        PPDieuTri_Array[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public string DieuTri_CuThe { get; set; }
        public DateTime? HenKhamLai { get; set; }
        public string BacSyKhamBenh { get; set; }
        public string MaBacSyKhambenh { get; set; }


        // Phần tái khám
        public string TK_HoTen { get; set; }
        public string TK_SoBADienTu { get; set; }
        public DateTime? TK_Ngay { get; set; }
        public string TK_SoLuuTru { get; set; }
        public int TK_Sot { get; set; }
        public string TK_Sot_Do { get; set; }
        public int TK_Hach { get; set; }
        public int TK_MetMoi { get; set; }
        public string TK_HA { get; set; }
        public string TK_Mach { get; set; }
        public bool[] TK_TrieuChungCoNangArray { get; } = new bool[] { false, false, false };
        public string TK_TrieuChungCoNang
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < TK_TrieuChungCoNangArray.Length; i++)
                    temp += (TK_TrieuChungCoNangArray[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        TK_TrieuChungCoNangArray[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public string TK_TienSu { get; set; }
        public string TK_DiemPasi1 { get; set; }
        public string TK_DiemPasi2 { get; set; }
        public string TK_DiemPasi3 { get; set; }
        public string TK_DiemPasi4 { get; set; }
        public string TK_DiemPasi { get; set; }
        public string TK_DiemPasi_Text { get; set; }
        public string TK_TongDiemNAPSI { get; set; }
        public string TK_SoKhopDau { get; set; }
        public string TK_SoKhopSung { get; set; }
        public string TK_DAS28 { get; set; }
        public bool[] TK_ViemKhopArray { get; } = new bool[] { false, false, false };
        public string TK_ViemKhop
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < TK_ViemKhopArray.Length; i++)
                    temp += (TK_ViemKhopArray[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        TK_ViemKhopArray[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }

        public int TK_BienDangKhop { get; set; }
        public string TK_BienDangKhop_Text { get; set; }
        // 7. biểu hiện niêm mạc
        public int TK_BieuHienNiemMac { get; set; }
        public string TK_BieuHienNiemMac_ViTri { get; set; }
        //8. Các biểu hiện lâm sàng khác
        public string TK_BieuHienKhac_TimMach { get; set; }
        public string TK_BieuHienKhac_TietNieu { get; set; }
        public string TK_BieuHienKhac_HoHap { get; set; }
        public string TK_BieuHienKhac_TieuHoa { get; set; }
        public string TK_BieuHienKhac_TamThan { get; set; }
        public string TK_BieuHienKhac_CoQuanKhac { get; set; }
        // 9. ĐIỂM DLQI (Dermatology life Quality index)
        public int TK_DiemDLQI_1 { get; set; }
        public int TK_DiemDLQI_2 { get; set; }
        public int TK_DiemDLQI_3 { get; set; }
        public int TK_DiemDLQI_4 { get; set; }
        public int TK_DiemDLQI_5 { get; set; }
        public int TK_DiemDLQI_6 { get; set; }
        public int TK_DiemDLQI_7 { get; set; }
        public int TK_DiemDLQI_8 { get; set; }
        public int TK_DiemDLQI_9 { get; set; }
        public int TK_DiemDLQI_10 { get; set; }
        public string TK_TongDiem { get; set; }
        // 10. xét nghiệm
        public string TK_CTM_HC { get; set; }
        public string TK_CTM_Hb { get; set; }
        public string TK_CTM_HCT { get; set; }
        public string TK_CTM_TieuCau { get; set; }
        public string TK_CTM_BachCau { get; set; }
        public string TK_CTM_Lympho { get; set; }
        public string TK_CTM_TT { get; set; }
        public string TK_CTM_Mono { get; set; }
        public string TK_CTM_Khac { get; set; }
        public string TK_MauLang_1 { get; set; }
        public string TK_MauLang_2 { get; set; }
        public string TK_SinhHoa_Ure { get; set; }
        public string TK_SinhHoa_Cre { get; set; }
        public string TK_SinhHoa_Glu { get; set; }
        public string TK_SinhHoa_Uric { get; set; }
        public string TK_SinhHoa_TP { get; set; }
        public string TK_SinhHoa_TT { get; set; }
        public string TK_SinhHoa_GT { get; set; }
        public string TK_SinhHoa_Protein { get; set; }
        public string TK_SinhHoa_Alb { get; set; }
        public string TK_SinhHoa_Cholesterol { get; set; }
        public string TK_SinhHoa_Tri { get; set; }
        public string TK_SinhHoa_HDL { get; set; }
        public string TK_SinhHoa_LDL { get; set; }
        public string TK_SinhHoa_GOT { get; set; }
        public string TK_SinhHoa_GPT { get; set; }
        public string TK_SinhHoa_CK { get; set; }
        public string TK_SinhHoa_DGD_Na { get; set; }
        public string TK_SinhHoa_DGD_K { get; set; }
        public string TK_SinhHoa_DGD_Cl { get; set; }
        public string TK_SinhHoa_DGD_Ca { get; set; }
        public string TK_SinhHoa_DGD_CaIonHoa { get; set; }
        public string STK_inhHoa_DGD_HbA1c { get; set; }
        public int TK_ProteinNieu { get; set; }
        public int TK_TruNieu { get; set; }
        public int TK_HCNieu { get; set; }
        public int TK_BCNieu { get; set; }
        public string TK_XetNghiemKhac { get; set; }
        public int TK_TacDungPhu { get; set; }
        public string TK_TenThuoc { get; set; }
        public string TK_LietKeTacDungPhu { get; set; }
        public string TK_ThuocBoi { get; set; }
        public string TK_ThuocToanThan { get; set; }
        public DateTime? TK_HenKhamLai { get; set; }
        public string TK_BacSyDieuTri { get; set; }
        public string TK_MaBacSyDieuTri { get; set; }

        // Tổng kết bệnh án
        public string TK_QuaTrinhBenhLy { get; set; }
        public string TK_TomTatKetQua { get; set; }
        public string TK_BenhChinh { get; set; }
        public string TK_MaBenhChinh { get; set; }
        public string TK_BenhKemTheo { get; set; }
        public string TK_MaBenhKemTheo { get; set; }
        public string TK_PhuongPhapDieuTri { get; set; }
        public string TK_TinhTrangRaVien { get; set; }
        public string TK_HuongDieuTri { get; set; }
        public string NguoiNhanHoSo { get; set; }
        public string NguoiGiaoHoSo { get; set; }
        public DateTime NgayTongKet { get; set; }
        public string BacSyDieuTri { get; set; }
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
    public class ThuocToanThan
    {
        public int Co { get; set; }
        public string LieuDung { get; set; }
        public DateTime? NgayBatDau { get; set; }
        public string LieuBatDau { get; set; }
        public DateTime? NgayKetThuc { get; set; }
        public string LieuKetThuc { get; set; }
        public string LieuTichLuy { get; set; }
        public string TenThuoc { get; set; }
        public int HienTai { get; set; }
    }



    public class DiemNAPSI
    {
        public string DiaMong1 { get; set; }
        public string DiaMong2 { get; set; }
        public string DiaMong3 { get; set; }
        public string DiaMong4 { get; set; }
        public string DiaMong5 { get; set; }

        public string GiuongMong1 { get; set; }
        public string GiuongMong2 { get; set; }
        public string GiuongMong3 { get; set; }
        public string GiuongMong4 { get; set; }
        public string GiuongMong5 { get; set; }

        public string TongDiemNAPSI { get; set; }
    }
}
