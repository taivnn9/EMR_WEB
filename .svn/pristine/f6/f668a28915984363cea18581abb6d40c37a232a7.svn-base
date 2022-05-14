
using EMR.KyDienTu;
using Newtonsoft.Json;
using PMS.Access;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;

namespace EMR_MAIN.DATABASE.Other
{
    public class PhieuDoChucNangHoHap : ThongTinKy
    {
        public PhieuDoChucNangHoHap()
        {
            TableName = "PhieuDoChucNangHoHap";
            TablePrimaryKeyName = "ID";
            IDMauPhieu = (int)DanhMucPhieu.PDCNHH;
            TenMauPhieu = DanhMucPhieu.PDCNHH.Description();
        }
        [MoTaDuLieu("Mã định danh")]
		public long ID { get; set; }
        [MoTaDuLieu("Mã quản lý: mã duy nhất trong 1 đợt khám chữa bệnh (kcb), không trùng giữa các đợt kcb khác nhau","",1)]
		public decimal MaQuanLy { get; set; }
        [MoTaDuLieu("Mã bệnh nhân")]
		public string MaBenhNhan { get; set; }
        [MoTaDuLieu("Khoa")]
		public string Khoa { get; set; }
        [MoTaDuLieu("Buồng")]
		public string Buong { get; set; }
        [MoTaDuLieu("Giường")]
		public string Giuong { get; set; }    
        public string LanThu { get; set; }
        public string SoVaoVien { get; set; }
        [MoTaDuLieu("Họ và tên bệnh nhân")]
		public string TenBenhNhan { get; set; }
        [MoTaDuLieu("Tuổi bệnh nhân")]
		public string Tuoi { get; set; }
        [MoTaDuLieu("Giới tính bệnh nhân")]
		public string GioiTinh { get; set; }
        [MoTaDuLieu("Chẩn đoán bệnh")]
		public string ChanDoan { get; set; }
        [MoTaDuLieu("Địa chỉ nhà bệnh nhân")]
		public string DiaChi { get; set; }
        public DateTime? NgayLamPhieu { get; set; }
      
        public string MaBacSiDieuTri { get; set; }
        [MoTaDuLieu("Bác sỹ điều trị")]
		public string BacSiDieuTri { get; set; }
        public string MaBacSiChuyenKhoa { get; set; }
        public string BacSiChuyenKhoa { get; set; }


        public ObservableCollection<ChucNangHoHap> ListChucNang { get; set; }

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

    public class ChucNangHoHap
    {
        public string TenChucNang { get; set; }
        public string DungTichSong { get; set; }
        public string DTThoRa { get; set; }
        public string TiSo { get; set; }
        public string ThongKhi { get; set; }
        public string KhiDuTru { get; set; }

    }
    public class PhieuDoChucNangHoHapFunc
    {
        public const string TableName = "PhieuDoChucNangHoHap";
        public const string TablePrimaryKeyName = "ID";

