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
    public class DonDeNghiTHKTHoTroSinhSan : ThongTinKy
    {
        public DonDeNghiTHKTHoTroSinhSan()
        {
            TableName = "DonDeNghiTHKTHoTroSinhSan";
            TablePrimaryKeyName = "ID";
            IDMauPhieu = (int)DanhMucPhieu.DDNTHKTHTSS;
            TenMauPhieu = DanhMucPhieu.DDNTHKTHTSS.Description();
        }
        [MoTaDuLieu("Mã định danh")]
        public long ID { get; set; }
        [MoTaDuLieu("Mã quản lý: mã duy nhất trong 1 đợt khám chữa bệnh (kcb), không trùng giữa các đợt kcb khác nhau", "", 1)]
        public decimal MaQuanLy { get; set; }
        [MoTaDuLieu("Mã bệnh nhân")]
        public string MaBenhNhan { get; set; }
        [MoTaDuLieu("Danh sách kính gửi")]
        public string KinhGui { get; set; }
        public string HoTenVo { get; set; }
        [MoTaDuLieu("Số chứng minh nhân dân của vợ")]
        public string NamSinhVo { get; set; }
        [MoTaDuLieu("Số chứng minh nhân dân của vợ")]
        public string SoCMNDVo { get; set; }
        [MoTaDuLieu("Ngày cấp CMDN vợ")]
        public string NgayCapCMNDVo { get; set; }
        [MoTaDuLieu("Nơi cấp CMND vợ")]
        public string NoiCapCMNDVo { get; set; }
        [MoTaDuLieu("Nơi cấp CMND vợ")]
        public string DiaChiVo { get; set; }
        public string HoTenChong { get; set; }
        public string NamSinhChong { get; set; }
        [MoTaDuLieu("Số chứng minh nhân dân của chồng")]
        public string SoCMNDChong { get; set; }
        [MoTaDuLieu("Ngày cấp CMDN chồng")]
        public string NgayCapCMNDChong { get; set; }
        [MoTaDuLieu("Nơi cấp CMND chồng")]
        public string NoiCapCMNDChong { get; set; }
        [MoTaDuLieu("Nơi cấp CMND chồng")]
        public string DiaChiChong { get; set; }
        public string LyDo { get; set; }
        public string NhanVienYTe { get; set; }
        public string MaNhanVienYTe { get; set; }
        // bắt buộc
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
    public class DonDeNghiTHKTHoTroSinhSanFunc
    {
        public const string TableName = "DonDeNghiTHKTHoTroSinhSan";
        public const string TablePrimaryKeyName = "ID";
        public static List<DonDeNghiTHKTHoTroSinhSan> GetListData(MDB.MDBConnection _OracleConnection, decimal maquanly)
        {
            List<DonDeNghiTHKTHoTroSinhSan> list = new List<DonDeNghiTHKTHoTroSinhSan>();
            try
            {
                string sql = @"SELECT * FROM DonDeNghiTHKTHoTroSinhSan where MaQuanLy = :MaQuanLy";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, _OracleConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", maquanly));
                MDB.MDBDataReader DataReader = Command.ExecuteReader();
                while (DataReader.Read())
                {
                    DonDeNghiTHKTHoTroSinhSan data = new DonDeNghiTHKTHoTroSinhSan();
                    data.ID = Convert.ToInt64(DataReader.GetLong("ID").ToString());
                    data.MaQuanLy = maquanly;
                    data.MaBenhNhan = DataReader["MaBenhNhan"].ToString();
                    data.KinhGui = DataReader["KinhGui"].ToString();
                    data.HoTenVo = DataReader["HoTenVo"].ToString();
                    data.NamSinhVo = DataReader["NamSinhVo"].ToString();
                    data.SoCMNDVo = DataReader["SoCMNDVo"].ToString();
                    data.NgayCapCMNDVo = DataReader["NgayCapCMNDVo"].ToString();
                    data.NoiCapCMNDVo = DataReader["NoiCapCMNDVo"].ToString();
                    data.DiaChiVo = DataReader["DiaChiVo"].ToString();
                    data.HoTenChong = DataReader["HoTenChong"].ToString();
                    data.NamSinhChong = DataReader["NamSinhChong"].ToString();
                    data.SoCMNDChong = DataReader["SoCMNDChong"].ToString();
                    data.NgayCapCMNDChong = DataReader["NgayCapCMNDChong"].ToString();
                    data.NoiCapCMNDChong = DataReader["NoiCapCMNDChong"].ToString();
                    data.DiaChiChong = DataReader["DiaChiChong"].ToString();
                    data.LyDo = DataReader["LyDo"].ToString();
                    data.NhanVienYTe = DataReader["NhanVienYTe"].ToString();
                    data.MaNhanVienYTe = DataReader["MaNhanVienYTe"].ToString();

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
        public static bool InsertOrUpdate(MDB.MDBConnection MyConnection, ref DonDeNghiTHKTHoTroSinhSan ketQua)
        {
            try
            {
                string sql = @"INSERT INTO DonDeNghiTHKTHoTroSinhSan
                (
                    MAQUANLY,
                    MaBenhNhan,
                    KinhGui,
                    HoTenVo,
                    NamSinhVo,
                    SoCMNDVo,
                    NgayCapCMNDVo,
                    NoiCapCMNDVo,
                    DiaChiVo,
                    HoTenChong,
                    NamSinhChong,
                    SoCMNDChong,
                    NgayCapCMNDChong,
                    NoiCapCMNDChong,
                    DiaChiChong,
                    LyDo,
                    NhanVienYTe,
                    MaNhanVienYTe,
                    NGUOITAO,
                    NGUOISUA,
                    NGAYTAO,
                    NGAYSUA)  VALUES
                 (
				    :MAQUANLY,
                    :MaBenhNhan,
                    :KinhGui,
                    :HoTenVo,
                    :NamSinhVo,
                    :SoCMNDVo,
                    :NgayCapCMNDVo,
                    :NoiCapCMNDVo,
                    :DiaChiVo,
                    :HoTenChong,
                    :NamSinhChong,
                    :SoCMNDChong,
                    :NgayCapCMNDChong,
                    :NoiCapCMNDChong,
                    :DiaChiChong,
                    :LyDo,
                    :NhanVienYTe,
                    :MaNhanVienYTe,
                    :NGUOITAO,
                    :NGUOISUA,
                    :NGAYTAO,
                    :NGAYSUA
                 )  RETURNING ID INTO :ID";
                if (ketQua.ID != 0)
                {
                    sql = @"UPDATE DonDeNghiTHKTHoTroSinhSan SET 
                    MAQUANLY = :MAQUANLY,
                    MaBenhNhan = :MaBenhNhan,
                    KinhGui=:KinhGui,
                    HoTenVo=:HoTenVo,
                    NamSinhVo=:NamSinhVo,
                    SoCMNDVo=:SoCMNDVo,
                    NgayCapCMNDVo=:NgayCapCMNDVo,
                    NoiCapCMNDVo=:NoiCapCMNDVo,
                    DiaChiVo=:DiaChiVo,
                    HoTenChong=:HoTenChong,
                    NamSinhChong=:NamSinhChong,
                    SoCMNDChong=:SoCMNDChong,
                    NgayCapCMNDChong=:NgayCapCMNDChong,
                    NoiCapCMNDChong=:NoiCapCMNDChong,
                    DiaChiChong=:DiaChiChong,
                    LyDo = :LyDo,
                    NhanVienYTe=:NhanVienYTe,
                    MaNhanVienYTe=:MaNhanVienYTe,
                    NGUOISUA = :NGUOISUA,
                    NGAYSUA = :NGAYSUA
                    WHERE ID = " + ketQua.ID;
                }
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MAQUANLY", ketQua.MaQuanLy));
                Command.Parameters.Add(new MDB.MDBParameter("MaBenhNhan", ketQua.MaBenhNhan));
                Command.Parameters.Add(new MDB.MDBParameter("KinhGui", ketQua.KinhGui));
                Command.Parameters.Add(new MDB.MDBParameter("HoTenVo", ketQua.HoTenVo));
                Command.Parameters.Add(new MDB.MDBParameter("NamSinhVo", ketQua.NamSinhVo));
                Command.Parameters.Add(new MDB.MDBParameter("SoCMNDVo", ketQua.SoCMNDVo));
                Command.Parameters.Add(new MDB.MDBParameter("NgayCapCMNDVo", ketQua.NgayCapCMNDVo));
                Command.Parameters.Add(new MDB.MDBParameter("NoiCapCMNDVo", ketQua.NoiCapCMNDVo));
                Command.Parameters.Add(new MDB.MDBParameter("DiaChiVo", ketQua.DiaChiVo));
                Command.Parameters.Add(new MDB.MDBParameter("HoTenChong", ketQua.HoTenChong));
                Command.Parameters.Add(new MDB.MDBParameter("NamSinhChong", ketQua.NamSinhChong));
                Command.Parameters.Add(new MDB.MDBParameter("SoCMNDChong", ketQua.SoCMNDChong));
                Command.Parameters.Add(new MDB.MDBParameter("NgayCapCMNDChong", ketQua.NgayCapCMNDChong));
                Command.Parameters.Add(new MDB.MDBParameter("NoiCapCMNDChong", ketQua.NoiCapCMNDChong));
                Command.Parameters.Add(new MDB.MDBParameter("DiaChiChong", ketQua.DiaChiChong));
                Command.Parameters.Add(new MDB.MDBParameter("LyDo", ketQua.LyDo));
                Command.Parameters.Add(new MDB.MDBParameter("NhanVienYTe", ketQua.NhanVienYTe));
                Command.Parameters.Add(new MDB.MDBParameter("MaNhanVienYTe", ketQua.MaNhanVienYTe));

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
                string sql = "DELETE FROM DonDeNghiTHKTHoTroSinhSan WHERE ID = :ID";
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
                DonDeNghiTHKTHoTroSinhSan P
            WHERE
                ID = " + id;

            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
            MDB.MDBDataAdapter adt = new MDB.MDBDataAdapter(Command);
            var ds = new DataSet();

            adt.Fill(ds, "KQ");

            ds.Tables[0].AddColumn("SOYTE", typeof(string));
            ds.Tables[0].AddColumn("BENHVIEN", typeof(string));

            ds.Tables[0].Rows[0]["SOYTE"] = XemBenhAn._HanhChinhBenhNhan.SoYTe;
            ds.Tables[0].Rows[0]["BENHVIEN"] = XemBenhAn._HanhChinhBenhNhan.BenhVien;

            return ds;
        }
    }
}
