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
    public class PhieuXetNghiemViKhuanLao : ThongTinKy
    {
        public PhieuXetNghiemViKhuanLao()
        {
            TableName = "PhieuXetNghiemViKhuanLao";
            TablePrimaryKeyName = "ID";
            IDMauPhieu = (int)DanhMucPhieu.PXNVKL;
            TenMauPhieu = DanhMucPhieu.PXNVKL.Description();
        }
        [MoTaDuLieu("Mã định danh")]
		public long ID { get; set; }
        [MoTaDuLieu("Mã quản lý: mã duy nhất trong 1 đợt khám chữa bệnh (kcb), không trùng giữa các đợt kcb khác nhau","",1)]
		public decimal MaQuanLy { get; set; }
        [MoTaDuLieu("Mã bệnh nhân")]
		public string MaBenhNhan { get; set; }
        public string DonViYeuCau { get; set; }
        public string HoVaTenNguoiBenh { get; set; }
        [MoTaDuLieu("Tuổi bệnh nhân")]
		public string Tuoi { get; set; }
        [MoTaDuLieu("Giới tính bệnh nhân")]
		public string GioiTinh { get; set; }
        public string Thon { get; set; }
        public string PhuongXa { get; set; }
        public string QuanHuyen { get; set; }
        public string Tinh { get; set; }
        public string DienThoai { get; set; }
        public string SoDKDT { get; set; }
        public string SoETBM { get; set; }
        public bool[] LyDoXetNghiem_Array { get; } = new bool[] { false, false, false, false, false, false };
        public string LyDoXetNghiem
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < LyDoXetNghiem_Array.Length; i++)
                    temp += (LyDoXetNghiem_Array[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        LyDoXetNghiem_Array[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public string ThangThu { get; set; }
        public string XetNghiem_Khac { get; set; }
        public bool[] TienSuDTLao_Array { get; } = new bool[] { false, false };
        public int TienSuDTLao
        {
            get
            {
                return Array.IndexOf(TienSuDTLao_Array, true) + 1;
            }
            set
            {
                for (int i = 0; i < TienSuDTLao_Array.Length; i++)
                {
                    if (i == (value - 1)) TienSuDTLao_Array[i] = true;
                    else TienSuDTLao_Array[i] = false;
                }
            }
        }
        public string TinhTrangH { get; set; }
        public bool[] LoaiBenhPham_Array { get; } = new bool[] { false, false };
        public int LoaiBenhPham
        {
            get
            {
                return Array.IndexOf(LoaiBenhPham_Array, true) + 1;
            }
            set
            {
                for (int i = 0; i < LoaiBenhPham_Array.Length; i++)
                {
                    if (i == (value - 1)) LoaiBenhPham_Array[i] = true;
                    else LoaiBenhPham_Array[i] = false;
                }
            }
        }
        public string LoaiBenhPham_Khac { get; set; }
        public DateTime? ThoiGianLayMau { get; set; }
        public string NguoiLayMau { get; set; }
        public string MaNguoiLayMau { get; set; }
        public bool[] LoaiXetNghiemYeuCau_Array { get; } = new bool[] { false, false, false, false, false, false, false, false, false, false, false, false, false};
        public string LoaiXetNghiemYeuCau
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < LoaiXetNghiemYeuCau_Array.Length; i++)
                    temp += (LoaiXetNghiemYeuCau_Array[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        LoaiXetNghiemYeuCau_Array[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public string MauSoNeelsen { get; set; }
        public string MauSoHuynhQuan { get; set; }
        public string LanThuXpert { get; set; }
        public string LoaiXetNghiem_LyDo { get; set; }
        public bool[] ChanDoanLao_Array { get; } = new bool[] { false, false, false, false };
        [MoTaDuLieu("Chẩn đoán lao")]
		public string ChanDoanLao
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < ChanDoanLao_Array.Length; i++)
                    temp += (ChanDoanLao_Array[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        ChanDoanLao_Array[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public string LaoNgoaiPhoi_Text { get; set; }
        public bool[] ChanDoanLaoDaKhangThuoc_Array { get; } = new bool[] { false, false, false, false, false, false, false, false };
        [MoTaDuLieu("Chẩn đoán Lao đã kháng thuốc")]
		public string ChanDoanLaoDaKhangThuoc
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < ChanDoanLaoDaKhangThuoc_Array.Length; i++)
                    temp += (ChanDoanLaoDaKhangThuoc_Array[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        ChanDoanLaoDaKhangThuoc_Array[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public bool[] ChanDoanLaoTien_Array { get; } = new bool[] { false, false, false, false};
        [MoTaDuLieu("Chẩn đoán Lao tiền/siêu kháng thuốc")]
		public string ChanDoanLaoTien
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < ChanDoanLaoTien_Array.Length; i++)
                    temp += (ChanDoanLaoTien_Array[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        ChanDoanLaoTien_Array[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public string NghiThatBai_ThangThu { get; set; }
        [MoTaDuLieu("Chẩn đoán Lao tiền/siêu kháng thuốc - nội dung")]
		public string ChanDoanLaoTien_text { get; set; }
        public string DoiTuongKhac { get; set; }
        public string NguoiYeuCauXetNghiem { get; set; }
        public string MaNguoiYeuCauXetNghiem { get; set; }
        // phan cho ket qua xet nghiem
        public string SoXN { get; set; }
        public string PhongXetNghiem { get; set; }
        public DateTime? ThoiGianNhanMau { get; set; }
        public string NguoiNhanMau { get; set; }
        public string MaNguoiNhanMau { get; set; }
        public DateTime? ThoiGianLamXetNghiem { get; set; }
        public string NguoiLamXN { get; set; }
        public string MaNguoiLamXN { get; set; }
        public string TrangThaiBenhNhan { get; set; }
        public AFBTrucTiep aFBTrucTiep { get; set; }
        public MTBDinhDanh mTBDinhDanh { get; set; }
        public MTBNuoiCay mTBNoiCay { get; set; }
        public string NTMDinhDanh { get; set; }
        public bool[] MTB_Array { get; } = new bool[] { false, false};
        public int MTB
        {
            get
            {
                return Array.IndexOf(MTB_Array, true) + 1;
            }
            set
            {
                for (int i = 0; i < MTB_Array.Length; i++)
                {
                    if (i == (value - 1)) MTB_Array[i] = true;
                    else MTB_Array[i] = false;
                }
            }
        }
        public MTBDaKhang mTBDaKhang { get; set; }
        public  ObservableCollection<MTBKhangThuoc> mTBKhangThuoc { get; set; }
        public string Col1_Extra { get; set; }
        public string Col2_Extra { get; set; }
        [MoTaDuLieu("Trưởng khoa")]
		public string TruongKhoa { get; set; }
        [MoTaDuLieu("Mã trưởng khoa")]
		public string MaTruongKhoa { get; set; }

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
    public class AFBTrucTiep
    {
        public string AmTinh { get; set; }
        public string SoLuongAFB { get; set; }
        public string Plus1 { get; set; }
        public string Plus2 { get; set; }
        public string Plus3 { get; set; }
    }
    public class MTBDinhDanh
    {
        public string AmTinh { get; set; }
        public string CoMTB1 { get; set; }
        public string CoMTB2 { get; set; }
        public string CoMTB3 { get; set; }
        public string Loi { get; set; }
    }
    public class MTBNuoiCay
    {
        public string AmTinh { get; set; }
        public string MTB { get; set; }
        public string NTM { get; set; }
        public string NgoaiNhiem { get; set; }
    }
    public class MTBDaKhang
    {
        public string INH { get; set; }
        public string RMP { get; set; }
        public string Flu { get; set; }
        public string KM { get; set; }
        public string AMK { get; set; }
        public string CAP { get; set; }
        public string VMC { get; set; }
    }
    public class MTBKhangThuoc
    {
        [MoTaDuLieu("Chọn", null, 0, 0)]
		public bool Chon { get; set; }
        public string MoiTruong { get; set; }
        public string INH1 { get; set; }
        public string INH2 { get; set; }
        public string RMP { get; set; }
        public string EMB { get; set; }
        public string SM { get; set; }
        public string PZA { get; set; }
        public string MOX1 { get; set; }
        public string MOX2 { get; set; }
        public string AMK { get; set; }
        public string KM { get; set; }
        public string CAP { get; set; }
        public string Col1 { get; set; }
        public string Col2 { get; set; }
        [MoTaDuLieu("Ghi chú")]
		public string GhiChu { get; set; }
    }
    public class PhieuXetNghiemViKhuanLaoFunc
    {
        public const string TableName = "PhieuXetNghiemViKhuanLao";
        public const string TablePrimaryKeyName = "ID";
        public static List<PhieuXetNghiemViKhuanLao> GetListData(MDB.MDBConnection _OracleConnection, decimal maquanly)
        {
            List<PhieuXetNghiemViKhuanLao> list = new List<PhieuXetNghiemViKhuanLao>();
            try
            {
                string sql = @"SELECT * FROM PhieuXetNghiemViKhuanLao where MaQuanLy = :MaQuanLy";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, _OracleConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", maquanly));
                MDB.MDBDataReader DataReader = Command.ExecuteReader();
                while (DataReader.Read())
                {
                    PhieuXetNghiemViKhuanLao data = new PhieuXetNghiemViKhuanLao();
                    data.ID = Convert.ToInt64(DataReader.GetLong("ID").ToString());
                    data.MaQuanLy = maquanly;
                    data.MaBenhNhan = DataReader["MaBenhNhan"].ToString();
                    data.HoVaTenNguoiBenh = XemBenhAn._HanhChinhBenhNhan.TenBenhNhan;
                    data.Tuoi = XemBenhAn._HanhChinhBenhNhan.Tuoi;
                    data.GioiTinh = XemBenhAn._HanhChinhBenhNhan.GioiTinh.Description();
                    data.DonViYeuCau = DataReader["DonViYeuCau"].ToString();
                    data.Thon = DataReader["Thon"].ToString();
                    data.PhuongXa = DataReader["PhuongXa"].ToString();
                    data.QuanHuyen = DataReader["QuanHuyen"].ToString();
                    data.Tinh = DataReader["Tinh"].ToString();
                    data.DienThoai = DataReader["DienThoai"].ToString();
                    data.SoDKDT = DataReader["SoDKDT"].ToString();
                    data.SoETBM = DataReader["SoETBM"].ToString();
                    data.LyDoXetNghiem = DataReader["LyDoXetNghiem"].ToString();
                    data.MauSoNeelsen = DataReader["MauSoNeelsen"].ToString();
                    data.MauSoHuynhQuan = DataReader["MauSoHuynhQuan"].ToString();
                    data.LanThuXpert = DataReader["LanThuXpert"].ToString();
                    data.ThangThu = DataReader["ThangThu"].ToString();
                    data.XetNghiem_Khac = DataReader["XetNghiem_Khac"].ToString();
                    int intTemp = 0;
                    data.TienSuDTLao = int.TryParse(DataReader["TienSuDTLao"].ToString(), out intTemp) ? intTemp : 0;
                    data.TinhTrangH = DataReader["TinhTrangH"].ToString();
                    intTemp = 0;
                    data.LoaiBenhPham = int.TryParse(DataReader["LoaiBenhPham"].ToString(), out intTemp) ? intTemp : 0;
                    data.LoaiBenhPham_Khac = DataReader["LoaiBenhPham_Khac"].ToString();
                    data.ThoiGianLayMau = DataReader["ThoiGianLayMau"] == DBNull.Value ? (DateTime?)null : DataReader.GetDate("ThoiGianLayMau");
                    data.NguoiLayMau = DataReader["NguoiLayMau"].ToString();
                    data.MaNguoiLayMau = DataReader["MaNguoiLayMau"].ToString();
                    data.LoaiXetNghiemYeuCau = DataReader["LoaiXetNghiemYeuCau"].ToString();
                    data.LoaiXetNghiem_LyDo = DataReader["LoaiXetNghiem_LyDo"].ToString();
                    data.ChanDoanLao = DataReader["ChanDoanLao"].ToString();
                    data.LaoNgoaiPhoi_Text = DataReader["LaoNgoaiPhoi_Text"].ToString();
                    data.ChanDoanLaoDaKhangThuoc =DataReader["ChanDoanLaoDaKhangThuoc"].ToString();
                    data.ChanDoanLaoTien = DataReader["ChanDoanLaoTien"].ToString();
                    data.NghiThatBai_ThangThu = DataReader["NghiThatBai_ThangThu"].ToString();
                    data.ChanDoanLaoTien_text = DataReader["ChanDoanLaoTien_text"].ToString();
                    data.DoiTuongKhac = DataReader["DoiTuongKhac"].ToString();
                    data.NguoiYeuCauXetNghiem = DataReader["NguoiYeuCauXetNghiem"].ToString();
                    data.MaNguoiYeuCauXetNghiem = DataReader["MaNguoiYeuCauXetNghiem"].ToString();

                    // phan cho ket qua xet nghiem
                    data.SoXN = DataReader["SoXN"].ToString();
                    data.PhongXetNghiem = DataReader["PhongXetNghiem"].ToString();
                    data.ThoiGianNhanMau = DataReader["ThoiGianNhanMau"] == DBNull.Value ? (DateTime?)null : DataReader.GetDate("ThoiGianNhanMau");
                    data.NguoiNhanMau = DataReader["NguoiNhanMau"].ToString();
                    data.MaNguoiNhanMau = DataReader["MaNguoiNhanMau"].ToString();
                    data.ThoiGianLamXetNghiem = DataReader["ThoiGianLamXetNghiem"] == DBNull.Value ? (DateTime?)null : DataReader.GetDate("ThoiGianLamXetNghiem");
                    data.NguoiLamXN = DataReader["NguoiLamXN"].ToString();
                    data.MaNguoiLamXN = DataReader["MaNguoiLamXN"].ToString();
                    data.TrangThaiBenhNhan = DataReader["TrangThaiBenhNhan"].ToString();
                    data.aFBTrucTiep = JsonConvert.DeserializeObject<AFBTrucTiep>(DataReader["aFBTrucTiep"].ToString());

                    data.mTBDinhDanh = JsonConvert.DeserializeObject<MTBDinhDanh>(DataReader["mTBDinhDanh"].ToString());

                    data.mTBNoiCay = JsonConvert.DeserializeObject<MTBNuoiCay>(DataReader["mTBNoiCay"].ToString());
                    data.NTMDinhDanh = DataReader["NTMDinhDanh"].ToString();
                    intTemp = 0;
                    data.MTB = int.TryParse(DataReader["MTB"].ToString(), out intTemp) ? intTemp : 0;
                    data.mTBDaKhang = JsonConvert.DeserializeObject<MTBDaKhang>(DataReader["mTBDaKhang"].ToString());

                    data.mTBKhangThuoc = JsonConvert.DeserializeObject<ObservableCollection<MTBKhangThuoc>>(DataReader["mTBKhangThuoc"].ToString());
                    data.Col1_Extra = DataReader["Col1_Extra"].ToString();
                    data.Col2_Extra = DataReader["Col2_Extra"].ToString();
                    data.TruongKhoa = DataReader["TruongKhoa"].ToString();
                    data.MaTruongKhoa = DataReader["MaTruongKhoa"].ToString();

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
        public static bool InsertOrUpdate(MDB.MDBConnection MyConnection, ref PhieuXetNghiemViKhuanLao bangTheoDoi)
        {
            try
            {
                string sql = @"INSERT INTO PhieuXetNghiemViKhuanLao
                (
                    MAQUANLY,
                    MaBenhNhan,
                    DonViYeuCau,
                    Thon,
                    PhuongXa,
                    QuanHuyen,
                    Tinh,
                    DienThoai,
                    SoDKDT,
                    SoETBM,
                    LyDoXetNghiem,
                    ThangThu,
                    XetNghiem_Khac,
                    TienSuDTLao,
                    TinhTrangH,
                    LoaiBenhPham,
                    LoaiBenhPham_Khac,
                    ThoiGianLayMau,
                    NguoiLayMau,
                    MaNguoiLayMau ,
                    LoaiXetNghiemYeuCau,
                    MauSoNeelsen,
                    MauSoHuynhQuan,
                    LanThuXpert,
                    LoaiXetNghiem_LyDo,
                    ChanDoanLao,
                    LaoNgoaiPhoi_Text,
                    ChanDoanLaoDaKhangThuoc,
                    ChanDoanLaoTien,
                    NghiThatBai_ThangThu,
                    ChanDoanLaoTien_text,
                    DoiTuongKhac,
                    NguoiYeuCauXetNghiem,
                    MaNguoiYeuCauXetNghiem,
                    SoXN,
                    PhongXetNghiem,
                    ThoiGianNhanMau,
                    NguoiNhanMau,
                    MaNguoiNhanMau,
                    ThoiGianLamXetNghiem,
                    NguoiLamXN,
                    MaNguoiLamXN,
                    TrangThaiBenhNhan,
                    aFBTrucTiep,
                    mTBDinhDanh,
                    mTBNoiCay,
                    NTMDinhDanh,
                    MTB,
                    mTBDaKhang,
                    mTBKhangThuoc,
                    Col1_Extra,
                    Col2_Extra,
                    TruongKhoa,
                    MaTruongKhoa,
                    NGUOITAO,
                    NGUOISUA,
                    NGAYTAO,
                    NGAYSUA)  VALUES
                 (
                    :MAQUANLY,
                    :MaBenhNhan,
                    :DonViYeuCau,
                    :Thon,
                    :PhuongXa,
                    :QuanHuyen,
                    :Tinh,
                    :DienThoai,
                    :SoDKDT,
                    :SoETBM,
                    :LyDoXetNghiem,
                    :ThangThu,
                    :XetNghiem_Khac,
                    :TienSuDTLao,
                    :TinhTrangH,
                    :LoaiBenhPham,
                    :LoaiBenhPham_Khac,
                    :ThoiGianLayMau,
                    :NguoiLayMau,
                    :MaNguoiLayMau,
                    :LoaiXetNghiemYeuCau,
                    :MauSoNeelsen,
                    :MauSoHuynhQuan,
                    :LanThuXpert,
                    :LoaiXetNghiem_LyDo,
                    :ChanDoanLao,
                    :LaoNgoaiPhoi_Text,
                    :ChanDoanLaoDaKhangThuoc,
                    :ChanDoanLaoTien,
                    :NghiThatBai_ThangThu,
                    :ChanDoanLaoTien_text,
                    :DoiTuongKhac,
                    :NguoiYeuCauXetNghiem,
                    :MaNguoiYeuCauXetNghiem,
                    :SoXN,
                    :PhongXetNghiem,
                    :ThoiGianNhanMau,
                    :NguoiNhanMau,
                    :MaNguoiNhanMau,
                    :ThoiGianLamXetNghiem,
                    :NguoiLamXN,
                    :MaNguoiLamXN,
                    :TrangThaiBenhNhan,
                    :aFBTrucTiep,
                    :mTBDinhDanh,
                    :mTBNoiCay,
                    :NTMDinhDanh,
                    :MTB,
                    :mTBDaKhang,
                    :mTBKhangThuoc,
                    :Col1_Extra,
                    :Col2_Extra,
                    :TruongKhoa,
                    :MaTruongKhoa,
                    :NGUOITAO,
                    :NGUOISUA,
                    :NGAYTAO,
                    :NGAYSUA
                 )  RETURNING ID INTO :ID";
                if (bangTheoDoi.ID != 0)
                {
                    sql = @"UPDATE PhieuXetNghiemViKhuanLao SET 
                    MAQUANLY = :MAQUANLY,
                    MaBenhNhan = :MaBenhNhan,
                    DonViYeuCau = :DonViYeuCau,
                    Thon = :Thon,
                    PhuongXa = :PhuongXa,
                    QuanHuyen = :QuanHuyen,
                    Tinh = :Tinh,
                    DienThoai = :DienThoai,
                    SoDKDT = :SoDKDT,
                    SoETBM = :SoETBM,
                    LyDoXetNghiem = :LyDoXetNghiem,
                    ThangThu = :ThangThu,
                    XetNghiem_Khac = :XetNghiem_Khac,
                    TienSuDTLao = :TienSuDTLao,
                    TinhTrangH = :TinhTrangH,
                    LoaiBenhPham = :LoaiBenhPham,
                    LoaiBenhPham_Khac = :LoaiBenhPham_Khac,
                    ThoiGianLayMau = :ThoiGianLayMau,
                    NguoiLayMau = :NguoiLayMau,
                    MaNguoiLayMau  = :MaNguoiLayMau,
                    LoaiXetNghiemYeuCau  = :LoaiXetNghiemYeuCau,
                    LoaiXetNghiem_LyDo  = :LoaiXetNghiem_LyDo,
                    ChanDoanLao  = :ChanDoanLao,
                    LaoNgoaiPhoi_Text  = :LaoNgoaiPhoi_Text,
                    ChanDoanLaoDaKhangThuoc  = :ChanDoanLaoDaKhangThuoc,
                    ChanDoanLaoTien  = :ChanDoanLaoTien,
                    NghiThatBai_ThangThu = :NghiThatBai_ThangThu,
                    ChanDoanLaoTien_text  = :ChanDoanLaoTien_text,
                    DoiTuongKhac  = :DoiTuongKhac,
                    NguoiYeuCauXetNghiem  = :NguoiYeuCauXetNghiem,
                    MaNguoiYeuCauXetNghiem  = :MaNguoiYeuCauXetNghiem,
                    SoXN  = :SoXN,
                    PhongXetNghiem = :PhongXetNghiem,
                    ThoiGianNhanMau = :ThoiGianNhanMau,
                    NguoiNhanMau = :NguoiNhanMau,
                    MaNguoiNhanMau = :MaNguoiNhanMau,
                    ThoiGianLamXetNghiem = :ThoiGianLamXetNghiem,
                    NguoiLamXN = :NguoiLamXN,
                    MaNguoiLamXN = :MaNguoiLamXN,
                    TrangThaiBenhNhan = :TrangThaiBenhNhan,
                    aFBTrucTiep = :aFBTrucTiep,
                    mTBDinhDanh = :mTBDinhDanh,
                    mTBNoiCay = :mTBNoiCay,
                    NTMDinhDanh = :NTMDinhDanh,
                    MTB = :MTB,
                    mTBDaKhang = :mTBDaKhang,
                    mTBKhangThuoc = :mTBKhangThuoc,
                    Col1_Extra = :Col1_Extra,
                    Col2_Extra = :Col2_Extra,
                    TruongKhoa = :TruongKhoa,
                    MaTruongKhoa = :MaTruongKhoa,
                    NGUOISUA = :NGUOISUA,
                    NGAYSUA = :NGAYSUA
                    WHERE ID = " + bangTheoDoi.ID;
                }
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MAQUANLY", bangTheoDoi.MaQuanLy));
                Command.Parameters.Add(new MDB.MDBParameter("MaBenhNhan", bangTheoDoi.MaBenhNhan));
                Command.Parameters.Add(new MDB.MDBParameter("DonViYeuCau", bangTheoDoi.DonViYeuCau));
                Command.Parameters.Add(new MDB.MDBParameter("Thon", bangTheoDoi.Thon));
                Command.Parameters.Add(new MDB.MDBParameter("PhuongXa", bangTheoDoi.PhuongXa));
                Command.Parameters.Add(new MDB.MDBParameter("QuanHuyen", bangTheoDoi.QuanHuyen));
                Command.Parameters.Add(new MDB.MDBParameter("Tinh", bangTheoDoi.Tinh));
                Command.Parameters.Add(new MDB.MDBParameter("DienThoai", bangTheoDoi.DienThoai));
                Command.Parameters.Add(new MDB.MDBParameter("SoDKDT", bangTheoDoi.SoDKDT));
                Command.Parameters.Add(new MDB.MDBParameter("SoETBM", bangTheoDoi.SoETBM));
                Command.Parameters.Add(new MDB.MDBParameter("LyDoXetNghiem", bangTheoDoi.LyDoXetNghiem));
                Command.Parameters.Add(new MDB.MDBParameter("ThangThu", bangTheoDoi.ThangThu));
                Command.Parameters.Add(new MDB.MDBParameter("XetNghiem_Khac", bangTheoDoi.XetNghiem_Khac));
                Command.Parameters.Add(new MDB.MDBParameter("TienSuDTLao", bangTheoDoi.TienSuDTLao));
                Command.Parameters.Add(new MDB.MDBParameter("TinhTrangH", bangTheoDoi.TinhTrangH));
                Command.Parameters.Add(new MDB.MDBParameter("LoaiBenhPham", bangTheoDoi.LoaiBenhPham));
                Command.Parameters.Add(new MDB.MDBParameter("LoaiBenhPham_Khac", bangTheoDoi.LoaiBenhPham_Khac));
                Command.Parameters.Add(new MDB.MDBParameter("ThoiGianLayMau", bangTheoDoi.ThoiGianLayMau));
                Command.Parameters.Add(new MDB.MDBParameter("NguoiLayMau", bangTheoDoi.NguoiLayMau));
                Command.Parameters.Add(new MDB.MDBParameter("MaNguoiLayMau", bangTheoDoi.MaNguoiLayMau));
                Command.Parameters.Add(new MDB.MDBParameter("LoaiXetNghiemYeuCau", bangTheoDoi.LoaiXetNghiemYeuCau));
                Command.Parameters.Add(new MDB.MDBParameter("MauSoNeelsen", bangTheoDoi.MauSoNeelsen));
                Command.Parameters.Add(new MDB.MDBParameter("MauSoHuynhQuan", bangTheoDoi.MauSoHuynhQuan));
                Command.Parameters.Add(new MDB.MDBParameter("LanThuXpert", bangTheoDoi.LanThuXpert));
                Command.Parameters.Add(new MDB.MDBParameter("LoaiXetNghiem_LyDo", bangTheoDoi.LoaiXetNghiem_LyDo));
                Command.Parameters.Add(new MDB.MDBParameter("ChanDoanLao", bangTheoDoi.ChanDoanLao));
                Command.Parameters.Add(new MDB.MDBParameter("LaoNgoaiPhoi_Text", bangTheoDoi.LaoNgoaiPhoi_Text));
                Command.Parameters.Add(new MDB.MDBParameter("ChanDoanLaoDaKhangThuoc", bangTheoDoi.ChanDoanLaoDaKhangThuoc));
                Command.Parameters.Add(new MDB.MDBParameter("ChanDoanLaoTien", bangTheoDoi.ChanDoanLaoTien));
                Command.Parameters.Add(new MDB.MDBParameter("NghiThatBai_ThangThu", bangTheoDoi.NghiThatBai_ThangThu));
                Command.Parameters.Add(new MDB.MDBParameter("ChanDoanLaoTien_text", bangTheoDoi.ChanDoanLaoTien_text));
                Command.Parameters.Add(new MDB.MDBParameter("DoiTuongKhac", bangTheoDoi.DoiTuongKhac));
                Command.Parameters.Add(new MDB.MDBParameter("NguoiYeuCauXetNghiem", bangTheoDoi.NguoiYeuCauXetNghiem));
                Command.Parameters.Add(new MDB.MDBParameter("MaNguoiYeuCauXetNghiem", bangTheoDoi.MaNguoiYeuCauXetNghiem));
                Command.Parameters.Add(new MDB.MDBParameter("SoXN", bangTheoDoi.SoXN));
                Command.Parameters.Add(new MDB.MDBParameter("PhongXetNghiem", bangTheoDoi.PhongXetNghiem));
                Command.Parameters.Add(new MDB.MDBParameter("ThoiGianNhanMau", bangTheoDoi.ThoiGianNhanMau));
                Command.Parameters.Add(new MDB.MDBParameter("NguoiNhanMau", bangTheoDoi.NguoiNhanMau));
                Command.Parameters.Add(new MDB.MDBParameter("MaNguoiNhanMau", bangTheoDoi.MaNguoiNhanMau));
                Command.Parameters.Add(new MDB.MDBParameter("ThoiGianLamXetNghiem", bangTheoDoi.ThoiGianLamXetNghiem));
                Command.Parameters.Add(new MDB.MDBParameter("NguoiLamXN", bangTheoDoi.NguoiLamXN));
                Command.Parameters.Add(new MDB.MDBParameter("MaNguoiLamXN", bangTheoDoi.MaNguoiLamXN));
                Command.Parameters.Add(new MDB.MDBParameter("TrangThaiBenhNhan", bangTheoDoi.TrangThaiBenhNhan));
                Command.Parameters.Add(new MDB.MDBParameter("aFBTrucTiep", JsonConvert.SerializeObject(bangTheoDoi.aFBTrucTiep)));
                Command.Parameters.Add(new MDB.MDBParameter("mTBDinhDanh", JsonConvert.SerializeObject(bangTheoDoi.mTBDinhDanh)));
                Command.Parameters.Add(new MDB.MDBParameter("mTBNoiCay", JsonConvert.SerializeObject(bangTheoDoi.mTBNoiCay)));
                Command.Parameters.Add(new MDB.MDBParameter("NTMDinhDanh", bangTheoDoi.NTMDinhDanh));
                Command.Parameters.Add(new MDB.MDBParameter("MTB", bangTheoDoi.MTB));
                Command.Parameters.Add(new MDB.MDBParameter("mTBDaKhang", JsonConvert.SerializeObject(bangTheoDoi.mTBDaKhang)));
                Command.Parameters.Add(new MDB.MDBParameter("mTBKhangThuoc", JsonConvert.SerializeObject(bangTheoDoi.mTBKhangThuoc)));
                Command.Parameters.Add(new MDB.MDBParameter("Col1_Extra", bangTheoDoi.Col1_Extra));
                Command.Parameters.Add(new MDB.MDBParameter("Col2_Extra", bangTheoDoi.Col2_Extra));
                Command.Parameters.Add(new MDB.MDBParameter("TruongKhoa", bangTheoDoi.TruongKhoa));
                Command.Parameters.Add(new MDB.MDBParameter("MaTruongKhoa", bangTheoDoi.MaTruongKhoa));

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
                string sql = "DELETE FROM PhieuXetNghiemViKhuanLao WHERE ID = :ID";
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
                B.DonViYeuCau,
                B.Thon,
                B.PhuongXa,
                B.QuanHuyen,
                B.Tinh,
                B.DienThoai,
                B.SoDKDT,
                B.SoETBM,
                B.LyDoXetNghiem,
                B.ThangThu,
                B.XetNghiem_Khac,
                B.TienSuDTLao,
                B.TinhTrangH,
                B.LoaiBenhPham,
                B.LoaiBenhPham_Khac,
                B.ThoiGianLayMau,
                B.NguoiLayMau,
                B.MaNguoiLayMau,
                B.LoaiXetNghiemYeuCau, 
                B.MauSoNeelsen,
                B.MauSoHuynhQuan,
                B.LanThuXpert,
                B.LoaiXetNghiem_LyDo, 
                B.ChanDoanLao,
                B.LaoNgoaiPhoi_Text, 
                B.ChanDoanLaoDaKhangThuoc, 
                B.ChanDoanLaoTien,
                B.NghiThatBai_ThangThu,
                B.ChanDoanLaoTien_text, 
                B.DoiTuongKhac, 
                B.NguoiYeuCauXetNghiem,
                B.MaNguoiYeuCauXetNghiem, 
                B.SoXN, 
                B.PhongXetNghiem,
                B.ThoiGianNhanMau,
                B.NguoiNhanMau,
                B.MaNguoiNhanMau,
                B.ThoiGianLamXetNghiem,
                B.NguoiLamXN,
                B.MaNguoiLamXN,
                B.TrangThaiBenhNhan,
                B.NTMDinhDanh,
                B.MTB,
                B.Col1_Extra,
                B.Col2_Extra,
                B.TruongKhoa,
                B.MaTruongKhoa,
                B.NgayTao,
                H.TENBENHNHAN,
                H.Tuoi,
                H.GioiTinh,
                H.SOYTE,
                H.BENHVIEN,
                T.KHOA
            FROM
                PhieuXetNghiemViKhuanLao B
                LEFT JOIN HANHCHINHBENHNHAN H ON B.MABENHNHAN = H.MABENHNHAN
                LEFT JOIN THONGTINDIEUTRI T ON B.MAQUANLY = T.MAQUANLY
            WHERE
                ID = " + id;

            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
            MDB.MDBDataAdapter adt = new MDB.MDBDataAdapter(Command);
            var ds = new DataSet();

            adt.Fill(ds, "Table");

            sql = @"SELECT
                B.aFBTrucTiep,
                B.mTBDinhDanh,
                B.mTBNoiCay,
                B.NTMDinhDanh,
                B.mTBDaKhang,
                B.mTBKhangThuoc
            FROM
                PhieuXetNghiemViKhuanLao B
                
            WHERE
                ID = " + id;

            Command = new MDB.MDBCommand(sql, MyConnection);
            MDB.MDBDataReader DataReader = Command.ExecuteReader();
            AFBTrucTiep aFBTrucTiep = new AFBTrucTiep();
            MTBDinhDanh mTBDinhDanh = new MTBDinhDanh();
            MTBNuoiCay mTBNoiCay = new MTBNuoiCay();
            MTBDaKhang mTBDaKhang = new MTBDaKhang();
            ObservableCollection<MTBKhangThuoc> mTBKhangThuoc = new ObservableCollection<MTBKhangThuoc>();
            while (DataReader.Read())
            {
                aFBTrucTiep = JsonConvert.DeserializeObject<AFBTrucTiep>(DataReader["aFBTrucTiep"].ToString());
                mTBDinhDanh = JsonConvert.DeserializeObject<MTBDinhDanh>(DataReader["mTBDinhDanh"].ToString());
                mTBNoiCay = JsonConvert.DeserializeObject<MTBNuoiCay>(DataReader["mTBNoiCay"].ToString());
                mTBDaKhang = JsonConvert.DeserializeObject<MTBDaKhang>(DataReader["mTBDaKhang"].ToString());
                mTBKhangThuoc = JsonConvert.DeserializeObject<ObservableCollection<MTBKhangThuoc>>(DataReader["mTBKhangThuoc"].ToString());
                break;
            }

            DataTable AF = new DataTable("AF");
            AF.Columns.Add("AmTinh");
            AF.Columns.Add("SoLuongAFB");
            AF.Columns.Add("Plus1");
            AF.Columns.Add("Plus2");
            AF.Columns.Add("Plus3");

            AF.Rows.Add(aFBTrucTiep.AmTinh, aFBTrucTiep.SoLuongAFB, aFBTrucTiep.Plus1, aFBTrucTiep.Plus2, aFBTrucTiep.Plus3);
            ds.Tables.Add(AF);

            DataTable DinhDanh = new DataTable("DD");
            DinhDanh.Columns.Add("AmTinh");
            DinhDanh.Columns.Add("CoMTB1");
            DinhDanh.Columns.Add("CoMTB2");
            DinhDanh.Columns.Add("CoMTB3");
            DinhDanh.Columns.Add("Loi");

            DinhDanh.Rows.Add(mTBDinhDanh.AmTinh, mTBDinhDanh.CoMTB1, mTBDinhDanh.CoMTB2, mTBDinhDanh.CoMTB3, mTBDinhDanh.Loi);
            ds.Tables.Add(DinhDanh);

            DataTable NuoiCay = new DataTable("NC");
            NuoiCay.Columns.Add("AmTinh");
            NuoiCay.Columns.Add("MTB");
            NuoiCay.Columns.Add("NTM");
            NuoiCay.Columns.Add("NgoaiNhiem");

            NuoiCay.Rows.Add(mTBNoiCay.AmTinh, mTBNoiCay.MTB, mTBNoiCay.NTM, mTBNoiCay.NgoaiNhiem);
            ds.Tables.Add(NuoiCay);

            DataTable MTBDaKhang = new DataTable("DK");
            MTBDaKhang.Columns.Add("INH");
            MTBDaKhang.Columns.Add("RMP");
            MTBDaKhang.Columns.Add("Flu");
            MTBDaKhang.Columns.Add("KM");
            MTBDaKhang.Columns.Add("AMK");
            MTBDaKhang.Columns.Add("CAP");
            MTBDaKhang.Columns.Add("VMC");
            MTBDaKhang.Rows.Add(mTBDaKhang.INH, mTBDaKhang.RMP, mTBDaKhang.Flu, mTBDaKhang.KM, mTBDaKhang.AMK, mTBDaKhang.CAP, mTBDaKhang.VMC);
            ds.Tables.Add(MTBDaKhang);

            DataTable KhangThuoc = new DataTable("KT");
            KhangThuoc.Columns.Add("Chon", typeof(int));
            KhangThuoc.Columns.Add("MoiTruong");
            KhangThuoc.Columns.Add("INH1");
            KhangThuoc.Columns.Add("INH2");
            KhangThuoc.Columns.Add("RMP");
            KhangThuoc.Columns.Add("EMB");
            KhangThuoc.Columns.Add("SM");
            KhangThuoc.Columns.Add("PZA");
            KhangThuoc.Columns.Add("MOX1");
            KhangThuoc.Columns.Add("MOX2");
            KhangThuoc.Columns.Add("AMK");
            KhangThuoc.Columns.Add("KM");
            KhangThuoc.Columns.Add("CAP");
            KhangThuoc.Columns.Add("Col1");
            KhangThuoc.Columns.Add("Col2");
            KhangThuoc.Columns.Add("GhiChu");
            foreach (MTBKhangThuoc mTBKT in mTBKhangThuoc)
            {
                KhangThuoc.Rows.Add(mTBKT.Chon ? 1: 0,
                                mTBKT.MoiTruong,
                                mTBKT.INH1,
                                mTBKT.INH2,
                                mTBKT.RMP,
                                mTBKT.EMB,
                                mTBKT.SM,
                                mTBKT.PZA,
                                mTBKT.MOX1,
                                mTBKT.MOX2,
                                mTBKT.AMK,
                                mTBKT.KM,
                                mTBKT.CAP,
                                mTBKT.Col1,
                                mTBKT.Col2,
                                mTBKT.GhiChu);
            }
            ds.Tables.Add(KhangThuoc);
            return ds;
        }
    }
}
