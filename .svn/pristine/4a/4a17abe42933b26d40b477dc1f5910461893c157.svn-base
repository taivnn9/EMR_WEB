using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EMR.KyDienTu;

namespace EMR_MAIN.DATABASE.Other
{
    public class ToDieuTriModel
    {
        public string SoPhieu { get; set; }
        [MoTaDuLieu("Ngày tạo", null, 0, 0)]
		public string NgayTao { get; set; }
        [MoTaDuLieu("Giờ tạo")]
		public string GioTao { get; set; }
        [MoTaDuLieu("Mạch")]
		public string Mach { get; set; }
        [MoTaDuLieu("Nhiệt độ")]
		public string NhietDo { get; set; }
        [MoTaDuLieu("Nhịp thở")]
		public string NhipTho { get; set; }
        [MoTaDuLieu("Huyết áp")]
		public string HuyetAp { get; set; }
        [MoTaDuLieu("Cân nặng")]
		public string CanNang { get; set; }
        [MoTaDuLieu("Nước tiểu")]
		public string NuocTieu { get; set; }
        public string KhamToanThan { get; set; }
        public string KhamBoPhan { get; set; }
        public string KQCanLamSang { get; set; }
        [MoTaDuLieu("Chẩn đoán bệnh")]
		public string ChanDoan { get; set; }
        [MoTaDuLieu("Khoa")]
		public string Khoa { get; set; }
        public string MaChanDoan { get; set; }
        [MoTaDuLieu("Xử trí")]
        public string XuTri { get; set; }
        [MoTaDuLieu("Người tạo", null, 0, 0)]
		public string NguoiTao { get; set; }
        public string CheDoAn { get; set; }
        public string CheDoChamSoc { get; set; }
        public string DonThuocMuaNgoai { get; set; }
        public List<PhieuDieuTriYLenhModel> YLenh { get; set; }
    }
    public class PhieuDieuTriYLenhModel
    {
        public string SoPhieu { get; set; }
        [MoTaDuLieu("Ngày tạo", null, 0, 0)]
		public string NgayTao { get; set; }
        [MoTaDuLieu("Ngày sử dụng")]
        public string NgaySuDung { get; set; }
        [MoTaDuLieu("Giờ tạo")]
		public string GioTao { get; set; }
        [MoTaDuLieu("Tên dịch vụ")]
		public string TenDichVu { get; set; }
        public string LoaiPhieu { get; set; }
        [MoTaDuLieu("Người tạo", null, 0, 0)]
		public string NguoiTao { get; set; }
        [MoTaDuLieu("Số lượng")]
		public double SoLuong { get; set; }
        [MoTaDuLieu("Đơn vị tính")]
		public string DonViTinh { get; set; }
        public string HuongDanSuDung { get; set; }
        public string DuongDung { get; set; }
    }
    public class ToDieuTriKetXuatChiTiet
    {
        public string SoPhieu { get; set; }
        [MoTaDuLieu("Ngày tạo", null, 0, 0)]
		public string NgayTao { get; set; }
        [MoTaDuLieu("Diễn biến bệnh")]
        public DateTime? NgayTao_F
        {
            get
            {
                DateTime dt = DateTime.Now;
                if(DateTime.TryParseExact(NgayTao, "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture, DateTimeStyles.None, out dt))
                {
                    return dt;
                }
                return null;
            }
        }
		public string DienBienBenh { get; set; }
        [MoTaDuLieu("Y lệnh")]
		public string YLenh { get; set; }
        [MoTaDuLieu("Người tạo", null, 0, 0)]
		public string NguoiTao { get; set; }
        [MoTaDuLieu("Chẩn đoán bệnh")]
		public string ChanDoan { get; set; }
        [MoTaDuLieu("Khoa")]
		public string Khoa { get; set; }
        public string DuongDung { get; set; }
        public string DienBien { get; set; }
        public string DienBienCLS { get; set; }
        public bool Chon { get; set; }
    }
}
