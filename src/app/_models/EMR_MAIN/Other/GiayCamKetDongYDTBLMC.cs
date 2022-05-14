using EMR.KyDienTu;
using System;
using System.Collections.Generic;
using System.Data;
using PMS.Access;

namespace EMR_MAIN.DATABASE.Other
{
        public class GiayCamKetDongYDTBLMC : ThongTinKy
    {
        public GiayCamKetDongYDTBLMC()
        {
            TableName = "GiayCamKetDongYDTBLMC";
            TablePrimaryKeyName = "ID";
            IDMauPhieu = (int)DanhMucPhieu.GCKDYDTTBLMC;
            TenMauPhieu = DanhMucPhieu.GCKDYDTTBLMC.Description();
        }
        [MoTaDuLieu("Mã định danh")]
		public decimal ID { get; set; }
        [MoTaDuLieu("Mã quản lý: mã duy nhất trong 1 đợt khám chữa bệnh (kcb), không trùng giữa các đợt kcb khác nhau","",1)]
		public decimal MaQuanLy { get; set; }
        public string HoTen { get; set; }
        public string TinhTrangBenh { get; set; }
        public string PTDT { get; set; }
        public string NguyCo { get; set; }
        public string NoiLamGiay { get; set; }
        public DateTime? NgayLamGiay { get; set; }
        [MoTaDuLieu("Ngày tạo", null, 0, 0)]
		public DateTime NgayTao { get; set; }
        [MoTaDuLieu("Ngày sửa", null, 0, 0)]
		public DateTime NgaySua { get; set; }
        [MoTaDuLieu("Ngày ký")]
		public DateTime NgayKi { get; set; }
        [MoTaDuLieu("Người tạo", null, 0, 0)]
		public string NguoiTao { get; set; }
        [MoTaDuLieu("Người sửa", null, 0, 0)]
		public string NguoiSua { get; set; }
        [MoTaDuLieu("Chọn", null, 0, 0)]
		public bool Chon { get; set; }
        //public string MaSoKyTen { get; set; }
        [MoTaDuLieu("Đã ký", null, 0, 0)]
		public bool DaKy { get; set; }
    }
    public class GiayCamKetDongYDTBLMCFunc
    {

        public const string TableName = "GiayCamKetDongYDTBLMC";
        public const string TablePrimaryKeyName = "ID";

        public static bool Delete(MDB.MDBConnection MyConnection, decimal id)
        {
            try
            {
                string sql = "DELETE FROM GiayCamKetDongYDTBLMC WHERE ID = :ID";
                MDB.MDBCommand command = new MDB.MDBCommand(sql, MyConnection);
                command.Parameters.Add(new MDB.MDBParameter("ID", id));
                command.BindByName = true;
                int n = command.ExecuteNonQuery();
                return n > 0;
            }
            catch (Exception ex)
            {
                XuLyLoi.Handle(ex);
            }
            return false;
        }

        public static List<GiayCamKetDongYDTBLMC> GetListData(MDB.MDBConnection _OracleConnection, decimal maquanly)
        {
            List<GiayCamKetDongYDTBLMC> list = new List<GiayCamKetDongYDTBLMC>();
            try
            {
                string sql = @"SELECT * FROM GiayCamKetDongYDTBLMC where MaQuanLy = :MaQuanLy";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, _OracleConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", maquanly));
                MDB.MDBDataReader DataReader = Command.ExecuteReader();
                while (DataReader.Read())
                {
                    GiayCamKetDongYDTBLMC data = new GiayCamKetDongYDTBLMC();
                    data.ID = Convert.ToInt64(DataReader.GetLong("ID").ToString());
                    data.MaQuanLy = maquanly;

                    data.HoTen = DataReader["HoTen"].ToString();
                    data.TinhTrangBenh = DataReader["TinhTrangBenh"].ToString();
                    data.PTDT = DataReader["PTDT"].ToString();
                    data.NguyCo = DataReader["NguyCo"].ToString();
                    data.NoiLamGiay = DataReader["NoiLamGiay"].ToString();
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
        public static DataSet GetDataSet(MDB.MDBConnection MyConnection, string IDBienBan)
        {
            string sql = @"SELECT
                P.* 
            FROM
                GiayCamKetDongYDTBLMC P
            WHERE
                ID = " + IDBienBan;

            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
            MDB.MDBDataAdapter adt = new MDB.MDBDataAdapter(Command);
            var ds = new DataSet();

            adt.Fill(ds, "TB");

            ds.Tables[0].AddColumn("BenhVien", typeof(string));
            ds.Tables[0].AddColumn("SoYTe", typeof(string));

            ds.Tables[0].Rows[0]["BenhVien"] = XemBenhAn._HanhChinhBenhNhan.BenhVien;
            ds.Tables[0].Rows[0]["SoYTe"] = XemBenhAn._HanhChinhBenhNhan.SoYTe;

            return ds;
        }
        public static bool InsertOrUpdate(MDB.MDBConnection MyConnection, GiayCamKetDongYDTBLMC ketQua)
        {
            try
            {
                string sql = @"INSERT INTO GiayCamKetDongYDTBLMC
                (
                    MaQuanLy,
                    HoTen,
                    TinhTrangBenh,
                    PTDT,
                    NguyCo,
                    NoiLamGiay,
                    NgayLamGiay,
                    NGUOITAO,
                    NGUOISUA,
                    NGAYTAO,
                    NGAYSUA)  VALUES
                 (
				    :MaQuanLy,
                    :HoTen,
                    :TinhTrangBenh,
                    :PTDT,
                    :NguyCo,
                    :NoiLamGiay,
                    :NgayLamGiay,
                    :NGUOITAO,
                    :NGUOISUA,
                    :NGAYTAO,
                    :NGAYSUA
                 )  RETURNING ID INTO :ID";
                if (ketQua.ID != 0)
                {
                    sql = @"UPDATE GiayCamKetDongYDTBLMC SET 
                    MaQuanLy = :MaQuanLy,
                    HoTen = :HoTen,
                    TinhTrangBenh = :TinhTrangBenh,
                    PTDT = :PTDT,
                    NguyCo = :NguyCo,
                    NoiLamGiay = :NoiLamGiay,
                    NgayLamGiay = :NgayLamGiay,
                    NGUOISUA = :NGUOISUA,
                    NGAYSUA = :NGAYSUA 
                    WHERE ID = " + ketQua.ID;
                }
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);

                Command.Parameters.Add(new MDB.MDBParameter("NGUOISUA", ketQua.NguoiSua));
                Command.Parameters.Add(new MDB.MDBParameter("NGAYSUA", ketQua.NgaySua));

                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", ketQua.MaQuanLy));
                Command.Parameters.Add(new MDB.MDBParameter("HoTen", ketQua.HoTen));
                Command.Parameters.Add(new MDB.MDBParameter("TinhTrangBenh", ketQua.TinhTrangBenh));
                Command.Parameters.Add(new MDB.MDBParameter("PTDT", ketQua.PTDT));
                Command.Parameters.Add(new MDB.MDBParameter("NguyCo", ketQua.NguyCo));
                Command.Parameters.Add(new MDB.MDBParameter("NoiLamGiay", ketQua.NoiLamGiay));
                Command.Parameters.Add(new MDB.MDBParameter("NgayLamGiay", ketQua.NgayLamGiay));

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
