import { EMR_TREATMENT } from "./EMR_TREATMENT";
import { LoaiVanBanKyDienTu } from "./LoaiVanBanKyDienTu";

export enum LoaiHinhKyDienTu {
    USB = 1,
    HSM = 2
}

export interface ThongTinKy {
    LoaiKy: LoaiHinhKyDienTu;
    RoomTypeCode: string;
    RoomCode: string;
    RawKind: number;
    PaperSizeDefault: any;
    DocumentTime: Date | null;
    PrinterDefault: string;
    DocumentCode: string;
    MergeCode: string;
    RefId: string;
    TablePrimaryKeyName: string;
    PrimaryKey: { [key: string]: string; };
    TableName: string;
    ThongTinDieuTri: EMR_TREATMENT;
    MaKy: string;
    LoaiVanBan: LoaiVanBanKyDienTu;
    ComputerKyTen: string;
    NgayKy: Date;
    TenFileKy: string;
    UserNameKy: string;
    MaSoKy: string;
    TenVanBan: string;
    ListID: string;
    TenMauPhieu: string;
    IDMauPhieu: number;
    BusinessCode: string;
    PrintTypeBusinessCodes: string[];
}