        public static List<PhieuDoChucNangHoHap> GetListData(MDB.MDBConnection _OracleConnection, decimal maquanly)
        {
            List<PhieuDoChucNangHoHap> list = new List<PhieuDoChucNangHoHap>();
            try
            {
                string sql = @"SELECT * FROM PhieuDoChucNangHoHap where MaQuanLy = :MaQuanLy";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, _OracleConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", maquanly));
                MDB.MDBDataReader DataReader = Command.ExecuteReader();
                while (DataReader.Read())
                {
                    PhieuDoChucNangHoHap data = new PhieuDoChucNangHoHap();
                    data.ID = Convert.ToInt64(DataReader.GetLong("ID").ToString());
                    data.MaQuanLy = maquanly;

                    data.MaBenhNhan = XemBenhAn._HanhChinhBenhNhan.MaBenhNhan;
                    data.TenBenhNhan = XemBenhAn._HanhChinhBenhNhan.TenBenhNhan;
                    data.Tuoi = XemBenhAn._HanhChinhBenhNhan.Tuoi;
                    data.Khoa = XemBenhAn._ThongTinDieuTri.Khoa;
                    data.GioiTinh = XemBenhAn._HanhChinhBenhNhan.GioiTinh.Description();

                    data.LanThu = DataReader["LanThu"].ToString();
                    data.SoVaoVien = DataReader["SoVaoVien"].ToString();
                    data.ChanDoan = DataReader["ChanDoan"].ToString();
                    data.DiaChi = DataReader["DiaChi"].ToString();
                    data.Buong = DataReader["Buong"].ToString();
                    data.Giuong = DataReader["Giuong"].ToString();
                    data.MaBacSiChuyenKhoa = DataReader["MaBacSiChuyenKhoa"].ToString();
                    data.BacSiChuyenKhoa = DataReader["BacSiChuyenKhoa"].ToString();
                    data.MaBacSiDieuTri = DataReader["MaBacSiDieuTri"].ToString();
                    data.BacSiDieuTri = DataReader["BacSiDieuTri"].ToString();
                    
                    data.NgayLamPhieu = Convert.ToDateTime(DataReader["NgayLamPhieu"] == DBNull.Value ? DateTime.Now : DataReader["NgayLamPhieu"]);
                    data.ListChucNang = JsonConvert.DeserializeObject<ObservableCollection<ChucNangHoHap>>(DataReader["ListChucNang"].ToString());

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
                sql = @"DELETE FROM PhieuDoChucNangHoHap WHERE ID =" + IDBienBan;
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
                PhieuDoChucNangHoHap P
            WHERE
                ID = " + IDBienBan;

            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
            MDB.MDBDataAdapter adt = new MDB.MDBDataAdapter(Command);
            var ds = new DataSet();

            adt.Fill(ds, "TB");

            ds.Tables[0].AddColumn("TenBenhNhan", typeof(string));
            ds.Tables[0].AddColumn("Tuoi", typeof(string));
            ds.Tables[0].AddColumn("GioiTinh", typeof(string));
            ds.Tables[0].AddColumn("SoYTe", typeof(string));
            ds.Tables[0].AddColumn("BenhVien", typeof(string));
            ds.Tables[0].AddColumn("Khoa", typeof(string));
            ds.Tables[0].Rows[0]["TenBenhNhan"] = XemBenhAn._HanhChinhBenhNhan.TenBenhNhan;
            ds.Tables[0].Rows[0]["Tuoi"] = XemBenhAn._HanhChinhBenhNhan.Tuoi;
            ds.Tables[0].Rows[0]["GioiTinh"] = XemBenhAn._HanhChinhBenhNhan.GioiTinh.Description();
            ds.Tables[0].Rows[0]["SoYTe"] = XemBenhAn._HanhChinhBenhNhan.SoYTe;
            ds.Tables[0].Rows[0]["BenhVien"] = XemBenhAn._HanhChinhBenhNhan.BenhVien;
            ds.Tables[0].Rows[0]["Khoa"] = XemBenhAn._ThongTinDieuTri.Khoa;

           
            ObservableCollection<ChucNangHoHap> ListChucNang = JsonConvert.DeserializeObject<ObservableCollection<ChucNangHoHap>>(ds.Tables[0].Rows[0]["ListChucNang"].ToString());
            DataTable DT = Common.ListToDataTable(ListChucNang, "CN");
            ds.Tables.Add(DT);

            return ds;
        }
        public static bool InsertOrUpdate(MDB.MDBConnection MyConnection, ref PhieuDoChucNangHoHap ketQua)
        {
            try
            {
                string sql = @"INSERT INTO PhieuDoChucNangHoHap
                (
                    MaQuanLy,
                    LanThu,
                    SoVaoVien,
                    DiaChi,
                    Buong,
                    Giuong,
                    ChanDoan,
                    ListChucNang,
                    MaBacSiDieuTri,
                    BacSiDieuTri,
                    MaBacSiChuyenKhoa,
                    BacSiChuyenKhoa,
                    NgayLamPhieu,
                    NGUOITAO,
                    NGUOISUA,
                    NGAYTAO,
                    NGAYSUA)  VALUES
                 (
				    :MaQuanLy,
                    :LanThu,
                    :SoVaoVien,
                    :DiaChi,
                    :Buong,
                    :Giuong,
                    :ChanDoan,
                    :ListChucNang,
                    :MaBacSiDieuTri,
                    :BacSiDieuTri,
                    :MaBacSiChuyenKhoa,
                    :BacSiChuyenKhoa,
                    :NgayLamPhieu,
                    :NGUOITAO,
                    :NGUOISUA,
                    :NGAYTAO,
                    :NGAYSUA
                 )  RETURNING ID INTO :ID";
                if (ketQua.ID != 0)
                {
                    sql = @"UPDATE PhieuDoChucNangHoHap SET 
                    MaQuanLy = :MaQuanLy,
                    LanThu = :LanThu,
                    SoVaoVien = :SoVaoVien,
                    DiaChi = :DiaChi,
                    Buong = :Buong,
                    Giuong = :Giuong,
                    ChanDoan = :ChanDoan,
                    ListChucNang = :ListChucNang,
                    MaBacSiDieuTri = :MaBacSiDieuTri,
                    BacSiDieuTri = :BacSiDieuTri,
                    MaBacSiChuyenKhoa = :MaBacSiChuyenKhoa,
                    BacSiChuyenKhoa = :BacSiChuyenKhoa,
                    NgayLamPhieu = :NgayLamPhieu,
                    NGUOISUA = :NGUOISUA,
                    NGAYSUA = :NGAYSUA 
                    WHERE ID = " + ketQua.ID;
                }
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);

                Command.Parameters.Add(new MDB.MDBParameter("NGUOISUA", ketQua.NguoiSua));
                Command.Parameters.Add(new MDB.MDBParameter("NGAYSUA", ketQua.NgaySua));

                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", ketQua.MaQuanLy));

                Command.Parameters.Add(new MDB.MDBParameter("LanThu", ketQua.LanThu));
                Command.Parameters.Add(new MDB.MDBParameter("SoVaoVien", ketQua.SoVaoVien));
                Command.Parameters.Add(new MDB.MDBParameter("DiaChi", ketQua.DiaChi));
                Command.Parameters.Add(new MDB.MDBParameter("Buong", ketQua.Buong));
                Command.Parameters.Add(new MDB.MDBParameter("Giuong", ketQua.Giuong));
                Command.Parameters.Add(new MDB.MDBParameter("ChanDoan", ketQua.ChanDoan));
                Command.Parameters.Add(new MDB.MDBParameter("ListChucNang", JsonConvert.SerializeObject(ketQua.ListChucNang)));
                Command.Parameters.Add(new MDB.MDBParameter("MaBacSiDieuTri", ketQua.MaBacSiDieuTri));
                Command.Parameters.Add(new MDB.MDBParameter("BacSiDieuTri", ketQua.BacSiDieuTri));
                Command.Parameters.Add(new MDB.MDBParameter("MaBacSiChuyenKhoa", ketQua.MaBacSiChuyenKhoa));
                Command.Parameters.Add(new MDB.MDBParameter("BacSiChuyenKhoa", ketQua.BacSiChuyenKhoa));
                Command.Parameters.Add(new MDB.MDBParameter("NgayLamPhieu", ketQua.NgayLamPhieu));

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
