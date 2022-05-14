using EMR.KyDienTu;
using EMR_MAIN.ViewModel;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Net.Http;
using System.Net.Http.Headers;
using PMS.Access;

namespace EMR_MAIN.DATABASE.Other
{
    public class PhauThuatMong : ThongTinKy
    {
        public PhauThuatMong()
        {
            TableName = "PHAUTHUATMONG";
            TablePrimaryKeyName = "ID";
            IDMauPhieu = (int)DanhMucPhieu.PTM;
            TenMauPhieu = DanhMucPhieu.PTM.Description();
        }
        public decimal IdPhauThuatMong { get; set; }
        [MoTaDuLieu("Mã quản lý: mã duy nhất trong 1 đợt khám chữa bệnh (kcb), không trùng giữa các đợt kcb khác nhau","",1)]
		public decimal MaQuanLy { get; set; }
        [MoTaDuLieu("Ngày vào bệnh viện")]
		public DateTime NgayVaoVien { get; set; }
        public DateTime NgayPhauThuat { get; set; }
        public DateTime? NgayPhauThuat_Gio { get; set; }
        [MoTaDuLieu("Chẩn đoán bệnh trước phẫu thuật")]
		public string ChanDoanTruocPhauThuat { get; set; }
        public bool[] CachThucPTArray { get; } = new bool[] { false, false };
        public int CachThucPT
        {
            get
            {
                return Array.IndexOf(CachThucPTArray, true);
            }
            set
            {
                for (int i = 0; i < 2; i++)
                {
                    if (i == value) CachThucPTArray[i] = true;
                    else CachThucPTArray[i] = false;
                }
            }
        }
        public string CachThucPT_Text { get; set; }
        public string PhauThuatVienChinh { get; set; }
        public string MaPhauThuatVienChinh { get; set; }
        public string PhauThuatVienPhu { get; set; }
        public string MaPhauThuatVienPhu { get; set; }
        public string BacSyGayMe { get; set; }
        public string MaBacSyGayMe { get; set; }
        public bool[] PhuongPhapVoCamArray { get; } = new bool[] { false, false };
        public int PhuongPhapVoCam
        {
            get
            {
                return Array.IndexOf(PhuongPhapVoCamArray, true);
            }
            set
            {
                for (int i = 0; i < 2; i++)
                {
                    if (i == value) PhuongPhapVoCamArray[i] = true;
                    else PhuongPhapVoCamArray[i] = false;
                }
            }
        }
        public string LoaiThuocGayTe { get; set; }
        public double DungTichGayMe { get; set; }
        public bool DatVanhMi { get; set; }
        public bool CatRoiDauMong { get; set; }
        public bool PhanTichThanMong { get; set; }
        public bool DotCamMau { get; set; }
        public string NongDoMMC { get; set; }
        public double ThoiGianMMC { get; set; }
        public bool[] RuaBeMatArray { get; } = new bool[] { false, false };
        public int RuaBeMat
        {
            get
            {
                return Array.IndexOf(RuaBeMatArray, true);
            }
            set
            {
                for (int i = 0; i < 2; i++)
                {
                    if (i == value) RuaBeMatArray[i] = true;
                    else RuaBeMatArray[i] = false;
                }
            }
        }
        public string RuaBeMatKhac { get; set; }
        [MoTaDuLieu("Số lượng")]
		public double SoLuong { get; set; }
        public bool GotDauMong { get; set; }
        public bool[] ViTriManhKMArray { get; } = new bool[] { false, false };
        public int ViTriManhKM
        {
            get
            {
                return Array.IndexOf(ViTriManhKMArray, true);
            }
            set
            {
                for (int i = 0; i < 2; i++)
                {
                    if (i == value) ViTriManhKMArray[i] = true;
                    else ViTriManhKMArray[i] = false;
                }
            }
        }
        public double KichThuocManhKM { get; set; }
        public bool LayManhMangOi { get; set; }
        public double KichThuocMangOi { get; set; }
        public string ChiManhGhep { get; set; }
        public int SoMuiManhGhep { get; set; }
        public bool KhauKMChePhanMong { get; set; }
        public int SoMuiKMChePhanMong { get; set; }
        public bool[] BienChungArray { get; } = new bool[] { false, false, false, false, false };
        public string BienChung
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < BienChungArray.Length; i++)
                    temp += (BienChungArray[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        BienChungArray[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public string CachXuTri { get; set; }
        public string DienBienKhac { get; set; }
        public bool[] TraKhangSinhArray { get; } = new bool[] { false, false };
        public int TraKhangSinh
        {
            get
            {
                return Array.IndexOf(TraKhangSinhArray, true);
            }
            set
            {
                for (int i = 0; i < 2; i++)
                {
                    if (i == value) TraKhangSinhArray[i] = true;
                    else TraKhangSinhArray[i] = false;
                }
            }
        }
        public string LoaiThuoc { get; set; }
        public bool BangEp { get; set; }
        public DateTime NgayLapPhieu { get; set; }
        public string PhauThuatVien { get; set; }
        public string MaPhauThuatVien { get; set; }
        public string LuocDoPhauThuat { get; set; }
        [MoTaDuLieu("Ngày tạo", null, 0, 0)]
		public DateTime NgayTao { get; set; }
        [MoTaDuLieu("Người tạo", null, 0, 0)]
		public string NguoiTao { get; set; }
        [MoTaDuLieu("Ngày sửa", null, 0, 0)]
		public DateTime NgaySua { get; set; }
        [MoTaDuLieu("Người sửa", null, 0, 0)]
		public string NguoiSua { get; set; }
        public string HinhAnhMoTa { get; set; }
    }
    public class PhauThuatMongFunc
    {
        public static List<PhauThuatMong> GetListData(MDB.MDBConnection _OracleConnection, decimal maquanly)
        {
            List<PhauThuatMong> list = new List<PhauThuatMong>();
            try
            {
                string sql = @"SELECT * FROM PhauThuatMong where MaQuanLy = :MaQuanLy";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, _OracleConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", maquanly));
                MDB.MDBDataReader DataReader = Command.ExecuteReader();
                while (DataReader.Read())
                {
                    PhauThuatMong data = new PhauThuatMong();
                    data.IdPhauThuatMong = Convert.ToInt64(DataReader.GetLong("IdPhauThuatMong").ToString());
                    data.MaQuanLy = maquanly;
                    data.NgayVaoVien = Convert.ToDateTime(DataReader["NgayVaoVien"] == DBNull.Value ? DateTime.Now : DataReader["NgayVaoVien"]);
                    data.NgayPhauThuat = Convert.ToDateTime(DataReader["NgayPhauThuat"] == DBNull.Value ? DateTime.Now : DataReader["NgayPhauThuat"]);
                    data.ChanDoanTruocPhauThuat = DataReader["ChanDoanTruocPhauThuat"].ToString();
                    int tempInt = -1;
                    int.TryParse(DataReader["CachThucPT"].ToString(), out tempInt);
                    data.CachThucPT = tempInt;
                    data.CachThucPT_Text = DataReader["CachThucPT_Text"].ToString();
                    data.PhauThuatVienChinh = DataReader["PhauThuatVienChinh"].ToString();
                    data.MaPhauThuatVienChinh = DataReader["MaPhauThuatVienChinh"].ToString();
                    data.PhauThuatVienPhu = DataReader["PhauThuatVienPhu"].ToString();
                    data.MaPhauThuatVienPhu = DataReader["MaPhauThuatVienPhu"].ToString();
                    data.BacSyGayMe = DataReader["BacSyGayMe"].ToString();
                    data.MaBacSyGayMe = DataReader["MaBacSyGayMe"].ToString();

                    tempInt = -1;
                    int.TryParse(DataReader["PhuongPhapVoCam"].ToString(), out tempInt);
                    data.PhuongPhapVoCam = tempInt;
                    data.LoaiThuocGayTe = DataReader["LoaiThuocGayTe"].ToString();

                    double doubleTemp = 0;
                    double.TryParse(DataReader["ThoiGianMMC"].ToString(), out doubleTemp);
                    data.ThoiGianMMC = doubleTemp;

                    data.DatVanhMi = DataReader["DatVanhMi"].ToString().Equals("1") ? true:false;
                    data.CatRoiDauMong = DataReader["CatRoiDauMong"].ToString().Equals("1") ? true : false;
                    data.PhanTichThanMong = DataReader["PhanTichThanMong"].ToString().Equals("1") ? true : false;
                    data.DotCamMau = DataReader["DotCamMau"].ToString().Equals("1") ? true : false;
                    
                    data.NongDoMMC = DataReader["NongDoMMC"].ToString();
                   
                    doubleTemp = 0;
                    double.TryParse(DataReader["DungTichGayMe"].ToString(), out doubleTemp);
                    data.DungTichGayMe = doubleTemp;

                    tempInt = -1;
                    int.TryParse(DataReader["RuaBeMat"].ToString(), out tempInt);
                    data.RuaBeMat = tempInt;
                    data.RuaBeMatKhac = DataReader["RuaBeMatKhac"].ToString();

                    doubleTemp = 0;
                    double.TryParse(DataReader["SoLuong"].ToString(), out doubleTemp);
                    data.SoLuong = doubleTemp;

                    data.GotDauMong = DataReader["GotDauMong"].ToString().Equals("1") ? true : false;
                    tempInt = -1;
                    int.TryParse(DataReader["ViTriManhKM"].ToString(), out tempInt);
                    data.ViTriManhKM = tempInt;

                    doubleTemp = 0;
                    double.TryParse(DataReader["KichThuocManhKM"].ToString(), out doubleTemp);
                    data.KichThuocManhKM = doubleTemp;
                    
                    data.LayManhMangOi = DataReader["LayManhMangOi"].ToString().Equals("1") ? true : false;
                    doubleTemp = 0;
                    double.TryParse(DataReader["KichThuocMangOi"].ToString(), out doubleTemp);
                    data.KichThuocMangOi = doubleTemp;

                    data.ChiManhGhep = DataReader["ChiManhGhep"].ToString();
                    tempInt = -1;
                    int.TryParse(DataReader["SoMuiManhGhep"].ToString(), out tempInt);
                    data.SoMuiManhGhep = tempInt;

                    data.KhauKMChePhanMong = DataReader["KhauKMChePhanMong"].ToString().Equals("1") ? true : false;

                    tempInt = 0;
                    int.TryParse(DataReader["SoMuiKMChePhanMong"].ToString(), out tempInt);
                    data.SoMuiKMChePhanMong = tempInt;

                    data.BienChung = DataReader["BienChung"].ToString();
                    data.CachXuTri = DataReader["CachXuTri"].ToString();
                    data.DienBienKhac = DataReader["DienBienKhac"].ToString();

                    tempInt = -1;
                    int.TryParse(DataReader["TraKhangSinh"].ToString(), out tempInt);
                    data.TraKhangSinh = tempInt;

                    data.LoaiThuoc = DataReader["LoaiThuoc"].ToString();
                    data.LuocDoPhauThuat = DataReader["LuocDoPhauThuat"].ToString();

                    data.BangEp = DataReader["BangEp"].ToString().Equals("1") ? true : false;
                    data.NgayLapPhieu = Convert.ToDateTime(DataReader["NgayLapPhieu"] == DBNull.Value ? DateTime.Now : DataReader["NgayLapPhieu"]);
                    data.PhauThuatVien = DataReader["PhauThuatVien"].ToString();
                    data.MaPhauThuatVien = DataReader["MaPhauThuatVien"].ToString();

                    data.NgayTao = Convert.ToDateTime(DataReader["NgayTao"] == DBNull.Value ? DateTime.Now : DataReader["NgayTao"]);
                    data.NguoiTao = DataReader["NguoiTao"].ToString();
                    data.NgaySua = Convert.ToDateTime(DataReader["NgaySua"] == DBNull.Value ? DateTime.Now : DataReader["NgaySua"]);
                    data.NguoiSua = DataReader["NguoiSua"].ToString();
                    list.Add(data);
                }
            }
            catch (Exception ex) { XuLyLoi.Handle(ex); }
            return list;
        }
        public static bool InsertOrUpdate(MDB.MDBConnection MyConnection, ref PhauThuatMong phauThuatMong)
        {
            try
            {
                string sql = @"INSERT INTO PHAUTHUATMONG
                (
                    MAQUANLY,
                    NgayVaoVien,
                    NgayPhauThuat,
                    ChanDoanTruocPhauThuat,
                    CachThucPT,
                    CachThucPT_Text,
                    PhauThuatVienChinh,
                    MaPhauThuatVienChinh,
                    PhauThuatVienPhu,
                    MaPhauThuatVienPhu,
                    BacSyGayMe,
                    MaBacSyGayMe,
                    PhuongPhapVoCam,
                    LoaiThuocGayTe,
                    DungTichGayMe,
                    DatVanhMi,
                    CatRoiDauMong,
                    PhanTichThanMong,
                    DotCamMau,
                    NongDoMMC,
                    ThoiGianMMC,
                    RuaBeMat,
                    RuaBeMatKhac,
                    SoLuong,
                    GotDauMong,
                    ViTriManhKM,
                    KichThuocManhKM,
                    LayManhMangOi,
                    KichThuocMangOi,
                    ChiManhGhep,
                    SoMuiManhGhep,
                    KhauKMChePhanMong,
                    SoMuiKMChePhanMong,
                    BienChung,
                    CachXuTri,
                    DienBienKhac,
                    TraKhangSinh,
                    LoaiThuoc,
                    BangEp,
                    NgayLapPhieu,
                    PhauThuatVien,
                    MaPhauThuatVien,
                    LuocDoPhauThuat,
                    NGUOITAO,
                    NGUOISUA,
                    NGAYTAO,
                    NGAYSUA)  VALUES
                 (
				    :MAQUANLY,
                    :NgayVaoVien,
                    :NgayPhauThuat,
                    :ChanDoanTruocPhauThuat,
                    :CachThucPT,
                    :CachThucPT_Text,
                    :PhauThuatVienChinh,
                    :MaPhauThuatVienChinh,
                    :PhauThuatVienPhu,
                    :MaPhauThuatVienPhu,
                    :BacSyGayMe,
                    :MaBacSyGayMe,
                    :PhuongPhapVoCam,
                    :LoaiThuocGayTe,
                    :DungTichGayMe,
                    :DatVanhMi,
                    :CatRoiDauMong,
                    :PhanTichThanMong,
                    :DotCamMau,
                    :NongDoMMC,
                    :ThoiGianMMC,
                    :RuaBeMat,
                    :RuaBeMatKhac,
                    :SoLuong,
                    :GotDauMong,
                    :ViTriManhKM,
                    :KichThuocManhKM,
                    :LayManhMangOi,
                    :KichThuocMangOi,
                    :ChiManhGhep,
                    :SoMuiManhGhep,
                    :KhauKMChePhanMong,
                    :SoMuiKMChePhanMong,
                    :BienChung,
                    :CachXuTri,
                    :DienBienKhac,
                    :TraKhangSinh,
                    :LoaiThuoc,
                    :BangEp,
                    :NgayLapPhieu,
                    :PhauThuatVien,
                    :MaPhauThuatVien,
                    :LuocDoPhauThuat,
                    :NGUOITAO,
                    :NGUOISUA,
                    :NGAYTAO,
                    :NGAYSUA
                 )  RETURNING IdPhauThuatMong INTO :IdPhauThuatMong";
                if (phauThuatMong.IdPhauThuatMong != Decimal.Zero)
                {
                    sql = @"UPDATE PHAUTHUATMONG SET 
                    MAQUANLY = :MAQUANLY,
                    NgayVaoVien = :NgayVaoVien,
                    NgayPhauThuat = :NgayPhauThuat,
                    ChanDoanTruocPhauThuat = :ChanDoanTruocPhauThuat,
                    CachThucPT = :CachThucPT,
                    CachThucPT_Text = :CachThucPT_Text,
                    PhauThuatVienChinh = :PhauThuatVienChinh,
                    MaPhauThuatVienChinh = :MaPhauThuatVienChinh,
                    PhauThuatVienPhu = :PhauThuatVienPhu,
                    MaPhauThuatVienPhu = :MaPhauThuatVienPhu,
                    BacSyGayMe = :BacSyGayMe,
                    MaBacSyGayMe = :MaBacSyGayMe,
                    PhuongPhapVoCam = :PhuongPhapVoCam,
                    LoaiThuocGayTe = :LoaiThuocGayTe,
                    DungTichGayMe = :DungTichGayMe,
                    DatVanhMi = :DatVanhMi,
                    CatRoiDauMong = :CatRoiDauMong,
                    PhanTichThanMong = :PhanTichThanMong,
                    DotCamMau = :DotCamMau,
                    NongDoMMC = :NongDoMMC,
                    ThoiGianMMC = :ThoiGianMMC,
                    RuaBeMat = :RuaBeMat,
                    RuaBeMatKhac = :RuaBeMatKhac,
                    SoLuong = :SoLuong,
					GotDauMong =  :GotDauMong,
                    ViTriManhKM = :ViTriManhKM,
                    KichThuocManhKM = :KichThuocManhKM,
                    LayManhMangOi = :LayManhMangOi,
                    KichThuocMangOi = :KichThuocMangOi,
                    ChiManhGhep = :ChiManhGhep,
                    SoMuiManhGhep = :SoMuiManhGhep,
                    KhauKMChePhanMong = :KhauKMChePhanMong,
                    SoMuiKMChePhanMong = :SoMuiKMChePhanMong,
                    BienChung = :BienChung,
                    CachXuTri = :CachXuTri,
                    DienBienKhac = :DienBienKhac,
                    TraKhangSinh = :TraKhangSinh,
                    LoaiThuoc = :LoaiThuoc,
                    BangEp = :BangEp,
                    NgayLapPhieu = :NgayLapPhieu,
                    PhauThuatVien = :PhauThuatVien,
                    MaPhauThuatVien = :MaPhauThuatVien,
                    LuocDoPhauThuat = :LuocDoPhauThuat,
                    NGUOISUA = :NGUOISUA,
                    NGAYSUA = :NGAYSUA 
                    WHERE IdPhauThuatMong = " + phauThuatMong.IdPhauThuatMong;
                }
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MAQUANLY", phauThuatMong.MaQuanLy));
                Command.Parameters.Add(new MDB.MDBParameter("NgayVaoVien", phauThuatMong.NgayVaoVien));
                var Ngay = phauThuatMong.NgayPhauThuat.Date.Add(new TimeSpan(0, 0, 0));
                var Gio = phauThuatMong.NgayPhauThuat_Gio != null ? phauThuatMong.NgayPhauThuat_Gio.Value.TimeOfDay : DateTime.Now.TimeOfDay;
                var ngayPhauThuat = Ngay + Gio;
                Command.Parameters.Add(new MDB.MDBParameter("NgayPhauThuat", ngayPhauThuat));
                Command.Parameters.Add(new MDB.MDBParameter("ChanDoanTruocPhauThuat", phauThuatMong.ChanDoanTruocPhauThuat));
                Command.Parameters.Add(new MDB.MDBParameter("CachThucPT", phauThuatMong.CachThucPT));
                Command.Parameters.Add(new MDB.MDBParameter("CachThucPT_Text", phauThuatMong.CachThucPT_Text));
                Command.Parameters.Add(new MDB.MDBParameter("PhauThuatVienChinh", phauThuatMong.PhauThuatVienChinh));
                Command.Parameters.Add(new MDB.MDBParameter("MaPhauThuatVienChinh", phauThuatMong.MaPhauThuatVienChinh));
                Command.Parameters.Add(new MDB.MDBParameter("PhauThuatVienPhu", phauThuatMong.PhauThuatVienPhu));
                Command.Parameters.Add(new MDB.MDBParameter("MaPhauThuatVienPhu", phauThuatMong.MaPhauThuatVienPhu));
                Command.Parameters.Add(new MDB.MDBParameter("BacSyGayMe", phauThuatMong.BacSyGayMe));
                Command.Parameters.Add(new MDB.MDBParameter("MaBacSyGayMe", phauThuatMong.MaBacSyGayMe));
                Command.Parameters.Add(new MDB.MDBParameter("PhuongPhapVoCam", phauThuatMong.PhuongPhapVoCam));
                Command.Parameters.Add(new MDB.MDBParameter("LoaiThuocGayTe", phauThuatMong.LoaiThuocGayTe));
                Command.Parameters.Add(new MDB.MDBParameter("DungTichGayMe", phauThuatMong.DungTichGayMe)); 
                Command.Parameters.Add(new MDB.MDBParameter("DatVanhMi", phauThuatMong.DatVanhMi ? 1 : 0));
                Command.Parameters.Add(new MDB.MDBParameter("CatRoiDauMong", phauThuatMong.CatRoiDauMong ? 1 : 0));
                Command.Parameters.Add(new MDB.MDBParameter("PhanTichThanMong", phauThuatMong.PhanTichThanMong ? 1 : 0));
                Command.Parameters.Add(new MDB.MDBParameter("DotCamMau", phauThuatMong.DotCamMau ? 1 : 0));
                Command.Parameters.Add(new MDB.MDBParameter("NongDoMMC", phauThuatMong.NongDoMMC));
                Command.Parameters.Add(new MDB.MDBParameter("ThoiGianMMC", phauThuatMong.ThoiGianMMC));
                Command.Parameters.Add(new MDB.MDBParameter("RuaBeMat", phauThuatMong.RuaBeMat));
                Command.Parameters.Add(new MDB.MDBParameter("RuaBeMatKhac", phauThuatMong.RuaBeMatKhac));
                Command.Parameters.Add(new MDB.MDBParameter("SoLuong", phauThuatMong.SoLuong));
                Command.Parameters.Add(new MDB.MDBParameter("GotDauMong", phauThuatMong.GotDauMong ? 1 : 0));
                Command.Parameters.Add(new MDB.MDBParameter("ViTriManhKM", phauThuatMong.ViTriManhKM));
                Command.Parameters.Add(new MDB.MDBParameter("KichThuocManhKM", phauThuatMong.KichThuocManhKM));
                Command.Parameters.Add(new MDB.MDBParameter("LayManhMangOi", phauThuatMong.LayManhMangOi ? 1 : 0));
                Command.Parameters.Add(new MDB.MDBParameter("KichThuocMangOi", phauThuatMong.KichThuocMangOi));
                Command.Parameters.Add(new MDB.MDBParameter("ChiManhGhep", phauThuatMong.ChiManhGhep));
                Command.Parameters.Add(new MDB.MDBParameter("SoMuiManhGhep", phauThuatMong.SoMuiManhGhep));
                Command.Parameters.Add(new MDB.MDBParameter("KhauKMChePhanMong", phauThuatMong.KhauKMChePhanMong ? 1 : 0));
                Command.Parameters.Add(new MDB.MDBParameter("SoMuiKMChePhanMong", phauThuatMong.SoMuiKMChePhanMong));
                Command.Parameters.Add(new MDB.MDBParameter("BienChung", phauThuatMong.BienChung));
                Command.Parameters.Add(new MDB.MDBParameter("CachXuTri", phauThuatMong.CachXuTri));
                Command.Parameters.Add(new MDB.MDBParameter("DienBienKhac", phauThuatMong.DienBienKhac));
                Command.Parameters.Add(new MDB.MDBParameter("TraKhangSinh", phauThuatMong.TraKhangSinh));
                Command.Parameters.Add(new MDB.MDBParameter("LoaiThuoc", phauThuatMong.LoaiThuoc));
                Command.Parameters.Add(new MDB.MDBParameter("BangEp", phauThuatMong.BangEp ? 1 : 0));
                Command.Parameters.Add(new MDB.MDBParameter("NgayLapPhieu", phauThuatMong.NgayLapPhieu));
                Command.Parameters.Add(new MDB.MDBParameter("PhauThuatVien", phauThuatMong.PhauThuatVien));
                Command.Parameters.Add(new MDB.MDBParameter("MaPhauThuatVien", phauThuatMong.MaPhauThuatVien));
                Command.Parameters.Add(new MDB.MDBParameter("LuocDoPhauThuat", phauThuatMong.LuocDoPhauThuat));
                Command.Parameters.Add(new MDB.MDBParameter("NGUOISUA", phauThuatMong.NguoiSua));
                Command.Parameters.Add(new MDB.MDBParameter("NGAYSUA", phauThuatMong.NgaySua));
                if (phauThuatMong.IdPhauThuatMong.Equals(Decimal.Zero))
                {
                    Command.Parameters.Add(new MDB.MDBParameter("IdPhauThuatMong", phauThuatMong.IdPhauThuatMong));
                    Command.Parameters.Add(new MDB.MDBParameter("NGUOITAO", phauThuatMong.NguoiTao));
                    Command.Parameters.Add(new MDB.MDBParameter("NGAYTAO", phauThuatMong.NgayTao));
                }
                Command.BindByName = true;
                int n = Command.ExecuteNonQuery();
                if (phauThuatMong.IdPhauThuatMong.Equals(Decimal.Zero))
                {
                    decimal nextval = Convert.ToInt64((Command.Parameters["IdPhauThuatMong"] as MDB.MDBParameter).Value);
                    phauThuatMong.IdPhauThuatMong = nextval;
                }
                return n > 0 ? true : false;
            }
            catch (Exception ex)
            {
                XuLyLoi.Handle(ex);
            }
            return false;
        }
        public static bool delete(MDB.MDBConnection MyConnection, decimal idPhauThuatMong)
        {
            try
            {
                string sql = "DELETE FROM PHAUTHUATMONG WHERE IdPhauThuatMong = :IdPhauThuatMong";
                MDB.MDBCommand command = new MDB.MDBCommand(sql, MyConnection);
                command.Parameters.Add(new MDB.MDBParameter("IdPhauThuatMong", idPhauThuatMong));
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
        public static DataSet getDataSet(MDB.MDBConnection MyConnection, decimal IdPhauThuatMong)
        {
            string sql = @"SELECT
                P.*,
	            T.NGAYVAOVIEN,
                T.MABENHAN,
	            H.TENBENHNHAN,
                H.TUOI,
                H.NGAYSINH,
	            H.GIOITINH
            FROM
                PHAUTHUATMONG P
                JOIN THONGTINDIEUTRI T ON P.MAQUANLY = T.MAQUANLY
                JOIN HANHCHINHBENHNHAN H ON T.MABENHNHAN = H.MABENHNHAN
            WHERE
                IdPhauThuatMong = " + IdPhauThuatMong;

            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);

            MDB.MDBDataAdapter adt = new MDB.MDBDataAdapter(Command);
            var ds = new DataSet();

            adt.Fill(ds, "PT");

            DataTable thongTinVien = new DataTable("HEADER");

            thongTinVien.Columns.Add("BENHVIEN");
            thongTinVien.Columns.Add("KHOA");
            thongTinVien.Columns.Add("MABENHAN");
			if (XemBenhAn._HanhChinhBenhNhan == null) XemBenhAn._HanhChinhBenhNhan = new HanhChinhBenhNhan();
            if (XemBenhAn._ThongTinDieuTri == null) XemBenhAn._ThongTinDieuTri = new ThongTinDieuTri();
            thongTinVien.Rows.Add(XemBenhAn._HanhChinhBenhNhan.BenhVien, XemBenhAn._ThongTinDieuTri.Khoa, XemBenhAn._ThongTinDieuTri.MaBenhAn);
            ds.Tables.Add(thongTinVien);

            return ds;
        }
        public static string downloadAnhMoTa(decimal IdPhauThuatMong, decimal maQuanLy)
        {
            string fullPath = "";
            try
            {
                string FileHinhAnh = @"\PTM\" + maQuanLy;
                if (IdPhauThuatMong != 0M)
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
                            string fileName = FileHinhAnh.Trim('\\') + "\\" + IdPhauThuatMong + ".png";
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
