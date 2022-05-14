using EMR.KyDienTu;
using System;
using System.Collections.Generic;
using System.Data;
using PMS.Access;

namespace EMR_MAIN.DATABASE.Other
{
    public class GiayCamKetChapNhanTTNCTTM : ThongTinKy
    {
        [MoTaDuLieu("Mã định danh")]
		public long ID { get; set; }
        [MoTaDuLieu("Mã quản lý: mã duy nhất trong 1 đợt khám chữa bệnh (kcb), không trùng giữa các đợt kcb khác nhau","",1)]
		public decimal MaQuanLy { get; set; }
        [MoTaDuLieu("Bệnh viện")]
		public string BenhVien { get; set; }
        [MoTaDuLieu("Mã bệnh nhân")]
		public string MaBenhNhan { get; set; }
        [MoTaDuLieu("Sở Y Tế")]
		public string SoYTe { get; set; }
        public string MaSo { get; set; }
        public string HoTen { get; set; }
        [MoTaDuLieu("Tuổi bệnh nhân")]
		public string Tuoi { get; set; }
        [MoTaDuLieu("Giới tính bệnh nhân")]
		public string GioiTinh { get; set; }
        [MoTaDuLieu("Dân tộc")]
		public string DanToc { get; set; }
        public string SoDT { get; set; }
        [MoTaDuLieu("Nghề nghiệp")]
		public string NgheNghiep { get; set; }
        public string NoiLamViec { get; set; }
        [MoTaDuLieu("Địa chỉ nhà bệnh nhân")]
		public string DiaChi { get; set; }
        public string QuanHe { get; set; }
        [MoTaDuLieu("Họ tên người thân")]
		public string NguoiThan { get; set; }
        public string NguoiChungThuNhat { get; set; }
        public string NguoiChungThuHai { get; set; }

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
        [MoTaDuLieu("Chọn", null, 0, 0)]
		public bool Chon { get; set; }

        [MoTaDuLieu("Khoa")]
		public string Khoa { get; set; }
        public GiayCamKetChapNhanTTNCTTM()
        {
            ID = 0;
            TenFileKy = "";
            UserNameKy = "";
            NgayKi = DateTime.Now;
            ComputerKyTen = "";
            MaSoKy = "";
            NgayTao = DateTime.Now;
            MaQuanLy = 0;
        }
    }
    public class GiayCamKetChapNhanTTNCTTMFunc
    {

        public const string TableName = "GiayCamKetCNTTNCTTM";
        public const string TablePrimaryKeyName = "ID";

