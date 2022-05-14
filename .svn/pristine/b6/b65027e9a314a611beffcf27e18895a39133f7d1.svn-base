using EMR.KyDienTu;
using Newtonsoft.Json;
using PMS.Access;
using System;

namespace EMR_MAIN.DATABASE.Other
{
    public class GiayChuyenVien : ThongTinKy
    {
        public GiayChuyenVien()
        {
            IDMauPhieu = (int)DanhMucPhieu.P_GIAYCHUYENVIEN;
            TenMauPhieu = DanhMucPhieu.P_GIAYCHUYENVIEN.Description();
        }
        /// <summary>
        /// Key của table p_GiayChuyenVien: maql
        /// </summary>
        public decimal MaQuanLy { get; set; }
        /// <summary>
        /// mã bệnh viện
        /// </summary>
        [JsonProperty("MA_CSKCB")]
        public string MaBV { get; set; }

        /// <summary>
        /// hạng bệnh viện
        /// </summary>
        public int HangBenhVien { get; set; }
        /// <summary>
        ///  dấu hiệu lâm sàng
        /// </summary>
        public string DauHieuLamSang { get; set; }

        /// <summary>
        /// xét nghiệm
        /// </summary>
        public string XetNghiem { get; set; }
        /// <summary>
        /// Chẩn đoán
        /// </summary>
        public string ChanDoan { get; set; }
        /// <summary>
        /// Thuốc
        /// </summary>
        public string Thuoc { get; set; }
        public string TinhTrang { get; set; }
        public string HuongDieuTri { get; set; }
        /// <summary>
        /// Ngày,giờ chuyển viện
        /// </summary>
        public DateTime NgayChuyenVien { get; set; }
        public string PhuongTienVanChuyen { get; set; }
        public string NguoiDua { get; set; }
        /// <summary>
        ///  Lần in
        /// </summary>
        public int LanIn { get; set; }
        public string SoChuyenVien { get; set; }
        public int ChuyenVienTheoYeuCau { get; set; }
        public string SoHoSo { get; set; }
        public int DaLuuTru { get; set; }
        public string SoLuuTru { get; set; }
        public DateTime NgayLuuTru { get; set; }
        public string MaBSKy { get; set; }
        public string MaTruongKhoaKy { get; set; }
        public string MaLanhDaoKy { get; set; }
        [JsonProperty("SO_GIAY_CHUYEN_TUYEN")]
        public string SoGCT { get; set; } = string.Empty;
        public int ChuyenVienDieuTriCovid19 { get; set; }

    }
}
