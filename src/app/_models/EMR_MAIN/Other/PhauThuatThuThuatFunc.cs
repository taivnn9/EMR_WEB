
using EMR.KyDienTu;
using EMR_MAIN.DATABASE;
using EMR_MAIN.ViewModel;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;

namespace EMR_MAIN
{
    public enum ChucNangEKipMo
    {
        [Description("Phẫu thuật viên 1")]
        PTV1 = 1,
        [Description("Phẫu thuật viên 2")]
        PTV2 = 8,
        [Description("Phụ mỗ 1")]
        PhuMo1 = 2,
        [Description("Phụ mỗ 2")]
        PhuMo2 = 3,
        [Description("Bác sĩ gây mê")]
        GayMe = 4,
        [Description("Bác sĩ gây mê 2")]
        GayMe2 = 5,
        [Description("Bác sĩ hồi sức")]
        HoiSuc = 6,
        [Description("Dụng cụ")]
        DungCu = 7,
        [Description("Điều dưỡng ngoài")]
        DieuDuongNgoai = 9,
        [Description("Phụ mỗ 3")]
        PhuMo3 = 10,
        [Description("Phụ mỗ 4")]
        PhuMo4 = 11,
        [Description("Phụ mỗ 5")]
        PhuMo5 = 12,
        [Description("Phụ mê 1")]
        PhuMe1 = 13,
        [Description("Phụ mê 2")]
        PhuMe2 = 14,
        [Description("Bác sỹ")]
        BacSy = 15,
        [Description("Điều dưỡng")]
        DieuDuong = 16,

    }
    public enum PhanLoaiPTTT
    {
        PhauThuat = 0,
        ThuThuat = 1,
    }

    [JsonObject]
    [Serializable]
    public class PhauThuatThuThuat_HIS : ThongTinKy
    {
        [MoTaDuLieu("Mã định danh")]
        public long IDPhauThuatThuThuat { get; set; }
        public DateTime NgayPhauThuatThuThuat { get; set; }
        public DateTime? NgayPhauThuatThuThuat_Gio { get; set; }
        public DateTime NgayPhauThuatThuThuat_Display
        {
            get
            {
                if (NgayPhauThuatThuThuat_Gio.HasValue)
                {
                    return NgayPhauThuatThuThuat + NgayPhauThuatThuThuat_Gio.Value.TimeOfDay;
                }
                else return NgayPhauThuatThuThuat;
            }
        }
        public string ThoiGianXyLy { get; set; }
        public string PhuongPhapPhauThuatThuThuat { get; set; }
        public string PhuongPhapVoCam { get; set; }
        [JsonProperty("MaBacSiPhauThuThuat")]
        public string BacSyPhauThuat { get; set; }
        [JsonProperty("MaBacSiGayMe")]
        public string BacSyGayMe { get; set; }
        [JsonProperty("HoTenBacSiPhauThuThuat")]
        public string BacSyPhauThuatHoVaTen { get; set; }
        [JsonProperty("HoTenBacSiGayMe")]
        public string BacSyGayMeHoVaTen { get; set; }
        [MoTaDuLieu("Mã quản lý: mã duy nhất trong 1 đợt khám chữa bệnh (kcb), không trùng giữa các đợt kcb khác nhau", "", 1)]
        public decimal MaQuanLy { get; set; }
        /// <summary>
        /// Phần này , con sanbox ko dùng
        /// </summary>
        [MoTaDuLieu("","",0,0)]
        [JsonIgnore]
        public string PhuongPhapPhauThuatThuThuat2 { get; set; }
        public string CachThucPhauThuatThuThuat { get; set; }
        [MoTaDuLieu("Chẩn đoán bệnh trước phẫu thuật thủ thuật")]
        public string ChanDoanTruocPhauThuatThuThuat { get; set; }
        [MoTaDuLieu("Chẩn đoán bệnh sau phẫu thuật thủ thuật")]
        public string ChanDoanSauPhauThuatThuThuat { get; set; }
        [MoTaDuLieu("Chẩn đoán bệnh chính")]
        public string ChanDoanChinh { get; set; }
        public string TenPhauThuatThuThuat { get; set; }
        public string MaYLenh { get; set; }
        public int Loai { get; set; }// 11, phẫu thuật, 4 thủ thuật
        public List<ThuocVatTu> VatTuTieuHaos { get; set; }
        public string MoTa { get; set; }
        public List<string> EkipThucHien { get; set; }
        public string EkipThucHien_Text
        {
            get
            {
                string display = string.Empty;
                if(EkipThucHien != null)
                {
                    foreach(string s in EkipThucHien)
                    {
                        display += s + ";";
                    }
                }
                if (display.EndsWith(";"))
                {
                    display = display.Substring(0, display.Length - 1);
                }
                return display;
            }
        }
        public string BacSyChiDinh { get; set; }
        public string MaBacSyChiDinh { get; set; }
        public bool Chon { get; set; }
    }

    public class PhauThuatThuThuat : ThongTinKy
    {
        [MoTaDuLieu("Mã định danh")]
		public long IDPhauThuatThuThuat { get; set; }
        // dung de link den bang ekip mo
        public string MaEkipMo { set; get; }
        /// <summary>
        /// Ngày giờ bắt đầu pttt
        /// </summary>
        public DateTime NgayPhauThuatThuThuat { get; set; }
        public DateTime? NgayPhauThuatThuThuat_Gio { get; set; }
        public string PhuongPhapPhauThuatThuThuat { get; set; }
        public string PhuongPhapVoCam { get; set; }
        /// <summary>
        /// Mã phẫu thuật viên 1m, phần này vừa lưu trong đây, vừa lưu trong table ekip mỗ luôn, không bỏ được, lý do có dữ liệu form cũ đang xài
        /// </summary>
        public string BacSyPhauThuat { get; set; }
        /// <summary>
        /// Mã bác sĩ gây mê, phần này vừa lưu trong đây, vừa lưu trong table ekip mỗ luôn, không bỏ được, lý do có dữ liệu form cũ đang xài
        /// </summary>
        public string BacSyGayMe { get; set; }
        /// <summary>
        /// Họ tên phẫu thuật viên 1, phần này vừa lưu trong đây, vừa lưu trong table ekip mỗ luôn, không bỏ được, lý do có dữ liệu form cũ đang xài
        /// </summary>
        public string BacSyPhauThuatHoVaTen { get; set; }
        /// <summary>
        /// Họ tên bác sĩ gây mê, phần này vừa lưu trong đây, vừa lưu trong table ekip mỗ luôn, không bỏ được, lý do có dữ liệu form cũ đang xài
        /// </summary>
        public string BacSyGayMeHoVaTen { get; set; }
        [MoTaDuLieu("Mã quản lý: mã duy nhất trong 1 đợt khám chữa bệnh (kcb), không trùng giữa các đợt kcb khác nhau","",1)]
		public decimal MaQuanLy { get; set; }

        //update properties for issue :redmine.vietsens.vn/redmine/issues/23945
        //public DateTime PhauThuatBatDau { get; set; } => lấy cái : NgayPhauThuatThuThuat
        public DateTime PhauThuatKetThuc { get; set; }
        public DateTime? PhauThuatKetThuc_Gio { get; set; }
        public string MaChanDoanChinh { get; set; }
        [MoTaDuLieu("Chẩn đoán bệnh")]
		public string ChanDoanChinh { get; set; }
        public string MaChanDoanPhu { get; set; }
        [MoTaDuLieu("Chẩn đoán bệnh")]
		public string ChanDoanPhu { get; set; }
        public string MaChanDoanTruocPTTT { get; set; }
        [MoTaDuLieu("Chẩn đoán bệnh trước phẫu thuật thủ thuật")]
		public string ChanDoanTruocPTTT { get; set; }
        public string MaChanDoanSauPTTT { get; set; }
        [MoTaDuLieu("Chẩn đoán bệnh sau phẫu thuật thủ thuật")]
		public string ChanDoanSauPTTT { get; set; }
        public string MaCachThucPTTT { get; set; }
        public string CachThucPTTT { get; set; }
        //public string PhuongPhapPTTT { get; set; } // different from PhuongPhapPhauThuatThuThuat above => lấy cái trên
        public string MaNgayGiuongPTTT { get; set; }
        public string NgayGiuongPTTT { get; set; }
        public string LoaiPTTT { get; set; }
        //public string PhauThuatVien2 { get; set; }
        //public string PhauThuatVien2HovaTen { get; set; }
        //public string DungCuVien { get; set; }
        //public string DungCuVienHoVaTen { get; set; }
        //public string PhuMe1 { get; set; }
        //public string PhuMe1HoVaTen { get; set; }
        //public string PhuMe2 { get; set; }
        //public string PhuMe2HoVaTen { get; set; }
        //[MoTaDuLieu("Họ tên điều dưỡng")]
		public string DieuDuongNgoai { get; set; }
        [MoTaDuLieu("Họ tên điều dưỡng")]
		public string DieuDuongNgoaiHoVaTen { get; set; }
        //public string PhuMo1 { get; set; }
        //public string PhuMo1HoVaTen { get; set; }
        //public string PhuMo2 { get; set; }
        //public string PhuMo2HoVaTen { get; set; }
        //public string PhuMo3 { get; set; }
        //public string PhuMo3HoVaTen { get; set; }
        //public string PhuMo4 { get; set; }
        //public string PhuMo4HoVaTen { get; set; }
        //public string PhuMo5 { get; set; }
        //public string PhuMo5HoVaTen { get; set; }
        [MoTaDuLieu("Nhóm máu")]
		public string NhomMau { get; set; }
        public string RH { get; set; }
        public int TinhHinhPTTTID { get; set; }
        public string TinhHinhPTTT { get; set; }
        public int TaiBienPTTTID { get; set; }
        public string TaiBienPTTT { get; set; }
        public int TuVongTrongPTTTID { get; set; }
        public string TuVongTrongPTTT { get; set; }
        public string MoTa { get; set; }
        
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

        // Link ảnh mô tả sẽ được lưu là một list các tên ảnh, cách nhau bởi dấu ;
        // khi lấy thông tin link đầu đủ của ảnh, sẽ lấy theo fpt server_folder_link
        // ví dụ LinkAnhMoTa = "truoc_no.png;sau_mo.png;sau_khau.png"
        // link le cua tung anh sẽ là ftp_server + ftp_folder+/truoc_mo.png...
        public string LinkAnhMoTa { get; set; }
        public string DanLuu { get; set; }
        public string Bac { get; set; }
        public DateTime NgayRutChi { get; set; }
        public DateTime NgayCatChi { get; set; }
        public string Khac { get; set; }
        /// <summary>
        /// Phân biệt là phẫu thuật hay thủ thuật
        /// </summary>
        public PhanLoaiPTTT Loai { get; set; }
        public  int? Loai_VBA { get; set; }

        public LoaiTT LoaiTT { get; set; }
        public string TenPhieuTT { get; set; }
        public ObservableCollection<EkipMo> ListEkipMo { get; set; }
        public ObservableCollection<EkipThuThuat> ListEkipThuThuat { get; set; }

        public static string pictureSource1;

        public static string pictureSource2;
        
        public static string PTTloai;

