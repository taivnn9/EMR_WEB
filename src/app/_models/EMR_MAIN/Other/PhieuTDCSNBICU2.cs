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

    public class DSSonDe
    {
        public string Ma { get; set; }
        public string Ten { get; set; }
        public DSSonDe()
        {
            Ma = string.Empty;
            Ten = string.Empty;
        }
    }
    public class DSSonDe_CT: DSSonDe
    {
        public int? ID { get; set; }
        public DateTime TGStart { get; set; }
        public DateTime TGEnd { get; set; }
        public string ViTri { get; set; }
    }
    public class ThongTinDichTruyen2: DSDichTruyen2
    {
        [MoTaDuLieu("Mã định danh")]
		public int ID { get; set; } 
        public double? TheTich { get; set; }  
        public int? Gio { get; set; }
        public string GioDis { get; set; }
        [MoTaDuLieu("Ghi chú")]
		public string GhiChu { get; set; }
        public string TenTocDo
        {
            get
            {
                if (DonVi == 1)
                {
                    return (Common.ConDBNull(TocDo) + "giọt/phút");
                }
                else if (DonVi == 2)
                {
                    return (Common.ConDBNull(TocDo) + "ml/giờ");
                } else
                {
                    return (Common.ConDBNull(TocDo) + "ml/phút");
                }
            }
        }
        public ThongTinDichTruyen2()
        {
            MaDT = string.Empty;
            TenDT = string.Empty;
        }
    }
    
    public class DSDichTruyen2
    {
        public string MaDT { get; set; }
        public string TenDT { get; set; }
        public string SL { get; set; }
        public double? TocDo { get; set; }
        public int? DonVi { get; set; }
        public double? TyLe { get; set; }
        public bool  IsMau{ get; set; }
        public string TenDonVi
        {
            get
            {
                if(DonVi==1)
                {
                    return "giọt/phút";
                }
                else if (DonVi == 2)
                {
                    return "ml/giờ";
                }
                else
                {
                    return "ml/phút";
                }
            }
        }
        public string TenDVTT
        {
            get
            {
                    return "ml";
            }
        }
        public DSDichTruyen2()
        {
            MaDT = string.Empty;
            TenDT = string.Empty;
        }
    }
    public class ThongTinTheoDoiGio2
    {
        [MoTaDuLieu("Mã định danh")]
		public decimal ID;
        [MoTaDuLieu("Mã định danh")]
		public decimal ID_Phieu { get; set; }
        public int CaThu { get; set; }
        public int Gio { get; set; }
        public DateTime ThoiGian { get; set; }
        public double? HAMax { get; set; }
        public double? HAMin { get; set; }
        public double? T { get; set; }
        public double? M { get; set; }
        public string OX { get; set; }
        [MoTaDuLieu("Nhịp tim")]
		public string NT { get; set; }
        public string Mod { get; set; }
        public string Fi { get; set; }
        public string TV { get; set; }
        public string RR { get; set; }
        public string ALBD { get; set; }
        public string HD { get; set; }
        [MoTaDuLieu("Nồng độ Oxy trong máu")]
		public string SpO2 { get; set; }
        public string CVP { get; set; }
        public string CA { get; set; }
        public string NTieu { get; set; }
        public string DXK { get; set; }
        public string CBN { get; set; }
        public string SDVT1 { get; set; }
        public string SDVT2 { get; set; }
        public string ND { get; set; }
        public string BC { get; set; }
        public string L { get; set; }
        public string LVT { get; set; }
        public string PNL { get; set; }
        public string GMM { get; set; }
        public string GDULN { get; set; }
        public string GDUVD { get; set; }
        public string GTong { get; set; }
        public string DTT { get; set; }
        public string DTP { get; set; }
        public string YL { get; set; }
        public string CSDD { get; set; }
        public string CLS { get; set; }
        public ThongTinTheoDoiGio2 Clone()
        {
            ThongTinTheoDoiGio2 other = (ThongTinTheoDoiGio2)this.MemberwiseClone();
            return other;
        }
    }
    
    public class PhieuTDCSNBICU2 : ThongTinKy
    {
        public PhieuTDCSNBICU2()
        {
            TableName = "PhieuTDCSNBICU";
            TablePrimaryKeyName = "ID";
            IDMauPhieu = (int)DanhMucPhieu.PTDCSNBICU;
            TenMauPhieu = DanhMucPhieu.PTDCSNBICU.Description();
            ThongTinGio_Ca1 = new ObservableCollection<ThongTinTheoDoiGio2>();
            ThongTinGio_Ca2 = new ObservableCollection<ThongTinTheoDoiGio2>();
            ThongTinGio_Ca3 = new ObservableCollection<ThongTinTheoDoiGio2>();
            DsDichTruyen = new ObservableCollection<DSDichTruyen2>();
            ttDichTruyen_Ca1 = new ObservableCollection<ThongTinDichTruyen2>();
            ttDichTruyen_Ca2 = new ObservableCollection<ThongTinDichTruyen2>();
            ttDichTruyen_Ca3 = new ObservableCollection<ThongTinDichTruyen2>();
            DsSonDe = new ObservableCollection<DSSonDe>();
            ttSonDe_Ca1 = new ObservableCollection<DSSonDe_CT>();
            ttSonDe_Ca2 = new ObservableCollection<DSSonDe_CT>();
            ttSonDe_Ca3 = new ObservableCollection<DSSonDe_CT>();
            ttThuocTiem = new ObservableCollection<ThongTinThocTiem>();
            ttThuocTiem_Ca1 = new ObservableCollection<ThongTinThocTiem>();
            ttThuocTiem_Ca2 = new ObservableCollection<ThongTinThocTiem>();
            ttThuocTiem_Ca3 = new ObservableCollection<ThongTinThocTiem>();
            ttThuocKhac = new ObservableCollection<ThongTinThocKhac>();
            ttThuocKhac_Ca1 = new ObservableCollection<ThongTinThocKhac>();
            ttThuocKhac_Ca2 = new ObservableCollection<ThongTinThocKhac>();
            ttThuocKhac_Ca3 = new ObservableCollection<ThongTinThocKhac>();
            ttTheoDoi = new ObservableCollection<TheoDoiGhiChuDieuDuong>();
            ttTheoDoi_Ca1 = new ObservableCollection<TheoDoiGhiChuDieuDuong>();
            ttTheoDoi_Ca2 = new ObservableCollection<TheoDoiGhiChuDieuDuong>();
            ttTheoDoi_Ca3 = new ObservableCollection<TheoDoiGhiChuDieuDuong>();

        }
        [MoTaDuLieu("Mã định danh")]
		public decimal ID { get; set; }
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
        public int? NgayDieuTriThu { get; set; }
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
        public string PNLKhac { get; set; }
        public string CLSkhac { get; set; }
        public string SD1 { get; set; }
        public string SD2 { get; set; }
        public DateTime NgayThucHien { get; set; }
        public ObservableCollection<ThongTinTheoDoiGio2> ThongTinGio_Ca1 { get; set; }
        public ObservableCollection<ThongTinTheoDoiGio2> ThongTinGio_Ca2 { get; set; }
        public ObservableCollection<ThongTinTheoDoiGio2> ThongTinGio_Ca3 { get; set; }
        public ObservableCollection<DSDichTruyen2> DsDichTruyen { get; set; }
        public ObservableCollection<DSSonDe> DsSonDe { get; set; }
        public ObservableCollection<ThongTinDichTruyen2> ttDichTruyen_Ca1 { get; set; }
        public ObservableCollection<ThongTinDichTruyen2> ttDichTruyen_Ca2 { get; set; }
        public ObservableCollection<ThongTinDichTruyen2> ttDichTruyen_Ca3 { get; set; }
        public ObservableCollection<DSSonDe_CT> ttSonDe_Ca1 { get; set; }
        public ObservableCollection<DSSonDe_CT> ttSonDe_Ca2 { get; set; }
        public ObservableCollection<DSSonDe_CT> ttSonDe_Ca3 { get; set; }
        public ObservableCollection<ThongTinThocTiem> ttThuocTiem { get; set; }
        public ObservableCollection<ThongTinThocTiem> ttThuocTiem_Ca1 { get; set; }
        public ObservableCollection<ThongTinThocTiem> ttThuocTiem_Ca2 { get; set; }
        public ObservableCollection<ThongTinThocTiem> ttThuocTiem_Ca3 { get; set; }
        public ObservableCollection<ThongTinThocKhac> ttThuocKhac { get; set; }
        public ObservableCollection<ThongTinThocKhac> ttThuocKhac_Ca1 { get; set; }
        public ObservableCollection<ThongTinThocKhac> ttThuocKhac_Ca2 { get; set; }
        public ObservableCollection<ThongTinThocKhac> ttThuocKhac_Ca3 { get; set; }
        public ObservableCollection<TheoDoiGhiChuDieuDuong> ttTheoDoi { get; set; }
        public ObservableCollection<TheoDoiGhiChuDieuDuong> ttTheoDoi_Ca1 { get; set; }
        public ObservableCollection<TheoDoiGhiChuDieuDuong> ttTheoDoi_Ca2 { get; set; }
        public ObservableCollection<TheoDoiGhiChuDieuDuong> ttTheoDoi_Ca3 { get; set; }
        public string MaNguoiTao_Ca1 { get; set; }
        public string TenNguoiTao_Ca1 { get; set; }
        public string MaNguoiTao_Ca2 { get; set; }
        public string TenNguoiTao_Ca2 { get; set; }
        public string MaNguoiTao_Ca3 { get; set; }
        public string TenNguoiTao_Ca3 { get; set; }
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
    public class PhieuTDCSNBICU2Func
    {
        public const string TableName = "PhieuTDCSNBICU";
        public const string TablePrimaryKeyName = "ID";
        public static PhieuTDCSNBICU2 GetData(MDB.MDBConnection _OracleConnection, decimal maquanly , decimal ID)
        {
            PhieuTDCSNBICU2 data = new PhieuTDCSNBICU2();
            try
            {
                string sql = @"SELECT *
                FROM PhieuTDCSNBICU 
                where ID =:ID And MaQuanLy = :MaQuanLy";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, _OracleConnection);
                Command.Parameters.Add(new MDB.MDBParameter("ID", ID));
                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", maquanly));
                MDB.MDBDataReader DataReader = Command.ExecuteReader();
                while (DataReader.Read())
                {
                    PhieuTDCSNBICU2 obj = new PhieuTDCSNBICU2();
                    obj.ID = Common.ConDB_Decimal(DataReader["ID"]);
                    obj.MaQuanLy = Common.ConDB_Decimal(DataReader["MaQuanLy"]);
                    obj.MaBenhNhan = Common.ConDBNull(DataReader["MaBenhNhan"]);
                    obj.TenBenhNhan = Common.ConDBNull(DataReader["TenBenhNhan"]);
                    obj.Tuoi = Common.ConDBNull(DataReader["Tuoi"]);
                    obj.GioiTinh = Common.ConDBNull(DataReader["GioiTinh"]);
                    obj.SoBenhAn = Common.ConDBNull(DataReader["SoBenhAn"]);
                    obj.Khoa = Common.ConDBNull(DataReader["Khoa"]);
                    obj.MaKhoa = Common.ConDBNull(DataReader["MaKhoa"]);
                    obj.NgayDieuTriThu = Common.ConDB_IntNull(DataReader["NgayDieuTriThu"]);
                    obj.Giuong = Common.ConDBNull(DataReader["Giuong"]);
                    obj.ChanDoan = Common.ConDBNull(DataReader["ChanDoan"]);
                    obj.BacSyDieuTri = Common.ConDBNull(DataReader["BacSyDieuTri"]);
                    obj.MaBacSyDieuTri = Common.ConDBNull(DataReader["MaBacSyDieuTri"]);
                    obj.DieuDuongCa1 = Common.ConDBNull(DataReader["DieuDuongCa1"]);
                    obj.MaDieuDuongCa1 = Common.ConDBNull(DataReader["MaDieuDuongCa1"]);
                    obj.DieuDuongCa2 = Common.ConDBNull(DataReader["DieuDuongCa2"]);
                    obj.MaDieuDuongCa2 = Common.ConDBNull(DataReader["MaDieuDuongCa2"]);
                    obj.DieuDuongCa3 = Common.ConDBNull(DataReader["DieuDuongCa3"]);
                    obj.MaDieuDuongCa3 = Common.ConDBNull(DataReader["MaDieuDuongCa3"]);
                    obj.PNLKhac = Common.ConDBNull(DataReader["PNLKhac"]);
                    obj.CLSkhac = Common.ConDBNull(DataReader["CLSkhac"]);
                    obj.SD1 = Common.ConDBNull(DataReader["SD1"]);
                    obj.SD2 = Common.ConDBNull(DataReader["SD2"]);
                    obj.NgayThucHien = Common.ConDB_DateTime(DataReader["NgayThucHien"]);
                    obj.DsDichTruyen = JsonConvert.DeserializeObject < ObservableCollection <DSDichTruyen2>>(Common.ConDBNull(DataReader["DsDichTruyen"])) ?? new ObservableCollection<DSDichTruyen2>();
                    obj.ttDichTruyen_Ca1 = JsonConvert.DeserializeObject < ObservableCollection <ThongTinDichTruyen2>> (Common.ConDBNull(DataReader["ttDichTruyen_Ca1"])) ?? new ObservableCollection<ThongTinDichTruyen2>();
                    obj.ttDichTruyen_Ca2 = JsonConvert.DeserializeObject<ObservableCollection<ThongTinDichTruyen2>>(Common.ConDBNull(DataReader["ttDichTruyen_Ca2"])) ?? new ObservableCollection<ThongTinDichTruyen2>();
                    obj.ttDichTruyen_Ca3 = JsonConvert.DeserializeObject<ObservableCollection<ThongTinDichTruyen2>>(Common.ConDBNull(DataReader["ttDichTruyen_Ca3"])) ?? new ObservableCollection<ThongTinDichTruyen2>();
                    obj.DsSonDe = JsonConvert.DeserializeObject<ObservableCollection<DSSonDe>>(Common.ConDBNull(DataReader["DsSonDe"])) ?? new ObservableCollection<DSSonDe>();
                    obj.ttSonDe_Ca1 = JsonConvert.DeserializeObject<ObservableCollection<DSSonDe_CT>>(Common.ConDBNull(DataReader["ttSonDe_Ca1"])) ?? new ObservableCollection<DSSonDe_CT>();
                    obj.ttSonDe_Ca2 = JsonConvert.DeserializeObject<ObservableCollection<DSSonDe_CT>>(Common.ConDBNull(DataReader["ttSonDe_Ca2"])) ?? new ObservableCollection<DSSonDe_CT>();
                    obj.ttSonDe_Ca3 = JsonConvert.DeserializeObject<ObservableCollection<DSSonDe_CT>>(Common.ConDBNull(DataReader["ttSonDe_Ca3"])) ?? new ObservableCollection<DSSonDe_CT>();
                    obj.ttThuocTiem = JsonConvert.DeserializeObject<ObservableCollection<ThongTinThocTiem>>(Common.ConDBNull(DataReader["ttThuocTiem"])) ?? new ObservableCollection<ThongTinThocTiem>();
                    obj.ttThuocTiem_Ca1 = JsonConvert.DeserializeObject<ObservableCollection<ThongTinThocTiem>>(Common.ConDBNull(DataReader["ttThuocTiem_Ca1"])) ?? new ObservableCollection<ThongTinThocTiem>();
                    obj.ttThuocTiem_Ca2 = JsonConvert.DeserializeObject<ObservableCollection<ThongTinThocTiem>>(Common.ConDBNull(DataReader["ttThuocTiem_Ca2"])) ?? new ObservableCollection<ThongTinThocTiem>();
                    obj.ttThuocTiem_Ca3 = JsonConvert.DeserializeObject<ObservableCollection<ThongTinThocTiem>>(Common.ConDBNull(DataReader["ttThuocTiem_Ca3"])) ?? new ObservableCollection<ThongTinThocTiem>();
                    obj.ttThuocKhac = JsonConvert.DeserializeObject<ObservableCollection<ThongTinThocKhac>>(Common.ConDBNull(DataReader["ttThuocKhac"])) ?? new ObservableCollection<ThongTinThocKhac>();
                    obj.ttThuocKhac_Ca1 = JsonConvert.DeserializeObject<ObservableCollection<ThongTinThocKhac>>(Common.ConDBNull(DataReader["ttThuocKhac_Ca1"])) ?? new ObservableCollection<ThongTinThocKhac>();
                    obj.ttThuocKhac_Ca2 = JsonConvert.DeserializeObject<ObservableCollection<ThongTinThocKhac>>(Common.ConDBNull(DataReader["ttThuocKhac_Ca2"])) ?? new ObservableCollection<ThongTinThocKhac>();
                    obj.ttThuocKhac_Ca3 = JsonConvert.DeserializeObject<ObservableCollection<ThongTinThocKhac>>(Common.ConDBNull(DataReader["ttThuocKhac_Ca3"])) ?? new ObservableCollection<ThongTinThocKhac>();
                    obj.ttTheoDoi = JsonConvert.DeserializeObject<ObservableCollection<TheoDoiGhiChuDieuDuong>>(Common.ConDBNull(DataReader["ttTheoDoi"])) ?? new ObservableCollection<TheoDoiGhiChuDieuDuong>();
                    obj.ttTheoDoi_Ca1 = JsonConvert.DeserializeObject<ObservableCollection<TheoDoiGhiChuDieuDuong>>(Common.ConDBNull(DataReader["ttTheoDoi_Ca1"])) ?? new ObservableCollection<TheoDoiGhiChuDieuDuong>();
                    obj.ttTheoDoi_Ca2 = JsonConvert.DeserializeObject<ObservableCollection<TheoDoiGhiChuDieuDuong>>(Common.ConDBNull(DataReader["ttTheoDoi_Ca2"])) ?? new ObservableCollection<TheoDoiGhiChuDieuDuong>();
                    obj.ttTheoDoi_Ca3 = JsonConvert.DeserializeObject<ObservableCollection<TheoDoiGhiChuDieuDuong>>(Common.ConDBNull(DataReader["ttTheoDoi_Ca3"])) ?? new ObservableCollection<TheoDoiGhiChuDieuDuong>();
                    obj.MaNguoiTao_Ca1 = Common.ConDBNull(DataReader["MaNguoiTao_Ca1"]);
                    obj.TenNguoiTao_Ca1 = Common.ConDBNull(DataReader["TenNguoiTao_Ca1"]);
                    obj.MaNguoiTao_Ca2 = Common.ConDBNull(DataReader["MaNguoiTao_Ca2"]);
                    obj.TenNguoiTao_Ca2 = Common.ConDBNull(DataReader["TenNguoiTao_Ca2"]);
                    obj.MaNguoiTao_Ca3 = Common.ConDBNull(DataReader["MaNguoiTao_Ca3"]);
                    obj.TenNguoiTao_Ca3 = Common.ConDBNull(DataReader["TenNguoiTao_Ca3"]);
                    obj.NgayTao = Common.ConDB_DateTime(DataReader["NgayTao"]);
                    obj.NguoiTao = Common.ConDBNull(DataReader["NguoiTao"]);
                    obj.NgaySua = Common.ConDB_DateTime(DataReader["NgaySua"]);
                    obj.NguoiSua = Common.ConDBNull(DataReader["NguoiSua"]);
                    obj.ThongTinGio_Ca1 = getThongTinTheoDoiGio(_OracleConnection, obj.ID, 1);
                    obj.ThongTinGio_Ca2 = getThongTinTheoDoiGio(_OracleConnection, obj.ID, 2);
                    obj.ThongTinGio_Ca3 = getThongTinTheoDoiGio(_OracleConnection, obj.ID, 3);
                    obj.NgayKy = Common.ConDB_DateTime(DataReader["ngayky"]);
                    obj.MaSoKy = DataReader["masokyten"].ToString();
                    obj.DaKy = !string.IsNullOrEmpty(obj.MaSoKy) ? true : false;
                    data = obj;
                }
            }
            catch (Exception ex) { throw ex; }
            return data;
        }
        public static List<PhieuTDCSNBICU2> GetListData(MDB.MDBConnection _OracleConnection, decimal maquanly)
        {
            List<PhieuTDCSNBICU2> list = new List<PhieuTDCSNBICU2>();
            try
            {
                string sql = @"SELECT * FROM PhieuTDCSNBICU where MaQuanLy = :MaQuanLy";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, _OracleConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", maquanly));
                MDB.MDBDataReader DataReader = Command.ExecuteReader();
                while (DataReader.Read())
                {
                    PhieuTDCSNBICU2 obj = new PhieuTDCSNBICU2();
                    obj.ID = Common.ConDB_Decimal(DataReader["ID"]);
                    obj.MaQuanLy = Common.ConDB_Decimal(DataReader["MaQuanLy"]);
                    obj.MaBenhNhan = Common.ConDBNull(DataReader["MaBenhNhan"]);
                    obj.TenBenhNhan = Common.ConDBNull(DataReader["TenBenhNhan"]);
                    obj.Tuoi = Common.ConDBNull(DataReader["Tuoi"]);
                    obj.GioiTinh = Common.ConDBNull(DataReader["GioiTinh"]);
                    obj.SoBenhAn = Common.ConDBNull(DataReader["SoBenhAn"]);
                    obj.Khoa = Common.ConDBNull(DataReader["Khoa"]);
                    obj.MaKhoa = Common.ConDBNull(DataReader["MaKhoa"]);
                    obj.NgayDieuTriThu = Common.ConDB_IntNull(DataReader["NgayDieuTriThu"]);
                    obj.Giuong = Common.ConDBNull(DataReader["Giuong"]);
                    obj.ChanDoan = Common.ConDBNull(DataReader["ChanDoan"]);
                    obj.BacSyDieuTri = Common.ConDBNull(DataReader["BacSyDieuTri"]);
                    obj.MaBacSyDieuTri = Common.ConDBNull(DataReader["MaBacSyDieuTri"]);
                    obj.DieuDuongCa1 = Common.ConDBNull(DataReader["DieuDuongCa1"]);
                    obj.MaDieuDuongCa1 = Common.ConDBNull(DataReader["MaDieuDuongCa1"]);
                    obj.DieuDuongCa2 = Common.ConDBNull(DataReader["DieuDuongCa2"]);
                    obj.MaDieuDuongCa2 = Common.ConDBNull(DataReader["MaDieuDuongCa2"]);
                    obj.DieuDuongCa3 = Common.ConDBNull(DataReader["DieuDuongCa3"]);
                    obj.MaDieuDuongCa3 = Common.ConDBNull(DataReader["MaDieuDuongCa3"]);
                    obj.PNLKhac = Common.ConDBNull(DataReader["PNLKhac"]);
                    obj.CLSkhac = Common.ConDBNull(DataReader["CLSkhac"]);
                    obj.CLSkhac = Common.ConDBNull(DataReader["CLSkhac"]);
                    obj.SD1 = Common.ConDBNull(DataReader["SD1"]);
                    obj.SD2 = Common.ConDBNull(DataReader["SD2"]);
                    obj.NgayThucHien = Common.ConDB_DateTime(DataReader["NgayThucHien"]);
                    obj.DsDichTruyen = JsonConvert.DeserializeObject<ObservableCollection<DSDichTruyen2>>(Common.ConDBNull(DataReader["DsDichTruyen"])) ?? new ObservableCollection<DSDichTruyen2>();
                    obj.ttDichTruyen_Ca1 = JsonConvert.DeserializeObject<ObservableCollection<ThongTinDichTruyen2>>(Common.ConDBNull(DataReader["ttDichTruyen_Ca1"])) ?? new ObservableCollection<ThongTinDichTruyen2>();
                    obj.ttDichTruyen_Ca2 = JsonConvert.DeserializeObject<ObservableCollection<ThongTinDichTruyen2>>(Common.ConDBNull(DataReader["ttDichTruyen_Ca2"])) ?? new ObservableCollection<ThongTinDichTruyen2>();
                    obj.ttDichTruyen_Ca3 = JsonConvert.DeserializeObject<ObservableCollection<ThongTinDichTruyen2>>(Common.ConDBNull(DataReader["ttDichTruyen_Ca3"])) ?? new ObservableCollection<ThongTinDichTruyen2>();
                    obj.DsSonDe = JsonConvert.DeserializeObject<ObservableCollection<DSSonDe>>(Common.ConDBNull(DataReader["DsSonDe"])) ?? new ObservableCollection<DSSonDe>();
                    obj.ttSonDe_Ca1 = JsonConvert.DeserializeObject<ObservableCollection<DSSonDe_CT>>(Common.ConDBNull(DataReader["ttSonDe_Ca1"])) ?? new ObservableCollection<DSSonDe_CT>();
                    obj.ttSonDe_Ca2 = JsonConvert.DeserializeObject<ObservableCollection<DSSonDe_CT>>(Common.ConDBNull(DataReader["ttSonDe_Ca2"])) ?? new ObservableCollection<DSSonDe_CT>();
                    obj.ttSonDe_Ca3 = JsonConvert.DeserializeObject<ObservableCollection<DSSonDe_CT>>(Common.ConDBNull(DataReader["ttSonDe_Ca3"])) ?? new ObservableCollection<DSSonDe_CT>();
                    obj.ttThuocTiem = JsonConvert.DeserializeObject<ObservableCollection<ThongTinThocTiem>>(Common.ConDBNull(DataReader["ttThuocTiem"])) ?? new ObservableCollection<ThongTinThocTiem>();
                    obj.ttThuocTiem_Ca1 = JsonConvert.DeserializeObject<ObservableCollection<ThongTinThocTiem>>(Common.ConDBNull(DataReader["ttThuocTiem_Ca1"])) ?? new ObservableCollection<ThongTinThocTiem>();
                    obj.ttThuocTiem_Ca2 = JsonConvert.DeserializeObject<ObservableCollection<ThongTinThocTiem>>(Common.ConDBNull(DataReader["ttThuocTiem_Ca2"])) ?? new ObservableCollection<ThongTinThocTiem>();
                    obj.ttThuocTiem_Ca3 = JsonConvert.DeserializeObject<ObservableCollection<ThongTinThocTiem>>(Common.ConDBNull(DataReader["ttThuocTiem_Ca3"])) ?? new ObservableCollection<ThongTinThocTiem>();
                    obj.ttThuocKhac = JsonConvert.DeserializeObject<ObservableCollection<ThongTinThocKhac>>(Common.ConDBNull(DataReader["ttThuocKhac"])) ?? new ObservableCollection<ThongTinThocKhac>();
                    obj.ttThuocKhac_Ca1 = JsonConvert.DeserializeObject<ObservableCollection<ThongTinThocKhac>>(Common.ConDBNull(DataReader["ttThuocKhac_Ca1"])) ?? new ObservableCollection<ThongTinThocKhac>();
                    obj.ttThuocKhac_Ca2 = JsonConvert.DeserializeObject<ObservableCollection<ThongTinThocKhac>>(Common.ConDBNull(DataReader["ttThuocKhac_Ca2"])) ?? new ObservableCollection<ThongTinThocKhac>();
                    obj.ttThuocKhac_Ca3 = JsonConvert.DeserializeObject<ObservableCollection<ThongTinThocKhac>>(Common.ConDBNull(DataReader["ttThuocKhac_Ca3"])) ?? new ObservableCollection<ThongTinThocKhac>();
                    obj.ttTheoDoi = JsonConvert.DeserializeObject<ObservableCollection<TheoDoiGhiChuDieuDuong>>(Common.ConDBNull(DataReader["ttTheoDoi"])) ?? new ObservableCollection<TheoDoiGhiChuDieuDuong>();
                    obj.ttTheoDoi_Ca1 = JsonConvert.DeserializeObject<ObservableCollection<TheoDoiGhiChuDieuDuong>>(Common.ConDBNull(DataReader["ttTheoDoi_Ca1"]))??new ObservableCollection<TheoDoiGhiChuDieuDuong>();
                    obj.ttTheoDoi_Ca2 = JsonConvert.DeserializeObject<ObservableCollection<TheoDoiGhiChuDieuDuong>>(Common.ConDBNull(DataReader["ttTheoDoi_Ca2"])) ?? new ObservableCollection<TheoDoiGhiChuDieuDuong>();
                    obj.ttTheoDoi_Ca3 = JsonConvert.DeserializeObject<ObservableCollection<TheoDoiGhiChuDieuDuong>>(Common.ConDBNull(DataReader["ttTheoDoi_Ca3"])) ?? new ObservableCollection<TheoDoiGhiChuDieuDuong>();
                    obj.MaNguoiTao_Ca1 = Common.ConDBNull(DataReader["MaNguoiTao_Ca1"]);
                    obj.TenNguoiTao_Ca1 = Common.ConDBNull(DataReader["TenNguoiTao_Ca1"]);
                    obj.MaNguoiTao_Ca2 = Common.ConDBNull(DataReader["MaNguoiTao_Ca2"]);
                    obj.TenNguoiTao_Ca2 = Common.ConDBNull(DataReader["TenNguoiTao_Ca2"]);
                    obj.MaNguoiTao_Ca3 = Common.ConDBNull(DataReader["MaNguoiTao_Ca3"]);
                    obj.TenNguoiTao_Ca3 = Common.ConDBNull(DataReader["TenNguoiTao_Ca3"]);
                    obj.NgayTao = Common.ConDB_DateTime(DataReader["NgayTao"]);
                    obj.NguoiTao = Common.ConDBNull(DataReader["NguoiTao"]);
                    obj.NgaySua = Common.ConDB_DateTime(DataReader["NgaySua"]);
                    obj.NguoiSua = Common.ConDBNull(DataReader["NguoiSua"]);
                    obj.ThongTinGio_Ca1 = getThongTinTheoDoiGio(_OracleConnection, obj.ID, 1);
                    obj.ThongTinGio_Ca2 = getThongTinTheoDoiGio(_OracleConnection, obj.ID, 2);
                    obj.ThongTinGio_Ca3 = getThongTinTheoDoiGio(_OracleConnection, obj.ID, 3);
                    obj.NgayKy = Common.ConDB_DateTime(DataReader["ngayky"]);
                    obj.MaSoKy = DataReader["masokyten"].ToString();
                    obj.DaKy = !string.IsNullOrEmpty(obj.MaSoKy) ? true : false;
                    list.Add(obj);
                }
            }
            catch (Exception ex) { throw ex; }
            return list;
        }
        public static ObservableCollection<ThongTinTheoDoiGio2> getThongTinTheoDoiGio(MDB.MDBConnection _OracleConnection, decimal idPhieu, int caThu)
        {
            ObservableCollection<ThongTinTheoDoiGio2> ThongTinTheoDoiGios = new ObservableCollection<ThongTinTheoDoiGio2>();
            try
            {
                string sql = @"SELECT * FROM PhieuTDCSNBICU_Gio where ID_Phieu = :ID_Phieu and CaThu= :CaThu  ORDER BY ID asc";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, _OracleConnection);
                Command.Parameters.Add(new MDB.MDBParameter("ID_Phieu", idPhieu));
                Command.Parameters.Add(new MDB.MDBParameter("CaThu", caThu));
                MDB.MDBDataReader DataReader = Command.ExecuteReader();
                while (DataReader.Read())
                {
                    ThongTinTheoDoiGio2 obj = new ThongTinTheoDoiGio2();
                    obj.ID = Common.ConDB_Decimal(DataReader["ID"]);
                    obj.ID_Phieu = Common.ConDB_Decimal(DataReader["ID_Phieu"]);
                    obj.CaThu = Common.ConDB_Int(DataReader["CaThu"]);
                    obj.Gio = Common.ConDB_Int(DataReader["Gio"]);
                    obj.HAMax = Common.ConDBNull_double(DataReader["HAMax"]);
                    obj.ThoiGian = Common.ConDB_DateTime(DataReader["ThoiGian"]);
                    obj.HAMin = Common.ConDBNull_double(DataReader["HAMin"]);
                    obj.T = Common.ConDBNull_double(DataReader["T"]);
                    obj.M = Common.ConDBNull_double(DataReader["M"]);
                    obj.OX = Common.ConDBNull(DataReader["OX"]);
                    obj.NT = Common.ConDBNull(DataReader["NT"]);
                    obj.Mod = Common.ConDBNull(DataReader["Mod"]);
                    obj.Fi = Common.ConDBNull(DataReader["Fi"]);
                    obj.TV = Common.ConDBNull(DataReader["TV"]);
                    obj.RR = Common.ConDBNull(DataReader["RR"]);
                    obj.ALBD = Common.ConDBNull(DataReader["ALBD"]);
                    obj.HD = Common.ConDBNull(DataReader["HD"]);
                    obj.SpO2 = Common.ConDBNull(DataReader["SpO2"]);
                    obj.CVP = Common.ConDBNull(DataReader["CVP"]);
                    obj.CA = Common.ConDBNull(DataReader["CA"]);
                    obj.NTieu = Common.ConDBNull(DataReader["NTieu"]);
                    obj.DXK = Common.ConDBNull(DataReader["DXK"]);
                    obj.CBN = Common.ConDBNull(DataReader["CBN"]);
                    obj.SDVT1 = Common.ConDBNull(DataReader["SDVT1"]);
                    obj.SDVT2 = Common.ConDBNull(DataReader["SDVT2"]);
                    obj.ND = Common.ConDBNull(DataReader["ND"]);
                    obj.BC = Common.ConDBNull(DataReader["BC"]);
                    obj.L = Common.ConDBNull(DataReader["L"]);
                    obj.LVT = Common.ConDBNull(DataReader["LVT"]);
                    obj.PNL = Common.ConDBNull(DataReader["PNL"]);
                    obj.GMM = Common.ConDBNull(DataReader["GMM"]);
                    obj.GDULN = Common.ConDBNull(DataReader["GDULN"]);
                    obj.GDUVD = Common.ConDBNull(DataReader["GDUVD"]);
                    obj.GTong = Common.ConDBNull(DataReader["GTong"]);
                    obj.DTT = Common.ConDBNull(DataReader["DTT"]);
                    obj.DTP = Common.ConDBNull(DataReader["DTP"]);
                    obj.YL = Common.ConDBNull(DataReader["YL"]);
                    obj.CSDD = Common.ConDBNull(DataReader["CSDD"]);
                    obj.CLS = Common.ConDBNull(DataReader["CLS"]);
                    ThongTinTheoDoiGios.Add(obj);
                }
            }
            catch (Exception ex) { throw ex; }
            return ThongTinTheoDoiGios;
        }
        public static bool InsertOrUpdatePhieu(MDB.MDBConnection MyConnection, ref PhieuTDCSNBICU2 obj, int CaLV)
        {
            try
            {
                string sql = @"INSERT INTO PhieuTDCSNBICU
                (
                    MaQuanLy,
                    MaBenhNhan,
                    TenBenhNhan,
                    Tuoi,
                    GioiTinh,
                    SoBenhAn,
                    Khoa,
                    MaKhoa,
                    NgayDieuTriThu,
                    Giuong,
                    ChanDoan,
                    BacSyDieuTri,
                    MaBacSyDieuTri,
                    DieuDuongCa1,
                    MaDieuDuongCa1,
                    DieuDuongCa2,
                    MaDieuDuongCa2,
                    DieuDuongCa3,
                    MaDieuDuongCa3,
                    PNLKhac,
                    CLSkhac,
                    SD1,
                    SD2,
                    NgayThucHien,
                    DsDichTruyen,
                    DsSonDe,
                    ttDichTruyen_Ca1,
                    ttSonDe_Ca1,
                    ttThuocTiem_Ca1,
                    ttThuocKhac_Ca1,
                    ttTheoDoi_Ca1,
                    MaNguoiTao_Ca1,
                    TenNguoiTao_Ca1,
                    ttDichTruyen_Ca2,
                    ttSonDe_Ca2,
                    ttThuocTiem_Ca2,
                    ttThuocKhac_Ca2,
                    ttTheoDoi_Ca2 ,
                    MaNguoiTao_Ca2 ,
                    TenNguoiTao_Ca2,
                    ttDichTruyen_Ca3,
                    ttSonDe_Ca3,
                    ttThuocTiem_Ca3,
                    ttThuocKhac_Ca3,
                    ttTheoDoi_Ca3 ,
                    MaNguoiTao_Ca3 ,
                    TenNguoiTao_Ca3,
                    ttThuocTiem,
                    ttThuocKhac,
                    ttTheoDoi,
                    NgayTao,
                    NguoiTao,
                    NgaySua,
                    NguoiSua
                )  VALUES(
                    :MaQuanLy,
                    :MaBenhNhan,
                    :TenBenhNhan,
                    :Tuoi,
                    :GioiTinh,
                    :SoBenhAn,
                    :Khoa,
                    :MaKhoa,
                    :NgayDieuTriThu,
                    :Giuong,
                    :ChanDoan,
                    :BacSyDieuTri,
                    :MaBacSyDieuTri,
                    :DieuDuongCa1,
                    :MaDieuDuongCa1,
                    :DieuDuongCa2,
                    :MaDieuDuongCa2,
                    :DieuDuongCa3,
                    :MaDieuDuongCa3,
                    :PNLKhac,
                    :CLSkhac,
                    :SD1,
                    :SD2,
                    :NgayThucHien,
                    :DsDichTruyen,
                    :DsSonDe,
                    :ttDichTruyen_Ca1,
                    :ttSonDe_Ca1,
                    :ttThuocTiem_Ca1,
                    :ttThuocKhac_Ca1,
                    :ttTheoDoi_Ca1,
                    :MaNguoiTao_Ca1,
                    :TenNguoiTao_Ca1,
                    :ttDichTruyen_Ca2,
                    :ttSonDe_Ca2,
                    :ttThuocTiem_Ca2,
                    :ttThuocKhac_Ca2,
                    :ttTheoDoi_Ca2 ,
                    :MaNguoiTao_Ca2 ,
                    :TenNguoiTao_Ca2,
                    :ttDichTruyen_Ca3,
                    :ttSonDe_Ca3,
                    :ttThuocTiem_Ca3,
                    :ttThuocKhac_Ca3,
                    :ttTheoDoi_Ca3 ,
                    :MaNguoiTao_Ca3 ,
                    :TenNguoiTao_Ca3,
                    :ttThuocTiem,
                    :ttThuocKhac,
                    :ttTheoDoi,
                    :NgayTao,
                    :NguoiTao,
                    :NgaySua,
                    :NguoiSua
                   )  RETURNING ID INTO :ID";
                if (obj.ID != 0)
                {
                    sql = @"UPDATE PhieuTDCSNBICU SET 
                        MaQuanLy=:MaQuanLy,
                        MaBenhNhan=:MaBenhNhan,
                        TenBenhNhan=:TenBenhNhan,
                        Tuoi=:Tuoi,
                        GioiTinh=:GioiTinh,
                        SoBenhAn=:SoBenhAn,
                        Khoa=:Khoa,
                        MaKhoa=:MaKhoa,
                        NgayDieuTriThu=:NgayDieuTriThu,
                        Giuong=:Giuong,
                        ChanDoan=:ChanDoan,
                        BacSyDieuTri=:BacSyDieuTri,
                        MaBacSyDieuTri=:MaBacSyDieuTri,
                        DieuDuongCa1=:DieuDuongCa1,
                        MaDieuDuongCa1=:MaDieuDuongCa1,
                        DieuDuongCa2=:DieuDuongCa2,
                        MaDieuDuongCa2=:MaDieuDuongCa2,
                        DieuDuongCa3=:DieuDuongCa3,
                        MaDieuDuongCa3=:MaDieuDuongCa3,
                        PNLKhac=:PNLKhac,
                        CLSkhac=:CLSkhac,
                        SD1=:SD1,
                        SD2=:SD2,
                        NgayThucHien=:NgayThucHien,
                        DsDichTruyen=:DsDichTruyen,
                        ttDichTruyen_Ca1 = :ttDichTruyen_Ca1,
                        ttSonDe_Ca1 = :ttSonDe_Ca1,
                        ttThuocTiem_Ca1 = :ttThuocTiem_Ca1,
                        ttThuocKhac_Ca1 = :ttThuocKhac_Ca1,
                        ttTheoDoi_Ca1 = :ttTheoDoi_Ca1,
                        MaNguoiTao_Ca1 = :MaNguoiTao_Ca1,
                        TenNguoiTao_Ca1 = :TenNguoiTao_Ca1,
                        ttDichTruyen_Ca2 = :ttDichTruyen_Ca2,
                        ttSonDe_Ca2 = :ttSonDe_Ca2,
                        ttThuocTiem_Ca2 = :ttThuocTiem_Ca2,
                        ttThuocKhac_Ca2 = :ttThuocKhac_Ca2,
                        ttTheoDoi_Ca2 = :ttTheoDoi_Ca2,
                        MaNguoiTao_Ca2 = :MaNguoiTao_Ca2,
                        TenNguoiTao_Ca2 = :TenNguoiTao_Ca2,
                        ttDichTruyen_Ca3 = :ttDichTruyen_Ca3,
                        ttSonDe_Ca3 = :ttSonDe_Ca3,
                        ttThuocTiem_Ca3 = :ttThuocTiem_Ca3,
                        ttThuocKhac_Ca3 = :ttThuocKhac_Ca3,
                        ttTheoDoi_Ca3 = :ttTheoDoi_Ca3,
                        MaNguoiTao_Ca3 = :MaNguoiTao_Ca3,
                        TenNguoiTao_Ca3 = :TenNguoiTao_Ca3,
                        ttThuocTiem =:ttThuocTiem,
                        ttThuocKhac=:ttThuocKhac,
                        ttTheoDoi=:ttTheoDoi,
                        NgayTao=:NgayTao,
                        NguoiTao=:NguoiTao,
                        NgaySua=:NgaySua,
                        NguoiSua=:NguoiSua
                        WHERE ID = " + obj.ID;
                }


                MDB.MDBCommand oracleCommand = new MDB.MDBCommand(sql, MyConnection);
                oracleCommand.Parameters.Add(new MDB.MDBParameter("MaQuanLy", obj.MaQuanLy));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("MaBenhNhan", obj.MaBenhNhan));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("TenBenhNhan", obj.TenBenhNhan));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("Tuoi", obj.Tuoi));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("GioiTinh", obj.GioiTinh));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("SoBenhAn", obj.SoBenhAn));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("Khoa", obj.Khoa));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("MaKhoa", obj.MaKhoa));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("NgayDieuTriThu", obj.NgayDieuTriThu));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("Giuong", obj.Giuong));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("ChanDoan", obj.ChanDoan));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("BacSyDieuTri", obj.BacSyDieuTri));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("MaBacSyDieuTri", obj.MaBacSyDieuTri));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("DieuDuongCa1", obj.DieuDuongCa1));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("MaDieuDuongCa1", obj.MaDieuDuongCa1));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("DieuDuongCa2", obj.DieuDuongCa2));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("MaDieuDuongCa2", obj.MaDieuDuongCa2));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("DieuDuongCa3", obj.DieuDuongCa3));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("MaDieuDuongCa3", obj.MaDieuDuongCa3));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("PNLKhac", obj.PNLKhac));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("CLSkhac", obj.CLSkhac));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("SD1", obj.SD1));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("SD2", obj.SD2));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("NgayThucHien", obj.NgayThucHien));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("DsDichTruyen", JsonConvert.SerializeObject(obj.DsDichTruyen)));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("DsSonDe", JsonConvert.SerializeObject(obj.DsSonDe)));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("ttDichTruyen_Ca1", JsonConvert.SerializeObject(obj.ttDichTruyen_Ca1)));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("ttSonDe_Ca1", JsonConvert.SerializeObject(obj.ttSonDe_Ca1)));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("ttThuocTiem_Ca1", JsonConvert.SerializeObject(obj.ttThuocTiem_Ca1)));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("ttThuocKhac_Ca1", JsonConvert.SerializeObject(obj.ttThuocKhac_Ca1)));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("ttTheoDoi_Ca1", JsonConvert.SerializeObject(obj.ttTheoDoi_Ca1)));
                if (Common.ConDBNull(obj.MaNguoiTao_Ca2).Length == 0)
                {
                    string MaNv = Common.getUserLogin();
                    string TenNV = "";
                    try
                    {
                        var nv = NhanVienFunc.ListNhanVien.Where(s => s.MaNhanVien == MaNv).FirstOrDefault();
                        if (nv != null)
                        {
                            TenNV = nv.HoVaTen;
                        }
                    }
                    catch { }
                    finally { }
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("MaNguoiTao_Ca1", MaNv));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("TenNguoiTao_Ca1", TenNV));
                }
                else
                {
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("MaNguoiTao_Ca1", obj.MaNguoiTao_Ca1));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("TenNguoiTao_Ca1", obj.TenNguoiTao_Ca1));
                }
                
                oracleCommand.Parameters.Add(new MDB.MDBParameter("ttDichTruyen_Ca2", JsonConvert.SerializeObject(obj.ttDichTruyen_Ca2)));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("ttSonDe_Ca2", JsonConvert.SerializeObject(obj.ttSonDe_Ca2)));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("ttThuocTiem_Ca2", JsonConvert.SerializeObject(obj.ttThuocTiem_Ca2)));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("ttThuocKhac_Ca2", JsonConvert.SerializeObject(obj.ttThuocKhac_Ca2)));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("ttTheoDoi_Ca2", JsonConvert.SerializeObject(obj.ttTheoDoi_Ca2)));
                if(Common.ConDBNull(obj.MaNguoiTao_Ca2).Length == 0)
                {
                    string MaNv = Common.getUserLogin();
                    string TenNV = "";
                    try
                    {
                        var nv = NhanVienFunc.ListNhanVien.Where(s => s.MaNhanVien == MaNv).FirstOrDefault();
                        if (nv != null)
                        {
                            TenNV = nv.HoVaTen;
                        }
                    }
                    catch { }
                    finally { }
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("MaNguoiTao_Ca2", MaNv));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("TenNguoiTao_Ca2", TenNV));
                }else
                {
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("MaNguoiTao_Ca2", obj.MaNguoiTao_Ca2));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("TenNguoiTao_Ca2", obj.TenNguoiTao_Ca2));
                }
                   
                oracleCommand.Parameters.Add(new MDB.MDBParameter("ttDichTruyen_Ca3", JsonConvert.SerializeObject(obj.ttDichTruyen_Ca3)));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("ttSonDe_Ca3", JsonConvert.SerializeObject(obj.ttSonDe_Ca3)));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("ttThuocTiem_Ca3", JsonConvert.SerializeObject(obj.ttThuocTiem_Ca3)));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("ttThuocKhac_Ca3", JsonConvert.SerializeObject(obj.ttThuocKhac_Ca3)));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("ttTheoDoi_Ca3", JsonConvert.SerializeObject(obj.ttTheoDoi_Ca3)));
                if (Common.ConDBNull(obj.MaNguoiTao_Ca2).Length == 0)
                {
                    string MaNv = Common.getUserLogin();
                    string TenNV = "";
                    try
                    {
                        var nv = NhanVienFunc.ListNhanVien.Where(s => s.MaNhanVien == MaNv).FirstOrDefault();
                        if (nv != null)
                        {
                            TenNV = nv.HoVaTen;
                        }
                    }
                    catch { }
                    finally { }
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("MaNguoiTao_Ca3", MaNv));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("TenNguoiTao_Ca3", TenNV));
                }
                else
                {
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("MaNguoiTao_Ca3", obj.MaNguoiTao_Ca3));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("TenNguoiTao_Ca3", obj.TenNguoiTao_Ca3));
                }
                
                oracleCommand.Parameters.Add(new MDB.MDBParameter("ttThuocTiem", JsonConvert.SerializeObject(obj.ttThuocTiem)));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("ttThuocKhac", JsonConvert.SerializeObject(obj.ttThuocKhac)));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("ttTheoDoi", JsonConvert.SerializeObject(obj.ttTheoDoi)));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("NgayTao", obj.NgayTao));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("NguoiTao", obj.NguoiTao));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("NgaySua", DateTime.Now));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("NguoiSua", obj.NguoiSua));
                if (obj.ID == 0)
                {
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("ID", obj.ID));
                }
                oracleCommand.BindByName = true;
                int n = oracleCommand.ExecuteNonQuery();
                if (obj.ID == 0)
                {
                    long nextval = Convert.ToInt64((oracleCommand.Parameters["ID"] as MDB.MDBParameter).Value);
                    obj.ID = nextval;
                }
                return n > 0 ? true : false;
            }
            catch (Exception ex)
            {
                throw ex;
            }            
        }
        public static bool InsertOrUpdateThongTinGio(MDB.MDBConnection MyConnection, ThongTinTheoDoiGio2 obj)
        {
            try
            {
                string sql = @"INSERT INTO PhieuTDCSNBICU_Gio
                (
                    ID_Phieu,
                    CaThu,
                    Gio,
                    HAMax, ThoiGian,
                    HAMin,
                    T,
                    M,
                    OX,
                    NT,
                    Mod,
                    Fi,
                    TV,
                    RR,
                    ALBD,
                    HD,
                    SpO2,
                    CVP,
                    CA,
                    NTieu,
                    DXK,
                    CBN,
                    SDVT1,
                    SDVT2,
                    ND,
                    BC,
                    L,
                    LVT,
                    PNL,
                    GMM,
                    GDULN,
                    GDUVD,
                    GTong,
                    DTT,
                    DTP,
                    YL,
                    CSDD,
                    CLS
                )  VALUES(
                    :ID_Phieu,
                    :CaThu,
                    :Gio,
                    :HAMax, :ThoiGian,
                    :HAMin,
                    :T,
                    :M,
                    :OX,
                    :NT,
                    :Mod,
                    :Fi,
                    :TV,
                    :RR,
                    :ALBD,
                    :HD,
                    :SpO2,
                    :CVP,
                    :CA,
                    :NTieu,
                    :DXK,
                    :CBN,
                    :SDVT1,
                    :SDVT2,
                    :ND,
                    :BC,
                    :L,
                    :LVT,
                    :PNL,
                    :GMM,
                    :GDULN,
                    :GDUVD,
                    :GTong,
                    :DTT,
                    :DTP,
                    :YL,
                    :CSDD,
                    :CLS
                )  RETURNING ID INTO :ID";
                if (obj.ID != 0)
                {
                    sql = @"UPDATE PhieuTDCSNBICU_Gio SET 
                    ID_Phieu=:ID_Phieu,
                    CaThu=:CaThu,
                    Gio=:Gio,
                    HAMax=:HAMax, ThoiGian=:ThoiGian,
                    HAMin=:HAMin,
                    T=:T,
                    M=:M,
                    OX=:OX,
                    NT=:NT,
                    Mod=:Mod,
                    Fi=:Fi,
                    TV=:TV,
                    RR=:RR,
                    ALBD=:ALBD,
                    HD=:HD,
                    SpO2=:SpO2,
                    CVP=:CVP,
                    CA=:CA,
                    NTieu=:NTieu,
                    DXK=:DXK,
                    CBN=:CBN,
                    SDVT1=:SDVT1,
                    SDVT2=:SDVT2,
                    ND=:ND,
                    BC=:BC,
                    L=:L,
                    LVT=:LVT,
                    PNL=:PNL,
                    GMM=:GMM,
                    GDULN=:GDULN,
                    GDUVD=:GDUVD,
                    GTong=:GTong,
                    DTT=:DTT,
                    DTP=:DTP,
                    YL=:YL,
                    CSDD=:CSDD,
                    CLS=:CLS
                    WHERE ID = " + obj.ID;
                }
                MDB.MDBCommand oracleCommand = new MDB.MDBCommand(sql, MyConnection);
                oracleCommand.Parameters.Add(new MDB.MDBParameter("ID_Phieu", obj.ID_Phieu));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("CaThu", obj.CaThu));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("Gio", obj.Gio));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("HAMax", obj.HAMax));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("ThoiGian", obj.ThoiGian));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("HAMin", obj.HAMin));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("T", obj.T));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("M", obj.M));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("OX", obj.OX));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("NT", obj.NT));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("Mod", obj.Mod));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("Fi", obj.Fi));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("TV", obj.TV));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("RR", obj.RR));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("ALBD", obj.ALBD));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("HD", obj.HD));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("SpO2", obj.SpO2));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("CVP", obj.CVP));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("CA", obj.CA));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("NTieu", obj.NTieu));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("DXK", obj.DXK));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("CBN", obj.CBN));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("SDVT1", obj.SDVT1));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("SDVT2", obj.SDVT2));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("ND", obj.ND));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("BC", obj.BC));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("L", obj.L));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("LVT", obj.LVT));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("PNL", obj.PNL));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("GMM", obj.GMM));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("GDULN", obj.GDULN));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("GDUVD", obj.GDUVD));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("GTong", obj.GTong));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("DTT", obj.DTT));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("DTP", obj.DTP));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("YL", obj.YL));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("CSDD", obj.CSDD));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("CLS", obj.CLS));
                oracleCommand.BindByName = true;
                if (obj.ID == 0)
                {
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("ID", obj.ID));
                }
                int n = oracleCommand.ExecuteNonQuery();
                if (obj.ID == 0)
                {
                    long nextval = Convert.ToInt64((oracleCommand.Parameters["ID"] as MDB.MDBParameter).Value);
                    obj.ID = nextval;
                }
                return n > 0 ? true : false;
            }
            catch (Exception ex)
            {
                throw ex;
            } 
        }

        public static bool deleteThongTinGio(MDB.MDBConnection MyConnection, decimal ID_Phieu)
        {
            try
            {
                string sql = "DELETE FROM PhieuTDCSNBICU_Gio WHERE ID_Phieu = :ID_Phieu";
                MDB.MDBCommand command = new MDB.MDBCommand(sql, MyConnection);
                command.Parameters.Add(new MDB.MDBParameter("ID_Phieu", ID_Phieu));
                command.BindByName = true;
                int n = command.ExecuteNonQuery();
                return n > 0 ? true : false;
            }
            catch (Exception ex)
            {
                throw ex;
            }   
        }
        public static bool deletePhieu(MDB.MDBConnection MyConnection, decimal id)
        {
            try
            {
                string sql = "DELETE FROM PhieuTDCSNBICU WHERE ID = :ID";
                MDB.MDBCommand command = new MDB.MDBCommand(sql, MyConnection);
                command.Parameters.Add(new MDB.MDBParameter("ID", id));
                command.BindByName = true;
                int n = command.ExecuteNonQuery();
                return n > 0 ? true : false;
            }
            catch (Exception ex)
            {
                throw ex;
            }          
        }

    }

}
