using EMR.KyDienTu;
using EMR_MAIN.ViewModel;
using Newtonsoft.Json;
using NLog;
using PMS.Access;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;

namespace EMR_MAIN.DATABASE.Other
{
    public class DanhGiaNBNVVaKHCS : ThongTinKy
    {
        public DanhGiaNBNVVaKHCS()
        {
            TableName = "DanhGiaNBNVVaKHCS";
            TablePrimaryKeyName = "ID";
            IDMauPhieu = (int)DanhMucPhieu.DGNBNVVKHCS;
            TenMauPhieu = DanhMucPhieu.DGNBNVVKHCS.Description();
        }
        [MoTaDuLieu("Mã định danh")]
        public long ID { get; set; }
        [MoTaDuLieu("Mã quản lý: mã duy nhất trong 1 đợt khám chữa bệnh (kcb), không trùng giữa các đợt kcb khác nhau", "", 1)]
        public decimal MaQuanLy { get; set; }
        [MoTaDuLieu("Mã bệnh nhân")]
        public string MaBenhNhan { get; set; }
        public string SoPhieu { set; get; }
        public string HoTenBenhNhan { get; set; }
        [MoTaDuLieu("Tuổi bệnh nhân")]
        public string Tuoi { get; set; }
        [MoTaDuLieu("Giới tính bệnh nhân")]
        public string GioiTinh { get; set; }
        public int BHYT { get; set; }
        public DateTime? NgayVaoVien { get; set; }
        public string ChanDoan { get; set; }
        public string DDCS { get; set; }
        public string MaDDCD { get; set; }
        // phần tiền sử bệnh sử
        public string LyDoVaoVien { get; set; }
        public string BanThan { get; set; }
        public string GiaDinh { get; set; }
        public int DiUng { get; set; }
        public string TenChatDiUng { get; set; }
        public string PhanUngCuaCoThe { get; set; }
        public string PCCS { get; set; }
        public DateTime? Gio { get; set; }
        // PHẦN NHẬN ĐỊNH
        public int TheTrang { get; set; }
        public string P { get; set; }
        public string H { get; set; }
        public string BMI { get; set; }
        public bool[] TriGiac_Array { get; } = new bool[] { false, false };
        public string TriGiac
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < TriGiac_Array.Length; i++)
                    temp += (TriGiac_Array[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        TriGiac_Array[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public int TuanHoan { get; set; }
        public int HA { get; set; }

        public bool[] HoHap_Array { get; } = new bool[] { false, false, false };
        public string HoHap
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < HoHap_Array.Length; i++)
                    temp += (HoHap_Array[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        HoHap_Array[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public bool[] Oxy_Array { get; } = new bool[] { false, false };
        public string Oxy
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < Oxy_Array.Length; i++)
                    temp += (Oxy_Array[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        Oxy_Array[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public string Oxy_Text { get; set; }
        public int SuDungCoHoHapPhu { get; set; }
        public int Sot { get; set; }
        public int Ho { get; set; }
        public int Dom { get; set; }
        public string Dom_MauSac { get; set; }
        public bool[] Da_Array { get; } = new bool[] { false, false, false };
        public string Da
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < Da_Array.Length; i++)
                    temp += (Da_Array[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        Da_Array[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public int Dau { get; set; }
        public string Dau_ViTri { get; set; }
        public string Dau_MucDoDau { get; set; }
        public string Dau_KieuDau { get; set; }
        public int Phu { get; set; }
        public string Phu_ViTri { get; set; }
        public string TinhChatPhu { get; set; }
        public int VetMo { get; set; }
        public bool[] VetThuong_Array { get; } = new bool[] { false, false, false, false };
        public string VetThuong
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < VetThuong_Array.Length; i++)
                    temp += (VetThuong_Array[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        VetThuong_Array[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public string VetThuong_ViTri { get; set; }
        public string Khac { get; set; }
        public int AnKem { get; set; }
        public bool[] DinhDuong_Array { get; } = new bool[] { false, false, false };
        public string DinhDuong
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < DinhDuong_Array.Length; i++)
                    temp += (DinhDuong_Array[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        DinhDuong_Array[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public string DinhDuong_Khac { get; set; }
        public int ChuongBung { get; set; }
        public int BuonNon { get; set; }
        public int Non { get; set; }
        public bool[] DaiTien_Array { get; } = new bool[] { false, false, false };
        public string DaiTien
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < DaiTien_Array.Length; i++)
                    temp += (DaiTien_Array[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        DaiTien_Array[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public bool[] TieuTien_Array { get; } = new bool[] { false, false, false };
        public string TieuTien
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < TieuTien_Array.Length; i++)
                    temp += (TieuTien_Array[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        TieuTien_Array[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public int VanDong { get; set; }

        public bool[] KhaNangNghe_Array { get; } = new bool[] { false, false, false };
        public string KhaNangNghe
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < KhaNangNghe_Array.Length; i++)
                    temp += (KhaNangNghe_Array[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        KhaNangNghe_Array[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public int KhaNangNoi { get; set; }
        public string KhaNangNoi_CuThe { get; set; }
        public int KhaNangNhin { get; set; }
        public string KhaNangNhin_CuThe { get; set; }
        public bool[] GiacNgu_Array { get; } = new bool[] { false, false, false };
        public string GiacNgu
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < GiacNgu_Array.Length; i++)
                    temp += (GiacNgu_Array[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        GiacNgu_Array[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public int RangMieng { get; set; }
        public int Luoi { get; set; }
        public int CheDoAnKieng { get; set; }
        public bool[] SuyTim_Array { get; } = new bool[] { false, false, false, false };
        public string SuyTim
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < SuyTim_Array.Length; i++)
                    temp += (SuyTim_Array[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        SuyTim_Array[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public string DauHieuBatThuongKhac { get; set; }
        // PHẦN THỰC HIỆN
        public int ThongBao { get; set; }
        public int DoDHST { get; set; }
        public int BaoBSKham { get; set; }
        public bool[] ThucHienYLenh_Array { get; } = new bool[] { false, false, false, false };
        public string ThucHienYLenh
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < ThucHienYLenh_Array.Length; i++)
                    temp += (ThucHienYLenh_Array[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        ThucHienYLenh_Array[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public int TheoDoiToanTrang { get; set; }
        public bool[] HoanThienHSBA_Array { get; } = new bool[] { false, false, false, false };
        public string HoanThienHSBA
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < HoanThienHSBA_Array.Length; i++)
                    temp += (HoanThienHSBA_Array[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        HoanThienHSBA_Array[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public int TamTruocCT { get; set; }
        public int DatVanNgoaiViTruocCT { get; set; }
        public int DeoVaDoiChieuVongDinhDanh { get; set; }
        public int ThucHienYLenhThuocTruocCT { get; set; }
        public int BaoBSDuyetHS { get; set; }
        public int ChienBN { get; set; }
        public ObservableCollection<DanhGiaNBNVVaKHCS_ChiTiet> TTCSChiTiet { get; set; }
        // bắt buộc
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
        public DanhGiaNBNVVaKHCS Clone()
        {
            DanhGiaNBNVVaKHCS other = (DanhGiaNBNVVaKHCS)this.MemberwiseClone();
            other.TTCSChiTiet = new ObservableCollection<DanhGiaNBNVVaKHCS_ChiTiet>();
            if (this.TTCSChiTiet != null)
            {
                foreach (DanhGiaNBNVVaKHCS_ChiTiet item in this.TTCSChiTiet)
                {
                    other.TTCSChiTiet.Add(item.Clone());
                }
            } 
            return other;
        }
    }
    public class DanhGiaNBNVVaKHCS_ChiTiet : ThongTinKy
    {
        [MoTaDuLieu("Mã định danh")]
        public long ID { set; get; }
        [MoTaDuLieu("Mã định danh")]
        public decimal IDPhieu { set; get; }
        public DateTime ThoiGian { set; get; }
        [MoTaDuLieu("Người tạo", null, 0, 0)]
        public string NguoiTao { set; get; }
        public string MaNguoiTao { set; get; }
        public DateTime? ThoiGianDHST { set; get; }
        public double? Mach { set; get; }
        public double? T { set; get; }
        [MoTaDuLieu("Huyết áp")]
        public string HA { set; get; }
        [MoTaDuLieu("Nhịp thở")]
        public string NT { set; get; }
        [MoTaDuLieu("Nước tiểu")]
        public string NuocTieu { set; get; }
        public bool Daky { set; get; }
        [MoTaDuLieu("Chọn", null, 0, 0)]
        public bool Chon { get; set; }
        public DanhGiaNBNVVaKHCS_ChiTiet Clone()
        {
            DanhGiaNBNVVaKHCS_ChiTiet other = (DanhGiaNBNVVaKHCS_ChiTiet)this.MemberwiseClone();
            return other;
        }
    }
    public class DanhGiaNBNVVaKHCSFunc
    {
        static Logger log = LogManager.GetLogger("Log");
        public const string TableName = "DanhGiaNBNVVaKHCS";
        public const string TablePrimaryKeyName = "ID";
        public static string DownloadAnhMoTa(long Id, decimal maQuanLy)
        {
            string fullPath = "";
            try
            {
                string FileHinhAnh = @"\PDGNBNVVKHCS\" + maQuanLy;
                if (Id != 0M)
                {
                    using (var client = new HttpClient())
                    {
                        try
                        {
                            string URL = ERMDatabase.WebServiceEMR;
                            client.BaseAddress = new Uri(URL);
                            client.DefaultRequestHeaders.Accept.Clear();
                            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                            client.Timeout = new TimeSpan(0, 0, 1000);
                            string fileName = FileHinhAnh.Trim('\\') + "\\" + Id + ".png";
                            var url = "api/KetXuat/Get1File?PathFile=" + fileName;
                            HttpResponseMessage response = client.GetAsync(url).Result;
                            response.EnsureSuccessStatusCode();
                            if (response.IsSuccessStatusCode)
                            {
                                string result = response.Content.ReadAsStringAsync().Result;
                                if (result != "null" && result != "[]")
                                {
                                    FileCopy lstFile = JsonConvert.DeserializeObject<FileCopy>(result);
                                    if (lstFile != null)
                                    {
                                        string tempPath = System.IO.Path.GetTempPath().Trim('\\');
                                        fullPath = tempPath.Trim('\\') + "\\" + FileHinhAnh.Trim('\\');
                                        if (!System.IO.Directory.Exists(fullPath)) { System.IO.Directory.CreateDirectory(fullPath); }
                                        string fileHinhAnh = fullPath.Trim('\\') + "\\" + lstFile.FileName;
                                        try
                                        {
                                            File.WriteAllBytes(fileHinhAnh, lstFile.ArrayBytes);
                                        }
                                        catch
                                        {
                                            fileHinhAnh = fullPath.Trim('\\') + "\\COPY_" + lstFile.FileName;
                                            File.WriteAllBytes(fileHinhAnh, lstFile.ArrayBytes);
                                        }
                                    }
                                }
                            }
                        }
                        catch (Exception ex)
                        {
                            XuLyLoi.LogError(ex);
                        }
                    }
                }


            }
            catch (Exception ex)
            {
                XuLyLoi.Handle(ex);
            }
            return fullPath;
        }
        public static List<DanhGiaNBNVVaKHCS> Select(MDB.MDBConnection MyConnection, decimal MaQuanLy)
        {
            try
            {
                List<DanhGiaNBNVVaKHCS> listResult = new List<DanhGiaNBNVVaKHCS>();
                string sql = @"SELECT t.*
                FROM DanhGiaNBNVVaKHCS t
                WHERE t.MaQuanLy = :MaQuanLy";
                sql = sql + " ORDER BY t.NgayTao DESC";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", MaQuanLy));
                MDB.MDBDataReader DataReader = Command.ExecuteReader();
                while (DataReader.Read())
                {
                    var obj = new DanhGiaNBNVVaKHCS();
                    obj.ID = DataReader.GetLong("ID");
                    obj.MaQuanLy = Common.ConDB_Decimal(DataReader["MaQuanLy"]);
                    obj.MaBenhNhan = Common.ConDBNull(DataReader["MaBenhNhan"]);
                    obj.HoTenBenhNhan = XemBenhAn._HanhChinhBenhNhan.TenBenhNhan;
                    obj.Tuoi = XemBenhAn._HanhChinhBenhNhan.Tuoi;
                    obj.GioiTinh = XemBenhAn._HanhChinhBenhNhan.GioiTinh.Description();
                    obj.SoPhieu = DataReader["SoPhieu"].ToString();
                    obj.BHYT = DataReader.GetInt("BHYT");
                    obj.NgayVaoVien = DataReader["NgayVaoVien"] != DBNull.Value ? (DateTime?) Convert.ToDateTime(DataReader["NgayVaoVien"]): null;
                    obj.ChanDoan = DataReader["ChanDoan"].ToString();
                    obj.DDCS = DataReader["DDCS"].ToString();
                    obj.MaDDCD = DataReader["MaDDCD"].ToString();
                    obj.LyDoVaoVien = DataReader["LyDoVaoVien"].ToString();
                    obj.BanThan = DataReader["BanThan"].ToString();
                    obj.GiaDinh = DataReader["GiaDinh"].ToString();
                    obj.DiUng = DataReader.GetInt("DiUng");
                    obj.TenChatDiUng = DataReader["TenChatDiUng"].ToString();
                    obj.PhanUngCuaCoThe = DataReader["PhanUngCuaCoThe"].ToString();
                    obj.PCCS = DataReader["PCCS"].ToString();
                    obj.Gio = DataReader["Gio"] != DBNull.Value ? (DateTime?)Convert.ToDateTime(DataReader["Gio"]) : null;
                    obj.TheTrang = DataReader.GetInt("TheTrang");
                    obj.P = DataReader["P"].ToString();
                    obj.H = DataReader["H"].ToString();
                    obj.BMI = DataReader["BMI"].ToString();
                    obj.TriGiac = DataReader["TriGiac"].ToString();
                    obj.TuanHoan = DataReader.GetInt("TuanHoan");
                    obj.HA = DataReader.GetInt("HA");
                    obj.HoHap = DataReader["HoHap"].ToString();
                    obj.Oxy = DataReader["Oxy"].ToString();
                    obj.Oxy_Text = DataReader["Oxy_Text"].ToString();
                    obj.SuDungCoHoHapPhu = DataReader.GetInt("SuDungCoHoHapPhu");
                    obj.Sot = DataReader.GetInt("Sot");
                    obj.Ho = DataReader.GetInt("Ho");
                    obj.Dom = DataReader.GetInt("Dom");
                    obj.Dom_MauSac = DataReader["Dom_MauSac"].ToString();
                    obj.Da = DataReader["Da"].ToString();
                    obj.Dau = DataReader.GetInt("Dau");
                    obj.Dau_ViTri = DataReader["Dau_ViTri"].ToString();
                    obj.Dau_MucDoDau = DataReader["Dau_MucDoDau"].ToString();
                    obj.Dau_KieuDau = DataReader["Dau_KieuDau"].ToString();
                    obj.Phu = DataReader.GetInt("Phu");
                    obj.Phu_ViTri = DataReader["Phu_ViTri"].ToString();
                    obj.TinhChatPhu = DataReader["TinhChatPhu"].ToString();
                    obj.VetMo = DataReader.GetInt("VetMo");
                    obj.VetThuong = DataReader["VetThuong"].ToString();
                    obj.VetThuong_ViTri = DataReader["VetThuong_ViTri"].ToString();
                    obj.Khac = DataReader["Khac"].ToString();
                    obj.AnKem = DataReader.GetInt("AnKem");
                    obj.DinhDuong = DataReader["DinhDuong"].ToString();
                    obj.DinhDuong_Khac = DataReader["DinhDuong_Khac"].ToString();
                    obj.ChuongBung = DataReader.GetInt("ChuongBung");
                    obj.BuonNon = DataReader.GetInt("BuonNon");
                    obj.Non = DataReader.GetInt("Non");
                    obj.DaiTien = DataReader["DaiTien"].ToString();
                    obj.TieuTien = DataReader["TieuTien"].ToString();
                    obj.VanDong = DataReader.GetInt("VanDong");
                    obj.KhaNangNghe = DataReader["KhaNangNghe"].ToString();
                    obj.KhaNangNoi = DataReader.GetInt("KhaNangNoi");
                    obj.KhaNangNoi_CuThe = DataReader["KhaNangNoi_CuThe"].ToString();
                    obj.KhaNangNhin = DataReader.GetInt("KhaNangNhin");
                    obj.KhaNangNhin_CuThe = DataReader["KhaNangNhin_CuThe"].ToString();
                    obj.GiacNgu = DataReader["GiacNgu"].ToString();
                    obj.RangMieng = DataReader.GetInt("RangMieng");
                    obj.Luoi = DataReader.GetInt("Luoi");
                    obj.CheDoAnKieng = DataReader.GetInt("CheDoAnKieng");
                    obj.SuyTim = DataReader["SuyTim"].ToString();
                    obj.DauHieuBatThuongKhac = DataReader["DauHieuBatThuongKhac"].ToString();
                    obj.ThongBao = DataReader.GetInt("ThongBao");
                    obj.DoDHST = DataReader.GetInt("DoDHST");
                    obj.BaoBSKham = DataReader.GetInt("BaoBSKham");
                    obj.ThucHienYLenh = DataReader["ThucHienYLenh"].ToString();
                    obj.TheoDoiToanTrang = DataReader.GetInt("TheoDoiToanTrang");
                    obj.HoanThienHSBA = DataReader["HoanThienHSBA"].ToString();
                    obj.TamTruocCT = DataReader.GetInt("TamTruocCT");
                    obj.DatVanNgoaiViTruocCT = DataReader.GetInt("DatVanNgoaiViTruocCT");
                    obj.DeoVaDoiChieuVongDinhDanh = DataReader.GetInt("DeoVaDoiChieuVongDinhDanh");
                    obj.ThucHienYLenhThuocTruocCT = DataReader.GetInt("ThucHienYLenhThuocTruocCT");
                    obj.BaoBSDuyetHS = DataReader.GetInt("BaoBSDuyetHS");
                    obj.ChienBN = DataReader.GetInt("ChienBN");

                    obj.TTCSChiTiet = new ObservableCollection<DanhGiaNBNVVaKHCS_ChiTiet>();
                    obj.TTCSChiTiet = Select_PhieuCHiTiet(MyConnection, obj.ID);

                    obj.NgayTao = Convert.ToDateTime(DataReader["NgayTao"] == DBNull.Value ? DateTime.Now : DataReader["NgayTao"]);
                    obj.NguoiTao = DataReader["NguoiTao"].ToString();
                    obj.NgaySua = Convert.ToDateTime(DataReader["NgaySua"] == DBNull.Value ? DateTime.Now : DataReader["NgaySua"]);
                    obj.NguoiSua = DataReader["NguoiSua"].ToString();

                    obj.MaSoKy = DataReader["masokyten"].ToString();
                    obj.DaKy = !string.IsNullOrEmpty(obj.MaSoKy) ? true : false;
                    listResult.Add(obj);
                }
                return listResult;
                
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static ObservableCollection<DanhGiaNBNVVaKHCS_ChiTiet> Select_PhieuCHiTiet(MDB.MDBConnection MyConnection, long IDPhieu, int ModOrder = 0)
        {
            try
            {
                ObservableCollection<DanhGiaNBNVVaKHCS_ChiTiet>  listResult = new ObservableCollection<DanhGiaNBNVVaKHCS_ChiTiet>();
                string sql = @"SELECT t.*
                FROM DanhGiaNBNVVaKHCS_ChiTiet t
                WHERE t.IDPhieu = :IDPhieu ";

                if (ModOrder == 1)
                {
                    sql = sql + " ORDER BY t.ThoiGian ASC";
                }
                else
                {
                    sql = sql + " ORDER BY t.ThoiGian DESC";
                }
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
                Command.Parameters.Add(new MDB.MDBParameter("IDPhieu", IDPhieu));
                MDB.MDBDataReader DataReader = Command.ExecuteReader();
                while (DataReader.Read())
                {
                    var obj = new DanhGiaNBNVVaKHCS_ChiTiet();
                    obj.ID = DataReader.GetLong("ID");
                    obj.IDPhieu = DataReader.GetLong("IDPhieu");
                    obj.ThoiGian = DataReader.GetDate("ThoiGian");
                    obj.NguoiTao = DataReader["NguoiTao"].ToString();
                    obj.MaNguoiTao = DataReader["MaNguoiTao"].ToString();
                    obj.ThoiGianDHST = DataReader["ThoiGianDHST"] != DBNull.Value ? (DateTime?)Convert.ToDateTime(DataReader["ThoiGianDHST"]) : null;
                    double doubleTemp = 0;
                    obj.Mach = double.TryParse(DataReader["Mach"].ToString(), out doubleTemp) ? (double?) doubleTemp : null;
                    obj.T = double.TryParse(DataReader["T"].ToString(), out doubleTemp) ? (double?)doubleTemp : null;
                    obj.HA = DataReader["HA"].ToString();
                    obj.NT = DataReader["NT"].ToString();
                    obj.NuocTieu = DataReader["NuocTieu"].ToString();

                    obj.MaSoKy = DataReader["masokyten"].ToString();
                    obj.Daky = !string.IsNullOrEmpty(obj.MaSoKy) ? true : false;
                    listResult.Add(obj);
                }
                return listResult;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static bool Insert(MDB.MDBConnection MyConnection, DanhGiaNBNVVaKHCS obj)
        {
            try
            {
                string sql = @"INSERT INTO DanhGiaNBNVVaKHCS (
                MaQuanLy,
                MaBenhNhan,
                SoPhieu,
                BHYT,
                NgayVaoVien,
                ChanDoan,
                DDCS,
                MaDDCD,
                LyDoVaoVien,
                BanThan,
                GiaDinh,
                DiUng,
                TenChatDiUng,
                PhanUngCuaCoThe,
                PCCS,
                Gio,
                TheTrang,
                P,
                H,
                BMI,
                TriGiac,
                TuanHoan,
                HA,
                HoHap,
                Oxy,
                Oxy_Text,
                SuDungCoHoHapPhu,
                Sot,
                Ho,
                Dom,
                Dom_MauSac,
                Da,
                Dau,
                Dau_ViTri,
                Dau_MucDoDau,
                Dau_KieuDau,
                Phu,
                Phu_ViTri,
                TinhChatPhu,
                VetMo,
                VetThuong,
                VetThuong_ViTri,
                Khac,
                AnKem,
                DinhDuong,
                DinhDuong_Khac,
                ChuongBung,
                BuonNon,
                Non,
                DaiTien,
                TieuTien,
                VanDong,
                KhaNangNghe,
                KhaNangNoi,
                KhaNangNoi_CuThe,
                KhaNangNhin,
                KhaNangNhin_CuThe,
                GiacNgu,
                RangMieng,
                Luoi,
                CheDoAnKieng,
                SuyTim,
                DauHieuBatThuongKhac,
                ThongBao,
                DoDHST,
                BaoBSKham,
                ThucHienYLenh,
                TheoDoiToanTrang,
                HoanThienHSBA,
                TamTruocCT,
                DatVanNgoaiViTruocCT,
                DeoVaDoiChieuVongDinhDanh,
                ThucHienYLenhThuocTruocCT,
                BaoBSDuyetHS,
                ChienBN,
                NguoiTao,
                NgayTao,
                NguoiSua,
                NgaySua
                ) 
                VALUES (
                :MaQuanLy,
                :MaBenhNhan,
                :SoPhieu,
                :BHYT,
                :NgayVaoVien,
                :ChanDoan,
                :DDCS,
                :MaDDCD,
                :LyDoVaoVien,
                :BanThan,
                :GiaDinh,
                :DiUng,
                :TenChatDiUng,
                :PhanUngCuaCoThe,
                :PCCS,
                :Gio,
                :TheTrang,
                :P,
                :H,
                :BMI,
                :TriGiac,
                :TuanHoan,
                :HA,
                :HoHap,
                :Oxy,
                :Oxy_Text,
                :SuDungCoHoHapPhu,
                :Sot,
                :Ho,
                :Dom,
                :Dom_MauSac,
                :Da,
                :Dau,
                :Dau_ViTri,
                :Dau_MucDoDau,
                :Dau_KieuDau,
                :Phu,
                :Phu_ViTri,
                :TinhChatPhu,
                :VetMo,
                :VetThuong,
                :VetThuong_ViTri,
                :Khac,
                :AnKem,
                :DinhDuong,
                :DinhDuong_Khac,
                :ChuongBung,
                :BuonNon,
                :Non,
                :DaiTien,
                :TieuTien,
                :VanDong,
                :KhaNangNghe,
                :KhaNangNoi,
                :KhaNangNoi_CuThe,
                :KhaNangNhin,
                :KhaNangNhin_CuThe,
                :GiacNgu,
                :RangMieng,
                :Luoi,
                :CheDoAnKieng,
                :SuyTim,
                :DauHieuBatThuongKhac,
                :ThongBao,
                :DoDHST,
                :BaoBSKham,
                :ThucHienYLenh,
                :TheoDoiToanTrang,
                :HoanThienHSBA,
                :TamTruocCT,
                :DatVanNgoaiViTruocCT,
                :DeoVaDoiChieuVongDinhDanh,
                :ThucHienYLenhThuocTruocCT,
                :BaoBSDuyetHS,
                :ChienBN,
                :NguoiTao,
                :NgayTao,
                :NguoiSua,
                :NgaySua
                ) RETURNING ID INTO :ID ";
                MDB.MDBCommand oracleCommand = new MDB.MDBCommand(sql, MyConnection);
                oracleCommand.Parameters.Add(new MDB.MDBParameter("MaQuanLy", obj.MaQuanLy));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("MaBenhNhan", obj.MaBenhNhan));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("SoPhieu", obj.SoPhieu));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("BHYT", obj.BHYT));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("NgayVaoVien", obj.NgayVaoVien));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("ChanDoan", obj.ChanDoan));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("DDCS", obj.DDCS));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("MaDDCD", obj.MaDDCD));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("LyDoVaoVien", obj.LyDoVaoVien));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("BanThan", obj.BanThan));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("GiaDinh", obj.GiaDinh));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("DiUng", obj.DiUng));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("TenChatDiUng", obj.TenChatDiUng));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("PhanUngCuaCoThe", obj.PhanUngCuaCoThe));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("PCCS", obj.PCCS));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("Gio", obj.Gio));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("TheTrang", obj.TheTrang));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("P", obj.P));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("H", obj.H));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("BMI", obj.BMI));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("TriGiac", obj.TriGiac));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("TuanHoan", obj.TuanHoan));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("HA", obj.HA));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("HoHap", obj.HoHap));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("Oxy", obj.Oxy));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("Oxy_Text", obj.Oxy_Text));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("SuDungCoHoHapPhu", obj.SuDungCoHoHapPhu));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("Sot", obj.Sot));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("Ho", obj.Ho));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("Dom", obj.Dom));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("Dom_MauSac", obj.Dom_MauSac));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("Da", obj.Da));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("Dau", obj.Dau));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("Dau_ViTri", obj.Dau_ViTri));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("Dau_MucDoDau", obj.Dau_MucDoDau));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("Dau_KieuDau", obj.Dau_KieuDau));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("Phu", obj.Phu));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("Phu_ViTri", obj.Phu_ViTri));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("TinhChatPhu", obj.TinhChatPhu));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("VetMo", obj.VetMo));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("VetThuong", obj.VetThuong));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("VetThuong_ViTri", obj.VetThuong_ViTri));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("Khac", obj.Khac));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("AnKem", obj.AnKem));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("DinhDuong", obj.DinhDuong));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("DinhDuong_Khac", obj.DinhDuong_Khac));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("ChuongBung", obj.ChuongBung));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("BuonNon", obj.BuonNon));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("Non", obj.Non));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("DaiTien", obj.DaiTien));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("TieuTien", obj.TieuTien));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("VanDong", obj.VanDong));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("KhaNangNghe", obj.KhaNangNghe));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("KhaNangNoi", obj.KhaNangNoi));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("KhaNangNoi_CuThe", obj.KhaNangNoi_CuThe));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("KhaNangNhin", obj.KhaNangNhin));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("KhaNangNhin_CuThe", obj.KhaNangNhin_CuThe));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("GiacNgu", obj.GiacNgu));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("RangMieng", obj.RangMieng));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("Luoi", obj.Luoi));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("CheDoAnKieng", obj.CheDoAnKieng));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("SuyTim", obj.SuyTim));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("DauHieuBatThuongKhac", obj.DauHieuBatThuongKhac));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("ThongBao", obj.ThongBao));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("DoDHST", obj.DoDHST));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("BaoBSKham", obj.BaoBSKham));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("ThucHienYLenh", obj.ThucHienYLenh));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("TheoDoiToanTrang", obj.TheoDoiToanTrang));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("HoanThienHSBA", obj.HoanThienHSBA));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("TamTruocCT", obj.TamTruocCT));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("DatVanNgoaiViTruocCT", obj.DatVanNgoaiViTruocCT));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("DeoVaDoiChieuVongDinhDanh", obj.DeoVaDoiChieuVongDinhDanh));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("ThucHienYLenhThuocTruocCT", obj.ThucHienYLenhThuocTruocCT));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("BaoBSDuyetHS", obj.BaoBSDuyetHS));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("ChienBN", obj.ChienBN));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("NGUOISUA", obj.NguoiSua));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("NGAYSUA", obj.NgaySua));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("ID", obj.ID));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("NGUOITAO", obj.NguoiTao));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("NGAYTAO", obj.NgayTao));
                oracleCommand.BindByName = true;
                int n = oracleCommand.ExecuteNonQuery();
                if (n > 0)
                {
                    long IDPhieu = Convert.ToInt64((oracleCommand.Parameters["ID"] as MDB.MDBParameter).Value);
                    obj.ID = IDPhieu;
                }

                return n > 0 ? true : false;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static bool Update(MDB.MDBConnection MyConnection, DanhGiaNBNVVaKHCS obj)
        {
            try
            {
                string sql = @"UPDATE DanhGiaNBNVVaKHCS SET 
                    MaQuanLy=:MaQuanLy,
                    MaBenhNhan=:MaBenhNhan,
                    SoPhieu=:SoPhieu,
                    BHYT=:BHYT,
                    NgayVaoVien=:NgayVaoVien,
                    ChanDoan=:ChanDoan,
                    DDCS=:DDCS,
                    MaDDCD=:MaDDCD,
                    LyDoVaoVien=:LyDoVaoVien,
                    BanThan=:BanThan,
                    GiaDinh=:GiaDinh,
                    DiUng=:DiUng,
                    TenChatDiUng=:TenChatDiUng,
                    PhanUngCuaCoThe=:PhanUngCuaCoThe,
                    PCCS=:PCCS,
                    Gio=:Gio,
                    TheTrang=:TheTrang,
                    P=:P,
                    H=:H,
                    BMI=:BMI,
                    TriGiac=:TriGiac,
                    TuanHoan=:TuanHoan,
                    HA=:HA,
                    HoHap=:HoHap,
                    Oxy=:Oxy,
                    Oxy_Text=:Oxy_Text,
                    SuDungCoHoHapPhu=:SuDungCoHoHapPhu,
                    Sot=:Sot,
                    Ho=:Ho,
                    Dom=:Dom,
                    Dom_MauSac=:Dom_MauSac,
                    Da=:Da,
                    Dau=:Dau,
                    Dau_ViTri=:Dau_ViTri,
                    Dau_MucDoDau=:Dau_MucDoDau,
                    Dau_KieuDau=:Dau_KieuDau,
                    Phu=:Phu,
                    Phu_ViTri=:Phu_ViTri,
                    TinhChatPhu=:TinhChatPhu,
                    VetMo=:VetMo,
                    VetThuong=:VetThuong,
                    VetThuong_ViTri=:VetThuong_ViTri,
                    Khac=:Khac,
                    AnKem=:AnKem,
                    DinhDuong=:DinhDuong,
                    DinhDuong_Khac=:DinhDuong_Khac,
                    ChuongBung=:ChuongBung,
                    BuonNon=:BuonNon,
                    Non=:Non,
                    DaiTien=:DaiTien,
                    TieuTien=:TieuTien,
                    VanDong=:VanDong,
                    KhaNangNghe=:KhaNangNghe,
                    KhaNangNoi=:KhaNangNoi,
                    KhaNangNoi_CuThe=:KhaNangNoi_CuThe,
                    KhaNangNhin=:KhaNangNhin,
                    KhaNangNhin_CuThe=:KhaNangNhin_CuThe,
                    GiacNgu=:GiacNgu,
                    RangMieng=:RangMieng,
                    Luoi=:Luoi,
                    CheDoAnKieng=:CheDoAnKieng,
                    SuyTim=:SuyTim,
                    DauHieuBatThuongKhac=:DauHieuBatThuongKhac,
                    ThongBao=:ThongBao,
                    DoDHST=:DoDHST,
                    BaoBSKham=:BaoBSKham,
                    ThucHienYLenh=:ThucHienYLenh,
                    TheoDoiToanTrang=:TheoDoiToanTrang,
                    HoanThienHSBA=:HoanThienHSBA,
                    TamTruocCT=:TamTruocCT,
                    DatVanNgoaiViTruocCT=:DatVanNgoaiViTruocCT,
                    DeoVaDoiChieuVongDinhDanh=:DeoVaDoiChieuVongDinhDanh,
                    ThucHienYLenhThuocTruocCT=:ThucHienYLenhThuocTruocCT,
                    BaoBSDuyetHS=:BaoBSDuyetHS,
                    ChienBN=:ChienBN,
                    NguoiSua=:NguoiSua,
                    NgaySua=:NgaySua
                    WHERE ID = " + obj.ID;
                MDB.MDBCommand oracleCommand = new MDB.MDBCommand(sql, MyConnection);
                oracleCommand.Parameters.Add(new MDB.MDBParameter("MaQuanLy", obj.MaQuanLy));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("MaBenhNhan", obj.MaBenhNhan));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("SoPhieu", obj.SoPhieu));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("BHYT", obj.BHYT));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("NgayVaoVien", obj.NgayVaoVien));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("ChanDoan", obj.ChanDoan));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("DDCS", obj.DDCS));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("MaDDCD", obj.MaDDCD));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("LyDoVaoVien", obj.LyDoVaoVien));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("BanThan", obj.BanThan));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("GiaDinh", obj.GiaDinh));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("DiUng", obj.DiUng));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("TenChatDiUng", obj.TenChatDiUng));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("PhanUngCuaCoThe", obj.PhanUngCuaCoThe));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("PCCS", obj.PCCS));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("Gio", obj.Gio));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("TheTrang", obj.TheTrang));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("P", obj.P));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("H", obj.H));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("BMI", obj.BMI));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("TriGiac", obj.TriGiac));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("TuanHoan", obj.TuanHoan));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("HA", obj.HA));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("HoHap", obj.HoHap));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("Oxy", obj.Oxy));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("Oxy_Text", obj.Oxy_Text));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("SuDungCoHoHapPhu", obj.SuDungCoHoHapPhu));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("Sot", obj.Sot));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("Ho", obj.Ho));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("Dom", obj.Dom));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("Dom_MauSac", obj.Dom_MauSac));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("Da", obj.Da));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("Dau", obj.Dau));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("Dau_ViTri", obj.Dau_ViTri));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("Dau_MucDoDau", obj.Dau_MucDoDau));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("Dau_KieuDau", obj.Dau_KieuDau));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("Phu", obj.Phu));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("Phu_ViTri", obj.Phu_ViTri));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("TinhChatPhu", obj.TinhChatPhu));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("VetMo", obj.VetMo));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("VetThuong", obj.VetThuong));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("VetThuong_ViTri", obj.VetThuong_ViTri));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("Khac", obj.Khac));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("AnKem", obj.AnKem));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("DinhDuong", obj.DinhDuong));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("DinhDuong_Khac", obj.DinhDuong_Khac));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("ChuongBung", obj.ChuongBung));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("BuonNon", obj.BuonNon));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("Non", obj.Non));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("DaiTien", obj.DaiTien));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("TieuTien", obj.TieuTien));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("VanDong", obj.VanDong));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("KhaNangNghe", obj.KhaNangNghe));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("KhaNangNoi", obj.KhaNangNoi));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("KhaNangNoi_CuThe", obj.KhaNangNoi_CuThe));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("KhaNangNhin", obj.KhaNangNhin));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("KhaNangNhin_CuThe", obj.KhaNangNhin_CuThe));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("GiacNgu", obj.GiacNgu));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("RangMieng", obj.RangMieng));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("Luoi", obj.Luoi));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("CheDoAnKieng", obj.CheDoAnKieng));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("SuyTim", obj.SuyTim));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("DauHieuBatThuongKhac", obj.DauHieuBatThuongKhac));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("ThongBao", obj.ThongBao));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("DoDHST", obj.DoDHST));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("BaoBSKham", obj.BaoBSKham));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("ThucHienYLenh", obj.ThucHienYLenh));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("TheoDoiToanTrang", obj.TheoDoiToanTrang));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("HoanThienHSBA", obj.HoanThienHSBA));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("TamTruocCT", obj.TamTruocCT));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("DatVanNgoaiViTruocCT", obj.DatVanNgoaiViTruocCT));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("DeoVaDoiChieuVongDinhDanh", obj.DeoVaDoiChieuVongDinhDanh));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("ThucHienYLenhThuocTruocCT", obj.ThucHienYLenhThuocTruocCT));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("BaoBSDuyetHS", obj.BaoBSDuyetHS));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("ChienBN", obj.ChienBN));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("NGUOISUA", obj.NguoiSua));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("NGAYSUA", obj.NgaySua));
                int n = oracleCommand.ExecuteNonQuery();

                return n > 0 ? true : false;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static bool Delete(MDB.MDBConnection MyConnection, long ID)
        {
            try
            {
                if (ID != 0)
                {
                    string sql = @"Delete DanhGiaNBNVVaKHCS 
                                WHERE 
                                (ID = :ID) ";
                    MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
                    Command.Parameters.Add(new MDB.MDBParameter(":ID", ID));
                    int n = Command.ExecuteNonQuery();
                    Command.Dispose();
                    sql = @"Delete DanhGiaNBNVVaKHCS_ChiTiet 
                                WHERE 
                                (IDPhieu = :IDPhieu) ";
                    Command = new MDB.MDBCommand(sql, MyConnection);
                    Command.Parameters.Add(new MDB.MDBParameter(":IDPhieu", ID));
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
        public static bool Delete_ChiTiet(MDB.MDBConnection MyConnection, long ID)
        {
            try
            {
                if (ID != 0)
                {
                    string sql = @"Delete DanhGiaNBNVVaKHCS_ChiTiet 
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
        public static bool InsertOrUpdate_ChiTiet(MDB.MDBConnection MyConnection, DanhGiaNBNVVaKHCS_ChiTiet obj)
        {
            try
            {
                string sql = @"insert into DanhGiaNBNVVaKHCS_ChiTiet (
                    IDPhieu,
                    ThoiGian,
                    NguoiTao,
                    MaNguoiTao,
                    ThoiGianDHST,
                    Mach,
                    T,
                    HA,
                    NT,
                    NuocTieu  
                    ) values (
                    :IDPhieu,
                    :ThoiGian,
                    :NguoiTao,
                    :MaNguoiTao,
                    :ThoiGianDHST,
                    :Mach,
                    :T,
                    :HA,
                    :NT,
                    :NuocTieu  
                    ) RETURNING ID INTO :ID";
                if (obj.ID != 0)
                {
                    sql = @"update DanhGiaNBNVVaKHCS_ChiTiet set
                    IDPhieu=:IDPhieu,
                    ThoiGian=:ThoiGian,
                    NguoiTao=:NguoiTao,
                    MaNguoiTao=:MaNguoiTao,
                    ThoiGianDHST=:ThoiGianDHST,
                    Mach=:Mach,
                    T=:T,
                    HA=:HA,
                    NT=:NT,
                    NuocTieu=:NuocTieu 
                    WHERE ID = " + obj.ID + "";
                }
                MDB.MDBCommand oracleCommand = new MDB.MDBCommand(sql, MyConnection);
                oracleCommand.Parameters.Add(new MDB.MDBParameter("IDPhieu", obj.IDPhieu));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("ThoiGian", obj.ThoiGian));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("NguoiTao", obj.NguoiTao));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("MaNguoiTao", obj.MaNguoiTao));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("ThoiGianDHST", obj.ThoiGianDHST));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("Mach", obj.Mach));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("T", obj.T));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("HA", obj.HA));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("NT", obj.NT));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("NuocTieu", obj.NuocTieu));
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
        public static DataSet GetDataSet(MDB.MDBConnection MyConnection, long ID)
        {
            var timer = new Stopwatch();
            StringBuilder sql = new StringBuilder();
            timer.Start();
            try
            {
                sql.AppendLine(@"SELECT P.*, '' SoNhapVien, '' MaBenhAn , '' SoVaoVien, '' TenBenhNhan,
                        '' TUOI, '' SoYTe, '' BENHVIEN,
                        ''  GioiTinh
                    FROM DanhGiaNBNVVaKHCS P
                ");
                sql.AppendLine(" WHERE P.ID = " + ID);
                MDB.MDBCommand Command = new MDB.MDBCommand(sql.ToString(), MyConnection);
                MDB.MDBDataAdapter adt = new MDB.MDBDataAdapter(Command);
                var ds = new DataSet();
                adt.Fill(ds);
                if (ds != null || ds.Tables[0].Rows.Count > 0)
                {
                    ds.Tables[0].Rows[0]["SoNhapVien"] = XemBenhAn._ThongTinDieuTri.SoNhapVien;
                    ds.Tables[0].Rows[0]["MaBenhAn"] = XemBenhAn._ThongTinDieuTri.MaBenhAn;
                    ds.Tables[0].Rows[0]["SoVaoVien"] = XemBenhAn._ThongTinDieuTri.SoNhapVien;
                    ds.Tables[0].Rows[0]["TenBenhNhan"] = XemBenhAn._HanhChinhBenhNhan.TenBenhNhan;
                    ds.Tables[0].Rows[0]["TUOI"] = XemBenhAn._HanhChinhBenhNhan.Tuoi;
                    ds.Tables[0].Rows[0]["SoYTe"] = XemBenhAn._HanhChinhBenhNhan.SoYTe;
                    ds.Tables[0].Rows[0]["BENHVIEN"] = XemBenhAn._HanhChinhBenhNhan.BenhVien;
                    ds.Tables[0].Rows[0]["GioiTinh"] = XemBenhAn._HanhChinhBenhNhan.GioiTinh.Description();
                }

                DataTable dt = Common.ListToDataTable(Select_PhieuCHiTiet(MyConnection, ID), "CT");
                ds.Tables.Add(dt);
                return ds;
            }

            catch (Exception ex)
            {
                MDB.ExceptionExtend.LogError(ex);
                return null;
            }
            finally
            {
                timer.Stop();
            }
        }
    }
}
