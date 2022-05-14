using EMR.KyDienTu;
using System;
using System.Data;

namespace EMR_MAIN.DATABASE.Other
{
    public class PhieuQuyTrinhCls : ThongTinKy
    {
        [MoTaDuLieu("Mã định danh")]
		public decimal IDPhieu { get; set; }
        public decimal LoaiBA { get; set; }
        [MoTaDuLieu("Mã quản lý: mã duy nhất trong 1 đợt khám chữa bệnh (kcb), không trùng giữa các đợt kcb khác nhau","",1)]
		public decimal MaQuanLy { get; set; }
        [MoTaDuLieu("Mã bệnh nhân")]
		public string MaBenhNhan { get; set; }
        [MoTaDuLieu("Mã khoa")]
		public string MaKhoa { get; set; }
        public string MaBacSyTT { get; set; }
        public string MaBacSyDT { get; set; }
        public DateTime? NgayThucHienTT { get; set; }
        [MoTaDuLieu("Chẩn đoán bệnh")]
		public string ChanDoan { get; set; }
        public string MaPPVoCam { get; set; }
        public string QuyTrinh1 { get; set; }
        public string DuongDanAnh1 { get; set; }
        public string QuyTrinh2 { get; set; }
        public string DuongDanAnh2 { get; set; }
        public string QuyTrinh3 { get; set; }
        public string DuongDanAnh3 { get; set; }
        public string QuyTrinh4 { get; set; }
        public string DuongDanAnh4 { get; set; }
        public string QuyTrinh5 { get; set; }
        public string DuongDanAnh5 { get; set; }
        public string QuyTrinh6 { get; set; }
        public string DuongDanAnh6 { get; set; }
        public string QuyTrinh7 { get; set; }
        public string DuongDanAnh7 { get; set; }
        public string QuyTrinh8 { get; set; }
        public string DuongDanAnh8 { get; set; }
        public string QuyTrinh9 { get; set; }
        public string DuongDanAnh9 { get; set; }
        public string QuyTrinh10 { get; set; }
        public string DuongDanAnh10 { get; set; }
        public string MaPhauThuatVien { get; set; }
        public string TenPhauThuatVien { get; set; }
        public string TenBacSyTT { get; set; }
        public string TenBacSyDT { get; set; }
        [MoTaDuLieu("Ngày tạo", null, 0, 0)]
		public DateTime NgayTao { get; set; }
        public DateTime Ngaysua { get; set; }
        //public string MaSoKyTen { get; set; }
        [MoTaDuLieu("Đã ký", null, 0, 0)]
		public bool DaKy { get; set; }
    }
    public class PhieuQuyTrinhFunc
    {
        public const string TableName = "PhieuQuyTrinh";
        public const string TablePrimaryKeyName = "IDMaPhieu";
        public static bool DeleteByIDPhieu(MDB.MDBConnection oracleConnection, decimal IDBienBan, decimal typ)
        {
            try
            {
                string sql = "";
                MDB.MDBCommand oracleCommand;
                sql = @"DELETE FROM PhieuQuyTrinh WHERE IDPhieu = " + IDBienBan.ToString() + " and LoaiBA = "+ typ.ToString();
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
        public static DataSet GetDataSet(MDB.MDBConnection MyConnection, decimal IDBienBan, decimal typ)
        {
            string sql = @"SELECT P.*, T.SoNhapVien, T.Khoa , T.NgayVaoVien ,  T.MaKhoa, T.MaBenhAn, T.Giuong, T.Buong,            
                H.TUOI,H.SoYTe, H.BENHVIEN, H.TenBenhNhan, H.maBenhNhan, H.NgheNghiep
                  FROM PhieuQuyTrinh P 
                Left JOIN THONGTINDIEUTRI T ON P.MAQUANLY = T.MAQUANLY
                Left JOIN HANHCHINHBENHNHAN H ON T.MABENHNHAN = H.MABENHNHAN
                  where IDPhieu = :IDPhieu and LoaiBA = :LoaiBA";
            MDB.MDBCommand Command;
            MDB.MDBDataAdapter adt;
            using (Command = new MDB.MDBCommand(sql, MyConnection))
            {
                Command.Parameters.Add(new MDB.MDBParameter("IDPhieu", IDBienBan));
                Command.Parameters.Add(new MDB.MDBParameter("LoaiBA", typ));
                adt = new MDB.MDBDataAdapter(Command);
            }
            var ds = new DataSet();
            adt.Fill(ds, "TBL");
            return ds;
        }
        public static bool InsertOrUpdate(MDB.MDBConnection oracleConnection, PhieuQuyTrinhCls obj, ref bool isUpdate)
        {
            try
            {
                string sql = @"SELECT COUNT(*) RECNUM FROM PhieuQuyTrinh WHERE IDPhieu = :IDPhieu  and LoaiBA = :LoaiBA";
                MDB.MDBCommand oracleCommand;
                int rowCount = 0;
                int nRecord = 0;
                decimal sequence_nextval = 0;
                using (oracleCommand = new MDB.MDBCommand(sql, oracleConnection))
                {
                    oracleCommand.Parameters.Add("IDPhieu", obj.IDPhieu);
                    oracleCommand.Parameters.Add("LoaiBA", obj.LoaiBA);
                    MDB.MDBDataReader oracleDataReader = oracleCommand.ExecuteReader();
                    while (oracleDataReader.Read())
                    {
                        rowCount = int.Parse(oracleDataReader["RECNUM"].ToString());
                    }
                }


                if (rowCount > 0)
                {
                    isUpdate = true;
                    sequence_nextval = obj.IDPhieu;
                    sql = "update PhieuQuyTrinh set MaQuanLy= :MaQuanLy,MaBenhNhan= :MaBenhNhan,MaKhoa= :MaKhoa,MaBacSyTT= :MaBacSyTT,MaBacSyDT= :MaBacSyDT,NgayThucHienTT= :NgayThucHienTT,ChanDoan= :ChanDoan,MaPPVoCam= :MaPPVoCam,QuyTrinh1= :QuyTrinh1,DuongDanAnh1= :DuongDanAnh1,QuyTrinh2= :QuyTrinh2,DuongDanAnh2= :DuongDanAnh2,QuyTrinh3= :QuyTrinh3,DuongDanAnh3= :DuongDanAnh3,QuyTrinh4= :QuyTrinh4,DuongDanAnh4= :DuongDanAnh4,QuyTrinh5= :QuyTrinh5,DuongDanAnh5= :DuongDanAnh5,QuyTrinh6= :QuyTrinh6,DuongDanAnh6= :DuongDanAnh6,QuyTrinh7= :QuyTrinh7,DuongDanAnh7= :DuongDanAnh7,QuyTrinh8= :QuyTrinh8,DuongDanAnh8= :DuongDanAnh8,QuyTrinh9= :QuyTrinh9,DuongDanAnh9= :DuongDanAnh9,QuyTrinh10= :QuyTrinh10,DuongDanAnh10= :DuongDanAnh10,MaPhauThuatVien= :MaPhauThuatVien,TenPhauThuatVien= :TenPhauThuatVien,TenBacSyTT= :TenBacSyTT,TenBacSyDT= :TenBacSyDT,NgayTao= :NgayTao,Ngaysua= :Ngaysua,MaSoKyTen= :MaSoKyTen";
                    sql = sql + " WHERE IDPhieu = " + obj.IDPhieu.ToString() + " and LoaiBA = " + obj.LoaiBA.ToString();
                }
                else
                {
                    sql = @"select IDPhieuQuyTrinh_SEQ.nextval sequence_nextval from dual ";
                    using (oracleCommand = new MDB.MDBCommand(sql, oracleConnection))
                    {
                        MDB.MDBDataReader oracleDataReader = oracleCommand.ExecuteReader();
                        while (oracleDataReader.Read())
                        {
                            sequence_nextval = decimal.Parse(oracleDataReader["sequence_nextval"].ToString()) + 1;
                        }
                    }
                    sql = @"insert into PhieuQuyTrinh(IDPhieu,LoaiBA,MaQuanLy,MaBenhNhan,MaKhoa,MaBacSyTT,MaBacSyDT,NgayThucHienTT,ChanDoan,MaPPVoCam,QuyTrinh1,DuongDanAnh1,QuyTrinh2,DuongDanAnh2,QuyTrinh3,DuongDanAnh3,QuyTrinh4,DuongDanAnh4,QuyTrinh5,DuongDanAnh5,QuyTrinh6,DuongDanAnh6,QuyTrinh7,DuongDanAnh7,QuyTrinh8,DuongDanAnh8,QuyTrinh9,DuongDanAnh9,QuyTrinh10,DuongDanAnh10,MaPhauThuatVien,TenPhauThuatVien,TenBacSyTT,TenBacSyDT, NgayTao,Ngaysua,MaSoKyTen" +
                        ")";
                    sql = sql + @"Values(:IDPhieu, :LoaiBA, :MaQuanLy, :MaBenhNhan, :MaKhoa, :MaBacSyTT, :MaBacSyDT, :NgayThucHienTT, :ChanDoan, :MaPPVoCam, :QuyTrinh1, :DuongDanAnh1, :QuyTrinh2, :DuongDanAnh2, :QuyTrinh3, :DuongDanAnh3, :QuyTrinh4, :DuongDanAnh4, :QuyTrinh5, :DuongDanAnh5, :QuyTrinh6, :DuongDanAnh6, :QuyTrinh7, :DuongDanAnh7, :QuyTrinh8, :DuongDanAnh8, :QuyTrinh9, :DuongDanAnh9, :QuyTrinh10, :DuongDanAnh10, :MaPhauThuatVien, :TenPhauThuatVien, :TenBacSyTT, :TenBacSyDT, :NgayTao, :Ngaysua, :MaSoKyTen" +
                        ")";
                }
                using (oracleCommand = new MDB.MDBCommand(sql, oracleConnection))
                {
                    if (rowCount <= 0)
                    {
                        obj.IDPhieu = sequence_nextval;
                        oracleCommand.Parameters.Add(new MDB.MDBParameter("IDPhieu", sequence_nextval));
                        oracleCommand.Parameters.Add(new MDB.MDBParameter("LoaiBA", obj.LoaiBA));
                    }
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("MaQuanLy", obj.MaQuanLy));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("MaBenhNhan", obj.MaBenhNhan));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("MaKhoa", obj.MaKhoa));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("MaBacSyTT", obj.MaBacSyTT));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("MaBacSyDT", obj.MaBacSyDT));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("NgayThucHienTT", obj.NgayThucHienTT));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("ChanDoan", obj.ChanDoan));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("MaPPVoCam", obj.MaPPVoCam));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("QuyTrinh1", obj.QuyTrinh1));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("DuongDanAnh1", obj.DuongDanAnh1));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("QuyTrinh2", obj.QuyTrinh2));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("DuongDanAnh2", obj.DuongDanAnh2));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("QuyTrinh3", obj.QuyTrinh3));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("DuongDanAnh3", obj.DuongDanAnh3));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("QuyTrinh4", obj.QuyTrinh4));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("DuongDanAnh4", obj.DuongDanAnh4));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("QuyTrinh5", obj.QuyTrinh5));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("DuongDanAnh5", obj.DuongDanAnh5));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("QuyTrinh6", obj.QuyTrinh6));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("DuongDanAnh6", obj.DuongDanAnh6));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("QuyTrinh7", obj.QuyTrinh7));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("DuongDanAnh7", obj.DuongDanAnh7));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("QuyTrinh8", obj.QuyTrinh8));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("DuongDanAnh8", obj.DuongDanAnh8));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("QuyTrinh9", obj.QuyTrinh9));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("DuongDanAnh9", obj.DuongDanAnh9));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("QuyTrinh10", obj.QuyTrinh10));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("DuongDanAnh10", obj.DuongDanAnh10));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("MaPhauThuatVien", obj.MaPhauThuatVien));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("TenPhauThuatVien", obj.TenPhauThuatVien));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("TenBacSyTT", obj.TenBacSyTT));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("TenBacSyDT", obj.TenBacSyDT));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("NgayTao", obj.NgayTao));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("Ngaysua", DateTime.Now));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("MaSoKyTen", obj.MaSoKy));
                    nRecord = oracleCommand.ExecuteNonQuery();
                }
                if (nRecord > 0)
                {
                    obj.IDPhieu = sequence_nextval;
                }
                return nRecord > 0 ? true : false;
            }
            catch (Exception ex)
            {
                XuLyLoi.LogError(ex);
            }
            return false;
        }
        //public static int countPhieu(MDB.MDBConnection oracleConnection, string MaQuanLy)
        //{
        //    int count = 0;
        //    string sql = @"SELECT COUNT(IDPhieu) FROM PhieuQuyTrinh WHERE MAQUANLY = :MaQuanLy";
        //    MDB.MDBCommand oracleCommand = new MDB.MDBCommand(sql, oracleConnection);
        //    oracleCommand.Parameters.Add("MaQuanLy", MaQuanLy);
        //    oracleCommand.BindByName = true;
        //    MDB.MDBDataReader DataReader = oracleCommand.ExecuteReader();
        //    while (DataReader.Read())
        //    {
        //        int temp = 0;
        //        int.TryParse(DataReader["COUNT(IDPhieu)"].ToString(), out temp);
        //        count = temp;
        //        break;
        //    }
        //    return count;
        //}
        public static PhieuQuyTrinhCls GetData(MDB.MDBConnection MyConnection, decimal MaQuanLy, decimal LoaiBA)
        {
            PhieuQuyTrinhCls obj = new PhieuQuyTrinhCls();
            string sql = @"select * from PhieuQuyTrinh WHERE MaQuanLy = :MaQuanLy " + " and LoaiBA = " + LoaiBA.ToString(); ;
            sql += " ORDER BY NgayTao, NgaySua asc";
            MDB.MDBCommand Command;
            using (Command = new MDB.MDBCommand(sql, MyConnection))
            {
                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", MaQuanLy));
                MDB.MDBDataReader DataReader = Command.ExecuteReader();
                while (DataReader.Read())
                {
                    obj.IDPhieu = ConDB_Decimal(DataReader["IDPhieu"]);
                    obj.LoaiBA = ConDB_Decimal(DataReader["LoaiBA"]);
                    obj.MaQuanLy = ConDB_Decimal(DataReader["MaQuanLy"]);
                    obj.MaBenhNhan = ConDBNull(DataReader["MaBenhNhan"]);
                    obj.MaKhoa = ConDBNull(DataReader["MaKhoa"]);
                    obj.MaBacSyTT = ConDBNull(DataReader["MaBacSyTT"]);
                    obj.MaBacSyDT = ConDBNull(DataReader["MaBacSyDT"]);
                    obj.NgayThucHienTT = ConDB_DateTime(DataReader["NgayThucHienTT"]);
                    obj.ChanDoan = ConDBNull(DataReader["ChanDoan"]);
                    obj.MaPPVoCam = ConDBNull(DataReader["MaPPVoCam"]);
                    obj.QuyTrinh1 = ConDBNull(DataReader["QuyTrinh1"]);
                    obj.DuongDanAnh1 = ConDBNull(DataReader["DuongDanAnh1"]);
                    obj.QuyTrinh2 = ConDBNull(DataReader["QuyTrinh2"]);
                    obj.DuongDanAnh2 = ConDBNull(DataReader["DuongDanAnh2"]);
                    obj.QuyTrinh3 = ConDBNull(DataReader["QuyTrinh3"]);
                    obj.DuongDanAnh3 = ConDBNull(DataReader["DuongDanAnh3"]);
                    obj.QuyTrinh4 = ConDBNull(DataReader["QuyTrinh4"]);
                    obj.DuongDanAnh4 = ConDBNull(DataReader["DuongDanAnh4"]);
                    obj.QuyTrinh5 = ConDBNull(DataReader["QuyTrinh5"]);
                    obj.DuongDanAnh5 = ConDBNull(DataReader["DuongDanAnh5"]);
                    obj.QuyTrinh6 = ConDBNull(DataReader["QuyTrinh6"]);
                    obj.DuongDanAnh6 = ConDBNull(DataReader["DuongDanAnh6"]);
                    obj.QuyTrinh7 = ConDBNull(DataReader["QuyTrinh7"]);
                    obj.DuongDanAnh7 = ConDBNull(DataReader["DuongDanAnh7"]);
                    obj.QuyTrinh8 = ConDBNull(DataReader["QuyTrinh8"]);
                    obj.DuongDanAnh8 = ConDBNull(DataReader["DuongDanAnh8"]);
                    obj.QuyTrinh9 = ConDBNull(DataReader["QuyTrinh9"]);
                    obj.DuongDanAnh9 = ConDBNull(DataReader["DuongDanAnh9"]);
                    obj.QuyTrinh10 = ConDBNull(DataReader["QuyTrinh10"]);
                    obj.DuongDanAnh10 = ConDBNull(DataReader["DuongDanAnh10"]);
                    obj.MaPhauThuatVien = ConDBNull(DataReader["MaPhauThuatVien"]);
                    obj.TenPhauThuatVien = ConDBNull(DataReader["TenPhauThuatVien"]);
                    obj.TenBacSyTT = ConDBNull(DataReader["TenBacSyTT"]);
                    obj.TenBacSyDT = ConDBNull(DataReader["TenBacSyDT"]);
                    obj.NgayTao = ConDB_DateTime(DataReader["NgayTao"]);
                    obj.Ngaysua = ConDB_DateTime(DataReader["Ngaysua"]);
                    obj.MaSoKy = ConDBNull(DataReader["MaSoKyTen"]);
                    obj.DaKy = !string.IsNullOrEmpty(ConDBNull(DataReader["MaSoKy"])) ? true : false;
                }
            }
            return obj;
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
