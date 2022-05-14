
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMR_MAIN
{
    public class Khoa
    {
        public decimal IdKhoa { get; set; }
        public string MaKhoa { get; set; }
        public string TenKhoa { get; set; }
        public bool Active { get; set; }

        public static void InsertListKhoa(MDB.MDBConnection MyConnection, List<Khoa> ListKhoa)
        {
            foreach (Khoa Khoa in ListKhoa)
                InsertOrUpdateKhoa(MyConnection, Khoa);
        }

        public static void InsertOrUpdateKhoa(MDB.MDBConnection MyConnection, Khoa Khoa)
        {
            try
            {
                string sql = @"select makhoa from Khoa where IdKhoa = :IdKhoa";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
                Command.Parameters.Add(":IdKhoa", Khoa.IdKhoa);
                MDB.MDBDataReader DataReader = Command.ExecuteReader();
                int rowCount = 0;
                while (DataReader.Read()) rowCount++;
                if (rowCount == 1)
                {
                    sql = @"update Khoa set MaKhoa = :MaKhoa, TenKhoa = :TenKhoa, Active =:Active where IdKhoa = :IdKhoa";
                }
                else
                {
                    sql = @"insert into Khoa(MaKhoa, TenKhoa, IdKhoa, Active) values (:MaKhoa, :TenKhoa, :IdKhoa, :Active)";
                }
                Command = new MDB.MDBCommand(sql, MyConnection);
                Command.Parameters.Add("MaKhoa", Khoa.MaKhoa);
                Command.Parameters.Add("TenKhoa", Khoa.TenKhoa);
                Command.Parameters.Add("IdKhoa", Khoa.IdKhoa);
                Command.Parameters.Add("Active", Khoa.Active ? "1" : "0");

                int n = Command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                XuLyLoi.Handle(ex);
            }
        }

        public static List<Khoa> GetListKhoa(MDB.MDBConnection MyConnection)
        {
            #region
            string sql =
                      @"select * 
                        from Khoa a
                        ";
            #endregion
            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
            MDB.MDBDataReader DataReader = Command.ExecuteReader();
            List<Khoa> ListKhoa = new List<Khoa>();
            while (DataReader.Read())
            {
                ListKhoa.Add(new Khoa
                {
                    IdKhoa = Convert.ToDecimal(DataReader.GetDecimal("IdKhoa")),
                    MaKhoa = DataReader["MaKhoa"].ToString(),
                    TenKhoa = DataReader["TenKhoa"].ToString(),
                    Active = Common.ConDB_IntNull(DataReader["Active"]) == 1
                });
            }
            return ListKhoa;
        }
        public static bool DeleteKhoa(MDB.MDBConnection MyConnection, Khoa currentKhoa)
        {
            string sql = @"DELETE FROM Khoa 
                           WHERE IdKhoa = :IdKhoa";
            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
            Command.Parameters.Add("IdKhoa", currentKhoa.IdKhoa);
            int n = Command.ExecuteNonQuery(); // C#
            return n > 0;
        }
    }

}
