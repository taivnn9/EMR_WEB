
using EMR.KyDienTu;
using PMS.Access;
using System;
using System.Collections.Generic;
using System.Data;

namespace EMR_MAIN.DATABASE.Other
{
    public class GiayGioiThieuBenhNhanMDR : ThongTinKy
    {
        public GiayGioiThieuBenhNhanMDR()
        {
            TableName = "GiayGioiThieuBenhNhanMDR";
            TablePrimaryKeyName = "ID";
            IDMauPhieu = (int)DanhMucPhieu.GGTBNMDR;
            TenMauPhieu = DanhMucPhieu.GGTBNMDR.Description();
        }
        [MoTaDuLieu("Mã định danh")]
		public long ID { get; set; }
        [MoTaDuLieu("Mã quản lý: mã duy nhất trong 1 đợt khám chữa bệnh (kcb), không trùng giữa các đợt kcb khác nhau","",1)]
		public decimal MaQuanLy { get; set; }
        [MoTaDuLieu("Mã bệnh nhân")]
		public string MaBenhNhan { get; set; }
        [MoTaDuLieu("Mã bệnh án")]
		public string MaBenhAn { get; set; }
        [MoTaDuLieu("Sở Y Tế")]
		public string SoYTe { get; set; }
        [MoTaDuLieu("Bệnh viện")]
		public string BenhVien { get; set; }
        public string MaSo { get; set; }
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
        public string SoDangKiDieuTri { get; set; }
        public string PhacDoDieuTri { get; set; }
        public string NgayBatDauDieuTri { get; set; }
        public string HienTai { get; set; }
        public string XetNghiem { get; set; }
        public string BenhVienGioiThieu { get; set; }
        public string BenhVienTiepNhan { get; set; }

        [MoTaDuLieu("Ngày vào bệnh viện")]
		public DateTime NgayVaoVien { get; set; }
        public DateTime NgayBatDauDieuTriLao { get; set; }
        public DateTime NgayKetThucDieuTriLao { get; set; }
        [MoTaDuLieu("Mã trưởng khoa")]
		public string MaNVTruongKhoa { get; set; }
        [MoTaDuLieu("Mã bác sỹ điều trị")]
		public string MaNVBacSiDieuTri { get; set; }

        [MoTaDuLieu("Trưởng khoa")]
		public string TruongKhoa { get; set; }
        [MoTaDuLieu("Bác sỹ điều trị")]
		public string BacSiDieuTri { get; set; }

        public string MaNVGiamDocBenhVien { get; set; }
        public string MaNVPhongChiDaoTuyen { get; set; }

        public string GiamDocBenhVien { get; set; }
        public string PhongChiDaoTuyen { get; set; }

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
    public class GiayGioiThieuBenhNhanMDRFunc
    {
        public const string TableName = "GiayGioiThieuBenhNhanMDR";
        public const string TablePrimaryKeyName = "ID";

