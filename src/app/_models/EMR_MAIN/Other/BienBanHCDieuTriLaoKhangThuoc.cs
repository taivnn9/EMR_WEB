using EMR.KyDienTu;
using Newtonsoft.Json;
using PMS.Access;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;

namespace EMR_MAIN.DATABASE.Other
{
    public class BienBanHCDieuTriLaoKhangThuoc : ThongTinKy
    {
        public BienBanHCDieuTriLaoKhangThuoc()
        {
            TableName = "BBHCDieuTriLaoKhangThuoc";
            TablePrimaryKeyName = "ID";
            IDMauPhieu = (int)DanhMucPhieu.BBHCDTLKT;
            TenMauPhieu = DanhMucPhieu.BBHCDTLKT.Description();
        }
        [MoTaDuLieu("Mã định danh")]
		public long ID { get; set; }
        [MoTaDuLieu("Mã quản lý: mã duy nhất trong 1 đợt khám chữa bệnh (kcb), không trùng giữa các đợt kcb khác nhau","",1)]
		public decimal MaQuanLy { get; set; }
        [MoTaDuLieu("Mã bệnh nhân")]
		public string MaBenhNhan { get; set; }
        [MoTaDuLieu("Khoa")]
		public string Khoa { get; set; }
        [MoTaDuLieu("Mã khoa")]
		public string MaKhoa { get; set; }
        public string HoVaTenBN { get; set; }
        [MoTaDuLieu("Tuổi bệnh nhân")]
		public string Tuoi { get; set; }
        [MoTaDuLieu("Giới tính bệnh nhân")]
		public string GioiTinh { get; set; }
        [MoTaDuLieu("Địa chỉ nhà bệnh nhân")]
		public string DiaChi { get; set; }
        [MoTaDuLieu("Giường")]
		public string Giuong { get; set; }
        [MoTaDuLieu("Buồng")]
		public string Buong { get; set; }
        public DateTime HoiChanLuc { get; set; }
        public DateTime? HoiChanLuc_Gio { get; set; }
        public string ChuToa { get; set; }
        public string MaChuToa { get; set; }
        public string ThuKy { get; set; }
        public string MaThuKy { get; set; }
        public ObservableCollection<NhanVien> DanhSachHoiChan { get; set; }
        public string TomTat { get; set; }
        [MoTaDuLieu("Chẩn đoán bệnh ban đầu")]
		public string ChanDoanBanDau { get; set; }
        public int TieuSuThocLaoTruocDay { get; set; }
        public int? SoLanTruocDay { get; set; }
        public DateTime? VaoNgayTruocDay { get; set; }
        public string PhapDo { get; set; }
        public string KetQua { get; set; }
        public int TieuSuLaoHangHai { get; set; }
        public string TenThuoc { get; set; }
        public DateTime? ThoiGianHangHai { get; set; }
        public string TienSuKhac { get; set; }
        public string XetNghiemLaoGanNhat { get; set; }
        public string KQXpert { get; set; }
        public string KQNhuom { get; set; }
        public string KQNuoiCay { get; set; }
        public string KQhain { get; set; }
        public string KQKhangSinhDo { get; set; }
        public string KQKhac { get; set; }
        public string KetLuan { get; set; }
        [MoTaDuLieu("Chẩn đoán bệnh")]
		public string ChanDoan { get; set; }
        public string HuongDieuTri { get; set; }
        [MoTaDuLieu("Bác sỹ điều trị")]
		public string BacSyDieuTri { get; set; }
        [MoTaDuLieu("Mã bác sỹ điều trị")]
		public string MaBacSyDieuTri { get; set; }
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
    public class BienBanHCDieuTriLaoKhangThuocFunc
    {
        public const string TableName = "BBHCDieuTriLaoKhangThuoc";
        public const string TablePrimaryKeyName = "ID";
        public static List<BienBanHCDieuTriLaoKhangThuoc> GetListData(MDB.MDBConnection _OracleConnection, decimal maquanly)
        {
            List<BienBanHCDieuTriLaoKhangThuoc> list = new List<BienBanHCDieuTriLaoKhangThuoc>();
            try
            {
                string sql = @"SELECT * FROM BBHCDieuTriLaoKhangThuoc where MaQuanLy = :MaQuanLy";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, _OracleConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", maquanly));
                MDB.MDBDataReader DataReader = Command.ExecuteReader();
                while (DataReader.Read())
                {
                    BienBanHCDieuTriLaoKhangThuoc data = new BienBanHCDieuTriLaoKhangThuoc();
                    data.ID = Convert.ToInt64(DataReader.GetLong("ID").ToString());
                    data.MaQuanLy = maquanly;
                    data.MaBenhNhan = DataReader["MaBenhNhan"].ToString();
                    data.Khoa = DataReader["Khoa"].ToString();
                    data.MaKhoa = DataReader["MaKhoa"].ToString();
                    data.HoVaTenBN = XemBenhAn._HanhChinhBenhNhan.TenBenhNhan;
                    data.Tuoi = XemBenhAn._HanhChinhBenhNhan.Tuoi;
                    data.GioiTinh = XemBenhAn._HanhChinhBenhNhan.GioiTinh.Description();
                    data.DiaChi = DataReader["DiaChi"].ToString();
                    data.Giuong = DataReader["Giuong"].ToString();
                    data.Buong = DataReader["Buong"].ToString();
                    data.HoiChanLuc = Convert.ToDateTime(DataReader["HoiChanLuc"] == DBNull.Value ? DateTime.Now : DataReader["HoiChanLuc"]);
                    data.HoiChanLuc_Gio = data.HoiChanLuc;
                    data.ChuToa = DataReader["ChuToa"].ToString();
                    data.MaChuToa = DataReader["MaChuToa"].ToString();
                    data.ThuKy = DataReader["ThuKy"].ToString();
                    data.MaThuKy = DataReader["MaThuKy"].ToString();
                    data.DanhSachHoiChan = JsonConvert.DeserializeObject<ObservableCollection<NhanVien>>(DataReader["DanhSachHoiChan"].ToString());
                    data.TomTat = DataReader["TomTat"].ToString();
                    data.ChanDoanBanDau = DataReader["ChanDoanBanDau"].ToString();
                    data.TieuSuThocLaoTruocDay = DataReader.GetInt("TieuSuThocLaoTruocDay");
                    int intTemp = 0;
                    data.SoLanTruocDay = int.TryParse(DataReader["SoLanTruocDay"].ToString(), out intTemp) ? (int?) intTemp : null;
                    DateTime dateTimeTemp;
                    data.VaoNgayTruocDay = DateTime.TryParse(DataReader["VaoNgayTruocDay"].ToString(), out dateTimeTemp) ? (DateTime?)dateTimeTemp : null;
                    data.PhapDo = DataReader["PhapDo"].ToString();
                    data.KetQua = DataReader["KetQua"].ToString();
                    data.TieuSuLaoHangHai = DataReader.GetInt("TieuSuLaoHangHai");
                    data.TenThuoc = DataReader["TenThuoc"].ToString();
                    data.ThoiGianHangHai = DateTime.TryParse(DataReader["ThoiGianHangHai"].ToString(), out dateTimeTemp) ? (DateTime?)dateTimeTemp : null;
                    data.TienSuKhac = DataReader["TienSuKhac"].ToString();
                    data.XetNghiemLaoGanNhat = DataReader["XetNghiemLaoGanNhat"].ToString();
                    data.KQXpert = DataReader["KQXpert"].ToString();
                    data.KQNhuom = DataReader["KQNhuom"].ToString();
                    data.KQNuoiCay = DataReader["KQNuoiCay"].ToString();
                    data.KQhain = DataReader["KQhain"].ToString();
                    data.KQKhangSinhDo = DataReader["KQKhangSinhDo"].ToString();
                    data.KQKhac = DataReader["KQKhac"].ToString();
                    data.KetLuan = DataReader["KetLuan"].ToString();
                    data.ChanDoan = DataReader["ChanDoan"].ToString();
                    data.HuongDieuTri = DataReader["HuongDieuTri"].ToString();
                    data.BacSyDieuTri = DataReader["BacSyDieuTri"].ToString();
                    data.MaBacSyDieuTri = DataReader["MaBacSyDieuTri"].ToString();

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
        public static bool InsertOrUpdate(MDB.MDBConnection MyConnection, ref BienBanHCDieuTriLaoKhangThuoc bienBan)
        {
            try
            {
                string sql = @"INSERT INTO BBHCDieuTriLaoKhangThuoc
                (
                    MAQUANLY,
                    MaBenhNhan,
                    Khoa,
                    MaKhoa,
                    DiaChi,
                    Giuong,
                    Buong,
                    HoiChanLuc,
                    ChuToa,
                    MaChuToa,
                    ThuKy,
                    MaThuKy,
                    DanhSachHoiChan,
                    TomTat,
                    ChanDoanBanDau,
                    TieuSuThocLaoTruocDay,
                    SoLanTruocDay,
                    VaoNgayTruocDay,
                    PhapDo,
                    KetQua,
                    TieuSuLaoHangHai,
                    TenThuoc,
                    ThoiGianHangHai,
                    TienSuKhac,
                    XetNghiemLaoGanNhat,
                    KQXpert,
                    KQNhuom,
                    KQNuoiCay,
                    KQhain,
                    KQKhangSinhDo,
                    KQKhac,
                    KetLuan,
                    ChanDoan,
                    HuongDieuTri,
                    BacSyDieuTri,
                    MaBacSyDieuTri,
                    NGUOITAO,
                    NGUOISUA,
                    NGAYTAO,
                    NGAYSUA)  VALUES
                 (
				    :MAQUANLY,
                    :MaBenhNhan,
                    :Khoa,
                    :MaKhoa,
                    :DiaChi,
                    :Giuong,
                    :Buong,
                    :HoiChanLuc,
                    :ChuToa,
                    :MaChuToa,
                    :ThuKy,
                    :MaThuKy,
                    :DanhSachHoiChan,
                    :TomTat,
                    :ChanDoanBanDau,
                    :TieuSuThocLaoTruocDay,
                    :SoLanTruocDay,
                    :VaoNgayTruocDay,
                    :PhapDo,
                    :KetQua,
                    :TieuSuLaoHangHai,
                    :TenThuoc,
                    :ThoiGianHangHai,
                    :TienSuKhac,
                    :XetNghiemLaoGanNhat,
                    :KQXpert,
                    :KQNhuom,
                    :KQNuoiCay,
                    :KQhain,
                    :KQKhangSinhDo,
                    :KQKhac,
                    :KetLuan,
                    :ChanDoan,
                    :HuongDieuTri,
                    :BacSyDieuTri,
                    :MaBacSyDieuTri,
                    :NGUOITAO,
                    :NGUOISUA,
                    :NGAYTAO,
                    :NGAYSUA
                 )  RETURNING ID INTO :ID";
                if (bienBan.ID != 0)
                {
                    sql = @"UPDATE BBHCDieuTriLaoKhangThuoc SET 
                    MAQUANLY = :MAQUANLY,
                    MaBenhNhan = :MaBenhNhan,
                    Khoa = :Khoa,
                    MaKhoa = :MaKhoa,
                    DiaChi = :DiaChi,
                    Giuong = :Giuong,
                    Buong = :Buong,
                    HoiChanLuc = :HoiChanLuc,
                    ChuToa = :ChuToa,
                    MaChuToa = :MaChuToa,
                    ThuKy = :ThuKy,
                    MaThuKy = :MaThuKy,
                    DanhSachHoiChan = :DanhSachHoiChan,
                    TomTat = :TomTat,
                    ChanDoanBanDau = :ChanDoanBanDau,
                    TieuSuThocLaoTruocDay = :TieuSuThocLaoTruocDay,
                    SoLanTruocDay = :SoLanTruocDay,
                    VaoNgayTruocDay = :VaoNgayTruocDay,
                    PhapDo = :PhapDo,
                    KetQua = :KetQua,
                    TieuSuLaoHangHai = :TieuSuLaoHangHai,
                    TenThuoc = :TenThuoc,
                    ThoiGianHangHai = :ThoiGianHangHai,
                    TienSuKhac = :TienSuKhac,
                    XetNghiemLaoGanNhat = :XetNghiemLaoGanNhat,
                    KQXpert = :KQXpert,
                    KQNhuom = :KQNhuom,
                    KQNuoiCay = :KQNuoiCay,
                    KQhain = :KQhain,
                    KQKhangSinhDo = :KQKhangSinhDo,
                    KQKhac = :KQKhac,
                    KetLuan = :KetLuan,
                    ChanDoan = :ChanDoan,
                    HuongDieuTri = :HuongDieuTri,
                    BacSyDieuTri = :BacSyDieuTri,
                    MaBacSyDieuTri = :MaBacSyDieuTri,
                    NGUOISUA = :NGUOISUA,
                    NGAYSUA = :NGAYSUA
                    WHERE ID = " + bienBan.ID;
                }
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MAQUANLY", bienBan.MaQuanLy));
                Command.Parameters.Add(new MDB.MDBParameter("MaBenhNhan", bienBan.MaBenhNhan));
                Command.Parameters.Add(new MDB.MDBParameter("Khoa", bienBan.Khoa));
                Command.Parameters.Add(new MDB.MDBParameter("MaKhoa", bienBan.MaKhoa));
                Command.Parameters.Add(new MDB.MDBParameter("DiaChi", bienBan.DiaChi));
                Command.Parameters.Add(new MDB.MDBParameter("Giuong", bienBan.Giuong));
                Command.Parameters.Add(new MDB.MDBParameter("Buong", bienBan.Buong));
                
                var Ngay = bienBan.HoiChanLuc.Date.Add(new TimeSpan(0, 0, 0));
                var Gio = bienBan.HoiChanLuc_Gio != null ? bienBan.HoiChanLuc_Gio.Value.TimeOfDay : DateTime.Now.TimeOfDay;
                var ngayHoiChan = Ngay + Gio;
                Command.Parameters.Add(new MDB.MDBParameter("HoiChanLuc", ngayHoiChan));
                Command.Parameters.Add(new MDB.MDBParameter("ChuToa", bienBan.ChuToa));
                Command.Parameters.Add(new MDB.MDBParameter("MaChuToa", bienBan.MaChuToa));
                Command.Parameters.Add(new MDB.MDBParameter("ThuKy", bienBan.ThuKy));
                Command.Parameters.Add(new MDB.MDBParameter("MaThuKy", bienBan.MaThuKy));
                Command.Parameters.Add(new MDB.MDBParameter("MaThuKy", bienBan.MaThuKy));
                Command.Parameters.Add(new MDB.MDBParameter("DanhSachHoiChan", JsonConvert.SerializeObject(bienBan.DanhSachHoiChan)));
                Command.Parameters.Add(new MDB.MDBParameter("TomTat", bienBan.TomTat));
                Command.Parameters.Add(new MDB.MDBParameter("ChanDoanBanDau", bienBan.ChanDoanBanDau));
                Command.Parameters.Add(new MDB.MDBParameter("TieuSuThocLaoTruocDay", bienBan.TieuSuThocLaoTruocDay));
                Command.Parameters.Add(new MDB.MDBParameter("SoLanTruocDay", bienBan.SoLanTruocDay));
                Command.Parameters.Add(new MDB.MDBParameter("VaoNgayTruocDay", bienBan.VaoNgayTruocDay));
                Command.Parameters.Add(new MDB.MDBParameter("PhapDo", bienBan.PhapDo));
                Command.Parameters.Add(new MDB.MDBParameter("KetQua", bienBan.KetQua));
                Command.Parameters.Add(new MDB.MDBParameter("TieuSuLaoHangHai", bienBan.TieuSuLaoHangHai));
                Command.Parameters.Add(new MDB.MDBParameter("TenThuoc", bienBan.TenThuoc));
                Command.Parameters.Add(new MDB.MDBParameter("ThoiGianHangHai", bienBan.ThoiGianHangHai));
                Command.Parameters.Add(new MDB.MDBParameter("TienSuKhac", bienBan.TienSuKhac));
                Command.Parameters.Add(new MDB.MDBParameter("XetNghiemLaoGanNhat", bienBan.XetNghiemLaoGanNhat));
                Command.Parameters.Add(new MDB.MDBParameter("KQXpert", bienBan.KQXpert));
                Command.Parameters.Add(new MDB.MDBParameter("KQNhuom", bienBan.KQNhuom));
                Command.Parameters.Add(new MDB.MDBParameter("KQNuoiCay", bienBan.KQNuoiCay));
                Command.Parameters.Add(new MDB.MDBParameter("KQhain", bienBan.KQhain));
                Command.Parameters.Add(new MDB.MDBParameter("KQKhangSinhDo", bienBan.KQKhangSinhDo));
                Command.Parameters.Add(new MDB.MDBParameter("KQKhac", bienBan.KQKhac));
                Command.Parameters.Add(new MDB.MDBParameter("KetLuan", bienBan.KetLuan));
                Command.Parameters.Add(new MDB.MDBParameter("ChanDoan", bienBan.ChanDoan));
                Command.Parameters.Add(new MDB.MDBParameter("HuongDieuTri", bienBan.HuongDieuTri));
                Command.Parameters.Add(new MDB.MDBParameter("BacSyDieuTri", bienBan.BacSyDieuTri));
                Command.Parameters.Add(new MDB.MDBParameter("MaBacSyDieuTri", bienBan.MaBacSyDieuTri));
                Command.Parameters.Add(new MDB.MDBParameter("NGUOISUA", bienBan.NguoiSua));
                Command.Parameters.Add(new MDB.MDBParameter("NGAYSUA", bienBan.NgaySua));
                if (bienBan.ID == 0)
                {
                    Command.Parameters.Add(new MDB.MDBParameter("ID", bienBan.ID));
                    Command.Parameters.Add(new MDB.MDBParameter("NGUOITAO", bienBan.NguoiTao));
                    Command.Parameters.Add(new MDB.MDBParameter("NGAYTAO", bienBan.NgayTao));
                }
                Command.BindByName = true;
                int n = Command.ExecuteNonQuery();
                if (bienBan.ID == 0)
                {
                    long nextval = Convert.ToInt64((Command.Parameters["ID"] as MDB.MDBParameter).Value);
                    bienBan.ID = nextval;
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
                string sql = "DELETE FROM BBHCDieuTriLaoKhangThuoc WHERE ID = :ID";
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
                B.MaBenhNhan,
                B.Khoa,
                B.MaKhoa,
                B.DiaChi,
                B.Giuong,
                B.Buong,
                B.HoiChanLuc,
                B.ChuToa,
                B.MaChuToa,
                B.ThuKy,
                B.MaThuKy,
                B.TomTat,
                B.ChanDoanBanDau,
                B.TieuSuThocLaoTruocDay,
                B.SoLanTruocDay,
                B.VaoNgayTruocDay,
                B.PhapDo,
                B.KetQua,
                B.TieuSuLaoHangHai,
                B.TenThuoc,
                B.ThoiGianHangHai,
                B.TienSuKhac,
                B.XetNghiemLaoGanNhat,
                B.KQXpert,
                B.KQNhuom,
                B.KQNuoiCay,
                B.KQhain,
                B.KQKhangSinhDo,
                B.KQKhac,
                B.KetLuan,
                B.ChanDoan,
                B.HuongDieuTri,
                B.BacSyDieuTri,
                B.MaBacSyDieuTri,
                B.NgayTao,
                T.MABENHAN,
	            H.TENBENHNHAN,
                H.GioiTinh,
                H.Tuoi,
                H.SOYTE,
                H.BENHVIEN
                
            FROM
                BBHCDieuTriLaoKhangThuoc B
                LEFT JOIN THONGTINDIEUTRI T ON B.MAQUANLY = T.MAQUANLY
                LEFT JOIN HANHCHINHBENHNHAN H ON T.MABENHNHAN = H.MABENHNHAN
            WHERE
                ID = " + id;

            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);

            MDB.MDBDataAdapter adt = new MDB.MDBDataAdapter(Command);
            var ds = new DataSet();
            adt.Fill(ds, "HC");

            sql = @"SELECT DANHSACHHOICHAN FROM BBHCDieuTriLaoKhangThuoc where ID = " + id;
            Command = new MDB.MDBCommand(sql, MyConnection);
            Command.BindByName = true;
            MDB.MDBDataReader DataReader = Command.ExecuteReader();
            ObservableCollection<NhanVien> listDanhSach = new ObservableCollection<NhanVien>();
            while (DataReader.Read())
            {
                listDanhSach = JsonConvert.DeserializeObject<ObservableCollection<NhanVien>>(DataReader["DANHSACHHOICHAN"].ToString());
            }
            DataTable DanhSachHoiChan = new DataTable("DSHC");
            DanhSachHoiChan.Columns.Add("LIST1");
            DanhSachHoiChan.Columns.Add("LIST2");

            if (listDanhSach.Count > 2)
            {
                for (int i = 0; i < listDanhSach.Count / 2; i++)
                {
                    DanhSachHoiChan.Rows.Add(listDanhSach[i].HoVaTen, listDanhSach[listDanhSach.Count / 2 + i].HoVaTen);
                }
                if (listDanhSach.Count % 2 == 1)
                {
                    DanhSachHoiChan.Rows.Add(listDanhSach[listDanhSach.Count - 1].HoVaTen, "");
                }
            }
            else
            {
                for (int i = 0; i < listDanhSach.Count; i++)
                {
                    DanhSachHoiChan.Rows.Add(listDanhSach[i].HoVaTen, "");
                }
            }
            ds.Tables.Add(DanhSachHoiChan);

            return ds;
        }
    } 

}
