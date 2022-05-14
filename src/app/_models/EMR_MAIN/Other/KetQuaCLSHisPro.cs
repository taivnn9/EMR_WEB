using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EMR.KyDienTu;

namespace EMR_MAIN.DATABASE.Other
{
    public class KetQuaCLSHisPro
    {
        public DateTime? NgayGio { get; set; }
        public string LoaiDichVu { get; set; }
        [MoTaDuLieu("Tên dịch vụ")]
		public string TenDichVu { get; set; }
        public string TenXetNghiem { get; set; }
        public string KetQua { get; set; }
        [MoTaDuLieu("Ghi chú")]
		public string GhiChu { get; set; }
        [MoTaDuLieu("Chọn", null, 0, 0)]
		public bool Chon { get; set; }
        public string GroupNgay { get { return NgayGio != null ? NgayGio.Value.ToString("dd/MM/yyyy") : ""; } }
        public string GroupDichVu { get { return LoaiDichVu +" -> " +TenDichVu; } }
        public int Idxetnghiem { get; set; } //08/06/2021 Add by Hòa Issues 64961
        public string Mota { get; set; } //10/06/2021 Add by Hòa Issues 64961
        public int IdLoaixetnghiem { get; set; } //10/06/2021 Add by Hòa Issues 64961
        public KetQuaCLSHisPro(DateTime? ngayGio, string loaiDichVu, string tenDichVu, string tenXetNghiem, string ketQua, string ghiChu, int IDXETNGHIEM, string MOTA, int IDLOAIXETNGHIEM)
        {
            NgayGio = ngayGio;
            LoaiDichVu = loaiDichVu;
            TenDichVu = tenDichVu;
            TenXetNghiem = tenXetNghiem;
            KetQua = ketQua;
            GhiChu = ghiChu;
            Idxetnghiem = IDXETNGHIEM; //08/06/2021 Add by Hòa Issues 64961
            Mota = MOTA; //10/06/2021 Add by Hòa Issues 64961
            IdLoaixetnghiem = IDLOAIXETNGHIEM; //10/06/2021 Add by Hòa Issues 64961
        }    
    }
}
