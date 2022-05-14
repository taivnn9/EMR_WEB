
using EMR_MAIN.ChucNangKhac;
using MDB;
using PMS.Access;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows;

namespace EMR_MAIN.DATABASE
{
    public enum DanhMucPhieu
    {
        [Description("Tờ bìa")]
        TOBIA=1,//", TenPhieu = "Tờ bìa", LoaiPhieu = 1, TrangThai = 1, DatabaseName = "" });
        [Description("Hành chính")]
        HANHCHINH=2,//", TenPhieu = "Hành chính", LoaiPhieu = 1, TrangThai = 1, DatabaseName = "" });
        [Description("Phiếu khám bệnh vào viện")]
        KBVAOVIEN=3,//", TenPhieu = "Phiếu khám bệnh vào viện", LoaiPhieu = 1, TrangThai = 1, DatabaseName = "" });
        [Description("Phiếu chỉ định")]
        CHIDINH4=4,//", TenPhieu = "Phiếu chỉ định", LoaiPhieu = 1, TrangThai = 1, DatabaseName = "" });
        [Description("Phiếu kết quả")]
        KETQUA=5,//", TenPhieu = "Phiếu kết quả", LoaiPhieu = 1, TrangThai = 1, DatabaseName = "" });
        [Description("Phiếu chăm sóc")]
        CS=6,//", TenPhieu = "Phiếu chăm sóc", TrangThai = 1, DatabaseName = "THONGTINCHAMSOC" });
        [Description("Phiếu truyền máu")]
        TM=7,//", TenPhieu = "Phiếu truyền máu", TrangThai = 1, DatabaseName = "THONGTINTRUYENMAU", NguoiTao = "", NguoiSua = "" });
        [Description("Phiếu truyền dịch")]
        TD=8,//", TenPhieu = "Phiếu truyền dịch", TrangThai = 1, DatabaseName = "THONGTINTRUYENDICH", NgayTao = "THOIGIANTAOPHIEU", NgaySua = "", NguoiTao = "", NguoiSua = "" });
        [Description("Phiếu khám gây mê trước mổ")]
        KGMTM=9,//", TenPhieu = "Phiếu khám gây mê trước mổ", TrangThai = 1, DatabaseName = "PHIEUKHAMGAYMETRUOCMO", NgayTao = "THOIGIANTAO", NgaySua = "THOIGIANSUA", NguoiTao = "", NguoiSua = "" });
        [Description("Bảng kiểm an toàn phẫu thuật")]
        BKATPT=10,//", TenPhieu = "", TrangThai = 1, DatabaseName = "BANGKIEMANTOANPHAUTHUAT", NgayTao = "THOIGIANTAOBANGKIEM", NgaySua = "", NguoiTao = "", NguoiSua = "" });
        [Description("Sơ kết bệnh án duyệt mổ")]
        SKBADM = 11,//", TenPhieu = "Sơ kết bệnh án duyệt mổ", TrangThai = 1, DatabaseName = "SOKETBENHANDUYETMO", NgayTao = "THOIGIANTAO", NgaySua = "THOIGIANSUA", NguoiTao = "", NguoiSua = "" });
        [Description("Phiếu chuẩn bị trước phẫu thuật")]
        CBTPT=12,//", TenPhieu = "Phiếu chuẩn bị trước phẫu thuật", TrangThai = 1, DatabaseName = "CHUANBITRUOCMO", NguoiTao = "", NguoiSua = "" });
        [Description("Phiếu sơ kết 15 ngày điều trị")]
        SK15NDT=13,//", TenPhieu = "", TrangThai = 1, DatabaseName = "PHIEUSOKET15NGAYDIEUTRI", NgayTao = "THOIGIANTAO", NgaySua = "", NguoiTao = "", NguoiSua = "" });
        [Description("Giấy cam đoan chấp nhận test thử kháng sinh")]
        CDKS =14,//", TenPhieu = "", TrangThai = 1, DatabaseName = "PHIEUCAMDOANKHANGSINH", NgayTao = "", NgaySua = "", NguoiTao = "", NguoiSua = "" });
        [Description("Phiếu sàng lọc, đánh giá dinh dưỡng người bệnh khi nhập viện")]
        SLDGDD =15,//", TenPhieu = ".", TrangThai = 1, DatabaseName = "PHIEUDANHGIADINHDUONG", NgayTao = "THOIGIANTAO", NgaySua = "THOIGIANSUA", NguoiTao = "USERCREATE", NguoiSua = "USERUPDATE" });
        [Description("Biên bản kiểm điểm bệnh nhân nặng xin về")]
        KDBNNXV=16,//", TenPhieu = "", TrangThai = 1, DatabaseName = "BENHNHANNANGXINVE", NgayTao = "NGAY_TAO", NgaySua = "NGAY_SUA", NguoiTao = "NGUOI_TAO", NguoiSua = "NGUOI_SUA" });
        [Description("Biên bản kiểm điểm bệnh nhân tử vong")]
        KDBNTV=17,//", TenPhieu = "", TrangThai = 1, DatabaseName = "BENHNHANTUVONG", NgayTao = "NGAY_TAO", NgaySua = "NGAY_SUA", NguoiTao = "NGUOI_TAO", NguoiSua = "NGUOI_SUA" });
        [Description("Biên bản kiểm điểm bệnh nhân bỏ viện")]
        KDBNBV =18,//", TenPhieu = "", TrangThai = 1, DatabaseName = "BENHNHANBOVE", NgayTao = "NGAY_TAO", NgaySua = "NGAY_SUA", NguoiTao = "NGUOI_TAO", NguoiSua = "NGUOI_SUA" });
        [Description("Biên bản xác nhận bệnh nhân cấp cứu")]
        KDBNCC=19,//", TenPhieu = "", TrangThai = 1, DatabaseName = "BENHNHANCAPCUU", NgayTao = "NGAY_TAO", NgaySua = "NGAY_SUA", NguoiTao = "NGUOI_TAO", NguoiSua = "NGUOI_SUA" });
        [Description("Biên bản cam kết điều trị truyền máu")]
        CKDTTM =20,//", TenPhieu = "", TrangThai = 1, DatabaseName = "CAMKETDIEUTRITRUYENMAU", NgayTao = "NGAY_TAO", NgaySua = "NGAY_SUA", NguoiTao = "NGUOI_TAO", NguoiSua = "NGUOI_SUA" });
        [Description("Biên bản hội chẩn người bệnh sử dụng thuốc có dấu sao (*)")]
        HCTDS=21,//", TenPhieu = "", TrangThai = 1, DatabaseName = "BIENBANHOICHANTHUOCCODAUSAO" });
        [Description("Đánh giá dinh dưỡng người bệnh nhập viện (mẫu chung)")]
        DGDDC =22,//", TenPhieu = "", TrangThai = 1, DatabaseName = "PHIEUDANHGIADINHDUONGCHUNG" });
        [Description("Đánh giá dinh dưỡng dành cho phụ nữ mang thai")]
        DD_PNMT = 23,//", TenPhieu = "", TrangThai = 1, DatabaseName = "DINHDUONG_PNMT", NguoiSua = "" });
        [Description("Đánh giá dinh dưỡng dành cho trẻ em")]
        DD_TE=24,//", TenPhieu = "", TrangThai = 1, DatabaseName = "DINHDUONG_TE", NguoiSua = "" });
        [Description("Phiếu xác nhận bệnh nhân thay băng đa vết thương")]
        TBDVT =25,//", TenPhieu = "", TrangThai = 1, DatabaseName = "THAYBANGDAVETTHUONG_BENHNHAN", NgayTao = "NGAY_TAO", NgaySua = "NGAY_SUA", NguoiTao = "NGUOI_TAO", NguoiSua = "NGUOI_SUA" });
        [Description("Phiếu Sơ Sinh")]
        SS =26,//", TenPhieu = "", TrangThai = 1, DatabaseName = "PHIEUSOSINH", NgayTao = "", NgaySua = "", NguoiTao = "", NguoiSua = "" });
        [Description("Phiếu kiểm soát gạc trong ca mổ")]
        KSGTCM =27,//", TenPhieu = "", TrangThai = 1, DatabaseName = "phieukiemsoatgac", NgayTao = "THOIGIANTAO", NgaySua = "THOIGIANSUA", NguoiTao = "", NguoiSua = "" });
        [Description("Phiếu xác nhận bệnh nhân thay băng đa vết thương trên 30 cm")]
        TBDVT30CM = 28,//", TenPhieu = "", TrangThai = 1, DatabaseName = "thaybangdavetthuong30cm_bn", NgayTao = "NGAY_TAO", NgaySua = "NGAY_SUA", NguoiTao = "NGUOI_TAO", NguoiSua = "NGUOI_SUA" }); //Khong dung ma quan ly
        [Description("Bảng kiểm Johns Hopking")]
        BKJH=29,//", TenPhieu = "", TrangThai = 1, DatabaseName = "BangKiemJohnsHopking" });
        [Description("Phiếu gây mê hồi sức")]
        GMHS =30,//", TenPhieu = "", TrangThai = 1, DatabaseName = "phieugaymehoisuc", NgayTao = "NGAY_TAO", NgaySua = "NGAY_SUA", NguoiTao = "NGUOI_TAO", NguoiSua = "NGUOI_SUA" });
        [Description("Phiếu thủ thuật")]
        TT =31,//", TenPhieu = "", TrangThai = 1, DatabaseName = "PhauThuatThuThuat" });
        [Description("Phiếu phẫu thuật thủ thuật")]
        PTTT =32,//", TenPhieu = "", TrangThai = 1, DatabaseName = "PhauThuatThuThuat" });
        [Description("Phiếu chuyển dạ")]
        CD =33,//", TenPhieu = "", TrangThai = 1, DatabaseName = "BIEUDOCHUYENDA", NgayTao = "NGAY_TAO", NgaySua = "NGAY_SUA", NguoiTao = "NGUOI_TAO", NguoiSua = "NGUOI_SUA" });
        [Description("Biên bản tử vong ngoài viện")]
        BBTVNV =34,//", TenPhieu = "", TrangThai = 1, DatabaseName = "BienBanTuVongNgoaiVien" });
        [Description("Phiếu đánh giá dinh dưỡng")]
        DD =35,//", TenPhieu = "", TrangThai = 1, DatabaseName = "DanhGiaDinhDuong" });
        [Description("Phiếu phẫu thuật thể thủy tinh")]
        PPTT3 =36,//", TenPhieu = "", TrangThai = 1, DatabaseName = "PHAUTHUATTHETHUYTINH" });
        [Description("Phiếu kiểm soát trước khi chuyển khoa")]
        KSTCK =37,//", TenPhieu = ", TrangThai = 1, DatabaseName = "KIEMSOATNGUOIBENHTRUOC" });
        [Description("Bảng kiểm hồ sơ bệnh án")]
        BKHSBA =38,//", TenPhieu = "", TrangThai = 1, DatabaseName = "BANGKIEMHOSOBENHAN" });
        [Description("Kiểm soát bệnh nhân tại phòng mổ")]
        KSBN =39,//", TenPhieu = "", TrangThai = 1, DatabaseName = "KiemSoatBenhNhanTaiPhongMo", NgayTao = "", NgaySua = "", NguoiTao = "", NguoiSua = "" });
        [Description("Trích biên bản hội chẩn")]
        TBBHC =40,//", TenPhieu = "", TrangThai = 1, DatabaseName = "TRICHBIENBANHOICHAN" });
        [Description("Yêu cầu sử dụng kháng sinh")]
        YCSDKS =41,//", TenPhieu = "", TrangThai = 1, DatabaseName = "YeuCauSuDungKhangSinh", NgayTao = "", NgaySua = "", NguoiTao = "", NguoiSua = "" });
        [Description("Biên bản hội chẩn")]
        BBHC =42,//", TenPhieu = "", TrangThai = 1, DatabaseName = "BIENBANHOICHAN" });
        [Description("Biên bản bàn giao trẻ sơ sinh")]
        BBBGTSS =43,//", TenPhieu = "", TrangThai = 1, DatabaseName = "BIENBANBANGIAOTRESOSINH" });
        [Description("Phiếu theo dõi sơ sinh")]
        TDSS =44,//", TenPhieu = "", TrangThai = 1, DatabaseName = "PHIEUTHEODOISOSINH", NgayTao = "", NgaySua = "", NguoiTao = "", NguoiSua = "" });
        [Description("Hồ sơ chăm sóc bệnh nhân của điều dưỡng")]
        CSBNDD =45,//", TenPhieu = "", TrangThai = 1, DatabaseName = "CHAMSOCNGUOIBENHCUADIEUDUONG" });
        [Description("Phiếu thuốc vật tư tiêu hao trong mổ")]
        TVTTM =46,//", TenPhieu = "", TrangThai = 1, DatabaseName = "THUOCVATTUTIEUHAOTRONGMO" });
        [Description("Hướng dẫn khai thác tiền sử dị ứng")]
        HDKTTSDU =47,//", TenPhieu = "", TrangThai = 1, DatabaseName = "HuongDanKhaiThacTienSuDiUng", NguoiTao = "", NguoiSua = "" });
        [Description("Phiếu phẫu thuật mộng")]
        PTM=48,//", TenPhieu = "", TrangThai = 1, DatabaseName = "PHAUTHUATMONG" });
        [Description("Phiếu phẫu thuật mổ quặm")]
        PTMQ =49,//", TenPhieu = "", TrangThai = 1, DatabaseName = "PHAUTHUATQUAM" });
        [Description("Phiếu điều trị phục hồi chức năng")]
        PDTPHCN =50,//", TenPhieu = "", TrangThai = 1, DatabaseName = "PHIEUDIEUTRIPHUCHOICHUCNANG", NgayTao = "", NgaySua = "", NguoiTao = "", NguoiSua = "" });
        [Description("Phiếu lọc máu")]
        PLM =51,//", TenPhieu = "", TrangThai = 1, DatabaseName = "PHIEULOCMAU", NgayTao = "", NgaySua = "", NguoiTao = "", NguoiSua = "" });
        [Description("Bảng kiểm trước tiêm chủng cho trẻ sơ sinh")]
        BKTCTSS =52,//", TenPhieu = "", TrangThai = 1, DatabaseName = "BangKiemTruocTiemChung", NgayTao = "", NgaySua = "", NguoiTao = "", NguoiSua = "" });
        [Description("Phiếu theo dõi mổ đẻ chỉ huy")]
        PTDMDCH =53,//", TenPhieu = "", TrangThai = 1, DatabaseName = "PhieuTheoDoiMoDeChiHuy", NgayTao = "", NgaySua = "", NguoiTao = "", NguoiSua = "" });
        [Description("Phiếu kết quả nghiệm pháp dung nạp Glucose")]
        PKQNPDNG =54,// TenPhieu = "", TrangThai = 1, DatabaseName = "PhieuKetQuaNghiemPhap", NgayTao = "", NgaySua = "", NguoiTao = "", NguoiSua = "" });
        [Description("Phiếu đề nghị khám bệnh tự nguyện")]
        DKKBTN=55,//", TenPhieu = "", TrangThai = 1, DatabaseName = "PhieuKhamBenhTuNguyen" });
        [Description("Giấy đề nghị nạo phá thai")]
        GDNNPT =56,//", TenPhieu = "", TrangThai = 1, DatabaseName = "GiayDeNghiNaoPhaThai", NguoiTao = "", NguoiSua = "" });
        [Description("Theo dõi chăm sóc điều trị HIV")]
        TDCSDTHIV = 57,//", TenPhieu = "", TrangThai = 1, DatabaseName = "TheoDoiChamSocDieuTriHIV" });
        [Description("Tờ điều trị phá thai hút chân không")]
        PTHCK=58,//", TenPhieu = "", TrangThai = 1, DatabaseName = "ToPhaThaiHutChanKhong" });
        [Description("Phiếu tự nguyện sử dụng giường chất lượng cao")]
        PTNSDGCLC =59,//", TenPhieu = "", TrangThai = 1, DatabaseName = "PhieuTuNguyenSuDungGiuongCLC", NgayTao = "", NgaySua = "", NguoiTao = "", NguoiSua = "" });
        [Description("Bảng tường trình điều trị tái thông")]
        BTTDTTT=60,//", TenPhieu = "", TrangThai = 1, DatabaseName = "BANTUONGTRINHDIEUTRITAITHONG" });
        [Description("NNX xác nhận nằm viện")]
        NNXXNNV =61,//", TenPhieu = "", TrangThai = 1, DatabaseName = "NNXXacNhanNamVien", NgayTao = "NGAY_TAO", NgaySua = "NGAY_SUA", NguoiTao = "NGUOI_TAO", NguoiSua = "NGUOI_SUA" });
        [Description("NNX chấp nhận PTTT")]
        NNXCNPTTT =62,//", TenPhieu = "", TrangThai = 1, DatabaseName = "NNXChapNhanPTTT", NgayTao = "NGAY_TAO", NgaySua = "NGAY_SUA", NguoiTao = "NGUOI_TAO", NguoiSua = "NGUOI_SUA" });
        [Description("NNX ra viện")]
        NNXRV=63,//", TenPhieu = "", TrangThai = 1, DatabaseName = "NNXRaVien", NgayTao = "NGAY_TAO", NgaySua = "NGAY_SUA", NguoiTao = "NGUOI_TAO", NguoiSua = "NGUOI_SUA" });
        [Description("NNX thuê máy trợ thở")]
        NNXTMTT =64,//", TenPhieu = "", TrangThai = 1, DatabaseName = "NNXThueMayTroTho", NgayTao = "NGAY_TAO", NgaySua = "NGAY_SUA", NguoiTao = "NGUOI_TAO", NguoiSua = "NGUOI_SUA" });
        [Description("NNX hồi sức tối thiểu")]
        NNXHSTT =65,//", TenPhieu = "", TrangThai = 1, DatabaseName = "NNXHoiSucToiThieu", NgayTao = "NGAY_TAO", NgaySua = "NGAY_SUA", NguoiTao = "NGUOI_TAO", NguoiSua = "NGUOI_SUA" });
        [Description("Phiếu theo dõi và chăm sóc bệnh nhân cấp 2")]
        TDVCSBNC2 =66,//", TenPhieu = "", TrangThai = 1, DatabaseName = "PhieuTheoDoiVaChamSocBNC2" });
        [Description("Đánh giá tri giác người lớn theo thang điểm Glasgow")]
        DGTGNLGG=67,//", TenPhieu = "", TrangThai = 1, DatabaseName = "DanhGiaTriGiacNguoiLonGLASGOW" });
        [Description("Phiếu theo dõi bệnh nhân nặng")]
        PTDBNN=68,//", TenPhieu = "", TrangThai = 1, DatabaseName = "PhieuTheoDoiBenhNhanNang" });
        [Description("Thang điểm đột quỵ NIHSS")]
        TDDQNIHSS =69,//", TenPhieu = "", TrangThai = 1, DatabaseName = "ThangDiemDotQuyNIHSS" });
        [Description("Bảng kiểm trước khi mổ")]
        BKTKM =70,//", TenPhieu = "", TrangThai = 1, DatabaseName = "BangKiemTruocKhiMo" });
        [Description("Bảng kiểm sau khi mổ")]
        BKSKM=71,//", TenPhieu = "", TrangThai = 1, DatabaseName = "BangKiemSauKhiMo" });
        [Description("Bảng kiểm điều trị tái thông, đột quỵ do thiếu máu não cục bộ (Dành cho điều dưỡng)")]
        BKDTTTDD =72,//", TenPhieu = "", TrangThai = 1, DatabaseName = "BangDieuTriTaiThongDieuDuong" });
        [Description("Bảng kiểm điều trị tái thông, đột quỵ do thiếu máu não cục bộ (Dành cho bác sỹ)")]
        BKDTTTBS=73,//", TenPhieu = "", TrangThai = 1, DatabaseName = "BangDieuTriTaiThongBacSy" });
        [Description("Phiếu theo dõi điều trị huyết áp chỉ huy")]
        PTDDTHACH=74,//", TenPhieu = ", TrangThai = 1, DatabaseName = "PhieuTheoDoiDieuTriHACH", NgayTao = "", NgaySua = "", NguoiTao = "", NguoiSua = "" });
        [Description("Phiếu theo dõi đường mao mạch")]
        PTDMM =75,//", TenPhieu = "", TrangThai = 1, DatabaseName = "PhieuTheoDoiDuongMaoMach", NgayTao = "", NgaySua = "", NguoiTao = "", NguoiSua = "" });
        [Description("NNX cam đoan làm thủ thuật")]
        NNXCDLTT =76,//", TenPhieu = "", TrangThai = 1, DatabaseName = "NNXCamDoanLamThuThuat", NgayTao = "NGAY_TAO", NgaySua = "NGAY_SUA", NguoiTao = "NGUOI_TAO", NguoiSua = "NGUOI_SUA" });
        [Description("NNX cam kết sử dụng xét nghiệm, vật tư tiêu hoa")]
        NNXCKXDXN=77,//", TenPhieu = "", TrangThai = 1, DatabaseName = "NNXCamKetSuDungXetNghiem", NgayTao = "NGAY_TAO", NgaySua = "NGAY_SUA", NguoiTao = "NGUOI_TAO", NguoiSua = "NGUOI_SUA" });
        [Description("Giấy báo mổ")]
        GBM =78,//", TenPhieu = "", TrangThai = 1, DatabaseName = "GiayBaoMo" });
        [Description("Biên bản hội chẩn can thiệp tim mạch")]
        BBHCTTTM =79,//", TenPhieu = "", TrangThai = 1, DatabaseName = "BienBanHCCTTimMach" });
        [Description("Phiếu theo dõi chức năng sống")]
        PTDCNS =80,//", TenPhieu = "", TrangThai = 1, DatabaseName = "PhieuTheoDoiChucNangSong" });
        [Description("Danh sách phiếu trả kết quả")]
        DSPTKQ =81,//", TenPhieu = "", TrangThai = 1, DatabaseName = "PhieuTraKetQuaTim", NguoiTao = "", NguoiSua = "" });
        [Description("Phiếu chỉ định theo dõi tim thai và cơn co tử cung bằng máy monitor")]
        TDTTCCCTC= 82,//", TenPhieu = "", TrangThai = 1, DatabaseName = "PhieuTDTimThaiCCTC" });
        [Description("Phiếu theo dõi điều trị Alteplase đường tĩnh mạch")]
        PTDDTADTM=83,//", TenPhieu = ", TrangThai = 1, DatabaseName = "PhieuTDDTAlteplase", NgayTao = "", NgaySua = "", NguoiTao = "", NguoiSua = "" });
        [Description("Giấy cam kết đồng ý chụp phim có tiêm chất tương phản")]
        CKTCTP=84,//", TenPhieu = "", TrangThai = 1, DatabaseName = "CamKetTiemChatTuongPhan" });
        [Description("Giấy cam đoan tự nguyện phá thai")]
        GCDTNPT=85,//", TenPhieu = "", TrangThai = 1, DatabaseName = "GiayCamDoanTuNguyenPhaThai", NgayTao = "NGAY_TAO", NgaySua = "NGAY_SUA", NguoiTao = "NGUOI_TAO", NguoiSua = "NGUOI_SUA" });
        [Description("Biên bản hội chẩn phẫu thuật")]
        BBHCPT=86,//", TenPhieu = "", TrangThai = 1, DatabaseName = "BienBanHoiChanPhauThuat" });
        [Description("Phiếu đánh giá tình trạng dinh dưỡng")]
        PDGTTDD = 87,//", TenPhieu = "", TrangThai = 1, DatabaseName = "DanhGiaTinhTrangDinhDuong" });
        [Description("Phiếu tư vấn bệnh nhân/thân nhân")]
        PTVBNTN = 88,//", TenPhieu = "", TrangThai = 1, DatabaseName = "PhieuTuVanBNTN" });
        [Description("Phiếu lọc máu cấp cứu")]
        PLMCC= 89,//", TenPhieu = "", TrangThai = 1, DatabaseName = "PhieuLocMauCapCuu" });
        [Description("Tầm kiểm soát bệnh nhân có nguy cơ với chất tương phản")]
        TSBNCTP = 90,//", TenPhieu = "", TrangThai = 1, DatabaseName = "NGUYCOCHATTUONGPHAN", NguoiTao = "", NguoiSua = "" });
        [Description("Phiếu đánh giá tình trạng dinh dưỡng")]
        PDGDD= 91,//", TenPhieu = "", TrangThai = 1, DatabaseName = "" });
        [Description("Phiếu theo dõi và chăm sóc bệnh nhân cấp 1")]
        TDCSBNC1= 92,//", TenPhieu = "", TrangThai = 1, DatabaseName = "PhieuTDCSBenhNhanCap1" });
        [Description("Phiếu theo dõi và điều trị thận nhân tạo")]
        TDDTTNT= 93,//", TenPhieu = "", TrangThai = 1, DatabaseName = "PhieuTDDTThanNhanTao" });
        [Description("Phiếu hội chẩn duyệt mổ")]
        PHCDM= 94,//", TenPhieu = "", TrangThai = 1, DatabaseName = "PhieuHoiChanDuyetMo" });
        [Description("Phiếu theo dõi và chăm sóc")]
        PTDVCS= 95,//", TenPhieu = "", TrangThai = 1, DatabaseName = "PhieuTheoDoiVaChamSoc" });
        [Description("Phiếu dịch vụ kỹ thuật thủ thuật ngoại trú")]
        PDVKTTT= 96,//", TenPhieu = "", TrangThai = 1, DatabaseName = "PhieuDichVuKTTT" });
        [Description("Phiếu tái khám hen")]
        PTKH=97,//", TenPhieu = "", TrangThai = 1, DatabaseName = "PhieuTaiKhamHen" });
        [Description("Phiếu theo dõi chức năng sống (cấp II, III)")]
        PTDCN23=98,//", TenPhieu = "", TrangThai = 1, DatabaseName = "PhieuTDCSNguoiBenhCap23" });
        [Description("Bảng kiểm tránh nhầm lẫn bệnh nhân khi cung cấp dịch vụ")]
        BKTNLBN=99,//", TenPhieu = " ", TrangThai = 1, DatabaseName = "BangKiemTranhNhamLanBN" });
        [Description("Giấy xác nhận bàn giao trẻ")]
        GXNBGT =100,//", TenPhieu = "", TrangThai = 1, DatabaseName = "GiayXacNhanBanGiaoTre" });
        [Description("Bảng theo dõi chăm sóc bệnh nhân")]
        BTDCSBN=101,//", TenPhieu = "", TrangThai = 1, DatabaseName = "BangTDCSBenhNhan" });
        [Description("Bảng kết quả đường máu mao mạch")]
        BKQDMMM =102,//", TenPhieu = ", TrangThai = 1, DatabaseName = "BangKQDuongMaoMach" });
        [Description("Phiếu nghiệm pháp tăng đường huyết")]
        PNPTDH=103,//", TenPhieu = "", TrangThai = 1, DatabaseName = "PhieuNghiemPhapTangDuongHuyet" });
        [Description("Bảng kiểm bàn giao người bệnh trước PTTT")]
        BKCBBGTPTTT = 104,//", TenPhieu = "", TrangThai = 1, DatabaseName = "BangKiemCBBGTruocPTTT" });
        [Description("Giấy cam đoan chấp nhận PTTT GMHS2")]
        CDPTGMHS2=105,//", TenPhieu = "", TrangThai = 1, DatabaseName = "CamDoanChapNhanPTTTGMHS2", NgayTao = "NGAY_TAO", NgaySua = "NGAY_SUA", NguoiTao = "NGUOI_TAO", NguoiSua = "NGUOI_SUA" });
        [Description("Phiếu chuẩn bị bệnh nhân trước khi mổ của Y tá")]
        PCBTKMCYT=106,//", TenPhieu = "", TrangThai = 1, DatabaseName = "PhieuChuanBiTruocKhiMo" });
        [Description("Phiếu xác nhận tình trạng cấp cứu với mức hưởng BHYT")]
        PXNTTCCBHYT = 107,//", TenPhieu = "", TrangThai = 1, DatabaseName = "PHIEUXNTTCAPCUUVOIMUCBHYT" });
        [Description("Bản cam kết")]
        BCK=108,//", TenPhieu = "", TrangThai = 1, DatabaseName = "BanCamKet", NgayTao = "NGAY_TAO", NgaySua = "NGAY_SUA", NguoiTao = "NGUOI_TAO", NguoiSua = "NGUOI_SUA" });
        [Description("Biên bản hội chẩn bệnh viện")]
        BBHCBV =109,//", TenPhieu = "", TrangThai = 1, DatabaseName = "BienBanHoiChanBenhVien" });
        [Description("Bảng kiểm nhận diện đúng người bệnh")]
        BKNDDNB=110,//", TenPhieu = "", TrangThai = 1, DatabaseName = "BangKiemNhanDienNB" });
        [Description("Giấy giải thích và cam kết")]
        GGTVCK =111,//", TenPhieu = "", TrangThai = 1, DatabaseName = "GiayGiaiThichVaCamKet", NgayTao = "NGAY_TAO", NgaySua = "NGAY_SUA", NguoiTao = "NGUOI_TAO", NguoiSua = "NGUOI_SUA" });
        [Description("Giấy cam kết đồng ý truyền máu và chế phẩm máu")]
        GCKDYTMVPC=112,//", TenPhieu = "", TrangThai = 1, DatabaseName = "GiayCamKetDYTMVCPM", NgayTao = "NGAY_TAO", NgaySua = "NGAY_SUA", NguoiTao = "NGUOI_TAO", NguoiSua = "NGUOI_SUA" });
        [Description("Bảng kiểm chuẩn bị và bàn giao bênh nhân sau PTTT")]
        BKCBBGSPTTT= 113,//", TenPhieu = "", TrangThai = 1, DatabaseName = "BangKiemCBBGSauPTTT" });
        [Description("Giấy giải thích và cam kết trước dùng thuốc cản quang")]
        GGTVCKTDTCQ=114,//", TenPhieu = "", TrangThai = 1, DatabaseName = "GiayGiaiThichVaCamKetTDTCQ", NgayTao = "NGAY_TAO", NgaySua = "NGAY_SUA", NguoiTao = "NGUOI_TAO", NguoiSua = "NGUOI_SUA" });
        [Description("Giấy cam kết được nghe giải thích về tình trạng bệnh")]
        GCKDNGTVTTB=115,//", TenPhieu = "", TrangThai = 1, DatabaseName = "GiayCamKetDNGTVTTB", NgayTao = "NGAY_TAO", NgaySua = "NGAY_SUA", NguoiTao = "NGUOI_TAO", NguoiSua = "NGUOI_SUA" });
        [Description("Giấy cam kết chụp xạ hình tưới máu cơ tim")]
        GCKCXHTMCT=116,//", TenPhieu = "", TrangThai = 1, DatabaseName = "GiayCamKetCXHTMCT", NgayTao = "NGAY_TAO", NgaySua = "NGAY_SUA", NguoiTao = "NGUOI_TAO", NguoiSua = "NGUOI_SUA" });
        [Description("Phiếu theo dõi nước tiểu 24h dành cho bệnh nhân")]
        PTDNT24HBN=117,//", TenPhieu = ", TrangThai = 1, DatabaseName = "PhieuTDNuocTieu24H" });
        [Description("Phiếu đánh giá người bệnh nhập viện")]
        DGNBNV=118,//", TenPhieu = "", TrangThai = 1, DatabaseName = "DanhGiaNguoiBenhNhapVien" });
        [Description("Phiếu đánh giá bệnh nhi nhập viện")]
        DGBNNV =119,//", TenPhieu = "Phiếu đánh giá bệnh nhi nhập viện", TrangThai = 1, DatabaseName = "DanhGiaBenhNhiNhapVien" });
        [Description("Bảng kê dụng cụ và VTTH bệnh nhân can thiệp tim mạch")]
        BKDCVTTHBNCTTM = 120,//", TenPhieu = "Bảng kê dụng cụ và VTTH bệnh nhân can thiệp tim mạch", TrangThai = 1, DatabaseName = "BANGKEDCVAVTTHBNCTTIMMACH" });
        [Description("Đánh giá tình trạng răng miệng bệnh nhân trước phẫu thuật")]
        DGTTRMBNTPT= 121,//", TenPhieu = "Đánh giá tình trạng răng miệng bệnh nhân trước phẫu thuật", TrangThai = 1, DatabaseName = "DGTTRangMiengBNTruocPT" });
        [Description("Phiếu khám trước gây mê")]
        PKTGM=122,//", TenPhieu = "Phiếu khám trước gây mê", TrangThai = 1, DatabaseName = "PhieuKhamTruocGayMe" });
        [Description("Phiếu kiểm tra bệnh án")]
        PKTBA =123,//", TenPhieu = "", TrangThai = 1, DatabaseName = "PhieuKiemTraBenhAn" });
        [Description("Phiếu chuẩn bị bệnh nhân trước can thiệp của điều dưỡng")]
        PCBTCTCDD=124,//", TenPhieu = "", TrangThai = 1, DatabaseName = "PhieuChuanBiTruocCanThiep" });
        [Description("Phiếu khám và điều trị bệnh nhân")]
        PKVDTBN =125,//", TenPhieu = "", TrangThai = 1, DatabaseName = "PhieuKhamVaDieuTriBenhNhan" });
        [Description("Phiếu bàn giao bênh nhân")]
        PBGBN=126,//", TenPhieu = ", TrangThai = 1, DatabaseName = "PhieuBanGiaoBenhNhan" });
        [Description("Phiếu tóm tắt quá trình điều trị")]
        PTTQTDT =127,//", TenPhieu = "", TrangThai = 1, DatabaseName = "PhieuTomTatQuaTrinhDieuTri" });
        [Description("Phiếu gây mê thủ thuật")]
        GMTT=128,//", TenPhieu = "", TrangThai = 1, DatabaseName = "PhieuGayMeThuThuat" });
        [Description("Phiếu kiểm bàn giao người bệnh trước PTTT")]
        BKCBBGTPTTT2 = 129,//", TenPhieu = "", TrangThai = 1, DatabaseName = "BangKiemCBBGTruocPTTT2" });
        [Description("Bảng kiểm an toàn thủ thuật CTTM")]
        BKATTTCTTM=130,//", TenPhieu = "", TrangThai = 1, DatabaseName = "BangKiemAnToanThuThuat_CTTM", NgayTao = "NGAY_TAO", NgaySua = "NGAY_SUA", NguoiTao = "NGUOI_TAO", NguoiSua = "NGUOI_SUA" });
        [Description("Kế hoạch chăm sóc người bệnh suy tim")]
        KHCSNBST=131,//", TenPhieu = ", TrangThai = 1, DatabaseName = "KeHoachCSNBSuyTim" });
        [Description("Kế hoạch chăm sóc người bệnh sau can thiệp tim mạch")]
        KHCSNBSCTTM =132,//", TenPhieu = "", TrangThai = 1, DatabaseName = "KeHoachCSNBSauTimMach" });
        [Description("Giấy cam đoan chấp nhận thủ thuật tim mạch can thiệp và gây mê hồi sức")]
        CKTMCTGMHS=133,//", TenPhieu = "", TrangThai = 1, DatabaseName = "CamKetTMCT_GMHS", NgayTao = "NGAY_TAO", NgaySua = "NGAY_SUA", NguoiTao = "NGUOI_TAO", NguoiSua = "NGUOI_SUA" });
        [Description("Bảng theo dõi CEC")]
        BTDCEC=134,//", TenPhieu = "", TrangThai = 1, DatabaseName = "BangTheoDoiCEC" });
        [Description("Bảng theo dõi chăm sóc người bệnh")]
        BTDCSNB =135,//", TenPhieu = "", TrangThai = 1, DatabaseName = "BangTheoDoiChamSocNB" });
        [Description("Bảng theo dõi bệnh nhân can thiệp mạch vành")]
        BTDBNCTMV=136,//", TenPhieu = "", TrangThai = 1, DatabaseName = "BangTheoDoiBenhNhanCTMV" });
        [Description("Bảng kê lọc máu liên tục")]
        BKLMLT=137,//", TenPhieu = "", TrangThai = 1, DatabaseName = "BangKeLocMauLienTuc" });
        [Description("Bảng kê thay huyết tương")]
        BKTHT=138,//", TenPhieu = "", TrangThai = 1, DatabaseName = "BangKeThayHuyetTuong" });
        [Description("Bảng tóm tắt hồ sơ bệnh án")]
        BTTHSBA=139,//", TenPhieu = "", TrangThai = 1, DatabaseName = "BangTomTatHoSoBenhAn" });
        [Description("Phiếu lọc máu 2")]
        PLM2=140,//", TenPhieu = "", TrangThai = 1, DatabaseName = "PhieuLocMau2" });
        [Description("Phiếu thực hiện kỹ thuật/thủ thuật")]
        PKTTT=141,//", TenPhieu = "", TrangThai = 1, DatabaseName = "PhauThuatThuThuat" });
        [Description("Phiếu khám chuyên khoa")]
        PKCK=142,//", TenPhieu = "", TrangThai = 1, DatabaseName = "PhieuKhamChuyenKhoa" });
        [Description("Phiếu theo dõi và thực hiện kế hoạch chăm sóc")]
        PTDTHKHCS= 143,//", TenPhieu = "", TrangThai = 1, DatabaseName = "PhieuTDVaTHKHCSNguoiBenh" });
        [Description("Phiếu đếm gạc")]
        PDG=144,//", TenPhieu = "", TrangThai = 1, DatabaseName = "PhieuDemGac" });
        [Description("Trích lục bệnh án")]
        TLBA=145,//", TenPhieu = "", TrangThai = 1, DatabaseName = "PhieuTomTatBenhAnNoiTru" });
        [Description("Bảng theo dõi lọc máu")]
        BTDLM=146,//", TenPhieu = "", TrangThai = 1, DatabaseName = "BangTheoDoiLocMau" });
        [Description("Bảng theo dõi thay huyết tương")]
        BTDTHT=147,//", TenPhieu = "", TrangThai = 1, DatabaseName = "BangTheoDoiThayHuyetTuong" });
        [Description("Phiếu theo dõi truyền máu lâm sàng")]
        PTDTMLS=148,//", TenPhieu = "", TrangThai = 1, DatabaseName = "BangTheoDoiTMLS" });
        [Description("Phiếu xét nghiệm hòa hợp miễn dịch phát máu")]
        PXNHHMDPM=149,//", TenPhieu = "", TrangThai = 1, DatabaseName = "PhieuXetNghiemPhatMau" });
        [Description("Phiếu chuẩn bị người bệnh trước can thiệp của điều dưỡng")]
        PCBBNTCTCDD= 150,//", TenPhieu = "", TrangThai = 1, DatabaseName = "PhieuCBBnTruocCTCuaDD" });
        [Description("Phiếu chuẩn bị người bệnh trước phẫu thuật của điều dưỡng")]
        PCBBNTPTCDD= 151,//", TenPhieu = "", TrangThai = 1, DatabaseName = "PhieuCBBnTruocPTCuaDD" });
        [Description("Phiếu khám và theo dõi điều trị hen")]
        PKVTDDTH=152,//", TenPhieu = "", TrangThai = 1, DatabaseName = "PKVaTDDieuTriHen" });
        [Description("Phiếu khám và theo dõi điều trị COPD")]
        PKVTDDTC=153,//", TenPhieu = "", TrangThai = 1, DatabaseName = "PKVaTDDieuTriCopd" });
        [Description("Phiếu trích biên bản hội chẩn")]
        PTBBHC=154,//", TenPhieu = "", TrangThai = 1, DatabaseName = "PhieuTrichBienBanHoiChan" });
        [Description("Phiếu khám và điều trị phục hồi chức năng hô hấp")]
        PKVDTPHCNHH=155,//", TenPhieu = "", TrangThai = 1, DatabaseName = "PHIEUKHAMVADIEUTRIPHCNHOHAP" });
        [Description("Cam kết trước chuyển dạ, trước phẫu thuật")]
        CKTCDTPT=156,//", TenPhieu = "", TrangThai = 1, DatabaseName = "CAMKETTRUOCCHUYENDATRUOCPT" });
        [Description("Phiếu công khai chế độ ăn")]
        PCKCDA=157,//", TenPhieu = "", TrangThai = 1, DatabaseName = "PhieuCongKhaiCheDoAn" });
        [Description("Phiếu sơ kết 30 ngày điều trị")]
        SK30NDT=158,//", TenPhieu = "", TrangThai = 1, DatabaseName = "PHIEUSOKET30NGAYDIEUTRI", NgayTao = "THOIGIANTAO", NgaySua = "", NguoiTao = "", NguoiSua = "" });
        [Description("Phiếu theo dõi và chăm sóc bệnh nhân ICU")]
        PTDCSNBICU =159,//", TenPhieu = "", TrangThai = 1, DatabaseName = "PhieuTDCSNBICU" });
        [Description("Phiếu đánh giá dinh dưỡng người bệnh nhập viện ICU")]
        PDGDDNBNVICU =160,//", TenPhieu = ", TrangThai = 1, DatabaseName = "PhieuDGDDNguoiBenhNhapVienICU" });
        [Description("Phiếu phản hồi Kết quả điều trị bệnh nhân chuyển đến")]
        PPHKQDTBNCD=161,//", TenPhieu = "", TrangThai = 1, DatabaseName = "PhieuPhanHoiKetQuaDieuTri" });
        [Description("Phiếu chuyển bệnh nhân để tiếp tục điều trị")]
        PCBNDTTDT=162,//", TenPhieu = "", TrangThai = 1, DatabaseName = "PhieuChuyenBenhNhan" });
        [Description("Biên bản hội chẩn điều trị lao kháng thuốc")]
        BBHCDTLKT=163,//", TenPhieu = "", TrangThai = 1, DatabaseName = "BBHCDieuTriLaoKhangThuoc" });
        [Description("Phiếu chăm sóc mới")]
        CS2=164,//", TenPhieu = "", TrangThai = 1, DatabaseName = "ThongTinChamSocNew" });
        [Description("Kết quả làm trắc nghiệm trí nhớ Wechsler")]
        KQLTNTNW=165,//", TenPhieu = "", TrangThai = 1, DatabaseName = "TracNghiemTriNhoWECHSLER" });
        [Description("Thang đánh giá hưng cảm Young")]
        TDGHCY=166,//", TenPhieu = "", TrangThai = 1, DatabaseName = "ThangDanhGiaHungCamYoung" });
        [Description("Thang đánh giá tâm thần rút gọn (BPRS)")]
        DGBPRS=167,//", TenPhieu = "", TrangThai = 1, DatabaseName = "DanhGiaTamThanRutGonBPRS" });
        [Description("Đánh giá tự kỷ ở trẻ (M-CHAT)")]
        DGTKOTNMC=168,//", TenPhieu = "", TrangThai = 1, DatabaseName = "DanhGiaTuKyTreNhoMChat" });
        [Description("Nghiệm pháp Beck")]
        NPB=169,//", TenPhieu = "", TrangThai = 1, DatabaseName = "NghiemPhapBeck" });
        [Description("Trang trầm cảm Hamilton")]
        TTCH=170,//", TenPhieu = "", TrangThai = 1, DatabaseName = "ThangTramCamHamilton" });
        [Description("Nghiệm pháp Beck (Test Nhi)")]
        NPBN=171,//", TenPhieu = "", TrangThai = 1, DatabaseName = "NghiemPhapBeckNhi" });
        [Description("Bậc thang tự đánh giá lo âu SAS Zung")]
        BTTDGLASZ=172,//", TenPhieu = "", TrangThai = 1, DatabaseName = "DanhGiaLoAuSasZung" });
        [Description("Phiếu hồ sơ chăm sóc")]
        PHSCS=173,//", TenPhieu = "", TrangThai = 1, DatabaseName = "HSCS_TTBenhNhan" });
        [Description("Phiếu tư vấn và giáo dục sức khoẻ")]
        PTVGDSK=174,//", TenPhieu = "", TrangThai = 1, DatabaseName = "GiaoDucSucKhoe" });
        [Description("Đánh giá nguy cơ ngã và hướng can thiệp")]
        DGNCNVHCT=175,//", TenPhieu = "", TrangThai = 1, DatabaseName = "BangDGNguyCoTeNgaVaHCT" });
        [Description("Mẫu phiếu yêu cầu sử dụng kháng sinh cần ưu tiên quản lý")]
        MPYCSDKS=176,//", TenPhieu = "", TrangThai = 1, DatabaseName = "PhieuYCSDKhanhSinhUuTien" });
        [Description("Giấy tự nguyện triệt sản")]
        GTNTS=177,//", TenPhieu = "", TrangThai = 1, DatabaseName = "GiayTuNguyenTrietSan" });
        [Description("Giấy khám chữa bệnh theo yêu cầu")]
        GKCBTYC=178,//", TenPhieu = ", TrangThai = 1, DatabaseName = "GiayKhamChuaBenTheoYeuCau" });
        [Description("Phiếu theo dõi và chăm sóc cấp 1")]
        PTDVCSC1=179,//", TenPhieu = "", TrangThai = 1, DatabaseName = "PTDVCSC1" });
        [Description("Phiếu theo dõi và chăm sóc bệnh nhân cấp II, III")]
        PTDVCSNBC23= 180,//", TenPhieu = "", TrangThai = 1, DatabaseName = "PTDVCSNBC23" });
        [Description("Bảng kiểm soát bệnh nhân trước khi đưa lên phòng mổ")]
        BKSBNTM=181,//", TenPhieu = "", TrangThai = 1, DatabaseName = "BangKiemSoatBNTruocMo" });
        [Description("Phiếu theo dõi giảm đau sản khoa")]
        PTDGDSK=182,//", TenPhieu = "", TrangThai = 1, DatabaseName = "PhieuTDGDKhoaSan" });
        [Description("Phiếu chuyển để tiếp tục điều trị")]
        PCDTTDT=183,//", TenPhieu = "", TrangThai = 1, DatabaseName = "PhieuChuyenDeTiepTucDieuTri" });
        [Description("Phiếu yêu cầu sử dụng kháng sinh")]
        PYCSDKS=184,//", TenPhieu = "", TrangThai = 1, DatabaseName = "PhieuYCSDKhanhSinh" });//13/07/2021 Add by Hòa Issues 60112
        [Description("Kế hoạch chăm sóc người bệnh")]
        KHCSNB= 185,//", TenPhieu = "", TrangThai = 1, DatabaseName = "KeHoachChamSocNguoiBenh" });
        [Description("Phiếu chăm sóc")]
        PCS=186,//", TenPhieu = "", TrangThai = 1, DatabaseName = "PhieuChamSoc" });
        [Description("Phiếu điện tim")]
        PDT=187,//", TenPhieu = "", TrangThai = 1, DatabaseName = "PhieuDienTim" });
        [Description("Phiếu theo dõi và chăm sóc bệnh nhân ICU 2")]
        PTDCSNBICU2 = 188,//", TenPhieu = "", TrangThai = 1, DatabaseName = "PhieuTDCSNBICU" });
        [Description("Phiếu tư vấn giáo dục sức khỏe cho người bệnh và gia đình người bệnh")]
        TVGDSK= 189,//", TenPhieu = "", TrangThai = 1, DatabaseName = "TuVanGiaoDucSucKhoe" });
        [Description("Phiếu bàn giao sang phòng hồi sức")]
        PBGSPHS=190,//", TenPhieu = "", TrangThai = 1, DatabaseName = "PhieuBanGiaoSangPhongHoiSuc" });
        [Description("Giấy giới thiệu bệnh nhân MDR - TB đến đơn vị tiếp tục quản lí điều trị")]
        GGTBNMDR=191,//", TenPhieu = "", TrangThai = 1, DatabaseName = "GiayGioiThieuBenhNhanMDR" });
        [Description("Đơn xin đảm bảo bệnh nhân tâm thần")]
        DXDBBNTT=192,//", TenPhieu = "", TrangThai = 1, DatabaseName = "DonXinDamBaoBenhNhanTamThan" });
        [Description("Phiếu theo dõi chăm sóc người bệnh")]
        PTDCSNB=193,//", TenPhieu = "", TrangThai = 1, DatabaseName = "PhieuTDCSNB" });
        [Description("Biên bản duyệt bệnh nhân phẫu thuật theo kế hoạch")]
        BBDBNPTTKH=194,//", TenPhieu = "", TrangThai = 1, DatabaseName = "PhieuTDCSNB" });
        [Description("Phiếu xét nghiệm vi khuẩn lao")]
        PXNVKL=195,//", TenPhieu = "", TrangThai = 1, DatabaseName = "PhieuXetNghiemViKhuanLao" });
        [Description("Phiếu đánh giá dinh dưỡng người bệnh")]
        PDGDDNB=196,//", TenPhieu = "", TrangThai = 1, DatabaseName = "PhieuDanhGiaDDNguoiBenh" });
        [Description("Phiếu xét nghiệm xpert xpress sars-cov-2")]
        PXNXXS=197,//", TenPhieu = "", TrangThai = 1, DatabaseName = "PhieuXetNghiemXpertXpress" });
        [Description("Phiếu xét nghiệm vi khuẩn lao 1 mặt")]
        PXNVKLMM=198,//", TenPhieu = "", TrangThai = 1, DatabaseName = "PhieuXetNghiemViKhuanLao2" });
        [Description("Phiếu tiếp nhận bệnh nhân")]
        PTNBN=199,//", TenPhieu = "", TrangThai = 1, DatabaseName = "PhieuTiepNhanBenhNhan" });
        [Description("Phiếu xác nhận xét nghiệm HIV")]
        PXNXNHIV=200,//", TenPhieu = "", TrangThai = 1, DatabaseName = "PhieuXNXNHIV" });
        [Description("Tờ y lệnh truyền insulin tĩnh mạch")]
        TYLTITM=201,//", TenPhieu = "", TrangThai = 1, DatabaseName = "PhieuTruyenInsulin" });
        [Description("Kết quả nghiệm pháp Atropin")]
        KQNPA=202,//", TenPhieu = "", TrangThai = 1, DatabaseName = "KetQuaNghiemPhapAtropin" });
        [Description("Giấy cam đoan chấp nhận sử dụng thuốc trong điều trị")]
        GCDCNSDTTDT =203,//", TenPhieu = "", TrangThai = 1, DatabaseName = "CamDoanSDTTDT" });
        [Description("Giấy cam đoan chấp nhận phẫu thuật, thủ thuật và gây mê hồi sức")]
        GCDCNPTTTGMHS=204,//", TenPhieu = "", TrangThai = 1, DatabaseName = "GiayCamDoanCNPTTTGMHS" });
        [Description("Phiếu tóm tắt thông tin điều trị")]
        PTTTTDT=205,//", TenPhieu = "", TrangThai = 1, DatabaseName = "PhieuTTThongTinDieuTri" });
        [Description("Giấy báo đóng tiền")]
        GBDT=206,//", TenPhieu = "", TrangThai = 1, DatabaseName = "GiayBaoDongTien" });
        [Description("Giấy cam kết đóng tiền TMCT")]
        GCKDTTMCT=207,//", TenPhieu = "", TrangThai = 1, DatabaseName = "GiayCamKetDongTien" });
        [Description("Giấy cam kết chấp nhận tình trạng nặng can thiệp tim mạch")]
        GCKCNTTNCTTM=208,//", TenPhieu = "", TrangThai = 1, DatabaseName = "GiayCamKetCNTTNCTTM" });
        [Description("Phiếu theo dõi và chăm sóc bệnh nhân cấp II, III (Mẫu 2)")]
        PTDVCSNBC23_2=209,//", TenPhieu = "", TrangThai = 1, DatabaseName = "PTDVCSNBC23_2" });
        [Description("Bảng theo dõi chăm sóc người bệnh sau can thiệp tim mạch")]
        BTDCSNBSCTTM=210,//", TenPhieu = "", TrangThai = 1, DatabaseName = "BangTDCSNBSauCTTM" });
        [Description("Kết quả trả lời kết quả trắc nghiệm Raven")]
        KQTLTNRV=211,//", TenPhieu = "", TrangThai = 1, DatabaseName = "KQTLTracNghiemRaven" });
        [Description("Phơi cấy máy can thiệp tim mạch")]
        PCMCTTM=212,//", TenPhieu = "", TrangThai = 1, DatabaseName = "PhoiCayMayCTTM" });
        [Description("Phơi mạch vành can thiệp tim mạch")]
        PMVCTTM=213,//", TenPhieu = "", TrangThai = 1, DatabaseName = "PhoiMachVanhCTTM" });
        [Description("Đánh giá trạng thái tâm thần tối thiểu (MMSE)")]
        DGTTTTTT=214,//", TenPhieu = "", TrangThai = 1, DatabaseName = "DanhGiaTrangThaiTTTT" });
        [Description("Chỉ bảo chất lượng giấc ngủ")]
        CBCLGN=215,//", TenPhieu = "", TrangThai = 1, DatabaseName = "ChiBaoChatLuongGiacNgu" });
        [Description("Kết quả trả lời trắc nghiệm Raven màu")]
        KQTLTNRM=216,//", TenPhieu = ", TrangThai = 1, DatabaseName = "KQTLTracNghiemRavenMau" });
        [Description("Bảng hỏi sức khỏe bệnh nhân PHQ-9")]
        BHSKBNPHQ=217,//", TenPhieu = "", TrangThai = 1, DatabaseName = "BangHoiSucKhoeBNPHQ" });
        [Description("Đơn xin lại phim")]
        DXLP=218,//", TenPhieu = "", TrangThai = 1, DatabaseName = "DonXinLaiPhim" });
        [Description("Tờ giải thích tình trạng bệnh lý")]
        TGTTTBL=219,//", TenPhieu = "", TrangThai = 1, DatabaseName = "ToGiaiThichTTBL" });
        [Description("Phiếu theo dõi và chăm sóc sơ sinh sau mổ đẻ")]
        PTDVCSSSSMD=230,//", TenPhieu = "", TrangThai = 1, DatabaseName = "PhieuTDVCSSSSauMoDe" });
        [Description("Phiếu yêu cầu nội soi")]
        PYCNS=231,//", TenPhieu = "", TrangThai = 1, DatabaseName = "PhieuYeuCauNoiSoi" });
        [Description("Biên bản hội chẩn ung bướu")]
        BBHCUB=232,//", TenPhieu = "", TrangThai = 1, DatabaseName = "BienBanHoiChanUngBuou" });
        [Description("Đánh giá người bệnh nhập viện/vào khoa và kế hoạch chăm sóc")]
        DGNBNVKHCS=233,//", TenPhieu = "", TrangThai = 1, DatabaseName = "DanhGiaNBVaKHCS" });
        [Description("Phiếu điều trị khoa Laser")]
        PDTKL=234,//", TenPhieu = "", TrangThai = 1, DatabaseName = "PhieuDieuTriKhoaLaser" });
        [Description("Phiếu khám nghiệm tử thi")]
        PKNTT=235,//", TenPhieu = "", TrangThai = 1, DatabaseName = "KhamNghiemTuThi" });
        [Description("Phiếu theo dõi và chăm sóc người bệnh ( Khoa sản)")]
        PTDVCSNBKS=236,//", TenPhieu = "", TrangThai = 1, DatabaseName = "PTDCSNBKhoaSan" });
        [Description("Phiếu đánh giá mức độ tự kỉ của trẻ em")]
        PDGMDTKTE=237,//", TenPhieu = "", TrangThai = 1, DatabaseName = "PhieuDGMucDoTuKiTE" });
        [Description("Phiếu săn sóc da khoa laser")]
        PSSDKL=238,//", TenPhieu = "", TrangThai = 1, DatabaseName = "PhieuSanSocDaKhoaLaser" });
        [Description("Phiếu truyền máu lâm sàng")]
        PTMLS=239,//", TenPhieu = ", TrangThai = 1, DatabaseName = "PhieuTruyenMauLamSang" });
        [Description("Thủ thuật rút chi thép")]
        TTRCT=240,//", TenPhieu = "", TrangThai = 1, DatabaseName = "ThuThuatRutChiThep" });
        [Description("Thủ thuật chọc hút dịch màng phổi")]
        TTCHDMP = 241,//", TenPhieu = "", TrangThai = 1, DatabaseName = "TTChocHutDichMangPhoi" });
        [Description("Thủ thuật khâu vết mổ")]
        TTKVM=242,//", TenPhieu = "", TrangThai = 1, DatabaseName = "ThuThuatKhauVetMo" });
        [Description("Thủ thuật đặt dẫn lưu màng phổi")]
        TTDDLMP=243,//", TenPhieu = "", TrangThai = 1, DatabaseName = "TTDatDLMangPhoi" });
        [Description("Biên bản tổng hợp thuốc hủy")]
        BBTHTH=244,//", TenPhieu = "", TrangThai = 1, DatabaseName = "BienBanTongHopThuocHuy" });
        [Description("Phẫu thuật/thủ thuật đặt catheter động mạch")]
        PTTTDCDM=245,//", TenPhieu = "", TrangThai = 1, DatabaseName = "ThuThuatDatCatheterDM" });
        [Description("Phẫu thuật/thủ thuật đặt catheter tĩnh mạch cảnh trong")]
        PTTTDCTMCT=246,//", TenPhieu = "", TrangThai = 1, DatabaseName = "ThuThuatDatCatheterTMCT" });
        [Description("Phẫu thuật/thủ thuật đặt catheter tĩnh mạch đùi")]
        PTTTDCTMD=247,//", TenPhieu = "", TrangThai = 1, DatabaseName = "ThuThuatDatCatheterTMDui" });
        [Description("Phẫu thuật/thủ thuật đặt nội khí quản qua miệng")]
        PTTTDNKQQMIENG=248,//", TenPhieu = "", TrangThai = 1, DatabaseName = "ThuThuatDatNKQQuaMieng" });
        [Description("Phẫu thuật/thủ thuật đặt nội khí quản qua mũi")]
        PTTTDNKQQMUI=249,//", TenPhieu = "", TrangThai = 1, DatabaseName = "ThuThuatDatNKQQuaMui" });
        [Description("Thủ thuật đặt Catheter tĩnh mạch trung tâm")]
        TTDCTMTT=250,//", TenPhieu = "", TrangThai = 1, DatabaseName = "ThuThuatDatCatheterTMTT" });
        [Description("Biên bản hội chẩn dùng kháng sinh")]
        BBHCDKS=251,//", TenPhieu = "", TrangThai = 1, DatabaseName = "BienBanHoiChanDungKS" });
        [Description("Giấy đặt máu và chế phẩm máu")]
        GDMVCPM=252,//", TenPhieu = "", TrangThai = 1, DatabaseName = "GiayDatMauVaChePhamMau" });
        [Description("Phiếu theo dõi bệnh nhân truyển Ilomedi")]
        PTDBNTI=253,//", TenPhieu = "n", TrangThai = 1, DatabaseName = "PhieuTDBNTruyenILOMEDIN" });
        [Description("Phiếu yêu cầu xét nghiệm")]
        PYCXN=254,//", TenPhieu = "", TrangThai = 1, DatabaseName = "PhieuYeuCauXetNghiem" });
        [Description("Phiếu theo dõi bệnh nhân truyền endoxan")]
        PTDBNTE=255,//", TenPhieu = "", TrangThai = 1, DatabaseName = "PTDBNTruyenEndoxan" });
        [Description("Phiếu khảo sát loét")]
        PKSL=256,//", TenPhieu = "", TrangThai = 1, DatabaseName = "PhieuKhaoSatLoet" });
        [Description("Giấy cam đoan chấp nhận PTTT GMHS3")]
        CDPTGMHS3=257,//", TenPhieu = ", TrangThai = 1, DatabaseName = "CamDoanChapNhanPTTTGMHS3" });
        [Description("Phiếu điều dưỡng sốt xuất huyết")]
        PDDSXH =258,//", TenPhieu = "", TrangThai = 1, DatabaseName = "PhieuDDSotXuatHuyet" });
        [Description("Phiếu công khai dịch vụ khám chữa bệnh")]
        PCKDVKCB =259,//", TenPhieu = "", TrangThai = 1, DatabaseName = "PhieuCongKhaiDichVuKCB" });
        [Description("Bảng theo dõi BN can thiệp")]
        PTDCSNBCT=260,//", TenPhieu = "", TrangThai = 1, DatabaseName = "PTDCSNBCT" });
        [Description("Phiếu chăm sóc Nhi")]
        PCSN=261,//", TenPhieu = "", TrangThai = 1, DatabaseName = "PhieuCSNhi" });
        [Description("Phiếu truyền máu xét nghiệm")]
        PTMXN=262,//", TenPhieu = ", TrangThai = 1, DatabaseName = "PhieuTruyenMauXetNghiem" });
        [Description("Giấy giới thiệu điều trị tiếp của bệnh nhân lao kháng thuốc")]
        GGTDTTCBNLKT=263,//", TenPhieu = "", TrangThai = 1, DatabaseName = "GiayGTDTTCBNLaoKhangThuoc" });
        [Description("Phơi IP tim mạch can thiệp")]
        PIPTMCT=264,//", TenPhieu = "", TrangThai = 1, DatabaseName = "PhoiIPTMCT" });
        [Description("Phiếu phẫu thuật glocom")]
        PTTG=265,//", TenPhieu = "", TrangThai = 1, DatabaseName = "PhieuPhauThuatGlocom" });
        [Description("Phiếu phẫu thuật túi lệ")]
        PTTL=266,//", TenPhieu = "", TrangThai = 1, DatabaseName = "PhieuPhauThuatTuiLe" });
        [Description("Phiếu phẩu thuật SAPEJKO")]
        PPTS=267,//", TenPhieu = "", TrangThai = 1, DatabaseName = "PhieuPhauThuatSapejko" });
        [Description("Phiếu đánh giá dinh dưỡng người bệnh nhập viện (SGA)")]
        PDGDDNBNV=268,//", TenPhieu = "", TrangThai = 1, DatabaseName = "PhieuDanhGiaDDNBNV" });
        [Description("Phiếu công khai thuốc theo ngày")]
        PCKTTN=269,//", TenPhieu = "", TrangThai = 1, DatabaseName = "PhieuCongKhaiThuocTheoNgay" });
        [Description("Thang trí tuệ người lớn Wechsler")]
        TTTNLW=270,//", TenPhieu = "", TrangThai = 1, DatabaseName = "TriTueNguoiLonWechsler" });
        [Description("Giấy cam kết đồng ý chi trả khoản chênh lệch")]
        GCKDYCTKCL=271,//", TenPhieu = "", TrangThai = 1, DatabaseName = "GiayCamKetDYCTKCL" });
        [Description("Phiếu phẫu thuật sụp mi")]
        PTSM =272,//", TenPhieu = "", TrangThai = 1, DatabaseName = "PhieuPhauThuatSupMi" });
        [Description("Phiếu phẫu thuật lác")]
        PPTL=273,//", TenPhieu = "", TrangThai = 1, DatabaseName = "PhieuPhauThuatLac" });
        [Description("Phiếu đánh giá nhân cách - MINI – MMPI (MMPI rút gọn)")]
        PDGNC=274,//", TenPhieu = "", TrangThai = 1, DatabaseName = "PhieuDGNhanCach" });
        [Description("Hồ sơ trị xạ")]
        HSTX=275,//", TenPhieu = "", TrangThai = 1, DatabaseName = "HoSoTriXa" });
        [Description("Phiếu gửi mẫu xét nghiệm HIV")]
        PGMXNHIV=276,//", TenPhieu = ", TrangThai = 1, DatabaseName = "PhieuGuiMauXetNghiemHIV" });
        [Description("Phiếu lượng giá hoạt động chức năng và sự tham gia")]
        PLGHDCN=277,//", TenPhieu = "", TrangThai = 1, DatabaseName = "PhieuLuongGiaHDCNVaSTG" });
        [Description("Phiếu theo dõi và chăm sóc cấp người bệnh cấp II, III(Mẫu 3)")]
        PTDVCSNBC23_3=278,//", TenPhieu = "", TrangThai = 1, DatabaseName = "PTDVCSNBC23_3" });
        [Description("Phiếu theo dõi và chăm sóc cấp 1(Mẫu 2)")]
        PTDVCSNBC1_2=279,//", TenPhieu = ", TrangThai = 1, DatabaseName = "PTDVCSNBC1_2" });
        [Description("Phiếu sàng lọc dinh dưỡng")]
        PSLDDNB=280,//", TenPhieu = "", TrangThai = 1, DatabaseName = "PSLDDNB" });
        [Description("Phiếu xác nhận đồng ý xét nghiệm HIV")]
        PXNDYXNHIV=281,//", TenPhieu = "", TrangThai = 1, DatabaseName = "PXNDYXNHIV" });
        [Description("Bảng kiểm dụng cụ - vật tư y tế người bệnh làm thủ thuật")]
        BKDCVTYTNLTT=282,//", TenPhieu = "", TrangThai = 1, DatabaseName = "BKDCVTYTNLTT" });
        [Description("Bảng kiểm dụng cụ - Vật tư y tế phẫu thuật")]
        BKDCVTYPT=283,//", TenPhieu = "", TrangThai = 1, DatabaseName = "BKDCVTYPT" });
        [Description("Phiếu chuẩn bị và ban giao người bệnh trước phẫu thuật thủ thuật")]
        PCBVBGNBTPTTT= 284,//", TenPhieu = "", TrangThai = 1, DatabaseName = "PCBVBGNBTPTTT" });
        [Description("Phiếu thực hiện kỹ thuật phục hồi chức năng")]
        PTHKTPHCN=285,//", TenPhieu = ", TrangThai = 1, DatabaseName = "PTHKTPHCN" });
        [Description("Phiếu khám và chỉ định phục hồi chức năng")]
        PKVCDPHCN=286,//", TenPhieu = "", TrangThai = 1, DatabaseName = "PKVCDPHCN" });
        [Description("Phiếu phẫu thuật thể thủy tinh phối hợp cắt bè")]
        PTTTTCB=287,//", TenPhieu = "", TrangThai = 1, DatabaseName = "PhieuPhuatThuatTTTCB" });
        [Description("Bản cam kết Khoa phẫu thuật tim trẻ em")]
        BCKKPTTTE=288,//", TenPhieu = "", TrangThai = 1, DatabaseName = "BanCamKetKhoaPTTTE" });
        [Description("Giấy mời hội chẩn")]
        GMHC=289,//", TenPhieu = "", TrangThai = 1, DatabaseName = "GiayMoiHoiChan" });
        [Description("Bảng kiểm an toàn thủ thuật")]
        BKANTT=290,//", TenPhieu = "", TrangThai = 1, DatabaseName = "BangKiemAnToanThuThuat" });
        [Description("Bảng kiểm an toàn phẫu thuật")]
        BKANPT=291,//", TenPhieu = "", TrangThai = 1, DatabaseName = "BangKiemAnToanThuThuat" });
        [Description("Phiếu xét nghiệm đường máu mao mạch")]
        PXNMMM=292,//", TenPhieu = "", TrangThai = 1, DatabaseName = "PhieuXNMauMaoMach" });
        [Description("Thẻ dị ứng")]
        TDU=293,//", TenPhieu = "", TrangThai = 1, DatabaseName = "TheDiUng" });
        [Description("Phiếu khai thác tiền sử dị ứng")]
        PKTTSDU=294,//", TenPhieu = "", TrangThai = 1, DatabaseName = "PhieuKhaiThacTienSuDiUng" });
        [Description("Phiếu thử phản ứng thuốc")]
        PTPUT=295,//", TenPhieu = "", TrangThai = 1, DatabaseName = "PTPUT" });
        [Description("Biên bản hội chẩn trước phẫu thuật")]
        BBHCTPT=296,//", TenPhieu = "", TrangThai = 1, DatabaseName = "BBHCTPT" });
        [Description("Biên bản hội chẩn trước thủ thuật")]
        BBHCTTT=297,//", TenPhieu = "", TrangThai = 1, DatabaseName = "BBHCTTT" });
        [Description("Bảng theo dõi lọc máu 2")]
        BTDLM2=298,//", TenPhieu = "", TrangThai = 1, DatabaseName = "BangTheoDoiLocMau2" });
        [Description("Phiếu thủ thuật")]
        PTT=299,//", TenPhieu = "", TrangThai = 1, DatabaseName = "PhieuThuThuat" });
        [Description("Bảng theo dõi bệnh nhân hạ thân nhiệt")]
        BTDBNHTN=300,//", TenPhieu = "", TrangThai = 1, DatabaseName = "BangTDBNHaThanNhiet" });
        [Description("Phiếu sàng lọc dinh dưỡng bệnh nhân ngoại trú")]
        PSLDDBNNT=301,//", TenPhieu = "", TrangThai = 1, DatabaseName = "PhieuDGDinhDuongBNNgoaiTru" });
        [Description("Phiếu điều tra ca mắc covid-19")]
        PDTCMCV=302,//", TenPhieu = "", TrangThai = 1, DatabaseName = "PhieuDieuTraCaMacCovid" });
        [Description("Phiếu theo dõi truyền dịch")]
        PTDTD=303,//", TenPhieu = "", TrangThai = 1, DatabaseName = "PhieuChiTietTruyenDich2" });
        [Description("Bảng theo dõi lọc máu 3")]
        BTDLM3=304,//", TenPhieu = ", TrangThai = 1, DatabaseName = "BangTheoDoiLocMau3" });
        [Description("Bảng kê sử dụng thuốc - VTTH - Máu cho bệnh nhân")]
        BKSDTVTTHMCBN=305,//", TenPhieu = "", TrangThai = 1, DatabaseName = "BKSDTVTTHMCBN" });
        [Description("Phiếu theo dõi và chăm sóc người bệnh trong ngày")]
        PTDVCSNBTN=306,//", TenPhieu = "", TrangThai = 1, DatabaseName = "PTDVCSNBTN" });
        [Description("Phiếu sàng lọc dinh dưỡng bệnh nhân nhi ngoại trú")]
        PSLDDBNNNT=307,//", TenPhieu = "", TrangThai = 1, DatabaseName = "PhieuSLDDBNNhiNgoaiTru" });
        [Description("Phiếu sàng lọc và đánh giá tình trạng dinh dưỡng bệnh nhân nội trú")]
        PSLVDGTTDDBNNT=308,//", TenPhieu = "", TrangThai = 1, DatabaseName = "PhieuSLVDGTTDDBNNoiTru" });
        [Description("Giấy cam đoạn chấp nhận  thủ thuật tim mạch can thiệp và gây mê hồi sức")]
        CDCNTTTMGMHS=309,//", TenPhieu = "", TrangThai = 1, DatabaseName = "CamDoanChapNhanTTTMVGMHS" });
        [Description("Giấy cam kết điều trị")]
        GCKDT=310,//", TenPhieu = "", TrangThai = 1, DatabaseName = "GiayCamKetDieuTri" });
        [Description("Mẫu phiếu phân tích sử dụng thuốc")]
        MPPTSDT=311,//", TenPhieu = "", TrangThai = 1, DatabaseName = "MauPhieuPTSDThuoc" });
        [Description("Kế hoạch chăm sóc người bệnh covid-19")]
        KHCSNBCV=312,//", TenPhieu = "", TrangThai = 1, DatabaseName = "KHCSNBCovid19" });
        [Description("Giấy cam đoạn chấp nhận phẫu thuật thủ thuật và gây mê hồi sức")]
        CDCNPTTTGMHS_BN=313,//", TenPhieu = "", TrangThai = 1, DatabaseName = "CamDoanChapNhanPTTTGMHS3" });
        [Description("Biên bản xác nhận bệnh nhân bỏ viện")]
        BBXNBNBV=314,//", TenPhieu = ", TrangThai = 1, DatabaseName = "BienBanXacNhanBNBoVien" });
        [Description("Phiếu xác nhận bệnh nhân không có mặt tại khoa phòng")]
        PXNBNKCMTKP=315,//", TenPhieu = "", TrangThai = 1, DatabaseName = "PXNBNKCMTKP" });
        [Description("Giấy cam đoan chấp nhận chạy thận nhân tạo")]
        GCDCTCTNT=316,//", TenPhieu = "", TrangThai = 1, DatabaseName = "GCDCTCTNT" });
        [Description("Bảng kiểm an toàn thủ thuật và can thiệp tim mạch")]
        BKANTTCTTM2=317,//", TenPhieu = "", TrangThai = 1, DatabaseName = "BangKiemAnToanTT_CTTM2" });
        [Description("Giấy cam đoan chấp nhận sử dụng dịch vụ theo yêu cầu")]
        GCDCNSDDVTYC=318,//", TenPhieu = "", TrangThai = 1, DatabaseName = "GiayCamDoanCNSDDVTYC" });
        [Description("Giấy cam đoan chấp nhận phẫu thuật, thủ thuật và gây mê hồi sức 4")]
        GCDCNPTTTGMHS4=319,//", TenPhieu = "", TrangThai = 1, DatabaseName = "GiayCamDoanCNPTTTGMHS4" });
        [Description("Phiếu theo dõi bệnh nhân truyền thuốc")]
        PTDBNTT=320,//", TenPhieu = "", TrangThai = 1, DatabaseName = "PhieuTDBNTruyenThuoc" });
        [Description("Phiếu khám gây mê trước phẫu thuật thủ thuật")]
        PKGMTPTTT=321,//", TenPhieu = "", TrangThai = 1, DatabaseName = "PhieuKhamGayMeTruocPTTT" });
        [Description("Bảng kiểm tra dụng cụ")]
        BKTDC=322,//", TenPhieu = "", TrangThai = 1, DatabaseName = "BangKiemTraDungCu" });
        [Description("Báo cáo tai biến không mong muốn liên quan đến truyền máu")]
        BCTBTM=323,//", TenPhieu = "", TrangThai = 1, DatabaseName = "BaoCaoTaiBienTruyenMau" });
        [Description("Giấy cam đoan chấp nhận sử dụng thuốc trong điều trị cho người nhà bệnh nhân")]
        GCDCNSDTTDTCNN=324,//", TenPhieu = "", TrangThai = 1, DatabaseName = "NguoiNhaCamDoanSDTTDT" });
        [Description("Phiếu theo dõi và điều trị lọc máu")]
        PTDVDTLM=325,//", TenPhieu = "", TrangThai = 1, DatabaseName = "PTDVDTLM" });
        [Description("Phiếu tư vấn, hướng dẫn - giáo dục sức khỏe")]
        PTVHDGDSK=326,//", TenPhieu = "", TrangThai = 1, DatabaseName = "PTVHDGDSK" });
        [Description("Phiếu theo dõi bệnh nhân Covid")]
        PTDBNC=327,//", TenPhieu = "", TrangThai = 1, DatabaseName = "PhieuTheoDoiBenhNhanCovid" });
        [Description("Giấy cam đoan chấp nhận thủ thuật tim mạch can thiệp và gây mê hồi sức")]
        GCDCNTTTMCTVGMHS=328,//", TenPhieu = "", TrangThai = 1, DatabaseName = "GCDCNTTTMCTVGMHS" });
        [Description("Phiếu chuyển dạ 2")]
        CD2=329,//", TenPhieu = "", TrangThai = 1, DatabaseName = "BIEUDOCHUYENDA2" });
        [Description("Giấy cam đoan chấp nhận phẫu thuật, thủ thuật và gây mê hồi sức 5")]
        GCDCNPTTTGMHS5=330,//", TenPhieu = "", TrangThai = 1, DatabaseName = "GiayCamDoanCNPTTTGMHS5" });
        [Description("Phiếu kiểm điểm tử vong")]
        PKDTV=331,//", TenPhieu = "", TrangThai = 1, DatabaseName = "PhieuKiemDiemTuVong" });
        [Description("Bảng kiểm an toàn điện quang")]
        BKATDQ=332,//", TenPhieu = "", TrangThai = 1, DatabaseName = "BangKiemAnToanDienQuang" });
        [Description("Phiếu sàng lọc đánh giá dinh dưỡng trẻ em")]
        PSLDGDDTE=333,//", TenPhieu = "", TrangThai = 1, DatabaseName = "PhieuSangLocDGDDTE" });
        [Description("Giấy chứng nhận thương tích")]
        GCNTT=334,//", TenPhieu = "", TrangThai = 1, DatabaseName = "GiayChungNhanThuongTich" });
        [Description("Phiếu theo dõi và chăm sóc người bệnh trong ngày")]
        PTDCSBNTN=335,//", TenPhieu = "", TrangThai = 1, DatabaseName = "PhieuTheoDoiVaChamSocBNTN" });
        [Description("Phiếu sàng lọc dinh dưỡng cho phụ nữ mang thai")]
        PSLDDCPNMT=336,//", TenPhieu = "", TrangThai = 1, DatabaseName = "PhieuSLDDChoPNMT" });
        [Description("Giấy cam kết đồng ý điều trị bệnh lý mạch cảnh")]
        GCKDYDTTBLMC=337,//", TenPhieu = "", TrangThai = 1, DatabaseName = "GiayCamKetDongYDTBLMC" });
        [Description("Bảng kiểm tra trước siêu âm tim qua thực quản")]
        BKTTSATQTQ=338,//", TenPhieu = "", TrangThai = 1, DatabaseName = "BangKiemTraTruocSATQTQ" });
        [Description("Giấy cam kết đồng ý điều trị bệnh lý rối loạn nhịp")]
        GCKDYDTBLRLN=339,//", TenPhieu = "", TrangThai = 1, DatabaseName = "KhaoSatDienSinhLyCDVDT" });
        [Description("Điều trị rối loạn nhịp tim bằng năng lượng sóng có tần số radio")]
        DTRLNTBRF=340,//", TenPhieu = "", TrangThai = 1, DatabaseName = "DieuTriRoiLoanNTBangRF" });
        [Description("Phiếu đo chức năng hô hấp")]
        PDCNHH=341,//", TenPhieu = "", TrangThai = 1, DatabaseName = "PhieuDoChucNangHoHap" });
        [Description("Phiếu xác nhận đúng người bệnh")]
        PXNDNB=342,//", TenPhieu = "", TrangThai = 1, DatabaseName = "PhieuXacNhanDungNguoiBenh" });
        [Description("Giấy xác nhận đã tiêm vắc xin covid-19")]
        GXNDTCovid=343,//", TenPhieu = "", TrangThai = 1, DatabaseName = "GXNDTCovid" });
        [Description("Báo cáo phản ứng có hại của thuốc")]
        BCPUCHCT=344,//", TenPhieu = "", TrangThai = 1, DatabaseName = "BaoCaoPhanUngCoHaiCuaThuoc" });
        [Description("Thẻ cảnh cáo phản ứng có hại của người bệnh")]
        TCCPUCH=345,//", TenPhieu = "", TrangThai = 1, DatabaseName = "TCCPUCH" });
        [Description("Đơn xin xác nhận nằm viện")]
        DXXNNV=346,//", TenPhieu = "", TrangThai = 1, DatabaseName = "DonXinXacNhanNamVien" });
        [Description("Giấy hẹn siêu âm tim qua thực quản")]
        GHSATQTQ=347,//", TenPhieu = "", TrangThai = 1, DatabaseName = "GiayHenSieuAmTimQTQ" });
        [Description("Giấy cam đoan làm siêu âm tim qua thực quản")]
        GCDLSATQTQ=348,//", TenPhieu = "", TrangThai = 1, DatabaseName = "GiayCamDoanLSATQTQ" });
        [Description("Giấy hẹn đeo máy Holter")]
        GHDMHOLTER=349,//", TenPhieu = "", TrangThai = 1, DatabaseName = "GiayHenDeoMayHOLTER" });
        [Description("Phiếu công khai dịch vụ khám chữa bệnh nội trú theo ngày")]
        PCKDVKCBNTTN=350,//", TenPhieu = "", TrangThai = 1, DatabaseName = "PhieuCongKhaiDichVuKCBNTTN" });
        [Description("Phiếu xét nghiệm tai biến không mong muốn liên quan đến truyền máu")]
        PXNTBKMMTM=351,//", TenPhieu = ", TrangThai = 1, DatabaseName = "PhieuXNTBKMMLienQuanTM" });
        [Description("Phiếu theo dõi và chăm sóc nội khoa")]
        PTDVCSNOIKHOA=352,//", TenPhieu = "", TrangThai = 1, DatabaseName = "PhieuTDVCSBNNoiKhoa" });
        [Description("Phiếu phẫu thuật bề mặt nhãn cầu")]
        PPTBMNC=353,//", TenPhieu = "", TrangThai = 1, DatabaseName = "PhieuPhauThuatBeMatNhanCau" });
        [Description("Giấy cam đoan làm điện tâm đồ gắng sức")]
        GCDLDTDGS=354,//", TenPhieu = "", TrangThai = 1, DatabaseName = "GiayCamDoanLDTDGS" });
        [Description("Phiếu theo dõi và chăm sóc ngoại khoa")]
        PTDVCSNGOAIKHOA=355,//", TenPhieu = ", TrangThai = 1, DatabaseName = "PhieuTDVCSBNNgoaiKhoa" });
        [Description("Phiếu theo dõi và chăm sóc người bệnh tại khoa cấp cứu")]
        PTDCSNBTKCC=356,//", TenPhieu = "", TrangThai = 1, DatabaseName = "PhieuTDCSNBTaiKhoaCapCuu" });
        [Description("Phiếu theo dõi và chăm sóc sản")]
        PTDVCSSAN=357,//", TenPhieu = ", TrangThai = 1, DatabaseName = "PhieuTDVCSBNSan" });
        [Description("Chuẩn bị bệnh nhân chụp MSCT")]
        CBBNCMSCT=358,//", TenPhieu = "", TrangThai = 1, DatabaseName = "ChuanBiBenhNhanChupMSCT" });
        [Description("Phiếu theo dõi và chăm sóc răng hàm mặt")]
        PTDVCSRHM=359,//", TenPhieu = "", TrangThai = 1, DatabaseName = "PhieuTDVCSBNRHM" });
        [Description("Phiếu theo dõi và chăm sóc khoa mắt")]
        PTDVCSKM=360,//", TenPhieu = "", TrangThai = 1, DatabaseName = "PhieuTDVCSBNKhoaMat" });
        [Description("Giấy cam đoan đeo máy Holter điện tâm đồ - Holter huyết áp")]
        GCDDMHDTDHA=361,//", TenPhieu = "", TrangThai = 1, DatabaseName = "GiayCamDoanDeoMayHolterDTDHA" });
        [Description("Giấy cam kết bệnh nhân xin ra viện")]
        GCKBNXRV=362,//", TenPhieu = "", TrangThai = 1, DatabaseName = "GiayCamKetBenhNhanXinRaVien" });
        [Description("Giấy cam đoan chấp nhận thủ thuật can thiệp tĩnh mạch chi")]
        GCDCNTTCTTMC=363,//", TenPhieu = "", TrangThai = 1, DatabaseName = "GiayCamDoanChapNhanTTCTTMC" });
        [Description("Giấy cam kết chấp nhận thủ thuật đặt Catheter động mạch")]
        GCKCNTTDCDM=364,//", TenPhieu = ", TrangThai = 1, DatabaseName = "GiayCamKetChapNhanTTDCDM" });
        [Description("Phiếu chỉ định")]
        B_CHIDINH=365,//", TenPhieu = "", LoaiPhieu = 1, TrangThai = 0, DatabaseName = "b_chidinh", NgayTao = "ngay", NgaySua = "ngayud" });
        [Description("Phiếu truyền máu 1")]
        BL_XUATNOIVIENDS = 366,//", TenPhieu = "", LoaiPhieu = 1, TrangThai = 0, DatabaseName = "bl_xuatnoiviends", NgayTao = "ngay", NgaySua = "ngayud" });
        [Description("Phiếu truyền máu 2")]
        BL_PHIEUTRUYENMAUDS = 367,//", TenPhieu = "", LoaiPhieu = 1, TrangThai = 0, DatabaseName = "bl_phieutruyenmauds", NgayTao = "ngay", NgaySua = "ngayud" });
        [Description("Kết quả xét nghiệm")]
        L_KETQUA=368,//", TenPhieu = "", LoaiPhieu = 1, TrangThai = 0, DatabaseName = "l_ketqua", NgayTao = "ngay", NgaySua = "ngayud" });
        [Description("Tờ điều trị")]
        P_TODIEUTri=369,//", TenPhieu = "", LoaiPhieu = 1, TrangThai = 0, DatabaseName = "p_todieutri", NgayTao = "ngay", NgaySua = "ngayud" });
        [Description("Đơn thuốc")]
        P_TOATHUOCLL=370,//", TenPhieu = "", LoaiPhieu = 1, TrangThai = 0, DatabaseName = "p_toathuocll", NgayTao = "ngay", NgaySua = "ngayud" });
        [Description("Giấy ra viện")]
        P_GIAYRAVIEN=371,//", TenPhieu = "", LoaiPhieu = 1, TrangThai = 0, DatabaseName = "p_giayravien", NgayTao = "ngay", NgaySua = "ngayud" });
        [Description("Giấy chuyển viện")]
        P_GIAYCHUYENVIEN=372,//", TenPhieu = "", LoaiPhieu = 1, TrangThai = 0, DatabaseName = "p_giaychuyenvien", NgayTao = "ngay", NgaySua = "ngayud" });
        [Description("Giấy nghỉ ốm")]
        P_GIAYNGHIOM=373,//", TenPhieu = "", LoaiPhieu = 1, TrangThai = 0, DatabaseName = "p_giaynghiom", NgayTao = "ngay", NgaySua = "ngayud" });
        [Description("Phiếu chăm sóc")]
        P_DAUSINHTON=374,//", TenPhieu = ", LoaiPhieu = 1, TrangThai = 0, DatabaseName = "p_dausinhton", NgayTao = "ngay", NgaySua = "ngayud" });
        [Description("Biên bản hội chẩn")]
        P_HOICHAN=375,//", TenPhieu = "", LoaiPhieu = 1, TrangThai = 0, DatabaseName = "p_hoichan", NgayTao = "ngay", NgaySua = "ngayud" });
        [Description("Phiếu sơ kết 15")]
        P_PHIEUSOKET15=376,//", TenPhieu = "", LoaiPhieu = 1, TrangThai = 0, DatabaseName = "p_phieusoket15", NgayTao = "ngay", NgaySua = "ngayud" });
        [Description("Giấy chứng sinh")]
        P_TRESOSINH=377,//", TenPhieu = "", LoaiPhieu = 1, TrangThai = 0, DatabaseName = "p_tresosinh", NgayTao = "ngay", NgaySua = "ngayud" });
        [Description("Giấy thử phản ứng thuốc")]
        p_GIAYTHUPHANUNGTHUOC=378,//", TenPhieu = "", LoaiPhieu = 1, TrangThai = 0, DatabaseName = "p_giaythuphanungthuoc", NgayTao = "ngay", NgaySua = "ngayud" });
        [Description("Phiếu phẫu thuật thủ thuật")]
        P_PTTT =379,//", TenPhieu = "", LoaiPhieu = 1, TrangThai = 0, DatabaseName = "p_pttt", NgayTao = "ngay", NgaySua = "ngayud" });
        [Description("Hội chẩn phẫu thuật")]
        P_HOICHANPHAUTHUAT=380,//", TenPhieu = "", LoaiPhieu = 1, TrangThai = 0, DatabaseName = "p_hoichanphauthuat", NgayTao = "ngay", NgaySua = "ngayud" });
        [Description("Phiếu truyền dịch")]
        P_PHIEUTRUYENDICH=381,//", TenPhieu = "", LoaiPhieu = 1, TrangThai = 0, DatabaseName = "p_phieutruyendich", NgayTao = "ngay", NgaySua = "ngayud" });
        [Description("Kết quả CDHA")]
        R_KETQUALL=382,//", TenPhieu = "", LoaiPhieu = 1, TrangThai = 0, DatabaseName = "r_ketquall", NgayTao = "ngay", NgaySua = "ngayud" });
        [Description("Kết quả kháng sinh")]
        L_KETQUAKHANGSINH=383,//", TenPhieu = ", LoaiPhieu = 1, TrangThai = 0, DatabaseName = "l_ketquakhangsinh", NgayTao = "ngay", NgaySua = "ngayud" });
        [Description("Công khai thuốc")]
        H2_CKT=384,//", TenPhieu = "", LoaiPhieu = 1, TrangThai = 0, DatabaseName = "", NgayTao = "ngay", NgaySua = "ngayud" });
        [Description("Đơn thuốc gây nghiện")]
        H2_DTGN=385,//", TenPhieu = "", LoaiPhieu = 1, TrangThai = 0, DatabaseName = "", NgayTao = "ngay", NgaySua = "ngayud" });
        [Description("Đơn thuốc hướng thần")]
        H2_DTHT=386,//", TenPhieu = "", LoaiPhieu = 1, TrangThai = 0, DatabaseName = "", NgayTao = "ngay", NgaySua = "ngayud" });
        [Description("Phiếu khám vào viện")]
        H2_PKVV=387,//", TenPhieu = "", LoaiPhieu = 1, TrangThai = 0, DatabaseName = "", NgayTao = "ngay", NgaySua = "ngayud" });
        [Description("Giấy chứng nhận phẫu thuật")]
        H2_GCNPT=388,//", TenPhieu = "", LoaiPhieu = 1, TrangThai = 0, DatabaseName = "", NgayTao = "ngay", NgaySua = "ngayud" });
        [Description("Phiếu đồng ý xét nghiệm HIV")]
        H2_PDYXNHIV=389,//", TenPhieu = "", LoaiPhieu = 1, TrangThai = 0, DatabaseName = "", NgayTao = "ngay", NgaySua = "ngayud" });
        [Description("Giấy chứng nhận thương tích")]
        H2_GCNTT=390,//", TenPhieu = "", LoaiPhieu = 1, TrangThai = 0, DatabaseName = "", NgayTao = "ngay", NgaySua = "ngayud" });
        [Description("Phiếu thanh toán ra viện")]
        H2_PTTRV=391,//", TenPhieu = "", LoaiPhieu = 1, TrangThai = 0, DatabaseName = "", NgayTao = "ngay", NgaySua = "ngayud" });
        [Description("Phiếu khám sức khỏe")]
        H2_PKSK=392,//", TenPhieu = "", LoaiPhieu = 1, TrangThai = 0, DatabaseName = "", NgayTao = "ngay", NgaySua = "ngayud" });
        [Description("Giấy chứng nhận nằm viện")]
        H2_GCNNV=393,//", TenPhieu = "", LoaiPhieu = 1, TrangThai = 0, DatabaseName = "", NgayTao = "ngay", NgaySua = "ngayud" });
        [Description("Giấy cam đoan phẫu thuật thủ thuật")]
        H2_GCDPTTT=394,
        [Description("Phiếu khai thác tiền sử dị ứng")]
        H2_PKTTSDU=395,
        [Description("Bệnh án ung bướu")]
        BAUB = 396,
        [Description("Bệnh án xã phường")]
        BAXP = 397,
        [Description("Bệnh án ngoại trú tim")]
        BANgTruTIM = 398,
        [Description("Bệnh án bỏng")]
        BABONG = 399,
        [Description("Bệnh án CMU")]
        BACMU = 400,
        [Description("Bệnh án da liễu")]
        BADL = 401,
        [Description("Bệnh án da liễu TW")]
        BADLTW = 402,
        [Description("Bệnh án điều trị ban ngày")]
        BADTBN = 403,
        [Description("Bệnh án huyết học truyền máu")]
        BAHHTM = 404,
        [Description("Bệnh án lưu cấp cứu")]
        BALCC = 405,
        [Description("Bệnh án mắt")]
        BAM = 406,
        [Description("Bệnh án mắt bán phần trước")]
        BAMBPT = 407,
        [Description("Bệnh án mắt chấn thương")]
        BAMCT = 408,
        [Description("Bệnh án mắt đắy mắt")]
        BAMDM = 409,
        [Description("Bệnh án mắt glocom")]
        BAMGlocom = 410,
        [Description("Bệnh án mắt lác")]
        BAMLac = 411,
        [Description("Bệnh án mắt trẻ em")]
        BAMTE = 412,
        [Description("Bệnh án ngoại khoa")]
        BANgK = 413,
        [Description("Bệnh án ngoại trú")]
        BANgTru = 414,
        [Description("Bệnh án ngoại trú - Bệnh vải nến thông thường")]
        BANgTruBVNTT = 415,
        [Description("Bệnh án ngoại trú - Á vải nến")]
        BANgTruAVN = 416,
        [Description("Bênh án ngoại trú mắt")]
        BANgTruMat = 417,
        [Description("Bệnh án ngoại trú PHCN")]
        BANgTruPHCN = 418,
        [Description("Bệnh án ngoại trú TMH")]
        BANgTruTMH = 419,
        [Description("Bệnh án ngoại trú RHM")]
        BANgTruRHM = 420,
        [Description("Bệnh án ngoại trú YHCT")]
        BANgTruYHCT = 421,
        [Description("Bệnh án nhi khoa")]
        BANhiKhoa = 422,
        [Description("Bệnh án nội khoa")]
        BANoiKhoa = 423,
        [Description("Bệnh án nội trú YHCT")]
        BANoiTruYHCT = 424,
        [Description("Bệnh án phá thai I")]
        BAPhaThaiI = 425,
        [Description("Bệnh án phá thai II")]
        BAPhaThaiII = 426,
        [Description("Bệnh án phá thai III")]
        BAPhaThaiIII = 427,
        [Description("Bệnh án PHCN II")]
        BAPHCNII = 428,
        [Description("Bệnh án PHCN nhi")]
        BAPHCNNhi = 429,
        [Description("Bệnh án PHCN")]
        BAPHCN = 430,
        [Description("Bệnh án PHCN- YHCT")]
        BAPHCNYHCT = 431,
        [Description("Bệnh án phụ khoa")]
        BAPK = 432,
        [Description("Bệnh án RHM")]
        BARHM = 433,
        [Description("Bệnh án sản khoa")]
        BASK = 434,
        [Description("Bệnh án sơ sinh")]
        BASS = 435,
        [Description("Bệnh án TMH")]
        BATMH = 436,
        [Description("Bệnh án tâm thần")]
        BATT = 437,
        [Description("Bệnh án tay chân miệng")]
        BATCM = 438,
        [Description("Bệnh án thận nhân tạo")]
        BATNT = 439,
        [Description("Bệnh án tim")]
        BATim = 440,
        [Description("Bệnh án truyền nhiễm")]
        BATNhiem = 441,
        [Description("Bệnh án truyền nhiễm II")]
        BATNhiemII = 442,
        [Description("Giấy cam kết thiếu tiền phẫu thuật can thiệp")]
        GCKTTPTCT = 443,
        [Description("Giấy cam đoan đồng ý tiêm thuốc đối quang từ")]
        GCDDYTTDQT = 444,
        [Description("Giấy cam kết chấp nhận thủ thuật đặt ống nội khí quản")]
        GCKCNTTDONKQ = 445,
        [Description("Giấy cam kết chấp nhận thủ thuật đặt Catheter tĩnh mạch trung tâm")]
        GCKCNTTDCTMTT = 446,
        [Description("Giấy cam kết chấp nhận thủ thuật shock điện")]
        GCKCNTTSD = 447,
        [Description("Phiếu sàng lọc và đánh giá tình trạng dinh dưỡng người bệnh nội trú")]
        PSLVDGTTDDNBNT = 448,
        [Description("Bảng kê vật tư tiêu hao phòng phẫu thuật, thủ thuật")]
        BKVTTHPTTT = 449,
        [Description("Bảng kê thuốc trong phòng phẫu thuật, thủ thuật")]
        BKTPTTT = 450,
        [Description("Bảng kê trước khi mỗ mẫu 2")]
        BKTKM2 = 451,
        [Description("Bảng kê trước khi mỗ mẫu 3")]
        BKTKM3 = 452,
        [Description("Bảng kiểm an toàn thủ thuật và can thiệp tim mạch (mẫu 1)")]
        BKANTTCTTM = 453,
        [Description("Bảng kiểm an toàn phẫu thuật (mẫu 2)")]
        BKATPT2 = 454,
        [Description("Bảng tầm soát bệnh nhân nguy cơ với chất tương phản")]
        BTSBNNCCTP = 455,
        [Description("Phiếu đánh giá tình trạng dinh dưỡng trên 18 tuổi")]
        PDGTTDD18 = 456,
        [Description("Phiếu yêu cầu sử dụng kháng sinh hội chẩn - phê duyệt")]
        PYCSDKSHCPD = 457,
        [Description("Đơn đề nghị thực kỹ thuật hỗ trợ sinh sản")]
        DDNTHKTHTSS = 458,
        [Description("Phiếu chẩn đoán nguyên nhân tử vong")]
        PCDNNTV = 459,
        [Description("Biên bản bàn giao bệnh nhân công bố điều trị khỏi covid-19")]
        BBBGBNDTKCOVID = 460,
        [Description("Giấy cam kết chấp nhận thủ thuật chọc dịch màng tim / màng phổi")]
        GCKCNTTCDMTMP = 461,
        [Description("Giấy đề nghị thực hiện cách ly phòng chống dịch COVID-19")]
        GDNTHCLPCDCOVID = 462,
        [Description("Bản cam kết sau khi ra viện điều trị COVID-19")]
        BCKCOVID = 463,
        [Description("Phiếu cam kết thụ tinh ống nghiệm")]
        CKTTON = 464,
        [Description("Giấy cam kết bệnh nhân chuyển viện")]
        GCKBNCV = 465,
        [Description("Phiếu xét nghiệm giải phẫu bệnh sinh thiết")]
        GPBST = 466,
        [Description("Thông báo điều trị covid thành công")]
        TBDTCTC = 467,
        [Description("Giấy báo tử")]
        GBT = 468,
        [Description("Cam kết sử dụng giá dịch vụ trong thụ tinh ông nghiệm")]
        CKSDGDVTTTON = 469,
        [Description("Giấy chứng nhận phẫu thuật")]
        GCNPT = 470,
        [Description("Cam kết bơm tinh trùng vào buồng tử cung")]
        CKBTTVBTC = 471,
        [Description("Bệnh án ngoại trú trung tâm hỗ trợ sinh sản")]
        BANgoaiTruHTSS = 472,
        [Description("BẢN CAM KẾT THỤ TINH TRONG ỐNG NGHIỆM VỚI PHƯƠNG PHÁP IVF / ICSI / XIN TRỨNG")]
        BCKTTTONIVF = 473,
        [Description("BỆNH ÁN ĐIỀU TRỊ NGOẠI TRÚ BỆNH VIÊM BÌ CƠ")]
        BANTVBC = 474,
        [Description("BỆNH ÁN ĐIỀU TRỊ NGOẠI TRÚ BỆNH LUPUS BAN ĐỎ HỆ THỐNG")]
        BANTLBDHT = 475,
        [Description("Bảng câu hỏi sàng lọc về rượu")]
        BCHSLVR = 476,
        [Description("THANG ĐÁNH GIÁ TÓM TẮT CÁC TRIỆU CHỨNG LÂM SÀNG CỦA TRẠNG THÁI CAI RƯỢU")]
        TDGTTCR = 477,
        [Description("BỆNH ÁN ĐIỀU TRỊ NGOẠI TRÚ PEMPHIGOID")]
        BANTP = 478,
        [Description("BỆNH ÁN ĐIỀU TRỊ NGOẠI TRÚ BỆNH VẢY PHẤN ĐỎ NANG LÔNG")]
        BABVPDNL = 479,
        [Description("Phiếu đánh giá dinh dưỡng người bệnh nhập viện (SGA)")]
        PDGDDNBNV2 = 480,//", TenPhieu = "", TrangThai = 1, DatabaseName = "PhieuDanhGiaDDNBNV" });
        [Description("Bệnh án điều trị ngoại trú LuPus ban đỏ mạn tính")]
        BANgoaiTruLuPusBDMT = 481,
        [Description("Phiếu phẫu thuật ghép giác mạc")]
        PPTGGM = 482,
        [Description("BỆNH ÁN ĐIỀU TRỊ NGOẠI TRÚ BỆNH VẢY NẾN THỂ MỦ")]
        BANTBVNTM = 483,
        [Description("PHIẾU THEO DÕI THỰC HIỆN LỌC MÀNG BỤNG")]
        PTDTHLMB = 484,
        [Description("Phiếu theo dõi và điều trị thận nhân tạo")]
        PTDVDTTNT = 485,
        [Description("Giấy thử phản ứng thuốc")]
        GTPUT = 486,
        [Description("Phiếu đăng ký sử dụng dịch vụ")]
        PDKSDDV = 487,
        [Description("ĐÁNH GIÁ NGƯỜI BỆNH NHẬP VIỆN VÀ KẾ HOẠCH CHĂM SÓC")]
        DGNBNVVKHCS = 488,
        [Description("Bảng đánh giá tình trạng người bệnh mới vào khoa")]
        BDGTTNBMVK = 489,
        [Description("BỆNH ÁN ĐIỀU TRỊ NGOẠI TRÚ BỆNH DUHRING BROCQ")]
        BANTBDB = 490,
        [Description("Bảng kiểm tránh nhầm lẫn bệnh nhân khi cung cấp dịch vụ 2")]
        BKTNLBNKCCDV = 491,
        [Description("Phiếu tóm tắt bệnh án")]
        PTTBA = 492,
        [Description("KẾ HOẠCH CHĂM SÓC NGƯỜI BỆNH COVID-19")]
        KHCSNBCOVID19 = 493,
        [Description("PHIẾU ĐIỀU TRỊ CÓ KIỂM SOÁT")]
        PDTCKS = 494,
        [Description("BỆNH ÁN ĐÁI THÁO ĐƯỜNG")]
        BADTD = 495,
        [Description("TÁI KHÁM ĐÁI THÁO ĐƯỜNG")]
        TKDTD = 496,
        [Description("ĐIỀU TRỊ NGOẠI TRÚ BỆNH UNG THƯ HẮC TỐ")]
        BAUTDHT = 497,
        [Description("PHIẾU TÁI KHÁM UNG THƯ DA HẮC TỐ")]
        PTKUTHT = 498,
        [Description("PHIẾU ĐÁNH GIÁ TÌNH TRẠNG DINH DƯỠNG (SGA)")]
        PDGTTDDSGA = 499,
        [Description("BẢNG KIỂM TRƯỚC TIÊM CHỦNG ĐỐI VỚI TRẺ SƠ SINH")]
        BKTTCDVTSS = 500,
        [Description("PHIẾU KIỂM SOÁT NGƯỜI BỆNH TRƯỚC MỔ")]
        PKSNBTM = 501,
        [Description("ĐIỀU TRỊ NGOẠI TRÚ BỆNH UNG THƯ DA KHÔNG HẮC TỐ")]
        BAUTDKHT = 502,
        [Description("PHIẾU TÁI KHÁM UNG THƯ DA KHÔNG HẮC TỐ")]
        PTKUTDKHT = 503,
        [Description("ĐIỀU TRỊ NGOẠI TRÚ BỆNH PEMPHIGUS")]
        BADTNTBP = 504,
        [Description("ĐIỀU TRỊ NGOẠI TRÚ BỆNH VẢY NẾN THỂ KHỚP")]
        BADTNTVNTK = 505,
        [Description("ĐIỀU TRỊ NGOẠI TRÚ BỆNH HỘI CHỨNG TRÙNG LẮP")]
        BADTNTHCTL = 506,
        [Description("SỔ MỜI HỘI CHẨN")]
        SMHC = 507,
        [Description("BẢNG THEO DÕI CHĂM SÓC NGƯỜI BỆNH KHOA BNĐ")]
        BTDCSNBKBND = 508,
        [Description("BẢNG THEO DÕI CHĂM SÓC NGƯỜI BỆNH HỒI SỨC TÍCH CỰC KHOA NGOẠI")]
        BTDCSNBHSTCNK = 509,
        [Description("BẢNG THEO DÕI CHĂM SÓC NGƯỜI BỆNH HỒI SỨC TÍCH CỰC KHOA NỘI")]
        BTDCSNBHSTCKN = 510,
        [Description("PHIẾU ĐIỀU TRỊ BỆNH NHÂN LAO KHÁNG THUỐC")]
        PDTBNLKT = 511,
        [Description("QUẢN LÝ, THEO DÕI VÀ ĐIỀU TRỊ CÓ KIỂM SOÁT STENT ĐỘNG MẠCH VÀNH")]
        BASDMV = 512,
        [Description("TÁI KHÁM BỆNH ÁN STENT ĐỘNG MẠCH VÀNH")]
        TKBASDMV = 513,
        [Description("QUẢN LÝ, THEO DÕI VÀ ĐIỀU TRỊ CÓ KIỂM SOÁT THIẾU MÁU CƠ TIM CỤC BỘ")]
        TMCTCB = 514,
        [Description("TÁI KHÁM BỆNH ÁN THIẾU MÁU CƠ TIM CỤC BỘ")]
        TKTMCTCB = 515,
        [Description("THEO DÕI VÀ ĐIỀU TRỊ BỆNH BASEDOW")]
        BATDDTBBD = 516,
        [Description("TÁI KHÁM BỆNH ÁN THEO DÕI VÀ ĐIỀU TRỊ BỆNH BASEDOW")]
        TKBATDDTBBD = 517,
        [Description("Phiếu theo dõi và chăm sóc răng phụ khoa")]
        PTDVCSPK = 518,
        [Description("Biên bản xác nhận người bệnh tử vong")]
        BBXNNBTV = 519,// TenPhieu = "", TrangThai = 1, DatabaseName = "BienBanXacNhanNBTuVong", NgayTao = "", NgaySua = "", NguoiTao = "", NguoiSua = "" });
        [Description("QUẢN LÝ, THEO DÕI VÀ ĐIỀU TRỊ BỆNH VIÊM GAN SIÊU VI B MẠN TÍNH")]
        BAVGBMT = 520,
        [Description("TÁI KHÁM BỆNH VIÊM GAN SIÊU VI B MẠN TÍNH")]
        TKBAVGBMT =521,
        [Description("QUẢN LÝ BỆNH PHỔI TẮC NGHẼN MẠN TÍNH")]
        BAPTNMT = 522,
        [Description("BẢNG KÊ THUỐC DÙNG TRONG GÂY MÊ")]
        BKTDTGM = 523,
        [Description("Giấy Chuyển Viện Bệnh Tay Chân Miệng")]
        GCVBTCM = 524,
        [Description("Bảng Kê Thuốc Đã Dùng")]
        BKTDD = 525,
        [Description("Bảng kê thuốc trong gây mê")]
        BKTTGM = 526,
        [Description("PHIẾU CHUẨN BỊ VÀ BÀN GIAO NGƯỜI BỆNH TRƯỚC PHẪU THUẬT THỦ THUẬT")]
        CBBGNBTPTTT = 527,//", TenPhieu = "", TrangThai = 1, DatabaseName = "PhieuCBBGNBTruocPTTT" });
        [Description("TÁI KHÁM PHỔI TẮC NGHẼN MẠN TÍNH")]
        TKBAPTNMT = 532,
        [Description("Bảng kiểm vật tư tiêu hao trong gây mê")]
        BKVTTHTGM = 528,//", TenPhieu = "", TrangThai = 1, DatabaseName = "PhieuCBBGNBTruocPTTT" });
        [Description("THEO DÕI, QUẢN LÝ & ĐIỀU TRỊ CÓ KIỂM SOÁT BỆNH TĂNG HUYẾT ÁP")]
        BATHA = 529,
        [Description("TÁI KHÁM BỆNH TĂNG HUYẾT ÁP")]
        TKBATHA = 534,
        [Description("Bảng kiểm dụng cụ, gạc trong phẫu thuật")]
        BKDCGTPT =531,
        [Description("PHIẾU DIỄN TIẾN ĐIỀU TRỊ")]
        PDTDT = 532,
        [Description("Phiếu hội chẩn phẫu thuật")]
        PHCPT = 536,//", TenPhieu = "", TrangThai = 1, DatabaseName = "PhieuHoiChanPhauThuat" });
        [Description("GIẤY ĐĂNG KÝ BAO PHÒNG DỊCH VỤ")]
        GDKBPDV = 534,
        [Description("GIẤY CHỨNG NHẬN PHẪU THUẬT 2")]
        GCNPT2 = 535,
        [Description("Giấy cam kết về việc thay đổi thông tin hồ sơn bệnh án")]
        GCKTDTTHSBA = 536,
        [Description("Phiếu khám gây mê trước mổ 2")]
        PKGMTM2 = 537,
        [Description("BẢNG KIỂM TRƯỚC TIÊM CHỦNG ĐỐI VỚI ĐỐI TƯỢNG >= 1 THÁNG TUỔI")]
        BKTTCDVTT1TT = 538,
        [Description("Giấy khám bệnh vào viện")]
        PKBVVXA = 539,
        [Description("PHÁ THÁI BẰNG THUỐC")]
        PTBT = 540,
        [Description("PHIẾU CHĂM SÓC ĐIỀU TRỊ HIV/AIDS")]
        PCSDTHIVAIDS = 541,
        [Description("Bảng kiểm trước tiêm chủng đối với trẻ sơ sinh 2 - BVHaDong")]
        BKTTCDVTSS2 = 542,//", TenPhieu = "", TrangThai = 1, DatabaseName = "BangKiemTruocTiemChungDVTreSS" }); 
        [Description("BẢNG KIỂM AN TOÀN PHẪU THUẬT NEW")]
        BKATPTN = 543,
        [Description("BẢNG KIỂM TRƯỚC LÀM THỦ THUẬT CHỤP DSA")]
        BKTLTTCDSA = 544,
        [Description("BỆNH ÁN BỆNH NHÂN TẠI BỆNH VIỆN ĐIỀU TRỊ COVID - 19 NGUYỄN TRI PHƯƠNG")] //02/03/2022 Add by Hòa bị trùng số tt nên không lên phiếu được
        BACV19NTP = 545,
        [Description("BẢNG KIỂM AN TOÀN PHẤU THUẬT")] //02/03/2022 Add by Hòa bị trùng số tt nên không lên phiếu được
        BKANPTNA = 546,
        [Description("Bệnh án ngoại trú - HIV")]
        BANgTruHIV = 547,
        [Description("PHIẾU ĐĂNG KÝ DA KỀ DA TRONG SANH MỖ")]
        PDKDKDTSM = 548,//", TenPhieu = "", TrangThai = 1, DatabaseName = "PhieuDKDaKeDaTrongSanhMo" });
        [Description("PHIẾU TƯ VẤN PHẨU THUẬT MỔ LẤY THAI")]
        PTVPTMLT = 549,//", TenPhieu = "", TrangThai = 1, DatabaseName = "PhieuTVPTMoLayThai" });
        [Description("PHIẾU KHÁM TIỀN PHẪU")]
        PKTP = 550,
        [Description("PHIẾU THEO DÕI NGƯỜI BỆNH SAU KHI MỔ (TRONG 24 GIỜ ĐẦU)")] //02/03/2022 Add by Hòa bị trùng số tt nên không lên phiếu được
        PTDNBSKM24H = 551,
    }
    public class DanhSachPhieu
    {
        public decimal IdPhieu { get; set; }
        public int STT { get; set; }
        public string MaPhieu { get; set; }
        public string TenPhieu { get; set; }
        public int LoaiPhieu { get; set; } // 1 : phieu ko nhap , 0 : phieu nhap
        public int TrangThai { get; set; } // 0 : Dong, 1: Mo
        public int SoLuong { get; set; }
        public string TenPhieuVaSoLuong { get { return this.TenPhieu + " (" + this.SoLuong + ")"; } }

