
using EMR.KyDienTu;
using PMS.Access;
using System;
using System.Collections.Generic;
using System.Data;

namespace EMR_MAIN.DATABASE.Other
{
    public class GiayGTDTTCBNLaoKhangThuoc : ThongTinKy
    {
        public GiayGTDTTCBNLaoKhangThuoc()
        {
            TableName = "GiayGTDTTCBNLaoKhangThuoc";
            TablePrimaryKeyName = "ID";
            IDMauPhieu = (int)DanhMucPhieu.GGTDTTCBNLKT;
            TenMauPhieu = DanhMucPhieu.GGTDTTCBNLKT.Description();
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
        [MoTaDuLieu("Họ và tên bệnh nhân")]
		public string TenBenhNhan { get; set; }
        [MoTaDuLieu("Tuổi bệnh nhân")]
		public string Tuoi { get; set; }
        [MoTaDuLieu("Giới tính bệnh nhân")]
		public string GioiTinh { get; set; }
        public string SoVaoVien { get; set; }
        public string ThoiGianText { get; set; }
        public DateTime? ThoiGian { get; set; }
        public string KinhGui { get; set; }
        [MoTaDuLieu("Địa chỉ nhà bệnh nhân")]
		public string DiaChi { get; set; }
        public DateTime? NgayVaoVien { get; set; }
        public string DieuTri { get; set; }
        [MoTaDuLieu("Chẩn đoán bệnh")]
		public string ChanDoan { get; set; }
        public string SoDangKi { get; set; }
        public string PhacDoDieuTri { get; set; }
        public string NgayBatDauDieuTri { get; set; }
        public string HienTai { get; set; }
        public string KetQuaXetNghiem { get; set; }
        public string LyDo { get; set; }
        public string MaGiamDocBenhVien { get; set; }
        public string GiamDocBenhVien { get; set; }
        public string MaPhongKHTH { get; set; }
        public string PhongKHTH { get; set; }
        [MoTaDuLieu("Mã trưởng khoa")]
		public string MaTruongKhoa { get; set; }
        [MoTaDuLieu("Trưởng khoa")]
		public string TruongKhoa { get; set; }
        public string MaBacSiDieuTri { get; set; }
        [MoTaDuLieu("Bác sỹ điều trị")]
		public string BacSiDieuTri { get; set; }

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
    public class GiayGTDTTCBNLaoKhangThuocFunc
    {
        public const string TableName = "GiayGTDTTCBNLaoKhangThuoc";
        public const string TablePrimaryKeyName = "ID";

        public static List<GiayGTDTTCBNLaoKhangThuoc> GetListData(MDB.MDBConnection _OracleConnection, decimal maquanly)
        {
            List<GiayGTDTTCBNLaoKhangThuoc> list = new List<GiayGTDTTCBNLaoKhangThuoc>();
            try
            {
                string sql = @"SELECT * FROM GiayGTDTTCBNLaoKhangThuoc where MaQuanLy = :MaQuanLy";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, _OracleConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", maquanly));
                MDB.MDBDataReader DataReader = Command.ExecuteReader();
                while (DataReader.Read())
                {
                    GiayGTDTTCBNLaoKhangThuoc data = new GiayGTDTTCBNLaoKhangThuoc();
                    data.ID = Convert.ToInt64(DataReader.GetLong("ID").ToString());
                    data.MaQuanLy = maquanly;

                    data.MaBenhNhan = XemBenhAn._HanhChinhBenhNhan.MaBenhNhan;
                    data.TenBenhNhan = XemBenhAn._HanhChinhBenhNhan.TenBenhNhan;
                    data.Tuoi = XemBenhAn._HanhChinhBenhNhan.Tuoi;
                    data.GioiTinh = XemBenhAn._HanhChinhBenhNhan.GioiTinh.Description();
                    data.SoYTe = XemBenhAn._HanhChinhBenhNhan.SoYTe;
                    data.BenhVien = XemBenhAn._HanhChinhBenhNhan.BenhVien;

                    data.SoVaoVien = DataReader["SoVaoVien"].ToString();
                    data.ThoiGianText = DataReader["ThoiGianText"].ToString();
                    data.ThoiGian = Convert.ToDateTime(DataReader["ThoiGian"] == DBNull.Value ? DateTime.Now : DataReader["ThoiGian"]);
                    data.KinhGui = DataReader["KinhGui"].ToString();

                    data.DiaChi = DataReader["DiaChi"].ToString();
                    data.NgayVaoVien = Convert.ToDateTime(DataReader["NgayVaoVien"] == DBNull.Value ? DateTime.Now : DataReader["NgayVaoVien"]);

                    data.ChanDoan = DataReader["ChanDoan"].ToString();
                    data.SoDangKi = DataReader["SoDangKi"].ToString();
                    data.PhacDoDieuTri = DataReader["PhacDoDieuTri"].ToString();
                    data.NgayBatDauDieuTri = DataReader["NgayBatDauDieuTri"].ToString();
                    data.HienTai = DataReader["HienTai"].ToString();
                    data.KetQuaXetNghiem = DataReader["KetQuaXetNghiem"].ToString();
                    data.LyDo = DataReader["LyDo"].ToString();

                    data.GiamDocBenhVien = DataReader["GiamDocBenhVien"].ToString();
                    data.MaGiamDocBenhVien = DataReader["MaGiamDocBenhVien"].ToString();
                    data.MaPhongKHTH = DataReader["MaPhongKHTH"].ToString();
                    data.PhongKHTH = DataReader["PhongKHTH"].ToString();
                    data.MaTruongKhoa = DataReader["MaTruongKhoa"].ToString();
                    data.TruongKhoa = DataReader["TruongKhoa"].ToString();
                    data.BacSiDieuTri = DataReader["BacSiDieuTri"].ToString();
                    data.MaBacSiDieuTri = DataReader["MaBacSiDieuTri"].ToString();

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
                sql = @"DELETE FROM GiayGTDTTCBNLaoKhangThuoc WHERE ID =" + IDBienBan;
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
                GiayGTDTTCBNLaoKhangThuoc P
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
            ds.Tables[0].AddColumn("ThoiGianFull", typeof(string));
            ds.Tables[0].Rows[0]["TenBenhNhan"] = XemBenhAn._HanhChinhBenhNhan.TenBenhNhan;
            ds.Tables[0].Rows[0]["Tuoi"] = XemBenhAn._HanhChinhBenhNhan.Tuoi;
            ds.Tables[0].Rows[0]["GioiTinh"] = XemBenhAn._HanhChinhBenhNhan.GioiTinh.Description();
            ds.Tables[0].Rows[0]["SoYTe"] = XemBenhAn._HanhChinhBenhNhan.SoYTe;
            ds.Tables[0].Rows[0]["BenhVien"] = XemBenhAn._HanhChinhBenhNhan.BenhVien;
            DateTime ThoiGian = ds.Tables[0].Rows[0]["ThoiGian"].ToDateTime();
            string ThoiGianText = ds.Tables[0].Rows[0]["ThoiGianText"].ToString();
            ds.Tables[0].Rows[0]["ThoiGianFull"] = ThoiGianText + ", ngày " + ThoiGian.Day + " tháng " + ThoiGian.Month + " năm " + ThoiGian.Year;

            return ds;
        }
        public static bool InsertOrUpdate(MDB.MDBConnection MyConnection, ref GiayGTDTTCBNLaoKhangThuoc ketQua)
        {
            try
            {
                string sql = @"INSERT INTO GiayGTDTTCBNLaoKhangThuoc
                (
                    MaQuanLy,
                    SoVaoVien,
                    ThoiGianText,
                    ThoiGian,
                    KinhGui,
                    DiaChi,
                    NgayVaoVien,
                    ChanDoan,
                    SoDangKi,
                    PhacDoDieuTri,
                    NgayBatDauDieuTri,
                    HienTai,
                    KetQuaXetNghiem,
                    LyDo,
                    MaGiamDocBenhVien,
                    GiamDocBenhVien,
                    MaPhongKHTH,
                    PhongKHTH,
                    MaTruongKhoa,
                    TruongKhoa,
                    MaBacSiDieuTri,
                    BacSiDieuTri,
                    NGUOITAO,
                    NGUOISUA,
                    NGAYTAO,
                    NGAYSUA)  VALUES
                 (
				    :MaQuanLy,
                    :SoVaoVien,
                    :ThoiGianText,
                    :ThoiGian,
                    :KinhGui,
                    :DiaChi,
                    :NgayVaoVien,
                    :ChanDoan,
                    :SoDangKi,
                    :PhacDoDieuTri,
                    :NgayBatDauDieuTri,
                    :HienTai,
                    :KetQuaXetNghiem,
                    :LyDo,
                    :MaGiamDocBenhVien,
                    :GiamDocBenhVien,
                    :MaPhongKHTH,
                    :PhongKHTH,
                    :MaTruongKhoa,
                    :TruongKhoa,
                    :MaBacSiDieuTri,
                    :BacSiDieuTri,
                    :NGUOITAO,
                    :NGUOISUA,
                    :NGAYTAO,
                    :NGAYSUA
                 )  RETURNING ID INTO :ID";
                if (ketQua.ID != 0)
                {
                    sql = @"UPDATE GiayGTDTTCBNLaoKhangThuoc SET 
                    MaQuanLy = :MaQuanLy,
                    SoVaoVien = :SoVaoVien,
                    ThoiGianText = :ThoiGianText,
                    ThoiGian = :ThoiGian,
                    KinhGui = :KinhGui,
                    DiaChi = :DiaChi,
                    NgayVaoVien = :NgayVaoVien,
                    ChanDoan = :ChanDoan,
                    SoDangKi = :SoDangKi,
                    PhacDoDieuTri = :PhacDoDieuTri,
                    NgayBatDauDieuTri = :NgayBatDauDieuTri,
                    HienTai = :HienTai,
                    KetQuaXetNghiem = :KetQuaXetNghiem,
                    LyDo = :LyDo,
                    MaGiamDocBenhVien = :MaGiamDocBenhVien,
                    GiamDocBenhVien = :GiamDocBenhVien,
                    MaPhongKHTH = :MaPhongKHTH,
                    PhongKHTH = :PhongKHTH,
                    MaTruongKhoa = :MaTruongKhoa,
                    TruongKhoa = :TruongKhoa,
                    MaBacSiDieuTri = :MaBacSiDieuTri,
                    BacSiDieuTri = :BacSiDieuTri,
                    NGUOISUA = :NGUOISUA,
                    NGAYSUA = :NGAYSUA 
                    WHERE ID = " + ketQua.ID;
                }
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);

                Command.Parameters.Add(new MDB.MDBParameter("NGUOISUA", ketQua.NguoiSua));
                Command.Parameters.Add(new MDB.MDBParameter("NGAYSUA", ketQua.NgaySua));

                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", ketQua.MaQuanLy));

                Command.Parameters.Add(new MDB.MDBParameter("SoVaoVien", ketQua.SoVaoVien));
                Command.Parameters.Add(new MDB.MDBParameter("ThoiGianText", ketQua.ThoiGianText));
                Command.Parameters.Add(new MDB.MDBParameter("ThoiGian", ketQua.ThoiGian));
                Command.Parameters.Add(new MDB.MDBParameter("KinhGui", ketQua.KinhGui));
                Command.Parameters.Add(new MDB.MDBParameter("DiaChi", ketQua.DiaChi));
                Command.Parameters.Add(new MDB.MDBParameter("NgayVaoVien", ketQua.NgayVaoVien));
                Command.Parameters.Add(new MDB.MDBParameter("ChanDoan", ketQua.ChanDoan));
                Command.Parameters.Add(new MDB.MDBParameter("SoDangKi", ketQua.SoDangKi));
                Command.Parameters.Add(new MDB.MDBParameter("PhacDoDieuTri", ketQua.PhacDoDieuTri));
                Command.Parameters.Add(new MDB.MDBParameter("NgayBatDauDieuTri", ketQua.NgayBatDauDieuTri));
                Command.Parameters.Add(new MDB.MDBParameter("HienTai", ketQua.HienTai));
                Command.Parameters.Add(new MDB.MDBParameter("KetQuaXetNghiem", ketQua.KetQuaXetNghiem));
                Command.Parameters.Add(new MDB.MDBParameter("LyDo", ketQua.LyDo));
                Command.Parameters.Add(new MDB.MDBParameter("MaGiamDocBenhVien", ketQua.MaGiamDocBenhVien));
                Command.Parameters.Add(new MDB.MDBParameter("GiamDocBenhVien", ketQua.GiamDocBenhVien));
                Command.Parameters.Add(new MDB.MDBParameter("MaPhongKHTH", ketQua.MaPhongKHTH));
                Command.Parameters.Add(new MDB.MDBParameter("MaPhongKHTH", ketQua.MaPhongKHTH));
                Command.Parameters.Add(new MDB.MDBParameter("PhongKHTH", ketQua.PhongKHTH));
                Command.Parameters.Add(new MDB.MDBParameter("MaTruongKhoa", ketQua.MaTruongKhoa));
                Command.Parameters.Add(new MDB.MDBParameter("TruongKhoa", ketQua.TruongKhoa));
                Command.Parameters.Add(new MDB.MDBParameter("MaBacSiDieuTri", ketQua.MaBacSiDieuTri));
                Command.Parameters.Add(new MDB.MDBParameter("BacSiDieuTri", ketQua.BacSiDieuTri));

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
