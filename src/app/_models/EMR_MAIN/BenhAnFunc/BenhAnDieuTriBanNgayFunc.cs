using EMR_MAIN.DATABASE.BenhAn;
using System.Data;
using System.Globalization;

namespace EMR_MAIN.DATABASE.BenhAnFunc
{
    public class BenhAnDieuTriBanNgayFunc
    {
        public static void WriteXml(MDB.MDBConnection MyConnection)
        {
            string sql =
                   @"select * from BenhAnDieuTriBanNgay a inner where rownum = 1";
            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
            MDB.MDBDataReader DataReader = Command.ExecuteReader();

            var DataTable = new DataTable { TableName = "BenhAnBong" };
            DataTable.Load(DataReader as IDataReader);
            DataTable.WriteXml("rptBenhAnDieuTriBanNgay.xml");
        }
        public static DataSet SelectDataSet(MDB.MDBConnection MyConnection, decimal MaQuanLy)
        {
            string sql = @"select  a.*, b.NgayRaVien 
                 from BenhAnDieuTriBanNgay a  left join thongtindieutri b on a.maquanly = b.maquanly 
                  where a.maquanly = " + MaQuanLy.ToString(System.Globalization.CultureInfo.InvariantCulture);
            MDB.MDBDataAdapter adt = new MDB.MDBDataAdapter(sql, MyConnection);
            var ds = new DataSet();
            adt.Fill(ds);
            
            return ds;
        }
        public static BenhAnDieuTriBanNgay Select(MDB.MDBConnection MyConnection, decimal MaQuanLy)
        {
            #region
            string sql =
                      @"select * 
                        from BenhAnDieuTriBanNgay a
                        where MaQuanLy = :MaQuanLy";
            #endregion
            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
            Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", MaQuanLy));
            MDB.MDBDataReader DataReader = Command.ExecuteReader();
            var value = new BenhAnDieuTriBanNgay();
            while (DataReader.Read())
            {
                value.MaQuanLy =  DataReader.GetDecimal("MaQuanLy");
                value.QuaTrinhBenhLy = DataReader["QuaTrinhBenhLy"].ToString();
                value.CacXetNghiemCanLamSangCanLam = DataReader["CacXetNghiemCanLamSangCanLam"].ToString();
                value.BenhChinh = DataReader["BenhChinh"].ToString();
                value.BenhKemTheo = DataReader["BenhKemTheo"].ToString();
                value.TienLuong = DataReader["TienLuong"].ToString();
                value.PhuongPhapDieuTri = DataReader["PhuongPhapDieuTri"].ToString();
                value.BacSyDieuTri = DataReader["BacSyDieuTri"].ToString();
                value.TruongKhoa = DataReader["TruongKhoa"].ToString();
                value.MaSoKyTen = DataReader["masokyten"].ToString();
                value.MaSoKyTen_KB = DataReader["masokyten_kb"].ToString();
                value.MaSoKyTen_TK = DataReader["masokyten_tk"].ToString();
            }
            return value;
        }
        public static bool InsertOrUpdate(MDB.MDBConnection MyConnection, BenhAnDieuTriBanNgay benhAnDieuTriBanNgay)
        {
            string sql =
                      @"select MaQuanLy 
                        from BenhAnDieuTriBanNgay
                        where MaQuanLy = :MaQuanLy";
            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
            Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", benhAnDieuTriBanNgay.MaQuanLy));
            MDB.MDBDataReader DataReader = Command.ExecuteReader();
            int rowCount = 0;
            while (DataReader.Read()) rowCount++;
            if (rowCount == 1) return Update(MyConnection, benhAnDieuTriBanNgay);
            sql = @"INSERT INTO BenhAnDieuTriBanNgay (MaQuanLy, QuaTrinhBenhLy, CacXetNghiemCanLamSangCanLam, BenhChinh, BenhKemTheo, TienLuong, PhuongPhapDieuTri, BacSyDieuTri, TruongKhoa) VALUES (:MaQuanLy, :QuaTrinhBenhLy, :CacXetNghiemCanLamSangCanLam, :BenhChinh, :BenhKemTheo, :TienLuong, :PhuongPhapDieuTri, :BacSyDieuTri, :TruongKhoa)";
            Command = new MDB.MDBCommand(sql, MyConnection);
            Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", benhAnDieuTriBanNgay.MaQuanLy));
            Command.Parameters.Add(new MDB.MDBParameter("QuaTrinhBenhLy", benhAnDieuTriBanNgay.QuaTrinhBenhLy));
            Command.Parameters.Add(new MDB.MDBParameter("CacXetNghiemCanLamSangCanLam", benhAnDieuTriBanNgay.CacXetNghiemCanLamSangCanLam));
            Command.Parameters.Add(new MDB.MDBParameter("BenhChinh", benhAnDieuTriBanNgay.BenhChinh));
            Command.Parameters.Add(new MDB.MDBParameter("BenhKemTheo", benhAnDieuTriBanNgay.BenhKemTheo));
            Command.Parameters.Add(new MDB.MDBParameter("TienLuong", benhAnDieuTriBanNgay.TienLuong));
            Command.Parameters.Add(new MDB.MDBParameter("PhuongPhapDieuTri", benhAnDieuTriBanNgay.PhuongPhapDieuTri));
            Command.Parameters.Add(new MDB.MDBParameter("BacSyDieuTri", benhAnDieuTriBanNgay.BacSyDieuTri));
            Command.Parameters.Add(new MDB.MDBParameter("TruongKhoa", benhAnDieuTriBanNgay.TruongKhoa));

            int n = Command.ExecuteNonQuery(); // C#
            return n > 0 ? true : false;
        }
        public static bool Update(MDB.MDBConnection MyConnection, BenhAnDieuTriBanNgay benhAnDieuTriBanNgay)
        {
            string sql = @"UPDATE BenhAnDieuTriBanNgay SET QuaTrinhBenhLy =:QuaTrinhBenhLy, CacXetNghiemCanLamSangCanLam =:CacXetNghiemCanLamSangCanLam, BenhChinh =:BenhChinh, BenhKemTheo =:BenhKemTheo, TienLuong =:TienLuong, PhuongPhapDieuTri=:PhuongPhapDieuTri, BacSyDieuTri=:BacSyDieuTri, TruongKhoa=:TruongKhoa WHERE MaQuanLy = :MaQuanLy";
            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
            Command.Parameters.Add(new MDB.MDBParameter("QuaTrinhBenhLy", benhAnDieuTriBanNgay.QuaTrinhBenhLy));
            Command.Parameters.Add(new MDB.MDBParameter("CacXetNghiemCanLamSangCanLam", benhAnDieuTriBanNgay.CacXetNghiemCanLamSangCanLam));
            Command.Parameters.Add(new MDB.MDBParameter("BenhChinh", benhAnDieuTriBanNgay.BenhChinh));
            Command.Parameters.Add(new MDB.MDBParameter("BenhKemTheo", benhAnDieuTriBanNgay.BenhKemTheo));
            Command.Parameters.Add(new MDB.MDBParameter("TienLuong", benhAnDieuTriBanNgay.TienLuong));
            Command.Parameters.Add(new MDB.MDBParameter("PhuongPhapDieuTri", benhAnDieuTriBanNgay.PhuongPhapDieuTri));
            Command.Parameters.Add(new MDB.MDBParameter("BacSyDieuTri", benhAnDieuTriBanNgay.BacSyDieuTri));
            Command.Parameters.Add(new MDB.MDBParameter("TruongKhoa", benhAnDieuTriBanNgay.TruongKhoa));
            Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", benhAnDieuTriBanNgay.MaQuanLy));

            int n = Command.ExecuteNonQuery(); // C#
            return n > 0 ? true : false;
        }
        public static bool Delete(MDB.MDBConnection MyConnection, BenhAnBong BenhAnBong)
        {
            string sql = @"DELETE FROM BenhAnDieuTriBanNgay 
                           WHERE MaQuanLy = :MaQuanLy";
            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
            Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", BenhAnBong.MaQuanLy));

            int n = Command.ExecuteNonQuery(); // C#
            return n > 0 ? true : false;
        }
    }
}