        public static string NoiDungThucHien;
        public bool ShowBSDD { get; set; } 
        public bool ShowSoLuong { get; set; }
        public int? SoLuongBacSy { get; set; }
        public int? SoLuongDD { get; set; }
        public string MaPhieuTT { get; set; }
        [MoTaDuLieu("Đã ký", null, 0, 0)]
        public bool DaKy { get; set; }

    }
    public class EkipMo
    {
        [MoTaDuLieu("Mã định danh")]
		public decimal IDPhauThuatThuThuat { get; set; }
        public string MaEkipMo { get; set; }
        public ChucNangEKipMo ChucVuEkip { get; set; }
        [MoTaDuLieu("Mã nhân viên")]
		public string MaNhanVien { get; set; }
        public string HoTenNhanVien { get; set; }
    }
    public class EkipThuThuat
    {
        [MoTaDuLieu("Mã định danh")]
		public long ID { get; set; }
        public string Stt { get; set; }
        [MoTaDuLieu("Mã định danh")]
		public decimal IDPhauThuatThuThuat { get; set; }
        public DateTime NgayGioThucHien { get; set; }
        public NhanVien BacSy { get; set; }
        public NhanVien DieuDuong { get; set; }
        public string BacSyMa { get; set; }
        [MoTaDuLieu("Họ tên điều dưỡng")]
		public string DieuDuongMa { get; set; }
        public string BacSyTxt { get; set; }
        [MoTaDuLieu("Họ tên điều dưỡng")]
		public string DieuDuongTxt { get; set; }
        public string DienBienBenhNhanSauTT { get; set; }
        public EkipThuThuat()
        {
            BacSy = new NhanVien();
            DieuDuong = new NhanVien();
        }
        public int BacSyTCnt
        {
            get
            {
                int Cnt =0 ;
                if (string.IsNullOrEmpty(BacSyMa))
                {
                    return 0;
                }
                string[] lstData = BacSyMa.Split(new[] { ",\n" }, StringSplitOptions.RemoveEmptyEntries);
                if(lstData != null)
                {
                    Cnt = lstData.Count();
                }

                return Cnt;
            }
        }
        public int DieuDuongCnt
        {
            get
            {
                int Cnt = 0;
                if (string.IsNullOrEmpty(DieuDuongMa))
                {
                    return 0;
                }
                string[] lstData = DieuDuongMa.Split(new[] { ",\n" }, StringSplitOptions.RemoveEmptyEntries);
                if (lstData != null)
                {
                    Cnt = lstData.Count();
                }

                return Cnt;
            }
        }
        public EkipThuThuat Clone()
        {
            EkipThuThuat other = (EkipThuThuat)this.MemberwiseClone();
            other.BacSy = new NhanVien();
            if(BacSy != null)
            {
                other.BacSy = this.BacSy.Clone();
            }
            other.DieuDuong = new NhanVien();
            if (DieuDuong != null)
            {
                other.DieuDuong = this.DieuDuong.Clone();
            } 
            return other;
        }
    }
    public class PhauThuatThuThuatFunc
    {
        public const string TableName = "PhauThuatThuThuat";
        public const string TablePrimaryKeyName = "IDPhauThuatThuThuat";
        public static bool CheckConnection()
        {

            try
            {
                using (var client = new HttpClient())
                {
                    try
                    {
                        string URL = ERMDatabase.WebServiceEMR;
                        client.BaseAddress = new Uri(URL);
                        client.DefaultRequestHeaders.Accept.Clear();
                        client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                        client.Timeout = new TimeSpan(0, 0, 500);
                        var url = "api/KetXuat/CheckConnection";
                        HttpResponseMessage response = client.GetAsync(url).Result;
                        response.EnsureSuccessStatusCode();
                        if (response.IsSuccessStatusCode)
                        {
                            string result = response.Content.ReadAsStringAsync().Result;
                            if (result == "true")
                            {
                                return true;
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        XuLyLoi.LogError(ex);
                    }
                }
            }
            catch (Exception ex)
            {
                XuLyLoi.Handle(ex);
            }
            finally
            {
            }
            return false;
        }
        public static List<PhauThuatThuThuat> ListPhauThuatThuThuat { get; private set; }

        public static List<PhauThuatThuThuat> GetListPhauThuatThuThuat(MDB.MDBConnection MyConnection, decimal MaQuanLy)
        {
            #region
            string sql =
                      @"select IDPhauThuatThuThuat, NgayPhauThuatThuThuat, PhuongPhapPhauThuatThuThuat, PhuongPhapVoCam, BacSyPhauThuatHoVaTen, BacSyGayMeHoVaTen, Loai_VBA
            from PhauThuatThuThuat 
                  where MaQuanLy = '" + (decimal)MaQuanLy + "' and (Loai = 0 or Loai is null) and TenPhieuTT is null and MaPhieuTT is null";

            #endregion
            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
            MDB.MDBDataReader DataReader = Command.ExecuteReader();
            ListPhauThuatThuThuat = new List<PhauThuatThuThuat>();
            int tempInt = 0;
            while (DataReader.Read())
            {

                ListPhauThuatThuThuat.Add(new PhauThuatThuThuat
                {
                    IDPhauThuatThuThuat = DataReader.GetInt("IDPhauThuatThuThuat"),
                    MaQuanLy = MaQuanLy,
                    NgayPhauThuatThuThuat = DataReader.GetDate("NgayPhauThuatThuThuat"),
                    PhuongPhapPhauThuatThuThuat = DataReader["PhuongPhapPhauThuatThuThuat"].ToString(),
                    PhuongPhapVoCam = DataReader["PhuongPhapVoCam"].ToString(),
                    BacSyPhauThuatHoVaTen = DataReader["BacSyPhauThuatHoVaTen"].ToString(),
                    BacSyGayMeHoVaTen = DataReader["BacSyGayMeHoVaTen"].ToString(),
                    Loai_VBA = int.TryParse(DataReader["Loai_VBA"].ToString(), out tempInt) ? (int?)tempInt : null
                }); ;
            }
            return ListPhauThuatThuThuat;
        }
        public static PhauThuatThuThuat Select(MDB.MDBConnection MyConnection, decimal IDPhauThuatThuThuat)
        {
            #region
            string sql =
                      @"select * 
                        from PhauThuatThuThuat a
                        where IDPhauThuatThuThuat = :IDPhauThuatThuThuat";
            #endregion
            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
            Command.Parameters.Add(new MDB.MDBParameter("IDPhauThuatThuThuat", IDPhauThuatThuThuat));
            MDB.MDBDataReader DataReader = Command.ExecuteReader();
            PhauThuatThuThuat PhauThuatThuThuat = new PhauThuatThuThuat();

            while (DataReader.Read())
            {
                PhauThuatThuThuat.IDPhauThuatThuThuat = int.Parse(DataReader["IDPHAUTHUATTHUTHUAT"].ToString());
                PhauThuatThuThuat.MaQuanLy = decimal.Parse(DataReader["MaQuanLy"].ToString());
                PhauThuatThuThuat.NgayPhauThuatThuThuat = DateTime.Parse(DataReader["NgayPhauThuatThuThuat"].ToString());
                PhauThuatThuThuat.NgayPhauThuatThuThuat_Gio = PhauThuatThuThuat.NgayPhauThuatThuThuat;
                PhauThuatThuThuat.PhuongPhapPhauThuatThuThuat = DataReader["PhuongPhapPhauThuatThuThuat"].ToString();
                PhauThuatThuThuat.BacSyPhauThuat = DataReader["BacSyPhauThuat"] != null ? DataReader["BacSyPhauThuat"].ToString() : null;
                PhauThuatThuThuat.BacSyGayMe = DataReader["BacSyGayMe"] != null ? DataReader["BacSyGayMe"].ToString() : null;
                PhauThuatThuThuat.PhauThuatKetThuc = DateTime.Parse(DataReader["PhauThuatKetThuc"].ToString());
                PhauThuatThuThuat.MaEkipMo = DataReader["MaEkipMo"].ToString(); ;

                PhauThuatThuThuat.BacSyPhauThuatHoVaTen = DataReader["BacSyPhauThuatHoVaTen"] != null ? DataReader["BacSyPhauThuatHoVaTen"].ToString() : null;
                PhauThuatThuThuat.BacSyGayMeHoVaTen = DataReader["BacSyGayMeHoVaTen"] != null ? DataReader["BacSyGayMeHoVaTen"].ToString() : null;

                PhauThuatThuThuat.DieuDuongNgoaiHoVaTen = DataReader["DieuDuongNgoaiHoVaTen"] != null ? DataReader["DieuDuongNgoaiHoVaTen"].ToString() : null;

                PhauThuatThuThuat.MaChanDoanChinh = DataReader["MaChanDoanChinh"] != null ? DataReader["MaChanDoanChinh"].ToString(): null ;
                PhauThuatThuThuat.ChanDoanChinh = DataReader["ChanDoanChinh"] != null ? DataReader["ChanDoanChinh"].ToString() : null;
                PhauThuatThuThuat.MaChanDoanPhu = DataReader["MaChanDoanPhu"] != null ? DataReader["MaChanDoanPhu"].ToString() : null;
                PhauThuatThuThuat.ChanDoanPhu = DataReader["ChanDoanPhu"] != null ? DataReader["ChanDoanPhu"].ToString() : null;
                PhauThuatThuThuat.MaChanDoanTruocPTTT = DataReader["MaChanDoanTruocPTTT"] != null ? DataReader["MaChanDoanTruocPTTT"].ToString() : null;
                PhauThuatThuThuat.ChanDoanTruocPTTT = DataReader["ChanDoanTruocPTTT"] != null ? DataReader["ChanDoanTruocPTTT"].ToString() : null;
                PhauThuatThuThuat.MaChanDoanSauPTTT = DataReader["MaChanDoanSauPTTT"] != null ? DataReader["MaChanDoanSauPTTT"].ToString() : null;
                PhauThuatThuThuat.ChanDoanSauPTTT = DataReader["ChanDoanSauPTTT"] != null ? DataReader["ChanDoanSauPTTT"].ToString() : null;
                PhauThuatThuThuat.MaCachThucPTTT = DataReader["MaCachThucPTTT"] != null ? DataReader["MaCachThucPTTT"].ToString() : null;
                PhauThuatThuThuat.CachThucPTTT = DataReader["CachThucPTTT"] != null ? DataReader["CachThucPTTT"].ToString() : null;
                PhauThuatThuThuat.NgayGiuongPTTT = DataReader["NgayGiuongPTTT"] != null ? DataReader["NgayGiuongPTTT"].ToString() : null;
                PhauThuatThuThuat.LoaiPTTT = DataReader["LoaiPTTT"] != null ? DataReader["LoaiPTTT"].ToString() : null;
                PhauThuatThuThuat.PhuongPhapVoCam = DataReader["PhuongPhapVoCam"] != null ? DataReader["PhuongPhapVoCam"].ToString() : null;
                int loaiThuThuat = 0;
                if(DataReader["LoaiTT"] != null && int.TryParse(DataReader["LoaiTT"].ToString(), out loaiThuThuat))
                {
                    PhauThuatThuThuat.LoaiTT = (LoaiTT) loaiThuThuat;
                }
                PhauThuatThuThuat.NhomMau = DataReader["NhomMau"] != null ? DataReader["NhomMau"].ToString() : null;
                PhauThuatThuThuat.RH = DataReader["RH"] != null ? DataReader["RH"].ToString() : null;
                PhauThuatThuThuat.TinhHinhPTTT = DataReader["TinhHinhPTTT"] != null ? DataReader["TinhHinhPTTT"].ToString() : null;
                PhauThuatThuThuat.TaiBienPTTT = DataReader["TaiBienPTTT"] != null ? DataReader["TaiBienPTTT"].ToString() : null;
                PhauThuatThuThuat.TuVongTrongPTTT = DataReader["TuVongTrongPTTT"] != null ? DataReader["TuVongTrongPTTT"].ToString() : null;
                PhauThuatThuThuat.MoTa = DataReader["MoTa"] != null ? DataReader["MoTa"].ToString() : null;
                PhauThuatThuThuat.LinkAnhMoTa = DataReader["LinkAnhMoTa"] != null ? DataReader["LinkAnhMoTa"].ToString() : null;
                PhauThuatThuThuat.DanLuu = DataReader["DanLuu"] != null ? DataReader["DanLuu"].ToString() : null;
                PhauThuatThuThuat.Bac = DataReader["Bac"] != null ? DataReader["Bac"].ToString() : null;
                PhauThuatThuThuat.NgayRutChi = DateTime.Parse(DataReader["NgayRutChi"].ToString());
                PhauThuatThuThuat.NgayCatChi = DateTime.Parse(DataReader["NgayCatChi"].ToString());
                PhauThuatThuThuat.Khac = DataReader["Khac"] != null ? DataReader["Khac"].ToString() : null;
                PhauThuatThuThuat.NguoiTao = DataReader["NguoiTao"] != null ? DataReader["NguoiTao"].ToString() : null;
                PhauThuatThuThuat.NguoiSua = DataReader["NguoiSua"] != null ? DataReader["NguoiSua"].ToString() : null;
                int tempInt = 0;
                PhauThuatThuThuat.Loai_VBA = int.TryParse(DataReader["Loai_VBA"].ToString(), out tempInt) ? (int?)tempInt : null;

                PhauThuatThuThuat.MaSoKy = DataReader["masokyten"].ToString();
                PhauThuatThuThuat.DaKy = !string.IsNullOrEmpty(PhauThuatThuThuat.MaSoKy) ? true : false;
                if (DataReader["NgayTao"] != null)
                {
                    DateTime tempDate;
                    if (DateTime.TryParse(DataReader["NgayTao"].ToString(), out tempDate))
                    {
                        PhauThuatThuThuat.NgayTao = tempDate;
                    }
                    else
                    {
                        PhauThuatThuThuat.NgayTao = DateTime.Now;
                    }
                } 
                else
                    PhauThuatThuThuat.NgayTao = DateTime.Now;

                if (DataReader["NgaySua"] != null)
                {
                    DateTime tempDate;
                    if (DateTime.TryParse(DataReader["NgaySua"].ToString(), out tempDate))
                    {
                        PhauThuatThuThuat.NgaySua = tempDate;
                    }
                    else
                    {
                        PhauThuatThuThuat.NgaySua = DateTime.Now;
                    }
                }
                else
                    PhauThuatThuThuat.NgaySua = DateTime.Now;
            }
            // get ekip mo
            PhauThuatThuThuat.ListEkipMo = getEkipMo(MyConnection, PhauThuatThuThuat.IDPhauThuatThuThuat);
            return PhauThuatThuThuat;
        }
        public static ObservableCollection<EkipMo> getEkipMo(MDB.MDBConnection MyConnection, decimal IDPhauThuatThuThuat)
        {
            ObservableCollection<EkipMo> listEkipMo = new ObservableCollection<EkipMo>();
            string sql =
                     @"select * 
                        from EKipMo
                        where IDPhauThuatThuThuat = :IDPhauThuatThuThuat";
            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
            Command.Parameters.Add("IDPhauThuatThuThuat", IDPhauThuatThuThuat);
            MDB.MDBDataReader DataReader = Command.ExecuteReader();

            while (DataReader.Read())
            {
                EkipMo ekipMo = new EkipMo() ;
                ekipMo.IDPhauThuatThuThuat = IDPhauThuatThuThuat;
                ekipMo.MaNhanVien= DataReader["MANHANVIEN"].ToString();
                ekipMo.HoTenNhanVien = DataReader["HOTENNHANVIEN"].ToString();
                string cv = DataReader["CHUCVUEKIP"].ToString();
                ekipMo.ChucVuEkip = (ChucNangEKipMo) Enum.Parse(typeof(ChucNangEKipMo), cv);
                listEkipMo.Add(ekipMo);
            }
            return listEkipMo;
        }
        public static DataSet GetDataSet(MDB.MDBConnection MyConnection, decimal IDPhauThuatThuThuat)
        {
            string sql2 = @"SELECT
                P.*,
	            T.MABENHNHAN,
	            T.KHOA,
	            T.GIUONG,
                T.BUONG,
	            T.NGAYVAOVIEN,
                T.ChanDoanTruocPhauThuat,
	            H.SOYTE,
	            H.BENHVIEN,
	            H.MABENHNHAN,
	            H.TENBENHNHAN,
	            H.TUOI,
	            H.GIOITINH,
                E.HOTENNHANVIEN AS PHUMO1
            FROM
                PHAUTHUATTHUTHUAT P
                JOIN THONGTINDIEUTRI T ON P.MAQUANLY = T.MAQUANLY
                JOIN HANHCHINHBENHNHAN H ON T.MABENHNHAN = H.MABENHNHAN
                LEFT JOIN EKipMo E ON E.IDPHAUTHUATTHUTHUAT = P.IDPHAUTHUATTHUTHUAT AND E.ChucVuEkip = 'PhuMo1'
            WHERE
                P.IDPHAUTHUATTHUTHUAT = :IDPhauThuatThuThuat";
            MDB.MDBCommand Command = new MDB.MDBCommand(sql2, MyConnection);
            Command.Parameters.Add(new MDB.MDBParameter("IDPhauThuatThuThuat", IDPhauThuatThuThuat));

            MDB.MDBDataAdapter adt = new MDB.MDBDataAdapter(Command);
            var ds = new DataSet();
            adt.Fill(ds);
            if(ds.Tables[0].Rows.Count > 1)
            {
                for (int i = 1; i < ds.Tables[0].Rows.Count; i++)
                    ds.Tables[0].Rows[i].Delete();
                ds.Tables[0].AcceptChanges();
            }
            return ds;
        }
        public static bool Insert(MDB.MDBConnection MyConnection, ref PhauThuatThuThuat PhauThuatThuThuat)
        {
            string sql = @"INSERT INTO PhauThuatThuThuat (
		        MaQuanLy,
		        NgayPhauThuatThuThuat,
		        PhauThuatKetThuc,
		        PhuongPhapPhauThuatThuThuat,
		        MaEkipMo,
		        BacSyPhauThuat,
		        BacSyGayMe,
                BacSyPhauThuatHoVaTen,
                BacSyGayMeHoVaTen,
                DieuDuongNgoaiHoVaTen,
		        MaChanDoanChinh,
		        ChanDoanChinh,
		        MaChanDoanPhu,
		        ChanDoanPhu,
		        MaChanDoanTruocPTTT,
		        ChanDoanTruocPTTT,
		        MaChanDoanSauPTTT,
		        ChanDoanSauPTTT,
		        MaCachThucPTTT,
		        CachThucPTTT,
		        NgayGiuongPTTT,
		        LoaiPTTT,
                PhuongPhapVoCam,
                Loai,
                LoaiTT,
		        NhomMau,
		        RH,
		        TinhHinhPTTT,
		        TaiBienPTTT,
		        TuVongTrongPTTT,
		        MoTa,
		        LinkAnhMoTa,
		        DanLuu,
		        Bac,
		        NgayRutChi,
		        NgayCatChi,
		        Khac,
                Loai_VBA,
                NgayTao,
                NguoiTao,
                NgaySua,
                NguoiSua
	        )
            VALUES
	            (
		    :MaQuanLy, :NgayPhauThuatThuThuat, :PhauThuatKetThuc, :PhuongPhapPhauThuatThuThuat,
		    :MaEkipMo, :BacSyPhauThuat, : BacSyGayMe, :BacSyPhauThuatHoVaTen , :BacSyGayMeHoVaTen, :DieuDuongNgoaiHoVaTen, 
		    :MaChanDoanChinh, :ChanDoanChinh, :MaChanDoanPhu, :ChanDoanPhu, 
		    :MaChanDoanTruocPTTT, :ChanDoanTruocPTTT, :MaChanDoanSauPTTT, :ChanDoanSauPTTT,
		    :MaCachThucPTTT, :CachThucPTTT, :NgayGiuongPTTT,
		    :LoaiPTTT, :PhuongPhapVoCam, :Loai, :LoaiTT, :NhomMau, :RH, :TinhHinhPTTT, :TaiBienPTTT, :TuVongTrongPTTT,
	        :MoTa, :LinkAnhMoTa, :DanLuu, :Bac, 
	        :NgayRutChi, :NgayCatChi, :Khac, :Loai_VBA, :NgayTao, :NguoiTao, :NgaySua, :NguoiSua )  RETURNING IDPhauThuatThuThuat INTO :IDPhauThuatThuThuat";
            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
            Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", PhauThuatThuThuat.MaQuanLy));
            var Ngay = PhauThuatThuThuat.NgayPhauThuatThuThuat.Date.Add(new TimeSpan(0, 0, 0));
            var Gio = PhauThuatThuThuat.NgayPhauThuatThuThuat_Gio != null ? PhauThuatThuThuat.NgayPhauThuatThuThuat_Gio.Value.TimeOfDay : DateTime.Now.TimeOfDay;
            var ngayPhauThuatThuThuat = Ngay + Gio;
            Command.Parameters.Add(new MDB.MDBParameter("NgayPhauThuatThuThuat", ngayPhauThuatThuThuat));
            
            Ngay = PhauThuatThuThuat.PhauThuatKetThuc.Date.Add(new TimeSpan(0, 0, 0));
            Gio = PhauThuatThuThuat.PhauThuatKetThuc_Gio != null ? PhauThuatThuThuat.PhauThuatKetThuc_Gio.Value.TimeOfDay : DateTime.Now.TimeOfDay;
            var ketThucPhauThuatThuThuat = Ngay + Gio;

            Command.Parameters.Add(new MDB.MDBParameter("PhauThuatKetThuc", ketThucPhauThuatThuThuat));
            Command.Parameters.Add(new MDB.MDBParameter("PhuongPhapPhauThuatThuThuat", PhauThuatThuThuat.PhuongPhapPhauThuatThuThuat));
            Command.Parameters.Add(new MDB.MDBParameter("MaEkipMo", PhauThuatThuThuat.MaEkipMo));
            
            Command.Parameters.Add(new MDB.MDBParameter("BacSyPhauThuatHoVaTen", PhauThuatThuThuat.BacSyPhauThuatHoVaTen));
            Command.Parameters.Add(new MDB.MDBParameter("BacSyGayMeHoVaTen", PhauThuatThuThuat.BacSyGayMeHoVaTen));

            Command.Parameters.Add(new MDB.MDBParameter("BacSyPhauThuat", PhauThuatThuThuat.BacSyPhauThuat));
            Command.Parameters.Add(new MDB.MDBParameter("BacSyGayMe", PhauThuatThuThuat.BacSyGayMe));
            Command.Parameters.Add(new MDB.MDBParameter("DieuDuongNgoaiHoVaTen", PhauThuatThuThuat.DieuDuongNgoaiHoVaTen));

            Command.Parameters.Add(new MDB.MDBParameter("MaChanDoanChinh", PhauThuatThuThuat.MaChanDoanChinh));
            Command.Parameters.Add(new MDB.MDBParameter("ChanDoanChinh", PhauThuatThuThuat.ChanDoanChinh));
            Command.Parameters.Add(new MDB.MDBParameter("MaChanDoanPhu", PhauThuatThuThuat.MaChanDoanPhu));
            Command.Parameters.Add(new MDB.MDBParameter("ChanDoanPhu", PhauThuatThuThuat.ChanDoanPhu));
            Command.Parameters.Add(new MDB.MDBParameter("MaChanDoanTruocPTTT", PhauThuatThuThuat.MaChanDoanTruocPTTT));
            Command.Parameters.Add(new MDB.MDBParameter("ChanDoanTruocPTTT", PhauThuatThuThuat.ChanDoanTruocPTTT));
            Command.Parameters.Add(new MDB.MDBParameter("MaChanDoanSauPTTT", PhauThuatThuThuat.MaChanDoanSauPTTT));
            Command.Parameters.Add(new MDB.MDBParameter("ChanDoanSauPTTT", PhauThuatThuThuat.ChanDoanSauPTTT));
            Command.Parameters.Add(new MDB.MDBParameter("MaCachThucPTTT", PhauThuatThuThuat.MaCachThucPTTT));
            Command.Parameters.Add(new MDB.MDBParameter("CachThucPTTT", PhauThuatThuThuat.CachThucPTTT));
            Command.Parameters.Add(new MDB.MDBParameter("NgayGiuongPTTT", PhauThuatThuThuat.NgayGiuongPTTT));
            Command.Parameters.Add(new MDB.MDBParameter("LoaiPTTT", PhauThuatThuThuat.LoaiPTTT));
            Command.Parameters.Add(new MDB.MDBParameter("PhuongPhapVoCam", PhauThuatThuThuat.PhuongPhapVoCam));
            Command.Parameters.Add(new MDB.MDBParameter("Loai", (int) PhauThuatThuThuat.Loai));
            Command.Parameters.Add(new MDB.MDBParameter("LoaiTT", (int)PhauThuatThuThuat.LoaiTT));
            Command.Parameters.Add(new MDB.MDBParameter("NhomMau", PhauThuatThuThuat.NhomMau));
            Command.Parameters.Add(new MDB.MDBParameter("RH", PhauThuatThuThuat.RH));
            Command.Parameters.Add(new MDB.MDBParameter("TinhHinhPTTT", PhauThuatThuThuat.TinhHinhPTTT));
            Command.Parameters.Add(new MDB.MDBParameter("TaiBienPTTT", PhauThuatThuThuat.TaiBienPTTT));
            Command.Parameters.Add(new MDB.MDBParameter("TuVongTrongPTTT", PhauThuatThuThuat.TuVongTrongPTTT));
            Command.Parameters.Add(new MDB.MDBParameter("MoTa", PhauThuatThuThuat.MoTa));
            Command.Parameters.Add(new MDB.MDBParameter("LinkAnhMoTa", PhauThuatThuThuat.LinkAnhMoTa));
            Command.Parameters.Add(new MDB.MDBParameter("DanLuu", PhauThuatThuThuat.DanLuu));
            Command.Parameters.Add(new MDB.MDBParameter("Bac", PhauThuatThuThuat.Bac));
            Command.Parameters.Add(new MDB.MDBParameter("NgayRutChi", PhauThuatThuThuat.NgayRutChi));
            Command.Parameters.Add(new MDB.MDBParameter("NgayCatChi", PhauThuatThuThuat.NgayCatChi));
            Command.Parameters.Add(new MDB.MDBParameter("Khac", PhauThuatThuThuat.Khac));
            Command.Parameters.Add(new MDB.MDBParameter("Loai_VBA", PhauThuatThuThuat.Loai_VBA));
            Command.Parameters.Add(new MDB.MDBParameter("NgayTao", PhauThuatThuThuat.NgayTao));
            Command.Parameters.Add(new MDB.MDBParameter("NguoiTao", PhauThuatThuThuat.NguoiTao));
            Command.Parameters.Add(new MDB.MDBParameter("NgaySua", PhauThuatThuThuat.NgaySua));
            Command.Parameters.Add(new MDB.MDBParameter("NguoiSua", PhauThuatThuThuat.NguoiSua));
            Command.Parameters.Add(new MDB.MDBParameter("IDPhauThuatThuThuat", PhauThuatThuThuat.IDPhauThuatThuThuat));
            Command.BindByName = true;
            int n = Command.ExecuteNonQuery(); // C#
            long nextval = Convert.ToInt64((Command.Parameters["IDPhauThuatThuThuat"] as MDB.MDBParameter).Value);
            PhauThuatThuThuat.IDPhauThuatThuThuat = nextval;
            
            if (n > 0 && PhauThuatThuThuat.ListEkipThuThuat != null)
            {
                foreach(EkipThuThuat ekip in PhauThuatThuThuat.ListEkipThuThuat) { 
                    sql = @"INSERT INTO EkipThuThuat (
		            IDPhauThuatThuThuat,
		            NgayGioThucHien,
                    BacSyMa,
		            DieuDuongMa,
                    BacSyTxt,
		            DieuDuongTxt,
		            BacSy,
		            DieuDuong,
		            DienBienBenhNhanSauTT
	                )
                    VALUES
	                    (
		            : IDPhauThuatThuThuat, : NgayGioThucHien,:BacSyMa, :DieuDuongMa, : BacSyTxt, : DieuDuongTxt, : BacSy, : DieuDuong,
		            : DienBienBenhNhanSauTT)";
                    Command = new MDB.MDBCommand(sql, MyConnection);
                    Command.Parameters.Add(new MDB.MDBParameter("IDPhauThuatThuThuat", PhauThuatThuThuat.IDPhauThuatThuThuat));
                    Command.Parameters.Add(new MDB.MDBParameter("NgayGioThucHien", ekip.NgayGioThucHien));
                    Command.Parameters.Add(new MDB.MDBParameter("BacSyMa", ekip.BacSyMa));
                    Command.Parameters.Add(new MDB.MDBParameter("DieuDuongMa", ekip.DieuDuongMa));
                    Command.Parameters.Add(new MDB.MDBParameter("BacSyTxt", ekip.BacSyTxt));
                    Command.Parameters.Add(new MDB.MDBParameter("DieuDuongTxt", ekip.DieuDuongTxt));
                    Command.Parameters.Add(new MDB.MDBParameter("BacSy", ekip.BacSy.IdNhanVien));
                    Command.Parameters.Add(new MDB.MDBParameter("DieuDuong", ekip.DieuDuong.IdNhanVien));
                    Command.Parameters.Add(new MDB.MDBParameter("DienBienBenhNhanSauTT", ekip.DienBienBenhNhanSauTT));
                }

            }

            return n > 0 ? true : false;

        }

