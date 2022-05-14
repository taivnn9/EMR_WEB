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
    public class SoMoiHoiChan : ThongTinKy
    {
        public SoMoiHoiChan()
        {
            TableName = "SoMoiHoiChan";
            TablePrimaryKeyName = "ID";
            IDMauPhieu = (int)DanhMucPhieu.SMHC;
            TenMauPhieu = DanhMucPhieu.SMHC.Description();
        }
        [MoTaDuLieu("Mã định danh")]
		public long ID { get; set; }
        [MoTaDuLieu("Mã quản lý: mã duy nhất trong 1 đợt khám chữa bệnh (kcb), không trùng giữa các đợt kcb khác nhau","",1)]
		public decimal MaQuanLy { get; set; }
        [MoTaDuLieu("Bệnh viện")]
		public string BenhVien { 
            get
            {
                return XemBenhAn._HanhChinhBenhNhan.BenhVien;
            } 
        }
        [MoTaDuLieu("Mã bệnh nhân")]
		public string MaBenhNhan { get; set; }
        [MoTaDuLieu("Ngày mời hội chẩn")]
        public DateTime NgayMoiHC { get; set; }
        [MoTaDuLieu("Thời gian hội chẩn")]
        public DateTime ThoiGianHC { get; set; }
        [MoTaDuLieu("Hình thức hội chẩn")]
        public string HinhThucHC { get; set; }
        [MoTaDuLieu("Họ tên bệnh nhân")]
        public string HoTenBenhNhan { get; set; }
        [MoTaDuLieu("Tuổi bệnh nhân")]
		public string Tuoi { get; set; }
        [MoTaDuLieu("Giới tính")]
        public string GioiTinh { get; set; }
        [MoTaDuLieu("Thời gian vào viên")]
        public DateTime ThoiGianVaoVien { get; set; }
        [MoTaDuLieu("Giường")]
		public string Giuong { get; set; }
        [MoTaDuLieu("Khoa")]
		public string Khoa { get; set; }
        [MoTaDuLieu("Mã khoa")]
		public string MaKhoa { get; set; }
        [MoTaDuLieu("Buồng")]
        public string Buong { get; set; }
        [MoTaDuLieu("Tuyến dưới ")]
		public string TuyenDuoi { get; set; }
        [MoTaDuLieu("Khoa khám bệnh")]
        public string KhoaKhamBenh { get; set; }
        [MoTaDuLieu("Khoa điều trị")]
        public string KhoaDieuTri { get; set; }
        [MoTaDuLieu("Tình trạng người bệnh")]
        public string TinhTrangNguoiBenh { get; set; }
        [MoTaDuLieu(" yêu cầu hội chẩn")]
        public string YeuCauHC { get; set; }
        [MoTaDuLieu("Hội chẩn tại")]
        public string HoiChanTai { get; set; }
        [MoTaDuLieu("Giám đốc")]
        public string GiamDoc { get; set; }
        [MoTaDuLieu("Mã giám đốc")]
		public string MaGiamDoc { get; set; }
        [MoTaDuLieu("Bác sĩ hội chẩn")]
        public string BS1 { get; set; }
        [MoTaDuLieu("Mã bác sĩ hội chẩn")]
        public string MaBS1 { get; set; }
        [MoTaDuLieu("Bác sĩ hội chẩn")]
        public string BS2 { get; set; }
        [MoTaDuLieu("Mã bác sĩ hội chẩn")]
        public string MaBS2 { get; set; }
        [MoTaDuLieu("Bác sĩ hội chẩn")]
        public string BS3 { get; set; }
        [MoTaDuLieu("Mã bác sĩ hội chẩn")]
        public string MaBS3 { get; set; }
        [MoTaDuLieu("Bác sĩ hội chẩn")]
        public string BS4 { get; set; }
        [MoTaDuLieu("Mã bác sĩ hội chẩn")]
        public string MaBS4 { get; set; }
        [MoTaDuLieu("Bác sĩ hội chẩn")]
        public string BS5 { get; set; }
        [MoTaDuLieu("Mã bác sĩ hội chẩn")]
        public string MaBS5 { get; set; }
        [MoTaDuLieu("Bác sĩ hội chẩn")]
        public string BS6 { get; set; }
        [MoTaDuLieu("Mã bác sĩ hội chẩn")]
        public string MaBS6 { get; set; }
        [MoTaDuLieu("Bác sĩ hội chẩn")]
        public string BS7 { get; set; }
        [MoTaDuLieu("Mã bác sĩ hội chẩn")]
        public string MaBS7 { get; set; }
        [MoTaDuLieu("Bác sĩ hội chẩn")]
        public string BS8 { get; set; }
        [MoTaDuLieu("Mã bác sĩ hội chẩn")]
        public string MaBS8 { get; set; }
        [MoTaDuLieu("Bác sĩ hội chẩn")]
        public string BS9 { get; set; }
        [MoTaDuLieu("Mã bác sĩ hội chẩn")]
        public string MaBS9 { get; set; }
        [MoTaDuLieu("Bác sĩ hội chẩn")]
        public string BS10 { get; set; }
        [MoTaDuLieu("Mã bác sĩ hội chẩn")]
        public string MaBS10 { get; set; }
        [MoTaDuLieu("Khoa 1")]
        public string Khoa1 { get; set; }
        [MoTaDuLieu("Mã khoa 1")]
        public string MaKhoa1 { get; set; }
        [MoTaDuLieu("Khoa 1")]
        public string Khoa2 { get; set; }
        [MoTaDuLieu("Mã khoa 1")]
        public string MaKhoa2 { get; set; }
        [MoTaDuLieu("Khoa 1")]
        public string Khoa3 { get; set; }
        [MoTaDuLieu("Mã khoa 1")]
        public string MaKhoa3 { get; set; }
        [MoTaDuLieu("Khoa 1")]
        public string Khoa4 { get; set; }
        [MoTaDuLieu("Mã khoa 1")]
        public string MaKhoa4 { get; set; }
        [MoTaDuLieu("Khoa 1")]
        public string Khoa5 { get; set; }
        [MoTaDuLieu("Mã khoa 1")]
        public string MaKhoa5 { get; set; }
        [MoTaDuLieu("Khoa 1")]
        public string Khoa6 { get; set; }
        [MoTaDuLieu("Mã khoa 1")]
        public string MaKhoa6 { get; set; }
        [MoTaDuLieu("Khoa 1")]
        public string Khoa7 { get; set; }
        [MoTaDuLieu("Mã khoa 1")]
        public string MaKhoa7 { get; set; }
        [MoTaDuLieu("Khoa 1")]
        public string Khoa8 { get; set; }
        [MoTaDuLieu("Mã khoa 1")]
        public string MaKhoa8 { get; set; }
        [MoTaDuLieu("Khoa 1")]
        public string Khoa9 { get; set; }
        [MoTaDuLieu("Mã khoa 1")]
        public string MaKhoa9 { get; set; }
        [MoTaDuLieu("Khoa 1")]
        public string Khoa10 { get; set; }
        [MoTaDuLieu("Mã khoa 1")]
        public string MaKhoa10 { get; set; }
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
    public class SoMoiHoiChanFunc
    {
        public const string TableName = "SoMoiHoiChan";
        public const string TablePrimaryKeyName = "ID";
        public static List<SoMoiHoiChan> GetListData(MDB.MDBConnection _OracleConnection, decimal maquanly)
        {
            List<SoMoiHoiChan> list = new List<SoMoiHoiChan>();
            try
            {
                string sql = @"SELECT * FROM SoMoiHoiChan where MaQuanLy = :MaQuanLy";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, _OracleConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", maquanly));
                MDB.MDBDataReader DataReader = Command.ExecuteReader();
                while (DataReader.Read())
                {
                    SoMoiHoiChan data = new SoMoiHoiChan();
                    data.ID = Convert.ToInt64(DataReader.GetLong("ID").ToString());
                    data.MaQuanLy = maquanly;
                    data.MaBenhNhan = DataReader["MaBenhNhan"].ToString();
                    data.NgayMoiHC = Common.ConDB_DateTime(DataReader["NgayMoiHC"]);
                    data.HoiChanTai = DataReader["HoiChanTai"].ToString();
                    data.GioiTinh = DataReader["GioiTinh"].ToString();
                    data.ThoiGianHC = Common.ConDB_DateTime(DataReader["ThoiGianHC"]);
                    data.HinhThucHC = DataReader["HinhThucHC"].ToString();
                    data.HoTenBenhNhan = DataReader["HoTenBenhNhan"].ToString();
                    data.Tuoi = DataReader["Tuoi"].ToString();
                    data.GioiTinh = DataReader["GioiTinh"].ToString();
                    data.ThoiGianVaoVien = Common.ConDB_DateTime(DataReader["ThoiGianVaoVien"]);
                    data.Giuong = DataReader["Giuong"].ToString();
                    data.Khoa = DataReader["Khoa"].ToString();
                    data.MaKhoa = DataReader["MaKhoa"].ToString();
                    data.Buong = DataReader["Buong"].ToString();
                    data.TuyenDuoi = DataReader["TuyenDuoi"].ToString();
                    data.KhoaKhamBenh = DataReader["KhoaKhamBenh"].ToString();
                    data.KhoaDieuTri = DataReader["KhoaDieuTri"].ToString();
                    data.TinhTrangNguoiBenh = DataReader["TinhTrangNguoiBenh"].ToString();
                    data.YeuCauHC = DataReader["YeuCauHC"].ToString();
                    data.GiamDoc = DataReader["GiamDoc"].ToString();
                    data.MaGiamDoc = DataReader["MaGiamDoc"].ToString();
                    data.BS1 = DataReader["BS1"].ToString();
                    data.MaBS1 = DataReader["MaBS1"].ToString();
                    data.BS2 = DataReader["BS2"].ToString();
                    data.MaBS2 = DataReader["MaBS2"].ToString();
                    data.BS3 = DataReader["BS3"].ToString();
                    data.MaBS3 = DataReader["MaBS3"].ToString();
                    data.BS4 = DataReader["BS4"].ToString();
                    data.MaBS4 = DataReader["MaBS4"].ToString();
                    data.BS5 = DataReader["BS5"].ToString();
                    data.MaBS5 = DataReader["MaBS5"].ToString();
                    data.BS6 = DataReader["BS6"].ToString();
                    data.MaBS6 = DataReader["MaBS6"].ToString();
                    data.BS7 = DataReader["BS7"].ToString();
                    data.MaBS7 = DataReader["MaBS7"].ToString();
                    data.BS8 = DataReader["BS8"].ToString();
                    data.MaBS8 = DataReader["MaBS8"].ToString();
                    data.BS9 = DataReader["BS9"].ToString();
                    data.MaBS9 = DataReader["MaBS9"].ToString();
                    data.BS10 = DataReader["BS10"].ToString();
                    data.MaBS10 = DataReader["MaBS10"].ToString();
                    data.Khoa1 = DataReader["Khoa1"].ToString();
                    data.MaKhoa1 = DataReader["MaKhoa1"].ToString();
                    data.Khoa2 = DataReader["Khoa2"].ToString();
                    data.Khoa3 = DataReader["Khoa3"].ToString();
                    data.MaKhoa3 = DataReader["MaKhoa3"].ToString();
                    data.Khoa4 = DataReader["Khoa4"].ToString();
                    data.MaKhoa4 = DataReader["MaKhoa4"].ToString();
                    data.Khoa5 = DataReader["Khoa5"].ToString();
                    data.MaKhoa5 = DataReader["MaKhoa5"].ToString();
                    data.Khoa6 = DataReader["Khoa6"].ToString();
                    data.MaKhoa6 = DataReader["MaKhoa6"].ToString();
                    data.Khoa7 = DataReader["Khoa7"].ToString();
                    data.MaKhoa7 = DataReader["MaKhoa7"].ToString();
                    data.Khoa8 = DataReader["Khoa8"].ToString();
                    data.MaKhoa8 = DataReader["MaKhoa8"].ToString();
                    data.Khoa9 = DataReader["Khoa9"].ToString();
                    data.MaKhoa9 = DataReader["MaKhoa9"].ToString();
                    data.Khoa10 = DataReader["Khoa10"].ToString();
                    data.MaKhoa10 = DataReader["MaKhoa10"].ToString();
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
        public static bool InsertOrUpdate(MDB.MDBConnection MyConnection, ref SoMoiHoiChan ketQua)
        {
            try
            {
                string sql = @"INSERT INTO SoMoiHoiChan
                (
                    MAQUANLY,
                    MaBenhNhan,
                    NgayMoiHC,
                    HoiChanTai,
                    ThoiGianHC,
                    HinhThucHC,
                    HoTenBenhNhan,
                    Tuoi,
                    GioiTinh,
                    ThoiGianVaoVien,
                    Giuong,
                    Khoa,
                    MaKhoa,
                    Buong,
                    TuyenDuoi,
                    KhoaKhamBenh,
                    KhoaDieuTri,
                    TinhTrangNguoiBenh,
                    YeuCauHC,
                    GiamDoc,
                    MaGiamDoc,
                    BS1,
                    MaBS1,
                    BS2,
                    MaBS2,
                    BS3,
                    MaBS3,
                    BS4,
                    MaBS4,
                    BS5,
                    MaBS5,
                    BS6,
                    MaBS6,
                    BS7,
                    MaBS7,
                    BS8,
                    MaBS8,
                    BS9,
                    MaBS9,
                    BS10,
                    MaBS10,
                    Khoa1,
                    MaKhoa1,
                    Khoa2,
                    MaKhoa2,
                    Khoa3,
                    MaKhoa3,
                    Khoa4,
                    MaKhoa4,
                    Khoa5,
                    MaKhoa5,
                    Khoa6,
                    MaKhoa6,
                    Khoa7,
                    MaKhoa7,
                    Khoa8,
                    MaKhoa8,
                    Khoa9,
                    MaKhoa9,
                    Khoa10,
                    MaKhoa10,
                    NGUOITAO,
                    NGUOISUA,
                    NGAYTAO,
                    NGAYSUA)  VALUES
                 (
				    :MAQUANLY,
                    :MaBenhNhan,
                    :NgayMoiHC,
                    :HoiChanTai,
                    :ThoiGianHC,
                    :HinhThucHC,
                    :HoTenBenhNhan,
                    :Tuoi,
                    :GioiTinh,
                    :ThoiGianVaoVien,
                    :Giuong,
                    :Khoa,
                    :MaKhoa,
                    :Buong,
                    :TuyenDuoi,
                    :KhoaKhamBenh,
                    :KhoaDieuTri,
                    :TinhTrangNguoiBenh,
                    :YeuCauHC,
                    :GiamDoc,
                    :MaGiamDoc,
                    :BS1,
                    :MaBS1,
                    :BS2,
                    :MaBS2,
                    :BS3,
                    :MaBS3,
                    :BS4,
                    :MaBS4,
                    :BS5,
                    :MaBS5,
                    :BS6,
                    :MaBS6,
                    :BS7,
                    :MaBS7,
                    :BS8,
                    :MaBS8,
                    :BS9,
                    :MaBS9,
                    :BS10,
                    :MaBS10,
                    :Khoa1,
                    :MaKhoa1,
                    :Khoa2,
                    :MaKhoa2,
                    :Khoa3,
                    :MaKhoa3,
                    :Khoa4,
                    :MaKhoa4,
                    :Khoa5,
                    :MaKhoa5,
                    :Khoa6,
                    :MaKhoa6,
                    :Khoa7,
                    :MaKhoa7,
                    :Khoa8,
                    :MaKhoa8,
                    :Khoa9,
                    :MaKhoa9,
                    :Khoa10,
                    :MaKhoa10,
                    :NGUOITAO,
                    :NGUOISUA,
                    :NGAYTAO,
                    :NGAYSUA
                 )  RETURNING ID INTO :ID";
                if (ketQua.ID != 0)
                {
                    sql = @"UPDATE SoMoiHoiChan SET 
                    MAQUANLY = :MAQUANLY,
                    MaBenhNhan = :MaBenhNhan,
                    NgayMoiHC =:NgayMoiHC,
                    HoiChanTai =:HoiChanTai,
                    ThoiGianHC =:ThoiGianHC,
                    HinhThucHC =:HinhThucHC,
                    HoTenBenhNhan =:HoTenBenhNhan,
                    Tuoi =:Tuoi,
                    GioiTinh =:GioiTinh,
                    ThoiGianVaoVien =:ThoiGianVaoVien,
                    Giuong =:Giuong,
                    Khoa =:Khoa,
                    MaKhoa =:MaKhoa,
                    Buong =:Buong,
                    TuyenDuoi =:TuyenDuoi,
                    KhoaKhamBenh =:KhoaKhamBenh,
                    KhoaDieuTri =:KhoaDieuTri,
                    TinhTrangNguoiBenh =:TinhTrangNguoiBenh,
                    YeuCauHC =:YeuCauHC,
                    GiamDoc =:GiamDoc,
                    MaGiamDoc =:MaGiamDoc,
                    BS1 =:BS1,
                    MaBS1 =:MaBS1,
                    BS2 =:BS2,
                    MaBS2 =:MaBS2,
                    BS3 =:BS3,
                    MaBS3 =:MaBS3,
                    BS4 =:BS4,
                    MaBS4 =:MaBS4,
                    BS5 =:BS5,
                    MaBS5 =:MaBS5,
                    BS6 =:BS6,
                    MaBS6 =:MaBS6,
                    BS7 =:BS7,
                    MaBS7 =:MaBS7,
                    BS8 =:BS8,
                    MaBS8 =:MaBS8,
                    BS9 =:BS9,
                    MaBS9 =:MaBS9,
                    BS10 =:BS10,
                    MaBS10 =:MaBS10,
                    Khoa1 =:Khoa1,
                    MaKhoa1 =:MaKhoa1,
                    Khoa2 =:Khoa2,
                    MaKhoa2 =:MaKhoa2,
                    Khoa3 =:Khoa3,
                    MaKhoa3 =:MaKhoa3,
                    Khoa4 =:Khoa4,
                    MaKhoa4 =:MaKhoa4,
                    Khoa5 =:Khoa5,
                    MaKhoa5 =:MaKhoa5,
                    Khoa6 =:Khoa6,
                    MaKhoa6 =:MaKhoa6,
                    Khoa7 =:Khoa7,
                    MaKhoa7 =:MaKhoa7,
                    Khoa8 =:Khoa8,
                    MaKhoa8 =:MaKhoa8,
                    Khoa9 =:Khoa9,
                    MaKhoa9 =:MaKhoa9,
                    Khoa10 =:Khoa10,
                    MaKhoa10 =:MaKhoa10,
                    NGUOISUA = :NGUOISUA,
                    NGAYSUA = :NGAYSUA
                    WHERE ID = " + ketQua.ID;
                }
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MAQUANLY", ketQua.MaQuanLy));
                Command.Parameters.Add(new MDB.MDBParameter("MaBenhNhan", ketQua.MaBenhNhan));
                Command.Parameters.Add(new MDB.MDBParameter("NgayMoiHC", ketQua.NgayMoiHC));
                Command.Parameters.Add(new MDB.MDBParameter("HoiChanTai", ketQua.HoiChanTai));
                Command.Parameters.Add(new MDB.MDBParameter("ThoiGianHC", ketQua.ThoiGianHC));
                Command.Parameters.Add(new MDB.MDBParameter("HinhThucHC", ketQua.HinhThucHC));
                Command.Parameters.Add(new MDB.MDBParameter("HoTenBenhNhan", ketQua.HoTenBenhNhan));
                Command.Parameters.Add(new MDB.MDBParameter("Tuoi", ketQua.Tuoi));
                Command.Parameters.Add(new MDB.MDBParameter("GioiTinh", ketQua.GioiTinh));
                Command.Parameters.Add(new MDB.MDBParameter("ThoiGianVaoVien", ketQua.ThoiGianVaoVien));
                Command.Parameters.Add(new MDB.MDBParameter("Giuong", ketQua.Giuong));
                Command.Parameters.Add(new MDB.MDBParameter("Khoa", ketQua.Khoa));
                Command.Parameters.Add(new MDB.MDBParameter("MaKhoa", ketQua.MaKhoa));
                Command.Parameters.Add(new MDB.MDBParameter("Buong", ketQua.Buong));
                Command.Parameters.Add(new MDB.MDBParameter("TuyenDuoi", ketQua.TuyenDuoi));
                Command.Parameters.Add(new MDB.MDBParameter("KhoaKhamBenh", ketQua.KhoaKhamBenh));
                Command.Parameters.Add(new MDB.MDBParameter("KhoaDieuTri", ketQua.KhoaDieuTri));
                Command.Parameters.Add(new MDB.MDBParameter("TinhTrangNguoiBenh", ketQua.TinhTrangNguoiBenh));
                Command.Parameters.Add(new MDB.MDBParameter("YeuCauHC", ketQua.YeuCauHC));
                Command.Parameters.Add(new MDB.MDBParameter("GiamDoc", ketQua.GiamDoc));
                Command.Parameters.Add(new MDB.MDBParameter("MaGiamDoc", ketQua.MaGiamDoc));
                Command.Parameters.Add(new MDB.MDBParameter("BS1", ketQua.BS1));
                Command.Parameters.Add(new MDB.MDBParameter("MaBS1", ketQua.MaBS1));
                Command.Parameters.Add(new MDB.MDBParameter("BS2", ketQua.BS2));
                Command.Parameters.Add(new MDB.MDBParameter("MaBS2", ketQua.MaBS2));
                Command.Parameters.Add(new MDB.MDBParameter("BS3", ketQua.BS3));
                Command.Parameters.Add(new MDB.MDBParameter("MaBS3", ketQua.MaBS3));
                Command.Parameters.Add(new MDB.MDBParameter("BS4", ketQua.BS4));
                Command.Parameters.Add(new MDB.MDBParameter("MaBS4", ketQua.MaBS4));
                Command.Parameters.Add(new MDB.MDBParameter("BS5", ketQua.BS5));
                Command.Parameters.Add(new MDB.MDBParameter("MaBS5", ketQua.MaBS5));
                Command.Parameters.Add(new MDB.MDBParameter("BS6", ketQua.BS6));
                Command.Parameters.Add(new MDB.MDBParameter("MaBS6", ketQua.MaBS6));
                Command.Parameters.Add(new MDB.MDBParameter("BS7", ketQua.BS7));
                Command.Parameters.Add(new MDB.MDBParameter("MaBS7", ketQua.MaBS7));
                Command.Parameters.Add(new MDB.MDBParameter("BS8", ketQua.BS8));
                Command.Parameters.Add(new MDB.MDBParameter("MaBS8", ketQua.MaBS8));
                Command.Parameters.Add(new MDB.MDBParameter("BS9", ketQua.BS9));
                Command.Parameters.Add(new MDB.MDBParameter("MaBS9", ketQua.MaBS9));
                Command.Parameters.Add(new MDB.MDBParameter("BS10", ketQua.BS10));
                Command.Parameters.Add(new MDB.MDBParameter("MaBS10", ketQua.MaBS10));
                Command.Parameters.Add(new MDB.MDBParameter("Khoa1", ketQua.Khoa1));
                Command.Parameters.Add(new MDB.MDBParameter("MaKhoa1", ketQua.MaKhoa1));
                Command.Parameters.Add(new MDB.MDBParameter("Khoa2", ketQua.Khoa2));
                Command.Parameters.Add(new MDB.MDBParameter("MaKhoa2", ketQua.MaKhoa2));
                Command.Parameters.Add(new MDB.MDBParameter("Khoa3", ketQua.Khoa3));
                Command.Parameters.Add(new MDB.MDBParameter("MaKhoa3", ketQua.MaKhoa3));
                Command.Parameters.Add(new MDB.MDBParameter("Khoa4", ketQua.Khoa4));
                Command.Parameters.Add(new MDB.MDBParameter("MaKhoa4", ketQua.MaKhoa4));
                Command.Parameters.Add(new MDB.MDBParameter("Khoa5", ketQua.Khoa5));
                Command.Parameters.Add(new MDB.MDBParameter("MaKhoa5", ketQua.MaKhoa5));
                Command.Parameters.Add(new MDB.MDBParameter("Khoa6", ketQua.Khoa6));
                Command.Parameters.Add(new MDB.MDBParameter("MaKhoa6", ketQua.MaKhoa6));
                Command.Parameters.Add(new MDB.MDBParameter("Khoa7", ketQua.Khoa7));
                Command.Parameters.Add(new MDB.MDBParameter("MaKhoa7", ketQua.MaKhoa7));
                Command.Parameters.Add(new MDB.MDBParameter("Khoa8", ketQua.Khoa8));
                Command.Parameters.Add(new MDB.MDBParameter("MaKhoa8", ketQua.MaKhoa8));
                Command.Parameters.Add(new MDB.MDBParameter("Khoa9", ketQua.Khoa9));
                Command.Parameters.Add(new MDB.MDBParameter("MaKhoa9", ketQua.MaKhoa9));
                Command.Parameters.Add(new MDB.MDBParameter("Khoa10", ketQua.Khoa10));
                Command.Parameters.Add(new MDB.MDBParameter("MaKhoa10", ketQua.MaKhoa10));
                Command.Parameters.Add(new MDB.MDBParameter("NGUOISUA", ketQua.NguoiSua));
                Command.Parameters.Add(new MDB.MDBParameter("NGAYSUA", ketQua.NgaySua));
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
                XuLyLoi.Handle(ex);
            }
            return false;
        }
        public static bool delete(MDB.MDBConnection MyConnection, long id)
        {
            try
            {
                string sql = "DELETE FROM SoMoiHoiChan WHERE ID = :ID";
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
                P.* 
            FROM
                SoMoiHoiChan P
            WHERE
                ID = " + id;

            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
            MDB.MDBDataAdapter adt = new MDB.MDBDataAdapter(Command);
            var ds = new DataSet();
            adt.Fill(ds, "KQ");
            return ds;
        }
    }
}
