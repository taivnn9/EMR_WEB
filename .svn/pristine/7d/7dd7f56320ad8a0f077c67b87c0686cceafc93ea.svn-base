using EMR.KyDienTu;
using PMS.Access;
using System;
using System.Collections.Generic;
using System.Data;
using PMS.Access;

namespace EMR_MAIN.DATABASE.Other
{
    public class BangKiemBanGiaoNguoiBenhTruocPTTT : ThongTinKy
    {
        public BangKiemBanGiaoNguoiBenhTruocPTTT()
        {
            TableName = "BangKiemCBBGTruocPTTT";
            TablePrimaryKeyName = "ID";
            IDMauPhieu = (int)DanhMucPhieu.BKCBBGTPTTT;
            TenMauPhieu = DanhMucPhieu.BKCBBGTPTTT.Description();
        }
        [MoTaDuLieu("Mã định danh")]
		public long ID { get; set; }
        [MoTaDuLieu("Mã quản lý: mã duy nhất trong 1 đợt khám chữa bệnh (kcb), không trùng giữa các đợt kcb khác nhau","",1)]
		public decimal MaQuanLy { get; set; }
        [MoTaDuLieu("Mã bệnh nhân")]
		public string MaBenhNhan { get; set; }
        [MoTaDuLieu("Phẫu thuật - Thủ thuật cấp cứu")]
        public int PhauThuatThuThuat { get; set; }
        [MoTaDuLieu("Thời gian bàn giao")]
        public DateTime? ThoiGianBanGiao { get; set; }
        [MoTaDuLieu("Họ tên người bệnh")]
        public string HoTenNguoiBenh { get; set; }
        [MoTaDuLieu("Chẩn đoán bệnh")]
		public string ChanDoan { get; set; }
        [MoTaDuLieu("Tiền sử dị ứng")]
        public string TienSuDiUng { get; set; }
        [MoTaDuLieu("Cân nặng")]
        public double? CanNang { get; set; }
        [MoTaDuLieu("Mạch")]
        public int? Mach { get; set; }
        [MoTaDuLieu("Nhiệt độ")]
        public double? NhietDo { get; set; }
        [MoTaDuLieu("Huyết áp")]
		public string HuyetAp { get; set; }
        [MoTaDuLieu("Nhịp thở")]
        public double ? NhipTho { get; set; }
        [MoTaDuLieu("Tình hình tiếp xúc")]
        public bool[] TinhTiepXucArray { get; } = new bool[] { false, false, false, false, false, false };
        [MoTaDuLieu("Tình tiếp xúc tốt")]
        public string TinhTiepXuc
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < TinhTiepXucArray.Length; i++)
                    temp += (TinhTiepXucArray[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        TinhTiepXucArray[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public bool[] TamLyArray { get; } = new bool[] { false, false, false, false };
        [MoTaDuLieu("Tâm lý")]
        public string TamLy
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < TamLyArray.Length; i++)
                    temp += (TamLyArray[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        TamLyArray[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public bool[] VeSinhThanTheArray { get; } = new bool[] { false, false, false, false };
        [MoTaDuLieu("Vệ sinh thân thể (tắm, cát móng tay, chân)")]
        public string VeSinhThanThe
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < VeSinhThanTheArray.Length; i++)
                    temp += (VeSinhThanTheArray[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        VeSinhThanTheArray[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public bool[] ThaoDoTrangSucArray { get; } = new bool[] { false, false, false, false };
        [MoTaDuLieu("Tháo đồ trang sức")]
        public string ThaoDoTrangSuc
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < ThaoDoTrangSucArray.Length; i++)
                    temp += (ThaoDoTrangSucArray[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        ThaoDoTrangSucArray[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public bool[] ThayQuanAoArray { get; } = new bool[] { false, false, false, false };
        [MoTaDuLieu("Thay quần áo, vệ sinh da vùng mổ")]
        public string ThayQuanAo
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < ThayQuanAoArray.Length; i++)
                    temp += (ThayQuanAoArray[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        ThayQuanAoArray[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public bool[] ThutThaoArray { get; set; } = new bool[] { false, false, false, false, false, false };
        [MoTaDuLieu("Thụt tháo")]
        public string ThutThao
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < ThutThaoArray.Length; i++)
                    temp += (ThutThaoArray[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        ThutThaoArray[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public bool[] CoRangGiaArray { get; } = new bool[] { false, false, false, false,false, false };
        [MoTaDuLieu("Có răng giả")]
        public string CoRangGia
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < CoRangGiaArray.Length; i++)
                    temp += (CoRangGiaArray[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        CoRangGiaArray[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        [MoTaDuLieu("Người bệnh ngừng ăn từ")]
        public DateTime? NBNgungAn_Date { get; set; }
        public bool[] NBNgungAnArray { get; } = new bool[] { false, false, false, false };
        [MoTaDuLieu("Người bệnh ngừng ăn")]
        public string NBNgungAn
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < NBNgungAnArray.Length; i++)
                    temp += (NBNgungAnArray[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        NBNgungAnArray[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        [MoTaDuLieu("Người bệnh ngừng uống từ")]
        public DateTime? NBNgungUong_Date { get; set; }
        public bool[] NBNgungUongArray { get; } = new bool[] { false, false, false, false };
        [MoTaDuLieu("Người bệnh ngừng uống")]
        public string NBNgungUong
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < NBNgungUongArray.Length; i++)
                    temp += (NBNgungUongArray[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        NBNgungUongArray[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public bool[] TheTenArray { get; } = new bool[] { false, false, false, false, false, false };
        [MoTaDuLieu("Thẻ tên")]
        public string TheTen
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < TheTenArray.Length; i++)
                    temp += (TheTenArray[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        TheTenArray[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public bool[] BenhAnArray { get; } = new bool[] { false, false, false, false };
        [MoTaDuLieu("Bệnh án")]
        public string BenhAn
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < BenhAnArray.Length; i++)
                    temp += (BenhAnArray[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        BenhAnArray[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public bool[] ThuTestArray { get; } = new bool[] { false, false, false, false };
        [MoTaDuLieu("Thử test kháng sinh")]
        public string ThuTest
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < ThuTestArray.Length; i++)
                    temp += (ThuTestArray[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        ThuTestArray[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public bool[] BoXetNghiemArray { get; } = new bool[] { false, false, false, false, false, false, false, false, false, false };
        [MoTaDuLieu("Bộ xét nghiệm cơ bản")]
        public string BoXetNghiem
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < BoXetNghiemArray.Length; i++)
                    temp += (BoXetNghiemArray[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        BoXetNghiemArray[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        [MoTaDuLieu("HIV")]
		public string HIV { get; set; }
        [MoTaDuLieu(" sAg")]
        public string SAG { get; set; }
        [MoTaDuLieu("HVG")]
        public string HVG { get; set; }
        public bool[] XetNghiemArray { get; } = new bool[] { false, false, false, false };
        [MoTaDuLieu("Xét nghiệm")]
        public string XetNghiem
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < XetNghiemArray.Length; i++)
                    temp += (XetNghiemArray[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        XetNghiemArray[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public bool[] SoLuongPhimArray { get; } = new bool[] { false, false, false, false };
        [MoTaDuLieu("Số lượng phim")]
        public string SoLuongPhim
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < SoLuongPhimArray.Length; i++)
                    temp += (SoLuongPhimArray[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        SoLuongPhimArray[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public bool[] SoLuongTamThuArray { get; } = new bool[] { false, false, false, false };
        [MoTaDuLieu("Số lượng tạm thu")]
        public string SoLuongTamThu
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < SoLuongTamThuArray.Length; i++)
                    temp += (SoLuongTamThuArray[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        SoLuongTamThuArray[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public bool[] ThuocKhangSinhArray { get; } = new bool[] { false, false, false, false };
        [MoTaDuLieu("Thuốc kháng sinh")]
        public string ThuocKhangSinh
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < ThuocKhangSinhArray.Length; i++)
                    temp += (ThuocKhangSinhArray[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        ThuocKhangSinhArray[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public bool[] DanhDauViTriArray { get; } = new bool[] { false, false, false, false };
        [MoTaDuLieu("Đánh dấu vị trí mổ")]
        public string DanhDauViTri
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < DanhDauViTriArray.Length; i++)
                    temp += (DanhDauViTriArray[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        DanhDauViTriArray[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        [MoTaDuLieu("Khác")]
        public string Khac_Text { get; set; }
        public bool[] KhacArray { get; } = new bool[] { false, false, false, false };
        public string Khac
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < KhacArray.Length; i++)
                    temp += (KhacArray[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        KhacArray[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        [MoTaDuLieu("Họ tên người chuẩn bị")]
        public string NguoiChuanBi { get; set; }
        [MoTaDuLieu("Mã người chuẩn bị")]
        public string MaNguoiChuanBi { get; set; }
        [MoTaDuLieu("Họ tên người bàn giao")]
        public string NguoiBanGiao { get; set; }
        [MoTaDuLieu("Mã người nhận bàn giao")]
        public string MaNguoiBanGiao { get; set; }
        [MoTaDuLieu("Họ tên người nhận bàn giao")]
        public string NguoiNhanBanGiao { get; set; }
        [MoTaDuLieu("Mã người nhận bàn giao")]
        public string MaNguoiNhanBanGiao { get; set; }
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
    public class BangKiemBanGiaoNguoiBenhTruocPTTTFunc
    {
        public const string TableName = "BangKiemCBBGTruocPTTT";
        public const string TablePrimaryKeyName = "ID";
        public static List<BangKiemBanGiaoNguoiBenhTruocPTTT> GetListData(MDB.MDBConnection _OracleConnection, decimal maquanly)
        {
            List<BangKiemBanGiaoNguoiBenhTruocPTTT> list = new List<BangKiemBanGiaoNguoiBenhTruocPTTT>();
            try
            {
                string sql = @"SELECT * FROM BangKiemCBBGTruocPTTT where MaQuanLy = :MaQuanLy";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, _OracleConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", maquanly));
                MDB.MDBDataReader DataReader = Command.ExecuteReader();
                while (DataReader.Read())
                {
                    BangKiemBanGiaoNguoiBenhTruocPTTT data = new BangKiemBanGiaoNguoiBenhTruocPTTT();
                    data.ID = Convert.ToInt64(DataReader.GetLong("ID").ToString());
                    data.MaQuanLy = maquanly;
                    data.MaBenhNhan = DataReader["MaBenhNhan"].ToString();
                    data.PhauThuatThuThuat = DataReader.GetInt("PhauThuatThuThuat");
                    data.ThoiGianBanGiao = DataReader.GetDate("ThoiGianBanGiao");
                    data.HoTenNguoiBenh = DataReader["HoTenNguoiBenh"].ToString();
                    data.ChanDoan = DataReader["ChanDoan"].ToString();
                    data.TienSuDiUng = DataReader["TienSuDiUng"].ToString();
                    double doubleTemp = 0;
                    data.CanNang = double.TryParse(DataReader["CanNang"].ToString(), out doubleTemp) ? (double?) doubleTemp : null;
                    int intTemp = 0;
                    data.Mach = int.TryParse(DataReader["Mach"].ToString(), out intTemp) ? (int?) intTemp : null;
                    data.NhietDo = double.TryParse(DataReader["NhietDo"].ToString(), out doubleTemp) ? (double?)doubleTemp : null;
                    data.HuyetAp = DataReader["HuyetAp"].ToString();
                    data.NhipTho = double.TryParse(DataReader["NhipTho"].ToString(), out doubleTemp) ? (double?)doubleTemp : null;
                    data.TinhTiepXuc = DataReader["TinhTiepXuc"].ToString();
                    data.TamLy = DataReader["TamLy"].ToString();
                    data.VeSinhThanThe = DataReader["VeSinhThanThe"].ToString();
                    data.ThaoDoTrangSuc = DataReader["ThaoDoTrangSuc"].ToString();
                    data.ThayQuanAo = DataReader["ThayQuanAo"].ToString();
                    data.ThutThao = DataReader["ThutThao"].ToString();
                    data.CoRangGia = DataReader["CoRangGia"].ToString();
                    data.NBNgungAn_Date = DataReader.GetDate("NBNgungAn_Date");
                    data.NBNgungAn = DataReader["NBNgungAn"].ToString();
                    data.NBNgungUong_Date = DataReader.GetDate("NBNgungUong_Date");
                    data.NBNgungUong = DataReader["NBNgungUong"].ToString();
                    data.TheTen = DataReader["TheTen"].ToString();
                    data.BenhAn = DataReader["BenhAn"].ToString();
                    data.ThuTest = DataReader["ThuTest"].ToString();
                    data.BoXetNghiem = DataReader["BoXetNghiem"].ToString();
                    data.HIV = DataReader["HIV"].ToString();
                    data.SAG = DataReader["SAG"].ToString();
                    data.HVG = DataReader["HVG"].ToString();
                    data.XetNghiem = DataReader["XetNghiem"].ToString();
                    data.SoLuongPhim = DataReader["SoLuongPhim"].ToString();
                    data.SoLuongTamThu = DataReader["SoLuongTamThu"].ToString();
                    data.ThuocKhangSinh = DataReader["ThuocKhangSinh"].ToString();
                    data.DanhDauViTri = DataReader["DanhDauViTri"].ToString();
                    data.Khac_Text = DataReader["Khac_Text"].ToString();
                    data.Khac = DataReader["Khac"].ToString();
                    data.NguoiChuanBi = DataReader["NguoiChuanBi"].ToString();
                    data.MaNguoiChuanBi = DataReader["MaNguoiChuanBi"].ToString();
                    data.NguoiBanGiao = DataReader["NguoiBanGiao"].ToString();
                    data.MaNguoiBanGiao = DataReader["MaNguoiBanGiao"].ToString();
                    data.NguoiNhanBanGiao = DataReader["NguoiNhanBanGiao"].ToString();
                    data.MaNguoiNhanBanGiao = DataReader["MaNguoiNhanBanGiao"].ToString();
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
        public static bool InsertOrUpdate(MDB.MDBConnection MyConnection, ref BangKiemBanGiaoNguoiBenhTruocPTTT bangKiem)
        {
            try
            {
                string sql = @"INSERT INTO BangKiemCBBGTruocPTTT
                (
                    MAQUANLY,
                    MaBenhNhan,
                    PhauThuatThuThuat,
                    ThoiGianBanGiao,
                    HoTenNguoiBenh,
                    ChanDoan,
                    TienSuDiUng,
                    CanNang,
                    Mach,
                    NhietDo,
                    HuyetAp,
                    NhipTho,
                    TinhTiepXuc,
                    TamLy,
                    VeSinhThanThe,
                    ThaoDoTrangSuc,
                    ThayQuanAo,
                    ThutThao,
                    CoRangGia,
                    NBNgungAn_Date,
                    NBNgungAn,
                    NBNgungUong_Date,
                    NBNgungUong,
                    TheTen,
                    BenhAn,
                    ThuTest,
                    BoXetNghiem,
                    HIV,
                    SAG,
                    HVG,
                    XetNghiem,
                    SoLuongPhim,
                    SoLuongTamThu,
                    ThuocKhangSinh,
                    DanhDauViTri,
                    Khac_Text,
                    Khac,
                    NguoiChuanBi,
                    MaNguoiChuanBi,
                    NguoiBanGiao,
                    MaNguoiBanGiao,
                    NguoiNhanBanGiao,
                    MaNguoiNhanBanGiao,
                    NGUOITAO,
                    NGUOISUA,
                    NGAYTAO,
                    NGAYSUA)  VALUES
                 (
				    :MAQUANLY,
                    :MaBenhNhan,
                    :PhauThuatThuThuat,
                    :ThoiGianBanGiao,
                    :HoTenNguoiBenh,
                    :ChanDoan,
                    :TienSuDiUng,
                    :CanNang,
                    :Mach,
                    :NhietDo,
                    :HuyetAp,
                    :NhipTho,
                    :TinhTiepXuc,
                    :TamLy,
                    :VeSinhThanThe,
                    :ThaoDoTrangSuc,
                    :ThayQuanAo,
                    :ThutThao,
                    :CoRangGia,
                    :NBNgungAn_Date,
                    :NBNgungAn,
                    :NBNgungUong_Date,
                    :NBNgungUong,
                    :TheTen,
                    :BenhAn,
                    :ThuTest,
                    :BoXetNghiem,
                    :HIV,
                    :SAG,
                    :HVG,
                    :XetNghiem,
                    :SoLuongPhim,
                    :SoLuongTamThu,
                    :ThuocKhangSinh,
                    :DanhDauViTri,
                    :Khac_Text,
                    :Khac,
                    :NguoiChuanBi,
                    :MaNguoiChuanBi,
                    :NguoiBanGiao,
                    :MaNguoiBanGiao,
                    :NguoiNhanBanGiao,
                    :MaNguoiNhanBanGiao,
                    :NGUOITAO,
                    :NGUOISUA,
                    :NGAYTAO,
                    :NGAYSUA
                 )  RETURNING ID INTO :ID";
                if (bangKiem.ID != 0)
                {
                    sql = @"UPDATE BangKiemCBBGTruocPTTT SET 
                    MAQUANLY = :MAQUANLY,
                    MaBenhNhan = :MaBenhNhan,
                    PhauThuatThuThuat = :PhauThuatThuThuat,
                    ThoiGianBanGiao = :ThoiGianBanGiao,
                    HoTenNguoiBenh = :HoTenNguoiBenh,
                    ChanDoan = :ChanDoan,
                    TienSuDiUng = :TienSuDiUng,
                    CanNang = :CanNang,
                    Mach = :Mach,
                    NhietDo = :NhietDo,
                    HuyetAp = :HuyetAp,
                    NhipTho = :NhipTho,
                    TinhTiepXuc = :TinhTiepXuc,
                    TamLy = :TamLy,
                    VeSinhThanThe = :VeSinhThanThe,
                    ThaoDoTrangSuc = :ThaoDoTrangSuc,
                    ThayQuanAo = :ThayQuanAo,
                    ThutThao = :ThutThao,
                    CoRangGia = :CoRangGia,
                    NBNgungAn_Date = :NBNgungAn_Date,
                    NBNgungAn = :NBNgungAn,
                    NBNgungUong_Date = :NBNgungUong_Date,
                    NBNgungUong = :NBNgungUong,
                    TheTen = :TheTen,
                    BenhAn = :BenhAn,
                    ThuTest = :ThuTest,
                    BoXetNghiem = :BoXetNghiem,
                    HIV = :HIV,
                    SAG = :SAG,
                    HVG = :HVG,
                    XetNghiem = :XetNghiem,
                    SoLuongPhim = :SoLuongPhim,
                    SoLuongTamThu = :SoLuongTamThu,
                    ThuocKhangSinh = :ThuocKhangSinh,
                    DanhDauViTri = :DanhDauViTri,
                    Khac_Text = :Khac_Text,
                    Khac = :Khac,
                    NguoiChuanBi = :NguoiChuanBi,
                    MaNguoiChuanBi = :MaNguoiChuanBi,
                    NguoiBanGiao = :NguoiBanGiao,
                    MaNguoiBanGiao = :MaNguoiBanGiao,
                    NguoiNhanBanGiao = :NguoiNhanBanGiao,
                    MaNguoiNhanBanGiao = :MaNguoiNhanBanGiao,
                    NGUOISUA = :NGUOISUA,
                    NGAYSUA = :NGAYSUA 
                    WHERE ID = " + bangKiem.ID;
                }
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MAQUANLY", bangKiem.MaQuanLy));
                Command.Parameters.Add(new MDB.MDBParameter("MaBenhNhan", bangKiem.MaBenhNhan));
                Command.Parameters.Add(new MDB.MDBParameter("PhauThuatThuThuat", bangKiem.PhauThuatThuThuat));
                Command.Parameters.Add(new MDB.MDBParameter("ThoiGianBanGiao", bangKiem.ThoiGianBanGiao));
                Command.Parameters.Add(new MDB.MDBParameter("HoTenNguoiBenh", bangKiem.HoTenNguoiBenh));
                Command.Parameters.Add(new MDB.MDBParameter("ChanDoan", bangKiem.ChanDoan));
                Command.Parameters.Add(new MDB.MDBParameter("TienSuDiUng", bangKiem.TienSuDiUng));
                Command.Parameters.Add(new MDB.MDBParameter("CanNang", bangKiem.CanNang));
                Command.Parameters.Add(new MDB.MDBParameter("Mach", bangKiem.Mach));
                Command.Parameters.Add(new MDB.MDBParameter("NhietDo", bangKiem.NhietDo));
                Command.Parameters.Add(new MDB.MDBParameter("HuyetAp", bangKiem.HuyetAp));
                Command.Parameters.Add(new MDB.MDBParameter("NhipTho", bangKiem.NhipTho));
                Command.Parameters.Add(new MDB.MDBParameter("TinhTiepXuc", bangKiem.TinhTiepXuc));
                Command.Parameters.Add(new MDB.MDBParameter("TamLy", bangKiem.TamLy));
                Command.Parameters.Add(new MDB.MDBParameter("VeSinhThanThe", bangKiem.VeSinhThanThe));
                Command.Parameters.Add(new MDB.MDBParameter("ThaoDoTrangSuc", bangKiem.ThaoDoTrangSuc));
                Command.Parameters.Add(new MDB.MDBParameter("ThayQuanAo", bangKiem.ThayQuanAo));
                Command.Parameters.Add(new MDB.MDBParameter("ThutThao", bangKiem.ThutThao));
                Command.Parameters.Add(new MDB.MDBParameter("CoRangGia", bangKiem.CoRangGia));
                Command.Parameters.Add(new MDB.MDBParameter("NBNgungAn_Date", bangKiem.NBNgungAn_Date));
                Command.Parameters.Add(new MDB.MDBParameter("NBNgungAn", bangKiem.NBNgungAn));
                Command.Parameters.Add(new MDB.MDBParameter("NBNgungUong_Date", bangKiem.NBNgungUong_Date));
                Command.Parameters.Add(new MDB.MDBParameter("NBNgungUong", bangKiem.NBNgungUong));
                Command.Parameters.Add(new MDB.MDBParameter("TheTen", bangKiem.TheTen));
                Command.Parameters.Add(new MDB.MDBParameter("BenhAn", bangKiem.BenhAn));
                Command.Parameters.Add(new MDB.MDBParameter("ThuTest", bangKiem.ThuTest));
                Command.Parameters.Add(new MDB.MDBParameter("BoXetNghiem", bangKiem.BoXetNghiem));
                Command.Parameters.Add(new MDB.MDBParameter("HIV", bangKiem.HIV));
                Command.Parameters.Add(new MDB.MDBParameter("SAG", bangKiem.SAG));
                Command.Parameters.Add(new MDB.MDBParameter("HVG", bangKiem.HVG));
                Command.Parameters.Add(new MDB.MDBParameter("XetNghiem", bangKiem.XetNghiem));
                Command.Parameters.Add(new MDB.MDBParameter("SoLuongPhim", bangKiem.SoLuongPhim));
                Command.Parameters.Add(new MDB.MDBParameter("SoLuongTamThu", bangKiem.SoLuongTamThu));
                Command.Parameters.Add(new MDB.MDBParameter("ThuocKhangSinh", bangKiem.ThuocKhangSinh));
                Command.Parameters.Add(new MDB.MDBParameter("DanhDauViTri", bangKiem.DanhDauViTri));
                Command.Parameters.Add(new MDB.MDBParameter("Khac_Text", bangKiem.Khac_Text));
                Command.Parameters.Add(new MDB.MDBParameter("Khac", bangKiem.Khac));
                Command.Parameters.Add(new MDB.MDBParameter("NguoiChuanBi", bangKiem.NguoiChuanBi));
                Command.Parameters.Add(new MDB.MDBParameter("MaNguoiChuanBi", bangKiem.MaNguoiChuanBi));
                Command.Parameters.Add(new MDB.MDBParameter("NguoiBanGiao", bangKiem.NguoiBanGiao));
                Command.Parameters.Add(new MDB.MDBParameter("MaNguoiBanGiao", bangKiem.MaNguoiBanGiao));
                Command.Parameters.Add(new MDB.MDBParameter("NguoiNhanBanGiao", bangKiem.NguoiNhanBanGiao));
                Command.Parameters.Add(new MDB.MDBParameter("MaNguoiNhanBanGiao", bangKiem.MaNguoiNhanBanGiao));
                Command.Parameters.Add(new MDB.MDBParameter("NGUOISUA", bangKiem.NguoiSua));
                Command.Parameters.Add(new MDB.MDBParameter("NGAYSUA", bangKiem.NgaySua));
                if (bangKiem.ID == 0)
                {
                    Command.Parameters.Add(new MDB.MDBParameter("ID", bangKiem.ID));
                    Command.Parameters.Add(new MDB.MDBParameter("NGUOITAO", bangKiem.NguoiTao));
                    Command.Parameters.Add(new MDB.MDBParameter("NGAYTAO", bangKiem.NgayTao));
                }
                Command.BindByName = true;
                int n = Command.ExecuteNonQuery();
                if (bangKiem.ID == 0)
                {
                    long nextval = Convert.ToInt64((Command.Parameters["ID"] as MDB.MDBParameter).Value);
                    bangKiem.ID = nextval;
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
                string sql = "DELETE FROM BangKiemCBBGTruocPTTT WHERE ID = :ID";
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
                B.*,
                H.SOYTE,
                H.BENHVIEN,
                T.KHOA
            FROM
                BangKiemCBBGTruocPTTT B
                LEFT JOIN HANHCHINHBENHNHAN H ON B.MABENHNHAN = H.MABENHNHAN
                LEFT JOIN THONGTINDIEUTRI T ON B.MAQUANLY = T.MAQUANLY
            WHERE
                ID = " + id;

            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
            MDB.MDBDataAdapter adt = new MDB.MDBDataAdapter(Command);
            var ds = new DataSet();

            adt.Fill(ds, "BK");
            return ds;
        }

    }
}
