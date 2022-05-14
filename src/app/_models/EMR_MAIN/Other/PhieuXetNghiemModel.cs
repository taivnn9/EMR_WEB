using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EMR.KyDienTu;

namespace EMR_MAIN.DATABASE.Other
{
    public class PhieuXetNghiemModel
    {
        public long MaBenhAn { get; set; }
        public long MaPhieu { get; set; }
        public string SoPhieu { get; set; }
        public int SoThuTuCLS { get; set; }
        public string BarCode { get; set; }
        public string TenBacSiChiDinh { get; set; }
        public string MaBacSiChiDinh { get; set; }
        public string TenBacSiTraKQ { get; set; }
        public string MaBacSiTraKQ { get; set; }
        public string MaBacSiLayMau { get; set; }
        public string TenBacSiLayMay { get; set; }
        public string ThoiGianChiDinh { get; set; }  //dd-MM-yyyy HH:mm:ss
        public string ThoiGianLayMau { get; set; }    //dd-MM-yyyy HH:mm:ss
        public string ThoiGianThucHien { get; set; } //dd-MM-yyyy HH:mm:ss
        public string ThoiGianKetThuc { get; set; }  //dd-MM-yyyy HH:mm:ss
        public string KhoaPhongChiDinh { get; set; }
        public string KhoaPhongThucHien { get; set; }
        [MoTaDuLieu("Chẩn đoán chỉ định")]
		public string ChanDoanChiDinh { get; set; }
        [MoTaDuLieu("Mã chẩn đoán chỉ định")]
		public string ChanDoanChiDinh_Code { get; set; }
        public int TrangThai { get; set; }
        public int LoaiBenhPham { get; set; }
        public List<ChiTietXetNghiemModel> ChiTiet { get; set; }
    }
    public class ChiTietXetNghiemModel
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
        public List<KetQuaXetNghiemModel> KetQua { get; set; }
    }
    public class KetQuaXetNghiemModel
    {
        [MoTaDuLieu("Mã định danh")]
		public long Id { get; set; }
        [MoTaDuLieu("Tên dịch vụ")]
		public string TenDichVu { get; set; }
        public string KetQua { get; set; }
        public string DonVi { get; set; }
        public string GioiHanDuoi { get; set; }
        public string GioiHanTren { get; set; }
        public string GhiChuCd { get; set; }
        public string GhiChuKq { get; set; }
        public string ThoiGianTraKQ { get; set; }
        [MoTaDuLieu("Chọn", null, 0, 0)]
		public bool Chon { get; set; }
        //03/06/2021 Add by Hòa Issues 64983
        public DateTime? NgayGio { get; set; }
        public string LoaiDichVu { get; set; }
        public string TenXetNghiem { get; set; }
        //03/06/2021 End by Hòa Issues 64983
        //08/06/2021 Add by Hòa Issues 64961
        [MoTaDuLieu("Mã định danh xét nghiệm")]
		public int IDXETNGHIEM { get; set; }
        public string MoTa { get; set; }
        [MoTaDuLieu("Mã định danh xét nghiệm")]
		public int IDLoaiXetNghiem { get; set; }
        //08/06/2021 End by Hòa Issues 64961
    }
}
