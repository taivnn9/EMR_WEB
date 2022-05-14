using EMR.KyDienTu;
using Newtonsoft.Json;
using PMS.Access;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace EMR_MAIN.DATABASE.Other
{
    public class ThongTinGioChamSoc
    {
        [MoTaDuLieu("Mã định danh")]
		public long ID { get; set; }
        [MoTaDuLieu("Mã định danh")]
		public long ID_Phieu { get; set; }
        public DateTime Gio { get; set; }
        public int? Mach { get; set; }
        public int? HuyetApTren { get; set; }
        public int? HuyetApDuoi { get; set; }
        public double? NhietDo { get; set; }
        public int? NhipTho { get; set; }
        public int? O2 { get; set; }
        public int? SPO2 { get; set; }
        public string DichTruyen { get; set; }
        public string TocDo { get; set; }
        public string TongDichTruyen { get; set; }
        public string AnUong { get; set; }
        [MoTaDuLieu("Nước tiểu")]
		public string NuocTieu { get; set; }
        public string DichKhac { get; set; }
        public string DieuTri { get; set; }
        public string MoMat { get; set; }
        public string DapUngLoiNoi { get; set; }
        public string DapUngVanDong { get; set; }
        public string TongCong { get; set; }
        public double? DongTuTrai_DoLon { get; set; }
        public string DongTuTrai_PhanXa { get; set; }
        public double? DongTuPhai_DoLon { get; set; }
        public string DongTuPhai_PhanXa { get; set; }
        public string DoAmChi { get; set; }
        public string BungChuong { get; set; }
        public double? VongBung { get; set; }
        public double? CanNang { get; set; }
        public string CanLamSang { get; set; }
        public string ChamSoc { get; set; }
    }
    public class TheoDoiGhiChu
    {
        [MoTaDuLieu("Mã định danh")]
		public long ID { get; set; }
        [MoTaDuLieu("Mã định danh")]
		public long ID_Phieu { get; set; }
        public DateTime? Gio { get; set; }
        [MoTaDuLieu("Ghi chú")]
		public string GhiChu { get; set; }
    }
    public class YLenh
    {
        public string STT { get; set; }
        public string TenYLenh { get; set; }
    }
    public class PhieuTheoDoiVaChamSoc : ThongTinKy
    {
        public PhieuTheoDoiVaChamSoc()
        {
            TableName = "PhieuTheoDoiVaChamSoc";
            TablePrimaryKeyName = "ID";
            IDMauPhieu = (int)DanhMucPhieu.PTDCSNB;
            TenMauPhieu = DanhMucPhieu.PTDCSNB.Description();
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
        [MoTaDuLieu("Khoa")]
		public string Khoa { get; set; }
        [MoTaDuLieu("Mã khoa")]
		public string MaKhoa { get; set; }
        public string SoGiuong { get; set; }
        [MoTaDuLieu("Chẩn đoán bệnh")]
		public string ChanDoan { get; set; }
        [MoTaDuLieu("Họ tên điều dưỡng")]
		public string DieuDuongCaSang { get; set; }
        [MoTaDuLieu("Mã điều dưỡng")]
		public string MaDieuDuongCaSang { get; set; }
        [MoTaDuLieu("Họ tên điều dưỡng")]
		public string DieuDuongCaChieu { get; set; }
        [MoTaDuLieu("Mã điều dưỡng")]
		public string MaDieuDuongCaChieu { get; set; }
        [MoTaDuLieu("Họ tên điều dưỡng")]
		public string DieuDuongCaDem { get; set; }
        [MoTaDuLieu("Mã điều dưỡng")]
		public string MaDieuDuongCaDem{ get; set; }
        public ObservableCollection<YLenh> DichTruyen { get; set; }
        public ObservableCollection<YLenh> ThuocTiem { get; set; }
        public ObservableCollection<YLenh> ThuocUong { get; set; }
        public ObservableCollection<ThongTinGioChamSoc> ThongTinGio { get; set; }
        public ObservableCollection<TheoDoiGhiChu>  TheoDoi { get; set; }
        public bool[] CanLamSangArray { get; } = new bool[] { false, false, false, false, false, false, false, false,false };
        public string CanLamSang
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < CanLamSangArray.Length; i++)
                    temp += (CanLamSangArray[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        CanLamSangArray[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public bool[] ChamSocDieuDuongArray { get; } = new bool[] { false, false, false, false, false };
        public string ChamSocDieuDuong
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < ChamSocDieuDuongArray.Length; i++)
                    temp += (ChamSocDieuDuongArray[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        ChamSocDieuDuongArray[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
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
    public class PhieuTheoDoiVaChamSocFunc
    {
        public const string TableName = "PhieuTheoDoiVaChamSoc";
        public const string TablePrimaryKeyName = "ID";
        public static PhieuTheoDoiVaChamSoc GetData(MDB.MDBConnection _OracleConnection, long ID)
        {
            PhieuTheoDoiVaChamSoc data = new PhieuTheoDoiVaChamSoc();
            try
            {
                string sql = @"SELECT * FROM PhieuTheoDoiVaChamSoc where ID = :ID";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, _OracleConnection);
                Command.Parameters.Add(new MDB.MDBParameter("ID", ID));
                MDB.MDBDataReader DataReader = Command.ExecuteReader();
                while (DataReader.Read())
                {
                    data.ID = Convert.ToInt64(DataReader.GetLong("ID").ToString());
                    data.MaQuanLy = Convert.ToDecimal(DataReader["MaQuanLy"].ToString());
                    data.MaBenhNhan = DataReader["MaBenhNhan"].ToString();
                    data.TenBenhNhan = DataReader["TenBenhNhan"].ToString();
                    data.Khoa = DataReader["Khoa"].ToString();
                    data.MaKhoa = DataReader["MaKhoa"].ToString();
                    data.ChanDoan = DataReader["ChanDoan"].ToString();
                    data.SoGiuong = DataReader["SoGiuong"].ToString();
                    data.Tuoi = DataReader["Tuoi"].ToString();
                    data.GioiTinh = DataReader["GioiTinh"].ToString();

                    data.DieuDuongCaSang = DataReader["DieuDuongCaSang"].ToString();
                    data.MaDieuDuongCaSang = DataReader["MaDieuDuongCaSang"].ToString();
                    data.DieuDuongCaChieu = DataReader["DieuDuongCaChieu"].ToString();
                    data.MaDieuDuongCaChieu = DataReader["MaDieuDuongCaChieu"].ToString();
                    data.DieuDuongCaDem = DataReader["DieuDuongCaDem"].ToString();
                    data.MaDieuDuongCaDem = DataReader["MaDieuDuongCaDem"].ToString();

                    data.DichTruyen = JsonConvert.DeserializeObject<ObservableCollection<YLenh>>(DataReader["DichTruyen"].ToString());
                    data.ThuocTiem = JsonConvert.DeserializeObject<ObservableCollection<YLenh>>(DataReader["ThuocTiem"].ToString());
                    data.ThuocUong = JsonConvert.DeserializeObject<ObservableCollection<YLenh>>(DataReader["ThuocUong"].ToString());

                    data.ThongTinGio = getThongTinGioChamSoc(_OracleConnection, data.ID);
                    data.TheoDoi = getTheoDoiGhiChu(_OracleConnection, data.ID);
                    data.CanLamSang = DataReader["CanLamSang"].ToString();
                    data.ChamSocDieuDuong = DataReader["ChamSocDieuDuong"].ToString();

                    data.NgayTao = Convert.ToDateTime(DataReader["NgayTao"] == DBNull.Value ? DateTime.Now : DataReader["NgayTao"]);
                    data.NguoiTao = DataReader["NguoiTao"].ToString();
                    data.NgaySua = Convert.ToDateTime(DataReader["NgaySua"] == DBNull.Value ? DateTime.Now : DataReader["NgaySua"]);
                    data.NguoiSua = DataReader["NguoiSua"].ToString();

                    data.MaSoKy = DataReader["masokyten"].ToString();
                    data.DaKy = !string.IsNullOrEmpty(data.MaSoKy) ? true : false;
                }
            }
            catch (Exception ex) { XuLyLoi.Handle(ex); }
            return data;
        }
        public static List<PhieuTheoDoiVaChamSoc> GetListData(MDB.MDBConnection _OracleConnection, decimal maquanly)
        {
            List<PhieuTheoDoiVaChamSoc> list = new List<PhieuTheoDoiVaChamSoc>();
            try
            {
                string sql = @"SELECT * FROM PhieuTheoDoiVaChamSoc where MaQuanLy = :MaQuanLy";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, _OracleConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", maquanly));
                MDB.MDBDataReader DataReader = Command.ExecuteReader();
                while (DataReader.Read())
                {
                    PhieuTheoDoiVaChamSoc data = new PhieuTheoDoiVaChamSoc();
                    data.ID = Convert.ToInt64(DataReader.GetLong("ID").ToString());
                    data.MaQuanLy = maquanly;
                    data.MaBenhNhan = DataReader["MaBenhNhan"].ToString();
                    data.TenBenhNhan = DataReader["TenBenhNhan"].ToString();
                    data.Khoa = DataReader["Khoa"].ToString();
                    data.MaKhoa = DataReader["MaKhoa"].ToString();
                    data.ChanDoan = DataReader["ChanDoan"].ToString();
                    data.SoGiuong = DataReader["SoGiuong"].ToString();
                    data.Tuoi = DataReader["Tuoi"].ToString();
                    data.GioiTinh = DataReader["GioiTinh"].ToString();

                    data.DieuDuongCaSang = DataReader["DieuDuongCaSang"].ToString();
                    data.MaDieuDuongCaSang = DataReader["MaDieuDuongCaSang"].ToString();
                    data.DieuDuongCaChieu = DataReader["DieuDuongCaChieu"].ToString();
                    data.MaDieuDuongCaChieu = DataReader["MaDieuDuongCaChieu"].ToString();
                    data.DieuDuongCaDem = DataReader["DieuDuongCaDem"].ToString();
                    data.MaDieuDuongCaDem = DataReader["MaDieuDuongCaDem"].ToString();

                    data.DichTruyen = JsonConvert.DeserializeObject<ObservableCollection<YLenh>>(DataReader["DichTruyen"].ToString());
                    data.ThuocTiem = JsonConvert.DeserializeObject<ObservableCollection<YLenh>>(DataReader["ThuocTiem"].ToString());
                    data.ThuocUong = JsonConvert.DeserializeObject<ObservableCollection<YLenh>>(DataReader["ThuocUong"].ToString());

                    data.ThongTinGio = getThongTinGioChamSoc(_OracleConnection, data.ID);
                    data.TheoDoi = getTheoDoiGhiChu(_OracleConnection, data.ID);
                    data.CanLamSang = DataReader["CanLamSang"].ToString();
                    data.ChamSocDieuDuong = DataReader["ChamSocDieuDuong"].ToString();
                   
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
        public static ObservableCollection<ThongTinGioChamSoc> getThongTinGioChamSoc(MDB.MDBConnection _OracleConnection, long idPhieu)
        {
            ObservableCollection<ThongTinGioChamSoc> thongTinTheoGios = new ObservableCollection<ThongTinGioChamSoc>();
            try
            {
                string sql = @"SELECT * FROM PhieuTheoDoiVaChamSoc_Gio where ID_Phieu = :ID_Phieu ORDER BY ID asc";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, _OracleConnection);
                Command.Parameters.Add(new MDB.MDBParameter("ID_Phieu", idPhieu));
                MDB.MDBDataReader DataReader = Command.ExecuteReader();
                while (DataReader.Read())
                {
                    ThongTinGioChamSoc data = new ThongTinGioChamSoc();
                    data.ID = Convert.ToInt64(DataReader.GetLong("ID").ToString());
                    data.ID_Phieu = idPhieu;
                    data.Gio = Convert.ToDateTime(DataReader["Gio"].ToString());
                    int tempInt = -1;
                    data.Mach = int.TryParse(DataReader["Mach"].ToString(), out tempInt) ? (int?)tempInt : null;

                    tempInt = -1;
                    data.HuyetApTren = int.TryParse(DataReader["HuyetApTren"].ToString(), out tempInt) ? (int?)tempInt : null;

                    tempInt = -1;
                    data.HuyetApDuoi = int.TryParse(DataReader["HuyetApDuoi"].ToString(), out tempInt) ? (int?)tempInt : null;

                    double tempDouble = -1;
                    data.NhietDo = double.TryParse(DataReader["NhietDo"].ToString(), out tempDouble) ? (double?)tempDouble : null;

                    tempInt = -1;
                    data.NhipTho = int.TryParse(DataReader["NhipTho"].ToString(), out tempInt) ? (int?)tempInt : null;
                    
                    tempInt = -1;
                    data.O2 = int.TryParse(DataReader["O2"].ToString(), out tempInt) ? (int?)tempInt : null;

                    tempInt = -1;
                    data.SPO2 = int.TryParse(DataReader["SPO2"].ToString(), out tempInt) ? (int?)tempInt : null;

                    data.DichTruyen = DataReader["DichTruyen"].ToString();
                    data.TocDo = DataReader["TocDo"].ToString();
                    data.TongDichTruyen = DataReader["TongDichTruyen"].ToString();
                    data.AnUong = DataReader["AnUong"].ToString();
                    data.NuocTieu = DataReader["NuocTieu"].ToString();
                    data.DichKhac = DataReader["DichKhac"].ToString();
                    data.DieuTri = DataReader["DieuTri"].ToString();
                    data.MoMat = DataReader["MoMat"].ToString();
                    data.DapUngLoiNoi = DataReader["DapUngLoiNoi"].ToString();
                    data.DapUngVanDong = DataReader["DapUngVanDong"].ToString();
                    data.TongCong = DataReader["TongCong"].ToString();

                    tempDouble = -1;
                    data.DongTuTrai_DoLon = double.TryParse(DataReader["DongTuTrai_DoLon"].ToString(), out tempDouble) ? (double?)tempDouble : null;
                    data.DongTuTrai_PhanXa = DataReader["DongTuTrai_PhanXa"].ToString();
                    
                    tempDouble = -1;
                    data.DongTuPhai_DoLon = double.TryParse(DataReader["DongTuPhai_DoLon"].ToString(), out tempDouble) ? (double?)tempDouble : null;
                    data.DongTuPhai_PhanXa = DataReader["DongTuPhai_PhanXa"].ToString();

                    data.DoAmChi = DataReader["DoAmChi"].ToString();
                    data.BungChuong = DataReader["BungChuong"].ToString();
                    
                    tempDouble = -1;
                    data.VongBung = double.TryParse(DataReader["VongBung"].ToString(), out tempDouble) ? (double?)tempDouble : null;
                    tempDouble = -1;
                    data.CanNang = double.TryParse(DataReader["CanNang"].ToString(), out tempDouble) ? (double?)tempDouble : null;

                    data.CanLamSang = DataReader["CanLamSang"].ToString();
                    data.ChamSoc = DataReader["ChamSoc"].ToString();

                    thongTinTheoGios.Add(data);
                }
            }
            catch (Exception ex) { XuLyLoi.Handle(ex); }
            return thongTinTheoGios;
        }
        public static ObservableCollection<TheoDoiGhiChu> getTheoDoiGhiChu(MDB.MDBConnection _OracleConnection, long idPhieu)
        {
            ObservableCollection<TheoDoiGhiChu> bangThucHienThuocs = new ObservableCollection<TheoDoiGhiChu>();
            try
            {
                string sql = @"SELECT * FROM PhieuTheoDoiVaChamSoc_GhiChu where ID_Phieu = :ID_Phieu";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, _OracleConnection);
                Command.Parameters.Add(new MDB.MDBParameter("ID_Phieu", idPhieu));
                MDB.MDBDataReader DataReader = Command.ExecuteReader();
                while (DataReader.Read())
                {
                    TheoDoiGhiChu data = new TheoDoiGhiChu();
                    data.ID = Convert.ToInt64(DataReader.GetLong("ID").ToString());
                    data.ID_Phieu = idPhieu;

                    data.Gio = Convert.ToDateTime(DataReader["Gio"] == DBNull.Value ? DateTime.Now : DataReader["Gio"]);
                    data.GhiChu = DataReader["GhiChu"].ToString();
                  
                    bangThucHienThuocs.Add(data);
                }
            }
            catch (Exception ex) { XuLyLoi.Handle(ex); }
            return bangThucHienThuocs;
        }
        public static bool InsertOrUpdatePhieu(MDB.MDBConnection MyConnection, ref PhieuTheoDoiVaChamSoc phieuTheoDoi)
        {
            try
            {
                string sql = @"INSERT INTO PhieuTheoDoiVaChamSoc
                (
                    MAQUANLY,
                    MaBenhNhan,
                    TenBenhNhan,
	                Tuoi,
                    GioiTinh,
                    Khoa,
	                MaKhoa,
	                SoGiuong,
	                ChanDoan,
	                DieuDuongCaSang,
	                MaDieuDuongCaSang,
	                DieuDuongCaChieu,
	                MaDieuDuongCaChieu,
	                DieuDuongCaDem,
	                MaDieuDuongCaDem,
	                DichTruyen,
	                ThuocTiem,
	                ThuocUong,
	                CanLamSang,
	                ChamSocDieuDuong,
                    NGUOITAO,
                    NGUOISUA,
                    NGAYTAO,
                    NGAYSUA)  VALUES
                 (
				    :MAQUANLY,
                    :MaBenhNhan,
                    :TenBenhNhan,
	                :Tuoi,
                    :GioiTinh,
                    :Khoa,
	                :MaKhoa,
	                :SoGiuong,
	                :ChanDoan,
	                :DieuDuongCaSang,
	                :MaDieuDuongCaSang,
	                :DieuDuongCaChieu,
	                :MaDieuDuongCaChieu,
	                :DieuDuongCaDem,
	                :MaDieuDuongCaDem,
	                :DichTruyen,
	                :ThuocTiem,
	                :ThuocUong,
	                :CanLamSang,
	                :ChamSocDieuDuong,
                    :NGUOITAO,
                    :NGUOISUA,
                    :NGAYTAO,
                    :NGAYSUA
                 )  RETURNING ID INTO :ID";
                if (phieuTheoDoi.ID != 0)
                {
                    sql = @"UPDATE PhieuTheoDoiVaChamSoc SET 
                    MAQUANLY = :MAQUANLY,
                    MaBenhNhan = :MaBenhNhan,
                    TenBenhNhan = :TenBenhNhan,
	                Tuoi = :Tuoi,
                    GioiTinh = :GioiTinh,
                    Khoa = :Khoa,
	                MaKhoa = :MaKhoa,
	                SoGiuong = :SoGiuong,
	                ChanDoan = :ChanDoan,
	                DieuDuongCaSang = :DieuDuongCaSang,
	                MaDieuDuongCaSang = :MaDieuDuongCaSang,
	                DieuDuongCaChieu = :DieuDuongCaChieu,
	                MaDieuDuongCaChieu = :MaDieuDuongCaChieu,
	                DieuDuongCaDem = :DieuDuongCaDem,
	                MaDieuDuongCaDem = :MaDieuDuongCaDem,
	                DichTruyen = :DichTruyen,
	                ThuocTiem = :ThuocTiem,
	                ThuocUong = :ThuocUong,
	                CanLamSang = :CanLamSang,
	                ChamSocDieuDuong = :ChamSocDieuDuong,
                    NGUOISUA = :NGUOISUA,
                    NGAYSUA = :NGAYSUA
                    WHERE ID = " + phieuTheoDoi.ID;
                }
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MAQUANLY", phieuTheoDoi.MaQuanLy));
                Command.Parameters.Add(new MDB.MDBParameter("MaBenhNhan", phieuTheoDoi.MaBenhNhan));
                Command.Parameters.Add(new MDB.MDBParameter("TenBenhNhan", phieuTheoDoi.TenBenhNhan));
                Command.Parameters.Add(new MDB.MDBParameter("Tuoi", phieuTheoDoi.Tuoi));
                Command.Parameters.Add(new MDB.MDBParameter("GioiTinh", phieuTheoDoi.GioiTinh));
                Command.Parameters.Add(new MDB.MDBParameter("Khoa", phieuTheoDoi.Khoa));
                Command.Parameters.Add(new MDB.MDBParameter("MaKhoa", phieuTheoDoi.MaKhoa));
                Command.Parameters.Add(new MDB.MDBParameter("SoGiuong", phieuTheoDoi.SoGiuong));
                Command.Parameters.Add(new MDB.MDBParameter("ChanDoan", phieuTheoDoi.ChanDoan));
                Command.Parameters.Add(new MDB.MDBParameter("DieuDuongCaSang", phieuTheoDoi.DieuDuongCaSang));
                Command.Parameters.Add(new MDB.MDBParameter("MaDieuDuongCaSang", phieuTheoDoi.MaDieuDuongCaSang));
                Command.Parameters.Add(new MDB.MDBParameter("DieuDuongCaChieu", phieuTheoDoi.DieuDuongCaChieu));
                Command.Parameters.Add(new MDB.MDBParameter("MaDieuDuongCaChieu", phieuTheoDoi.MaDieuDuongCaChieu));
                Command.Parameters.Add(new MDB.MDBParameter("DieuDuongCaDem", phieuTheoDoi.DieuDuongCaDem));
                Command.Parameters.Add(new MDB.MDBParameter("MaDieuDuongCaDem", phieuTheoDoi.MaDieuDuongCaDem));
                Command.Parameters.Add(new MDB.MDBParameter("DichTruyen", JsonConvert.SerializeObject(phieuTheoDoi.DichTruyen)));
                Command.Parameters.Add(new MDB.MDBParameter("ThuocTiem", JsonConvert.SerializeObject(phieuTheoDoi.ThuocTiem)));
                Command.Parameters.Add(new MDB.MDBParameter("ThuocUong", JsonConvert.SerializeObject(phieuTheoDoi.ThuocUong)));
                Command.Parameters.Add(new MDB.MDBParameter("CanLamSang", phieuTheoDoi.CanLamSang));
                Command.Parameters.Add(new MDB.MDBParameter("ChamSocDieuDuong", phieuTheoDoi.ChamSocDieuDuong));
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
        public static bool InsertOrUpdateThongTinGio(MDB.MDBConnection MyConnection, ThongTinGioChamSoc thongTinGio)
        {
            try
            {
                string sql = @"INSERT INTO PhieuTheoDoiVaChamSoc_Gio
                (
                    ID_Phieu,
                    Gio,
                    Mach,
                    HuyetApTren,
                    HuyetApDuoi,
                    NhietDo,
                    NhipTho,
                    O2,
                    SPO2,
                    DichTruyen,
                    TocDo,
                    TongDichTruyen,
                    AnUong,
                    NuocTieu,
                    DichKhac,
                    DieuTri,
                    MoMat,
                    DapUngLoiNoi,
                    DapUngVanDong,
                    TongCong,
                    DongTuTrai_DoLon,
                    DongTuTrai_PhanXa,
                    DongTuPhai_DoLon,
                    DongTuPhai_PhanXa,
                    DoAmChi,
                    BungChuong,
                    VongBung,
                    CanNang,
                    CanLamSang,
                    ChamSoc)  VALUES
                 (
				    :ID_Phieu,
                    :Gio,
                    :Mach,
                    :HuyetApTren,
                    :HuyetApDuoi,
                    :NhietDo,
                    :NhipTho,
                    :O2,
                    :SPO2,
                    :DichTruyen,
                    :TocDo,
                    :TongDichTruyen,
                    :AnUong,
                    :NuocTieu,
                    :DichKhac,
                    :DieuTri,
                    :MoMat,
                    :DapUngLoiNoi,
                    :DapUngVanDong,
                    :TongCong,
                    :DongTuTrai_DoLon,
                    :DongTuTrai_PhanXa,
                    :DongTuPhai_DoLon,
                    :DongTuPhai_PhanXa,
                    :DoAmChi,
                    :BungChuong,
                    :VongBung,
                    :CanNang,
                    :CanLamSang,
                    :ChamSoc
                 )";
                if (thongTinGio.ID != 0)
                {
                    sql = @"UPDATE PhieuTheoDoiVaChamSoc_Gio SET 
                     ID_Phieu = :ID_Phieu,
                     Gio = :Gio,
                     Mach = :Mach,
                     HuyetApTren = :HuyetApTren,
                     HuyetApDuoi = :HuyetApDuoi,
                     NhietDo = :NhietDo,
                     NhipTho = :NhipTho,
                     O2 = :O2,
                     SPO2 = :SPO2,
                     DichTruyen = :DichTruyen,
                     TocDo = :TocDo,
                     TongDichTruyen = :TongDichTruyen,
                     AnUong = :AnUong,
                     NuocTieu = :NuocTieu,   
                     DichKhac = :DichKhac,
                     DieuTri = :DieuTri,
                     MoMat = :MoMat,
                     DapUngLoiNoi = :DapUngLoiNoi,
                     DapUngVanDong = :DapUngVanDong,
                     TongCong = :TongCong,
                     DongTuTrai_DoLon = :DongTuTrai_DoLon,
                     DongTuTrai_PhanXa = :DongTuTrai_PhanXa,
                     DongTuPhai_DoLon = :DongTuPhai_DoLon,
                     DongTuPhai_PhanXa = :DongTuPhai_PhanXa,
                     DoAmChi = :DoAmChi,
                     BungChuong = :BungChuong,
                     VongBung = :VongBung,
                     CanNang = :CanNang,
                     CanLamSang = :CanLamSang,
                     ChamSoc = :ChamSoc
                    WHERE ID = " + thongTinGio.ID;
                }
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
                Command.Parameters.Add(new MDB.MDBParameter("ID_Phieu", thongTinGio.ID_Phieu));
                Command.Parameters.Add(new MDB.MDBParameter("Gio", thongTinGio.Gio));
                Command.Parameters.Add(new MDB.MDBParameter("Mach", thongTinGio.Mach));
                Command.Parameters.Add(new MDB.MDBParameter("HuyetApTren", thongTinGio.HuyetApTren));
                Command.Parameters.Add(new MDB.MDBParameter("HuyetApDuoi", thongTinGio.HuyetApDuoi));
                Command.Parameters.Add(new MDB.MDBParameter("NhietDo", thongTinGio.NhietDo));
                Command.Parameters.Add(new MDB.MDBParameter("NhipTho", thongTinGio.NhipTho));
                Command.Parameters.Add(new MDB.MDBParameter("O2", thongTinGio.O2));
                Command.Parameters.Add(new MDB.MDBParameter("SPO2", thongTinGio.SPO2));
                Command.Parameters.Add(new MDB.MDBParameter("DichTruyen", thongTinGio.DichTruyen));
                Command.Parameters.Add(new MDB.MDBParameter("TocDo", thongTinGio.TocDo));
                Command.Parameters.Add(new MDB.MDBParameter("TongDichTruyen", thongTinGio.TongDichTruyen));
                Command.Parameters.Add(new MDB.MDBParameter("AnUong", thongTinGio.AnUong));
                Command.Parameters.Add(new MDB.MDBParameter("NuocTieu", thongTinGio.NuocTieu));
                Command.Parameters.Add(new MDB.MDBParameter("DichKhac", thongTinGio.DichKhac));
                Command.Parameters.Add(new MDB.MDBParameter("DieuTri", thongTinGio.DieuTri));
                Command.Parameters.Add(new MDB.MDBParameter("MoMat", thongTinGio.MoMat));
                Command.Parameters.Add(new MDB.MDBParameter("DapUngLoiNoi", thongTinGio.DapUngLoiNoi));
                Command.Parameters.Add(new MDB.MDBParameter("DapUngVanDong", thongTinGio.DapUngVanDong));
                Command.Parameters.Add(new MDB.MDBParameter("TongCong", thongTinGio.TongCong));
                Command.Parameters.Add(new MDB.MDBParameter("DongTuTrai_DoLon", thongTinGio.DongTuTrai_DoLon));
                Command.Parameters.Add(new MDB.MDBParameter("DongTuTrai_PhanXa", thongTinGio.DongTuTrai_PhanXa));
                Command.Parameters.Add(new MDB.MDBParameter("DongTuPhai_DoLon", thongTinGio.DongTuPhai_DoLon));
                Command.Parameters.Add(new MDB.MDBParameter("DongTuPhai_PhanXa", thongTinGio.DongTuPhai_PhanXa));
                Command.Parameters.Add(new MDB.MDBParameter("DoAmChi", thongTinGio.DoAmChi));
                Command.Parameters.Add(new MDB.MDBParameter("BungChuong", thongTinGio.BungChuong));
                Command.Parameters.Add(new MDB.MDBParameter("VongBung", thongTinGio.VongBung));
                Command.Parameters.Add(new MDB.MDBParameter("CanNang", thongTinGio.CanNang));
                Command.Parameters.Add(new MDB.MDBParameter("CanLamSang", thongTinGio.CanLamSang));
                Command.Parameters.Add(new MDB.MDBParameter("ChamSoc", thongTinGio.ChamSoc));
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
        public static bool InsertOrUpdateGhiChu(MDB.MDBConnection MyConnection, TheoDoiGhiChu thongTinGhiChu)
        {
            try
            {
                string sql = @"INSERT INTO PhieuTheoDoiVaChamSoc_GhiChu
                (
                    ID_Phieu,
                    Gio,
                    GhiChu)  VALUES
                 (
				    :ID_Phieu,
                    :Gio,
                    :GhiChu
                 )";
                if (thongTinGhiChu.ID != 0)
                {
                    sql = @"UPDATE PhieuTheoDoiVaChamSoc_GhiChu SET 
                    ID_Phieu = :ID_Phieu,
                    Gio = :Gio,
                    GhiChu = :GhiChu
                    WHERE ID = " + thongTinGhiChu.ID;
                }
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
                Command.Parameters.Add(new MDB.MDBParameter("ID_Phieu", thongTinGhiChu.ID_Phieu));
                Command.Parameters.Add(new MDB.MDBParameter("Gio", thongTinGhiChu.Gio));
                Command.Parameters.Add(new MDB.MDBParameter("GhiChu", thongTinGhiChu.GhiChu));
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
                string sql = "DELETE FROM PhieuTheoDoiVaChamSoc WHERE ID = :ID";
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
                string sql = "DELETE FROM PhieuTheoDoiVaChamSoc_Gio WHERE ID = :ID";
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
        public static bool deleteThongTinGhiChu(MDB.MDBConnection MyConnection, long id)
        {
            try
            {
                string sql = "DELETE FROM PhieuTheoDoiVaChamSoc_GhiChu WHERE ID = :ID";
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
        public static string ConvertNumber(decimal _Number)
        {
            try
            {
                string strRet = string.Empty;
                Boolean _Flag = true;
                string[] ArrLama = { "M", "CM", "D", "CD", "C", "XC", "L", "XL", "X", "IX", "V", "IV", "I" };
                int[] ArrNumber = { 1000, 900, 500, 400, 100, 90, 50, 40, 10, 9, 5, 4, 1 };
                int i = 0;
                while (_Flag)
                {
                    while (_Number >= ArrNumber[i])
                    {
                        _Number -= ArrNumber[i];
                        strRet += ArrLama[i];
                        if (_Number < 1)
                            _Flag = false;
                    }
                    i++;
                }
                return strRet;
            }
            catch (Exception ex)
            {
                return string.Empty;
            }
        }

    }
}
