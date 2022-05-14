using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EMR.KyDienTu;
using PMS.Access;
using System;
using System.Collections.Generic;
using System.Data;
using Newtonsoft.Json;

namespace EMR_MAIN.DATABASE.Other
{
    public class PhieuDieuTraCaMacCovid : ThongTinKy
    {
        public PhieuDieuTraCaMacCovid()
        {
            TableName = "PhieuDieuTraCaMacCovid";
            TablePrimaryKeyName = "ID";
            IDMauPhieu = (int)DanhMucPhieu.PDTCMCV;
            TenMauPhieu = DanhMucPhieu.PDTCMCV.Description();
        }
        [MoTaDuLieu("Mã định danh")]
		public long ID { get; set; }
        [MoTaDuLieu("Mã quản lý: mã duy nhất trong 1 đợt khám chữa bệnh (kcb), không trùng giữa các đợt kcb khác nhau","",1)]
		public decimal MaQuanLy { get; set; }
        [MoTaDuLieu("Mã bệnh nhân")]
		public string MaBenhNhan { get; set; }
        public string TenNguoiBaoCao { get; set; }
        public DateTime? NgayBaoCao { get; set; }
        public string TenDonVi { get; set; }
        public string DienThoai { get; set; }
        [MoTaDuLieu("Địa chỉ thư điện tử")]
		public string Email { get; set; }
        public string HoTenBenhNhan { get; set; }
        public DateTime? NgaySinh { get; set; }
        [MoTaDuLieu("Tuổi bệnh nhân")]
		public string Tuoi { get; set; }
        [MoTaDuLieu("Giới tính bệnh nhân")]
		public string GioiTinh { get; set; }
        [MoTaDuLieu("Dân tộc")]
		public string DanToc { get; set; }
        [MoTaDuLieu("Nghề nghiệp")]
		public string NgheNghiep { get; set; }
        [MoTaDuLieu("Quốc tịch")]
		public string QuocTich { get; set; }
        [MoTaDuLieu("Số nhà")]
		public string DiaChi_So { get; set; }
        [MoTaDuLieu("Thôn")]
		public string DiaChi_Thon { get; set; }
        [MoTaDuLieu("Phường")]
		public string DiaChi_Phuong { get; set; }
        [MoTaDuLieu("Quận")]
		public string DiaChi_Quan {get;set;}
        [MoTaDuLieu("Tỉnh")]
        public string Tinh { get; set; }
        public string DienThoaiLienHe { get; set; }
        public bool[] DiaChiKhoiPhat_Array { get; } = new bool[] { false, false };
        [MoTaDuLieu("Địa chỉ nhà bệnh nhân")]
		public string DiaChiKhoiPhat
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < DiaChiKhoiPhat_Array.Length; i++)
                    temp += (DiaChiKhoiPhat_Array[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        DiaChiKhoiPhat_Array[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        [MoTaDuLieu("Địa chỉ nhà bệnh nhân")]
		public string DiaChiKhoiPhat_Text { get; set; }
        public DateTime? NgayKhoiPhat { get; set; }
        public DateTime? NgayVaoVien { get; set; }
        public string CoSoDangDieuTri { get; set; }
        [MoTaDuLieu("Diễn biến bệnh")]
		public string DienBienBenh { get; set; }
        public bool[] BieuHien_Sot_Array { get; } = new bool[] { false, false };
        public int BieuHien_Sot
        {
            get
            {
                return Array.IndexOf(BieuHien_Sot_Array, true) + 1;
            }
            set
            {
                for (int i = 0; i < BieuHien_Sot_Array.Length; i++)
                {
                    if (i == (value - 1)) BieuHien_Sot_Array[i] = true;
                    else BieuHien_Sot_Array[i] = false;
                }
            }
        }
        public bool[] BieuHien_Ho_Array { get; } = new bool[] { false, false };
        public int BieuHien_Ho
        {
            get
            {
                return Array.IndexOf(BieuHien_Ho_Array, true) + 1;
            }
            set
            {
                for (int i = 0; i < BieuHien_Ho_Array.Length; i++)
                {
                    if (i == (value - 1)) BieuHien_Ho_Array[i] = true;
                    else BieuHien_Ho_Array[i] = false;
                }
            }
        }
        public bool[] BieuHien_DauHong_Array { get; } = new bool[] { false, false };
        public int BieuHien_DauHong
        {
            get
            {
                return Array.IndexOf(BieuHien_DauHong_Array, true) + 1;
            }
            set
            {
                for (int i = 0; i < BieuHien_DauHong_Array.Length; i++)
                {
                    if (i == (value - 1)) BieuHien_DauHong_Array[i] = true;
                    else BieuHien_DauHong_Array[i] = false;
                }
            }
        }
        public bool[] BieuHien_KhoTho_Array { get; } = new bool[] { false, false };
        public int BieuHien_KhoTho
        {
            get
            {
                return Array.IndexOf(BieuHien_KhoTho_Array, true) + 1;
            }
            set
            {
                for (int i = 0; i < BieuHien_KhoTho_Array.Length; i++)
                {
                    if (i == (value - 1)) BieuHien_KhoTho_Array[i] = true;
                    else BieuHien_KhoTho_Array[i] = false;
                }
            }
        }
        public bool[] BieuHien_KhuuGiac_Array { get; } = new bool[] { false, false };
        public int BieuHien_KhuuGiac
        {
            get
            {
                return Array.IndexOf(BieuHien_KhuuGiac_Array, true) + 1;
            }
            set
            {
                for (int i = 0; i < BieuHien_KhuuGiac_Array.Length; i++)
                {
                    if (i == (value - 1)) BieuHien_KhuuGiac_Array[i] = true;
                    else BieuHien_KhuuGiac_Array[i] = false;
                }
            }
        }
        public bool[] BieuHien_ViemPhoi_Array { get; } = new bool[] { false, false };
        public int BieuHien_ViemPhoi
        {
            get
            {
                return Array.IndexOf(BieuHien_ViemPhoi_Array, true) + 1;
            }
            set
            {
                for (int i = 0; i < BieuHien_ViemPhoi_Array.Length; i++)
                {
                    if (i == (value - 1)) BieuHien_ViemPhoi_Array[i] = true;
                    else BieuHien_ViemPhoi_Array[i] = false;
                }
            }
        }
        public bool[] BieuHien_TrieuChungKhac_Array { get; } = new bool[] { false, false };
        public int BieuHien_TrieuChungKhac
        {
            get
            {
                return Array.IndexOf(BieuHien_TrieuChungKhac_Array, true) + 1;
            }
            set
            {
                for (int i = 0; i < BieuHien_TrieuChungKhac_Array.Length; i++)
                {
                    if (i == (value - 1)) BieuHien_TrieuChungKhac_Array[i] = true;
                    else BieuHien_TrieuChungKhac_Array[i] = false;
                }
            }
        }
        public string BieuHien_CuThe { get; set; }
        public string TienSuBenh { get; set; }
        public bool[] TienSuDichTe1_Array { get; } = new bool[] { false, false, false};
        public int TienSuDichTe1
        {
            get
            {
                return Array.IndexOf(TienSuDichTe1_Array, true) + 1;
            }
            set
            {
                for (int i = 0; i < TienSuDichTe1_Array.Length; i++)
                {
                    if (i == (value - 1)) TienSuDichTe1_Array[i] = true;
                    else TienSuDichTe1_Array[i] = false;
                }
            }
        }
        public string TienSuDichTe1_Text { get; set; }
        public bool[] TienSuDichTe2_Array { get; } = new bool[] { false, false, false };
        public int TienSuDichTe2
        {
            get
            {
                return Array.IndexOf(TienSuDichTe2_Array, true) + 1;
            }
            set
            {
                for (int i = 0; i < TienSuDichTe2_Array.Length; i++)
                {
                    if (i == (value - 1)) TienSuDichTe2_Array[i] = true;
                    else TienSuDichTe2_Array[i] = false;
                }
            }
        }
        public bool[] TienSuDichTe3_Array { get; } = new bool[] { false, false, false };
        public int TienSuDichTe3
        {
            get
            {
                return Array.IndexOf(TienSuDichTe3_Array, true) + 1;
            }
            set
            {
                for (int i = 0; i < TienSuDichTe3_Array.Length; i++)
                {
                    if (i == (value - 1)) TienSuDichTe3_Array[i] = true;
                    else TienSuDichTe3_Array[i] = false;
                }
            }
        }
        public bool[] TienSuDichTe4_Array { get; } = new bool[] { false, false, false };
        public int TienSuDichTe4
        {
            get
            {
                return Array.IndexOf(TienSuDichTe4_Array, true) + 1;
            }
            set
            {
                for (int i = 0; i < TienSuDichTe4_Array.Length; i++)
                {
                    if (i == (value - 1)) TienSuDichTe4_Array[i] = true;
                    else TienSuDichTe4_Array[i] = false;
                }
            }
        }
        public bool[] TienSuDichTe5_Array { get; } = new bool[] { false, false, false };
        public int TienSuDichTe5
        {
            get
            {
                return Array.IndexOf(TienSuDichTe5_Array, true) + 1;
            }
            set
            {
                for (int i = 0; i < TienSuDichTe5_Array.Length; i++)
                {
                    if (i == (value - 1)) TienSuDichTe5_Array[i] = true;
                    else TienSuDichTe5_Array[i] = false;
                }
            }
        }
        public bool[] TienSuDichTe6_Array { get; } = new bool[] { false, false, false };
        public int TienSuDichTe6
        {
            get
            {
                return Array.IndexOf(TienSuDichTe6_Array, true) + 1;
            }
            set
            {
                for (int i = 0; i < TienSuDichTe6_Array.Length; i++)
                {
                    if (i == (value - 1)) TienSuDichTe6_Array[i] = true;
                    else TienSuDichTe6_Array[i] = false;
                }
            }
        }
        public string TienSuDichTe_Khac { get; set; }
        public bool[] TTDT1_Array { get; } = new bool[] { false, false, false };
        public int TTDT1
        {
            get
            {
                return Array.IndexOf(TTDT1_Array, true) + 1;
            }
            set
            {
                for (int i = 0; i < TTDT1_Array.Length; i++)
                {
                    if (i == (value - 1)) TTDT1_Array[i] = true;
                    else TTDT1_Array[i] = false;
                }
            }
        }
        public bool[] TTDT2_Array { get; } = new bool[] { false, false, false };
        public int TTDT2
        {
            get
            {
                return Array.IndexOf(TTDT2_Array, true) + 1;
            }
            set
            {
                for (int i = 0; i < TTDT2_Array.Length; i++)
                {
                    if (i == (value - 1)) TTDT2_Array[i] = true;
                    else TTDT2_Array[i] = false;
                }
            }
        }
        public DateTime? TTDT2_NgayBatDau { get; set; }
        public string TTDT2_SoNgay { get; set; }
        public bool[] TTDT3_Array { get; } = new bool[] { false, false, false };
        public int TTDT3
        {
            get
            {
                return Array.IndexOf(TTDT3_Array, true) + 1;
            }
            set
            {
                for (int i = 0; i < TTDT3_Array.Length; i++)
                {
                    if (i == (value - 1)) TTDT3_Array[i] = true;
                    else TTDT3_Array[i] = false;
                }
            }
        }
        public DateTime? TTDT3_NgayBatDau { get; set; }
        public string TTDT3_SoNgay { get; set; }
        public bool[] TTDT4_Array { get; } = new bool[] { false, false, false };
        public int TTDT4
        {
            get
            {
                return Array.IndexOf(TTDT4_Array, true) + 1;
            }
            set
            {
                for (int i = 0; i < TTDT4_Array.Length; i++)
                {
                    if (i == (value - 1)) TTDT4_Array[i] = true;
                    else TTDT4_Array[i] = false;
                }
            }
        }
        public string TTDT4_Text { get; set; }
        public string TTDT5_Text { get; set; }
        [MoTaDuLieu("Bạch cầu")]
		public string BachCau { get; set; }
        [MoTaDuLieu("Hồng cầu")]
		public string HongCau { get; set; }
        [MoTaDuLieu("Tiểu cầu")]
		public string TieuCau { get; set; }
        public string Hermatocrite { get; set; }
        public bool[] XQuang_Array { get; } = new bool[] { false, false, false };
        public int XQuang
        {
            get
            {
                return Array.IndexOf(XQuang_Array, true) + 1;
            }
            set
            {
                for (int i = 0; i < XQuang_Array.Length; i++)
                {
                    if (i == (value - 1)) XQuang_Array[i] = true;
                    else XQuang_Array[i] = false;
                }
            }
        }
        public DateTime? XQuang_Ngay { get; set; }
        public string XQuang_MoTa { get; set; }
        public BenhPhamXN DichTyHau { get; set; }
        public BenhPhamXN DichHong { get; set; }
        public BenhPhamXN DichMui { get; set; }
        public BenhPhamXN DichRuaMui { get; set; }
        public BenhPhamXN MauSucHong { get; set; }
        public BenhPhamXN Dom { get; set; }
        public BenhPhamXN DichNoiKhiQuan { get; set; }
        public BenhPhamXN MauGiaiDoanCap { get; set; }
        public BenhPhamXN MauGiaiDoanPH { get; set; }
        public string MauGiaiDoanPH_Text { get; set; }
        public BenhPhamXN BenhPham_Khac { get; set; }
        public string BenhPhamKhac_Text { get; set; }
        public bool[] KetQuaDieuTri_Array { get; } = new bool[] { false, false, false, false, false, false };
        public string KetQuaDieuTri
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < KetQuaDieuTri_Array.Length; i++)
                    temp += (KetQuaDieuTri_Array[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        KetQuaDieuTri_Array[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public string DangDieuTri_Text { get; set; }
        public string DiChung { get; set; }
        public string KQDT_Khac { get; set; }
        public DateTime? NgayTuVong { get; set; }
        public string LyDoTuVong { get; set; }
        public bool[] ChanDoanCuoi_Array { get; } = new bool[] { false, false, false, false};
        [MoTaDuLieu("Chẩn đoán bệnh")]
		public string ChanDoanCuoi
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < ChanDoanCuoi_Array.Length; i++)
                    temp += (ChanDoanCuoi_Array[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        ChanDoanCuoi_Array[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        [MoTaDuLieu("Chẩn đoán bệnh")]
		public string ChanDoanCuoi_Text { get; set; }
        public string DieuTraVien { get; set; }
        public string MaDieuTraVien { get; set; }
        [MoTaDuLieu("Lãnh đạo bệnh viện")]
		public string LanhDaoBenhVien { get; set; }
        [MoTaDuLieu("Mã lãnh đạo bệnh viện")]
		public string MaLanhDaoBenhVien { get; set; }
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
    public class BenhPhamXN
    {
        [MoTaDuLieu("Chọn", null, 0, 0)]
		public bool Chon { get; set; }
        public DateTime? NgayLay { get; set; }
        public string KetQua { get; set; }
    }
    public class PhieuDieuTraCaMacCovidFunc
    {
        public const string TableName = "PhieuDieuTraCaMacCovid";
        public const string TablePrimaryKeyName = "ID";
        public static List<PhieuDieuTraCaMacCovid> GetListData(MDB.MDBConnection _OracleConnection, decimal maquanly)
        {
            List<PhieuDieuTraCaMacCovid> list = new List<PhieuDieuTraCaMacCovid>();
            try
            {
                string sql = @"SELECT * FROM PhieuDieuTraCaMacCovid where MaQuanLy = :MaQuanLy";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, _OracleConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", maquanly));
                MDB.MDBDataReader DataReader = Command.ExecuteReader();
                while (DataReader.Read())
                {
                    PhieuDieuTraCaMacCovid data = new PhieuDieuTraCaMacCovid();
                    data.ID = Convert.ToInt64(DataReader.GetLong("ID").ToString());
                    data.MaQuanLy = maquanly;
                    data.MaBenhNhan = DataReader["MaBenhNhan"].ToString();
                    data.HoTenBenhNhan = DataReader["HoTenBenhNhan"].ToString();
                    data.Tuoi = DataReader["Tuoi"].ToString();
                    data.NgaySinh = DataReader["NgaySinh"] != DBNull.Value ? (DateTime?)Convert.ToDateTime(DataReader["NgaySinh"]) : null;
                    data.GioiTinh = DataReader["GioiTinh"].ToString();
                    data.TenDonVi = DataReader["TenDonVi"].ToString();
                    data.NgayBaoCao = DataReader["NgayBaoCao"] != DBNull.Value ? (DateTime?)Convert.ToDateTime(DataReader["NgayBaoCao"]) : null;
                    data.TenNguoiBaoCao = DataReader["TenNguoiBaoCao"].ToString();
                    data.DienThoai = DataReader["DienThoai"].ToString();
                    data.Email = DataReader["Email"].ToString();
                    data.DanToc = DataReader["DanToc"].ToString();
                    data.NgheNghiep = DataReader["NgheNghiep"].ToString();
                    data.QuocTich = DataReader["QuocTich"].ToString();
                    data.DiaChi_So = DataReader["DiaChi_So"].ToString();
                    data.DiaChi_Thon = DataReader["DiaChi_Thon"].ToString();
                    data.DiaChi_Phuong = DataReader["DiaChi_Phuong"].ToString();
                    data.DiaChi_Quan = DataReader["DiaChi_Quan"].ToString();
                    data.Tinh = DataReader["Tinh"].ToString();
                    data.DienThoaiLienHe = DataReader["DienThoaiLienHe"].ToString();
                    data.DiaChiKhoiPhat = DataReader["DiaChiKhoiPhat"].ToString();
                    data.DiaChiKhoiPhat_Text = DataReader["DiaChiKhoiPhat_Text"].ToString();
                    data.NgayKhoiPhat = DataReader["NgayKhoiPhat"] != DBNull.Value ? (DateTime?)Convert.ToDateTime(DataReader["NgayKhoiPhat"]) : null;
                    data.NgayVaoVien = DataReader["NgayVaoVien"] != DBNull.Value ? (DateTime?)Convert.ToDateTime(DataReader["NgayVaoVien"]) : null;
                    data.CoSoDangDieuTri = DataReader["CoSoDangDieuTri"].ToString();
                    data.DienBienBenh = DataReader["DienBienBenh"].ToString();
                    data.DienBienBenh = DataReader["DienBienBenh"].ToString();
                    int tempInt = 0;
                    data.BieuHien_Sot = int.TryParse(DataReader["BieuHien_Sot"].ToString(), out tempInt) ? tempInt : 0;
                    tempInt = 0;
                    data.BieuHien_DauHong = int.TryParse(DataReader["BieuHien_DauHong"].ToString(), out tempInt) ? tempInt : 0;
                    tempInt = 0;
                    data.BieuHien_KhoTho = int.TryParse(DataReader["BieuHien_KhoTho"].ToString(), out tempInt) ? tempInt : 0;
                    tempInt = 0;
                    data.BieuHien_KhuuGiac = int.TryParse(DataReader["BieuHien_KhuuGiac"].ToString(), out tempInt) ? tempInt : 0;
                    tempInt = 0;
                    data.BieuHien_ViemPhoi = int.TryParse(DataReader["BieuHien_ViemPhoi"].ToString(), out tempInt) ? tempInt : 0;
                    tempInt = 0;
                    data.BieuHien_TrieuChungKhac = int.TryParse(DataReader["BieuHien_TrieuChungKhac"].ToString(), out tempInt) ? tempInt : 0;
                    data.BieuHien_CuThe = DataReader["BieuHien_CuThe"].ToString();
                    data.TienSuBenh = DataReader["TienSuBenh"].ToString();
                    tempInt = 0;
                    data.TienSuDichTe1 = int.TryParse(DataReader["TienSuDichTe1"].ToString(), out tempInt) ? tempInt : 0;
                    data.TienSuDichTe1_Text = DataReader["TienSuDichTe1_Text"].ToString();
                    tempInt = 0;
                    data.TienSuDichTe2 = int.TryParse(DataReader["TienSuDichTe2"].ToString(), out tempInt) ? tempInt : 0;
                    tempInt = 0;
                    data.TienSuDichTe3 = int.TryParse(DataReader["TienSuDichTe3"].ToString(), out tempInt) ? tempInt : 0;
                    tempInt = 0;
                    data.TienSuDichTe4 = int.TryParse(DataReader["TienSuDichTe4"].ToString(), out tempInt) ? tempInt : 0;
                    tempInt = 0;
                    data.TienSuDichTe5 = int.TryParse(DataReader["TienSuDichTe5"].ToString(), out tempInt) ? tempInt : 0;
                    tempInt = 0;
                    data.TienSuDichTe6 = int.TryParse(DataReader["TienSuDichTe6"].ToString(), out tempInt) ? tempInt : 0;
                    data.TienSuDichTe_Khac = DataReader["TienSuDichTe_Khac"].ToString();
                    tempInt = 0;
                    data.TTDT1 = int.TryParse(DataReader["TTDT1"].ToString(), out tempInt) ? tempInt : 0;
                    tempInt = 0;
                    data.TTDT2 = int.TryParse(DataReader["TTDT2"].ToString(), out tempInt) ? tempInt : 0;
                    data.TTDT2_NgayBatDau = DataReader["TTDT2_NgayBatDau"] != DBNull.Value ? (DateTime?)Convert.ToDateTime(DataReader["TTDT2_NgayBatDau"]) : null;
                    data.TTDT2_SoNgay = DataReader["TTDT2_SoNgay"].ToString();
                    tempInt = 0;
                    data.TTDT3 = int.TryParse(DataReader["TTDT3"].ToString(), out tempInt) ? tempInt : 0;
                    data.TTDT3_NgayBatDau = DataReader["TTDT3_NgayBatDau"] != DBNull.Value ? (DateTime?)Convert.ToDateTime(DataReader["TTDT3_NgayBatDau"]) : null;
                    data.TTDT3_SoNgay = DataReader["TTDT3_SoNgay"].ToString();
                    tempInt = 0;
                    data.TTDT4 = int.TryParse(DataReader["TTDT4"].ToString(), out tempInt) ? tempInt : 0;
                    data.TTDT4_Text = DataReader["TTDT4_Text"].ToString();
                    data.TTDT5_Text = DataReader["TTDT5_Text"].ToString();
                    data.BachCau = DataReader["BachCau"].ToString();
                    data.HongCau = DataReader["HongCau"].ToString();
                    data.TieuCau = DataReader["TieuCau"].ToString();
                    data.Hermatocrite = DataReader["Hermatocrite"].ToString();
                    tempInt = 0;
                    data.XQuang = int.TryParse(DataReader["XQuang"].ToString(), out tempInt) ? tempInt : 0;
                    data.XQuang_Ngay = DataReader["XQuang_Ngay"] != DBNull.Value ? (DateTime?)Convert.ToDateTime(DataReader["XQuang_Ngay"]) : null;
                    data.XQuang_MoTa = DataReader["XQuang_MoTa"].ToString();

                    data.DichTyHau = JsonConvert.DeserializeObject<BenhPhamXN>(DataReader["DichTyHau"].ToString());
                    data.DichHong = JsonConvert.DeserializeObject<BenhPhamXN>(DataReader["DichHong"].ToString());
                    data.DichMui = JsonConvert.DeserializeObject<BenhPhamXN>(DataReader["DichMui"].ToString());
                    data.DichRuaMui = JsonConvert.DeserializeObject<BenhPhamXN>(DataReader["DichRuaMui"].ToString());
                    data.MauSucHong = JsonConvert.DeserializeObject<BenhPhamXN>(DataReader["MauSucHong"].ToString());
                    data.Dom = JsonConvert.DeserializeObject<BenhPhamXN>(DataReader["Dom"].ToString());
                    data.DichNoiKhiQuan = JsonConvert.DeserializeObject<BenhPhamXN>(DataReader["DichNoiKhiQuan"].ToString());
                    data.MauGiaiDoanCap = JsonConvert.DeserializeObject<BenhPhamXN>(DataReader["MauGiaiDoanCap"].ToString());
                    data.MauGiaiDoanPH = JsonConvert.DeserializeObject<BenhPhamXN>(DataReader["MauGiaiDoanPH"].ToString());
                    data.MauGiaiDoanPH_Text = DataReader["MauGiaiDoanPH_Text"].ToString();
                    data.BenhPham_Khac = JsonConvert.DeserializeObject<BenhPhamXN>(DataReader["BenhPham_Khac"].ToString());

                    data.BenhPhamKhac_Text = DataReader["BenhPhamKhac_Text"].ToString();
                    data.KetQuaDieuTri = DataReader["KetQuaDieuTri"].ToString();
                    data.DangDieuTri_Text = DataReader["DangDieuTri_Text"].ToString();
                    data.DiChung = DataReader["DiChung"].ToString();
                    data.KQDT_Khac = DataReader["KQDT_Khac"].ToString();
                    data.NgayTuVong = DataReader["NgayTuVong"] != DBNull.Value ? (DateTime?)Convert.ToDateTime(DataReader["NgayTuVong"]) : null;
                    data.ChanDoanCuoi = DataReader["ChanDoanCuoi"].ToString();
                    data.ChanDoanCuoi_Text = DataReader["ChanDoanCuoi_Text"].ToString();
                    data.DieuTraVien = DataReader["DieuTraVien"].ToString();
                    data.MaDieuTraVien = DataReader["MaDieuTraVien"].ToString();
                    data.LanhDaoBenhVien = DataReader["LanhDaoBenhVien"].ToString();
                    data.MaLanhDaoBenhVien = DataReader["MaLanhDaoBenhVien"].ToString();

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
        public static bool InsertOrUpdate(MDB.MDBConnection MyConnection, ref PhieuDieuTraCaMacCovid ketQua)
        {
            try
            {
                string sql = @"INSERT INTO PhieuDieuTraCaMacCovid
                (
                    MAQUANLY,
                    MaBenhNhan,
                    TenDonVi,
                    NgayBaoCao,
                    TenNguoiBaoCao,
                    DienThoai,
                    Email,
                    HoTenBenhNhan,
                    NgaySinh,
                    Tuoi,
                    GioiTinh,
                    DanToc,
                    NgheNghiep,
                    QuocTich,
                    DiaChi_So,
                    DiaChi_Thon,
                    DiaChi_Phuong,
                    DiaChi_Quan,
                    Tinh,
                    DienThoaiLienHe,
                    DiaChiKhoiPhat,
                    DiaChiKhoiPhat_Text,
                    NgayKhoiPhat,
                    NgayVaoVien,
                    CoSoDangDieuTri,
                    DienBienBenh,
                    BieuHien_Sot,
                    BieuHien_Ho,
                    BieuHien_DauHong,
                    BieuHien_KhoTho,
                    BieuHien_KhuuGiac,
                    BieuHien_ViemPhoi,
                    BieuHien_TrieuChungKhac,
                    BieuHien_CuThe,
                    TienSuBenh,
                    TienSuDichTe1,
                    TienSuDichTe1_Text,
                    TienSuDichTe2,
                    TienSuDichTe3,
                    TienSuDichTe4,
                    TienSuDichTe5,
                    TienSuDichTe6,
                    TienSuDichTe_Khac,
                    TTDT1,
                    TTDT2,
                    TTDT2_NgayBatDau,
                    TTDT2_SoNgay,
                    TTDT3,
                    TTDT3_NgayBatDau,
                    TTDT3_SoNgay,
                    TTDT4,
                    TTDT4_Text,
                    TTDT5_Text,
                    BachCau,
                    HongCau,
                    TieuCau,
                    Hermatocrite,
                    XQuang,
                    XQuang_Ngay,
                    XQuang_MoTa,
                    DichTyHau,
                    DichHong,
                    DichMui,
                    DichRuaMui,
                    MauSucHong,
                    Dom,
                    DichNoiKhiQuan,
                    MauGiaiDoanCap,
                    MauGiaiDoanPH,
                    MauGiaiDoanPH_Text,
                    BenhPham_Khac,
                    BenhPhamKhac_Text,
                    KetQuaDieuTri,
                    DangDieuTri_Text,
                    DiChung,
                    KQDT_Khac,
                    NgayTuVong,
                    LyDoTuVong,
                    ChanDoanCuoi,
                    ChanDoanCuoi_Text,
                    DieuTraVien,
                    MaDieuTraVien,
                    LanhDaoBenhVien,
                    MaLanhDaoBenhVien,
                    NGUOITAO,
                    NGUOISUA,
                    NGAYTAO,
                    NGAYSUA)  VALUES
                 (
				    :MAQUANLY,
                    :MaBenhNhan,
                    :TenDonVi,
                    :NgayBaoCao,
                    :TenNguoiBaoCao,
                    :DienThoai,
                    :Email,
                    :HoTenBenhNhan,
                    :NgaySinh,
                    :Tuoi,
                    :GioiTinh,
                    :DanToc,
                    :NgheNghiep,
                    :QuocTich,
                    :DiaChi_So,
                    :DiaChi_Thon,
                    :DiaChi_Phuong,
                    :DiaChi_Quan,
                    :Tinh,
                    :DienThoaiLienHe,
                    :DiaChiKhoiPhat,
                    :DiaChiKhoiPhat_Text,
                    :NgayKhoiPhat,
                    :NgayVaoVien,
                    :CoSoDangDieuTri,
                    :DienBienBenh,
                    :BieuHien_Sot,
                    :BieuHien_Ho,
                    :BieuHien_DauHong,
                    :BieuHien_KhoTho,
                    :BieuHien_KhuuGiac,
                    :BieuHien_ViemPhoi,
                    :BieuHien_TrieuChungKhac,
                    :BieuHien_CuThe,
                    :TienSuBenh,
                    :TienSuDichTe1,
                    :TienSuDichTe1_Text,
                    :TienSuDichTe2,
                    :TienSuDichTe3,
                    :TienSuDichTe4,
                    :TienSuDichTe5,
                    :TienSuDichTe6,
                    :TienSuDichTe_Khac,
                    :TTDT1,
                    :TTDT2,
                    :TTDT2_NgayBatDau,
                    :TTDT2_SoNgay,
                    :TTDT3,
                    :TTDT3_NgayBatDau,
                    :TTDT3_SoNgay,
                    :TTDT4,
                    :TTDT4_Text,
                    :TTDT5_Text,
                    :BachCau,
                    :HongCau,
                    :TieuCau,
                    :Hermatocrite,
                    :XQuang,
                    :XQuang_Ngay,
                    :XQuang_MoTa,
                    :DichTyHau,
                    :DichHong,
                    :DichMui,
                    :DichRuaMui,
                    :MauSucHong,
                    :Dom,
                    :DichNoiKhiQuan,
                    :MauGiaiDoanCap,
                    :MauGiaiDoanPH,
                    :MauGiaiDoanPH_Text,
                    :BenhPham_Khac,
                    :BenhPhamKhac_Text,
                    :KetQuaDieuTri,
                    :DangDieuTri_Text,
                    :DiChung,
                    :KQDT_Khac,
                    :NgayTuVong,
                    :LyDoTuVong,
                    :ChanDoanCuoi,
                    :ChanDoanCuoi_Text,
                    :DieuTraVien,
                    :MaDieuTraVien,
                    :LanhDaoBenhVien,
                    :MaLanhDaoBenhVien,
                    :NGUOITAO,
                    :NGUOISUA,
                    :NGAYTAO,
                    :NGAYSUA
                 )  RETURNING ID INTO :ID";
                if (ketQua.ID != 0)
                {
                    sql = @"UPDATE PhieuDieuTraCaMacCovid SET 
                    MAQUANLY = :MAQUANLY,
                    MaBenhNhan = :MaBenhNhan,
                    TenDonVi = :TenDonVi,
                    NgayBaoCao = :NgayBaoCao,
                    TenNguoiBaoCao = :TenNguoiBaoCao,
                    DienThoai = :DienThoai,
                    Email = :Email,
                    HoTenBenhNhan = :HoTenBenhNhan,
                    NgaySinh = :NgaySinh,
                    Tuoi = :Tuoi,
                    GioiTinh = :GioiTinh,
                    DanToc = :DanToc,
                    NgheNghiep = :NgheNghiep,
                    QuocTich = :QuocTich,
                    DiaChi_So = :DiaChi_So,
                    DiaChi_Thon = :DiaChi_Thon,
                    DiaChi_Phuong = :DiaChi_Phuong,
                    DiaChi_Quan = :DiaChi_Quan,
                    Tinh = :Tinh,
                    DienThoaiLienHe = :DienThoaiLienHe,
                    DiaChiKhoiPhat = :DiaChiKhoiPhat,
                    DiaChiKhoiPhat_Text = :DiaChiKhoiPhat_Text,
                    NgayKhoiPhat = :NgayKhoiPhat,
                    NgayVaoVien = :NgayVaoVien,
                    CoSoDangDieuTri = :CoSoDangDieuTri,
                    DienBienBenh = :DienBienBenh,
                    BieuHien_Sot = :BieuHien_Sot,
                    BieuHien_Ho = :BieuHien_Ho,
                    BieuHien_DauHong = :BieuHien_DauHong,
                    BieuHien_KhoTho = :BieuHien_KhoTho,
                    BieuHien_KhuuGiac = :BieuHien_KhuuGiac,
                    BieuHien_ViemPhoi = :BieuHien_ViemPhoi,
                    BieuHien_TrieuChungKhac = :BieuHien_TrieuChungKhac,
                    BieuHien_CuThe = :BieuHien_CuThe,
                    TienSuBenh = :TienSuBenh,
                    TienSuDichTe1 = :TienSuDichTe1,
                    TienSuDichTe1_Text = :TienSuDichTe1_Text,
                    TienSuDichTe2 = :TienSuDichTe2,
                    TienSuDichTe3 = :TienSuDichTe3,
                    TienSuDichTe4 = :TienSuDichTe4,
                    TienSuDichTe5 = :TienSuDichTe5,
                    TienSuDichTe6 = :TienSuDichTe6,
                    TienSuDichTe_Khac = :TienSuDichTe_Khac,
                    TTDT1 = :TTDT1,
                    TTDT2 = :TTDT2,
                    TTDT2_NgayBatDau = :TTDT2_NgayBatDau,
                    TTDT2_SoNgay = :TTDT2_SoNgay,
                    TTDT3 = :TTDT3,
                    TTDT3_NgayBatDau = :TTDT3_NgayBatDau,
                    TTDT3_SoNgay = :TTDT3_SoNgay,
                    TTDT4 = :TTDT4,
                    TTDT4_Text = :TTDT4_Text,
                    TTDT5_Text = :TTDT5_Text,
                    BachCau = :BachCau,
                    HongCau = :HongCau,
                    TieuCau = :TieuCau,
                    Hermatocrite = :Hermatocrite,
                    XQuang = :XQuang,
                    XQuang_Ngay = :XQuang_Ngay,
                    XQuang_MoTa = :XQuang_MoTa,
                    DichTyHau = :DichTyHau,
                    DichHong = :DichHong,
                    DichMui = :DichMui,
                    DichRuaMui = :DichRuaMui,
                    MauSucHong = :MauSucHong,
                    Dom = :Dom,
                    DichNoiKhiQuan = :DichNoiKhiQuan,
                    MauGiaiDoanCap = :MauGiaiDoanCap,
                    MauGiaiDoanPH = :MauGiaiDoanPH,
                    MauGiaiDoanPH_Text = :MauGiaiDoanPH_Text,
                    BenhPham_Khac = :BenhPham_Khac,
                    BenhPhamKhac_Text = :BenhPhamKhac_Text,
                    KetQuaDieuTri = :KetQuaDieuTri,
                    DangDieuTri_Text = :DangDieuTri_Text,
                    DiChung = :DiChung,
                    KQDT_Khac = :KQDT_Khac,
                    NgayTuVong = :NgayTuVong,
                    LyDoTuVong = :LyDoTuVong,
                    ChanDoanCuoi = :ChanDoanCuoi,
                    ChanDoanCuoi_Text = :ChanDoanCuoi_Text,
                    DieuTraVien = :DieuTraVien,
                    MaDieuTraVien = :MaDieuTraVien,
                    LanhDaoBenhVien = :LanhDaoBenhVien,
                    MaLanhDaoBenhVien = :MaLanhDaoBenhVien,
                    NGUOISUA = :NGUOISUA,
                    NGAYSUA = :NGAYSUA
                    WHERE ID = " + ketQua.ID;
                }
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MAQUANLY", ketQua.MaQuanLy));
                Command.Parameters.Add(new MDB.MDBParameter("MaBenhNhan", ketQua.MaBenhNhan));
                Command.Parameters.Add(new MDB.MDBParameter("TenDonVi", ketQua.TenDonVi));
                Command.Parameters.Add(new MDB.MDBParameter("NgayBaoCao", ketQua.NgayBaoCao));
                Command.Parameters.Add(new MDB.MDBParameter("TenNguoiBaoCao", ketQua.TenNguoiBaoCao));
                Command.Parameters.Add(new MDB.MDBParameter("DienThoai", ketQua.DienThoai));
                Command.Parameters.Add(new MDB.MDBParameter("Email", ketQua.Email));
                Command.Parameters.Add(new MDB.MDBParameter("HoTenBenhNhan", ketQua.HoTenBenhNhan));
                Command.Parameters.Add(new MDB.MDBParameter("NgaySinh", ketQua.NgaySinh));
                Command.Parameters.Add(new MDB.MDBParameter("Tuoi", ketQua.Tuoi));
                Command.Parameters.Add(new MDB.MDBParameter("GioiTinh", ketQua.GioiTinh));
                Command.Parameters.Add(new MDB.MDBParameter("DanToc", ketQua.DanToc));
                Command.Parameters.Add(new MDB.MDBParameter("NgheNghiep", ketQua.NgheNghiep));
                Command.Parameters.Add(new MDB.MDBParameter("QuocTich", ketQua.QuocTich));
                Command.Parameters.Add(new MDB.MDBParameter("DiaChi_So", ketQua.DiaChi_So));
                Command.Parameters.Add(new MDB.MDBParameter("DiaChi_Thon", ketQua.DiaChi_Thon));
                Command.Parameters.Add(new MDB.MDBParameter("DiaChi_Phuong", ketQua.DiaChi_Phuong));
                Command.Parameters.Add(new MDB.MDBParameter("DiaChi_Quan", ketQua.DiaChi_Quan));
                Command.Parameters.Add(new MDB.MDBParameter("Tinh", ketQua.Tinh));
                Command.Parameters.Add(new MDB.MDBParameter("DienThoaiLienHe", ketQua.DienThoaiLienHe));
                Command.Parameters.Add(new MDB.MDBParameter("DiaChiKhoiPhat", ketQua.DiaChiKhoiPhat));
                Command.Parameters.Add(new MDB.MDBParameter("DiaChiKhoiPhat_Text", ketQua.DiaChiKhoiPhat_Text));
                Command.Parameters.Add(new MDB.MDBParameter("NgayKhoiPhat", ketQua.NgayKhoiPhat));
                Command.Parameters.Add(new MDB.MDBParameter("NgayVaoVien", ketQua.NgayVaoVien));
                Command.Parameters.Add(new MDB.MDBParameter("CoSoDangDieuTri", ketQua.CoSoDangDieuTri));
                Command.Parameters.Add(new MDB.MDBParameter("DienBienBenh", ketQua.DienBienBenh));
                Command.Parameters.Add(new MDB.MDBParameter("BieuHien_Sot", ketQua.BieuHien_Sot));
                Command.Parameters.Add(new MDB.MDBParameter("BieuHien_Ho", ketQua.BieuHien_Ho));
                Command.Parameters.Add(new MDB.MDBParameter("BieuHien_DauHong", ketQua.BieuHien_DauHong));
                Command.Parameters.Add(new MDB.MDBParameter("BieuHien_KhoTho", ketQua.BieuHien_KhoTho));
                Command.Parameters.Add(new MDB.MDBParameter("BieuHien_KhuuGiac", ketQua.BieuHien_KhuuGiac));
                Command.Parameters.Add(new MDB.MDBParameter("BieuHien_ViemPhoi", ketQua.BieuHien_ViemPhoi));
                Command.Parameters.Add(new MDB.MDBParameter("BieuHien_TrieuChungKhac", ketQua.BieuHien_TrieuChungKhac));
                Command.Parameters.Add(new MDB.MDBParameter("BieuHien_CuThe", ketQua.BieuHien_CuThe));
                Command.Parameters.Add(new MDB.MDBParameter("TienSuBenh", ketQua.TienSuBenh));
                Command.Parameters.Add(new MDB.MDBParameter("TienSuDichTe1", ketQua.TienSuDichTe1));
                Command.Parameters.Add(new MDB.MDBParameter("TienSuDichTe1_Text", ketQua.TienSuDichTe1_Text));
                Command.Parameters.Add(new MDB.MDBParameter("TienSuDichTe2", ketQua.TienSuDichTe2));
                Command.Parameters.Add(new MDB.MDBParameter("TienSuDichTe3", ketQua.TienSuDichTe3));
                Command.Parameters.Add(new MDB.MDBParameter("TienSuDichTe4", ketQua.TienSuDichTe4));
                Command.Parameters.Add(new MDB.MDBParameter("TienSuDichTe5", ketQua.TienSuDichTe5));
                Command.Parameters.Add(new MDB.MDBParameter("TienSuDichTe6", ketQua.TienSuDichTe6));
                Command.Parameters.Add(new MDB.MDBParameter("TienSuDichTe_Khac", ketQua.TienSuDichTe_Khac));
                Command.Parameters.Add(new MDB.MDBParameter("TTDT1", ketQua.TTDT1));
                Command.Parameters.Add(new MDB.MDBParameter("TTDT2", ketQua.TTDT2));
                Command.Parameters.Add(new MDB.MDBParameter("TTDT2_NgayBatDau", ketQua.TTDT2_NgayBatDau));
                Command.Parameters.Add(new MDB.MDBParameter("TTDT2_SoNgay", ketQua.TTDT2_SoNgay));
                Command.Parameters.Add(new MDB.MDBParameter("TTDT3", ketQua.TTDT3));
                Command.Parameters.Add(new MDB.MDBParameter("TTDT3_NgayBatDau", ketQua.TTDT3_NgayBatDau));
                Command.Parameters.Add(new MDB.MDBParameter("TTDT3_SoNgay", ketQua.TTDT3_SoNgay));
                Command.Parameters.Add(new MDB.MDBParameter("TTDT4", ketQua.TTDT4));
                Command.Parameters.Add(new MDB.MDBParameter("TTDT4_Text", ketQua.TTDT4_Text));
                Command.Parameters.Add(new MDB.MDBParameter("TTDT5_Text", ketQua.TTDT5_Text));
                Command.Parameters.Add(new MDB.MDBParameter("BachCau", ketQua.BachCau));
                Command.Parameters.Add(new MDB.MDBParameter("HongCau", ketQua.HongCau));
                Command.Parameters.Add(new MDB.MDBParameter("TieuCau", ketQua.TieuCau));
                Command.Parameters.Add(new MDB.MDBParameter("Hermatocrite", ketQua.Hermatocrite));
                Command.Parameters.Add(new MDB.MDBParameter("XQuang", ketQua.XQuang));
                Command.Parameters.Add(new MDB.MDBParameter("XQuang_Ngay", ketQua.XQuang_Ngay));
                Command.Parameters.Add(new MDB.MDBParameter("XQuang_MoTa", ketQua.XQuang_MoTa));
                Command.Parameters.Add(new MDB.MDBParameter("DichTyHau", JsonConvert.SerializeObject(ketQua.DichTyHau)));
                Command.Parameters.Add(new MDB.MDBParameter("DichHong", JsonConvert.SerializeObject(ketQua.DichHong)));
                Command.Parameters.Add(new MDB.MDBParameter("DichMui", JsonConvert.SerializeObject(ketQua.DichMui)));
                Command.Parameters.Add(new MDB.MDBParameter("DichRuaMui", JsonConvert.SerializeObject(ketQua.DichRuaMui)));
                Command.Parameters.Add(new MDB.MDBParameter("MauSucHong", JsonConvert.SerializeObject(ketQua.MauSucHong)));
                Command.Parameters.Add(new MDB.MDBParameter("Dom", JsonConvert.SerializeObject(ketQua.Dom)));
                Command.Parameters.Add(new MDB.MDBParameter("DichNoiKhiQuan", JsonConvert.SerializeObject(ketQua.DichNoiKhiQuan)));
                Command.Parameters.Add(new MDB.MDBParameter("MauGiaiDoanCap", JsonConvert.SerializeObject(ketQua.MauGiaiDoanCap)));
                Command.Parameters.Add(new MDB.MDBParameter("MauGiaiDoanPH", JsonConvert.SerializeObject(ketQua.MauGiaiDoanPH)));
                Command.Parameters.Add(new MDB.MDBParameter("MauGiaiDoanPH_Text", ketQua.MauGiaiDoanPH_Text));
                Command.Parameters.Add(new MDB.MDBParameter("BenhPham_Khac", JsonConvert.SerializeObject(ketQua.BenhPham_Khac)));
                Command.Parameters.Add(new MDB.MDBParameter("BenhPhamKhac_Text", ketQua.BenhPhamKhac_Text));
                Command.Parameters.Add(new MDB.MDBParameter("KetQuaDieuTri", ketQua.KetQuaDieuTri));
                Command.Parameters.Add(new MDB.MDBParameter("DangDieuTri_Text", ketQua.DangDieuTri_Text));
                Command.Parameters.Add(new MDB.MDBParameter("DiChung", ketQua.DiChung));
                Command.Parameters.Add(new MDB.MDBParameter("KQDT_Khac", ketQua.KQDT_Khac));
                Command.Parameters.Add(new MDB.MDBParameter("NgayTuVong", ketQua.NgayTuVong));
                Command.Parameters.Add(new MDB.MDBParameter("LyDoTuVong", ketQua.LyDoTuVong));
                Command.Parameters.Add(new MDB.MDBParameter("ChanDoanCuoi", ketQua.ChanDoanCuoi));
                Command.Parameters.Add(new MDB.MDBParameter("ChanDoanCuoi_Text", ketQua.ChanDoanCuoi_Text));
                Command.Parameters.Add(new MDB.MDBParameter("DieuTraVien", ketQua.DieuTraVien));
                Command.Parameters.Add(new MDB.MDBParameter("MaDieuTraVien", ketQua.MaDieuTraVien));
                Command.Parameters.Add(new MDB.MDBParameter("LanhDaoBenhVien", ketQua.LanhDaoBenhVien));
                Command.Parameters.Add(new MDB.MDBParameter("MaLanhDaoBenhVien", ketQua.MaLanhDaoBenhVien));
                Command.Parameters.Add(new MDB.MDBParameter("NGUOISUA", ketQua.NguoiSua));
                Command.Parameters.Add(new MDB.MDBParameter("NGAYSUA", ketQua.NgaySua));
                if (ketQua.ID == 0)
                {
                    Command.Parameters.Add(new MDB.MDBParameter("ID", ketQua.ID));
                    Command.Parameters.Add(new MDB.MDBParameter("NGUOITAO", ketQua.NguoiTao));
                    Command.Parameters.Add(new MDB.MDBParameter("NGAYTAO", ketQua.NgayTao));
                }
                Command.BindByName = true;
                int n = Command.ExecuteNonQuery();
                if (ketQua.ID == 0)
                {
                    long nextval = Convert.ToInt64((Command.Parameters["ID"] as MDB.MDBParameter).Value);
                    ketQua.ID = nextval;
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
                string sql = "DELETE FROM PhieuDieuTraCaMacCovid WHERE ID = :ID";
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
                P.* 
            FROM
                PhieuDieuTraCaMacCovid P
            WHERE
                ID = " + id;

            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
            MDB.MDBDataAdapter adt = new MDB.MDBDataAdapter(Command);
            var ds = new DataSet();

            adt.Fill(ds, "KQ");

            ds.Tables[0].AddColumn("SOYTE", typeof(string));
            ds.Tables[0].AddColumn("BENHVIEN", typeof(string));

            ds.Tables[0].Rows[0]["SOYTE"] = XemBenhAn._HanhChinhBenhNhan.SoYTe;
            ds.Tables[0].Rows[0]["BENHVIEN"] = XemBenhAn._HanhChinhBenhNhan.BenhVien;

            ds.Tables[0].AddColumn("DichTyHau_Chon", typeof(int));
            ds.Tables[0].AddColumn("DichTyHau_Ngay", typeof(string));
            ds.Tables[0].AddColumn("DichTyHau_KetQua", typeof(string));

            ds.Tables[0].AddColumn("DichHong_Chon", typeof(int));
            ds.Tables[0].AddColumn("DichHong_Ngay", typeof(string));
            ds.Tables[0].AddColumn("DichHong_KetQua", typeof(string));

            ds.Tables[0].AddColumn("DichMui_Chon", typeof(int));
            ds.Tables[0].AddColumn("DichMui_Ngay", typeof(string));
            ds.Tables[0].AddColumn("DichMui_KetQua", typeof(string));

            ds.Tables[0].AddColumn("DichRuaMui_Chon", typeof(int));
            ds.Tables[0].AddColumn("DichRuaMui_Ngay", typeof(string));
            ds.Tables[0].AddColumn("DichRuaMui_KetQua", typeof(string));

            ds.Tables[0].AddColumn("MauSucHong_Chon", typeof(int));
            ds.Tables[0].AddColumn("MauSucHong_Ngay", typeof(string));
            ds.Tables[0].AddColumn("MauSucHong_KetQua", typeof(string));

            ds.Tables[0].AddColumn("Dom_Chon", typeof(int));
            ds.Tables[0].AddColumn("Dom_Ngay", typeof(string));
            ds.Tables[0].AddColumn("Dom_KetQua", typeof(string));

            ds.Tables[0].AddColumn("DichNoiKhiQuan_Chon", typeof(int));
            ds.Tables[0].AddColumn("DichNoiKhiQuan_Ngay", typeof(string));
            ds.Tables[0].AddColumn("DichNoiKhiQuan_KetQua", typeof(string));

            ds.Tables[0].AddColumn("MauGiaiDoanCap_Chon", typeof(int));
            ds.Tables[0].AddColumn("MauGiaiDoanCap_Ngay", typeof(string));
            ds.Tables[0].AddColumn("MauGiaiDoanCap_KetQua", typeof(string));

            ds.Tables[0].AddColumn("MauGiaiDoanPH_Chon", typeof(int));
            ds.Tables[0].AddColumn("MauGiaiDoanPH_Ngay", typeof(string));
            ds.Tables[0].AddColumn("MauGiaiDoanPH_KetQua", typeof(string));

            ds.Tables[0].AddColumn("BenhPham_Khac_Chon", typeof(int));
            ds.Tables[0].AddColumn("BenhPham_Khac_Ngay", typeof(string));
            ds.Tables[0].AddColumn("BenhPham_Khac_KetQua", typeof(string));
  
            BenhPhamXN DichTyHau = JsonConvert.DeserializeObject<BenhPhamXN>(ds.Tables[0].Rows[0]["DichTyHau"].ToString());
            if(DichTyHau != null)
            {
                ds.Tables[0].Rows[0]["DichTyHau_Chon"] = DichTyHau.Chon ? 1:0;
                ds.Tables[0].Rows[0]["DichTyHau_Ngay"] = DichTyHau.NgayLay.HasValue ? DichTyHau.NgayLay.Value.ToString("dd/MM/yyyy") :"";
                ds.Tables[0].Rows[0]["DichTyHau_KetQua"] = DichTyHau.KetQua;
            }    
            BenhPhamXN DichHong = JsonConvert.DeserializeObject<BenhPhamXN>(ds.Tables[0].Rows[0]["DichHong"].ToString());
            if (DichHong != null)
            {
                ds.Tables[0].Rows[0]["DichHong_Chon"] = DichHong.Chon ? 1 : 0;
                ds.Tables[0].Rows[0]["DichHong_Ngay"] = DichHong.NgayLay.HasValue ? DichHong.NgayLay.Value.ToString("dd/MM/yyyy") : "";
                ds.Tables[0].Rows[0]["DichHong_KetQua"] = DichHong.KetQua;
            }

            BenhPhamXN DichMui = JsonConvert.DeserializeObject<BenhPhamXN>(ds.Tables[0].Rows[0]["DichMui"].ToString());
            if (DichMui != null)
            {
                ds.Tables[0].Rows[0]["DichMui_Chon"] = DichMui.Chon ? 1 : 0;
                ds.Tables[0].Rows[0]["DichMui_Ngay"] = DichMui.NgayLay.HasValue ? DichMui.NgayLay.Value.ToString("dd/MM/yyyy") : "";
                ds.Tables[0].Rows[0]["DichMui_KetQua"] = DichMui.KetQua;
            }

            BenhPhamXN DichRuaMui = JsonConvert.DeserializeObject<BenhPhamXN>(ds.Tables[0].Rows[0]["DichRuaMui"].ToString());
            if (DichRuaMui != null)
            {
                ds.Tables[0].Rows[0]["DichRuaMui_Chon"] = DichRuaMui.Chon ? 1 : 0;
                ds.Tables[0].Rows[0]["DichRuaMui_Ngay"] = DichRuaMui.NgayLay.HasValue ? DichRuaMui.NgayLay.Value.ToString("dd/MM/yyyy") : "";
                ds.Tables[0].Rows[0]["DichRuaMui_KetQua"] = DichRuaMui.KetQua;
            }
            BenhPhamXN MauSucHong = JsonConvert.DeserializeObject<BenhPhamXN>(ds.Tables[0].Rows[0]["MauSucHong"].ToString());
            if (MauSucHong != null)
            {
                ds.Tables[0].Rows[0]["MauSucHong_Chon"] = MauSucHong.Chon ? 1 : 0;
                ds.Tables[0].Rows[0]["MauSucHong_Ngay"] = MauSucHong.NgayLay.HasValue ? MauSucHong.NgayLay.Value.ToString("dd/MM/yyyy") : "";
                ds.Tables[0].Rows[0]["MauSucHong_KetQua"] = MauSucHong.KetQua;
            }
            BenhPhamXN Dom = JsonConvert.DeserializeObject<BenhPhamXN>(ds.Tables[0].Rows[0]["Dom"].ToString());
            if (Dom != null)
            {
                ds.Tables[0].Rows[0]["Dom_Chon"] = Dom.Chon ? 1 : 0;
                ds.Tables[0].Rows[0]["Dom_Ngay"] = Dom.NgayLay.HasValue ? Dom.NgayLay.Value.ToString("dd/MM/yyyy") : "";
                ds.Tables[0].Rows[0]["Dom_KetQua"] = Dom.KetQua;
            }
            BenhPhamXN DichNoiKhiQuan = JsonConvert.DeserializeObject<BenhPhamXN>(ds.Tables[0].Rows[0]["DichNoiKhiQuan"].ToString());
            if (DichNoiKhiQuan != null)
            {
                ds.Tables[0].Rows[0]["DichNoiKhiQuan_Chon"] = DichNoiKhiQuan.Chon ? 1 : 0;
                ds.Tables[0].Rows[0]["DichNoiKhiQuan_Ngay"] = DichNoiKhiQuan.NgayLay.HasValue ? DichNoiKhiQuan.NgayLay.Value.ToString("dd/MM/yyyy") : "";
                ds.Tables[0].Rows[0]["DichNoiKhiQuan_KetQua"] = DichNoiKhiQuan.KetQua;
            }

            BenhPhamXN MauGiaiDoanCap = JsonConvert.DeserializeObject<BenhPhamXN>(ds.Tables[0].Rows[0]["MauGiaiDoanCap"].ToString());
            if (MauGiaiDoanCap != null)
            {
                ds.Tables[0].Rows[0]["MauGiaiDoanCap_Chon"] = MauGiaiDoanCap.Chon ? 1 : 0;
                ds.Tables[0].Rows[0]["MauGiaiDoanCap_Ngay"] = MauGiaiDoanCap.NgayLay.HasValue ? MauGiaiDoanCap.NgayLay.Value.ToString("dd/MM/yyyy") : "";
                ds.Tables[0].Rows[0]["MauGiaiDoanCap_KetQua"] = MauGiaiDoanCap.KetQua;
            }
            BenhPhamXN MauGiaiDoanPH = JsonConvert.DeserializeObject<BenhPhamXN>(ds.Tables[0].Rows[0]["MauGiaiDoanPH"].ToString());
            if (MauGiaiDoanPH != null)
            {
                ds.Tables[0].Rows[0]["MauGiaiDoanPH_Chon"] = MauGiaiDoanPH.Chon ? 1 : 0;
                ds.Tables[0].Rows[0]["MauGiaiDoanPH_Ngay"] = MauGiaiDoanPH.NgayLay.HasValue ? MauGiaiDoanPH.NgayLay.Value.ToString("dd/MM/yyyy") : "";
                ds.Tables[0].Rows[0]["MauGiaiDoanPH_KetQua"] = MauGiaiDoanPH.KetQua;
            }
            BenhPhamXN BenhPham_Khac = JsonConvert.DeserializeObject<BenhPhamXN>(ds.Tables[0].Rows[0]["BenhPham_Khac"].ToString());
            if (BenhPham_Khac != null)
            {
                ds.Tables[0].Rows[0]["BenhPham_Khac_Chon"] = BenhPham_Khac.Chon ? 1 : 0;
                ds.Tables[0].Rows[0]["BenhPham_Khac_Ngay"] = BenhPham_Khac.NgayLay.HasValue ? BenhPham_Khac.NgayLay.Value.ToString("dd/MM/yyyy") : "";
                ds.Tables[0].Rows[0]["BenhPham_Khac_KetQua"] = BenhPham_Khac.KetQua;
            }


            return ds;
        }
    }

}
