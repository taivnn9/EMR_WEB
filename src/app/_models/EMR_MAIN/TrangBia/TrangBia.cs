using Cda2Fhir;
using EMR.KyDienTu;
using MedilinkHL7.SDK;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace EMR_MAIN
{
    //07/06/2021 Add by Hòa Issues 64961
    public enum CLS_PTTT
    {
        CongThucMauHongCau = 1,
        CongThucMauBachcau = 2,
        CongThucMauN = 3,
        CongThucMauL = 4,
        NhomMau = 5,
        ThoiGianMauChay = 6,
        ThoiGianMauDong = 7,
        HuyetSacTo = 8,
        NuocTieuHongCau = 9,
        NuocTieuBachCau = 10,
        NuocTieuProtein = 11,
        NuocTieuTrucNieu = 12,
        NuocTieuDuongNieu = 13,
        NuocTieuSacToMa = 14,
        SinhHoaUre = 15,
        Creatimin = 16,
        Glucose = 17,
        BilirubinTP = 18,
        BilirubinTT = 19,
        BilirubinGT = 20,
        ProteinTP = 21,
        Albumin = 22,
        Got = 23,
        Gpt = 24,
        DongMauPT = 25,
        Aptt = 26,
        Fibrinogen = 27,
        XetNghiemHIV = 28,
        HbsAg = 29,
        Hcv = 30,
        XQuang = 31,
        SieuAm = 32,
        DienTim = 33,
        XetNghiemKhac = 34,
        HGB = 35,
        HCT = 36,
        Neu = 37,
        Lymph = 38,
        TieuCau = 39,
        GiangMai = 40,
        PT = 41,
        Na = 42,
        K = 43,
        Cl = 44,
        HPV = 45,
        SieuAmTim = 46,
        ChupTimPhoi = 47,
        SieuAmOBung = 48,
        GiaiPhauBenh = 49,
        SinhThiet = 50,
    }
    //07/06/2021 End by Hòa Issues 64961
    public enum LoaiPhieuTDCS
    {
        [Description("BẢNG THEO DÕI CHĂM SÓC NGƯỜI BỆNH")]
        BTDCSNB = 0,
        [Description("BẢNG THEO DÕI BỆNH NHÂN CAN THIỆP MẠCH VÀNH")]
        BTDBNCTMV = 1
    }
    public enum DanhSachPhieuKetQua
    {
        [Description("KẾT QUẢ THÔNG TIM ỐNG LỚN")]
        KQTTOL = 1,
        [Description("KẾT QUẢ ĐÓNG THÔNG LIÊN THẤT")]
        KQDTLP = 2,
        [Description("KẾT QUẢ ĐÓNG ỐNG ĐỘNG MẠCH")]
        KQDODM = 3,
        [Description("KẾT QUẢ BÍT THÔNG LIÊN NHĨ QUA DA")]
        KQBTLNQD = 4,
        [Description("KẾT QUẢ NONG VAN ĐỘNG MẠCH PHỔI")]
        KQVDMP = 5,
        [Description("KẾT QUẢ CHỤP ĐỘNG MẠCH CHI DƯỚI")]
        KQCDMCD = 6,
        [Description("KẾT QUẢ CAN THIỆP ĐỘNG MẠCH CHI DƯỚI")]
        KQCTDMCD = 7,
        [Description("KẾT QUẢ CHỤP ĐỘNG MẠCH THẬN")]
        KQCDMT = 8,
        [Description("KẾT QUẢ CAN THIỆP ĐỘNG MẠCH THẬN")]
        KQCTDMT = 9,
        [Description("KẾT QUẢ CHỤP ĐỘNG MẠCH VÀNH DSA")]
        KQCDMV = 10,
        [Description("KẾT QUẢ CHỤP ĐỘNG MẠCH CẢNH")]
        KQCDMC = 11,
        [Description("KẾT QUẢ CAN THIỆP ĐỘNG MẠCH CẢNH")]
        KQCTDMC = 12,
        [Description("THĂM DÒ ĐIỆN SINH LÝ VÀ ĐIỀU TRỊ RLNT")]
        TDDSL = 13,
        [Description("KẾT QUẢ ĐIỀU TRỊ CAN THIỆP ĐỘNG MẠCH VÀNH")]
        KQDTCTDVM = 14,
    }
    public enum LoaiCHePhamMau
    {
        [Description("Khối hồng cầu")]
        KHC = 1,
        [Description("Huyết tương tươi đông lạnh")]
        HTTDL = 2,
        [Description("Huyết tương đông lạnh")]
        HTDL = 3,
        [Description("Tủa lạnh giàu yếu tố VIII")]
        TLGYT = 4,
        [Description("Khối tiểu cầu poll")]
        KTCP = 5,
        [Description("Khối tiểu cầu máy")]
        KTCM = 6
    }
    public enum LoaiBenhAnEMR
    {
        [Description("Nội khoa")]
        [TableName("benhannoikhoa", "maquanly")]
        NoiKhoa = 1,
        [Description("Nhi khoa")]
        [TableName("benhannhikhoa", "maquanly")]
        NhiKhoa = 2,
        [Description("Truyền nhiễm")]
        [TableName("benhantruyennhiem", "maquanly")]
        TruyenNhiem = 3,
        [Description("Phụ khoa")]
        [TableName("benhanphukhoa", "maquanly")]
        PhuKhoa = 4,
        [Description("Sản khoa")]
        [TableName("benhansankhoa", "maquanly")]
        SanKhoa = 5,
        [Description("Sơ sinh")]
        [TableName("benhansosinh", "maquanly")]
        SoSinh = 6,
        [Description("Tâm thần")]
        [TableName("benhantamthan", "maquanly")]
        TamThan = 7,
        [Description("Da liễu")]
        [TableName("benhandalieu", "maquanly")]
        DaLieu = 8,
        [Description("Phục hồi chức năng")]
        [TableName("benhanphuchoichucnang", "maquanly")]
        PhucHoiChucNang = 9,
        [Description("Huyết học truyền máu")]
        [TableName("benhanhuyethoctruyenmau", "maquanly")]
        HuyetHocTruyenMau = 10,
        [Description("Ngoại khoa")]
        [TableName("benhanngoaikhoa", "maquanly")]
        NgoaiKhoa = 11,
        [Description("Bỏng")]
        [TableName("benhanbong", "maquanly")]
        Bong = 12,
        [Description("Ung bướu")]
        [TableName("benhanungbuou", "maquanly")]
        UngBuou = 13,
        [Description("Răng - Hàm - Mặt")]
        [TableName("benhanranghammat", "maquanly")]
        RangHamMat = 14,
        [Description("Tai - Mũi - Họng")]
        [TableName("benhantaimuihong", "maquanly")]
        TaiMuiHong = 15,
        [Description("Ngoại trú")]
        [TableName("benhanngoaitru", "maquanly")]
        NgoaiTru = 16,
        [Description("Ngoại trú Răng - Hàm - Mặt")]
        [TableName("benhanngoaitruranghammat", "maquanly")]
        NgoaiTruRangHamMat = 17,
        [Description("Ngoại trú Tai - Mũi - Họng")]
        [TableName("benhanngoaitrutaimuihong", "maquanly")]
        NgoaiTruTaiMuiHong = 18,
        [Description("Xã phường")]
        [TableName("benhanxaphuong", "maquanly")]
        XaPhuong = 19,
        [Description("Mắt lác")]
        [TableName("benhanmatlat", "maquanly")]
        MatLac = 20,
        [Description("Mắt trẻ em")]
        [TableName("benhanmattreem", "maquanly")]
        MatTreEm = 21,
        [Description("Mắt Glôcôm")]
        [TableName("benhanmatglocom", "maquanly")]
        MatGloCom = 22,
        [Description("Mắt - Đáy mắt")]
        [TableName("benhandaymat", "maquanly")]
        MatDayMat = 23,
        [Description("Mắt chấn thương")]
        [TableName("benhanmatchanthuong", "maquanly")]
        MatChanThuong = 24,
        [Description("Mắt bán phần trước")]
        [TableName("benhanmatbanphantruoc", "maquanly")]
        MatBanPhanTruoc = 25,
        [Description("Nội trú YHCT")]
        [TableName("benhannoitruyhct", "maquanly")]
        NoiTruYHCT = 26,
        [Description("Ngoại trú YHCT")]
        [TableName("benhanngoaitruyhct", "maquanly")]
        NgoaiTruYHCT = 27,
        [Description("Phá thai I")]
        PhaThaiI = 28,
        [Description("Phá thai II")]
        PhaThaiII = 29,
        [Description("Điều trị ban ngày")]
        [TableName("benhandieutribanngay", "maquanly")]
        DieuTriBanNgay = 30,
        [Description("Thận nhân tạo")]
        [TableName("benhanthannhantao", "maquanly")]
        ThanNhanTao = 31,
        [Description("Mắt")]
        [TableName("benhanmat", "maquanly")]
        Mat = 32,
        [Description("Tim")]
        [TableName("benhantim", "maquanly")]
        Tim = 33,
        [Description("YHCT-Phục hồi chức năng")]
        [TableName("benhanphuchoichucnangyhct", "maquanly")]
        PhucHoiChucNangYHCT = 34,
        [Description("Lưu cấp cứu")]
        [TableName("BenhAnLuuCapCuu", "maquanly")]
        LuuCapCuu = 35,
        [Description("CMU")]
        [TableName("BenhAnCMU", "maquanly")]
        CMU = 36,
        [Description("Phá thai III")]
        [TableName("BenhAnPhaThaiIII", "maquanly")]
        PhaThaiIII = 37,
        [Description("ngoại trú phòng khám")]
        [TableName("benhanngoaitruPK", "maquanly")]
        BANgoaTruPK = 38,
        [Description("Tay Chân Miệng")]
        [TableName("TayChanMieng", "maquanly")]
        TayChanMieng = 39,
        [Description("Ngoại trú mắt")]
        [TableName("benhanngoaitrumat", "maquanly")]
        NgoaiTruMat = 40,
        [Description("Ngoại Trú Phục Hồi Chức Năng")]
        [TableName("BenhAnNgoaiTruPHCN", "maquanly")]
        NgoaiTruPhucHoiChucNang = 41,
        [Description("Phục Hồi Chức Năng Nhi")]
        [TableName("BenhAnPHCNNhi", "maquanly")]
        PhucHoiChucNangNhi = 42,
        [Description("Da liễu trung ương")]
        [TableName("benhanDaLieuTW", "maquanly")]
        DaLieuTW = 43,
        [Description("Phục hồi chức năng")]
        [TableName("BenhAnPHCNII", "maquanly")]
        PHCNII = 44,
        [Description("Truyền nhiễm")]
        [TableName("benhantruyennhiemII", "maquanly")]
        TruyenNhiemII = 45,
        [Description("ĐIỀU TRỊ NGOẠI TRÚ BỆNH VẢY NẾN THÔNG THƯỜNG")]
        [TableName("BenhAnVayNenThongThuong", "maquanly")]
        NgoaiTru_VayNenThuongThuong = 46,
        [Description("NGOẠI TRÚ Á VẢY NẾN")]
        [TableName("BENHANNTAVAYNEN", "maquanly")]
        NgoaiTru_AVayNen = 47,
        [Description("BỆNH ÁN NGOẠI TRÚ TRUNG TÂM HỖ TRỢ SINH SẢN")]
        [TableName("BenhAnNgoaiTru_HTSS", "maquanly")]
        NgoaiTru_HoTroSinhSan = 48,
        [Description("ĐIỀU TRỊ NGOẠI TRÚ BỆNH VIÊM BÌ CƠ")]
        [TableName("BenhAnViemBiCo", "maquanly")]
        NgoaiTru_BenhAnViemBiCo = 49,
        [Description("ĐIỀU TRỊ NGOẠI TRÚ BỆNH LUPUS BAN ĐỎ HỆ THỐNG")]
        [TableName("BenhAnLupusBanDoHeThong", "maquanly")]
        NgoaiTru_BenhAnLupusBanDoHeThong = 50,
        [Description("NGOẠI TRÚ PEMPHIGOID")]
        [TableName("BENHANNTPEMPHIGOID", "maquanly")]
        NgoaiTru_PEMPHIGOID = 51,
        [Description("NGOẠI TRÚ BỆNH VẢY PHẤN ĐỎ NANG LÔNG")]
        [TableName("BenhAnVayPhanDoNangLong", "maquanly")]
        NgoaiTru_VayPhanDoNangLong = 52,
        [Description(" NGOẠI TRÚ LUPUS BAN ĐỎ MẠN TÍNH")]
        [TableName("BENHANDTNTLUPUSMANTINH", "maquanly")]
        NgoaiTru_LuPusBanDoManTinh = 53,
        [Description("ĐIỀU TRỊ NGOẠI TRÚ BỆNH VẢY NẾN THỂ MỦ")]
        [TableName("BenhAnVayNenTheMu", "maquanly")]
        NgoaiTru_VayNenTheMu = 54,
        [Description("ĐIỀU TRỊ NGOẠI TRÚ BỆNH DUHRING BROCQ")]
        [TableName("BenhAnNgoaiTruDuhringBrocq", "maquanly")]
        NgoaiTru_DuhringBrocq = 55,
        [Description("ĐÁI THÁO ĐƯỜNG")]
        [TableName("BenhAnDaiThaoDuong", "maquanly")]
        DaiThaoDuong = 56,
        [Description("ĐIỀU TRỊ NGOẠI TRÚ BỆNH UNG THƯ HẮC TỐ")]
        [TableName("BenhAnUngThuHacTo", "maquanly")]
        NgoaiTru_UngThuDaHacTo = 57,
        [Description("ĐIỀU TRỊ NGOẠI TRÚ BỆNH UNG THƯ KHÔNG HẮC TỐ")]
        [TableName("BenhAnUngThuKhongHacTo", "maquanly")]
        NgoaiTru_UngThuDaKhongHacTo = 58,
        [Description("ĐIỀU TRỊ NGOẠI TRÚ BỆNH PEMPHIGUS")]
        [TableName("BenhAnNgoaiTruPemphigus", "maquanly")]
        NgoaiTru_Pemphigus = 59,
        [Description("ĐIỀU TRỊ NGOẠI TRÚ BỆNH VẢY NẾN THỂ KHỚP")]
        [TableName("BenhAnVayNenTheKhop", "maquanly")]
        NgoaiTru_VayNenTheKhop = 60,
        [Description("ĐIỀU TRỊ NGOẠI TRÚ BỆNH HỘI CHỨNG TRÙNG LẮP")]
        [TableName("BenhAnHoiChungTrungLap", "maquanly")]
        NgoaiTru_HoiChungTrungLap = 61,
        [Description("QUẢN LÝ, THEO DÕI VÀ ĐIỀU TRỊ CÓ KIỂM SOÁT STENT ĐỘNG MẠCH VÀNH")]
        [TableName("BenhAnStentDongMachVanh", "maquanly")]
        StentDongMachVanh = 62,
        [Description("QUẢN LÝ, THEO DÕI VÀ ĐIỀU TRỊ CÓ KIỂM SOÁT THIẾU MÁU CƠ TIM CỤC BỘ")]
        [TableName("BenhAnThieuMauCoTimCucBo", "maquanly")]
        ThieuMauCoTimCucBo = 63,
        [Description(" ĐIỀU TRỊ VÀ THEO DÕI NGOẠI TRÚ BỆNH BASEDOW")]
        [TableName("BenhAnBenhBaseDow", "maquanly")]
        NgoaiTru_BenhBasedow = 64,
        [Description(" QUẢN LÝ, THEO DÕI VÀ ĐIỀU TRỊ BỆNH VIÊM GAN SIÊU VI B MẠN TÍNH")]
        [TableName("BenhAnViemGanBManTinh", "maquanly")]
        ViemGanBManTinh = 65,
        [Description(" QUẢN LÝ BỆNH PHỔI TẮC NGHẼN MẠN TÍNH")]
        [TableName("BenhAnPhoiTacNghenManTinh", "maquanly")]
        PhoiTacNghenManTinh = 66,
        [Description("QUẢN LÝ, THEO DÕI VÀ ĐIỀU TRỊ CÓ KIỂM SOÁT BỆNH TĂNG HUYẾT ÁP")]
        [TableName("BenhAnTangHuyetAp", "maquanly")]
        BenhTangHuyetAp = 67,
        [Description("BỆNH ÁN NGOẠI TRÚ HIV")]
        [TableName("BenhAnNgoaiTruHIV", "maquanly")]
        BenhAnNgoaiTruHIV = 68,

    };
    public enum GioiTinh {[Description("Nam")] Nam = 1, [Description("Nữ")] Nu, [Description("Không biết")] KhongBiet, [Description("Chưa xác định")] ChuaXacDinh };
    public enum DoiTuong {[Description("BHYT")] BHYT = 1, [Description("Thu phí")] ThuPhi, [Description("Miễn phí")] MienPhi, [Description("Khác")] Khac };
    public enum TrucTiepVao {[Description("Cấp cứu")] CapCuu = 1, [Description("Khoa khám bệnh")] KKB, [Description("Khoa điều trị")] KhoaDieuTri };
    public enum NoiGioiThieu {[Description("Cơ quan y tế")] CoQuanYTe = 1, [Description("Tự đến")] TuDen, [Description("Khác")] Khac };
    public enum ChuyenVien {[Description("Tuyến trên")] TuyenTren = 1, [Description("Tuyến Dưới")] TuyenDuoi, [Description("Khác")] Khac };
    public enum TinhTrangRaVien {[Description("Ra viện")] RaVien = 1, [Description("Xin về")] XinVe, [Description("Bỏ về")] BoVe, [Description(" Đưa về")] DuaVe, [Description("Hẹn khám")]HenKham };
    public enum KetQuaDieuTri {[Description("Khỏi")] Khoi = 1, [Description("Giảm đỡ")] GiamDo, [Description("Không thay đổi")] KhongThayDoi, [Description("Nặng hơn")] NangHon, [Description("Tử vong")] TuVong };
    public enum GiaiPhauBenh {[Description("Lành tính")] LanhTinh = 1, [Description("Nghi ngờ")] NghiNgo, [Description("Ác tính")] AcTinh };
    public enum LyDoTuVong {[Description("Do bệnh")] DoBenh = 1, [Description("Do tai biến điều trị")] DoTaiBienDieuTri, [Description("Khác")] Khac };
    public enum ThoiGianTuVong {[Description("Trong 24 giờ vào viện")] Trong24hVaoVien = 1, [Description("Sau 24h vào viện")] Sau24hvaoVien = 2, [Description("Sau 72h vào viện")] Sau72hvaoVien = 3 };

    public interface IHanhChinhBenhNhan
    {
        string BenhVien { get; set; }
        string MaYTe { get; set; }
        string MaBenhNhan { get; set; }
        [CodeHL7("54125-0", "54125-0", "Patient name", "371484003", "371484003", "Patient name")]
        [ResouceHL7("name")]
        string TenBenhNhan { get; set; }
        [CodeHL7("", "", "", "184099003", "184099003", "Date of birth")]
        [ResouceHL7("birthDate")]
        DateTime? NgaySinh { get; set; }
        string Tuoi { get; set; }
        [CodeHL7("", "", "", "184100006", "184100006", "Patient sex")]
        [ResouceHL7("gender")]
        GioiTinh GioiTinh { get; set; }
        string NgheNghiep { get; set; }
        string MaNgheNghiep { get; set; }
        string DanToc { get; set; }
        string MaDanhToc { get; set; }
        string NgoaiKieu { get; set; }
        string MaNgoaiKieu { get; set; }
        string SoNha { get; set; }
        string ThonPho { get; set; }
        string XaPhuong { get; set; }
        string MaXaPhuong { get; set; }
        string HuyenQuan { get; set; }
        string MaHuyenQuan { get; set; }
        string TinhThanhPho { get; set; }
        string MaTinhThanhPho { get; set; }
        string NoiLamViec { get; set; }
        DoiTuong DoiTuong { get; set; }
        DateTime? NgayHetHanBHYT { get; set; }
        string SoTheBHYT { get; set; }
        string HoTenDiaChiNguoiNha { get; set; }
        string SoDienThoaiNguoiNha { get; set; }
        string DienThoaiLienLac { get; set; }
    }

    [NhomThongTin(NhomThongTinBenhAn.HanhChinh)]
    public class HanhChinhBenhNhan : IHanhChinhBenhNhan
    {
        public string SoYTe { get; set; }
        public string BenhVien { get; set; }
        public string MaYTe { get; set; }
        public string MaBenhNhan { get; set; }
        [CodeHL7("", "", "", "371484003", "371484003", "Patient name")]
        [ResouceHL7("name")]
        public string TenBenhNhan { get; set; }
        [CodeHL7("", "", "", "184099003", "184099003", "Date of birth")]
        [ResouceHL7("birthDate")]
        public DateTime? NgaySinh { get; set; }
        public string Tuoi { get; set; }
        [CodeHL7("", "", "", "184100006", "184100006", "Patient sex")]
        [ResouceHL7("gender")]
        public GioiTinh GioiTinh { get; set; }
        public string NgheNghiep { get; set; }
        public string MaNgheNghiep { get; set; }
        public string MaNgheNghiepBo { get; set; }
        public string MaNgheNghiepMe { get; set; }
        public string DanToc { get; set; }
        public string MaDanhToc { get; set; }
        public string NgoaiKieu { get; set; }
        public string MaNgoaiKieu { get; set; }
        public string SoNha { get; set; }
        public string ThonPho { get; set; }
        public string XaPhuong { get; set; }
        public string MaXaPhuong { get; set; }
        public string HuyenQuan { get; set; }
        public string MaHuyenQuan { get; set; }
        public string TinhThanhPho { get; set; }
        public string MaTinhThanhPho { get; set; }
        public string NoiLamViec { get; set; }
        public DoiTuong DoiTuong { get; set; }
        public DateTime? NgayHetHanBHYT { get; set; }
        public string SoTheBHYT { get; set; }
        public DateTime? NgayDangKyBHYT { get; set; }
        public string TenNoiDangKyBHYT { get; set; }
        public string MaNoiDangKyBHYT { get; set; }
        public DateTime? NgayDuocHuong5Nam { get; set; }
        public string HoTenDiaChiNguoiNha { get; set; }
        public string SoDienThoaiNguoiNha { get; set; }
        public string HoVaTenBo { get; set; }
        public string HoVaTenMe { get; set; }
        public string NgheNghiepBo { get; set; }
        public string NgheNghiepMe { get; set; }
        public string TrinhDoVanHoaBo { get; set; }
        public string TrinhDoVanHoaMe { get; set; }
        public DateTime? NgaySinhMe { get; set; }
        public DateTime? NgaySinhBo { get; set; }
        public int? DeLanMay { get; set; }
        public string TienThaiPara { get; set; }
        public int? TienThaiParaID { get; set; }
        public string NhomMauMe { get; set; }
        public string TrinhDoVanHoa { get; set; }
        public string DienThoaiLienLac { get; set; }
        /// <summary>
        /// Them cho vien 108
        public string CapBac { get; set; }
        public string DonVi { get; set; }
        /// </summary>
        //#endregion
        public string CardCode { get; set; } // SoTheOneLink - TREATMENT.CARD_CODE
        // bactv add
        public bool[] CNKhuyetTatArray { get; } = new bool[] { false, false };
        public int CNKhuyetTat
        {
            get
            {
                return Array.IndexOf(CNKhuyetTatArray, true) + 1;
            }
            set
            {
                for (int i = 0; i < CNKhuyetTatArray.Length; i++)
                {
                    if (i == (value - 1)) CNKhuyetTatArray[i] = true;
                    else CNKhuyetTatArray[i] = false;
                }
            }
        }
        public string DangKhuyetTat { get; set; }
        public string MucDoKT { get; set; }
        // bactv add
        public string CMND { get; set; }
        public string NoiCap_CMND { get; set; }
        public DateTime? NgayCap_CMND { get; set; }
    }
    [NhomThongTin(NhomThongTinBenhAn.ToBia_QuanLyNguoiBenh)]
    public interface IQuanLyNguoiBenh
    {
        string MaKhoa { get; set; }
        string Khoa { get; set; }
        string Buong { get; set; }
        string Giuong { get; set; }
        string BacSiKhamBenh { get; set; }
        string SoNhapVien { get; set; }
        string MaSoBenhTat { get; set; }
        string KhoaRaVien { get; set; }
        string GiuongRaVien { get; set; }
        string SoLuuTru { get; set; }
        string MaBenhAn { get; set; }
        string MaBenhNhan { get; set; }
        DateTime? NgayVaoVien { get; set; }
        TrucTiepVao TrucTiepVao { get; set; }
        NoiGioiThieu NoiGioiThieu { get; set; }
        int VaoVienDoBenhNayLanThu { get; set; }
        int IDLoaiBenhAn { get; set; }
        string TenKhoaVao { get; set; }
        DateTime? NgayVaoKhoa { get; set; }       
        int? SoNgayDieuTriTaiKhoa { get; set; }
        List<LichSuChuyenKhoa> lstChuyenKhoaHis { get; set; }
        string ChuyenKhoa1 { get; set; }
        DateTime? NgayChuyenKhoa1 { get; set; }
        int? SoNgayDieuTriKhoa1 { get; set; }
        string ChuyenKhoa2 { get; set; }
        DateTime? NgayChuyenKhoa2 { get; set; }
        int? SoNgayDieuTriKhoa2 { get; set; }
        string ChuyenKhoa3 { get; set; }
        DateTime? NgayChuyenKhoa3 { get; set; }
        int? SoNgayDieuTriKhoa3 { get; set; }
        ChuyenVien? ChuyenVien { get; set; }
        string TenVienChuyenBenhNhanDen { get; set; }
        string MaVienChuyenBenhNhanDen { get; set; }
        DateTime? NgayRaVien { get; set; }
        TinhTrangRaVien? TinhTrangRaVien { get; set; }
        string TongSoNgayDieuTri1 { get; set; }
        string ChanDoan_NoiChuyenDen { get; set; }
        string MaCSKCB{ get; set; }
    }
   [NhomThongTin(NhomThongTinBenhAn.ToBia_ChanDoan)]
    public interface IChanDoan
    {
        string ChanDoan_NoiChuyenDen { get; set; }
        string MaICD_NoiChuyenDen { get; set; }
        string ChanDoan_KKB_CapCuu { get; set; }
        string MaICD_KKB_CapCuu { get; set; }
        string ChanDoan_KhiVaoKhoaDieuTri { get; set; }
        string MaICD_KhiVaoKhoaDieuTri { get; set; }
        string BenhChinh_RaVien { get; set; }
        string MaICD_BenhChinh_RaVien { get; set; }
        string BenhKemTheo_RaVien { get; set; }
        string MaICD_BenhKemTheo_RaVien { get; set; }
        bool TaiBien { get; set; }
        bool BienChung { get; set; }
        int? LyDoTaiBienBienChung { get; set; }
    }

    [NhomThongTin(NhomThongTinBenhAn.ToBia_TinhTrangRaVien)]
    public interface ITinhTrangRaVien
    {
        KetQuaDieuTri? KetQuaDieuTri { get; set; }
        GiaiPhauBenh? GiaiPhauBenh { get; set; }
        DateTime? NgayTuVong { get; set; }
        LyDoTuVong? LyDoTuVong { get; set; }
        ThoiGianTuVong? ThoiGianTuVong { get; set; }
        string NguyenNhanChinhTuVong { get; set; }
        string MaICD_NguyenNhanChinhTuVong { get; set; }
        bool KhamNghiemTuThi { get; set; }
        string ChanDoanGiaiPhauTuThi { get; set; }
        string MaICD_ChanDoanGiaiPhauTuThi { get; set; }
        string MaGiamDocBenhVien { get; set; }
        string MaTruongKhoa { get; set; }
        string TenGiamDocBenhVien { get; set; }
        string TenTruongKhoa { get; set; }
    }
    [Serializable]
    [JsonObject]
    public class ThongTinDieuTri: IQuanLyNguoiBenh, IChanDoan, ITinhTrangRaVien
    {
        public ThongTinDieuTri()
        {
            PhauThuatThuThuats = new List<PhauThuatThuThuats>();
            ThuocVatTus = new List<ThuocVatTu>();
            DsThuocDangSuDung = new List<DsThuocDangSuDung>();
        }
        public string MaKhoa { get; set; }  
        public string Khoa { get; set; }
        public string Buong { get; set; }
        public string Giuong { get; set; }   
        public string BacSiKhamBenh { get; set; }
        public string SoNhapVien { get; set; }
        public string MaSoBenhTat { get; set; }
        public string KhoaRaVien { get; set; }
        public string GiuongRaVien { get; set; }
        public string SoLuuTru { get; set; }
        public string SoNgoaiTru { get; set; }
        public decimal MaQuanLy { get; set; }
        public string MaBenhAn { get; set; }  
        public string MaBenhNhan { get; set; }
        public DateTime? NgayVaoVien { get; set; }
        public TrucTiepVao TrucTiepVao { get; set; }
        public NoiGioiThieu NoiGioiThieu { get; set; }
        public int VaoVienDoBenhNayLanThu { get; set; }
        public int IDLoaiBenhAn { get; set; }
        public string TenKhoaVao { get; set; }
        public DateTime? NgayVaoKhoa { get; set; }
        public int? SoNgayDieuTriTaiKhoa { get; set; }
        public List<LichSuChuyenKhoa> lstChuyenKhoaHis { get; set; }
        public string ChuyenKhoa1 { get; set; }
        public DateTime? NgayChuyenKhoa1 { get; set; }
        public int? SoNgayDieuTriKhoa1 { get; set; }
        public string ChuyenKhoa2 { get; set; }
        public DateTime? NgayChuyenKhoa2 { get; set; }
        public int? SoNgayDieuTriKhoa2 { get; set; }
        public string ChuyenKhoa3 { get; set; }
        public DateTime? NgayChuyenKhoa3 { get; set; }
        public int? SoNgayDieuTriKhoa3 { get; set; }
        public ChuyenVien? ChuyenVien { get; set; }
        public string TenVienChuyenBenhNhanDen { get; set; }
        public string MaVienChuyenBenhNhanDen { get; set; }
        public DateTime? NgayRaVien { get; set; }
        public TinhTrangRaVien? TinhTrangRaVien { get; set; }
        public string TongSoNgayDieuTri1 { get; set; }
        public string TongSoNgayDieuTri2 { get; set; }
        public string ChanDoan_NoiChuyenDen { get; set; }
        public string MaICD_NoiChuyenDen { get; set; }
        public string ChanDoan_YHCT { get; set; }
        public string ChanDoan_KKB_CapCuu { get; set; }
        public string MaICD_KKB_CapCuu { get; set; }
        public string ChanDoan_KhiVaoKhoaDieuTri { get; set; }
        public string MaICD_KhiVaoKhoaDieuTri { get; set; }
        public string BenhChinh_RaVien { get; set; }
        public string MaICD_BenhChinh_RaVien { get; set; }
        public string BenhKemTheo_RaVien { get; set; }
        public string MaICD_BenhKemTheo_RaVien { get; set; }

        //http://redmine.vietsens.vn:8080/redmine/issues/39471
        public string BenhKemTheo_RaVien1 { get; set; }
        public string MaICD_BenhKemTheo_RaVien1 { get; set; }
        public string BenhKemTheo_RaVien2 { get; set; }
        public string MaICD_BenhKemTheo_RaVien2 { get; set; }
        public string ChanDoanCuaNoiGioiThieu { get; set; }
        public bool ThuThuat { get; set; }
        public bool PhauThuat { get; set; }
        public bool TaiBien { get; set; }
        public bool BienChung { get; set; }
        public KetQuaDieuTri? KetQuaDieuTri { get; set; }
        public GiaiPhauBenh? GiaiPhauBenh { get; set; }
        public DateTime? NgayTuVong { get; set; }
        public LyDoTuVong? LyDoTuVong { get; set; }
        public ThoiGianTuVong? ThoiGianTuVong { get; set; }
        public string NguyenNhanChinhTuVong { get; set; }
        public string MaICD_NguyenNhanChinhTuVong { get; set; }
        public bool KhamNghiemTuThi { get; set; }
        public string ChanDoanGiaiPhauTuThi { get; set; }
        public string MaICD_ChanDoanGiaiPhauTuThi { get; set; }
        public string MaGiamDocBenhVien { get; set; }
        public DateTime? NgayThangNamTrangBia { get; set; }
        public string MaTruongKhoa { get; set; }
        public DauSinhTon DauSinhTon { get; set; }
        public HoSo HoSo { get; set; }
        public int YHCT_KetQuaDieutTriID { get; set; }
        public string YHCT_ChuanDoanaRaVien { get; set; }
        public string YHCT_NguyenNhan { get; set; }
        public string YHCT_TangPhu { get; set; }
        public string YHCT_BatCuong { get; set; }
        public string YHCT_KinhMach { get; set; }
        public int YHCT_BatCuongID { get; set; }
        public int YHCT_TangPhuID { get; set; }
        public int YHCT_KinhMachID { get; set; }
        public int YHCT_DinhViBenhID { get; set; }
        public int YHCT_NguyenNhanID { get; set; }
        public string YHCT_BenhDanh { get; set; }
        public string YHCT_NoiDieuTri { get; set; }
        public string YHHD_NoiDieuTri { get; set; }
        public string YHHD_BenhChinh { get; set; }
        public string YHHD_BenhKemTheo { get; set; }
        public string ChanDoanKKBYHCT { get; set; }
        public string ChanDoanKKBYHHD { get; set; }
        public string ChanDoanNoiGioiThieu { get; set; }
        public string MaTruongPhongKHTH { get; set; }
        public string MaThayThuocDieuTri { get; set; }
        public string MaThayThuocKhamBenh { get; set; }
        public int? TongSoNgayDieuTriSauPT { get; set; }
        public int? TongSoLanPhauThuat { get; set; }
        public string NguyenNhan_BenhChinh_RaVien { get; set; }
        public string MaICD_NguyenNhan_BenhChinh_RV { get; set; }
        public string ChanDoanTruocPhauThuat { get; set; }
        public string ChanDoanSauPhauThuat { get; set; }
        public string MaICD_ChanDoanTruocPhauThuat { get; set; }
        public string MaICD_ChanDoanSauPhauThuat { get; set; }
        public string LucVaoDe { get; set; }
        public DateTime? NgayDe { get; set; }
        public string NgoiThai { get; set; }
        public string CachThucDe { get; set; }
        public bool KiemSoatTuCung { get; set; }
        public string KiemSoatTuCung_Text { get; set; }
        public string PhuongPhapPhauThuat { get; set; }
        public int? LyDoTaiBienBienChung { get; set; }
        public bool TinhHinhPhauThuat { get; set; }
        public int TinhHinhPTSanKhoa { get; set; }
        public int TreSoSinh_LoaiThai { get; set; } = 2;
        public int TreSoSinh_GioiTinh { get; set; } = 2;
        public int TreSoSinh_DiTat { get; set; } = 2;
        public string TreSoSinh_DiTat_Text { get; set; }
        public int? TreSoSinh_CanNang { get; set; }
        public int TreSoSinh_SongChet { get; set; } = 2;
        public string ChanDoan_SoBo { get; set; }
        public string MaICD_SoBo { get; set; }
        public string CachThucPttt { get; set; }
        public string PhuongPhapVoCam { get; set; }
        public string PhauThuatVien { get; set; }
        public string PhauThuatVien2 { get; set; }
        public string BacSiGayMe { get; set; }
        public string PhuMe { get; set; }
        public string sYHCT_BatCuongID { get; set; }
        public string sYHCT_TangPhuID { get; set; }
        public string sYHCT_KinhMachID { get; set; }
        public string sYHCT_DinhViBenhID { get; set; }
        public string sYHCT_NguyenNhanID { get; set; }
        public List<PhauThuatThuThuats> PhauThuatThuThuats { get; set; }
        public List<ThuocVatTu> ThuocVatTus { get; set; }
        public string TenGiuong { get; set; }
        public string MaCSKCB { get; set; }
        public List<DsThuocDangSuDung> DsThuocDangSuDung { get; set; }
        //bactv thêm mã điều trị tương dương MedicalRecordID
        public decimal? MaDieuTri { get; set; }
        [JsonProperty("NgayBatDauDieuTri")]
        public DateTime? NgayBDDieuTri { get; set; }
        //bactv add
        public string LyDoVaoVien { get; set; }
        //linh: thêm cho con sanbox, sanbox: cho các nơi (cskcb bất kì) đẩy dữ liệu về, nên ko đồng bộ được danh mục, lúc gởi lên phải gởi 1 cặp: mã + tên
        public string TenGiamDocBenhVien { get; set; }
        public string TenTruongKhoa { get; set; }
    }

    [Serializable]
    public class ChanDoan
    {
        public int icd10id { get; set; }
        public string icd10code { get; set; }
        public string icd10name { get; set; }
        public string icd10name_en { get; set; }
        public string icd10name_thuonggoi { get; set; }
        public int icd10chapter { get; set; }
        public int icd10group { get; set; }
        public int icd10type { get; set; }
        public int version { get; set; }
        public int thanhtoanngoaidinhsuat { get; set; }
        public int sync_flag { get; set; }
        public int update_flag { get; set; }
        public int icd10disable { get; set; }
        public int isremove { get; set; }
        public int lastuserupdated { get; set; }
        public int lasttimeupdated { get; set; }
        public int botinhngaygiuongcongkham { get; set; }
        public string danhsachmadichvu { get; set; }
        public string danhsachmathuoc { get; set; }
        public string danhsachmahoatchat { get; set; }
        public string icd10name_yhct { get; set; }
    }
    [Serializable]
    public class PhuongPhapPTTT
    {
        public int pttt_phuongphapdbid { get; set; }
        public string pttt_phuongphapcode { get; set; }
        public string pttt_phuongphapname { get; set; }
        public int pttt_hangid { get; set; }
        public int version { get; set; }
        public int sync_flag { get; set; }
        public int update_flag { get; set; }
    }
    [Serializable]
    public class BedInfo
    {
        public string bedcode { get; set; }
        public string bedname { get; set; }
        public BedInfo Clone()
        {
            BedInfo other = (BedInfo)this.MemberwiseClone();
            return other;
        }
    }
    public class CachThucPTTT
    {
        public string servicepricecode { get; set; }
        public string servicepricename { get; set; }
    }
}
class ChuyenKhoa
{
    public string TenKhoa { get; set; }
    public DateTime NgayChuyen { get; set; }
    public int SoNgayDieuTri { get; set; }
}

