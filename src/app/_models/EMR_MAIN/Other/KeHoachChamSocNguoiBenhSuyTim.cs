using EMR.KyDienTu;
using Newtonsoft.Json;
using PMS.Access;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace EMR_MAIN.DATABASE.Other
{
    public class KHCSNBST_ThoiGian
    {
        public DateTime? ThoiGian { get; set; }
        public string NhanDinh { get; set; }
        public string KeHoach { get; set; }
        public string ThucHien { get; set; }
        public string DanhGia { get; set; }
        public string MaDD { get; set; }
        public string TenDD
        {
            get
            {
                string temp = String.Empty;
                temp = NhanVienFunc.ListNhanVien.Where(x => x.MaNhanVien == MaDD).FirstOrDefault().HoVaTen;
                return temp;
            }
        }
    }
    public class KHCSNBST_LoaiCS
    {
        public string ChamSoc { get; set; }
        public string NhanDinh { get; set; }
        public string KeHoach { get; set; }
        public string ThucHien { get; set; }
        public string DanhGia { get; set; }
        public string MaDD { get; set; }
        public string TenDD
        {
            get
            {
                string temp = String.Empty;
                try
                {
                    temp = NhanVienFunc.ListNhanVien.Where(x => x.MaNhanVien == Common.ConDBNull(MaDD)).FirstOrDefault().HoVaTen;

                }
                catch
                {

                }finally
                { }
                return temp;
            }
        }
    }
    public class KeHoachChamSocNguoiBenhSuyTim : ThongTinKy
    {
        public KeHoachChamSocNguoiBenhSuyTim()
        {
            TableName = "KeHoachCSNBSuyTim";
            TablePrimaryKeyName = "ID";
            IDMauPhieu = (int)DanhMucPhieu.KHCSNBST;
            TenMauPhieu = DanhMucPhieu.KHCSNBST.Description();
            LstKHCSThoiGian = new List<KHCSNBST_ThoiGian>();
            LstKHCSLoaiCS = new List<KHCSNBST_LoaiCS>();
    }
        [MoTaDuLieu("Mã định danh")]
		public long ID { get; set; }
        [MoTaDuLieu("Mã quản lý: mã duy nhất trong 1 đợt khám chữa bệnh (kcb), không trùng giữa các đợt kcb khác nhau","",1)]
		public decimal MaQuanLy { get; set; }
        [MoTaDuLieu("Mã bệnh nhân")]
		public string MaBenhNhan { get; set; }
        public string HoVaTenBN { get; set; }
        [MoTaDuLieu("Tuổi bệnh nhân")]
		public string Tuoi { get; set; }
        [MoTaDuLieu("Giới tính bệnh nhân")]
		public string GioiTinh { get; set; }
        public string SoGiuong { get; set; }
        [MoTaDuLieu("Buồng")]
		public string Buong { get; set; }
        [MoTaDuLieu("Chẩn đoán bệnh")]
		public string ChanDoan { get; set; }
        public DateTime? NgayGio { get; set; }
        public DateTime? NgayGio_Gio { get; set; }
        public bool[] TriGiacArray { get; } = new bool[] { false, false, false };
        public int TriGiac
        {
            get
            {
                return Array.IndexOf(TriGiacArray, true) + 1;
            }
            set
            {
                for (int i = 0; i < TriGiacArray.Length; i++)
                {
                    if (i == (value - 1)) TriGiacArray[i] = true;
                    else TriGiacArray[i] = false;
                }
            }
        }
        public double? NhipTim { get; set; }
        [MoTaDuLieu("Huyết áp")]
		public string HuyetAp { get; set; }
        public double? NhietDo { get; set; }
        public bool[] TuThoArray { get; } = new bool[] { false, false, false };
        public string TuTho
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < TuThoArray.Length; i++)
                    temp += (TuThoArray[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        TuThoArray[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public string TuTho_Text { get; set; }
        public bool[] KhoThoArray { get; } = new bool[] { false, false };
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
        public bool[] HoTroArray { get; } = new bool[] { false, false };
        public string HoTro
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < HoTroArray.Length; i++)
                    temp += (HoTroArray[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        HoTroArray[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public double? HoTro_Number { get; set; }
        public double? SpO2 { get; set; }
        public bool[] DaArray { get; } = new bool[] { false, false, false };
        public int Da
        {
            get
            {
                return Array.IndexOf(DaArray, true) + 1;
            }
            set
            {
                for (int i = 0; i < DaArray.Length; i++)
                {
                    if (i == (value - 1)) DaArray[i] = true;
                    else DaArray[i] = false;
                }
            }
        }
        public string Da_Text { get; set; }
        public bool[] NiemMacArray { get; } = new bool[] { false, false, false, false };
        public int NiemMac
        {
            get
            {
                return Array.IndexOf(NiemMacArray, true) + 1;
            }
            set
            {
                for (int i = 0; i < NiemMacArray.Length; i++)
                {
                    if (i == (value - 1)) NiemMacArray[i] = true;
                    else NiemMacArray[i] = false;
                }
            }
        }
        public bool[] BungArray { get; } = new bool[] { false, false, false, false };
        public int Bung
        {
            get
            {
                return Array.IndexOf(BungArray, true) + 1;
            }
            set
            {
                for (int i = 0; i < BungArray.Length; i++)
                {
                    if (i == (value - 1)) BungArray[i] = true;
                    else BungArray[i] = false;
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
        public bool[] TMCoArray { get; } = new bool[] { false, false };
        public int TMCo
        {
            get
            {
                return Array.IndexOf(TMCoArray, true) + 1;
            }
            set
            {
                for (int i = 0; i < TMCoArray.Length; i++)
                {
                    if (i == (value - 1)) TMCoArray[i] = true;
                    else TMCoArray[i] = false;
                }
            }
        }
        public bool[] DinhDuongArray { get; } = new bool[] { false, false, false };
        public int DinhDuong
        {
            get
            {
                return Array.IndexOf(DinhDuongArray, true) + 1;
            }
            set
            {
                for (int i = 0; i < DinhDuongArray.Length; i++)
                {
                    if (i == (value - 1)) DinhDuongArray[i] = true;
                    else DinhDuongArray[i] = false;
                }
            }
        }
        public string DinhDuong_Text { get; set; }
        public string DuongTruyen_ViTri { get; set; }
        public DateTime? DuongTruyen_NgayDat { get; set; }
        public bool Loet_Check { get; set; }
        public string Loet_ViTri { get; set; }
        public string Loet_Do { get; set; }
        public bool Dau_Check { get; set; }
        public string Dau_ViTri { get; set; }
        public double? Dau_Diem { get; set; }
        public bool[] VanDongArray { get; } = new bool[] { false, false };
        public int VanDong
        {
            get
            {
                return Array.IndexOf(VanDongArray, true) + 1;
            }
            set
            {
                for (int i = 0; i < VanDongArray.Length; i++)
                {
                    if (i == (value - 1)) VanDongArray[i] = true;
                    else VanDongArray[i] = false;
                }
            }
        }
        public bool[] VSCNArray { get; } = new bool[] { false, false };
        public int VSCN
        {
            get
            {
                return Array.IndexOf(VSCNArray, true) + 1;
            }
            set
            {
                for (int i = 0; i < VSCNArray.Length; i++)
                {
                    if (i == (value - 1)) VSCNArray[i] = true;
                    else VSCNArray[i] = false;
                }
            }
        }
        public bool[] GiacNguArray { get; } = new bool[] { false, false };
        public int GiacNgu
        {
            get
            {
                return Array.IndexOf(GiacNguArray, true) + 1;
            }
            set
            {
                for (int i = 0; i < GiacNguArray.Length; i++)
                {
                    if (i == (value - 1)) GiacNguArray[i] = true;
                    else GiacNguArray[i] = false;
                }
            }
        }
        public double? CanNang { get; set; }
        public double? DichVao { get; set; }
        public string DaiTien { get; set; }
        public int? DaiTien_Lan { get; set; }
        public bool[] BaiTietArray { get; } = new bool[] { false, false };
        public int BaiTiet
        {
            get
            {
                return Array.IndexOf(BaiTietArray, true) + 1;
            }
            set
            {
                for (int i = 0; i < BaiTietArray.Length; i++)
                {
                    if (i == (value - 1)) BaiTietArray[i] = true;
                    else BaiTietArray[i] = false;
                }
            }
        }
        public double? NT24h { get; set; }
        public string Ure { get; set; }
        public string NTBNP { get; set; }
        public bool[] RangMiengArray { get; } = new bool[] { false, false };
        public int RangMieng
        {
            get
            {
                return Array.IndexOf(RangMiengArray, true) + 1;
            }
            set
            {
                for (int i = 0; i < RangMiengArray.Length; i++)
                {
                    if (i == (value - 1)) RangMiengArray[i] = true;
                    else RangMiengArray[i] = false;
                }
            }
        }
        public bool[] LuoiArray { get; } = new bool[] { false, false };
        public int Luoi
        {
            get
            {
                return Array.IndexOf(LuoiArray, true) + 1;
            }
            set
            {
                for (int i = 0; i < LuoiArray.Length; i++)
                {
                    if (i == (value - 1)) LuoiArray[i] = true;
                    else LuoiArray[i] = false;
                }
            }
        }
        // Ke Hoach Cham Soc
        public bool KH_TheoDoiDHST { get; set; }
        public string TH_NhanBanGiaoBN { get; set; }
        public bool TH_HuongDan { get; set; }
        public bool TH_TheoDoi { get; set; }

        public bool TH_CanTrongLuong { get; set; }

        public bool TH_CanNuocTieu { get; set; }
        public bool TH_DinhDuong { get; set; }
        public bool TH_VSCN { get; set; }
        public bool KH_XucMieng { get; set; }
        public string KH_ChamSocCap { get; set; }
        //
        public List<KHCSNBST_ThoiGian> LstKHCSThoiGian { get; set; }
        public List<KHCSNBST_LoaiCS> LstKHCSLoaiCS { get; set; }
        // danh gia
        public string DanhGia { get; set; }
        public int? DanhGia_XucMieng { get; set; }

        public string TenDieuDuong { get; set; }
        public string MaTenDieuDuong { get; set; }



        public string TH_GhiChu { get; set; }
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
    public class KeHoachChamSocNguoiBenhSuyTimFunc
    {
        public const string TableName = "KeHoachCSNBSuyTim";
        public const string TablePrimaryKeyName = "ID";
        public static List<KeHoachChamSocNguoiBenhSuyTim> GetListData(MDB.MDBConnection _OracleConnection, decimal maquanly)
        {
            List<KeHoachChamSocNguoiBenhSuyTim> list = new List<KeHoachChamSocNguoiBenhSuyTim>();
            try
            {
                string sql = @"SELECT * FROM KeHoachCSNBSuyTim where MaQuanLy = :MaQuanLy";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, _OracleConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", maquanly));
                MDB.MDBDataReader DataReader = Command.ExecuteReader();
                while (DataReader.Read())
                {
                    KeHoachChamSocNguoiBenhSuyTim data = new KeHoachChamSocNguoiBenhSuyTim();
                    data.ID = Convert.ToInt64(DataReader.GetLong("ID").ToString());
                    data.MaQuanLy = maquanly;
                    data.MaBenhNhan = DataReader["MaBenhNhan"].ToString();
                    data.HoVaTenBN = XemBenhAn._HanhChinhBenhNhan.TenBenhNhan;
                    data.Tuoi = XemBenhAn._HanhChinhBenhNhan.Tuoi;
                    data.GioiTinh = XemBenhAn._HanhChinhBenhNhan.GioiTinh.Description();
                    data.SoGiuong = DataReader["SoGiuong"].ToString();
                    data.Buong = DataReader["Buong"].ToString();
                    data.ChanDoan = DataReader["ChanDoan"].ToString();
                    data.NgayGio = DataReader["NgayGio"] == DBNull.Value ? (DateTime?)null : DataReader.GetDate("NgayGio");
                    data.NgayGio_Gio = data.NgayGio;
                    data.TriGiac = DataReader.GetInt("TriGiac");
                    double tempDouble = 0;
                    data.NhipTim = double.TryParse(DataReader["NhipTim"].ToString(), out tempDouble) ? (double?)tempDouble : null;
                    data.HuyetAp = DataReader["HuyetAp"].ToString();
                    tempDouble = 0;
                    data.NhietDo = double.TryParse(DataReader["NhietDo"].ToString(), out tempDouble) ? (double?)tempDouble : null;
                    data.TuTho = DataReader["TuTho"].ToString();
                    data.TuTho_Text = DataReader["TuTho_Text"].ToString();
                    data.KhoTho = DataReader["KhoTho"].ToString();
                    data.HoTro = DataReader["HoTro"].ToString();
                    tempDouble = 0;
                    data.HoTro_Number = double.TryParse(DataReader["HoTro_Number"].ToString(), out tempDouble) ? (double?)tempDouble : null;
                    tempDouble = 0;
                    data.SpO2 = double.TryParse(DataReader["SpO2"].ToString(), out tempDouble) ? (double?)tempDouble : null;
                    data.Da = DataReader.GetInt("Da");
                    data.Da_Text = DataReader["Da_Text"].ToString();
                    data.NiemMac = DataReader.GetInt("NiemMac");
                    data.Bung = DataReader.GetInt("Bung");
                    data.Phu = DataReader.GetInt("Phu");
                    data.TMCo = DataReader.GetInt("TMCo");
                    data.DinhDuong = DataReader.GetInt("DinhDuong");
                    data.DinhDuong_Text = DataReader["DinhDuong_Text"].ToString();
                    data.DuongTruyen_ViTri = DataReader["DuongTruyen_ViTri"].ToString();
                    data.DuongTruyen_NgayDat = DataReader["DuongTruyen_NgayDat"] == DBNull.Value ? (DateTime?)null : DataReader.GetDate("DuongTruyen_NgayDat");
                    data.Loet_Check = DataReader["Loet_Check"].ToString().Equals("1") ? true: false;
                    data.Loet_ViTri = DataReader["Loet_ViTri"].ToString();
                    data.Loet_Do = DataReader["Loet_Do"].ToString();
                    data.Dau_Check = DataReader["Dau_Check"].ToString().Equals("1") ? true : false;
                    data.Dau_ViTri = DataReader["Dau_ViTri"].ToString();
                    tempDouble = 0;
                    data.Dau_Diem = double.TryParse(DataReader["Dau_Diem"].ToString(), out tempDouble) ? (double?)tempDouble : null;
                    data.VanDong = DataReader.GetInt("VanDong");
                    data.VSCN = DataReader.GetInt("VSCN");
                    data.GiacNgu = DataReader.GetInt("GiacNgu");
                    tempDouble = 0;
                    data.CanNang = double.TryParse(DataReader["CanNang"].ToString(), out tempDouble) ? (double?)tempDouble : null;
                    tempDouble = 0;
                    data.DichVao = double.TryParse(DataReader["DichVao"].ToString(), out tempDouble) ? (double?)tempDouble : null;
                    data.DaiTien = DataReader["DaiTien"].ToString();
                    tempDouble = 0;
                    data.DaiTien_Lan = DataReader.GetInt("DaiTien_Lan");
                    data.BaiTiet = DataReader.GetInt("BaiTiet");
                    tempDouble = 0;
                    data.NT24h = double.TryParse(DataReader["NT24h"].ToString(), out tempDouble) ? (double?)tempDouble : null;
                    data.Ure = DataReader["Ure"].ToString();
                    data.NTBNP = DataReader["NTBNP"].ToString();
                    data.RangMieng = DataReader.GetInt("RangMieng");
                    data.Luoi = DataReader.GetInt("Luoi");
                    data.KH_TheoDoiDHST = DataReader["KH_TheoDoiDHST"].ToString().Equals("1") ? true : false;
                    data.TH_NhanBanGiaoBN = DataReader["TH_NhanBanGiaoBN"].ToString();
                    data.TH_HuongDan = DataReader["TH_HuongDan"].ToString().Equals("1") ? true : false;
                    data.TH_TheoDoi = DataReader["TH_TheoDoi"].ToString().Equals("1") ? true : false;
                    data.TH_CanTrongLuong = DataReader["TH_CanTrongLuong"].ToString().Equals("1") ? true : false;
                    data.TH_CanNuocTieu = DataReader["TH_CanNuocTieu"].ToString().Equals("1") ? true : false;
                    data.TH_DinhDuong = DataReader["TH_DinhDuong"].ToString().Equals("1") ? true : false;
                    data.TH_VSCN = DataReader["TH_VSCN"].ToString().Equals("1") ? true : false;
                    data.KH_XucMieng = DataReader["KH_XucMieng"].ToString().Equals("1") ? true : false;
                    data.KH_ChamSocCap = DataReader["KH_ChamSocCap"].ToString();
                    data.DanhGia = DataReader["DanhGia"].ToString();
                    int intTemp = 0;
                    data.DanhGia_XucMieng = int.TryParse(DataReader["DanhGia_XucMieng"].ToString(), out intTemp) ? (int?)intTemp : null;
                    data.LstKHCSThoiGian = JsonConvert.DeserializeObject<List<KHCSNBST_ThoiGian>>(Common.ConDBNull(DataReader["LstKHCSThoiGian"]));
                    data.LstKHCSLoaiCS = JsonConvert.DeserializeObject<List<KHCSNBST_LoaiCS>>(Common.ConDBNull(DataReader["LstKHCSLoaiCS"]));
                    data.TenDieuDuong = DataReader["TenDieuDuong"].ToString();
                    data.MaTenDieuDuong = DataReader["MaTenDieuDuong"].ToString();
                    data.TH_GhiChu = DataReader["TH_GhiChu"].ToString();
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
        public static bool InsertOrUpdate(MDB.MDBConnection MyConnection, ref KeHoachChamSocNguoiBenhSuyTim keHoach)
        {
            try
            {
                string sql = @"INSERT INTO KeHoachCSNBSuyTim
                (
                    MAQUANLY,
                    MaBenhNhan,
                    SoGiuong,
	                Buong,
	                ChanDoan,
	                NgayGio,
	                TriGiac,
	                NhipTim,
	                HuyetAp,
	                NhietDo,
	                TuTho,
	                TuTho_Text,
	                KhoTho,
	                HoTro,
	                HoTro_Number,
	                SpO2,
	                Da,
	                Da_Text,
	                NiemMac,
	                Bung,
	                Phu,
	                TMCo,
	                DinhDuong,
	                DinhDuong_Text,
	                DuongTruyen_ViTri,
	                DuongTruyen_NgayDat,
	                Loet_ViTri,
	                Loet_Do,
	                Dau_ViTri,
	                Dau_Diem,
	                VanDong,
	                VSCN,
	                GiacNgu,
	                CanNang,
	                DichVao,
	                DaiTien,
	                DaiTien_Lan,
	                BaiTiet,
	                NT24h,
	                Ure,
	                NTBNP,
	                RangMieng,
	                Luoi,
	                KH_TheoDoiDHST,
	                TH_NhanBanGiaoBN,
	                TH_HuongDan,
	                TH_TheoDoi,
	                TH_CanTrongLuong,
	                TH_CanNuocTieu,
	                TH_DinhDuong,
	                TH_VSCN,
	                KH_XucMieng,
	                KH_ChamSocCap,
	                DanhGia,
	                DanhGia_XucMieng,LstKHCSThoiGian,LstKHCSLoaiCS,
	                TenDieuDuong,
	                MaTenDieuDuong,
                    Loet_Check,
                    Dau_Check,
                    TH_GhiChu,
                    NGUOITAO,
                    NGUOISUA,
                    NGAYTAO,
                    NGAYSUA)  VALUES
                 (
				    :MAQUANLY,
                    :MaBenhNhan,
                    :SoGiuong,
                    :Buong,
                    :ChanDoan,
                    :NgayGio,
                    :TriGiac,
                    :NhipTim,
                    :HuyetAp,
                    :NhietDo,
                    :TuTho,
                    :TuTho_Text,
                    :KhoTho,
                    :HoTro,
                    :HoTro_Number,
                    :SpO2,
                    :Da,
                    :Da_Text,
                    :NiemMac,
                    :Bung,
                    :Phu,
                    :TMCo,
                    :DinhDuong,
                    :DinhDuong_Text,
                    :DuongTruyen_ViTri,
                    :DuongTruyen_NgayDat,
                    :Loet_ViTri,
                    :Loet_Do,
                    :Dau_ViTri,
                    :Dau_Diem,
                    :VanDong,
                    :VSCN,
                    :GiacNgu,
                    :CanNang,
                    :DichVao,
                    :DaiTien,
                    :DaiTien_Lan,
                    :BaiTiet,
                    :NT24h,
                    :Ure,
                    :NTBNP,
                    :RangMieng,
                    :Luoi,
                    :KH_TheoDoiDHST,
                    :TH_NhanBanGiaoBN,
                    :TH_HuongDan,
                    :TH_TheoDoi,
                    :TH_CanTrongLuong,
                    :TH_CanNuocTieu,
                    :TH_DinhDuong,
                    :TH_VSCN,
                    :KH_XucMieng,
                    :KH_ChamSocCap,
                    :DanhGia,
                    :DanhGia_XucMieng, :LstKHCSThoiGian, :LstKHCSLoaiCS,
                    :TenDieuDuong,
                    :MaTenDieuDuong,
                    :Loet_Check,
                    :Dau_Check,
                    :TH_GhiChu,
                    :NGUOITAO,
                    :NGUOISUA,
                    :NGAYTAO,
                    :NGAYSUA
                 )  RETURNING ID INTO :ID";
                if (keHoach.ID != 0)
                {
                    sql = @"UPDATE KeHoachCSNBSuyTim SET 
                    MAQUANLY = :MAQUANLY,
                    MaBenhNhan = :MaBenhNhan,
                    SoGiuong = :SoGiuong,
                    Buong = :Buong,
                    ChanDoan = :ChanDoan,
                    NgayGio = :NgayGio,
                    TriGiac = :TriGiac,
                    NhipTim = :NhipTim,
                    HuyetAp = :HuyetAp,
                    NhietDo = :NhietDo,
                    TuTho = :TuTho,
                    TuTho_Text = :TuTho_Text,
                    KhoTho = :KhoTho,
                    HoTro = :HoTro,
                    HoTro_Number = :HoTro_Number,
                    SpO2 = :SpO2,
                    Da = :Da,
                    Da_Text = :Da_Text,
                    NiemMac = :NiemMac,
                    Bung = :Bung,
                    Phu = :Phu,
                    TMCo = :TMCo,
                    DinhDuong = :DinhDuong,
                    DinhDuong_Text = :DinhDuong_Text,
                    DuongTruyen_ViTri = :DuongTruyen_ViTri,
                    DuongTruyen_NgayDat = :DuongTruyen_NgayDat,
                    Loet_ViTri = :Loet_ViTri,
                    Loet_Do = :Loet_Do,
                    Dau_ViTri = :Dau_ViTri,
                    Dau_Diem = :Dau_Diem,
                    VanDong = :VanDong,
                    VSCN = :VSCN,
                    GiacNgu = :GiacNgu,
                    CanNang = :CanNang,
                    DichVao = :DichVao,
                    DaiTien = :DaiTien,
                    DaiTien_Lan = :DaiTien_Lan,
                    BaiTiet = :BaiTiet,
                    NT24h = :NT24h,
                    Ure = :Ure,
                    NTBNP = :NTBNP,
                    RangMieng = :RangMieng,
                    Luoi = :Luoi,
                    KH_TheoDoiDHST = :KH_TheoDoiDHST,
                    TH_NhanBanGiaoBN = :TH_NhanBanGiaoBN,
                    TH_HuongDan = :TH_HuongDan,
                    TH_TheoDoi = :TH_TheoDoi,
                    TH_CanTrongLuong = :TH_CanTrongLuong,
                    TH_CanNuocTieu = :TH_CanNuocTieu,
                    TH_DinhDuong = :TH_DinhDuong,
                    TH_VSCN = :TH_VSCN,
                    KH_XucMieng = :KH_XucMieng,
                    KH_ChamSocCap = :KH_ChamSocCap,
                    DanhGia = :DanhGia,
                    DanhGia_XucMieng = :DanhGia_XucMieng, LstKHCSThoiGian = :LstKHCSThoiGian,LstKHCSLoaiCS = :LstKHCSLoaiCS,
                    TenDieuDuong = :TenDieuDuong,
                    MaTenDieuDuong = :MaTenDieuDuong,
                    Loet_Check = :Loet_Check,
                    Dau_Check = :Dau_Check,
                    TH_GhiChu = :TH_GhiChu,
                    NGUOISUA = :NGUOISUA,
                    NGAYSUA = :NGAYSUA 
                    WHERE ID = " + keHoach.ID;
                }
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MAQUANLY", keHoach.MaQuanLy));
                Command.Parameters.Add(new MDB.MDBParameter("MaBenhNhan", keHoach.MaBenhNhan));
                Command.Parameters.Add(new MDB.MDBParameter("SoGiuong", keHoach.SoGiuong));
                Command.Parameters.Add(new MDB.MDBParameter("Buong", keHoach.Buong));
                Command.Parameters.Add(new MDB.MDBParameter("ChanDoan", keHoach.ChanDoan));
                DateTime? Ngay = keHoach.NgayGio.HasValue ? keHoach.NgayGio.Value.Add(new TimeSpan(0, 0, 0)) : (DateTime?) null;
                var NgayGio = Ngay;
                if (Ngay != null)
                {
                    var Gio = keHoach.NgayGio_Gio.HasValue ? keHoach.NgayGio_Gio.Value.TimeOfDay : new TimeSpan(0, 0, 0);
                    NgayGio = Ngay + Gio;
                }
                Command.Parameters.Add(new MDB.MDBParameter("NgayGio", NgayGio));
                Command.Parameters.Add(new MDB.MDBParameter("TriGiac", keHoach.TriGiac));
                Command.Parameters.Add(new MDB.MDBParameter("NhipTim", keHoach.NhipTim));
                Command.Parameters.Add(new MDB.MDBParameter("HuyetAp", keHoach.HuyetAp));
                Command.Parameters.Add(new MDB.MDBParameter("NhietDo", keHoach.NhietDo));
                Command.Parameters.Add(new MDB.MDBParameter("TuTho", keHoach.TuTho));
                Command.Parameters.Add(new MDB.MDBParameter("TuTho_Text", keHoach.TuTho_Text));
                Command.Parameters.Add(new MDB.MDBParameter("KhoTho", keHoach.KhoTho));
                Command.Parameters.Add(new MDB.MDBParameter("HoTro", keHoach.HoTro));
                Command.Parameters.Add(new MDB.MDBParameter("HoTro_Number", keHoach.HoTro_Number));
                Command.Parameters.Add(new MDB.MDBParameter("SpO2", keHoach.SpO2));
                Command.Parameters.Add(new MDB.MDBParameter("Da", keHoach.Da));
                Command.Parameters.Add(new MDB.MDBParameter("Da_Text", keHoach.Da_Text));
                Command.Parameters.Add(new MDB.MDBParameter("NiemMac", keHoach.NiemMac));
                Command.Parameters.Add(new MDB.MDBParameter("Bung", keHoach.Bung));
                Command.Parameters.Add(new MDB.MDBParameter("Phu", keHoach.Phu));
                Command.Parameters.Add(new MDB.MDBParameter("TMCo", keHoach.TMCo));
                Command.Parameters.Add(new MDB.MDBParameter("DinhDuong", keHoach.DinhDuong));
                Command.Parameters.Add(new MDB.MDBParameter("DinhDuong_Text", keHoach.DinhDuong_Text));
                Command.Parameters.Add(new MDB.MDBParameter("DuongTruyen_ViTri", keHoach.DuongTruyen_ViTri));
                Command.Parameters.Add(new MDB.MDBParameter("DuongTruyen_NgayDat", keHoach.DuongTruyen_NgayDat));
                Command.Parameters.Add(new MDB.MDBParameter("Loet_ViTri", keHoach.Loet_ViTri));
                Command.Parameters.Add(new MDB.MDBParameter("Loet_Do", keHoach.Loet_Do));
                Command.Parameters.Add(new MDB.MDBParameter("Dau_ViTri", keHoach.Dau_ViTri));
                Command.Parameters.Add(new MDB.MDBParameter("Dau_Diem", keHoach.Dau_Diem));
                Command.Parameters.Add(new MDB.MDBParameter("VanDong", keHoach.VanDong));
                Command.Parameters.Add(new MDB.MDBParameter("VSCN", keHoach.VSCN));
                Command.Parameters.Add(new MDB.MDBParameter("GiacNgu", keHoach.GiacNgu));
                Command.Parameters.Add(new MDB.MDBParameter("CanNang", keHoach.CanNang));
                Command.Parameters.Add(new MDB.MDBParameter("DichVao", keHoach.DichVao));
                Command.Parameters.Add(new MDB.MDBParameter("DaiTien", keHoach.DaiTien));
                Command.Parameters.Add(new MDB.MDBParameter("DaiTien_Lan", keHoach.DaiTien_Lan));
                Command.Parameters.Add(new MDB.MDBParameter("BaiTiet", keHoach.BaiTiet));
                Command.Parameters.Add(new MDB.MDBParameter("NT24h", keHoach.NT24h));
                Command.Parameters.Add(new MDB.MDBParameter("Ure", keHoach.Ure));
                Command.Parameters.Add(new MDB.MDBParameter("NTBNP", keHoach.NTBNP));
                Command.Parameters.Add(new MDB.MDBParameter("RangMieng", keHoach.RangMieng));
                Command.Parameters.Add(new MDB.MDBParameter("Luoi", keHoach.Luoi));
                Command.Parameters.Add(new MDB.MDBParameter("KH_TheoDoiDHST", keHoach.KH_TheoDoiDHST ? 1 : 0));
                Command.Parameters.Add(new MDB.MDBParameter("TH_NhanBanGiaoBN", keHoach.TH_NhanBanGiaoBN));
                Command.Parameters.Add(new MDB.MDBParameter("TH_HuongDan", keHoach.TH_HuongDan ? 1 : 0));
                Command.Parameters.Add(new MDB.MDBParameter("TH_TheoDoi", keHoach.TH_TheoDoi ? 1 : 0));
                Command.Parameters.Add(new MDB.MDBParameter("TH_CanTrongLuong", keHoach.TH_CanTrongLuong ? 1 : 0));
                Command.Parameters.Add(new MDB.MDBParameter("TH_CanNuocTieu", keHoach.TH_CanNuocTieu ? 1 : 0));
                Command.Parameters.Add(new MDB.MDBParameter("TH_DinhDuong", keHoach.TH_DinhDuong ? 1 : 0));
                Command.Parameters.Add(new MDB.MDBParameter("TH_VSCN", keHoach.TH_VSCN ? 1 : 0));
                Command.Parameters.Add(new MDB.MDBParameter("KH_XucMieng", keHoach.KH_XucMieng ? 1 : 0));
                Command.Parameters.Add(new MDB.MDBParameter("KH_ChamSocCap", keHoach.KH_ChamSocCap));
                Command.Parameters.Add(new MDB.MDBParameter("DanhGia", keHoach.DanhGia));
                Command.Parameters.Add(new MDB.MDBParameter("DanhGia_XucMieng", keHoach.DanhGia_XucMieng));
                Command.Parameters.Add(new MDB.MDBParameter("LstKHCSThoiGian", JsonConvert.SerializeObject(keHoach.LstKHCSThoiGian)));
                Command.Parameters.Add(new MDB.MDBParameter("LstKHCSLoaiCS", JsonConvert.SerializeObject(keHoach.LstKHCSLoaiCS)));
                Command.Parameters.Add(new MDB.MDBParameter("TenDieuDuong", keHoach.TenDieuDuong));
                Command.Parameters.Add(new MDB.MDBParameter("MaTenDieuDuong", keHoach.MaTenDieuDuong));

                Command.Parameters.Add(new MDB.MDBParameter("Loet_Check", keHoach.Loet_Check ? 1:0));
                Command.Parameters.Add(new MDB.MDBParameter("Dau_Check", keHoach.Dau_Check ? 1:0));
                Command.Parameters.Add(new MDB.MDBParameter("TH_GhiChu", keHoach.TH_GhiChu));
                Command.Parameters.Add(new MDB.MDBParameter("NGUOISUA", keHoach.NguoiSua));
                Command.Parameters.Add(new MDB.MDBParameter("NGAYSUA", keHoach.NgaySua));
                if (keHoach.ID == 0)
                {
                    Command.Parameters.Add(new MDB.MDBParameter("ID", keHoach.ID));
                    Command.Parameters.Add(new MDB.MDBParameter("NGUOITAO", keHoach.NguoiTao));
                    Command.Parameters.Add(new MDB.MDBParameter("NGAYTAO", keHoach.NgayTao));
                }
                Command.BindByName = true;
                int n = Command.ExecuteNonQuery();
                if (keHoach.ID == 0)
                {
                    long nextval = Convert.ToInt64((Command.Parameters["ID"] as MDB.MDBParameter).Value);
                    keHoach.ID = nextval;
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
                string sql = "DELETE FROM KeHoachCSNBSuyTim WHERE ID = :ID";
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
                H.TenBenhNhan,
                H.Tuoi,
                H.GioiTinh,
                T.KHOA
            FROM
                KeHoachCSNBSuyTim B
                LEFT JOIN HANHCHINHBENHNHAN H ON B.MABENHNHAN = H.MABENHNHAN
                LEFT JOIN THONGTINDIEUTRI T ON B.MAQUANLY = T.MAQUANLY
            WHERE
                ID = " + id;

            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
            MDB.MDBDataAdapter adt = new MDB.MDBDataAdapter(Command);
            var ds = new DataSet();

            adt.Fill(ds, "KH");
            return ds;
        }
    }
}
