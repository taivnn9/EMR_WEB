
using EMR.KyDienTu;
using PMS.Access;
using System;
using System.Collections.Generic;
using System.Data;

namespace EMR_MAIN.DATABASE.Other
{
    public class DanhGiaTrangThaiTamThanToiThieu : ThongTinKy
    {
        public DanhGiaTrangThaiTamThanToiThieu()
        {
            IDMauPhieu = (int)DanhMucPhieu.DGTTTTTT;
            TenMauPhieu = DanhMucPhieu.DGTTTTTT.Description();
        }
        [MoTaDuLieu("Mã định danh")]
		public long ID { get; set; }
        [MoTaDuLieu("Mã quản lý: mã duy nhất trong 1 đợt khám chữa bệnh (kcb), không trùng giữa các đợt kcb khác nhau","",1)]
		public decimal MaQuanLy { get; set; }
        [MoTaDuLieu("Mã bệnh nhân")]
		public string MaBenhNhan { get; set; }
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
        [MoTaDuLieu("Nghề nghiệp")]
		public string NgheNghiep { get; set; }
        public DateTime? NgayLamTest { get; set; }
        [MoTaDuLieu("Mã người thực hiện")]
		public string MaNguoiThucHien { get; set; }
        [MoTaDuLieu("Người thực hiện")]
		public string NguoiThucHien { get; set; }
        public int DinhHuong_1 { get; set; }
        public string DinhHuong_1_Text { get; set; }
        public int DinhHuong_2 { get; set; }
        public string DinhHuong_2_Text { get; set; }
        public int DinhHuong_3 { get; set; }
        public string DinhHuong_3_Text { get; set; }
        public int DinhHuong_4 { get; set; }
        public string DinhHuong_4_Text { get; set; }
        public int DinhHuong_5 { get; set; }
        public string DinhHuong_5_Text { get; set; }
        public int DinhHuong_6 { get; set; }
        public string DinhHuong_6_Text { get; set; }
        public int DinhHuong_7 { get; set; }
        public string DinhHuong_7_Text { get; set; }
        public int DinhHuong_8 { get; set; }
        public string DinhHuong_8_Text { get; set; }
        public int KhaNangNhanThuc_1 { get; set; }
        public string KhaNangNhanThuc_1_Text { get; set; }
        public int KhaNangNhanThuc_2 { get; set; }
        public string KhaNangNhanThuc_2_Text { get; set; }
        public int KhaNangNhanThuc_3 { get; set; }
        public string KhaNangNhanThuc_3_Text { get; set; }
        public int SuChuY_1 { get; set; }
        public string SuChuY_1_Text { get; set; }
        public int SuChuY_2 { get; set; }
        public string SuChuY_2_Text { get; set; }
        public int SuChuY_3 { get; set; }
        public string SuChuY_3_Text { get; set; }
        public int SuChuY_4 { get; set; }
        public string SuChuY_4_Text { get; set; }
        public int SuChuY_5 { get; set; }
        public string SuChuY_5_Text { get; set; }
        public int SuChuY_6 { get; set; }
        public string SuChuY_6_Text { get; set; }
        public int KhaNangHoiUc_1 { get; set; }
        public string KhaNangHoiUc_1_Text { get; set; }
        public int KhaNangHoiUc_2 { get; set; }
        public string KhaNangHoiUc_2_Text { get; set; }
        public int KhaNangHoiUc_3 { get; set; }
        public string KhaNangHoiUc_3_Text { get; set; }
        public int NgonNgu_1 { get; set; }
        public string NgonNgu_1_Text { get; set; }
        public int NgonNgu_2 { get; set; }
        public string NgonNgu_2_Text { get; set; }
        public int NgonNgu_3 { get; set; }
        public string NgonNgu_3_Text { get; set; }
        public int NgonNgu_GiaiDoan3_1 { get; set; }
        public string NgonNgu_GiaiDoan3_1_Text { get; set; }
        public int NgonNgu_GiaiDoan3_2 { get; set; }
        public string NgonNgu_GiaiDoan3_2_Text { get; set; }
        public int NgonNgu_GiaiDoan3_3 { get; set; }
        public string NgonNgu_GiaiDoan3_3_Text { get; set; }
        public int NgonNgu_GiaiDoan3_4 { get; set; }
        public string NgonNgu_GiaiDoan3_4_Text { get; set; }
        public int NgonNgu_GiaiDoan3_5 { get; set; }
        public string NgonNgu_GiaiDoan3_5_Text { get; set; }
        public int TuongTuong_1 { get; set; }

