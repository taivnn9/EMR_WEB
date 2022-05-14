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
    public class GiayDangKyBaoPhongDichVu : ThongTinKy
    {
        public GiayDangKyBaoPhongDichVu()
        {
            TableName = "GiayDangKyBaoPhongDichVu";
            TablePrimaryKeyName = "ID";
            IDMauPhieu = (int)DanhMucPhieu.GDKBPDV;
            TenMauPhieu = DanhMucPhieu.GDKBPDV.Description();
        }
        // Phần chung
        [MoTaDuLieu("Mã định danh")]
        public long ID { get; set; }
        [MoTaDuLieu("Mã quản lý: mã duy nhất trong 1 đợt khám chữa bệnh (kcb), không trùng giữa các đợt kcb khác nhau", "", 1)]
        public decimal MaQuanLy { get; set; }
        [MoTaDuLieu("Mã bệnh nhân")]
        public string MaBenhNhan { get; set; }
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
        // End Phần chung 
        [MoTaDuLieu("Họ và tên")]
        public string HoVaTen { get; set; }
        [MoTaDuLieu("Tuổi")]
        public string Tuoi { get; set; }
        [MoTaDuLieu("Nam/Nữ")]
        public string NamHoacNu { get; set; }
        [MoTaDuLieu("Phòng")]
        public string Phong { get; set; }
        [MoTaDuLieu("Địa chỉ nhà")]
        public string DiaChiNha { get; set; }
        [MoTaDuLieu("Chuẩn đoán")]
        public string ChuanDoan { get; set; }
        [MoTaDuLieu("Ngày")]
        public string Ngay { get; set; }
        [MoTaDuLieu("Tháng")]
        public string Thang { get; set; }
        [MoTaDuLieu("ĐD Tư Vấn")]
        public string  DDTuVanId{ get; set; }
        [MoTaDuLieu("Tên ĐD Tư Vấn ")]
        public string TenDDTuVan { get; set; }
        // de hien thi
        public string DayNow { get; set; }
        public string MonthNow { get; set; }
        // endde hien thi
        [MoTaDuLieu("Từ Ngày", null, 0, 0)]
        public DateTime TuNgay { get; set; }
    }
    public class GiayDangKyBaoPhongDichVuFunc
    {
        public const string TableName = "GiayDangKyBaoPhongDichVuFunc";
        public const string TablePrimaryKeyName = "ID";
        public static List<GiayDangKyBaoPhongDichVu> GetListData(MDB.MDBConnection _OracleConnection, decimal maquanly)
        {
            List<GiayDangKyBaoPhongDichVu> list = new List<GiayDangKyBaoPhongDichVu>();
            try
            {
                string sql = @"SELECT * FROM GiayDangKyBaoPhongDichVu where MaQuanLy = :MaQuanLy";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, _OracleConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", maquanly));
                MDB.MDBDataReader DataReader = Command.ExecuteReader();
                while (DataReader.Read())
                {
                    GiayDangKyBaoPhongDichVu data = new GiayDangKyBaoPhongDichVu();
                    data.ID = Convert.ToInt64(DataReader.GetLong("ID").ToString());
                    data.MaQuanLy = maquanly;
                    data.MaBenhNhan = DataReader["MaBenhNhan"].ToString();
                    data.HoVaTen = DataReader["HoVaTen"].ToString();
                    data.Tuoi = DataReader["Tuoi"].ToString();
                    data.NamHoacNu = DataReader["NamHoacNu"].ToString();
                    data.Phong = DataReader["Phong"].ToString();
                    data.DiaChiNha = DataReader["DiaChiNha"].ToString();
                    data.ChuanDoan = DataReader["ChuanDoan"].ToString();
                    data.DDTuVanId = DataReader["DDTuVanId"].ToString();
                    data.TenDDTuVan = DataReader["TenDDTuVan"].ToString();
                    data.TuNgay = Convert.ToDateTime(DataReader["TuNgay"] == DBNull.Value ? DateTime.Now : DataReader["TuNgay"]);

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
        public static bool InsertOrUpdate(MDB.MDBConnection MyConnection, ref GiayDangKyBaoPhongDichVu ketQua)
        {
            try
            {
                string sql = @"INSERT INTO GiayDangKyBaoPhongDichVu
                (
                    MAQUANLY,
                    MaBenhNhan,
                    HoVaTen,
                    Tuoi,
                    NamHoacNu,
                    Phong,
                    DiaChiNha,
                    ChuanDoan,
                    DDTuVanId,
                    TenDDTuVan,
                    TuNgay,
                    NGUOITAO,
                    NGUOISUA,
                    NGAYTAO,
                    NGAYSUA)  VALUES
                 (
				    :MAQUANLY,
                    :MaBenhNhan,
                    :HoVaTen,
                    :Tuoi,
                    :NamHoacNu,
                    :Phong,
                    :DiaChiNha,
                    :ChuanDoan,
                    :DDTuVanId,
                    :TenDDTuVan,
                    :TuNgay,
                    :NGUOITAO,
                    :NGUOISUA,
                    :NGAYTAO,
                    :NGAYSUA
                 )  RETURNING ID INTO :ID";
                if (ketQua.ID != 0)
                {
                    sql = @"UPDATE GiayDangKyBaoPhongDichVu SET 
                    MAQUANLY = :MAQUANLY,
                    MaBenhNhan = :MaBenhNhan,
                    HoVaTen=:HoVaTen,
                    Tuoi=:Tuoi,
                    NamHoacNu=:NamHoacNu,
                    Phong=:Phong,
                    DiaChiNha=:DiaChiNha,
                    ChuanDoan=:ChuanDoan,
                    DDTuVanId=:DDTuVanId,
                    TenDDTuVan=:TenDDTuVan,
                    TuNgay=:TuNgay,
                    NGUOISUA = :NGUOISUA,
                    NGAYSUA = :NGAYSUA
                    WHERE ID = " + ketQua.ID;
                }
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MAQUANLY", ketQua.MaQuanLy));
                Command.Parameters.Add(new MDB.MDBParameter("MaBenhNhan", ketQua.MaBenhNhan));
                Command.Parameters.Add(new MDB.MDBParameter("HoVaTen", ketQua.HoVaTen));
                Command.Parameters.Add(new MDB.MDBParameter("Tuoi", ketQua.Tuoi));
                Command.Parameters.Add(new MDB.MDBParameter("NamHoacNu", ketQua.NamHoacNu));
                Command.Parameters.Add(new MDB.MDBParameter("Phong", ketQua.Phong));
                Command.Parameters.Add(new MDB.MDBParameter("DiaChiNha", ketQua.DiaChiNha));
                Command.Parameters.Add(new MDB.MDBParameter("ChuanDoan", ketQua.ChuanDoan));
                Command.Parameters.Add(new MDB.MDBParameter("DDTuVanId", ketQua.DDTuVanId));
                var TenDDTuVan = getTenDDTuVan(MyConnection, ketQua.DDTuVanId);
                Command.Parameters.Add(new MDB.MDBParameter("TenDDTuVan", TenDDTuVan));
                Command.Parameters.Add(new MDB.MDBParameter("TuNgay", ketQua.TuNgay));
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
        public static string getTenDDTuVan(MDB.MDBConnection MyConnection, string DDTuVanId)
        {
            try
            {
                var result = "";
                string sql = "Select HoVaTen From  NhanVien WHERE MaNhanVien = :DDTuVanId";
                MDB.MDBCommand command = new MDB.MDBCommand(sql, MyConnection);
                command.Parameters.Add(new MDB.MDBParameter("DDTuVanId", DDTuVanId));
                command.BindByName = true;
                MDB.MDBDataReader DataReader = command.ExecuteReader();
                while (DataReader.Read())
                {
                    result = DataReader["HoVaTen"].ToString();
                }
                return result;
            }
            catch (Exception ex)
            {
                XuLyLoi.Handle(ex);
            }
            return "";
        }
        public static bool delete(MDB.MDBConnection MyConnection, long id)
        {
            try
            {
                string sql = "DELETE FROM GiayDangKyBaoPhongDichVu WHERE ID = :ID";
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
                GiayDangKyBaoPhongDichVu P
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
