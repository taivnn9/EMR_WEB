using Cda2Fhir;
using EMR.KyDienTu;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using Newtonsoft.Json;
using System;
using System.ComponentModel.DataAnnotations;

namespace EMR_MAIN
{
    public class LichSuChuyenKhoa
    {
        public string ChuyenKhoa { get; set; }
        public string NgayChuyenKhoa { get; set; }
        public DateTime? DateNgayChuyenKhoa { get; set; }
        public int? SoNgayDieuTriKhoa { get; set; }
    }
    /// <summary>
    public class DauSinhTon
    {
        public int? Mach { get; set; }
        public double? NhietDo { get; set; }
        public string HuyetAp { get; set; }
        public int? NhipTho { get; set; }
        public double? CanNang { get; set; }
        public double? ChieuCao { get; set; }
        public double? BMI { get; set; }
        //them moi
        public int DhstId { get; set; }
        public DateTime? ExecuteTime { get; set; }
        public bool IsTracking { get; set; }
        public bool IsCare { get; set; }
    }
    public class HoSo
    {
        public int XQuang { get; set; }
        public int CTScanner { get; set; }
        public int SieuAm { get; set; }
        public int XetNghiem { get; set; }
        public int Khac { get; set; }
        public string Khac_Text { get; set; }
        public int ToanBoHoSo { get; set; }
    }
    /// <summary>
    /// 06/07/2021 Add by Hòa Issues 66720 truyền danh sách thuốc đã sử dụng qua EMR
    /// </summary>
    public class DsThuocDangSuDung
    {
        public int IDThuoc { get; set; }
        public string TenThuoc { get; set; }
        public string HamLuong { get; set; }
        public string DonViTinh { get; set; }
        public string SoLuong { get; set; }
        public string FullTenThuoc
        {
            get
            {
                string temp = "";
                if (!string.IsNullOrEmpty(TenThuoc))
                {
                    temp += TenThuoc;
                }
                temp += " -- ";
                if (!string.IsNullOrEmpty(HamLuong))
                {
                    temp += HamLuong;
                }
                else
                {
                    temp += "";
                }
                temp += " -- ";
                if (!string.IsNullOrEmpty(DonViTinh))
                {
                    temp += DonViTinh;
                }
                return temp;
            }
        }
    }
    [NhomThongTin(NhomThongTinBenhAn.HoiBenh)]
    public class DacDiemLienQuanBenh
    {
        public bool DiUng { get; set; }
        public string DiUng_Text { get; set; }
        public bool MaTuy { get; set; }
        public string MaTuy_Text { get; set; }
        public bool RuouBia { get; set; }
        public string RuouBia_Text { get; set; }
        public bool ThuocLa { get; set; }
        public string ThuocLa_Text { get; set; }
        public bool ThuocLao { get; set; }
        public string ThuocLao_Text { get; set; }
        public bool Khac_DacDiemLienQuanBenh { get; set; }
        public string Khac_DacDiemLienQuanBenh_Text { get; set; }
        public bool DaiThaoDuong { get; set; }
        public string DaiThaoDuong_Text { get; set; }
        public bool CaoHuyetAp { get; set; }
        public string CaoHuyetAp_Text { get; set; }
        public bool RoiLoanMoMau { get; set; }
        public string RoiLoanMoMau_Text { get; set; }
        public bool YeuToGiaDinh { get; set; }
        public string YeuToGiaDinh_Text { get; set; }
    }

