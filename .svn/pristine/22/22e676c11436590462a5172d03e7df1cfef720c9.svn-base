using System;
using EMR.KyDienTu;
using PMS.Access;

namespace EMR_MAIN.DATABASE.BenhAn
{
    public class BenhAnNgoaiTru_BenhVayNenTheMu : IBase
    {
        public int IDMauPhieu { get; set; } = (int)DanhMucPhieu.BANTBVNTM;
        public string TenMauPhieu { get; set; } = DanhMucPhieu.BANTBVNTM.Description();
        // Phần chung Hành chính
        public decimal MaQuanLy { get; set; }
        public DateTime? DieuTriNgoaiTruTu { get; set; }
        public DateTime? DieuTriNgoaiTruDen { get; set; }
        public string SoCMND { get; set; }
        public DateTime? BaoHiem { get; set; }
        public string ChanDoan_TuyenTruoc { get; set; }
        public string ChanDoanBanDau { get; set; }
        public string ChanDoanTaiKham1 { get; set; }
        public string ChanDoanTaiKham2 { get; set; }
        public string ChanDoanTaiKham3 { get; set; }
        public string ChanDoanTaiKham4 { get; set; }
        public string BenhPhu { get; set; }
        public int KetQuaDieuTri { get; set; }
        public string BienChung_Text { get; set; }
        public string GDPhongKeHoach { get; set; }
        public string GDPhongKhamBenh { get; set; }
        // Phần hỏi bệnh
        //1. Tiền sử - bệnh sử
        public string ThoiGianKhoiPhat { get; set; }
        public string ViTriKhoiPhat { get; set; }
        public string TrieuChungDauTien { get; set; }
        public string NhapVienLan { get; set; }
        public string QuaTrinhDieuTri { get; set; }
        public string BenhKhac { get; set; }
        public string ThoiQuenCaNhan { get; set; }
        public string YeuToTinhThan { get; set; }
        public int TienSuGiaDinh { get; set; }
        public string TienSuGiaDinh_Co { get; set; }
        // 2. SÀNG LỌC CÁC BỆNH ĐỒNG MẮC VÀ HƯỚNG DẪN XỬ TRÍ:
        public int NguyCoCao { get; set; }
        public int CoYeuToNguyCoCao { get; set; }
        // 3. TOÀN TRẠNG
        public string NhietDo { get; set; }
        public string Mach { get; set; }
        public string HA { get; set; }
        public string Can { get; set; }
        public string Cao { get; set; }
        public string TrieuChungCoNang { get; set; }
        //4. BIỂU HIỆN DA
        public string TonThuongCoBan { get; set; }
        public bool[] DatDo_Array { get; } = new bool[] { false, false, false };
        public string DatDo
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < DatDo_Array.Length; i++)
                    temp += (DatDo_Array[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        DatDo_Array[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public int MunMu_KichThuoc { get; set; }
        public int MunMu_TinhChat { get; set; }
        public int MunMu_MauSac { get; set; }
        public int MunMu_MatDo { get; set; }
        public bool[] Vay_Array { get; } = new bool[] { false, false, false };
        public string Vay
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < Vay_Array.Length; i++)
                    temp += (Vay_Array[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        Vay_Array[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public ViTriTonThuong DauMatCo { get; set; }
        public ViTriTonThuong ChiTren { get; set; }
        public ViTriTonThuong ThanTruoc { get; set; }
        public ViTriTonThuong ThanSau { get; set; }
        public ViTriTonThuong ChiDuoi { get; set; }
        public ViTriTonThuong BoPhanSD { get; set; }
        //THANG ĐIỂM ĐÁNH GIÁ MỨC ĐỘ: Theo JDA score
        public string TongDiem { get; set; }
        public string MucDo { get; set; }
        // đánh giá mức độ 
        public int MucDoJDA { get; set; }
        public string DiemPASI { get; set; }
        //5. biểu hiện móng
        public int BieuHienMong { get; set; }
        public string BieuHienMong_Text { get; set; }
        public string TongDiemNAPSI { get; set; }
        // 6. Biểu hiện khớp
        public int BieuHienKhop { get; set; }
        public string SoKhopDau { get; set; }
        public string SoKhopSung { get; set; }
        public string BieuHienKhop_Text { get; set; }
        // 7. Biểu hiện niêm mạc
        public int BieuHienNiemMac { get; set; }
        public string BieuHienNiemMac_ViTri { get; set; }
        // 8. Các biểu hiện lâm sàng khác
        public string TimMach { get; set; }
        public string HoHap { get; set; }
        public string TieuHoa { get; set; }
        public string TamThan { get; set; }
        public string DiemDLQI { get; set; }
        // 9. ghi chú
        public string GhiChu { get; set; }
        // 11. Chẩn đoán
        public string ChanDoanTheoGGP { get; set; }
        public string ChanDoanVayNen { get; set; }
        public bool[] ChanDoanVayNen_NeuCo_Array { get; } = new bool[] { false, false, false };
        public string ChanDoanVayNen_NeuCo
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < ChanDoanVayNen_NeuCo_Array.Length; i++)
                    temp += (ChanDoanVayNen_NeuCo_Array[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        ChanDoanVayNen_NeuCo_Array[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public string ChanDoanVayNen_Khac { get; set; }
        // VII. ĐIỀU TRỊ
        public string DieuTri_CuThe { get; set; }
        public DateTime? HenTaiKham { get; set; }
        public string BacSiDieuTri { get; set; }
        // PHẦN TÁI KHÁM
        public string TK_HoTen { get; set; }
        public string TK_SoBADienTu { get; set; }
        public DateTime? TK_Ngay { get; set; }
        public string TK_SoLuuTru { get; set; }
        public string TK_NhietDo { get; set; }
        public string TK_Mach { get; set; }
        public string TK_HA { get; set; }
        public string TK_Can { get; set; }
        public string TK_Cao { get; set; }
        public string TK_TrieuChungCoNang { get; set; }
        public string TK_TienSu { get; set; }
        //3. Lâm sàng da, niêm mạc
        public int TK_DatDo { get; set; }
        public int TK_MunMu { get; set; }
        public int TK_Vay { get; set; }
        // 4. Biểu hiện móng
        public int TK_BieuHienMong { get; set; }
        public string TK_BieuHienMong_ViTri { get; set; }
        public string TK_TongDiemNAPSI { get; set; }
        // 5. Bieu hiện khớp
        public int TK_BieuHienKhop { get; set; }
        public string TK_BieuHienKhop_ViTri { get; set; }
        //6. BIỂU HIỆN NIÊM MẠC
        public int TK_BieuHienNiemMac { get; set; }
        public string TK_BieuHienNiemMac_ViTri { get; set; }
        //7. Các biểu hiện lâm sàng khác 
        public string TK_TimMach { get; set; }
        public string TK_HoHap { get; set; }
        public string TK_TieuHoa { get; set; }
        public string TK_TamThan { get; set; }
        //8.tác dụng phụ của thuốc
        public string TK_TacDungPhuCuaThuoc { get; set; }
        //9. THANG ĐIỂM ĐÁNH GIÁ (đánh giá PASI theo từng tháng, đánh giá theo JDA 3 tháng/lần)
        public string TK_JDAScore { get; set; }
        public string TK_PASIChoGpp { get; set; }
        public string TK_ChuY { get; set; }
        public string TK_DieuTri { get; set; }
        public DateTime? TK_HenTaiKham { get; set; }
        public string TK_BacSiKhamBenh { get; set; }


        // Phần tổng kết
        public string QuaTrinhBenhLy { get; set; }
        public string TomTatKetQua { get; set; }
        public string BenhChinh { get; set; }
        public string MaBenhChinh { get; set; }
        public string BenhKemTheo { get; set; }
        public string MaBenhKemTheo { get; set; }
        public string PhuongPhapDieuTri { get; set; }
        public string TinhTrangRaVien { get; set; }
        public string HuongDieuTri { get; set; }
        public string NguoiNhanHoSo { get; set; }
        public string NguoiGiaoHoSo { get; set; }
        public DateTime NgayTongKet { get; set; }
        public string TongKet_BacSyDieuTri { get; set; }
        public string TongKet_MaBacSyDieuTri { get; set; }


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
    public class ViTriTonThuong
    {
        public string KhongTonThuong { get; set; }
        public string ViTri { get; set; }
        public string UocLuong { get; set; }
        public string Diem { get; set; }
    }
}
