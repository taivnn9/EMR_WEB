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

    public class PhieuTheoDoiVaChamSocBNTN : ThongTinKy
    {
        public PhieuTheoDoiVaChamSocBNTN()
        {
            TableName = "PhieuTheoDoiVaChamSocBNTN";
            TablePrimaryKeyName = "IDPhieu";
            IDMauPhieu = (int)DanhMucPhieu.PTDCSBNTN;
            TenMauPhieu = DanhMucPhieu.PTDCSBNTN.Description();
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
        public List<PhieuTheoDoiVaChamSocBNTN_ChiTiet> TTCSChiTiet { get; set; }
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
        public PhieuTheoDoiVaChamSocBNTN Clone()
        {
            PhieuTheoDoiVaChamSocBNTN other = (PhieuTheoDoiVaChamSocBNTN)this.MemberwiseClone();
            other.TTCSChiTiet = new List<PhieuTheoDoiVaChamSocBNTN_ChiTiet>();
            if (this.TTCSChiTiet != null)
            foreach (PhieuTheoDoiVaChamSocBNTN_ChiTiet item in this.TTCSChiTiet)
            {
                other.TTCSChiTiet.Add(item.Clone());
            }
            return other;
        }
        // them vao
        public DateTime? TGTiepNhan { set; get; }
        public string DomMau { set; get; }
        public string TS { set; get; }
        public string TSDU { set; get; }
        public string OxTxt { set; get; }
        public string DauVT { set; get; }
        public string DauMucDo { set; get; }
        public string PhuVT { set; get; }
        public string PhuTC { set; get; }
        public string DHK { set; get; }
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
        public bool[] TuanHoan_Array { get; } = new bool[] { false, false, false };
        public string TuanHoan
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < TuanHoan_Array.Length; i++)
                    temp += (TuanHoan_Array[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        TuanHoan_Array[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public bool[] HATT_Array { get; } = new bool[] { false, false, false };
        public string HATT
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < HATT_Array.Length; i++)
                    temp += (HATT_Array[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        HATT_Array[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public bool[] HH_Array { get; } = new bool[] { false, false, false };
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
        public bool[] Ox_Array { get; } = new bool[] { false, false };
        public string Ox
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < Ox_Array.Length; i++)
                    temp += (Ox_Array[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        Ox_Array[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public bool[] TinhTrang_Array { get; } = new bool[] { false, false, false, false };
        public string TinhTrang
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < TinhTrang_Array.Length; i++)
                    temp += (TinhTrang_Array[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        TinhTrang_Array[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public bool[] DNM_Array { get; } = new bool[] { false, false, false };
        public string DNM
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < DNM_Array.Length; i++)
                    temp += (DNM_Array[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        DNM_Array[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public bool[] Dau_Array { get; } = new bool[] { false, false };
        public string Dau
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < Dau_Array.Length; i++)
                    temp += (Dau_Array[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        Dau_Array[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
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
        public bool[] An_Array { get; } = new bool[] { false, false };
        public string An
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < An_Array.Length; i++)
                    temp += (An_Array[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        An_Array[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public bool[] DD_Array { get; } = new bool[] { false, false, false };
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
        public bool[] BuonNon_Array { get; } = new bool[] { false, false, false, false };
        public string BuonNon
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < BuonNon_Array.Length; i++)
                    temp += (BuonNon_Array[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        BuonNon_Array[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public bool[] DaiTien_Array { get; } = new bool[] { false, false, false };
        public string DaiTien
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < DaiTien_Array.Length; i++)
                    temp += (DaiTien_Array[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        DaiTien_Array[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public bool[] TieuTien_Array { get; } = new bool[] { false, false, false };
        public string TieuTien
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < TieuTien_Array.Length; i++)
                    temp += (TieuTien_Array[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        TieuTien_Array[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
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
        public bool[] NoiQuy_Array { get; } = new bool[] { false };
        public string NoiQuy
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < NoiQuy_Array.Length; i++)
                    temp += (NoiQuy_Array[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        NoiQuy_Array[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public bool[] DoNhietDo_Array { get; } = new bool[] { false };
        public string DoNhietDo
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < DoNhietDo_Array.Length; i++)
                    temp += (DoNhietDo_Array[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        DoNhietDo_Array[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public bool[] BaoBS_Array { get; } = new bool[] { false };
        public string BaoBS
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < BaoBS_Array.Length; i++)
                    temp += (BaoBS_Array[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        BaoBS_Array[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public bool[] THYL_Array { get; } = new bool[] { false, false, false, false };
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
        public bool[] TheoDoi_Array { get; } = new bool[] { false };
        public string TheoDoi
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < TheoDoi_Array.Length; i++)
                    temp += (TheoDoi_Array[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        TheoDoi_Array[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
    }
    public class PhieuTheoDoiVaChamSocBNTN_ChiTiet: ThongTinKy
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
        public string NhanDinh { set; get; }
        public string ThucHien { set; get; }
        [MoTaDuLieu("Nước tiểu")]
		public string NuocTieu { set; get; }
        public string NGAYKY { set; get; }
        public string COMPUTERKYTEN { set; get; }
        //public string MASOKYTEN { set; get; }
        public string TENFILEKY { set; get; }
        public string USERNAMEKY { set; get; }
        public bool Daky { set; get; }
        [MoTaDuLieu("Chọn", null, 0, 0)]
		public bool Chon { get; set; }
        public PhieuTheoDoiVaChamSocBNTN_ChiTiet Clone()
        {
            PhieuTheoDoiVaChamSocBNTN_ChiTiet other = (PhieuTheoDoiVaChamSocBNTN_ChiTiet)this.MemberwiseClone(); 
            return other;
        }
    }
    public class PhieuTheoDoiVaChamSocBNTNFunc
    {
        static Logger log = LogManager.GetLogger("Log");
        public const string TableName = "PhieuTheoDoiVaChamSocBNTN";
        public const string TablePrimaryKeyName = "IDPhieu";

        public static List<ThuocPha> DanhSachThuocPha = new List<ThuocPha>();


        public List<PhieuTheoDoiVaChamSocBNTN> Select(MDB.MDBConnection MyConnection, string MaQuanLy)
        {
            try
            { 
                { 
                    List<PhieuTheoDoiVaChamSocBNTN> listResult = new List<PhieuTheoDoiVaChamSocBNTN>();
                    string sql = @"SELECT t.*
                    FROM PhieuTheoDoiVaChamSocBNTN t
                    WHERE t.MaQuanLy = :MaQuanLy";
                    sql = sql + " ORDER BY t.NgayTao DESC";
                    MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
                    Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", MaQuanLy));
                    MDB.MDBDataReader DataReader = Command.ExecuteReader();
                    while (DataReader.Read())
                    {
                        var obj = new PhieuTheoDoiVaChamSocBNTN();
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
                        obj.DomMau = Common.ConDBNull(DataReader["DomMau"]);
                        obj.TS = Common.ConDBNull(DataReader["TS"]);
                        obj.TSDU = Common.ConDBNull(DataReader["TSDU"]);
                        obj.OxTxt = Common.ConDBNull(DataReader["OxTxt"]);
                        obj.DauVT = Common.ConDBNull(DataReader["DauVT"]);
                        obj.DauMucDo = Common.ConDBNull(DataReader["DauMucDo"]);
                        obj.PhuVT = Common.ConDBNull(DataReader["PhuVT"]);
                        obj.PhuTC = Common.ConDBNull(DataReader["PhuTC"]);
                        obj.DHK = Common.ConDBNull(DataReader["DHK"]);
                        obj.YThuc = Common.ConDBNull(DataReader["YThuc"]);
                        obj.TuanHoan = Common.ConDBNull(DataReader["TuanHoan"]);
                        obj.HATT = Common.ConDBNull(DataReader["HATT"]);
                        obj.HH = Common.ConDBNull(DataReader["HH"]);
                        obj.Ox = Common.ConDBNull(DataReader["Ox"]);
                        obj.TinhTrang = Common.ConDBNull(DataReader["TinhTrang"]);
                        obj.DNM = Common.ConDBNull(DataReader["DNM"]);
                        obj.Dau = Common.ConDBNull(DataReader["Dau"]);
                        obj.Phu = Common.ConDBNull(DataReader["Phu"]);
                        obj.An = Common.ConDBNull(DataReader["An"]);
                        obj.DD = Common.ConDBNull(DataReader["DD"]);
                        obj.BuonNon = Common.ConDBNull(DataReader["BuonNon"]);
                        obj.DaiTien = Common.ConDBNull(DataReader["DaiTien"]);
                        obj.TieuTien = Common.ConDBNull(DataReader["TieuTien"]);
                        obj.VanDong = Common.ConDBNull(DataReader["VanDong"]);
                        obj.NoiQuy = Common.ConDBNull(DataReader["NoiQuy"]);
                        obj.DoNhietDo = Common.ConDBNull(DataReader["DoNhietDo"]);
                        obj.BaoBS = Common.ConDBNull(DataReader["BaoBS"]);
                        obj.THYL = Common.ConDBNull(DataReader["THYL"]);
                        obj.TheoDoi = Common.ConDBNull(DataReader["TheoDoi"]);
                        obj.NguoiTao = Common.ConDBNull(DataReader["NguoiTao"]);
                        obj.NgayTao = Common.ConDB_DateTime(DataReader["NgayTao"]);
                        obj.NguoiSua = Common.ConDBNull(DataReader["NguoiSua"]);
                        obj.NgaySua = Common.ConDB_DateTime(DataReader["NgaySua"]);
                        obj.TTCSChiTiet = new List<PhieuTheoDoiVaChamSocBNTN_ChiTiet>();
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
        public bool Insert(MDB.MDBConnection MyConnection, PhieuTheoDoiVaChamSocBNTN obj)
        {
            try
            { 
                { 
                    string sql = @"INSERT INTO PhieuTheoDoiVaChamSocBNTN (
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
                    TGTiepNhan,DomMau,
                    TS,
                    TSDU,
                    OxTxt,
                    DauVT,
                    DauMucDo,
                    PhuVT,
                    PhuTC,
                    DHK,
                    YThuc,
                    TuanHoan,
                    HATT,
                    HH,
                    Ox,
                    TinhTrang,
                    DNM,
                    Dau,
                    Phu,
                    An,
                    DD,
                    BuonNon,
                    DaiTien,
                    TieuTien,
                    VanDong,
                    NoiQuy,
                    DoNhietDo,
                    BaoBS,
                    THYL,
                    TheoDoi,
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
                    :TGTiepNhan,:DomMau,
                    :TS,
                    :TSDU,
                    :OxTxt,
                    :DauVT,
                    :DauMucDo,
                    :PhuVT,
                    :PhuTC,
                    :DHK,
                    :YThuc,
                    :TuanHoan,
                    :HATT,
                    :HH,
                    :Ox,
                    :TinhTrang,
                    :DNM,
                    :Dau,
                    :Phu,
                    :An,
                    :DD,
                    :BuonNon,
                    :DaiTien,
                    :TieuTien,
                    :VanDong,
                    :NoiQuy,
                    :DoNhietDo,
                    :BaoBS,
                    :THYL,
                    :TheoDoi,
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
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("DomMau", obj.DomMau));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("TS", obj.TS));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("TSDU", obj.TSDU));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("OxTxt", obj.OxTxt));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("DauVT", obj.DauVT));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("DauMucDo", obj.DauMucDo));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("PhuVT", obj.PhuVT));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("PhuTC", obj.PhuTC));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("DHK", obj.DHK));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("YThuc", obj.YThuc));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("TuanHoan", obj.TuanHoan));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("HATT", obj.HATT));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("HH", obj.HH));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("Ox", obj.Ox));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("TinhTrang", obj.TinhTrang));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("DNM", obj.DNM));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("Dau", obj.Dau));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("Phu", obj.Phu));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("An", obj.An));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("DD", obj.DD));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("BuonNon", obj.BuonNon));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("DaiTien", obj.DaiTien));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("TieuTien", obj.TieuTien));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("VanDong", obj.VanDong));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("NoiQuy", obj.NoiQuy));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("DoNhietDo", obj.DoNhietDo));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("BaoBS", obj.BaoBS));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("THYL", obj.THYL));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("TheoDoi", obj.TheoDoi));
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
        public bool Update(MDB.MDBConnection MyConnection, PhieuTheoDoiVaChamSocBNTN obj)
        {
            try
            {
                {

                    string sql = @"UPDATE PhieuTheoDoiVaChamSocBNTN SET 
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
                        TGTiepNhan=:TGTiepNhan,DomMau =:DomMau,
                        TS=:TS,
                        TSDU=:TSDU,
                        OxTxt=:OxTxt,
                        DauVT=:DauVT,
                        DauMucDo=:DauMucDo,
                        PhuVT=:PhuVT,
                        PhuTC=:PhuTC,
                        DHK=:DHK,
                        YThuc=:YThuc,
                        TuanHoan=:TuanHoan,
                        HATT=:HATT,
                        HH=:HH,
                        Ox=:Ox,
                        TinhTrang=:TinhTrang,
                        DNM=:DNM,
                        Dau=:Dau,
                        Phu=:Phu,
                        An=:An,
                        DD=:DD,
                        BuonNon=:BuonNon,
                        DaiTien=:DaiTien,
                        TieuTien=:TieuTien,
                        VanDong=:VanDong,
                        NoiQuy=:NoiQuy,
                        DoNhietDo=:DoNhietDo,
                        BaoBS=:BaoBS,
                        THYL=:THYL,
                        TheoDoi=:TheoDoi,
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
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("DomMau", obj.DomMau));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("TS", obj.TS));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("TSDU", obj.TSDU));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("OxTxt", obj.OxTxt));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("DauVT", obj.DauVT));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("DauMucDo", obj.DauMucDo));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("PhuVT", obj.PhuVT));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("PhuTC", obj.PhuTC));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("DHK", obj.DHK));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("YThuc", obj.YThuc));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("TuanHoan", obj.TuanHoan));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("HATT", obj.HATT));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("HH", obj.HH));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("Ox", obj.Ox));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("TinhTrang", obj.TinhTrang));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("DNM", obj.DNM));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("Dau", obj.Dau));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("Phu", obj.Phu));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("An", obj.An));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("DD", obj.DD));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("BuonNon", obj.BuonNon));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("DaiTien", obj.DaiTien));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("TieuTien", obj.TieuTien));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("VanDong", obj.VanDong));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("NoiQuy", obj.NoiQuy));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("DoNhietDo", obj.DoNhietDo));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("BaoBS", obj.BaoBS));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("THYL", obj.THYL));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("TheoDoi", obj.TheoDoi));
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
                    string sql = @"Delete PhieuTheoDoiVaChamSocBNTN 
                                WHERE 
                                (IDPhieu = :IDPhieu) ";
                    MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
                    Command.Parameters.Add(new MDB.MDBParameter(":IDPhieu", IDPhieu));
                    int n = Command.ExecuteNonQuery();
                    Command.Dispose();
                    sql = @"Delete PhieuTheoDoiVaChamSocBNTN_ChiTiet 
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
                    string sql = @"Delete PTDVCSBNTN_ChiTiet 
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
        public static List<PhieuTheoDoiVaChamSocBNTN_ChiTiet> Select_PhieuCHiTiet(MDB.MDBConnection MyConnection, string IDPhieu, int ModOrder = 0)
        {
            try
            {  
                {
                    List<PhieuTheoDoiVaChamSocBNTN_ChiTiet> listResult = new List<PhieuTheoDoiVaChamSocBNTN_ChiTiet>();
                    string sql = @"SELECT t.*
                    FROM PTDVCSBNTN_ChiTiet t
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
                        var obj = new PhieuTheoDoiVaChamSocBNTN_ChiTiet();
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
                        obj.NhanDinh = Common.ConDBNull(DataReader["NhanDinh"]);
                        obj.ThucHien = Common.ConDBNull(DataReader["ThucHien"]);
                        obj.NuocTieu = Common.ConDBNull(DataReader["NuocTieu"]);
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
        public bool InsertOrUpdate_ChiTiet(MDB.MDBConnection MyConnection, PhieuTheoDoiVaChamSocBNTN_ChiTiet obj)
        {
            try
            {
                string sql = @"update PTDVCSBNTN_ChiTiet set
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
                    NhanDinh=:NhanDinh,
                    ThucHien=:ThucHien,
                    NuocTieu=:NuocTieu
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
                oracleCommand.Parameters.Add(new MDB.MDBParameter("NhanDinh", obj.NhanDinh));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("ThucHien", obj.ThucHien));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("NuocTieu", obj.NuocTieu));

                int n = oracleCommand.ExecuteNonQuery();
                if (n == 0)
                {
                    oracleCommand.Dispose();
                    sql = @"insert into PTDVCSBNTN_ChiTiet (
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
                    NhanDinh,
                    ThucHien,
                    NuocTieu
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
                    :NhanDinh,
                    :ThucHien,
                    :NuocTieu
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
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("NhanDinh", obj.NhanDinh));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("ThucHien", obj.ThucHien));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("NuocTieu", obj.NuocTieu));
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
                    FROM PhieuTheoDoiVaChamSocBNTN P
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
