
using EMR.KyDienTu;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using PMS.Access;

namespace EMR_MAIN.DATABASE.Other
{
    public class PhieuKetQuaNghiemPhapObj : ThongTinKy
    {
        public PhieuKetQuaNghiemPhapObj()
        {
            TableName = "PhieuKetQuaNghiemPhap";
            TablePrimaryKeyName = "ID";
            IDMauPhieu = (int)DanhMucPhieu.PKQNPDNG;
            TenMauPhieu = DanhMucPhieu.PKQNPDNG.Description();
        }

        [MoTaDuLieu("Mã định danh")]
		public decimal IDPhieuKetQuaNghiemPhap { get; set; }
		[MoTaDuLieu("Sở Y Tế")]
		public string SoYTe { get; set; }
        public string MaYTe { get; set; }
        [MoTaDuLieu("Bệnh viện")]
		public string BenhVien { get; set; }
        [MoTaDuLieu("Tên khoa")]
		public string TenKhoa { get; set; }
        [MoTaDuLieu("Họ và tên bệnh nhân")]
		public string TenBenhNhan { get; set; }
        [MoTaDuLieu("Tuổi bệnh nhân")]
		public string Tuoi { get; set; }
        public string Gioi { get; set; }
        [MoTaDuLieu("Địa chỉ nhà bệnh nhân")]
		public string DiaChi { get; set; }
        [MoTaDuLieu("Chẩn đoán bệnh")]
		public string ChanDoan { get; set; }
        public DateTime? NgayTao { get; set; }
        public string ThongTinKetQuaNghiemPhap { get; set; }
        public string KetLuan { get; set; }
        public string MaBsChuyenKhoaNoiTiet { get; set; }
        public string TenBsChuyenKhoaNoiTiet { get; set; }
        //public string KyTen { get; set; }
        [MoTaDuLieu("Mã quản lý: mã duy nhất trong 1 đợt khám chữa bệnh (kcb), không trùng giữa các đợt kcb khác nhau","",1)]
		public decimal MaQuanLy { get; set; }

    }
    public class ThongTinKetQuaNghiemPhap
    {
        public DateTime ThoiGian { get; set; }
        public string NoiDung { get; set; }
        public string KetQua { get; set; }
    }
    public class PhieuKetQuaNghiemPhapFunc
    {
        public const string TableName = "PhieuKetQuaNghiemPhap";
        public const string TablePrimaryKeyName = "IDPhieuKetQuaNghiemPhap";
        public static bool InsertOrUpdate(MDB.MDBConnection MyConnection, ref PhieuKetQuaNghiemPhapObj data)
        {
            string sql = "INSERT INTO PhieuKetQuaNghiemPhap"
                    + " (SoYTe, MaYTe, BenhVien, TenKhoa, TenBenhNhan, Tuoi, Gioi, DiaChi, ChanDoan, NgayTao,"
                    + " ThongTinKetQuaNghiemPhap, MaBsChuyenKhoaNoiTiet, KetLuan, TenBsChuyenKhoaNoiTiet, MaQuanLy)"
                    + " VALUES (:SoYTe, :MaYTe, :BenhVien, :TenKhoa, :TenBenhNhan, :Tuoi, :Gioi, :DiaChi, :ChanDoan, :NgayTao,"
                    + ":ThongTinKetQuaNghiemPhap,:MaBsChuyenKhoaNoiTiet, :KetLuan, :TenBsChuyenKhoaNoiTiet, :MaQuanLy) " +
                    " RETURNING IDPhieuKetQuaNghiemPhap INTO :IDPhieuKetQuaNghiemPhap";
            if(data.IDPhieuKetQuaNghiemPhap != Decimal.Zero)
                 sql = "UPDATE PhieuKetQuaNghiemPhap"
                     + " SET SoYTe = :SoYTe, MaYTe= :MaYTe, BenhVien= :BenhVien, TenKhoa= :TenKhoa,"
                     + " TenBenhNhan= :TenBenhNhan, Tuoi= :Tuoi, Gioi= :Gioi,"
                     + " DiaChi= :DiaChi, ChanDoan= :ChanDoan, NgayTao= :NgayTao, ThongTinKetQuaNghiemPhap= :ThongTinKetQuaNghiemPhap,"
                     + " MaBsChuyenKhoaNoiTiet= :MaBsChuyenKhoaNoiTiet,"
                      + " KetLuan= :KetLuan,"
                     + " TenBsChuyenKhoaNoiTiet=:TenBsChuyenKhoaNoiTiet,"
                     + " MaQuanLy= :MaQuanLy "
                     + " WHERE IDPhieuKetQuaNghiemPhap = :IDPhieuKetQuaNghiemPhap";

            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);

