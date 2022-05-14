
using EMR.KyDienTu;
using PMS.Access;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;

namespace EMR_MAIN.DATABASE.Other
{
    public class PhieuTDVCSSSSauMoDe : ThongTinKy
    {
        public PhieuTDVCSSSSauMoDe()
        {
            TableName = "PhieuTDVCSSSSauMoDe";
            TablePrimaryKeyName = "ID";
            IDMauPhieu = (int)DanhMucPhieu.PTDVCSSSSMD;
            TenMauPhieu = DanhMucPhieu.PTDVCSSSSMD.Description();
        }
        [MoTaDuLieu("Mã định danh")]
		public long ID { get; set; }
        [MoTaDuLieu("Mã quản lý: mã duy nhất trong 1 đợt khám chữa bệnh (kcb), không trùng giữa các đợt kcb khác nhau","",1)]
		public decimal MaQuanLy { get; set; }
        [MoTaDuLieu("Mã bệnh nhân")]
		public string MaBenhNhan { get; set; }
        [MoTaDuLieu("Bệnh viện")]
		public string BenhVien { get; set; }
        public string HoTenMe { get; set; }
        [MoTaDuLieu("Địa chỉ nhà bệnh nhân")]
		public string DiaChiMe { get; set; }
        [MoTaDuLieu("Chẩn đoán bệnh")]
		public string ChanDoan { get; set; }
        public DateTime? NgayGioSinh { get; set; }
        public DateTime? NgayGioSinh_Gio { get; set; }
      
        public string YeuCauKiemTra { get; set; }
        [MoTaDuLieu("Họ tên điều dưỡng")]
		public string DieuDuong { get; set; }
        [MoTaDuLieu("Mã điều dưỡng")]
		public string MaDieuDuong { get; set; }
        [MoTaDuLieu("Trưởng khoa")]
		public string TruongKhoa { get; set; }
        [MoTaDuLieu("Mã trưởng khoa")]
		public string MaTruongKhoa { get; set; }

        public ObservableCollection<TheoDoiSoSinh> ListTheoDoi { get; set; }

        [MoTaDuLieu("Người tạo", null, 0, 0)]
		public string NguoiTao { get; set; }
        [MoTaDuLieu("Người sửa", null, 0, 0)]
		public string NguoiSua { get; set; }
        [MoTaDuLieu("Ngày tạo", null, 0, 0)]
		public DateTime NgayTao { get; set; }
        [MoTaDuLieu("Ngày sửa", null, 0, 0)]
		public DateTime NgaySua { get; set; }
        [MoTaDuLieu("Chọn", null, 0, 0)]
		public bool Chon { get; set; }
        //public string MaSoKyTen { get; set; }
        [MoTaDuLieu("Đã ký", null, 0, 0)]
		public bool DaKy { get; set; }
    }

    public class TheoDoiSoSinh
    {
        [MoTaDuLieu("Mã định danh")]
		public long ID { get; set; }
        [MoTaDuLieu("Mã định danh")]
		public long ID_Phieu { get; set; }
        public string NgayThang { get; set; }
        public string TinhTrangSoSinh { get; set; }
        public string SoTri { get; set; }
        public string Thuoc { get; set; }

    }
    public class PhieuTDVCSSSSauMoDeFunc
    {
        public const string TableName = "PhieuTDVCSSSSauMoDe";
        public const string TablePrimaryKeyName = "ID";

