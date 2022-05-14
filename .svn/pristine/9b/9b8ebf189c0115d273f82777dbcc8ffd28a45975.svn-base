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
    public class ChiTietPhieuTruyenMauLamSang
    {
        public DateTime? Ngay { get; set; }
        public DateTime? Gio { get; set; }
        public double? TocDoTruyen { get; set; }
        public string MauSacDa { get; set; }
        public int? NhipTho { get; set; }
        public int? Mach { get; set; }
        [MoTaDuLieu("Huyết áp")]
		public string HuyetAp { get; set; }
        public double? ThanNhiet { get; set; }
        public string DienBienKhac { get; set; }
    }
    public class SaveChiTietPhieuTruyenMauLamSang
    {
        public DateTime? Ng { get; set; }
        public double? TDT { get; set; }
        public string MSD { get; set; }
        public int? NT { get; set; }
        public int? M { get; set; }
        [MoTaDuLieu("Huyết áp")]
		public string HA { get; set; }
        public double? TN { get; set; }
        public string DBK { get; set; }
    }
    public class PhieuTruyenMauLamSang : ThongTinKy
    {
        public PhieuTruyenMauLamSang()
        {
            TableName = "PhieuTruyenMauLamSang";
            TablePrimaryKeyName = "ID";
            IDMauPhieu = (int)DanhMucPhieu.PTMLS;
            TenMauPhieu = DanhMucPhieu.PTMLS.Description();
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
        [MoTaDuLieu("Giường")]
		public string Giuong { get; set; }
        [MoTaDuLieu("Chẩn đoán bệnh")]
		public string ChanDoan { get; set; }
        public string NhomMauBenhNhan { get; set; }
        public string LoaiChePham { get; set; }
        public int? LanTruyenMauThu { get; set; }
        public string DinhNhomDonViMau { get; set; }
        public string DinhNhomNguoiNhan { get; set; }
        public string PhanUngCheo { get; set; }
        public DateTime? BatDauTruyenHoi { get; set; }
        public ObservableCollection<ChiTietTruyenMauLamSang> BangTheoDois { get; set; }
        public DateTime? NgungTruyenHoi { get; set; }
        public string SoLuongMauThucTe { get; set; }
        public string SoDonVi { get; set; }
        public string LoaiTheTich { get; set; }
        public string TongSoLuong { get; set; }
        public string NhanXet { get; set; }
        [MoTaDuLieu("Bác sỹ")]
		public string BacSy { get; set; }
        [MoTaDuLieu("Mã bác sỹ")]
		public string MaBacSy { get; set; }
        [MoTaDuLieu("Họ tên điều dưỡng")]
		public string DieuDuong { get; set; }
        [MoTaDuLieu("Mã điều dưỡng")]
		public string MaDieuDuong { get; set; }
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
    public class PhieuTruyenMauLamSangFunc
    {
        public const string TableName = "PhieuTruyenMauLamSang";
        public const string TablePrimaryKeyName = "ID";
        public static ObservableCollection<ChiTietTruyenMauLamSang> ConvertShowData(List<SaveChiTietTruyenMauLamSang> saveDatas)
        {
            ObservableCollection<ChiTietTruyenMauLamSang> showData = new ObservableCollection<ChiTietTruyenMauLamSang>();
            foreach (SaveChiTietTruyenMauLamSang saveChiTiet in saveDatas)
            {
                showData.Add(new ChiTietTruyenMauLamSang
                {
                    Ngay = saveChiTiet.Ng,
                    Gio = saveChiTiet.Ng,
                    TocDoTruyen = saveChiTiet.TDT,
                    MauSacDa = saveChiTiet.MSD,
                    NhipTho = saveChiTiet.NT,
                    Mach = saveChiTiet.M,
                    HuyetAp = saveChiTiet.HA,
                    ThanNhiet = saveChiTiet.TN,
                    DienBienKhac = saveChiTiet.DBK
                });
            }
            return showData;
        }
        public static List<SaveChiTietTruyenMauLamSang> ConvertSaveData(ObservableCollection<ChiTietTruyenMauLamSang> showDatas)
        {
            List<SaveChiTietTruyenMauLamSang> saveData = new List<SaveChiTietTruyenMauLamSang>();
            foreach (ChiTietTruyenMauLamSang showChiTiet in showDatas)
            {
                var Ngay = showChiTiet.Ngay.HasValue ? showChiTiet.Ngay.Value.Date.Add(new TimeSpan(0, 0, 0)) : DateTime.Now.Date.Add(new TimeSpan(0, 0, 0));
                var Gio = showChiTiet.Gio.HasValue ? showChiTiet.Gio.Value.TimeOfDay : DateTime.Now.TimeOfDay;
                saveData.Add(new SaveChiTietTruyenMauLamSang
                {
                    Ng = Ngay + Gio,
                    TDT = showChiTiet.TocDoTruyen,
                    MSD = showChiTiet.MauSacDa,
                    NT = showChiTiet.NhipTho,
                    M = showChiTiet.Mach,
                    HA = showChiTiet.HuyetAp,
                    TN = showChiTiet.ThanNhiet,
                    DBK = showChiTiet.DienBienKhac
                });
            }
            return saveData;
        }

        public static List<PhieuTruyenMauLamSang> GetListData(MDB.MDBConnection _OracleConnection, decimal maquanly)
        {
            List<PhieuTruyenMauLamSang> list = new List<PhieuTruyenMauLamSang>();
            try
            {
                string sql = @"SELECT * FROM PhieuTruyenMauLamSang where MaQuanLy = :MaQuanLy";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, _OracleConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", maquanly));
                MDB.MDBDataReader DataReader = Command.ExecuteReader();
                while (DataReader.Read())
                {
                    PhieuTruyenMauLamSang data = new PhieuTruyenMauLamSang();
                    data.ID = Convert.ToInt64(DataReader.GetLong("ID").ToString());
                    data.MaQuanLy = maquanly;
                    data.MaBenhNhan = DataReader["MaBenhNhan"].ToString();
                    data.HoTenBenhNhan = XemBenhAn._HanhChinhBenhNhan.TenBenhNhan;
                    data.Tuoi = XemBenhAn._HanhChinhBenhNhan.Tuoi;
                    data.GioiTinh = XemBenhAn._HanhChinhBenhNhan.GioiTinh.Description();
                    data.ChanDoan = DataReader["ChanDoan"].ToString();
                    data.Khoa = DataReader["Khoa"].ToString();
                    data.MaKhoa = DataReader["MaKhoa"].ToString();
                    data.NhomMauBenhNhan = DataReader["NhomMauBenhNhan"].ToString();
                    data.LoaiChePham = DataReader["LoaiChePham"].ToString();

                    int tempInt = 0;
                    data.LanTruyenMauThu = int.TryParse(DataReader["LanTruyenMauThu"].ToString(), out tempInt) ? (int?)tempInt : null;
                    data.DinhNhomDonViMau = DataReader["DinhNhomDonViMau"].ToString();
                    data.DinhNhomNguoiNhan = DataReader["DinhNhomNguoiNhan"].ToString();
                    data.PhanUngCheo = DataReader["PhanUngCheo"].ToString();
                    data.PhanUngCheo = DataReader["PhanUngCheo"].ToString();
                    data.BatDauTruyenHoi = Common.ConDB_DateTime(DataReader["BatDauTruyenHoi"]);

                    string bangTheoDoiJson = DataReader["BangTheoDois_1"].ToString();
                    if (DataReader["BangTheoDois_2"] != DBNull.Value)
                        bangTheoDoiJson += DataReader["BangTheoDois_2"].ToString();
                    if (DataReader["BangTheoDois_3"] != DBNull.Value)
                        bangTheoDoiJson += DataReader["BangTheoDois_3"].ToString();

                    List<SaveChiTietTruyenMauLamSang> ketQuaSaves = JsonConvert.DeserializeObject<List<SaveChiTietTruyenMauLamSang>>(bangTheoDoiJson);
                    data.BangTheoDois = ConvertShowData(ketQuaSaves);

                    data.NgungTruyenHoi = Common.ConDB_DateTime(DataReader["NgungTruyenHoi"]);
                    data.SoLuongMauThucTe = DataReader["SoLuongMauThucTe"].ToString();
                    data.SoDonVi = DataReader["SoDonVi"].ToString();
                    data.LoaiTheTich = DataReader["LoaiTheTich"].ToString();
                    data.TongSoLuong = DataReader["TongSoLuong"].ToString();
                    data.NhanXet = DataReader["NhanXet"].ToString();
                    data.BacSy = DataReader["BacSy"].ToString();
                    data.MaBacSy = DataReader["MaBacSy"].ToString();
                    data.DieuDuong = DataReader["DieuDuong"].ToString();
                    data.MaDieuDuong = DataReader["MaDieuDuong"].ToString();

                    data.NgayTao = Convert.ToDateTime(DataReader["NgayTao"] == DBNull.Value ? DateTime.Now : DataReader["NgayTao"]);
                    data.NguoiTao = DataReader["NguoiTao"].ToString();
                    data.NgaySua = Convert.ToDateTime(DataReader["NgaySua"] == DBNull.Value ? DateTime.Now : DataReader["NgaySua"]);
                    data.NguoiSua = DataReader["NguoiSua"].ToString();

                    data.MaSoKy = DataReader["masokyten"].ToString();
                    data.DaKy = !string.IsNullOrEmpty(data.MaSoKy);
                    list.Add(data);
                }
            }
            catch (Exception ex) { XuLyLoi.Handle(ex); }
            return list;
        }
        public static bool InsertOrUpdate(MDB.MDBConnection MyConnection, ref PhieuTruyenMauLamSang bangKe)
        {
            try
            {
                string sql = @"INSERT INTO PhieuTruyenMauLamSang
                (
                    MAQUANLY,
                    MaBenhNhan,
                    Khoa,
                    MaKhoa,
                    Giuong,
                    ChanDoan,
                    NhomMauBenhNhan,
                    LoaiChePham,
                    LanTruyenMauThu,
                    DinhNhomDonViMau,
                    DinhNhomNguoiNhan,
                    PhanUngCheo,
                    BatDauTruyenHoi,
                    BangTheoDois_1,
                    BangTheoDois_2,
                    BangTheoDois_3,
                    NgungTruyenHoi,
                    SoLuongMauThucTe,
                    SoDonVi,
                    LoaiTheTich,
                    TongSoLuong,
                    NhanXet,
                    BacSy,
                    MaBacSy,
                    DieuDuong,
                    MaDieuDuong,
                    NGUOITAO,
                    NGUOISUA,
                    NGAYTAO,
                    NGAYSUA)  VALUES
                 (
				    :MAQUANLY,
                    :MaBenhNhan,
                    :Khoa,
                    :MaKhoa,
                    :Giuong,
                    :ChanDoan,
                    :NhomMauBenhNhan,
                    :LoaiChePham,
                    :LanTruyenMauThu,
                    :DinhNhomDonViMau,
                    :DinhNhomNguoiNhan,
                    :PhanUngCheo,
                    :BatDauTruyenHoi,
                    :BangTheoDois_1,
                    :BangTheoDois_2,
                    :BangTheoDois_3,
                    :NgungTruyenHoi,
                    :SoLuongMauThucTe,
                    :SoDonVi,
                    :LoaiTheTich,
                    :TongSoLuong,
                    :NhanXet,
                    :BacSy,
                    :MaBacSy,
                    :DieuDuong,
                    :MaDieuDuong,
                    :NGUOITAO,
                    :NGUOISUA,
                    :NGAYTAO,
                    :NGAYSUA
                 )  RETURNING ID INTO :ID";
                if (bangKe.ID != 0)
                {
                    sql = @"UPDATE PhieuTruyenMauLamSang SET 
                    MAQUANLY = :MAQUANLY,
                    MaBenhNhan = :MaBenhNhan,
                    Khoa = :Khoa,
                    MaKhoa = :MaKhoa,
                    Giuong = :Giuong,
                    ChanDoan = :ChanDoan,
                    NhomMauBenhNhan = :NhomMauBenhNhan,
                    LoaiChePham = :LoaiChePham,
                    LanTruyenMauThu = :LanTruyenMauThu,
                    DinhNhomDonViMau = :DinhNhomDonViMau,
                    DinhNhomNguoiNhan = :DinhNhomNguoiNhan,
                    PhanUngCheo = :PhanUngCheo,
                    BatDauTruyenHoi = :BatDauTruyenHoi,
                    BangTheoDois_1 = :BangTheoDois_1,
                    BangTheoDois_2 = :BangTheoDois_2,
                    BangTheoDois_3 = :BangTheoDois_3,
                    NgungTruyenHoi = :NgungTruyenHoi,
                    SoLuongMauThucTe = :SoLuongMauThucTe,
                    SoDonVi = :SoDonVi,
                    LoaiTheTich = :LoaiTheTich,
                    TongSoLuong = :TongSoLuong,
                    NhanXet = :NhanXet,
                    BacSy = :BacSy,
                    MaBacSy = :MaBacSy,
                    DieuDuong = :DieuDuong,
                    MaDieuDuong = :MaDieuDuong,
                    NGUOISUA = :NGUOISUA,
                    NGAYSUA = :NGAYSUA
                    WHERE ID = " + bangKe.ID;
                }
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MAQUANLY", bangKe.MaQuanLy));
                Command.Parameters.Add(new MDB.MDBParameter("MaBenhNhan", bangKe.MaBenhNhan));
                Command.Parameters.Add(new MDB.MDBParameter("Khoa", bangKe.Khoa));
                Command.Parameters.Add(new MDB.MDBParameter("MaKhoa", bangKe.MaKhoa));
                Command.Parameters.Add(new MDB.MDBParameter("ChanDoan", bangKe.ChanDoan));
                Command.Parameters.Add(new MDB.MDBParameter("NhomMauBenhNhan", bangKe.NhomMauBenhNhan));
                Command.Parameters.Add(new MDB.MDBParameter("Giuong", bangKe.Giuong));
                Command.Parameters.Add(new MDB.MDBParameter("LoaiChePham", bangKe.LoaiChePham));
                Command.Parameters.Add(new MDB.MDBParameter("LanTruyenMauThu", bangKe.LanTruyenMauThu));
                Command.Parameters.Add(new MDB.MDBParameter("DinhNhomDonViMau", bangKe.DinhNhomDonViMau));
                Command.Parameters.Add(new MDB.MDBParameter("DinhNhomNguoiNhan", bangKe.DinhNhomNguoiNhan));
                Command.Parameters.Add(new MDB.MDBParameter("PhanUngCheo", bangKe.PhanUngCheo));
                Command.Parameters.Add(new MDB.MDBParameter("BatDauTruyenHoi", bangKe.BatDauTruyenHoi));

                string jsonBangKes = JsonConvert.SerializeObject(ConvertSaveData(bangKe.BangTheoDois));
                List<string> listJson = new List<string>();
                for (int i = 0; i < jsonBangKes.Length; i += 3999)
                {
                    if ((i + 3999) < jsonBangKes.Length)
                        listJson.Add(jsonBangKes.Substring(i, 3999));
                    else
                        listJson.Add(jsonBangKes.Substring(i));
                }
                Command.Parameters.Add(new MDB.MDBParameter("BangTheoDois_1", listJson[0]));
                Command.Parameters.Add(new MDB.MDBParameter("BangTheoDois_2", listJson.Count > 1 ? listJson[1] : null));
                Command.Parameters.Add(new MDB.MDBParameter("BangTheoDois_3", listJson.Count > 2 ? listJson[2] : null));

                Command.Parameters.Add(new MDB.MDBParameter("NgungTruyenHoi", bangKe.NgungTruyenHoi));
                Command.Parameters.Add(new MDB.MDBParameter("SoLuongMauThucTe", bangKe.SoLuongMauThucTe));
                Command.Parameters.Add(new MDB.MDBParameter("SoDonVi", bangKe.SoDonVi));
                Command.Parameters.Add(new MDB.MDBParameter("LoaiTheTich", bangKe.LoaiTheTich));
                Command.Parameters.Add(new MDB.MDBParameter("TongSoLuong", bangKe.TongSoLuong));
                Command.Parameters.Add(new MDB.MDBParameter("NhanXet", bangKe.NhanXet));
                Command.Parameters.Add(new MDB.MDBParameter("BacSy", bangKe.BacSy));
                Command.Parameters.Add(new MDB.MDBParameter("MaBacSy", bangKe.MaBacSy));
                Command.Parameters.Add(new MDB.MDBParameter("DieuDuong", bangKe.DieuDuong));
                Command.Parameters.Add(new MDB.MDBParameter("MaDieuDuong", bangKe.MaDieuDuong));

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
                string sql = "DELETE FROM PhieuTruyenMauLamSang WHERE ID = :ID";
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
                B.MAQUANLY,
                B.MaBenhNhan,
                B.Khoa,
                B.Giuong,
                B.ChanDoan,
                B.NhomMauBenhNhan,
                B.LoaiChePham,
                B.LanTruyenMauThu,
                B.DinhNhomDonViMau,
                B.DinhNhomNguoiNhan,
                B.PhanUngCheo,
                B.BatDauTruyenHoi,
                B.NgungTruyenHoi,
                B.SoLuongMauThucTe,
                B.SoDonVi,
                B.LoaiTheTich,
                B.TongSoLuong, 
                B.NhanXet,
                B.BacSy, 
                B.MaBacSy, 
                B.DieuDuong, 
                B.MaDieuDuong
            FROM
                PhieuTruyenMauLamSang B
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
            ds.Tables[0].AddColumn("MaBenhAn", typeof(string));

            ds.Tables[0].Rows[0]["TenBenhNhan"] = XemBenhAn._HanhChinhBenhNhan.TenBenhNhan;
            ds.Tables[0].Rows[0]["Tuoi"] = XemBenhAn._HanhChinhBenhNhan.Tuoi;
            ds.Tables[0].Rows[0]["GioiTinh"] = XemBenhAn._HanhChinhBenhNhan.GioiTinh.Description();
            ds.Tables[0].Rows[0]["SOYTE"] = XemBenhAn._HanhChinhBenhNhan.SoYTe;
            ds.Tables[0].Rows[0]["BENHVIEN"] = XemBenhAn._HanhChinhBenhNhan.BenhVien;
            ds.Tables[0].Rows[0]["MaBenhAn"] = XemBenhAn._ThongTinDieuTri.MaBenhAn;

            sql = @"SELECT
               B.BangTheoDois_1, B.BangTheoDois_2, B.BangTheoDois_3
            FROM
                PhieuTruyenMauLamSang B
                
            WHERE
                ID = " + id;

            Command = new MDB.MDBCommand(sql, MyConnection);
            MDB.MDBDataReader DataReader = Command.ExecuteReader();

            List<SaveChiTietTruyenMauLamSang> saveDatas = new List<SaveChiTietTruyenMauLamSang>();
            while (DataReader.Read())
            {
                string bangKeJson = DataReader["BangTheoDois_1"].ToString();
                if (DataReader["BangTheoDois_2"] != DBNull.Value)
                    bangKeJson += DataReader["BangTheoDois_2"].ToString();
                if (DataReader["BangTheoDois_3"] != DBNull.Value)
                    bangKeJson += DataReader["BangTheoDois_3"].ToString();
                saveDatas = JsonConvert.DeserializeObject<List<SaveChiTietTruyenMauLamSang>>(bangKeJson).OrderBy(s => s.Ng).ToList();
                break;
            }

            DataTable ChiTiet = new DataTable("CT");
            ChiTiet.Columns.Add("Ng", typeof(string));
            ChiTiet.Columns.Add("TDT", typeof(string));
            ChiTiet.Columns.Add("MSD", typeof(string));
            ChiTiet.Columns.Add("NT", typeof(string));
            ChiTiet.Columns.Add("M", typeof(string));
            ChiTiet.Columns.Add("HA", typeof(string));
            ChiTiet.Columns.Add("TN", typeof(string));
            ChiTiet.Columns.Add("DBK", typeof(string));
            foreach (SaveChiTietTruyenMauLamSang ct in saveDatas)
            {
                ChiTiet.Rows.Add(ct.Ng.HasValue ? ct.Ng.Value.ToString("HH:mm dd/MM") : "",
                    ct.TDT.HasValue ? ct.TDT.Value.ToString() : "",
                    ct.MSD,
                    ct.NT.HasValue ? ct.NT.Value.ToString() : "",
                    ct.M.HasValue ? ct.M.Value.ToString() : "",
                    ct.HA,
                    ct.TN.HasValue ? ct.TN.Value.ToString() : "",
                    ct.DBK
                    );
            }

            ds.Tables.Add(ChiTiet);
            return ds;
        }
    }
}