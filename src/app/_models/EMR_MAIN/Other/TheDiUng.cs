using EMR.KyDienTu;
using Newtonsoft.Json;
using PMS.Access;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Linq;

namespace EMR_MAIN.DATABASE.Other
{
    public class TheDiUng : ThongTinKy
    {
        public TheDiUng()
        {
            TableName = "TheDiUng";
            TablePrimaryKeyName = "ID";
            IDMauPhieu = (int)DanhMucPhieu.TDU;
            TenMauPhieu = DanhMucPhieu.TDU.Description();
        }
        [MoTaDuLieu("Mã định danh")]
		public long ID { get; set; }
        [MoTaDuLieu("Mã quản lý: mã duy nhất trong 1 đợt khám chữa bệnh (kcb), không trùng giữa các đợt kcb khác nhau","",1)]
		public decimal MaQuanLy { get; set; }
        [MoTaDuLieu("Mã bệnh nhân")]
		public string MaBenhNhan { get; set; }
        [MoTaDuLieu("Khoa")]
		public string Khoa { get; set; }
        [MoTaDuLieu("Mã khoa")]
		public string MaKhoa { get; set; }
        public string HoTenBenhNhan { get; set; }
        [MoTaDuLieu("Tuổi bệnh nhân")]
		public string Tuoi { get; set; }
        [MoTaDuLieu("Giới tính bệnh nhân")]
		public string GioiTinh { get; set; }
        public string SoCMND { get; set; }
        public ObservableCollection<DataDiUng> Datas { get; set; }
        [MoTaDuLieu("Bác sỹ")]
		public string BacSy { get; set; }
        [MoTaDuLieu("Mã bác sỹ")]
		public string MaBacSy { get; set; }
        public string SDT { get; set; }
        public DateTime? NgayCapThe { get; set; }
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
    public class DataDiUng
    {
        public string Thuoc { get; set; }
        public bool NghiNgo { get; set; }
        public bool ChacChan { get; set; }
        public string BieuHien { get; set; }
    }  
    public class TheDiUngFunc
    {

