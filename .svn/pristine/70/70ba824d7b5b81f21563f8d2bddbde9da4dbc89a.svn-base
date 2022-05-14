
using EMR.KyDienTu;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using PMS.Access; 

namespace EMR_MAIN.DATABASE.Other
{
    public class PhieuTheoDoiSoSinh : ThongTinKy
    {
        public PhieuTheoDoiSoSinh()
        {
            TableName = "PHIEUTHEODOISOSINH";
            TablePrimaryKeyName = "ID";
            IDMauPhieu = (int)DanhMucPhieu.TDSS;
            TenMauPhieu = DanhMucPhieu.TDSS.Description();
        }
        [MoTaDuLieu("Mã định danh")]
		public decimal IDPhieuTheoDoiSoSinh { get; set; }
		[MoTaDuLieu("Sở Y Tế")]
		public string SoYTe { get; set; }
        public string MaYTe { get; set; }
        [MoTaDuLieu("Bệnh viện")]
		public string BenhVien { get; set; }
        [MoTaDuLieu("Tên khoa")]
		public string TenKhoa { get; set; }
        [MoTaDuLieu("Mã bệnh án")]
		public string MaBenhAn { get; set; }
        [MoTaDuLieu("Mã bệnh nhân")]
		public string MaBenhNhan { get; set; }
        [MoTaDuLieu("Họ và tên bệnh nhân")]
		public string TenBenhNhan { get; set; }
        [MoTaDuLieu("Tuổi bệnh nhân")]
		public string Tuoi { get; set; }
        [MoTaDuLieu("Địa chỉ nhà bệnh nhân")]
		public string DiaChi { get; set; }
        [MoTaDuLieu("Buồng")]
		public string Buong { get; set; }
        [MoTaDuLieu("Giường")]
		public string Giuong { get; set; }
        [MoTaDuLieu("Chẩn đoán bệnh")]
		public string ChanDoan { get; set; }
        public DateTime? NgayGioSinh { get; set; }
        public string YeuCauKiemTra { get; set; }
        public string ChiSoAppaCon { get; set; }
        [MoTaDuLieu("Giới tính bệnh nhân")]
		public string GioiTinhCon { get; set; }
        public string CanNangCon { get; set; }
        public string DiTatCon { get; set; }
        public string ThongTinTheoDoiCon { get; set; }
        [MoTaDuLieu("Mã điều dưỡng")]
		public string MaDieuDuong { get; set; }
        public string TenDieuDuong { get; set; }
        public string MaBsTruongKhoa { get; set; }
        public string TenBsTruongKhoa { get; set; }
        public string KyTen { get; set; }
        [MoTaDuLieu("Mã quản lý: mã duy nhất trong 1 đợt khám chữa bệnh (kcb), không trùng giữa các đợt kcb khác nhau","",1)]
		public decimal MaQuanLy { get; set; }

    }
    public class ThongTinTheoDoiCon
    {
        public DateTime ThoiGian { get; set; }
        public string TinhTrangTreSoSinh { get; set; }
        public string SuTri { get; set; }
        public string ThuocVatTu { get; set; }
    }
    public class PhieuTheoDoiSoSinhFunc
    {
        public static bool InsertOrUpdate(MDB.MDBConnection MyConnection, ref PhieuTheoDoiSoSinh data)
        {
            string sql = "INSERT INTO PHIEUTHEODOISOSINH"
                    + " (SoYTe, MaYTe, BenhVien, TenKhoa, MaBenhAn, MaBenhNhan, TenBenhNhan, Tuoi, DiaChi, Buong, Giuong, ChanDoan, NgayGioSinh, YeuCauKiemTra,"
                    + " ChiSoAppaCon, GioiTinhCon, CanNangCon, DiTatCon, ThongTinTheoDoiCon, MaDieuDuong, TenDieuDuong, MaBsTruongKhoa, TenBsTruongKhoa, MaQuanLy, KyTen)"
                    + " VALUES (:SoYTe, :MaYTe, :BenhVien, :TenKhoa, :MaBenhAn, :MaBenhNhan, :TenBenhNhan, :Tuoi, :DiaChi, :Buong, :Giuong, :ChanDoan, :NgayGioSinh, :YeuCauKiemTra,"
                    + " :ChiSoAppaCon, :GioiTinhCon, :CanNangCon, :DiTatCon, :ThongTinTheoDoiCon, :MaDieuDuong, :TenDieuDuong, :MaBsTruongKhoa, :TenBsTruongKhoa, :MaQuanLy, :KyTen) " +
                    " RETURNING IDPHIEUTHEODOISOSINH INTO :IDPHIEUTHEODOISOSINH";
            if(data.IDPhieuTheoDoiSoSinh != Decimal.Zero)
                 sql = "UPDATE PHIEUTHEODOISOSINH"
                     + " SET SoYTe = :SoYTe, MaYTe= :MaYTe, BenhVien= :BenhVien, TenKhoa= :TenKhoa,"
                     + " MaBenhAn= :MaBenhAn, MaBenhNhan= :MaBenhNhan, TenBenhNhan= :TenBenhNhan, Tuoi= :Tuoi,"
                     + " DiaChi= :DiaChi, Buong= :Buong, Giuong= :Giuong, ChanDoan= :ChanDoan, NgayGioSinh= :NgayGioSinh,"
                     + " YeuCauKiemTra= :YeuCauKiemTra, ChiSoAppaCon= :ChiSoAppaCon, GioiTinhCon= :GioiTinhCon,"
                     + " CanNangCon= :CanNangCon, DiTatCon = :DiTatCon, ThongTinTheoDoiCon=:ThongTinTheoDoiCon,"
                     + " MaDieuDuong= :MaDieuDuong, TenDieuDuong = :TenDieuDuong, MaBsTruongKhoa=:MaBsTruongKhoa, TenBsTruongKhoa=:TenBsTruongKhoa,"
                     + " KyTen= :KyTen, MaQuanLy= :MaQuanLy"
                     + " WHERE IDPhieuTheoDoiSoSinh = " + data.IDPhieuTheoDoiSoSinh;

            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);

