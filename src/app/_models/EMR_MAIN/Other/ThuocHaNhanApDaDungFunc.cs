
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using EMR.KyDienTu;

namespace EMR_MAIN
{
    public class ThuocHaNhanApDaDung
    {
        [MoTaDuLieu("Mã định danh")]
		public int IDThuocHaNhanApDaDung { get; set; }
        public string Mat { get; set; }
        public string TenThuoc { get; set; }
        public string LieuDung { get; set; }
        public string ThoiGianDaDung { get; set; }
    }
    public class ThuocHaNhanApDaDungFunc
    {
        public static List<ThuocHaNhanApDaDung> ListThuocHaNhanApDaDung { get; private set; }

        public static List<ThuocHaNhanApDaDung> GetListThuocHaNhanApDaDung(MDB.MDBConnection MyConnection, decimal MaQuanLy)
        {
            #region
            string sql =
                      @"   select a.*,c.hovaten BacSyPhauThuatHoVaTen, d.hovaten BacSyGayMeHoVaTen
            from ThuocHaNhanApDaDung a
                  left join nhanvien c on a.bacsyphauthuat  = c.manhanvien
                  left join nhanvien d on a.bacsygayme= d.manhanvien
                  where a.maquanly = '" + MaQuanLy + "'";

            #endregion
            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
            MDB.MDBDataReader DataReader = Command.ExecuteReader();
            ListThuocHaNhanApDaDung = new List<ThuocHaNhanApDaDung>();
            while (DataReader.Read())
            {
                ListThuocHaNhanApDaDung.Add(new ThuocHaNhanApDaDung
                {
                    IDThuocHaNhanApDaDung = int.Parse(DataReader["IDThuocHaNhanApDaDung"].ToString()),
                    Mat = DataReader["Mat"].ToString(),
                    TenThuoc = DataReader["TenThuoc"].ToString(),
                    LieuDung = DataReader["LieuDung"].ToString(),
                    ThoiGianDaDung = DataReader["ThoiGianDaDung"].ToString(),
                });
            }
            return ListThuocHaNhanApDaDung;
        }

        public static ThuocHaNhanApDaDung Select(MDB.MDBConnection MyConnection, decimal IDThuocHaNhanApDaDung)
        {
            #region
            string sql =
                      @"select * 
                        from ThuocHaNhanApDaDung a
                        where IDThuocHaNhanApDaDung = :IDThuocHaNhanApDaDung";
            #endregion
            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
            Command.Parameters.Add(new MDB.MDBParameter("IDThuocHaNhanApDaDung", IDThuocHaNhanApDaDung));
            MDB.MDBDataReader DataReader = Command.ExecuteReader();
            ThuocHaNhanApDaDung ThuocHaNhanApDaDung = new ThuocHaNhanApDaDung();

            while (DataReader.Read())
            {
                ThuocHaNhanApDaDung.IDThuocHaNhanApDaDung = int.Parse(DataReader["IDPhauThuThuThuat"].ToString());
                ThuocHaNhanApDaDung.Mat = DataReader["Mat"].ToString();
                ThuocHaNhanApDaDung.TenThuoc = DataReader["TenThuoc"].ToString();
                ThuocHaNhanApDaDung.LieuDung = DataReader["LieuDung"].ToString();
                ThuocHaNhanApDaDung.ThoiGianDaDung = DataReader["ThoiGianDaDung"].ToString();
            }
            return ThuocHaNhanApDaDung;
        }

        public static bool Insert(MDB.MDBConnection MyConnection, ThuocHaNhanApDaDung ThuocHaNhanApDaDung)
        {
            string sql = @"
       INSERT INTO ThuocHaNhanApDaDung ( MaQuanLy, Mat, TenThuoc, LieuDung, ThoiGianDaDung)
 VALUES( :MaQuanLy, :Mat, :TenThuoc, :LieuDung, :ThoiGianDaDung)           ";
            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
            Command.Parameters.Add(new MDB.MDBParameter("Mat", ThuocHaNhanApDaDung.Mat));
            Command.Parameters.Add(new MDB.MDBParameter("TenThuoc", ThuocHaNhanApDaDung.TenThuoc));
            Command.Parameters.Add(new MDB.MDBParameter("LieuDung", ThuocHaNhanApDaDung.LieuDung));
            Command.Parameters.Add(new MDB.MDBParameter("ThoiGianDaDung", ThuocHaNhanApDaDung.ThoiGianDaDung));

            int n = Command.ExecuteNonQuery(); // C#
            return n > 0 ? true : false;
        }
        public static bool Update(MDB.MDBConnection MyConnection, ThuocHaNhanApDaDung ThuocHaNhanApDaDung)
        {
            string sql = @"UPDATE ThuocHaNhanApDaDung SET 
Mat = :Mat,
TenThuoc = :TenThuoc,
LieuDung = :LieuDung,
ThoiGianDaDung = :ThoiGianDaDung

                        WHERE   IDThuocHaNhanApDaDung = :IDThuocHaNhanApDaDung";
            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
            Command.Parameters.Add(new MDB.MDBParameter("Mat", ThuocHaNhanApDaDung.Mat));
            Command.Parameters.Add(new MDB.MDBParameter("TenThuoc", ThuocHaNhanApDaDung.TenThuoc));
            Command.Parameters.Add(new MDB.MDBParameter("LieuDung", ThuocHaNhanApDaDung.LieuDung));
            Command.Parameters.Add(new MDB.MDBParameter("ThoiGianDaDung", ThuocHaNhanApDaDung.ThoiGianDaDung));

            Command.Parameters.Add(new MDB.MDBParameter("IDPhauThuThuThuat", ThuocHaNhanApDaDung.IDThuocHaNhanApDaDung));
            int n = Command.ExecuteNonQuery(); // C#
            return n > 0 ? true : false;
        }
        public static bool DeleteThuocHaNhanApDaDung(MDB.MDBConnection MyConnection, ThuocHaNhanApDaDung ThuocHaNhanApDaDung)
        {
            string sql = @"DELETE FROM ThuocHaNhanApDaDung 
                           WHERE IDThuocHaNhanApDaDung = :IDThuocHaNhanApDaDung";
            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
            Command.Parameters.Add(new MDB.MDBParameter("IDThuocHaNhanApDaDung", ThuocHaNhanApDaDung.IDThuocHaNhanApDaDung));

            int n = Command.ExecuteNonQuery(); // C#
            return n > 0 ? true : false;
        }
    }
}
