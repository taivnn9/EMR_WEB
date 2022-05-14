using EMR.KyDienTu;
using NLog;
using PMS.Access;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace EMR_MAIN.DATABASE.Other
{
    public class HoSoTriXa : ThongTinKy
    {
        public HoSoTriXa()
        {
            TableName = "HoSoTriXa";
            TablePrimaryKeyName = "ID";
            IDMauPhieu = (int)DanhMucPhieu.HSTX;
            TenMauPhieu = DanhMucPhieu.HSTX.Description();
        }
        [MoTaDuLieu("Mã định danh")]
		public decimal IDPhieu { get; set; }
        [MoTaDuLieu("Mã quản lý: mã duy nhất trong 1 đợt khám chữa bệnh (kcb), không trùng giữa các đợt kcb khác nhau","",1)]
		public decimal MaQuanLy { get; set; }
        [MoTaDuLieu("Tên khoa")]
		public string TenKhoa { get; set; }
        [MoTaDuLieu("Mã bệnh án")]
		public string MaBenhAn { get; set; }
        [MoTaDuLieu("Mã bệnh nhân")]
		public string MaBenhNhan { get; set; }
        [MoTaDuLieu("Địa chỉ nhà bệnh nhân")]
		public string DiaChi { get; set; }
        public string SoPhieu { get; set; }
        [MoTaDuLieu("Mã khoa")]
		public string MaKhoa { get; set; }
        [MoTaDuLieu("Buồng")]
		public string Buong { get; set; }
        [MoTaDuLieu("Giường")]
		public string Giuong { get; set; }
        [MoTaDuLieu("Mã giường")]
		public string MaGiuong { get; set; }
        [MoTaDuLieu("Chẩn đoán bệnh")]
		public string ChanDoan { get; set; }
        [MoTaDuLieu("Chẩn đoán bệnh")]
		public string ChanDoanGPBL { get; set; }
        public bool[] MDTXArray { get; } = new bool[] { false, false, false };

        public string MDTX
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < MDTXArray.Length; i++)
                    temp += (MDTXArray[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                    MDTXArray[i] = intTemp == 1 ? true : false;
                    }
                }
                }
            }
        public string MDTX_Txt1 { get; set; }
        public string MDTX_Txt2 { get; set; }
        public string MDTX_Txt3 { get; set; }
        public string Photon { get; set; }
        public string Electron { get; set; }
        public string TongLieuTC { get; set; }
        public string LieuTC1 { get; set; }
        public string LieuTC2 { get; set; }
        public string LieuTC3 { get; set; }
        public DateTime? NgayThucHien { get; set; }
        public DateTime? NgayVaoVien { get; set; }
        public DateTime? NgayRaVien { get; set; }
        public string MaKTV { get; set; }
        public string TenKTV { get; set; }
        public string MaBacSyDT { get; set; }
        public string TenBacSyDT { get; set; }
        public string SSD_TC1 { get; set; }
        public string SAD_TC1 { get; set; }
        public string ThanMay_TC1 { get; set; }
        public string Colli_TC1 { get; set; }
        public string Giuong_TC1 { get; set; }
        public string LocNem_TC1 { get; set; }
        public string CheTri_TC1 { get; set; }
        public string SSD_TC2 { get; set; }
        public string SAD_TC2 { get; set; }
        public string ThanMay_TC2 { get; set; }
        public string Colli_TC2 { get; set; }
        public string Giuong_TC2 { get; set; }
        public string LocNem_TC2 { get; set; }
        public string CheTri_TC2 { get; set; }
        public string SSD_TC3 { get; set; }
        public string SAD_TC3 { get; set; }
        public string ThanMay_TC3 { get; set; }
        public string Colli_TC3 { get; set; }
        public string Giuong_TC3 { get; set; }
        public string LocNem_TC3 { get; set; }
        public string CheTri_TC3 { get; set; }
        public string SSD_TC4 { get; set; }
        public string SAD_TC4 { get; set; }
        public string ThanMay_TC4 { get; set; }
        public string Colli_TC4 { get; set; }
        public string Giuong_TC4 { get; set; }
        public string LocNem_TC4 { get; set; }
        public string CheTri_TC4 { get; set; }
        public string SSD_TC5 { get; set; }
        public string SAD_TC5 { get; set; }
        public string ThanMay_TC5 { get; set; }
        public string Colli_TC5 { get; set; }
        public string Giuong_TC5 { get; set; }
        public string LocNem_TC5 { get; set; }
        public string CheTri_TC5 { get; set; }
        public string SSD_TC6 { get; set; }
        public string SAD_TC6 { get; set; }
        public string ThanMay_TC6 { get; set; }
        public string Colli_TC6 { get; set; }
        public string Giuong_TC6 { get; set; }
        public string LocNem_TC6 { get; set; }
        public string CheTri_TC6 { get; set; }
        public string SSD_TBS1 { get; set; }
        public string SAD_TBS1 { get; set; }
        public string ThanMay_TBS1 { get; set; }
        public string Colli_TBS1 { get; set; }
        public string Giuong_TBS1 { get; set; }
        public string LocNem_TBS1 { get; set; }
        public string CheTri_TBS1 { get; set; }
        public string SSD_TBS2 { get; set; }
        public string SAD_TBS2 { get; set; }
        public string ThanMay_TBS2 { get; set; }
        public string Colli_TBS2 { get; set; }
        public string Giuong_TBS2 { get; set; }
        public string LocNem_TBS2 { get; set; }
        public string CheTri_TBS2 { get; set; }
        public string SSD_TBS3 { get; set; }
        public string SAD_TBS3 { get; set; }
        public string ThanMay_TBS3 { get; set; }
        public string Colli_TBS3 { get; set; }
        public string Giuong_TBS3 { get; set; }
        public string LocNem_TBS3 { get; set; }
        public string CheTri_TBS3 { get; set; }
        public string HCVL { get; set; }
        public string NXSauDT { get; set; }
        [MoTaDuLieu("Người tạo",null,0,0)]
		public string NguoiTao { get; set; }
        [MoTaDuLieu("Ngày tạo", null, 0, 0)]
		public DateTime NgayTao { get; set; }
        [MoTaDuLieu("Người sửa", null, 0, 0)]
		public string NguoiSua { get; set; }
        [MoTaDuLieu("Ngày sửa", null, 0, 0)]
		public DateTime NgaySua { get; set; }
        [MoTaDuLieu("Chọn", null, 0, 0)]
		public bool Chon { get; set; }
        //public string MaSoKyTen { get; set; }
        [MoTaDuLieu("Đã ký", null, 0, 0)]
		public bool DaKy { get; set; }
        public List<HoSoTriXa_ChiTiet> TTTXChiTiet { get; set; }
        public string SoYTe
        {
            get
            {
                return XemBenhAn._HanhChinhBenhNhan.SoYTe;
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
        public string SoVaoVien
        {
            get
            {
                return XemBenhAn._ThongTinDieuTri.SoNhapVien;
            }
        }
        public string SoTheBHYT
        {
            get
            {
                return XemBenhAn._HanhChinhBenhNhan.SoTheBHYT;
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
        [MoTaDuLieu("Giới tính bệnh nhân")]
		public string GioiTinh
        {
            get
            {
                return XemBenhAn._HanhChinhBenhNhan.GioiTinh.Description();
            }
        }
    }
    public class HoSoTriXa_ChiTiet
    {
        [MoTaDuLieu("Mã định danh")]
		public decimal ID { get; set; }
        [MoTaDuLieu("Mã định danh")]
		public decimal IDPhieu { get; set; }
        public DateTime? ThoiGian { get; set; }
        public DateTime? ThoiGianBS { get; set; }
        public string TenKTV { get; set; }
        public string MaKTV { get; set; }
        public DateTime? ThoiGian_TC1 { get; set; }
        public string LieuTC_TC1 { get; set; }
        public DateTime? ThoiGian_TC2 { get; set; }
        public string LieuTC_TC2 { get; set; }
        public DateTime? ThoiGian_TC3 { get; set; }
        public string LieuTC_TC3 { get; set; }
        public DateTime? ThoiGian_TC4 { get; set; }
        public string LieuTC_TC4 { get; set; }
        public DateTime? ThoiGian_TC5 { get; set; }
        public string LieuTC_TC5 { get; set; }
        public DateTime? ThoiGian_TC6 { get; set; }
        public string LieuTC_TC6 { get; set; }
        public string MoTaKT { get; set; }
        public string TenKTVBS { get; set; }
        public string MaKTVBS { get; set; }
        public DateTime? ThoiGian_TBS1 { get; set; }
        public string LieuTC_TBS1 { get; set; }
        public DateTime? ThoiGian_TBS2 { get; set; }
        public string LieuTC_TBS2 { get; set; }
        public DateTime? ThoiGian_TBS3 { get; set; }
        public string LieuTC_TBS3 { get; set; }
        public string KyTen { get; set; }
        public string TenKyTen
        {
            get
            {
                string Name = "";
                try
                {
                    var item = NhanVienFunc.ListNhanVien.Where(x => x.MaNhanVien.Equals(Common.ConDBNull(KyTen))).FirstOrDefault();
                    if (item != null)
                    {
                        Name = item.HoVaTen;
                    }
                }
                finally
                {

                }
                return Name;


            }
        }
        [MoTaDuLieu("Chọn", null, 0, 0)]
		public bool Chon { get; set; }
        public string MaSoKyTen { get; set; }
        [MoTaDuLieu("Đã ký", null, 0, 0)]
		public bool DaKy { get; set; }
        public int Cnt { get; set; }
    }
    public class HoSoTriXaFunc
    {
        static Logger log = LogManager.GetLogger("Log");
        public const string TableName = "HoSoTriXa_ChiTiet";
        public const string TableNameDM = "HoSoTriXa";
        public const string TablePrimaryKeyName = "IDPhieu";
        public const string MaPhieu = "HSTX";

        public static List<ThuocPha> DanhSachThuocPha = new List<ThuocPha>();


        public List<HoSoTriXa> Select(MDB.MDBConnection MyConnection, string MaQuanLy)
        {
            try
            {
                {
                    List<HoSoTriXa> listResult = new List<HoSoTriXa>();
                    string sql = @"SELECT t.*
                    FROM HoSoTriXa t
                    WHERE t.MaQuanLy = :MaQuanLy "; 
                    sql = sql + "ORDER BY t.NgaySua DESC";
                    MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
                    Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", MaQuanLy));
                    MDB.MDBDataReader DataReader = Command.ExecuteReader();
                    while (DataReader.Read())
                    {
                        var obj = new HoSoTriXa();
                        obj.IDPhieu = DataReader.GetDecimal("IDPhieu");
                        obj.MaQuanLy = DataReader.GetDecimal("MaQuanLy");
                        obj.TenKhoa = Common.ConDBNull(DataReader["TenKhoa"]);
                        obj.MaBenhAn = Common.ConDBNull(DataReader["MaBenhAn"]);
                        obj.MaBenhNhan = Common.ConDBNull(DataReader["MaBenhNhan"]);
                        obj.DiaChi = Common.ConDBNull(DataReader["DiaChi"]);
                        obj.SoPhieu = Common.ConDBNull(DataReader["SoPhieu"]);
                        obj.MaKhoa = Common.ConDBNull(DataReader["MaKhoa"]);
                        obj.Buong = Common.ConDBNull(DataReader["Buong"]);
                        obj.Giuong = Common.ConDBNull(DataReader["Giuong"]);
                        obj.MaGiuong = Common.ConDBNull(DataReader["MaGiuong"]);
                        obj.ChanDoan = Common.ConDBNull(DataReader["ChanDoan"]);
                        obj.ChanDoanGPBL = Common.ConDBNull(DataReader["ChanDoanGPBL"]);
                        obj.MDTX = Common.ConDBNull(DataReader["MDTX"]);
                        obj.MDTX_Txt1 = Common.ConDBNull(DataReader["MDTX_Txt1"]);
                        obj.MDTX_Txt2 = Common.ConDBNull(DataReader["MDTX_Txt2"]);
                        obj.MDTX_Txt3 = Common.ConDBNull(DataReader["MDTX_Txt3"]);
                        obj.Photon = Common.ConDBNull(DataReader["Photon"]);
                        obj.Electron = Common.ConDBNull(DataReader["Electron"]);
                        obj.TongLieuTC = Common.ConDBNull(DataReader["TongLieuTC"]);
                        obj.LieuTC1 = Common.ConDBNull(DataReader["LieuTC1"]);
                        obj.LieuTC2 = Common.ConDBNull(DataReader["LieuTC2"]);
                        obj.LieuTC3 = Common.ConDBNull(DataReader["LieuTC3"]);
                        obj.NgayThucHien = Common.ConDB_DateTimeNull(DataReader["NgayThucHien"]);
                        obj.NgayVaoVien = Common.ConDB_DateTimeNull(DataReader["NgayVaoVien"]);
                        obj.NgayRaVien = Common.ConDB_DateTimeNull(DataReader["NgayRaVien"]);
                        obj.MaKTV = Common.ConDBNull(DataReader["MaKTV"]);
                        obj.TenKTV = Common.ConDBNull(DataReader["TenKTV"]);
                        obj.MaBacSyDT = Common.ConDBNull(DataReader["MaBacSyDT"]);
                        obj.TenBacSyDT = Common.ConDBNull(DataReader["TenBacSyDT"]);
                        obj.SSD_TC1 = Common.ConDBNull(DataReader["SSD_TC1"]);
                        obj.SAD_TC1 = Common.ConDBNull(DataReader["SAD_TC1"]);
                        obj.ThanMay_TC1 = Common.ConDBNull(DataReader["ThanMay_TC1"]);
                        obj.Colli_TC1 = Common.ConDBNull(DataReader["Colli_TC1"]);
                        obj.Giuong_TC1 = Common.ConDBNull(DataReader["Giuong_TC1"]);
                        obj.LocNem_TC1 = Common.ConDBNull(DataReader["LocNem_TC1"]);
                        obj.CheTri_TC1 = Common.ConDBNull(DataReader["CheTri_TC1"]);
                        obj.SSD_TC2 = Common.ConDBNull(DataReader["SSD_TC2"]);
                        obj.SAD_TC2 = Common.ConDBNull(DataReader["SAD_TC2"]);
                        obj.ThanMay_TC2 = Common.ConDBNull(DataReader["ThanMay_TC2"]);
                        obj.Colli_TC2 = Common.ConDBNull(DataReader["Colli_TC2"]);
                        obj.Giuong_TC2 = Common.ConDBNull(DataReader["Giuong_TC2"]);
                        obj.LocNem_TC2 = Common.ConDBNull(DataReader["LocNem_TC2"]);
                        obj.CheTri_TC2 = Common.ConDBNull(DataReader["CheTri_TC2"]);
                        obj.SSD_TC3 = Common.ConDBNull(DataReader["SSD_TC3"]);
                        obj.SAD_TC3 = Common.ConDBNull(DataReader["SAD_TC3"]);
                        obj.ThanMay_TC3 = Common.ConDBNull(DataReader["ThanMay_TC3"]);
                        obj.Colli_TC3 = Common.ConDBNull(DataReader["Colli_TC3"]);
                        obj.Giuong_TC3 = Common.ConDBNull(DataReader["Giuong_TC3"]);
                        obj.LocNem_TC3 = Common.ConDBNull(DataReader["LocNem_TC3"]);
                        obj.CheTri_TC3 = Common.ConDBNull(DataReader["CheTri_TC3"]);
                        obj.SSD_TC4 = Common.ConDBNull(DataReader["SSD_TC4"]);
                        obj.SAD_TC4 = Common.ConDBNull(DataReader["SAD_TC4"]);
                        obj.ThanMay_TC4 = Common.ConDBNull(DataReader["ThanMay_TC4"]);
                        obj.Colli_TC4 = Common.ConDBNull(DataReader["Colli_TC4"]);
                        obj.Giuong_TC4 = Common.ConDBNull(DataReader["Giuong_TC4"]);
                        obj.LocNem_TC4 = Common.ConDBNull(DataReader["LocNem_TC4"]);
                        obj.CheTri_TC4 = Common.ConDBNull(DataReader["CheTri_TC4"]);
                        obj.SSD_TC5 = Common.ConDBNull(DataReader["SSD_TC5"]);
                        obj.SAD_TC5 = Common.ConDBNull(DataReader["SAD_TC5"]);
                        obj.ThanMay_TC5 = Common.ConDBNull(DataReader["ThanMay_TC5"]);
                        obj.Colli_TC5 = Common.ConDBNull(DataReader["Colli_TC5"]);
                        obj.Giuong_TC5 = Common.ConDBNull(DataReader["Giuong_TC5"]);
                        obj.LocNem_TC5 = Common.ConDBNull(DataReader["LocNem_TC5"]);
                        obj.CheTri_TC5 = Common.ConDBNull(DataReader["CheTri_TC5"]);
                        obj.SSD_TC6 = Common.ConDBNull(DataReader["SSD_TC6"]);
                        obj.SAD_TC6 = Common.ConDBNull(DataReader["SAD_TC6"]);
                        obj.ThanMay_TC6 = Common.ConDBNull(DataReader["ThanMay_TC6"]);
                        obj.Colli_TC6 = Common.ConDBNull(DataReader["Colli_TC6"]);
                        obj.Giuong_TC6 = Common.ConDBNull(DataReader["Giuong_TC6"]);
                        obj.LocNem_TC6 = Common.ConDBNull(DataReader["LocNem_TC6"]);
                        obj.CheTri_TC6 = Common.ConDBNull(DataReader["CheTri_TC6"]);
                        obj.SSD_TBS1 = Common.ConDBNull(DataReader["SSD_TBS1"]);
                        obj.SAD_TBS1 = Common.ConDBNull(DataReader["SAD_TBS1"]);
                        obj.ThanMay_TBS1 = Common.ConDBNull(DataReader["ThanMay_TBS1"]);
                        obj.Colli_TBS1 = Common.ConDBNull(DataReader["Colli_TBS1"]);
                        obj.Giuong_TBS1 = Common.ConDBNull(DataReader["Giuong_TBS1"]);
                        obj.LocNem_TBS1 = Common.ConDBNull(DataReader["LocNem_TBS1"]);
                        obj.CheTri_TBS1 = Common.ConDBNull(DataReader["CheTri_TBS1"]);
                        obj.SSD_TBS2 = Common.ConDBNull(DataReader["SSD_TBS2"]);
                        obj.SAD_TBS2 = Common.ConDBNull(DataReader["SAD_TBS2"]);
                        obj.ThanMay_TBS2 = Common.ConDBNull(DataReader["ThanMay_TBS2"]);
                        obj.Colli_TBS2 = Common.ConDBNull(DataReader["Colli_TBS2"]);
                        obj.Giuong_TBS2 = Common.ConDBNull(DataReader["Giuong_TBS2"]);
                        obj.LocNem_TBS2 = Common.ConDBNull(DataReader["LocNem_TBS2"]);
                        obj.CheTri_TBS2 = Common.ConDBNull(DataReader["CheTri_TBS2"]);
                        obj.SSD_TBS3 = Common.ConDBNull(DataReader["SSD_TBS3"]);
                        obj.SAD_TBS3 = Common.ConDBNull(DataReader["SAD_TBS3"]);
                        obj.ThanMay_TBS3 = Common.ConDBNull(DataReader["ThanMay_TBS3"]);
                        obj.Colli_TBS3 = Common.ConDBNull(DataReader["Colli_TBS3"]);
                        obj.Giuong_TBS3 = Common.ConDBNull(DataReader["Giuong_TBS3"]);
                        obj.LocNem_TBS3 = Common.ConDBNull(DataReader["LocNem_TBS3"]);
                        obj.CheTri_TBS3 = Common.ConDBNull(DataReader["CheTri_TBS3"]);
                        obj.HCVL = Common.ConDBNull(DataReader["HCVL"]);
                        obj.NXSauDT = Common.ConDBNull(DataReader["NXSauDT"]);
                        obj.NguoiTao = Common.ConDBNull(DataReader["NguoiTao"]);
                        obj.NgayTao = Common.ConDB_DateTime(DataReader["NgayTao"]);
                        obj.NguoiSua = Common.ConDBNull(DataReader["NguoiSua"]);
                        obj.NgaySua = Common.ConDB_DateTime(DataReader["NgaySua"]);
                        obj.TTTXChiTiet = new List<HoSoTriXa_ChiTiet>();
                        obj.TTTXChiTiet = Select_PhieuChiTiet(MyConnection, obj.IDPhieu.ToString());
                        obj.MaSoKy = DataReader["masokyten"].ToString();
                        obj.DaKy = !string.IsNullOrEmpty(obj.MaSoKy) ? true : false;
                        listResult.Add(obj);
                    }
                    return listResult;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public bool Insert(MDB.MDBConnection MyConnection, HoSoTriXa obj)
        {
            try
            {
                //using (MDB.MDBConnection MyConnection = new MDB.MDBConnection(ERMDatabase.ConnectionString))
                {


                    string sql = @"INSERT INTO HoSoTriXa (
                        MaQuanLy,
                        TenKhoa,
                        MaBenhAn,
                        MaBenhNhan,
                        DiaChi,
                        SoPhieu,
                        MaKhoa,
                        Buong,
                        Giuong,
                        MaGiuong,
                        ChanDoan,
                        ChanDoanGPBL,
                        MDTX,
                        MDTX_Txt1,
                        MDTX_Txt2,
                        MDTX_Txt3,
                        Photon,
                        Electron,
                        TongLieuTC,
                        LieuTC1,
                        LieuTC2,
                        LieuTC3,
                        NgayVaoVien,NgayThucHien,
                        NgayRaVien,
                        MaKTV,
                        TenKTV,
                        MaBacSyDT,
                        TenBacSyDT,
                        SSD_TC1,
                        SAD_TC1,
                        ThanMay_TC1,
                        Colli_TC1,
                        Giuong_TC1,
                        LocNem_TC1,
                        CheTri_TC1,
                        SSD_TC2,
                        SAD_TC2,
                        ThanMay_TC2,
                        Colli_TC2,
                        Giuong_TC2,
                        LocNem_TC2,
                        CheTri_TC2,
                        SSD_TC3,
                        SAD_TC3,
                        ThanMay_TC3,
                        Colli_TC3,
                        Giuong_TC3,
                        LocNem_TC3,
                        CheTri_TC3,
                        SSD_TC4,
                        SAD_TC4,
                        ThanMay_TC4,
                        Colli_TC4,
                        Giuong_TC4,
                        LocNem_TC4,
                        CheTri_TC4,
                        SSD_TC5,
                        SAD_TC5,
                        ThanMay_TC5,
                        Colli_TC5,
                        Giuong_TC5,
                        LocNem_TC5,
                        CheTri_TC5,
                        SSD_TC6,
                        SAD_TC6,
                        ThanMay_TC6,
                        Colli_TC6,
                        Giuong_TC6,
                        LocNem_TC6,
                        CheTri_TC6,
                        SSD_TBS1,
                        SAD_TBS1,
                        ThanMay_TBS1,
                        Colli_TBS1,
                        Giuong_TBS1,
                        LocNem_TBS1,
                        CheTri_TBS1,
                        SSD_TBS2,
                        SAD_TBS2,
                        ThanMay_TBS2,
                        Colli_TBS2,
                        Giuong_TBS2,
                        LocNem_TBS2,
                        CheTri_TBS2,
                        SSD_TBS3,
                        SAD_TBS3,
                        ThanMay_TBS3,
                        Colli_TBS3,
                        Giuong_TBS3,
                        LocNem_TBS3,
                        CheTri_TBS3,
                        HCVL,
                        NXSauDT,
                        NguoiTao,
                        NgayTao,
                        NguoiSua,
                        NgaySua
                        ) 
                        VALUES (
                        :MaQuanLy,
                        :TenKhoa,
                        :MaBenhAn,
                        :MaBenhNhan,
                        :DiaChi,
                        :SoPhieu,
                        :MaKhoa,
                        :Buong,
                        :Giuong,
                        :MaGiuong,
                        :ChanDoan,
                        :ChanDoanGPBL,
                        :MDTX,
                        :MDTX_Txt1,
                        :MDTX_Txt2,
                        :MDTX_Txt3,
                        :Photon,
                        :Electron,
                        :TongLieuTC,
                        :LieuTC1,
                        :LieuTC2,
                        :LieuTC3,
                        :NgayVaoVien,:NgayThucHien,
                        :NgayRaVien,
                        :MaKTV,
                        :TenKTV,
                        :MaBacSyDT,
                        :TenBacSyDT,
                        :SSD_TC1,
                        :SAD_TC1,
                        :ThanMay_TC1,
                        :Colli_TC1,
                        :Giuong_TC1,
                        :LocNem_TC1,
                        :CheTri_TC1,
                        :SSD_TC2,
                        :SAD_TC2,
                        :ThanMay_TC2,
                        :Colli_TC2,
                        :Giuong_TC2,
                        :LocNem_TC2,
                        :CheTri_TC2,
                        :SSD_TC3,
                        :SAD_TC3,
                        :ThanMay_TC3,
                        :Colli_TC3,
                        :Giuong_TC3,
                        :LocNem_TC3,
                        :CheTri_TC3,
                        :SSD_TC4,
                        :SAD_TC4,
                        :ThanMay_TC4,
                        :Colli_TC4,
                        :Giuong_TC4,
                        :LocNem_TC4,
                        :CheTri_TC4,
                        :SSD_TC5,
                        :SAD_TC5,
                        :ThanMay_TC5,
                        :Colli_TC5,
                        :Giuong_TC5,
                        :LocNem_TC5,
                        :CheTri_TC5,
                        :SSD_TC6,
                        :SAD_TC6,
                        :ThanMay_TC6,
                        :Colli_TC6,
                        :Giuong_TC6,
                        :LocNem_TC6,
                        :CheTri_TC6,
                        :SSD_TBS1,
                        :SAD_TBS1,
                        :ThanMay_TBS1,
                        :Colli_TBS1,
                        :Giuong_TBS1,
                        :LocNem_TBS1,
                        :CheTri_TBS1,
                        :SSD_TBS2,
                        :SAD_TBS2,
                        :ThanMay_TBS2,
                        :Colli_TBS2,
                        :Giuong_TBS2,
                        :LocNem_TBS2,
                        :CheTri_TBS2,
                        :SSD_TBS3,
                        :SAD_TBS3,
                        :ThanMay_TBS3,
                        :Colli_TBS3,
                        :Giuong_TBS3,
                        :LocNem_TBS3,
                        :CheTri_TBS3,
                        :HCVL,
                        :NXSauDT,
                        :NguoiTao,
                        :NgayTao,
                        :NguoiSua,
                        :NgaySua
                                )";
                    MDB.MDBCommand oracleCommand = new MDB.MDBCommand(sql, MyConnection);
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("MaQuanLy", obj.MaQuanLy));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("TenKhoa", obj.TenKhoa));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("MaBenhAn", obj.MaBenhAn));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("MaBenhNhan", obj.MaBenhNhan));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("DiaChi", obj.DiaChi));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("SoPhieu", obj.SoPhieu));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("MaKhoa", obj.MaKhoa));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("Buong", obj.Buong));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("Giuong", obj.Giuong));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("MaGiuong", obj.MaGiuong));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("ChanDoan", obj.ChanDoan));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("ChanDoanGPBL", obj.ChanDoanGPBL));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("MDTX", obj.MDTX));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("MDTX_Txt1", obj.MDTX_Txt1));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("MDTX_Txt2", obj.MDTX_Txt2));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("MDTX_Txt3", obj.MDTX_Txt3));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("Photon", obj.Photon));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("Electron", obj.Electron));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("TongLieuTC", obj.TongLieuTC));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("LieuTC1", obj.LieuTC1));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("LieuTC2", obj.LieuTC2));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("LieuTC3", obj.LieuTC3));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("NgayVaoVien", obj.NgayVaoVien));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("NgayThucHien", obj.NgayThucHien));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("NgayRaVien", obj.NgayRaVien));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("MaKTV", obj.MaKTV));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("TenKTV", obj.TenKTV));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("MaBacSyDT", obj.MaBacSyDT));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("TenBacSyDT", obj.TenBacSyDT));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("SSD_TC1", obj.SSD_TC1));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("SAD_TC1", obj.SAD_TC1));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("ThanMay_TC1", obj.ThanMay_TC1));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("Colli_TC1", obj.Colli_TC1));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("Giuong_TC1", obj.Giuong_TC1));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("LocNem_TC1", obj.LocNem_TC1));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("CheTri_TC1", obj.CheTri_TC1));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("SSD_TC2", obj.SSD_TC2));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("SAD_TC2", obj.SAD_TC2));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("ThanMay_TC2", obj.ThanMay_TC2));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("Colli_TC2", obj.Colli_TC2));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("Giuong_TC2", obj.Giuong_TC2));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("LocNem_TC2", obj.LocNem_TC2));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("CheTri_TC2", obj.CheTri_TC2));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("SSD_TC3", obj.SSD_TC3));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("SAD_TC3", obj.SAD_TC3));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("ThanMay_TC3", obj.ThanMay_TC3));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("Colli_TC3", obj.Colli_TC3));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("Giuong_TC3", obj.Giuong_TC3));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("LocNem_TC3", obj.LocNem_TC3));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("CheTri_TC3", obj.CheTri_TC3));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("SSD_TC4", obj.SSD_TC4));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("SAD_TC4", obj.SAD_TC4));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("ThanMay_TC4", obj.ThanMay_TC4));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("Colli_TC4", obj.Colli_TC4));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("Giuong_TC4", obj.Giuong_TC4));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("LocNem_TC4", obj.LocNem_TC4));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("CheTri_TC4", obj.CheTri_TC4));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("SSD_TC5", obj.SSD_TC5));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("SAD_TC5", obj.SAD_TC5));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("ThanMay_TC5", obj.ThanMay_TC5));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("Colli_TC5", obj.Colli_TC5));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("Giuong_TC5", obj.Giuong_TC5));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("LocNem_TC5", obj.LocNem_TC5));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("CheTri_TC5", obj.CheTri_TC5));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("SSD_TC6", obj.SSD_TC6));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("SAD_TC6", obj.SAD_TC6));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("ThanMay_TC6", obj.ThanMay_TC6));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("Colli_TC6", obj.Colli_TC6));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("Giuong_TC6", obj.Giuong_TC6));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("LocNem_TC6", obj.LocNem_TC6));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("CheTri_TC6", obj.CheTri_TC6));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("SSD_TBS1", obj.SSD_TBS1));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("SAD_TBS1", obj.SAD_TBS1));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("ThanMay_TBS1", obj.ThanMay_TBS1));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("Colli_TBS1", obj.Colli_TBS1));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("Giuong_TBS1", obj.Giuong_TBS1));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("LocNem_TBS1", obj.LocNem_TBS1));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("CheTri_TBS1", obj.CheTri_TBS1));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("SSD_TBS2", obj.SSD_TBS2));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("SAD_TBS2", obj.SAD_TBS2));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("ThanMay_TBS2", obj.ThanMay_TBS2));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("Colli_TBS2", obj.Colli_TBS2));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("Giuong_TBS2", obj.Giuong_TBS2));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("LocNem_TBS2", obj.LocNem_TBS2));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("CheTri_TBS2", obj.CheTri_TBS2));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("SSD_TBS3", obj.SSD_TBS3));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("SAD_TBS3", obj.SAD_TBS3));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("ThanMay_TBS3", obj.ThanMay_TBS3));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("Colli_TBS3", obj.Colli_TBS3));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("Giuong_TBS3", obj.Giuong_TBS3));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("LocNem_TBS3", obj.LocNem_TBS3));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("CheTri_TBS3", obj.CheTri_TBS3));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("HCVL", obj.HCVL));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("NXSauDT", obj.NXSauDT));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("NguoiTao", Common.getUserLogin()));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("NgayTao", DateTime.Now));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("NguoiSua", Common.getUserLogin()));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("NgaySua", DateTime.Now));
                    int n = oracleCommand.ExecuteNonQuery();
                    return n > 0 ? true : false;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public bool Update(MDB.MDBConnection MyConnection, HoSoTriXa obj)
        {
            try
            {
                //using (MDB.MDBConnection MyConnection = new MDB.MDBConnection(ERMDatabase.ConnectionString))
                {

                    string sql = @"UPDATE HoSoTriXa SET 
                        MaQuanLy=:MaQuanLy,
                        TenKhoa=:TenKhoa,
                        MaBenhAn=:MaBenhAn,
                        MaBenhNhan=:MaBenhNhan,
                        DiaChi=:DiaChi,
                        SoPhieu=:SoPhieu,
                        MaKhoa=:MaKhoa,
                        Buong=:Buong,
                        Giuong=:Giuong,
                        MaGiuong=:MaGiuong,
                        ChanDoan=:ChanDoan,
                        ChanDoanGPBL=:ChanDoanGPBL,
                        MDTX=:MDTX,
                        MDTX_Txt1=:MDTX_Txt1,
                        MDTX_Txt2=:MDTX_Txt2,
                        MDTX_Txt3=:MDTX_Txt3,
                        Photon=:Photon,
                        Electron=:Electron,
                        TongLieuTC=:TongLieuTC,
                        LieuTC1=:LieuTC1,
                        LieuTC2=:LieuTC2,
                        LieuTC3=:LieuTC3,
                        NgayVaoVien=:NgayVaoVien,NgayThucHien=:NgayThucHien,
                        NgayRaVien=:NgayRaVien,
                        MaKTV=:MaKTV,
                        TenKTV=:TenKTV,
                        MaBacSyDT=:MaBacSyDT,
                        TenBacSyDT=:TenBacSyDT,
                        SSD_TC1=:SSD_TC1,
                        SAD_TC1=:SAD_TC1,
                        ThanMay_TC1=:ThanMay_TC1,
                        Colli_TC1=:Colli_TC1,
                        Giuong_TC1=:Giuong_TC1,
                        LocNem_TC1=:LocNem_TC1,
                        CheTri_TC1=:CheTri_TC1,
                        SSD_TC2=:SSD_TC2,
                        SAD_TC2=:SAD_TC2,
                        ThanMay_TC2=:ThanMay_TC2,
                        Colli_TC2=:Colli_TC2,
                        Giuong_TC2=:Giuong_TC2,
                        LocNem_TC2=:LocNem_TC2,
                        CheTri_TC2=:CheTri_TC2,
                        SSD_TC3=:SSD_TC3,
                        SAD_TC3=:SAD_TC3,
                        ThanMay_TC3=:ThanMay_TC3,
                        Colli_TC3=:Colli_TC3,
                        Giuong_TC3=:Giuong_TC3,
                        LocNem_TC3=:LocNem_TC3,
                        CheTri_TC3=:CheTri_TC3,
                        SSD_TC4=:SSD_TC4,
                        SAD_TC4=:SAD_TC4,
                        ThanMay_TC4=:ThanMay_TC4,
                        Colli_TC4=:Colli_TC4,
                        Giuong_TC4=:Giuong_TC4,
                        LocNem_TC4=:LocNem_TC4,
                        CheTri_TC4=:CheTri_TC4,
                        SSD_TC5=:SSD_TC5,
                        SAD_TC5=:SAD_TC5,
                        ThanMay_TC5=:ThanMay_TC5,
                        Colli_TC5=:Colli_TC5,
                        Giuong_TC5=:Giuong_TC5,
                        LocNem_TC5=:LocNem_TC5,
                        CheTri_TC5=:CheTri_TC5,
                        SSD_TC6=:SSD_TC6,
                        SAD_TC6=:SAD_TC6,
                        ThanMay_TC6=:ThanMay_TC6,
                        Colli_TC6=:Colli_TC6,
                        Giuong_TC6=:Giuong_TC6,
                        LocNem_TC6=:LocNem_TC6,
                        CheTri_TC6=:CheTri_TC6,
                        SSD_TBS1=:SSD_TBS1,
                        SAD_TBS1=:SAD_TBS1,
                        ThanMay_TBS1=:ThanMay_TBS1,
                        Colli_TBS1=:Colli_TBS1,
                        Giuong_TBS1=:Giuong_TBS1,
                        LocNem_TBS1=:LocNem_TBS1,
                        CheTri_TBS1=:CheTri_TBS1,
                        SSD_TBS2=:SSD_TBS2,
                        SAD_TBS2=:SAD_TBS2,
                        ThanMay_TBS2=:ThanMay_TBS2,
                        Colli_TBS2=:Colli_TBS2,
                        Giuong_TBS2=:Giuong_TBS2,
                        LocNem_TBS2=:LocNem_TBS2,
                        CheTri_TBS2=:CheTri_TBS2,
                        SSD_TBS3=:SSD_TBS3,
                        SAD_TBS3=:SAD_TBS3,
                        ThanMay_TBS3=:ThanMay_TBS3,
                        Colli_TBS3=:Colli_TBS3,
                        Giuong_TBS3=:Giuong_TBS3,
                        LocNem_TBS3=:LocNem_TBS3,
                        CheTri_TBS3=:CheTri_TBS3,
                        HCVL=:HCVL,
                        NXSauDT=:NXSauDT,
                        NguoiSua=:NguoiSua,
                        NgaySua=:NgaySua
                        WHERE IDPhieu = " + obj.IDPhieu;
                    MDB.MDBCommand oracleCommand = new MDB.MDBCommand(sql, MyConnection);
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("MaQuanLy", obj.MaQuanLy));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("TenKhoa", obj.TenKhoa));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("MaBenhAn", obj.MaBenhAn));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("MaBenhNhan", obj.MaBenhNhan));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("DiaChi", obj.DiaChi));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("SoPhieu", obj.SoPhieu));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("MaKhoa", obj.MaKhoa));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("Buong", obj.Buong));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("Giuong", obj.Giuong));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("MaGiuong", obj.MaGiuong));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("ChanDoan", obj.ChanDoan));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("ChanDoanGPBL", obj.ChanDoanGPBL));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("MDTX", obj.MDTX));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("MDTX_Txt1", obj.MDTX_Txt1));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("MDTX_Txt2", obj.MDTX_Txt2));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("MDTX_Txt3", obj.MDTX_Txt3));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("Photon", obj.Photon));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("Electron", obj.Electron));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("TongLieuTC", obj.TongLieuTC));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("LieuTC1", obj.LieuTC1));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("LieuTC2", obj.LieuTC2));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("LieuTC3", obj.LieuTC3));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("NgayVaoVien", obj.NgayVaoVien));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("NgayThucHien", obj.NgayThucHien));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("NgayRaVien", obj.NgayRaVien));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("MaKTV", obj.MaKTV));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("TenKTV", obj.TenKTV));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("MaBacSyDT", obj.MaBacSyDT));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("TenBacSyDT", obj.TenBacSyDT));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("SSD_TC1", obj.SSD_TC1));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("SAD_TC1", obj.SAD_TC1));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("ThanMay_TC1", obj.ThanMay_TC1));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("Colli_TC1", obj.Colli_TC1));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("Giuong_TC1", obj.Giuong_TC1));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("LocNem_TC1", obj.LocNem_TC1));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("CheTri_TC1", obj.CheTri_TC1));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("SSD_TC2", obj.SSD_TC2));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("SAD_TC2", obj.SAD_TC2));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("ThanMay_TC2", obj.ThanMay_TC2));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("Colli_TC2", obj.Colli_TC2));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("Giuong_TC2", obj.Giuong_TC2));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("LocNem_TC2", obj.LocNem_TC2));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("CheTri_TC2", obj.CheTri_TC2));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("SSD_TC3", obj.SSD_TC3));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("SAD_TC3", obj.SAD_TC3));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("ThanMay_TC3", obj.ThanMay_TC3));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("Colli_TC3", obj.Colli_TC3));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("Giuong_TC3", obj.Giuong_TC3));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("LocNem_TC3", obj.LocNem_TC3));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("CheTri_TC3", obj.CheTri_TC3));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("SSD_TC4", obj.SSD_TC4));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("SAD_TC4", obj.SAD_TC4));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("ThanMay_TC4", obj.ThanMay_TC4));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("Colli_TC4", obj.Colli_TC4));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("Giuong_TC4", obj.Giuong_TC4));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("LocNem_TC4", obj.LocNem_TC4));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("CheTri_TC4", obj.CheTri_TC4));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("SSD_TC5", obj.SSD_TC5));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("SAD_TC5", obj.SAD_TC5));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("ThanMay_TC5", obj.ThanMay_TC5));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("Colli_TC5", obj.Colli_TC5));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("Giuong_TC5", obj.Giuong_TC5));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("LocNem_TC5", obj.LocNem_TC5));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("CheTri_TC5", obj.CheTri_TC5));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("SSD_TC6", obj.SSD_TC6));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("SAD_TC6", obj.SAD_TC6));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("ThanMay_TC6", obj.ThanMay_TC6));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("Colli_TC6", obj.Colli_TC6));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("Giuong_TC6", obj.Giuong_TC6));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("LocNem_TC6", obj.LocNem_TC6));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("CheTri_TC6", obj.CheTri_TC6));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("SSD_TBS1", obj.SSD_TBS1));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("SAD_TBS1", obj.SAD_TBS1));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("ThanMay_TBS1", obj.ThanMay_TBS1));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("Colli_TBS1", obj.Colli_TBS1));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("Giuong_TBS1", obj.Giuong_TBS1));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("LocNem_TBS1", obj.LocNem_TBS1));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("CheTri_TBS1", obj.CheTri_TBS1));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("SSD_TBS2", obj.SSD_TBS2));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("SAD_TBS2", obj.SAD_TBS2));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("ThanMay_TBS2", obj.ThanMay_TBS2));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("Colli_TBS2", obj.Colli_TBS2));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("Giuong_TBS2", obj.Giuong_TBS2));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("LocNem_TBS2", obj.LocNem_TBS2));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("CheTri_TBS2", obj.CheTri_TBS2));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("SSD_TBS3", obj.SSD_TBS3));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("SAD_TBS3", obj.SAD_TBS3));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("ThanMay_TBS3", obj.ThanMay_TBS3));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("Colli_TBS3", obj.Colli_TBS3));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("Giuong_TBS3", obj.Giuong_TBS3));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("LocNem_TBS3", obj.LocNem_TBS3));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("CheTri_TBS3", obj.CheTri_TBS3));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("HCVL", obj.HCVL));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("NXSauDT", obj.NXSauDT));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("NguoiSua", Common.getUserLogin()));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("NgaySua", DateTime.Now));
                    int n = oracleCommand.ExecuteNonQuery();

                    return n > 0 ? true : false;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public bool Delete(MDB.MDBConnection MyConnection, decimal IDPhieu)
        {
            try
            {
                if (IDPhieu != 0)
                {
                    string sql = @"Delete HoSoTriXa 
                                WHERE 
                                (IDPhieu = :IDPhieu) ";
                    MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
                    Command.Parameters.Add(new MDB.MDBParameter(":IDPhieu", IDPhieu));
                    int n = Command.ExecuteNonQuery();
                    Command.Dispose();
                    sql = @"Delete HoSoTriXa_ChiTiet 
                                WHERE 
                                (IDPhieu = :IDPhieu) ";
                    Command = new MDB.MDBCommand(sql, MyConnection);
                    Command.Parameters.Add(new MDB.MDBParameter(":IDPhieu", IDPhieu));
                    n = Command.ExecuteNonQuery();

                    return true;
                }

            }
            catch (Exception ex)
            {
                XuLyLoi.Handle(ex);
            }
            return false;
        }
        public bool Delete_ChiTiet(MDB.MDBConnection MyConnection, decimal ID)
        {
            try
            {
                if (ID != 0)
                {
                    string sql = @"Delete HoSoTriXa_ChiTiet 
                                WHERE 
                                (ID = :ID) ";
                    MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
                    Command.Parameters.Add(new MDB.MDBParameter(":ID", ID));
                    int n = Command.ExecuteNonQuery();

                    return true;
                }

            }
            catch (Exception ex)
            {
                XuLyLoi.Handle(ex);
            }
            return false;
        }
        public List<HoSoTriXa_ChiTiet> Select_PhieuChiTiet(MDB.MDBConnection MyConnection, string IDPhieu, string lstStrID = null)
        {
            try
            {
                //using (MDB.MDBConnection MyConnection = new MDB.MDBConnection(ERMDatabase.ConnectionString))
                {
                    int idx = 0;
                    List<HoSoTriXa_ChiTiet> listResult = new List<HoSoTriXa_ChiTiet>();
                    StringBuilder sql = new StringBuilder();
                    sql.AppendLine("SELECT t.*");
                    sql.AppendLine("FROM HoSoTriXa_ChiTiet t");
                    sql.AppendLine("WHERE t.IDPhieu = :IDPhieu ");
                    if (!string.IsNullOrWhiteSpace(lstStrID))
                    {
                        sql.AppendLine(" and t.ID in (" + lstStrID + ")");
                    }
                    sql.AppendLine("ORDER BY t.ThoiGian DESC"); // datmc update get ThoiGianForMat24H
                    MDB.MDBCommand Command = new MDB.MDBCommand(sql.ToString(), MyConnection);
                    Command.Parameters.Add(new MDB.MDBParameter("IDPhieu", IDPhieu));
                    MDB.MDBDataReader DataReader = Command.ExecuteReader();
                    while (DataReader.Read())
                    {
                        var obj = new HoSoTriXa_ChiTiet();
                        obj.ID = Common.ConDB_Decimal(DataReader["ID"]);
                        obj.IDPhieu = Common.ConDB_Decimal(DataReader["IDPhieu"]);
                        obj.ThoiGian = Common.ConDB_DateTimeNull(DataReader["ThoiGian"]);
                        obj.TenKTV = Common.ConDBNull(DataReader["TenKTV"]);
                        obj.MaKTV = Common.ConDBNull(DataReader["MaKTV"]);
                        obj.ThoiGian_TC1 = Common.ConDB_DateTimeNull(DataReader["ThoiGian_TC1"]);
                        obj.LieuTC_TC1 = Common.ConDBNull(DataReader["LieuTC_TC1"]);
                        obj.ThoiGian_TC2 = Common.ConDB_DateTimeNull(DataReader["ThoiGian_TC2"]);
                        obj.LieuTC_TC2 = Common.ConDBNull(DataReader["LieuTC_TC2"]);
                        obj.ThoiGian_TC3 = Common.ConDB_DateTimeNull(DataReader["ThoiGian_TC3"]);
                        obj.LieuTC_TC3 = Common.ConDBNull(DataReader["LieuTC_TC3"]);
                        obj.ThoiGian_TC4 = Common.ConDB_DateTimeNull(DataReader["ThoiGian_TC4"]);
                        obj.LieuTC_TC4 = Common.ConDBNull(DataReader["LieuTC_TC4"]);
                        obj.ThoiGian_TC5 = Common.ConDB_DateTimeNull(DataReader["ThoiGian_TC5"]);
                        obj.LieuTC_TC5 = Common.ConDBNull(DataReader["LieuTC_TC5"]);
                        obj.ThoiGian_TC6 = Common.ConDB_DateTimeNull(DataReader["ThoiGian_TC6"]);
                        obj.LieuTC_TC6 = Common.ConDBNull(DataReader["LieuTC_TC6"]);
                        obj.MoTaKT = Common.ConDBNull(DataReader["MoTaKT"]);
                        obj.TenKTVBS = Common.ConDBNull(DataReader["TenKTVBS"]);
                        obj.MaKTVBS = Common.ConDBNull(DataReader["MaKTVBS"]);
                        obj.ThoiGian_TBS1 = Common.ConDB_DateTimeNull(DataReader["ThoiGian_TBS1"]);
                        obj.ThoiGianBS = Common.ConDB_DateTimeNull(DataReader["ThoiGianBS"]);
                        obj.LieuTC_TBS1 = Common.ConDBNull(DataReader["LieuTC_TBS1"]);
                        obj.ThoiGian_TBS2 = Common.ConDB_DateTimeNull(DataReader["ThoiGian_TBS2"]);
                        obj.LieuTC_TBS2 = Common.ConDBNull(DataReader["LieuTC_TBS2"]);
                        obj.ThoiGian_TBS3 = Common.ConDB_DateTimeNull(DataReader["ThoiGian_TBS3"]);
                        obj.LieuTC_TBS3 = Common.ConDBNull(DataReader["LieuTC_TBS3"]);
                        obj.KyTen = Common.ConDBNull(DataReader["KyTen"]);
                        obj.MaSoKyTen = DataReader["masokyten"].ToString();
                        obj.DaKy = !string.IsNullOrEmpty(obj.MaSoKyTen) ? true : false;
                        idx++;
                        obj.Cnt = idx;
                        listResult.Add(obj);
                    }
                    return listResult;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public bool InsertOrUpdate_ChiTiet(MDB.MDBConnection MyConnection, HoSoTriXa_ChiTiet obj)
        {
            string sql = @"update HoSoTriXa_ChiTiet set
                    IDPhieu=:IDPhieu,
                    ThoiGian=:ThoiGian,
                    TenKTV=:TenKTV,
                    MaKTV=:MaKTV,
                    ThoiGian_TC1=:ThoiGian_TC1,
                    LieuTC_TC1=:LieuTC_TC1,
                    ThoiGian_TC2=:ThoiGian_TC2,
                    LieuTC_TC2=:LieuTC_TC2,
                    ThoiGian_TC3=:ThoiGian_TC3,
                    LieuTC_TC3=:LieuTC_TC3,
                    ThoiGian_TC4=:ThoiGian_TC4,
                    LieuTC_TC4=:LieuTC_TC4,
                    ThoiGian_TC5=:ThoiGian_TC5,
                    LieuTC_TC5=:LieuTC_TC5,
                    ThoiGian_TC6=:ThoiGian_TC6,
                    LieuTC_TC6=:LieuTC_TC6,
                    MoTaKT=:MoTaKT,
                    TenKTVBS=:TenKTVBS,
                    MaKTVBS=:MaKTVBS,
                    ThoiGian_TBS1=:ThoiGian_TBS1,ThoiGianBS=:ThoiGianBS,
                    LieuTC_TBS1=:LieuTC_TBS1,
                    ThoiGian_TBS2=:ThoiGian_TBS2,
                    LieuTC_TBS2=:LieuTC_TBS2,
                    ThoiGian_TBS3=:ThoiGian_TBS3,
                    LieuTC_TBS3=:LieuTC_TBS3
                        WHERE ID = " + obj.ID + "";

            MDB.MDBCommand oracleCommand = new MDB.MDBCommand(sql, MyConnection);
            oracleCommand.Parameters.Add(new MDB.MDBParameter("IDPhieu", obj.IDPhieu));
            oracleCommand.Parameters.Add(new MDB.MDBParameter("ThoiGian", obj.ThoiGian));
            oracleCommand.Parameters.Add(new MDB.MDBParameter("TenKTV", obj.TenKTV));
            oracleCommand.Parameters.Add(new MDB.MDBParameter("MaKTV", obj.MaKTV));
            oracleCommand.Parameters.Add(new MDB.MDBParameter("ThoiGian_TC1", obj.ThoiGian_TC1));
            oracleCommand.Parameters.Add(new MDB.MDBParameter("LieuTC_TC1", obj.LieuTC_TC1));
            oracleCommand.Parameters.Add(new MDB.MDBParameter("ThoiGian_TC2", obj.ThoiGian_TC2));
            oracleCommand.Parameters.Add(new MDB.MDBParameter("LieuTC_TC2", obj.LieuTC_TC2));
            oracleCommand.Parameters.Add(new MDB.MDBParameter("ThoiGian_TC3", obj.ThoiGian_TC3));
            oracleCommand.Parameters.Add(new MDB.MDBParameter("LieuTC_TC3", obj.LieuTC_TC3));
            oracleCommand.Parameters.Add(new MDB.MDBParameter("ThoiGian_TC4", obj.ThoiGian_TC4));
            oracleCommand.Parameters.Add(new MDB.MDBParameter("LieuTC_TC4", obj.LieuTC_TC4));
            oracleCommand.Parameters.Add(new MDB.MDBParameter("ThoiGian_TC5", obj.ThoiGian_TC5));
            oracleCommand.Parameters.Add(new MDB.MDBParameter("LieuTC_TC5", obj.LieuTC_TC5));
            oracleCommand.Parameters.Add(new MDB.MDBParameter("ThoiGian_TC6", obj.ThoiGian_TC6));
            oracleCommand.Parameters.Add(new MDB.MDBParameter("LieuTC_TC6", obj.LieuTC_TC6));
            oracleCommand.Parameters.Add(new MDB.MDBParameter("MoTaKT", obj.MoTaKT));
            oracleCommand.Parameters.Add(new MDB.MDBParameter("TenKTVBS", obj.TenKTVBS));
            oracleCommand.Parameters.Add(new MDB.MDBParameter("MaKTVBS", obj.MaKTVBS));
            oracleCommand.Parameters.Add(new MDB.MDBParameter("ThoiGian_TBS1", obj.ThoiGian_TBS1));
            oracleCommand.Parameters.Add(new MDB.MDBParameter("ThoiGianBS", obj.ThoiGianBS));
            oracleCommand.Parameters.Add(new MDB.MDBParameter("LieuTC_TBS1", obj.LieuTC_TBS1));
            oracleCommand.Parameters.Add(new MDB.MDBParameter("ThoiGian_TBS2", obj.ThoiGian_TBS2));
            oracleCommand.Parameters.Add(new MDB.MDBParameter("LieuTC_TBS2", obj.LieuTC_TBS2));
            oracleCommand.Parameters.Add(new MDB.MDBParameter("ThoiGian_TBS3", obj.ThoiGian_TBS3));
            oracleCommand.Parameters.Add(new MDB.MDBParameter("LieuTC_TBS3", obj.LieuTC_TBS3));

            int n = oracleCommand.ExecuteNonQuery();
            if (n == 0)
            {
                oracleCommand.Dispose();
                sql = @"insert into HoSoTriXa_ChiTiet (
                    IDPhieu,
                    ThoiGian,
                    TenKTV,
                    MaKTV,
                    ThoiGian_TC1,
                    LieuTC_TC1,
                    ThoiGian_TC2,
                    LieuTC_TC2,
                    ThoiGian_TC3,
                    LieuTC_TC3,
                    ThoiGian_TC4,
                    LieuTC_TC4,
                    ThoiGian_TC5,
                    LieuTC_TC5,
                    ThoiGian_TC6,
                    LieuTC_TC6,
                    MoTaKT,
                    TenKTVBS,
                    MaKTVBS,
                    ThoiGian_TBS1,ThoiGianBS,
                    LieuTC_TBS1,
                    ThoiGian_TBS2,
                    LieuTC_TBS2,
                    ThoiGian_TBS3,
                    LieuTC_TBS3,
                    KyTen
                    ) values (
                    :IDPhieu,
                    :ThoiGian,
                    :TenKTV,
                    :MaKTV,
                    :ThoiGian_TC1,
                    :LieuTC_TC1,
                    :ThoiGian_TC2,
                    :LieuTC_TC2,
                    :ThoiGian_TC3,
                    :LieuTC_TC3,
                    :ThoiGian_TC4,
                    :LieuTC_TC4,
                    :ThoiGian_TC5,
                    :LieuTC_TC5,
                    :ThoiGian_TC6,
                    :LieuTC_TC6,
                    :MoTaKT,
                    :TenKTVBS,
                    :MaKTVBS,
                    :ThoiGian_TBS1,:ThoiGianBS,
                    :LieuTC_TBS1,
                    :ThoiGian_TBS2,
                    :LieuTC_TBS2,
                    :ThoiGian_TBS3,
                    :LieuTC_TBS3,
                    :KyTen
                    ) RETURNING ID INTO :ID";
                oracleCommand = new MDB.MDBCommand(sql, MyConnection);
                oracleCommand.Parameters.Add(new MDB.MDBParameter("IDPhieu", obj.IDPhieu));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("ThoiGian", obj.ThoiGian));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("TenKTV", obj.TenKTV));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("MaKTV", obj.MaKTV));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("ThoiGian_TC1", obj.ThoiGian_TC1));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("LieuTC_TC1", obj.LieuTC_TC1));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("ThoiGian_TC2", obj.ThoiGian_TC2));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("LieuTC_TC2", obj.LieuTC_TC2));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("ThoiGian_TC3", obj.ThoiGian_TC3));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("LieuTC_TC3", obj.LieuTC_TC3));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("ThoiGian_TC4", obj.ThoiGian_TC4));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("LieuTC_TC4", obj.LieuTC_TC4));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("ThoiGian_TC5", obj.ThoiGian_TC5));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("LieuTC_TC5", obj.LieuTC_TC5));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("ThoiGian_TC6", obj.ThoiGian_TC6));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("LieuTC_TC6", obj.LieuTC_TC6));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("MoTaKT", obj.MoTaKT));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("TenKTVBS", obj.TenKTVBS));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("MaKTVBS", obj.MaKTVBS));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("ThoiGian_TBS1", obj.ThoiGian_TBS1));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("ThoiGianBS", obj.ThoiGianBS));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("LieuTC_TBS1", obj.LieuTC_TBS1));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("ThoiGian_TBS2", obj.ThoiGian_TBS2));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("LieuTC_TBS2", obj.LieuTC_TBS2));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("ThoiGian_TBS3", obj.ThoiGian_TBS3));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("LieuTC_TBS3", obj.LieuTC_TBS3));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("KyTen", Common.getUserLogin()));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("ID", obj.ID));
                n = oracleCommand.ExecuteNonQuery();
                long nextval = Convert.ToInt64((oracleCommand.Parameters["ID"] as MDB.MDBParameter).Value);
                obj.ID = nextval;
            }
            return n > 0 ? true : false;
        }
        public static DataSet GetDataSet(MDB.MDBConnection MyConnection, decimal id)
        {
            string sql = @"SELECT
                B.*,
                '' SOYTE,
                '' BENHVIEN,
                '' TenBenhNhan,
                '' Tuoi, '' SoTheBHYT, '' SoVaoVien
            FROM
                HoSoTriXa B
            WHERE
                IDPhieu = " + id;

            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
            MDB.MDBDataAdapter adt = new MDB.MDBDataAdapter(Command);
            var ds = new DataSet();

            adt.Fill(ds);
            if (ds != null || ds.Tables[0].Rows.Count > 0)
            {
                ds.Tables[0].Rows[0]["SoYTe"] = XemBenhAn._HanhChinhBenhNhan.SoYTe;
                ds.Tables[0].Rows[0]["BENHVIEN"] = XemBenhAn._HanhChinhBenhNhan.BenhVien;
                ds.Tables[0].Rows[0]["TenBenhNhan"] = XemBenhAn._HanhChinhBenhNhan.TenBenhNhan;
                ds.Tables[0].Rows[0]["TUOI"] = XemBenhAn._HanhChinhBenhNhan.Tuoi;
                ds.Tables[0].Rows[0]["SoTheBHYT"] = XemBenhAn._HanhChinhBenhNhan.SoTheBHYT;
                ds.Tables[0].Rows[0]["SoVaoVien"] = XemBenhAn._ThongTinDieuTri.SoNhapVien;
            }
            return ds;
        }
        //public static DataSet GetDataSet(MDB.MDBConnection MyConnection, decimal MaQuanLy, decimal? IDPhieu = null, string lstStrID = null)
        //{
        //    MDB.ExceptionExtend.Log(typeof(ThongTinChamSoc), "Start get data " + MaQuanLy);
        //    var timer = new Stopwatch();
        //    StringBuilder sql = new StringBuilder();
        //    timer.Start();
        //    try
        //    {
        //        sql.AppendLine(@"select a.*, c.*, to_char(c.thoigian, 'dd/MM/yyyy HH24:mi') thoigianbaocao,");
        //        sql.AppendLine(@"c.NguoiThucHien hotennguoiky from HoSoTriXa a");
        //        sql.AppendLine(@"left join HoSoTriXa_ChiTiet c");
        //        sql.AppendLine("on a.IDPhieu = c.IDPhieu");
        //        sql.AppendLine("WHERE a.MaQuanLy = :MaQuanLy");
        //        if (IDPhieu != null && IDPhieu.HasValue && IDPhieu.Value != 0)
        //        {
        //            sql.AppendLine(" and a.IDPhieu = " + IDPhieu);
        //        }

        //        if( !string.IsNullOrEmpty(lstStrID))
        //        {
        //            sql.AppendLine(" and c.ID in (" + lstStrID + ")");
        //        }
        //        sql.AppendLine(" ORDER BY c.ThoiGian asc");
        //        //XuLyLoi.LogDebug("dangtung - sql : " + sql);
        //        MDB.MDBCommand Command = new MDB.MDBCommand(sql.ToString(), MyConnection);
        //        Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", MaQuanLy));
        //        MDB.MDBDataAdapter adt = new MDB.MDBDataAdapter(Command);
        //        var ds = new DataSet();
        //        adt.Fill(ds);
        //        return ds;
        //    }
        //    catch (Exception ex)
        //    {
        //        MDB.ExceptionExtend.LogError(ex);
        //        return null;
        //    }
        //    finally
        //    {
        //        timer.Stop();
        //        MDB.ExceptionExtend.Log(typeof(ThongTinChamSoc), "End get data " + MaQuanLy + ". Total " + timer.ElapsedMilliseconds.ToString() + " ms");
        //    }
        //}
    }
}
