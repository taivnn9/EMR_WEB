using EMR.KyDienTu;
using EMR_MAIN.DATABASE;
using PMS.Access;
using System;

namespace EMR_MAIN
{
    public class BenhAnBong : BenhAnBase, IBase
    {
        [MoTaDuLieu("ID mẫu phiếu")]
        public int IDMauPhieu { get; set; } = (int)DanhMucPhieu.BABONG;
        [MoTaDuLieu("Tên mẫu phiếu")]
        public string TenMauPhieu { get; set; } = DanhMucPhieu.BABONG.Description();
        public string SinhDuc { set; get; }
        [MoTaDuLieu("Tổn thương bỏng","",0,1,1)]
        public string TonThuongBong { set; get; }
        public string HinhAnhHoacVe { get; set; }
        public bool PhauThuat { set; get; }
        public bool ThuThuat { get; set; }
        public DateTime ThoiGianBiBong { get; set; }
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
