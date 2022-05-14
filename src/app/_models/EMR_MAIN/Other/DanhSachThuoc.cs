using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EMR.KyDienTu;

namespace EMR_MAIN.DATABASE.Other
{
    public class DanhSachThuoc
    {
        [MoTaDuLieu("Mã định danh")]
		public long ID { get; set; }
        public string MaLoaiThuoc { get; set; }
        public string TenLoaiThuoc { get; set; }
    }
    public class DanhSachThuocFunc
    {
        public static List<DanhSachThuoc> GetDanhSachThuoc(MDB.MDBConnection _OracleConnection)
        {
            List<DanhSachThuoc> list = new List<DanhSachThuoc>();
            try
            {
                string sql = @"SELECT * FROM DANHSACHTHUOC";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, _OracleConnection);
                MDB.MDBDataReader DataReader = Command.ExecuteReader();
                while (DataReader.Read())
                {
                    DanhSachThuoc data = new DanhSachThuoc();
                    data.ID = Convert.ToInt64(DataReader.GetLong("ID").ToString());
                    data.MaLoaiThuoc = DataReader["MaLoaiThuoc"].ToString();
                    data.TenLoaiThuoc = DataReader["TenLoaiThuoc"].ToString();
                    
                    list.Add(data);
                }
            }
            catch (Exception ex) { XuLyLoi.Handle(ex); }
            return list;
        }
    }
}