    public interface IBase
    {
        [MoTaDuLieu("ID mẫu phiếu")]
        int IDMauPhieu { get; set; }
        [MoTaDuLieu("Tên mẫu phiếu")]
        string TenMauPhieu { get; set; }
        [MoTaDuLieu("", "", 0)]
        string MaSoKyTen { get; set; }
        [MoTaDuLieu("", "", 0)]
        string MaSoKyTen_KB { get; set; }
        [MoTaDuLieu("", "", 0)]
        string MaSoKyTen_TK { get; set; }
        [MoTaDuLieu("", "", 0)]
        bool DaKy { get; set; }
        [MoTaDuLieu("", "", 0)]
        bool DaKy_KB { get; set; }
        [MoTaDuLieu("", "", 0)]
        bool DaKy_TK { get; set; }
    }
    public interface IBenhAnBase
    {
        #region
        [MoTaDuLieu("Mã quản lý: mã duy nhất trong 1 đợt khám chữa bệnh (kcb), không trùng giữa các đợt kcb khác nhau", "", 1)]
        decimal MaQuanLy { get; set; }
        [MoTaDuLieu("Thời gian vào viện là ngày thứ mấy của bệnh")]
        int VaoNgayThu { get; set; }
        DauSinhTon DauSinhTon { get; set; }
        [MoTaDuLieu("Khám toàn thân")]
        string ToanThan { get; set; }
        [MoTaDuLieu("Khám tuần hoàn")]
        string TuanHoan { get; set; }
        [CodeHL7("", "", "", "714324006", "714324006", "Entire organ in respiratory system")]
        string HoHap { get; set; }
        [CodeHL7("", "", "", "272627002", "272627002", "Entire digestive orga")]
        string TieuHoa { get; set; }
        string ThanTietNieuSinhDuc { get; set; }
        [CodeHL7("", "", "", "256864008", "256864008", "Entire nerve")]
        string ThanKinh { get; set; }
        [CodeHL7("", "", "", "244716004,302536002", "244716004", "Entire skeletal muscle (organ)")]
        string CoXuongKhop { get; set; }
        string TaiMuiHong { get; set; }
        string RangHamMat { get; set; }
        string Mat { get; set; }
        string Khac_CacCoQuan { get; set; }
        string CacXetNghiemCanLamSangCanLam { get; set; }
        string TomTatBenhAn { get; set; }
        string BenhChinh { get; set; }
        string BenhKemTheo { get; set; }
        string PhanBiet { get; set; }
        string TienLuong { get; set; }
        string HuongDieuTri { get; set; }
        DateTime NgayKhamBenh { get; set; }
        string BacSyLamBenhAn { get; set; }
        HoSo HoSo { get; set; }
        string QuaTrinhBenhLyVaDienBien { get; set; }
        string TomTatKetQuaXetNghiem { get; set; }
        string PhuongPhapDieuTri { get; set; }
        string TinhTrangNguoiBenhRaVien { get; set; }
        string HuongDieuTriVaCacCheDoTiepTheo { get; set; }
        string NguoiNhanHoSo { get; set; }
        string NguoiGiaoHoSo { get; set; }
        DateTime NgayTongKet { get; set; }
        string BacSyDieuTri { get; set; }
        string BacSyKhamBenh { get; set; }
        DacDiemLienQuanBenh DacDiemLienQuanBenh { get; set; }
        #endregion
    }

    public interface IHoiBenhBase
    {
        [MoTaDuLieu("Lý do vào viện")]
        [CodeHL7("46239-0", "46239-0", "Chief complaint+Reason for visit")]
        string LyDoVaoVien { get; set; }
        [CodeHL7("10164-2", "10164-2", "History of Present illness Narrative", "370135005", "370135005", "Pathological process")]
        string QuaTrinhBenhLy { get; set; }
        [CodeHL7("67437-4", "67437-4", "Disease history")]
        string TienSuBenhBanThan { get; set; }
        [CodeHL7("10157-6", "10157-6", "History of family member diseases", "137667000", "137667000", "Family history")]
        string TienSuBenhGiaDinh { get; set; }
    }
    /// <summary>
    /// Tất cả các lớp bệnh án đều kế thừa từ đây
    /// </summary>
    public class BenhAnBase : IBenhAnBase, IHoiBenhBase
    {
        #region
        [MoTaDuLieu("Mã quản lý: mã duy nhất trong 1 đợt khám chữa bệnh (kcb), không trùng giữa các đợt kcb khác nhau","",1)]
        public decimal MaQuanLy { get; set; }

