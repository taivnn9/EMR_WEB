using EMR.KyDienTu;
using System;
using System.Collections.Generic;
using System.Data;
using PMS.Access;

namespace EMR_MAIN.DATABASE.Other
{
    public class ChamSocNguoiBenhCuaDieuDuong : ThongTinKy
    {
        public ChamSocNguoiBenhCuaDieuDuong()
        {
            TableName = "CHAMSOCNGUOIBENHCUADIEUDUONG";
            TablePrimaryKeyName = "ID";
            IDMauPhieu = (int)DanhMucPhieu.CSBNDD;
            TenMauPhieu = DanhMucPhieu.CSBNDD.Description();
        }
        [MoTaDuLieu("Mã định danh")]
		public decimal IDChamSocNguoiBenhCuaDieuDuong { get; set; }
        [MoTaDuLieu("Mã quản lý: mã duy nhất trong 1 đợt khám chữa bệnh (kcb), không trùng giữa các đợt kcb khác nhau","",1)]
		public decimal MaQuanLy { get; set; }
        [MoTaDuLieu("Ngày vào khoa")]
        public DateTime NgayVaoKhoa { get; set; }
        [MoTaDuLieu("Giờ vào khoa")]
        public DateTime? NgayVaoKhoa_Gio { get; set; }
        [MoTaDuLieu("Người liên hệ khi cần")]
        public string NguoiLienHeKhiCan { get; set; }
        [MoTaDuLieu("Bác sỹ tiếp nhận")]
        public string BacSyTiepNhan { get; set; }
        [MoTaDuLieu("Mạch")]
        public float Mach { get; set; }
        [MoTaDuLieu("Huyết áp cáo nhất")]
        public float HuyetApTren { get; set; }
        [MoTaDuLieu("Huyết áp thấp nhất")]
        public float HuyetApDuoi { get; set; }
        [MoTaDuLieu("Thân nhiệt")]
        public float ThanNhiet { get; set; }
        [MoTaDuLieu("Nhịp thở")]
        public float NhipTho { get; set; }
        [MoTaDuLieu("Chiều cao")]
        public float ChieuCao { get; set; }
        [MoTaDuLieu("Cân nặng")]
        public float CanNang { get; set; }[MoTaDuLieu("")]
        public bool[] TheTrangArray { get; } = new bool[] { false, false, false };
        [MoTaDuLieu("Thể trạng")]
        public int TheTrang
        {
            get
            {
                return Array.IndexOf(TheTrangArray, true);
            }
            set
            {
                for (int i = 0; i < 3; i++)
                {
                    if (i == value) TheTrangArray[i] = true;
                    else TheTrangArray[i] = false;
                }
            }
        }
        [MoTaDuLieu("Tiền sử")]
        public string TienSu { get; set; }
        public bool[] DiUngArray { get; } = new bool[] { false, false };
        [MoTaDuLieu("Dị ứng")]
        public int DiUng
        {
            get
            {
                return Array.IndexOf(DiUngArray, true);
            }
            set
            {
                for (int i = 0; i < 2; i++)
                {
                    if (i == value) DiUngArray[i] = true;
                    else DiUngArray[i] = false;
                }
            }
        }
        [MoTaDuLieu("Chất, thuốc dị ứng")]
        public string ChatThuocDiUng { get; set; }
        [MoTaDuLieu("Đánh giá về tâm thần kinh")]
        public string TamThanhKinh { get; set; }
        public bool[] TinhTrangBenhNhanArray { get; } = new bool[] { false, false, false };
        [MoTaDuLieu("Tình trạng bệnh nhân")]
        public int TinhTrangBenhNhan
        {
            get
            {
                return Array.IndexOf(TinhTrangBenhNhanArray, true);
            }
            set
            {
                for (int i = 0; i < 3; i++)
                {
                    if (i == value) TinhTrangBenhNhanArray[i] = true;
                    else TinhTrangBenhNhanArray[i] = false;
                }
            }
        }
        public bool[] BenhLyTimMachArray { get; } = new bool[] {false, false};
        [MoTaDuLieu("Bệnh lý tim mạch")]
        public int BenhLyTimMach
        {
            get
            {
                return Array.IndexOf(BenhLyTimMachArray, true);
            }
            set
            {
                for (int i = 0; i < 2; i++)
                {
                    if (i == value) BenhLyTimMachArray[i] = true;
                    else BenhLyTimMachArray[i] = false;
                }
            }
        }
        public bool[] KhoThoArray { get; } = new bool[] { false, false };
        [MoTaDuLieu("Khó thở")]
        public int KhoTho
        {
            get
            {
                return Array.IndexOf(KhoThoArray, true);
            }
            set
            {
                for (int i = 0; i < 2; i++)
                {
                    if (i == value) KhoThoArray[i] = true;
                    else KhoThoArray[i] = false;
                }
            }
        }
        public bool[] RoiLoanTieuTienArray { get; } = new bool[] { false, false };
        [MoTaDuLieu("Rối loạn tiểu tiện")]
        public int RoiLoanTieuTien
        {
            get
            {
                return Array.IndexOf(RoiLoanTieuTienArray, true);
            }
            set
            {
                for (int i = 0; i < 2; i++)
                {
                    if (i == value) RoiLoanTieuTienArray[i] = true;
                    else RoiLoanTieuTienArray[i] = false;
                }
            }
        }
        public bool[] CamGiacKhiAnArray { get; } = new bool[] { false, false, false };
        [MoTaDuLieu("Cảm giác khi ăn")]
        public int CamGiacKhiAn
        {
            get
            {
                return Array.IndexOf(CamGiacKhiAnArray, true);
            }
            set
            {
                for (int i = 0; i < 3; i++)
                {
                    if (i == value) CamGiacKhiAnArray[i] = true;
                    else CamGiacKhiAnArray[i] = false;
                }
            }
        }
        public bool[] DuongAnUongArray { get; } = new bool[] { false, false, false };
        [MoTaDuLieu("Đường ăn uống")]
        public int DuongAnUong
        {
            get
            {
                return Array.IndexOf(DuongAnUongArray, true);
            }
            set
            {
                for (int i = 0; i < 3; i++)
                {
                    if (i == value) DuongAnUongArray[i] = true;
                    else DuongAnUongArray[i] = false;
                }
            }
        }
        public bool[] MauSacArray { get; } = new bool[] { false, false, false, false };
        [MoTaDuLieu("Màu sắc")]
        public int MauSac
        {
            get
            {
                return Array.IndexOf(MauSacArray, true);
            }
            set
            {
                for (int i = 0; i < 4; i++)
                {
                    if (i == value) MauSacArray[i] = true;
                    else MauSacArray[i] = false;
                }
            }
        }
        public bool[] TamLyArray { get; } = new bool[] { false, false, false, false, false };
        [MoTaDuLieu("Tâm lý")]
        public int TamLy
        {
            get
            {
                return Array.IndexOf(TamLyArray, true);
            }
            set
            {
                for (int i = 0; i < 5; i++)
                {
                    if (i == value) TamLyArray[i] = true;
                    else TamLyArray[i] = false;
                }
            }
        }
        public bool[] KhaNangNgheArray { get; } = new bool[] { false, false, false, false };
        [MoTaDuLieu("Khả năng nghe")]
        public int KhaNangNghe
        {
            get
            {
                return Array.IndexOf(KhaNangNgheArray, true);
            }
            set
            {
                for (int i = 0; i < 4; i++)
                {
                    if (i == value) KhaNangNgheArray[i] = true;
                    else KhaNangNgheArray[i] = false;
                }
            }
        }
        public bool[] KhaNangNoiArray { get; } = new bool[] { false, false, false, false };
        [MoTaDuLieu("Khả năng nói")]
        public int KhaNangNoi
        {
            get
            {
                return Array.IndexOf(KhaNangNoiArray, true);
            }
            set
            {
                for (int i = 0; i < 4; i++)
                {
                    if (i == value) KhaNangNoiArray[i] = true;
                    else KhaNangNoiArray[i] = false;
                }
            }
        }
        public bool[] KhaNangNhinArray { get; } = new bool[] { false, false, false, false };
        [MoTaDuLieu("Khả năng nhịn")]
        public int KhaNangNhin
        {
            get
            {
                return Array.IndexOf(KhaNangNhinArray, true);
            }
            set
            {
                for (int i = 0; i < 4; i++)
                {
                    if (i == value) KhaNangNhinArray[i] = true;
                    else KhaNangNhinArray[i] = false;
                }
            }
        }
        public bool[] VeSinhCaNhanArray { get; } = new bool[] { false, false, false, false };
        [MoTaDuLieu("Vệ sinh cá nhân")]
        public int VeSinhCaNhan
        {
            get
            {
                return Array.IndexOf(VeSinhCaNhanArray, true);
            }
            set
            {
                for (int i = 0; i < 4; i++)
                {
                    if (i == value) VeSinhCaNhanArray[i] = true;
                    else VeSinhCaNhanArray[i] = false;
                }
            }
        }
        public bool[] KhaNangVanDongArray { get; } = new bool[] { false, false, false, false };
        [MoTaDuLieu("Khả năng vận động")]
        public int KhaNangVanDong
        {
            get
            {
                return Array.IndexOf(KhaNangVanDongArray, true);
            }
            set
            {
                for (int i = 0; i < 4; i++)
                {
                    if (i == value) KhaNangVanDongArray[i] = true;
                    else KhaNangVanDongArray[i] = false;
                }
            }
        }
        [MoTaDuLieu("Mang thai")]
        public bool MangThai { get; set; }
        [MoTaDuLieu("Số tuần")]
        public float SoTuan { get; set; }
        [MoTaDuLieu("Đang cho con bú")]
        public bool DangChoConBu { get; set; }
        [MoTaDuLieu("PARA")]
        public string Para { get; set; }
        public bool[] MatArray { get; } = new bool[] { false, false, false, false, false };
        [MoTaDuLieu("Mắt")]
        public string Mat
        {
            get
            {
               string temp = String.Empty;
                for (int i = 0; i < MatArray.Length; i++)
                    temp += (MatArray[i] ? "1":"0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        MatArray[i] = intTemp == 1 ? true:false ;
                    }
                }
            }
        }
        [MoTaDuLieu("Bệnh lý mắt")]
        public string BenhLyMat { get; set; }
        public bool[] TaiArray { get; } = new bool[] { false, false };
        [MoTaDuLieu("Tai")]
        public string Tai
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < TaiArray.Length; i++)
                    temp +=  (TaiArray[i] ? "1":"0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        TaiArray[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        [MoTaDuLieu("Bệnh lý tai")]
        public string BenhLyTai { get; set; }
        public bool[] MuiArray { get; } = new bool[] { false, false, false };
        [MoTaDuLieu("Mũi")]
        public string Mui
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < MuiArray.Length; i++)
                    temp += (MuiArray[i] ? "1":"0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        MuiArray[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        [MoTaDuLieu("Bệnh lý mũi")]
        public string BenhLyMui{ get; set; }
        public bool[] HongArray { get; } = new bool[] { false, false, false };
        [MoTaDuLieu("Họng")]
        public string Hong
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < HongArray.Length; i++)
                    temp += (HongArray[i] ? "1":"0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        HongArray[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        [MoTaDuLieu("Bệnh lý họng")]
        public string BenhLyHong { get; set; }
        public bool[] RangGiaArray { get; } = new bool[] { false, false, false, false };
        [MoTaDuLieu("Răng giả")]
        public string RangGia
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < RangGiaArray.Length; i++)
                    temp += (RangGiaArray[i] ? "1":"0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        RangGiaArray[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        [MoTaDuLieu("Bệnh lý răng giả")]
        public string BenhLyRangGia { get; set; }
        [MoTaDuLieu("Đau(vị trí)")]
        public string DauViTri { get; set; }
        [MoTaDuLieu("Có mức độ đau")]
        public bool CoMucDoDau { get; set; }
        public bool[] MucDoDauArray { get; } = new bool[] { false, false, false, false, false, false };
        [MoTaDuLieu("Mức độ đau")]
        public int MucDoDau
        {
            get
            {
                return Array.IndexOf(MucDoDauArray, true);
            }
            set
            {
                for (int i = 0; i < 6; i++)
                {
                    if (i == value) MucDoDauArray[i] = true;
                    else MucDoDauArray[i] = false;
                }
            }
        }
        [MoTaDuLieu("Nguy cơ loét")]
        public string NguyCoLoet { get; set; }
        [MoTaDuLieu("Có mức độ nguy cơ BRADEN")]
        public bool CoNguyCoBranden { get; set; }
        public bool[] NguyCoBrandenArray { get; } = new bool[] { false, false, false, false};
        [MoTaDuLieu("Có mức độ nguy cơ Branden")]
        public int NguyCoBranden
        {
            get
            {
                return Array.IndexOf(NguyCoBrandenArray, true);
            }
            set
            {
                for (int i = 0; i < 4; i++)
                {
                    if (i == value) NguyCoBrandenArray[i] = true;
                    else NguyCoBrandenArray[i] = false;
                }
            }
        }
        [MoTaDuLieu("Nguy cơ té ngã")]
        public string NguyCoTeNga { get; set; }
        [MoTaDuLieu("Có mức độ nguy cơ MORSE")]
        public bool CoNguyCoMorse { get; set; }
        public bool[] NguyCoMorseArray { get; } = new bool[] { false, false, false };
        [MoTaDuLieu("Nguy cơ Morse")]
        public int NguyCoMorse
        {
            get
            {
                return Array.IndexOf(NguyCoMorseArray, true);
            }
            set
            {
                for (int i = 0; i < 3; i++)
                {
                    if (i == value) NguyCoMorseArray[i] = true;
                    else NguyCoMorseArray[i] = false;
                }
            }
        }
        public bool[] KeHoachXuatVienArray { get; } = new bool[] { false, false, false, false, false };
        [MoTaDuLieu("Kế hoạch xuất viện")]
        public string KeHoachXuatVien
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < KeHoachXuatVienArray.Length; i++)
                    temp += (KeHoachXuatVienArray[i] ? "1":"0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        KeHoachXuatVienArray[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        [MoTaDuLieu("Chẩn đoán của bác sỹ")]
		public string ChanDoanCuaBacSy { get; set; }
        public bool[] CheDoChamSocArray { get; } = new bool[] { false, false, false };
        [MoTaDuLieu("Chế độ chăm sóc")]
        public int CheDoChamSoc
        {
            get
            {
                return Array.IndexOf(CheDoChamSocArray, true);
            }
            set
            {
                for (int i = 0; i < 3; i++)
                {
                    if (i == value) CheDoChamSocArray[i] = true;
                    else CheDoChamSocArray[i] = false;
                }
            }
        }
        [MoTaDuLieu("Theo dõi mạch")]
        public string TheoDoiMach { get; set; }
        [MoTaDuLieu("Theo dõi nhiệt độ")]
        public string TheoDoiNhietDo { get; set; }
        [MoTaDuLieu("Theo dõi nhịp thở")]
        public string TheoDoiNhipTho{ get; set; }
        [MoTaDuLieu("Theo dõi ý thức")]
        public string TheoDoiYThuc { get; set; }
        [MoTaDuLieu("Tại chỗ")]
        public string TaiCho { get; set; }
        [MoTaDuLieu("Thực hiện y lệnh điều trị: thuốc")]
        public string YLenhDieuTri_Thuoc { get; set; }
        [MoTaDuLieu("Thực hiện y lệnh điều trị: xét nghiệm")]
        public string YLenhDieuTri_XetNghiem { get; set; }
        [MoTaDuLieu("Thực hiện y lệnh điều trị: khác")]
        public string YLenhDieuTri_Khac { get; set; }
        [MoTaDuLieu("Dự kiến chăm sóc")]
        public string DuKienChamSoc { get; set; }
        public bool[] CheDoAnArray { get; } = new bool[] { false, false, false, false, false };
        [MoTaDuLieu("Chế độ ăn")]
        public int CheDoAn
        {
            get
            {
                return Array.IndexOf(CheDoAnArray, true);
            }
            set
            {
                for (int i = 0; i < 5; i++)
                {
                    if (i == value) CheDoAnArray[i] = true;
                    else CheDoAnArray[i] = false;
                }
            }
        }
        [MoTaDuLieu("Chế độ dinh dưỡng khác")]
        public string CheDoDinhDuongKhac { get; set; }
        [MoTaDuLieu("Hướng dẫn vệ sinh cá  nhân")]
        public string HuongDanVeSinhCaNhan { get; set; }
        [MoTaDuLieu("Hướng dẫn giáo dục sức khoẻ")]
        public string HuongDanGiaoDucSucKhoe { get; set; }
        [MoTaDuLieu("Chăm sóc khác")]
        public string ChamSocKhac { get; set; }
        [MoTaDuLieu("Mã điều dưỡng lập phiếu")]
		public string MaDieuDuongLapPhieu { get; set; }
        [MoTaDuLieu("Họ tên điều dưỡng lập phiếu")]
		public string DieuDuongLapPhieu { get; set; }
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
        public bool DaKy { get; set; }
    }
    public class ChamSocNguoiBenhCuaDieuDuongFunc
    {
        public const string TableName = "ChamSocNguoiBenhCuaDieuDuong";
        public const string TablePrimaryKeyName = "IDCHAMSOCNGUOIBENHCUADIEUDUONG";
        public static List<ChamSocNguoiBenhCuaDieuDuong> GetListData(MDB.MDBConnection _OracleConnection, decimal maquanly)
        {
            List<ChamSocNguoiBenhCuaDieuDuong> list = new List<ChamSocNguoiBenhCuaDieuDuong>();
            try
            {
                string sql = @"SELECT * FROM ChamSocNguoiBenhCuaDieuDuong where MaQuanLy = :MaQuanLy and XOA = 0";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, _OracleConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", maquanly));
                MDB.MDBDataReader DataReader = Command.ExecuteReader();
                while (DataReader.Read())
                {
                    ChamSocNguoiBenhCuaDieuDuong data = new ChamSocNguoiBenhCuaDieuDuong();
                    data.IDChamSocNguoiBenhCuaDieuDuong = Convert.ToInt64(DataReader.GetLong("IDCHAMSOCNGUOIBENHCUADIEUDUONG").ToString());
                    data.MaQuanLy = maquanly;
                    data.NgayVaoKhoa = Convert.ToDateTime(DataReader["NGAYVAOKHOA"] == DBNull.Value ? DateTime.Now : DataReader["NGAYVAOKHOA"]);
                    data.NguoiLienHeKhiCan = DataReader["NGUOILIENHEKHICAN"].ToString();
                    data.BacSyTiepNhan = DataReader["BACSYTIEPNHAN"].ToString();
                    float floatTemp = 0;
                    float.TryParse(DataReader["MACH"].ToString(), out floatTemp);
                    data.Mach = floatTemp;

                    floatTemp = 0;
                    float.TryParse(DataReader["HUYETAPTREN"].ToString(), out floatTemp);
                    data.HuyetApTren = floatTemp;

                    floatTemp = 0;
                    float.TryParse(DataReader["HUYETAPDUOI"].ToString(), out floatTemp);
                    data.HuyetApDuoi = floatTemp;
                    
                    floatTemp = 0;
                    float.TryParse(DataReader["THANNHIET"].ToString(), out floatTemp);
                    data.ThanNhiet = floatTemp;

                    floatTemp = 0;
                    float.TryParse(DataReader["NHIPTHO"].ToString(), out floatTemp);
                    data.NhipTho = floatTemp;

                    floatTemp = 0;
                    float.TryParse(DataReader["CHIEUCAO"].ToString(), out floatTemp);
                    data.ChieuCao = floatTemp;
                    
                    floatTemp = 0;
                    float.TryParse(DataReader["CANNANG"].ToString(), out floatTemp);
                    data.CanNang = floatTemp;
                    
                    int intTemp = 0;
                    int.TryParse(DataReader["THETRANG"].ToString(), out intTemp);
                    data.TheTrang = intTemp;
                    data.TienSu = DataReader["TIENSU"].ToString();
                    intTemp = 0;
                    int.TryParse(DataReader["DIUNG"].ToString(), out intTemp);
                    data.DiUng = intTemp;

                    data.ChatThuocDiUng = DataReader["CHATTHUOCDIUNG"].ToString();
                    data.TamThanhKinh = DataReader["TAMTHANHKINH"].ToString();

                    intTemp = 0;
                    int.TryParse(DataReader["TINHTRANGBENHNHAN"].ToString(), out intTemp);
                    data.TinhTrangBenhNhan = intTemp;

                    intTemp = 0;
                    int.TryParse(DataReader["BENHLYTIMMACH"].ToString(), out intTemp);
                    data.BenhLyTimMach = intTemp;

                    intTemp = 0;
                    int.TryParse(DataReader["KHOTHO"].ToString(), out intTemp);
                    data.KhoTho = intTemp;

                    intTemp = 0;
                    int.TryParse(DataReader["ROILOANTIEUTIEN"].ToString(), out intTemp);
                    data.RoiLoanTieuTien = intTemp;

                    intTemp = 0;
                    int.TryParse(DataReader["CAMGIACKHIAN"].ToString(), out intTemp);
                    data.CamGiacKhiAn = intTemp;

                    intTemp = 0;
                    int.TryParse(DataReader["DUONGANUONG"].ToString(), out intTemp);
                    data.DuongAnUong = intTemp;

                    intTemp = 0;
                    int.TryParse(DataReader["MAUSAC"].ToString(), out intTemp);
                    data.MauSac = intTemp;

                    intTemp = 0;
                    int.TryParse(DataReader["TAMLY"].ToString(), out intTemp);
                    data.TamLy = intTemp;

                    intTemp = 0;
                    int.TryParse(DataReader["KHANANGNGHE"].ToString(), out intTemp);
                    data.KhaNangNghe = intTemp;

                    intTemp = 0;
                    int.TryParse(DataReader["KHANANGNOI"].ToString(), out intTemp);
                    data.KhaNangNoi = intTemp;

                    intTemp = 0;
                    int.TryParse(DataReader["KHANANGNHIN"].ToString(), out intTemp);
                    data.KhaNangNhin = intTemp;

                    intTemp = 0;
                    int.TryParse(DataReader["VESINHCANHAN"].ToString(), out intTemp);
                    data.VeSinhCaNhan = intTemp;

                    intTemp = 0;
                    int.TryParse(DataReader["KHANANGVANDONG"].ToString(), out intTemp);
                    data.KhaNangVanDong = intTemp;

                    intTemp = 0;
                    int.TryParse(DataReader["MANGTHAI"].ToString(), out intTemp);
                    data.MangThai = intTemp == 1 ? true:false;

                    floatTemp = 0;
                    float.TryParse(DataReader["SOTUAN"].ToString(), out floatTemp);
                    data.SoTuan = floatTemp;

                    intTemp = 0;
                    int.TryParse(DataReader["DANGCHOCONBU"].ToString(), out intTemp);
                    data.DangChoConBu = intTemp == 1 ? true : false;

                    data.Para = DataReader["PARA"].ToString();

                    data.Mat = DataReader["MAT"].ToString();
                    data.BenhLyMat = DataReader["BENHLYMAT"].ToString();

                    data.Tai = DataReader["TAI"].ToString();
                    data.BenhLyTai = DataReader["BENHLYTAI"].ToString();

                    data.Mui = DataReader["MUI"].ToString();
                    data.BenhLyMui = DataReader["BENHLYMUI"].ToString();

                    data.Hong = DataReader["HONG"].ToString();
                    data.BenhLyHong = DataReader["BENHLYHONG"].ToString();

                    data.RangGia = DataReader["RANGGIA"].ToString();
                    data.BenhLyRangGia = DataReader["BENHLYRANGGIA"].ToString();
                    data.DauViTri = DataReader["DAUVITRI"].ToString();
                    intTemp = 0;
                    int.TryParse(DataReader["COMUCDODAU"].ToString(), out intTemp);
                    data.CoMucDoDau = intTemp == 1 ? true:false;

                    data.NguyCoLoet = DataReader["NGUYCOLOET"].ToString();

                    intTemp = 0;
                    int.TryParse(DataReader["CONGUYCOBRANDEN"].ToString(), out intTemp);
                    data.CoNguyCoBranden = intTemp == 1 ? true : false;

                    intTemp = 0;
                    int.TryParse(DataReader["NGUYCOBRANDEN"].ToString(), out intTemp);
                    data.NguyCoBranden = intTemp;

                    data.NguyCoTeNga = DataReader["NGUYCOTENGA"].ToString();

                    intTemp = 0;
                    int.TryParse(DataReader["CONGUYCOMORSE"].ToString(), out intTemp);
                    data.CoNguyCoMorse = intTemp == 1 ? true : false;

                    intTemp = 0;
                    int.TryParse(DataReader["NGUYCOMORSE"].ToString(), out intTemp);
                    data.NguyCoMorse = intTemp;

                    data.KeHoachXuatVien = DataReader["KEHOACHXUATVIEN"].ToString();
                    data.ChanDoanCuaBacSy = DataReader["CHANDOANCUABACSY"].ToString();
                    intTemp = 0;
                    int.TryParse(DataReader["CHEDOCHAMSOC"].ToString(), out intTemp);
                    data.CheDoChamSoc = intTemp;
                    data.TheoDoiMach = DataReader["THEODOIMACH"].ToString();
                    data.TheoDoiNhietDo = DataReader["THEODOINHIETDO"].ToString();
                    data.TheoDoiNhipTho = DataReader["THEODOINHIPTHO"].ToString();
                    data.TheoDoiYThuc = DataReader["THEODOIYTHUC"].ToString();
                    data.TaiCho = DataReader["TAICHO"].ToString();
                    data.YLenhDieuTri_Thuoc = DataReader["YLENHDIEUTRI_THUOC"].ToString();
                    data.YLenhDieuTri_XetNghiem = DataReader["YLENHDIEUTRI_XETNGHIEM"].ToString();
                    data.YLenhDieuTri_Khac = DataReader["YLENHDIEUTRI_KHAC"].ToString();
                    data.DuKienChamSoc = DataReader["DUKIENCHAMSOC"].ToString();
                    intTemp = 0;
                    int.TryParse(DataReader["CHEDOAN"].ToString(), out intTemp);
                    data.CheDoAn = intTemp;
                    data.CheDoDinhDuongKhac = DataReader["CHEDODINHDUONGKHAC"].ToString();
                    data.HuongDanVeSinhCaNhan = DataReader["HUONGDANVESINHCANHAN"].ToString();
                    data.HuongDanGiaoDucSucKhoe = DataReader["HUONGDANGIAODUCSUCKHOE"].ToString();
                    data.ChamSocKhac = DataReader["CHAMSOCKHAC"].ToString();
                    data.MaDieuDuongLapPhieu = DataReader["MADIEUDUONGLAPPHIEU"].ToString();
                    data.DieuDuongLapPhieu = DataReader["DIEUDUONGLAPPHIEU"].ToString();
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
        public static bool InsertOrUpdate(MDB.MDBConnection MyConnection, ref ChamSocNguoiBenhCuaDieuDuong chamSoc)
        {
            string sql = @"INSERT INTO CHAMSOCNGUOIBENHCUADIEUDUONG
                (
                    MAQUANLY,
                    NGAYVAOKHOA,
                    NGUOILIENHEKHICAN,
                    BACSYTIEPNHAN,
                    MACH,
                    HUYETAPTREN,
                    HUYETAPDUOI,
                    THANNHIET,
                    NHIPTHO,
                    CHIEUCAO,
                    CANNANG,
                    THETRANG,
                    TIENSU,
                    DIUNG,
                    CHATTHUOCDIUNG,
                    TAMTHANHKINH,
                    TINHTRANGBENHNHAN,
                    BENHLYTIMMACH,
                    KHOTHO,
                    ROILOANTIEUTIEN,
                    CAMGIACKHIAN,
                    DUONGANUONG,
                    MAUSAC,
                    TAMLY,
                    KHANANGNGHE,
                    KHANANGNOI,
                    KHANANGNHIN,
                    VESINHCANHAN,
                    KHANANGVANDONG,
                    MANGTHAI,
                    SOTUAN,
                    DANGCHOCONBU,
                    PARA,
                    MAT,
                    BENHLYMAT,
                    TAI,
                    BENHLYTAI,
                    MUI,
                    BENHLYMUI,
                    HONG,
                    BENHLYHONG,
                    RANGGIA,
                    BENHLYRANGGIA,
                    DAUVITRI,
                    COMUCDODAU,
                    MUCDODAU,
                    NGUYCOLOET,
                    CONGUYCOBRANDEN,
                    NGUYCOBRANDEN,
                    NGUYCOTENGA,
                    CONGUYCOMORSE,
                    NGUYCOMORSE,
                    KEHOACHXUATVIEN,
                    CHANDOANCUABACSY,
                    CHEDOCHAMSOC,
                    THEODOIMACH,
                    THEODOINHIETDO,
                    THEODOINHIPTHO,
                    THEODOIYTHUC,
                    TAICHO,
                    YLENHDIEUTRI_THUOC,
                    YLENHDIEUTRI_XETNGHIEM,
                    YLENHDIEUTRI_KHAC,
                    DUKIENCHAMSOC,
                    CHEDOAN,
                    CHEDODINHDUONGKHAC,
                    HUONGDANVESINHCANHAN,
                    HUONGDANGIAODUCSUCKHOE,
                    CHAMSOCKHAC,
                    MADIEUDUONGLAPPHIEU,
                    DIEUDUONGLAPPHIEU,
                    XOA,
                    NGUOITAO,
                    NGUOISUA,
                    NGAYTAO,
                    NGAYSUA)  VALUES
                 (
					:MAQUANLY,
                    :NGAYVAOKHOA,
                    :NGUOILIENHEKHICAN,
                    :BACSYTIEPNHAN,
                    :MACH,
					:HUYETAPTREN,
					:HUYETAPDUOI,
					:THANNHIET,
                    :NHIPTHO,
					:CHIEUCAO,
					:CANNANG,
					:THETRANG,
                    :TIENSU,
					:DIUNG,
					:CHATTHUOCDIUNG,
                    :TAMTHANHKINH,
					:TINHTRANGBENHNHAN,
					:BENHLYTIMMACH,
					:KHOTHO,
					:ROILOANTIEUTIEN,
					:CAMGIACKHIAN,
					:DUONGANUONG,
					:MAUSAC,
					:TAMLY,
					:KHANANGNGHE,
					:KHANANGNOI,
					:KHANANGNHIN,
					:VESINHCANHAN,
					:KHANANGVANDONG,
					:MANGTHAI,
					:SOTUAN,
					:DANGCHOCONBU,
					:PARA,
					:MAT,
					:BENHLYMAT,
					:TAI,
					:BENHLYTAI,
					:MUI,
					:BENHLYMUI,
					:HONG,
					:BENHLYHONG,
					:RANGGIA,
					:BENHLYRANGGIA,
					:DAUVITRI,
					:COMUCDODAU,
					:MUCDODAU,
					:NGUYCOLOET,
					:CONGUYCOBRANDEN,
					:NGUYCOBRANDEN,
					:NGUYCOTENGA,
					:CONGUYCOMORSE,
					:NGUYCOMORSE,
					:KEHOACHXUATVIEN,
					:CHANDOANCUABACSY,
					:CHEDOCHAMSOC,
					:THEODOIMACH,
					:THEODOINHIETDO,
					:THEODOINHIPTHO,
					:THEODOIYTHUC,
					:TAICHO,
					:YLENHDIEUTRI_THUOC,
					:YLENHDIEUTRI_XETNGHIEM,
					:YLENHDIEUTRI_KHAC,
					:DUKIENCHAMSOC,
					:CHEDOAN,
					:CHEDODINHDUONGKHAC,
					:HUONGDANVESINHCANHAN,
					:HUONGDANGIAODUCSUCKHOE,
					:CHAMSOCKHAC,
                    :MADIEUDUONGLAPPHIEU,
					:DIEUDUONGLAPPHIEU,
                    0,
					:NGUOITAO,
					:NGUOISUA,
					:NGAYTAO,
					:NGAYSUA
                 )  RETURNING IDCHAMSOCNGUOIBENHCUADIEUDUONG INTO :IDCHAMSOCNGUOIBENHCUADIEUDUONG";
            if(chamSoc.IDChamSocNguoiBenhCuaDieuDuong != Decimal.Zero)
            {
                sql = @"UPDATE CHAMSOCNGUOIBENHCUADIEUDUONG SET 
                    MAQUANLY = :MAQUANLY,
                    NGAYVAOKHOA = :NGAYVAOKHOA,
                    NGUOILIENHEKHICAN = :NGUOILIENHEKHICAN,
                    BACSYTIEPNHAN = :BACSYTIEPNHAN,
                    MACH = :MACH, 
					HUYETAPTREN = :HUYETAPTREN, 
					HUYETAPDUOI = :HUYETAPDUOI, 
					THANNHIET = :THANNHIET, 
                    NHIPTHO = :NHIPTHO,
					CHIEUCAO = :CHIEUCAO, 
					CANNANG = :CANNANG, 
					THETRANG = :THETRANG, 
                    TIENSU = :TIENSU,
					DIUNG = :DIUNG, 
					CHATTHUOCDIUNG = :CHATTHUOCDIUNG, 
                    TAMTHANHKINH = :TAMTHANHKINH,
					TINHTRANGBENHNHAN = :TINHTRANGBENHNHAN, 
					BENHLYTIMMACH = :BENHLYTIMMACH, 
					KHOTHO = :KHOTHO, 
					ROILOANTIEUTIEN = :ROILOANTIEUTIEN, 
					CAMGIACKHIAN = :CAMGIACKHIAN, 
					DUONGANUONG = :DUONGANUONG, 
					MAUSAC = :MAUSAC, 
					TAMLY = :TAMLY, 
					KHANANGNGHE = :KHANANGNGHE, 
					KHANANGNOI = :KHANANGNOI, 
					KHANANGNHIN = :KHANANGNHIN, 
					VESINHCANHAN = :VESINHCANHAN, 
					KHANANGVANDONG = :KHANANGVANDONG, 
					MANGTHAI = :MANGTHAI, 
					SOTUAN = :SOTUAN, 
					DANGCHOCONBU = :DANGCHOCONBU, 
					PARA = :PARA, 
					MAT = :MAT, 
					BENHLYMAT = :BENHLYMAT, 
					TAI = :TAI, 
					BENHLYTAI = :BENHLYTAI, 
					MUI = :MUI, 
					BENHLYMUI = :BENHLYMUI, 
					HONG = :HONG, 
					BENHLYHONG = :BENHLYHONG, 
					RANGGIA = :RANGGIA, 
					BENHLYRANGGIA = :BENHLYRANGGIA, 
					DAUVITRI = :DAUVITRI, 
					COMUCDODAU = :COMUCDODAU, 
					MUCDODAU = :MUCDODAU, 
					NGUYCOLOET = :NGUYCOLOET, 
					CONGUYCOBRANDEN = :CONGUYCOBRANDEN, 
					NGUYCOBRANDEN = :NGUYCOBRANDEN, 
					NGUYCOTENGA = :NGUYCOTENGA, 
					CONGUYCOMORSE = :CONGUYCOMORSE, 
					NGUYCOMORSE = :NGUYCOMORSE, 
					KEHOACHXUATVIEN = :KEHOACHXUATVIEN, 
					CHANDOANCUABACSY = :CHANDOANCUABACSY, 
					CHEDOCHAMSOC = :CHEDOCHAMSOC, 
					THEODOIMACH = :THEODOIMACH, 
					THEODOINHIETDO = :THEODOINHIETDO, 
					THEODOINHIPTHO = :THEODOINHIPTHO, 
					THEODOIYTHUC = :THEODOIYTHUC, 
					TAICHO = :TAICHO, 
					YLENHDIEUTRI_THUOC = :YLENHDIEUTRI_THUOC, 
					YLENHDIEUTRI_XETNGHIEM = :YLENHDIEUTRI_XETNGHIEM, 
					YLENHDIEUTRI_KHAC = :YLENHDIEUTRI_KHAC, 
					DUKIENCHAMSOC = :DUKIENCHAMSOC, 
					CHEDOAN = :CHEDOAN, 
					CHEDODINHDUONGKHAC = :CHEDODINHDUONGKHAC, 
					HUONGDANVESINHCANHAN = :HUONGDANVESINHCANHAN, 
					HUONGDANGIAODUCSUCKHOE = :HUONGDANGIAODUCSUCKHOE, 
					CHAMSOCKHAC = :CHAMSOCKHAC, 
                    MADIEUDUONGLAPPHIEU = :MADIEUDUONGLAPPHIEU,
					DIEUDUONGLAPPHIEU =:DIEUDUONGLAPPHIEU,
					NGUOISUA = :NGUOISUA, 
					NGAYSUA = :NGAYSUA 
                    WHERE IDCHAMSOCNGUOIBENHCUADIEUDUONG = " + chamSoc.IDChamSocNguoiBenhCuaDieuDuong;

            }
            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
            Command.Parameters.Add(new MDB.MDBParameter("MAQUANLY", chamSoc.MaQuanLy));
            var Ngay = chamSoc.NgayVaoKhoa.Date.Add(new TimeSpan(0, 0, 0));
            var Gio = chamSoc.NgayVaoKhoa_Gio != null ? chamSoc.NgayVaoKhoa_Gio.Value.TimeOfDay : DateTime.Now.TimeOfDay;
            var ngayVaoKhoa = Ngay + Gio;
            Command.Parameters.Add(new MDB.MDBParameter("NGAYVAOKHOA", ngayVaoKhoa));
            Command.Parameters.Add(new MDB.MDBParameter("NGUOILIENHEKHICAN", chamSoc.NguoiLienHeKhiCan));
            Command.Parameters.Add(new MDB.MDBParameter("BACSYTIEPNHAN", chamSoc.BacSyTiepNhan));
            Command.Parameters.Add(new MDB.MDBParameter("MACH", chamSoc.Mach));
            Command.Parameters.Add(new MDB.MDBParameter("HUYETAPTREN", chamSoc.HuyetApTren));
            Command.Parameters.Add(new MDB.MDBParameter("HUYETAPDUOI", chamSoc.HuyetApDuoi)); 
            Command.Parameters.Add(new MDB.MDBParameter("THANNHIET", chamSoc.ThanNhiet));
            Command.Parameters.Add(new MDB.MDBParameter("NHIPTHO", chamSoc.NhipTho));
            Command.Parameters.Add(new MDB.MDBParameter("CHIEUCAO", chamSoc.ChieuCao));
            Command.Parameters.Add(new MDB.MDBParameter("CANNANG", chamSoc.CanNang));
            Command.Parameters.Add(new MDB.MDBParameter("THETRANG", chamSoc.TheTrang));
            Command.Parameters.Add(new MDB.MDBParameter("TIENSU", chamSoc.TienSu));
            Command.Parameters.Add(new MDB.MDBParameter("DIUNG", chamSoc.DiUng));
            Command.Parameters.Add(new MDB.MDBParameter("CHATTHUOCDIUNG", chamSoc.ChatThuocDiUng));
            Command.Parameters.Add(new MDB.MDBParameter("TAMTHANHKINH", chamSoc.TamThanhKinh));
            Command.Parameters.Add(new MDB.MDBParameter("TINHTRANGBENHNHAN", chamSoc.TinhTrangBenhNhan));
            Command.Parameters.Add(new MDB.MDBParameter("BENHLYTIMMACH", chamSoc.BenhLyTimMach));
            Command.Parameters.Add(new MDB.MDBParameter("KHOTHO", chamSoc.KhoTho));
            Command.Parameters.Add(new MDB.MDBParameter("ROILOANTIEUTIEN", chamSoc.RoiLoanTieuTien));
            Command.Parameters.Add(new MDB.MDBParameter("CAMGIACKHIAN", chamSoc.CamGiacKhiAn));
            Command.Parameters.Add(new MDB.MDBParameter("DUONGANUONG", chamSoc.DuongAnUong));
            Command.Parameters.Add(new MDB.MDBParameter("MAUSAC", chamSoc.MauSac));
            Command.Parameters.Add(new MDB.MDBParameter("TAMLY", chamSoc.TamLy));
            Command.Parameters.Add(new MDB.MDBParameter("KHANANGNGHE", chamSoc.KhaNangNghe));
            Command.Parameters.Add(new MDB.MDBParameter("KHANANGNOI", chamSoc.KhaNangNoi));
            Command.Parameters.Add(new MDB.MDBParameter("KHANANGNHIN", chamSoc.KhaNangNhin));
            Command.Parameters.Add(new MDB.MDBParameter("VESINHCANHAN", chamSoc.VeSinhCaNhan));
            Command.Parameters.Add(new MDB.MDBParameter("KHANANGVANDONG", chamSoc.KhaNangVanDong));
            Command.Parameters.Add(new MDB.MDBParameter("MANGTHAI", chamSoc.MangThai ? 1:0));
            Command.Parameters.Add(new MDB.MDBParameter("SOTUAN", chamSoc.SoTuan));
            Command.Parameters.Add(new MDB.MDBParameter("DANGCHOCONBU", chamSoc.DangChoConBu ? 1:0));
            Command.Parameters.Add(new MDB.MDBParameter("PARA", chamSoc.Para));
            Command.Parameters.Add(new MDB.MDBParameter("MAT", chamSoc.Mat));
            Command.Parameters.Add(new MDB.MDBParameter("BENHLYMAT", chamSoc.BenhLyMat));
            Command.Parameters.Add(new MDB.MDBParameter("TAI", chamSoc.Tai));
            Command.Parameters.Add(new MDB.MDBParameter("BENHLYTAI", chamSoc.BenhLyTai));
            Command.Parameters.Add(new MDB.MDBParameter("MUI", chamSoc.Mui));
            Command.Parameters.Add(new MDB.MDBParameter("BENHLYMUI", chamSoc.BenhLyMui));
            Command.Parameters.Add(new MDB.MDBParameter("HONG", chamSoc.Hong));
            Command.Parameters.Add(new MDB.MDBParameter("BENHLYHONG", chamSoc.BenhLyHong));
            Command.Parameters.Add(new MDB.MDBParameter("RANGGIA", chamSoc.RangGia));
            Command.Parameters.Add(new MDB.MDBParameter("BENHLYRANGGIA", chamSoc.BenhLyRangGia));
            Command.Parameters.Add(new MDB.MDBParameter("DAUVITRI", chamSoc.DauViTri));
            Command.Parameters.Add(new MDB.MDBParameter("COMUCDODAU", chamSoc.CoMucDoDau ? 1: 0));
            Command.Parameters.Add(new MDB.MDBParameter("MUCDODAU", chamSoc.MucDoDau));
            Command.Parameters.Add(new MDB.MDBParameter("NGUYCOLOET", chamSoc.NguyCoLoet));
            Command.Parameters.Add(new MDB.MDBParameter("CONGUYCOBRANDEN", chamSoc.CoNguyCoBranden ? 1 :0));
            Command.Parameters.Add(new MDB.MDBParameter("NGUYCOBRANDEN", chamSoc.NguyCoBranden));
            Command.Parameters.Add(new MDB.MDBParameter("NGUYCOTENGA", chamSoc.NguyCoTeNga));
            Command.Parameters.Add(new MDB.MDBParameter("CONGUYCOMORSE", chamSoc.CoNguyCoMorse ? 1:0));
            Command.Parameters.Add(new MDB.MDBParameter("NGUYCOMORSE", chamSoc.NguyCoMorse));
            Command.Parameters.Add(new MDB.MDBParameter("KEHOACHXUATVIEN", chamSoc.KeHoachXuatVien));
            Command.Parameters.Add(new MDB.MDBParameter("CHANDOANCUABACSY", chamSoc.ChanDoanCuaBacSy));
            Command.Parameters.Add(new MDB.MDBParameter("CHEDOCHAMSOC", chamSoc.CheDoChamSoc));
            Command.Parameters.Add(new MDB.MDBParameter("THEODOIMACH", chamSoc.TheoDoiMach));
            Command.Parameters.Add(new MDB.MDBParameter("THEODOINHIETDO", chamSoc.TheoDoiNhietDo));
            Command.Parameters.Add(new MDB.MDBParameter("THEODOINHIPTHO", chamSoc.TheoDoiNhipTho));
            Command.Parameters.Add(new MDB.MDBParameter("THEODOIYTHUC", chamSoc.TheoDoiYThuc));
            Command.Parameters.Add(new MDB.MDBParameter("TAICHO", chamSoc.TaiCho));
            Command.Parameters.Add(new MDB.MDBParameter("YLENHDIEUTRI_THUOC", chamSoc.YLenhDieuTri_Thuoc));
            Command.Parameters.Add(new MDB.MDBParameter("YLENHDIEUTRI_XETNGHIEM", chamSoc.YLenhDieuTri_XetNghiem));
            Command.Parameters.Add(new MDB.MDBParameter("YLENHDIEUTRI_KHAC", chamSoc.YLenhDieuTri_Khac));
            Command.Parameters.Add(new MDB.MDBParameter("DUKIENCHAMSOC", chamSoc.DuKienChamSoc));
            Command.Parameters.Add(new MDB.MDBParameter("CHEDOAN", chamSoc.CheDoAn));
            Command.Parameters.Add(new MDB.MDBParameter("CHEDODINHDUONGKHAC", chamSoc.CheDoDinhDuongKhac));
            Command.Parameters.Add(new MDB.MDBParameter("HUONGDANVESINHCANHAN", chamSoc.HuongDanVeSinhCaNhan));
            Command.Parameters.Add(new MDB.MDBParameter("HUONGDANGIAODUCSUCKHOE", chamSoc.HuongDanGiaoDucSucKhoe));
            Command.Parameters.Add(new MDB.MDBParameter("CHAMSOCKHAC", chamSoc.ChamSocKhac));
            Command.Parameters.Add(new MDB.MDBParameter("MADIEUDUONGLAPPHIEU", chamSoc.MaDieuDuongLapPhieu));
            Command.Parameters.Add(new MDB.MDBParameter("DIEUDUONGLAPPHIEU", chamSoc.DieuDuongLapPhieu));
            Command.Parameters.Add(new MDB.MDBParameter("NGUOISUA", chamSoc.NguoiSua));
            Command.Parameters.Add(new MDB.MDBParameter("NGAYSUA", chamSoc.NgaySua));
            if (chamSoc.IDChamSocNguoiBenhCuaDieuDuong.Equals(Decimal.Zero))
            {
                Command.Parameters.Add(new MDB.MDBParameter("IDCHAMSOCNGUOIBENHCUADIEUDUONG", chamSoc.IDChamSocNguoiBenhCuaDieuDuong));
                Command.Parameters.Add(new MDB.MDBParameter("NGUOITAO", chamSoc.NguoiTao));
                Command.Parameters.Add(new MDB.MDBParameter("NGAYTAO", chamSoc.NgayTao));
            }
            Command.BindByName = true;
            int n = Command.ExecuteNonQuery(); // C#
            if (chamSoc.IDChamSocNguoiBenhCuaDieuDuong.Equals(Decimal.Zero))
            {
                decimal nextval = Convert.ToInt64((Command.Parameters["IDCHAMSOCNGUOIBENHCUADIEUDUONG"] as MDB.MDBParameter).Value);
                chamSoc.IDChamSocNguoiBenhCuaDieuDuong = nextval;
            }

            return n > 0 ? true : false;
        }
        public static bool delete(MDB.MDBConnection MyConnection, decimal idChamSocNguoiBenhCuaDieuDuong)
        {
            string sql = @"UPDATE CHAMSOCNGUOIBENHCUADIEUDUONG SET 
                    XOA = 1 
                    WHERE IDCHAMSOCNGUOIBENHCUADIEUDUONG = " + idChamSocNguoiBenhCuaDieuDuong;
            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
            int n = Command.ExecuteNonQuery(); // C#
            return n > 0 ? true : false;
        }
        public static DataSet getDataSet(MDB.MDBConnection MyConnection, decimal idChamSocNguoiBenhCuaDieuDuong)
        {
            string sql = @"SELECT
                C.*,
	            T.NGAYVAOKHOA,
	            H.TENBENHNHAN,
                H.NGAYSINH,
	            H.GIOITINH
            FROM
                CHAMSOCNGUOIBENHCUADIEUDUONG C
                JOIN THONGTINDIEUTRI T ON C.MAQUANLY = T.MAQUANLY
                JOIN HANHCHINHBENHNHAN H ON T.MABENHNHAN = H.MABENHNHAN
            WHERE
                IDCHAMSOCNGUOIBENHCUADIEUDUONG = " + idChamSocNguoiBenhCuaDieuDuong;

            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);

            MDB.MDBDataAdapter adt = new MDB.MDBDataAdapter(Command);
            var ds = new DataSet();

            adt.Fill(ds, "CS");

            /*DataTable thongTinVien = new DataTable("HEADER");

            thongTinVien.Columns.Add("BENHVIEN");
            thongTinVien.Columns.Add("KHOA");
			if (XemBenhAn._HanhChinhBenhNhan == null) XemBenhAn._HanhChinhBenhNhan = new HanhChinhBenhNhan();
            if (XemBenhAn._ThongTinDieuTri == null) XemBenhAn._ThongTinDieuTri = new ThongTinDieuTri();
            thongTinVien.Rows.Add(XemBenhAn._HanhChinhBenhNhan.BenhVien, XemBenhAn._ThongTinDieuTri.Khoa);
            ds.Tables.Add(thongTinVien);*/

            return ds;
        }
  }
}
