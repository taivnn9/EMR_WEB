
using EMR.KyDienTu;
using System;
using System.Collections.Generic;
using System.Data;
using PMS.Access;

namespace EMR_MAIN.DATABASE.Other
{
    public class BanCamKetKhoaPTTTE : ThongTinKy
    {
        public BanCamKetKhoaPTTTE()
        {
            TableName = "BanCamKetKhoaPTTTE";
            TablePrimaryKeyName = "ID";
            IDMauPhieu = (int)DanhMucPhieu.BCKKPTTTE;
            TenMauPhieu = DanhMucPhieu.BCKKPTTTE.Description();
        }
        [MoTaDuLieu("Mã định danh")]
		public long ID { get; set; }
        [MoTaDuLieu("Mã quản lý: mã duy nhất trong 1 đợt khám chữa bệnh (kcb), không trùng giữa các đợt kcb khác nhau","",1)]
        public decimal MaQuanLy { get; set; }
        [MoTaDuLieu("Mã bệnh nhân")]
		public string MaBenhNhan { get; set; }
        [MoTaDuLieu("Họ và tên người làm cam kết")]
        public string HoTen { get; set; }
        [MoTaDuLieu("Tuổi bệnh nhân")]
		public string Tuoi { get; set; }
        public string SDT { get; set; }
        [MoTaDuLieu("Địa chỉ nhà người cam kết")]
		public string DiaChi { get; set; }
        [MoTaDuLieu("Số chứng minh nhân dân")]
		public string CMND { get; set; }
        [MoTaDuLieu(" Ngày cấp chứng minh nhân dân")]
        public DateTime? NgayCap { get; set; }
      
        [MoTaDuLieu("Nơi cấp chứng minh nhân dân")]
		public string NoiCap { get; set; }
        [MoTaDuLieu("Họ và tên người bệnh")]
        public string TenNguoiBenh { get; set; }
        [MoTaDuLieu(" Ngày làm phiếu")]
        public DateTime? NgayLamPhieu { get; set; }

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

    public class BanCamKetKhoaPTTTEFunc
    {
        public const string TableName = "BanCamKetKhoaPTTTE";
        public const string TablePrimaryKeyName = "ID";

        public static List<BanCamKetKhoaPTTTE> GetListData(MDB.MDBConnection _OracleConnection, decimal maquanly)
        {
            List<BanCamKetKhoaPTTTE> list = new List<BanCamKetKhoaPTTTE>();
            try
            {
                string sql = @"SELECT * FROM BanCamKetKhoaPTTTE where MaQuanLy = :MaQuanLy";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, _OracleConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", maquanly));
                MDB.MDBDataReader DataReader = Command.ExecuteReader();
                while (DataReader.Read())
                {
                    BanCamKetKhoaPTTTE data = new BanCamKetKhoaPTTTE();
                    data.ID = Convert.ToInt64(DataReader.GetLong("ID").ToString());
                    data.MaQuanLy = maquanly;

                    data.MaBenhNhan = XemBenhAn._HanhChinhBenhNhan.MaBenhNhan;
                    data.HoTen = DataReader["HoTen"].ToString();
                    data.Tuoi = DataReader["Tuoi"].ToString();
                    data.SDT = DataReader["SDT"].ToString();
                    data.DiaChi = DataReader["DiaChi"].ToString();
                    data.CMND = DataReader["CMND"].ToString();
                    
                    data.NgayCap = Convert.ToDateTime(DataReader["NgayCap"] == DBNull.Value ? DateTime.Now : DataReader["NgayCap"]);
                    data.NoiCap = DataReader["NoiCap"].ToString();
                    data.TenNguoiBenh = DataReader["TenNguoiBenh"].ToString();

                    data.NgayLamPhieu = Convert.ToDateTime(DataReader["NgayLamPhieu"] == DBNull.Value ? DateTime.Now : DataReader["NgayLamPhieu"]);

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
                sql = @"DELETE FROM BanCamKetKhoaPTTTE WHERE ID =" + IDBienBan;
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
                D.*,
	            T.MABENHNHAN,
	            H.SOYTE,
	            H.BENHVIEN
            FROM
                BanCamKetKhoaPTTTE D
                LEFT JOIN THONGTINDIEUTRI T ON D.MAQUANLY = T.MAQUANLY
                LEFT JOIN HANHCHINHBENHNHAN H ON T.MABENHNHAN = H.MABENHNHAN
            WHERE
                ID = " + IDBienBan;

            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
            MDB.MDBDataAdapter adt = new MDB.MDBDataAdapter(Command);
            var ds = new DataSet();

            adt.Fill(ds, "TB");

            return ds;
        }
        public static bool InsertOrUpdate(MDB.MDBConnection MyConnection, ref BanCamKetKhoaPTTTE ketQua)
        {
            try
            {
                string sql = @"INSERT INTO BanCamKetKhoaPTTTE
                (
                    MaQuanLy,
                    HoTen,
                    Tuoi,
                    SDT,
                    DiaChi,
                    CMND,
                    NgayCap,
                    NoiCap,
                    TenNguoiBenh,
                    NgayLamPhieu,
                    NGUOITAO,
                    NGUOISUA,
                    NGAYTAO,
                    NGAYSUA)  VALUES
                 (
				    :MaQuanLy,
                    :HoTen,
                    :Tuoi,
                    :SDT,
                    :DiaChi,
                    :CMND,
                    :NgayCap,
                    :NoiCap,
                    :TenNguoiBenh,
                    :NgayLamPhieu,
                    :NGUOITAO,
                    :NGUOISUA,
                    :NGAYTAO,
                    :NGAYSUA
                 )  RETURNING ID INTO :ID";
                if (ketQua.ID != 0)
                {
                    sql = @"UPDATE BanCamKetKhoaPTTTE SET 
                    MaQuanLy = :MaQuanLy,
                    HoTen = :HoTen,
                    Tuoi = :Tuoi,
                    SDT = :SDT,
                    DiaChi = :DiaChi,
                    CMND = :CMND,
                    NgayCap = :NgayCap,
                    NoiCap = :NoiCap,
                    TenNguoiBenh = :TenNguoiBenh,
                    NgayLamPhieu = :NgayLamPhieu,
                    NGUOISUA = :NGUOISUA,
                    NGAYSUA = :NGAYSUA 
                    WHERE ID = " + ketQua.ID;
                }
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);

                Command.Parameters.Add(new MDB.MDBParameter("NGUOISUA", ketQua.NguoiSua));
                Command.Parameters.Add(new MDB.MDBParameter("NGAYSUA", ketQua.NgaySua));

                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", ketQua.MaQuanLy));

                Command.Parameters.Add(new MDB.MDBParameter("HoTen", ketQua.HoTen));
                Command.Parameters.Add(new MDB.MDBParameter("Tuoi", ketQua.Tuoi));
                Command.Parameters.Add(new MDB.MDBParameter("SDT", ketQua.SDT));
                Command.Parameters.Add(new MDB.MDBParameter("DiaChi", ketQua.DiaChi));
                Command.Parameters.Add(new MDB.MDBParameter("CMND", ketQua.CMND));
                Command.Parameters.Add(new MDB.MDBParameter("NgayCap", ketQua.NgayCap));
                Command.Parameters.Add(new MDB.MDBParameter("NoiCap", ketQua.NoiCap));
                Command.Parameters.Add(new MDB.MDBParameter("TenNguoiBenh", ketQua.TenNguoiBenh));
                Command.Parameters.Add(new MDB.MDBParameter("NgayLamPhieu", ketQua.NgayLamPhieu));

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
