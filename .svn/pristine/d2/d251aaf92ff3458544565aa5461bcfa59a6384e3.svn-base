
using EMR.KyDienTu;
using PMS.Access;
using System;
using System.Collections.Generic;
using System.Data;

namespace EMR_MAIN.DATABASE.Other
{
    public class GiayChungNhanPhauThuat : ThongTinKy
    {
        public GiayChungNhanPhauThuat()
        {
            TableName = "GiayChungNhanPhauThuat";
            TablePrimaryKeyName = "ID";
            IDMauPhieu = (int)DanhMucPhieu.GCNPT;
            TenMauPhieu = DanhMucPhieu.GCNPT.Description();
        }
        [MoTaDuLieu("Mã định danh")]
		public long ID { get; set; }
        [MoTaDuLieu("Mã quản lý: mã duy nhất trong 1 đợt khám chữa bệnh (kcb), không trùng giữa các đợt kcb khác nhau","",1)]
		public decimal MaQuanLy { get; set; }
        [MoTaDuLieu("Mã bệnh nhân")]
		public string MaBenhNhan { get; set; }
		[MoTaDuLieu("Sở Y Tế")]
		public string SoYTe { get; set; }
        [MoTaDuLieu("Bệnh viện")]
		public string BenhVien { get; set; }
        [MoTaDuLieu("Sổ lưu trữ")]
        public string SoLuuTru { get; set; }
        [MoTaDuLieu("Tên bệnh nhân")]
		public string TenBenhNhan { get; set; }
        [MoTaDuLieu("Năm sinh bệnh nhân")]
		public string NamSinh { get; set; }
        [MoTaDuLieu("Giới tính bệnh nhân")]
		public string GioiTinh { get; set; }
        [MoTaDuLieu("Địa chỉ bệnh nhân")]
        public string DiaChi { get; set; }
        [MoTaDuLieu("Ngày vào viện")]
		public DateTime? NgayVaoVien { get; set; }
        [MoTaDuLieu("Ngày ra viện")]
        public DateTime? NgayRaVien { get; set; }
        [MoTaDuLieu("Ngày phẫu thuật")]
        public DateTime? NgayPhauThuat { get; set; }
        [MoTaDuLieu("Cách phẫu thuật")]
        public string CachPhauThuat { get; set; }
        [MoTaDuLieu("Mã phẫu thuật viên")]
        public string MaPhauThuatVien { get; set; }
        [MoTaDuLieu("Phẫu thuật viên")]
        public string PhauThuatVien { get; set; }
        [MoTaDuLieu("Cách gây mê")]
        public string CachGayMe { get; set; }
        [MoTaDuLieu("Nhóm máu")]
        public string NhomMau { get; set; }
        [MoTaDuLieu("Yếu tố Rh")]
        public string Rh { get; set; }
        [MoTaDuLieu("Trưởng khoa")]
        public string TruongKhoa { get; set; }
        [MoTaDuLieu("Mã trưởng khoa")]
        public string MaTruongKhoa { get; set; }
        [MoTaDuLieu("Giám đốc")]
        public string GiamDoc { get; set; }
        [MoTaDuLieu("Mã giám đốc")]
        public string MaGiamDoc { get; set; }
        public string ThoiGian_Text { get; set; }
        public DateTime? ThoiGian { get; set; }
        [MoTaDuLieu("Người tạo")]
		public string NguoiTao { get; set; }
        [MoTaDuLieu("Người sửa")]
		public string NguoiSua { get; set; }
        [MoTaDuLieu("Ngày tạo")]
		public DateTime NgayTao { get; set; }
        [MoTaDuLieu("Ngày sửa")]
		public DateTime NgaySua { get; set; }
        [MoTaDuLieu("Chọn")]
		public bool Chon { get; set; }
        //public string MaSoKyTen { get; set; }
        [MoTaDuLieu("Đã ký")]
		public bool DaKy { get; set; }
    }
    public class GiayChungNhanPhauThuatFunc
    {
        public const string TableName = "GiayChungNhanPhauThuat";
        public const string TablePrimaryKeyName = "ID";

