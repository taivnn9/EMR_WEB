using EMR.KyDienTu;
using System;
using System.Collections.Generic;
using System.Data;
using PMS.Access;
using PMS.Access;

namespace EMR_MAIN.DATABASE.Other
{
    public class BangKiemNhanDienDungNguoiBenh : ThongTinKy
    {
        public BangKiemNhanDienDungNguoiBenh()
        {
            TableName = "BangKiemNhanDienNB";
            TablePrimaryKeyName = "ID";
            IDMauPhieu = (int)DanhMucPhieu.BKNDDNB;
            TenMauPhieu = DanhMucPhieu.BKNDDNB.Description();
        }
        [MoTaDuLieu("Mã định danh")]
		public long ID { get; set; }
        [MoTaDuLieu("Mã quản lý: mã duy nhất trong 1 đợt khám chữa bệnh (kcb), không trùng giữa các đợt kcb khác nhau","",1)]
		public decimal MaQuanLy { get; set; }
        [MoTaDuLieu("Mã bệnh nhân")]
		public string MaBenhNhan { get; set; }
        [MoTaDuLieu("Họ và tên bệnh nhân")]
		public string TenBenhNhan { get; set; }
        [MoTaDuLieu("Năm sinh")]
		public string NamSinh { get; set; }
        [MoTaDuLieu("Địa chỉ nhà bệnh nhân")]
		public string DiaChi { get; set; }
        [MoTaDuLieu("Ngày 1")]
        public DateTime? Ngay1 { get; set; }
        [MoTaDuLieu("Ngày 2")]
        public DateTime? Ngay2 { get; set; }
        [MoTaDuLieu("Ngày 3")]
        public DateTime? Ngay3 { get; set; }
        [MoTaDuLieu("Ngày 4")]
        public DateTime? Ngay4 { get; set; }
        [MoTaDuLieu("Ngày 5")]
        public DateTime? Ngay5 { get; set; }
        [MoTaDuLieu("Khoa 1")]
        public string Khoa1 { get; set; }
        [MoTaDuLieu("Khoa 2")]
        public string Khoa2 { get; set; }
        [MoTaDuLieu("Khoa 3")]
        public string Khoa3 { get; set; }
        [MoTaDuLieu("Khoa 4")]
        public string Khoa4 { get; set; }
        [MoTaDuLieu("Khoa 5")]
        public string Khoa5 { get; set; }

