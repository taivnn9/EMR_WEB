using EMR.KyDienTu;
using Newtonsoft.Json;
using PMS.Access;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace EMR_MAIN.DATABASE.Other
{
    public class ThongTinNhap
    {
        public int? DichTruyen { get; set; }
        public int? Thuoc { get; set; }
        public int? Mau { get; set; }
        public int? ThucAn { get; set; }
        public int? Nuoc { get; set; }
        public int? Khac { get; set; }
        public int? Tong { get; set; }
    }
    public class ThongTinXuat
    {
        public int? Non { get; set; }
        public int? DichDaDay { get; set; }
        public string DichDanLuu1_Text { get; set; }
        public int? DichDanLuu1 { get; set; }
        public string DichDanLuu2_Text { get; set; }
        public int? DichDanLuu2 { get; set; }
        public string DichDanLuu3_Text { get; set; }
        public int? DichDanLuu3 { get; set; }
        public int? NuocTieu { get; set; }
        public int? Phan { get; set; }
        public int? Khac { get; set; }
        public int? Tong { get; set; }
    }
    public class ThongTinTheoGio
    {
        [MoTaDuLieu("Mã định danh")]
		public long ID;
        [MoTaDuLieu("Mã định danh")]
		public long ID_Phieu { get; set; }
        public int CaThu { get; set; }
        public int Gio { get; set; }
        public int? M { get; set; }
        public double? HAMax { get; set; }
        public double? HAMin { get; set; }
        public double? T { get; set; }
        public double? NhipTho { get; set; }
        public double? SpO2 { get; set; }
        public string HATB { get; set; }
        public string DaNiem { get; set; }
        public string ModeNkq { get; set; }
        public string ApLucBongChen { get; set; }
        public string ApLucDuongTho { get; set; }
        public string PEEP { get; set; }
        public string VM { get; set; }
        public string PhongNguaLoet { get; set; }
        public string TuTheBenhNhan { get; set; }
        public string ChamSocCuaDieuDuong { get; set; }
        public double? DuongMauTaiGiuong { get; set; }
        public string CanLamSan { get; set; }
        public string Dam { get; set; }
        public string Glasgow { get; set; }
        public string NKQ { get; set; }
        public string TMTT { get; set; }
        public string Viem { get; set; }
        public string Phu { get; set; }
        public string VietThuong { get; set; }
        public string Sonde { get; set; }
        public string NhuDongRuot { get; set; }
        public string SondeTieuNgay { get; set; }
    }
    public class BangThucHienThuoc
    {
        [MoTaDuLieu("Mã định danh")]
		public long ID { get; set; }
        [MoTaDuLieu("Mã định danh")]
		public long ID_Phieu { get; set; }
        public string TenThuocHamLuong { get; set; }
        public string LieuLuongDuongDung { get; set; }
        public DateTime Ngay { get; set; }
        public string Gio { get; set; }
    }
    public class TheoDoiCanThiep
    {
        public DateTime Gio { get; set; }
        public string TheoDoi { get; set; }
    }
    public class PhieuTheoDoiChamSocBenhNhanCap1 : ThongTinKy
    {
        public PhieuTheoDoiChamSocBenhNhanCap1()
        {
            TableName = "PhieuTDCSBenhNhanCap1";
            TablePrimaryKeyName = "ID";
            IDMauPhieu = (int)DanhMucPhieu.TDCSBNC1;
            TenMauPhieu = DanhMucPhieu.TDCSBNC1.Description();
        }
        [MoTaDuLieu("Mã định danh")]
		public long ID { get; set; }
        [MoTaDuLieu("Mã quản lý: mã duy nhất trong 1 đợt khám chữa bệnh (kcb), không trùng giữa các đợt kcb khác nhau","",1)]
		public decimal MaQuanLy { get; set; }
        [MoTaDuLieu("Mã bệnh nhân")]
		public string MaBenhNhan { get; set; }
        [MoTaDuLieu("Họ và tên bệnh nhân")]
		public string TenBenhNhan { get; set; }
        [MoTaDuLieu("Tuổi bệnh nhân")]
		public string Tuoi { get; set; }
        [MoTaDuLieu("Giới tính bệnh nhân")]
		public string GioiTinh { get; set; }
        [MoTaDuLieu("Số bệnh án")]
		public string SoBenhAn { get; set; }
        [MoTaDuLieu("Khoa")]
		public string Khoa { get; set; }
        [MoTaDuLieu("Mã khoa")]
		public string MaKhoa { get; set; }
        public int NgayDieuTriThu { get; set; }
        [MoTaDuLieu("Giường")]
		public string Giuong { get; set; }
        [MoTaDuLieu("Chẩn đoán bệnh")]
		public string ChanDoan { get; set; }
        [MoTaDuLieu("Bác sỹ điều trị")]
		public string BacSyDieuTri { get; set; }
        [MoTaDuLieu("Mã bác sỹ điều trị")]
		public string MaBacSyDieuTri { get; set; }
        [MoTaDuLieu("Họ tên điều dưỡng")]
		public string DieuDuongCa1 { get; set; }
        [MoTaDuLieu("Mã điều dưỡng")]
		public string MaDieuDuongCa1 { get; set; }
        [MoTaDuLieu("Họ tên điều dưỡng")]
		public string DieuDuongCa2 { get; set; }
        [MoTaDuLieu("Mã điều dưỡng")]
		public string MaDieuDuongCa2 { get; set; }
        [MoTaDuLieu("Họ tên điều dưỡng")]
		public string DieuDuongCa3 { get; set; }
        [MoTaDuLieu("Mã điều dưỡng")]
		public string MaDieuDuongCa3 { get; set; }
        public ObservableCollection<TheoDoiCanThiep> TheoDoiCanThiep { get; set; }
        // Thong tin theo gio
        public ObservableCollection<ThongTinTheoGio> ThongTinGio_Ca1 { get; set; }
        public ObservableCollection<ThongTinTheoGio> ThongTinGio_Ca2 { get; set; }
        public ObservableCollection<ThongTinTheoGio> ThongTinGio_Ca3 { get; set; }
        // Thong tin bang thuc hien thuoc
        public ObservableCollection<BangThucHienThuoc> BangThucHienThuoc { get; set; }
        [MoTaDuLieu("Mã điều dưỡng")]
		public string MaDieuDuongThucHienThuocCa1 { get; set; }
        [MoTaDuLieu("Họ tên điều dưỡng")]
		public string DieuDuongThucHienThuocCa1 { get; set; }
        [MoTaDuLieu("Mã điều dưỡng")]
		public string MaDieuDuongThucHienThuocCa2 { get; set; }
        [MoTaDuLieu("Họ tên điều dưỡng")]
		public string DieuDuongThucHienThuocCa2 { get; set; }
        [MoTaDuLieu("Mã điều dưỡng")]
		public string MaDieuDuongThucHienThuocCa3 { get; set; }
        [MoTaDuLieu("Họ tên điều dưỡng")]
		public string DieuDuongThucHienThuocCa3 { get; set; }
        public string BaoGiaoThuocCa1 { get; set; }
        public string BaoGiaoThuocCa2 { get; set; }
        public string BaoGiaoThuocCa3 { get; set; }
        public string MaBaoGiaoThuocCa1 { get; set; }
        public string MaBaoGiaoThuocCa2 { get; set; }
        public string MaBaoGiaoThuocCa3 { get; set; }
        // Thong tin xuat nhap
        public ThongTinNhap Nhap_Ca1 { get; set; }
        public ThongTinNhap Nhap_Ca2 { get; set; }
        public ThongTinNhap Nhap_Ca3 { get; set; }
        public ThongTinXuat Xuat_Ca1 { get; set; }
        public ThongTinXuat Xuat_Ca2 { get; set; }
        public ThongTinXuat Xuat_Ca3 { get; set; }
        public int TongNhap24h { get; set; }
        public int TongXuat24h { get; set; }
        public int TongBilan24h { get; set; }
        public string BanGiao { get; set; }
        [MoTaDuLieu("Ngày tạo", null, 0, 0)]
		public DateTime NgayTao { get; set; }
        public DateTime NgayThucHienThuoc { get; set; }
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
    public class PhieuTheoDoiChamSocBenhNhanCap1Func
    {
        public const string TableName = "PhieuTheoDoiChamSocBenhNhanCap1";
        public const string TablePrimaryKeyName = "ID";
        public static PhieuTheoDoiChamSocBenhNhanCap1 GetData(MDB.MDBConnection _OracleConnection, decimal maquanly , decimal ID)
        {
            PhieuTheoDoiChamSocBenhNhanCap1 list = new PhieuTheoDoiChamSocBenhNhanCap1();
            try
            {
                string sql = @"SELECT B.*,
                T.MABENHNHAN,
                H.SOYTE,
                H.BENHVIEN
                FROM PhieuTDCSBenhNhanCap1 B
                LEFT JOIN THONGTINDIEUTRI T ON B.MAQUANLY = T.MAQUANLY
                LEFT JOIN HANHCHINHBENHNHAN H ON T.MABENHNHAN = H.MABENHNHAN
                where B.ID =:ID And B.MaQuanLy = :MaQuanLy";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, _OracleConnection);
                Command.Parameters.Add(new MDB.MDBParameter("ID", ID));
                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", maquanly));
                MDB.MDBDataReader DataReader = Command.ExecuteReader();
                while (DataReader.Read())
                {
                    PhieuTheoDoiChamSocBenhNhanCap1 data = new PhieuTheoDoiChamSocBenhNhanCap1();
                    data.ID = Convert.ToInt64(DataReader.GetLong("ID").ToString());
                    data.MaQuanLy = maquanly;
                    data.MaBenhNhan = DataReader["MaBenhNhan"].ToString();
                    data.Khoa = DataReader["Khoa"].ToString();
                    data.MaKhoa = DataReader["MaKhoa"].ToString();
                    data.ChanDoan = DataReader["ChanDoan"].ToString();
                    data.TenBenhNhan = DataReader["TenBenhNhan"].ToString();
                    data.Tuoi = DataReader["Tuoi"].ToString();
                    data.GioiTinh = DataReader["GioiTinh"].ToString();
                    data.SoBenhAn = DataReader["SoBenhAn"].ToString();
                    data.Giuong = DataReader["Giuong"].ToString();
                    int tempInt = -1;
                    int.TryParse(DataReader["NgayDieuTriThu"].ToString(), out tempInt);
                    data.NgayDieuTriThu = tempInt;

                    data.BacSyDieuTri = DataReader["BacSyDieuTri"].ToString();
                    data.MaBacSyDieuTri = DataReader["MaBacSyDieuTri"].ToString();
                    data.DieuDuongCa1 = DataReader["DieuDuongCa1"].ToString();
                    data.MaDieuDuongCa1 = DataReader["MaDieuDuongCa1"].ToString();
                    data.DieuDuongCa2 = DataReader["DieuDuongCa2"].ToString();
                    data.MaDieuDuongCa2 = DataReader["MaDieuDuongCa2"].ToString();
                    data.DieuDuongCa3 = DataReader["DieuDuongCa3"].ToString();
                    data.MaDieuDuongCa3 = DataReader["MaDieuDuongCa3"].ToString();
                    data.TheoDoiCanThiep = JsonConvert.DeserializeObject<ObservableCollection<TheoDoiCanThiep>>(DataReader["TheoDoiCanThiep"].ToString());
                    data.Nhap_Ca1 = JsonConvert.DeserializeObject<ThongTinNhap>(DataReader["Nhap_Ca1"].ToString());
                    data.Nhap_Ca2 = JsonConvert.DeserializeObject<ThongTinNhap>(DataReader["Nhap_Ca2"].ToString());
                    data.Nhap_Ca3 = JsonConvert.DeserializeObject<ThongTinNhap>(DataReader["Nhap_Ca3"].ToString());
                    data.Xuat_Ca1 = JsonConvert.DeserializeObject<ThongTinXuat>(DataReader["Xuat_Ca1"].ToString());
                    data.Xuat_Ca2 = JsonConvert.DeserializeObject<ThongTinXuat>(DataReader["Xuat_Ca2"].ToString());
                    data.Xuat_Ca3 = JsonConvert.DeserializeObject<ThongTinXuat>(DataReader["Xuat_Ca3"].ToString());

                    tempInt = -1;
                    int.TryParse(DataReader["TongNhap24h"].ToString(), out tempInt);
                    data.TongNhap24h = tempInt;
                    tempInt = -1;
                    int.TryParse(DataReader["TongXuat24h"].ToString(), out tempInt);
                    data.TongXuat24h = tempInt;
                    tempInt = -1;
                    int.TryParse(DataReader["TongBilan24h"].ToString(), out tempInt);
                    data.TongBilan24h = tempInt;
                    data.BanGiao = DataReader["BanGiao"].ToString();

                    data.MaDieuDuongThucHienThuocCa1 = DataReader["MaDieuDuongThucHienThuocCa1"].ToString();
                    data.DieuDuongThucHienThuocCa1 = DataReader["DieuDuongThucHienThuocCa1"].ToString();
                    data.MaDieuDuongThucHienThuocCa2 = DataReader["MaDieuDuongThucHienThuocCa2"].ToString();
                    data.DieuDuongThucHienThuocCa2 = DataReader["DieuDuongThucHienThuocCa2"].ToString();
                    data.MaDieuDuongThucHienThuocCa3 = DataReader["MaDieuDuongThucHienThuocCa3"].ToString();
                    data.DieuDuongThucHienThuocCa3 = DataReader["DieuDuongThucHienThuocCa3"].ToString();
                    data.BaoGiaoThuocCa1 = DataReader["BaoGiaoThuocCa1"].ToString();
                    data.BaoGiaoThuocCa2 = DataReader["BaoGiaoThuocCa2"].ToString();
                    data.BaoGiaoThuocCa3 = DataReader["BaoGiaoThuocCa3"].ToString();

                    data.MaBaoGiaoThuocCa1 = DataReader["MaBaoGiaoThuocCa1"].ToString();
                    data.MaBaoGiaoThuocCa2 = DataReader["MaBaoGiaoThuocCa2"].ToString();
                    data.MaBaoGiaoThuocCa3 = DataReader["MaBaoGiaoThuocCa3"].ToString();

                    data.ThongTinGio_Ca1 = getThongTinTheoGio(_OracleConnection, data.ID, 1);
                    data.ThongTinGio_Ca2 = getThongTinTheoGio(_OracleConnection, data.ID, 2);
                    data.ThongTinGio_Ca3 = getThongTinTheoGio(_OracleConnection, data.ID, 3);

                    data.BangThucHienThuoc = getBangThucHienThuoc(_OracleConnection, data.ID);

                    data.NgayTao = Convert.ToDateTime(DataReader["NgayTao"] == DBNull.Value ? DateTime.Now : DataReader["NgayTao"]);
                    data.NgayThucHienThuoc = Convert.ToDateTime(DataReader["NgayThucHienThuoc"] == DBNull.Value ? DateTime.Now : DataReader["NgayThucHienThuoc"]);
                    data.NguoiTao = DataReader["NguoiTao"].ToString();
                    data.NgaySua = Convert.ToDateTime(DataReader["NgaySua"] == DBNull.Value ? DateTime.Now : DataReader["NgaySua"]);
                    data.NguoiSua = DataReader["NguoiSua"].ToString();

                    data.MaSoKy = DataReader["masokyten"].ToString();
                    data.DaKy = !string.IsNullOrEmpty(data.MaSoKy) ? true : false;
                    list = data;
                }
            }
            catch (Exception ex) { throw ex; }
            return list;
        }
        public static List<PhieuTheoDoiChamSocBenhNhanCap1> GetListData(MDB.MDBConnection _OracleConnection, decimal maquanly)
        {
            List<PhieuTheoDoiChamSocBenhNhanCap1> list = new List<PhieuTheoDoiChamSocBenhNhanCap1>();
            try
            {
                string sql = @"SELECT * FROM PhieuTDCSBenhNhanCap1 where MaQuanLy = :MaQuanLy";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, _OracleConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", maquanly));
                MDB.MDBDataReader DataReader = Command.ExecuteReader();
                while (DataReader.Read())
                {
                    PhieuTheoDoiChamSocBenhNhanCap1 data = new PhieuTheoDoiChamSocBenhNhanCap1();
                    data.ID = Convert.ToInt64(DataReader.GetLong("ID").ToString());
                    data.MaQuanLy = maquanly;
                    data.MaBenhNhan = DataReader["MaBenhNhan"].ToString();
                    data.Khoa = DataReader["Khoa"].ToString();
                    data.MaKhoa = DataReader["MaKhoa"].ToString();
                    data.ChanDoan = DataReader["ChanDoan"].ToString();
                    data.TenBenhNhan = DataReader["TenBenhNhan"].ToString();
                    data.Tuoi = DataReader["Tuoi"].ToString();
                    data.GioiTinh = DataReader["GioiTinh"].ToString();
                    data.SoBenhAn = DataReader["SoBenhAn"].ToString();
                    data.Giuong = DataReader["Giuong"].ToString();
                    int tempInt = -1;
                    int.TryParse(DataReader["NgayDieuTriThu"].ToString(), out tempInt);
                    data.NgayDieuTriThu = tempInt;

                    data.BacSyDieuTri = DataReader["BacSyDieuTri"].ToString();
                    data.MaBacSyDieuTri = DataReader["MaBacSyDieuTri"].ToString();
                    data.DieuDuongCa1 = DataReader["DieuDuongCa1"].ToString();
                    data.MaDieuDuongCa1 = DataReader["MaDieuDuongCa1"].ToString();
                    data.DieuDuongCa2 = DataReader["DieuDuongCa2"].ToString();
                    data.MaDieuDuongCa2 = DataReader["MaDieuDuongCa2"].ToString();
                    data.DieuDuongCa3 = DataReader["DieuDuongCa3"].ToString();
                    data.MaDieuDuongCa3 = DataReader["MaDieuDuongCa3"].ToString();
                    data.TheoDoiCanThiep = JsonConvert.DeserializeObject<ObservableCollection<TheoDoiCanThiep>>(DataReader["TheoDoiCanThiep"].ToString());
                    data.Nhap_Ca1 = JsonConvert.DeserializeObject<ThongTinNhap>(DataReader["Nhap_Ca1"].ToString());
                    data.Nhap_Ca2 = JsonConvert.DeserializeObject<ThongTinNhap>(DataReader["Nhap_Ca2"].ToString());
                    data.Nhap_Ca3 = JsonConvert.DeserializeObject<ThongTinNhap>(DataReader["Nhap_Ca3"].ToString());
                    data.Xuat_Ca1 = JsonConvert.DeserializeObject<ThongTinXuat>(DataReader["Xuat_Ca1"].ToString());
                    data.Xuat_Ca2 = JsonConvert.DeserializeObject<ThongTinXuat>(DataReader["Xuat_Ca2"].ToString());
                    data.Xuat_Ca3 = JsonConvert.DeserializeObject<ThongTinXuat>(DataReader["Xuat_Ca3"].ToString());

                    tempInt = -1;
                    int.TryParse(DataReader["TongNhap24h"].ToString(), out tempInt);
                    data.TongNhap24h = tempInt;
                    tempInt = -1;
                    int.TryParse(DataReader["TongXuat24h"].ToString(), out tempInt);
                    data.TongXuat24h = tempInt;
                    tempInt = -1;
                    int.TryParse(DataReader["TongBilan24h"].ToString(), out tempInt);
                    data.TongBilan24h = tempInt;
                    data.BanGiao = DataReader["BanGiao"].ToString();

                    data.MaDieuDuongThucHienThuocCa1 = DataReader["MaDieuDuongThucHienThuocCa1"].ToString();
                    data.DieuDuongThucHienThuocCa1 = DataReader["DieuDuongThucHienThuocCa1"].ToString();
                    data.MaDieuDuongThucHienThuocCa2 = DataReader["MaDieuDuongThucHienThuocCa2"].ToString();
                    data.DieuDuongThucHienThuocCa2 = DataReader["DieuDuongThucHienThuocCa2"].ToString();
                    data.MaDieuDuongThucHienThuocCa3 = DataReader["MaDieuDuongThucHienThuocCa3"].ToString();
                    data.DieuDuongThucHienThuocCa3 = DataReader["DieuDuongThucHienThuocCa3"].ToString();
                    data.BaoGiaoThuocCa1 = DataReader["BaoGiaoThuocCa1"].ToString();
                    data.BaoGiaoThuocCa2 = DataReader["BaoGiaoThuocCa2"].ToString();
                    data.BaoGiaoThuocCa3 = DataReader["BaoGiaoThuocCa3"].ToString();
                    data.MaBaoGiaoThuocCa1 = DataReader["MaBaoGiaoThuocCa1"].ToString();
                    data.MaBaoGiaoThuocCa2 = DataReader["MaBaoGiaoThuocCa2"].ToString();
                    data.MaBaoGiaoThuocCa3 = DataReader["MaBaoGiaoThuocCa3"].ToString();

                    data.ThongTinGio_Ca1 = getThongTinTheoGio(_OracleConnection, data.ID, 1);
                    data.ThongTinGio_Ca2 = getThongTinTheoGio(_OracleConnection, data.ID, 2);
                    data.ThongTinGio_Ca3 = getThongTinTheoGio(_OracleConnection, data.ID, 3);

                    data.BangThucHienThuoc = getBangThucHienThuoc(_OracleConnection, data.ID);

                    data.NgayTao = Convert.ToDateTime(DataReader["NgayTao"] == DBNull.Value ? DateTime.Now : DataReader["NgayTao"]);
                    data.NgayThucHienThuoc = Convert.ToDateTime(DataReader["NgayThucHienThuoc"] == DBNull.Value ? DateTime.Now : DataReader["NgayThucHienThuoc"]);
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
        public static ObservableCollection<ThongTinTheoGio> getThongTinTheoGio(MDB.MDBConnection _OracleConnection, long idPhieu, int caThu)
        {
            ObservableCollection<ThongTinTheoGio> thongTinTheoGios = new ObservableCollection<ThongTinTheoGio>();
            try
            {
                string sql = @"SELECT * FROM PhieuTDCSBenhNhanCap1_Gio where ID_Phieu = :ID_Phieu and CaThu= :CaThu  ORDER BY ID asc";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, _OracleConnection);
                Command.Parameters.Add(new MDB.MDBParameter("ID_Phieu", idPhieu));
                Command.Parameters.Add(new MDB.MDBParameter("CaThu", caThu));
                MDB.MDBDataReader DataReader = Command.ExecuteReader();
                while (DataReader.Read())
                {
                    ThongTinTheoGio data = new ThongTinTheoGio();
                    data.ID = Convert.ToInt64(DataReader.GetLong("ID").ToString());
                    data.ID_Phieu = idPhieu;
                    data.CaThu = caThu;
                    data.Gio = Convert.ToInt32(DataReader["Gio"].ToString());

                    int tempInt = -1;
                    data.M =  int.TryParse(DataReader["M"].ToString(), out tempInt) ? (int?) tempInt : null;

                    
                    double tempDouble = -1;
                    data.T = double.TryParse(DataReader["T"].ToString(), out tempDouble) ? (double?) tempDouble : null;
                    tempDouble = -1;
                    data.NhipTho =  double.TryParse(DataReader["NhipTho"].ToString(), out tempDouble) ? (double?)tempDouble : null;
                    tempDouble = -1;
                    data.SpO2 = double.TryParse(DataReader["SpO2"].ToString(), out tempDouble) ? (double?)tempDouble : null;
                    tempDouble = -1;
                    data.HAMax = double.TryParse(DataReader["HAMax"].ToString(), out tempDouble) ? (double?)tempDouble : null;
                    data.HAMin = double.TryParse(DataReader["HAMin"].ToString(), out tempDouble) ? (double?)tempDouble : null;

                    data.HATB = DataReader["HATB"].ToString();
                    data.DaNiem = DataReader["DaNiem"].ToString();
                    data.ModeNkq = DataReader["ModeNkq"].ToString();
                    data.ApLucBongChen = DataReader["ApLucBongChen"].ToString();
                    data.ApLucDuongTho = DataReader["ApLucDuongTho"].ToString();
                    data.PEEP = DataReader["PEEP"].ToString();
                    data.VM = DataReader["VM"].ToString();
                    data.PhongNguaLoet = DataReader["PhongNguaLoet"].ToString();
                    data.TuTheBenhNhan = DataReader["TuTheBenhNhan"].ToString();
                    data.ChamSocCuaDieuDuong = DataReader["ChamSocCuaDieuDuong"].ToString();

                    tempDouble = -1;
                    data.DuongMauTaiGiuong =  Common.ConDBNull_float(DataReader["DuongMauTaiGiuong"]);
                    data.CanLamSan = DataReader["CanLamSan"].ToString();
                    data.Dam = DataReader["Dam"].ToString();
                    data.Glasgow = DataReader["Glasgow"].ToString();
                    data.NKQ = DataReader["NKQ"].ToString();
                    data.TMTT = DataReader["TMTT"].ToString();
                    data.Viem = DataReader["Viem"].ToString();
                    data.Phu = DataReader["Phu"].ToString();
                    data.VietThuong = DataReader["VietThuong"].ToString();
                    data.Sonde = DataReader["Sonde"].ToString();
                    data.NhuDongRuot = DataReader["NhuDongRuot"].ToString();
                    data.SondeTieuNgay = DataReader["SondeTieuNgay"].ToString();

                    thongTinTheoGios.Add(data);
                }
            }
            catch (Exception ex) { XuLyLoi.Handle(ex); }
            return thongTinTheoGios;
        }
        public static ObservableCollection<BangThucHienThuoc> getBangThucHienThuoc(MDB.MDBConnection _OracleConnection, long idPhieu)
        {
            ObservableCollection<BangThucHienThuoc> bangThucHienThuocs = new ObservableCollection<BangThucHienThuoc>();
            try
            {
                string sql = @"SELECT * FROM PhieuTDCSBNCap1_BTHT where ID_Phieu = :ID_Phieu";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, _OracleConnection);
                Command.Parameters.Add(new MDB.MDBParameter("ID_Phieu", idPhieu));
                MDB.MDBDataReader DataReader = Command.ExecuteReader();
                while (DataReader.Read())
                {
                    BangThucHienThuoc data = new BangThucHienThuoc();
                    data.ID = Convert.ToInt64(DataReader.GetLong("ID").ToString());
                    data.ID_Phieu = idPhieu;

                    data.TenThuocHamLuong = DataReader["TenThuocHamLuong"].ToString();
                    data.LieuLuongDuongDung = DataReader["LieuLuongDuongDung"].ToString();
                    data.Ngay = Convert.ToDateTime(DataReader["Ngay"] == DBNull.Value ? DateTime.Now : DataReader["Ngay"]);
                    
                    data.Gio = DataReader["Gio"].ToString();
                    bangThucHienThuocs.Add(data);
                }
            }
            catch (Exception ex) { XuLyLoi.Handle(ex); }
            return bangThucHienThuocs;
        }
        public static bool InsertOrUpdatePhieu(MDB.MDBConnection MyConnection, ref PhieuTheoDoiChamSocBenhNhanCap1 phieuTheoDoi)
        {
            try
            {
                string sql = @"INSERT INTO PhieuTDCSBenhNhanCap1
                (
                    MAQUANLY,
                    MaBenhNhan,
                    Khoa,
	                MaKhoa,
                    ChanDoan,
                    TenBenhNhan,
                    Tuoi,
                    GioiTinh,
                    SoBenhAn,
                    Giuong,
	                NgayDieuTriThu,
	                BacSyDieuTri,
	                MaBacSyDieuTri,
	                DieuDuongCa1,
	                MaDieuDuongCa1,
	                DieuDuongCa2,
	                MaDieuDuongCa2,
	                DieuDuongCa3,
	                MaDieuDuongCa3,
	                TheoDoiCanThiep,
	                Nhap_Ca1,
	                Nhap_Ca2,
	                Nhap_Ca3,
	                Xuat_Ca1,
	                Xuat_Ca2,
	                Xuat_Ca3,
	                TongNhap24h,
	                TongXuat24h,
	                TongBilan24h,
	                BanGiao,
                    MaDieuDuongThucHienThuocCa1,
                    DieuDuongThucHienThuocCa1,
                    MaDieuDuongThucHienThuocCa2,
                    DieuDuongThucHienThuocCa2,
                    MaDieuDuongThucHienThuocCa3,
                    DieuDuongThucHienThuocCa3,
                    BaoGiaoThuocCa1,
                    BaoGiaoThuocCa2,
                    BaoGiaoThuocCa3,
	                MaBaoGiaoThuocCa1, 
	                MaBaoGiaoThuocCa2, 
	                MaBaoGiaoThuocCa3, 
                    NgayThucHienThuoc,
                    NGUOITAO,
                    NGUOISUA,
                    NGAYTAO,
                    NGAYSUA)  VALUES
                 (
				    :MAQUANLY,
                    :MaBenhNhan,
                    :Khoa,
	                :MaKhoa,
                    :ChanDoan,
                    :TenBenhNhan,
                    :Tuoi,
                    :GioiTinh,
                    :SoBenhAn,
                    :Giuong,
	                :NgayDieuTriThu,
	                :BacSyDieuTri,
	                :MaBacSyDieuTri,
	                :DieuDuongCa1,
	                :MaDieuDuongCa1,
	                :DieuDuongCa2,
	                :MaDieuDuongCa2,
	                :DieuDuongCa3,
	                :MaDieuDuongCa3,
	                :TheoDoiCanThiep,
	                :Nhap_Ca1,
	                :Nhap_Ca2,
	                :Nhap_Ca3,
	                :Xuat_Ca1,
	                :Xuat_Ca2,
	                :Xuat_Ca3,
	                :TongNhap24h,
	                :TongXuat24h,
	                :TongBilan24h,
	                :BanGiao,
                    :MaDieuDuongThucHienThuocCa1,
                    :DieuDuongThucHienThuocCa1,
                    :MaDieuDuongThucHienThuocCa2,
                    :DieuDuongThucHienThuocCa2,
                    :MaDieuDuongThucHienThuocCa3,
                    :DieuDuongThucHienThuocCa3,
                    :BaoGiaoThuocCa1,
                    :BaoGiaoThuocCa2,
                    :BaoGiaoThuocCa3,
                    :MaBaoGiaoThuocCa1, 
	                :MaBaoGiaoThuocCa2, 
	                :MaBaoGiaoThuocCa3, 
                    :NgayThucHienThuoc,
                    :NGUOITAO,
                    :NGUOISUA,
                    :NGAYTAO,
                    :NGAYSUA
                 )  RETURNING ID INTO :ID";
                if (phieuTheoDoi.ID != 0)
                {
                    sql = @"UPDATE PhieuTDCSBenhNhanCap1 SET 
                    MAQUANLY = :MAQUANLY,
                    MaBenhNhan = :MaBenhNhan,
                    Khoa = :Khoa,
	                MaKhoa = :MaKhoa,
                    Giuong = :Giuong,
                    ChanDoan = :ChanDoan,
                    TenBenhNhan = :TenBenhNhan,
                    Tuoi = :Tuoi,
                    GioiTinh = :GioiTinh,
                    SoBenhAn = :SoBenhAn,
	                NgayDieuTriThu = :NgayDieuTriThu,
	                BacSyDieuTri = :BacSyDieuTri,
	                MaBacSyDieuTri = :MaBacSyDieuTri,
	                DieuDuongCa1 = :DieuDuongCa1,
	                MaDieuDuongCa1 = :MaDieuDuongCa1,
	                DieuDuongCa2 = :DieuDuongCa2,
	                MaDieuDuongCa2 = :MaDieuDuongCa2,
	                DieuDuongCa3 = :DieuDuongCa3,
	                MaDieuDuongCa3 = :MaDieuDuongCa3,
	                TheoDoiCanThiep = :TheoDoiCanThiep,
	                Nhap_Ca1 = :Nhap_Ca1,
	                Nhap_Ca2 = :Nhap_Ca2,
	                Nhap_Ca3 = :Nhap_Ca3,
	                Xuat_Ca1 = :Xuat_Ca1,
	                Xuat_Ca2 = :Xuat_Ca2,
	                Xuat_Ca3 = :Xuat_Ca3,
	                TongNhap24h = :TongNhap24h,
	                TongXuat24h = :TongXuat24h,
	                TongBilan24h = :TongBilan24h,
	                BanGiao = :BanGiao,
                    MaDieuDuongThucHienThuocCa1 = :MaDieuDuongThucHienThuocCa1,
                    DieuDuongThucHienThuocCa1 = :DieuDuongThucHienThuocCa1,
                    MaDieuDuongThucHienThuocCa2 = :MaDieuDuongThucHienThuocCa2,
                    DieuDuongThucHienThuocCa2 = :DieuDuongThucHienThuocCa2,
                    MaDieuDuongThucHienThuocCa3 = :MaDieuDuongThucHienThuocCa3,
                    DieuDuongThucHienThuocCa3 = :DieuDuongThucHienThuocCa3,
                    BaoGiaoThuocCa1 = :BaoGiaoThuocCa1,
                    BaoGiaoThuocCa2 = :BaoGiaoThuocCa2,
                    BaoGiaoThuocCa3 = :BaoGiaoThuocCa3,
                    MaBaoGiaoThuocCa1 = :MaBaoGiaoThuocCa1,
	                MaBaoGiaoThuocCa2 = :MaBaoGiaoThuocCa2,
	                MaBaoGiaoThuocCa3 = :MaBaoGiaoThuocCa3,
                    NgayThucHienThuoc = :NgayThucHienThuoc,
                    NGUOISUA = :NGUOISUA,
                    NGAYSUA = :NGAYSUA
                    WHERE ID = " + phieuTheoDoi.ID;
                }
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MAQUANLY", phieuTheoDoi.MaQuanLy));
                Command.Parameters.Add(new MDB.MDBParameter("MaBenhNhan", phieuTheoDoi.MaBenhNhan));
                Command.Parameters.Add(new MDB.MDBParameter("Khoa", phieuTheoDoi.Khoa));
                Command.Parameters.Add(new MDB.MDBParameter("MaKhoa", phieuTheoDoi.MaKhoa));
                Command.Parameters.Add(new MDB.MDBParameter("ChanDoan", phieuTheoDoi.ChanDoan));
                Command.Parameters.Add(new MDB.MDBParameter("TenBenhNhan", phieuTheoDoi.TenBenhNhan));
                Command.Parameters.Add(new MDB.MDBParameter("Tuoi", phieuTheoDoi.Tuoi));
                Command.Parameters.Add(new MDB.MDBParameter("GioiTinh", phieuTheoDoi.GioiTinh));
                Command.Parameters.Add(new MDB.MDBParameter("SoBenhAn", phieuTheoDoi.SoBenhAn));
                Command.Parameters.Add(new MDB.MDBParameter("Giuong", phieuTheoDoi.Giuong));
                Command.Parameters.Add(new MDB.MDBParameter("NgayDieuTriThu", phieuTheoDoi.NgayDieuTriThu));
                Command.Parameters.Add(new MDB.MDBParameter("BacSyDieuTri", phieuTheoDoi.BacSyDieuTri));
                Command.Parameters.Add(new MDB.MDBParameter("MaBacSyDieuTri", phieuTheoDoi.MaBacSyDieuTri));
                Command.Parameters.Add(new MDB.MDBParameter("DieuDuongCa1", phieuTheoDoi.DieuDuongCa1));
                Command.Parameters.Add(new MDB.MDBParameter("MaDieuDuongCa1", phieuTheoDoi.MaDieuDuongCa1));
                Command.Parameters.Add(new MDB.MDBParameter("DieuDuongCa2", phieuTheoDoi.DieuDuongCa2));
                Command.Parameters.Add(new MDB.MDBParameter("MaDieuDuongCa2", phieuTheoDoi.MaDieuDuongCa2));
                Command.Parameters.Add(new MDB.MDBParameter("DieuDuongCa3", phieuTheoDoi.DieuDuongCa3));
                Command.Parameters.Add(new MDB.MDBParameter("MaDieuDuongCa3", phieuTheoDoi.MaDieuDuongCa3));
                Command.Parameters.Add(new MDB.MDBParameter("TheoDoiCanThiep", JsonConvert.SerializeObject(phieuTheoDoi.TheoDoiCanThiep)));
                Command.Parameters.Add(new MDB.MDBParameter("Nhap_Ca1", JsonConvert.SerializeObject(phieuTheoDoi.Nhap_Ca1)));
                Command.Parameters.Add(new MDB.MDBParameter("Nhap_Ca2", JsonConvert.SerializeObject(phieuTheoDoi.Nhap_Ca2)));
                Command.Parameters.Add(new MDB.MDBParameter("Nhap_Ca3", JsonConvert.SerializeObject(phieuTheoDoi.Nhap_Ca3)));
                Command.Parameters.Add(new MDB.MDBParameter("Xuat_Ca1", JsonConvert.SerializeObject(phieuTheoDoi.Xuat_Ca1)));
                Command.Parameters.Add(new MDB.MDBParameter("Xuat_Ca2", JsonConvert.SerializeObject(phieuTheoDoi.Xuat_Ca2)));
                Command.Parameters.Add(new MDB.MDBParameter("Xuat_Ca3", JsonConvert.SerializeObject(phieuTheoDoi.Xuat_Ca3)));
                Command.Parameters.Add(new MDB.MDBParameter("TongNhap24h", phieuTheoDoi.TongNhap24h));
                Command.Parameters.Add(new MDB.MDBParameter("TongXuat24h", phieuTheoDoi.TongXuat24h));
                Command.Parameters.Add(new MDB.MDBParameter("TongBilan24h", phieuTheoDoi.TongBilan24h));
                Command.Parameters.Add(new MDB.MDBParameter("BanGiao", phieuTheoDoi.BanGiao));

                Command.Parameters.Add(new MDB.MDBParameter("MaDieuDuongThucHienThuocCa1", phieuTheoDoi.MaDieuDuongThucHienThuocCa1));
                Command.Parameters.Add(new MDB.MDBParameter("DieuDuongThucHienThuocCa1", phieuTheoDoi.DieuDuongThucHienThuocCa1));
                Command.Parameters.Add(new MDB.MDBParameter("MaDieuDuongThucHienThuocCa2", phieuTheoDoi.MaDieuDuongThucHienThuocCa2));
                Command.Parameters.Add(new MDB.MDBParameter("DieuDuongThucHienThuocCa2", phieuTheoDoi.DieuDuongThucHienThuocCa2));
                Command.Parameters.Add(new MDB.MDBParameter("MaDieuDuongThucHienThuocCa3", phieuTheoDoi.MaDieuDuongThucHienThuocCa3));
                Command.Parameters.Add(new MDB.MDBParameter("DieuDuongThucHienThuocCa3", phieuTheoDoi.DieuDuongThucHienThuocCa3));

                Command.Parameters.Add(new MDB.MDBParameter("BaoGiaoThuocCa1", phieuTheoDoi.BaoGiaoThuocCa1));
                Command.Parameters.Add(new MDB.MDBParameter("BaoGiaoThuocCa2", phieuTheoDoi.BaoGiaoThuocCa2));
                Command.Parameters.Add(new MDB.MDBParameter("BaoGiaoThuocCa3", phieuTheoDoi.BaoGiaoThuocCa3));
                Command.Parameters.Add(new MDB.MDBParameter("MaBaoGiaoThuocCa1", phieuTheoDoi.MaBaoGiaoThuocCa1));
                Command.Parameters.Add(new MDB.MDBParameter("MaBaoGiaoThuocCa2", phieuTheoDoi.MaBaoGiaoThuocCa2));
                Command.Parameters.Add(new MDB.MDBParameter("MaBaoGiaoThuocCa3", phieuTheoDoi.MaBaoGiaoThuocCa3));
                Command.Parameters.Add(new MDB.MDBParameter("NgayThucHienThuoc", phieuTheoDoi.NgayThucHienThuoc));
                Command.Parameters.Add(new MDB.MDBParameter("NGUOISUA", phieuTheoDoi.NguoiSua));
                Command.Parameters.Add(new MDB.MDBParameter("NGAYSUA", phieuTheoDoi.NgaySua));
                if (phieuTheoDoi.ID == 0)
                {
                    Command.Parameters.Add(new MDB.MDBParameter("ID", phieuTheoDoi.ID));
                    Command.Parameters.Add(new MDB.MDBParameter("NGUOITAO", phieuTheoDoi.NguoiTao));
                    Command.Parameters.Add(new MDB.MDBParameter("NGAYTAO", phieuTheoDoi.NgayTao));
                }
                Command.BindByName = true;
                int n = Command.ExecuteNonQuery();
                if (phieuTheoDoi.ID == 0)
                {
                    long nextval = Convert.ToInt64((Command.Parameters["ID"] as MDB.MDBParameter).Value);
                    phieuTheoDoi.ID = nextval;
                }
                return n > 0 ? true : false;
            }
            catch (Exception ex)
            {
                XuLyLoi.Handle(ex);
            }
            return false;
        }
        public static bool InsertOrUpdateThongTinGio(MDB.MDBConnection MyConnection, ThongTinTheoGio thongTinTheoGio)
        {
            try
            {
                string sql = @"INSERT INTO PhieuTDCSBenhNhanCap1_Gio
                (
                    ID_Phieu,
	                CaThu,
	                Gio,
	                M,
	                HAMax,
	                HAMin,
	                T,
	                NhipTho,
                    SpO2,
	                HATB,
	                DaNiem,
	                ModeNkq,
	                ApLucBongChen,
	                ApLucDuongTho,
	                PEEP,
	                VM,
	                PhongNguaLoet,
	                TuTheBenhNhan,
	                ChamSocCuaDieuDuong,
	                DuongMauTaiGiuong,
	                CanLamSan,
                    Dam,
                    Glasgow,
                    NKQ,
                    TMTT,
                    Viem,
                    Phu,
                    VietThuong,
                    Sonde,
                    NhuDongRuot,
                    SondeTieuNgay
                )  VALUES
                 (
				    :ID_Phieu,
	                :CaThu,
	                :Gio,
	                :M,
                    :HAMax,
	                :HAMin,
	                :T,
	                :NhipTho,
                    :SpO2,
	                :HATB,
	                :DaNiem,
	                :ModeNkq,
	                :ApLucBongChen,
	                :ApLucDuongTho,
	                :PEEP,
	                :VM,
	                :PhongNguaLoet,
	                :TuTheBenhNhan,
	                :ChamSocCuaDieuDuong,
	                :DuongMauTaiGiuong,
	                :CanLamSan,
                    :Dam,
                    :Glasgow,
                    :NKQ,
                    :TMTT,
                    :Viem,
                    :Phu,
                    :VietThuong,
                    :Sonde,
                    :NhuDongRuot,
                    :SondeTieuNgay
                 )";
                if (thongTinTheoGio.ID != 0)
                {
                    sql = @"UPDATE PhieuTDCSBenhNhanCap1_Gio SET 
                    ID_Phieu = :ID_Phieu,
	                CaThu = :CaThu,
	                Gio = :Gio,
	                M = :M,
	                HAMax = :HAMax,
	                HAMin = :HAMin,
	                T = :T,
	                NhipTho = :NhipTho,
                    SpO2 = :SpO2,
	                HATB = :HATB,
	                DaNiem = :DaNiem,
	                ModeNkq = :ModeNkq,
	                ApLucBongChen = :ApLucBongChen,
	                ApLucDuongTho = :ApLucDuongTho,
	                PEEP = :PEEP,
	                VM = :VM,
	                PhongNguaLoet = :PhongNguaLoet,
	                TuTheBenhNhan = :TuTheBenhNhan,
	                ChamSocCuaDieuDuong = :ChamSocCuaDieuDuong,
	                DuongMauTaiGiuong = :DuongMauTaiGiuong,
	                CanLamSan = :CanLamSan,
                    Dam = :Dam,
                    Glasgow = :Glasgow,
                    NKQ = :NKQ,
                    TMTT = :TMTT,
                    Viem = :Viem,
                    Phu = :Phu,
                    VietThuong = :VietThuong,
                    Sonde = :Sonde,
                    NhuDongRuot = :NhuDongRuot,
                    SondeTieuNgay = :SondeTieuNgay
                    WHERE ID = " + thongTinTheoGio.ID;
                }
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
                Command.Parameters.Add(new MDB.MDBParameter("ID_Phieu", thongTinTheoGio.ID_Phieu));
                Command.Parameters.Add(new MDB.MDBParameter("CaThu", thongTinTheoGio.CaThu));
                Command.Parameters.Add(new MDB.MDBParameter("Gio", thongTinTheoGio.Gio));
                Command.Parameters.Add(new MDB.MDBParameter("M", thongTinTheoGio.M));
                Command.Parameters.Add(new MDB.MDBParameter("HAMax", thongTinTheoGio.HAMax));
                Command.Parameters.Add(new MDB.MDBParameter("HAMin", thongTinTheoGio.HAMin));
                Command.Parameters.Add(new MDB.MDBParameter("T", thongTinTheoGio.T));
                Command.Parameters.Add(new MDB.MDBParameter("NhipTho", thongTinTheoGio.NhipTho));
                Command.Parameters.Add(new MDB.MDBParameter("SpO2", thongTinTheoGio.SpO2));
                Command.Parameters.Add(new MDB.MDBParameter("HATB", thongTinTheoGio.HATB));
                Command.Parameters.Add(new MDB.MDBParameter("DaNiem", thongTinTheoGio.DaNiem));
                Command.Parameters.Add(new MDB.MDBParameter("ModeNkq", thongTinTheoGio.ModeNkq));
                Command.Parameters.Add(new MDB.MDBParameter("ApLucBongChen", thongTinTheoGio.ApLucBongChen));
                Command.Parameters.Add(new MDB.MDBParameter("ApLucDuongTho", thongTinTheoGio.ApLucDuongTho));
                Command.Parameters.Add(new MDB.MDBParameter("PEEP", thongTinTheoGio.PEEP));
                Command.Parameters.Add(new MDB.MDBParameter("VM", thongTinTheoGio.VM));
                Command.Parameters.Add(new MDB.MDBParameter("PhongNguaLoet", thongTinTheoGio.PhongNguaLoet));
                Command.Parameters.Add(new MDB.MDBParameter("TuTheBenhNhan", thongTinTheoGio.TuTheBenhNhan));
                Command.Parameters.Add(new MDB.MDBParameter("ChamSocCuaDieuDuong", thongTinTheoGio.ChamSocCuaDieuDuong));
                Command.Parameters.Add(new MDB.MDBParameter("DuongMauTaiGiuong", thongTinTheoGio.DuongMauTaiGiuong));
                Command.Parameters.Add(new MDB.MDBParameter("CanLamSan", thongTinTheoGio.CanLamSan));
                Command.Parameters.Add(new MDB.MDBParameter("Dam", thongTinTheoGio.Dam));
                Command.Parameters.Add(new MDB.MDBParameter("Glasgow", thongTinTheoGio.Glasgow));
                Command.Parameters.Add(new MDB.MDBParameter("NKQ", thongTinTheoGio.NKQ));
                Command.Parameters.Add(new MDB.MDBParameter("TMTT", thongTinTheoGio.TMTT));
                Command.Parameters.Add(new MDB.MDBParameter("Viem", thongTinTheoGio.Viem));
                Command.Parameters.Add(new MDB.MDBParameter("Phu", thongTinTheoGio.Phu));
                Command.Parameters.Add(new MDB.MDBParameter("VietThuong", thongTinTheoGio.VietThuong));
                Command.Parameters.Add(new MDB.MDBParameter("Sonde", thongTinTheoGio.Sonde));
                Command.Parameters.Add(new MDB.MDBParameter("NhuDongRuot", thongTinTheoGio.NhuDongRuot));
                Command.Parameters.Add(new MDB.MDBParameter("SondeTieuNgay", thongTinTheoGio.SondeTieuNgay));
                Command.BindByName = true;
                int n = Command.ExecuteNonQuery();
                return n > 0 ? true : false;
            }
            catch (Exception ex)
            {
                XuLyLoi.Handle(ex);
            }
            return false;
        }
        public static bool InsertOrUpdateThucHienThuoc(MDB.MDBConnection MyConnection, BangThucHienThuoc bangThucHienThuoc)
        {
            try
            {
                string sql = @"INSERT INTO PhieuTDCSBNCap1_BTHT
                (
                    ID_Phieu,
	                TenThuocHamLuong,
                    LieuLuongDuongDung,
                    Ngay,
                    Gio
                )  VALUES
                 (
				    :ID_Phieu,
	                :TenThuocHamLuong,
                    :LieuLuongDuongDung,
                    :Ngay,
                    :Gio
                 )";
                if (bangThucHienThuoc.ID != 0)
                {
                    sql = @"UPDATE PhieuTDCSBNCap1_BTHT SET 
                    ID_Phieu = :ID_Phieu,
	                TenThuocHamLuong = :TenThuocHamLuong,
                    LieuLuongDuongDung = :LieuLuongDuongDung,
                    Ngay = :Ngay,
                    Gio = :Gio
                    WHERE ID = " + bangThucHienThuoc.ID;
                }
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
                Command.Parameters.Add(new MDB.MDBParameter("ID_Phieu", bangThucHienThuoc.ID_Phieu));
                Command.Parameters.Add(new MDB.MDBParameter("TenThuocHamLuong", bangThucHienThuoc.TenThuocHamLuong));
                Command.Parameters.Add(new MDB.MDBParameter("LieuLuongDuongDung", bangThucHienThuoc.LieuLuongDuongDung));
                Command.Parameters.Add(new MDB.MDBParameter("Ngay", bangThucHienThuoc.Ngay));
                Command.Parameters.Add(new MDB.MDBParameter("Gio", bangThucHienThuoc.Gio));
                
                Command.BindByName = true;
                int n = Command.ExecuteNonQuery();
                return n > 0 ? true : false;
            }
            catch (Exception ex)
            {
                XuLyLoi.Handle(ex);
            }
            return false;
        }
        public static bool deletePhieu(MDB.MDBConnection MyConnection, long id)
        {
            try
            {
                string sql = "DELETE FROM PhieuTDCSBenhNhanCap1 WHERE ID = :ID";
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
        public static bool deleteThongTinGio(MDB.MDBConnection MyConnection, long id)
        {
            try
            {
                string sql = "DELETE FROM PhieuTDCSBenhNhanCap1_Gio WHERE ID = :ID";
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
        public static bool deleteThucHienThuoc(MDB.MDBConnection MyConnection, long id)
        {
            try
            {
                string sql = "DELETE FROM PhieuTDCSBNCap1_BTHT WHERE ID = :ID";
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

    }

}
