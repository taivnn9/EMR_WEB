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
    public class PhieuTDCSNB_Gio
    {
        [MoTaDuLieu("Mã định danh")]
		public decimal ID;
        [MoTaDuLieu("Mã định danh")]
		public decimal ID_Phieu { get; set; }
        public int CaThu { get; set; }
        public int Gio { get; set; }
        public DateTime ThoiGian { get; set; }
        public double? T { get; set; }
        public double? HAMax { get; set; }
        public double? HAMin { get; set; }
        public double? M { get; set; }
        public string Glass { get; set; }
        public string VTTT { get; set; }
        public string DGK1 { get; set; }
        public string DGK2 { get; set; }
        public string DGK3 { get; set; }
        public string DGK4 { get; set; }
        public string DGK5 { get; set; }
        public string DGK6 { get; set; }
        public string DGK7 { get; set; }
        public string Tso { get; set; }
        [MoTaDuLieu("Nồng độ Oxy trong máu")]
		public string SpO2 { get; set; }
        public string Mod { get; set; }
        public string Oxy { get; set; }
        public string Vt { get; set; }
        public string F { get; set; }
        public string Fi { get; set; }
        public string FEEP { get; set; }
        public double? DVThuoc { get; set; }
        public double? DVCA { get; set; }
        public double? DVKhac { get; set; }
        public double? DRTieu { get; set; }
        public double? DRKhac { get; set; }
        public string HD { get; set; }
        public string TB { get; set; }
        public string CSK { get; set; }
        public string TTL { get; set; }
        public string HA
        {
            get
            {
                if (Common.ConDBNull(HAMax).Length != 0 || Common.ConDBNull(HAMin).Length != 0)
                {
                    return (Common.ConDBNull(HAMax) + "/" + Common.ConDBNull(HAMin));
                }
                else
                {
                    return "";
                }
            }
        }
        public string VtF
        {
            get
            {
                if(Common.ConDBNull(Vt).Length != 0 || Common.ConDBNull(F).Length != 0)
                {
                    return (Common.ConDBNull(Vt) + "/" + Common.ConDBNull(F));
                }else
                {
                    return "";
                }
            }
        }
        public string TsoSpO2
        {
            get
            {
                if (Common.ConDBNull(Tso).Length != 0 || Common.ConDBNull(SpO2).Length != 0)
                {
                    return (Common.ConDBNull(Tso) + "/" + Common.ConDBNull(SpO2));
                }
                else
                {
                    return "";
                }
            }
        }
        public string ModOxy
        {
            get
            {
                if (Common.ConDBNull(Mod).Length != 0 || Common.ConDBNull(Oxy).Length != 0)
                {
                    return (Common.ConDBNull(Mod) + "/" + Common.ConDBNull(Oxy));
                }
                else
                {
                    return "";
                }
            }
        }
        public string FiO2FEEP
        {
            get
            {
                if (Common.ConDBNull(Fi).Length != 0 || Common.ConDBNull(FEEP).Length != 0)
                {
                    return (Common.ConDBNull(Fi) + "/" + Common.ConDBNull(FEEP));
                }
                else
                {
                    return "";
                }
            }
        }
        private double? _DRTong;
        public double? DRTong
        {
            get
            {
                if (Common.ConDBNull(DRTieu).Length != 0 || Common.ConDBNull(DRKhac).Length != 0)
                {
                    return (Common.ConDB_float(DRTieu) + Common.ConDB_float(DRKhac));
                }
                else
                {
                    return null;
                }
            }
            set
            {
                _DRTong = value;
            }
        }
        public double? DVRTong
        {
            get
            {
                if (Common.ConDBNull(DRTong).Length != 0 || Common.ConDBNull(DVTong).Length != 0)
                {
                    return (Common.ConDB_float(DRTong) + Common.ConDB_float(DVTong));
                }
                else
                {
                    return null;
                }
            }
        }
        private double? _DVTong;
        public double? DVTong
        {
            get
            {
                if (Common.ConDBNull(DVThuoc).Length != 0 || Common.ConDBNull(DVCA).Length != 0 || Common.ConDBNull(DVKhac).Length != 0)
                {
                    return (Common.ConDB_float(DVThuoc) + Common.ConDB_float(DVCA) + Common.ConDB_float(DVKhac));
                }
                else
                {
                    return null;
                }
            }
            set
            {
                _DVTong = value;
            }
        }
        public PhieuTDCSNB_Gio Clone()
        {
            PhieuTDCSNB_Gio other = (PhieuTDCSNB_Gio)this.MemberwiseClone();
            return other;
        }
    }
    public class PhieuTDCSNB_DSDT: DSDichTruyen2
    {
        public int Loai { get; set; }
        public string TenLoai
        {
            get
            {
                if (Loai == 1)
                {
                    return ("Máu");
                }
                else if (Loai == 2)
                {
                    return ("Thuốc");
                }
                else if (Loai == 3)
                {
                    return ("Dịch truyền");
                }
                return "";
            }
        }
        public PhieuTDCSNB_DSDT()
        {
            MaDT = string.Empty;
            TenDT = string.Empty;
        }
    }
    public class PhieuTDCSNB_TTDT : PhieuTDCSNB_DSDT
    {
        [MoTaDuLieu("Mã định danh")]
		public int ID { get; set; }
        public float? TheTich { get; set; }
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
                else
                {
                    return (Common.ConDBNull(TocDo) + "ml/phút");
                }
            }
        }
        public PhieuTDCSNB_TTDT()
        {
            MaDT = string.Empty;
            TenDT = string.Empty;
        }
    }
    public class PhieuTDCSNB : ThongTinKy
    {
        public PhieuTDCSNB()
        {
            TableName = "PhieuTDCSNB";
            TablePrimaryKeyName = "ID";
            IDMauPhieu = (int)DanhMucPhieu.PTDCSNB;
            TenMauPhieu = DanhMucPhieu.PTDCSNB.Description();
            ThongTinGio_Ca1 = new ObservableCollection<PhieuTDCSNB_Gio>();
            ThongTinGio_Ca2 = new ObservableCollection<PhieuTDCSNB_Gio>();
            ThongTinGio_Ca3 = new ObservableCollection<PhieuTDCSNB_Gio>();
            DsDichTruyen = new ObservableCollection<PhieuTDCSNB_DSDT>();
            ttDichTruyen_Ca1 = new ObservableCollection<PhieuTDCSNB_TTDT>();
            ttDichTruyen_Ca2 = new ObservableCollection<PhieuTDCSNB_TTDT>();
            ttDichTruyen_Ca3 = new ObservableCollection<PhieuTDCSNB_TTDT>();

        }
        public string SoYTe
        {
            get
            {
                return XemBenhAn._HanhChinhBenhNhan.SoYTe;
            }
        }
        public string SoBenhAn
        {
            get
            {
                return XemBenhAn._HanhChinhBenhNhan.MaBenhNhan;
            }
        }
        public string BenhVien
        {
            get
            {
                return XemBenhAn._HanhChinhBenhNhan.BenhVien;
            }
        }
        [MoTaDuLieu("Họ và tên bệnh nhân")]
		public string TenBenhNhan
        {
            get
            {
                return XemBenhAn._HanhChinhBenhNhan.TenBenhNhan;
            }
        }
        [MoTaDuLieu("Tuổi bệnh nhân")]
		public string Tuoi
        {
            get
            {
                return XemBenhAn._HanhChinhBenhNhan.Tuoi;
            }
        }
        public string SoNhapVien
        {
            get
            {
                return XemBenhAn._ThongTinDieuTri.SoNhapVien;
            }
        }
        [MoTaDuLieu("Giới tính bệnh nhân")]
		public string GioiTinh
        {
            get
            {
                return XemBenhAn._HanhChinhBenhNhan.GioiTinh.Description();
            }
        }
        private double? _BMI;
        public double? BMI
        {
            get
            {
                if (Common.ConDB_float(ChieuCao) != 0)
                {
                    return Math.Round(( Common.ConDB_float(CanNang) / Math.Pow((Common.ConDB_float(ChieuCao) / 100), 2)),2) ;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                _BMI = value;
            }
        }
        [MoTaDuLieu("Mã định danh")]
		public decimal ID { get; set; }
        [MoTaDuLieu("Mã quản lý: mã duy nhất trong 1 đợt khám chữa bệnh (kcb), không trùng giữa các đợt kcb khác nhau","",1)]
		public decimal MaQuanLy { get; set; }
        [MoTaDuLieu("Mã bệnh nhân")]
		public string MaBenhNhan { get; set; }
        [MoTaDuLieu("Mã khoa")]
		public string MaKhoa { get; set; }
        [MoTaDuLieu("Khoa")]
		public string Khoa { get; set; }
        public DateTime NgayThucHien { get; set; }
        public string NgayDieuTriThu { get; set; }
        [MoTaDuLieu("Giường")]
		public string Giuong { get; set; }
        [MoTaDuLieu("Mã giường")]
		public string MaGiuong { get; set; }
        public double? ChieuCao { get; set; }
        public double? CanNang { get; set; }
        [MoTaDuLieu("Nhóm máu")]
		public string NhomMau { get; set; }
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
        public string DGK1H { get; set; }
        public string DGK2H { get; set; }
        public string DGK3H { get; set; }
        public string DGK4H { get; set; }
        public string DGK5H { get; set; }
        public string DGK6H { get; set; }
        public string DGK7H { get; set; }
        public string Phan_Ca1 { get; set; }
        public string Phan_Ca2 { get; set; }
        public string Phan_Ca3 { get; set; }
        public string Dom_Ca1 { get; set; }
        public string Dom_Ca2 { get; set; }
        public string Dom_Ca3 { get; set; }
        public string CSKhac { get; set; }
        public string NKQ { get; set; }
        public string SondeDD { get; set; }
        public string SondeTieu { get; set; }
        public string DanLuu { get; set; }
        public string LoetEp { get; set; }
        public ObservableCollection<PhieuTDCSNB_Gio> ThongTinGio_Ca1 { get; set; }
        public ObservableCollection<PhieuTDCSNB_Gio> ThongTinGio_Ca2 { get; set; }
        public ObservableCollection<PhieuTDCSNB_Gio> ThongTinGio_Ca3 { get; set; }
        public ObservableCollection<PhieuTDCSNB_DSDT> DsDichTruyen { get; set; }
        public ObservableCollection<PhieuTDCSNB_TTDT> ttDichTruyen_Ca1 { get; set; }
        public ObservableCollection<PhieuTDCSNB_TTDT> ttDichTruyen_Ca2 { get; set; }
        public ObservableCollection<PhieuTDCSNB_TTDT> ttDichTruyen_Ca3 { get; set; }
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
    public class PhieuTDCSNBFunc
    {
        public const string TableName = "PhieuTDCSNB";
        public const string TablePrimaryKeyName = "ID";
        public static PhieuTDCSNB GetData(MDB.MDBConnection _OracleConnection, decimal maquanly , decimal ID)
        {
            PhieuTDCSNB data = new PhieuTDCSNB();
            try
            {
                string sql = @"SELECT *
                FROM PhieuTDCSNB 
                where ID =:ID And MaQuanLy = :MaQuanLy";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, _OracleConnection);
                Command.Parameters.Add(new MDB.MDBParameter("ID", ID));
                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", maquanly));
                MDB.MDBDataReader DataReader = Command.ExecuteReader();
                while (DataReader.Read())
                {
                    PhieuTDCSNB obj = new PhieuTDCSNB();
                    obj.ID = Common.ConDB_Decimal(DataReader["ID"]);
                    obj.MaQuanLy = Common.ConDB_Decimal(DataReader["MaQuanLy"]);
                    obj.MaBenhNhan = Common.ConDBNull(DataReader["MaBenhNhan"]);
                    obj.MaKhoa = Common.ConDBNull(DataReader["MaKhoa"]);
                    obj.Khoa = Common.ConDBNull(DataReader["Khoa"]);
                    obj.NgayThucHien = Common.ConDB_DateTime(DataReader["NgayThucHien"]);
                    obj.NgayDieuTriThu = Common.ConDBNull(DataReader["NgayDieuTriThu"]);
                    obj.Giuong = Common.ConDBNull(DataReader["Giuong"]);
                    obj.MaGiuong = Common.ConDBNull(DataReader["MaGiuong"]);
                    obj.ChieuCao = Common.ConDBNull_float(DataReader["ChieuCao"]);
                    obj.CanNang = Common.ConDBNull_float(DataReader["CanNang"]);
                    obj.NhomMau = Common.ConDBNull(DataReader["NhomMau"]);
                    obj.ChanDoan = Common.ConDBNull(DataReader["ChanDoan"]);
                    obj.BacSyDieuTri = Common.ConDBNull(DataReader["BacSyDieuTri"]);
                    obj.MaBacSyDieuTri = Common.ConDBNull(DataReader["MaBacSyDieuTri"]);
                    obj.DieuDuongCa1 = Common.ConDBNull(DataReader["DieuDuongCa1"]);
                    obj.MaDieuDuongCa1 = Common.ConDBNull(DataReader["MaDieuDuongCa1"]);
                    obj.DieuDuongCa2 = Common.ConDBNull(DataReader["DieuDuongCa2"]);
                    obj.MaDieuDuongCa2 = Common.ConDBNull(DataReader["MaDieuDuongCa2"]);
                    obj.DieuDuongCa3 = Common.ConDBNull(DataReader["DieuDuongCa3"]);
                    obj.MaDieuDuongCa3 = Common.ConDBNull(DataReader["MaDieuDuongCa3"]);
                    obj.DGK1H = Common.ConDBNull(DataReader["DGK1H"]);
                    obj.DGK2H = Common.ConDBNull(DataReader["DGK2H"]);
                    obj.DGK3H = Common.ConDBNull(DataReader["DGK3H"]);
                    obj.DGK4H = Common.ConDBNull(DataReader["DGK4H"]);
                    obj.DGK5H = Common.ConDBNull(DataReader["DGK5H"]);
                    obj.DGK6H = Common.ConDBNull(DataReader["DGK6H"]);
                    obj.DGK7H = Common.ConDBNull(DataReader["DGK7H"]);
                    obj.Phan_Ca1 = Common.ConDBNull(DataReader["Phan_Ca1"]);
                    obj.Phan_Ca2 = Common.ConDBNull(DataReader["Phan_Ca2"]);
                    obj.Phan_Ca3 = Common.ConDBNull(DataReader["Phan_Ca3"]);
                    obj.Dom_Ca1 = Common.ConDBNull(DataReader["Dom_Ca1"]);
                    obj.Dom_Ca2 = Common.ConDBNull(DataReader["Dom_Ca2"]);
                    obj.Dom_Ca3 = Common.ConDBNull(DataReader["Dom_Ca3"]);
                    obj.CSKhac = Common.ConDBNull(DataReader["CSKhac"]);
                    obj.ThongTinGio_Ca1 = getThongTinTheoDoiGio(_OracleConnection, obj.ID, 1);
                    obj.ThongTinGio_Ca2 = getThongTinTheoDoiGio(_OracleConnection, obj.ID, 2);
                    obj.ThongTinGio_Ca3 = getThongTinTheoDoiGio(_OracleConnection, obj.ID, 3);
                    obj.DsDichTruyen = JsonConvert.DeserializeObject<ObservableCollection < PhieuTDCSNB_DSDT >> (Common.ConDBNull(DataReader["DsDichTruyen"]));
                    obj.ttDichTruyen_Ca1 = JsonConvert.DeserializeObject<ObservableCollection<PhieuTDCSNB_TTDT>>(Common.ConDBNull(DataReader["ttDichTruyen_Ca1"]));
                    obj.ttDichTruyen_Ca2 = JsonConvert.DeserializeObject<ObservableCollection<PhieuTDCSNB_TTDT>>(Common.ConDBNull(DataReader["ttDichTruyen_Ca2"]));
                    obj.ttDichTruyen_Ca3 = JsonConvert.DeserializeObject<ObservableCollection<PhieuTDCSNB_TTDT>>(Common.ConDBNull(DataReader["ttDichTruyen_Ca3"]));
                    obj.NgayTao = Common.ConDB_DateTime(DataReader["NgayTao"]);
                    obj.NguoiTao = Common.ConDBNull(DataReader["NguoiTao"]);
                    obj.NgaySua = Common.ConDB_DateTime(DataReader["NgaySua"]);
                    obj.NguoiSua = Common.ConDBNull(DataReader["NguoiSua"]);
                    obj.NgayKy = Common.ConDB_DateTime(DataReader["ngayky"]);
                    obj.MaSoKy = DataReader["masokyten"].ToString();
                    obj.DaKy = !string.IsNullOrEmpty(obj.MaSoKy) ? true : false;
                    data = obj;
                }
            }
            catch (Exception ex) { throw ex; }
            return data;
        }
        public static List<PhieuTDCSNB> GetListData(MDB.MDBConnection _OracleConnection, decimal maquanly)
        {
            List<PhieuTDCSNB> list = new List<PhieuTDCSNB>();
            try
            {
                string sql = @"SELECT * FROM PhieuTDCSNB where MaQuanLy = :MaQuanLy";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, _OracleConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", maquanly));
                MDB.MDBDataReader DataReader = Command.ExecuteReader();
                while (DataReader.Read())
                {
                    PhieuTDCSNB obj = new PhieuTDCSNB();
                    obj.ID = Common.ConDB_Decimal(DataReader["ID"]);
                    obj.MaQuanLy = Common.ConDB_Decimal(DataReader["MaQuanLy"]);
                    obj.MaBenhNhan = Common.ConDBNull(DataReader["MaBenhNhan"]);
                    obj.MaKhoa = Common.ConDBNull(DataReader["MaKhoa"]);
                    obj.Khoa = Common.ConDBNull(DataReader["Khoa"]);
                    obj.NgayThucHien = Common.ConDB_DateTime(DataReader["NgayThucHien"]);
                    obj.NgayDieuTriThu = Common.ConDBNull(DataReader["NgayDieuTriThu"]);
                    obj.Giuong = Common.ConDBNull(DataReader["Giuong"]);
                    obj.MaGiuong = Common.ConDBNull(DataReader["MaGiuong"]);
                    obj.ChieuCao = Common.ConDBNull_float(DataReader["ChieuCao"]);
                    obj.CanNang = Common.ConDBNull_float(DataReader["CanNang"]);
                    obj.NhomMau = Common.ConDBNull(DataReader["NhomMau"]);
                    obj.ChanDoan = Common.ConDBNull(DataReader["ChanDoan"]);
                    obj.BacSyDieuTri = Common.ConDBNull(DataReader["BacSyDieuTri"]);
                    obj.MaBacSyDieuTri = Common.ConDBNull(DataReader["MaBacSyDieuTri"]);
                    obj.DieuDuongCa1 = Common.ConDBNull(DataReader["DieuDuongCa1"]);
                    obj.MaDieuDuongCa1 = Common.ConDBNull(DataReader["MaDieuDuongCa1"]);
                    obj.DieuDuongCa2 = Common.ConDBNull(DataReader["DieuDuongCa2"]);
                    obj.MaDieuDuongCa2 = Common.ConDBNull(DataReader["MaDieuDuongCa2"]);
                    obj.DieuDuongCa3 = Common.ConDBNull(DataReader["DieuDuongCa3"]);
                    obj.MaDieuDuongCa3 = Common.ConDBNull(DataReader["MaDieuDuongCa3"]);
                    obj.DGK1H = Common.ConDBNull(DataReader["DGK1H"]);
                    obj.DGK2H = Common.ConDBNull(DataReader["DGK2H"]);
                    obj.DGK3H = Common.ConDBNull(DataReader["DGK3H"]);
                    obj.DGK4H = Common.ConDBNull(DataReader["DGK4H"]);
                    obj.DGK5H = Common.ConDBNull(DataReader["DGK5H"]);
                    obj.DGK6H = Common.ConDBNull(DataReader["DGK6H"]);
                    obj.DGK7H = Common.ConDBNull(DataReader["DGK7H"]);
                    obj.Phan_Ca1 = Common.ConDBNull(DataReader["Phan_Ca1"]);
                    obj.Phan_Ca2 = Common.ConDBNull(DataReader["Phan_Ca2"]);
                    obj.Phan_Ca3 = Common.ConDBNull(DataReader["Phan_Ca3"]);
                    obj.Dom_Ca1 = Common.ConDBNull(DataReader["Dom_Ca1"]);
                    obj.Dom_Ca2 = Common.ConDBNull(DataReader["Dom_Ca2"]);
                    obj.Dom_Ca3 = Common.ConDBNull(DataReader["Dom_Ca3"]);
                    obj.CSKhac = Common.ConDBNull(DataReader["CSKhac"]);
                    obj.NKQ = Common.ConDBNull(DataReader["NKQ"]);
                    obj.SondeDD = Common.ConDBNull(DataReader["SondeDD"]);
                    obj.SondeTieu = Common.ConDBNull(DataReader["SondeTieu"]);
                    obj.DanLuu = Common.ConDBNull(DataReader["DanLuu"]);
                    obj.LoetEp = Common.ConDBNull(DataReader["LoetEp"]);
                    obj.ThongTinGio_Ca1 = getThongTinTheoDoiGio(_OracleConnection, obj.ID, 1);
                    obj.ThongTinGio_Ca2 = getThongTinTheoDoiGio(_OracleConnection, obj.ID, 2);
                    obj.ThongTinGio_Ca3 = getThongTinTheoDoiGio(_OracleConnection, obj.ID, 3);
                    obj.DsDichTruyen = JsonConvert.DeserializeObject<ObservableCollection<PhieuTDCSNB_DSDT>>(Common.ConDBNull(DataReader["DsDichTruyen"]));
                    obj.ttDichTruyen_Ca1 = JsonConvert.DeserializeObject<ObservableCollection<PhieuTDCSNB_TTDT>>(Common.ConDBNull(DataReader["ttDichTruyen_Ca1"]));
                    obj.ttDichTruyen_Ca2 = JsonConvert.DeserializeObject<ObservableCollection<PhieuTDCSNB_TTDT>>(Common.ConDBNull(DataReader["ttDichTruyen_Ca2"]));
                    obj.ttDichTruyen_Ca3 = JsonConvert.DeserializeObject<ObservableCollection<PhieuTDCSNB_TTDT>>(Common.ConDBNull(DataReader["ttDichTruyen_Ca3"]));
                    obj.NgayTao = Common.ConDB_DateTime(DataReader["NgayTao"]);
                    obj.NguoiTao = Common.ConDBNull(DataReader["NguoiTao"]);
                    obj.NgaySua = Common.ConDB_DateTime(DataReader["NgaySua"]);
                    obj.NguoiSua = Common.ConDBNull(DataReader["NguoiSua"]);
                    obj.NgayKy = Common.ConDB_DateTime(DataReader["ngayky"]);
                    obj.MaSoKy = DataReader["masokyten"].ToString();
                    obj.DaKy = !string.IsNullOrEmpty(obj.MaSoKy) ? true : false;
                    list.Add(obj);
                }
            }
            catch (Exception ex) { throw ex; }
            return list;
        }
        public static ObservableCollection<PhieuTDCSNB_Gio> getThongTinTheoDoiGio(MDB.MDBConnection _OracleConnection, decimal idPhieu, int caThu)
        {
            ObservableCollection<PhieuTDCSNB_Gio> ThongTinTheoDoiGios = new ObservableCollection<PhieuTDCSNB_Gio>();
            try
            {
                string sql = @"SELECT * FROM PhieuTDCSNB_Gio where ID_Phieu = :ID_Phieu and CaThu= :CaThu  ORDER BY ID asc";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, _OracleConnection);
                Command.Parameters.Add(new MDB.MDBParameter("ID_Phieu", idPhieu));
                Command.Parameters.Add(new MDB.MDBParameter("CaThu", caThu));
                MDB.MDBDataReader DataReader = Command.ExecuteReader();
                while (DataReader.Read())
                {
                    PhieuTDCSNB_Gio obj = new PhieuTDCSNB_Gio();
                    obj.ID = Common.ConDB_Decimal(DataReader["ID"]);
                    obj.ID_Phieu = Common.ConDB_Decimal(DataReader["ID_Phieu"]);
                    obj.CaThu = Common.ConDB_Int(DataReader["CaThu"]);
                    obj.Gio = Common.ConDB_Int(DataReader["Gio"]);
                    obj.ThoiGian = Common.ConDB_DateTime(DataReader["ThoiGian"]);
                    obj.T = Common.ConDBNull_float(DataReader["T"]);
                    obj.HAMax = Common.ConDBNull_float(DataReader["HAMax"]);
                    obj.HAMin = Common.ConDBNull_float(DataReader["HAMin"]);
                    obj.M = Common.ConDBNull_float(DataReader["M"]);
                    obj.Glass = Common.ConDBNull(DataReader["Glass"]);
                    obj.VTTT = Common.ConDBNull(DataReader["VTTT"]);
                    obj.DGK1 = Common.ConDBNull(DataReader["DGK1"]);
                    obj.DGK2 = Common.ConDBNull(DataReader["DGK2"]);
                    obj.DGK3 = Common.ConDBNull(DataReader["DGK3"]);
                    obj.DGK4 = Common.ConDBNull(DataReader["DGK4"]);
                    obj.DGK5 = Common.ConDBNull(DataReader["DGK5"]);
                    obj.Tso = Common.ConDBNull(DataReader["Tso"]);
                    obj.SpO2 = Common.ConDBNull(DataReader["SpO2"]);
                    obj.Mod = Common.ConDBNull(DataReader["Mod"]);
                    obj.Oxy = Common.ConDBNull(DataReader["Oxy"]);
                    obj.Vt = Common.ConDBNull(DataReader["Vt"]);
                    obj.F = Common.ConDBNull(DataReader["F"]);
                    obj.Fi = Common.ConDBNull(DataReader["Fi"]);
                    obj.FEEP = Common.ConDBNull(DataReader["FEEP"]);
                    obj.DVThuoc = Common.ConDBNull_float(DataReader["DVThuoc"]);
                    obj.DVCA = Common.ConDBNull_float(DataReader["DVCA"]);
                    obj.DVKhac = Common.ConDBNull_float(DataReader["DVKhac"]);
                    obj.DRTieu = Common.ConDBNull_float(DataReader["DRTieu"]);
                    obj.DRKhac = Common.ConDBNull_float(DataReader["DRKhac"]);
                    obj.HD = Common.ConDBNull(DataReader["HD"]);
                    obj.TB = Common.ConDBNull(DataReader["TB"]);
                    obj.CSK = Common.ConDBNull(DataReader["CSK"]);
                    obj.TTL = Common.ConDBNull(DataReader["TTL"]);
                    obj.DVTong = Common.ConDBNull_float(DataReader["DVTong"]);
                    obj.DRTong = Common.ConDBNull_float(DataReader["DRTong"]);
                    ThongTinTheoDoiGios.Add(obj);
                }
            }
            catch (Exception ex) { throw ex; }
            return ThongTinTheoDoiGios;
        }
        public static bool InsertOrUpdatePhieu(MDB.MDBConnection MyConnection, ref PhieuTDCSNB obj)
        {
            try
            {
                string sql = @"INSERT INTO PhieuTDCSNB
                (
                    MaQuanLy,
                    MaBenhNhan,
                    MaKhoa,Khoa,
                    NgayThucHien,
                    NgayDieuTriThu,
                    Giuong,
                    MaGiuong,
                    ChieuCao,
                    CanNang,
                    NhomMau,
                    ChanDoan,
                    BacSyDieuTri,
                    MaBacSyDieuTri,
                    DieuDuongCa1,
                    MaDieuDuongCa1,
                    DieuDuongCa2,
                    MaDieuDuongCa2,
                    DieuDuongCa3,
                    MaDieuDuongCa3,
                    DGK1H,
                    DGK2H,
                    DGK3H,
                    DGK4H,
                    DGK5H,DGK6H,DGK7H,
                    Phan_Ca1,
                    Phan_Ca2,
                    Phan_Ca3,
                    Dom_Ca1,
                    Dom_Ca2,
                    Dom_Ca3,CSKhac,NKQ,SondeDD,SondeTieu,DanLuu,LoetEp,
                    DsDichTruyen,
                    ttDichTruyen_Ca1,
                    ttDichTruyen_Ca2,
                    ttDichTruyen_Ca3,
                    NgayTao,
                    NguoiTao,
                    NgaySua,
                    NguoiSua
                )  VALUES(
                    :MaQuanLy,
                    :MaBenhNhan,
                    :MaKhoa,:Khoa,
                    :NgayThucHien,
                    :NgayDieuTriThu,
                    :Giuong,
                    :MaGiuong,
                    :ChieuCao,
                    :CanNang,
                    :NhomMau,
                    :ChanDoan,
                    :BacSyDieuTri,
                    :MaBacSyDieuTri,
                    :DieuDuongCa1,
                    :MaDieuDuongCa1,
                    :DieuDuongCa2,
                    :MaDieuDuongCa2,
                    :DieuDuongCa3,
                    :MaDieuDuongCa3,
                    :DGK1H,
                    :DGK2H,
                    :DGK3H,
                    :DGK4H,
                    :DGK5H,:DGK6H,:DGK7H,
                    :Phan_Ca1,
                    :Phan_Ca2,
                    :Phan_Ca3,
                    :Dom_Ca1,
                    :Dom_Ca2,
                    :Dom_Ca3,:CSKhac,:NKQ,:SondeDD,:SondeTieu,:DanLuu,:LoetEp,
                    :DsDichTruyen,
                    :ttDichTruyen_Ca1,
                    :ttDichTruyen_Ca2,
                    :ttDichTruyen_Ca3,
                    :NgayTao,
                    :NguoiTao,
                    :NgaySua,
                    :NguoiSua
                   )  RETURNING ID INTO :ID";
                if (obj.ID != 0)
                {
                    sql = @"UPDATE PhieuTDCSNB SET 
                    MaQuanLy=:MaQuanLy,
                    MaBenhNhan=:MaBenhNhan,
                    MaKhoa=:MaKhoa,Khoa=:Khoa,
                    NgayThucHien=:NgayThucHien,
                    NgayDieuTriThu=:NgayDieuTriThu,
                    Giuong=:Giuong,
                    MaGiuong=:MaGiuong,
                    ChieuCao=:ChieuCao,
                    CanNang=:CanNang,
                    NhomMau=:NhomMau,
                    ChanDoan=:ChanDoan,
                    BacSyDieuTri=:BacSyDieuTri,
                    MaBacSyDieuTri=:MaBacSyDieuTri,
                    DieuDuongCa1=:DieuDuongCa1,
                    MaDieuDuongCa1=:MaDieuDuongCa1,
                    DieuDuongCa2=:DieuDuongCa2,
                    MaDieuDuongCa2=:MaDieuDuongCa2,
                    DieuDuongCa3=:DieuDuongCa3,
                    MaDieuDuongCa3=:MaDieuDuongCa3,
                    DGK1H=:DGK1H,
                    DGK2H=:DGK2H,
                    DGK3H=:DGK3H,
                    DGK4H=:DGK4H,
                    DGK5H=:DGK5H,DGK6H=:DGK6H,DGK7H=:DGK7H,
                    Phan_Ca1=:Phan_Ca1,
                    Phan_Ca2=:Phan_Ca2,
                    Phan_Ca3=:Phan_Ca3,
                    Dom_Ca1=:Dom_Ca1,
                    Dom_Ca2=:Dom_Ca2,
                    Dom_Ca3=:Dom_Ca3,CSKhac=:CSKhac,NKQ=:NKQ,SondeDD =:SondeDD,SondeTieu =:SondeTieu,DanLuu =:DanLuu,LoetEp =:LoetEp,
                    DsDichTruyen=:DsDichTruyen,
                    ttDichTruyen_Ca1=:ttDichTruyen_Ca1,
                    ttDichTruyen_Ca2=:ttDichTruyen_Ca2,
                    ttDichTruyen_Ca3=:ttDichTruyen_Ca3,
                    NgaySua=:NgaySua,
                    NguoiSua=:NguoiSua
                        WHERE ID = " + obj.ID;
                }
                MDB.MDBCommand oracleCommand = new MDB.MDBCommand(sql, MyConnection);
                oracleCommand.Parameters.Add(new MDB.MDBParameter("MaQuanLy", obj.MaQuanLy));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("MaBenhNhan", obj.MaBenhNhan));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("MaKhoa", obj.MaKhoa));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("Khoa", obj.Khoa));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("NgayThucHien", obj.NgayThucHien));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("NgayDieuTriThu", obj.NgayDieuTriThu));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("Giuong", obj.Giuong));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("MaGiuong", obj.MaGiuong));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("ChieuCao", obj.ChieuCao));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("CanNang", obj.CanNang));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("NhomMau", obj.NhomMau));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("ChanDoan", obj.ChanDoan));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("BacSyDieuTri", obj.BacSyDieuTri));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("MaBacSyDieuTri", obj.MaBacSyDieuTri));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("DieuDuongCa1", obj.DieuDuongCa1));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("MaDieuDuongCa1", obj.MaDieuDuongCa1));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("DieuDuongCa2", obj.DieuDuongCa2));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("MaDieuDuongCa2", obj.MaDieuDuongCa2));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("DieuDuongCa3", obj.DieuDuongCa3));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("MaDieuDuongCa3", obj.MaDieuDuongCa3));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("DGK1H", obj.DGK1H));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("DGK2H", obj.DGK2H));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("DGK3H", obj.DGK3H));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("DGK4H", obj.DGK4H));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("DGK5H", obj.DGK5H));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("DGK6H", obj.DGK6H));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("DGK7H", obj.DGK7H));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("Phan_Ca1", obj.Phan_Ca1));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("Phan_Ca2", obj.Phan_Ca2));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("Phan_Ca3", obj.Phan_Ca3));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("Dom_Ca1", obj.Dom_Ca1));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("Dom_Ca2", obj.Dom_Ca2));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("Dom_Ca3", obj.Dom_Ca3));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("CSKhac", obj.CSKhac));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("NKQ", obj.NKQ));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("SondeDD", obj.SondeDD));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("SondeTieu", obj.SondeTieu));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("DanLuu", obj.DanLuu));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("LoetEp", obj.LoetEp));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("DsDichTruyen", JsonConvert.SerializeObject(obj.DsDichTruyen)));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("ttDichTruyen_Ca1", JsonConvert.SerializeObject(obj.ttDichTruyen_Ca1)));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("ttDichTruyen_Ca2", JsonConvert.SerializeObject(obj.ttDichTruyen_Ca2)));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("ttDichTruyen_Ca3", JsonConvert.SerializeObject(obj.ttDichTruyen_Ca3)));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("NgaySua", DateTime.Now));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("NguoiSua", Common.getUserLogin()));

                if (obj.ID == 0)
                {
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("NgayTao", DateTime.Now));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("NguoiTao", Common.getUserLogin()));
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
        public static bool InsertOrUpdateThongTinGio(MDB.MDBConnection MyConnection, PhieuTDCSNB_Gio obj)
        {
            try
            {
                string sql = @"INSERT INTO PhieuTDCSNB_Gio
                (
                    ID_Phieu,
                    CaThu,
                    Gio,
                    ThoiGian,
                    T,
                    HAMax,
                    HAMin,
                    M,
                    Glass,
                    VTTT,
                    DGK1,
                    DGK2,
                    DGK3,
                    DGK4,
                    DGK5,
                    Tso,
                    SpO2,
                    Mod,
                    Oxy,
                    Vt,
                    F,
                    Fi,
                    FEEP,
                    DVThuoc,
                    DVCA,
                    DVKhac,
                    DRTieu,
                    DRKhac,
                    HD,
                    TB,CSK,TTL,DVTong,DRTong,DGK6,DGK7
                )  VALUES(
                    :ID_Phieu,
                    :CaThu,
                    :Gio,
                    :ThoiGian,
                    :T,
                    :HAMax,
                    :HAMin,
                    :M,
                    :Glass,
                    :VTTT,
                    :DGK1,
                    :DGK2,
                    :DGK3,
                    :DGK4,
                    :DGK5,
                    :Tso,
                    :SpO2,
                    :Mod,
                    :Oxy,
                    :Vt,
                    :F,
                    :Fi,
                    :FEEP,
                    :DVThuoc,
                    :DVCA,
                    :DVKhac,
                    :DRTieu,
                    :DRKhac,
                    :HD,
                    :TB,:CSK,:TTL,:DVTong,:DRTong,:DGK6,:DGK7
                )  RETURNING ID INTO :ID";
                if (obj.ID != 0)
                {
                    sql = @"UPDATE PhieuTDCSNB_Gio SET 
                    ID_Phieu=:ID_Phieu,
                    CaThu=:CaThu,
                    Gio=:Gio,
                    ThoiGian=:ThoiGian,
                    T=:T,
                    HAMax=:HAMax,
                    HAMin=:HAMin,
                    M=:M,
                    Glass=:Glass,
                    VTTT=:VTTT,
                    DGK1=:DGK1,
                    DGK2=:DGK2,
                    DGK3=:DGK3,
                    DGK4=:DGK4,
                    DGK5=:DGK5,
                    Tso=:Tso,
                    SpO2=:SpO2,
                    Mod=:Mod,
                    Oxy=:Oxy,
                    Vt=:Vt,
                    F=:F,
                    Fi=:Fi,
                    FEEP=:FEEP,
                    DVThuoc=:DVThuoc,
                    DVCA=:DVCA,
                    DVKhac=:DVKhac,
                    DRTieu=:DRTieu,
                    DRKhac=:DRKhac,
                    HD=:HD,
                    TB=:TB,CSK=:CSK,TTL=:TTL,DVTong=:DVTong,DRTong=:DRTong,DGK6=:DGK6,DGK7=:DGK7
                    WHERE ID = " + obj.ID;
                }
                MDB.MDBCommand oracleCommand = new MDB.MDBCommand(sql, MyConnection);
                oracleCommand.Parameters.Add(new MDB.MDBParameter("ID_Phieu", obj.ID_Phieu));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("CaThu", obj.CaThu));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("Gio", obj.Gio));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("ThoiGian", obj.ThoiGian));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("T", obj.T));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("HAMax", obj.HAMax));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("HAMin", obj.HAMin));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("M", obj.M));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("Glass", obj.Glass));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("VTTT", obj.VTTT));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("DGK1", obj.DGK1));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("DGK2", obj.DGK2));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("DGK3", obj.DGK3));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("DGK4", obj.DGK4));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("DGK5", obj.DGK5));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("Tso", obj.Tso));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("SpO2", obj.SpO2));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("Mod", obj.Mod));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("Oxy", obj.Oxy));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("Vt", obj.Vt));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("F", obj.F));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("Fi", obj.Fi));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("FEEP", obj.FEEP));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("DVThuoc", obj.DVThuoc));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("DVCA", obj.DVCA));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("DVKhac", obj.DVKhac));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("DRTieu", obj.DRTieu));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("DRKhac", obj.DRKhac));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("HD", obj.HD));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("TB", obj.TB));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("CSK", obj.CSK));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("TTL", obj.TTL));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("DVTong", obj.DVTong));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("DRTong", obj.DRTong));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("DGK6", obj.DGK6));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("DGK7", obj.DGK7));
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
                string sql = "DELETE FROM PhieuTDCSNB_Gio WHERE ID_Phieu = :ID_Phieu";
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
                string sql = "DELETE FROM PhieuTDCSNB WHERE ID = :ID";
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
