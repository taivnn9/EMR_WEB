
using EMR.KyDienTu;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using PMS.Access; 

namespace EMR_MAIN.DATABASE.Other
{
    public class PhieuTheoDoiBenhNhanCovid : ThongTinKy
    {
        public PhieuTheoDoiBenhNhanCovid()
        {
            TableName = "PhieuTheoDoiBenhNhanCovid";
            TablePrimaryKeyName = "ID";
            IDMauPhieu = (int)DanhMucPhieu.PTDBNC;
            TenMauPhieu = DanhMucPhieu.PTDBNC.Description();
        }
        [MoTaDuLieu("Mã định danh")]
		public long ID { get; set; }
        [MoTaDuLieu("Mã quản lý: mã duy nhất trong 1 đợt khám chữa bệnh (kcb), không trùng giữa các đợt kcb khác nhau","",1)]
		public decimal MaQuanLy { get; set; }

        public ObservableCollection<PhanLoaiMucDo> ListPhanLoai { get; set; }

        public DateTime? QuickCovidNgay1 { get; set; }
        public DateTime? QuickCovidNgay2 { get; set; }
        public DateTime? QuickCovidNgay3 { get; set; }
        public DateTime? QuickCovidNgay4 { get; set; }
        public string TanSoThoNgay1_S { get; set; }
        public string TanSoThoNgay1_C { get; set; }
        public string TanSoThoNgay2_S { get; set; }
        public string TanSoThoNgay2_C { get; set; }
        public string TanSoThoNgay3_S { get; set; }
        public string TanSoThoNgay3_C { get; set; }
        public string TanSoThoNgay4_S { get; set; }
        public string TanSoThoNgay4_C { get; set; }
        public string Spo2Ngay1_S { get; set; }
        public string Spo2Ngay1_C { get; set; }
        public string Spo2Ngay2_S { get; set; }
        public string Spo2Ngay2_C { get; set; }
        public string Spo2Ngay3_S { get; set; }
        public string Spo2Ngay3_C { get; set; }
        public string Spo2Ngay4_S { get; set; }
        public string Spo2Ngay4_C { get; set; }
        public string OxiNgay1_S { get; set; }
        public string OxiNgay1_C { get; set; }
        public string OxiNgay2_S { get; set; }
        public string OxiNgay2_C { get; set; }
        public string OxiNgay3_S { get; set; }
        public string OxiNgay3_C { get; set; }
        public string OxiNgay4_S { get; set; }
        public string OxiNgay4_C { get; set; }
        public string TongDiemNgay1_S { get; set; }
        public string TongDiemNgay1_C { get; set; }
        public string TongDiemNgay2_S { get; set; }
        public string TongDiemNgay2_C { get; set; }
        public string TongDiemNgay3_S { get; set; }
        public string TongDiemNgay3_C { get; set; }
        public string TongDiemNgay4_S { get; set; }
        public string TongDiemNgay4_C { get; set; }
        public DateTime? ChiSoRoxNgay1 { get; set; }
        public DateTime? ChiSoRoxNgay2 { get; set; }
        public DateTime? ChiSoRoxNgay3 { get; set; }
        public DateTime? ChiSoRoxNgay1_Gio1 { get; set; }
        public DateTime? ChiSoRoxNgay1_Gio2 { get; set; }
        public DateTime? ChiSoRoxNgay1_Gio3 { get; set; }
        public DateTime? ChiSoRoxNgay1_Gio4 { get; set; }
        public DateTime? ChiSoRoxNgay2_Gio1 { get; set; }
        public DateTime? ChiSoRoxNgay2_Gio2 { get; set; }
        public DateTime? ChiSoRoxNgay2_Gio3 { get; set; }
        public DateTime? ChiSoRoxNgay2_Gio4 { get; set; }
        public DateTime? ChiSoRoxNgay3_Gio1 { get; set; }
        public DateTime? ChiSoRoxNgay3_Gio2 { get; set; }
        public DateTime? ChiSoRoxNgay3_Gio3 { get; set; }
        public DateTime? ChiSoRoxNgay3_Gio4 { get; set; }
        public string ChiSoRoxNgay1_Text1 { get; set; }
        public string ChiSoRoxNgay1_Text2 { get; set; }
        public string ChiSoRoxNgay1_Text3 { get; set; }
        public string ChiSoRoxNgay1_Text4 { get; set; }
        public string ChiSoRoxNgay2_Text1 { get; set; }
        public string ChiSoRoxNgay2_Text2 { get; set; }
        public string ChiSoRoxNgay2_Text3 { get; set; }
        public string ChiSoRoxNgay2_Text4 { get; set; }
        public string ChiSoRoxNgay3_Text1 { get; set; }
        public string ChiSoRoxNgay3_Text2 { get; set; }
        public string ChiSoRoxNgay3_Text3 { get; set; }
        public string ChiSoRoxNgay3_Text4 { get; set; }

