using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EMR.KyDienTu;
using PMS.Access;
using System;
using System.Collections.Generic;
using System.Data;

namespace EMR_MAIN.DATABASE.Other
{
    public class GiayMoiHoiChan : ThongTinKy
    {
        public GiayMoiHoiChan()
        {
            TableName = "GiayMoiHoiChan";
            TablePrimaryKeyName = "ID";
            IDMauPhieu = (int)DanhMucPhieu.GMHC;
            TenMauPhieu = DanhMucPhieu.GMHC.Description();
        }
        [MoTaDuLieu("Mã định danh")]
		public long ID { get; set; }
        [MoTaDuLieu("Mã quản lý: mã duy nhất trong 1 đợt khám chữa bệnh (kcb), không trùng giữa các đợt kcb khác nhau","",1)]
		public decimal MaQuanLy { get; set; }
        [MoTaDuLieu("Bệnh viện")]
		public string BenhVien { 
            get
            {
                return XemBenhAn._HanhChinhBenhNhan.BenhVien;
            } 
        }
        [MoTaDuLieu("Mã bệnh nhân")]
		public string MaBenhNhan { get; set; }
        public string KinhGui { get; set; }
        public string KinhMoi { get; set; }
        public string HoTenBenhNhan { get; set; }
        [MoTaDuLieu("Tuổi bệnh nhân")]
		public string Tuoi { get; set; }
        [MoTaDuLieu("Giường")]
		public string Giuong { get; set; }
        [MoTaDuLieu("Khoa")]
		public string Khoa { get; set; }
        [MoTaDuLieu("Mã khoa")]
		public string MaKhoa { get; set; }
        [MoTaDuLieu("Chẩn đoán bệnh")]
		public string ChanDoan { get; set; }
        [MoTaDuLieu("Bác sỹ điều trị")]
		public string BacSyDieuTri { get; set; }
        [MoTaDuLieu("Mã bác sỹ điều trị")]
		public string MaBacSyDieuTri { get; set; }
        public string GiamDoc { get; set; }
        public string MaGiamDoc { get; set; }
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
    public class GiayMoiHoiChanFunc
    {
        public const string TableName = "GiayMoiHoiChan";
        public const string TablePrimaryKeyName = "ID";
        public static List<GiayMoiHoiChan> GetListData(MDB.MDBConnection _OracleConnection, decimal maquanly)
        {
            List<GiayMoiHoiChan> list = new List<GiayMoiHoiChan>();
            try
            {
                string sql = @"SELECT * FROM GiayMoiHoiChan where MaQuanLy = :MaQuanLy";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, _OracleConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", maquanly));
                MDB.MDBDataReader DataReader = Command.ExecuteReader();
                while (DataReader.Read())
                {
                    GiayMoiHoiChan data = new GiayMoiHoiChan();
                    data.ID = Convert.ToInt64(DataReader.GetLong("ID").ToString());
                    data.MaQuanLy = maquanly;
                    data.MaBenhNhan = DataReader["MaBenhNhan"].ToString();
                    data.KinhGui = DataReader["KinhGui"].ToString();
                    data.KinhMoi = DataReader["KinhMoi"].ToString();
                    data.HoTenBenhNhan = XemBenhAn._HanhChinhBenhNhan.TenBenhNhan;
                    data.Tuoi = XemBenhAn._HanhChinhBenhNhan.Tuoi;
                    data.Giuong = DataReader["Giuong"].ToString();
                    data.Khoa = DataReader["Khoa"].ToString();
                    data.MaKhoa = DataReader["MaKhoa"].ToString();
                    data.ChanDoan = DataReader["ChanDoan"].ToString();
                    data.BacSyDieuTri = DataReader["BacSyDieuTri"].ToString();
                    data.MaBacSyDieuTri = DataReader["MaBacSyDieuTri"].ToString();
                    data.GiamDoc = DataReader["GiamDoc"].ToString();
                    data.MaGiamDoc = DataReader["MaGiamDoc"].ToString();

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
        public static bool InsertOrUpdate(MDB.MDBConnection MyConnection, ref GiayMoiHoiChan ketQua)
        {
            try
            {
                string sql = @"INSERT INTO GiayMoiHoiChan
                (
                    MAQUANLY,
                    MaBenhNhan,
                    KinhGui,
                    KinhMoi,
                    Giuong,
                    Khoa,
                    MaKhoa,
                    ChanDoan,
                    BacSyDieuTri,
                    MaBacSyDieuTri,
                    GiamDoc,
                    MaGiamDoc,
                    NGUOITAO,
                    NGUOISUA,
                    NGAYTAO,
                    NGAYSUA)  VALUES
                 (
				    :MAQUANLY,
                    :MaBenhNhan,
                    :KinhGui,
                    :KinhMoi,
                    :Giuong,
                    :Khoa,
                    :MaKhoa,
                    :ChanDoan,
                    :BacSyDieuTri,
                    :MaBacSyDieuTri,
                    :GiamDoc,
                    :MaGiamDoc,
                    :NGUOITAO,
                    :NGUOISUA,
                    :NGAYTAO,
                    :NGAYSUA
                 )  RETURNING ID INTO :ID";
                if (ketQua.ID != 0)
                {
                    sql = @"UPDATE GiayMoiHoiChan SET 
                    MAQUANLY = :MAQUANLY,
                    MaBenhNhan = :MaBenhNhan,
                    KinhGui = :KinhGui,
                    KinhMoi = :KinhMoi,
                    Giuong = :Giuong,
                    Khoa = :Khoa,
                    MaKhoa = :MaKhoa,
                    ChanDoan = :ChanDoan,
                    BacSyDieuTri = :BacSyDieuTri,
                    MaBacSyDieuTri = :MaBacSyDieuTri,
                    GiamDoc = :GiamDoc,
                    MaGiamDoc = :MaGiamDoc,
                    NGUOISUA = :NGUOISUA,
                    NGAYSUA = :NGAYSUA
                    WHERE ID = " + ketQua.ID;
                }
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MAQUANLY", ketQua.MaQuanLy));
                Command.Parameters.Add(new MDB.MDBParameter("MaBenhNhan", ketQua.MaBenhNhan));
                Command.Parameters.Add(new MDB.MDBParameter("KinhGui", ketQua.KinhGui));
                Command.Parameters.Add(new MDB.MDBParameter("KinhMoi", ketQua.KinhMoi));
                Command.Parameters.Add(new MDB.MDBParameter("Giuong", ketQua.Giuong));
                Command.Parameters.Add(new MDB.MDBParameter("Khoa", ketQua.Khoa));
                Command.Parameters.Add(new MDB.MDBParameter("MaKhoa", ketQua.MaKhoa));
                Command.Parameters.Add(new MDB.MDBParameter("ChanDoan", ketQua.ChanDoan));
                Command.Parameters.Add(new MDB.MDBParameter("BacSyDieuTri", ketQua.BacSyDieuTri));
                Command.Parameters.Add(new MDB.MDBParameter("MaBacSyDieuTri", ketQua.MaBacSyDieuTri));
                Command.Parameters.Add(new MDB.MDBParameter("GiamDoc", ketQua.GiamDoc));
                Command.Parameters.Add(new MDB.MDBParameter("MaGiamDoc", ketQua.MaGiamDoc));

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
                string sql = "DELETE FROM GiayMoiHoiChan WHERE ID = :ID";
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
                GiayMoiHoiChan P
            WHERE
                ID = " + id;

            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
            MDB.MDBDataAdapter adt = new MDB.MDBDataAdapter(Command);
            var ds = new DataSet();

            adt.Fill(ds, "KQ");

            ds.Tables[0].AddColumn("TenBenhNhan", typeof(string));
            ds.Tables[0].AddColumn("Tuoi", typeof(string));
            ds.Tables[0].AddColumn("SOYTE", typeof(string));
            ds.Tables[0].AddColumn("BENHVIEN", typeof(string));

            ds.Tables[0].Rows[0]["TenBenhNhan"] = XemBenhAn._HanhChinhBenhNhan.TenBenhNhan;
            ds.Tables[0].Rows[0]["Tuoi"] = XemBenhAn._HanhChinhBenhNhan.Tuoi;
            ds.Tables[0].Rows[0]["SOYTE"] = XemBenhAn._HanhChinhBenhNhan.SoYTe;
            ds.Tables[0].Rows[0]["BENHVIEN"] = XemBenhAn._HanhChinhBenhNhan.BenhVien;

            return ds;
        }
    }
}
