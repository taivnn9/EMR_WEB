
using EMR.KyDienTu;
using PMS.Access;
using System;
using System.Collections.Generic;
using System.Data;

namespace EMR_MAIN.DATABASE.Other
{
    public class ChiBaoChatLuongGiacNgu : ThongTinKy
    {
        public ChiBaoChatLuongGiacNgu()
        {
            TableName = "ChiBaoChatLuongGiacNgu";
            TablePrimaryKeyName = "ID";
            IDMauPhieu = (int)DanhMucPhieu.CBCLGN;
            TenMauPhieu = DanhMucPhieu.CBCLGN.Description();
        }
        [MoTaDuLieu("Mã định danh")]
		public long ID { get; set; }
        [MoTaDuLieu("Mã quản lý: mã duy nhất trong 1 đợt khám chữa bệnh (kcb), không trùng giữa các đợt kcb khác nhau","",1)]
		public decimal MaQuanLy { get; set; }
        [MoTaDuLieu("Mã bệnh nhân")]
		public string MaBenhNhan { get; set; }
        [MoTaDuLieu("Họ và tên bệnh nhân")]
		public string TenBenhNhan { get; set; }
        [MoTaDuLieu("Khoa")]
		public string Khoa { get; set; }
        [MoTaDuLieu("Tuổi bệnh nhân")]
		public string Tuoi { get; set; }
        [MoTaDuLieu("Giới tính bệnh nhân")]
		public string GioiTinh { get; set; }
        [MoTaDuLieu("Địa chỉ nhà bệnh nhân")]
		public string DiaChi { get; set; }
        [MoTaDuLieu("Nghề nghiệp")]
		public string NgheNghiep { get; set; }
        [MoTaDuLieu("Chẩn đoán bệnh")]
		public string ChanDoan { get; set; }
        [MoTaDuLieu("Ngày chỉ định")]
        public DateTime? NgayChiDinh { get; set; }
        [MoTaDuLieu("Mã bác sĩ chỉ định")]
        public string MaBacSiChiDinh { get; set; }
        [MoTaDuLieu("Tên bác sỹ chỉ định")]
        public string BacSiChiDinh { get; set; }
        [MoTaDuLieu("Mã người thực hiện")]
		public string MaNguoiThucHien { get; set; }
        [MoTaDuLieu("Người thực hiện")]
		public string NguoiThucHien { get; set; }
        [MoTaDuLieu("Trong tháng vừa qua, anh (chị) thường đi ngủ lúc mấy giờ?; Giờ đi ngủ thường là:")]
        public string GiacNgu_1 { get; set; }
        [MoTaDuLieu("Trong tháng vừa qua, mỗi tối anh (chị) thường mất bao nhiêu thời gian mới đi vào giấc ngủ được?;Số phút thường là:")]
        public string GiacNgu_2 { get; set; }
        [MoTaDuLieu("")]
        public string GiacNgu_3 { get; set; }
        [MoTaDuLieu("")]
        public string GiacNgu_4 { get; set; }

