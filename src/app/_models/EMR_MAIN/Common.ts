import { HanhChinhBenhNhan } from "./TrangBia/TrangBia";

export interface DSNhanVien_Chon {
    Chon: boolean;
    MaNhanVien: string;
    HoVaTen: string;
    STT: number;
}

export interface NoiDungDG {
    ThangTuoi: string;
    NamLoai1: string;
    NamLoai2: string;
    NamLoai3: string;
    NamLoai4: string;
    NuLoai1: string;
    NuLoai2: string;
    NuLoai3: string;
    NuLoai4: string;
}

export class Common {
    GetDiaChi(HanhChinhBenhNhan: HanhChinhBenhNhan) {
        try
            {
                let diachi = [];
                if (HanhChinhBenhNhan.SoNha)
                {
                    diachi.push(HanhChinhBenhNhan.SoNha);
                }
                if (HanhChinhBenhNhan.ThonPho)
                {
                    diachi.push(HanhChinhBenhNhan.ThonPho);
                }
                if (HanhChinhBenhNhan.XaPhuong)
                {
                    diachi.push(HanhChinhBenhNhan.XaPhuong);
                }
                if (HanhChinhBenhNhan.HuyenQuan)
                {
                    diachi.push(HanhChinhBenhNhan.HuyenQuan);
                }
                if (HanhChinhBenhNhan.TinhThanhPho)
                {
                    diachi.push(HanhChinhBenhNhan.TinhThanhPho);
                }
                return diachi.join(", ");
            }
            catch
            {
                return "";
            }
    }
}