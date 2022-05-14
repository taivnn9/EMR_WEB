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
    public class VatLieuCEC
    {
        [MoTaDuLieu("Montage")]
        public string Montage { get; set; }
        [MoTaDuLieu("Oxy genateur")]
        public string OxyGenateur { get; set; }
        [MoTaDuLieu("Resseervoir")]
        public string Resseervoir { get; set; }
        [MoTaDuLieu("Hemofiltre")]
        public string Hemofiltre { get; set; }
        [MoTaDuLieu("CPG")]
        public string CPG { get; set; }
        [MoTaDuLieu("Canule Aor")]
        public string CanuleAor { get; set; }
        [MoTaDuLieu("Canule Vein")]
        public string CanuleVein { get; set; }
    }
    public class LieuThuocCEC
    {
        [MoTaDuLieu("Tên thuốc")]
        public string Ten { get; set; }
        [MoTaDuLieu("Số lượng")]
        public double? SoLuong { get; set; }
        [MoTaDuLieu("Đơn vị")]
        public string DonVi { get; set; }

    }
    public class XetNghiemCEC 
    {
        [MoTaDuLieu("GS")]
        public string GS { get; set; }
        [MoTaDuLieu("FE")]
        public string FE { get; set; }
        [MoTaDuLieu("Rct")]
        public string Rct { get; set; }
        [MoTaDuLieu("Hct preop")]
        public string HctPreop { get; set; }
        [MoTaDuLieu("TP")]
        public string TP { get; set; }
        [MoTaDuLieu("Fig")]
        public string Fig { get; set; }
        [MoTaDuLieu("Protidemie")]
        public string Protidemie { get; set; }
    }
    public class PrimingCEC
    {
        [MoTaDuLieu("Tên")]
        public string Ten { get; set; }
        [MoTaDuLieu("Priming")]
        public string Priming { get; set; }
        [MoTaDuLieu("Bù dịch trong CEC")]
        public string BuDichTrongCEC { get; set; }
    }
    public class KhiMauCEC
    {
        [MoTaDuLieu("Tên")]
        public string Ten { get; set; }
        [MoTaDuLieu("Trước")]
        public double? Truoc { get; set; }
        [MoTaDuLieu("Trong")]
        public double? Trong { get; set; }
    }
    public class ChiSoCEC
    {
        [MoTaDuLieu("Thời gian")]
        public int? ThoiGian { get; set; }
        [MoTaDuLieu("Lưu lượng")]
        public double? LuuLuong { get; set; }
        [MoTaDuLieu("Huyết áp trung bình")]
        public double? HATrungBinh { get; set; }
        [MoTaDuLieu("TT Tực quản")]
        public string TucQUan { get; set; }
        [MoTaDuLieu("Thực quản")]
        public string ThucQUan { get; set; }
        [MoTaDuLieu("Lưu lượng K2/O2")]
        public string LuuLuongK2O2 { get; set; }
        [MoTaDuLieu("Nước tiểu")]
		public string NuocTieu { get; set; }
        [MoTaDuLieu("Thuốc")]
        public string Thuoc { get; set; }
        [MoTaDuLieu("Cặp/Thả ĐMC")]
        public string CapThaDMC { get; set; }
        [MoTaDuLieu("Thay đổi")]
        public string ThayDoi { get; set; }
    }
    public class DungDichLietTim
    {
        [MoTaDuLieu("STT")]
        public int? No { get; set; }
        [MoTaDuLieu("Xuôi dòng: Aig")]
        public bool XD_Aig { get; set; }
        [MoTaDuLieu("Xuôi dòng: A")]
        public bool XD_A { get; set; }
        [MoTaDuLieu("Xuôi dòng: Coron")]
        public bool XD_Coron { get; set; }
        [MoTaDuLieu("Ngược dòng")]
        public bool ND { get; set; }
        [MoTaDuLieu("Máu")]
        public bool Mau { get; set; }
        [MoTaDuLieu("Điện tim: Tốt")]
        public bool DT_Tot { get; set; }
        [MoTaDuLieu("Điện tim: xấu")]
        public bool DT_Xau { get; set; }
    }
    public class TheoDoiCEC
    {
        [MoTaDuLieu("CEC nhiệt độ bình thường")]
        public string CEC_NhietDo { get; set; }
        [MoTaDuLieu("CEC hạ nhiệt độ")]
        public string CEC_HaNhietDo { get; set; }
        [MoTaDuLieu("CEC tim rung")]
        public string CEC_TimRun { get; set; }
        [MoTaDuLieu("CEC tim đập")]
        public string CEC_TimDap { get; set; }
        [MoTaDuLieu("Ngừng tuần hoàn")]
        public string NgungTuanHoan { get; set; }
        [MoTaDuLieu("Tim tự đập")]
        public string TimTuDap { get; set; }
        [MoTaDuLieu("Chống rung")]
        public string ChongRung { get; set; }
        [MoTaDuLieu("Tai nạn")]
        public string TaiNan { get; set; }
    }
    public class BilanCEC
    {
        [MoTaDuLieu("Dịch vào")]
        public double? DichVao { get; set; }
        [MoTaDuLieu("Oxygennatem vào")]
        public double? Oxygennatem_Vao { get; set; }
        [MoTaDuLieu("Dịch đổ vảo")]
        public double? DichDoVao { get; set; }
        [MoTaDuLieu("Cardioplrgie")]
        public double? Cardioplrgie { get; set; }
        [MoTaDuLieu("Bù")]
        public double? Bu { get; set; }
        [MoTaDuLieu("Tổng cộng vào")]
        public double? TongCongVao { get; set; }
        [MoTaDuLieu("Dịch ra")]
        public double? DichRa { get; set; }
        [MoTaDuLieu("Oxygennatem ra")]
        public double? Oxygennatem_Ra { get; set; }
        [MoTaDuLieu("Máy hút")]
        public double? MayHut { get; set; }
        [MoTaDuLieu("Nước tiểu")]
        public double? NuocTieu { get; set; }
        [MoTaDuLieu("Dịch lọc")]
        public double? DichLoc { get; set; }
        [MoTaDuLieu("Tổng cộng ra")]
        public double? TongCongRa { get; set; }
    }
    public class BangTheoDoiCEC : ThongTinKy
    {
        public BangTheoDoiCEC()
        {
            TableName = "BangTheoDoiCEC";
            TablePrimaryKeyName = "ID";
            IDMauPhieu = (int)DanhMucPhieu.BTDCEC;
            TenMauPhieu = DanhMucPhieu.BTDCEC.Description();
        }
        [MoTaDuLieu("Mã định danh")]
		public long ID { get; set; }
        [MoTaDuLieu("Mã quản lý: mã duy nhất trong 1 đợt khám chữa bệnh (kcb), không trùng giữa các đợt kcb khác nhau","",1)]
		public decimal MaQuanLy { get; set; }
        [MoTaDuLieu("Mã bệnh nhân")]
		public string MaBenhNhan { get; set; }
        [MoTaDuLieu("Ngày lập bảng")]
        public DateTime? NgayLapBang { get; set; }
        [MoTaDuLieu("Họ và tên bệnh nhân")]
		public string TenBenhNhan { get; set; }
        [MoTaDuLieu("Giới tính bệnh nhân")]
		public string GioiTinh { get; set; }
        [MoTaDuLieu("Tuổi bệnh nhân")]
		public string Tuoi { get; set; }
        [MoTaDuLieu("Cân nặng bệnh nhân")]
        public double? CanNang { get; set; }
        [MoTaDuLieu("Chiều cao bệnh nhân")]
        public double? ChieuCao { get; set; }
        [MoTaDuLieu("Chẩn đoán bệnh")]
		public string ChanDoan { get; set; }
        [MoTaDuLieu("SC")]
        public double? SC { get; set; }
        [MoTaDuLieu("Lưu lượng tối thiểu")]
        public double? LuuLuongToiThieu { get; set; }
        [MoTaDuLieu("Lưu lượng tối đa")]
        public double? ToiDa { get; set; }
        [MoTaDuLieu("Danh sách kíp Phẫu thuật viên")]
        public ObservableCollection<NhanVien> KipPTV { get; set; }
        [MoTaDuLieu("Danh sách kíp Gây mê")]
        public ObservableCollection<NhanVien> KipGM { get; set; }
        [MoTaDuLieu("Danh sách kíp CEC")]
        public ObservableCollection<NhanVien> KipCEC { get; set; }
        [MoTaDuLieu("Vật liệu")]
        public VatLieuCEC VatLieu { get; set; }
        [MoTaDuLieu("Dãn mạch")]
        public LieuThuocCEC DanMach { get; set; }
        [MoTaDuLieu("Co mạch")]
        public LieuThuocCEC CoMach { get; set; }
        [MoTaDuLieu("Heparine")]
        public LieuThuocCEC Heparine { get; set; }
        [MoTaDuLieu("Khác")]
        public LieuThuocCEC Khac { get; set; }
        [MoTaDuLieu("Xét nghiệm")]
        public XetNghiemCEC XetNghiem { get; set; }
        [MoTaDuLieu("Danh sách Priming")]
        public ObservableCollection<PrimingCEC> Primings { get; set; }
        [MoTaDuLieu("Danh sách Khí máu")]
        public ObservableCollection<KhiMauCEC> KhiMaus { get; set; }
        [MoTaDuLieu("Danh sách Chỉ số CEC")]
        public ObservableCollection<ChiSoCEC> ChiSos { get; set; }
        [MoTaDuLieu("Hỗ trợ CEC")]
        public string CECHoTro { get; set; }
        [MoTaDuLieu("Thời gian chạy máy")]
        public double? ThoiGianChayMay { get; set; }
        [MoTaDuLieu("Thời gian cặp ĐMC")]
        public double? ThoiGianCapDMC { get; set; }
        [MoTaDuLieu("")]
        public DungDichLietTim No1 { get; set; }
        [MoTaDuLieu("")]
        public DungDichLietTim No2 { get; set; }
        [MoTaDuLieu("")]
        public DungDichLietTim No3 { get; set; }
        [MoTaDuLieu("")]
        public DungDichLietTim No4 { get; set; }
        [MoTaDuLieu("")]
        public DungDichLietTim No5 { get; set; }
        [MoTaDuLieu("Thông tin theo dõi")]
        public TheoDoiCEC TheoDoi { get; set; }
        [MoTaDuLieu("Thông tin Bilan")]
        public BilanCEC Bilan { get; set; }
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
    public class BangTheoDoiCECFunc
    {
        public const string TableName = "BangTheoDoiCEC";
        public const string TablePrimaryKeyName = "ID";
        public static BangTheoDoiCEC GetData(MDB.MDBConnection _OracleConnection, long ID)
        {
            BangTheoDoiCEC data = new BangTheoDoiCEC();
            try
            {
                string sql = @"SELECT * FROM BangTheoDoiCEC where ID = :ID";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, _OracleConnection);
                Command.Parameters.Add(new MDB.MDBParameter("ID", ID));
                MDB.MDBDataReader DataReader = Command.ExecuteReader();
                while (DataReader.Read())
                {
                    data.ID = Convert.ToInt64(DataReader.GetLong("ID").ToString());
                    data.MaQuanLy = DataReader.GetDecimal("maquanly");
                    data.MaBenhNhan = DataReader["MaBenhNhan"].ToString();
                    data.TenBenhNhan = XemBenhAn._HanhChinhBenhNhan.TenBenhNhan;
                    data.Tuoi = XemBenhAn._HanhChinhBenhNhan.Tuoi;
                    data.GioiTinh = XemBenhAn._HanhChinhBenhNhan.GioiTinh.Description();
                    data.NgayLapBang = DataReader["NgayLapBang"] == DBNull.Value ? (DateTime?)null : DataReader.GetDate("NgayLapBang");
                    double doubleTemp = 0;
                    data.CanNang = double.TryParse(DataReader["CanNang"].ToString(), out doubleTemp) ? doubleTemp : (double?)null;
                    doubleTemp = 0;
                    data.ChieuCao = double.TryParse(DataReader["ChieuCao"].ToString(), out doubleTemp) ? doubleTemp : (double?)null;
                    data.ChanDoan = DataReader["ChanDoan"].ToString();
                    doubleTemp = 0;
                    data.SC = double.TryParse(DataReader["SC"].ToString(), out doubleTemp) ? doubleTemp : (double?)null;
                    doubleTemp = 0;
                    data.LuuLuongToiThieu = double.TryParse(DataReader["LuuLuongToiThieu"].ToString(), out doubleTemp) ? doubleTemp : (double?)null;
                    doubleTemp = 0;
                    data.ToiDa = double.TryParse(DataReader["ToiDa"].ToString(), out doubleTemp) ? doubleTemp : (double?)null;
                    data.KipPTV = JsonConvert.DeserializeObject<ObservableCollection<NhanVien>>(DataReader["KipPTV"].ToString());
                    data.KipGM = JsonConvert.DeserializeObject<ObservableCollection<NhanVien>>(DataReader["KipGM"].ToString());
                    data.KipCEC = JsonConvert.DeserializeObject<ObservableCollection<NhanVien>>(DataReader["KipCEC"].ToString());

                    data.VatLieu = JsonConvert.DeserializeObject<VatLieuCEC>(DataReader["VatLieu"].ToString());
                    data.DanMach = JsonConvert.DeserializeObject<LieuThuocCEC>(DataReader["DanMach"].ToString());
                    data.CoMach = JsonConvert.DeserializeObject<LieuThuocCEC>(DataReader["CoMach"].ToString());
                    data.Heparine = JsonConvert.DeserializeObject<LieuThuocCEC>(DataReader["Heparine"].ToString());
                    data.Khac = JsonConvert.DeserializeObject<LieuThuocCEC>(DataReader["Khac"].ToString());
                    data.XetNghiem = JsonConvert.DeserializeObject<XetNghiemCEC>(DataReader["XetNghiem"].ToString());
                    data.Primings = JsonConvert.DeserializeObject<ObservableCollection<PrimingCEC>>(DataReader["Primings"].ToString());
                    data.KhiMaus = JsonConvert.DeserializeObject<ObservableCollection<KhiMauCEC>>(DataReader["KhiMaus"].ToString());

                    string ChiSosJson = DataReader["ChiSos_1"].ToString();
                    if (DataReader["ChiSos_2"] != DBNull.Value)
                        ChiSosJson += DataReader["ChiSos_2"].ToString();
                    data.ChiSos = JsonConvert.DeserializeObject<ObservableCollection<ChiSoCEC>>(ChiSosJson);

                    data.CECHoTro = DataReader["CECHoTro"].ToString();

                    doubleTemp = 0;
                    data.ThoiGianChayMay = double.TryParse(DataReader["ThoiGianChayMay"].ToString(), out doubleTemp) ? doubleTemp : (double?)null;
                    doubleTemp = 0;
                    data.ThoiGianCapDMC = double.TryParse(DataReader["ThoiGianCapDMC"].ToString(), out doubleTemp) ? doubleTemp : (double?)null;

                    data.No1 = JsonConvert.DeserializeObject<DungDichLietTim>(DataReader["No1"].ToString());
                    data.No2 = JsonConvert.DeserializeObject<DungDichLietTim>(DataReader["No2"].ToString());
                    data.No3 = JsonConvert.DeserializeObject<DungDichLietTim>(DataReader["No3"].ToString());
                    data.No4 = JsonConvert.DeserializeObject<DungDichLietTim>(DataReader["No4"].ToString());
                    data.No5 = JsonConvert.DeserializeObject<DungDichLietTim>(DataReader["No5"].ToString());

                    data.TheoDoi = JsonConvert.DeserializeObject<TheoDoiCEC>(DataReader["TheoDoi"].ToString());
                    data.Bilan = JsonConvert.DeserializeObject<BilanCEC>(DataReader["Bilan"].ToString());

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
        public static List<BangTheoDoiCEC> GetListData(MDB.MDBConnection _OracleConnection, decimal maquanly)
        {
            List<BangTheoDoiCEC> list = new List<BangTheoDoiCEC>();
            try
            {
                string sql = @"SELECT * FROM BangTheoDoiCEC where MaQuanLy = :MaQuanLy";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, _OracleConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", maquanly));
                MDB.MDBDataReader DataReader = Command.ExecuteReader();
                while (DataReader.Read())
                {
                    BangTheoDoiCEC data = new BangTheoDoiCEC();
                    data.ID = Convert.ToInt64(DataReader.GetLong("ID").ToString());
                    data.MaQuanLy = maquanly;
                    data.MaBenhNhan = DataReader["MaBenhNhan"].ToString();
                    data.TenBenhNhan = XemBenhAn._HanhChinhBenhNhan.TenBenhNhan;
                    data.Tuoi = XemBenhAn._HanhChinhBenhNhan.Tuoi;
                    data.GioiTinh = XemBenhAn._HanhChinhBenhNhan.GioiTinh.Description();
                    data.NgayLapBang = DataReader["NgayLapBang"] == DBNull.Value ? (DateTime?) null : DataReader.GetDate("NgayLapBang");
                    double doubleTemp = 0;
                    data.CanNang = double.TryParse(DataReader["CanNang"].ToString(), out doubleTemp) ? doubleTemp : (double?) null;
                    doubleTemp = 0;
                    data.ChieuCao = double.TryParse(DataReader["ChieuCao"].ToString(), out doubleTemp) ? doubleTemp : (double?) null;
                    data.ChanDoan = DataReader["ChanDoan"].ToString();
                    doubleTemp = 0;
                    data.SC = double.TryParse(DataReader["SC"].ToString(), out doubleTemp) ? doubleTemp : (double?) null;
                    doubleTemp = 0;
                    data.LuuLuongToiThieu = double.TryParse(DataReader["LuuLuongToiThieu"].ToString(), out doubleTemp) ? doubleTemp : (double?) null;
                    doubleTemp = 0;
                    data.ToiDa = double.TryParse(DataReader["ToiDa"].ToString(), out doubleTemp) ? doubleTemp : (double?) null;
                    data.KipPTV = JsonConvert.DeserializeObject<ObservableCollection<NhanVien>>(DataReader["KipPTV"].ToString());
                    data.KipGM = JsonConvert.DeserializeObject<ObservableCollection<NhanVien>>(DataReader["KipGM"].ToString());
                    data.KipCEC = JsonConvert.DeserializeObject<ObservableCollection<NhanVien>>(DataReader["KipCEC"].ToString());

                    data.VatLieu = JsonConvert.DeserializeObject<VatLieuCEC>(DataReader["VatLieu"].ToString());
                    data.DanMach = JsonConvert.DeserializeObject<LieuThuocCEC>(DataReader["DanMach"].ToString());
                    data.CoMach = JsonConvert.DeserializeObject<LieuThuocCEC>(DataReader["CoMach"].ToString());
                    data.Heparine = JsonConvert.DeserializeObject<LieuThuocCEC>(DataReader["Heparine"].ToString());
                    data.Khac = JsonConvert.DeserializeObject<LieuThuocCEC>(DataReader["Khac"].ToString());
                    data.XetNghiem = JsonConvert.DeserializeObject<XetNghiemCEC>(DataReader["XetNghiem"].ToString());
                    data.Primings = JsonConvert.DeserializeObject<ObservableCollection<PrimingCEC>>(DataReader["Primings"].ToString());
                    data.KhiMaus = JsonConvert.DeserializeObject<ObservableCollection<KhiMauCEC>>(DataReader["KhiMaus"].ToString());

                    string ChiSosJson = DataReader["ChiSos_1"].ToString();
                    if (DataReader["ChiSos_2"] != DBNull.Value)
                        ChiSosJson += DataReader["ChiSos_2"].ToString();
                    data.ChiSos = JsonConvert.DeserializeObject<ObservableCollection<ChiSoCEC>>(ChiSosJson);

                    data.CECHoTro = DataReader["CECHoTro"].ToString();

                    doubleTemp = 0;
                    data.ThoiGianChayMay = double.TryParse(DataReader["ThoiGianChayMay"].ToString(), out doubleTemp) ? doubleTemp : (double?) null;
                    doubleTemp = 0;
                    data.ThoiGianCapDMC = double.TryParse(DataReader["ThoiGianCapDMC"].ToString(), out doubleTemp) ? doubleTemp : (double?) null;
                    
                    data.No1 = JsonConvert.DeserializeObject<DungDichLietTim>(DataReader["No1"].ToString());
                    data.No2 = JsonConvert.DeserializeObject<DungDichLietTim>(DataReader["No2"].ToString());
                    data.No3 = JsonConvert.DeserializeObject<DungDichLietTim>(DataReader["No3"].ToString());
                    data.No4 = JsonConvert.DeserializeObject<DungDichLietTim>(DataReader["No4"].ToString());
                    data.No5 = JsonConvert.DeserializeObject<DungDichLietTim>(DataReader["No5"].ToString());

                    data.TheoDoi = JsonConvert.DeserializeObject<TheoDoiCEC>(DataReader["TheoDoi"].ToString());
                    data.Bilan = JsonConvert.DeserializeObject<BilanCEC>(DataReader["Bilan"].ToString());

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
        public static bool InsertOrUpdate(MDB.MDBConnection MyConnection, ref BangTheoDoiCEC bangTheoDoi)
        {
            try
            {
                string sql = @"INSERT INTO BangTheoDoiCEC
                (
                    MAQUANLY,
                    MaBenhNhan,
                    NgayLapBang,
                    CanNang,
                    ChieuCao,
                    ChanDoan,
                    SC,
                    LuuLuongToiThieu,
                    ToiDa,
                    KipPTV,
                    KipGM,
                    KipCEC,
                    VatLieu,
                    DanMach,
                    CoMach,
                    Heparine,
                    Khac,
                    XetNghiem,
                    Primings,
                    KhiMaus,
                    ChiSos_1,
                    ChiSos_2,
                    CECHoTro,
                    ThoiGianChayMay,
                    ThoiGianCapDMC,
                    No1,
                    No2,
                    No3,
                    No4,
                    No5,
                    TheoDoi,
                    Bilan,
                    NGUOITAO,
                    NGUOISUA,
                    NGAYTAO,
                    NGAYSUA)  VALUES
                 (
                    :MAQUANLY,
                    :MaBenhNhan,
                    :NgayLapBang,
                    :CanNang,
                    :ChieuCao,
                    :ChanDoan,
                    :SC,
                    :LuuLuongToiThieu,
                    :ToiDa,
                    :KipPTV,
                    :KipGM,
                    :KipCEC,
                    :VatLieu,
                    :DanMach,
                    :CoMach,
                    :Heparine,
                    :Khac,
                    :XetNghiem,
                    :Primings,
                    :KhiMaus,
                    :ChiSos_1,
                    :ChiSos_2,
                    :CECHoTro,
                    :ThoiGianChayMay,
                    :ThoiGianCapDMC,
                    :No1,
                    :No2,
                    :No3,
                    :No4,
                    :No5,
                    :TheoDoi,
                    :Bilan,
                    :NGUOITAO,
                    :NGUOISUA,
                    :NGAYTAO,
                    :NGAYSUA
                 )  RETURNING ID INTO :ID";
                if (bangTheoDoi.ID != 0)
                {
                    sql = @"UPDATE BangTheoDoiCEC SET 
                    MAQUANLY = :MAQUANLY,
                    MaBenhNhan = :MaBenhNhan,
                    NgayLapBang = :NgayLapBang,
                    CanNang = :CanNang,
                    ChieuCao = :ChieuCao,
                    ChanDoan = :ChanDoan,
                    SC = :SC,
                    LuuLuongToiThieu = :LuuLuongToiThieu,
                    ToiDa = :ToiDa,
                    KipPTV = :KipPTV,
                    KipGM = :KipGM,
                    KipCEC = :KipCEC,
                    VatLieu = :VatLieu,
                    DanMach = :DanMach,
                    CoMach = :CoMach,
                    Heparine = :Heparine,
                    Khac = :Khac,
                    XetNghiem = :XetNghiem,
                    Primings = :Primings,
                    KhiMaus = :KhiMaus,
                    ChiSos_1 = :ChiSos_1,
                    ChiSos_2 = :ChiSos_2,
                    CECHoTro = :CECHoTro,
                    ThoiGianChayMay = :ThoiGianChayMay,
                    ThoiGianCapDMC = :ThoiGianCapDMC,
                    No1 = :No1,
                    No2 = :No2,
                    No3 = :No3,
                    No4 = :No4,
                    No5 = :No5,
                    TheoDoi = :TheoDoi,
                    Bilan = :Bilan,
                    NGUOISUA = :NGUOISUA,
                    NGAYSUA = :NGAYSUA
                    WHERE ID = " + bangTheoDoi.ID;
                }
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MAQUANLY", bangTheoDoi.MaQuanLy));
                Command.Parameters.Add(new MDB.MDBParameter("MaBenhNhan", bangTheoDoi.MaBenhNhan));
                Command.Parameters.Add(new MDB.MDBParameter("NgayLapBang", bangTheoDoi.NgayLapBang));
                Command.Parameters.Add(new MDB.MDBParameter("CanNang", bangTheoDoi.CanNang));
                Command.Parameters.Add(new MDB.MDBParameter("ChieuCao", bangTheoDoi.ChieuCao));
                Command.Parameters.Add(new MDB.MDBParameter("ChanDoan", bangTheoDoi.ChanDoan));
                Command.Parameters.Add(new MDB.MDBParameter("SC", bangTheoDoi.SC));
                Command.Parameters.Add(new MDB.MDBParameter("LuuLuongToiThieu", bangTheoDoi.LuuLuongToiThieu));
                Command.Parameters.Add(new MDB.MDBParameter("ToiDa", bangTheoDoi.ToiDa));
                Command.Parameters.Add(new MDB.MDBParameter("KipPTV", JsonConvert.SerializeObject(bangTheoDoi.KipPTV)));
                Command.Parameters.Add(new MDB.MDBParameter("KipGM", JsonConvert.SerializeObject(bangTheoDoi.KipGM)));
                Command.Parameters.Add(new MDB.MDBParameter("KipCEC", JsonConvert.SerializeObject(bangTheoDoi.KipCEC)));
                Command.Parameters.Add(new MDB.MDBParameter("VatLieu", JsonConvert.SerializeObject(bangTheoDoi.VatLieu)));
                Command.Parameters.Add(new MDB.MDBParameter("DanMach", JsonConvert.SerializeObject(bangTheoDoi.DanMach)));
                Command.Parameters.Add(new MDB.MDBParameter("CoMach", JsonConvert.SerializeObject(bangTheoDoi.CoMach)));
                Command.Parameters.Add(new MDB.MDBParameter("Heparine", JsonConvert.SerializeObject(bangTheoDoi.Heparine)));
                Command.Parameters.Add(new MDB.MDBParameter("Khac", JsonConvert.SerializeObject(bangTheoDoi.Khac)));
                Command.Parameters.Add(new MDB.MDBParameter("XetNghiem", JsonConvert.SerializeObject(bangTheoDoi.XetNghiem)));
                Command.Parameters.Add(new MDB.MDBParameter("Primings", JsonConvert.SerializeObject(bangTheoDoi.Primings)));
                Command.Parameters.Add(new MDB.MDBParameter("KhiMaus", JsonConvert.SerializeObject(bangTheoDoi.KhiMaus)));

                string jsonChiSos = JsonConvert.SerializeObject(bangTheoDoi.ChiSos);
                List<string>  listJson = new List<string>();
                for (int i = 0; i < jsonChiSos.Length; i += 3999)
                {
                    if ((i + 3999) < jsonChiSos.Length)
                        listJson.Add(jsonChiSos.Substring(i, 3999));
                    else
                        listJson.Add(jsonChiSos.Substring(i));
                }
                Command.Parameters.Add(new MDB.MDBParameter("ChiSos_1", listJson[0]));
                Command.Parameters.Add(new MDB.MDBParameter("ChiSos_2", listJson.Count > 1 ? listJson[1] : null));

                Command.Parameters.Add(new MDB.MDBParameter("CECHoTro", bangTheoDoi.CECHoTro));
                Command.Parameters.Add(new MDB.MDBParameter("ThoiGianChayMay", bangTheoDoi.ThoiGianChayMay));
                Command.Parameters.Add(new MDB.MDBParameter("ThoiGianCapDMC", bangTheoDoi.ThoiGianCapDMC));
                Command.Parameters.Add(new MDB.MDBParameter("No1", JsonConvert.SerializeObject(bangTheoDoi.No1)));
                Command.Parameters.Add(new MDB.MDBParameter("No2", JsonConvert.SerializeObject(bangTheoDoi.No2)));
                Command.Parameters.Add(new MDB.MDBParameter("No3", JsonConvert.SerializeObject(bangTheoDoi.No3)));
                Command.Parameters.Add(new MDB.MDBParameter("No4", JsonConvert.SerializeObject(bangTheoDoi.No4)));
                Command.Parameters.Add(new MDB.MDBParameter("No5", JsonConvert.SerializeObject(bangTheoDoi.No5)));

                Command.Parameters.Add(new MDB.MDBParameter("TheoDoi", JsonConvert.SerializeObject(bangTheoDoi.TheoDoi)));
                Command.Parameters.Add(new MDB.MDBParameter("Bilan", JsonConvert.SerializeObject(bangTheoDoi.Bilan)));

                Command.Parameters.Add(new MDB.MDBParameter("NGUOISUA", bangTheoDoi.NguoiSua));
                Command.Parameters.Add(new MDB.MDBParameter("NGAYSUA", bangTheoDoi.NgaySua));
                if (bangTheoDoi.ID == 0)
                {
                    Command.Parameters.Add(new MDB.MDBParameter("ID", bangTheoDoi.ID));
                    Command.Parameters.Add(new MDB.MDBParameter("NGUOITAO", bangTheoDoi.NguoiTao));
                    Command.Parameters.Add(new MDB.MDBParameter("NGAYTAO", bangTheoDoi.NgayTao));
                }
                Command.BindByName = true;
                int n = Command.ExecuteNonQuery();
                if (bangTheoDoi.ID == 0)
                {
                    long nextval = Convert.ToInt64((Command.Parameters["ID"] as MDB.MDBParameter).Value);
                    bangTheoDoi.ID = nextval;
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
                string sql = "DELETE FROM BangTheoDoiCEC WHERE ID = :ID";
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
                B.NgayLapBang,
                B.CanNang,
                B.ChieuCao,
                B.ChanDoan,
                B.SC,
                B.LuuLuongToiThieu,
                B.ToiDa,
                B.CECHoTro,
                B.ThoiGianChayMay,
                B.ThoiGianCapDMC,
                H.TENBENHNHAN,
                H.SOYTE,
                H.BENHVIEN,
                T.KHOA
            FROM
                BangTheoDoiCEC B
                LEFT JOIN HANHCHINHBENHNHAN H ON B.MABENHNHAN = H.MABENHNHAN
                LEFT JOIN THONGTINDIEUTRI T ON B.MAQUANLY = T.MAQUANLY
            WHERE
                ID = " + id;

            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
            MDB.MDBDataAdapter adt = new MDB.MDBDataAdapter(Command);
            var ds = new DataSet();

            adt.Fill(ds, "BTD");

            sql = @"SELECT
                B.KipPTV, B.KipGM, B.KipCEC, B.VatLieu, B.DanMach, B.CoMach, B.Heparine, B.Khac, B.XetNghiem,
                B.No1, B.No2, B.No3, B.No4, B.No5, B.TheoDoi, B.Bilan 
                
            FROM
                BangTheoDoiCEC B
                
            WHERE
                ID = " + id;
            
            Command = new MDB.MDBCommand(sql, MyConnection);
            MDB.MDBDataReader DataReader = Command.ExecuteReader();

            ObservableCollection<NhanVien> kipPTV = new ObservableCollection<NhanVien>();
            ObservableCollection<NhanVien> kipGM = new ObservableCollection<NhanVien>();
            ObservableCollection<NhanVien> kipCEC = new ObservableCollection<NhanVien>();

            VatLieuCEC vatLieu = new VatLieuCEC();
            LieuThuocCEC danMach = new LieuThuocCEC();
            LieuThuocCEC coMach = new LieuThuocCEC();
            LieuThuocCEC heparine = new LieuThuocCEC();
            LieuThuocCEC khac = new LieuThuocCEC();
            XetNghiemCEC xetNghiem = new XetNghiemCEC();

            DungDichLietTim no1 = new DungDichLietTim();
            DungDichLietTim no2 = new DungDichLietTim();
            DungDichLietTim no3 = new DungDichLietTim();
            DungDichLietTim no4 = new DungDichLietTim();
            DungDichLietTim no5 = new DungDichLietTim();
            TheoDoiCEC theoDoi = new TheoDoiCEC();
            BilanCEC bilan = new BilanCEC();

            ds.Tables[0].AddColumn("KipPTV", typeof(string));
            ds.Tables[0].AddColumn("KipGM", typeof(string));
            ds.Tables[0].AddColumn("KipCEC", typeof(string));

            while (DataReader.Read())
            {
                kipPTV = JsonConvert.DeserializeObject<ObservableCollection<NhanVien>>(DataReader["KipPTV"].ToString());
                kipGM = JsonConvert.DeserializeObject<ObservableCollection<NhanVien>>(DataReader["KipGM"].ToString());
                kipCEC = JsonConvert.DeserializeObject<ObservableCollection<NhanVien>>(DataReader["KipCEC"].ToString());

                vatLieu = JsonConvert.DeserializeObject<VatLieuCEC>(DataReader["VatLieu"].ToString());
                danMach = JsonConvert.DeserializeObject<LieuThuocCEC>(DataReader["DanMach"].ToString());
                coMach = JsonConvert.DeserializeObject<LieuThuocCEC>(DataReader["CoMach"].ToString());
                heparine = JsonConvert.DeserializeObject<LieuThuocCEC>(DataReader["Heparine"].ToString());
                khac = JsonConvert.DeserializeObject<LieuThuocCEC>(DataReader["Khac"].ToString());
                xetNghiem = JsonConvert.DeserializeObject<XetNghiemCEC>(DataReader["XetNghiem"].ToString());

                no1 = JsonConvert.DeserializeObject<DungDichLietTim>(DataReader["No1"].ToString());
                no2 = JsonConvert.DeserializeObject<DungDichLietTim>(DataReader["No2"].ToString());
                no3 = JsonConvert.DeserializeObject<DungDichLietTim>(DataReader["No3"].ToString());
                no4 = JsonConvert.DeserializeObject<DungDichLietTim>(DataReader["No4"].ToString());
                no5 = JsonConvert.DeserializeObject<DungDichLietTim>(DataReader["No5"].ToString());

                theoDoi = JsonConvert.DeserializeObject<TheoDoiCEC>(DataReader["TheoDoi"].ToString());
                bilan = JsonConvert.DeserializeObject<BilanCEC>(DataReader["Bilan"].ToString());

                break;
            }
            string kipPTV_String = "";
            for(int i = 0; i < kipPTV.Count; i++)
            {
                if (i == 0)
                    kipPTV_String += kipPTV[0].HoVaTen;
                else
                    kipPTV_String += " - " + kipPTV[0].HoVaTen;
            }
            string kipGM_String = "";
            for (int i = 0; i < kipGM.Count; i++)
            {
                if (i == 0)
                    kipGM_String += kipGM[0].HoVaTen;
                else
                    kipGM_String += " - " + kipGM[0].HoVaTen;
            }
            string kipCEC_String = "";
            for (int i = 0; i < kipCEC.Count; i++)
            {
                if (i == 0)
                    kipCEC_String += kipCEC[0].HoVaTen;
                else
                    kipCEC_String += " - " + kipCEC[0].HoVaTen;
            }
            ds.Tables[0].Rows[0]["KipPTV"] = kipPTV_String;
            ds.Tables[0].Rows[0]["KipGM"] = kipGM_String;
            ds.Tables[0].Rows[0]["KipCEC"] = kipCEC_String;
            
            DataTable VL = new DataTable("VL");
            VL.Columns.Add("Montage");
            VL.Columns.Add("OxyGenateur");
            VL.Columns.Add("Resseervoir");
            VL.Columns.Add("Hemofiltre");
            VL.Columns.Add("CPG");
            VL.Columns.Add("CanuleAor");
            VL.Columns.Add("CanuleVein");

            VL.Rows.Add(vatLieu.Montage, vatLieu.OxyGenateur, vatLieu.Resseervoir, vatLieu.Hemofiltre, vatLieu.CPG,
                vatLieu.CanuleAor, vatLieu.CanuleVein);
            ds.Tables.Add(VL);

            DataTable TLT1 = new DataTable("TLT1");
            TLT1.Columns.Add("Ten");
            TLT1.Columns.Add("SoLuong");
            TLT1.Columns.Add("DonVi");

            TLT1.Rows.Add(danMach.Ten, danMach.SoLuong, danMach.DonVi);
            ds.Tables.Add(TLT1);

            DataTable TLT2 = new DataTable("TLT2");
            TLT2.Columns.Add("Ten");
            TLT2.Columns.Add("SoLuong");
            TLT2.Columns.Add("DonVi");

            TLT2.Rows.Add(coMach.Ten, coMach.SoLuong, coMach.DonVi);
            ds.Tables.Add(TLT2);

            DataTable TLT3 = new DataTable("TLT3");
            TLT3.Columns.Add("Ten");
            TLT3.Columns.Add("SoLuong");
            TLT3.Columns.Add("DonVi");

            TLT3.Rows.Add(heparine.Ten, heparine.SoLuong, heparine.DonVi);
            ds.Tables.Add(TLT3);

            DataTable TLT4 = new DataTable("TLT4");
            TLT4.Columns.Add("Ten");
            TLT4.Columns.Add("SoLuong");
            TLT4.Columns.Add("DonVi");

            TLT4.Rows.Add(khac.Ten, khac.SoLuong, khac.DonVi);
            ds.Tables.Add(TLT4);

            DataTable XN = new DataTable("XN");
            XN.Columns.Add("GS");
            XN.Columns.Add("FE");
            XN.Columns.Add("Rct");
            XN.Columns.Add("HctPreop");
            XN.Columns.Add("TP");
            XN.Columns.Add("Fig");
            XN.Columns.Add("Protidemie");
            XN.Rows.Add(xetNghiem.GS, xetNghiem.FE, xetNghiem.Rct, xetNghiem.HctPreop, xetNghiem.TP, xetNghiem.Fig, xetNghiem.Protidemie);
            ds.Tables.Add(XN);
           
            DataTable N1 = new DataTable("N1");
            N1.Columns.Add("No");
            N1.Columns.Add("XD_Aig");
            N1.Columns.Add("XD_A");
            N1.Columns.Add("XD_Coron");
            N1.Columns.Add("ND");
            N1.Columns.Add("Mau");
            N1.Columns.Add("DT_Tot");
            N1.Columns.Add("DT_Xau");

            N1.Rows.Add(no1.No, no1.XD_Aig ? 1:0, no1.XD_A ? 1 : 0, no1.XD_Coron ? 1 : 0, no1.ND ? 1 : 0, no1.Mau ? 1 : 0, no1.DT_Tot ? 1 : 0, no1.DT_Xau ? 1 : 0);
            ds.Tables.Add(N1);

            DataTable N2 = new DataTable("N2");
            N2.Columns.Add("No");
            N2.Columns.Add("XD_Aig");
            N2.Columns.Add("XD_A");
            N2.Columns.Add("XD_Coron");
            N2.Columns.Add("ND");
            N2.Columns.Add("Mau");
            N2.Columns.Add("DT_Tot");
            N2.Columns.Add("DT_Xau");

            N2.Rows.Add(no2.No, no2.XD_Aig ? 1 : 0, no2.XD_A ? 1 : 0, no2.XD_Coron ? 1 : 0, no2.ND ? 1 : 0, no2.Mau ? 1 : 0, no2.DT_Tot ? 1 : 0, no2.DT_Xau ? 1 : 0);
            ds.Tables.Add(N2);

            DataTable N3 = new DataTable("N3");
            N3.Columns.Add("No");
            N3.Columns.Add("XD_Aig");
            N3.Columns.Add("XD_A");
            N3.Columns.Add("XD_Coron");
            N3.Columns.Add("ND");
            N3.Columns.Add("Mau");
            N3.Columns.Add("DT_Tot");
            N3.Columns.Add("DT_Xau");

            N3.Rows.Add(no3.No, no3.XD_Aig ? 1 : 0, no3.XD_A ? 1 : 0, no3.XD_Coron ? 1 : 0, no3.ND ? 1 : 0, no3.Mau ? 1 : 0, no3.DT_Tot ? 1 : 0, no3.DT_Xau ? 1 : 0);
            ds.Tables.Add(N3);

            DataTable N4 = new DataTable("N4");
            N4.Columns.Add("No");
            N4.Columns.Add("XD_Aig");
            N4.Columns.Add("XD_A");
            N4.Columns.Add("XD_Coron");
            N4.Columns.Add("ND");
            N4.Columns.Add("Mau");
            N4.Columns.Add("DT_Tot");
            N4.Columns.Add("DT_Xau");

            N4.Rows.Add(no4.No, no4.XD_Aig ? 1 : 0, no4.XD_A ? 1 : 0, no4.XD_Coron ? 1 : 0, no4.ND ? 1 : 0, no4.Mau ? 1 : 0, no4.DT_Tot ? 1 : 0, no4.DT_Xau ? 1 : 0);
            ds.Tables.Add(N4);
            DataTable N5 = new DataTable("N5");
            N5.Columns.Add("No");
            N5.Columns.Add("XD_Aig");
            N5.Columns.Add("XD_A");
            N5.Columns.Add("XD_Coron");
            N5.Columns.Add("ND");
            N5.Columns.Add("Mau");
            N5.Columns.Add("DT_Tot");
            N5.Columns.Add("DT_Xau");

            N5.Rows.Add(no5.No, no5.XD_Aig ? 1 : 0, no5.XD_A ? 1 : 0, no5.XD_Coron ? 1 : 0, no5.ND ? 1 : 0, no5.Mau ? 1 : 0, no5.DT_Tot ? 1 : 0, no5.DT_Xau ? 1 : 0);
            ds.Tables.Add(N5);

            DataTable TD = new DataTable("TD");
            TD.Columns.Add("CEC_NhietDo");
            TD.Columns.Add("CEC_HaNhietDo");
            TD.Columns.Add("CEC_TimRun");
            TD.Columns.Add("CEC_TimDap");
            TD.Columns.Add("NgungTuanHoan");
            TD.Columns.Add("TimTuDap");
            TD.Columns.Add("ChongRung");
            TD.Columns.Add("TaiNan");

            TD.Rows.Add(theoDoi.CEC_NhietDo, theoDoi.CEC_HaNhietDo, theoDoi.CEC_TimRun, 
                theoDoi.CEC_TimDap, theoDoi.NgungTuanHoan, theoDoi.TimTuDap, theoDoi.ChongRung, theoDoi.TaiNan);
            ds.Tables.Add(TD);

            DataTable Bilan = new DataTable("BILAN");
            Bilan.Columns.Add("DichVao");
            Bilan.Columns.Add("Oxygennatem_Vao");
            Bilan.Columns.Add("DichDoVao");
            Bilan.Columns.Add("Cardioplrgie");
            Bilan.Columns.Add("Bu");
            Bilan.Columns.Add("TongCongVao");
            Bilan.Columns.Add("DichRa");
            Bilan.Columns.Add("Oxygennatem_Ra");
            Bilan.Columns.Add("MayHut");
            Bilan.Columns.Add("NuocTieu");
            Bilan.Columns.Add("DichLoc");
            Bilan.Columns.Add("TongCongRa");

            Bilan.Rows.Add(bilan.DichVao,
                            bilan.Oxygennatem_Vao,
                            bilan.DichDoVao,
                            bilan.Cardioplrgie,
                            bilan.Bu,
                            bilan.TongCongVao,
                            bilan.DichRa,
                            bilan.Oxygennatem_Ra,
                            bilan.MayHut,
                            bilan.NuocTieu,
                            bilan.DichLoc,
                            bilan.TongCongRa);
            ds.Tables.Add(Bilan);
            return ds;
        }
    }
}