public class PhauThuatThuThuats
{
    public PhauThuatThuThuats() { EkipMos = new List<EkipMo>(); }
    public DateTime NgayPTTT { get; set; }
    public string MaPhuongPhapPTTT { get; set; }
    public string PhuongPhapPTTT { get; set; }
    public PhPhapVoCam PhuongPhapVoCam { get; set; }
    public DateTime? NgayKetThucPTTT { get; set; }
    public string MaChanDoanChinh { get; set; }
    public string ChanDoanChinh { get; set; }
    public string MaChanDoanPhu { get; set; }
    public string ChanDoanPhu { get; set; }
    public string MaChanDoanTruocPTTT { get; set; }
    public string ChanDoanTruocPTTT { get; set; }
    public string MaChanDoanSauPTTT { get; set; }
    public string ChanDoanSauPTTT { get; set; }
    public string MaCachThucPTTT { get; set; }
    public string CachThucPTTT { get; set; }
    public string MaNgayGiuongPTTT { get; set; }
    public string NgayGiuongPTTT { get; set; }
    public eNhomMau NhomMau { get; set; }
    public eRH RH { get; set; }
    public eTinhHinhPTTT TinhHinhPTTT { get; set; }
    public eTaiBienPTTT TaiBienPTTT { get; set; }
    public eTuVongTrongPTTT TuVongTrongPTTT { get; set; }
    public string MoTa { get; set; }
    public string DanLuu { get; set; }
    public string Bac { get; set; }
    public DateTime? NgayRutChi { get; set; }
    public DateTime? NgayCatChi { get; set; }
    public string Khac { get; set; }
    public eLoaiPTTT Loai { get; set; }
    public List<EkipMo> EkipMos { get; set; }

