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
    public class PhieuPhauThuatSupMi : ThongTinKy
    {
        public PhieuPhauThuatSupMi()
        {
            TableName = "PhieuPhauThuatSupMi";
            TablePrimaryKeyName = "ID";
            IDMauPhieu = (int)DanhMucPhieu.PTSM;
            TenMauPhieu = DanhMucPhieu.PTSM.Description();
        }
        [MoTaDuLieu("Mã định danh")]
		public long ID { get; set; }
        [MoTaDuLieu("Mã quản lý: mã duy nhất trong 1 đợt khám chữa bệnh (kcb), không trùng giữa các đợt kcb khác nhau","",1)]
		public decimal MaQuanLy { get; set; }
        [MoTaDuLieu("Mã bệnh nhân")]
		public string MaBenhNhan { get; set; }
        [MoTaDuLieu("Mã bệnh án")]
		public string MaBenhAn { get; set; }
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
        public bool[] CachThucPhauThuatArray { get; } = new bool[] { false, false };
        public string CachThucPhauThuat
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < CachThucPhauThuatArray.Length; i++)
                    temp += (CachThucPhauThuatArray[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        CachThucPhauThuatArray[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public string CachThucPhauThuat_Text;
        public string PhauThuatVienChinh { get; set; }
        public string MaPhauThuatVienChinh { get; set; }
        public string PhauThuatVienPhu { get; set; }
        public string MaPhauThuatVienPhu { get; set; }
        public string BacSyGayMe { get; set; }
        public string MaBacSyGayMe { get; set; }
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
        public string LoaiThuocTe { get; set; }
        public string RutNganCo { get; set; }
        public string TreoCoTran { get; set; }
        public bool[] TrinhTu1Array { get; } = new bool[] { false, false };
        public string TrinhTu1
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < TrinhTu1Array.Length; i++)
                    temp += (TrinhTu1Array[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        TrinhTu1Array[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public string CoDinhMi1 { get; set; }
        public string RachDaMi1_Text { get; set; }
        public string CatVatDa { get; set; }
        public string BocLoCo { get; set; }
        public bool KhauCoNang { get; set; }
        public string KhauCoNang_Text { get; set; }
        public string CatMauCo { get; set; }
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
        public string KhauDaMi_Chi { get; set; }
        public bool[] TraMat1Array { get; } = new bool[] { false, false };
        public string TraMat1
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < TraMat1Array.Length; i++)
                    temp += (TraMat1Array[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        TraMat1Array[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public bool[] BangMat1Array { get; } = new bool[] { false, false, false };
        public string BangMat1
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < BangMat1Array.Length; i++)
                    temp += (BangMat1Array[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        BangMat1Array[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public bool[] TrinhTu2Array { get; } = new bool[] { false, false };
        public string TrinhTu2
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < TrinhTu2Array.Length; i++)
                    temp += (TrinhTu2Array[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        TrinhTu2Array[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public string CoDinhMi2 { get; set; }
        public string RachDaMi2_Text { get; set; }
        public bool[] RachDaMi2Array { get; } = new bool[] { false, false };
        public string RachDaMi2
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < RachDaMi2Array.Length; i++)
                    temp += (RachDaMi2Array[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        RachDaMi2Array[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public bool RachDaTrenCungMay { get; set; }
        public bool RachDaGiuaCungMay { get; set; }
        public bool QuaCacDiem { get; set; }
        public string QuaCacDiem_Chi { get; set; }
        public bool BuocChi { get; set; }
        public bool[] KhauDaTranArray { get; } = new bool[] { false, false };
        public string KhauDaTran
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < KhauDaTranArray.Length; i++)
                    temp += (KhauDaTranArray[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        KhauDaTranArray[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public string BatThuong { get; set; }
        public bool[] TraMat2Array { get; } = new bool[] { false, false };
        public string TraMat2
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < TraMat2Array.Length; i++)
                    temp += (TraMat2Array[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        TraMat2Array[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public bool[] BangMat2Array { get; } = new bool[] { false, false, false };
        public string BangMat2
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < BangMat2Array.Length; i++)
                    temp += (BangMat2Array[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        BangMat2Array[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public string PhauThuatVien { get; set; }
        public string MaPhauThuatVien { get; set; }
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

    public class PhieuPhauThuatSupMiFunc
    {
        public const string TableName = "PhieuPhauThuatSupMi";
        public const string TablePrimaryKeyName = "ID";
        public static List<PhieuPhauThuatSupMi> GetListData(MDB.MDBConnection _OracleConnection, decimal maquanly)
        {
            List<PhieuPhauThuatSupMi> list = new List<PhieuPhauThuatSupMi>();
            try
            {
                string sql = @"SELECT * FROM PhieuPhauThuatSupMi where MaQuanLy = :MaQuanLy";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, _OracleConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", maquanly));
                MDB.MDBDataReader DataReader = Command.ExecuteReader();
                while (DataReader.Read())
                {
                    PhieuPhauThuatSupMi data = new PhieuPhauThuatSupMi();
                    data.ID = Convert.ToInt64(DataReader.GetLong("ID").ToString());
                    data.MaQuanLy = maquanly;

                    data.MaBenhNhan = XemBenhAn._HanhChinhBenhNhan.MaBenhNhan;
                    data.MaBenhAn = XemBenhAn._ThongTinDieuTri.MaBenhAn;
                    data.TenBenhNhan = XemBenhAn._HanhChinhBenhNhan.TenBenhNhan;
                    data.Tuoi = XemBenhAn._HanhChinhBenhNhan.Tuoi;
                    data.GioiTinh = XemBenhAn._HanhChinhBenhNhan.GioiTinh.Description();
                    data.NgayVaoVien = DataReader["NgayVaoVien"] != DBNull.Value ? (DateTime?) Convert.ToDateTime(DataReader["NgayVaoVien"]) : null;
                    data.NgayPhauThuat = DataReader["NgayPhauThuat"] != DBNull.Value ? (DateTime?)Convert.ToDateTime(DataReader["NgayPhauThuat"]) : null;
                    data.NgayPhauThuat_Gio = data.NgayPhauThuat;
                    data.ChanDoanTruocPhauThuat = DataReader["ChanDoanTruocPhauThuat"].ToString();
                    data.CachThucPhauThuat = DataReader["CachThucPhauThuat"].ToString();
                    data.CachThucPhauThuat_Text = DataReader["CachThucPhauThuat_Text"].ToString();
                    data.PhauThuatVienChinh = DataReader["PhauThuatVienChinh"].ToString();
                    data.MaPhauThuatVienChinh = DataReader["MaPhauThuatVienChinh"].ToString();
                    data.PhauThuatVienPhu = DataReader["PhauThuatVienPhu"].ToString();
                    data.MaPhauThuatVienPhu = DataReader["MaPhauThuatVienPhu"].ToString();
                    data.BacSyGayMe = DataReader["BacSyGayMe"].ToString();
                    data.MaBacSyGayMe = DataReader["MaBacSyGayMe"].ToString();
                    data.PhuongPhapVoCam = DataReader["PhuongPhapVoCam"].ToString();
                    data.LoaiThuocTe = DataReader["LoaiThuocTe"].ToString();
                    data.RutNganCo = DataReader["RutNganCo"].ToString();
                    data.TreoCoTran = DataReader["TreoCoTran"].ToString();
                    data.TrinhTu1 = DataReader["TrinhTu1"].ToString();
                    data.CoDinhMi1 = DataReader["CoDinhMi1"].ToString();
                    data.RachDaMi1_Text = DataReader["RachDaMi1_Text"].ToString();
                    data.CatVatDa = DataReader["CatVatDa"].ToString();
                    data.BocLoCo = DataReader["BocLoCo"].ToString();
                    data.KhauCoNang = DataReader["KhauCoNang"].ToString().Equals("1") ? true : false;
                    data.KhauCoNang_Text = DataReader["KhauCoNang_Text"].ToString();
                    data.CatMauCo = DataReader["CatMauCo"].ToString();
                    data.KhauDaMi = DataReader["KhauDaMi"].ToString();
                    data.KhauDaMi_Chi = DataReader["KhauDaMi_Chi"].ToString();
                    data.TraMat1 = DataReader["TraMat1"].ToString();
                    data.BangMat1 = DataReader["BangMat1"].ToString();
                    data.TrinhTu2 = DataReader["TrinhTu2"].ToString();
                    data.CoDinhMi2 = DataReader["CoDinhMi2"].ToString();
                    data.RachDaMi2_Text = DataReader["RachDaMi2_Text"].ToString();
                    data.RachDaMi2 = DataReader["RachDaMi2"].ToString();
                    data.RachDaTrenCungMay = DataReader["RachDaTrenCungMay"].ToString().Equals("1") ? true: false;
                    data.RachDaGiuaCungMay = DataReader["RachDaGiuaCungMay"].ToString().Equals("1") ? true : false;
                    data.QuaCacDiem = DataReader["QuaCacDiem"].ToString().Equals("1") ? true : false;
                    data.QuaCacDiem_Chi = DataReader["QuaCacDiem_Chi"].ToString();
                    data.BuocChi = DataReader["BuocChi"].ToString().Equals("1") ? true : false;
                    data.KhauDaTran = DataReader["KhauDaTran"].ToString();
                    data.BatThuong = DataReader["BatThuong"].ToString();
                    data.TraMat2 = DataReader["TraMat2"].ToString();
                    data.BangMat2 = DataReader["BangMat2"].ToString();
                    data.PhauThuatVien = DataReader["PhauThuatVien"].ToString();
                    data.MaPhauThuatVien = DataReader["MaPhauThuatVien"].ToString();
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
        public static bool InsertOrUpdate(MDB.MDBConnection MyConnection, ref PhieuPhauThuatSupMi ketQua)
        {
            try
            {
                string sql = @"INSERT INTO PhieuPhauThuatSupMi
                (
                    MaQuanLy,
                    MaBenhNhan,
                    NgayVaoVien,
                    NgayPhauThuat,
                    ChanDoanTruocPhauThuat,
                    CachThucPhauThuat,
                    CachThucPhauThuat_Text,
                    PhauThuatVienChinh,
                    MaPhauThuatVienChinh,
                    PhauThuatVienPhu,
                    MaPhauThuatVienPhu,
                    BacSyGayMe,
                    MaBacSyGayMe,
                    PhuongPhapVoCam,
                    LoaiThuocTe,
                    RutNganCo,
                    TreoCoTran,
                    TrinhTu1,
                    CoDinhMi1,
                    RachDaMi1_Text,
                    CatVatDa,
                    BocLoCo,
                    KhauCoNang,
                    KhauCoNang_Text,
                    CatMauCo,
                    KhauDaMi,
                    KhauDaMi_Chi,
                    TraMat1,
                    BangMat1,
                    TrinhTu2,
                    CoDinhMi2,
                    RachDaMi2_Text,
                    RachDaMi2,
                    RachDaTrenCungMay,
                    RachDaGiuaCungMay,
                    QuaCacDiem,
                    QuaCacDiem_Chi,
                    BuocChi,
                    KhauDaTran,
                    BatThuong,
                    TraMat2,
                    BangMat2,
                    PhauThuatVien,
                    MaPhauThuatVien,
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
                    :CachThucPhauThuat,
                    :CachThucPhauThuat_Text,
                    :PhauThuatVienChinh,
                    :MaPhauThuatVienChinh,
                    :PhauThuatVienPhu,
                    :MaPhauThuatVienPhu,
                    :BacSyGayMe,
                    :MaBacSyGayMe,
                    :PhuongPhapVoCam,
                    :LoaiThuocTe,
                    :RutNganCo,
                    :TreoCoTran,
                    :TrinhTu1,
                    :CoDinhMi1,
                    :RachDaMi1_Text,
                    :CatVatDa,
                    :BocLoCo,
                    :KhauCoNang,
                    :KhauCoNang_Text,
                    :CatMauCo,
                    :KhauDaMi,
                    :KhauDaMi_Chi,
                    :TraMat1,
                    :BangMat1,
                    :TrinhTu2,
                    :CoDinhMi2,
                    :RachDaMi2_Text,
                    :RachDaMi2,
                    :RachDaTrenCungMay,
                    :RachDaGiuaCungMay,
                    :QuaCacDiem,
                    :QuaCacDiem_Chi,
                    :BuocChi,
                    :KhauDaTran,
                    :BatThuong,
                    :TraMat2,
                    :BangMat2,
                    :PhauThuatVien,
                    :MaPhauThuatVien,
                    :NGUOITAO,
                    :NGUOISUA,
                    :NGAYTAO,
                    :NGAYSUA
                 )  RETURNING ID INTO :ID";
                if (ketQua.ID != 0)
                {
                    sql = @"UPDATE PhieuPhauThuatSupMi SET 
                    MaQuanLy = :MaQuanLy,
                    MaBenhNhan = :MaBenhNhan,
                    NgayVaoVien = :NgayVaoVien,
                    NgayPhauThuat = :NgayPhauThuat,
                    ChanDoanTruocPhauThuat = :ChanDoanTruocPhauThuat,
                    CachThucPhauThuat = :CachThucPhauThuat,
                    CachThucPhauThuat_Text = :CachThucPhauThuat_Text,
                    PhauThuatVienChinh = :PhauThuatVienChinh,
                    MaPhauThuatVienChinh = :MaPhauThuatVienChinh,
                    PhauThuatVienPhu = :PhauThuatVienPhu,
                    MaPhauThuatVienPhu = :MaPhauThuatVienPhu,
                    BacSyGayMe = :BacSyGayMe,
                    MaBacSyGayMe = :MaBacSyGayMe,
                    PhuongPhapVoCam = :PhuongPhapVoCam,
                    LoaiThuocTe = :LoaiThuocTe,
                    RutNganCo = :RutNganCo,
                    TreoCoTran = :TreoCoTran,
                    TrinhTu1 = :TrinhTu1,
                    CoDinhMi1 = :CoDinhMi1,
                    RachDaMi1_Text = :RachDaMi1_Text,
                    CatVatDa = :CatVatDa,
                    BocLoCo = :BocLoCo,
                    KhauCoNang = :KhauCoNang,
                    KhauCoNang_Text = :KhauCoNang_Text,
                    CatMauCo = :CatMauCo,
                    KhauDaMi = :KhauDaMi,
                    KhauDaMi_Chi = :KhauDaMi_Chi,
                    TraMat1 = :TraMat1,
                    BangMat1 = :BangMat1,
                    TrinhTu2 = :TrinhTu2,
                    CoDinhMi2 = :CoDinhMi2,
                    RachDaMi2_Text = :RachDaMi2_Text,
                    RachDaMi2 = :RachDaMi2,
                    RachDaTrenCungMay = :RachDaTrenCungMay,
                    RachDaGiuaCungMay = :RachDaGiuaCungMay,
                    QuaCacDiem = :QuaCacDiem,
                    QuaCacDiem_Chi = :QuaCacDiem_Chi,
                    BuocChi = :BuocChi,
                    KhauDaTran = :KhauDaTran,
                    BatThuong = :BatThuong,
                    TraMat2 = :TraMat2,
                    BangMat2 = :BangMat2,
                    PhauThuatVien = :PhauThuatVien,
                    MaPhauThuatVien = :MaPhauThuatVien,
                    NGUOISUA = :NGUOISUA,
                    NGAYSUA = :NGAYSUA 
                    WHERE ID = " + ketQua.ID;
                }
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", ketQua.MaQuanLy));
                Command.Parameters.Add(new MDB.MDBParameter("MaBenhNhan", ketQua.MaBenhNhan));
                Command.Parameters.Add(new MDB.MDBParameter("NgayVaoVien", ketQua.NgayVaoVien));
                DateTime? Ngay = ketQua.NgayPhauThuat.HasValue ? ketQua.NgayPhauThuat.ToDateTime().Date : (DateTime?)null;
                var NgayGio = Ngay;
                if (Ngay != null)
                {
                    var Gio = ketQua.NgayPhauThuat_Gio.HasValue ? ketQua.NgayPhauThuat_Gio.Value.TimeOfDay : new TimeSpan(0, 0, 0);
                    NgayGio = Ngay + Gio;
                }
                Command.Parameters.Add(new MDB.MDBParameter("NgayPhauThuat", NgayGio));
                Command.Parameters.Add(new MDB.MDBParameter("ChanDoanTruocPhauThuat", ketQua.ChanDoanTruocPhauThuat));
                Command.Parameters.Add(new MDB.MDBParameter("CachThucPhauThuat", ketQua.CachThucPhauThuat));
                Command.Parameters.Add(new MDB.MDBParameter("CachThucPhauThuat_Text", ketQua.CachThucPhauThuat_Text));
                Command.Parameters.Add(new MDB.MDBParameter("PhauThuatVienChinh", ketQua.PhauThuatVienChinh));
                Command.Parameters.Add(new MDB.MDBParameter("MaPhauThuatVienChinh", ketQua.MaPhauThuatVienChinh));
                Command.Parameters.Add(new MDB.MDBParameter("PhauThuatVienPhu", ketQua.PhauThuatVienPhu));
                Command.Parameters.Add(new MDB.MDBParameter("MaPhauThuatVienPhu", ketQua.MaPhauThuatVienPhu));
                Command.Parameters.Add(new MDB.MDBParameter("BacSyGayMe", ketQua.BacSyGayMe));
                Command.Parameters.Add(new MDB.MDBParameter("MaBacSyGayMe", ketQua.MaBacSyGayMe));
                Command.Parameters.Add(new MDB.MDBParameter("PhuongPhapVoCam", ketQua.PhuongPhapVoCam));
                Command.Parameters.Add(new MDB.MDBParameter("LoaiThuocTe", ketQua.LoaiThuocTe));
                Command.Parameters.Add(new MDB.MDBParameter("RutNganCo", ketQua.RutNganCo));
                Command.Parameters.Add(new MDB.MDBParameter("TreoCoTran", ketQua.TreoCoTran));
                Command.Parameters.Add(new MDB.MDBParameter("TrinhTu1", ketQua.TrinhTu1));
                Command.Parameters.Add(new MDB.MDBParameter("CoDinhMi1", ketQua.CoDinhMi1));
                Command.Parameters.Add(new MDB.MDBParameter("RachDaMi1_Text", ketQua.RachDaMi1_Text));
                Command.Parameters.Add(new MDB.MDBParameter("CatVatDa", ketQua.CatVatDa));
                Command.Parameters.Add(new MDB.MDBParameter("BocLoCo", ketQua.BocLoCo));
                Command.Parameters.Add(new MDB.MDBParameter("KhauCoNang", ketQua.KhauCoNang ? 1: 0));
                Command.Parameters.Add(new MDB.MDBParameter("KhauCoNang_Text", ketQua.KhauCoNang_Text));
                Command.Parameters.Add(new MDB.MDBParameter("CatMauCo", ketQua.CatMauCo));
                Command.Parameters.Add(new MDB.MDBParameter("KhauDaMi", ketQua.KhauDaMi));
                Command.Parameters.Add(new MDB.MDBParameter("KhauDaMi_Chi", ketQua.KhauDaMi_Chi));
                Command.Parameters.Add(new MDB.MDBParameter("TraMat1", ketQua.TraMat1));
                Command.Parameters.Add(new MDB.MDBParameter("BangMat1", ketQua.BangMat1));
                Command.Parameters.Add(new MDB.MDBParameter("TrinhTu2", ketQua.TrinhTu2));
                Command.Parameters.Add(new MDB.MDBParameter("CoDinhMi2", ketQua.CoDinhMi2));
                Command.Parameters.Add(new MDB.MDBParameter("RachDaMi2_Text", ketQua.RachDaMi2_Text));
                Command.Parameters.Add(new MDB.MDBParameter("RachDaMi2", ketQua.RachDaMi2));
                Command.Parameters.Add(new MDB.MDBParameter("RachDaTrenCungMay", ketQua.RachDaTrenCungMay ? 1:0));
                Command.Parameters.Add(new MDB.MDBParameter("RachDaGiuaCungMay", ketQua.RachDaGiuaCungMay ? 1 : 0));
                Command.Parameters.Add(new MDB.MDBParameter("QuaCacDiem", ketQua.QuaCacDiem ? 1: 0));
                Command.Parameters.Add(new MDB.MDBParameter("QuaCacDiem_Chi", ketQua.QuaCacDiem_Chi));
                Command.Parameters.Add(new MDB.MDBParameter("BuocChi", ketQua.BuocChi ? 1:0 ));
                Command.Parameters.Add(new MDB.MDBParameter("KhauDaTran", ketQua.KhauDaTran));
                Command.Parameters.Add(new MDB.MDBParameter("BatThuong", ketQua.BatThuong));
                Command.Parameters.Add(new MDB.MDBParameter("TraMat2", ketQua.TraMat2));
                Command.Parameters.Add(new MDB.MDBParameter("BangMat2", ketQua.BangMat2));
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
        public static bool DeleteByIDPhieu(MDB.MDBConnection oracleConnection, decimal IDBienBan)
        {
            try
            {
                string sql = "";
                MDB.MDBCommand oracleCommand;
                sql = @"DELETE FROM PhieuPhauThuatSupMi WHERE ID =" + IDBienBan;
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
            string sql = @"SELECT P.*, 
                T.SoNhapVien, T.Khoa, T.NgayVaoVien,  T.MaKhoa, T.MaBenhAn, T.Giuong, T.Buong,    
				H.TUOI, H.SoYTe, H.BENHVIEN, 
				H.GIOITINH,  H.TenBenhNhan, H.maBenhNhan
			  FROM PhieuPhauThuatSupMi P 
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
        public static string DownloadAnhMoTa(decimal ID, decimal maQuanLy, string FilePath)
        {
            string fullPath = "";
            try
            {
                string FileHinhAnh = @"\"+ FilePath+ @"\" + maQuanLy;
                if (ID != 0M)
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
                            string fileName = FileHinhAnh.Trim('\\') + "\\" + ID + ".png";
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
