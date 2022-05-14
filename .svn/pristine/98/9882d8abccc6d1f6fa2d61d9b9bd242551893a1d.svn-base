
using EMR.KyDienTu;
using PMS.Access;
using System;
using System.Collections.Generic;
using System.Data;

namespace EMR_MAIN.DATABASE.Other
{
    public class GiayCamKetDieuTri : ThongTinKy
    {
        public GiayCamKetDieuTri()
        {
            TableName = "GiayCamKetDieuTri";
            TablePrimaryKeyName = "ID";
            IDMauPhieu = (int)DanhMucPhieu.GCKDT;
            TenMauPhieu = DanhMucPhieu.GCKDT.Description();
        }
        [MoTaDuLieu("Mã định danh")]
		public long ID { get; set; }
        [MoTaDuLieu("Mã quản lý: mã duy nhất trong 1 đợt khám chữa bệnh (kcb), không trùng giữa các đợt kcb khác nhau","",1)]
		public decimal MaQuanLy { get; set; }
        [MoTaDuLieu("Mã bệnh nhân")]
		public string MaBenhNhan { get; set; }
        public string TenToiLa { get; set; }
        [MoTaDuLieu("Năm sinh")]
		public string NamSinh { get; set; }
        [MoTaDuLieu("Giới tính bệnh nhân")]
		public string GioiTinh { get; set; }
        public string NoiLam { get; set; }
        public DateTime? NgayLamGiay { get; set; }
        public bool[] NguoiBenhArray { get; } = new bool[] { false, false};
        public string NguoiBenh
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < NguoiBenhArray.Length; i++)
                    temp += (NguoiBenhArray[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        NguoiBenhArray[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        [MoTaDuLieu("Khoa")]
		public string Khoa { get; set; }
        [MoTaDuLieu("Họ và tên bệnh nhân")]
		public string TenBenhNhan { get; set; }
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

    public class GiayCamKetDieuTriFunc
    {
        public const string TableName = "GiayCamKetDieuTri";
        public const string TablePrimaryKeyName = "ID";

        public static List<GiayCamKetDieuTri> GetListData(MDB.MDBConnection _OracleConnection, decimal maquanly)
        {
            List<GiayCamKetDieuTri> list = new List<GiayCamKetDieuTri>();
            try
            {
                string sql = @"SELECT * FROM GiayCamKetDieuTri where MaQuanLy = :MaQuanLy";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, _OracleConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", maquanly));
                MDB.MDBDataReader DataReader = Command.ExecuteReader();
                while (DataReader.Read())
                {
                    GiayCamKetDieuTri data = new GiayCamKetDieuTri();
                    data.ID = Convert.ToInt64(DataReader.GetLong("ID").ToString());
                    data.MaQuanLy = maquanly;

                    data.MaBenhNhan = XemBenhAn._HanhChinhBenhNhan.MaBenhNhan;
                    data.TenBenhNhan = DataReader["TenBenhNhan"].ToString();
                    data.TenToiLa = DataReader["TenToiLa"].ToString();
                    data.NamSinh = DataReader["NamSinh"].ToString();
                    data.GioiTinh = DataReader["GioiTinh"].ToString();
                    data.Khoa = DataReader["Khoa"].ToString();
                    data.NguoiBenh = DataReader["NguoiBenh"].ToString();
                    data.NoiLam = DataReader["NoiLam"].ToString();

                    data.NgayLamGiay = Convert.ToDateTime(DataReader["NgayLamGiay"] == DBNull.Value ? DateTime.Now : DataReader["NgayLamGiay"]);
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
                sql = @"DELETE FROM GiayCamKetDieuTri WHERE ID =" + IDBienBan;
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
                GiayCamKetDieuTri P
            WHERE
                ID = " + IDBienBan;

            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
            MDB.MDBDataAdapter adt = new MDB.MDBDataAdapter(Command);
            var ds = new DataSet();

            adt.Fill(ds, "TB");

            ds.Tables[0].AddColumn("BENHVIEN", typeof(string));

            ds.Tables[0].Rows[0]["BENHVIEN"] = XemBenhAn._HanhChinhBenhNhan.BenhVien;

            return ds;
        }
        public static bool InsertOrUpdate(MDB.MDBConnection MyConnection, ref GiayCamKetDieuTri ketQua)
        {
            try
            {
                string sql = @"INSERT INTO GiayCamKetDieuTri
                (
                    MaQuanLy,
                    NoiLam,
                    NgayLamGiay,
                    TenToiLa,
                    NamSinh,
                    GioiTinh,
                    NguoiBenh,
                    Khoa,
                    TenBenhNhan,
                    NGUOITAO,
                    NGUOISUA,
                    NGAYTAO,
                    NGAYSUA)  VALUES
                 (
				    :MaQuanLy,
                    :NoiLam,
                    :NgayLamGiay,
                    :TenToiLa,
                    :NamSinh,
                    :GioiTinh,
                    :NguoiBenh,
                    :Khoa,
                    :TenBenhNhan,
                    :NGUOITAO,
                    :NGUOISUA,
                    :NGAYTAO,
                    :NGAYSUA
                 )  RETURNING ID INTO :ID";
                if (ketQua.ID != 0)
                {
                    sql = @"UPDATE GiayCamKetDieuTri SET 
                    MaQuanLy = :MaQuanLy,
                    NoiLam = :NoiLam,
                    NgayLamGiay = :NgayLamGiay,
                    TenToiLa = :TenToiLa,
                    NamSinh = :NamSinh,
                    GioiTinh = :GioiTinh,
                    NguoiBenh = :NguoiBenh,
                    Khoa = :Khoa,
                    TenBenhNhan = :TenBenhNhan,
                    NGUOISUA = :NGUOISUA,
                    NGAYSUA = :NGAYSUA 
                    WHERE ID = " + ketQua.ID;
                }
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);

                Command.Parameters.Add(new MDB.MDBParameter("NGUOISUA", ketQua.NguoiSua));
                Command.Parameters.Add(new MDB.MDBParameter("NGAYSUA", ketQua.NgaySua));

                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", ketQua.MaQuanLy));

                Command.Parameters.Add(new MDB.MDBParameter("NoiLam", ketQua.NoiLam));
                Command.Parameters.Add(new MDB.MDBParameter("NgayLamGiay", ketQua.NgayLamGiay));
                Command.Parameters.Add(new MDB.MDBParameter("TenToiLa", ketQua.TenToiLa));
                Command.Parameters.Add(new MDB.MDBParameter("NamSinh", ketQua.NamSinh));
                Command.Parameters.Add(new MDB.MDBParameter("GioiTinh", ketQua.GioiTinh));
                Command.Parameters.Add(new MDB.MDBParameter("NguoiBenh", ketQua.NguoiBenh));
                Command.Parameters.Add(new MDB.MDBParameter("Khoa", ketQua.Khoa));
                Command.Parameters.Add(new MDB.MDBParameter("TenBenhNhan", ketQua.TenBenhNhan));

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