            Command.Parameters.Add(new MDB.MDBParameter("SoYTe", data.SoYTe));
            Command.Parameters.Add(new MDB.MDBParameter("MaYTe", data.MaYTe));
            Command.Parameters.Add(new MDB.MDBParameter("BenhVien", data.BenhVien));
            Command.Parameters.Add(new MDB.MDBParameter("TenKhoa", data.TenKhoa));
            Command.Parameters.Add(new MDB.MDBParameter("MaBenhAn", data.MaBenhAn));
            Command.Parameters.Add(new MDB.MDBParameter("MaBenhNhan", data.MaBenhNhan));
            Command.Parameters.Add(new MDB.MDBParameter("TenBenhNhan", data.TenBenhNhan));
            Command.Parameters.Add(new MDB.MDBParameter("Tuoi", data.Tuoi));
            Command.Parameters.Add(new MDB.MDBParameter("DiaChi", data.DiaChi));
            Command.Parameters.Add(new MDB.MDBParameter("Buong", data.Buong));
            Command.Parameters.Add(new MDB.MDBParameter("Giuong", data.Giuong));
            Command.Parameters.Add(new MDB.MDBParameter("ChanDoan", data.ChanDoan));
            Command.Parameters.Add(new MDB.MDBParameter("NgayGioSinh", data.NgayGioSinh));
            Command.Parameters.Add(new MDB.MDBParameter("YeuCauKiemTra", data.YeuCauKiemTra));
            Command.Parameters.Add(new MDB.MDBParameter("ChiSoAppaCon", data.ChiSoAppaCon));
            Command.Parameters.Add(new MDB.MDBParameter("GioiTinhCon", data.GioiTinhCon));
            Command.Parameters.Add(new MDB.MDBParameter("CanNangCon", data.CanNangCon));
            Command.Parameters.Add(new MDB.MDBParameter("DiTatCon", data.DiTatCon));
            Command.Parameters.Add(new MDB.MDBParameter("ThongTinTheoDoiCon", data.ThongTinTheoDoiCon));
            Command.Parameters.Add(new MDB.MDBParameter("MaDieuDuong", data.MaDieuDuong));
            Command.Parameters.Add(new MDB.MDBParameter("TenDieuDuong", data.TenDieuDuong));
            Command.Parameters.Add(new MDB.MDBParameter("MaBsTruongKhoa", data.MaBsTruongKhoa));
            Command.Parameters.Add(new MDB.MDBParameter("TenBsTruongKhoa", data.TenBsTruongKhoa));
            Command.Parameters.Add(new MDB.MDBParameter("KyTen", data.KyTen));
            Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", data.MaQuanLy));
            if (data.IDPhieuTheoDoiSoSinh.Equals(Decimal.Zero))
            {
                Command.Parameters.Add(new MDB.MDBParameter("IDPHIEUTHEODOISOSINH", data.IDPhieuTheoDoiSoSinh));
            }
            Command.BindByName = true;
            int n = Command.ExecuteNonQuery();
            if (data.IDPhieuTheoDoiSoSinh.Equals(Decimal.Zero))
            {
                decimal nextval = Convert.ToInt64((Command.Parameters["IDPHIEUTHEODOISOSINH"] as MDB.MDBParameter).Value);
                data.IDPhieuTheoDoiSoSinh = nextval;
            }