        public static List<GiayChungNhanPhauThuat> GetListData(MDB.MDBConnection _OracleConnection, decimal maquanly)
        {
            List<GiayChungNhanPhauThuat> list = new List<GiayChungNhanPhauThuat>();
            try
            {
                string sql = @"SELECT * FROM GiayChungNhanPhauThuat where MaQuanLy = :MaQuanLy";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, _OracleConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", maquanly));
                MDB.MDBDataReader DataReader = Command.ExecuteReader();
                while (DataReader.Read())
                {
                    GiayChungNhanPhauThuat data = new GiayChungNhanPhauThuat();
                    data.ID = Convert.ToInt64(DataReader.GetLong("ID").ToString());
                    data.MaQuanLy = maquanly;

                    data.MaBenhNhan = XemBenhAn._HanhChinhBenhNhan.MaBenhNhan;
                    data.SoYTe = XemBenhAn._HanhChinhBenhNhan.SoYTe;
                    data.BenhVien = XemBenhAn._HanhChinhBenhNhan.BenhVien;

                    data.SoLuuTru = DataReader["SoLuuTru"].ToString();
                    data.TenBenhNhan = XemBenhAn._HanhChinhBenhNhan.TenBenhNhan;
                    data.NamSinh = XemBenhAn._HanhChinhBenhNhan.NgaySinh?.Year.ToString();
                    data.GioiTinh = XemBenhAn._HanhChinhBenhNhan.GioiTinh.Description();
                    data.DiaChi = DataReader["DiaChi"].ToString();
                    data.NgayVaoVien = Convert.ToDateTime(DataReader["NgayVaoVien"] == DBNull.Value ? DateTime.Now : DataReader["NgayVaoVien"]);
                    data.NgayRaVien = Convert.ToDateTime(DataReader["NgayRaVien"] == DBNull.Value ? DateTime.Now : DataReader["NgayRaVien"]);
                    data.NgayPhauThuat = Convert.ToDateTime(DataReader["NgayPhauThuat"] == DBNull.Value ? DateTime.Now : DataReader["NgayPhauThuat"]);

                    data.CachPhauThuat = DataReader["CachPhauThuat"].ToString();
                    data.PhauThuatVien = DataReader["PhauThuatVien"].ToString();
                    data.MaPhauThuatVien = DataReader["MaPhauThuatVien"].ToString();
                    data.CachGayMe = DataReader["CachGayMe"].ToString();
                    data.NhomMau = DataReader["NhomMau"].ToString();
                    data.Rh = DataReader["Rh"].ToString();
                    data.TruongKhoa = DataReader["TruongKhoa"].ToString();
                    data.MaTruongKhoa = DataReader["MaTruongKhoa"].ToString();
                    data.GiamDoc = DataReader["GiamDoc"].ToString();
                    data.MaGiamDoc = DataReader["MaGiamDoc"].ToString();
                    data.ThoiGian_Text = DataReader["ThoiGian_Text"].ToString();
                    data.ThoiGian = Convert.ToDateTime(DataReader["ThoiGian"] == DBNull.Value ? DateTime.Now : DataReader["ThoiGian"]);

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
                sql = @"DELETE FROM GiayChungNhanPhauThuat WHERE ID =" + IDBienBan;
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
                GiayChungNhanPhauThuat P
            WHERE
                ID = " + IDBienBan;

            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
            MDB.MDBDataAdapter adt = new MDB.MDBDataAdapter(Command);
            var ds = new DataSet();

            adt.Fill(ds, "TB");

            ds.Tables[0].AddColumn("SoYTe", typeof(string));
            ds.Tables[0].AddColumn("TenBenhNhan", typeof(string));
            ds.Tables[0].AddColumn("BenhVien", typeof(string));
            ds.Tables[0].AddColumn("NamSinh", typeof(string));
            ds.Tables[0].AddColumn("GioiTinh", typeof(string));
            ds.Tables[0].AddColumn("ThoiGianFull", typeof(string));
            ds.Tables[0].Rows[0]["SoYTe"] = XemBenhAn._HanhChinhBenhNhan.SoYTe;
            ds.Tables[0].Rows[0]["BenhVien"] = XemBenhAn._HanhChinhBenhNhan.BenhVien;
            ds.Tables[0].Rows[0]["TenBenhNhan"] = XemBenhAn._HanhChinhBenhNhan.TenBenhNhan;
            ds.Tables[0].Rows[0]["NamSinh"] = XemBenhAn._HanhChinhBenhNhan.NgaySinh?.Year.ToString();
            ds.Tables[0].Rows[0]["GioiTinh"] = XemBenhAn._HanhChinhBenhNhan.GioiTinh.Description();

            DateTime ThoiGian = ds.Tables[0].Rows[0]["ThoiGian"].ToDateTime();
            string ThoiGian_Text = ds.Tables[0].Rows[0]["ThoiGian_Text"].ToString();

            ds.Tables[0].Rows[0]["ThoiGianFull"] = ThoiGian_Text + ", ngày " + ThoiGian.Day + " tháng " + ThoiGian.Month + " năm " + ThoiGian.Year;

            return ds;
        }
        public static bool InsertOrUpdate(MDB.MDBConnection MyConnection, ref GiayChungNhanPhauThuat ketQua)
        {
            try
            {
                string sql = @"INSERT INTO GiayChungNhanPhauThuat
                (
                    MaQuanLy,
                    SoLuuTru,
                    DiaChi,
                    NgayVaoVien,
                    NgayRaVien,
                    NgayPhauThuat,
                    CachPhauThuat,
                    PhauThuatVien,
                    MaPhauThuatVien,
                    CachGayMe,
                    NhomMau,
                    Rh,
                    TruongKhoa,
                    MaTruongKhoa,
                    GiamDoc,
                    MaGiamDoc,
                    ThoiGian_Text,
                    ThoiGian,
                    NGUOITAO,
                    NGUOISUA,
                    NGAYTAO,
                    NGAYSUA)  VALUES
                 (
				    :MaQuanLy,
                    :SoLuuTru,
                    :DiaChi,
                    :NgayVaoVien,
                    :NgayRaVien,
                    :NgayPhauThuat,
                    :CachPhauThuat,
                    :PhauThuatVien,
                    :MaPhauThuatVien,
                    :CachGayMe,
                    :NhomMau,
                    :Rh,
                    :TruongKhoa,
                    :MaTruongKhoa,
                    :GiamDoc,
                    :MaGiamDoc,
                    :ThoiGian_Text,
                    :ThoiGian,
                    :NGUOITAO,
                    :NGUOISUA,
                    :NGAYTAO,
                    :NGAYSUA
                 )  RETURNING ID INTO :ID";
                if (ketQua.ID != 0)
                {
                    sql = @"UPDATE GiayChungNhanPhauThuat SET 
                    MaQuanLy = :MaQuanLy,
                    SoLuuTru = :SoLuuTru,
                    DiaChi = :DiaChi,
                    NgayVaoVien = :NgayVaoVien,
                    NgayRaVien = :NgayRaVien,
                    NgayPhauThuat = :NgayPhauThuat,
                    CachPhauThuat = :CachPhauThuat,
                    PhauThuatVien = :PhauThuatVien,
                    MaPhauThuatVien = :MaPhauThuatVien,
                    CachGayMe = :CachGayMe,
                    NhomMau = :NhomMau,
                    Rh = :Rh,
                    TruongKhoa = :TruongKhoa,
                    MaTruongKhoa = :MaTruongKhoa,
                    GiamDoc = :GiamDoc,
                    MaGiamDoc = :MaGiamDoc,
                    ThoiGian_Text = :ThoiGian_Text,
                    ThoiGian = :ThoiGian,
                    NGUOISUA = :NGUOISUA,
                    NGAYSUA = :NGAYSUA 
                    WHERE ID = " + ketQua.ID;
                }
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);

                Command.Parameters.Add(new MDB.MDBParameter("NGUOISUA", ketQua.NguoiSua));
                Command.Parameters.Add(new MDB.MDBParameter("NGAYSUA", ketQua.NgaySua));

                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", ketQua.MaQuanLy));

                Command.Parameters.Add(new MDB.MDBParameter("SoLuuTru", ketQua.SoLuuTru));
                Command.Parameters.Add(new MDB.MDBParameter("DiaChi", ketQua.DiaChi));
                Command.Parameters.Add(new MDB.MDBParameter("NgayVaoVien", ketQua.NgayVaoVien));
                Command.Parameters.Add(new MDB.MDBParameter("NgayRaVien", ketQua.NgayRaVien));
                Command.Parameters.Add(new MDB.MDBParameter("NgayPhauThuat", ketQua.NgayPhauThuat));
                Command.Parameters.Add(new MDB.MDBParameter("CachPhauThuat", ketQua.CachPhauThuat));
                Command.Parameters.Add(new MDB.MDBParameter("PhauThuatVien", ketQua.PhauThuatVien));
                Command.Parameters.Add(new MDB.MDBParameter("MaPhauThuatVien", ketQua.MaPhauThuatVien));
                Command.Parameters.Add(new MDB.MDBParameter("CachGayMe", ketQua.CachGayMe));
                Command.Parameters.Add(new MDB.MDBParameter("NhomMau", ketQua.NhomMau));
                Command.Parameters.Add(new MDB.MDBParameter("Rh", ketQua.Rh));
                Command.Parameters.Add(new MDB.MDBParameter("TruongKhoa", ketQua.TruongKhoa));
                Command.Parameters.Add(new MDB.MDBParameter("MaTruongKhoa", ketQua.MaTruongKhoa));
                Command.Parameters.Add(new MDB.MDBParameter("GiamDoc", ketQua.GiamDoc));
                Command.Parameters.Add(new MDB.MDBParameter("MaGiamDoc", ketQua.MaGiamDoc));
                Command.Parameters.Add(new MDB.MDBParameter("ThoiGian_Text", ketQua.ThoiGian_Text));
                Command.Parameters.Add(new MDB.MDBParameter("ThoiGian", ketQua.ThoiGian));

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
    }
}
