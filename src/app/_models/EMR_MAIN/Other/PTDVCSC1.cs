using EMR.KyDienTu;
using Newtonsoft.Json;
using PMS.Access;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace EMR_MAIN.DATABASE.Other
{
    public class PTDVCSC1_ChiTietGio
    {
        [MoTaDuLieu("Mã định danh")]
		public decimal ID;
        [MoTaDuLieu("Mã định danh")]
		public decimal ID_Phieu { get; set; }
        public int CaThu { get; set; }
        public int Gio { get; set; }
        public double? NT { get; set; }
        public double? T { get; set; }
        public double? M { get; set; }
        public double? HAMax { get; set; }
        public double? HAMin { get; set; }
        public string Fi { get; set; }
        [MoTaDuLieu("Nồng độ Oxy trong máu")]
		public string SpO2 { get; set; }
        public double? DVAn { get; set; }
        public double? DRNTieu { get; set; }
        public double? DRDaDay { get; set; }
        public double? DRPhan { get; set; }
    }
    public class PTDVCSC1 : ThongTinKy
    {
        public PTDVCSC1()
        {
            TableName = "PTDVCSC1";
            TablePrimaryKeyName = "ID";
            IDMauPhieu = (int)DanhMucPhieu.PTDVCSC1;
            TenMauPhieu = DanhMucPhieu.PTDVCSC1.Description();
            ThongTinGio_Ca1 = new ObservableCollection<PTDVCSC1_ChiTietGio>();
            ThongTinGio_Ca2 = new ObservableCollection<PTDVCSC1_ChiTietGio>();
            ThongTinGio_Ca3 = new ObservableCollection<PTDVCSC1_ChiTietGio>();
            DsDichTruyen = new ObservableCollection<DSDichTruyen>();
            ttDichTruyen_Ca1 = new ObservableCollection<ThongTinThuoc>();
            ttDichTruyen_Ca2 = new ObservableCollection<ThongTinThuoc>();
            ttDichTruyen_Ca3 = new ObservableCollection<ThongTinThuoc>();
            ttThuoc_Ca1 = new ObservableCollection<ThongTinThuoc> ();
            ttThuoc_Ca2 = new ObservableCollection<ThongTinThuoc>();
            ttThuoc_Ca3 = new ObservableCollection<ThongTinThuoc>();

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
        [MoTaDuLieu("Giường")]
		public string Giuong { get; set; }
        [MoTaDuLieu("Chẩn đoán bệnh")]
		public string ChanDoan { get; set; }
        [MoTaDuLieu("Ngày vào bệnh viện")]
		public DateTime NgayVaoVien { get; set; }
        public string CDCS { get; set; }
        public DateTime NgayCS { get; set; }
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
        public string TienSuDU { get; set; }
        public string TienSuBenh { get; set; }
        public bool[] YThucArr { set; get; } = new bool[] { false, false, false, false };
        public string YThuc
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < YThucArr.Length; i++)
                    temp += (YThucArr[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        YThucArr[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public bool[] DaArr { set; get; } = new bool[] { false, false };
        public string Da
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < DaArr.Length; i++)
                    temp += (DaArr[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        DaArr[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public string DaTxt { get; set; }
        public bool[] NiemMacArr { set; get; } = new bool[] { false, false };
        public string NiemMac
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < NiemMacArr.Length; i++)
                    temp += (NiemMacArr[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        NiemMacArr[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public string NiemMacKhac { get; set; }

        public int Phu { set; get; }
        public string PhuKhac { set; get; }
        public double CanNang { set; get; }
        public double ChieuCao { set; get; }
        public double BMI { set; get; }
        public string ThoOxy { set; get; }
        public bool[] NKQArr { set; get; } = new bool[] { false, false, false };
        public string NKQ
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < NKQArr.Length; i++)
                    temp += (NKQArr[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        NKQArr[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }

        public string ModeTho { get; set; }

        public bool[] DomArr { set; get; } = new bool[] { false, false};
        public string Dom
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < DomArr.Length; i++)
                    temp += (DomArr[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        DomArr[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public bool[] MauSacArr { set; get; } = new bool[] { false, false, false };
        public string MauSac
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < MauSacArr.Length; i++)
                    temp += (MauSacArr[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        MauSacArr[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }

        public bool[] TinhChatArr { set; get; } = new bool[] { false, false };
        public string TinhChat
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < TinhChatArr.Length; i++)
                    temp += (TinhChatArr[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        TinhChatArr[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public string TinhChatKhac { get; set; }
        public bool[] ThanKinhArr { set; get; } = new bool[] { false, false };
        public string ThanKinh
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < ThanKinhArr.Length; i++)
                    temp += (ThanKinhArr[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        ThanKinhArr[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public string ThanKinhKhac { get; set; }
        public bool[] TieuHoaArr { set; get; } = new bool[] { false, false, false };
        public string TieuHoa
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < TieuHoaArr.Length; i++)
                    temp += (TieuHoaArr[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        TieuHoaArr[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public bool[] TieuHoa2Arr { set; get; } = new bool[] { false, false, false };
        public string TieuHoa2
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < TieuHoa2Arr.Length; i++)
                    temp += (TieuHoa2Arr[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        TieuHoa2Arr[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public bool[] DaiTienArr { set; get; } = new bool[] { false, false, false };
        public string DaiTien
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < DaiTienArr.Length; i++)
                    temp += (DaiTienArr[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        DaiTienArr[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public string DauhieuBatthuong { get; set; }
        public string TuTheNguoiBenh { get; set; }
        public int HutDom { get; set; }
        public string VoRung { get; set; }
        public bool[] TTYLArr { set; get; } = new bool[] { false, false, false, false };
        public string TTYL
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < TTYLArr.Length; i++)
                    temp += (TTYLArr[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        TTYLArr[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public DateTime GiotruyenDich { get; set; }
        public DateTime GioKetThuc { get; set; }

        public int TDAT { get; set; }
        public string TDKhac { get; set; }

        public double TongDV { get; set; }
        public double TongDR { get; set; }
        public string ThayBang { get; set; }
        public bool[] KTTTArr { set; get; } = new bool[] { false, false};
        public string KTTT
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < KTTTArr.Length; i++)
                    temp += (KTTTArr[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        KTTTArr[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public string KTTTKhac { get; set; }
        public bool[] CDAArr { set; get; } = new bool[] { false, false, false, false, false };
        public string CDAA
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < CDAArr.Length; i++)
                    temp += (CDAArr[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        CDAArr[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public string CSKhacTDTuThe { get; set; }
        public int CSKhacPhongLoet { get; set; }
        public bool[] VSCaNhanArr { set; get; } = new bool[] { false, false, false, false, false };
        public string VSCaNhan
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < VSCaNhanArr.Length; i++)
                    temp += (VSCaNhanArr[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        VSCaNhanArr[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public int VSCaNhanThayDo { get; set; }
        public string VSCaNhanKhac { get; set; }
        public string CacChamSocKhac { get; set; }
        public ObservableCollection<PTDVCSC1_ChiTietGio> ThongTinGio_Ca1 { get; set; }
        public ObservableCollection<PTDVCSC1_ChiTietGio> ThongTinGio_Ca2 { get; set; }
        public ObservableCollection<PTDVCSC1_ChiTietGio> ThongTinGio_Ca3 { get; set; }
        public ObservableCollection<DSDichTruyen> DsDichTruyen { get; set; }
        public ObservableCollection<ThongTinThuoc> ttDichTruyen_Ca1 { get; set; }
        public ObservableCollection<ThongTinThuoc> ttDichTruyen_Ca2 { get; set; }
        public ObservableCollection<ThongTinThuoc> ttDichTruyen_Ca3 { get; set; }
        public ObservableCollection<DSDichTruyen> DsThuoc { get; set; }
        public ObservableCollection<ThongTinThuoc> ttThuoc_Ca1 { get; set; }
        public ObservableCollection<ThongTinThuoc> ttThuoc_Ca2 { get; set; }
        public ObservableCollection<ThongTinThuoc> ttThuoc_Ca3 { get; set; }
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
    public class PTDVCSC1Func
    {
        public const string TableName = "PTDVCSC1";
        public const string TablePrimaryKeyName = "ID";
        public static PTDVCSC1 GetData(MDB.MDBConnection _OracleConnection, decimal maquanly , decimal ID)
        {
            PTDVCSC1 data = new PTDVCSC1();
            try
            {
                string sql = @"SELECT *
                FROM PTDVCSC1 
                where ID =:ID And MaQuanLy = :MaQuanLy";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, _OracleConnection);
                Command.Parameters.Add(new MDB.MDBParameter("ID", ID));
                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", maquanly));
                MDB.MDBDataReader DataReader = Command.ExecuteReader();
                while (DataReader.Read())
                {
                    PTDVCSC1 obj = new PTDVCSC1();
                    obj.ID = Common.ConDB_Decimal(DataReader["ID"]);
                    obj.MaQuanLy = Common.ConDB_Decimal(DataReader["MaQuanLy"]);
                    obj.MaBenhNhan = Common.ConDBNull(DataReader["MaBenhNhan"]);
                    obj.TenBenhNhan = Common.ConDBNull(DataReader["TenBenhNhan"]);
                    obj.Tuoi = Common.ConDBNull(DataReader["Tuoi"]);
                    obj.GioiTinh = Common.ConDBNull(DataReader["GioiTinh"]);
                    obj.SoBenhAn = Common.ConDBNull(DataReader["SoBenhAn"]);
                    obj.Khoa = Common.ConDBNull(DataReader["Khoa"]);
                    obj.MaKhoa = Common.ConDBNull(DataReader["MaKhoa"]);
                    obj.Giuong = Common.ConDBNull(DataReader["Giuong"]);
                    obj.ChanDoan = Common.ConDBNull(DataReader["ChanDoan"]);
                    obj.NgayVaoVien = Common.ConDB_DateTime(DataReader["NgayVaoVien"]);
                    obj.CDCS = Common.ConDBNull(DataReader["CDCS"]);
                    obj.NgayCS = Common.ConDB_DateTime(DataReader["NgayCS"]);
                    obj.DieuDuongCa1 = Common.ConDBNull(DataReader["DieuDuongCa1"]);
                    obj.MaDieuDuongCa1 = Common.ConDBNull(DataReader["MaDieuDuongCa1"]);
                    obj.DieuDuongCa2 = Common.ConDBNull(DataReader["DieuDuongCa2"]);
                    obj.MaDieuDuongCa2 = Common.ConDBNull(DataReader["MaDieuDuongCa2"]);
                    obj.DieuDuongCa3 = Common.ConDBNull(DataReader["DieuDuongCa3"]);
                    obj.MaDieuDuongCa3 = Common.ConDBNull(DataReader["MaDieuDuongCa3"]);
                    obj.TienSuDU = Common.ConDBNull(DataReader["TienSuDU"]);
                    obj.TienSuBenh = Common.ConDBNull(DataReader["TienSuBenh"]);
                    obj.YThuc = Common.ConDBNull(DataReader["YThuc"]);
                    obj.Da = Common.ConDBNull(DataReader["Da"]);
                    obj.DaTxt = Common.ConDBNull(DataReader["DaTxt"]);
                    obj.NiemMac = Common.ConDBNull(DataReader["NiemMac"]);
                    obj.NiemMacKhac = Common.ConDBNull(DataReader["NiemMacKhac"]);
                    obj.Phu = Common.ConDB_Int(DataReader["Phu"]);
                    obj.PhuKhac = Common.ConDBNull(DataReader["PhuKhac"]);
                    obj.CanNang = Common.ConDB_float(DataReader["CanNang"]);
                    obj.ChieuCao = Common.ConDB_float(DataReader["ChieuCao"]);
                    obj.BMI = Common.ConDB_float(DataReader["BMI"]);
                    obj.ThoOxy = Common.ConDBNull(DataReader["ThoOxy"]);
                    obj.NKQ = Common.ConDBNull(DataReader["NKQ"]);
                    obj.ModeTho = Common.ConDBNull(DataReader["ModeTho"]);
                    obj.Dom = Common.ConDBNull(DataReader["Dom"]);
                    obj.MauSac = Common.ConDBNull(DataReader["MauSac"]);
                    obj.TinhChat = Common.ConDBNull(DataReader["TinhChat"]);
                    obj.TinhChatKhac = Common.ConDBNull(DataReader["TinhChatKhac"]);
                    obj.ThanKinh = Common.ConDBNull(DataReader["ThanKinh"]);
                    obj.ThanKinhKhac = Common.ConDBNull(DataReader["ThanKinhKhac"]);
                    obj.TieuHoa = Common.ConDBNull(DataReader["TieuHoa"]);
                    obj.TieuHoa2 = Common.ConDBNull(DataReader["TieuHoa2"]);
                    obj.DaiTien = Common.ConDBNull(DataReader["DaiTien"]);
                    obj.DauhieuBatthuong = Common.ConDBNull(DataReader["DauhieuBatthuong"]);
                    obj.TuTheNguoiBenh = Common.ConDBNull(DataReader["TuTheNguoiBenh"]);
                    obj.HutDom = Common.ConDB_Int(DataReader["HutDom"]);
                    obj.VoRung = Common.ConDBNull(DataReader["VoRung"]);
                    obj.TTYL = Common.ConDBNull(DataReader["TTYL"]);
                    obj.GiotruyenDich = Common.ConDB_DateTime(DataReader["GiotruyenDich"]);
                    obj.GioKetThuc = Common.ConDB_DateTime(DataReader["GioKetThuc"]);
                    obj.TDAT = Common.ConDB_Int(DataReader["TDAT"]);
                    obj.TDKhac = Common.ConDBNull(DataReader["TDKhac"]);
                    obj.TongDV = Common.ConDB_float(DataReader["TongDV"]);
                    obj.TongDR = Common.ConDB_float(DataReader["TongDR"]);
                    obj.ThayBang = Common.ConDBNull(DataReader["ThayBang"]);
                    obj.KTTT = Common.ConDBNull(DataReader["KTTT"]);
                    obj.KTTTKhac = Common.ConDBNull(DataReader["KTTTKhac"]);
                    obj.CDAA = Common.ConDBNull(DataReader["CDAA"]);
                    obj.CSKhacTDTuThe = Common.ConDBNull(DataReader["CSKhacTDTuThe"]);
                    obj.CSKhacPhongLoet = Common.ConDB_Int(DataReader["CSKhacPhongLoet"]);
                    obj.VSCaNhan = Common.ConDBNull(DataReader["VSCaNhan"]);
                    obj.VSCaNhanThayDo = Common.ConDB_Int(DataReader["VSCaNhanThayDo"]);
                    obj.VSCaNhanKhac = Common.ConDBNull(DataReader["VSCaNhanKhac"]);
                    obj.CacChamSocKhac = Common.ConDBNull(DataReader["CacChamSocKhac"]);
                    obj.DsDichTruyen = JsonConvert.DeserializeObject<ObservableCollection<DSDichTruyen>>(Common.ConDBNull(DataReader["DsDichTruyen"]));
                    obj.ttDichTruyen_Ca1 = JsonConvert.DeserializeObject<ObservableCollection<ThongTinThuoc>>(Common.ConDBNull(DataReader["ttDichTruyen_Ca1"]));
                    obj.ttDichTruyen_Ca2 = JsonConvert.DeserializeObject<ObservableCollection<ThongTinThuoc>>(Common.ConDBNull(DataReader["ttDichTruyen_Ca2"]));
                    obj.ttDichTruyen_Ca3 = JsonConvert.DeserializeObject<ObservableCollection<ThongTinThuoc>>(Common.ConDBNull(DataReader["ttDichTruyen_Ca3"]));
                    obj.DsThuoc = JsonConvert.DeserializeObject<ObservableCollection<DSDichTruyen>>(Common.ConDBNull(DataReader["DsThuoc"]));
                    obj.ttThuoc_Ca1 = JsonConvert.DeserializeObject<ObservableCollection<ThongTinThuoc>>(Common.ConDBNull(DataReader["ttThuoc_Ca1"]));
                    obj.ttThuoc_Ca2 = JsonConvert.DeserializeObject<ObservableCollection<ThongTinThuoc>>(Common.ConDBNull(DataReader["ttThuoc_Ca2"]));
                    obj.ttThuoc_Ca3 = JsonConvert.DeserializeObject<ObservableCollection<ThongTinThuoc>>(Common.ConDBNull(DataReader["ttThuoc_Ca3"]));
                    obj.NgayTao = Common.ConDB_DateTime(DataReader["NgayTao"]);
                    obj.NguoiTao = Common.ConDBNull(DataReader["NguoiTao"]);
                    obj.NgaySua = Common.ConDB_DateTime(DataReader["NgaySua"]);
                    obj.NguoiSua = Common.ConDBNull(DataReader["NguoiSua"]);    
                    obj.ComputerKyTen = Common.ConDBNull(DataReader["ComputerKyTen"]);
                    obj.MaSoKy = Common.ConDBNull(DataReader["MaSoKy"]);
                    obj.TenFileKy = Common.ConDBNull(DataReader["TenFileKy"]);
                    obj.UserNameKy = Common.ConDBNull(DataReader["UserNameKy"]);
                    obj.ThongTinGio_Ca1 = getThongTinTheoDoiGio(_OracleConnection, obj.ID, 1);
                    obj.ThongTinGio_Ca2 = getThongTinTheoDoiGio(_OracleConnection, obj.ID, 2);
                    obj.ThongTinGio_Ca3 = getThongTinTheoDoiGio(_OracleConnection, obj.ID, 3);
                    obj.NgayKy = Common.ConDB_DateTime(DataReader["ngayky"]);
                    obj.MaSoKy = DataReader["masokyten"].ToString();
                    obj.DaKy = !string.IsNullOrEmpty(obj.MaSoKy) ? true : false;
                    data = obj;
                }
            }
            catch (Exception ex) { throw ex; }
            return data;
        }
        public static List<PTDVCSC1> GetListData(MDB.MDBConnection _OracleConnection, decimal maquanly)
        {
            List<PTDVCSC1> list = new List<PTDVCSC1>();
            try
            {
                string sql = @"SELECT * FROM PTDVCSC1 where MaQuanLy = :MaQuanLy";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, _OracleConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", maquanly));
                MDB.MDBDataReader DataReader = Command.ExecuteReader();
                while (DataReader.Read())
                {
                    PTDVCSC1 obj = new PTDVCSC1();
                    obj.ID = Common.ConDB_Decimal(DataReader["ID"]);
                    obj.MaQuanLy = Common.ConDB_Decimal(DataReader["MaQuanLy"]);
                    obj.MaBenhNhan = Common.ConDBNull(DataReader["MaBenhNhan"]);
                    obj.TenBenhNhan = Common.ConDBNull(DataReader["TenBenhNhan"]);
                    obj.Tuoi = Common.ConDBNull(DataReader["Tuoi"]);
                    obj.GioiTinh = Common.ConDBNull(DataReader["GioiTinh"]);
                    obj.SoBenhAn = Common.ConDBNull(DataReader["SoBenhAn"]);
                    obj.Khoa = Common.ConDBNull(DataReader["Khoa"]);
                    obj.MaKhoa = Common.ConDBNull(DataReader["MaKhoa"]);
                    obj.Giuong = Common.ConDBNull(DataReader["Giuong"]);
                    obj.ChanDoan = Common.ConDBNull(DataReader["ChanDoan"]);
                    obj.NgayVaoVien = Common.ConDB_DateTime(DataReader["NgayVaoVien"]);
                    obj.CDCS = Common.ConDBNull(DataReader["CDCS"]);
                    obj.NgayCS = Common.ConDB_DateTime(DataReader["NgayCS"]);
                    obj.DieuDuongCa1 = Common.ConDBNull(DataReader["DieuDuongCa1"]);
                    obj.MaDieuDuongCa1 = Common.ConDBNull(DataReader["MaDieuDuongCa1"]);
                    obj.DieuDuongCa2 = Common.ConDBNull(DataReader["DieuDuongCa2"]);
                    obj.MaDieuDuongCa2 = Common.ConDBNull(DataReader["MaDieuDuongCa2"]);
                    obj.DieuDuongCa3 = Common.ConDBNull(DataReader["DieuDuongCa3"]);
                    obj.MaDieuDuongCa3 = Common.ConDBNull(DataReader["MaDieuDuongCa3"]);
                    obj.TienSuDU = Common.ConDBNull(DataReader["TienSuDU"]);
                    obj.TienSuBenh = Common.ConDBNull(DataReader["TienSuBenh"]);
                    obj.YThuc = Common.ConDBNull(DataReader["YThuc"]);
                    obj.Da = Common.ConDBNull(DataReader["Da"]);
                    obj.DaTxt = Common.ConDBNull(DataReader["DaTxt"]);
                    obj.NiemMac = Common.ConDBNull(DataReader["NiemMac"]);
                    obj.NiemMacKhac = Common.ConDBNull(DataReader["NiemMacKhac"]);
                    obj.Phu = Common.ConDB_Int(DataReader["Phu"]);
                    obj.PhuKhac = Common.ConDBNull(DataReader["PhuKhac"]);
                    obj.CanNang = Common.ConDB_float(DataReader["CanNang"]);
                    obj.ChieuCao = Common.ConDB_float(DataReader["ChieuCao"]);
                    obj.BMI = Common.ConDB_float(DataReader["BMI"]);
                    obj.ThoOxy = Common.ConDBNull(DataReader["ThoOxy"]);
                    obj.NKQ = Common.ConDBNull(DataReader["NKQ"]);
                    obj.ModeTho = Common.ConDBNull(DataReader["ModeTho"]);
                    obj.Dom = Common.ConDBNull(DataReader["Dom"]);
                    obj.MauSac = Common.ConDBNull(DataReader["MauSac"]);
                    obj.TinhChat = Common.ConDBNull(DataReader["TinhChat"]);
                    obj.TinhChatKhac = Common.ConDBNull(DataReader["TinhChatKhac"]);
                    obj.ThanKinh = Common.ConDBNull(DataReader["ThanKinh"]);
                    obj.ThanKinhKhac = Common.ConDBNull(DataReader["ThanKinhKhac"]);
                    obj.TieuHoa = Common.ConDBNull(DataReader["TieuHoa"]);
                    obj.TieuHoa2 = Common.ConDBNull(DataReader["TieuHoa2"]);
                    obj.DaiTien = Common.ConDBNull(DataReader["DaiTien"]);
                    obj.DauhieuBatthuong = Common.ConDBNull(DataReader["DauhieuBatthuong"]);
                    obj.TuTheNguoiBenh = Common.ConDBNull(DataReader["TuTheNguoiBenh"]);
                    obj.HutDom = Common.ConDB_Int(DataReader["HutDom"]);
                    obj.VoRung = Common.ConDBNull(DataReader["VoRung"]);
                    obj.TTYL = Common.ConDBNull(DataReader["TTYL"]);
                    obj.GiotruyenDich = Common.ConDB_DateTime(DataReader["GiotruyenDich"]);
                    obj.GioKetThuc = Common.ConDB_DateTime(DataReader["GioKetThuc"]);
                    obj.TDAT = Common.ConDB_Int(DataReader["TDAT"]);
                    obj.TDKhac = Common.ConDBNull(DataReader["TDKhac"]);
                    obj.TongDV = Common.ConDB_float(DataReader["TongDV"]);
                    obj.TongDR = Common.ConDB_float(DataReader["TongDR"]);
                    obj.ThayBang = Common.ConDBNull(DataReader["ThayBang"]);
                    obj.KTTT = Common.ConDBNull(DataReader["KTTT"]);
                    obj.KTTTKhac = Common.ConDBNull(DataReader["KTTTKhac"]);
                    obj.CDAA = Common.ConDBNull(DataReader["CDAA"]);
                    obj.CSKhacTDTuThe = Common.ConDBNull(DataReader["CSKhacTDTuThe"]);
                    obj.CSKhacPhongLoet = Common.ConDB_Int(DataReader["CSKhacPhongLoet"]);
                    obj.VSCaNhan = Common.ConDBNull(DataReader["VSCaNhan"]);
                    obj.VSCaNhanThayDo = Common.ConDB_Int(DataReader["VSCaNhanThayDo"]);
                    obj.VSCaNhanKhac = Common.ConDBNull(DataReader["VSCaNhanKhac"]);
                    obj.CacChamSocKhac = Common.ConDBNull(DataReader["CacChamSocKhac"]);
                    obj.DsDichTruyen = JsonConvert.DeserializeObject<ObservableCollection<DSDichTruyen>>(Common.ConDBNull(DataReader["DsDichTruyen"]));
                    obj.ttDichTruyen_Ca1 = JsonConvert.DeserializeObject<ObservableCollection<ThongTinThuoc>>(Common.ConDBNull(DataReader["ttDichTruyen_Ca1"]));
                    obj.ttDichTruyen_Ca2 = JsonConvert.DeserializeObject<ObservableCollection<ThongTinThuoc>>(Common.ConDBNull(DataReader["ttDichTruyen_Ca2"]));
                    obj.ttDichTruyen_Ca3 = JsonConvert.DeserializeObject<ObservableCollection<ThongTinThuoc>>(Common.ConDBNull(DataReader["ttDichTruyen_Ca3"]));
                    obj.DsThuoc = JsonConvert.DeserializeObject<ObservableCollection<DSDichTruyen>>(Common.ConDBNull(DataReader["DsThuoc"]));
                    obj.ttThuoc_Ca1 = JsonConvert.DeserializeObject<ObservableCollection<ThongTinThuoc>>(Common.ConDBNull(DataReader["ttThuoc_Ca1"]));
                    obj.ttThuoc_Ca2 = JsonConvert.DeserializeObject<ObservableCollection<ThongTinThuoc>>(Common.ConDBNull(DataReader["ttThuoc_Ca2"]));
                    obj.ttThuoc_Ca3 = JsonConvert.DeserializeObject<ObservableCollection<ThongTinThuoc>>(Common.ConDBNull(DataReader["ttThuoc_Ca3"]));
                    obj.NgayTao = Common.ConDB_DateTime(DataReader["NgayTao"]);
                    obj.NguoiTao = Common.ConDBNull(DataReader["NguoiTao"]);
                    obj.NgaySua = Common.ConDB_DateTime(DataReader["NgaySua"]);
                    obj.NguoiSua = Common.ConDBNull(DataReader["NguoiSua"]);
                    obj.ComputerKyTen = Common.ConDBNull(DataReader["ComputerKyTen"]);
                    obj.MaSoKy = Common.ConDBNull(DataReader["MaSoKy"]);
                    obj.TenFileKy = Common.ConDBNull(DataReader["TenFileKy"]);
                    obj.UserNameKy = Common.ConDBNull(DataReader["UserNameKy"]);
                    obj.ThongTinGio_Ca1 = getThongTinTheoDoiGio(_OracleConnection, obj.ID, 1);
                    obj.ThongTinGio_Ca2 = getThongTinTheoDoiGio(_OracleConnection, obj.ID, 2);
                    obj.ThongTinGio_Ca3 = getThongTinTheoDoiGio(_OracleConnection, obj.ID, 3);
                    obj.NgayKy = Common.ConDB_DateTime(DataReader["ngayky"]);
                    obj.MaSoKy = DataReader["masokyten"].ToString();
                    obj.DaKy = !string.IsNullOrEmpty(obj.MaSoKy) ? true : false;
                    list.Add(obj);
                }
            }
            catch (Exception ex) { XuLyLoi.Handle(ex); }
            return list;
        }
        public static ObservableCollection<PTDVCSC1_ChiTietGio> getThongTinTheoDoiGio(MDB.MDBConnection _OracleConnection, decimal idPhieu, int caThu)
        {
            ObservableCollection<PTDVCSC1_ChiTietGio> ThongTinTheoDoiGios = new ObservableCollection<PTDVCSC1_ChiTietGio>();
            try
            {
                string sql = @"SELECT * FROM PTDVCSC1_ChiTietGio where ID_Phieu = :ID_Phieu and CaThu= :CaThu  ORDER BY ID asc";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, _OracleConnection);
                Command.Parameters.Add(new MDB.MDBParameter("ID_Phieu", idPhieu));
                Command.Parameters.Add(new MDB.MDBParameter("CaThu", caThu));
                MDB.MDBDataReader DataReader = Command.ExecuteReader();
                while (DataReader.Read())
                {
                    PTDVCSC1_ChiTietGio obj = new PTDVCSC1_ChiTietGio();
                    obj.ID = Common.ConDB_Decimal(DataReader["ID"]);
                    obj.ID_Phieu = Common.ConDB_Decimal(DataReader["ID_Phieu"]);
                    obj.CaThu = Common.ConDB_Int(DataReader["CaThu"]);
                    obj.Gio = Common.ConDB_Int(DataReader["Gio"]);
                    obj.NT = Common.ConDBNull_float(DataReader["NT"]);
                    obj.T = Common.ConDBNull_float(DataReader["T"]);
                    obj.M = Common.ConDBNull_float(DataReader["M"]);
                    obj.HAMax = Common.ConDBNull_float(DataReader["HAMax"]);
                    obj.HAMin = Common.ConDBNull_float(DataReader["HAMin"]);
                    obj.Fi = Common.ConDBNull(DataReader["Fi"]);
                    obj.SpO2 = Common.ConDBNull(DataReader["SpO2"]);
                    obj.DVAn = Common.ConDBNull_float(DataReader["DVAn"]);
                    obj.DRNTieu = Common.ConDBNull_float(DataReader["DRNTieu"]);
                    obj.DRDaDay = Common.ConDBNull_float(DataReader["DRDaDay"]);
                    obj.DRPhan = Common.ConDBNull_float(DataReader["DRPhan"]);
                    ThongTinTheoDoiGios.Add(obj);
                }
            }
            catch (Exception ex) { XuLyLoi.Handle(ex); }
            return ThongTinTheoDoiGios;
        }
        public static bool InsertOrUpdatePhieu(MDB.MDBConnection MyConnection, ref PTDVCSC1 obj)
        {
            try
            {
                string sql = @"INSERT INTO PTDVCSC1
                (
                    MaQuanLy,
                    MaBenhNhan,
                    TenBenhNhan,
                    Tuoi,
                    GioiTinh,
                    SoBenhAn,
                    Khoa,
                    MaKhoa,
                    Giuong,
                    ChanDoan,
                    NgayVaoVien,
                    CDCS,
                    NgayCS,
                    DieuDuongCa1,
                    MaDieuDuongCa1,
                    DieuDuongCa2,
                    MaDieuDuongCa2,
                    DieuDuongCa3,
                    MaDieuDuongCa3,
                    TienSuDU,
                    TienSuBenh,
                    YThuc,
                    Da,
                    DaTxt,
                    NiemMac,
                    NiemMacKhac,
                    Phu,
                    PhuKhac,
                    CanNang,
                    ChieuCao,
                    BMI,
                    ThoOxy,
                    NKQ,
                    ModeTho,
                    Dom,
                    MauSac,
                    TinhChat,
                    TinhChatKhac,
                    ThanKinh,
                    ThanKinhKhac,
                    TieuHoa,
                    TieuHoa2,
                    DaiTien,
                    DauhieuBatthuong,
                    TuTheNguoiBenh,
                    HutDom,
                    VoRung,
                    TTYL,
                    GiotruyenDich,
                    GioKetThuc,
                    TDAT,
                    TDKhac,
                    TongDV,
                    TongDR,
                    ThayBang,
                    KTTT,
                    KTTTKhac,
                    CDAA,
                    CSKhacTDTuThe,
                    CSKhacPhongLoet,
                    VSCaNhan,
                    VSCaNhanThayDo,
                    VSCaNhanKhac,
                    CacChamSocKhac,
                    DsDichTruyen,
                    ttDichTruyen_Ca1,
                    ttDichTruyen_Ca2,
                    ttDichTruyen_Ca3,
                    DsThuoc,
                    ttThuoc_Ca1,
                    ttThuoc_Ca2,
                    ttThuoc_Ca3,
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
                    :Giuong,
                    :ChanDoan,
                    :NgayVaoVien,
                    :CDCS,
                    :NgayCS,
                    :DieuDuongCa1,
                    :MaDieuDuongCa1,
                    :DieuDuongCa2,
                    :MaDieuDuongCa2,
                    :DieuDuongCa3,
                    :MaDieuDuongCa3,
                    :TienSuDU,
                    :TienSuBenh,
                    :YThuc,
                    :Da,
                    :DaTxt,
                    :NiemMac,
                    :NiemMacKhac,
                    :Phu,
                    :PhuKhac,
                    :CanNang,
                    :ChieuCao,
                    :BMI,
                    :ThoOxy,
                    :NKQ,
                    :ModeTho,
                    :Dom,
                    :MauSac,
                    :TinhChat,
                    :TinhChatKhac,
                    :ThanKinh,
                    :ThanKinhKhac,
                    :TieuHoa,
                    :TieuHoa2,
                    :DaiTien,
                    :DauhieuBatthuong,
                    :TuTheNguoiBenh,
                    :HutDom,
                    :VoRung,
                    :TTYL,
                    :GiotruyenDich,
                    :GioKetThuc,
                    :TDAT,
                    :TDKhac,
                    :TongDV,
                    :TongDR,
                    :ThayBang,
                    :KTTT,
                    :KTTTKhac,
                    :CDAA,
                    :CSKhacTDTuThe,
                    :CSKhacPhongLoet,
                    :VSCaNhan,
                    :VSCaNhanThayDo,
                    :VSCaNhanKhac,
                    :CacChamSocKhac,
                    :DsDichTruyen,
                    :ttDichTruyen_Ca1,
                    :ttDichTruyen_Ca2,
                    :ttDichTruyen_Ca3,
                    :DsThuoc,
                    :ttThuoc_Ca1,
                    :ttThuoc_Ca2,
                    :ttThuoc_Ca3,
                    :NgayTao,
                    :NguoiTao,
                    :NgaySua,
                    :NguoiSua
                   )  RETURNING ID INTO :ID";
                if (obj.ID != 0)
                {
                    sql = @"UPDATE PTDVCSC1 SET 
                            MaQuanLy=:MaQuanLy,
                            MaBenhNhan=:MaBenhNhan,
                            TenBenhNhan=:TenBenhNhan,
                            Tuoi=:Tuoi,
                            GioiTinh=:GioiTinh,
                            SoBenhAn=:SoBenhAn,
                            Khoa=:Khoa,
                            MaKhoa=:MaKhoa,
                            Giuong=:Giuong,
                            ChanDoan=:ChanDoan,
                            NgayVaoVien=:NgayVaoVien,
                            CDCS=:CDCS,
                            NgayCS=:NgayCS,
                            DieuDuongCa1=:DieuDuongCa1,
                            MaDieuDuongCa1=:MaDieuDuongCa1,
                            DieuDuongCa2=:DieuDuongCa2,
                            MaDieuDuongCa2=:MaDieuDuongCa2,
                            DieuDuongCa3=:DieuDuongCa3,
                            MaDieuDuongCa3=:MaDieuDuongCa3,
                            TienSuDU=:TienSuDU,
                            TienSuBenh=:TienSuBenh,
                            YThuc=:YThuc,
                            Da=:Da,
                            DaTxt=:DaTxt,
                            NiemMac=:NiemMac,
                            NiemMacKhac=:NiemMacKhac,
                            Phu=:Phu,
                            PhuKhac=:PhuKhac,
                            CanNang=:CanNang,
                            ChieuCao=:ChieuCao,
                            BMI=:BMI,
                            ThoOxy=:ThoOxy,
                            NKQ=:NKQ,
                            ModeTho=:ModeTho,
                            Dom=:Dom,
                            MauSac=:MauSac,
                            TinhChat=:TinhChat,
                            TinhChatKhac=:TinhChatKhac,
                            ThanKinh=:ThanKinh,
                            ThanKinhKhac=:ThanKinhKhac,
                            TieuHoa=:TieuHoa,
                            TieuHoa2=:TieuHoa2,
                            DaiTien=:DaiTien,
                            DauhieuBatthuong=:DauhieuBatthuong,
                            TuTheNguoiBenh=:TuTheNguoiBenh,
                            HutDom=:HutDom,
                            VoRung=:VoRung,
                            TTYL=:TTYL,
                            GiotruyenDich=:GiotruyenDich,
                            GioKetThuc=:GioKetThuc,
                            TDAT=:TDAT,
                            TDKhac=:TDKhac,
                            TongDV=:TongDV,
                            TongDR=:TongDR,
                            ThayBang=:ThayBang,
                            KTTT=:KTTT,
                            KTTTKhac=:KTTTKhac,
                            CDAA=:CDAA,
                            CSKhacTDTuThe=:CSKhacTDTuThe,
                            CSKhacPhongLoet=:CSKhacPhongLoet,
                            VSCaNhan=:VSCaNhan,
                            VSCaNhanThayDo=:VSCaNhanThayDo,
                            VSCaNhanKhac=:VSCaNhanKhac,
                            CacChamSocKhac=:CacChamSocKhac,
                            DsDichTruyen=:DsDichTruyen,
                            ttDichTruyen_Ca1=:ttDichTruyen_Ca1,
                            ttDichTruyen_Ca2=:ttDichTruyen_Ca2,
                            ttDichTruyen_Ca3=:ttDichTruyen_Ca3,
                            DsThuoc=:DsThuoc,
                            ttThuoc_Ca1=:ttThuoc_Ca1,
                            ttThuoc_Ca2=:ttThuoc_Ca2,
                            ttThuoc_Ca3=:ttThuoc_Ca3,
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
                oracleCommand.Parameters.Add(new MDB.MDBParameter("Giuong", obj.Giuong));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("ChanDoan", obj.ChanDoan));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("NgayVaoVien", obj.NgayVaoVien));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("CDCS", obj.CDCS));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("NgayCS", obj.NgayCS));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("DieuDuongCa1", obj.DieuDuongCa1));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("MaDieuDuongCa1", obj.MaDieuDuongCa1));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("DieuDuongCa2", obj.DieuDuongCa2));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("MaDieuDuongCa2", obj.MaDieuDuongCa2));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("DieuDuongCa3", obj.DieuDuongCa3));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("MaDieuDuongCa3", obj.MaDieuDuongCa3));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("TienSuDU", obj.TienSuDU));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("TienSuBenh", obj.TienSuBenh));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("YThuc", obj.YThuc));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("Da", obj.Da));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("DaTxt", obj.DaTxt));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("NiemMac", obj.NiemMac));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("NiemMacKhac", obj.NiemMacKhac));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("Phu", obj.Phu));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("PhuKhac", obj.PhuKhac));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("CanNang", obj.CanNang));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("ChieuCao", obj.ChieuCao));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("BMI", obj.BMI));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("ThoOxy", obj.ThoOxy));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("NKQ", obj.NKQ));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("ModeTho", obj.ModeTho));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("Dom", obj.Dom));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("MauSac", obj.MauSac));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("TinhChat", obj.TinhChat));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("TinhChatKhac", obj.TinhChatKhac));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("ThanKinh", obj.ThanKinh));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("ThanKinhKhac", obj.ThanKinhKhac));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("TieuHoa", obj.TieuHoa));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("TieuHoa2", obj.TieuHoa2));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("DaiTien", obj.DaiTien));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("DauhieuBatthuong", obj.DauhieuBatthuong));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("TuTheNguoiBenh", obj.TuTheNguoiBenh));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("HutDom", obj.HutDom));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("VoRung", obj.VoRung));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("TTYL", obj.TTYL));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("GiotruyenDich", obj.GiotruyenDich));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("GioKetThuc", obj.GioKetThuc));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("TDAT", obj.TDAT));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("TDKhac", obj.TDKhac));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("TongDV", obj.TongDV));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("TongDR", obj.TongDR));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("ThayBang", obj.ThayBang));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("KTTT", obj.KTTT));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("KTTTKhac", obj.KTTTKhac));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("CDAA", obj.CDAA));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("CSKhacTDTuThe", obj.CSKhacTDTuThe));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("CSKhacPhongLoet", obj.CSKhacPhongLoet));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("VSCaNhan", obj.VSCaNhan));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("VSCaNhanThayDo", obj.VSCaNhanThayDo));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("VSCaNhanKhac", obj.VSCaNhanKhac));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("CacChamSocKhac", obj.CacChamSocKhac));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("DsDichTruyen", JsonConvert.SerializeObject(obj.DsDichTruyen)));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("ttDichTruyen_Ca1", JsonConvert.SerializeObject(obj.ttDichTruyen_Ca1)));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("ttDichTruyen_Ca2", JsonConvert.SerializeObject(obj.ttDichTruyen_Ca2)));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("ttDichTruyen_Ca3", JsonConvert.SerializeObject(obj.ttDichTruyen_Ca3)));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("DsThuoc", JsonConvert.SerializeObject(obj.DsThuoc)));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("ttThuoc_Ca1", JsonConvert.SerializeObject(obj.ttThuoc_Ca1)));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("ttThuoc_Ca2", JsonConvert.SerializeObject(obj.ttThuoc_Ca2)));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("ttThuoc_Ca3", JsonConvert.SerializeObject(obj.ttThuoc_Ca3)));
                if (obj.ID == 0)
                {
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("NgayTao", obj.NgayTao));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("NguoiTao", obj.NguoiTao));
                }
                oracleCommand.Parameters.Add(new MDB.MDBParameter("NgaySua", DateTime.Now));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("NguoiSua", obj.NguoiSua));
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
                XuLyLoi.LogError(ex);
            }
            return false;
        }
        public static bool InsertOrUpdateThongTinGio(MDB.MDBConnection MyConnection, PTDVCSC1_ChiTietGio obj)
        {
            try
            {
                string sql = @"INSERT INTO PTDVCSC1_ChiTietGio
                (
                    ID_Phieu,
                    CaThu,
                    Gio,
                    NT,
                    T,
                    M,
                    HAMax,
                    HAMin,
                    Fi,
                    SpO2,
                    DVAn,
                    DRNTieu,
                    DRDaDay,
                    DRPhan
                )  VALUES(
                    :ID_Phieu,
                    :CaThu,
                    :Gio,
                    :NT,
                    :T,
                    :M,
                    :HAMax,
                    :HAMin,
                    :Fi,
                    :SpO2,
                    :DVAn,
                    :DRNTieu,
                    :DRDaDay,
                    :DRPhan
                )  RETURNING ID INTO :ID";
                if (obj.ID != 0)
                {
                    sql = @"UPDATE PTDVCSC1_ChiTietGio SET
                    ID_Phieu=:ID_Phieu,
                    CaThu=:CaThu,
                    Gio=:Gio,
                    NT=:NT,
                    T=:T,
                    M=:M,
                    HAMax=:HAMax,
                    HAMin=:HAMin,
                    Fi=:Fi,
                    SpO2=:SpO2,
                    DVAn=:DVAn,
                    DRNTieu=:DRNTieu,
                    DRDaDay=:DRDaDay,
                    DRPhan=:DRPhan
                    WHERE ID = " + obj.ID;
                }
                MDB.MDBCommand oracleCommand = new MDB.MDBCommand(sql, MyConnection);
                oracleCommand.Parameters.Add(new MDB.MDBParameter("ID_Phieu", obj.ID_Phieu));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("CaThu", obj.CaThu));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("Gio", obj.Gio));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("NT", obj.NT));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("T", obj.T));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("M", obj.M));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("HAMax", obj.HAMax));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("HAMin", obj.HAMin));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("Fi", obj.Fi));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("SpO2", obj.SpO2));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("DVAn", obj.DVAn));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("DRNTieu", obj.DRNTieu));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("DRDaDay", obj.DRDaDay));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("DRPhan", obj.DRPhan));
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
                XuLyLoi.LogError(ex);
            }
            return false;
        }

        public static bool deleteThongTinGio(MDB.MDBConnection MyConnection, decimal ID_Phieu)
        {
            try
            {
                string sql = "DELETE FROM PTDVCSC1_ChiTietGio WHERE ID_Phieu = :ID_Phieu";
                MDB.MDBCommand command = new MDB.MDBCommand(sql, MyConnection);
                command.Parameters.Add(new MDB.MDBParameter("ID_Phieu", ID_Phieu));
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
        public static DataSet GetDataSet(MDB.MDBConnection MyConnection, decimal ID)
        {
            var timer = new Stopwatch();
            StringBuilder sql = new StringBuilder();
            timer.Start();
            try
            {
                sql.AppendLine(@" select A.*, H.BENHVIEN, H.SOYTe ");
                sql.AppendLine(@" from PTDVCSC1 A left join HANHCHINHBENHNHAN H ON A.MABENHNHAN = H.MABENHNHAN");
                sql.AppendLine(" WHERE a.ID = " + ID);
                MDB.MDBCommand Command = new MDB.MDBCommand(sql.ToString(), MyConnection);
                MDB.MDBDataAdapter adt = new MDB.MDBDataAdapter(Command);
                var ds = new DataSet();
                adt.Fill(ds);
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
        public static bool deletePhieu(MDB.MDBConnection MyConnection, decimal id)
        {
            try
            {
                string sql = "DELETE FROM PTDVCSC1 WHERE ID = :ID";
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

    }

}
