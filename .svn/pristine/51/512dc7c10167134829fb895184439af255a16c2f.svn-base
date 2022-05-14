using EMR.KyDienTu;
using MDB;
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
    public class KeHoachChamSocNguoiBenh : ThongTinKy
    {
        public KeHoachChamSocNguoiBenh()
        {
            TableName = "KeHoachChamSocNguoiBenh";
            TablePrimaryKeyName = "ID";
            IDMauPhieu = (int)DanhMucPhieu.KHCSNB;
            TenMauPhieu = DanhMucPhieu.KHCSNB.Description();
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
        public int? So { get; set; }
        public string HoVaTen { get; set; }
        [MoTaDuLieu("Tuổi bệnh nhân")]
		public string Tuoi { get; set; }
        [MoTaDuLieu("Giới tính bệnh nhân")]
		public string GioiTinh { get; set; }
        public DateTime? NgayVaoVien { get; set; }
        [MoTaDuLieu("Chẩn đoán bệnh")]
		public string ChanDoan { get; set; }
        [MoTaDuLieu("Buồng")]
		public string Buong { get; set; }
        [MoTaDuLieu("Giường")]
		public string Giuong { get; set; }
        public ObservableCollection<KeHoachChamSocNguoiBenh_ChiTiet> ChiTiets { get; set; }

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
    public class KeHoachChamSocNguoiBenh_ChiTiet
    {
        [MoTaDuLieu("Mã định danh")]
		public long ID { get; set; }
        [MoTaDuLieu("Mã định danh")]
		public long ID_Phieu { get; set; }
        public DateTime Ngay { get; set; }
        public DateTime Gio { get; set; }
        public string NhanDinh { get; set; }
        [MoTaDuLieu("Chẩn đoán bệnh chăm sóc")]
		public string ChanDoanChamSoc { get; set; }
        public string LapKeHoachChamSoc { get; set; }
        [MoTaDuLieu("Mã điều dưỡng")]
		public string MaDieuDuong { get; set; }
    }
    public class KeHoachChamSocNguoiBenhFunc
    {
        public const string TableName = "KeHoachChamSocNguoiBenh";
        public const string TablePrimaryKeyName = "ID";
        public static ObservableCollection<KeHoachChamSocNguoiBenh_ChiTiet> GetListData_ChiTiet(MDB.MDBConnection _OracleConnection, long IdPhieu)
        {
            ObservableCollection<KeHoachChamSocNguoiBenh_ChiTiet> list = new ObservableCollection<KeHoachChamSocNguoiBenh_ChiTiet>();
            try
            {
                string sql = @"SELECT * FROM KHCSNGUOIBENH_CHITIET where ID_Phieu = :ID_Phieu ORDER BY Ngay ASC";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, _OracleConnection);
                Command.Parameters.Add(new MDB.MDBParameter("ID_Phieu", IdPhieu));
                MDB.MDBDataReader DataReader = Command.ExecuteReader();
                while (DataReader.Read())
                {
                    KeHoachChamSocNguoiBenh_ChiTiet data = new KeHoachChamSocNguoiBenh_ChiTiet();
                    data.ID = Convert.ToInt64(DataReader.GetLong("ID").ToString());
                    data.ID_Phieu = IdPhieu;
                    data.Ngay =  Convert.ToDateTime(DataReader["Ngay"] == DBNull.Value ? DateTime.Now : DataReader["Ngay"]);
                    data.Gio = data.Ngay;
                    data.NhanDinh = DataReader["NhanDinh"].ToString();
                    data.ChanDoanChamSoc = DataReader["ChanDoanChamSoc"].ToString();
                    data.LapKeHoachChamSoc = DataReader["LapKeHoachChamSoc"].ToString();
                    data.MaDieuDuong = DataReader["MaDieuDuong"].ToString();
                    list.Add(data);
                }
            }
            catch (Exception ex) { XuLyLoi.Handle(ex); }
            return list;
        }    
        public static List<KeHoachChamSocNguoiBenh> GetListData_Phieu(MDB.MDBConnection _OracleConnection, decimal maquanly)
        {
            List<KeHoachChamSocNguoiBenh> list = new List<KeHoachChamSocNguoiBenh>();
            try
            {
                string sql = @"SELECT * FROM KeHoachChamSocNguoiBenh where MaQuanLy = :MaQuanLy";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, _OracleConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", maquanly));
                MDB.MDBDataReader DataReader = Command.ExecuteReader();
                while (DataReader.Read())
                {
                    KeHoachChamSocNguoiBenh data = new KeHoachChamSocNguoiBenh();
                    data.ID = Convert.ToInt64(DataReader.GetLong("ID").ToString());
                    data.MaQuanLy = maquanly;
                    data.MaBenhNhan = DataReader["MaBenhNhan"].ToString();
                    data.Khoa = DataReader["Khoa"].ToString();
                    data.MaKhoa = DataReader["MaKhoa"].ToString();
                    data.HoVaTen = XemBenhAn._HanhChinhBenhNhan.TenBenhNhan;
                    data.GioiTinh = XemBenhAn._HanhChinhBenhNhan.GioiTinh.Description();
                    data.Tuoi = XemBenhAn._HanhChinhBenhNhan.Tuoi;
                    int tempInt = 0;
                    data.So = int.TryParse(DataReader["So"].ToString(), out tempInt) ? (int?)tempInt : 0;
                    data.ChanDoan = DataReader["ChanDoan"].ToString();
                    data.NgayVaoVien = DataReader.GetDate("NgayVaoVien");
                    data.Giuong = DataReader["Giuong"].ToString();
                    data.Buong = DataReader["Buong"].ToString();

                    data.ChiTiets = GetListData_ChiTiet(_OracleConnection, data.ID);

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
        public static bool InsertOrUpdate_Phieu(MDB.MDBConnection MyConnection, ref KeHoachChamSocNguoiBenh bangDieuTri)
        {
            try
            {
                string sql = @"INSERT INTO KeHoachChamSocNguoiBenh
                (
                    MAQUANLY,
                    MaBenhNhan,
                    Khoa,
                    MaKhoa,
                    So,
                    NgayVaoVien,
                    ChanDoan,
                    Buong,
                    Giuong,
                    NGUOITAO,
                    NGUOISUA,
                    NGAYTAO,
                    NGAYSUA)  VALUES
                 (
				    :MAQUANLY,
                    :MaBenhNhan,
                    :Khoa,
                    :MaKhoa,
                    :So,
                    :NgayVaoVien,
                    :ChanDoan,
                    :Buong,
                    :Giuong,                    
                    :NGUOITAO,
                    :NGUOISUA,
                    :NGAYTAO,
                    :NGAYSUA
                 )  RETURNING ID INTO :ID";
                if (bangDieuTri.ID != 0)
                {
                    sql = @"UPDATE KeHoachChamSocNguoiBenh SET 
                    MAQUANLY = :MAQUANLY,
                    MaBenhNhan = :MaBenhNhan,
                    Khoa = :Khoa,
                    MaKhoa = :MaKhoa,
                    So = :So,
                    NgayVaoVien = :NgayVaoVien,
                    ChanDoan = :ChanDoan,
                    Buong = :Buong,
                    Giuong = :Giuong,
                    NGUOISUA = :NGUOISUA,
                    NGAYSUA = :NGAYSUA
                    WHERE ID = " + bangDieuTri.ID;
                }
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MAQUANLY", bangDieuTri.MaQuanLy));
                Command.Parameters.Add(new MDB.MDBParameter("MaBenhNhan", bangDieuTri.MaBenhNhan));
                Command.Parameters.Add(new MDB.MDBParameter("Khoa", bangDieuTri.Khoa));
                Command.Parameters.Add(new MDB.MDBParameter("MaKhoa", bangDieuTri.MaKhoa));
                Command.Parameters.Add(new MDB.MDBParameter("So", bangDieuTri.So));
                Command.Parameters.Add(new MDB.MDBParameter("NgayVaoVien", bangDieuTri.NgayVaoVien));
                Command.Parameters.Add(new MDB.MDBParameter("ChanDoan", bangDieuTri.ChanDoan));
                Command.Parameters.Add(new MDB.MDBParameter("Buong", bangDieuTri.Buong));
                Command.Parameters.Add(new MDB.MDBParameter("Giuong", bangDieuTri.Giuong));
                Command.Parameters.Add(new MDB.MDBParameter("NGUOISUA", bangDieuTri.NguoiSua));
                Command.Parameters.Add(new MDB.MDBParameter("NGAYSUA", bangDieuTri.NgaySua));
                if (bangDieuTri.ID == 0)
                {
                    Command.Parameters.Add(new MDB.MDBParameter("ID", bangDieuTri.ID));
                    Command.Parameters.Add(new MDB.MDBParameter("NGUOITAO", bangDieuTri.NguoiTao));
                    Command.Parameters.Add(new MDB.MDBParameter("NGAYTAO", bangDieuTri.NgayTao));
                }
                Command.BindByName = true;
                int n = Command.ExecuteNonQuery();
                if (bangDieuTri.ID == 0)
                {
                    long nextval = Convert.ToInt64((Command.Parameters["ID"] as MDB.MDBParameter).Value);
                    bangDieuTri.ID = nextval;
                }
                return n > 0 ? true : false;
            }
            catch (Exception ex)
            {
                XuLyLoi.Handle(ex);
            }
            return false;
        }
        public static bool InsertOrUpdate_ChiTiet(MDB.MDBConnection MyConnection, KeHoachChamSocNguoiBenh_ChiTiet phieuChiTiet, long ID_Phieu)
        {
            try
            {
                string sql = @"INSERT INTO KHCSNGUOIBENH_CHITIET
                (
                    ID_Phieu,
                    Ngay,
                    NhanDinh,
                    ChanDoanChamSoc,
                    LapKeHoachChamSoc,
                    MaDieuDuong) 
                VALUES
                 (
				    :ID_Phieu,
                    :Ngay,
                    :NhanDinh,
                    :ChanDoanChamSoc,
                    :LapKeHoachChamSoc,
                    :MaDieuDuong
                 )";
                if (phieuChiTiet.ID != 0)
                {
                    sql = @"UPDATE KHCSNGUOIBENH_CHITIET SET 
                    ID_Phieu = :ID_Phieu,
                    Ngay = :Ngay,
                    NhanDinh = :NhanDinh,
                    ChanDoanChamSoc = :ChanDoanChamSoc,
                    LapKeHoachChamSoc = :LapKeHoachChamSoc,
                    MaDieuDuong = :MaDieuDuong
                    WHERE ID = " + phieuChiTiet.ID;
                }
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
                Command.Parameters.Add(new MDB.MDBParameter("ID_Phieu", ID_Phieu));
                var Ngay = phieuChiTiet.Ngay.Date.Add(new TimeSpan(0, 0, 0));
                var Gio = phieuChiTiet.Gio != null ? phieuChiTiet.Gio.TimeOfDay : DateTime.Now.TimeOfDay;
                var NgayGioChamSoc = Ngay + Gio;
                Command.Parameters.Add(new MDB.MDBParameter("Ngay", NgayGioChamSoc));
                Command.Parameters.Add(new MDB.MDBParameter("NhanDinh", phieuChiTiet.NhanDinh));
                Command.Parameters.Add(new MDB.MDBParameter("ChanDoanChamSoc", phieuChiTiet.ChanDoanChamSoc));
                Command.Parameters.Add(new MDB.MDBParameter("LapKeHoachChamSoc", phieuChiTiet.LapKeHoachChamSoc));
                Command.Parameters.Add(new MDB.MDBParameter("MaDieuDuong", phieuChiTiet.MaDieuDuong));
                Command.BindByName = true;
                int n = Command.ExecuteNonQuery();
                return n > 0 ? true : false;
            }
            catch (Exception ex)
            {
                XuLyLoi.Handle(ex);
            }
            return false;
        }
        public static bool Delete_Phieu(MDB.MDBConnection MyConnection, long id)
        {
            try
            {

                string sql = "DELETE FROM KeHoachChamSocNguoiBenh WHERE ID = :ID";
                MDB.MDBCommand command = new MDB.MDBCommand(sql, MyConnection);
                command.Parameters.Add(new MDB.MDBParameter("ID", id));
                command.BindByName = true;
                int n = command.ExecuteNonQuery();

                sql = "DELETE FROM KHCSNGUOIBENH_CHITIET WHERE ID_Phieu = :ID_Phieu";
                command = new MDB.MDBCommand(sql, MyConnection);
                command.Parameters.Add(new MDB.MDBParameter("ID_Phieu", id));
                command.BindByName = true;
                int m = command.ExecuteNonQuery();

                return (n > 0 && m > 0) ? true : false;
            }
            catch (Exception ex)
            {
                XuLyLoi.Handle(ex);
            }
            return false;
        }
        public static bool Delete_ChiTiet(MDB.MDBConnection MyConnection, long id)
        {
            try
            {
                string sql = "DELETE FROM KHCSNGUOIBENH_CHITIET WHERE ID = :ID";
                MDB.MDBCommand command = new MDB.MDBCommand(sql, MyConnection);
                command.Parameters.Add(new MDB.MDBParameter("ID", id));
                command.BindByName = true;
                int n = command.ExecuteNonQuery();
                return n > 0 ? true : false;
            }
            catch (Exception ex)
            {
                //XuLyLoi.Handle(ex);
            }
            return false;
        }
        public static DataSet getDataSet(MDB.MDBConnection MyConnection, long id)
        {
            string sql = @"SELECT
                P.*
            FROM
                KeHoachChamSocNguoiBenh P
            WHERE
                ID = " + id;

            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
            MDB.MDBDataAdapter adt = new MDB.MDBDataAdapter(Command);
            var ds = new DataSet();

            adt.Fill(ds, "KH");

            ds.Tables[0].AddColumn("TenBenhNhan", typeof(string));
            ds.Tables[0].AddColumn("MaBenhAn", typeof(string));
            ds.Tables[0].AddColumn("Tuoi", typeof(string));
            ds.Tables[0].AddColumn("NamSinh", typeof(string));
            ds.Tables[0].AddColumn("GioiTinh", typeof(string));
            ds.Tables[0].AddColumn("SOYTE", typeof(string));
            ds.Tables[0].AddColumn("BENHVIEN", typeof(string));
            ds.Tables[0].AddColumn("KHOA", typeof(string));

            ds.Tables[0].Rows[0]["TenBenhNhan"] = XemBenhAn._HanhChinhBenhNhan.TenBenhNhan;
            ds.Tables[0].Rows[0]["MaBenhAn"] = XemBenhAn._ThongTinDieuTri.MaBenhAn;
            ds.Tables[0].Rows[0]["Tuoi"] = XemBenhAn._HanhChinhBenhNhan.Tuoi;
            ds.Tables[0].Rows[0]["NamSinh"] = XemBenhAn._HanhChinhBenhNhan.NgaySinh.HasValue ? XemBenhAn._HanhChinhBenhNhan.NgaySinh.Value.Year + "" : "";
            ds.Tables[0].Rows[0]["GioiTinh"] = XemBenhAn._HanhChinhBenhNhan.GioiTinh.Description();
            ds.Tables[0].Rows[0]["SOYTE"] = XemBenhAn._HanhChinhBenhNhan.SoYTe;
            ds.Tables[0].Rows[0]["BENHVIEN"] = XemBenhAn._HanhChinhBenhNhan.BenhVien;
            ds.Tables[0].Rows[0]["KHOA"] = XemBenhAn._ThongTinDieuTri.Khoa;

            DataTable ChiTiet = new DataTable("CT");
            ChiTiet.Columns.Add("Ngay", typeof(string));
            ChiTiet.Columns.Add("NhanDinh", typeof(string));
            ChiTiet.Columns.Add("ChanDoanChamSoc", typeof(string));
            ChiTiet.Columns.Add("LapKeHoachChamSoc", typeof(string));
            ChiTiet.Columns.Add("DieuDuong", typeof(string));
            ObservableCollection<KeHoachChamSocNguoiBenh_ChiTiet> ChiTiets = GetListData_ChiTiet(MyConnection, id);
            foreach (KeHoachChamSocNguoiBenh_ChiTiet ct in ChiTiets)
            {
                string DieuDuong = "";
                try
                {
                    if (!string.IsNullOrEmpty(ct.MaDieuDuong))
                    {
                        DieuDuong = NhanVienFunc.ListNhanVien.FirstOrDefault(x => x.MaNhanVien.Equals(ct.MaDieuDuong)).HoVaTen;
                    }
                }
                catch (Exception ex)
                {
                    ExceptionExtend.Log("Get Nhan Vien", "Error : not found "+ ct.MaDieuDuong+ "->" + ex.Message);
                }
                ChiTiet.Rows.Add(ct.Ngay.ToString("HH:mm dd/MM/yyyy"),
                   ct.NhanDinh,
                   ct.ChanDoanChamSoc,
                   ct.LapKeHoachChamSoc,
                   DieuDuong
                   );
            }
            ds.Tables.Add(ChiTiet);
            return ds;
        }
    }
}
