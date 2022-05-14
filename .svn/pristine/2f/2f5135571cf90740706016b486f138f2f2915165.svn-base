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
    public class PhieuPhauThuatGhepGiacMac : ThongTinKy
    {
        public PhieuPhauThuatGhepGiacMac()
        {
            TableName = "PhieuPhauThuatGhepGiacMac";
            TablePrimaryKeyName = "ID";
            IDMauPhieu = (int)DanhMucPhieu.PPTGGM;
            TenMauPhieu = DanhMucPhieu.PPTGGM.Description();
        }
        [MoTaDuLieu("Mã định danh")]
        public long ID { get; set; }
        [MoTaDuLieu("Mã quản lý: mã duy nhất trong 1 đợt khám chữa bệnh (kcb), không trùng giữa các đợt kcb khác nhau", "", 1)]
        public decimal MaQuanLy { get; set; }
        [MoTaDuLieu("Mã bệnh nhân")]
        public string MaBenhNhan { get; set; }
        [MoTaDuLieu("Mã bệnh án")]
        public string MaBenhAn { get; set; }
        public string TenBenhNhan { get; set; }
        [MoTaDuLieu("Tuổi bệnh nhân")]
        public string Tuoi { get; set; }
        [MoTaDuLieu("Giới tính bệnh nhân")]
        public string GioiTinh { get; set; }
        public DateTime? NgayVaoVien { get; set; }
        public DateTime? NgayPhauThuat { get; set; }
        public DateTime? NgayPhauThuat_Gio { get; set; }
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
        public bool[] CoDinhMi_Array { get; } = new bool[] { false, false, false };
        public string CoDinhMi
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < CoDinhMi_Array.Length; i++)
                    temp += (CoDinhMi_Array[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        CoDinhMi_Array[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public int VongCoDinhCungMac { get; set; }
        public string KichThuocVong { get; set; }
        public bool[] VCDCM_Chi_Array { get; } = new bool[] { false, false, false };
        [MoTaDuLieu("Vòng cố định củng mạc, chỉ")]
        public string VCDCM_Chi
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < VCDCM_Chi_Array.Length; i++)
                    temp += (VCDCM_Chi_Array[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        VCDCM_Chi_Array[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public bool[] VCDCM_ViTri_Array { get; } = new bool[] { false, false, false, false };
        [MoTaDuLieu("Vòng cố định củng mạc, vị trí")]
        public string VCDCM_ViTri
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < VCDCM_ViTri_Array.Length; i++)
                    temp += (VCDCM_ViTri_Array[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        VCDCM_ViTri_Array[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public bool[] MoKM_Array { get; } = new bool[] { false, false, false, false, false };
        public string MoKM
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < MoKM_Array.Length; i++)
                    temp += (MoKM_Array[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        MoKM_Array[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public int DotCamMau { get; set; }
        public bool[] ViTriManhGhep_Array { get; } = new bool[] { false, false, false, false };
        public string ViTriManhGhep
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < ViTriManhGhep_Array.Length; i++)
                    temp += (ViTriManhGhep_Array[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        ViTriManhGhep_Array[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public bool[] LoaiGhep_Array { get; } = new bool[] { false, false, false, false };
        public string LoaiGhep
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < LoaiGhep_Array.Length; i++)
                    temp += (LoaiGhep_Array[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        LoaiGhep_Array[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        [MoTaDuLieu("Đường kính khoan mảnh ghép")]
        public string DKKMG { get; set; }
        [MoTaDuLieu("Đường kính khoan GM tổn thương")]
        public string DKKGMTT { get; set; }
        public string DKKGMTT_LoaiKhoan { get; set; }
        public bool[] VaoTienPhong_Array { get; } = new bool[] { false, false, false };
        public string VaoTienPhong
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < VaoTienPhong_Array.Length; i++)
                    temp += (VaoTienPhong_Array[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        VaoTienPhong_Array[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        [MoTaDuLieu("Cắt GM tổn thương bằng kéo vannas")]
        public int CGMTTBKV { get; set; }
        public bool[] TonThuongKemTheo_Array { get; } = new bool[] { false, false, false };
        public string TonThuongKemTheo
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < TonThuongKemTheo_Array.Length; i++)
                    temp += (TonThuongKemTheo_Array[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        TonThuongKemTheo_Array[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public bool[] CachThucKhau_Array { get; } = new bool[] { false, false };
        public string CachThucKhau
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < CachThucKhau_Array.Length; i++)
                    temp += (CachThucKhau_Array[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        CachThucKhau_Array[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public bool[] LoaiChi_Array { get; } = new bool[] { false, false };
        public string LoaiChi
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < LoaiChi_Array.Length; i++)
                    temp += (LoaiChi_Array[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        LoaiChi_Array[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public string LoaiChi_Khac { get; set; }
        public bool[] TaoHinhMongMat_Array { get; } = new bool[] { false, false, false };
        public string TaoHinhMongMat
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < TaoHinhMongMat_Array.Length; i++)
                    temp += (TaoHinhMongMat_Array[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        TaoHinhMongMat_Array[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public bool[] CatBe_Array { get; } = new bool[] { false, false };
        public string CatBe
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < CatBe_Array.Length; i++)
                    temp += (CatBe_Array[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        CatBe_Array[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public bool[] LayT3_Array { get; } = new bool[] { false, false, false };
        public string LayT3
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < LayT3_Array.Length; i++)
                    temp += (LayT3_Array[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        LayT3_Array[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public bool[] ViTriIOL_Array { get; } = new bool[] { false, false, false };
        public string ViTriIOL
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < ViTriIOL_Array.Length; i++)
                    temp += (ViTriIOL_Array[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        ViTriIOL_Array[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public bool[] CatDichKinh_Array { get; } = new bool[] { false, false, false, false };
        public string CatDichKinh
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < CatDichKinh_Array.Length; i++)
                    temp += (CatDichKinh_Array[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        CatDichKinh_Array[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public string MoTa { get; set; }
        public string ThuocTiem { get; set; }
        public string PhauThuatVien { get; set; }
        public string MaPhauThuatVien { get; set; }

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
    public class PhieuPhauThuatGhepGiacMacFunc
    {
        public const string TableName = "PhieuPhauThuatGhepGiacMac";
        public const string TablePrimaryKeyName = "ID";
        public static List<PhieuPhauThuatGhepGiacMac> GetListData(MDB.MDBConnection _OracleConnection, decimal maquanly)
        {
            List<PhieuPhauThuatGhepGiacMac> list = new List<PhieuPhauThuatGhepGiacMac>();
            try
            {
                string sql = @"SELECT * FROM PhieuPhauThuatGhepGiacMac where MaQuanLy = :MaQuanLy";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, _OracleConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", maquanly));
                MDB.MDBDataReader DataReader = Command.ExecuteReader();
                while (DataReader.Read())
                {
                    PhieuPhauThuatGhepGiacMac data = new PhieuPhauThuatGhepGiacMac();
                    data.ID = Convert.ToInt64(DataReader.GetLong("ID").ToString());
                    data.MaQuanLy = maquanly;
                    data.MaBenhNhan = XemBenhAn._HanhChinhBenhNhan.MaBenhNhan;
                    data.MaBenhAn = XemBenhAn._ThongTinDieuTri.MaBenhAn;
                    data.TenBenhNhan = XemBenhAn._HanhChinhBenhNhan.TenBenhNhan;
                    data.Tuoi = XemBenhAn._HanhChinhBenhNhan.Tuoi;
                    data.GioiTinh = XemBenhAn._HanhChinhBenhNhan.GioiTinh.Description();

                    data.NgayVaoVien = DataReader["NgayVaoVien"] != DBNull.Value ? (DateTime?) Convert.ToDateTime(DataReader["NgayVaoVien"].ToString()): null;
                    data.NgayPhauThuat = DataReader["NgayPhauThuat"] != DBNull.Value ? (DateTime?)Convert.ToDateTime(DataReader["NgayPhauThuat"].ToString()) : null;
                    data.NgayPhauThuat_Gio = data.NgayPhauThuat;
                    data.ChanDoanTruocPhauThuat = DataReader["ChanDoanTruocPhauThuat"].ToString();
                    data.ChiDinhPhauThuat = DataReader["ChiDinhPhauThuat"].ToString();
                    data.ChiDinhPhauThuat_Text = DataReader["ChiDinhPhauThuat_Text"].ToString();
                    data.MaPhauThuatVienChinh = DataReader["MaPhauThuatVienChinh"].ToString();
                    data.PhauThuatVienChinh = DataReader["PhauThuatVienChinh"].ToString();
                    data.MaPhauThuatVienPhu = DataReader["MaPhauThuatVienPhu"].ToString();
                    data.PhauThuatVienPhu = DataReader["PhauThuatVienPhu"].ToString();
                    data.MaBacSyGayMe = DataReader["MaBacSyGayMe"].ToString();
                    data.BacSyGayMe = DataReader["BacSyGayMe"].ToString();
                    data.PhauThuat = DataReader["PhauThuat"].ToString();
                    data.PhuongPhapVoCam = DataReader["PhuongPhapVoCam"].ToString();
                    data.LoaiThuocGayTe = DataReader["LoaiThuocGayTe"].ToString();
                    data.LuocDoPhauThuat = DataReader["LuocDoPhauThuat"].ToString();
                    data.CoDinhMi = DataReader["CoDinhMi"].ToString();
                    data.VongCoDinhCungMac = DataReader.GetInt("VongCoDinhCungMac");
                    data.KichThuocVong = DataReader["KichThuocVong"].ToString();
                    data.VCDCM_Chi = DataReader["VCDCM_Chi"].ToString();
                    data.VCDCM_ViTri = DataReader["VCDCM_ViTri"].ToString();
                    data.MoKM = DataReader["MoKM"].ToString();
                    data.DotCamMau = DataReader.GetInt("DotCamMau");
                    data.ViTriManhGhep = DataReader["ViTriManhGhep"].ToString();
                    data.LoaiGhep = DataReader["LoaiGhep"].ToString();
                    data.DKKMG = DataReader["DKKMG"].ToString();
                    data.DKKGMTT = DataReader["DKKGMTT"].ToString();
                    data.DKKGMTT_LoaiKhoan = DataReader["DKKGMTT_LoaiKhoan"].ToString();
                    data.VaoTienPhong = DataReader["VaoTienPhong"].ToString();
                    data.CGMTTBKV = DataReader.GetInt("CGMTTBKV");
                    data.TonThuongKemTheo = DataReader["TonThuongKemTheo"].ToString();
                    data.CachThucKhau = DataReader["CachThucKhau"].ToString();
                    data.LoaiChi = DataReader["LoaiChi"].ToString();
                    data.LoaiChi_Khac = DataReader["LoaiChi_Khac"].ToString();
                    data.TaoHinhMongMat = DataReader["TaoHinhMongMat"].ToString();
                    data.CatBe = DataReader["CatBe"].ToString();
                    data.LayT3 = DataReader["LayT3"].ToString();
                    data.ViTriIOL = DataReader["ViTriIOL"].ToString();
                    data.CatDichKinh = DataReader["CatDichKinh"].ToString();
                    data.MoTa = DataReader["MoTa"].ToString();
                    data.ThuocTiem = DataReader["ThuocTiem"].ToString();
                    data.PhauThuatVien = DataReader["PhauThuatVien"].ToString();
                    data.MaPhauThuatVien = DataReader["MaPhauThuatVien"].ToString();

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
                sql = @"DELETE FROM PhieuPhauThuatGhepGiacMac WHERE ID =" + IDBienBan;
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
			  FROM PhieuPhauThuatGhepGiacMac P 
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
        public static bool InsertOrUpdate(MDB.MDBConnection MyConnection, ref PhieuPhauThuatGhepGiacMac ketQua)
        {
            try
            {
                string sql = @"INSERT INTO PhieuPhauThuatGhepGiacMac
                (
                    MaQuanLy,
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
                    PhauThuat,
                    PhuongPhapVoCam,
                    LoaiThuocGayTe,
                    LuocDoPhauThuat,
                    CoDinhMi,
                    VongCoDinhCungMac,
                    KichThuocVong,
                    VCDCM_Chi,
                    VCDCM_ViTri,
                    MoKM,
                    DotCamMau,
                    ViTriManhGhep,
                    LoaiGhep,
                    DKKMG,
                    DKKGMTT,
                    DKKGMTT_LoaiKhoan,
                    VaoTienPhong,
                    CGMTTBKV,
                    TonThuongKemTheo,
                    CachThucKhau,
                    LoaiChi,
                    LoaiChi_Khac,
                    TaoHinhMongMat,
                    CatBe,
                    LayT3,
                    ViTriIOL,
                    CatDichKinh,
                    MoTa,
                    ThuocTiem,
                    PhauThuatVien,
                    MaPhauThuatVien,
                    NGUOITAO,
                    NGUOISUA,
                    NGAYTAO,
                    NGAYSUA)  VALUES
                 (
				    :MaQuanLy,
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
                    :PhauThuat,
                    :PhuongPhapVoCam,
                    :LoaiThuocGayTe,
                    :LuocDoPhauThuat,
                    :CoDinhMi,
                    :VongCoDinhCungMac,
                    :KichThuocVong,
                    :VCDCM_Chi,
                    :VCDCM_ViTri,
                    :MoKM,
                    :DotCamMau,
                    :ViTriManhGhep,
                    :LoaiGhep,
                    :DKKMG,
                    :DKKGMTT,
                    :DKKGMTT_LoaiKhoan,
                    :VaoTienPhong,
                    :CGMTTBKV,
                    :TonThuongKemTheo,
                    :CachThucKhau,
                    :LoaiChi,
                    :LoaiChi_Khac,
                    :TaoHinhMongMat,
                    :CatBe,
                    :LayT3,
                    :ViTriIOL,
                    :CatDichKinh,
                    :MoTa,
                    :ThuocTiem,
                    :PhauThuatVien,
                    :MaPhauThuatVien,
                    :NGUOITAO,
                    :NGUOISUA,
                    :NGAYTAO,
                    :NGAYSUA
                 )  RETURNING ID INTO :ID";
                if (ketQua.ID != 0)
                {
                    sql = @"UPDATE PhieuPhauThuatGhepGiacMac SET 
                    MaQuanLy = :MaQuanLy,
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
                    PhauThuat=:PhauThuat,
                    PhuongPhapVoCam=:PhuongPhapVoCam,
                    LoaiThuocGayTe=:LoaiThuocGayTe,
                    LuocDoPhauThuat=:LuocDoPhauThuat,
                    CoDinhMi=:CoDinhMi,
                    VongCoDinhCungMac=:VongCoDinhCungMac,
                    KichThuocVong=:KichThuocVong,
                    VCDCM_Chi=:VCDCM_Chi,
                    VCDCM_ViTri=:VCDCM_ViTri,
                    MoKM=:MoKM,
                    DotCamMau=:DotCamMau,
                    ViTriManhGhep=:ViTriManhGhep,
                    LoaiGhep=:LoaiGhep,
                    DKKMG=:DKKMG,
                    DKKGMTT=:DKKGMTT,
                    DKKGMTT_LoaiKhoan=:DKKGMTT_LoaiKhoan,
                    VaoTienPhong=:VaoTienPhong,
                    CGMTTBKV=:CGMTTBKV,
                    TonThuongKemTheo=:TonThuongKemTheo,
                    CachThucKhau=:CachThucKhau,
                    LoaiChi=:LoaiChi,
                    LoaiChi_Khac=:LoaiChi_Khac,
                    TaoHinhMongMat=:TaoHinhMongMat,
                    CatBe=:CatBe,
                    LayT3=:LayT3,
                    ViTriIOL=:ViTriIOL,
                    CatDichKinh=:CatDichKinh,
                    MoTa=:MoTa,
                    ThuocTiem=:ThuocTiem,
                    PhauThuatVien = :PhauThuatVien,
                    MaPhauThuatVien = :MaPhauThuatVien,
                    NGUOISUA = :NGUOISUA,
                    NGAYSUA = :NGAYSUA 
                    WHERE ID = " + ketQua.ID;
                }
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);

                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", ketQua.MaQuanLy));
                DateTime? Ngay = ketQua.NgayPhauThuat.HasValue ? ketQua.NgayPhauThuat.ToDateTime().Date : (DateTime?)null;
                var NgayGio = Ngay;
                if (Ngay != null)
                {
                    var Gio = ketQua.NgayPhauThuat_Gio.HasValue ? ketQua.NgayPhauThuat_Gio.Value.TimeOfDay : new TimeSpan(0, 0, 0);
                    NgayGio = Ngay + Gio;
                }
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
                Command.Parameters.Add(new MDB.MDBParameter("PhauThuat", ketQua.PhauThuat));
                Command.Parameters.Add(new MDB.MDBParameter("PhuongPhapVoCam", ketQua.PhuongPhapVoCam));
                Command.Parameters.Add(new MDB.MDBParameter("LoaiThuocGayTe", ketQua.LoaiThuocGayTe));
                Command.Parameters.Add(new MDB.MDBParameter("LuocDoPhauThuat", ketQua.LuocDoPhauThuat));
                Command.Parameters.Add(new MDB.MDBParameter("CoDinhMi", ketQua.CoDinhMi));
                Command.Parameters.Add(new MDB.MDBParameter("VongCoDinhCungMac", ketQua.VongCoDinhCungMac));
                Command.Parameters.Add(new MDB.MDBParameter("KichThuocVong", ketQua.KichThuocVong));
                Command.Parameters.Add(new MDB.MDBParameter("VCDCM_Chi", ketQua.VCDCM_Chi));
                Command.Parameters.Add(new MDB.MDBParameter("VCDCM_ViTri", ketQua.VCDCM_ViTri));
                Command.Parameters.Add(new MDB.MDBParameter("MoKM", ketQua.MoKM));
                Command.Parameters.Add(new MDB.MDBParameter("DotCamMau", ketQua.DotCamMau));
                Command.Parameters.Add(new MDB.MDBParameter("ViTriManhGhep", ketQua.ViTriManhGhep));
                Command.Parameters.Add(new MDB.MDBParameter("LoaiGhep", ketQua.LoaiGhep));
                Command.Parameters.Add(new MDB.MDBParameter("DKKMG", ketQua.DKKMG));
                Command.Parameters.Add(new MDB.MDBParameter("DKKGMTT", ketQua.DKKGMTT));
                Command.Parameters.Add(new MDB.MDBParameter("DKKGMTT_LoaiKhoan", ketQua.DKKGMTT_LoaiKhoan));
                Command.Parameters.Add(new MDB.MDBParameter("VaoTienPhong", ketQua.VaoTienPhong));
                Command.Parameters.Add(new MDB.MDBParameter("CGMTTBKV", ketQua.CGMTTBKV));
                Command.Parameters.Add(new MDB.MDBParameter("TonThuongKemTheo", ketQua.TonThuongKemTheo));
                Command.Parameters.Add(new MDB.MDBParameter("CachThucKhau", ketQua.CachThucKhau));
                Command.Parameters.Add(new MDB.MDBParameter("LoaiChi", ketQua.LoaiChi));
                Command.Parameters.Add(new MDB.MDBParameter("LoaiChi_Khac", ketQua.LoaiChi_Khac));
                Command.Parameters.Add(new MDB.MDBParameter("TaoHinhMongMat", ketQua.TaoHinhMongMat));
                Command.Parameters.Add(new MDB.MDBParameter("CatBe", ketQua.CatBe));
                Command.Parameters.Add(new MDB.MDBParameter("LayT3", ketQua.LayT3));
                Command.Parameters.Add(new MDB.MDBParameter("ViTriIOL", ketQua.ViTriIOL));
                Command.Parameters.Add(new MDB.MDBParameter("CatDichKinh", ketQua.CatDichKinh));
                Command.Parameters.Add(new MDB.MDBParameter("MoTa", ketQua.MoTa));
                Command.Parameters.Add(new MDB.MDBParameter("ThuocTiem", ketQua.ThuocTiem));
                Command.Parameters.Add(new MDB.MDBParameter("PhauThuatVien", ketQua.PhauThuatVien));
                Command.Parameters.Add(new MDB.MDBParameter("MaPhauThuatVien", ketQua.MaPhauThuatVien));

                Command.Parameters.Add(new MDB.MDBParameter("NGUOISUA", ketQua.NguoiSua));
                Command.Parameters.Add(new MDB.MDBParameter("NGAYSUA", ketQua.NgaySua));
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
                string FileHinhAnh = @"\PTGGM\" + maQuanLy;
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
