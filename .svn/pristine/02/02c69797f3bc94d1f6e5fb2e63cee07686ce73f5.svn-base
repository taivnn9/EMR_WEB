
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
    public class PhieuPhauThuatGlocom : ThongTinKy
    {
        public PhieuPhauThuatGlocom()
        {
            TableName = "PhieuPhauThuatGlocom";
            TablePrimaryKeyName = "ID";
            IDMauPhieu = (int)DanhMucPhieu.PTTG;
            TenMauPhieu = DanhMucPhieu.PTTG.Description();
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

        public bool[] ChanDoanArray { get; } = new bool[] { false, false, false, false };
        public int ChanDoan
        {
            get
            {
                return Array.IndexOf(ChanDoanArray, true) + 1;
            }
            set
            {
                for (int i = 0; i < ChanDoanArray.Length; i++)
                {
                    if (i == (value - 1)) ChanDoanArray[i] = true;
                    else ChanDoanArray[i] = false;
                }
            }
        }
        [MoTaDuLieu("Chẩn đoán bệnh")]
		public string ChanDoan_Text { get; set; }
        public bool[] GiaiDoanBenhArray { get; } = new bool[] { false, false, false, false, false, false };
        public int GiaiDoanBenh
        {
            get
            {
                return Array.IndexOf(GiaiDoanBenhArray, true) + 1;
            }
            set
            {
                for (int i = 0; i < GiaiDoanBenhArray.Length; i++)
                {
                    if (i == (value - 1)) GiaiDoanBenhArray[i] = true;
                    else GiaiDoanBenhArray[i] = false;
                }
            }
        }

        public DateTime? NgayVaoVien { get; set; }
        public DateTime? NgayPhauThuat { get; set; }
        public DateTime? NgayPhauThuat_Gio { get; set; }
        public bool[] PhuongPhapPhauThuatArray { get; } = new bool[] { false, false, false, false, false, false };
        public int PhuongPhapPhauThuat
        {
            get
            {
                return Array.IndexOf(PhuongPhapPhauThuatArray, true) + 1;
            }
            set
            {
                for (int i = 0; i < PhuongPhapPhauThuatArray.Length; i++)
                {
                    if (i == (value - 1)) PhuongPhapPhauThuatArray[i] = true;
                    else PhuongPhapPhauThuatArray[i] = false;
                }
            }
        }
        public string MaPhauThuatVienChinh { get; set; }
        public string PhauThuatVienChinh { get; set; }
        public string MaPhauThuatVienPhu { get; set; }
        public string PhauThuatVienPhu { get; set; }
        public string MaBacSyGayMe { get; set; }
        public string BacSyGayMe { get; set; }
        public string LanPhauThuat { get; set; }
        public bool[] PhuongPhapVoCamArray { get; } = new bool[] { false, false, false, false };
        public int PhuongPhapVoCam
        {
            get
            {
                return Array.IndexOf(PhuongPhapVoCamArray, true) + 1;
            }
            set
            {
                for (int i = 0; i < PhuongPhapVoCamArray.Length; i++)
                {
                    if (i == (value - 1)) PhuongPhapVoCamArray[i] = true;
                    else PhuongPhapVoCamArray[i] = false;
                }
            }
        }
        public string LoaiThuocGayTe { get; set; }
        public string LuocDoPhauThuat { get; set; }
        public bool[] CoDinhNhanCauArray { get; } = new bool[] { false, false, false };
        public int CoDinhNhanCau
        {
            get
            {
                return Array.IndexOf(CoDinhNhanCauArray, true) + 1;
            }
            set
            {
                for (int i = 0; i < CoDinhNhanCauArray.Length; i++)
                {
                    if (i == (value - 1)) CoDinhNhanCauArray[i] = true;
                    else CoDinhNhanCauArray[i] = false;
                }
            }
        }
        public bool[] TaoVatKmArray { get; } = new bool[] { false, false };
        public int TaoVatKm
        {
            get
            {
                return Array.IndexOf(TaoVatKmArray, true) + 1;
            }
            set
            {
                for (int i = 0; i < TaoVatKmArray.Length; i++)
                {
                    if (i == (value - 1)) TaoVatKmArray[i] = true;
                    else TaoVatKmArray[i] = false;
                }
            }
        }
        public string KinhTuyen { get; set; }
        public bool[] TinhTrangBaoTenonArray { get; } = new bool[] { false, false, false };
        public int TinhTrangBaoTenon
        {
            get
            {
                return Array.IndexOf(TinhTrangBaoTenonArray, true) + 1;
            }
            set
            {
                for (int i = 0; i < TinhTrangBaoTenonArray.Length; i++)
                {
                    if (i == (value - 1)) TinhTrangBaoTenonArray[i] = true;
                    else TinhTrangBaoTenonArray[i] = false;
                }
            }
        }
        public bool[] UcCheTaoXoArray { get; } = new bool[] { false, false, false, false, false };
        public int UcCheTaoXo
        {
            get
            {
                return Array.IndexOf(UcCheTaoXoArray, true) + 1;
            }
            set
            {
                for (int i = 0; i < UcCheTaoXoArray.Length; i++)
                {
                    if (i == (value - 1)) UcCheTaoXoArray[i] = true;
                    else UcCheTaoXoArray[i] = false;
                }
            }
        }
        public string UcCheTaoXo_Text { get; set; }
        public bool[] ViTriArray { get; } = new bool[] { false, false, false };
        public int ViTri
        {
            get
            {
                return Array.IndexOf(ViTriArray, true) + 1;
            }
            set
            {
                for (int i = 0; i < ViTriArray.Length; i++)
                {
                    if (i == (value - 1)) ViTriArray[i] = true;
                    else ViTriArray[i] = false;
                }
            }
        }
        public string ThoiGian { get; set; }
        public bool[] LangBotBaoTenonArray { get; } = new bool[] { false, false };
        public int LangBotBaoTenon
        {
            get
            {
                return Array.IndexOf(LangBotBaoTenonArray, true) + 1;
            }
            set
            {
                for (int i = 0; i < LangBotBaoTenonArray.Length; i++)
                {
                    if (i == (value - 1)) LangBotBaoTenonArray[i] = true;
                    else LangBotBaoTenonArray[i] = false;
                }
            }
        }
        public bool[] CatBoCMArray { get; } = new bool[] { false, false };
        public int CatBoCM
        {
            get
            {
                return Array.IndexOf(CatBoCMArray, true) + 1;
            }
            set
            {
                for (int i = 0; i < CatBoCMArray.Length; i++)
                {
                    if (i == (value - 1)) CatBoCMArray[i] = true;
                    else CatBoCMArray[i] = false;
                }
            }
        }
        public string VatCMThuNhat1 { get; set; }
        public string VatCMThuNhat2 { get; set; }
        public string VatCMThuHai1 { get; set; }
        public string VatCMThuHai2 { get; set; }
        public bool[] ChocTPArray { get; } = new bool[] { false, false };
        public int ChocTP
        {
            get
            {
                return Array.IndexOf(ChocTPArray, true) + 1;
            }
            set
            {
                for (int i = 0; i < ChocTPArray.Length; i++)
                {
                    if (i == (value - 1)) ChocTPArray[i] = true;
                    else ChocTPArray[i] = false;
                }
            }
        }
        public bool[] CatMauBeArray { get; } = new bool[] { false, false, false, false, false, false };
        public int CatMauBe
        {
            get
            {
                return Array.IndexOf(CatMauBeArray, true) + 1;
            }
            set
            {
                for (int i = 0; i < CatMauBeArray.Length; i++)
                {
                    if (i == (value - 1)) CatMauBeArray[i] = true;
                    else CatMauBeArray[i] = false;
                }
            }
        }
        public bool[] CatMongMatArray { get; } = new bool[] { false, false, false, false };
        public int CatMongMat
        {
            get
            {
                return Array.IndexOf(CatMongMatArray, true) + 1;
            }
            set
            {
                for (int i = 0; i < CatMongMatArray.Length; i++)
                {
                    if (i == (value - 1)) CatMongMatArray[i] = true;
                    else CatMongMatArray[i] = false;
                }
            }
        }
        public bool[] TinhTrangTheMiArray { get; } = new bool[] { false, false, false };
        public int TinhTrangTheMi
        {
            get
            {
                return Array.IndexOf(TinhTrangTheMiArray, true) + 1;
            }
            set
            {
                for (int i = 0; i < TinhTrangTheMiArray.Length; i++)
                {
                    if (i == (value - 1)) TinhTrangTheMiArray[i] = true;
                    else TinhTrangTheMiArray[i] = false;
                }
            }
        }
        public string SoMui { get; set; }
        public bool[] KhauNapCMArray { get; } = new bool[] { false, false };
        public int KhauNapCM
        {
            get
            {
                return Array.IndexOf(KhauNapCMArray, true) + 1;
            }
            set
            {
                for (int i = 0; i < KhauNapCMArray.Length; i++)
                {
                    if (i == (value - 1)) KhauNapCMArray[i] = true;
                    else KhauNapCMArray[i] = false;
                }
            }
        }
        public string LoaiChi { get; set; }
        public bool[] TaiTaoTPArray { get; } = new bool[] { false, false };
        public int TaiTaoTP
        {
            get
            {
                return Array.IndexOf(TaiTaoTPArray, true) + 1;
            }
            set
            {
                for (int i = 0; i < TaiTaoTPArray.Length; i++)
                {
                    if (i == (value - 1)) TaiTaoTPArray[i] = true;
                    else TaiTaoTPArray[i] = false;
                }
            }
        }
        public bool[] KhauKMArray { get; } = new bool[] { false, false, false, false };
        public int KhauKM
        {
            get
            {
                return Array.IndexOf(KhauKMArray, true) + 1;
            }
            set
            {
                for (int i = 0; i < KhauKMArray.Length; i++)
                {
                    if (i == (value - 1)) KhauKMArray[i] = true;
                    else KhauKMArray[i] = false;
                }
            }
        }
        public bool[] TiemMatArray { get; } = new bool[] { false, false, false, false };
        public int TiemMat
        {
            get
            {
                return Array.IndexOf(TiemMatArray, true) + 1;
            }
            set
            {
                for (int i = 0; i < TiemMatArray.Length; i++)
                {
                    if (i == (value - 1)) TiemMatArray[i] = true;
                    else TiemMatArray[i] = false;
                }
            }
        }
        public string KhauKM2_Text { get; set; }
        public string KhauKM3_Text { get; set; }
        public string KhauKM4_Text { get; set; }
        public string DienBienKhac { get; set; }
        public string TiemMat_Thuoc { get; set; }
        public string ThuocTraMat { get; set; }
        public string Bang { get; set; }
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
    public class PhieuPhauThuatGlocomFunc
    {
        public const string TableName = "PhieuPhauThuatGlocom";
        public const string TablePrimaryKeyName = "ID";

        public static List<PhieuPhauThuatGlocom> GetListData(MDB.MDBConnection _OracleConnection, decimal maquanly)
        {
            List<PhieuPhauThuatGlocom> list = new List<PhieuPhauThuatGlocom>();
            try
            {
                string sql = @"SELECT * FROM PhieuPhauThuatGlocom where MaQuanLy = :MaQuanLy";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, _OracleConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", maquanly));
                MDB.MDBDataReader DataReader = Command.ExecuteReader();
                while (DataReader.Read())
                {
                    PhieuPhauThuatGlocom data = new PhieuPhauThuatGlocom();
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

                    data.ChanDoan = DataReader.GetInt("ChanDoan");
                    data.ChanDoan_Text = DataReader["ChanDoan_Text"].ToString();
                    data.GiaiDoanBenh = DataReader.GetInt("GiaiDoanBenh");
                    data.NgayVaoVien = Convert.ToDateTime(DataReader["NgayVaoVien"] == DBNull.Value ? DateTime.Now : DataReader["NgayVaoVien"]);
                    data.NgayPhauThuat = Convert.ToDateTime(DataReader["NgayPhauThuat"] == DBNull.Value ? DateTime.Now : DataReader["NgayPhauThuat"]);
                    data.NgayPhauThuat_Gio = data.NgayPhauThuat;
                    data.PhuongPhapPhauThuat = DataReader.GetInt("PhuongPhapPhauThuat");
                    data.LanPhauThuat = DataReader["LanPhauThuat"].ToString();

                    data.PhauThuatVienChinh = DataReader["PhauThuatVienChinh"].ToString();
                    data.MaPhauThuatVienChinh = DataReader["MaPhauThuatVienChinh"].ToString();
                    data.PhauThuatVienPhu = DataReader["PhauThuatVienPhu"].ToString();
                    data.MaPhauThuatVienPhu = DataReader["MaPhauThuatVienPhu"].ToString();
                    data.BacSyGayMe = DataReader["BacSyGayMe"].ToString();
                    data.MaBacSyGayMe = DataReader["MaBacSyGayMe"].ToString();

                    data.PhuongPhapVoCam = DataReader.GetInt("PhuongPhapVoCam");
                    data.LoaiThuocGayTe = DataReader["LoaiThuocGayTe"].ToString();
                    data.CoDinhNhanCau = DataReader.GetInt("CoDinhNhanCau");
                    data.KinhTuyen = DataReader["KinhTuyen"].ToString();
                    data.TaoVatKm = DataReader.GetInt("TaoVatKm");
                    data.TinhTrangBaoTenon = DataReader.GetInt("TinhTrangBaoTenon");
                    data.UcCheTaoXo = DataReader.GetInt("UcCheTaoXo");
                    data.UcCheTaoXo_Text = DataReader["UcCheTaoXo_Text"].ToString();
                    data.ViTri = DataReader.GetInt("ViTri");
                    data.ThoiGian = DataReader["ThoiGian"].ToString();
                    data.LangBotBaoTenon = DataReader.GetInt("LangBotBaoTenon");
                    data.CatBoCM = DataReader.GetInt("CatBoCM");
                    data.VatCMThuHai1 = DataReader["VatCMThuHai1"].ToString();
                    data.VatCMThuHai2 = DataReader["VatCMThuHai2"].ToString();
                    data.VatCMThuNhat1 = DataReader["VatCMThuNhat1"].ToString();
                    data.VatCMThuNhat2 = DataReader["VatCMThuNhat2"].ToString();
                    data.ChocTP = DataReader.GetInt("ChocTP");
                    data.CatMauBe = DataReader.GetInt("CatMauBe");
                    data.CatMongMat = DataReader.GetInt("CatMongMat");
                    data.TinhTrangTheMi = DataReader.GetInt("TinhTrangTheMi");
                    data.KhauNapCM = DataReader.GetInt("KhauNapCM");
                    data.SoMui = DataReader["SoMui"].ToString();
                    data.LoaiChi = DataReader["LoaiChi"].ToString();
                    data.TaiTaoTP = DataReader.GetInt("TaiTaoTP");
                    data.KhauKM = DataReader.GetInt("KhauKM");
                    data.KhauKM2_Text = DataReader["KhauKM2_Text"].ToString();
                    data.KhauKM3_Text = DataReader["KhauKM3_Text"].ToString();
                    data.KhauKM4_Text = DataReader["KhauKM4_Text"].ToString();
                    data.DienBienKhac = DataReader["DienBienKhac"].ToString();
                    data.TiemMat = DataReader.GetInt("TiemMat");
                    data.TiemMat_Thuoc = DataReader["TiemMat_Thuoc"].ToString();
                    data.ThuocTraMat = DataReader["ThuocTraMat"].ToString();
                    data.Bang = DataReader["Bang"].ToString();
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
                sql = @"DELETE FROM PhieuPhauThuatGlocom WHERE ID =" + IDBienBan;
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
			  FROM PhieuPhauThuatGlocom P 
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
        public static bool InsertOrUpdate(MDB.MDBConnection MyConnection, ref PhieuPhauThuatGlocom ketQua)
        {
            try
            {
                string sql = @"INSERT INTO PhieuPhauThuatGlocom
                (
                    MaQuanLy,
                    ChanDoan,
                    ChanDoan_Text,
                    GiaiDoanBenh,
                    NgayVaoVien,
                    NgayPhauThuat,
                    PhuongPhapPhauThuat,
                    LanPhauThuat,
                    PhauThuatVienChinh,
                    MaPhauThuatVienChinh,
                    PhauThuatVienPhu,
                    MaPhauThuatVienPhu,
                    BacSyGayMe,
                    MaBacSyGayMe,
                    PhuongPhapVoCam,
                    LoaiThuocGayTe,
                    CoDinhNhanCau,
                    KinhTuyen,
                    TaoVatKm,
                    TinhTrangBaoTenon,
                    UcCheTaoXo,
                    UcCheTaoXo_Text,
                    ViTri,
                    ThoiGian,
                    LangBotBaoTenon,
                    CatBoCM,
                    VatCMThuHai1,
                    VatCMThuHai2,
                    VatCMThuNhat1,
                    VatCMThuNhat2,
                    ChocTP,
                    CatMauBe,
                    CatMongMat,
                    TinhTrangTheMi,
                    KhauNapCM,
                    SoMui,
                    LoaiChi,
                    TaiTaoTP,
                    KhauKM,
                    KhauKM2_Text,
                    KhauKM3_Text,
                    KhauKM4_Text,
                    DienBienKhac,
                    TiemMat,
                    TiemMat_Thuoc,
                    ThuocTraMat,
                    Bang,
                    MaPhauThuatVien,
                    PhauThuatVien,
                    NgayLapPhieu,
                    LuocDoPhauThuat,
                    NGUOITAO,
                    NGUOISUA,
                    NGAYTAO,
                    NGAYSUA)  VALUES
                 (
				    :MaQuanLy,
                    :ChanDoan,
                    :ChanDoan_Text,
                    :GiaiDoanBenh,
                    :NgayVaoVien,
                    :NgayPhauThuat,
                    :PhuongPhapPhauThuat,
                    :LanPhauThuat,
                    :PhauThuatVienChinh,
                    :MaPhauThuatVienChinh,
                    :PhauThuatVienPhu,
                    :MaPhauThuatVienPhu,
                    :BacSyGayMe,
                    :MaBacSyGayMe,
                    :PhuongPhapVoCam,
                    :LoaiThuocGayTe,
                    :CoDinhNhanCau,
                    :KinhTuyen,
                    :TaoVatKm,
                    :TinhTrangBaoTenon,
                    :UcCheTaoXo,
                    :UcCheTaoXo_Text,
                    :ViTri,
                    :ThoiGian,
                    :LangBotBaoTenon,
                    :CatBoCM,
                    :VatCMThuHai1,
                    :VatCMThuHai2,
                    :VatCMThuNhat1,
                    :VatCMThuNhat2,
                    :ChocTP,
                    :CatMauBe,
                    :CatMongMat,
                    :TinhTrangTheMi,
                    :KhauNapCM,
                    :SoMui,
                    :LoaiChi,
                    :TaiTaoTP,
                    :KhauKM,
                    :KhauKM2_Text,
                    :KhauKM3_Text,
                    :KhauKM4_Text,
                    :DienBienKhac,
                    :TiemMat,
                    :TiemMat_Thuoc,
                    :ThuocTraMat,
                    :Bang,
                    :MaPhauThuatVien,
                    :PhauThuatVien,
                    :NgayLapPhieu,
                    :LuocDoPhauThuat,
                    :NGUOITAO,
                    :NGUOISUA,
                    :NGAYTAO,
                    :NGAYSUA
                 )  RETURNING ID INTO :ID";
                if (ketQua.ID != 0)
                {
                    sql = @"UPDATE PhieuPhauThuatGlocom SET 
                    MaQuanLy = :MaQuanLy,
                    ChanDoan = :ChanDoan,
                    ChanDoan_Text = :ChanDoan_Text,
                    GiaiDoanBenh = :GiaiDoanBenh,
                    NgayVaoVien = :NgayVaoVien,
                    NgayPhauThuat = :NgayPhauThuat,
                    PhuongPhapPhauThuat = :PhuongPhapPhauThuat,
                    LanPhauThuat = :LanPhauThuat,
                    PhauThuatVienChinh = :PhauThuatVienChinh,
                    MaPhauThuatVienChinh = :MaPhauThuatVienChinh,
                    PhauThuatVienPhu = :PhauThuatVienPhu,
                    MaPhauThuatVienPhu = :MaPhauThuatVienPhu,
                    BacSyGayMe = :BacSyGayMe,
                    MaBacSyGayMe = :MaBacSyGayMe,
                    PhuongPhapVoCam = :PhuongPhapVoCam,
                    LoaiThuocGayTe = :LoaiThuocGayTe,
                    CoDinhNhanCau = :CoDinhNhanCau,
                    KinhTuyen = :KinhTuyen,
                    TaoVatKm = :TaoVatKm,
                    TinhTrangBaoTenon = :TinhTrangBaoTenon,
                    UcCheTaoXo = :UcCheTaoXo,
                    UcCheTaoXo_Text = :UcCheTaoXo_Text,
                    ViTri = :ViTri,
                    ThoiGian = :ThoiGian,
                    LangBotBaoTenon = :LangBotBaoTenon,
                    CatBoCM = :CatBoCM,
                    VatCMThuHai1 = :VatCMThuHai1,
                    VatCMThuHai2 = :VatCMThuHai2,
                    VatCMThuNhat1 = :VatCMThuNhat1,
                    VatCMThuNhat2 = :VatCMThuNhat2,
                    ChocTP = :ChocTP,
                    CatMauBe = :CatMauBe,
                    CatMongMat = :CatMongMat,
                    TinhTrangTheMi = :TinhTrangTheMi,
                    KhauNapCM = :KhauNapCM,
                    SoMui = :SoMui,
                    LoaiChi = :LoaiChi,
                    TaiTaoTP = :TaiTaoTP,
                    KhauKM = :KhauKM,
                    KhauKM2_Text = :KhauKM2_Text,
                    KhauKM3_Text = :KhauKM3_Text,
                    KhauKM4_Text = :KhauKM4_Text,
                    DienBienKhac = :DienBienKhac,
                    TiemMat = :TiemMat,
                    TiemMat_Thuoc = :TiemMat_Thuoc,
                    ThuocTraMat = :ThuocTraMat,
                    Bang = :Bang,
                    MaPhauThuatVien = :MaPhauThuatVien,
                    PhauThuatVien = :PhauThuatVien,
                    NgayLapPhieu = :NgayLapPhieu,
                    LuocDoPhauThuat = :LuocDoPhauThuat,
                    NGUOISUA = :NGUOISUA,
                    NGAYSUA = :NGAYSUA 
                    WHERE ID = " + ketQua.ID;
                }
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);

                Command.Parameters.Add(new MDB.MDBParameter("NGUOISUA", ketQua.NguoiSua));
                Command.Parameters.Add(new MDB.MDBParameter("NGAYSUA", ketQua.NgaySua));

                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", ketQua.MaQuanLy));

                Command.Parameters.Add(new MDB.MDBParameter("ChanDoan", ketQua.ChanDoan));
                Command.Parameters.Add(new MDB.MDBParameter("ChanDoan_Text", ketQua.ChanDoan_Text));
                Command.Parameters.Add(new MDB.MDBParameter("GiaiDoanBenh", ketQua.GiaiDoanBenh));
                Command.Parameters.Add(new MDB.MDBParameter("NgayVaoVien", ketQua.NgayVaoVien));
                DateTime? Ngay = ketQua.NgayPhauThuat.HasValue ? ketQua.NgayPhauThuat.ToDateTime().Date : (DateTime?)null;
                var NgayGio = Ngay;
                if (Ngay != null)
                {
                    var Gio = ketQua.NgayPhauThuat_Gio.HasValue ? ketQua.NgayPhauThuat_Gio.Value.TimeOfDay : new TimeSpan(0, 0, 0);
                    NgayGio = Ngay + Gio;
                }
                Command.Parameters.Add(new MDB.MDBParameter("NgayPhauThuat", NgayGio));
                Command.Parameters.Add(new MDB.MDBParameter("PhuongPhapPhauThuat", ketQua.PhuongPhapPhauThuat));
                Command.Parameters.Add(new MDB.MDBParameter("LanPhauThuat", ketQua.LanPhauThuat));
                Command.Parameters.Add(new MDB.MDBParameter("PhauThuatVienChinh", ketQua.PhauThuatVienChinh));
                Command.Parameters.Add(new MDB.MDBParameter("MaPhauThuatVienChinh", ketQua.MaPhauThuatVienChinh));
                Command.Parameters.Add(new MDB.MDBParameter("PhauThuatVienPhu", ketQua.PhauThuatVienPhu));
                Command.Parameters.Add(new MDB.MDBParameter("MaPhauThuatVienPhu", ketQua.MaPhauThuatVienPhu));
                Command.Parameters.Add(new MDB.MDBParameter("BacSyGayMe", ketQua.BacSyGayMe));
                Command.Parameters.Add(new MDB.MDBParameter("MaBacSyGayMe", ketQua.MaBacSyGayMe));
                Command.Parameters.Add(new MDB.MDBParameter("PhuongPhapVoCam", ketQua.PhuongPhapVoCam));
                Command.Parameters.Add(new MDB.MDBParameter("LoaiThuocGayTe", ketQua.LoaiThuocGayTe));
                Command.Parameters.Add(new MDB.MDBParameter("CoDinhNhanCau", ketQua.CoDinhNhanCau));
                Command.Parameters.Add(new MDB.MDBParameter("KinhTuyen", ketQua.KinhTuyen));
                Command.Parameters.Add(new MDB.MDBParameter("TaoVatKm", ketQua.TaoVatKm));
                Command.Parameters.Add(new MDB.MDBParameter("TinhTrangBaoTenon", ketQua.TinhTrangBaoTenon));
                Command.Parameters.Add(new MDB.MDBParameter("UcCheTaoXo", ketQua.UcCheTaoXo));
                Command.Parameters.Add(new MDB.MDBParameter("UcCheTaoXo_Text", ketQua.UcCheTaoXo_Text));
                Command.Parameters.Add(new MDB.MDBParameter("ViTri", ketQua.ViTri));
                Command.Parameters.Add(new MDB.MDBParameter("ThoiGian", ketQua.ThoiGian));
                Command.Parameters.Add(new MDB.MDBParameter("LangBotBaoTenon", ketQua.LangBotBaoTenon));
                Command.Parameters.Add(new MDB.MDBParameter("CatBoCM", ketQua.CatBoCM));
                Command.Parameters.Add(new MDB.MDBParameter("VatCMThuHai1", ketQua.VatCMThuHai1));
                Command.Parameters.Add(new MDB.MDBParameter("VatCMThuHai2", ketQua.VatCMThuHai2));
                Command.Parameters.Add(new MDB.MDBParameter("VatCMThuNhat1", ketQua.VatCMThuNhat1));
                Command.Parameters.Add(new MDB.MDBParameter("VatCMThuNhat2", ketQua.VatCMThuNhat2));
                Command.Parameters.Add(new MDB.MDBParameter("ChocTP", ketQua.ChocTP));
                Command.Parameters.Add(new MDB.MDBParameter("CatMauBe", ketQua.CatMauBe));
                Command.Parameters.Add(new MDB.MDBParameter("CatMongMat", ketQua.CatMongMat));
                Command.Parameters.Add(new MDB.MDBParameter("TinhTrangTheMi", ketQua.TinhTrangTheMi));
                Command.Parameters.Add(new MDB.MDBParameter("KhauNapCM", ketQua.KhauNapCM));
                Command.Parameters.Add(new MDB.MDBParameter("SoMui", ketQua.SoMui));
                Command.Parameters.Add(new MDB.MDBParameter("LoaiChi", ketQua.LoaiChi));
                Command.Parameters.Add(new MDB.MDBParameter("TaiTaoTP", ketQua.TaiTaoTP));
                Command.Parameters.Add(new MDB.MDBParameter("KhauKM", ketQua.KhauKM));
                Command.Parameters.Add(new MDB.MDBParameter("KhauKM2_Text", ketQua.KhauKM2_Text));
                Command.Parameters.Add(new MDB.MDBParameter("KhauKM3_Text", ketQua.KhauKM3_Text));
                Command.Parameters.Add(new MDB.MDBParameter("KhauKM4_Text", ketQua.KhauKM4_Text));
                Command.Parameters.Add(new MDB.MDBParameter("DienBienKhac", ketQua.DienBienKhac));
                Command.Parameters.Add(new MDB.MDBParameter("TiemMat", ketQua.TiemMat));
                Command.Parameters.Add(new MDB.MDBParameter("TiemMat_Thuoc", ketQua.TiemMat_Thuoc));
                Command.Parameters.Add(new MDB.MDBParameter("ThuocTraMat", ketQua.ThuocTraMat));
                Command.Parameters.Add(new MDB.MDBParameter("Bang", ketQua.Bang));
                Command.Parameters.Add(new MDB.MDBParameter("MaPhauThuatVien", ketQua.MaPhauThuatVien));
                Command.Parameters.Add(new MDB.MDBParameter("PhauThuatVien", ketQua.PhauThuatVien));
                Command.Parameters.Add(new MDB.MDBParameter("NgayLapPhieu", ketQua.NgayLapPhieu));
                Command.Parameters.Add(new MDB.MDBParameter("LuocDoPhauThuat", ketQua.LuocDoPhauThuat));

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
                string FileHinhAnh = @"\PTGlocom\" + maQuanLy;
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
