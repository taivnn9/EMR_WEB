using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EMR.KyDienTu;

namespace EMR_MAIN.DATABASE.Other
{
    public class DonThuocVatTuNgoaiTruModel
    {
        public long MaBenhAn { get; set; }
        public long MaPhieu { get; set; }
        public string SoPhieu { get; set; }
        public string TenBacSiChiDinh { get; set; }
        public string MaBacSiChiDinh { get; set; }
        public DateTime ThoiGianChiDinh { get; set; }
        public string KhoaPhongChiDinh { get; set; }
        public string KhoaPhongThucHien { get; set; }
        [MoTaDuLieu("Chẩn đoán chỉ định")]
		public string ChanDoanChiDinh { get; set; }
        [MoTaDuLieu("Mã chẩn đoán chỉ định")]
		public string ChanDoanChiDinh_Code { get; set; }
        public string LoiDanBacSi { get; set; }
        public List<DonThuocVatTuNgoaiTruChiTietModel> ChiTiet { get; set; }
    }
    public class DonThuocVatTuNgoaiTruChiTietModel
    {
        public string MaThuoc { get; set; }
        public string TenThuoc { get; set; }
        [MoTaDuLieu("Số lượng")]
		public double SoLuong { get; set; }
        [MoTaDuLieu("Đơn giá")]
		public double DonGia { get; set; }
        [MoTaDuLieu("Đơn vị tính")]
		public string DonViTinh { get; set; }
        public int LaHaoPhi { get; set; }  // 0 ko phải hao phí, 1 là hao phí
        public string DuongDung { get; set; }
        public string HuongDanSuDung { get; set; }
    }
}
