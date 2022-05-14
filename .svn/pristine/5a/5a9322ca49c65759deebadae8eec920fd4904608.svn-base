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

    public class PTDVCSNBC23_3 : ThongTinKy
    {
        public PTDVCSNBC23_3()
        {
            TableName = "PTDVCSNBC23_3";
            TablePrimaryKeyName = "ID";
            IDMauPhieu = (int)DanhMucPhieu.PTDVCSNBC23_3;
            TenMauPhieu = DanhMucPhieu.PTDVCSNBC23_2.Description();
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
        public List<PTDVCSNBC23_3_ChiTiet> TTCSChiTiet { get; set; }
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
        public PTDVCSNBC23_3 Clone()
        {
            PTDVCSNBC23_3 other = (PTDVCSNBC23_3)this.MemberwiseClone();
            other.TTCSChiTiet = new List<PTDVCSNBC23_3_ChiTiet>();
            if (this.TTCSChiTiet != null)
            foreach (PTDVCSNBC23_3_ChiTiet item in this.TTCSChiTiet)
            {
                other.TTCSChiTiet.Add(item.Clone());
            }
            return other;
        }
    }
    public class PTDVCSNBC23_3_ChiTiet: ThongTinKy
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
        public bool[] YThuc_Array { get; } = new bool[] { false};
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
        public PTDVCSNBC23_3_ChiTiet Clone()
        {
            PTDVCSNBC23_3_ChiTiet other = (PTDVCSNBC23_3_ChiTiet)this.MemberwiseClone(); 
            return other;
        }
    }
    public class PTDVCSNBC23_3Func
    {
        static Logger log = LogManager.GetLogger("Log");
        public const string TableName = "PTDVCSNBC23_3";
        public const string TablePrimaryKeyName = "IDPhieu";

        public static List<ThuocPha> DanhSachThuocPha = new List<ThuocPha>();


        public List<PTDVCSNBC23_3> Select(MDB.MDBConnection MyConnection, string MaQuanLy)
        {
            try
            { 
                { 
                    List<PTDVCSNBC23_3> listResult = new List<PTDVCSNBC23_3>();
                    string sql = @"SELECT t.*
                    FROM PTDVCSNBC23_3 t
                    WHERE t.MaQuanLy = :MaQuanLy";
                    sql = sql + " ORDER BY t.NgayTao DESC";
                    MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
                    Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", MaQuanLy));
                    MDB.MDBDataReader DataReader = Command.ExecuteReader();
                    while (DataReader.Read())
                    {
                        var obj = new PTDVCSNBC23_3();
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
                        obj.NguoiTao = Common.ConDBNull(DataReader["NguoiTao"]);
                        obj.NgayTao = Common.ConDB_DateTime(DataReader["NgayTao"]);
                        obj.NguoiSua = Common.ConDBNull(DataReader["NguoiSua"]);
                        obj.NgaySua = Common.ConDB_DateTime(DataReader["NgaySua"]);
                        obj.TTCSChiTiet = new List<PTDVCSNBC23_3_ChiTiet>();
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
        public bool Insert(MDB.MDBConnection MyConnection, PTDVCSNBC23_3 obj)
        {
            try
            { 
                { 
                    string sql = @"INSERT INTO PTDVCSNBC23_3 (
                    MaQuanLy,
                    TenKhoa,
                    MaKhoa,
                    MaBenhNhan,
                    SoPhieu,
                    ChanDoan,
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
                    :ChanDoan,
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
        public bool Update(MDB.MDBConnection MyConnection, PTDVCSNBC23_3 obj)
        {
            try
            {
                {

                    string sql = @"UPDATE PTDVCSNBC23_3 SET 
                        MaQuanLy=:MaQuanLy,
                        TenKhoa=:TenKhoa,
                        MaKhoa=:MaKhoa,
                        MaBenhNhan=:MaBenhNhan,
                        SoPhieu=:SoPhieu,
                        ChanDoan=:ChanDoan,
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
                    string sql = @"Delete PTDVCSNBC23_3 
                                WHERE 
                                (IDPhieu = :IDPhieu) ";
                    MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
                    Command.Parameters.Add(new MDB.MDBParameter(":IDPhieu", IDPhieu));
                    int n = Command.ExecuteNonQuery();
                    Command.Dispose();
                    sql = @"Delete PTDVCSNBC23_3_ChiTiet 
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
                    string sql = @"Delete PTDVCSNBC23_3_ChiTiet 
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
        public static List<PTDVCSNBC23_3_ChiTiet> Select_PhieuCHiTiet(MDB.MDBConnection MyConnection, string IDPhieu, int ModOrder = 0)
        {
            try
            {  
                {
                    List<PTDVCSNBC23_3_ChiTiet> listResult = new List<PTDVCSNBC23_3_ChiTiet>();
                    string sql = @"SELECT t.*
                    FROM PTDVCSNBC23_3_ChiTiet t
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
                        var obj = new PTDVCSNBC23_3_ChiTiet();
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
        public bool InsertOrUpdate_ChiTiet(MDB.MDBConnection MyConnection, PTDVCSNBC23_3_ChiTiet obj)
        {
            try
            {
                string sql = @"update PTDVCSNBC23_3_ChiTiet set
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
                    ThayBang=:ThayBang
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

                int n = oracleCommand.ExecuteNonQuery();
                if (n == 0)
                {
                    oracleCommand.Dispose();
                    sql = @"insert into PTDVCSNBC23_3_ChiTiet (
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
                    ThayBang
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
                    :ThayBang
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
                        '' GioiTinh
                    FROM PTDVCSNBC23_3 P
                ");
                sql.AppendLine(" WHERE P.IDPhieu = :IDPhieu " );
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
