using EMR.KyDienTu;
using PMS.Access;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMR_MAIN.DATABASE.Other
{
    public class NghiemPhapBeckNhi : ThongTinKy
    {
        public NghiemPhapBeckNhi()
        {
            TableName = "NghiemPhapBeckNhi";
            TablePrimaryKeyName = "ID";
            IDMauPhieu = (int)DanhMucPhieu.NPBN;
            TenMauPhieu = DanhMucPhieu.NPBN.Description();
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
        [MoTaDuLieu("Địa chỉ nhà bệnh nhân")]
		public string DiaChi { get; set; }
        [MoTaDuLieu("Nghề nghiệp")]
		public string NgheNghiep { get; set; }
        public DateTime NgayLamTest { get; set; }
        public bool[] STT_1_Array { get; } = new bool[] { false, false, false, false};
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
        public bool[] STT_2_Array { get; } = new bool[] { false, false, false, false, false };
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
        public bool[] STT_3_Array { get; } = new bool[] { false, false, false, false, false };
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
        public bool[] STT_4_Array { get; } = new bool[] { false, false, false, false, false};
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
        public bool[] STT_5_Array { get; } = new bool[] { false, false, false, false, false};
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
        public bool[] STT_6_Array { get; } = new bool[] { false, false, false, false, false};
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
        public bool[] STT_7_Array { get; } = new bool[] { false, false, false, false, false };
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
        public bool[] STT_8_Array { get; } = new bool[] { false, false, false, false };
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
        public bool[] STT_9_Array { get; } = new bool[] { false, false, false, false, false, false};
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
        public bool[] STT_10_Array { get; } = new bool[] { false, false, false, false };
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
        public bool[] STT_11_Array { get; } = new bool[] { false, false, false, false };
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
        public bool[] STT_12_Array { get; } = new bool[] { false, false, false, false };
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
        public string NguoiLamTest { get; set; }
        public string MaNguoiLamTest { get; set; }
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
    public class NghiemPhapBeckNhiFunc
    {
        public const string TableName = "NghiemPhapBeckNhi";
        public const string TablePrimaryKeyName = "ID";
        public static List<NghiemPhapBeckNhi> GetListData(MDB.MDBConnection _OracleConnection, decimal maquanly)
        {
            List<NghiemPhapBeckNhi> list = new List<NghiemPhapBeckNhi>();
            try
            {
                string sql = @"SELECT * FROM NghiemPhapBeckNhi where MaQuanLy = :MaQuanLy";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, _OracleConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", maquanly));
                MDB.MDBDataReader DataReader = Command.ExecuteReader();
                while (DataReader.Read())
                {
                    NghiemPhapBeckNhi data = new NghiemPhapBeckNhi();
                    data.ID = Convert.ToInt64(DataReader.GetLong("ID").ToString());
                    data.MaQuanLy = maquanly;
                    data.MaBenhNhan = DataReader["MaBenhNhan"].ToString();
                    data.HoTenBenhNhan = XemBenhAn._HanhChinhBenhNhan.TenBenhNhan;
                    data.Tuoi = XemBenhAn._HanhChinhBenhNhan.Tuoi;
                    data.GioiTinh = XemBenhAn._HanhChinhBenhNhan.GioiTinh.Description();
                    data.ChanDoan = DataReader["ChanDoan"].ToString();
                    data.DiaChi = DataReader["DiaChi"].ToString();
                    data.NgheNghiep = DataReader["NgheNghiep"].ToString();
                    int tempInt = 0;

                    data.NgayLamTest = Convert.ToDateTime(DataReader["NgayLamTest"] == DBNull.Value ? DateTime.Now : DataReader["NgayLamTest"]);

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

                    data.NguoiLamTest = DataReader["NguoiLamTest"].ToString();
                    data.MaNguoiLamTest = DataReader["MaNguoiLamTest"].ToString();

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
        public static bool InsertOrUpdate(MDB.MDBConnection MyConnection, ref NghiemPhapBeckNhi ketQua)
        {
            try
            {
                string sql = @"INSERT INTO NghiemPhapBeckNhi
                (
                    MAQUANLY,
                    MaBenhNhan,
                    ChanDoan,
                    DiaChi, 
                    NgheNghiep, 
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
                    NguoiLamTest,
                    MaNguoiLamTest,
                    NGUOITAO,
                    NGUOISUA,
                    NGAYTAO,
                    NGAYSUA)  VALUES
                 (
				    :MAQUANLY,
                    :MaBenhNhan,
                    :ChanDoan,
                    :DiaChi, 
                    :NgheNghiep, 
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
                    :NguoiLamTest,
                    :MaNguoiLamTest,
                    :NGUOITAO,
                    :NGUOISUA,
                    :NGAYTAO,
                    :NGAYSUA
                 )  RETURNING ID INTO :ID";
                if (ketQua.ID != 0)
                {
                    sql = @"UPDATE NghiemPhapBeckNhi SET 
                    MAQUANLY = :MAQUANLY,
                    MaBenhNhan = :MaBenhNhan,
                    ChanDoan = :ChanDoan,
                    DiaChi = :DiaChi, 
                    NgheNghiep = :NgheNghiep, 
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
                    NguoiLamTest = :NguoiLamTest,
                    MaNguoiLamTest = :MaNguoiLamTest,
                    NGUOISUA = :NGUOISUA,
                    NGAYSUA = :NGAYSUA
                    WHERE ID = " + ketQua.ID;
                }
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MAQUANLY", ketQua.MaQuanLy));
                Command.Parameters.Add(new MDB.MDBParameter("MaBenhNhan", ketQua.MaBenhNhan));
                Command.Parameters.Add(new MDB.MDBParameter("ChanDoan", ketQua.ChanDoan));
                Command.Parameters.Add(new MDB.MDBParameter("DiaChi", ketQua.DiaChi));
                Command.Parameters.Add(new MDB.MDBParameter("NgheNghiep", ketQua.NgheNghiep));
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
                Command.Parameters.Add(new MDB.MDBParameter("NguoiLamTest", ketQua.NguoiLamTest));
                Command.Parameters.Add(new MDB.MDBParameter("MaNguoiLamTest", ketQua.MaNguoiLamTest));
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
                string sql = "DELETE FROM NghiemPhapBeckNhi WHERE ID = :ID";
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
                NghiemPhapBeckNhi P
            WHERE
                ID = " + id;

            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
            MDB.MDBDataAdapter adt = new MDB.MDBDataAdapter(Command);
            var ds = new DataSet();

            adt.Fill(ds, "KQ");

            ds.Tables[0].AddColumn("TenBenhNhan", typeof(string));
            ds.Tables[0].AddColumn("Tuoi", typeof(string));
            ds.Tables[0].AddColumn("GioiTinh", typeof(int));
            ds.Tables[0].AddColumn("SOYTE", typeof(string));
            ds.Tables[0].AddColumn("BENHVIEN", typeof(string));
            ds.Tables[0].AddColumn("KHOA", typeof(string));

            ds.Tables[0].Rows[0]["TenBenhNhan"] = XemBenhAn._HanhChinhBenhNhan.TenBenhNhan;
            ds.Tables[0].Rows[0]["Tuoi"] = XemBenhAn._HanhChinhBenhNhan.Tuoi;
            ds.Tables[0].Rows[0]["GioiTinh"] = (int)XemBenhAn._HanhChinhBenhNhan.GioiTinh;
            ds.Tables[0].Rows[0]["SOYTE"] = XemBenhAn._HanhChinhBenhNhan.SoYTe;
            ds.Tables[0].Rows[0]["BENHVIEN"] = XemBenhAn._HanhChinhBenhNhan.BenhVien;
            ds.Tables[0].Rows[0]["KHOA"] = XemBenhAn._ThongTinDieuTri.Khoa;

            return ds;
        }
    }
}
