
using EMR.KyDienTu;
using System;
using System.Collections.Generic;
using System.Data;
using PMS.Access;

namespace EMR_MAIN.DATABASE.Other
{
    public class CamKetTruocChuyenDaTruocPT: ThongTinKy
    {
        public CamKetTruocChuyenDaTruocPT()
        {
            TableName = "CamKetTruocChuyenDaTruocPT";
            TablePrimaryKeyName = "IDPhieu";
            IDMauPhieu = (int)DanhMucPhieu.CKTCDTPT;
            TenMauPhieu = DanhMucPhieu.CKTCDTPT.Description();
        }
        [MoTaDuLieu("Mã định danh")]
		public decimal IDPhieu { get; set; }
        [MoTaDuLieu("Sở Y Tế")]
		public string SoYTe { get; set; }
        [MoTaDuLieu("Bệnh viện")]
		public string BenhVien { get; set; }
        [MoTaDuLieu("Tên người nhà")]
        public string TenNguoiNha { get; set; }
        [MoTaDuLieu("Năm sinh người nhà")]
        public decimal NamSinhNguoiNha { get; set; }
        [MoTaDuLieu("Địa chỉ người nhà bệnh nhân")]
		public string DiaChiNguoiNha { get; set; }
        [MoTaDuLieu("Họ tên")]
        public string HoTen { get; set; }
        [MoTaDuLieu("Khoa")]
		public string Khoa { get; set; }
        [MoTaDuLieu("Ngày tạo", null, 0, 0)]
		public DateTime NgayTao { get; set; }
        [MoTaDuLieu("Ngày sửa", null, 0, 0)]
		public DateTime NgaySua { get; set; }
        [MoTaDuLieu("Mã quản lý: mã duy nhất trong 1 đợt khám chữa bệnh (kcb), không trùng giữa các đợt kcb khác nhau","",1)]
		public decimal MaQuanLy { get; set; }
        [MoTaDuLieu("Chọn", null, 0, 0)]
		public bool Chon { get; set; }
        //public string MaSoKyTen { get; set; }
        [MoTaDuLieu("Đã ký", null, 0, 0)]
		public bool DaKy { get; set; }
        //public const string TableName = "CamKetTruocChuyenDaTruocPT";
        //public const string TablePrimaryKeyName = "IDPhieu";
    }
    public class CamKetTruocChuyenDaTruocPTFunc
    {
        public static bool DeleteByIDPhieu(MDB.MDBConnection oracleConnection, List<decimal> IDBienBan)
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
                sql = @"DELETE FROM CamKetTruocChuyenDaTruocPT WHERE IDPhieu " + strWhere;
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
        public static DataSet GetDataSet(MDB.MDBConnection MyConnection, string IDBienBan)
        {
            string sql = @"select AA.*"
                         + " from CamKetTruocChuyenDaTruocPT AA WHERE IDPhieu =: IDPhieu ORDER BY NgayTao, NgaySua asc";
            MDB.MDBCommand Command;
            MDB.MDBDataAdapter adt;
            using (Command = new MDB.MDBCommand(sql, MyConnection))
            {
                Command.Parameters.Add(new MDB.MDBParameter("IDPhieu", IDBienBan));
                adt = new MDB.MDBDataAdapter(Command);
            }
            var ds = new DataSet();
            adt.Fill(ds, "TBL");
            return ds;
        }
        public static bool InsertOrUpdate(MDB.MDBConnection oracleConnection, CamKetTruocChuyenDaTruocPT obj, ref bool isUpdate)
        {
            try
            {
                string sql = @"SELECT COUNT(*) RECNUM FROM CamKetTruocChuyenDaTruocPT WHERE IDPhieu  = :IDPhieu ";
                MDB.MDBCommand oracleCommand;
                int rowCount = 0;
                int nRecord = 0;
                decimal IDphieuNext = 0;
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
                    IDphieuNext = obj.IDPhieu;
                    sql = "update CamKetTruocChuyenDaTruocPT set SoYTe=:SoYTe,BenhVien=:BenhVien,TenNguoiNha=:TenNguoiNha,NamSinhNguoiNha=:NamSinhNguoiNha,DiaChiNguoiNha=:DiaChiNguoiNha,HoTen=:HoTen,Khoa=:Khoa,NgayTao=:NgayTao,NgaySua=:NgaySua,MaQuanLy=:MaQuanLy";
                    sql = sql + " WHERE IDPhieu  = " + obj.IDPhieu.ToString();
                }
                else
                {
                    sql = @"insert into CamKetTruocChuyenDaTruocPT(SoYTe,BenhVien,TenNguoiNha,NamSinhNguoiNha,DiaChiNguoiNha,HoTen,Khoa,NgayTao,NgaySua,MaQuanLy" +
                        ")";
                    sql = sql + @"Values(:SoYTe,:BenhVien,:TenNguoiNha,:NamSinhNguoiNha,:DiaChiNguoiNha,:HoTen,:Khoa,:NgayTao,:NgaySua,:MaQuanLy" +
                        ")   RETURNING IDPhieu INTO :IDPhieu";
                }
                oracleCommand = new MDB.MDBCommand(sql, oracleConnection);
                oracleCommand.Parameters.Add(new MDB.MDBParameter("SoYTe", obj.SoYTe));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("BenhVien", obj.BenhVien));

