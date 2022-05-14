using EMR.KyDienTu;
using MDB;
using System;
using System.Collections.Generic;
using System.Data;
using PMS.Access;
using PMS.Access;

namespace EMR_MAIN.DATABASE.Other
{
    public class DanhGiaBenhNhiNhapVien : ThongTinKy
    {
        public DanhGiaBenhNhiNhapVien()
        {
            TableName = "DanhGiaBenhNhiNhapVien";
            TablePrimaryKeyName = "ID";
            IDMauPhieu = (int)DanhMucPhieu.DGBNNV;
            TenMauPhieu = DanhMucPhieu.DGBNNV.Description();
        }
        [MoTaDuLieu("Mã định danh")]
		public long ID { get; set; }
        [MoTaDuLieu("Mã quản lý: mã duy nhất trong 1 đợt khám chữa bệnh (kcb), không trùng giữa các đợt kcb khác nhau","",1)]
		public decimal MaQuanLy { get; set; }
        [MoTaDuLieu("Mã bệnh nhân")]
		public string MaBenhNhan { get; set; }
        [MoTaDuLieu("Họ và tên bệnh nhân")]
		public string TenBenhNhan { get; set; }
        [MoTaDuLieu("Tuổi bệnh nhân")]
		public string Tuoi { get; set; }
        [MoTaDuLieu("Khoa")]
		public string Khoa { get; set; }
        public string SoBuong { get; set; }
        [MoTaDuLieu("Giường")]
		public string Giuong { get; set; }
        public string QueQuan { get; set; }
        [MoTaDuLieu("Nghề nghiệp")]
		public string NgheNghiep { get; set; }
        public int DoiTuong { get; set; }
        public DateTime ThoiGianNhapVien { get; set; }
        public string MaNVBacSyChoNhapVien { get; set; }
        public string BacSyChoNhapVien { get; set; }
        [MoTaDuLieu("Chẩn đoán y khoa")]
		public string ChanDoanYKhoa { get; set; }
        public string TTKhiCanLienHe { get; set; }
        public bool[] GiayToKhacArray { get; } = new bool[] { false, false, false, false, false };
        public string GiayToKhac
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < GiayToKhacArray.Length; i++)
                    temp += (GiayToKhacArray[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        GiayToKhacArray[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public bool[] DiUngArray { get; } = new bool[] { false, false, false, false };
        public string DiUng
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < DiUngArray.Length; i++)
                    temp += (DiUngArray[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        DiUngArray[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public string TTSKCuaNguoiBenh { get; set; }
        public string TSBSBanThan { get; set; }
        public string TSBSGiaDinh { get; set; }
        public string ChatDiUng_ThucAn { get; set; }
        public string ChatDiUng_Thuoc { get; set; }
        public string ChatDiUng_Nhua { get; set; }
        public string ChatDiUng_Khac { get; set; }
        public string SuPhanUng_ThucAn { get; set; }
        public string SuPhanUng_Thuoc { get; set; }
        public string SuPhanUng_Nhua { get; set; }
        public string SuPhanUng_Khac { get; set; }
        [MoTaDuLieu("Cân nặng")]
		public string CanNang { get; set; }
        [MoTaDuLieu("Chiều cao")]
		public string ChieuCao { get; set; }
        [MoTaDuLieu("Mạch")]
		public string Mach { get; set; }
        [MoTaDuLieu("Nhiệt độ")]
		public string NhietDo { get; set; }
        [MoTaDuLieu("Huyết áp")]
		public string HuyetAp { get; set; }
        [MoTaDuLieu("Nhịp thở")]
		public string NhipTho { get; set; }
        public string SPO2 { get; set; }
        public bool[] TTTKArray { get; } = new bool[] { false, false, false, false };
        public string TTTK
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < TTTKArray.Length; i++)
                    temp += (TTTKArray[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        TTTKArray[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public bool[] HoHapArray { get; } = new bool[] { false, false, false, false, false, false, false, false };
        public string HoHap
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < HoHapArray.Length; i++)
                    temp += (HoHapArray[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        HoHapArray[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public string HoHap_Khac { get; set; }
        public bool[] KhaNangNgheArray { get; } = new bool[] { false, false, false };
        public string KhaNangNghe
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < KhaNangNgheArray.Length; i++)
                    temp += (KhaNangNgheArray[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        KhaNangNgheArray[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public bool[] RangMiengArray { get; } = new bool[] { false, false, false, false, false, false };
        public string RangMieng
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < RangMiengArray.Length; i++)
                    temp += (RangMiengArray[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        RangMiengArray[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public bool[] KhaNangNuotArray { get; } = new bool[] { false, false, false, false };
        public string KhaNangNuot
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < KhaNangNuotArray.Length; i++)
                    temp += (KhaNangNuotArray[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        KhaNangNuotArray[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public bool[] KhaNangNoiArray { get; } = new bool[] { false, false, false, false };
        public string KhaNangNoi
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < KhaNangNoiArray.Length; i++)
                    temp += (KhaNangNoiArray[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        KhaNangNoiArray[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public bool[] TuanHoanNgoaiViArray { get; } = new bool[] { false, false, false, false, false, false, false };
        public string TuanHoanNgoaiVi
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < TuanHoanNgoaiViArray.Length; i++)
                    temp += (TuanHoanNgoaiViArray[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        TuanHoanNgoaiViArray[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public string TuanHoanNgoaiVi_Khac { get; set; }
        public bool[] DaArray { get; } = new bool[] { false, false };
        public string Da
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < DaArray.Length; i++)
                    temp += (DaArray[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        DaArray[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public string Da_ViTriLoet { get; set; }
        public string Da_MucDoLoet { get; set; }
        public string VetThuong_MoTa { get; set; }
        public string VetThuong_ViTri { get; set; }
        public bool[] BaiTietTieuTienArray { get; } = new bool[] { false, false, false };
        public string BaiTietTieuTien
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < BaiTietTieuTienArray.Length; i++)
                    temp += (BaiTietTieuTienArray[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        BaiTietTieuTienArray[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public bool[] BaiTietDaiTienArray { get; } = new bool[] { false, false, false, false, false };
        public string BaiTietDaiTien
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < BaiTietDaiTienArray.Length; i++)
                    temp += (BaiTietDaiTienArray[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        BaiTietDaiTienArray[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public DateTime NgayDatOngThongTieu { get; set; }
        public int DanhGiaDau { get; set; }
        public string DanhGiaDau_Khac { get; set; }
        public string DanhGiaDau_ViTri { get; set; }
        public string DanhGiaDau_MucDo { get; set; }
        public string DanhGiaDau_ThoiGianDau { get; set; }
        public string DanhGiaDau_GhiChu { get; set; }
        public string DanhGiaDau_DauLanMay { get; set; }
        public bool[] HeTieuHoaArray { get; } = new bool[] { false, false, false, false, false, false };
        public string HeTieuHoa
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < HeTieuHoaArray.Length; i++)
                    temp += (HeTieuHoaArray[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        HeTieuHoaArray[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public string HeTieuHoa_Khac { get; set; }
        public bool[] GiacNguArray { get; } = new bool[] { false, false, false, false, false, false };
        public string GiacNgu
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < GiacNguArray.Length; i++)
                    temp += (GiacNguArray[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        GiacNguArray[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public string GiacNgu_ThuocAnThan { get; set; }
        public bool[] TanTatArray { get; } = new bool[] { false, false, false, false, false, false };
        public string TanTat
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < TanTatArray.Length; i++)
                    temp += (TanTatArray[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        TanTatArray[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public string TanTat_Khac { get; set; }
        public bool[] CheDoAnArray { get; } = new bool[] { false, false, false, false, false, false };
        public string CheDoAn
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < CheDoAnArray.Length; i++)
                    temp += (CheDoAnArray[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        CheDoAnArray[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public string CheDoAn_DacBiet { get; set; }
        public string CheDoAn_SoLanTrenNgay { get; set; }
        public string MaNVDieuDuong { get; set; }
        [MoTaDuLieu("Họ tên điều dưỡng")]
		public string DieuDuongThucHien { get; set; }
        public DateTime ThoiGianThucHien { get; set; }

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
    public class DanhGiaBenhNhiNhapVienFunc
    {
        public const string TableName = "DanhGiaBenhNhiNhapVien";
        public const string TablePrimaryKeyName = "ID";
        public static List<DanhGiaBenhNhiNhapVien> GetListData(MDB.MDBConnection _OracleConnection, decimal maquanly)
        {
            List<DanhGiaBenhNhiNhapVien> list = new List<DanhGiaBenhNhiNhapVien>();
            try
            {

                string sql = @"SELECT * FROM DANHGIABENHNHINHAPVIEN where MaQuanLy = :MaQuanLy";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, _OracleConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", maquanly));
                MDB.MDBDataReader DataReader = Command.ExecuteReader();
                while (DataReader.Read())
                {
                    try
                    {
                        DanhGiaBenhNhiNhapVien data = new DanhGiaBenhNhiNhapVien();
                        data.ID = DataReader.GetLong("ID");
                        data.MaQuanLy = Convert.ToDecimal(DataReader["MaQuanLy"].ToString());
                        data.MaBenhNhan = DataReader["MABENHNHAN"] != DBNull.Value ? DataReader["MABENHNHAN"].ToString():"";
                        data.TenBenhNhan = DataReader["TenBenhNhan"] != DBNull.Value ? DataReader["TenBenhNhan"].ToString() : ""; 
                        data.Tuoi = DataReader["Tuoi"] != DBNull.Value ? DataReader["Tuoi"].ToString() : "";
                        data.Khoa = DataReader["Khoa"] != DBNull.Value ? DataReader["Khoa"].ToString() : "";
                        data.SoBuong = DataReader["SoBuong"] != DBNull.Value ? DataReader["SoBuong"].ToString() : "";
                        data.Giuong = DataReader["Giuong"] != DBNull.Value ? DataReader["Giuong"].ToString() : "";
                        data.QueQuan = DataReader["QueQuan"] != DBNull.Value ? DataReader["QueQuan"].ToString() : "";
                        data.NgheNghiep = DataReader.GetString("NgheNghiep");
                        data.DoiTuong = DataReader.GetInt("DoiTuong");
                        data.ThoiGianNhapVien = ConDB_DateTime(DataReader["ThoiGianNhapVien"]);
                        data.MaNVBacSyChoNhapVien = DataReader["MaNVBacSyChoNhapVien"] != DBNull.Value ? DataReader["MaNVBacSyChoNhapVien"].ToString() : "";
                        data.BacSyChoNhapVien = DataReader["BacSyChoNhapVien"] != DBNull.Value ? DataReader["BacSyChoNhapVien"].ToString() : "";
                        data.ChanDoanYKhoa = DataReader["ChanDoanYKhoa"] != DBNull.Value ? DataReader["ChanDoanYKhoa"].ToString() : "";
                        data.TTKhiCanLienHe = DataReader.GetString("TTKhiCanLienHe");
                        data.GiayToKhac = DataReader["GiayToKhac"] != DBNull.Value ? DataReader["GiayToKhac"].ToString() : "";
                        data.DiUng = DataReader["DiUng"] != DBNull.Value ? DataReader["DiUng"].ToString() : "";
                        data.TTSKCuaNguoiBenh = DataReader["TTSKCUANGUOIBENH"] != DBNull.Value ? DataReader["TTSKCUANGUOIBENH"].ToString() : "";
                        data.TSBSBanThan = DataReader["TSBSBanThan"] != DBNull.Value ? DataReader["TSBSBanThan"].ToString() : "";
                        data.TSBSGiaDinh = DataReader["TSBSGiaDinh"] != DBNull.Value ? DataReader["TSBSGiaDinh"].ToString() : "";
                        data.ChatDiUng_ThucAn = DataReader["ChatDiUng_ThucAn"] != DBNull.Value ? DataReader["ChatDiUng_ThucAn"].ToString() : "";
                        data.ChatDiUng_Thuoc = DataReader["ChatDiUng_Thuoc"] != DBNull.Value ? DataReader["ChatDiUng_Thuoc"].ToString() : "";
                        data.ChatDiUng_Nhua = DataReader["ChatDiUng_Nhua"] != DBNull.Value ? DataReader["ChatDiUng_Nhua"].ToString() : "";
                        data.ChatDiUng_Khac = DataReader["ChatDiUng_Khac"] != DBNull.Value ? DataReader["ChatDiUng_Khac"].ToString() : "";
                        data.SuPhanUng_ThucAn = DataReader["SuPhanUng_ThucAn"] != DBNull.Value ? DataReader["SuPhanUng_ThucAn"].ToString() : "";
                        data.SuPhanUng_Thuoc = DataReader["SuPhanUng_Thuoc"] != DBNull.Value ? DataReader["SuPhanUng_Thuoc"].ToString() : "";
                        data.SuPhanUng_Nhua = DataReader["SuPhanUng_Nhua"] != DBNull.Value ? DataReader["SuPhanUng_Nhua"].ToString() : "";
                        data.SuPhanUng_Khac = DataReader["SuPhanUng_Khac"] != DBNull.Value ? DataReader["SuPhanUng_Khac"].ToString() : "";
                        data.CanNang = DataReader["CanNang"] != DBNull.Value ? DataReader["CanNang"].ToString() : "";
                        data.ChieuCao = DataReader["ChieuCao"] != DBNull.Value ? DataReader["ChieuCao"].ToString() : "";
                        data.Mach = DataReader["Mach"] != DBNull.Value ? DataReader["Mach"].ToString() : "";
                        data.NhietDo = DataReader["NhietDo"] != DBNull.Value ? DataReader["NhietDo"].ToString() : "";
                        data.HuyetAp = DataReader["HuyetAp"] != DBNull.Value ? DataReader["HuyetAp"].ToString() : "";
                        data.NhipTho = DataReader["NhipTho"] != DBNull.Value ? DataReader["NhipTho"].ToString() : "";
                        data.SPO2 = DataReader["SPO2"] != DBNull.Value ? DataReader["SPO2"].ToString() : "";
                        data.TTTK = DataReader["TTTK"] != DBNull.Value ? DataReader["TTTK"].ToString() : "";
                        data.HoHap = DataReader["HoHap"] != DBNull.Value ? DataReader["HoHap"].ToString() : "";
                        data.HoHap_Khac = DataReader["HoHap_Khac"] != DBNull.Value ? DataReader["HoHap_Khac"].ToString() : "";
                        data.KhaNangNghe = DataReader["KhaNangNghe"] != DBNull.Value ? DataReader["KhaNangNghe"].ToString() : "";
                        data.RangMieng = DataReader["RangMieng"] != DBNull.Value ? DataReader["RangMieng"].ToString() : "";
                        data.KhaNangNoi = DataReader["KhaNangNoi"] != DBNull.Value ? DataReader["KhaNangNoi"].ToString() : "";
                        data.KhaNangNuot = DataReader["KhaNangNuot"] != DBNull.Value ? DataReader["KhaNangNuot"].ToString() : "";
                        data.TuanHoanNgoaiVi = DataReader["TuanHoanNgoaiVi"] != DBNull.Value ? DataReader["TuanHoanNgoaiVi"].ToString() : "";
                        data.TuanHoanNgoaiVi_Khac = DataReader["TuanHoanNgoaiVi_Khac"] != DBNull.Value ? DataReader["TuanHoanNgoaiVi_Khac"].ToString() : "";
                        data.Da = DataReader["Da"] != DBNull.Value ? DataReader["Da"].ToString() : "";
                        data.Da_ViTriLoet = DataReader["Da_ViTriLoet"] != DBNull.Value ? DataReader["Da_ViTriLoet"].ToString() : "";
                        data.Da_MucDoLoet = DataReader["Da_MucDoLoet"] != DBNull.Value ? DataReader["Da_MucDoLoet"].ToString() : "";
                        data.VetThuong_MoTa = DataReader["VetThuong_MoTa"] != DBNull.Value ? DataReader["VetThuong_MoTa"].ToString() : "";
                        data.VetThuong_ViTri = DataReader["VetThuong_ViTri"] != DBNull.Value ? DataReader["VetThuong_ViTri"].ToString() : "";
                        data.BaiTietTieuTien = DataReader["BaiTietTieuTien"] != DBNull.Value ? DataReader["BaiTietTieuTien"].ToString() : "";
                        data.BaiTietDaiTien = DataReader["BaiTietDaiTien"] != DBNull.Value ? DataReader["BaiTietDaiTien"].ToString() : "";
                        data.NgayDatOngThongTieu = ConDB_DateTime(DataReader["NgayDatOngThongTieu"]);
                        data.DanhGiaDau = DataReader.GetInt("DanhGiaDau");
                        data.DanhGiaDau_Khac = DataReader["DanhGiaDau_Khac"] != DBNull.Value ? DataReader["DanhGiaDau_Khac"].ToString() : "";
                        data.DanhGiaDau_ViTri = DataReader["DanhGiaDau_ViTri"] != DBNull.Value ? DataReader["DanhGiaDau_ViTri"].ToString() : "";
                        data.DanhGiaDau_MucDo = DataReader["DanhGiaDau_MucDo"] != DBNull.Value ? DataReader["DanhGiaDau_MucDo"].ToString() : "";
                        data.DanhGiaDau_ThoiGianDau = DataReader["DanhGiaDau_ThoiGianDau"] != DBNull.Value ? DataReader["DanhGiaDau_ThoiGianDau"].ToString() : "";
                        data.DanhGiaDau_GhiChu = DataReader["DanhGiaDau_GhiChu"] != DBNull.Value ? DataReader["DanhGiaDau_GhiChu"].ToString() : "";
                        data.DanhGiaDau_DauLanMay = DataReader["DanhGiaDau_DauLanMay"] != DBNull.Value ? DataReader["DanhGiaDau_DauLanMay"].ToString() : "";
                        data.HeTieuHoa = DataReader["HeTieuHoa"] != DBNull.Value ? DataReader["HeTieuHoa"].ToString() : "";
                        data.HeTieuHoa_Khac = DataReader["HeTieuHoa_Khac"] != DBNull.Value ? DataReader["HeTieuHoa_Khac"].ToString() : "";
                        data.GiacNgu = DataReader["GiacNgu"] != DBNull.Value ? DataReader["GiacNgu"].ToString() : "";
                        data.GiacNgu_ThuocAnThan = DataReader["GiacNgu_ThuocAnThan"] != DBNull.Value ? DataReader["GiacNgu_ThuocAnThan"].ToString() : "";
                        data.TanTat = DataReader["TanTat"] != DBNull.Value ? DataReader["TanTat"].ToString() : "";
                        data.TanTat_Khac = DataReader["TanTat_Khac"] != DBNull.Value ? DataReader["TanTat_Khac"].ToString() : "";
                        data.CheDoAn = DataReader["CheDoAn"] != DBNull.Value ? DataReader["CheDoAn"].ToString() : "";
                        data.CheDoAn_DacBiet = DataReader["CheDoAn_DacBiet"] != DBNull.Value ? DataReader["CheDoAn_DacBiet"].ToString() : "";
                        data.CheDoAn_SoLanTrenNgay = DataReader["CheDoAn_SoLanTrenNgay"] != DBNull.Value ? DataReader["CheDoAn_SoLanTrenNgay"].ToString() : "";
                        data.MaNVDieuDuong = DataReader["MaNVDieuDuong"] != DBNull.Value ? DataReader["MaNVDieuDuong"].ToString() : "";
                        data.DieuDuongThucHien = DataReader["DieuDuongThucHien"] != DBNull.Value ? DataReader["DieuDuongThucHien"].ToString() : "";
                        data.ThoiGianThucHien = ConDB_DateTime(DataReader["ThoiGianThucHien"]);

                        data.NgayTao = ConDB_DateTime(DataReader["NgayTao"]);
                        data.NgaySua = ConDB_DateTime(DataReader["NgaySua"]);
                        data.MaSoKy = DataReader.GetString("masokyten");
                        data.NgayKy = DataReader.GetDate("ngayky");
                        data.TenFileKy = DataReader.GetString("tenfileky");
                        data.UserNameKy = DataReader.GetString("usernameky");
                        list.Add(data);
                    }
                    catch (Exception ex)
                    {
                        MDB.ExceptionExtend.LogError(ex);
                    }
                }
                DataReader.Close();
                DataReader = null;
            }
            catch (Exception ex) { XuLyLoi.Handle(ex); }
            return list;
        }
        public static DateTime ConDB_DateTime(object dbVal)
        {
            DateTime ret = DateTime.MinValue;
            if (dbVal == null)
            {
                return ret;
            }
            bool isSuccess = DateTime.TryParse(dbVal.ToString(), out ret);
            return ret;
        }
        public static bool InsertOrUpdate(MDB.MDBConnection MyConnection, ref DanhGiaBenhNhiNhapVien objData)
        {
            string sql;
            int n = 0;
            if (objData.ID == 0)
            {
                sql = @"INSERT INTO DANHGIABENHNHINHAPVIEN (
                        maquanly,
                        mabenhnhan,
                        tenbenhnhan,
                        tuoi,
                        khoa,
                        sobuong,
                        giuong,
                        quequan,
                        nghenghiep,
                        doituong,
                        thoigiannhapvien,
                        manvbacsychonhapvien,
                        bacsychonhapvien,
                        chandoanykhoa,
                        ttkhicanlienhe,
                        giaytokhac,
                        diung,
                        ttskcuanguoibenh,
                        tsbsbanthan,
                        tsbsgiadinh,
                        chatdiung_thucan,
                        chatdiung_thuoc,
                        chatdiung_nhua,
                        chatdiung_khac,
                        suphanung_thucan,
                        suphanung_thuoc,
                        suphanung_nhua,
                        suphanung_khac,
                        cannang,
                        chieucao,
                        mach,
                        nhietdo,
                        huyetap,
                        nhiptho,
                        spo2,
                        tttk,
                        hohap,
                        hohap_khac,
                        khanangnghe,
                        rangmieng,
                        khanangnuot,
                        khanangnoi,
                        tuanhoanngoaivi,
                        tuanhoanngoaivi_khac,
                        da,
                        da_vitriloet,
                        da_mucdoloet,
                        vetthuong_mota,
                        vetthuong_vitri,
                        baitiettieutien,
                        baitietdaitien,
                        ngaydatongthongtieu,
                        danhgiadau,
                        danhgiadau_khac,
                        danhgiadau_vitri,
                        danhgiadau_mucdo,
                        danhgiadau_thoigiandau,
                        danhgiadau_ghichu,
                        danhgiadau_daulanmay,
                        hetieuhoa,
                        hetieuhoa_khac,
                        giacngu,
                        giacngu_thuocanthan,
                        tantat,
                        tantat_khac,
                        chedoan,
                        chedoan_dacbiet,
                        chedoan_solantrenngay,
                        manvdieuduong,
                        dieuduongthuchien,
                        thoigianthuchien,
                        nguoitao,
                        ngaytao
                    ) VALUES (
                        :maquanly,
                        :mabenhnhan,
                        :tenbenhnhan,
                        :tuoi,
                        :khoa,
                        :sobuong,
                        :giuong,
                        :quequan,
                        :nghenghiep,
                        :doituong,
                        :thoigiannhapvien,
                        :manvbacsychonhapvien,
                        :bacsychonhapvien,
                        :chandoanykhoa,
                        :ttkhicanlienhe,
                        :giaytokhac,
                        :diung,
                        :ttskcuanguoibenh,
                        :tsbsbanthan,
                        :tsbsgiadinh,
                        :chatdiung_thucan,
                        :chatdiung_thuoc,
                        :chatdiung_nhua,
                        :chatdiung_khac,
                        :suphanung_thucan,
                        :suphanung_thuoc,
                        :suphanung_nhua,
                        :suphanung_khac,
                        :cannang,
                        :chieucao,
                        :mach,
                        :nhietdo,
                        :huyetap,
                        :nhiptho,
                        :spo2,
                        :tttk,
                        :hohap,
                        :hohap_khac,
                        :khanangnghe,
                        :rangmieng,
                        :khanangnuot,
                        :khanangnoi,
                        :tuanhoanngoaivi,
                        :tuanhoanngoaivi_khac,
                        :da,
                        :da_vitriloet,
                        :da_mucdoloet,
                        :vetthuong_mota,
                        :vetthuong_vitri,
                        :baitiettieutien,
                        :baitietdaitien,
                        :ngaydatongthongtieu,
                        :danhgiadau,
                        :danhgiadau_khac,
                        :danhgiadau_vitri,
                        :danhgiadau_mucdo,
                        :danhgiadau_thoigiandau,
                        :danhgiadau_ghichu,
                        :danhgiadau_daulanmay,
                        :hetieuhoa,
                        :hetieuhoa_khac,
                        :giacngu,
                        :giacngu_thuocanthan,
                        :tantat,
                        :tantat_khac,
                        :chedoan,
                        :chedoan_dacbiet,
                        :chedoan_solantrenngay,
                        :manvdieuduong,
                        :dieuduongthuchien,
                        :thoigianthuchien,
                        :nguoitao,
                        :ngaytao
                    ) RETURNING ID INTO :ID";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
                Command.Parameters.Add(new MDB.MDBParameter("maquanly", objData.MaQuanLy));
                Command.Parameters.Add(new MDB.MDBParameter("mabenhnhan", objData.MaBenhNhan));
                Command.Parameters.Add(new MDB.MDBParameter("tenbenhnhan", objData.TenBenhNhan));
                Command.Parameters.Add(new MDB.MDBParameter("tuoi", objData.Tuoi));
                Command.Parameters.Add(new MDB.MDBParameter("khoa", objData.Khoa));
                Command.Parameters.Add(new MDB.MDBParameter("sobuong", objData.SoBuong));
                Command.Parameters.Add(new MDB.MDBParameter("giuong", objData.Giuong));
                Command.Parameters.Add(new MDB.MDBParameter("quequan", objData.QueQuan));
                Command.Parameters.Add(new MDB.MDBParameter("nghenghiep", objData.NgheNghiep));
                Command.Parameters.Add(new MDB.MDBParameter("doituong", objData.DoiTuong));
                Command.Parameters.Add(new MDB.MDBParameter("thoigiannhapvien", objData.ThoiGianNhapVien));
                Command.Parameters.Add(new MDB.MDBParameter("manvbacsychonhapvien", objData.MaNVBacSyChoNhapVien));
                Command.Parameters.Add(new MDB.MDBParameter("bacsychonhapvien", objData.BacSyChoNhapVien));
                Command.Parameters.Add(new MDB.MDBParameter("chandoanykhoa", objData.ChanDoanYKhoa));
                Command.Parameters.Add(new MDB.MDBParameter("ttkhicanlienhe", objData.TTKhiCanLienHe));
                Command.Parameters.Add(new MDB.MDBParameter("giaytokhac", objData.GiayToKhac));
                Command.Parameters.Add(new MDB.MDBParameter("diung", objData.DiUng));
                Command.Parameters.Add(new MDB.MDBParameter("ttskcuanguoibenh", objData.TTSKCuaNguoiBenh));
                Command.Parameters.Add(new MDB.MDBParameter("tsbsbanthan", objData.TSBSBanThan));
                Command.Parameters.Add(new MDB.MDBParameter("tsbsgiadinh", objData.TSBSGiaDinh));
                Command.Parameters.Add(new MDB.MDBParameter("chatdiung_thucan", objData.ChatDiUng_ThucAn));
                Command.Parameters.Add(new MDB.MDBParameter("chatdiung_thuoc", objData.ChatDiUng_Thuoc));
                Command.Parameters.Add(new MDB.MDBParameter("chatdiung_nhua", objData.ChatDiUng_Nhua));
                Command.Parameters.Add(new MDB.MDBParameter("chatdiung_khac", objData.ChatDiUng_Khac));
                Command.Parameters.Add(new MDB.MDBParameter("suphanung_thucan", objData.SuPhanUng_ThucAn));
                Command.Parameters.Add(new MDB.MDBParameter("suphanung_thuoc", objData.SuPhanUng_Thuoc));
                Command.Parameters.Add(new MDB.MDBParameter("suphanung_nhua", objData.SuPhanUng_Nhua));
                Command.Parameters.Add(new MDB.MDBParameter("suphanung_khac", objData.SuPhanUng_Khac));
                Command.Parameters.Add(new MDB.MDBParameter("cannang", objData.CanNang));
                Command.Parameters.Add(new MDB.MDBParameter("chieucao", objData.ChieuCao));
                Command.Parameters.Add(new MDB.MDBParameter("mach", objData.Mach));
                Command.Parameters.Add(new MDB.MDBParameter("nhietdo", objData.NhietDo));
                Command.Parameters.Add(new MDB.MDBParameter("huyetap", objData.HuyetAp));
                Command.Parameters.Add(new MDB.MDBParameter("nhiptho", objData.NhipTho));
                Command.Parameters.Add(new MDB.MDBParameter("spo2", objData.SPO2));
                Command.Parameters.Add(new MDB.MDBParameter("tttk", objData.TTTK));
                Command.Parameters.Add(new MDB.MDBParameter("hohap", objData.HoHap));
                Command.Parameters.Add(new MDB.MDBParameter("hohap_khac", objData.HoHap_Khac));
                Command.Parameters.Add(new MDB.MDBParameter("khanangnghe", objData.KhaNangNghe));
                Command.Parameters.Add(new MDB.MDBParameter("rangmieng", objData.RangMieng));
                Command.Parameters.Add(new MDB.MDBParameter("khanangnuot", objData.KhaNangNuot));
                Command.Parameters.Add(new MDB.MDBParameter("khanangnoi", objData.KhaNangNoi));
                Command.Parameters.Add(new MDB.MDBParameter("tuanhoanngoaivi", objData.TuanHoanNgoaiVi));
                Command.Parameters.Add(new MDB.MDBParameter("tuanhoanngoaivi_khac", objData.TuanHoanNgoaiVi_Khac));
                Command.Parameters.Add(new MDB.MDBParameter("da", objData.Da));
                Command.Parameters.Add(new MDB.MDBParameter("da_vitriloet", objData.Da_ViTriLoet));
                Command.Parameters.Add(new MDB.MDBParameter("da_mucdoloet", objData.Da_MucDoLoet));
                Command.Parameters.Add(new MDB.MDBParameter("vetthuong_mota", objData.VetThuong_MoTa));
                Command.Parameters.Add(new MDB.MDBParameter("vetthuong_vitri", objData.VetThuong_ViTri));
                Command.Parameters.Add(new MDB.MDBParameter("baitiettieutien", objData.BaiTietTieuTien));
                Command.Parameters.Add(new MDB.MDBParameter("baitietdaitien", objData.BaiTietDaiTien));
                Command.Parameters.Add(new MDB.MDBParameter("ngaydatongthongtieu", objData.NgayDatOngThongTieu));
                Command.Parameters.Add(new MDB.MDBParameter("danhgiadau", objData.DanhGiaDau));
                Command.Parameters.Add(new MDB.MDBParameter("danhgiadau_khac", objData.DanhGiaDau_Khac));
                Command.Parameters.Add(new MDB.MDBParameter("danhgiadau_vitri", objData.DanhGiaDau_ViTri));
                Command.Parameters.Add(new MDB.MDBParameter("danhgiadau_mucdo", objData.DanhGiaDau_MucDo));
                Command.Parameters.Add(new MDB.MDBParameter("danhgiadau_thoigiandau", objData.DanhGiaDau_ThoiGianDau));
                Command.Parameters.Add(new MDB.MDBParameter("danhgiadau_ghichu", objData.DanhGiaDau_GhiChu));
                Command.Parameters.Add(new MDB.MDBParameter("danhgiadau_daulanmay", objData.DanhGiaDau_DauLanMay));
                Command.Parameters.Add(new MDB.MDBParameter("hetieuhoa", objData.HeTieuHoa));
                Command.Parameters.Add(new MDB.MDBParameter("hetieuhoa_khac", objData.HeTieuHoa_Khac));
                Command.Parameters.Add(new MDB.MDBParameter("giacngu", objData.GiacNgu));
                Command.Parameters.Add(new MDB.MDBParameter("giacngu_thuocanthan", objData.GiacNgu_ThuocAnThan));
                Command.Parameters.Add(new MDB.MDBParameter("tantat", objData.TanTat));
                Command.Parameters.Add(new MDB.MDBParameter("tantat_khac", objData.TanTat_Khac));
                Command.Parameters.Add(new MDB.MDBParameter("chedoan", objData.CheDoAn));
                Command.Parameters.Add(new MDB.MDBParameter("chedoan_dacbiet", objData.CheDoAn_DacBiet));
                Command.Parameters.Add(new MDB.MDBParameter("chedoan_solantrenngay", objData.CheDoAn_SoLanTrenNgay));
                Command.Parameters.Add(new MDB.MDBParameter("manvdieuduong", objData.MaNVDieuDuong));
                Command.Parameters.Add(new MDB.MDBParameter("dieuduongthuchien", objData.DieuDuongThucHien));
                Command.Parameters.Add(new MDB.MDBParameter("thoigianthuchien", objData.ThoiGianThucHien));
                Command.Parameters.Add(new MDB.MDBParameter("ID", objData.ID));
                Command.Parameters.Add(new MDB.MDBParameter("nguoitao", objData.NguoiTao));
                Command.Parameters.Add(new MDB.MDBParameter("ngaytao", objData.NgayTao));


                Command.BindByName = true;
                n = Command.ExecuteNonQuery();

                if (n > 0)
                {
                    if (objData.ID == 0)
                    {
                        long nextval = Convert.ToInt64((Command.Parameters["ID"] as MDB.MDBParameter).Value);
                        objData.ID = nextval;
                    }
                }
            }

            else
            {
                sql = @"UPDATE DANHGIABENHNHINHAPVIEN SET 
                                        maquanly=:maquanly,
                                        mabenhnhan=:mabenhnhan,
                                        tenbenhnhan=:tenbenhnhan,
                                        tuoi=:tuoi,
                                        khoa=:khoa,
                                        sobuong=:sobuong,
                                        giuong=:giuong,
                                        quequan=:quequan,
                                        nghenghiep=:nghenghiep,
                                        doituong=:doituong,
                                        thoigiannhapvien=:thoigiannhapvien,
                                        manvbacsychonhapvien=:manvbacsychonhapvien,
                                        bacsychonhapvien=:bacsychonhapvien,
                                        chandoanykhoa=:chandoanykhoa,
                                        ttkhicanlienhe=:ttkhicanlienhe,
                                        giaytokhac=:giaytokhac,
                                        diung=:diung,
                                        ttskcuanguoibenh=:ttskcuanguoibenh,
                                        tsbsbanthan=:tsbsbanthan,
                                        tsbsgiadinh=:tsbsgiadinh,
                                        chatdiung_thucan=:chatdiung_thucan,
                                        chatdiung_thuoc=:chatdiung_thuoc,
                                        chatdiung_nhua=:chatdiung_nhua,
                                        chatdiung_khac=:chatdiung_khac,
                                        suphanung_thucan=:suphanung_thucan,
                                        suphanung_thuoc=:suphanung_thuoc,
                                        suphanung_nhua=:suphanung_nhua,
                                        suphanung_khac=:suphanung_khac,
                                        cannang=:cannang,
                                        chieucao=:chieucao,
                                        mach=:mach,
                                        nhietdo=:nhietdo,
                                        huyetap=:huyetap,
                                        nhiptho=:nhiptho,
                                        spo2=:spo2,
                                        tttk=:tttk,
                                        hohap=:hohap,
                                        hohap_khac=:hohap_khac,
                                        khanangnghe=:khanangnghe,
                                        rangmieng=:rangmieng,
                                        khanangnuot=:khanangnuot,
                                        khanangnoi=:khanangnoi,
                                        tuanhoanngoaivi=:tuanhoanngoaivi,
                                        tuanhoanngoaivi_khac=:tuanhoanngoaivi_khac,
                                        da=:da,
                                        da_vitriloet=:da_vitriloet,
                                        da_mucdoloet=:da_mucdoloet,
                                        vetthuong_mota=:vetthuong_mota,
                                        vetthuong_vitri=:vetthuong_vitri,
                                        baitiettieutien=:baitiettieutien,
                                        baitietdaitien=:baitietdaitien,
                                        ngaydatongthongtieu=:ngaydatongthongtieu,
                                        danhgiadau=:danhgiadau,
                                        danhgiadau_khac=:danhgiadau_khac,
                                        danhgiadau_vitri=:danhgiadau_vitri,
                                        danhgiadau_mucdo=:danhgiadau_mucdo,
                                        danhgiadau_thoigiandau=:danhgiadau_thoigiandau,
                                        danhgiadau_ghichu=:danhgiadau_ghichu,
                                        danhgiadau_daulanmay=:danhgiadau_daulanmay,
                                        hetieuhoa=:hetieuhoa,
                                        hetieuhoa_khac=:hetieuhoa_khac,
                                        giacngu=:giacngu,
                                        giacngu_thuocanthan=:giacngu_thuocanthan,
                                        tantat=:tantat,
                                        tantat_khac=:tantat_khac,
                                        chedoan=:chedoan,
                                        chedoan_dacbiet=:chedoan_dacbiet,
                                        chedoan_solantrenngay=:chedoan_solantrenngay,
                                        manvdieuduong=:manvdieuduong,
                                        dieuduongthuchien=:dieuduongthuchien,
                                        thoigianthuchien=:thoigianthuchien,
                                        nguoisua=:nguoisua,
                                        ngaysua=:ngaysua
                                        WHERE ID = :IDPhieu";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
                Command.Parameters.Add(new MDB.MDBParameter("maquanly", objData.MaQuanLy));
                Command.Parameters.Add(new MDB.MDBParameter("mabenhnhan", objData.MaBenhNhan));
                Command.Parameters.Add(new MDB.MDBParameter("tenbenhnhan", objData.TenBenhNhan));
                Command.Parameters.Add(new MDB.MDBParameter("tuoi", objData.Tuoi));
                Command.Parameters.Add(new MDB.MDBParameter("khoa", objData.Khoa));
                Command.Parameters.Add(new MDB.MDBParameter("sobuong", objData.SoBuong));
                Command.Parameters.Add(new MDB.MDBParameter("giuong", objData.Giuong));
                Command.Parameters.Add(new MDB.MDBParameter("quequan", objData.QueQuan));
                Command.Parameters.Add(new MDB.MDBParameter("nghenghiep", objData.NgheNghiep));
                Command.Parameters.Add(new MDB.MDBParameter("doituong", objData.DoiTuong));
                Command.Parameters.Add(new MDB.MDBParameter("thoigiannhapvien", objData.ThoiGianNhapVien));
                Command.Parameters.Add(new MDB.MDBParameter("manvbacsychonhapvien", objData.MaNVBacSyChoNhapVien));
                Command.Parameters.Add(new MDB.MDBParameter("bacsychonhapvien", objData.BacSyChoNhapVien));
                Command.Parameters.Add(new MDB.MDBParameter("chandoanykhoa", objData.ChanDoanYKhoa));
                Command.Parameters.Add(new MDB.MDBParameter("ttkhicanlienhe", objData.TTKhiCanLienHe));
                Command.Parameters.Add(new MDB.MDBParameter("giaytokhac", objData.GiayToKhac));
                Command.Parameters.Add(new MDB.MDBParameter("diung", objData.DiUng));
                Command.Parameters.Add(new MDB.MDBParameter("ttskcuanguoibenh", objData.TTSKCuaNguoiBenh));
                Command.Parameters.Add(new MDB.MDBParameter("tsbsbanthan", objData.TSBSBanThan));
                Command.Parameters.Add(new MDB.MDBParameter("tsbsgiadinh", objData.TSBSGiaDinh));
                Command.Parameters.Add(new MDB.MDBParameter("chatdiung_thucan", objData.ChatDiUng_ThucAn));
                Command.Parameters.Add(new MDB.MDBParameter("chatdiung_thuoc", objData.ChatDiUng_Thuoc));
                Command.Parameters.Add(new MDB.MDBParameter("chatdiung_nhua", objData.ChatDiUng_Nhua));
                Command.Parameters.Add(new MDB.MDBParameter("chatdiung_khac", objData.ChatDiUng_Khac));
                Command.Parameters.Add(new MDB.MDBParameter("suphanung_thucan", objData.SuPhanUng_ThucAn));
                Command.Parameters.Add(new MDB.MDBParameter("suphanung_thuoc", objData.SuPhanUng_Thuoc));
                Command.Parameters.Add(new MDB.MDBParameter("suphanung_nhua", objData.SuPhanUng_Nhua));
                Command.Parameters.Add(new MDB.MDBParameter("suphanung_khac", objData.SuPhanUng_Khac));
                Command.Parameters.Add(new MDB.MDBParameter("cannang", objData.CanNang));
                Command.Parameters.Add(new MDB.MDBParameter("chieucao", objData.ChieuCao));
                Command.Parameters.Add(new MDB.MDBParameter("mach", objData.Mach));
                Command.Parameters.Add(new MDB.MDBParameter("nhietdo", objData.NhietDo));
                Command.Parameters.Add(new MDB.MDBParameter("huyetap", objData.HuyetAp));
                Command.Parameters.Add(new MDB.MDBParameter("nhiptho", objData.NhipTho));
                Command.Parameters.Add(new MDB.MDBParameter("spo2", objData.SPO2));
                Command.Parameters.Add(new MDB.MDBParameter("tttk", objData.TTTK));
                Command.Parameters.Add(new MDB.MDBParameter("hohap", objData.HoHap));
                Command.Parameters.Add(new MDB.MDBParameter("hohap_khac", objData.HoHap_Khac));
                Command.Parameters.Add(new MDB.MDBParameter("khanangnghe", objData.KhaNangNghe));
                Command.Parameters.Add(new MDB.MDBParameter("rangmieng", objData.RangMieng));
                Command.Parameters.Add(new MDB.MDBParameter("khanangnuot", objData.KhaNangNuot));
                Command.Parameters.Add(new MDB.MDBParameter("khanangnoi", objData.KhaNangNoi));
                Command.Parameters.Add(new MDB.MDBParameter("tuanhoanngoaivi", objData.TuanHoanNgoaiVi));
                Command.Parameters.Add(new MDB.MDBParameter("tuanhoanngoaivi_khac", objData.TuanHoanNgoaiVi_Khac));
                Command.Parameters.Add(new MDB.MDBParameter("da", objData.Da));
                Command.Parameters.Add(new MDB.MDBParameter("da_vitriloet", objData.Da_ViTriLoet));
                Command.Parameters.Add(new MDB.MDBParameter("da_mucdoloet", objData.Da_MucDoLoet));
                Command.Parameters.Add(new MDB.MDBParameter("vetthuong_mota", objData.VetThuong_MoTa));
                Command.Parameters.Add(new MDB.MDBParameter("vetthuong_vitri", objData.VetThuong_ViTri));
                Command.Parameters.Add(new MDB.MDBParameter("baitiettieutien", objData.BaiTietTieuTien));
                Command.Parameters.Add(new MDB.MDBParameter("baitietdaitien", objData.BaiTietDaiTien));
                Command.Parameters.Add(new MDB.MDBParameter("ngaydatongthongtieu", objData.NgayDatOngThongTieu));
                Command.Parameters.Add(new MDB.MDBParameter("danhgiadau", objData.DanhGiaDau));
                Command.Parameters.Add(new MDB.MDBParameter("danhgiadau_khac", objData.DanhGiaDau_Khac));
                Command.Parameters.Add(new MDB.MDBParameter("danhgiadau_vitri", objData.DanhGiaDau_ViTri));
                Command.Parameters.Add(new MDB.MDBParameter("danhgiadau_mucdo", objData.DanhGiaDau_MucDo));
                Command.Parameters.Add(new MDB.MDBParameter("danhgiadau_thoigiandau", objData.DanhGiaDau_ThoiGianDau));
                Command.Parameters.Add(new MDB.MDBParameter("danhgiadau_ghichu", objData.DanhGiaDau_GhiChu));
                Command.Parameters.Add(new MDB.MDBParameter("danhgiadau_daulanmay", objData.DanhGiaDau_DauLanMay));
                Command.Parameters.Add(new MDB.MDBParameter("hetieuhoa", objData.HeTieuHoa));
                Command.Parameters.Add(new MDB.MDBParameter("hetieuhoa_khac", objData.HeTieuHoa_Khac));
                Command.Parameters.Add(new MDB.MDBParameter("giacngu", objData.GiacNgu));
                Command.Parameters.Add(new MDB.MDBParameter("giacngu_thuocanthan", objData.GiacNgu_ThuocAnThan));
                Command.Parameters.Add(new MDB.MDBParameter("tantat", objData.TanTat));
                Command.Parameters.Add(new MDB.MDBParameter("tantat_khac", objData.TanTat_Khac));
                Command.Parameters.Add(new MDB.MDBParameter("chedoan", objData.CheDoAn));
                Command.Parameters.Add(new MDB.MDBParameter("chedoan_dacbiet", objData.CheDoAn_DacBiet));
                Command.Parameters.Add(new MDB.MDBParameter("chedoan_solantrenngay", objData.CheDoAn_SoLanTrenNgay));
                Command.Parameters.Add(new MDB.MDBParameter("manvdieuduong", objData.MaNVDieuDuong));
                Command.Parameters.Add(new MDB.MDBParameter("dieuduongthuchien", objData.DieuDuongThucHien));
                Command.Parameters.Add(new MDB.MDBParameter("thoigianthuchien", objData.ThoiGianThucHien));
                Command.Parameters.Add(new MDB.MDBParameter("nguoisua", objData.NguoiSua));
                Command.Parameters.Add(new MDB.MDBParameter("ngaysua", objData.NgaySua));
                Command.Parameters.Add(new MDB.MDBParameter("IDPhieu", objData.ID));
                Command.BindByName = true;
                n = Command.ExecuteNonQuery();

            }


            return n > 0 ? true : false;
        }

        public static bool Delete(MDB.MDBConnection MyConnection, decimal idPhieu)
        {
            string sql = "DELETE FROM DANHGIABENHNHINHAPVIEN WHERE ID = :idPhieu";
            MDBCommand command = new MDB.MDBCommand(sql, MyConnection);
            command.Parameters.Add(new MDB.MDBParameter("idPhieu", idPhieu));
            command.BindByName = true;
            int n = command.ExecuteNonQuery();
            return n > 0 ? true : false;
        }
        public static DanhGiaBenhNhiNhapVien GetData(MDB.MDBConnection _OracleConnection, decimal id)
        {
            try
            {
                string sql = @"SELECT * FROM DANHGIABENHNHINHAPVIEN where ID = :ID";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, _OracleConnection);
                Command.Parameters.Add(new MDB.MDBParameter("ID", id));
                MDB.MDBDataReader DataReader = Command.ExecuteReader();
                while (DataReader.Read())
                {
                    try
                    {
                        DanhGiaBenhNhiNhapVien data = new DanhGiaBenhNhiNhapVien();
                        data.ID = DataReader.GetLong("ID");
                        data.MaQuanLy = Convert.ToDecimal(DataReader["MaQuanLy"].ToString());
                        data.MaBenhNhan = DataReader["MABENHNHAN"] != DBNull.Value ? DataReader["MABENHNHAN"].ToString() : "";
                        data.TenBenhNhan = DataReader["TenBenhNhan"] != DBNull.Value ? DataReader["TenBenhNhan"].ToString() : "";
                        data.Tuoi = DataReader["Tuoi"] != DBNull.Value ? DataReader["Tuoi"].ToString() : "";
                        data.Khoa = DataReader["Khoa"] != DBNull.Value ? DataReader["Khoa"].ToString() : "";
                        data.SoBuong = DataReader["SoBuong"] != DBNull.Value ? DataReader["SoBuong"].ToString() : "";
                        data.Giuong = DataReader["Giuong"] != DBNull.Value ? DataReader["Giuong"].ToString() : "";
                        data.QueQuan = DataReader["QueQuan"] != DBNull.Value ? DataReader["QueQuan"].ToString() : "";
                        data.NgheNghiep = DataReader.GetString("NgheNghiep");
                        data.DoiTuong = DataReader.GetInt("DoiTuong");
                        data.ThoiGianNhapVien = ConDB_DateTime(DataReader["ThoiGianNhapVien"]);
                        data.MaNVBacSyChoNhapVien = DataReader["MaNVBacSyChoNhapVien"] != DBNull.Value ? DataReader["MaNVBacSyChoNhapVien"].ToString() : "";
                        data.BacSyChoNhapVien = DataReader["BacSyChoNhapVien"] != DBNull.Value ? DataReader["BacSyChoNhapVien"].ToString() : "";
                        data.ChanDoanYKhoa = DataReader["ChanDoanYKhoa"] != DBNull.Value ? DataReader["ChanDoanYKhoa"].ToString() : "";
                        data.TTKhiCanLienHe = DataReader.GetString("TTKhiCanLienHe");
                        data.GiayToKhac = DataReader["GiayToKhac"] != DBNull.Value ? DataReader["GiayToKhac"].ToString() : "";
                        data.DiUng = DataReader["DiUng"] != DBNull.Value ? DataReader["DiUng"].ToString() : "";
                        data.TTSKCuaNguoiBenh = DataReader["TTSKCUANGUOIBENH"] != DBNull.Value ? DataReader["TTSKCUANGUOIBENH"].ToString() : "";
                        data.TSBSBanThan = DataReader["TSBSBanThan"] != DBNull.Value ? DataReader["TSBSBanThan"].ToString() : "";
                        data.TSBSGiaDinh = DataReader["TSBSGiaDinh"] != DBNull.Value ? DataReader["TSBSGiaDinh"].ToString() : "";
                        data.ChatDiUng_ThucAn = DataReader["ChatDiUng_ThucAn"] != DBNull.Value ? DataReader["ChatDiUng_ThucAn"].ToString() : "";
                        data.ChatDiUng_Thuoc = DataReader["ChatDiUng_Thuoc"] != DBNull.Value ? DataReader["ChatDiUng_Thuoc"].ToString() : "";
                        data.ChatDiUng_Nhua = DataReader["ChatDiUng_Nhua"] != DBNull.Value ? DataReader["ChatDiUng_Nhua"].ToString() : "";
                        data.ChatDiUng_Khac = DataReader["ChatDiUng_Khac"] != DBNull.Value ? DataReader["ChatDiUng_Khac"].ToString() : "";
                        data.SuPhanUng_ThucAn = DataReader["SuPhanUng_ThucAn"] != DBNull.Value ? DataReader["SuPhanUng_ThucAn"].ToString() : "";
                        data.SuPhanUng_Thuoc = DataReader["SuPhanUng_Thuoc"] != DBNull.Value ? DataReader["SuPhanUng_Thuoc"].ToString() : "";
                        data.SuPhanUng_Nhua = DataReader["SuPhanUng_Nhua"] != DBNull.Value ? DataReader["SuPhanUng_Nhua"].ToString() : "";
                        data.SuPhanUng_Khac = DataReader["SuPhanUng_Khac"] != DBNull.Value ? DataReader["SuPhanUng_Khac"].ToString() : "";
                        data.CanNang = DataReader["CanNang"] != DBNull.Value ? DataReader["CanNang"].ToString() : "";
                        data.ChieuCao = DataReader["ChieuCao"] != DBNull.Value ? DataReader["ChieuCao"].ToString() : "";
                        data.Mach = DataReader["Mach"] != DBNull.Value ? DataReader["Mach"].ToString() : "";
                        data.NhietDo = DataReader["NhietDo"] != DBNull.Value ? DataReader["NhietDo"].ToString() : "";
                        data.HuyetAp = DataReader["HuyetAp"] != DBNull.Value ? DataReader["HuyetAp"].ToString() : "";
                        data.NhipTho = DataReader["NhipTho"] != DBNull.Value ? DataReader["NhipTho"].ToString() : "";
                        data.SPO2 = DataReader["SPO2"] != DBNull.Value ? DataReader["SPO2"].ToString() : "";
                        data.TTTK = DataReader["TTTK"] != DBNull.Value ? DataReader["TTTK"].ToString() : "";
                        data.HoHap = DataReader["HoHap"] != DBNull.Value ? DataReader["HoHap"].ToString() : "";
                        data.HoHap_Khac = DataReader["HoHap_Khac"] != DBNull.Value ? DataReader["HoHap_Khac"].ToString() : "";
                        data.KhaNangNghe = DataReader["KhaNangNghe"] != DBNull.Value ? DataReader["KhaNangNghe"].ToString() : "";
                        data.RangMieng = DataReader["RangMieng"] != DBNull.Value ? DataReader["RangMieng"].ToString() : "";
                        data.KhaNangNoi = DataReader["KhaNangNoi"] != DBNull.Value ? DataReader["KhaNangNoi"].ToString() : "";
                        data.KhaNangNuot = DataReader["KhaNangNuot"] != DBNull.Value ? DataReader["KhaNangNuot"].ToString() : "";
                        data.TuanHoanNgoaiVi = DataReader["TuanHoanNgoaiVi"] != DBNull.Value ? DataReader["TuanHoanNgoaiVi"].ToString() : "";
                        data.TuanHoanNgoaiVi_Khac = DataReader["TuanHoanNgoaiVi_Khac"] != DBNull.Value ? DataReader["TuanHoanNgoaiVi_Khac"].ToString() : "";
                        data.Da = DataReader["Da"] != DBNull.Value ? DataReader["Da"].ToString() : "";
                        data.Da_ViTriLoet = DataReader["Da_ViTriLoet"] != DBNull.Value ? DataReader["Da_ViTriLoet"].ToString() : "";
                        data.Da_MucDoLoet = DataReader["Da_MucDoLoet"] != DBNull.Value ? DataReader["Da_MucDoLoet"].ToString() : "";
                        data.VetThuong_MoTa = DataReader["VetThuong_MoTa"] != DBNull.Value ? DataReader["VetThuong_MoTa"].ToString() : "";
                        data.VetThuong_ViTri = DataReader["VetThuong_ViTri"] != DBNull.Value ? DataReader["VetThuong_ViTri"].ToString() : "";
                        data.BaiTietTieuTien = DataReader["BaiTietTieuTien"] != DBNull.Value ? DataReader["BaiTietTieuTien"].ToString() : "";
                        data.BaiTietDaiTien = DataReader["BaiTietDaiTien"] != DBNull.Value ? DataReader["BaiTietDaiTien"].ToString() : "";
                        data.NgayDatOngThongTieu = ConDB_DateTime(DataReader["NgayDatOngThongTieu"]);
                        data.DanhGiaDau = DataReader.GetInt("DanhGiaDau");
                        data.DanhGiaDau_Khac = DataReader["DanhGiaDau_Khac"] != DBNull.Value ? DataReader["DanhGiaDau_Khac"].ToString() : "";
                        data.DanhGiaDau_ViTri = DataReader["DanhGiaDau_ViTri"] != DBNull.Value ? DataReader["DanhGiaDau_ViTri"].ToString() : "";
                        data.DanhGiaDau_MucDo = DataReader["DanhGiaDau_MucDo"] != DBNull.Value ? DataReader["DanhGiaDau_MucDo"].ToString() : "";
                        data.DanhGiaDau_ThoiGianDau = DataReader["DanhGiaDau_ThoiGianDau"] != DBNull.Value ? DataReader["DanhGiaDau_ThoiGianDau"].ToString() : "";
                        data.DanhGiaDau_GhiChu = DataReader["DanhGiaDau_GhiChu"] != DBNull.Value ? DataReader["DanhGiaDau_GhiChu"].ToString() : "";
                        data.DanhGiaDau_DauLanMay = DataReader["DanhGiaDau_DauLanMay"] != DBNull.Value ? DataReader["DanhGiaDau_DauLanMay"].ToString() : "";
                        data.HeTieuHoa = DataReader["HeTieuHoa"] != DBNull.Value ? DataReader["HeTieuHoa"].ToString() : "";
                        data.HeTieuHoa_Khac = DataReader["HeTieuHoa_Khac"] != DBNull.Value ? DataReader["HeTieuHoa_Khac"].ToString() : "";
                        data.GiacNgu = DataReader["GiacNgu"] != DBNull.Value ? DataReader["GiacNgu"].ToString() : "";
                        data.GiacNgu_ThuocAnThan = DataReader["GiacNgu_ThuocAnThan"] != DBNull.Value ? DataReader["GiacNgu_ThuocAnThan"].ToString() : "";
                        data.TanTat = DataReader["TanTat"] != DBNull.Value ? DataReader["TanTat"].ToString() : "";
                        data.TanTat_Khac = DataReader["TanTat_Khac"] != DBNull.Value ? DataReader["TanTat_Khac"].ToString() : "";
                        data.CheDoAn = DataReader["CheDoAn"] != DBNull.Value ? DataReader["CheDoAn"].ToString() : "";
                        data.CheDoAn_DacBiet = DataReader["CheDoAn_DacBiet"] != DBNull.Value ? DataReader["CheDoAn_DacBiet"].ToString() : "";
                        data.CheDoAn_SoLanTrenNgay = DataReader["CheDoAn_SoLanTrenNgay"] != DBNull.Value ? DataReader["CheDoAn_SoLanTrenNgay"].ToString() : "";
                        data.MaNVDieuDuong = DataReader["MaNVDieuDuong"] != DBNull.Value ? DataReader["MaNVDieuDuong"].ToString() : "";
                        data.DieuDuongThucHien = DataReader["DieuDuongThucHien"] != DBNull.Value ? DataReader["DieuDuongThucHien"].ToString() : "";
                        data.ThoiGianThucHien = ConDB_DateTime(DataReader["ThoiGianThucHien"]);

                        data.NgayTao = ConDB_DateTime(DataReader["NgayTao"]);
                        data.NgaySua = ConDB_DateTime(DataReader["NgaySua"]);
                        data.MaSoKy = DataReader.GetString("masokyten");
                        data.NgayKy = DataReader.GetDate("ngayky");
                        data.TenFileKy = DataReader.GetString("tenfileky");
                        data.UserNameKy = DataReader.GetString("usernameky");

                        return data;
                    }
                    catch (Exception ex)
                    {
                        MDB.ExceptionExtend.LogError(ex);
                    }
                }
                DataReader.Close();
                DataReader = null;
            }
            catch (Exception ex) { XuLyLoi.Handle(ex); }
            return null;
        }
        public static DataSet GetDataSet(MDB.MDBConnection MyConnection, decimal idPhieu)
        {
            string sql2 = @"SELECT
                D.*,
	            T.MABENHNHAN,
	            T.KHOA,
	            T.GIUONG,
                T.BUONG,
	            T.NGAYVAOVIEN,
	            H.SOYTE,
	            H.BENHVIEN,
	            H.MABENHNHAN,
	            H.TENBENHNHAN,
	            H.TUOI,
	            H.GIOITINH
            FROM
                DANHGIABENHNHINHAPVIEN D
                LEFT JOIN THONGTINDIEUTRI T ON D.MAQUANLY = T.MAQUANLY
                LEFT JOIN HANHCHINHBENHNHAN H ON T.MABENHNHAN = H.MABENHNHAN
            WHERE
                ID = :ID";
            MDB.MDBCommand Command = new MDB.MDBCommand(sql2, MyConnection);
            Command.Parameters.Add(new MDB.MDBParameter("ID", idPhieu));

            MDB.MDBDataAdapter adt = new MDB.MDBDataAdapter(Command);
            var ds = new DataSet();
            adt.Fill(ds,"BK");
            return ds;
        }
    }
}