        public const string TableName = "TheDiUng";
        public const string TablePrimaryKeyName = "ID";
        public static List<TheDiUng> GetListData(MDB.MDBConnection _OracleConnection, decimal maquanly)
        {
            List<TheDiUng> list = new List<TheDiUng>();
            try
            {
                string sql = @"SELECT * FROM TheDiUng where MaQuanLy = :MaQuanLy";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, _OracleConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", maquanly));
                MDB.MDBDataReader DataReader = Command.ExecuteReader();
                while (DataReader.Read())
                {
                    TheDiUng data = new TheDiUng();
                    data.ID = DataReader.GetLong("ID");
                    data.MaQuanLy = maquanly;
                    data.MaBenhNhan = DataReader["MaBenhNhan"].ToString();
                    data.HoTenBenhNhan = XemBenhAn._HanhChinhBenhNhan.TenBenhNhan;
                    data.Tuoi = XemBenhAn._HanhChinhBenhNhan.Tuoi;
                    data.GioiTinh = XemBenhAn._HanhChinhBenhNhan.GioiTinh.Description();
                    data.Khoa = DataReader["Khoa"].ToString();
                    data.MaKhoa = DataReader["MaKhoa"].ToString();
                    data.SoCMND = DataReader["SoCMND"].ToString();
                    data.Datas = JsonConvert.DeserializeObject<ObservableCollection<DataDiUng>>(DataReader["Datas"].ToString());
                    data.BacSy = DataReader["BacSy"].ToString();
                    data.MaBacSy = DataReader["MaBacSy"].ToString();
                    data.SDT = DataReader["SDT"].ToString();
                    data.NgayCapThe = DataReader["NgayCapThe"] != DBNull.Value ? (DateTime?) Convert.ToDateTime(DataReader["NgayCapThe"]) : null;

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
        public static bool InsertOrUpdate(MDB.MDBConnection MyConnection, ref TheDiUng phieu)
        {
            try
            {
                string sql = @"INSERT INTO TheDiUng
                (
                    MAQUANLY,
                    MaBenhNhan,
                    Khoa,
                    MaKhoa,
                    SoCMND,
                    Datas,
                    BacSy,
                    MaBacSy,
                    SDT,
                    NgayCapThe,
                    NGUOITAO,
                    NGUOISUA,
                    NGAYTAO,
                    NGAYSUA)  VALUES
                 (
				    :MAQUANLY,
                    :MaBenhNhan,
                    :Khoa,
                    :MaKhoa,
                    :SoCMND,
                    :Datas,
                    :BacSy,
                    :MaBacSy,
                    :SDT,
                    :NgayCapThe,
                    :NGUOITAO,
                    :NGUOISUA,
                    :NGAYTAO,
                    :NGAYSUA
                 )  RETURNING ID INTO :ID";
                if (phieu.ID != 0)
                {
                    sql = @"UPDATE TheDiUng SET 
                    MAQUANLY = :MAQUANLY,
                    MaBenhNhan = :MaBenhNhan,
                    Khoa = :Khoa,
                    MaKhoa = :MaKhoa,
                    SoCMND = :SoCMND,
                    Datas = :Datas,
                    BacSy = :BacSy,
                    MaBacSy = :MaBacSy,
                    SDT = :SDT,
                    NgayCapThe = :NgayCapThe,
                    NGUOISUA = :NGUOISUA,
                    NGAYSUA = :NGAYSUA
                    WHERE ID = " + phieu.ID;
                }
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MAQUANLY", phieu.MaQuanLy));
                Command.Parameters.Add(new MDB.MDBParameter("MaBenhNhan", phieu.MaBenhNhan));
                Command.Parameters.Add(new MDB.MDBParameter("Khoa", phieu.Khoa));
                Command.Parameters.Add(new MDB.MDBParameter("MaKhoa", phieu.MaKhoa));
                Command.Parameters.Add(new MDB.MDBParameter("SoCMND", phieu.SoCMND));
                Command.Parameters.Add(new MDB.MDBParameter("Datas", JsonConvert.SerializeObject(phieu.Datas)));
                Command.Parameters.Add(new MDB.MDBParameter("BacSy", phieu.BacSy));
                Command.Parameters.Add(new MDB.MDBParameter("MaBacSy", phieu.MaBacSy));
                Command.Parameters.Add(new MDB.MDBParameter("SDT", phieu.SDT));
                Command.Parameters.Add(new MDB.MDBParameter("NgayCapThe", phieu.NgayCapThe));
                Command.Parameters.Add(new MDB.MDBParameter("NGUOISUA", phieu.NguoiSua));
                Command.Parameters.Add(new MDB.MDBParameter("NGAYSUA", phieu.NgaySua));
                if (phieu.ID == 0)
                {
                    Command.Parameters.Add(new MDB.MDBParameter("ID", phieu.ID));
                    Command.Parameters.Add(new MDB.MDBParameter("NGUOITAO", phieu.NguoiTao));
                    Command.Parameters.Add(new MDB.MDBParameter("NGAYTAO", phieu.NgayTao));
                }
                Command.BindByName = true;
                int n = Command.ExecuteNonQuery();
                if (phieu.ID == 0)
                {
                    long nextval = Convert.ToInt64((Command.Parameters["ID"] as MDB.MDBParameter).Value);
                    phieu.ID = nextval;
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
                string sql = "DELETE FROM TheDiUng WHERE ID = :ID";
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
                B.MAQUANLY,
                B.MaBenhNhan,
                B.Khoa,
                B.SoCMND,
                B.BacSy,
                B.MaBacSy,
                B.SDT,
                B.NgayCapThe
            FROM
                TheDiUng B
            WHERE
                ID = " + id;

            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
            MDB.MDBDataAdapter adt = new MDB.MDBDataAdapter(Command);
            var ds = new DataSet();

            adt.Fill(ds, "BK");

            ds.Tables[0].AddColumn("TenBenhNhan", typeof(string));
            ds.Tables[0].AddColumn("Tuoi", typeof(string));
            ds.Tables[0].AddColumn("GioiTinh", typeof(string));
            ds.Tables[0].AddColumn("SOYTE", typeof(string));
            ds.Tables[0].AddColumn("BENHVIEN", typeof(string));
            ds.Tables[0].AddColumn("KHOA", typeof(string));

            ds.Tables[0].Rows[0]["TenBenhNhan"] = XemBenhAn._HanhChinhBenhNhan.TenBenhNhan;
            ds.Tables[0].Rows[0]["Tuoi"] = XemBenhAn._HanhChinhBenhNhan.Tuoi;
            ds.Tables[0].Rows[0]["GioiTinh"] = XemBenhAn._HanhChinhBenhNhan.GioiTinh.Description();
            ds.Tables[0].Rows[0]["SOYTE"] = XemBenhAn._HanhChinhBenhNhan.SoYTe;
            ds.Tables[0].Rows[0]["BENHVIEN"] = XemBenhAn._HanhChinhBenhNhan.BenhVien;
            ds.Tables[0].Rows[0]["KHOA"] = XemBenhAn._ThongTinDieuTri.Khoa;


            sql = @"SELECT
               B.Datas 
            FROM
                TheDiUng B
                
            WHERE
                ID = " + id;

            Command = new MDB.MDBCommand(sql, MyConnection);
            MDB.MDBDataReader DataReader = Command.ExecuteReader();

            List<DataDiUng> saveDatas = new List<DataDiUng>();
            while (DataReader.Read())
            {
                string bangKeJson = DataReader["Datas"].ToString();
                saveDatas = JsonConvert.DeserializeObject<List<DataDiUng>>(bangKeJson).ToList();
                break;
            }

            DataTable ChiTiet = new DataTable("KQ");
            ChiTiet.Columns.Add("Thuoc", typeof(string));
            ChiTiet.Columns.Add("NghiNgo", typeof(int));
            ChiTiet.Columns.Add("ChacChan", typeof(int));
            ChiTiet.Columns.Add("BieuHien", typeof(string));
            
            foreach (DataDiUng chiTiet in saveDatas)
            {
                ChiTiet.Rows.Add
                (
                    chiTiet.Thuoc,
                    chiTiet.NghiNgo ? 1: 0,
                    chiTiet.ChacChan ? 1: 0,
                    chiTiet.BieuHien
                ); ;

            }
            ds.Tables.Add(ChiTiet);
            return ds;

        }
    }

}
