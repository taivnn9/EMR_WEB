using System;
using System.Collections.Generic;
using System.Data;
using EMR.KyDienTu;

namespace EMR_MAIN.DATABASE.Other
{
    public class HSCS_TTBenhNhanRaVien
    {
        [MoTaDuLieu("Mã định danh")]
        public long id { get; set; }
        public decimal id_hscs_ttbenhnhan { get; set; }
        public int KetQuaDieuTri { get; set; }
        public int TTRaVien { get; set; }
        public int YThucNB { get; set; }
        public string TTRaVien_HoHap_NhipTho { get; set; }
        public string TTRaVien_HoHap_SPO2 { get; set; }
        public int TTRaVien_HoHap { get; set; }
        public string DHST_Mach { get; set; }
        public string DHST_NhietDo { get; set; }
        public string DHST_HuyetAp { get; set; }
        public int TTRaVien_PTVC { get; set; }
        public int TuVanNB { get; set; }
        [MoTaDuLieu("Họ tên điều dưỡng")]
		public string DieuDuongChamSoc{ get; set; }
        public string MaNVDieuDuongChamSoc { get; set; }
        [MoTaDuLieu("Họ tên điều dưỡng")]
		public string DieuDuongTruong { get; set; }
        public string MaNVDieuDuongTruong { get; set; }
        [MoTaDuLieu("Ngày tạo", null, 0, 0)]
		public DateTime NgayTao { get; set; }
        [MoTaDuLieu("Người tạo", null, 0, 0)]
		public string NguoiTao { get; set; }
        [MoTaDuLieu("Ngày sửa", null, 0, 0)]
		public DateTime NgaySua { get; set; }
        [MoTaDuLieu("Người sửa", null, 0, 0)]
		public string NguoiSua { get; set; }
        [MoTaDuLieu("Tên file ký")]
		public string TenFileKy { get; set; }
        [MoTaDuLieu("Tên người ký")]
		public string UserNameKy { get; set; }
        [MoTaDuLieu("Ngày ký")]
		public DateTime NgayKy { get; set; }
        [MoTaDuLieu("Tên máy tính ký")]
		public string ComputerKyTen { get; set; }
        public string MaSoKyTen { get; set; }
        [MoTaDuLieu("Đã ký", null, 0, 0)]
		public bool DaKy { get; set; }
        [MoTaDuLieu("Chọn", null, 0, 0)]
		public bool Chon { get; set; }
    }
    public class HSCS_TTBenhNhanRaVienFunc
    {
        public const string TableName = "HSCS_TTBenhNhanRaVien";
        public const string TablePrimaryKeyName = "ID";
        public static List<HSCS_TTBenhNhanRaVien> GetListData(MDB.MDBConnection _OracleConnection, decimal id_hscs_ttbenhnhan)
        {
            List<HSCS_TTBenhNhanRaVien> list = new List<HSCS_TTBenhNhanRaVien>();
            try
            {
                string sql = @"SELECT * FROM hscs_ttbenhnhanravien where id_hscs_ttbenhnhan = :id_hscs_ttbenhnhan";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, _OracleConnection);
                Command.Parameters.Add(new MDB.MDBParameter("id_hscs_ttbenhnhan", id_hscs_ttbenhnhan));
                MDB.MDBDataReader DataReader = Command.ExecuteReader();
                while (DataReader.Read())
                {
                    HSCS_TTBenhNhanRaVien data = new HSCS_TTBenhNhanRaVien();
                    data.id = DataReader.GetLong("id");
                    data.id_hscs_ttbenhnhan = DataReader.GetDecimal("id_hscs_ttbenhnhan");
                    data.KetQuaDieuTri = DataReader.GetInt("ketquadieutri");
                    data.TTRaVien = DataReader.GetInt("ttravien");
                    data.YThucNB = DataReader.GetInt("ythucbn");
                    data.TTRaVien_HoHap_NhipTho = DataReader.GetString("TTRaVien_HoHap_NhipTho");
                    data.TTRaVien_HoHap_SPO2 = DataReader.GetString("TTRaVien_HoHap_SPO2");
                    data.TTRaVien_HoHap = DataReader.GetInt("DienThoaiLienHe");
                    data.DHST_HuyetAp = DataReader.GetString("DHST_HuyetAp");
                    data.DHST_Mach = DataReader.GetString("DHST_Mach");
                    data.DHST_NhietDo = DataReader.GetString("DHST_NhietDo");
                    data.TTRaVien_PTVC = DataReader.GetInt("ptvanchuyen");
                    data.TuVanNB = DataReader.GetInt("tuvan");
                    data.DieuDuongChamSoc = DataReader.GetString("DieuDuongChamSoc");
                    data.DieuDuongTruong = DataReader.GetString("DieuDuongTruong");
                    data.MaNVDieuDuongChamSoc = DataReader.GetString("MaNVDieuDuongChamSoc");
                    data.MaNVDieuDuongTruong = DataReader.GetString("MaNVDieuDuongTruong");
                    data.NguoiTao = DataReader.GetString("NguoiTao");
                    data.NguoiSua = DataReader.GetString("NguoiSua");
                    data.NgayTao = ConDB_DateTime(DataReader["NgayTao"]);
                    data.NgaySua = ConDB_DateTime(DataReader["NgaySua"]);
                    data.ComputerKyTen = DataReader.GetString("computerkyten");
                    data.MaSoKyTen = DataReader.GetString("MaSoKyTen");
                    data.TenFileKy = DataReader.GetString("TenFileKy");
                    data.UserNameKy = DataReader.GetString("UserNameKy");
                    list.Add(data);
                }
            }
            catch (Exception ex) { XuLyLoi.Handle(ex); }
            return list;
        }
        public static HSCS_TTBenhNhanRaVien GetDataByIDTTBenhNhan(MDB.MDBConnection _OracleConnection, decimal id_hscs_ttbenhnhan)
        {
            HSCS_TTBenhNhanRaVien data = null;
            try
            {
                string sql = @"SELECT * FROM hscs_ttbenhnhanravien where id_hscs_ttbenhnhan = :id_hscs_ttbenhnhan";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, _OracleConnection);
                Command.Parameters.Add(new MDB.MDBParameter("id_hscs_ttbenhnhan", id_hscs_ttbenhnhan));
                MDB.MDBDataReader DataReader = Command.ExecuteReader();
                while (DataReader.Read())
                {
                    data = new HSCS_TTBenhNhanRaVien();
                    data.id = DataReader.GetLong("id");
                    data.id_hscs_ttbenhnhan = DataReader.GetDecimal("id_hscs_ttbenhnhan");
                    data.KetQuaDieuTri = DataReader.GetInt("ketquadieutri");
                    data.TTRaVien = DataReader.GetInt("ttravien");
                    data.YThucNB = DataReader.GetInt("ythucbn");
                    data.TTRaVien_HoHap_NhipTho = DataReader.GetString("TTRaVien_HoHap_NhipTho");
                    data.TTRaVien_HoHap_SPO2 = DataReader.GetString("TTRaVien_HoHap_SPO2");
                    data.TTRaVien_HoHap = DataReader.GetInt("TTRaVien_HoHap");
                    data.DHST_HuyetAp = DataReader.GetString("DHST_HuyetAp");
                    data.DHST_Mach = DataReader.GetString("DHST_Mach");
                    data.DHST_NhietDo = DataReader.GetString("DHST_NhietDo");
                    data.TTRaVien_PTVC = DataReader.GetInt("ptvanchuyen");
                    data.TuVanNB = DataReader.GetInt("tuvan");
                    data.DieuDuongChamSoc = DataReader.GetString("DieuDuongChamSoc");
                    data.DieuDuongTruong = DataReader.GetString("DieuDuongTruong");
                    data.MaNVDieuDuongChamSoc = DataReader.GetString("MaNVDieuDuongChamSoc");
                    data.MaNVDieuDuongTruong = DataReader.GetString("MaNVDieuDuongTruong");
                    data.NguoiTao = DataReader.GetString("NguoiTao");
                    data.NguoiSua = DataReader.GetString("NguoiSua");
                    data.NgayTao = ConDB_DateTime(DataReader["NgayTao"]);
                    data.NgaySua = ConDB_DateTime(DataReader["NgaySua"]);
                    data.ComputerKyTen = DataReader.GetString("computerkyten");
                    data.MaSoKyTen = DataReader.GetString("MaSoKyTen");
                    data.TenFileKy = DataReader.GetString("TenFileKy");
                    data.UserNameKy = DataReader.GetString("UserNameKy");
                }
            }
            catch (Exception ex) { XuLyLoi.Handle(ex); }
            return data;
        }
        public static bool InsertOrUpdate(MDB.MDBConnection MyConnection, ref HSCS_TTBenhNhanRaVien data)
        {
            try
            {
                string sql = @"INSERT INTO hscs_ttbenhnhanravien
                (
                    id_hscs_ttbenhnhan,
                    ketquadieutri,
                    ttravien,
                    ythucbn,
                    TTRaVien_HoHap_NhipTho,
                    TTRaVien_HoHap_SPO2,
                    TTRaVien_HoHap,
                    DHST_Mach,
                    DHST_NhietDo,
                    DHST_HuyetAp,
                    ptvanchuyen,
                    tuvan,
                    DieuDuongChamSoc,
                    MANVDieuDuongChamSoc,
                    DieuDuongTruong,
                    manvDieuDuongTruong)  VALUES
                 (
                    :id_hscs_ttbenhnhan,
                    :ketquadieutri,
                    :ttravien,
                    :ythucbn,
                    :TTRaVien_HoHap_NhipTho,
                    :TTRaVien_HoHap_SPO2,
                    :TTRaVien_HoHap,
                    :DHST_Mach,
                    :DHST_NhietDo,
                    :DHST_HuyetAp,
                    :ptvanchuyen,
                    :tuvan,
                    :DieuDuongChamSoc,
                    :MANVDieuDuongChamSoc,
                    :DieuDuongTruong,
                    :manvDieuDuongTruong 
                 )  RETURNING ID INTO :ID";
                if (data.id != Decimal.Zero)
                {
                    sql = @"UPDATE hscs_ttbenhnhanravien SET 
                    
                    id_hscs_ttbenhnhan=:id_hscs_ttbenhnhan ,
                    ketquadieutri=:ketquadieutri ,
                    ttravien=:ttravien ,
                    ythucbn=: ythucbn,
                    TTRaVien_HoHap_NhipTho=:TTRaVien_HoHap_NhipTho ,
                    TTRaVien_HoHap_SPO2=: TTRaVien_HoHap_SPO2,
                    TTRaVien_HoHap=:TTRaVien_HoHap,
                    DHST_Mach=:DHST_Mach ,
                    DHST_NhietDo=: DHST_NhietDo,
                    DHST_HuyetAp=:DHST_HuyetAp ,
                    ptvanchuyen=:ptvanchuyen ,
                    tuvan=: tuvan,
                    DieuDuongChamSoc=: DieuDuongChamSoc,
                    MANVDieuDuongChamSoc=:MANVDieuDuongChamSoc ,
                    DieuDuongTruong=:DieuDuongTruong ,
                    manvDieuDuongTruong=: manvDieuDuongTruong 
                    WHERE ID = " + data.id;
                }
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
                Command.Parameters.Add(new MDB.MDBParameter("id_hscs_ttbenhnhan", data.id_hscs_ttbenhnhan));
                Command.Parameters.Add(new MDB.MDBParameter("ketquadieutri", data.KetQuaDieuTri));
                Command.Parameters.Add(new MDB.MDBParameter("ttravien", data.TTRaVien));
                Command.Parameters.Add(new MDB.MDBParameter("ythucbn", data.YThucNB));
                Command.Parameters.Add(new MDB.MDBParameter("TTRaVien_HoHap_NhipTho", data.TTRaVien_HoHap_NhipTho));
                Command.Parameters.Add(new MDB.MDBParameter("TTRaVien_HoHap_SPO2", data.TTRaVien_HoHap_SPO2));
                Command.Parameters.Add(new MDB.MDBParameter("TTRaVien_HoHap", data.TTRaVien_HoHap));
                Command.Parameters.Add(new MDB.MDBParameter("DHST_Mach", data.DHST_Mach));
                Command.Parameters.Add(new MDB.MDBParameter("DHST_NhietDo", data.DHST_NhietDo));
                Command.Parameters.Add(new MDB.MDBParameter("DHST_HuyetAp", data.DHST_HuyetAp));
                Command.Parameters.Add(new MDB.MDBParameter("ptvanchuyen", data.TTRaVien_PTVC));
                Command.Parameters.Add(new MDB.MDBParameter("tuvan", data.TuVanNB));
                Command.Parameters.Add(new MDB.MDBParameter("DieuDuongChamSoc", data.DieuDuongChamSoc));
                Command.Parameters.Add(new MDB.MDBParameter("MaNVDieuDuongChamSoc", data.MaNVDieuDuongChamSoc));
                Command.Parameters.Add(new MDB.MDBParameter("DieuDuongTruong", data.DieuDuongTruong));
                Command.Parameters.Add(new MDB.MDBParameter("MaNVDieuDuongTruong", data.MaNVDieuDuongTruong));
                if (data.id.Equals(Decimal.Zero))
                {
                    Command.Parameters.Add(new MDB.MDBParameter("ID", data.id));
                }
                /*Command.Parameters.Add(new MDB.MDBParameter("nguoisua", data.NguoiSua));
                Command.Parameters.Add(new MDB.MDBParameter("ngaysua", data.NgaySua));
                if (data.id.Equals(Decimal.Zero))
                {
                    Command.Parameters.Add(new MDB.MDBParameter("ID", data.id));
                    Command.Parameters.Add(new MDB.MDBParameter("NGUOITAO", data.NguoiTao));
                    Command.Parameters.Add(new MDB.MDBParameter("NGAYTAO", data.NgayTao));
                }*/
                Command.BindByName = true;
                int n = Command.ExecuteNonQuery();
                if (data.id.Equals(Decimal.Zero))
                {
                    long nextval = Convert.ToInt64((Command.Parameters["ID"] as MDB.MDBParameter).Value);
                    data.id = nextval;
                }
                return n > 0 ? true : false;
            }
            catch (Exception ex)
            {
                XuLyLoi.Handle(ex);
            }
            return false;
        }
        public static bool deleteByTTBenhNhan(MDB.MDBConnection MyConnection, decimal id_hscs_ttbenhnhan)
        {
            try
            {
                int n = 0;
                string sql = "DELETE FROM hscs_ttbenhnhanravien WHERE id_hscs_ttbenhnhan = :id_hscs_ttbenhnhan";
                MDB.MDBCommand command;
                using (command = new MDB.MDBCommand(sql, MyConnection)) {
                    command.Parameters.Add(new MDB.MDBParameter("id_hscs_ttbenhnhan", id_hscs_ttbenhnhan));
                    command.BindByName = true;
                    n = command.ExecuteNonQuery();
                }   
                return n > 0 ? true : false;
            }
            catch (Exception ex)
            {
                XuLyLoi.Handle(ex);
            }
            return false;
        }
        public static DataSet getDataSet(MDB.MDBConnection MyConnection, decimal ID)
        {
            string sql = @"SELECT
                P.* 
            FROM
                hscs_ttbenhnhanravien P
            WHERE
                ID = " + ID;

            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);

            MDB.MDBDataAdapter adt = new MDB.MDBDataAdapter(Command);
            var ds = new DataSet();

            adt.Fill(ds, "PT");

            DataTable thongTinVien = new DataTable("HEADER");

            thongTinVien.Columns.Add("BENHVIEN");
            thongTinVien.Columns.Add("KHOA");
            thongTinVien.Columns.Add("MABENHAN");
			if (XemBenhAn._HanhChinhBenhNhan == null) XemBenhAn._HanhChinhBenhNhan = new HanhChinhBenhNhan();
            if (XemBenhAn._ThongTinDieuTri == null) XemBenhAn._ThongTinDieuTri = new ThongTinDieuTri();
            thongTinVien.Rows.Add(XemBenhAn._HanhChinhBenhNhan.BenhVien, XemBenhAn._ThongTinDieuTri.Khoa, XemBenhAn._ThongTinDieuTri.MaBenhAn);
            ds.Tables.Add(thongTinVien);

            return ds;
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
