using EMR.KyDienTu;
using System;
using System.Collections.Generic;
using System.Data;
using PMS.Access;

namespace EMR_MAIN.DATABASE.Other
{
    public class GCDCNTTTMCTVGMHS : ThongTinKy
    {
        public GCDCNTTTMCTVGMHS()
        {
            TableName = "GCDCNTTTMCTVGMHS";
            TablePrimaryKeyName = "ID";
            IDMauPhieu = (int)DanhMucPhieu.GCDCNTTTMCTVGMHS;
            TenMauPhieu = DanhMucPhieu.GCDCNTTTMCTVGMHS.Description();
        }
        [MoTaDuLieu("Mã định danh")]
		public decimal ID { get; set; }
        [MoTaDuLieu("Mã quản lý: mã duy nhất trong 1 đợt khám chữa bệnh (kcb), không trùng giữa các đợt kcb khác nhau","",1)]
		public decimal MaQuanLy { get; set; }
        public string HoTen { get; set; }
        [MoTaDuLieu("Tuổi bệnh nhân")]
		public string Tuoi { get; set; }
        [MoTaDuLieu("Giới tính bệnh nhân")]
		public string GioiTinh { get; set; }
        [MoTaDuLieu("Dân tộc")]
		public string DanToc { get; set; }
        public string NgoaiKieu { get; set; }
        [MoTaDuLieu("Nghề nghiệp")]
		public string NgheNghiep { get; set; }
        public string NoiLamViec { get; set; }
        [MoTaDuLieu("Địa chỉ nhà bệnh nhân")]
		public string DiaChi { get; set; }
        public string SDT { get; set; }
        [MoTaDuLieu("Khoa")]
		public string Khoa { get; set; }
        [MoTaDuLieu("Bệnh viện")]
		public string BenhVien { get; set; }
        public string QuanHeVoiNguoiBenh { get; set; }
        [MoTaDuLieu("Họ và tên bệnh nhân")]
		public string TenBenhNhan { get; set; }
        public string QuanHeNguoiLamPhieu { get; set; }
        [MoTaDuLieu("Họ tên bác sỹ")]
		public string BacSi { get; set; }
        [MoTaDuLieu("Mã bác sỹ")]
		public string MaBacSi { get; set; }
        [MoTaDuLieu("Ngày tạo", null, 0, 0)]
		public DateTime NgayTao { get; set; }
        [MoTaDuLieu("Ngày sửa", null, 0, 0)]
		public DateTime NgaySua { get; set; }
        [MoTaDuLieu("Ngày ký")]
		public DateTime NgayKi { get; set; }
        [MoTaDuLieu("Người tạo", null, 0, 0)]
		public string NguoiTao { get; set; }
        [MoTaDuLieu("Người sửa", null, 0, 0)]
		public string NguoiSua { get; set; }
        [MoTaDuLieu("Chọn", null, 0, 0)]
		public bool Chon { get; set; }
        //public string MaSoKyTen { get; set; }
        [MoTaDuLieu("Đã ký", null, 0, 0)]
		public bool DaKy { get; set; }
    }
    public class GCDCNTTTMCTVGMHSFunc
    {

        public const string TableName = "GCDCNTTTMCTVGMHS";
        public const string TablePrimaryKeyName = "ID";