        public static List<GiayGioiThieuBenhNhanMDR> GetListData(MDB.MDBConnection _OracleConnection, decimal maquanly)
        {
            List<GiayGioiThieuBenhNhanMDR> list = new List<GiayGioiThieuBenhNhanMDR>();
            try
            {
                string sql = @"SELECT * FROM GiayGioiThieuBenhNhanMDR where MaQuanLy = :MaQuanLy";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, _OracleConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", maquanly));
                MDB.MDBDataReader DataReader = Command.ExecuteReader();
                while (DataReader.Read())
                {
                    GiayGioiThieuBenhNhanMDR data = new GiayGioiThieuBenhNhanMDR();
                    data.ID = Convert.ToInt64(DataReader.GetLong("ID").ToString());
                    data.MaQuanLy = maquanly;

                    data.MaBenhNhan = XemBenhAn._HanhChinhBenhNhan.MaBenhNhan;
                    data.MaBenhAn = XemBenhAn._ThongTinDieuTri.MaBenhAn;
                    data.TenBenhNhan = XemBenhAn._HanhChinhBenhNhan.TenBenhNhan;
                    data.Tuoi = XemBenhAn._HanhChinhBenhNhan.Tuoi;
                    data.GioiTinh = XemBenhAn._HanhChinhBenhNhan.GioiTinh.Description();
                    data.DiaChi = Common.GetDiaChi();
                    data.ChanDoan = XemBenhAn._ThongTinDieuTri.ChanDoan_KhiVaoKhoaDieuTri;
                    data.SoYTe = XemBenhAn._HanhChinhBenhNhan.SoYTe;
                    data.BenhVien = XemBenhAn._HanhChinhBenhNhan.BenhVien;
                    data.SoVaoVien = XemBenhAn._ThongTinDieuTri.SoNhapVien;

                    data.SoDangKiDieuTri = DataReader["SoDangKiDieuTri"].ToString();
                    data.PhacDoDieuTri = DataReader["PhacDoDieuTri"].ToString();
                    data.NgayBatDauDieuTri = DataReader["NgayBatDauDieuTri"].ToString();
                    data.HienTai = DataReader["HienTai"].ToString();
                    data.XetNghiem = DataReader["XetNghiem"].ToString();
                    data.ChanDoan = DataReader["ChanDoan"].ToString();

                    data.BenhVienGioiThieu = DataReader["BenhVienGioiThieu"].ToString();
                    data.BenhVienTiepNhan = DataReader["BenhVienTiepNhan"].ToString();
                    data.MaNVTruongKhoa = DataReader["MaNVTruongKhoa"].ToString();
                    data.MaNVBacSiDieuTri = DataReader["MaNVBacSiDieuTri"].ToString();
                    data.MaNVPhongChiDaoTuyen = DataReader["MaNVPhongChiDaoTuyen"].ToString();
                    data.MaNVGiamDocBenhVien = DataReader["MaNVGiamDocBenhVien"].ToString();
                    data.TruongKhoa = DataReader["TruongKhoa"].ToString();
                    data.BacSiDieuTri = DataReader["BacSiDieuTri"].ToString();
                    data.GiamDocBenhVien = DataReader["GiamDocBenhVien"].ToString();
                    data.PhongChiDaoTuyen = DataReader["PhongChiDaoTuyen"].ToString();

                    data.NgayVaoVien = Convert.ToDateTime(DataReader["NgayVaoVien"] == DBNull.Value ? DateTime.Now : DataReader["NgayVaoVien"]);
                    data.NgayBatDauDieuTriLao = Convert.ToDateTime(DataReader["NgayBatDauDieuTriLao"] == DBNull.Value ? DateTime.Now : DataReader["NgayBatDauDieuTriLao"]);
                    data.NgayKetThucDieuTriLao = Convert.ToDateTime(DataReader["NGAYTAO"] == DBNull.Value ? DateTime.Now : DataReader["NgayKetThucDieuTriLao"]);


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
                sql = @"DELETE FROM GiayGioiThieuBenhNhanMDR WHERE ID =" + IDBienBan;
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
            string sql = @"SELECT P.*, T.SoNhapVien, T.Khoa , T.NgayVaoVien ,  T.MaKhoa, T.MaBenhAn, T.Giuong, T.Buong,            
				H.TUOI,H.SoYTe, H.BENHVIEN, 
				 H.GIOITINH,  H.TenBenhNhan, H.maBenhNhan
			  FROM GiayGioiThieuBenhNhanMDR P 
				Left JOIN THONGTINDIEUTRI T ON P.MAQUANLY = T.MAQUANLY
				Left JOIN HANHCHINHBENHNHAN H ON T.MABENHNHAN = H.MABENHNHAN
			  where ID = :IDPhieu";
            MDB.MDBCommand Command;
            MDB.MDBDataAdapter adt;
            using (Command = new MDB.MDBCommand(sql, MyConnection))
            {
                Command.Parameters.Add(new MDB.MDBParameter("IDPhieu", IDBienBan));
                adt = new MDB.MDBDataAdapter(Command);
            }
            var ds = new DataSet();
            adt.Fill(ds, "TBL");
            DateTime NgayBatDauDieuTriLao = ds.Tables[0].Rows[0]["NgayBatDauDieuTriLao"].ToDateTime();
            DateTime NgayKetThucDieuTriLao = ds.Tables[0].Rows[0]["NgayKetThucDieuTriLao"].ToDateTime();

            ds.Tables[0].AddColumn("NgayThang", typeof(string));
            ds.Tables[0].AddColumn("DiaChi", typeof(string));
            ds.Tables[0].AddColumn("SoNgay", typeof(double));
            ds.Tables[0].AddColumn("NgayBatDauDieuTriLaoFormat", typeof(string));
            ds.Tables[0].AddColumn("NgayKetThucDieuTriLaoFormat", typeof(string));

            ds.Tables[0].Rows[0]["DiaChi"] = Common.GetDiaChi();
            ds.Tables[0].Rows[0]["SoNgay"] = (NgayKetThucDieuTriLao - NgayKetThucDieuTriLao).TotalDays;
            ds.Tables[0].Rows[0]["NgayBatDauDieuTriLaoFormat"] = NgayBatDauDieuTriLao.ToString("dd/MM/yyyy");
            ds.Tables[0].Rows[0]["NgayKetThucDieuTriLaoFormat"] = NgayKetThucDieuTriLao.ToString("dd/MM/yyyy");
            ds.Tables[0].Rows[0]["NgayThang"] = "Ngày " + DateTime.Now.Day + " tháng " + DateTime.Now.Month + " năm " + DateTime.Now.Year;
            return ds;
        }
        public static bool InsertOrUpdate(MDB.MDBConnection MyConnection, ref GiayGioiThieuBenhNhanMDR ketQua)
        {
            try
            {
                string sql = @"INSERT INTO GiayGioiThieuBenhNhanMDR
                (
                    MaQuanLy,
                    SoDangKiDieuTri,
                    PhacDoDieuTri,
                    NgayBatDauDieuTri,
                    HienTai,
                    ChanDoan,
                    XetNghiem,
                    BenhVienGioiThieu,
                    BenhVienTiepNhan,
                    NgayVaoVien,
                    NgayBatDauDieuTriLao,
                    NgayKetThucDieuTriLao,
                    MaNVTruongKhoa,
                    MaNVBacSiDieuTri,
                    MaNVGiamDocBenhVien,
                    MaNVPhongChiDaoTuyen,
                    TruongKhoa,
                    BacSiDieuTri,
                    GiamDocBenhVien,
                    PhongChiDaoTuyen,
                    NGUOITAO,
                    NGUOISUA,
                    NGAYTAO,
                    NGAYSUA)  VALUES
                 (
				    :MaQuanLy,
                    :SoDangKiDieuTri,
                    :PhacDoDieuTri,
                    :NgayBatDauDieuTri,
                    :HienTai,
                    :ChanDoan,
                    :XetNghiem,
                    :BenhVienGioiThieu,
                    :BenhVienTiepNhan,
                    :NgayVaoVien,
                    :NgayBatDauDieuTriLao,
                    :NgayKetThucDieuTriLao,
                    :MaNVTruongKhoa,
                    :MaNVBacSiDieuTri,
                    :MaNVGiamDocBenhVien,
                    :MaNVPhongChiDaoTuyen,
                    :TruongKhoa,
                    :BacSiDieuTri,
                    :GiamDocBenhVien,
                    :PhongChiDaoTuyen,
                    :NGUOITAO,
                    :NGUOISUA,
                    :NGAYTAO,
                    :NGAYSUA
                 )  RETURNING ID INTO :ID";
                if (ketQua.ID != 0)
                {
                    sql = @"UPDATE GiayGioiThieuBenhNhanMDR SET 
                    MaQuanLy = :MaQuanLy,
                    SoDangKiDieuTri = :SoDangKiDieuTri,
                    PhacDoDieuTri = :PhacDoDieuTri,
                    NgayBatDauDieuTri = :NgayBatDauDieuTri,
                    HienTai = :HienTai,
                    ChanDoan = :ChanDoan,
                    BenhVienGioiThieu = :BenhVienGioiThieu,
                    BenhVienTiepNhan = :BenhVienTiepNhan,
                    XetNghiem = :XetNghiem,
                    NgayVaoVien = :NgayVaoVien,
                    NgayBatDauDieuTriLao = :NgayBatDauDieuTriLao,
                    NgayKetThucDieuTriLao = :NgayKetThucDieuTriLao,
                    MaNVTruongKhoa = :MaNVTruongKhoa,
                    MaNVBacSiDieuTri = :MaNVBacSiDieuTri,
                    MaNVGiamDocBenhVien = :MaNVGiamDocBenhVien,
                    MaNVPhongChiDaoTuyen = :MaNVPhongChiDaoTuyen,
                    TruongKhoa = :TruongKhoa,
                    BacSiDieuTri = :BacSiDieuTri,
                    GiamDocBenhVien = :GiamDocBenhVien,
                    PhongChiDaoTuyen = :PhongChiDaoTuyen,
                    NGUOISUA = :NGUOISUA,
                    NGAYSUA = :NGAYSUA 
                    WHERE ID = " + ketQua.ID;
                }
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);

                Command.Parameters.Add(new MDB.MDBParameter("NGUOISUA", ketQua.NguoiSua));
                Command.Parameters.Add(new MDB.MDBParameter("NGAYSUA", ketQua.NgaySua));

                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", ketQua.MaQuanLy));

                Command.Parameters.Add(new MDB.MDBParameter("SoDangKiDieuTri", ketQua.SoDangKiDieuTri));
                Command.Parameters.Add(new MDB.MDBParameter("PhacDoDieuTri", ketQua.PhacDoDieuTri));
                Command.Parameters.Add(new MDB.MDBParameter("NgayBatDauDieuTri", ketQua.NgayBatDauDieuTri));
                Command.Parameters.Add(new MDB.MDBParameter("HienTai", ketQua.HienTai));
                Command.Parameters.Add(new MDB.MDBParameter("ChanDoan", ketQua.ChanDoan));
                Command.Parameters.Add(new MDB.MDBParameter("BenhVienGioiThieu", ketQua.BenhVienGioiThieu));
                Command.Parameters.Add(new MDB.MDBParameter("BenhVienTiepNhan", ketQua.BenhVienTiepNhan));
                Command.Parameters.Add(new MDB.MDBParameter("XetNghiem", ketQua.XetNghiem));
                Command.Parameters.Add(new MDB.MDBParameter("NgayVaoVien", ketQua.NgayVaoVien));
                Command.Parameters.Add(new MDB.MDBParameter("NgayBatDauDieuTriLao", ketQua.NgayBatDauDieuTriLao));
                Command.Parameters.Add(new MDB.MDBParameter("NgayKetThucDieuTriLao", ketQua.NgayKetThucDieuTriLao));
                Command.Parameters.Add(new MDB.MDBParameter("MaNVTruongKhoa", ketQua.MaNVTruongKhoa));
                Command.Parameters.Add(new MDB.MDBParameter("MaNVBacSiDieuTri", ketQua.MaNVBacSiDieuTri));
                Command.Parameters.Add(new MDB.MDBParameter("MaNVGiamDocBenhVien", ketQua.MaNVGiamDocBenhVien));
                Command.Parameters.Add(new MDB.MDBParameter("MaNVPhongChiDaoTuyen", ketQua.MaNVPhongChiDaoTuyen));
                Command.Parameters.Add(new MDB.MDBParameter("TruongKhoa", ketQua.TruongKhoa));
                Command.Parameters.Add(new MDB.MDBParameter("BacSiDieuTri", ketQua.BacSiDieuTri));
                Command.Parameters.Add(new MDB.MDBParameter("GiamDocBenhVien", ketQua.GiamDocBenhVien));
                Command.Parameters.Add(new MDB.MDBParameter("PhongChiDaoTuyen", ketQua.PhongChiDaoTuyen));

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
       
        public static string ConDBNull(object dbVal)
        {
            string ret = "";
            if (dbVal == null)
            {
                return ret;
            }
            ret = dbVal.ToString();
            return ret;
        }
        public static decimal ConDB_Decimal(object dbVal, decimal valDefault = 0)
        {
            decimal ret = valDefault;
            if (dbVal == null)
            {
                return ret;
            }
            bool isSuccess = decimal.TryParse(dbVal.ToString(), out ret);
            if (!isSuccess)
            {
                return valDefault;
            }
            return ret;
        }
        public static int ConDB_Int(object dbVal, int valDefault = 0)
        {
            int ret = valDefault;
            if (dbVal == null)
            {
                return ret;
            }
            bool isSuccess = int.TryParse(dbVal.ToString(), out ret);
            if (!isSuccess)
            {
                return valDefault;
            }
            return ret;
        }
        public static DateTime ConDB_DateTime(object dbVal)
        {
            DateTime ret = DateTime.MinValue;
            if (dbVal == null)
            {
                return ret;
            }
            bool isSuccess = DateTime.TryParse(dbVal.ToString(), out ret);
            return ret;
        }
    }
}
