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
    public class ChiSoSinhTon
    {
        public string GioTheoDoi { get; set; }
        public int? Mach { get; set; }
        public int? HuyetApTren { get; set; }
        public int? HuyetApDuoi { get; set; }
        public double? NhietDo { get; set; }
        public int? NhipTho { get; set; }
    }
    public class ThongSoMay
    {
        public string GioTheoDoi { get; set; }
        public double? NhietDo { get; set; }
        public double? TocDoSieuLoc { get; set; }
        public double? SoCanDaRut { get; set; }
        public double? LLMau { get; set; }
        public double? TocDoHeparin { get; set; }
        public double? ALXuyenMang { get; set; }
        public string ApLucDTM { get; set; }
        public double? DoDanDien { get; set; }
    }
    public class ChamSoc
    {
        [MoTaDuLieu("Chọn", null, 0, 0)]
		public bool Chon { get; set; }
        public string ThucHien { get; set; }
        public string Gio { get; set; }
    }
    public class PhieuTheoDoiDieuTriThanNhanTao : ThongTinKy
    {
        public PhieuTheoDoiDieuTriThanNhanTao()
        {
            TableName = "PhieuTDDTThanNhanTao";
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
        public int LoaiMay
        {
            get
            {
                return Array.IndexOf(LoaiMayArray, true) + 1;
            }
            set
            {
                for (int i = 0; i < LoaiMayArray.Length; i++)
                {
                    if (i == (value - 1)) LoaiMayArray[i] = true;
                    else LoaiMayArray[i] = false;
                }
            }
        }
        public string SoMay { get; set; }
        // Can nang
        public double? CanYeuCau { get; set; }
        public double? CanTruocLoc { get; set; }
        public double? Dat { get; set; }
        public double? AUF { get; set; }
        public double? CanSauLoc { get; set; }
        public bool[] DuongVaoMachMauArray { get; } = new bool[] { false, false, false, false, false, false, false, false };
        public int DuongVaoMachMau
        {
            get
            {
                return Array.IndexOf(DuongVaoMachMauArray, true) + 1;
            }
            set
            {
                for (int i = 0; i < DuongVaoMachMauArray.Length; i++)
                {
                    if (i == (value - 1)) DuongVaoMachMauArray[i] = true;
                    else DuongVaoMachMauArray[i] = false;
                }
            }
        }
        // Chống đông
        public double? Trang { get; set; }
        public bool[] ChongDongArray { get; } = new bool[] { false, false };
        public int ChongDong
        {
            get
            {
                return Array.IndexOf(ChongDongArray, true) + 1;
            }
            set
            {
                for (int i = 0; i < ChongDongArray.Length; i++)
                {
                    if (i == (value - 1)) ChongDongArray[i] = true;
                    else ChongDongArray[i] = false;
                }
            }
        }
        public double? LieuTong { get; set; }
        public double? LieuTC { get; set; }
        public double? DuyTri { get; set; }
        public bool[] CachDungArray { get; } = new bool[] { false, false };
        public int CachDung
        {
            get
            {
                return Array.IndexOf(CachDungArray, true) + 1;
            }
            set
            {
                for (int i = 0; i < CachDungArray.Length; i++)
                {
                    if (i == (value - 1)) CachDungArray[i] = true;
                    else CachDungArray[i] = false;
                }
            }
        }
        // Khám trước thận nhân tạo
        public bool[] YThucArray { get; } = new bool[] { false, false, false, false };
        public int YThuc
        {
            get
            {
                return Array.IndexOf(YThucArray, true) + 1;
            }
            set
            {
                for (int i = 0; i < YThucArray.Length; i++)
                {
                    if (i == (value - 1)) YThucArray[i] = true;
                    else YThucArray[i] = false;
                }
            }
        }
        public bool[] KhoThoArray { get; } = new bool[] { false, false, false, false, false };
        public int KhoTho
        {
            get
            {
                return Array.IndexOf(KhoThoArray, true) + 1;
            }
            set
            {
                for (int i = 0; i < KhoThoArray.Length; i++)
                {
                    if (i == (value - 1)) KhoThoArray[i] = true;
                    else KhoThoArray[i] = false;
                }
            }
        }
        public bool[] PhuArray { get; } = new bool[] { false, false, false, false, false };
        public int Phu
        {
            get
            {
                return Array.IndexOf(PhuArray, true) + 1;
            }
            set
            {
                for (int i = 0; i < PhuArray.Length; i++)
                {
                    if (i == (value - 1)) PhuArray[i] = true;
                    else PhuArray[i] = false;
                }
            }
        }
        public ObservableCollection<ChiSoSinhTon> ChiSoSinhTons { get; set; }
        public ObservableCollection<ThongSoMay> ThongSoMays { get; set; }
        public string DienBien { get; set; }
        [MoTaDuLieu("Y lệnh")]
		public string YLenh { get; set; }
        public bool[] QuaLocYLenhArray { get; } = new bool[] { false, false, false, false };
        public int QuaLocYLenh
        {
            get
            {
                return Array.IndexOf(QuaLocYLenhArray, true) + 1;
            }
            set
            {
                for (int i = 0; i < QuaLocYLenhArray.Length; i++)
                {
                    if (i == (value - 1)) QuaLocYLenhArray[i] = true;
                    else QuaLocYLenhArray[i] = false;
                }
            }
        }
        public string QuaLocYlenh_Text { get; set; }
        public bool[] ThoiGianArray { get; } = new bool[] { false, false };
        public int ThoiGian
        {
            get
            {
                return Array.IndexOf(ThoiGianArray, true) + 1;
            }
            set
            {
                for (int i = 0; i < ThoiGianArray.Length; i++)
                {
                    if (i == (value - 1)) ThoiGianArray[i] = true;
                    else ThoiGianArray[i] = false;
                }
            }
        }
        public string ThoiGian_Text { get; set; }
        public bool[] QuaLocArray { get; } = new bool[] { false, false, false, false };
        public int QuaLoc
        {
            get
            {
                return Array.IndexOf(QuaLocArray, true) + 1;
            }
            set
            {
                for (int i = 0; i < QuaLocArray.Length; i++)
                {
                    if (i == (value - 1)) QuaLocArray[i] = true;
                    else QuaLocArray[i] = false;
                }
            }
        }
        public string QuaLoc_Text { get; set; }
        public bool[] DichKhuTrungArray { get; } = new bool[] { false, false };
        public int DichKhuTrung
        {
            get
            {
                return Array.IndexOf(DichKhuTrungArray, true) + 1;
            }
            set
            {
                for (int i = 0; i < DichKhuTrungArray.Length; i++)
                {
                    if (i == (value - 1)) DichKhuTrungArray[i] = true;
                    else DichKhuTrungArray[i] = false;
                }
            }
        }
        public string DichKhuTrung_Text { get; set; }
        public int? QuaLan { get; set; }
        public int? DayLan { get; set; }
        public bool[] TinhTrangQuaLocArray { get; } = new bool[] { false, false };
        public int TinhTrangQuaLoc
        {
            get
            {
                return Array.IndexOf(TinhTrangQuaLocArray, true) + 1;
            }
            set
            {
                for (int i = 0; i < TinhTrangQuaLocArray.Length; i++)
                {
                    if (i == (value - 1)) TinhTrangQuaLocArray[i] = true;
                    else TinhTrangQuaLocArray[i] = false;
                }
            }
        }
        public string TinhTrangQuaLoc_Text { get; set; }
        public bool[] NXQuaLocKhiKetThucArray { get; } = new bool[] { false, false, false, false };
        public int NXQuaLocKhiKetThuc
        {
            get
            {
                return Array.IndexOf(NXQuaLocKhiKetThucArray, true) + 1;
            }
            set
            {
                for (int i = 0; i < NXQuaLocKhiKetThucArray.Length; i++)
                {
                    if (i == (value - 1)) NXQuaLocKhiKetThucArray[i] = true;
                    else NXQuaLocKhiKetThucArray[i] = false;
                }
            }
        }
        public bool[] DichKetTNTArray { get; } = new bool[] { false, false, false };
        public int DichKetTNT
        {
            get
            {
                return Array.IndexOf(DichKetTNTArray, true) + 1;
            }
            set
            {
                for (int i = 0; i < DichKetTNTArray.Length; i++)
                {
                    if (i == (value - 1)) DichKetTNTArray[i] = true;
                    else DichKetTNTArray[i] = false;
                }
            }
        }
        public ObservableCollection<ChamSoc> ChamSocs { get; set; }
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
    public class PhieuTheoDoiDieuTriThanNhanTaoFunc
    {
        public const string TableName = "PhieuTDDTThanNhanTao";
        public const string TablePrimaryKeyName = "ID";
        public static List<PhieuTheoDoiDieuTriThanNhanTao> GetListData(MDB.MDBConnection _OracleConnection, decimal maquanly)
        {
            List<PhieuTheoDoiDieuTriThanNhanTao> list = new List<PhieuTheoDoiDieuTriThanNhanTao>();
            try
            {
                string sql = @"SELECT * FROM PhieuTDDTThanNhanTao where MaQuanLy = :MaQuanLy";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, _OracleConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", maquanly));
                MDB.MDBDataReader DataReader = Command.ExecuteReader();
                while (DataReader.Read())
                {
                    PhieuTheoDoiDieuTriThanNhanTao data = new PhieuTheoDoiDieuTriThanNhanTao();
                    data.ID = Convert.ToInt64(DataReader.GetLong("ID").ToString());
                    data.MaQuanLy = maquanly;
                    data.MaBenhNhan = DataReader["MaBenhNhan"].ToString();
                    data.CaLocMau = DataReader["CaLocMau"].ToString();
                    data.ChanDoan = DataReader["ChanDoan"].ToString();

                    int tempInt = 0;
                    int.TryParse(DataReader["LoaiMay"].ToString(), out tempInt);
                    data.LoaiMay = tempInt;
                    data.SoMay = DataReader["SoMay"].ToString();

                    double tempDouble = 0;
                    data.CanYeuCau =  double.TryParse(DataReader["CanYeuCau"].ToString(), out tempDouble) ? (double?)tempDouble : null;

                    tempDouble = 0;
                    data.CanTruocLoc = double.TryParse(DataReader["CanTruocLoc"].ToString(), out tempDouble) ? (double?)tempDouble : null;

                    tempDouble = 0;
                    data.Dat =  double.TryParse(DataReader["Dat"].ToString(), out tempDouble) ? (double?)tempDouble : null;

                    tempDouble = 0;
                    data.AUF =  double.TryParse(DataReader["AUF"].ToString(), out tempDouble) ? (double?)tempDouble : null;

                    tempDouble = 0;
                    data.CanSauLoc =  double.TryParse(DataReader["CanSauLoc"].ToString(), out tempDouble) ? (double?)tempDouble : null;

                    tempInt = 0;
                    int.TryParse(DataReader["DuongVaoMachMau"].ToString(), out tempInt);
                    data.DuongVaoMachMau = tempInt;

                    tempDouble = 0;
                    data.Trang = double.TryParse(DataReader["Trang"].ToString(), out tempDouble) ? (double?)tempDouble : null;

                    tempInt = 0;
                    int.TryParse(DataReader["ChongDong"].ToString(), out tempInt);
                    data.ChongDong = tempInt;

                    tempDouble = 0;
                    data.LieuTong = double.TryParse(DataReader["LieuTong"].ToString(), out tempDouble) ? (double?)tempDouble : null;

                    tempDouble = 0;
                    data.LieuTC =  double.TryParse(DataReader["LieuTC"].ToString(), out tempDouble) ? (double?)tempDouble : null;
                    tempDouble = 0;
                    data.DuyTri =  double.TryParse(DataReader["DuyTri"].ToString(), out tempDouble) ? (double?)tempDouble : null;

                    tempInt = 0;
                    int.TryParse(DataReader["CachDung"].ToString(), out tempInt);
                    data.CachDung = tempInt;
                    tempInt = 0;
                    int.TryParse(DataReader["YThuc"].ToString(), out tempInt);
                    data.YThuc = tempInt;
                    tempInt = 0;
                    int.TryParse(DataReader["KhoTho"].ToString(), out tempInt);
                    data.KhoTho = tempInt;
                    tempInt = 0;
                    int.TryParse(DataReader["Phu"].ToString(), out tempInt);
                    data.Phu = tempInt;

                    data.ChiSoSinhTons = JsonConvert.DeserializeObject<ObservableCollection<ChiSoSinhTon>>(DataReader["ChiSoSinhTons"].ToString());
                    data.ThongSoMays = JsonConvert.DeserializeObject<ObservableCollection<ThongSoMay>>(DataReader["ThongSoMays"].ToString());
                    data.DienBien = DataReader["DienBien"].ToString();
                    data.YLenh = DataReader["YLenh"].ToString();

                    tempInt = 0;
                    int.TryParse(DataReader["QuaLocYLenh"].ToString(), out tempInt);
                    data.QuaLocYLenh = tempInt;
                    data.QuaLocYlenh_Text = DataReader["QuaLocYlenh_Text"].ToString();

                    tempInt = 0;
                    int.TryParse(DataReader["ThoiGian"].ToString(), out tempInt);
                    data.ThoiGian = tempInt;
                    data.ThoiGian_Text = DataReader["ThoiGian_Text"].ToString();

                    tempInt = 0;
                    int.TryParse(DataReader["QuaLoc"].ToString(), out tempInt);
                    data.QuaLoc = tempInt;
                    data.QuaLoc_Text = DataReader["QuaLoc_Text"].ToString();

                    tempInt = 0;
                    int.TryParse(DataReader["DichKhuTrung"].ToString(), out tempInt);
                    data.DichKhuTrung = tempInt;
                    data.DichKhuTrung_Text = DataReader["DichKhuTrung_Text"].ToString();


                    tempInt = 0;
                    int.TryParse(DataReader["QuaLan"].ToString(), out tempInt);
                    data.QuaLan = tempInt;

                    tempInt = 0;
                    int.TryParse(DataReader["DayLan"].ToString(), out tempInt);
                    data.DayLan = tempInt;

                    tempInt = 0;
                    int.TryParse(DataReader["TinhTrangQuaLoc"].ToString(), out tempInt);
                    data.TinhTrangQuaLoc = tempInt;
                    data.TinhTrangQuaLoc_Text = DataReader["TinhTrangQuaLoc_Text"].ToString();

                    tempInt = 0;
                    int.TryParse(DataReader["NXQuaLocKhiKetThuc"].ToString(), out tempInt);
                    data.NXQuaLocKhiKetThuc = tempInt;

                    tempInt = 0;
                    int.TryParse(DataReader["DichKetTNT"].ToString(), out tempInt);
                    data.DichKetTNT = tempInt;

                    data.ChamSocs = JsonConvert.DeserializeObject<ObservableCollection<ChamSoc>>(DataReader["ChamSocs"].ToString());

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
        public static PhieuTheoDoiDieuTriThanNhanTao GetData(MDB.MDBConnection _OracleConnection, long ID)
        {
            PhieuTheoDoiDieuTriThanNhanTao data = new PhieuTheoDoiDieuTriThanNhanTao();
            try
            {
                string sql = @"SELECT * FROM PhieuTDDTThanNhanTao where ID = :ID";
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

                    int tempInt = 0;
                    int.TryParse(DataReader["LoaiMay"].ToString(), out tempInt);
                    data.LoaiMay = tempInt;
                    data.SoMay = DataReader["SoMay"].ToString();

                    double tempDouble = 0;
                    data.CanYeuCau = double.TryParse(DataReader["CanYeuCau"].ToString(), out tempDouble) ? (double?)tempDouble : null;

                    tempDouble = 0;
                    data.CanTruocLoc = double.TryParse(DataReader["CanTruocLoc"].ToString(), out tempDouble) ? (double?)tempDouble : null;

                    tempDouble = 0;
                    data.Dat = double.TryParse(DataReader["Dat"].ToString(), out tempDouble) ? (double?)tempDouble : null;

                    tempDouble = 0;
                    data.AUF = double.TryParse(DataReader["AUF"].ToString(), out tempDouble) ? (double?)tempDouble : null;

                    tempDouble = 0;
                    data.CanSauLoc = double.TryParse(DataReader["CanSauLoc"].ToString(), out tempDouble) ? (double?)tempDouble : null;

                    tempInt = 0;
                    int.TryParse(DataReader["DuongVaoMachMau"].ToString(), out tempInt);
                    data.DuongVaoMachMau = tempInt;

                    tempDouble = 0;
                    data.Trang = double.TryParse(DataReader["Trang"].ToString(), out tempDouble) ? (double?)tempDouble : null;

                    tempInt = 0;
                    int.TryParse(DataReader["ChongDong"].ToString(), out tempInt);
                    data.ChongDong = tempInt;

                    tempDouble = 0;
                    data.LieuTong = double.TryParse(DataReader["LieuTong"].ToString(), out tempDouble) ? (double?)tempDouble : null;

                    tempDouble = 0;
                    data.LieuTC = double.TryParse(DataReader["LieuTC"].ToString(), out tempDouble) ? (double?)tempDouble : null;
                    tempDouble = 0;
                    data.DuyTri = double.TryParse(DataReader["DuyTri"].ToString(), out tempDouble) ? (double?)tempDouble : null;

                    tempInt = 0;
                    int.TryParse(DataReader["CachDung"].ToString(), out tempInt);
                    data.CachDung = tempInt;
                    tempInt = 0;
                    int.TryParse(DataReader["YThuc"].ToString(), out tempInt);
                    data.YThuc = tempInt;
                    tempInt = 0;
                    int.TryParse(DataReader["KhoTho"].ToString(), out tempInt);
                    data.KhoTho = tempInt;
                    tempInt = 0;
                    int.TryParse(DataReader["Phu"].ToString(), out tempInt);
                    data.Phu = tempInt;

                    data.ChiSoSinhTons = JsonConvert.DeserializeObject<ObservableCollection<ChiSoSinhTon>>(DataReader["ChiSoSinhTons"].ToString());
                    data.ThongSoMays = JsonConvert.DeserializeObject<ObservableCollection<ThongSoMay>>(DataReader["ThongSoMays"].ToString());
                    data.DienBien = DataReader["DienBien"].ToString();
                    data.YLenh = DataReader["YLenh"].ToString();

                    tempInt = 0;
                    int.TryParse(DataReader["QuaLocYLenh"].ToString(), out tempInt);
                    data.QuaLocYLenh = tempInt;
                    data.QuaLocYlenh_Text = DataReader["QuaLocYlenh_Text"].ToString();

                    tempInt = 0;
                    int.TryParse(DataReader["ThoiGian"].ToString(), out tempInt);
                    data.ThoiGian = tempInt;
                    data.ThoiGian_Text = DataReader["ThoiGian_Text"].ToString();

                    tempInt = 0;
                    int.TryParse(DataReader["QuaLoc"].ToString(), out tempInt);
                    data.QuaLoc = tempInt;
                    data.QuaLoc_Text = DataReader["QuaLoc_Text"].ToString();

                    tempInt = 0;
                    int.TryParse(DataReader["DichKhuTrung"].ToString(), out tempInt);
                    data.DichKhuTrung = tempInt;
                    data.DichKhuTrung_Text = DataReader["DichKhuTrung_Text"].ToString();


                    tempInt = 0;
                    int.TryParse(DataReader["QuaLan"].ToString(), out tempInt);
                    data.QuaLan = tempInt;

                    tempInt = 0;
                    int.TryParse(DataReader["DayLan"].ToString(), out tempInt);
                    data.DayLan = tempInt;

                    tempInt = 0;
                    int.TryParse(DataReader["TinhTrangQuaLoc"].ToString(), out tempInt);
                    data.TinhTrangQuaLoc = tempInt;
                    data.TinhTrangQuaLoc_Text = DataReader["TinhTrangQuaLoc_Text"].ToString();

                    tempInt = 0;
                    int.TryParse(DataReader["NXQuaLocKhiKetThuc"].ToString(), out tempInt);
                    data.NXQuaLocKhiKetThuc = tempInt;

                    tempInt = 0;
                    int.TryParse(DataReader["DichKetTNT"].ToString(), out tempInt);
                    data.DichKetTNT = tempInt;

                    data.ChamSocs = JsonConvert.DeserializeObject<ObservableCollection<ChamSoc>>(DataReader["ChamSocs"].ToString());

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

        public static bool InsertOrUpdate(MDB.MDBConnection MyConnection, ref PhieuTheoDoiDieuTriThanNhanTao phieuTheoDoi)
        {
            try
            {
                string sql = @"INSERT INTO PhieuTDDTThanNhanTao
                (
                    MAQUANLY,
                    MaBenhNhan,
                    CaLocMau,
	                ChanDoan,
	                LoaiMay,
	                SoMay,
	                CanYeuCau,
	                CanTruocLoc,
	                Dat,
	                AUF,
	                CanSauLoc,
	                DuongVaoMachMau,
	                Trang,
	                ChongDong,
	                LieuTong,
	                LieuTC,
	                DuyTri,
	                CachDung,
	                YThuc,
	                KhoTho,
	                Phu,
	                ChiSoSinhTons,
	                ThongSoMays,
	                DienBien,
	                YLenh,
	                QuaLocYLenh,
	                QuaLocYlenh_Text, 
	                ThoiGian,
	                ThoiGian_Text, 
	                QuaLoc,
	                QuaLoc_Text,
	                DichKhuTrung,
	                DichKhuTrung_Text,
	                QuaLan,
	                DayLan,
	                TinhTrangQuaLoc,
	                TinhTrangQuaLoc_Text,
	                NXQuaLocKhiKetThuc,
	                DichKetTNT,
	                ChamSocs,
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
	                :CanYeuCau,
	                :CanTruocLoc,
	                :Dat,
	                :AUF,
	                :CanSauLoc,
	                :DuongVaoMachMau,
	                :Trang,
	                :ChongDong,
	                :LieuTong,
	                :LieuTC,
	                :DuyTri,
	                :CachDung,
	                :YThuc,
	                :KhoTho,
	                :Phu,
	                :ChiSoSinhTons,
	                :ThongSoMays,
	                :DienBien,
	                :YLenh,
	                :QuaLocYLenh,
	                :QuaLocYlenh_Text, 
	                :ThoiGian,
	                :ThoiGian_Text, 
	                :QuaLoc,
	                :QuaLoc_Text,
	                :DichKhuTrung,
	                :DichKhuTrung_Text,
	                :QuaLan,
	                :DayLan,
	                :TinhTrangQuaLoc,
	                :TinhTrangQuaLoc_Text,
	                :NXQuaLocKhiKetThuc,
	                :DichKetTNT,
	                :ChamSocs,
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
                    sql = @"UPDATE PhieuTDDTThanNhanTao SET 
                    MAQUANLY = :MAQUANLY,
                    MaBenhNhan = :MaBenhNhan,
                    CaLocMau = :CaLocMau,
                    ChanDoan = :ChanDoan,
	                LoaiMay = :LoaiMay,
	                SoMay  = :SoMay,
	                CanYeuCau = :CanYeuCau,
	                CanTruocLoc = :CanTruocLoc,
	                Dat = :Dat,
	                AUF = :AUF,
	                CanSauLoc = :CanSauLoc,
	                DuongVaoMachMau = :DuongVaoMachMau,
	                Trang = :Trang,
	                ChongDong = :ChongDong,
	                LieuTong = :LieuTong,
	                LieuTC = :LieuTC,
	                DuyTri = :DuyTri,
	                CachDung = :CachDung,
	                YThuc = :YThuc,
	                KhoTho = :KhoTho,
	                Phu = :Phu,
	                ChiSoSinhTons = :ChiSoSinhTons,
	                ThongSoMays = :ThongSoMays,
	                DienBien = :DienBien,
	                YLenh = :YLenh,
	                QuaLocYLenh = :QuaLocYLenh,
	                QuaLocYlenh_Text = :QuaLocYlenh_Text, 
	                ThoiGian = :ThoiGian,
	                ThoiGian_Text = :ThoiGian_Text, 
	                QuaLoc = :QuaLoc,
	                QuaLoc_Text = :QuaLoc_Text,
	                DichKhuTrung = :DichKhuTrung,
	                DichKhuTrung_Text = :DichKhuTrung_Text,
	                QuaLan = :QuaLan,
	                DayLan = :DayLan,
	                TinhTrangQuaLoc = :TinhTrangQuaLoc,
	                TinhTrangQuaLoc_Text = :TinhTrangQuaLoc_Text,
	                NXQuaLocKhiKetThuc = :NXQuaLocKhiKetThuc,
	                DichKetTNT = :DichKetTNT,
	                ChamSocs = :ChamSocs,
	                BacSy = :BacSy,
	                MaBacSy = :MaBacSy,
 	                DieuDuong = :DieuDuong,
	                MaDieuDuong = :MaDieuDuong,
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
                Command.Parameters.Add(new MDB.MDBParameter("CanYeuCau", phieuTheoDoi.CanYeuCau));
                Command.Parameters.Add(new MDB.MDBParameter("CanTruocLoc", phieuTheoDoi.CanTruocLoc));
                Command.Parameters.Add(new MDB.MDBParameter("Dat", phieuTheoDoi.Dat));
                Command.Parameters.Add(new MDB.MDBParameter("AUF", phieuTheoDoi.AUF));
                Command.Parameters.Add(new MDB.MDBParameter("CanSauLoc", phieuTheoDoi.CanSauLoc));
                Command.Parameters.Add(new MDB.MDBParameter("DuongVaoMachMau", phieuTheoDoi.DuongVaoMachMau));
                Command.Parameters.Add(new MDB.MDBParameter("Trang", phieuTheoDoi.Trang));
                Command.Parameters.Add(new MDB.MDBParameter("ChongDong", phieuTheoDoi.ChongDong));
                Command.Parameters.Add(new MDB.MDBParameter("LieuTong", phieuTheoDoi.LieuTong));
                Command.Parameters.Add(new MDB.MDBParameter("LieuTC", phieuTheoDoi.LieuTC));
                Command.Parameters.Add(new MDB.MDBParameter("DuyTri", phieuTheoDoi.DuyTri));
                Command.Parameters.Add(new MDB.MDBParameter("CachDung", phieuTheoDoi.CachDung));
                Command.Parameters.Add(new MDB.MDBParameter("YThuc", phieuTheoDoi.YThuc));
                Command.Parameters.Add(new MDB.MDBParameter("KhoTho", phieuTheoDoi.KhoTho));
                Command.Parameters.Add(new MDB.MDBParameter("Phu", phieuTheoDoi.Phu));
                Command.Parameters.Add(new MDB.MDBParameter("ChiSoSinhTons", JsonConvert.SerializeObject(phieuTheoDoi.ChiSoSinhTons)));
                Command.Parameters.Add(new MDB.MDBParameter("ThongSoMays", JsonConvert.SerializeObject(phieuTheoDoi.ThongSoMays)));
                Command.Parameters.Add(new MDB.MDBParameter("DienBien", phieuTheoDoi.DienBien));
                Command.Parameters.Add(new MDB.MDBParameter("YLenh", phieuTheoDoi.YLenh));
                Command.Parameters.Add(new MDB.MDBParameter("QuaLocYLenh", phieuTheoDoi.QuaLocYLenh));
                Command.Parameters.Add(new MDB.MDBParameter("QuaLocYlenh_Text", phieuTheoDoi.QuaLocYlenh_Text));
                Command.Parameters.Add(new MDB.MDBParameter("ThoiGian", phieuTheoDoi.ThoiGian));
                Command.Parameters.Add(new MDB.MDBParameter("ThoiGian_Text", phieuTheoDoi.ThoiGian_Text));
                Command.Parameters.Add(new MDB.MDBParameter("QuaLoc", phieuTheoDoi.QuaLoc));
                Command.Parameters.Add(new MDB.MDBParameter("QuaLoc_Text", phieuTheoDoi.QuaLoc_Text));
                Command.Parameters.Add(new MDB.MDBParameter("DichKhuTrung", phieuTheoDoi.DichKhuTrung));
                Command.Parameters.Add(new MDB.MDBParameter("DichKhuTrung_Text", phieuTheoDoi.DichKhuTrung_Text));
                Command.Parameters.Add(new MDB.MDBParameter("QuaLan", phieuTheoDoi.QuaLan));
                Command.Parameters.Add(new MDB.MDBParameter("DayLan", phieuTheoDoi.DayLan));
                Command.Parameters.Add(new MDB.MDBParameter("TinhTrangQuaLoc", phieuTheoDoi.TinhTrangQuaLoc));
                Command.Parameters.Add(new MDB.MDBParameter("TinhTrangQuaLoc_Text", phieuTheoDoi.TinhTrangQuaLoc_Text));
                Command.Parameters.Add(new MDB.MDBParameter("NXQuaLocKhiKetThuc", phieuTheoDoi.NXQuaLocKhiKetThuc));
                Command.Parameters.Add(new MDB.MDBParameter("DichKetTNT", phieuTheoDoi.DichKetTNT));
                Command.Parameters.Add(new MDB.MDBParameter("ChamSocs", JsonConvert.SerializeObject(phieuTheoDoi.ChamSocs)));
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
                string sql = "DELETE FROM PhieuTDDTThanNhanTao WHERE ID = :ID";
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
                B.MaBenhNhan,
                B.CaLocMau,
                B.ChanDoan,
                B.LoaiMay,
                B.SoMay,
                B.CanYeuCau,
                B.CanTruocLoc,
                B.Dat,
                B.AUF,
                B.CanSauLoc,
                B.DuongVaoMachMau,
                B.Trang,
                B.ChongDong ,
                B.LieuTong,
                B.LieuTC,
                B.DuyTri,
                B.CachDung,
                B.YThuc,
                B.KhoTho,
                B.Phu,
                B.DienBien,
                B.YLenh,
                B.QuaLocYLenh,
                B.QuaLocYlenh_Text, 
                B.ThoiGian,
                B.ThoiGian_Text, 
                B.QuaLoc,
                B.QuaLoc_Text,
                B.DichKhuTrung,
                B.DichKhuTrung_Text,
                B.QuaLan,
                B.DayLan,
                B.TinhTrangQuaLoc,
                B.TinhTrangQuaLoc_Text,
                B.NXQuaLocKhiKetThuc,
                B.DichKetTNT,
                B.BacSy,
                B.MaBacSy,
                B.DieuDuong,
                B.MaDieuDuong,
                T.MABENHAN,
                H.GIOITINH,
	            H.TENBENHNHAN,
                H.SOYTE,
                H.BENHVIEN
            FROM
                PhieuTDDTThanNhanTao B
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
