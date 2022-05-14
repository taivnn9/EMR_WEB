using EMR.KyDienTu;
using Newtonsoft.Json;
using PMS.Access;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMR_MAIN.DATABASE.Other
{
    public class GiayDatMauVaChePhamMauChiTiet
    {
        public int STT { get; set; }
        public string TenChePhamMau { get; set; }
        [MoTaDuLieu("Nhóm máu")]
		public string NhomMau { get; set; }
        public string TheTich { get; set; }
        public string SoLuong { get; set; }
        [MoTaDuLieu("Ghi chú")]
		public string GhiChu { get; set; }
    }

    public class GiayDatMauVaChePhamMau : ThongTinKy
    {
        public GiayDatMauVaChePhamMau()
        {
            TableName = "GiayDatMauVaChePhamMau";
            TablePrimaryKeyName = "ID";
            IDMauPhieu = (int)DanhMucPhieu.GDMVCPM;
            TenMauPhieu = DanhMucPhieu.GDMVCPM.Description();
        }
        [MoTaDuLieu("Mã định danh")]
		public long ID { get; set; }
        [MoTaDuLieu("Mã quản lý: mã duy nhất trong 1 đợt khám chữa bệnh (kcb), không trùng giữa các đợt kcb khác nhau","",1)]
		public decimal MaQuanLy { get; set; }
        [MoTaDuLieu("Mã bệnh nhân")]
		public string MaBenhNhan { get; set; }
        public string HoTenBenhNhan { get; set; }
        [MoTaDuLieu("Tuổi bệnh nhân")]
		public string Tuoi { get; set; }
        [MoTaDuLieu("Giới tính bệnh nhân")]
		public string GioiTinh { get; set; }
        [MoTaDuLieu("Khoa")]
		public string Khoa { get; set; }
        [MoTaDuLieu("Mã khoa")]
		public string MaKhoa { get; set; }
        [MoTaDuLieu("Nhóm máu")]
		public string NhomMau { get; set; }
        public string ChePhamMauDat { get; set; }
        public DateTime ThoiGian { get; set; }
        public DateTime ThoiGianTruyen { get; set; }
        public List<GiayDatMauVaChePhamMauChiTiet> BangTheoDois { get; set; }
        [MoTaDuLieu("Bác sỹ")]
		public string BacSy { get; set; }
        [MoTaDuLieu("Mã bác sỹ")]
		public string MaBacSy { get; set; }
        [MoTaDuLieu("Đã ký", null, 0, 0)]
		public bool DaKy { get; set; }
        [MoTaDuLieu("Ngày tạo", null, 0, 0)]
		public DateTime NgayTao { get; set; }
        [MoTaDuLieu("Người tạo", null, 0, 0)]
		public string NguoiTao { get; set; }
        [MoTaDuLieu("Ngày sửa", null, 0, 0)]
		public DateTime NgaySua { get; set; }
        [MoTaDuLieu("Người sửa", null, 0, 0)]
		public string NguoiSua { get; set; }
        [MoTaDuLieu("Chọn", null, 0, 0)]
		public bool Chon { get; set; }
    }
    public class GiayDatMauVaChePhamMauFunc
    {
        public const string TableName = "GiayDatMauVaChePhamMau";
        public const string TablePrimaryKeyName = "ID";
        //public static ObservableCollection<GiayDatMauVaChePhamMauChiTiet> ConvertShowData(List<SaveChiTietGiayDatMauVaChePhamMau> saveDatas)
        //{
        //    ObservableCollection<GiayDatMauVaChePhamMauChiTiet> showData = new ObservableCollection<GiayDatMauVaChePhamMauChiTiet>();
        //    foreach (SaveChiTietGiayDatMauVaChePhamMau saveChiTiet in saveDatas)
        //    {
        //        showData.Add(new GiayDatMauVaChePhamMauChiTiet
        //        {
        //            Ngay = saveChiTiet.Ng,
        //            Gio = saveChiTiet.Ng,
        //            TocDoTruyen = saveChiTiet.TDT,
        //            MauSacDa = saveChiTiet.MSD,
        //            NhipTho = saveChiTiet.NT,
        //            Mach = saveChiTiet.M,
        //            HuyetAp = saveChiTiet.HA,
        //            ThanNhiet = saveChiTiet.TN,
        //            DienBienKhac = saveChiTiet.DBK
        //        });
        //    }
        //    return showData;
        //}
        //public static List<SaveChiTietGiayDatMauVaChePhamMau> ConvertSaveData(ObservableCollection<GiayDatMauVaChePhamMauChiTiet> showDatas)
        //{
        //    List<SaveChiTietGiayDatMauVaChePhamMau> saveData = new List<SaveChiTietGiayDatMauVaChePhamMau>();
        //    foreach (GiayDatMauVaChePhamMauChiTiet showChiTiet in showDatas)
        //    {
        //        var Ngay = showChiTiet.Ngay.HasValue ? showChiTiet.Ngay.Value.Date.Add(new TimeSpan(0, 0, 0)) : DateTime.Now.Date.Add(new TimeSpan(0, 0, 0));
        //        var Gio = showChiTiet.Gio.HasValue ? showChiTiet.Gio.Value.TimeOfDay : DateTime.Now.TimeOfDay;
        //        saveData.Add(new SaveChiTietGiayDatMauVaChePhamMau
        //        {
        //            Ng = Ngay + Gio,
        //            TDT = showChiTiet.TocDoTruyen,
        //            MSD = showChiTiet.MauSacDa,
        //            NT = showChiTiet.NhipTho,
        //            M = showChiTiet.Mach,
        //            HA = showChiTiet.HuyetAp,
        //            TN = showChiTiet.ThanNhiet,
        //            DBK = showChiTiet.DienBienKhac
        //        });
        //    }
        //    return saveData;
        //}

        public static List<GiayDatMauVaChePhamMau> GetListData(MDB.MDBConnection _OracleConnection, decimal maquanly)
        {
            List<GiayDatMauVaChePhamMau> list = new List<GiayDatMauVaChePhamMau>();
            try
            {
                string sql = @"SELECT * FROM GiayDatMauVaChePhamMau where MaQuanLy = :MaQuanLy";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, _OracleConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", maquanly));
                MDB.MDBDataReader DataReader = Command.ExecuteReader();
                while (DataReader.Read())
                {
                    GiayDatMauVaChePhamMau data = new GiayDatMauVaChePhamMau();
                    data.ID = Convert.ToInt64(DataReader.GetLong("ID").ToString());
                    data.MaQuanLy = maquanly;
                    data.MaBenhNhan = DataReader["MaBenhNhan"].ToString();
                    data.HoTenBenhNhan = XemBenhAn._HanhChinhBenhNhan.TenBenhNhan;
                    data.Tuoi = XemBenhAn._HanhChinhBenhNhan.Tuoi;
                    data.GioiTinh = XemBenhAn._HanhChinhBenhNhan.GioiTinh.Description();
                    data.Khoa = XemBenhAn._ThongTinDieuTri.Khoa;

                    data.NhomMau = DataReader["NhomMau"].ToString();
                    data.ChePhamMauDat = DataReader["ChePhamMauDat"].ToString();
                    data.ThoiGian = Common.ConDB_DateTime(DataReader["ThoiGian"]);
                    data.ThoiGianTruyen = Common.ConDB_DateTime(DataReader["ThoiGianTruyen"]);

                    string bangTheoDoiJson = DataReader["BangTheoDois_1"].ToString();
                    if (DataReader["BangTheoDois_2"] != DBNull.Value)
                        bangTheoDoiJson += DataReader["BangTheoDois_2"].ToString();
                    if (DataReader["BangTheoDois_3"] != DBNull.Value)
                        bangTheoDoiJson += DataReader["BangTheoDois_3"].ToString();

                    try
                    {
                        data.BangTheoDois = JsonConvert.DeserializeObject<List<GiayDatMauVaChePhamMauChiTiet>>(bangTheoDoiJson);
                    }
                    catch { data.BangTheoDois = new List<GiayDatMauVaChePhamMauChiTiet>(); }
                    data.BacSy = DataReader["BacSy"].ToString();
                    data.MaBacSy = DataReader["MaBacSy"].ToString();

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
        public static bool InsertOrUpdate(MDB.MDBConnection MyConnection, ref GiayDatMauVaChePhamMau data)
        {
            try
            {
                string sql = @"INSERT INTO GiayDatMauVaChePhamMau
                (
                    MAQUANLY,
                    MaBenhNhan,
                    NhomMau,
                    ChePhamMauDat,
                    ThoiGian,
                    ThoiGianTruyen,
                    BangTheoDois_1,
                    BangTheoDois_2,
                    BangTheoDois_3,
                    BacSy,
                    MaBacSy,
                    NGUOITAO,
                    NGUOISUA,
                    NGAYTAO,
                    NGAYSUA)  VALUES
                 (
				    :MAQUANLY,
                    :MaBenhNhan,
                    :NhomMau,
                    :ChePhamMauDat,
                    :ThoiGian,
                    :ThoiGianTruyen,
                    :BangTheoDois_1,
                    :BangTheoDois_2,
                    :BangTheoDois_3,
                    :BacSy,
                    :MaBacSy,
                    :NGUOITAO,
                    :NGUOISUA,
                    :NGAYTAO,
                    :NGAYSUA
                 )  RETURNING ID INTO :ID";
                if (data.ID != 0)
                {
                    sql = @"UPDATE GiayDatMauVaChePhamMau SET 
                    MAQUANLY=:MAQUANLY,
                    MaBenhNhan=:MaBenhNhan,
                    NhomMau=:NhomMau,
                    ChePhamMauDat=:ChePhamMauDat,
                    ThoiGian=:ThoiGian,
                    ThoiGianTruyen=:ThoiGianTruyen,
                    BangTheoDois_1=:BangTheoDois_1,
                    BangTheoDois_2=:BangTheoDois_2,
                    BangTheoDois_3=:BangTheoDois_3,
                    BacSy=:BacSy,
                    MaBacSy=:MaBacSy,
                    NGUOISUA = :NGUOISUA,
                    NGAYSUA = :NGAYSUA
                    WHERE ID = " + data.ID;
                }
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MAQUANLY", data.MaQuanLy));
                Command.Parameters.Add(new MDB.MDBParameter("MaBenhNhan", data.MaBenhNhan));
                Command.Parameters.Add(new MDB.MDBParameter("NhomMau", data.NhomMau));
                Command.Parameters.Add(new MDB.MDBParameter("ChePhamMauDat", data.ChePhamMauDat));
                Command.Parameters.Add(new MDB.MDBParameter("ThoiGian", data.ThoiGian));
                Command.Parameters.Add(new MDB.MDBParameter("ThoiGianTruyen", data.ThoiGianTruyen));
                string jsonBangKes = JsonConvert.SerializeObject(data.BangTheoDois);
                List<string> listJson = new List<string>();
                for (int i = 0; i < jsonBangKes.Length; i += 3999)
                {
                    if ((i + 3999) < jsonBangKes.Length)
                        listJson.Add(jsonBangKes.Substring(i, 3999));
                    else
                        listJson.Add(jsonBangKes.Substring(i));
                }
                Command.Parameters.Add(new MDB.MDBParameter("BangTheoDois_1", listJson[0]));
                Command.Parameters.Add(new MDB.MDBParameter("BangTheoDois_2", listJson.Count > 1 ? listJson[1] : ""));
                Command.Parameters.Add(new MDB.MDBParameter("BangTheoDois_3", listJson.Count > 2 ? listJson[2] : ""));
                Command.Parameters.Add(new MDB.MDBParameter("BacSy", data.BacSy));
                Command.Parameters.Add(new MDB.MDBParameter("MaBacSy", data.MaBacSy));

                Command.Parameters.Add(new MDB.MDBParameter("NGUOISUA", data.NguoiSua));
                Command.Parameters.Add(new MDB.MDBParameter("NGAYSUA", data.NgaySua));
                if (data.ID == 0)
                {
                    Command.Parameters.Add(new MDB.MDBParameter("ID", data.ID));
                    Command.Parameters.Add(new MDB.MDBParameter("NGUOITAO", data.NguoiTao));
                    Command.Parameters.Add(new MDB.MDBParameter("NGAYTAO", data.NgayTao));
                }
                Command.BindByName = true;
                int n = Command.ExecuteNonQuery();
                if (data.ID == 0)
                {
                    long nextval = Convert.ToInt64((Command.Parameters["ID"] as MDB.MDBParameter).Value);
                    data.ID = nextval;
                }
                return n > 0;
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
                string sql = "DELETE FROM GiayDatMauVaChePhamMau WHERE ID = :ID";
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
        public static DataSet getDataSet(MDB.MDBConnection MyConnection, long id)
        {
            string sql = @"SELECT
                B.*
            FROM
                GiayDatMauVaChePhamMau B
            WHERE
                ID = " + id;

            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
            MDB.MDBDataAdapter adt = new MDB.MDBDataAdapter(Command);
            var ds = new DataSet();

            adt.Fill(ds, "BK");

            ds.Tables[0].AddColumn("TenBenhNhan", typeof(string));
            ds.Tables[0].AddColumn("Tuoi", typeof(string));
            ds.Tables[0].AddColumn("GioiTinh", typeof(string));
            ds.Tables[0].AddColumn("SOYTE", typeof(string));
            ds.Tables[0].AddColumn("BENHVIEN", typeof(string));
            ds.Tables[0].AddColumn("KHOA", typeof(string));

            ds.Tables[0].Rows[0]["TenBenhNhan"] = XemBenhAn._HanhChinhBenhNhan.TenBenhNhan;
            ds.Tables[0].Rows[0]["Tuoi"] = XemBenhAn._HanhChinhBenhNhan.Tuoi;
            ds.Tables[0].Rows[0]["GioiTinh"] = XemBenhAn._HanhChinhBenhNhan.GioiTinh.Description();
            ds.Tables[0].Rows[0]["SOYTE"] = XemBenhAn._HanhChinhBenhNhan.SoYTe;
            ds.Tables[0].Rows[0]["BENHVIEN"] = XemBenhAn._HanhChinhBenhNhan.BenhVien;
            ds.Tables[0].Rows[0]["KHOA"] = XemBenhAn._ThongTinDieuTri.Khoa;

            sql = @"SELECT
               B.BangTheoDois_1, B.BangTheoDois_2, B.BangTheoDois_3
            FROM
                GiayDatMauVaChePhamMau B
                
            WHERE
                ID = " + id;

            Command = new MDB.MDBCommand(sql, MyConnection);
            MDB.MDBDataReader DataReader = Command.ExecuteReader();

            List<GiayDatMauVaChePhamMauChiTiet> saveDatas = new List<GiayDatMauVaChePhamMauChiTiet>();
            while (DataReader.Read())
            {
                string bangKeJson = DataReader["BangTheoDois_1"].ToString();
                if (DataReader["BangTheoDois_2"] != DBNull.Value)
                    bangKeJson += DataReader["BangTheoDois_2"].ToString();
                if (DataReader["BangTheoDois_3"] != DBNull.Value)
                    bangKeJson += DataReader["BangTheoDois_3"].ToString();
                saveDatas = JsonConvert.DeserializeObject<List<GiayDatMauVaChePhamMauChiTiet>>(bangKeJson).ToList();
                break;
            }

            // DataTable ChiTiet = new DataTable("CT");
            //ChiTiet.Columns.Add("Ng", typeof(string));
            //ChiTiet.Columns.Add("TDT", typeof(string));
            //ChiTiet.Columns.Add("MSD", typeof(string));
            //ChiTiet.Columns.Add("NT", typeof(string));
            //ChiTiet.Columns.Add("M", typeof(string));
            //ChiTiet.Columns.Add("HA", typeof(string));
            //ChiTiet.Columns.Add("TN", typeof(string));
            //ChiTiet.Columns.Add("DBK", typeof(string));
            //foreach (SaveChiTietGiayDatMauVaChePhamMau ct in saveDatas)
            //{
            //    ChiTiet.Rows.Add(ct.Ng.HasValue ? ct.Ng.Value.ToString("HH:mm dd/MM") : "",
            //        ct.TDT.HasValue ? ct.TDT.Value.ToString() : "",
            //        ct.MSD,
            //        ct.NT.HasValue ? ct.NT.Value.ToString() : "",
            //        ct.M.HasValue ? ct.M.Value.ToString() : "",
            //        ct.HA,
            //        ct.TN.HasValue ? ct.TN.Value.ToString() : "",
            //        ct.DBK
            //        );
            //}

            DataTable ChiTiet = Common.ListToDataTable(saveDatas, "CT");
            ds.Tables.Add(ChiTiet);

            return ds;

        }

    }
}
