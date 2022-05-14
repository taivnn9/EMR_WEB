
using EMR.KyDienTu;
using PMS.Access;
using System;
using System.Collections.Generic;
using System.Data;

namespace EMR_MAIN.DATABASE.Other
{
    public class ToGiaiThichTTBL : ThongTinKy
    {
        public ToGiaiThichTTBL()
        {
            TableName = "ToGiaiThichTTBL";
            TablePrimaryKeyName = "ID";
            IDMauPhieu = (int)DanhMucPhieu.TGTTTBL;
            TenMauPhieu = DanhMucPhieu.TGTTTBL.Description();
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
        public string TinhTrangBenhLy { get; set; }
        public string LyDoPhauThuat { get; set; }
        public string PhuongPhapPhauThuat { get; set; }
        public string NguyCo { get; set; }
        public string CongPhauThuat { get; set; }
      
        public string VatTuYTe { get; set; }
        public string TongCong { get; set; }
        public string MaNguoiPhauThuat { get; set; }
        public string NguoiPhauThuat { get; set; }
        [MoTaDuLieu("Họ tên người thân")]
		public string NguoiThan { get; set; }

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
    public class ToGiaiThichTTBLFunc
    {
        public const string TableName = "ToGiaiThichTTBL";
        public const string TablePrimaryKeyName = "ID";

        public static List<ToGiaiThichTTBL> GetListData(MDB.MDBConnection _OracleConnection, decimal maquanly)
        {
            List<ToGiaiThichTTBL> list = new List<ToGiaiThichTTBL>();
            try
            {
                string sql = @"SELECT * FROM ToGiaiThichTTBL where MaQuanLy = :MaQuanLy";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, _OracleConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", maquanly));
                MDB.MDBDataReader DataReader = Command.ExecuteReader();
                while (DataReader.Read())
                {
                    ToGiaiThichTTBL data = new ToGiaiThichTTBL();
                    data.ID = Convert.ToInt64(DataReader.GetLong("ID").ToString());
                    data.MaQuanLy = maquanly;

                    data.MaBenhNhan = XemBenhAn._HanhChinhBenhNhan.MaBenhNhan;
                    data.TenBenhNhan = XemBenhAn._HanhChinhBenhNhan.TenBenhNhan;
                    data.NamSinh = XemBenhAn._HanhChinhBenhNhan.NgaySinh?.Year + "";

                    data.DiaChi = DataReader["DiaChi"].ToString();
                    data.TinhTrangBenhLy = DataReader["TinhTrangBenhLy"].ToString();
                    data.LyDoPhauThuat = DataReader["LyDoPhauThuat"].ToString();
                    data.PhuongPhapPhauThuat = DataReader["PhuongPhapPhauThuat"].ToString();
                    data.NguyCo = DataReader["NguyCo"].ToString();
                    data.CongPhauThuat = DataReader["CongPhauThuat"].ToString();
                    
                    data.VatTuYTe = DataReader["VatTuYTe"].ToString();
                    data.TongCong = DataReader["TongCong"].ToString();
                    data.MaNguoiPhauThuat = DataReader["MaNguoiPhauThuat"].ToString();
                    data.NguoiPhauThuat = DataReader["NguoiPhauThuat"].ToString();
                    data.NguoiThan = DataReader["NguoiThan"].ToString();

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
                sql = @"DELETE FROM ToGiaiThichTTBL WHERE ID =" + IDBienBan;
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
                ToGiaiThichTTBL P
            WHERE
                ID = " + IDBienBan;

            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
            MDB.MDBDataAdapter adt = new MDB.MDBDataAdapter(Command);
            var ds = new DataSet();

            adt.Fill(ds, "TB");

            ds.Tables[0].AddColumn("TenBenhNhan", typeof(string));
            ds.Tables[0].AddColumn("NamSinh", typeof(string));
            ds.Tables[0].Rows[0]["TenBenhNhan"] = XemBenhAn._HanhChinhBenhNhan.TenBenhNhan;
            ds.Tables[0].Rows[0]["NamSinh"] = XemBenhAn._HanhChinhBenhNhan.NgaySinh?.Year + "";

            ds.Tables[0].AddColumn("ThongTinNgayThang", typeof(string));
            ds.Tables[0].Rows[0]["ThongTinNgayThang"] = "Ngày " + DateTime.Now.Day + " tháng " + DateTime.Now.Month + " năm " + DateTime.Now.Year;

            return ds;
        }
        public static bool InsertOrUpdate(MDB.MDBConnection MyConnection, ref ToGiaiThichTTBL ketQua)
        {
            try
            {
                string sql = @"INSERT INTO ToGiaiThichTTBL
                (
                    MaQuanLy,
                    DiaChi,
                    TinhTrangBenhLy,
                    LyDoPhauThuat,
                    PhuongPhapPhauThuat,
                    NguyCo,
                    CongPhauThuat,
                    VatTuYTe,
                    TongCong,
                    MaNguoiPhauThuat,
                    NguoiPhauThuat,
                    NguoiThan,
                    NGUOITAO,
                    NGUOISUA,
                    NGAYTAO,
                    NGAYSUA)  VALUES
                 (
				    :MaQuanLy,
                    :DiaChi,
                    :TinhTrangBenhLy,
                    :LyDoPhauThuat,
                    :PhuongPhapPhauThuat,
                    :NguyCo,
                    :CongPhauThuat,
                    :VatTuYTe,
                    :TongCong,
                    :MaNguoiPhauThuat,
                    :NguoiPhauThuat,
                    :NguoiThan,
                    :NGUOITAO,
                    :NGUOISUA,
                    :NGAYTAO,
                    :NGAYSUA
                 )  RETURNING ID INTO :ID";
                if (ketQua.ID != 0)
                {
                    sql = @"UPDATE ToGiaiThichTTBL SET 
                    MaQuanLy = :MaQuanLy,
                    DiaChi= :DiaChi,
                    TinhTrangBenhLy = :TinhTrangBenhLy,
                    LyDoPhauThuat = :LyDoPhauThuat,
                    PhuongPhapPhauThuat = :PhuongPhapPhauThuat,
                    NguyCo = :NguyCo,
                    CongPhauThuat = :CongPhauThuat,
                    VatTuYTe = :VatTuYTe,
                    TongCong = :TongCong,
                    MaNguoiPhauThuat = :MaNguoiPhauThuat,
                    NguoiPhauThuat = :NguoiPhauThuat,
                    NguoiThan = :NguoiThan,
                    NGUOISUA = :NGUOISUA,
                    NGAYSUA = :NGAYSUA 
                    WHERE ID = " + ketQua.ID;
                }
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);

                Command.Parameters.Add(new MDB.MDBParameter("NGUOISUA", ketQua.NguoiSua));
                Command.Parameters.Add(new MDB.MDBParameter("NGAYSUA", ketQua.NgaySua));

                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", ketQua.MaQuanLy));

                Command.Parameters.Add(new MDB.MDBParameter("DiaChi", ketQua.DiaChi));
                Command.Parameters.Add(new MDB.MDBParameter("TinhTrangBenhLy", ketQua.TinhTrangBenhLy));
                Command.Parameters.Add(new MDB.MDBParameter("LyDoPhauThuat", ketQua.LyDoPhauThuat));
                Command.Parameters.Add(new MDB.MDBParameter("PhuongPhapPhauThuat", ketQua.PhuongPhapPhauThuat));
                Command.Parameters.Add(new MDB.MDBParameter("NguyCo", ketQua.NguyCo));
                Command.Parameters.Add(new MDB.MDBParameter("CongPhauThuat", ketQua.CongPhauThuat));
                Command.Parameters.Add(new MDB.MDBParameter("VatTuYTe", ketQua.VatTuYTe));
                Command.Parameters.Add(new MDB.MDBParameter("TongCong", ketQua.TongCong));
                Command.Parameters.Add(new MDB.MDBParameter("MaNguoiPhauThuat", ketQua.MaNguoiPhauThuat));
                Command.Parameters.Add(new MDB.MDBParameter("NguoiPhauThuat", ketQua.NguoiPhauThuat));
                Command.Parameters.Add(new MDB.MDBParameter("NguoiThan", ketQua.NguoiThan));

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
