using EMR.KyDienTu;
using PMS.Access;
using System;
using System.Collections.Generic;
using System.Data;

namespace EMR_MAIN.DATABASE.Other
{
    public class BangKiemAnToanThuThuat_CTTM2 : ThongTinKy
    {
        public BangKiemAnToanThuThuat_CTTM2()
        {
            TableName = "BangKiemAnToanTT_CTTM2";
            TablePrimaryKeyName = "ID";
            IDMauPhieu = (int)DanhMucPhieu.BKANTTCTTM2;
            TenMauPhieu = DanhMucPhieu.BKANTTCTTM2.Description();
        }
        [MoTaDuLieu("Mã định danh")]
		public long ID { get; set; }
        [MoTaDuLieu("Mã quản lý: mã duy nhất trong 1 đợt khám chữa bệnh (kcb), không trùng giữa các đợt kcb khác nhau","",1)]
		public decimal MaQuanLy { get; set; }
        [MoTaDuLieu("Mã bệnh nhân")]
		public string MaBenhNhan { get; set; }
        public string HoTenBenhNhan { get; set; }
        [MoTaDuLieu("Tuổi bệnh nhân")]
		public string Tuoi { get; set; }
        [MoTaDuLieu("Giới tính bệnh nhân")]
		public string GioiTinh { get; set; }
        [MoTaDuLieu("Chẩn đoán bệnh")]
		public string ChanDoan { get; set; }
        [MoTaDuLieu("Phương pháp can thiệp")]
        public string PhuongPhapCanThiep { get; set; }
        [MoTaDuLieu("Phương pháp gây mê")]
        public string PhuongPhapGayMe { get; set; }
        public bool[] CanThiep_Array { get; } = new bool[] { false, false, false };
        public string CanThiep
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < CanThiep_Array.Length; i++)
                    temp += (CanThiep_Array[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        CanThiep_Array[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public bool[] TKV1_Array { get; } = new bool[] { false, false };
        public int TKV1
        {
            get
            {
                return Array.IndexOf(TKV1_Array, true) + 1;
            }
            set
            {
                for (int i = 0; i < TKV1_Array.Length; i++)
                {
                    if (i == (value - 1)) TKV1_Array[i] = true;
                    else TKV1_Array[i] = false;
                }
            }
        }
        public bool[] TKV2_Array { get; } = new bool[] { false, false };
        public int TKV2
        {
            get
            {
                return Array.IndexOf(TKV2_Array, true) + 1;
            }
            set
            {
                for (int i = 0; i < TKV2_Array.Length; i++)
                {
                    if (i == (value - 1)) TKV2_Array[i] = true;
                    else TKV2_Array[i] = false;
                }
            }
        }
        public bool[] TKV3_Array { get; } = new bool[] { false, false };
        public int TKV3
        {
            get
            {
                return Array.IndexOf(TKV3_Array, true) + 1;
            }
            set
            {
                for (int i = 0; i < TKV3_Array.Length; i++)
                {
                    if (i == (value - 1)) TKV3_Array[i] = true;
                    else TKV3_Array[i] = false;
                }
            }
        }
        public bool[] TKV4_Array { get; } = new bool[] { false, false };
        public int TKV4
        {
            get
            {
                return Array.IndexOf(TKV4_Array, true) + 1;
            }
            set
            {
                for (int i = 0; i < TKV4_Array.Length; i++)
                {
                    if (i == (value - 1)) TKV4_Array[i] = true;
                    else TKV4_Array[i] = false;
                }
            }
        }
        public bool[] TKV5_Array { get; } = new bool[] { false, false };
        public int TKV5
        {
            get
            {
                return Array.IndexOf(TKV5_Array, true) + 1;
            }
            set
            {
                for (int i = 0; i < TKV5_Array.Length; i++)
                {
                    if (i == (value - 1)) TKV5_Array[i] = true;
                    else TKV5_Array[i] = false;
                }
            }
        }
        public bool[] TKV6_Array { get; } = new bool[] { false, false };
        public int TKV6
        {
            get
            {
                return Array.IndexOf(TKV6_Array, true) + 1;
            }
            set
            {
                for (int i = 0; i < TKV6_Array.Length; i++)
                {
                    if (i == (value - 1)) TKV6_Array[i] = true;
                    else TKV6_Array[i] = false;
                }
            }
        }
        public bool[] TKV7_Array { get; } = new bool[] { false, false };
        public int TKV7
        {
            get
            {
                return Array.IndexOf(TKV7_Array, true) + 1;
            }
            set
            {
                for (int i = 0; i < TKV7_Array.Length; i++)
                {
                    if (i == (value - 1)) TKV7_Array[i] = true;
                    else TKV7_Array[i] = false;
                }
            }
        }
        public bool[] TKV8_Array { get; } = new bool[] { false, false };
        public int TKV8
        {
            get
            {
                return Array.IndexOf(TKV8_Array, true) + 1;
            }
            set
            {
                for (int i = 0; i < TKV8_Array.Length; i++)
                {
                    if (i == (value - 1)) TKV8_Array[i] = true;
                    else TKV8_Array[i] = false;
                }
            }
        }
        public bool[] TKC1_Array { get; } = new bool[] { false, false };
        public int TKC1
        {
            get
            {
                return Array.IndexOf(TKC1_Array, true) + 1;
            }
            set
            {
                for (int i = 0; i < TKC1_Array.Length; i++)
                {
                    if (i == (value - 1)) TKC1_Array[i] = true;
                    else TKC1_Array[i] = false;
                }
            }
        }
        public bool[] TKC2_Array { get; } = new bool[] { false, false };
        public int TKC2
        {
            get
            {
                return Array.IndexOf(TKC2_Array, true) + 1;
            }
            set
            {
                for (int i = 0; i < TKC2_Array.Length; i++)
                {
                    if (i == (value - 1)) TKC2_Array[i] = true;
                    else TKC2_Array[i] = false;
                }
            }
        }
        public bool[] TKC3_Array { get; } = new bool[] { false, false };
        public int TKC3
        {
            get
            {
                return Array.IndexOf(TKC3_Array, true) + 1;
            }
            set
            {
                for (int i = 0; i < TKC3_Array.Length; i++)
                {
                    if (i == (value - 1)) TKC3_Array[i] = true;
                    else TKC3_Array[i] = false;
                }
            }
        }
        public bool[] TKC4_Array { get; } = new bool[] { false, false };
        public int TKC4
        {
            get
            {
                return Array.IndexOf(TKC4_Array, true) + 1;
            }
            set
            {
                for (int i = 0; i < TKC4_Array.Length; i++)
                {
                    if (i == (value - 1)) TKC4_Array[i] = true;
                    else TKC4_Array[i] = false;
                }
            }
        }
        public bool[] TKC5_Array { get; } = new bool[] { false, false };
        public int TKC5
        {
            get
            {
                return Array.IndexOf(TKC5_Array, true) + 1;
            }
            set
            {
                for (int i = 0; i < TKC5_Array.Length; i++)
                {
                    if (i == (value - 1)) TKC5_Array[i] = true;
                    else TKC5_Array[i] = false;
                }
            }
        }
        public bool[] TKN1_Array { get; } = new bool[] { false, false };
        public int TKN1
        {
            get
            {
                return Array.IndexOf(TKN1_Array, true) + 1;
            }
            set
            {
                for (int i = 0; i < TKN1_Array.Length; i++)
                {
                    if (i == (value - 1)) TKN1_Array[i] = true;
                    else TKN1_Array[i] = false;
                }
            }
        }
        public bool[] TKN2_Array { get; } = new bool[] { false, false };
        public int TKN2
        {
            get
            {
                return Array.IndexOf(TKN2_Array, true) + 1;
            }
            set
            {
                for (int i = 0; i < TKN2_Array.Length; i++)
                {
                    if (i == (value - 1)) TKN2_Array[i] = true;
                    else TKN2_Array[i] = false;
                }
            }
        }
        public bool[] TKN3_Array { get; } = new bool[] { false, false };
        public int TKN3
        {
            get
            {
                return Array.IndexOf(TKN3_Array, true) + 1;
            }
            set
            {
                for (int i = 0; i < TKN3_Array.Length; i++)
                {
                    if (i == (value - 1)) TKN3_Array[i] = true;
                    else TKN3_Array[i] = false;
                }
            }
        }
        public bool[] TKN4_Array { get; } = new bool[] { false, false };
        public int TKN4
        {
            get
            {
                return Array.IndexOf(TKN4_Array, true) + 1;
            }
            set
            {
                for (int i = 0; i < TKN4_Array.Length; i++)
                {
                    if (i == (value - 1)) TKN4_Array[i] = true;
                    else TKN4_Array[i] = false;
                }
            }
        }
        public string DuongKhac1 { get; set; }
        public bool[] TKN5_Array { get; } = new bool[] { false, false, false };
        public string TKN5
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < TKN5_Array.Length; i++)
                    temp += (TKN5_Array[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        TKN5_Array[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public string DuongKhac2 { get; set; }
        public bool[] TKN6_Array { get; } = new bool[] { false, false };
        public int TKN6
        {
            get
            {
                return Array.IndexOf(TKN6_Array, true) + 1;
            }
            set
            {
                for (int i = 0; i < TKN6_Array.Length; i++)
                {
                    if (i == (value - 1)) TKN6_Array[i] = true;
                    else TKN6_Array[i] = false;
                }
            }
        }
        public bool[] TKN7_Array { get; } = new bool[] { false, false };
        public int TKN7
        {
            get
            {
                return Array.IndexOf(TKN7_Array, true) + 1;
            }
            set
            {
                for (int i = 0; i < TKN7_Array.Length; i++)
                {
                    if (i == (value - 1)) TKN7_Array[i] = true;
                    else TKN7_Array[i] = false;
                }
            }
        }
        public bool[] TKN8_Array { get; } = new bool[] { false, false, false };
        public string TKN8
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < TKN8_Array.Length; i++)
                    temp += (TKN8_Array[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        TKN8_Array[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public string TKN8_Khac { get; set; }
        [MoTaDuLieu("Họ tên bác sĩ gây mê")]
        public string BacSyGayMe { get; set; }
        [MoTaDuLieu("Mã bác sĩ gây mê")]
        public string MaBacSyGayMe { get; set; }
        [MoTaDuLieu("Họ tên điều dưỡng")]
		public string DieuDuong1 { get; set; }
        [MoTaDuLieu("Mã điều dưỡng 1")]
		public string MaDieuDuong1 { get; set; }
        [MoTaDuLieu("Họ tên bác sĩ TMCT")]
        public string BacSyTMCT { get; set; }
        [MoTaDuLieu("Mã bác sĩ TMCT")]
        public string MaBacSyTMCT { get; set; }
        [MoTaDuLieu("Họ tên điều dưỡng 2")]
		public string DieuDuong2 { get; set; }
        [MoTaDuLieu("Mã điều dưỡng 2")]
		public string MaDieuDuong2 { get; set; }
        [MoTaDuLieu("Họ tên điều dưỡng 3")]
		public string DieuDuong3 { get; set; }
        [MoTaDuLieu("Mã điều dưỡng 3")]
		public string MaDieuDuong3 { get; set; }
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
    public class BangKiemAnToanThuThuat_CTTM2Func
    {
        public const string TableName = "BangKiemAnToanTT_CTTM2";
        public const string TablePrimaryKeyName = "ID";
        public static List<BangKiemAnToanThuThuat_CTTM2> GetListData(MDB.MDBConnection _OracleConnection, decimal maquanly)
        {
            List<BangKiemAnToanThuThuat_CTTM2> list = new List<BangKiemAnToanThuThuat_CTTM2>();
            try
            {
                string sql = @"SELECT * FROM BangKiemAnToanTT_CTTM2 where MaQuanLy = :MaQuanLy";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, _OracleConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", maquanly));
                MDB.MDBDataReader DataReader = Command.ExecuteReader();
                while (DataReader.Read())
                {
                    BangKiemAnToanThuThuat_CTTM2 data = new BangKiemAnToanThuThuat_CTTM2();
                    data.ID = Convert.ToInt64(DataReader.GetLong("ID").ToString());
                    data.MaQuanLy = maquanly;
                    data.MaBenhNhan = DataReader["MaBenhNhan"].ToString();
                    data.HoTenBenhNhan = XemBenhAn._HanhChinhBenhNhan.TenBenhNhan;
                    data.Tuoi = XemBenhAn._HanhChinhBenhNhan.Tuoi;
                    data.GioiTinh = XemBenhAn._HanhChinhBenhNhan.GioiTinh.Description();
                    data.ChanDoan = DataReader["ChanDoan"].ToString();
                    data.PhuongPhapCanThiep = DataReader["PhuongPhapCanThiep"].ToString();
                    data.PhuongPhapGayMe = DataReader["PhuongPhapGayMe"].ToString();
                    data.CanThiep = DataReader["CanThiep"].ToString();

                    int tempInt = 0;
                    data.TKV1 = int.TryParse(DataReader["TKV1"].ToString(), out tempInt) ? tempInt : 0;
                    tempInt = 0;
                    data.TKV2 = int.TryParse(DataReader["TKV2"].ToString(), out tempInt) ? tempInt : 0;
                    tempInt = 0;
                    data.TKV3 = int.TryParse(DataReader["TKV3"].ToString(), out tempInt) ? tempInt : 0;
                    tempInt = 0;
                    data.TKV4 = int.TryParse(DataReader["TKV4"].ToString(), out tempInt) ? tempInt : 0;
                    tempInt = 0;
                    data.TKV5 = int.TryParse(DataReader["TKV5"].ToString(), out tempInt) ? tempInt : 0;
                    tempInt = 0;
                    data.TKV6 = int.TryParse(DataReader["TKV6"].ToString(), out tempInt) ? tempInt : 0;
                    tempInt = 0;
                    data.TKV7 = int.TryParse(DataReader["TKV7"].ToString(), out tempInt) ? tempInt : 0;
                    tempInt = 0;
                    data.TKV8 = int.TryParse(DataReader["TKV8"].ToString(), out tempInt) ? tempInt : 0;
                    tempInt = 0;
                    data.TKC1 = int.TryParse(DataReader["TKC1"].ToString(), out tempInt) ? tempInt : 0;
                    tempInt = 0;
                    data.TKC2 = int.TryParse(DataReader["TKC2"].ToString(), out tempInt) ? tempInt : 0;
                    tempInt = 0;
                    data.TKC3 = int.TryParse(DataReader["TKC3"].ToString(), out tempInt) ? tempInt : 0;
                    tempInt = 0;
                    data.TKC4 = int.TryParse(DataReader["TKC4"].ToString(), out tempInt) ? tempInt : 0;
                    tempInt = 0;
                    data.TKC5 = int.TryParse(DataReader["TKC5"].ToString(), out tempInt) ? tempInt : 0;
                    tempInt = 0;
                    data.TKN1 = int.TryParse(DataReader["TKN1"].ToString(), out tempInt) ? tempInt : 0;
                    tempInt = 0;
                    data.TKN2 = int.TryParse(DataReader["TKN2"].ToString(), out tempInt) ? tempInt : 0;
                    tempInt = 0;
                    data.TKN3 = int.TryParse(DataReader["TKN3"].ToString(), out tempInt) ? tempInt : 0;
                    tempInt = 0;
                    data.TKN4 = int.TryParse(DataReader["TKN4"].ToString(), out tempInt) ? tempInt : 0;
                    data.DuongKhac1 = DataReader["DuongKhac1"].ToString();
                    data.TKN5 = DataReader["TKN5"].ToString();
                    data.DuongKhac2 = DataReader["DuongKhac2"].ToString();
                    tempInt = 0;
                    data.TKN6 = int.TryParse(DataReader["TKN6"].ToString(), out tempInt) ? tempInt : 0;
                    tempInt = 0;
                    data.TKN7 = int.TryParse(DataReader["TKN7"].ToString(), out tempInt) ? tempInt : 0;
                    data.TKN8 = DataReader["TKN8"].ToString();
                    data.TKN8_Khac = DataReader["TKN8_Khac"].ToString();

                    data.BacSyGayMe = DataReader["BacSyGayMe"].ToString();
                    data.MaBacSyGayMe = DataReader["MaBacSyGayMe"].ToString();
                    data.DieuDuong1 = DataReader["DieuDuong1"].ToString();
                    data.MaDieuDuong1 = DataReader["MaDieuDuong1"].ToString();
                    data.BacSyTMCT = DataReader["BacSyTMCT"].ToString();
                    data.MaBacSyTMCT = DataReader["MaBacSyTMCT"].ToString();
                    data.DieuDuong2 = DataReader["DieuDuong2"].ToString();
                    data.MaDieuDuong2 = DataReader["MaDieuDuong2"].ToString();
                    data.DieuDuong3 = DataReader["DieuDuong3"].ToString();
                    data.MaDieuDuong3 = DataReader["MaDieuDuong3"].ToString();

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
        public static bool InsertOrUpdate(MDB.MDBConnection MyConnection, ref BangKiemAnToanThuThuat_CTTM2 ketQua)
        {
            try
            {
                string sql = @"INSERT INTO BangKiemAnToanTT_CTTM2
                (
                    MAQUANLY,
                    MaBenhNhan,
                    ChanDoan,
                    PhuongPhapCanThiep,
                    PhuongPhapGayMe,
                    CanThiep,
                    TKV1,
                    TKV2,
                    TKV3,
                    TKV4,
                    TKV5,
                    TKV6,
                    TKV7,
                    TKV8,
                    TKC1,
                    TKC2,
                    TKC3,
                    TKC4,
                    TKC5,
                    TKN1,
                    TKN2,
                    TKN3,
                    TKN4,
                    DuongKhac1,
                    TKN5,
                    DuongKhac2,
                    TKN6,
                    TKN7,
                    TKN8,
                    TKN8_Khac,
                    BacSyGayMe,
                    MaBacSyGayMe,
                    DieuDuong1,
                    MaDieuDuong1,
                    BacSyTMCT,
                    MaBacSyTMCT,
                    DieuDuong2,
                    MaDieuDuong2,
                    DieuDuong3,
                    MaDieuDuong3,
                    NGUOITAO,
                    NGUOISUA,
                    NGAYTAO,
                    NGAYSUA
                 )  VALUES
                 (
				    :MAQUANLY,
                    :MaBenhNhan,
                    :ChanDoan,
                    :PhuongPhapCanThiep,
                    :PhuongPhapGayMe,
                    :CanThiep,
                    :TKV1,
                    :TKV2,
                    :TKV3,
                    :TKV4,
                    :TKV5,
                    :TKV6,
                    :TKV7,
                    :TKV8,
                    :TKC1,
                    :TKC2,
                    :TKC3,
                    :TKC4,
                    :TKC5,
                    :TKN1,
                    :TKN2,
                    :TKN3,
                    :TKN4,
                    :DuongKhac1,
                    :TKN5,
                    :DuongKhac2,
                    :TKN6,
                    :TKN7,
                    :TKN8,
                    :TKN8_Khac,
                    :BacSyGayMe,
                    :MaBacSyGayMe,
                    :DieuDuong1,
                    :MaDieuDuong1,
                    :BacSyTMCT,
                    :MaBacSyTMCT,
                    :DieuDuong2,
                    :MaDieuDuong2,
                    :DieuDuong3,
                    :MaDieuDuong3,
                    :NGUOITAO,
                    :NGUOISUA,
                    :NGAYTAO,
                    :NGAYSUA
                 )  RETURNING ID INTO :ID";
                if (ketQua.ID != 0)
                {
                    sql = @"UPDATE BangKiemAnToanTT_CTTM2 SET 
                    MAQUANLY = :MAQUANLY,
                    MaBenhNhan = :MaBenhNhan,
                    ChanDoan = :ChanDoan,
                    PhuongPhapCanThiep = :PhuongPhapCanThiep,
                    PhuongPhapGayMe = :PhuongPhapGayMe,
                    CanThiep = :CanThiep,
                    TKV1 = :TKV1,
                    TKV2 = :TKV2,
                    TKV3 = :TKV3,
                    TKV4 = :TKV4,
                    TKV5 = :TKV5,
                    TKV6 = :TKV6,
                    TKV7 = :TKV7,
                    TKV8 = :TKV8,
                    TKC1 = :TKC1,
                    TKC2 = :TKC2,
                    TKC3 = :TKC3,
                    TKC4 = :TKC4,
                    TKC5 = :TKC5,
                    TKN1 = :TKN1,
                    TKN2 = :TKN2,
                    TKN3 = :TKN3,
                    TKN4 = :TKN4,
                    DuongKhac1 = :DuongKhac1,
                    TKN5 = :TKN5,
                    DuongKhac2 = :DuongKhac2,
                    TKN6 = :TKN6,
                    TKN7 = :TKN7,
                    TKN8 = :TKN8,
                    TKN8_Khac = :TKN8_Khac,
                    BacSyGayMe = :BacSyGayMe,
                    MaBacSyGayMe = :MaBacSyGayMe,
                    DieuDuong1 = :DieuDuong1,
                    MaDieuDuong1 = :MaDieuDuong1,
                    BacSyTMCT = :BacSyTMCT,
                    MaBacSyTMCT = :MaBacSyTMCT,
                    DieuDuong2 = :DieuDuong2,
                    MaDieuDuong2 = :MaDieuDuong2,
                    DieuDuong3 = :DieuDuong3,
                    MaDieuDuong3 = :MaDieuDuong3,
                    NGUOISUA = :NGUOISUA,
                    NGAYSUA = :NGAYSUA 
                    WHERE ID = " + ketQua.ID;
                }
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MAQUANLY", ketQua.MaQuanLy));
                Command.Parameters.Add(new MDB.MDBParameter("MaBenhNhan", ketQua.MaBenhNhan));
                Command.Parameters.Add(new MDB.MDBParameter("ChanDoan", ketQua.ChanDoan));
                Command.Parameters.Add(new MDB.MDBParameter("PhuongPhapCanThiep", ketQua.PhuongPhapCanThiep));
                Command.Parameters.Add(new MDB.MDBParameter("PhuongPhapGayMe", ketQua.PhuongPhapGayMe));
                Command.Parameters.Add(new MDB.MDBParameter("CanThiep", ketQua.CanThiep));
                Command.Parameters.Add(new MDB.MDBParameter("TKV1", ketQua.TKV1));
                Command.Parameters.Add(new MDB.MDBParameter("TKV2", ketQua.TKV2));
                Command.Parameters.Add(new MDB.MDBParameter("TKV3", ketQua.TKV3));
                Command.Parameters.Add(new MDB.MDBParameter("TKV4", ketQua.TKV4));
                Command.Parameters.Add(new MDB.MDBParameter("TKV5", ketQua.TKV5));
                Command.Parameters.Add(new MDB.MDBParameter("TKV6", ketQua.TKV6));
                Command.Parameters.Add(new MDB.MDBParameter("TKV7", ketQua.TKV7));
                Command.Parameters.Add(new MDB.MDBParameter("TKV8", ketQua.TKV8));
                Command.Parameters.Add(new MDB.MDBParameter("TKC1", ketQua.TKC1));
                Command.Parameters.Add(new MDB.MDBParameter("TKC2", ketQua.TKC2));
                Command.Parameters.Add(new MDB.MDBParameter("TKC3", ketQua.TKC3));
                Command.Parameters.Add(new MDB.MDBParameter("TKC4", ketQua.TKC4));
                Command.Parameters.Add(new MDB.MDBParameter("TKC5", ketQua.TKC5));
                Command.Parameters.Add(new MDB.MDBParameter("TKN1", ketQua.TKN1));
                Command.Parameters.Add(new MDB.MDBParameter("TKN2", ketQua.TKN2));
                Command.Parameters.Add(new MDB.MDBParameter("TKN3", ketQua.TKN3));
                Command.Parameters.Add(new MDB.MDBParameter("TKN4", ketQua.TKN4));
                Command.Parameters.Add(new MDB.MDBParameter("DuongKhac1", ketQua.DuongKhac1));
                Command.Parameters.Add(new MDB.MDBParameter("TKN5", ketQua.TKN5));
                Command.Parameters.Add(new MDB.MDBParameter("DuongKhac2", ketQua.DuongKhac2));
                Command.Parameters.Add(new MDB.MDBParameter("TKN6", ketQua.TKN6));
                Command.Parameters.Add(new MDB.MDBParameter("TKN7", ketQua.TKN7));
                Command.Parameters.Add(new MDB.MDBParameter("TKN8", ketQua.TKN8));
                Command.Parameters.Add(new MDB.MDBParameter("TKN8_Khac", ketQua.TKN8_Khac));
                Command.Parameters.Add(new MDB.MDBParameter("BacSyGayMe", ketQua.BacSyGayMe));
                Command.Parameters.Add(new MDB.MDBParameter("MaBacSyGayMe", ketQua.MaBacSyGayMe));
                Command.Parameters.Add(new MDB.MDBParameter("DieuDuong1", ketQua.DieuDuong1));
                Command.Parameters.Add(new MDB.MDBParameter("MaDieuDuong1", ketQua.MaDieuDuong1));
                Command.Parameters.Add(new MDB.MDBParameter("BacSyTMCT", ketQua.BacSyTMCT));
                Command.Parameters.Add(new MDB.MDBParameter("MaBacSyTMCT", ketQua.MaBacSyTMCT));
                Command.Parameters.Add(new MDB.MDBParameter("DieuDuong2", ketQua.DieuDuong2));
                Command.Parameters.Add(new MDB.MDBParameter("MaDieuDuong2", ketQua.MaDieuDuong2));
                Command.Parameters.Add(new MDB.MDBParameter("DieuDuong3", ketQua.DieuDuong3));
                Command.Parameters.Add(new MDB.MDBParameter("MaDieuDuong3", ketQua.MaDieuDuong3));
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
                XuLyLoi.Handle(ex);
            }
            return false;
        }
        public static bool delete(MDB.MDBConnection MyConnection, long id)
        {
            try
            {
                string sql = "DELETE FROM BangKiemAnToanTT_CTTM2 WHERE ID = :ID";
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
                P.* 
            FROM
               BangKiemAnToanTT_CTTM2 P
            WHERE
                ID = " + id;

            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
            MDB.MDBDataAdapter adt = new MDB.MDBDataAdapter(Command);
            var ds = new DataSet();

            adt.Fill(ds, "BK");

            ds.Tables[0].AddColumn("TenBenhNhan", typeof(string));
            ds.Tables[0].AddColumn("MaBenhNhan", typeof(string));
            ds.Tables[0].AddColumn("GioiTinh", typeof(string));
            ds.Tables[0].AddColumn("Tuoi", typeof(string));
            ds.Tables[0].AddColumn("SOYTE", typeof(string));
            ds.Tables[0].AddColumn("BENHVIEN", typeof(string));
            ds.Tables[0].AddColumn("KHOA", typeof(string));
            ds.Tables[0].AddColumn("SoVaoVien", typeof(string));

            ds.Tables[0].Rows[0]["TenBenhNhan"] = XemBenhAn._HanhChinhBenhNhan.TenBenhNhan;
            ds.Tables[0].Rows[0]["MaBenhNhan"] = XemBenhAn._HanhChinhBenhNhan.MaBenhNhan;
            ds.Tables[0].Rows[0]["GioiTinh"] = XemBenhAn._HanhChinhBenhNhan.GioiTinh.Description();
            ds.Tables[0].Rows[0]["Tuoi"] = XemBenhAn._HanhChinhBenhNhan.Tuoi;
            ds.Tables[0].Rows[0]["SOYTE"] = XemBenhAn._HanhChinhBenhNhan.SoYTe;
            ds.Tables[0].Rows[0]["BENHVIEN"] = XemBenhAn._HanhChinhBenhNhan.BenhVien;
            ds.Tables[0].Rows[0]["KHOA"] = XemBenhAn._ThongTinDieuTri.Khoa;
            ds.Tables[0].Rows[0]["SoVaoVien"] = XemBenhAn._ThongTinDieuTri.SoNhapVien;

            return ds;
        }
    }


}
