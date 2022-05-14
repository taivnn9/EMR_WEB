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
    public class GXNDTCovid : ThongTinKy
    {
        public GXNDTCovid()
        {
            TableName = "GXNDTCovid";
            TablePrimaryKeyName = "ID";
            IDMauPhieu = (int)DanhMucPhieu.GXNDTCovid;
            TenMauPhieu = DanhMucPhieu.GXNDTCovid.Description();
        }
        [MoTaDuLieu("Mã định danh")]
		public decimal ID { get; set; }
        [MoTaDuLieu("Mã quản lý: mã duy nhất trong 1 đợt khám chữa bệnh (kcb), không trùng giữa các đợt kcb khác nhau","",1)]
		public decimal MaQuanLy { get; set; }
        [MoTaDuLieu("Mã bệnh nhân")]
		public string MaBenhNhan { get; set; }
        public string HoTenBenhNhan { get; set; }
        [MoTaDuLieu("Số chứng minh nhân dân")]
		public string CMND { get; set; }
        public string SDT { get; set; }
        public string KhaiBaoTiem { get; set; }
        public DateTime? NgayTiem1 { get; set; }
        [MoTaDuLieu("Năm sinh")]
		public string NamSinh { get; set; }
        [MoTaDuLieu("Địa chỉ nhà bệnh nhân")]
		public string DiaChi { get; set; }
        public DateTime? NgayTiem2 { get; set; }
        public string MoTaVaccine1 { get; set; }
        public string MoTaVaccine2 { get; set; }
        public string NguoiDaiDien1 { get; set; }
        public string MaNguoiDaiDien1 { get; set; }
        public string NguoiDaiDien2 { get; set; }
        public string MaNguoiDaiDien2 { get; set; }
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
    public class GXNDTCovidFunc
    {
        public const string TableName = "GXNDTCovid";
        public const string TablePrimaryKeyName = "ID";
        public static List<GXNDTCovid> GetListData(MDB.MDBConnection _OracleConnection, decimal maquanly)
        {
            List<GXNDTCovid> list = new List<GXNDTCovid>();
            try
            {
                string sql = @"SELECT * FROM GXNDTCovid where MaQuanLy = :MaQuanLy";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, _OracleConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", maquanly));
                MDB.MDBDataReader DataReader = Command.ExecuteReader();
                while (DataReader.Read())
                {
                    GXNDTCovid obj = new GXNDTCovid();
                    obj.ID = Common.ConDB_Decimal(DataReader["ID"]);
                    obj.MaQuanLy = Common.ConDB_Decimal(DataReader["MaQuanLy"]);
                    obj.MaBenhNhan = Common.ConDBNull(DataReader["MaBenhNhan"]);
                    obj.HoTenBenhNhan = Common.ConDBNull(DataReader["HoTenBenhNhan"]);
                    obj.CMND = Common.ConDBNull(DataReader["CMND"]);
                    obj.KhaiBaoTiem = Common.ConDBNull(DataReader["KhaiBaoTiem"]);
                    obj.SDT = Common.ConDBNull(DataReader["SDT"]);
                    obj.NgayTiem1 = Common.ConDB_DateTimeNull(DataReader["NgayTiem1"]);
                    obj.NamSinh = Common.ConDBNull(DataReader["NamSinh"]);
                    obj.DiaChi = Common.ConDBNull(DataReader["DiaChi"]);
                    obj.NgayTiem2 = Common.ConDB_DateTimeNull(DataReader["NgayTiem2"]);
                    obj.MoTaVaccine1 = Common.ConDBNull(DataReader["MoTaVaccine1"]);
                    obj.MoTaVaccine2 = Common.ConDBNull(DataReader["MoTaVaccine2"]);
                    obj.NguoiDaiDien1 = Common.ConDBNull(DataReader["NguoiDaiDien1"]);
                    obj.MaNguoiDaiDien1 = Common.ConDBNull(DataReader["MaNguoiDaiDien1"]);
                    obj.NguoiDaiDien2 = Common.ConDBNull(DataReader["NguoiDaiDien2"]);
                    obj.MaNguoiDaiDien2 = Common.ConDBNull(DataReader["MaNguoiDaiDien2"]);
                    obj.NgayTao = Common.ConDB_DateTime(DataReader["NgayTao"]);
                    obj.NguoiTao = Common.ConDBNull(DataReader["NguoiTao"]);
                    obj.NgaySua = Common.ConDB_DateTime(DataReader["NgaySua"]);
                    obj.NguoiSua = Common.ConDBNull(DataReader["NguoiSua"]);
                    obj.MaSoKy = DataReader["masokyten"].ToString();
                    obj.DaKy = !string.IsNullOrEmpty(obj.MaSoKy) ? true : false;
                    list.Add(obj);
                }
            }
            catch (Exception ex) { XuLyLoi.Handle(ex); }
            return list;
        }
        public static bool InsertOrUpdate(MDB.MDBConnection MyConnection, ref GXNDTCovid obj)
        {
            try
            {
                string sql = @"INSERT INTO GXNDTCovid
                (
                    MaQuanLy,
                    MaBenhNhan,
                    HoTenBenhNhan,
                    CMND,
                    KhaiBaoTiem,SDT,
                    NgayTiem1,
                    NamSinh,
                    DiaChi,
                    NgayTiem2,
                    MoTaVaccine1,
                    MoTaVaccine2,
                    NguoiDaiDien1,
                    MaNguoiDaiDien1,
                    NguoiDaiDien2,
                    MaNguoiDaiDien2,
                    NgayTao,
                    NguoiTao,
                    NgaySua,
                    NguoiSua)  VALUES
                    (
                    :MaQuanLy,
                    :MaBenhNhan,
                    :HoTenBenhNhan,
                    :CMND,
                    :KhaiBaoTiem, :SDT,
                    :NgayTiem1,
                    :NamSinh,
                    :DiaChi,
                    :NgayTiem2,
                    :MoTaVaccine1,
                    :MoTaVaccine2,
                    :NguoiDaiDien1,
                    :MaNguoiDaiDien1,
                    :NguoiDaiDien2,
                    :MaNguoiDaiDien2,
                    :NgayTao,
                    :NguoiTao,
                    :NgaySua,
                    :NguoiSua
                 )  RETURNING ID INTO :ID";
                if (obj.ID != 0)
                {
                    sql = @"UPDATE GXNDTCovid SET 
                    MaQuanLy=:MaQuanLy,
                    MaBenhNhan=:MaBenhNhan,
                    HoTenBenhNhan=:HoTenBenhNhan,
                    CMND=:CMND,
                    KhaiBaoTiem=:KhaiBaoTiem,SDT=:SDT,
                    NgayTiem1=:NgayTiem1,
                    NamSinh=:NamSinh,
                    DiaChi=:DiaChi,
                    NgayTiem2=:NgayTiem2,
                    MoTaVaccine1=:MoTaVaccine1,
                    MoTaVaccine2=:MoTaVaccine2,
                    NguoiDaiDien1=:NguoiDaiDien1,
                    MaNguoiDaiDien1=:MaNguoiDaiDien1,
                    NguoiDaiDien2=:NguoiDaiDien2,
                    MaNguoiDaiDien2=:MaNguoiDaiDien2,
                    NgaySua=:NgaySua,
                    NguoiSua=:NguoiSua
                    WHERE ID = " + obj.ID;
                }
                MDB.MDBCommand oracleCommand = new MDB.MDBCommand(sql, MyConnection);
                oracleCommand.Parameters.Add(new MDB.MDBParameter("MaQuanLy", obj.MaQuanLy));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("MaBenhNhan", obj.MaBenhNhan));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("HoTenBenhNhan", obj.HoTenBenhNhan));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("CMND", obj.CMND));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("KhaiBaoTiem", obj.KhaiBaoTiem));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("SDT", obj.SDT));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("NgayTiem1", obj.NgayTiem1));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("NamSinh", obj.NamSinh));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("DiaChi", obj.DiaChi));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("NgayTiem2", obj.NgayTiem2));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("MoTaVaccine1", obj.MoTaVaccine1));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("MoTaVaccine2", obj.MoTaVaccine2));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("NguoiDaiDien1", obj.NguoiDaiDien1));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("MaNguoiDaiDien1", obj.MaNguoiDaiDien1));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("NguoiDaiDien2", obj.NguoiDaiDien2));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("MaNguoiDaiDien2", obj.MaNguoiDaiDien2));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("NgaySua", DateTime.Now));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("NguoiSua", Common.getUserLogin()));
                if (obj.ID == 0)
                {
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("NgayTao", DateTime.Now));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("NguoiTao", Common.getUserLogin()));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("ID", obj.ID));
                }
                oracleCommand.BindByName = true;
                int n = oracleCommand.ExecuteNonQuery();
                if (obj.ID == 0)
                {
                    long nextval = Convert.ToInt64((oracleCommand.Parameters["ID"] as MDB.MDBParameter).Value);
                    obj.ID = nextval;
                }
                return n > 0 ? true : false;
            }
            catch (Exception ex)
            {
                XuLyLoi.Handle(ex);
            }
            return false;
        }
        public static bool delete(MDB.MDBConnection MyConnection, decimal id)
        {
            try
            {
                string sql = "DELETE FROM GXNDTCovid WHERE ID = :ID";
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
        public static DataSet getDataSet(MDB.MDBConnection MyConnection, decimal id)
        {
            string sql = @"SELECT
                P.* 
            FROM
                GXNDTCovid P
            WHERE
                ID = " + id;

            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
            MDB.MDBDataAdapter adt = new MDB.MDBDataAdapter(Command);
            var ds = new DataSet();

            adt.Fill(ds, "KQ");
            ds.Tables[0].AddColumn("SOYTE", typeof(string));
            ds.Tables[0].AddColumn("BENHVIEN", typeof(string));
            ds.Tables[0].AddColumn("KHOA", typeof(string));
            ds.Tables[0].Rows[0]["SOYTE"] = XemBenhAn._HanhChinhBenhNhan.SoYTe;
            ds.Tables[0].Rows[0]["BENHVIEN"] = XemBenhAn._HanhChinhBenhNhan.BenhVien;
            ds.Tables[0].Rows[0]["KHOA"] = XemBenhAn._ThongTinDieuTri.Khoa;

            return ds;
        }
    }
}
