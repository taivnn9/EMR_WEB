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
    public class PTDVDTLM_CT1
    {
        public DateTime? Gio { get; set; }
        public string M { get; set; }
        [MoTaDuLieu("Huyết áp")]
		public string HA { get; set; }
        public string T { get; set; }
        [MoTaDuLieu("Nhịp tim")]
		public string NT { get; set; }
    }
    public class PTDVDTLM_CT2
    {
        public DateTime? Gio { get; set; }
        public string T { get; set; }
        public string TDLoc { get; set; }
        public string SoCanRut { get; set; }
        public string LLMau { get; set; }
        public string ApLuc { get; set; }
    }
    public class PTDVDTLM_CT3
    {
        public string DB { get; set; }
        public string YL { get; set; }
    }
    public class PTDVDTLM : ThongTinKy
    {
        public PTDVDTLM()
        {
            TableName = "PTDVDTLM";
            TablePrimaryKeyName = "ID";
            IDMauPhieu = (int)DanhMucPhieu.PTDVDTLM;
            TenMauPhieu = DanhMucPhieu.PTDVDTLM.Description();
        }
        [MoTaDuLieu("Mã định danh")]
		public long ID { get; set; }
        [MoTaDuLieu("Mã quản lý: mã duy nhất trong 1 đợt khám chữa bệnh (kcb), không trùng giữa các đợt kcb khác nhau","",1)]
		public decimal MaQuanLy { get; set; }
        [MoTaDuLieu("Khoa")]
		public string Khoa { get; set; }
        [MoTaDuLieu("Mã khoa")]
		public string MaKhoa { get; set; }
        [MoTaDuLieu("Mã bệnh nhân")]
		public string MaBenhNhan { get; set; }
        public bool[] ChanLeArray { get; } = new bool[] { false, false };
        public string ChanLe
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < ChanLeArray.Length; i++)
                    temp += (ChanLeArray[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        ChanLeArray[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public string CaLoc { get; set; }
        [MoTaDuLieu("Chẩn đoán bệnh")]
		public string ChanDoan { get; set; }
        public string SoML { get; set; }
        public string LoaiMay { get; set; }
        [MoTaDuLieu("Bác sỹ")]
		public string BacSy { get; set; }
        [MoTaDuLieu("Mã bác sỹ")]
		public string MaBacSy { get; set; }
        [MoTaDuLieu("Họ tên điều dưỡng")]
		public string DieuDuong { get; set; }
        [MoTaDuLieu("Mã điều dưỡng")]
		public string MaDieuDuong { get; set; }
        public string CanTruocLoc { get; set; }
        public string CanSauLoc { get; set; }
        public bool[] DuongVaoArray { get; } = new bool[] { false, false };
        public string DuongVao
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < DuongVaoArray.Length; i++)
                    temp += (DuongVaoArray[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        DuongVaoArray[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public string DuongVaoKhac { get; set; }
        public bool[] ChongDongArray { get; } = new bool[] { false, false };
        public string ChongDong
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < ChongDongArray.Length; i++)
                    temp += (ChongDongArray[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        ChongDongArray[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public double? LieuBD { get; set; }
        public double? LieuDT { get; set; }
        public double? LieuTong { get; set; }
        public string TGLoc { get; set; }
        public string QuaLoc { get; set; }
        public string HesoSieuLoc { get; set; }
        public string DienTich { get; set; }
        public DateTime? HSD { get; set; }
        public string DayML { get; set; }
        public DateTime? HSDDayML { get; set; }
        public bool[] NhanXetQLArray { get; } = new bool[] { false, false, false, false };
        public string NhanXetQL
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < NhanXetQLArray.Length; i++)
                    temp += (NhanXetQLArray[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        NhanXetQLArray[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }

        public string NhanXetKhac { get; set; }
        public bool[] YThucArray { get; } = new bool[] { false, false, false, false };
        public string YThuc
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < YThucArray.Length; i++)
                    temp += (YThucArray[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        YThucArray[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }

        public bool[] KhoThoArray { get; } = new bool[] { false, false, false, false, false };
        public string KhoTho
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < KhoThoArray.Length; i++)
                    temp += (KhoThoArray[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        KhoThoArray[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public bool[] PhuArray { get; } = new bool[] { false, false, false, false, false };
        public string Phu
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < PhuArray.Length; i++)
                    temp += (PhuArray[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        PhuArray[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public bool[] BienChung1Array { get; } = new bool[] { false, false, false, false, false };
        public string BienChung1
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < BienChung1Array.Length; i++)
                    temp += (BienChung1Array[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        BienChung1Array[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public bool[] BienChung2Array { get; } = new bool[] { false, false , false, false , false, false };
        public string BienChung2
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < BienChung2Array.Length; i++)
                    temp += (BienChung2Array[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        BienChung2Array[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public DateTime NgayThucHien { get; set; }
        public ObservableCollection<PTDVDTLM_CT1> BangDHST { get; set; }
        public ObservableCollection<PTDVDTLM_CT2> BangTSM { get; set; }
        public ObservableCollection<PTDVDTLM_CT3> BangDBYL { get; set; }
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
        public string NamSinh
        {
            get
            {
                return XemBenhAn._HanhChinhBenhNhan.NgaySinh.HasValue ? XemBenhAn._HanhChinhBenhNhan.NgaySinh.Value.Year.ToString() : ""; ;
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
        public string SoVaoVien
        {
            get
            {
                return XemBenhAn._ThongTinDieuTri.SoNhapVien;
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
        public string MaBenhAn
        {
            get
            {
                return XemBenhAn._ThongTinDieuTri.MaBenhAn;
            }
        }
    }
    public class PTDVDTLMFunc
    {
        public const string TableName = "PTDVDTLM";
        public const string TablePrimaryKeyName = "ID";
        public static List<PTDVDTLM> GetListData(MDB.MDBConnection _OracleConnection, decimal maquanly)
        {
            List<PTDVDTLM> list = new List<PTDVDTLM>();
            try
            {
                string sql = @"SELECT * FROM PTDVDTLM where MaQuanLy = :MaQuanLy";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, _OracleConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", maquanly));
                MDB.MDBDataReader DataReader = Command.ExecuteReader();
                while (DataReader.Read())
                {
                    PTDVDTLM data = new PTDVDTLM();
                    data.ID = Convert.ToInt64(DataReader.GetLong("ID").ToString());
                    data.MaQuanLy = maquanly;
                    data.MaBenhNhan = XemBenhAn._HanhChinhBenhNhan.TenBenhNhan;
                    data.ChanLe = DataReader["ChanLe"].ToString();
                    data.CaLoc = DataReader["CaLoc"].ToString();
                    data.ChanDoan = DataReader["ChanDoan"].ToString();
                    data.SoML = DataReader["SoML"].ToString();
                    data.LoaiMay = DataReader["LoaiMay"].ToString();
                    data.BacSy = DataReader["BacSy"].ToString();
                    data.MaBacSy = DataReader["MaBacSy"].ToString();
                    data.DieuDuong = DataReader["DieuDuong"].ToString();
                    data.MaDieuDuong = DataReader["MaDieuDuong"].ToString();
                    data.CanTruocLoc = DataReader["CanTruocLoc"].ToString();
                    data.CanSauLoc = DataReader["CanSauLoc"].ToString();
                    data.DuongVao = DataReader["DuongVao"].ToString();
                    data.DuongVaoKhac = DataReader["DuongVaoKhac"].ToString();
                    data.ChongDong = DataReader["ChongDong"].ToString();
                    data.LieuBD = Common.ConDBNull_double(DataReader["LieuBD"]);
                    data.LieuDT = Common.ConDBNull_double(DataReader["LieuDT"]);
                    data.LieuTong = Common.ConDBNull_double(DataReader["LieuTong"]);
                    data.TGLoc = Common.ConDBNull(DataReader["TGLoc"]);
                    data.QuaLoc = DataReader["QuaLoc"].ToString();
                    data.HesoSieuLoc = DataReader["HesoSieuLoc"].ToString();
                    data.DienTich = DataReader["DienTich"].ToString();
                    data.HSD = Common.ConDB_DateTimeNull(DataReader["HSD"]);
                    data.DayML = DataReader["DayML"].ToString();
                    data.HSDDayML = Common.ConDB_DateTimeNull(DataReader["HSDDayML"]);
                    data.NhanXetQL = DataReader["NhanXetQL"].ToString();
                    data.NhanXetKhac = DataReader["NhanXetKhac"].ToString();
                    data.YThuc = DataReader["YThuc"].ToString();
                    data.KhoTho = DataReader["KhoTho"].ToString();
                    data.Phu = DataReader["Phu"].ToString();
                    data.BienChung1 = DataReader["BienChung1"].ToString();
                    data.BienChung2 = DataReader["BienChung2"].ToString();
                    data.NgayThucHien =Common.ConDB_DateTime( DataReader["NgayThucHien"]);
                    data.BangDHST = JsonConvert.DeserializeObject<ObservableCollection<PTDVDTLM_CT1>>(DataReader["BangDHST"].ToString());
                    data.BangTSM = JsonConvert.DeserializeObject<ObservableCollection<PTDVDTLM_CT2>>(DataReader["BangTSM"].ToString());
                    data.BangDBYL = JsonConvert.DeserializeObject<ObservableCollection<PTDVDTLM_CT3>>(DataReader["BangDBYL"].ToString());
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
        public static bool InsertOrUpdate(MDB.MDBConnection MyConnection, ref PTDVDTLM bangKe)
        {
            try
            {
                string sql = @"INSERT INTO PTDVDTLM
                (
                    MaQuanLy,
                    Khoa,
                    MaKhoa,
                    MaBenhNhan,
                    ChanLe,
                    CaLoc,
                    ChanDoan,
                    SoML,LoaiMay,
                    BacSy,
                    MaBacSy,
                    DieuDuong,
                    MaDieuDuong,
                    CanTruocLoc,
                    CanSauLoc,
                    DuongVao,
                    DuongVaoKhac,
                    ChongDong,
                    LieuBD,
                    LieuDT,
                    LieuTong,TGLoc,
                    QuaLoc,
                    HesoSieuLoc,
                    DienTich,
                    HSD,
                    DayML,
                    HSDDayML,
                    NhanXetQL,
                    NhanXetKhac,
                    YThuc,
                    KhoTho,
                    Phu,
                    BienChung1,
                    BienChung2,
                    NgayThucHien,
                    BangDHST,
                    BangTSM,
                    BangDBYL,
                    NGUOITAO,
                    NGUOISUA,
                    NGAYTAO,
                    NGAYSUA)  VALUES
                 (
                    :MaQuanLy,
                    :Khoa,
                    :MaKhoa,
                    :MaBenhNhan,
                    :ChanLe,
                    :CaLoc,
                    :ChanDoan,
                    :SoML,:LoaiMay,
                    :BacSy,
                    :MaBacSy,
                    :DieuDuong,
                    :MaDieuDuong,
                    :CanTruocLoc,
                    :CanSauLoc,
                    :DuongVao,
                    :DuongVaoKhac,
                    :ChongDong,
                    :LieuBD,
                    :LieuDT,
                    :LieuTong,:TGLoc,
                    :QuaLoc,
                    :HesoSieuLoc,
                    :DienTich,
                    :HSD,
                    :DayML,
                    :HSDDayML,
                    :NhanXetQL,
                    :NhanXetKhac,
                    :YThuc,
                    :KhoTho,
                    :Phu,
                    :BienChung1,
                    :BienChung2,:NgayThucHien,
                    :BangDHST,
                    :BangTSM,
                    :BangDBYL,
                    :NGUOITAO,
                    :NGUOISUA,
                    :NGAYTAO,
                    :NGAYSUA
                 )  RETURNING ID INTO :ID";
                if (bangKe.ID != 0)
                {
                    sql = @"UPDATE PTDVDTLM SET 
                    MaQuanLy =:MaQuanLy,
                    Khoa =:Khoa,
                    MaKhoa =:MaKhoa,
                    MaBenhNhan =:MaBenhNhan,
                    ChanLe =:ChanLe,
                    CaLoc =:CaLoc,
                    ChanDoan =:ChanDoan,
                    SoML =:SoML,LoaiMay =:LoaiMay,
                    BacSy =:BacSy,
                    MaBacSy =:MaBacSy,
                    DieuDuong =:DieuDuong,
                    MaDieuDuong =:MaDieuDuong,
                    CanTruocLoc =:CanTruocLoc,
                    CanSauLoc =:CanSauLoc,
                    DuongVao =:DuongVao,
                    DuongVaoKhac =:DuongVaoKhac,
                    ChongDong =:ChongDong,
                    LieuBD =:LieuBD,
                    LieuDT =:LieuDT,
                    LieuTong =:LieuTong, TGLoc =:TGLoc,
                    QuaLoc =:QuaLoc,
                    HesoSieuLoc =:HesoSieuLoc,
                    DienTich =:DienTich,
                    HSD =:HSD,
                    DayML =:DayML,
                    HSDDayML =:HSDDayML,
                    NhanXetQL =:NhanXetQL,
                    NhanXetKhac =:NhanXetKhac,
                    YThuc =:YThuc,
                    KhoTho =:KhoTho,
                    Phu =:Phu,
                    BienChung1 =:BienChung1,
                    BienChung2 =:BienChung2,NgayThucHien =:NgayThucHien, BangDHST =:BangDHST, BangTSM =:BangTSM,BangDBYL =:BangDBYL,
                    NGUOISUA = :NGUOISUA,
                    NGAYSUA = :NGAYSUA
                    WHERE ID = " + bangKe.ID;
                }
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", bangKe.MaQuanLy));
                Command.Parameters.Add(new MDB.MDBParameter("Khoa", bangKe.Khoa));
                Command.Parameters.Add(new MDB.MDBParameter("MaKhoa", bangKe.MaKhoa));
                Command.Parameters.Add(new MDB.MDBParameter("MaBenhNhan", bangKe.MaBenhNhan));
                Command.Parameters.Add(new MDB.MDBParameter("ChanLe", bangKe.ChanLe));
                Command.Parameters.Add(new MDB.MDBParameter("CaLoc", bangKe.CaLoc));
                Command.Parameters.Add(new MDB.MDBParameter("ChanDoan", bangKe.ChanDoan));
                Command.Parameters.Add(new MDB.MDBParameter("SoML", bangKe.SoML));
                Command.Parameters.Add(new MDB.MDBParameter("LoaiMay", bangKe.LoaiMay));
                Command.Parameters.Add(new MDB.MDBParameter("BacSy", bangKe.BacSy));
                Command.Parameters.Add(new MDB.MDBParameter("MaBacSy", bangKe.MaBacSy));
                Command.Parameters.Add(new MDB.MDBParameter("DieuDuong", bangKe.DieuDuong));
                Command.Parameters.Add(new MDB.MDBParameter("MaDieuDuong", bangKe.MaDieuDuong));
                Command.Parameters.Add(new MDB.MDBParameter("CanTruocLoc", bangKe.CanTruocLoc));
                Command.Parameters.Add(new MDB.MDBParameter("CanSauLoc", bangKe.CanSauLoc));
                Command.Parameters.Add(new MDB.MDBParameter("DuongVao", bangKe.DuongVao));
                Command.Parameters.Add(new MDB.MDBParameter("DuongVaoKhac", bangKe.DuongVaoKhac));
                Command.Parameters.Add(new MDB.MDBParameter("ChongDong", bangKe.ChongDong));
                Command.Parameters.Add(new MDB.MDBParameter("LieuBD", bangKe.LieuBD));
                Command.Parameters.Add(new MDB.MDBParameter("LieuDT", bangKe.LieuDT));
                Command.Parameters.Add(new MDB.MDBParameter("LieuTong", bangKe.LieuTong));
                Command.Parameters.Add(new MDB.MDBParameter("TGLoc", bangKe.TGLoc));
                Command.Parameters.Add(new MDB.MDBParameter("QuaLoc", bangKe.QuaLoc));
                Command.Parameters.Add(new MDB.MDBParameter("HesoSieuLoc", bangKe.HesoSieuLoc));
                Command.Parameters.Add(new MDB.MDBParameter("DienTich", bangKe.DienTich));
                Command.Parameters.Add(new MDB.MDBParameter("HSD", bangKe.HSD));
                Command.Parameters.Add(new MDB.MDBParameter("DayML", bangKe.DayML));
                Command.Parameters.Add(new MDB.MDBParameter("HSDDayML", bangKe.HSDDayML));
                Command.Parameters.Add(new MDB.MDBParameter("NhanXetQL", bangKe.NhanXetQL));
                Command.Parameters.Add(new MDB.MDBParameter("NhanXetKhac", bangKe.NhanXetKhac));
                Command.Parameters.Add(new MDB.MDBParameter("YThuc", bangKe.YThuc));
                Command.Parameters.Add(new MDB.MDBParameter("KhoTho", bangKe.KhoTho));
                Command.Parameters.Add(new MDB.MDBParameter("Phu", bangKe.Phu));
                Command.Parameters.Add(new MDB.MDBParameter("BienChung1", bangKe.BienChung1));
                Command.Parameters.Add(new MDB.MDBParameter("BienChung2", bangKe.BienChung2));
                Command.Parameters.Add(new MDB.MDBParameter("NgayThucHien", bangKe.NgayThucHien));
                Command.Parameters.Add(new MDB.MDBParameter("BangDHST", JsonConvert.SerializeObject(bangKe.BangDHST)));
                Command.Parameters.Add(new MDB.MDBParameter("BangTSM", JsonConvert.SerializeObject(bangKe.BangTSM)));
                Command.Parameters.Add(new MDB.MDBParameter("BangDBYL", JsonConvert.SerializeObject(bangKe.BangDBYL)));
                Command.Parameters.Add(new MDB.MDBParameter("NGUOISUA", bangKe.NguoiSua));
                Command.Parameters.Add(new MDB.MDBParameter("NGAYSUA", bangKe.NgaySua));
                if (bangKe.ID == 0)
                {
                    Command.Parameters.Add(new MDB.MDBParameter("ID", bangKe.ID));
                    Command.Parameters.Add(new MDB.MDBParameter("NGUOITAO", bangKe.NguoiTao));
                    Command.Parameters.Add(new MDB.MDBParameter("NGAYTAO", bangKe.NgayTao));
                }
                Command.BindByName = true;
                int n = Command.ExecuteNonQuery();
                if (bangKe.ID == 0)
                {
                    long nextval = Convert.ToInt64((Command.Parameters["ID"] as MDB.MDBParameter).Value);
                    bangKe.ID = nextval;
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
                string sql = "DELETE FROM PTDVDTLM WHERE ID = :ID";
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
                B.*, '' NamSinh, '' MaBenhAn , 
                '' TenBenhNhan, '' SoYTe, '' BENHVIEN,
                ''  GioiTinh
            FROM
                PTDVDTLM B
            WHERE
                ID = " + id;

            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
            MDB.MDBDataAdapter adt = new MDB.MDBDataAdapter(Command);

            var ds = new DataSet();

            adt.Fill(ds);
            if (ds != null || ds.Tables[0].Rows.Count > 0)
            {
                ds.Tables[0].Rows[0]["TenBenhNhan"] = XemBenhAn._HanhChinhBenhNhan.TenBenhNhan;
                ds.Tables[0].Rows[0]["MaBenhAn"] = XemBenhAn._ThongTinDieuTri.MaBenhAn;
                ds.Tables[0].Rows[0]["NamSinh"] = XemBenhAn._HanhChinhBenhNhan.NgaySinh.HasValue ? XemBenhAn._HanhChinhBenhNhan.NgaySinh.Value.Year.ToString() : "";
                ds.Tables[0].Rows[0]["SOYTE"] = XemBenhAn._HanhChinhBenhNhan.SoYTe;
                ds.Tables[0].Rows[0]["BENHVIEN"] = XemBenhAn._HanhChinhBenhNhan.BenhVien;
                ds.Tables[0].Rows[0]["GioiTinh"] = XemBenhAn._HanhChinhBenhNhan.GioiTinh.Description();
            }
            ObservableCollection<PTDVDTLM_CT1> BangDHST = JsonConvert.DeserializeObject<ObservableCollection<PTDVDTLM_CT1>>(ds.Tables[0].Rows[0]["BangDHST"].ToString());
            ObservableCollection<PTDVDTLM_CT2> BangTSM = JsonConvert.DeserializeObject<ObservableCollection<PTDVDTLM_CT2>>(ds.Tables[0].Rows[0]["BangTSM"].ToString());
            ObservableCollection<PTDVDTLM_CT3> BangDBYL = JsonConvert.DeserializeObject<ObservableCollection<PTDVDTLM_CT3>>(ds.Tables[0].Rows[0]["BangDBYL"].ToString());

            DataTable BK1 = Common.ListToDataTable(BangDHST, "BK1");
            DataTable BK2 = Common.ListToDataTable(BangTSM, "BK2");
            DataTable BK3 = Common.ListToDataTable(BangDBYL, "BK3");
            ds.Tables.Add(BK1);
            ds.Tables.Add(BK2);
            ds.Tables.Add(BK3);

            return ds;

        }
    }
}