        [MoTaDuLieu("Lý do vào viện")]
        [CodeHL7("46239-0", "46239-0", "Chief complaint+Reason for visit")]
        [NhomThongTin(NhomThongTinBenhAn.HoiBenh)]
        public string LyDoVaoVien { get; set; }

        [MoTaDuLieu("Thời gian vào viện là ngày thứ mấy của bệnh")]
        [NhomThongTin(NhomThongTinBenhAn.HoiBenh)]
        public int VaoNgayThu { get; set; }

        [CodeHL7("10164-2", "10164-2", "History of Present illness Narrative", "370135005", "370135005", "Pathological process")]
        [MoTaDuLieu("Quá trình bệnh lý")]
        [NhomThongTin(NhomThongTinBenhAn.HoiBenh)]
        public string QuaTrinhBenhLy { get; set; }

        [MoTaDuLieu("Tiền sử bệnh bản thân")]
        [NhomThongTin(NhomThongTinBenhAn.HoiBenh)]
        [CodeHL7("67437-4", "67437-4", "Disease history")]
        public string TienSuBenhBanThan { get; set; }

        [CodeHL7("10157-6", "10157-6", "History of family member diseases", "137667000", "137667000", "Family history")]
        [MoTaDuLieu("Tiền sử bệnh gia đình")]
        [NhomThongTin(NhomThongTinBenhAn.HoiBenh)]
        public string TienSuBenhGiaDinh { get; set; }

        [NhomThongTin(NhomThongTinBenhAn.HoiBenh)]
        [MoTaDuLieu("Đặc điểm liên quan bệnh")]
        public DacDiemLienQuanBenh DacDiemLienQuanBenh { get; set; }

        [CodeHL7("8716-3", "8716-3", "Vital signs", "", "", "")]
        [NhomThongTin(NhomThongTinBenhAn.KhamBenh)]
        [MoTaDuLieu("Dấu sinh tồn")]
        public DauSinhTon DauSinhTon { get; set; }

        [MoTaDuLieu("Khám toàn thân")]
        [NhomThongTin(NhomThongTinBenhAn.KhamBenh)]
        [CodeHL7("55286-9", "55286-9", "Physical exam by body areas", "", "", "")]
        public string ToanThan { get; set; }

        [CodeHL7("", "", "", "256864008", "256864008", "Entire nerve")]
        [MoTaDuLieu("Khám thần kinh")]
        [JsonProperty("ThanKinh")]
        [NhomThongTin(NhomThongTinBenhAn.KhamBenh)]
        public string ThanKinh { get; set; }

        [MoTaDuLieu("Khám tuần hoàn")]
        [NhomThongTin(NhomThongTinBenhAn.KhamBenh)]
        [CodeHL7("20201-0", "20201-0", "Circulatory system")]
        public string TuanHoan { get; set; }

        [CodeHL7("53756-3", "53756-3", "Respiratory status", "714324006", "714324006", "Entire organ in respiratory system")]
        [MoTaDuLieu("Khám hô hấp")]
        [NhomThongTin(NhomThongTinBenhAn.KhamBenh)]
        public string HoHap { get; set; }

        [CodeHL7("", "", "", "272627002", "272627002", "Entire digestive orga")]
        [MoTaDuLieu("Khám tiêu hóa")]
        [NhomThongTin(NhomThongTinBenhAn.KhamBenh)]
        public string TieuHoa { get; set; }

        [CodeHL7("", "", "", "244716004,302536002", "244716004", "Entire skeletal muscle (organ)")]
        [MoTaDuLieu("Khám cơ xương khớp")]
        [NhomThongTin(NhomThongTinBenhAn.KhamBenh)]
        public string CoXuongKhop { get; set; }