        public bool[] XNHoVaTenArray { get; } = new bool[] { false, false, false, false, false };
        [MoTaDuLieu("Họ và tên người bệnh")]
        public string XNHoVaTen
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < XNHoVaTenArray.Length; i++)
                    temp += (XNHoVaTenArray[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        XNHoVaTenArray[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public bool[] XNNamSinhArray { get; } = new bool[] { false, false, false, false, false };
        [MoTaDuLieu("Năm sinh người bệnh")]
        public string XNNamSinh
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < XNNamSinhArray.Length; i++)
                    temp += (XNNamSinhArray[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        XNNamSinhArray[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public bool[] XNDiaChiArray { get; } = new bool[] { false, false, false, false, false };
        [MoTaDuLieu("Địa chỉ người bệnh")]
        public string XNDiaChi
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < XNDiaChiArray.Length; i++)
                    temp += (XNDiaChiArray[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        XNDiaChiArray[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public bool[] DoiChieuArray { get; } = new bool[] { false, false, false, false, false };
        [MoTaDuLieu("Đối chiếu")]
        public string DoiChieu
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < DoiChieuArray.Length; i++)
                    temp += (DoiChieuArray[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        DoiChieuArray[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        [MoTaDuLieu("Họ tên người thực hiện 1")]
        public string NguoiThucHien1 { get; set; }
        [MoTaDuLieu("Họ tên người thực hiện 2")]
        public string NguoiThucHien2 { get; set; }
        [MoTaDuLieu("Họ tên người thực hiện 3")]
        public string NguoiThucHien3 { get; set; }
        [MoTaDuLieu("Họ tên người thực hiện 4")]
        public string NguoiThucHien4 { get; set; }
        [MoTaDuLieu("Họ tên người thực hiện 5")]
        public string NguoiThucHien5 { get; set; }
        [MoTaDuLieu("Mã người thực hiện 1")]
        public string MaNguoiThucHien1 { get; set; }
        [MoTaDuLieu("Mã người thực hiện 2")]
        public string MaNguoiThucHien2 { get; set; }
        [MoTaDuLieu("Mã người thực hiện 3")]
        public string MaNguoiThucHien3 { get; set; }
        [MoTaDuLieu("Mã người thực hiện 4")]
        public string MaNguoiThucHien4 { get; set; }
        [MoTaDuLieu("Mã người thực hiện 5")]
        public string MaNguoiThucHien5 { get; set; }

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
    public class BangKiemNhanDienDungNguoiBenhFunc
    {
        public const string TableName = "BangKiemNhanDienNB";
        public const string TablePrimaryKeyName = "ID";
        public static List<BangKiemNhanDienDungNguoiBenh> GetListData(MDB.MDBConnection _OracleConnection, decimal maquanly)
        {
            List<BangKiemNhanDienDungNguoiBenh> list = new List<BangKiemNhanDienDungNguoiBenh>();
            try
            {
                string sql = @"SELECT * FROM BangKiemNhanDienNB where MaQuanLy = :MaQuanLy";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, _OracleConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", maquanly));
                MDB.MDBDataReader DataReader = Command.ExecuteReader();
                while (DataReader.Read())
                {
                    BangKiemNhanDienDungNguoiBenh data = new BangKiemNhanDienDungNguoiBenh();
                    data.ID = Convert.ToInt64(DataReader.GetLong("ID").ToString());
                    data.MaQuanLy = maquanly;
                    data.MaBenhNhan = DataReader["MaBenhNhan"].ToString();
                    data.TenBenhNhan = DataReader["TenBenhNhan"].ToString();
                    data.NamSinh = DataReader["NamSinh"].ToString();
                    data.DiaChi = DataReader["DiaChi"].ToString();

                    data.Ngay1 = DataReader["Ngay1"] == DBNull.Value ? (DateTime?)null: DataReader.GetDate("Ngay1");
                    data.Ngay2 = DataReader["Ngay2"] == DBNull.Value ? (DateTime?)null : DataReader.GetDate("Ngay2");
                    data.Ngay3 = DataReader["Ngay3"] == DBNull.Value ? (DateTime?)null : DataReader.GetDate("Ngay3");
                    data.Ngay4 = DataReader["Ngay4"] == DBNull.Value ? (DateTime?)null : DataReader.GetDate("Ngay4");
                    data.Ngay5 = DataReader["Ngay5"] == DBNull.Value ? (DateTime?)null : DataReader.GetDate("Ngay5");

                    data.Khoa1 = DataReader["Khoa1"].ToString();
                    data.Khoa2 = DataReader["Khoa2"].ToString();
                    data.Khoa3 = DataReader["Khoa3"].ToString();
                    data.Khoa4 = DataReader["Khoa4"].ToString();
                    data.Khoa5 = DataReader["Khoa5"].ToString();
                    data.XNHoVaTen = DataReader["XNHoVaTen"].ToString();
                    data.XNNamSinh = DataReader["XNNamSinh"].ToString();
                    data.XNDiaChi = DataReader["XNDiaChi"].ToString();
                    data.DoiChieu = DataReader["DoiChieu"].ToString();

                    data.NguoiThucHien1 = DataReader["NguoiThucHien1"].ToString();
                    data.NguoiThucHien2 = DataReader["NguoiThucHien2"].ToString();
                    data.NguoiThucHien3 = DataReader["NguoiThucHien3"].ToString();
                    data.NguoiThucHien4 = DataReader["NguoiThucHien4"].ToString();
                    data.NguoiThucHien5 = DataReader["NguoiThucHien5"].ToString();
                    data.MaNguoiThucHien1 = DataReader["MaNguoiThucHien1"].ToString();
                    data.MaNguoiThucHien2 = DataReader["MaNguoiThucHien2"].ToString();
                    data.MaNguoiThucHien3 = DataReader["MaNguoiThucHien3"].ToString();
                    data.MaNguoiThucHien4 = DataReader["MaNguoiThucHien4"].ToString();
                    data.MaNguoiThucHien5 = DataReader["MaNguoiThucHien5"].ToString();

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
        public static bool InsertOrUpdate(MDB.MDBConnection MyConnection, ref BangKiemNhanDienDungNguoiBenh bangKiem)
        {
            try
            {
                string sql = @"INSERT INTO BangKiemNhanDienNB
                (
                    MAQUANLY,
                    MaBenhNhan,
                    TenBenhNhan,
                    NamSinh,
                    DiaChi,
                    Ngay1,
                    Ngay2,
                    Ngay3,
                    Ngay4,
                    Ngay5,
                    Khoa1,
                    Khoa2,
                    Khoa3,
                    Khoa4,
                    Khoa5,
                    XNHoVaTen,
                    XNNamSinh,
                    XNDiaChi,
                    DoiChieu,
                    NguoiThucHien1,
                    NguoiThucHien2,
                    NguoiThucHien3,
                    NguoiThucHien4,
                    NguoiThucHien5,
                    MaNguoiThucHien1,
                    MaNguoiThucHien2,
                    MaNguoiThucHien3,
                    MaNguoiThucHien4,
                    MaNguoiThucHien5,
                    NGUOITAO,
                    NGUOISUA,
                    NGAYTAO,
                    NGAYSUA)  VALUES
                 (
				    :MAQUANLY,
                    :MaBenhNhan,
                    :TenBenhNhan,
                    :NamSinh,
                    :DiaChi,
                    :Ngay1,
                    :Ngay2,
                    :Ngay3,
                    :Ngay4,
                    :Ngay5,
                    :Khoa1,
                    :Khoa2,
                    :Khoa3,
                    :Khoa4,
                    :Khoa5,
                    :XNHoVaTen,
                    :XNNamSinh,
                    :XNDiaChi,
                    :DoiChieu,
                    :NguoiThucHien1,
                    :NguoiThucHien2,
                    :NguoiThucHien3,
                    :NguoiThucHien4,
                    :NguoiThucHien5,
                    :MaNguoiThucHien1,
                    :MaNguoiThucHien2,
                    :MaNguoiThucHien3,
                    :MaNguoiThucHien4,
                    :MaNguoiThucHien5,
                    :NGUOITAO,
                    :NGUOISUA,
                    :NGAYTAO,
                    :NGAYSUA
                 )  RETURNING ID INTO :ID";
                if (bangKiem.ID != 0)
                {
                    sql = @"UPDATE BangKiemNhanDienNB SET 
                    MAQUANLY = :MAQUANLY,
                    MaBenhNhan = :MaBenhNhan,
                    TenBenhNhan = :TenBenhNhan,
                    NamSinh = :NamSinh,
                    DiaChi = :DiaChi,
                    Ngay1 = :Ngay1,
                    Ngay2 = :Ngay2,
                    Ngay3 = :Ngay3,
                    Ngay4 = :Ngay4,
                    Ngay5 = :Ngay5,
                    Khoa1 = :Khoa1,
                    Khoa2 = :Khoa2,
                    Khoa3 = :Khoa3,
                    Khoa4 = :Khoa4,
                    Khoa5 = :Khoa5,
                    XNHoVaTen = :XNHoVaTen,
                    XNNamSinh = :XNNamSinh,
                    XNDiaChi = :XNDiaChi,
                    DoiChieu = :DoiChieu,
                    NguoiThucHien1 = :NguoiThucHien1,
                    NguoiThucHien2 = :NguoiThucHien2,
                    NguoiThucHien3 = :NguoiThucHien3,
                    NguoiThucHien4 = :NguoiThucHien4,
                    NguoiThucHien5 = :NguoiThucHien5,
                    MaNguoiThucHien1 = :MaNguoiThucHien1,
                    MaNguoiThucHien2 = :MaNguoiThucHien2,
                    MaNguoiThucHien3 = :MaNguoiThucHien3,
                    MaNguoiThucHien4 = :MaNguoiThucHien4,
                    MaNguoiThucHien5 = :MaNguoiThucHien5,
                    NGUOISUA = :NGUOISUA,
                    NGAYSUA = :NGAYSUA
                    WHERE ID = " + bangKiem.ID;
                }
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MAQUANLY", bangKiem.MaQuanLy));
                Command.Parameters.Add(new MDB.MDBParameter("MaBenhNhan", bangKiem.MaBenhNhan));
                Command.Parameters.Add(new MDB.MDBParameter("TenBenhNhan", bangKiem.TenBenhNhan));
                Command.Parameters.Add(new MDB.MDBParameter("NamSinh", bangKiem.NamSinh));
                Command.Parameters.Add(new MDB.MDBParameter("DiaChi", bangKiem.DiaChi));
                Command.Parameters.Add(new MDB.MDBParameter("Ngay1", bangKiem.Ngay1));
                Command.Parameters.Add(new MDB.MDBParameter("Ngay2", bangKiem.Ngay2));
                Command.Parameters.Add(new MDB.MDBParameter("Ngay3", bangKiem.Ngay3));
                Command.Parameters.Add(new MDB.MDBParameter("Ngay4", bangKiem.Ngay4));
                Command.Parameters.Add(new MDB.MDBParameter("Ngay5", bangKiem.Ngay5));
                Command.Parameters.Add(new MDB.MDBParameter("Khoa1", bangKiem.Khoa1));
                Command.Parameters.Add(new MDB.MDBParameter("Khoa2", bangKiem.Khoa2));
                Command.Parameters.Add(new MDB.MDBParameter("Khoa3", bangKiem.Khoa3));
                Command.Parameters.Add(new MDB.MDBParameter("Khoa4", bangKiem.Khoa4));
                Command.Parameters.Add(new MDB.MDBParameter("Khoa5", bangKiem.Khoa5));
                Command.Parameters.Add(new MDB.MDBParameter("XNHoVaTen", bangKiem.XNHoVaTen));
                Command.Parameters.Add(new MDB.MDBParameter("XNNamSinh", bangKiem.XNNamSinh));
                Command.Parameters.Add(new MDB.MDBParameter("XNDiaChi", bangKiem.XNDiaChi));
                Command.Parameters.Add(new MDB.MDBParameter("DoiChieu", bangKiem.DoiChieu));
                Command.Parameters.Add(new MDB.MDBParameter("NguoiThucHien1", bangKiem.NguoiThucHien1));
                Command.Parameters.Add(new MDB.MDBParameter("NguoiThucHien2", bangKiem.NguoiThucHien2));
                Command.Parameters.Add(new MDB.MDBParameter("NguoiThucHien3", bangKiem.NguoiThucHien3));
                Command.Parameters.Add(new MDB.MDBParameter("NguoiThucHien4", bangKiem.NguoiThucHien4));
                Command.Parameters.Add(new MDB.MDBParameter("NguoiThucHien5", bangKiem.NguoiThucHien5));
                Command.Parameters.Add(new MDB.MDBParameter("MaNguoiThucHien1", bangKiem.MaNguoiThucHien1));
                Command.Parameters.Add(new MDB.MDBParameter("MaNguoiThucHien2", bangKiem.MaNguoiThucHien2));
                Command.Parameters.Add(new MDB.MDBParameter("MaNguoiThucHien3", bangKiem.MaNguoiThucHien3));
                Command.Parameters.Add(new MDB.MDBParameter("MaNguoiThucHien4", bangKiem.MaNguoiThucHien4));
                Command.Parameters.Add(new MDB.MDBParameter("MaNguoiThucHien5", bangKiem.MaNguoiThucHien5));
                Command.Parameters.Add(new MDB.MDBParameter("NGUOISUA", bangKiem.NguoiSua));
                Command.Parameters.Add(new MDB.MDBParameter("NGAYSUA", bangKiem.NgaySua));
                if (bangKiem.ID == 0)
                {
                    Command.Parameters.Add(new MDB.MDBParameter("ID", bangKiem.ID));
                    Command.Parameters.Add(new MDB.MDBParameter("NGUOITAO", bangKiem.NguoiTao));
                    Command.Parameters.Add(new MDB.MDBParameter("NGAYTAO", bangKiem.NgayTao));
                }
                Command.BindByName = true;
                int n = Command.ExecuteNonQuery();
                if (bangKiem.ID == 0)
                {
                    long nextval = Convert.ToInt64((Command.Parameters["ID"] as MDB.MDBParameter).Value);
                    bangKiem.ID = nextval;
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
                string sql = "DELETE FROM BangKiemNhanDienNB WHERE ID = :ID";
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
                B.*,
                H.SOYTE,
                H.BENHVIEN
            FROM
                BangKiemNhanDienNB B
                LEFT JOIN HANHCHINHBENHNHAN H ON B.MABENHNHAN = H.MABENHNHAN
            WHERE
                ID = " + id;

            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);

            MDB.MDBDataAdapter adt = new MDB.MDBDataAdapter(Command);
            var ds = new DataSet();
            adt.Fill(ds, "BK");

            return ds;
        }
    }
}