        public string TuongTuong_1_Text { get; set; }
        public string TongDiem { get; set; }
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


    public class DanhGiaTrangThaiTamThanToiThieuFunc
    {
        public const string TableName = "DanhGiaTrangThaiTTTT";
        public const string TablePrimaryKeyName = "ID";

        public static List<DanhGiaTrangThaiTamThanToiThieu> GetListData(MDB.MDBConnection _OracleConnection, decimal maquanly)
        {
            List<DanhGiaTrangThaiTamThanToiThieu> list = new List<DanhGiaTrangThaiTamThanToiThieu>();
            try
            {
                string sql = @"SELECT * FROM DanhGiaTrangThaiTTTT where MaQuanLy = :MaQuanLy";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, _OracleConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", maquanly));
                MDB.MDBDataReader DataReader = Command.ExecuteReader();
                while (DataReader.Read())
                {
                    DanhGiaTrangThaiTamThanToiThieu data = new DanhGiaTrangThaiTamThanToiThieu();
                    data.ID = Convert.ToInt64(DataReader.GetLong("ID").ToString());
                    data.MaQuanLy = maquanly;

                    data.MaBenhNhan = XemBenhAn._HanhChinhBenhNhan.MaBenhNhan;
                    data.TenBenhNhan = XemBenhAn._HanhChinhBenhNhan.TenBenhNhan;
                    data.Tuoi = XemBenhAn._HanhChinhBenhNhan.Tuoi;
                    data.GioiTinh = XemBenhAn._HanhChinhBenhNhan.GioiTinh.Description();

                    data.ChanDoan = DataReader["ChanDoan"].ToString();
                    data.DiaChi = DataReader["DiaChi"].ToString();
                    data.NgheNghiep = DataReader["NgheNghiep"].ToString();
                    data.MaNguoiThucHien = DataReader["MaNguoiThucHien"].ToString();
                    data.NguoiThucHien = DataReader["NguoiThucHien"].ToString();

                    data.DinhHuong_1 = DataReader.GetInt("DinhHuong_1");
                    data.DinhHuong_1_Text = DataReader["DinhHuong_1_Text"].ToString();
                    data.DinhHuong_2 = DataReader.GetInt("DinhHuong_2");
                    data.DinhHuong_2_Text = DataReader["DinhHuong_2_Text"].ToString();
                    data.DinhHuong_3 = DataReader.GetInt("DinhHuong_3");
                    data.DinhHuong_3_Text = DataReader["DinhHuong_3_Text"].ToString();
                    data.DinhHuong_4 = DataReader.GetInt("DinhHuong_4");
                    data.DinhHuong_4_Text = DataReader["DinhHuong_4_Text"].ToString();
                    data.DinhHuong_5 = DataReader.GetInt("DinhHuong_5");
                    data.DinhHuong_5_Text = DataReader["DinhHuong_5_Text"].ToString();
                    data.DinhHuong_6 = DataReader.GetInt("DinhHuong_6");
                    data.DinhHuong_6_Text = DataReader["DinhHuong_6_Text"].ToString();
                    data.DinhHuong_7 = DataReader.GetInt("DinhHuong_7");
                    data.DinhHuong_7_Text = DataReader["DinhHuong_7_Text"].ToString();
                    data.DinhHuong_8 = DataReader.GetInt("DinhHuong_8");
                    data.DinhHuong_8_Text = DataReader["DinhHuong_8_Text"].ToString();

                    data.KhaNangNhanThuc_1 = DataReader.GetInt("KhaNangNhanThuc_1");
                    data.KhaNangNhanThuc_1_Text = DataReader["KhaNangNhanThuc_1_Text"].ToString();
                    data.KhaNangNhanThuc_2 = DataReader.GetInt("KhaNangNhanThuc_2");
                    data.KhaNangNhanThuc_2_Text = DataReader["KhaNangNhanThuc_2_Text"].ToString();
                    data.KhaNangNhanThuc_3 = DataReader.GetInt("KhaNangNhanThuc_3");
                    data.KhaNangNhanThuc_3_Text = DataReader["KhaNangNhanThuc_3_Text"].ToString();

                    data.SuChuY_1 = DataReader.GetInt("SuChuY_1");
                    data.SuChuY_1_Text = DataReader["SuChuY_1_Text"].ToString();
                    data.SuChuY_2= DataReader.GetInt("SuChuY_2");
                    data.SuChuY_2_Text = DataReader["SuChuY_2_Text"].ToString();
                    data.SuChuY_3 = DataReader.GetInt("SuChuY_3");
                    data.SuChuY_3_Text = DataReader["SuChuY_3_Text"].ToString();
                    data.SuChuY_4 = DataReader.GetInt("SuChuY_4");
                    data.SuChuY_4_Text = DataReader["SuChuY_4_Text"].ToString();
                    data.SuChuY_5 = DataReader.GetInt("SuChuY_5");
                    data.SuChuY_5_Text = DataReader["SuChuY_5_Text"].ToString();
                    data.SuChuY_6 = DataReader.GetInt("SuChuY_6");
                    data.SuChuY_6_Text = DataReader["SuChuY_6_Text"].ToString();

                    data.KhaNangHoiUc_1 = DataReader.GetInt("KhaNangHoiUc_1");
                    data.KhaNangHoiUc_1_Text = DataReader["KhaNangHoiUc_1_Text"].ToString();
                    data.KhaNangHoiUc_2 = DataReader.GetInt("KhaNangHoiUc_2");
                    data.KhaNangHoiUc_2_Text = DataReader["KhaNangHoiUc_2_Text"].ToString();
                    data.KhaNangHoiUc_3 = DataReader.GetInt("KhaNangHoiUc_3");
                    data.KhaNangHoiUc_3_Text = DataReader["KhaNangHoiUc_3_Text"].ToString();

                    data.NgonNgu_1 = DataReader.GetInt("NgonNgu_1");
                    data.NgonNgu_1_Text = DataReader["NgonNgu_1_Text"].ToString();
                    data.NgonNgu_2 = DataReader.GetInt("NgonNgu_2");
                    data.NgonNgu_2_Text = DataReader["NgonNgu_2_Text"].ToString();
                    data.NgonNgu_3 = DataReader.GetInt("NgonNgu_3");
                    data.NgonNgu_3_Text = DataReader["NgonNgu_3_Text"].ToString();

                    data.NgonNgu_GiaiDoan3_1 = DataReader.GetInt("NgonNgu_GiaiDoan3_1");
                    data.NgonNgu_GiaiDoan3_1_Text = DataReader["NgonNgu_GiaiDoan3_1_Text"].ToString();
                    data.NgonNgu_GiaiDoan3_2 = DataReader.GetInt("NgonNgu_GiaiDoan3_2");
                    data.NgonNgu_GiaiDoan3_2_Text = DataReader["NgonNgu_GiaiDoan3_2_Text"].ToString();
                    data.NgonNgu_GiaiDoan3_3 = DataReader.GetInt("NgonNgu_GiaiDoan3_3");
                    data.NgonNgu_GiaiDoan3_3_Text = DataReader["NgonNgu_GiaiDoan3_3_Text"].ToString();
                    data.NgonNgu_GiaiDoan3_4 = DataReader.GetInt("NgonNgu_GiaiDoan3_4");
                    data.NgonNgu_GiaiDoan3_4_Text = DataReader["NgonNgu_GiaiDoan3_4_Text"].ToString();
                    data.NgonNgu_GiaiDoan3_5 = DataReader.GetInt("NgonNgu_GiaiDoan3_5");
                    data.NgonNgu_GiaiDoan3_5_Text = DataReader["NgonNgu_GiaiDoan3_5_Text"].ToString();

                    data.TuongTuong_1 = DataReader.GetInt("TuongTuong_1");
                    data.TuongTuong_1_Text = DataReader["TuongTuong_1_Text"].ToString();
                    data.TongDiem = DataReader["TongDiem"].ToString();

                    data.NgayLamTest = Convert.ToDateTime(DataReader["NgayLamTest"] == DBNull.Value ? DateTime.Now : DataReader["NgayLamTest"]);

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
                sql = @"DELETE FROM DanhGiaTrangThaiTTTT WHERE ID =" + IDBienBan;
                using (oracleCommand = new MDB.MDBCommand(sql, oracleConnection))
                {
                    oracleCommand.ExecuteNonQuery();
                }
                return true;
            }
            catch (Exception ex)
            {
                XuLyLoi.Handle(ex);
            }
            return false;
        }
        public static DataSet GetDataSet(MDB.MDBConnection MyConnection, long IDBienBan)
        {
            string sql = @"SELECT
                P.* 
            FROM
                DanhGiaTrangThaiTTTT P
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
            ds.Tables[0].Rows[0]["TenBenhNhan"] = XemBenhAn._HanhChinhBenhNhan.TenBenhNhan;
            ds.Tables[0].Rows[0]["Tuoi"] = XemBenhAn._HanhChinhBenhNhan.Tuoi;
            ds.Tables[0].Rows[0]["GioiTinh"] = XemBenhAn._HanhChinhBenhNhan.GioiTinh.Description();
            ds.Tables[0].Rows[0]["SoYTe"] = XemBenhAn._HanhChinhBenhNhan.SoYTe;
            ds.Tables[0].Rows[0]["BenhVien"] = XemBenhAn._HanhChinhBenhNhan.BenhVien;

            return ds;
        }
        public static bool InsertOrUpdate(MDB.MDBConnection MyConnection, ref DanhGiaTrangThaiTamThanToiThieu ketQua)
        {
            try
            {
                string sql = @"INSERT INTO DanhGiaTrangThaiTTTT
                (
                    MaQuanLy,
                    NgheNghiep,
                    DiaChi,
                    ChanDoan,
                    NgayLamTest,
                    MaNguoiThucHien,
                    NguoiThucHien,
                    DinhHuong_1,
                    DinhHuong_1_Text,
                    DinhHuong_2,
                    DinhHuong_2_Text,
                    DinhHuong_3,
                    DinhHuong_3_Text,
                    DinhHuong_4,
                    DinhHuong_4_Text,
                    DinhHuong_5,
                    DinhHuong_5_Text,
                    DinhHuong_6,
                    DinhHuong_6_Text,
                    DinhHuong_7,
                    DinhHuong_7_Text,
                    DinhHuong_8,
                    DinhHuong_8_Text,
                    KhaNangNhanThuc_1,
                    KhaNangNhanThuc_1_Text,
                    KhaNangNhanThuc_2,
                    KhaNangNhanThuc_2_Text,
                    KhaNangNhanThuc_3,
                    KhaNangNhanThuc_3_Text,
                    SuChuY_1,
                    SuChuY_1_Text,
                    SuChuY_2,
                    SuChuY_2_Text,
                    SuChuY_3,
                    SuChuY_3_Text,
                    SuChuY_4,
                    SuChuY_4_Text,
                    SuChuY_5,
                    SuChuY_5_Text,
                    SuChuY_6,
                    SuChuY_6_Text,
                    KhaNangHoiUc_1,
                    KhaNangHoiUc_1_Text,
                    KhaNangHoiUc_2,
                    KhaNangHoiUc_2_Text,
                    KhaNangHoiUc_3,
                    KhaNangHoiUc_3_Text,
                    NgonNgu_1,
                    NgonNgu_1_Text,
                    NgonNgu_2,
                    NgonNgu_2_Text,
                    NgonNgu_3,
                    NgonNgu_3_Text,
                    NgonNgu_GiaiDoan3_1,
                    NgonNgu_GiaiDoan3_1_Text,
                    NgonNgu_GiaiDoan3_2,
                    NgonNgu_GiaiDoan3_2_Text,
                    NgonNgu_GiaiDoan3_3,
                    NgonNgu_GiaiDoan3_3_Text,
                    NgonNgu_GiaiDoan3_4,
                    NgonNgu_GiaiDoan3_4_Text,
                    NgonNgu_GiaiDoan3_5,
                    NgonNgu_GiaiDoan3_5_Text,
                    TuongTuong_1,
                    TuongTuong_1_Text,
                    TongDiem,
                    NGUOITAO,
                    NGUOISUA,
                    NGAYTAO,
                    NGAYSUA)  VALUES
                 (
				    :MaQuanLy,
                    :NgheNghiep,
                    :DiaChi,
                    :ChanDoan,
                    :NgayLamTest,
                    :MaNguoiThucHien,
                    :NguoiThucHien,
                    :DinhHuong_1,
                    :DinhHuong_1_Text,
                    :DinhHuong_2,
                    :DinhHuong_2_Text,
                    :DinhHuong_3,
                    :DinhHuong_3_Text,
                    :DinhHuong_4,
                    :DinhHuong_4_Text,
                    :DinhHuong_5,
                    :DinhHuong_5_Text,
                    :DinhHuong_6,
                    :DinhHuong_6_Text,
                    :DinhHuong_7,
                    :DinhHuong_7_Text,
                    :DinhHuong_8,
                    :DinhHuong_8_Text,
                    :KhaNangNhanThuc_1,
                    :KhaNangNhanThuc_1_Text,
                    :KhaNangNhanThuc_2,
                    :KhaNangNhanThuc_2_Text,
                    :KhaNangNhanThuc_3,
                    :KhaNangNhanThuc_3_Text,
                    :SuChuY_1,
                    :SuChuY_1_Text,
                    :SuChuY_2,
                    :SuChuY_2_Text,
                    :SuChuY_3,
                    :SuChuY_3_Text,
                    :SuChuY_4,
                    :SuChuY_4_Text,
                    :SuChuY_5,
                    :SuChuY_5_Text,
                    :SuChuY_6,
                    :SuChuY_6_Text,
                    :KhaNangHoiUc_1,
                    :KhaNangHoiUc_1_Text,
                    :KhaNangHoiUc_2,
                    :KhaNangHoiUc_2_Text,
                    :KhaNangHoiUc_3,
                    :KhaNangHoiUc_3_Text,
                    :NgonNgu_1,
                    :NgonNgu_1_Text,
                    :NgonNgu_2,
                    :NgonNgu_2_Text,
                    :NgonNgu_3,
                    :NgonNgu_3_Text,
                    :NgonNgu_GiaiDoan3_1,
                    :NgonNgu_GiaiDoan3_1_Text,
                    :NgonNgu_GiaiDoan3_2,
                    :NgonNgu_GiaiDoan3_2_Text,
                    :NgonNgu_GiaiDoan3_3,
                    :NgonNgu_GiaiDoan3_3_Text,
                    :NgonNgu_GiaiDoan3_4,
                    :NgonNgu_GiaiDoan3_4_Text,
                    :NgonNgu_GiaiDoan3_5,
                    :NgonNgu_GiaiDoan3_5_Text,
                    :TuongTuong_1,
                    :TuongTuong_1_Text,
                    :TongDiem,
                    :NGUOITAO,
                    :NGUOISUA,
                    :NGAYTAO,
                    :NGAYSUA
                 )  RETURNING ID INTO :ID";
                if (ketQua.ID != 0)
                {
                    sql = @"UPDATE DanhGiaTrangThaiTTTT SET 
                    MaQuanLy = :MaQuanLy,
                    NgheNghiep = :NgheNghiep,
                    DiaChi = :DiaChi,
                    ChanDoan = :ChanDoan,
                    NgayLamTest = :NgayLamTest,
                    MaNguoiThucHien = :MaNguoiThucHien,
                    NguoiThucHien = :NguoiThucHien,
                    DinhHuong_1 = :DinhHuong_1,
                    DinhHuong_1_Text = :DinhHuong_1_Text,
                    DinhHuong_2 = :DinhHuong_2,
                    DinhHuong_2_Text = :DinhHuong_2_Text,
                    DinhHuong_3 = :DinhHuong_3,
                    DinhHuong_3_Text = :DinhHuong_3_Text,
                    DinhHuong_4 = :DinhHuong_4,
                    DinhHuong_4_Text = :DinhHuong_4_Text,
                    DinhHuong_5 = :DinhHuong_5,
                    DinhHuong_5_Text = :DinhHuong_5_Text,
                    DinhHuong_6 = :DinhHuong_6,
                    DinhHuong_6_Text = :DinhHuong_6_Text,
                    DinhHuong_7 = :DinhHuong_7,
                    DinhHuong_7_Text = :DinhHuong_7_Text,
                    DinhHuong_8 = :DinhHuong_8,
                    DinhHuong_8_Text = :DinhHuong_8_Text,
                    KhaNangNhanThuc_1 = :KhaNangNhanThuc_1,
                    KhaNangNhanThuc_1_Text = :KhaNangNhanThuc_1_Text,
                    KhaNangNhanThuc_2 = :KhaNangNhanThuc_2,
                    KhaNangNhanThuc_2_Text = :KhaNangNhanThuc_2_Text,
                    KhaNangNhanThuc_3 = :KhaNangNhanThuc_3,
                    KhaNangNhanThuc_3_Text = :KhaNangNhanThuc_3_Text,
                    SuChuY_1 = :SuChuY_1,
                    SuChuY_1_Text = :SuChuY_1_Text,
                    SuChuY_2 = :SuChuY_2,
                    SuChuY_2_Text = :SuChuY_2_Text,
                    SuChuY_3 = :SuChuY_3,
                    SuChuY_3_Text = :SuChuY_3_Text,
                    SuChuY_4 = :SuChuY_4,
                    SuChuY_4_Text = :SuChuY_4_Text,
                    SuChuY_5 = :SuChuY_5,
                    SuChuY_5_Text = :SuChuY_5_Text,
                    SuChuY_6 = :SuChuY_6,
                    SuChuY_6_Text = :SuChuY_6_Text,
                    KhaNangHoiUc_1 = :KhaNangHoiUc_1,
                    KhaNangHoiUc_1_Text = :KhaNangHoiUc_1_Text,
                    KhaNangHoiUc_2 = :KhaNangHoiUc_2,
                    KhaNangHoiUc_2_Text = :KhaNangHoiUc_2_Text,
                    KhaNangHoiUc_3 = :KhaNangHoiUc_3,
                    KhaNangHoiUc_3_Text = :KhaNangHoiUc_3_Text,
                    NgonNgu_1 = :NgonNgu_1,
                    NgonNgu_1_Text = :NgonNgu_1_Text,
                    NgonNgu_2 = :NgonNgu_2,
                    NgonNgu_2_Text = :NgonNgu_2_Text,
                    NgonNgu_3 = :NgonNgu_3,
                    NgonNgu_3_Text = :NgonNgu_3_Text,
                    NgonNgu_GiaiDoan3_1 = :NgonNgu_GiaiDoan3_1,
                    NgonNgu_GiaiDoan3_1_Text = :NgonNgu_GiaiDoan3_1_Text,
                    NgonNgu_GiaiDoan3_2 = :NgonNgu_GiaiDoan3_2,
                    NgonNgu_GiaiDoan3_2_Text = :NgonNgu_GiaiDoan3_2_Text,
                    NgonNgu_GiaiDoan3_3 = :NgonNgu_GiaiDoan3_3,
                    NgonNgu_GiaiDoan3_3_Text = :NgonNgu_GiaiDoan3_3_Text,
                    NgonNgu_GiaiDoan3_4 = :NgonNgu_GiaiDoan3_4,
                    NgonNgu_GiaiDoan3_4_Text = :NgonNgu_GiaiDoan3_4_Text,
                    NgonNgu_GiaiDoan3_5 = :NgonNgu_GiaiDoan3_5,
                    NgonNgu_GiaiDoan3_5_Text = :NgonNgu_GiaiDoan3_5_Text,
                    TuongTuong_1 = :TuongTuong_1,
                    TuongTuong_1_Text = :TuongTuong_1_Text,
                    TongDiem = :TongDiem,
                    NGUOISUA = :NGUOISUA,
                    NGAYSUA = :NGAYSUA 
                    WHERE ID = " + ketQua.ID;
                }
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);

                Command.Parameters.Add(new MDB.MDBParameter("NGUOISUA", ketQua.NguoiSua));
                Command.Parameters.Add(new MDB.MDBParameter("NGAYSUA", ketQua.NgaySua));

                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", ketQua.MaQuanLy));

                Command.Parameters.Add(new MDB.MDBParameter("NgheNghiep", ketQua.NgheNghiep));
                Command.Parameters.Add(new MDB.MDBParameter("DiaChi", ketQua.DiaChi));
                Command.Parameters.Add(new MDB.MDBParameter("ChanDoan", ketQua.ChanDoan));
                Command.Parameters.Add(new MDB.MDBParameter("NgayLamTest", ketQua.NgayLamTest));
                Command.Parameters.Add(new MDB.MDBParameter("MaNguoiThucHien", ketQua.MaNguoiThucHien));
                Command.Parameters.Add(new MDB.MDBParameter("NguoiThucHien", ketQua.NguoiThucHien));

                Command.Parameters.Add(new MDB.MDBParameter("DinhHuong_1", ketQua.DinhHuong_1));
                Command.Parameters.Add(new MDB.MDBParameter("DinhHuong_1_Text", ketQua.DinhHuong_1_Text));
                Command.Parameters.Add(new MDB.MDBParameter("DinhHuong_2", ketQua.DinhHuong_2));
                Command.Parameters.Add(new MDB.MDBParameter("DinhHuong_2_Text", ketQua.DinhHuong_2_Text));
                Command.Parameters.Add(new MDB.MDBParameter("DinhHuong_3", ketQua.DinhHuong_3));
                Command.Parameters.Add(new MDB.MDBParameter("DinhHuong_3_Text", ketQua.DinhHuong_3_Text));
                Command.Parameters.Add(new MDB.MDBParameter("DinhHuong_4", ketQua.DinhHuong_4));
                Command.Parameters.Add(new MDB.MDBParameter("DinhHuong_4_Text", ketQua.DinhHuong_4_Text));
                Command.Parameters.Add(new MDB.MDBParameter("DinhHuong_5", ketQua.DinhHuong_5));
                Command.Parameters.Add(new MDB.MDBParameter("DinhHuong_5_Text", ketQua.DinhHuong_5_Text));
                Command.Parameters.Add(new MDB.MDBParameter("DinhHuong_6", ketQua.DinhHuong_6));
                Command.Parameters.Add(new MDB.MDBParameter("DinhHuong_6_Text", ketQua.DinhHuong_6_Text));
                Command.Parameters.Add(new MDB.MDBParameter("DinhHuong_7", ketQua.DinhHuong_7));
                Command.Parameters.Add(new MDB.MDBParameter("DinhHuong_7_Text", ketQua.DinhHuong_7_Text));
                Command.Parameters.Add(new MDB.MDBParameter("DinhHuong_8", ketQua.DinhHuong_8));
                Command.Parameters.Add(new MDB.MDBParameter("DinhHuong_8_Text", ketQua.DinhHuong_8_Text));

                Command.Parameters.Add(new MDB.MDBParameter("KhaNangNhanThuc_1", ketQua.KhaNangNhanThuc_1));
                Command.Parameters.Add(new MDB.MDBParameter("KhaNangNhanThuc_1_Text", ketQua.KhaNangNhanThuc_1_Text));
                Command.Parameters.Add(new MDB.MDBParameter("KhaNangNhanThuc_2", ketQua.KhaNangNhanThuc_2));
                Command.Parameters.Add(new MDB.MDBParameter("KhaNangNhanThuc_2_Text", ketQua.KhaNangNhanThuc_2_Text));
                Command.Parameters.Add(new MDB.MDBParameter("KhaNangNhanThuc_3", ketQua.KhaNangNhanThuc_3));
                Command.Parameters.Add(new MDB.MDBParameter("KhaNangNhanThuc_3_Text", ketQua.KhaNangNhanThuc_3_Text));

                Command.Parameters.Add(new MDB.MDBParameter("SuChuY_1", ketQua.SuChuY_1));
                Command.Parameters.Add(new MDB.MDBParameter("SuChuY_1_Text", ketQua.SuChuY_1_Text));
                Command.Parameters.Add(new MDB.MDBParameter("SuChuY_2", ketQua.SuChuY_2));
                Command.Parameters.Add(new MDB.MDBParameter("SuChuY_2_Text", ketQua.SuChuY_2_Text));
                Command.Parameters.Add(new MDB.MDBParameter("SuChuY_3", ketQua.SuChuY_3));
                Command.Parameters.Add(new MDB.MDBParameter("SuChuY_3_Text", ketQua.SuChuY_3_Text));
                Command.Parameters.Add(new MDB.MDBParameter("SuChuY_4", ketQua.SuChuY_4));
                Command.Parameters.Add(new MDB.MDBParameter("SuChuY_4_Text", ketQua.SuChuY_4_Text));
                Command.Parameters.Add(new MDB.MDBParameter("SuChuY_5", ketQua.SuChuY_5));
                Command.Parameters.Add(new MDB.MDBParameter("SuChuY_5_Text", ketQua.SuChuY_5_Text));
                Command.Parameters.Add(new MDB.MDBParameter("SuChuY_6", ketQua.SuChuY_6));
                Command.Parameters.Add(new MDB.MDBParameter("SuChuY_6_Text", ketQua.SuChuY_6_Text));

                Command.Parameters.Add(new MDB.MDBParameter("KhaNangHoiUc_1", ketQua.KhaNangHoiUc_1));
                Command.Parameters.Add(new MDB.MDBParameter("KhaNangHoiUc_1_Text", ketQua.KhaNangHoiUc_1_Text));
                Command.Parameters.Add(new MDB.MDBParameter("KhaNangHoiUc_2", ketQua.KhaNangHoiUc_2));
                Command.Parameters.Add(new MDB.MDBParameter("KhaNangHoiUc_2_Text", ketQua.KhaNangHoiUc_2_Text));
                Command.Parameters.Add(new MDB.MDBParameter("KhaNangHoiUc_3", ketQua.KhaNangHoiUc_3));
                Command.Parameters.Add(new MDB.MDBParameter("KhaNangHoiUc_3_Text", ketQua.KhaNangHoiUc_3_Text));

                Command.Parameters.Add(new MDB.MDBParameter("NgonNgu_1", ketQua.NgonNgu_1));
                Command.Parameters.Add(new MDB.MDBParameter("NgonNgu_1_Text", ketQua.NgonNgu_1_Text));
                Command.Parameters.Add(new MDB.MDBParameter("NgonNgu_2", ketQua.NgonNgu_2));
                Command.Parameters.Add(new MDB.MDBParameter("NgonNgu_2_Text", ketQua.NgonNgu_2_Text));
                Command.Parameters.Add(new MDB.MDBParameter("NgonNgu_3", ketQua.NgonNgu_3));
                Command.Parameters.Add(new MDB.MDBParameter("NgonNgu_3_Text", ketQua.NgonNgu_3_Text));

                Command.Parameters.Add(new MDB.MDBParameter("NgonNgu_GiaiDoan3_1", ketQua.NgonNgu_GiaiDoan3_1));
                Command.Parameters.Add(new MDB.MDBParameter("NgonNgu_GiaiDoan3_1_Text", ketQua.NgonNgu_GiaiDoan3_1_Text));
                Command.Parameters.Add(new MDB.MDBParameter("NgonNgu_GiaiDoan3_2", ketQua.NgonNgu_GiaiDoan3_2));
                Command.Parameters.Add(new MDB.MDBParameter("NgonNgu_GiaiDoan3_2_Text", ketQua.NgonNgu_GiaiDoan3_2_Text));
                Command.Parameters.Add(new MDB.MDBParameter("NgonNgu_GiaiDoan3_3", ketQua.NgonNgu_GiaiDoan3_3));
                Command.Parameters.Add(new MDB.MDBParameter("NgonNgu_GiaiDoan3_3_Text", ketQua.NgonNgu_GiaiDoan3_3_Text));
                Command.Parameters.Add(new MDB.MDBParameter("NgonNgu_GiaiDoan3_4", ketQua.NgonNgu_GiaiDoan3_4));
                Command.Parameters.Add(new MDB.MDBParameter("NgonNgu_GiaiDoan3_4_Text", ketQua.NgonNgu_GiaiDoan3_4_Text));
                Command.Parameters.Add(new MDB.MDBParameter("NgonNgu_GiaiDoan3_5", ketQua.NgonNgu_GiaiDoan3_5));
                Command.Parameters.Add(new MDB.MDBParameter("NgonNgu_GiaiDoan3_5_Text", ketQua.NgonNgu_GiaiDoan3_5_Text));

                Command.Parameters.Add(new MDB.MDBParameter("TuongTuong_1", ketQua.TuongTuong_1));
                Command.Parameters.Add(new MDB.MDBParameter("TuongTuong_1_Text", ketQua.TuongTuong_1_Text));
                Command.Parameters.Add(new MDB.MDBParameter("TongDiem", ketQua.TongDiem));

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
                XuLyLoi.Handle(ex);
            }
            return false;
        }
    }
}
