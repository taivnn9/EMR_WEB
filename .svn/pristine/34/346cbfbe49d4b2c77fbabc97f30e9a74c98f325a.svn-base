using System;
using EMR.KyDienTu;
using EMR_MAIN.DATABASE;
using PMS.Access;
using System;

namespace EMR_MAIN.DATABASE.BenhAn
{
    public class BenhAnDaiThaoDuong:BenhAnBase, IBase
    {
        [MoTaDuLieu("ID mẫu phiếu")]
        public int IDMauPhieu { get; set; } = (int)DanhMucPhieu.BADTD;
        [MoTaDuLieu("Tên mẫu phiếu")]
        public string TenMauPhieu { get; set; } = DanhMucPhieu.BADTD.Description();
        [MoTaDuLieu("Lý do nhận vào chương trình")]
        public string LyDoNhanVaoChuongTrinh { get; set; }
        // A Tiền sử bản thân
        [MoTaDuLieu("Hút thuốc, 1 -> có, 2 -> không")]
        public int HutThuoc { get; set; }
        [MoTaDuLieu("Hút thuốc, điếu/ngày")]
        public string HutThuoc_DieuNgay { get; set; }
        [MoTaDuLieu("Hút thuốc, bao/năm")]
        public string HutThuoc_BaoNam { get; set; }
        [MoTaDuLieu("Hút thuốc, 1 -> bỏ")]
        public int HutThuoc_Bo { get; set; }
        [MoTaDuLieu("Uống rượu, 1 -> có, 2 -> không")]
        public int UongRuou { get; set; }
        [MoTaDuLieu("Uống rượu, ml/ngay")]
        public string UongRuou_MlNgay { get; set; }
        [MoTaDuLieu("Uống rượu, 1-> bỏ")]
        public int UongRuou_Bo { get; set; }
        [MoTaDuLieu("Tăng huyết áp")]
        public int TangHuyetAp { get; set; }
        [MoTaDuLieu("Rối loạn mỡ máu")]
        public int RoiLoanMoMau { get; set; }
        [MoTaDuLieu("Bệnh goutte")]
        public int BenhGoutte { get; set; }
        [MoTaDuLieu("Bệnh thận")]
        public int BenhThan { get; set; }
        [MoTaDuLieu("Bệnh thận, ghi rõ")]
        public string BenhThan_GhiRo { get; set; }
        [MoTaDuLieu("Bệnh lý khác")]
        public int BenhLyKhac { get; set; }
        [MoTaDuLieu("Bệnh lý khác, ghi rõ")]
        public string BenhLyKhac_GhiRo { get; set; }
        [MoTaDuLieu("Thời điểm phát hiện ĐTD")]
        public DateTime? ThoiDiemPhatHienDTD { get; set; }
        [MoTaDuLieu("Trị số đường huyết cao nhất")]
        public string TriSoDuongHuyetCaoNhat { get; set; }
        // 4. Hoàn cảnh phát hiện ĐTD
        [MoTaDuLieu("Hoàn cảnh phát hiện ĐTD, có triệu chứng, 1-> có, 2 -> không")]
        public int CoTrieuChung { get; set; }
        [MoTaDuLieu("Khám sức khỏe định kỳ")]
        public int KhamSKDinhKy { get; set; }
        [MoTaDuLieu("Tình cờ")]
        public int TinhCo { get; set; }
        [MoTaDuLieu("5. có điều trị thường xuyên hay không")]
        public string CDTTXHK { get; set; }
        //6. Điều trị ĐTD
        [MoTaDuLieu("Thực hiện chế độ ăn uống, tập luyện")]
        public int ThucHienCheDoAnUong { get; set; }
        [MoTaDuLieu("Thuốc uống, Sulffonylyra")]
        public int Sulffonylyra { get; set; }
        [MoTaDuLieu("Thuốc uống, Biguanid")]
        public int Biguanid { get; set; }
        [MoTaDuLieu("Thuốc uống, Acrbose")]
        public int Acrbose { get; set; }
        [MoTaDuLieu("Thuốc uống, Khác")]
        public int ThuocUong_Khac { get; set; }
        [MoTaDuLieu("Insulin")]
        public int Insulin { get; set; }
        // 7. Tiền sử sinh đẻ
        [MoTaDuLieu("Sảy thai")]
        public int SayThai { get; set; }
        [MoTaDuLieu("Sảy thai mấy lần")]
        public string SayThai_MayLan { get; set; }
        [MoTaDuLieu("Đẻ con lớn hơn 4 kg")]
        public int DeCon4Kg { get; set; }
        [MoTaDuLieu("Đẻ con lớn hơn 4 kg mấy lần")]
        public string DeCon4Kg_MayLan { get; set; }
        [MoTaDuLieu("Đẻ con nhỏ hơn 2.5 kg")]
        public int DeCon25kg { get; set; }
        [MoTaDuLieu("Đẻ con nhỏ hơn 2.5 kg mấy lần")]
        public string DeCon25kg_MayLan { get; set; }
        [MoTaDuLieu("Tiền sử đái tháo đường thai nghén")]
        public int TienSuDTDThaiNghen { get; set; }
        [MoTaDuLieu("RLDNG")]
        public int RLDNG { get; set; }
        // B. Tiền sử gia đình
        [MoTaDuLieu("Gia đình có bị đái tháo đường,  1-> có, 2 -> không")]
        public int GDCoBiDTD { get; set; }
        [MoTaDuLieu("Gia đình có bị đái tháo đường, người bị")]
        public string GDCoBiDTD_Text { get; set; }
        [MoTaDuLieu("Gia đình có người bị tim mạch sớm, 1-> có, 2-> không")]
        public int GDCoBiTimMachSom { get; set; }
        [MoTaDuLieu("Gia đình có người bị tim mạch sớm, người bị")]
        public string GDCoBiTimMachSom_Text { get; set; }
        [MoTaDuLieu("Tiền sử bệnh tật khác, 1-> có, 2-> không")]
        public int TienSuBenhTatKhac { get; set; }
        [MoTaDuLieu("Tiền sử bệnh tật khác, ghi rõ")]
        public string TienSuBenhTatKhac_GhiRo { get; set; }
        [MoTaDuLieu("Bệnh sử")]
        public string BenhSu { get; set; }
        // D. Khám lâm sàng
        // 1. Toàn thân
        [MoTaDuLieu("Chiều cao")]
        public string ChieuCao { get; set; }
        [MoTaDuLieu("Cân nặng")]
        public string CanNang { get; set; }
        [MoTaDuLieu("BMT")]
        public string BMT { get; set; }
        [MoTaDuLieu("Vòng eo")]
        public string VongEo { get; set; }
        [MoTaDuLieu("Vòng hông")]
        public string VongHong { get; set; }
        [MoTaDuLieu("Chỉ số eo/hông")]
        public string ChiSoEoHong { get; set; }
        //2. Triệu chứng cơ năng
        [MoTaDuLieu("Khát, uống nhiều")]
        public int KhatUongNhieu { get; set; }
        [MoTaDuLieu("Khát, uống nhiều, số lượng")]
        public string KhatUongNhieu_SL { get; set; }
        [MoTaDuLieu("Tiểu nhiều")]
        public int TieuNhieu { get; set; }
        [MoTaDuLieu("Tiểu nhiều, số lượng")]
        public string TieuNhieu_SL { get; set; }
        [MoTaDuLieu("Mệt mỏi")]
        public int MetMoi { get; set; }
        [MoTaDuLieu("Sụt cân")]
        public int SutCan { get; set; }
        [MoTaDuLieu("Đau ngực")]
        public int DauNguc { get; set; }
        [MoTaDuLieu("Đau cánh hồi")]
        public int DauCanhHoi { get; set; }
        [MoTaDuLieu("Tê bì chân tay")]
        public int TeBiChanTay { get; set; }
        [MoTaDuLieu("Mắt nhìn mở")]
        public int MatNhinMo { get; set; }
        [MoTaDuLieu("Triệu chứng khác")]
        public string TrieuChungKhac { get; set; }
        // 3. khám bộ phận
        // Mắt
        [MoTaDuLieu("Thị lực mắt phải")]
        public string ThiLuc_MP { get; set; }
        [MoTaDuLieu("Thị lực mắt trái")]
        public string ThiLuc_MT { get; set; }
        [MoTaDuLieu("Tổn thương mắt phải")]
        public string TonThuong_MP { get; set; }
        [MoTaDuLieu("Tổn thương mắt trái")]
        public string TonThuong_MT { get; set; }
        [MoTaDuLieu("Da, niêm mạc")]
        public string DaNiemMac { get; set; }
        [MoTaDuLieu("Phù, 1-> có, 2-> không")]
        public int Phu { get; set; }
        [MoTaDuLieu("Phù, vị trí")]
        public string Phu_ViTri { get; set; }
        [MoTaDuLieu("Tình trạng răng lợi")]
        public string TinhTrangRangLoi { get; set; }
        // Tĩm mạch
        //Tư thế nằm
        [MoTaDuLieu("Nhịp tim, Tư thế nằm")]
        public string NhipTim_TuTheNam { get; set; }
        [MoTaDuLieu("Huyết áp, Tư thế nằm")]
        public string HA_TuTheNam { get; set; }
        //Tư thế đứng
        [MoTaDuLieu("Nhịp tim, Tư thế đứng")]
        public string NhipTim_TuTheDung { get; set; }
        [MoTaDuLieu("Huyết áp, Tư thế đứng")]
        public string HA_TuTheDung { get; set; }
        [MoTaDuLieu("Mạch ngoại biên: giảm, mất mạch, 1 -> không, 2 -> có")]
        public int MachNgoaiBien { get; set; }
        [MoTaDuLieu("Mạch ngoại biên: giảm, mất mạch, vị trí")]
        public string MachNgoaiBien_ViTri { get; set; }
        [MoTaDuLieu("Tiếng phổi ĐM lớn ngoại biên, 1-> không, 2 -> có")]
        public int TiengPhoiDM { get; set; }
        [MoTaDuLieu("Tiếng phổi ĐM lớn ngoại biên, vị trí")]
        public string TiengPhoiDM_ViTri { get; set; }
        // Thần kinh
        [MoTaDuLieu("BLTK vận động, 1-> không, 2 -> có")]
        public int BLTK_VanDong { get; set; }
        [MoTaDuLieu("BLTK vận động, ghi rõ")]
        public string BLTK_VanDong_GhiRo { get; set; }
        [MoTaDuLieu("BLTK cảm giác, 1-> không, 2 -> có")]
        public int BLTK_CamGiac { get; set; }
        [MoTaDuLieu("BLTK cảm giác, ghi rõ")]
        public string BLTK_CamGiac_GhiRo { get; set; }
        [MoTaDuLieu("BLTK tự chủ, 1-> không, 2 -> có")]
        public int BLTK_TuChu { get; set; }
        [MoTaDuLieu("BLTK tự chủ, ghi rõ")]
        public string BLTK_TuChu_GhiRo { get; set; }
        [MoTaDuLieu("Các bộ phận khác")]
        public string CacBoPhanKhac { get; set; }
        // E. Cận lâm sàng
        //1. Mau
        [MoTaDuLieu("Đường máu (đói)")]
        public string DuongMau_Doi { get; set; }
        [MoTaDuLieu("Đường máu sau ăn 2 giờ")]
        public string DuongMau_SauAn { get; set; }
        [MoTaDuLieu("HbAlc")]
        public string HbAlc { get; set; }
        [MoTaDuLieu("Insulin")]
        public string Mau_Insulin { get; set; }
        [MoTaDuLieu("Creatimin")]
        public string Creatimin { get; set; }
        [MoTaDuLieu("Acrid Uric")]
        public string Acrid_Uric { get; set; }
        [MoTaDuLieu("Lipid CT")]
        public string Lipid_CT { get; set; }
        [MoTaDuLieu("Lipid TG")]
        public string Lipid_TG { get; set; }
        [MoTaDuLieu("Lipid HDL")]
        public string Lipid_HDL { get; set; }
        [MoTaDuLieu("Lipid LDL")]
        public string Lipid_LDL { get; set; }
        [MoTaDuLieu("Lipid GOT")]
        public string GOT { get; set; }
        [MoTaDuLieu("Lipid GPT")]
        public string GPT { get; set; }
        [MoTaDuLieu("Protein")]
        public string Protein { get; set; }
        [MoTaDuLieu("Albumin")]
        public string Albumin { get; set; }
        [MoTaDuLieu("CTM HC")]
        public string CTM_HC { get; set; }
        [MoTaDuLieu("CTM Hb")]
        public string CTM_Hb { get; set; }
        [MoTaDuLieu("CTM Ht")]
        public string CTM_Ht { get; set; }
        [MoTaDuLieu("CTM BC")]
        public string CTM_BC { get; set; }
        [MoTaDuLieu("CTM TC")]
        public string CTM_TC { get; set; }

