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
    public class PhauThuatQuam : ThongTinKy
    {
        public PhauThuatQuam()
        {
            TableName = "PHAUTHUATQUAM";
            TablePrimaryKeyName = "ID";
            IDMauPhieu = (int)DanhMucPhieu.PTMQ;
            TenMauPhieu = DanhMucPhieu.PTMQ.Description();
        }
        public decimal IdPhauThuatQuam { get; set; }
        [MoTaDuLieu("Mã quản lý: mã duy nhất trong 1 đợt khám chữa bệnh (kcb), không trùng giữa các đợt kcb khác nhau","",1)]
		public decimal MaQuanLy { get; set; }
        [MoTaDuLieu("Ngày vào bệnh viện")]
		public DateTime NgayVaoVien { get; set; }
        public DateTime NgayPhauThuat { get; set; }
        public DateTime? NgayPhauThuat_Gio { get; set; }
        [MoTaDuLieu("Chẩn đoán bệnh trước phẫu thuật")]
		public string ChanDoanTruocPhauThuat { get; set; }
        public bool[] ChiDinhPTArray { get; } = new bool[] { false, false };
        public int ChiDinhPT
        {
            get
            {
                return Array.IndexOf(ChiDinhPTArray, true);
            }
            set
            {
                for (int i = 0; i < 2; i++)
                {
                    if (i == value) ChiDinhPTArray[i] = true;
                    else ChiDinhPTArray[i] = false;
                }
            }
        }
        public string ChiDinhPT_Text { get; set; }
        public bool[] CachThucPTArray { get; } = new bool[] { false, false, false };
        public int CachThucPT
        {
            get
            {
                return Array.IndexOf(CachThucPTArray, true);
            }
            set
            {
                for (int i = 0; i < 3; i++)
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
        public string LuocDoPhauThuat { get; set; }
        public bool LayManhNiemMacMoi { get; set; }
        public bool[] ViTriNiemMacDinhLayArray { get; } = new bool[] { false, false };
        public int ViTriNiemMacDinhLay
        {
            get
            {
                return Array.IndexOf(ViTriNiemMacDinhLayArray, true);
            }
            set
            {
                for (int i = 0; i < 2; i++)
                {
                    if (i == value) ViTriNiemMacDinhLayArray[i] = true;
                    else ViTriNiemMacDinhLayArray[i] = false;
                }
            }
        }
        public string RachNiemMacMoi { get; set; }
        public string Lay { get; set; }
        public double KichThuoc1 { get; set; }
        public double KichThuoc2 { get; set; }
        public bool[] KieuKhauArray { get; } = new bool[] { false, false };
        public int KieuKhau
        {
            get
            {
                return Array.IndexOf(KieuKhauArray, true);
            }
            set
            {
                for (int i = 0; i < 2; i++)
                {
                    if (i == value) KieuKhauArray[i] = true;
                    else KieuKhauArray[i] = false;
                }
            }
        }
        public string LoaiChiKhau { get; set; }
        public bool TraBetadin { get; set; }
        public bool[] CoDinhMiArray { get; } = new bool[] { false, false, false };
        public string CoDinhMi
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < CoDinhMiArray.Length; i++)
                    temp += (CoDinhMiArray[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        CoDinhMiArray[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public string LoaiChiCoDinhMi { get; set; }
        public bool DatThanhDe { get; set; }
        public bool RachBoMi { get; set; }
        public bool[] KieuKhauManhArray { get; } = new bool[] { false, false, false };
        public int KieuKhauManh
        {
            get
            {
                return Array.IndexOf(KieuKhauManhArray, true);
            }
            set
            {
                for (int i = 0; i < 3; i++)
                {
                    if (i == value) KieuKhauManhArray[i] = true;
                    else KieuKhauManhArray[i] = false;
                }
            }
        }
        public string LoaiChiKhauManh { get; set; }
        public bool RachDaMi { get; set; }
        public double KhoangCachRach { get; set; }
        public bool CatDaMiThua { get; set; }
        public double KichThuocCat { get; set; }
        public bool BocLoSunMi { get; set; }
        public bool TaoMangSun { get; set; }
        public bool DotCamMau { get; set; }
        public bool KhauSunMi { get; set; }
        public string LoaiChiKhauTreo { get; set; }
        public string LoaiChiKhauMangSun { get; set; }
        public bool[] KieuKhauDaMiArray { get; } = new bool[] { false, false };
        public int KieuKhauDaMi
        {
            get
            {
                return Array.IndexOf(KieuKhauDaMiArray, true);
            }
            set
            {
                for (int i = 0; i < 2; i++)
                {
                    if (i == value) KieuKhauDaMiArray[i] = true;
                    else KieuKhauDaMiArray[i] = false;
                }
            }
        }
        public string LoaiChiKhauDaMi { get; set; }
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
        public string TenThuoc { get; set; }
        public bool BangEp { get; set; }
        public DateTime NgayLapPhieu { get; set; }
        public string PhauThuatVien { get; set; }
        public string MaPhauThuatVien { get; set; }
        [MoTaDuLieu("Ngày tạo", null, 0, 0)]
		public DateTime NgayTao { get; set; }
        [MoTaDuLieu("Người tạo", null, 0, 0)]
		public string NguoiTao { get; set; }
        [MoTaDuLieu("Ngày sửa", null, 0, 0)]
		public DateTime NgaySua { get; set; }
        [MoTaDuLieu("Người sửa", null, 0, 0)]
		public string NguoiSua { get; set; }
    }
    public class PhauThuatQuamFunc
    {
        public static List<PhauThuatQuam> GetListData(MDB.MDBConnection _OracleConnection, decimal maquanly)
        {
            List<PhauThuatQuam> list = new List<PhauThuatQuam>();
            try
            {
                string sql = @"SELECT * FROM PhauThuatQuam where MaQuanLy = :MaQuanLy";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, _OracleConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", maquanly));
                MDB.MDBDataReader DataReader = Command.ExecuteReader();
                while (DataReader.Read())
                {
                    PhauThuatQuam data = new PhauThuatQuam();
                    data.IdPhauThuatQuam = Convert.ToInt64(DataReader.GetLong("IdPhauThuatQuam").ToString());
                    data.MaQuanLy = maquanly;
                    data.NgayVaoVien = Convert.ToDateTime(DataReader["NgayVaoVien"] == DBNull.Value ? DateTime.Now : DataReader["NgayVaoVien"]);
                    data.NgayPhauThuat = Convert.ToDateTime(DataReader["NgayPhauThuat"] == DBNull.Value ? DateTime.Now : DataReader["NgayPhauThuat"]);
                    data.ChanDoanTruocPhauThuat = DataReader["ChanDoanTruocPhauThuat"].ToString();

                    int tempInt = -1;
                    int.TryParse(DataReader["CachThucPT"].ToString(), out tempInt);
                    data.CachThucPT = tempInt;
                    data.CachThucPT_Text = DataReader["CachThucPT_Text"].ToString();

                    tempInt = -1;
                    int.TryParse(DataReader["ChiDinhPT"].ToString(), out tempInt);
                    data.ChiDinhPT = tempInt;
                    data.ChiDinhPT_Text = DataReader["ChiDinhPT_Text"].ToString();

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
                    double.TryParse(DataReader["DungTichGayMe"].ToString(), out doubleTemp);
                    data.DungTichGayMe = doubleTemp;
                    data.LuocDoPhauThuat = DataReader["LuocDoPhauThuat"].ToString();

                    data.LayManhNiemMacMoi = DataReader["LayManhNiemMacMoi"].ToString().Equals("1") ? true : false;
                   
                    tempInt = -1;
                    int.TryParse(DataReader["ViTriNiemMacDinhLay"].ToString(), out tempInt);
                    data.ViTriNiemMacDinhLay = tempInt;
                    data.RachNiemMacMoi = DataReader["RachNiemMacMoi"].ToString();
                    data.Lay = DataReader["Lay"].ToString();

                    doubleTemp = 0;
                    double.TryParse(DataReader["KichThuoc1"].ToString(), out doubleTemp);
                    data.KichThuoc1 = doubleTemp;

                    doubleTemp = 0;
                    double.TryParse(DataReader["KichThuoc2"].ToString(), out doubleTemp);
                    data.KichThuoc2 = doubleTemp;

                    tempInt = -1;
                    int.TryParse(DataReader["KieuKhau"].ToString(), out tempInt);
                    data.KieuKhau = tempInt;
                    data.LoaiChiKhau = DataReader["LoaiChiKhau"].ToString();
                    data.CoDinhMi = DataReader["CoDinhMi"].ToString();
                    data.TraBetadin = DataReader["TraBetadin"].ToString().Equals("1") ? true : false;
                    data.DotCamMau = DataReader["DotCamMau"].ToString().Equals("1") ? true : false;

                    data.LoaiChiCoDinhMi = DataReader["LoaiChiCoDinhMi"].ToString();
                    data.DatThanhDe = DataReader["DatThanhDe"].ToString().Equals("1") ? true : false;
                    data.RachBoMi = DataReader["RachBoMi"].ToString().Equals("1") ? true : false;

                    tempInt = -1;
                    int.TryParse(DataReader["KieuKhauManh"].ToString(), out tempInt);
                    data.KieuKhauManh = tempInt;
                    data.LoaiChiKhauManh = DataReader["LoaiChiKhauManh"].ToString();
                    data.RachDaMi = DataReader["RachDaMi"].ToString().Equals("1") ? true : false;
                    doubleTemp = 0;
                    double.TryParse(DataReader["KhoangCachRach"].ToString(), out doubleTemp);
                    data.KhoangCachRach = doubleTemp;

                    data.CatDaMiThua = DataReader["CatDaMiThua"].ToString().Equals("1") ? true : false;

                    doubleTemp = 0;
                    double.TryParse(DataReader["KichThuocCat"].ToString(), out doubleTemp);
                    data.KichThuocCat = doubleTemp;

                    data.BocLoSunMi = DataReader["BocLoSunMi"].ToString().Equals("1") ? true : false;
                    data.TaoMangSun = DataReader["TaoMangSun"].ToString().Equals("1") ? true : false;
                    data.DotCamMau = DataReader["DotCamMau"].ToString().Equals("1") ? true : false;
                    data.KhauSunMi = DataReader["KhauSunMi"].ToString().Equals("1") ? true : false;

                    data.LoaiChiKhauTreo = DataReader["LoaiChiKhauTreo"].ToString();
                    data.LoaiChiKhauMangSun = DataReader["LoaiChiKhauMangSun"].ToString();

                    tempInt = -1;
                    int.TryParse(DataReader["KieuKhauDaMi"].ToString(), out tempInt);
                    data.KieuKhauDaMi = tempInt;

                    data.LoaiChiKhauDaMi = DataReader["LoaiChiKhauDaMi"].ToString();

                    data.TraKhangSinh = tempInt;

                    data.TenThuoc = DataReader["TenThuoc"].ToString();

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
        public static bool InsertOrUpdate(MDB.MDBConnection MyConnection, ref PhauThuatQuam phauThuatQuam)
        {
            try
            {
                string sql = @"INSERT INTO PHAUTHUATQUAM
                (
                    MAQUANLY,
                    NgayVaoVien,
                    NgayPhauThuat,
                    ChanDoanTruocPhauThuat,
                    ChiDinhPT,
                    ChiDinhPT_Text,
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
                    LuocDoPhauThuat,
                    LayManhNiemMacMoi,
	                ViTriNiemMacDinhLay,
	                RachNiemMacMoi,
	                Lay,
	                KichThuoc1,
	                KichThuoc2,
	                KieuKhau,
	                LoaiChiKhau,
	                TraBetadin,
	                CoDinhMi,
	                LoaiChiCoDinhMi,
	                DatThanhDe,
	                RachBoMi,
	                KieuKhauManh,
	                LoaiChiKhauManh,
	                RachDaMi,
	                KhoangCachRach,
	                CatDaMiThua,
	                KichThuocCat,
	                BocLoSunMi,
	                TaoMangSun,
	                DotCamMau,
	                KhauSunMi,
	                LoaiChiKhauTreo,
	                LoaiChiKhauMangSun,
	                KieuKhauDaMi,
	                LoaiChiKhauDaMi,
                    TraKhangSinh,
                    TenThuoc,
                    BangEp,
                    NgayLapPhieu,
                    PhauThuatVien,
                    MaPhauThuatVien,
                    NGUOITAO,
                    NGUOISUA,
                    NGAYTAO,
                    NGAYSUA)  VALUES
                 (
				    :MAQUANLY,
                    :NgayVaoVien,
                    :NgayPhauThuat,
                    :ChanDoanTruocPhauThuat,
                    :ChiDinhPT,
                    :ChiDinhPT_Text,
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
                    :LuocDoPhauThuat,
                    :LayManhNiemMacMoi,
                    :ViTriNiemMacDinhLay,
	                :RachNiemMacMoi,
	                :Lay,
	                :KichThuoc1,
	                :KichThuoc2,
	                :KieuKhau,
	                :LoaiChiKhau,
	                :TraBetadin,
	                :CoDinhMi,
	                :LoaiChiCoDinhMi,
	                :DatThanhDe,
	                :RachBoMi,
	                :KieuKhauManh,
	                :LoaiChiKhauManh,
	                :RachDaMi,
	                :KhoangCachRach,
	                :CatDaMiThua,
	                :KichThuocCat,
	                :BocLoSunMi,
	                :TaoMangSun,
	                :DotCamMau,
	                :KhauSunMi,
	                :LoaiChiKhauTreo,
	                :LoaiChiKhauMangSun,
	                :KieuKhauDaMi,
	                :LoaiChiKhauDaMi,
                    :TraKhangSinh,
                    :TenThuoc,
                    :BangEp,
                    :NgayLapPhieu,
                    :PhauThuatVien,
                    :MaPhauThuatVien,
                    :NGUOITAO,
                    :NGUOISUA,
                    :NGAYTAO,
                    :NGAYSUA
                 )  RETURNING IdPhauThuatQuam INTO :IdPhauThuatQuam";
                if (phauThuatQuam.IdPhauThuatQuam != Decimal.Zero)
                {
                    sql = @"UPDATE PHAUTHUATQUAM SET 
                    MAQUANLY = :MAQUANLY,
                    NgayVaoVien = :NgayVaoVien,
                    NgayPhauThuat = :NgayPhauThuat,
                    ChanDoanTruocPhauThuat = :ChanDoanTruocPhauThuat,
                    ChiDinhPT = :ChiDinhPT,
                    ChiDinhPT_Text = :ChiDinhPT_Text,
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
                    LuocDoPhauThuat = :LuocDoPhauThuat,
                    LayManhNiemMacMoi = :LayManhNiemMacMoi,
	                ViTriNiemMacDinhLay = :ViTriNiemMacDinhLay,
	                RachNiemMacMoi = :RachNiemMacMoi,
	                Lay = :Lay,
	                KichThuoc1 = :KichThuoc1,
	                KichThuoc2 = :KichThuoc2,
	                KieuKhau = :KieuKhau,
	                LoaiChiKhau = :LoaiChiKhau,
	                TraBetadin = :TraBetadin,
	                CoDinhMi = :CoDinhMi,
	                LoaiChiCoDinhMi = :LoaiChiCoDinhMi,
	                DatThanhDe = :DatThanhDe,
	                RachBoMi = :RachBoMi,
	                KieuKhauManh = :KieuKhauManh,
	                LoaiChiKhauManh = :LoaiChiKhauManh,
	                RachDaMi = :RachDaMi,
	                KhoangCachRach = :KhoangCachRach,
	                CatDaMiThua = :CatDaMiThua,
	                KichThuocCat = :KichThuocCat,
	                BocLoSunMi = :BocLoSunMi,
	                TaoMangSun = :TaoMangSun,
	                DotCamMau = :DotCamMau,
	                KhauSunMi = :KhauSunMi,
	                LoaiChiKhauTreo = :LoaiChiKhauTreo,
	                LoaiChiKhauMangSun = :LoaiChiKhauMangSun,
	                KieuKhauDaMi = :KieuKhauDaMi,
	                LoaiChiKhauDaMi = :LoaiChiKhauDaMi,
                    TraKhangSinh = :TraKhangSinh,
                    TenThuoc = :TenThuoc,
                    BangEp = :BangEp,
                    NgayLapPhieu = :NgayLapPhieu,
                    PhauThuatVien = :PhauThuatVien,
                    MaPhauThuatVien = :MaPhauThuatVien,
                    NGUOISUA = :NGUOISUA,
                    NGAYSUA = :NGAYSUA 
                    WHERE IdPhauThuatQuam = " + phauThuatQuam.IdPhauThuatQuam;
                }
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MAQUANLY", phauThuatQuam.MaQuanLy));
                Command.Parameters.Add(new MDB.MDBParameter("NgayVaoVien", phauThuatQuam.NgayVaoVien));
                var Ngay = phauThuatQuam.NgayPhauThuat.Date.Add(new TimeSpan(0, 0, 0));
                var Gio = phauThuatQuam.NgayPhauThuat_Gio != null ? phauThuatQuam.NgayPhauThuat_Gio.Value.TimeOfDay : DateTime.Now.TimeOfDay;
                var ngayPhauThuat = Ngay + Gio;
                Command.Parameters.Add(new MDB.MDBParameter("NgayPhauThuat", ngayPhauThuat));
                Command.Parameters.Add(new MDB.MDBParameter("ChanDoanTruocPhauThuat", phauThuatQuam.ChanDoanTruocPhauThuat));
                Command.Parameters.Add(new MDB.MDBParameter("ChiDinhPT", phauThuatQuam.ChiDinhPT));
                Command.Parameters.Add(new MDB.MDBParameter("ChiDinhPT_Text", phauThuatQuam.ChiDinhPT_Text));
                Command.Parameters.Add(new MDB.MDBParameter("CachThucPT", phauThuatQuam.CachThucPT));
                Command.Parameters.Add(new MDB.MDBParameter("CachThucPT_Text", phauThuatQuam.CachThucPT_Text));
                Command.Parameters.Add(new MDB.MDBParameter("PhauThuatVienChinh", phauThuatQuam.PhauThuatVienChinh));
                Command.Parameters.Add(new MDB.MDBParameter("MaPhauThuatVienChinh", phauThuatQuam.MaPhauThuatVienChinh));
                Command.Parameters.Add(new MDB.MDBParameter("PhauThuatVienPhu", phauThuatQuam.PhauThuatVienPhu));
                Command.Parameters.Add(new MDB.MDBParameter("MaPhauThuatVienPhu", phauThuatQuam.MaPhauThuatVienPhu));
                Command.Parameters.Add(new MDB.MDBParameter("BacSyGayMe", phauThuatQuam.BacSyGayMe));
                Command.Parameters.Add(new MDB.MDBParameter("MaBacSyGayMe", phauThuatQuam.MaBacSyGayMe));
                Command.Parameters.Add(new MDB.MDBParameter("PhuongPhapVoCam", phauThuatQuam.PhuongPhapVoCam));
                Command.Parameters.Add(new MDB.MDBParameter("LoaiThuocGayTe", phauThuatQuam.LoaiThuocGayTe));
                Command.Parameters.Add(new MDB.MDBParameter("DungTichGayMe", phauThuatQuam.DungTichGayMe));
                Command.Parameters.Add(new MDB.MDBParameter("LuocDoPhauThuat", phauThuatQuam.LuocDoPhauThuat));
                Command.Parameters.Add(new MDB.MDBParameter("LayManhNiemMacMoi", phauThuatQuam.LayManhNiemMacMoi ? 1:0));
                Command.Parameters.Add(new MDB.MDBParameter("ViTriNiemMacDinhLay", phauThuatQuam.ViTriNiemMacDinhLay));
                Command.Parameters.Add(new MDB.MDBParameter("RachNiemMacMoi", phauThuatQuam.RachNiemMacMoi));
                Command.Parameters.Add(new MDB.MDBParameter("Lay", phauThuatQuam.Lay));
                Command.Parameters.Add(new MDB.MDBParameter("KichThuoc1", phauThuatQuam.KichThuoc1));
                Command.Parameters.Add(new MDB.MDBParameter("KichThuoc2", phauThuatQuam.KichThuoc2));
                Command.Parameters.Add(new MDB.MDBParameter("KieuKhau", phauThuatQuam.KieuKhau));
                Command.Parameters.Add(new MDB.MDBParameter("LoaiChiKhau", phauThuatQuam.LoaiChiKhau));
                Command.Parameters.Add(new MDB.MDBParameter("TraBetadin", phauThuatQuam.TraBetadin ? 1 : 0));
                Command.Parameters.Add(new MDB.MDBParameter("CoDinhMi", phauThuatQuam.CoDinhMi));
                Command.Parameters.Add(new MDB.MDBParameter("LoaiChiCoDinhMi", phauThuatQuam.LoaiChiCoDinhMi));
                Command.Parameters.Add(new MDB.MDBParameter("DatThanhDe", phauThuatQuam.DatThanhDe ? 1: 0));
                Command.Parameters.Add(new MDB.MDBParameter("RachBoMi", phauThuatQuam.RachBoMi ? 1 : 0));
                Command.Parameters.Add(new MDB.MDBParameter("KieuKhauManh", phauThuatQuam.KieuKhauManh));
                Command.Parameters.Add(new MDB.MDBParameter("LoaiChiKhauManh", phauThuatQuam.LoaiChiKhauManh));
                Command.Parameters.Add(new MDB.MDBParameter("RachDaMi", phauThuatQuam.RachDaMi ? 1: 0));
                Command.Parameters.Add(new MDB.MDBParameter("KhoangCachRach", phauThuatQuam.KhoangCachRach));
                Command.Parameters.Add(new MDB.MDBParameter("CatDaMiThua", phauThuatQuam.CatDaMiThua ? 1:0));
                Command.Parameters.Add(new MDB.MDBParameter("KichThuocCat", phauThuatQuam.KichThuocCat));
                Command.Parameters.Add(new MDB.MDBParameter("BocLoSunMi", phauThuatQuam.BocLoSunMi ? 1: 0));
                Command.Parameters.Add(new MDB.MDBParameter("TaoMangSun", phauThuatQuam.TaoMangSun ? 1 : 0));
                Command.Parameters.Add(new MDB.MDBParameter("DotCamMau", phauThuatQuam.DotCamMau ? 1 : 0));
                Command.Parameters.Add(new MDB.MDBParameter("KhauSunMi", phauThuatQuam.KhauSunMi ? 1 : 0));
                Command.Parameters.Add(new MDB.MDBParameter("LoaiChiKhauTreo", phauThuatQuam.LoaiChiKhauTreo));
                Command.Parameters.Add(new MDB.MDBParameter("LoaiChiKhauMangSun", phauThuatQuam.LoaiChiKhauMangSun));
                Command.Parameters.Add(new MDB.MDBParameter("KieuKhauDaMi", phauThuatQuam.KieuKhauDaMi));
                Command.Parameters.Add(new MDB.MDBParameter("LoaiChiKhauDaMi", phauThuatQuam.LoaiChiKhauDaMi));
                Command.Parameters.Add(new MDB.MDBParameter("TraKhangSinh", phauThuatQuam.TraKhangSinh));
                Command.Parameters.Add(new MDB.MDBParameter("TenThuoc", phauThuatQuam.TenThuoc));
                Command.Parameters.Add(new MDB.MDBParameter("BangEp", phauThuatQuam.BangEp ? 1 : 0));
                Command.Parameters.Add(new MDB.MDBParameter("NgayLapPhieu", phauThuatQuam.NgayLapPhieu));
                Command.Parameters.Add(new MDB.MDBParameter("PhauThuatVien", phauThuatQuam.PhauThuatVien));
                Command.Parameters.Add(new MDB.MDBParameter("MaPhauThuatVien", phauThuatQuam.MaPhauThuatVien));
                Command.Parameters.Add(new MDB.MDBParameter("NGUOISUA", phauThuatQuam.NguoiSua));
                Command.Parameters.Add(new MDB.MDBParameter("NGAYSUA", phauThuatQuam.NgaySua));
                if (phauThuatQuam.IdPhauThuatQuam.Equals(Decimal.Zero))
                {
                    Command.Parameters.Add(new MDB.MDBParameter("IdPhauThuatQuam", phauThuatQuam.IdPhauThuatQuam));
                    Command.Parameters.Add(new MDB.MDBParameter("NGUOITAO", phauThuatQuam.NguoiTao));
                    Command.Parameters.Add(new MDB.MDBParameter("NGAYTAO", phauThuatQuam.NgayTao));
                }
                Command.BindByName = true;
                int n = Command.ExecuteNonQuery();
                if (phauThuatQuam.IdPhauThuatQuam.Equals(Decimal.Zero))
                {
                    decimal nextval = Convert.ToInt64((Command.Parameters["IdPhauThuatQuam"] as MDB.MDBParameter).Value);
                    phauThuatQuam.IdPhauThuatQuam = nextval;
                }
                return n > 0 ? true : false;
            }
            catch (Exception ex)
            {
                XuLyLoi.Handle(ex);
            }
            return false;
        }
        public static bool delete(MDB.MDBConnection MyConnection, decimal idPhauThuatQuam)
        {
            try
            {
                string sql = "DELETE FROM PHAUTHUATQUAM WHERE idPhauThuatQuam = :idPhauThuatQuam";
                MDB.MDBCommand command = new MDB.MDBCommand(sql, MyConnection);
                command.Parameters.Add(new MDB.MDBParameter("idPhauThuatQuam", idPhauThuatQuam));
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
        public static DataSet getDataSet(MDB.MDBConnection MyConnection, decimal IdPhauThuatQuam)
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
                PHAUTHUATQUAM P
                JOIN THONGTINDIEUTRI T ON P.MAQUANLY = T.MAQUANLY
                JOIN HANHCHINHBENHNHAN H ON T.MABENHNHAN = H.MABENHNHAN
            WHERE
                IdPhauThuatQuam = " + IdPhauThuatQuam;

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
        public static string downloadAnhMoTa(decimal IdPhauThuatMoQuam, decimal maQuanLy)
        {
            string fullPath = "";
            try
            {
                string FileHinhAnh = @"\PTMQ\" + maQuanLy;
                if (IdPhauThuatMoQuam != 0M)
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
                            string fileName = FileHinhAnh.Trim('\\') + "\\" + IdPhauThuatMoQuam + ".png";
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
