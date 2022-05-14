using EMR.KyDienTu;
using EMR_MAIN.ViewModel;
using Newtonsoft.Json;
using PMS.Access;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Net.Http;
using System.Net.Http.Headers;

namespace EMR_MAIN.DATABASE.Other
{
    public class DanhGiaNBVaKHCS : ThongTinKy
    {
        public DanhGiaNBVaKHCS()
        {
            TableName = "DanhGiaNBVaKHCS";
            TablePrimaryKeyName = "ID";
            IDMauPhieu = (int)DanhMucPhieu.DGNBNVKHCS;
            TenMauPhieu = DanhMucPhieu.DGNBNVKHCS.Description();
        }
        [MoTaDuLieu("Mã định danh")]
		public long ID { get; set; }
        [MoTaDuLieu("Mã quản lý: mã duy nhất trong 1 đợt khám chữa bệnh (kcb), không trùng giữa các đợt kcb khác nhau","",1)]
		public decimal MaQuanLy { get; set; }
        [MoTaDuLieu("Mã bệnh nhân")]
		public string MaBenhNhan { get; set; }
        public string HoTenBenhNhan { get; set; }
        [MoTaDuLieu("Tuổi bệnh nhân")]
		public string Tuoi { get; set; }
        [MoTaDuLieu("Giới tính bệnh nhân")]
		public string GioiTinh { get; set; }
        public bool[] BHYT_Array { get; } = new bool[] { false, false };
        public int BHYT
        {
            get
            {
                return Array.IndexOf(BHYT_Array, true) + 1;
            }
            set
            {
                for (int i = 0; i < BHYT_Array.Length; i++)
                {
                    if (i == (value - 1)) BHYT_Array[i] = true;
                    else BHYT_Array[i] = false;
                }
            }
        }
        [MoTaDuLieu("Nghề nghiệp")]
		public string NgheNghiep { get; set; }
        [MoTaDuLieu("Địa chỉ nhà bệnh nhân")]
		public string DiaChi { get; set; }
        public DateTime? NgayVaoKhoa { get; set; }
        [MoTaDuLieu("Chẩn đoán bệnh")]
		public string ChanDoan { get; set; }
        [MoTaDuLieu("Giường")]
		public string Giuong { get; set; }
        [MoTaDuLieu("Buồng")]
		public string Buong { get; set; }
        [MoTaDuLieu("Địa chỉ nhà bệnh nhân")]
		public string DiaChiLienHe { get; set; }
        public string SDT { get; set; }

