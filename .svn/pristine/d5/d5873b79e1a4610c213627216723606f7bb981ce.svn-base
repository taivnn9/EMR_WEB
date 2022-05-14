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
    public class PXNBNKCMTKP : ThongTinKy
    {
        public PXNBNKCMTKP()
        {
            TableName = "PXNBNKCMTKP";
            TablePrimaryKeyName = "ID";
            IDMauPhieu = (int)DanhMucPhieu.PXNBNKCMTKP;
            TenMauPhieu = DanhMucPhieu.PXNBNKCMTKP.Description();
        }
        [MoTaDuLieu("Mã định danh")]
		public long ID { get; set; }
        [MoTaDuLieu("Mã quản lý: mã duy nhất trong 1 đợt khám chữa bệnh (kcb), không trùng giữa các đợt kcb khác nhau","",1)]
		public decimal MaQuanLy { get; set; }
        public string HoTenBenhNhan { get; set; }
        [MoTaDuLieu("Năm sinh")]
		public string NamSinh { get; set; }
        [MoTaDuLieu("Địa chỉ nhà bệnh nhân")]
		public string DiaChi { get; set; }
        [MoTaDuLieu("Giới tính bệnh nhân")]
		public string GioiTinh { get; set; }
        [MoTaDuLieu("Khoa")]
		public string Khoa { get; set; }
        [MoTaDuLieu("Giường")]
		public string Giuong { get; set; }
        [MoTaDuLieu("Buồng")]
		public string Buong { get; set; }
        [MoTaDuLieu("Ngày vào bệnh viện")]
		public DateTime NgayVaoVien { get; set; }
        [MoTaDuLieu("Chẩn đoán bệnh")]
		public string ChanDoan { get; set; }
        public string NoiDung { get; set; }
        public DateTime ThoiGian { get; set; }
        public DateTime ThoiGianBatDau { get; set; }
        public DateTime ThoiGianKetThuc { get; set; }
        [MoTaDuLieu("Họ tên điều dưỡng")]
		public string DieuDuong { get; set; }
        [MoTaDuLieu("Mã điều dưỡng")]
		public string MaDieuDuong { get; set; }
        [MoTaDuLieu("Bác sỹ")]
		public string BacSy { get; set; }
        [MoTaDuLieu("Mã bác sỹ")]
		public string MaBacSy { get; set; }

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
    public class PXNBNKCMTKPFunc
    {
        public const string TableName = "PXNBNKCMTKP";
        public const string TablePrimaryKeyName = "ID";
        public static List<PXNBNKCMTKP> GetListData(MDB.MDBConnection _OracleConnection, decimal maquanly)
        {
            List<PXNBNKCMTKP> list = new List<PXNBNKCMTKP>();
            try
            {
                string sql = @"SELECT * FROM PXNBNKCMTKP where MaQuanLy = :MaQuanLy";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, _OracleConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", maquanly));
                MDB.MDBDataReader DataReader = Command.ExecuteReader();
                while (DataReader.Read())
                {
                    PXNBNKCMTKP data = new PXNBNKCMTKP();
                    data.ID = Convert.ToInt64(DataReader.GetLong("ID").ToString());
                    data.MaQuanLy = maquanly;
                    data.HoTenBenhNhan = XemBenhAn._HanhChinhBenhNhan.TenBenhNhan;
                    try
                    {
                        data.NamSinh = XemBenhAn._HanhChinhBenhNhan.NgaySinh.Value.Year + "";
                    }
                    catch { }
                    data.GioiTinh = XemBenhAn._HanhChinhBenhNhan.GioiTinh.Description();
                    data.DiaChi = Common.GetDiaChi();
                    data.Khoa = XemBenhAn._ThongTinDieuTri.Khoa;
                    data.Giuong = DataReader["Giuong"].ToString();
                    data.Buong = DataReader["Buong"].ToString();
                    data.NgayVaoVien = Convert.ToDateTime(DataReader["NgayVaoVien"] == DBNull.Value ? DateTime.Now : DataReader["NgayVaoVien"]);
                    data.NoiDung = DataReader["NoiDung"].ToString();
                    data.ChanDoan = DataReader["ChanDoan"].ToString();
                    data.ThoiGian = Common.ConDB_DateTime(DataReader["ThoiGian"]);
                    data.ThoiGianBatDau = Common.ConDB_DateTime(DataReader["TThoiGianBatDau"]);
                    data.ThoiGianKetThuc = Common.ConDB_DateTime(DataReader["ThoiGianKetThuc"]);
                    data.DieuDuong = DataReader["DieuDuong"].ToString();
                    data.MaDieuDuong = DataReader["MaDieuDuong"].ToString();
                    data.BacSy = DataReader["BacSy"].ToString();
                    data.MaBacSy = DataReader["MaBacSy"].ToString();

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
        public static bool InsertOrUpdate(MDB.MDBConnection MyConnection, ref PXNBNKCMTKP data)
        {
            try
            {
                string sql = @"INSERT INTO PXNBNKCMTKP
                (
                    MAQUANLY,
                    Giuong,
                    Buong,
                    NgayVaoVien,
                    ChanDoan,
                    NoiDung,
                    ThoiGian,
                    ThoiGianBatDau,
                    ThoiGianKetThuc,
                    DieuDuong,
                    MaDieuDuong,
                    BacSy,
                    MaBacSy,
                    NGUOITAO,
                    NGUOISUA,
                    NGAYTAO,
                    NGAYSUA)  VALUES
                 (
				    :MAQUANLY,
                    :Giuong,
                    :Buong,
                    :NgayVaoVien,
                    :ChanDoan,
                    :NoiDung,
                    :ThoiGian,
                    :ThoiGianBatDau,
                    :ThoiGianKetThuc,
                    :DieuDuong,
                    :MaDieuDuong,
                    :BacSy,
                    :MaBacSy,
                    :NGUOITAO,
                    :NGUOISUA,
                    :NGAYTAO,
                    :NGAYSUA
                 )  RETURNING ID INTO :ID";
                if (data.ID != 0)
                {
                    sql = @"UPDATE PXNBNKCMTKP SET 
                    MAQUANLY = :MAQUANLY,
                    Giuong=:Giuong,
                    Buong=:Buong,
                    NgayVaoVien=:NgayVaoVien,
                    ChanDoan=:ChanDoan,
                    NoiDung=:NoiDung,
                    ThoiGian=:ThoiGian,
                    ThoiGianBatDau=:ThoiGianBatDau,
                    ThoiGianKetThuc=:ThoiGianKetThuc,
                    DieuDuong=:DieuDuong,
                    MaDieuDuong=:MaDieuDuong,
                    BacSy=:BacSy,
                    MaBacSy=:MaBacSy,
                    NGUOISUA = :NGUOISUA,
                    NGAYSUA = :NGAYSUA
                    WHERE ID = " + data.ID;
                }
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MAQUANLY", data.MaQuanLy));
                Command.Parameters.Add(new MDB.MDBParameter("Giuong", data.Giuong));
                Command.Parameters.Add(new MDB.MDBParameter("Buong", data.Buong));
                Command.Parameters.Add(new MDB.MDBParameter("NgayVaoVien", data.NgayVaoVien));
                Command.Parameters.Add(new MDB.MDBParameter("ChanDoan", data.ChanDoan));
                Command.Parameters.Add(new MDB.MDBParameter("NoiDung", data.NoiDung));
                Command.Parameters.Add(new MDB.MDBParameter("ThoiGian", data.ThoiGian));
                Command.Parameters.Add(new MDB.MDBParameter("ThoiGianBatDau", data.ThoiGianBatDau));
                Command.Parameters.Add(new MDB.MDBParameter("ThoiGianKetThuc", data.ThoiGianKetThuc));
                Command.Parameters.Add(new MDB.MDBParameter("DieuDuong", data.DieuDuong));
                Command.Parameters.Add(new MDB.MDBParameter("MaDieuDuong", data.MaDieuDuong));
                Command.Parameters.Add(new MDB.MDBParameter("BacSy", data.BacSy));
                Command.Parameters.Add(new MDB.MDBParameter("MaBacSy", data.MaBacSy));

                Command.Parameters.Add(new MDB.MDBParameter("NGUOISUA", data.NguoiSua));
                Command.Parameters.Add(new MDB.MDBParameter("NGAYSUA", data.NgaySua));
                if (data.ID == 0)
                {
                    Command.Parameters.Add(new MDB.MDBParameter("ID", data.ID));
                    Command.Parameters.Add(new MDB.MDBParameter("NGUOITAO", data.NguoiTao));
                    Command.Parameters.Add(new MDB.MDBParameter("NGAYTAO", data.NgayTao));
                }
                Command.BindByName = true;
                int n = Command.ExecuteNonQuery();
                if (data.ID == 0)
                {
                    long nextval = Convert.ToInt64((Command.Parameters["ID"] as MDB.MDBParameter).Value);
                    data.ID = nextval;
                }
                return n > 0;
            }
            catch (Exception ex)
            {
                XuLyLoi.Handle(ex);
            }
            return false;
        }
        public static bool Delete(MDB.MDBConnection MyConnection, long id)
        {
            try
            {
                string sql = "DELETE FROM PXNBNKCMTKP WHERE ID = :ID";
                MDB.MDBCommand command = new MDB.MDBCommand(sql, MyConnection);
                command.Parameters.Add(new MDB.MDBParameter("ID", id));
                command.BindByName = true;
                int n = command.ExecuteNonQuery();
                return n > 0;
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
                PXNBNKCMTKP B
            WHERE
                ID = " + id;

            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
            MDB.MDBDataAdapter adt = new MDB.MDBDataAdapter(Command);

            var ds = new DataSet();

            adt.Fill(ds, "TB");
            ds.Tables[0].AddColumn("TenBenhNhan", typeof(string));
            ds.Tables[0].AddColumn("NamSinh", typeof(string));
            ds.Tables[0].AddColumn("GioiTinh", typeof(string));
            ds.Tables[0].AddColumn("DiaChi", typeof(string));
            ds.Tables[0].AddColumn("Khoa", typeof(string));
            ds.Tables[0].AddColumn("SoYTe", typeof(string));
            ds.Tables[0].AddColumn("BenhVien", typeof(string));

            ds.Tables[0].Rows[0]["TenBenhNhan"] = XemBenhAn._HanhChinhBenhNhan.TenBenhNhan;
            ds.Tables[0].Rows[0]["NamSinh"] = XemBenhAn._HanhChinhBenhNhan.NgaySinh!=null ? XemBenhAn._HanhChinhBenhNhan.NgaySinh.Value.Year + "" : "";
            ds.Tables[0].Rows[0]["GioiTinh"] = XemBenhAn._HanhChinhBenhNhan.GioiTinh.Description();
            ds.Tables[0].Rows[0]["DiaChi"] = Common.GetDiaChi();
            ds.Tables[0].Rows[0]["Khoa"] = XemBenhAn._ThongTinDieuTri.Khoa;
            ds.Tables[0].Rows[0]["SoYTe"] = XemBenhAn._HanhChinhBenhNhan.SoYTe;
            ds.Tables[0].Rows[0]["BenhVien"] = XemBenhAn._HanhChinhBenhNhan.BenhVien;

            return ds;
        }
    }
}
