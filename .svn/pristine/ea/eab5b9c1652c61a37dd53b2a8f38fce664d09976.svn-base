using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace EMR_MAIN
{
    public class NhanVien_Khoa
    {
        public decimal Id_NhanVien_Khoa { get; set; }
        public decimal IdNhanVien { get; set; }
        public decimal IdKhoa { get; set; }

        public static bool InsertListNhanVienKhoa(MDB.MDBConnection Connection, List<NhanVien_Khoa> ListNhanVien_Khoa)
        {
            int n = 0;
            try
            {
                string sql = "";
                var ListIdNhanVien = ListNhanVien_Khoa.GroupBy(g => g.IdNhanVien).Select(s => s.Key).ToList();
                foreach (var IdNhanVien in ListIdNhanVien)
                {
                    sql = @"delete from NhanVien_Khoa where IdNhanVien = :IdNhanVien";
                    MDB.MDBCommand Command = new MDB.MDBCommand(sql, Connection);
                    Command.Parameters.Add("IdNhanVien",IdNhanVien);
                    Command.ExecuteNonQuery();
                }

                foreach (NhanVien_Khoa nhanvien_khoa in ListNhanVien_Khoa)
                {
                    sql = @"insert into NhanVien_Khoa(IdNhanVien, IdKhoa) values(:IdNhanVien, :IdKhoa)";
                    MDB.MDBCommand Command = new MDB.MDBCommand(sql,Connection);
                    Command.Parameters.Add("IdNhanVien", nhanvien_khoa.IdNhanVien);
                    Command.Parameters.Add("IdKhoa", nhanvien_khoa.IdKhoa);
                    n = Command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                XuLyLoi.Handle(ex);
            }
            return n > 0 ? true : false;
        }

        public static void InsertOrUpdateNhanVienKhoa(MDB.MDBConnection Connection, NhanVien_Khoa NhanVien_Khoa)
        {
            try
            {
                string sql =
                      @"select IdNhanVien 
                        from NhanVien_Khoa
                        where IdNhanVien = :IdNhanVien";

                MDB.MDBCommand Command = new MDB.MDBCommand(sql, Connection);
                Command.Parameters.Add("IdNhanVien", NhanVien_Khoa.IdNhanVien);
                MDB.MDBDataReader DataReader = Command.ExecuteReader();
                int rowCount = 0;
                while (DataReader.Read()) rowCount++;
                if (rowCount > 0) //UpdateNhanVien_Khoa(Connection, NhanVien_Khoa);
                {
                    sql = @"UPDATE NhanVien_Khoa SET 
                        IdKhoa = :IdKhoa
                        WHERE IdNhanVien = :IdNhanVien";
                }
                else
                {
                    sql = @"
                INSERT INTO NhanVien_Khoa (IdNhanVien, IdKhoa)
                VALUES(:IdNhanVien, :IdKhoa)
                ";
                }
                Command = new MDB.MDBCommand(sql, Connection);
                Command.Parameters.Add("IdNhanVien", NhanVien_Khoa.IdNhanVien);
                Command.Parameters.Add("IdKhoa", NhanVien_Khoa.IdKhoa);

                int n = Command.ExecuteNonQuery(); // C#
            }
            catch (Exception ex)
            {
                XuLyLoi.Handle(ex);
            }
        }
    }
}
