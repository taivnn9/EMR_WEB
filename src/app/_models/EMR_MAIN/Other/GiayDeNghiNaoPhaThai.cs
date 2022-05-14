
using EMR.KyDienTu;
using System;
using System.Collections.Generic;
using System.Data;
using PMS.Access;

namespace EMR_MAIN.DATABASE.Other
{
    public class GiayDeNghiNaoPhaThaiTbl : ThongTinKy
    {
        [MoTaDuLieu("Mã định danh")]
		public decimal IDMaPhieu { get; set; }
        [MoTaDuLieu("Mã quản lý: mã duy nhất trong 1 đợt khám chữa bệnh (kcb), không trùng giữa các đợt kcb khác nhau","",1)]
		public decimal MaQuanLy { get; set; }
        [MoTaDuLieu("Bệnh viện")]
		public string BenhVien { get; set; }
        [MoTaDuLieu("Khoa")]
		public string Khoa { get; set; }
        [MoTaDuLieu("Mã khoa")]
		public string MaKhoa { get; set; }
        [MoTaDuLieu("Mã bệnh nhân")]
		public string MaBenhNhan { get; set; }
        public string HoTen { get; set; }
        [MoTaDuLieu("Tuổi bệnh nhân")]
		public string Tuoi { get; set; }
        [MoTaDuLieu("Nghề nghiệp")]
		public string NgheNghiep { get; set; }
        [MoTaDuLieu("Địa chỉ nhà bệnh nhân")]
		public string DiaChi { get; set; }
        public string SoThangMangThai { get; set; }
        public int? LoaiDonViTinhMangThai { get; set; }
        public string LyDoPhaThai { get; set; }
        [MoTaDuLieu("Ngày tạo", null, 0, 0)]
		public DateTime NgayTao { get; set; }
        [MoTaDuLieu("Ngày sửa", null, 0, 0)]
		public DateTime NgaySua { get; set; }
        //[MoTaDuLieu("Tên file ký")]
		public string TenFileKy { get; set; }
        //[MoTaDuLieu("Tên người ký")]
		public string UserNameKy { get; set; }
        [MoTaDuLieu("Ngày ký")]
		public DateTime NgayKi { get; set; }
        //[MoTaDuLieu("Tên máy tính ký")]
		public string ComputerKyTen { get; set; }
        //public string MaSoKyTen { get; set; }
        [MoTaDuLieu("Chọn", null, 0, 0)]
		public bool Chon { get; set; }
        public GiayDeNghiNaoPhaThaiTbl()
        {
            TableName = "GiayDeNghiNaoPhaThai";
            TablePrimaryKeyName = "ID";
            IDMauPhieu = (int)DanhMucPhieu.GDNNPT;
            TenMauPhieu = DanhMucPhieu.GDNNPT.Description();
            IDMaPhieu = 0;
            TenFileKy = "";
            UserNameKy = "";
            NgayKi = DateTime.Now;
            ComputerKyTen = "";
            MaSoKy = "";
            NgayTao = DateTime.Now;
            MaQuanLy = 0;
        }
    }
        public class GiayDeNghiNaoPhaThaiFunc
        {