        public bool[] GiacNgu_5_1_Array { get; } = new bool[] { false, false, false, false };
        public int GiacNgu_5_1
        {
            get
            {
                return Array.IndexOf(GiacNgu_5_1_Array, true) + 1;
            }
            set
            {
                for (int i = 0; i < GiacNgu_5_1_Array.Length; i++)
                {
                    if (i == (value - 1)) GiacNgu_5_1_Array[i] = true;
                    else GiacNgu_5_1_Array[i] = false;
                }
            }
        }
        public bool[] GiacNgu_5_2_Array { get; } = new bool[] { false, false, false, false };
        public int GiacNgu_5_2
        {
            get
            {
                return Array.IndexOf(GiacNgu_5_2_Array, true) + 1;
            }
            set
            {
                for (int i = 0; i < GiacNgu_5_2_Array.Length; i++)
                {
                    if (i == (value - 1)) GiacNgu_5_2_Array[i] = true;
                    else GiacNgu_5_2_Array[i] = false;
                }
            }
        }
        public bool[] GiacNgu_5_3_Array { get; } = new bool[] { false, false, false, false };
        public int GiacNgu_5_3
        {
            get
            {
                return Array.IndexOf(GiacNgu_5_3_Array, true) + 1;
            }
            set
            {
                for (int i = 0; i < GiacNgu_5_3_Array.Length; i++)
                {
                    if (i == (value - 1)) GiacNgu_5_3_Array[i] = true;
                    else GiacNgu_5_3_Array[i] = false;
                }
            }
        }
        public bool[] GiacNgu_5_4_Array { get; } = new bool[] { false, false, false, false };
        public int GiacNgu_5_4
        {
            get
            {
                return Array.IndexOf(GiacNgu_5_4_Array, true) + 1;
            }
            set
            {
                for (int i = 0; i < GiacNgu_5_4_Array.Length; i++)
                {
                    if (i == (value - 1)) GiacNgu_5_4_Array[i] = true;
                    else GiacNgu_5_4_Array[i] = false;
                }
            }
        }
        public bool[] GiacNgu_5_5_Array { get; } = new bool[] { false, false, false, false };
        public int GiacNgu_5_5
        {
            get
            {
                return Array.IndexOf(GiacNgu_5_5_Array, true) + 1;
            }
            set
            {
                for (int i = 0; i < GiacNgu_5_5_Array.Length; i++)
                {
                    if (i == (value - 1)) GiacNgu_5_5_Array[i] = true;
                    else GiacNgu_5_5_Array[i] = false;
                }
            }
        }
        public bool[] GiacNgu_5_6_Array { get; } = new bool[] { false, false, false, false };
        public int GiacNgu_5_6
        {
            get
            {
                return Array.IndexOf(GiacNgu_5_6_Array, true) + 1;
            }
            set
            {
                for (int i = 0; i < GiacNgu_5_6_Array.Length; i++)
                {
                    if (i == (value - 1)) GiacNgu_5_6_Array[i] = true;
                    else GiacNgu_5_6_Array[i] = false;
                }
            }
        }
        public bool[] GiacNgu_5_7_Array { get; } = new bool[] { false, false, false, false };
        public int GiacNgu_5_7
        {
            get
            {
                return Array.IndexOf(GiacNgu_5_7_Array, true) + 1;
            }
            set
            {
                for (int i = 0; i < GiacNgu_5_7_Array.Length; i++)
                {
                    if (i == (value - 1)) GiacNgu_5_7_Array[i] = true;
                    else GiacNgu_5_7_Array[i] = false;
                }
            }
        }
        public bool[] GiacNgu_5_8_Array { get; } = new bool[] { false, false, false, false };
        public int GiacNgu_5_8
        {
            get
            {
                return Array.IndexOf(GiacNgu_5_8_Array, true) + 1;
            }
            set
            {
                for (int i = 0; i < GiacNgu_5_8_Array.Length; i++)
                {
                    if (i == (value - 1)) GiacNgu_5_8_Array[i] = true;
                    else GiacNgu_5_8_Array[i] = false;
                }
            }
        }
        public bool[] GiacNgu_5_9_Array { get; } = new bool[] { false, false, false, false };
        public int GiacNgu_5_9
        {
            get
            {
                return Array.IndexOf(GiacNgu_5_9_Array, true) + 1;
            }
            set
            {
                for (int i = 0; i < GiacNgu_5_9_Array.Length; i++)
                {
                    if (i == (value - 1)) GiacNgu_5_9_Array[i] = true;
                    else GiacNgu_5_9_Array[i] = false;
                }
            }
        }
        public bool[] GiacNgu_5_10_Array { get; } = new bool[] { false, false, false, false };
        public int GiacNgu_5_10
        {
            get
            {
                return Array.IndexOf(GiacNgu_5_10_Array, true) + 1;
            }
            set
            {
                for (int i = 0; i < GiacNgu_5_10_Array.Length; i++)
                {
                    if (i == (value - 1)) GiacNgu_5_10_Array[i] = true;
                    else GiacNgu_5_10_Array[i] = false;
                }
            }
        }
        public string GiacNgu_5_10_Text { get; set; }
        public bool[] GiacNgu_6_Array { get; } = new bool[] { false, false, false, false };
        public int GiacNgu_6
        {
            get
            {
                return Array.IndexOf(GiacNgu_6_Array, true) + 1;
            }
            set
            {
                for (int i = 0; i < GiacNgu_6_Array.Length; i++)
                {
                    if (i == (value - 1)) GiacNgu_6_Array[i] = true;
                    else GiacNgu_6_Array[i] = false;
                }
            }
        }
        public bool[] GiacNgu_7_Array { get; } = new bool[] { false, false, false, false };
        public int GiacNgu_7
        {
            get
            {
                return Array.IndexOf(GiacNgu_7_Array, true) + 1;
            }
            set
            {
                for (int i = 0; i < GiacNgu_7_Array.Length; i++)
                {
                    if (i == (value - 1)) GiacNgu_7_Array[i] = true;
                    else GiacNgu_7_Array[i] = false;
                }
            }
        }
        public bool[] GiacNgu_8_Array { get; } = new bool[] { false, false, false, false };
        public int GiacNgu_8
        {
            get
            {
                return Array.IndexOf(GiacNgu_8_Array, true) + 1;
            }
            set
            {
                for (int i = 0; i < GiacNgu_8_Array.Length; i++)
                {
                    if (i == (value - 1)) GiacNgu_8_Array[i] = true;
                    else GiacNgu_8_Array[i] = false;
                }
            }
        }
        public bool[] GiacNgu_9_Array { get; } = new bool[] { false, false, false, false };
        public int GiacNgu_9
        {
            get
            {
                return Array.IndexOf(GiacNgu_9_Array, true) + 1;
            }
            set
            {
                for (int i = 0; i < GiacNgu_9_Array.Length; i++)
                {
                    if (i == (value - 1)) GiacNgu_9_Array[i] = true;
                    else GiacNgu_9_Array[i] = false;
                }
            }
        }
        public string TongDiem { get; set; }
        public string KetLuan { get; set; }
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


