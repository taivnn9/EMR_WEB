using EMR.KyDienTu;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PMS.Access; 

namespace EMR_MAIN.DATABASE.Other
{
    public class PhieuTheoDoiDieuTriThanNhanTao2 : ThongTinKy
    {
        public PhieuTheoDoiDieuTriThanNhanTao2()
        {
            TableName = "PhieuTDDTThanNhanTao2";
            TablePrimaryKeyName = "ID";
            IDMauPhieu = (int)DanhMucPhieu.TDDTTNT;
            TenMauPhieu = DanhMucPhieu.TDDTTNT.Description();
        }
        [MoTaDuLieu("Mã định danh")]
		public long ID { get; set; }
        [MoTaDuLieu("Mã quản lý: mã duy nhất trong 1 đợt khám chữa bệnh (kcb), không trùng giữa các đợt kcb khác nhau","",1)]
		public decimal MaQuanLy { get; set; }
        [MoTaDuLieu("Mã bệnh nhân")]
		public string MaBenhNhan { get; set; }
        public string CaLocMau { get; set; }
        [MoTaDuLieu("Chẩn đoán bệnh")]
		public string ChanDoan { get; set; }
        public bool[] LoaiMayArray { get; } = new bool[] { false, false };
        public string LoaiMay
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < LoaiMayArray.Length; i++)
                    temp += (LoaiMayArray[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        LoaiMayArray[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
       
        public string SoMay { get; set; }
        // Can nang
        public string CanTruocLoc { get; set; }
        public string CanCanLay  { get; set; }
        public string CanSauLoc { get; set; }
        public bool[] DuongVaoMachMauArray { get; } = new bool[] { false, false, false, false, false };
        public string DuongVaoMachMau
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < DuongVaoMachMauArray.Length; i++)
                    temp += (DuongVaoMachMauArray[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        DuongVaoMachMauArray[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        // Chống đông
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
        public string LieuTong { get; set; }
        public string Bolus { get; set; }
        public string DuyTri { get; set; }
       
        // Khám trước thận nhân tạo
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
        // Chỉ số sinh tồn
        public string Cot1 { get; set; }
        public string Cot2 { get; set; }
        public string Cot3 { get; set; }
        public string Cot4 { get; set; }
        public ObservableCollection<ChiSoSinhTon> ChiSoSinhTons { get; set; }
        public string ThongSoMay_1 { get; set; }
        public string ThongSoMay_2 { get; set; }
        public string ThongSoMay_3 { get; set; }
        public ObservableCollection<ThongSoMay2> ThongSoMays { get; set; }
        public string DienBien { get; set; }
        [MoTaDuLieu("Y lệnh")]
		public string YLenh { get; set; }
        public bool[] QuaLocYLenhArray { get; } = new bool[] { false, false, false, false };
        public string QuaLocYLenh
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < QuaLocYLenhArray.Length; i++)
                    temp += (QuaLocYLenhArray[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        QuaLocYLenhArray[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }

        public string QuaLocYlenh_Text { get; set; }
        public int DichTruyen { get; set; }
        public string DichTruyen_Text { get; set; }
        public int TaoMau { get; set; }
        public string TaoMau_Text { get; set; }
        public int Khac { get; set; }
        public string Khac_Text { get; set; }

        // Thời gian
        public int ThoiGian { get; set; }
        public string ThoiGian_Text { get; set; }
        public bool[] QuaLocArray { get; } = new bool[] { false, false, false, false };
        public string QuaLoc
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < QuaLocArray.Length; i++)
                    temp += (QuaLocArray[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        QuaLocArray[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public string QuaLoc_Text { get; set; }
        public bool[] DichKhuTrungArray { get; } = new bool[] { false, false, false, false };
        public string DichKhuTrung
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < DichKhuTrungArray.Length; i++)
                    temp += (DichKhuTrungArray[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        DichKhuTrungArray[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public string DichKhuTrung_Text { get; set; }
        public string QuaLan { get; set; }
        public string DayLan { get; set; }

        public bool[] DichLocArray { get; } = new bool[] { false, false };
        public string DichLoc
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < DichLocArray.Length; i++)
                    temp += (DichLocArray[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        DichLocArray[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public bool[] NXQuaLocKhiKetThucArray { get; } = new bool[] { false, false, false, false };
        public string NXQuaLocKhiKetThuc
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < NXQuaLocKhiKetThucArray.Length; i++)
                    temp += (NXQuaLocKhiKetThucArray[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        NXQuaLocKhiKetThucArray[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public bool[] DichPrimingMangArray { get; } = new bool[] { false, false };
        public string DichPrimingMang
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < DichPrimingMangArray.Length; i++)
                    temp += (DichPrimingMangArray[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        DichPrimingMangArray[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public string NaCl { get; set; }
        public string Glucose { get; set; }
        public ObservableCollection<ChamSoc> ChamSocs { get; set; }
        public ObservableCollection<ChamSoc> CLS { get; set; }
        [MoTaDuLieu("Bác sỹ")]
		public string BacSy { get; set; }
        [MoTaDuLieu("Mã bác sỹ")]
		public string MaBacSy { get; set; }
        [MoTaDuLieu("Họ tên điều dưỡng")]
		public string DieuDuong { get; set; }
        [MoTaDuLieu("Mã điều dưỡng")]
		public string MaDieuDuong { get; set; }

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
    public class ThongSoMay2
    {
        public string GioTheoDoi { get; set; }
        public string VanToc { get; set; }
        public string ApLuc { get; set; }
        public string PTM { get; set; }
        public string NhietDoDich { get; set; }
        public string Cond { get; set; }
        public string Cot_1 { get; set; }
        public string Cot_2 { get; set; }
        public string Cot_3 { get; set; }
    }
    public class PhieuTheoDoiDieuTriThanNhanTao2Func
    {
        public const string TableName = "PhieuTDDTThanNhanTao2";
        public const string TablePrimaryKeyName = "ID";
        public static List<PhieuTheoDoiDieuTriThanNhanTao2> GetListData(MDB.MDBConnection _OracleConnection, decimal maquanly)
        {
            List<PhieuTheoDoiDieuTriThanNhanTao2> list = new List<PhieuTheoDoiDieuTriThanNhanTao2>();
            try
            {
                string sql = @"SELECT * FROM PhieuTDDTThanNhanTao2 where MaQuanLy = :MaQuanLy";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, _OracleConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", maquanly));
                MDB.MDBDataReader DataReader = Command.ExecuteReader();
                while (DataReader.Read())
                {
                    PhieuTheoDoiDieuTriThanNhanTao2 data = new PhieuTheoDoiDieuTriThanNhanTao2();
                    data.ID = Convert.ToInt64(DataReader.GetLong("ID").ToString());
                    data.MaQuanLy = maquanly;
                    data.MaBenhNhan = DataReader["MaBenhNhan"].ToString();
                    data.CaLocMau = DataReader["CaLocMau"].ToString();
                    data.ChanDoan = DataReader["ChanDoan"].ToString();
                    data.LoaiMay = DataReader["LoaiMay"].ToString();
                    data.SoMay = DataReader["SoMay"].ToString();
                    data.CanTruocLoc = DataReader["CanTruocLoc"].ToString();
                    data.CanCanLay = DataReader["CanCanLay"].ToString();
                    data.CanSauLoc = DataReader["CanSauLoc"].ToString();
                    data.DuongVaoMachMau = DataReader["DuongVaoMachMau"].ToString();
                    data.ChongDong = DataReader["ChongDong"].ToString();
                    data.LieuTong = DataReader["LieuTong"].ToString();
                    data.Bolus = DataReader["Bolus"].ToString();
                    data.DuyTri = DataReader["DuyTri"].ToString();
                    data.YThuc = DataReader["YThuc"].ToString();
                    data.KhoTho = DataReader["KhoTho"].ToString();
                    data.Phu = DataReader["Phu"].ToString();
                    data.Cot1 = DataReader["Cot1"].ToString();
                    data.Cot2 = DataReader["Cot2"].ToString();
                    data.Cot3 = DataReader["Cot3"].ToString();
                    data.Cot4 = DataReader["Cot4"].ToString();
                    data.ChiSoSinhTons = JsonConvert.DeserializeObject<ObservableCollection<ChiSoSinhTon>>(DataReader["ChiSoSinhTons"].ToString());
                    data.ThongSoMay_1 = DataReader["ThongSoMay_1"].ToString();
                    data.ThongSoMay_2 = DataReader["ThongSoMay_2"].ToString();
                    data.ThongSoMay_3 = DataReader["ThongSoMay_3"].ToString();
                    data.ThongSoMays = JsonConvert.DeserializeObject<ObservableCollection<ThongSoMay2>>(DataReader["ThongSoMays"].ToString());
                    data.DienBien = DataReader["DienBien"].ToString();
                    data.YLenh = DataReader["YLenh"].ToString();
                    data.QuaLocYLenh = DataReader["QuaLocYLenh"].ToString();
                    data.QuaLocYlenh_Text = DataReader["QuaLocYlenh_Text"].ToString();
                    data.DichTruyen = DataReader.GetInt("DichTruyen");
                    data.DichTruyen_Text = DataReader["DichTruyen_Text"].ToString();
                    data.TaoMau = DataReader.GetInt("TaoMau");
                    data.TaoMau_Text = DataReader["TaoMau_Text"].ToString();
                    data.Khac = DataReader.GetInt("Khac");
                    data.Khac_Text = DataReader["Khac_Text"].ToString();
                    data.ThoiGian = DataReader.GetInt("ThoiGian");
                    data.ThoiGian_Text = DataReader["ThoiGian_Text"].ToString();
                    data.QuaLoc = DataReader["QuaLoc"].ToString();
                    data.QuaLoc_Text = DataReader["QuaLoc_Text"].ToString();
                    data.DichKhuTrung = DataReader["DichKhuTrung"].ToString();
                    data.DichKhuTrung_Text = DataReader["DichKhuTrung_Text"].ToString();
                    data.QuaLan = DataReader["QuaLan"].ToString();
                    data.DayLan = DataReader["DayLan"].ToString();
                    data.DichLoc = DataReader["DichLoc"].ToString();
                    data.NXQuaLocKhiKetThuc = DataReader["NXQuaLocKhiKetThuc"].ToString();
                    data.DichPrimingMang = DataReader["DichPrimingMang"].ToString();
                    data.NaCl = DataReader["NaCl"].ToString();
                    data.Glucose = DataReader["Glucose"].ToString();
                    data.ChamSocs = JsonConvert.DeserializeObject<ObservableCollection<ChamSoc>>(DataReader["ChamSocs"].ToString());
                    data.CLS = JsonConvert.DeserializeObject<ObservableCollection<ChamSoc>>(DataReader["CLS"].ToString());
                    data.BacSy = DataReader["BacSy"].ToString();
                    data.MaBacSy = DataReader["MaBacSy"].ToString();
                    data.DieuDuong = DataReader["DieuDuong"].ToString();
                    data.MaDieuDuong = DataReader["MaDieuDuong"].ToString();

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
        public static PhieuTheoDoiDieuTriThanNhanTao2 GetData(MDB.MDBConnection _OracleConnection, long ID)
        {
            PhieuTheoDoiDieuTriThanNhanTao2 data = new PhieuTheoDoiDieuTriThanNhanTao2();
            try
            {
                string sql = @"SELECT * FROM PhieuTDDTThanNhanTao2 where ID = :ID";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, _OracleConnection);
                Command.Parameters.Add(new MDB.MDBParameter("ID", ID));
                MDB.MDBDataReader DataReader = Command.ExecuteReader();
                while (DataReader.Read())
                {
                    data.ID = Convert.ToInt64(DataReader.GetLong("ID").ToString());
                    data.MaQuanLy = Convert.ToDecimal(DataReader["MaQuanLy"].ToString());
                    data.MaBenhNhan = DataReader["MaBenhNhan"].ToString();
                    data.CaLocMau = DataReader["CaLocMau"].ToString();
                    data.ChanDoan = DataReader["ChanDoan"].ToString();
                    data.LoaiMay = DataReader["LoaiMay"].ToString();
                    data.SoMay = DataReader["SoMay"].ToString();
                    data.CanTruocLoc = DataReader["CanTruocLoc"].ToString();
                    data.CanCanLay = DataReader["CanCanLay"].ToString();
                    data.CanSauLoc = DataReader["CanSauLoc"].ToString();
                    data.DuongVaoMachMau = DataReader["DuongVaoMachMau"].ToString();
                    data.ChongDong = DataReader["ChongDong"].ToString();
                    data.LieuTong = DataReader["LieuTong"].ToString();
                    data.Bolus = DataReader["Bolus"].ToString();
                    data.DuyTri = DataReader["DuyTri"].ToString();
                    data.YThuc = DataReader["YThuc"].ToString();
                    data.KhoTho = DataReader["KhoTho"].ToString();
                    data.Phu = DataReader["Phu"].ToString();
                    data.Cot1 = DataReader["Cot1"].ToString();
                    data.Cot2 = DataReader["Cot2"].ToString();
                    data.Cot3 = DataReader["Cot3"].ToString();
                    data.Cot4 = DataReader["Cot4"].ToString();
                    data.ChiSoSinhTons = JsonConvert.DeserializeObject<ObservableCollection<ChiSoSinhTon>>(DataReader["ChiSoSinhTons"].ToString());
                    data.ThongSoMay_1 = DataReader["ThongSoMay_1"].ToString();
                    data.ThongSoMay_2 = DataReader["ThongSoMay_2"].ToString();
                    data.ThongSoMay_3 = DataReader["ThongSoMay_3"].ToString();
                    data.ThongSoMays = JsonConvert.DeserializeObject<ObservableCollection<ThongSoMay2>>(DataReader["ThongSoMays"].ToString());
                    data.DienBien = DataReader["DienBien"].ToString();
                    data.YLenh = DataReader["YLenh"].ToString();
                    data.QuaLocYLenh = DataReader["QuaLocYLenh"].ToString();
                    data.QuaLocYlenh_Text = DataReader["QuaLocYlenh_Text"].ToString();
                    data.DichTruyen = DataReader.GetInt("DichTruyen");
                    data.DichTruyen_Text = DataReader["DichTruyen_Text"].ToString();
                    data.TaoMau = DataReader.GetInt("TaoMau");
                    data.TaoMau_Text = DataReader["TaoMau_Text"].ToString();
                    data.Khac = DataReader.GetInt("Khac");
                    data.Khac_Text = DataReader["Khac_Text"].ToString();
                    data.ThoiGian = DataReader.GetInt("ThoiGian");
                    data.ThoiGian_Text = DataReader["ThoiGian_Text"].ToString();
                    data.QuaLoc = DataReader["QuaLoc"].ToString();
                    data.QuaLoc_Text = DataReader["QuaLoc_Text"].ToString();
                    data.DichKhuTrung = DataReader["DichKhuTrung"].ToString();
                    data.DichKhuTrung_Text = DataReader["DichKhuTrung_Text"].ToString();
                    data.QuaLan = DataReader["QuaLan"].ToString();
                    data.DayLan = DataReader["DayLan"].ToString();
                    data.DichLoc = DataReader["DichLoc"].ToString();
                    data.NXQuaLocKhiKetThuc = DataReader["NXQuaLocKhiKetThuc"].ToString();
                    data.DichPrimingMang = DataReader["DichPrimingMang"].ToString();
                    data.NaCl = DataReader["NaCl"].ToString();
                    data.Glucose = DataReader["Glucose"].ToString();
                    data.ChamSocs = JsonConvert.DeserializeObject<ObservableCollection<ChamSoc>>(DataReader["ChamSocs"].ToString());
                    data.CLS = JsonConvert.DeserializeObject<ObservableCollection<ChamSoc>>(DataReader["CLS"].ToString());
                    data.BacSy = DataReader["BacSy"].ToString();
                    data.MaBacSy = DataReader["MaBacSy"].ToString();
                    data.DieuDuong = DataReader["DieuDuong"].ToString();
                    data.MaDieuDuong = DataReader["MaDieuDuong"].ToString();

                    data.NgayTao = Convert.ToDateTime(DataReader["NgayTao"] == DBNull.Value ? DateTime.Now : DataReader["NgayTao"]);
                    data.NguoiTao = DataReader["NguoiTao"].ToString();
                    data.NgaySua = Convert.ToDateTime(DataReader["NgaySua"] == DBNull.Value ? DateTime.Now : DataReader["NgaySua"]);
                    data.NguoiSua = DataReader["NguoiSua"].ToString();

                    data.MaSoKy = DataReader["masokyten"].ToString();
                    data.DaKy = !string.IsNullOrEmpty(data.MaSoKy) ? true : false;
                }
            }
            catch (Exception ex) { XuLyLoi.Handle(ex); }
            return data;
        }

        public static bool InsertOrUpdate(MDB.MDBConnection MyConnection, ref PhieuTheoDoiDieuTriThanNhanTao2 phieuTheoDoi)
        {
            try
            {
                string sql = @"INSERT INTO PhieuTDDTThanNhanTao2
                (
                    MAQUANLY,
                    MaBenhNhan,
                    CaLocMau,
                    ChanDoan,
                    LoaiMay,
                    SoMay,
                    CanTruocLoc,
                    CanCanLay,
                    CanSauLoc,
                    DuongVaoMachMau,
                    ChongDong,
                    LieuTong,
                    Bolus,
                    DuyTri,
                    YThuc,
                    KhoTho,
                    Phu,
                    Cot1,
                    Cot2,
                    Cot3,
                    Cot4,
                    ChiSoSinhTons,
                    ThongSoMay_1,
                    ThongSoMay_2,
                    ThongSoMay_3,
                    ThongSoMays,
                    DienBien,
                    YLenh,
                    QuaLocYLenh,
                    QuaLocYlenh_Text,
                    DichTruyen,
                    DichTruyen_Text,
                    TaoMau,
                    TaoMau_Text,
                    Khac,
                    Khac_Text,
                    ThoiGian,
                    ThoiGian_Text,
                    QuaLoc,
                    QuaLoc_Text,
                    DichKhuTrung,
                    DichKhuTrung_Text,
                    QuaLan,
                    DayLan,
                    DichLoc,
                    NXQuaLocKhiKetThuc,
                    DichPrimingMang,
                    NaCl,
                    Glucose,
                    ChamSocs,
                    CLS,
                    BacSy,
                    MaBacSy,
                    DieuDuong,
                    MaDieuDuong,
                    NGUOITAO,
                    NGUOISUA,
                    NGAYTAO,
                    NGAYSUA)  VALUES
                 (
				    :MAQUANLY,
                    :MaBenhNhan,
                    :CaLocMau,
                    :ChanDoan,
                    :LoaiMay,
                    :SoMay,
                    :CanTruocLoc,
                    :CanCanLay,
                    :CanSauLoc,
                    :DuongVaoMachMau,
                    :ChongDong,
                    :LieuTong,
                    :Bolus,
                    :DuyTri,
                    :YThuc,
                    :KhoTho,
                    :Phu,
                    :Cot1,
                    :Cot2,
                    :Cot3,
                    :Cot4,
                    :ChiSoSinhTons,
                    :ThongSoMay_1,
                    :ThongSoMay_2,
                    :ThongSoMay_3,
                    :ThongSoMays,
                    :DienBien,
                    :YLenh,
                    :QuaLocYLenh,
                    :QuaLocYlenh_Text,
                    :DichTruyen,
                    :DichTruyen_Text,
                    :TaoMau,
                    :TaoMau_Text,
                    :Khac,
                    :Khac_Text,
                    :ThoiGian,
                    :ThoiGian_Text,
                    :QuaLoc,
                    :QuaLoc_Text,
                    :DichKhuTrung,
                    :DichKhuTrung_Text,
                    :QuaLan,
                    :DayLan,
                    :DichLoc,
                    :NXQuaLocKhiKetThuc,
                    :DichPrimingMang,
                    :NaCl,
                    :Glucose,
                    :ChamSocs,
                    :CLS,
                    :BacSy,
                    :MaBacSy,
                    :DieuDuong,
                    :MaDieuDuong,
                    :NGUOITAO,
                    :NGUOISUA,
                    :NGAYTAO,
                    :NGAYSUA
                 )  RETURNING ID INTO :ID";
                if (phieuTheoDoi.ID != 0)
                {
                    sql = @"UPDATE PhieuTDDTThanNhanTao2 SET 
                    MAQUANLY = :MAQUANLY,
                    MaBenhNhan = :MaBenhNhan,
                    CaLocMau=:CaLocMau,
                    ChanDoan=:ChanDoan,
                    LoaiMay=:LoaiMay,
                    SoMay=:SoMay,
                    CanTruocLoc=:CanTruocLoc,
                    CanCanLay=:CanCanLay,
                    CanSauLoc=:CanSauLoc,
                    DuongVaoMachMau=:DuongVaoMachMau,
                    ChongDong=:ChongDong,
                    LieuTong = :LieuTong,
                    Bolus = :Bolus,
                    DuyTri = :DuyTri,
                    YThuc = :YThuc,
                    KhoTho=:KhoTho,
                    Phu=:Phu,
                    Cot1=:Cot1,
                    Cot2=:Cot2,
                    Cot3=:Cot3,
                    Cot4=:Cot4,
                    ChiSoSinhTons=:ChiSoSinhTons,
                    ThongSoMay_1 = :ThongSoMay_1,
                    ThongSoMay_2 = :ThongSoMay_2,
                    ThongSoMay_3 = :ThongSoMay_3,
                    ThongSoMays=:ThongSoMays,
                    DienBien=:DienBien,
                    YLenh=:YLenh,
                    QuaLocYLenh=:QuaLocYLenh,
                    QuaLocYlenh_Text=:QuaLocYlenh_Text,
                    DichTruyen=:DichTruyen,
                    DichTruyen_Text=:DichTruyen_Text,
                    TaoMau=:TaoMau,
                    TaoMau_Text=:TaoMau_Text,
                    Khac=:Khac,
                    Khac_Text=:Khac_Text,
                    ThoiGian=:ThoiGian,
                    ThoiGian_Text=:ThoiGian_Text,
                    QuaLoc=:QuaLoc,
                    QuaLoc_Text=:QuaLoc_Text,
                    DichKhuTrung=:DichKhuTrung,
                    DichKhuTrung_Text=:DichKhuTrung_Text,
                    QuaLan=:QuaLan,
                    DayLan=:DayLan,
                    DichLoc=:DichLoc,
                    NXQuaLocKhiKetThuc=:NXQuaLocKhiKetThuc,
                    DichPrimingMang=:DichPrimingMang,
                    NaCl=:NaCl,
                    Glucose=:Glucose,
                    ChamSocs=:ChamSocs,
                    CLS=:CLS,
                    BacSy=:BacSy,
                    MaBacSy=:MaBacSy,
                    DieuDuong=:DieuDuong,
                    MaDieuDuong=:MaDieuDuong,
                    NGUOISUA = :NGUOISUA,
                    NGAYSUA = :NGAYSUA
                    WHERE ID = " + phieuTheoDoi.ID;
                }
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MAQUANLY", phieuTheoDoi.MaQuanLy));
                Command.Parameters.Add(new MDB.MDBParameter("MaBenhNhan", phieuTheoDoi.MaBenhNhan));
                Command.Parameters.Add(new MDB.MDBParameter("CaLocMau", phieuTheoDoi.CaLocMau));
                Command.Parameters.Add(new MDB.MDBParameter("ChanDoan", phieuTheoDoi.ChanDoan));
                Command.Parameters.Add(new MDB.MDBParameter("LoaiMay", phieuTheoDoi.LoaiMay));
                Command.Parameters.Add(new MDB.MDBParameter("SoMay", phieuTheoDoi.SoMay));
                Command.Parameters.Add(new MDB.MDBParameter("CanTruocLoc", phieuTheoDoi.CanTruocLoc));
                Command.Parameters.Add(new MDB.MDBParameter("CanCanLay", phieuTheoDoi.CanCanLay));
                Command.Parameters.Add(new MDB.MDBParameter("CanSauLoc", phieuTheoDoi.CanSauLoc));
                Command.Parameters.Add(new MDB.MDBParameter("DuongVaoMachMau", phieuTheoDoi.DuongVaoMachMau));
                Command.Parameters.Add(new MDB.MDBParameter("ChongDong", phieuTheoDoi.ChongDong));
                Command.Parameters.Add(new MDB.MDBParameter("LieuTong", phieuTheoDoi.LieuTong));
                Command.Parameters.Add(new MDB.MDBParameter("Bolus", phieuTheoDoi.Bolus));
                Command.Parameters.Add(new MDB.MDBParameter("DuyTri", phieuTheoDoi.DuyTri));
                Command.Parameters.Add(new MDB.MDBParameter("YThuc", phieuTheoDoi.YThuc));
                Command.Parameters.Add(new MDB.MDBParameter("KhoTho", phieuTheoDoi.KhoTho));
                Command.Parameters.Add(new MDB.MDBParameter("Phu", phieuTheoDoi.Phu));
                Command.Parameters.Add(new MDB.MDBParameter("Cot1", phieuTheoDoi.Cot1));
                Command.Parameters.Add(new MDB.MDBParameter("Cot2", phieuTheoDoi.Cot2));
                Command.Parameters.Add(new MDB.MDBParameter("Cot3", phieuTheoDoi.Cot3));
                Command.Parameters.Add(new MDB.MDBParameter("Cot4", phieuTheoDoi.Cot4));
                Command.Parameters.Add(new MDB.MDBParameter("ChiSoSinhTons", JsonConvert.SerializeObject(phieuTheoDoi.ChiSoSinhTons)));
                Command.Parameters.Add(new MDB.MDBParameter("ThongSoMay_1", phieuTheoDoi.ThongSoMay_1));
                Command.Parameters.Add(new MDB.MDBParameter("ThongSoMay_2", phieuTheoDoi.ThongSoMay_2));
                Command.Parameters.Add(new MDB.MDBParameter("ThongSoMay_3", phieuTheoDoi.ThongSoMay_3));
                Command.Parameters.Add(new MDB.MDBParameter("ThongSoMays", JsonConvert.SerializeObject(phieuTheoDoi.ThongSoMays)));
                Command.Parameters.Add(new MDB.MDBParameter("DienBien", phieuTheoDoi.DienBien));
                Command.Parameters.Add(new MDB.MDBParameter("YLenh", phieuTheoDoi.YLenh));
                Command.Parameters.Add(new MDB.MDBParameter("QuaLocYLenh", phieuTheoDoi.QuaLocYLenh));
                Command.Parameters.Add(new MDB.MDBParameter("QuaLocYlenh_Text", phieuTheoDoi.QuaLocYlenh_Text));
                Command.Parameters.Add(new MDB.MDBParameter("DichTruyen", phieuTheoDoi.DichTruyen));
                Command.Parameters.Add(new MDB.MDBParameter("DichTruyen_Text", phieuTheoDoi.DichTruyen_Text));
                Command.Parameters.Add(new MDB.MDBParameter("TaoMau", phieuTheoDoi.TaoMau));
                Command.Parameters.Add(new MDB.MDBParameter("TaoMau_Text", phieuTheoDoi.TaoMau_Text));
                Command.Parameters.Add(new MDB.MDBParameter("Khac", phieuTheoDoi.Khac));
                Command.Parameters.Add(new MDB.MDBParameter("Khac_Text", phieuTheoDoi.Khac_Text));
                Command.Parameters.Add(new MDB.MDBParameter("ThoiGian", phieuTheoDoi.ThoiGian));
                Command.Parameters.Add(new MDB.MDBParameter("ThoiGian_Text", phieuTheoDoi.ThoiGian_Text));
                Command.Parameters.Add(new MDB.MDBParameter("QuaLoc", phieuTheoDoi.QuaLoc));
                Command.Parameters.Add(new MDB.MDBParameter("QuaLoc_Text", phieuTheoDoi.QuaLoc_Text));
                Command.Parameters.Add(new MDB.MDBParameter("DichKhuTrung", phieuTheoDoi.DichKhuTrung));
                Command.Parameters.Add(new MDB.MDBParameter("DichKhuTrung_Text", phieuTheoDoi.DichKhuTrung_Text));
                Command.Parameters.Add(new MDB.MDBParameter("QuaLan", phieuTheoDoi.QuaLan));
                Command.Parameters.Add(new MDB.MDBParameter("DayLan", phieuTheoDoi.DayLan));
                Command.Parameters.Add(new MDB.MDBParameter("DichLoc", phieuTheoDoi.DichLoc));
                Command.Parameters.Add(new MDB.MDBParameter("NXQuaLocKhiKetThuc", phieuTheoDoi.NXQuaLocKhiKetThuc));
                Command.Parameters.Add(new MDB.MDBParameter("DichPrimingMang", phieuTheoDoi.DichPrimingMang));
                Command.Parameters.Add(new MDB.MDBParameter("NaCl", phieuTheoDoi.NaCl));
                Command.Parameters.Add(new MDB.MDBParameter("Glucose", phieuTheoDoi.Glucose));
                Command.Parameters.Add(new MDB.MDBParameter("ChamSocs", JsonConvert.SerializeObject(phieuTheoDoi.ChamSocs)));
                Command.Parameters.Add(new MDB.MDBParameter("CLS", JsonConvert.SerializeObject(phieuTheoDoi.CLS)));
                Command.Parameters.Add(new MDB.MDBParameter("BacSy", phieuTheoDoi.BacSy));
                Command.Parameters.Add(new MDB.MDBParameter("MaBacSy", phieuTheoDoi.MaBacSy));
                Command.Parameters.Add(new MDB.MDBParameter("DieuDuong", phieuTheoDoi.DieuDuong));
                Command.Parameters.Add(new MDB.MDBParameter("MaDieuDuong", phieuTheoDoi.MaDieuDuong));
                Command.Parameters.Add(new MDB.MDBParameter("NGUOISUA", phieuTheoDoi.NguoiSua));
                Command.Parameters.Add(new MDB.MDBParameter("NGAYSUA", phieuTheoDoi.NgaySua));
                if (phieuTheoDoi.ID == 0)
                {
                    Command.Parameters.Add(new MDB.MDBParameter("ID", phieuTheoDoi.ID));
                    Command.Parameters.Add(new MDB.MDBParameter("NGUOITAO", phieuTheoDoi.NguoiTao));
                    Command.Parameters.Add(new MDB.MDBParameter("NGAYTAO", phieuTheoDoi.NgayTao));
                }
                Command.BindByName = true;
                int n = Command.ExecuteNonQuery();
                if (phieuTheoDoi.ID == 0)
                {
                    long nextval = Convert.ToInt64((Command.Parameters["ID"] as MDB.MDBParameter).Value);
                    phieuTheoDoi.ID = nextval;
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
                string sql = "DELETE FROM PhieuTDDTThanNhanTao2 WHERE ID = :ID";
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
                T.MABENHAN,
                H.GIOITINH,
	            H.TENBENHNHAN,
                H.SOYTE,
                H.BENHVIEN
            FROM
                PhieuTDDTThanNhanTao2 B
                LEFT JOIN THONGTINDIEUTRI T ON B.MAQUANLY = T.MAQUANLY
                LEFT JOIN HANHCHINHBENHNHAN H ON T.MABENHNHAN = H.MABENHNHAN
            WHERE
                ID = " + id;

            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);

            MDB.MDBDataAdapter adt = new MDB.MDBDataAdapter(Command);
            var ds = new DataSet();
            adt.Fill(ds, "BM");

            return ds;
        }
    }
}
