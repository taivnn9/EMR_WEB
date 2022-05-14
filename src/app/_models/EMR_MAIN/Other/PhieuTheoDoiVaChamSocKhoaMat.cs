using EMR.KyDienTu;
using NLog;
using PMS.Access;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Text;

namespace EMR_MAIN.DATABASE.Other
{

    public class PhieuTheoDoiVaChamSocKhoaMat : ThongTinKy
    {
        public PhieuTheoDoiVaChamSocKhoaMat()
        {
            TableName = "PhieuTDVCSBNKhoaMat";
            TablePrimaryKeyName = "ID";
            IDMauPhieu = (int)DanhMucPhieu.PTDVCSKM;
            TenMauPhieu = DanhMucPhieu.PTDVCSKM.Description();
        }
        [MoTaDuLieu("Mã định danh")]
		public decimal IDPhieu { set; get; }
        [MoTaDuLieu("Mã quản lý: mã duy nhất trong 1 đợt khám chữa bệnh (kcb), không trùng giữa các đợt kcb khác nhau","",1)]
		public decimal MaQuanLy { set; get; }
        [MoTaDuLieu("Tên khoa")]
		public string TenKhoa { set; get; }
        [MoTaDuLieu("Mã khoa")]
		public string MaKhoa { set; get; }
        [MoTaDuLieu("Mã bệnh nhân")]
		public string MaBenhNhan { set; get; }
        public string SoPhieu { set; get; }
        [MoTaDuLieu("Chẩn đoán bệnh")]
		public string ChanDoan { set; get; }
        [MoTaDuLieu("Buồng")]
		public string Buong { set; get; }
        [MoTaDuLieu("Giường")]
		public string Giuong { set; get; }
        [MoTaDuLieu("Mã giường")]
		public string MaGiuong { set; get; }
        public DateTime? NgayVaoVien { set; get; }
        [MoTaDuLieu("Người tạo", null, 0, 0)]
		public string NguoiTao { set; get; }
        [MoTaDuLieu("Ngày tạo", null, 0, 0)]
		public DateTime NgayTao { set; get; }
        [MoTaDuLieu("Người sửa", null, 0, 0)]
		public string NguoiSua { set; get; }
        [MoTaDuLieu("Ngày sửa", null, 0, 0)]
		public DateTime NgaySua { set; get; }
        public string TenDDCS { set; get; }//
        public string MaDDCS { set; get; }//
        public List<PhieuTheoDoiVaChamSocKhoaMat_ChiTiet> TTCSChiTiet { get; set; }
        [MoTaDuLieu("Chọn", null, 0, 0)]
		public bool Chon { get; set; }
        public string SoYTe
        {
            get
            {
                return XemBenhAn._HanhChinhBenhNhan.SoYTe;
            }
        }
        public string BenhVien
        {
            get
            {
                return XemBenhAn._HanhChinhBenhNhan.BenhVien;
            }
        }
        [MoTaDuLieu("Tuổi bệnh nhân")]
		public string Tuoi
        {
            get
            {
                return XemBenhAn._HanhChinhBenhNhan.Tuoi;
            }
        }
        [MoTaDuLieu("Giới tính bệnh nhân")]
		public string GioiTinh
        {
            get
            {
                return XemBenhAn._HanhChinhBenhNhan.GioiTinh.Description();
            }
        }
        public string SoVaoVien
        {
            get
            {
                return XemBenhAn._ThongTinDieuTri.SoNhapVien;
            }
        }
        [MoTaDuLieu("Họ và tên bệnh nhân")]
		public string TenBenhNhan
        {
            get
            {
                return XemBenhAn._HanhChinhBenhNhan.TenBenhNhan;
            }
        }
        public string MaBenhAn
        {
            get
            {
                return XemBenhAn._ThongTinDieuTri.MaBenhAn;
            }
        }
        public PhieuTheoDoiVaChamSocKhoaMat Clone()
        {
            PhieuTheoDoiVaChamSocKhoaMat other = (PhieuTheoDoiVaChamSocKhoaMat)this.MemberwiseClone();
            other.TTCSChiTiet = new List<PhieuTheoDoiVaChamSocKhoaMat_ChiTiet>();
            if (this.TTCSChiTiet != null)
            foreach (PhieuTheoDoiVaChamSocKhoaMat_ChiTiet item in this.TTCSChiTiet)
            {
                other.TTCSChiTiet.Add(item.Clone());
            }
            return other;
        }
        // them vao
        public DateTime? TGTiepNhan { set; get; }
        public string PCCS { set; get; }
        public bool[] TSDU_Array { get; } = new bool[] { false, false,false, false, false };
        public string TSDU
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < TSDU_Array.Length; i++)
                    temp += (TSDU_Array[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        TSDU_Array[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public string TSDU_Text { get; set; }
        public string TSB { get; set; }
        public string ChuanDoanSauMo { get; set; }
        public bool[] YThuc_Array { get; } = new bool[] { false, false };
        public string YThuc
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < YThuc_Array.Length; i++)
                    temp += (YThuc_Array[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        YThuc_Array[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public string YThuc_TiepXuc { get; set; }
        public string YThuc_Khac { get; set; }
        [MoTaDuLieu("Chiều cao")]
		public string ChieuCao { get; set; }
        [MoTaDuLieu("Cân nặng")]
		public string CanNang { get; set; }
        [MoTaDuLieu("Chỉ số BMI")]
		public string BMI { get; set; }
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
        public string Phu_ViTri { get; set; }
        public string DaNiemMac { get; set; }

        public bool[] HoHap_Array { get; } = new bool[] { false, false };
        public string HoHap
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < HoHap_Array.Length; i++)
                    temp += (HoHap_Array[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        HoHap_Array[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public string HoHap_Khac { get; set; }
        public bool[] TieuHoa_Array { get; } = new bool[] { false, false, false };
        public string TieuHoa
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < TieuHoa_Array.Length; i++)
                    temp += (TieuHoa_Array[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        TieuHoa_Array[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public string TieuHoa_Khac { get; set; }
        public string ThiLucMP { get; set; }
        public string ThiLucMT { get; set; }
        public bool[] SungMP_Array { get; } = new bool[] { false, false };
        public string SungMP
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < SungMP_Array.Length; i++)
                    temp += (SungMP_Array[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        SungMP_Array[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public bool[] SungMT_Array { get; } = new bool[] { false, false };
        public string SungMT
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < SungMT_Array.Length; i++)
                    temp += (SungMT_Array[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        SungMT_Array[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public bool[] DoMP_Array { get; } = new bool[] { false, false };
        public string DoMP
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < DoMP_Array.Length; i++)
                    temp += (DoMP_Array[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        DoMP_Array[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public bool[] DoMT_Array { get; } = new bool[] { false, false };
        public string DoMT
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < DoMT_Array.Length; i++)
                    temp += (DoMT_Array[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        DoMT_Array[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public bool[] DauMP_Array { get; } = new bool[] { false, false };
        public string DauMP
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < DauMP_Array.Length; i++)
                    temp += (DauMP_Array[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        DauMP_Array[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }

        public bool[] DauMT_Array { get; } = new bool[] { false, false };
        public string DauMT
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < DauMT_Array.Length; i++)
                    temp += (DauMT_Array[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        DauMT_Array[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public string TinhChatDauMP { get; set; }
        public string TinhChatDauMT { get; set; }
        public string VanDeKhac { get; set; }
        public DateTime? GioThucHienThuoc { get; set; }
        public DateTime? GioThucHienThuoc_Gio { get; set; }
        public bool[] XN_Array { get; } = new bool[] { false, false, false };

        public string XN
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < XN_Array.Length; i++)
                    temp += (XN_Array[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        XN_Array[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public string XN_Khac { get; set; }
        public int CDHA { get; set; }
        public int TDCN { get; set; }
        public bool[] CS_Array { get; } = new bool[] { false, false };
        public string CS
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < CS_Array.Length; i++)
                    temp += (CS_Array[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        CS_Array[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public string CheDoAn { get; set; }

        public bool[] DDKhac_Array { get; } = new bool[] { false, false, false };
        public string DDKhac
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < DDKhac_Array.Length; i++)
                    temp += (DDKhac_Array[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        DDKhac_Array[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public string ChamSocKhac { get; set; }
    }
    public class PhieuTheoDoiVaChamSocKhoaMat_ChiTiet: ThongTinKy
    {
        [MoTaDuLieu("Mã định danh")]
		public decimal IDPhieuCT { set; get; }
        [MoTaDuLieu("Mã định danh")]
		public decimal IDPhieu { set; get; }
        public DateTime ThoiGian { set; get; }
        [MoTaDuLieu("Người tạo", null, 0, 0)]
		public string NguoiTao { set; get; }
        public string MaNguoiTao { set; get; }
        public DateTime? ThoiGianDHST { set; get; }
        public double? Mach { set; get; }
        public double? T { set; get; }
        [MoTaDuLieu("Huyết áp")]
		public string HA { set; get; }
        [MoTaDuLieu("Nhịp tim")]
		public string NT { set; get; }
        public DateTime? ThoiGianTHCS { set; get; }
        [MoTaDuLieu("Người thực hiện")]
		public string NguoiThucHien { set; get; }
        [MoTaDuLieu("Mã người thực hiện")]
		public string MaNguoiThucHien { set; get; }
        public string PCCS { set; get; }
        public string TrieuChungCu { set; get; }
        public string DauHieuKhac { set; get; }
        public DateTime? GioThucHienThuoc { set; get; }
        public DateTime? GioThucHienThuoc_Gio { set; get; }
        public string XetNghiemMoi { set; get; }
        public string CDHAMoi { set; get; }
        public string CheDoAn { set; get; }
        public bool[] DDKhac_Array { get; } = new bool[] { false,false,false };
        public string DDKhac
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < DDKhac_Array.Length; i++)
                    temp += (DDKhac_Array[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        DDKhac_Array[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public string ChamSocKhac { set; get; }
        public string MaDDCS { set; get; }
        public string TenDDCS { set; get; }
        public string NGAYKY { set; get; }
        public string COMPUTERKYTEN { set; get; }
        //public string MASOKYTEN { set; get; }
        public string TENFILEKY { set; get; }
        public string USERNAMEKY { set; get; }
        public bool Daky { set; get; }
        [MoTaDuLieu("Chọn", null, 0, 0)]
		public bool Chon { get; set; }
        public PhieuTheoDoiVaChamSocKhoaMat_ChiTiet Clone()
        {
            PhieuTheoDoiVaChamSocKhoaMat_ChiTiet other = (PhieuTheoDoiVaChamSocKhoaMat_ChiTiet)this.MemberwiseClone(); 
            return other;
        }
    }
    public class PhieuTheoDoiVaChamSocKhoaMatFunc
    {
        static Logger log = LogManager.GetLogger("Log");
        public const string TableName = "PhieuTDVCSBNKhoaMat";
        public const string TablePrimaryKeyName = "IDPhieu";

        public static List<ThuocPha> DanhSachThuocPha = new List<ThuocPha>();


        public List<PhieuTheoDoiVaChamSocKhoaMat> Select(MDB.MDBConnection MyConnection, string MaQuanLy)
        {
            try
            { 
                { 
                    List<PhieuTheoDoiVaChamSocKhoaMat> listResult = new List<PhieuTheoDoiVaChamSocKhoaMat>();
                    string sql = @"SELECT t.*
                    FROM PhieuTDVCSBNKhoaMat t
                    WHERE t.MaQuanLy = :MaQuanLy";
                    sql = sql + " ORDER BY t.NgayTao DESC";
                    MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
                    Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", MaQuanLy));
                    MDB.MDBDataReader DataReader = Command.ExecuteReader();
                    while (DataReader.Read())
                    {
                        var obj = new PhieuTheoDoiVaChamSocKhoaMat();
                        obj.IDPhieu = Common.ConDB_Decimal(DataReader["IDPhieu"]);
                        obj.MaQuanLy = Common.ConDB_Decimal(DataReader["MaQuanLy"]);
                        obj.TenKhoa = Common.ConDBNull(DataReader["TenKhoa"]);
                        obj.MaKhoa = Common.ConDBNull(DataReader["MaKhoa"]);
                        obj.MaBenhNhan = Common.ConDBNull(DataReader["MaBenhNhan"]);
                        obj.SoPhieu = Common.ConDBNull(DataReader["SoPhieu"]);
                        obj.ChanDoan = Common.ConDBNull(DataReader["ChanDoan"]);
                        obj.Buong = Common.ConDBNull(DataReader["Buong"]);
                        obj.Giuong = Common.ConDBNull(DataReader["Giuong"]);
                        obj.MaGiuong = Common.ConDBNull(DataReader["MaGiuong"]);
                        obj.NgayVaoVien = Common.ConDB_DateTimeNull(DataReader["NgayVaoVien"]);
                        obj.TenDDCS = Common.ConDBNull(DataReader["TenDDCS"]);
                        obj.MaDDCS = Common.ConDBNull(DataReader["MaDDCS"]);
                        obj.TGTiepNhan = Common.ConDB_DateTimeNull(DataReader["TGTiepNhan"]);

                        obj.PCCS = Common.ConDBNull(DataReader["PCCS"]);
                        obj.TSDU = Common.ConDBNull(DataReader["TSDU"]);
                        obj.TSDU_Text = Common.ConDBNull(DataReader["TSDU_Text"]);
                        obj.TSB = Common.ConDBNull(DataReader["TSB"]);
                        obj.ChuanDoanSauMo = Common.ConDBNull(DataReader["ChuanDoanSauMo"]);
                        obj.YThuc = Common.ConDBNull(DataReader["YThuc"]);
                        obj.YThuc_TiepXuc = Common.ConDBNull(DataReader["YThuc_TiepXuc"]);
                        obj.YThuc_Khac = Common.ConDBNull(DataReader["YThuc_Khac"]);
                        obj.ChieuCao = Common.ConDBNull(DataReader["ChieuCao"]);
                        obj.CanNang = Common.ConDBNull(DataReader["CanNang"]);
                        obj.BMI = Common.ConDBNull(DataReader["BMI"]);
                        obj.Phu = Common.ConDBNull(DataReader["Phu"]);
                        obj.Phu_ViTri = Common.ConDBNull(DataReader["Phu_ViTri"]);
                        obj.DaNiemMac = Common.ConDBNull(DataReader["DaNiemMac"]);
                        obj.HoHap = Common.ConDBNull(DataReader["HoHap"]);
                        obj.TieuHoa = Common.ConDBNull(DataReader["TieuHoa"]);
                        obj.TieuHoa_Khac = Common.ConDBNull(DataReader["TieuHoa_Khac"]);
                        obj.HoHap_Khac = Common.ConDBNull(DataReader["HoHap_Khac"]);
                        obj.ThiLucMP = Common.ConDBNull(DataReader["ThiLucMP"]);
                        obj.ThiLucMT = Common.ConDBNull(DataReader["ThiLucMT"]);
                        obj.SungMP = Common.ConDBNull(DataReader["SungMP"]);
                        obj.SungMT = Common.ConDBNull(DataReader["SungMT"]);
                        obj.DoMP = Common.ConDBNull(DataReader["DoMP"]);
                        obj.DoMT = Common.ConDBNull(DataReader["DoMT"]);
                        obj.DauMP = Common.ConDBNull(DataReader["DauMP"]);
                        obj.DauMT = Common.ConDBNull(DataReader["DauMT"]);
                        obj.TinhChatDauMP = Common.ConDBNull(DataReader["TinhChatDauMP"]);
                        obj.TinhChatDauMT = Common.ConDBNull(DataReader["TinhChatDauMT"]);
                        obj.VanDeKhac = Common.ConDBNull(DataReader["VanDeKhac"]);
                        obj.GioThucHienThuoc = Common.ConDB_DateTime(DataReader["GioThucHienThuoc"]);
                        obj.GioThucHienThuoc_Gio = obj.GioThucHienThuoc;
                        obj.XN = Common.ConDBNull(DataReader["XN"]);
                        obj.XN_Khac = Common.ConDBNull(DataReader["XN_Khac"]);
                        obj.CDHA = Common.ConDB_Int(DataReader["CDHA"]);
                        obj.TDCN = Common.ConDB_Int(DataReader["TDCN"]);
                        obj.CS = Common.ConDBNull(DataReader["CS"]);
                        obj.CheDoAn = Common.ConDBNull(DataReader["CheDoAn"]);
                        obj.DDKhac = Common.ConDBNull(DataReader["DDKhac"]);
                        obj.CS = Common.ConDBNull(DataReader["CS"]);
                        obj.ChamSocKhac = Common.ConDBNull(DataReader["ChamSocKhac"]);
                        obj.NguoiTao = Common.ConDBNull(DataReader["NguoiTao"]);
                        obj.NgayTao = Common.ConDB_DateTime(DataReader["NgayTao"]);
                        obj.NguoiSua = Common.ConDBNull(DataReader["NguoiSua"]);
                        obj.NgaySua = Common.ConDB_DateTime(DataReader["NgaySua"]);
                        obj.TTCSChiTiet = new List<PhieuTheoDoiVaChamSocKhoaMat_ChiTiet>();
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
        public bool Insert(MDB.MDBConnection MyConnection, PhieuTheoDoiVaChamSocKhoaMat obj)
        {
            try
            { 
                { 
                    string sql = @"INSERT INTO PhieuTDVCSBNKhoaMat (
                    MaQuanLy,
                    TenKhoa,
                    MaKhoa,
                    MaBenhNhan,
                    SoPhieu,
                    ChanDoan,
                    Buong,
                    Giuong,
                    MaGiuong,
                    NgayVaoVien,TenDDCS,MaDDCS,
                    TGTiepNhan,
                    PCCS,
                    TSDU,
                    TSDU_Text,
                    TSB,
                    ChuanDoanSauMo,
                    YThuc,
                    YThuc_TiepXuc,
                    YThuc_Khac,
                    ChieuCao,
                    CanNang,
                    BMI,
                    Phu,
                    Phu_ViTri,
                    DaNiemMac,
                    HoHap,
                    HoHap_Khac,
                    TieuHoa,
                    TieuHoa_Khac,
                    ThiLucMP,
                    ThiLucMT,
                    SungMP,
                    SungMT,
                    DoMP,
                    DoMT,
                    DauMP,
                    DauMT,
                    TinhChatDauMP,
                    TinhChatDauMT,
                    VanDeKhac,
                    GioThucHienThuoc,
                    XN,
                    XN_Khac,
                    CDHA,
                    TDCN,
                    CS,
                    CheDoAn,
                    DDKhac,
                    ChamSocKhac,
                    NguoiTao,
                    NgayTao,
                    NguoiSua,
                    NgaySua
                    ) 
                    VALUES (
                    :MaQuanLy,
                    :TenKhoa,
                    :MaKhoa,
                    :MaBenhNhan,
                    :SoPhieu,
                    :ChanDoan,
                    :Buong,
                    :Giuong,
                    :MaGiuong,
                    :NgayVaoVien,:TenDDCS,:MaDDCS,
                    :TGTiepNhan,
                    :PCCS,
                    :TSDU,
                    :TSDU_Text,
                    :TSB,
                    :ChuanDoanSauMo,
                    :YThuc,
                    :YThuc_TiepXuc,
                    :YThuc_Khac,
                    :ChieuCao,
                    :CanNang,
                    :BMI,
                    :Phu,
                    :Phu_ViTri,
                    :DaNiemMac,
                    :HoHap,
                    :HoHap_Khac,
                    :TieuHoa,
                    :TieuHoa_Khac,
                    :ThiLucMP,
                    :ThiLucMT,
                    :SungMP,
                    :SungMT,
                    :DoMP,
                    :DoMT,
                    :DauMP,
                    :DauMT,
                    :TinhChatDauMP,
                    :TinhChatDauMT,
                    :VanDeKhac,
                    :GioThucHienThuoc,
                    :XN,
                    :XN_Khac,
                    :CDHA,
                    :TDCN,
                    :CS,
                    :CheDoAn,
                    :DDKhac,
                    :ChamSocKhac,
                    :NguoiTao,
                    :NgayTao,
                    :NguoiSua,
                    :NgaySua
                    ) RETURNING IDPhieu INTO :IDPhieu ";
                    MDB.MDBCommand oracleCommand = new MDB.MDBCommand(sql, MyConnection);
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("MaQuanLy", obj.MaQuanLy));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("TenKhoa", obj.TenKhoa));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("MaKhoa", obj.MaKhoa));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("MaBenhNhan", obj.MaBenhNhan));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("SoPhieu", obj.SoPhieu));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("ChanDoan", obj.ChanDoan));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("Buong", obj.Buong));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("Giuong", obj.Giuong));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("MaGiuong", obj.MaGiuong));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("NgayVaoVien", obj.NgayVaoVien));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("TenDDCS", obj.TenDDCS));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("MaDDCS", obj.MaDDCS));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("TGTiepNhan", obj.TGTiepNhan));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("PCCS", obj.PCCS));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("TSDU", obj.TSDU));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("TSDU_Text", obj.TSDU_Text));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("TSB", obj.TSB));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("ChuanDoanSauMo", obj.ChuanDoanSauMo));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("YThuc", obj.YThuc));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("YThuc_TiepXuc", obj.YThuc_TiepXuc));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("YThuc_Khac", obj.YThuc_Khac));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("ChieuCao", obj.ChieuCao));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("CanNang", obj.CanNang));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("BMI", obj.BMI));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("Phu", obj.Phu));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("Phu_ViTri", obj.Phu_ViTri));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("DaNiemMac", obj.DaNiemMac));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("HoHap", obj.HoHap));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("HoHap_Khac", obj.HoHap_Khac));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("TieuHoa", obj.TieuHoa));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("TieuHoa_Khac", obj.TieuHoa_Khac));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("ThiLucMP", obj.ThiLucMP));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("ThiLucMT", obj.ThiLucMT));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("SungMP", obj.SungMP));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("SungMT", obj.SungMT));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("DoMP", obj.DoMP));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("DoMT", obj.DoMT));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("DauMP", obj.DauMP));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("DauMT", obj.DauMT));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("TinhChatDauMP", obj.TinhChatDauMP));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("TinhChatDauMT", obj.TinhChatDauMT));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("VanDeKhac", obj.VanDeKhac));

                    DateTime? ThoiGian = obj.GioThucHienThuoc.HasValue ? obj.GioThucHienThuoc.Value.Date : (DateTime?)null;
                    var ThoiGianFull = ThoiGian;
                    if (ThoiGian != null)
                    {
                        var ThoiGian_Gio = obj.GioThucHienThuoc_Gio.HasValue ? obj.GioThucHienThuoc_Gio.Value.TimeOfDay : new TimeSpan(0, 0, 0);
                        ThoiGianFull = ThoiGian + ThoiGian_Gio;
                    }

                    oracleCommand.Parameters.Add(new MDB.MDBParameter("GioThucHienThuoc", ThoiGianFull));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("XN", obj.XN));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("XN_Khac", obj.XN_Khac));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("CDHA", obj.CDHA));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("TDCN", obj.TDCN));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("CS", obj.CS));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("CheDoAn", obj.CheDoAn));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("DDKhac", obj.DDKhac));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("ChamSocKhac", obj.ChamSocKhac));

                    oracleCommand.Parameters.Add(new MDB.MDBParameter("NguoiTao", Common.getUserLogin()));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("NgayTao", DateTime.Now));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("NguoiSua", Common.getUserLogin()));
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
        public bool Update(MDB.MDBConnection MyConnection, PhieuTheoDoiVaChamSocKhoaMat obj)
        {
            try
            {
                {

                    string sql = @"UPDATE PhieuTDVCSBNKhoaMat SET 
                        MaQuanLy=:MaQuanLy,
                        TenKhoa=:TenKhoa,
                        MaKhoa=:MaKhoa,
                        MaBenhNhan=:MaBenhNhan,
                        SoPhieu=:SoPhieu,
                        ChanDoan=:ChanDoan,
                        Buong=:Buong,
                        Giuong=:Giuong,
                        MaGiuong=:MaGiuong,
                        NgayVaoVien=:NgayVaoVien,TenDDCS=:TenDDCS, MaDDCS=:MaDDCS,
                        TGTiepNhan=:TGTiepNhan,
                        PCCS = :PCCS,
                        TSDU = :TSDU,
                        TSDU_Text = :TSDU_Text,
                        TSB = :TSB,
                        ChuanDoanSauMo = :ChuanDoanSauMo,
                        YThuc = :YThuc,
                        YThuc_TiepXuc = :YThuc_TiepXuc,
                        YThuc_Khac = :YThuc_Khac,
                        ChieuCao = :ChieuCao,
                        CanNang = :CanNang,
                        BMI = :BMI,
                        Phu = :Phu,
                        Phu_ViTri = :Phu_ViTri,
                        DaNiemMac = :DaNiemMac,
                        HoHap = :HoHap,
                        HoHap_Khac = :HoHap_Khac,
                        TieuHoa = :TieuHoa,
                        TieuHoa_Khac = :TieuHoa_Khac,
                        ThiLucMP = :ThiLucMP,
                        ThiLucMT = :ThiLucMT,
                        SungMP = :SungMP,
                        SungMT = :SungMT,
                        DoMP = :DoMP,
                        DoMT = :DoMT,
                        DauMP = :DauMP,
                        DauMT = :DauMT,
                        TinhChatDauMP = :TinhChatDauMP,
                        TinhChatDauMT = :TinhChatDauMT,
                        VanDeKhac = :VanDeKhac,
                        GioThucHienThuoc = :GioThucHienThuoc,
                        XN = :XN,
                        XN_Khac = :XN_Khac,
                        CDHA = :CDHA,
                        TDCN = :TDCN,
                        CS = :CS,
                        CheDoAn = :CheDoAn,
                        DDKhac = :DDKhac,
                        ChamSocKhac = :ChamSocKhac,
                        NguoiSua=:NguoiSua,
                        NgaySua=:NgaySua
                        WHERE IDPhieu = " + obj.IDPhieu;
                    MDB.MDBCommand oracleCommand = new MDB.MDBCommand(sql, MyConnection);
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("MaQuanLy", obj.MaQuanLy));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("TenKhoa", obj.TenKhoa));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("MaKhoa", obj.MaKhoa));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("MaBenhNhan", obj.MaBenhNhan));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("SoPhieu", obj.SoPhieu));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("ChanDoan", obj.ChanDoan));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("Buong", obj.Buong));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("Giuong", obj.Giuong));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("MaGiuong", obj.MaGiuong));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("NgayVaoVien", obj.NgayVaoVien));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("TenDDCS", obj.TenDDCS));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("MaDDCS", obj.MaDDCS));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("TGTiepNhan", obj.TGTiepNhan));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("PCCS", obj.PCCS));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("TSDU", obj.TSDU));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("TSDU_Text", obj.TSDU_Text));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("TSB", obj.TSB));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("ChuanDoanSauMo", obj.ChuanDoanSauMo));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("YThuc", obj.YThuc));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("YThuc_TiepXuc", obj.YThuc_TiepXuc));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("YThuc_Khac", obj.YThuc_Khac));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("ChieuCao", obj.ChieuCao));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("CanNang", obj.CanNang));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("BMI", obj.BMI));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("Phu", obj.Phu));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("Phu_ViTri", obj.Phu_ViTri));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("DaNiemMac", obj.DaNiemMac));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("HoHap", obj.HoHap));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("HoHap_Khac", obj.HoHap_Khac));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("TieuHoa", obj.TieuHoa));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("TieuHoa_Khac", obj.TieuHoa_Khac));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("ThiLucMP", obj.ThiLucMP));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("ThiLucMT", obj.ThiLucMT));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("SungMP", obj.SungMP));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("SungMT", obj.SungMT));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("DoMP", obj.DoMP));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("DoMT", obj.DoMT));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("DauMP", obj.DauMP));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("DauMT", obj.DauMT));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("TinhChatDauMP", obj.TinhChatDauMP));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("TinhChatDauMT", obj.TinhChatDauMT));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("VanDeKhac", obj.VanDeKhac));

                    DateTime? ThoiGian = obj.GioThucHienThuoc.HasValue ? obj.GioThucHienThuoc.Value.Date : (DateTime?)null;
                    var ThoiGianFull = ThoiGian;
                    if (ThoiGian != null)
                    {
                        var ThoiGian_Gio = obj.GioThucHienThuoc_Gio.HasValue ? obj.GioThucHienThuoc_Gio.Value.TimeOfDay : new TimeSpan(0, 0, 0);
                        ThoiGianFull = ThoiGian + ThoiGian_Gio;
                    }

                    oracleCommand.Parameters.Add(new MDB.MDBParameter("GioThucHienThuoc", ThoiGianFull));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("XN", obj.XN));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("XN_Khac", obj.XN_Khac));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("CDHA", obj.CDHA));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("TDCN", obj.TDCN));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("CS", obj.CS));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("CheDoAn", obj.CheDoAn));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("DDKhac", obj.DDKhac));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("ChamSocKhac", obj.ChamSocKhac));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("NguoiSua", Common.getUserLogin()));
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
        public bool Delete(MDB.MDBConnection MyConnection, decimal IDPhieu)
        {
            try
            {
                if (IDPhieu != 0)
                {
                    string sql = @"Delete PhieuTDVCSBNKhoaMat 
                                WHERE 
                                (IDPhieu = :IDPhieu) ";
                    MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
                    Command.Parameters.Add(new MDB.MDBParameter(":IDPhieu", IDPhieu));
                    int n = Command.ExecuteNonQuery();
                    Command.Dispose();
                    sql = @"Delete PTDVCSBNKhoaMat_ChiTiet 
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
        public bool Delete_ChiTiet(MDB.MDBConnection MyConnection, decimal IDPhieuCT)
        {
            try
            {
                if (IDPhieuCT != 0)
                {
                    string sql = @"Delete PTDVCSBNKhoaMat_ChiTiet 
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
        public static List<PhieuTheoDoiVaChamSocKhoaMat_ChiTiet> Select_PhieuCHiTiet(MDB.MDBConnection MyConnection, string IDPhieu, int ModOrder = 0)
        {
            try
            {  
                {
                    List<PhieuTheoDoiVaChamSocKhoaMat_ChiTiet> listResult = new List<PhieuTheoDoiVaChamSocKhoaMat_ChiTiet>();
                    string sql = @"SELECT t.*
                    FROM PTDVCSBNKhoaMat_ChiTiet t
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
                        var obj = new PhieuTheoDoiVaChamSocKhoaMat_ChiTiet();
                        obj.IDPhieuCT = Common.ConDB_Decimal(DataReader["IDPhieuCT"]);
                        obj.IDPhieu = Common.ConDB_Decimal(DataReader["IDPhieu"]);
                        obj.ThoiGian = Common.ConDB_DateTime(DataReader["ThoiGian"]);
                        obj.NguoiTao = Common.ConDBNull(DataReader["NguoiTao"]);
                        obj.MaNguoiTao = Common.ConDBNull(DataReader["MaNguoiTao"]);
                        obj.ThoiGianDHST = Common.ConDB_DateTimeNull(DataReader["ThoiGianDHST"]);
                        obj.Mach = Common.ConDBNull_double(DataReader["Mach"]);
                        obj.T = Common.ConDBNull_double(DataReader["T"]);
                        obj.HA = Common.ConDBNull(DataReader["HA"]);
                        obj.NT = Common.ConDBNull(DataReader["NT"]);
                        obj.ThoiGianTHCS = Common.ConDB_DateTimeNull(DataReader["ThoiGianTHCS"]);
                        obj.NguoiThucHien = Common.ConDBNull(DataReader["NguoiThucHien"]);
                        obj.MaNguoiThucHien = Common.ConDBNull(DataReader["MaNguoiThucHien"]);
                        obj.PCCS = Common.ConDBNull(DataReader["PCCS"]);
                        obj.TrieuChungCu = Common.ConDBNull(DataReader["TrieuChungCu"]);
                        obj.DauHieuKhac = Common.ConDBNull(DataReader["DauHieuKhac"]);
                        obj.GioThucHienThuoc = Common.ConDB_DateTimeNull(DataReader["GioThucHienThuoc"]);
                        obj.GioThucHienThuoc_Gio = obj.GioThucHienThuoc;
                        obj.XetNghiemMoi = Common.ConDBNull(DataReader["XetNghiemMoi"]);
                        obj.CDHAMoi = Common.ConDBNull(DataReader["CDHAMoi"]);
                        obj.CheDoAn = Common.ConDBNull(DataReader["CheDoAn"]);
                        obj.DDKhac = Common.ConDBNull(DataReader["DDKhac"]);
                        obj.ChamSocKhac = Common.ConDBNull(DataReader["ChamSocKhac"]);
                        obj.MaDDCS = Common.ConDBNull(DataReader["MaDDCS"]);
                        obj.TenDDCS = Common.ConDBNull(DataReader["TenDDCS"]);
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
        public bool InsertOrUpdate_ChiTiet(MDB.MDBConnection MyConnection, PhieuTheoDoiVaChamSocKhoaMat_ChiTiet obj)
        {
            try
            {
                string sql = @"update PTDVCSBNKhoaMat_ChiTiet set
                    IDPhieu=:IDPhieu,
                    ThoiGian=:ThoiGian,
                    NguoiTao=:NguoiTao,
                    MaNguoiTao=:MaNguoiTao,
                    ThoiGianDHST=:ThoiGianDHST,
                    Mach=:Mach,
                    T=:T,
                    HA=:HA,
                    NT=:NT,
                    ThoiGianTHCS=:ThoiGianTHCS,
                    NguoiThucHien=:NguoiThucHien,
                    MaNguoiThucHien=:MaNguoiThucHien,
                    PCCS=:PCCS,
                    TrieuChungCu=:TrieuChungCu,
                    DauHieuKhac=:DauHieuKhac,
                    GioThucHienThuoc=:GioThucHienThuoc,
                    XetNghiemMoi=:XetNghiemMoi,
                    CDHAMoi=:CDHAMoi,
                    CheDoAn=:CheDoAn,
                    DDKhac=:DDKhac,
                    ChamSocKhac=:ChamSocKhac,
                    MaDDCS=:MaDDCS,
                    TenDDCS=:TenDDCS 
                    WHERE IDPhieuCT = " + obj.IDPhieuCT + "";

                MDB.MDBCommand oracleCommand = new MDB.MDBCommand(sql, MyConnection);
                oracleCommand.Parameters.Add(new MDB.MDBParameter("IDPhieu", obj.IDPhieu));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("ThoiGian", obj.ThoiGian));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("NguoiTao", obj.NguoiTao));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("MaNguoiTao", obj.MaNguoiTao));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("ThoiGianDHST", obj.ThoiGianDHST));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("Mach", obj.Mach));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("T", obj.T));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("HA", obj.HA));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("NT", obj.NT));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("ThoiGianTHCS", obj.ThoiGianTHCS));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("NguoiThucHien", obj.NguoiThucHien));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("MaNguoiThucHien", obj.MaNguoiThucHien));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("PCCS", obj.PCCS));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("TrieuChungCu", obj.TrieuChungCu));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("DauHieuKhac", obj.DauHieuKhac));
                DateTime? ThoiGian = obj.GioThucHienThuoc.HasValue ? obj.GioThucHienThuoc.Value.Date : (DateTime?)null;
                var ThoiGianFull = ThoiGian;
                if (ThoiGian != null)
                {
                    var ThoiGian_Gio = obj.GioThucHienThuoc_Gio.HasValue ? obj.GioThucHienThuoc_Gio.Value.TimeOfDay : new TimeSpan(0, 0, 0);
                    ThoiGianFull = ThoiGian + ThoiGian_Gio;
                }
                oracleCommand.Parameters.Add(new MDB.MDBParameter("GioThucHienThuoc", ThoiGianFull));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("XetNghiemMoi", obj.XetNghiemMoi));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("CDHAMoi", obj.CDHAMoi));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("CheDoAn", obj.CheDoAn));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("DDKhac", obj.DDKhac));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("ChamSocKhac", obj.ChamSocKhac));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("MaDDCS", obj.MaDDCS));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("TenDDCS", obj.TenDDCS));

                int n = oracleCommand.ExecuteNonQuery();
                if (n == 0)
                {
                    oracleCommand.Dispose();
                    sql = @"insert into PTDVCSBNKhoaMat_ChiTiet (
                    IDPhieu,
                    ThoiGian,
                    NguoiTao,
                    MaNguoiTao,
                    ThoiGianDHST,
                    Mach,
                    T,
                    HA,
                    NT,
                    ThoiGianTHCS,
                    NguoiThucHien,
                    MaNguoiThucHien,
                    PCCS,
                    TrieuChungCu,
                    DauHieuKhac,
                    GioThucHienThuoc,
                    XetNghiemMoi,
                    CDHAMoi,
                    CheDoAn,
                    DDKhac,
                    ChamSocKhac,
                    MaDDCS,
                    TenDDCS
                    ) values (
                    :IDPhieu,
                    :ThoiGian,
                    :NguoiTao,
                    :MaNguoiTao,
                    :ThoiGianDHST,
                    :Mach,
                    :T,
                    :HA,
                    :NT,
                    :ThoiGianTHCS,
                    :NguoiThucHien,
                    :MaNguoiThucHien,
                    :PCCS,
                    :TrieuChungCu,
                    :DauHieuKhac,
                    :GioThucHienThuoc,
                    :XetNghiemMoi,
                    :CDHAMoi,
                    :CheDoAn,
                    :DDKhac,
                    :ChamSocKhac,
                    :MaDDCS,
                    :TenDDCS
                    ) RETURNING IDPhieuCT INTO :IDPhieuCT";
                    oracleCommand = new MDB.MDBCommand(sql, MyConnection);
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("IDPhieu", obj.IDPhieu));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("ThoiGian", obj.ThoiGian));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("NguoiTao", obj.NguoiTao));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("MaNguoiTao", obj.MaNguoiTao));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("ThoiGianDHST", obj.ThoiGianDHST));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("Mach", obj.Mach));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("T", obj.T));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("HA", obj.HA));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("NT", obj.NT));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("ThoiGianTHCS", obj.ThoiGianTHCS));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("NguoiThucHien", obj.NguoiThucHien));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("MaNguoiThucHien", obj.MaNguoiThucHien));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("PCCS", obj.PCCS));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("TrieuChungCu", obj.TrieuChungCu));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("DauHieuKhac", obj.DauHieuKhac));
                    DateTime? ThoiGian1 = obj.GioThucHienThuoc.HasValue ? obj.GioThucHienThuoc.Value.Date : (DateTime?)null;
                    var ThoiGianFull1 = ThoiGian1;
                    if (ThoiGian1 != null)
                    {
                        var ThoiGian_Gio1 = obj.GioThucHienThuoc_Gio.HasValue ? obj.GioThucHienThuoc_Gio.Value.TimeOfDay : new TimeSpan(0, 0, 0);
                        ThoiGianFull1 = ThoiGian1 + ThoiGian_Gio1;
                    }
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("GioThucHienThuoc", ThoiGianFull));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("XetNghiemMoi", obj.XetNghiemMoi));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("CDHAMoi", obj.CDHAMoi));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("CheDoAn", obj.CheDoAn));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("DDKhac", obj.DDKhac));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("ChamSocKhac", obj.ChamSocKhac));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("MaDDCS", obj.MaDDCS));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("TenDDCS", obj.TenDDCS));
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
                sql.AppendLine(@"SELECT P.*, '' SoNhapVien, '' MaBenhAn , '' SoVaoVien, '' TenBenhNhan,
                        '' TUOI, '' SoYTe, '' BENHVIEN,
                        ''  GioiTinh
                    FROM PhieuTDVCSBNKhoaMat P
                ");
                sql.AppendLine(" WHERE P.IDPhieu = " + IDPhieu);
                MDB.MDBCommand Command = new MDB.MDBCommand(sql.ToString(), MyConnection);  
                MDB.MDBDataAdapter adt = new MDB.MDBDataAdapter(Command);
                var ds = new DataSet();
                adt.Fill(ds);
                if (ds != null || ds.Tables[0].Rows.Count > 0)
                {
                    ds.Tables[0].Rows[0]["SoNhapVien"] = XemBenhAn._ThongTinDieuTri.SoNhapVien;
                    ds.Tables[0].Rows[0]["MaBenhAn"] = XemBenhAn._ThongTinDieuTri.MaBenhAn;
                    ds.Tables[0].Rows[0]["SoVaoVien"] = XemBenhAn._ThongTinDieuTri.SoNhapVien;
                    ds.Tables[0].Rows[0]["TenBenhNhan"] = XemBenhAn._HanhChinhBenhNhan.TenBenhNhan;
                    ds.Tables[0].Rows[0]["TUOI"] = XemBenhAn._HanhChinhBenhNhan.Tuoi;
                    ds.Tables[0].Rows[0]["SoYTe"] = XemBenhAn._HanhChinhBenhNhan.SoYTe;
                    ds.Tables[0].Rows[0]["BENHVIEN"] = XemBenhAn._HanhChinhBenhNhan.BenhVien;
                    ds.Tables[0].Rows[0]["GioiTinh"] = XemBenhAn._HanhChinhBenhNhan.GioiTinh.Description();
                }

                DataTable dt = Common.ListToDataTable(Select_PhieuCHiTiet(MyConnection, IDPhieu.ToString()), "CT");
                ds.Tables.Add(dt);
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