        public string DatabaseName { get; set; }
        public List<string> DatabaseNameDetail { get; set; }
        public string NgayTao { get; set; }
        public string NgaySua { get; set; }
        public int SoLuongThemMoi { get; set; }
        public int SoLuongCapNhat { get; set; }
        public string NguoiTao { get; set; }
        public string NguoiSua { get; set; }
        public string TenNguoiTao { get; set; }
        public string TenNguoiSua { get; set; }
        public string MaNguoiTao { get; set; }
        public string MaNguoiSua { get; set; }
        public string NgayNguoiTao { get; set; }
        public string NgayNguoiSua { get; set; }
        public int IdQuanLy { get; set; }
        public int MaKy { get; set; }
        public string Document_MaKy { get; set; }
        /// <summary>
        /// Có kiểm tra phiếu đã ký, giá trị 0-1: 1 là có kiểm tra, 0 là không kiểm tra => Sử dụng để lấy những phiếu cần kiểm tra đã được ký hay chưa ký
        /// </summary>
        public int KiemTraDaKy { get; set; } = 0;
        public DanhSachPhieu()
        {
            NgayTao = "NgayTao";
            NgaySua = "NgaySua";
            NguoiTao = "NguoiTao";
            NguoiSua = "NguoiSua";
            SoLuongThemMoi = 0;
            SoLuongCapNhat = 0;
        }
        public DanhSachPhieu Clone()
        {
            return (DanhSachPhieu)this.MemberwiseClone();
        }
        public List<DanhSachPhieu> CreateDanhSachPhieu()
        {
            // MaPhieu unique . Khong thay doi.
            List<DanhSachPhieu> lstDanhSachPhieu = new List<DanhSachPhieu>();
            lstDanhSachPhieu.Add(new DanhSachPhieu() { STT = 1, MaPhieu = "TOBIA", TenPhieu = "Tờ bìa", LoaiPhieu = 1, TrangThai = 1, DatabaseName = "" });
            lstDanhSachPhieu.Add(new DanhSachPhieu() { STT = 2, MaPhieu = "HANHCHINH", TenPhieu = "Hành chính", LoaiPhieu = 1, TrangThai = 1, DatabaseName = "" });
            lstDanhSachPhieu.Add(new DanhSachPhieu() { STT = 3, MaPhieu = "KBVAOVIEN", TenPhieu = "Phiếu khám bệnh vào viện", LoaiPhieu = 1, TrangThai = 1, DatabaseName = "" });
            lstDanhSachPhieu.Add(new DanhSachPhieu() { STT = 4, MaPhieu = "CHIDINH", TenPhieu = "Phiếu chỉ định", LoaiPhieu = 1, TrangThai = 1, DatabaseName = "" });
            lstDanhSachPhieu.Add(new DanhSachPhieu() { STT = 5, MaPhieu = "KETQUA", TenPhieu = "Phiếu kết quả", LoaiPhieu = 1, TrangThai = 1, DatabaseName = "" });
            lstDanhSachPhieu.Add(new DanhSachPhieu() { STT = 6, MaPhieu = "CS", TenPhieu = "Phiếu chăm sóc", TrangThai = 1, DatabaseName = "THONGTINCHAMSOC" });
            lstDanhSachPhieu.Add(new DanhSachPhieu() { STT = 7, MaPhieu = "TM", TenPhieu = "Phiếu truyền máu", TrangThai = 1, DatabaseName = "THONGTINTRUYENMAU", NguoiTao = "", NguoiSua = "" });
            lstDanhSachPhieu.Add(new DanhSachPhieu() { STT = 8, MaPhieu = "TD", TenPhieu = "Phiếu truyền dịch", TrangThai = 1, DatabaseName = "THONGTINTRUYENDICH", NgayTao = "THOIGIANTAOPHIEU", NgaySua = "", NguoiTao = "", NguoiSua = "" });
            lstDanhSachPhieu.Add(new DanhSachPhieu() { STT = 9, MaPhieu = "KGMTM", TenPhieu = "Phiếu khám gây mê trước mổ", TrangThai = 1, DatabaseName = "PHIEUKHAMGAYMETRUOCMO", NgayTao = "THOIGIANTAO", NgaySua = "THOIGIANSUA", NguoiTao = "", NguoiSua = "" });
            lstDanhSachPhieu.Add(new DanhSachPhieu() { STT = 10, MaPhieu = "BKATPT", TenPhieu = "Bảng kiểm an toàn phẫu thuật", TrangThai = 1, DatabaseName = "BANGKIEMANTOANPHAUTHUAT", NgayTao = "THOIGIANTAOBANGKIEM", NgaySua = "", NguoiTao = "", NguoiSua = "" });
            lstDanhSachPhieu.Add(new DanhSachPhieu() { STT = 11, MaPhieu = "SKBADM", TenPhieu = "Sơ kết bệnh án duyệt mổ", TrangThai = 1, DatabaseName = "SOKETBENHANDUYETMO", NgayTao = "THOIGIANTAO", NgaySua = "THOIGIANSUA", NguoiTao = "", NguoiSua = "" });
            lstDanhSachPhieu.Add(new DanhSachPhieu() { STT = 12, MaPhieu = "CBTPT", TenPhieu = "Phiếu chuẩn bị trước phẫu thuật", TrangThai = 1, DatabaseName = "CHUANBITRUOCMO", NguoiTao = "", NguoiSua = "" });
            lstDanhSachPhieu.Add(new DanhSachPhieu() { STT = 13, MaPhieu = "SK15NDT", TenPhieu = "Phiếu sơ kết 15 ngày điều trị", TrangThai = 1, DatabaseName = "PHIEUSOKET15NGAYDIEUTRI", NgayTao = "THOIGIANTAO", NgaySua = "", NguoiTao = "", NguoiSua = "" });
            lstDanhSachPhieu.Add(new DanhSachPhieu() { STT = 14, MaPhieu = "CDKS", TenPhieu = "Giấy cam đoan chấp nhận test thử kháng sinh", TrangThai = 1, DatabaseName = "PHIEUCAMDOANKHANGSINH", NgayTao = "", NgaySua = "", NguoiTao = "", NguoiSua = "" });
            lstDanhSachPhieu.Add(new DanhSachPhieu() { STT = 15, MaPhieu = "SLDGDD", TenPhieu = "Phiếu sàng lọc, đánh giá dinh dưỡng người bệnh khi nhập viện.", TrangThai = 1, DatabaseName = "PHIEUDANHGIADINHDUONG", NgayTao = "THOIGIANTAO", NgaySua = "THOIGIANSUA", NguoiTao = "USERCREATE", NguoiSua = "USERUPDATE" });
            lstDanhSachPhieu.Add(new DanhSachPhieu() { STT = 16, MaPhieu = "KDBNNXV", TenPhieu = "Biên bản kiểm điểm bệnh nhân nặng xin về", TrangThai = 1, DatabaseName = "BENHNHANNANGXINVE", NgayTao = "NGAY_TAO", NgaySua = "NGAY_SUA", NguoiTao = "NGUOI_TAO", NguoiSua = "NGUOI_SUA" });
            lstDanhSachPhieu.Add(new DanhSachPhieu() { STT = 17, MaPhieu = "KDBNTV", TenPhieu = "Biên bản kiểm điểm bệnh nhân tử vong", TrangThai = 1, DatabaseName = "BENHNHANTUVONG", NgayTao = "NGAY_TAO", NgaySua = "NGAY_SUA", NguoiTao = "NGUOI_TAO", NguoiSua = "NGUOI_SUA" });
            lstDanhSachPhieu.Add(new DanhSachPhieu() { STT = 18, MaPhieu = "KDBNBV", TenPhieu = "Biên bản kiểm điểm bệnh nhân bỏ viện", TrangThai = 1, DatabaseName = "BENHNHANBOVE", NgayTao = "NGAY_TAO", NgaySua = "NGAY_SUA", NguoiTao = "NGUOI_TAO", NguoiSua = "NGUOI_SUA" });
            lstDanhSachPhieu.Add(new DanhSachPhieu() { STT = 19, MaPhieu = "KDBNCC", TenPhieu = "Biên bản xác nhận bệnh nhân cấp cứu", TrangThai = 1, DatabaseName = "BENHNHANCAPCUU", NgayTao = "NGAY_TAO", NgaySua = "NGAY_SUA", NguoiTao = "NGUOI_TAO", NguoiSua = "NGUOI_SUA" });
            lstDanhSachPhieu.Add(new DanhSachPhieu() { STT = 20, MaPhieu = "CKDTTM", TenPhieu = "Biên bản cam kết điều trị truyền máu", TrangThai = 1, DatabaseName = "CAMKETDIEUTRITRUYENMAU", NgayTao = "NGAY_TAO", NgaySua = "NGAY_SUA", NguoiTao = "NGUOI_TAO", NguoiSua = "NGUOI_SUA" });
            lstDanhSachPhieu.Add(new DanhSachPhieu() { STT = 21, MaPhieu = "HCTDS", TenPhieu = "Biên bản hội chẩn người bệnh sử dụng thuốc có dấu sao (*)", TrangThai = 1, DatabaseName = "BIENBANHOICHANTHUOCCODAUSAO" });
            //lstDanhSachPhieu.Add(new DanhSachPhieu() { STT = 22, MaPhieu = "DGDDC", TenPhieu = "Đánh giá dinh dưỡng người bệnh nhập viện (mẫu chung)", TrangThai = 1, DatabaseName = "PHIEUDANHGIADINHDUONGCHUNG" });
            lstDanhSachPhieu.Add(new DanhSachPhieu() { STT = 23, MaPhieu = "DD_PNMT", TenPhieu = "Đánh giá dinh dưỡng dành cho phụ nữ mang thai", TrangThai = 1, DatabaseName = "DINHDUONG_PNMT", NguoiSua = "" });
            lstDanhSachPhieu.Add(new DanhSachPhieu() { STT = 24, MaPhieu = "DD_TE", TenPhieu = "Đánh giá dinh dưỡng dành cho trẻ em", TrangThai = 1, DatabaseName = "DINHDUONG_TE", NguoiSua = "" });
            lstDanhSachPhieu.Add(new DanhSachPhieu() { STT = 25, MaPhieu = "TBDVT", TenPhieu = "Phiếu xác nhận bệnh nhân thay băng đa vết thương", TrangThai = 1, DatabaseName = "THAYBANGDAVETTHUONG_BENHNHAN", NgayTao = "NGAY_TAO", NgaySua = "NGAY_SUA", NguoiTao = "NGUOI_TAO", NguoiSua = "NGUOI_SUA" });
            lstDanhSachPhieu.Add(new DanhSachPhieu() { STT = 26, MaPhieu = "SS", TenPhieu = "Phiếu Sơ Sinh", TrangThai = 1, DatabaseName = "PHIEUSOSINH", NgayTao = "", NgaySua = "", NguoiTao = "", NguoiSua = "" });
            lstDanhSachPhieu.Add(new DanhSachPhieu() { STT = 27, MaPhieu = "KSGTCM", TenPhieu = "Phiếu kiểm soát gạc trong ca mổ", TrangThai = 1, DatabaseName = "phieukiemsoatgac", NgayTao = "THOIGIANTAO", NgaySua = "THOIGIANSUA", NguoiTao = "", NguoiSua = "" });
            lstDanhSachPhieu.Add(new DanhSachPhieu() { STT = 28, MaPhieu = "TBDVT30CM", TenPhieu = "Phiếu xác nhận bệnh nhân thay băng đa vết thương trên 30 cm", TrangThai = 1, DatabaseName = "thaybangdavetthuong30cm_bn", NgayTao = "NGAY_TAO", NgaySua = "NGAY_SUA", NguoiTao = "NGUOI_TAO", NguoiSua = "NGUOI_SUA" }); //Khong dung ma quan ly
            lstDanhSachPhieu.Add(new DanhSachPhieu() { STT = 29, MaPhieu = "BKJH", TenPhieu = "Bảng kiểm Johns Hopking", TrangThai = 1, DatabaseName = "BangKiemJohnsHopking" });
            lstDanhSachPhieu.Add(new DanhSachPhieu() { STT = 30, MaPhieu = "GMHS", TenPhieu = "Phiếu gây mê hồi sức", TrangThai = 1, DatabaseName = "phieugaymehoisuc", NgayTao = "NGAY_TAO", NgaySua = "NGAY_SUA", NguoiTao = "NGUOI_TAO", NguoiSua = "NGUOI_SUA" });
            lstDanhSachPhieu.Add(new DanhSachPhieu() { STT = 31, MaPhieu = "TT", TenPhieu = "Phiếu thủ thuật", TrangThai = 1, DatabaseName = "PhauThuatThuThuat" });
            lstDanhSachPhieu.Add(new DanhSachPhieu() { STT = 32, MaPhieu = "PTTT", TenPhieu = "Phiếu phẫu thuật thủ thuật", TrangThai = 1, DatabaseName = "PhauThuatThuThuat" });
            lstDanhSachPhieu.Add(new DanhSachPhieu() { STT = 33, MaPhieu = "CD", TenPhieu = "Phiếu chuyển dạ", TrangThai = 1, DatabaseName = "BIEUDOCHUYENDA", NgayTao = "NGAY_TAO", NgaySua = "NGAY_SUA", NguoiTao = "NGUOI_TAO", NguoiSua = "NGUOI_SUA" });
            lstDanhSachPhieu.Add(new DanhSachPhieu() { STT = 34, MaPhieu = "BBTVNV", TenPhieu = "Biên bản tử vong ngoài viện", TrangThai = 1, DatabaseName = "BienBanTuVongNgoaiVien" });
            lstDanhSachPhieu.Add(new DanhSachPhieu() { STT = 35, MaPhieu = "DD", TenPhieu = "Phiếu đánh giá dinh dưỡng", TrangThai = 1, DatabaseName = "DanhGiaDinhDuong" });
            lstDanhSachPhieu.Add(new DanhSachPhieu() { STT = 36, MaPhieu = "PPTT3", TenPhieu = "Phiếu phẫu thuật thể thủy tinh", TrangThai = 1, DatabaseName = "PHAUTHUATTHETHUYTINH" });
            lstDanhSachPhieu.Add(new DanhSachPhieu() { STT = 37, MaPhieu = "KSTCK", TenPhieu = "Phiếu kiểm soát trước khi chuyển khoa", TrangThai = 1, DatabaseName = "KIEMSOATNGUOIBENHTRUOC" });
            lstDanhSachPhieu.Add(new DanhSachPhieu() { STT = 38, MaPhieu = "BKHSBA", TenPhieu = "Bảng kiểm hồ sơ bệnh án", TrangThai = 1, DatabaseName = "BANGKIEMHOSOBENHAN" });
            lstDanhSachPhieu.Add(new DanhSachPhieu() { STT = 39, MaPhieu = "KSBN", TenPhieu = "Kiểm Soát Bệnh Nhân Tại Phòng Mổ", TrangThai = 1, DatabaseName = "KiemSoatBenhNhanTaiPhongMo", NgayTao = "", NgaySua = "", NguoiTao = "", NguoiSua = "" });
            lstDanhSachPhieu.Add(new DanhSachPhieu() { STT = 40, MaPhieu = "TBBHC", TenPhieu = "Trích biên bản hội chẩn", TrangThai = 1, DatabaseName = "TRICHBIENBANHOICHAN" });
            lstDanhSachPhieu.Add(new DanhSachPhieu() { STT = 41, MaPhieu = "YCSDKS", TenPhieu = "Yêu cầu sử dụng kháng sinh", TrangThai = 1, DatabaseName = "YeuCauSuDungKhangSinh", NgayTao = "", NgaySua = "", NguoiTao = "", NguoiSua = "" });
            lstDanhSachPhieu.Add(new DanhSachPhieu() { STT = 42, MaPhieu = "BBHC", TenPhieu = "Biên bản hội chẩn", TrangThai = 1, DatabaseName = "BIENBANHOICHAN" });
            lstDanhSachPhieu.Add(new DanhSachPhieu() { STT = 43, MaPhieu = "BBBGTSS", TenPhieu = "Biên bản bàn giao trẻ sơ sinh", TrangThai = 1, DatabaseName = "BIENBANBANGIAOTRESOSINH" });
            lstDanhSachPhieu.Add(new DanhSachPhieu() { STT = 44, MaPhieu = "TDSS", TenPhieu = "Phiếu theo dõi sơ sinh", TrangThai = 1, DatabaseName = "PHIEUTHEODOISOSINH", NgayTao = "", NgaySua = "", NguoiTao = "", NguoiSua = "" });
            lstDanhSachPhieu.Add(new DanhSachPhieu() { STT = 45, MaPhieu = "CSBNDD", TenPhieu = "Hồ sơ chăm sóc bệnh nhân của điều dưỡng", TrangThai = 1, DatabaseName = "CHAMSOCNGUOIBENHCUADIEUDUONG" });
            lstDanhSachPhieu.Add(new DanhSachPhieu() { STT = 46, MaPhieu = "TVTTM", TenPhieu = "Phiếu thuốc vật tư tiêu hao trong mổ", TrangThai = 1, DatabaseName = "THUOCVATTUTIEUHAOTRONGMO" });
            lstDanhSachPhieu.Add(new DanhSachPhieu() { STT = 47, MaPhieu = "HDKTTSDU", TenPhieu = "Hướng dẫn khai thác tiền sử dị ứng", TrangThai = 1, DatabaseName = "HuongDanKhaiThacTienSuDiUng", NguoiTao = "", NguoiSua = "" });
            lstDanhSachPhieu.Add(new DanhSachPhieu() { STT = 48, MaPhieu = "PTM", TenPhieu = "Phiếu phẫu thuật mộng", TrangThai = 1, DatabaseName = "PHAUTHUATMONG" });
            lstDanhSachPhieu.Add(new DanhSachPhieu() { STT = 49, MaPhieu = "PTMQ", TenPhieu = "Phiếu phẫu thuật mổ quặm", TrangThai = 1, DatabaseName = "PHAUTHUATQUAM" });
            lstDanhSachPhieu.Add(new DanhSachPhieu() { STT = 50, MaPhieu = "PDTPHCN", TenPhieu = "Phiếu điều trị phục hồi chức năng", TrangThai = 1, DatabaseName = "PHIEUDIEUTRIPHUCHOICHUCNANG", NgayTao = "", NgaySua = "", NguoiTao = "", NguoiSua = "" });
            lstDanhSachPhieu.Add(new DanhSachPhieu() { STT = 51, MaPhieu = "PLM", TenPhieu = "Phiếu lọc máu", TrangThai = 1, DatabaseName = "PHIEULOCMAU", NgayTao = "", NgaySua = "", NguoiTao = "", NguoiSua = "" });
            lstDanhSachPhieu.Add(new DanhSachPhieu() { STT = 52, MaPhieu = "BKTCTSS", TenPhieu = "Bảng kiểm trước tiêm chủng cho trẻ sơ sinh", TrangThai = 1, DatabaseName = "BangKiemTruocTiemChung", NgayTao = "", NgaySua = "", NguoiTao = "", NguoiSua = "" });
            lstDanhSachPhieu.Add(new DanhSachPhieu() { STT = 53, MaPhieu = "PTDMDCH", TenPhieu = "Phiếu theo dõi mổ đẻ chỉ huy", TrangThai = 1, DatabaseName = "PhieuTheoDoiMoDeChiHuy", NgayTao = "", NgaySua = "", NguoiTao = "", NguoiSua = "" });
            lstDanhSachPhieu.Add(new DanhSachPhieu() { STT = 54, MaPhieu = "PKQNPDNG", TenPhieu = "Phiếu kết quả nghiệm pháp dung nạp Glucose", TrangThai = 1, DatabaseName = "PhieuKetQuaNghiemPhap", NgayTao = "", NgaySua = "", NguoiTao = "", NguoiSua = "" });
            lstDanhSachPhieu.Add(new DanhSachPhieu() { STT = 55, MaPhieu = "DKKBTN", TenPhieu = "Phiếu đề nghị khám bệnh tự nguyện", TrangThai = 1, DatabaseName = "PhieuKhamBenhTuNguyen" });
            lstDanhSachPhieu.Add(new DanhSachPhieu() { STT = 56, MaPhieu = "GDNNPT", TenPhieu = "Giấy đề nghị nạo phá thai", TrangThai = 1, DatabaseName = "GiayDeNghiNaoPhaThai", NguoiTao = "", NguoiSua = "" });
            lstDanhSachPhieu.Add(new DanhSachPhieu() { STT = 57, MaPhieu = "TDCSDTHIV", TenPhieu = "Theo dõi chăm sóc điều trị HIV", TrangThai = 1, DatabaseName = "TheoDoiChamSocDieuTriHIV" });
            lstDanhSachPhieu.Add(new DanhSachPhieu() { STT = 58, MaPhieu = "PTHCK", TenPhieu = "Tờ điều trị phá thai hút chân không", TrangThai = 1, DatabaseName = "ToPhaThaiHutChanKhong" });
            lstDanhSachPhieu.Add(new DanhSachPhieu() { STT = 59, MaPhieu = "PTNSDGCLC", TenPhieu = "Phiếu tự nguyện sử dụng giường chất lượng cao", TrangThai = 1, DatabaseName = "PhieuTuNguyenSuDungGiuongCLC", NgayTao = "", NgaySua = "", NguoiTao = "", NguoiSua = "" });
            lstDanhSachPhieu.Add(new DanhSachPhieu() { STT = 60, MaPhieu = "BTTDTTT", TenPhieu = "Bảng tường trình điều trị tái thông", TrangThai = 1, DatabaseName = "BANTUONGTRINHDIEUTRITAITHONG" });
            lstDanhSachPhieu.Add(new DanhSachPhieu() { STT = 61, MaPhieu = "NNXXNNV", TenPhieu = "NNX xác nhận nằm viện", TrangThai = 1, DatabaseName = "NNXXacNhanNamVien", NgayTao = "NGAY_TAO", NgaySua = "NGAY_SUA", NguoiTao = "NGUOI_TAO", NguoiSua = "NGUOI_SUA" });
            lstDanhSachPhieu.Add(new DanhSachPhieu() { STT = 62, MaPhieu = "NNXCNPTTT", TenPhieu = "NNX chấp nhận PTTT", TrangThai = 1, DatabaseName = "NNXChapNhanPTTT", NgayTao = "NGAY_TAO", NgaySua = "NGAY_SUA", NguoiTao = "NGUOI_TAO", NguoiSua = "NGUOI_SUA" });
            lstDanhSachPhieu.Add(new DanhSachPhieu() { STT = 63, MaPhieu = "NNXRV", TenPhieu = "NNX ra viện", TrangThai = 1, DatabaseName = "NNXRaVien", NgayTao = "NGAY_TAO", NgaySua = "NGAY_SUA", NguoiTao = "NGUOI_TAO", NguoiSua = "NGUOI_SUA" });
            lstDanhSachPhieu.Add(new DanhSachPhieu() { STT = 64, MaPhieu = "NNXTMTT", TenPhieu = "NNX thuê máy trợ thở", TrangThai = 1, DatabaseName = "NNXThueMayTroTho", NgayTao = "NGAY_TAO", NgaySua = "NGAY_SUA", NguoiTao = "NGUOI_TAO", NguoiSua = "NGUOI_SUA" });
            lstDanhSachPhieu.Add(new DanhSachPhieu() { STT = 65, MaPhieu = "NNXHSTT", TenPhieu = "NNX hồi sức tối thiểu", TrangThai = 1, DatabaseName = "NNXHoiSucToiThieu", NgayTao = "NGAY_TAO", NgaySua = "NGAY_SUA", NguoiTao = "NGUOI_TAO", NguoiSua = "NGUOI_SUA" });
            lstDanhSachPhieu.Add(new DanhSachPhieu() { STT = 66, MaPhieu = "TDVCSBNC2", TenPhieu = "Phiếu theo dõi và chăm sóc bệnh nhân cấp 2", TrangThai = 1, DatabaseName = "PhieuTheoDoiVaChamSocBNC2" });
            lstDanhSachPhieu.Add(new DanhSachPhieu() { STT = 67, MaPhieu = "DGTGNLGG", TenPhieu = "Đánh giá tri giác người lớn theo thang điểm Glasgow", TrangThai = 1, DatabaseName = "DanhGiaTriGiacNguoiLonGLASGOW" });
            lstDanhSachPhieu.Add(new DanhSachPhieu() { STT = 68, MaPhieu = "PTDBNN", TenPhieu = "Phiếu theo dõi bệnh nhân nặng", TrangThai = 1, DatabaseName = "PhieuTheoDoiBenhNhanNang" });
            lstDanhSachPhieu.Add(new DanhSachPhieu() { STT = 69, MaPhieu = "TDDQNIHSS", TenPhieu = "Thang điểm đột quỵ NIHSS", TrangThai = 1, DatabaseName = "ThangDiemDotQuyNIHSS" });
            lstDanhSachPhieu.Add(new DanhSachPhieu() { STT = 70, MaPhieu = "BKTKM", TenPhieu = "Bảng kiểm trước khi mổ", TrangThai = 1, DatabaseName = "BangKiemTruocKhiMo" });
            lstDanhSachPhieu.Add(new DanhSachPhieu() { STT = 71, MaPhieu = "BKSKM", TenPhieu = "Bảng kiểm sau khi mổ", TrangThai = 1, DatabaseName = "BangKiemSauKhiMo" });
            lstDanhSachPhieu.Add(new DanhSachPhieu() { STT = 72, MaPhieu = "BKDTTTDD", TenPhieu = "Bảng kiểm điều trị tái thông, đột quỵ do thiếu máu não cục bộ (Dành cho điều dưỡng)", TrangThai = 1, DatabaseName = "BangDieuTriTaiThongDieuDuong" });
            lstDanhSachPhieu.Add(new DanhSachPhieu() { STT = 73, MaPhieu = "BKDTTTBS", TenPhieu = "Bảng kiểm điều trị tái thông, đột quỵ do thiếu máu não cục bộ (Dành cho bác sỹ)", TrangThai = 1, DatabaseName = "BangDieuTriTaiThongBacSy" });
            lstDanhSachPhieu.Add(new DanhSachPhieu() { STT = 74, MaPhieu = "PTDDTHACH", TenPhieu = "Phiếu theo dõi điều trị huyết áp chỉ huy", TrangThai = 1, DatabaseName = "PhieuTheoDoiDieuTriHACH", NgayTao = "", NgaySua = "", NguoiTao = "", NguoiSua = "" });
            lstDanhSachPhieu.Add(new DanhSachPhieu() { STT = 75, MaPhieu = "PTDMM", TenPhieu = "Phiếu theo dõi đường mao mạch", TrangThai = 1, DatabaseName = "PhieuTheoDoiDuongMaoMach", NgayTao = "", NgaySua = "", NguoiTao = "", NguoiSua = "" });
            lstDanhSachPhieu.Add(new DanhSachPhieu() { STT = 76, MaPhieu = "NNXCDLTT", TenPhieu = "NNX cam đoan làm thủ thuật", TrangThai = 1, DatabaseName = "NNXCamDoanLamThuThuat", NgayTao = "NGAY_TAO", NgaySua = "NGAY_SUA", NguoiTao = "NGUOI_TAO", NguoiSua = "NGUOI_SUA" });
            lstDanhSachPhieu.Add(new DanhSachPhieu() { STT = 77, MaPhieu = "NNXCKXDXN", TenPhieu = "NNX cam kết sử dụng xét nghiệm, vật tư tiêu hoa", TrangThai = 1, DatabaseName = "NNXCamKetSuDungXetNghiem", NgayTao = "NGAY_TAO", NgaySua = "NGAY_SUA", NguoiTao = "NGUOI_TAO", NguoiSua = "NGUOI_SUA" });
            lstDanhSachPhieu.Add(new DanhSachPhieu() { STT = 78, MaPhieu = "GBM", TenPhieu = "Giấy báo mổ", TrangThai = 1, DatabaseName = "GiayBaoMo" });
            lstDanhSachPhieu.Add(new DanhSachPhieu() { STT = 79, MaPhieu = "BBHCTTTM", TenPhieu = "Biên bản hội chẩn can thiệp tim mạch", TrangThai = 1, DatabaseName = "BienBanHCCTTimMach" });
            lstDanhSachPhieu.Add(new DanhSachPhieu() { STT = 80, MaPhieu = "PTDCNS", TenPhieu = "Phiếu theo dõi chức năng sống", TrangThai = 1, DatabaseName = "PhieuTheoDoiChucNangSong" });
            lstDanhSachPhieu.Add(new DanhSachPhieu() { STT = 81, MaPhieu = "DSPTKQ", TenPhieu = "Danh sách phiếu trả kết quả", TrangThai = 1, DatabaseName = "PhieuTraKetQuaTim", NguoiTao = "", NguoiSua = "" });
            lstDanhSachPhieu.Add(new DanhSachPhieu() { STT = 82, MaPhieu = "TDTTCCCTC", TenPhieu = "Phiếu chỉ định theo dõi tim thai và cơn co tử cung bằng máy monitor", TrangThai = 1, DatabaseName = "PhieuTDTimThaiCCTC" });
            lstDanhSachPhieu.Add(new DanhSachPhieu() { STT = 83, MaPhieu = "PTDDTADTM", TenPhieu = "Phiếu theo dõi điều trị Alteplase đường tĩnh mạch", TrangThai = 1, DatabaseName = "PhieuTDDTAlteplase", NgayTao = "", NgaySua = "", NguoiTao = "", NguoiSua = "" });
            lstDanhSachPhieu.Add(new DanhSachPhieu() { STT = 84, MaPhieu = "CKTCTP", TenPhieu = "Giấy cam kết đồng ý chụp phim có tiêm chất tương phản", TrangThai = 1, DatabaseName = "CamKetTiemChatTuongPhan" });
            lstDanhSachPhieu.Add(new DanhSachPhieu() { STT = 85, MaPhieu = "GCDTNPT", TenPhieu = "Giấy cam đoan tự nguyện phá thai", TrangThai = 1, DatabaseName = "GiayCamDoanTuNguyenPhaThai", NgayTao = "NGAY_TAO", NgaySua = "NGAY_SUA", NguoiTao = "NGUOI_TAO", NguoiSua = "NGUOI_SUA" });
            lstDanhSachPhieu.Add(new DanhSachPhieu() { STT = 86, MaPhieu = "BBHCPT", TenPhieu = "Biên bản hội chẩn phẫu thuật", TrangThai = 1, DatabaseName = "BienBanHoiChanPhauThuat" });
            //lstDanhSachPhieu.Add(new DanhSachPhieu() { STT = 87, MaPhieu = "PDGTTDD", TenPhieu = "PHIẾU ĐÁNH GIÁ TÌNH TRẠNG DINH DƯỠNG", TrangThai = 1, DatabaseName = "DanhGiaTinhTrangDinhDuong" });
            lstDanhSachPhieu.Add(new DanhSachPhieu() { STT = 88, MaPhieu = "PTVBNTN", TenPhieu = "Phiếu tư vấn bệnh nhân/thân nhân", TrangThai = 1, DatabaseName = "PhieuTuVanBNTN" });
            lstDanhSachPhieu.Add(new DanhSachPhieu() { STT = 89, MaPhieu = "PLMCC", TenPhieu = "Phiếu lọc máu cấp cứu", TrangThai = 1, DatabaseName = "PhieuLocMauCapCuu" });
            lstDanhSachPhieu.Add(new DanhSachPhieu() { STT = 90, MaPhieu = "TSBNCTP", TenPhieu = "Tầm kiểm soát bệnh nhân có nguy cơ với chất tương phản", TrangThai = 1, DatabaseName = "NGUYCOCHATTUONGPHAN", NguoiTao = "", NguoiSua = "" });
            lstDanhSachPhieu.Add(new DanhSachPhieu() { STT = 91, MaPhieu = "PDGDD", TenPhieu = "Phiếu đánh giá tình trạng dinh dưỡng", TrangThai = 1, DatabaseName = "" });
            lstDanhSachPhieu.Add(new DanhSachPhieu() { STT = 92, MaPhieu = "TDCSBNC1", TenPhieu = "Phiếu theo dõi và chăm sóc bệnh nhân cấp 1", TrangThai = 1, DatabaseName = "PhieuTDCSBenhNhanCap1" });
            lstDanhSachPhieu.Add(new DanhSachPhieu() { STT = 93, MaPhieu = "TDDTTNT", TenPhieu = "Phiếu theo dõi và điều trị thận nhân tạo", TrangThai = 1, DatabaseName = "PhieuTDDTThanNhanTao" });
            lstDanhSachPhieu.Add(new DanhSachPhieu() { STT = 94, MaPhieu = "PHCDM", TenPhieu = "Phiếu hội chẩn duyệt mổ", TrangThai = 1, DatabaseName = "PhieuHoiChanDuyetMo" });
            lstDanhSachPhieu.Add(new DanhSachPhieu() { STT = 95, MaPhieu = "PTDVCS", TenPhieu = "Phiếu theo dõi và chăm sóc", TrangThai = 1, DatabaseName = "PhieuTheoDoiVaChamSoc" });
            lstDanhSachPhieu.Add(new DanhSachPhieu() { STT = 96, MaPhieu = "PDVKTTT", TenPhieu = "Phiếu dịch vụ kỹ thuật thủ thuật ngoại trú", TrangThai = 1, DatabaseName = "PhieuDichVuKTTT" });
            lstDanhSachPhieu.Add(new DanhSachPhieu() { STT = 97, MaPhieu = "PTKH", TenPhieu = "Phiếu tái khám hen", TrangThai = 1, DatabaseName = "PhieuTaiKhamHen" });
            lstDanhSachPhieu.Add(new DanhSachPhieu() { STT = 98, MaPhieu = "PTDCN23", TenPhieu = "Phiếu theo dõi chức năng sống (cấp II, III)", TrangThai = 1, DatabaseName = "PhieuTDCSNguoiBenhCap23" });
            lstDanhSachPhieu.Add(new DanhSachPhieu() { STT = 99, MaPhieu = "BKTNLBN", TenPhieu = "Bảng kiểm tránh nhầm lẫn bệnh nhân khi cung cấp dịch vụ ", TrangThai = 1, DatabaseName = "BangKiemTranhNhamLanBN" });

            lstDanhSachPhieu.Add(new DanhSachPhieu() { STT = 105, MaPhieu = "GXNBGT", TenPhieu = "Giấy xác nhận bàn giao trẻ", TrangThai = 1, DatabaseName = "GiayXacNhanBanGiaoTre" });
            lstDanhSachPhieu.Add(new DanhSachPhieu() { STT = 106, MaPhieu = "BTDCSBN", TenPhieu = "Bảng theo dõi chăm sóc bệnh nhân", TrangThai = 1, DatabaseName = "BangTDCSBenhNhan" });
            lstDanhSachPhieu.Add(new DanhSachPhieu() { STT = 107, MaPhieu = "BKQDMMM", TenPhieu = "Bảng kết quả đường máu mao mạch", TrangThai = 1, DatabaseName = "BangKQDuongMaoMach" });
            lstDanhSachPhieu.Add(new DanhSachPhieu() { STT = 108, MaPhieu = "PNPTDH", TenPhieu = "Phiếu nghiệm pháp tăng đường huyết", TrangThai = 1, DatabaseName = "PhieuNghiemPhapTangDuongHuyet" });
            lstDanhSachPhieu.Add(new DanhSachPhieu() { STT = 109, MaPhieu = "BKCBBGTPTTT", TenPhieu = "Bảng kiểm bàn giao người bệnh trước PTTT", TrangThai = 1, DatabaseName = "BangKiemCBBGTruocPTTT" });
            lstDanhSachPhieu.Add(new DanhSachPhieu() { STT = 110, MaPhieu = "CDPTGMHS2", TenPhieu = "Giấy cam đoan chấp nhận PTTT GMHS2", TrangThai = 1, DatabaseName = "CamDoanChapNhanPTTTGMHS2", NgayTao = "NGAY_TAO", NgaySua = "NGAY_SUA", NguoiTao = "NGUOI_TAO", NguoiSua = "NGUOI_SUA" });
            lstDanhSachPhieu.Add(new DanhSachPhieu() { STT = 111, MaPhieu = "PCBTKMCYT", TenPhieu = "Phiếu chuẩn bị bệnh nhân trước khi mổ của Y tá", TrangThai = 1, DatabaseName = "PhieuChuanBiTruocKhiMo" });
            lstDanhSachPhieu.Add(new DanhSachPhieu() { STT = 112, MaPhieu = "PXNTTCCBHYT", TenPhieu = "Phiếu xác nhận tình trạng cấp cứu với mức hưởng BHYT", TrangThai = 1, DatabaseName = "PHIEUXNTTCAPCUUVOIMUCBHYT" });
            lstDanhSachPhieu.Add(new DanhSachPhieu() { STT = 113, MaPhieu = "BCK", TenPhieu = "Bản cam kết", TrangThai = 1, DatabaseName = "BanCamKet", NgayTao = "NGAY_TAO", NgaySua = "NGAY_SUA", NguoiTao = "NGUOI_TAO", NguoiSua = "NGUOI_SUA" });
            lstDanhSachPhieu.Add(new DanhSachPhieu() { STT = 114, MaPhieu = "BBHCBV", TenPhieu = "Biên bản hội chẩn bệnh viện", TrangThai = 1, DatabaseName = "BienBanHoiChanBenhVien" });
            lstDanhSachPhieu.Add(new DanhSachPhieu() { STT = 115, MaPhieu = "BKNDDNB", TenPhieu = "Bảng kiểm nhận diện đúng người bệnh", TrangThai = 1, DatabaseName = "BangKiemNhanDienNB" });
            lstDanhSachPhieu.Add(new DanhSachPhieu() { STT = 115, MaPhieu = "GGTVCK", TenPhieu = "Giấy giải thích và cam kết", TrangThai = 1, DatabaseName = "GiayGiaiThichVaCamKet", NgayTao = "NGAY_TAO", NgaySua = "NGAY_SUA", NguoiTao = "NGUOI_TAO", NguoiSua = "NGUOI_SUA" });
            lstDanhSachPhieu.Add(new DanhSachPhieu() { STT = 116, MaPhieu = "GCKDYTMVPC", TenPhieu = "Giấy cam kết đồng ý truyền máu và chế phẩm máu", TrangThai = 1, DatabaseName = "GiayCamKetDYTMVCPM", NgayTao = "NGAY_TAO", NgaySua = "NGAY_SUA", NguoiTao = "NGUOI_TAO", NguoiSua = "NGUOI_SUA" });
            lstDanhSachPhieu.Add(new DanhSachPhieu() { STT = 117, MaPhieu = "BKCBBGSPTTT", TenPhieu = "Bảng kiểm chuẩn bị và bàn giao bênh nhân sau PTTT", TrangThai = 1, DatabaseName = "BangKiemCBBGSauPTTT" });
            lstDanhSachPhieu.Add(new DanhSachPhieu() { STT = 118, MaPhieu = "GGTVCKTDTCQ", TenPhieu = "Giấy giải thích và cam kết trước dùng thuốc cản quang", TrangThai = 1, DatabaseName = "GiayGiaiThichVaCamKetTDTCQ", NgayTao = "NGAY_TAO", NgaySua = "NGAY_SUA", NguoiTao = "NGUOI_TAO", NguoiSua = "NGUOI_SUA" });
            lstDanhSachPhieu.Add(new DanhSachPhieu() { STT = 119, MaPhieu = "GCKDNGTVTTB", TenPhieu = "Giấy cam kết được nghe giải thích về tình trạng bệnh", TrangThai = 1, DatabaseName = "GiayCamKetDNGTVTTB", NgayTao = "NGAY_TAO", NgaySua = "NGAY_SUA", NguoiTao = "NGUOI_TAO", NguoiSua = "NGUOI_SUA" });
            lstDanhSachPhieu.Add(new DanhSachPhieu() { STT = 120, MaPhieu = "GCKCXHTMCT", TenPhieu = "Giấy cam kết chụp xạ hình tưới máu cơ tim", TrangThai = 1, DatabaseName = "GiayCamKetCXHTMCT", NgayTao = "NGAY_TAO", NgaySua = "NGAY_SUA", NguoiTao = "NGUOI_TAO", NguoiSua = "NGUOI_SUA" });
            lstDanhSachPhieu.Add(new DanhSachPhieu() { STT = 121, MaPhieu = "PTDNT24HBN", TenPhieu = "Phiếu theo dõi nước tiểu 24h dành cho bệnh nhân", TrangThai = 1, DatabaseName = "PhieuTDNuocTieu24H" });
            lstDanhSachPhieu.Add(new DanhSachPhieu() { STT = 122, MaPhieu = "DGNBNV", TenPhieu = "Phiếu đánh giá người bệnh nhập viện", TrangThai = 1, DatabaseName = "DanhGiaNguoiBenhNhapVien" });
            lstDanhSachPhieu.Add(new DanhSachPhieu() { STT = 123, MaPhieu = "DGBNNV", TenPhieu = "Phiếu đánh giá bệnh nhi nhập viện", TrangThai = 1, DatabaseName = "DanhGiaBenhNhiNhapVien" });
            lstDanhSachPhieu.Add(new DanhSachPhieu() { STT = 124, MaPhieu = "BKDCVTTHBNCTTM", TenPhieu = "Bảng kê dụng cụ và VTTH bệnh nhân can thiệp tim mạch", TrangThai = 1, DatabaseName = "BANGKEDCVAVTTHBNCTTIMMACH" });
            lstDanhSachPhieu.Add(new DanhSachPhieu() { STT = 125, MaPhieu = "DGTTRMBNTPT", TenPhieu = "Đánh giá tình trạng răng miệng bệnh nhân trước phẫu thuật", TrangThai = 1, DatabaseName = "DGTTRangMiengBNTruocPT" });
            lstDanhSachPhieu.Add(new DanhSachPhieu() { STT = 126, MaPhieu = "PKTGM", TenPhieu = "Phiếu khám trước gây mê", TrangThai = 1, DatabaseName = "PhieuKhamTruocGayMe" });
            lstDanhSachPhieu.Add(new DanhSachPhieu() { STT = 127, MaPhieu = "PKTBA", TenPhieu = "Phiếu kiểm tra bệnh án", TrangThai = 1, DatabaseName = "PhieuKiemTraBenhAn" });
            lstDanhSachPhieu.Add(new DanhSachPhieu() { STT = 128, MaPhieu = "PCBTCTCDD", TenPhieu = "Phiếu chuẩn bị bệnh nhân trước can thiệp của điều dưỡng", TrangThai = 1, DatabaseName = "PhieuChuanBiTruocCanThiep" });
            lstDanhSachPhieu.Add(new DanhSachPhieu() { STT = 129, MaPhieu = "PKVDTBN", TenPhieu = "Phiếu khám và điều trị bệnh nhân", TrangThai = 1, DatabaseName = "PhieuKhamVaDieuTriBenhNhan" });
            lstDanhSachPhieu.Add(new DanhSachPhieu() { STT = 130, MaPhieu = "PBGBN", TenPhieu = "Phiếu bàn giao bênh nhân", TrangThai = 1, DatabaseName = "PhieuBanGiaoBenhNhan" });
            lstDanhSachPhieu.Add(new DanhSachPhieu() { STT = 131, MaPhieu = "PTTQTDT", TenPhieu = "Phiếu tóm tắt quá trình điều trị", TrangThai = 1, DatabaseName = "PhieuTomTatQuaTrinhDieuTri" });
            lstDanhSachPhieu.Add(new DanhSachPhieu() { STT = 132, MaPhieu = "GMTT", TenPhieu = "Phiếu gây mê thủ thuật", TrangThai = 1, DatabaseName = "PhieuGayMeThuThuat" });
            lstDanhSachPhieu.Add(new DanhSachPhieu() { STT = 133, MaPhieu = "BKCBBGTPTTT2", TenPhieu = "Phiếu kiểm bàn giao người bệnh trước PTTT", TrangThai = 1, DatabaseName = "BangKiemCBBGTruocPTTT2" });
            lstDanhSachPhieu.Add(new DanhSachPhieu() { STT = 134, MaPhieu = "BKATTTCTTM", TenPhieu = "Bảng kiểm an toàn thủ thuật CTTM", TrangThai = 1, DatabaseName = "BangKiemAnToanThuThuat_CTTM", NgayTao = "NGAY_TAO", NgaySua = "NGAY_SUA", NguoiTao = "NGUOI_TAO", NguoiSua = "NGUOI_SUA" });
            lstDanhSachPhieu.Add(new DanhSachPhieu() { STT = 135, MaPhieu = "KHCSNBST", TenPhieu = "Kế hoạch chăm sóc người bệnh suy tim", TrangThai = 1, DatabaseName = "KeHoachCSNBSuyTim" });
            lstDanhSachPhieu.Add(new DanhSachPhieu() { STT = 136, MaPhieu = "KHCSNBSCTTM", TenPhieu = "Kế hoạch chăm sóc người bệnh sau can thiệp tim mạch", TrangThai = 1, DatabaseName = "KeHoachCSNBSauTimMach" });
            lstDanhSachPhieu.Add(new DanhSachPhieu() { STT = 137, MaPhieu = "CKTMCTGMHS", TenPhieu = "Giấy cam đoan chấp nhận thủ thuật tim mạch can thiệp và gây mê hồi sức", TrangThai = 1, DatabaseName = "CamKetTMCT_GMHS", NgayTao = "NGAY_TAO", NgaySua = "NGAY_SUA", NguoiTao = "NGUOI_TAO", NguoiSua = "NGUOI_SUA" });
            lstDanhSachPhieu.Add(new DanhSachPhieu() { STT = 138, MaPhieu = "BTDCEC", TenPhieu = "Bảng theo dõi CEC", TrangThai = 1, DatabaseName = "BangTheoDoiCEC" });
            lstDanhSachPhieu.Add(new DanhSachPhieu() { STT = 139, MaPhieu = "BTDCSNB", TenPhieu = "Bảng theo dõi chăm sóc người bệnh", TrangThai = 1, DatabaseName = "BangTheoDoiChamSocNB" });
            lstDanhSachPhieu.Add(new DanhSachPhieu() { STT = 140, MaPhieu = "BTDBNCTMV", TenPhieu = "Bảng theo dõi bệnh nhân can thiệp mạch vành", TrangThai = 1, DatabaseName = "BangTheoDoiBenhNhanCTMV" });
            lstDanhSachPhieu.Add(new DanhSachPhieu() { STT = 141, MaPhieu = "BKLMLT", TenPhieu = "Bảng kê lọc máu liên tục", TrangThai = 1, DatabaseName = "BangKeLocMauLienTuc" });
            lstDanhSachPhieu.Add(new DanhSachPhieu() { STT = 141, MaPhieu = "BKTHT", TenPhieu = "Bảng kê thay huyết tương", TrangThai = 1, DatabaseName = "BangKeThayHuyetTuong" });
            lstDanhSachPhieu.Add(new DanhSachPhieu() { STT = 143, MaPhieu = "BTTHSBA", TenPhieu = "Bảng tóm tắt hồ sơ bệnh án", TrangThai = 1, DatabaseName = "BangTomTatHoSoBenhAn" });
            lstDanhSachPhieu.Add(new DanhSachPhieu() { STT = 144, MaPhieu = "PLM2", TenPhieu = "Phiếu lọc máu 2", TrangThai = 1, DatabaseName = "PhieuLocMau2" });
            lstDanhSachPhieu.Add(new DanhSachPhieu() { STT = 145, MaPhieu = "PKTTT", TenPhieu = "Phiếu thực hiện kỹ thuật/thủ thuật", TrangThai = 1, DatabaseName = "PhauThuatThuThuat" });
            lstDanhSachPhieu.Add(new DanhSachPhieu() { STT = 146, MaPhieu = "PKCK", TenPhieu = "Phiếu khám chuyên khoa", TrangThai = 1, DatabaseName = "PhieuKhamChuyenKhoa" });
            lstDanhSachPhieu.Add(new DanhSachPhieu() { STT = 147, MaPhieu = "PTDTHKHCS", TenPhieu = "Phiếu theo dõi và thực hiện kế hoạch chăm sóc", TrangThai = 1, DatabaseName = "PhieuTDVaTHKHCSNguoiBenh" });
            lstDanhSachPhieu.Add(new DanhSachPhieu() { STT = 148, MaPhieu = "PDG", TenPhieu = "Phiếu đếm gạc", TrangThai = 1, DatabaseName = "PhieuDemGac" });
            lstDanhSachPhieu.Add(new DanhSachPhieu() { STT = 149, MaPhieu = "TLBA", TenPhieu = "Trích lục bệnh án", TrangThai = 1, DatabaseName = "PhieuTomTatBenhAnNoiTru" });
            lstDanhSachPhieu.Add(new DanhSachPhieu() { STT = 150, MaPhieu = "BTDLM", TenPhieu = "Bảng theo dõi lọc máu", TrangThai = 1, DatabaseName = "BangTheoDoiLocMau" });
            lstDanhSachPhieu.Add(new DanhSachPhieu() { STT = 151, MaPhieu = "BTDTHT", TenPhieu = "Bảng theo dõi thay huyết tương", TrangThai = 1, DatabaseName = "BangTheoDoiThayHuyetTuong" });
            lstDanhSachPhieu.Add(new DanhSachPhieu() { STT = 152, MaPhieu = "PTDTMLS", TenPhieu = "Phiếu theo dõi truyền máu lâm sàng", TrangThai = 1, DatabaseName = "BangTheoDoiTMLS" });
            lstDanhSachPhieu.Add(new DanhSachPhieu() { STT = 153, MaPhieu = "PXNHHMDPM", TenPhieu = "Phiếu xét nghiệm hòa hợp miễn dịch phát máu", TrangThai = 1, DatabaseName = "PhieuXetNghiemPhatMau" });
            lstDanhSachPhieu.Add(new DanhSachPhieu() { STT = 154, MaPhieu = "PCBBNTCTCDD", TenPhieu = "Phiếu chuẩn bị người bệnh trước can thiệp của điều dưỡng", TrangThai = 1, DatabaseName = "PhieuCBBnTruocCTCuaDD" });
            lstDanhSachPhieu.Add(new DanhSachPhieu() { STT = 155, MaPhieu = "PCBBNTPTCDD", TenPhieu = "Phiếu chuẩn bị người bệnh trước phẫu thuật của điều dưỡng", TrangThai = 1, DatabaseName = "PhieuCBBnTruocPTCuaDD" });
            lstDanhSachPhieu.Add(new DanhSachPhieu() { STT = 156, MaPhieu = "PKVTDDTH", TenPhieu = "Phiếu khám và theo dõi điều trị hen", TrangThai = 1, DatabaseName = "PKVaTDDieuTriHen" });
            lstDanhSachPhieu.Add(new DanhSachPhieu() { STT = 157, MaPhieu = "PKVTDDTC", TenPhieu = "Phiếu khám và theo dõi điều trị COPD", TrangThai = 1, DatabaseName = "PKVaTDDieuTriCopd" });
            lstDanhSachPhieu.Add(new DanhSachPhieu() { STT = 158, MaPhieu = "PTBBHC", TenPhieu = "Phiếu trích biên bản hội chẩn", TrangThai = 1, DatabaseName = "PhieuTrichBienBanHoiChan" });
            lstDanhSachPhieu.Add(new DanhSachPhieu() { STT = 159, MaPhieu = "PKVDTPHCNHH", TenPhieu = "Phiếu khám và điều trị phục hồi chức năng hô hấp", TrangThai = 1, DatabaseName = "PHIEUKHAMVADIEUTRIPHCNHOHAP" });
            lstDanhSachPhieu.Add(new DanhSachPhieu() { STT = 160, MaPhieu = "CKTCDTPT", TenPhieu = "Cam kết trước chuyển dạ, trước phẫu thuật", TrangThai = 1, DatabaseName = "CAMKETTRUOCCHUYENDATRUOCPT" });
            lstDanhSachPhieu.Add(new DanhSachPhieu() { STT = 161, MaPhieu = "PCKCDA", TenPhieu = "Phiếu công khai chế độ ăn", TrangThai = 1, DatabaseName = "PhieuCongKhaiCheDoAn" });
            lstDanhSachPhieu.Add(new DanhSachPhieu() { STT = 162, MaPhieu = "SK30NDT", TenPhieu = "Phiếu sơ kết 30 ngày điều trị", TrangThai = 1, DatabaseName = "PHIEUSOKET30NGAYDIEUTRI", NgayTao = "THOIGIANTAO", NgaySua = "", NguoiTao = "", NguoiSua = "" });
            lstDanhSachPhieu.Add(new DanhSachPhieu() { STT = 163, MaPhieu = "PTDCSNBICU", TenPhieu = "Phiếu theo dõi và chăm sóc bệnh nhân ICU", TrangThai = 1, DatabaseName = "PhieuTDCSNBICU" });
            lstDanhSachPhieu.Add(new DanhSachPhieu() { STT = 164, MaPhieu = "PDGDDNBNVICU", TenPhieu = "Phiếu đánh giá dinh dưỡng người bệnh nhập viện ICU", TrangThai = 1, DatabaseName = "PhieuDGDDNguoiBenhNhapVienICU" });
            lstDanhSachPhieu.Add(new DanhSachPhieu() { STT = 165, MaPhieu = "PPHKQDTBNCD", TenPhieu = "Phiếu phản hồi Kết quả điều trị bệnh nhân chuyển đến", TrangThai = 1, DatabaseName = "PhieuPhanHoiKetQuaDieuTri" });
            lstDanhSachPhieu.Add(new DanhSachPhieu() { STT = 166, MaPhieu = "PCBNDTTDT", TenPhieu = "Phiếu chuyển bệnh nhân để tiếp tục điều trị", TrangThai = 1, DatabaseName = "PhieuChuyenBenhNhan" });
            lstDanhSachPhieu.Add(new DanhSachPhieu() { STT = 167, MaPhieu = "BBHCDTLKT", TenPhieu = "Biên bản hội chẩn điều trị lao kháng thuốc", TrangThai = 1, DatabaseName = "BBHCDieuTriLaoKhangThuoc" });
            lstDanhSachPhieu.Add(new DanhSachPhieu() { STT = 168, MaPhieu = "CS2", TenPhieu = "Phiếu chăm sóc mới", TrangThai = 1, DatabaseName = "ThongTinChamSocNew" });
            lstDanhSachPhieu.Add(new DanhSachPhieu() { STT = 169, MaPhieu = "KQLTNTNW", TenPhieu = "Kết quả làm trắc nghiệm trí nhớ Wechsler", TrangThai = 1, DatabaseName = "TracNghiemTriNhoWECHSLER" });
            lstDanhSachPhieu.Add(new DanhSachPhieu() { STT = 170, MaPhieu = "TDGHCY", TenPhieu = "Thang đánh giá hưng cảm Young", TrangThai = 1, DatabaseName = "ThangDanhGiaHungCamYoung" });
            lstDanhSachPhieu.Add(new DanhSachPhieu() { STT = 171, MaPhieu = "DGBPRS", TenPhieu = "THANG ĐÁNH GIÁ TÂM THẦN RÚT GỌN (BPRS)", TrangThai = 1, DatabaseName = "DanhGiaTamThanRutGonBPRS" });
            lstDanhSachPhieu.Add(new DanhSachPhieu() { STT = 172, MaPhieu = "DGTKOTNMC", TenPhieu = "Đánh giá tự kỷ ở trẻ (M-CHAT)", TrangThai = 1, DatabaseName = "DanhGiaTuKyTreNhoMChat" });
            lstDanhSachPhieu.Add(new DanhSachPhieu() { STT = 173, MaPhieu = "NPB", TenPhieu = "Nghiệm pháp Beck", TrangThai = 1, DatabaseName = "NghiemPhapBeck" });
            lstDanhSachPhieu.Add(new DanhSachPhieu() { STT = 174, MaPhieu = "TTCH", TenPhieu = "Trang trầm cảm Hamilton", TrangThai = 1, DatabaseName = "ThangTramCamHamilton" });
            lstDanhSachPhieu.Add(new DanhSachPhieu() { STT = 175, MaPhieu = "NPBN", TenPhieu = "Nghiệm pháp Beck (Test Nhi)", TrangThai = 1, DatabaseName = "NghiemPhapBeckNhi" });
            lstDanhSachPhieu.Add(new DanhSachPhieu() { STT = 176, MaPhieu = "BTTDGLASZ", TenPhieu = "Bậc thang tự đánh giá lo âu SAS Zung", TrangThai = 1, DatabaseName = "DanhGiaLoAuSasZung" });
            lstDanhSachPhieu.Add(new DanhSachPhieu() { STT = 177, MaPhieu = "PHSCS", TenPhieu = "Phiếu hồ sơ chăm sóc", TrangThai = 1, DatabaseName = "HSCS_TTBenhNhan" });
            //lstDanhSachPhieu.Add(new DanhSachPhieu() { STT = 178, MaPhieu = "PTVGDSK", TenPhieu = "Phiếu tư vấn và giáo dục sức khoẻ", TrangThai = 1, DatabaseName = "GiaoDucSucKhoe" });
            lstDanhSachPhieu.Add(new DanhSachPhieu() { STT = 179, MaPhieu = "DGNCNVHCT", TenPhieu = "Đánh giá nguy cơ ngã và hướng can thiệp", TrangThai = 1, DatabaseName = "BangDGNguyCoTeNgaVaHCT" });
            lstDanhSachPhieu.Add(new DanhSachPhieu() { STT = 180, MaPhieu = "MPYCSDKS", TenPhieu = "Mẫu phiếu yêu cầu sử dụng kháng sinh cần ưu tiên quản lý", TrangThai = 1, DatabaseName = "PhieuYCSDKhanhSinhUuTien" });
            lstDanhSachPhieu.Add(new DanhSachPhieu() { STT = 181, MaPhieu = "GTNTS", TenPhieu = "Giấy tự nguyện triệt sản", TrangThai = 1, DatabaseName = "GiayTuNguyenTrietSan" });
            lstDanhSachPhieu.Add(new DanhSachPhieu() { STT = 182, MaPhieu = "GKCBTYC", TenPhieu = "Giấy khám chữa bệnh theo yêu cầu", TrangThai = 1, DatabaseName = "GiayKhamChuaBenTheoYeuCau" });
            lstDanhSachPhieu.Add(new DanhSachPhieu() { STT = 183, MaPhieu = "PTDVCSC1", TenPhieu = "Phiếu theo dõi và chăm sóc cấp 1", TrangThai = 1, DatabaseName = "PTDVCSC1" });
            lstDanhSachPhieu.Add(new DanhSachPhieu() { STT = 184, MaPhieu = "PTDVCSNBC23", TenPhieu = "Phiếu theo dõi và chăm sóc bệnh nhân cấp II, III", TrangThai = 1, DatabaseName = "PTDVCSNBC23" });
            lstDanhSachPhieu.Add(new DanhSachPhieu() { STT = 185, MaPhieu = "BKSBNTM", TenPhieu = "Bảng kiểm soát bệnh nhân trước khi đưa lên phòng mổ", TrangThai = 1, DatabaseName = "BangKiemSoatBNTruocMo" });
            lstDanhSachPhieu.Add(new DanhSachPhieu() { STT = 186, MaPhieu = "PTDGDSK", TenPhieu = "PHIẾU THEO DÕI GIẢM ĐAU SẢN KHOA", TrangThai = 1, DatabaseName = "PhieuTDGDKhoaSan" });
            lstDanhSachPhieu.Add(new DanhSachPhieu() { STT = 187, MaPhieu = "PCDTTDT", TenPhieu = "Phiếu chuyển để tiếp tục điều trị", TrangThai = 1, DatabaseName = "PhieuChuyenDeTiepTucDieuTri" });
            lstDanhSachPhieu.Add(new DanhSachPhieu() { STT = 188, MaPhieu = "PYCSDKS", TenPhieu = "Phiếu yêu cầu sử dụng kháng sinh", TrangThai = 1, DatabaseName = "PhieuYCSDKhanhSinh" });//13/07/2021 Add by Hòa Issues 60112
            //lstDanhSachPhieu.Add(new DanhSachPhieu() { STT = 188, MaPhieu = "PYCSDKS", TenPhieu = "Phiếu yêu cầu sử dụng kháng sinh", TrangThai = 1, DatabaseName = "PhieuYCSDKhangSinh" });//13/07/2021 Close by Hòa Issues 60112
            lstDanhSachPhieu.Add(new DanhSachPhieu() { STT = 189, MaPhieu = "KHCSNB", TenPhieu = "Kế hoạch chăm sóc người bệnh", TrangThai = 1, DatabaseName = "KeHoachChamSocNguoiBenh" });
            lstDanhSachPhieu.Add(new DanhSachPhieu() { STT = 190, MaPhieu = "PCS", TenPhieu = "Phiếu chăm sóc", TrangThai = 1, DatabaseName = "PhieuChamSoc" });
            lstDanhSachPhieu.Add(new DanhSachPhieu() { STT = 191, MaPhieu = "PDT", TenPhieu = "Phiếu điện tim", TrangThai = 1, DatabaseName = "PhieuDienTim" });
            lstDanhSachPhieu.Add(new DanhSachPhieu() { STT = 192, MaPhieu = "PTDCSNBICU2", TenPhieu = "Phiếu theo dõi và chăm sóc bệnh nhân ICU 2", TrangThai = 1, DatabaseName = "PhieuTDCSNBICU" });
            lstDanhSachPhieu.Add(new DanhSachPhieu() { STT = 193, MaPhieu = "TVGDSK", TenPhieu = "Phiếu tư vấn giáo dục sức khỏe cho người bệnh và gia đình người bệnh", TrangThai = 1, DatabaseName = "TuVanGiaoDucSucKhoe" });
            lstDanhSachPhieu.Add(new DanhSachPhieu() { STT = 194, MaPhieu = "PBGSPHS", TenPhieu = "Phiếu bàn giao sang phòng hồi sức", TrangThai = 1, DatabaseName = "PhieuBanGiaoSangPhongHoiSuc" });
            lstDanhSachPhieu.Add(new DanhSachPhieu() { STT = 195, MaPhieu = "GGTBNMDR", TenPhieu = "Giấy giới thiệu bệnh nhân MDR - TB đến đơn vị tiếp tục quản lí điều trị", TrangThai = 1, DatabaseName = "GiayGioiThieuBenhNhanMDR" });
            lstDanhSachPhieu.Add(new DanhSachPhieu() { STT = 196, MaPhieu = "DXDBBNTT", TenPhieu = "Đơn xin đảm bảo bệnh nhân tâm thần", TrangThai = 1, DatabaseName = "DonXinDamBaoBenhNhanTamThan" });
            lstDanhSachPhieu.Add(new DanhSachPhieu() { STT = 197, MaPhieu = "PTDCSNB", TenPhieu = "Phiếu theo dõi chăm sóc người bệnh", TrangThai = 1, DatabaseName = "PhieuTDCSNB" });
            lstDanhSachPhieu.Add(new DanhSachPhieu() { STT = 198, MaPhieu = "BBDBNPTTKH", TenPhieu = "Biên bản duyệt bệnh nhân phẫu thuật theo kế hoạch", TrangThai = 1, DatabaseName = "PhieuTDCSNB" });
            lstDanhSachPhieu.Add(new DanhSachPhieu() { STT = 199, MaPhieu = "PXNVKL", TenPhieu = "Phiếu xét nghiệm vi khuẩn lao", TrangThai = 1, DatabaseName = "PhieuXetNghiemViKhuanLao" });
            lstDanhSachPhieu.Add(new DanhSachPhieu() { STT = 200, MaPhieu = "PDGDDNB", TenPhieu = "Phiếu đánh giá dinh dưỡng người bệnh", TrangThai = 1, DatabaseName = "PhieuDanhGiaDDNguoiBenh" });
            lstDanhSachPhieu.Add(new DanhSachPhieu() { STT = 201, MaPhieu = "PXNXXS", TenPhieu = "Phiếu xét nghiệm xpert xpress sars-cov-2", TrangThai = 1, DatabaseName = "PhieuXetNghiemXpertXpress" });
            lstDanhSachPhieu.Add(new DanhSachPhieu() { STT = 202, MaPhieu = "PXNVKLMM", TenPhieu = "Phiếu xét nghiệm vi khuẩn lao 1 mặt", TrangThai = 1, DatabaseName = "PhieuXetNghiemViKhuanLao2" });
            lstDanhSachPhieu.Add(new DanhSachPhieu() { STT = 203, MaPhieu = "PTNBN", TenPhieu = "Phiếu tiếp nhận bệnh nhân", TrangThai = 1, DatabaseName = "PhieuTiepNhanBenhNhan" });
            lstDanhSachPhieu.Add(new DanhSachPhieu() { STT = 204, MaPhieu = "PXNXNHIV", TenPhieu = "Phiếu xác nhận xét nghiệm HIV", TrangThai = 1, DatabaseName = "PhieuXNXNHIV" });
            lstDanhSachPhieu.Add(new DanhSachPhieu() { STT = 205, MaPhieu = "TYLTITM", TenPhieu = "Tờ y lệnh truyền insulin tĩnh mạch", TrangThai = 1, DatabaseName = "PhieuTruyenInsulin" });
            lstDanhSachPhieu.Add(new DanhSachPhieu() { STT = 206, MaPhieu = "KQNPA", TenPhieu = "Kết quả nghiệm pháp Atropin", TrangThai = 1, DatabaseName = "KetQuaNghiemPhapAtropin" });
            lstDanhSachPhieu.Add(new DanhSachPhieu() { STT = 207, MaPhieu = "GCDCNSDTTDT", TenPhieu = "Giấy cam đoan chấp nhận sử dụng thuốc trong điều trị", TrangThai = 1, DatabaseName = "CamDoanSDTTDT" });
            lstDanhSachPhieu.Add(new DanhSachPhieu() { STT = 208, MaPhieu = "GCDCNPTTTGMHS", TenPhieu = "Giấy cam đoan chấp nhận phẫu thuật, thủ thuật và gây mê hồi sức", TrangThai = 1, DatabaseName = "GiayCamDoanCNPTTTGMHS" });
            lstDanhSachPhieu.Add(new DanhSachPhieu() { STT = 209, MaPhieu = "PTTTTDT", TenPhieu = "Phiếu tóm tắt thông tin điều trị", TrangThai = 1, DatabaseName = "PhieuTTThongTinDieuTri" });
            lstDanhSachPhieu.Add(new DanhSachPhieu() { STT = 210, MaPhieu = "GBDT", TenPhieu = "Giấy báo đóng tiền", TrangThai = 1, DatabaseName = "GiayBaoDongTien" });
            lstDanhSachPhieu.Add(new DanhSachPhieu() { STT = 211, MaPhieu = "GCKDTTMCT", TenPhieu = "Giấy cam kết đóng tiền TMCT", TrangThai = 1, DatabaseName = "GiayCamKetDongTien" });
            lstDanhSachPhieu.Add(new DanhSachPhieu() { STT = 212, MaPhieu = "GCKCNTTNCTTM", TenPhieu = "Giấy cam kết chấp nhận tình trạng nặng can thiệp tim mạch", TrangThai = 1, DatabaseName = "GiayCamKetCNTTNCTTM" });
            lstDanhSachPhieu.Add(new DanhSachPhieu() { STT = 213, MaPhieu = "PTDVCSNBC23_2", TenPhieu = "Phiếu theo dõi và chăm sóc bệnh nhân cấp II, III (Mẫu 2)", TrangThai = 1, DatabaseName = "PTDVCSNBC23_2" });
            lstDanhSachPhieu.Add(new DanhSachPhieu() { STT = 214, MaPhieu = "BTDCSNBSCTTM", TenPhieu = "Bảng theo dõi chăm sóc người bệnh sau can thiệp tim mạch", TrangThai = 1, DatabaseName = "BangTDCSNBSauCTTM" });
            lstDanhSachPhieu.Add(new DanhSachPhieu() { STT = 215, MaPhieu = "KQTLTNRV", TenPhieu = "Kết quả trả lời kết quả trắc nghiệm Raven", TrangThai = 1, DatabaseName = "KQTLTracNghiemRaven" });
            lstDanhSachPhieu.Add(new DanhSachPhieu() { STT = 216, MaPhieu = "PCMCTTM", TenPhieu = "Phơi cấy máy can thiệp tim mạch", TrangThai = 1, DatabaseName = "PhoiCayMayCTTM" });
            lstDanhSachPhieu.Add(new DanhSachPhieu() { STT = 217, MaPhieu = "PMVCTTM", TenPhieu = "Phơi mạch vành can thiệp tim mạch", TrangThai = 1, DatabaseName = "PhoiMachVanhCTTM" });
            lstDanhSachPhieu.Add(new DanhSachPhieu() { STT = 218, MaPhieu = "DGTTTTTT", TenPhieu = "Đánh giá trạng thái tâm thần tối thiểu (MMSE)", TrangThai = 1, DatabaseName = "DanhGiaTrangThaiTTTT" });
            lstDanhSachPhieu.Add(new DanhSachPhieu() { STT = 219, MaPhieu = "CBCLGN", TenPhieu = "Chỉ bảo chất lượng giấc ngủ", TrangThai = 1, DatabaseName = "ChiBaoChatLuongGiacNgu" });
            lstDanhSachPhieu.Add(new DanhSachPhieu() { STT = 220, MaPhieu = "KQTLTNRM", TenPhieu = "Kết quả trả lời trắc nghiệm Raven màu", TrangThai = 1, DatabaseName = "KQTLTracNghiemRavenMau" });
            lstDanhSachPhieu.Add(new DanhSachPhieu() { STT = 221, MaPhieu = "BHSKBNPHQ", TenPhieu = "Bảng hỏi sức khỏe bệnh nhân PHQ-9", TrangThai = 1, DatabaseName = "BangHoiSucKhoeBNPHQ" });
            lstDanhSachPhieu.Add(new DanhSachPhieu() { STT = 222, MaPhieu = "DXLP", TenPhieu = "Đơn xin lại phim", TrangThai = 1, DatabaseName = "DonXinLaiPhim" });
            lstDanhSachPhieu.Add(new DanhSachPhieu() { STT = 223, MaPhieu = "TGTTTBL", TenPhieu = "Tờ giải thích tình trạng bệnh lý", TrangThai = 1, DatabaseName = "ToGiaiThichTTBL" });
            lstDanhSachPhieu.Add(new DanhSachPhieu() { STT = 224, MaPhieu = "PTDVCSSSSMD", TenPhieu = "Phiếu theo dõi và chăm sóc sơ sinh sau mổ đẻ", TrangThai = 1, DatabaseName = "PhieuTDVCSSSSauMoDe" });
            lstDanhSachPhieu.Add(new DanhSachPhieu() { STT = 225, MaPhieu = "PYCNS", TenPhieu = "Phiếu yêu cầu nội soi", TrangThai = 1, DatabaseName = "PhieuYeuCauNoiSoi" });
            lstDanhSachPhieu.Add(new DanhSachPhieu() { STT = 226, MaPhieu = "BBHCUB", TenPhieu = "Biên bản hội chẩn ung bướu", TrangThai = 1, DatabaseName = "BienBanHoiChanUngBuou" });
            lstDanhSachPhieu.Add(new DanhSachPhieu() { STT = 227, MaPhieu = "DGNBNVKHCS", TenPhieu = "Đánh giá người bệnh nhập viện/vào khoa và kế hoạch chăm sóc", TrangThai = 1, DatabaseName = "DanhGiaNBVaKHCS" });
            lstDanhSachPhieu.Add(new DanhSachPhieu() { STT = 228, MaPhieu = "PDTKL", TenPhieu = "Phiếu điều trị khoa Laser", TrangThai = 1, DatabaseName = "PhieuDieuTriKhoaLaser" });
            lstDanhSachPhieu.Add(new DanhSachPhieu() { STT = 229, MaPhieu = "PKNTT", TenPhieu = "Phiếu khám nghiệm tử thi", TrangThai = 1, DatabaseName = "KhamNghiemTuThi" });
            lstDanhSachPhieu.Add(new DanhSachPhieu() { STT = 230, MaPhieu = "PTDVCSNBKS", TenPhieu = "Phiếu theo dõi và chăm sóc người bệnh ( Khoa sản)", TrangThai = 1, DatabaseName = "PTDCSNBKhoaSan" });
            lstDanhSachPhieu.Add(new DanhSachPhieu() { STT = 231, MaPhieu = "PDGMDTKTE", TenPhieu = "Phiếu đánh giá mức độ tự kỉ của trẻ em", TrangThai = 1, DatabaseName = "PhieuDGMucDoTuKiTE" });
            lstDanhSachPhieu.Add(new DanhSachPhieu() { STT = 232, MaPhieu = "PSSDKL", TenPhieu = "Phiếu săn sóc da khoa laser", TrangThai = 1, DatabaseName = "PhieuSanSocDaKhoaLaser" });
            lstDanhSachPhieu.Add(new DanhSachPhieu() { STT = 233, MaPhieu = "PTMLS", TenPhieu = "Phiếu truyền máu lâm sàng", TrangThai = 1, DatabaseName = "PhieuTruyenMauLamSang" });
            lstDanhSachPhieu.Add(new DanhSachPhieu() { STT = 234, MaPhieu = "TTRCT", TenPhieu = "Thủ thuật rút chi thép", TrangThai = 1, DatabaseName = "ThuThuatRutChiThep" });
            lstDanhSachPhieu.Add(new DanhSachPhieu() { STT = 235, MaPhieu = "TTCHDMP", TenPhieu = "Thủ thuật chọc hút dịch màng phổi", TrangThai = 1, DatabaseName = "TTChocHutDichMangPhoi" });
            lstDanhSachPhieu.Add(new DanhSachPhieu() { STT = 236, MaPhieu = "TTKVM", TenPhieu = "Thủ thuật khâu vết mổ", TrangThai = 1, DatabaseName = "ThuThuatKhauVetMo" });
            lstDanhSachPhieu.Add(new DanhSachPhieu() { STT = 237, MaPhieu = "TTDDLMP", TenPhieu = "Thủ thuật đặt dẫn lưu màng phổi", TrangThai = 1, DatabaseName = "TTDatDLMangPhoi" });
            lstDanhSachPhieu.Add(new DanhSachPhieu() { STT = 238, MaPhieu = "BBTHTH", TenPhieu = "Biên bản tổng hợp thuốc hủy", TrangThai = 1, DatabaseName = "BienBanTongHopThuocHuy" });
            lstDanhSachPhieu.Add(new DanhSachPhieu() { STT = 239, MaPhieu = "PTTTDCDM", TenPhieu = "Phẫu thuật/thủ thuật đặt catheter động mạch", TrangThai = 1, DatabaseName = "ThuThuatDatCatheterDM" });
            lstDanhSachPhieu.Add(new DanhSachPhieu() { STT = 240, MaPhieu = "PTTTDCTMCT", TenPhieu = "Phẫu thuật/thủ thuật đặt catheter tĩnh mạch cảnh trong", TrangThai = 1, DatabaseName = "ThuThuatDatCatheterTMCT" });
            lstDanhSachPhieu.Add(new DanhSachPhieu() { STT = 241, MaPhieu = "PTTTDCTMD", TenPhieu = "Phẫu thuật/thủ thuật đặt catheter tĩnh mạch đùi", TrangThai = 1, DatabaseName = "ThuThuatDatCatheterTMDui" });
            lstDanhSachPhieu.Add(new DanhSachPhieu() { STT = 242, MaPhieu = "PTTTDNKQQMIENG", TenPhieu = "Phẫu thuật/thủ thuật đặt nội khí quản qua miệng", TrangThai = 1, DatabaseName = "ThuThuatDatNKQQuaMieng" });
            lstDanhSachPhieu.Add(new DanhSachPhieu() { STT = 243, MaPhieu = "PTTTDNKQQMUI", TenPhieu = "Phẫu thuật/thủ thuật đặt nội khí quản qua mũi", TrangThai = 1, DatabaseName = "ThuThuatDatNKQQuaMui" });
            lstDanhSachPhieu.Add(new DanhSachPhieu() { STT = 244, MaPhieu = "TTDCTMTT", TenPhieu = "Thủ thuật đặt Catheter tĩnh mạch trung tâm", TrangThai = 1, DatabaseName = "ThuThuatDatCatheterTMTT" });
            lstDanhSachPhieu.Add(new DanhSachPhieu() { STT = 245, MaPhieu = "BBHCDKS", TenPhieu = "Biên bản hội chẩn dùng kháng sinh", TrangThai = 1, DatabaseName = "BienBanHoiChanDungKS" });
            lstDanhSachPhieu.Add(new DanhSachPhieu() { STT = 246, MaPhieu = "GDMVCPM", TenPhieu = "Giấy đặt máu và chế phẩm máu", TrangThai = 1, DatabaseName = "GiayDatMauVaChePhamMau" });
            lstDanhSachPhieu.Add(new DanhSachPhieu() { STT = 247, MaPhieu = "PTDBNTI", TenPhieu = "Phiếu theo dõi bệnh nhân truyển Ilomedin", TrangThai = 1, DatabaseName = "PhieuTDBNTruyenILOMEDIN" });
            lstDanhSachPhieu.Add(new DanhSachPhieu() { STT = 248, MaPhieu = "PYCXN", TenPhieu = "Phiếu yêu cầu xét nghiệm", TrangThai = 1, DatabaseName = "PhieuYeuCauXetNghiem" });
            lstDanhSachPhieu.Add(new DanhSachPhieu() { STT = 249, MaPhieu = "PTDBNTE", TenPhieu = "Phiếu theo dõi bệnh nhân truyền endoxan", TrangThai = 1, DatabaseName = "PTDBNTruyenEndoxan" });
            lstDanhSachPhieu.Add(new DanhSachPhieu() { STT = 250, MaPhieu = "PKSL", TenPhieu = "Phiếu khảo sát loét", TrangThai = 1, DatabaseName = "PhieuKhaoSatLoet" });
            lstDanhSachPhieu.Add(new DanhSachPhieu() { STT = 251, MaPhieu = "CDPTGMHS3", TenPhieu = "Giấy cam đoan chấp nhận PTTT GMHS3", TrangThai = 1, DatabaseName = "CamDoanChapNhanPTTTGMHS3" });
            lstDanhSachPhieu.Add(new DanhSachPhieu() { STT = 252, MaPhieu = "PDDSXH", TenPhieu = "Phiếu điều dưỡng sốt xuất huyết", TrangThai = 1, DatabaseName = "PhieuDDSotXuatHuyet" });
            lstDanhSachPhieu.Add(new DanhSachPhieu() { STT = 253, MaPhieu = "PCKDVKCB", TenPhieu = "Phiếu công khai dịch vụ khám chữa bệnh", TrangThai = 1, DatabaseName = "PhieuCongKhaiDichVuKCB" });
            lstDanhSachPhieu.Add(new DanhSachPhieu() { STT = 254, MaPhieu = "PTDCSNBCT", TenPhieu = "Bảng theo dõi BN can thiệp", TrangThai = 1, DatabaseName = "PTDCSNBCT" });
            lstDanhSachPhieu.Add(new DanhSachPhieu() { STT = 255, MaPhieu = "PCSN", TenPhieu = "Phiếu chăm sóc Nhi", TrangThai = 1, DatabaseName = "PhieuCSNhi" });
            lstDanhSachPhieu.Add(new DanhSachPhieu() { STT = 256, MaPhieu = "PTMXN", TenPhieu = "Phiếu truyền máu xét nghiệm", TrangThai = 1, DatabaseName = "PhieuTruyenMauXetNghiem" });
            lstDanhSachPhieu.Add(new DanhSachPhieu() { STT = 257, MaPhieu = "GGTDTTCBNLKT", TenPhieu = "Giấy giới thiệu điều trị tiếp của bệnh nhân lao kháng thuốc", TrangThai = 1, DatabaseName = "GiayGTDTTCBNLaoKhangThuoc" });
            lstDanhSachPhieu.Add(new DanhSachPhieu() { STT = 258, MaPhieu = "PIPTMCT", TenPhieu = "Phơi IP tim mạch can thiệp", TrangThai = 1, DatabaseName = "PhoiIPTMCT" });
            lstDanhSachPhieu.Add(new DanhSachPhieu() { STT = 259, MaPhieu = "PTTG", TenPhieu = "Phiếu phẫu thuật glocom", TrangThai = 1, DatabaseName = "PhieuPhauThuatGlocom" });
            lstDanhSachPhieu.Add(new DanhSachPhieu() { STT = 260, MaPhieu = "PTTL", TenPhieu = "Phiếu phẫu thuật túi lệ", TrangThai = 1, DatabaseName = "PhieuPhauThuatTuiLe" });
            lstDanhSachPhieu.Add(new DanhSachPhieu() { STT = 261, MaPhieu = "PPTS", TenPhieu = "Phiếu phẩu thuật SAPEJKO", TrangThai = 1, DatabaseName = "PhieuPhauThuatSapejko" });
            lstDanhSachPhieu.Add(new DanhSachPhieu() { STT = 262, MaPhieu = "PDGDDNBNV", TenPhieu = "Phiếu đánh giá dinh dưỡng người bệnh nhập viện (SGA)", TrangThai = 1, DatabaseName = "PhieuDanhGiaDDNBNV" });
            lstDanhSachPhieu.Add(new DanhSachPhieu() { STT = 263, MaPhieu = "PCKTTN", TenPhieu = "Phiếu công khai thuốc theo ngày", TrangThai = 1, DatabaseName = "PhieuCongKhaiThuocTheoNgay" });
            lstDanhSachPhieu.Add(new DanhSachPhieu() { STT = 264, MaPhieu = "TTTNLW", TenPhieu = "Thang trí tuệ người lớn Wechsler", TrangThai = 1, DatabaseName = "TriTueNguoiLonWechsler" });
            lstDanhSachPhieu.Add(new DanhSachPhieu() { STT = 265, MaPhieu = "GCKDYCTKCL", TenPhieu = "Giấy cam kết đồng ý chi trả khoản chênh lệch", TrangThai = 1, DatabaseName = "GiayCamKetDYCTKCL" });
            lstDanhSachPhieu.Add(new DanhSachPhieu() { STT = 266, MaPhieu = "PTSM", TenPhieu = "Phiếu phẫu thuật sụp mi", TrangThai = 1, DatabaseName = "PhieuPhauThuatSupMi" });
            lstDanhSachPhieu.Add(new DanhSachPhieu() { STT = 267, MaPhieu = "PPTL", TenPhieu = "Phiếu phẫu thuật lác", TrangThai = 1, DatabaseName = "PhieuPhauThuatLac" });
            lstDanhSachPhieu.Add(new DanhSachPhieu() { STT = 268, MaPhieu = "PDGNC", TenPhieu = "Phiếu đánh giá nhân cách - MINI – MMPI (MMPI rút gọn)", TrangThai = 1, DatabaseName = "PhieuDGNhanCach" });
            lstDanhSachPhieu.Add(new DanhSachPhieu() { STT = 269, MaPhieu = "HSTX", TenPhieu = "Hồ sơ trị xạ", TrangThai = 1, DatabaseName = "HoSoTriXa" });
            lstDanhSachPhieu.Add(new DanhSachPhieu() { STT = 270, MaPhieu = "PGMXNHIV", TenPhieu = "Phiếu gửi mẫu xét nghiệm HIV", TrangThai = 1, DatabaseName = "PhieuGuiMauXetNghiemHIV" });
            lstDanhSachPhieu.Add(new DanhSachPhieu() { STT = 271, MaPhieu = "PLGHDCN", TenPhieu = "Phiếu lượng giá hoạt động chức năng và sự tham gia", TrangThai = 1, DatabaseName = "PhieuLuongGiaHDCNVaSTG" });
            lstDanhSachPhieu.Add(new DanhSachPhieu() { STT = 272, MaPhieu = "PTDVCSNBC23_3", TenPhieu = "Phiếu theo dõi và chăm sóc cấp người bệnh cấp II, III(Mẫu 3)", TrangThai = 1, DatabaseName = "PTDVCSNBC23_3" });
            lstDanhSachPhieu.Add(new DanhSachPhieu() { STT = 273, MaPhieu = "PTDVCSNBC1_2", TenPhieu = "Phiếu theo dõi và chăm sóc cấp 1(Mẫu 2)", TrangThai = 1, DatabaseName = "PTDVCSNBC1_2" });
            lstDanhSachPhieu.Add(new DanhSachPhieu() { STT = 274, MaPhieu = "PSLDDNB", TenPhieu = "Phiếu sàng lọc dinh dưỡng", TrangThai = 1, DatabaseName = "PSLDDNB" });
            lstDanhSachPhieu.Add(new DanhSachPhieu() { STT = 275, MaPhieu = "PXNDYXNHIV", TenPhieu = "Phiếu xác nhận đồng ý xét nghiệm HIV", TrangThai = 1, DatabaseName = "PXNDYXNHIV" });
            lstDanhSachPhieu.Add(new DanhSachPhieu() { STT = 276, MaPhieu = "BKDCVTYTNLTT", TenPhieu = "Bảng kiểm dụng cụ - vật tư y tế người bệnh làm thủ thuật", TrangThai = 1, DatabaseName = "BKDCVTYTNLTT" });
            lstDanhSachPhieu.Add(new DanhSachPhieu() { STT = 277, MaPhieu = "BKDCVTYPT", TenPhieu = "Bảng kiểm dụng cụ - Vật tư y tế phẫu thuật", TrangThai = 1, DatabaseName = "BKDCVTYPT" });
            lstDanhSachPhieu.Add(new DanhSachPhieu() { STT = 278, MaPhieu = "PCBVBGNBTPTTT", TenPhieu = "Phiếu chuẩn bị và ban giao người bệnh trước phẫu thuật thủ thuật", TrangThai = 1, DatabaseName = "PCBVBGNBTPTTT" });
            lstDanhSachPhieu.Add(new DanhSachPhieu() { STT = 279, MaPhieu = "PTHKTPHCN", TenPhieu = "Phiếu thực hiện kỹ thuật phục hồi chức năng", TrangThai = 1, DatabaseName = "PTHKTPHCN" });
            lstDanhSachPhieu.Add(new DanhSachPhieu() { STT = 280, MaPhieu = "PKVCDPHCN", TenPhieu = "Phiếu khám và chỉ định phục hồi chức năng", TrangThai = 1, DatabaseName = "PKVCDPHCN" });
            lstDanhSachPhieu.Add(new DanhSachPhieu() { STT = 281, MaPhieu = "PTTTTCB", TenPhieu = "Phiếu phẫu thuật thể thủy tinh phối hợp cắt bè", TrangThai = 1, DatabaseName = "PhieuPhuatThuatTTTCB" });
            lstDanhSachPhieu.Add(new DanhSachPhieu() { STT = 282, MaPhieu = "BCKKPTTTE", TenPhieu = "Bản cam kết Khoa phẫu thuật tim trẻ em", TrangThai = 1, DatabaseName = "BanCamKetKhoaPTTTE" });
            lstDanhSachPhieu.Add(new DanhSachPhieu() { STT = 283, MaPhieu = "GMHC", TenPhieu = "Giấy mời hội chẩn", TrangThai = 1, DatabaseName = "GiayMoiHoiChan" });
            lstDanhSachPhieu.Add(new DanhSachPhieu() { STT = 284, MaPhieu = "BKANTT", TenPhieu = "Bảng kiểm an toàn thủ thuật", TrangThai = 1, DatabaseName = "BangKiemAnToanThuThuat" });
            lstDanhSachPhieu.Add(new DanhSachPhieu() { STT = 285, MaPhieu = "BKANPT", TenPhieu = "Bảng kiểm an toàn phẫu thuật", TrangThai = 1, DatabaseName = "BangKiemAnToanThuThuat" });
            lstDanhSachPhieu.Add(new DanhSachPhieu() { STT = 286, MaPhieu = "PXNMMM", TenPhieu = "Phiếu xét nghiệm đường máu mao mạch", TrangThai = 1, DatabaseName = "PhieuXNMauMaoMach" });
            lstDanhSachPhieu.Add(new DanhSachPhieu() { STT = 287, MaPhieu = "TDU", TenPhieu = "Thẻ dị ứng", TrangThai = 1, DatabaseName = "TheDiUng" });
            lstDanhSachPhieu.Add(new DanhSachPhieu() { STT = 288, MaPhieu = "PKTTSDU", TenPhieu = "Phiếu khai thác tiền sử dị ứng", TrangThai = 1, DatabaseName = "PhieuKhaiThacTienSuDiUng" });
            lstDanhSachPhieu.Add(new DanhSachPhieu() { STT = 289, MaPhieu = "PTPUT", TenPhieu = "Phiếu thử phản ứng thuốc", TrangThai = 1, DatabaseName = "PTPUT" });
            lstDanhSachPhieu.Add(new DanhSachPhieu() { STT = 290, MaPhieu = "BBHCTPT", TenPhieu = "Biên bản hội chẩn trước phẫu thuật", TrangThai = 1, DatabaseName = "BBHCTPT" });
            lstDanhSachPhieu.Add(new DanhSachPhieu() { STT = 291, MaPhieu = "BBHCTTT", TenPhieu = "Biên bản hội chẩn trước thủ thuật", TrangThai = 1, DatabaseName = "BBHCTTT" });
            lstDanhSachPhieu.Add(new DanhSachPhieu() { STT = 292, MaPhieu = "BTDLM2", TenPhieu = "Bảng theo dõi lọc máu 2", TrangThai = 1, DatabaseName = "BangTheoDoiLocMau2" });
            lstDanhSachPhieu.Add(new DanhSachPhieu() { STT = 293, MaPhieu = "PTT", TenPhieu = "Phiếu thủ thuật", TrangThai = 1, DatabaseName = "PhieuThuThuat" });
            lstDanhSachPhieu.Add(new DanhSachPhieu() { STT = 294, MaPhieu = "BTDBNHTN", TenPhieu = "Bảng theo dõi bệnh nhân hạ thân nhiệt", TrangThai = 1, DatabaseName = "BangTDBNHaThanNhiet" });
            lstDanhSachPhieu.Add(new DanhSachPhieu() { STT = 295, MaPhieu = "PSLDDBNNT", TenPhieu = "Phiếu sàng lọc dinh dưỡng bệnh nhân ngoại trú", TrangThai = 1, DatabaseName = "PhieuDGDinhDuongBNNgoaiTru" });
            lstDanhSachPhieu.Add(new DanhSachPhieu() { STT = 296, MaPhieu = "PDTCMCV", TenPhieu = "Phiếu điều tra ca mắc covid-19", TrangThai = 1, DatabaseName = "PhieuDieuTraCaMacCovid" });
            lstDanhSachPhieu.Add(new DanhSachPhieu() { STT = 297, MaPhieu = "PTDTD", TenPhieu = "Phiếu theo dõi truyền dịch", TrangThai = 1, DatabaseName = "PhieuChiTietTruyenDich2" });
            lstDanhSachPhieu.Add(new DanhSachPhieu() { STT = 298, MaPhieu = "BTDLM3", TenPhieu = "Bảng theo dõi lọc máu 3", TrangThai = 1, DatabaseName = "BangTheoDoiLocMau3" });
            lstDanhSachPhieu.Add(new DanhSachPhieu() { STT = 299, MaPhieu = "BKSDTVTTHMCBN", TenPhieu = "Bảng kê sử dụng thuốc - VTTH - Máu cho bệnh nhân", TrangThai = 1, DatabaseName = "BKSDTVTTHMCBN" });
            lstDanhSachPhieu.Add(new DanhSachPhieu() { STT = 300, MaPhieu = "PTDVCSNBTN", TenPhieu = "Phiếu theo dõi và chăm sóc người bệnh trong ngày", TrangThai = 1, DatabaseName = "PTDVCSNBTN" });
            lstDanhSachPhieu.Add(new DanhSachPhieu() { STT = 301, MaPhieu = "PSLDDBNNNT", TenPhieu = "Phiếu sàng lọc dinh dưỡng bệnh nhân nhi ngoại trú", TrangThai = 1, DatabaseName = "PhieuSLDDBNNhiNgoaiTru" });
            lstDanhSachPhieu.Add(new DanhSachPhieu() { STT = 302, MaPhieu = "PSLVDGTTDDBNNT", TenPhieu = "Phiếu sàng lọc và đánh giá tình trạng dinh dưỡng bệnh nhân nội trú", TrangThai = 1, DatabaseName = "PhieuSLVDGTTDDBNNoiTru" });
            lstDanhSachPhieu.Add(new DanhSachPhieu() { STT = 303, MaPhieu = "CDCNTTTMGMHS", TenPhieu = "Giấy cam đoạn chấp nhận  thủ thuật tim mạch can thiệp và gây mê hồi sức", TrangThai = 1, DatabaseName = "CamDoanChapNhanTTTMVGMHS" });
            lstDanhSachPhieu.Add(new DanhSachPhieu() { STT = 304, MaPhieu = "GCKDT", TenPhieu = "Giấy cam kết điều trị", TrangThai = 1, DatabaseName = "GiayCamKetDieuTri" });
            lstDanhSachPhieu.Add(new DanhSachPhieu() { STT = 305, MaPhieu = "MPPTSDT", TenPhieu = "Mẫu phiếu phân tích sử dụng thuốc", TrangThai = 1, DatabaseName = "MauPhieuPTSDThuoc" });
            lstDanhSachPhieu.Add(new DanhSachPhieu() { STT = 306, MaPhieu = "KHCSNBCV", TenPhieu = "Kế hoạch chăm sóc người bệnh covid-19", TrangThai = 1, DatabaseName = "KHCSNBCovid19" });
            lstDanhSachPhieu.Add(new DanhSachPhieu() { STT = 307, MaPhieu = "CDCNPTTTGMHS_BN", TenPhieu = "Giấy cam đoạn chấp nhận phẫu thuật thủ thuật và gây mê hồi sức", TrangThai = 1, DatabaseName = "CamDoanChapNhanPTTTGMHS3" });
            lstDanhSachPhieu.Add(new DanhSachPhieu() { STT = 308, MaPhieu = "BBXNBNBV", TenPhieu = "Biên bản xác nhận bệnh nhân bỏ viện", TrangThai = 1, DatabaseName = "BienBanXacNhanBNBoVien" });
            lstDanhSachPhieu.Add(new DanhSachPhieu() { STT = 309, MaPhieu = "PXNBNKCMTKP", TenPhieu = "Phiếu xác nhận bệnh nhân không có mặt tại khoa phòng", TrangThai = 1, DatabaseName = "PXNBNKCMTKP" });
            lstDanhSachPhieu.Add(new DanhSachPhieu() { STT = 310, MaPhieu = "GCDCTCTNT", TenPhieu = "Giấy cam đoan chấp nhận chạy thận nhân tạo", TrangThai = 1, DatabaseName = "GCDCTCTNT" });
            lstDanhSachPhieu.Add(new DanhSachPhieu() { STT = 311, MaPhieu = "BKANTTCTTM2", TenPhieu = "Bảng kiểm an toàn thủ thuật và can thiệp tim mạch", TrangThai = 1, DatabaseName = "BangKiemAnToanTT_CTTM2" });
            lstDanhSachPhieu.Add(new DanhSachPhieu() { STT = 312, MaPhieu = "GCDCNSDDVTYC", TenPhieu = "Giấy cam đoan chấp nhận sử dụng dịch vụ theo yêu cầu", TrangThai = 1, DatabaseName = "GiayCamDoanCNSDDVTYC" });
            lstDanhSachPhieu.Add(new DanhSachPhieu() { STT = 313, MaPhieu = "GCDCNPTTTGMHS4", TenPhieu = "Giấy cam đoan chấp nhận phẫu thuật, thủ thuật và gây mê hồi sức 4", TrangThai = 1, DatabaseName = "GiayCamDoanCNPTTTGMHS4" });
            lstDanhSachPhieu.Add(new DanhSachPhieu() { STT = 314, MaPhieu = "PTDBNTT", TenPhieu = "Phiếu theo dõi bệnh nhân truyền thuốc", TrangThai = 1, DatabaseName = "PhieuTDBNTruyenThuoc" });
            lstDanhSachPhieu.Add(new DanhSachPhieu() { STT = 315, MaPhieu = "PKGMTPTTT", TenPhieu = "Phiếu khám gây mê trước phẫu thuật thủ thuật", TrangThai = 1, DatabaseName = "PhieuKhamGayMeTruocPTTT" });
            lstDanhSachPhieu.Add(new DanhSachPhieu() { STT = 316, MaPhieu = "BKTDC", TenPhieu = "Bảng kiểm tra dụng cụ", TrangThai = 1, DatabaseName = "BangKiemTraDungCu" });
            lstDanhSachPhieu.Add(new DanhSachPhieu() { STT = 317, MaPhieu = "BCTBTM", TenPhieu = "Báo cáo tai biến không mong muốn liên quan đến truyền máu", TrangThai = 1, DatabaseName = "BaoCaoTaiBienTruyenMau" });
            lstDanhSachPhieu.Add(new DanhSachPhieu() { STT = 318, MaPhieu = "GCDCNSDTTDTCNN", TenPhieu = "Giấy cam đoan chấp nhận sử dụng thuốc trong điều trị cho người nhà bệnh nhân", TrangThai = 1, DatabaseName = "NguoiNhaCamDoanSDTTDT" });
            lstDanhSachPhieu.Add(new DanhSachPhieu() { STT = 319, MaPhieu = "PTDVDTLM", TenPhieu = "Phiếu theo dõi và điều trị lọc máu", TrangThai = 1, DatabaseName = "PTDVDTLM" });
            lstDanhSachPhieu.Add(new DanhSachPhieu() { STT = 320, MaPhieu = "PTVHDGDSK", TenPhieu = "Phiếu tư vấn, hướng dẫn - giáo dục sức khỏe", TrangThai = 1, DatabaseName = "PTVHDGDSK" });
            lstDanhSachPhieu.Add(new DanhSachPhieu() { STT = 321, MaPhieu = "PTDBNC", TenPhieu = "Phiếu theo dõi bênh nhân Covid", TrangThai = 1, DatabaseName = "PhieuTheoDoiBenhNhanCovid" });
            lstDanhSachPhieu.Add(new DanhSachPhieu() { STT = 322, MaPhieu = "GCDCNTTTMCTVGMHS", TenPhieu = "Giấy cam đoan chấp nhận thủ thuật tim mạch can thiệp và gây mê hồi sức", TrangThai = 1, DatabaseName = "GCDCNTTTMCTVGMHS" });
            lstDanhSachPhieu.Add(new DanhSachPhieu() { STT = 323, MaPhieu = "CD2", TenPhieu = "Phiếu chuyển dạ 2", TrangThai = 1, DatabaseName = "BIEUDOCHUYENDA2" });
            lstDanhSachPhieu.Add(new DanhSachPhieu() { STT = 324, MaPhieu = "GCDCNPTTTGMHS5", TenPhieu = "Giấy cam đoan chấp nhận phẫu thuật, thủ thuật và gây mê hồi sức 5", TrangThai = 1, DatabaseName = "GiayCamDoanCNPTTTGMHS5" });
            lstDanhSachPhieu.Add(new DanhSachPhieu() { STT = 325, MaPhieu = "PKDTV", TenPhieu = "Phiếu kiểm điểm tử vong", TrangThai = 1, DatabaseName = "PhieuKiemDiemTuVong" });
            lstDanhSachPhieu.Add(new DanhSachPhieu() { STT = 326, MaPhieu = "BKATDQ", TenPhieu = "Bảng kiểm an toàn điện quang", TrangThai = 1, DatabaseName = "BangKiemAnToanDienQuang" });
            lstDanhSachPhieu.Add(new DanhSachPhieu() { STT = 327, MaPhieu = "PSLDGDDTE", TenPhieu = "Phiếu sàng lọc đánh giá dinh dưỡng trẻ em", TrangThai = 1, DatabaseName = "PhieuSangLocDGDDTE" });
            lstDanhSachPhieu.Add(new DanhSachPhieu() { STT = 328, MaPhieu = "GCNTT", TenPhieu = "Giấy chứng nhận thương tích", TrangThai = 1, DatabaseName = "GiayChungNhanThuongTich" });
            lstDanhSachPhieu.Add(new DanhSachPhieu() { STT = 329, MaPhieu = "PTDCSBNTN", TenPhieu = "Phiếu theo dõi và chăm sóc người bệnh trong ngày", TrangThai = 1, DatabaseName = "PhieuTheoDoiVaChamSocBNTN" });
            lstDanhSachPhieu.Add(new DanhSachPhieu() { STT = 330, MaPhieu = "PSLDDCPNMT", TenPhieu = "Phiếu sàng lọc dinh dưỡng cho phụ nữ mang thai", TrangThai = 1, DatabaseName = "PhieuSLDDChoPNMT" });
            lstDanhSachPhieu.Add(new DanhSachPhieu() { STT = 331, MaPhieu = "GCKDYDTTBLMC", TenPhieu = "Giấy cam kết đồng ý điều trị bệnh lý mạch cảnh", TrangThai = 1, DatabaseName = "GiayCamKetDongYDTBLMC" });
            lstDanhSachPhieu.Add(new DanhSachPhieu() { STT = 332, MaPhieu = "BKTTSATQTQ", TenPhieu = "Bảng kiểm tra trước siêu âm tim qua thực quản", TrangThai = 1, DatabaseName = "BangKiemTraTruocSATQTQ" });
            lstDanhSachPhieu.Add(new DanhSachPhieu() { STT = 333, MaPhieu = "GCKDYDTBLRLN", TenPhieu = "Giấy cam kết đồng ý điều trị bệnh lý rối loạn nhịp", TrangThai = 1, DatabaseName = "KhaoSatDienSinhLyCDVDT" });
            lstDanhSachPhieu.Add(new DanhSachPhieu() { STT = 334, MaPhieu = "DTRLNTBRF", TenPhieu = "Điều trị rối loạn nhịp tim bằng năng lượng sóng có tần số radio", TrangThai = 1, DatabaseName = "DieuTriRoiLoanNTBangRF" });
            lstDanhSachPhieu.Add(new DanhSachPhieu() { STT = 335, MaPhieu = "PDCNHH", TenPhieu = "Phiếu đo chức năng hô hấp", TrangThai = 1, DatabaseName = "PhieuDoChucNangHoHap" });
            lstDanhSachPhieu.Add(new DanhSachPhieu() { STT = 336, MaPhieu = "PXNDNB", TenPhieu = "Phiếu xác nhận đúng người bệnh", TrangThai = 1, DatabaseName = "PhieuXacNhanDungNguoiBenh" });
            lstDanhSachPhieu.Add(new DanhSachPhieu() { STT = 337, MaPhieu = "GXNDTCovid", TenPhieu = "Giấy xác nhận đã tiêm vắc xin covid-19", TrangThai = 1, DatabaseName = "GXNDTCovid" });
            lstDanhSachPhieu.Add(new DanhSachPhieu() { STT = 338, MaPhieu = "BCPUCHCT", TenPhieu = "Báo cáo phản ứng có hại của thuốc", TrangThai = 1, DatabaseName = "BaoCaoPhanUngCoHaiCuaThuoc" });
            lstDanhSachPhieu.Add(new DanhSachPhieu() { STT = 339, MaPhieu = "TCCPUCH", TenPhieu = "Thẻ cảnh cáo phản ứng có hại của người bệnh", TrangThai = 1, DatabaseName = "TCCPUCH" });
            lstDanhSachPhieu.Add(new DanhSachPhieu() { STT = 340, MaPhieu = "DXXNNV", TenPhieu = "Đơn xin xác nhận nằm viện", TrangThai = 1, DatabaseName = "DonXinXacNhanNamVien" });
            lstDanhSachPhieu.Add(new DanhSachPhieu() { STT = 341, MaPhieu = "GHSATQTQ", TenPhieu = "Giấy hẹn siêu âm tim qua thực quản", TrangThai = 1, DatabaseName = "GiayHenSieuAmTimQTQ" });
            lstDanhSachPhieu.Add(new DanhSachPhieu() { STT = 342, MaPhieu = "GCDLSATQTQ", TenPhieu = "Giấy cam đoan làm siêu âm tim qua thực quản", TrangThai = 1, DatabaseName = "GiayCamDoanLSATQTQ" });
            lstDanhSachPhieu.Add(new DanhSachPhieu() { STT = 343, MaPhieu = "GHDMHOLTER", TenPhieu = "Giấy hẹn đeo máy Holter", TrangThai = 1, DatabaseName = "GiayHenDeoMayHOLTER" });
            lstDanhSachPhieu.Add(new DanhSachPhieu() { STT = 344, MaPhieu = "PCKDVKCBNTTN", TenPhieu = "Phiếu công khai dịch vụ khám chữa bệnh nội trú theo ngày", TrangThai = 1, DatabaseName = "PhieuCongKhaiDichVuKCBNTTN" });
            lstDanhSachPhieu.Add(new DanhSachPhieu() { STT = 345, MaPhieu = "PXNTBKMMTM", TenPhieu = "Phiếu xét nghiệm tai biến không mong muốn liên quan đến truyền máu", TrangThai = 1, DatabaseName = "PhieuXNTBKMMLienQuanTM" });
            lstDanhSachPhieu.Add(new DanhSachPhieu() { STT = 346, MaPhieu = "PTDVCSNOIKHOA", TenPhieu = "Phiếu theo dõi và chăm sóc nội khoa", TrangThai = 1, DatabaseName = "PhieuTDVCSBNNoiKhoa" });
            lstDanhSachPhieu.Add(new DanhSachPhieu() { STT = 347, MaPhieu = "PPTBMNC", TenPhieu = "Phiếu phẫu thuật bề mặt nhãn cầu", TrangThai = 1, DatabaseName = "PhieuPhauThuatBeMatNhanCau" });
            lstDanhSachPhieu.Add(new DanhSachPhieu() { STT = 348, MaPhieu = "GCDLDTDGS", TenPhieu = "Giấy cam đoan làm điện tâm đồ gắng sức", TrangThai = 1, DatabaseName = "GiayCamDoanLDTDGS" });
            lstDanhSachPhieu.Add(new DanhSachPhieu() { STT = 349, MaPhieu = "PTDVCSNGOAIKHOA", TenPhieu = "Phiếu theo dõi và chăm sóc ngoại khoa", TrangThai = 1, DatabaseName = "PhieuTDVCSBNNgoaiKhoa" });
            lstDanhSachPhieu.Add(new DanhSachPhieu() { STT = 350, MaPhieu = "PTDCSNBTKCC", TenPhieu = "Phiếu theo dõi và chăm sóc người bệnh tại khoa cấp cứu", TrangThai = 1, DatabaseName = "PhieuTDCSNBTaiKhoaCapCuu" });
            lstDanhSachPhieu.Add(new DanhSachPhieu() { STT = 351, MaPhieu = "PTDVCSSAN", TenPhieu = "Phiếu theo dõi và chăm sóc sản", TrangThai = 1, DatabaseName = "PhieuTDVCSBNSan" });
            lstDanhSachPhieu.Add(new DanhSachPhieu() { STT = (int)DanhMucPhieu.CBBNCMSCT, MaPhieu = DanhMucPhieu.CBBNCMSCT.ToString(), TenPhieu = DanhMucPhieu.CBBNCMSCT.Description() , TrangThai = 1, DatabaseName = "ChuanBiBenhNhanChupMSCT" });
            lstDanhSachPhieu.Add(new DanhSachPhieu() { STT = (int)DanhMucPhieu.PTDVCSRHM, MaPhieu = DanhMucPhieu.PTDVCSRHM.ToString(), TenPhieu = DanhMucPhieu.PTDVCSRHM.Description() , TrangThai = 1, DatabaseName = "PhieuTDVCSBNRHM" });
            lstDanhSachPhieu.Add(new DanhSachPhieu() { STT = (int)DanhMucPhieu.PTDVCSKM, MaPhieu = DanhMucPhieu.PTDVCSKM.ToString(), TenPhieu = DanhMucPhieu.PTDVCSKM.Description() , TrangThai = 1, DatabaseName = "PhieuTDVCSBNKhoaMat" });
            lstDanhSachPhieu.Add(new DanhSachPhieu() { STT = (int)DanhMucPhieu.GCDDMHDTDHA, MaPhieu = DanhMucPhieu.GCDDMHDTDHA.ToString(), TenPhieu = DanhMucPhieu.GCDDMHDTDHA.Description() , TrangThai = 1, DatabaseName = "GiayCamDoanDeoMayHolterDTDHA" });
            lstDanhSachPhieu.Add(new DanhSachPhieu() { STT = (int)DanhMucPhieu.GCKBNXRV, MaPhieu = DanhMucPhieu.GCKBNXRV.ToString(), TenPhieu = DanhMucPhieu.GCKBNXRV.Description() , TrangThai = 1, DatabaseName = "GiayCamKetBenhNhanXinRaVien" });
            lstDanhSachPhieu.Add(new DanhSachPhieu() { STT = (int)DanhMucPhieu.GCDCNTTCTTMC, MaPhieu = DanhMucPhieu.GCDCNTTCTTMC.ToString(), TenPhieu = DanhMucPhieu.GCDCNTTCTTMC.Description(), TrangThai = 1, DatabaseName = "GiayCamDoanChapNhanTTCTTMC" });
            lstDanhSachPhieu.Add(new DanhSachPhieu() { STT = (int)DanhMucPhieu.GCKCNTTDCDM, MaPhieu = DanhMucPhieu.GCKCNTTDCDM.ToString(), TenPhieu = DanhMucPhieu.GCKCNTTDCDM.Description(), TrangThai = 1, DatabaseName = "GiayCamKetChapNhanTTDCDM" });
            lstDanhSachPhieu.Add(new DanhSachPhieu() { STT = (int)DanhMucPhieu.GCKTTPTCT, MaPhieu = DanhMucPhieu.GCKTTPTCT.ToString(), TenPhieu = DanhMucPhieu.GCKTTPTCT.Description() , TrangThai = 1, DatabaseName = "GiayCamKetThieuTienPTCT" });
            lstDanhSachPhieu.Add(new DanhSachPhieu() { STT = (int)DanhMucPhieu.GCDDYTTDQT, MaPhieu = DanhMucPhieu.GCDDYTTDQT.ToString(), TenPhieu = DanhMucPhieu.GCDDYTTDQT.Description() , TrangThai = 1, DatabaseName = "GiayCamDoanDYTTDQT" });
            lstDanhSachPhieu.Add(new DanhSachPhieu() { STT = (int)DanhMucPhieu.GCKCNTTDONKQ, MaPhieu = DanhMucPhieu.GCKCNTTDONKQ.ToString(), TenPhieu = DanhMucPhieu.GCKCNTTDONKQ.Description() , TrangThai = 1, DatabaseName = "GiayCamKetChapNhanTTDONKQ" });
            lstDanhSachPhieu.Add(new DanhSachPhieu() { STT = (int)DanhMucPhieu.GCKCNTTDCTMTT, MaPhieu = DanhMucPhieu.GCKCNTTDCTMTT.ToString(), TenPhieu = DanhMucPhieu.GCKCNTTDCTMTT.Description() , TrangThai = 1, DatabaseName = "GiayCamKetChapNhanTTDCTMTT" });
            lstDanhSachPhieu.Add(new DanhSachPhieu() { STT = (int)DanhMucPhieu.GCKCNTTSD, MaPhieu = DanhMucPhieu.GCKCNTTSD.ToString(), TenPhieu = DanhMucPhieu.GCKCNTTSD.Description() , TrangThai = 1, DatabaseName = "GiayCamKetChapNhanTTSD" });
            lstDanhSachPhieu.Add(new DanhSachPhieu() { STT = (int)DanhMucPhieu.PSLVDGTTDDNBNT, MaPhieu = DanhMucPhieu.PSLVDGTTDDNBNT.ToString(), TenPhieu = DanhMucPhieu.PSLVDGTTDDNBNT.Description() , TrangThai = 1, DatabaseName = "PhieuSLVDGTTDDNBNT" });
            lstDanhSachPhieu.Add(new DanhSachPhieu() { STT = (int)DanhMucPhieu.BKVTTHPTTT, MaPhieu = DanhMucPhieu.BKVTTHPTTT.ToString(), TenPhieu = DanhMucPhieu.BKVTTHPTTT.Description(), TrangThai = 1, DatabaseName = "BangKeVTTHPhongPTTT" });
            lstDanhSachPhieu.Add(new DanhSachPhieu() { STT = (int)DanhMucPhieu.BKTPTTT, MaPhieu = DanhMucPhieu.BKTPTTT.ToString(), TenPhieu = DanhMucPhieu.BKTPTTT.Description(), TrangThai = 1, DatabaseName = "BangKeThuocPhongPTTT" });
            lstDanhSachPhieu.Add(new DanhSachPhieu() { STT = (int)DanhMucPhieu.PYCSDKSHCPD, MaPhieu = DanhMucPhieu.PYCSDKSHCPD.ToString(), TenPhieu = DanhMucPhieu.PYCSDKSHCPD.Description(), TrangThai = 1, DatabaseName = "PhieuYCSDKhangSinhHCPD" });
            lstDanhSachPhieu.Add(new DanhSachPhieu() { STT = (int)DanhMucPhieu.DDNTHKTHTSS, MaPhieu = DanhMucPhieu.DDNTHKTHTSS.ToString(), TenPhieu = DanhMucPhieu.DDNTHKTHTSS.Description(), TrangThai = 1, DatabaseName = "DonDeNghiTHKTHoTroSinhSan" });
            lstDanhSachPhieu.Add(new DanhSachPhieu() { STT = (int)DanhMucPhieu.PCDNNTV, MaPhieu = DanhMucPhieu.PCDNNTV.ToString(), TenPhieu = DanhMucPhieu.PCDNNTV.Description(), TrangThai = 1, DatabaseName = "PhieuCDNguyenNhanTuVong" });
            lstDanhSachPhieu.Add(new DanhSachPhieu() { STT = (int)DanhMucPhieu.BBBGBNDTKCOVID, MaPhieu = DanhMucPhieu.BBBGBNDTKCOVID.ToString(), TenPhieu = DanhMucPhieu.BBBGBNDTKCOVID.Description(), TrangThai = 1, DatabaseName = "BienBanBGBNCongBoKhoiCovid" });
            lstDanhSachPhieu.Add(new DanhSachPhieu() { STT = (int)DanhMucPhieu.GCKCNTTCDMTMP, MaPhieu = DanhMucPhieu.GCKCNTTCDMTMP.ToString(), TenPhieu = DanhMucPhieu.GCKCNTTCDMTMP.Description(), TrangThai = 1, DatabaseName = "GiayCamKetChapNhanTTCDMTMP" });
            lstDanhSachPhieu.Add(new DanhSachPhieu() { STT = (int)DanhMucPhieu.GDNTHCLPCDCOVID, MaPhieu = DanhMucPhieu.GDNTHCLPCDCOVID.ToString(), TenPhieu = DanhMucPhieu.GDNTHCLPCDCOVID.Description(), TrangThai = 1, DatabaseName = "GiayDeNghiTHCLPCDCovid" });
            lstDanhSachPhieu.Add(new DanhSachPhieu() { STT = (int)DanhMucPhieu.BCKCOVID, MaPhieu = DanhMucPhieu.BCKCOVID.ToString(), TenPhieu = DanhMucPhieu.BCKCOVID.Description(), TrangThai = 1, DatabaseName = "BanCamKetCovid" });
            lstDanhSachPhieu.Add(new DanhSachPhieu() { STT = (int)DanhMucPhieu.CKTTON, MaPhieu = DanhMucPhieu.CKTTON.ToString(), TenPhieu = DanhMucPhieu.CKTTON.Description(), TrangThai = 1, DatabaseName = "CamKetThuTinhOngNghiem" });
            lstDanhSachPhieu.Add(new DanhSachPhieu() { STT = (int)DanhMucPhieu.GCKBNCV, MaPhieu = DanhMucPhieu.GCKBNCV.ToString(), TenPhieu = DanhMucPhieu.GCKBNCV.Description(), TrangThai = 1, DatabaseName = "GiayCamKetBenhNhanChuyenVien" });
            lstDanhSachPhieu.Add(new DanhSachPhieu() { STT = (int)DanhMucPhieu.GPBST, MaPhieu = DanhMucPhieu.GPBST.ToString(), TenPhieu = DanhMucPhieu.GPBST.Description(), TrangThai = 1, DatabaseName = "GiaiPhauBenhSinhThiet" });
            lstDanhSachPhieu.Add(new DanhSachPhieu() { STT = (int)DanhMucPhieu.TBDTCTC, MaPhieu = DanhMucPhieu.TBDTCTC.ToString(), TenPhieu = DanhMucPhieu.TBDTCTC.Description(), TrangThai = 1, DatabaseName = "ThongBaoDTCovidThanhCong" });
            lstDanhSachPhieu.Add(new DanhSachPhieu() { STT = (int)DanhMucPhieu.GBT, MaPhieu = DanhMucPhieu.GBT.ToString(), TenPhieu = DanhMucPhieu.GBT.Description(), TrangThai = 1, DatabaseName = "GiayBaoTu" });
            lstDanhSachPhieu.Add(new DanhSachPhieu() { STT = (int)DanhMucPhieu.CKSDGDVTTTON, MaPhieu = DanhMucPhieu.CKSDGDVTTTON.ToString(), TenPhieu = DanhMucPhieu.CKSDGDVTTTON.Description(), TrangThai = 1, DatabaseName = "CamKetSDGDVTTTOngNghiem" });
            lstDanhSachPhieu.Add(new DanhSachPhieu() { STT = (int)DanhMucPhieu.CKBTTVBTC, MaPhieu = DanhMucPhieu.CKBTTVBTC.ToString(), TenPhieu = DanhMucPhieu.CKBTTVBTC.Description(), TrangThai = 1, DatabaseName = "CamKetBomTTVBTC" });
            lstDanhSachPhieu.Add(new DanhSachPhieu() { STT = (int)DanhMucPhieu.BCKTTTONIVF, MaPhieu = DanhMucPhieu.BCKTTTONIVF.ToString(), TenPhieu = DanhMucPhieu.BCKTTTONIVF.Description(), TrangThai = 1, DatabaseName = "BanCamKetTTTON_IVF_ICSI_XC" });
            lstDanhSachPhieu.Add(new DanhSachPhieu() { STT = (int)DanhMucPhieu.BCHSLVR, MaPhieu = DanhMucPhieu.BCHSLVR.ToString(), TenPhieu = DanhMucPhieu.BCHSLVR.Description(), TrangThai = 1, DatabaseName = "BangCauHoiSangLocVeRuou" });
            lstDanhSachPhieu.Add(new DanhSachPhieu() { STT = (int)DanhMucPhieu.TDGTTCR, MaPhieu = DanhMucPhieu.TDGTTCR.ToString(), TenPhieu = DanhMucPhieu.TDGTTCR.Description(), TrangThai = 1, DatabaseName = "ThangDGTTCTCLSCTTCR" });
            lstDanhSachPhieu.Add(new DanhSachPhieu() { STT = (int)DanhMucPhieu.PDGDDNBNV2, MaPhieu = DanhMucPhieu.PDGDDNBNV2.ToString(), TenPhieu = DanhMucPhieu.PDGDDNBNV2.Description(), TrangThai = 1, DatabaseName = "PhieuDanhGiaDDNBNV" });
            lstDanhSachPhieu.Add(new DanhSachPhieu() { STT = (int)DanhMucPhieu.PPTGGM, MaPhieu = DanhMucPhieu.PPTGGM.ToString(), TenPhieu = DanhMucPhieu.PPTGGM.Description(), TrangThai = 1, DatabaseName = "PhieuPhauThuatGhepGiacMac" });
            lstDanhSachPhieu.Add(new DanhSachPhieu() { STT = (int)DanhMucPhieu.PTDTHLMB, MaPhieu = DanhMucPhieu.PTDTHLMB.ToString(), TenPhieu = DanhMucPhieu.PTDTHLMB.Description(), TrangThai = 1, DatabaseName = "PhieuTDTHLocMangBung" });
            lstDanhSachPhieu.Add(new DanhSachPhieu() { STT = (int)DanhMucPhieu.PTDVDTTNT, MaPhieu = DanhMucPhieu.PTDVDTTNT.ToString(), TenPhieu = DanhMucPhieu.PTDVDTTNT.Description(), TrangThai = 1, DatabaseName = "PhieuTDDTThanNhanTao2" });
            lstDanhSachPhieu.Add(new DanhSachPhieu() { STT = (int)DanhMucPhieu.GTPUT, MaPhieu = DanhMucPhieu.GTPUT.ToString(), TenPhieu = DanhMucPhieu.GTPUT.Description(), TrangThai = 1, DatabaseName = "GiayThuPhanUngThuoc" });
            lstDanhSachPhieu.Add(new DanhSachPhieu() { STT = (int)DanhMucPhieu.PDKSDDV, MaPhieu = DanhMucPhieu.PDKSDDV.ToString(), TenPhieu = DanhMucPhieu.PDKSDDV.Description(), TrangThai = 1, DatabaseName = "PhieuDKSDDV" });
            lstDanhSachPhieu.Add(new DanhSachPhieu() { STT = (int)DanhMucPhieu.BKTNLBNKCCDV, MaPhieu = DanhMucPhieu.BKTNLBNKCCDV.ToString(), TenPhieu = DanhMucPhieu.BKTNLBNKCCDV.Description(), TrangThai = 1, DatabaseName = "BangKiemTranhNhamLanBN2" });
            lstDanhSachPhieu.Add(new DanhSachPhieu() { STT = (int)DanhMucPhieu.BDGTTNBMVK, MaPhieu = DanhMucPhieu.BDGTTNBMVK.ToString(), TenPhieu = DanhMucPhieu.BDGTTNBMVK.Description(), TrangThai = 1, DatabaseName = "BangDanhGiaTTNBMVK" });
            lstDanhSachPhieu.Add(new DanhSachPhieu() { STT = (int)DanhMucPhieu.DGNBNVVKHCS, MaPhieu = DanhMucPhieu.DGNBNVVKHCS.ToString(), TenPhieu = DanhMucPhieu.DGNBNVVKHCS.Description(), TrangThai = 1, DatabaseName = "DANHGIANBNVVAKHCS" });
            lstDanhSachPhieu.Add(new DanhSachPhieu() { STT = (int)DanhMucPhieu.PTTBA, MaPhieu = DanhMucPhieu.PTTBA.ToString(), TenPhieu = DanhMucPhieu.PTTBA.Description(), TrangThai = 1, DatabaseName = "PhieuTomTatBenhAn" });
            lstDanhSachPhieu.Add(new DanhSachPhieu() { STT = (int)DanhMucPhieu.KHCSNBCOVID19, MaPhieu = DanhMucPhieu.KHCSNBCOVID19.ToString(), TenPhieu = DanhMucPhieu.KHCSNBCOVID19.Description(), TrangThai = 1, DatabaseName = "KHCSNguoiBenhCovid19_2" });
            lstDanhSachPhieu.Add(new DanhSachPhieu() { STT = (int)DanhMucPhieu.PDTCKS, MaPhieu = DanhMucPhieu.PDTCKS.ToString(), TenPhieu = DanhMucPhieu.PDTCKS.Description(), TrangThai = 1, DatabaseName = "PhieuDieuTriCoKiemSoat" });
            lstDanhSachPhieu.Add(new DanhSachPhieu() { STT = (int)DanhMucPhieu.TKDTD, MaPhieu = DanhMucPhieu.TKDTD.ToString(), TenPhieu = DanhMucPhieu.TKDTD.Description(), TrangThai = 1, DatabaseName = "TaiKhamDaiThaoDuong" });
            lstDanhSachPhieu.Add(new DanhSachPhieu() { STT = (int)DanhMucPhieu.PTKUTHT, MaPhieu = DanhMucPhieu.PTKUTHT.ToString(), TenPhieu = DanhMucPhieu.PTKUTHT.Description(), TrangThai = 1, DatabaseName = "TaiKhamUngThuHacTo" });
            lstDanhSachPhieu.Add(new DanhSachPhieu() { STT = (int)DanhMucPhieu.PDGTTDDSGA, MaPhieu = DanhMucPhieu.PDGTTDDSGA.ToString(), TenPhieu = DanhMucPhieu.PDGTTDDSGA.Description(), TrangThai = 1, DatabaseName = "PhieuDanhGiaTinhTDDSGA" });
            lstDanhSachPhieu.Add(new DanhSachPhieu() { STT = (int)DanhMucPhieu.BKTTCDVTSS, MaPhieu = DanhMucPhieu.BKTTCDVTSS.ToString(), TenPhieu = DanhMucPhieu.BKTTCDVTSS.Description(), TrangThai = 1, DatabaseName = "BangKiemTTCDVTSS" });
            lstDanhSachPhieu.Add(new DanhSachPhieu() { STT = (int)DanhMucPhieu.PKSNBTM, MaPhieu = DanhMucPhieu.PKSNBTM.ToString(), TenPhieu = DanhMucPhieu.PKSNBTM.Description(), TrangThai = 1, DatabaseName = "PhieuKiemSoatNBTruocMo" });
            lstDanhSachPhieu.Add(new DanhSachPhieu() { STT = (int)DanhMucPhieu.PTKUTDKHT, MaPhieu = DanhMucPhieu.PTKUTDKHT.ToString(), TenPhieu = DanhMucPhieu.PTKUTDKHT.Description(), TrangThai = 1, DatabaseName = "PhieuTKUngThuKhongHacTo" });
            lstDanhSachPhieu.Add(new DanhSachPhieu() { STT = (int)DanhMucPhieu.SMHC, MaPhieu = DanhMucPhieu.SMHC.ToString(), TenPhieu = DanhMucPhieu.SMHC.Description(), TrangThai = 1, DatabaseName = "SoMoiHoiChan" });
            lstDanhSachPhieu.Add(new DanhSachPhieu() { STT = (int)DanhMucPhieu.BTDCSNBKBND, MaPhieu = DanhMucPhieu.BTDCSNBKBND.ToString(), TenPhieu = DanhMucPhieu.BTDCSNBKBND.Description(), TrangThai = 1, DatabaseName = "BangTDCSNBKhoaBND" });
            lstDanhSachPhieu.Add(new DanhSachPhieu() { STT = (int)DanhMucPhieu.BTDCSNBHSTCNK, MaPhieu = DanhMucPhieu.BTDCSNBHSTCNK.ToString(), TenPhieu = DanhMucPhieu.BTDCSNBHSTCNK.Description(), TrangThai = 1, DatabaseName = "BangTDCSNBHSTCNgoaiKhoa" });
            lstDanhSachPhieu.Add(new DanhSachPhieu() { STT = (int)DanhMucPhieu.BTDCSNBHSTCKN, MaPhieu = DanhMucPhieu.BTDCSNBHSTCKN.ToString(), TenPhieu = DanhMucPhieu.BTDCSNBHSTCKN.Description(), TrangThai = 1, DatabaseName = "BangTDCSNBHSTCNoiKhoa" });
            lstDanhSachPhieu.Add(new DanhSachPhieu() { STT = (int)DanhMucPhieu.PDTBNLKT, MaPhieu = DanhMucPhieu.PDTBNLKT.ToString(), TenPhieu = DanhMucPhieu.PDTBNLKT.Description(), TrangThai = 1, DatabaseName = "PhieuDTBNLaoKhangThuoc" });
            lstDanhSachPhieu.Add(new DanhSachPhieu() { STT = (int)DanhMucPhieu.TKBASDMV, MaPhieu = DanhMucPhieu.TKBASDMV.ToString(), TenPhieu = DanhMucPhieu.TKBASDMV.Description(), TrangThai = 1, DatabaseName = "TaiKhamBAStentDMV" });
            lstDanhSachPhieu.Add(new DanhSachPhieu() { STT = (int)DanhMucPhieu.TKTMCTCB, MaPhieu = DanhMucPhieu.TKTMCTCB.ToString(), TenPhieu = DanhMucPhieu.TKTMCTCB.Description(), TrangThai = 1, DatabaseName = "TaiKhamBATMCoTimCucBo" });
            lstDanhSachPhieu.Add(new DanhSachPhieu() { STT = (int)DanhMucPhieu.TKBATDDTBBD, MaPhieu = DanhMucPhieu.TKBATDDTBBD.ToString(), TenPhieu = DanhMucPhieu.TKBATDDTBBD.Description(), TrangThai = 1, DatabaseName = "TaiKhamBABenhBaseDow" });
            lstDanhSachPhieu.Add(new DanhSachPhieu() { STT = (int)DanhMucPhieu.PTDVCSPK, MaPhieu = DanhMucPhieu.PTDVCSPK.ToString(), TenPhieu = DanhMucPhieu.PTDVCSPK.Description(), TrangThai = 1, DatabaseName = "PhieuTDVCSBNPhuKhoa" });
            lstDanhSachPhieu.Add(new DanhSachPhieu() { STT = (int)DanhMucPhieu.BBXNNBTV, MaPhieu = DanhMucPhieu.BBXNNBTV.ToString(), TenPhieu = DanhMucPhieu.BBXNNBTV.Description(), TrangThai = 1, DatabaseName = "BienBanXacNhanNBTuVong" });
            lstDanhSachPhieu.Add(new DanhSachPhieu() { STT = (int)DanhMucPhieu.BKTTGM, MaPhieu = DanhMucPhieu.BKTTGM.ToString(), TenPhieu = DanhMucPhieu.BKTTGM.Description(), TrangThai = 1, DatabaseName = "BangKeThuocTrongGayMe" });
            lstDanhSachPhieu.Add(new DanhSachPhieu() { STT = (int)DanhMucPhieu.GCVBTCM, MaPhieu = DanhMucPhieu.GCVBTCM.ToString(), TenPhieu = DanhMucPhieu.GCVBTCM.Description(), TrangThai = 1, DatabaseName = "GiayChuyenVienBenhTCM" });// GIAYCHUYENVIENBENHTAYCHANMIENG GiayChuyenVienBenhTayChanMieng
            lstDanhSachPhieu.Add(new DanhSachPhieu() { STT = (int)DanhMucPhieu.BKTDTGM, MaPhieu = DanhMucPhieu.BKTDTGM.ToString(), TenPhieu = DanhMucPhieu.BKTDTGM.Description(), TrangThai = 1, DatabaseName = "BANGKETHUOCDUNGTRONGGAYME" });// GIAYCHUYENVIENBENHTAYCHANMIENG GiayChuyenVienBenhTayChanMieng
            lstDanhSachPhieu.Add(new DanhSachPhieu() { STT = (int)DanhMucPhieu.BKTDD, MaPhieu = DanhMucPhieu.BKTDD.ToString(), TenPhieu = DanhMucPhieu.BKTDD.Description(), TrangThai = 1, DatabaseName = "BangKeThuocDaDung" });// GIAYCHUYENVIENBENHTAYCHANMIENG GiayChuyenVienBenhTayChanMieng
            lstDanhSachPhieu.Add(new DanhSachPhieu() { STT = (int)DanhMucPhieu.TKBAVGBMT, MaPhieu = DanhMucPhieu.TKBAVGBMT.ToString(), TenPhieu = DanhMucPhieu.TKBAVGBMT.Description(), TrangThai = 1, DatabaseName = "TaiKhamViemGanBManTinh" });// GIAYCHUYENVIENBENHTAYCHANMIENG GiayChuyenVienBenhTayChanMieng
            lstDanhSachPhieu.Add(new DanhSachPhieu() { STT = (int)DanhMucPhieu.TKBAPTNMT, MaPhieu = DanhMucPhieu.TKBAPTNMT.ToString(), TenPhieu = DanhMucPhieu.TKBAPTNMT.Description(), TrangThai = 1, DatabaseName = "TaiKhamPhoiTacNghenManTinh" });// GIAYCHUYENVIENBENHTAYCHANMIENG GiayChuyenVienBenhTayChanMieng
            lstDanhSachPhieu.Add(new DanhSachPhieu() { STT = (int)DanhMucPhieu.BKVTTHTGM, MaPhieu = DanhMucPhieu.BKVTTHTGM.ToString(), TenPhieu = DanhMucPhieu.BKVTTHTGM.Description(), TrangThai = 1, DatabaseName = "BangKeVTTHTrongGayMe" });
            lstDanhSachPhieu.Add(new DanhSachPhieu() { STT = (int)DanhMucPhieu.TKBATHA, MaPhieu = DanhMucPhieu.TKBATHA.ToString(), TenPhieu = DanhMucPhieu.TKBATHA.Description(), TrangThai = 1, DatabaseName = "TaiKhamBenhAnTangHuyetAp" });
            lstDanhSachPhieu.Add(new DanhSachPhieu() { STT = (int)DanhMucPhieu.BKDCGTPT, MaPhieu = DanhMucPhieu.BKDCGTPT.ToString(), TenPhieu = DanhMucPhieu.BKDCGTPT.Description(), TrangThai = 1, DatabaseName = "BangKiemDCGacTrongPT" });
            lstDanhSachPhieu.Add(new DanhSachPhieu() { STT = (int)DanhMucPhieu.PDTDT, MaPhieu = DanhMucPhieu.PDTDT.ToString(), TenPhieu = DanhMucPhieu.PDTDT.Description(), TrangThai = 1, DatabaseName = "PhieuDienTienDieuTri" });
            lstDanhSachPhieu.Add(new DanhSachPhieu() { STT = (int)DanhMucPhieu.PHCPT, MaPhieu = DanhMucPhieu.PHCPT.ToString(), TenPhieu = DanhMucPhieu.PHCPT.Description(), TrangThai = 1, DatabaseName = "PhieuHoiChanPhauThuat" });
            lstDanhSachPhieu.Add(new DanhSachPhieu() { STT = (int)DanhMucPhieu.GDKBPDV, MaPhieu = DanhMucPhieu.GDKBPDV.ToString(), TenPhieu = DanhMucPhieu.GDKBPDV.Description(), TrangThai = 1, DatabaseName = "GiayDangKyBaoPhongDichVu" });// GIAYCHUYENVIENBENHTAYCHANMIENG GiayChuyenVienBenhTayChanMieng

            lstDanhSachPhieu.Add(new DanhSachPhieu() { STT = (int)DanhMucPhieu.PTBT, MaPhieu = DanhMucPhieu.PTBT.ToString(), TenPhieu = DanhMucPhieu.PTBT.Description(), TrangThai = 1, DatabaseName = "PhaThaiBangThuoc" });// GIAYCHUYENVIENBENHTAYCHANMIENG GiayChuyenVienBenhTayChanMieng
            lstDanhSachPhieu.Add(new DanhSachPhieu() { STT = (int)DanhMucPhieu.PCSDTHIVAIDS, MaPhieu = DanhMucPhieu.PCSDTHIVAIDS.ToString(), TenPhieu = DanhMucPhieu.PCSDTHIVAIDS.Description(), TrangThai = 1, DatabaseName = "PhieuCSDTHIVAIDS" });// GIAYCHUYENVIENBENHTAYCHANMIENG GiayChuyenVienBenhTayChanMieng
            lstDanhSachPhieu.Add(new DanhSachPhieu() { STT = (int)DanhMucPhieu.GCNPT2, MaPhieu = DanhMucPhieu.GCNPT2.ToString(), TenPhieu = DanhMucPhieu.GCNPT2.Description(), TrangThai = 1, DatabaseName = "GiayChungNhanPhauThuat2" });// GIAYCHUYENVIENBENHTAYCHANMIENG GiayChuyenVienBenhTayChanMieng
            lstDanhSachPhieu.Add(new DanhSachPhieu() { STT = (int)DanhMucPhieu.GCKTDTTHSBA, MaPhieu = DanhMucPhieu.GCKTDTTHSBA.ToString(), TenPhieu = DanhMucPhieu.GCKTDTTHSBA.Description(), TrangThai = 1, DatabaseName = "GiayCamKetThayDoiTTHSBA" });
            lstDanhSachPhieu.Add(new DanhSachPhieu() { STT = (int)DanhMucPhieu.PKGMTM2, MaPhieu = DanhMucPhieu.PKGMTM2.ToString(), TenPhieu = DanhMucPhieu.PKGMTM2.Description(), TrangThai = 1, DatabaseName = "PhieuKhamGayMeTruocMo2" });
            lstDanhSachPhieu.Add(new DanhSachPhieu() { STT = (int)DanhMucPhieu.BACV19NTP, MaPhieu = DanhMucPhieu.BACV19NTP.ToString(), TenPhieu = DanhMucPhieu.BACV19NTP.Description(), TrangThai = 1, DatabaseName = "BABNDieuTriCovid19NTP" });
            lstDanhSachPhieu.Add(new DanhSachPhieu() { STT = (int)DanhMucPhieu.BKTTCDVTSS2, MaPhieu = DanhMucPhieu.BKTTCDVTSS2.ToString(), TenPhieu = DanhMucPhieu.BKTTCDVTSS2.Description(), TrangThai = 1, DatabaseName = "BangKiemTruocTiemChungDVTreSS" });
            lstDanhSachPhieu.Add(new DanhSachPhieu() { STT = (int)DanhMucPhieu.PKBVVXA, MaPhieu = DanhMucPhieu.PKBVVXA.ToString(), TenPhieu = DanhMucPhieu.PKBVVXA.Description(), TrangThai = 1, DatabaseName = "PhieuKhamBenhVaoVienXA" });

            
            lstDanhSachPhieu.Add(new DanhSachPhieu() { STT = (int)DanhMucPhieu.BKATPTN, MaPhieu = DanhMucPhieu.BKATPTN.ToString(), TenPhieu = DanhMucPhieu.BKATPTN.Description(), TrangThai = 1, DatabaseName = "BangKiemAnToanPhauThuatNew" });
            lstDanhSachPhieu.Add(new DanhSachPhieu() { STT = (int)DanhMucPhieu.BKTLTTCDSA, MaPhieu = DanhMucPhieu.BKTLTTCDSA.ToString(), TenPhieu = DanhMucPhieu.BKTLTTCDSA.Description(), TrangThai = 1, DatabaseName = "BangKiemTruocLamThuThuatChupDSA" });
            lstDanhSachPhieu.Add(new DanhSachPhieu() { STT = (int)DanhMucPhieu.BKANPTNA, MaPhieu = DanhMucPhieu.BKANPTNA.ToString(), TenPhieu = DanhMucPhieu.BKANPTNA.Description(), TrangThai = 1, DatabaseName = "BangKiemAnToanPhauThuatNA" });
            lstDanhSachPhieu.Add(new DanhSachPhieu() { STT = (int)DanhMucPhieu.PDKDKDTSM, MaPhieu = DanhMucPhieu.PDKDKDTSM.ToString(), TenPhieu = DanhMucPhieu.PDKDKDTSM.Description(), TrangThai = 1, DatabaseName = "PhieuDKDaKeDaTrongSanhMo" });
            lstDanhSachPhieu.Add(new DanhSachPhieu() { STT = (int)DanhMucPhieu.PTVPTMLT, MaPhieu = DanhMucPhieu.PTVPTMLT.ToString(), TenPhieu = DanhMucPhieu.PTVPTMLT.Description(), TrangThai = 1, DatabaseName = "PhieuTVPTMoLayThai" });


            lstDanhSachPhieu.Add(new DanhSachPhieu() { STT = (int)DanhMucPhieu.PKTP, MaPhieu = DanhMucPhieu.PKTP.ToString(), TenPhieu = DanhMucPhieu.PKTP.Description(), TrangThai = 1, DatabaseName = "PhieuKhamTienPhau" });
            lstDanhSachPhieu.Add(new DanhSachPhieu() { STT = (int)DanhMucPhieu.PTDNBSKM24H, MaPhieu = DanhMucPhieu.PTDNBSKM24H.ToString(), TenPhieu = DanhMucPhieu.PTDNBSKM24H.Description(), TrangThai = 1, DatabaseName = "PhieuTDNBSauKhiMo24h" });
            
            if (XemBenhAn.IsHis2)
            {
                lstDanhSachPhieu.Add(new DanhSachPhieu() { STT = (int)DanhMucPhieu.B_CHIDINH, MaPhieu = DanhMucPhieu.B_CHIDINH.ToString(), TenPhieu = DanhMucPhieu.B_CHIDINH.Description() , LoaiPhieu = 1, TrangThai = 0, DatabaseName = "b_chidinh", NgayTao = "ngay", NgaySua = "ngayud" });
                //15/07/2021 Add by Hòa Issues 72297
                lstDanhSachPhieu.Add(new DanhSachPhieu() { STT = (int)DanhMucPhieu.BL_XUATNOIVIENDS, MaPhieu = DanhMucPhieu.BL_XUATNOIVIENDS.ToString(), TenPhieu = DanhMucPhieu.BL_XUATNOIVIENDS.Description() , LoaiPhieu = 1, TrangThai = 0, DatabaseName = "bl_xuatnoiviends", NgayTao = "ngay", NgaySua = "ngayud" });
                lstDanhSachPhieu.Add(new DanhSachPhieu() { STT = (int)DanhMucPhieu.BL_PHIEUTRUYENMAUDS, MaPhieu = DanhMucPhieu.BL_PHIEUTRUYENMAUDS.ToString(), TenPhieu = DanhMucPhieu.BL_PHIEUTRUYENMAUDS.Description() , LoaiPhieu = 1, TrangThai = 0, DatabaseName = "bl_phieutruyenmauds", NgayTao = "ngay", NgaySua = "ngayud" });
                lstDanhSachPhieu.Add(new DanhSachPhieu() { STT = (int)DanhMucPhieu.L_KETQUA, MaPhieu = DanhMucPhieu.L_KETQUA.ToString(), TenPhieu = DanhMucPhieu.L_KETQUA.Description() , LoaiPhieu = 1, TrangThai = 0, DatabaseName = "l_ketqua", NgayTao = "ngay", NgaySua = "ngayud" });
                lstDanhSachPhieu.Add(new DanhSachPhieu() { STT = (int)DanhMucPhieu.P_TODIEUTri, MaPhieu = DanhMucPhieu.P_TODIEUTri.ToString(), TenPhieu = DanhMucPhieu.P_TODIEUTri.Description() , LoaiPhieu = 1, TrangThai = 0, DatabaseName = "p_todieutri", NgayTao = "ngay", NgaySua = "ngayud" });
                lstDanhSachPhieu.Add(new DanhSachPhieu() { STT = (int)DanhMucPhieu.P_TOATHUOCLL, MaPhieu = DanhMucPhieu.P_TOATHUOCLL.ToString(), TenPhieu = DanhMucPhieu.P_TOATHUOCLL.Description() , LoaiPhieu = 1, TrangThai = 0, DatabaseName = "p_toathuocll", NgayTao = "ngay", NgaySua = "ngayud" });
                lstDanhSachPhieu.Add(new DanhSachPhieu() { STT = (int)DanhMucPhieu.P_GIAYRAVIEN, MaPhieu = DanhMucPhieu.P_GIAYRAVIEN.ToString(), TenPhieu = DanhMucPhieu.P_GIAYRAVIEN.Description()  , LoaiPhieu = 1, TrangThai = 0, DatabaseName = "p_giayravien", NgayTao = "ngay", NgaySua = "ngayud" });
                lstDanhSachPhieu.Add(new DanhSachPhieu() { STT = (int)DanhMucPhieu.P_GIAYCHUYENVIEN, MaPhieu = DanhMucPhieu.P_GIAYCHUYENVIEN.ToString(), TenPhieu = DanhMucPhieu.P_GIAYCHUYENVIEN.Description() , LoaiPhieu = 1, TrangThai = 0, DatabaseName = "p_giaychuyenvien", NgayTao = "ngay", NgaySua = "ngayud" });
                lstDanhSachPhieu.Add(new DanhSachPhieu() { STT = (int)DanhMucPhieu.P_GIAYNGHIOM, MaPhieu = DanhMucPhieu.P_GIAYNGHIOM.ToString(), TenPhieu = DanhMucPhieu.P_GIAYNGHIOM.Description() , LoaiPhieu = 1, TrangThai = 0, DatabaseName = "p_giaynghiom", NgayTao = "ngay", NgaySua = "ngayud" });
                lstDanhSachPhieu.Add(new DanhSachPhieu() { STT = (int)DanhMucPhieu.P_DAUSINHTON, MaPhieu = DanhMucPhieu.P_DAUSINHTON.ToString(), TenPhieu = DanhMucPhieu.P_DAUSINHTON.Description(), LoaiPhieu = 1, TrangThai = 0, DatabaseName = "p_dausinhton", NgayTao = "ngay", NgaySua = "ngayud" });
                lstDanhSachPhieu.Add(new DanhSachPhieu() { STT = (int)DanhMucPhieu.P_HOICHAN, MaPhieu = DanhMucPhieu.P_HOICHAN.ToString(), TenPhieu = DanhMucPhieu.P_HOICHAN.Description(), LoaiPhieu = 1, TrangThai = 0, DatabaseName = "p_hoichan", NgayTao = "ngay", NgaySua = "ngayud" });
                lstDanhSachPhieu.Add(new DanhSachPhieu() { STT = (int)DanhMucPhieu.P_PHIEUSOKET15, MaPhieu = DanhMucPhieu.P_PHIEUSOKET15.ToString(), TenPhieu = DanhMucPhieu.P_PHIEUSOKET15.Description() , LoaiPhieu = 1, TrangThai = 0, DatabaseName = "p_phieusoket15", NgayTao = "ngay", NgaySua = "ngayud" });
                lstDanhSachPhieu.Add(new DanhSachPhieu() { STT = (int)DanhMucPhieu.P_TRESOSINH, MaPhieu = DanhMucPhieu.P_TRESOSINH.ToString(), TenPhieu = DanhMucPhieu.P_TRESOSINH.Description() , LoaiPhieu = 1, TrangThai = 0, DatabaseName = "p_tresosinh", NgayTao = "ngay", NgaySua = "ngayud" });
                lstDanhSachPhieu.Add(new DanhSachPhieu() { STT = (int)DanhMucPhieu.p_GIAYTHUPHANUNGTHUOC, MaPhieu = DanhMucPhieu.p_GIAYTHUPHANUNGTHUOC.ToString(), TenPhieu = DanhMucPhieu.p_GIAYTHUPHANUNGTHUOC.Description() , LoaiPhieu = 1, TrangThai = 0, DatabaseName = "p_giaythuphanungthuoc", NgayTao = "ngay", NgaySua = "ngayud" });
                lstDanhSachPhieu.Add(new DanhSachPhieu() { STT = (int)DanhMucPhieu.P_PTTT, MaPhieu = DanhMucPhieu.P_PTTT.ToString(), TenPhieu = DanhMucPhieu.P_PTTT.Description() , LoaiPhieu = 1, TrangThai = 0, DatabaseName = "p_pttt", NgayTao = "ngay", NgaySua = "ngayud" });
                lstDanhSachPhieu.Add(new DanhSachPhieu() { STT = (int)DanhMucPhieu.P_HOICHANPHAUTHUAT, MaPhieu = DanhMucPhieu.P_HOICHANPHAUTHUAT.ToString(), TenPhieu = DanhMucPhieu.P_HOICHANPHAUTHUAT.Description() , LoaiPhieu = 1, TrangThai = 0, DatabaseName = "p_hoichanphauthuat", NgayTao = "ngay", NgaySua = "ngayud" });
                lstDanhSachPhieu.Add(new DanhSachPhieu() { STT = (int)DanhMucPhieu.P_PHIEUTRUYENDICH, MaPhieu = DanhMucPhieu.P_PHIEUTRUYENDICH.ToString(), TenPhieu = DanhMucPhieu.P_PHIEUTRUYENDICH.Description() , LoaiPhieu = 1, TrangThai = 0, DatabaseName = "p_phieutruyendich", NgayTao = "ngay", NgaySua = "ngayud" });
                lstDanhSachPhieu.Add(new DanhSachPhieu() { STT = (int)DanhMucPhieu.R_KETQUALL, MaPhieu = DanhMucPhieu.R_KETQUALL.ToString(), TenPhieu = DanhMucPhieu.R_KETQUALL.Description(), LoaiPhieu = 1, TrangThai = 0, DatabaseName = "r_ketquall", NgayTao = "ngay", NgaySua = "ngayud" });
                lstDanhSachPhieu.Add(new DanhSachPhieu() { STT = (int)DanhMucPhieu.L_KETQUAKHANGSINH, MaPhieu = DanhMucPhieu.L_KETQUAKHANGSINH.ToString(), TenPhieu = DanhMucPhieu.L_KETQUAKHANGSINH.Description() , LoaiPhieu = 1, TrangThai = 0, DatabaseName = "l_ketquakhangsinh", NgayTao = "ngay", NgaySua = "ngayud" });
                lstDanhSachPhieu.Add(new DanhSachPhieu() { STT = (int)DanhMucPhieu.H2_CKT, MaPhieu = DanhMucPhieu.H2_CKT.ToString(), TenPhieu = DanhMucPhieu.H2_CKT.Description() , LoaiPhieu = 1, TrangThai = 0, DatabaseName = "", NgayTao = "ngay", NgaySua = "ngayud" });
                lstDanhSachPhieu.Add(new DanhSachPhieu() { STT = (int)DanhMucPhieu.H2_DTGN, MaPhieu = DanhMucPhieu.H2_DTGN.ToString(), TenPhieu = DanhMucPhieu.H2_DTGN.Description()  , LoaiPhieu = 1, TrangThai = 0, DatabaseName = "", NgayTao = "ngay", NgaySua = "ngayud" });
                lstDanhSachPhieu.Add(new DanhSachPhieu() { STT = (int)DanhMucPhieu.H2_DTHT, MaPhieu = DanhMucPhieu.H2_DTHT.ToString(), TenPhieu = DanhMucPhieu.H2_DTHT.Description() , LoaiPhieu = 1, TrangThai = 0, DatabaseName = "", NgayTao = "ngay", NgaySua = "ngayud" });
                lstDanhSachPhieu.Add(new DanhSachPhieu() { STT = (int)DanhMucPhieu.H2_PKVV, MaPhieu = DanhMucPhieu.H2_PKVV.ToString(), TenPhieu = DanhMucPhieu.H2_PKVV.Description() , LoaiPhieu = 1, TrangThai = 0, DatabaseName = "", NgayTao = "ngay", NgaySua = "ngayud" });
                lstDanhSachPhieu.Add(new DanhSachPhieu() { STT = (int)DanhMucPhieu.H2_GCNPT, MaPhieu = DanhMucPhieu.H2_GCNPT.ToString(), TenPhieu = DanhMucPhieu.H2_GCNPT.Description() , LoaiPhieu = 1, TrangThai = 0, DatabaseName = "", NgayTao = "ngay", NgaySua = "ngayud" });
                lstDanhSachPhieu.Add(new DanhSachPhieu() { STT = (int)DanhMucPhieu.H2_PDYXNHIV, MaPhieu = DanhMucPhieu.H2_PDYXNHIV.ToString(), TenPhieu = DanhMucPhieu.H2_PDYXNHIV.Description() , LoaiPhieu = 1, TrangThai = 0, DatabaseName = "", NgayTao = "ngay", NgaySua = "ngayud" });
                lstDanhSachPhieu.Add(new DanhSachPhieu() { STT = (int)DanhMucPhieu.H2_GCNTT, MaPhieu = DanhMucPhieu.H2_GCNTT.ToString(), TenPhieu = DanhMucPhieu.H2_GCNTT.Description() , LoaiPhieu = 1, TrangThai = 0, DatabaseName = "", NgayTao = "ngay", NgaySua = "ngayud" });
                lstDanhSachPhieu.Add(new DanhSachPhieu() { STT = (int)DanhMucPhieu.H2_PTTRV, MaPhieu = DanhMucPhieu.H2_PTTRV.ToString(), TenPhieu = DanhMucPhieu.H2_PTTRV.Description(), LoaiPhieu = 1, TrangThai = 0, DatabaseName = "", NgayTao = "ngay", NgaySua = "ngayud" });
                lstDanhSachPhieu.Add(new DanhSachPhieu() { STT = (int)DanhMucPhieu.H2_PKSK, MaPhieu = DanhMucPhieu.H2_PKSK.ToString(), TenPhieu = DanhMucPhieu.H2_PKSK.Description(), LoaiPhieu = 1, TrangThai = 0, DatabaseName = "", NgayTao = "ngay", NgaySua = "ngayud" });
                lstDanhSachPhieu.Add(new DanhSachPhieu() { STT = (int)DanhMucPhieu.H2_GCNNV, MaPhieu = DanhMucPhieu.H2_GCNNV.ToString(), TenPhieu = DanhMucPhieu.H2_GCNNV.Description(), LoaiPhieu = 1, TrangThai = 0, DatabaseName = "", NgayTao = "ngay", NgaySua = "ngayud" });
                lstDanhSachPhieu.Add(new DanhSachPhieu() { STT = (int)DanhMucPhieu.H2_GCDPTTT, MaPhieu = DanhMucPhieu.H2_GCDPTTT.ToString(), TenPhieu = DanhMucPhieu.H2_GCDPTTT.Description(), LoaiPhieu = 1, TrangThai = 0, DatabaseName = "", NgayTao = "ngay", NgaySua = "ngayud" });
                lstDanhSachPhieu.Add(new DanhSachPhieu() { STT =(int) DanhMucPhieu.H2_PKTTSDU, MaPhieu = DanhMucPhieu.H2_PKTTSDU.ToString(), TenPhieu = DanhMucPhieu.H2_PKTTSDU.Description(), LoaiPhieu = 1, TrangThai = 0, DatabaseName = "", NgayTao = "ngay", NgaySua = "ngayud" });
                //15/07/2021 End by Hòa Issues 72297
            }
            return lstDanhSachPhieu;
        }
        public void UpdateDSPhieu(List<DanhSachPhieu> danhSachPhieus, MDB.MDBConnection oracleConnection)
        {
            ExceptionExtend.Log("DanhSachPhieu", "Start UpdateDSPhieu");
            try
            {
                string sql;
                foreach (var Phieu in danhSachPhieus)
                {
                    sql = @"select IdPhieu from DM_PHIEU where MaPhieu = :MaPhieu";
                    MDB.MDBCommand oracleCommand = new MDB.MDBCommand(sql, oracleConnection);
                    oracleCommand.Parameters.Add("MaPhieu", Phieu.MaPhieu);
                    MDB.MDBDataReader DataReader = oracleCommand.ExecuteReader();
                    int rowCount = 0;
                    while (DataReader.Read()) rowCount++;
                    if (rowCount > 0)
                    {
                        ExceptionExtend.Log("DanhSachPhieu", "Update phiếu : " + Phieu.MaPhieu + ", Mã ký : " + Phieu.MaKy);
                        UpdatePhieu(Phieu, oracleConnection);

                    }
                    else
                    {
                        ExceptionExtend.Log("DanhSachPhieu", "Insert phiếu : " + Phieu.MaPhieu);
                        InsertPhieu(Phieu, oracleConnection);
                    }

                }

            }
            catch (Exception ex)
            {
                XuLyLoi.LogDebug("dangtung - 1.3 UpdateDSPhieu err: " + ex);
                MessageBox.Show("EMR", "Lỗi khi update các mẫu phiếu ", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
            ExceptionExtend.Log("DanhSachPhieu", "End UpdateDSPhieu");
        }
        public void DeleteDSPhieu(List<DanhSachPhieu> danhSachPhieus, MDB.MDBConnection oracleConnection, string Maphieu)
        {
            XuLyLoi.LogDebug("dangtung - 1 stat UpdateDSPhieu");
            try
            {
                string sql;

                sql = @"Delete DM_PHIEU where MaPhieu = :MaPhieu";
                MDB.MDBCommand oracleCommand = new MDB.MDBCommand(sql, oracleConnection);
                oracleCommand.Parameters.Add("MaPhieu", Maphieu);
                oracleCommand.ExecuteNonQuery();
                int idx = danhSachPhieus.FindIndex(x => x.MaPhieu.Equals(Maphieu));
                if (idx >= 0)
                {
                    danhSachPhieus.RemoveAt(idx);
                }


            }
            catch (Exception ex)
            {
                XuLyLoi.LogDebug("dangtung - 1.3 UpdateDSPhieu err: " + ex);
            }
            XuLyLoi.LogDebug("dangtung - 2 completed UpdateDSPhieu");
        }
        public void InsertPhieu(DanhSachPhieu Phieu, MDB.MDBConnection oracleConnection)
        {
            string sql = @"insert into DM_PHIEU(STT, MaPhieu, TenPhieu, LoaiPhieu, TrangThai, DatabaseName, IdQuanLy, MaKy, KiemTraDaKy, document_maky) values(:STT, :MaPhieu, :TenPhieu, :LoaiPhieu, :TrangThai, :DatabaseName, :IdQuanLy, :MaKy, :KiemTraDaKy, :document_maky)";
            MDB.MDBCommand oracleCommand = new MDB.MDBCommand(sql, oracleConnection);
            oracleCommand.Parameters.Add("STT", Phieu.STT);
            oracleCommand.Parameters.Add("MaPhieu", Phieu.MaPhieu);
            oracleCommand.Parameters.Add("TenPhieu", Phieu.TenPhieu);
            oracleCommand.Parameters.Add("LoaiPhieu", Phieu.LoaiPhieu);
            oracleCommand.Parameters.Add("TrangThai", Phieu.TrangThai);
            oracleCommand.Parameters.Add("DatabaseName", Phieu.DatabaseName);
            oracleCommand.Parameters.Add("IdQuanLy", Phieu.IdQuanLy);
            oracleCommand.Parameters.Add("MaKy", Phieu.MaKy);
            oracleCommand.Parameters.Add("KiemTraDaKy", Phieu.KiemTraDaKy);
            oracleCommand.Parameters.Add("document_maky", Phieu.Document_MaKy); //23/07/2021 Add by Hòa Issues 72581
            oracleCommand.ExecuteNonQuery();

            XuLyLoi.LogDebug("dangtung - 1.2.1 InsertPhieu completed : " + Phieu.DatabaseName.ToString());
        }
        public void UpdatePhieu(DanhSachPhieu Phieu, MDB.MDBConnection oracleConnection)
        {
            string sql = @"update DM_PHIEU set STT = :STT , TenPhieu = :TenPhieu, LoaiPhieu= :LoaiPhieu, TrangThai = :TrangThai, DatabaseName = :DatabaseName, IdQuanLy = :IdQuanLy, MaKy = :MaKy,KiemTraDaKy = :KiemTraDaKy, document_maky =:document_maky where MaPhieu = :MaPhieu";
            MDB.MDBCommand oracleCommand = new MDB.MDBCommand(sql, oracleConnection);
            XuLyLoi.LogDebug("dangtung - 1.1.1 UpdatePhieu with sql : " + sql.ToString());
            oracleCommand.Parameters.Add("STT", Phieu.STT);
            oracleCommand.Parameters.Add("TenPhieu", Phieu.TenPhieu);
            oracleCommand.Parameters.Add("LoaiPhieu", Phieu.LoaiPhieu);
            oracleCommand.Parameters.Add("TrangThai", Phieu.TrangThai);

            //if (Phieu.DatabaseName != null && !Phieu.DatabaseName.Equals(""))
            //{
            oracleCommand.Parameters.Add("DatabaseName", Phieu.DatabaseName);
            XuLyLoi.LogDebug("dangtung - Add DatabaseName: " + Phieu.DatabaseName);
            //}
            //else
            //{
            //    oracleCommand.Parameters.Add("DatabaseName", "");
            //    XuLyLoi.LogDebug("dangtung - 1.1.1.2 Add DatabaseName done ");
            //}
            oracleCommand.Parameters.Add("IdQuanLy", Phieu.IdQuanLy);
            oracleCommand.Parameters.Add("MaKy", Phieu.MaKy);
            oracleCommand.Parameters.Add("KiemTraDaKy", Phieu.KiemTraDaKy);
            oracleCommand.Parameters.Add("document_maky", Phieu.Document_MaKy); //23/07/2021 Add by Hòa Issues 72581
            oracleCommand.Parameters.Add("MaPhieu", Phieu.MaPhieu);
            XuLyLoi.LogDebug("dangtung - Add MaPhieu done: " + Phieu.MaPhieu);

            oracleCommand.ExecuteNonQuery();
        }
        public List<DanhSachPhieu> GetDanhSachPhieu(MDB.MDBConnection oracleConnection)
        {
            List<DanhSachPhieu> danhSachPhieus = new List<DanhSachPhieu>();
            try
            {
                string sql = @"select * from DM_PHIEU order by STT, MaPhieu";
                MDB.MDBCommand oracleCommand = new MDB.MDBCommand(sql, oracleConnection);
                MDB.MDBDataReader oracleDataReader = oracleCommand.ExecuteReader();
                while (oracleDataReader.Read())
                {
                    DanhSachPhieu Phieu = new DanhSachPhieu();
                    Phieu.IdPhieu = decimal.Parse(oracleDataReader["IdPhieu"].ToString());
                    Phieu.STT = int.Parse(oracleDataReader["STT"].ToString());
                    Phieu.TenPhieu = oracleDataReader["TenPhieu"].ToString();
                    Phieu.LoaiPhieu = int.Parse(oracleDataReader["LoaiPhieu"].ToString());
                    Phieu.TrangThai = int.Parse(oracleDataReader["TrangThai"].ToString());
                    Phieu.DatabaseName = (oracleDataReader["DatabaseName"].ToString());
                    Phieu.MaPhieu = oracleDataReader["MaPhieu"].ToString();
                    Phieu.IdQuanLy = int.Parse(oracleDataReader["IdQuanLy"].ToString());
                    Phieu.MaKy = int.Parse(oracleDataReader["MaKy"].ToString());
                    Phieu.KiemTraDaKy = int.Parse(oracleDataReader["KiemTraDaKy"].ToString());
                    Phieu.Document_MaKy = oracleDataReader["document_maky"].ToString() == "" ? oracleDataReader["MaKy"].ToString() : oracleDataReader["document_maky"].ToString(); //19/07/2021 Add by Hòa Issues 72581
                    XuLyLoi.LogDebug("dangtung - GetDanhSachPhieu : " + Phieu.DatabaseName.ToString());
                    danhSachPhieus.Add(Phieu);
                }
            }
            catch (Exception ex)
            {
                XuLyLoi.LogError(ex);
                MessageBox.Show("EMR", "Lỗi sảy ra trong quá trình lấy dữ liệu từ db", MessageBoxButton.OK, MessageBoxImage.Warning);
                return null;
            }
            return danhSachPhieus;
        }

        public List<DanhSachPhieu> GetDanhSachPhieu(MDB.MDBConnection oracleConnection, decimal maQuanLy)
        {

            Dictionary<string, int> soLuongPhieu = new Dictionary<string, int>();


            List<DanhSachPhieu> danhSachPhieus = new List<DanhSachPhieu>();
            try
            {

                string sql = @"select * from SoLuongPhieu where MAQUANLY = :MAQUANLY";
                MDB.MDBCommand oracleCommand = new MDB.MDBCommand(sql, oracleConnection);
                oracleCommand.Parameters.Add("MAQUANLY", maQuanLy);
                MDB.MDBDataReader oracleDataReader = oracleCommand.ExecuteReader();
                while (oracleDataReader.Read())
                {
                    string maPhieu = oracleDataReader["MaPhieu"].ToString();
                    int soluong = int.Parse(oracleDataReader["SoLuong"].ToString());
                    soLuongPhieu.Add(maPhieu, soluong);
                }


                sql = @"select * from DM_PHIEU order by STT , MaPhieu";
                oracleCommand = new MDB.MDBCommand(sql, oracleConnection);
                oracleDataReader = oracleCommand.ExecuteReader();
                while (oracleDataReader.Read())
                {
                    DanhSachPhieu Phieu = new DanhSachPhieu();
                    try
                    {
                        Phieu.IdPhieu = decimal.Parse(oracleDataReader["IdPhieu"].ToString());
                        Phieu.STT = int.Parse(oracleDataReader["STT"].ToString());
                        Phieu.TenPhieu = oracleDataReader["TenPhieu"].ToString();
                        Phieu.LoaiPhieu = int.Parse(oracleDataReader["LoaiPhieu"].ToString());
                        Phieu.TrangThai = int.Parse(oracleDataReader["TrangThai"].ToString());
                        Phieu.DatabaseName = (oracleDataReader["DatabaseName"].ToString());
                        Phieu.KiemTraDaKy = int.Parse(oracleDataReader["KiemTraDaKy"].ToString());
                        Phieu.MaKy = int.Parse(oracleDataReader["MaKy"].ToString());

                        Phieu.MaPhieu = oracleDataReader["MaPhieu"].ToString();
                        if (Phieu.MaPhieu.Equals("PDGDD") || Phieu.MaPhieu.Equals("BKTKM") || Phieu.MaPhieu.Equals("BKATPT") || Phieu.MaPhieu.Equals("NNXCNPTTT") || Phieu.MaPhieu.Equals("HDKTTSDU")
                            || Phieu.MaPhieu.Equals("CBTPT")
                            )
                        {
                            ChucNangKhac.ThongTinPhieu selectedOnes = null;
                            try
                            {
                                selectedOnes = XemBenhAn._TTCauHinhPhieu.FirstOrDefault((x => (x.MaNhomPhieu.ToUpper().Equals(Phieu.MaPhieu)) && x.TrangThai == true));
                            }
                            catch (Exception ex)
                            {

                            }
                            if (selectedOnes != null)
                            {
                                Phieu.IdPhieu = decimal.Parse(oracleDataReader["IdPhieu"].ToString());
                                Phieu.STT = int.Parse(oracleDataReader["STT"].ToString());
                                Phieu.TenPhieu = selectedOnes.TenPhieu.ToString();
                                Phieu.LoaiPhieu = int.Parse(oracleDataReader["LoaiPhieu"].ToString());
                                Phieu.TrangThai = int.Parse(oracleDataReader["TrangThai"].ToString());
                                Phieu.DatabaseName = selectedOnes.DataBaseName;
                                Phieu.KiemTraDaKy = oracleDataReader.GetInt("KiemTraDaKy");
                                Phieu.MaKy = int.Parse(oracleDataReader["MaKy"].ToString());
                                if (soLuongPhieu.ContainsKey(Phieu.MaPhieu))
                                    Phieu.SoLuong = soLuongPhieu[Phieu.MaPhieu];
                            }
                        }
                        else
                        {
                            if (soLuongPhieu.ContainsKey(Phieu.MaPhieu))
                                Phieu.SoLuong = soLuongPhieu[Phieu.MaPhieu];
                        }
                    }
                    catch (Exception ex)
                    {
                        XuLyLoi.LogError(ex);
                    }
                    finally { }

                    danhSachPhieus.Add(Phieu);
                }
            }
            catch (Exception ex)
            {
                XuLyLoi.LogError(ex);
            }
            return danhSachPhieus;
        }
        public static void updateSoLuongPhieu(MDB.MDBConnection oracleConnection, DanhSachPhieu Phieu, decimal maquanly)
        {
            try
            {
                if (Phieu.DatabaseName.IsNullOrEmpty())
                {
                    var list = Phieu.CreateDanhSachPhieu();
                    if (list != null && list.Count > 0)
                    {
                        var phieu = list.Where(x => x.MaPhieu == Phieu.MaPhieu).FirstOrDefault();
                        if (phieu != null)
                        {
                            Phieu.DatabaseName = phieu?.DatabaseName;
                        }
                    }
                }
                string sql = @"SELECT COUNT(*) FROM " + Phieu.DatabaseName + "  where MaQuanLy = :MaQuanLy";
                switch (Phieu.MaPhieu)
                {
                    /*case "CS":
                        if (!String.IsNullOrEmpty(XemBenhAn._ThongTinDieuTri.Khoa))
                        {
                            sql += " and TenKhoa = '" + XemBenhAn._ThongTinDieuTri.Khoa + "' ";
                        }
                        break;*/
                    case "PDGDD":
                        if (XemBenhAn._TTCauHinhPhieu != null && XemBenhAn._TTCauHinhPhieu.Count > 0)
                        {
                            ThongTinPhieu selectedOnes = null;
                            string tableName = "DanhGiaTinhTrangDinhDuong";
                            try
                            {
                                selectedOnes = XemBenhAn._TTCauHinhPhieu.FirstOrDefault((x => (x.MaNhomPhieu.ToUpper().Equals("PDGDD".ToUpper())) && x.TrangThai == true));
                            }
                            catch (Exception ex)
                            {

                            }
                            if (selectedOnes != null)
                            {
                                if (selectedOnes.MaPhieu.Equals("PDGTTDD"))
                                {
                                    tableName = "DanhGiaTinhTrangDinhDuong";
                                }
                                else if (selectedOnes.MaPhieu.Equals("PDGTTDDT18") || selectedOnes.MaPhieu.Equals("PDGTTDDT18t2"))
                                {
                                    tableName = "DanhGiaTinhTrangDDTren18T";
                                }
                                else if (selectedOnes.MaPhieu.Equals("DGDDC") || selectedOnes.MaPhieu.Equals("DGDDC2") || selectedOnes.MaPhieu.Equals("DGDDC3"))
                                {
                                    tableName = "PHIEUDANHGIADINHDUONGCHUNG";
                                }
                            }
                            sql = @"SELECT 
                                COUNT(*) 
                            FROM " + tableName + "  where MaQuanLy = :MaQuanLy";
                        }
                        break;
                    case "KSGTCM":
                    case "BKJH":
                        sql = @"SELECT 
                                COUNT(*) 
                            FROM " + Phieu.DatabaseName + "  where MaQuanLy = :MaQuanLy AND TRANGTHAI = 0";
                        break;
                    case "PTTT":
                        sql = @"SELECT 
                                COUNT(*) 
                            FROM " + Phieu.DatabaseName + "  where MaQuanLy = :MaQuanLy AND LOAI = 0";
                        break;
                    case "TT":
                        sql = @"SELECT 
                                COUNT(*) 
                            FROM " + Phieu.DatabaseName + "  where MaQuanLy = :MaQuanLy AND LOAI = 1";
                        break;
                    case "CD":
                        sql = @"SELECT 
                                COUNT(*) 
                            FROM " + Phieu.DatabaseName + "  where MaQuanLy = :MaQuanLy AND IS_DELETE = 0";
                        break;
                    case "TD":
                        sql = @"SELECT 
                                COUNT(*) 
                            FROM " + Phieu.DatabaseName + "  where MaQuanLy = :MaQuanLy AND IS_DELETE = 0 and IdPhieuThongTinTruyenDich > 0";
                        break;
                    case "PKTTT":
                        sql = @"SELECT 
                                COUNT(*) 
                            FROM " + Phieu.DatabaseName + "  where MaQuanLy = :MaQuanLy AND LOAITT = 500";
                        break;
                    case "PPTT3":
                    case "KSTCK":
                    case "TBBHC":
                    case "BBHC":
                    case "YCSDKS":
                        sql = @"SELECT 
                                COUNT(*) 
                            FROM " + Phieu.DatabaseName + "  where MaQuanLy = :MaQuanLy AND XOA = 0";
                        break;
                    case "BKANTT":
                        sql = @"SELECT 
                                COUNT(*) 
                            FROM " + Phieu.DatabaseName + "  where MaQuanLy = :MaQuanLy AND Loai = 1";
                        break;
                    case "BKANPT":
                        sql = @"SELECT 
                                COUNT(*) 
                            FROM " + Phieu.DatabaseName + "  where MaQuanLy = :MaQuanLy AND Loai = 2";
                        break;
                    default:
                        break;

                }

                int count = 0;

                MDB.MDBCommand oracleCommand = new MDB.MDBCommand(sql, oracleConnection);
                oracleCommand.Parameters.Add("MaQuanLy", maquanly);
                MDB.MDBDataReader oracleDataReader = oracleCommand.ExecuteReader();
                while (oracleDataReader.Read())
                {
                    count = int.Parse(oracleDataReader["Count(*)"].ToString());
                    Phieu.SoLuong = count;

                }
                sql = @"select * from SoLuongPhieu where MaPhieu = :MaPhieu And MaQuanLy = :MaQuanLy";
                oracleCommand = new MDB.MDBCommand(sql, oracleConnection);
                oracleCommand.Parameters.Add("MaPhieu", Phieu.MaPhieu);
                oracleCommand.Parameters.Add("MaQuanLy", maquanly);
                MDB.MDBDataReader DataReader = oracleCommand.ExecuteReader();
                int rowCount = 0;
                while (DataReader.Read()) { rowCount++; break; };
                if (rowCount > 0)
                {
                    sql = @"update SoLuongPhieu set SoLuong = :SoLuong where MaPhieu = :MaPhieu and MaQuanLy = :MaQuanLy";
                    oracleCommand = new MDB.MDBCommand(sql, oracleConnection);

                    oracleCommand.Parameters.Add("SoLuong", count);
                    oracleCommand.Parameters.Add("MaPhieu", Phieu.MaPhieu);
                    oracleCommand.Parameters.Add("MaQuanLy", maquanly);
                    oracleCommand.ExecuteNonQuery();

                }
                else
                {

                    sql = @"insert into SoLuongPhieu(MaPhieu, MaQuanLy,SoLuong) values(:MaPhieu, :MaQuanLy, :SoLuong)";
                    oracleCommand = new MDB.MDBCommand(sql, oracleConnection);
                    oracleCommand.Parameters.Add("MaPhieu", Phieu.MaPhieu);
                    oracleCommand.Parameters.Add("MaQuanLy", maquanly);
                    oracleCommand.Parameters.Add("SoLuong", count);
                    oracleCommand.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                XuLyLoi.LogError(ex);
            }
        }
        //27/10/2021 add by Hòa 2712 lấy nghiệp vụ ký Business_code về Business_code
        public class MauPhieuNghiepVuKy
        {
            public string ReportCode { get; set; }
            public List<string> PrintTypeBusinessCodes { get; set; }
        }
        //20/10/2021 End by Hòa 2712 lấy nghiệp vụ ký Business_code về Business_code
    }
}
