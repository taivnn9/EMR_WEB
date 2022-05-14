using EMR.KyDienTu;
using PMS.Access;
using System;
using System.Collections.Generic;
using System.Data;
using PMS.Access;

namespace EMR_MAIN.DATABASE.Other
{
    public class DanhGiaTuKyTreNhoMChat : ThongTinKy
    {
        public DanhGiaTuKyTreNhoMChat()
        {
            TableName = "DanhGiaTuKyTreNhoMChat";
            TablePrimaryKeyName = "ID";
            IDMauPhieu = (int)DanhMucPhieu.DGTKOTNMC;
            TenMauPhieu = DanhMucPhieu.DGTKOTNMC.Description();
        }
        [MoTaDuLieu("Mã định danh")]
		public long ID { get; set; }
        [MoTaDuLieu("Mã quản lý: mã duy nhất trong 1 đợt khám chữa bệnh (kcb), không trùng giữa các đợt kcb khác nhau","",1)]
		public decimal MaQuanLy { get; set; }
        [MoTaDuLieu("Mã bệnh nhân")]
		public string MaBenhNhan { get; set; }
        public string HoTenBenhNhan { get; set; }
        public DateTime? NgaySinh { get; set; }
        [MoTaDuLieu("Giới tính bệnh nhân")]
		public string GioiTinh { get; set; }
        [MoTaDuLieu("Địa chỉ nhà bệnh nhân")]
		public string DiaChi { get; set; }
        public string DienThoai { get; set; }
        public DateTime NgayLamTest { get; set; }
        public bool[] STT_1_Array { get; } = new bool[] { false, false};
        public int STT_1
        {
            get
            {
                return Array.IndexOf(STT_1_Array, true) + 1;
            }
            set
            {
                for (int i = 0; i < STT_1_Array.Length; i++)
                {
                    if (i == (value - 1)) STT_1_Array[i] = true;
                    else STT_1_Array[i] = false;
                }
            }
        }
        public bool[] STT_2_Array { get; } = new bool[] { false, false };
        public int STT_2
        {
            get
            {
                return Array.IndexOf(STT_2_Array, true) + 1;
            }
            set
            {
                for (int i = 0; i < STT_2_Array.Length; i++)
                {
                    if (i == (value - 1)) STT_2_Array[i] = true;
                    else STT_2_Array[i] = false;
                }
            }
        }
        public bool[] STT_3_Array { get; } = new bool[] { false, false };
        public int STT_3
        {
            get
            {
                return Array.IndexOf(STT_3_Array, true) + 1;
            }
            set
            {
                for (int i = 0; i < STT_3_Array.Length; i++)
                {
                    if (i == (value - 1)) STT_3_Array[i] = true;
                    else STT_3_Array[i] = false;
                }
            }
        }
        public bool[] STT_4_Array { get; } = new bool[] { false, false };
        public int STT_4
        {
            get
            {
                return Array.IndexOf(STT_4_Array, true) + 1;
            }
            set
            {
                for (int i = 0; i < STT_4_Array.Length; i++)
                {
                    if (i == (value - 1)) STT_4_Array[i] = true;
                    else STT_4_Array[i] = false;
                }
            }
        }
        public bool[] STT_5_Array { get; } = new bool[] { false, false };
        public int STT_5
        {
            get
            {
                return Array.IndexOf(STT_5_Array, true) + 1;
            }
            set
            {
                for (int i = 0; i < STT_5_Array.Length; i++)
                {
                    if (i == (value - 1)) STT_5_Array[i] = true;
                    else STT_5_Array[i] = false;
                }
            }
        }
        public bool[] STT_6_Array { get; } = new bool[] { false, false };
        public int STT_6
        {
            get
            {
                return Array.IndexOf(STT_6_Array, true) + 1;
            }
            set
            {
                for (int i = 0; i < STT_6_Array.Length; i++)
                {
                    if (i == (value - 1)) STT_6_Array[i] = true;
                    else STT_6_Array[i] = false;
                }
            }
        }
        public bool[] STT_7_Array { get; } = new bool[] { false, false };
        public int STT_7
        {
            get
            {
                return Array.IndexOf(STT_7_Array, true) + 1;
            }
            set
            {
                for (int i = 0; i < STT_7_Array.Length; i++)
                {
                    if (i == (value - 1)) STT_7_Array[i] = true;
                    else STT_7_Array[i] = false;
                }
            }
        }
        public bool[] STT_8_Array { get; } = new bool[] { false, false };
        public int STT_8
        {
            get
            {
                return Array.IndexOf(STT_8_Array, true) + 1;
            }
            set
            {
                for (int i = 0; i < STT_8_Array.Length; i++)
                {
                    if (i == (value - 1)) STT_8_Array[i] = true;
                    else STT_8_Array[i] = false;
                }
            }
        }
        public bool[] STT_9_Array { get; } = new bool[] { false, false };
        public int STT_9
        {
            get
            {
                return Array.IndexOf(STT_9_Array, true) + 1;
            }
            set
            {
                for (int i = 0; i < STT_9_Array.Length; i++)
                {
                    if (i == (value - 1)) STT_9_Array[i] = true;
                    else STT_9_Array[i] = false;
                }
            }
        }
        public bool[] STT_10_Array { get; } = new bool[] { false, false };
        public int STT_10
        {
            get
            {
                return Array.IndexOf(STT_10_Array, true) + 1;
            }
            set
            {
                for (int i = 0; i < STT_10_Array.Length; i++)
                {
                    if (i == (value - 1)) STT_10_Array[i] = true;
                    else STT_10_Array[i] = false;
                }
            }
        }
        public bool[] STT_11_Array { get; } = new bool[] { false, false };
        public int STT_11
        {
            get
            {
                return Array.IndexOf(STT_11_Array, true) + 1;
            }
            set
            {
                for (int i = 0; i < STT_11_Array.Length; i++)
                {
                    if (i == (value - 1)) STT_11_Array[i] = true;
                    else STT_11_Array[i] = false;
                }
            }
        }
        public bool[] STT_12_Array { get; } = new bool[] { false, false };
        public int STT_12
        {
            get
            {
                return Array.IndexOf(STT_12_Array, true) + 1;
            }
            set
            {
                for (int i = 0; i < STT_12_Array.Length; i++)
                {
                    if (i == (value - 1)) STT_12_Array[i] = true;
                    else STT_12_Array[i] = false;
                }
            }
        }
        public bool[] STT_13_Array { get; } = new bool[] { false, false };
        public int STT_13
        {
            get
            {
                return Array.IndexOf(STT_13_Array, true) + 1;
            }
            set
            {
                for (int i = 0; i < STT_13_Array.Length; i++)
                {
                    if (i == (value - 1)) STT_13_Array[i] = true;
                    else STT_13_Array[i] = false;
                }
            }
        }
        public bool[] STT_14_Array { get; } = new bool[] { false, false };
        public int STT_14
        {
            get
            {
                return Array.IndexOf(STT_14_Array, true) + 1;
            }
            set
            {
                for (int i = 0; i < STT_14_Array.Length; i++)
                {
                    if (i == (value - 1)) STT_14_Array[i] = true;
                    else STT_14_Array[i] = false;
                }
            }
        }
        public bool[] STT_15_Array { get; } = new bool[] { false, false };
        public int STT_15
        {
            get
            {
                return Array.IndexOf(STT_15_Array, true) + 1;
            }
            set
            {
                for (int i = 0; i < STT_15_Array.Length; i++)
                {
                    if (i == (value - 1)) STT_15_Array[i] = true;
                    else STT_15_Array[i] = false;
                }
            }
        }
        public bool[] STT_16_Array { get; } = new bool[] { false, false };
        public int STT_16
        {
            get
            {
                return Array.IndexOf(STT_16_Array, true) + 1;
            }
            set
            {
                for (int i = 0; i < STT_16_Array.Length; i++)
                {
                    if (i == (value - 1)) STT_16_Array[i] = true;
                    else STT_16_Array[i] = false;
                }
            }
        }
        public bool[] STT_17_Array { get; } = new bool[] { false, false };
        public int STT_17
        {
            get
            {
                return Array.IndexOf(STT_17_Array, true) + 1;
            }
            set
            {
                for (int i = 0; i < STT_17_Array.Length; i++)
                {
                    if (i == (value - 1)) STT_17_Array[i] = true;
                    else STT_17_Array[i] = false;
                }
            }
        }
        public bool[] STT_18_Array { get; } = new bool[] { false, false };
        public int STT_18
        {
            get
            {
                return Array.IndexOf(STT_18_Array, true) + 1;
            }
            set
            {
                for (int i = 0; i < STT_18_Array.Length; i++)
                {
                    if (i == (value - 1)) STT_18_Array[i] = true;
                    else STT_18_Array[i] = false;
                }
            }
        }
        public bool[] STT_19_Array { get; } = new bool[] { false, false };
        public int STT_19
        {
            get
            {
                return Array.IndexOf(STT_19_Array, true) + 1;
            }
            set
            {
                for (int i = 0; i < STT_19_Array.Length; i++)
                {
                    if (i == (value - 1)) STT_19_Array[i] = true;
                    else STT_19_Array[i] = false;
                }
            }
        }
        public bool[] STT_20_Array { get; } = new bool[] { false, false };
        public int STT_20
        {
            get
            {
                return Array.IndexOf(STT_20_Array, true) + 1;
            }
            set
            {
                for (int i = 0; i < STT_20_Array.Length; i++)
                {
                    if (i == (value - 1)) STT_20_Array[i] = true;
                    else STT_20_Array[i] = false;
                }
            }
        }
        public bool[] STT_21_Array { get; } = new bool[] { false, false };
        public int STT_21
        {
            get
            {
                return Array.IndexOf(STT_21_Array, true) + 1;
            }
            set
            {
                for (int i = 0; i < STT_21_Array.Length; i++)
                {
                    if (i == (value - 1)) STT_21_Array[i] = true;
                    else STT_21_Array[i] = false;
                }
            }
        }
        public bool[] STT_22_Array { get; } = new bool[] { false, false };
        public int STT_22
        {
            get
            {
                return Array.IndexOf(STT_22_Array, true) + 1;
            }
            set
            {
                for (int i = 0; i < STT_22_Array.Length; i++)
                {
                    if (i == (value - 1)) STT_22_Array[i] = true;
                    else STT_22_Array[i] = false;
                }
            }
        }
        public bool[] STT_23_Array { get; } = new bool[] { false, false };
        public int STT_23
        {
            get
            {
                return Array.IndexOf(STT_23_Array, true) + 1;
            }
            set
            {
                for (int i = 0; i < STT_23_Array.Length; i++)
                {
                    if (i == (value - 1)) STT_23_Array[i] = true;
                    else STT_23_Array[i] = false;
                }
            }
        }
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
    public class DanhGiaTuKyTreNhoMChatFunc
    {
        public const string TableName = "DanhGiaTuKyTreNhoMChat";
        public const string TablePrimaryKeyName = "ID";
        public static List<DanhGiaTuKyTreNhoMChat> GetListData(MDB.MDBConnection _OracleConnection, decimal maquanly)
        {
            List<DanhGiaTuKyTreNhoMChat> list = new List<DanhGiaTuKyTreNhoMChat>();
            try
            {
                string sql = @"SELECT * FROM DanhGiaTuKyTreNhoMChat where MaQuanLy = :MaQuanLy";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, _OracleConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", maquanly));
                MDB.MDBDataReader DataReader = Command.ExecuteReader();
                while (DataReader.Read())
                {
                    DanhGiaTuKyTreNhoMChat data = new DanhGiaTuKyTreNhoMChat();
                    data.ID = Convert.ToInt64(DataReader.GetLong("ID").ToString());
                    data.MaQuanLy = maquanly;
                    data.MaBenhNhan = DataReader["MaBenhNhan"].ToString();
                    data.HoTenBenhNhan = XemBenhAn._HanhChinhBenhNhan.TenBenhNhan;
                    data.NgaySinh = XemBenhAn._HanhChinhBenhNhan.NgaySinh;
                    data.GioiTinh = XemBenhAn._HanhChinhBenhNhan.GioiTinh.Description();
                    data.DiaChi = DataReader["DiaChi"].ToString();
                    data.DienThoai = DataReader["DienThoai"].ToString();
                    data.NgayLamTest = Convert.ToDateTime(DataReader["NgayLamTest"] == DBNull.Value ? DateTime.Now : DataReader["NgayLamTest"]);

                    int tempInt = 0;

                    data.STT_1 = int.TryParse(DataReader["STT_1"].ToString(), out tempInt) ? tempInt : 0;

                    tempInt = 0;
                    data.STT_2 = int.TryParse(DataReader["STT_2"].ToString(), out tempInt) ? tempInt : 0;

                    tempInt = 0;
                    data.STT_3 = int.TryParse(DataReader["STT_3"].ToString(), out tempInt) ? tempInt : 0;

                    tempInt = 0;
                    data.STT_4 = int.TryParse(DataReader["STT_4"].ToString(), out tempInt) ? tempInt : 0;

                    tempInt = 0;
                    data.STT_5 = int.TryParse(DataReader["STT_5"].ToString(), out tempInt) ? tempInt : 0;

                    tempInt = 0;
                    data.STT_6 = int.TryParse(DataReader["STT_6"].ToString(), out tempInt) ? tempInt : 0;

                    tempInt = 0;
                    data.STT_7 = int.TryParse(DataReader["STT_7"].ToString(), out tempInt) ? tempInt : 0;

                    tempInt = 0;
                    data.STT_8 = int.TryParse(DataReader["STT_8"].ToString(), out tempInt) ? tempInt : 0;

                    tempInt = 0;
                    data.STT_9 = int.TryParse(DataReader["STT_9"].ToString(), out tempInt) ? tempInt : 0;

                    tempInt = 0;
                    data.STT_10 = int.TryParse(DataReader["STT_10"].ToString(), out tempInt) ? tempInt : 0;

                    tempInt = 0;
                    data.STT_11 = int.TryParse(DataReader["STT_11"].ToString(), out tempInt) ? tempInt : 0;

                    tempInt = 0;
                    data.STT_12 = int.TryParse(DataReader["STT_12"].ToString(), out tempInt) ? tempInt : 0;

                    tempInt = 0;
                    data.STT_13 = int.TryParse(DataReader["STT_13"].ToString(), out tempInt) ? tempInt : 0;

                    tempInt = 0;
                    data.STT_14 = int.TryParse(DataReader["STT_14"].ToString(), out tempInt) ? tempInt : 0;

                    tempInt = 0;
                    data.STT_15 = int.TryParse(DataReader["STT_15"].ToString(), out tempInt) ? tempInt : 0;

                    tempInt = 0;
                    data.STT_16 = int.TryParse(DataReader["STT_16"].ToString(), out tempInt) ? tempInt : 0;

                    tempInt = 0;
                    data.STT_17 = int.TryParse(DataReader["STT_17"].ToString(), out tempInt) ? tempInt : 0;

                    tempInt = 0;
                    data.STT_18 = int.TryParse(DataReader["STT_18"].ToString(), out tempInt) ? tempInt : 0;

                    tempInt = 0;
                    data.STT_19 = int.TryParse(DataReader["STT_19"].ToString(), out tempInt) ? tempInt : 0;

                    tempInt = 0;
                    data.STT_20 = int.TryParse(DataReader["STT_20"].ToString(), out tempInt) ? tempInt : 0;

                    tempInt = 0;
                    data.STT_21 = int.TryParse(DataReader["STT_21"].ToString(), out tempInt) ? tempInt : 0;

                    tempInt = 0;
                    data.STT_22 = int.TryParse(DataReader["STT_22"].ToString(), out tempInt) ? tempInt : 0;

                    tempInt = 0;
                    data.STT_23 = int.TryParse(DataReader["STT_23"].ToString(), out tempInt) ? tempInt : 0;

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
        public static bool InsertOrUpdate(MDB.MDBConnection MyConnection, ref DanhGiaTuKyTreNhoMChat ketQua)
        {
            try
            {
                string sql = @"INSERT INTO DanhGiaTuKyTreNhoMChat
                (
                    MAQUANLY,
                    MaBenhNhan,
                    NgaySinh,
                    DiaChi, 
                    DienThoai,
                    NgayLamTest,
                    STT_1,
                    STT_2,
                    STT_3,
                    STT_4,
                    STT_5,
                    STT_6,
                    STT_7,
                    STT_8,
                    STT_9,
                    STT_10,
                    STT_11,
                    STT_12,
                    STT_13,
                    STT_14,
                    STT_15,
                    STT_16,
                    STT_17,
                    STT_18,
                    STT_19,
                    STT_20,
                    STT_21,
                    STT_22,
                    STT_23,
                    NGUOITAO,
                    NGUOISUA,
                    NGAYTAO,
                    NGAYSUA)  VALUES
                 (
				    :MAQUANLY,
                    :MaBenhNhan,
                    :NgaySinh,
                    :DiaChi, 
                    :DienThoai,
                    :NgayLamTest,
                    :STT_1,
                    :STT_2,
                    :STT_3,
                    :STT_4,
                    :STT_5,
                    :STT_6,
                    :STT_7,
                    :STT_8,
                    :STT_9,
                    :STT_10,
                    :STT_11,
                    :STT_12,
                    :STT_13,
                    :STT_14,
                    :STT_15,
                    :STT_16,
                    :STT_17,
                    :STT_18,
                    :STT_19,
                    :STT_20,
                    :STT_21,
                    :STT_22,
                    :STT_23,
                    :NGUOITAO,
                    :NGUOISUA,
                    :NGAYTAO,
                    :NGAYSUA
                 )  RETURNING ID INTO :ID";
                if (ketQua.ID != 0)
                {
                    sql = @"UPDATE DanhGiaTuKyTreNhoMChat SET 
                    MAQUANLY = :MAQUANLY,
                    MaBenhNhan = :MaBenhNhan,
                    NgaySinh = :NgaySinh,
                    DienThoai = :DienThoai,
                    DiaChi = :DiaChi, 
                    NgayLamTest = :NgayLamTest,
                    STT_1 = :STT_1,
                    STT_2 = :STT_2,
                    STT_3 = :STT_3,
                    STT_4 = :STT_4,
                    STT_5 = :STT_5,
                    STT_6 = :STT_6,
                    STT_7 = :STT_7,
                    STT_8 = :STT_8,
                    STT_9 = :STT_9,
                    STT_10 = :STT_10,
                    STT_11 = :STT_11,
                    STT_12 = :STT_12,
                    STT_13 = :STT_13,
                    STT_14 = :STT_14,
                    STT_15 = :STT_15,
                    STT_16 = :STT_16,
                    STT_17 = :STT_17,
                    STT_18 = :STT_18,
                    STT_19 = :STT_19,
                    STT_20 = :STT_20,
                    STT_21 = :STT_21,
                    STT_22 = :STT_22,
                    STT_23 = :STT_23,
                    NGUOISUA = :NGUOISUA,
                    NGAYSUA = :NGAYSUA
                    WHERE ID = " + ketQua.ID;
                }
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MAQUANLY", ketQua.MaQuanLy));
                Command.Parameters.Add(new MDB.MDBParameter("MaBenhNhan", ketQua.MaBenhNhan));
                Command.Parameters.Add(new MDB.MDBParameter("NgaySinh", ketQua.NgaySinh));
                Command.Parameters.Add(new MDB.MDBParameter("DienThoai", ketQua.DienThoai));
                Command.Parameters.Add(new MDB.MDBParameter("DiaChi", ketQua.DiaChi));
                Command.Parameters.Add(new MDB.MDBParameter("NgayLamTest", ketQua.NgayLamTest));
                Command.Parameters.Add(new MDB.MDBParameter("STT_1", ketQua.STT_1));
                Command.Parameters.Add(new MDB.MDBParameter("STT_2", ketQua.STT_2));
                Command.Parameters.Add(new MDB.MDBParameter("STT_3", ketQua.STT_3));
                Command.Parameters.Add(new MDB.MDBParameter("STT_4", ketQua.STT_4));
                Command.Parameters.Add(new MDB.MDBParameter("STT_5", ketQua.STT_5));
                Command.Parameters.Add(new MDB.MDBParameter("STT_6", ketQua.STT_6));
                Command.Parameters.Add(new MDB.MDBParameter("STT_7", ketQua.STT_7));
                Command.Parameters.Add(new MDB.MDBParameter("STT_8", ketQua.STT_8));
                Command.Parameters.Add(new MDB.MDBParameter("STT_9", ketQua.STT_9));
                Command.Parameters.Add(new MDB.MDBParameter("STT_10", ketQua.STT_10));
                Command.Parameters.Add(new MDB.MDBParameter("STT_11", ketQua.STT_11));
                Command.Parameters.Add(new MDB.MDBParameter("STT_12", ketQua.STT_12));
                Command.Parameters.Add(new MDB.MDBParameter("STT_13", ketQua.STT_13));
                Command.Parameters.Add(new MDB.MDBParameter("STT_14", ketQua.STT_14));
                Command.Parameters.Add(new MDB.MDBParameter("STT_15", ketQua.STT_15));
                Command.Parameters.Add(new MDB.MDBParameter("STT_16", ketQua.STT_16));
                Command.Parameters.Add(new MDB.MDBParameter("STT_17", ketQua.STT_17));
                Command.Parameters.Add(new MDB.MDBParameter("STT_18", ketQua.STT_18));
                Command.Parameters.Add(new MDB.MDBParameter("STT_19", ketQua.STT_19));
                Command.Parameters.Add(new MDB.MDBParameter("STT_20", ketQua.STT_20));
                Command.Parameters.Add(new MDB.MDBParameter("STT_21", ketQua.STT_21));
                Command.Parameters.Add(new MDB.MDBParameter("STT_22", ketQua.STT_22));
                Command.Parameters.Add(new MDB.MDBParameter("STT_23", ketQua.STT_23));
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
                string sql = "DELETE FROM DanhGiaTuKyTreNhoMChat WHERE ID = :ID";
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
                DanhGiaTuKyTreNhoMChat P
            WHERE
                ID = " + id;

            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
            MDB.MDBDataAdapter adt = new MDB.MDBDataAdapter(Command);
            var ds = new DataSet();

            adt.Fill(ds, "KQ");

            ds.Tables[0].AddColumn("TenBenhNhan", typeof(string));
            ds.Tables[0].AddColumn("GioiTinh", typeof(int));
            ds.Tables[0].AddColumn("SOYTE", typeof(string));
            ds.Tables[0].AddColumn("BENHVIEN", typeof(string));
            ds.Tables[0].AddColumn("KHOA", typeof(string));

            ds.Tables[0].Rows[0]["TenBenhNhan"] = XemBenhAn._HanhChinhBenhNhan.TenBenhNhan;
            ds.Tables[0].Rows[0]["GioiTinh"] = (int)XemBenhAn._HanhChinhBenhNhan.GioiTinh;
            ds.Tables[0].Rows[0]["SOYTE"] = XemBenhAn._HanhChinhBenhNhan.SoYTe;
            ds.Tables[0].Rows[0]["BENHVIEN"] = XemBenhAn._HanhChinhBenhNhan.BenhVien;
            ds.Tables[0].Rows[0]["KHOA"] = XemBenhAn._ThongTinDieuTri.Khoa;

            return ds;
        }
    }
}
