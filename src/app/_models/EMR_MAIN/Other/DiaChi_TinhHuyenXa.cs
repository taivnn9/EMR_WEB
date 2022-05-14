using EMR.KyDienTu;
using MDB;
using NLog;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMR_MAIN.DATABASE.Other
{
    public class DiaChi_TinhHuyenXa
    {
        public int TinhID { get; set; }
        public string TinhName { get; set; }
        public int HuyenID { get; set; }
        public string HuyenName { get; set; }
        public int XaID { get; set; }
        public string XaName { get; set; }
        public string FullName
        {
            get
            {
                List<string> diachi = new List<string>();
                if (!string.IsNullOrEmpty(TinhName))
                {
                    diachi.Add(TinhName);
                }
                if (!string.IsNullOrEmpty(HuyenName))
                {
                    diachi.Add(HuyenName);
                }
                if (!string.IsNullOrEmpty(XaName))
                {
                    diachi.Add(XaName);
                }
                return string.Join(", ", diachi);
            }
        }
        public string Search { get; set; }
    }
    /* TAM COMMENT
    public class DiaChi_Tinh
    {
        [MoTaDuLieu("Mã định danh")]
		public int ID { get; set; }
        public string Name { get; set; }
        public string Search { get; set; }
    }
    public class DiaChi_Huyen
    {
        [MoTaDuLieu("Mã định danh")]
		public int ID { get; set; }
        public string Name { get; set; }
        public int TinhID { get; set; }
        public string Search { get; set; }
    }
    public class DiaChi_Xa
    {
        [MoTaDuLieu("Mã định danh")]
		public int ID { get; set; }
        public string Name { get; set; }
        public int HuyenID { get; set; }
        public string Search { get; set; }
    }*/
    public class DiaChi_TinhHuyenXaFunc
    {
        static Logger log = LogManager.GetLogger("Log");
        public static List<DiaChi_TinhHuyenXa> ListDiaChiTinhHuyenXa = new List<DiaChi_TinhHuyenXa>();
        public static List<DiaChi_TinhHuyenXa> GetTinhHuyenXa(MDB.MDBConnection MyConnection)
        {

            log.LogConfig();
            log.Info("DiaChi_TinhHuyenXaFunc - Start - GetTinhHuyenXa");
            if (ListDiaChiTinhHuyenXa.Count == 0)
            { 

                try
                {
                    log.Info("DiaChi_TinhHuyenXaFunc - Start - GetTinhHuyenXa - GetTinh");
                    ListDiaChiTinhHuyenXa.AddRange(GetTinh(MyConnection));
                    log.Info("DiaChi_TinhHuyenXaFunc - End - GetTinhHuyenXa - GetTinh");

                    log.Info("DiaChi_TinhHuyenXaFunc - Start - GetTinhHuyenXa - GetHuyen");
                    ListDiaChiTinhHuyenXa.AddRange(GetHuyen(MyConnection));
                    log.Info("DiaChi_TinhHuyenXaFunc - End - GetTinhHuyenXa - GetHuyen");

                    log.Info("DiaChi_TinhHuyenXaFunc - Start - GetTinhHuyenXa - GetXa");
                    ListDiaChiTinhHuyenXa.AddRange(GetXa(MyConnection));
                    log.Info("DiaChi_TinhHuyenXaFunc - End - GetTinhHuyenXa - GetXa");
                }
                catch (Exception ex) { XuLyLoi.Handle(ex); }
                log.Info("DiaChi_TinhHuyenXaFunc - End - GetTinhHuyenXa");
            }
            return ListDiaChiTinhHuyenXa;
        }
        public static List<DiaChi_TinhHuyenXa> GetTinh(MDB.MDBConnection MyConnection)
        {
            List<DiaChi_TinhHuyenXa> list = new List<DiaChi_TinhHuyenXa>();
            try
            {
                string sql = @"SELECT * FROM DC_TINH";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
                MDB.MDBDataReader DataReader = Command.ExecuteReader();
                while (DataReader.Read())
                {
                    try
                    {
                        DiaChi_TinhHuyenXa data = new DiaChi_TinhHuyenXa();
                        data.TinhID = DataReader.GetInt("ID");
                        data.TinhName = DataReader["TINH_NAME"].ToString();
                        data.Search = DataReader["TINH_SEARCH"].ToString();
                        list.Add(data);
                    }
                    catch { }
                }
            }
            catch (Exception ex) { XuLyLoi.Handle(ex); }
            return list;
        }
        private static List<DiaChi_TinhHuyenXa> GetHuyen(MDB.MDBConnection MyConnection)
        {
            List<DiaChi_TinhHuyenXa> list = new List<DiaChi_TinhHuyenXa>();
            try
            {
                string sql = "SELECT h.ID, h.HUYEN_NAME, h.HUYEN_SEARCH, h.TINH_ID, t.TINH_NAME, t.TINH_SEARCH"
                             + " FROM DC_HUYEN h"
                             + " JOIN DC_TINH t ON h.TINH_ID = t.ID";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
                MDB.MDBDataReader DataReader = Command.ExecuteReader();
                while (DataReader.Read())
                {
                    try
                    {
                        DiaChi_TinhHuyenXa data = new DiaChi_TinhHuyenXa();
                        data.TinhID = DataReader.GetInt("TINH_ID");
                        data.TinhName = DataReader["TINH_NAME"].ToString();
                        data.HuyenID = DataReader.GetInt("ID");
                        data.HuyenName = DataReader["HUYEN_NAME"].ToString();
                        data.Search = DataReader["TINH_SEARCH"].ToString() + DataReader["HUYEN_SEARCH"].ToString();
                        list.Add(data);
                    }
                    catch { }
                }
            }
            catch (Exception ex) { XuLyLoi.Handle(ex); }
            return list;
        }
        public static List<DiaChi_TinhHuyenXa> GetHuyen(MDB.MDBConnection MyConnection, int tinhID)
        {
            List<DiaChi_TinhHuyenXa> list = new List<DiaChi_TinhHuyenXa>();
            try
            {
                string sql = "SELECT h.ID, h.HUYEN_NAME, h.HUYEN_SEARCH, h.TINH_ID, t.TINH_NAME, t.TINH_SEARCH"
                             + " FROM DC_HUYEN h"
                             + " JOIN DC_TINH t ON h.TINH_ID = t.ID where h.TINH_ID = " + tinhID;
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
                MDB.MDBDataReader DataReader = Command.ExecuteReader();
                while (DataReader.Read())
                {
                    try
                    {
                        DiaChi_TinhHuyenXa data = new DiaChi_TinhHuyenXa();
                        data.TinhID = DataReader.GetInt("TINH_ID");
                        data.TinhName = DataReader["TINH_NAME"].ToString();
                        data.HuyenID = DataReader.GetInt("ID");
                        data.HuyenName = DataReader["HUYEN_NAME"].ToString();
                        data.Search = DataReader["TINH_SEARCH"].ToString() + DataReader["HUYEN_SEARCH"].ToString();
                        list.Add(data);
                    }
                    catch { }
                }
            }
            catch (Exception ex) { XuLyLoi.Handle(ex); }
            return list;
        }
        private static List<DiaChi_TinhHuyenXa> GetXa(MDB.MDBConnection MyConnection)
        {

            List<DiaChi_TinhHuyenXa> list = new List<DiaChi_TinhHuyenXa>();
            try
            {
                string sql = "SELECT x.ID, x.XA_NAME, x.XA_SEARCH, x.HUYEN_ID, h.HUYEN_NAME, h.HUYEN_SEARCH, h.TINH_ID, t.TINH_NAME, t.TINH_SEARCH"
                            + " FROM DC_XA x"
                            + " JOIN DC_HUYEN h ON x.HUYEN_ID = h.ID"
                            + " JOIN DC_TINH t ON h.TINH_ID = t.ID";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
                MDB.MDBDataReader DataReader = Command.ExecuteReader();
                while (DataReader.Read())
                {
                    try
                    {
                        DiaChi_TinhHuyenXa data = new DiaChi_TinhHuyenXa();
                        data.TinhID = DataReader.GetInt("TINH_ID");
                        data.TinhName = DataReader["TINH_NAME"].ToString();
                        data.HuyenID = DataReader.GetInt("ID");
                        data.HuyenName = DataReader["HUYEN_NAME"].ToString();
                        data.XaID = DataReader.GetInt("ID");
                        data.XaName = DataReader["XA_NAME"].ToString();
                        data.Search = DataReader["TINH_SEARCH"].ToString() + DataReader["HUYEN_SEARCH"].ToString() + DataReader["XA_SEARCH"].ToString();
                        list.Add(data);
                    }
                    catch { }
                }
            }
            catch (Exception ex) { XuLyLoi.Handle(ex); }
            return list;
        }
        public static List<DiaChi_TinhHuyenXa> GetXa(MDB.MDBConnection MyConnection, int huyenID)
        {

            List<DiaChi_TinhHuyenXa> list = new List<DiaChi_TinhHuyenXa>();
            try
            {
                string sql = "SELECT x.ID, x.XA_NAME, x.XA_SEARCH, x.HUYEN_ID, h.HUYEN_NAME, h.HUYEN_SEARCH, h.TINH_ID, t.TINH_NAME, t.TINH_SEARCH"
                            + " FROM DC_XA x"
                            + " JOIN DC_HUYEN h ON x.HUYEN_ID = h.ID"
                            + " JOIN DC_TINH t ON h.TINH_ID = t.ID where x.HUYEN_ID = "+ huyenID;
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
                MDB.MDBDataReader DataReader = Command.ExecuteReader();
                while (DataReader.Read())
                {
                    try
                    {
                        DiaChi_TinhHuyenXa data = new DiaChi_TinhHuyenXa();
                        data.TinhID = DataReader.GetInt("TINH_ID");
                        data.TinhName = DataReader["TINH_NAME"].ToString();
                        data.HuyenID = DataReader.GetInt("ID");
                        data.HuyenName = DataReader["HUYEN_NAME"].ToString();
                        data.XaID = DataReader.GetInt("ID");
                        data.XaName = DataReader["XA_NAME"].ToString();
                        data.Search = DataReader["TINH_SEARCH"].ToString() + DataReader["HUYEN_SEARCH"].ToString() + DataReader["XA_SEARCH"].ToString();
                        list.Add(data);
                    }
                    catch { }
                }
            }
            catch (Exception ex) { XuLyLoi.Handle(ex); }
            return list;
        }
    }
}