            return n > 0 ? true : false;
            return n > 0;
        }

        public static List<PhieuTheoDoiSoSinh> GetData(MDB.MDBConnection MyConnection, decimal MaQuanLy)
        {
            List<PhieuTheoDoiSoSinh> lstData = new List<PhieuTheoDoiSoSinh>();
            string sql = @"SELECT * FROM PHIEUTHEODOISOSINH WHERE MaQuanLy = :MaQuanLy ";
            sql += " ORDER BY IDPhieuTheoDoiSoSinh desc";
            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
            Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", MaQuanLy));
            MDB.MDBDataReader DataReader = Command.ExecuteReader();
            while (DataReader.Read())
            {
                PhieuTheoDoiSoSinh item = new PhieuTheoDoiSoSinh();
                item.IDPhieuTheoDoiSoSinh = decimal.Parse(DataReader["IDPhieuTheoDoiSoSinh"].ToString());
                item.SoYTe = DataReader["SoYTe"].ToString();
                item.MaYTe = DataReader["MaYTe"].ToString();
                item.BenhVien = DataReader["BenhVien"].ToString();
                item.TenKhoa = DataReader["TenKhoa"].ToString();
                item.MaBenhAn = DataReader["MaBenhAn"].ToString();
                item.MaBenhNhan = DataReader["MaBenhNhan"].ToString();
                item.TenBenhNhan = DataReader["TenBenhNhan"].ToString();
                item.Tuoi = DataReader["Tuoi"].ToString();
                item.DiaChi = DataReader["DiaChi"].ToString();
                item.Buong = DataReader["Buong"].ToString();
                item.Giuong = DataReader["Giuong"].ToString();
                item.ChanDoan = DataReader["ChanDoan"].ToString();
                try
                {
                    item.NgayGioSinh = DataReader["NgayGioSinh"] != DBNull.Value ? (DateTime?) Convert.ToDateTime(DataReader["NgayGioSinh"]) : null;
                }
                catch { }
                item.YeuCauKiemTra = DataReader["YeuCauKiemTra"].ToString();
                item.ChiSoAppaCon = DataReader["ChiSoAppaCon"].ToString();
                item.GioiTinhCon = DataReader["GioiTinhCon"].ToString();
                item.CanNangCon = DataReader["CanNangCon"].ToString();
                item.DiTatCon = DataReader["DiTatCon"].ToString();
                item.ThongTinTheoDoiCon = DataReader["ThongTinTheoDoiCon"].ToString();
                item.MaDieuDuong = DataReader["MaDieuDuong"].ToString();
                item.TenDieuDuong = DataReader["TenDieuDuong"].ToString();
                item.MaBsTruongKhoa = DataReader["MaBsTruongKhoa"].ToString();
                item.TenBsTruongKhoa = DataReader["TenBsTruongKhoa"].ToString();
                item.KyTen = DataReader["KyTen"].ToString();
                item.MaQuanLy = decimal.Parse(DataReader["MaQuanLy"].ToString());
                lstData.Add(item);
            }
            return lstData;
        }

