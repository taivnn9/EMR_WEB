using EMR.KyDienTu;
using Newtonsoft.Json;
using PMS.Access;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMR_MAIN.DATABASE.Other
{
    public class PhieuXetNghiemViKhuanLao2 : ThongTinKy
    {
        public PhieuXetNghiemViKhuanLao2()
        {
            TableName = "PhieuXetNghiemViKhuanLao2";
            TablePrimaryKeyName = "ID";
            IDMauPhieu = (int)DanhMucPhieu.PXNVKLMM;
            TenMauPhieu = DanhMucPhieu.PXNVKLMM.Description();
        }
        [MoTaDuLieu("Mã định danh")]
		public long ID { get; set; }
        [MoTaDuLieu("Mã quản lý: mã duy nhất trong 1 đợt khám chữa bệnh (kcb), không trùng giữa các đợt kcb khác nhau","",1)]
		public decimal MaQuanLy { get; set; }
        [MoTaDuLieu("Mã bệnh nhân")]
		public string MaBenhNhan { get; set; }
        public string DonViYeuCau { get; set; }
        public string HoVaTenNguoiBenh { get; set; }
        [MoTaDuLieu("Tuổi bệnh nhân")]
		public string Tuoi { get; set; }
        [MoTaDuLieu("Giới tính bệnh nhân")]
		public string GioiTinh { get; set; }
        public string Thon { get; set; }
        public string PhuongXa { get; set; }
        public string QuanHuyen { get; set; }
        public string Tinh { get; set; }
        public string DienThoai { get; set; }
        public string SoDKDT { get; set; }
        public string SoETBM { get; set; }
        public bool[] LyDoXetNghiem_Array { get; } = new bool[] { false, false, false, false, false, false };
        public string LyDoXetNghiem
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < LyDoXetNghiem_Array.Length; i++)
                    temp += (LyDoXetNghiem_Array[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        LyDoXetNghiem_Array[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public string ThangThu { get; set; }
        public string XetNghiem_Khac { get; set; }
        public bool[] TienSuDTLao_Array { get; } = new bool[] { false, false };
        public int TienSuDTLao
        {
            get
            {
                return Array.IndexOf(TienSuDTLao_Array, true) + 1;
            }
            set
            {
                for (int i = 0; i < TienSuDTLao_Array.Length; i++)
                {
                    if (i == (value - 1)) TienSuDTLao_Array[i] = true;
                    else TienSuDTLao_Array[i] = false;
                }
            }
        }
        public string TinhTrangH { get; set; }
        public bool[] LoaiBenhPham_Array { get; } = new bool[] { false, false };
        public int LoaiBenhPham
        {
            get
            {
                return Array.IndexOf(LoaiBenhPham_Array, true) + 1;
            }
            set
            {
                for (int i = 0; i < LoaiBenhPham_Array.Length; i++)
                {
                    if (i == (value - 1)) LoaiBenhPham_Array[i] = true;
                    else LoaiBenhPham_Array[i] = false;
                }
            }
        }
        public string LoaiBenhPham_Khac { get; set; }
        public DateTime? ThoiGianLayMau { get; set; }
        public string NguoiLayMau { get; set; }
        public string MaNguoiLayMau { get; set; }
        public bool[] LoaiXetNghiemYeuCau_Array { get; } = new bool[] { false, false, false, false, false, false, false, false, false, false, false, false, false};
        public string LoaiXetNghiemYeuCau
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < LoaiXetNghiemYeuCau_Array.Length; i++)
                    temp += (LoaiXetNghiemYeuCau_Array[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        LoaiXetNghiemYeuCau_Array[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public string MauSoNeelsen { get; set; }
        public string MauSoHuynhQuan { get; set; }
        public string LanThuXpert { get; set; }
        public string LoaiXetNghiem_LyDo { get; set; }
        public bool[] ChanDoanLao_Array { get; } = new bool[] { false, false, false, false };
        [MoTaDuLieu("Chẩn đoán bệnh")]
		public string ChanDoanLao
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < ChanDoanLao_Array.Length; i++)
                    temp += (ChanDoanLao_Array[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        ChanDoanLao_Array[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public string LaoNgoaiPhoi_Text { get; set; }
        public bool[] ChanDoanLaoDaKhangThuoc_Array { get; } = new bool[] { false, false, false, false, false, false, false, false };
        [MoTaDuLieu("Chẩn đoán Lao đã kháng thuốc")]
		public string ChanDoanLaoDaKhangThuoc
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < ChanDoanLaoDaKhangThuoc_Array.Length; i++)
                    temp += (ChanDoanLaoDaKhangThuoc_Array[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        ChanDoanLaoDaKhangThuoc_Array[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public bool[] ChanDoanLaoTien_Array { get; } = new bool[] { false, false, false, false};
        [MoTaDuLieu("Chẩn đoán Lao tiền/siêu kháng thuốc")]
		public string ChanDoanLaoTien
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < ChanDoanLaoTien_Array.Length; i++)
                    temp += (ChanDoanLaoTien_Array[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        ChanDoanLaoTien_Array[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public string NghiThatBai_ThangThu { get; set; }
        [MoTaDuLieu("Chẩn đoán Lao tiền/siêu kháng thuốc - nội dung")]
		public string ChanDoanLaoTien_text { get; set; }
        public string DoiTuongKhac { get; set; }
        public string NguoiYeuCauXetNghiem { get; set; }
        public string MaNguoiYeuCauXetNghiem { get; set; }
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

    public class PhieuXetNghiemViKhuanLao2Func
    {
        public const string TableName = "PhieuXetNghiemViKhuanLao2";
        public const string TablePrimaryKeyName = "ID";
        public static List<PhieuXetNghiemViKhuanLao2> GetListData(MDB.MDBConnection _OracleConnection, decimal maquanly)
        {
            List<PhieuXetNghiemViKhuanLao2> list = new List<PhieuXetNghiemViKhuanLao2>();
            try
            {
                string sql = @"SELECT * FROM PhieuXetNghiemViKhuanLao2 where MaQuanLy = :MaQuanLy";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, _OracleConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", maquanly));
                MDB.MDBDataReader DataReader = Command.ExecuteReader();
                while (DataReader.Read())
                {
                    PhieuXetNghiemViKhuanLao2 data = new PhieuXetNghiemViKhuanLao2();
                    data.ID = Convert.ToInt64(DataReader.GetLong("ID").ToString());
                    data.MaQuanLy = maquanly;
                    data.MaBenhNhan = DataReader["MaBenhNhan"].ToString();
                    data.HoVaTenNguoiBenh = XemBenhAn._HanhChinhBenhNhan.TenBenhNhan;
                    data.Tuoi = XemBenhAn._HanhChinhBenhNhan.Tuoi;
                    data.GioiTinh = XemBenhAn._HanhChinhBenhNhan.GioiTinh.Description();
                    data.DonViYeuCau = DataReader["DonViYeuCau"].ToString();
                    data.Thon = DataReader["Thon"].ToString();
                    data.PhuongXa = DataReader["PhuongXa"].ToString();
                    data.QuanHuyen = DataReader["QuanHuyen"].ToString();
                    data.Tinh = DataReader["Tinh"].ToString();
                    data.DienThoai = DataReader["DienThoai"].ToString();
                    data.SoDKDT = DataReader["SoDKDT"].ToString();
                    data.SoETBM = DataReader["SoETBM"].ToString();
                    data.LyDoXetNghiem = DataReader["LyDoXetNghiem"].ToString();
                    data.MauSoNeelsen = DataReader["MauSoNeelsen"].ToString();
                    data.MauSoHuynhQuan = DataReader["MauSoHuynhQuan"].ToString();
                    data.LanThuXpert = DataReader["LanThuXpert"].ToString();
                    data.ThangThu = DataReader["ThangThu"].ToString();
                    data.XetNghiem_Khac = DataReader["XetNghiem_Khac"].ToString();
                    int intTemp = 0;
                    data.TienSuDTLao = int.TryParse(DataReader["TienSuDTLao"].ToString(), out intTemp) ? intTemp : 0;
                    data.TinhTrangH = DataReader["TinhTrangH"].ToString();
                    intTemp = 0;
                    data.LoaiBenhPham = int.TryParse(DataReader["LoaiBenhPham"].ToString(), out intTemp) ? intTemp : 0;
                    data.LoaiBenhPham_Khac = DataReader["LoaiBenhPham_Khac"].ToString();
                    data.ThoiGianLayMau = DataReader["ThoiGianLayMau"] == DBNull.Value ? (DateTime?)null : DataReader.GetDate("ThoiGianLayMau");
                    data.NguoiLayMau = DataReader["NguoiLayMau"].ToString();
                    data.MaNguoiLayMau = DataReader["MaNguoiLayMau"].ToString();
                    data.LoaiXetNghiemYeuCau = DataReader["LoaiXetNghiemYeuCau"].ToString();
                    data.LoaiXetNghiem_LyDo = DataReader["LoaiXetNghiem_LyDo"].ToString();
                    data.ChanDoanLao = DataReader["ChanDoanLao"].ToString();
                    data.LaoNgoaiPhoi_Text = DataReader["LaoNgoaiPhoi_Text"].ToString();
                    data.ChanDoanLaoDaKhangThuoc =DataReader["ChanDoanLaoDaKhangThuoc"].ToString();
                    data.ChanDoanLaoTien = DataReader["ChanDoanLaoTien"].ToString();
                    data.NghiThatBai_ThangThu = DataReader["NghiThatBai_ThangThu"].ToString();
                    data.ChanDoanLaoTien_text = DataReader["ChanDoanLaoTien_text"].ToString();
                    data.DoiTuongKhac = DataReader["DoiTuongKhac"].ToString();
                    data.NguoiYeuCauXetNghiem = DataReader["NguoiYeuCauXetNghiem"].ToString();
                    data.MaNguoiYeuCauXetNghiem = DataReader["MaNguoiYeuCauXetNghiem"].ToString();

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
        public static bool InsertOrUpdate(MDB.MDBConnection MyConnection, ref PhieuXetNghiemViKhuanLao2 bangTheoDoi)
        {
            try
            {
                string sql = @"INSERT INTO PhieuXetNghiemViKhuanLao2
                (
                    MAQUANLY,
                    MaBenhNhan,
                    DonViYeuCau,
                    Thon,
                    PhuongXa,
                    QuanHuyen,
                    Tinh,
                    DienThoai,
                    SoDKDT,
                    SoETBM,
                    LyDoXetNghiem,
                    ThangThu,
                    XetNghiem_Khac,
                    TienSuDTLao,
                    TinhTrangH,
                    LoaiBenhPham,
                    LoaiBenhPham_Khac,
                    ThoiGianLayMau,
                    NguoiLayMau,
                    MaNguoiLayMau ,
                    LoaiXetNghiemYeuCau,
                    MauSoNeelsen,
                    MauSoHuynhQuan,
                    LanThuXpert,
                    LoaiXetNghiem_LyDo,
                    ChanDoanLao,
                    LaoNgoaiPhoi_Text,
                    ChanDoanLaoDaKhangThuoc,
                    ChanDoanLaoTien,
                    NghiThatBai_ThangThu,
                    ChanDoanLaoTien_text,
                    DoiTuongKhac,
                    NguoiYeuCauXetNghiem,
                    MaNguoiYeuCauXetNghiem,
                    NGUOITAO,
                    NGUOISUA,
                    NGAYTAO,
                    NGAYSUA)  VALUES
                 (
                    :MAQUANLY,
                    :MaBenhNhan,
                    :DonViYeuCau,
                    :Thon,
                    :PhuongXa,
                    :QuanHuyen,
                    :Tinh,
                    :DienThoai,
                    :SoDKDT,
                    :SoETBM,
                    :LyDoXetNghiem,
                    :ThangThu,
                    :XetNghiem_Khac,
                    :TienSuDTLao,
                    :TinhTrangH,
                    :LoaiBenhPham,
                    :LoaiBenhPham_Khac,
                    :ThoiGianLayMau,
                    :NguoiLayMau,
                    :MaNguoiLayMau,
                    :LoaiXetNghiemYeuCau,
                    :MauSoNeelsen,
                    :MauSoHuynhQuan,
                    :LanThuXpert,
                    :LoaiXetNghiem_LyDo,
                    :ChanDoanLao,
                    :LaoNgoaiPhoi_Text,
                    :ChanDoanLaoDaKhangThuoc,
                    :ChanDoanLaoTien,
                    :NghiThatBai_ThangThu,
                    :ChanDoanLaoTien_text,
                    :DoiTuongKhac,
                    :NguoiYeuCauXetNghiem,
                    :MaNguoiYeuCauXetNghiem,
                    :NGUOITAO,
                    :NGUOISUA,
                    :NGAYTAO,
                    :NGAYSUA
                 )  RETURNING ID INTO :ID";
                if (bangTheoDoi.ID != 0)
                {
                    sql = @"UPDATE PhieuXetNghiemViKhuanLao2 SET 
                    MAQUANLY = :MAQUANLY,
                    MaBenhNhan = :MaBenhNhan,
                    DonViYeuCau = :DonViYeuCau,
                    Thon = :Thon,
                    PhuongXa = :PhuongXa,
                    QuanHuyen = :QuanHuyen,
                    Tinh = :Tinh,
                    DienThoai = :DienThoai,
                    SoDKDT = :SoDKDT,
                    SoETBM = :SoETBM,
                    LyDoXetNghiem = :LyDoXetNghiem,
                    ThangThu = :ThangThu,
                    XetNghiem_Khac = :XetNghiem_Khac,
                    TienSuDTLao = :TienSuDTLao,
                    TinhTrangH = :TinhTrangH,
                    LoaiBenhPham = :LoaiBenhPham,
                    LoaiBenhPham_Khac = :LoaiBenhPham_Khac,
                    ThoiGianLayMau = :ThoiGianLayMau,
                    NguoiLayMau = :NguoiLayMau,
                    MaNguoiLayMau  = :MaNguoiLayMau,
                    LoaiXetNghiemYeuCau  = :LoaiXetNghiemYeuCau,
                    LoaiXetNghiem_LyDo  = :LoaiXetNghiem_LyDo,
                    ChanDoanLao  = :ChanDoanLao,
                    LaoNgoaiPhoi_Text  = :LaoNgoaiPhoi_Text,
                    ChanDoanLaoDaKhangThuoc  = :ChanDoanLaoDaKhangThuoc,
                    ChanDoanLaoTien  = :ChanDoanLaoTien,
                    NghiThatBai_ThangThu = :NghiThatBai_ThangThu,
                    ChanDoanLaoTien_text  = :ChanDoanLaoTien_text,
                    DoiTuongKhac  = :DoiTuongKhac,
                    NguoiYeuCauXetNghiem  = :NguoiYeuCauXetNghiem,
                    MaNguoiYeuCauXetNghiem  = :MaNguoiYeuCauXetNghiem,
                    NGUOISUA = :NGUOISUA,
                    NGAYSUA = :NGAYSUA
                    WHERE ID = " + bangTheoDoi.ID;
                }
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MAQUANLY", bangTheoDoi.MaQuanLy));
                Command.Parameters.Add(new MDB.MDBParameter("MaBenhNhan", bangTheoDoi.MaBenhNhan));
                Command.Parameters.Add(new MDB.MDBParameter("DonViYeuCau", bangTheoDoi.DonViYeuCau));
                Command.Parameters.Add(new MDB.MDBParameter("Thon", bangTheoDoi.Thon));
                Command.Parameters.Add(new MDB.MDBParameter("PhuongXa", bangTheoDoi.PhuongXa));
                Command.Parameters.Add(new MDB.MDBParameter("QuanHuyen", bangTheoDoi.QuanHuyen));
                Command.Parameters.Add(new MDB.MDBParameter("Tinh", bangTheoDoi.Tinh));
                Command.Parameters.Add(new MDB.MDBParameter("DienThoai", bangTheoDoi.DienThoai));
                Command.Parameters.Add(new MDB.MDBParameter("SoDKDT", bangTheoDoi.SoDKDT));
                Command.Parameters.Add(new MDB.MDBParameter("SoETBM", bangTheoDoi.SoETBM));
                Command.Parameters.Add(new MDB.MDBParameter("LyDoXetNghiem", bangTheoDoi.LyDoXetNghiem));
                Command.Parameters.Add(new MDB.MDBParameter("ThangThu", bangTheoDoi.ThangThu));
                Command.Parameters.Add(new MDB.MDBParameter("XetNghiem_Khac", bangTheoDoi.XetNghiem_Khac));
                Command.Parameters.Add(new MDB.MDBParameter("TienSuDTLao", bangTheoDoi.TienSuDTLao));
                Command.Parameters.Add(new MDB.MDBParameter("TinhTrangH", bangTheoDoi.TinhTrangH));
                Command.Parameters.Add(new MDB.MDBParameter("LoaiBenhPham", bangTheoDoi.LoaiBenhPham));
                Command.Parameters.Add(new MDB.MDBParameter("LoaiBenhPham_Khac", bangTheoDoi.LoaiBenhPham_Khac));
                Command.Parameters.Add(new MDB.MDBParameter("ThoiGianLayMau", bangTheoDoi.ThoiGianLayMau));
                Command.Parameters.Add(new MDB.MDBParameter("NguoiLayMau", bangTheoDoi.NguoiLayMau));
                Command.Parameters.Add(new MDB.MDBParameter("MaNguoiLayMau", bangTheoDoi.MaNguoiLayMau));
                Command.Parameters.Add(new MDB.MDBParameter("LoaiXetNghiemYeuCau", bangTheoDoi.LoaiXetNghiemYeuCau));
                Command.Parameters.Add(new MDB.MDBParameter("MauSoNeelsen", bangTheoDoi.MauSoNeelsen));
                Command.Parameters.Add(new MDB.MDBParameter("MauSoHuynhQuan", bangTheoDoi.MauSoHuynhQuan));
                Command.Parameters.Add(new MDB.MDBParameter("LanThuXpert", bangTheoDoi.LanThuXpert));
                Command.Parameters.Add(new MDB.MDBParameter("LoaiXetNghiem_LyDo", bangTheoDoi.LoaiXetNghiem_LyDo));
                Command.Parameters.Add(new MDB.MDBParameter("ChanDoanLao", bangTheoDoi.ChanDoanLao));
                Command.Parameters.Add(new MDB.MDBParameter("LaoNgoaiPhoi_Text", bangTheoDoi.LaoNgoaiPhoi_Text));
                Command.Parameters.Add(new MDB.MDBParameter("ChanDoanLaoDaKhangThuoc", bangTheoDoi.ChanDoanLaoDaKhangThuoc));
                Command.Parameters.Add(new MDB.MDBParameter("ChanDoanLaoTien", bangTheoDoi.ChanDoanLaoTien));
                Command.Parameters.Add(new MDB.MDBParameter("NghiThatBai_ThangThu", bangTheoDoi.NghiThatBai_ThangThu));
                Command.Parameters.Add(new MDB.MDBParameter("ChanDoanLaoTien_text", bangTheoDoi.ChanDoanLaoTien_text));
                Command.Parameters.Add(new MDB.MDBParameter("DoiTuongKhac", bangTheoDoi.DoiTuongKhac));
                Command.Parameters.Add(new MDB.MDBParameter("NguoiYeuCauXetNghiem", bangTheoDoi.NguoiYeuCauXetNghiem));
                Command.Parameters.Add(new MDB.MDBParameter("MaNguoiYeuCauXetNghiem", bangTheoDoi.MaNguoiYeuCauXetNghiem));

                Command.Parameters.Add(new MDB.MDBParameter("NGUOISUA", bangTheoDoi.NguoiSua));
                Command.Parameters.Add(new MDB.MDBParameter("NGAYSUA", bangTheoDoi.NgaySua));
                if (bangTheoDoi.ID == 0)
                {
                    Command.Parameters.Add(new MDB.MDBParameter("ID", bangTheoDoi.ID));
                    Command.Parameters.Add(new MDB.MDBParameter("NGUOITAO", bangTheoDoi.NguoiTao));
                    Command.Parameters.Add(new MDB.MDBParameter("NGAYTAO", bangTheoDoi.NgayTao));
                }
                Command.BindByName = true;
                int n = Command.ExecuteNonQuery();
                if (bangTheoDoi.ID == 0)
                {
                    long nextval = Convert.ToInt64((Command.Parameters["ID"] as MDB.MDBParameter).Value);
                    bangTheoDoi.ID = nextval;
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
                string sql = "DELETE FROM PhieuXetNghiemViKhuanLao2 WHERE ID = :ID";
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
                B.MAQUANLY,
                B.MaBenhNhan,
                B.DonViYeuCau,
                B.Thon,
                B.PhuongXa,
                B.QuanHuyen,
                B.Tinh,
                B.DienThoai,
                B.SoDKDT,
                B.SoETBM,
                B.LyDoXetNghiem,
                B.ThangThu,
                B.XetNghiem_Khac,
                B.TienSuDTLao,
                B.TinhTrangH,
                B.LoaiBenhPham,
                B.LoaiBenhPham_Khac,
                B.ThoiGianLayMau,
                B.NguoiLayMau,
                B.MaNguoiLayMau,
                B.LoaiXetNghiemYeuCau, 
                B.MauSoNeelsen,
                B.MauSoHuynhQuan,
                B.LanThuXpert,
                B.LoaiXetNghiem_LyDo, 
                B.ChanDoanLao,
                B.LaoNgoaiPhoi_Text, 
                B.ChanDoanLaoDaKhangThuoc, 
                B.ChanDoanLaoTien,
                B.NghiThatBai_ThangThu,
                B.ChanDoanLaoTien_text, 
                B.DoiTuongKhac, 
                B.NguoiYeuCauXetNghiem,
                B.MaNguoiYeuCauXetNghiem, 
                B.NgayTao,
                H.TENBENHNHAN,
                H.Tuoi,
                H.GioiTinh,
                H.SOYTE,
                H.BENHVIEN,
                T.KHOA
            FROM
                PhieuXetNghiemViKhuanLao2 B
                LEFT JOIN HANHCHINHBENHNHAN H ON B.MABENHNHAN = H.MABENHNHAN
                LEFT JOIN THONGTINDIEUTRI T ON B.MAQUANLY = T.MAQUANLY
            WHERE
                ID = " + id;

            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
            MDB.MDBDataAdapter adt = new MDB.MDBDataAdapter(Command);
            var ds = new DataSet();

            adt.Fill(ds, "Table");
            return ds;
        }
    }
}
