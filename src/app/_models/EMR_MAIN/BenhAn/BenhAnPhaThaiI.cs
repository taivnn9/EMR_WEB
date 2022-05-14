using EMR.KyDienTu;
using EMR_MAIN.DATABASE;
using PMS.Access;
using System;

namespace EMR_MAIN
{

    public class BenhAnPhaThaiI : BenhAnBase, IBase
    {
        public int IDMauPhieu { get; set; } = (int)DanhMucPhieu.BAPhaThaiI;
        public string TenMauPhieu { get; set; } = DanhMucPhieu.BAPhaThaiI.Description();
        public string NoiGioiThieu{ get; set; }
        public int? NoiGioiThieuYTe{ get; set; }
        public string ChanDoanNoiGioiThieu{ get; set; }
        public string TienThaiPara { get; set; }
        public string SoConHienCo { get; set; }
        public string Trai { get; set; }
        public string Gai { get; set; }
        public string DaPhauThuatLayThai { get; set; }
        public string NamPhauThuatLanCuoi { get; set; }
        public string CacPhauThuatTCKhac { get; set; }
        public string CacPhauThuatTCKhac_Nam { get; set; }
        public string SoLanPhaThai { get; set; }
        public string LanPhaThaiGanNhat_Thang { get; set; }
        public string LanPhaThaiGanNhat_Nam { get; set; }
        public int? BienPhapTTDangSuDung { get; set; }
        public string TienSuBenh { get; set; }
        public string TienSuBenh_S { get; set; }
        public int? TinhTrangHonNhan { get; set; }
        public string CacBoPhan { get; set; }
        public string NgayDauKyKinhCuoi { get; set; }
        public string TuoiThai { get; set; }
        public string AmHo { get; set; }
        public string AmDao { get; set; }
        public string CoTuCung { get; set; }
        public string TuCung { get; set; }
        public string PhanPhuPhai { get; set; }
        public string PhanPhuTrai { get; set; }
        public string CacXetNghiemCanLam { get; set; }
        public string ChanDoanTuoiThai { get; set; }
        public string PhuongPhapPhaThai { get; set; }
        public DateTime? ThoiDiemThucHienPhaThai { get; set; }
        public DateTime? ThoiDiemKetThuc { get; set; }
        public string GayTe { get; set; }
        public string GayMe { get; set; }
        public int? PhuongPhapPhaThaitr2 { get; set; }
        public int? HutThaiChanKhongBang { get; set; }
        public string SoLuong { get; set; }
        public int? MangOi { get; set; }
        public int? RauThai { get; set; }
        public int? MoThai { get; set; }
        public int? TuongXungVoiTuoiThai { get; set; }
        public string ThaiBatThuong { get; set; }
        public string ThuocSuDungTruocTrongSau { get; set; }
        public string TaiBienTrongQuaTrinhThuThuat { get; set; }
        public string ToanTrang { get; set; }
        public string Mach { get; set; }
        public string HuyetAp { get; set; }
        public int? RaMauAmDao { get; set; }
        public string DanhGiaKetQua { get; set; }
        public int? BienPhapTranhThaiSauPhaThai { get; set; }
        public DateTime? NgayThangNamTr2 { get; set; }
        public string NguoiLamThuThuat { get; set; }
        public string Thai { get; set; }
        public int? PhuongPhapPhaThaiTK { get; set; }
        public int? TinhTrangSauKhiPhaThai { get; set; }
        public int? TaiBien { get; set; }
        public string TongSo { get; set; }
        public int? RaVe { get; set; }
        public DateTime? RaVeThoiThoiGian { get; set; }
        public string LyDoNhapVien { get; set; }
        public string LyDoChuyenTuyen { get; set; }
        public int? BienPhapTranhThaiSauPhaThaiTK { get; set; }
        public string KhamLaiBatThuong { get; set; }
        public string KhamLaiTheoHen { get; set; }
        public string KetLuan { get; set; }
        public string LanhDaoDonVi { get; set; }
        public DateTime? LanhDaoDonViNgayThang { get; set; }
        public string NguoiTongKet { get; set; }
        public DateTime? NguoiTongKetNgayThang { get; set; }
        [MoTaDuLieu("", "", 0, 0)]
        public string MaSoKyTen { set; get; }
        [MoTaDuLieu("", "", 0, 0)]
        public string MaSoKyTen_KB { set; get; }
        [MoTaDuLieu("", "", 0, 0)]
        public string MaSoKyTen_TK { set; get; }
        [MoTaDuLieu("", "", 0, 0)]
        public bool DaKy
        {
            get
            {
                return !MaSoKyTen.IsNullOrEmpty();
            }
            set
            {
            }
        }
        [MoTaDuLieu("", "", 0, 0)]
        public bool DaKy_KB
        {
            get
            {
                return !MaSoKyTen.IsNullOrEmpty();
            }
            set
            {
            }
        }
        [MoTaDuLieu("", "", 0, 0)]
        public bool DaKy_TK
        {
            get
            {
                return !MaSoKyTen.IsNullOrEmpty();
            }
            set
            {
            }
        }
    }
}
