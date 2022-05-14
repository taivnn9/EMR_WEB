using EMR.KyDienTu;
using PMS.Access;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMR_MAIN.DATABASE.Other
{
    public class KeHoachChamSocNBSauCanThiepTimMach : ThongTinKy
    {
        public KeHoachChamSocNBSauCanThiepTimMach()
        {
            TableName = "KeHoachCSNBSauTimMach";
            TablePrimaryKeyName = "ID";
            IDMauPhieu = (int)DanhMucPhieu.KHCSNBSCTTM;
            TenMauPhieu = DanhMucPhieu.KHCSNBSCTTM.Description();

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
        public DateTime? NgayCanThiep { get; set; }
        [MoTaDuLieu("Chẩn đoán bệnh sau can thiệp")]
		public string ChanDoanSauCanThiep { get; set; }
        public DateTime? GioVeKhoa { get; set; }
        public DateTime? NgayGio { get; set; }
        public string ChamSocCap { get; set; }
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
        public bool[] NhipTimArray { get; } = new bool[] { false, false };
        public int NhipTim
        {
            get
            {
                return Array.IndexOf(NhipTimArray, true) + 1;
            }
            set
            {
                for (int i = 0; i < NhipTimArray.Length; i++)
                {
                    if (i == (value - 1)) NhipTimArray[i] = true;
                    else NhipTimArray[i] = false;
                }
            }
        }
        public bool[] HuyetApArray { get; } = new bool[] { false, false, false };
        public int HuyetAp
        {
            get
            {
                return Array.IndexOf(HuyetApArray, true) + 1;
            }
            set
            {
                for (int i = 0; i < HuyetApArray.Length; i++)
                {
                    if (i == (value - 1)) HuyetApArray[i] = true;
                    else HuyetApArray[i] = false;
                }
            }
        }
        public bool[] TuThoArray { get; } = new bool[] { false, false };
        public int TuTho
        {
            get
            {
                return Array.IndexOf(TuThoArray, true) + 1;
            }
            set
            {
                for (int i = 0; i < TuThoArray.Length; i++)
                {
                    if (i == (value - 1)) TuThoArray[i] = true;
                    else TuThoArray[i] = false;
                }
            }
        }
        public bool[] HoTroArray { get; } = new bool[] { false, false };
        public int HoTro
        {
            get
            {
                return Array.IndexOf(HoTroArray, true) + 1;
            }
            set
            {
                for (int i = 0; i < HoTroArray.Length; i++)
                {
                    if (i == (value - 1)) HoTroArray[i] = true;
                    else HoTroArray[i] = false;
                }
            }
        }
        public double? HoTro_Number { get; set; }
        public double? SpO2 { get; set; }
        public bool[] ThanNhietArray { get; } = new bool[] { false, false, false };
        public int ThanNhiet
        {
            get
            {
                return Array.IndexOf(ThanNhietArray, true) + 1;
            }
            set
            {
                for (int i = 0; i < ThanNhietArray.Length; i++)
                {
                    if (i == (value - 1)) ThanNhietArray[i] = true;
                    else ThanNhietArray[i] = false;
                }
            }
        }
        public bool[] DauArray { get; } = new bool[] { false, false };
        public int Dau
        {
            get
            {
                return Array.IndexOf(DauArray, true) + 1;
            }
            set
            {
                for (int i = 0; i < DauArray.Length; i++)
                {
                    if (i == (value - 1)) DauArray[i] = true;
                    else DauArray[i] = false;
                }
            }
        }
        public string Dau_Text { get; set; }
        public double? Dau_Diem { get; set; }
        public bool[] ViTriCanThiepArray { get; } = new bool[] { false, false, false, false, false, false };
        public string ViTriCanThiep
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < ViTriCanThiepArray.Length; i++)
                    temp += (ViTriCanThiepArray[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        ViTriCanThiepArray[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public bool[] ChiBenCT1Array { get; } = new bool[] { false, false, false };
        public int ChiBenCT1
        {
            get
            {
                return Array.IndexOf(ChiBenCT1Array, true) + 1;
            }
            set
            {
                for (int i = 0; i < ChiBenCT1Array.Length; i++)
                {
                    if (i == (value - 1)) ChiBenCT1Array[i] = true;
                    else ChiBenCT1Array[i] = false;
                }
            }
        }
        public bool[] ChiBenCT2Array { get; } = new bool[] { false, false, false };
        public int ChiBenCT2
        {
            get
            {
                return Array.IndexOf(ChiBenCT2Array, true) + 1;
            }
            set
            {
                for (int i = 0; i < ChiBenCT2Array.Length; i++)
                {
                    if (i == (value - 1)) ChiBenCT2Array[i] = true;
                    else ChiBenCT2Array[i] = false;
                }
            }
        }
        public bool[] ChiBenCT3Array { get; } = new bool[] { false, false };
        public int ChiBenCT3
        {
            get
            {
                return Array.IndexOf(ChiBenCT3Array, true) + 1;
            }
            set
            {
                for (int i = 0; i < ChiBenCT3Array.Length; i++)
                {
                    if (i == (value - 1)) ChiBenCT3Array[i] = true;
                    else ChiBenCT3Array[i] = false;
                }
            }
        }
        public double? SpO2DauChi { get; set; }
        public bool DuongKinh56F { get; set; }
        public string DuongKinh_Text { get; set; }
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
        public string NhanXetKhac { get; set; }
        public bool[] CTL1_SungNeArray { get; } = new bool[] { false, false };
        public int CTL1_SungNe
        {
            get
            {
                return Array.IndexOf(CTL1_SungNeArray, true) + 1;
            }
            set
            {
                for (int i = 0; i < CTL1_SungNeArray.Length; i++)
                {
                    if (i == (value - 1)) CTL1_SungNeArray[i] = true;
                    else CTL1_SungNeArray[i] = false;
                }
            }
        }
        public string CTL1_SungNe_Text { get; set; }
        public bool[] CTL1_ChayMauArray { get; } = new bool[] { false, false };
        public int CTL1_ChayMau
        {
            get
            {
                return Array.IndexOf(CTL1_ChayMauArray, true) + 1;
            }
            set
            {
                for (int i = 0; i < CTL1_ChayMauArray.Length; i++)
                {
                    if (i == (value - 1)) CTL1_ChayMauArray[i] = true;
                    else CTL1_ChayMauArray[i] = false;
                }
            }
        }
        public bool[] CTL1_TimArray { get; } = new bool[] { false, false };
        public int CTL1_Tim
        {
            get
            {
                return Array.IndexOf(CTL1_TimArray, true) + 1;
            }
            set
            {
                for (int i = 0; i < CTL1_TimArray.Length; i++)
                {
                    if (i == (value - 1)) CTL1_TimArray[i] = true;
                    else CTL1_TimArray[i] = false;
                }
            }
        }
        public string CTL1_Tim_Text { get; set; }
        public bool[] CTL1_DauArray { get; } = new bool[] { false, false };
        public int CTL1_Dau
        {
            get
            {
                return Array.IndexOf(CTL1_DauArray, true) + 1;
            }
            set
            {
                for (int i = 0; i < CTL1_DauArray.Length; i++)
                {
                    if (i == (value - 1)) CTL1_DauArray[i] = true;
                    else CTL1_DauArray[i] = false;
                }
            }
        }
        public bool[] CTL2_SungNeArray { get; } = new bool[] { false, false };
        public int CTL2_SungNe
        {
            get
            {
                return Array.IndexOf(CTL2_SungNeArray, true) + 1;
            }
            set
            {
                for (int i = 0; i < CTL2_SungNeArray.Length; i++)
                {
                    if (i == (value - 1)) CTL2_SungNeArray[i] = true;
                    else CTL2_SungNeArray[i] = false;
                }
            }
        }
        public string CTL2_SungNe_Text { get; set; }
        public bool[] CTL2_ChayMauArray { get; } = new bool[] { false, false };
        public int CTL2_ChayMau
        {
            get
            {
                return Array.IndexOf(CTL2_ChayMauArray, true) + 1;
            }
            set
            {
                for (int i = 0; i < CTL2_ChayMauArray.Length; i++)
                {
                    if (i == (value - 1)) CTL2_ChayMauArray[i] = true;
                    else CTL2_ChayMauArray[i] = false;
                }
            }
        }
        public bool[] CTL2_TimArray { get; } = new bool[] { false, false };
        public int CTL2_Tim
        {
            get
            {
                return Array.IndexOf(CTL2_TimArray, true) + 1;
            }
            set
            {
                for (int i = 0; i < CTL2_TimArray.Length; i++)
                {
                    if (i == (value - 1)) CTL2_TimArray[i] = true;
                    else CTL2_TimArray[i] = false;
                }
            }
        }
        public string CTL2_Tim_Text { get; set; }
        public bool[] CTL2_DauArray { get; } = new bool[] { false, false };
        public int CTL2_Dau
        {
            get
            {
                return Array.IndexOf(CTL2_DauArray, true) + 1;
            }
            set
            {
                for (int i = 0; i < CTL2_DauArray.Length; i++)
                {
                    if (i == (value - 1)) CTL2_DauArray[i] = true;
                    else CTL2_DauArray[i] = false;
                }
            }
        }
        public bool[] CTTruocThaoBang_SungNeArray { get; } = new bool[] { false, false };
        public int CTTruocThaoBang_SungNe
        {
            get
            {
                return Array.IndexOf(CTTruocThaoBang_SungNeArray, true) + 1;
            }
            set
            {
                for (int i = 0; i < CTTruocThaoBang_SungNeArray.Length; i++)
                {
                    if (i == (value - 1)) CTTruocThaoBang_SungNeArray[i] = true;
                    else CTTruocThaoBang_SungNeArray[i] = false;
                }
            }
        }
        public string CTTruocThaoBang_SungNe_Text { get; set; }
        public bool[] CTTruocThaoBang_ChayMauArray { get; } = new bool[] { false, false };
        public int CTTruocThaoBang_ChayMau
        {
            get
            {
                return Array.IndexOf(CTTruocThaoBang_ChayMauArray, true) + 1;
            }
            set
            {
                for (int i = 0; i < CTTruocThaoBang_ChayMauArray.Length; i++)
                {
                    if (i == (value - 1)) CTTruocThaoBang_ChayMauArray[i] = true;
                    else CTTruocThaoBang_ChayMauArray[i] = false;
                }
            }
        }
        public bool[] CTTruocThaoBang_TimArray { get; } = new bool[] { false, false };
        public int CTTruocThaoBang_Tim
        {
            get
            {
                return Array.IndexOf(CTTruocThaoBang_TimArray, true) + 1;
            }
            set
            {
                for (int i = 0; i < CTTruocThaoBang_TimArray.Length; i++)
                {
                    if (i == (value - 1)) CTTruocThaoBang_TimArray[i] = true;
                    else CTTruocThaoBang_TimArray[i] = false;
                }
            }
        }
        public string CTTruocThaoBang_Tim_Text { get; set; }
        public bool[] CTTruocThaoBang_DauArray { get; } = new bool[] { false, false };
        public int CTTruocThaoBang_Dau
        {
            get
            {
                return Array.IndexOf(CTTruocThaoBang_DauArray, true) + 1;
            }
            set
            {
                for (int i = 0; i < CTTruocThaoBang_DauArray.Length; i++)
                {
                    if (i == (value - 1)) CTTruocThaoBang_DauArray[i] = true;
                    else CTTruocThaoBang_DauArray[i] = false;
                }
            }
        }
        public string NhanXetKhac_ChamSocCap { get; set; }
        // Kế Hoạch Chăm Sóc
        public string KeHoachCS_Text { get; set; }
        public bool KH_DHST { get; set; }
        public string KH_DHST_Text { get; set; }
        public bool KH_TheoDoiVet { get; set; }
        public bool KH_HuongDanBN { get; set; }
        public string KH_HuongDanBN_Text { get; set; }
        public bool KH_NoiBangEp { get; set; }
        public bool KH_ThaoBangEp { get; set; }
        public bool TH_GhiDienTamDo { get; set; }
        public bool TH_BaoBacSyKham { get; set; }
        public bool TH_DanhGiaViTri { get; set; }

        public bool TH_SotRet { get; set; }
        public bool TH_KiemTraViTri { get; set; }
        public bool TH_BatDongChi { get; set; }
        public bool TH_HanCheGangSuc { get; set; }
        public bool TH_TheoDoiDiTieu { get; set; }
        public bool TH_KhongUongSua { get; set; }
        public string TH_Text { get; set; }
        public string DanhGia { get; set; }
        [MoTaDuLieu("Họ tên điều dưỡng")]
		public string DieuDuong { get; set; }
        [MoTaDuLieu("Mã điều dưỡng")]
		public string MaDieuDuong { get; set; }

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
    public class KeHoachChamSocNBSauCanThiepTimMachFunc
    {
        public const string TableName = "KeHoachCSNBSauTimMach";
        public const string TablePrimaryKeyName = "ID";
        public static List<KeHoachChamSocNBSauCanThiepTimMach> GetListData(MDB.MDBConnection _OracleConnection, decimal maquanly)
        {
            List<KeHoachChamSocNBSauCanThiepTimMach> list = new List<KeHoachChamSocNBSauCanThiepTimMach>();
            try
            {
                string sql = @"SELECT * FROM KeHoachCSNBSauTimMach where MaQuanLy = :MaQuanLy";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, _OracleConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", maquanly));
                MDB.MDBDataReader DataReader = Command.ExecuteReader();
                while (DataReader.Read())
                {
                    KeHoachChamSocNBSauCanThiepTimMach data = new KeHoachChamSocNBSauCanThiepTimMach();
                    data.ID = Convert.ToInt64(DataReader.GetLong("ID").ToString());
                    data.MaQuanLy = maquanly;
                    data.MaBenhNhan = DataReader["MaBenhNhan"].ToString();
                    data.HoVaTenBN = XemBenhAn._HanhChinhBenhNhan.TenBenhNhan;
                    data.Tuoi = XemBenhAn._HanhChinhBenhNhan.Tuoi;
                    data.GioiTinh = XemBenhAn._HanhChinhBenhNhan.GioiTinh.Description();
                    data.SoGiuong = DataReader["SoGiuong"].ToString();
                    data.Buong = DataReader["Buong"].ToString();
                    data.ChanDoanSauCanThiep = DataReader["ChanDoanSauCanThiep"].ToString();
                    data.NgayCanThiep = DataReader["NgayCanThiep"] == DBNull.Value ? (DateTime?)null : DataReader.GetDate("NgayCanThiep");
                    data.NgayGio = DataReader["NgayGio"] == DBNull.Value ? (DateTime?)null : DataReader.GetDate("NgayGio");
                    data.GioVeKhoa = DataReader["GioVeKhoa"] == DBNull.Value ? (DateTime?)null : DataReader.GetDate("GioVeKhoa");
                    data.ChamSocCap = DataReader["ChamSocCap"].ToString();
                    data.TriGiac = DataReader.GetInt("TriGiac");
                    data.NhipTim = DataReader.GetInt("NhipTim");
                    data.HuyetAp = DataReader.GetInt("HuyetAp");
                    data.TuTho = DataReader.GetInt("TuTho");
                    data.HoTro = DataReader.GetInt("HoTro");
                    double tempDouble = 0;
                    data.SpO2 = double.TryParse(DataReader["SpO2"].ToString(), out tempDouble) ? (double?)tempDouble : null;
                    tempDouble = 0;
                    data.HoTro_Number = double.TryParse(DataReader["HoTro_Number"].ToString(), out tempDouble) ? (double?)tempDouble : null;

                    data.ThanNhiet = DataReader.GetInt("ThanNhiet");
                    data.Dau = DataReader.GetInt("Dau");
                    data.Dau_Text = DataReader["Dau_Text"].ToString();
                    tempDouble = 0;
                    data.Dau_Diem = double.TryParse(DataReader["Dau_Diem"].ToString(), out tempDouble) ? (double?)tempDouble : null;
                    data.ViTriCanThiep = DataReader["ViTriCanThiep"].ToString();
                    data.ChiBenCT1 = DataReader.GetInt("ChiBenCT1");
                    data.ChiBenCT2 = DataReader.GetInt("ChiBenCT2");
                    data.ChiBenCT3 = DataReader.GetInt("ChiBenCT3");
                    tempDouble = 0;
                    data.SpO2DauChi = double.TryParse(DataReader["SpO2DauChi"].ToString(), out tempDouble) ? (double?)tempDouble : null;
                    data.DuongKinh56F = DataReader["DuongKinh56F"].ToString().Equals("1")? true : false;
                    data.DuongKinh_Text = DataReader["DuongKinh_Text"].ToString();
                    data.BaiTiet = DataReader.GetInt("BaiTiet");
                    data.NhanXetKhac = DataReader["NhanXetKhac"].ToString();
                    data.CTL1_SungNe = DataReader.GetInt("CTL1_SungNe");
                    data.CTL1_SungNe_Text = DataReader["CTL1_SungNe_Text"].ToString();
                    data.CTL1_ChayMau = DataReader.GetInt("CTL1_ChayMau");
                    data.CTL1_Tim = DataReader.GetInt("CTL1_Tim");
                    data.CTL1_Tim_Text = DataReader["CTL1_Tim_Text"].ToString();
                    data.CTL1_Dau = DataReader.GetInt("CTL1_Dau");
                    data.CTL2_SungNe = DataReader.GetInt("CTL2_SungNe");
                    data.CTL2_SungNe_Text = DataReader["CTL2_SungNe_Text"].ToString();
                    data.CTL2_ChayMau = DataReader.GetInt("CTL2_ChayMau");
                    data.CTL2_Tim = DataReader.GetInt("CTL2_Tim");
                    data.CTL2_Tim_Text = DataReader["CTL2_Tim_Text"].ToString();
                    data.CTL2_Dau = DataReader.GetInt("CTL2_Dau");
                    data.CTTruocThaoBang_SungNe = DataReader.GetInt("CTTruocThaoBang_SungNe");
                    data.CTTruocThaoBang_SungNe_Text = DataReader["CTTruocThaoBang_SungNe_Text"].ToString();
                    data.CTTruocThaoBang_ChayMau = DataReader.GetInt("CTTruocThaoBang_ChayMau");
                    data.CTTruocThaoBang_Tim = DataReader.GetInt("CTTruocThaoBang_Tim");
                    data.CTTruocThaoBang_Tim_Text = DataReader["CTTruocThaoBang_Tim_Text"].ToString();
                    data.CTTruocThaoBang_Dau = DataReader.GetInt("CTTruocThaoBang_Dau");
                    data.NhanXetKhac_ChamSocCap = DataReader["NhanXetKhac_ChamSocCap"].ToString();
                    data.KeHoachCS_Text = DataReader["KeHoachCS_Text"].ToString();
                    data.KH_DHST = DataReader["KH_DHST"].ToString().Equals("1") ? true:false;
                    data.KH_DHST_Text = DataReader["KH_DHST_Text"].ToString();
                    data.KH_TheoDoiVet = DataReader["KH_TheoDoiVet"].ToString().Equals("1") ? true : false;
                    data.KH_HuongDanBN = DataReader["KH_HuongDanBN"].ToString().Equals("1") ? true : false;
                    data.KH_HuongDanBN_Text = DataReader["KH_HuongDanBN_Text"].ToString();
                    data.KH_NoiBangEp = DataReader["KH_NoiBangEp"].ToString().Equals("1") ? true : false;
                    data.KH_ThaoBangEp = DataReader["KH_ThaoBangEp"].ToString().Equals("1") ? true : false;
                    data.TH_GhiDienTamDo = DataReader["TH_GhiDienTamDo"].ToString().Equals("1") ? true : false;
                    data.TH_BaoBacSyKham = DataReader["TH_BaoBacSyKham"].ToString().Equals("1") ? true : false;
                    data.TH_DanhGiaViTri = DataReader["TH_DanhGiaViTri"].ToString().Equals("1") ? true : false;
                    data.TH_SotRet = DataReader["TH_SotRet"].ToString().Equals("1") ? true : false;
                    data.TH_KiemTraViTri = DataReader["TH_KiemTraViTri"].ToString().Equals("1") ? true : false;
                    data.TH_BatDongChi = DataReader["TH_BatDongChi"].ToString().Equals("1") ? true : false;
                    data.TH_HanCheGangSuc = DataReader["TH_HanCheGangSuc"].ToString().Equals("1") ? true : false;
                    data.TH_TheoDoiDiTieu = DataReader["TH_TheoDoiDiTieu"].ToString().Equals("1") ? true : false;
                    data.TH_KhongUongSua = DataReader["TH_KhongUongSua"].ToString().Equals("1") ? true : false;
                    data.TH_Text = DataReader["TH_Text"].ToString();
                    data.DanhGia = DataReader["DanhGia"].ToString();
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
        public static bool InsertOrUpdate(MDB.MDBConnection MyConnection, ref KeHoachChamSocNBSauCanThiepTimMach keHoach)
        {
            try
            {
                string sql = @"INSERT INTO KeHoachCSNBSauTimMach
                (
                    MAQUANLY,
                    MaBenhNhan,
	                SoGiuong,
	                Buong,
	                NgayCanThiep,
	                ChanDoanSauCanThiep,
	                GioVeKhoa,
	                NgayGio,
	                ChamSocCap,
	                TriGiac,
	                NhipTim,
	                HuyetAp,
	                TuTho,
	                HoTro,
                    HoTro_Number,
	                SpO2,
	                ThanNhiet,
	                Dau,
	                Dau_Text,
	                Dau_Diem,
	                ViTriCanThiep,
	                ChiBenCT1,
	                ChiBenCT2,
	                ChiBenCT3,
	                SpO2DauChi,
	                DuongKinh56F,
	                DuongKinh_Text,
	                BaiTiet,
	                NhanXetKhac,
	                CTL1_SungNe,
	                CTL1_SungNe_Text,
	                CTL1_ChayMau,
	                CTL1_Tim,
	                CTL1_Tim_Text,
	                CTL1_Dau,
	                CTL2_SungNe,
	                CTL2_SungNe_Text,
	                CTL2_ChayMau,
	                CTL2_Tim,
	                CTL2_Tim_Text,
	                CTL2_Dau,
	                CTTruocThaoBang_SungNe,
	                CTTruocThaoBang_SungNe_Text,
	                CTTruocThaoBang_ChayMau,
	                CTTruocThaoBang_Tim,
	                CTTruocThaoBang_Tim_Text,
	                CTTruocThaoBang_Dau,
	                NhanXetKhac_ChamSocCap,
	                KeHoachCS_Text,
	                KH_DHST,
	                KH_DHST_Text,
                    KH_TheoDoiVet,
	                KH_HuongDanBN,
	                KH_HuongDanBN_Text,
	                KH_NoiBangEp,
	                KH_ThaoBangEp,
	                TH_GhiDienTamDo,
	                TH_BaoBacSyKham,
                    TH_DanhGiaViTri,
	                TH_SotRet,
	                TH_KiemTraViTri,
	                TH_BatDongChi,
	                TH_HanCheGangSuc,
	                TH_TheoDoiDiTieu,
	                TH_KhongUongSua,
	                TH_Text,
	                DanhGia,
	                DieuDuong, 
	                MaDieuDuong,
                    NGUOITAO,
                    NGUOISUA,
                    NGAYTAO,
                    NGAYSUA)  VALUES
                 (
				    :MAQUANLY,
                    :MaBenhNhan,
                    :SoGiuong,
                    :Buong,
                    :NgayCanThiep,
                    :ChanDoanSauCanThiep,
                    :GioVeKhoa,
                    :NgayGio,
                    :ChamSocCap,
                    :TriGiac,
                    :NhipTim,
                    :HuyetAp,
                    :TuTho,
                    :HoTro,
                    :HoTro_Number,
                    :SpO2,
                    :ThanNhiet,
                    :Dau,
                    :Dau_Text,
                    :Dau_Diem,
                    :ViTriCanThiep,
                    :ChiBenCT1,
                    :ChiBenCT2,
                    :ChiBenCT3,
                    :SpO2DauChi,
                    :DuongKinh56F,
                    :DuongKinh_Text,
                    :BaiTiet,
                    :NhanXetKhac,
                    :CTL1_SungNe,
                    :CTL1_SungNe_Text,
                    :CTL1_ChayMau,
                    :CTL1_Tim,
                    :CTL1_Tim_Text,
                    :CTL1_Dau,
                    :CTL2_SungNe,
                    :CTL2_SungNe_Text,
                    :CTL2_ChayMau,
                    :CTL2_Tim,
                    :CTL2_Tim_Text,
                    :CTL2_Dau,
                    :CTTruocThaoBang_SungNe,
                    :CTTruocThaoBang_SungNe_Text,
                    :CTTruocThaoBang_ChayMau,
                    :CTTruocThaoBang_Tim,
                    :CTTruocThaoBang_Tim_Text,
                    :CTTruocThaoBang_Dau,
                    :NhanXetKhac_ChamSocCap,
                    :KeHoachCS_Text,
                    :KH_DHST,
                    :KH_DHST_Text,
                    :KH_TheoDoiVet,
                    :KH_HuongDanBN,
                    :KH_HuongDanBN_Text,
                    :KH_NoiBangEp,
                    :KH_ThaoBangEp,
                    :TH_GhiDienTamDo,
                    :TH_BaoBacSyKham,
                    :TH_DanhGiaViTri,
                    :TH_SotRet,
                    :TH_KiemTraViTri,
                    :TH_BatDongChi,
                    :TH_HanCheGangSuc,
                    :TH_TheoDoiDiTieu,
                    :TH_KhongUongSua,
                    :TH_Text,
                    :DanhGia,
                    :DieuDuong, 
                    :MaDieuDuong,
                    :NGUOITAO,
                    :NGUOISUA,
                    :NGAYTAO,
                    :NGAYSUA
                 )  RETURNING ID INTO :ID";
                if (keHoach.ID != 0)
                {
                    sql = @"UPDATE KeHoachCSNBSauTimMach SET 
                    MAQUANLY = :MAQUANLY,
                    MaBenhNhan = :MaBenhNhan,
                    SoGiuong = :SoGiuong,
                    Buong = :Buong,
                    NgayCanThiep = :NgayCanThiep,
                    ChanDoanSauCanThiep = :ChanDoanSauCanThiep,
                    GioVeKhoa = :GioVeKhoa,
                    NgayGio = :NgayGio,
                    ChamSocCap = :ChamSocCap,
                    TriGiac = :TriGiac,
                    NhipTim = :NhipTim,
                    HuyetAp = :HuyetAp,
                    TuTho = :TuTho,
                    HoTro = :HoTro,
                    HoTro_Number = :HoTro_Number,
                    SpO2 = :SpO2,
                    ThanNhiet = :ThanNhiet,
                    Dau = :Dau,
                    Dau_Text = :Dau_Text,
                    Dau_Diem = :Dau_Diem,
                    ViTriCanThiep = :ViTriCanThiep,
                    ChiBenCT1 = :ChiBenCT1,
                    ChiBenCT2 = :ChiBenCT2,
                    ChiBenCT3 = :ChiBenCT3,
                    SpO2DauChi = :SpO2DauChi,
                    DuongKinh56F = :DuongKinh56F,
                    DuongKinh_Text = :DuongKinh_Text,
                    BaiTiet = :BaiTiet,
                    NhanXetKhac = :NhanXetKhac,
                    CTL1_SungNe = :CTL1_SungNe,
                    CTL1_SungNe_Text = :CTL1_SungNe_Text,
                    CTL1_ChayMau = :CTL1_ChayMau,
                    CTL1_Tim = :CTL1_Tim,
                    CTL1_Tim_Text = :CTL1_Tim_Text,
                    CTL1_Dau = :CTL1_Dau,
                    CTL2_SungNe = :CTL2_SungNe,
                    CTL2_SungNe_Text = :CTL2_SungNe_Text,
                    CTL2_ChayMau = :CTL2_ChayMau,
                    CTL2_Tim = :CTL2_Tim,
                    CTL2_Tim_Text = :CTL2_Tim_Text,
                    CTL2_Dau = :CTL2_Dau,
                    CTTruocThaoBang_SungNe = :CTTruocThaoBang_SungNe,
                    CTTruocThaoBang_SungNe_Text = :CTTruocThaoBang_SungNe_Text,
                    CTTruocThaoBang_ChayMau = :CTTruocThaoBang_ChayMau,
                    CTTruocThaoBang_Tim = :CTTruocThaoBang_Tim,
                    CTTruocThaoBang_Tim_Text = :CTTruocThaoBang_Tim_Text,
                    CTTruocThaoBang_Dau = :CTTruocThaoBang_Dau,
                    NhanXetKhac_ChamSocCap = :NhanXetKhac_ChamSocCap,
                    KeHoachCS_Text = :KeHoachCS_Text,
                    KH_DHST = :KH_DHST,
                    KH_DHST_Text = :KH_DHST_Text,
                    KH_TheoDoiVet = :KH_TheoDoiVet,
                    KH_HuongDanBN = :KH_HuongDanBN,
                    KH_HuongDanBN_Text = :KH_HuongDanBN_Text,
                    KH_NoiBangEp = :KH_NoiBangEp,
                    KH_ThaoBangEp = :KH_ThaoBangEp,
                    TH_GhiDienTamDo = :TH_GhiDienTamDo,
                    TH_BaoBacSyKham = :TH_BaoBacSyKham,
                    TH_DanhGiaViTri = :TH_DanhGiaViTri,
                    TH_SotRet = :TH_SotRet,
                    TH_KiemTraViTri = :TH_KiemTraViTri,
                    TH_BatDongChi = :TH_BatDongChi,
                    TH_HanCheGangSuc = :TH_HanCheGangSuc,
                    TH_TheoDoiDiTieu = :TH_TheoDoiDiTieu,
                    TH_KhongUongSua = :TH_KhongUongSua,
                    TH_Text = :TH_Text,
                    DanhGia = :DanhGia,
                    DieuDuong  = :DieuDuong ,
                    MaDieuDuong = :MaDieuDuong,
                    NGUOISUA = :NGUOISUA,
                    NGAYSUA = :NGAYSUA 
                    WHERE ID = " + keHoach.ID;
                }
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MAQUANLY", keHoach.MaQuanLy));
                Command.Parameters.Add(new MDB.MDBParameter("MaBenhNhan", keHoach.MaBenhNhan));
                Command.Parameters.Add(new MDB.MDBParameter("SoGiuong", keHoach.SoGiuong));
                Command.Parameters.Add(new MDB.MDBParameter("Buong", keHoach.Buong));
                Command.Parameters.Add(new MDB.MDBParameter("NgayCanThiep", keHoach.NgayCanThiep));
                Command.Parameters.Add(new MDB.MDBParameter("ChanDoanSauCanThiep", keHoach.ChanDoanSauCanThiep));
                Command.Parameters.Add(new MDB.MDBParameter("GioVeKhoa", keHoach.GioVeKhoa));
                Command.Parameters.Add(new MDB.MDBParameter("NgayGio", keHoach.NgayGio));
                Command.Parameters.Add(new MDB.MDBParameter("ChamSocCap", keHoach.ChamSocCap));
                Command.Parameters.Add(new MDB.MDBParameter("TriGiac", keHoach.TriGiac));
                Command.Parameters.Add(new MDB.MDBParameter("NhipTim", keHoach.NhipTim));
                Command.Parameters.Add(new MDB.MDBParameter("HuyetAp", keHoach.HuyetAp));
                Command.Parameters.Add(new MDB.MDBParameter("TuTho", keHoach.TuTho));
                Command.Parameters.Add(new MDB.MDBParameter("HoTro", keHoach.HoTro));
                Command.Parameters.Add(new MDB.MDBParameter("HoTro_Number", keHoach.HoTro_Number));
                Command.Parameters.Add(new MDB.MDBParameter("SpO2", keHoach.SpO2));
                Command.Parameters.Add(new MDB.MDBParameter("ThanNhiet", keHoach.ThanNhiet));
                Command.Parameters.Add(new MDB.MDBParameter("Dau", keHoach.Dau));
                Command.Parameters.Add(new MDB.MDBParameter("Dau_Text", keHoach.Dau_Text));
                Command.Parameters.Add(new MDB.MDBParameter("Dau_Diem", keHoach.Dau_Diem));
                Command.Parameters.Add(new MDB.MDBParameter("ViTriCanThiep", keHoach.ViTriCanThiep));
                Command.Parameters.Add(new MDB.MDBParameter("ChiBenCT1", keHoach.ChiBenCT1));
                Command.Parameters.Add(new MDB.MDBParameter("ChiBenCT2", keHoach.ChiBenCT2));
                Command.Parameters.Add(new MDB.MDBParameter("ChiBenCT3", keHoach.ChiBenCT3));
                Command.Parameters.Add(new MDB.MDBParameter("SpO2DauChi", keHoach.SpO2DauChi));
                Command.Parameters.Add(new MDB.MDBParameter("DuongKinh56F", keHoach.DuongKinh56F ? 1 : 0));
                Command.Parameters.Add(new MDB.MDBParameter("DuongKinh_Text", keHoach.DuongKinh_Text));
                Command.Parameters.Add(new MDB.MDBParameter("BaiTiet", keHoach.BaiTiet));
                Command.Parameters.Add(new MDB.MDBParameter("NhanXetKhac", keHoach.NhanXetKhac));
                Command.Parameters.Add(new MDB.MDBParameter("CTL1_SungNe", keHoach.CTL1_SungNe));
                Command.Parameters.Add(new MDB.MDBParameter("CTL1_SungNe_Text", keHoach.CTL1_SungNe_Text));
                Command.Parameters.Add(new MDB.MDBParameter("CTL1_ChayMau", keHoach.CTL1_ChayMau));
                Command.Parameters.Add(new MDB.MDBParameter("CTL1_Tim", keHoach.CTL1_Tim));
                Command.Parameters.Add(new MDB.MDBParameter("CTL1_Tim_Text", keHoach.CTL1_Tim_Text));
                Command.Parameters.Add(new MDB.MDBParameter("CTL1_Dau", keHoach.CTL1_Dau));
                Command.Parameters.Add(new MDB.MDBParameter("CTL2_SungNe", keHoach.CTL2_SungNe));
                Command.Parameters.Add(new MDB.MDBParameter("CTL2_SungNe_Text", keHoach.CTL2_SungNe_Text));
                Command.Parameters.Add(new MDB.MDBParameter("CTL2_ChayMau", keHoach.CTL2_ChayMau));
                Command.Parameters.Add(new MDB.MDBParameter("CTL2_Tim", keHoach.CTL2_Tim));
                Command.Parameters.Add(new MDB.MDBParameter("CTL2_Tim_Text", keHoach.CTL2_Tim_Text));
                Command.Parameters.Add(new MDB.MDBParameter("CTL2_Dau", keHoach.CTL2_Dau));
                Command.Parameters.Add(new MDB.MDBParameter("CTTruocThaoBang_SungNe", keHoach.CTTruocThaoBang_SungNe));
                Command.Parameters.Add(new MDB.MDBParameter("CTTruocThaoBang_SungNe_Text", keHoach.CTTruocThaoBang_SungNe_Text));
                Command.Parameters.Add(new MDB.MDBParameter("CTTruocThaoBang_ChayMau", keHoach.CTTruocThaoBang_ChayMau));
                Command.Parameters.Add(new MDB.MDBParameter("CTTruocThaoBang_Tim", keHoach.CTTruocThaoBang_Tim));
                Command.Parameters.Add(new MDB.MDBParameter("CTTruocThaoBang_Tim_Text", keHoach.CTTruocThaoBang_Tim_Text));
                Command.Parameters.Add(new MDB.MDBParameter("CTTruocThaoBang_Dau", keHoach.CTTruocThaoBang_Dau));
                Command.Parameters.Add(new MDB.MDBParameter("NhanXetKhac_ChamSocCap", keHoach.NhanXetKhac_ChamSocCap));
                Command.Parameters.Add(new MDB.MDBParameter("KeHoachCS_Text", keHoach.KeHoachCS_Text));
                Command.Parameters.Add(new MDB.MDBParameter("KH_DHST", keHoach.KH_DHST ? 1 : 0));
                Command.Parameters.Add(new MDB.MDBParameter("KH_DHST_Text", keHoach.KH_DHST_Text));
                Command.Parameters.Add(new MDB.MDBParameter("KH_TheoDoiVet", keHoach.KH_TheoDoiVet ? 1 : 0));
                Command.Parameters.Add(new MDB.MDBParameter("KH_HuongDanBN", keHoach.KH_HuongDanBN ? 1 : 0));
                Command.Parameters.Add(new MDB.MDBParameter("KH_HuongDanBN_Text", keHoach.KH_HuongDanBN_Text));
                Command.Parameters.Add(new MDB.MDBParameter("KH_NoiBangEp", keHoach.KH_NoiBangEp ? 1 : 0));
                Command.Parameters.Add(new MDB.MDBParameter("KH_ThaoBangEp", keHoach.KH_ThaoBangEp ? 1 : 0));
                Command.Parameters.Add(new MDB.MDBParameter("TH_GhiDienTamDo", keHoach.TH_GhiDienTamDo ? 1 : 0));
                Command.Parameters.Add(new MDB.MDBParameter("TH_BaoBacSyKham", keHoach.TH_BaoBacSyKham ? 1 : 0));
                Command.Parameters.Add(new MDB.MDBParameter("TH_DanhGiaViTri", keHoach.TH_DanhGiaViTri ? 1 : 0));
                Command.Parameters.Add(new MDB.MDBParameter("TH_SotRet", keHoach.TH_SotRet ? 1 : 0));
                Command.Parameters.Add(new MDB.MDBParameter("TH_KiemTraViTri", keHoach.TH_KiemTraViTri ? 1 : 0));
                Command.Parameters.Add(new MDB.MDBParameter("TH_BatDongChi", keHoach.TH_BatDongChi ? 1 : 0));
                Command.Parameters.Add(new MDB.MDBParameter("TH_HanCheGangSuc", keHoach.TH_HanCheGangSuc ? 1 : 0));
                Command.Parameters.Add(new MDB.MDBParameter("TH_TheoDoiDiTieu", keHoach.TH_TheoDoiDiTieu ? 1 : 0));
                Command.Parameters.Add(new MDB.MDBParameter("TH_KhongUongSua", keHoach.TH_KhongUongSua ? 1 : 0));
                Command.Parameters.Add(new MDB.MDBParameter("TH_Text", keHoach.TH_Text));
                Command.Parameters.Add(new MDB.MDBParameter("DanhGia", keHoach.DanhGia));
                Command.Parameters.Add(new MDB.MDBParameter("DieuDuong", keHoach.DieuDuong));
                Command.Parameters.Add(new MDB.MDBParameter("MaDieuDuong", keHoach.MaDieuDuong));


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
                string sql = "DELETE FROM KeHoachCSNBSauTimMach WHERE ID = :ID";
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
                T.KHOA,
                T.MaBenhAn
            FROM
                KeHoachCSNBSauTimMach B
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
