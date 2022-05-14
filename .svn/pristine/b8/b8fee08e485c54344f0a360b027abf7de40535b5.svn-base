using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EMR.KyDienTu;
using PMS.Access;
namespace EMR_MAIN.DATABASE.Other
{
    public class BanCamKetCovid : ThongTinKy
    {
        public BanCamKetCovid()
        {
            TableName = "BanCamKetCovid";
            TablePrimaryKeyName = "ID";
            IDMauPhieu = (int)DanhMucPhieu.BCKCOVID;
            TenMauPhieu = DanhMucPhieu.BCKCOVID.Description();
        }
        [MoTaDuLieu("Mã định danh")]
        public long ID { get; set; }
        [MoTaDuLieu("Mã quản lý: mã duy nhất trong 1 đợt khám chữa bệnh (kcb), không trùng giữa các đợt kcb khác nhau", "", 1)]
        public decimal MaQuanLy { get; set; }
        [MoTaDuLieu("Mã bệnh nhân")]
        public string MaBenhNhan { get; set; }
        public string BenhVien { get; set; }
        public string HoTen { get; set; }
        public string GioiTinh { get; set; }
        public string TenBenhNhan { get; set; }
        public string SDT { get; set; }
        public string DiaChiTamTru { get; set; }
        public string ThuongTru { get; set; }
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
    public class BanCamKetCovidFunc
    {
        public const string TableName = "BanCamKetCovid";
        public const string TablePrimaryKeyName = "ID";
        public static List<BanCamKetCovid> GetListData(MDB.MDBConnection _OracleConnection, decimal maquanly)
        {
            List<BanCamKetCovid> list = new List<BanCamKetCovid>();
            try
            {
                string sql = @"SELECT * FROM BanCamKetCovid where MaQuanLy = :MaQuanLy";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, _OracleConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", maquanly));
                MDB.MDBDataReader DataReader = Command.ExecuteReader();
                while (DataReader.Read())
                {
                    BanCamKetCovid data = new BanCamKetCovid();
                    data.ID = Convert.ToInt64(DataReader.GetLong("ID").ToString());
                    data.MaQuanLy = maquanly;
                    data.MaBenhNhan = DataReader["MaBenhNhan"].ToString();
                    data.BenhVien = DataReader["BenhVien"].ToString();
                    data.HoTen = DataReader["HoTen"].ToString();
                    data.GioiTinh = DataReader["GioiTinh"].ToString();
                    data.TenBenhNhan = DataReader["TenBenhNhan"].ToString();
                    data.SDT = DataReader["SDT"].ToString();
                    data.DiaChiTamTru = DataReader["DiaChiTamTru"].ToString();
                    data.ThuongTru = DataReader["ThuongTru"].ToString();

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
        public static bool InsertOrUpdate(MDB.MDBConnection MyConnection, ref BanCamKetCovid ketQua)
        {
            try
            {
                string sql = @"INSERT INTO BanCamKetCovid
                (
                    MAQUANLY,
                    MaBenhNhan,
                    BenhVien,
                    HoTen,
                    GioiTinh,
                    TenBenhNhan,
                    SDT,
                    DiaChiTamTru,
                    ThuongTru,
                    NGUOITAO,
                    NGUOISUA,
                    NGAYTAO,
                    NGAYSUA)  VALUES
                 (
				    :MAQUANLY,
                    :MaBenhNhan,
                    :BenhVien,
                    :HoTen,
                    :GioiTinh,
                    :TenBenhNhan,
                    :SDT,
                    :DiaChiTamTru,
                    :ThuongTru,
                    :NGUOITAO,
                    :NGUOISUA,
                    :NGAYTAO,
                    :NGAYSUA
                 )  RETURNING ID INTO :ID";
                if (ketQua.ID != 0)
                {
                    sql = @"UPDATE BanCamKetCovid SET 
                    MAQUANLY = :MAQUANLY,
                    MaBenhNhan = :MaBenhNhan,
                    BenhVien=:BenhVien,
                    HoTen=:HoTen,
                    GioiTinh=:GioiTinh,
                    TenBenhNhan=:TenBenhNhan,
                    SDT=:SDT,
                    DiaChiTamTru=:DiaChiTamTru,
                    ThuongTru=:ThuongTru,
                    NGUOISUA = :NGUOISUA,
                    NGAYSUA = :NGAYSUA
                    WHERE ID = " + ketQua.ID;
                }
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MAQUANLY", ketQua.MaQuanLy));
                Command.Parameters.Add(new MDB.MDBParameter("MaBenhNhan", ketQua.MaBenhNhan));
                Command.Parameters.Add(new MDB.MDBParameter("BenhVien", ketQua.BenhVien));
                Command.Parameters.Add(new MDB.MDBParameter("HoTen", ketQua.HoTen));
                Command.Parameters.Add(new MDB.MDBParameter("GioiTinh", ketQua.GioiTinh));
                Command.Parameters.Add(new MDB.MDBParameter("TenBenhNhan", ketQua.TenBenhNhan));
                Command.Parameters.Add(new MDB.MDBParameter("SDT", ketQua.SDT));
                Command.Parameters.Add(new MDB.MDBParameter("DiaChiTamTru", ketQua.DiaChiTamTru));
                Command.Parameters.Add(new MDB.MDBParameter("ThuongTru", ketQua.ThuongTru));
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
                string sql = "DELETE FROM BanCamKetCovid WHERE ID = :ID";
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
                BanCamKetCovid P
            WHERE
                ID = " + id;

            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
            MDB.MDBDataAdapter adt = new MDB.MDBDataAdapter(Command);
            var ds = new DataSet();

            adt.Fill(ds, "KQ");

            return ds;
        }
    }
}
