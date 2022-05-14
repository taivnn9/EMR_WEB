using EMR.KyDienTu;
using System;
using System.Data;
using PMS.Access;

namespace EMR_MAIN.DATABASE.Other
{
    public class PhieuDanhGiaTinhTrangDDTbl : ThongTinKy
    {
        public PhieuDanhGiaTinhTrangDDTbl()
        {
            TableName = "DanhGiaTinhTrangDinhDuong";
            TablePrimaryKeyName = "ID";
            IDMauPhieu = (int)DanhMucPhieu.PDGTTDD;
            TenMauPhieu = DanhMucPhieu.PDGTTDD.Description();
        }
        [MoTaDuLieu("Mã định danh")]
		public decimal IDPhieu { get; set; }
        [MoTaDuLieu("Mã quản lý: mã duy nhất trong 1 đợt khám chữa bệnh (kcb), không trùng giữa các đợt kcb khác nhau","",1)]
		public decimal MaQuanLy { get; set; }
        [MoTaDuLieu("Chẩn đoán bệnh")]
		public string ChanDoan { get; set; }
        [MoTaDuLieu("Mã bệnh nhân")]
		public string MaBenhNhan { get; set; }
        [MoTaDuLieu("Họ và tên bệnh nhân")]
		public string TenBenhNhan { get; set; }
        [MoTaDuLieu("Khoa")]
		public string Khoa { get; set; }
        [MoTaDuLieu("Mã khoa")]
		public string MaKhoa { get; set; }
        public DateTime? NgayVaoVien { get; set; }
        [MoTaDuLieu("Mã bệnh án")]
		public string MaBenhAn { get; set; }
        public double? ChieuCao { get; set; }
        public double? CanNang { get; set; }
        public double? BMI { get; set; }
        public bool SLBDLoai1_Co { get; set; }
        public bool SLBDLoai1_Ko { get; set; }
        public bool SLBDLoai2_Co { get; set; }
        public bool SLBDLoai2_Ko { get; set; }
        public bool SLBDLoai3_Co { get; set; }
        public bool SLBDLoai3_Ko { get; set; }
        public bool SLBDLoai4_Co { get; set; }
        public bool SLBDLoai4_Ko { get; set; }
        public int? TTSDDDiem { get; set; }
        public int? TTBLDiem { get; set; }
        public int? TongDiemSL2 { get; set; }
        public int? TongDiem { get; set; }
        public string DanhGiaDinhDuong { get; set; }
        [MoTaDuLieu("Mã người thực hiện")]
		public string MaNguoiThucHien { get; set; }
        public string TenNguoiThucHien { get; set; }
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
    public class PhieuDanhGiaTinhTrangDDFunc
    {
        public const string TableName = "DanhGiaTinhTrangDinhDuong";
        public const string TablePrimaryKeyName = "IDPhieu";
        public const string MaPhieu = "PDGTTDD";
        public static PhieuDanhGiaTinhTrangDDTbl GeData(MDB.MDBConnection MyConnection, decimal MaQuanly)
        {
            try
            {
                {
                    PhieuDanhGiaTinhTrangDDTbl obj = new PhieuDanhGiaTinhTrangDDTbl();
                    string sql = @"SELECT t.*
                    FROM DanhGiaTinhTrangDinhDuong t
                    WHERE t.MaQuanLy = :MaQuanLy";
                    MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
                    Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", MaQuanly));
                    MDB.MDBDataReader DataReader = Command.ExecuteReader();
                    while (DataReader.Read())
                    {
                        obj.IDPhieu = Common.ConDB_Decimal(DataReader["IDPhieu"]);
                        obj.MaQuanLy = Common.ConDB_Decimal(DataReader["MaQuanLy"]);
                        obj.ChanDoan = Common.ConDBNull(DataReader["ChanDoan"]);
                        obj.MaBenhNhan = Common.ConDBNull(DataReader["MaBenhNhan"]);
                        obj.TenBenhNhan = Common.ConDBNull(DataReader["TenBenhNhan"]);
                        obj.Khoa = Common.ConDBNull(DataReader["Khoa"]);
                        obj.MaKhoa = Common.ConDBNull(DataReader["MaKhoa"]);
                        obj.NgayVaoVien = Common.ConDB_DateTime(DataReader["NgayVaoVien"]);
                        obj.MaBenhAn = Common.ConDBNull(DataReader["MaBenhAn"]);
                        obj.ChieuCao = Common.ConDBNull_float(DataReader["ChieuCao"]);
                        obj.CanNang = Common.ConDBNull_float(DataReader["CanNang"]);
                        obj.BMI = Common.ConDBNull_float(DataReader["BMI"]);
                        obj.SLBDLoai1_Co =DataReader["SLBDLoai1_Co"].ToString() == "1" ? true : false;
                        obj.SLBDLoai1_Ko = DataReader["SLBDLoai1_Ko"].ToString() == "1" ? true : false;
                        obj.SLBDLoai2_Co = DataReader["SLBDLoai2_Co"].ToString() == "1" ? true : false;
                        obj.SLBDLoai2_Ko = DataReader["SLBDLoai2_Ko"].ToString() == "1" ? true : false;
                        obj.SLBDLoai3_Co = DataReader["SLBDLoai3_Co"].ToString() == "1" ? true : false;
                        obj.SLBDLoai3_Ko = DataReader["SLBDLoai3_Ko"].ToString() == "1" ? true : false;
                        obj.SLBDLoai4_Co = DataReader["SLBDLoai4_Co"].ToString() == "1" ? true : false;
                        obj.SLBDLoai4_Ko = DataReader["SLBDLoai4_Ko"].ToString() == "1" ? true : false;
                        obj.TTSDDDiem = Common.ConDB_Int(DataReader["TTSDDDiem"]);
                        obj.TTBLDiem = Common.ConDB_Int(DataReader["TTBLDiem"]);
                        obj.TongDiemSL2 = Common.ConDB_Int(DataReader["TongDiemSL2"]);
                        obj.TongDiem = Common.ConDB_Int(DataReader["TongDiem"]);
                        obj.DanhGiaDinhDuong = Common.ConDBNull(DataReader["DanhGiaDinhDuong"]);
                        obj.MaNguoiThucHien = Common.ConDBNull(DataReader["MaNguoiThucHien"]);
                        obj.TenNguoiThucHien = Common.ConDBNull(DataReader["TenNguoiThucHien"]);
                        obj.NgayTao = Common.ConDB_DateTime(DataReader["NgayTao"]);
                        obj.NgaySua = Common.ConDB_DateTime(DataReader["NgaySua"]);
                        obj.MaSoKy = Common.ConDBNull(DataReader["MaSoKyTen"]);
                        obj.DaKy = !string.IsNullOrEmpty(obj.MaSoKy) ? true : false;
                    }

                    return obj;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static DataSet GetDataSet(MDB.MDBConnection MyConnection, decimal IDBienBan)
        {
            string sql = @"SELECT P.*, T.SoNhapVien,T.MaBenhAn, 
                H.TUOI,H.SoYTe, H.BENHVIEN, H.NgaySinh, H.NgheNghiep
                  FROM DanhGiaTinhTrangDinhDuong P 
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
            return ds;
        }
        public static bool InsertOrUpdate(MDB.MDBConnection oracleConnection, PhieuDanhGiaTinhTrangDDTbl obj, ref bool isUpdate)
        {
            try
            {
                string sql = @"SELECT COUNT(*) RECNUM FROM DanhGiaTinhTrangDinhDuong WHERE IDPhieu  = :IDPhieu";
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
                    sql = "update DanhGiaTinhTrangDinhDuong set MaQuanLy  = :MaQuanLy,ChanDoan  = :ChanDoan,MaBenhNhan  = :MaBenhNhan,TenBenhNhan  = :TenBenhNhan,Khoa  = :Khoa,MaKhoa  = :MaKhoa,NgayVaoVien  = :NgayVaoVien,MaBenhAn  = :MaBenhAn,ChieuCao  = :ChieuCao,CanNang  = :CanNang,BMI  = :BMI,SLBDLoai1_Co  = :SLBDLoai1_Co,SLBDLoai1_Ko  = :SLBDLoai1_Ko,SLBDLoai2_Co  = :SLBDLoai2_Co,SLBDLoai2_Ko  = :SLBDLoai2_Ko,SLBDLoai3_Co  = :SLBDLoai3_Co,SLBDLoai3_Ko  = :SLBDLoai3_Ko,SLBDLoai4_Co  = :SLBDLoai4_Co,SLBDLoai4_Ko  = :SLBDLoai4_Ko,TTSDDDiem  = :TTSDDDiem,TTBLDiem  = :TTBLDiem,TongDiemSL2  = :TongDiemSL2,TongDiem  = :TongDiem,DanhGiaDinhDuong  = :DanhGiaDinhDuong,MaNguoiThucHien  = :MaNguoiThucHien,TenNguoiThucHien  = :TenNguoiThucHien,NgayTao  = :NgayTao,NgaySua  = :NgaySua";
                    sql = sql + " WHERE IDPhieu  = " + obj.IDPhieu.ToString();
                }
                else
                {
                    while (oracleDataReader.Read())
                    {
                        IDphieuNext = Common.ConDB_Decimal(oracleDataReader["IDPhieu"]) + 1;
                    }
                    sql = @"insert into DanhGiaTinhTrangDinhDuong(MaQuanLy,ChanDoan,MaBenhNhan,TenBenhNhan,Khoa,MaKhoa,NgayVaoVien,MaBenhAn,ChieuCao,CanNang,BMI,SLBDLoai1_Co,SLBDLoai1_Ko,SLBDLoai2_Co,SLBDLoai2_Ko,SLBDLoai3_Co,SLBDLoai3_Ko,SLBDLoai4_Co,SLBDLoai4_Ko,TTSDDDiem,TTBLDiem,TongDiemSL2,TongDiem,DanhGiaDinhDuong,MaNguoiThucHien,TenNguoiThucHien,NgayTao,NgaySua" +
                        ")";
                    sql = sql + @"Values(:MaQuanLy, :ChanDoan, :MaBenhNhan, :TenBenhNhan, :Khoa, :MaKhoa, :NgayVaoVien, :MaBenhAn, :ChieuCao, :CanNang, :BMI, :SLBDLoai1_Co, :SLBDLoai1_Ko, :SLBDLoai2_Co, :SLBDLoai2_Ko, :SLBDLoai3_Co, :SLBDLoai3_Ko, :SLBDLoai4_Co, :SLBDLoai4_Ko, :TTSDDDiem, :TTBLDiem, :TongDiemSL2, :TongDiem, :DanhGiaDinhDuong, :MaNguoiThucHien, :TenNguoiThucHien, :NgayTao, :NgaySua" +
                        ")   RETURNING IDPhieu INTO :IDPhieu";
                }
                oracleCommand = new MDB.MDBCommand(sql, oracleConnection);
                oracleCommand.Parameters.Add(new MDB.MDBParameter("MaQuanLy", obj.MaQuanLy));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("ChanDoan", obj.ChanDoan));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("MaBenhNhan", obj.MaBenhNhan));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("TenBenhNhan", obj.TenBenhNhan));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("Khoa", obj.Khoa));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("MaKhoa", obj.MaKhoa));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("NgayVaoVien", obj.NgayVaoVien));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("MaBenhAn", obj.MaBenhAn));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("ChieuCao", obj.ChieuCao));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("CanNang", obj.CanNang));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("BMI", obj.BMI));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("SLBDLoai1_Co", obj.SLBDLoai1_Co == true ? "1" : "0"));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("SLBDLoai1_Ko", obj.SLBDLoai1_Ko == true ? "1" : "0"));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("SLBDLoai2_Co", obj.SLBDLoai2_Co == true ? "1" : "0"));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("SLBDLoai2_Ko", obj.SLBDLoai2_Ko == true ? "1" : "0"));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("SLBDLoai3_Co", obj.SLBDLoai3_Co == true ? "1" : "0"));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("SLBDLoai3_Ko", obj.SLBDLoai3_Ko == true ? "1" : "0"));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("SLBDLoai4_Co", obj.SLBDLoai4_Co == true ? "1" : "0"));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("SLBDLoai4_Ko", obj.SLBDLoai4_Ko == true ? "1" : "0"));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("TTSDDDiem", obj.TTSDDDiem));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("TTBLDiem", obj.TTBLDiem));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("TongDiemSL2", obj.TongDiemSL2));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("TongDiem", obj.TongDiem));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("DanhGiaDinhDuong", obj.DanhGiaDinhDuong));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("MaNguoiThucHien", obj.MaNguoiThucHien));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("TenNguoiThucHien", obj.TenNguoiThucHien));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("NgayTao", obj.NgayTao));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("NgaySua", DateTime.Now));
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
        public static bool DeleteByIDPhieu(MDB.MDBConnection oracleConnection, decimal IDBienBan)
        {
            try
            {
                string sql = "";
                MDB.MDBCommand oracleCommand;
                sql = @"DELETE FROM DanhGiaTinhTrangDinhDuong WHERE IDPhieu  = " + IDBienBan.ToString();
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
