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

    public class PTDVCSNBC1_2 : ThongTinKy
    {
        public PTDVCSNBC1_2()
        {
            TableName = "PTDVCSNBC1_2";
            TablePrimaryKeyName = "ID";
            IDMauPhieu = (int)DanhMucPhieu.PTDVCSNBC1_2;
            TenMauPhieu = DanhMucPhieu.PTDVCSNBC1_2.Description();
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
        [MoTaDuLieu("Ghi chú")]
		public string GhiChu { set; get; }
        public DateTime? NgayChuyenCSC1 { set; get; }
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
        public List<PTDVCSNBC1_2_ChiTiet> TTCSChiTiet { get; set; }
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
        public PTDVCSNBC1_2 Clone()
        {
            PTDVCSNBC1_2 other = (PTDVCSNBC1_2)this.MemberwiseClone();
            other.TTCSChiTiet = new List<PTDVCSNBC1_2_ChiTiet>();
            if (this.TTCSChiTiet != null)
            foreach (PTDVCSNBC1_2_ChiTiet item in this.TTCSChiTiet)
            {
                other.TTCSChiTiet.Add(item.Clone());
            }
            return other;
        }
    }
    public class PTDVCSNBC1_2_ChiTiet: ThongTinKy
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
        [MoTaDuLieu("Cân nặng")]
		public string CanNang { set; get; }
        [MoTaDuLieu("Chiều cao")]
		public string ChieuCao { set; get; }
        public string DiemDau { set; get; }
        public string DHK { set; get; }
        public string VsTxt { set; get; }
        public string DD { set; get; }
        public string CSDG { set; get; }
        public bool[] TSDU_Array { get; } = new bool[] { false, false };
        public string TSDU {
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
        public bool[] YThuc_Array { get; } = new bool[] { false, false, false };
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
        public bool[] ToanTrang_Array { get; } = new bool[] { false, false };
        public string ToanTrang
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < ToanTrang_Array.Length; i++)
                    temp += (ToanTrang_Array[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        ToanTrang_Array[i] = intTemp == 1 ? true : false;
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
        public bool[] CoNang_Array { get; } = new bool[] { false, false, false, false };
        public string CoNang
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < CoNang_Array.Length; i++)
                    temp += (CoNang_Array[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        CoNang_Array[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public bool[] TonThuong_Array { get; } = new bool[] { false, false , false, false, false };
        public string TonThuong
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < TonThuong_Array.Length; i++)
                    temp += (TonThuong_Array[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        TonThuong_Array[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public bool[] NguyCo_Array { get; } = new bool[] { false, false };
        public string NguyCo
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < NguyCo_Array.Length; i++)
                    temp += (NguyCo_Array[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        NguyCo_Array[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public bool[] NoiQuy_Array { get; } = new bool[] { false, false };
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
        public bool[] Vs_Array { get; } = new bool[] { false };
        public string Vs
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < Vs_Array.Length; i++)
                    temp += (Vs_Array[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        Vs_Array[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public bool[] GDSK_Array { get; } = new bool[] { false, false };
        public string GDSK
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < GDSK_Array.Length; i++)
                    temp += (GDSK_Array[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        GDSK_Array[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public bool[] Thuoc_Array { get; } = new bool[] { false, false, false };
        public string Thuoc
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < Thuoc_Array.Length; i++)
                    temp += (Thuoc_Array[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        Thuoc_Array[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
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
        public bool[] ThayBang_Array { get; } = new bool[] { false, false };
        public string ThayBang
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < ThayBang_Array.Length; i++)
                    temp += (ThayBang_Array[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        ThayBang_Array[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        // them
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
        public bool[] ThanKinh_Array { get; } = new bool[] { false, false };
        public string ThanKinh
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < ThanKinh_Array.Length; i++)
                    temp += (ThanKinh_Array[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        ThanKinh_Array[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public bool[] DaiTien_Array { get; } = new bool[] { false, false };
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
        public string CLSKhac { set; get; }
        public string DG { set; get; }
        public string OxyMay { set; get; }
        public double? DVTruyen { set; get; }
        public double? DvAn { set; get; }
        public double? DVKhac { set; get; }
        public double? DRNTieu { set; get; }
        public double? DRDanLuu { set; get; }
        public double? DRPhan { set; get; }
        public double TongDichVao {
            get
            {
                double temp = 0;
                temp = Common.ConDB_double(DVTruyen) + Common.ConDB_double(DvAn) + Common.ConDB_double(DVKhac) ;
                return temp;
            }
        }
        public double TongDichRa
        {
            get
            {
                double temp = 0;
                temp =  Common.ConDB_double(DRNTieu) + Common.ConDB_double(DRDanLuu) + Common.ConDB_double(DRPhan);
                return temp;
            }
        }
        public string NGAYKY { set; get; }
        public string COMPUTERKYTEN { set; get; }
        //public string MASOKYTEN { set; get; }
        public string TENFILEKY { set; get; }
        public string USERNAMEKY { set; get; }
        public bool Daky { set; get; }
        [MoTaDuLieu("Chọn", null, 0, 0)]
		public bool Chon { get; set; }
        public bool isEnableTSDU { set; get; }
        public bool isEnableNoiQuy { set; get; }
        public PTDVCSNBC1_2_ChiTiet Clone()
        {
            PTDVCSNBC1_2_ChiTiet other = (PTDVCSNBC1_2_ChiTiet)this.MemberwiseClone(); 
            return other;
        }
    }
    public class PTDVCSNBC1_2Func
    {
        static Logger log = LogManager.GetLogger("Log");
        public const string TableName = "PTDVCSNBC1_2";
        public const string TablePrimaryKeyName = "IDPhieu";

        public static List<ThuocPha> DanhSachThuocPha = new List<ThuocPha>();


        public List<PTDVCSNBC1_2> Select(MDB.MDBConnection MyConnection, string MaQuanLy)
        {
            try
            { 
                { 
                    List<PTDVCSNBC1_2> listResult = new List<PTDVCSNBC1_2>();
                    string sql = @"SELECT t.*
                    FROM PTDVCSNBC1_2 t
                    WHERE t.MaQuanLy = :MaQuanLy";
                    sql = sql + " ORDER BY t.NgayTao DESC";
                    MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
                    Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", MaQuanLy));
                    MDB.MDBDataReader DataReader = Command.ExecuteReader();
                    while (DataReader.Read())
                    {
                        var obj = new PTDVCSNBC1_2();
                        obj.IDPhieu = Common.ConDB_Decimal(DataReader["IDPhieu"]);
                        obj.MaQuanLy = Common.ConDB_Decimal(DataReader["MaQuanLy"]);
                        obj.TenKhoa = Common.ConDBNull(DataReader["TenKhoa"]);
                        obj.MaKhoa = Common.ConDBNull(DataReader["MaKhoa"]);
                        obj.MaBenhNhan = Common.ConDBNull(DataReader["MaBenhNhan"]);
                        obj.SoPhieu = Common.ConDBNull(DataReader["SoPhieu"]);
                        obj.ChanDoan = Common.ConDBNull(DataReader["ChanDoan"]);
                        obj.GhiChu = Common.ConDBNull(DataReader["GhiChu"]);
                        obj.NgayChuyenCSC1 = Common.ConDB_DateTimeNull(DataReader["NgayChuyenCSC1"]);
                        obj.Buong = Common.ConDBNull(DataReader["Buong"]);
                        obj.Giuong = Common.ConDBNull(DataReader["Giuong"]);
                        obj.MaGiuong = Common.ConDBNull(DataReader["MaGiuong"]);
                        obj.NgayVaoVien = Common.ConDB_DateTimeNull(DataReader["NgayVaoVien"]);
                        obj.NguoiTao = Common.ConDBNull(DataReader["NguoiTao"]);
                        obj.NgayTao = Common.ConDB_DateTime(DataReader["NgayTao"]);
                        obj.NguoiSua = Common.ConDBNull(DataReader["NguoiSua"]);
                        obj.NgaySua = Common.ConDB_DateTime(DataReader["NgaySua"]);
                        obj.TTCSChiTiet = new List<PTDVCSNBC1_2_ChiTiet>();
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
        public bool Insert(MDB.MDBConnection MyConnection, PTDVCSNBC1_2 obj)
        {
            try
            { 
                { 
                    string sql = @"INSERT INTO PTDVCSNBC1_2 (
                    MaQuanLy,
                    TenKhoa,
                    MaKhoa,
                    MaBenhNhan,
                    SoPhieu,
                    ChanDoan,GhiChu,NgayChuyenCSC1,
                    Buong,
                    Giuong,
                    MaGiuong,
                    NgayVaoVien,
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
                    :ChanDoan,:GhiChu,:NgayChuyenCSC1,
                    :Buong,
                    :Giuong,
                    :MaGiuong,
                    :NgayVaoVien,
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
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("GhiChu", obj.GhiChu));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("NgayChuyenCSC1", obj.NgayChuyenCSC1));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("Buong", obj.Buong));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("Giuong", obj.Giuong));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("MaGiuong", obj.MaGiuong));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("NgayVaoVien", obj.NgayVaoVien));
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
        public bool Update(MDB.MDBConnection MyConnection, PTDVCSNBC1_2 obj)
        {
            try
            {
                {

                    string sql = @"UPDATE PTDVCSNBC1_2 SET 
                        MaQuanLy=:MaQuanLy,
                        TenKhoa=:TenKhoa,
                        MaKhoa=:MaKhoa,
                        MaBenhNhan=:MaBenhNhan,
                        SoPhieu=:SoPhieu,
                        ChanDoan=:ChanDoan,GhiChu=:GhiChu,NgayChuyenCSC1=:NgayChuyenCSC1,
                        Buong=:Buong,
                        Giuong=:Giuong,
                        MaGiuong=:MaGiuong,
                        NgayVaoVien=:NgayVaoVien,
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
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("GhiChu", obj.GhiChu));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("NgayChuyenCSC1", obj.NgayChuyenCSC1));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("Buong", obj.Buong));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("Giuong", obj.Giuong));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("MaGiuong", obj.MaGiuong));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("NgayVaoVien", obj.NgayVaoVien));
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
                    string sql = @"Delete PTDVCSNBC1_2 
                                WHERE 
                                (IDPhieu = :IDPhieu) ";
                    MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
                    Command.Parameters.Add(new MDB.MDBParameter(":IDPhieu", IDPhieu));
                    int n = Command.ExecuteNonQuery();
                    Command.Dispose();
                    sql = @"Delete PTDVCSNBC1_2_ChiTiet 
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
                    string sql = @"Delete PTDVCSNBC1_2_ChiTiet 
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
        public static List<PTDVCSNBC1_2_ChiTiet> Select_PhieuCHiTiet(MDB.MDBConnection MyConnection, string IDPhieu, int ModOrder = 0)
        {
            try
            {  
                {
                    List<PTDVCSNBC1_2_ChiTiet> listResult = new List<PTDVCSNBC1_2_ChiTiet>();
                    string sql = @"SELECT t.*
                    FROM PTDVCSNBC1_2_ChiTiet t
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
                        var obj = new PTDVCSNBC1_2_ChiTiet();
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
                        obj.CanNang = Common.ConDBNull(DataReader["CanNang"]);
                        obj.ChieuCao = Common.ConDBNull(DataReader["ChieuCao"]);
                        obj.DiemDau = Common.ConDBNull(DataReader["DiemDau"]);
                        obj.DHK = Common.ConDBNull(DataReader["DHK"]);
                        obj.VsTxt = Common.ConDBNull(DataReader["VsTxt"]);
                        obj.DD = Common.ConDBNull(DataReader["DD"]);
                        obj.CSDG = Common.ConDBNull(DataReader["CSDG"]);
                        obj.TSDU = Common.ConDBNull(DataReader["TSDU"]);
                        obj.YThuc = Common.ConDBNull(DataReader["YThuc"]);
                        obj.ToanTrang = Common.ConDBNull(DataReader["ToanTrang"]);
                        obj.DNM = Common.ConDBNull(DataReader["DNM"]);
                        obj.CoNang = Common.ConDBNull(DataReader["CoNang"]);
                        obj.TonThuong = Common.ConDBNull(DataReader["TonThuong"]);
                        obj.NguyCo = Common.ConDBNull(DataReader["NguyCo"]);
                        obj.NoiQuy = Common.ConDBNull(DataReader["NoiQuy"]);
                        obj.Vs = Common.ConDBNull(DataReader["Vs"]);
                        obj.GDSK = Common.ConDBNull(DataReader["GDSK"]);
                        obj.Thuoc = Common.ConDBNull(DataReader["Thuoc"]);
                        obj.XN = Common.ConDBNull(DataReader["XN"]);
                        obj.ThayBang = Common.ConDBNull(DataReader["ThayBang"]);
                        obj.HoHap = Common.ConDBNull(DataReader["HoHap"]);
                        obj.ThanKinh = Common.ConDBNull(DataReader["ThanKinh"]);
                        obj.DaiTien = Common.ConDBNull(DataReader["DaiTien"]);
                        obj.TieuTien = Common.ConDBNull(DataReader["TieuTien"]);
                        obj.CLSKhac = Common.ConDBNull(DataReader["CLSKhac"]);
                        obj.DG = Common.ConDBNull(DataReader["DG"]);
                        obj.OxyMay = Common.ConDBNull(DataReader["OxyMay"]);
                        obj.DVTruyen = Common.ConDBNull_double(DataReader["DVTruyen"]);
                        obj.DvAn = Common.ConDBNull_double(DataReader["DvAn"]);
                        obj.DVKhac = Common.ConDBNull_double(DataReader["DVKhac"]);
                        obj.DRNTieu = Common.ConDBNull_double(DataReader["DRNTieu"]);
                        obj.DRDanLuu = Common.ConDBNull_double(DataReader["DRDanLuu"]);
                        obj.DRPhan = Common.ConDBNull_double(DataReader["DRPhan"]);
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
        public bool InsertOrUpdate_ChiTiet(MDB.MDBConnection MyConnection, PTDVCSNBC1_2_ChiTiet obj)
        {
            try
            {
                string sql = @"update PTDVCSNBC1_2_ChiTiet set
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
                    CanNang=:CanNang,
                    ChieuCao=:ChieuCao,
                    DiemDau=:DiemDau,
                    DHK=:DHK,
                    VsTxt=:VsTxt,
                    DD=:DD,
                    CSDG=:CSDG,
                    TSDU=:TSDU,
                    YThuc=:YThuc,
                    ToanTrang=:ToanTrang,
                    DNM=:DNM,
                    CoNang=:CoNang,
                    TonThuong=:TonThuong,
                    NguyCo=:NguyCo,
                    NoiQuy=:NoiQuy,
                    Vs=:Vs,
                    GDSK=:GDSK,
                    Thuoc=:Thuoc,
                    XN=:XN,
                    ThayBang=:ThayBang, HoHap=:HoHap, ThanKinh=:ThanKinh, DaiTien=:DaiTien, 
                    TieuTien=:TieuTien,CLSKhac=:CLSKhac,DG=:DG,
                    OxyMay=:OxyMay,DVTruyen=:DVTruyen,DvAn=:DvAn,DVKhac=:DVKhac, 
                    DRNTieu=:DRNTieu, DRDanLuu=:DRDanLuu, DRPhan=:DRPhan
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
                oracleCommand.Parameters.Add(new MDB.MDBParameter("CanNang", obj.CanNang));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("ChieuCao", obj.ChieuCao));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("DiemDau", obj.DiemDau));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("DHK", obj.DHK));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("VsTxt", obj.VsTxt));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("DD", obj.DD));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("CSDG", obj.CSDG));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("TSDU", obj.TSDU));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("YThuc", obj.YThuc));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("ToanTrang", obj.ToanTrang));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("DNM", obj.DNM));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("CoNang", obj.CoNang));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("TonThuong", obj.TonThuong));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("NguyCo", obj.NguyCo));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("NoiQuy", obj.NoiQuy));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("Vs", obj.Vs));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("GDSK", obj.GDSK));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("Thuoc", obj.Thuoc));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("XN", obj.XN));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("ThayBang", obj.ThayBang));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("HoHap", obj.HoHap));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("ThanKinh", obj.ThanKinh));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("DaiTien", obj.DaiTien));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("TieuTien", obj.TieuTien));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("CLSKhac", obj.CLSKhac));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("DG", obj.DG));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("OxyMay", obj.OxyMay));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("DVTruyen", obj.DVTruyen));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("DvAn", obj.DvAn));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("DVKhac", obj.DVKhac));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("DRNTieu", obj.DRNTieu));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("DRDanLuu", obj.DRDanLuu));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("DRPhan", obj.DRPhan));

                int n = oracleCommand.ExecuteNonQuery();
                if (n == 0)
                {
                    oracleCommand.Dispose();
                    sql = @"insert into PTDVCSNBC1_2_ChiTiet (
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
                    CanNang,
                    ChieuCao,
                    DiemDau,
                    DHK,
                    VsTxt,
                    DD,
                    CSDG,
                    TSDU,
                    YThuc,
                    ToanTrang,
                    DNM,
                    CoNang,
                    TonThuong,
                    NguyCo,
                    NoiQuy,
                    Vs,
                    GDSK,
                    Thuoc,
                    XN,
                    ThayBang,HoHap,ThanKinh,DaiTien,TieuTien,CLSKhac,DG,OxyMay,DVTruyen,DvAn,DVKhac,DRNTieu,DRDanLuu,DRPhan
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
                    :CanNang,
                    :ChieuCao,
                    :DiemDau,
                    :DHK,
                    :VsTxt,
                    :DD,
                    :CSDG,
                    :TSDU,
                    :YThuc,
                    :ToanTrang,
                    :DNM,
                    :CoNang,
                    :TonThuong,
                    :NguyCo,
                    :NoiQuy,
                    :Vs,
                    :GDSK,
                    :Thuoc,
                    :XN,
                    :ThayBang,:HoHap,:ThanKinh,:DaiTien,:TieuTien,:CLSKhac,:DG,:OxyMay,:DVTruyen,:DvAn,:DVKhac,:DRNTieu,:DRDanLuu,:DRPhan
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
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("CanNang", obj.CanNang));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("ChieuCao", obj.ChieuCao));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("DiemDau", obj.DiemDau));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("DHK", obj.DHK));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("VsTxt", obj.VsTxt));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("DD", obj.DD));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("CSDG", obj.CSDG));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("TSDU", obj.TSDU));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("YThuc", obj.YThuc));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("ToanTrang", obj.ToanTrang));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("DNM", obj.DNM));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("CoNang", obj.CoNang));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("TonThuong", obj.TonThuong));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("NguyCo", obj.NguyCo));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("NoiQuy", obj.NoiQuy));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("Vs", obj.Vs));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("GDSK", obj.GDSK));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("Thuoc", obj.Thuoc));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("XN", obj.XN));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("ThayBang", obj.ThayBang));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("HoHap", obj.HoHap));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("ThanKinh", obj.ThanKinh));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("DaiTien", obj.DaiTien));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("TieuTien", obj.TieuTien));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("CLSKhac", obj.CLSKhac));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("DG", obj.DG));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("OxyMay", obj.OxyMay));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("DVTruyen", obj.DVTruyen));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("DvAn", obj.DvAn));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("DVKhac", obj.DVKhac));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("DRNTieu", obj.DRNTieu));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("DRDanLuu", obj.DRDanLuu));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("DRPhan", obj.DRPhan));
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
                    FROM PTDVCSNBC1_2 P
                ");
                sql.AppendLine(" WHERE P.IDPhieu = :IDPhieu ");
                MDB.MDBCommand Command = new MDB.MDBCommand(sql.ToString(), MyConnection);
                Command.Parameters.Add(new MDB.MDBParameter("IDPhieu", IDPhieu));
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