        public static bool Delete(MDB.MDBConnection MyConnection, decimal id)
        {
            try
            {
                string sql = "DELETE FROM GCDCNTTTMCTVGMHS WHERE ID = :ID";
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

        public static List<GCDCNTTTMCTVGMHS> GetListData(MDB.MDBConnection _OracleConnection, decimal maquanly)
        {
            List<GCDCNTTTMCTVGMHS> list = new List<GCDCNTTTMCTVGMHS>();
            try
            {
                string sql = @"SELECT * FROM GCDCNTTTMCTVGMHS where MaQuanLy = :MaQuanLy";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, _OracleConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", maquanly));
                MDB.MDBDataReader DataReader = Command.ExecuteReader();
                while (DataReader.Read())
                {
                    GCDCNTTTMCTVGMHS data = new GCDCNTTTMCTVGMHS();
                    data.ID = Convert.ToInt64(DataReader.GetLong("ID").ToString());
                    data.MaQuanLy = maquanly;

                    data.Khoa = XemBenhAn._ThongTinDieuTri.Khoa;
                    data.BenhVien = XemBenhAn._HanhChinhBenhNhan.BenhVien;

                    data.HoTen = DataReader["HoTen"].ToString();
                    data.Tuoi = DataReader["Tuoi"].ToString();
                    data.GioiTinh = DataReader["GioiTinh"].ToString();

                    data.DanToc = DataReader["DanToc"].ToString();
                    data.NgoaiKieu = DataReader["NgoaiKieu"].ToString();
                    data.NgheNghiep = DataReader["NgheNghiep"].ToString();
                    data.NoiLamViec = DataReader["NoiLamViec"].ToString();
                    data.DiaChi = DataReader["DiaChi"].ToString();
                    data.SDT = DataReader["SDT"].ToString();

                    data.QuanHeVoiNguoiBenh = DataReader["QuanHeVoiNguoiBenh"].ToString();
                    data.QuanHeNguoiLamPhieu = DataReader["QuanHeNguoiLamPhieu"].ToString();
                    data.TenBenhNhan = DataReader["TenBenhNhan"].ToString();

                    data.BacSi = DataReader["BacSi"].ToString();
                    data.MaBacSi = DataReader["MaBacSi"].ToString();

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
        public static DataSet GetDataSet(MDB.MDBConnection MyConnection, string IDBienBan)
        {
            string sql = @"SELECT
                P.* 
            FROM
                GCDCNTTTMCTVGMHS P
            WHERE
                ID = " + IDBienBan;

            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
            MDB.MDBDataAdapter adt = new MDB.MDBDataAdapter(Command);
            var ds = new DataSet();

            adt.Fill(ds, "TB");

            ds.Tables[0].AddColumn("BenhVien", typeof(string));
            ds.Tables[0].AddColumn("Khoa", typeof(string));
            ds.Tables[0].AddColumn("SoYTe", typeof(string));

            ds.Tables[0].Rows[0]["BenhVien"] = XemBenhAn._HanhChinhBenhNhan.BenhVien;
            ds.Tables[0].Rows[0]["Khoa"] = XemBenhAn._ThongTinDieuTri.Khoa;
            ds.Tables[0].Rows[0]["SoYTe"] = XemBenhAn._HanhChinhBenhNhan.SoYTe;

            return ds;
        }
        public static bool InsertOrUpdate(MDB.MDBConnection MyConnection, GCDCNTTTMCTVGMHS ketQua)
        {
            try
            {
                string sql = @"INSERT INTO GCDCNTTTMCTVGMHS
                (
                    MaQuanLy,
                    HoTen,
                    Tuoi,
                    GioiTinh,
                    NgheNghiep,
                    DanToc,
                    NgoaiKieu,
                    NoiLamViec,
                    DiaChi,
                    SDT,
                    QuanHeVoiNguoiBenh,
                    QuanHeNguoiLamPhieu,
                    TenBenhNhan,
                    BacSi,
                    MaBacSi,
                    NGUOITAO,
                    NGUOISUA,
                    NGAYTAO,
                    NGAYSUA)  VALUES
                 (
				    :MaQuanLy,
                    :HoTen,
                    :Tuoi,
                    :GioiTinh,
                    :NgheNghiep,
                    :DanToc,
                    :NgoaiKieu,
                    :NoiLamViec,
                    :DiaChi,
                    :SDT,
                    :QuanHeVoiNguoiBenh,
                    :QuanHeNguoiLamPhieu,
                    :TenBenhNhan,
                    :BacSi,
                    :MaBacSi,
                    :NGUOITAO,
                    :NGUOISUA,
                    :NGAYTAO,
                    :NGAYSUA
                 )  RETURNING ID INTO :ID";
                if (ketQua.ID != 0)
                {
                    sql = @"UPDATE GCDCNTTTMCTVGMHS SET 
                    MaQuanLy = :MaQuanLy,
                    HoTen = :HoTen,
                    Tuoi = :Tuoi,
                    GioiTinh = :GioiTinh,
                    NgheNghiep = :NgheNghiep,
                    DanToc = :DanToc,
                    NgoaiKieu = :NgoaiKieu,
                    NoiLamViec = :NoiLamViec,
                    DiaChi = :DiaChi,
                    SDT = :SDT,
                    QuanHeVoiNguoiBenh = :QuanHeVoiNguoiBenh,
                    QuanHeNguoiLamPhieu = :QuanHeNguoiLamPhieu,
                    TenBenhNhan = :TenBenhNhan,
                    BacSi = :BacSi,
                    MaBacSi = :MaBacSi,
                    NGUOISUA = :NGUOISUA,
                    NGAYSUA = :NGAYSUA 
                    WHERE ID = " + ketQua.ID;
                }
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);

                Command.Parameters.Add(new MDB.MDBParameter("NGUOISUA", ketQua.NguoiSua));
                Command.Parameters.Add(new MDB.MDBParameter("NGAYSUA", ketQua.NgaySua));

                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", ketQua.MaQuanLy));

                Command.Parameters.Add(new MDB.MDBParameter("HoTen", ketQua.HoTen));
                Command.Parameters.Add(new MDB.MDBParameter("Tuoi", ketQua.Tuoi));
                Command.Parameters.Add(new MDB.MDBParameter("GioiTinh", ketQua.GioiTinh));

                Command.Parameters.Add(new MDB.MDBParameter("DanToc", ketQua.DanToc));
                Command.Parameters.Add(new MDB.MDBParameter("NgoaiKieu", ketQua.NgoaiKieu));
                Command.Parameters.Add(new MDB.MDBParameter("NgheNghiep", ketQua.NgheNghiep));
                Command.Parameters.Add(new MDB.MDBParameter("NoiLamViec", ketQua.NoiLamViec));

                Command.Parameters.Add(new MDB.MDBParameter("DiaChi", ketQua.DiaChi));
                Command.Parameters.Add(new MDB.MDBParameter("SDT", ketQua.SDT));

                Command.Parameters.Add(new MDB.MDBParameter("QuanHeVoiNguoiBenh", ketQua.QuanHeVoiNguoiBenh));
                Command.Parameters.Add(new MDB.MDBParameter("QuanHeNguoiLamPhieu", ketQua.QuanHeNguoiLamPhieu));
                Command.Parameters.Add(new MDB.MDBParameter("TenBenhNhan", ketQua.TenBenhNhan));

                Command.Parameters.Add(new MDB.MDBParameter("BacSi", ketQua.BacSi));
                Command.Parameters.Add(new MDB.MDBParameter("MaBacSi", ketQua.MaBacSi));

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