    public class EkipMo
    {
        public EMR_MAIN.ChucNangEKipMo ChucVuEkip { get; set; }
        public string MaNhanVien { get; set; }
        public string HoTenNhanVien { get; set; }
    }

    public enum PhPhapVoCam
    {
        [Description("Gây mê tĩnh mạch")]
        GayMeTinhMach = 1,
        [Description("Gây mê nội khí quản")]
        GayMeNoiKhiQuan,
        [Description("Gây mê tại chỗ")]
        GayMeTaiCho,
        [Description("Tiền mê + gây mê tại chỗ")]
        TienMe,
        [Description("Gây tê tủy sống")]
        GayMeTuySong,
        [Description("Gây tê")]
        GayTe,
        [Description("Gây tê ngoài màng cứng")]
        GayTeNgoaiMangCung,
        [Description("Gây tê đám rối thần kinh")]
        GayTeDamRoiThanKinh,
        [Description("Gây tê codan")]
        GayTeCodan,
        [Description("Gây tê nhãn cầu")]
        GayTeNhanCau,
        [Description("Gây tê cạnh sống")]
        GayTeCanhSong,
        [Description("Khác")]
        Khac = 99
    }

    public enum eNhomMau
    {
        [Description("A")]
        A = 1,
        [Description("AB")]
        AB,
        [Description("B")]
        B,
        [Description("O")]
        O,
    }
    public enum eRH
    {
        [Description("+")]
        Cong = 1,
        [Description("-")]
        Tru,
    }
    public enum eTinhHinhPTTT
    {
        [Description("Cấp cứu")]
        CapCuu = 1,
        [Description("Chủ động")]
        ChuDong,
    }
    public enum eTaiBienPTTT
    {
        [Description("Không")]
        Khong = 1,
        [Description("Do phẫu thuật")]
        PhauThuat,
        [Description("Do thu thuật")]
        ThuThuat,
        [Description("Do gây mê")]
        GayMe,
        [Description("Khác")]
        Khac = 99,
    }
    public enum eTuVongTrongPTTT
    {
        [Description("Không")]
        Khong = 1,
        [Description("Trên bàn mổ")]
        TrenBanMo,
        [Description("Trong 24 giờ")]
        Trong24Gio,
        [Description("Sau 24 giờ")]
        Sau24Gio,
    }
    public enum eLoaiPTTT
    {

