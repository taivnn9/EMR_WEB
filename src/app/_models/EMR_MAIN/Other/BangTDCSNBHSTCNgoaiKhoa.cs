using EMR.KyDienTu;
using Newtonsoft.Json;
using NLog;
using PMS.Access;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Diagnostics;
using System.Text;

namespace EMR_MAIN.DATABASE.Other
{
    public class BangTDCSNBHSTCNgoaiKhoa : ThongTinKy
    {
        public BangTDCSNBHSTCNgoaiKhoa()
        {
            TableName = "BangTDCSNBHSTCNgoaiKhoa";
            TablePrimaryKeyName = "ID";
            IDMauPhieu = (int)DanhMucPhieu.BTDCSNBHSTCNK;
            TenMauPhieu = DanhMucPhieu.BTDCSNBHSTCNK.Description();
        }
        [MoTaDuLieu("Mã định danh")]
        public decimal ID { set; get; }
        [MoTaDuLieu("Mã quản lý: mã duy nhất trong 1 đợt khám chữa bệnh (kcb), không trùng giữa các đợt kcb khác nhau", "", 1)]
        public decimal MaQuanLy { set; get; }
        [MoTaDuLieu("Mã bệnh nhân")]
        public string MaBenhNhan { set; get; }
        [MoTaDuLieu("Tờ số")]
        public string ToSo { get; set; }
        [MoTaDuLieu("Tên khoa")]
        public string TenKhoa { set; get; }
        [MoTaDuLieu("Mã khoa")]
        public string MaKhoa { set; get; }
        [MoTaDuLieu("Họ và tên người bệnh")]
        public string HoTenNguoiBenh { get; set; }
        [MoTaDuLieu("Họ và tên người bệnh")]
        public string Tuoi { get; set; }
        [MoTaDuLieu("Giới tính")]
        public string GioiTinh { get; set; }
        [MoTaDuLieu("BMI")]
        public string BMI { get; set; }
        [MoTaDuLieu("Cân nặng")]
        public string CanNang { get; set; }
        [MoTaDuLieu("Nhóm máu")]
        public string NhomMau { get; set; }
        [MoTaDuLieu("Ngày điều trị")]
        public DateTime? NgayDieuTri { get; set; }
        [MoTaDuLieu("Chẩn đoán")]
        public string ChanDoan { get; set; }
        [MoTaDuLieu("Bs điều trị")]
        public string BSDieuTri { get; set; }
        [MoTaDuLieu("Mã Bs điều trị")]
        public string MaBSDieuTri { get; set; }
        [MoTaDuLieu("Điều dưỡng ca 1")]
        public string DieuDuongCa1 { get; set; }
        [MoTaDuLieu("Mã Điều dưỡng ca 1")]
        public string MaDieuDuongCa1 { get; set; }
        [MoTaDuLieu("Điều dưỡng ca 2")]
        public string DieuDuongCa2 { get; set; }
        [MoTaDuLieu("Mã Điều dưỡng ca 2")]
        public string MaDieuDuongCa2 { get; set; }
        [MoTaDuLieu("NKQ/Canuyn KQ ")]
        public string Canuyn_KQ { get; set; }
        [MoTaDuLieu("Sonde dạ dày")]
        public string SondeDaDay { get; set; }
        [MoTaDuLieu("Sonde tiểu")]
        public string SondeTieu { get; set; }
        [MoTaDuLieu("Loét ép (vị trí/độ)")]
        public string LoetEp { get; set; }
        [MoTaDuLieu("Những vị trí tổn thương khác")]
        public string NhungViTriTonThuongKhac { get; set; }
        [MoTaDuLieu("Phân, số lần")]
        public string Phan_SoLan { get; set; }
        [MoTaDuLieu("Phân, số lượng")]
        public string Phan_SoLuong { get; set; }
        [MoTaDuLieu("Phân, tính chất")]
        public string Phan_TinhChat { get; set; }
        [MoTaDuLieu("Đờm, số lượng")]
        public string Dom_SoLuong { get; set; }
        [MoTaDuLieu("Đờm, tính chất")]
        public string Dom_TinhChat { get; set; }
        [MoTaDuLieu("Dẫn lưu 1")]
        public string DL_1 { get; set; }
        [MoTaDuLieu("Dẫn lưu 2")]
        public string DL_2 { get; set; }
        [MoTaDuLieu("Dẫn lưu 3")]
        public string DL_3 { get; set; }
        [MoTaDuLieu("Máu (loại/số lượng/ tốc độ truyền")]
        public string Mau { get; set; }
        [MoTaDuLieu("Bilan dịch, máu 12h")]
        public string Mau_12h { get; set; }
        [MoTaDuLieu("Bilan dịch, máu 24h")]
        public string Mau_24h { get; set; }
        [MoTaDuLieu("Bilan dịch, Ăn 12h")]
        public string An_12h { get; set; }
        [MoTaDuLieu("Bilan dịch, Ăn 24h")]
        public string An_24h { get; set; }
        [MoTaDuLieu("Bilan dịch, Thuốc/dịch 12h")]
        public string ThuocDich_12h { get; set; }
        [MoTaDuLieu("Bilan dịch, Thuốc/dịch 24h")]
        public string ThuocDich_24h { get; set; }
        [MoTaDuLieu("Bilan dịch, Dẫn lưu 12h")]
        public string DanLuu_12h { get; set; }
        [MoTaDuLieu("Bilan dịch, Dẫn lưu 24h")]
        public string DanLuu_24h { get; set; }
        [MoTaDuLieu("Bilan dịch, Qua da 12h")]
        public string QuaDa_12h { get; set; }
        [MoTaDuLieu("Bilan dịch, Qua da 24h")]
        public string QuaDa_24h { get; set; }
        [MoTaDuLieu("Bilan dịch, Tiểu 12h")]
        public string Tieu_12h { get; set; }
        [MoTaDuLieu("Bilan dịch, Tiểu 24h")]
        public string Tieu_24h { get; set; }
        [MoTaDuLieu("Bilan dịch, Bilan 12h")]
        public string Bilan_12h { get; set; }
        [MoTaDuLieu("Bilan dịch, Bilan 24h")]
        public string Bilan_24h { get; set; }
        public ObservableCollection<BangTDCSNBHSTCNgoaiKhoa_CT> ChiTiets { get; set; }
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
        public BangTDCSNBHSTCNgoaiKhoa Clone()
        {
            BangTDCSNBHSTCNgoaiKhoa other = (BangTDCSNBHSTCNgoaiKhoa)this.MemberwiseClone();
            other.ChiTiets = new ObservableCollection<BangTDCSNBHSTCNgoaiKhoa_CT>();
            if (this.ChiTiets != null)
                foreach (BangTDCSNBHSTCNgoaiKhoa_CT item in this.ChiTiets)
                {
                    other.ChiTiets.Add(item.Clone());
                }
            return other;
        }
    }
    public class BangTDCSNBHSTCNgoaiKhoa_CT : ThongTinKy
    {
        public BangTDCSNBHSTCNgoaiKhoa_CT()
        {
            TableName = "BangTDCSNBHSTCNgoaiKhoa_CT";
            TablePrimaryKeyName = "ID";
        }
        [MoTaDuLieu("Mã định danh")]
        public decimal ID { set; get; }
        [MoTaDuLieu("Mã định danh")]
        public decimal IDPhieu { set; get; }
        public DateTime ThoiGian { set; get; }
        [MoTaDuLieu("Mạch")]
        public double? Mach { get; set; }
        [MoTaDuLieu("Nhiệt độ")]
        public double? NhietDo { get; set; }
        [MoTaDuLieu("Huyết áp min")]
        public string HuyetAp_Min { get; set; }
        [MoTaDuLieu("Huyết áp max")]
        public string HuyetAp_Max { get; set; }
        [MoTaDuLieu("Glassgow")]
        public string Glassgow { get; set; }
        [MoTaDuLieu("Tình trạng liệt")]
        public string TinhTrangLiet { get; set; }
        [MoTaDuLieu("Đánh giá khác")]
        public string DanhGiaKhac { get; set; }
        [MoTaDuLieu("MODE/Liệu pháp  Oxy")]
        public string LieuPhapOxy { get; set; }
        [MoTaDuLieu("Vt/PC/PS")]
        public string VtPCPS { get; set; }
        [MoTaDuLieu("F/PEEP")]
        public string FPEEP { get; set; }
        [MoTaDuLieu("FiO2/SpO2/PaO2(%)")]
        public string FiO2 { get; set; }
        [MoTaDuLieu("Dẫn lưu (ML), DL 1")]
        public string DL_1 { get; set; }
        [MoTaDuLieu("Dẫn lưu (ML), DL 2")]
        public string DL_2 { get; set; }
        [MoTaDuLieu("Dẫn lưu (ML), DL 3")]
        public string DL_3 { get; set; }
        [MoTaDuLieu("Nước tiểu (ml)")]
        public string NuocTieu { get; set; }
        [MoTaDuLieu("Cho ăn (Loại/ml)")]
        public string ChoAn { get; set; }
        [MoTaDuLieu("Tư thế/vô rung")]
        public string TuThe { get; set; }
        [MoTaDuLieu("DỊCH TRUYỀN VÀ THUỐC")]
        public ObservableCollection<DichTruyenThuoc> DichTruyenThuocs { get; set; }
        [MoTaDuLieu("Các chăm sóc khác")]
        public string CacChamSocKhac { get; set; }
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
        public BangTDCSNBHSTCNgoaiKhoa_CT Clone()
        {
            BangTDCSNBHSTCNgoaiKhoa_CT other = (BangTDCSNBHSTCNgoaiKhoa_CT)this.MemberwiseClone();
            other.DichTruyenThuocs = new ObservableCollection<DichTruyenThuoc>();
            if (this.DichTruyenThuocs != null)
                foreach (DichTruyenThuoc item in this.DichTruyenThuocs)
                {
                    other.DichTruyenThuocs.Add(item.Clone());
                }
            return other;
        }
    }
    public class BangTDCSNBHSTCNgoaiKhoaFunc
    {
        public const string TableName = "BangTDCSNBHSTCNgoaiKhoa";
        public const string TablePrimaryKeyName = "ID";
        public static List<BangTDCSNBHSTCNgoaiKhoa> Select(MDB.MDBConnection MyConnection, decimal MaQuanLy)
        {
            try
            {
                List<BangTDCSNBHSTCNgoaiKhoa> listResult = new List<BangTDCSNBHSTCNgoaiKhoa>();
                string sql = @"SELECT t.*
                FROM BangTDCSNBHSTCNgoaiKhoa t
                WHERE t.MaQuanLy = :MaQuanLy";
                sql = sql + " ORDER BY t.NgayTao DESC";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", MaQuanLy));
                MDB.MDBDataReader DataReader = Command.ExecuteReader();
                while (DataReader.Read())
                {
                    BangTDCSNBHSTCNgoaiKhoa data = new BangTDCSNBHSTCNgoaiKhoa();
                    data.ID = Convert.ToInt64(DataReader.GetLong("ID").ToString());
                    data.MaQuanLy = MaQuanLy;
                    data.MaBenhNhan = DataReader["MaBenhNhan"].ToString();
                    data.HoTenNguoiBenh = XemBenhAn._HanhChinhBenhNhan.TenBenhNhan;
                    data.Tuoi = XemBenhAn._HanhChinhBenhNhan.Tuoi;
                    data.GioiTinh = XemBenhAn._HanhChinhBenhNhan.GioiTinh.Description();
                    data.ToSo = DataReader["ToSo"].ToString();
                    data.TenKhoa = DataReader["TenKhoa"].ToString();
                    data.MaKhoa = DataReader["MaKhoa"].ToString();
                    data.BMI = DataReader["BMI"].ToString();
                    data.CanNang = DataReader["CanNang"].ToString();
                    data.NhomMau = DataReader["NhomMau"].ToString();
                    data.NgayDieuTri = DataReader["NgayDieuTri"] != DBNull.Value ? (DateTime?) Convert.ToDateTime(DataReader["NgayDieuTri"]) : null ;
                    data.ChanDoan = DataReader["ChanDoan"].ToString();
                    data.BSDieuTri = DataReader["BSDieuTri"].ToString();
                    data.MaBSDieuTri = DataReader["MaBSDieuTri"].ToString();
                    data.DieuDuongCa1 = DataReader["DieuDuongCa1"].ToString();
                    data.MaDieuDuongCa1 = DataReader["MaDieuDuongCa1"].ToString();
                    data.DieuDuongCa2 = DataReader["DieuDuongCa2"].ToString();
                    data.MaDieuDuongCa2 = DataReader["MaDieuDuongCa2"].ToString();
                    data.Canuyn_KQ = DataReader["Canuyn_KQ"].ToString();
                    data.SondeDaDay = DataReader["SondeDaDay"].ToString();
                    data.SondeTieu = DataReader["SondeTieu"].ToString();
                    data.LoetEp = DataReader["LoetEp"].ToString();
                    data.NhungViTriTonThuongKhac = DataReader["NhungViTriTonThuongKhac"].ToString();
                    data.Phan_SoLan = DataReader["Phan_SoLan"].ToString();
                    data.Phan_SoLuong = DataReader["Phan_SoLuong"].ToString();
                    data.Phan_TinhChat = DataReader["Phan_TinhChat"].ToString();
                    data.Dom_SoLuong = DataReader["Dom_SoLuong"].ToString();
                    data.Dom_TinhChat = DataReader["Dom_TinhChat"].ToString();
                    data.DL_1 = DataReader["DL_1"].ToString();
                    data.DL_2 = DataReader["DL_2"].ToString();
                    data.DL_3 = DataReader["DL_3"].ToString();
                    data.Mau = DataReader["Mau"].ToString();
                    data.Mau_12h = DataReader["Mau_12h"].ToString();
                    data.Mau_24h = DataReader["Mau_24h"].ToString();
                    data.An_12h = DataReader["An_12h"].ToString();
                    data.An_24h = DataReader["An_24h"].ToString();
                    data.ThuocDich_12h = DataReader["ThuocDich_12h"].ToString();
                    data.ThuocDich_24h = DataReader["ThuocDich_24h"].ToString();
                    data.DanLuu_12h = DataReader["DanLuu_12h"].ToString();
                    data.DanLuu_24h = DataReader["DanLuu_24h"].ToString();
                    data.QuaDa_12h = DataReader["QuaDa_12h"].ToString();
                    data.QuaDa_24h = DataReader["QuaDa_24h"].ToString();
                    data.Tieu_12h = DataReader["Tieu_12h"].ToString();
                    data.Tieu_24h = DataReader["Tieu_24h"].ToString();
                    data.Bilan_12h = DataReader["Bilan_12h"].ToString();
                    data.Bilan_24h = DataReader["Bilan_24h"].ToString();
                    data.ChiTiets = Select_PhieuCHiTiet(MyConnection, data.ID, 1);

                    data.NgayTao = Convert.ToDateTime(DataReader["NgayTao"] == DBNull.Value ? DateTime.Now : DataReader["NgayTao"]);
                    data.NguoiTao = DataReader["NguoiTao"].ToString();
                    data.NgaySua = Convert.ToDateTime(DataReader["NgaySua"] == DBNull.Value ? DateTime.Now : DataReader["NgaySua"]);
                    data.NguoiSua = DataReader["NguoiSua"].ToString();

                    data.MaSoKy = DataReader["masokyten"].ToString();
                    data.DaKy = !string.IsNullOrEmpty(data.MaSoKy) ? true : false;

                    listResult.Add(data);
                }
                return listResult;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static bool Insert(MDB.MDBConnection MyConnection, BangTDCSNBHSTCNgoaiKhoa obj)
        {
            try
            {
                {
                    string sql = @"INSERT INTO BangTDCSNBHSTCNgoaiKhoa (
                    MaQuanLy,
                    MaBenhNhan,
                    ToSo,
                    TenKhoa,
                    MaKhoa,
                    BMI,
                    CanNang,
                    NhomMau,
                    NgayDieuTri,
                    ChanDoan,
                    BSDieuTri,
                    MaBSDieuTri,
                    DieuDuongCa1,
                    MaDieuDuongCa1,
                    DieuDuongCa2,
                    MaDieuDuongCa2,
                    Canuyn_KQ,
                    SondeDaDay,
                    SondeTieu,
                    LoetEp,
                    NhungViTriTonThuongKhac,
                    Phan_SoLan,
                    Phan_SoLuong,
                    Phan_TinhChat,
                    Dom_SoLuong,
                    Dom_TinhChat,
                    DL_1,
                    DL_2,
                    DL_3,
                    Mau,
                    Mau_12h,
                    Mau_24h,
                    An_12h,
                    An_24h,
                    ThuocDich_12h,
                    ThuocDich_24h,
                    DanLuu_12h,
                    DanLuu_24h,
                    QuaDa_12h,
                    QuaDa_24h,
                    Tieu_12h,
                    Tieu_24h,
                    Bilan_12h,
                    Bilan_24h,
                    NguoiTao,
                    NgayTao,
                    NguoiSua,
                    NgaySua
                    ) 
                    VALUES (
                    :MaQuanLy,
                    :MaBenhNhan,
                    :ToSo,
                    :TenKhoa,
                    :MaKhoa,
                    :BMI,
                    :CanNang,
                    :NhomMau,
                    :NgayDieuTri,
                    :ChanDoan,
                    :BSDieuTri,
                    :MaBSDieuTri,
                    :DieuDuongCa1,
                    :MaDieuDuongCa1,
                    :DieuDuongCa2,
                    :MaDieuDuongCa2,
                    :Canuyn_KQ,
                    :SondeDaDay,
                    :SondeTieu,
                    :LoetEp,
                    :NhungViTriTonThuongKhac,
                    :Phan_SoLan,
                    :Phan_SoLuong,
                    :Phan_TinhChat,
                    :Dom_SoLuong,
                    :Dom_TinhChat,
                    :DL_1,
                    :DL_2,
                    :DL_3,
                    :Mau,
                    :Mau_12h,
                    :Mau_24h,
                    :An_12h,
                    :An_24h,
                    :ThuocDich_12h,
                    :ThuocDich_24h,
                    :DanLuu_12h,
                    :DanLuu_24h,
                    :QuaDa_12h,
                    :QuaDa_24h,
                    :Tieu_12h,
                    :Tieu_24h,
                    :Bilan_12h,
                    :Bilan_24h,
                    :NguoiTao,
                    :NgayTao,
                    :NguoiSua,
                    :NgaySua
                    ) RETURNING ID INTO :ID ";
                    MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
                    Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", obj.MaQuanLy));
                    Command.Parameters.Add(new MDB.MDBParameter("MaBenhNhan", obj.MaBenhNhan));
                    Command.Parameters.Add(new MDB.MDBParameter("ToSo", obj.ToSo));
                    Command.Parameters.Add(new MDB.MDBParameter("TenKhoa", obj.TenKhoa));
                    Command.Parameters.Add(new MDB.MDBParameter("MaKhoa", obj.MaKhoa));
                    Command.Parameters.Add(new MDB.MDBParameter("BMI", obj.BMI));
                    Command.Parameters.Add(new MDB.MDBParameter("CanNang", obj.CanNang));
                    Command.Parameters.Add(new MDB.MDBParameter("NhomMau", obj.NhomMau));
                    Command.Parameters.Add(new MDB.MDBParameter("NgayDieuTri", obj.NgayDieuTri));
                    Command.Parameters.Add(new MDB.MDBParameter("ChanDoan", obj.ChanDoan));
                    Command.Parameters.Add(new MDB.MDBParameter("BSDieuTri", obj.BSDieuTri));
                    Command.Parameters.Add(new MDB.MDBParameter("MaBSDieuTri", obj.MaBSDieuTri));
                    Command.Parameters.Add(new MDB.MDBParameter("DieuDuongCa1", obj.DieuDuongCa1));
                    Command.Parameters.Add(new MDB.MDBParameter("MaDieuDuongCa1", obj.MaDieuDuongCa1));
                    Command.Parameters.Add(new MDB.MDBParameter("DieuDuongCa2", obj.DieuDuongCa2));
                    Command.Parameters.Add(new MDB.MDBParameter("MaDieuDuongCa2", obj.MaDieuDuongCa2));
                    Command.Parameters.Add(new MDB.MDBParameter("Canuyn_KQ", obj.Canuyn_KQ));
                    Command.Parameters.Add(new MDB.MDBParameter("SondeDaDay", obj.SondeDaDay));
                    Command.Parameters.Add(new MDB.MDBParameter("SondeTieu", obj.SondeTieu));
                    Command.Parameters.Add(new MDB.MDBParameter("LoetEp", obj.LoetEp));
                    Command.Parameters.Add(new MDB.MDBParameter("NhungViTriTonThuongKhac", obj.NhungViTriTonThuongKhac));
                    Command.Parameters.Add(new MDB.MDBParameter("Phan_SoLan", obj.Phan_SoLan));
                    Command.Parameters.Add(new MDB.MDBParameter("Phan_SoLuong", obj.Phan_SoLuong));
                    Command.Parameters.Add(new MDB.MDBParameter("Phan_TinhChat", obj.Phan_TinhChat));
                    Command.Parameters.Add(new MDB.MDBParameter("Dom_SoLuong", obj.Dom_SoLuong));
                    Command.Parameters.Add(new MDB.MDBParameter("Dom_TinhChat", obj.Dom_TinhChat));
                    Command.Parameters.Add(new MDB.MDBParameter("DL_1", obj.DL_1));
                    Command.Parameters.Add(new MDB.MDBParameter("DL_2", obj.DL_2));
                    Command.Parameters.Add(new MDB.MDBParameter("DL_3", obj.DL_3));
                    Command.Parameters.Add(new MDB.MDBParameter("Mau", obj.Mau));
                    Command.Parameters.Add(new MDB.MDBParameter("Mau_12h", obj.Mau_12h));
                    Command.Parameters.Add(new MDB.MDBParameter("Mau_24h", obj.Mau_24h));
                    Command.Parameters.Add(new MDB.MDBParameter("An_12h", obj.An_12h));
                    Command.Parameters.Add(new MDB.MDBParameter("An_24h", obj.An_24h));
                    Command.Parameters.Add(new MDB.MDBParameter("ThuocDich_12h", obj.ThuocDich_12h));
                    Command.Parameters.Add(new MDB.MDBParameter("ThuocDich_24h", obj.ThuocDich_24h));
                    Command.Parameters.Add(new MDB.MDBParameter("DanLuu_12h", obj.DanLuu_12h));
                    Command.Parameters.Add(new MDB.MDBParameter("DanLuu_24h", obj.DanLuu_24h));
                    Command.Parameters.Add(new MDB.MDBParameter("QuaDa_12h", obj.QuaDa_12h));
                    Command.Parameters.Add(new MDB.MDBParameter("QuaDa_24h", obj.QuaDa_24h));
                    Command.Parameters.Add(new MDB.MDBParameter("Tieu_12h", obj.Tieu_12h));
                    Command.Parameters.Add(new MDB.MDBParameter("Tieu_24h", obj.Tieu_24h));
                    Command.Parameters.Add(new MDB.MDBParameter("Bilan_12h", obj.Bilan_12h));
                    Command.Parameters.Add(new MDB.MDBParameter("Bilan_24h", obj.Bilan_24h));

                    Command.Parameters.Add(new MDB.MDBParameter("NguoiTao", Common.getUserLogin()));
                    Command.Parameters.Add(new MDB.MDBParameter("NgayTao", DateTime.Now));
                    Command.Parameters.Add(new MDB.MDBParameter("NguoiSua", Common.getUserLogin()));
                    Command.Parameters.Add(new MDB.MDBParameter("NgaySua", DateTime.Now));
                    Command.Parameters.Add(new MDB.MDBParameter("ID", obj.ID));
                    int n = Command.ExecuteNonQuery();
                    if (n > 0)
                    {
                        decimal ID = Common.ConDB_Decimal((Command.Parameters["ID"] as MDB.MDBParameter).Value);
                        obj.ID = ID;
                    }

                    return n > 0 ? true : false;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static bool Update(MDB.MDBConnection MyConnection, BangTDCSNBHSTCNgoaiKhoa obj)
        {
            try
            {
                {

                    string sql = @"UPDATE BangTDCSNBHSTCNgoaiKhoa SET 
                        MaQuanLy=:MaQuanLy,
                        MaBenhNhan=:MaBenhNhan,
                        ToSo=:ToSo,
                        TenKhoa=:TenKhoa,
                        MaKhoa=:MaKhoa,
                        BMI=:BMI,
                        CanNang=:CanNang,
                        NhomMau=:NhomMau,
                        NgayDieuTri=:NgayDieuTri,
                        ChanDoan=:ChanDoan,
                        BSDieuTri=:BSDieuTri,
                        MaBSDieuTri=:MaBSDieuTri,
                        DieuDuongCa1=:DieuDuongCa1,
                        MaDieuDuongCa1=:MaDieuDuongCa1,
                        DieuDuongCa2=:DieuDuongCa2,
                        MaDieuDuongCa2=:MaDieuDuongCa2,
                        Canuyn_KQ=:Canuyn_KQ,
                        SondeDaDay=:SondeDaDay,
                        SondeTieu=:SondeTieu,
                        LoetEp=:LoetEp,
                        NhungViTriTonThuongKhac=:NhungViTriTonThuongKhac,
                        Phan_SoLan=:Phan_SoLan,
                        Phan_SoLuong=:Phan_SoLuong,
                        Phan_TinhChat=:Phan_TinhChat,
                        Dom_SoLuong=:Dom_SoLuong,
                        Dom_TinhChat=:Dom_TinhChat,
                        DL_1=:DL_1,
                        DL_2=:DL_2,
                        DL_3=:DL_3,
                        Mau=:Mau,
                        Mau_12h=:Mau_12h,
                        Mau_24h=:Mau_24h,
                        An_12h=:An_12h,
                        An_24h=:An_24h,
                        ThuocDich_12h=:ThuocDich_12h,
                        ThuocDich_24h=:ThuocDich_24h,
                        DanLuu_12h=:DanLuu_12h,
                        DanLuu_24h=:DanLuu_24h,
                        QuaDa_12h=:QuaDa_12h,
                        QuaDa_24h=:QuaDa_24h,
                        Tieu_12h=:Tieu_12h,
                        Tieu_24h=:Tieu_24h,
                        Bilan_12h=:Bilan_12h,
                        Bilan_24h=:Bilan_24h,
                        NguoiSua = :NguoiSua,
                        NgaySua=:NgaySua
                        WHERE ID = " + obj.ID;
                    MDB.MDBCommand oracleCommand = new MDB.MDBCommand(sql, MyConnection);
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("MaQuanLy", obj.MaQuanLy));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("MaBenhNhan", obj.MaBenhNhan));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("ToSo", obj.ToSo));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("TenKhoa", obj.TenKhoa));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("MaKhoa", obj.MaKhoa));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("BMI", obj.BMI));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("CanNang", obj.CanNang));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("NhomMau", obj.NhomMau));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("NgayDieuTri", obj.NgayDieuTri));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("ChanDoan", obj.ChanDoan));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("BSDieuTri", obj.BSDieuTri));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("MaBSDieuTri", obj.MaBSDieuTri));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("DieuDuongCa1", obj.DieuDuongCa1));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("MaDieuDuongCa1", obj.MaDieuDuongCa1));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("DieuDuongCa2", obj.DieuDuongCa2));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("MaDieuDuongCa2", obj.MaDieuDuongCa2));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("Canuyn_KQ", obj.Canuyn_KQ));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("SondeDaDay", obj.SondeDaDay));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("SondeTieu", obj.SondeTieu));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("LoetEp", obj.LoetEp));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("NhungViTriTonThuongKhac", obj.NhungViTriTonThuongKhac));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("Phan_SoLan", obj.Phan_SoLan));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("Phan_SoLuong", obj.Phan_SoLuong));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("Phan_TinhChat", obj.Phan_TinhChat));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("Dom_SoLuong", obj.Dom_SoLuong));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("Dom_TinhChat", obj.Dom_TinhChat));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("DL_1", obj.DL_1));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("DL_2", obj.DL_2));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("DL_3", obj.DL_3));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("Mau", obj.Mau));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("Mau_12h", obj.Mau_12h));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("Mau_24h", obj.Mau_24h));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("An_12h", obj.An_12h));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("An_24h", obj.An_24h));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("ThuocDich_12h", obj.ThuocDich_12h));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("ThuocDich_24h", obj.ThuocDich_24h));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("DanLuu_12h", obj.DanLuu_12h));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("DanLuu_24h", obj.DanLuu_24h));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("QuaDa_12h", obj.QuaDa_12h));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("QuaDa_24h", obj.QuaDa_24h));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("Tieu_12h", obj.Tieu_12h));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("Tieu_24h", obj.Tieu_24h));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("Bilan_12h", obj.Bilan_12h));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("Bilan_24h", obj.Bilan_24h));

                    oracleCommand.Parameters.Add(new MDB.MDBParameter("NguoiSua", Common.getUserLogin()));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("NgaySua", DateTime.Now));
                    int n = oracleCommand.ExecuteNonQuery();

                    return n > 0 ? true : false;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static bool Delete(MDB.MDBConnection MyConnection, decimal IDPhieu)
        {
            try
            {
                if (IDPhieu != 0)
                {
                    string sql = @"Delete BangTDCSNBHSTCNgoaiKhoa 
                                WHERE 
                                (ID = :ID) ";
                    MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
                    Command.Parameters.Add(new MDB.MDBParameter(":ID", IDPhieu));
                    int n = Command.ExecuteNonQuery();
                    Command.Dispose();
                    sql = @"Delete BangTDCSNBHSTCNgoaiKhoa_CT 
                                WHERE 
                                (IDPhieu = :IDPhieu) ";
                    Command = new MDB.MDBCommand(sql, MyConnection);
                    Command.Parameters.Add(new MDB.MDBParameter(":IDPhieu", IDPhieu));
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
        public static bool Delete_ChiTiet(MDB.MDBConnection MyConnection, decimal ID)
        {
            try
            {
                if (ID != 0)
                {
                    string sql = @"Delete BangTDCSNBHSTCNgoaiKhoa_CT 
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
        public static ObservableCollection<BangTDCSNBHSTCNgoaiKhoa_CT> Select_PhieuCHiTiet(MDB.MDBConnection MyConnection, decimal IDPhieu, int ModOrder = 0)
        {
            try
            {
                ObservableCollection<BangTDCSNBHSTCNgoaiKhoa_CT> listResult = new ObservableCollection<BangTDCSNBHSTCNgoaiKhoa_CT>();
                string sql = @"SELECT t.*
                FROM BangTDCSNBHSTCNgoaiKhoa_CT t
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
                    var obj = new BangTDCSNBHSTCNgoaiKhoa_CT();
                    obj.ID = DataReader.GetDecimal("ID");
                    obj.IDPhieu = DataReader.GetDecimal("IDPhieu");

                    obj.ThoiGian = Convert.ToDateTime(DataReader["ThoiGian"] == DBNull.Value ? DateTime.Now : DataReader["ThoiGian"]);
                    obj.Mach = Common.ConDB_double(DataReader["Mach"]);
                    obj.NhietDo = Common.ConDB_double(DataReader["NhietDo"]);
                    obj.HuyetAp_Min = DataReader["HuyetAp_Min"].ToString();
                    obj.HuyetAp_Max = DataReader["HuyetAp_Max"].ToString();
                    obj.Glassgow = DataReader["Glassgow"].ToString();
                    obj.TinhTrangLiet = DataReader["TinhTrangLiet"].ToString();
                    obj.DanhGiaKhac = DataReader["DanhGiaKhac"].ToString();
                    obj.LieuPhapOxy = DataReader["LieuPhapOxy"].ToString();
                    obj.VtPCPS = DataReader["VtPCPS"].ToString();
                    obj.FPEEP = DataReader["FPEEP"].ToString();
                    obj.FiO2 = DataReader["FiO2"].ToString();
                    obj.DL_1 = DataReader["DL_1"].ToString();
                    obj.DL_2 = DataReader["DL_2"].ToString();
                    obj.DL_3 = DataReader["DL_3"].ToString();
                    obj.NuocTieu = DataReader["NuocTieu"].ToString();
                    obj.ChoAn = DataReader["ChoAn"].ToString();
                    obj.TuThe = DataReader["TuThe"].ToString();
                    obj.DichTruyenThuocs = JsonConvert.DeserializeObject<ObservableCollection<DichTruyenThuoc>>(DataReader["DichTruyenThuocs"].ToString());
                    if (obj.DichTruyenThuocs == null)
                    {
                        obj.DichTruyenThuocs = new ObservableCollection<DichTruyenThuoc>();
                    }

                    obj.CacChamSocKhac = DataReader["CacChamSocKhac"].ToString();


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
        public static bool InsertOrUpdate_ChiTiet(MDB.MDBConnection MyConnection, ref BangTDCSNBHSTCNgoaiKhoa_CT ketQua)
        {
            try
            {
                string sql = @"INSERT INTO BangTDCSNBHSTCNgoaiKhoa_CT
                (
                    IDPhieu,
                    ThoiGian,
                    Mach,
                    NhietDo,
                    HuyetAp_Min,
                    HuyetAp_Max,
                    Glassgow,
                    TinhTrangLiet,
                    DanhGiaKhac,
                    LieuPhapOxy,
                    VtPCPS,
                    FPEEP,
                    FiO2,
                    DL_1,
                    DL_2,
                    DL_3,
                    NuocTieu,
                    ChoAn,
                    TuThe,
                    DichTruyenThuocs,
                    CacChamSocKhac,
                    NGUOITAO,
                    NGUOISUA,
                    NGAYTAO,
                    NGAYSUA)  VALUES
                 (
				    :IDPhieu,
                    :ThoiGian,
                    :Mach,
                    :NhietDo,
                    :HuyetAp_Min,
                    :HuyetAp_Max,
                    :Glassgow,
                    :TinhTrangLiet,
                    :DanhGiaKhac,
                    :LieuPhapOxy,
                    :VtPCPS,
                    :FPEEP,
                    :FiO2,
                    :DL_1,
                    :DL_2,
                    :DL_3,
                    :NuocTieu,
                    :ChoAn,
                    :TuThe,
                    :DichTruyenThuocs,
                    :CacChamSocKhac,
                    :NGUOITAO,
                    :NGUOISUA,
                    :NGAYTAO,
                    :NGAYSUA
                 )  RETURNING ID INTO :ID";
                if (ketQua.ID != 0)
                {
                    sql = @"UPDATE BangTDCSNBHSTCNgoaiKhoa_CT SET 
                    IDPhieu=:IDPhieu,
                    ThoiGian=:ThoiGian,
                    Mach=:Mach,
                    NhietDo=:NhietDo,
                    HuyetAp_Min=:HuyetAp_Min,
                    HuyetAp_Max=:HuyetAp_Max,
                    Glassgow=:Glassgow,
                    TinhTrangLiet=:TinhTrangLiet,
                    DanhGiaKhac=:DanhGiaKhac,
                    LieuPhapOxy=:LieuPhapOxy,
                    VtPCPS=:VtPCPS,
                    FPEEP=:FPEEP,
                    FiO2=:FiO2,
                    DL_1=:DL_1,
                    DL_2=:DL_2,
                    DL_3=:DL_3,
                    NuocTieu=:NuocTieu,
                    ChoAn=:ChoAn,
                    TuThe=:TuThe,
                    DichTruyenThuocs=:DichTruyenThuocs,
                    CacChamSocKhac=:CacChamSocKhac,
                    NGUOISUA = :NGUOISUA,
                    NGAYSUA = :NGAYSUA
                    WHERE ID = " + ketQua.ID;
                }
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
                Command.Parameters.Add(new MDB.MDBParameter("IDPhieu", ketQua.IDPhieu));
                Command.Parameters.Add(new MDB.MDBParameter("ThoiGian", ketQua.ThoiGian));
                Command.Parameters.Add(new MDB.MDBParameter("Mach", ketQua.Mach));
                Command.Parameters.Add(new MDB.MDBParameter("NhietDo", ketQua.NhietDo));
                Command.Parameters.Add(new MDB.MDBParameter("HuyetAp_Min", ketQua.HuyetAp_Min));
                Command.Parameters.Add(new MDB.MDBParameter("HuyetAp_Max", ketQua.HuyetAp_Max));
                Command.Parameters.Add(new MDB.MDBParameter("Glassgow", ketQua.Glassgow));
                Command.Parameters.Add(new MDB.MDBParameter("TinhTrangLiet", ketQua.TinhTrangLiet));
                Command.Parameters.Add(new MDB.MDBParameter("DanhGiaKhac", ketQua.DanhGiaKhac));
                Command.Parameters.Add(new MDB.MDBParameter("LieuPhapOxy", ketQua.LieuPhapOxy));
                Command.Parameters.Add(new MDB.MDBParameter("VtPCPS", ketQua.VtPCPS));
                Command.Parameters.Add(new MDB.MDBParameter("FPEEP", ketQua.FPEEP));
                Command.Parameters.Add(new MDB.MDBParameter("FiO2", ketQua.FiO2));
                Command.Parameters.Add(new MDB.MDBParameter("DL_1", ketQua.DL_1));
                Command.Parameters.Add(new MDB.MDBParameter("DL_2", ketQua.DL_2));
                Command.Parameters.Add(new MDB.MDBParameter("DL_3", ketQua.DL_3));
                Command.Parameters.Add(new MDB.MDBParameter("NuocTieu", ketQua.NuocTieu));
                Command.Parameters.Add(new MDB.MDBParameter("ChoAn", ketQua.ChoAn));
                Command.Parameters.Add(new MDB.MDBParameter("TuThe", ketQua.TuThe));

                Command.Parameters.Add(new MDB.MDBParameter("DichTruyenThuocs", JsonConvert.SerializeObject(ketQua.DichTruyenThuocs)));
                Command.Parameters.Add(new MDB.MDBParameter("CacChamSocKhac", ketQua.CacChamSocKhac));

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
        public static DataSet GetDataSet(MDB.MDBConnection MyConnection, decimal ID)
        {
            var timer = new Stopwatch();
            StringBuilder sql = new StringBuilder();
            timer.Start();
            try
            {
                sql.AppendLine(@"SELECT P.*, T.SoNhapVien, T.MaBenhAn, H.TenBenhNhan, H.Tuoi, H.SoYTe, H.BenhVien, H.GioiTinh 
                    FROM BangTDCSNBHSTCNgoaiKhoa P
                    LEFT JOIN THONGTINDIEUTRI T ON P.MAQUANLY = T.MAQUANLY
                    LEFT JOIN HANHCHINHBENHNHAN H ON T.MABENHNHAN = H.MABENHNHAN
                ");
                sql.AppendLine(" WHERE P.ID = :ID ");
                MDB.MDBCommand Command = new MDB.MDBCommand(sql.ToString(), MyConnection);
                Command.Parameters.Add(new MDB.MDBParameter("ID", ID));
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
    }

}