            Command.Parameters.Add(new MDB.MDBParameter("SoYTe", data.SoYTe));
            Command.Parameters.Add(new MDB.MDBParameter("MaYTe", data.MaYTe));
            Command.Parameters.Add(new MDB.MDBParameter("BenhVien", data.BenhVien));
            Command.Parameters.Add(new MDB.MDBParameter("TenKhoa", data.TenKhoa));
            Command.Parameters.Add(new MDB.MDBParameter("TenBenhNhan", data.TenBenhNhan));
            Command.Parameters.Add(new MDB.MDBParameter("Tuoi", data.Tuoi));
            Command.Parameters.Add(new MDB.MDBParameter("Gioi", data.Gioi));
            Command.Parameters.Add(new MDB.MDBParameter("DiaChi", data.DiaChi));
            Command.Parameters.Add(new MDB.MDBParameter("ChanDoan", data.ChanDoan));
            Command.Parameters.Add(new MDB.MDBParameter("NgayTao", DateTime.Now));
            Command.Parameters.Add(new MDB.MDBParameter("ThongTinKetQuaNghiemPhap", data.ThongTinKetQuaNghiemPhap));
            Command.Parameters.Add(new MDB.MDBParameter("MaBsChuyenKhoaNoiTiet", data.MaBsChuyenKhoaNoiTiet));
            Command.Parameters.Add(new MDB.MDBParameter("KetLuan", data.KetLuan));
            Command.Parameters.Add(new MDB.MDBParameter("TenBsChuyenKhoaNoiTiet", data.TenBsChuyenKhoaNoiTiet));
            //Command.Parameters.Add(new MDB.MDBParameter("KyTen", data.KyTen));
            Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", data.MaQuanLy));
            //if (data.IDPhieuKetQuaNghiemPhap.Equals(Decimal.Zero))
            //{
                Command.Parameters.Add(new MDB.MDBParameter("IDPhieuKetQuaNghiemPhap", data.IDPhieuKetQuaNghiemPhap));
            //}
            Command.BindByName = true;
            int n = Command.ExecuteNonQuery();
            if (data.IDPhieuKetQuaNghiemPhap.Equals(Decimal.Zero))
            {
                decimal nextval = Convert.ToInt64((Command.Parameters["IDPhieuKetQuaNghiemPhap"] as MDB.MDBParameter).Value);
                data.IDPhieuKetQuaNghiemPhap = nextval;
            }

            return n > 0 ? true : false;
        }

