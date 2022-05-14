using EMR.KyDienTu;
using NLog;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Text;
using PMS.Access; 

namespace EMR_MAIN.DATABASE.Other
{

    public class PTDVCSNBC23_2 : ThongTinKy
    {
        public PTDVCSNBC23_2()
        {
            TableName = "PTDVCSNBC23_2";
            TablePrimaryKeyName = "ID";
            IDMauPhieu = (int)DanhMucPhieu.PTDVCSNBC23_2;
            TenMauPhieu = DanhMucPhieu.PTDVCSNBC23_2.Description();
        }
        [MoTaDuLieu("Mã định danh")]
		public decimal IDPhieu { set; get; }
		[MoTaDuLieu("Sở Y Tế")]
		public string SoYTe { set; get; }
        public string MaYTe { set; get; }
        [MoTaDuLieu("Bệnh viện")]
		public string BenhVien { set; get; }
        [MoTaDuLieu("Tên khoa")]
		public string TenKhoa { set; get; }
        [MoTaDuLieu("Mã bệnh án")]
		public string MaBenhAn { set; get; }
        [MoTaDuLieu("Mã bệnh nhân")]
		public string MaBenhNhan { set; get; }
        [MoTaDuLieu("Họ và tên bệnh nhân")]
		public string TenBenhNhan { set; get; }
        [MoTaDuLieu("Tuổi bệnh nhân")]
		public string Tuoi { set; get; }
        [MoTaDuLieu("Địa chỉ nhà bệnh nhân")]
		public string DiaChi { set; get; }
        public string SoPhieu { set; get; }
        [MoTaDuLieu("Mã quản lý: mã duy nhất trong 1 đợt khám chữa bệnh (kcb), không trùng giữa các đợt kcb khác nhau","",1)]
		public decimal MaQuanLy { set; get; }
        [MoTaDuLieu("Chẩn đoán bệnh")]
		public string ChanDoan { set; get; }
        [MoTaDuLieu("Mã khoa")]
		public string MaKhoa { set; get; }
        [MoTaDuLieu("Buồng")]
		public string Buong { set; get; }
        [MoTaDuLieu("Giường")]
		public string Giuong { set; get; }
        [MoTaDuLieu("Mã giường")]
		public string MaGiuong { set; get; }
        public string SoVaoVien { set; get; }
        [MoTaDuLieu("Giới tính bệnh nhân")]
		public string GioiTinh { set; get; }
        [MoTaDuLieu("Ngày vào bệnh viện")]
		public DateTime NgayVaoVien { set; get; }
        [MoTaDuLieu("Người tạo", null, 0, 0)]
		public string NguoiTao { set; get; }
        [MoTaDuLieu("Ngày tạo", null, 0, 0)]
		public DateTime NgayTao { set; get; }
        [MoTaDuLieu("Người sửa", null, 0, 0)]
		public string NguoiSua { set; get; }
        [MoTaDuLieu("Ngày sửa", null, 0, 0)]
		public DateTime NgaySua { set; get; }
        public List<PTDVCSNBC23_2_ChiTiet> TTCSChiTiet { get; set; }
        [MoTaDuLieu("Chọn", null, 0, 0)]
		public bool Chon { get; set; }
        public PTDVCSNBC23_2 Clone()
        {
            PTDVCSNBC23_2 other = (PTDVCSNBC23_2)this.MemberwiseClone();
            other.TTCSChiTiet = new List<PTDVCSNBC23_2_ChiTiet>();
            if (this.TTCSChiTiet != null)
            foreach (PTDVCSNBC23_2_ChiTiet item in this.TTCSChiTiet)
            {
                other.TTCSChiTiet.Add(item.Clone());
            }
            return other;
        }
    }
    public class PTDVCSNBC23_2_ChiTiet: ThongTinKy
    {
        [MoTaDuLieu("Mã định danh")]
		public decimal IDPhieuCT { set; get; }
        [MoTaDuLieu("Mã định danh")]
		public decimal IDPhieu { set; get; }
        public DateTime ThoiGian { set; get; }
        [MoTaDuLieu("Người thực hiện")]
		public string NguoiThucHien { set; get; }
        public string YThuc { set; get; }
        public string YThucKHCS { set; get; }
        public bool[] DaNM_Array { get; } = new bool[] { false, false };
        public string DaNM {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < DaNM_Array.Length; i++)
                    temp += (DaNM_Array[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        DaNM_Array[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public string DaKhac { set; get; }
        public string DaKHCS { set; get; }
        public bool[] NT_Array { get; } = new bool[] { false, false };
        public string NT
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < NT_Array.Length; i++)
                    temp += (NT_Array[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        NT_Array[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public string NTKhac { set; get; }
        public string NTKHCS { set; get; }
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
        public string HAKhac { set; get; }
        public string HAKHCS { set; get; }
        public bool[] ND_Array { get; } = new bool[] { false, false, false };
        public string ND
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < ND_Array.Length; i++)
                    temp += (ND_Array[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        ND_Array[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public string NDKhac { set; get; }
        public string NDKHCS { set; get; }
        public bool[] HH_Array { get; } = new bool[] { false, false };
        public string HH
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < HH_Array.Length; i++)
                    temp += (HH_Array[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        HH_Array[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public string HHKhac { set; get; }
        public string HHKHCS { set; get; }
        public bool[] Ho_Array { get; } = new bool[] { false, false , false };
        public string Ho
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < Ho_Array.Length; i++)
                    temp += (Ho_Array[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        Ho_Array[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public string HoKhac { set; get; }
        public string HoKHCS { set; get; }
        public bool[] Phu_Array { get; } = new bool[] { false, false };
        public string Phu
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < Phu_Array.Length; i++)
                    temp += (Phu_Array[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        Phu_Array[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public string PhuKhac { set; get; }
        public string PhuKHCS { set; get; }
        public bool[] VM_Array { get; } = new bool[] { false, false, false, false };
        public string VM
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < VM_Array.Length; i++)
                    temp += (VM_Array[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        VM_Array[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public string VMKhac { set; get; }
        public string VMKHCS { set; get; }
        public string Dau { set; get; }
        public string DauKhac { set; get; }
        public string DauKHCS { set; get; }
        public string TenDT { set; get; }
        public bool[] DT_Array { get; } = new bool[] { false, false };
        public string DT
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < DT_Array.Length; i++)
                    temp += (DT_Array[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        DT_Array[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public string DTKhac { set; get; }
        public string DTKHCS { set; get; }
        public bool[] DD_Array { get; } = new bool[] { false, false };
        public string DD
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < DD_Array.Length; i++)
                    temp += (DD_Array[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        DD_Array[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public string DDKhac { set; get; }
        public string DDKHCS { set; get; }
        public bool[] Bung_Array { get; } = new bool[] { false, false, false };
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
        public string BungKHCS { set; get; }
        public string DaiTien { set; get; }
        public string DaiTienKhac { set; get; }
        public string DaiTienKHCS { set; get; }
        public bool[] Tieu_Array { get; } = new bool[] { false, false };
        public string Tieu
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < Tieu_Array.Length; i++)
                    temp += (Tieu_Array[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        Tieu_Array[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public string TieuKhac { set; get; }
        public string TieuKHCS { set; get; }
        public bool[] VSCN_Array { get; } = new bool[] { false, false };
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
        public string VSCNKHCS { set; get; }
        public bool[] RML_Array { get; } = new bool[] { false, false };
        public string RML
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < RML_Array.Length; i++)
                    temp += (RML_Array[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        RML_Array[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public string RMLKhac { set; get; }
        public string RMLKHCS { set; get; }
        public string VanDong { set; get; }
        public string VanDongKHCS { set; get; }
        public string BThuong { set; get; }
        public string BThuongKHCS { set; get; }
        public string DHK { set; get; }
        public string DHKKHCS { set; get; }
        public string YThuc2 { set; get; }
        public string YThuc2KHCS { set; get; }
        public string TuanHoan { set; get; }
        public string TuanHoanKHCS { set; get; }
        public string Hohap { set; get; }
        public string HohapKHCS { set; get; }
        public string Khac { set; get; }
        public string KhacKHCS { set; get; }
        public DateTime? TGDHST { set; get; }
        public string KHCS1Khac { set; get; }
        public string KHCS1DanhGia { set; get; }
        public string MaDD1 { set; get; }
        public string TenDD1 { set; get; }
        public bool[] KHCS2_1_Array { get; } = new bool[] { false, false };
        public string KHCS2_1
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < KHCS2_1_Array.Length; i++)
                    temp += (KHCS2_1_Array[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        KHCS2_1_Array[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public bool[] KHCS2_2_Array { get; } = new bool[] { false, false };
        public string KHCS2_2
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < KHCS2_2_Array.Length; i++)
                    temp += (KHCS2_2_Array[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        KHCS2_2_Array[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public bool[] KHCS2_3_Array { get; } = new bool[] { false, false, false };
        public string KHCS2_3
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < KHCS2_3_Array.Length; i++)
                    temp += (KHCS2_3_Array[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        KHCS2_3_Array[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public string KHCS2Khac_Tho { set; get; }
        public string KHCS2Khac { set; get; }
        public string KHCS2DanhGia { set; get; }
        public string MaDD2 { set; get; }
        public string TenDD2 { set; get; }
        public bool[] KHCS3_1_Array { get; } = new bool[] { false, false, false, false };
        public string KHCS3_1
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < KHCS3_1_Array.Length; i++)
                    temp += (KHCS3_1_Array[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        KHCS3_1_Array[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public bool[] KHCS3_2_Array { get; } = new bool[] { false, false, false, false };
        public string KHCS3_2
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < KHCS3_2_Array.Length; i++)
                    temp += (KHCS3_2_Array[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        KHCS3_2_Array[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public bool[] KHCS3_3_Array { get; } = new bool[] { false , false};
        public string KHCS3_3
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < KHCS3_3_Array.Length; i++)
                    temp += (KHCS3_3_Array[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        KHCS3_3_Array[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public bool[] KHCS3_4_Array { get; } = new bool[] { false , false};
        public string KHCS3_4
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < KHCS3_4_Array.Length; i++)
                    temp += (KHCS3_4_Array[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        KHCS3_4_Array[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public string KHCS3_2Khac { set; get; }
        public string KHCS3_3Khac { set; get; }
        public string KHCS3_4Khac { set; get; }
        public bool[] KHCS3_5_1_Array { get; } = new bool[] { false, false, false };
        public string KHCS3_5_1
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < KHCS3_5_1_Array.Length; i++)
                    temp += (KHCS3_5_1_Array[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        KHCS3_5_1_Array[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public string KHCS3_5_2 { set; get; }
        public string KHCS3_5_3 { set; get; }
        public string KHCS3_5Khac1 { set; get; }
        public string KHCS3_5Khac2 { set; get; }
        public string KHCS3_5Khac3 { set; get; }
        public string KHCS3DanhGia { set; get; }
        public string MaDD3 { set; get; }
        public string TenDD3 { set; get; }
        public bool[] KHCS4_1_Array { get; } = new bool[] { false , false };
        public string KHCS4_1
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < KHCS4_1_Array.Length; i++)
                    temp += (KHCS4_1_Array[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        KHCS4_1_Array[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public bool[] KHCS4_3_Array { get; } = new bool[] { false , false , false  };
        public string KHCS4_3
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < KHCS4_3_Array.Length; i++)
                    temp += (KHCS4_3_Array[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        KHCS4_3_Array[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public bool[] KHCS4_4_Array { get; } = new bool[] { false, false, false, false };
        public string KHCS4_4
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < KHCS4_4_Array.Length; i++)
                    temp += (KHCS4_4_Array[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        KHCS4_4_Array[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public bool[] KHCS4_5_Array { get; } = new bool[] { false, false };
        public string KHCS4_5
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < KHCS4_5_Array.Length; i++)
                    temp += (KHCS4_5_Array[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        KHCS4_5_Array[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public string KHCS4_1Khac { set; get; }
        public string KHCS4_2Khac { set; get; }
        public string KHCS4_3Khac { set; get; }
        public string KHCS4DanhGia { set; get; }
        public string MaDD4 { set; get; }
        public string TenDD4 { set; get; }
        public string TVGDSK { set; get; }
        public string TVGDSKDanhGia { set; get; }
        public string MaDD5 { set; get; }
        public string TenDD5 { set; get; }
        public string CSC { set; get; }
        public string KHCS4_5Khac { set; get; }
        public string KHCS3_5Khac4 { set; get; }
        public string NGAYKY { set; get; }
        public string COMPUTERKYTEN { set; get; }
        //public string MASOKYTEN { set; get; }
        public string TENFILEKY { set; get; }
        public string USERNAMEKY { set; get; }
        public bool Daky { set; get; }
        [MoTaDuLieu("Chọn", null, 0, 0)]
		public bool Chon { get; set; }
        public PTDVCSNBC23_2_ChiTiet Clone()
        {
            PTDVCSNBC23_2_ChiTiet other = (PTDVCSNBC23_2_ChiTiet)this.MemberwiseClone(); 
            return other;
        }
    }
    public class PTDVCSNBC23_2Func
    {
        static Logger log = LogManager.GetLogger("Log");
        public const string TableName = "PTDVCSNBC23_2";
        public const string TablePrimaryKeyName = "IDPhieu";

        public static List<ThuocPha> DanhSachThuocPha = new List<ThuocPha>();


        public static List<PTDVCSNBC23_2> Select(MDB.MDBConnection MyConnection, decimal MaQuanLy)
        {
            try
            { 
                { 
                    List<PTDVCSNBC23_2> listResult = new List<PTDVCSNBC23_2>();
                    string sql = @"SELECT t.*
                    FROM PTDVCSNBC23_2 t
                    WHERE t.MaQuanLy = :MaQuanLy";
                    sql = sql + " ORDER BY t.NgayTao DESC";
                    MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
                    Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", MaQuanLy));
                    MDB.MDBDataReader DataReader = Command.ExecuteReader();
                    while (DataReader.Read())
                    {
                        var obj = new PTDVCSNBC23_2();
                        obj.IDPhieu = Common.ConDB_Decimal(DataReader["IDPhieu"]);
                        obj.SoYTe = Common.ConDBNull(DataReader["SoYTe"]);
                        obj.MaYTe = Common.ConDBNull(DataReader["MaYTe"]);
                        obj.BenhVien = Common.ConDBNull(DataReader["BenhVien"]);
                        obj.TenKhoa = Common.ConDBNull(DataReader["TenKhoa"]);
                        obj.MaBenhAn = Common.ConDBNull(DataReader["MaBenhAn"]);
                        obj.MaBenhNhan = Common.ConDBNull(DataReader["MaBenhNhan"]);
                        obj.TenBenhNhan = Common.ConDBNull(DataReader["TenBenhNhan"]);
                        obj.Tuoi = Common.ConDBNull(DataReader["Tuoi"]);
                        obj.DiaChi = Common.ConDBNull(DataReader["DiaChi"]);
                        obj.SoPhieu = Common.ConDBNull(DataReader["SoPhieu"]);
                        obj.MaQuanLy = Common.ConDB_Decimal(DataReader["MaQuanLy"]);
                        obj.ChanDoan = Common.ConDBNull(DataReader["ChanDoan"]);
                        obj.MaKhoa = Common.ConDBNull(DataReader["MaKhoa"]);
                        obj.Buong = Common.ConDBNull(DataReader["Buong"]);
                        obj.Giuong = Common.ConDBNull(DataReader["Giuong"]);
                        obj.MaGiuong = Common.ConDBNull(DataReader["MaGiuong"]);
                        obj.SoVaoVien = Common.ConDBNull(DataReader["SoVaoVien"]);
                        obj.GioiTinh = Common.ConDBNull(DataReader["GioiTinh"]);
                        obj.NgayVaoVien = Common.ConDB_DateTime(DataReader["NgayVaoVien"]);
                        obj.NguoiTao = Common.ConDBNull(DataReader["NguoiTao"]);
                        obj.NgayTao = Common.ConDB_DateTime(DataReader["NgayTao"]);
                        obj.NguoiSua = Common.ConDBNull(DataReader["NguoiSua"]);
                        obj.NgaySua = Common.ConDB_DateTime(DataReader["NgaySua"]);
                        obj.TTCSChiTiet = new List<PTDVCSNBC23_2_ChiTiet>();
                        obj.TTCSChiTiet = Select_PhieuCHiTiet(MyConnection, obj.IDPhieu.ToString());
                        listResult.Add(obj);
                    }
                    return listResult;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static bool Insert(MDB.MDBConnection MyConnection, PTDVCSNBC23_2 obj)
        {
            try
            { 
                { 
                    string sql = @"INSERT INTO PTDVCSNBC23_2 (
                    SoYTe,
                    MaYTe,
                    BenhVien,
                    TenKhoa,
                    MaBenhAn,
                    MaBenhNhan,
                    TenBenhNhan,
                    Tuoi,
                    DiaChi,
                    SoPhieu,
                    MaQuanLy,
                    ChanDoan,
                    MaKhoa,
                    Buong,
                    Giuong,
                    MaGiuong,
                    SoVaoVien,
                    GioiTinh,NgayVaoVien,
                    NguoiTao,
                    NgayTao,
                    NguoiSua,
                    NgaySua
                    ) 
                    VALUES (
                    :SoYTe,
                    :MaYTe,
                    :BenhVien,
                    :TenKhoa,
                    :MaBenhAn,
                    :MaBenhNhan,
                    :TenBenhNhan,
                    :Tuoi,
                    :DiaChi,
                    :SoPhieu,
                    :MaQuanLy,
                    :ChanDoan,
                    :MaKhoa,
                    :Buong,
                    :Giuong,
                    :MaGiuong,
                    :SoVaoVien,
                    :GioiTinh,:NgayVaoVien,
                    :NguoiTao,
                    :NgayTao,
                    :NguoiSua,
                    :NgaySua
                    ) RETURNING IDPhieu INTO :IDPhieu ";
                    MDB.MDBCommand oracleCommand = new MDB.MDBCommand(sql, MyConnection);
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("SoYTe", obj.SoYTe));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("MaYTe", obj.MaYTe));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("BenhVien", obj.BenhVien));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("TenKhoa", obj.TenKhoa));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("MaBenhAn", obj.MaBenhAn));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("MaBenhNhan", obj.MaBenhNhan));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("TenBenhNhan", obj.TenBenhNhan));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("Tuoi", obj.Tuoi));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("DiaChi", obj.DiaChi));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("SoPhieu", obj.SoPhieu));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("MaQuanLy", obj.MaQuanLy));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("ChanDoan", obj.ChanDoan));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("MaKhoa", obj.MaKhoa));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("Buong", obj.Buong));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("Giuong", obj.Giuong));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("MaGiuong", obj.MaGiuong));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("SoVaoVien", obj.SoVaoVien));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("GioiTinh", obj.GioiTinh));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("NgayVaoVien", obj.NgayVaoVien));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("NguoiTao", obj.NguoiTao));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("NgayTao", DateTime.Now));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("NguoiSua", obj.NguoiSua));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("NgaySua", DateTime.Now));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("IDPhieu", obj.IDPhieu));
                    int n = oracleCommand.ExecuteNonQuery();
                    if (n > 0)
                    {
                        decimal IDPhieu = Common.ConDB_Decimal((oracleCommand.Parameters["IDPhieu"] as MDB.MDBParameter).Value);
                        obj.IDPhieu = IDPhieu;
                    }

                    return n > 0 ? true : false;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static bool Update(MDB.MDBConnection MyConnection, PTDVCSNBC23_2 obj)
        {
            try
            {
                {

                    string sql = @"UPDATE PTDVCSNBC23_2 SET 
                        SoYTe=:SoYTe,
                        MaYTe=:MaYTe,
                        BenhVien=:BenhVien,
                        TenKhoa=:TenKhoa,
                        MaBenhAn=:MaBenhAn,
                        MaBenhNhan=:MaBenhNhan,
                        TenBenhNhan=:TenBenhNhan,
                        Tuoi=:Tuoi,
                        DiaChi=:DiaChi,
                        SoPhieu=:SoPhieu,
                        MaQuanLy=:MaQuanLy,
                        ChanDoan=:ChanDoan,
                        MaKhoa=:MaKhoa,
                        Buong=:Buong,
                        Giuong=:Giuong,
                        MaGiuong=:MaGiuong,
                        SoVaoVien=:SoVaoVien,
                        GioiTinh=:GioiTinh,
                        NgayVaoVien=:NgayVaoVien,
                        NguoiSua=:NguoiSua,
                        NgaySua=:NgaySua
                        WHERE IDPhieu = " + obj.IDPhieu;
                    MDB.MDBCommand oracleCommand = new MDB.MDBCommand(sql, MyConnection);
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("SoYTe", obj.SoYTe));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("MaYTe", obj.MaYTe));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("BenhVien", obj.BenhVien));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("TenKhoa", obj.TenKhoa));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("MaBenhAn", obj.MaBenhAn));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("MaBenhNhan", obj.MaBenhNhan));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("TenBenhNhan", obj.TenBenhNhan));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("Tuoi", obj.Tuoi));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("DiaChi", obj.DiaChi));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("SoPhieu", obj.SoPhieu));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("MaQuanLy", obj.MaQuanLy));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("ChanDoan", obj.ChanDoan));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("MaKhoa", obj.MaKhoa));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("Buong", obj.Buong));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("Giuong", obj.Giuong));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("MaGiuong", obj.MaGiuong));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("SoVaoVien", obj.SoVaoVien));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("GioiTinh", obj.GioiTinh));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("NgayVaoVien", obj.NgayVaoVien));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("NguoiSua", obj.NguoiSua));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("NgaySua", DateTime.Now));
                    int n = oracleCommand.ExecuteNonQuery();

                    return n > 0 ? true : false;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static bool Delete(MDB.MDBConnection MyConnection, decimal IDPhieu)
        {
            try
            {
                if (IDPhieu != 0)
                {
                    string sql = @"Delete PTDVCSNBC23_2 
                                WHERE 
                                (IDPhieu = :IDPhieu) ";
                    MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
                    Command.Parameters.Add(new MDB.MDBParameter(":IDPhieu", IDPhieu));
                    int n = Command.ExecuteNonQuery();
                    Command.Dispose();
                    sql = @"Delete PTDVCSNBC23_2_ChiTiet 
                                WHERE 
                                (IDPhieu = :IDPhieu) ";
                    Command = new MDB.MDBCommand(sql, MyConnection);
                    Command.Parameters.Add(new MDB.MDBParameter(":IDPhieu", IDPhieu));
                    n = Command.ExecuteNonQuery();

                    return true;
                }

            }
            catch (Exception ex)
            {
                XuLyLoi.Handle(ex);
            }
            return false;
        }
        public static bool Delete_ChiTiet(MDB.MDBConnection MyConnection, decimal IDPhieuCT)
        {
            try
            {
                if (IDPhieuCT != 0)
                {
                    string sql = @"Delete PTDVCSNBC23_2_ChiTiet 
                                WHERE 
                                (IDPhieuCT = :IDPhieuCT) ";
                    MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
                    Command.Parameters.Add(new MDB.MDBParameter(":IDPhieuCT", IDPhieuCT));
                    int n = Command.ExecuteNonQuery();

                    return true;
                }

            }
            catch (Exception ex)
            {
                XuLyLoi.Handle(ex);
            }
            return false;
        }
        public static List<PTDVCSNBC23_2_ChiTiet> Select_PhieuCHiTiet(MDB.MDBConnection MyConnection, string IDPhieu, int ModOrder = 0)
        {
            try
            {  
                {
                    List<PTDVCSNBC23_2_ChiTiet> listResult = new List<PTDVCSNBC23_2_ChiTiet>();
                    string sql = @"SELECT t.*
                    FROM PTDVCSNBC23_2_ChiTiet t
                    WHERE t.IDPhieu = :IDPhieu ";

                    if(ModOrder == 1)
                    {
                        sql = sql + " ORDER BY t.ThoiGian ASC";
                    }
                    else
                    {
                        sql = sql + " ORDER BY t.ThoiGian DESC";
                    }
                    MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
                    Command.Parameters.Add(new MDB.MDBParameter("IDPhieu", IDPhieu));
                    MDB.MDBDataReader DataReader = Command.ExecuteReader();
                    while (DataReader.Read())
                    {
                        var obj = new PTDVCSNBC23_2_ChiTiet();
                        obj.IDPhieuCT = Common.ConDB_Decimal(DataReader["IDPhieuCT"]);
                        obj.IDPhieu = Common.ConDB_Decimal(DataReader["IDPhieu"]);
                        obj.ThoiGian = Common.ConDB_DateTime(DataReader["ThoiGian"]);
                        obj.YThuc = Common.ConDBNull(DataReader["YThuc"]);
                        obj.YThucKHCS = Common.ConDBNull(DataReader["YThucKHCS"]);
                        obj.HH = Common.ConDBNull(DataReader["HH"]);
                        obj.DaNM = Common.ConDBNull(DataReader["DaNM"]);
                        obj.DaKhac = Common.ConDBNull(DataReader["DaKhac"]);
                        obj.DaKHCS = Common.ConDBNull(DataReader["DaKHCS"]);
                        obj.NT = Common.ConDBNull(DataReader["NT"]);
                        obj.NTKhac = Common.ConDBNull(DataReader["NTKhac"]);
                        obj.NTKHCS = Common.ConDBNull(DataReader["NTKHCS"]);
                        obj.HA = Common.ConDBNull(DataReader["HA"]);
                        obj.HAKhac = Common.ConDBNull(DataReader["HAKhac"]);
                        obj.HAKHCS = Common.ConDBNull(DataReader["HAKHCS"]);
                        obj.ND = Common.ConDBNull(DataReader["ND"]);
                        obj.NDKhac = Common.ConDBNull(DataReader["NDKhac"]);
                        obj.NDKHCS = Common.ConDBNull(DataReader["NDKHCS"]);
                        obj.HHKhac = Common.ConDBNull(DataReader["HHKhac"]);
                        obj.HHKHCS = Common.ConDBNull(DataReader["HHKHCS"]);
                        obj.Ho = Common.ConDBNull(DataReader["Ho"]);
                        obj.HoKhac = Common.ConDBNull(DataReader["HoKhac"]);
                        obj.HoKHCS = Common.ConDBNull(DataReader["HoKHCS"]);
                        obj.Phu = Common.ConDBNull(DataReader["Phu"]);
                        obj.PhuKhac = Common.ConDBNull(DataReader["PhuKhac"]);
                        obj.PhuKHCS = Common.ConDBNull(DataReader["PhuKHCS"]);
                        obj.VM = Common.ConDBNull(DataReader["VM"]);
                        obj.VMKhac = Common.ConDBNull(DataReader["VMKhac"]);
                        obj.VMKHCS = Common.ConDBNull(DataReader["VMKHCS"]);
                        obj.Dau = Common.ConDBNull(DataReader["Dau"]);
                        obj.DauKhac = Common.ConDBNull(DataReader["DauKhac"]);
                        obj.DauKHCS = Common.ConDBNull(DataReader["DauKHCS"]);
                        obj.TenDT = Common.ConDBNull(DataReader["TenDT"]);
                        obj.DT = Common.ConDBNull(DataReader["DT"]);
                        obj.DTKhac = Common.ConDBNull(DataReader["DTKhac"]);
                        obj.DTKHCS = Common.ConDBNull(DataReader["DTKHCS"]);
                        obj.DD = Common.ConDBNull(DataReader["DD"]);
                        obj.DDKhac = Common.ConDBNull(DataReader["DDKhac"]);
                        obj.DDKHCS = Common.ConDBNull(DataReader["DDKHCS"]);
                        obj.Bung = Common.ConDBNull(DataReader["Bung"]);
                        obj.BungKHCS = Common.ConDBNull(DataReader["BungKHCS"]);
                        obj.DaiTien = Common.ConDBNull(DataReader["DaiTien"]);
                        obj.DaiTienKhac = Common.ConDBNull(DataReader["DaiTienKhac"]);
                        obj.DaiTienKHCS = Common.ConDBNull(DataReader["DaiTienKHCS"]);
                        obj.Tieu = Common.ConDBNull(DataReader["Tieu"]);
                        obj.TieuKhac = Common.ConDBNull(DataReader["TieuKhac"]);
                        obj.TieuKHCS = Common.ConDBNull(DataReader["TieuKHCS"]);
                        obj.VSCN = Common.ConDBNull(DataReader["VSCN"]);
                        obj.VSCNKHCS = Common.ConDBNull(DataReader["VSCNKHCS"]);
                        obj.RML = Common.ConDBNull(DataReader["RML"]);
                        obj.RMLKhac = Common.ConDBNull(DataReader["RMLKhac"]);
                        obj.RMLKHCS = Common.ConDBNull(DataReader["RMLKHCS"]);
                        obj.VanDong = Common.ConDBNull(DataReader["VanDong"]);
                        obj.VanDongKHCS = Common.ConDBNull(DataReader["VanDongKHCS"]);
                        obj.BThuong = Common.ConDBNull(DataReader["BThuong"]);
                        obj.BThuongKHCS = Common.ConDBNull(DataReader["BThuongKHCS"]);
                        obj.DHK = Common.ConDBNull(DataReader["DHK"]);
                        obj.DHKKHCS = Common.ConDBNull(DataReader["DHKKHCS"]);
                        obj.YThuc2 = Common.ConDBNull(DataReader["YThuc2"]);
                        obj.YThuc2KHCS = Common.ConDBNull(DataReader["YThuc2KHCS"]);
                        obj.TuanHoan = Common.ConDBNull(DataReader["TuanHoan"]);
                        obj.TuanHoanKHCS = Common.ConDBNull(DataReader["TuanHoanKHCS"]);
                        obj.Hohap = Common.ConDBNull(DataReader["Hohap"]);
                        obj.HohapKHCS = Common.ConDBNull(DataReader["HohapKHCS"]);
                        obj.Khac = Common.ConDBNull(DataReader["Khac"]);
                        obj.KhacKHCS = Common.ConDBNull(DataReader["KhacKHCS"]);
                        obj.TGDHST = Common.ConDB_DateTime(DataReader["TGDHST"]);
                        obj.KHCS1Khac = Common.ConDBNull(DataReader["KHCS1Khac"]);
                        obj.KHCS1DanhGia = Common.ConDBNull(DataReader["KHCS1DanhGia"]);
                        obj.MaDD1 = Common.ConDBNull(DataReader["MaDD1"]);
                        obj.TenDD1 = Common.ConDBNull(DataReader["TenDD1"]);
                        obj.KHCS2_1 = Common.ConDBNull(DataReader["KHCS2_1"]);
                        obj.KHCS2_2 = Common.ConDBNull(DataReader["KHCS2_2"]);
                        obj.KHCS2_3 = Common.ConDBNull(DataReader["KHCS2_3"]);
                        obj.KHCS2Khac_Tho = Common.ConDBNull(DataReader["KHCS2Khac_Tho"]);
                        obj.KHCS2Khac = Common.ConDBNull(DataReader["KHCS2Khac"]);
                        obj.KHCS2DanhGia = Common.ConDBNull(DataReader["KHCS2DanhGia"]);
                        obj.MaDD2 = Common.ConDBNull(DataReader["MaDD2"]);
                        obj.TenDD2 = Common.ConDBNull(DataReader["TenDD2"]);
                        obj.KHCS3_1 = Common.ConDBNull(DataReader["KHCS3_1"]);
                        obj.KHCS3_2 = Common.ConDBNull(DataReader["KHCS3_2"]);
                        obj.KHCS3_3 = Common.ConDBNull(DataReader["KHCS3_3"]);
                        obj.KHCS3_4 = Common.ConDBNull(DataReader["KHCS3_4"]);
                        obj.KHCS3_2Khac = Common.ConDBNull(DataReader["KHCS3_2Khac"]);
                        obj.KHCS3_3Khac = Common.ConDBNull(DataReader["KHCS3_3Khac"]);
                        obj.KHCS3_4Khac = Common.ConDBNull(DataReader["KHCS3_4Khac"]);
                        obj.KHCS3_5_1 = Common.ConDBNull(DataReader["KHCS3_5_1"]);
                        obj.KHCS3_5_2 = Common.ConDBNull(DataReader["KHCS3_5_2"]);
                        obj.KHCS3_5_3 = Common.ConDBNull(DataReader["KHCS3_5_3"]);
                        obj.KHCS3_5Khac1 = Common.ConDBNull(DataReader["KHCS3_5Khac1"]);
                        obj.KHCS3_5Khac2 = Common.ConDBNull(DataReader["KHCS3_5Khac2"]);
                        obj.KHCS3_5Khac3 = Common.ConDBNull(DataReader["KHCS3_5Khac3"]);
                        obj.KHCS3DanhGia = Common.ConDBNull(DataReader["KHCS3DanhGia"]);
                        obj.MaDD3 = Common.ConDBNull(DataReader["MaDD3"]);
                        obj.TenDD3 = Common.ConDBNull(DataReader["TenDD3"]);
                        obj.KHCS4_1 = Common.ConDBNull(DataReader["KHCS4_1"]);
                        obj.KHCS4_3 = Common.ConDBNull(DataReader["KHCS4_3"]);
                        obj.KHCS4_4 = Common.ConDBNull(DataReader["KHCS4_4"]);
                        obj.KHCS4_5 = Common.ConDBNull(DataReader["KHCS4_5"]);
                        obj.KHCS4_1Khac = Common.ConDBNull(DataReader["KHCS4_1Khac"]);
                        obj.KHCS4_2Khac = Common.ConDBNull(DataReader["KHCS4_2Khac"]);
                        obj.KHCS4_3Khac = Common.ConDBNull(DataReader["KHCS4_3Khac"]);
                        obj.KHCS4DanhGia = Common.ConDBNull(DataReader["KHCS4DanhGia"]);
                        obj.MaDD4 = Common.ConDBNull(DataReader["MaDD4"]);
                        obj.TenDD4 = Common.ConDBNull(DataReader["TenDD4"]);
                        obj.TVGDSK = Common.ConDBNull(DataReader["TVGDSK"]);
                        obj.TVGDSKDanhGia = Common.ConDBNull(DataReader["TVGDSKDanhGia"]);
                        obj.MaDD5 = Common.ConDBNull(DataReader["MaDD5"]);
                        obj.TenDD5 = Common.ConDBNull(DataReader["TenDD5"]);
                        obj.KHCS4_5Khac = Common.ConDBNull(DataReader["KHCS4_5Khac"]);
                        obj.KHCS3_5Khac4 = Common.ConDBNull(DataReader["KHCS3_5Khac4"]);
                        obj.CSC = Common.ConDBNull(DataReader["CSC"]);
                        obj.NGAYKY = Common.ConDBNull(DataReader["NGAYKY"]);
                        obj.COMPUTERKYTEN = Common.ConDBNull(DataReader["COMPUTERKYTEN"]);
                        obj.MaSoKy = Common.ConDBNull(DataReader["MASOKYTEN"]);
                        obj.TENFILEKY = Common.ConDBNull(DataReader["TENFILEKY"]);
                        obj.USERNAMEKY = Common.ConDBNull(DataReader["USERNAMEKY"]);   
                        obj.Daky = !string.IsNullOrEmpty(obj.MaSoKy) ? true : false;
                        listResult.Add(obj);
                    }
                    return listResult;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static bool InsertOrUpdate_ChiTiet(MDB.MDBConnection MyConnection, PTDVCSNBC23_2_ChiTiet obj)
        {
            try
            {
                string sql = @"update PTDVCSNBC23_2_ChiTiet set
                    IDPhieu=:IDPhieu,
                    ThoiGian=:ThoiGian,
                    YThuc=:YThuc,
                    YThucKHCS=:YThucKHCS,
                    HH=:HH,
                    DaNM=:DaNM,
                    DaKhac=:DaKhac,
                    DaKHCS=:DaKHCS,
                    NT=:NT,
                    NTKhac=:NTKhac,
                    NTKHCS=:NTKHCS,
                    HA=:HA,
                    HAKhac=:HAKhac,
                    HAKHCS=:HAKHCS,
                    ND=:ND,
                    NDKhac=:NDKhac,
                    NDKHCS=:NDKHCS,
                    HHKhac=:HHKhac,
                    HHKHCS=:HHKHCS,
                    Ho=:Ho,
                    HoKhac=:HoKhac,
                    HoKHCS=:HoKHCS,
                    Phu=:Phu,
                    PhuKhac=:PhuKhac,
                    PhuKHCS=:PhuKHCS,
                    VM=:VM,
                    VMKhac=:VMKhac,
                    VMKHCS=:VMKHCS,
                    Dau=:Dau,
                    DauKhac=:DauKhac,
                    DauKHCS=:DauKHCS,
                    TenDT=:TenDT,
                    DT=:DT,
                    DTKhac=:DTKhac,
                    DTKHCS=:DTKHCS,
                    DD=:DD,
                    DDKhac=:DDKhac,
                    DDKHCS=:DDKHCS,
                    Bung=:Bung,
                    BungKHCS=:BungKHCS,
                    DaiTien=:DaiTien,
                    DaiTienKhac=:DaiTienKhac,
                    DaiTienKHCS=:DaiTienKHCS,
                    Tieu=:Tieu,
                    TieuKhac=:TieuKhac,
                    TieuKHCS=:TieuKHCS,
                    VSCN=:VSCN,
                    VSCNKHCS=:VSCNKHCS,
                    RML=:RML,
                    RMLKhac=:RMLKhac,
                    RMLKHCS=:RMLKHCS,
                    VanDong=:VanDong,
                    VanDongKHCS=:VanDongKHCS,
                    BThuong=:BThuong,
                    BThuongKHCS=:BThuongKHCS,
                    DHK=:DHK,
                    DHKKHCS=:DHKKHCS,
                    YThuc2=:YThuc2,
                    YThuc2KHCS=:YThuc2KHCS,
                    TuanHoan=:TuanHoan,
                    TuanHoanKHCS=:TuanHoanKHCS,
                    Hohap=:Hohap,
                    HohapKHCS=:HohapKHCS,
                    Khac=:Khac,
                    KhacKHCS=:KhacKHCS,
                    TGDHST=:TGDHST,
                    KHCS1Khac=:KHCS1Khac,
                    KHCS1DanhGia=:KHCS1DanhGia,
                    MaDD1=:MaDD1,
                    TenDD1=:TenDD1,
                    KHCS2_1=:KHCS2_1,
                    KHCS2_2=:KHCS2_2,
                    KHCS2_3=:KHCS2_3,
                    KHCS2Khac_Tho=:KHCS2Khac_Tho,
                    KHCS2Khac=:KHCS2Khac,
                    KHCS2DanhGia=:KHCS2DanhGia,
                    MaDD2=:MaDD2,
                    TenDD2=:TenDD2,
                    KHCS3_1=:KHCS3_1,
                    KHCS3_2=:KHCS3_2,
                    KHCS3_3=:KHCS3_3,
                    KHCS3_4=:KHCS3_4,
                    KHCS3_2Khac=:KHCS3_2Khac,
                    KHCS3_3Khac=:KHCS3_3Khac,
                    KHCS3_4Khac=:KHCS3_4Khac,KHCS3_5_1=:KHCS3_5_1,KHCS3_5_2=:KHCS3_5_2,KHCS3_5_3=:KHCS3_5_3,KHCS3_5Khac1=:KHCS3_5Khac1,KHCS3_5Khac2=:KHCS3_5Khac2,KHCS3_5Khac3=:KHCS3_5Khac3,
                    KHCS3DanhGia=:KHCS3DanhGia,
                    MaDD3=:MaDD3,
                    TenDD3=:TenDD3,
                    KHCS4_1=:KHCS4_1,
                    KHCS4_3=:KHCS4_3,
                    KHCS4_4=:KHCS4_4,
                    KHCS4_5=:KHCS4_5,
                    KHCS4_1Khac=:KHCS4_1Khac,
                    KHCS4_2Khac=:KHCS4_2Khac,
                    KHCS4_3Khac=:KHCS4_3Khac,
                    KHCS4DanhGia=:KHCS4DanhGia,
                    MaDD4=:MaDD4,
                    TenDD4=:TenDD4,
                    TVGDSK=:TVGDSK,
                    TVGDSKDanhGia=:TVGDSKDanhGia,
                    MaDD5=:MaDD5,
                    TenDD5=:TenDD5,KHCS4_5Khac=:KHCS4_5Khac, KHCS3_5Khac4 =:KHCS3_5Khac4, CSC =:CSC
                    WHERE IDPhieuCT = " + obj.IDPhieuCT + "";

                MDB.MDBCommand oracleCommand = new MDB.MDBCommand(sql, MyConnection);
                oracleCommand.Parameters.Add(new MDB.MDBParameter("IDPhieu", obj.IDPhieu));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("ThoiGian", obj.ThoiGian));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("YThuc", obj.YThuc));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("YThucKHCS", obj.YThucKHCS));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("HH", obj.HH));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("DaNM", obj.DaNM));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("DaKhac", obj.DaKhac));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("DaKHCS", obj.DaKHCS));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("NT", obj.NT));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("NTKhac", obj.NTKhac));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("NTKHCS", obj.NTKHCS));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("HA", obj.HA));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("HAKhac", obj.HAKhac));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("HAKHCS", obj.HAKHCS));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("ND", obj.ND));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("NDKhac", obj.NDKhac));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("NDKHCS", obj.NDKHCS));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("HHKhac", obj.HHKhac));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("HHKHCS", obj.HHKHCS));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("Ho", obj.Ho));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("HoKhac", obj.HoKhac));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("HoKHCS", obj.HoKHCS));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("Phu", obj.Phu));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("PhuKhac", obj.PhuKhac));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("PhuKHCS", obj.PhuKHCS));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("VM", obj.VM));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("VMKhac", obj.VMKhac));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("VMKHCS", obj.VMKHCS));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("Dau", obj.Dau));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("DauKhac", obj.DauKhac));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("DauKHCS", obj.DauKHCS));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("TenDT", obj.TenDT));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("DT", obj.DT));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("DTKhac", obj.DTKhac));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("DTKHCS", obj.DTKHCS));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("DD", obj.DD));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("DDKhac", obj.DDKhac));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("DDKHCS", obj.DDKHCS));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("Bung", obj.Bung));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("BungKHCS", obj.BungKHCS));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("DaiTien", obj.DaiTien));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("DaiTienKhac", obj.DaiTienKhac));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("DaiTienKHCS", obj.DaiTienKHCS));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("Tieu", obj.Tieu));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("TieuKhac", obj.TieuKhac));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("TieuKHCS", obj.TieuKHCS));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("VSCN", obj.VSCN));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("VSCNKHCS", obj.VSCNKHCS));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("RML", obj.RML));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("RMLKhac", obj.RMLKhac));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("RMLKHCS", obj.RMLKHCS));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("VanDong", obj.VanDong));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("VanDongKHCS", obj.VanDongKHCS));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("BThuong", obj.BThuong));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("BThuongKHCS", obj.BThuongKHCS));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("DHK", obj.DHK));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("DHKKHCS", obj.DHKKHCS));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("YThuc2", obj.YThuc2));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("YThuc2KHCS", obj.YThuc2KHCS));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("TuanHoan", obj.TuanHoan));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("TuanHoanKHCS", obj.TuanHoanKHCS));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("Hohap", obj.Hohap));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("HohapKHCS", obj.HohapKHCS));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("Khac", obj.Khac));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("KhacKHCS", obj.KhacKHCS));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("TGDHST", obj.TGDHST));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("KHCS1Khac", obj.KHCS1Khac));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("KHCS1DanhGia", obj.KHCS1DanhGia));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("MaDD1", obj.MaDD1));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("TenDD1", obj.TenDD1));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("KHCS2_1", obj.KHCS2_1));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("KHCS2_2", obj.KHCS2_2));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("KHCS2_3", obj.KHCS2_3));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("KHCS2Khac_Tho", obj.KHCS2Khac_Tho));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("KHCS2Khac", obj.KHCS2Khac));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("KHCS2DanhGia", obj.KHCS2DanhGia));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("MaDD2", obj.MaDD2));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("TenDD2", obj.TenDD2));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("KHCS3_1", obj.KHCS3_1));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("KHCS3_2", obj.KHCS3_2));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("KHCS3_3", obj.KHCS3_3));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("KHCS3_4", obj.KHCS3_4));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("KHCS3_2Khac", obj.KHCS3_2Khac));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("KHCS3_3Khac", obj.KHCS3_3Khac));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("KHCS3_4Khac", obj.KHCS3_4Khac));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("KHCS3_5_1", obj.KHCS3_5_1));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("KHCS3_5_2", obj.KHCS3_5_1));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("KHCS3_5_3", obj.KHCS3_5_3));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("KHCS3_5Khac1", obj.KHCS3_5Khac1));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("KHCS3_5Khac2", obj.KHCS3_5Khac2));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("KHCS3_5Khac3", obj.KHCS3_5Khac3));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("KHCS3DanhGia", obj.KHCS3DanhGia));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("MaDD3", obj.MaDD3));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("TenDD3", obj.TenDD3));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("KHCS4_1", obj.KHCS4_1));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("KHCS4_3", obj.KHCS4_3));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("KHCS4_4", obj.KHCS4_4));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("KHCS4_5", obj.KHCS4_5));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("KHCS4_1Khac", obj.KHCS4_1Khac));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("KHCS4_2Khac", obj.KHCS4_2Khac));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("KHCS4_3Khac", obj.KHCS4_3Khac));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("KHCS4DanhGia", obj.KHCS4DanhGia));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("MaDD4", obj.MaDD4));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("TenDD4", obj.TenDD4));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("TVGDSK", obj.TVGDSK));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("TVGDSKDanhGia", obj.TVGDSKDanhGia));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("MaDD5", obj.MaDD5));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("TenDD5", obj.TenDD5));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("KHCS4_5Khac", obj.KHCS4_5Khac));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("KHCS3_5Khac4", obj.KHCS3_5Khac4));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("CSC", obj.CSC));


                int n = oracleCommand.ExecuteNonQuery();
                if (n == 0)
                {
                    oracleCommand.Dispose();
                    sql = @"insert into PTDVCSNBC23_2_ChiTiet (
                    IDPhieu,
                    ThoiGian,
                    YThuc,
                    YThucKHCS,
                    HH,
                    DaNM,
                    DaKhac,
                    DaKHCS,
                    NT,
                    NTKhac,
                    NTKHCS,
                    HA,
                    HAKhac,
                    HAKHCS,
                    ND,
                    NDKhac,
                    NDKHCS,
                    HHKhac,
                    HHKHCS,
                    Ho,
                    HoKhac,
                    HoKHCS,
                    Phu,
                    PhuKhac,
                    PhuKHCS,
                    VM,
                    VMKhac,
                    VMKHCS,
                    Dau,
                    DauKhac,
                    DauKHCS,
                    TenDT,
                    DT,
                    DTKhac,
                    DTKHCS,
                    DD,
                    DDKhac,
                    DDKHCS,
                    Bung,
                    BungKHCS,
                    DaiTien,
                    DaiTienKhac,
                    DaiTienKHCS,
                    Tieu,
                    TieuKhac,
                    TieuKHCS,
                    VSCN,
                    VSCNKHCS,
                    RML,
                    RMLKhac,
                    RMLKHCS,
                    VanDong,
                    VanDongKHCS,
                    BThuong,
                    BThuongKHCS,
                    DHK,
                    DHKKHCS,
                    YThuc2,
                    YThuc2KHCS,
                    TuanHoan,
                    TuanHoanKHCS,
                    Hohap,
                    HohapKHCS,
                    Khac,
                    KhacKHCS,
                    TGDHST,
                    KHCS1Khac,
                    KHCS1DanhGia,
                    MaDD1,
                    TenDD1,
                    KHCS2_1,
                    KHCS2_2,
                    KHCS2_3,
                    KHCS2Khac_Tho,
                    KHCS2Khac,
                    KHCS2DanhGia,
                    MaDD2,
                    TenDD2,
                    KHCS3_1,
                    KHCS3_2,
                    KHCS3_3,
                    KHCS3_4,
                    KHCS3_2Khac,
                    KHCS3_3Khac,
                    KHCS3_4Khac,KHCS3_5_1,KHCS3_5_2,KHCS3_5_3,KHCS3_5Khac1,KHCS3_5Khac2,KHCS3_5Khac3,
                    KHCS3DanhGia,
                    MaDD3,
                    TenDD3,
                    KHCS4_1,
                    KHCS4_3,
                    KHCS4_4,
                    KHCS4_5,
                    KHCS4_1Khac,
                    KHCS4_2Khac,
                    KHCS4_3Khac,
                    KHCS4DanhGia,
                    MaDD4,
                    TenDD4,
                    TVGDSK,
                    TVGDSKDanhGia,
                    MaDD5,
                    TenDD5, KHCS4_5Khac, KHCS3_5Khac4, CSC
                    ) values (
                    :IDPhieu,
                    :ThoiGian,
                    :YThuc,
                    :YThucKHCS,
                    :HH,
                    :DaNM,
                    :DaKhac,
                    :DaKHCS,
                    :NT,
                    :NTKhac,
                    :NTKHCS,
                    :HA,
                    :HAKhac,
                    :HAKHCS,
                    :ND,
                    :NDKhac,
                    :NDKHCS,
                    :HHKhac,
                    :HHKHCS,
                    :Ho,
                    :HoKhac,
                    :HoKHCS,
                    :Phu,
                    :PhuKhac,
                    :PhuKHCS,
                    :VM,
                    :VMKhac,
                    :VMKHCS,
                    :Dau,
                    :DauKhac,
                    :DauKHCS,
                    :TenDT,
                    :DT,
                    :DTKhac,
                    :DTKHCS,
                    :DD,
                    :DDKhac,
                    :DDKHCS,
                    :Bung,
                    :BungKHCS,
                    :DaiTien,
                    :DaiTienKhac,
                    :DaiTienKHCS,
                    :Tieu,
                    :TieuKhac,
                    :TieuKHCS,
                    :VSCN,
                    :VSCNKHCS,
                    :RML,
                    :RMLKhac,
                    :RMLKHCS,
                    :VanDong,
                    :VanDongKHCS,
                    :BThuong,
                    :BThuongKHCS,
                    :DHK,
                    :DHKKHCS,
                    :YThuc2,
                    :YThuc2KHCS,
                    :TuanHoan,
                    :TuanHoanKHCS,
                    :Hohap,
                    :HohapKHCS,
                    :Khac,
                    :KhacKHCS,
                    :TGDHST,
                    :KHCS1Khac,
                    :KHCS1DanhGia,
                    :MaDD1,
                    :TenDD1,
                    :KHCS2_1,
                    :KHCS2_2,
                    :KHCS2_3,
                    :KHCS2Khac_Tho,
                    :KHCS2Khac,
                    :KHCS2DanhGia,
                    :MaDD2,
                    :TenDD2,
                    :KHCS3_1,
                    :KHCS3_2,
                    :KHCS3_3,
                    :KHCS3_4,
                    :KHCS3_2Khac,
                    :KHCS3_3Khac,
                    :KHCS3_4Khac,:KHCS3_5_1,:KHCS3_5_2,:KHCS3_5_3,:KHCS3_5Khac1,:KHCS3_5Khac2,:KHCS3_5Khac3,
                    :KHCS3DanhGia,
                    :MaDD3,
                    :TenDD3,
                    :KHCS4_1,
                    :KHCS4_3,
                    :KHCS4_4,
                    :KHCS4_5,
                    :KHCS4_1Khac,
                    :KHCS4_2Khac,
                    :KHCS4_3Khac,
                    :KHCS4DanhGia,
                    :MaDD4,
                    :TenDD4,
                    :TVGDSK,
                    :TVGDSKDanhGia,
                    :MaDD5,
                    :TenDD5, :KHCS4_5Khac, :KHCS3_5Khac4, :CSC
                     ) RETURNING IDPhieuCT INTO :IDPhieuCT";
                    oracleCommand = new MDB.MDBCommand(sql, MyConnection);
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("IDPhieu", obj.IDPhieu));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("ThoiGian", obj.ThoiGian));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("YThuc", obj.YThuc));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("YThucKHCS", obj.YThucKHCS));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("HH", obj.HH));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("DaNM", obj.DaNM));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("DaKhac", obj.DaKhac));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("DaKHCS", obj.DaKHCS));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("NT", obj.NT));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("NTKhac", obj.NTKhac));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("NTKHCS", obj.NTKHCS));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("HA", obj.HA));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("HAKhac", obj.HAKhac));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("HAKHCS", obj.HAKHCS));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("ND", obj.ND));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("NDKhac", obj.NDKhac));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("NDKHCS", obj.NDKHCS));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("HHKhac", obj.HHKhac));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("HHKHCS", obj.HHKHCS));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("Ho", obj.Ho));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("HoKhac", obj.HoKhac));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("HoKHCS", obj.HoKHCS));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("Phu", obj.Phu));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("PhuKhac", obj.PhuKhac));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("PhuKHCS", obj.PhuKHCS));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("VM", obj.VM));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("VMKhac", obj.VMKhac));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("VMKHCS", obj.VMKHCS));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("Dau", obj.Dau));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("DauKhac", obj.DauKhac));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("DauKHCS", obj.DauKHCS));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("TenDT", obj.TenDT));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("DT", obj.DT));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("DTKhac", obj.DTKhac));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("DTKHCS", obj.DTKHCS));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("DD", obj.DD));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("DDKhac", obj.DDKhac));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("DDKHCS", obj.DDKHCS));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("Bung", obj.Bung));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("BungKHCS", obj.BungKHCS));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("DaiTien", obj.DaiTien));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("DaiTienKhac", obj.DaiTienKhac));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("DaiTienKHCS", obj.DaiTienKHCS));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("Tieu", obj.Tieu));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("TieuKhac", obj.TieuKhac));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("TieuKHCS", obj.TieuKHCS));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("VSCN", obj.VSCN));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("VSCNKHCS", obj.VSCNKHCS));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("RML", obj.RML));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("RMLKhac", obj.RMLKhac));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("RMLKHCS", obj.RMLKHCS));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("VanDong", obj.VanDong));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("VanDongKHCS", obj.VanDongKHCS));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("BThuong", obj.BThuong));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("BThuongKHCS", obj.BThuongKHCS));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("DHK", obj.DHK));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("DHKKHCS", obj.DHKKHCS));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("YThuc2", obj.YThuc2));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("YThuc2KHCS", obj.YThuc2KHCS));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("TuanHoan", obj.TuanHoan));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("TuanHoanKHCS", obj.TuanHoanKHCS));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("Hohap", obj.Hohap));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("HohapKHCS", obj.HohapKHCS));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("Khac", obj.Khac));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("KhacKHCS", obj.KhacKHCS));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("TGDHST", obj.TGDHST));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("KHCS1Khac", obj.KHCS1Khac));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("KHCS1DanhGia", obj.KHCS1DanhGia));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("MaDD1", obj.MaDD1));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("TenDD1", obj.TenDD1));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("KHCS2_1", obj.KHCS2_1));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("KHCS2_2", obj.KHCS2_2));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("KHCS2_3", obj.KHCS2_3));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("KHCS2Khac_Tho", obj.KHCS2Khac_Tho));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("KHCS2Khac", obj.KHCS2Khac));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("KHCS2DanhGia", obj.KHCS2DanhGia));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("MaDD2", obj.MaDD2));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("TenDD2", obj.TenDD2));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("KHCS3_1", obj.KHCS3_1));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("KHCS3_2", obj.KHCS3_2));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("KHCS3_3", obj.KHCS3_3));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("KHCS3_4", obj.KHCS3_4));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("KHCS3_2Khac", obj.KHCS3_2Khac));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("KHCS3_3Khac", obj.KHCS3_3Khac));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("KHCS3_4Khac", obj.KHCS3_4Khac));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("KHCS3_5_1", obj.KHCS3_5_1));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("KHCS3_5_2", obj.KHCS3_5_1));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("KHCS3_5_3", obj.KHCS3_5_3));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("KHCS3_5Khac1", obj.KHCS3_5Khac1));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("KHCS3_5Khac2", obj.KHCS3_5Khac2));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("KHCS3_5Khac3", obj.KHCS3_5Khac3));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("KHCS3DanhGia", obj.KHCS3DanhGia));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("MaDD3", obj.MaDD3));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("TenDD3", obj.TenDD3));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("KHCS4_1", obj.KHCS4_1));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("KHCS4_3", obj.KHCS4_3));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("KHCS4_4", obj.KHCS4_4));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("KHCS4_5", obj.KHCS4_5));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("KHCS4_1Khac", obj.KHCS4_1Khac));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("KHCS4_2Khac", obj.KHCS4_2Khac));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("KHCS4_3Khac", obj.KHCS4_3Khac));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("KHCS4DanhGia", obj.KHCS4DanhGia));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("MaDD4", obj.MaDD4));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("TenDD4", obj.TenDD4));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("TVGDSK", obj.TVGDSK));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("TVGDSKDanhGia", obj.TVGDSKDanhGia));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("MaDD5", obj.MaDD5));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("TenDD5", obj.TenDD5));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("KHCS4_5Khac", obj.KHCS4_5Khac));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("KHCS3_5Khac4", obj.KHCS3_5Khac4));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("CSC", obj.CSC));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("IDPhieuCT", obj.IDPhieuCT));
                    n = oracleCommand.ExecuteNonQuery();
                    long nextval = Convert.ToInt64((oracleCommand.Parameters["IDPhieuCT"] as MDB.MDBParameter).Value);
                    obj.IDPhieuCT = nextval;
                }
                return n > 0 ? true : false;
            }
            catch (Exception ex)
            {
                throw ex;
            }
           
        }
        public static DataSet GetDataSet(MDB.MDBConnection MyConnection, decimal IDPhieu)
        {      
            var timer = new Stopwatch();
            StringBuilder sql = new StringBuilder();
            timer.Start();
            try
            {
                sql .AppendLine(@" select a.* ");
                sql.AppendLine(@" from PTDVCSNBC23_2 a");
                sql.AppendLine(" WHERE a.IDPhieu =:IDPhieu " );
                MDB.MDBCommand Command = new MDB.MDBCommand(sql.ToString(), MyConnection);
                Command.Parameters.Add(new MDB.MDBParameter("IDPhieu", IDPhieu));
                MDB.MDBDataAdapter adt = new MDB.MDBDataAdapter(Command);
                var ds = new DataSet();
                adt.Fill(ds);
                return ds;
            }
            catch (Exception ex)
            {
                MDB.ExceptionExtend.LogError(ex);
                return null;
            }
            finally
            {
                timer.Stop();
            }
        }
    }
}