        [Description("Phẫu thuật đặc biệt")]
        PTDacBiet = 1,
        [Description("Phẫu thuật loại 1")]
        PTLoai1,
        [Description("Phẫu thuật loại 2")]
        PTLoai2,
        [Description("Phẫu thuật loại 3")]
        PTLoai3,
        [Description("Thủ thuật đặc biệt")]
        TTDacBiet,
        [Description("Thủ thuật loại 1")]
        TTLoai1,
        [Description("Thủ thuật loại 2")]
        TTLoai2,
        [Description("Thủ thuật loại 3")]
        TTLoai3,
    }

}

public class ThuocVatTu
{
    public bool IsChecked { get; set; }
    public string MaThuocVatTu { get; set; }
    public string TenThuocVatTu { get; set; }
    public string DonVi { get; set; }
    public decimal SoLuong { get; set; }
    public string HangSanXuat { get; set; }
    public string GhiChu { get; set; }
    public ThuocVatTu Clone()
    {
        ThuocVatTu other = (ThuocVatTu)this.MemberwiseClone();
        return other;
    }
    public override string ToString()
    {
        return MaThuocVatTu + ":" + TenThuocVatTu;
    }
}
public class ThuocKhangSinh
{
    public string MaKhangSinh { get; set; }
    public string TenKhangSinh { get; set; }
    public decimal SoLuong { get; set; }
    public string DonVi { get; set; }
    public string HuongDanSuDung { get; set; }
}
public class ChiSoXetNghiemADO
{
    public string TestIndexCode { get; set; }
    public string TestIndexName { get; set; }
    public string Value { get; set; }
    public string Description { get; set; }
    public bool IsBloodABO { get; set; }
    public bool IsBloodRH { get; set; }
    public bool IsAbsAg { get; set; }
    public bool IsHCV { get; set; }
    public bool IsHIV { get; set; }
    public DateTime? ExecuteTime { get; set; }
}
public class ThongTinCheDoAn
{
    public string MaCheDoAn { get; set; }
    public string DonGia { get; set; }
}
public class RoomInfo
{
   public long? IdPhong { get; set; }
   public long?  IdLoaiPhong { get; set; }
   public string MaPhong { get; set; }
   public string MaLoaiPhong { get; set; }
}