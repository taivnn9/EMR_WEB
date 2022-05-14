
using EMR.KyDienTu;
using PMS.Access;
using System;
using System.Collections.Generic;
using System.Data;

namespace EMR_MAIN.DATABASE.Other
{
    public class PhieuYeuCauNoiSoi : ThongTinKy
    {
        public PhieuYeuCauNoiSoi()
        {
            TableName = "PhieuYeuCauNoiSoi";
            TablePrimaryKeyName = "ID";
            IDMauPhieu = (int)DanhMucPhieu.PYCNS;
            TenMauPhieu = DanhMucPhieu.PYCNS.Description();
        }
        [MoTaDuLieu("Mã định danh")]
		public long ID { get; set; }
        [MoTaDuLieu("Mã quản lý: mã duy nhất trong 1 đợt khám chữa bệnh (kcb), không trùng giữa các đợt kcb khác nhau","",1)]
		public decimal MaQuanLy { get; set; }
        [MoTaDuLieu("Mã bệnh nhân")]
		public string MaBenhNhan { get; set; }
        [MoTaDuLieu("Khoa")]
		public string Khoa { get; set; }
        [MoTaDuLieu("Bệnh viện")]
		public string BenhVien { get; set; }
        [MoTaDuLieu("Họ và tên bệnh nhân")]
		public string TenBenhNhan { get; set; }
        [MoTaDuLieu("Giới tính bệnh nhân")]
		public string GioiTinh { get; set; }
        [MoTaDuLieu("Tuổi bệnh nhân")]
		public string Tuoi { get; set; }
        [MoTaDuLieu("Địa chỉ nhà bệnh nhân")]
		public string DiaChi { get; set; }
        public string DienThoai { get; set; }
        [MoTaDuLieu("Địa chỉ thư điện tử")]
		public string Email { get; set; }
      
        [MoTaDuLieu("Bác sỹ điều trị")]
		public string BacSiDieuTri { get; set; }
        public string MaBacSiDieuTri { get; set; }
        public string NSDD { get; set; }
        public string NSDT { get; set; }
        public string BLKhac { get; set; }
        public string SuDungThuocChongDong { get; set; }
        public string SuDungThuocDaDay { get; set; }
        public string TrieuChungChuYeu { get; set; }
        public int TrieuChungDD1 { get; set; }
        public int TrieuChungDD2 { get; set; }
        public int TrieuChungDD3 { get; set; }
        public int TrieuChungDD4 { get; set; }
        public int TrieuChungDD5 { get; set; }
        public int TrieuChungDD6 { get; set; }
        public int TrieuChungDD7 { get; set; }
        public int TrieuChungDD8 { get; set; }
        public int TrieuChungDD9 { get; set; }
        public int TrieuChungDD10 { get; set; }
        public int TrieuChungDD11 { get; set; }
        public string TC_Khac_DD { get; set; }
        public int TrieuChungDT1 { get; set; }
        public int TrieuChungDT2 { get; set; }
        public int TrieuChungDT3 { get; set; }
        public int TrieuChungDT4 { get; set; }
        public int TrieuChungDT5 { get; set; }
        public int TrieuChungDT6 { get; set; }
        public int TrieuChungDT7 { get; set; }
        public int TrieuChungDT8 { get; set; }
        public string TC_Khac_DT { get; set; }
        public string ViTri { get; set; }
        public string SoLanTieuLong { get; set; }
        public string TrieuChungBenhLy { get; set; }
        [MoTaDuLieu("Chẩn đoán trước nội soi")]
		public string ChanDoanTruocSoi { get; set; }
        public int NoiSoiChanDoan1 { get; set; }
        public int NoiSoiChanDoan2 { get; set; }
        public int NoiSoiChanDoan3 { get; set; }
        public int NoiSoiChanDoan4 { get; set; }
        public int NoiSoiChanDoan5 { get; set; }
        public int NoiSoiChanDoan6 { get; set; }
        public int NoiSoiChanDoan7 { get; set; }
        public int NoiSoiChanDoan8 { get; set; }
        public string NoiSoiChanDoan1_Text { get; set; }
        public string NoiSoiChanDoan2_Text { get; set; }
        public string NoiSoiChanDoan3_Text { get; set; }
        public string NoiSoiChanDoan4_Text { get; set; }
        public string NoiSoiChanDoan5_Text { get; set; }
        public string NoiSoiChanDoan6_Text { get; set; }
        public string NoiSoiChanDoan7_Text { get; set; }
        public string NoiSoiChanDoan8_Text { get; set; }
        public int ThuThuatNoiSoi1 { get; set; }
        public int ThuThuatNoiSoi2 { get; set; }
        public int ThuThuatNoiSoi3 { get; set; }
        public int ThuThuatNoiSoi4 { get; set; }
        public int ThuThuatNoiSoi5 { get; set; }
        public int ThuThuatNoiSoi6 { get; set; }
        public string ThuThuatNoiSoi1_Text { get; set; }
        public string ThuThuatNoiSoi2_Text { get; set; }
        public string ThuThuatNoiSoi3_Text { get; set; }
        public string ThuThuatNoiSoi4_Text { get; set; }
        public string ThuThuatNoiSoi5_Text { get; set; }
        public string ThuThuatNoiSoi6_Text { get; set; }

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

