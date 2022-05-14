using EMR.KyDienTu;
using System;
using System.Collections.Generic;
using System.Data;

namespace EMR_MAIN.DATABASE.Other
{
    public class PhieuDanhGiaDinhDuongTreEm3 : ThongTinKy
    {
        [MoTaDuLieu("Mã định danh")]
		public decimal IDPhieu { get; set; }
        [MoTaDuLieu("Mã quản lý: mã duy nhất trong 1 đợt khám chữa bệnh (kcb), không trùng giữa các đợt kcb khác nhau","",1)]
		public decimal MaQuanLy { get; set; }
        [MoTaDuLieu("Họ và tên bệnh nhân")]
		public string TenBenhNhan { get; set; }
        [MoTaDuLieu("Mã bệnh nhân")]
		public string MaBenhNhan { get; set; }
        [MoTaDuLieu("Tuổi bệnh nhân")]
		public string Tuoi { get; set; }
        [MoTaDuLieu("Mã bệnh án")]
		public string MaBenhAn { get; set; }
        public string Khoa { get; set; }
        public string MaKhoa { get; set; }
        public double? CanNang { get; set; }
        public double? ChieuCao { get; set; }
        public double? BMI { get; set; }
        public double? CanNangRV { get; set; }
        public string MaBSDT { get; set; }
        public string TenBSDT { get; set; }
        public string MaNguoiTH { get; set; }
        public string TenNguoiTH { get; set; }
        public int DuongNuoi { get; set; }
        public int TaiKham { get; set; }
        public string DGBMI { get; set; }
        public string DGMUAC { get; set; }
        public DateTime ThoiGian { get; set; }
        public string ND0 { get; set; }
        public string ND1 { get; set; }
        public string ND2 { get; set; }
        public string ND3 { get; set; }
        public string ND4 { get; set; }
        public string ND5 { get; set; }
        public string ND6 { get; set; }
        public string ND7 { get; set; }
        [MoTaDuLieu("Ngày tạo", null, 0, 0)]
		public DateTime NgayTao { get; set; }
        [MoTaDuLieu("Người tạo", null, 0, 0)]
		public string NguoiTao { get; set; }
        [MoTaDuLieu("Ngày sửa", null, 0, 0)]
		public DateTime NgaySua { get; set; }
        [MoTaDuLieu("Người sửa", null, 0, 0)]
		public string NguoiSua { get; set; }
        //public string MaSoKyTen { get; set; }
        [MoTaDuLieu("Đã ký", null, 0, 0)]
		public bool DaKy { get; set; }
        [MoTaDuLieu("Chọn", null, 0, 0)]
		public bool Chon { get; set; }

    }
    public class PhieuDanhGiaDinhDuongTreEm3Func
    {
        public const string TableName = "PDGDDTE3";
        public const string TablePrimaryKeyName = "IDPhieu";
        public static List<PhieuDanhGiaDinhDuongTreEm3> GetListData(MDB.MDBConnection MyConnection, decimal MaQuanly)
        {
            try
            {
                List<PhieuDanhGiaDinhDuongTreEm3> lstObject = new List<PhieuDanhGiaDinhDuongTreEm3>();
                string sql = "SELECT * FROM PDGDDTE3 WHERE MaQuanLy = :MaQuanLy ORDER BY IDPhieu DESC";
                MDB.MDBCommand command = new MDB.MDBCommand(sql, MyConnection);
                command.Parameters.Add(new MDB.MDBParameter("MaQuanly", MaQuanly));
                MDB.MDBDataReader DataReader = command.ExecuteReader();
                while (DataReader.Read())
                {
                    PhieuDanhGiaDinhDuongTreEm3 obj = new PhieuDanhGiaDinhDuongTreEm3();
                    obj.IDPhieu = Common.ConDB_Decimal(DataReader["IDPhieu"]);
                    obj.MaQuanLy = Common.ConDB_Decimal(DataReader["MaQuanLy"]);
                    obj.TenBenhNhan = Common.ConDBNull(DataReader["TenBenhNhan"]);
                    obj.MaBenhNhan = Common.ConDBNull(DataReader["MaBenhNhan"]);
                    obj.Tuoi = Common.ConDBNull(DataReader["Tuoi"]);
                    obj.MaBenhAn = Common.ConDBNull(DataReader["MaBenhAn"]);
                    obj.Khoa = Common.ConDBNull(DataReader["Khoa"]);
                    obj.MaKhoa = Common.ConDBNull(DataReader["MaKhoa"]);
                    obj.CanNang = Common.ConDBNull_float(DataReader["CanNang"]);
                    obj.ChieuCao = Common.ConDBNull_float(DataReader["ChieuCao"]);
                    obj.BMI = Common.ConDBNull_float(DataReader["BMI"]);
                    obj.CanNangRV = Common.ConDBNull_float(DataReader["CanNangRV"]);
                    obj.MaBSDT = Common.ConDBNull(DataReader["MaBSDT"]);
                    obj.TenBSDT = Common.ConDBNull(DataReader["TenBSDT"]);
                    obj.MaNguoiTH = Common.ConDBNull(DataReader["MaNguoiTH"]);
                    obj.TenNguoiTH = Common.ConDBNull(DataReader["TenNguoiTH"]);
                    obj.DuongNuoi = Common.ConDB_Int(DataReader["DuongNuoi"]);
                    obj.TaiKham = Common.ConDB_Int(DataReader["TaiKham"]);
                    obj.DGBMI = Common.ConDBNull(DataReader["DGBMI"]);
                    obj.DGMUAC = Common.ConDBNull(DataReader["DGMUAC"]);
                    obj.ThoiGian = Common.ConDB_DateTime(DataReader["ThoiGian"]);
                    obj.ND0 = Common.ConDBNull(DataReader["ND0"]);
                    obj.ND1 = Common.ConDBNull(DataReader["ND1"]);
                    obj.ND2 = Common.ConDBNull(DataReader["ND2"]);
                    obj.ND3 = Common.ConDBNull(DataReader["ND3"]);
                    obj.ND4 = Common.ConDBNull(DataReader["ND4"]);
                    obj.ND5 = Common.ConDBNull(DataReader["ND5"]);
                    obj.ND6 = Common.ConDBNull(DataReader["ND6"]);
                    obj.ND7 = Common.ConDBNull(DataReader["ND7"]);
                    obj.NgayTao = Common.ConDB_DateTime(DataReader["NgayTao"]);
                    obj.NguoiTao = Common.ConDBNull(DataReader["NguoiTao"]);
                    obj.NgaySua = Common.ConDB_DateTime(DataReader["NgaySua"]);
                    obj.NguoiSua = Common.ConDBNull(DataReader["NguoiSua"]);
                    obj.MaSoKy = Common.ConDBNull(DataReader["MaSoKyTen"]);
                    obj.DaKy = !string.IsNullOrEmpty(obj.MaSoKy) ? true : false;
                    obj.Chon = false;
                    lstObject.Add(obj);
                }
                return lstObject;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static DataSet GetDataSet(MDB.MDBConnection MyConnection, decimal IDBienBan)
        {
            string sql = @"SELECT P.*, T.SoNhapVien, T.Khoa as Khoa2,
                  H.SoYTe, H.BENHVIEN, H.NgheNghiep
                  FROM PDGDDTE3 P 
                Left JOIN THONGTINDIEUTRI T ON P.MAQUANLY = T.MAQUANLY
                Left JOIN HANHCHINHBENHNHAN H ON T.MABENHNHAN = H.MABENHNHAN
                  where IDPhieu  = :IDPhieu";
            MDB.MDBCommand Command;
            MDB.MDBDataAdapter adt;
            using (Command = new MDB.MDBCommand(sql, MyConnection))
            {
                Command.Parameters.Add(new MDB.MDBParameter("IDPhieu", IDBienBan));
                adt = new MDB.MDBDataAdapter(Command);
            }
            var ds = new DataSet();
            adt.Fill(ds, "TBL");
            if(ds.Tables[0].Rows.Count > 0)
            {
                if(string.IsNullOrEmpty(ds.Tables[0].Rows[0]["Khoa"].ToString()))
                {
                    ds.Tables[0].Rows[0]["Khoa"] = ds.Tables[0].Rows[0]["Khoa2"];
                }
            }
            return ds;
        }
        public static bool InsertOrUpdate(MDB.MDBConnection oracleConnection, PhieuDanhGiaDinhDuongTreEm3 obj, ref bool isUpdate)
        {
            try
            {
                string sql = @"SELECT COUNT(*) RECNUM FROM PDGDDTE3 WHERE IDPhieu  = :IDPhieu";
                MDB.MDBCommand oracleCommand;
                int rowCount = 0;
                int nRecord = 0;
                oracleCommand = new MDB.MDBCommand(sql, oracleConnection);
                oracleCommand.Parameters.Add("IDPhieu", obj.IDPhieu);
                MDB.MDBDataReader oracleDataReader = oracleCommand.ExecuteReader();
                while (oracleDataReader.Read())
                {
                    rowCount = int.Parse(oracleDataReader["RECNUM"].ToString());
                }
                if (rowCount > 0)
                {
                    isUpdate = true;
                    sql = "update PDGDDTE3 set MaQuanLy=:MaQuanLy,TenBenhNhan=:TenBenhNhan,MaBenhNhan=:MaBenhNhan,Tuoi=:Tuoi,MaBenhAn=:MaBenhAn,Khoa=:Khoa,MaKhoa=:MaKhoa,CanNang=:CanNang,ChieuCao=:ChieuCao,BMI=:BMI,CanNangRV=:CanNangRV,MaBSDT=:MaBSDT,TenBSDT=:TenBSDT,MaNguoiTH=:MaNguoiTH,TenNguoiTH=:TenNguoiTH,DuongNuoi=:DuongNuoi,TaiKham=:TaiKham,DGBMI=:DGBMI,DGMUAC=:DGMUAC,ThoiGian=:ThoiGian,ND0=:ND0,ND1=:ND1,ND2=:ND2,ND3=:ND3,ND4=:ND4,ND5=:ND5,ND6=:ND6,ND7=:ND7,NgayTao=:NgayTao,NguoiTao=:NguoiTao,NgaySua=:NgaySua,NguoiSua=:NguoiSua";
                    sql = sql + " WHERE IDPhieu  = " + obj.IDPhieu.ToString();
                }
                else
                {
                    sql = @"insert into PDGDDTE3(MaQuanLy,TenBenhNhan,MaBenhNhan,Tuoi,MaBenhAn,Khoa,MaKhoa,CanNang,ChieuCao,BMI,CanNangRV,MaBSDT,TenBSDT,MaNguoiTH,TenNguoiTH,DuongNuoi,TaiKham,DGBMI,DGMUAC,ThoiGian,ND0,ND1,ND2,ND3,ND4,ND5,ND6,ND7,NgayTao,NguoiTao,NgaySua,NguoiSua" +
                        ")";
                    sql = sql + @"Values(:MaQuanLy,:TenBenhNhan,:MaBenhNhan,:Tuoi,:MaBenhAn,:Khoa,:MaKhoa,:CanNang,:ChieuCao,:BMI,:CanNangRV,:MaBSDT,:TenBSDT,:MaNguoiTH,:TenNguoiTH,:DuongNuoi,:TaiKham,:DGBMI,:DGMUAC,:ThoiGian,:ND0,:ND1,:ND2,:ND3,:ND4,:ND5,:ND6,:ND7,:NgayTao,:NguoiTao,:NgaySua,:NguoiSua" +
                        ")   RETURNING IDPhieu INTO :IDPhieu";
                }
                oracleCommand = new MDB.MDBCommand(sql, oracleConnection);
                oracleCommand.Parameters.Add(new MDB.MDBParameter("MaQuanLy", obj.MaQuanLy));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("TenBenhNhan", obj.TenBenhNhan));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("MaBenhNhan", obj.MaBenhNhan));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("Tuoi", obj.Tuoi));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("MaBenhAn", obj.MaBenhAn));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("Khoa", obj.Khoa));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("MaKhoa", obj.MaKhoa));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("CanNang", obj.CanNang));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("ChieuCao", obj.ChieuCao));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("BMI", obj.BMI));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("CanNangRV", obj.CanNangRV));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("MaBSDT", obj.MaBSDT));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("TenBSDT", obj.TenBSDT));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("MaNguoiTH", obj.MaNguoiTH));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("TenNguoiTH", obj.TenNguoiTH));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("DuongNuoi", obj.DuongNuoi));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("TaiKham", obj.TaiKham));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("DGBMI", obj.DGBMI));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("DGMUAC", obj.DGMUAC));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("ThoiGian", obj.ThoiGian));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("ND0", obj.ND0));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("ND1", obj.ND1));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("ND2", obj.ND2));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("ND3", obj.ND3));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("ND4", obj.ND4));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("ND5", obj.ND5));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("ND6", obj.ND6));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("ND7", obj.ND7));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("NgayTao", obj.NgayTao));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("NguoiTao", obj.NguoiTao));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("NgaySua", DateTime.Now));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("NguoiSua", Common.getUserLogin()));

                if (!isUpdate)
                {
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("IDPhieu", obj.IDPhieu));
                }
                nRecord = oracleCommand.ExecuteNonQuery();
                if (nRecord > 0)
                {
                    if (!isUpdate)
                    {
                        decimal nextval = Common.ConDB_Decimal((oracleCommand.Parameters["IDPhieu"] as MDB.MDBParameter).Value);
                        obj.IDPhieu = nextval;
                    }
                }
                return nRecord > 0;
            }
            catch (Exception ex)
            {
                XuLyLoi.LogError(ex);
            }
            return false;
        }
        public static bool DeleteByIDPhieu(MDB.MDBConnection oracleConnection, List<decimal> lstIDbienBan)
        {
            try
            {
                string sql = "";
                string strWhere = "";
                MDB.MDBCommand oracleCommand;
                strWhere = " IDPhieu In(";
                if (lstIDbienBan.Count > 0)
                {
                    for (int i = 0; i < lstIDbienBan.Count; i++)
                    {
                        strWhere = strWhere + lstIDbienBan[i].ToString();
                        if (i == (lstIDbienBan.Count - 1))
                        {
                            strWhere = strWhere + ")";
                        }
                        else
                        {
                            strWhere = strWhere + ",";
                        }
                    }
                }
                sql = @"DELETE FROM PDGDDTE3 WHERE  " + strWhere;
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
    }
}
