using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EMR.KyDienTu;

namespace EMR_MAIN.DATABASE.Other
{
    public class PhieuChiDinhModel
    {
        public long MaBenhAn { get; set; }
        public long MaPhieu { get; set; }
        public string SoPhieu { get; set; }
        public int SoThuTuCLS { get; set; }
        public string TenBacSiChiDinh { get; set; }
        public string MaBacSiChiDinh { get; set; }
        public string TenBacSiTraKQ { get; set; }
        public string MaBacSiTraKQ { get; set; }
        public string ThoiGianChiDinh { get; set; }
        public string KhoaPhongChiDinh { get; set; }
        public string KhoaPhongThucHien { get; set; }
        [MoTaDuLieu("Chẩn đoán chỉ định")]
		public string ChanDoanChiDinh { get; set; }
        [MoTaDuLieu("Mã chẩn đoán đoán chỉ định")]
		public string ChanDoanChiDinh_Code { get; set; }
        public int TrangThai { get; set; }
        public List<PhieuChiDinhChiTietModel> ChiTiet { get; set; }
    }
    public class PhieuChiDinhChiTietModel
    {
        [MoTaDuLieu("Mã dịch vụ")]
		public string MaDichVu { get; set; }
        public string TenDich { get; set; }
        [MoTaDuLieu("Số lượng")]
		public double SoLuong { get; set; }
        [MoTaDuLieu("Đơn giá")]
		public double DonGia { get; set; }
        [MoTaDuLieu("Đơn vị tính")]
		public string DonViTinh { get; set; }
        public string Nhom { get; set; }
        public string NoiDung { get; set; }
        public string KetQua { get; set; }
        public string ThoiGianTraKQ { get; set; }
    }
}