    public class PhieuYeuCauNoiSoiFunc
    {
        public const string TableName = "PhieuYeuCauNoiSoi";
        public const string TablePrimaryKeyName = "ID";

        public static List<PhieuYeuCauNoiSoi> GetListData(MDB.MDBConnection _OracleConnection, decimal maquanly)
        {
            List<PhieuYeuCauNoiSoi> list = new List<PhieuYeuCauNoiSoi>();
            try
            {
                string sql = @"SELECT * FROM PhieuYeuCauNoiSoi where MaQuanLy = :MaQuanLy";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, _OracleConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", maquanly));
                MDB.MDBDataReader DataReader = Command.ExecuteReader();
                while (DataReader.Read())
                {
                    PhieuYeuCauNoiSoi data = new PhieuYeuCauNoiSoi();
                    data.ID = Convert.ToInt64(DataReader.GetLong("ID").ToString());
                    data.MaQuanLy = maquanly;

                    data.MaBenhNhan = XemBenhAn._HanhChinhBenhNhan.MaBenhNhan;
                    data.TenBenhNhan = XemBenhAn._HanhChinhBenhNhan.TenBenhNhan;
                    data.Tuoi = XemBenhAn._HanhChinhBenhNhan.NgaySinh?.Year.ToString();
                    data.GioiTinh = XemBenhAn._HanhChinhBenhNhan.GioiTinh.Description();
                    data.Khoa = XemBenhAn._HanhChinhBenhNhan.SoYTe;
                    data.BenhVien = XemBenhAn._HanhChinhBenhNhan.BenhVien;

                    data.DiaChi = DataReader["DiaChi"].ToString();
                    data.DienThoai = DataReader["DienThoai"].ToString();
                    data.Email = DataReader["Email"].ToString();
                    data.BacSiDieuTri = DataReader["BacSiDieuTri"].ToString();
                    data.MaBacSiDieuTri = DataReader["MaBacSiDieuTri"].ToString();
                    data.NSDD = DataReader["NSDD"].ToString();
                    data.NSDT = DataReader["NSDT"].ToString();
                    data.BLKhac = DataReader["BLKhac"].ToString();
                    data.SuDungThuocChongDong = DataReader["SuDungThuocChongDong"].ToString();
                    data.SuDungThuocDaDay = DataReader["SuDungThuocDaDay"].ToString();
                    data.TrieuChungChuYeu = DataReader["TrieuChungBenhLy"].ToString();
                    data.TC_Khac_DD = DataReader["TC_Khac_DD"].ToString();
                    data.TC_Khac_DT = DataReader["TC_Khac_DT"].ToString();
                    data.ViTri = DataReader["ViTri"].ToString();
                    data.TrieuChungBenhLy = DataReader["TrieuChungBenhLy"].ToString();
                    data.ChanDoanTruocSoi = DataReader["ChanDoanTruocSoi"].ToString();
                    data.SoLanTieuLong = DataReader["SoLanTieuLong"].ToString();

                    data.TrieuChungDD1 = DataReader.GetInt("TrieuChungDD1");
                    data.TrieuChungDD2 = DataReader.GetInt("TrieuChungDD2");
                    data.TrieuChungDD3 = DataReader.GetInt("TrieuChungDD3");
                    data.TrieuChungDD4 = DataReader.GetInt("TrieuChungDD4");
                    data.TrieuChungDD5 = DataReader.GetInt("TrieuChungDD5");
                    data.TrieuChungDD6 = DataReader.GetInt("TrieuChungDD6");
                    data.TrieuChungDD7 = DataReader.GetInt("TrieuChungDD7");
                    data.TrieuChungDD8 = DataReader.GetInt("TrieuChungDD8");
                    data.TrieuChungDD9 = DataReader.GetInt("TrieuChungDD9");
                    data.TrieuChungDD10 = DataReader.GetInt("TrieuChungDD10");
                    data.TrieuChungDD11 = DataReader.GetInt("TrieuChungDD11");

                    data.TrieuChungDT1 = DataReader.GetInt("TrieuChungDT1");
                    data.TrieuChungDT2 = DataReader.GetInt("TrieuChungDT2");
                    data.TrieuChungDT3 = DataReader.GetInt("TrieuChungDT3");
                    data.TrieuChungDT4 = DataReader.GetInt("TrieuChungDT4");
                    data.TrieuChungDT5 = DataReader.GetInt("TrieuChungDT5");
                    data.TrieuChungDT6 = DataReader.GetInt("TrieuChungDT6");
                    data.TrieuChungDT7 = DataReader.GetInt("TrieuChungDT7");
                    data.TrieuChungDT8 = DataReader.GetInt("TrieuChungDT8");

                    data.NoiSoiChanDoan1 = DataReader.GetInt("NoiSoiChanDoan1");
                    data.NoiSoiChanDoan2 = DataReader.GetInt("NoiSoiChanDoan2");
                    data.NoiSoiChanDoan3 = DataReader.GetInt("NoiSoiChanDoan3");
                    data.NoiSoiChanDoan4 = DataReader.GetInt("NoiSoiChanDoan4");
                    data.NoiSoiChanDoan5 = DataReader.GetInt("NoiSoiChanDoan5");
                    data.NoiSoiChanDoan6 = DataReader.GetInt("NoiSoiChanDoan6");
                    data.NoiSoiChanDoan7 = DataReader.GetInt("NoiSoiChanDoan7");
                    data.NoiSoiChanDoan8 = DataReader.GetInt("NoiSoiChanDoan8");

                    data.NoiSoiChanDoan1_Text = DataReader["NoiSoiChanDoan1_Text"].ToString();
                    data.NoiSoiChanDoan2_Text = DataReader["NoiSoiChanDoan2_Text"].ToString();
                    data.NoiSoiChanDoan3_Text = DataReader["NoiSoiChanDoan3_Text"].ToString();
                    data.NoiSoiChanDoan4_Text = DataReader["NoiSoiChanDoan4_Text"].ToString();
                    data.NoiSoiChanDoan5_Text = DataReader["NoiSoiChanDoan5_Text"].ToString();
                    data.NoiSoiChanDoan6_Text = DataReader["NoiSoiChanDoan6_Text"].ToString();
                    data.NoiSoiChanDoan7_Text = DataReader["NoiSoiChanDoan7_Text"].ToString();
                    data.NoiSoiChanDoan8_Text = DataReader["NoiSoiChanDoan8_Text"].ToString();

                    data.ThuThuatNoiSoi1 = DataReader.GetInt("ThuThuatNoiSoi1");
                    data.ThuThuatNoiSoi2 = DataReader.GetInt("ThuThuatNoiSoi2");
                    data.ThuThuatNoiSoi3 = DataReader.GetInt("ThuThuatNoiSoi3");
                    data.ThuThuatNoiSoi4 = DataReader.GetInt("ThuThuatNoiSoi4");
                    data.ThuThuatNoiSoi5 = DataReader.GetInt("ThuThuatNoiSoi5");
                    data.ThuThuatNoiSoi6 = DataReader.GetInt("ThuThuatNoiSoi6");

                    data.ThuThuatNoiSoi1_Text = DataReader["ThuThuatNoiSoi1_Text"].ToString();
                    data.ThuThuatNoiSoi2_Text = DataReader["ThuThuatNoiSoi2_Text"].ToString();
                    data.ThuThuatNoiSoi3_Text = DataReader["ThuThuatNoiSoi3_Text"].ToString();
                    data.ThuThuatNoiSoi4_Text = DataReader["ThuThuatNoiSoi4_Text"].ToString();
                    data.ThuThuatNoiSoi5_Text = DataReader["ThuThuatNoiSoi5_Text"].ToString();
                    data.ThuThuatNoiSoi6_Text = DataReader["ThuThuatNoiSoi6_Text"].ToString();

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
                sql = @"DELETE FROM PhieuYeuCauNoiSoi WHERE ID =" + IDBienBan;
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
                PhieuYeuCauNoiSoi P
            WHERE
                ID = " + IDBienBan;

            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
            MDB.MDBDataAdapter adt = new MDB.MDBDataAdapter(Command);
            var ds = new DataSet();

            adt.Fill(ds, "TB");

            ds.Tables[0].AddColumn("TenBenhNhan", typeof(string));
            ds.Tables[0].AddColumn("Tuoi", typeof(string));
            ds.Tables[0].AddColumn("GioiTinh", typeof(int));
            ds.Tables[0].AddColumn("Khoa", typeof(string));
            ds.Tables[0].AddColumn("BenhVien", typeof(string));
            ds.Tables[0].Rows[0]["TenBenhNhan"] = XemBenhAn._HanhChinhBenhNhan.TenBenhNhan;
            ds.Tables[0].Rows[0]["Tuoi"] = XemBenhAn._HanhChinhBenhNhan.Tuoi;
            ds.Tables[0].Rows[0]["GioiTinh"] = (int) XemBenhAn._HanhChinhBenhNhan.GioiTinh;
            ds.Tables[0].Rows[0]["Khoa"] = XemBenhAn._ThongTinDieuTri.Khoa;
            ds.Tables[0].Rows[0]["BenhVien"] = XemBenhAn._HanhChinhBenhNhan.BenhVien;

            ds.Tables[0].AddColumn("ThongTinNgayThang", typeof(string));
            ds.Tables[0].Rows[0]["ThongTinNgayThang"] = "Ngày " + DateTime.Now.Day + " tháng " + DateTime.Now.Month + " năm " + DateTime.Now.Year;

            return ds;
        }
        public static bool InsertOrUpdate(MDB.MDBConnection MyConnection, ref PhieuYeuCauNoiSoi ketQua)
        {
            try
            {
                string sql = @"INSERT INTO PhieuYeuCauNoiSoi
                (
                    MaQuanLy,
                    DiaChi,
                    DienThoai,
                    Email,
                    MaBacSiDieuTri,
                    BacSiDieuTri,
                    NSDD,
                    NSDT,
                    BLKhac,
                    SuDungThuocChongDong,
                    SuDungThuocDaDay,
                    TrieuChungChuYeu,
                    TC_Khac_DD,
                    SoLanTieuLong,
                    ViTri,
                    TC_Khac_DT,
                    TrieuChungBenhLy,
                    ChanDoanTruocSoi,
                    TrieuChungDD1,
                    TrieuChungDD2,
                    TrieuChungDD3,
                    TrieuChungDD4,
                    TrieuChungDD5,
                    TrieuChungDD6,
                    TrieuChungDD7,
                    TrieuChungDD8,
                    TrieuChungDD9,
                    TrieuChungDD10,
                    TrieuChungDD11,
                    TrieuChungDT1,
                    TrieuChungDT2,
                    TrieuChungDT3,
                    TrieuChungDT4,
                    TrieuChungDT5,
                    TrieuChungDT6,
                    TrieuChungDT7,
                    TrieuChungDT8,
                    NoiSoiChanDoan1,
                    NoiSoiChanDoan2,
                    NoiSoiChanDoan3,
                    NoiSoiChanDoan4,
                    NoiSoiChanDoan5,
                    NoiSoiChanDoan6,
                    NoiSoiChanDoan7,
                    NoiSoiChanDoan8,
                    NoiSoiChanDoan1_Text,
                    NoiSoiChanDoan2_Text,
                    NoiSoiChanDoan3_Text,
                    NoiSoiChanDoan4_Text,
                    NoiSoiChanDoan5_Text,
                    NoiSoiChanDoan6_Text,
                    NoiSoiChanDoan7_Text,
                    NoiSoiChanDoan8_Text,
                    ThuThuatNoiSoi1,
                    ThuThuatNoiSoi2,
                    ThuThuatNoiSoi3,
                    ThuThuatNoiSoi4,
                    ThuThuatNoiSoi5,
                    ThuThuatNoiSoi6,
                    ThuThuatNoiSoi1_Text,
                    ThuThuatNoiSoi2_Text,
                    ThuThuatNoiSoi3_Text,
                    ThuThuatNoiSoi4_Text,
                    ThuThuatNoiSoi5_Text,
                    ThuThuatNoiSoi6_Text,
                    NGUOITAO,
                    NGUOISUA,
                    NGAYTAO,
                    NGAYSUA)  VALUES
                 (
				    :MaQuanLy,
                    :DiaChi,
                    :DienThoai,
                    :Email,
                    :MaBacSiDieuTri,
                    :BacSiDieuTri,
                    :NSDD,
                    :NSDT,
                    :BLKhac,
                    :SuDungThuocChongDong,
                    :SuDungThuocDaDay,
                    :TrieuChungChuYeu,
                    :TC_Khac_DD,
                    :SoLanTieuLong,
                    :ViTri,
                    :TC_Khac_DT,
                    :TrieuChungBenhLy,
                    :ChanDoanTruocSoi,
                    :TrieuChungDD1,
                    :TrieuChungDD2,
                    :TrieuChungDD3,
                    :TrieuChungDD4,
                    :TrieuChungDD5,
                    :TrieuChungDD6,
                    :TrieuChungDD7,
                    :TrieuChungDD8,
                    :TrieuChungDD9,
                    :TrieuChungDD10,
                    :TrieuChungDD11,
                    :TrieuChungDT1,
                    :TrieuChungDT2,
                    :TrieuChungDT3,
                    :TrieuChungDT4,
                    :TrieuChungDT5,
                    :TrieuChungDT6,
                    :TrieuChungDT7,
                    :TrieuChungDT8,
                    :NoiSoiChanDoan1,
                    :NoiSoiChanDoan2,
                    :NoiSoiChanDoan3,
                    :NoiSoiChanDoan4,
                    :NoiSoiChanDoan5,
                    :NoiSoiChanDoan6,
                    :NoiSoiChanDoan7,
                    :NoiSoiChanDoan8,
                    :NoiSoiChanDoan1_Text,
                    :NoiSoiChanDoan2_Text,
                    :NoiSoiChanDoan3_Text,
                    :NoiSoiChanDoan4_Text,
                    :NoiSoiChanDoan5_Text,
                    :NoiSoiChanDoan6_Text,
                    :NoiSoiChanDoan7_Text,
                    :NoiSoiChanDoan8_Text,
                    :ThuThuatNoiSoi1,
                    :ThuThuatNoiSoi2,
                    :ThuThuatNoiSoi3,
                    :ThuThuatNoiSoi4,
                    :ThuThuatNoiSoi5,
                    :ThuThuatNoiSoi6,
                    :ThuThuatNoiSoi1_Text,
                    :ThuThuatNoiSoi2_Text,
                    :ThuThuatNoiSoi3_Text,
                    :ThuThuatNoiSoi4_Text,
                    :ThuThuatNoiSoi5_Text,
                    :ThuThuatNoiSoi6_Text,
                    :NGUOITAO,
                    :NGUOISUA,
                    :NGAYTAO,
                    :NGAYSUA
                 )  RETURNING ID INTO :ID";
                if (ketQua.ID != 0)
                {
                    sql = @"UPDATE PhieuYeuCauNoiSoi SET 
                    MaQuanLy = :MaQuanLy,
                    DiaChi = :DiaChi,
                    DienThoai = :DienThoai,
                    Email = :Email,
                    MaBacSiDieuTri = :MaBacSiDieuTri,
                    BacSiDieuTri = :BacSiDieuTri,
                    NSDD = :NSDD,
                    NSDT = :NSDT,
                    BLKhac = :BLKhac,
                    SuDungThuocChongDong = :SuDungThuocChongDong,
                    SuDungThuocDaDay = :SuDungThuocDaDay,
                    TrieuChungChuYeu = :TrieuChungChuYeu,
                    TC_Khac_DD = :TC_Khac_DD,
                    SoLanTieuLong = :SoLanTieuLong,
                    ViTri = :ViTri,
                    TC_Khac_DT = :TC_Khac_DT,
                    TrieuChungBenhLy = :TrieuChungBenhLy,
                    ChanDoanTruocSoi = :ChanDoanTruocSoi,
                    TrieuChungDD1 = :TrieuChungDD1,
                    TrieuChungDD2 = :TrieuChungDD2,
                    TrieuChungDD3 = :TrieuChungDD3,
                    TrieuChungDD4 = :TrieuChungDD4,
                    TrieuChungDD5 = :TrieuChungDD5,
                    TrieuChungDD6 = :TrieuChungDD6,
                    TrieuChungDD7 = :TrieuChungDD7,
                    TrieuChungDD8 = :TrieuChungDD8,
                    TrieuChungDD9 = :TrieuChungDD9,
                    TrieuChungDD10 = :TrieuChungDD10,
                    TrieuChungDD11 = :TrieuChungDD11,
                    TrieuChungDT1 = :TrieuChungDT1,
                    TrieuChungDT2 = :TrieuChungDT2,
                    TrieuChungDT3 = :TrieuChungDT3,
                    TrieuChungDT4 = :TrieuChungDT4,
                    TrieuChungDT5 = :TrieuChungDT5,
                    TrieuChungDT6 = :TrieuChungDT6,
                    TrieuChungDT7 = :TrieuChungDT7,
                    TrieuChungDT8 = :TrieuChungDT8,
                    NoiSoiChanDoan1 = :NoiSoiChanDoan1,
                    NoiSoiChanDoan2 = :NoiSoiChanDoan2,
                    NoiSoiChanDoan3 = :NoiSoiChanDoan3,
                    NoiSoiChanDoan4 = :NoiSoiChanDoan4,
                    NoiSoiChanDoan5 = :NoiSoiChanDoan5,
                    NoiSoiChanDoan6 = :NoiSoiChanDoan6,
                    NoiSoiChanDoan7 =  :NoiSoiChanDoan7,
                    NoiSoiChanDoan8 = :NoiSoiChanDoan8,
                    NoiSoiChanDoan1_Text = :NoiSoiChanDoan1_Text,
                    NoiSoiChanDoan2_Text = :NoiSoiChanDoan2_Text,
                    NoiSoiChanDoan3_Text = :NoiSoiChanDoan3_Text,
                    NoiSoiChanDoan4_Text = :NoiSoiChanDoan4_Text,
                    NoiSoiChanDoan5_Text = :NoiSoiChanDoan5_Text,
                    NoiSoiChanDoan6_Text = :NoiSoiChanDoan6_Text,
                    NoiSoiChanDoan7_Text = :NoiSoiChanDoan7_Text,
                    NoiSoiChanDoan8_Text = :NoiSoiChanDoan8_Text,
                    ThuThuatNoiSoi1 = :ThuThuatNoiSoi1,
                    ThuThuatNoiSoi2 = :ThuThuatNoiSoi2,
                    ThuThuatNoiSoi3 = :ThuThuatNoiSoi3,
                    ThuThuatNoiSoi4 = :ThuThuatNoiSoi4,
                    ThuThuatNoiSoi5 = :ThuThuatNoiSoi5,
                    ThuThuatNoiSoi6 = :ThuThuatNoiSoi6,
                    ThuThuatNoiSoi1_Text = :ThuThuatNoiSoi1_Text,
                    ThuThuatNoiSoi2_Text = :ThuThuatNoiSoi2_Text,
                    ThuThuatNoiSoi3_Text = :ThuThuatNoiSoi3_Text,
                    ThuThuatNoiSoi4_Text = :ThuThuatNoiSoi4_Text,
                    ThuThuatNoiSoi5_Text = :ThuThuatNoiSoi5_Text,
                    ThuThuatNoiSoi6_Text = :ThuThuatNoiSoi6_Text,
                    NGUOISUA = :NGUOISUA,
                    NGAYSUA = :NGAYSUA 
                    WHERE ID = " + ketQua.ID;
                }
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);

                Command.Parameters.Add(new MDB.MDBParameter("NGUOISUA", ketQua.NguoiSua));
                Command.Parameters.Add(new MDB.MDBParameter("NGAYSUA", ketQua.NgaySua));

                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", ketQua.MaQuanLy));

                Command.Parameters.Add(new MDB.MDBParameter("DiaChi", ketQua.DiaChi));
                Command.Parameters.Add(new MDB.MDBParameter("DienThoai", ketQua.DienThoai));
                Command.Parameters.Add(new MDB.MDBParameter("Email", ketQua.Email));
                Command.Parameters.Add(new MDB.MDBParameter("MaBacSiDieuTri", ketQua.MaBacSiDieuTri));
                Command.Parameters.Add(new MDB.MDBParameter("BacSiDieuTri", ketQua.BacSiDieuTri));
                Command.Parameters.Add(new MDB.MDBParameter("NSDD", ketQua.NSDD));
                Command.Parameters.Add(new MDB.MDBParameter("NSDT", ketQua.NSDT));
                Command.Parameters.Add(new MDB.MDBParameter("BLKhac", ketQua.BLKhac));
                Command.Parameters.Add(new MDB.MDBParameter("SuDungThuocChongDong", ketQua.SuDungThuocChongDong));
                Command.Parameters.Add(new MDB.MDBParameter("SuDungThuocDaDay", ketQua.SuDungThuocDaDay));
                Command.Parameters.Add(new MDB.MDBParameter("TrieuChungChuYeu", ketQua.TrieuChungChuYeu));
                Command.Parameters.Add(new MDB.MDBParameter("TC_Khac_DD", ketQua.TC_Khac_DD));
                Command.Parameters.Add(new MDB.MDBParameter("SoLanTieuLong", ketQua.SoLanTieuLong));
                Command.Parameters.Add(new MDB.MDBParameter("ViTri", ketQua.ViTri));
                Command.Parameters.Add(new MDB.MDBParameter("TC_Khac_DT", ketQua.TC_Khac_DT));
                Command.Parameters.Add(new MDB.MDBParameter("TrieuChungBenhLy", ketQua.TrieuChungBenhLy));
                Command.Parameters.Add(new MDB.MDBParameter("ChanDoanTruocSoi", ketQua.ChanDoanTruocSoi));

                Command.Parameters.Add(new MDB.MDBParameter("TrieuChungDD1", ketQua.TrieuChungDD1));
                Command.Parameters.Add(new MDB.MDBParameter("TrieuChungDD2", ketQua.TrieuChungDD2));
                Command.Parameters.Add(new MDB.MDBParameter("TrieuChungDD3", ketQua.TrieuChungDD3));
                Command.Parameters.Add(new MDB.MDBParameter("TrieuChungDD4", ketQua.TrieuChungDD4));
                Command.Parameters.Add(new MDB.MDBParameter("TrieuChungDD5", ketQua.TrieuChungDD5));
                Command.Parameters.Add(new MDB.MDBParameter("TrieuChungDD6", ketQua.TrieuChungDD6));
                Command.Parameters.Add(new MDB.MDBParameter("TrieuChungDD7", ketQua.TrieuChungDD7));
                Command.Parameters.Add(new MDB.MDBParameter("TrieuChungDD8", ketQua.TrieuChungDD8));
                Command.Parameters.Add(new MDB.MDBParameter("TrieuChungDD9", ketQua.TrieuChungDD9));
                Command.Parameters.Add(new MDB.MDBParameter("TrieuChungDD10", ketQua.TrieuChungDD10));
                Command.Parameters.Add(new MDB.MDBParameter("TrieuChungDD11", ketQua.TrieuChungDD11));

                Command.Parameters.Add(new MDB.MDBParameter("TrieuChungDT1", ketQua.TrieuChungDT1));
                Command.Parameters.Add(new MDB.MDBParameter("TrieuChungDT2", ketQua.TrieuChungDT2));
                Command.Parameters.Add(new MDB.MDBParameter("TrieuChungDT3", ketQua.TrieuChungDT3));
                Command.Parameters.Add(new MDB.MDBParameter("TrieuChungDT4", ketQua.TrieuChungDT4));
                Command.Parameters.Add(new MDB.MDBParameter("TrieuChungDT5", ketQua.TrieuChungDT5));
                Command.Parameters.Add(new MDB.MDBParameter("TrieuChungDT6", ketQua.TrieuChungDT6));
                Command.Parameters.Add(new MDB.MDBParameter("TrieuChungDT7", ketQua.TrieuChungDT7));
                Command.Parameters.Add(new MDB.MDBParameter("TrieuChungDT8", ketQua.TrieuChungDT8));

                Command.Parameters.Add(new MDB.MDBParameter("NoiSoiChanDoan1", ketQua.NoiSoiChanDoan1));
                Command.Parameters.Add(new MDB.MDBParameter("NoiSoiChanDoan2", ketQua.NoiSoiChanDoan2));
                Command.Parameters.Add(new MDB.MDBParameter("NoiSoiChanDoan3", ketQua.NoiSoiChanDoan3));
                Command.Parameters.Add(new MDB.MDBParameter("NoiSoiChanDoan4", ketQua.NoiSoiChanDoan4));
                Command.Parameters.Add(new MDB.MDBParameter("NoiSoiChanDoan5", ketQua.NoiSoiChanDoan5));
                Command.Parameters.Add(new MDB.MDBParameter("NoiSoiChanDoan6", ketQua.NoiSoiChanDoan6));
                Command.Parameters.Add(new MDB.MDBParameter("NoiSoiChanDoan7", ketQua.NoiSoiChanDoan7));
                Command.Parameters.Add(new MDB.MDBParameter("NoiSoiChanDoan8", ketQua.NoiSoiChanDoan8));

                Command.Parameters.Add(new MDB.MDBParameter("NoiSoiChanDoan1_Text", ketQua.NoiSoiChanDoan1_Text));
                Command.Parameters.Add(new MDB.MDBParameter("NoiSoiChanDoan2_Text", ketQua.NoiSoiChanDoan2_Text));
                Command.Parameters.Add(new MDB.MDBParameter("NoiSoiChanDoan3_Text", ketQua.NoiSoiChanDoan3_Text));
                Command.Parameters.Add(new MDB.MDBParameter("NoiSoiChanDoan4_Text", ketQua.NoiSoiChanDoan4_Text));
                Command.Parameters.Add(new MDB.MDBParameter("NoiSoiChanDoan5_Text", ketQua.NoiSoiChanDoan5_Text));
                Command.Parameters.Add(new MDB.MDBParameter("NoiSoiChanDoan6_Text", ketQua.NoiSoiChanDoan6_Text));
                Command.Parameters.Add(new MDB.MDBParameter("NoiSoiChanDoan7_Text", ketQua.NoiSoiChanDoan7_Text));
                Command.Parameters.Add(new MDB.MDBParameter("NoiSoiChanDoan8_Text", ketQua.NoiSoiChanDoan8_Text));

                Command.Parameters.Add(new MDB.MDBParameter("ThuThuatNoiSoi1", ketQua.ThuThuatNoiSoi1));
                Command.Parameters.Add(new MDB.MDBParameter("ThuThuatNoiSoi2", ketQua.ThuThuatNoiSoi2));
                Command.Parameters.Add(new MDB.MDBParameter("ThuThuatNoiSoi3", ketQua.ThuThuatNoiSoi3));
                Command.Parameters.Add(new MDB.MDBParameter("ThuThuatNoiSoi4", ketQua.ThuThuatNoiSoi4));
                Command.Parameters.Add(new MDB.MDBParameter("ThuThuatNoiSoi5", ketQua.ThuThuatNoiSoi5));
                Command.Parameters.Add(new MDB.MDBParameter("ThuThuatNoiSoi6", ketQua.ThuThuatNoiSoi6));

                Command.Parameters.Add(new MDB.MDBParameter("ThuThuatNoiSoi1_Text", ketQua.ThuThuatNoiSoi1_Text));
                Command.Parameters.Add(new MDB.MDBParameter("ThuThuatNoiSoi2_Text", ketQua.ThuThuatNoiSoi2_Text));
                Command.Parameters.Add(new MDB.MDBParameter("ThuThuatNoiSoi3_Text", ketQua.ThuThuatNoiSoi3_Text));
                Command.Parameters.Add(new MDB.MDBParameter("ThuThuatNoiSoi4_Text", ketQua.ThuThuatNoiSoi4_Text));
                Command.Parameters.Add(new MDB.MDBParameter("ThuThuatNoiSoi5_Text", ketQua.ThuThuatNoiSoi5_Text));
                Command.Parameters.Add(new MDB.MDBParameter("ThuThuatNoiSoi6_Text", ketQua.ThuThuatNoiSoi6_Text));

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