        [MoTaDuLieu("Khám thận - tiết niệu - sinh dục")]
        [NhomThongTin(NhomThongTinBenhAn.KhamBenh)]
        [CodeHL7("46944-5", "46944-5", "Urinary Function Status")]
        public string ThanTietNieuSinhDuc { get; set; }

        [MoTaDuLieu("Khác")]
        [JsonProperty("ThongTinKhamBenhKhac")]
        [NhomThongTin(NhomThongTinBenhAn.KhamBenh)]
        public string Khac_CacCoQuan { get; set; }

        [NhomThongTin(NhomThongTinBenhAn.KhamBenh)]
        [MoTaDuLieu("Các xét nghiệm cận lâm sàng cần làm")]
        [CodeHL7("22032-7", "22032-7", "Lab tests.total")]
        public string CacXetNghiemCanLamSangCanLam { get; set; }

        [CodeHL7("55108-5", "55108-5", "Clinical presentation")]
        [MoTaDuLieu("Tóm tắt bệnh án", "", 0, 1, 1)]
        [NhomThongTin(NhomThongTinBenhAn.KhamBenh)]
        public string TomTatBenhAn { get; set; }

        [CodeHL7("42347-5", "42347-5", "Admission diagnosis")]
        [MoTaDuLieu("Bệnh chính", "", 0, 1, 1)]
        //[NhomThongTin(NhomThongTinBenhAn.ChanDoan_KhiVaoKDT)]
        public string BenhChinh { get; set; }

        [CodeHL7("54545-9", "54545-9", "Additional diagnoses")]
        //[NhomThongTin(NhomThongTinBenhAn.ChanDoan_KhiVaoKDT)]
        [MoTaDuLieu("Chẩn đoán bệnh kèm theo")]
        public string BenhKemTheo { get; set; }

        //[NhomThongTin(NhomThongTinBenhAn.ChanDoan_KhiVaoKDT)]
        [MoTaDuLieu("Chẩn đoán phân biệt")]
        [CodeHL7("92238-5", "92238-5", "Differential diagnosis")]
        public string PhanBiet { get; set; }

        [MoTaDuLieu("Tiên lượng")]
        [CodeHL7("75328-5", "75328-5", "Prognosis")]
        public string TienLuong { get; set; }

        [MoTaDuLieu("Hướng điều trị")]
        [CodeHL7("18657-7", "18657-7", "Plan of treatment")]
        public string HuongDieuTri { get; set; }

        [MoTaDuLieu("Bác sĩ làm bệnh án", "", 0, 1, 1)]
        [JsonProperty("BacSiLamBenhAn")]
        public string BacSyLamBenhAn { get; set; }

        [CodeHL7("10164-2", "10164-2", "History of Present illness Narrative", "370135005", "370135005", "Pathological process")]
        [JsonProperty("QuaTrinhBenhLyVaDienBienLamSang")]
        [NhomThongTin(NhomThongTinBenhAn.TongKet)]
        [MoTaDuLieu("Quá trình bệnh lý và diễn biến lâm sàng")]
        public string QuaTrinhBenhLyVaDienBien { get; set; }

        [CodeHL7("96552-5", "96552-5", "Result of most recent lab test for condition of interest", "74314007", "74314007", "Subclinical")]
        [NhomThongTin(NhomThongTinBenhAn.TongKet)]
        [MoTaDuLieu("Tóm tắt kết quả xét nghiệm cận lâm sàng có gia trị chẩn đoán")]
        public string TomTatKetQuaXetNghiem { get; set; }

        [CodeHL7("52468-6", "52468-6", "Major Treatments")]
        [NhomThongTin(NhomThongTinBenhAn.TongKet)]
        [MoTaDuLieu("Phương pháp điều trị")]
        public string PhuongPhapDieuTri { get; set; }

        [NhomThongTin(NhomThongTinBenhAn.TongKet)]
        [MoTaDuLieu("Tình trạng người bệnh ra viện")]
        [CodeHL7("52523-8", "52523-8", "Discharge status")]
        public string TinhTrangNguoiBenhRaVien { get; set; }

