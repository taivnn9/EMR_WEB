
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
    public class PhieuPhauThuatSapejko : ThongTinKy
    {
        public PhieuPhauThuatSapejko()
        {
            TableName = "PhieuPhauThuatSapejko";
            TablePrimaryKeyName = "ID";
            IDMauPhieu = (int)DanhMucPhieu.PPTS;
            TenMauPhieu = DanhMucPhieu.PPTS.Description();
        }
        [MoTaDuLieu("Mã định danh")]
		public long ID { get; set; }
        [MoTaDuLieu("Mã quản lý: mã duy nhất trong 1 đợt khám chữa bệnh (kcb), không trùng giữa các đợt kcb khác nhau","",1)]
		public decimal MaQuanLy { get; set; }
        [MoTaDuLieu("Mã bệnh nhân")]
		public string MaBenhNhan { get; set; }
        [MoTaDuLieu("Mã bệnh án")]
		public string MaBenhAn { get; set; }
		[MoTaDuLieu("Sở Y Tế")]
		public string SoYTe { get; set; }
        [MoTaDuLieu("Bệnh viện")]
		public string BenhVien { get; set; }
        public string MaSo { get; set; }
        public string SoVaoVien { get; set; }
        [MoTaDuLieu("Họ và tên bệnh nhân")]
		public string TenBenhNhan { get; set; }
        [MoTaDuLieu("Tuổi bệnh nhân")]
		public string Tuoi { get; set; }
        [MoTaDuLieu("Giới tính bệnh nhân")]
		public string GioiTinh { get; set; }

        [MoTaDuLieu("Chẩn đoán bệnh")]
		public string ChanDoan { get; set; }
        public bool[] ChiDinhPhauThuatArray { get; } = new bool[] { false, false };
        public string ChiDinhPhauThuat
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < ChiDinhPhauThuatArray.Length; i++)
                    temp += (ChiDinhPhauThuatArray[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        ChiDinhPhauThuatArray[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public string ChiDinhPhauThuat_Text { get; set; }

        public DateTime? NgayVaoVien { get; set; }
        public DateTime? NgayPhauThuat { get; set; }
        public DateTime? NgayPhauThuat_Gio { get; set; }
        public string MaPhauThuatVienChinh { get; set; }
        public string PhauThuatVienChinh { get; set; }
        public string MaPhauThuatVienPhu { get; set; }
        public string PhauThuatVienPhu { get; set; }
        public string MaBacSyGayMe { get; set; }
        public string BacSyGayMe { get; set; }
        public bool[] PhuongPhapVoCamArray { get; } = new bool[] { false, false };
        public string PhuongPhapVoCam
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < PhuongPhapVoCamArray.Length; i++)
                    temp += (PhuongPhapVoCamArray[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        PhuongPhapVoCamArray[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public string LoaiThuocGayTe { get; set; }
        public string LuocDoPhauThuat { get; set; }
        public int LayManhNiemMac { get; set; }
        public bool[] ViTriArray { get; } = new bool[] { false, false, false };
        public string ViTri
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < ViTriArray.Length; i++)
                    temp += (ViTriArray[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        ViTriArray[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public string SoLuongManh { get; set; }
        public string KichThuocX { get; set; }
        public string KichThuocY { get; set; }
        public bool[] KhauPhucHoiArray { get; } = new bool[] { false, false };
        public string KhauPhucHoi
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < KhauPhucHoiArray.Length; i++)
                    temp += (KhauPhucHoiArray[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        KhauPhucHoiArray[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public string KhauPhucHoi_Text { get; set; }
        public int TraBetadin { get; set; }
        public bool[] CoDinhMiArray { get; } = new bool[] { false, false };
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
        public string CoDinhMi_Text { get; set; }
        public int DatThanhDe { get; set; }
        public int RachBoMi { get; set; }
        public bool[] KhauManhNiemMacArray { get; } = new bool[] { false, false};
        public string KhauManhNiemMac
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < KhauManhNiemMacArray.Length; i++)
                    temp += (KhauManhNiemMacArray[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        KhauManhNiemMacArray[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }

        public string KhauManhNiemMac_Text { get; set; }
        public int RachDaMi { get; set; }
        public string RachDaMi_Text { get; set; }
        public int CatDaMiThua { get; set; }
        public string CatDaMiThua_Text { get; set; }
        public int BocLoSunMi { get; set; }
        public int TaoMangSun { get; set; }
        public int DotCamMau { get; set; }
        public int KhauSunMi { get; set; }
        public int KhauTreoNgoai { get; set; }
        public string KhauTreoNgoai_Text { get; set; }
        public int KhauMangSun { get; set; }
        public string KhauMangSun_Text { get; set; }

        public bool[] KhauDaMiArray { get; } = new bool[] { false, false };
        public string KhauDaMi
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < KhauDaMiArray.Length; i++)
                    temp += (KhauDaMiArray[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        KhauDaMiArray[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public string KhauDaMi_Text { get; set; }
        public bool[] TraKhangSinhArray { get; } = new bool[] { false, false };
        public string TraKhangSinh
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < TraKhangSinhArray.Length; i++)
                    temp += (TraKhangSinhArray[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        TraKhangSinhArray[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public string TraKhangSinh_Text { get; set; }
        public int BangEp { get; set; }
        public string MaPhauThuatVien { get; set; }
        public string PhauThuatVien { get; set; }
        public DateTime? NgayLapPhieu { get; set; }
        public string HinhAnhMoTa { get; set; }
        [MoTaDuLieu("Người tạo", null, 0, 0)]
		public string NguoiTao { get; set; }
        [MoTaDuLieu("Người sửa", null, 0, 0)]
		public string NguoiSua { get; set; }
        [MoTaDuLieu("Ngày tạo", null, 0, 0)]
		public DateTime NgayTao { get; set; }
        [MoTaDuLieu("Ngày sửa", null, 0, 0)]
		public DateTime NgaySua { get; set; }
        [MoTaDuLieu("Chọn", null, 0, 0)]
		public bool Chon { get; set; }
        //public string MaSoKyTen { get; set; }
        [MoTaDuLieu("Đã ký", null, 0, 0)]
		public bool DaKy { get; set; }
    }
    public class PhieuPhauThuatSapejkoFunc
    {
        public const string TableName = "PhieuPhauThuatSapejko";
        public const string TablePrimaryKeyName = "ID";

        public static List<PhieuPhauThuatSapejko> GetListData(MDB.MDBConnection _OracleConnection, decimal maquanly)
        {
            List<PhieuPhauThuatSapejko> list = new List<PhieuPhauThuatSapejko>();
            try
            {
                string sql = @"SELECT * FROM PhieuPhauThuatSapejko where MaQuanLy = :MaQuanLy";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, _OracleConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", maquanly));
                MDB.MDBDataReader DataReader = Command.ExecuteReader();
                while (DataReader.Read())
                {
                    PhieuPhauThuatSapejko data = new PhieuPhauThuatSapejko();
                    data.ID = Convert.ToInt64(DataReader.GetLong("ID").ToString());
                    data.MaQuanLy = maquanly;

                    data.MaBenhNhan = XemBenhAn._HanhChinhBenhNhan.MaBenhNhan;
                    data.MaBenhAn = XemBenhAn._ThongTinDieuTri.MaBenhAn;
                    data.TenBenhNhan = XemBenhAn._HanhChinhBenhNhan.TenBenhNhan;
                    data.Tuoi = XemBenhAn._HanhChinhBenhNhan.Tuoi;
                    data.GioiTinh = XemBenhAn._HanhChinhBenhNhan.GioiTinh.Description();
                    data.SoYTe = XemBenhAn._HanhChinhBenhNhan.SoYTe;
                    data.BenhVien = XemBenhAn._HanhChinhBenhNhan.BenhVien;
                    data.SoVaoVien = XemBenhAn._ThongTinDieuTri.SoNhapVien;

                    data.ChanDoan = DataReader["ChanDoan"].ToString();
                    data.ChiDinhPhauThuat_Text = DataReader["ChiDinhPhauThuat_Text"].ToString();
                    data.ChiDinhPhauThuat = DataReader["ChiDinhPhauThuat"].ToString();
                    data.NgayVaoVien = Convert.ToDateTime(DataReader["NgayVaoVien"] == DBNull.Value ? DateTime.Now : DataReader["NgayVaoVien"]);
                    data.NgayPhauThuat = Convert.ToDateTime(DataReader["NgayPhauThuat"] == DBNull.Value ? DateTime.Now : DataReader["NgayPhauThuat"]);
                    data.NgayPhauThuat_Gio = data.NgayPhauThuat;

                    data.PhauThuatVienChinh = DataReader["PhauThuatVienChinh"].ToString();
                    data.MaPhauThuatVienChinh = DataReader["MaPhauThuatVienChinh"].ToString();
                    data.PhauThuatVienPhu = DataReader["PhauThuatVienPhu"].ToString();
                    data.MaPhauThuatVienPhu = DataReader["MaPhauThuatVienPhu"].ToString();
                    data.BacSyGayMe = DataReader["BacSyGayMe"].ToString();
                    data.MaBacSyGayMe = DataReader["MaBacSyGayMe"].ToString();

                    data.PhuongPhapVoCam = DataReader["PhuongPhapVoCam"].ToString();
                    data.LoaiThuocGayTe = DataReader["LoaiThuocGayTe"].ToString();

                    data.LayManhNiemMac = DataReader.GetInt("LayManhNiemMac");
                    data.ViTri = DataReader["ViTri"].ToString();
                    data.SoLuongManh = DataReader["SoLuongManh"].ToString();
                    data.KichThuocX = DataReader["KichThuocX"].ToString();
                    data.KichThuocY = DataReader["KichThuocY"].ToString();
                    data.KhauPhucHoi = DataReader["KhauPhucHoi"].ToString();
                    data.KhauPhucHoi_Text = DataReader["KhauPhucHoi_Text"].ToString();
                    data.TraBetadin = DataReader.GetInt("TraBetadin");
                    data.CoDinhMi = DataReader["CoDinhMi"].ToString();
                    data.DatThanhDe = DataReader.GetInt("DatThanhDe");
                    data.RachBoMi = DataReader.GetInt("RachBoMi");
                    data.KhauManhNiemMac = DataReader["KhauManhNiemMac"].ToString();
                    data.KhauManhNiemMac_Text = DataReader["KhauManhNiemMac_Text"].ToString();
                    data.RachDaMi = DataReader.GetInt("RachDaMi");
                    data.RachDaMi_Text = DataReader["RachDaMi_Text"].ToString();
                    data.CatDaMiThua = DataReader.GetInt("CatDaMiThua");
                    data.CatDaMiThua_Text = DataReader["CatDaMiThua_Text"].ToString();
                    data.BocLoSunMi = DataReader.GetInt("BocLoSunMi");
                    data.TaoMangSun = DataReader.GetInt("TaoMangSun");
                    data.DotCamMau = DataReader.GetInt("DotCamMau");
                    data.KhauSunMi = DataReader.GetInt("KhauSunMi");
                    data.KhauTreoNgoai = DataReader.GetInt("KhauTreoNgoai");
                    data.KhauTreoNgoai_Text = DataReader["KhauTreoNgoai_Text"].ToString();
                    data.KhauMangSun = DataReader.GetInt("KhauMangSun");
                    data.KhauMangSun_Text = DataReader["KhauMangSun_Text"].ToString();
                    data.KhauDaMi = DataReader["KhauDaMi"].ToString();
                    data.KhauDaMi_Text = DataReader["KhauDaMi_Text"].ToString();
                    data.TraKhangSinh = DataReader["TraKhangSinh"].ToString();
                    data.TraKhangSinh_Text = DataReader["TraKhangSinh_Text"].ToString();
                    data.BangEp = DataReader.GetInt("BangEp");

                    data.MaPhauThuatVien = DataReader["MaPhauThuatVien"].ToString();
                    data.PhauThuatVien = DataReader["PhauThuatVien"].ToString();
                    data.LuocDoPhauThuat = DataReader["LuocDoPhauThuat"].ToString();
                    data.NgayLapPhieu = Convert.ToDateTime(DataReader["NgayLapPhieu"] == DBNull.Value ? DateTime.Now : DataReader["NgayLapPhieu"]);

                    data.NgayTao = Convert.ToDateTime(DataReader["NGAYTAO"] == DBNull.Value ? DateTime.Now : DataReader["NGAYTAO"]);
                    data.NguoiTao = DataReader["NGUOITAO"].ToString();
                    data.NgaySua = Convert.ToDateTime(DataReader["NGAYSUA"] == DBNull.Value ? DateTime.Now : DataReader["NGAYSUA"]);
                    data.NguoiSua = DataReader["NGUOISUA"].ToString();

                    data.MaSoKy = DataReader["masokyten"].ToString();
                    data.DaKy = !string.IsNullOrEmpty(data.MaSoKy) ? true : false;
                    list.Add(data);
                }
            }
            catch (Exception ex) { XuLyLoi.Handle(ex); }
            return list;
        }
        public static bool DeleteByIDPhieu(MDB.MDBConnection oracleConnection, decimal IDBienBan)
        {
            try
            {
                string sql = "";
                MDB.MDBCommand oracleCommand;
                sql = @"DELETE FROM PhieuPhauThuatSapejko WHERE ID =" + IDBienBan;
                using (oracleCommand = new MDB.MDBCommand(sql, oracleConnection))
                {
                    oracleCommand.ExecuteNonQuery();
                }
                return true;
            }
            catch (Exception ex)
            {
                XuLyLoi.LogError(ex);
            }
            return false;
        }
        public static DataSet GetDataSet(MDB.MDBConnection MyConnection, long IDBienBan)
        {
            string sql = @"SELECT P.*, T.SoNhapVien, T.Khoa , T.NgayVaoVien ,  T.MaKhoa, T.MaBenhAn, T.Giuong, T.Buong,            
				H.TUOI,H.SoYTe, H.BENHVIEN, 
				 H.GIOITINH,  H.TenBenhNhan, H.maBenhNhan
			  FROM PhieuPhauThuatSapejko P 
				Left JOIN THONGTINDIEUTRI T ON P.MAQUANLY = T.MAQUANLY
				Left JOIN HANHCHINHBENHNHAN H ON T.MABENHNHAN = H.MABENHNHAN
			  where ID = :IDPhieu";
            MDB.MDBCommand Command;
            MDB.MDBDataAdapter adt;
            using (Command = new MDB.MDBCommand(sql, MyConnection))
            {
                Command.Parameters.Add(new MDB.MDBParameter("IDPhieu", IDBienBan));
                adt = new MDB.MDBDataAdapter(Command);
            }
            var ds = new DataSet();
            adt.Fill(ds, "PT");

            return ds;
        }
        public static bool InsertOrUpdate(MDB.MDBConnection MyConnection, ref PhieuPhauThuatSapejko ketQua)
        {
            try
            {
                string sql = @"INSERT INTO PhieuPhauThuatSapejko
                (
                    MaQuanLy,
                    ChanDoan,
                    ChiDinhPhauThuat,
                    ChiDinhPhauThuat_Text,
                    NgayVaoVien,
                    NgayPhauThuat,
                    MaPhauThuatVienChinh,
                    PhauThuatVienChinh,
                    MaPhauThuatVienPhu,
                    PhauThuatVienPhu,
                    MaBacSyGayMe,
                    BacSyGayMe,
                    PhuongPhapVoCam,
                    LoaiThuocGayTe,
                    LuocDoPhauThuat,
                    LayManhNiemMac,
                    ViTri,
                    SoLuongManh,
                    KichThuocX,
                    KichThuocY,
                    KhauPhucHoi,
                    KhauPhucHoi_Text,
                    TraBetadin,
                    CoDinhMi,
                    CoDinhMi_Text,
                    DatThanhDe,
                    RachBoMi,
                    KhauManhNiemMac,
                    KhauManhNiemMac_Text,
                    RachDaMi,
                    RachDaMi_Text,
                    CatDaMiThua,
                    CatDaMiThua_Text,
                    BocLoSunMi,
                    TaoMangSun,
                    DotCamMau,
                    KhauSunMi,
                    KhauTreoNgoai,
                    KhauTreoNgoai_Text,
                    KhauMangSun,
                    KhauMangSun_Text,
                    KhauDaMi,
                    KhauDaMi_Text,
                    TraKhangSinh,
                    TraKhangSinh_Text,
                    BangEp,
                    MaPhauThuatVien,
                    PhauThuatVien,
                    NgayLapPhieu,
                    NGUOITAO,
                    NGUOISUA,
                    NGAYTAO,
                    NGAYSUA)  VALUES
                 (
				    :MaQuanLy,
                    :ChanDoan,
                    :ChiDinhPhauThuat,
                    :ChiDinhPhauThuat_Text,
                    :NgayVaoVien,
                    :NgayPhauThuat,
                    :MaPhauThuatVienChinh,
                    :PhauThuatVienChinh,
                    :MaPhauThuatVienPhu,
                    :PhauThuatVienPhu,
                    :MaBacSyGayMe,
                    :BacSyGayMe,
                    :PhuongPhapVoCam,
                    :LoaiThuocGayTe,
                    :LuocDoPhauThuat,
                    :LayManhNiemMac,
                    :ViTri,
                    :SoLuongManh,
                    :KichThuocX,
                    :KichThuocY,
                    :KhauPhucHoi,
                    :KhauPhucHoi_Text,
                    :TraBetadin,
                    :CoDinhMi,
                    :CoDinhMi_Text,
                    :DatThanhDe,
                    :RachBoMi,
                    :KhauManhNiemMac,
                    :KhauManhNiemMac_Text,
                    :RachDaMi,
                    :RachDaMi_Text,
                    :CatDaMiThua,
                    :CatDaMiThua_Text,
                    :BocLoSunMi,
                    :TaoMangSun,
                    :DotCamMau,
                    :KhauSunMi,
                    :KhauTreoNgoai,
                    :KhauTreoNgoai_Text,
                    :KhauMangSun,
                    :KhauMangSun_Text,
                    :KhauDaMi,
                    :KhauDaMi_Text,
                    :TraKhangSinh,
                    :TraKhangSinh_Text,
                    :BangEp,
                    :MaPhauThuatVien,
                    :PhauThuatVien,
                    :NgayLapPhieu,
                    :NGUOITAO,
                    :NGUOISUA,
                    :NGAYTAO,
                    :NGAYSUA
                 )  RETURNING ID INTO :ID";
                if (ketQua.ID != 0)
                {
                    sql = @"UPDATE PhieuPhauThuatSapejko SET 
                    MaQuanLy = :MaQuanLy,
                    ChanDoan = :ChanDoan,
                    ChiDinhPhauThuat = :ChiDinhPhauThuat,
                    ChiDinhPhauThuat_Text = :ChiDinhPhauThuat_Text,
                    NgayVaoVien = :NgayVaoVien,
                    NgayPhauThuat = :NgayPhauThuat,
                    MaPhauThuatVienChinh = :MaPhauThuatVienChinh,
                    PhauThuatVienChinh = :PhauThuatVienChinh,
                    MaPhauThuatVienPhu = :MaPhauThuatVienPhu,
                    PhauThuatVienPhu = :PhauThuatVienPhu,
                    MaBacSyGayMe = :MaBacSyGayMe,
                    BacSyGayMe = :BacSyGayMe,
                    PhuongPhapVoCam = :PhuongPhapVoCam,
                    LoaiThuocGayTe = :LoaiThuocGayTe,
                    LuocDoPhauThuat = :LuocDoPhauThuat,
                    LayManhNiemMac = :LayManhNiemMac,
                    ViTri = :ViTri,
                    SoLuongManh = :SoLuongManh,
                    KichThuocX = :KichThuocX,
                    KichThuocY = :KichThuocY,
                    KhauPhucHoi = :KhauPhucHoi,
                    KhauPhucHoi_Text = :KhauPhucHoi_Text,
                    TraBetadin = :TraBetadin,
                    CoDinhMi = :CoDinhMi,
                    CoDinhMi_Text = :CoDinhMi_Text,
                    DatThanhDe = :DatThanhDe,
                    RachBoMi = :RachBoMi,
                    KhauManhNiemMac = :KhauManhNiemMac,
                    KhauManhNiemMac_Text = :KhauManhNiemMac_Text,
                    RachDaMi = :RachDaMi,
                    RachDaMi_Text = :RachDaMi_Text,
                    CatDaMiThua = :CatDaMiThua,
                    CatDaMiThua_Text = :CatDaMiThua_Text,
                    BocLoSunMi = :BocLoSunMi,
                    TaoMangSun = :TaoMangSun,
                    DotCamMau = :DotCamMau,
                    KhauSunMi = :KhauSunMi,
                    KhauTreoNgoai = :KhauTreoNgoai,
                    KhauTreoNgoai_Text = :KhauTreoNgoai_Text,
                    KhauMangSun = :KhauMangSun,
                    KhauMangSun_Text = :KhauMangSun_Text,
                    KhauDaMi = :KhauDaMi,
                    KhauDaMi_Text = :KhauDaMi_Text,
                    TraKhangSinh = :TraKhangSinh,
                    TraKhangSinh_Text = :TraKhangSinh_Text,
                    BangEp = :BangEp,
                    MaPhauThuatVien = :MaPhauThuatVien,
                    PhauThuatVien = :PhauThuatVien,
                    NgayLapPhieu = :NgayLapPhieu,
                    NGUOISUA = :NGUOISUA,
                    NGAYSUA = :NGAYSUA 
                    WHERE ID = " + ketQua.ID;
                }
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);

                Command.Parameters.Add(new MDB.MDBParameter("NGUOISUA", ketQua.NguoiSua));
                Command.Parameters.Add(new MDB.MDBParameter("NGAYSUA", ketQua.NgaySua));

                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", ketQua.MaQuanLy));
                DateTime? Ngay = ketQua.NgayPhauThuat.HasValue ? ketQua.NgayPhauThuat.ToDateTime().Date : (DateTime?)null;
                var NgayGio = Ngay;
                if (Ngay != null)
                {
                    var Gio = ketQua.NgayPhauThuat_Gio.HasValue ? ketQua.NgayPhauThuat_Gio.Value.TimeOfDay : new TimeSpan(0, 0, 0);
                    NgayGio = Ngay + Gio;
                }
                Command.Parameters.Add(new MDB.MDBParameter("ChanDoan", ketQua.ChanDoan));
                Command.Parameters.Add(new MDB.MDBParameter("ChiDinhPhauThuat", ketQua.ChiDinhPhauThuat));
                Command.Parameters.Add(new MDB.MDBParameter("ChiDinhPhauThuat_Text", ketQua.ChiDinhPhauThuat_Text));
                Command.Parameters.Add(new MDB.MDBParameter("NgayVaoVien", ketQua.NgayVaoVien));
                Command.Parameters.Add(new MDB.MDBParameter("NgayPhauThuat", NgayGio));
                Command.Parameters.Add(new MDB.MDBParameter("MaPhauThuatVienChinh", ketQua.MaPhauThuatVienChinh));
                Command.Parameters.Add(new MDB.MDBParameter("PhauThuatVienChinh", ketQua.PhauThuatVienChinh));
                Command.Parameters.Add(new MDB.MDBParameter("MaPhauThuatVienPhu", ketQua.MaPhauThuatVienPhu));
                Command.Parameters.Add(new MDB.MDBParameter("PhauThuatVienPhu", ketQua.PhauThuatVienPhu));
                Command.Parameters.Add(new MDB.MDBParameter("MaBacSyGayMe", ketQua.MaBacSyGayMe));
                Command.Parameters.Add(new MDB.MDBParameter("BacSyGayMe", ketQua.BacSyGayMe));
                Command.Parameters.Add(new MDB.MDBParameter("PhuongPhapVoCam", ketQua.PhuongPhapVoCam));
                Command.Parameters.Add(new MDB.MDBParameter("LoaiThuocGayTe", ketQua.LoaiThuocGayTe));
                Command.Parameters.Add(new MDB.MDBParameter("LuocDoPhauThuat", ketQua.LuocDoPhauThuat));
                Command.Parameters.Add(new MDB.MDBParameter("LayManhNiemMac", ketQua.LayManhNiemMac));
                Command.Parameters.Add(new MDB.MDBParameter("ViTri", ketQua.ViTri));
                Command.Parameters.Add(new MDB.MDBParameter("SoLuongManh", ketQua.SoLuongManh));
                Command.Parameters.Add(new MDB.MDBParameter("KichThuocX", ketQua.KichThuocX));
                Command.Parameters.Add(new MDB.MDBParameter("KichThuocY", ketQua.KichThuocY));
                Command.Parameters.Add(new MDB.MDBParameter("KhauPhucHoi", ketQua.KhauPhucHoi));
                Command.Parameters.Add(new MDB.MDBParameter("KhauPhucHoi_Text", ketQua.KhauPhucHoi_Text));
                Command.Parameters.Add(new MDB.MDBParameter("TraBetadin", ketQua.TraBetadin));
                Command.Parameters.Add(new MDB.MDBParameter("CoDinhMi", ketQua.CoDinhMi));
                Command.Parameters.Add(new MDB.MDBParameter("CoDinhMi_Text", ketQua.CoDinhMi_Text));
                Command.Parameters.Add(new MDB.MDBParameter("DatThanhDe", ketQua.DatThanhDe));
                Command.Parameters.Add(new MDB.MDBParameter("RachBoMi", ketQua.RachBoMi));
                Command.Parameters.Add(new MDB.MDBParameter("KhauManhNiemMac", ketQua.KhauManhNiemMac));
                Command.Parameters.Add(new MDB.MDBParameter("KhauManhNiemMac_Text", ketQua.KhauManhNiemMac_Text));
                Command.Parameters.Add(new MDB.MDBParameter("RachDaMi", ketQua.RachDaMi));
                Command.Parameters.Add(new MDB.MDBParameter("RachDaMi_Text", ketQua.RachDaMi_Text));
                Command.Parameters.Add(new MDB.MDBParameter("CatDaMiThua", ketQua.CatDaMiThua));
                Command.Parameters.Add(new MDB.MDBParameter("CatDaMiThua_Text", ketQua.CatDaMiThua_Text));
                Command.Parameters.Add(new MDB.MDBParameter("BocLoSunMi", ketQua.BocLoSunMi));
                Command.Parameters.Add(new MDB.MDBParameter("TaoMangSun", ketQua.TaoMangSun));
                Command.Parameters.Add(new MDB.MDBParameter("DotCamMau", ketQua.DotCamMau));
                Command.Parameters.Add(new MDB.MDBParameter("KhauSunMi", ketQua.KhauSunMi));
                Command.Parameters.Add(new MDB.MDBParameter("KhauTreoNgoai", ketQua.KhauTreoNgoai));
                Command.Parameters.Add(new MDB.MDBParameter("KhauTreoNgoai_Text", ketQua.KhauTreoNgoai_Text));
                Command.Parameters.Add(new MDB.MDBParameter("KhauMangSun", ketQua.KhauMangSun));
                Command.Parameters.Add(new MDB.MDBParameter("KhauMangSun_Text", ketQua.KhauMangSun_Text));
                Command.Parameters.Add(new MDB.MDBParameter("KhauDaMi", ketQua.KhauDaMi));
                Command.Parameters.Add(new MDB.MDBParameter("KhauDaMi_Text", ketQua.KhauDaMi_Text));
                Command.Parameters.Add(new MDB.MDBParameter("TraKhangSinh", ketQua.TraKhangSinh));
                Command.Parameters.Add(new MDB.MDBParameter("TraKhangSinh_Text", ketQua.TraKhangSinh_Text));
                Command.Parameters.Add(new MDB.MDBParameter("BangEp", ketQua.BangEp));
                Command.Parameters.Add(new MDB.MDBParameter("MaPhauThuatVien", ketQua.MaPhauThuatVien));
                Command.Parameters.Add(new MDB.MDBParameter("PhauThuatVien", ketQua.PhauThuatVien));
                Command.Parameters.Add(new MDB.MDBParameter("NgayLapPhieu", ketQua.NgayLapPhieu));
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
                XuLyLoi.LogError(ex);
            }
            return false;
        }

        public static string downloadAnhMoTa(decimal IdPhauThuatMong, decimal maQuanLy)
        {
            string fullPath = "";
            try
            {
                string FileHinhAnh = @"\PTSapejko\" + maQuanLy;
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