                oracleCommand.Parameters.Add(new MDB.MDBParameter("TenNguoiNha", obj.TenNguoiNha));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("NamSinhNguoiNha", obj.NamSinhNguoiNha));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("DiaChiNguoiNha", obj.DiaChiNguoiNha));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("HoTen", obj.HoTen));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("Khoa", obj.Khoa));
                
                oracleCommand.Parameters.Add(new MDB.MDBParameter("NgayTao", obj.NgayTao));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("NgaySua", obj.NgaySua));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("MaQuanLy", obj.MaQuanLy));
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
                return nRecord > 0 ? true : false;
            }
            catch (Exception ex)
            {
                XuLyLoi.LogError(ex);
            }
            return false;

        }
        public static List<CamKetTruocChuyenDaTruocPT> GetData(MDB.MDBConnection MyConnection, decimal MaQuanLy)
        {
            List<CamKetTruocChuyenDaTruocPT> lstData = new List<CamKetTruocChuyenDaTruocPT>();
            string sql = @"select * from CamKetTruocChuyenDaTruocPT WHERE MaQuanLy = :MaQuanLy ";
            sql += " ORDER BY NgayTao, NgaySua asc";
            MDB.MDBCommand Command;
            using (Command = new MDB.MDBCommand(sql, MyConnection))
            {
                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", MaQuanLy));
                MDB.MDBDataReader DataReader = Command.ExecuteReader();
                while (DataReader.Read())
                {
                    lstData.Add(new CamKetTruocChuyenDaTruocPT
                    {
                        IDPhieu = Common.ConDB_Decimal(DataReader["IDPhieu"]),

                        SoYTe = Common.ConDBNull(DataReader["SoYTe"]),
                        BenhVien = Common.ConDBNull(DataReader["BenhVien"]),

                        TenNguoiNha = Common.ConDBNull(DataReader["TenNguoiNha"]),
                        DiaChiNguoiNha = Common.ConDBNull(DataReader["DiaChiNguoiNha"]),
                        NamSinhNguoiNha = Common.ConDB_Decimal(DataReader["NamSinhNguoiNha"], 1900),

                        HoTen = Common.ConDBNull(DataReader["HoTen"]),
                        Khoa = Common.ConDBNull(DataReader["Khoa"]),

                        NgayTao = Common.ConDB_DateTime(DataReader["NgayTao"]),
                        NgaySua = Common.ConDB_DateTime(DataReader["NgaySua"]),
                        MaQuanLy = Common.ConDB_Decimal(DataReader["MaQuanLy"]),
                        MaSoKy = Common.ConDBNull(DataReader["MASOKYTEN"]),
                        DaKy = !string.IsNullOrEmpty(Common.ConDBNull(DataReader["masokyten"])) ? true : false,
                        Chon = false
                    });
                }
            }
            return lstData;
        }

    }
}

//CREATE TABLE CAMKETTRUOCCHUYENDATRUOCPT(
//IDPHIEU NUMBER(30) PRIMARY KEY NOT NULL,
//SOYTE VARCHAR(50),
//BENHVIEN VARCHAR(50),
//TENNGUOINHA VARCHAR(50),
//NAMSINHNGUOINHA NUMBER(30),
//DIACHINGUOINHA VARCHAR(100),
//HOTEN VARCHAR(50),
//KHOA VARCHAR(100),
//NGAYTAO Date,
//NGAYSUA Date,
//NGAYKY DATE,
//COMPUTERKYTEN VARCHAR2(50 BYTE), 
//MASOKYTEN VARCHAR2(50 BYTE), 
//TENFILEKY VARCHAR2(2000 BYTE), 
//USERNAMEKY VARCHAR2(100 BYTE)
//);
   

//create sequence CAMKETTRUOCCHUYENDATRUOCPT_SEQ;
//create or replace trigger TRG_CAMKETTRUOCCHUYENDATRUOCPT before insert on CAMKETTRUOCCHUYENDATRUOCPT for each row  begin select CAMKETTRUOCCHUYENDATRUOCPT_SEQ.nextval into :new.IDPHIEU from dual; end;