        // nước tiểu
        [MoTaDuLieu("Nước tiểu, protein")]
        public string NuocTieu_Protein { get; set; }
        [MoTaDuLieu("Nước tiểu, đường")]
        public string NuocTieu_Duong { get; set; }
        [MoTaDuLieu("Nước tiểu, Cetol")]
        public string NuocTieu_Cetol { get; set; }
        [MoTaDuLieu("Điện tâm đồ")]
        public string DienTamDo { get; set; }
        [MoTaDuLieu("Siêu âm tim")]
        public string SieuAmTim { get; set; }
        [MoTaDuLieu("SA Doppler Mạch")]
        public string SADopplerMach { get; set; }
        [MoTaDuLieu("Xq tim phổi")]
        public string XqTimPhoi { get; set; }
        [MoTaDuLieu("Chẩn đoán")]
        public string ChanDoan { get; set; }
        [MoTaDuLieu("Thể đái tháo đường, 1 -> type 1, 2-> type 2, 3 -> type khác")]
        public int TheDTD { get; set; }
        [MoTaDuLieu("Type 1")]
        public string Type1_Text { get; set; }
        [MoTaDuLieu("Type 2")]
        public string Type2_Text { get; set; }
        [MoTaDuLieu("Type khác")]
        public string Type_Khac { get; set; }
        [MoTaDuLieu("Biến chứng")]
        public string BienChung { get; set; }
        [MoTaDuLieu("Bệnh phối hợp")]
        public string BenhPhoiHop { get; set; }
        [MoTaDuLieu("Điều trị")]
        public string DieuTri { get; set; }
        [MoTaDuLieu("Lý do thêm, thay đổi thuốc")]
        public string LyDoThemThayThuoc { get; set; }
        [MoTaDuLieu("Ngày hẹn khám lại")]
        public DateTime? HenKhamLai { get; set; }
        [MoTaDuLieu("Ngày hẹn XN lại")]
        public DateTime? HenXNLai { get; set; }
        //public string BacSyDieuTri { get; set; }
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
