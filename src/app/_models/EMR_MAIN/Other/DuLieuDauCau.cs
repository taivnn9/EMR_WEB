using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EMR.KyDienTu;


namespace EMR_MAIN.DATABASE.Other
{
    public class DuLieuDauCau
    {
        [MoTaDuLieu("Mã định danh")]
		public int ID { get; set; }
        public string KyTu { get; set; }
        public string CachDoc { get; set; }
    }

    public class DuLieuDauCauFunc
    {
        public static List<DuLieuDauCau> GetData(MDB.MDBConnection MyConnection)
        {
            List<DuLieuDauCau> listData = new List<DuLieuDauCau>();
            string sql = @"select * from dulieudaucau";
            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
            MDB.MDBDataReader DataReader = Command.ExecuteReader();
            while (DataReader.Read())
            {
                listData.Add(new DuLieuDauCau {
                    ID = int.Parse(DataReader["ID"].ToString()),
                    KyTu = DataReader["KyTu"].ToString(),
                    CachDoc = DataReader["CachDoc"].ToString()
                });
            }
            return listData;
        }
    }

}