        public static bool Delete(MDB.MDBConnection MyConnection, decimal id)
        {
            try
            {
                string sql = "DELETE FROM GiayCamKetCNTTNCTTM WHERE ID = :ID";
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
       
        public static DataSet GetDataSet(MDB.MDBConnection MyConnection, string IDCHon)
        {
            string sql = @"select * "
                         + " from GiayCamKetCNTTNCTTM WHERE ID =: ID ORDER BY NgayTao, NgaySua asc";
            MDB.MDBCommand Command;
            MDB.MDBDataAdapter adt;
            using (Command = new MDB.MDBCommand(sql, MyConnection))
            {
                Command.Parameters.Add(new MDB.MDBParameter("ID", IDCHon));
                adt = new MDB.MDBDataAdapter(Command);
            }
            var ds = new DataSet();
            adt.Fill(ds, "TBL");
            return ds;
        }
        public static bool InsertOrUpdate(MDB.MDBConnection MyConnection, GiayCamKetChapNhanTTNCTTM ketQua)
        {
            try
            {
                string sql = @"INSERT INTO GiayCamKetCNTTNCTTM
                (
                    MaQuanLy,
                    MaBenhNhan,
                    Khoa,
                    HoTen,
                    Tuoi,
                    GioiTinh,
                    DanToc,
                    SoDT,
                    NgheNghiep,
                    NoiLamViec,
                    DiaChi,
                    QuanHe,
                    NguoiThan,
                    NguoiChungThuNhat,
                    NguoiChungThuHai,
                    NGUOITAO,
                    NGUOISUA,
                    NGAYTAO,
                    NGAYSUA)  VALUES
                 (
				    :MaQuanLy,
                    :MaBenhNhan,
                    :Khoa,
                    :HoTen,
                    :Tuoi,
                    :GioiTinh,
				    :DanToc,
                    :SoDT,
                    :NgheNghiep,
                    :NoiLamViec,
                    :DiaChi,
                    :QuanHe,
                    :NguoiThan,
                    :NguoiChungThuNhat,
                    :NguoiChungThuHai,
                    :NGUOITAO,
                    :NGUOISUA,
                    :NGAYTAO,
                    :NGAYSUA
                 )  RETURNING ID INTO :ID";
                if (ketQua.ID != 0)
                {
                    sql = @"UPDATE GiayCamKetCNTTNCTTM SET 
                    MaQuanLy = :MaQuanLy,
                    MaBenhNhan = :MaBenhNhan,
                    Khoa = :Khoa,
                    HoTen = :HoTen,
                    Tuoi = :Tuoi,
                    GioiTinh = :GioiTinh,
                    DanToc = :DanToc,
                    SoDT = :SoDT,
                    NgheNghiep = :NgheNghiep,
                    NoiLamViec = :NoiLamViec,
                    DiaChi = :DiaChi,
                    QuanHe = :QuanHe,
                    NguoiThan = :NguoiThan,
                    NguoiChungThuNhat = :NguoiChungThuNhat,
                    NguoiChungThuHai = :NguoiChungThuHai,
                    NGUOISUA = :NGUOISUA,
                    NGAYSUA = :NGAYSUA 
                    WHERE ID = " + ketQua.ID;
                }
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);

                Command.Parameters.Add(new MDB.MDBParameter("NGUOISUA", ketQua.NguoiSua));
                Command.Parameters.Add(new MDB.MDBParameter("NGAYSUA", ketQua.NgaySua));

                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", ketQua.MaQuanLy));
                Command.Parameters.Add(new MDB.MDBParameter("MaBenhNhan", ketQua.MaBenhNhan));
                Command.Parameters.Add(new MDB.MDBParameter("HoTen", ketQua.HoTen));
                Command.Parameters.Add(new MDB.MDBParameter("GioiTinh", ketQua.GioiTinh));
                Command.Parameters.Add(new MDB.MDBParameter("Khoa", ketQua.Khoa));

                Command.Parameters.Add(new MDB.MDBParameter("Tuoi", ketQua.Tuoi));
                Command.Parameters.Add(new MDB.MDBParameter("DanToc", ketQua.DanToc));
                Command.Parameters.Add(new MDB.MDBParameter("SoDT", ketQua.SoDT));

                Command.Parameters.Add(new MDB.MDBParameter("NgheNghiep", ketQua.NgheNghiep));
                Command.Parameters.Add(new MDB.MDBParameter("NoiLamViec", ketQua.NoiLamViec));
                Command.Parameters.Add(new MDB.MDBParameter("DiaChi", ketQua.DiaChi));
                Command.Parameters.Add(new MDB.MDBParameter("QuanHe", ketQua.QuanHe));
                Command.Parameters.Add(new MDB.MDBParameter("NguoiThan", ketQua.NguoiThan));
                Command.Parameters.Add(new MDB.MDBParameter("NguoiChungThuNhat", ketQua.NguoiChungThuNhat));
                Command.Parameters.Add(new MDB.MDBParameter("NguoiChungThuHai", ketQua.NguoiChungThuHai));

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
                XuLyLoi.LogError(ex);
            }
            return false;
        }
        public static List<GiayCamKetChapNhanTTNCTTM> GetData(MDB.MDBConnection MyConnection, decimal MaQuanLy)
        {
            List<GiayCamKetChapNhanTTNCTTM> lstData = new List<GiayCamKetChapNhanTTNCTTM>();
            string sql = @"select * from GiayCamKetCNTTNCTTM WHERE MaQuanLy = :MaQuanLy ";
   
            sql += " ORDER BY NgayTao, NgaySua asc";
            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
            Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", MaQuanLy));
            MDB.MDBDataReader DataReader = Command.ExecuteReader();
            while (DataReader.Read())
            {
                GiayCamKetChapNhanTTNCTTM item = new GiayCamKetChapNhanTTNCTTM();

                item.ID = long.Parse(DataReader["ID"].ToString());

                item.MaBenhNhan = DataReader["MaBenhNhan"].ToString();
                item.HoTen = DataReader["HoTen"].ToString();
                item.Tuoi = DataReader["Tuoi"].ToString();
                item.GioiTinh = DataReader["GioiTinh"].ToString();
                item.Khoa = DataReader["Khoa"].ToString();
                item.MaQuanLy = ConDB_Decimal(DataReader["MaQuanLy"]);
                item.NgayTao = ConDB_DateTime(DataReader["NgayTao"]);
                item.NgaySua = ConDB_DateTime(DataReader["NgaySua"]);
                item.TenFileKy = ConDBNull(DataReader["TenFileKy"]);
                item.UserNameKy = ConDBNull(DataReader["UserNameKy"]);
                item.NgayKi = ConDB_DateTime(DataReader["NgayKi"]);
                item.ComputerKyTen = ConDBNull(DataReader["ComputerKyTen"]);
                item.MaSoKy = ConDBNull(DataReader["MaSoKy"]);

                item.DanToc = ConDBNull(DataReader["DanToc"]);
                item.SoDT = ConDBNull(DataReader["SoDT"]);
                item.NgheNghiep = ConDBNull(DataReader["NgheNghiep"]);
                item.NoiLamViec = ConDBNull(DataReader["NoiLamViec"]);
                item.DiaChi = ConDBNull(DataReader["DiaChi"]);
                item.QuanHe = ConDBNull(DataReader["QuanHe"]);
                item.NguoiThan = ConDBNull(DataReader["NguoiThan"]);
                item.NguoiChungThuNhat = ConDBNull(DataReader["NguoiChungThuNhat"]);
                item.NguoiChungThuHai = ConDBNull(DataReader["NguoiChungThuHai"]);

                lstData.Add(item);
                
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
