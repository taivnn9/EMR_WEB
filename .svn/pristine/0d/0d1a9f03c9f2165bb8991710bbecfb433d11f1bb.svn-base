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
    public class CamKetBomTTVBTC : ThongTinKy
    {
        public CamKetBomTTVBTC()
        {
            TableName = "CamKetBomTTVBTC";
            TablePrimaryKeyName = "ID";
            IDMauPhieu = (int)DanhMucPhieu.CKBTTVBTC;
            TenMauPhieu = DanhMucPhieu.CKBTTVBTC.Description();
        }
        [MoTaDuLieu("Mã định danh")]
        public long ID { get; set; }
        [MoTaDuLieu("Mã quản lý: mã duy nhất trong 1 đợt khám chữa bệnh (kcb), không trùng giữa các đợt kcb khác nhau", "", 1)]
        public decimal MaQuanLy { get; set; }
        [MoTaDuLieu("Mã bệnh nhân")]
        public string MaBenhNhan { get; set; }
        public string NhanVien { get; set; }
        public string MaNhanVien { get; set; }
        public string HoTenVo { get; set; }
        public string HoTenChong { get; set; }

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
    public class CamKetBomTTVBTCFunc
    {
        public const string TableName = "CamKetBomTTVBTC";
        public const string TablePrimaryKeyName = "ID";
        public static List<CamKetBomTTVBTC> GetListData(MDB.MDBConnection _OracleConnection, decimal maquanly)
        {
            List<CamKetBomTTVBTC> list = new List<CamKetBomTTVBTC>();
            try
            {
                string sql = @"SELECT * FROM CamKetBomTTVBTC where MaQuanLy = :MaQuanLy";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, _OracleConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", maquanly));
                MDB.MDBDataReader DataReader = Command.ExecuteReader();
                while (DataReader.Read())
                {
                    CamKetBomTTVBTC data = new CamKetBomTTVBTC();
                    data.ID = Convert.ToInt64(DataReader.GetLong("ID").ToString());
                    data.MaQuanLy = maquanly;
                    data.MaBenhNhan = DataReader["MaBenhNhan"].ToString();
                    data.NhanVien = DataReader["NhanVien"].ToString();
                    data.MaNhanVien = DataReader["MaNhanVien"].ToString();
                    data.HoTenVo = DataReader["HoTenVo"].ToString();
                    data.HoTenChong = DataReader["HoTenChong"].ToString();

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
        public static bool InsertOrUpdate(MDB.MDBConnection MyConnection, ref CamKetBomTTVBTC ketQua)
        {
            try
            {
                string sql = @"INSERT INTO CamKetBomTTVBTC
                (
                    MAQUANLY,
                    MaBenhNhan,
                    NhanVien,
                    MaNhanVien,
                    HoTenVo,
                    HoTenChong,
                    NGUOITAO,
                    NGUOISUA,
                    NGAYTAO,
                    NGAYSUA)  VALUES
                 (
				    :MAQUANLY,
                    :MaBenhNhan,
                    :NhanVien,
                    :MaNhanVien,
                    :HoTenVo,
                    :HoTenChong,
                    :NGUOITAO,
                    :NGUOISUA,
                    :NGAYTAO,
                    :NGAYSUA
                 )  RETURNING ID INTO :ID";
                if (ketQua.ID != 0)
                {
                    sql = @"UPDATE CamKetBomTTVBTC SET 
                    MAQUANLY = :MAQUANLY,
                    MaBenhNhan = :MaBenhNhan,
                    NhanVien = :NhanVien,
                    MaNhanVien = :MaNhanVien,
                    HoTenVo = :HoTenVo,
                    HoTenChong = :HoTenChong,
                    NGUOISUA = :NGUOISUA,
                    NGAYSUA = :NGAYSUA
                    WHERE ID = " + ketQua.ID;
                }
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MAQUANLY", ketQua.MaQuanLy));
                Command.Parameters.Add(new MDB.MDBParameter("MaBenhNhan", ketQua.MaBenhNhan));
                Command.Parameters.Add(new MDB.MDBParameter("NhanVien", ketQua.NhanVien));
                Command.Parameters.Add(new MDB.MDBParameter("MaNhanVien", ketQua.MaNhanVien));
                Command.Parameters.Add(new MDB.MDBParameter("HoTenVo", ketQua.HoTenVo));
                Command.Parameters.Add(new MDB.MDBParameter("HoTenChong", ketQua.HoTenChong));

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
                string sql = "DELETE FROM CamKetBomTTVBTC WHERE ID = :ID";
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
                CamKetBomTTVBTC P
            WHERE
                ID = " + id;

            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
            MDB.MDBDataAdapter adt = new MDB.MDBDataAdapter(Command);
            var ds = new DataSet();

            adt.Fill(ds, "KQ");

            ds.Tables[0].AddColumn("LoGoPath", typeof(string));
            ds.Tables[0].AddColumn("SOYTE", typeof(string));
            ds.Tables[0].AddColumn("BENHVIEN", typeof(string));

            ds.Tables[0].Rows[0]["LoGoPath"] = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location) + @"\PaintLibrary\HinhAnh\LoGoVien\" + "Logo.png";
            ds.Tables[0].Rows[0]["SOYTE"] = XemBenhAn._HanhChinhBenhNhan.SoYTe;
            ds.Tables[0].Rows[0]["BENHVIEN"] = XemBenhAn._HanhChinhBenhNhan.BenhVien;

            return ds;
        }
    }
}
