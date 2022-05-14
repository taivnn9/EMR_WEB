using EMR.KyDienTu;
using EMR_MAIN.DATABASE;
using PMS.Access;
using System;
using System.Data;

namespace EMR_MAIN
{

    public class BenhAnSanKhoa : BenhAnBase, IBase
    {
        public int IDMauPhieu { get; set; } = (int)DanhMucPhieu.BASK;
        public string TenMauPhieu { get; set; } =DanhMucPhieu.BASK.Description();
        public DateTime KinhCuoiCungTuNgay { get; set; }
        public DateTime KinhCuoiCungDenNgay { get; set; }
        public bool KhongNhoNgayKinhCuoi { get; set; }
        public string KinhKhacThuong { get; set; }
        public int TuoiThai { get; set; }
        public int NgayThai { get; set; }
        public string KhamThaiTai { get; set; }
        public bool TiemPhongUonVan { get; set; }
        public bool Phu { get; set; }
        public int DuocTiem { get; set; }
        public int SoMuiKhau { get; set; }
        public DateTime? BatDauChuyenDaTu { get; set; }
        public string DauHieuLucDau { get; set; }
        public string BienChuyen { get; set; }
        public int BatDauThayKinhNam { get; set; }
        public int TuoiThayKinh { get; set; }
        public string TinhChatKinhNguyet { get; set; }
        public string ChuKy { get; set; }
        public int SoNgayThayKinh { get; set; }
        public string LuongKinh { get; set; }
        public int KinhLanCuoiNgay { get; set; }
        public bool DauBung { get; set; }
        public int LayChongNam { get; set; }
        public int TuoiLayChong { get; set; }
        public int HetKinhNam { get; set; }
        public int TuoiHetKinh { get; set; }
        public bool Truoc { get; set; }
        public bool Sau { get; set; }
        public bool Trong { get; set; }
        public string NhungBenhPhuKhoaDaDieuTri { get; set; }
        public string ToanTrang { get; set; }
        public bool ToanTrang_Phu { get; set; }
        public bool BungCoSeoPhauThuatCu { get; set; }
        public string HinhDangTuCung { get; set; }
        public string TuThe { get; set; }
        public double ChieuCaoTC { get; set; }
        public double VongBung { get; set; }
        public string ConCoTC { get; set; }
        public int TimThai { get; set; }
        public string Vu { get; set; }
        public string ChanDoanKhiVaoKhoa { get; set; }
        public double ChiSoBishop { get; set; }
        public string AmHo { get; set; }
        public string AmDao { get; set; }
        public string TangSinhMon { get; set; }
        public string CoTuCung { get; set; }
        public string PhanPhu { get; set; }
        public int? TinhTrangOiID { get; set; }
        public DateTime? OiVoLuc { get; set; }
        public bool OiVoID { get; set; }
        public string MauSacNuocOi { get; set; }
        public string NuocOiNhieuHayIt { get; set; }
        public string Ngoi { get; set; }
        public string The_KhamTrong { get; set; }
        public string KieuThe { get; set; }
        public int DoLotID { get; set; }
        public string DuongKinhNhoHaVe { get; set; }
        public string KhiVaoKhoa { get; set; }
        public string PhuongPhapChinh { get; set; }
        public DateTime? ThoiGianVaoBuongDe { get; set; }
        public DateTime? ThoiGianDe { get; set; }
        public string TenNguoiTheoDoi { get; set; }
        public string ChucDanh { get; set; }
        public string Apgar_1 { get; set; }
        public string Apgar_5 { get; set; }
        public string Apgar_10 { get; set; }
        public double CanNang { get; set; }
        public double CanNangRau { get; set; }
        public double Cao { get; set; }
        public double VongDau { get; set; }
        public bool? DonThai { get; set; }
        public bool? DaThai { get; set; }
        public bool TatBamSinh { get; set; }
        public bool CoHauMon { get; set; }
        public string CuTheDiTatBamSinh { get; set; }
        public string TinhTrangSoSinhSauKhiDe { get; set; }
        public string XuLyVaKetQua { get; set; }
        public bool Rau { get; set; }
        public bool RauCuonCo { get; set; }
        public DateTime? ThoiGianRauSo { get; set; }
        public string CachSoRau { get; set; }
        public string MatMang { get; set; }
        public string MatMui { get; set; }
        public string BanhRau { get; set; }
        public double CanNangSoRau { get; set; }
        public double RauCuonDai { get; set; }
        public double CoChayMauSauSo { get; set; }
        public double LuongMauMat { get; set; }
        public bool KiemSoatTuCung { get; set; }
        public string XuLyVaKetQuaSoRau { get; set; }
        public string DaNiemMac { get; set; }
        public int PhuongPhapDeID { get; set; }
        public string LyDoCanThiep { get; set; }
        public int TangSinhMonID { get; set; }
        public string PhuongPhapKhauChi { get; set; }
        public string ChuanDoanTruocPhauThuat { get; set; }
        public string ChuanDoanSauPhauThuat { get; set; }
        public int CoTuCungID { get; set; }
        public bool TaiBienPhauThuat { get; set; }
        public bool BienChung { get; set; }
        public int LyDoBienChung { get; set; }
        public string Mach { get; set; }
        public string NhietDo { get; set; }
        public string HuyetAp { get; set; }
        public string NhipTho { get; set; }
        public int iOiVoID { get; set; }
        public int iRau { get; set; }
        public int iDaThai { get; set; }
        public int iDonThai { get; set; }
        public int TinhHinhPT { get; set; }
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
