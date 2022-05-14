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
    public class ChiTietTheoDoiLocMau
    {
        [MoTaDuLieu("Ngày")]
        public DateTime? Ngay { get; set; }
        [MoTaDuLieu("Giờ")]
        public DateTime? Gio { get; set; }
        [MoTaDuLieu("Mạch/SpO2")]
        public string MachSpo2 { get; set; }
        [MoTaDuLieu("Huyết áp")]
		public string HA { get; set; }
        [MoTaDuLieu("Blood")]
        public string Blood { get; set; }
        [MoTaDuLieu("Dịch thay thế")]
        public string DichThayThe { get; set; }
        [MoTaDuLieu("Dialyat %")]
        public double? Dialyat { get; set; }
        [MoTaDuLieu("Heparin")]
        public string Heparin { get; set; }
        [MoTaDuLieu("PA")]
        public string PA { get; set; }
        [MoTaDuLieu("Filter")]
        public string Filter { get; set; }
        [MoTaDuLieu("TMP")]
        public string TMP { get; set; }
        [MoTaDuLieu("PV")]
        public string PV { get; set; }
        [MoTaDuLieu("UF")]
        public string UF { get; set; }
    }
    public class SaveChiTietTheoDoiLocMau
    {
        [MoTaDuLieu("Ngày/giờ")]
        public DateTime? NgayGio { get; set; }
        [MoTaDuLieu("Mạch/SpO2")]
        public string MS { get; set; }
        [MoTaDuLieu("Huyết áp")]
		public string HA { get; set; }
        [MoTaDuLieu("Blood")]
        public string B { get; set; }
        [MoTaDuLieu("Dịch thay thế")]
        public string DTT { get; set; }
        [MoTaDuLieu("Dialyat %")]
        public double? Di { get; set; }
        [MoTaDuLieu("Heparin")]
        public string He { get; set; }
        [MoTaDuLieu("PAc")]
        public string PA { get; set; }
        [MoTaDuLieu("Filter")]
        public string Fi { get; set; }
        [MoTaDuLieu("TMP")]
        public string TMP { get; set; }
        [MoTaDuLieu("PV")]
        public string PV { get; set; }
        [MoTaDuLieu("UF")]
        public string UF { get; set; }
    }
    public class BangTheoDoiLocMau : ThongTinKy
    {
        public BangTheoDoiLocMau()
        {
            TableName = "BangTheoDoiLocMau";
            TablePrimaryKeyName = "ID";
            IDMauPhieu = (int)DanhMucPhieu.BTDLM;
            TenMauPhieu = DanhMucPhieu.BTDLM.Description();
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
        [MoTaDuLieu("CVVH")]
        public string CVVH { get; set; }
        [MoTaDuLieu("Máy")]
        public string May { get; set; }
        [MoTaDuLieu("Lần")]
        public int? Lan { get; set; }
        [MoTaDuLieu("Ngày")]
        public DateTime Ngay { get; set; }
        [MoTaDuLieu("Bảng kê chi thiết theo dõi lọc máu")]
        public ObservableCollection<ChiTietTheoDoiLocMau> BangKes { get; set; }
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
    public class BangTheoDoiLocMauFunc
    {
        public const string TableName = "BangTheoDoiLocMau";
        public const string TablePrimaryKeyName = "ID";
        public static ObservableCollection<ChiTietTheoDoiLocMau> ConvertShowData(List<SaveChiTietTheoDoiLocMau> saveDatas)
        {
            ObservableCollection<ChiTietTheoDoiLocMau> showData = new ObservableCollection<ChiTietTheoDoiLocMau>();
            foreach (SaveChiTietTheoDoiLocMau saveChiTiet in saveDatas)
            {
                showData.Add(new ChiTietTheoDoiLocMau
                {
                    Ngay = saveChiTiet.NgayGio,
                    Gio = saveChiTiet.NgayGio,
                    MachSpo2 = saveChiTiet.MS,
                    HA = saveChiTiet.HA,
                    Blood = saveChiTiet.B,
                    DichThayThe = saveChiTiet.DTT,
                    Dialyat = saveChiTiet.Di,
                    Heparin = saveChiTiet.He,
                    PA = saveChiTiet.PA,
                    Filter = saveChiTiet.Fi,
                    TMP = saveChiTiet.TMP,
                    PV = saveChiTiet.PV,
                    UF = saveChiTiet.UF,
                });
            }
            return showData;
        }
        public static List<SaveChiTietTheoDoiLocMau> ConvertSaveData(ObservableCollection<ChiTietTheoDoiLocMau> showDatas)
        {
            List<SaveChiTietTheoDoiLocMau> saveData = new List<SaveChiTietTheoDoiLocMau>();
            foreach (ChiTietTheoDoiLocMau showChiTiet in showDatas)
            {
                var Ngay = showChiTiet.Ngay.HasValue ? showChiTiet.Ngay.Value.Date.Add(new TimeSpan(0, 0, 0)) : DateTime.Now.Date.Add(new TimeSpan(0, 0, 0));
                var Gio = showChiTiet.Gio.HasValue ? showChiTiet.Gio.Value.TimeOfDay : DateTime.Now.TimeOfDay;
                saveData.Add(new SaveChiTietTheoDoiLocMau
                {
                    NgayGio = Ngay + Gio,
                    MS = showChiTiet.MachSpo2,
                    HA = showChiTiet.HA,
                    B = showChiTiet.Blood,
                    DTT = showChiTiet.DichThayThe,
                    Di = showChiTiet.Dialyat,
                    He = showChiTiet.Heparin,
                    PA = showChiTiet.PA,
                    Fi = showChiTiet.Filter,
                    TMP = showChiTiet.TMP,
                    PV = showChiTiet.PV,
                    UF = showChiTiet.UF
                }) ;
            }
            return saveData;
        }
        public static List<BangTheoDoiLocMau> GetListData(MDB.MDBConnection _OracleConnection, decimal maquanly)
        {
            List<BangTheoDoiLocMau> list = new List<BangTheoDoiLocMau>();
            try
            {
                string sql = @"SELECT * FROM BangTheoDoiLocMau where MaQuanLy = :MaQuanLy";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, _OracleConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", maquanly));
                MDB.MDBDataReader DataReader = Command.ExecuteReader();
                while (DataReader.Read())
                {
                    BangTheoDoiLocMau data = new BangTheoDoiLocMau();
                    data.ID = Convert.ToInt64(DataReader.GetLong("ID").ToString());
                    data.MaQuanLy = maquanly;
                    data.MaBenhNhan = DataReader["MaBenhNhan"].ToString();
                    data.HoTenBenhNhan = XemBenhAn._HanhChinhBenhNhan.TenBenhNhan;
                    data.Tuoi = XemBenhAn._HanhChinhBenhNhan.Tuoi;
                    data.GioiTinh = XemBenhAn._HanhChinhBenhNhan.GioiTinh.Description();
                    data.ChanDoan = DataReader["ChanDoan"].ToString();
                    data.PhuongThucChay = DataReader["PhuongThucChay"].ToString();
                    data.CVVH = DataReader["CVVH"].ToString();
                    data.May = DataReader["May"].ToString();
                    int tempInt = 0;
                    data.Lan = int.TryParse(DataReader["Lan"].ToString(), out tempInt) ? (int?)tempInt : null;
                    data.Ngay = DataReader.GetDate("Ngay");

                    string bangKeJson = DataReader["BangKe_1"].ToString();
                    if (DataReader["BangKe_2"] != DBNull.Value)
                        bangKeJson += DataReader["BangKe_2"].ToString();
                    if (DataReader["BangKe_3"] != DBNull.Value)
                        bangKeJson += DataReader["BangKe_3"].ToString();

                    List<SaveChiTietTheoDoiLocMau> ketQuaSaves = JsonConvert.DeserializeObject<List<SaveChiTietTheoDoiLocMau>>(bangKeJson);
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
        public static bool InsertOrUpdate(MDB.MDBConnection MyConnection, ref BangTheoDoiLocMau bangKe)
        {
            try
            {
                string sql = @"INSERT INTO BangTheoDoiLocMau
                (
                    MAQUANLY,
                    MaBenhNhan,
                    ChanDoan,
                    NguoiThucHien,
                    MaNguoiThucHien,
                    PhuongThucChay,
                    CVVH,
                    May,
                    Lan,
                    Ngay,
                    BangKe_1,
                    BangKe_2,
                    BangKe_3,
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
                    :CVVH,
                    :May,
                    :Lan,
                    :Ngay,
                    :BangKe_1,
                    :BangKe_2,
                    :BangKe_3,
                    :NGUOITAO,
                    :NGUOISUA,
                    :NGAYTAO,
                    :NGAYSUA
                 )  RETURNING ID INTO :ID";
                if (bangKe.ID != 0)
                {
                    sql = @"UPDATE BangTheoDoiLocMau SET 
                    MAQUANLY = :MAQUANLY,
                    MaBenhNhan = :MaBenhNhan,
                    ChanDoan = :ChanDoan,
                    NguoiThucHien = :NguoiThucHien,
                    MaNguoiThucHien = :MaNguoiThucHien,
                    PhuongThucChay = :PhuongThucChay,
                    CVVH = :CVVH,
                    May = :May,
                    Lan = :Lan,
                    Ngay = :Ngay,
                    BangKe_1 = :BangKe_1,
                    BangKe_2 = :BangKe_2,
                    BangKe_3 = :BangKe_3,
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
                Command.Parameters.Add(new MDB.MDBParameter("CVVH", bangKe.CVVH));
                Command.Parameters.Add(new MDB.MDBParameter("May", bangKe.May));
                Command.Parameters.Add(new MDB.MDBParameter("Lan", bangKe.Lan));
                Command.Parameters.Add(new MDB.MDBParameter("Ngay", bangKe.Ngay));
                string jsonBangKes = JsonConvert.SerializeObject(ConvertSaveData(bangKe.BangKes));
                List<string> listJson = new List<string>();
                for (int i = 0; i < jsonBangKes.Length; i += 3999)
                {
                    if ((i + 3999) < jsonBangKes.Length)
                        listJson.Add(jsonBangKes.Substring(i, 3999));
                    else
                        listJson.Add(jsonBangKes.Substring(i));
                }
                Command.Parameters.Add(new MDB.MDBParameter("BangKe_1", listJson[0]));
                Command.Parameters.Add(new MDB.MDBParameter("BangKe_2", listJson.Count > 1 ? listJson[1] : null));
                Command.Parameters.Add(new MDB.MDBParameter("BangKe_3", listJson.Count > 2 ? listJson[2] : null));

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
                string sql = "DELETE FROM BangTheoDoiLocMau WHERE ID = :ID";
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
                B.CVVH,
                B.May,
                B.Lan,
                B.Ngay
            FROM
                BangTheoDoiLocMau B
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
            ds.Tables[0].AddColumn("MaBenhAn", typeof(string));

            ds.Tables[0].Rows[0]["TenBenhNhan"] = XemBenhAn._HanhChinhBenhNhan.TenBenhNhan;
            ds.Tables[0].Rows[0]["Tuoi"] = XemBenhAn._HanhChinhBenhNhan.Tuoi;
            ds.Tables[0].Rows[0]["GioiTinh"] = (int) XemBenhAn._HanhChinhBenhNhan.GioiTinh;
            ds.Tables[0].Rows[0]["SOYTE"] = XemBenhAn._HanhChinhBenhNhan.SoYTe;
            ds.Tables[0].Rows[0]["BENHVIEN"] = XemBenhAn._HanhChinhBenhNhan.BenhVien;
            ds.Tables[0].Rows[0]["KHOA"] = XemBenhAn._ThongTinDieuTri.Khoa;
            ds.Tables[0].Rows[0]["MaBenhAn"] = XemBenhAn._ThongTinDieuTri.MaBenhAn;

            sql = @"SELECT
               B.BangKe_1, B.BangKe_2, B.BangKe_3
            FROM
                BangTheoDoiLocMau B
                
            WHERE
                ID = " + id;

            Command = new MDB.MDBCommand(sql, MyConnection);
            MDB.MDBDataReader DataReader = Command.ExecuteReader();

            List<SaveChiTietTheoDoiLocMau> saveDatas = new List<SaveChiTietTheoDoiLocMau>();
            while (DataReader.Read())
            {
                string bangKeJson = DataReader["BangKe_1"].ToString();
                if (DataReader["BangKe_2"] != DBNull.Value)
                    bangKeJson += DataReader["BangKe_2"].ToString();
                if (DataReader["BangKe_3"] != DBNull.Value)
                    bangKeJson += DataReader["BangKe_3"].ToString();
                saveDatas = JsonConvert.DeserializeObject<List<SaveChiTietTheoDoiLocMau>>(bangKeJson).OrderBy(s => s.NgayGio).ToList();
                break;
            }

            DataTable ChiTiet = new DataTable("CT");
            ChiTiet.Columns.Add("NgayGio", typeof(string));
            ChiTiet.Columns.Add("MS", typeof(string));
            ChiTiet.Columns.Add("HA", typeof(string));
            ChiTiet.Columns.Add("Blood", typeof(string));
            ChiTiet.Columns.Add("DichThayThe", typeof(string));
            ChiTiet.Columns.Add("Dialyat", typeof(string));
            ChiTiet.Columns.Add("Heparin", typeof(string));
            ChiTiet.Columns.Add("PA", typeof(string));
            ChiTiet.Columns.Add("Filter", typeof(string));
            ChiTiet.Columns.Add("TMP", typeof(string));
            ChiTiet.Columns.Add("PV", typeof(string));
            ChiTiet.Columns.Add("UF", typeof(string));
            foreach(SaveChiTietTheoDoiLocMau ct in saveDatas)
            {
                ChiTiet.Rows.Add(ct.NgayGio.HasValue ? ct.NgayGio.Value.ToString("HH:mm dd/MM/yyyy") : "",
                    ct.MS,
                    ct.HA,
                    ct.B,
                    ct.DTT,
                    ct.Di.HasValue ? ct.Di.Value.ToString() : "",
                    ct.He,
                    ct.PA,
                    ct.Fi,
                    ct.TMP,
                    ct.PV,
                    ct.UF
                    );
            }


            ds.Tables.Add(ChiTiet);

            return ds;

        } 
    }
}
