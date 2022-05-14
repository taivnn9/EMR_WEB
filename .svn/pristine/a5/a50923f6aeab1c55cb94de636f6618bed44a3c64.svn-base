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
    public class GiayBaoTu : ThongTinKy
    {
        public GiayBaoTu()
        {
            TableName = "GiayBaoTu";
            TablePrimaryKeyName = "ID";
            IDMauPhieu = (int)DanhMucPhieu.GBT;
            TenMauPhieu = DanhMucPhieu.GBT.Description();
        }
        [MoTaDuLieu("Mã định danh")]
        public long ID { get; set; }
        [MoTaDuLieu("Mã quản lý: mã duy nhất trong 1 đợt khám chữa bệnh (kcb), không trùng giữa các đợt kcb khác nhau", "", 1)]
        public decimal MaQuanLy { get; set; }
        [MoTaDuLieu("Mã bệnh nhân")]
        public string MaBenhNhan { get; set; }
        public string So { get; set; }
        public string QuyenSo { get; set; }
        public string CoSoKhamBenh { get; set; }
        public string DiaChi { get; set; }
        public string HoVaTen { get; set; }
        public DateTime? NamSinh { get; set; }
        public string GioiTinh { get; set; }
        public string DanToc { get; set; }
        public string QuocTich { get; set; }
        public string ThuongTru { get; set; }
        public string CMND { get; set; }
        public DateTime? NgayCap { get; set; }
        public string NoiCap { get; set; }
        public DateTime? TuVongLuc { get; set; }
        public DateTime? TuVongLuc_Gio { get; set; }
        public string NguyenNhanTuVong { get; set; }
        public string NguoiThanThich { get; set; }
        public string NguoiGhiGiay { get; set; }
        public string MaNguoiGhiGiay { get; set; }
        public string ThuTruong { get; set; }
        public string MaThuTruong { get; set; }
        public string So2 { get; set; }
        public string QuyenSo2 { get; set; }
        public int TuVongTrenDuongCapCuu { get; set; }
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
    public class GiayBaoTuFunc
    {
        public const string TableName = "GiayBaoTu";
        public const string TablePrimaryKeyName = "ID";
        public static List<GiayBaoTu> GetListData(MDB.MDBConnection _OracleConnection, decimal maquanly)
        {
            List<GiayBaoTu> list = new List<GiayBaoTu>();
            try
            {
                string sql = @"SELECT * FROM GiayBaoTu where MaQuanLy = :MaQuanLy";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, _OracleConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", maquanly));
                MDB.MDBDataReader DataReader = Command.ExecuteReader();
                while (DataReader.Read())
                {
                    GiayBaoTu data = new GiayBaoTu();
                    data.ID = Convert.ToInt64(DataReader.GetLong("ID").ToString());
                    data.MaQuanLy = maquanly;
                    data.MaBenhNhan = DataReader["MaBenhNhan"].ToString();
                    data.So = DataReader["So"].ToString();
                    data.QuyenSo = DataReader["QuyenSo"].ToString();
                    data.CoSoKhamBenh = DataReader["CoSoKhamBenh"].ToString();
                    data.DiaChi = DataReader["DiaChi"].ToString();
                    data.HoVaTen = DataReader["HoVaTen"].ToString();
                    data.NamSinh = DataReader["NamSinh"] != DBNull.Value ? (DateTime?) Convert.ToDateTime(DataReader["NamSinh"].ToString()) : null;
                    data.GioiTinh = DataReader["GioiTinh"].ToString();
                    data.DanToc = DataReader["DanToc"].ToString();
                    data.QuocTich = DataReader["QuocTich"].ToString();
                    data.ThuongTru = DataReader["ThuongTru"].ToString();
                    data.CMND = DataReader["CMND"].ToString();
                    data.NgayCap = DataReader["NgayCap"] != DBNull.Value ? (DateTime?)Convert.ToDateTime(DataReader["NgayCap"].ToString()) : null;
                    data.NoiCap = DataReader["NoiCap"].ToString();
                    data.TuVongLuc = DataReader["TuVongLuc"] != DBNull.Value ? (DateTime?)Convert.ToDateTime(DataReader["TuVongLuc"].ToString()) : null;
                    data.TuVongLuc_Gio = data.TuVongLuc;
                    data.NguyenNhanTuVong = DataReader["NguyenNhanTuVong"].ToString();
                    data.NguoiThanThich = DataReader["NguoiThanThich"].ToString();
                    data.NguoiGhiGiay = DataReader["NguoiGhiGiay"].ToString();
                    data.MaNguoiGhiGiay = DataReader["MaNguoiGhiGiay"].ToString();
                    data.ThuTruong = DataReader["ThuTruong"].ToString();
                    data.MaThuTruong = DataReader["MaThuTruong"].ToString();
                    data.So2 = DataReader["So2"].ToString();
                    data.QuyenSo2 = DataReader["QuyenSo2"].ToString();

                    int tempInt = 0;
                    data.TuVongTrenDuongCapCuu = int.TryParse(DataReader["TuVongTrenDuongCapCuu"].ToString(), out tempInt) ? tempInt : 0;

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
        public static bool InsertOrUpdate(MDB.MDBConnection MyConnection, ref GiayBaoTu ketQua)
        {
            try
            {
                string sql = @"INSERT INTO GiayBaoTu
                (
                    MAQUANLY,
                    MaBenhNhan,
                    So,
                    QuyenSo,
                    CoSoKhamBenh,
                    DiaChi,
                    HoVaTen,
                    NamSinh,
                    GioiTinh,
                    DanToc,
                    QuocTich,
                    ThuongTru,
                    CMND,
                    NgayCap,
                    NoiCap,
                    TuVongLuc,
                    NguyenNhanTuVong,
                    NguoiThanThich,
                    NguoiGhiGiay,
                    MaNguoiGhiGiay,
                    ThuTruong,
                    MaThuTruong,
                    So2,
                    QuyenSo2,
                    TuVongTrenDuongCapCuu,
                    NGUOITAO,
                    NGUOISUA,
                    NGAYTAO,
                    NGAYSUA)  VALUES
                 (
				    :MAQUANLY,
                    :MaBenhNhan,
                    :So,
                    :QuyenSo,
                    :CoSoKhamBenh,
                    :DiaChi,
                    :HoVaTen,
                    :NamSinh,
                    :GioiTinh,
                    :DanToc,
                    :QuocTich,
                    :ThuongTru,
                    :CMND,
                    :NgayCap,
                    :NoiCap,
                    :TuVongLuc,
                    :NguyenNhanTuVong,
                    :NguoiThanThich,
                    :NguoiGhiGiay,
                    :MaNguoiGhiGiay,
                    :ThuTruong,
                    :MaThuTruong,
                    :So2,
                    :QuyenSo2,
                    :TuVongTrenDuongCapCuu,
                    :NGUOITAO,
                    :NGUOISUA,
                    :NGAYTAO,
                    :NGAYSUA
                 )  RETURNING ID INTO :ID";
                if (ketQua.ID != 0)
                {
                    sql = @"UPDATE GiayBaoTu SET 
                    MAQUANLY = :MAQUANLY,
                    MaBenhNhan = :MaBenhNhan,
                    So=:So,
                    QuyenSo=:QuyenSo,
                    CoSoKhamBenh=:CoSoKhamBenh,
                    DiaChi=:DiaChi,
                    HoVaTen=:HoVaTen,
                    NamSinh=:NamSinh,
                    GioiTinh=:GioiTinh,
                    DanToc=:DanToc,
                    QuocTich=:QuocTich,
                    ThuongTru=:ThuongTru,
                    CMND=:CMND,
                    NgayCap=:NgayCap,
                    NoiCap=:NoiCap,
                    TuVongLuc=:TuVongLuc,
                    NguyenNhanTuVong=:NguyenNhanTuVong,
                    NguoiThanThich=:NguoiThanThich,
                    NguoiGhiGiay=:NguoiGhiGiay,
                    MaNguoiGhiGiay=:MaNguoiGhiGiay,
                    ThuTruong=:ThuTruong,
                    MaThuTruong=:MaThuTruong,
                    So2=:So2,
                    QuyenSo2=:QuyenSo2,
                    TuVongTrenDuongCapCuu=:TuVongTrenDuongCapCuu,
                    NGUOISUA = :NGUOISUA,
                    NGAYSUA = :NGAYSUA
                    WHERE ID = " + ketQua.ID;
                }
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MAQUANLY", ketQua.MaQuanLy));
                Command.Parameters.Add(new MDB.MDBParameter("MaBenhNhan", ketQua.MaBenhNhan));
                Command.Parameters.Add(new MDB.MDBParameter("So", ketQua.So));
                Command.Parameters.Add(new MDB.MDBParameter("QuyenSo", ketQua.QuyenSo));
                Command.Parameters.Add(new MDB.MDBParameter("CoSoKhamBenh", ketQua.CoSoKhamBenh));
                Command.Parameters.Add(new MDB.MDBParameter("DiaChi", ketQua.DiaChi));
                Command.Parameters.Add(new MDB.MDBParameter("HoVaTen", ketQua.HoVaTen));
                Command.Parameters.Add(new MDB.MDBParameter("NamSinh", ketQua.NamSinh));
                Command.Parameters.Add(new MDB.MDBParameter("GioiTinh", ketQua.GioiTinh));
                Command.Parameters.Add(new MDB.MDBParameter("DanToc", ketQua.DanToc));
                Command.Parameters.Add(new MDB.MDBParameter("QuocTich", ketQua.QuocTich));
                Command.Parameters.Add(new MDB.MDBParameter("ThuongTru", ketQua.ThuongTru));
                Command.Parameters.Add(new MDB.MDBParameter("CMND", ketQua.CMND));
                Command.Parameters.Add(new MDB.MDBParameter("NgayCap", ketQua.NgayCap));
                Command.Parameters.Add(new MDB.MDBParameter("NoiCap", ketQua.NoiCap));
                DateTime? TGM_ThoiGian = ketQua.TuVongLuc.HasValue ? ketQua.TuVongLuc.Value : DateTime.Now;
                var ThoiGianThucHien_Gio = ketQua.TuVongLuc_Gio.HasValue ? ketQua.TuVongLuc_Gio.Value.TimeOfDay : new TimeSpan(0, 0, 0);
                TGM_ThoiGian = TGM_ThoiGian + ThoiGianThucHien_Gio;
                Command.Parameters.Add(new MDB.MDBParameter("TuVongLuc", ketQua.TuVongLuc));
                Command.Parameters.Add(new MDB.MDBParameter("NguyenNhanTuVong", ketQua.NguyenNhanTuVong));
                Command.Parameters.Add(new MDB.MDBParameter("NguoiThanThich", ketQua.NguoiThanThich));
                Command.Parameters.Add(new MDB.MDBParameter("NguoiGhiGiay", ketQua.NguoiGhiGiay));
                Command.Parameters.Add(new MDB.MDBParameter("MaNguoiGhiGiay", ketQua.MaNguoiGhiGiay));
                Command.Parameters.Add(new MDB.MDBParameter("ThuTruong", ketQua.ThuTruong));
                Command.Parameters.Add(new MDB.MDBParameter("MaThuTruong", ketQua.MaThuTruong));
                Command.Parameters.Add(new MDB.MDBParameter("So2", ketQua.So2));
                Command.Parameters.Add(new MDB.MDBParameter("QuyenSo2", ketQua.QuyenSo2));
                Command.Parameters.Add(new MDB.MDBParameter("TuVongTrenDuongCapCuu", ketQua.TuVongTrenDuongCapCuu));
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
                string sql = "DELETE FROM GiayBaoTu WHERE ID = :ID";
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
                GiayBaoTu P
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