        public static List<PhieuTDVCSSSSauMoDe> GetListData(MDB.MDBConnection _OracleConnection, decimal maquanly)
        {
            List<PhieuTDVCSSSSauMoDe> list = new List<PhieuTDVCSSSSauMoDe>();
            try
            {
                string sql = @"SELECT * FROM PhieuTDVCSSSSauMoDe where MaQuanLy = :MaQuanLy";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, _OracleConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", maquanly));
                MDB.MDBDataReader DataReader = Command.ExecuteReader();
                while (DataReader.Read())
                {
                    PhieuTDVCSSSSauMoDe data = new PhieuTDVCSSSSauMoDe();
                    data.ID = Convert.ToInt64(DataReader.GetLong("ID").ToString());
                    data.MaQuanLy = maquanly;

                    data.MaBenhNhan = XemBenhAn._HanhChinhBenhNhan.MaBenhNhan;
                    data.BenhVien = XemBenhAn._HanhChinhBenhNhan.BenhVien;

                    data.HoTenMe = DataReader["HoTenMe"].ToString();
                    data.DiaChiMe = DataReader["DiaChiMe"].ToString();
                    data.ChanDoan = DataReader["ChanDoan"].ToString();
                    data.YeuCauKiemTra = DataReader["YeuCauKiemTra"].ToString();
                    data.MaDieuDuong = DataReader["MaDieuDuong"].ToString();
                    data.DieuDuong = DataReader["DieuDuong"].ToString();
                    data.TruongKhoa = DataReader["TruongKhoa"].ToString();
                    data.MaTruongKhoa = DataReader["MaTruongKhoa"].ToString();
                    
                    data.NgayGioSinh = Convert.ToDateTime(DataReader["NgayGioSinh"] == DBNull.Value ? DateTime.Now : DataReader["NgayGioSinh"]);
                    data.NgayGioSinh_Gio = data.NgayGioSinh;
                    data.ListTheoDoi = GetListTheoDoiSoSinh(_OracleConnection, data.ID);

                    data.NgayTao = Convert.ToDateTime(DataReader["NGAYTAO"] == DBNull.Value ? DateTime.Now : DataReader["NGAYTAO"]);
                    data.NguoiTao = DataReader["NGUOITAO"].ToString();
                    data.NgaySua = Convert.ToDateTime(DataReader["NGAYSUA"] == DBNull.Value ? DateTime.Now : DataReader["NGAYSUA"]);
                    data.NguoiSua = DataReader["NGUOISUA"].ToString();

                    data.MaSoKy = DataReader["masokyten"].ToString();
                    data.DaKy = !string.IsNullOrEmpty(data.MaSoKy) ? true : false;
                    list.Add(data);
                }
            }
            catch (Exception ex) { XuLyLoi.Handle(ex); }
            return list;
        }
        public static bool DeleteByIDPhieu(MDB.MDBConnection oracleConnection, decimal IDBienBan)
        {
            try
            {
                string sql = "";
                MDB.MDBCommand oracleCommand;
                sql = @"DELETE FROM PhieuTDVCSSSSauMoDe WHERE ID =" + IDBienBan;
                using (oracleCommand = new MDB.MDBCommand(sql, oracleConnection))
                {
                    oracleCommand.ExecuteNonQuery();
                }
                return true;
            }
            catch (Exception ex)
            {
                XuLyLoi.LogError(ex);
            }
            return false;
        }
        public static DataSet GetDataSet(MDB.MDBConnection MyConnection, long IDBienBan)
        {
            string sql = @"SELECT
                P.* 
            FROM
                PhieuTDVCSSSSauMoDe P
            WHERE
                ID = " + IDBienBan;

            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
            MDB.MDBDataAdapter adt = new MDB.MDBDataAdapter(Command);
            var ds = new DataSet();

            adt.Fill(ds, "TB");

            ds.Tables[0].AddColumn("BenhVien", typeof(string));
            ds.Tables[0].Rows[0]["BenhVien"] = XemBenhAn._HanhChinhBenhNhan.BenhVien;

            DataTable TD = new DataTable("TD");
            TD.Columns.Add("NgayThang", typeof(string));

            TD.Columns.Add("TinhTrangSoSinh", typeof(string));
            TD.Columns.Add("SoTri", typeof(string));

            TD.Columns.Add("Thuoc", typeof(string));
           
            ObservableCollection<TheoDoiSoSinh> ListTheoDoi = GetListTheoDoiSoSinh(MyConnection, IDBienBan);
            if (ListTheoDoi != null)
            {
                foreach (TheoDoiSoSinh TheoDoi in ListTheoDoi)
                {
                    TD.Rows.Add(TheoDoi.NgayThang, TheoDoi.TinhTrangSoSinh, TheoDoi.SoTri, TheoDoi.Thuoc);
                }
            }
            ds.Tables.Add(TD);

            return ds;
        }
        public static bool InsertOrUpdate(MDB.MDBConnection MyConnection, ref PhieuTDVCSSSSauMoDe ketQua)
        {
            try
            {
                string sql = @"INSERT INTO PhieuTDVCSSSSauMoDe
                (
                    MaQuanLy,
                    HoTenMe,
                    DiaChiMe,
                    NgayGioSinh,
                    ChanDoan,
                    YeuCauKiemTra,
                    DieuDuong,
                    MaDieuDuong,
                    TruongKhoa,
                    MaTruongKhoa,
                    NGUOITAO,
                    NGUOISUA,
                    NGAYTAO,
                    NGAYSUA)  VALUES
                 (
				    :MaQuanLy,
                    :HoTenMe,
                    :DiaChiMe,
                    :NgayGioSinh,
                    :ChanDoan,
                    :YeuCauKiemTra,
                    :DieuDuong,
                    :MaDieuDuong,
                    :TruongKhoa,
                    :MaTruongKhoa,
                    :NGUOITAO,
                    :NGUOISUA,
                    :NGAYTAO,
                    :NGAYSUA
                 )  RETURNING ID INTO :ID";
                if (ketQua.ID != 0)
                {
                    sql = @"UPDATE PhieuTDVCSSSSauMoDe SET 
                    MaQuanLy = :MaQuanLy,
                    HoTenMe = :HoTenMe,
                    DiaChiMe = :DiaChiMe,
                    NgayGioSinh = :NgayGioSinh,
                    ChanDoan = :ChanDoan,
                    YeuCauKiemTra = :YeuCauKiemTra,
                    DieuDuong = :DieuDuong,
                    MaDieuDuong = :MaDieuDuong,
                    TruongKhoa = :TruongKhoa,
                    MaTruongKhoa = :MaTruongKhoa,
                    NGUOISUA = :NGUOISUA,
                    NGAYSUA = :NGAYSUA 
                    WHERE ID = " + ketQua.ID;
                }
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);

                Command.Parameters.Add(new MDB.MDBParameter("NGUOISUA", ketQua.NguoiSua));
                Command.Parameters.Add(new MDB.MDBParameter("NGAYSUA", ketQua.NgaySua));

                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", ketQua.MaQuanLy));

                Command.Parameters.Add(new MDB.MDBParameter("HoTenMe", ketQua.HoTenMe));
                Command.Parameters.Add(new MDB.MDBParameter("DiaChiMe", ketQua.DiaChiMe));
                DateTime? NgayGioSinh = ketQua.NgayGioSinh.HasValue ? ketQua.NgayGioSinh.Value.Add(new TimeSpan(0, 0, 0)) : (DateTime?)null;
                var NgayGio = NgayGioSinh;
                if (NgayGioSinh != null)
                {
                    var Gio = ketQua.NgayGioSinh_Gio.HasValue ? ketQua.NgayGioSinh_Gio.Value.TimeOfDay : new TimeSpan(0, 0, 0);
                    NgayGio = NgayGioSinh + Gio;
                }
                Command.Parameters.Add(new MDB.MDBParameter("NgayGioSinh", NgayGio));
                Command.Parameters.Add(new MDB.MDBParameter("ChanDoan", ketQua.ChanDoan));
                Command.Parameters.Add(new MDB.MDBParameter("YeuCauKiemTra", ketQua.YeuCauKiemTra));
                Command.Parameters.Add(new MDB.MDBParameter("TruongKhoa", ketQua.TruongKhoa));
                Command.Parameters.Add(new MDB.MDBParameter("MaTruongKhoa", ketQua.MaTruongKhoa));
                Command.Parameters.Add(new MDB.MDBParameter("DieuDuong", ketQua.DieuDuong));
                Command.Parameters.Add(new MDB.MDBParameter("MaDieuDuong", ketQua.MaDieuDuong));

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
                XuLyLoi.LogError(ex);
            }
            return false;
        }