         public static DataSet GetDataSetByDate(MDB.MDBConnection MyConnection, decimal IdPhieuSoSinh,  DateTime? _DateFrom, DateTime? _DateTo)
         {
             string sql = @"SELECT  P.BENHVIEN,
                                    P.TENKHOA,
                                    P.MAYTE,
                                    P.TENBENHNHAN,
                                    P.DIACHI,
                                    P.NGAYGIOSINH,
                                    P.CHANDOAN,
                                    P.YEUCAUKIEMTRA,
                                    P.CHISOAPPACON,
                                    P.GIOITINHCON,
                                    P.CANNANGCON,
                                    P.DITATCON,
                                    P.TENDIEUDUONG,
                                    P.TENBSTRUONGKHOA 
                                    FROM PHIEUTHEODOISOSINH P WHERE IDPHIEUTHEODOISOSINH=" + IdPhieuSoSinh;
             MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
             MDB.MDBDataAdapter adt = new MDB.MDBDataAdapter(Command);

             var ds = new DataSet();
             adt.Fill(ds, "TDSS");

            sql = @"SELECT THONGTINTHEODOICON FROM PHIEUTHEODOISOSINH WHERE IDPHIEUTHEODOISOSINH=" + IdPhieuSoSinh;
            Command = new MDB.MDBCommand(sql, MyConnection);
            Command.BindByName = true;
            MDB.MDBDataReader DataReader = Command.ExecuteReader();
            List<ThongTinTheoDoiCon> lstThongTinTheoDoiCon = new List<ThongTinTheoDoiCon>();
            while (DataReader.Read())
            {
                lstThongTinTheoDoiCon = JsonConvert.DeserializeObject<List<ThongTinTheoDoiCon>>(DataReader["THONGTINTHEODOICON"].ToString());
            }
            List<ThongTinTheoDoiCon> lstSelect = lstThongTinTheoDoiCon;
            if (_DateFrom != null && _DateFrom > DateTime.MinValue
                && _DateTo != null && _DateTo > _DateFrom) {
                lstSelect = lstThongTinTheoDoiCon.Where(x => (x.ThoiGian >= _DateFrom && x.ThoiGian <= _DateTo)).ToList();
            }
            else if (_DateFrom != null && _DateFrom > DateTime.MinValue
                     && (_DateTo == null || _DateTo == DateTime.MinValue))
                lstSelect = lstThongTinTheoDoiCon.Where(x => x.ThoiGian > _DateFrom).ToList();
            else if ((_DateFrom == null || _DateFrom > DateTime.MinValue)
                     && (_DateTo != null && _DateTo > DateTime.MinValue))
                lstSelect = lstThongTinTheoDoiCon.Where(x => x.ThoiGian < _DateFrom).ToList();
            
            DataTable TableThongTin = new DataTable("DSHC");
            TableThongTin.Columns.Add("NGAYTHANG");
            TableThongTin.Columns.Add("TINHTRANGTRESOSINH");
            TableThongTin.Columns.Add("SUTRI");
            TableThongTin.Columns.Add("THUOC_VATTU");
            foreach(ThongTinTheoDoiCon thongTin in lstSelect)
            {
                TableThongTin.Rows.Add(
                    thongTin.ThoiGian.ToString("HH:mm dd/MM/yyyy"),
                    thongTin.TinhTrangTreSoSinh,
                    thongTin.SuTri,
                    thongTin.ThuocVatTu
                    );
            }
            ds.Tables.Add(TableThongTin);

            return ds;
         }

        public static bool Delete(MDB.MDBConnection oracleConnection, string MaBenhAn, string TenKhoa)
        {
            string sql = @"DELETE FROM PHIEUTHEODOISOSINH WHERE MaBenhAn = :MaBenhAn";
            if (!String.IsNullOrEmpty(TenKhoa))
                sql += " AND TenKhoa = '" + TenKhoa + "' ";
            MDB.MDBCommand oracleCommand = new MDB.MDBCommand(sql, oracleConnection);
            oracleCommand.Parameters.Add("MaBenhAn", MaBenhAn);
            int n = oracleCommand.ExecuteNonQuery();
            return n > 0;
        }

        public static bool DeleteById(MDB.MDBConnection oracleConnection, decimal id)
        {
            string sql = @"DELETE FROM PHIEUTHEODOISOSINH WHERE IdPHIEUTHEODOISOSINH = :Id";
            MDB.MDBCommand oracleCommand = new MDB.MDBCommand(sql, oracleConnection);
            oracleCommand.Parameters.Add("Id", id);

            int n = oracleCommand.ExecuteNonQuery();
            return n > 0;
        }

        public static int countPhieu(MDB.MDBConnection oracleConnection, string maBenhNhan)
        {
            int count = 0;
            string sql = @"SELECT COUNT(IDPHIEUTHEODOISOSINH) FROM PHIEUTHEODOISOSINH WHERE MaBenhNhan = :MaBenhNhan";
            MDB.MDBCommand oracleCommand = new MDB.MDBCommand(sql, oracleConnection);
            oracleCommand.Parameters.Add("MaBenhNhan", maBenhNhan);
            oracleCommand.BindByName = true;
            MDB.MDBDataReader DataReader = oracleCommand.ExecuteReader();
            while (DataReader.Read())
            {
                int temp = 0;
                int.TryParse(DataReader["COUNT(IDPHIEUTHEODOISOSINH)"].ToString(), out temp);
                count = temp;
                break;
            }
            return count;
        }
    }
}
