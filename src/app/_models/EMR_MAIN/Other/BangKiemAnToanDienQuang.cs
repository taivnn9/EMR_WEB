using EMR.KyDienTu;
using PMS.Access;
using System;
using System.Collections.Generic;
using System.Data;

namespace EMR_MAIN.DATABASE.Other
{
    public class BangKiemAnToanDienQuang : ThongTinKy
    {
        public BangKiemAnToanDienQuang()
        {
            TableName = "BangKiemAnToanDienQuang";
            TablePrimaryKeyName = "ID";
            IDMauPhieu = (int)DanhMucPhieu.BKATDQ;
            TenMauPhieu = DanhMucPhieu.BKATDQ.Description();
        }
        [MoTaDuLieu("Mã định danh")]
		public long ID { get; set; }
        [MoTaDuLieu("Mã quản lý: mã duy nhất trong 1 đợt khám chữa bệnh (kcb), không trùng giữa các đợt kcb khác nhau","",1)]
		public decimal MaQuanLy { get; set; }
        [MoTaDuLieu("Họ và tên bệnh nhân")]
		public string TenBenhNhan { get; set; }
        [MoTaDuLieu("Mã bệnh nhân")]
		public string MaBenhNhan { get; set; }
        [MoTaDuLieu("Giới tính bệnh nhân")]
		public string GioiTinh { get; set; }
        [MoTaDuLieu("Địa chỉ nhà bệnh nhân")]
		public string DiaChi { get; set; }
        [MoTaDuLieu("Ngày sinh bệnh nhân")]
        public DateTime? NgaySinh { get; set; }
        [MoTaDuLieu("SĐT bệnh nhân")]
        public string SDT { get; set; }
        [MoTaDuLieu("Khoa")]
		public string Khoa { get; set; }
        [MoTaDuLieu("Bệnh viện")]
		public string BenhVien { get; set; }
        [MoTaDuLieu("Giờ làm bảng kiểm")]
        public DateTime? ThoiGian_Gio { get; set; }
        [MoTaDuLieu("Ngày làm bảng kiểm")]
        public DateTime? ThoiGian { get; set; }
        public bool[] PhuNuCoThaiArray { get; } = new bool[] { false, false, false };
        public string PhuNuCoThai
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < PhuNuCoThaiArray.Length; i++)
                    temp += (PhuNuCoThaiArray[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        PhuNuCoThaiArray[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public bool[] TienSuDiUngThuocArray { get; } = new bool[] { false, false, false };
        public string TienSuDiUngThuoc
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < TienSuDiUngThuocArray.Length; i++)
                    temp += (TienSuDiUngThuocArray[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        TienSuDiUngThuocArray[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public bool[] TienSuDiUngThucAnArray { get; } = new bool[] { false, false, false };
        public string TienSuDiUngThucAn
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < TienSuDiUngThucAnArray.Length; i++)
                    temp += (TienSuDiUngThucAnArray[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        TienSuDiUngThucAnArray[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public bool[] TienSuBenhArray { get; } = new bool[] { false, false, false };
        public string TienSuBenh
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < TienSuBenhArray.Length; i++)
                    temp += (TienSuBenhArray[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        TienSuBenhArray[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public bool[] SuyThanArray { get; } = new bool[] { false, false, false };
        public string SuyThan
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < SuyThanArray.Length; i++)
                    temp += (SuyThanArray[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        SuyThanArray[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public bool[] SuDungThuocArray { get; } = new bool[] { false, false, false };
        public string SuDungThuoc
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < SuDungThuocArray.Length; i++)
                    temp += (SuDungThuocArray[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        SuDungThuocArray[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public bool[] ChupMRIArray { get; } = new bool[] { false, false, false };
        public string ChupMRI
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < ChupMRIArray.Length; i++)
                    temp += (ChupMRIArray[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        ChupMRIArray[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public bool[] ThucHienPhauThuatArray { get; } = new bool[] { false, false, false };
        public string ThucHienPhauThuat
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < ThucHienPhauThuatArray.Length; i++)
                    temp += (ThucHienPhauThuatArray[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        ThucHienPhauThuatArray[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public bool[] MayTaoNhipTimArray { get; } = new bool[] { false, false, false };
        public string MayTaoNhipTim
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < MayTaoNhipTimArray.Length; i++)
                    temp += (MayTaoNhipTimArray[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        MayTaoNhipTimArray[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public bool[] CayGhepArray { get; } = new bool[] { false, false, false };
        public string CayGhep
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < CayGhepArray.Length; i++)
                    temp += (CayGhepArray[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        CayGhepArray[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public bool[] KepPhinhArray { get; } = new bool[] { false, false, false };
        public string KepPhinh
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < KepPhinhArray.Length; i++)
                    temp += (KepPhinhArray[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        KepPhinhArray[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public bool[] KimLoaiKhacArray { get; } = new bool[] { false, false, false };
        public string KimLoaiKhac
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < KimLoaiKhacArray.Length; i++)
                    temp += (KimLoaiKhacArray[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        KimLoaiKhacArray[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public bool[] CamKetArray { get; } = new bool[] { false, false };
        public string CamKet
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < CamKetArray.Length; i++)
                    temp += (CamKetArray[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        CamKetArray[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        [MoTaDuLieu("Họ tên người thân")]
		public string NguoiThan { get; set; }
        public bool[] ChupCHTArray { get; } = new bool[] { false, false };
        public string ChupCHT
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < ChupCHTArray.Length; i++)
                    temp += (ChupCHTArray[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        ChupCHTArray[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        [MoTaDuLieu("Mã nhân viên")]
		public string MaNhanVien { get; set; }
        [MoTaDuLieu("Họ tên nhân viên")]
        public string NhanVien { get; set; }
        [MoTaDuLieu("Theo dõi")]
        public string TheoDoi { get; set; }
        [MoTaDuLieu("Họ tên Bác sĩ điện quang")]
        public string BacSiDienQuang { get; set; }
        [MoTaDuLieu("Mã bác sĩ điện quang")]
        public string MaBacSiDienQuang { get; set; }
        [MoTaDuLieu("Họ tên bác sĩ chỉ định")]
        public string BacSiChiDinh { get; set; }
        [MoTaDuLieu("Mã bác sĩ chỉ định")]
        public string MaBacSiChiDinh { get; set; }
        [MoTaDuLieu("Dặn dò của bác sĩ")]
        public string DanDoCuaBacSi { get; set; }
        [MoTaDuLieu("Đã ký", null, 0, 0)]
		public bool DaKy { get; set; }
        [MoTaDuLieu("Ngày tạo", null, 0, 0)]
		public DateTime NgayTao { get; set; }
        [MoTaDuLieu("Người tạo", null, 0, 0)]
		public string NguoiTao { get; set; }
        [MoTaDuLieu("Ngày sửa", null, 0, 0)]
		public DateTime NgaySua { get; set; }
        [MoTaDuLieu("Người sửa", null, 0, 0)]
		public string NguoiSua { get; set; }
        [MoTaDuLieu("Chọn", null, 0, 0)]
		public bool Chon { get; set; }
    }
    public class BangKiemAnToanDienQuangFunc
    {
        public const string TableName = "BangKiemAnToanDienQuang";
        public const string TablePrimaryKeyName = "ID";
        public static List<BangKiemAnToanDienQuang> GetListData(MDB.MDBConnection _OracleConnection, decimal maquanly)
        {
            List<BangKiemAnToanDienQuang> list = new List<BangKiemAnToanDienQuang>();
            try
            {
                string sql = @"SELECT * FROM BangKiemAnToanDienQuang where MaQuanLy = :MaQuanLy";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, _OracleConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", maquanly));
                MDB.MDBDataReader DataReader = Command.ExecuteReader();
                while (DataReader.Read())
                {
                    BangKiemAnToanDienQuang data = new BangKiemAnToanDienQuang();
                    data.ID = Convert.ToInt64(DataReader.GetLong("ID").ToString());
                    data.MaQuanLy = maquanly;
                    data.TenBenhNhan = XemBenhAn._HanhChinhBenhNhan.TenBenhNhan;
                    data.NgaySinh = XemBenhAn._HanhChinhBenhNhan.NgaySinh;
                    data.GioiTinh = XemBenhAn._HanhChinhBenhNhan.GioiTinh.Description();
                    data.Khoa = XemBenhAn._ThongTinDieuTri.Khoa;
                    data.BenhVien = XemBenhAn._HanhChinhBenhNhan.BenhVien;

                    data.MaBenhNhan = DataReader["MaBenhNhan"].ToString();
                    data.DiaChi = DataReader["DiaChi"].ToString();
                    data.SDT = DataReader["SDT"].ToString();
                    data.ThoiGian = Convert.ToDateTime(DataReader["ThoiGian"] == DBNull.Value ? DateTime.Now : DataReader["ThoiGian"]);
                    data.ThoiGian_Gio = data.ThoiGian;
                    data.PhuNuCoThai = DataReader["PhuNuCoThai"].ToString();
                    data.TienSuDiUngThuoc = DataReader["TienSuDiUngThuoc"].ToString();
                    data.TienSuDiUngThucAn = DataReader["TienSuDiUngThucAn"].ToString();
                    data.TienSuBenh = DataReader["TienSuBenh"].ToString();
                    data.SuyThan = DataReader["SuyThan"].ToString();
                    data.SuDungThuoc = DataReader["SuDungThuoc"].ToString();
                    data.ChupMRI = DataReader["ChupMRI"].ToString();
                    data.ThucHienPhauThuat = DataReader["ThucHienPhauThuat"].ToString();
                    data.MayTaoNhipTim = DataReader["MayTaoNhipTim"].ToString();
                    data.CayGhep = DataReader["CayGhep"].ToString();
                    data.KepPhinh = DataReader["KepPhinh"].ToString();
                    data.KimLoaiKhac = DataReader["KimLoaiKhac"].ToString();
                    data.CamKet = DataReader["CamKet"].ToString();
                    data.NguoiThan = DataReader["NguoiThan"].ToString();

                    data.ChupCHT = DataReader["ChupCHT"].ToString();
                    data.MaNhanVien = DataReader["MaNhanVien"].ToString();
                    data.NhanVien = DataReader["NhanVien"].ToString();
                    data.TheoDoi = DataReader["TheoDoi"].ToString();
                    data.BacSiDienQuang = DataReader["BacSiDienQuang"].ToString();
                    data.MaBacSiDienQuang = DataReader["MaBacSiDienQuang"].ToString();
                    data.BacSiChiDinh = DataReader["BacSiChiDinh"].ToString();
                    data.MaBacSiChiDinh = DataReader["MaBacSiChiDinh"].ToString();
                    data.DanDoCuaBacSi = DataReader["DanDoCuaBacSi"].ToString();

                    data.NgayTao = Convert.ToDateTime(DataReader["NgayTao"] == DBNull.Value ? DateTime.Now : DataReader["NgayTao"]);
                    data.NguoiTao = DataReader["NguoiTao"].ToString();
                    data.NgaySua = Convert.ToDateTime(DataReader["NgaySua"] == DBNull.Value ? DateTime.Now : DataReader["NgaySua"]);
                    data.NguoiSua = DataReader["NguoiSua"].ToString();

                    data.MaSoKy = DataReader["masokyten"].ToString();
                    data.DaKy = !string.IsNullOrEmpty(data.MaSoKy) ? true : false;
                    list.Add(data);
                }
            }
            catch (Exception ex) { XuLyLoi.Handle(ex); }
            return list;
        }
        public static bool InsertOrUpdate(MDB.MDBConnection MyConnection, ref BangKiemAnToanDienQuang bangKe)
        {
            try
            {
                string sql = @"INSERT INTO BangKiemAnToanDienQuang
                (
                    MAQUANLY,
                    MaBenhNhan,
                    DiaChi,
                    SDT,
                    ThoiGian,
                    PhuNuCoThai,
                    TienSuDiUngThuoc,
                    TienSuDiUngThucAn,
                    TienSuBenh,
                    SuyThan,
                    SuDungThuoc,
                    ChupMRI,
                    ThucHienPhauThuat,
                    MayTaoNhipTim,
                    CayGhep,
                    KepPhinh,
                    KimLoaiKhac,
                    CamKet,
                    NguoiThan,
                    ChupCHT,
                    MaNhanVien,
                    NhanVien,
                    TheoDoi,
                    BacSiDienQuang,
                    MaBacSiDienQuang,
                    BacSiChiDinh,
                    MaBacSiChiDinh,
                    DanDoCuaBacSi,
                    NGUOITAO,
                    NGUOISUA,
                    NGAYTAO,
                    NGAYSUA)  VALUES
                 (
				    :MAQUANLY,
                    :MaBenhNhan,
                    :DiaChi,
                    :SDT,
                    :ThoiGian,
                    :PhuNuCoThai,
                    :TienSuDiUngThuoc,
                    :TienSuDiUngThucAn,
                    :TienSuBenh,
                    :SuyThan,
                    :SuDungThuoc,
                    :ChupMRI,
                    :ThucHienPhauThuat,
                    :MayTaoNhipTim,
                    :CayGhep,
                    :KepPhinh,
                    :KimLoaiKhac,
                    :CamKet,
                    :NguoiThan,
                    :ChupCHT,
                    :MaNhanVien,
                    :NhanVien,
                    :TheoDoi,
                    :BacSiDienQuang,
                    :MaBacSiDienQuang,
                    :BacSiChiDinh,
                    :MaBacSiChiDinh,
                    :DanDoCuaBacSi,
                    :NGUOITAO,
                    :NGUOISUA,
                    :NGAYTAO,
                    :NGAYSUA
                 )  RETURNING ID INTO :ID";
                if (bangKe.ID != 0)
                {
                    sql = @"UPDATE BangKiemAnToanDienQuang SET 
                    MAQUANLY = :MAQUANLY,
                    MaBenhNhan = :MaBenhNhan,
                    DiaChi = :DiaChi,
                    SDT = :SDT,
                    ThoiGian = :ThoiGian,
                    PhuNuCoThai = :PhuNuCoThai,
                    TienSuDiUngThuoc = :TienSuDiUngThuoc,
                    TienSuDiUngThucAn = :TienSuDiUngThucAn,
                    TienSuBenh = :TienSuBenh,
                    SuyThan = :SuyThan,
                    SuDungThuoc = :SuDungThuoc,
                    ChupMRI = :ChupMRI,
                    ThucHienPhauThuat = :ThucHienPhauThuat,
                    MayTaoNhipTim = :MayTaoNhipTim,
                    CayGhep = :CayGhep,
                    KepPhinh = :KepPhinh,
                    KimLoaiKhac = :KimLoaiKhac,
                    CamKet = :CamKet,
                    NguoiThan = :NguoiThan,
                    ChupCHT = :ChupCHT,
                    MaNhanVien = :MaNhanVien,
                    NhanVien = :NhanVien,
                    TheoDoi = :TheoDoi,
                    BacSiDienQuang = :BacSiDienQuang,
                    MaBacSiDienQuang = :MaBacSiDienQuang,
                    BacSiChiDinh = :BacSiChiDinh,
                    MaBacSiChiDinh = :MaBacSiChiDinh,
                    DanDoCuaBacSi = :DanDoCuaBacSi,
                    NGUOISUA = :NGUOISUA,
                    NGAYSUA = :NGAYSUA
                    WHERE ID = " + bangKe.ID;
                }
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MAQUANLY", bangKe.MaQuanLy));
                Command.Parameters.Add(new MDB.MDBParameter("MaBenhNhan", bangKe.MaBenhNhan));
                Command.Parameters.Add(new MDB.MDBParameter("DiaChi", bangKe.DiaChi));
                Command.Parameters.Add(new MDB.MDBParameter("SDT", bangKe.SDT));
                DateTime? ThoiGian = bangKe.ThoiGian.HasValue ? bangKe.ThoiGian.Value.Date : (DateTime?)null;
                var ThoiGianFull = ThoiGian;
                if (ThoiGian != null)
                {
                    var ThoiGian_Gio = bangKe.ThoiGian_Gio.HasValue ? bangKe.ThoiGian_Gio.Value.TimeOfDay : new TimeSpan(0, 0, 0);
                    ThoiGianFull = ThoiGian + ThoiGian_Gio;
                }
                Command.Parameters.Add(new MDB.MDBParameter("ThoiGian", ThoiGianFull));
                Command.Parameters.Add(new MDB.MDBParameter("PhuNuCoThai", bangKe.PhuNuCoThai));
                Command.Parameters.Add(new MDB.MDBParameter("TienSuDiUngThuoc", bangKe.TienSuDiUngThuoc));
                Command.Parameters.Add(new MDB.MDBParameter("TienSuDiUngThucAn", bangKe.TienSuDiUngThucAn));
                Command.Parameters.Add(new MDB.MDBParameter("TienSuBenh", bangKe.TienSuBenh));
                Command.Parameters.Add(new MDB.MDBParameter("SuyThan", bangKe.SuyThan));
                Command.Parameters.Add(new MDB.MDBParameter("SuDungThuoc", bangKe.SuDungThuoc));
                Command.Parameters.Add(new MDB.MDBParameter("ChupMRI", bangKe.ChupMRI));
                Command.Parameters.Add(new MDB.MDBParameter("ThucHienPhauThuat", bangKe.ThucHienPhauThuat));
                Command.Parameters.Add(new MDB.MDBParameter("MayTaoNhipTim", bangKe.MayTaoNhipTim));
                Command.Parameters.Add(new MDB.MDBParameter("CayGhep", bangKe.CayGhep));
                Command.Parameters.Add(new MDB.MDBParameter("KepPhinh", bangKe.KepPhinh));
                Command.Parameters.Add(new MDB.MDBParameter("KimLoaiKhac", bangKe.KimLoaiKhac));
                Command.Parameters.Add(new MDB.MDBParameter("CamKet", bangKe.CamKet));
                Command.Parameters.Add(new MDB.MDBParameter("NguoiThan", bangKe.NguoiThan));
                Command.Parameters.Add(new MDB.MDBParameter("ChupCHT", bangKe.ChupCHT));
                Command.Parameters.Add(new MDB.MDBParameter("MaNhanVien", bangKe.MaNhanVien));
                Command.Parameters.Add(new MDB.MDBParameter("NhanVien", bangKe.NhanVien));
                Command.Parameters.Add(new MDB.MDBParameter("TheoDoi", bangKe.TheoDoi));
                Command.Parameters.Add(new MDB.MDBParameter("BacSiDienQuang", bangKe.BacSiDienQuang));
                Command.Parameters.Add(new MDB.MDBParameter("MaBacSiDienQuang", bangKe.MaBacSiDienQuang));
                Command.Parameters.Add(new MDB.MDBParameter("BacSiChiDinh", bangKe.BacSiChiDinh));
                Command.Parameters.Add(new MDB.MDBParameter("MaBacSiChiDinh", bangKe.MaBacSiChiDinh));
                Command.Parameters.Add(new MDB.MDBParameter("DanDoCuaBacSi", bangKe.DanDoCuaBacSi));
                Command.Parameters.Add(new MDB.MDBParameter("NGUOISUA", bangKe.NguoiSua));
                Command.Parameters.Add(new MDB.MDBParameter("NGAYSUA", bangKe.NgaySua));
                if (bangKe.ID == 0)
                {
                    Command.Parameters.Add(new MDB.MDBParameter("ID", bangKe.ID));
                    Command.Parameters.Add(new MDB.MDBParameter("NGUOITAO", bangKe.NguoiTao));
                    Command.Parameters.Add(new MDB.MDBParameter("NGAYTAO", bangKe.NgayTao));
                }
                Command.BindByName = true;
                int n = Command.ExecuteNonQuery();
                if (bangKe.ID == 0)
                {
                    long nextval = Convert.ToInt64((Command.Parameters["ID"] as MDB.MDBParameter).Value);
                    bangKe.ID = nextval;
                }
                return n > 0 ? true : false;
            }
            catch (Exception ex)
            {
                XuLyLoi.Handle(ex);
            }
            return false;
        }
        public static bool delete(MDB.MDBConnection MyConnection, long id)
        {
            try
            {
                string sql = "DELETE FROM BangKiemAnToanDienQuang WHERE ID = :ID";
                MDB.MDBCommand command = new MDB.MDBCommand(sql, MyConnection);
                command.Parameters.Add(new MDB.MDBParameter("ID", id));
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
        public static DataSet getDataSet(MDB.MDBConnection MyConnection, long id)
        {
            string sql = @"SELECT
                *
            FROM
                BangKiemAnToanDienQuang B
            WHERE
                ID = " + id;

            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
            MDB.MDBDataAdapter adt = new MDB.MDBDataAdapter(Command);

            var ds = new DataSet();

            adt.Fill(ds, "TB");
            ds.Tables[0].AddColumn("TenBenhNhan", typeof(string));
            ds.Tables[0].AddColumn("NgaySinh", typeof(DateTime));
            ds.Tables[0].AddColumn("GioiTinh", typeof(string));
            ds.Tables[0].AddColumn("BenhVien", typeof(string));
            ds.Tables[0].AddColumn("Khoa", typeof(string));
            ds.Tables[0].AddColumn("SoYTe", typeof(string));

            ds.Tables[0].Rows[0]["TenBenhNhan"] = XemBenhAn._HanhChinhBenhNhan.TenBenhNhan;
            ds.Tables[0].Rows[0]["NgaySinh"] = XemBenhAn._HanhChinhBenhNhan.NgaySinh;
            ds.Tables[0].Rows[0]["GioiTinh"] = XemBenhAn._HanhChinhBenhNhan.GioiTinh.Description();
            ds.Tables[0].Rows[0]["BenhVien"] = XemBenhAn._HanhChinhBenhNhan.BenhVien;
            ds.Tables[0].Rows[0]["Khoa"] = XemBenhAn._ThongTinDieuTri.Khoa;
            ds.Tables[0].Rows[0]["SoYTe"] = XemBenhAn._HanhChinhBenhNhan.SoYTe;

            return ds;

        }
    }
}
