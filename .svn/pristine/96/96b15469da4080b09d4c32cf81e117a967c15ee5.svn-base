import { NhanVien } from "../BenhVien/nhanVien";
import { ThongTinKy } from "../../EMR/KyDienTu/ThongTinKy";
import { LoaiTT } from "../taoPhieuThuThuat";
import { ThuocVatTu } from "../TrangBia/TrangBia";

export enum ChucNangEKipMo {
    PTV1 = 1,
    PTV2 = 8,
    PhuMo1 = 2,
    PhuMo2 = 3,
    GayMe = 4,
    GayMe2 = 5,
    HoiSuc = 6,
    DungCu = 7,
    DieuDuongNgoai = 9,
    PhuMo3 = 10,
    PhuMo4 = 11,
    PhuMo5 = 12,
    PhuMe1 = 13,
    PhuMe2 = 14,
    BacSy = 15,
    DieuDuong = 16
}

export enum PhanLoaiPTTT {
    PhauThuat = 0,
    ThuThuat = 1
}

export interface PhauThuatThuThuat_HIS extends ThongTinKy {
    IDPhauThuatThuThuat: number;
    NgayPhauThuatThuThuat: Date;
    NgayPhauThuatThuThuat_Gio: Date | null;
    NgayPhauThuatThuThuat_Display: Date;
    ThoiGianXyLy: string;
    PhuongPhapPhauThuatThuThuat: string;
    PhuongPhapVoCam: string;
    MaBacSiPhauThuThuat: string;
    MaBacSiGayMe: string;
    HoTenBacSiPhauThuThuat: string;
    HoTenBacSiGayMe: string;
    MaQuanLy: number;
    CachThucPhauThuatThuThuat: string;
    ChanDoanTruocPhauThuatThuThuat: string;
    ChanDoanSauPhauThuatThuThuat: string;
    ChanDoanChinh: string;
    TenPhauThuatThuThuat: string;
    MaYLenh: string;
    Loai: number;
    VatTuTieuHaos: ThuocVatTu[];
    MoTa: string;
    EkipThucHien: string[];
    EkipThucHien_Text: string;
    BacSyChiDinh: string;
    MaBacSyChiDinh: string;
    Chon: boolean;
}

export interface PhauThuatThuThuat extends ThongTinKy {
    IDPhauThuatThuThuat: number;
    MaEkipMo: string;
    NgayPhauThuatThuThuat: Date;
    NgayPhauThuatThuThuat_Gio: Date | null;
    PhuongPhapPhauThuatThuThuat: string;
    PhuongPhapVoCam: string;
    BacSyPhauThuat: string;
    BacSyGayMe: string;
    BacSyPhauThuatHoVaTen: string;
    BacSyGayMeHoVaTen: string;
    MaQuanLy: number;
    PhauThuatKetThuc: Date;
    PhauThuatKetThuc_Gio: Date | null;
    MaChanDoanChinh: string;
    ChanDoanChinh: string;
    MaChanDoanPhu: string;
    ChanDoanPhu: string;
    MaChanDoanTruocPTTT: string;
    ChanDoanTruocPTTT: string;
    MaChanDoanSauPTTT: string;
    ChanDoanSauPTTT: string;
    MaCachThucPTTT: string;
    CachThucPTTT: string;
    MaNgayGiuongPTTT: string;
    NgayGiuongPTTT: string;
    LoaiPTTT: string;
    DieuDuongNgoai: string;
    DieuDuongNgoaiHoVaTen: string;
    NhomMau: string;
    RH: string;
    TinhHinhPTTTID: number;
    TinhHinhPTTT: string;
    TaiBienPTTTID: number;
    TaiBienPTTT: string;
    TuVongTrongPTTTID: number;
    TuVongTrongPTTT: string;
    MoTa: string;
    NgayTao: Date;
    NguoiTao: string;
    NgaySua: Date;
    NguoiSua: string;
    Chon: boolean;
    LinkAnhMoTa: string;
    DanLuu: string;
    Bac: string;
    NgayRutChi: Date;
    NgayCatChi: Date;
    Khac: string;
    Loai: PhanLoaiPTTT;
    Loai_VBA: number | null;
    LoaiTT: LoaiTT;
    TenPhieuTT: string;
    ListEkipMo: EkipMo[];
    ListEkipThuThuat: EkipThuThuat[];
    ShowBSDD: boolean;
    ShowSoLuong: boolean;
    SoLuongBacSy: number | null;
    SoLuongDD: number | null;
    MaPhieuTT: string;
    DaKy: boolean;
}

export interface EkipMo {
    IDPhauThuatThuThuat: number;
    MaEkipMo: string;
    ChucVuEkip: ChucNangEKipMo;
    MaNhanVien: string;
    HoTenNhanVien: string;
}

export interface EkipThuThuat {
    ID: number;
    Stt: string;
    IDPhauThuatThuThuat: number;
    NgayGioThucHien: Date;
    BacSy: NhanVien;
    DieuDuong: NhanVien;
    BacSyMa: string;
    DieuDuongMa: string;
    BacSyTxt: string;
    DieuDuongTxt: string;
    DienBienBenhNhanSauTT: string;
    BacSyTCnt: number;
    DieuDuongCnt: number;
}

export interface PhauThuatThuThuatFunc {
    TableName: string;
    TablePrimaryKeyName: string;
}