using EMR.KyDienTu;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PMS.Access; 

namespace EMR_MAIN.DATABASE.Other
{
    public class NoiDungTuVan
    {
        public string NoiDung { get; set; }
        public string ChiTiet { get; set; }
        public string MaNguoiTuVan { get; set; }
        public string NguoiTuVan { get; set; }
        public DateTime NgayTuVan { get; set; }
        public string XacNhan { get; set; }
    }
    public class PhieuTuVanBNTN : ThongTinKy
    {
        public PhieuTuVanBNTN()
        {
            TableName = "PhieuTuVanBNTN";
            TablePrimaryKeyName = "ID";
            IDMauPhieu = (int)DanhMucPhieu.PTVBNTN;
            TenMauPhieu = DanhMucPhieu.PTVBNTN.Description();
        }
        [MoTaDuLieu("Mã định danh")]
		public long ID { get; set; }
        [MoTaDuLieu("Mã quản lý: mã duy nhất trong 1 đợt khám chữa bệnh (kcb), không trùng giữa các đợt kcb khác nhau","",1)]
		public decimal MaQuanLy { get; set; }
        [MoTaDuLieu("Mã bệnh nhân")]
		public string MaBenhNhan { get; set; }
        public string HoTenNguoiNha { get; set; }
        public string NamSinhNguoiNha { get; set; }
        [MoTaDuLieu("Giới tính bệnh nhân")]
		public string GioiTinhNguoiNha { get; set; }
        public string QuanHe { get; set; }
        [MoTaDuLieu("Khoa")]
		public string Khoa { get; set; }
        [MoTaDuLieu("Mã khoa")]
		public string MaKhoa { get; set; }
        public ObservableCollection<NoiDungTuVan> NoiDungTuVans { get; set; }
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
    public class PhieuTuVanBNTNFunc
    {
        public const string TableName = "PhieuTuVanBNTN";
        public const string TablePrimaryKeyName = "ID";
        public static List<PhieuTuVanBNTN> GetListData(MDB.MDBConnection _OracleConnection, decimal maquanly)
        {
            List<PhieuTuVanBNTN> list = new List<PhieuTuVanBNTN>();
            try
            {
                string sql = @"SELECT * FROM PhieuTuVanBNTN where MaQuanLy = :MaQuanLy";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, _OracleConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", maquanly));
                MDB.MDBDataReader DataReader = Command.ExecuteReader();
                while (DataReader.Read())
                {
                    PhieuTuVanBNTN data = new PhieuTuVanBNTN();
                    data.ID = Convert.ToInt64(DataReader.GetLong("ID").ToString());
                    data.MaQuanLy = maquanly;
                    data.MaBenhNhan = DataReader["MaBenhNhan"].ToString();
                    data.HoTenNguoiNha = DataReader["HoTenNguoiNha"].ToString();

                    data.NamSinhNguoiNha = DataReader["NamSinhNguoiNha"].ToString();
                    data.GioiTinhNguoiNha = DataReader["GioiTinhNguoiNha"].ToString();
                    data.QuanHe = DataReader["QuanHe"].ToString();
                    data.Khoa = DataReader["Khoa"].ToString();
                    data.MaKhoa = DataReader["MaKhoa"].ToString();

                    data.NoiDungTuVans = JsonConvert.DeserializeObject<ObservableCollection<NoiDungTuVan>>(DataReader["NoiDungTuVans"].ToString());

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
        
        //using CLOUD DB
        public static bool InsertOrUpdate(MDB.MDBConnection MyConnection, ref PhieuTuVanBNTN phieuTuVan)
        {
            try
            {
                string sql = @"INSERT INTO PhieuTuVanBNTN
                (
                    MAQUANLY,
                    MaBenhNhan,
                    HoTenNguoiNha,
                    NamSinhNguoiNha,
                    GioiTinhNguoiNha,
                    QuanHe,
                    Khoa,
                    MaKhoa,
                    NoiDungTuVans,
                    NGUOITAO,
                    NGUOISUA,
                    NGAYTAO,
                    NGAYSUA)  VALUES
                 (
				    :MAQUANLY,
                    :MaBenhNhan,
                    :HoTenNguoiNha,
                    :NamSinhNguoiNha,
                    :GioiTinhNguoiNha,
                    :QuanHe,
                    :Khoa,
                    :MaKhoa,
                    :NoiDungTuVans,
                    :NGUOITAO,
                    :NGUOISUA,
                    :NGAYTAO,
                    :NGAYSUA
                 )  RETURNING ID INTO :ID";
                if (phieuTuVan.ID != 0)
                {
                    sql = @"UPDATE PhieuTuVanBNTN SET 
                    MAQUANLY = :MAQUANLY,
                    MaBenhNhan = :MaBenhNhan,
                    HoTenNguoiNha = :HoTenNguoiNha,
                    NamSinhNguoiNha = :NamSinhNguoiNha,
                    GioiTinhNguoiNha = :GioiTinhNguoiNha,
                    QuanHe = :QuanHe,
                    Khoa = :Khoa,
                    MaKhoa = :MaKhoa,
                    NoiDungTuVans = :NoiDungTuVans,
                    NGUOISUA = :NGUOISUA,
                    NGAYSUA = :NGAYSUA
                    WHERE ID = " + phieuTuVan.ID;
                }
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MAQUANLY", phieuTuVan.MaQuanLy));
                Command.Parameters.Add(new MDB.MDBParameter("MaBenhNhan", phieuTuVan.MaBenhNhan));
                Command.Parameters.Add(new MDB.MDBParameter("HoTenNguoiNha", phieuTuVan.HoTenNguoiNha));
                Command.Parameters.Add(new MDB.MDBParameter("NamSinhNguoiNha", phieuTuVan.NamSinhNguoiNha));
                Command.Parameters.Add(new MDB.MDBParameter("GioiTinhNguoiNha", phieuTuVan.GioiTinhNguoiNha));
                Command.Parameters.Add(new MDB.MDBParameter("QuanHe", phieuTuVan.QuanHe));
                Command.Parameters.Add(new MDB.MDBParameter("Khoa", phieuTuVan.Khoa));
                Command.Parameters.Add(new MDB.MDBParameter("MaKhoa", phieuTuVan.MaKhoa));
                Command.Parameters.Add(new MDB.MDBParameter("MaKhoa", phieuTuVan.MaKhoa));
                Command.Parameters.Add(new MDB.MDBParameter("NoiDungTuVans", JsonConvert.SerializeObject(phieuTuVan.NoiDungTuVans)));
                Command.Parameters.Add(new MDB.MDBParameter("NGUOISUA", phieuTuVan.NguoiSua));
                Command.Parameters.Add(new MDB.MDBParameter("NGAYSUA", phieuTuVan.NgaySua));
                if (phieuTuVan.ID == 0)
                {
                    Command.Parameters.Add(new MDB.MDBParameter("ID", phieuTuVan.ID));
                    Command.Parameters.Add(new MDB.MDBParameter("NGUOITAO", phieuTuVan.NguoiTao));
                    Command.Parameters.Add(new MDB.MDBParameter("NGAYTAO", phieuTuVan.NgayTao));
                }
                Command.BindByName = true;
                int n = Command.ExecuteNonQuery();
                if (phieuTuVan.ID == 0)
                {
                    long nextval = Convert.ToInt64((Command.Parameters["ID"] as MDB.MDBParameter).Value);
                    phieuTuVan.ID = nextval;
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
                string sql = "DELETE FROM PhieuTuVanBNTN WHERE ID = :ID";
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
                B.HoTenNguoiNha,
                B.NamSinhNguoiNha,
                B.GioiTinhNguoiNha,
                B.QuanHe,
                B.Khoa,
                T.MABENHAN,
                T.GIUONG,
                H.GIOITINH,
	            H.TENBENHNHAN,
                H.NGAYSINH
            FROM
                PhieuTuVanBNTN B
                LEFT JOIN THONGTINDIEUTRI T ON B.MAQUANLY = T.MAQUANLY
                LEFT JOIN HANHCHINHBENHNHAN H ON T.MABENHNHAN = H.MABENHNHAN
            WHERE
                ID = " + id;

            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);

            MDB.MDBDataAdapter adt = new MDB.MDBDataAdapter(Command);
            var ds = new DataSet();

            adt.Fill(ds, "PTV");

            

            sql = @"SELECT
                NoiDungTuVans
            FROM
                PhieuTuVanBNTN
            WHERE
                ID = " + id;
            Command = new MDB.MDBCommand(sql, MyConnection);
            MDB.MDBDataReader DataReader = Command.ExecuteReader();
            ObservableCollection<NoiDungTuVan> NDTV = new ObservableCollection<NoiDungTuVan>();
            while (DataReader.Read())
            {
                NDTV = JsonConvert.DeserializeObject<ObservableCollection<NoiDungTuVan>>(DataReader["NoiDungTuVans"].ToString());
            }
            DataTable NoiDungTuVan = new DataTable("NDTV");
            NoiDungTuVan.Columns.Add("NOIDUNG");
            NoiDungTuVan.Columns.Add("CHITIET");
            NoiDungTuVan.Columns.Add("NGAYTUVAN");
            NoiDungTuVan.Columns.Add("NGUOITUVAN");
            NoiDungTuVan.Columns.Add("XACNHAN");
            foreach(NoiDungTuVan n in NDTV)
            {
                NoiDungTuVan.Rows.Add(
                    n.NoiDung,
                    n.ChiTiet,
                    n.NgayTuVan.ToString("dd/MM/yyyy"),
                    n.NguoiTuVan,
                    n.XacNhan);
            }
            ds.Tables.Add(NoiDungTuVan);
            return ds;
        }
    }
}
