import { GiayChuyenVien } from "../Other/giayChuyenVien";
import { HanhChinhBenhNhan, ThongTinDieuTri } from "../TrangBia/trangBia";

export interface LichSuChuyenKhoa {
    ChuyenKhoa: string;
    NgayChuyenKhoa: string;
    DateNgayChuyenKhoa: Date | null;
    SoNgayDieuTriKhoa: number | null;
}

export interface DauSinhTon {
    Mach: number | null;
    NhietDo: number | null;
    HuyetAp: string;
    NhipTho: number | null;
    CanNang: number | null;
    ChieuCao: number | null;
    BMI: number | null;
    DhstId: number;
    ExecuteTime: Date | null;
    IsTracking: boolean;
    IsCare: boolean;
}

export interface HoSo {
    XQuang: number;
    CTScanner: number;
    SieuAm: number;
    XetNghiem: number;
    Khac: number;
    Khac_Text: string;
    ToanBoHoSo: number;
}

export interface DsThuocDangSuDung {
    IDThuoc: number;
    TenThuoc: string;
    HamLuong: string;
    DonViTinh: string;
    SoLuong: string;
    FullTenThuoc: string;
}

export interface DacDiemLienQuanBenh {
    DiUng: boolean;
    DiUng_Text: string;
    MaTuy: boolean;
    MaTuy_Text: string;
    RuouBia: boolean;
    RuouBia_Text: string;
    ThuocLa: boolean;
    ThuocLa_Text: string;
    ThuocLao: boolean;
    ThuocLao_Text: string;
    Khac_DacDiemLienQuanBenh: boolean;
    Khac_DacDiemLienQuanBenh_Text: string;
    DaiThaoDuong: boolean;
    DaiThaoDuong_Text: string;
    CaoHuyetAp: boolean;
    CaoHuyetAp_Text: string;
    RoiLoanMoMau: boolean;
    RoiLoanMoMau_Text: string;
    YeuToGiaDinh: boolean;
    YeuToGiaDinh_Text: string;
}

export interface IBase {
    IDMauPhieu: number;
    TenMauPhieu: string;
    MaSoKyTen: string;
    MaSoKyTen_KB: string;
    MaSoKyTen_TK: string;
    DaKy: boolean;
    DaKy_KB: boolean;
    DaKy_TK: boolean;
}

export interface IBenhAnBase {
    MaQuanLy: number;
    VaoNgayThu: number;
    DauSinhTon: DauSinhTon;
    ToanThan: string;
    TuanHoan: string;
    HoHap: string;
    TieuHoa: string;
    ThanTietNieuSinhDuc: string;
    ThanKinh: string;
    CoXuongKhop: string;
    TaiMuiHong: string;
    RangHamMat: string;
    Mat: string;
    Khac_CacCoQuan: string;
    CacXetNghiemCanLamSangCanLam: string;
    TomTatBenhAn: string;
    BenhChinh: string;
    BenhKemTheo: string;
    PhanBiet: string;
    TienLuong: string;
    HuongDieuTri: string;
    NgayKhamBenh: Date;
    BacSyLamBenhAn: string;
    HoSo: HoSo;
    QuaTrinhBenhLyVaDienBien: string;
    TomTatKetQuaXetNghiem: string;
    PhuongPhapDieuTri: string;
    TinhTrangNguoiBenhRaVien: string;
    HuongDieuTriVaCacCheDoTiepTheo: string;
    NguoiNhanHoSo: string;
    NguoiGiaoHoSo: string;
    NgayTongKet: Date;
    BacSyDieuTri: string;
    BacSyKhamBenh: string;
    DacDiemLienQuanBenh: DacDiemLienQuanBenh;
}

export interface IHoiBenhBase {
    LyDoVaoVien: string;
    QuaTrinhBenhLy: string;
    TienSuBenhBanThan: string;
    TienSuBenhGiaDinh: string;
}

export interface BenhAnBase {
    MaQuanLy: number;
    LyDoVaoVien: string;
    VaoNgayThu: number;
    QuaTrinhBenhLy: string;
    TienSuBenhBanThan: string;
    TienSuBenhGiaDinh: string;
    DacDiemLienQuanBenh: DacDiemLienQuanBenh;
    DauSinhTon: DauSinhTon;
    ToanThan: string;
    ThanKinh: string;
    TuanHoan: string;
    HoHap: string;
    TieuHoa: string;
    CoXuongKhop: string;
    ThanTietNieuSinhDuc: string;
    ThongTinKhamBenhKhac: string;
    CacXetNghiemCanLamSangCanLam: string;
    TomTatBenhAn: string;
    BenhChinh: string;
    BenhKemTheo: string;
    PhanBiet: string;
    TienLuong: string;
    HuongDieuTri: string;
    BacSiLamBenhAn: string;
    QuaTrinhBenhLyVaDienBienLamSang: string;
    TomTatKetQuaXetNghiem: string;
    PhuongPhapDieuTri: string;
    TinhTrangNguoiBenhRaVien: string;
    HuongDieuTriVaCacCheDoTiepTheo: string;
    HoSo: HoSo;
    NguoiNhanHoSo: string;
    NguoiGiaoHoSo: string;
    NgayTongKet: Date;
    BacSiDieuTri: string;
    TaiMuiHong: string;
    RangHamMat: string;
    Mat: string;
    NgayKhamBenh: Date;
    BacSiKhamBenh: string;
}

export interface HoSoChuyenVien_New {
    ThongTinHanhChinh: HanhChinhBenhNhan;
    ThongTinDieuTri: ThongTinDieuTri;
    ThongTinBenhAn: any;
    GiayChuyenVien: GiayChuyenVien;
}

export interface HoSoChuyenVien extends HoSoChuyenVien_New {
    _id: any;
    NgayTao: number;
    NguoiGui: string;
    MaGiaoDich: string;
}

export interface ThongTinCapSoLuTru {
    _id: any;
    MaBenhVien: string;
    MaKhoaPhong: string;
    MaQuanLy: string;
    NgayTao: Date;
    IDBenhAn: number;
    NguoiGui: string;
    STT: number;
    SoLuuTru: string;
}

export interface ThongTinCapSoLuTru_New {
    MaQuanLy: string;
    MaBenhVien: string;
    MaKhoaPhong: string;
    IDBenhAn: number;
}