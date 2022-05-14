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
    public class MauPhieuYCSDKhanhSinh : ThongTinKy
    {
        public MauPhieuYCSDKhanhSinh()
        {
            TableName = "PhieuYCSDKhanhSinhUuTien";
            TablePrimaryKeyName = "ID";
            IDMauPhieu = (int)DanhMucPhieu.MPYCSDKS;
            TenMauPhieu = DanhMucPhieu.MPYCSDKS.Description();
        }
        [MoTaDuLieu("Mã định danh")]
		public long ID { get; set; }
        [MoTaDuLieu("Mã quản lý: mã duy nhất trong 1 đợt khám chữa bệnh (kcb), không trùng giữa các đợt kcb khác nhau","",1)]
		public decimal MaQuanLy { get; set; }
        [MoTaDuLieu("Mã bệnh nhân")]
		public string MaBenhNhan { get; set; }
        public DateTime? NgayNoiDung { get; set; }
        public string HoTenBenhNhan { get; set; }
        [MoTaDuLieu("Khoa")]
		public string Khoa { get; set; }
        [MoTaDuLieu("Mã khoa")]
		public string MaKhoa { get; set; }
        [MoTaDuLieu("Mã bệnh án")]
		public string MaBenhAn { get; set; }
        [MoTaDuLieu("Tuổi bệnh nhân")]
		public string Tuoi { get; set; }
        [MoTaDuLieu("Giới tính bệnh nhân")]
		public string GioiTinh { get; set; }
        public double? CanNang { get; set; }
        public string DiUng { get; set; }
        public bool[] ChanDoanArray { get; } = new bool[] { false, false, false, false, false, false, false, false, false };
        [MoTaDuLieu("Chẩn đoán bệnh")]
		public string ChanDoan
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < ChanDoanArray.Length; i++)
                    temp += (ChanDoanArray[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        ChanDoanArray[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }

        public string DuongVao { get; set; }
        public string NhiemKhuanKhac { get; set; }
        public string NKTietNieu { get; set; }
        public string NKOBung { get; set; }
        public string BenhMacKemKhac { get; set; }
        public string TinhTrangLamSanHoiChan { get; set; }
        public double? NhietDo { get; set; }
        public string KQCLS {get;set;}
        [MoTaDuLieu("Bạch cầu")]
		public string BachCau { get; set; }
        public string CRP { get; set; }
        public string PCT { get; set; }
        public string KhacCLS { get; set; }
        public double? ThanhThaiCreatimin { get; set; }
        public bool[] LocMauArray { get; } = new bool[] { false, false, false, false };
        public string LocMau
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < LocMauArray.Length; i++)
                    temp += (LocMauArray[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        LocMauArray[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public string XemNghiemViSinh { get; set; }
        public ObservableCollection<BenhPham> ListBenhPham { get; set; }
        public string PhapDo_1 { get; set; }
        public string PhapDo_2 { get; set; }
        public string PhapDo_3 { get; set; }
        public string PhapDo_4 { get; set; }
        public bool[] LyDoDungPhapDoArray { get; } = new bool[] { false, false, false, false };
        public string LyDoDungPhapDo
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < LyDoDungPhapDoArray.Length; i++)
                    temp += (LyDoDungPhapDoArray[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        LyDoDungPhapDoArray[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public string KhanhSinh { get; set; }
        public string LyDoKhac { get; set; }
        public ObservableCollection<PhapDoKhangSinhYeuCau> PhapDoKhangSinh { get; set; }
        [MoTaDuLieu("Bác sỹ điều trị")]
		public string BacSyDieuTri { get; set; }
        [MoTaDuLieu("Mã bác sỹ điều trị")]
		public string MaBacSyDieuTri { get; set; }
        public string LanhDaoKhoaLS { get; set; }
        public string MaLanhDaoKhoaLS { get; set; }
        public DateTime? NgayYKien { get; set; }
        public bool[] ThongNhatArray { get; } = new bool[] { false, false };
        public int ThongNhat
        {
            get
            {
                return Array.IndexOf(ThongNhatArray, true)+1;
            }
            set
            {
                for (int i = 0; i < ThongNhatArray.Length; i++)
                {
                    if (i == (value - 1)) ThongNhatArray[i] = true;
                    else ThongNhatArray[i] = false;
                }
            }
        }
        public string YKienKhac { get; set; }
        public string NguoiDuocPhanCong { get; set; }
        public string MaNguoiDuocPhanCong { get; set; }
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
    public class BenhPham
    {
        public string TenBenhPham { get; set; }
        public DateTime? NgayCay { get; set; }
        public DateTime? NgayTra { get; set; }
        public string KetQua { get; set; }
    }
    public class PhapDoKhangSinhYeuCau
    {
        public string KhangSinh { get; set; }
        public string LieuDung { get; set; }
        public string KhoangCachDung { get; set; }
        public string CachDung { get; set; }
        public DateTime? ThoiGianDieuTri { get; set; }
        public double? SoNgayDieuTri { get; set; }
    }
    public class MauPhieuYCSDKhanhSinhFunc
    {
        public const string TableName = "PhieuYCSDKhanhSinhUuTien";
        public const string TablePrimaryKeyName = "ID";
        public static List<MauPhieuYCSDKhanhSinh> GetListData(MDB.MDBConnection _OracleConnection, decimal maquanly)
        {
            List<MauPhieuYCSDKhanhSinh> list = new List<MauPhieuYCSDKhanhSinh>();
            try
            {
                string sql = @"SELECT * FROM PhieuYCSDKhanhSinhUuTien where MaQuanLy = :MaQuanLy";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, _OracleConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", maquanly));
                MDB.MDBDataReader DataReader = Command.ExecuteReader();
                while (DataReader.Read())
                {
                    MauPhieuYCSDKhanhSinh data = new MauPhieuYCSDKhanhSinh();
                    data.ID = Convert.ToInt64(DataReader.GetLong("ID").ToString());
                    data.MaQuanLy = maquanly;
                    data.MaBenhNhan = DataReader["MaBenhNhan"].ToString();
                    data.Khoa = DataReader["Khoa"].ToString();
                    data.MaKhoa = DataReader["MaKhoa"].ToString();
                    data.MaBenhAn = XemBenhAn._ThongTinDieuTri.MaBenhAn;
                    data.HoTenBenhNhan = XemBenhAn._HanhChinhBenhNhan.TenBenhNhan;
                    data.Tuoi = XemBenhAn._HanhChinhBenhNhan.Tuoi;
                    data.GioiTinh = XemBenhAn._HanhChinhBenhNhan.GioiTinh.Description();
                    data.NgayNoiDung = Convert.ToDateTime(DataReader["NgayNoiDung"] == DBNull.Value ? DateTime.Now : DataReader["NgayNoiDung"]);
                    double tempDouble = 0;
                    data.CanNang = double.TryParse(DataReader["CanNang"].ToString(), out tempDouble) ? (double?) tempDouble : null;
                    data.DiUng = DataReader["DiUng"].ToString();
                    data.ChanDoan = DataReader["ChanDoan"].ToString();
                    data.DuongVao = DataReader["DuongVao"].ToString();
                    data.NhiemKhuanKhac = DataReader["NhiemKhuanKhac"].ToString();
                    data.NKTietNieu = DataReader["NKTietNieu"].ToString();
                    data.NKOBung = DataReader["NKOBung"].ToString();
                    data.BenhMacKemKhac = DataReader["BenhMacKemKhac"].ToString();
                    data.TinhTrangLamSanHoiChan = DataReader["TinhTrangLamSanHoiChan"].ToString();
                    tempDouble = 0;
                    data.NhietDo = double.TryParse(DataReader["NhietDo"].ToString(), out tempDouble) ? (double?)tempDouble : null;
                    data.KQCLS = DataReader["KQCLS"].ToString();
                    data.BachCau = DataReader["BachCau"].ToString();
                    data.CRP = DataReader["CRP"].ToString();
                    data.PCT = DataReader["PCT"].ToString();
                    data.KhacCLS = DataReader["KhacCLS"].ToString();
                    tempDouble = 0;
                    data.ThanhThaiCreatimin = double.TryParse(DataReader["ThanhThaiCreatimin"].ToString(), out tempDouble) ? (double?)tempDouble : null;
                    data.LocMau = DataReader["LocMau"].ToString();
                    data.XemNghiemViSinh = DataReader["XemNghiemViSinh"].ToString();
                    data.ListBenhPham = JsonConvert.DeserializeObject<ObservableCollection<BenhPham>>(DataReader["ListBenhPham"].ToString());
                    data.PhapDo_1 = DataReader["PhapDo_1"].ToString();
                    data.PhapDo_2 = DataReader["PhapDo_2"].ToString();
                    data.PhapDo_3 = DataReader["PhapDo_3"].ToString();
                    data.PhapDo_4 = DataReader["PhapDo_4"].ToString();
                    data.LyDoDungPhapDo = DataReader["LyDoDungPhapDo"].ToString();
                    data.KhanhSinh = DataReader["KhanhSinh"].ToString();
                    data.PhapDoKhangSinh = JsonConvert.DeserializeObject<ObservableCollection<PhapDoKhangSinhYeuCau>>(DataReader["PhapDoKhangSinh"].ToString());
                    data.BacSyDieuTri = DataReader["BacSyDieuTri"].ToString();
                    data.MaBacSyDieuTri = DataReader["MaBacSyDieuTri"].ToString();
                    data.LanhDaoKhoaLS = DataReader["LanhDaoKhoaLS"].ToString();
                    data.MaLanhDaoKhoaLS = DataReader["MaLanhDaoKhoaLS"].ToString();
                    data.NgayYKien = Convert.ToDateTime(DataReader["NgayYKien"] == DBNull.Value ? DateTime.Now : DataReader["NgayYKien"]);
                    int intTemp = 0;
                    data.ThongNhat = int.TryParse(DataReader["ThongNhat"].ToString(), out intTemp) ? intTemp : 0;
                    data.YKienKhac = DataReader["YKienKhac"].ToString();
                    data.LyDoKhac = DataReader["LyDoKhac"].ToString();
                    data.NguoiDuocPhanCong = DataReader["NguoiDuocPhanCong"].ToString();
                    data.MaNguoiDuocPhanCong = DataReader["MaNguoiDuocPhanCong"].ToString();

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
        public static bool InsertOrUpdate(MDB.MDBConnection MyConnection, ref MauPhieuYCSDKhanhSinh ketQua)
        {
            try
            {
                string sql = @"INSERT INTO PhieuYCSDKhanhSinhUuTien
                (
                    MaQuanLy,
                    MaBenhNhan,
                    Khoa,
                    MaKhoa,
                    NgayNoiDung,
                    CanNang,
                    DiUng,
                    ChanDoan,
                    DuongVao,
                    NhiemKhuanKhac,
                    NKTietNieu,
                    NKOBung,
                    BenhMacKemKhac,
                    TinhTrangLamSanHoiChan,
                    NhietDo,
                    KQCLS,
                    BachCau,
                    CRP,
                    PCT,
                    KhacCLS,
                    ThanhThaiCreatimin,
                    LocMau,
                    XemNghiemViSinh,
                    ListBenhPham,
                    PhapDo_1,
                    PhapDo_2 ,
                    PhapDo_3 ,
                    PhapDo_4 ,
                    LyDoDungPhapDo,
                    KhanhSinh ,
                    PhapDoKhangSinh,
                    BacSyDieuTri ,
                    MaBacSyDieuTri ,
                    LanhDaoKhoaLS ,
                    MaLanhDaoKhoaLS,
                    NgayYKien,
                    ThongNhat,
                    YKienKhac,
                    LyDoKhac,
                    NguoiDuocPhanCong,
                    MaNguoiDuocPhanCong,
                    NGUOITAO,
                    NGUOISUA,
                    NGAYTAO,
                    NGAYSUA)  VALUES
                 (
				    :MaQuanLy,
                    :MaBenhNhan,
                    :Khoa,
                    :MaKhoa,
                    :NgayNoiDung,
                    :CanNang,
                    :DiUng,
                    :ChanDoan,
                    :DuongVao,
                    :NhiemKhuanKhac,
                    :NKTietNieu,
                    :NKOBung,
                    :BenhMacKemKhac,
                    :TinhTrangLamSanHoiChan,
                    :NhietDo,
                    :KQCLS,
                    :BachCau,
                    :CRP,
                    :PCT,
                    :KhacCLS,
                    :ThanhThaiCreatimin,
                    :LocMau,
                    :XemNghiemViSinh,
                    :ListBenhPham,
                    :PhapDo_1,
                    :PhapDo_2 ,
                    :PhapDo_3 ,
                    :PhapDo_4 ,
                    :LyDoDungPhapDo,
                    :KhanhSinh ,
                    :PhapDoKhangSinh,
                    :BacSyDieuTri ,
                    :MaBacSyDieuTri ,
                    :LanhDaoKhoaLS ,
                    :MaLanhDaoKhoaLS,
                    :NgayYKien,
                    :ThongNhat,
                    :YKienKhac,
                    :LyDoKhac,
                    :NguoiDuocPhanCong,
                    :MaNguoiDuocPhanCong,
                    :NGUOITAO,
                    :NGUOISUA,
                    :NGAYTAO,
                    :NGAYSUA
                 )  RETURNING ID INTO :ID";
                if (ketQua.ID != 0)
                {
                    sql = @"UPDATE PhieuYCSDKhanhSinhUuTien SET 
                    MaQuanLy = :MaQuanLy,
                    MaBenhNhan = :MaBenhNhan,
                    Khoa = :Khoa,
                    MaKhoa = :MaKhoa,
                    NgayNoiDung = :NgayNoiDung,
                    CanNang = :CanNang,
                    DiUng = :DiUng,
                    ChanDoan = :ChanDoan,
                    DuongVao = :DuongVao,
                    NhiemKhuanKhac = :NhiemKhuanKhac,
                    NKTietNieu = :NKTietNieu,
                    NKOBung = :NKOBung,
                    BenhMacKemKhac = :BenhMacKemKhac,
                    TinhTrangLamSanHoiChan = :TinhTrangLamSanHoiChan,
                    NhietDo = :NhietDo,
                    KQCLS = :KQCLS,
                    BachCau = :BachCau,
                    CRP = :CRP,
                    PCT = :PCT,
                    KhacCLS = :KhacCLS,
                    ThanhThaiCreatimin = :ThanhThaiCreatimin,
                    LocMau = :LocMau,
                    XemNghiemViSinh = :XemNghiemViSinh,
                    ListBenhPham = :ListBenhPham,
                    PhapDo_1 = :PhapDo_1,
                    PhapDo_2  = :PhapDo_2 ,
                    PhapDo_3  = :PhapDo_3 ,
                    PhapDo_4  = :PhapDo_4 ,
                    LyDoDungPhapDo = :LyDoDungPhapDo,
                    KhanhSinh  = :KhanhSinh ,
                    PhapDoKhangSinh = :PhapDoKhangSinh,
                    BacSyDieuTri  = :BacSyDieuTri ,
                    MaBacSyDieuTri  = :MaBacSyDieuTri ,
                    LanhDaoKhoaLS  = :LanhDaoKhoaLS ,
                    MaLanhDaoKhoaLS = :MaLanhDaoKhoaLS,
                    NgayYKien = :NgayYKien,
                    ThongNhat = :ThongNhat,
                    YKienKhac  = :YKienKhac,
                    LyDoKhac = :LyDoKhac,
                    NguoiDuocPhanCong = :NguoiDuocPhanCong,
                    MaNguoiDuocPhanCong = :MaNguoiDuocPhanCong,
                    NGUOISUA = :NGUOISUA,
                    NGAYSUA = :NGAYSUA
                    WHERE ID = " + ketQua.ID;
                }
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MAQUANLY", ketQua.MaQuanLy));
                Command.Parameters.Add(new MDB.MDBParameter("MaBenhNhan", ketQua.MaBenhNhan));
                Command.Parameters.Add(new MDB.MDBParameter("Khoa", ketQua.Khoa));
                Command.Parameters.Add(new MDB.MDBParameter("MaKhoa", ketQua.MaKhoa));
                Command.Parameters.Add(new MDB.MDBParameter("NgayNoiDung", ketQua.NgayNoiDung));
                Command.Parameters.Add(new MDB.MDBParameter("CanNang", ketQua.CanNang));
                Command.Parameters.Add(new MDB.MDBParameter("DiUng", ketQua.DiUng));
                Command.Parameters.Add(new MDB.MDBParameter("ChanDoan", ketQua.ChanDoan));
                Command.Parameters.Add(new MDB.MDBParameter("DuongVao", ketQua.DuongVao));
                Command.Parameters.Add(new MDB.MDBParameter("NhiemKhuanKhac", ketQua.NhiemKhuanKhac));
                Command.Parameters.Add(new MDB.MDBParameter("NKTietNieu", ketQua.NKTietNieu));
                Command.Parameters.Add(new MDB.MDBParameter("NKOBung", ketQua.NKOBung));
                Command.Parameters.Add(new MDB.MDBParameter("BenhMacKemKhac", ketQua.BenhMacKemKhac));
                Command.Parameters.Add(new MDB.MDBParameter("TinhTrangLamSanHoiChan", ketQua.TinhTrangLamSanHoiChan));
                Command.Parameters.Add(new MDB.MDBParameter("NhietDo", ketQua.NhietDo));
                Command.Parameters.Add(new MDB.MDBParameter("KQCLS", ketQua.KQCLS));
                Command.Parameters.Add(new MDB.MDBParameter("BachCau", ketQua.BachCau));
                Command.Parameters.Add(new MDB.MDBParameter("CRP", ketQua.CRP));
                Command.Parameters.Add(new MDB.MDBParameter("PCT", ketQua.PCT));
                Command.Parameters.Add(new MDB.MDBParameter("KhacCLS", ketQua.KhacCLS));
                Command.Parameters.Add(new MDB.MDBParameter("ThanhThaiCreatimin", ketQua.ThanhThaiCreatimin));
                Command.Parameters.Add(new MDB.MDBParameter("LocMau", ketQua.LocMau));
                Command.Parameters.Add(new MDB.MDBParameter("XemNghiemViSinh", ketQua.XemNghiemViSinh));
                Command.Parameters.Add(new MDB.MDBParameter("ListBenhPham", JsonConvert.SerializeObject(ketQua.ListBenhPham)));
                Command.Parameters.Add(new MDB.MDBParameter("PhapDo_1", ketQua.PhapDo_1));
                Command.Parameters.Add(new MDB.MDBParameter("PhapDo_2", ketQua.PhapDo_2));
                Command.Parameters.Add(new MDB.MDBParameter("PhapDo_3", ketQua.PhapDo_3));
                Command.Parameters.Add(new MDB.MDBParameter("PhapDo_4", ketQua.PhapDo_4));
                Command.Parameters.Add(new MDB.MDBParameter("LyDoDungPhapDo", ketQua.LyDoDungPhapDo));
                Command.Parameters.Add(new MDB.MDBParameter("KhanhSinh", ketQua.KhanhSinh));
                Command.Parameters.Add(new MDB.MDBParameter("PhapDoKhangSinh", JsonConvert.SerializeObject(ketQua.PhapDoKhangSinh)));
                Command.Parameters.Add(new MDB.MDBParameter("BacSyDieuTri", ketQua.BacSyDieuTri));
                Command.Parameters.Add(new MDB.MDBParameter("MaBacSyDieuTri", ketQua.MaBacSyDieuTri));
                Command.Parameters.Add(new MDB.MDBParameter("LanhDaoKhoaLS", ketQua.LanhDaoKhoaLS));
                Command.Parameters.Add(new MDB.MDBParameter("MaLanhDaoKhoaLS", ketQua.MaLanhDaoKhoaLS));
                Command.Parameters.Add(new MDB.MDBParameter("NgayYKien", ketQua.NgayYKien));
                Command.Parameters.Add(new MDB.MDBParameter("ThongNhat", ketQua.ThongNhat));
                Command.Parameters.Add(new MDB.MDBParameter("YKienKhac", ketQua.YKienKhac));
                Command.Parameters.Add(new MDB.MDBParameter("LyDoKhac", ketQua.LyDoKhac));
                Command.Parameters.Add(new MDB.MDBParameter("NguoiDuocPhanCong", ketQua.NguoiDuocPhanCong));
                Command.Parameters.Add(new MDB.MDBParameter("MaNguoiDuocPhanCong", ketQua.MaNguoiDuocPhanCong));
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
                string sql = "DELETE FROM PhieuYCSDKhanhSinhUuTien WHERE ID = :ID";
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
                PhieuYCSDKhanhSinhUuTien P
            WHERE
                ID = " + id;

            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
            MDB.MDBDataAdapter adt = new MDB.MDBDataAdapter(Command);
            var ds = new DataSet();

            adt.Fill(ds, "KQ");

            ds.Tables[0].AddColumn("TenBenhNhan", typeof(string));
            ds.Tables[0].AddColumn("Tuoi", typeof(string));
            ds.Tables[0].AddColumn("NamSinh", typeof(string));
            ds.Tables[0].AddColumn("GioiTinh", typeof(string));
            ds.Tables[0].AddColumn("SOYTE", typeof(string));
            ds.Tables[0].AddColumn("BENHVIEN", typeof(string));
            ds.Tables[0].AddColumn("KHOA", typeof(string));

            ds.Tables[0].Rows[0]["TenBenhNhan"] = XemBenhAn._HanhChinhBenhNhan.TenBenhNhan;
            ds.Tables[0].Rows[0]["Tuoi"] = XemBenhAn._HanhChinhBenhNhan.Tuoi;
            ds.Tables[0].Rows[0]["NamSinh"] = XemBenhAn._HanhChinhBenhNhan.NgaySinh.HasValue ? XemBenhAn._HanhChinhBenhNhan.NgaySinh.Value.Year + "" : "";
            ds.Tables[0].Rows[0]["GioiTinh"] = XemBenhAn._HanhChinhBenhNhan.GioiTinh.Description();
            ds.Tables[0].Rows[0]["SOYTE"] = XemBenhAn._HanhChinhBenhNhan.SoYTe;
            ds.Tables[0].Rows[0]["BENHVIEN"] = XemBenhAn._HanhChinhBenhNhan.BenhVien;
            ds.Tables[0].Rows[0]["KHOA"] = XemBenhAn._ThongTinDieuTri.Khoa;

            DataTable BP = new DataTable("BP");
            BP.Columns.Add("TenBenhPham", typeof(string));
            BP.Columns.Add("NgayCay", typeof(DateTime));
            BP.Columns.Add("NgayTra", typeof(DateTime));
            BP.Columns.Add("KetQua", typeof(string));
            ObservableCollection<BenhPham> ListBenhPham = JsonConvert.DeserializeObject<ObservableCollection<BenhPham>>(ds.Tables[0].Rows[0]["ListBenhPham"].ToString());
            if (ListBenhPham != null)
            {
                foreach (BenhPham benhPham in ListBenhPham)
                {
                    BP.Rows.Add(benhPham.TenBenhPham, benhPham.NgayCay, benhPham.NgayTra, benhPham.KetQua);
                }
            }
            ds.Tables.Add(BP);

            DataTable PD = new DataTable("PD");
            PD.Columns.Add("KhangSinh", typeof(string));
            PD.Columns.Add("LieuDung", typeof(string));
            PD.Columns.Add("KhoangCachDung", typeof(string));
            PD.Columns.Add("CachDung", typeof(string));
            PD.Columns.Add("ThoiGianDieuTri", typeof(DateTime));
            PD.Columns.Add("SoNgayDieuTri", typeof(string));
            ObservableCollection<PhapDoKhangSinhYeuCau> PhapDoKhangSinh = JsonConvert.DeserializeObject<ObservableCollection<PhapDoKhangSinhYeuCau>>(ds.Tables[0].Rows[0]["PhapDoKhangSinh"].ToString());
            if(PhapDoKhangSinh != null)
            {
                foreach (PhapDoKhangSinhYeuCau phapDo in PhapDoKhangSinh)
                {
                    PD.Rows.Add(phapDo.KhangSinh,
                        phapDo.LieuDung,
                        phapDo.KhoangCachDung,
                        phapDo.CachDung,
                        phapDo.ThoiGianDieuTri,
                        phapDo.SoNgayDieuTri.HasValue? phapDo.SoNgayDieuTri.Value.ToString():"");
                }
            }
            ds.Tables.Add(PD);

            return ds;
        }
    }
}
