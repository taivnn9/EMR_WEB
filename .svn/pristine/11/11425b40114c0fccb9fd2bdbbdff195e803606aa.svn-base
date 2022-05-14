using EMR.KyDienTu;
using Newtonsoft.Json;
using PMS.Access;
using System;
using System.Collections.Generic;
using System.Data;

namespace EMR_MAIN.DATABASE.Other
{
    public class BangKiemAnToanThuThuat : ThongTinKy
    {
        public BangKiemAnToanThuThuat()
        {
            TableName = "BangKiemAnToanThuThuat";
            TablePrimaryKeyName = "ID";
            IDMauPhieu = (int)DanhMucPhieu.BKANTT;
            TenMauPhieu = DanhMucPhieu.BKANTT.Description();
        }
        [MoTaDuLieu("Mã định danh")]
		public long ID { get; set; }
        [MoTaDuLieu("Mã quản lý: mã duy nhất trong 1 đợt khám chữa bệnh (kcb), không trùng giữa các đợt kcb khác nhau","",1)]
		public decimal MaQuanLy { get; set; }
        [MoTaDuLieu("Mã bệnh nhân")]
		public string MaBenhNhan { get; set; }
        [MoTaDuLieu("Họ và tên bệnh nhân")] 
        public string HoTenBenhNhan { get; set; }
        [MoTaDuLieu("Ngày sinh bện nhân")]
        public DateTime? NgaySinh { get; set; }
        [MoTaDuLieu("Giới tính bệnh nhân")]
		public string GioiTinh { get; set; }
        [MoTaDuLieu("Chẩn đoán bệnh")]
		public string ChanDoan { get; set; }
        [MoTaDuLieu("Phương pháp phẫu thuật")]
        public string PhuongPhapPhauThuat { get; set; }
        [MoTaDuLieu("Vị trí thủ thuật")]
        public string ViTriThuThuat { get; set; }
        [JsonProperty("PHUONG_PHAP_GAY_ME")]
        [MoTaDuLieu("Phương pháp gây mê")]
        public string PhuongPhapGayMe { get; set; }
        public bool[] TGM1_Array { get; } = new bool[] { false, false};
        public int TGM1
        {
            get
            {
                return Array.IndexOf(TGM1_Array, true) + 1;
            }
            set
            {
                for (int i = 0; i < TGM1_Array.Length; i++)
                {
                    if (i == (value - 1)) TGM1_Array[i] = true;
                    else TGM1_Array[i] = false;
                }
            }
        }
        public bool[] TGM2_Array { get; } = new bool[] { false, false };
        public int TGM2
        {
            get
            {
                return Array.IndexOf(TGM2_Array, true) + 1;
            }
            set
            {
                for (int i = 0; i < TGM2_Array.Length; i++)
                {
                    if (i == (value - 1)) TGM2_Array[i] = true;
                    else TGM2_Array[i] = false;
                }
            }
        }
        public bool[] TGM3_Array { get; } = new bool[] { false, false };
        public int TGM3
        {
            get
            {
                return Array.IndexOf(TGM3_Array, true) + 1;
            }
            set
            {
                for (int i = 0; i < TGM3_Array.Length; i++)
                {
                    if (i == (value - 1)) TGM3_Array[i] = true;
                    else TGM3_Array[i] = false;
                }
            }
        }
        public bool[] TGM4_Array { get; } = new bool[] { false, false };
        public int TGM4
        {
            get
            {
                return Array.IndexOf(TGM4_Array, true) + 1;
            }
            set
            {
                for (int i = 0; i < TGM4_Array.Length; i++)
                {
                    if (i == (value - 1)) TGM4_Array[i] = true;
                    else TGM4_Array[i] = false;
                }
            }
        }
        public bool[] TGM5_Array { get; } = new bool[] { false, false };
        public int TGM5
        {
            get
            {
                return Array.IndexOf(TGM5_Array, true) + 1;
            }
            set
            {
                for (int i = 0; i < TGM5_Array.Length; i++)
                {
                    if (i == (value - 1)) TGM5_Array[i] = true;
                    else TGM5_Array[i] = false;
                }
            }
        }
        public bool[] TGM61_Array { get; } = new bool[] { false, false };
        public int TGM61
        {
            get
            {
                return Array.IndexOf(TGM61_Array, true) + 1;
            }
            set
            {
                for (int i = 0; i < TGM61_Array.Length; i++)
                {
                    if (i == (value - 1)) TGM61_Array[i] = true;
                    else TGM61_Array[i] = false;
                }
            }
        }
        public string TGM61_Text { get; set; }
        public bool[] TGM62_Array { get; } = new bool[] { false, false };
        public int TGM62
        {
            get
            {
                return Array.IndexOf(TGM62_Array, true) + 1;
            }
            set
            {
                for (int i = 0; i < TGM62_Array.Length; i++)
                {
                    if (i == (value - 1)) TGM62_Array[i] = true;
                    else TGM62_Array[i] = false;
                }
            }
        }
        public bool[] TGM63_Array { get; } = new bool[] { false, false };
        public int TGM63
        {
            get
            {
                return Array.IndexOf(TGM63_Array, true) + 1;
            }
            set
            {
                for (int i = 0; i < TGM63_Array.Length; i++)
                {
                    if (i == (value - 1)) TGM63_Array[i] = true;
                    else TGM63_Array[i] = false;
                }
            }
        }
        public string TGM63_Text { get; set; }
        public DateTime? TGM_ThoiGian_Gio { get; set; }
        public DateTime? TGM_ThoiGian { get; set; }
        public string TGM_BacSyGayMe { get; set; }
        public string TGM_MaBacSyGayMe { get; set; }
        public string TGM_TTV { get; set; }
        public string TGM_MaTTV { get; set; }
        public string TGM_KTV { get; set; }
        public string TGM_MaKTV { get; set; }