    public class ChiBaoChatLuongGiacNguFunc
    {
        public const string TableName = "ChiBaoChatLuongGiacNgu";
        public const string TablePrimaryKeyName = "ID";

        public static List<ChiBaoChatLuongGiacNgu> GetListData(MDB.MDBConnection _OracleConnection, decimal maquanly)
        {
            List<ChiBaoChatLuongGiacNgu> list = new List<ChiBaoChatLuongGiacNgu>();
            try
            {
                string sql = @"SELECT * FROM ChiBaoChatLuongGiacNgu where MaQuanLy = :MaQuanLy";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, _OracleConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", maquanly));
                MDB.MDBDataReader DataReader = Command.ExecuteReader();
                while (DataReader.Read())
                {
                    ChiBaoChatLuongGiacNgu data = new ChiBaoChatLuongGiacNgu();
                    data.ID = Convert.ToInt64(DataReader.GetLong("ID").ToString());
                    data.MaQuanLy = maquanly;

                    data.MaBenhNhan = XemBenhAn._HanhChinhBenhNhan.MaBenhNhan;
                    data.TenBenhNhan = XemBenhAn._HanhChinhBenhNhan.TenBenhNhan;
                    data.Tuoi = XemBenhAn._HanhChinhBenhNhan.Tuoi;
                    data.GioiTinh = XemBenhAn._HanhChinhBenhNhan.GioiTinh.Description();
                    data.Khoa = XemBenhAn._ThongTinDieuTri.Khoa;

                    data.DiaChi = DataReader["DiaChi"].ToString();
                    data.NgheNghiep = DataReader["NgheNghiep"].ToString();
                    data.ChanDoan = DataReader["ChanDoan"].ToString();
                    data.NgheNghiep = DataReader["NgheNghiep"].ToString();
                    data.MaBacSiChiDinh = DataReader["MaBacSiChiDinh"].ToString();
                    data.BacSiChiDinh = DataReader["BacSiChiDinh"].ToString();
                    data.MaNguoiThucHien = DataReader["MaNguoiThucHien"].ToString();
                    data.NguoiThucHien = DataReader["NguoiThucHien"].ToString();

                    data.GiacNgu_1 = DataReader["GiacNgu_1"].ToString();
                    data.GiacNgu_2 = DataReader["GiacNgu_2"].ToString();
                    data.GiacNgu_3 = DataReader["GiacNgu_3"].ToString();
                    data.GiacNgu_4 = DataReader["GiacNgu_4"].ToString();

                    data.GiacNgu_5_1 = DataReader.GetInt("GiacNgu_5_1");
                    data.GiacNgu_5_2 = DataReader.GetInt("GiacNgu_5_2");
                    data.GiacNgu_5_3 = DataReader.GetInt("GiacNgu_5_3");
                    data.GiacNgu_5_4 = DataReader.GetInt("GiacNgu_5_4");
                    data.GiacNgu_5_5 = DataReader.GetInt("GiacNgu_5_5");
                    data.GiacNgu_5_6 = DataReader.GetInt("GiacNgu_5_6");
                    data.GiacNgu_5_7 = DataReader.GetInt("GiacNgu_5_7");
                    data.GiacNgu_5_8 = DataReader.GetInt("GiacNgu_5_8");
                    data.GiacNgu_5_9 = DataReader.GetInt("GiacNgu_5_9");
                    data.GiacNgu_5_10 = DataReader.GetInt("GiacNgu_5_10");
                    data.GiacNgu_5_10_Text = DataReader["GiacNgu_5_10_Text"].ToString();

                    data.GiacNgu_6 = DataReader.GetInt("GiacNgu_6");
                    data.GiacNgu_7 = DataReader.GetInt("GiacNgu_7");
                    data.GiacNgu_8 = DataReader.GetInt("GiacNgu_8");
                    data.GiacNgu_9 = DataReader.GetInt("GiacNgu_9");
                    
                    data.TongDiem = DataReader["TongDiem"].ToString();
                    data.KetLuan = DataReader["KetLuan"].ToString();

                    data.NgayChiDinh = Convert.ToDateTime(DataReader["NgayChiDinh"] == DBNull.Value ? DateTime.Now : DataReader["NgayChiDinh"]);

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
                sql = @"DELETE FROM ChiBaoChatLuongGiacNgu WHERE ID =" + IDBienBan;
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
            string sql = @"SELECT
                P.* 
            FROM
                ChiBaoChatLuongGiacNgu P
            WHERE
                ID = " + IDBienBan;

            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
            MDB.MDBDataAdapter adt = new MDB.MDBDataAdapter(Command);
            var ds = new DataSet();

            adt.Fill(ds, "TB");

            ds.Tables[0].AddColumn("TenBenhNhan", typeof(string));
            ds.Tables[0].AddColumn("Tuoi", typeof(string));
            ds.Tables[0].AddColumn("GioiTinh", typeof(string));
            ds.Tables[0].AddColumn("SoYTe", typeof(string));
            ds.Tables[0].AddColumn("Khoa", typeof(string));
            ds.Tables[0].AddColumn("BenhVien", typeof(string));
            ds.Tables[0].Rows[0]["TenBenhNhan"] = XemBenhAn._HanhChinhBenhNhan.TenBenhNhan;
            ds.Tables[0].Rows[0]["Tuoi"] = XemBenhAn._HanhChinhBenhNhan.Tuoi;
            ds.Tables[0].Rows[0]["GioiTinh"] = XemBenhAn._HanhChinhBenhNhan.GioiTinh.Description();
            ds.Tables[0].Rows[0]["SoYTe"] = XemBenhAn._HanhChinhBenhNhan.SoYTe;
            ds.Tables[0].Rows[0]["Khoa"] = XemBenhAn._ThongTinDieuTri.Khoa;
            ds.Tables[0].Rows[0]["BenhVien"] = XemBenhAn._HanhChinhBenhNhan.BenhVien;

            return ds;
        }
        public static bool InsertOrUpdate(MDB.MDBConnection MyConnection, ref ChiBaoChatLuongGiacNgu ketQua)
        {
            try
            {
                string sql = @"INSERT INTO ChiBaoChatLuongGiacNgu
                (
                    MaQuanLy,
                    DiaChi,
                    NgheNghiep,
                    NgayChiDinh,
                    ChanDoan,
                    BacSiChiDinh,
                    MaBacSiChiDinh,
                    NguoiThucHien,
                    MaNguoiThucHien,
                    GiacNgu_1,
                    GiacNgu_2,
                    GiacNgu_3,
                    GiacNgu_4,
                    GiacNgu_5_1,
                    GiacNgu_5_2,
                    GiacNgu_5_3,
                    GiacNgu_5_4,
                    GiacNgu_5_5,
                    GiacNgu_5_6,
                    GiacNgu_5_7,
                    GiacNgu_5_8,
                    GiacNgu_5_9,
                    GiacNgu_5_10,
                    GiacNgu_5_10_Text,
                    GiacNgu_6,
                    GiacNgu_7,
                    GiacNgu_8,
                    GiacNgu_9,
                    TongDiem,
                    KetLuan,
                    NGUOITAO,
                    NGUOISUA,
                    NGAYTAO,
                    NGAYSUA)  VALUES
                 (
				    :MaQuanLy,
                    :DiaChi,
                    :NgheNghiep,
                    :NgayChiDinh,
                    :ChanDoan,
                    :BacSiChiDinh,
                    :MaBacSiChiDinh,
                    :NguoiThucHien,
                    :MaNguoiThucHien,
                    :GiacNgu_1,
                    :GiacNgu_2,
                    :GiacNgu_3,
                    :GiacNgu_4,
                    :GiacNgu_5_1,
                    :GiacNgu_5_2,
                    :GiacNgu_5_3,
                    :GiacNgu_5_4,
                    :GiacNgu_5_5,
                    :GiacNgu_5_6,
                    :GiacNgu_5_7,
                    :GiacNgu_5_8,
                    :GiacNgu_5_9,
                    :GiacNgu_5_10,
                    :GiacNgu_5_10_Text,
                    :GiacNgu_6,
                    :GiacNgu_7,
                    :GiacNgu_8,
                    :GiacNgu_9,
                    :TongDiem,
                    :KetLuan,
                    :NGUOITAO,
                    :NGUOISUA,
                    :NGAYTAO,
                    :NGAYSUA
                 )  RETURNING ID INTO :ID";
                if (ketQua.ID != 0)
                {
                    sql = @"UPDATE ChiBaoChatLuongGiacNgu SET 
                    MaQuanLy = :MaQuanLy,
                    DiaChi = :DiaChi,
                    NgheNghiep = :NgheNghiep,
                    NgayChiDinh = :NgayChiDinh,
                    ChanDoan = :ChanDoan,
                    BacSiChiDinh = :BacSiChiDinh,
                    MaBacSiChiDinh = :MaBacSiChiDinh,
                    NguoiThucHien = :NguoiThucHien,
                    MaNguoiThucHien = :MaNguoiThucHien,
                    GiacNgu_1 = :GiacNgu_1,
                    GiacNgu_2 = :GiacNgu_2,
                    GiacNgu_3 = :GiacNgu_3,
                    GiacNgu_4 = :GiacNgu_4,
                    GiacNgu_5_1 = :GiacNgu_5_1,
                    GiacNgu_5_2 = :GiacNgu_5_2,
                    GiacNgu_5_3 = :GiacNgu_5_3,
                    GiacNgu_5_4 = :GiacNgu_5_4,
                    GiacNgu_5_5 = :GiacNgu_5_5,
                    GiacNgu_5_6 = :GiacNgu_5_6,
                    GiacNgu_5_7 = :GiacNgu_5_7,
                    GiacNgu_5_8 = :GiacNgu_5_8,
                    GiacNgu_5_9 = :GiacNgu_5_9,
                    GiacNgu_5_10 = :GiacNgu_5_10,
                    GiacNgu_5_10_Text = :GiacNgu_5_10_Text,
                    GiacNgu_6 = :GiacNgu_6,
                    GiacNgu_7 = :GiacNgu_7,
                    GiacNgu_8 = :GiacNgu_8,
                    GiacNgu_9 = :GiacNgu_9,
                    TongDiem = :TongDiem,
                    KetLuan = :KetLuan,
                    NGUOISUA = :NGUOISUA,
                    NGAYSUA = :NGAYSUA 
                    WHERE ID = " + ketQua.ID;
                }
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);

                Command.Parameters.Add(new MDB.MDBParameter("NGUOISUA", ketQua.NguoiSua));
                Command.Parameters.Add(new MDB.MDBParameter("NGAYSUA", ketQua.NgaySua));

                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", ketQua.MaQuanLy));

                Command.Parameters.Add(new MDB.MDBParameter("DiaChi", ketQua.DiaChi));
                Command.Parameters.Add(new MDB.MDBParameter("NgheNghiep", ketQua.NgheNghiep));
                Command.Parameters.Add(new MDB.MDBParameter("NgayChiDinh", ketQua.NgayChiDinh));
                Command.Parameters.Add(new MDB.MDBParameter("ChanDoan", ketQua.ChanDoan));
                Command.Parameters.Add(new MDB.MDBParameter("MaBacSiChiDinh", ketQua.MaBacSiChiDinh));
                Command.Parameters.Add(new MDB.MDBParameter("BacSiChiDinh", ketQua.BacSiChiDinh));
                Command.Parameters.Add(new MDB.MDBParameter("NguoiThucHien", ketQua.NguoiThucHien));
                Command.Parameters.Add(new MDB.MDBParameter("MaNguoiThucHien", ketQua.MaNguoiThucHien));

                Command.Parameters.Add(new MDB.MDBParameter("GiacNgu_1", ketQua.GiacNgu_1));
                Command.Parameters.Add(new MDB.MDBParameter("GiacNgu_2", ketQua.GiacNgu_2));
                Command.Parameters.Add(new MDB.MDBParameter("GiacNgu_3", ketQua.GiacNgu_3));
                Command.Parameters.Add(new MDB.MDBParameter("GiacNgu_4", ketQua.GiacNgu_4));

                Command.Parameters.Add(new MDB.MDBParameter("GiacNgu_5_1", ketQua.GiacNgu_5_1));
                Command.Parameters.Add(new MDB.MDBParameter("GiacNgu_5_2", ketQua.GiacNgu_5_2));
                Command.Parameters.Add(new MDB.MDBParameter("GiacNgu_5_3", ketQua.GiacNgu_5_3));
                Command.Parameters.Add(new MDB.MDBParameter("GiacNgu_5_4", ketQua.GiacNgu_5_4));
                Command.Parameters.Add(new MDB.MDBParameter("GiacNgu_5_5", ketQua.GiacNgu_5_5));
                Command.Parameters.Add(new MDB.MDBParameter("GiacNgu_5_6", ketQua.GiacNgu_5_6));
                Command.Parameters.Add(new MDB.MDBParameter("GiacNgu_5_7", ketQua.GiacNgu_5_7));
                Command.Parameters.Add(new MDB.MDBParameter("GiacNgu_5_8", ketQua.GiacNgu_5_8));
                Command.Parameters.Add(new MDB.MDBParameter("GiacNgu_5_9", ketQua.GiacNgu_5_9));
                Command.Parameters.Add(new MDB.MDBParameter("GiacNgu_5_10", ketQua.GiacNgu_5_10));
                Command.Parameters.Add(new MDB.MDBParameter("GiacNgu_5_10_Text", ketQua.GiacNgu_5_10_Text));

                Command.Parameters.Add(new MDB.MDBParameter("GiacNgu_6", ketQua.GiacNgu_6));
                Command.Parameters.Add(new MDB.MDBParameter("GiacNgu_7", ketQua.GiacNgu_7));
                Command.Parameters.Add(new MDB.MDBParameter("GiacNgu_8", ketQua.GiacNgu_8));
                Command.Parameters.Add(new MDB.MDBParameter("GiacNgu_9", ketQua.GiacNgu_9));

                Command.Parameters.Add(new MDB.MDBParameter("TongDiem", ketQua.TongDiem));
                Command.Parameters.Add(new MDB.MDBParameter("KetLuan", ketQua.KetLuan));

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
    }
}
