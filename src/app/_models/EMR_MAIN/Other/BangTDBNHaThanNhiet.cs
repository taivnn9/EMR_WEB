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
    public class TheoDoiHaNhiet
    {
        [MoTaDuLieu("Giờ")]
        public string Gio { get; set; }
        [MoTaDuLieu("Giờ thực tế")]
        public DateTime? GioThucTe { get; set; }
        [MoTaDuLieu("Mạch")]
		public string Mach { get; set; }
        [MoTaDuLieu("Huyết áp")]
		public string HA { get; set; }
        [MoTaDuLieu("V.mạch")]
        public string VMach { get; set; }
        [MoTaDuLieu("Nhiệt độ")]
        public string T { get; set; }
        [MoTaDuLieu("Nồng độ Oxy trong máu")]
		public string SpO2 { get; set; }
        [MoTaDuLieu("FiO2")]
        public string FiO2 { get; set; }
        [MoTaDuLieu("Nước tiểu")]
		public string NuocTieu { get; set; }
        [MoTaDuLieu("Rét run")]
        public string RetRun { get; set; }
    }
    public class BangTDBNHaThanNhiet : ThongTinKy
    {
        public BangTDBNHaThanNhiet()
        {
            TableName = "BangTDBNHaThanNhiet";
            TablePrimaryKeyName = "ID";
            IDMauPhieu = (int)DanhMucPhieu.BTDBNHTN;
            TenMauPhieu = DanhMucPhieu.BTDBNHTN.Description();
        }
        [MoTaDuLieu("Mã định danh")]
		public long ID { get; set; }
        [MoTaDuLieu("Mã quản lý: mã duy nhất trong 1 đợt khám chữa bệnh (kcb), không trùng giữa các đợt kcb khác nhau","",1)]
		public decimal MaQuanLy { get; set; }
        [MoTaDuLieu("Họ và tên bệnh nhân")] 
        public string HoTenBenhNhan { get; set; }
        [MoTaDuLieu("Tuổi bệnh nhân")]
		public string Tuoi { get; set; }
        [MoTaDuLieu("Giới tính bệnh nhân")]
		public string GioiTinh { get; set; }
        [MoTaDuLieu("Thời gian bắt đầu hạ nhiệt")]
        public DateTime ThoiGian { get; set; }
        [MoTaDuLieu("Thời gian khi đạt 33 độ C")]
        public string ThoiGianDat33 { get; set; }
        [MoTaDuLieu("Thời gian bắt đầu làm ấm lên 37 độ C")]
        public string ThoiGianBD37 { get; set; }
        [MoTaDuLieu("Thời gian khi đạt 37 độ C")]
        public string ThoiGianDat37 { get; set; }

        [MoTaDuLieu("Thông tin theo dõi hạ nhiệt khi bắt đầu hạ nhiệt")]
        public ObservableCollection<TheoDoiHaNhiet> TheoDoi1 { get; set; }
        [MoTaDuLieu("Thông tin theo dõi hạ nhiệt khi bắt đầu đạt 33 độ C")]
        public ObservableCollection<TheoDoiHaNhiet> TheoDoi2 { get; set; }
        [MoTaDuLieu("Thông tin theo dõi hạ nhiệt khi bắt đầu ấm lên 37 độ C")]
        public ObservableCollection<TheoDoiHaNhiet> TheoDoi3 { get; set; }
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
    public class BangTDBNHaThanNhietFunc
    {
        public const string TableName = "BangTDBNHaThanNhiet";
        public const string TablePrimaryKeyName = "ID";
        public static List<BangTDBNHaThanNhiet> GetListData(MDB.MDBConnection _OracleConnection, decimal maquanly)
        {
            List<BangTDBNHaThanNhiet> list = new List<BangTDBNHaThanNhiet>();
            try
            {
                string sql = @"SELECT * FROM BangTDBNHaThanNhiet where MaQuanLy = :MaQuanLy";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, _OracleConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", maquanly));
                MDB.MDBDataReader DataReader = Command.ExecuteReader();
                while (DataReader.Read())
                {
                    BangTDBNHaThanNhiet data = new BangTDBNHaThanNhiet();
                    data.ID = Convert.ToInt64(DataReader.GetLong("ID").ToString());
                    data.MaQuanLy = maquanly;
                    data.HoTenBenhNhan = XemBenhAn._HanhChinhBenhNhan.TenBenhNhan;
                    data.Tuoi = XemBenhAn._HanhChinhBenhNhan.Tuoi;
                    data.GioiTinh = XemBenhAn._HanhChinhBenhNhan.GioiTinh.Description();
                    data.ThoiGian = Convert.ToDateTime(DataReader["ThoiGian"] == DBNull.Value ? DateTime.Now : DataReader["ThoiGian"]);

                    data.ThoiGianDat33 = DataReader["ThoiGianDat33"].ToString();
                    data.ThoiGianBD37 = DataReader["ThoiGianBD37"].ToString();
                    data.ThoiGianDat37 = DataReader["ThoiGianDat37"].ToString();

                    data.TheoDoi1 = JsonConvert.DeserializeObject<ObservableCollection<TheoDoiHaNhiet>>(DataReader["TheoDoi1"].ToString());
                    data.TheoDoi2 = JsonConvert.DeserializeObject<ObservableCollection<TheoDoiHaNhiet>>(DataReader["TheoDoi2"].ToString());
                    data.TheoDoi3 = JsonConvert.DeserializeObject<ObservableCollection<TheoDoiHaNhiet>>(DataReader["TheoDoi3"].ToString());

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
        public static bool InsertOrUpdate(MDB.MDBConnection MyConnection, ref BangTDBNHaThanNhiet bangKe)
        {
            try
            {
                string sql = @"INSERT INTO BangTDBNHaThanNhiet
                (
                    MAQUANLY,
                    ThoiGian,
                    ThoiGianDat33,
                    ThoiGianBD37,
                    ThoiGianDat37,
                    TheoDoi1,
                    TheoDoi2,
                    TheoDoi3,
                    NGUOITAO,
                    NGUOISUA,
                    NGAYTAO,
                    NGAYSUA)  VALUES
                 (
				    :MAQUANLY,
                    :ThoiGian,
                    :ThoiGianDat33,
                    :ThoiGianBD37,
                    :ThoiGianDat37,
                    :TheoDoi1,
                    :TheoDoi2,
                    :TheoDoi3,
                    :NGUOITAO,
                    :NGUOISUA,
                    :NGAYTAO,
                    :NGAYSUA
                 )  RETURNING ID INTO :ID";
                if (bangKe.ID != 0)
                {
                    sql = @"UPDATE BangTDBNHaThanNhiet SET 
                    MAQUANLY = :MAQUANLY,
                    ThoiGian = :ThoiGian,
                    ThoiGianDat33 = :ThoiGianDat33,
                    ThoiGianBD37 = :ThoiGianBD37,
                    ThoiGianDat37 = :ThoiGianDat37,
                    TheoDoi1 = :TheoDoi1,
                    TheoDoi2 = :TheoDoi2,
                    TheoDoi3 = :TheoDoi3,
                    NGUOISUA = :NGUOISUA,
                    NGAYSUA = :NGAYSUA
                    WHERE ID = " + bangKe.ID;
                }
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MAQUANLY", bangKe.MaQuanLy));
                Command.Parameters.Add(new MDB.MDBParameter("ThoiGian", bangKe.ThoiGian));
                Command.Parameters.Add(new MDB.MDBParameter("ThoiGianDat33", bangKe.ThoiGianDat33));
                Command.Parameters.Add(new MDB.MDBParameter("ThoiGianBD37", bangKe.ThoiGianBD37));
                Command.Parameters.Add(new MDB.MDBParameter("ThoiGianDat37", bangKe.ThoiGianDat37));
                Command.Parameters.Add(new MDB.MDBParameter("TheoDoi1", JsonConvert.SerializeObject(bangKe.TheoDoi1)));
                Command.Parameters.Add(new MDB.MDBParameter("TheoDoi2", JsonConvert.SerializeObject(bangKe.TheoDoi2)));
                Command.Parameters.Add(new MDB.MDBParameter("TheoDoi3", JsonConvert.SerializeObject(bangKe.TheoDoi3)));

                Command.Parameters.Add(new MDB.MDBParameter("NGUOISUA", bangKe.NguoiSua));
                Command.Parameters.Add(new MDB.MDBParameter("NGAYSUA", bangKe.NgaySua));
                if (bangKe.ID == 0)
                {
                    Command.Parameters.Add(new MDB.MDBParameter("ID", bangKe.ID));
                    Command.Parameters.Add(new MDB.MDBParameter("NGUOITAO", bangKe.NguoiTao));
                    Command.Parameters.Add(new MDB.MDBParameter("NGAYTAO", bangKe.NgayTao));
                }
                Command.BindByName = true;
                int n = Command.ExecuteNonQuery();
                if (bangKe.ID == 0)
                {
                    long nextval = Convert.ToInt64((Command.Parameters["ID"] as MDB.MDBParameter).Value);
                    bangKe.ID = nextval;
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
                string sql = "DELETE FROM BangTDBNHaThanNhiet WHERE ID = :ID";
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
                *
            FROM
                BangTDBNHaThanNhiet B
            WHERE
                ID = " + id;

            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
            MDB.MDBDataAdapter adt = new MDB.MDBDataAdapter(Command);

            var ds = new DataSet();

            adt.Fill(ds, "TB");
            ds.Tables[0].AddColumn("TenBenhNhan", typeof(string));
            ds.Tables[0].AddColumn("Tuoi", typeof(string));
            ds.Tables[0].AddColumn("GioiTinh", typeof(string));

            ds.Tables[0].Rows[0]["TenBenhNhan"] = XemBenhAn._HanhChinhBenhNhan.TenBenhNhan;
            ds.Tables[0].Rows[0]["Tuoi"] = XemBenhAn._HanhChinhBenhNhan.Tuoi;
            ds.Tables[0].Rows[0]["GioiTinh"] = XemBenhAn._HanhChinhBenhNhan.GioiTinh.Description();

            ObservableCollection<TheoDoiHaNhiet> TheoDoi1 = JsonConvert.DeserializeObject<ObservableCollection<TheoDoiHaNhiet>>(ds.Tables[0].Rows[0]["TheoDoi1"].ToString());
            ObservableCollection<TheoDoiHaNhiet> TheoDoi2 = JsonConvert.DeserializeObject<ObservableCollection<TheoDoiHaNhiet>>(ds.Tables[0].Rows[0]["TheoDoi2"].ToString());
            ObservableCollection<TheoDoiHaNhiet> TheoDoi3 = JsonConvert.DeserializeObject<ObservableCollection<TheoDoiHaNhiet>>(ds.Tables[0].Rows[0]["TheoDoi3"].ToString());

            DataTable TD1 = Common.ListToDataTable(TheoDoi1, "TD1");
            DataTable TD2 = Common.ListToDataTable(TheoDoi2, "TD2");
            DataTable TD3 = Common.ListToDataTable(TheoDoi3, "TD3");
            ds.Tables.Add(TD1);
            ds.Tables.Add(TD2);
            ds.Tables.Add(TD3);

            return ds;

        }
    }
}
