using EMR.KyDienTu;
using EMR_MAIN.DATABASE;
using PMS.Access;
using System;

namespace EMR_MAIN
{
    public class BenhAnSoSinh : BenhAnBase, IBase
    {
        public int IDMauPhieu { get; set; } = (int)DanhMucPhieu.BASS;
        public string TenMauPhieu { get; set; } = DanhMucPhieu.BASS.Description();
        public string HoiBenh { get; set; }
        public DateTime OiVo { get; set; }
        public string MauSac { get; set; }
        public bool CachDeID { get; set; }
        public DateTime ThoiGianDe { get; set; }
        public string LyDoCanThiep { get; set; }
        public string NguoiDoDe { get; set; }
        public string Apgar1 { get; set; }
        public string Apgar5 { get; set; }
        public string Apgar10 { get; set; }
        public double CanNang { get; set; }
        public string TinhTrangDinhDuong { get; set; }
        public bool HutDich { get; set; }
        public bool XoaBopTim { get; set; }
        public bool ThoO2 { get; set; }
        public bool DatNoiKhiQuan { get; set; }
        public bool BopBongO2 { get; set; }
        public bool Khac { get; set; }
        public string NguoiChuyenSoSinh { set; get; }
        public bool DiTatBamSinh { set; get; }
        public bool CoHauMon { set; get; }
        public string CuTheDiTat { set; get; }
        public string TinhHinhSoSinhKhiVaoKhoa { set; get; }
        public string TinhTrangToanThan { set; get; }
        public int MauSacDaID { set; get; }
        public string MauSacDa { set; get; }
        public int ChieuDai { get; set; }
        public int VongDau { get; set; }
        public int NhipTho { get; set; }
        public int NhietDo { get; set; }
        public string NghePhoi { set; get; }
        public float ChiSoSilverman { set; get; }
        public int SuDanNoLongNgucID { get; set; }
        public int CoKeoCoLienSuonID { get; set; }
        public int CoKeoMuiUcID { get; set; }
        public int DapCanhMuiID { get; set; }
        public int RenRiID { get; set; }
        public string Bung { set; get; }
        public string PhanXa { set; get; }
        public string TruongLucCo { set; get; }
        public int NhipTim { get; set; }
        public bool[] TinhTrangSoSinhKRDID_Array { get; } = new bool[] { false, false, false };
        public int TinhTrangSoSinhKRDID
        {
            get
            {
                return Array.IndexOf(TinhTrangSoSinhKRDID_Array, true) + 1;
            }
            set
            {
                for (int i = 0; i < TinhTrangSoSinhKRDID_Array.Length; i++)
                {
                    if (i == (value - 1)) TinhTrangSoSinhKRDID_Array[i] = true;
                    else TinhTrangSoSinhKRDID_Array[i] = false;
                }
            }
        }

        public string ChiDinhTheoDoi { get; set; }
        public bool[] iCachDeID_Array { get; } = new bool[] { false, false};
        public int iCachDeID
        {
            get
            {
                return Array.IndexOf(iCachDeID_Array, true) + 1;
            }
            set
            {
                for (int i = 0; i < iCachDeID_Array.Length; i++)
                {
                    if (i == (value - 1)) iCachDeID_Array[i] = true;
                    else iCachDeID_Array[i] = false;
                }
            }
        }
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