        public static ObservableCollection<TheoDoiSoSinh> GetListTheoDoiSoSinh(MDB.MDBConnection _OracleConnection, long idPhieu)
        {
            ObservableCollection<TheoDoiSoSinh> ListTheoDoiSoSinh = new ObservableCollection<TheoDoiSoSinh>();
            try
            {
                string sql = @"SELECT * FROM TheoDoiSoSinh where ID_Phieu = :ID_Phieu ORDER BY ID asc";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, _OracleConnection);
                Command.Parameters.Add(new MDB.MDBParameter("ID_Phieu", idPhieu));
                MDB.MDBDataReader DataReader = Command.ExecuteReader();
                while (DataReader.Read())
                {
                    TheoDoiSoSinh data = new TheoDoiSoSinh();
                    data.ID = Convert.ToInt64(DataReader.GetLong("ID").ToString());
                    data.ID_Phieu = idPhieu;

                    data.NgayThang = DataReader["NgayThang"].ToString();
                    data.TinhTrangSoSinh = DataReader["TinhTrangSoSinh"].ToString();
                    data.SoTri = DataReader["SoTri"].ToString();
                    data.Thuoc = DataReader["Thuoc"].ToString();

                    ListTheoDoiSoSinh.Add(data);
                }
            }
            catch (Exception ex) { XuLyLoi.Handle(ex); }
            return ListTheoDoiSoSinh;
        }
        public static bool DeleteTheoDoiSoSinh(MDB.MDBConnection MyConnection, long id)
        {
            try
            {
                string sql = "DELETE FROM TheoDoiSoSinh WHERE ID = :ID";
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
        public static bool InsertOrUpdateTheoDoiSoSinh(MDB.MDBConnection MyConnection, TheoDoiSoSinh _TheoDoiSoSinh)
        {
            try
            {
                string sql = @"INSERT INTO TheoDoiSoSinh
                (
                    ID_Phieu,
                    NgayThang,
                    TinhTrangSoSinh,
                    SoTri,
                    Thuoc)  VALUES
                 (
				    :ID_Phieu,
                    :NgayThang,
                    :TinhTrangSoSinh,
                    :SoTri,
                    :Thuoc
                 )";
                if (_TheoDoiSoSinh.ID != 0)
                {
                    sql = @"UPDATE TheoDoiSoSinh SET 
                    ID_Phieu = :ID_Phieu,
                    NgayThang = :NgayThang,
                    TinhTrangSoSinh = :TinhTrangSoSinh,
                    SoTri = :SoTri,
                    Thuoc = :Thuoc
                    WHERE ID = " + _TheoDoiSoSinh.ID;
                }
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
                Command.Parameters.Add(new MDB.MDBParameter("ID_Phieu", _TheoDoiSoSinh.ID_Phieu));
                Command.Parameters.Add(new MDB.MDBParameter("NgayThang", _TheoDoiSoSinh.NgayThang));
                Command.Parameters.Add(new MDB.MDBParameter("TinhTrangSoSinh", _TheoDoiSoSinh.TinhTrangSoSinh));
                Command.Parameters.Add(new MDB.MDBParameter("SoTri", _TheoDoiSoSinh.SoTri));
                Command.Parameters.Add(new MDB.MDBParameter("Thuoc", _TheoDoiSoSinh.Thuoc));

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
    }
}
