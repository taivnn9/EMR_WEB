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
    public class PhieuKiemDiemTuVong : ThongTinKy
    {
        public PhieuKiemDiemTuVong()
        {
            TableName = "PhieuKiemDiemTuVong";
            TablePrimaryKeyName = "ID";
            IDMauPhieu = (int)DanhMucPhieu.PKDTV;
            TenMauPhieu = DanhMucPhieu.PKDTV.Description();
        }
        [MoTaDuLieu("Mã định danh")]
		public long ID { get; set; }

        [MoTaDuLieu("Mã quản lý: mã duy nhất trong 1 đợt khám chữa bệnh (kcb), không trùng giữa các đợt kcb khác nhau","",1)]
		public decimal MaQuanLy { get; set; }
        public DateTime? ThoiGian_Gio { get; set; }
        public DateTime? ThoiGian{ get; set; }

        public string HopTai { get; set; }
        public string ChuToa { get; set; }
        public string MaChuToa { get; set; }
        public string ThuKy { get; set; }
        public string MaThuKy { get; set; }
        [MoTaDuLieu("Họ và tên bệnh nhân")]
		public string TenBenhNhan { get; set; }
        [MoTaDuLieu("Tuổi bệnh nhân")]
		public string Tuoi { get; set; }
        [MoTaDuLieu("Giới tính bệnh nhân")]
		public string GioiTinh { get; set; }
        [MoTaDuLieu("Dân tộc")]
		public string DanToc { get; set; }
        public string NgoaiKieu { get; set; }
        [MoTaDuLieu("Nghề nghiệp")]
		public string NgheNghiep { get; set; }
        public string NoiLamViec { get; set; }
        [MoTaDuLieu("Địa chỉ nhà bệnh nhân")]
		public string DiaChi { get; set; }
        public string SoVaoVien { get; set; }
        [MoTaDuLieu("Số chứng minh nhân dân")]
		public string CMND { get; set; }
        [MoTaDuLieu("Nơi cấp chứng minh nhân dân")]
		public string NoiCap { get; set; }
        public DateTime? NgayCap { get; set; }
        public DateTime? NgayVaoVien { get; set; }
        public DateTime? NgayVaoVien_Gio { get; set; }
        public DateTime? NgayTuVong { get; set; }
        public DateTime? NgayTuVong_Gio { get; set; }
        public DateTime? NgayTao { get; set; }
        [MoTaDuLieu("Người tạo", null, 0, 0)]
		public string NguoiTao { get; set; }
        [MoTaDuLieu("Người sửa", null, 0, 0)]
		public string NguoiSua { get; set; }
        public DateTime? NgaySua { get; set; }

        [MoTaDuLieu("Khoa")]
		public string Khoa { get; set; }
        public string NguyenNhanTuVong { get; set; }
        public string TomTatTienSuBenh { get; set; }
        public string TinhTrangVaoVien { get; set; }
        [MoTaDuLieu("Chẩn đoán bệnh")]
		public string ChanDoan { get; set; }
        public string TomTatDienBienBenh { get; set; }
        public string TiepDonNguoiBenh { get; set; }
        public string ThamKham { get; set; }
        public string DieuTri { get; set; }
        public string ChamSoc { get; set; }
        public string MoiQuanHe { get; set; }
        public string YKienBoSung { get; set; }
        public string KetLuan { get; set; }

        public ObservableCollection<DanhSachThanhVien> ListThanhVien { get; set; }

        [MoTaDuLieu("Đã ký", null, 0, 0)]
		public bool DaKy { get; set; }

        [MoTaDuLieu("Chọn", null, 0, 0)]
		public bool Chon { get; set; }
    }
    
    public class DanhSachThanhVien
    {
        public string TenThanhVien { get; set; }
        public string ChucDanh { get; set; }
    }
    public class PhieuKiemDiemTuVongFunc
    {
        public const string TableName = "PhieuKiemDiemTuVong";
        public const string TablePrimaryKeyName = "ID";
        public const string MaPhieu = "KDTV";
        public static List<PhieuKiemDiemTuVong> GetListData(MDB.MDBConnection _OracleConnection, decimal maquanly)
        {
            List<PhieuKiemDiemTuVong> list = new List<PhieuKiemDiemTuVong>();
            try
            {
                string sql = @"SELECT * FROM PhieuKiemDiemTuVong where MaQuanLy = :MaQuanLy";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, _OracleConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", maquanly));
                MDB.MDBDataReader DataReader = Command.ExecuteReader();
                while (DataReader.Read())
                {
                    PhieuKiemDiemTuVong data = new PhieuKiemDiemTuVong();
                    data.ID = Convert.ToInt64(DataReader.GetLong("ID").ToString());
                    data.MaQuanLy = maquanly;
                    data.HopTai = DataReader["HopTai"].ToString();
                    data.ChuToa = DataReader["ChuToa"].ToString();
                    data.ThuKy = DataReader["ThuKy"].ToString();
                    data.TenBenhNhan = XemBenhAn._HanhChinhBenhNhan.TenBenhNhan;
                    data.Tuoi = XemBenhAn._HanhChinhBenhNhan.Tuoi;
                    data.GioiTinh = XemBenhAn._HanhChinhBenhNhan.GioiTinh.Description();
                    data.DanToc = DataReader["DanToc"].ToString();
                    data.NgoaiKieu = DataReader["NgoaiKieu"].ToString();
                    data.NgheNghiep = DataReader["NgheNghiep"].ToString();
                    data.NoiLamViec = DataReader["NoiLamViec"].ToString();
                    data.DiaChi = DataReader["DiaChi"].ToString();
                    data.SoVaoVien = DataReader["SoVaoVien"].ToString();
                    data.CMND = DataReader["CMND"].ToString();
                    data.NoiCap = DataReader["NoiCap"].ToString();
                    data.NgayCap = DataReader["NgayCap"] == DBNull.Value ? (DateTime?)null : DataReader.GetDate("NgayCap");
                    data.ThoiGian = DataReader["ThoiGian"] == DBNull.Value ? (DateTime?)null : DataReader.GetDate("ThoiGian");
                    data.ThoiGian_Gio = data.ThoiGian;
                    data.NgayVaoVien = DataReader["NgayVaoVien"] == DBNull.Value ? (DateTime?)null : DataReader.GetDate("NgayVaoVien");
                    data.NgayVaoVien_Gio = data.NgayVaoVien;
                    data.NgayTuVong = DataReader["NgayTuVong"] == DBNull.Value ? (DateTime?)null : DataReader.GetDate("NgayTuVong");
                    data.NgayTuVong_Gio = data.NgayTuVong;

                    data.Khoa = XemBenhAn._ThongTinDieuTri.Khoa;
                    data.NguyenNhanTuVong = DataReader["NguyenNhanTuVong"].ToString();
                    data.TomTatTienSuBenh = DataReader["TomTatTienSuBenh"].ToString();
                    data.TinhTrangVaoVien = DataReader["TinhTrangVaoVien"].ToString();
                    data.ChanDoan = DataReader["ChanDoan"].ToString();
                    data.TomTatDienBienBenh = DataReader["TomTatDienBienBenh"].ToString();
                    data.TiepDonNguoiBenh = DataReader["TiepDonNguoiBenh"].ToString();
                    data.ThamKham = DataReader["ThamKham"].ToString();
                    data.DieuTri = DataReader["DieuTri"].ToString();
                    data.ChamSoc = DataReader["ChamSoc"].ToString();
                    data.MoiQuanHe = DataReader["MoiQuanHe"].ToString();
                    data.YKienBoSung = DataReader["YKienBoSung"].ToString();
                    data.KetLuan = DataReader["KetLuan"].ToString();

                    data.ListThanhVien = JsonConvert.DeserializeObject<ObservableCollection<DanhSachThanhVien>>(DataReader["ListThanhVien"].ToString());

                    data.MaSoKy = DataReader["masokyten"].ToString();
                    data.DaKy = !string.IsNullOrEmpty(data.MaSoKy) ? true : false;

                    data.NgayTao = DataReader["NgayTao"] == DBNull.Value ? (DateTime?)null : DataReader.GetDate("NgayTao");
                    data.NguoiTao = DataReader["NguoiTao"].ToString();
                    data.NguoiSua = DataReader["NguoiSua"].ToString();
                    data.NgaySua = DataReader["NgaySua"] == DBNull.Value ? (DateTime?)null : DataReader.GetDate("NgaySua");


                    list.Add(data);
                }
            }
            catch (Exception ex) { XuLyLoi.Handle(ex); }
            return list;
        }
        public static bool InsertOrUpdate(MDB.MDBConnection MyConnection, ref PhieuKiemDiemTuVong bangKiem)
        {
            try
            {
                string sql = @"INSERT INTO PhieuKiemDiemTuVong
                (
                    MAQUANLY,
                    HopTai,
                    MaChuToa,
                    ChuToa,
                    MaThuKy,
                    ThuKy,
                    DanToc,
                    NgoaiKieu,
                    NgheNghiep,
                    NoiLamViec,
                    DiaChi,
                    SoVaoVien,
                    CMND,
                    NgayCap,
                    NoiCap,
                    ThoiGian,
                    NgayVaoVien,
                    NgayTuVong,
                    NguyenNhanTuVong,
                    TomTatTienSuBenh,
                    TinhTrangVaoVien,
                    ChanDoan,
                    TomTatDienBienBenh,
                    TiepDonNguoiBenh,
                    ThamKham,
                    DieuTri,
                    ChamSoc,
                    MoiQuanHe,
                    YKienBoSung,
                    KetLuan,
                    ListThanhVien,
                    NGUOITAO,
                    NGUOISUA,
                    NGAYTAO,
                    NGAYSUA)  VALUES
                 (
				    :MAQUANLY,
                    :HopTai,
                    :MaChuToa,
                    :ChuToa,
                    :MaThuKy,
                    :ThuKy,
                    :DanToc,
                    :NgoaiKieu,
                    :NgheNghiep,
                    :NoiLamViec,
                    :DiaChi,
                    :SoVaoVien,
                    :CMND,
                    :NgayCap,
                    :NoiCap,
                    :ThoiGian,
                    :NgayVaoVien,
                    :NgayTuVong,
                    :NguyenNhanTuVong,
                    :TomTatTienSuBenh,
                    :TinhTrangVaoVien,
                    :ChanDoan,
                    :TomTatDienBienBenh,
                    :TiepDonNguoiBenh,
                    :ThamKham,
                    :DieuTri,
                    :ChamSoc,
                    :MoiQuanHe,
                    :YKienBoSung,
                    :KetLuan,
                    :ListThanhVien,
                    :NGUOITAO,
                    :NGUOISUA,
                    :NGAYTAO,
                    :NGAYSUA
                 )  RETURNING ID INTO :ID";
                if (bangKiem.ID != 0)
                {
                    sql = @"UPDATE PhieuKiemDiemTuVong SET 
                    MAQUANLY = :MAQUANLY,
					HopTai = :HopTai,
                    MaChuToa = :MaChuToa,
                    ChuToa = :ChuToa,
                    MaThuKy = :MaThuKy,
                    ThuKy = :ThuKy,
                    DanToc = :DanToc,
                    NgoaiKieu = :NgoaiKieu,
                    NgheNghiep = :NgheNghiep,
                    NoiLamViec = :NoiLamViec,
                    DiaChi = :DiaChi,
                    SoVaoVien = :SoVaoVien,
                    CMND = :CMND,
                    NgayCap = :NgayCap,
                    NoiCap = :NoiCap,
                    ThoiGian = :ThoiGian,
                    NgayVaoVien = :NgayVaoVien,
                    NgayTuVong = :NgayTuVong,
                    NguyenNhanTuVong = :NguyenNhanTuVong,
                    TomTatTienSuBenh = :TomTatTienSuBenh,
                    TinhTrangVaoVien = :TinhTrangVaoVien,
                    ChanDoan = :ChanDoan,
                    TomTatDienBienBenh = :TomTatDienBienBenh,
                    TiepDonNguoiBenh = :TiepDonNguoiBenh,
                    ThamKham = :ThamKham,
                    DieuTri = :DieuTri,
                    ChamSoc = :ChamSoc,
                    MoiQuanHe = :MoiQuanHe,
                    YKienBoSung = :YKienBoSung,
                    KetLuan = :KetLuan,
                    ListThanhVien = :ListThanhVien,
                    NGUOISUA = :NGUOISUA,
                    NGAYSUA = :NGAYSUA
                    WHERE ID = " + bangKiem.ID;
                }
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MAQUANLY", bangKiem.MaQuanLy));
                Command.Parameters.Add(new MDB.MDBParameter("HopTai", bangKiem.HopTai));
                Command.Parameters.Add(new MDB.MDBParameter("MaChuToa", bangKiem.MaChuToa));
                Command.Parameters.Add(new MDB.MDBParameter("ChuToa", bangKiem.ChuToa));
                Command.Parameters.Add(new MDB.MDBParameter("MaThuKy", bangKiem.MaThuKy));
                Command.Parameters.Add(new MDB.MDBParameter("ThuKy", bangKiem.ThuKy));
                Command.Parameters.Add(new MDB.MDBParameter("DanToc", bangKiem.DanToc));
                Command.Parameters.Add(new MDB.MDBParameter("NgoaiKieu", bangKiem.NgoaiKieu));
                Command.Parameters.Add(new MDB.MDBParameter("NgheNghiep", bangKiem.NgheNghiep));
                Command.Parameters.Add(new MDB.MDBParameter("NoiLamViec", bangKiem.NoiLamViec));
                Command.Parameters.Add(new MDB.MDBParameter("DiaChi", bangKiem.DiaChi));
                Command.Parameters.Add(new MDB.MDBParameter("SoVaoVien", bangKiem.SoVaoVien));
                Command.Parameters.Add(new MDB.MDBParameter("CMND", bangKiem.CMND));
                Command.Parameters.Add(new MDB.MDBParameter("NgayCap", bangKiem.NgayCap));
                Command.Parameters.Add(new MDB.MDBParameter("NoiCap", bangKiem.NoiCap));

                DateTime? ThoiGian = bangKiem.ThoiGian.HasValue ? bangKiem.ThoiGian.Value.Date : (DateTime?)null;
                var ThoiGianFull = ThoiGian;
                if (ThoiGian != null)
                {
                    var ThoiGian_Gio = bangKiem.ThoiGian_Gio.HasValue ? bangKiem.ThoiGian_Gio.Value.TimeOfDay : new TimeSpan(0, 0, 0);
                    ThoiGianFull = ThoiGian + ThoiGian_Gio;
                }

                Command.Parameters.Add(new MDB.MDBParameter("ThoiGian", ThoiGianFull));

                DateTime? NgayVaoVien = bangKiem.NgayVaoVien.HasValue ? bangKiem.NgayVaoVien.Value.Date : (DateTime?)null;
                var NgayVaoVienFull = NgayVaoVien;
                if (NgayVaoVien != null)
                {
                    var NgayVaoVien_Gio = bangKiem.NgayVaoVien_Gio.HasValue ? bangKiem.NgayVaoVien_Gio.Value.TimeOfDay : new TimeSpan(0, 0, 0);
                    NgayVaoVienFull = NgayVaoVien + NgayVaoVien_Gio;
                }

                Command.Parameters.Add(new MDB.MDBParameter("NgayVaoVien", NgayVaoVienFull));

                DateTime? NgayTuVong = bangKiem.NgayTuVong.HasValue ? bangKiem.NgayTuVong.Value.Date : (DateTime?)null;
                var NgayTuVongFull = NgayTuVong;
                if (NgayTuVong != null)
                {
                    var NgayTuVong_Gio = bangKiem.NgayTuVong_Gio.HasValue ? bangKiem.NgayTuVong_Gio.Value.TimeOfDay : new TimeSpan(0, 0, 0);
                    NgayTuVongFull = NgayTuVong + NgayTuVong_Gio;
                }

                Command.Parameters.Add(new MDB.MDBParameter("NgayTuVong", NgayTuVongFull));

                Command.Parameters.Add(new MDB.MDBParameter("NguyenNhanTuVong", bangKiem.NguyenNhanTuVong));
                Command.Parameters.Add(new MDB.MDBParameter("TomTatTienSuBenh", bangKiem.TomTatTienSuBenh));
                Command.Parameters.Add(new MDB.MDBParameter("TinhTrangVaoVien", bangKiem.TinhTrangVaoVien));
                Command.Parameters.Add(new MDB.MDBParameter("ChanDoan", bangKiem.ChanDoan));
                Command.Parameters.Add(new MDB.MDBParameter("TomTatDienBienBenh", bangKiem.TomTatDienBienBenh));
                Command.Parameters.Add(new MDB.MDBParameter("TiepDonNguoiBenh", bangKiem.TiepDonNguoiBenh));
                Command.Parameters.Add(new MDB.MDBParameter("ThamKham", bangKiem.ThamKham));
                Command.Parameters.Add(new MDB.MDBParameter("DieuTri", bangKiem.DieuTri));
                Command.Parameters.Add(new MDB.MDBParameter("ChamSoc", bangKiem.ChamSoc));
                Command.Parameters.Add(new MDB.MDBParameter("MoiQuanHe", bangKiem.MoiQuanHe));
                Command.Parameters.Add(new MDB.MDBParameter("YKienBoSung", bangKiem.YKienBoSung));
                Command.Parameters.Add(new MDB.MDBParameter("KetLuan", bangKiem.KetLuan));
                Command.Parameters.Add(new MDB.MDBParameter("ListThanhVien", JsonConvert.SerializeObject(bangKiem.ListThanhVien)));

                Command.Parameters.Add(new MDB.MDBParameter("NGUOISUA", bangKiem.NguoiSua));
                Command.Parameters.Add(new MDB.MDBParameter("NGAYSUA", bangKiem.NgaySua));
                if (bangKiem.ID == 0)
                {
                    Command.Parameters.Add(new MDB.MDBParameter("ID", bangKiem.ID));
                    Command.Parameters.Add(new MDB.MDBParameter("NGUOITAO", bangKiem.NguoiTao));
                    Command.Parameters.Add(new MDB.MDBParameter("NGAYTAO", bangKiem.NgayTao));
                }
                Command.BindByName = true;
                int n = Command.ExecuteNonQuery();
                if (bangKiem.ID == 0)
                {
                    long nextval = Convert.ToInt64((Command.Parameters["ID"] as MDB.MDBParameter).Value);
                    bangKiem.ID = nextval;
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
                string sql = "DELETE FROM PhieuKiemDiemTuVong WHERE ID = :ID";
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
                *
            FROM
                PhieuKiemDiemTuVong B
            WHERE
                ID = " + id;

            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
            MDB.MDBDataAdapter adt = new MDB.MDBDataAdapter(Command);

            var ds = new DataSet();

            adt.Fill(ds, "TB");
            ds.Tables[0].AddColumn("TenBenhNhan", typeof(string));
            ds.Tables[0].AddColumn("Tuoi", typeof(string));
            ds.Tables[0].AddColumn("GioiTinh", typeof(string));
            ds.Tables[0].AddColumn("Khoa", typeof(string));
            ds.Tables[0].AddColumn("CacThanhVien", typeof(string));

            ds.Tables[0].Rows[0]["TenBenhNhan"] = XemBenhAn._HanhChinhBenhNhan.TenBenhNhan;
            ds.Tables[0].Rows[0]["Khoa"] = XemBenhAn._ThongTinDieuTri.Khoa;
            ds.Tables[0].Rows[0]["Tuoi"] = XemBenhAn._HanhChinhBenhNhan.Tuoi;
            ds.Tables[0].Rows[0]["GioiTinh"] = XemBenhAn._HanhChinhBenhNhan.GioiTinh.Description();


            ObservableCollection<DanhSachThanhVien> ListThanhVien = JsonConvert.DeserializeObject<ObservableCollection<DanhSachThanhVien>>(ds.Tables[0].Rows[0]["ListThanhVien"].ToString());
            string CacThanhVien = "";

            foreach (DanhSachThanhVien tv in ListThanhVien)
            {
                NhanVien nv = NhanVienFunc.ListNhanVien.Where(x => x.MaNhanVien.Equals(tv.TenThanhVien)).FirstOrDefault();
                CacThanhVien += nv.HoVaTen + "\r\n";
                tv.TenThanhVien = nv.HoVaTen;
            }

            ds.Tables[0].Rows[0]["CacThanhVien"] = CacThanhVien;

            DataTable TV = Common.ListToDataTable(ListThanhVien, "TV");
            ds.Tables.Add(TV);

            return ds;
        }
    }
}
