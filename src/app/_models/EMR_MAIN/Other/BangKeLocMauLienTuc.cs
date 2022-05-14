using EMR.KyDienTu;
using MDB;
using Newtonsoft.Json;
using NLog;
using PMS.Access;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Linq;

namespace EMR_MAIN.DATABASE.Other
{
    public class ChiTietLocMauLienTuc
    {
        [MoTaDuLieu("Giờ")]
        public DateTime? Gio { get; set; }
        [MoTaDuLieu("Nacl")]
        public string Na { get; set; }
        [MoTaDuLieu("Dịch thay thế")]
        public string DTT { get; set; }
        [MoTaDuLieu("Kali")]
        public string Ka { get; set; }
        [MoTaDuLieu("Heparin")]
        public string He { get; set; }
        [MoTaDuLieu("Thay quả")]
        public string TQ { get; set; }
        [MoTaDuLieu("Bác sĩ")]
        public string BS { get; set; }
        [MoTaDuLieu("Diều dưỡng")]
        public string DD { get; set; }
    }
    public class SaveChiTietLocMauLienTuc
    {
        public int G { get; set; }
        public int P { get; set; }
        public string N { get; set; }
        public string D { get; set; }
        public string K { get; set; }
        public string H { get; set; }
        public string T { get; set; }
        [MoTaDuLieu("Bác sĩ")]
        public string BS { get; set; }
        [MoTaDuLieu("Diều dưỡng")]
        public string DD { get; set; }
    }
    public class BangKeLocMauLienTuc : ThongTinKy
    {
        public BangKeLocMauLienTuc()
        {
            TableName = "BangKeLocMauLienTuc";
            TablePrimaryKeyName = "ID";
            IDMauPhieu = (int)DanhMucPhieu.BKLMLT;
            TenMauPhieu = DanhMucPhieu.BKLMLT.Description();
        }
        [MoTaDuLieu("Mã định danh")]
		public long ID { get; set; }
        [MoTaDuLieu("Mã quản lý: mã duy nhất trong 1 đợt khám chữa bệnh (kcb), không trùng giữa các đợt kcb khác nhau","",1)]
		public decimal MaQuanLy { get; set; }
        [MoTaDuLieu("Mã bệnh nhân")]
		public string MaBenhNhan { get; set; }
        [MoTaDuLieu("Họ và tên bệnh nhân")]
        public string HoTenBenhNhan { get; set; }
        [MoTaDuLieu("Tuổi bệnh nhân")]
		public string Tuoi { get; set; }
        [MoTaDuLieu("Giới tính bệnh nhân")]
		public string GioiTinh { get; set; }
        [MoTaDuLieu("Chẩn đoán bệnh")]
		public string ChanDoan { get; set; }
        [MoTaDuLieu("Người thực hiện")]
		public string NguoiThucHien { get; set; }
        [MoTaDuLieu("Mã người thực hiện")]
		public string MaNguoiThucHien { get; set; }
        [MoTaDuLieu("Phương thức chạy")]
        public string PhuongThucChay { get; set; }
        [MoTaDuLieu("Lần chạy thứ mấy")]
        public int? Lan { get; set; }
        [MoTaDuLieu("Ngày chạy lọc máu")]
        public DateTime Ngay { get; set; }
        public ObservableCollection<ChiTietLocMauLienTuc> BangKes { get; set; }
        [MoTaDuLieu("Máy lọc")]
        public string MayLoc { get; set; }
        [MoTaDuLieu("Quả lọc")]
        public string QuaLoc { get; set; }
        [MoTaDuLieu("Tốc độ máu BF")]
        public string TocDoMauBF { get; set; }
        [MoTaDuLieu("Tốc độ máu UF")]
        public string TocDoMauUF { get; set; }
        [MoTaDuLieu("Trước màng")]
        public string TruocMang { get; set; }
        [MoTaDuLieu("Sau màng")]
        public string SauMang { get; set; }

        [MoTaDuLieu("Thuốc chống đông")]
        public string ThuocChongDong { get; set; }

        [MoTaDuLieu("Bolus")]
        public string Bolus { get; set; }

