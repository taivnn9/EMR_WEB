using EMR.KyDienTu;
using EMR_MAIN.DATABASE;
using EMR_MAIN.DATABASE.Other;
using PMS.Access;
using System;
using System.Collections.Generic;

namespace EMR_MAIN
{
    public class BANgoaiTruPK : BenhAnBase, IBase
    {
        public BANgoaiTruPK()
        {
            LstTTChiTiet = new List<TheoDoiDieuTriHIV_ChiTietTbl>();
        }
        public int IDMauPhieu { get; set; } = (int)DanhMucPhieu.BANgTruTIM;
        public string TenMauPhieu { get; set; }= DanhMucPhieu.BANgTruTIM.Description();
        public decimal IDBenhAnNgoaiTruPK { get; set; }
        public List<TheoDoiDieuTriHIV_ChiTietTbl> LstTTChiTiet { get; set; }
        public float? ChieuCao { set; get; }
        public float? CanNang { set; get; }
        public float? NhietDo { set; get; }
        public string BenhCoHoiKemTheo { set; get; }
        public int GDLamSangHIV { set; get; }
        public string CD4 { set; get; }
        public string Hb { set; get; }
        public string ALT { set; get; }
        public string HBsAg { set; get; }
        public string AntiHCV { set; get; }
        public string Creatinine { set; get; }
        public string XetNghiemKhac { set; get; }
        public DateTime? NgayLayMau1 { set; get; }
        public string KetQua1 { set; get; }
        public DateTime? NgayLayMau2 { set; get; }
        public string KetQua2 { set; get; }
        public int XuTru1 { set; get; }
        public int XuTru2 { set; get; }
        public int XuTru3 { set; get; }
        public string NDXuTru3 { set; get; }
        public int XuTru4 { set; get; }
        public string NDXuTru4 { set; get; }
        public int XuTru5 { set; get; }
        public int XuTru6 { set; get; }
        public int XuTru7 { set; get; }
        public string NDXuTru7 { set; get; }
        // trang 1
        public int TTKhiDK1 { set; get; }
        public int TTKhiDK2 { set; get; }
        public int TTKhiDK3 { set; get; }
        public string NDTTKhiDK3 { set; get; }
        public int TTKhiDK4 { set; get; }
        public string NDTTKhiDK4 { set; get; }
        public int TTKhiDK5 { set; get; }
        public int TTKhiDK6 { set; get; }
        public int TTKhiDK7 { set; get; }
        public int TSDungThuocARV1 { set; get; }
        public int TSDungThuocARV2 { set; get; }
        public string TSDungThuocARV3 { set; get; }
        public string TSBenhBanThan { set; get; }
        public string TienSuDUT { set; get; }
        public string TienSuNuoiDuong { set; get; }
        public string KQXNPCRL1 { set; get; }
        public string KQXNPCRL2 { set; get; }
        public string NamSinh1 { set; get; }
        public int TTHIV1 { set; get; }
        public string NoiDT1 { set; get; }
        public string DangDTARV1 { set; get; }
        public string NamSinh2 { set; get; }
        public int TTHIV2 { set; get; }
        public string NoiDT2 { set; get; }
        public string DangDTARV2 { set; get; }
        public string NamSinh3 { set; get; }
        public int TTHIV3 { set; get; }
        public string NoiDT3 { set; get; }
        public string DangDTARV3 { set; get; }
        public string NamSinh4 { set; get; }
        public int TTHIV4 { set; get; }
        public string NoiDT4 { set; get; }
        public string DangDTARV4 { set; get; }
        public string NamSinh5 { set; get; }
        public int TTHIV5 { set; get; }
        public string NoiDT5 { set; get; }
        public string NamSinh6 { set; get; }
        public int TTHIV6 { set; get; }
        public string NoiDT6 { set; get; }
        public string DangDTARV6 { set; get; }
        public string MQHKhac { set; get; }
        public string NamSinh7 { set; get; }
        public int TTHIV7 { set; get; }
        public string NoiDT7 { set; get; }
        public string DangDTARV17 { set; get; }
        public string TenThuoc1 { set; get; }
        public int TSDU1 { set; get; }
        public string SoLan1 { set; get; }
        public string BHLS1 { set; get; }
        public string TenThuoc2 { set; get; }
        public int TSDU2 { set; get; }
        public string SoLan2 { set; get; }
        public string BHLS2 { set; get; }
        public string TenThuoc3 { set; get; }
        public int TSDU3 { set; get; }
        public string SoLan3 { set; get; }
        public string BHLS3 { set; get; }
        public string TenThuoc4 { set; get; }
        public int TSDU4 { set; get; }
        public string SoLan4 { set; get; }
        public string BHLS4 { set; get; }
        public string TenThuoc5 { set; get; }
        public int TSDU5 { set; get; }
        public string SoLan5 { set; get; }
        public string BHLS5 { set; get; }
        public string TenThuoc6 { set; get; }
        public int TSDU6 { set; get; }
        public string SoLan6 { set; get; }
        public string BHLS6 { set; get; }
        public string Khoa { set; get; }
        public string MaKhoa { set; get; }
        public int TTKhiDK8 { set; get; }
        public string CMTND { set; get; }
        public string DiaChiThuongTru { set; get; }
        public string MoiQuanHeNguoiNha { set; get; }
        public string NgheNghiepNguoiNha { set; get; }
        public string TenThuongGoi { set; get; }
        public string MaBacSyDieuTri { set; get; }
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