        [MoTaDuLieu("Người tạo", null, 0, 0)]
		public string NguoiTao { get; set; }
        [MoTaDuLieu("Người sửa", null, 0, 0)]
		public string NguoiSua { get; set; }
        [MoTaDuLieu("Ngày tạo", null, 0, 0)]
		public DateTime NgayTao { get; set; }
        [MoTaDuLieu("Ngày sửa", null, 0, 0)]
		public DateTime NgaySua { get; set; }
        [MoTaDuLieu("Chọn", null, 0, 0)]
		public bool Chon { get; set; }
        //public string MaSoKyTen { get; set; }
        [MoTaDuLieu("Đã ký", null, 0, 0)]
		public bool DaKy { get; set; }
    }

    public class PhanLoaiMucDo
    {
        public string MucDo { get; set; }
        public DateTime? NgayPhanLoai { get; set; }
       

    }
    public class PhieuTheoDoiBenhNhanCovidFunc
    {
        public const string TableName = "PhieuTheoDoiBenhNhanCovid";
        public const string TablePrimaryKeyName = "ID";

        public static List<PhieuTheoDoiBenhNhanCovid> GetListData(MDB.MDBConnection _OracleConnection, decimal maquanly)
        {
            List<PhieuTheoDoiBenhNhanCovid> list = new List<PhieuTheoDoiBenhNhanCovid>();
            try
            {
                string sql = @"SELECT * FROM PhieuTheoDoiBenhNhanCovid where MaQuanLy = :MaQuanLy";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, _OracleConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", maquanly));
                MDB.MDBDataReader DataReader = Command.ExecuteReader();
                while (DataReader.Read())
                {
                    PhieuTheoDoiBenhNhanCovid data = new PhieuTheoDoiBenhNhanCovid();
                    data.ID = Convert.ToInt64(DataReader.GetLong("ID").ToString());
                    data.MaQuanLy = maquanly;

                    data.ListPhanLoai = JsonConvert.DeserializeObject<ObservableCollection<PhanLoaiMucDo>>(DataReader["ListPhanLoai"].ToString());
                    data.QuickCovidNgay1 = Convert.ToDateTime(DataReader["QuickCovidNgay1"] == DBNull.Value ? DateTime.Now : DataReader["QuickCovidNgay1"]);
                    data.QuickCovidNgay2 = Convert.ToDateTime(DataReader["QuickCovidNgay2"] == DBNull.Value ? DateTime.Now : DataReader["QuickCovidNgay2"]);
                    data.QuickCovidNgay3 = Convert.ToDateTime(DataReader["QuickCovidNgay3"] == DBNull.Value ? DateTime.Now : DataReader["QuickCovidNgay3"]);
                    data.QuickCovidNgay4 = Convert.ToDateTime(DataReader["QuickCovidNgay4"] == DBNull.Value ? DateTime.Now : DataReader["QuickCovidNgay4"]);

                    data.TanSoThoNgay1_S = DataReader["TanSoThoNgay1_S"].ToString();
                    data.TanSoThoNgay1_C = DataReader["TanSoThoNgay1_C"].ToString();
                    data.TanSoThoNgay2_S = DataReader["TanSoThoNgay2_S"].ToString();
                    data.TanSoThoNgay2_C = DataReader["TanSoThoNgay2_C"].ToString();
                    data.TanSoThoNgay3_S = DataReader["TanSoThoNgay3_S"].ToString();
                    data.TanSoThoNgay3_C = DataReader["TanSoThoNgay3_C"].ToString();
                    data.TanSoThoNgay4_S = DataReader["TanSoThoNgay4_S"].ToString();
                    data.TanSoThoNgay4_C = DataReader["TanSoThoNgay4_C"].ToString();

                    data.Spo2Ngay1_S = DataReader["Spo2Ngay1_S"].ToString();
                    data.Spo2Ngay1_C = DataReader["Spo2Ngay1_C"].ToString();
                    data.Spo2Ngay2_S = DataReader["Spo2Ngay2_S"].ToString();
                    data.Spo2Ngay2_C = DataReader["Spo2Ngay2_C"].ToString();
                    data.Spo2Ngay3_S = DataReader["Spo2Ngay3_S"].ToString();
                    data.Spo2Ngay3_C = DataReader["Spo2Ngay3_C"].ToString();
                    data.Spo2Ngay4_S = DataReader["Spo2Ngay4_S"].ToString();
                    data.Spo2Ngay4_C = DataReader["Spo2Ngay4_C"].ToString();

                    data.OxiNgay1_S = DataReader["OxiNgay1_S"].ToString();
                    data.OxiNgay1_C = DataReader["OxiNgay1_C"].ToString();
                    data.OxiNgay2_S = DataReader["OxiNgay2_S"].ToString();
                    data.OxiNgay2_C = DataReader["OxiNgay2_C"].ToString();
                    data.OxiNgay3_S = DataReader["OxiNgay3_S"].ToString();
                    data.OxiNgay3_C = DataReader["OxiNgay3_C"].ToString();
                    data.OxiNgay4_S = DataReader["OxiNgay4_S"].ToString();
                    data.OxiNgay4_C = DataReader["OxiNgay4_C"].ToString();

                    data.TongDiemNgay1_S = DataReader["TongDiemNgay1_S"].ToString();
                    data.TongDiemNgay1_C = DataReader["TongDiemNgay1_C"].ToString();
                    data.TongDiemNgay2_S = DataReader["TongDiemNgay2_S"].ToString();
                    data.TongDiemNgay2_C = DataReader["TongDiemNgay2_C"].ToString();
                    data.TongDiemNgay3_S = DataReader["TongDiemNgay3_S"].ToString();
                    data.TongDiemNgay3_C = DataReader["TongDiemNgay3_C"].ToString();
                    data.TongDiemNgay4_S = DataReader["TongDiemNgay4_S"].ToString();
                    data.TongDiemNgay4_C = DataReader["TongDiemNgay4_C"].ToString();

                    data.ChiSoRoxNgay1 = Convert.ToDateTime(DataReader["ChiSoRoxNgay1"] == DBNull.Value ? DateTime.Now : DataReader["ChiSoRoxNgay1"]);
                    data.ChiSoRoxNgay2 = Convert.ToDateTime(DataReader["ChiSoRoxNgay2"] == DBNull.Value ? DateTime.Now : DataReader["ChiSoRoxNgay2"]);
                    data.ChiSoRoxNgay3 = Convert.ToDateTime(DataReader["ChiSoRoxNgay3"] == DBNull.Value ? DateTime.Now : DataReader["ChiSoRoxNgay3"]);
                    data.ChiSoRoxNgay1_Gio1 = Convert.ToDateTime(DataReader["ChiSoRoxNgay1_Gio1"] == DBNull.Value ? DateTime.Now : DataReader["ChiSoRoxNgay1_Gio1"]);
                    data.ChiSoRoxNgay1_Gio2 = Convert.ToDateTime(DataReader["ChiSoRoxNgay1_Gio2"] == DBNull.Value ? DateTime.Now : DataReader["ChiSoRoxNgay1_Gio2"]);
                    data.ChiSoRoxNgay1_Gio3 = Convert.ToDateTime(DataReader["ChiSoRoxNgay1_Gio3"] == DBNull.Value ? DateTime.Now : DataReader["ChiSoRoxNgay1_Gio3"]);
                    data.ChiSoRoxNgay1_Gio4 = Convert.ToDateTime(DataReader["ChiSoRoxNgay1_Gio4"] == DBNull.Value ? DateTime.Now : DataReader["ChiSoRoxNgay1_Gio4"]);

                    data.ChiSoRoxNgay2_Gio1 = Convert.ToDateTime(DataReader["ChiSoRoxNgay2_Gio1"] == DBNull.Value ? DateTime.Now : DataReader["ChiSoRoxNgay2_Gio1"]);
                    data.ChiSoRoxNgay2_Gio2 = Convert.ToDateTime(DataReader["ChiSoRoxNgay2_Gio2"] == DBNull.Value ? DateTime.Now : DataReader["ChiSoRoxNgay2_Gio2"]);
                    data.ChiSoRoxNgay2_Gio3 = Convert.ToDateTime(DataReader["ChiSoRoxNgay2_Gio3"] == DBNull.Value ? DateTime.Now : DataReader["ChiSoRoxNgay2_Gio3"]);
                    data.ChiSoRoxNgay2_Gio4 = Convert.ToDateTime(DataReader["ChiSoRoxNgay2_Gio4"] == DBNull.Value ? DateTime.Now : DataReader["ChiSoRoxNgay2_Gio4"]);

                    data.ChiSoRoxNgay3_Gio1 = Convert.ToDateTime(DataReader["ChiSoRoxNgay3_Gio1"] == DBNull.Value ? DateTime.Now : DataReader["ChiSoRoxNgay3_Gio1"]);
                    data.ChiSoRoxNgay3_Gio2 = Convert.ToDateTime(DataReader["ChiSoRoxNgay3_Gio2"] == DBNull.Value ? DateTime.Now : DataReader["ChiSoRoxNgay3_Gio2"]);
                    data.ChiSoRoxNgay3_Gio3 = Convert.ToDateTime(DataReader["ChiSoRoxNgay3_Gio3"] == DBNull.Value ? DateTime.Now : DataReader["ChiSoRoxNgay3_Gio3"]);
                    data.ChiSoRoxNgay3_Gio4 = Convert.ToDateTime(DataReader["ChiSoRoxNgay3_Gio4"] == DBNull.Value ? DateTime.Now : DataReader["ChiSoRoxNgay3_Gio4"]);

                    data.ChiSoRoxNgay1_Text1 = DataReader["ChiSoRoxNgay1_Text1"].ToString();
                    data.ChiSoRoxNgay1_Text2 = DataReader["ChiSoRoxNgay1_Text2"].ToString();
                    data.ChiSoRoxNgay1_Text3 = DataReader["ChiSoRoxNgay1_Text3"].ToString();
                    data.ChiSoRoxNgay1_Text4 = DataReader["ChiSoRoxNgay1_Text4"].ToString();

                    data.ChiSoRoxNgay2_Text1 = DataReader["ChiSoRoxNgay2_Text1"].ToString();
                    data.ChiSoRoxNgay2_Text2 = DataReader["ChiSoRoxNgay2_Text2"].ToString();
                    data.ChiSoRoxNgay2_Text3 = DataReader["ChiSoRoxNgay2_Text3"].ToString();
                    data.ChiSoRoxNgay2_Text4 = DataReader["ChiSoRoxNgay2_Text4"].ToString();

                    data.ChiSoRoxNgay3_Text1 = DataReader["ChiSoRoxNgay3_Text1"].ToString();
                    data.ChiSoRoxNgay3_Text2 = DataReader["ChiSoRoxNgay3_Text2"].ToString();
                    data.ChiSoRoxNgay3_Text3 = DataReader["ChiSoRoxNgay3_Text3"].ToString();
                    data.ChiSoRoxNgay3_Text4 = DataReader["ChiSoRoxNgay3_Text4"].ToString();

                    data.NgayTao = Convert.ToDateTime(DataReader["NGAYTAO"] == DBNull.Value ? DateTime.Now : DataReader["NGAYTAO"]);
                    data.NguoiTao = DataReader["NGUOITAO"].ToString();
                    data.NgaySua = Convert.ToDateTime(DataReader["NGAYSUA"] == DBNull.Value ? DateTime.Now : DataReader["NGAYSUA"]);
                    data.NguoiSua = DataReader["NGUOISUA"].ToString();

                    data.MaSoKy = DataReader["masokyten"].ToString();
                    data.DaKy = !string.IsNullOrEmpty(data.MaSoKy) ? true : false;
                    list.Add(data);
                }
            }
            catch (Exception ex) { XuLyLoi.Handle(ex); }
            return list;
        }
        public static bool DeleteByIDPhieu(MDB.MDBConnection oracleConnection, decimal IDBienBan)
        {
            try
            {
                string sql = "";
                MDB.MDBCommand oracleCommand;
                sql = @"DELETE FROM PhieuTheoDoiBenhNhanCovid WHERE ID =" + IDBienBan;
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
        public static DataSet GetDataSet(MDB.MDBConnection MyConnection, long IDBienBan)
        {
            string sql = @"SELECT
                P.* 
            FROM
                PhieuTheoDoiBenhNhanCovid P
            WHERE
                ID = " + IDBienBan;

            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
            MDB.MDBDataAdapter adt = new MDB.MDBDataAdapter(Command);
            var ds = new DataSet();

            adt.Fill(ds, "TB");


            return ds;
        }
        public static bool InsertOrUpdate(MDB.MDBConnection MyConnection, ref PhieuTheoDoiBenhNhanCovid ketQua)
        {
            try
            {
                string sql = @"INSERT INTO PhieuTheoDoiBenhNhanCovid
                (
                    MaQuanLy,
                    ListPhanLoai,
                    QuickCovidNgay1,
                    QuickCovidNgay2,
                    QuickCovidNgay3,
                    QuickCovidNgay4,
                    TanSoThoNgay1_S,
                    TanSoThoNgay1_C,
                    TanSoThoNgay2_S,
                    TanSoThoNgay2_C,
                    TanSoThoNgay3_S,
                    TanSoThoNgay3_C,
                    TanSoThoNgay4_S,
                    TanSoThoNgay4_C,
                    Spo2Ngay1_S,
                    Spo2Ngay1_C,
                    Spo2Ngay2_S,
                    Spo2Ngay2_C,
                    Spo2Ngay3_S,
                    Spo2Ngay3_C,
                    Spo2Ngay4_S,
                    Spo2Ngay4_C,
                    OxiNgay1_S,
                    OxiNgay1_C,
                    OxiNgay2_S,
                    OxiNgay2_C,
                    OxiNgay3_S,
                    OxiNgay3_C,
                    OxiNgay4_S,
                    OxiNgay4_C,
                    TongDiemNgay1_S,
                    TongDiemNgay1_C,
                    TongDiemNgay2_S,
                    TongDiemNgay2_C,
                    TongDiemNgay3_S,
                    TongDiemNgay3_C,
                    TongDiemNgay4_S,
                    TongDiemNgay4_C,
                    ChiSoRoxNgay1,
                    ChiSoRoxNgay2,
                    ChiSoRoxNgay3,
                    ChiSoRoxNgay1_Gio1,
                    ChiSoRoxNgay1_Gio2,
                    ChiSoRoxNgay1_Gio3,
                    ChiSoRoxNgay1_Gio4,
                    ChiSoRoxNgay2_Gio1,
                    ChiSoRoxNgay2_Gio2,
                    ChiSoRoxNgay2_Gio3,
                    ChiSoRoxNgay2_Gio4,
                    ChiSoRoxNgay3_Gio1,
                    ChiSoRoxNgay3_Gio2,
                    ChiSoRoxNgay3_Gio3,
                    ChiSoRoxNgay3_Gio4,
                    ChiSoRoxNgay1_Text1,
                    ChiSoRoxNgay1_Text2,
                    ChiSoRoxNgay1_Text3,
                    ChiSoRoxNgay1_Text4,
                    ChiSoRoxNgay2_Text1,
                    ChiSoRoxNgay2_Text2,
                    ChiSoRoxNgay2_Text3,
                    ChiSoRoxNgay2_Text4,
                    ChiSoRoxNgay3_Text1,
                    ChiSoRoxNgay3_Text2,
                    ChiSoRoxNgay3_Text3,
                    ChiSoRoxNgay3_Text4,
                    NGUOITAO,
                    NGUOISUA,
                    NGAYTAO,
                    NGAYSUA)  VALUES
                 (
				    :MaQuanLy,
                    :ListPhanLoai,
                    :QuickCovidNgay1,
                    :QuickCovidNgay2,
                    :QuickCovidNgay3,
                    :QuickCovidNgay4,
                    :TanSoThoNgay1_S,
                    :TanSoThoNgay1_C,
                    :TanSoThoNgay2_S,
                    :TanSoThoNgay2_C,
                    :TanSoThoNgay3_S,
                    :TanSoThoNgay3_C,
                    :TanSoThoNgay4_S,
                    :TanSoThoNgay4_C,
                    :Spo2Ngay1_S,
                    :Spo2Ngay1_C,
                    :Spo2Ngay2_S,
                    :Spo2Ngay2_C,
                    :Spo2Ngay3_S,
                    :Spo2Ngay3_C,
                    :Spo2Ngay4_S,
                    :Spo2Ngay4_C,
                    :OxiNgay1_S,
                    :OxiNgay1_C,
                    :OxiNgay2_S,
                    :OxiNgay2_C,
                    :OxiNgay3_S,
                    :OxiNgay3_C,
                    :OxiNgay4_S,
                    :OxiNgay4_C,
                    :TongDiemNgay1_S,
                    :TongDiemNgay1_C,
                    :TongDiemNgay2_S,
                    :TongDiemNgay2_C,
                    :TongDiemNgay3_S,
                    :TongDiemNgay3_C,
                    :TongDiemNgay4_S,
                    :TongDiemNgay4_C,
                    :ChiSoRoxNgay1,
                    :ChiSoRoxNgay2,
                    :ChiSoRoxNgay3,
                    :ChiSoRoxNgay1_Gio1,
                    :ChiSoRoxNgay1_Gio2,
                    :ChiSoRoxNgay1_Gio3,
                    :ChiSoRoxNgay1_Gio4,
                    :ChiSoRoxNgay2_Gio1,
                    :ChiSoRoxNgay2_Gio2,
                    :ChiSoRoxNgay2_Gio3,
                    :ChiSoRoxNgay2_Gio4,
                    :ChiSoRoxNgay3_Gio1,
                    :ChiSoRoxNgay3_Gio2,
                    :ChiSoRoxNgay3_Gio3,
                    :ChiSoRoxNgay3_Gio4,
                    :ChiSoRoxNgay1_Text1,
                    :ChiSoRoxNgay1_Text2,
                    :ChiSoRoxNgay1_Text3,
                    :ChiSoRoxNgay1_Text4,
                    :ChiSoRoxNgay2_Text1,
                    :ChiSoRoxNgay2_Text2,
                    :ChiSoRoxNgay2_Text3,
                    :ChiSoRoxNgay2_Text4,
                    :ChiSoRoxNgay3_Text1,
                    :ChiSoRoxNgay3_Text2,
                    :ChiSoRoxNgay3_Text3,
                    :ChiSoRoxNgay3_Text4,
                    :NGUOITAO,
                    :NGUOISUA,
                    :NGAYTAO,
                    :NGAYSUA
                 )  RETURNING ID INTO :ID";
                if (ketQua.ID != 0)
                {
                    sql = @"UPDATE PhieuTheoDoiBenhNhanCovid SET 
                    MaQuanLy = :MaQuanLy,
                    ListPhanLoai = :ListPhanLoai,
                    QuickCovidNgay1 = :QuickCovidNgay1,
                    QuickCovidNgay2 = :QuickCovidNgay2,
                    QuickCovidNgay3 = :QuickCovidNgay3,
                    QuickCovidNgay4 = :QuickCovidNgay4,
                    TanSoThoNgay1_S = :TanSoThoNgay1_S,
                    TanSoThoNgay1_C = :TanSoThoNgay1_C,
                    TanSoThoNgay2_S = :TanSoThoNgay2_S,
                    TanSoThoNgay2_C = :TanSoThoNgay2_C,
                    TanSoThoNgay3_S = :TanSoThoNgay3_S,
                    TanSoThoNgay3_C = :TanSoThoNgay3_C,
                    TanSoThoNgay4_S = :TanSoThoNgay4_S,
                    TanSoThoNgay4_C = :TanSoThoNgay4_C,
                    Spo2Ngay1_S = :Spo2Ngay1_S,
                    Spo2Ngay1_C = :Spo2Ngay1_C,
                    Spo2Ngay2_S = :Spo2Ngay2_S,
                    Spo2Ngay2_C = :Spo2Ngay2_C,
                    Spo2Ngay3_S = :Spo2Ngay3_S,
                    Spo2Ngay3_C = :Spo2Ngay3_C,
                    Spo2Ngay4_S = :Spo2Ngay4_S,
                    Spo2Ngay4_C = :Spo2Ngay4_C,
                    OxiNgay1_S = :OxiNgay1_S,
                    OxiNgay1_C = :OxiNgay1_C,
                    OxiNgay2_S = :OxiNgay2_S,
                    OxiNgay2_C = :OxiNgay2_C,
                    OxiNgay3_S = :OxiNgay3_S,
                    OxiNgay3_C = :OxiNgay3_C,
                    OxiNgay4_S = :OxiNgay4_S,
                    OxiNgay4_C = :OxiNgay4_C,
                    TongDiemNgay1_S = :TongDiemNgay1_S,
                    TongDiemNgay1_C = :TongDiemNgay1_C,
                    TongDiemNgay2_S = :TongDiemNgay2_S,
                    TongDiemNgay2_C = :TongDiemNgay2_C,
                    TongDiemNgay3_S = :TongDiemNgay3_S,
                    TongDiemNgay3_C = :TongDiemNgay3_C,
                    TongDiemNgay4_S = :TongDiemNgay4_S,
                    TongDiemNgay4_C = :TongDiemNgay4_C,
                    ChiSoRoxNgay1 = :ChiSoRoxNgay1,
                    ChiSoRoxNgay2 = :ChiSoRoxNgay2,
                    ChiSoRoxNgay3 = :ChiSoRoxNgay3,
                    ChiSoRoxNgay1_Gio1 = :ChiSoRoxNgay1_Gio1,
                    ChiSoRoxNgay1_Gio2 = :ChiSoRoxNgay1_Gio2,
                    ChiSoRoxNgay1_Gio3 = :ChiSoRoxNgay1_Gio3,
                    ChiSoRoxNgay1_Gio4 = :ChiSoRoxNgay1_Gio4,
                    ChiSoRoxNgay2_Gio1 = :ChiSoRoxNgay2_Gio1,
                    ChiSoRoxNgay2_Gio2 = :ChiSoRoxNgay2_Gio2,
                    ChiSoRoxNgay2_Gio3 = :ChiSoRoxNgay2_Gio3,
                    ChiSoRoxNgay2_Gio4 = :ChiSoRoxNgay2_Gio4,
                    ChiSoRoxNgay3_Gio1 = :ChiSoRoxNgay3_Gio1,
                    ChiSoRoxNgay3_Gio2 = :ChiSoRoxNgay3_Gio2,
                    ChiSoRoxNgay3_Gio3 = :ChiSoRoxNgay3_Gio3,
                    ChiSoRoxNgay3_Gio4 = :ChiSoRoxNgay3_Gio4,
                    ChiSoRoxNgay1_Text1 = :ChiSoRoxNgay1_Text1,
                    ChiSoRoxNgay1_Text2 = :ChiSoRoxNgay1_Text2,
                    ChiSoRoxNgay1_Text3 = :ChiSoRoxNgay1_Text3,
                    ChiSoRoxNgay1_Text4 = :ChiSoRoxNgay1_Text4,
                    ChiSoRoxNgay2_Text1 = :ChiSoRoxNgay2_Text1,
                    ChiSoRoxNgay2_Text2 = :ChiSoRoxNgay2_Text2,
                    ChiSoRoxNgay2_Text3 = :ChiSoRoxNgay2_Text3,
                    ChiSoRoxNgay2_Text4 = :ChiSoRoxNgay2_Text4,
                    ChiSoRoxNgay3_Text1 = :ChiSoRoxNgay3_Text1,
                    ChiSoRoxNgay3_Text2 = :ChiSoRoxNgay3_Text2,
                    ChiSoRoxNgay3_Text3 = :ChiSoRoxNgay3_Text3,
                    ChiSoRoxNgay3_Text4 = :ChiSoRoxNgay3_Text4,
                    NGUOISUA = :NGUOISUA,
                    NGAYSUA = :NGAYSUA 
                    WHERE ID = " + ketQua.ID;
                }
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);

                Command.Parameters.Add(new MDB.MDBParameter("NGUOISUA", ketQua.NguoiSua));
                Command.Parameters.Add(new MDB.MDBParameter("NGAYSUA", ketQua.NgaySua));

                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", ketQua.MaQuanLy));
                Command.Parameters.Add(new MDB.MDBParameter("ListPhanLoai", JsonConvert.SerializeObject(ketQua.ListPhanLoai)));

                Command.Parameters.Add(new MDB.MDBParameter("QuickCovidNgay1", ketQua.QuickCovidNgay1));
                Command.Parameters.Add(new MDB.MDBParameter("QuickCovidNgay2", ketQua.QuickCovidNgay2));
                Command.Parameters.Add(new MDB.MDBParameter("QuickCovidNgay3", ketQua.QuickCovidNgay3));
                Command.Parameters.Add(new MDB.MDBParameter("QuickCovidNgay4", ketQua.QuickCovidNgay4));
                Command.Parameters.Add(new MDB.MDBParameter("TanSoThoNgay1_S", ketQua.TanSoThoNgay1_S));
                Command.Parameters.Add(new MDB.MDBParameter("TanSoThoNgay1_C", ketQua.TanSoThoNgay1_C));
                Command.Parameters.Add(new MDB.MDBParameter("TanSoThoNgay2_S", ketQua.TanSoThoNgay2_S));
                Command.Parameters.Add(new MDB.MDBParameter("TanSoThoNgay2_C", ketQua.TanSoThoNgay2_C));
                Command.Parameters.Add(new MDB.MDBParameter("TanSoThoNgay3_S", ketQua.TanSoThoNgay3_S));
                Command.Parameters.Add(new MDB.MDBParameter("TanSoThoNgay3_C", ketQua.TanSoThoNgay3_C));
                Command.Parameters.Add(new MDB.MDBParameter("TanSoThoNgay4_S", ketQua.TanSoThoNgay4_S));
                Command.Parameters.Add(new MDB.MDBParameter("TanSoThoNgay4_C", ketQua.TanSoThoNgay4_C));
                Command.Parameters.Add(new MDB.MDBParameter("Spo2Ngay1_S", ketQua.Spo2Ngay1_S));
                Command.Parameters.Add(new MDB.MDBParameter("Spo2Ngay1_C", ketQua.Spo2Ngay1_C));
                Command.Parameters.Add(new MDB.MDBParameter("Spo2Ngay2_S", ketQua.Spo2Ngay2_S));
                Command.Parameters.Add(new MDB.MDBParameter("Spo2Ngay2_C", ketQua.Spo2Ngay2_C));
                Command.Parameters.Add(new MDB.MDBParameter("Spo2Ngay3_S", ketQua.Spo2Ngay3_S));
                Command.Parameters.Add(new MDB.MDBParameter("Spo2Ngay3_C", ketQua.Spo2Ngay3_C));
                Command.Parameters.Add(new MDB.MDBParameter("Spo2Ngay4_S", ketQua.Spo2Ngay4_S));
                Command.Parameters.Add(new MDB.MDBParameter("Spo2Ngay4_C", ketQua.Spo2Ngay4_C));
                Command.Parameters.Add(new MDB.MDBParameter("OxiNgay1_S", ketQua.OxiNgay1_S));
                Command.Parameters.Add(new MDB.MDBParameter("OxiNgay1_C", ketQua.OxiNgay1_C));
                Command.Parameters.Add(new MDB.MDBParameter("OxiNgay2_S", ketQua.OxiNgay2_S));
                Command.Parameters.Add(new MDB.MDBParameter("OxiNgay2_C", ketQua.OxiNgay2_C));
                Command.Parameters.Add(new MDB.MDBParameter("OxiNgay3_S", ketQua.OxiNgay3_S));
                Command.Parameters.Add(new MDB.MDBParameter("OxiNgay3_C", ketQua.OxiNgay3_C));
                Command.Parameters.Add(new MDB.MDBParameter("OxiNgay4_S", ketQua.OxiNgay4_S));
                Command.Parameters.Add(new MDB.MDBParameter("OxiNgay4_C", ketQua.OxiNgay4_C));
                Command.Parameters.Add(new MDB.MDBParameter("TongDiemNgay1_S", ketQua.TongDiemNgay1_S));
                Command.Parameters.Add(new MDB.MDBParameter("TongDiemNgay1_C", ketQua.TongDiemNgay1_C));
                Command.Parameters.Add(new MDB.MDBParameter("TongDiemNgay2_S", ketQua.TongDiemNgay2_S));
                Command.Parameters.Add(new MDB.MDBParameter("TongDiemNgay2_C", ketQua.TongDiemNgay2_C));
                Command.Parameters.Add(new MDB.MDBParameter("TongDiemNgay3_S", ketQua.TongDiemNgay3_S));
                Command.Parameters.Add(new MDB.MDBParameter("TongDiemNgay3_C", ketQua.TongDiemNgay3_C));
                Command.Parameters.Add(new MDB.MDBParameter("TongDiemNgay4_S", ketQua.TongDiemNgay4_S));
                Command.Parameters.Add(new MDB.MDBParameter("TongDiemNgay4_C", ketQua.TongDiemNgay4_C));
                Command.Parameters.Add(new MDB.MDBParameter("ChiSoRoxNgay1", ketQua.ChiSoRoxNgay1));
                Command.Parameters.Add(new MDB.MDBParameter("ChiSoRoxNgay2", ketQua.ChiSoRoxNgay2));
                Command.Parameters.Add(new MDB.MDBParameter("ChiSoRoxNgay3", ketQua.ChiSoRoxNgay3));
                Command.Parameters.Add(new MDB.MDBParameter("ChiSoRoxNgay1_Gio1", ketQua.ChiSoRoxNgay1_Gio1));
                Command.Parameters.Add(new MDB.MDBParameter("ChiSoRoxNgay1_Gio2", ketQua.ChiSoRoxNgay1_Gio2));
                Command.Parameters.Add(new MDB.MDBParameter("ChiSoRoxNgay1_Gio3", ketQua.ChiSoRoxNgay1_Gio3));
                Command.Parameters.Add(new MDB.MDBParameter("ChiSoRoxNgay1_Gio4", ketQua.ChiSoRoxNgay1_Gio4));
                Command.Parameters.Add(new MDB.MDBParameter("ChiSoRoxNgay2_Gio1", ketQua.ChiSoRoxNgay2_Gio1));
                Command.Parameters.Add(new MDB.MDBParameter("ChiSoRoxNgay2_Gio2", ketQua.ChiSoRoxNgay2_Gio2));
                Command.Parameters.Add(new MDB.MDBParameter("ChiSoRoxNgay2_Gio3", ketQua.ChiSoRoxNgay2_Gio3));
                Command.Parameters.Add(new MDB.MDBParameter("ChiSoRoxNgay2_Gio4", ketQua.ChiSoRoxNgay2_Gio4));
                Command.Parameters.Add(new MDB.MDBParameter("ChiSoRoxNgay3_Gio1", ketQua.ChiSoRoxNgay3_Gio1));
                Command.Parameters.Add(new MDB.MDBParameter("ChiSoRoxNgay3_Gio2", ketQua.ChiSoRoxNgay3_Gio2));
                Command.Parameters.Add(new MDB.MDBParameter("ChiSoRoxNgay3_Gio3", ketQua.ChiSoRoxNgay3_Gio3));
                Command.Parameters.Add(new MDB.MDBParameter("ChiSoRoxNgay3_Gio4", ketQua.ChiSoRoxNgay3_Gio4));
                Command.Parameters.Add(new MDB.MDBParameter("ChiSoRoxNgay1_Text1", ketQua.ChiSoRoxNgay1_Text1));
                Command.Parameters.Add(new MDB.MDBParameter("ChiSoRoxNgay1_Text2", ketQua.ChiSoRoxNgay1_Text2));
                Command.Parameters.Add(new MDB.MDBParameter("ChiSoRoxNgay1_Text3", ketQua.ChiSoRoxNgay1_Text3));
                Command.Parameters.Add(new MDB.MDBParameter("ChiSoRoxNgay1_Text4", ketQua.ChiSoRoxNgay1_Text4));
                Command.Parameters.Add(new MDB.MDBParameter("ChiSoRoxNgay2_Text1", ketQua.ChiSoRoxNgay2_Text1));
                Command.Parameters.Add(new MDB.MDBParameter("ChiSoRoxNgay2_Text2", ketQua.ChiSoRoxNgay2_Text2));
                Command.Parameters.Add(new MDB.MDBParameter("ChiSoRoxNgay2_Text3", ketQua.ChiSoRoxNgay2_Text3));
                Command.Parameters.Add(new MDB.MDBParameter("ChiSoRoxNgay2_Text4", ketQua.ChiSoRoxNgay2_Text4));
                Command.Parameters.Add(new MDB.MDBParameter("ChiSoRoxNgay3_Text1", ketQua.ChiSoRoxNgay3_Text1));
                Command.Parameters.Add(new MDB.MDBParameter("ChiSoRoxNgay3_Text2", ketQua.ChiSoRoxNgay3_Text2));
                Command.Parameters.Add(new MDB.MDBParameter("ChiSoRoxNgay3_Text3", ketQua.ChiSoRoxNgay3_Text3));
                Command.Parameters.Add(new MDB.MDBParameter("ChiSoRoxNgay3_Text4", ketQua.ChiSoRoxNgay3_Text4));

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
    }
}