        public const string TableName = "GiayDeNghiNaoPhaThai";
        public const string TablePrimaryKeyName = "IDMaPhieu";
        public static bool DeleteByListID(MDB.MDBConnection oracleConnection, List<decimal> IDBienBan)
        {
            try
            {
                string sql = "";
                string strWhere = "";
                MDB.MDBCommand oracleCommand;
                strWhere = "In(";
                if (IDBienBan.Count > 0)
                {
                    for (int i = 0; i < IDBienBan.Count; i++)
                    {
                        strWhere = strWhere + IDBienBan[i].ToString();
                        if (i == (IDBienBan.Count - 1))
                        {
                            strWhere = strWhere + ")";
                        }
                        else
                        {
                            strWhere = strWhere + ",";
                        }
                    }
                }
                sql = @"DELETE FROM GiayDeNghiNaoPhaThai WHERE IDMaPhieu " + strWhere;
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
        public static DataSet GetDataSet(MDB.MDBConnection MyConnection, string IDCHon)
        {
            string sql = @"select AA.*, BB.Khoa as PhongKhoaName "
                         + " from GiayDeNghiNaoPhaThai AA left join thongtindieutri BB ON AA.MaBenhNhan = BB.MaBenhNhan WHERE IDMaPhieu =: IDMaPhieu ORDER BY NgayTao, NgaySua asc";
            MDB.MDBCommand Command;
            MDB.MDBDataAdapter adt;
            using (Command = new MDB.MDBCommand(sql, MyConnection))
            {
                Command.Parameters.Add(new MDB.MDBParameter("IDMaPhieu", IDCHon));
                adt = new MDB.MDBDataAdapter(Command);
            }
            var ds = new DataSet();
            adt.Fill(ds, "TBL");
            return ds;
        }
        public static bool InsertOrUpdate(MDB.MDBConnection oracleConnection, GiayDeNghiNaoPhaThaiTbl obj, ref bool isUpdate)
        {
            try
            {
                string sql = @"SELECT COUNT(*) RECNUM FROM GiayDeNghiNaoPhaThai WHERE IDMaPhieu = :IDMaPhieu";
                MDB.MDBCommand oracleCommand;
                int rowCount = 0;
                int nRecord = 0;
                decimal sequence_nextval = 0;
                using (oracleCommand = new MDB.MDBCommand(sql, oracleConnection))
                {
                    oracleCommand.Parameters.Add("IDMaPhieu", obj.IDMaPhieu);
                    MDB.MDBDataReader oracleDataReader = oracleCommand.ExecuteReader();
                    while (oracleDataReader.Read())
                    {
                        rowCount = int.Parse(oracleDataReader["RECNUM"].ToString());
                    }
                }


                if (rowCount > 0)
                {
                    isUpdate = true;
                    sequence_nextval = obj.IDMaPhieu;
                    sql = "update GiayDeNghiNaoPhaThai set MaQuanLy = :MaQuanLy,BenhVien = :BenhVien,Khoa = :Khoa,MaBenhNhan = :MaBenhNhan , MaKhoa = :MaKhoa, HoTen = :HoTen,Tuoi = :Tuoi,NgheNghiep = :NgheNghiep,DiaChi = :DiaChi,SoThangMangThai = :SoThangMangThai,LoaiDonViTinhMangThai = :LoaiDonViTinhMangThai,LyDoPhaThai = :LyDoPhaThai,NgayTao = :NgayTao,NgaySua = :NgaySua,TenFileKy = :TenFileKy,UserNameKy = :UserNameKy,NgayKi = :NgayKi,ComputerKyTen = :ComputerKyTen,MaSoKyTen = :MaSoKyTen";
                    sql = sql + " WHERE IDMaPhieu = " + obj.IDMaPhieu.ToString();
                }
                else
                {
                    sql = @"select NVL(MAX(IDMaPhieu),0) AS sequence_nextval from GiayDeNghiNaoPhaThai";
                    using (oracleCommand = new MDB.MDBCommand(sql, oracleConnection))
                    {
                        MDB.MDBDataReader oracleDataReader = oracleCommand.ExecuteReader();
                        while (oracleDataReader.Read())
                        {
                            sequence_nextval = decimal.Parse(oracleDataReader["sequence_nextval"].ToString()) + 1;
                        }
                    }
                    sql = @"insert into GiayDeNghiNaoPhaThai(IDMaPhieu,MaQuanLy,BenhVien,Khoa,MaBenhNhan,MaKhoa, HoTen,Tuoi,NgheNghiep,DiaChi,SoThangMangThai,LoaiDonViTinhMangThai,LyDoPhaThai,NgayTao,NgaySua,TenFileKy,UserNameKy,NgayKi,ComputerKyTen,MaSoKyTen)";
                    sql = sql + @"Values(:IDMaPhieu,:MaQuanLy,:BenhVien,:Khoa, :MaBenhNhan, :MaKhoa,:HoTen,:Tuoi,:NgheNghiep,:DiaChi,:SoThangMangThai,:LoaiDonViTinhMangThai,:LyDoPhaThai,:NgayTao,:NgaySua,:TenFileKy,:UserNameKy,:NgayKi,:ComputerKyTen,:MaSoKyTen)";
                }
                using (oracleCommand = new MDB.MDBCommand(sql, oracleConnection))
                {
                    if (rowCount <= 0)
                    {
                        oracleCommand.Parameters.Add(new MDB.MDBParameter("IDMaPhieu", sequence_nextval));
                    }

                    oracleCommand.Parameters.Add(new MDB.MDBParameter("MaQuanLy", obj.MaQuanLy));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("BenhVien", obj.BenhVien));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("Khoa", obj.Khoa));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("MaBenhNhan", obj.MaBenhNhan));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("MaKhoa", obj.MaKhoa));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("HoTen", obj.HoTen));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("Tuoi", obj.Tuoi));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("NgheNghiep", obj.NgheNghiep));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("DiaChi", obj.DiaChi));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("SoThangMangThai", obj.SoThangMangThai));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("LoaiDonViTinhMangThai", obj.LoaiDonViTinhMangThai));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("LyDoPhaThai", obj.LyDoPhaThai));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("NgayTao", obj.NgayTao));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("NgaySua", obj.NgaySua));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("TenFileKy", obj.TenFileKy));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("UserNameKy", obj.UserNameKy));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("NgayKi", obj.NgayKi));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("ComputerKyTen", obj.ComputerKyTen));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("MaSoKyTen", obj.MaSoKy));

                    nRecord = oracleCommand.ExecuteNonQuery();
                }
                if (nRecord > 0)
                {
                    obj.IDMaPhieu = sequence_nextval;
                }
                return nRecord > 0 ? true : false;
            }
            catch (Exception ex)
            {
                XuLyLoi.LogError(ex);
            }
            return false;
        }
        public static List<GiayDeNghiNaoPhaThaiTbl> GetData(MDB.MDBConnection MyConnection, decimal IDMaPhieu, decimal MaQuanLy)
        {
            List<GiayDeNghiNaoPhaThaiTbl> lstData = new List<GiayDeNghiNaoPhaThaiTbl>();
            string sql = @"select * from GiayDeNghiNaoPhaThai WHERE MaQuanLy = :MaQuanLy ";
            if (IDMaPhieu != -1)
            {
                sql += " and IDMaPhieu = " + IDMaPhieu + "";
            }
            sql += " ORDER BY NgayTao, NgaySua asc";
            MDB.MDBCommand Command;
            using (Command = new MDB.MDBCommand(sql, MyConnection))
            {
                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", MaQuanLy));
                MDB.MDBDataReader DataReader = Command.ExecuteReader();
                while (DataReader.Read())
                {
                    GiayDeNghiNaoPhaThaiTbl item = new GiayDeNghiNaoPhaThaiTbl();
                    item.IDMaPhieu = decimal.Parse(DataReader["IDMaPhieu"].ToString());
                    item.BenhVien = ConDBNull(DataReader["BenhVien"]);
                    item.Khoa = ConDBNull(DataReader["Khoa"]);
                    item.MaKhoa = ConDBNull(DataReader["MaKhoa"]);
                    item.MaBenhNhan = ConDBNull(DataReader["MaBenhNhan"]);
                    item.MaQuanLy = ConDB_Decimal(DataReader["MaQuanLy"]);
                    item.HoTen = ConDBNull(DataReader["HoTen"]);
                    item.Tuoi = ConDBNull(DataReader["Tuoi"]);
                    item.NgheNghiep = ConDBNull(DataReader["NgheNghiep"]);
                    item.DiaChi = ConDBNull(DataReader["DiaChi"]);
                    item.SoThangMangThai = ConDBNull(DataReader["SoThangMangThai"]);
                    item.LoaiDonViTinhMangThai = ConDB_Int(DataReader["LoaiDonViTinhMangThai"]);
                    item.LyDoPhaThai = ConDBNull(DataReader["LyDoPhaThai"]);
                    item.NgayTao = ConDB_DateTime(DataReader["NgayTao"]);
                    item.NgaySua = ConDB_DateTime(DataReader["NgaySua"]);
                    item.TenFileKy = ConDBNull(DataReader["TenFileKy"]);
                    item.UserNameKy = ConDBNull(DataReader["UserNameKy"]);
                    item.NgayKi = ConDB_DateTime(DataReader["NgayKi"]);
                    item.ComputerKyTen = ConDBNull(DataReader["ComputerKyTen"]);
                    item.MaSoKy = ConDBNull(DataReader["MaSoKyTen"]);
                    item.Chon = false;
                    lstData.Add(item);
                }
            }
            return lstData;
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