        public static bool InsertOrUpdateTT(MDB.MDBConnection MyConnection, ref PhauThuatThuThuat PhauThuatThuThuat)
        {

            int n = 0;
            ObservableCollection<EkipThuThuat> lstOlData = new ObservableCollection<EkipThuThuat>();
            if (PhauThuatThuThuat.IDPhauThuatThuThuat > 0)
            {
                string sql = "UPDATE PhauThuatThuThuat SET " +
                    "LoaiTT = :LoaiTT, " +
                    "LoaiPTTT = :LoaiPTTT, " +
                    "MaPhieuTT = :MaPhieuTT, " +
                    "TenPhieuTT = :TenPhieuTT, " +
                    "ChanDoanChinh = :ChanDoanChinh, " + 
                    "MoTa = :MoTa, " +
                    "BacSyPhauThuatHoVaTen = :BacSyPhauThuatHoVaTen, " +
                    "DieuDuongNgoaiHoVaTen = :DieuDuongNgoaiHoVaTen, " +
                    "PhuongPhapVoCam = :PhuongPhapVoCam, " +
                    "ShowBSDD = :ShowBSDD, " +
                    "ShowSoLuong = :ShowSoLuong, " +
                    "SoLuongBacSy = :SoLuongBacSy, " +
                    "SoLuongDD = :SoLuongDD, " +
                    "NGUOISUA = :NGUOISUA, " +
                    "NGAYSUA = :NGAYSUA " +
                    "WHERE IDPhauThuatThuThuat = :IDPhauThuatThuThuat";
                MDB.MDBCommand command = new MDB.MDBCommand(sql, MyConnection);
                command.Parameters.Add(new MDB.MDBParameter("LoaiTT", (int)PhauThuatThuThuat.LoaiTT));
                command.Parameters.Add(new MDB.MDBParameter("LoaiPTTT", PhauThuatThuThuat.LoaiPTTT));
                command.Parameters.Add(new MDB.MDBParameter("TenPhieuTT", PhauThuatThuThuat.TenPhieuTT));
                command.Parameters.Add(new MDB.MDBParameter("MaPhieuTT", PhauThuatThuThuat.MaPhieuTT));
                command.Parameters.Add(new MDB.MDBParameter("MoTa", PhauThuatThuThuat.MoTa));
                command.Parameters.Add(new MDB.MDBParameter("ChanDoanChinh", PhauThuatThuThuat.ChanDoanChinh));
                command.Parameters.Add(new MDB.MDBParameter("IDPhauThuatThuThuat", PhauThuatThuThuat.IDPhauThuatThuThuat));
                command.Parameters.Add(new MDB.MDBParameter("BacSyPhauThuatHoVaTen", PhauThuatThuThuat.BacSyPhauThuatHoVaTen));
                command.Parameters.Add(new MDB.MDBParameter("DieuDuongNgoaiHoVaTen", PhauThuatThuThuat.DieuDuongNgoaiHoVaTen));
                command.Parameters.Add(new MDB.MDBParameter("PhuongPhapVoCam", PhauThuatThuThuat.PhuongPhapVoCam));
                command.Parameters.Add(new MDB.MDBParameter("ShowBSDD", PhauThuatThuThuat.ShowBSDD ? 1:0));
                command.Parameters.Add(new MDB.MDBParameter("ShowSoLuong", PhauThuatThuThuat.ShowSoLuong ? 1 : 0));
                command.Parameters.Add(new MDB.MDBParameter("SoLuongBacSy", PhauThuatThuThuat.SoLuongBacSy));
                command.Parameters.Add(new MDB.MDBParameter("SoLuongDD", PhauThuatThuThuat.SoLuongDD));

                command.Parameters.Add(new MDB.MDBParameter("NGUOISUA", PhauThuatThuThuat.NguoiSua));
                command.Parameters.Add(new MDB.MDBParameter("NGAYSUA", PhauThuatThuThuat.NgaySua));
                command.BindByName = true;
                n = command.ExecuteNonQuery();
                lstOlData = getListEkipThuThuat(MyConnection, PhauThuatThuThuat.IDPhauThuatThuThuat);
            }
            else { 
               
                string sql = @"INSERT INTO PhauThuatThuThuat (
		            MaQuanLy,
		            LoaiPTTT,
                    LoaiTT,
                    TenPhieuTT,
                    MaPhieuTT,
                    ChanDoanChinh,
		            MoTa,
                    BacSyPhauThuatHoVaTen,
                    DieuDuongNgoaiHoVaTen,
                    PhuongPhapVoCam,
                    ShowBSDD,
                    ShowSoLuong,
                    SoLuongBacSy,
                    SoLuongDD,
                    NGUOITAO,
                    NGUOISUA,
                    NGAYTAO,
                    NGAYSUA
                    )
                    VALUES(
		            :MaQuanLy,
                    :LoaiPTTT,
                    :LoaiTT,
                    :TenPhieuTT,
                    :MaPhieuTT,
                    :ChanDoanChinh,
                    :MoTa,
                    :BacSyPhauThuatHoVaTen,
                    :DieuDuongNgoaiHoVaTen,
                    :PhuongPhapVoCam,
                    :ShowBSDD,
                    :ShowSoLuong,
                    :SoLuongBacSy,
                    :SoLuongDD,    
                    :NGUOITAO,
                    :NGUOISUA,
                    :NGAYTAO,
                    :NGAYSUA) 
                    RETURNING IDPhauThuatThuThuat INTO :IDPhauThuatThuThuat";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", PhauThuatThuThuat.MaQuanLy));
                Command.Parameters.Add(new MDB.MDBParameter("LoaiPTTT", PhauThuatThuThuat.LoaiPTTT));
                Command.Parameters.Add(new MDB.MDBParameter("LoaiTT", (int)PhauThuatThuThuat.LoaiTT));
                Command.Parameters.Add(new MDB.MDBParameter("TenPhieuTT", PhauThuatThuThuat.TenPhieuTT));
                Command.Parameters.Add(new MDB.MDBParameter("ChanDoanChinh", PhauThuatThuThuat.ChanDoanChinh));
                Command.Parameters.Add(new MDB.MDBParameter("MaPhieuTT", PhauThuatThuThuat.MaPhieuTT));
                Command.Parameters.Add(new MDB.MDBParameter("MoTa", PhauThuatThuThuat.MoTa));
                Command.Parameters.Add(new MDB.MDBParameter("IDPhauThuatThuThuat", PhauThuatThuThuat.IDPhauThuatThuThuat));
                Command.Parameters.Add(new MDB.MDBParameter("BacSyPhauThuatHoVaTen", PhauThuatThuThuat.BacSyPhauThuatHoVaTen));
                Command.Parameters.Add(new MDB.MDBParameter("DieuDuongNgoaiHoVaTen", PhauThuatThuThuat.DieuDuongNgoaiHoVaTen));
                Command.Parameters.Add(new MDB.MDBParameter("PhuongPhapVoCam", PhauThuatThuThuat.PhuongPhapVoCam));
                Command.Parameters.Add(new MDB.MDBParameter("ShowBSDD", PhauThuatThuThuat.ShowBSDD ? 1 : 0));
                Command.Parameters.Add(new MDB.MDBParameter("ShowSoLuong", PhauThuatThuThuat.ShowSoLuong ? 1 : 0));
                Command.Parameters.Add(new MDB.MDBParameter("SoLuongBacSy", PhauThuatThuThuat.SoLuongBacSy));
                Command.Parameters.Add(new MDB.MDBParameter("SoLuongDD", PhauThuatThuThuat.SoLuongDD));
                Command.Parameters.Add(new MDB.MDBParameter("NGUOITAO", PhauThuatThuThuat.NguoiTao));
                Command.Parameters.Add(new MDB.MDBParameter("NGAYTAO", PhauThuatThuThuat.NgayTao));
                Command.Parameters.Add(new MDB.MDBParameter("NGUOISUA", PhauThuatThuThuat.NguoiSua));
                Command.Parameters.Add(new MDB.MDBParameter("NGAYSUA", PhauThuatThuThuat.NgaySua));
                Command.BindByName = true;
                n = Command.ExecuteNonQuery(); // C#
                if (n > 0)
                {
                    long nextval = (long)((Command.Parameters["IDPhauThuatThuThuat"] as MDB.MDBParameter).Value);
                    PhauThuatThuThuat.IDPhauThuatThuThuat = nextval;
                }
            }

            if (n > 0 && PhauThuatThuThuat.ListEkipThuThuat != null)
            {
                foreach (EkipThuThuat ekip in PhauThuatThuThuat.ListEkipThuThuat)
                {
                    string sql = "";
                    if (ekip.ID == 0)
                    {
                        sql = @"INSERT INTO EkipThuThuat (
		                IDPhauThuatThuThuat,
		                NgayGioThucHien,
                        BacSyMa,
                        DieuDuongMa,
                        BacSyTxt,
                        DieuDuongTxt,
		                BacSy,
		                DieuDuong,
		                DienBienBenhNhanSauTT
	                    )
                        VALUES
	                    (
		                :IDPhauThuatThuThuat,
                        :NgayGioThucHien, 
                        :BacSyMa,
                        :DieuDuongMa,
                        :BacSyTxt,
                        :DieuDuongTxt,
                        :BacSy,
                        :DieuDuong,
		                :DienBienBenhNhanSauTT)";
                    }
                    else
                    {
                           sql = "UPDATE EkipThuThuat SET " +
                           "IDPhauThuatThuThuat = :IDPhauThuatThuThuat, " +
                           "NgayGioThucHien = :NgayGioThucHien, " +
                           "BacSyMa = :BacSyMa, " +
                           "DieuDuongMa = :DieuDuongMa, " +
                           "BacSyTxt = :BacSyTxt, " +
                           "DieuDuongTxt = :DieuDuongTxt, " +
                           "BacSy = :BacSy, " +
                           "DieuDuong = :DieuDuong, " +
                           "DienBienBenhNhanSauTT = :DienBienBenhNhanSauTT " +
                           "WHERE ID = :ID";
                    }
                    MDB.MDBCommand command = new MDB.MDBCommand(sql, MyConnection);
                    command.Parameters.Add(new MDB.MDBParameter("IDPhauThuatThuThuat", PhauThuatThuThuat.IDPhauThuatThuThuat));
                    command.Parameters.Add(new MDB.MDBParameter("NgayGioThucHien", ekip.NgayGioThucHien));
                    command.Parameters.Add(new MDB.MDBParameter("BacSyMa", ekip.BacSyMa));
                    command.Parameters.Add(new MDB.MDBParameter("DieuDuongMa", ekip.DieuDuongMa));
                    command.Parameters.Add(new MDB.MDBParameter("BacSyTxt", ekip.BacSyTxt));
                    command.Parameters.Add(new MDB.MDBParameter("DieuDuongTxt", ekip.DieuDuongTxt));
                    if (ekip.BacSy != null)
                        command.Parameters.Add(new MDB.MDBParameter("BacSy", ekip.BacSy.IdNhanVien));
                    else
                        command.Parameters.Add(new MDB.MDBParameter("BacSy", null));
                    if (ekip.DieuDuong != null)
                        command.Parameters.Add(new MDB.MDBParameter("DieuDuong", ekip.DieuDuong.IdNhanVien));
                    else
                        command.Parameters.Add(new MDB.MDBParameter("DieuDuong", null));
                    command.Parameters.Add(new MDB.MDBParameter("DienBienBenhNhanSauTT", ekip.DienBienBenhNhanSauTT));
                    if(ekip.ID > 0)
                        command.Parameters.Add(new MDB.MDBParameter("ID", ekip.ID));
                    command.ExecuteNonQuery();
                }
                if(lstOlData.Count > 0)
                {
                    foreach (EkipThuThuat ekip in lstOlData)
                    {
                        bool checkExit = PhauThuatThuThuat.ListEkipThuThuat.ToList().Exists(x => x.ID == ekip.ID);
                        if (!checkExit)
                        {
                            deleteEkipThuThuatByID(MyConnection, ekip.ID);
                        }
                    }    
                }
            }
            return n > 0 ? true : false;

        }

        private static NhanVien getNhanVienFromID(decimal id)
        {
            foreach(NhanVien nv in NhanVienFunc.ListNhanVien)
            {
                if (nv.IdNhanVien == id)
                {
                    return nv;
                }
            }
            return null;

        }
        public static ObservableCollection<EkipThuThuat> getListEkipThuThuat(MDB.MDBConnection MyConnection, decimal IDPhauThuatThuThuat)
        {
            ObservableCollection<EkipThuThuat> lstData = new ObservableCollection<EkipThuThuat>();
            try
            {
                string sql = "SELECT * FROM EkipThuThuat WHERE IDPHAUTHUATTHUTHUAT = :IDPHAUTHUATTHUTHUAT ORDER BY NgayGioThucHien ASC";
                MDB.MDBCommand command = new MDB.MDBCommand(sql, MyConnection);
                command.Parameters.Add(new MDB.MDBParameter("IDPHAUTHUATTHUTHUAT", IDPhauThuatThuThuat));
                MDB.MDBDataReader dataReader = command.ExecuteReader();
                int stt = 0;
                while (dataReader.Read())
                {
                    stt++;
                    EkipThuThuat ekipThuThuat = new EkipThuThuat();
                    ekipThuThuat.Stt = stt + "";
                    ekipThuThuat.ID = dataReader.GetLong("ID");
                    ekipThuThuat.NgayGioThucHien = Convert.ToDateTime(dataReader.GetDate("NgayGioThucHien"));
                    ekipThuThuat.BacSyMa = dataReader["BacSyMa"].ToString();
                    ekipThuThuat.DieuDuongMa = dataReader["DieuDuongMa"].ToString();
                    ekipThuThuat.BacSyTxt = dataReader["BacSyTxt"].ToString();
                    ekipThuThuat.DieuDuongTxt = dataReader["DieuDuongTxt"].ToString();
                    if (string.IsNullOrEmpty(dataReader["BacSy"].ToString()))
                        ekipThuThuat.BacSy = null;
                    else
                        ekipThuThuat.BacSy = getNhanVienFromID(decimal.Parse(dataReader["BacSy"].ToString()));
                    if (string.IsNullOrEmpty(dataReader["DieuDuong"].ToString()))
                        ekipThuThuat.DieuDuong = null;
                    else
                        ekipThuThuat.DieuDuong = getNhanVienFromID(decimal.Parse(dataReader["DieuDuong"].ToString()));
                    ekipThuThuat.DienBienBenhNhanSauTT = dataReader["DienBienBenhNhanSauTT"].ToString();
                    lstData.Add(ekipThuThuat);

                }
            }
            catch (Exception ex)
            {
                XuLyLoi.Handle(ex);
            }
            return lstData;
        }
        public static List<PhauThuatThuThuat> getListPhieuThuThuat(MDB.MDBConnection MyConnection, LoaiTT loaiTT, decimal maQuanLy)
        {
            List<PhauThuatThuThuat> lstData = new List<PhauThuatThuThuat>();
            try
            {
                string sql = "SELECT * FROM PhauThuatThuThuat WHERE LOAITT = :LOAITT AND  MAQUANLY = :MAQUANLY";
                MDB.MDBCommand command = new MDB.MDBCommand(sql, MyConnection);
                command.Parameters.Add(new MDB.MDBParameter("LOAITT", (int)loaiTT));
                command.Parameters.Add(new MDB.MDBParameter("MAQUANLY", maQuanLy));
                MDB.MDBDataReader dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    PhauThuatThuThuat thuThuat = new PhauThuatThuThuat();
                    thuThuat.LoaiTT = loaiTT;
                    thuThuat.MaQuanLy = Convert.ToDecimal(dataReader.GetDecimal("MAQUANLY"));
                    thuThuat.TenPhieuTT = dataReader["TenPhieuTT"].ToString();
                    thuThuat.MaPhieuTT = dataReader["MaPhieuTT"].ToString();
                    thuThuat.MoTa = dataReader["MOTA"].ToString();
                    thuThuat.LoaiPTTT = dataReader["LoaiPTTT"].ToString();
                    thuThuat.ChanDoanChinh = dataReader["ChanDoanChinh"].ToString();
                    thuThuat.BacSyPhauThuatHoVaTen = dataReader["BacSyPhauThuatHoVaTen"].ToString();
                    thuThuat.DieuDuongNgoaiHoVaTen = dataReader["DieuDuongNgoaiHoVaTen"].ToString();
                    thuThuat.PhuongPhapVoCam = dataReader["PhuongPhapVoCam"].ToString();
                    thuThuat.IDPhauThuatThuThuat = long.Parse(dataReader["IDPHAUTHUATTHUTHUAT"].ToString());
                    thuThuat.ShowBSDD = dataReader["ShowBSDD"].ToString().Equals("1") ? true:false;
                    thuThuat.ShowSoLuong = dataReader["ShowSoLuong"].ToString().Equals("1") ? true : false;
                    int intTemp = 0;
                    thuThuat.SoLuongBacSy = int.TryParse(dataReader["SoLuongBacSy"].ToString(), out intTemp) ? (int?) intTemp : null;
                    thuThuat.SoLuongDD = int.TryParse(dataReader["SoLuongDD"].ToString(), out intTemp) ? (int?)intTemp : null;
                    thuThuat.ListEkipThuThuat = getListEkipThuThuat(MyConnection, thuThuat.IDPhauThuatThuThuat);
                    thuThuat.NgayTao = Convert.ToDateTime(dataReader["NgayTao"] == DBNull.Value ? DateTime.Now : dataReader["NgayTao"]);
                    thuThuat.NguoiTao = dataReader["NguoiTao"].ToString();
                    thuThuat.NgaySua = Convert.ToDateTime(dataReader["NgaySua"] == DBNull.Value ? DateTime.Now : dataReader["NgaySua"]);
                    thuThuat.NguoiSua = dataReader["NguoiSua"].ToString();

                    lstData.Add(thuThuat);
                }
            }
            catch (Exception ex)
            {
                XuLyLoi.Handle(ex);
            }
            return lstData;
        }
        public static bool deleteEkipThuThuatByID(MDB.MDBConnection MyConnection, long ID)
        {
            try
            {
                string sql = "DELETE FROM EkipThuThuat WHERE ID = :ID";
                MDB.MDBCommand command = new MDB.MDBCommand(sql, MyConnection);
                command.Parameters.Add(new MDB.MDBParameter("ID", ID));
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
        public static bool deleteEkipThuThuat(MDB.MDBConnection MyConnection, decimal IDPhauThuatThuThuat)
        {
            try
            {
                string sql = "DELETE FROM EkipThuThuat WHERE IDPHAUTHUATTHUTHUAT = :IDPHAUTHUATTHUTHUAT";
                MDB.MDBCommand command = new MDB.MDBCommand(sql, MyConnection);
                command.Parameters.Add(new MDB.MDBParameter("IDPHAUTHUATTHUTHUAT", IDPhauThuatThuThuat));
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
        public static PhauThuatThuThuat getPhieuThuThuatTheoLoai(MDB.MDBConnection MyConnection, LoaiTT loaiTT, decimal maQuanLy)
        {
            try
            {
                string sql = "SELECT * FROM PhauThuatThuThuat WHERE LOAITT = :LOAITT AND  MAQUANLY = :MAQUANLY";
                MDB.MDBCommand command = new MDB.MDBCommand(sql, MyConnection);
                command.Parameters.Add(new MDB.MDBParameter("LOAITT", (int)loaiTT));
                command.Parameters.Add(new MDB.MDBParameter("MAQUANLY", maQuanLy));
                MDB.MDBDataReader dataReader = command.ExecuteReader();
                PhauThuatThuThuat thuThuat = null;
                
                while (dataReader.Read())
                {
                    thuThuat = new PhauThuatThuThuat();
                    thuThuat.LoaiTT = loaiTT;
                    thuThuat.MaQuanLy = Convert.ToDecimal(dataReader.GetDecimal("MAQUANLY"));
                    thuThuat.MoTa = dataReader["MOTA"].ToString();
                    thuThuat.LoaiPTTT = dataReader["LoaiPTTT"].ToString();
                    thuThuat.BacSyPhauThuatHoVaTen = dataReader["BacSyPhauThuatHoVaTen"].ToString();
                    thuThuat.DieuDuongNgoaiHoVaTen = dataReader["DieuDuongNgoaiHoVaTen"].ToString();
                    thuThuat.PhuongPhapVoCam = dataReader["PhuongPhapVoCam"].ToString();
                    thuThuat.IDPhauThuatThuThuat = long.Parse(dataReader["IDPHAUTHUATTHUTHUAT"].ToString());
                    thuThuat.NgayTao = Convert.ToDateTime(dataReader["NgayTao"] == DBNull.Value ? DateTime.Now : dataReader["NgayTao"]);
                    thuThuat.NguoiTao = dataReader["NguoiTao"].ToString();
                    thuThuat.NgaySua = Convert.ToDateTime(dataReader["NgaySua"] == DBNull.Value ? DateTime.Now : dataReader["NgaySua"]);
                    thuThuat.NguoiSua = dataReader["NguoiSua"].ToString();
                    break;

                }
                if (thuThuat != null)
                {
                     sql = "SELECT * FROM EkipThuThuat WHERE IDPHAUTHUATTHUTHUAT = :IDPHAUTHUATTHUTHUAT";
                     command = new MDB.MDBCommand(sql, MyConnection);
                    command.Parameters.Add(new MDB.MDBParameter("IDPHAUTHUATTHUTHUAT", thuThuat.IDPhauThuatThuThuat));
                     dataReader = command.ExecuteReader();
                    thuThuat.ListEkipThuThuat = new ObservableCollection<EkipThuThuat>();
                    int stt = 0;
                    while (dataReader.Read())
                    {
                        stt++;
                        EkipThuThuat ekipThuThuat = new EkipThuThuat();
                        ekipThuThuat.Stt = stt+"";
                        ekipThuThuat.NgayGioThucHien = Convert.ToDateTime(dataReader.GetDate("NgayGioThucHien"));
                        ekipThuThuat.BacSyMa = dataReader["BacSyMa"].ToString();
                        ekipThuThuat.DieuDuongMa = dataReader["DieuDuongMa"].ToString();
                        ekipThuThuat.BacSyTxt = dataReader["BacSyTxt"].ToString();
                        ekipThuThuat.DieuDuongTxt = dataReader["DieuDuongTxt"].ToString();
                        ekipThuThuat.BacSy = getNhanVienFromID(decimal.Parse(dataReader["BacSy"].ToString()));
                        ekipThuThuat.DieuDuong = getNhanVienFromID(decimal.Parse(dataReader["DieuDuong"].ToString()));
                        ekipThuThuat.DienBienBenhNhanSauTT = dataReader["DienBienBenhNhanSauTT"].ToString();
                        thuThuat.ListEkipThuThuat.Add(ekipThuThuat);

                    }

                }
                return thuThuat;

            }
            catch (Exception ex)
            {
                XuLyLoi.Handle(ex);
            }
            return null;
        }
        public static bool insertEkipMo(MDB.MDBConnection MyConnection, EkipMo ekipMo)
        {
            string sql = @"
       INSERT INTO EKipMo  ( IDPhauThuatThuThuat, ChucVuEkip , MaNhanVien , HoTenNhanVien)
 VALUES(:IDPhauThuatThuThuat, :ChucVuEkip, :MaNhanVien, :HoTenNhanVien)";
            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
            Command.Parameters.Add(new MDB.MDBParameter("IDPhauThuatThuThuat", ekipMo.IDPhauThuatThuThuat));
            Command.Parameters.Add(new MDB.MDBParameter("ChucVuEkip", ekipMo.ChucVuEkip.ToString()));
            Command.Parameters.Add(new MDB.MDBParameter("MaNhanVien", ekipMo.MaNhanVien));
            Command.Parameters.Add(new MDB.MDBParameter("HoTenNhanVien", ekipMo.HoTenNhanVien));
            Command.BindByName = true;
            int n = Command.ExecuteNonQuery(); // C#
            return n > 0 ? true : false;
        }
        public static bool updateEkipMo(MDB.MDBConnection MyConnection, EkipMo ekipMo)
        {
            string getData = @"SELECT * FROM EKipMo 
                WHERE IDPhauThuatThuThuat = :IDPhauThuatThuThuat AND ChucVuEkip = :ChucVuEkip";
            MDB.MDBCommand Command = new MDB.MDBCommand(getData, MyConnection);
            Command.Parameters.Add(new MDB.MDBParameter("IDPhauThuatThuThuat", ekipMo.IDPhauThuatThuThuat));
            Command.Parameters.Add(new MDB.MDBParameter("ChucVuEkip", ekipMo.ChucVuEkip.ToString()));
            MDB.MDBDataReader DataReader = Command.ExecuteReader();
            ListPhauThuatThuThuat = new List<PhauThuatThuThuat>();
            bool check = false;
            while (DataReader.Read())
            {
                if(DataReader["MaNhanVien"] != null)
                {
                    check = true;
                    break;
                }
            }
            int n = 0;
            if (check) // update data
            {
                string sql = @"UPDATE EKipMo SET 
                MaNhanVien = :MaNhanVien,
                HoTenNhanVien = :HoTenNhanVien
                WHERE IDPhauThuatThuThuat = :IDPhauThuatThuThuat AND ChucVuEkip = :ChucVuEkip";
                Command = new MDB.MDBCommand(sql, MyConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MaNhanVien", ekipMo.MaNhanVien));
                Command.Parameters.Add(new MDB.MDBParameter("HoTenNhanVien", ekipMo.HoTenNhanVien));
                Command.Parameters.Add(new MDB.MDBParameter("ChucVuEkip", ekipMo.ChucVuEkip.ToString()));
                Command.Parameters.Add(new MDB.MDBParameter("IDPhauThuatThuThuat", ekipMo.IDPhauThuatThuThuat));
                Command.BindByName = true;
                n = Command.ExecuteNonQuery(); // C#
            }
            else // insert new data
            {
                return insertEkipMo(MyConnection, ekipMo);
            }
            return n > 0 ? true : false;
        }
        public static bool Update(MDB.MDBConnection MyConnection, PhauThuatThuThuat PhauThuatThuThuat)
        {
            string sql = @"UPDATE PHAUTHUATTHUTHUAT SET
            NGAYPHAUTHUATTHUTHUAT = :NGAYPHAUTHUATTHUTHUAT,
            PHUONGPHAPPHAUTHUATTHUTHUAT = :PHUONGPHAPPHAUTHUATTHUTHUAT,
            BACSYPHAUTHUAT = :BACSYPHAUTHUAT,
            BACSYGAYME = :BACSYGAYME,
            BACSYPHAUTHUATHOVATEN = :BACSYPHAUTHUATHOVATEN,
            BACSYGAYMEHOVATEN = :BACSYGAYMEHOVATEN,
            DIEUDUONGNGOAIHOVATEN = :DIEUDUONGNGOAIHOVATEN,
            PHAUTHUATKETTHUC = :PHAUTHUATKETTHUC,
            CHANDOANCHINH = :CHANDOANCHINH,
            MACHANDOANCHINH =:MACHANDOANCHINH,
            CHANDOANPHU = :CHANDOANPHU,
            MACHANDOANPHU = :MACHANDOANPHU,
            CHANDOANTRUOCPTTT = :CHANDOANTRUOCPTTT,
            MACHANDOANTRUOCPTTT = :MACHANDOANTRUOCPTTT,
            CHANDOANSAUPTTT = :CHANDOANSAUPTTT,
            MACHANDOANSAUPTTT = :MACHANDOANSAUPTTT,
            CACHTHUCPTTT = :CACHTHUCPTTT,
            NHOMMAU = :NHOMMAU,
			RH = :RH,
            LOAIPTTT = :LOAIPTTT,
            PHUONGPHAPVOCAM = :PHUONGPHAPVOCAM, 
            TINHHINHPTTT = :TINHHINHPTTT,
            TAIBIENPTTT = :TAIBIENPTTT,
            TUVONGTRONGPTTT = :TUVONGTRONGPTTT,
            MOTA = :MOTA,
            NGAYGIUONGPTTT = :NGAYGIUONGPTTT,
            LINKANHMOTA = :LINKANHMOTA,
            DANLUU = :DANLUU,
            BAC = :BAC,
            NGAYRUTCHI = :NGAYRUTCHI,
            NGAYCATCHI = :NGAYCATCHI,
            KHAC = :KHAC,
            NGAYSUA = :NGAYSUA,
            NGUOISUA = :NGUOISUA,
            Loai_VBA = :Loai_VBA 
            WHERE
	            IDPhauThuatThuThuat = " + PhauThuatThuThuat.IDPhauThuatThuThuat;
            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
            
            var Ngay = PhauThuatThuThuat.NgayPhauThuatThuThuat.Date.Add(new TimeSpan(0, 0, 0));
            PhauThuatThuThuat.NgayPhauThuatThuThuat = PhauThuatThuThuat.NgayPhauThuatThuThuat != null ? PhauThuatThuThuat.NgayPhauThuatThuThuat : Convert.ToDateTime(null);
            var Gio = PhauThuatThuThuat.NgayPhauThuatThuThuat_Gio.Value.TimeOfDay;
            var ngayPhauThuatThuThuat = Ngay + Gio;
            Command.Parameters.Add(new MDB.MDBParameter("NGAYPHAUTHUATTHUTHUAT", ngayPhauThuatThuThuat));
            Command.Parameters.Add(new MDB.MDBParameter("PHUONGPHAPPHAUTHUATTHUTHUAT", PhauThuatThuThuat.PhuongPhapPhauThuatThuThuat));
            Command.Parameters.Add(new MDB.MDBParameter("BACSYPHAUTHUAT", PhauThuatThuThuat.BacSyPhauThuat));
            Command.Parameters.Add(new MDB.MDBParameter("BACSYGAYME", PhauThuatThuThuat.BacSyGayMe));
            Command.Parameters.Add(new MDB.MDBParameter("BACSYPHAUTHUATHOVATEN", PhauThuatThuThuat.BacSyPhauThuatHoVaTen));
            Command.Parameters.Add(new MDB.MDBParameter("BACSYGAYMEHOVATEN", PhauThuatThuThuat.BacSyGayMeHoVaTen));
            Command.Parameters.Add(new MDB.MDBParameter("DIEUDUONGNGOAIHOVATEN", PhauThuatThuThuat.DieuDuongNgoaiHoVaTen));
            
            Ngay = PhauThuatThuThuat.PhauThuatKetThuc.Date.Add(new TimeSpan(0, 0, 0));
            PhauThuatThuThuat.PhauThuatKetThuc_Gio = PhauThuatThuThuat.PhauThuatKetThuc_Gio != null ? PhauThuatThuThuat.PhauThuatKetThuc_Gio : Convert.ToDateTime(null);
            Gio = PhauThuatThuThuat.PhauThuatKetThuc_Gio.Value.TimeOfDay ;
            var ketThucPhauThuatThuThuat = Ngay + Gio;
            Command.Parameters.Add(new MDB.MDBParameter("PHAUTHUATKETTHUC", ketThucPhauThuatThuThuat));
            Command.Parameters.Add(new MDB.MDBParameter("CHANDOANCHINH", PhauThuatThuThuat.ChanDoanChinh));
            Command.Parameters.Add(new MDB.MDBParameter("MACHANDOANCHINH", PhauThuatThuThuat.MaChanDoanChinh));
            Command.Parameters.Add(new MDB.MDBParameter("CHANDOANPHU", PhauThuatThuThuat.ChanDoanPhu));
            Command.Parameters.Add(new MDB.MDBParameter("MACHANDOANPHU", PhauThuatThuThuat.MaChanDoanPhu));
            Command.Parameters.Add(new MDB.MDBParameter("CHANDOANTRUOCPTTT", PhauThuatThuThuat.ChanDoanTruocPTTT));
            Command.Parameters.Add(new MDB.MDBParameter("MACHANDOANTRUOCPTTT", PhauThuatThuThuat.MaChanDoanTruocPTTT));
            Command.Parameters.Add(new MDB.MDBParameter("CHANDOANSAUPTTT", PhauThuatThuThuat.ChanDoanSauPTTT));
            Command.Parameters.Add(new MDB.MDBParameter("MACHANDOANSAUPTTT", PhauThuatThuThuat.MaChanDoanSauPTTT));
            Command.Parameters.Add(new MDB.MDBParameter("CACHTHUCPTTT", PhauThuatThuThuat.CachThucPTTT));
            Command.Parameters.Add(new MDB.MDBParameter("LOAIPTTT", PhauThuatThuThuat.LoaiPTTT));
            Command.Parameters.Add(new MDB.MDBParameter("PHUONGPHAPVOCAM", PhauThuatThuThuat.PhuongPhapVoCam));
            Command.Parameters.Add(new MDB.MDBParameter("NHOMMAU", PhauThuatThuThuat.NhomMau));
            Command.Parameters.Add(new MDB.MDBParameter("RH", PhauThuatThuThuat.RH));
            Command.Parameters.Add(new MDB.MDBParameter("TINHHINHPTTT", PhauThuatThuThuat.TinhHinhPTTT));
            Command.Parameters.Add(new MDB.MDBParameter("TAIBIENPTTT", PhauThuatThuThuat.TaiBienPTTT));
            Command.Parameters.Add(new MDB.MDBParameter("TUVONGTRONGPTTT", PhauThuatThuThuat.TuVongTrongPTTT));
            Command.Parameters.Add(new MDB.MDBParameter("MOTA", PhauThuatThuThuat.MoTa));
            Command.Parameters.Add(new MDB.MDBParameter("NGAYGIUONGPTTT", PhauThuatThuThuat.NgayGiuongPTTT));
            Command.Parameters.Add(new MDB.MDBParameter("LINKANHMOTA", PhauThuatThuThuat.LinkAnhMoTa));
            Command.Parameters.Add(new MDB.MDBParameter("DANLUU", PhauThuatThuThuat.DanLuu));
            Command.Parameters.Add(new MDB.MDBParameter("BAC", PhauThuatThuThuat.Bac));
            Command.Parameters.Add(new MDB.MDBParameter("NGAYRUTCHI", PhauThuatThuThuat.NgayRutChi));
            Command.Parameters.Add(new MDB.MDBParameter("NGAYCATCHI", PhauThuatThuThuat.NgayCatChi));
            Command.Parameters.Add(new MDB.MDBParameter("KHAC", PhauThuatThuThuat.Khac));
            Command.Parameters.Add(new MDB.MDBParameter("NGAYSUA", PhauThuatThuThuat.NgaySua));
            Command.Parameters.Add(new MDB.MDBParameter("NGUOISUA", PhauThuatThuThuat.NguoiSua));
            Command.Parameters.Add(new MDB.MDBParameter("Loai_VBA", PhauThuatThuThuat.Loai_VBA));
            Command.BindByName = true;
            int n = Command.ExecuteNonQuery(); // C#
            return n > 0 ? true : false;
        }
        public static bool DeletePhauThuatThuThuat(MDB.MDBConnection MyConnection, PhauThuatThuThuat PhauThuatThuThuat)
        {
            string sql = @"DELETE FROM PhauThuatThuThuat 
                           WHERE IDPhauThuatThuThuat = :IDPhauThuatThuThuat";
            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
            Command.Parameters.Add(new MDB.MDBParameter("IDPhauThuatThuThuat", PhauThuatThuThuat.IDPhauThuatThuThuat));

            int n = Command.ExecuteNonQuery(); // C#
            return n > 0 ? true : false;
        }
        public static bool Delete(MDB.MDBConnection _OracleConnection, PhauThuatThuThuat PhauThuatThuThuat)
        {
            try
            {
                string sql = @"DELETE PhauThuatThuThuat WHERE IDPhauThuatThuThuat = :IDPhauThuatThuThuat";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, _OracleConnection);
                Command.Parameters.Add(new MDB.MDBParameter("IDPhauThuatThuThuat", PhauThuatThuThuat.IDPhauThuatThuThuat));
                int n = Command.ExecuteNonQuery();
                return n > 0 ? true : false;
            }
            catch (Exception ex) { XuLyLoi.Handle(ex); }
            return false;
        }
        
        public static List<string> getListPTTT(MDB.MDBConnection MyConnection)
        {
            List<string> listLoaiPTTT = new List<string>();
            #region
            string sql =
                      @"select
                            (case
                             serviceprice.loaipttt
                             WHEN 1  THEN 'Phẫu thuật loại đặc biệt'
                             WHEN 2  THEN 'Phẫu thuật loại 1'
                             WHEN 3  THEN 'Phẫu thuật loại 2'
                             WHEN 4  THEN 'Phẫu thuật loại 3'
                             WHEN 5  THEN 'Thủ thuật loại đặc biệt'
                             WHEN 6  THEN 'Thủ thuật loại 1'
                             WHEN 7  THEN 'Thủ thuật loại 2'
                             WHEN 8  THEN 'Thủ thuật loại 3'
                             ELSE ''
                            END) as loaipttt
                            from serviceprice
                            join phauthuatthuthuat
                            on phauthuatthuthuat.servicepriceid = serviceprice.servicepriceid
                            where
                            phauthuatthuthuat.servicepriceid = 34226264";

            #endregion
            try
            {
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
                MDB.MDBDataReader DataReader = Command.ExecuteReader();
                ListPhauThuatThuThuat = new List<PhauThuatThuThuat>();
                while (DataReader.Read())
                {
                    listLoaiPTTT.Add(DataReader["loaipttt"].ToString());
                }
            }
            catch (Exception ex)
            {
                XuLyLoi.Handle(ex);

            }
            return listLoaiPTTT;

        }
        public static List<PhauThuatThuThuat> GetData(string MaQuanLy, MDB.MDBConnection _OracleConnection)
        {
            List<PhauThuatThuThuat> lstData = new List<PhauThuatThuThuat>();
            try
            {
                string sql = @"SELECT * FROM PHAUTHUATTHUTHUAT where MAQUANLY = :MAQUANLY AND LOAI=0";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, _OracleConnection);
                Command.Parameters.Add("MAQUANLY", MaQuanLy);
                MDB.MDBDataReader DataReader = Command.ExecuteReader();
                while (DataReader.Read())
                {
                    PhauThuatThuThuat data = new PhauThuatThuThuat();
                    data.IDPhauThuatThuThuat = DataReader.GetLong("IDPhauThuatThuThuat");
                    data.NgayTao = Convert.ToDateTime(DataReader["NgayTao"]==DBNull.Value ? DateTime.Now: DataReader["NgayTao"]);
                    data.NguoiTao = DataReader["NGUOITAO"].ToString();
                    data.CachThucPTTT = DataReader["CACHTHUCPTTT"].ToString();
                    data.PhuongPhapPhauThuatThuThuat = DataReader["PhuongPhapPhauThuatThuThuat"].ToString();
                    data.PhuongPhapVoCam = DataReader["PhuongPhapVoCam"].ToString();
                    data.NgayPhauThuatThuThuat = Convert.ToDateTime(DataReader["NgayPhauThuatThuThuat"] == DBNull.Value ? DateTime.Now : DataReader["NgayPhauThuatThuThuat"]);
                    data.NgayPhauThuatThuThuat_Gio = data.NgayPhauThuatThuThuat;
                    data.PhauThuatKetThuc = Convert.ToDateTime(DataReader["PhauThuatKetThuc"] == DBNull.Value ? DateTime.Now : DataReader["PhauThuatKetThuc"]);
                    data.MaEkipMo = DataReader["MaEkipMo"].ToString();
                    data.BacSyPhauThuat = DataReader["BacSyPhauThuat"].ToString();
                    data.BacSyGayMe = DataReader["BacSyGayMe"].ToString();
                    data.BacSyPhauThuatHoVaTen = DataReader["BacSyPhauThuatHoVaTen"].ToString();
                    data.BacSyGayMeHoVaTen = DataReader["BacSyGayMeHoVaTen"].ToString();
                    data.DieuDuongNgoaiHoVaTen = DataReader["DieuDuongNgoaiHoVaTen"].ToString();
                    data.MaChanDoanChinh = DataReader["MaChanDoanChinh"].ToString();
                    data.ChanDoanChinh = DataReader["ChanDoanChinh"].ToString();
                    data.MaChanDoanPhu = DataReader["MaChanDoanPhu"].ToString();
                    data.ChanDoanPhu = DataReader["ChanDoanPhu"].ToString();
                    data.MaChanDoanTruocPTTT = DataReader["MaChanDoanTruocPTTT"].ToString();
                    data.ChanDoanTruocPTTT = DataReader["ChanDoanTruocPTTT"].ToString();
                    data.MaChanDoanSauPTTT = DataReader["MaChanDoanSauPTTT"].ToString();
                    data.ChanDoanSauPTTT = DataReader["ChanDoanSauPTTT"].ToString();
                    data.MaCachThucPTTT = DataReader["MaCachThucPTTT"].ToString();
                    data.CachThucPTTT = DataReader["CachThucPTTT"].ToString();
                    data.NgayGiuongPTTT = DataReader["NgayGiuongPTTT"].ToString();
                    data.LoaiPTTT = DataReader["LoaiPTTT"].ToString();
                    data.PhuongPhapVoCam = DataReader["PhuongPhapVoCam"].ToString();
                    int tempInt = 0;
                    data.Loai = int.TryParse(DataReader["Loai"].ToString(), out tempInt) ? (PhanLoaiPTTT) tempInt : 0;
                    data.LoaiTT = int.TryParse(DataReader["LoaiTT"].ToString(), out tempInt) ? (LoaiTT)tempInt : 0;
                    tempInt = 0;
                    data.Loai_VBA = int.TryParse(DataReader["Loai_VBA"].ToString(), out tempInt) ? (int?) tempInt : null;
                    data.NhomMau = DataReader["NhomMau"].ToString();
                    data.RH = DataReader["RH"].ToString();
                    data.TinhHinhPTTT = DataReader["TinhHinhPTTT"].ToString();
                    data.TaiBienPTTT = DataReader["TaiBienPTTT"].ToString();
                    data.TuVongTrongPTTT = DataReader["TuVongTrongPTTT"].ToString();
                    data.MoTa = DataReader["MoTa"].ToString();
                    data.DanLuu = DataReader["DanLuu"].ToString();
                    data.Bac = DataReader["Bac"].ToString();
                    data.NgayRutChi = Convert.ToDateTime(DataReader["NgayRutChi"] == DBNull.Value ? DateTime.Now : DataReader["NgayRutChi"]);
                    data.NgayCatChi = Convert.ToDateTime(DataReader["NgayCatChi"] == DBNull.Value ? DateTime.Now : DataReader["NgayCatChi"]);
                    data.Khac = DataReader["Khac"].ToString();

                    data.NgayTao = Convert.ToDateTime(DataReader["NgayTao"] == DBNull.Value ? DateTime.Now : DataReader["NgayTao"]);
                    data.NguoiTao = DataReader["NguoiTao"].ToString();
                    data.NgaySua = Convert.ToDateTime(DataReader["NgaySua"] == DBNull.Value ? DateTime.Now : DataReader["NgaySua"]);
                    data.NguoiSua = DataReader["NguoiSua"].ToString();

                    data.ListEkipMo = getEkipMo(_OracleConnection, data.IDPhauThuatThuThuat);

                    data.Chon = false;
                    lstData.Add(data);
                }
            }
            catch (Exception ex) { XuLyLoi.Handle(ex); }
            return lstData;
        }
        public static string downloadAnhMoTa(decimal IdPhauThuatThuThuat, decimal maQuanLy)
        {
            string fullPath = "";
            try
            {
                string FileHinhAnh = @"\PTTT\" + maQuanLy;
                if (IdPhauThuatThuThuat != 0M)
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
                            string fileName = FileHinhAnh.Trim('\\') + "\\" + IdPhauThuatThuThuat + ".png";
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

        // xu dung cho PhauThuatThuThuatWindow.xaml dùng trên vỏ bệnh án
      
        public static PhauThuatThuThuat Select_VoBenhAn(MDB.MDBConnection MyConnection, decimal IDPhauThuatThuThuat)
        {
            #region
            string sql =
                      @"select * 
                        from PhauThuatThuThuat a
                        where IDPhauThuatThuThuat = :IDPhauThuatThuThuat";
            #endregion
            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
            Command.Parameters.Add(new MDB.MDBParameter("IDPhauThuatThuThuat", IDPhauThuatThuThuat));
            MDB.MDBDataReader DataReader = Command.ExecuteReader();
            PhauThuatThuThuat PhauThuatThuThuat = new PhauThuatThuThuat();

            while (DataReader.Read())
            {
                PhauThuatThuThuat.IDPhauThuatThuThuat = int.Parse(DataReader["IDPhauThuThuThuat"].ToString());
                PhauThuatThuThuat.MaQuanLy = decimal.Parse(DataReader["MaQuanLy"].ToString());
                PhauThuatThuThuat.NgayPhauThuatThuThuat = DateTime.Parse(DataReader["NgayPhauThuatThuThuat"].ToString());
                PhauThuatThuThuat.PhuongPhapPhauThuatThuThuat = DataReader["PhuongPhapPhauThuatThuThuat"].ToString();
                PhauThuatThuThuat.BacSyPhauThuat = DataReader["BacSyPhauThuat"].ToString();
                PhauThuatThuThuat.BacSyGayMe = DataReader["BacSyGayMe"].ToString();
                int tempInt = 0;
                PhauThuatThuThuat.Loai_VBA = int.TryParse(DataReader["Loai_VBA"].ToString(), out tempInt) ? (int?)tempInt : null;
            }
            return PhauThuatThuThuat;
        }

        public static bool Insert_VoBenhAn(MDB.MDBConnection MyConnection, PhauThuatThuThuat PhauThuatThuThuat)
        {
            string sql = @"
       INSERT INTO PhauThuatThuThuat ( MaQuanLy, NgayPhauThuatThuThuat, PhuongPhapPhauThuatThuThuat, PhuongPhapVoCam, BacSyPhauThuatHoVaTen, BacSyGayMeHoVaTen, Loai_VBA)
 VALUES( :MaQuanLy, :NgayPhauThuatThuThuat, :PhuongPhapPhauThuatThuThuat, :PhuongPhapVoCam, :BacSyPhauThuatHoVaTen, :BacSyGayMeHoVaTen, :Loai_VBA)           ";
            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
            Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", PhauThuatThuThuat.MaQuanLy));
            Command.Parameters.Add(new MDB.MDBParameter("NgayPhauThuatThuThuat", PhauThuatThuThuat.NgayPhauThuatThuThuat));
            Command.Parameters.Add(new MDB.MDBParameter("PhuongPhapPhauThuatThuThuat", PhauThuatThuThuat.PhuongPhapPhauThuatThuThuat));
            Command.Parameters.Add(new MDB.MDBParameter("PhuongPhapVoCam", PhauThuatThuThuat.PhuongPhapVoCam));
            Command.Parameters.Add(new MDB.MDBParameter("BacSyPhauThuatHoVaTen", PhauThuatThuThuat.BacSyPhauThuatHoVaTen));
            Command.Parameters.Add(new MDB.MDBParameter("BacSyGayMeHoVaTen", PhauThuatThuThuat.BacSyGayMeHoVaTen));
            Command.Parameters.Add(new MDB.MDBParameter("Loai_VBA", PhauThuatThuThuat.Loai_VBA));
            int n = Command.ExecuteNonQuery(); // C#
            return n > 0 ? true : false;
        }
        public static bool Update_VoBenhAn(MDB.MDBConnection MyConnection, PhauThuatThuThuat PhauThuatThuThuat)
        {
            string sql = @"UPDATE PhauThuatThuThuat SET 
MaQuanLy = :MaQuanLy,
NgayPhauThuatThuThuat = :NgayPhauThuatThuThuat,
PhuongPhapPhauThuatThuThuat = :PhuongPhapPhauThuatThuThuat,
PhuongPhapVoCam = :PhuongPhapVoCam,
BacSyPhauThuatHoVaTen = :BacSyPhauThuatHoVaTen,
BacSyGayMeHoVaTen = :BacSyGayMeHoVaTen,
Loai_VBA = :Loai_VBA

                        WHERE   IDPhauThuatThuThuat = :IDPhauThuatThuThuat";
            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
            Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", PhauThuatThuThuat.MaQuanLy));
            Command.Parameters.Add(new MDB.MDBParameter("NgayPhauThuatThuThuat", PhauThuatThuThuat.NgayPhauThuatThuThuat));
            Command.Parameters.Add(new MDB.MDBParameter("PhuongPhapPhauThuatThuThuat", PhauThuatThuThuat.PhuongPhapPhauThuatThuThuat));
            Command.Parameters.Add(new MDB.MDBParameter("PhuongPhapVoCam", PhauThuatThuThuat.PhuongPhapVoCam));
            Command.Parameters.Add(new MDB.MDBParameter("BacSyPhauThuatHoVaTen", PhauThuatThuThuat.BacSyPhauThuatHoVaTen));
            Command.Parameters.Add(new MDB.MDBParameter("BacSyGayMeHoVaTen", PhauThuatThuThuat.BacSyGayMeHoVaTen));
            Command.Parameters.Add(new MDB.MDBParameter("Loai_VBA", PhauThuatThuThuat.Loai_VBA));

            Command.Parameters.Add(new MDB.MDBParameter("IDPhauThuatThuThuat", PhauThuatThuThuat.IDPhauThuatThuThuat));
            int n = Command.ExecuteNonQuery(); // C#
            return n > 0 ? true : false;
        }
    }
}
