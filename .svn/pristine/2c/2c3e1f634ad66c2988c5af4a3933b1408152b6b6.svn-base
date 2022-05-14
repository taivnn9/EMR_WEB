using EMR.KyDienTu;
using NLog;
using PMS.Access;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Text;

namespace EMR_MAIN.DATABASE.Other
{
    public class PhieuTheoDoiVaChamSocPhuKhoa : ThongTinKy
    {
        public PhieuTheoDoiVaChamSocPhuKhoa()
        {
            TableName = "PhieuTDVCSBNPhuKhoa";
            TablePrimaryKeyName = "ID";
            IDMauPhieu = (int)DanhMucPhieu.PTDVCSPK;
            TenMauPhieu = DanhMucPhieu.PTDVCSPK.Description();
        }
        [MoTaDuLieu("Mã định danh")]
        public decimal IDPhieu { set; get; }
        [MoTaDuLieu("Mã quản lý: mã duy nhất trong 1 đợt khám chữa bệnh (kcb), không trùng giữa các đợt kcb khác nhau", "", 1)]
        public decimal MaQuanLy { set; get; }
        [MoTaDuLieu("Tên khoa")]
        public string TenKhoa { set; get; }
        [MoTaDuLieu("Mã khoa")]
        public string MaKhoa { set; get; }
        [MoTaDuLieu("Mã bệnh nhân")]
        public string MaBenhNhan { set; get; }
        public string SoPhieu { set; get; }
        [MoTaDuLieu("Chẩn đoán bệnh")]
        public string ChanDoan { set; get; }
        [MoTaDuLieu("Buồng")]
        public string Buong { set; get; }
        [MoTaDuLieu("Giường")]
        public string Giuong { set; get; }
        [MoTaDuLieu("Mã giường")]
        public string MaGiuong { set; get; }
        public DateTime? NgayVaoVien { set; get; }
        [MoTaDuLieu("Tên điều dưỡng chăm sóc")]
        public string TenDDCS { set; get; }
        [MoTaDuLieu("Mã điều dưỡng chăm sóc")]
        public string MaDDCS { set; get; }
        [MoTaDuLieu("Sở y tế")]
        public string SoYTe
        {
            get
            {
                return XemBenhAn._HanhChinhBenhNhan.SoYTe;
            }
        }
        public string BenhVien
        {
            get
            {
                return XemBenhAn._HanhChinhBenhNhan.BenhVien;
            }
        }
        [MoTaDuLieu("Tuổi bệnh nhân")]
        public string Tuoi
        {
            get
            {
                return XemBenhAn._HanhChinhBenhNhan.Tuoi;
            }
        }
        [MoTaDuLieu("Giới tính bệnh nhân")]
        public string GioiTinh
        {
            get
            {
                return XemBenhAn._HanhChinhBenhNhan.GioiTinh.Description();
            }
        }
        public string SoVaoVien
        {
            get
            {
                return XemBenhAn._ThongTinDieuTri.SoNhapVien;
            }
        }
        [MoTaDuLieu("Họ và tên bệnh nhân")]
        public string TenBenhNhan
        {
            get
            {
                return XemBenhAn._HanhChinhBenhNhan.TenBenhNhan;
            }
        }
        public string MaBenhAn
        {
            get
            {
                return XemBenhAn._ThongTinDieuTri.MaBenhAn;
            }
        }
        // phần riêng biệt của các phiếu
        [MoTaDuLieu("Thời gian")]
        public DateTime? TGTiepNhan { set; get; }
        [MoTaDuLieu("Phân cấp chăm sóc")]
        public string PCCS { set; get; }
        [MoTaDuLieu("Tiền sử dị ứng, 1-> không, 2-> có")]
        public int TSDU { get; set; }
        [MoTaDuLieu("Tiền sử dị ứng, thuốc")]
        public int TSDU_Thuoc { get; set; }
        [MoTaDuLieu("Tiền sử dị ứng, thực phẩm")]
        public int TSDU_ThucPham { get; set; }
        [MoTaDuLieu("Tiền sử dị ứng, khác")]
        public int TSDU_Khac { get; set; }
        [MoTaDuLieu("Tiền sử dị ứng, khac, cụ thể")]
        public string TSDU_Text { get; set; }
        [MoTaDuLieu("Tiền sử dị bệnh")]
        public string TSB { get; set; }
        [MoTaDuLieu("ý thức, hôn mê")]
        public int YThuc_HonMe { get; set; }
        [MoTaDuLieu("ý thức, tỉnh")]
        public int YThuc_Tinh { get; set; }
        [MoTaDuLieu("ý thức, tỉnh tiếp xúc")]
        public string YThuc_TinhTiepXuc { get; set; }
        [MoTaDuLieu("ý thức, khác")]
        public string YThuc_Khac { get; set; }
        [MoTaDuLieu("Thể trạng, H")]
        public string TheTrang_H { get; set; }
        [MoTaDuLieu("Thể trạng, P")]
        public string TheTrang_P { get; set; }
        [MoTaDuLieu("Thể trạng, BMI")]
        public string TheTrang_BMI { get; set; }
        [MoTaDuLieu("Phù, 1-> không, 1-> có")]
        public int Phu { get; set; }
        [MoTaDuLieu("Phù,vị trí")]
        public string Phu_ViTri { get; set; }
        [MoTaDuLieu("Da, niêm mạc")]
        public string DaNiemMac { get; set; }
        [MoTaDuLieu("Hô hấp, 1-> tự thở, 2-> khác")]
        public int HoHap { get; set; }
        [MoTaDuLieu("Hô hấp, khác")]
        public string HoHap_Khac { get; set; }
        [MoTaDuLieu("Vết thương, 1-> không, 2-> có")]
        public int VetThuong { get; set; }
        [MoTaDuLieu("Vết thương, khô")]
        public int VetThuong_Kho { get; set; }
        [MoTaDuLieu("Vết thương, dịch thấm băng")]
        public int VetThuong_DichThamBang { get; set; }
        [MoTaDuLieu("Vết thương, Nhiễm trùng")]
        public int VetThuong_NhiemTrung { get; set; }
        [MoTaDuLieu("Đau, 1-> không, 2-> có")]
        public int Dau { get; set; }
        [MoTaDuLieu("Đau, vị trí")]
        public string Dau_ViTri { get; set; }
        [MoTaDuLieu("Đau, mức độ, 1-> it, 2-> vừa, 3-> nhiều")]
        public int Dau_MucDo { get; set; }
        [MoTaDuLieu("Đau, tính chất, 1-> từng cơn, 2-> liên tục")]
        public int Dau_TinhChat { get; set; }
        [MoTaDuLieu("Ra máu AĐ, 1-> không, 2-> có")]
        public int RaMauAD { get; set; }
        [MoTaDuLieu("Ra máu AĐ, màu sắc")]
        public string RaMauAD_MauSac { get; set; }
        [MoTaDuLieu("Ra máu AĐ, số lượng")]
        public string RaMauAD_SoLuong { get; set; }
        [MoTaDuLieu("Tiêu hóa, dinh dưỡng")]
        public string TieuHoa { get; set; }
        [MoTaDuLieu("Đại tiện")]
        public string DaiTien { get; set; }
        [MoTaDuLieu("Tiểu tiện")]
        public string TieuTien { get; set; }
        [MoTaDuLieu("Dẫn lưu")]
        public string DanLuu { get; set; }
        [MoTaDuLieu("Vấn đề bất thường khác")]
        public string VanDeBatThuongKhac { get; set; }
        [MoTaDuLieu("ngày thực hiện thuốc")]
        public DateTime? GioThucHienThuoc { get; set; }
        [MoTaDuLieu("Giờ thực hiện thuốc")]
        public DateTime? GioThucHienThuoc_Gio { get; set; }
        [MoTaDuLieu("Xét nghiệm, HH")]
        public int XN_HH { get; set; }
        [MoTaDuLieu("Xét nghiệm, HS")]
        public int XN_HS { get; set; }
        [MoTaDuLieu("Xét nghiệm, VS")]
        public int XN_VS { get; set; }
        [MoTaDuLieu("Xét nghiệm, khác")]
        public string XN_Khac { get; set; }
        [MoTaDuLieu("CĐHA")]
        public int CDHA { get; set; }
        [MoTaDuLieu("TDCN")]
        public int TDCN { get; set; }
        [MoTaDuLieu("CS: thay băng")]
        public int ThayBang { get; set; }
        [MoTaDuLieu("CS: chăm sóc dẫn lưu")]
        public int ChamSocDanLuu { get; set; }
        [MoTaDuLieu("KT-TT: đặt sonde dạ dày")]
        public int KTTT_DatSondeDaDay { get; set; }
        [MoTaDuLieu("KT-TT: đặt sonde tiểu")]
        public int KTTT_DatSondeTieu { get; set; }
        [MoTaDuLieu("KT-TT: khác")]
        public string KTTT_Khac { get; set; }
        [MoTaDuLieu("Chế độ ăn")]
        public string CheDoAn { get; set; }
        [MoTaDuLieu("Khác, nuôi dưỡng tĩnh mạch")]
        public int Khac_NuoiDuongTinhMach { get; set; }
        [MoTaDuLieu("Khác, thông báo nội quy")]
        public int Khac_ThongBaoNoiQuy { get; set; }
        [MoTaDuLieu("Khác, tư vấn, giáo dục sức khỏe")]
        public int Khac_TVGDSK { get; set; }
        [MoTaDuLieu("Chăm sóc khác")]
        public string ChamSocKhac { get; set; }
        public List<PhieuTheoDoiVaChamSocPhuKhoa_CT> TTCSChiTiet { get; set; }

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
        public PhieuTheoDoiVaChamSocPhuKhoa Clone()
        {
            PhieuTheoDoiVaChamSocPhuKhoa other = (PhieuTheoDoiVaChamSocPhuKhoa)this.MemberwiseClone();
            other.TTCSChiTiet = new List<PhieuTheoDoiVaChamSocPhuKhoa_CT>();
            if (this.TTCSChiTiet != null)
                foreach (PhieuTheoDoiVaChamSocPhuKhoa_CT item in this.TTCSChiTiet)
                {
                    other.TTCSChiTiet.Add(item.Clone());
                }
            return other;
        }
    }
    public class PhieuTheoDoiVaChamSocPhuKhoa_CT : ThongTinKy
    {
        [MoTaDuLieu("Mã định danh")]
        public decimal IDPhieuCT { set; get; }
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
        [MoTaDuLieu("Nhịp tim")]
        public string NT { set; get; }
        public DateTime? ThoiGianTHCS { set; get; }
        [MoTaDuLieu("Người thực hiện")]
        public string NguoiThucHien { set; get; }
        [MoTaDuLieu("Mã người thực hiện")]
        public string MaNguoiThucHien { set; get; }
        public string PCCS { set; get; }
        [MoTaDuLieu("Chẩn đoán sau mổ")]
        public string ChanDoanSauMo { set; get; }
        [MoTaDuLieu("Ngày thứ")]
        public string NgayThu { set; get; }
        // phần riêng
        [MoTaDuLieu("Vết thương, khô")]
        public int VetThuong_Kho { get; set; }
        [MoTaDuLieu("Vết thương, dịch thấm băng")]
        public int VetThuong_DichThamBang { get; set; }
        [MoTaDuLieu("Vết thương, nhiễm trùng")]
        public int VetThuong_NhiemTrung { get; set; }
        [MoTaDuLieu("Đau, 1-> không, 2-> có")]
        public int Dau { get; set; }
        [MoTaDuLieu("Đau, vị trí")]
        public string Dau_ViTri { set; get; }
        [MoTaDuLieu("Đau, mức độ, 1-> ít, 2-> vừa, 3 -> nhiều")]
        public int Dau_MucDo { get; set; }
        [MoTaDuLieu("Đau, tính chất, 1-> từng cơn, 2-> liên tục")]
        public int Dau_TinhChat { get; set; }
        [MoTaDuLieu("Ra máu âm đạo, 1- > không, 2-> có")]
        public int RaMauAD { get; set; }
        [MoTaDuLieu("Ra máu âm đạo, màu sắc")]
        public string RaMauAD_MauSac { get; set; }
        [MoTaDuLieu("Ra máu âm đạo, số lượng")]
        public string RaMauAD_SoLuong { get; set; }
        [MoTaDuLieu("Dẫn lưu, số lượng, màu sắc")]
        public string DanLuu { set; get; }
        [MoTaDuLieu("Vấn đề khác")]
        public string VanDeKhac { set; get; }
        [MoTaDuLieu("Ngày thực hiện thuốc")]
        public DateTime? GioThucHienThuoc { set; get; }
        [MoTaDuLieu("Giờ thực hiện thuốc")]
        public DateTime? GioThucHienThuoc_Gio { set; get; }
        [MoTaDuLieu("XN mới")]
        public string XNMoi { set; get; }
        [MoTaDuLieu("CĐHA mới")]
        public string CDHAMoi { set; get; }
        [MoTaDuLieu("CS: thay băng")]
        public int CS_ThayBang { get; set; }
        [MoTaDuLieu("CS: Chăm sóc dẫn lưu")]
        public int CS_DanLuu { get; set; }
        [MoTaDuLieu("KTTT")]
        public string KTTT { get; set; }
        [MoTaDuLieu("Chế độ ăn")]
        public string CheDoAn { set; get; }
        [MoTaDuLieu("Nuôi dưỡng tĩnh mạch")]
        public int Khac_NuoiDuongTinhMach { get; set; }
        [MoTaDuLieu("Tư vấn giáo dục sức khỏe")]
        public int Khac_TuVanGDSK { get; set; }
        [MoTaDuLieu("Chắm sóc khác")]
        public string ChamSocKhac { set; get; }
        public string MaDDCS { set; get; }
        public string TenDDCS { set; get; }
        public string NGAYKY { set; get; }
        public string COMPUTERKYTEN { set; get; }
        //public string MASOKYTEN { set; get; }
        public string TENFILEKY { set; get; }
        public string USERNAMEKY { set; get; }
        public bool Daky { set; get; }
        [MoTaDuLieu("Chọn", null, 0, 0)]
        public bool Chon { get; set; }
        public PhieuTheoDoiVaChamSocPhuKhoa_CT Clone()
        {
            PhieuTheoDoiVaChamSocPhuKhoa_CT other = (PhieuTheoDoiVaChamSocPhuKhoa_CT)this.MemberwiseClone();
            return other;
        }
    }
    public class PhieuTheoDoiVaChamSocPhuKhoaFunc
    {
        static Logger log = LogManager.GetLogger("Log");
        public const string TableName = "PhieuTDVCSBNPhuKhoa";
        public const string TablePrimaryKeyName = "IDPhieu";
        public List<PhieuTheoDoiVaChamSocPhuKhoa> Select(MDB.MDBConnection MyConnection, string MaQuanLy)
        {
            List<PhieuTheoDoiVaChamSocPhuKhoa> listResult = new List<PhieuTheoDoiVaChamSocPhuKhoa>();
            try
            {
                string sql = @"SELECT t.*
                FROM PhieuTDVCSBNPhuKhoa t
                WHERE t.MaQuanLy = :MaQuanLy";
                sql = sql + " ORDER BY t.NgayTao DESC";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", MaQuanLy));
                MDB.MDBDataReader DataReader = Command.ExecuteReader();
                while (DataReader.Read())
                {
                    var obj = new PhieuTheoDoiVaChamSocPhuKhoa();
                    obj.IDPhieu = Common.ConDB_Decimal(DataReader["IDPhieu"]);
                    obj.MaQuanLy = Common.ConDB_Decimal(DataReader["MaQuanLy"]);
                    obj.TenKhoa = Common.ConDBNull(DataReader["TenKhoa"]);
                    obj.MaKhoa = Common.ConDBNull(DataReader["MaKhoa"]);
                    obj.MaBenhNhan = Common.ConDBNull(DataReader["MaBenhNhan"]);
                    obj.SoPhieu = Common.ConDBNull(DataReader["SoPhieu"]);
                    obj.ChanDoan = Common.ConDBNull(DataReader["ChanDoan"]);
                    obj.Buong = Common.ConDBNull(DataReader["Buong"]);
                    obj.Giuong = Common.ConDBNull(DataReader["Giuong"]);
                    obj.MaGiuong = Common.ConDBNull(DataReader["MaGiuong"]);
                    obj.NgayVaoVien = Common.ConDB_DateTimeNull(DataReader["NgayVaoVien"]);
                    obj.TenDDCS = Common.ConDBNull(DataReader["TenDDCS"]);
                    obj.MaDDCS = Common.ConDBNull(DataReader["MaDDCS"]);

                    obj.TGTiepNhan = DataReader["TGTiepNhan"] != DBNull.Value ? (DateTime?)Convert.ToDateTime(DataReader["TGTiepNhan"].ToString()) : null;
                    obj.PCCS = DataReader["PCCS"].ToString();
                    obj.TSDU = DataReader.GetInt("TSDU");
                    obj.TSDU_Thuoc = DataReader.GetInt("TSDU_Thuoc");
                    obj.TSDU_ThucPham = DataReader.GetInt("TSDU_ThucPham");
                    obj.TSDU_Khac = DataReader.GetInt("TSDU_Khac");
                    obj.TSDU_Text = DataReader["TSDU_Text"].ToString();
                    obj.TSB = DataReader["TSB"].ToString();
                    obj.YThuc_HonMe = DataReader.GetInt("YThuc_HonMe");
                    obj.YThuc_Tinh = DataReader.GetInt("YThuc_Tinh");
                    obj.YThuc_TinhTiepXuc = DataReader["YThuc_TinhTiepXuc"].ToString();
                    obj.YThuc_Khac = DataReader["YThuc_Khac"].ToString();
                    obj.TheTrang_H = DataReader["TheTrang_H"].ToString();
                    obj.TheTrang_P = DataReader["TheTrang_P"].ToString();
                    obj.TheTrang_BMI = DataReader["TheTrang_BMI"].ToString();
                    obj.Phu = DataReader.GetInt("Phu");
                    obj.Phu_ViTri = DataReader["Phu_ViTri"].ToString();
                    obj.DaNiemMac = DataReader["DaNiemMac"].ToString();
                    obj.HoHap = DataReader.GetInt("HoHap");
                    obj.HoHap_Khac = DataReader["HoHap_Khac"].ToString();
                    obj.VetThuong = DataReader.GetInt("VetThuong");
                    obj.VetThuong_Kho = DataReader.GetInt("VetThuong_Kho");
                    obj.VetThuong_DichThamBang = DataReader.GetInt("VetThuong_DichThamBang");
                    obj.VetThuong_NhiemTrung = DataReader.GetInt("VetThuong_NhiemTrung");
                    obj.Dau = DataReader.GetInt("Dau");
                    obj.Dau_ViTri = DataReader["Dau_ViTri"].ToString();
                    obj.Dau_MucDo = DataReader.GetInt("Dau_MucDo");
                    obj.Dau_TinhChat = DataReader.GetInt("Dau_TinhChat");
                    obj.RaMauAD = DataReader.GetInt("RaMauAD");
                    obj.RaMauAD_MauSac = DataReader["RaMauAD_MauSac"].ToString();
                    obj.RaMauAD_SoLuong = DataReader["RaMauAD_SoLuong"].ToString();
                    obj.TieuHoa = DataReader["TieuHoa"].ToString();
                    obj.DaiTien = DataReader["DaiTien"].ToString();
                    obj.TieuTien = DataReader["TieuTien"].ToString();
                    obj.DanLuu = DataReader["DanLuu"].ToString();
                    obj.VanDeBatThuongKhac = DataReader["VanDeBatThuongKhac"].ToString();
                    obj.GioThucHienThuoc = DataReader["GioThucHienThuoc"] != DBNull.Value ? (DateTime?)Convert.ToDateTime(DataReader["GioThucHienThuoc"].ToString()) : null;
                    obj.GioThucHienThuoc_Gio = obj.GioThucHienThuoc;
                    obj.XN_HH = DataReader.GetInt("XN_HH");
                    obj.XN_HS = DataReader.GetInt("XN_HS");
                    obj.XN_VS = DataReader.GetInt("XN_VS");
                    obj.XN_Khac = DataReader["XN_Khac"].ToString();
                    obj.CDHA = DataReader.GetInt("CDHA");
                    obj.TDCN = DataReader.GetInt("TDCN");
                    obj.ThayBang = DataReader.GetInt("ThayBang");
                    obj.ChamSocDanLuu = DataReader.GetInt("ChamSocDanLuu");
                    obj.KTTT_DatSondeDaDay = DataReader.GetInt("KTTT_DatSondeDaDay");
                    obj.KTTT_DatSondeTieu = DataReader.GetInt("KTTT_DatSondeTieu");
                    obj.KTTT_Khac = DataReader["KTTT_Khac"].ToString();
                    obj.CheDoAn = DataReader["CheDoAn"].ToString();
                    obj.Khac_NuoiDuongTinhMach = DataReader.GetInt("Khac_NuoiDuongTinhMach");
                    obj.Khac_ThongBaoNoiQuy = DataReader.GetInt("Khac_ThongBaoNoiQuy");
                    obj.Khac_TVGDSK = DataReader.GetInt("Khac_TVGDSK");
                    obj.ChamSocKhac = DataReader["ChamSocKhac"].ToString();


                    obj.NguoiTao = Common.ConDBNull(DataReader["NguoiTao"]);
                    obj.NgayTao = Common.ConDB_DateTime(DataReader["NgayTao"]);
                    obj.NguoiSua = Common.ConDBNull(DataReader["NguoiSua"]);
                    obj.NgaySua = Common.ConDB_DateTime(DataReader["NgaySua"]);
                    obj.TTCSChiTiet = new List<PhieuTheoDoiVaChamSocPhuKhoa_CT>();
                    obj.TTCSChiTiet = Select_PhieuCHiTiet(MyConnection, obj.IDPhieu.ToString());
                    listResult.Add(obj);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return listResult;
        }
        public bool Insert(MDB.MDBConnection MyConnection, PhieuTheoDoiVaChamSocPhuKhoa obj)
        {
            try
            {
                {
                    string sql = @"INSERT INTO PhieuTDVCSBNPhuKhoa (
                    MaQuanLy,
                    TenKhoa,
                    MaKhoa,
                    MaBenhNhan,
                    SoPhieu,
                    ChanDoan,
                    Buong,
                    Giuong,
                    MaGiuong,
                    NgayVaoVien,
                    TenDDCS,
                    MaDDCS,
                    TGTiepNhan,
                    PCCS,
                    TSDU,
                    TSDU_Thuoc,
                    TSDU_ThucPham,
                    TSDU_Khac,
                    TSDU_Text,
                    TSB,
                    YThuc_HonMe,
                    YThuc_Tinh,
                    YThuc_TinhTiepXuc,
                    YThuc_Khac,
                    TheTrang_H,
                    TheTrang_P,
                    TheTrang_BMI,
                    Phu,
                    Phu_ViTri,
                    DaNiemMac,
                    HoHap,
                    HoHap_Khac,
                    VetThuong,
                    VetThuong_Kho,
                    VetThuong_DichThamBang,
                    VetThuong_NhiemTrung,
                    Dau,
                    Dau_ViTri,
                    Dau_MucDo,
                    Dau_TinhChat,
                    RaMauAD,
                    RaMauAD_MauSac,
                    RaMauAD_SoLuong,
                    TieuHoa,
                    DaiTien,
                    TieuTien,
                    DanLuu,
                    VanDeBatThuongKhac,
                    GioThucHienThuoc,
                    XN_HH,
                    XN_HS,
                    XN_VS,
                    XN_Khac,
                    CDHA,
                    TDCN,
                    ThayBang,
                    ChamSocDanLuu,
                    KTTT_DatSondeDaDay,
                    KTTT_DatSondeTieu,
                    KTTT_Khac,
                    CheDoAn,
                    Khac_NuoiDuongTinhMach,
                    Khac_ThongBaoNoiQuy,
                    Khac_TVGDSK,
                    ChamSocKhac,
                    NguoiTao,
                    NgayTao,
                    NguoiSua,
                    NgaySua
                    ) 
                    VALUES (
                    :MaQuanLy,
                    :TenKhoa,
                    :MaKhoa,
                    :MaBenhNhan,
                    :SoPhieu,
                    :ChanDoan,
                    :Buong,
                    :Giuong,
                    :MaGiuong,
                    :NgayVaoVien,
                    :TenDDCS,
                    :MaDDCS,
                    :TGTiepNhan,
                    :PCCS,
                    :TSDU,
                    :TSDU_Thuoc,
                    :TSDU_ThucPham,
                    :TSDU_Khac,
                    :TSDU_Text,
                    :TSB,
                    :YThuc_HonMe,
                    :YThuc_Tinh,
                    :YThuc_TinhTiepXuc,
                    :YThuc_Khac,
                    :TheTrang_H,
                    :TheTrang_P,
                    :TheTrang_BMI,
                    :Phu,
                    :Phu_ViTri,
                    :DaNiemMac,
                    :HoHap,
                    :HoHap_Khac,
                    :VetThuong,
                    :VetThuong_Kho,
                    :VetThuong_DichThamBang,
                    :VetThuong_NhiemTrung,
                    :Dau,
                    :Dau_ViTri,
                    :Dau_MucDo,
                    :Dau_TinhChat,
                    :RaMauAD,
                    :RaMauAD_MauSac,
                    :RaMauAD_SoLuong,
                    :TieuHoa,
                    :DaiTien,
                    :TieuTien,
                    :DanLuu,
                    :VanDeBatThuongKhac,
                    :GioThucHienThuoc,
                    :XN_HH,
                    :XN_HS,
                    :XN_VS,
                    :XN_Khac,
                    :CDHA,
                    :TDCN,
                    :ThayBang,
                    :ChamSocDanLuu,
                    :KTTT_DatSondeDaDay,
                    :KTTT_DatSondeTieu,
                    :KTTT_Khac,
                    :CheDoAn,
                    :Khac_NuoiDuongTinhMach,
                    :Khac_ThongBaoNoiQuy,
                    :Khac_TVGDSK,
                    :ChamSocKhac,
                    :NguoiTao,
                    :NgayTao,
                    :NguoiSua,
                    :NgaySua
                    ) RETURNING IDPhieu INTO :IDPhieu ";
                    MDB.MDBCommand oracleCommand = new MDB.MDBCommand(sql, MyConnection);
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("MaQuanLy", obj.MaQuanLy));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("TenKhoa", obj.TenKhoa));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("MaKhoa", obj.MaKhoa));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("MaBenhNhan", obj.MaBenhNhan));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("SoPhieu", obj.SoPhieu));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("ChanDoan", obj.ChanDoan));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("Buong", obj.Buong));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("Giuong", obj.Giuong));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("MaGiuong", obj.MaGiuong));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("NgayVaoVien", obj.NgayVaoVien));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("TenDDCS", obj.TenDDCS));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("MaDDCS", obj.MaDDCS));

                    oracleCommand.Parameters.Add(new MDB.MDBParameter("TGTiepNhan", obj.TGTiepNhan));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("PCCS", obj.PCCS));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("TSDU", obj.TSDU));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("TSDU_Thuoc", obj.TSDU_Thuoc));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("TSDU_ThucPham", obj.TSDU_ThucPham));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("TSDU_Khac", obj.TSDU_Khac));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("TSDU_Text", obj.TSDU_Text));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("TSB", obj.TSB));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("YThuc_HonMe", obj.YThuc_HonMe));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("YThuc_Tinh", obj.YThuc_Tinh));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("YThuc_TinhTiepXuc", obj.YThuc_TinhTiepXuc));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("YThuc_Khac", obj.YThuc_Khac));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("TheTrang_H", obj.TheTrang_H));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("TheTrang_P", obj.TheTrang_P));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("TheTrang_BMI", obj.TheTrang_BMI));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("Phu", obj.Phu));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("Phu_ViTri", obj.Phu_ViTri));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("DaNiemMac", obj.DaNiemMac));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("HoHap", obj.HoHap));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("HoHap_Khac", obj.HoHap_Khac));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("VetThuong", obj.VetThuong));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("VetThuong_Kho", obj.VetThuong_Kho));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("VetThuong_DichThamBang", obj.VetThuong_DichThamBang));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("VetThuong_NhiemTrung", obj.VetThuong_NhiemTrung));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("Dau", obj.Dau));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("Dau_ViTri", obj.Dau_ViTri));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("Dau_MucDo", obj.Dau_MucDo));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("Dau_TinhChat", obj.Dau_TinhChat));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("RaMauAD", obj.RaMauAD));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("RaMauAD_MauSac", obj.RaMauAD_MauSac));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("RaMauAD_SoLuong", obj.RaMauAD_SoLuong));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("TieuHoa", obj.TieuHoa));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("DaiTien", obj.DaiTien));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("TieuTien", obj.TieuTien));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("DanLuu", obj.DanLuu));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("VanDeBatThuongKhac", obj.VanDeBatThuongKhac));

                    DateTime? ThoiGian = obj.GioThucHienThuoc.HasValue ? obj.GioThucHienThuoc.Value.Date : (DateTime?)null;
                    var ThoiGianFull = ThoiGian;
                    if (ThoiGian != null)
                    {
                        var ThoiGian_Gio = obj.GioThucHienThuoc_Gio.HasValue ? obj.GioThucHienThuoc_Gio.Value.TimeOfDay : new TimeSpan(0, 0, 0);
                        ThoiGianFull = ThoiGian + ThoiGian_Gio;
                    }
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("GioThucHienThuoc", ThoiGianFull));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("XN_HH", obj.XN_HH));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("XN_HS", obj.XN_HS));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("XN_VS", obj.XN_VS));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("XN_Khac", obj.XN_Khac));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("CDHA", obj.CDHA));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("TDCN", obj.TDCN));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("ThayBang", obj.ThayBang));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("ChamSocDanLuu", obj.ChamSocDanLuu));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("KTTT_DatSondeDaDay", obj.KTTT_DatSondeDaDay));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("KTTT_DatSondeTieu", obj.KTTT_DatSondeTieu));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("KTTT_Khac", obj.KTTT_Khac));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("CheDoAn", obj.CheDoAn));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("Khac_NuoiDuongTinhMach", obj.Khac_NuoiDuongTinhMach));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("Khac_ThongBaoNoiQuy", obj.Khac_ThongBaoNoiQuy));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("Khac_TVGDSK", obj.Khac_TVGDSK));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("ChamSocKhac", obj.ChamSocKhac));


                    oracleCommand.Parameters.Add(new MDB.MDBParameter("NguoiTao", Common.getUserLogin()));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("NgayTao", DateTime.Now));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("NguoiSua", Common.getUserLogin()));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("NgaySua", DateTime.Now));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("IDPhieu", obj.IDPhieu));
                    int n = oracleCommand.ExecuteNonQuery();
                    if (n > 0)
                    {
                        decimal IDPhieu = Common.ConDB_Decimal((oracleCommand.Parameters["IDPhieu"] as MDB.MDBParameter).Value);
                        obj.IDPhieu = IDPhieu;
                    }

                    return n > 0 ? true : false;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public bool Update(MDB.MDBConnection MyConnection, PhieuTheoDoiVaChamSocPhuKhoa obj)
        {
            try
            {
                {

                    string sql = @"UPDATE PhieuTDVCSBNPhuKhoa SET 
                        MaQuanLy=:MaQuanLy,
                        TenKhoa=:TenKhoa,
                        MaKhoa=:MaKhoa,
                        MaBenhNhan=:MaBenhNhan,
                        SoPhieu=:SoPhieu,
                        ChanDoan=:ChanDoan,
                        Buong=:Buong,
                        Giuong=:Giuong,
                        MaGiuong=:MaGiuong,
                        NgayVaoVien=:NgayVaoVien,
                        TenDDCS=:TenDDCS,
                        MaDDCS=:MaDDCS,
                        TGTiepNhan=:TGTiepNhan,
                        PCCS=:PCCS,
                        TSDU=:TSDU,
                        TSDU_Thuoc=:TSDU_Thuoc,
                        TSDU_ThucPham=:TSDU_ThucPham,
                        TSDU_Khac=:TSDU_Khac,
                        TSDU_Text=:TSDU_Text,
                        TSB=:TSB,
                        YThuc_HonMe=:YThuc_HonMe,
                        YThuc_Tinh=:YThuc_Tinh,
                        YThuc_TinhTiepXuc=:YThuc_TinhTiepXuc,
                        YThuc_Khac=:YThuc_Khac,
                        TheTrang_H=:TheTrang_H,
                        TheTrang_P=:TheTrang_P,
                        TheTrang_BMI=:TheTrang_BMI,
                        Phu=:Phu,
                        Phu_ViTri=:Phu_ViTri,
                        DaNiemMac=:DaNiemMac,
                        HoHap=:HoHap,
                        HoHap_Khac=:HoHap_Khac,
                        VetThuong=:VetThuong,
                        VetThuong_Kho=:VetThuong_Kho,
                        VetThuong_DichThamBang=:VetThuong_DichThamBang,
                        VetThuong_NhiemTrung=:VetThuong_NhiemTrung,
                        Dau=:Dau,
                        Dau_ViTri=:Dau_ViTri,
                        Dau_MucDo=:Dau_MucDo,
                        Dau_TinhChat=:Dau_TinhChat,
                        RaMauAD=:RaMauAD,
                        RaMauAD_MauSac=:RaMauAD_MauSac,
                        RaMauAD_SoLuong=:RaMauAD_SoLuong,
                        TieuHoa=:TieuHoa,
                        DaiTien=:DaiTien,
                        TieuTien=:TieuTien,
                        DanLuu=:DanLuu,
                        VanDeBatThuongKhac=:VanDeBatThuongKhac,
                        GioThucHienThuoc=:GioThucHienThuoc,
                        XN_HH=:XN_HH,
                        XN_HS=:XN_HS,
                        XN_VS=:XN_VS,
                        XN_Khac=:XN_Khac,
                        CDHA=:CDHA,
                        TDCN=:TDCN,
                        ThayBang=:ThayBang,
                        ChamSocDanLuu=:ChamSocDanLuu,
                        KTTT_DatSondeDaDay=:KTTT_DatSondeDaDay,
                        KTTT_DatSondeTieu=:KTTT_DatSondeTieu,
                        KTTT_Khac=:KTTT_Khac,
                        CheDoAn=:CheDoAn,
                        Khac_NuoiDuongTinhMach=:Khac_NuoiDuongTinhMach,
                        Khac_ThongBaoNoiQuy=:Khac_ThongBaoNoiQuy,
                        Khac_TVGDSK=:Khac_TVGDSK,
                        ChamSocKhac=:ChamSocKhac,
                        NguoiSua=:NguoiSua,
                        NgaySua=:NgaySua
                        WHERE IDPhieu = " + obj.IDPhieu;
                    MDB.MDBCommand oracleCommand = new MDB.MDBCommand(sql, MyConnection);
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("MaQuanLy", obj.MaQuanLy));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("TenKhoa", obj.TenKhoa));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("MaKhoa", obj.MaKhoa));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("MaBenhNhan", obj.MaBenhNhan));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("SoPhieu", obj.SoPhieu));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("ChanDoan", obj.ChanDoan));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("Buong", obj.Buong));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("Giuong", obj.Giuong));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("MaGiuong", obj.MaGiuong));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("NgayVaoVien", obj.NgayVaoVien));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("TenDDCS", obj.TenDDCS));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("MaDDCS", obj.MaDDCS));

                    oracleCommand.Parameters.Add(new MDB.MDBParameter("TGTiepNhan", obj.TGTiepNhan));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("PCCS", obj.PCCS));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("TSDU", obj.TSDU));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("TSDU_Thuoc", obj.TSDU_Thuoc));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("TSDU_ThucPham", obj.TSDU_ThucPham));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("TSDU_Khac", obj.TSDU_Khac));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("TSDU_Text", obj.TSDU_Text));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("TSB", obj.TSB));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("YThuc_HonMe", obj.YThuc_HonMe));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("YThuc_Tinh", obj.YThuc_Tinh));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("YThuc_TinhTiepXuc", obj.YThuc_TinhTiepXuc));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("YThuc_Khac", obj.YThuc_Khac));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("TheTrang_H", obj.TheTrang_H));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("TheTrang_P", obj.TheTrang_P));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("TheTrang_BMI", obj.TheTrang_BMI));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("Phu", obj.Phu));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("Phu_ViTri", obj.Phu_ViTri));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("DaNiemMac", obj.DaNiemMac));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("HoHap", obj.HoHap));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("HoHap_Khac", obj.HoHap_Khac));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("VetThuong", obj.VetThuong));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("VetThuong_Kho", obj.VetThuong_Kho));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("VetThuong_DichThamBang", obj.VetThuong_DichThamBang));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("VetThuong_NhiemTrung", obj.VetThuong_NhiemTrung));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("Dau", obj.Dau));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("Dau_ViTri", obj.Dau_ViTri));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("Dau_MucDo", obj.Dau_MucDo));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("Dau_TinhChat", obj.Dau_TinhChat));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("RaMauAD", obj.RaMauAD));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("RaMauAD_MauSac", obj.RaMauAD_MauSac));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("RaMauAD_SoLuong", obj.RaMauAD_SoLuong));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("TieuHoa", obj.TieuHoa));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("DaiTien", obj.DaiTien));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("TieuTien", obj.TieuTien));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("DanLuu", obj.DanLuu));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("VanDeBatThuongKhac", obj.VanDeBatThuongKhac));

                    DateTime? ThoiGian = obj.GioThucHienThuoc.HasValue ? obj.GioThucHienThuoc.Value.Date : (DateTime?)null;
                    var ThoiGianFull = ThoiGian;
                    if (ThoiGian != null)
                    {
                        var ThoiGian_Gio = obj.GioThucHienThuoc_Gio.HasValue ? obj.GioThucHienThuoc_Gio.Value.TimeOfDay : new TimeSpan(0, 0, 0);
                        ThoiGianFull = ThoiGian + ThoiGian_Gio;
                    }
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("GioThucHienThuoc", ThoiGianFull));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("XN_HH", obj.XN_HH));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("XN_HS", obj.XN_HS));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("XN_VS", obj.XN_VS));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("XN_Khac", obj.XN_Khac));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("CDHA", obj.CDHA));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("TDCN", obj.TDCN));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("ThayBang", obj.ThayBang));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("ChamSocDanLuu", obj.ChamSocDanLuu));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("KTTT_DatSondeDaDay", obj.KTTT_DatSondeDaDay));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("KTTT_DatSondeTieu", obj.KTTT_DatSondeTieu));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("KTTT_Khac", obj.KTTT_Khac));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("CheDoAn", obj.CheDoAn));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("Khac_NuoiDuongTinhMach", obj.Khac_NuoiDuongTinhMach));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("Khac_ThongBaoNoiQuy", obj.Khac_ThongBaoNoiQuy));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("Khac_TVGDSK", obj.Khac_TVGDSK));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("ChamSocKhac", obj.ChamSocKhac));

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
        public bool Delete(MDB.MDBConnection MyConnection, decimal IDPhieu)
        {
            try
            {
                if (IDPhieu != 0)
                {
                    string sql = @"Delete PhieuTDVCSBNPhuKhoa 
                                WHERE 
                                (IDPhieu = :IDPhieu) ";
                    MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
                    Command.Parameters.Add(new MDB.MDBParameter(":IDPhieu", IDPhieu));
                    int n = Command.ExecuteNonQuery();
                    Command.Dispose();
                    sql = @"Delete PhieuTDVCSBNPhuKhoa_CT 
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
        public bool Delete_ChiTiet(MDB.MDBConnection MyConnection, decimal IDPhieuCT)
        {
            try
            {
                if (IDPhieuCT != 0)
                {
                    string sql = @"Delete PhieuTDVCSBNPhuKhoa_CT 
                                WHERE 
                                (IDPhieuCT = :IDPhieuCT) ";
                    MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
                    Command.Parameters.Add(new MDB.MDBParameter(":IDPhieuCT", IDPhieuCT));
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
        public static List<PhieuTheoDoiVaChamSocPhuKhoa_CT> Select_PhieuCHiTiet(MDB.MDBConnection MyConnection, string IDPhieu, int ModOrder = 0)
        {
            try
            {
                {
                    List<PhieuTheoDoiVaChamSocPhuKhoa_CT> listResult = new List<PhieuTheoDoiVaChamSocPhuKhoa_CT>();
                    string sql = @"SELECT t.*
                    FROM PhieuTDVCSBNPhuKhoa_CT t
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
                        var obj = new PhieuTheoDoiVaChamSocPhuKhoa_CT();
                        obj.IDPhieuCT = Common.ConDB_Decimal(DataReader["IDPhieuCT"]);
                        obj.IDPhieu = Common.ConDB_Decimal(DataReader["IDPhieu"]);
                        obj.ThoiGian = Common.ConDB_DateTime(DataReader["ThoiGian"]);
                        obj.NguoiTao = Common.ConDBNull(DataReader["NguoiTao"]);
                        obj.MaNguoiTao = Common.ConDBNull(DataReader["MaNguoiTao"]);
                        obj.ThoiGianDHST = Common.ConDB_DateTimeNull(DataReader["ThoiGianDHST"]);
                        obj.Mach = Common.ConDBNull_double(DataReader["Mach"]);
                        obj.T = Common.ConDBNull_double(DataReader["T"]);
                        obj.HA = Common.ConDBNull(DataReader["HA"]);
                        obj.NT = Common.ConDBNull(DataReader["NT"]);
                        obj.ThoiGianTHCS = Common.ConDB_DateTimeNull(DataReader["ThoiGianTHCS"]);
                        obj.NguoiThucHien = Common.ConDBNull(DataReader["NguoiThucHien"]);
                        obj.MaNguoiThucHien = Common.ConDBNull(DataReader["MaNguoiThucHien"]);
                        obj.PCCS = Common.ConDBNull(DataReader["PCCS"]);
                        obj.ChanDoanSauMo = Common.ConDBNull(DataReader["ChanDoanSauMo"]);
                        obj.NgayThu = Common.ConDBNull(DataReader["NgayThu"]);

                        obj.VetThuong_Kho = DataReader.GetInt("VetThuong_Kho");
                        obj.VetThuong_DichThamBang = DataReader.GetInt("VetThuong_DichThamBang");
                        obj.VetThuong_NhiemTrung = DataReader.GetInt("VetThuong_NhiemTrung");
                        obj.Dau = DataReader.GetInt("Dau");
                        obj.Dau_ViTri = DataReader["Dau_ViTri"].ToString();
                        obj.Dau_MucDo = DataReader.GetInt("Dau_MucDo");
                        obj.Dau_TinhChat = DataReader.GetInt("Dau_TinhChat");
                        obj.RaMauAD = DataReader.GetInt("RaMauAD");
                        obj.RaMauAD_MauSac = DataReader["RaMauAD_MauSac"].ToString();
                        obj.RaMauAD_SoLuong = DataReader["RaMauAD_SoLuong"].ToString();
                        obj.DanLuu = DataReader["DanLuu"].ToString();
                        obj.VanDeKhac = DataReader["VanDeKhac"].ToString();
                        obj.GioThucHienThuoc = DataReader["GioThucHienThuoc"] != DBNull.Value ? (DateTime?) Convert.ToDateTime(DataReader["GioThucHienThuoc"].ToString()): null;
                        obj.GioThucHienThuoc_Gio = obj.GioThucHienThuoc;
                        obj.XNMoi = DataReader["XNMoi"].ToString();
                        obj.CDHAMoi = DataReader["CDHAMoi"].ToString();
                        obj.CS_ThayBang = DataReader.GetInt("CS_ThayBang");
                        obj.CS_DanLuu = DataReader.GetInt("CS_DanLuu");
                        obj.KTTT = DataReader["KTTT"].ToString();
                        obj.CheDoAn = DataReader["CheDoAn"].ToString();
                        obj.Khac_NuoiDuongTinhMach = DataReader.GetInt("Khac_NuoiDuongTinhMach");
                        obj.Khac_TuVanGDSK = DataReader.GetInt("Khac_TuVanGDSK");
                        obj.ChamSocKhac = DataReader["ChamSocKhac"].ToString();
                        obj.MaDDCS = DataReader["MaDDCS"].ToString();
                        obj.TenDDCS = DataReader["TenDDCS"].ToString();

                        obj.NGAYKY = Common.ConDBNull(DataReader["NGAYKY"]);
                        obj.COMPUTERKYTEN = Common.ConDBNull(DataReader["COMPUTERKYTEN"]);
                        obj.MaSoKy = Common.ConDBNull(DataReader["MASOKYTEN"]);
                        obj.TENFILEKY = Common.ConDBNull(DataReader["TENFILEKY"]);
                        obj.USERNAMEKY = Common.ConDBNull(DataReader["USERNAMEKY"]);
                        obj.Daky = !string.IsNullOrEmpty(obj.MaSoKy) ? true : false;
                        listResult.Add(obj);
                    }
                    return listResult;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public bool InsertOrUpdate_ChiTiet(MDB.MDBConnection MyConnection, PhieuTheoDoiVaChamSocPhuKhoa_CT obj)
        {
            try
            {
                string sql = @"update PhieuTDVCSBNPhuKhoa_CT set
                    IDPhieu=:IDPhieu,
                    ThoiGian=:ThoiGian,
                    NguoiTao=:NguoiTao,
                    MaNguoiTao=:MaNguoiTao,
                    ThoiGianDHST=:ThoiGianDHST,
                    Mach=:Mach,
                    T=:T,
                    HA=:HA,
                    NT=:NT,
                    ThoiGianTHCS=:ThoiGianTHCS,
                    NguoiThucHien=:NguoiThucHien,
                    MaNguoiThucHien=:MaNguoiThucHien,
                    PCCS=:PCCS,
                    ChanDoanSauMo=:ChanDoanSauMo,
                    NgayThu=:NgayThu,
                    VetThuong_Kho=:VetThuong_Kho,
                    VetThuong_DichThamBang=:VetThuong_DichThamBang,
                    VetThuong_NhiemTrung=:VetThuong_NhiemTrung,
                    Dau=:Dau,
                    Dau_ViTri=:Dau_ViTri,
                    Dau_MucDo=:Dau_MucDo,
                    Dau_TinhChat=:Dau_TinhChat,
                    RaMauAD=:RaMauAD,
                    RaMauAD_MauSac=:RaMauAD_MauSac,
                    RaMauAD_SoLuong=:RaMauAD_SoLuong,
                    DanLuu=:DanLuu,
                    VanDeKhac=:VanDeKhac,
                    GioThucHienThuoc=:GioThucHienThuoc,
                    XNMoi=:XNMoi,
                    CDHAMoi=:CDHAMoi,
                    CS_ThayBang=:CS_ThayBang,
                    CS_DanLuu=:CS_DanLuu,
                    KTTT=:KTTT,
                    CheDoAn=:CheDoAn,
                    Khac_NuoiDuongTinhMach=:Khac_NuoiDuongTinhMach,
                    Khac_TuVanGDSK=:Khac_TuVanGDSK,
                    ChamSocKhac=:ChamSocKhac,
                    MaDDCS=:MaDDCS,
                    TenDDCS=:TenDDCS

                    WHERE IDPhieuCT = " + obj.IDPhieuCT + "";

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
                oracleCommand.Parameters.Add(new MDB.MDBParameter("ThoiGianTHCS", obj.ThoiGianTHCS));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("NguoiThucHien", obj.NguoiThucHien));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("MaNguoiThucHien", obj.MaNguoiThucHien));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("PCCS", obj.PCCS));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("ChanDoanSauMo", obj.ChanDoanSauMo));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("NgayThu", obj.NgayThu));

                oracleCommand.Parameters.Add(new MDB.MDBParameter("VetThuong_Kho", obj.VetThuong_Kho));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("VetThuong_DichThamBang", obj.VetThuong_DichThamBang));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("VetThuong_NhiemTrung", obj.VetThuong_NhiemTrung));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("Dau", obj.Dau));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("Dau_ViTri", obj.Dau_ViTri));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("Dau_MucDo", obj.Dau_MucDo));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("Dau_TinhChat", obj.Dau_TinhChat));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("RaMauAD", obj.RaMauAD));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("RaMauAD_MauSac", obj.RaMauAD_MauSac));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("RaMauAD_SoLuong", obj.RaMauAD_SoLuong));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("DanLuu", obj.DanLuu));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("VanDeKhac", obj.VanDeKhac));

                DateTime? ThoiGian = obj.GioThucHienThuoc.HasValue ? obj.GioThucHienThuoc.Value.Date : (DateTime?)null;
                var ThoiGianFull = ThoiGian;
                if (ThoiGian != null)
                {
                    var ThoiGian_Gio = obj.GioThucHienThuoc_Gio.HasValue ? obj.GioThucHienThuoc_Gio.Value.TimeOfDay : new TimeSpan(0, 0, 0);
                    ThoiGianFull = ThoiGian + ThoiGian_Gio;
                }
                oracleCommand.Parameters.Add(new MDB.MDBParameter("GioThucHienThuoc", ThoiGianFull));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("XNMoi", obj.XNMoi));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("CDHAMoi", obj.CDHAMoi));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("CS_ThayBang", obj.CS_ThayBang));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("CS_DanLuu", obj.CS_DanLuu));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("KTTT", obj.KTTT));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("CheDoAn", obj.CheDoAn));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("Khac_NuoiDuongTinhMach", obj.Khac_NuoiDuongTinhMach));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("Khac_TuVanGDSK", obj.Khac_TuVanGDSK));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("ChamSocKhac", obj.ChamSocKhac));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("MaDDCS", obj.MaDDCS));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("TenDDCS", obj.TenDDCS));
                int n = oracleCommand.ExecuteNonQuery();
                if (n == 0)
                {
                    oracleCommand.Dispose();
                    sql = @"insert into PhieuTDVCSBNPhuKhoa_CT (
                    IDPhieu,
                    ThoiGian,
                    NguoiTao,
                    MaNguoiTao,
                    ThoiGianDHST,
                    Mach,
                    T,
                    HA,
                    NT,
                    ThoiGianTHCS,
                    NguoiThucHien,
                    MaNguoiThucHien,
                    PCCS,
                    ChanDoanSauMo,
                    NgayThu,
                    VetThuong_Kho,
                    VetThuong_DichThamBang,
                    VetThuong_NhiemTrung,
                    Dau,
                    Dau_ViTri,
                    Dau_MucDo,
                    Dau_TinhChat,
                    RaMauAD,
                    RaMauAD_MauSac,
                    RaMauAD_SoLuong,
                    DanLuu,
                    VanDeKhac,
                    GioThucHienThuoc,
                    XNMoi,
                    CDHAMoi,
                    CS_ThayBang,
                    CS_DanLuu,
                    KTTT,
                    CheDoAn,
                    Khac_NuoiDuongTinhMach,
                    Khac_TuVanGDSK,
                    ChamSocKhac,
                    MaDDCS,
                    TenDDCS

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
                    :ThoiGianTHCS,
                    :NguoiThucHien,
                    :MaNguoiThucHien,
                    :PCCS,
                    :ChanDoanSauMo,
                    :NgayThu,
                    :VetThuong_Kho,
                    :VetThuong_DichThamBang,
                    :VetThuong_NhiemTrung,
                    :Dau,
                    :Dau_ViTri,
                    :Dau_MucDo,
                    :Dau_TinhChat,
                    :RaMauAD,
                    :RaMauAD_MauSac,
                    :RaMauAD_SoLuong,
                    :DanLuu,
                    :VanDeKhac,
                    :GioThucHienThuoc,
                    :XNMoi,
                    :CDHAMoi,
                    :CS_ThayBang,
                    :CS_DanLuu,
                    :KTTT,
                    :CheDoAn,
                    :Khac_NuoiDuongTinhMach,
                    :Khac_TuVanGDSK,
                    :ChamSocKhac,
                    :MaDDCS,
                    :TenDDCS
                    ) RETURNING IDPhieuCT INTO :IDPhieuCT";
                    oracleCommand = new MDB.MDBCommand(sql, MyConnection);
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("IDPhieu", obj.IDPhieu));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("ThoiGian", obj.ThoiGian));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("NguoiTao", obj.NguoiTao));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("MaNguoiTao", obj.MaNguoiTao));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("ThoiGianDHST", obj.ThoiGianDHST));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("Mach", obj.Mach));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("T", obj.T));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("HA", obj.HA));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("NT", obj.NT));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("ThoiGianTHCS", obj.ThoiGianTHCS));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("NguoiThucHien", obj.NguoiThucHien));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("MaNguoiThucHien", obj.MaNguoiThucHien));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("PCCS", obj.PCCS));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("ChanDoanSauMo", obj.ChanDoanSauMo));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("NgayThu", obj.NgayThu));

                    oracleCommand.Parameters.Add(new MDB.MDBParameter("VetThuong_Kho", obj.VetThuong_Kho));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("VetThuong_DichThamBang", obj.VetThuong_DichThamBang));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("VetThuong_NhiemTrung", obj.VetThuong_NhiemTrung));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("Dau", obj.Dau));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("Dau_ViTri", obj.Dau_ViTri));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("Dau_MucDo", obj.Dau_MucDo));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("Dau_TinhChat", obj.Dau_TinhChat));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("RaMauAD", obj.RaMauAD));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("RaMauAD_MauSac", obj.RaMauAD_MauSac));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("RaMauAD_SoLuong", obj.RaMauAD_SoLuong));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("DanLuu", obj.DanLuu));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("VanDeKhac", obj.VanDeKhac));

                    ThoiGian = obj.GioThucHienThuoc.HasValue ? obj.GioThucHienThuoc.Value.Date : (DateTime?)null;
                    ThoiGianFull = ThoiGian;
                    if (ThoiGian != null)
                    {
                        var ThoiGian_Gio = obj.GioThucHienThuoc_Gio.HasValue ? obj.GioThucHienThuoc_Gio.Value.TimeOfDay : new TimeSpan(0, 0, 0);
                        ThoiGianFull = ThoiGian + ThoiGian_Gio;
                    }
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("GioThucHienThuoc", ThoiGianFull));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("XNMoi", obj.XNMoi));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("CDHAMoi", obj.CDHAMoi));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("CS_ThayBang", obj.CS_ThayBang));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("CS_DanLuu", obj.CS_DanLuu));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("KTTT", obj.KTTT));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("CheDoAn", obj.CheDoAn));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("Khac_NuoiDuongTinhMach", obj.Khac_NuoiDuongTinhMach));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("Khac_TuVanGDSK", obj.Khac_TuVanGDSK));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("ChamSocKhac", obj.ChamSocKhac));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("MaDDCS", obj.MaDDCS));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("TenDDCS", obj.TenDDCS));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("IDPhieuCT", obj.IDPhieuCT));
                    n = oracleCommand.ExecuteNonQuery();
                    long nextval = Convert.ToInt64((oracleCommand.Parameters["IDPhieuCT"] as MDB.MDBParameter).Value);
                    obj.IDPhieuCT = nextval;
                }
                return n > 0 ? true : false;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        public static DataSet GetDataSet(MDB.MDBConnection MyConnection, decimal IDPhieu)
        {
            var timer = new Stopwatch();
            StringBuilder sql = new StringBuilder();
            timer.Start();
            try
            {
                sql.AppendLine(@"SELECT P.*, '' SoNhapVien, '' MaBenhAn , '' SoVaoVien, '' TenBenhNhan,
                        '' TUOI, '' SoYTe, '' BENHVIEN,
                        ''  GioiTinh
                    FROM PhieuTDVCSBNPhuKhoa P
                ");
                sql.AppendLine(" WHERE P.IDPhieu = " + IDPhieu);
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

                DataTable dt = Common.ListToDataTable(Select_PhieuCHiTiet(MyConnection, IDPhieu.ToString()), "CT");
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
