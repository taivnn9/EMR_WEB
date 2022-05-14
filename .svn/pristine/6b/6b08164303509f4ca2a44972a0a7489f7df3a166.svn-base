using EMR.KyDienTu;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PMS.Access;

namespace EMR_MAIN.DATABASE.Other
{
    public class GiayBaoMo : ThongTinKy
    {
        public GiayBaoMo()
        {
            TableName = "GiayBaoMo";
            TablePrimaryKeyName = "ID";
            IDMauPhieu = (int)DanhMucPhieu.GBM;
            TenMauPhieu = DanhMucPhieu.GBM.Description();
        }
        [MoTaDuLieu("Mã định danh")]
		public long ID { get; set; }
        [MoTaDuLieu("Mã quản lý: mã duy nhất trong 1 đợt khám chữa bệnh (kcb), không trùng giữa các đợt kcb khác nhau","",1)]
		public decimal MaQuanLy { get; set; }
        [MoTaDuLieu("Mã bệnh nhân")]
		public string MaBenhNhan { get; set; }
        [MoTaDuLieu("Khoa")]
		public string Khoa { get; set; }
        [MoTaDuLieu("Mã khoa")]
		public string MaKhoa { get; set; }
        [MoTaDuLieu("Chẩn đoán bệnh")]
		public string ChanDoan { get; set; }
        public string PhuongPhapMo { get; set; }
        public string NguoiBaoMo { get; set; }
        public string MaNguoiBaoMo { get; set; }
        [MoTaDuLieu("Ngày tạo", null, 0, 0)]
		public DateTime NgayTao { get; set; }
        [MoTaDuLieu("Người tạo", null, 0, 0)]
		public string NguoiTao { get; set; }
        [MoTaDuLieu("Ngày sửa", null, 0, 0)]
		public DateTime NgaySua { get; set; }
        [MoTaDuLieu("Người sửa", null, 0, 0)]
		public string NguoiSua { get; set; }
        [MoTaDuLieu("Đã ký", null, 0, 0)]
		public bool DaKy { get; set; }
        [MoTaDuLieu("Chọn", null, 0, 0)]
		public bool Chon { get; set; }
    }
    public class GiayBaoMoFunc
    {
        public const string TableName = "GiayBaoMo";
        public const string TablePrimaryKeyName = "ID";
        public const string MaPhieu = "GBM";
        public static List<GiayBaoMo> GetListData(MDB.MDBConnection _OracleConnection, decimal maquanly)
        {
            List<GiayBaoMo> list = new List<GiayBaoMo>();
            try
            {
                string sql = @"SELECT * FROM GiayBaoMo where MaQuanLy = :MaQuanLy";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, _OracleConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", maquanly));
                MDB.MDBDataReader DataReader = Command.ExecuteReader();
                while (DataReader.Read())
                {
                    GiayBaoMo data = new GiayBaoMo();
                    data.ID = Convert.ToInt64(DataReader.GetLong("ID").ToString());
                    data.MaQuanLy = maquanly;
                    data.MaBenhNhan = DataReader["MaBenhNhan"].ToString();

                    data.Khoa = DataReader["Khoa"].ToString();
                    data.MaKhoa = DataReader["MaKhoa"].ToString();
                    data.ChanDoan = DataReader["ChanDoan"].ToString();
                    data.PhuongPhapMo = DataReader["PhuongPhapMo"].ToString();
                    data.NguoiBaoMo = DataReader["NguoiBaoMo"].ToString();
                    data.MaNguoiBaoMo = DataReader["MaNguoiBaoMo"].ToString();

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
        public static bool InsertOrUpdate(MDB.MDBConnection MyConnection, ref GiayBaoMo bangDieuTri)
        {
            try
            {
                string sql = @"INSERT INTO GiayBaoMo
                (
                    MAQUANLY,
                    MaBenhNhan,
                    Khoa,
                    MaKhoa,
                    ChanDoan,
                    PhuongPhapMo,
                    NguoiBaoMo,
                    MaNguoiBaoMo,
                    NGUOITAO,
                    NGUOISUA,
                    NGAYTAO,
                    NGAYSUA)  VALUES
                 (
				    :MAQUANLY,
                    :MaBenhNhan,
                    :Khoa,
                    :MaKhoa,
                    :ChanDoan,
                    :PhuongPhapMo,
                    :NguoiBaoMo,
                    :MaNguoiBaoMo,
                    :NGUOITAO,
                    :NGUOISUA,
                    :NGAYTAO,
                    :NGAYSUA
                 )  RETURNING ID INTO :ID";
                if (bangDieuTri.ID != 0)
                {
                    sql = @"UPDATE GiayBaoMo SET 
                    MAQUANLY = :MAQUANLY,
                    MaBenhNhan = :MaBenhNhan,
                    Khoa = :Khoa,
                    MaKhoa = :MaKhoa,
                    ChanDoan = :ChanDoan,
                    PhuongPhapMo = :PhuongPhapMo,
                    NguoiBaoMo = :NguoiBaoMo,
                    MaNguoiBaoMo = :MaNguoiBaoMo,
                    NGUOISUA = :NGUOISUA,
                    NGAYSUA = :NGAYSUA
                    WHERE ID = " + bangDieuTri.ID;
                }
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MAQUANLY", bangDieuTri.MaQuanLy));
                Command.Parameters.Add(new MDB.MDBParameter("MaBenhNhan", bangDieuTri.MaBenhNhan));
                Command.Parameters.Add(new MDB.MDBParameter("Khoa", bangDieuTri.Khoa));
                Command.Parameters.Add(new MDB.MDBParameter("MaKhoa", bangDieuTri.MaKhoa));
                Command.Parameters.Add(new MDB.MDBParameter("ChanDoan", bangDieuTri.ChanDoan));
                Command.Parameters.Add(new MDB.MDBParameter("PhuongPhapMo", bangDieuTri.PhuongPhapMo));
                Command.Parameters.Add(new MDB.MDBParameter("NguoiBaoMo", bangDieuTri.NguoiBaoMo));
                Command.Parameters.Add(new MDB.MDBParameter("MaNguoiBaoMo", bangDieuTri.MaNguoiBaoMo));
                Command.Parameters.Add(new MDB.MDBParameter("NGUOISUA", bangDieuTri.NguoiSua));
                Command.Parameters.Add(new MDB.MDBParameter("NGAYSUA", bangDieuTri.NgaySua));
                if (bangDieuTri.ID == 0)
                {
                    Command.Parameters.Add(new MDB.MDBParameter("ID", bangDieuTri.ID));
                    Command.Parameters.Add(new MDB.MDBParameter("NGUOITAO", bangDieuTri.NguoiTao));
                    Command.Parameters.Add(new MDB.MDBParameter("NGAYTAO", bangDieuTri.NgayTao));
                }
                Command.BindByName = true;
                int n = Command.ExecuteNonQuery();
                if (bangDieuTri.ID == 0)
                {
                    long nextval = Convert.ToInt64((Command.Parameters["ID"] as MDB.MDBParameter).Value);
                    bangDieuTri.ID = nextval;
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
                string sql = "DELETE FROM GiayBaoMo WHERE ID = :ID";
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
                T.MABENHAN,
	            H.TENBENHNHAN,
                H.SOYTE,
                H.BENHVIEN,
                (H.SONHA || ',' || H.THONPHO || ',' ||  H.XAPHUONG || ',' ||  H.HUYENQUAN || ',' ||  H.TINHTHANHPHO) AS DIACHI 
            FROM
                GiayBaoMo B
                LEFT JOIN THONGTINDIEUTRI T ON B.MAQUANLY = T.MAQUANLY
                LEFT JOIN HANHCHINHBENHNHAN H ON T.MABENHNHAN = H.MABENHNHAN
            WHERE
                ID = " + id;

            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);

            MDB.MDBDataAdapter adt = new MDB.MDBDataAdapter(Command);
            var ds = new DataSet();
            adt.Fill(ds, "BM");

            return ds;
        }
    }
}