        public bool[] TTT1_Array { get; } = new bool[] { false, false };
        public string TTT1
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < TTT1_Array.Length; i++)
                    temp += (TTT1_Array[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        TTT1_Array[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public bool[] TTT2_Array { get; } = new bool[] { false, false };
        public int TTT2
        {
            get
            {
                return Array.IndexOf(TTT2_Array, true) + 1;
            }
            set
            {
                for (int i = 0; i < TTT2_Array.Length; i++)
                {
                    if (i == (value - 1)) TTT2_Array[i] = true;
                    else TTT2_Array[i] = false;
                }
            }
        }
        public bool[] TTT3_Array { get; } = new bool[] { false, false };
        public int TTT3
        {
            get
            {
                return Array.IndexOf(TTT3_Array, true) + 1;
            }
            set
            {
                for (int i = 0; i < TTT3_Array.Length; i++)
                {
                    if (i == (value - 1)) TTT3_Array[i] = true;
                    else TTT3_Array[i] = false;
                }
            }
        }
        public string TTT3_Text { get; set; }
        public bool[] TTT41_Array { get; } = new bool[] { false, false };
        public int TTT41
        {
            get
            {
                return Array.IndexOf(TTT41_Array, true) + 1;
            }
            set
            {
                for (int i = 0; i < TTT41_Array.Length; i++)
                {
                    if (i == (value - 1)) TTT41_Array[i] = true;
                    else TTT41_Array[i] = false;
                }
            }
        }
        public string TTT41_Text { get; set; }
        public bool[] TTT42_Array { get; } = new bool[] { false, false };
        public int TTT42
        {
            get
            {
                return Array.IndexOf(TTT42_Array, true) + 1;
            }
            set
            {
                for (int i = 0; i < TTT42_Array.Length; i++)
                {
                    if (i == (value - 1)) TTT42_Array[i] = true;
                    else TTT42_Array[i] = false;
                }
            }
        }
        public bool[] TTT51_Array { get; } = new bool[] { false, false };
        public int TTT51
        {
            get
            {
                return Array.IndexOf(TTT51_Array, true) + 1;
            }
            set
            {
                for (int i = 0; i < TTT51_Array.Length; i++)
                {
                    if (i == (value - 1)) TTT51_Array[i] = true;
                    else TTT51_Array[i] = false;
                }
            }
        }
        public bool[] TTT52_Array { get; } = new bool[] { false, false };
        public int TTT52
        {
            get
            {
                return Array.IndexOf(TTT52_Array, true) + 1;
            }
            set
            {
                for (int i = 0; i < TTT52_Array.Length; i++)
                {
                    if (i == (value - 1)) TTT52_Array[i] = true;
                    else TTT52_Array[i] = false;
                }
            }
        }
        public bool[] TTT6_Array { get; } = new bool[] { false, false };
        public int TTT6
        {
            get
            {
                return Array.IndexOf(TTT6_Array, true) + 1;
            }
            set
            {
                for (int i = 0; i < TTT6_Array.Length; i++)
                {
                    if (i == (value - 1)) TTT6_Array[i] = true;
                    else TTT6_Array[i] = false;
                }
            }
        }
        public DateTime? TTT_ThoiGian_Gio { get; set; }
        public DateTime? TTT_ThoiGian { get; set; }
        public string TTT_BacSyGayMe { get; set; }
        public string TTT_MaBacSyGayMe { get; set; }
        public string TTT_TTV { get; set; }
        public string TTT_MaTTV { get; set; }
        public string TTT_KTV { get; set; }
        public string TTT_MaKTV { get; set; }
        public bool[] TKR11_Array { get; } = new bool[] { false, false };
        public int TKR11
        {
            get
            {
                return Array.IndexOf(TKR11_Array, true) + 1;
            }
            set
            {
                for (int i = 0; i < TKR11_Array.Length; i++)
                {
                    if (i == (value - 1)) TKR11_Array[i] = true;
                    else TKR11_Array[i] = false;
                }
            }
        }
        public bool[] TKR12_Array { get; } = new bool[] { false, false };
        public int TKR12
        {
            get
            {
                return Array.IndexOf(TKR12_Array, true) + 1;
            }
            set
            {
                for (int i = 0; i < TKR12_Array.Length; i++)
                {
                    if (i == (value - 1)) TKR12_Array[i] = true;
                    else TKR12_Array[i] = false;
                }
            }
        }
        public bool[] TKR21_Array { get; } = new bool[] { false, false, false };
        public string TKR21
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < TKR21_Array.Length; i++)
                    temp += (TKR21_Array[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        TKR21_Array[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public bool[] TKR22_Array { get; } = new bool[] { false, false, false };
        public string TKR22
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < TKR22_Array.Length; i++)
                    temp += (TKR22_Array[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        TKR22_Array[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public bool TKR3 { get; set; }
        public string TKR3_Text { get; set; }
        public bool[] TNBRP1_Array { get; } = new bool[] { false, false };
        public int TNBRP1
        {
            get
            {
                return Array.IndexOf(TNBRP1_Array, true) + 1;
            }
            set
            {
                for (int i = 0; i < TNBRP1_Array.Length; i++)
                {
                    if (i == (value - 1)) TNBRP1_Array[i] = true;
                    else TNBRP1_Array[i] = false;
                }
            }
        }
        public bool[] TNBRP2_Array { get; } = new bool[] { false, false };
        public int TNBRP2
        {
            get
            {
                return Array.IndexOf(TNBRP2_Array, true) + 1;
            }
            set
            {
                for (int i = 0; i < TNBRP2_Array.Length; i++)
                {
                    if (i == (value - 1)) TNBRP2_Array[i] = true;
                    else TNBRP2_Array[i] = false;
                }
            }
        }
        public bool[] TNBRP3_Array { get; } = new bool[] { false, false };
        public int TNBRP3
        {
            get
            {
                return Array.IndexOf(TNBRP3_Array, true) + 1;
            }
            set
            {
                for (int i = 0; i < TNBRP3_Array.Length; i++)
                {
                    if (i == (value - 1)) TNBRP3_Array[i] = true;
                    else TNBRP3_Array[i] = false;
                }
            }
        }
        public DateTime? TKR_ThoiGian_Gio { get; set; }
        public DateTime? TKR_ThoiGian { get; set; }
        public string TKR_BacSyGayMe { get; set; }
        public string TKR_MaBacSyGayMe { get; set; }
        public string TKR_TTV { get; set; }
        public string TKR_MaTTV { get; set; }
        public string TKR_KTV { get; set; }
        public string TKR_MaKTV { get; set; }
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
    public class BangKiemAnToanThuThuatFunc
    {
        public const string TableName = "BangKiemAnToanThuThuat";
        public const string TablePrimaryKeyName = "ID";
        public static List<BangKiemAnToanThuThuat> GetListData(MDB.MDBConnection _OracleConnection, decimal maquanly, int Loai)
        {
            List<BangKiemAnToanThuThuat> list = new List<BangKiemAnToanThuThuat>();
            try
            {
                string sql = @"SELECT * FROM BangKiemAnToanThuThuat where MaQuanLy = :MaQuanLy and Loai = :Loai";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, _OracleConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", maquanly));
                Command.Parameters.Add(new MDB.MDBParameter("Loai", Loai));
                MDB.MDBDataReader DataReader = Command.ExecuteReader();
                while (DataReader.Read())
                {
                    BangKiemAnToanThuThuat data = new BangKiemAnToanThuThuat();
                    data.ID = Convert.ToInt64(DataReader.GetLong("ID").ToString());
                    data.MaQuanLy = maquanly;
                    data.MaBenhNhan = DataReader["MaBenhNhan"].ToString();
                    data.HoTenBenhNhan = XemBenhAn._HanhChinhBenhNhan.TenBenhNhan;
                    data.NgaySinh = DataReader["NgaySinh"] != DBNull.Value ? (DateTime?)Convert.ToDateTime(DataReader["NgaySinh"]) : null;
                    data.GioiTinh = XemBenhAn._HanhChinhBenhNhan.GioiTinh.Description();
                    data.ChanDoan = DataReader["ChanDoan"].ToString();
                    data.PhuongPhapPhauThuat = DataReader["PhuongPhapPhauThuat"].ToString();
                    data.ViTriThuThuat = DataReader["ViTriThuThuat"].ToString();
                    data.PhuongPhapGayMe = DataReader["PhuongPhapGayMe"].ToString();

                    int tempInt = 0;
                    data.TGM1 = int.TryParse(DataReader["TGM1"].ToString(), out tempInt) ? tempInt : 0;
                    tempInt = 0;
                    data.TGM2 = int.TryParse(DataReader["TGM2"].ToString(), out tempInt) ? tempInt : 0;
                    tempInt = 0;
                    data.TGM3 = int.TryParse(DataReader["TGM3"].ToString(), out tempInt) ? tempInt : 0;
                    tempInt = 0;
                    data.TGM4 = int.TryParse(DataReader["TGM4"].ToString(), out tempInt) ? tempInt : 0;
                    tempInt = 0;
                    data.TGM5 = int.TryParse(DataReader["TGM5"].ToString(), out tempInt) ? tempInt : 0;
                    tempInt = 0;
                    data.TGM61 = int.TryParse(DataReader["TGM61"].ToString(), out tempInt) ? tempInt : 0;
                    data.TGM61_Text = DataReader["TGM61_Text"].ToString();

                    tempInt = 0;
                    data.TGM62 = int.TryParse(DataReader["TGM62"].ToString(), out tempInt) ? tempInt : 0;

                    tempInt = 0;
                    data.TGM63 = int.TryParse(DataReader["TGM63"].ToString(), out tempInt) ? tempInt : 0;
                    data.TGM63_Text = DataReader["TGM63_Text"].ToString();
                    data.TGM_ThoiGian = DataReader["TGM_ThoiGian"] != DBNull.Value ? (DateTime?) Convert.ToDateTime(DataReader["TGM_ThoiGian"]): null;
                    data.TGM_ThoiGian_Gio = data.TGM_ThoiGian;
                    data.TGM_BacSyGayMe = DataReader["TGM_BacSyGayMe"].ToString();
                    data.TGM_MaBacSyGayMe = DataReader["TGM_MaBacSyGayMe"].ToString();
                    data.TGM_TTV = DataReader["TGM_TTV"].ToString();
                    data.TGM_MaTTV = DataReader["TGM_MaTTV"].ToString();
                    data.TGM_KTV = DataReader["TGM_KTV"].ToString();
                    data.TGM_MaKTV = DataReader["TGM_MaKTV"].ToString();

                    data.TTT1 = DataReader["TTT1"].ToString();
                    tempInt = 0;
                    data.TTT2 = int.TryParse(DataReader["TTT2"].ToString(), out tempInt) ? tempInt : 0;

                    tempInt = 0;
                    data.TTT3 = int.TryParse(DataReader["TTT3"].ToString(), out tempInt) ? tempInt : 0;
                    data.TTT3_Text = DataReader["TTT3_Text"].ToString();

                    tempInt = 0;
                    data.TTT41 = int.TryParse(DataReader["TTT41"].ToString(), out tempInt) ? tempInt : 0;
                    data.TTT41_Text = DataReader["TTT41_Text"].ToString();

                    tempInt = 0;
                    data.TTT51 = int.TryParse(DataReader["TTT51"].ToString(), out tempInt) ? tempInt : 0;

                    tempInt = 0;
                    data.TTT52 = int.TryParse(DataReader["TTT52"].ToString(), out tempInt) ? tempInt : 0;

                    tempInt = 0;
                    data.TTT6 = int.TryParse(DataReader["TTT6"].ToString(), out tempInt) ? tempInt : 0;

                    data.TTT_ThoiGian = DataReader["TTT_ThoiGian"] != DBNull.Value ? (DateTime?)Convert.ToDateTime(DataReader["TTT_ThoiGian"]) : null;
                    data.TTT_ThoiGian_Gio = data.TTT_ThoiGian;
                    data.TTT_BacSyGayMe = DataReader["TTT_BacSyGayMe"].ToString();
                    data.TTT_MaBacSyGayMe = DataReader["TTT_MaBacSyGayMe"].ToString();
                    data.TTT_TTV = DataReader["TTT_TTV"].ToString();
                    data.TTT_MaTTV = DataReader["TTT_MaTTV"].ToString();
                    data.TTT_KTV = DataReader["TTT_KTV"].ToString();
                    data.TTT_MaKTV = DataReader["TTT_MaKTV"].ToString();

                    tempInt = 0;
                    data.TKR11 = int.TryParse(DataReader["TKR11"].ToString(), out tempInt) ? tempInt : 0;

                    tempInt = 0;
                    data.TKR12 = int.TryParse(DataReader["TKR12"].ToString(), out tempInt) ? tempInt : 0;
                    data.TKR21 = DataReader["TKR21"].ToString();
                    data.TKR22 = DataReader["TKR22"].ToString();

                    tempInt = 0;
                    data.TKR3 = DataReader["TKR3"].ToString().Equals("1") ? true:false;
                    data.TKR3_Text = DataReader["TKR3_Text"].ToString();

                    tempInt = 0;
                    data.TNBRP1 = int.TryParse(DataReader["TNBRP1"].ToString(), out tempInt) ? tempInt : 0;

                    tempInt = 0;
                    data.TNBRP2 = int.TryParse(DataReader["TNBRP2"].ToString(), out tempInt) ? tempInt : 0;

                    tempInt = 0;
                    data.TNBRP3 = int.TryParse(DataReader["TNBRP3"].ToString(), out tempInt) ? tempInt : 0;

                    data.TKR_ThoiGian = DataReader["TKR_ThoiGian"] != DBNull.Value ? (DateTime?)Convert.ToDateTime(DataReader["TKR_ThoiGian"]) : null;
                    data.TKR_ThoiGian_Gio = data.TKR_ThoiGian;
                    data.TKR_BacSyGayMe = DataReader["TKR_BacSyGayMe"].ToString();
                    data.TKR_MaBacSyGayMe = DataReader["TKR_MaBacSyGayMe"].ToString();
                    data.TKR_TTV = DataReader["TKR_TTV"].ToString();
                    data.TKR_MaTTV = DataReader["TKR_MaTTV"].ToString();
                    data.TKR_KTV = DataReader["TKR_KTV"].ToString();
                    data.TKR_MaKTV = DataReader["TKR_MaKTV"].ToString();

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
        public static bool InsertOrUpdate(MDB.MDBConnection MyConnection, ref BangKiemAnToanThuThuat ketQua, int Loai)
        {
            try
            {
                string sql = @"INSERT INTO BangKiemAnToanThuThuat
                (
                    MAQUANLY,
                    MaBenhNhan,
                    NgaySinh,
                    ChanDoan,
                    PhuongPhapPhauThuat,
                    ViTriThuThuat,
                    PhuongPhapGayMe,
                    TGM1,
                    TGM2,
                    TGM3,
                    TGM4,
                    TGM5,
                    TGM61,
                    TGM61_Text,
                    TGM62,
                    TGM63,
                    TGM63_Text,
                    TGM_ThoiGian,
                    TGM_BacSyGayMe,
                    TGM_MaBacSyGayMe,
                    TGM_TTV,
                    TGM_MaTTV,
                    TGM_KTV,
                    TGM_MaKTV,
                    TTT1,
                    TTT2,
                    TTT3,
                    TTT3_Text,
                    TTT41,
                    TTT41_Text,
                    TTT42,
                    TTT51,
                    TTT52,
                    TTT6,
                    TTT_ThoiGian,
                    TTT_BacSyGayMe,
                    TTT_MaBacSyGayMe,
                    TTT_TTV,
                    TTT_MaTTV,
                    TTT_KTV,
                    TTT_MaKTV,
                    TKR11,
                    TKR12,
                    TKR21,
                    TKR22,
                    TKR3,
                    TKR3_Text,
                    TNBRP1,
                    TNBRP2,
                    TNBRP3,
                    TKR_ThoiGian,
                    TKR_BacSyGayMe,
                    TKR_MaBacSyGayMe,
                    TKR_TTV,
                    TKR_MaTTV,
                    TKR_KTV,
                    TKR_MaKTV,
                    NGUOITAO,
                    NGUOISUA,
                    NGAYTAO,
                    NGAYSUA,
                    Loai)  VALUES
                 (
				    :MAQUANLY,
                    :MaBenhNhan,
                    :NgaySinh,
                    :ChanDoan,
                    :PhuongPhapPhauThuat,
                    :ViTriThuThuat,
                    :PhuongPhapGayMe,
                    :TGM1,
                    :TGM2,
                    :TGM3,
                    :TGM4,
                    :TGM5,
                    :TGM61,
                    :TGM61_Text,
                    :TGM62,
                    :TGM63,
                    :TGM63_Text,
                    :TGM_ThoiGian,
                    :TGM_BacSyGayMe,
                    :TGM_MaBacSyGayMe,
                    :TGM_TTV,
                    :TGM_MaTTV,
                    :TGM_KTV,
                    :TGM_MaKTV,
                    :TTT1,
                    :TTT2,
                    :TTT3,
                    :TTT3_Text,
                    :TTT41,
                    :TTT41_Text,
                    :TTT42,
                    :TTT51,
                    :TTT52,
                    :TTT6,
                    :TTT_ThoiGian,
                    :TTT_BacSyGayMe,
                    :TTT_MaBacSyGayMe,
                    :TTT_TTV,
                    :TTT_MaTTV,
                    :TTT_KTV,
                    :TTT_MaKTV,
                    :TKR11,
                    :TKR12,
                    :TKR21,
                    :TKR22,
                    :TKR3,
                    :TKR3_Text,
                    :TNBRP1,
                    :TNBRP2,
                    :TNBRP3,
                    :TKR_ThoiGian,
                    :TKR_BacSyGayMe,
                    :TKR_MaBacSyGayMe,
                    :TKR_TTV,
                    :TKR_MaTTV,
                    :TKR_KTV,
                    :TKR_MaKTV,
                    :NGUOITAO,
                    :NGUOISUA,
                    :NGAYTAO,
                    :NGAYSUA,
                    :Loai
                 )  RETURNING ID INTO :ID";
                if (ketQua.ID != 0)
                {
                    sql = @"UPDATE BangKiemAnToanThuThuat SET 
                    MAQUANLY = :MAQUANLY,
                    MaBenhNhan = :MaBenhNhan,
                    NgaySinh = :NgaySinh,
                    ChanDoan = :ChanDoan,
                    PhuongPhapPhauThuat = :PhuongPhapPhauThuat,
                    ViTriThuThuat = :ViTriThuThuat,
                    PhuongPhapGayMe = :PhuongPhapGayMe,
                    TGM1 = :TGM1,
                    TGM2 = :TGM2,
                    TGM3 = :TGM3,
                    TGM4 = :TGM4,
                    TGM5 = :TGM5,
                    TGM61 = :TGM61,
                    TGM61_Text = :TGM61_Text,
                    TGM62 = :TGM62,
                    TGM63 = :TGM63,
                    TGM63_Text = :TGM63_Text,
                    TGM_ThoiGian = :TGM_ThoiGian,
                    TGM_BacSyGayMe = :TGM_BacSyGayMe,
                    TGM_MaBacSyGayMe = :TGM_MaBacSyGayMe,
                    TGM_TTV = :TGM_TTV,
                    TGM_MaTTV = :TGM_MaTTV,
                    TGM_KTV = :TGM_KTV,
                    TGM_MaKTV = :TGM_MaKTV,
                    TTT1 = :TTT1,
                    TTT2 = :TTT2,
                    TTT3 = :TTT3,
                    TTT3_Text = :TTT3_Text,
                    TTT41 = :TTT41,
                    TTT41_Text = :TTT41_Text,
                    TTT42 = :TTT42,
                    TTT51 = :TTT51,
                    TTT52 = :TTT52,
                    TTT6 = :TTT6,
                    TTT_ThoiGian = :TTT_ThoiGian,
                    TTT_BacSyGayMe = :TTT_BacSyGayMe,
                    TTT_MaBacSyGayMe = :TTT_MaBacSyGayMe,
                    TTT_TTV = :TTT_TTV,
                    TTT_MaTTV = :TTT_MaTTV,
                    TTT_KTV = :TTT_KTV,
                    TTT_MaKTV = :TTT_MaKTV,
                    TKR11 = :TKR11,
                    TKR12 = :TKR12,
                    TKR21 = :TKR21,
                    TKR22 = :TKR22,
                    TKR3 = :TKR3,
                    TKR3_Text = :TKR3_Text,
                    TNBRP1 = :TNBRP1,
                    TNBRP2 = :TNBRP2,
                    TNBRP3 = :TNBRP3,
                    TKR_ThoiGian = :TKR_ThoiGian,
                    TKR_BacSyGayMe = :TKR_BacSyGayMe,
                    TKR_MaBacSyGayMe = :TKR_MaBacSyGayMe,
                    TKR_TTV = :TKR_TTV,
                    TKR_MaTTV = :TKR_MaTTV,
                    TKR_KTV = :TKR_KTV,
                    TKR_MaKTV = :TKR_MaKTV,
                    NGUOISUA = :NGUOISUA,
                    NGAYSUA = :NGAYSUA,
                    Loai = :Loai
                    WHERE ID = " + ketQua.ID;
                }
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MAQUANLY", ketQua.MaQuanLy));
                Command.Parameters.Add(new MDB.MDBParameter("MaBenhNhan", ketQua.MaBenhNhan));
                Command.Parameters.Add(new MDB.MDBParameter("NgaySinh", ketQua.NgaySinh));
                Command.Parameters.Add(new MDB.MDBParameter("ChanDoan", ketQua.ChanDoan));
                Command.Parameters.Add(new MDB.MDBParameter("PhuongPhapPhauThuat", ketQua.PhuongPhapPhauThuat));
                Command.Parameters.Add(new MDB.MDBParameter("ViTriThuThuat", ketQua.ViTriThuThuat));
                Command.Parameters.Add(new MDB.MDBParameter("PhuongPhapGayMe", ketQua.PhuongPhapGayMe));
                Command.Parameters.Add(new MDB.MDBParameter("TGM1", ketQua.TGM1));
                Command.Parameters.Add(new MDB.MDBParameter("TGM2", ketQua.TGM2));
                Command.Parameters.Add(new MDB.MDBParameter("TGM3", ketQua.TGM3));
                Command.Parameters.Add(new MDB.MDBParameter("TGM4", ketQua.TGM4));
                Command.Parameters.Add(new MDB.MDBParameter("TGM5", ketQua.TGM5));
                Command.Parameters.Add(new MDB.MDBParameter("TGM61", ketQua.TGM61));
                Command.Parameters.Add(new MDB.MDBParameter("TGM61_Text", ketQua.TGM61_Text));
                Command.Parameters.Add(new MDB.MDBParameter("TGM62", ketQua.TGM62));
                Command.Parameters.Add(new MDB.MDBParameter("TGM63", ketQua.TGM63));
                Command.Parameters.Add(new MDB.MDBParameter("TGM63_Text", ketQua.TGM63_Text));
                DateTime? TGM_ThoiGian = ketQua.TGM_ThoiGian;
                if (TGM_ThoiGian != null)
                {
                    var ThoiGianThucHien_Gio = ketQua.TGM_ThoiGian_Gio.HasValue ? ketQua.TGM_ThoiGian_Gio.Value.TimeOfDay : new TimeSpan(0, 0, 0);
                    TGM_ThoiGian = TGM_ThoiGian + ThoiGianThucHien_Gio;
                }
                Command.Parameters.Add(new MDB.MDBParameter("TGM_ThoiGian", TGM_ThoiGian));
                Command.Parameters.Add(new MDB.MDBParameter("TGM_BacSyGayMe", ketQua.TGM_BacSyGayMe));
                Command.Parameters.Add(new MDB.MDBParameter("TGM_MaBacSyGayMe", ketQua.TGM_MaBacSyGayMe));
                Command.Parameters.Add(new MDB.MDBParameter("TGM_TTV", ketQua.TGM_TTV));
                Command.Parameters.Add(new MDB.MDBParameter("TGM_MaTTV", ketQua.TGM_MaTTV));
                Command.Parameters.Add(new MDB.MDBParameter("TGM_KTV", ketQua.TGM_KTV));
                Command.Parameters.Add(new MDB.MDBParameter("TGM_MaKTV", ketQua.TGM_MaKTV));
                Command.Parameters.Add(new MDB.MDBParameter("TTT1", ketQua.TTT1));
                Command.Parameters.Add(new MDB.MDBParameter("TTT2", ketQua.TTT2));
                Command.Parameters.Add(new MDB.MDBParameter("TTT3", ketQua.TTT3));
                Command.Parameters.Add(new MDB.MDBParameter("TTT3_Text", ketQua.TTT3_Text));
                Command.Parameters.Add(new MDB.MDBParameter("TTT41", ketQua.TTT41));
                Command.Parameters.Add(new MDB.MDBParameter("TTT41_Text", ketQua.TTT41_Text));
                Command.Parameters.Add(new MDB.MDBParameter("TTT42", ketQua.TTT42));
                Command.Parameters.Add(new MDB.MDBParameter("TTT51", ketQua.TTT51));
                Command.Parameters.Add(new MDB.MDBParameter("TTT52", ketQua.TTT52));
                Command.Parameters.Add(new MDB.MDBParameter("TTT6", ketQua.TTT6));
                DateTime? TTT_ThoiGian = ketQua.TTT_ThoiGian;
                if (TTT_ThoiGian != null)
                {
                    var ThoiGianThucHien_Gio = ketQua.TTT_ThoiGian_Gio.HasValue ? ketQua.TTT_ThoiGian_Gio.Value.TimeOfDay : new TimeSpan(0, 0, 0);
                    TTT_ThoiGian = TTT_ThoiGian + ThoiGianThucHien_Gio;
                }
                Command.Parameters.Add(new MDB.MDBParameter("TTT_ThoiGian", TTT_ThoiGian));
                Command.Parameters.Add(new MDB.MDBParameter("TTT_BacSyGayMe", ketQua.TTT_BacSyGayMe));
                Command.Parameters.Add(new MDB.MDBParameter("TTT_MaBacSyGayMe", ketQua.TTT_MaBacSyGayMe));
                Command.Parameters.Add(new MDB.MDBParameter("TTT_TTV", ketQua.TTT_TTV));
                Command.Parameters.Add(new MDB.MDBParameter("TTT_MaTTV", ketQua.TTT_MaTTV));
                Command.Parameters.Add(new MDB.MDBParameter("TTT_KTV", ketQua.TTT_KTV));
                Command.Parameters.Add(new MDB.MDBParameter("TTT_MaKTV", ketQua.TTT_MaKTV));
                Command.Parameters.Add(new MDB.MDBParameter("TKR11", ketQua.TKR11));
                Command.Parameters.Add(new MDB.MDBParameter("TKR12", ketQua.TKR12));
                Command.Parameters.Add(new MDB.MDBParameter("TKR21", ketQua.TKR21));
                Command.Parameters.Add(new MDB.MDBParameter("TKR22", ketQua.TKR22));
                Command.Parameters.Add(new MDB.MDBParameter("TKR3", ketQua.TKR3 ? 1 : 0));
                Command.Parameters.Add(new MDB.MDBParameter("TKR3_Text", ketQua.TKR3_Text));
                Command.Parameters.Add(new MDB.MDBParameter("TNBRP1", ketQua.TNBRP1));
                Command.Parameters.Add(new MDB.MDBParameter("TNBRP2", ketQua.TNBRP2));
                Command.Parameters.Add(new MDB.MDBParameter("TNBRP3", ketQua.TNBRP3));
                DateTime? TKR_ThoiGian = ketQua.TKR_ThoiGian;
                if (TKR_ThoiGian != null)
                {
                    var ThoiGianThucHien_Gio = ketQua.TKR_ThoiGian_Gio.HasValue ? ketQua.TKR_ThoiGian_Gio.Value.TimeOfDay : new TimeSpan(0, 0, 0);
                    TKR_ThoiGian = TKR_ThoiGian + ThoiGianThucHien_Gio;
                }
                Command.Parameters.Add(new MDB.MDBParameter("TKR_ThoiGian", TKR_ThoiGian));
                Command.Parameters.Add(new MDB.MDBParameter("TKR_BacSyGayMe", ketQua.TKR_BacSyGayMe));
                Command.Parameters.Add(new MDB.MDBParameter("TKR_MaBacSyGayMe", ketQua.TKR_MaBacSyGayMe));
                Command.Parameters.Add(new MDB.MDBParameter("TKR_TTV", ketQua.TKR_TTV));
                Command.Parameters.Add(new MDB.MDBParameter("TKR_MaTTV", ketQua.TKR_MaTTV));
                Command.Parameters.Add(new MDB.MDBParameter("TKR_KTV", ketQua.TKR_KTV));
                Command.Parameters.Add(new MDB.MDBParameter("TKR_MaKTV", ketQua.TKR_MaKTV));

                Command.Parameters.Add(new MDB.MDBParameter("NGUOISUA", ketQua.NguoiSua));
                Command.Parameters.Add(new MDB.MDBParameter("NGAYSUA", ketQua.NgaySua));
                Command.Parameters.Add(new MDB.MDBParameter("Loai", Loai));
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
                string sql = "DELETE FROM BangKiemAnToanThuThuat WHERE ID = :ID";
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
                BangKiemAnToanThuThuat P
            WHERE
                ID = " + id;

            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
            MDB.MDBDataAdapter adt = new MDB.MDBDataAdapter(Command);
            var ds = new DataSet();

            adt.Fill(ds, "BK");

            ds.Tables[0].AddColumn("TenBenhNhan", typeof(string));
            ds.Tables[0].AddColumn("MaBenhNhan", typeof(string));
            ds.Tables[0].AddColumn("GioiTinh", typeof(string));
            ds.Tables[0].AddColumn("SOYTE", typeof(string));
            ds.Tables[0].AddColumn("BENHVIEN", typeof(string));
            ds.Tables[0].AddColumn("KHOA", typeof(string));

            ds.Tables[0].Rows[0]["TenBenhNhan"] = XemBenhAn._HanhChinhBenhNhan.TenBenhNhan;
            ds.Tables[0].Rows[0]["MaBenhNhan"] = XemBenhAn._HanhChinhBenhNhan.MaBenhNhan;
            ds.Tables[0].Rows[0]["GioiTinh"] = XemBenhAn._HanhChinhBenhNhan.GioiTinh.Description();
            ds.Tables[0].Rows[0]["SOYTE"] = XemBenhAn._HanhChinhBenhNhan.SoYTe;
            ds.Tables[0].Rows[0]["BENHVIEN"] = XemBenhAn._HanhChinhBenhNhan.BenhVien;
            ds.Tables[0].Rows[0]["KHOA"] = XemBenhAn._ThongTinDieuTri.Khoa;

            return ds;
        }
    }

    public class BangKiemAnToanPhauThuat2: BangKiemAnToanThuThuat
    {
        public BangKiemAnToanPhauThuat2()
        {
            TableName = "BangKiemAnToanThuThuat";
            TablePrimaryKeyName = "ID";
            IDMauPhieu = (int)DanhMucPhieu.BKANPT;
            TenMauPhieu = DanhMucPhieu.BKANPT.Description();
        }
    }
}
