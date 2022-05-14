using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EMR.KyDienTu;
using PMS.Access;

namespace EMR_MAIN.DATABASE.BenhAn
{
    public class BenhAnNgoaiTru_HoTroSinhSan : BenhAnBase, IBase
    {
        public int IDMauPhieu { get; set; } = (int)DanhMucPhieu.BANgoaiTruHTSS;
        public string TenMauPhieu { get; set; } = DanhMucPhieu.BANgoaiTruHTSS.Description();
        // phan hanh chinh
        public string HoVaTenChong { get; set; }
        public DateTime? NgaySinhChong { get; set; }
        public string TuoiChong { get; set; }
        public string TrinhDoHocVanChong { get; set; }
        public string NgheNghiepChong { get; set; }
        public string MaNgheNghiepChong { get; set; }
        public string DanTocChong { get; set; }
        public string MaDanhTocChong { get; set; }
        public string NgoaiKieuChong { get; set; }
        public string MaNgoaiKieuChong { get; set; }
        public string SDTVo { get; set; }
        public string SDTChong { get; set; }

        // phan hoi benh 
        // Hỏi bệnh vợ
        [MoTaDuLieu("Mong con: .... năm")]
        public string MongCon { get; set; }
        public ObservableCollection<TienSuSanKhoaVo> TienSuSanKhoaVo { get; set; }
        public string BatDauThayKinh_Nam { get; set; }
        public string BatDauThayKinh_Tuoi { get; set; }
        public string TinhChatKinhNguyet { get; set; }
        public string ChuKy { get; set; }
        public string SoNgayThayKinh { get; set; }
        public string LuongKinh { get; set; }
        public DateTime? KinhLanCuoiNgay { get; set; }
        public bool DauBung { get; set; }
        public bool[] ThoiGian_Array { get; } = new bool[] { false, false, false };
        public string ThoiGian
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < ThoiGian_Array.Length; i++)
                    temp += (ThoiGian_Array[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        ThoiGian_Array[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public string LayChongNam { get; set; }
        public string LayChongTuoi { get; set; }
        public string HetKinhNam { get; set; }
        public string HetKinhTuoi { get; set; }
        public string NhungBenhPhuKhoaDaDieuTri { get; set; }
        [MoTaDuLieu("Kế hoạch hóa gia đình")]
        public int KHHGD { get; set; }
        public string PhuongPhap { get; set; }
        public int BenhLyNoiKhoa { get; set; }
        public string BenhLyNoiKhoa_Text { get; set; }
        public string TienSuHiemMuon { get; set; }
        // hỏi bệnh chồng
        public string DaTungCoCon { get; set; }
        [MoTaDuLieu("Hoạt động tình dục, sống chung thường xuyên")]
        public int HDTD_SongChungThuongXuyen { get; set; }
        [MoTaDuLieu("Hoạt động tình dục, Số lần giao hợp")]
        public string HDTD_SoLanGiaoHop { get; set; }
        public string ThoiQuen_HutThuoc { get; set; }
        public string ThoiQuen_Ruou { get; set; }
        public int BenhLyKhac_QuaiBi { get; set; }
        [MoTaDuLieu("Bệnh lý khác, nhiễm trùng tiết niệu, sinh dục")]
        public string BenhLyKhac_NhiemTrungTNSD { get; set; }
        public string BenhLyKhac_Khac { get; set; }
        public int DaDieuTriHiemMuon { get; set; }
        public string DieuTri { get; set; }

        // phần khám bệnh vợ
        public string Hach { get; set; }
        public string Vu { get; set; }
        // khám chuyên khoa, khám ngoài
        public string CacDauHieuSinhDucThuPhat { get; set; }
        public string MoiLon { get; set; }
        public string MoiBe { get; set; }
        public string AmVat { get; set; }
        public string AmHo { get; set; }
        public string MangTrinh { get; set; }
        public string TangSinhMon { get; set; }
        // khám trong
        public string AmDao { get; set; }
        public string CoTuCung { get; set; }
        public string ThanTuCung { get; set; }
        public string PhanPhu { get; set; }
        public string CacTuiCung { get; set; }

        // phần khám bệnh chồng
        public int TheTrang { get; set; }
        public int TinhTrangLong { get; set; }
        public int TimPhoi { get; set; }
        public string TinhHoan { get; set; }
        public string Biu { get; set; }
        public string MaoTinh { get; set; }
        public string ThungTinh { get; set; }
        public string DuongVat { get; set; }
        public string ChanDoanBanDau { get; set; }
        public string DaXuLy { get; set; }
        public string PhacDo { get; set; }
        public string LieuThuoc { get; set; }
        public string ChanDoanKhiRaVien { get; set; }
        public DateTime? DieuTri_Tu { get; set; }
        public DateTime? DieuTri_Den { get; set; }
        public DateTime? NgayTao { get; set; }
        public string GiamDocBenhVien { get; set; }

        // phần tổng kết
        public string ChanDoan { get; set; }
        public string PhacDoDieuTri { get; set; }
        public ObservableCollection<PhieuTheoDoiNangNoan> PhieuTheoDoiNangNoan { get; set; }
        public string Col_1 { get; set; }
        public string Col_2 { get; set; }
        public string Col_3 { get; set; }
        public string Col_4 { get; set; }
        public ObservableCollection<PhieuTheoDoiNoiMac> PhieuTheoDoiNoiMac { get; set; }
        public DateTime? NgayRaPhoi { get; set; }
        public string GhiChu_P4 { get; set; }
        public string GhiChu_Text { get; set; }
        public string PhoiChuyen { get; set; }
        public bool EmbryoGlue { get; set; }
        public bool Tractocil { get; set; }
        public bool PRP { get; set; }
        public string Aspirin { get; set; }
        public string Lovenox { get; set; }
        public string Progesteron { get; set; }
        public string KetQuaLABO { get; set; }
        public string KetQuaDieuTri { get; set; }

        // phần lưu dữ liệu ký
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
    public class TienSuSanKhoaVo
    {
        public int? SoLanCoThai { get; set; }
        public string Nam { get; set; }
        public string DeDuThang { get; set; }
        public string DeThieuThang { get; set; }
        public string Say { get; set; }
        public string Hut { get; set; }
        public string Nao { get; set; }
        public string Co_vac { get; set; }
        public string ChuaNgoaiTuCung { get; set; }
        public string ChuaTrung { get; set; }
        public string ThaiChetLuu { get; set; }
        public string ConHienSong { get; set; }
        public string CanNang { get; set; }
        public string PhuongPhapDe { get; set; }
        public string TaiBien { get; set; }
        public TienSuSanKhoaVo Clone(TienSuSanKhoaVo obj)
        {
            TienSuSanKhoaVo other = (TienSuSanKhoaVo)obj.MemberwiseClone();
            return other;

        }
    }
    public class PhieuTheoDoiNangNoan
    {
        public int NgayCK { get; set; }
        public string NgayThang { get; set; }
        public string G_A { get; set; }
        public string FSH { get; set; }
        public string LHhMG { get; set; }
        public string LHP4E2 { get; set; }
        public string BTPhai { get; set; }
        public string BTTrai { get; set; }
        public string NMTC { get; set; }
        public PhieuTheoDoiNangNoan Clone(PhieuTheoDoiNangNoan obj)
        {
            PhieuTheoDoiNangNoan other = (PhieuTheoDoiNangNoan)obj.MemberwiseClone();
            return other;

        }
    }
    public class PhieuTheoDoiNoiMac
    {
        public int NgayCK { get; set; }
        public string NgayThang { get; set; }
        public string Col_1 { get; set; }
        public string Col_2 { get; set; }
        public string Col_3 { get; set; }
        public string Col_4 { get; set; }
        public string BT_P { get; set; }
        public string BT_T { get; set; }
        public string NMTC { get; set; }
        public string BacSy { get; set; }
        public PhieuTheoDoiNoiMac Clone(PhieuTheoDoiNoiMac obj)
        {
            PhieuTheoDoiNoiMac other = (PhieuTheoDoiNoiMac)obj.MemberwiseClone();
            return other;

        }
    }
}
