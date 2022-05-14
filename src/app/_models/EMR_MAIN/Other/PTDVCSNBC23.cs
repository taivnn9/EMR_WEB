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

    public class PTDVCSNBC23 : ThongTinKy
    {
        public PTDVCSNBC23()
        {
            TableName = "PTDVCSNBC23";
            TablePrimaryKeyName = "ID";
            IDMauPhieu = (int)DanhMucPhieu.PTDVCSNBC23;
            TenMauPhieu = DanhMucPhieu.PTDVCSNBC23.Description();
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
        public string TienSuDU { set; get; }
        public string TienSuBenh { set; get; }
        public double CanNang { set; get; }
        public double ChieuCao { set; get; }
        public double BMI { set; get; }
        public bool[] YThucArr { set; get; } = new bool[] { false, false, false };
        public string YThuc
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < YThucArr.Length; i++)
                    temp += (YThucArr[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        YThucArr[i] = intTemp == 1 ? true : false;
                    }
                }
            } 
        }
        public string Da { set; get; }
        public int DauDau { set; get; }
        public string Liet { set; get; }
        public bool[] HoArr { set; get; } = new bool[] { false, false, false, false };
        public string Ho
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < HoArr.Length; i++)
                    temp += (HoArr[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        HoArr[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public bool[] AnArr { set; get; } = new bool[] { false, false, false, false, false };
        public string An
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < AnArr.Length; i++)
                    temp += (AnArr[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        AnArr[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public bool[] DaiTienArr { set; get; } = new bool[] { false, false, false, false };
        public string DaiTien
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < DaiTienArr.Length; i++)
                    temp += (DaiTienArr[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        DaiTienArr[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public string SolanDaiTien { set; get; }
        public bool[] TieuTienArr { set; get; } = new bool[] { false, false, false, false };
        public string TieuTien
        {

            get
            {
                string temp = String.Empty;
                for (int i = 0; i < TieuTienArr.Length; i++)
                    temp += (TieuTienArr[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        TieuTienArr[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public string NTMauSac { set; get; }
        public string NTSoLuong { set; get; }
        public string Khac { set; get; }
        [MoTaDuLieu("Người tạo", null, 0, 0)]
		public string NguoiTao { set; get; }
        [MoTaDuLieu("Ngày tạo", null, 0, 0)]
		public DateTime NgayTao { set; get; }
        [MoTaDuLieu("Người sửa", null, 0, 0)]
		public string NguoiSua { set; get; }
        [MoTaDuLieu("Ngày sửa", null, 0, 0)]
		public DateTime NgaySua { set; get; }
        public List<PTDVCSNBC23_ChiTiet> TTCSChiTiet { get; set; }
        [MoTaDuLieu("Chọn", null, 0, 0)]
		public bool Chon { get; set; }
        public PTDVCSNBC23 Clone()
        {
            PTDVCSNBC23 other = (PTDVCSNBC23)this.MemberwiseClone();
            other.TTCSChiTiet = new List<PTDVCSNBC23_ChiTiet>();
            if (this.TTCSChiTiet != null)
            foreach (PTDVCSNBC23_ChiTiet item in this.TTCSChiTiet)
            {
                other.TTCSChiTiet.Add(item.Clone());
            }
            other.YThucArr = (bool[])this.YThucArr.Clone();
            other.HoArr = (bool[])this.HoArr.Clone(); 
            other.AnArr = (bool[])this.AnArr.Clone(); 
            other.DaiTienArr = (bool[])this.DaiTienArr.Clone();
            other.TieuTienArr = (bool[])this.TieuTienArr.Clone();
            return other;
        }
    }
    public class PTDVCSNBC23_ChiTiet: ThongTinKy
    {
        [MoTaDuLieu("Mã định danh")]
		public decimal IDPhieuCT { set; get; }
        [MoTaDuLieu("Mã định danh")]
		public decimal IDPhieu { set; get; }
        public DateTime ThoiGian { set; get; }
        [MoTaDuLieu("Người thực hiện")]
		public string NguoiThucHien { set; get; }
        public string MaNVNguoiThucHien { set; get; }
        public int? NT { set; get; }
        public int? M { set; get; }
        public float? T { set; get; }
        public float? HAMax { set; get; }
        public float? HAMin { set; get; }
        public string CheDoAn { set; get; }
        [MoTaDuLieu("Nước tiểu")]
		public string NuocTieu { set; get; }
        public string CanNangCT { set; get; }
        public string YThucCTKhac { set; get; }
        public bool[] YThucCTArr { set; get; } = new bool[] { false, false, false };
        public string YThucCT
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < YThucCTArr.Length; i++)
                    temp += (YThucCTArr[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        YThucCTArr[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public string DauhieuBatthuong { set; get; }
        public bool[] ThuocArr { set; get; } = new bool[] { false, false, false, false };
        public string Thuoc
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < ThuocArr.Length; i++)
                    temp += (ThuocArr[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        ThuocArr[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public string ThuocKhac { set; get; }
        public bool[] CDHAArr { set; get; } = new bool[] { false, false };
        public string CDHA
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < CDHAArr.Length; i++)
                    temp += (CDHAArr[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        CDHAArr[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public string CDHAKhac { set; get; }
        public string TDCNKhac { set; get; }
        public DateTime GiotruyenDich { set; get; }
        public DateTime GioKetThuc { set; get; }
        public int TDAT { set; get; }
        public string TDKhac { set; get; }
        public string CDAtxt { set; get; }
        public bool[] CDAArr { set; get; } = new bool[] { false, false, false, false, false };
        public string CDA
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < CDAArr.Length; i++)
                    temp += (CDAArr[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        CDAArr[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public string DT6h { set; get; }
        public string DT9h { set; get; }
        public string DT12h { set; get; }
        public string DT15h { set; get; }
        public string DT18h { set; get; }
        public string DT21h { set; get; }
        public string VeSinhCN { set; get; }
        public int TBNQ { set; get; }
        public string CSKhac { set; get; }    
        public string NGAYKY { set; get; }
        public string COMPUTERKYTEN { set; get; }
        //public string MASOKYTEN { set; get; }
        public string TENFILEKY { set; get; }
        public string USERNAMEKY { set; get; }
        public bool Daky { set; get; }
        [MoTaDuLieu("Chọn", null, 0, 0)]
		public bool Chon { get; set; }
        public PTDVCSNBC23_ChiTiet Clone()
        {
            PTDVCSNBC23_ChiTiet other = (PTDVCSNBC23_ChiTiet)this.MemberwiseClone(); 
            other.YThucCTArr = (bool[])this.YThucCTArr.Clone();
            other.ThuocArr = (bool[])this.ThuocArr.Clone();
            other.CDHAArr= (bool[]) this.CDHAArr.Clone(); 
            other.CDAArr= (bool[]) this.CDAArr.Clone(); 
            return other;
        }
    }
    public class PTDVCSNBC23Func
    {
        static Logger log = LogManager.GetLogger("Log");
        public const string TableName = "PTDVCSNBC23";
        public const string TablePrimaryKeyName = "IDPhieu";

        public static List<ThuocPha> DanhSachThuocPha = new List<ThuocPha>();


        public List<PTDVCSNBC23> Select(MDB.MDBConnection MyConnection, string MaQuanLy)
        {
            try
            { 
                { 
                    List<PTDVCSNBC23> listResult = new List<PTDVCSNBC23>();
                    string sql = @"SELECT t.*
                    FROM PTDVCSNBC23 t
                    WHERE t.MaQuanLy = :MaQuanLy";
                    sql = sql + " ORDER BY t.NgayTao DESC";
                    MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
                    Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", MaQuanLy));
                    MDB.MDBDataReader DataReader = Command.ExecuteReader();
                    while (DataReader.Read())
                    {
                        var obj = new PTDVCSNBC23();
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
                        obj.TienSuDU = Common.ConDBNull(DataReader["TienSuDU"]);
                        obj.TienSuBenh = Common.ConDBNull(DataReader["TienSuBenh"]);
                        obj.CanNang = Common.ConDB_float(DataReader["CanNang"]);
                        obj.ChieuCao = Common.ConDB_float(DataReader["ChieuCao"]);
                        obj.BMI = Common.ConDB_float(DataReader["BMI"]);
                        obj.YThuc = Common.ConDBNull(DataReader["YThuc"]);
                        obj.Da = Common.ConDBNull(DataReader["Da"]);
                        obj.DauDau = Common.ConDB_Int(DataReader["DauDau"]);
                        obj.Liet = Common.ConDBNull(DataReader["Liet"]);
                        obj.Ho = Common.ConDBNull(DataReader["Ho"]);
                        obj.An = Common.ConDBNull(DataReader["An"]);
                        obj.DaiTien = Common.ConDBNull(DataReader["DaiTien"]);
                        obj.SolanDaiTien = Common.ConDBNull(DataReader["SolanDaiTien"]);
                        obj.TieuTien = Common.ConDBNull(DataReader["TieuTien"]);
                        obj.NTMauSac = Common.ConDBNull(DataReader["NTMauSac"]);
                        obj.NTSoLuong = Common.ConDBNull(DataReader["NTSoLuong"]);
                        obj.Khac = Common.ConDBNull(DataReader["Khac"]);
                        obj.NguoiTao = Common.ConDBNull(DataReader["NguoiTao"]);
                        obj.NgayTao = Common.ConDB_DateTime(DataReader["NgayTao"]);
                        obj.NguoiSua = Common.ConDBNull(DataReader["NguoiSua"]);
                        obj.NgaySua = Common.ConDB_DateTime(DataReader["NgaySua"]);
                        obj.TTCSChiTiet = new List<PTDVCSNBC23_ChiTiet>();
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
        public bool Insert(MDB.MDBConnection MyConnection, PTDVCSNBC23 obj)
        {
            try
            { 
                { 
                    string sql = @"INSERT INTO PTDVCSNBC23 (
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
                    GioiTinh,
                    NgayVaoVien,
                    TienSuDU,
                    TienSuBenh,
                    CanNang,
                    ChieuCao,
                    BMI,
                    YThuc,
                    Da,
                    DauDau ,
                    Liet,
                    Ho,
                    An,
                    DaiTien,
                    SolanDaiTien,
                    TieuTien,
                    NTMauSac,
                    NTSoLuong,
                    Khac,
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
                    :GioiTinh,
                    :NgayVaoVien,
                    :TienSuDU,
                    :TienSuBenh,
                    :CanNang,
                    :ChieuCao,
                    :BMI,
                    :YThuc,
                    :Da,
                    :DauDau ,
                    :Liet,
                    :Ho,
                    :An,
                    :DaiTien,
                    :SolanDaiTien,
                    :TieuTien,
                    :NTMauSac,
                    :NTSoLuong,
                    :Khac,
                    :NguoiTao,
                    :NgayTao,
                    :NguoiSua,
                    :NgaySua
                    )";
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
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("TienSuDU", obj.TienSuDU));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("TienSuBenh", obj.TienSuBenh));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("CanNang", obj.CanNang));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("ChieuCao", obj.ChieuCao));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("BMI", obj.BMI));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("YThuc", obj.YThuc));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("Da", obj.Da));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("DauDau", obj.DauDau));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("Liet", obj.Liet));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("Ho", obj.Ho));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("An", obj.An));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("DaiTien", obj.DaiTien));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("SolanDaiTien", obj.SolanDaiTien));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("TieuTien", obj.TieuTien));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("NTMauSac", obj.NTMauSac));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("NTSoLuong", obj.NTSoLuong));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("Khac", obj.Khac));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("NguoiTao", obj.NguoiTao));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("NgayTao", DateTime.Now));
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
        public bool Update(MDB.MDBConnection MyConnection, PTDVCSNBC23 obj)
        {
            try
            {
                //using (MDB.MDBConnection MyConnection = new MDB.MDBConnection(ERMDatabase.ConnectionString))
                {

                    string sql = @"UPDATE PTDVCSNBC23 SET 
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
                        TienSuDU=:TienSuDU,
                        TienSuBenh=:TienSuBenh,
                        CanNang=:CanNang,
                        ChieuCao=:ChieuCao,
                        BMI=:BMI,
                        YThuc=:YThuc,
                        Da=:Da,
                        DauDau =:DauDau ,
                        Liet=:Liet,
                        Ho=:Ho,
                        An=:An,
                        DaiTien=:DaiTien,
                        SolanDaiTien=:SolanDaiTien,
                        TieuTien=:TieuTien,
                        NTMauSac=:NTMauSac,
                        NTSoLuong=:NTSoLuong,
                        Khac=:Khac,
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
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("TienSuDU", obj.TienSuDU));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("TienSuBenh", obj.TienSuBenh));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("CanNang", obj.CanNang));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("ChieuCao", obj.ChieuCao));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("BMI", obj.BMI));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("YThuc", obj.YThuc));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("Da", obj.Da));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("DauDau", obj.DauDau));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("Liet", obj.Liet));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("Ho", obj.Ho));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("An", obj.An));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("DaiTien", obj.DaiTien));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("SolanDaiTien", obj.SolanDaiTien));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("TieuTien", obj.TieuTien));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("NTMauSac", obj.NTMauSac));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("NTSoLuong", obj.NTSoLuong));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("Khac", obj.Khac));
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
        public bool Delete(MDB.MDBConnection MyConnection, decimal IDPhieu)
        {
            try
            {
                if (IDPhieu != 0)
                {
                    string sql = @"Delete PTDVCSNBC23 
                                WHERE 
                                (IDPhieu = :IDPhieu) ";
                    MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
                    Command.Parameters.Add(new MDB.MDBParameter(":IDPhieu", IDPhieu));
                    int n = Command.ExecuteNonQuery();
                    Command.Dispose();
                    sql = @"Delete PTDVCSNBC23_ChiTiet 
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
                    string sql = @"Delete PTDVCSNBC23_ChiTiet 
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
        public static List<PTDVCSNBC23_ChiTiet> Select_PhieuCHiTiet(MDB.MDBConnection MyConnection, string IDPhieu, int ModOrder = 0)
        {
            try
            {  
                {
                    List<PTDVCSNBC23_ChiTiet> listResult = new List<PTDVCSNBC23_ChiTiet>();
                    string sql = @"SELECT t.*
                    FROM PTDVCSNBC23_ChiTiet t
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
                        var obj = new PTDVCSNBC23_ChiTiet();
                        obj.IDPhieuCT = Common.ConDB_Decimal(DataReader["IDPhieuCT"]);
                        obj.IDPhieu = Common.ConDB_Decimal(DataReader["IDPhieu"]);
                        obj.ThoiGian = Common.ConDB_DateTime(DataReader["ThoiGian"]);
                        obj.NguoiThucHien = Common.ConDBNull(DataReader["NguoiThucHien"]);
                        obj.MaNVNguoiThucHien = Common.ConDBNull(DataReader["MaNVNguoiThucHien"]);
                        obj.NT = Common.ConDB_IntNull(DataReader["NT"]);
                        obj.M = Common.ConDB_IntNull(DataReader["M"]);
                        obj.T = Common.ConDBNull_float(DataReader["T"]);
                        obj.HAMax = Common.ConDBNull_float(DataReader["HAMax"]);
                        obj.HAMin = Common.ConDBNull_float(DataReader["HAMin"]);
                        obj.CheDoAn = Common.ConDBNull(DataReader["CheDoAn"]);
                        obj.NuocTieu = Common.ConDBNull(DataReader["NuocTieu"]);
                        obj.CanNangCT = Common.ConDBNull(DataReader["CanNangCT"]);
                        obj.YThucCTKhac = Common.ConDBNull(DataReader["YThucCTKhac"]);
                        obj.YThucCT = Common.ConDBNull(DataReader["YThucCT"]);
                        obj.DauhieuBatthuong = Common.ConDBNull(DataReader["DauhieuBatthuong"]);
                        obj.Thuoc = Common.ConDBNull(DataReader["Thuoc"]);
                        obj.ThuocKhac = Common.ConDBNull(DataReader["ThuocKhac"]);
                        obj.CDHA = Common.ConDBNull(DataReader["CDHA"]);
                        obj.CDHAKhac = Common.ConDBNull(DataReader["CDHAKhac"]);
                        obj.TDCNKhac = Common.ConDBNull(DataReader["TDCNKhac"]);
                        obj.GiotruyenDich = Common.ConDB_DateTime(DataReader["GiotruyenDich"]);
                        obj.GioKetThuc = Common.ConDB_DateTime(DataReader["GioKetThuc"]);
                        obj.TDAT = Common.ConDB_Int(DataReader["TDAT"]);
                        obj.TDKhac = Common.ConDBNull(DataReader["TDKhac"]);
                        obj.CDAtxt = Common.ConDBNull(DataReader["CDAtxt"]);
                        obj.CDA = Common.ConDBNull(DataReader["CDA"]);
                        obj.DT6h = Common.ConDBNull(DataReader["DT6h"]);
                        obj.DT9h = Common.ConDBNull(DataReader["DT9h"]);
                        obj.DT12h = Common.ConDBNull(DataReader["DT12h"]);
                        obj.DT15h = Common.ConDBNull(DataReader["DT15h"]);
                        obj.DT18h = Common.ConDBNull(DataReader["DT18h"]);
                        obj.DT21h = Common.ConDBNull(DataReader["DT21h"]);
                        obj.VeSinhCN = Common.ConDBNull(DataReader["VeSinhCN"]);
                        obj.TBNQ = Common.ConDB_Int(DataReader["TBNQ"]);
                        obj.CSKhac = Common.ConDBNull(DataReader["CSKhac"]);
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
        public bool InsertOrUpdate_ChiTiet(MDB.MDBConnection MyConnection, PTDVCSNBC23_ChiTiet obj)
        {
            try
            {
                string sql = @"update PTDVCSNBC23_ChiTiet set
                    IDPhieu=:IDPhieu,
                    ThoiGian=:ThoiGian,
                    NguoiThucHien=:NguoiThucHien,
                    MaNVNguoiThucHien=:MaNVNguoiThucHien,
                    NT=:NT,
                    M=:M,
                    T=:T,
                    HAMax=:HAMax,
                    HAMin=:HAMin,
                    CheDoAn=:CheDoAn,
                    NuocTieu=:NuocTieu,
                    CanNangCT=:CanNangCT,
                    YThucCTKhac=:YThucCTKhac,
                    YThucCT=:YThucCT,
                    DauhieuBatthuong=:DauhieuBatthuong,
                    Thuoc=:Thuoc,
                    ThuocKhac=:ThuocKhac,
                    CDHA=:CDHA,
                    CDHAKhac=:CDHAKhac,
                    TDCNKhac=:TDCNKhac,
                    GiotruyenDich=:GiotruyenDich,
                    GioKetThuc=:GioKetThuc,
                    TDAT=:TDAT,
                    TDKhac=:TDKhac,
                    CDAtxt=:CDAtxt,
                    CDA=:CDA,
                    DT6h=:DT6h,
                    DT9h=:DT9h,
                    DT12h=:DT12h,
                    DT15h=:DT15h,
                    DT18h=:DT18h,
                    DT21h=:DT21h,
                    VeSinhCN=:VeSinhCN,
                    TBNQ=:TBNQ,
                    CSKhac=:CSKhac
                    WHERE IDPhieuCT = " + obj.IDPhieuCT + "";

                MDB.MDBCommand oracleCommand = new MDB.MDBCommand(sql, MyConnection);
                oracleCommand.Parameters.Add(new MDB.MDBParameter("IDPhieu", obj.IDPhieu));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("ThoiGian", obj.ThoiGian));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("NguoiThucHien", obj.NguoiThucHien));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("MaNVNguoiThucHien", obj.MaNVNguoiThucHien));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("NT", obj.NT));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("M", obj.M));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("T", obj.T));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("HAMax", obj.HAMax));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("HAMin", obj.HAMin));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("CheDoAn", obj.CheDoAn));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("NuocTieu", obj.NuocTieu));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("CanNangCT", obj.CanNangCT));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("YThucCTKhac", obj.YThucCTKhac));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("YThucCT", obj.YThucCT));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("DauhieuBatthuong", obj.DauhieuBatthuong));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("Thuoc", obj.Thuoc));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("ThuocKhac", obj.ThuocKhac));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("CDHA", obj.CDHA));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("CDHAKhac", obj.CDHAKhac));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("TDCNKhac", obj.TDCNKhac));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("GiotruyenDich", obj.GiotruyenDich));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("GioKetThuc", obj.GioKetThuc));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("TDAT", obj.TDAT));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("TDKhac", obj.TDKhac));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("CDAtxt", obj.CDAtxt));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("CDA", obj.CDA));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("DT6h", obj.DT6h));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("DT9h", obj.DT9h));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("DT12h", obj.DT12h));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("DT15h", obj.DT15h));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("DT18h", obj.DT18h));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("DT21h", obj.DT21h));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("VeSinhCN", obj.VeSinhCN));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("TBNQ", obj.TBNQ));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("CSKhac", obj.CSKhac));

                int n = oracleCommand.ExecuteNonQuery();
                if (n == 0)
                {
                    oracleCommand.Dispose();
                    sql = @"insert into PTDVCSNBC23_ChiTiet (
                    IDPhieu,
                    ThoiGian,
                    NguoiThucHien,
                    MaNVNguoiThucHien,
                    NT,
                    M,
                    T,
                    HAMax,
                    HAMin,
                    CheDoAn,
                    NuocTieu,
                    CanNangCT,
                    YThucCTKhac,
                    YThucCT,
                    DauhieuBatthuong,
                    Thuoc,
                    ThuocKhac,
                    CDHA,
                    CDHAKhac,
                    TDCNKhac,
                    GiotruyenDich,
                    GioKetThuc,
                    TDAT,
                    TDKhac,
                    CDAtxt,
                    CDA,
                    DT6h,
                    DT9h,
                    DT12h,
                    DT15h,
                    DT18h,
                    DT21h,
                    VeSinhCN,
                    TBNQ,
                    CSKhac
                    ) values (
                    :IDPhieu,
                    :ThoiGian,
                    :NguoiThucHien,
                    :MaNVNguoiThucHien,
                    :NT,
                    :M,
                    :T,
                    :HAMax,
                    :HAMin,
                    :CheDoAn,
                    :NuocTieu,
                    :CanNangCT,
                    :YThucCTKhac,
                    :YThucCT,
                    :DauhieuBatthuong,
                    :Thuoc,
                    :ThuocKhac,
                    :CDHA,
                    :CDHAKhac,
                    :TDCNKhac,
                    :GiotruyenDich,
                    :GioKetThuc,
                    :TDAT,
                    :TDKhac,
                    :CDAtxt,
                    :CDA,
                    :DT6h,
                    :DT9h,
                    :DT12h,
                    :DT15h,
                    :DT18h,
                    :DT21h,
                    :VeSinhCN,
                    :TBNQ,
                    :CSKhac
                     ) RETURNING IDPhieuCT INTO :IDPhieuCT";
                    oracleCommand = new MDB.MDBCommand(sql, MyConnection);
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("IDPhieu", obj.IDPhieu));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("ThoiGian", obj.ThoiGian));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("NguoiThucHien", obj.NguoiThucHien));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("MaNVNguoiThucHien", obj.MaNVNguoiThucHien));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("NT", obj.NT));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("M", obj.M));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("T", obj.T));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("HAMax", obj.HAMax));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("HAMin", obj.HAMin));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("CheDoAn", obj.CheDoAn));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("NuocTieu", obj.NuocTieu));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("CanNangCT", obj.CanNangCT));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("YThucCTKhac", obj.YThucCTKhac));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("YThucCT", obj.YThucCT));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("DauhieuBatthuong", obj.DauhieuBatthuong));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("Thuoc", obj.Thuoc));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("ThuocKhac", obj.ThuocKhac));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("CDHA", obj.CDHA));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("CDHAKhac", obj.CDHAKhac));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("TDCNKhac", obj.TDCNKhac));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("GiotruyenDich", obj.GiotruyenDich));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("GioKetThuc", obj.GioKetThuc));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("TDAT", obj.TDAT));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("TDKhac", obj.TDKhac));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("CDAtxt", obj.CDAtxt));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("CDA", obj.CDA));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("DT6h", obj.DT6h));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("DT9h", obj.DT9h));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("DT12h", obj.DT12h));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("DT15h", obj.DT15h));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("DT18h", obj.DT18h));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("DT21h", obj.DT21h));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("VeSinhCN", obj.VeSinhCN));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("TBNQ", obj.TBNQ));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("CSKhac", obj.CSKhac));
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
                sql.AppendLine(@" from PTDVCSNBC23 a");
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
