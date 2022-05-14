using EMR.KyDienTu;
using Newtonsoft.Json;
using PMS.Access;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMR_MAIN.DATABASE.Other
{
    public class PhieuBanGiaoSangPhongHoiSuc : ThongTinKy
    {
        public PhieuBanGiaoSangPhongHoiSuc()
        {
            TableName = "PhieuBanGiaoSangPhongHoiSuc";
            TablePrimaryKeyName = "ID";
            IDMauPhieu = (int)DanhMucPhieu.PBGSPHS;
            TenMauPhieu = DanhMucPhieu.PBGSPHS.Description();
        }
        [MoTaDuLieu("Mã định danh")]
		public long ID { get; set; }
        [MoTaDuLieu("Mã quản lý: mã duy nhất trong 1 đợt khám chữa bệnh (kcb), không trùng giữa các đợt kcb khác nhau","",1)]
		public decimal MaQuanLy { get; set; }
        public bool[] TriGiaArr { get; } = new bool[] { false, false, false };
        public string TriGia
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < TriGiaArr.Length; i++)
                    temp += (TriGiaArr[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        TriGiaArr[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }

        public int? Mach { get; set; }
        public DateTime? GioBanGiaoBenh { get; set; }
        [MoTaDuLieu("Huyết áp")]
		public string HuyetAp { get; set; }

        [MoTaDuLieu("Huyết áp")]
		public string HA { get; set; }
        public int? NhipTho { get; set; }

        public bool[] NQKArr { get; } = new bool[] { false, false, false };
        public string NQK
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < NQKArr.Length; i++)
                    temp += (NQKArr[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        NQKArr[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }

        public string TeVung { get; set; }
        public string DichMauBanGiao { get; set; }
        public int? SoLuongPhimXQuangCT { get; set; }
        public string NhungVanDeCanLuuY { get; set; }

        public string BacSiGayMe { get; set; }
        public string MaBacSiGayMe { get; set; }        
        public string BacSiNhanBenh { get; set; }
        public string MaBacSiNhanBenh { get; set; }
     
        [MoTaDuLieu("Ngày tạo", null, 0, 0)]
		public DateTime NgayTao { get; set; }
        [MoTaDuLieu("Người tạo", null, 0, 0)]
		public string NguoiTao { get; set; }
        [MoTaDuLieu("Ngày sửa", null, 0, 0)]
		public DateTime NgaySua { get; set; }
        [MoTaDuLieu("Người sửa", null, 0, 0)]
		public string NguoiSua { get; set; }
        [MoTaDuLieu("Đã ký", null, 0, 0)]
		public bool DaKy { get; set; }
        [MoTaDuLieu("Chọn", null, 0, 0)]
		public bool Chon { get; set; }


    }
  
    public class PhieuBanGiaoSangPhongHoiSucFunc
    {
        public const string TableName = "PhieuBanGiaoSangPhongHoiSuc";
        public const string TablePrimaryKeyName = "ID";
        public static List<PhieuBanGiaoSangPhongHoiSuc> GetListData(MDB.MDBConnection _OracleConnection, decimal maquanly)
        {
            List<PhieuBanGiaoSangPhongHoiSuc> list = new List<PhieuBanGiaoSangPhongHoiSuc>();
            try
            {
                string sql = @"SELECT * FROM PhieuBanGiaoSangPhongHoiSuc where MaQuanLy = :MaQuanLy";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, _OracleConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", maquanly));
                MDB.MDBDataReader DataReader = Command.ExecuteReader();
                while (DataReader.Read())
                {
                    PhieuBanGiaoSangPhongHoiSuc data = new PhieuBanGiaoSangPhongHoiSuc();
                    data.ID = Convert.ToInt64(DataReader.GetLong("ID").ToString());
                    data.MaQuanLy = maquanly;

                    data.TriGia = DataReader["TriGia"].ToString();
                    int tempInt = 0;
                    data.Mach = int.TryParse(DataReader["Mach"].ToString(), out tempInt) ? (int?) tempInt : null;
                    data.HuyetAp = DataReader["HuyetAp"].ToString();
                    data.NhipTho = int.TryParse(DataReader["NhipTho"].ToString(), out tempInt) ? (int?)tempInt : null;
                    data.NQK = DataReader["NQK"].ToString();
                    data.TeVung = DataReader["TeVung"].ToString();
                    data.DichMauBanGiao = DataReader["DichMauBanGiao"].ToString();
                    data.SoLuongPhimXQuangCT = int.TryParse(DataReader["SoLuongPhimXQuangCT"].ToString(), out tempInt) ? (int?)tempInt : null;
                    data.NhungVanDeCanLuuY = DataReader["NhungVanDeCanLuuY"].ToString();

                    data.GioBanGiaoBenh = Convert.ToDateTime(DataReader["GioBanGiaoBenh"] == DBNull.Value ? DateTime.Now : DataReader["GioBanGiaoBenh"]);

                    data.BacSiNhanBenh = DataReader["BacSiNhanBenh"].ToString();
                    data.MaBacSiNhanBenh = DataReader["MaBacSiNhanBenh"].ToString();

                    data.BacSiGayMe = DataReader["BacSiGayMe"].ToString();
                    data.MaBacSiGayMe = DataReader["MaBacSiGayMe"].ToString();

                    data.NgayTao = Convert.ToDateTime(DataReader["NgayTao"] == DBNull.Value ? DateTime.Now : DataReader["NgayTao"]);
                    data.NguoiTao = DataReader["NguoiTao"].ToString();
                    data.NgaySua = Convert.ToDateTime(DataReader["NgaySua"] == DBNull.Value ? DateTime.Now : DataReader["NgaySua"]);
                    data.NguoiSua = DataReader["NguoiSua"].ToString();

                    data.MaSoKy = DataReader["masokyten"].ToString();
                    data.DaKy = !string.IsNullOrEmpty(data.MaSoKy) ? true : false;
                    list.Add(data);
                }
            }
            catch (Exception ex) { XuLyLoi.Handle(ex); }
            return list;
        }
        public static bool InsertOrUpdate(MDB.MDBConnection MyConnection, ref PhieuBanGiaoSangPhongHoiSuc ketQua)
        {
            try
            {
                string sql = @"INSERT INTO PhieuBanGiaoSangPhongHoiSuc
                (
                    MaQuanLy,
                    TriGia,
                    Mach,
                    GioBanGiaoBenh,
                    HuyetAp,
                    NhipTho,
                    NQK,
                    TeVung,
                    DichMauBanGiao,
                    SoLuongPhimXQuangCT,
                    NhungVanDeCanLuuY,
                    BacSiGayMe,
                    MaBacSiGayMe,
                    BacSiNhanBenh,
                    MaBacSiNhanBenh,
                    NGUOITAO,
                    NGUOISUA,
                    NGAYTAO,
                    NGAYSUA)  VALUES
                 (
				    :MaQuanLy,

                    :TriGia,
                    :Mach,
                    :GioBanGiaoBenh,
                    :HuyetAp,
                    :NhipTho,
                    :NQK,
                    :TeVung,
                    :DichMauBanGiao,
                    :SoLuongPhimXQuangCT,
                    :NhungVanDeCanLuuY,
                    :BacSiGayMe,
                    :MaBacSiGayMe,
                    :BacSiNhanBenh,
                    :MaBacSiNhanBenh,

                    :NGUOITAO,
                    :NGUOISUA,
                    :NGAYTAO,
                    :NGAYSUA
                 )  RETURNING ID INTO :ID";
                if (ketQua.ID != 0)
                {
                    sql = @"UPDATE PhieuBanGiaoSangPhongHoiSuc SET 
                    MaQuanLy = :MaQuanLy,
                    TriGia = :TriGia,
                    Mach = :Mach,
                    GioBanGiaoBenh = :GioBanGiaoBenh,
                    HuyetAp = :HuyetAp,
                    NhipTho = :NhipTho,
                    NQK = :NQK,
                    TeVung = :TeVung,
                    DichMauBanGiao = :DichMauBanGiao,
                    SoLuongPhimXQuangCT = :SoLuongPhimXQuangCT,
                    NhungVanDeCanLuuY = :NhungVanDeCanLuuY,
                    BacSiGayMe= :BacSiGayMe,
                    MaBacSiGayMe = :MaBacSiGayMe,
                    BacSiNhanBenh = :BacSiNhanBenh,
                    MaBacSiNhanBenh = :MaBacSiNhanBenh,

                    NGUOISUA = :NGUOISUA,
                    NGAYSUA = :NGAYSUA 
                     WHERE ID = " + ketQua.ID;
                }
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);

                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", ketQua.MaQuanLy));

                Command.Parameters.Add(new MDB.MDBParameter("TriGia", ketQua.TriGia));
                Command.Parameters.Add(new MDB.MDBParameter("Mach", ketQua.Mach));
                Command.Parameters.Add(new MDB.MDBParameter("GioBanGiaoBenh", ketQua.GioBanGiaoBenh));
                Command.Parameters.Add(new MDB.MDBParameter("HuyetAp", ketQua.HuyetAp));
                Command.Parameters.Add(new MDB.MDBParameter("NhipTho", ketQua.NhipTho));
                Command.Parameters.Add(new MDB.MDBParameter("NQK", ketQua.NQK));
                Command.Parameters.Add(new MDB.MDBParameter("TeVung", ketQua.TeVung));
                Command.Parameters.Add(new MDB.MDBParameter("DichMauBanGiao", ketQua.DichMauBanGiao));
                Command.Parameters.Add(new MDB.MDBParameter("SoLuongPhimXQuangCT", ketQua.SoLuongPhimXQuangCT));
                Command.Parameters.Add(new MDB.MDBParameter("NhungVanDeCanLuuY", ketQua.NhungVanDeCanLuuY));
                Command.Parameters.Add(new MDB.MDBParameter("BacSiGayMe", ketQua.BacSiGayMe));
                Command.Parameters.Add(new MDB.MDBParameter("MaBacSiGayMe", ketQua.MaBacSiGayMe));
                Command.Parameters.Add(new MDB.MDBParameter("BacSiNhanBenh", ketQua.BacSiNhanBenh));
                Command.Parameters.Add(new MDB.MDBParameter("MaBacSiNhanBenh", ketQua.MaBacSiNhanBenh));

                Command.Parameters.Add(new MDB.MDBParameter("NGUOISUA", ketQua.NguoiSua));
                Command.Parameters.Add(new MDB.MDBParameter("NGAYSUA", ketQua.NgaySua));
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
                XuLyLoi.Handle(ex);
            }
            return false;
        }
        public static bool delete(MDB.MDBConnection MyConnection, long id)
        {
            try
            {
                string sql = "DELETE FROM PhieuBanGiaoSangPhongHoiSuc WHERE ID = :ID";
                MDB.MDBCommand command = new MDB.MDBCommand(sql, MyConnection);
                command.Parameters.Add(new MDB.MDBParameter("ID", id));
                command.BindByName = true;
                int n = command.ExecuteNonQuery();
                return n > 0 ? true : false;
            }
            catch (Exception ex)
            {
                XuLyLoi.Handle(ex);
            }
            return false;
        }
        public static DataSet getDataSet(MDB.MDBConnection MyConnection, long id)
        {
            string sql = @"SELECT
                P.* 
            FROM
                PhieuBanGiaoSangPhongHoiSuc P
            WHERE
                ID = " + id;

            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
            MDB.MDBDataAdapter adt = new MDB.MDBDataAdapter(Command);
            var ds = new DataSet();

             adt.Fill(ds, "BM");

            return ds;
        }
    }
}
