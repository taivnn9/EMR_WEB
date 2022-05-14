using EMR.KyDienTu;
using Newtonsoft.Json;
using PMS.Access;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Linq;

namespace EMR_MAIN.DATABASE.Other
{
    public class ChiTietThayHuyetTuong
    {
        [MoTaDuLieu("Giờ")]
        public DateTime? Gio { get; set; }
        [MoTaDuLieu("NaCl 0.9%")]
        public string Na { get; set; }
        [MoTaDuLieu("Huyết tương/Albumin")]
        public string Al { get; set; }
        [MoTaDuLieu("Calci")]
        public string Ca { get; set; }
        [MoTaDuLieu("heparin")]
        public string He { get; set; }
        [MoTaDuLieu("Thay quả")]
        public string TQ { get; set; }
        [MoTaDuLieu("Bác sĩ")]
        public string BS { get; set; }
        [MoTaDuLieu("Điều dưỡng")]
        public string DD { get; set; }
    }
    public class SaveChiTietThayHuyetTuong
    {
        [MoTaDuLieu("Giờ")]
        public int G { get; set; }
        [MoTaDuLieu("Phút")]
        public int P { get; set; }
        [MoTaDuLieu("NaCl 0.9%")]
        public string N { get; set; }
        [MoTaDuLieu("Huyết tương/Albumin")]
        public string A { get; set; }
        [MoTaDuLieu("Calci")]
        public string C { get; set; }
        [MoTaDuLieu("heparin")]
        public string H { get; set; }
        [MoTaDuLieu("Thay quả")]
        public string T { get; set; }
        [MoTaDuLieu("Bác sĩ")]
        public string BS { get; set; }
        [MoTaDuLieu("Điều dưỡng")]
        public string DD { get; set; }
    }
    public class BangKeThayHuyetTuong : ThongTinKy
    {
        public BangKeThayHuyetTuong()
        {
            TableName = "BangKeThayHuyetTuong";
            TablePrimaryKeyName = "ID";
            IDMauPhieu = (int)DanhMucPhieu.BKTHT;
            TenMauPhieu = DanhMucPhieu.BKTHT.Description();
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
        [MoTaDuLieu("Lần chạy thứ bao nhiêu")]
        public int? Lan { get; set; }
        [MoTaDuLieu("Ngày chạy")]
        public DateTime Ngay { get; set; }
        public ObservableCollection<ChiTietThayHuyetTuong> BangKes { get; set; }
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
    public class BangKeThayHuyetTuongFunc
    {
        public const string TableName = "BangKeThayHuyetTuong";
        public const string TablePrimaryKeyName = "ID";
        public static ObservableCollection<ChiTietThayHuyetTuong> ConvertShowData(List<SaveChiTietThayHuyetTuong> saveDatas)
        {
            ObservableCollection<ChiTietThayHuyetTuong> showData = new ObservableCollection<ChiTietThayHuyetTuong>();
            foreach (SaveChiTietThayHuyetTuong saveChiTiet in saveDatas)
            {
                DateTime tempDate = DateTime.Now;
                TimeSpan ts = new TimeSpan(saveChiTiet.G, saveChiTiet.P, 0);
                tempDate = tempDate.Date + ts;
                showData.Add(new ChiTietThayHuyetTuong
                {
                    Gio = tempDate,
                    Na = saveChiTiet.N,
                    Al = saveChiTiet.A,
                    Ca = saveChiTiet.C,
                    He = saveChiTiet.H,
                    TQ = saveChiTiet.T,
                    BS = saveChiTiet.BS,
                    DD = saveChiTiet.DD,
                });
            }
            return showData;
        }
        public static List<SaveChiTietThayHuyetTuong> ConvertSaveData(ObservableCollection<ChiTietThayHuyetTuong> showDatas)
        {
            List<SaveChiTietThayHuyetTuong> saveData = new List<SaveChiTietThayHuyetTuong>();
            foreach (ChiTietThayHuyetTuong showChiTiet in showDatas)
            {
                saveData.Add(new SaveChiTietThayHuyetTuong
                {
                    G = showChiTiet.Gio.HasValue ? showChiTiet.Gio.Value.Hour : 0,
                    P = showChiTiet.Gio.HasValue ? showChiTiet.Gio.Value.Minute : 0,
                    N = showChiTiet.Na,
                    A = showChiTiet.Al,
                    C = showChiTiet.Ca,
                    H = showChiTiet.He,
                    T = showChiTiet.TQ,
                    BS = showChiTiet.BS,
                    DD = showChiTiet.DD,
                });
            }
            return saveData;
        }
        public static List<BangKeThayHuyetTuong> GetListData(MDB.MDBConnection _OracleConnection, decimal maquanly)
        {
            List<BangKeThayHuyetTuong> list = new List<BangKeThayHuyetTuong>();
            try
            {
                string sql = @"SELECT * FROM BangKeThayHuyetTuong where MaQuanLy = :MaQuanLy";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, _OracleConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", maquanly));
                MDB.MDBDataReader DataReader = Command.ExecuteReader();
                while (DataReader.Read())
                {
                    BangKeThayHuyetTuong data = new BangKeThayHuyetTuong();
                    data.ID = Convert.ToInt64(DataReader.GetLong("ID").ToString());
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
                    List<SaveChiTietThayHuyetTuong> ketQuaSaves = JsonConvert.DeserializeObject<List<SaveChiTietThayHuyetTuong>>(bangKeJson);
                    data.BangKes = ConvertShowData(ketQuaSaves);

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
        public static bool InsertOrUpdate(MDB.MDBConnection MyConnection, ref BangKeThayHuyetTuong bangKe)
        {
            try
            {
                string sql = @"INSERT INTO BangKeThayHuyetTuong
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
                    :NGUOITAO,
                    :NGUOISUA,
                    :NGAYTAO,
                    :NGAYSUA
                 )  RETURNING ID INTO :ID";
                if (bangKe.ID != 0)
                {
                    sql = @"UPDATE BangKeThayHuyetTuong SET 
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
                string sql = "DELETE FROM BangKeThayHuyetTuong WHERE ID = :ID";
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
                B.MAQUANLY,
                B.MaBenhNhan,
                B.ChanDoan,
                B.NguoiThucHien,
                B.MaNguoiThucHien,
                B.PhuongThucChay,
                B.Lan,
                B.Ngay
            FROM
                BangKeThayHuyetTuong B
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

            ds.Tables[0].AddColumn("TONG_NA", typeof(double));
            ds.Tables[0].AddColumn("TONG_AL", typeof(double));
            ds.Tables[0].AddColumn("TONG_CA", typeof(double));
            ds.Tables[0].AddColumn("TONG_HE", typeof(double));
            ds.Tables[0].AddColumn("TONG_TQ", typeof(double));

            sql = @"SELECT
               B.BangKe_1, B.BangKe_2
            FROM
                BangKeThayHuyetTuong B
                
            WHERE
                ID = " + id;

            Command = new MDB.MDBCommand(sql, MyConnection);
            MDB.MDBDataReader DataReader = Command.ExecuteReader();

            List<SaveChiTietThayHuyetTuong> saveDatas = new List<SaveChiTietThayHuyetTuong>();
            while (DataReader.Read())
            {
                string bangKeJson = DataReader["BangKe_1"].ToString();
                if (DataReader["BangKe_2"] != DBNull.Value)
                    bangKeJson += DataReader["BangKe_2"].ToString();
                saveDatas = JsonConvert.DeserializeObject<List<SaveChiTietThayHuyetTuong>>(bangKeJson).OrderBy(s => s.G).ThenBy(z => z.P).ToList();
                break;
            }
            double tong_NA = 0;
            double tong_AL = 0;
            double tong_CA = 0;
            double tong_HE = 0;
            double tong_TQ = 0;

            DataTable ChiTiet = new DataTable("CT");
            ChiTiet.Columns.Add("GIO");
            ChiTiet.Columns.Add("NA");
            ChiTiet.Columns.Add("AL");
            ChiTiet.Columns.Add("CA");
            ChiTiet.Columns.Add("HE");
            ChiTiet.Columns.Add("TQ");
            ChiTiet.Columns.Add("BS");
            ChiTiet.Columns.Add("DD");
            double tempDouble = 0;
            foreach(SaveChiTietThayHuyetTuong chiTiet in saveDatas)
            {
                string gio = (chiTiet.G > 9 ? chiTiet.G.ToString() : "0" + chiTiet.G) + ":" + (chiTiet.P > 9 ? chiTiet.P.ToString() : "0" + chiTiet.P);
                string BacSy = NhanVienFunc.ListNhanVien.Exists(x => x.MaNhanVien.Equals(chiTiet.BS)) ? NhanVienFunc.ListNhanVien.Find(x => x.MaNhanVien.Equals(chiTiet.BS)).HoVaTen : "";
                string DieuDuong = NhanVienFunc.ListNhanVien.Exists(x => x.MaNhanVien.Equals(chiTiet.DD)) ? NhanVienFunc.ListNhanVien.Find(x => x.MaNhanVien.Equals(chiTiet.DD)).HoVaTen : "";
                ChiTiet.Rows.Add(
                    gio,
                    chiTiet.N,
                    chiTiet.A,
                    chiTiet.C,
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
                    tong_AL += double.TryParse(chiTiet.A, out tempDouble) ? tempDouble : 0;
                }
                catch { }
                try
                {
                    tong_CA += double.TryParse(chiTiet.C, out tempDouble) ? tempDouble : 0;
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
            ds.Tables[0].Rows[0]["TONG_NA"] = tong_NA;
            ds.Tables[0].Rows[0]["TONG_AL"] = tong_AL;
            ds.Tables[0].Rows[0]["TONG_CA"] = tong_CA;
            ds.Tables[0].Rows[0]["TONG_HE"] = tong_HE;
            ds.Tables[0].Rows[0]["TONG_TQ"] = tong_TQ;

            ds.Tables.Add(ChiTiet);

            return ds;

        } 
    }
}