        public static PhieuKetQuaNghiemPhapObj GetData(MDB.MDBConnection MyConnection, decimal MaQuanLy)
        {
            string sql = @"SELECT * FROM PhieuKetQuaNghiemPhap WHERE MaQuanLy = :MaQuanLy ";
            sql += " ORDER BY IDPhieuKetQuaNghiemPhap desc";
            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
            Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", MaQuanLy));
            MDB.MDBDataReader DataReader = Command.ExecuteReader();
            PhieuKetQuaNghiemPhapObj item = null;
            while (DataReader.Read())
            {
                item = new PhieuKetQuaNghiemPhapObj();
                item.IDPhieuKetQuaNghiemPhap = decimal.Parse(DataReader["IDPhieuKetQuaNghiemPhap"].ToString());
                item.SoYTe = DataReader["SoYTe"].ToString();
                item.MaYTe = DataReader["MaYTe"].ToString();
                item.BenhVien = DataReader["BenhVien"].ToString();
                item.TenKhoa = DataReader["TenKhoa"].ToString();
                item.TenBenhNhan = DataReader["TenBenhNhan"].ToString();
                item.Tuoi = DataReader["Tuoi"].ToString();
                item.Gioi = DataReader["Gioi"].ToString();
                item.DiaChi = DataReader["DiaChi"].ToString();
                item.ChanDoan = DataReader["ChanDoan"].ToString();
                try
                {
                    item.NgayTao = (DateTime)DataReader["NgayTao"];
                }
                catch { }
                item.ThongTinKetQuaNghiemPhap = DataReader["ThongTinKetQuaNghiemPhap"].ToString();
                item.MaBsChuyenKhoaNoiTiet = DataReader["MaBsChuyenKhoaNoiTiet"].ToString();
                item.KetLuan = DataReader["KetLuan"].ToString();
                item.TenBsChuyenKhoaNoiTiet = DataReader["TenBsChuyenKhoaNoiTiet"].ToString();
                //item.KyTen = DataReader["KyTen"].ToString();
                item.MaQuanLy = decimal.Parse(DataReader["MaQuanLy"].ToString());
            }
            return item;
        }

        

         public static DataSet GetDataSetByDate(MDB.MDBConnection MyConnection, decimal IdPhieuSoSinh)
         {
             string sql = @"SELECT  P.SoYTe,
                                    P.MAYTE,
                                    P.BENHVIEN,
                                    P.TENKHOA,
                                    P.TENBENHNHAN,
                                    P.Gioi,
                                    P.Tuoi,
                                    P.DIACHI,
                                    P.CHANDOAN,
                                    P.NgayTao,
                                    P.TenBsChuyenKhoaNoiTiet ,
                                    P.KetLuan,
                                    p.masokyten
                                    FROM PhieuKetQuaNghiemPhap P WHERE IDPhieuKetQuaNghiemPhap=" + IdPhieuSoSinh;
             MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
             MDB.MDBDataAdapter adt = new MDB.MDBDataAdapter(Command);

             var ds = new DataSet();
             adt.Fill(ds, "TDSS");

            sql = @"SELECT ThongTinKetQuaNghiemPhap FROM PhieuKetQuaNghiemPhap WHERE IDPhieuKetQuaNghiemPhap=" + IdPhieuSoSinh;
            Command = new MDB.MDBCommand(sql, MyConnection);
            Command.BindByName = true;
            MDB.MDBDataReader DataReader = Command.ExecuteReader();
            List<ThongTinKetQuaNghiemPhap> lstThongTinKetQuaNghiemPhap = new List<ThongTinKetQuaNghiemPhap>();
            while (DataReader.Read())
            {
                lstThongTinKetQuaNghiemPhap = JsonConvert.DeserializeObject<List<ThongTinKetQuaNghiemPhap>>(DataReader["ThongTinKetQuaNghiemPhap"].ToString());
            }
            List<ThongTinKetQuaNghiemPhap> lstSelect = lstThongTinKetQuaNghiemPhap;
            DataTable TableThongTin = new DataTable("DSHC");
            TableThongTin.Columns.Add("NoiDung");
            TableThongTin.Columns.Add("ThoiGian");
            TableThongTin.Columns.Add("KetQua");
            foreach(ThongTinKetQuaNghiemPhap thongTin in lstSelect)
            {
                TableThongTin.Rows.Add(
                    thongTin.NoiDung,
                    thongTin.ThoiGian.ToString("HH:mm dd/MM/yyyy"),
                    thongTin.KetQua
                    );
            }
            ds.Tables.Add(TableThongTin);

            return ds;
         }
        public static bool DeleteById(MDB.MDBConnection oracleConnection, decimal id)
        {
            string sql = @"DELETE FROM PhieuKetQuaNghiemPhap WHERE IdPhieuKetQuaNghiemPhap = :Id";
            MDB.MDBCommand oracleCommand = new MDB.MDBCommand(sql, oracleConnection);
            oracleCommand.Parameters.Add("Id", id);

            int n = oracleCommand.ExecuteNonQuery();
            return n > 0;
        }
    }
}