        [NhomThongTin(NhomThongTinBenhAn.TongKet)]
        [MoTaDuLieu("Hướng điều trị và các chế độ tiếp theo")]
        [CodeHL7("60513-9", "60513-9", "Treatment-subsequent & other section")]
        public string HuongDieuTriVaCacCheDoTiepTheo { get; set; }

        [MoTaDuLieu("Thông tin hồ sơ")]
        [NhomThongTin(NhomThongTinBenhAn.TongKet)]
        public HoSo HoSo { get; set; }

        [NhomThongTin(NhomThongTinBenhAn.TongKet)]
        [MoTaDuLieu("Người nhận hồ sơ")]
        public string NguoiNhanHoSo { get; set; }

        [NhomThongTin(NhomThongTinBenhAn.TongKet)]
        [MoTaDuLieu("Người giao hồ sơ")]
        public string NguoiGiaoHoSo { get; set; }

        [NhomThongTin(NhomThongTinBenhAn.TongKet)]
        [MoTaDuLieu("Ngày tổng kết")]
        [CodeHL7("71504-5", "71504-5", "Date closed")]
        public DateTime NgayTongKet { get; set; }

        [MoTaDuLieu("Bác sĩ điều trị")]
        [NhomThongTin(NhomThongTinBenhAn.TongKet)]
        [JsonProperty("BacSiDieuTri")]
        [CodeHL7("56854-3", "56854-3", "Inpatient practitioner")]
        public string BacSyDieuTri { get; set; }

        [CodeHL7("71392-5", "71392-5", "CMS - ear-nose-mouth-throat exam panel")]
        public string TaiMuiHong { get; set; }
        public string RangHamMat { get; set; }

        [CodeHL7("29271-4", "29271-4", "Eye physical examination")]
        public string Mat { get; set; }
        public DateTime NgayKhamBenh { get; set; }

        [MoTaDuLieu("Bác sĩ khám bệnh")]
        [JsonProperty("BacSiKhamBenh")]
        public string BacSyKhamBenh { get; set; }
        #endregion
    }



    [JsonObject]
    public class HoSoChuyenVien_New
    {
        public HanhChinhBenhNhan ThongTinHanhChinh { get; set; }
        public ThongTinDieuTri ThongTinDieuTri { get; set; }
        public object ThongTinBenhAn { get; set; }
        public EMR_MAIN.DATABASE.Other.GiayChuyenVien GiayChuyenVien { get; set; }
    }
    [JsonObject]
    public class HoSoChuyenVien : HoSoChuyenVien_New
    {
        [Key]
        [BsonId]
        public ObjectId _id { get; set; } = ObjectId.GenerateNewId();
        public long NgayTao { get; set; } = long.Parse(DateTime.Now.ToString("yyyyMMddHHmmss"));
        public string NguoiGui { get; set; }
        public string MaGiaoDich { get; set; } = ObjectId.GenerateNewId().ToString();
    }
    [JsonObject]
    public class ThongTinCapSoLuTru
    {
        [Key]
        [BsonId]
        public ObjectId _id { get; set; } = ObjectId.GenerateNewId();
        public string MaBenhVien { get; set; }
        public string MaKhoaPhong { get; set; }
        public string MaQuanLy { get; set; }
        public DateTime NgayTao { get; set; }
        public int IDBenhAn { get; set; }
        public string NguoiGui { get; set; }
        [BsonDefaultValue(0)]
        public long STT { get; set; } = 0;
        public string SoLuuTru { get {
                return MaBenhVien + "-" + MaKhoaPhong + "/" + STT.ToString();
            }
            set { }
        } 
    }

    [JsonObject]
    public class ThongTinCapSoLuTru_New
    {
        public string MaQuanLy { get; set; } 
        public string MaBenhVien { get; set; }
        public string MaKhoaPhong { get; set; }
        public int IDBenhAn { get; set; }
    }
}