        [MoTaDuLieu("Duy trì")]
        public string DuyTri { get; set; }
        [MoTaDuLieu("Tai biến và biến chứng")]
        public string TaiBienVaBienChung { get; set; }
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
    public class BangKeLocMauLienTucFunc
    {
        static Logger log = LogManager.GetLogger("Log");
        public const string TableName = "BangKeLocMauLienTuc";
        public const string TablePrimaryKeyName = "ID";
        public static ObservableCollection<ChiTietLocMauLienTuc> ConvertShowData(List<SaveChiTietLocMauLienTuc> saveDatas)
        {
            ObservableCollection<ChiTietLocMauLienTuc> showData = new ObservableCollection<ChiTietLocMauLienTuc>();
            foreach (SaveChiTietLocMauLienTuc saveChiTiet in saveDatas)
            {
                DateTime tempDate = DateTime.Now;
                TimeSpan ts = new TimeSpan(saveChiTiet.G, saveChiTiet.P, 0);
                tempDate = tempDate.Date + ts;
                showData.Add(new ChiTietLocMauLienTuc
                {
                    Gio = tempDate,
                    Na = saveChiTiet.N,
                    DTT = saveChiTiet.D,
                    Ka = saveChiTiet.K,
                    He = saveChiTiet.H,
                    TQ = saveChiTiet.T,
                    BS = saveChiTiet.BS,
                    DD = saveChiTiet.DD,
                });
            }
            return showData;
        }
        public static List<SaveChiTietLocMauLienTuc> ConvertSaveData(ObservableCollection<ChiTietLocMauLienTuc> showDatas)
        {
            List<SaveChiTietLocMauLienTuc> saveData = new List<SaveChiTietLocMauLienTuc>();
            foreach (ChiTietLocMauLienTuc showChiTiet in showDatas)
            {
                saveData.Add(new SaveChiTietLocMauLienTuc
                {
                    G = showChiTiet.Gio.HasValue ? showChiTiet.Gio.Value.Hour : 0,
                    P = showChiTiet.Gio.HasValue ? showChiTiet.Gio.Value.Minute : 0,
                    N = showChiTiet.Na,
                    D = showChiTiet.DTT,
                    K = showChiTiet.Ka,
                    H = showChiTiet.He,
                    T = showChiTiet.TQ,
                    BS = showChiTiet.BS,
                    DD = showChiTiet.DD,
                });
            }
            return saveData;
        }
        public static List<BangKeLocMauLienTuc> GetListData(MDB.MDBConnection _OracleConnection, decimal maquanly)
        {
            List<BangKeLocMauLienTuc> list = new List<BangKeLocMauLienTuc>();
            try
            {
                string sql = @"SELECT * FROM BangKeLocMauLienTuc where MaQuanLy = :MaQuanLy";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, _OracleConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", maquanly));
                MDB.MDBDataReader DataReader = Command.ExecuteReader();
                while (DataReader.Read())
                {
                    BangKeLocMauLienTuc data = new BangKeLocMauLienTuc();
                    data.ID = DataReader.GetLong("ID");
                    data.MaQuanLy = maquanly;
                    data.MaBenhNhan = DataReader["MaBenhNhan"].ToString();
                    data.HoTenBenhNhan = XemBenhAn._HanhChinhBenhNhan.TenBenhNhan;
                    data.Tuoi = XemBenhAn._HanhChinhBenhNhan.Tuoi;
                    data.GioiTinh = XemBenhAn._HanhChinhBenhNhan.GioiTinh.Description();
                    data.ChanDoan = DataReader["ChanDoan"].ToString();
                    data.PhuongThucChay = DataReader["PhuongThucChay"].ToString();
                    int tempInt = 0;
                    data.Lan = int.TryParse(DataReader["Lan"].ToString(), out tempInt) ? (int?)tempInt : null;
                    data.Ngay = DataReader.GetDate("Ngay");

                    string bangKeJson = DataReader["BangKe_1"].ToString();
                    if (DataReader["BangKe_2"] != DBNull.Value)
                        bangKeJson += DataReader["BangKe_2"].ToString();
                    List<SaveChiTietLocMauLienTuc> ketQuaSaves = JsonConvert.DeserializeObject<List<SaveChiTietLocMauLienTuc>>(bangKeJson);
                    data.BangKes = ConvertShowData(ketQuaSaves);

                    data.MayLoc = DataReader["MayLoc"].ToString();
                    data.QuaLoc = DataReader["QuaLoc"].ToString();
                    data.TocDoMauBF = DataReader["TocDoMauBF"].ToString();
                    data.TocDoMauUF = DataReader["TocDoMauUF"].ToString();
                    data.TruocMang = DataReader["TruocMang"].ToString();
                    data.SauMang = DataReader["SauMang"].ToString();
                    data.ThuocChongDong = DataReader["ThuocChongDong"].ToString();
                    data.Bolus = DataReader["Bolus"].ToString();
                    data.DuyTri = DataReader["DuyTri"].ToString();
                    data.TaiBienVaBienChung = DataReader["TaiBienVaBienChung"].ToString();

                    data.NguoiThucHien = DataReader["NguoiThucHien"].ToString();
                    data.MaNguoiThucHien = DataReader["MaNguoiThucHien"].ToString();

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
        public static bool InsertOrUpdate(MDB.MDBConnection MyConnection, ref BangKeLocMauLienTuc bangKe)
        {
            try
            {
                string sql = @"INSERT INTO BangKeLocMauLienTuc
                (
                    MAQUANLY,
                    MaBenhNhan,
                    ChanDoan,
                    NguoiThucHien,
                    MaNguoiThucHien,
                    PhuongThucChay,
                    Lan,
                    Ngay,
                    BangKe_1,
                    BangKe_2,
                    MayLoc,
                    QuaLoc,
                    TocDoMauBF,
                    TocDoMauUF,
                    TruocMang,
                    SauMang,
                    ThuocChongDong,
                    Bolus,
                    DuyTri,
                    TaiBienVaBienChung,
                    NGUOITAO,
                    NGUOISUA,
                    NGAYTAO,
                    NGAYSUA)  VALUES
                 (
				    :MAQUANLY,
                    :MaBenhNhan,
                    :ChanDoan,
                    :NguoiThucHien,
                    :MaNguoiThucHien,
                    :PhuongThucChay,
                    :Lan,
                    :Ngay,
                    :BangKe_1,
                    :BangKe_2,
                    :MayLoc,
                    :QuaLoc,
                    :TocDoMauBF,
                    :TocDoMauUF,
                    :TruocMang,
                    :SauMang,
                    :ThuocChongDong,
                    :Bolus,
                    :DuyTri,
                    :TaiBienVaBienChung,
                    :NGUOITAO,
                    :NGUOISUA,
                    :NGAYTAO,
                    :NGAYSUA
                 )  RETURNING ID INTO :ID";
                if (bangKe.ID != 0)
                {
                    sql = @"UPDATE BangKeLocMauLienTuc SET 
                    MAQUANLY = :MAQUANLY,
                    MaBenhNhan = :MaBenhNhan,
                    ChanDoan = :ChanDoan,
                    NguoiThucHien = :NguoiThucHien,
                    MaNguoiThucHien = :MaNguoiThucHien,
                    PhuongThucChay = :PhuongThucChay,
                    Lan = :Lan,
                    Ngay = :Ngay,
                    BangKe_1 = :BangKe_1,
                    BangKe_2 = :BangKe_2,
                    MayLoc = :MayLoc,
                    QuaLoc = :QuaLoc,
                    TocDoMauBF = :TocDoMauBF,
                    TocDoMauUF = :TocDoMauUF,
                    TruocMang = :TruocMang,
                    SauMang = :SauMang,
                    ThuocChongDong = :ThuocChongDong,
                    Bolus = :Bolus,
                    DuyTri = :DuyTri,
                    TaiBienVaBienChung = :TaiBienVaBienChung,
                    NGUOISUA = :NGUOISUA,
                    NGAYSUA = :NGAYSUA
                    WHERE ID = " + bangKe.ID;
                }
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MAQUANLY", bangKe.MaQuanLy));
                Command.Parameters.Add(new MDB.MDBParameter("MaBenhNhan", bangKe.MaBenhNhan));
                Command.Parameters.Add(new MDB.MDBParameter("ChanDoan", bangKe.ChanDoan));
                Command.Parameters.Add(new MDB.MDBParameter("NguoiThucHien", bangKe.NguoiThucHien));
                Command.Parameters.Add(new MDB.MDBParameter("MaNguoiThucHien", bangKe.MaNguoiThucHien));
                Command.Parameters.Add(new MDB.MDBParameter("PhuongThucChay", bangKe.PhuongThucChay));
                Command.Parameters.Add(new MDB.MDBParameter("Lan", bangKe.Lan));
                Command.Parameters.Add(new MDB.MDBParameter("Ngay", bangKe.Ngay));
                string jsonBangKes = JsonConvert.SerializeObject(ConvertSaveData(bangKe.BangKes));
                List<string> listJson = Common.SplitByLength(jsonBangKes, 3999).ToList();
                Command.Parameters.Add(new MDB.MDBParameter("BangKe_1", listJson[0]));
                Command.Parameters.Add(new MDB.MDBParameter("BangKe_2", listJson.Count > 1 ? listJson[1] : null));
                Command.Parameters.Add(new MDB.MDBParameter("MayLoc", bangKe.MayLoc));
                Command.Parameters.Add(new MDB.MDBParameter("QuaLoc", bangKe.QuaLoc));
                Command.Parameters.Add(new MDB.MDBParameter("TocDoMauBF", bangKe.TocDoMauBF));
                Command.Parameters.Add(new MDB.MDBParameter("TocDoMauUF", bangKe.TocDoMauUF));
                Command.Parameters.Add(new MDB.MDBParameter("TruocMang", bangKe.TruocMang));
                Command.Parameters.Add(new MDB.MDBParameter("SauMang", bangKe.SauMang));
                Command.Parameters.Add(new MDB.MDBParameter("ThuocChongDong", bangKe.ThuocChongDong));
                Command.Parameters.Add(new MDB.MDBParameter("Bolus", bangKe.Bolus));
                Command.Parameters.Add(new MDB.MDBParameter("DuyTri", bangKe.DuyTri));
                Command.Parameters.Add(new MDB.MDBParameter("TaiBienVaBienChung", bangKe.TaiBienVaBienChung));
                Command.Parameters.Add(new MDB.MDBParameter("NGUOISUA", bangKe.NguoiSua));
                Command.Parameters.Add(new MDB.MDBParameter("NGAYSUA", bangKe.NgaySua));
                if (bangKe.ID == 0)
                {
                    Command.Parameters.Add(new MDB.MDBParameter("ID", bangKe.ID));
                    Command.Parameters.Add(new MDB.MDBParameter("NGUOITAO", bangKe.NguoiTao));
                    Command.Parameters.Add(new MDB.MDBParameter("NGAYTAO", bangKe.NgayTao));
                }
                Command.BindByName = true;
                int n = Command.ExecuteNonQuery();
                if (bangKe.ID == 0)
                {
                    long nextval = Convert.ToInt64((Command.Parameters["ID"] as MDB.MDBParameter).Value);
                    bangKe.ID = nextval;
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
                string sql = "DELETE FROM BangKeLocMauLienTuc WHERE ID = :ID";
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
            log.LogConfig();
            string sql = @"SELECT
                B.MAQUANLY,
                B.MaBenhNhan,
                B.ChanDoan,
                B.NguoiThucHien,
                B.MaNguoiThucHien,
                B.PhuongThucChay,
                B.Lan,
                B.Ngay,
                B.MayLoc,
                B.QuaLoc,
                B.TocDoMauBF,
                B.TocDoMauUF,
                B.TruocMang,
                B.SauMang,
                B.ThuocChongDong,
                B.Bolus,
                B.DuyTri,
                B.TaiBienVaBienChung
            FROM
                BangKeLocMauLienTuc B
            WHERE
                ID = " + id;

            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
            MDB.MDBDataAdapter adt = new MDB.MDBDataAdapter(Command);
            var ds = new DataSet();

            adt.Fill(ds, "BK");

            ds.Tables[0].AddColumn("TenBenhNhan", typeof(string));
            ds.Tables[0].AddColumn("Tuoi", typeof(string));
            ds.Tables[0].AddColumn("GioiTinh", typeof(int));
            ds.Tables[0].AddColumn("SOYTE", typeof(string));
            ds.Tables[0].AddColumn("BENHVIEN", typeof(string));
            ds.Tables[0].AddColumn("KHOA", typeof(string));

            ds.Tables[0].Rows[0]["TenBenhNhan"] = XemBenhAn._HanhChinhBenhNhan.TenBenhNhan;
            ds.Tables[0].Rows[0]["Tuoi"] = XemBenhAn._HanhChinhBenhNhan.Tuoi;
            ds.Tables[0].Rows[0]["GioiTinh"] = (int)XemBenhAn._HanhChinhBenhNhan.GioiTinh;
            ds.Tables[0].Rows[0]["SOYTE"] = XemBenhAn._HanhChinhBenhNhan.SoYTe;
            ds.Tables[0].Rows[0]["BENHVIEN"] = XemBenhAn._HanhChinhBenhNhan.BenhVien;
            ds.Tables[0].Rows[0]["KHOA"] = XemBenhAn._ThongTinDieuTri.Khoa;

            ds.Tables[0].AddColumn("TONG_NA", typeof(string));
            ds.Tables[0].AddColumn("TONG_DTT", typeof(string));
            ds.Tables[0].AddColumn("TONG_KA", typeof(string));
            ds.Tables[0].AddColumn("TONG_HE", typeof(string));
            ds.Tables[0].AddColumn("TONG_TQ", typeof(string));

            sql = @"SELECT
               B.BangKe_1, B.BangKe_2
            FROM
                BangKeLocMauLienTuc B
                
            WHERE
                ID = " + id;

            Command = new MDB.MDBCommand(sql, MyConnection);
            MDB.MDBDataReader DataReader = Command.ExecuteReader();

            List<SaveChiTietLocMauLienTuc> saveDatas = new List<SaveChiTietLocMauLienTuc>();
            while (DataReader.Read())
            {
                string bangKeJson = DataReader["BangKe_1"].ToString();
                if (DataReader["BangKe_2"] != DBNull.Value)
                    bangKeJson += DataReader["BangKe_2"].ToString();
                saveDatas = JsonConvert.DeserializeObject<List<SaveChiTietLocMauLienTuc>>(bangKeJson).OrderBy(s => s.G).ThenBy(z => z.P).ToList();
                break;
            }
            double tong_NA = 0;
            double tong_DTT = 0;
            double tong_KA = 0;
            double tong_HE = 0;
            double tong_TQ = 0;

            DataTable ChiTiet = new DataTable("CT");
            ChiTiet.Columns.Add("GIO", typeof(string));
            ChiTiet.Columns.Add("NA", typeof(string));
            ChiTiet.Columns.Add("DTT", typeof(string));
            ChiTiet.Columns.Add("KA", typeof(string));
            ChiTiet.Columns.Add("HE", typeof(string));
            ChiTiet.Columns.Add("TQ", typeof(string));
            ChiTiet.Columns.Add("BS", typeof(string));
            ChiTiet.Columns.Add("DD", typeof(string));
            double tempDouble = 0;
            foreach(SaveChiTietLocMauLienTuc chiTiet in saveDatas)
            {
                string gio = (chiTiet.G > 9 ? chiTiet.G.ToString() : "0" + chiTiet.G) + ":" + (chiTiet.P > 9 ? chiTiet.P.ToString() : "0" + chiTiet.P);
                string BacSy = NhanVienFunc.ListNhanVien.Exists(x => x.MaNhanVien.Equals(chiTiet.BS)) ? NhanVienFunc.ListNhanVien.Find(x => x.MaNhanVien.Equals(chiTiet.BS)).HoVaTen : "";
                string DieuDuong = NhanVienFunc.ListNhanVien.Exists(x => x.MaNhanVien.Equals(chiTiet.DD)) ? NhanVienFunc.ListNhanVien.Find(x => x.MaNhanVien.Equals(chiTiet.DD)).HoVaTen : "";
                ChiTiet.Rows.Add(
                    gio,
                    chiTiet.N,
                    chiTiet.D,
                    chiTiet.K,
                    chiTiet.H,
                    chiTiet.T,
                    BacSy,
                    DieuDuong) ;
                try 
                {
                    tong_NA += double.TryParse(chiTiet.N, out tempDouble) ? tempDouble : 0;
                }
                catch {}
                try
                {
                    tong_DTT += double.TryParse(chiTiet.D, out tempDouble) ? tempDouble : 0;
                }
                catch { }
                try
                {
                    tong_KA += double.TryParse(chiTiet.K, out tempDouble) ? tempDouble : 0;
                }
                catch { }
                try
                {
                    tong_HE += double.TryParse(chiTiet.H, out tempDouble) ? tempDouble : 0;
                }
                catch { }
                try
                {
                    tong_TQ += double.TryParse(chiTiet.T, out tempDouble) ? tempDouble : 0;
                }
                catch { }
            }
            ds.Tables[0].Rows[0]["TONG_NA"] = tong_NA.ToString();
            ds.Tables[0].Rows[0]["TONG_DTT"] = tong_DTT.ToString();
            ds.Tables[0].Rows[0]["TONG_KA"] = tong_KA.ToString();
            ds.Tables[0].Rows[0]["TONG_HE"] = tong_HE.ToString();
            ds.Tables[0].Rows[0]["TONG_TQ"] = tong_TQ.ToString();
            ds.Tables.Add(ChiTiet);
            log.Info("dang-tung : row of table 0: " + ds.Tables[0].Rows.Count);
            log.Info("dang-tung : row of table 1: " + ds.Tables[1].Rows.Count);
            return ds;

        } 
    }
}
