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

    public class PTDCSNBKhoaSan_Gio
    {
        [MoTaDuLieu("Mã định danh")]
		public decimal ID;
        [MoTaDuLieu("Mã định danh")]
		public decimal ID_Phieu { get; set; }
        public int CaThu { get; set; }
        public int Gio { get; set; }
        public DateTime ThoiGian { get; set; }
        public double? M { get; set; }
        public double? T { get; set; }
        [MoTaDuLieu("Huyết áp")]
		public string HA { get; set; }
        [MoTaDuLieu("Nhịp tim")]
		public string NT { get; set; }
        public string OX { get; set; }
        public string TriGiac { get; set; }
        [MoTaDuLieu("Nồng độ Oxy trong máu")]
		public string SpO2 { get; set; }
        public string CVP { get; set; }
        public string TTO { get; set; }
        public string ChongKhop { get; set; }
        public string PNT { get; set; }
        public string VMC { get; set; }
        public string PXGX { get; set; }
        public string Ho { get; set; }
        public string Dom { get; set; }
        public string Da { get; set; }
        [MoTaDuLieu("Nước tiểu")]
		public string NuocTieu { get; set; }
        public string DXK { get; set; }
        public string CBN { get; set; }
        public string NDR { get; set; }
        public string BC { get; set; }
        public string CHTC { get; set; }
        public string MauAD { get; set; }
        public string CSDD { get; set; }
        public string CLS { get; set; }
        public PTDCSNBKhoaSan_Gio Clone()
        {
            PTDCSNBKhoaSan_Gio other = (PTDCSNBKhoaSan_Gio)this.MemberwiseClone();
            return other;
        }
    }
    public class TTTDChuyenDa
    {
        public DateTime ThoiGian { get; set; }
        public int Gio { get; set; }
        public string GioDis { get; set; }
        public double? TDTT { get; set; }
        public double? DMTC { get; set; }
        public double? TTNT { get; set; }
        public double? SoCCTC { get; set; }
        public double? TGCo { get; set; }
        public TTTDChuyenDa Clone()
        {
            TTTDChuyenDa other = (TTTDChuyenDa)this.MemberwiseClone();
            return other;
        }
    }

    public class PTDCSNBKhoaSan : ThongTinKy
    {
        public PTDCSNBKhoaSan()
        {
            TableName = "PTDCSNBKhoaSan";
            TablePrimaryKeyName = "ID";
            IDMauPhieu = (int)DanhMucPhieu.PTDVCSNBKS;
            TenMauPhieu = DanhMucPhieu.PTDVCSNBKS.Description();
            ThongTinGio_Ca1 = new ObservableCollection<PTDCSNBKhoaSan_Gio>();
            ThongTinGio_Ca2 = new ObservableCollection<PTDCSNBKhoaSan_Gio>();
            ThongTinGio_Ca3 = new ObservableCollection<PTDCSNBKhoaSan_Gio>();
            DsDichTruyen = new ObservableCollection<DSDichTruyen2>();
            ttDichTruyen_Ca1 = new ObservableCollection<ThongTinDichTruyen2>();
            ttDichTruyen_Ca2 = new ObservableCollection<ThongTinDichTruyen2>();
            ttDichTruyen_Ca3 = new ObservableCollection<ThongTinDichTruyen2>();
            DsSonDe = new ObservableCollection<DSSonDe>();
            ttSonDe = new ObservableCollection<DSSonDe_CT>();
            ttChuyenDa_Ca1 = new ObservableCollection<TTTDChuyenDa>();
            ttChuyenDa_Ca2 = new ObservableCollection<TTTDChuyenDa>();
            ttChuyenDa_Ca3 = new ObservableCollection<TTTDChuyenDa>();
            ttTheoDoi = new ObservableCollection<TheoDoiGhiChuDieuDuong>();

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
        public string NgayDieuTriThu { get; set; }
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
        [MoTaDuLieu("Thực hiện y lệnh")]
		public string ThucHienYLenh { get; set; }
        public DateTime NgayThucHien { get; set; }
        public ObservableCollection<PTDCSNBKhoaSan_Gio> ThongTinGio_Ca1 { get; set; }
        public ObservableCollection<PTDCSNBKhoaSan_Gio> ThongTinGio_Ca2 { get; set; }
        public ObservableCollection<PTDCSNBKhoaSan_Gio> ThongTinGio_Ca3 { get; set; }
        public ObservableCollection<DSDichTruyen2> DsDichTruyen { get; set; }
        public ObservableCollection<DSSonDe> DsSonDe { get; set; }
        public ObservableCollection<ThongTinDichTruyen2> ttDichTruyen_Ca1 { get; set; }
        public ObservableCollection<ThongTinDichTruyen2> ttDichTruyen_Ca2 { get; set; }
        public ObservableCollection<ThongTinDichTruyen2> ttDichTruyen_Ca3 { get; set; }
        public ObservableCollection<DSSonDe_CT> ttSonDe { get; set; }
        public ObservableCollection<TTTDChuyenDa> ttChuyenDa_Ca1 { get; set; }
        public ObservableCollection<TTTDChuyenDa> ttChuyenDa_Ca2 { get; set; }
        public ObservableCollection<TTTDChuyenDa> ttChuyenDa_Ca3 { get; set; }
        public ObservableCollection<TheoDoiGhiChuDieuDuong> ttTheoDoi { get; set; }
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
    public class PTDCSNBKhoaSanFunc
    {
        public const string TableName = "PTDCSNBKhoaSan";
        public const string TablePrimaryKeyName = "ID";
        public static PTDCSNBKhoaSan GetData(MDB.MDBConnection _OracleConnection, decimal maquanly , decimal ID)
        {
            PTDCSNBKhoaSan data = new PTDCSNBKhoaSan();
            try
            {
                string sql = @"SELECT *
                FROM PTDCSNBKhoaSan 
                where ID =:ID And MaQuanLy = :MaQuanLy";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, _OracleConnection);
                Command.Parameters.Add(new MDB.MDBParameter("ID", ID));
                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", maquanly));
                MDB.MDBDataReader DataReader = Command.ExecuteReader();
                while (DataReader.Read())
                {
                    PTDCSNBKhoaSan obj = new PTDCSNBKhoaSan();
                    obj.ID = Common.ConDB_Decimal(DataReader["ID"]);
                    obj.MaQuanLy = Common.ConDB_Decimal(DataReader["MaQuanLy"]);
                    obj.MaBenhNhan = Common.ConDBNull(DataReader["MaBenhNhan"]);
                    obj.TenBenhNhan = Common.ConDBNull(DataReader["TenBenhNhan"]);
                    obj.Tuoi = Common.ConDBNull(DataReader["Tuoi"]);
                    obj.GioiTinh = Common.ConDBNull(DataReader["GioiTinh"]);
                    obj.SoBenhAn = Common.ConDBNull(DataReader["SoBenhAn"]);
                    obj.Khoa = Common.ConDBNull(DataReader["Khoa"]);
                    obj.MaKhoa = Common.ConDBNull(DataReader["MaKhoa"]);
                    obj.NgayDieuTriThu = Common.ConDBNull(DataReader["NgayDieuTriThu"]);
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
                    obj.ThucHienYLenh = Common.ConDBNull(DataReader["ThucHienYLenh"]);
                    obj.NgayThucHien = Common.ConDB_DateTime(DataReader["NgayThucHien"]);
                    obj.ThongTinGio_Ca1 = getThongTinTheoDoiGio(_OracleConnection, obj.ID, 1);
                    obj.ThongTinGio_Ca2 = getThongTinTheoDoiGio(_OracleConnection, obj.ID, 2);
                    obj.ThongTinGio_Ca3 = getThongTinTheoDoiGio(_OracleConnection, obj.ID, 3);
                    obj.DsDichTruyen = JsonConvert.DeserializeObject<ObservableCollection<DSDichTruyen2>>(Common.ConDBNull(DataReader["DsDichTruyen"]));
                    obj.DsSonDe = JsonConvert.DeserializeObject<ObservableCollection<DSSonDe>>(Common.ConDBNull(DataReader["DsSonDe"]));
                    obj.ttDichTruyen_Ca1 = JsonConvert.DeserializeObject<ObservableCollection<ThongTinDichTruyen2>>(Common.ConDBNull(DataReader["ttDichTruyen_Ca1"]));
                    obj.ttDichTruyen_Ca2 = JsonConvert.DeserializeObject<ObservableCollection<ThongTinDichTruyen2>>(Common.ConDBNull(DataReader["ttDichTruyen_Ca2"]));
                    obj.ttDichTruyen_Ca3 = JsonConvert.DeserializeObject<ObservableCollection<ThongTinDichTruyen2>>(Common.ConDBNull(DataReader["ttDichTruyen_Ca3"]));
                    obj.ttSonDe = JsonConvert.DeserializeObject<ObservableCollection<DSSonDe_CT>>(Common.ConDBNull(DataReader["ttSonDe"]));
                    obj.ttChuyenDa_Ca1 = JsonConvert.DeserializeObject<ObservableCollection<TTTDChuyenDa>>(Common.ConDBNull(DataReader["ttChuyenDa_Ca1"]));
                    obj.ttChuyenDa_Ca2 = JsonConvert.DeserializeObject<ObservableCollection<TTTDChuyenDa>>(Common.ConDBNull(DataReader["ttChuyenDa_Ca2"]));
                    obj.ttChuyenDa_Ca3 = JsonConvert.DeserializeObject<ObservableCollection<TTTDChuyenDa>>(Common.ConDBNull(DataReader["ttChuyenDa_Ca3"]));
                    obj.ttTheoDoi = JsonConvert.DeserializeObject<ObservableCollection<TheoDoiGhiChuDieuDuong>>(Common.ConDBNull(DataReader["ttTheoDoi"]));
                    obj.NgayTao = Common.ConDB_DateTime(DataReader["NgayTao"]);
                    obj.NguoiTao = Common.ConDBNull(DataReader["NguoiTao"]);
                    obj.NgaySua = Common.ConDB_DateTime(DataReader["NgaySua"]);
                    obj.NguoiSua = Common.ConDBNull(DataReader["NguoiSua"]);
                    obj.NgayKy = Common.ConDB_DateTime(DataReader["ngayky"]);
                    obj.ThongTinGio_Ca1 = getThongTinTheoDoiGio(_OracleConnection, obj.ID, 1);
                    obj.ThongTinGio_Ca2 = getThongTinTheoDoiGio(_OracleConnection, obj.ID, 2);
                    obj.ThongTinGio_Ca3 = getThongTinTheoDoiGio(_OracleConnection, obj.ID, 3);
                    obj.MaSoKy = DataReader["masokyten"].ToString();
                    obj.DaKy = !string.IsNullOrEmpty(obj.MaSoKy) ? true : false;
                    data = obj;
                }
            }
            catch (Exception ex) { throw ex; }
            return data;
        }
        public static List<PTDCSNBKhoaSan> GetListData(MDB.MDBConnection _OracleConnection, decimal maquanly)
        {
            List<PTDCSNBKhoaSan> list = new List<PTDCSNBKhoaSan>();
            try
            {
                string sql = @"SELECT * FROM PTDCSNBKhoaSan where MaQuanLy = :MaQuanLy";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, _OracleConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", maquanly));
                MDB.MDBDataReader DataReader = Command.ExecuteReader();
                while (DataReader.Read())
                {
                    PTDCSNBKhoaSan obj = new PTDCSNBKhoaSan();
                    obj.ID = Common.ConDB_Decimal(DataReader["ID"]);
                    obj.MaQuanLy = Common.ConDB_Decimal(DataReader["MaQuanLy"]);
                    obj.MaBenhNhan = Common.ConDBNull(DataReader["MaBenhNhan"]);
                    obj.TenBenhNhan = Common.ConDBNull(DataReader["TenBenhNhan"]);
                    obj.Tuoi = Common.ConDBNull(DataReader["Tuoi"]);
                    obj.GioiTinh = Common.ConDBNull(DataReader["GioiTinh"]);
                    obj.SoBenhAn = Common.ConDBNull(DataReader["SoBenhAn"]);
                    obj.Khoa = Common.ConDBNull(DataReader["Khoa"]);
                    obj.MaKhoa = Common.ConDBNull(DataReader["MaKhoa"]);
                    obj.NgayDieuTriThu = Common.ConDBNull(DataReader["NgayDieuTriThu"]);
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
                    obj.ThucHienYLenh = Common.ConDBNull(DataReader["ThucHienYLenh"]);
                    obj.NgayThucHien = Common.ConDB_DateTime(DataReader["NgayThucHien"]);
                    obj.ThongTinGio_Ca1 = getThongTinTheoDoiGio(_OracleConnection, obj.ID, 1);
                    obj.ThongTinGio_Ca2 = getThongTinTheoDoiGio(_OracleConnection, obj.ID, 2);
                    obj.ThongTinGio_Ca3 = getThongTinTheoDoiGio(_OracleConnection, obj.ID, 3);
                    obj.DsDichTruyen = JsonConvert.DeserializeObject<ObservableCollection<DSDichTruyen2>>(Common.ConDBNull(DataReader["DsDichTruyen"]));
                    obj.DsSonDe = JsonConvert.DeserializeObject<ObservableCollection<DSSonDe>>(Common.ConDBNull(DataReader["DsSonDe"]));
                    obj.ttDichTruyen_Ca1 = JsonConvert.DeserializeObject<ObservableCollection<ThongTinDichTruyen2>>(Common.ConDBNull(DataReader["ttDichTruyen_Ca1"]));
                    obj.ttDichTruyen_Ca2 = JsonConvert.DeserializeObject<ObservableCollection<ThongTinDichTruyen2>>(Common.ConDBNull(DataReader["ttDichTruyen_Ca2"]));
                    obj.ttDichTruyen_Ca3 = JsonConvert.DeserializeObject<ObservableCollection<ThongTinDichTruyen2>>(Common.ConDBNull(DataReader["ttDichTruyen_Ca3"]));
                    obj.ttSonDe = JsonConvert.DeserializeObject<ObservableCollection<DSSonDe_CT>>(Common.ConDBNull(DataReader["ttSonDe"]));
                    obj.ttChuyenDa_Ca1 = JsonConvert.DeserializeObject<ObservableCollection<TTTDChuyenDa>>(Common.ConDBNull(DataReader["ttChuyenDa_Ca1"]));
                    obj.ttChuyenDa_Ca2 = JsonConvert.DeserializeObject<ObservableCollection<TTTDChuyenDa>>(Common.ConDBNull(DataReader["ttChuyenDa_Ca2"]));
                    obj.ttChuyenDa_Ca3 = JsonConvert.DeserializeObject<ObservableCollection<TTTDChuyenDa>>(Common.ConDBNull(DataReader["ttChuyenDa_Ca3"]));
                    obj.ttTheoDoi = JsonConvert.DeserializeObject<ObservableCollection<TheoDoiGhiChuDieuDuong>>(Common.ConDBNull(DataReader["ttTheoDoi"]));
                    obj.NgayTao = Common.ConDB_DateTime(DataReader["NgayTao"]);
                    obj.NguoiTao = Common.ConDBNull(DataReader["NguoiTao"]);
                    obj.NgaySua = Common.ConDB_DateTime(DataReader["NgaySua"]);
                    obj.NguoiSua = Common.ConDBNull(DataReader["NguoiSua"]);
                    obj.NgayKy = Common.ConDB_DateTime(DataReader["ngayky"]);
                    obj.ThongTinGio_Ca1 = getThongTinTheoDoiGio(_OracleConnection, obj.ID, 1);
                    obj.ThongTinGio_Ca2 = getThongTinTheoDoiGio(_OracleConnection, obj.ID, 2);
                    obj.ThongTinGio_Ca3 = getThongTinTheoDoiGio(_OracleConnection, obj.ID, 3);
                    obj.MaSoKy = DataReader["masokyten"].ToString();
                    obj.DaKy = !string.IsNullOrEmpty(obj.MaSoKy) ? true : false;
                    list.Add(obj);
                }
            }
            catch (Exception ex) { throw ex; }
            return list;
        }
        public static ObservableCollection<PTDCSNBKhoaSan_Gio> getThongTinTheoDoiGio(MDB.MDBConnection _OracleConnection, decimal idPhieu, int caThu)
        {
            ObservableCollection<PTDCSNBKhoaSan_Gio> ThongTinTheoDoiGios = new ObservableCollection<PTDCSNBKhoaSan_Gio>();
            try
            {
                string sql = @"SELECT * FROM PTDCSNBKhoaSan_Gio where ID_Phieu = :ID_Phieu and CaThu= :CaThu  ORDER BY ID asc";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, _OracleConnection);
                Command.Parameters.Add(new MDB.MDBParameter("ID_Phieu", idPhieu));
                Command.Parameters.Add(new MDB.MDBParameter("CaThu", caThu));
                MDB.MDBDataReader DataReader = Command.ExecuteReader();
                while (DataReader.Read())
                {
                    PTDCSNBKhoaSan_Gio obj = new PTDCSNBKhoaSan_Gio();
                    obj.ID = Common.ConDB_Decimal(DataReader["ID"]);
                    obj.ID_Phieu = Common.ConDB_Decimal(DataReader["ID_Phieu"]);
                    obj.CaThu = Common.ConDB_Int(DataReader["CaThu"]);
                    obj.Gio = Common.ConDB_Int(DataReader["Gio"]);
                    obj.ThoiGian = Common.ConDB_DateTime(DataReader["ThoiGian"]);
                    obj.M = Common.ConDBNull_float(DataReader["M"]);
                    obj.T = Common.ConDBNull_float(DataReader["T"]);
                    obj.HA = Common.ConDBNull(DataReader["HA"]);
                    obj.NT = Common.ConDBNull(DataReader["NT"]);
                    obj.OX = Common.ConDBNull(DataReader["OX"]);
                    obj.TriGiac = Common.ConDBNull(DataReader["TriGiac"]);
                    obj.SpO2 = Common.ConDBNull(DataReader["SpO2"]);
                    obj.CVP = Common.ConDBNull(DataReader["CVP"]);
                    obj.TTO = Common.ConDBNull(DataReader["TTO"]);
                    obj.ChongKhop = Common.ConDBNull(DataReader["ChongKhop"]);
                    obj.PNT = Common.ConDBNull(DataReader["PNT"]);
                    obj.VMC = Common.ConDBNull(DataReader["VMC"]);
                    obj.PXGX = Common.ConDBNull(DataReader["PXGX"]);
                    obj.Ho = Common.ConDBNull(DataReader["Ho"]);
                    obj.Dom = Common.ConDBNull(DataReader["Dom"]);
                    obj.Da = Common.ConDBNull(DataReader["Da"]);
                    obj.NuocTieu = Common.ConDBNull(DataReader["NuocTieu"]);
                    obj.DXK = Common.ConDBNull(DataReader["DXK"]);
                    obj.CBN = Common.ConDBNull(DataReader["CBN"]);
                    obj.NDR = Common.ConDBNull(DataReader["NDR"]);
                    obj.BC = Common.ConDBNull(DataReader["BC"]);
                    obj.CHTC = Common.ConDBNull(DataReader["CHTC"]);
                    obj.MauAD = Common.ConDBNull(DataReader["MauAD"]);
                    obj.CSDD = Common.ConDBNull(DataReader["CSDD"]);
                    obj.CLS = Common.ConDBNull(DataReader["CLS"]);
                    ThongTinTheoDoiGios.Add(obj);
                }
            }
            catch (Exception ex) { throw ex; }
            return ThongTinTheoDoiGios;
        }
        public static bool InsertOrUpdatePhieu(MDB.MDBConnection MyConnection, ref PTDCSNBKhoaSan obj)
        {
            try
            {
                string sql = @"INSERT INTO PTDCSNBKhoaSan
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
                    ThucHienYLenh,
                    NgayThucHien,
                    DsDichTruyen,
                    DsSonDe,
                    ttDichTruyen_Ca1,ttDichTruyen_Ca2, ttDichTruyen_Ca3,
                    ttSonDe,
                    ttChuyenDa_Ca1,ttChuyenDa_Ca2,ttChuyenDa_Ca3,
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
                    :ThucHienYLenh,
                    :NgayThucHien,
                    :DsDichTruyen,
                    :DsSonDe,
                    :ttDichTruyen_Ca1, :ttDichTruyen_Ca2, :ttDichTruyen_Ca3,
                    :ttSonDe,
                    :ttChuyenDa_Ca1,:ttChuyenDa_Ca2,:ttChuyenDa_Ca3,
                    :ttTheoDoi,
                    :NgayTao,
                    :NguoiTao,
                    :NgaySua,
                    :NguoiSua

                   )  RETURNING ID INTO :ID";
                if (obj.ID != 0)
                {
                    sql = @"UPDATE PTDCSNBKhoaSan SET 
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
                        ThucHienYLenh=:ThucHienYLenh,
                        NgayThucHien=:NgayThucHien,
                        DsDichTruyen=:DsDichTruyen,
                        DsSonDe=:DsSonDe,
                        ttDichTruyen_Ca1=:ttDichTruyen_Ca1,ttDichTruyen_Ca2=:ttDichTruyen_Ca2, ttDichTruyen_Ca3=:ttDichTruyen_Ca3,
                        ttSonDe=:ttSonDe,
                        ttChuyenDa_Ca1=:ttChuyenDa_Ca1,ttChuyenDa_Ca2=:ttChuyenDa_Ca2,ttChuyenDa_Ca3=:ttChuyenDa_Ca3,
                        ttTheoDoi=:ttTheoDoi,
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
                oracleCommand.Parameters.Add(new MDB.MDBParameter("ThucHienYLenh", obj.ThucHienYLenh));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("NgayThucHien", obj.NgayThucHien));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("DsDichTruyen", JsonConvert.SerializeObject(obj.DsDichTruyen)));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("DsSonDe", JsonConvert.SerializeObject(obj.DsSonDe)));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("ttDichTruyen_Ca1", JsonConvert.SerializeObject(obj.ttDichTruyen_Ca1)));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("ttDichTruyen_Ca2", JsonConvert.SerializeObject(obj.ttDichTruyen_Ca2))); ;
                oracleCommand.Parameters.Add(new MDB.MDBParameter("ttDichTruyen_Ca3", JsonConvert.SerializeObject(obj.ttDichTruyen_Ca3)));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("ttSonDe", JsonConvert.SerializeObject(obj.ttSonDe)));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("ttChuyenDa_Ca1", JsonConvert.SerializeObject(obj.ttChuyenDa_Ca1)));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("ttChuyenDa_Ca2", JsonConvert.SerializeObject(obj.ttChuyenDa_Ca2)));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("ttChuyenDa_Ca3", JsonConvert.SerializeObject(obj.ttChuyenDa_Ca3)));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("ttTheoDoi", JsonConvert.SerializeObject(obj.ttTheoDoi)));
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
        public static bool InsertOrUpdateThongTinGio(MDB.MDBConnection MyConnection, PTDCSNBKhoaSan_Gio obj)
        {
            try
            {
                string sql = @"INSERT INTO PTDCSNBKhoaSan_Gio
                (
                    ID_Phieu,
                    CaThu,
                    Gio,
                    ThoiGian,
                    M,
                    T,
                    HA,
                    NT,
                    OX,
                    TriGiac,
                    SpO2,
                    CVP,
                    TTO,
                    ChongKhop,
                    PNT,
                    VMC,
                    PXGX,
                    Ho,
                    Dom,
                    Da,
                    NuocTieu,
                    DXK,
                    CBN,
                    NDR,
                    BC,
                    CHTC,
                    MauAD,
                    CSDD,
                    CLS
                )  VALUES(
                    :ID_Phieu,
                    :CaThu,
                    :Gio,
                    :ThoiGian,
                    :M,
                    :T,
                    :HA,
                    :NT,
                    :OX,
                    :TriGiac,
                    :SpO2,
                    :CVP,
                    :TTO,
                    :ChongKhop,
                    :PNT,
                    :VMC,
                    :PXGX,
                    :Ho,
                    :Dom,
                    :Da,
                    :NuocTieu,
                    :DXK,
                    :CBN,
                    :NDR,
                    :BC,
                    :CHTC,
                    :MauAD,
                    :CSDD,
                    :CLS
                )  RETURNING ID INTO :ID";
                if (obj.ID != 0)
                {
                    sql = @"UPDATE PTDCSNBKhoaSan_Gio SET 
                    ID_Phieu=:ID_Phieu,
                    CaThu=:CaThu,
                    Gio=:Gio,
                    ThoiGian=:ThoiGian,
                    M=:M,
                    T=:T,
                    HA=:HA,
                    NT=:NT,
                    OX=:OX,
                    TriGiac=:TriGiac,
                    SpO2=:SpO2,
                    CVP=:CVP,
                    TTO=:TTO,
                    ChongKhop=:ChongKhop,
                    PNT=:PNT,
                    VMC=:VMC,
                    PXGX=:PXGX,
                    Ho=:Ho,
                    Dom=:Dom,
                    Da=:Da,
                    NuocTieu=:NuocTieu,
                    DXK=:DXK,
                    CBN=:CBN,
                    NDR=:NDR,
                    BC=:BC,
                    CHTC=:CHTC,
                    MauAD=:MauAD,
                    CSDD=:CSDD,
                    CLS=:CLS
                    WHERE ID = " + obj.ID;
                }
                MDB.MDBCommand oracleCommand = new MDB.MDBCommand(sql, MyConnection);
                oracleCommand.Parameters.Add(new MDB.MDBParameter("ID_Phieu", obj.ID_Phieu));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("CaThu", obj.CaThu));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("Gio", obj.Gio));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("ThoiGian", obj.ThoiGian));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("M", obj.M));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("T", obj.T));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("HA", obj.HA));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("NT", obj.NT));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("OX", obj.OX));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("TriGiac", obj.TriGiac));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("SpO2", obj.SpO2));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("CVP", obj.CVP));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("TTO", obj.TTO));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("ChongKhop", obj.ChongKhop));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("PNT", obj.PNT));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("VMC", obj.VMC));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("PXGX", obj.PXGX));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("Ho", obj.Ho));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("Dom", obj.Dom));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("Da", obj.Da));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("NuocTieu", obj.NuocTieu));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("DXK", obj.DXK));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("CBN", obj.CBN));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("NDR", obj.NDR));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("BC", obj.BC));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("CHTC", obj.CHTC));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("MauAD", obj.MauAD));
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
                string sql = "DELETE FROM PTDCSNBKhoaSan_Gio WHERE ID_Phieu = :ID_Phieu";
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
                string sql = "DELETE FROM PTDCSNBKhoaSan WHERE ID = :ID";
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
