
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
    public class PhieuPhauThuatTuiLe : ThongTinKy
    {
        public PhieuPhauThuatTuiLe()
        {
            TableName = "PhieuPhauThuatTuiLe";
            TablePrimaryKeyName = "ID";
            IDMauPhieu = (int)DanhMucPhieu.PTTL;
            TenMauPhieu = DanhMucPhieu.PTTL.Description();
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
        public bool[] PhauThuatArray { get; } = new bool[] { false, false, false, false };
        public string PhauThuat
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < PhauThuatArray.Length; i++)
                    temp += (PhauThuatArray[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        PhauThuatArray[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
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
        public string RachDa { get; set; }
        public string DuongRachDai { get; set; }
        public int TachBocLo { get; set; }
        public int CatTuiLe { get; set; }
        public int BocLoTuiLe { get; set; }
        public bool[] PPCatTuiLeArray { get; } = new bool[] { false, false };
        public string PPCatTuiLe
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < PPCatTuiLeArray.Length; i++)
                    temp += (PPCatTuiLeArray[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        PPCatTuiLeArray[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public int DotCamMau { get; set; }
        public int DatDanLuu { get; set; }
        public string BienChung { get; set; }
        public int NoiThongLeMui { get; set; }
        public bool[] TaoVatMangXuongArray { get; } = new bool[] { false, false };
        public string TaoVatMangXuong
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < TaoVatMangXuongArray.Length; i++)
                    temp += (TaoVatMangXuongArray[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        TaoVatMangXuongArray[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public string KichThuocCuaSoXuongX { get; set; }
        public string KichThuocCuaSoXuongY { get; set; }
        public bool[] KhauNoiTuiLeArray { get; } = new bool[] { false, false };
        public string KhauNoiTuiLe
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < KhauNoiTuiLeArray.Length; i++)
                    temp += (KhauNoiTuiLeArray[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        KhauNoiTuiLeArray[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public string KhauThanhSau_Text { get; set; }
        public string KhauThanhTruoc_Text { get; set; }
        public bool[] DatOngSiliconArray { get; } = new bool[] { false, false, false, false, false, false };
        public string DatOngSilicon
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < DatOngSiliconArray.Length; i++)
                    temp += (DatOngSiliconArray[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        DatOngSiliconArray[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }

        public int DatGacCamMau { get; set; }
        public int KhauPhucHoi { get; set; }
        public string KhauPhucHoi_Text { get; set; }
        public bool[] KhauDaArray { get; } = new bool[] { false, false };
        public string KhauDa
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < KhauDaArray.Length; i++)
                    temp += (KhauDaArray[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        KhauDaArray[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public string KhauDa_Text { get; set; }
        public string DienBien { get; set; }
        public string Tra { get; set; }
        public int Bang { get; set; }
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
    public class PhieuPhauThuatTuiLeFunc
    {
        public const string TableName = "PhieuPhauThuatTuiLe";
        public const string TablePrimaryKeyName = "ID";

        public static List<PhieuPhauThuatTuiLe> GetListData(MDB.MDBConnection _OracleConnection, decimal maquanly)
        {
            List<PhieuPhauThuatTuiLe> list = new List<PhieuPhauThuatTuiLe>();
            try
            {
                string sql = @"SELECT * FROM PhieuPhauThuatTuiLe where MaQuanLy = :MaQuanLy";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, _OracleConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", maquanly));
                MDB.MDBDataReader DataReader = Command.ExecuteReader();
                while (DataReader.Read())
                {
                    PhieuPhauThuatTuiLe data = new PhieuPhauThuatTuiLe();
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
                    data.PhauThuat = DataReader["PhauThuat"].ToString();

                    data.PhauThuatVienChinh = DataReader["PhauThuatVienChinh"].ToString();
                    data.MaPhauThuatVienChinh = DataReader["MaPhauThuatVienChinh"].ToString();
                    data.PhauThuatVienPhu = DataReader["PhauThuatVienPhu"].ToString();
                    data.MaPhauThuatVienPhu = DataReader["MaPhauThuatVienPhu"].ToString();
                    data.BacSyGayMe = DataReader["BacSyGayMe"].ToString();
                    data.MaBacSyGayMe = DataReader["MaBacSyGayMe"].ToString();

                    data.PhuongPhapVoCam = DataReader["PhuongPhapVoCam"].ToString();
                    data.LoaiThuocGayTe = DataReader["LoaiThuocGayTe"].ToString();
                    data.RachDa = DataReader["RachDa"].ToString();
                    data.DuongRachDai = DataReader["DuongRachDai"].ToString();
                    data.TachBocLo = DataReader.GetInt("TachBocLo");
                    data.CatTuiLe = DataReader.GetInt("CatTuiLe");
                    data.BocLoTuiLe = DataReader.GetInt("BocLoTuiLe");
                    data.PPCatTuiLe = DataReader["PPCatTuiLe"].ToString();
                    data.DotCamMau = DataReader.GetInt("DotCamMau");
                    data.DatDanLuu = DataReader.GetInt("DatDanLuu");
                    data.BienChung = DataReader["BienChung"].ToString();
                    data.NoiThongLeMui = DataReader.GetInt("NoiThongLeMui");
                    data.TaoVatMangXuong = DataReader["TaoVatMangXuong"].ToString();
                    data.KichThuocCuaSoXuongX = DataReader["KichThuocCuaSoXuongX"].ToString();
                    data.KichThuocCuaSoXuongY = DataReader["KichThuocCuaSoXuongY"].ToString();
                    data.KhauNoiTuiLe = DataReader["KhauNoiTuiLe"].ToString();
                    data.KhauThanhSau_Text = DataReader["KhauThanhSau_Text"].ToString();
                    data.KhauThanhTruoc_Text = DataReader["KhauThanhTruoc_Text"].ToString();
                    data.DatOngSilicon = DataReader["DatOngSilicon"].ToString();
                    data.DatGacCamMau = DataReader.GetInt("DatGacCamMau");
                    data.KhauPhucHoi = DataReader.GetInt("KhauPhucHoi");
                    data.KhauPhucHoi_Text = DataReader["KhauPhucHoi_Text"].ToString();
                    data.KhauDa = DataReader["KhauDa"].ToString();
                    data.KhauDa_Text = DataReader["KhauDa_Text"].ToString();
                    data.DienBien = DataReader["DienBien"].ToString();
                    data.Tra = DataReader["Tra"].ToString();
                    data.Bang = DataReader.GetInt("Bang");

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
                sql = @"DELETE FROM PhieuPhauThuatTuiLe WHERE ID =" + IDBienBan;
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
			  FROM PhieuPhauThuatTuiLe P 
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
        public static bool InsertOrUpdate(MDB.MDBConnection MyConnection, ref PhieuPhauThuatTuiLe ketQua)
        {
            try
            {
                string sql = @"INSERT INTO PhieuPhauThuatTuiLe
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
			        PhauThuat,
			        PhuongPhapVoCam,
			        LoaiThuocGayTe,
			        LuocDoPhauThuat,
			        RachDa,
			        DuongRachDai,
			        TachBocLo,
			        CatTuiLe,
			        BocLoTuiLe,
			        PPCatTuiLe,
			        DotCamMau,
			        DatDanLuu,
			        BienChung,
			        NoiThongLeMui,
			        TaoVatMangXuong,
			        KichThuocCuaSoXuongX,
			        KichThuocCuaSoXuongY,
			        KhauNoiTuiLe,
			        KhauThanhSau_Text,
			        KhauThanhTruoc_Text,
			        DatOngSilicon,
			        DatGacCamMau,
			        KhauPhucHoi,
			        KhauPhucHoi_Text,
			        KhauDa,
			        KhauDa_Text,
			        DienBien,
			        Tra,
			        Bang,
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
			        :PhauThuat,
			        :PhuongPhapVoCam,
			        :LoaiThuocGayTe,
			        :LuocDoPhauThuat,
			        :RachDa,
			        :DuongRachDai,
			        :TachBocLo,
			        :CatTuiLe,
			        :BocLoTuiLe,
			        :PPCatTuiLe,
			        :DotCamMau,
			        :DatDanLuu,
			        :BienChung,
			        :NoiThongLeMui,
			        :TaoVatMangXuong,
			        :KichThuocCuaSoXuongX,
			        :KichThuocCuaSoXuongY,
			        :KhauNoiTuiLe,
			        :KhauThanhSau_Text,
			        :KhauThanhTruoc_Text,
			        :DatOngSilicon,
			        :DatGacCamMau,
			        :KhauPhucHoi,
			        :KhauPhucHoi_Text,
			        :KhauDa,
			        :KhauDa_Text,
			        :DienBien,
			        :Tra,
			        :Bang,
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
                    sql = @"UPDATE PhieuPhauThuatTuiLe SET 
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
			        PhauThuat = :PhauThuat,
			        PhuongPhapVoCam = :PhuongPhapVoCam,
			        LoaiThuocGayTe = :LoaiThuocGayTe,
			        LuocDoPhauThuat = :LuocDoPhauThuat,
			        RachDa = :RachDa,
			        DuongRachDai = :DuongRachDai,
			        TachBocLo = :TachBocLo,
			        CatTuiLe = :CatTuiLe,
			        BocLoTuiLe = :BocLoTuiLe,
			        PPCatTuiLe = :PPCatTuiLe,
			        DotCamMau = :DotCamMau,
			        DatDanLuu = :DatDanLuu,
			        BienChung = :BienChung,
			        NoiThongLeMui = :NoiThongLeMui,
			        TaoVatMangXuong = :TaoVatMangXuong,
			        KichThuocCuaSoXuongX = :KichThuocCuaSoXuongX,
			        KichThuocCuaSoXuongY = :KichThuocCuaSoXuongY,
			        KhauNoiTuiLe = :KhauNoiTuiLe,
			        KhauThanhSau_Text = :KhauThanhSau_Text,
			        KhauThanhTruoc_Text = :KhauThanhTruoc_Text,
			        DatOngSilicon = :DatOngSilicon,
			        DatGacCamMau = :DatGacCamMau,
			        KhauPhucHoi = :KhauPhucHoi,
			        KhauPhucHoi_Text = :KhauPhucHoi_Text,
			        KhauDa = :KhauDa,
			        KhauDa_Text = :KhauDa_Text,
			        DienBien = :DienBien,
			        Tra = :Tra,
			        Bang = :Bang,
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
                Command.Parameters.Add(new MDB.MDBParameter("PhauThuat", ketQua.PhauThuat));
                Command.Parameters.Add(new MDB.MDBParameter("PhuongPhapVoCam", ketQua.PhuongPhapVoCam));
                Command.Parameters.Add(new MDB.MDBParameter("LoaiThuocGayTe", ketQua.LoaiThuocGayTe));
                Command.Parameters.Add(new MDB.MDBParameter("LuocDoPhauThuat", ketQua.LuocDoPhauThuat));
                Command.Parameters.Add(new MDB.MDBParameter("RachDa", ketQua.RachDa));
                Command.Parameters.Add(new MDB.MDBParameter("DuongRachDai", ketQua.DuongRachDai));
                Command.Parameters.Add(new MDB.MDBParameter("TachBocLo", ketQua.TachBocLo));
                Command.Parameters.Add(new MDB.MDBParameter("CatTuiLe", ketQua.CatTuiLe));
                Command.Parameters.Add(new MDB.MDBParameter("BocLoTuiLe", ketQua.BocLoTuiLe));
                Command.Parameters.Add(new MDB.MDBParameter("PPCatTuiLe", ketQua.PPCatTuiLe));
                Command.Parameters.Add(new MDB.MDBParameter("DotCamMau", ketQua.DotCamMau));
                Command.Parameters.Add(new MDB.MDBParameter("DatDanLuu", ketQua.DatDanLuu));
                Command.Parameters.Add(new MDB.MDBParameter("BienChung", ketQua.BienChung));
                Command.Parameters.Add(new MDB.MDBParameter("NoiThongLeMui", ketQua.NoiThongLeMui));
                Command.Parameters.Add(new MDB.MDBParameter("TaoVatMangXuong", ketQua.TaoVatMangXuong));
                Command.Parameters.Add(new MDB.MDBParameter("KichThuocCuaSoXuongX", ketQua.KichThuocCuaSoXuongX));
                Command.Parameters.Add(new MDB.MDBParameter("KichThuocCuaSoXuongY", ketQua.KichThuocCuaSoXuongY));
                Command.Parameters.Add(new MDB.MDBParameter("KhauNoiTuiLe", ketQua.KhauNoiTuiLe));
                Command.Parameters.Add(new MDB.MDBParameter("KhauThanhSau_Text", ketQua.KhauThanhSau_Text));
                Command.Parameters.Add(new MDB.MDBParameter("KhauThanhTruoc_Text", ketQua.KhauThanhTruoc_Text));
                Command.Parameters.Add(new MDB.MDBParameter("DatOngSilicon", ketQua.DatOngSilicon));
                Command.Parameters.Add(new MDB.MDBParameter("DatGacCamMau", ketQua.DatGacCamMau));
                Command.Parameters.Add(new MDB.MDBParameter("KhauPhucHoi", ketQua.KhauPhucHoi));
                Command.Parameters.Add(new MDB.MDBParameter("KhauPhucHoi_Text", ketQua.KhauPhucHoi_Text));
                Command.Parameters.Add(new MDB.MDBParameter("KhauDa", ketQua.KhauDa));
                Command.Parameters.Add(new MDB.MDBParameter("KhauDa_Text", ketQua.KhauDa_Text));
                Command.Parameters.Add(new MDB.MDBParameter("DienBien", ketQua.DienBien));
                Command.Parameters.Add(new MDB.MDBParameter("Tra", ketQua.Tra));
                Command.Parameters.Add(new MDB.MDBParameter("Bang", ketQua.Bang));
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
                string FileHinhAnh = @"\PTTL\" + maQuanLy;
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