        // tiền sửa bệnh sử
        public string TienSuLyDoVaoVien { get; set; }
        public string TienSuBanThan { get; set; }
        public string TienSuGiaDinh { get; set; }
        public bool[] TienSuDiUng_Array { get; } = new bool[] { false, false };
        public string TienSuDiUng
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < TienSuDiUng_Array.Length; i++)
                    temp += (TienSuDiUng_Array[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        TienSuDiUng_Array[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public string TenChatDiUng { get; set; }
        public string PhanUngCoThe { get; set; }
        public DateTime ThoiGianNhanDinh { get; set; }
        public DateTime ThoiGianNhanDinh_Gio { get; set; }
        // the trang
        public bool[] TheTrang_Array { get; } = new bool[] { false, false, false };
        public string TheTrang
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < TheTrang_Array.Length; i++)
                    temp += (TheTrang_Array[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        TheTrang_Array[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public double? CanNang { get; set; }
        public double? ChieuCao { get; set; }
        public double? BMI { get; set; }
        //Tinh Trang Than kinh
        public bool[] TinhTrangThanKinh_Array { get; } = new bool[] { false, false, false, false };
        public string TinhTrangThanKinh
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < TinhTrangThanKinh_Array.Length; i++)
                    temp += (TinhTrangThanKinh_Array[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        TinhTrangThanKinh_Array[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public string TinhTrangThanKinh_Khac { get; set; }
        public string DiemAPVU { get; set; }
        public string DiemGlasgow { get; set; }
        // tuan hoan
        public bool[] NhipTim_Array { get; } = new bool[] { false, false, false, false };
        [MoTaDuLieu("Nhịp tim")]
		public string NhipTim
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < NhipTim_Array.Length; i++)
                    temp += (NhipTim_Array[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        NhipTim_Array[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public bool[] Mach_Array { get; } = new bool[] { false, false };
        public string Mach
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < Mach_Array.Length; i++)
                    temp += (Mach_Array[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        Mach_Array[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public bool[] HA_Array { get; } = new bool[] { false, false, false };
        public string HA
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < HA_Array.Length; i++)
                    temp += (HA_Array[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        HA_Array[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public bool[] Chi_Array { get; } = new bool[] { false, false, false, false };
        public string Chi
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < Chi_Array.Length; i++)
                    temp += (Chi_Array[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        Chi_Array[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public string TuanHoan_Khac { get; set; }
        public bool[] ThanNhiet_Array { get; } = new bool[] { false, false, false };
        public string ThanNhiet
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < ThanNhiet_Array.Length; i++)
                    temp += (ThanNhiet_Array[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        ThanNhiet_Array[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public int? SotNgayThu { get; set; }
        [MoTaDuLieu("Nhiệt độ tối đa")]
		public string NhietDoMax { get; set; }
        public string TCSot { get; set; }
        public bool[] TuTho_Array { get; } = new bool[] { false, false, false, false };
        public string TuTho
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < TuTho_Array.Length; i++)
                    temp += (TuTho_Array[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        TuTho_Array[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public string Oxy { get; set; }
        public bool[] NhipTho_Array { get; } = new bool[] { false, false, false, false };
        public string NhipTho
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < NhipTho_Array.Length; i++)
                    temp += (NhipTho_Array[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        NhipTho_Array[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public string Khi { get; set; }
        public bool[] SuDungCoHH_Array { get; } = new bool[] { false, false };
        public string SuDungCoHH
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < SuDungCoHH_Array.Length; i++)
                    temp += (SuDungCoHH_Array[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        SuDungCoHH_Array[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public string SuDungCoMoTa { get; set; }
        public bool[] KhongHo_Array { get; } = new bool[] { false, false, false, false, false };
        public string KhongHo
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < KhongHo_Array.Length; i++)
                    temp += (KhongHo_Array[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        KhongHo_Array[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public string KhongHo_Khac { get; set; }
        public string TinhChatDom { get; set; }
        public bool[] Da_Array { get; } = new bool[] { false, false, false };
        public string Da
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < Da_Array.Length; i++)
                    temp += (Da_Array[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        Da_Array[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public string Da_Khac { get; set; }
        public bool VetBam { get; set; }
        public string VetBam_Khac { get; set; }
        public bool Loet { get; set; }
        public string Loet_Do { get; set; }
        public bool Phu { get; set; }
        public string Phu_ViTri { get; set; }
        public string Phu_TinhChat { get; set; }
        public bool[] VetMo_Array { get; } = new bool[] { false, false };
        public string VetMo
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < VetMo_Array.Length; i++)
                    temp += (VetMo_Array[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        VetMo_Array[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public string VetMoVitri { get; set; }
        public bool[] Kho_Array { get; } = new bool[] { false, false, false };
        public string Kho
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < Kho_Array.Length; i++)
                    temp += (Kho_Array[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        Kho_Array[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public string VetMo_Khac { get; set; }
        public bool DanLuu { get; set; }
        public bool[] MangTim_Array { get; } = new bool[] { false, false, false, false };
        public string MangTim
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < MangTim_Array.Length; i++)
                    temp += (MangTim_Array[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        MangTim_Array[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public string MangTim_Khac { get; set; }
        public bool[] OngDanLuu_Array { get; } = new bool[] { false, false, false, false, false };
        public string OngDanLuu
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < OngDanLuu_Array.Length; i++)
                    temp += (OngDanLuu_Array[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        OngDanLuu_Array[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public string DichSL { get; set; }
        public string DichTinhChat { get; set; }
        public int? MucDoDau { get; set; }
        public string KieuDau { get; set; }
        public bool[] Bung_Array { get; } = new bool[] { false, false, false, false, false };
        public string Bung
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < Bung_Array.Length; i++)
                    temp += (Bung_Array[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        Bung_Array[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public bool[] TuAn_Array { get; } = new bool[] { false, false, false };
        public string TuAn
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < TuAn_Array.Length; i++)
                    temp += (TuAn_Array[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        TuAn_Array[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public string TuAn_SL { get; set; }
        public int? DaiTien { get; set; }
        public string TinhChatPhan { get; set; }
        public bool[] TuTieu_Array { get; } = new bool[] { false, false };
        public string TuTieu
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < TuTieu_Array.Length; i++)
                    temp += (TuTieu_Array[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        TuTieu_Array[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public DateTime? TietNieuNgayDat { get; set; }
        public bool[] CauBQ_Array { get; } = new bool[] { false, false };
        public string CauBQ
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < CauBQ_Array.Length; i++)
                    temp += (CauBQ_Array[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        CauBQ_Array[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        [MoTaDuLieu("Số lượng nước tiểu")]
		public string NuocTieuSL { get; set; }
        [MoTaDuLieu("Màu nước tiểu")]
		public string NuocTieuMauSac { get; set; }
        [MoTaDuLieu("Thông tin nước tiểu khác")]
		public string NuocTieu_Khac { get; set; }
        public bool DuongTruyen { get; set; }
        public string DuongTruyen_ViTri { get; set; }
        public DateTime? DuongTruyen_NgayDat { get; set; }
        public string DuongTruyen_DauHieu { get; set; }
        public bool[] KhaNangNghe_Array { get; } = new bool[] { false, false, false };
        public string KhaNangNghe
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < KhaNangNghe_Array.Length; i++)
                    temp += (KhaNangNghe_Array[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        KhaNangNghe_Array[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public string KhaNangNghe_CuThe { get; set; }
        public bool[] KhaNangNoi_Array { get; } = new bool[] { false, false };
        public string KhaNangNoi
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < KhaNangNoi_Array.Length; i++)
                    temp += (KhaNangNoi_Array[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        KhaNangNoi_Array[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public string KhaNangNoi_CuThe { get; set; }
        public bool[] KhaNangNhin_Array { get; } = new bool[] { false, false };
        public string KhaNangNhin
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < KhaNangNhin_Array.Length; i++)
                    temp += (KhaNangNhin_Array[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        KhaNangNhin_Array[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public string KhaNangNhin_CuThe { get; set; }
        public bool[] VanDong_Array { get; } = new bool[] { false, false };
        public string VanDong
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < VanDong_Array.Length; i++)
                    temp += (VanDong_Array[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        VanDong_Array[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public string VanDong_CuThe { get; set; }
        public bool[] GiacNgu_Array { get; } = new bool[] { false, false };
        public string GiacNgu
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < GiacNgu_Array.Length; i++)
                    temp += (GiacNgu_Array[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        GiacNgu_Array[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public string GiacNgu_SuDungThuoc { get; set; }
        public bool[] DinhDuong_Array { get; } = new bool[] { false, false, false, false };
        public string DinhDuong
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < DinhDuong_Array.Length; i++)
                    temp += (DinhDuong_Array[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        DinhDuong_Array[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public string DinhDuong_Khac { get; set; }
        public bool[] VSCN_Array { get; } = new bool[] { false, false, false, false, false, false };
        public string VSCN
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < VSCN_Array.Length; i++)
                    temp += (VSCN_Array[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        VSCN_Array[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public string KQCLS { get; set; }
        public string NhanDinh_Khac { get; set; }
        public string ChamSocCap { get; set; }
        public string DienBienTiepTheo { get; set; }
        // ke hoach cham soc
        public string TiepNhanBN { get; set; }
        public string NhanBanGiaoTuKhoa { get; set; }
        public bool SapXepGiuongBenh { get; set; }
        public bool BaoBSKhamBN { get; set; }
        public string TheoDoiDHST { get; set; }
        public bool DoDHST { get; set; }
        public string DoDHST_Text { get; set; }
        [MoTaDuLieu("Thực hiện y lệnh")]
		public string ThucHienYLenh { get; set; }
        public bool[] THYL_Array { get; } = new bool[] { false, false, false, false, false };
        public string THYL
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < THYL_Array.Length; i++)
                    temp += (THYL_Array[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        THYL_Array[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public string THYL_Khac { get; set; }
        public bool ChamSocHoHap { get; set; }
        public string ChamSocHoHap_Text { get; set; }
        public bool[] TuTheNB_Array { get; } = new bool[] { false, false };
        public string TuTheNB
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < TuTheNB_Array.Length; i++)
                    temp += (TuTheNB_Array[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        TuTheNB_Array[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public bool[] ThoOxyMui_Array { get; } = new bool[] { false, false };
        public string ThoOxyMui
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < ThoOxyMui_Array.Length; i++)
                    temp += (ThoOxyMui_Array[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        ThoOxyMui_Array[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public string ThoOxyMask { get; set; }
        public bool VoRung { get; set; }
        public string VoRung_Text { get; set; }
        public bool KhiRung { get; set; }
        public string KhiRung_Text { get; set; }
        public bool HDNBTapTho { get; set; }
        public bool HutDom { get; set; }
        public bool[] ChamSocVetMo_Array { get; } = new bool[] { false, false, false };
        public string ChamSocVetMo
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < ChamSocVetMo_Array.Length; i++)
                    temp += (ChamSocVetMo_Array[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        ChamSocVetMo_Array[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public string ChamSocVetMo_Text { get; set; }
        public bool ThayBang { get; set; }
        public string ThayBang_Text { get; set; }
        public bool ChamSocDanLuu { get; set; }
        public bool LapHeThongDanLuu { get; set; }
        public string VuotDanLuu { get; set; }
        public bool ChamSocGiamDau { get; set; }
        public string ChamSocGiamDau_Text1 { get; set; }
        public string ChamSocGiamDau_Text2 { get; set; }
        public string ChamSocGiamDau_Text3 { get; set; }
        public string TheoDoiNuocTieu { get; set; }
        public string TheoDoiNuocTieu_Text { get; set; }
        public string TuVanGiaoDucSucKhoe_Text { get; set; }
        public string TuVanGiaoDucSucKhoe_Text1 { get; set; }
        public string TuVanGiaoDucSucKhoe_Text2 { get; set; }
        public string DienBienTiepTheo_ThoiGian { get; set; }
        public string DienBienTiepTheo_KeHoach { get; set; }
        public string DienBienTiepTheo_ThucHien { get; set; }
        public string  DienBienTiepTheo_DanhGia { get; set; }
        public string TVGDSK { get; set; }
        public bool[] HDGDSK_Array { get; } = new bool[] { false, false, false, false, false, false, false, false };
        public string HDGDSK
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < HDGDSK_Array.Length; i++)
                    temp += (HDGDSK_Array[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        HDGDSK_Array[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public string TuVanDinhDuong { get; set; }
        public string Thay_Khac { get; set; }
        public string KHCLS { get; set; } 
        public string THCLS { get; set; }
        public string KHKhac {get; set; }
        public string THKhac { get; set; }
        public string KHDienBienTiepTheo { get; set; }
        public string THDienBienTiepTheo { get; set; }
        public string DanhGia1 { get; set; }
        // thêm các mục đánh giá
        public string DanhGia_TheTrang { get; set; }
        public string DanhGia_TinhTrangThanKinh { get; set; }
        public string DanhGia_TuanHoan { get; set; }
        public string DanhGia_ThanNhiet { get; set; }
        public string DanhGia_HoHap { get; set; }
        public string DanhGia_Da { get; set; }
        public string DanhGia_Phu { get; set; }
        public string DanhGia_VetMo { get; set; }
        public string DanhGia_DanLuu { get; set; }
        public string DanhGia_Dau { get; set; }
        public string DanhGia_TieuHoa { get; set; }
        public string DanhGia_TietNieu { get; set; }
        public string DanhGia_DuongTruyen { get; set; }
        public string DanhGia_KhaNangNghe { get; set; }
        public string DanhGia_KhaNangNoi { get; set; }
        public string DanhGia_KhaNangNhin { get; set; }
        public string DanhGia_VanDong { get; set; }
        public string DanhGia_GiacNgu { get; set; }
        public string DanhGia_DinhDuong { get; set; }
        public string DanhGia_VSCN { get; set; }
        public string DanhGia_BatThuong { get; set; }
        public string DanhGia_Khac { get; set; }
        [MoTaDuLieu("Mã điều dưỡng")]
		public string MaDieuDuong1 { get; set; }
        [MoTaDuLieu("Họ tên điều dưỡng")]
		public string DieuDuong1 { get; set; }
        [MoTaDuLieu("Mã điều dưỡng")]
		public string MaDieuDuong2 { get; set; }
        [MoTaDuLieu("Họ tên điều dưỡng")]
		public string DieuDuong2 { get; set; }
        [MoTaDuLieu("Đã ký", null, 0, 0)]
		public bool DaKy { get; set; }
        [MoTaDuLieu("Ngày tạo", null, 0, 0)]
		public DateTime NgayTao { get; set; }
        [MoTaDuLieu("Người tạo", null, 0, 0)]
		public string NguoiTao { get; set; }
        [MoTaDuLieu("Ngày sửa", null, 0, 0)]
		public DateTime NgaySua { get; set; }
        [MoTaDuLieu("Người sửa", null, 0, 0)]
		public string NguoiSua { get; set; }
        [MoTaDuLieu("Chọn", null, 0, 0)]
		public bool Chon { get; set; }
    }
    public class DanhGiaNBVaKHCSFunc
    {
        public const string TableName = "DanhGiaNBVaKHCS";
        public const string TablePrimaryKeyName = "ID";
        public const string MaPhieu = "DGNBNVKHCS";
        public static List<DanhGiaNBVaKHCS> GetListData(MDB.MDBConnection _OracleConnection, decimal maquanly)
        {
            List<DanhGiaNBVaKHCS> list = new List<DanhGiaNBVaKHCS>();
            try
            {
                string sql = @"SELECT * FROM DanhGiaNBVaKHCS where MaQuanLy = :MaQuanLy";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, _OracleConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", maquanly));
                MDB.MDBDataReader DataReader = Command.ExecuteReader();
                while (DataReader.Read())
                {
                    DanhGiaNBVaKHCS data = new DanhGiaNBVaKHCS();
                    data.ID = Convert.ToInt64(DataReader.GetLong("ID").ToString());
                    data.MaQuanLy = maquanly;
                    data.MaBenhNhan = DataReader["MaBenhNhan"].ToString();
                    data.HoTenBenhNhan = XemBenhAn._HanhChinhBenhNhan.TenBenhNhan;
                    data.Tuoi = XemBenhAn._HanhChinhBenhNhan.Tuoi;
                    data.GioiTinh = XemBenhAn._HanhChinhBenhNhan.GioiTinh.Description();
                    data.ChanDoan = DataReader["ChanDoan"].ToString();
                    data.DiaChi = DataReader["DiaChi"].ToString();
                    data.NgheNghiep = DataReader["NgheNghiep"].ToString();
                    int tempInt = 0;
                    data.BHYT = int.TryParse(DataReader["BHYT"].ToString(), out tempInt) ? tempInt : 0;
                    data.NgheNghiep = DataReader["NgheNghiep"].ToString();
                    data.NgayVaoKhoa = Convert.ToDateTime(DataReader["NgayVaoKhoa"] == DBNull.Value ? DateTime.Now : DataReader["NgayVaoKhoa"]);
                    data.Giuong = DataReader["Giuong"].ToString();
                    data.Buong = DataReader["Buong"].ToString();
                    data.DiaChiLienHe = DataReader["DiaChiLienHe"].ToString();
                    data.SDT = DataReader["SDT"].ToString();
                    data.TienSuLyDoVaoVien = DataReader["TienSuLyDoVaoVien"].ToString();
                    data.TienSuBanThan = DataReader["TienSuBanThan"].ToString();
                    data.TienSuGiaDinh = DataReader["TienSuGiaDinh"].ToString();
                    data.TienSuDiUng = DataReader["TienSuDiUng"].ToString();
                    data.TenChatDiUng = DataReader["TenChatDiUng"].ToString();
                    data.PhanUngCoThe = DataReader["PhanUngCoThe"].ToString();
                    data.ThoiGianNhanDinh = Convert.ToDateTime(DataReader["ThoiGianNhanDinh"] == DBNull.Value ? DateTime.Now : DataReader["ThoiGianNhanDinh"]);
                    data.ThoiGianNhanDinh_Gio = data.ThoiGianNhanDinh;
                    data.TheTrang = DataReader["TheTrang"].ToString();
                    double tempDouble = 0;
                    data.CanNang = double.TryParse(DataReader["CanNang"].ToString(), out tempDouble) ? (double?)tempDouble : null;
                    tempDouble = 0;
                    data.ChieuCao = double.TryParse(DataReader["ChieuCao"].ToString(), out tempDouble) ? (double?)tempDouble : null;
                    tempDouble = 0;
                    data.BMI = double.TryParse(DataReader["BMI"].ToString(), out tempDouble) ? (double?)tempDouble : null;
                    data.TinhTrangThanKinh = DataReader["TinhTrangThanKinh"].ToString();
                    data.TinhTrangThanKinh_Khac = DataReader["TinhTrangThanKinh_Khac"].ToString();
                    data.DiemAPVU = DataReader["DiemAPVU"].ToString();
                    data.DiemGlasgow = DataReader["DiemGlasgow"].ToString();
                    data.NhipTim = DataReader["NhipTim"].ToString();
                    data.Mach = DataReader["Mach"].ToString();
                    data.HA = DataReader["HA"].ToString();
                    data.Chi = DataReader["Chi"].ToString();
                    data.TuanHoan_Khac = DataReader["TuanHoan_Khac"].ToString();
                    data.ThanNhiet = DataReader["ThanNhiet"].ToString();
                    tempInt = 0;
                    data.SotNgayThu = int.TryParse(DataReader["SotNgayThu"].ToString(), out tempInt) ? (int?)tempInt : null;
                    data.NhietDoMax = DataReader["NhietDoMax"].ToString();
                    data.TCSot = DataReader["TCSot"].ToString();
                    data.TuTho = DataReader["TuTho"].ToString();
                    data.Oxy = DataReader["Oxy"].ToString();
                    data.NhipTho = DataReader["NhipTho"].ToString();
                    data.Khi = DataReader["Khi"].ToString();
                    data.SuDungCoHH = DataReader["SuDungCoHH"].ToString();
                    data.SuDungCoMoTa = DataReader["SuDungCoMoTa"].ToString();
                    data.KhongHo = DataReader["KhongHo"].ToString();
                    data.KhongHo_Khac = DataReader["KhongHo_Khac"].ToString();
                    data.TinhChatDom = DataReader["TinhChatDom"].ToString();
                    data.Da = DataReader["Da"].ToString();
                    data.Da_Khac = DataReader["Da_Khac"].ToString();
                    data.VetBam = DataReader["VetBam"].ToString().Equals("1") ? true : false;
                    data.VetBam_Khac = DataReader["VetBam_Khac"].ToString();
                    data.Loet = DataReader["Loet"].ToString().Equals("1") ? true : false;
                    data.Loet_Do = DataReader["Loet_Do"].ToString();
                    data.Phu = DataReader["Phu"].ToString().Equals("1") ? true : false;
                    data.Phu_ViTri = DataReader["Phu_ViTri"].ToString();
                    data.Phu_TinhChat = DataReader["Phu_TinhChat"].ToString();
                    data.VetMo = DataReader["VetMo"].ToString();
                    data.VetMoVitri = DataReader["VetMoVitri"].ToString();
                    data.Kho = DataReader["Kho"].ToString();
                    data.VetMo_Khac = DataReader["VetMo_Khac"].ToString();
                    data.DanLuu = DataReader["DanLuu"].ToString().Equals("1") ? true : false;
                    data.MangTim = DataReader["MangTim"].ToString();
                    data.MangTim_Khac = DataReader["MangTim_Khac"].ToString();
                    data.OngDanLuu = DataReader["OngDanLuu"].ToString();
                    data.DichSL = DataReader["DichSL"].ToString();
                    data.DichTinhChat = DataReader["DichTinhChat"].ToString();
                    tempInt = 0;
                    data.MucDoDau = int.TryParse(DataReader["MucDoDau"].ToString(), out tempInt) ? (int?)tempInt : null;
                    data.KieuDau = DataReader["KieuDau"].ToString();
                    data.Bung = DataReader["Bung"].ToString();
                    data.TuAn = DataReader["TuAn"].ToString();
                    data.TuAn_SL = DataReader["TuAn_SL"].ToString();
                    data.DaiTien = int.TryParse(DataReader["DaiTien"].ToString(), out tempInt) ? (int?)tempInt : null;
                    data.TinhChatPhan = DataReader["TinhChatPhan"].ToString();
                    data.TuTieu = DataReader["TuTieu"].ToString();
                    data.TietNieuNgayDat = DataReader["TietNieuNgayDat"] != DBNull.Value ? (DateTime?)Convert.ToDateTime(DataReader["TietNieuNgayDat"]) : null;
                    data.CauBQ = DataReader["CauBQ"].ToString();
                    data.NuocTieuSL = DataReader["NuocTieuSL"].ToString();
                    data.NuocTieuMauSac = DataReader["NuocTieuMauSac"].ToString();
                    data.NuocTieu_Khac = DataReader["NuocTieu_Khac"].ToString();
                    data.DuongTruyen = DataReader["NuocTieu_Khac"].ToString().Equals("1") ? true : false;
                    data.DuongTruyen_ViTri = DataReader["DuongTruyen_ViTri"].ToString();
                    data.DuongTruyen_NgayDat = DataReader["DuongTruyen_NgayDat"] != DBNull.Value ? (DateTime?)Convert.ToDateTime(DataReader["DuongTruyen_NgayDat"]) : null;
                    data.DuongTruyen_DauHieu = DataReader["DuongTruyen_DauHieu"].ToString();
                    data.KhaNangNghe = DataReader["KhaNangNghe"].ToString();
                    data.KhaNangNghe_CuThe = DataReader["KhaNangNghe_CuThe"].ToString();
                    data.KhaNangNoi = DataReader["KhaNangNoi"].ToString();
                    data.KhaNangNoi_CuThe = DataReader["KhaNangNoi_CuThe"].ToString();
                    data.KhaNangNhin = DataReader["KhaNangNhin"].ToString();
                    data.KhaNangNhin_CuThe = DataReader["KhaNangNhin_CuThe"].ToString();
                    data.VanDong = DataReader["VanDong"].ToString();
                    data.VanDong_CuThe = DataReader["VanDong_CuThe"].ToString();
                    data.GiacNgu = DataReader["GiacNgu"].ToString();
                    data.GiacNgu_SuDungThuoc = DataReader["GiacNgu_SuDungThuoc"].ToString();

                    data.DinhDuong = DataReader["DinhDuong"].ToString();
                    data.DinhDuong_Khac = DataReader["DinhDuong_Khac"].ToString();
                    data.VSCN = DataReader["VSCN"].ToString();
                    data.KQCLS = DataReader["KQCLS"].ToString();
                    data.NhanDinh_Khac = DataReader["NhanDinh_Khac"].ToString();
                    data.ChamSocCap = DataReader["ChamSocCap"].ToString();
                    data.DienBienTiepTheo = DataReader["DienBienTiepTheo"].ToString();
                    data.TiepNhanBN = DataReader["TiepNhanBN"].ToString();
                    data.NhanBanGiaoTuKhoa = DataReader["NhanBanGiaoTuKhoa"].ToString();
                    data.SapXepGiuongBenh = DataReader["SapXepGiuongBenh"].ToString().Equals("1") ? true : false;
                    data.BaoBSKhamBN = DataReader["BaoBSKhamBN"].ToString().Equals("1") ? true : false;
                    data.TheoDoiDHST = DataReader["TheoDoiDHST"].ToString();
                    data.DoDHST = DataReader["DoDHST"].ToString().Equals("1") ? true : false;
                    data.DoDHST_Text = DataReader["DoDHST_Text"].ToString();
                    data.ThucHienYLenh = DataReader["ThucHienYLenh"].ToString();
                    data.THYL = DataReader["THYL"].ToString();
                    data.THYL_Khac = DataReader["THYL_Khac"].ToString();
                    data.ChamSocHoHap = DataReader["ChamSocHoHap"].ToString().Equals("1") ? true : false;
                    data.ChamSocHoHap_Text = DataReader["ChamSocHoHap_Text"].ToString();
                    data.TuTheNB = DataReader["TuTheNB"].ToString();
                    data.ThoOxyMui = DataReader["ThoOxyMui"].ToString();
                    data.ThoOxyMask = DataReader["ThoOxyMask"].ToString();
                    data.VoRung = DataReader["VoRung"].ToString().Equals("1") ? true : false;
                    data.VoRung_Text = DataReader["VoRung_Text"].ToString();
                    data.KhiRung = DataReader["KhiRung"].ToString().Equals("1") ? true : false;
                    data.KhiRung_Text = DataReader["KhiRung_Text"].ToString();
                    data.HDNBTapTho = DataReader["HDNBTapTho"].ToString().Equals("1") ? true : false;
                    data.HutDom = DataReader["HutDom"].ToString().Equals("1") ? true : false;
                    data.ChamSocVetMo = DataReader["ChamSocVetMo"].ToString();
                    data.ChamSocVetMo_Text = DataReader["ChamSocVetMo_Text"].ToString();
                    data.ThayBang = DataReader["ThayBang"].ToString().Equals("1") ? true : false;
                    data.ChamSocDanLuu = DataReader["ChamSocDanLuu"].ToString().Equals("1") ? true : false;
                    data.LapHeThongDanLuu = DataReader["LapHeThongDanLuu"].ToString().Equals("1") ? true : false;
                    data.VuotDanLuu = DataReader["VuotDanLuu"].ToString();
                    data.ChamSocGiamDau = DataReader["ChamSocGiamDau"].ToString().Equals("1") ? true : false;
                    data.ChamSocGiamDau_Text1 = DataReader["ChamSocGiamDau_Text1"].ToString();
                    data.ChamSocGiamDau_Text2 = DataReader["ChamSocGiamDau_Text2"].ToString();
                    data.TheoDoiNuocTieu = DataReader["TheoDoiNuocTieu"].ToString();
                    data.TVGDSK = DataReader["TVGDSK"].ToString();
                    data.HDGDSK = DataReader["HDGDSK"].ToString();
                    data.TuVanDinhDuong = DataReader["TuVanDinhDuong"].ToString();
                    data.Thay_Khac = DataReader["Thay_Khac"].ToString();
                    data.KHCLS = DataReader["KHCLS"].ToString();
                    data.THCLS = DataReader["THCLS"].ToString();
                    data.KHKhac = DataReader["KHKhac"].ToString();
                    data.THKhac = DataReader["THKhac"].ToString();
                    data.KHDienBienTiepTheo = DataReader["KHDienBienTiepTheo"].ToString();
                    data.THDienBienTiepTheo = DataReader["THDienBienTiepTheo"].ToString();
                    data.DanhGia1 = DataReader["DanhGia1"].ToString();
                    data.MaDieuDuong1 = DataReader["MaDieuDuong1"].ToString();
                    data.DieuDuong1 = DataReader["DieuDuong1"].ToString();
                    data.MaDieuDuong2 = DataReader["MaDieuDuong2"].ToString();
                    data.DieuDuong2 = DataReader["DieuDuong2"].ToString();
                    data.ThayBang_Text = DataReader["ThayBang_Text"].ToString();
                    data.ChamSocGiamDau_Text3 = DataReader["ChamSocGiamDau_Text3"].ToString();
                    data.TuVanGiaoDucSucKhoe_Text = DataReader["TuVanGiaoDucSucKhoe_Text"].ToString();
                    data.TuVanGiaoDucSucKhoe_Text1 = DataReader["TuVanGiaoDucSucKhoe_Text1"].ToString();
                    data.TuVanGiaoDucSucKhoe_Text2 = DataReader["TuVanGiaoDucSucKhoe_Text2"].ToString();
                    data.DienBienTiepTheo_ThoiGian = DataReader["DienBienTiepTheo_ThoiGian"].ToString();
                    data.DienBienTiepTheo_KeHoach = DataReader["DienBienTiepTheo_KeHoach"].ToString();
                    data.DienBienTiepTheo_ThucHien = DataReader["DienBienTiepTheo_ThucHien"].ToString();
                    data.DienBienTiepTheo_DanhGia = DataReader["DienBienTiepTheo_DanhGia"].ToString();


                    data.DanhGia_TheTrang = DataReader["DanhGia_TheTrang"].ToString();
                    data.DanhGia_TinhTrangThanKinh = DataReader["DanhGia_TinhTrangThanKinh"].ToString();
                    data.DanhGia_TuanHoan = DataReader["DanhGia_TuanHoan"].ToString();
                    data.DanhGia_ThanNhiet = DataReader["DanhGia_ThanNhiet"].ToString();
                    data.DanhGia_HoHap = DataReader["DanhGia_HoHap"].ToString();
                    data.DanhGia_Da = DataReader["DanhGia_Da"].ToString();
                    data.DanhGia_Phu = DataReader["DanhGia_Phu"].ToString();
                    data.DanhGia_VetMo = DataReader["DanhGia_VetMo"].ToString();
                    data.DanhGia_DanLuu = DataReader["DanhGia_DanLuu"].ToString();
                    data.DanhGia_Dau = DataReader["DanhGia_Dau"].ToString();
                    data.DanhGia_TieuHoa = DataReader["DanhGia_TieuHoa"].ToString();
                    data.DanhGia_TietNieu = DataReader["DanhGia_TietNieu"].ToString();
                    data.DanhGia_DuongTruyen = DataReader["DanhGia_DuongTruyen"].ToString();
                    data.DanhGia_KhaNangNghe = DataReader["DanhGia_KhaNangNghe"].ToString();
                    data.DanhGia_KhaNangNoi = DataReader["DanhGia_KhaNangNoi"].ToString();
                    data.DanhGia_KhaNangNhin = DataReader["DanhGia_KhaNangNhin"].ToString();
                    data.DanhGia_VanDong = DataReader["DanhGia_VanDong"].ToString();
                    data.DanhGia_GiacNgu = DataReader["DanhGia_GiacNgu"].ToString();
                    data.DanhGia_DinhDuong = DataReader["DanhGia_DinhDuong"].ToString();
                    data.DanhGia_VSCN = DataReader["DanhGia_VSCN"].ToString();
                    data.DanhGia_BatThuong = DataReader["DanhGia_BatThuong"].ToString();
                    data.DanhGia_Khac = DataReader["DanhGia_Khac"].ToString();


                    data.NgayTao = Convert.ToDateTime(DataReader["NgayTao"] == DBNull.Value ? DateTime.Now : DataReader["NgayTao"]);
                    data.NguoiTao = DataReader["NguoiTao"].ToString();
                    data.NgaySua = Convert.ToDateTime(DataReader["NgaySua"] == DBNull.Value ? DateTime.Now : DataReader["NgaySua"]);
                    data.NguoiSua = DataReader["NguoiSua"].ToString();

                    data.MaSoKy = DataReader["masokyten"].ToString();
                    data.DaKy = !string.IsNullOrEmpty(data.MaSoKy) ? true : false;
                    list.Add(data);
                }
            }
            catch (Exception ex) { XuLyLoi.Handle(ex); }
            return list;
        }
        public static bool InsertOrUpdate(MDB.MDBConnection MyConnection, ref DanhGiaNBVaKHCS ketQua)
        {
            try
            {
                string sql = @"INSERT INTO DanhGiaNBVaKHCS
                (
                    MAQUANLY,
                    MaBenhNhan,
                    BHYT,
                    NgheNghiep,
                    DiaChi,
                    NgayVaoKhoa,
                    ChanDoan,
                    Giuong,
                    Buong,
                    DiaChiLienHe,
                    SDT,
                    TienSuLyDoVaoVien,
                    TienSuBanThan,
                    TienSuGiaDinh,
                    TienSuDiUng,
                    TenChatDiUng,
                    PhanUngCoThe,
                    ThoiGianNhanDinh,
                    TheTrang,
                    CanNang,
                    ChieuCao,
                    BMI,
                    TinhTrangThanKinh,
                    TinhTrangThanKinh_Khac,
                    DiemAPVU,
                    DiemGlasgow,
                    NhipTim,
                    Mach,
                    HA,
                    Chi,
                    TuanHoan_Khac,
                    ThanNhiet,
                    SotNgayThu,
                    NhietDoMax,
                    TCSot,
                    TuTho,
                    Oxy,
                    NhipTho,
                    Khi,
                    SuDungCoHH,
                    SuDungCoMoTa,
                    KhongHo,
                    KhongHo_Khac,
                    TinhChatDom,
                    Da,
                    Da_Khac,
                    VetBam,
                    VetBam_Khac,
                    Loet,
                    Loet_Do,
                    Phu,
                    Phu_ViTri,
                    Phu_TinhChat,
                    VetMo,
                    VetMoVitri,
                    Kho,
                    VetMo_Khac,
                    DanLuu,
                    MangTim,
                    MangTim_Khac,
                    OngDanLuu,
                    DichSL,
                    DichTinhChat,
                    MucDoDau,
                    KieuDau,
                    Bung,
                    TuAn,
                    TuAn_SL,
                    DaiTien,
                    TinhChatPhan,
                    TuTieu,
                    TietNieuNgayDat,
                    CauBQ,
                    NuocTieuSL,
                    NuocTieuMauSac,
                    NuocTieu_Khac,
                    DuongTruyen,
                    DuongTruyen_ViTri,
                    DuongTruyen_NgayDat,
                    DuongTruyen_DauHieu,
                    KhaNangNghe,
                    KhaNangNghe_CuThe,
                    KhaNangNoi,
                    KhaNangNoi_CuThe,
                    KhaNangNhin,
                    KhaNangNhin_CuThe,
                    VanDong,
                    VanDong_CuThe,
                    GiacNgu,
                    GiacNgu_SuDungThuoc,
                    DinhDuong,
                    DinhDuong_Khac,
                    VSCN,
                    KQCLS,
                    NhanDinh_Khac,
                    ChamSocCap,
                    DienBienTiepTheo,
                    TiepNhanBN,
                    NhanBanGiaoTuKhoa,
                    SapXepGiuongBenh,
                    BaoBSKhamBN,
                    TheoDoiDHST,
                    DoDHST,
                    DoDHST_Text,
                    ThucHienYLenh,
                    THYL,
                    THYL_Khac,
                    ChamSocHoHap,
                    ChamSocHoHap_Text,
                    TuTheNB,
                    ThoOxyMui,
                    ThoOxyMask,
                    VoRung,
                    VoRung_Text,
                    KhiRung,
                    KhiRung_Text,
                    HDNBTapTho,
                    HutDom,
                    ChamSocVetMo,
                    ChamSocVetMo_Text,
                    ThayBang,
                    ChamSocDanLuu,
                    LapHeThongDanLuu,
                    VuotDanLuu,
                    ChamSocGiamDau,
                    ChamSocGiamDau_Text1,
                    ChamSocGiamDau_Text2,
                    TheoDoiNuocTieu,
                    TVGDSK,
                    HDGDSK,
                    TuVanDinhDuong,
                    Thay_Khac,
                    KHCLS,
                    THCLS,
                    KHKhac,
                    THKhac,
                    KHDienBienTiepTheo,
                    THDienBienTiepTheo,
                    DanhGia1,
                    MaDieuDuong1,
                    DieuDuong1,
                    MaDieuDuong2,
                    DieuDuong2,
                    ThayBang_Text,
                    ChamSocGiamDau_Text3,
                    TuVanGiaoDucSucKhoe_Text,
                    TuVanGiaoDucSucKhoe_Text1,
                    TuVanGiaoDucSucKhoe_Text2,
                    DienBienTiepTheo_ThoiGian,
                    DienBienTiepTheo_KeHoach,
                    DienBienTiepTheo_ThucHien,
                    DienBienTiepTheo_DanhGia,
                    DanhGia_TheTrang,
                    DanhGia_TinhTrangThanKinh,
                    DanhGia_TuanHoan,
                    DanhGia_ThanNhiet,
                    DanhGia_HoHap,
                    DanhGia_Da,
                    DanhGia_Phu,
                    DanhGia_VetMo,
                    DanhGia_DanLuu,
                    DanhGia_Dau,
                    DanhGia_TieuHoa,
                    DanhGia_TietNieu,
                    DanhGia_DuongTruyen,
                    DanhGia_KhaNangNghe,
                    DanhGia_KhaNangNoi,
                    DanhGia_KhaNangNhin,
                    DanhGia_VanDong,
                    DanhGia_GiacNgu,
                    DanhGia_DinhDuong,
                    DanhGia_VSCN,
                    DanhGia_BatThuong,
                    DanhGia_Khac,
                    NGUOITAO,
                    NGUOISUA,
                    NGAYTAO,
                    NGAYSUA)  VALUES
                 (
				    :MAQUANLY,
                    :MaBenhNhan,
                    :BHYT,
                    :NgheNghiep,
                    :DiaChi,
                    :NgayVaoKhoa,
                    :ChanDoan,
                    :Giuong,
                    :Buong,
                    :DiaChiLienHe,
                    :SDT,
                    :TienSuLyDoVaoVien,
                    :TienSuBanThan,
                    :TienSuGiaDinh,
                    :TienSuDiUng,
                    :TenChatDiUng,
                    :PhanUngCoThe,
                    :ThoiGianNhanDinh,
                    :TheTrang,
                    :CanNang,
                    :ChieuCao,
                    :BMI,
                    :TinhTrangThanKinh,
                    :TinhTrangThanKinh_Khac,
                    :DiemAPVU,
                    :DiemGlasgow,
                    :NhipTim,
                    :Mach,
                    :HA,
                    :Chi,
                    :TuanHoan_Khac,
                    :ThanNhiet,
                    :SotNgayThu,
                    :NhietDoMax,
                    :TCSot,
                    :TuTho,
                    :Oxy,
                    :NhipTho,
                    :Khi,
                    :SuDungCoHH,
                    :SuDungCoMoTa,
                    :KhongHo,
                    :KhongHo_Khac,
                    :TinhChatDom,
                    :Da,
                    :Da_Khac,
                    :VetBam,
                    :VetBam_Khac,
                    :Loet,
                    :Loet_Do,
                    :Phu,
                    :Phu_ViTri,
                    :Phu_TinhChat,
                    :VetMo,
                    :VetMoVitri,
                    :Kho,
                    :VetMo_Khac,
                    :DanLuu,
                    :MangTim,
                    :MangTim_Khac,
                    :OngDanLuu,
                    :DichSL,
                    :DichTinhChat,
                    :MucDoDau,
                    :KieuDau,
                    :Bung,
                    :TuAn,
                    :TuAn_SL,
                    :DaiTien,
                    :TinhChatPhan,
                    :TuTieu,
                    :TietNieuNgayDat,
                    :CauBQ,
                    :NuocTieuSL,
                    :NuocTieuMauSac,
                    :NuocTieu_Khac,
                    :DuongTruyen,
                    :DuongTruyen_ViTri,
                    :DuongTruyen_NgayDat,
                    :DuongTruyen_DauHieu,
                    :KhaNangNghe,
                    :KhaNangNghe_CuThe,
                    :KhaNangNoi,
                    :KhaNangNoi_CuThe,
                    :KhaNangNhin,
                    :KhaNangNhin_CuThe,
                    :VanDong,
                    :VanDong_CuThe,
                    :GiacNgu,
                    :GiacNgu_SuDungThuoc,
                    :DinhDuong,
                    :DinhDuong_Khac,
                    :VSCN,
                    :KQCLS,
                    :NhanDinh_Khac,
                    :ChamSocCap,
                    :DienBienTiepTheo,
                    :TiepNhanBN,
                    :NhanBanGiaoTuKhoa,
                    :SapXepGiuongBenh,
                    :BaoBSKhamBN,
                    :TheoDoiDHST,
                    :DoDHST,
                    :DoDHST_Text,
                    :ThucHienYLenh,
                    :THYL,
                    :THYL_Khac,
                    :ChamSocHoHap,
                    :ChamSocHoHap_Text,
                    :TuTheNB,
                    :ThoOxyMui,
                    :ThoOxyMask,
                    :VoRung,
                    :VoRung_Text,
                    :KhiRung,
                    :KhiRung_Text,
                    :HDNBTapTho,
                    :HutDom,
                    :ChamSocVetMo,
                    :ChamSocVetMo_Text,
                    :ThayBang,
                    :ChamSocDanLuu,
                    :LapHeThongDanLuu,
                    :VuotDanLuu,
                    :ChamSocGiamDau,
                    :ChamSocGiamDau_Text1,
                    :ChamSocGiamDau_Text2,
                    :TheoDoiNuocTieu,
                    :TVGDSK,
                    :HDGDSK,
                    :TuVanDinhDuong,
                    :Thay_Khac,
                    :KHCLS,
                    :THCLS,
                    :KHKhac,
                    :THKhac,
                    :KHDienBienTiepTheo,
                    :THDienBienTiepTheo,
                    :DanhGia1,
                    :MaDieuDuong1,
                    :DieuDuong1,
                    :MaDieuDuong2,
                    :DieuDuong2,
                    :ThayBang_Text,
                    :ChamSocGiamDau_Text3,
                    :TuVanGiaoDucSucKhoe_Text,
                    :TuVanGiaoDucSucKhoe_Text1,
                    :TuVanGiaoDucSucKhoe_Text2,
                    :DienBienTiepTheo_ThoiGian,
                    :DienBienTiepTheo_KeHoach,
                    :DienBienTiepTheo_ThucHien,
                    :DienBienTiepTheo_DanhGia,
                    :DanhGia_TheTrang,
                    :DanhGia_TinhTrangThanKinh,
                    :DanhGia_TuanHoan,
                    :DanhGia_ThanNhiet,
                    :DanhGia_HoHap,
                    :DanhGia_Da,
                    :DanhGia_Phu,
                    :DanhGia_VetMo,
                    :DanhGia_DanLuu,
                    :DanhGia_Dau,
                    :DanhGia_TieuHoa,
                    :DanhGia_TietNieu,
                    :DanhGia_DuongTruyen,
                    :DanhGia_KhaNangNghe,
                    :DanhGia_KhaNangNoi,
                    :DanhGia_KhaNangNhin,
                    :DanhGia_VanDong,
                    :DanhGia_GiacNgu,
                    :DanhGia_DinhDuong,
                    :DanhGia_VSCN,
                    :DanhGia_BatThuong,
                    :DanhGia_Khac,
                    :NGUOITAO,
                    :NGUOISUA,
                    :NGAYTAO,
                    :NGAYSUA
                 )  RETURNING ID INTO :ID";
                if (ketQua.ID != 0)
                {
                    sql = @"UPDATE DanhGiaNBVaKHCS SET 
                    MAQUANLY = :MAQUANLY,
                    MaBenhNhan = :MaBenhNhan,
                    BHYT = :BHYT,
                    NgheNghiep = :NgheNghiep,
                    DiaChi = :DiaChi,
                    NgayVaoKhoa = :NgayVaoKhoa,
                    ChanDoan = :ChanDoan,
                    Giuong = :Giuong,
                    Buong = :Buong,
                    DiaChiLienHe = :DiaChiLienHe,
                    SDT = :SDT,
                    TienSuLyDoVaoVien = :TienSuLyDoVaoVien,
                    TienSuBanThan = :TienSuBanThan,
                    TienSuGiaDinh = :TienSuGiaDinh,
                    TienSuDiUng = :TienSuDiUng,
                    TenChatDiUng = :TenChatDiUng,
                    PhanUngCoThe = :PhanUngCoThe,
                    ThoiGianNhanDinh = :ThoiGianNhanDinh,
                    TheTrang = :TheTrang,
                    CanNang = :CanNang,
                    ChieuCao = :ChieuCao,
                    BMI = :BMI,
                    TinhTrangThanKinh = :TinhTrangThanKinh,
                    TinhTrangThanKinh_Khac = :TinhTrangThanKinh_Khac,
                    DiemAPVU = :DiemAPVU,
                    DiemGlasgow = :DiemGlasgow,
                    NhipTim = :NhipTim,
                    Mach = :Mach,
                    HA = :HA,
                    Chi = :Chi,
                    TuanHoan_Khac = :TuanHoan_Khac,
                    ThanNhiet = :ThanNhiet,
                    SotNgayThu = :SotNgayThu,
                    NhietDoMax = :NhietDoMax,
                    TCSot = :TCSot,
                    TuTho = :TuTho,
                    Oxy = :Oxy,
                    NhipTho = :NhipTho,
                    Khi = :Khi,
                    SuDungCoHH = :SuDungCoHH,
                    SuDungCoMoTa = :SuDungCoMoTa,
                    KhongHo = :KhongHo,
                    KhongHo_Khac = :KhongHo_Khac,
                    TinhChatDom = :TinhChatDom,
                    Da = :Da,
                    Da_Khac = :Da_Khac,
                    VetBam = :VetBam,
                    VetBam_Khac = :VetBam_Khac,
                    Loet = :Loet,
                    Loet_Do = :Loet_Do,
                    Phu = :Phu,
                    Phu_ViTri = :Phu_ViTri,
                    Phu_TinhChat = :Phu_TinhChat,
                    VetMo = :VetMo,
                    VetMoVitri = :VetMoVitri,
                    Kho = :Kho,
                    VetMo_Khac = :VetMo_Khac,
                    DanLuu = :DanLuu,
                    MangTim = :MangTim,
                    MangTim_Khac = :MangTim_Khac,
                    OngDanLuu = :OngDanLuu,
                    DichSL = :DichSL,
                    DichTinhChat = :DichTinhChat,
                    MucDoDau = :MucDoDau,
                    KieuDau = :KieuDau,
                    Bung = :Bung,
                    TuAn = :TuAn,
                    TuAn_SL = :TuAn_SL,
                    DaiTien = :DaiTien,
                    TinhChatPhan = :TinhChatPhan,
                    TuTieu = :TuTieu,
                    TietNieuNgayDat = :TietNieuNgayDat,
                    CauBQ = :CauBQ,
                    NuocTieuSL = :NuocTieuSL,
                    NuocTieuMauSac = :NuocTieuMauSac,
                    NuocTieu_Khac = :NuocTieu_Khac,
                    DuongTruyen = :DuongTruyen,
                    DuongTruyen_ViTri = :DuongTruyen_ViTri,
                    DuongTruyen_NgayDat = :DuongTruyen_NgayDat,
                    DuongTruyen_DauHieu = :DuongTruyen_DauHieu,
                    KhaNangNghe = :KhaNangNghe,
                    KhaNangNghe_CuThe = :KhaNangNghe_CuThe,
                    KhaNangNoi = :KhaNangNoi,
                    KhaNangNoi_CuThe = :KhaNangNoi_CuThe,
                    KhaNangNhin = :KhaNangNhin,
                    KhaNangNhin_CuThe = :KhaNangNhin_CuThe,
                    VanDong = :VanDong,
                    VanDong_CuThe = :VanDong_CuThe,
                    GiacNgu = :GiacNgu,
                    GiacNgu_SuDungThuoc = :GiacNgu_SuDungThuoc,
                    DinhDuong = :DinhDuong,
                    DinhDuong_Khac = :DinhDuong_Khac,
                    VSCN = :VSCN,
                    KQCLS = :KQCLS,
                    NhanDinh_Khac = :NhanDinh_Khac,
                    ChamSocCap = :ChamSocCap,
                    DienBienTiepTheo = :DienBienTiepTheo,
                    TiepNhanBN = :TiepNhanBN,
                    NhanBanGiaoTuKhoa = :NhanBanGiaoTuKhoa,
                    SapXepGiuongBenh = :SapXepGiuongBenh,
                    BaoBSKhamBN = :BaoBSKhamBN,
                    TheoDoiDHST = :TheoDoiDHST,
                    DoDHST = :DoDHST,
                    DoDHST_Text = :DoDHST_Text,
                    ThucHienYLenh = :ThucHienYLenh,
                    THYL = :THYL,
                    THYL_Khac = :THYL_Khac,
                    ChamSocHoHap = :ChamSocHoHap,
                    ChamSocHoHap_Text = :ChamSocHoHap_Text,
                    TuTheNB = :TuTheNB,
                    ThoOxyMui = :ThoOxyMui,
                    ThoOxyMask = :ThoOxyMask,
                    VoRung = :VoRung,
                    VoRung_Text = :VoRung_Text,
                    KhiRung = :KhiRung,
                    KhiRung_Text = :KhiRung_Text,
                    HDNBTapTho = :HDNBTapTho,
                    HutDom = :HutDom,
                    ChamSocVetMo = :ChamSocVetMo,
                    ChamSocVetMo_Text = :ChamSocVetMo_Text,
                    ThayBang = :ThayBang,
                    ChamSocDanLuu = :ChamSocDanLuu,
                    LapHeThongDanLuu = :LapHeThongDanLuu,
                    VuotDanLuu = :VuotDanLuu,
                    ChamSocGiamDau = :ChamSocGiamDau,
                    ChamSocGiamDau_Text1 = :ChamSocGiamDau_Text1,
                    ChamSocGiamDau_Text2 = :ChamSocGiamDau_Text2,
                    TheoDoiNuocTieu = :TheoDoiNuocTieu,
                    TVGDSK = :TVGDSK,
                    HDGDSK = :HDGDSK,
                    TuVanDinhDuong = :TuVanDinhDuong,
                    Thay_Khac = :Thay_Khac,
                    KHCLS = :KHCLS,
                    THCLS = :THCLS,
                    KHKhac = :KHKhac,
                    THKhac = :THKhac,
                    KHDienBienTiepTheo = :KHDienBienTiepTheo,
                    THDienBienTiepTheo = :THDienBienTiepTheo,
                    DanhGia1 = :DanhGia1,
                    MaDieuDuong1 = :MaDieuDuong1,
                    DieuDuong1 = :DieuDuong1,
                    MaDieuDuong2 = :MaDieuDuong2,
                    DieuDuong2 = :DieuDuong2,
                    ThayBang_Text = :ThayBang_Text,
                    ChamSocGiamDau_Text3 = :ChamSocGiamDau_Text3,
                    TuVanGiaoDucSucKhoe_Text = :TuVanGiaoDucSucKhoe_Text,
                    TuVanGiaoDucSucKhoe_Text1 = :TuVanGiaoDucSucKhoe_Text1,
                    TuVanGiaoDucSucKhoe_Text2 = :TuVanGiaoDucSucKhoe_Text2,
                    DienBienTiepTheo_ThoiGian = :DienBienTiepTheo_ThoiGian,
                    DienBienTiepTheo_KeHoach = :DienBienTiepTheo_KeHoach,
                    DienBienTiepTheo_ThucHien = :DienBienTiepTheo_ThucHien,
                    DienBienTiepTheo_DanhGia = :DienBienTiepTheo_DanhGia,
                    DanhGia_TheTrang=:DanhGia_TheTrang,
                    DanhGia_TinhTrangThanKinh=:DanhGia_TinhTrangThanKinh,
                    DanhGia_TuanHoan=:DanhGia_TuanHoan,
                    DanhGia_ThanNhiet=:DanhGia_ThanNhiet,
                    DanhGia_HoHap=:DanhGia_HoHap,
                    DanhGia_Da=:DanhGia_Da,
                    DanhGia_Phu=:DanhGia_Phu,
                    DanhGia_VetMo=:DanhGia_VetMo,
                    DanhGia_DanLuu=:DanhGia_DanLuu,
                    DanhGia_Dau=:DanhGia_Dau,
                    DanhGia_TieuHoa=:DanhGia_TieuHoa,
                    DanhGia_TietNieu=:DanhGia_TietNieu,
                    DanhGia_DuongTruyen=:DanhGia_DuongTruyen,
                    DanhGia_KhaNangNghe=:DanhGia_KhaNangNghe,
                    DanhGia_KhaNangNoi=:DanhGia_KhaNangNoi,
                    DanhGia_KhaNangNhin=:DanhGia_KhaNangNhin,
                    DanhGia_VanDong=:DanhGia_VanDong,
                    DanhGia_GiacNgu=:DanhGia_GiacNgu,
                    DanhGia_DinhDuong=:DanhGia_DinhDuong,
                    DanhGia_VSCN=:DanhGia_VSCN,
                    DanhGia_BatThuong=:DanhGia_BatThuong,
                    DanhGia_Khac=:DanhGia_Khac,
                    NGUOISUA = :NGUOISUA,
                    NGAYSUA = :NGAYSUA
                    WHERE ID = " + ketQua.ID;
                }
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MAQUANLY", ketQua.MaQuanLy));
                Command.Parameters.Add(new MDB.MDBParameter("MaBenhNhan", ketQua.MaBenhNhan));
                Command.Parameters.Add(new MDB.MDBParameter("BHYT", ketQua.BHYT));
                Command.Parameters.Add(new MDB.MDBParameter("NgheNghiep", ketQua.NgheNghiep));
                Command.Parameters.Add(new MDB.MDBParameter("DiaChi", ketQua.DiaChi));
                Command.Parameters.Add(new MDB.MDBParameter("NgayVaoKhoa", ketQua.NgayVaoKhoa));
                Command.Parameters.Add(new MDB.MDBParameter("ChanDoan", ketQua.ChanDoan));
                Command.Parameters.Add(new MDB.MDBParameter("Giuong", ketQua.Giuong));
                Command.Parameters.Add(new MDB.MDBParameter("Buong", ketQua.Buong));
                Command.Parameters.Add(new MDB.MDBParameter("DiaChiLienHe", ketQua.DiaChiLienHe));
                Command.Parameters.Add(new MDB.MDBParameter("SDT", ketQua.SDT));
                Command.Parameters.Add(new MDB.MDBParameter("TienSuLyDoVaoVien", ketQua.TienSuLyDoVaoVien));
                Command.Parameters.Add(new MDB.MDBParameter("TienSuBanThan", ketQua.TienSuBanThan));
                Command.Parameters.Add(new MDB.MDBParameter("TienSuGiaDinh", ketQua.TienSuGiaDinh));
                Command.Parameters.Add(new MDB.MDBParameter("TienSuDiUng", ketQua.TienSuDiUng));
                Command.Parameters.Add(new MDB.MDBParameter("TenChatDiUng", ketQua.TenChatDiUng));
                Command.Parameters.Add(new MDB.MDBParameter("PhanUngCoThe", ketQua.PhanUngCoThe));
                Command.Parameters.Add(new MDB.MDBParameter("ThoiGianNhanDinh", ketQua.ThoiGianNhanDinh));
                Command.Parameters.Add(new MDB.MDBParameter("TheTrang", ketQua.TheTrang));
                Command.Parameters.Add(new MDB.MDBParameter("CanNang", ketQua.CanNang));
                Command.Parameters.Add(new MDB.MDBParameter("ChieuCao", ketQua.ChieuCao));
                Command.Parameters.Add(new MDB.MDBParameter("BMI", ketQua.BMI));
                Command.Parameters.Add(new MDB.MDBParameter("TinhTrangThanKinh", ketQua.TinhTrangThanKinh));
                Command.Parameters.Add(new MDB.MDBParameter("TinhTrangThanKinh_Khac", ketQua.TinhTrangThanKinh_Khac));
                Command.Parameters.Add(new MDB.MDBParameter("DiemAPVU", ketQua.DiemAPVU));
                Command.Parameters.Add(new MDB.MDBParameter("DiemGlasgow", ketQua.DiemGlasgow));
                Command.Parameters.Add(new MDB.MDBParameter("NhipTim", ketQua.NhipTim));
                Command.Parameters.Add(new MDB.MDBParameter("Mach", ketQua.Mach));
                Command.Parameters.Add(new MDB.MDBParameter("HA", ketQua.HA));
                Command.Parameters.Add(new MDB.MDBParameter("Chi", ketQua.Chi));
                Command.Parameters.Add(new MDB.MDBParameter("TuanHoan_Khac", ketQua.TuanHoan_Khac));
                Command.Parameters.Add(new MDB.MDBParameter("ThanNhiet", ketQua.ThanNhiet));
                Command.Parameters.Add(new MDB.MDBParameter("SotNgayThu", ketQua.SotNgayThu));
                Command.Parameters.Add(new MDB.MDBParameter("NhietDoMax", ketQua.NhietDoMax));
                Command.Parameters.Add(new MDB.MDBParameter("TCSot", ketQua.TCSot));
                Command.Parameters.Add(new MDB.MDBParameter("TuTho", ketQua.TuTho));
                Command.Parameters.Add(new MDB.MDBParameter("Oxy", ketQua.Oxy));
                Command.Parameters.Add(new MDB.MDBParameter("NhipTho", ketQua.NhipTho));
                Command.Parameters.Add(new MDB.MDBParameter("Khi", ketQua.Khi));
                Command.Parameters.Add(new MDB.MDBParameter("SuDungCoHH", ketQua.SuDungCoHH));
                Command.Parameters.Add(new MDB.MDBParameter("SuDungCoMoTa", ketQua.SuDungCoMoTa));
                Command.Parameters.Add(new MDB.MDBParameter("KhongHo", ketQua.KhongHo));
                Command.Parameters.Add(new MDB.MDBParameter("KhongHo_Khac", ketQua.KhongHo_Khac));
                Command.Parameters.Add(new MDB.MDBParameter("TinhChatDom", ketQua.TinhChatDom));
                Command.Parameters.Add(new MDB.MDBParameter("Da", ketQua.Da));
                Command.Parameters.Add(new MDB.MDBParameter("Da_Khac", ketQua.Da_Khac));
                Command.Parameters.Add(new MDB.MDBParameter("VetBam", ketQua.VetBam ? 1 : 0));
                Command.Parameters.Add(new MDB.MDBParameter("VetBam_Khac", ketQua.VetBam_Khac));
                Command.Parameters.Add(new MDB.MDBParameter("Loet", ketQua.Loet ? 1 : 0));
                Command.Parameters.Add(new MDB.MDBParameter("Loet_Do", ketQua.Loet_Do));
                Command.Parameters.Add(new MDB.MDBParameter("Phu", ketQua.Phu ? 1 : 0));
                Command.Parameters.Add(new MDB.MDBParameter("Phu_ViTri", ketQua.Phu_ViTri));
                Command.Parameters.Add(new MDB.MDBParameter("Phu_TinhChat", ketQua.Phu_TinhChat));
                Command.Parameters.Add(new MDB.MDBParameter("VetMo", ketQua.VetMo));
                Command.Parameters.Add(new MDB.MDBParameter("VetMoVitri", ketQua.VetMoVitri));
                Command.Parameters.Add(new MDB.MDBParameter("Kho", ketQua.Kho));
                Command.Parameters.Add(new MDB.MDBParameter("VetMo_Khac", ketQua.VetMo_Khac));
                Command.Parameters.Add(new MDB.MDBParameter("DanLuu", ketQua.DanLuu ? 1 : 0));
                Command.Parameters.Add(new MDB.MDBParameter("MangTim", ketQua.MangTim));
                Command.Parameters.Add(new MDB.MDBParameter("MangTim_Khac", ketQua.MangTim_Khac));
                Command.Parameters.Add(new MDB.MDBParameter("OngDanLuu", ketQua.OngDanLuu));
                Command.Parameters.Add(new MDB.MDBParameter("DichSL", ketQua.DichSL));
                Command.Parameters.Add(new MDB.MDBParameter("DichTinhChat", ketQua.DichTinhChat));
                Command.Parameters.Add(new MDB.MDBParameter("MucDoDau", ketQua.MucDoDau));
                Command.Parameters.Add(new MDB.MDBParameter("KieuDau", ketQua.KieuDau));
                Command.Parameters.Add(new MDB.MDBParameter("Bung", ketQua.Bung));
                Command.Parameters.Add(new MDB.MDBParameter("TuAn", ketQua.TuAn));
                Command.Parameters.Add(new MDB.MDBParameter("TuAn_SL", ketQua.TuAn_SL));
                Command.Parameters.Add(new MDB.MDBParameter("DaiTien", ketQua.DaiTien));
                Command.Parameters.Add(new MDB.MDBParameter("TinhChatPhan", ketQua.TinhChatPhan));
                Command.Parameters.Add(new MDB.MDBParameter("TuTieu", ketQua.TuTieu));
                Command.Parameters.Add(new MDB.MDBParameter("TietNieuNgayDat", ketQua.TietNieuNgayDat));
                Command.Parameters.Add(new MDB.MDBParameter("CauBQ", ketQua.CauBQ));
                Command.Parameters.Add(new MDB.MDBParameter("NuocTieuSL", ketQua.NuocTieuSL));
                Command.Parameters.Add(new MDB.MDBParameter("NuocTieuMauSac", ketQua.NuocTieuMauSac));
                Command.Parameters.Add(new MDB.MDBParameter("NuocTieu_Khac", ketQua.NuocTieu_Khac));
                Command.Parameters.Add(new MDB.MDBParameter("DuongTruyen", ketQua.DuongTruyen ? 1 : 0));
                Command.Parameters.Add(new MDB.MDBParameter("DuongTruyen_ViTri", ketQua.DuongTruyen_ViTri));
                Command.Parameters.Add(new MDB.MDBParameter("DuongTruyen_NgayDat", ketQua.DuongTruyen_NgayDat));
                Command.Parameters.Add(new MDB.MDBParameter("DuongTruyen_DauHieu", ketQua.DuongTruyen_DauHieu));
                Command.Parameters.Add(new MDB.MDBParameter("KhaNangNghe", ketQua.KhaNangNghe));
                Command.Parameters.Add(new MDB.MDBParameter("KhaNangNghe_CuThe", ketQua.KhaNangNghe_CuThe));
                Command.Parameters.Add(new MDB.MDBParameter("KhaNangNoi", ketQua.KhaNangNoi));
                Command.Parameters.Add(new MDB.MDBParameter("KhaNangNoi_CuThe", ketQua.KhaNangNoi_CuThe));
                Command.Parameters.Add(new MDB.MDBParameter("KhaNangNhin", ketQua.KhaNangNhin));
                Command.Parameters.Add(new MDB.MDBParameter("KhaNangNhin_CuThe", ketQua.KhaNangNhin_CuThe));
                Command.Parameters.Add(new MDB.MDBParameter("VanDong", ketQua.VanDong));
                Command.Parameters.Add(new MDB.MDBParameter("VanDong_CuThe", ketQua.VanDong_CuThe));
                Command.Parameters.Add(new MDB.MDBParameter("GiacNgu", ketQua.GiacNgu));
                Command.Parameters.Add(new MDB.MDBParameter("GiacNgu_SuDungThuoc", ketQua.GiacNgu_SuDungThuoc));
                Command.Parameters.Add(new MDB.MDBParameter("DinhDuong", ketQua.DinhDuong));
                Command.Parameters.Add(new MDB.MDBParameter("DinhDuong_Khac", ketQua.DinhDuong_Khac));
                Command.Parameters.Add(new MDB.MDBParameter("VSCN", ketQua.VSCN));
                Command.Parameters.Add(new MDB.MDBParameter("KQCLS", ketQua.KQCLS));
                Command.Parameters.Add(new MDB.MDBParameter("NhanDinh_Khac", ketQua.NhanDinh_Khac));
                Command.Parameters.Add(new MDB.MDBParameter("ChamSocCap", ketQua.ChamSocCap));
                Command.Parameters.Add(new MDB.MDBParameter("DienBienTiepTheo", ketQua.DienBienTiepTheo));
                Command.Parameters.Add(new MDB.MDBParameter("TiepNhanBN", ketQua.TiepNhanBN));
                Command.Parameters.Add(new MDB.MDBParameter("NhanBanGiaoTuKhoa", ketQua.NhanBanGiaoTuKhoa));
                Command.Parameters.Add(new MDB.MDBParameter("SapXepGiuongBenh", ketQua.SapXepGiuongBenh ? 1 : 0));
                Command.Parameters.Add(new MDB.MDBParameter("BaoBSKhamBN", ketQua.BaoBSKhamBN ? 1 : 0));
                Command.Parameters.Add(new MDB.MDBParameter("TheoDoiDHST", ketQua.TheoDoiDHST));
                Command.Parameters.Add(new MDB.MDBParameter("DoDHST", ketQua.DoDHST ? 1 : 0));
                Command.Parameters.Add(new MDB.MDBParameter("DoDHST_Text", ketQua.DoDHST_Text));
                Command.Parameters.Add(new MDB.MDBParameter("ThucHienYLenh", ketQua.ThucHienYLenh));
                Command.Parameters.Add(new MDB.MDBParameter("THYL", ketQua.THYL));
                Command.Parameters.Add(new MDB.MDBParameter("THYL_Khac", ketQua.THYL_Khac));
                Command.Parameters.Add(new MDB.MDBParameter("ChamSocHoHap", ketQua.ChamSocHoHap ? 1 : 0));
                Command.Parameters.Add(new MDB.MDBParameter("ChamSocHoHap_Text", ketQua.ChamSocHoHap_Text));
                Command.Parameters.Add(new MDB.MDBParameter("TuTheNB", ketQua.TuTheNB));
                Command.Parameters.Add(new MDB.MDBParameter("ThoOxyMui", ketQua.ThoOxyMui));
                Command.Parameters.Add(new MDB.MDBParameter("ThoOxyMask", ketQua.ThoOxyMask));
                Command.Parameters.Add(new MDB.MDBParameter("VoRung", ketQua.VoRung ? 1 : 0));
                Command.Parameters.Add(new MDB.MDBParameter("VoRung_Text", ketQua.VoRung_Text));
                Command.Parameters.Add(new MDB.MDBParameter("KhiRung", ketQua.KhiRung ? 1 : 0));
                Command.Parameters.Add(new MDB.MDBParameter("KhiRung_Text", ketQua.KhiRung_Text));
                Command.Parameters.Add(new MDB.MDBParameter("HDNBTapTho", ketQua.HDNBTapTho ? 1 : 0));
                Command.Parameters.Add(new MDB.MDBParameter("HutDom", ketQua.HutDom ? 1 : 0));
                Command.Parameters.Add(new MDB.MDBParameter("ChamSocVetMo", ketQua.ChamSocVetMo));
                Command.Parameters.Add(new MDB.MDBParameter("ChamSocVetMo_Text", ketQua.ChamSocVetMo_Text));
                Command.Parameters.Add(new MDB.MDBParameter("ThayBang", ketQua.ThayBang ? 1 : 0));
                Command.Parameters.Add(new MDB.MDBParameter("ChamSocDanLuu", ketQua.ChamSocDanLuu ? 1 : 0));
                Command.Parameters.Add(new MDB.MDBParameter("LapHeThongDanLuu", ketQua.LapHeThongDanLuu ? 1 : 0));
                Command.Parameters.Add(new MDB.MDBParameter("VuotDanLuu", ketQua.VuotDanLuu));
                Command.Parameters.Add(new MDB.MDBParameter("ChamSocGiamDau", ketQua.ChamSocGiamDau ? 1 : 0));
                Command.Parameters.Add(new MDB.MDBParameter("ChamSocGiamDau_Text1", ketQua.ChamSocGiamDau_Text1));
                Command.Parameters.Add(new MDB.MDBParameter("ChamSocGiamDau_Text2", ketQua.ChamSocGiamDau_Text2));
                Command.Parameters.Add(new MDB.MDBParameter("TheoDoiNuocTieu", ketQua.TheoDoiNuocTieu));
                Command.Parameters.Add(new MDB.MDBParameter("TVGDSK", ketQua.TVGDSK));
                Command.Parameters.Add(new MDB.MDBParameter("HDGDSK", ketQua.HDGDSK));
                Command.Parameters.Add(new MDB.MDBParameter("TuVanDinhDuong", ketQua.TuVanDinhDuong));
                Command.Parameters.Add(new MDB.MDBParameter("Thay_Khac", ketQua.Thay_Khac));
                Command.Parameters.Add(new MDB.MDBParameter("KHCLS", ketQua.KHCLS));
                Command.Parameters.Add(new MDB.MDBParameter("THCLS", ketQua.THCLS));
                Command.Parameters.Add(new MDB.MDBParameter("KHKhac", ketQua.KHKhac));
                Command.Parameters.Add(new MDB.MDBParameter("THKhac", ketQua.THKhac));
                Command.Parameters.Add(new MDB.MDBParameter("KHDienBienTiepTheo", ketQua.KHDienBienTiepTheo));
                Command.Parameters.Add(new MDB.MDBParameter("THDienBienTiepTheo", ketQua.THDienBienTiepTheo));
                Command.Parameters.Add(new MDB.MDBParameter("DanhGia1", ketQua.DanhGia1));
                Command.Parameters.Add(new MDB.MDBParameter("MaDieuDuong1", ketQua.MaDieuDuong1));
                Command.Parameters.Add(new MDB.MDBParameter("DieuDuong1", ketQua.DieuDuong1));
                Command.Parameters.Add(new MDB.MDBParameter("MaDieuDuong2", ketQua.MaDieuDuong2));
                Command.Parameters.Add(new MDB.MDBParameter("DieuDuong2", ketQua.DieuDuong2));
                Command.Parameters.Add(new MDB.MDBParameter("ThayBang_Text", ketQua.ThayBang_Text));
                Command.Parameters.Add(new MDB.MDBParameter("ChamSocGiamDau_Text3", ketQua.ChamSocGiamDau_Text3));
                Command.Parameters.Add(new MDB.MDBParameter("TuVanGiaoDucSucKhoe_Text", ketQua.TuVanGiaoDucSucKhoe_Text));
                Command.Parameters.Add(new MDB.MDBParameter("TuVanGiaoDucSucKhoe_Text1", ketQua.TuVanGiaoDucSucKhoe_Text1));
                Command.Parameters.Add(new MDB.MDBParameter("TuVanGiaoDucSucKhoe_Text2", ketQua.TuVanGiaoDucSucKhoe_Text2));
                Command.Parameters.Add(new MDB.MDBParameter("DienBienTiepTheo_ThoiGian", ketQua.DienBienTiepTheo_ThoiGian));
                Command.Parameters.Add(new MDB.MDBParameter("DienBienTiepTheo_KeHoach", ketQua.DienBienTiepTheo_KeHoach));
                Command.Parameters.Add(new MDB.MDBParameter("DienBienTiepTheo_ThucHien", ketQua.DienBienTiepTheo_ThucHien));
                Command.Parameters.Add(new MDB.MDBParameter("DienBienTiepTheo_DanhGia", ketQua.DienBienTiepTheo_DanhGia));
                Command.Parameters.Add(new MDB.MDBParameter("DanhGia_TheTrang", ketQua.DanhGia_TheTrang));
                Command.Parameters.Add(new MDB.MDBParameter("DanhGia_TinhTrangThanKinh", ketQua.DanhGia_TinhTrangThanKinh));
                Command.Parameters.Add(new MDB.MDBParameter("DanhGia_TuanHoan", ketQua.DanhGia_TuanHoan));
                Command.Parameters.Add(new MDB.MDBParameter("DanhGia_ThanNhiet", ketQua.DanhGia_ThanNhiet));
                Command.Parameters.Add(new MDB.MDBParameter("DanhGia_HoHap", ketQua.DanhGia_HoHap));
                Command.Parameters.Add(new MDB.MDBParameter("DanhGia_Da", ketQua.DanhGia_Da));
                Command.Parameters.Add(new MDB.MDBParameter("DanhGia_Phu", ketQua.DanhGia_Phu));
                Command.Parameters.Add(new MDB.MDBParameter("DanhGia_VetMo", ketQua.DanhGia_VetMo));
                Command.Parameters.Add(new MDB.MDBParameter("DanhGia_DanLuu", ketQua.DanhGia_DanLuu));
                Command.Parameters.Add(new MDB.MDBParameter("DanhGia_Dau", ketQua.DanhGia_Dau));
                Command.Parameters.Add(new MDB.MDBParameter("DanhGia_TieuHoa", ketQua.DanhGia_TieuHoa));
                Command.Parameters.Add(new MDB.MDBParameter("DanhGia_TietNieu", ketQua.DanhGia_TietNieu));
                Command.Parameters.Add(new MDB.MDBParameter("DanhGia_DuongTruyen", ketQua.DanhGia_DuongTruyen));
                Command.Parameters.Add(new MDB.MDBParameter("DanhGia_KhaNangNghe", ketQua.DanhGia_KhaNangNghe));
                Command.Parameters.Add(new MDB.MDBParameter("DanhGia_KhaNangNoi", ketQua.DanhGia_KhaNangNoi));
                Command.Parameters.Add(new MDB.MDBParameter("DanhGia_KhaNangNhin", ketQua.DanhGia_KhaNangNhin));
                Command.Parameters.Add(new MDB.MDBParameter("DanhGia_VanDong", ketQua.DanhGia_VanDong));
                Command.Parameters.Add(new MDB.MDBParameter("DanhGia_GiacNgu", ketQua.DanhGia_GiacNgu));
                Command.Parameters.Add(new MDB.MDBParameter("DanhGia_DinhDuong", ketQua.DanhGia_DinhDuong));
                Command.Parameters.Add(new MDB.MDBParameter("DanhGia_VSCN", ketQua.DanhGia_VSCN));
                Command.Parameters.Add(new MDB.MDBParameter("DanhGia_BatThuong", ketQua.DanhGia_BatThuong));
                Command.Parameters.Add(new MDB.MDBParameter("DanhGia_Khac", ketQua.DanhGia_Khac));

                Command.Parameters.Add(new MDB.MDBParameter("NGUOISUA", ketQua.NguoiSua));
                Command.Parameters.Add(new MDB.MDBParameter("NGAYSUA", ketQua.NgaySua));
                if (ketQua.ID == 0)
                {
                    Command.Parameters.Add(new MDB.MDBParameter("ID", ketQua.ID));
                    Command.Parameters.Add(new MDB.MDBParameter("NGUOITAO", ketQua.NguoiTao));
                    Command.Parameters.Add(new MDB.MDBParameter("NGAYTAO", ketQua.NgayTao));
                }
                Command.BindByName = true;
                int n = Command.ExecuteNonQuery();
                if (ketQua.ID == 0)
                {
                    long nextval = Convert.ToInt64((Command.Parameters["ID"] as MDB.MDBParameter).Value);
                    ketQua.ID = nextval;
                }
                return n > 0 ? true : false;
            }
            catch (Exception ex)
            {
                XuLyLoi.Handle(ex);
            }
            return false;
        }
        public static bool delete(MDB.MDBConnection MyConnection, long id)
        {
            try
            {
                string sql = "DELETE FROM DanhGiaNBVaKHCS WHERE ID = :ID";
                MDB.MDBCommand command = new MDB.MDBCommand(sql, MyConnection);
                command.Parameters.Add(new MDB.MDBParameter("ID", id));
                command.BindByName = true;
                int n = command.ExecuteNonQuery();
                return n > 0 ? true : false;
            }
            catch (Exception ex)
            {
                XuLyLoi.Handle(ex);
            }
            return false;
        }
        public static DataSet getDataSet(MDB.MDBConnection MyConnection, long id)
        {
            string sql = @"SELECT
                P.* 
            FROM
                DanhGiaNBVaKHCS P
            WHERE
                ID = " + id;

            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
            MDB.MDBDataAdapter adt = new MDB.MDBDataAdapter(Command);
            var ds = new DataSet();

            adt.Fill(ds, "KQ");

            ds.Tables[0].AddColumn("TenBenhNhan", typeof(string));
            ds.Tables[0].AddColumn("Tuoi", typeof(string));
            ds.Tables[0].AddColumn("NamSinh", typeof(string));
            ds.Tables[0].AddColumn("GioiTinh", typeof(int));
            ds.Tables[0].AddColumn("SOYTE", typeof(string));
            ds.Tables[0].AddColumn("BENHVIEN", typeof(string));
            ds.Tables[0].AddColumn("KHOA", typeof(string));
            ds.Tables[0].AddColumn("MaBenhAn", typeof(string));

            ds.Tables[0].Rows[0]["TenBenhNhan"] = XemBenhAn._HanhChinhBenhNhan.TenBenhNhan;
            ds.Tables[0].Rows[0]["Tuoi"] = XemBenhAn._HanhChinhBenhNhan.Tuoi;
            ds.Tables[0].Rows[0]["NamSinh"] = XemBenhAn._HanhChinhBenhNhan.NgaySinh.HasValue ? XemBenhAn._HanhChinhBenhNhan.NgaySinh.Value.Year + "" : "";
            ds.Tables[0].Rows[0]["GioiTinh"] = (int)XemBenhAn._HanhChinhBenhNhan.GioiTinh;
            ds.Tables[0].Rows[0]["SOYTE"] = XemBenhAn._HanhChinhBenhNhan.SoYTe;
            ds.Tables[0].Rows[0]["BENHVIEN"] = XemBenhAn._HanhChinhBenhNhan.BenhVien;
            ds.Tables[0].Rows[0]["KHOA"] = XemBenhAn._ThongTinDieuTri.Khoa;
            ds.Tables[0].Rows[0]["MaBenhAn"] = XemBenhAn._ThongTinDieuTri.MaBenhAn;

            return ds;
        }
        public static string DownloadAnhMoTa(long Id, decimal maQuanLy)
        {
            string fullPath = "";
            try
            {
                string FileHinhAnh = @"\DGNBKHCS\" + maQuanLy;
                if (Id != 0M)
                {
                    using (var client = new HttpClient())
                    {
                        try
                        {
                            string URL = ERMDatabase.WebServiceEMR;
                            client.BaseAddress = new Uri(URL);
                            client.DefaultRequestHeaders.Accept.Clear();
                            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                            client.Timeout = new TimeSpan(0, 0, 1000);
                            string fileName = FileHinhAnh.Trim('\\') + "\\" + Id + ".png";
                            var url = "api/KetXuat/Get1File?PathFile=" + fileName;
                            HttpResponseMessage response = client.GetAsync(url).Result;
                            response.EnsureSuccessStatusCode();
                            if (response.IsSuccessStatusCode)
                            {
                                string result = response.Content.ReadAsStringAsync().Result;
                                if (result != "null" && result != "[]")
                                {
                                    FileCopy lstFile = JsonConvert.DeserializeObject<FileCopy>(result);
                                    if (lstFile != null)
                                    {
                                        string tempPath = System.IO.Path.GetTempPath().Trim('\\');
                                        fullPath = tempPath.Trim('\\') + "\\" + FileHinhAnh.Trim('\\');
                                        if (!System.IO.Directory.Exists(fullPath)) { System.IO.Directory.CreateDirectory(fullPath); }
                                        string fileHinhAnh = fullPath.Trim('\\') + "\\" + lstFile.FileName;
                                        try
                                        {
                                            File.WriteAllBytes(fileHinhAnh, lstFile.ArrayBytes);
                                        }
                                        catch
                                        {
                                            fileHinhAnh = fullPath.Trim('\\') + "\\COPY_" + lstFile.FileName;
                                            File.WriteAllBytes(fileHinhAnh, lstFile.ArrayBytes);
                                        }
                                    }
                                }
                            }
                        }
                        catch (Exception ex)
                        {
                            XuLyLoi.LogError(ex);
                        }
                    }
                }

                
            }
            catch (Exception ex)
            {
                XuLyLoi.Handle(ex);
            }
            return fullPath;
        }
    }
}
