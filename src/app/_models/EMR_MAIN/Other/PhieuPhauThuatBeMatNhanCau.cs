
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
    public class PhieuPhauThuatBeMatNhanCau : ThongTinKy
    {
        public PhieuPhauThuatBeMatNhanCau()
        {
            TableName = "PhieuPhauThuatBeMatNhanCau";
            TablePrimaryKeyName = "ID";
            IDMauPhieu = (int)DanhMucPhieu.PPTBMNC;
            TenMauPhieu = DanhMucPhieu.PPTBMNC.Description();
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
        public string SoVaoVien { get; set; }
        [MoTaDuLieu("Họ và tên bệnh nhân")]
		public string TenBenhNhan { get; set; }
        [MoTaDuLieu("Tuổi bệnh nhân")]
		public string Tuoi { get; set; }
        [MoTaDuLieu("Giới tính bệnh nhân")]
		public string GioiTinh { get; set; }
        public DateTime? NgayVaoVien { get; set; }
        public DateTime? NgayPhauThuat { get; set; }
        public DateTime? NgayPhauThuat_Gio { get; set; }

        [MoTaDuLieu("Chẩn đoán trước phẫu thuật")]
		public string ChanDoanTruocPhauThuat { get; set; }
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
        public string MaPhauThuatVienChinh { get; set; }
        public string PhauThuatVienChinh { get; set; }
        public string MaPhauThuatVienPhu { get; set; }
        public string PhauThuatVienPhu { get; set; }
        public string MaBacSyGayMe { get; set; }
        public string BacSyGayMe { get; set; }
        public bool[] PhuongPhapVoCamArray { get; } = new bool[] { false, false, false };
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
        public bool[] GotToChucTonThuongArray { get; } = new bool[] { false, false };
        public string GotToChucTonThuong
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < GotToChucTonThuongArray.Length; i++)
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
                        GotToChucTonThuongArray[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public string GotKichThuoc { get; set; }
        public bool GotToanBoNC { get; set; }
        public bool[] GotDoSauArray { get; } = new bool[] { false, false, false, false };
        public string GotDoSau
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < GotDoSauArray.Length; i++)
                    temp += (GotDoSauArray[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        GotDoSauArray[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public string GotDoSau_Text { get; set; }
        public bool[] GotDacDiemArray { get; } = new bool[] { false, false };
        public string GotDacDiem
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < GotDacDiemArray.Length; i++)
                    temp += (GotDacDiemArray[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        GotDacDiemArray[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public bool[] TachDinhMiCauArray { get; } = new bool[] { false, false, false, false, false };
        public string TachDinhMiCau
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < TachDinhMiCauArray.Length; i++)
                    temp += (TachDinhMiCauArray[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        TachDinhMiCauArray[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public bool GhepMangOi { get; set; }
        public string GhepMangOiKichThuoc { get; set; }
        public bool[] ViTriGMArray { get; } = new bool[] { false, false };
        public string ViTriGM
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < ViTriGMArray.Length; i++)
                    temp += (ViTriGMArray[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        ViTriGMArray[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public bool[] ViTriCMArray { get; } = new bool[] { false, false, false, false, false };
        public string ViTriCM
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < ViTriCMArray.Length; i++)
                    temp += (ViTriCMArray[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        ViTriCMArray[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public bool[] GMOHinhThucArray { get; } = new bool[] { false, false, false, false };
        public string GMOHinhThuc
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < GMOHinhThucArray.Length; i++)
                    temp += (GMOHinhThucArray[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        GMOHinhThucArray[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public string GMOHinhThuc_Text { get; set; }
        public bool[] GhepKMRiaArray { get; } = new bool[] { false, false };
        public string GhepKMRia
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < GhepKMRiaArray.Length; i++)
                    temp += (GhepKMRiaArray[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        GhepKMRiaArray[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public string GhepKMRia_Text { get; set; }
        public bool[] ViTriGhepKMArray { get; } = new bool[] { false, false };
        public string ViTriGhepKM
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < ViTriGhepKMArray.Length; i++)
                    temp += (ViTriGhepKMArray[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        ViTriGhepKMArray[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public string ViTriGhepKMKichThuoc { get; set; }
        public bool[] KyThuatKhauArray { get; } = new bool[] { false, false };
        public string KyThuatKhau
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < KyThuatKhauArray.Length; i++)
                    temp += (KyThuatKhauArray[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        KyThuatKhauArray[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public bool[] LoaiChiKhauArray { get; } = new bool[] { false, false, false, false };
        public string LoaiChiKhau
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < LoaiChiKhauArray.Length; i++)
                    temp += (LoaiChiKhauArray[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        LoaiChiKhauArray[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public string LoaiChiKhau_Text { get; set; }
        public bool[] CoChiArray { get; } = new bool[] { false, false, false, false };
        public string CoChi
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < CoChiArray.Length; i++)
                    temp += (CoChiArray[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        CoChiArray[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public string CoChi_Text { get; set; }
        public bool[] PTPhoiHopArray { get; } = new bool[] { false, false, false, false, false, false, false, false };
        public string PTPhoiHop
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < PTPhoiHopArray.Length; i++)
                    temp += (PTPhoiHopArray[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        PTPhoiHopArray[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public string MoTa { get; set; }
        public string HinhAnhMoTa { get; set; }
        public string ThuocTiem { get; set; }
        public string ThuocTra { get; set; }
        public bool[] BangMatArray { get; } = new bool[] { false, false };
        public string BangMat
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < BangMatArray.Length; i++)
                    temp += (BangMatArray[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        BangMatArray[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }

        public string MaPhauThuatVien { get; set; }
        public string PhauThuatVien { get; set; }
        public DateTime? NgayLapPhieu { get; set; }

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
    public class PhieuPhauThuatBeMatNhanCauFunc
    {
        public const string TableName = "PhieuPhauThuatBeMatNhanCau";
        public const string TablePrimaryKeyName = "ID";

        public static List<PhieuPhauThuatBeMatNhanCau> GetListData(MDB.MDBConnection _OracleConnection, decimal maquanly)
        {
            List<PhieuPhauThuatBeMatNhanCau> list = new List<PhieuPhauThuatBeMatNhanCau>();
            try
            {
                string sql = @"SELECT * FROM PhieuPhauThuatBeMatNhanCau where MaQuanLy = :MaQuanLy";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, _OracleConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", maquanly));
                MDB.MDBDataReader DataReader = Command.ExecuteReader();
                while (DataReader.Read())
                {
                    PhieuPhauThuatBeMatNhanCau data = new PhieuPhauThuatBeMatNhanCau();
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

                    data.NgayVaoVien = Convert.ToDateTime(DataReader["NgayVaoVien"] == DBNull.Value ? DateTime.Now : DataReader["NgayVaoVien"]);
                    data.NgayPhauThuat = Convert.ToDateTime(DataReader["NgayPhauThuat"] == DBNull.Value ? DateTime.Now : DataReader["NgayPhauThuat"]);
                    data.NgayPhauThuat_Gio = data.NgayPhauThuat;

                    data.ChanDoanTruocPhauThuat = DataReader["ChanDoanTruocPhauThuat"].ToString();
                    data.ChiDinhPhauThuat = DataReader["ChiDinhPhauThuat"].ToString();
                    data.ChiDinhPhauThuat_Text = DataReader["ChiDinhPhauThuat_Text"].ToString();

                    data.PhauThuatVienChinh = DataReader["PhauThuatVienChinh"].ToString();
                    data.MaPhauThuatVienChinh = DataReader["MaPhauThuatVienChinh"].ToString();
                    data.PhauThuatVienPhu = DataReader["PhauThuatVienPhu"].ToString();
                    data.MaPhauThuatVienPhu = DataReader["MaPhauThuatVienPhu"].ToString();
                    data.BacSyGayMe = DataReader["BacSyGayMe"].ToString();
                    data.MaBacSyGayMe = DataReader["MaBacSyGayMe"].ToString();

                    data.PhuongPhapVoCam = DataReader["PhuongPhapVoCam"].ToString();
                    data.LoaiThuocGayTe = DataReader["LoaiThuocGayTe"].ToString();
                    data.LuocDoPhauThuat = DataReader["LuocDoPhauThuat"].ToString();
                    data.CoDinhMi = DataReader["CoDinhMi"].ToString();
                    data.GotToChucTonThuong = DataReader["GotToChucTonThuong"].ToString();
                    data.GotKichThuoc = DataReader["GotKichThuoc"].ToString();
                    data.GotToanBoNC = DataReader["GotToanBoNC"].ToString().Equals("1") ? true : false;

                    data.GotDoSau = DataReader["GotDoSau"].ToString();
                    data.GotDoSau_Text = DataReader["GotDoSau_Text"].ToString();
                    data.GotDacDiem = DataReader["GotDacDiem"].ToString();
                    data.TachDinhMiCau = DataReader["TachDinhMiCau"].ToString();
                    data.GhepMangOi = DataReader["GhepMangOi"].ToString().Equals("1") ? true : false;
                    data.GhepMangOiKichThuoc = DataReader["GhepMangOiKichThuoc"].ToString();
                    data.ViTriGM = DataReader["ViTriGM"].ToString();
                    data.ViTriCM = DataReader["ViTriCM"].ToString();
                    data.GMOHinhThuc = DataReader["GMOHinhThuc"].ToString();
                    data.GMOHinhThuc_Text = DataReader["GMOHinhThuc_Text"].ToString();
                    data.GhepKMRia = DataReader["GhepKMRia"].ToString();
                    data.GhepKMRia_Text = DataReader["GhepKMRia_Text"].ToString();

                    data.ViTriGhepKM = DataReader["ViTriGhepKM"].ToString();
                    data.ViTriGhepKMKichThuoc = DataReader["ViTriGhepKMKichThuoc"].ToString();
                    data.KyThuatKhau = DataReader["KyThuatKhau"].ToString();
                    data.LoaiChiKhau = DataReader["LoaiChiKhau"].ToString();
                    data.LoaiChiKhau_Text = DataReader["LoaiChiKhau_Text"].ToString();
                    data.CoChi = DataReader["CoChi"].ToString();
                    data.CoChi_Text = DataReader["CoChi_Text"].ToString();
                    data.PTPhoiHop = DataReader["PTPhoiHop"].ToString();
                    data.MoTa = DataReader["MoTa"].ToString();
                    data.ThuocTiem = DataReader["ThuocTiem"].ToString();

                    data.ThuocTra = DataReader["ThuocTra"].ToString();
                    data.BangMat = DataReader["BangMat"].ToString();
                    data.MaPhauThuatVien = DataReader["MaPhauThuatVien"].ToString();
                    data.PhauThuatVien = DataReader["PhauThuatVien"].ToString();
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
                sql = @"DELETE FROM PhieuPhauThuatBeMatNhanCau WHERE ID =" + IDBienBan;
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
			  FROM PhieuPhauThuatBeMatNhanCau P 
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
        public static bool InsertOrUpdate(MDB.MDBConnection MyConnection, ref PhieuPhauThuatBeMatNhanCau ketQua)
        {
            try
            {
                string sql = @"INSERT INTO PhieuPhauThuatBeMatNhanCau
                (
                    MaQuanLy,
                    MaBenhNhan,
                    NgayVaoVien,
                    NgayPhauThuat,
                    ChanDoanTruocPhauThuat,
                    ChiDinhPhauThuat,
                    ChiDinhPhauThuat_Text,
                    MaPhauThuatVienChinh,
                    PhauThuatVienChinh,
                    MaPhauThuatVienPhu,
                    PhauThuatVienPhu,
                    MaBacSyGayMe,
                    BacSyGayMe,
                    PhuongPhapVoCam,
                    LoaiThuocGayTe,
                    LuocDoPhauThuat,
                    CoDinhMi,
                    GotToChucTonThuong,
                    GotKichThuoc,
                    GotToanBoNC,
                    GotDoSau,
                    GotDoSau_Text,
                    GotDacDiem,
                    TachDinhMiCau,
                    GhepMangOi,
                    GhepMangOiKichThuoc,
                    ViTriGM,
                    ViTriCM,
                    GMOHinhThuc,
                    GMOHinhThuc_Text,
                    GhepKMRia,
                    GhepKMRia_Text,
                    ViTriGhepKM,
                    ViTriGhepKMKichThuoc,
                    KyThuatKhau,
                    LoaiChiKhau,
                    LoaiChiKhau_Text,
                    CoChi,
                    CoChi_Text,
                    PTPhoiHop,
                    MoTa,
                    ThuocTiem,
                    ThuocTra,
                    BangMat,
                    MaPhauThuatVien,
                    PhauThuatVien,
                    NgayLapPhieu,
                    NGUOITAO,
                    NGUOISUA,
                    NGAYTAO,
                    NGAYSUA)  VALUES
                 (
				    :MaQuanLy,
                    :MaBenhNhan,
                    :NgayVaoVien,
                    :NgayPhauThuat,
                    :ChanDoanTruocPhauThuat,
                    :ChiDinhPhauThuat,
                    :ChiDinhPhauThuat_Text,
                    :MaPhauThuatVienChinh,
                    :PhauThuatVienChinh,
                    :MaPhauThuatVienPhu,
                    :PhauThuatVienPhu,
                    :MaBacSyGayMe,
                    :BacSyGayMe,
                    :PhuongPhapVoCam,
                    :LoaiThuocGayTe,
                    :LuocDoPhauThuat,
                    :CoDinhMi,
                    :GotToChucTonThuong,
                    :GotKichThuoc,
                    :GotToanBoNC,
                    :GotDoSau,
                    :GotDoSau_Text,
                    :GotDacDiem,
                    :TachDinhMiCau,
                    :GhepMangOi,
                    :GhepMangOiKichThuoc,
                    :ViTriGM,
                    :ViTriCM,
                    :GMOHinhThuc,
                    :GMOHinhThuc_Text,
                    :GhepKMRia,
                    :GhepKMRia_Text,
                    :ViTriGhepKM,
                    :ViTriGhepKMKichThuoc,
                    :KyThuatKhau,
                    :LoaiChiKhau,
                    :LoaiChiKhau_Text,
                    :CoChi,
                    :CoChi_Text,
                    :PTPhoiHop,
                    :MoTa,
                    :ThuocTiem,
                    :ThuocTra,
                    :BangMat,
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
                    sql = @"UPDATE PhieuPhauThuatBeMatNhanCau SET 
                    MaQuanLy=:MaQuanLy,
                    MaBenhNhan=:MaBenhNhan,
                    NgayVaoVien=:NgayVaoVien,
                    NgayPhauThuat=:NgayPhauThuat,
                    ChanDoanTruocPhauThuat=:ChanDoanTruocPhauThuat,
                    ChiDinhPhauThuat=:ChiDinhPhauThuat,
                    ChiDinhPhauThuat_Text=:ChiDinhPhauThuat_Text,
                    MaPhauThuatVienChinh=:MaPhauThuatVienChinh,
                    PhauThuatVienChinh=:PhauThuatVienChinh,
                    MaPhauThuatVienPhu=:MaPhauThuatVienPhu,
                    PhauThuatVienPhu=:PhauThuatVienPhu,
                    MaBacSyGayMe=:MaBacSyGayMe,
                    BacSyGayMe=:BacSyGayMe,
                    PhuongPhapVoCam=:PhuongPhapVoCam,
                    LoaiThuocGayTe=:LoaiThuocGayTe,
                    LuocDoPhauThuat=:LuocDoPhauThuat,
                    CoDinhMi=:CoDinhMi,
                    GotToChucTonThuong=:GotToChucTonThuong,
                    GotKichThuoc=:GotKichThuoc,
                    GotToanBoNC=:GotToanBoNC,
                    GotDoSau=:GotDoSau,
                    GotDoSau_Text=:GotDoSau_Text,
                    GotDacDiem=:GotDacDiem,
                    TachDinhMiCau=:TachDinhMiCau,
                    GhepMangOi=:GhepMangOi,
                    GhepMangOiKichThuoc=:GhepMangOiKichThuoc,
                    ViTriGM=:ViTriGM,
                    ViTriCM=:ViTriCM,
                    GMOHinhThuc=:GMOHinhThuc,
                    GMOHinhThuc_Text=:GMOHinhThuc_Text,
                    GhepKMRia=:GhepKMRia,
                    GhepKMRia_Text=:GhepKMRia_Text,
                    ViTriGhepKM=:ViTriGhepKM,
                    ViTriGhepKMKichThuoc=:ViTriGhepKMKichThuoc,
                    KyThuatKhau=:KyThuatKhau,
                    LoaiChiKhau=:LoaiChiKhau,
                    LoaiChiKhau_Text=:LoaiChiKhau_Text,
                    CoChi=:CoChi,
                    CoChi_Text=:CoChi_Text,
                    PTPhoiHop=:PTPhoiHop,
                    MoTa=:MoTa,
                    ThuocTiem=:ThuocTiem,
                    ThuocTra=:ThuocTra,
                    BangMat=:BangMat,
                    MaPhauThuatVien=:MaPhauThuatVien,
                    PhauThuatVien=:PhauThuatVien,
                    NgayLapPhieu=:NgayLapPhieu,
                    NGUOISUA=:NGUOISUA,
                    NGAYSUA=:NGAYSUA
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

                Command.Parameters.Add(new MDB.MDBParameter("MaBenhNhan", ketQua.MaBenhNhan));
                Command.Parameters.Add(new MDB.MDBParameter("NgayVaoVien", ketQua.NgayVaoVien));
                Command.Parameters.Add(new MDB.MDBParameter("NgayPhauThuat", NgayGio));
                Command.Parameters.Add(new MDB.MDBParameter("ChanDoanTruocPhauThuat", ketQua.ChanDoanTruocPhauThuat));
                Command.Parameters.Add(new MDB.MDBParameter("ChiDinhPhauThuat", ketQua.ChiDinhPhauThuat));
                Command.Parameters.Add(new MDB.MDBParameter("ChiDinhPhauThuat_Text", ketQua.ChiDinhPhauThuat_Text));
                Command.Parameters.Add(new MDB.MDBParameter("MaPhauThuatVienChinh", ketQua.MaPhauThuatVienChinh));
                Command.Parameters.Add(new MDB.MDBParameter("PhauThuatVienChinh", ketQua.PhauThuatVienChinh));
                Command.Parameters.Add(new MDB.MDBParameter("MaPhauThuatVienPhu", ketQua.MaPhauThuatVienPhu));
                Command.Parameters.Add(new MDB.MDBParameter("PhauThuatVienPhu", ketQua.PhauThuatVienPhu));
                Command.Parameters.Add(new MDB.MDBParameter("MaBacSyGayMe", ketQua.MaBacSyGayMe));
                Command.Parameters.Add(new MDB.MDBParameter("BacSyGayMe", ketQua.BacSyGayMe));
                Command.Parameters.Add(new MDB.MDBParameter("PhuongPhapVoCam", ketQua.PhuongPhapVoCam));
                Command.Parameters.Add(new MDB.MDBParameter("LoaiThuocGayTe", ketQua.LoaiThuocGayTe));
                Command.Parameters.Add(new MDB.MDBParameter("LuocDoPhauThuat", ketQua.LuocDoPhauThuat));
                Command.Parameters.Add(new MDB.MDBParameter("CoDinhMi", ketQua.CoDinhMi));
                Command.Parameters.Add(new MDB.MDBParameter("GotToChucTonThuong", ketQua.GotToChucTonThuong));
                Command.Parameters.Add(new MDB.MDBParameter("GotKichThuoc", ketQua.GotKichThuoc));
                Command.Parameters.Add(new MDB.MDBParameter("GotToanBoNC", ketQua.GotToanBoNC ? 1 : 0));
                Command.Parameters.Add(new MDB.MDBParameter("GotDoSau", ketQua.GotDoSau));
                Command.Parameters.Add(new MDB.MDBParameter("GotDoSau_Text", ketQua.GotDoSau_Text));
                Command.Parameters.Add(new MDB.MDBParameter("GotDacDiem", ketQua.GotDacDiem));
                Command.Parameters.Add(new MDB.MDBParameter("TachDinhMiCau", ketQua.TachDinhMiCau));
                Command.Parameters.Add(new MDB.MDBParameter("GhepMangOi", ketQua.GhepMangOi ? 1 : 0));
                Command.Parameters.Add(new MDB.MDBParameter("GhepMangOiKichThuoc", ketQua.GhepMangOiKichThuoc));
                Command.Parameters.Add(new MDB.MDBParameter("ViTriGM", ketQua.ViTriGM));
                Command.Parameters.Add(new MDB.MDBParameter("ViTriCM", ketQua.ViTriCM));
                Command.Parameters.Add(new MDB.MDBParameter("GMOHinhThuc", ketQua.GMOHinhThuc));
                Command.Parameters.Add(new MDB.MDBParameter("GMOHinhThuc_Text", ketQua.GMOHinhThuc_Text));
                Command.Parameters.Add(new MDB.MDBParameter("GhepKMRia", ketQua.GhepKMRia));
                Command.Parameters.Add(new MDB.MDBParameter("GhepKMRia_Text", ketQua.GhepKMRia_Text));
                Command.Parameters.Add(new MDB.MDBParameter("ViTriGhepKM", ketQua.ViTriGhepKM));
                Command.Parameters.Add(new MDB.MDBParameter("ViTriGhepKMKichThuoc", ketQua.ViTriGhepKMKichThuoc));
                Command.Parameters.Add(new MDB.MDBParameter("KyThuatKhau", ketQua.KyThuatKhau));
                Command.Parameters.Add(new MDB.MDBParameter("LoaiChiKhau", ketQua.LoaiChiKhau));
                Command.Parameters.Add(new MDB.MDBParameter("LoaiChiKhau_Text", ketQua.LoaiChiKhau_Text));
                Command.Parameters.Add(new MDB.MDBParameter("CoChi", ketQua.CoChi));
                Command.Parameters.Add(new MDB.MDBParameter("CoChi_Text", ketQua.CoChi_Text));
                Command.Parameters.Add(new MDB.MDBParameter("PTPhoiHop", ketQua.PTPhoiHop));
                Command.Parameters.Add(new MDB.MDBParameter("MoTa", ketQua.MoTa));
                Command.Parameters.Add(new MDB.MDBParameter("ThuocTiem", ketQua.ThuocTiem));
                Command.Parameters.Add(new MDB.MDBParameter("ThuocTra", ketQua.ThuocTra));
                Command.Parameters.Add(new MDB.MDBParameter("BangMat", ketQua.BangMat));
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
                string FileHinhAnh = @"\PPTBMNC\" + maQuanLy;
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
