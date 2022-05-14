using EMR.KyDienTu;
using EMR_MAIN.DATABASE;
using PMS.Access;
using System;
using System.Collections.Generic;

namespace EMR_MAIN
{
    public class BenhAnDaLieuTW: BenhAnBase, IBase
    {
        public int IDMauPhieu { get; set; } = (int)DanhMucPhieu.BADLTW;
        public string TenMauPhieu { get; set; }= DanhMucPhieu.BADLTW.Description();
        // hành chính
        public List<PhauThuatThuThuat_HIS> lstPTTT { set; get; }
        public string CMND { set; get; }
        public string KhoaDT_KhoaLV { set; get; }
        public string KhoaDT_NgayVao1 { set; get; }
        public string KhoaDT_NgayVao2 { set; get; }
        public string KhoaDT_NgayVao3 { set; get; }
        public string DTSauMo_SoNgay { set; get; }
        public string MaCSKCB { set; get; }
        public string DTSauMo_SoLan { set; get; }
        public string TonThuongCoBan { get; set; }
        public string TrieuChungCoBan { get; set; }
        public bool PhauThuat { set; get; }
        public bool ThuThuat { set; get; }
        public string BenhChuyenKhoa { set; get; }
        public string Phai_HinhVe { set; get; }
        public string Trai_HinhVe { set; get; }
        public string DUThuoc_Ten { set; get; }
        public string DUThuoc_CoSoLan { get; set; }
        public bool DUThuoc_Khong { get; set; }
        public string DUThuoc_BieuHien { get; set; }
        public string DUConTrung_Ten { get; set; }
        public string DUConTrung_CoSoLan { get; set; }
        public bool DUConTrung_Khong { get; set; }
        public string DUConTrung_BieuHien { get; set; }
        public string DUThucPham_Ten { get; set; }
        public string DUThucPham_CoSoLan { get; set; }
        public bool DUThucPham_Khong { get; set; }
        public string DUThucPham_BieuHien { get; set; }
        public string DUTacNhanKhac_Ten { get; set; }
        public string DUTacNhanKhac_CoSoLan { get; set; }
        public bool DUTacNhanKhac_Khong { get; set; }
        public string DUTacNhanKhac_BieuHien { get; set; }
        public string DUCaNhanKhac_Ten { get; set; }
        public string DUCaNhanKhac_CoSoLan { get; set; }
        public bool DUCaNhanKhac_Khong { get; set; }
        public string DUCaNhanKhac_BieuHien { get; set; }
        public string DUDiTruyen_Ten { get; set; }
        public string DUDiTruyen_CoSoLan { get; set; }
        public bool DUDiTruyen_Khong { get; set; }
        public string DUDiTruyen_BieuHien { get; set; }
        // add follow issue 1142
        public string BacSyChuyenVaoVien { get; set; }
        public string BacSyNhapChanDoan { get; set; }
        public bool[] TinhHinhRV_Array { get; } = new bool[] { false, false, false, false, false };
        public string TinhHinhRV
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < TinhHinhRV_Array.Length; i++)
                    temp += (TinhHinhRV_Array[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        TinhHinhRV_Array[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public string CSKCB { get; set; }
        public bool[] KQDTDG_Array { get; } = new bool[] { false, false, false };
        public string KQDTDG
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < KQDTDG_Array.Length; i++)
                    temp += (KQDTDG_Array[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        KQDTDG_Array[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public string TyLe { get; set; }
        public string KQDT_BienChung { get; set; }
        public string KQDT_ChuyenVien { get; set; }
        public string KQDT_TuVong { get; set; }
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
