using EMR.KyDienTu;
using System;
using System.Collections.Generic;
using System.Data;
using PMS.Access;

namespace EMR_MAIN.DATABASE.Other
{
    public class BangTuongTrinhDieuTriTaiThong : ThongTinKy
    {
        public BangTuongTrinhDieuTriTaiThong()
        {
            TableName = "BangTuongTrinhDieuTriTaiThong";
            TablePrimaryKeyName = "Id";
            IDMauPhieu = (int)DanhMucPhieu.BTTDTTT;
            TenMauPhieu = DanhMucPhieu.BTTDTTT.Description();
        }
        [MoTaDuLieu("Mã định danh")]
		public long Id { get; set; }
        [MoTaDuLieu("Mã quản lý: mã duy nhất trong 1 đợt khám chữa bệnh (kcb), không trùng giữa các đợt kcb khác nhau","",1)]
		public decimal MaQuanLy { get; set; }
        [MoTaDuLieu("Họ và tên bệnh nhân")]
		public string TenBenhNhan { get; set; }
        [MoTaDuLieu("Tuổi bệnh nhân")]
		public string Tuoi { get; set; }
        [MoTaDuLieu("Giới tính bệnh nhân")]
        public GioiTinh GioiTinh { get; set; }
        [MoTaDuLieu("Ngày vào bệnh viện")]
		public DateTime NgayVaoVien { get; set; }
        [MoTaDuLieu("Số nhập viện")]
		public string SoNhapVien { get; set; }
        [MoTaDuLieu("Mã bệnh nhân")]
		public string MaBenhNhan { get; set; }
        [MoTaDuLieu("Tại khoa")]
        public string TaiKhoa { get; set; }
        [MoTaDuLieu("Mã khoa")]
        public string MaTaiKhoa { get; set; }
        public bool[] ChucVuArray { get; } = new bool[] { false, false, false};
        [MoTaDuLieu("Chức vụ người ghi nhận có sự việc")]
        public int ChucVu
        {
            get
            {
                return Array.IndexOf(ChucVuArray, true);
            }
            set
            {
                for (int i = 0; i < 3; i++)
                {
                    if (i == value) ChucVuArray[i] = true;
                    else ChucVuArray[i] = false;
                }
            }
        }
        [MoTaDuLieu("Khác-người ghi nhận có sực việc")]
        public string ChucVu_Text { get; set; }
        [MoTaDuLieu("Họ và tên người ghi nhận có sự việc")]
        public string HoVaTen { get; set; }
        [MoTaDuLieu("Mã nhân viên người ghi nhận sự việc")]
		public string MaNhanVien { get; set; }
        [MoTaDuLieu("Khoa")]
        public string KhoaPhong { get; set; }
        [MoTaDuLieu("Mã khoa")]
		public string MaKhoa { get; set; }
        public bool[] GhiNhanSuViecArray { get; } = new bool[] { false, false, false, false, false, false, false, false, false, false};
        [MoTaDuLieu("Danh sách ghi nhận sự việc")]
        public string GhiNhanSuViec
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < GhiNhanSuViecArray.Length; i++)
                    temp += (GhiNhanSuViecArray[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        GhiNhanSuViecArray[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        [MoTaDuLieu("Khác-ghi nhận sự việc")]
        public string GhiNhanSuViec_Khac { get; set; }
        [MoTaDuLieu("Thời gian chậm trễ")]
        public int ThoiGianChamTre { get; set; }
        [MoTaDuLieu("Họ tên người đại diện phòng KHTH")]
        public string DaiDienPhong { get; set; }
        [MoTaDuLieu("Mã nhân viên người đại diện phòng KHTH")]
        public string MaDaiDienPhong { get; set; }
        [MoTaDuLieu("Họ tên người đại diện khoa 1")]
        public string DaiDienKhoa1 { get; set; }
        [MoTaDuLieu("Mã nhân viên người đại diện khoa 1")]
        public string MaDaiDienKhoa1 { get; set; }
        [MoTaDuLieu("Tên khoa 1")]
        public string Khoa1 { get; set; }
        [MoTaDuLieu("Mã khoa 1")]
        public string MaKhoa1 { get; set; }
        [MoTaDuLieu("Họ tên người đại diện khoa 2")]
        public string DaiDienKhoa2 { get; set; }
        [MoTaDuLieu("Mã nhân viên người đại diện khoa 2")]
        public string MaDaiDienKhoa2 { get; set; }
        [MoTaDuLieu("Tên khoa 2")]
        public string Khoa2 { get; set; }
        [MoTaDuLieu("Mã khoa 2")]
        public string MaKhoa2 { get; set; }
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
    public class BangTuongTrinhDieuTriTaiThongFunc
    {
        public const string TableName = "BangTuongTrinhDieuTriTaiThong";
        public const string TablePrimaryKeyName = "Id";
        public static List<BangTuongTrinhDieuTriTaiThong> GetListData(MDB.MDBConnection _OracleConnection, decimal maquanly)
        {
            List<BangTuongTrinhDieuTriTaiThong> list = new List<BangTuongTrinhDieuTriTaiThong>();
            try
            {
                string sql = @"SELECT * FROM BANTUONGTRINHDIEUTRITAITHONG where MaQuanLy = :MaQuanLy";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, _OracleConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", maquanly));
                MDB.MDBDataReader DataReader = Command.ExecuteReader();
				if (XemBenhAn._HanhChinhBenhNhan == null) XemBenhAn._HanhChinhBenhNhan = new HanhChinhBenhNhan();
				if (XemBenhAn._ThongTinDieuTri == null) XemBenhAn._ThongTinDieuTri = new ThongTinDieuTri();
                while (DataReader.Read())
                {
                    BangTuongTrinhDieuTriTaiThong data = new BangTuongTrinhDieuTriTaiThong();
                    data.Id = Convert.ToInt64(DataReader.GetLong("ID").ToString());
                    data.TenBenhNhan = XemBenhAn._HanhChinhBenhNhan.TenBenhNhan;
                    data.Tuoi = XemBenhAn._HanhChinhBenhNhan.Tuoi;
                    data.GioiTinh = XemBenhAn._HanhChinhBenhNhan.GioiTinh;
                    data.NgayVaoVien = XemBenhAn._ThongTinDieuTri.NgayVaoVien.HasValue ? XemBenhAn._ThongTinDieuTri.NgayVaoVien.Value : DateTime.Now;
                    data.SoNhapVien = XemBenhAn._ThongTinDieuTri.SoNhapVien;
                    data.MaQuanLy = maquanly;
                    data.MaBenhNhan = XemBenhAn._HanhChinhBenhNhan.MaBenhNhan;
                    data.TaiKhoa = DataReader["TaiKhoa"].ToString();
                    data.MaTaiKhoa = DataReader["MaTaiKhoa"].ToString();
                    int temp = -1;
                    int.TryParse(DataReader["ChucVu"].ToString(), out temp);
                    data.ChucVu = temp;
                    data.ChucVu_Text = DataReader["ChucVu_Text"].ToString();
                    data.HoVaTen = DataReader["HoVaTen"].ToString();
                    data.MaNhanVien = DataReader["MaNhanVien"].ToString();
                    data.KhoaPhong = DataReader["KhoaPhong"].ToString();
                    data.MaKhoa = DataReader["MaKhoa"].ToString();
                    data.GhiNhanSuViec = DataReader["GhiNhanSuViec"].ToString();
                    data.GhiNhanSuViec_Khac = DataReader["GhiNhanSuViec_Khac"].ToString();
                    temp = -1;
                    int.TryParse(DataReader["ThoiGianChamTre"].ToString(), out temp);
                    data.ThoiGianChamTre = temp;
                    data.DaiDienPhong = DataReader["DaiDienPhong"].ToString();
                    data.MaDaiDienPhong = DataReader["MaDaiDienPhong"].ToString();
                    data.DaiDienKhoa1 = DataReader["DaiDienKhoa1"].ToString();
                    data.MaDaiDienKhoa1 = DataReader["MaDaiDienKhoa1"].ToString();
                    data.Khoa1 = DataReader["Khoa1"].ToString();
                    data.MaKhoa1 = DataReader["MaKhoa1"].ToString();
                    data.DaiDienKhoa2 = DataReader["DaiDienKhoa2"].ToString();
                    data.MaDaiDienKhoa2 = DataReader["MaDaiDienKhoa2"].ToString();
                    data.Khoa2 = DataReader["Khoa2"].ToString();
                    data.MaKhoa2 = DataReader["MaKhoa2"].ToString();
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
        public static bool InsertOrUpdate(MDB.MDBConnection MyConnection, ref BangTuongTrinhDieuTriTaiThong bangTuongTrinhDieuTriTaiThong)
        {
            try
            {
                string sql = @"INSERT INTO BANTUONGTRINHDIEUTRITAITHONG
                (
                    MAQUANLY,
                    MaBenhNhan,
                    TaiKhoa,
                    MaTaiKhoa,
                    ChucVu,
                    ChucVu_Text,
                    HoVaTen,
                    MaNhanVien,
                    KhoaPhong,
                    MaKhoa,
                    GhiNhanSuViec,
                    GhiNhanSuViec_Khac,
                    ThoiGianChamTre,
                    DaiDienPhong,
                    MaDaiDienPhong,
                    DaiDienKhoa1,
                    MaDaiDienKhoa1,
                    Khoa1,
                    MaKhoa1,
                    DaiDienKhoa2,
                    MaDaiDienKhoa2,
                    Khoa2,
                    MaKhoa2,
                    NGUOITAO,
                    NGUOISUA,
                    NGAYTAO,
                    NGAYSUA)  VALUES
                 (
				    :MAQUANLY,
                    :MaBenhNhan,
                    :TaiKhoa,
                    :MaTaiKhoa,
                    :ChucVu,
                    :ChucVu_Text,
                    :HoVaTen,
                    :MaNhanVien,
                    :KhoaPhong,
                    :MaKhoa,
                    :GhiNhanSuViec,
                    :GhiNhanSuViec_Khac,
                    :ThoiGianChamTre,
                    :DaiDienPhong,
                    :MaDaiDienPhong,
                    :DaiDienKhoa1,
                    :MaDaiDienKhoa1,
                    :Khoa1,
                    :MaKhoa1,
                    :DaiDienKhoa2,
                    :MaDaiDienKhoa2,
                    :Khoa2,
                    :MaKhoa2,
                    :NGUOITAO,
                    :NGUOISUA,
                    :NGAYTAO,
                    :NGAYSUA
                 )  RETURNING ID INTO :ID";
                if (bangTuongTrinhDieuTriTaiThong.Id != 0)
                {
                    sql = @"UPDATE BANTUONGTRINHDIEUTRITAITHONG SET 
                    MAQUANLY = :MAQUANLY,
                    MaBenhNhan = :MaBenhNhan,
                    TaiKhoa = :TaiKhoa,
                    MaTaiKhoa = :MaTaiKhoa,
                    ChucVu = :ChucVu,
                    ChucVu_Text = :ChucVu_Text,
                    HoVaTen = :HoVaTen,
                    MaNhanVien = :MaNhanVien,
                    KhoaPhong = :KhoaPhong,
                    MaKhoa = :MaKhoa,
                    GhiNhanSuViec = :GhiNhanSuViec,
                    GhiNhanSuViec_Khac = :GhiNhanSuViec_Khac,
                    ThoiGianChamTre = :ThoiGianChamTre,
                    DaiDienPhong = :DaiDienPhong,
                    MaDaiDienPhong = :MaDaiDienPhong,
                    DaiDienKhoa1 = :DaiDienKhoa1,
                    MaDaiDienKhoa1 = :MaDaiDienKhoa1,
                    Khoa1 = :Khoa1,
                    MaKhoa1 = :MaKhoa1,
                    DaiDienKhoa2 = :DaiDienKhoa2,
                    MaDaiDienKhoa2 = :MaDaiDienKhoa2,
                    Khoa2 = :Khoa2,
                    MaKhoa2 = :MaKhoa2,
                    NGUOISUA = :NGUOISUA,
                    NGAYSUA = :NGAYSUA 
                    WHERE ID = " + bangTuongTrinhDieuTriTaiThong.Id;
                }
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MAQUANLY", bangTuongTrinhDieuTriTaiThong.MaQuanLy));
                Command.Parameters.Add(new MDB.MDBParameter("MaBenhNhan", bangTuongTrinhDieuTriTaiThong.MaBenhNhan));
                Command.Parameters.Add(new MDB.MDBParameter("TaiKhoa", bangTuongTrinhDieuTriTaiThong.TaiKhoa));
                Command.Parameters.Add(new MDB.MDBParameter("MaTaiKhoa", bangTuongTrinhDieuTriTaiThong.MaTaiKhoa));
                Command.Parameters.Add(new MDB.MDBParameter("ChucVu", bangTuongTrinhDieuTriTaiThong.ChucVu));
                Command.Parameters.Add(new MDB.MDBParameter("ChucVu_Text", bangTuongTrinhDieuTriTaiThong.ChucVu_Text));
                Command.Parameters.Add(new MDB.MDBParameter("HoVaTen", bangTuongTrinhDieuTriTaiThong.HoVaTen));
                Command.Parameters.Add(new MDB.MDBParameter("MaNhanVien", bangTuongTrinhDieuTriTaiThong.MaNhanVien));
                Command.Parameters.Add(new MDB.MDBParameter("KhoaPhong", bangTuongTrinhDieuTriTaiThong.KhoaPhong));
                Command.Parameters.Add(new MDB.MDBParameter("MaKhoa", bangTuongTrinhDieuTriTaiThong.MaKhoa));
                Command.Parameters.Add(new MDB.MDBParameter("GhiNhanSuViec", bangTuongTrinhDieuTriTaiThong.GhiNhanSuViec));
                Command.Parameters.Add(new MDB.MDBParameter("GhiNhanSuViec_Khac", bangTuongTrinhDieuTriTaiThong.GhiNhanSuViec_Khac));
                Command.Parameters.Add(new MDB.MDBParameter("ThoiGianChamTre", bangTuongTrinhDieuTriTaiThong.ThoiGianChamTre));
                Command.Parameters.Add(new MDB.MDBParameter("DaiDienPhong", bangTuongTrinhDieuTriTaiThong.DaiDienPhong));
                Command.Parameters.Add(new MDB.MDBParameter("MaDaiDienPhong", bangTuongTrinhDieuTriTaiThong.MaDaiDienPhong));
                Command.Parameters.Add(new MDB.MDBParameter("DaiDienKhoa1", bangTuongTrinhDieuTriTaiThong.DaiDienKhoa1));
                Command.Parameters.Add(new MDB.MDBParameter("MaDaiDienKhoa1", bangTuongTrinhDieuTriTaiThong.MaDaiDienKhoa1));
                Command.Parameters.Add(new MDB.MDBParameter("Khoa1", bangTuongTrinhDieuTriTaiThong.Khoa1));
                Command.Parameters.Add(new MDB.MDBParameter("MaKhoa1", bangTuongTrinhDieuTriTaiThong.MaKhoa1));
                Command.Parameters.Add(new MDB.MDBParameter("DaiDienKhoa2", bangTuongTrinhDieuTriTaiThong.DaiDienKhoa2));
                Command.Parameters.Add(new MDB.MDBParameter("MaDaiDienKhoa2", bangTuongTrinhDieuTriTaiThong.MaDaiDienKhoa2));
                Command.Parameters.Add(new MDB.MDBParameter("Khoa2", bangTuongTrinhDieuTriTaiThong.Khoa2));
                Command.Parameters.Add(new MDB.MDBParameter("MaKhoa2", bangTuongTrinhDieuTriTaiThong.MaKhoa2));
                Command.Parameters.Add(new MDB.MDBParameter("NGUOISUA", bangTuongTrinhDieuTriTaiThong.NguoiSua));
                Command.Parameters.Add(new MDB.MDBParameter("NGAYSUA", bangTuongTrinhDieuTriTaiThong.NgaySua));
                if (bangTuongTrinhDieuTriTaiThong.Id == 0)
                {
                    Command.Parameters.Add(new MDB.MDBParameter("ID", bangTuongTrinhDieuTriTaiThong.Id));
                    Command.Parameters.Add(new MDB.MDBParameter("NGUOITAO", bangTuongTrinhDieuTriTaiThong.NguoiTao));
                    Command.Parameters.Add(new MDB.MDBParameter("NGAYTAO", bangTuongTrinhDieuTriTaiThong.NgayTao));
                }
                Command.BindByName = true;
                int n = Command.ExecuteNonQuery();
                if (bangTuongTrinhDieuTriTaiThong.Id == 0)
                {
                    long nextval = Convert.ToInt64((Command.Parameters["ID"] as MDB.MDBParameter).Value);
                    bangTuongTrinhDieuTriTaiThong.Id = nextval;
                }
                return n > 0 ? true : false;
            }
            catch (Exception ex)
            {
                XuLyLoi.Handle(ex);
            }
            return false;
        }
        public static bool delete(MDB.MDBConnection MyConnection, long Id)
        {
            try
            {
                string sql = "DELETE FROM BANTUONGTRINHDIEUTRITAITHONG WHERE Id = :Id";
                MDB.MDBCommand command = new MDB.MDBCommand(sql, MyConnection);
                command.Parameters.Add(new MDB.MDBParameter("Id", Id));
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
        public static DataSet getDataSet(MDB.MDBConnection MyConnection, long Id)
        {
            string sql = @"SELECT
                B.*,
                H.BENHVIEN,
                H.TENBENHNHAN,
                H.TUOI,
                H.GIOITINH,
                T.NGAYVAOVIEN,
                T.SONHAPVIEN
            FROM
                BANTUONGTRINHDIEUTRITAITHONG B LEFT JOIN THONGTINDIEUTRI T ON B.MAQUANLY = T.MAQUANLY
                LEFT JOIN HANHCHINHBENHNHAN H ON T.MABENHNHAN = H.MABENHNHAN
            WHERE
                B.Id = " + Id;

            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
            MDB.MDBDataAdapter adt = new MDB.MDBDataAdapter(Command);
            var ds = new DataSet();
            adt.Fill(ds);

            return ds;
        }
    }
}
