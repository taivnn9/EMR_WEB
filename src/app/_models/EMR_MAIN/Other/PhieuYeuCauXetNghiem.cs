using EMR.KyDienTu;
using Newtonsoft.Json;
using PMS.Access;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMR_MAIN.DATABASE.Other
{
    public class PhieuYeuCauXetNghiem : ThongTinKy
    {
        public PhieuYeuCauXetNghiem()
        {
            TableName = "PhieuYeuCauXetNghiem";
            TablePrimaryKeyName = "ID";
            IDMauPhieu = (int)DanhMucPhieu.PYCXN;
            TenMauPhieu = DanhMucPhieu.PYCXN.Description();
        }
        [MoTaDuLieu("Mã định danh")]
		public long ID { get; set; }
        [MoTaDuLieu("Mã quản lý: mã duy nhất trong 1 đợt khám chữa bệnh (kcb), không trùng giữa các đợt kcb khác nhau","",1)]
		public decimal MaQuanLy { get; set; }
        public int HoTen_1 { get; set; }
        public int HoTen_2 { get; set; }
        public int HoTen_3 { get; set; }
        public int NamSinh_1 { get; set; }
        public int NamSinh_2 { get; set; }
        public int NamSinh_3 { get; set; }
        public int GioiTinh_1 { get; set; }
        public int GioiTinh_2 { get; set; }
        public int GioiTinh_3 { get; set; }
        public int DiaChi_1 { get; set; }
        public int DiaChi_2 { get; set; }
        public int DiaChi_3 { get; set; }
        public string NguoiThucHien1 { get; set; }
        public string MaNguoiThucHien1 { get; set; }
        public string NguoiThucHien2 { get; set; }
        public string MaNguoiThucHien2 { get; set; }
        public string NguoiThucHien3 { get; set; }
        public string MaNguoiThucHien3 { get; set; }
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
    public class PhieuYeuCauXetNghiemFunc
    {
        public const string TableName = "PhieuYeuCauXetNghiem";
        public const string TablePrimaryKeyName = "ID";
        public static List<PhieuYeuCauXetNghiem> GetListData(MDB.MDBConnection _OracleConnection, decimal maquanly)
        {
            List<PhieuYeuCauXetNghiem> list = new List<PhieuYeuCauXetNghiem>();
            try
            {
                string sql = @"SELECT * FROM PhieuYeuCauXetNghiem where MaQuanLy = :MaQuanLy";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, _OracleConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", maquanly));
                MDB.MDBDataReader DataReader = Command.ExecuteReader();
                while (DataReader.Read())
                {
                    PhieuYeuCauXetNghiem data = new PhieuYeuCauXetNghiem();
                    data.ID = Convert.ToInt64(DataReader.GetLong("ID").ToString());
                    data.MaQuanLy = maquanly;
                    data.HoTen_1 = DataReader.GetInt("HoTen_1");
                    data.HoTen_2 = DataReader.GetInt("HoTen_2");
                    data.HoTen_3 = DataReader.GetInt("HoTen_3");
                    data.NamSinh_1 = DataReader.GetInt("NamSinh_1");
                    data.NamSinh_2 = DataReader.GetInt("NamSinh_2");
                    data.NamSinh_3 = DataReader.GetInt("NamSinh_3");
                    data.GioiTinh_1 = DataReader.GetInt("GioiTinh_1");
                    data.GioiTinh_2 = DataReader.GetInt("GioiTinh_2");
                    data.GioiTinh_3 = DataReader.GetInt("GioiTinh_3");
                    data.DiaChi_1 = DataReader.GetInt("DiaChi_1");
                    data.DiaChi_2 = DataReader.GetInt("DiaChi_2");
                    data.DiaChi_3 = DataReader.GetInt("DiaChi_3");
                    data.NguoiThucHien1 = DataReader["NguoiThucHien1"].ToString();
                    data.MaNguoiThucHien1 = DataReader["MaNguoiThucHien1"].ToString();
                    data.NguoiThucHien2 = DataReader["NguoiThucHien2"].ToString();
                    data.MaNguoiThucHien2 = DataReader["MaNguoiThucHien2"].ToString();
                    data.NguoiThucHien3 = DataReader["NguoiThucHien3"].ToString();
                    data.MaNguoiThucHien3 = DataReader["MaNguoiThucHien3"].ToString();

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
        public static bool InsertOrUpdate(MDB.MDBConnection MyConnection, ref PhieuYeuCauXetNghiem bangTheoDoi)
        {
            try
            {
                string sql = @"INSERT INTO PhieuYeuCauXetNghiem
                (
                    MAQUANLY,
                    HoTen_1,
                    HoTen_2,
                    HoTen_3,
                    NamSinh_1,
                    NamSinh_2,
                    NamSinh_3,
                    GioiTinh_1,
                    GioiTinh_2,
                    GioiTinh_3,
                    DiaChi_1,
                    DiaChi_2,
                    DiaChi_3,
                    MaNguoiThucHien1,
                    MaNguoiThucHien2,
                    MaNguoiThucHien3,
                    NguoiThucHien1,
                    NguoiThucHien2,
                    NguoiThucHien3,
                    NGUOITAO,
                    NGUOISUA,
                    NGAYTAO,
                    NGAYSUA)  VALUES
                 (
                    :MAQUANLY,
                    :HoTen_1,
                    :HoTen_2,
                    :HoTen_3,
                    :NamSinh_1,
                    :NamSinh_2,
                    :NamSinh_3,
                    :GioiTinh_1,
                    :GioiTinh_2,
                    :GioiTinh_3,
                    :DiaChi_1,
                    :DiaChi_2,
                    :DiaChi_3,
                    :MaNguoiThucHien1,
                    :MaNguoiThucHien2,
                    :MaNguoiThucHien3,
                    :NguoiThucHien1,
                    :NguoiThucHien2,
                    :NguoiThucHien3,
                    :NGUOITAO,
                    :NGUOISUA,
                    :NGAYTAO,
                    :NGAYSUA
                 )  RETURNING ID INTO :ID";
                if (bangTheoDoi.ID != 0)
                {
                    sql = @"UPDATE PhieuYeuCauXetNghiem SET 
                    MAQUANLY = :MAQUANLY,
                    HoTen_1 = :HoTen_1,
                    HoTen_2 = :HoTen_2,
                    HoTen_3 = :HoTen_3,
                    NamSinh_1 = :NamSinh_1,
                    NamSinh_2 = :NamSinh_2,
                    NamSinh_3 = :NamSinh_3,
                    GioiTinh_1 = :GioiTinh_1,
                    GioiTinh_2 = :GioiTinh_2,
                    GioiTinh_3 = :GioiTinh_3,
                    DiaChi_1 = :DiaChi_1,
                    DiaChi_2 = :DiaChi_2,
                    DiaChi_3 = :DiaChi_3,
                    MaNguoiThucHien1 = :MaNguoiThucHien1,
                    MaNguoiThucHien2 = :MaNguoiThucHien2,
                    MaNguoiThucHien3 = :MaNguoiThucHien3,
                    NguoiThucHien1 = :NguoiThucHien1,
                    NguoiThucHien2 = :NguoiThucHien2,
                    NguoiThucHien3 = :NguoiThucHien3,
                    NGUOISUA = :NGUOISUA,
                    NGAYSUA = :NGAYSUA
                    WHERE ID = " + bangTheoDoi.ID;
                }
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MAQUANLY", bangTheoDoi.MaQuanLy));
                Command.Parameters.Add(new MDB.MDBParameter("HoTen_1", bangTheoDoi.HoTen_1));
                Command.Parameters.Add(new MDB.MDBParameter("HoTen_2", bangTheoDoi.HoTen_2));
                Command.Parameters.Add(new MDB.MDBParameter("HoTen_3", bangTheoDoi.HoTen_3));
                Command.Parameters.Add(new MDB.MDBParameter("NamSinh_1", bangTheoDoi.NamSinh_1));
                Command.Parameters.Add(new MDB.MDBParameter("NamSinh_2", bangTheoDoi.NamSinh_2));
                Command.Parameters.Add(new MDB.MDBParameter("NamSinh_3", bangTheoDoi.NamSinh_3));
                Command.Parameters.Add(new MDB.MDBParameter("GioiTinh_1", bangTheoDoi.GioiTinh_1));
                Command.Parameters.Add(new MDB.MDBParameter("GioiTinh_2", bangTheoDoi.GioiTinh_2));
                Command.Parameters.Add(new MDB.MDBParameter("GioiTinh_3", bangTheoDoi.GioiTinh_3));
                Command.Parameters.Add(new MDB.MDBParameter("DiaChi_1", bangTheoDoi.DiaChi_1));
                Command.Parameters.Add(new MDB.MDBParameter("DiaChi_2", bangTheoDoi.DiaChi_2));
                Command.Parameters.Add(new MDB.MDBParameter("DiaChi_3", bangTheoDoi.DiaChi_3));
                Command.Parameters.Add(new MDB.MDBParameter("NguoiThucHien1", bangTheoDoi.NguoiThucHien1));
                Command.Parameters.Add(new MDB.MDBParameter("NguoiThucHien2", bangTheoDoi.NguoiThucHien2));
                Command.Parameters.Add(new MDB.MDBParameter("NguoiThucHien3", bangTheoDoi.NguoiThucHien3));
                Command.Parameters.Add(new MDB.MDBParameter("MaNguoiThucHien1", bangTheoDoi.MaNguoiThucHien1));
                Command.Parameters.Add(new MDB.MDBParameter("MaNguoiThucHien2", bangTheoDoi.MaNguoiThucHien2));
                Command.Parameters.Add(new MDB.MDBParameter("MaNguoiThucHien3", bangTheoDoi.MaNguoiThucHien3));
                
                Command.Parameters.Add(new MDB.MDBParameter("NGUOISUA", bangTheoDoi.NguoiSua));
                Command.Parameters.Add(new MDB.MDBParameter("NGAYSUA", bangTheoDoi.NgaySua));
                if (bangTheoDoi.ID == 0)
                {
                    Command.Parameters.Add(new MDB.MDBParameter("ID", bangTheoDoi.ID));
                    Command.Parameters.Add(new MDB.MDBParameter("NGUOITAO", bangTheoDoi.NguoiTao));
                    Command.Parameters.Add(new MDB.MDBParameter("NGAYTAO", bangTheoDoi.NgayTao));
                }
                Command.BindByName = true;
                int n = Command.ExecuteNonQuery();
                if (bangTheoDoi.ID == 0)
                {
                    long nextval = Convert.ToInt64((Command.Parameters["ID"] as MDB.MDBParameter).Value);
                    bangTheoDoi.ID = nextval;
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
                string sql = "DELETE FROM PhieuYeuCauXetNghiem WHERE ID = :ID";
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
            string sql = @"SELECT *
            FROM
                PhieuYeuCauXetNghiem B
            WHERE
                ID = " + id;

            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
            MDB.MDBDataAdapter adt = new MDB.MDBDataAdapter(Command);
            var ds = new DataSet();

            adt.Fill(ds, "Table");

            return ds;
        }
    }
}
