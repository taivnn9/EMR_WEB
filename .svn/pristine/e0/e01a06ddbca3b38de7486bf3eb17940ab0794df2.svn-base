using EMR.KyDienTu;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMR_MAIN.DATABASE.Other
{
    public class GiayKhamChuaBenhTheoYeuCauTbl : ThongTinKy
    {
        [MoTaDuLieu("Mã định danh")]
		public long IDMaPhieu { get; set; }
        [MoTaDuLieu("Mã quản lý: mã duy nhất trong 1 đợt khám chữa bệnh (kcb), không trùng giữa các đợt kcb khác nhau","",1)]
		public decimal MaQuanLy { get; set; }
        [MoTaDuLieu("Bệnh viện")]
		public string BenhVien { get; set; }
        [MoTaDuLieu("Mã bệnh nhân")]
		public string MaBenhNhan { get; set; }
        public string HoTen { get; set; }
        [MoTaDuLieu("Tuổi bệnh nhân")]
		public string Tuoi { get; set; }
        [MoTaDuLieu("Giới tính bệnh nhân")]
		public string GioiTinh { get; set; }
        public string SoCMND { get; set; }
        [MoTaDuLieu("Ngày cấp chứng minh nhân dân")]
        public DateTime NgayCap { get; set; }
        [MoTaDuLieu("Nơi cấp chứng minh nhân dân")]
		public string NoiCap { get; set; }
        [MoTaDuLieu("Dân tộc")]
		public string DanToc { get; set; }
        public string NgoaiKieu { get; set; }
        [MoTaDuLieu("Nghề nghiệp")]
		public string NgheNghiep { get; set; }
        public string NoiLamViec { get; set; }
        [MoTaDuLieu("Địa chỉ nhà bệnh nhân")]
		public string DiaChi { get; set; }
        [MoTaDuLieu("Họ tên người thân")]
		public string NguoiThan { get; set; }
        public string NguoiDaiDien { get; set; }
        public string SoPhong { get; set; }
        public string SoTienUng { get; set; }

        [MoTaDuLieu("Ngày tạo", null, 0, 0)]
		public DateTime NgayTao { get; set; }
        [MoTaDuLieu("Ngày sửa", null, 0, 0)]
		public DateTime NgaySua { get; set; }
        [MoTaDuLieu("Ngày ký")]
		public DateTime NgayKi { get; set; }
        [MoTaDuLieu("Người tạo", null, 0, 0)]
		public string NguoiTao { get; set; }
        [MoTaDuLieu("Người sửa", null, 0, 0)]
		public string NguoiSua { get; set; }

        public string BacSiKham { get; set; }
        [MoTaDuLieu("Họ tên điều dưỡng")]
		public string DieuDuong { get; set; }
        [MoTaDuLieu("Bác sỹ điều trị")]
		public string BacSiDieuTri { get; set; }

        public string GiamDocBenhVien { get; set; }

        [MoTaDuLieu("Chọn", null, 0, 0)]
		public bool Chon { get; set; }

        [MoTaDuLieu("Khoa")]
		public string Khoa { get; set; }
        public GiayKhamChuaBenhTheoYeuCauTbl()
        {
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
    public class GiayKhamChuaBenhTheoYeuCauFunc
    {

        public const string TableName = "GiayKhamChuaBenhTheoYeuCau";
        public const string TablePrimaryKeyName = "IDMaPhieu";

        public static bool Delete(MDB.MDBConnection MyConnection, decimal id)
        {
            try
            {
                string sql = "DELETE FROM GiayKhamChuaBenhTheoYeuCau WHERE IDMaPhieu = :ID";
                MDB.MDBCommand command = new MDB.MDBCommand(sql, MyConnection);
                command.Parameters.Add(new MDB.MDBParameter("ID", id));
                command.BindByName = true;
                int n = command.ExecuteNonQuery();
                return n > 0;
            }
            catch (Exception ex)
            {
                XuLyLoi.Handle(ex);
            }
            return false;
        }
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
                sql = @"DELETE FROM GiayKhamChuaBenhTheoYeuCau WHERE IDMaPhieu " + strWhere;
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
                         + " from GiayKhamChuaBenhTheoYeuCau AA left join thongtindieutri BB ON AA.MaBenhNhan = BB.MaBenhNhan WHERE IDMaPhieu =: IDMaPhieu ORDER BY NgayTao, NgaySua asc";
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
        public static bool InsertOrUpdate(MDB.MDBConnection oracleConnection, GiayKhamChuaBenhTheoYeuCauTbl obj)
        {
            try
            {
                string sql = @"SELECT COUNT(*) RECNUM FROM GiayKhamChuaBenhTheoYeuCau WHERE IDMaPhieu = :IDMaPhieu";
                MDB.MDBCommand oracleCommand;
                int rowCount = 0;
                int nRecord = 0;
                long sequence_nextval = 0;
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
                    sequence_nextval = obj.IDMaPhieu;
                    sql = "update GiayKhamChuaBenhTheoYeuCau set MaQuanLy = :MaQuanLy,BenhVien = :BenhVien,GiamDocBenhVien = :GiamDocBenhVien,MaBenhNhan = :MaBenhNhan,Khoa = :Khoa, HoTen = :HoTen,Tuoi = :Tuoi ,GioiTinh = :GioiTinh,SoCMND  = :SoCMND,NgayCap = :NgayCap ,NoiCap = :NoiCap,DanToc = :DanToc,NgoaiKieu = :NgoaiKieu,NgayTao = :NgayTao,NgaySua = :NgaySua,NgheNghiep = :NgheNghiep,NoiLamViec = :NoiLamViec, DiaChi = :DiaChi, NguoiThan = :NguoiThan, NguoiDaiDien = :NguoiDaiDien, SoPhong = :SoPhong, SoTienUng = :SoTienUng,TenFileKy = :TenFileKy,UserNameKy = :UserNameKy,NgayKi = :NgayKi,ComputerKyTen = :ComputerKyTen,MaSoKy = :MaSoKy, BacSiKham = :BacSiKham, DieuDuong = :DieuDuong, BacSiDieuTri = :BacSiDieuTri";
                    sql = sql + " WHERE IDMaPhieu = " + obj.IDMaPhieu.ToString();
                }
                else
                {
                    sql = @"select NVL(MAX(IDMaPhieu),0) AS sequence_nextval from GiayKhamChuaBenhTheoYeuCau";
                    using (oracleCommand = new MDB.MDBCommand(sql, oracleConnection))
                    {
                        MDB.MDBDataReader oracleDataReader = oracleCommand.ExecuteReader();
                        while (oracleDataReader.Read())
                        {
                            sequence_nextval = long.Parse(oracleDataReader["sequence_nextval"].ToString()) + 1;
                        }
                    }
                    sql = @"insert into GiayKhamChuaBenhTheoYeuCau(IDMaPhieu,MaQuanLy,BenhVien,GiamDocBenhVien,MaBenhNhan, Khoa,HoTen,Tuoi,GioiTinh,SoCMND,NgayCap,NoiCap,DanToc,NgoaiKieu,NgayTao,NgaySua,NgheNghiep,NoiLamViec,DiaChi,NguoiThan,NguoiDaiDien,SoPhong,SoTienUng,TenFileKy,UserNameKy,NgayKi,ComputerKyTen,MaSoKy, BacSiKham, DieuDuong, BacSiDieuTri)";
                    sql = sql + @"VALUES(:IDMaPhieu,:MaQuanLy,:BenhVien,:GiamDocBenhVien,:MaBenhNhan,:Khoa,:HoTen,:Tuoi,:GioiTinh,:SoCMND,:NgayCap,:NoiCap,:DanToc,:NgoaiKieu,:NgayTao,:NgaySua,:NgheNghiep,:NoiLamViec,:DiaChi,:NguoiThan,:NguoiDaiDien,:SoPhong,:SoTienUng,:TenFileKy,:UserNameKy,:NgayKi,:ComputerKyTen,:MaSoKy, :BacSiKham, :DieuDuong, :BacSiDieuTri)";
                }
                using (oracleCommand = new MDB.MDBCommand(sql, oracleConnection))
                {
                    if (rowCount <= 0)
                    {
                        oracleCommand.Parameters.Add(new MDB.MDBParameter("IDMaPhieu", sequence_nextval));
                    }

                    oracleCommand.Parameters.Add(new MDB.MDBParameter("MaQuanLy", obj.MaQuanLy));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("BenhVien", obj.BenhVien));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("GiamDocBenhVien", obj.GiamDocBenhVien));

                    oracleCommand.Parameters.Add(new MDB.MDBParameter("MaBenhNhan", obj.MaBenhNhan));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("Khoa", obj.Khoa));

                    oracleCommand.Parameters.Add(new MDB.MDBParameter("HoTen", obj.HoTen));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("Tuoi", obj.Tuoi));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("GioiTinh", obj.GioiTinh));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("SoCMND", obj.SoCMND));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("NgayCap", obj.NgayCap));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("NoiCap", obj.NoiCap));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("DanToc", obj.DanToc));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("NgoaiKieu", obj.NgoaiKieu));

                    oracleCommand.Parameters.Add(new MDB.MDBParameter("NgayTao", obj.NgayTao));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("NgaySua", obj.NgaySua));

                    oracleCommand.Parameters.Add(new MDB.MDBParameter("NgheNghiep", obj.NgheNghiep));

                    oracleCommand.Parameters.Add(new MDB.MDBParameter("NoiLamViec", obj.NoiLamViec));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("DiaChi", obj.DiaChi));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("NguoiThan", obj.NguoiThan));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("NguoiDaiDien", obj.NguoiDaiDien));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("SoPhong", obj.SoPhong));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("SoTienUng", obj.SoTienUng));

                    oracleCommand.Parameters.Add(new MDB.MDBParameter("TenFileKy", obj.TenFileKy));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("UserNameKy", obj.UserNameKy));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("NgayKi", obj.NgayKi));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("ComputerKyTen", obj.ComputerKyTen));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("MaSoKy", obj.MaSoKy));

                    oracleCommand.Parameters.Add(new MDB.MDBParameter("BacSiKham", obj.BacSiKham));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("DieuDuong", obj.DieuDuong));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("BacSiDieuTri", obj.BacSiDieuTri));

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
        public static List<GiayKhamChuaBenhTheoYeuCauTbl> GetData(MDB.MDBConnection MyConnection, decimal MaQuanLy)
        {
            List<GiayKhamChuaBenhTheoYeuCauTbl> lstData = new List<GiayKhamChuaBenhTheoYeuCauTbl>();
            string sql = @"select * from GiayKhamChuaBenhTheoYeuCau WHERE MaQuanLy = :MaQuanLy ";
   
            sql += " ORDER BY NgayTao, NgaySua asc";
            MDB.MDBCommand Command;
            using (Command = new MDB.MDBCommand(sql, MyConnection))
            {
                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", MaQuanLy));
                MDB.MDBDataReader DataReader = Command.ExecuteReader();
                while (DataReader.Read())
                {
                    GiayKhamChuaBenhTheoYeuCauTbl item = new GiayKhamChuaBenhTheoYeuCauTbl();

                    item.IDMaPhieu = long.Parse(DataReader["IDMaPhieu"].ToString());
                    item.BenhVien = ConDBNull(DataReader["BenhVien"]);
                    item.GiamDocBenhVien = ConDBNull(DataReader["GiamDocBenhVien"]);

                    item.Khoa = ConDBNull(DataReader["Khoa"]);
                    item.MaBenhNhan = ConDBNull(DataReader["MaBenhNhan"]);
                    item.MaQuanLy = ConDB_Decimal(DataReader["MaQuanLy"]);
                    item.NgayTao = ConDB_DateTime(DataReader["NgayTao"]);
                    item.NgaySua = ConDB_DateTime(DataReader["NgaySua"]);
                    item.TenFileKy = ConDBNull(DataReader["TenFileKy"]);
                    item.UserNameKy = ConDBNull(DataReader["UserNameKy"]);
                    item.NgayKi = ConDB_DateTime(DataReader["NgayKi"]);
                    item.ComputerKyTen = ConDBNull(DataReader["ComputerKyTen"]);
                    item.MaSoKy = ConDBNull(DataReader["MaSoKy"]);

                    item.HoTen = ConDBNull(DataReader["HoTen"]);
                    item.Tuoi = ConDBNull(DataReader["Tuoi"]);
                    item.GioiTinh = ConDBNull(DataReader["GioiTinh"]);
                    item.SoCMND = ConDBNull(DataReader["SoCMND"]);
                    item.NoiCap = ConDBNull(DataReader["NoiCap"]);
                    item.NgayCap = ConDB_DateTime(DataReader["NgayCap"]);

                    item.DanToc = ConDBNull(DataReader["DanToc"]);
                    item.NgoaiKieu = ConDBNull(DataReader["NgoaiKieu"]);
                    item.NgheNghiep = ConDBNull(DataReader["NgheNghiep"]);
                    item.NoiLamViec = ConDBNull(DataReader["NoiLamViec"]);
                    item.DiaChi = ConDBNull(DataReader["DiaChi"]);
                    item.NguoiThan = ConDBNull(DataReader["NguoiThan"]);
                    item.NguoiDaiDien = ConDBNull(DataReader["NguoiDaiDien"]);
                    item.SoPhong = ConDBNull(DataReader["SoPhong"]);
                    item.SoTienUng = ConDBNull(DataReader["SoTienUng"]);

                    item.BacSiKham = ConDBNull(DataReader["BacSiKham"]);
                    item.DieuDuong = ConDBNull(DataReader["DieuDuong"]);
                    item.BacSiDieuTri = ConDBNull(DataReader["BacSiDieuTri"]);

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
