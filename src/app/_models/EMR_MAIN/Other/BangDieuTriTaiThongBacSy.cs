using EMR.KyDienTu;
using System;
using System.Collections.Generic;
using System.Data;
using PMS.Access;

namespace EMR_MAIN.DATABASE.Other
{
    public class BangDieuTriTaiThongBacSy : ThongTinKy
    {
        public BangDieuTriTaiThongBacSy()
        {
            TableName = "BangDieuTriTaiThongBacSy";
            TablePrimaryKeyName = "ID";
            IDMauPhieu = (int)DanhMucPhieu.BKDTTTBS;
            TenMauPhieu = DanhMucPhieu.BKDTTTBS.Description();
        }
        [MoTaDuLieu("Mã định danh")]
		public long ID { get; set; }
        [MoTaDuLieu("Mã quản lý: mã duy nhất trong 1 đợt khám chữa bệnh (kcb), không trùng giữa các đợt kcb khác nhau","",1)]
		public decimal MaQuanLy { get; set; }
        [MoTaDuLieu("Mã bệnh nhân")]
		public string MaBenhNhan { get; set; }
        [MoTaDuLieu("Cân nặng")]
        public double CanNang { get; set; }
        #region Cac moc thoi gian
        [MoTaDuLieu("Thời điểm đến khoa cấp cứu")]
        public DateTime ThoiDiemDenKhoacapCuu { get; set; }
        [MoTaDuLieu("Thời điểm phát hiện đột quỵ")]
        public DateTime ThoiDiemPhatHienDotQuy { get; set; }
        [MoTaDuLieu("Thời điểm thấy bình thường")]
        public DateTime ThoiDiemThayBinhThuong { get; set; }
        [MoTaDuLieu("Thời điểm Bác sĩ thần kinh có mặt")]
        public DateTime ThoiDiemBSThanKinhCoMat { get; set; }
        [MoTaDuLieu("Thời điểm chụp CT")]
        public DateTime ThoiDiemChupCT { get; set; }
        [MoTaDuLieu("Thời điểm Bolus rtPA")]
        public DateTime ThoiDiemBolus { get; set; }
        [MoTaDuLieu("Thời điểm bác sĩ can thiệp thần kinh cơ mặt")]
        public DateTime ThoiDiemBSCanThiepTK { get; set; }
        [MoTaDuLieu("Thời điểm trích DM đùi(can thiệp)")]
        public DateTime ThoiDiemTrichDM { get; set; }
        [MoTaDuLieu("Thời điểm tái thông đầu tiên(can thiệp)")]
        public DateTime ThoiDiemTaithongDauTien { get; set; }
        [MoTaDuLieu("Thời điểm tái thông hoàn tất(can thiệp)")]
        public DateTime ThoiDiemTaiThongHoanTat { get; set; }
        #endregion
        #region Cac van de cua benh nhan
        [MoTaDuLieu("Bệnh cảnh")]
        public string BenhCanh_Text { get; set; }
        public bool[] BenhCanh1Array { get; } = new bool[] { false, false };
        public int BenhCanh1
        {
            get
            {
                return Array.IndexOf(BenhCanh1Array, true) + 1;
            }
            set
            {
                for (int i = 0; i < 2; i++)
                {
                    if (i == (value - 1)) BenhCanh1Array[i] = true;
                    else BenhCanh1Array[i] = false;
                }
            }
        }
        public bool[] BenhCanh2Array { get; } = new bool[] { false, false };
        public int BenhCanh2
        {
            get
            {
                return Array.IndexOf(BenhCanh2Array, true) + 1;
            }
            set
            {
                for (int i = 0; i < 2; i++)
                {
                    if (i == (value - 1)) BenhCanh2Array[i] = true;
                    else BenhCanh2Array[i] = false;
                }
            }
        }
        public bool[] BenhCanh3Array { get; } = new bool[] { false, false };
        public int BenhCanh3
        {
            get
            {
                return Array.IndexOf(BenhCanh3Array, true) + 1;
            }
            set
            {
                for (int i = 0; i < 2; i++)
                {
                    if (i == (value - 1)) BenhCanh3Array[i] = true;
                    else BenhCanh3Array[i] = false;
                }
            }
        }
        [MoTaDuLieu("Lâm sàng")]
        public string LamSang_Text { get; set; }
        [MoTaDuLieu("Huyết áp")]
		public string HuyetAp { get; set; }
        [MoTaDuLieu("Đường huyết")]
        public double DuongHuyet { get; set; }
        [MoTaDuLieu("Tiểu cầu")]
        public double TieuCau { get; set; }
        [MoTaDuLieu("Lâm sàng")]
        public bool[] LamSang1Array { get; } = new bool[] { false, false };
        [MoTaDuLieu("Triệu chứng gợi ý XH dưới nhện (bất kể kết quả CT)")]
        public int LamSang1
        {
            get
            {
                return Array.IndexOf(LamSang1Array, true) + 1;
            }
            set
            {
                for (int i = 0; i < 2; i++)
                {
                    if (i == (value - 1)) LamSang1Array[i] = true;
                    else LamSang1Array[i] = false;
                }
            }
        }
        public bool[] LamSang2Array { get; } = new bool[] { false, false };
        [MoTaDuLieu("Huyết áp > 185/110 mmHg ( có thể điều chỉnh huyết áp)")]
        public int LamSang2
        {
            get
            {
                return Array.IndexOf(LamSang2Array, true) + 1;
            }
            set
            {
                for (int i = 0; i < 2; i++)
                {
                    if (i == (value - 1)) LamSang2Array[i] = true;
                    else LamSang2Array[i] = false;
                }
            }
        }
        public bool[] LamSang3Array { get; } = new bool[] { false, false };
        [MoTaDuLieu("Đường huyết < 50 mg/dL (2.7 mmmol/L")]
        public int LamSang3
        {
            get
            {
                return Array.IndexOf(LamSang3Array, true) + 1;
            }
            set
            {
                for (int i = 0; i < 2; i++)
                {
                    if (i == (value - 1)) LamSang3Array[i] = true;
                    else LamSang3Array[i] = false;
                }
            }
        }
        public bool[] LamSang4Array { get; } = new bool[] { false, false };
        [MoTaDuLieu("Tiểu cầu < 100 000/mm3")]
        public int LamSang4
        {
            get
            {
                return Array.IndexOf(LamSang4Array, true) + 1;
            }
            set
            {
                for (int i = 0; i < 2; i++)
                {
                    if (i == (value - 1)) LamSang4Array[i] = true;
                    else LamSang4Array[i] = false;
                }
            }
        }
        [MoTaDuLieu("Tiền căn bệnh lý")]
        public string TienCan_Text { get; set; }

        public bool[] TienCan1Array { get; } = new bool[] { false, false };
        public int TienCan1
        {
            get
            {
                return Array.IndexOf(TienCan1Array, true) + 1;
            }
            set
            {
                for (int i = 0; i < 2; i++)
                {
                    if (i == (value - 1)) TienCan1Array[i] = true;
                    else TienCan1Array[i] = false;
                }
            }
        }
        public bool[] TienCan2Array { get; } = new bool[] { false, false };
        public int TienCan2
        {
            get
            {
                return Array.IndexOf(TienCan2Array, true) + 1;
            }
            set
            {
                for (int i = 0; i < 2; i++)
                {
                    if (i == (value - 1)) TienCan2Array[i] = true;
                    else TienCan2Array[i] = false;
                }
            }
        }
        public bool[] TienCan3Array { get; } = new bool[] { false, false };
        public int TienCan3
        {
            get
            {
                return Array.IndexOf(TienCan3Array, true) + 1;
            }
            set
            {
                for (int i = 0; i < 2; i++)
                {
                    if (i == (value - 1)) TienCan3Array[i] = true;
                    else TienCan3Array[i] = false;
                }
            }
        }
        public bool[] TienCan4Array { get; } = new bool[] { false, false };
        public int TienCan4
        {
            get
            {
                return Array.IndexOf(TienCan4Array, true) + 1;
            }
            set
            {
                for (int i = 0; i < 2; i++)
                {
                    if (i == (value - 1)) TienCan4Array[i] = true;
                    else TienCan4Array[i] = false;
                }
            }
        }
        public bool[] TienCan5Array { get; } = new bool[] { false, false };
        public int TienCan5
        {
            get
            {
                return Array.IndexOf(TienCan5Array, true) + 1;
            }
            set
            {
                for (int i = 0; i < 2; i++)
                {
                    if (i == (value - 1)) TienCan5Array[i] = true;
                    else TienCan5Array[i] = false;
                }
            }
        }
        public bool[] TienCan6Array { get; } = new bool[] { false, false };
        public int TienCan6
        {
            get
            {
                return Array.IndexOf(TienCan6Array, true) + 1;
            }
            set
            {
                for (int i = 0; i < 2; i++)
                {
                    if (i == (value - 1)) TienCan6Array[i] = true;
                    else TienCan6Array[i] = false;
                }
            }
        }
        [MoTaDuLieu("Rối loạn đông máu")]
        public string RoiLoanDongMau_Text { get; set; }
        public bool[] RoiLoanDongMau1Array { get; } = new bool[] { false, false };
        public int RoiLoanDongMau1
        {
            get
            {
                return Array.IndexOf(RoiLoanDongMau1Array, true) + 1;
            }
            set
            {
                for (int i = 0; i < 2; i++)
                {
                    if (i == (value - 1)) RoiLoanDongMau1Array[i] = true;
                    else RoiLoanDongMau1Array[i] = false;
                }
            }
        }
        public bool[] RoiLoanDongMau2Array { get; } = new bool[] { false, false };
        public int RoiLoanDongMau2
        {
            get
            {
                return Array.IndexOf(RoiLoanDongMau2Array, true) + 1;
            }
            set
            {
                for (int i = 0; i < 2; i++)
                {
                    if (i == (value - 1)) RoiLoanDongMau2Array[i] = true;
                    else RoiLoanDongMau2Array[i] = false;
                }
            }
        }
        public bool[] RoiLoanDongMau3Array { get; } = new bool[] { false, false };
        public int RoiLoanDongMau3
        {
            get
            {
                return Array.IndexOf(RoiLoanDongMau3Array, true) + 1;
            }
            set
            {
                for (int i = 0; i < 2; i++)
                {
                    if (i == (value - 1)) RoiLoanDongMau3Array[i] = true;
                    else RoiLoanDongMau3Array[i] = false;
                }
            }
        }
        public bool[] RoiLoanDongMau4Array { get; } = new bool[] { false, false };
        public int RoiLoanDongMau4
        {
            get
            {
                return Array.IndexOf(RoiLoanDongMau4Array, true) + 1;
            }
            set
            {
                for (int i = 0; i < 2; i++)
                {
                    if (i == (value - 1)) RoiLoanDongMau4Array[i] = true;
                    else RoiLoanDongMau4Array[i] = false;
                }
            }
        }
        public bool[] RoiLoanDongMau5Array { get; } = new bool[] { false, false };
        public int RoiLoanDongMau5
        {
            get
            {
                return Array.IndexOf(RoiLoanDongMau5Array, true) + 1;
            }
            set
            {
                for (int i = 0; i < 2; i++)
                {
                    if (i == (value - 1)) RoiLoanDongMau5Array[i] = true;
                    else RoiLoanDongMau5Array[i] = false;
                }
            }
        }
        [MoTaDuLieu("Hình ảnh học")]
        public string HinhAnhHoc { get; set; }
        public bool[] KetQuaCT1Array { get; } = new bool[] { false, false };
        public int KetQuaCT1
        {
            get
            {
                return Array.IndexOf(KetQuaCT1Array, true) + 1;
            }
            set
            {
                for (int i = 0; i < 2; i++)
                {
                    if (i == (value - 1)) KetQuaCT1Array[i] = true;
                    else KetQuaCT1Array[i] = false;
                }
            }
        }
        public bool[] KetQuaCT2Array { get; } = new bool[] { false, false };
        public int KetQuaCT2
        {
            get
            {
                return Array.IndexOf(KetQuaCT2Array, true) + 1;
            }
            set
            {
                for (int i = 0; i < 2; i++)
                {
                    if (i == (value - 1)) KetQuaCT2Array[i] = true;
                    else KetQuaCT2Array[i] = false;
                }
            }
        }
        [MoTaDuLieu("Chống chỉ định riêng")]
        public string ChongChiDinhRieng_Text { get; set; }
        public bool[] ChongChiDinhRieng1Array { get; } = new bool[] { false, false };
        public int ChongChiDinhRieng1
        {
            get
            {
                return Array.IndexOf(ChongChiDinhRieng1Array, true) + 1;
            }
            set
            {
                for (int i = 0; i < 2; i++)
                {
                    if (i == (value - 1)) ChongChiDinhRieng1Array[i] = true;
                    else ChongChiDinhRieng1Array[i] = false;
                }
            }
        }
        public bool[] ChongChiDinhRieng2Array { get; } = new bool[] { false, false };
        public int ChongChiDinhRieng2
        {
            get
            {
                return Array.IndexOf(ChongChiDinhRieng2Array, true) + 1;
            }
            set
            {
                for (int i = 0; i < 2; i++)
                {
                    if (i == (value - 1)) ChongChiDinhRieng2Array[i] = true;
                    else ChongChiDinhRieng2Array[i] = false;
                }
            }
        }
        public bool[] ChongChiDinhRieng3Array { get; } = new bool[] { false, false };
        public int ChongChiDinhRieng3
        {
            get
            {
                return Array.IndexOf(ChongChiDinhRieng3Array, true) + 1;
            }
            set
            {
                for (int i = 0; i < 2; i++)
                {
                    if (i == (value - 1)) ChongChiDinhRieng3Array[i] = true;
                    else ChongChiDinhRieng3Array[i] = false;
                }
            }
        }
        public bool[] ChongChiDinhRieng4Array { get; } = new bool[] { false, false };
        public int ChongChiDinhRieng4
        {
            get
            {
                return Array.IndexOf(ChongChiDinhRieng4Array, true) + 1;
            }
            set
            {
                for (int i = 0; i < 2; i++)
                {
                    if (i == (value - 1)) ChongChiDinhRieng4Array[i] = true;
                    else ChongChiDinhRieng4Array[i] = false;
                }
            }
        }
        [MoTaDuLieu("Chống chỉ định tương đối")]
        public string ChongTriDinhTuongDoi_Text { get; set; }
        public bool[] ChongTriDinhTuongDoi1Array { get; } = new bool[] { false, false };
        public int ChongTriDinhTuongDoi1
        {
            get
            {
                return Array.IndexOf(ChongTriDinhTuongDoi1Array, true) + 1;
            }
            set
            {
                for (int i = 0; i < 2; i++)
                {
                    if (i == (value - 1)) ChongTriDinhTuongDoi1Array[i] = true;
                    else ChongTriDinhTuongDoi1Array[i] = false;
                }
            }
        }
        public bool[] ChongTriDinhTuongDoi2Array { get; } = new bool[] { false, false };
        public int ChongTriDinhTuongDoi2
        {
            get
            {
                return Array.IndexOf(ChongTriDinhTuongDoi2Array, true) + 1;
            }
            set
            {
                for (int i = 0; i < 2; i++)
                {
                    if (i == (value - 1)) ChongTriDinhTuongDoi2Array[i] = true;
                    else ChongTriDinhTuongDoi2Array[i] = false;
                }
            }
        }
        public bool[] ChongTriDinhTuongDoi3Array { get; } = new bool[] { false, false };
        public int ChongTriDinhTuongDoi3
        {
            get
            {
                return Array.IndexOf(ChongTriDinhTuongDoi3Array, true) + 1;
            }
            set
            {
                for (int i = 0; i < 2; i++)
                {
                    if (i == (value - 1)) ChongTriDinhTuongDoi3Array[i] = true;
                    else ChongTriDinhTuongDoi3Array[i] = false;
                }
            }
        }
        public bool[] ChongTriDinhTuongDoi4Array { get; } = new bool[] { false, false };
        public int ChongTriDinhTuongDoi4
        {
            get
            {
                return Array.IndexOf(ChongTriDinhTuongDoi4Array, true) + 1;
            }
            set
            {
                for (int i = 0; i < 2; i++)
                {
                    if (i == (value - 1)) ChongTriDinhTuongDoi4Array[i] = true;
                    else ChongTriDinhTuongDoi4Array[i] = false;
                }
            }
        }
        public bool[] ChongTriDinhTuongDoi5Array { get; } = new bool[] { false, false };
        public int ChongTriDinhTuongDoi5
        {
            get
            {
                return Array.IndexOf(ChongTriDinhTuongDoi5Array, true) + 1;
            }
            set
            {
                for (int i = 0; i < 2; i++)
                {
                    if (i == (value - 1)) ChongTriDinhTuongDoi5Array[i] = true;
                    else ChongTriDinhTuongDoi5Array[i] = false;
                }
            }
        }
        public bool[] ChongTriDinhTuongDoi6Array { get; } = new bool[] { false, false };
        public int ChongTriDinhTuongDoi6
        {
            get
            {
                return Array.IndexOf(ChongTriDinhTuongDoi6Array, true) + 1;
            }
            set
            {
                for (int i = 0; i < 2; i++)
                {
                    if (i == (value - 1)) ChongTriDinhTuongDoi6Array[i] = true;
                    else ChongTriDinhTuongDoi6Array[i] = false;
                }
            }
        }
        public bool[] ChongTriDinhTuongDoi7Array { get; } = new bool[] { false, false };
        public int ChongTriDinhTuongDoi7
        {
            get
            {
                return Array.IndexOf(ChongTriDinhTuongDoi7Array, true) + 1;
            }
            set
            {
                for (int i = 0; i < 2; i++)
                {
                    if (i == (value - 1)) ChongTriDinhTuongDoi7Array[i] = true;
                    else ChongTriDinhTuongDoi7Array[i] = false;
                }
            }
        }
        [MoTaDuLieu("Cân nhắc điều trị")]
        public string CanNhacDieuTri_Text { get; set; }
        public bool[] CanNhac1Array { get; } = new bool[] { false, false };
        public int CanNhac1
        {
            get
            {
                return Array.IndexOf(CanNhac1Array, true) + 1;
            }
            set
            {
                for (int i = 0; i < 2; i++)
                {
                    if (i == (value - 1)) CanNhac1Array[i] = true;
                    else CanNhac1Array[i] = false;
                }
            }
        }
        public bool[] CanNhac2Array { get; } = new bool[] { false, false };
        public int CanNhac2
        {
            get
            {
                return Array.IndexOf(CanNhac2Array, true) + 1;
            }
            set
            {
                for (int i = 0; i < 2; i++)
                {
                    if (i == (value - 1)) CanNhac2Array[i] = true;
                    else CanNhac2Array[i] = false;
                }
            }
        }
        public bool[] CanNhac3Array { get; } = new bool[] { false, false };
        public int CanNhac3
        {
            get
            {
                return Array.IndexOf(CanNhac3Array, true) + 1;
            }
            set
            {
                for (int i = 0; i < 2; i++)
                {
                    if (i == (value - 1)) CanNhac3Array[i] = true;
                    else CanNhac3Array[i] = false;
                }
            }
        }
        [MoTaDuLieu("Cân nhắc can thiệp")]
        public string CanNhacCanThiep_Text { get; set; }
        public bool[] CanThiep1Array { get; } = new bool[] { false, false };
        public int CanThiep1
        {
            get
            {
                return Array.IndexOf(CanThiep1Array, true) + 1;
            }
            set
            {
                for (int i = 0; i < 2; i++)
                {
                    if (i == (value - 1)) CanThiep1Array[i] = true;
                    else CanThiep1Array[i] = false;
                }
            }
        }
        public bool[] CanThiep2Array { get; } = new bool[] { false, false };
        public int CanThiep2
        {
            get
            {
                return Array.IndexOf(CanThiep2Array, true) + 1;
            }
            set
            {
                for (int i = 0; i < 2; i++)
                {
                    if (i == (value - 1)) CanThiep2Array[i] = true;
                    else CanThiep2Array[i] = false;
                }
            }
        }
        public bool[] CanThiep3Array { get; } = new bool[] { false, false };
        public int CanThiep3
        {
            get
            {
                return Array.IndexOf(CanThiep3Array, true) + 1;
            }
            set
            {
                for (int i = 0; i < 2; i++)
                {
                    if (i == (value - 1)) CanThiep3Array[i] = true;
                    else CanThiep3Array[i] = false;
                }
            }
        }
        public bool[] CanThiep4Array { get; } = new bool[] { false, false };
        public int CanThiep4
        {
            get
            {
                return Array.IndexOf(CanThiep4Array, true) + 1;
            }
            set
            {
                for (int i = 0; i < 2; i++)
                {
                    if (i == (value - 1)) CanThiep4Array[i] = true;
                    else CanThiep4Array[i] = false;
                }
            }
        }
        public bool[] CanThiep5Array { get; } = new bool[] { false, false };
        public int CanThiep5
        {
            get
            {
                return Array.IndexOf(CanThiep5Array, true) + 1;
            }
            set
            {
                for (int i = 0; i < 2; i++)
                {
                    if (i == (value - 1)) CanThiep5Array[i] = true;
                    else CanThiep5Array[i] = false;
                }
            }
        }
        public bool[] CanThiep6Array { get; } = new bool[] { false, false };
        public int CanThiep6
        {
            get
            {
                return Array.IndexOf(CanThiep6Array, true) + 1;
            }
            set
            {
                for (int i = 0; i < 2; i++)
                {
                    if (i == (value - 1)) CanThiep6Array[i] = true;
                    else CanThiep6Array[i] = false;
                }
            }
        }
        public bool[] CanThiep7Array { get; } = new bool[] { false, false };
        public int CanThiep7
        {
            get
            {
                return Array.IndexOf(CanThiep7Array, true) + 1;
            }
            set
            {
                for (int i = 0; i < 2; i++)
                {
                    if (i == (value - 1)) CanThiep7Array[i] = true;
                    else CanThiep7Array[i] = false;
                }
            }
        }
        [MoTaDuLieu("Tình huống 1")]
        public string TinhHuong1_Text { get; set; }
        public bool[] TinhHuong1_1Array { get; } = new bool[] { false, false };
        public int TinhHuong1_1
        {
            get
            {
                return Array.IndexOf(TinhHuong1_1Array, true) + 1;
            }
            set
            {
                for (int i = 0; i < 2; i++)
                {
                    if (i == (value - 1)) TinhHuong1_1Array[i] = true;
                    else TinhHuong1_1Array[i] = false;
                }
            }
        }
        public bool[] TinhHuong1_2Array { get; } = new bool[] { false, false };
        public int TinhHuong1_2
        {
            get
            {
                return Array.IndexOf(TinhHuong1_2Array, true) + 1;
            }
            set
            {
                for (int i = 0; i < 2; i++)
                {
                    if (i == (value - 1)) TinhHuong1_2Array[i] = true;
                    else TinhHuong1_2Array[i] = false;
                }
            }
        }
        [MoTaDuLieu("Tình huống 2")]
        public string TinhHuong2_Text { get; set; }
        public bool[] TinhHuong2_1Array { get; } = new bool[] { false, false };
        public int TinhHuong2_1
        {
            get
            {
                return Array.IndexOf(TinhHuong2_1Array, true) + 1;
            }
            set
            {
                for (int i = 0; i < 2; i++)
                {
                    if (i == (value - 1)) TinhHuong2_1Array[i] = true;
                    else TinhHuong2_1Array[i] = false;
                }
            }
        }
        public bool[] TinhHuong2_2Array { get; } = new bool[] { false, false };
        public int TinhHuong2_2
        {
            get
            {
                return Array.IndexOf(TinhHuong2_2Array, true) + 1;
            }
            set
            {
                for (int i = 0; i < 2; i++)
                {
                    if (i == (value - 1)) TinhHuong2_2Array[i] = true;
                    else TinhHuong2_2Array[i] = false;
                }
            }
        }
        public bool[] TinhHuong2_3Array { get; } = new bool[] { false, false };
        public int TinhHuong2_3
        {
            get
            {
                return Array.IndexOf(TinhHuong2_3Array, true) + 1;
            }
            set
            {
                for (int i = 0; i < 2; i++)
                {
                    if (i == (value - 1)) TinhHuong2_3Array[i] = true;
                    else TinhHuong2_3Array[i] = false;
                }
            }
        }
        [MoTaDuLieu("Tình huống 3")]
        public string TinhHuong3_Text { get; set; }
        public bool[] TinhHuong3_1Array { get; } = new bool[] { false, false };
        public int TinhHuong3_1
        {
            get
            {
                return Array.IndexOf(TinhHuong3_1Array, true) + 1;
            }
            set
            {
                for (int i = 0; i < 2; i++)
                {
                    if (i == (value - 1)) TinhHuong3_1Array[i] = true;
                    else TinhHuong3_1Array[i] = false;
                }
            }
        }
        public bool[] TinhHuong3_2Array { get; } = new bool[] { false, false };
        public int TinhHuong3_2
        {
            get
            {
                return Array.IndexOf(TinhHuong3_2Array, true) + 1;
            }
            set
            {
                for (int i = 0; i < 2; i++)
                {
                    if (i == (value - 1)) TinhHuong3_2Array[i] = true;
                    else TinhHuong3_2Array[i] = false;
                }
            }
        }
        [MoTaDuLieu("Tình huống 4")]
        public string TinhHuong4_Text { get; set; }
        public bool[] TinhHuong4_1Array { get; } = new bool[] { false, false };
        public int TinhHuong4_1
        {
            get
            {
                return Array.IndexOf(TinhHuong4_1Array, true) + 1;
            }
            set
            {
                for (int i = 0; i < 2; i++)
                {
                    if (i == (value - 1)) TinhHuong4_1Array[i] = true;
                    else TinhHuong4_1Array[i] = false;
                }
            }
        }
        public bool[] TinhHuong4_2Array { get; } = new bool[] { false, false };
        public int TinhHuong4_2
        {
            get
            {
                return Array.IndexOf(TinhHuong4_2Array, true) + 1;
            }
            set
            {
                for (int i = 0; i < 2; i++)
                {
                    if (i == (value - 1)) TinhHuong4_2Array[i] = true;
                    else TinhHuong4_2Array[i] = false;
                }
            }
        }
        [MoTaDuLieu("Tình huống 5")]
        public string TinhHuong5_Text { get; set; }
        public bool[] TinhHuong5Array { get; } = new bool[] { false, false };
        public int TinhHuong5
        {
            get
            {
                return Array.IndexOf(TinhHuong5Array, true) + 1;
            }
            set
            {
                for (int i = 0; i < 2; i++)
                {
                    if (i == (value - 1)) TinhHuong5Array[i] = true;
                    else TinhHuong5Array[i] = false;
                }
            }
        }
        public bool[] NhanThanHieuArray { get; } = new bool[] { false, false };
        public int NhanThanHieu
        {
            get
            {
                return Array.IndexOf(NhanThanHieuArray, true) + 1;
            }
            set
            {
                for (int i = 0; i < 2; i++)
                {
                    if (i == (value - 1)) NhanThanHieuArray[i] = true;
                    else NhanThanHieuArray[i] = false;
                }
            }
        }
        public bool[] AlteplaseArray { get; } = new bool[] { false, false };
        public int Alteplase
        {
            get
            {
                return Array.IndexOf(AlteplaseArray, true) + 1;
            }
            set
            {
                for (int i = 0; i < 2; i++)
                {
                    if (i == (value - 1)) AlteplaseArray[i] = true;
                    else AlteplaseArray[i] = false;
                }
            }
        }
        [MoTaDuLieu("Cân nặng 1")]
        public double CanNang1 { get; set; }
        [MoTaDuLieu("Cân nặng 2")]
        public double CanNang2 { get; set; }
        [MoTaDuLieu("Mg 1")]
        public double Mg1 { get; set; }
        [MoTaDuLieu("Mg 2")]
        public double Mg2 { get; set; }
        [MoTaDuLieu("Bolus 1")]
        public double Bolus1 { get; set; }
        [MoTaDuLieu("Bolus 2")]
        public double Bolus2 { get; set; }
        public bool[] KetQuaMCTAArray { get; } = new bool[] { false, false, false, false, false };
        [MoTaDuLieu("Kết quả mCTA")]
        public string KetQuaMCTA
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < KetQuaMCTAArray.Length; i++)
                    temp += (KetQuaMCTAArray[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        KetQuaMCTAArray[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public bool[] CanThiepNoiMachArray { get; } = new bool[] { false, false };
        public int CanThiepNoiMach
        {
            get
            {
                return Array.IndexOf(CanThiepNoiMachArray, true) + 1;
            }
            set
            {
                for (int i = 0; i < 2; i++)
                {
                    if (i == (value - 1)) CanThiepNoiMachArray[i] = true;
                    else CanThiepNoiMachArray[i] = false;
                }
            }
        }
        [MoTaDuLieu("Bác sĩ ra quyết định")]
        public string BacSyRaQuyetDinh { get; set; }
        [MoTaDuLieu("Mã bác sĩ ra quyết định")]
        public string MaBacSyRaQuyetDinh { get; set; }
        #endregion
        [MoTaDuLieu("Ngày tạo", null, 0, 0)]
		public DateTime NgayTao { get; set; }
        [MoTaDuLieu("Người tạo", null, 0, 0)]
		public string NguoiTao { get; set; }
        [MoTaDuLieu("Ngày sửa", null, 0, 0)]
		public DateTime NgaySua { get; set; }
        [MoTaDuLieu("Người sửa", null, 0, 0)]
		public string NguoiSua { get; set; }
        [MoTaDuLieu("Đã ký", null, 0, 0)]
		public bool DaKy { get; set; }
        [MoTaDuLieu("Chọn", null, 0, 0)]
		public bool Chon { get; set; }
    }
    public class BangDieuTriTaiThongBacSyFunc
    {
        public const string TableName = "BangDieuTriTaiThongBacSy";
        public const string TablePrimaryKeyName = "ID";
        public static List<BangDieuTriTaiThongBacSy> GetListData(MDB.MDBConnection _OracleConnection, decimal maquanly)
        {
            List<BangDieuTriTaiThongBacSy> list = new List<BangDieuTriTaiThongBacSy>();
            try
            {
                string sql = @"SELECT * FROM BangDieuTriTaiThongBacSy where MaQuanLy = :MaQuanLy";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, _OracleConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", maquanly));
                MDB.MDBDataReader DataReader = Command.ExecuteReader();
                while (DataReader.Read())
                {
                    BangDieuTriTaiThongBacSy data = new BangDieuTriTaiThongBacSy();
                    data.ID = Convert.ToInt64(DataReader.GetLong("ID").ToString());
                    data.MaQuanLy = maquanly;
                    data.MaBenhNhan = DataReader["MaBenhNhan"].ToString();

                    double tempDouble = 0;
                    double.TryParse(DataReader["CanNang"].ToString(), out tempDouble);
                    data.CanNang = tempDouble;

                    data.ThoiDiemDenKhoacapCuu = Convert.ToDateTime(DataReader["ThoiDiemDenKhoacapCuu"] == DBNull.Value ? DateTime.Now : DataReader["ThoiDiemDenKhoacapCuu"]);
                    data.ThoiDiemPhatHienDotQuy = Convert.ToDateTime(DataReader["ThoiDiemPhatHienDotQuy"] == DBNull.Value ? DateTime.Now : DataReader["ThoiDiemPhatHienDotQuy"]);
                    data.ThoiDiemThayBinhThuong = Convert.ToDateTime(DataReader["ThoiDiemThayBinhThuong"] == DBNull.Value ? DateTime.Now : DataReader["ThoiDiemThayBinhThuong"]);
                    data.ThoiDiemBSThanKinhCoMat = Convert.ToDateTime(DataReader["ThoiDiemBSThanKinhCoMat"] == DBNull.Value ? DateTime.Now : DataReader["ThoiDiemBSThanKinhCoMat"]);
                    data.ThoiDiemChupCT = Convert.ToDateTime(DataReader["ThoiDiemChupCT"] == DBNull.Value ? DateTime.Now : DataReader["ThoiDiemChupCT"]);
                    data.ThoiDiemBolus = Convert.ToDateTime(DataReader["ThoiDiemBolus"] == DBNull.Value ? DateTime.Now : DataReader["ThoiDiemBolus"]);
                    data.ThoiDiemBSCanThiepTK = Convert.ToDateTime(DataReader["ThoiDiemBSCanThiepTK"] == DBNull.Value ? DateTime.Now : DataReader["ThoiDiemBSCanThiepTK"]);
                    data.ThoiDiemTrichDM = Convert.ToDateTime(DataReader["ThoiDiemTrichDM"] == DBNull.Value ? DateTime.Now : DataReader["ThoiDiemTrichDM"]);
                    data.ThoiDiemTaithongDauTien = Convert.ToDateTime(DataReader["ThoiDiemTaithongDauTien"] == DBNull.Value ? DateTime.Now : DataReader["ThoiDiemTaithongDauTien"]);
                    data.ThoiDiemTaiThongHoanTat = Convert.ToDateTime(DataReader["ThoiDiemTaiThongHoanTat"] == DBNull.Value ? DateTime.Now : DataReader["ThoiDiemTaiThongHoanTat"]);
                    data.BenhCanh_Text = DataReader["BenhCanh_Text"].ToString();

                    int tempInt = 0;
                    int.TryParse(DataReader["BenhCanh1"].ToString(), out tempInt);
                    data.BenhCanh1 = tempInt;
                    tempInt = 0;
                    int.TryParse(DataReader["BenhCanh2"].ToString(), out tempInt);
                    data.BenhCanh2 = tempInt;
                    tempInt = 0;
                    int.TryParse(DataReader["BenhCanh3"].ToString(), out tempInt);
                    data.BenhCanh3 = tempInt;

                    data.LamSang_Text = DataReader["LamSang_Text"].ToString();
                    data.HuyetAp = DataReader["HuyetAp"].ToString();
                    tempDouble = 0;
                    double.TryParse(DataReader["DuongHuyet"].ToString(), out tempDouble);
                    data.DuongHuyet = tempDouble;
                    tempDouble = 0;
                    double.TryParse(DataReader["TieuCau"].ToString(), out tempDouble);
                    data.TieuCau = tempDouble;

                    tempInt = 0;
                    int.TryParse(DataReader["LamSang1"].ToString(), out tempInt);
                    data.LamSang1 = tempInt;
                    tempInt = 0;
                    int.TryParse(DataReader["LamSang2"].ToString(), out tempInt);
                    data.LamSang2 = tempInt;
                    tempInt = 0;
                    int.TryParse(DataReader["LamSang3"].ToString(), out tempInt);
                    data.LamSang3 = tempInt;
                    tempInt = 0;
                    int.TryParse(DataReader["LamSang4"].ToString(), out tempInt);
                    data.LamSang4 = tempInt;

                    data.TienCan_Text = DataReader["TienCan_Text"].ToString();
                    tempInt = 0;
                    int.TryParse(DataReader["TienCan1"].ToString(), out tempInt);
                    data.TienCan1 = tempInt;
                    tempInt = 0;
                    int.TryParse(DataReader["TienCan2"].ToString(), out tempInt);
                    data.TienCan2 = tempInt;
                    tempInt = 0;
                    int.TryParse(DataReader["TienCan3"].ToString(), out tempInt);
                    data.TienCan3 = tempInt;
                    tempInt = 0;
                    int.TryParse(DataReader["TienCan4"].ToString(), out tempInt);
                    data.TienCan4 = tempInt;
                    tempInt = 0;
                    int.TryParse(DataReader["TienCan5"].ToString(), out tempInt);
                    data.TienCan5 = tempInt;
                    tempInt = 0;
                    int.TryParse(DataReader["TienCan6"].ToString(), out tempInt);
                    data.TienCan6 = tempInt;

                    data.RoiLoanDongMau_Text = DataReader["RoiLoanDongMau_Text"].ToString();
                    tempInt = 0;
                    int.TryParse(DataReader["RoiLoanDongMau1"].ToString(), out tempInt);
                    data.RoiLoanDongMau1 = tempInt;
                    tempInt = 0;
                    int.TryParse(DataReader["RoiLoanDongMau2"].ToString(), out tempInt);
                    data.RoiLoanDongMau2 = tempInt;
                    tempInt = 0;
                    int.TryParse(DataReader["RoiLoanDongMau3"].ToString(), out tempInt);
                    data.RoiLoanDongMau3 = tempInt;
                    tempInt = 0;
                    int.TryParse(DataReader["RoiLoanDongMau4"].ToString(), out tempInt);
                    data.RoiLoanDongMau4 = tempInt;
                    tempInt = 0;
                    int.TryParse(DataReader["RoiLoanDongMau5"].ToString(), out tempInt);
                    data.RoiLoanDongMau5 = tempInt;

                    data.HinhAnhHoc = DataReader["HinhAnhHoc"].ToString();
                    tempInt = 0;
                    int.TryParse(DataReader["KetQuaCT1"].ToString(), out tempInt);
                    data.KetQuaCT1 = tempInt;
                    tempInt = 0;
                    int.TryParse(DataReader["KetQuaCT2"].ToString(), out tempInt);
                    data.KetQuaCT2 = tempInt;


                    data.ChongChiDinhRieng_Text = DataReader["ChongChiDinhRieng_Text"].ToString();
                    tempInt = 0;
                    int.TryParse(DataReader["ChongChiDinhRieng1"].ToString(), out tempInt);
                    data.ChongChiDinhRieng1 = tempInt;
                    tempInt = 0;
                    int.TryParse(DataReader["ChongChiDinhRieng2"].ToString(), out tempInt);
                    data.ChongChiDinhRieng2 = tempInt;
                    tempInt = 0;
                    int.TryParse(DataReader["ChongChiDinhRieng3"].ToString(), out tempInt);
                    data.ChongChiDinhRieng3 = tempInt;
                    tempInt = 0;
                    int.TryParse(DataReader["ChongChiDinhRieng4"].ToString(), out tempInt);
                    data.ChongChiDinhRieng4 = tempInt;

                    data.ChongTriDinhTuongDoi_Text = DataReader["ChongTriDinhTuongDoi_Text"].ToString();
                    tempInt = 0;
                    int.TryParse(DataReader["ChongTriDinhTuongDoi1"].ToString(), out tempInt);
                    data.ChongTriDinhTuongDoi1 = tempInt;
                    tempInt = 0;
                    int.TryParse(DataReader["ChongTriDinhTuongDoi2"].ToString(), out tempInt);
                    data.ChongTriDinhTuongDoi2 = tempInt;
                    tempInt = 0;
                    int.TryParse(DataReader["ChongTriDinhTuongDoi3"].ToString(), out tempInt);
                    data.ChongTriDinhTuongDoi3 = tempInt;
                    tempInt = 0;
                    int.TryParse(DataReader["ChongTriDinhTuongDoi4"].ToString(), out tempInt);
                    data.ChongTriDinhTuongDoi4 = tempInt;
                    tempInt = 0;
                    int.TryParse(DataReader["ChongTriDinhTuongDoi5"].ToString(), out tempInt);
                    data.ChongTriDinhTuongDoi5 = tempInt;
                    tempInt = 0;
                    int.TryParse(DataReader["ChongTriDinhTuongDoi6"].ToString(), out tempInt);
                    data.ChongTriDinhTuongDoi6 = tempInt;
                    tempInt = 0;
                    int.TryParse(DataReader["ChongTriDinhTuongDoi7"].ToString(), out tempInt);
                    data.ChongTriDinhTuongDoi7 = tempInt;

                    data.CanNhacDieuTri_Text = DataReader["CanNhacDieuTri_Text"].ToString();
                    tempInt = 0;
                    int.TryParse(DataReader["CanNhac1"].ToString(), out tempInt);
                    data.CanNhac1 = tempInt;
                    tempInt = 0;
                    int.TryParse(DataReader["CanNhac2"].ToString(), out tempInt);
                    data.CanNhac2 = tempInt;
                    tempInt = 0;
                    int.TryParse(DataReader["CanNhac3"].ToString(), out tempInt);
                    data.CanNhac3 = tempInt;

                    data.CanNhacCanThiep_Text = DataReader["CanNhacCanThiep_Text"].ToString();
                    tempInt = 0;
                    int.TryParse(DataReader["CanThiep1"].ToString(), out tempInt);
                    data.CanThiep1 = tempInt;
                    tempInt = 0;
                    int.TryParse(DataReader["CanThiep2"].ToString(), out tempInt);
                    data.CanThiep2 = tempInt;
                    tempInt = 0;
                    int.TryParse(DataReader["CanThiep3"].ToString(), out tempInt);
                    data.CanThiep3 = tempInt;
                    tempInt = 0;
                    int.TryParse(DataReader["CanThiep4"].ToString(), out tempInt);
                    data.CanThiep4 = tempInt;
                    tempInt = 0;
                    int.TryParse(DataReader["CanThiep5"].ToString(), out tempInt);
                    data.CanThiep5 = tempInt;
                    tempInt = 0;
                    int.TryParse(DataReader["CanThiep6"].ToString(), out tempInt);
                    data.CanThiep6 = tempInt;
                    tempInt = 0;
                    int.TryParse(DataReader["CanThiep7"].ToString(), out tempInt);
                    data.CanThiep7 = tempInt;

                    data.TinhHuong1_Text = DataReader["TinhHuong1_Text"].ToString();
                    tempInt = 0;
                    int.TryParse(DataReader["TinhHuong1_1"].ToString(), out tempInt);
                    data.TinhHuong1_1 = tempInt;
                    tempInt = 0;
                    int.TryParse(DataReader["TinhHuong1_2"].ToString(), out tempInt);
                    data.TinhHuong1_2 = tempInt;

                    data.TinhHuong2_Text = DataReader["TinhHuong2_Text"].ToString();
                    tempInt = 0;
                    int.TryParse(DataReader["TinhHuong2_1"].ToString(), out tempInt);
                    data.TinhHuong2_1 = tempInt;
                    tempInt = 0;
                    int.TryParse(DataReader["TinhHuong2_2"].ToString(), out tempInt);
                    data.TinhHuong2_2 = tempInt;
                    tempInt = 0;
                    int.TryParse(DataReader["TinhHuong2_3"].ToString(), out tempInt);
                    data.TinhHuong2_3 = tempInt;

                    data.TinhHuong3_Text = DataReader["TinhHuong3_Text"].ToString();
                    tempInt = 0;
                    int.TryParse(DataReader["TinhHuong3_1"].ToString(), out tempInt);
                    data.TinhHuong3_1 = tempInt;
                    tempInt = 0;
                    int.TryParse(DataReader["TinhHuong3_2"].ToString(), out tempInt);
                    data.TinhHuong3_2 = tempInt;

                    data.TinhHuong4_Text = DataReader["TinhHuong4_Text"].ToString();
                    tempInt = 0;
                    int.TryParse(DataReader["TinhHuong4_1"].ToString(), out tempInt);
                    data.TinhHuong4_1 = tempInt;
                    tempInt = 0;
                    int.TryParse(DataReader["TinhHuong4_2"].ToString(), out tempInt);
                    data.TinhHuong4_2 = tempInt;

                    data.TinhHuong5_Text = DataReader["TinhHuong5_Text"].ToString();
                    tempInt = 0;
                    int.TryParse(DataReader["TinhHuong5"].ToString(), out tempInt);
                    data.TinhHuong5 = tempInt;

                    tempInt = 0;
                    int.TryParse(DataReader["NhanThanHieu"].ToString(), out tempInt);
                    data.NhanThanHieu = tempInt;

                    tempInt = 0;
                    int.TryParse(DataReader["Alteplase"].ToString(), out tempInt);
                    data.Alteplase = tempInt;

                    tempDouble = 0;
                    double.TryParse(DataReader["CanNang1"].ToString(), out tempDouble);
                    data.CanNang1 = tempDouble;
                    tempDouble = 0;
                    double.TryParse(DataReader["CanNang2"].ToString(), out tempDouble);
                    data.CanNang2 = tempDouble;
                    tempDouble = 0;
                    double.TryParse(DataReader["Mg1"].ToString(), out tempDouble);
                    data.Mg1 = tempDouble;
                    tempDouble = 0;
                    double.TryParse(DataReader["Mg2"].ToString(), out tempDouble);
                    data.Mg2 = tempDouble;
                    tempDouble = 0;
                    double.TryParse(DataReader["Bolus1"].ToString(), out tempDouble);
                    data.Bolus1 = tempDouble;
                    tempDouble = 0;
                    double.TryParse(DataReader["Bolus2"].ToString(), out tempDouble);
                    data.Bolus2 = tempDouble;

                    data.KetQuaMCTA = DataReader["KetQuaMCTA"].ToString();

                    tempInt = 0;
                    int.TryParse(DataReader["CanThiepNoiMach"].ToString(), out tempInt);
                    data.CanThiepNoiMach = tempInt;

                    data.BacSyRaQuyetDinh = DataReader["BacSyRaQuyetDinh"].ToString();
                    data.MaBacSyRaQuyetDinh = DataReader["MaBacSyRaQuyetDinh"].ToString();

                    data.NgayTao = Convert.ToDateTime(DataReader["NgayTao"] == DBNull.Value ? DateTime.Now : DataReader["NgayTao"]);
                    data.NguoiTao = DataReader["NguoiTao"].ToString();
                    data.NgaySua = Convert.ToDateTime(DataReader["NgaySua"] == DBNull.Value ? DateTime.Now : DataReader["NgaySua"]);
                    data.NguoiSua = DataReader["NguoiSua"].ToString();

                    data.MaSoKy = DataReader["masokyten"].ToString();
                    data.DaKy = !string.IsNullOrEmpty(data.MaSoKy) ? true : false;
                    list.Add(data);
                }
            }
            catch (Exception ex) { XuLyLoi.Handle(ex); }
            return list;
        }
        public static bool InsertOrUpdate(MDB.MDBConnection MyConnection, ref BangDieuTriTaiThongBacSy bangDieuTri)
        {
            try
            {
                string sql = @"INSERT INTO BangDieuTriTaiThongBacSy
                (
                    MaQuanLy,
	                MaBenhNhan,
	                CanNang,
	                ThoiDiemDenKhoacapCuu,
	                ThoiDiemPhatHienDotQuy,
	                ThoiDiemThayBinhThuong,
	                ThoiDiemBSThanKinhCoMat,
	                ThoiDiemChupCT,
	                ThoiDiemBolus,
	                ThoiDiemBSCanThiepTK,
	                ThoiDiemTrichDM,
	                ThoiDiemTaithongDauTien,
	                ThoiDiemTaiThongHoanTat,
	                BenhCanh_Text,
	                BenhCanh1,
	                BenhCanh2,
	                BenhCanh3,
	                LamSang_Text,
	                HuyetAp,
	                DuongHuyet,
	                TieuCau,
	                LamSang1,	
	                LamSang2,	
	                LamSang3,	
	                LamSang4,
	                TienCan_Text,
	                TienCan1,
	                TienCan2,
	                TienCan3,
	                TienCan4,
	                TienCan5,
	                TienCan6,
	                RoiLoanDongMau_Text,
	                RoiLoanDongMau1,
	                RoiLoanDongMau2,
	                RoiLoanDongMau3,
	                RoiLoanDongMau4,
	                RoiLoanDongMau5,
	                HinhAnhHoc,
	                KetQuaCT1,
	                KetQuaCT2,
	                ChongChiDinhRieng_Text,
	                ChongChiDinhRieng1,
	                ChongChiDinhRieng2,
	                ChongChiDinhRieng3,
	                ChongChiDinhRieng4,
	                ChongTriDinhTuongDoi_Text,
	                ChongTriDinhTuongDoi1,
	                ChongTriDinhTuongDoi2,
	                ChongTriDinhTuongDoi3,
	                ChongTriDinhTuongDoi4,
	                ChongTriDinhTuongDoi5,
	                ChongTriDinhTuongDoi6,
	                ChongTriDinhTuongDoi7,
	                CanNhacDieuTri_Text,
	                CanNhac1,
	                CanNhac2,
	                CanNhac3,
	                CanNhacCanThiep_Text,
	                CanThiep1,
	                CanThiep2,
	                CanThiep3,
	                CanThiep4,
	                CanThiep5,
	                CanThiep6,
	                CanThiep7,
	                TinhHuong1_Text,
	                TinhHuong1_1,
	                TinhHuong1_2,
	                TinhHuong2_Text,
	                TinhHuong2_1,
	                TinhHuong2_2,
	                TinhHuong2_3,
	                TinhHuong3_Text,
	                TinhHuong3_1,
	                TinhHuong3_2,
	                TinhHuong4_Text,
	                TinhHuong4_1,
	                TinhHuong4_2,
	                TinhHuong5_Text,
	                TinhHuong5,
	                NhanThanHieu,
	                Alteplase,
	                CanNang1,
	                CanNang2,
	                Mg1,
	                Mg2,
	                Bolus1,
	                Bolus2,
	                KetQuaMCTA, 
	                CanThiepNoiMach,
	                BacSyRaQuyetDinh, 
	                MaBacSyRaQuyetDinh,
                    NGUOITAO,
                    NGUOISUA,
                    NGAYTAO,
                    NGAYSUA)  VALUES
                 (
				    :MaQuanLy,
	                :MaBenhNhan,
	                :CanNang,
	                :ThoiDiemDenKhoacapCuu,
	                :ThoiDiemPhatHienDotQuy,
	                :ThoiDiemThayBinhThuong,
	                :ThoiDiemBSThanKinhCoMat,
	                :ThoiDiemChupCT,
	                :ThoiDiemBolus,
	                :ThoiDiemBSCanThiepTK,
	                :ThoiDiemTrichDM,
	                :ThoiDiemTaithongDauTien,
	                :ThoiDiemTaiThongHoanTat,
	                :BenhCanh_Text,
	                :BenhCanh1,
	                :BenhCanh2,
	                :BenhCanh3,
	                :LamSang_Text,
	                :HuyetAp,
	                :DuongHuyet,
	                :TieuCau,
	                :LamSang1,	
	                :LamSang2,	
	                :LamSang3,	
	                :LamSang4,
	                :TienCan_Text,
	                :TienCan1,
	                :TienCan2,
	                :TienCan3,
	                :TienCan4,
	                :TienCan5,
	                :TienCan6,
	                :RoiLoanDongMau_Text,
	                :RoiLoanDongMau1,
	                :RoiLoanDongMau2,
	                :RoiLoanDongMau3,
	                :RoiLoanDongMau4,
	                :RoiLoanDongMau5,
	                :HinhAnhHoc,
	                :KetQuaCT1,
	                :KetQuaCT2,
	                :ChongChiDinhRieng_Text,
	                :ChongChiDinhRieng1,
	                :ChongChiDinhRieng2,
	                :ChongChiDinhRieng3,
	                :ChongChiDinhRieng4,
	                :ChongTriDinhTuongDoi_Text,
	                :ChongTriDinhTuongDoi1,
	                :ChongTriDinhTuongDoi2,
	                :ChongTriDinhTuongDoi3,
	                :ChongTriDinhTuongDoi4,
	                :ChongTriDinhTuongDoi5,
	                :ChongTriDinhTuongDoi6,
	                :ChongTriDinhTuongDoi7,
	                :CanNhacDieuTri_Text,
	                :CanNhac1,
	                :CanNhac2,
	                :CanNhac3,
	                :CanNhacCanThiep_Text,
	                :CanThiep1,
	                :CanThiep2,
	                :CanThiep3,
	                :CanThiep4,
	                :CanThiep5,
	                :CanThiep6,
	                :CanThiep7,
	                :TinhHuong1_Text,
	                :TinhHuong1_1,
	                :TinhHuong1_2,
	                :TinhHuong2_Text,
	                :TinhHuong2_1,
	                :TinhHuong2_2,
	                :TinhHuong2_3,
	                :TinhHuong3_Text,
	                :TinhHuong3_1,
	                :TinhHuong3_2,
	                :TinhHuong4_Text,
	                :TinhHuong4_1,
	                :TinhHuong4_2,
	                :TinhHuong5_Text,
	                :TinhHuong5,
	                :NhanThanHieu,
	                :Alteplase,
	                :CanNang1,
	                :CanNang2,
	                :Mg1,
	                :Mg2,
	                :Bolus1,
	                :Bolus2,
	                :KetQuaMCTA, 
	                :CanThiepNoiMach,
	                :BacSyRaQuyetDinh, 
	                :MaBacSyRaQuyetDinh,
                    :NGUOITAO,
                    :NGUOISUA,
                    :NGAYTAO,
                    :NGAYSUA
                 )  RETURNING ID INTO :ID";
                if (bangDieuTri.ID != 0)
                {
                    sql = @"UPDATE BangDieuTriTaiThongBacSy SET 
                    MaQuanLy = :MaQuanLy,
	                MaBenhNhan = :MaBenhNhan,
	                CanNang = :CanNang,
	                ThoiDiemDenKhoacapCuu = :ThoiDiemDenKhoacapCuu,
	                ThoiDiemPhatHienDotQuy = :ThoiDiemPhatHienDotQuy,
	                ThoiDiemThayBinhThuong = :ThoiDiemThayBinhThuong,
	                ThoiDiemBSThanKinhCoMat = :ThoiDiemBSThanKinhCoMat,
	                ThoiDiemChupCT = :ThoiDiemChupCT,
	                ThoiDiemBolus = :ThoiDiemBolus,
	                ThoiDiemBSCanThiepTK = :ThoiDiemBSCanThiepTK,
	                ThoiDiemTrichDM = :ThoiDiemTrichDM,
	                ThoiDiemTaithongDauTien = :ThoiDiemTaithongDauTien,
	                ThoiDiemTaiThongHoanTat = :ThoiDiemTaiThongHoanTat,
	                BenhCanh_Text = :BenhCanh_Text,
	                BenhCanh1 = :BenhCanh1,
	                BenhCanh2 = :BenhCanh2,
	                BenhCanh3 = :BenhCanh3,
	                LamSang_Text = :LamSang_Text,
	                HuyetAp = :HuyetAp,
	                DuongHuyet = :DuongHuyet,
	                TieuCau = :TieuCau,
	                LamSang1 = :LamSang1,	
	                LamSang2 = :LamSang2,	
	                LamSang3 = :LamSang3,	
	                LamSang4 = :LamSang4,
	                TienCan_Text = :TienCan_Text,
	                TienCan1 = :TienCan1,
	                TienCan2 = :TienCan2,
	                TienCan3 = :TienCan3,
	                TienCan4 = :TienCan4,
	                TienCan5 = :TienCan5,
	                TienCan6 = :TienCan6,
	                RoiLoanDongMau_Text = :RoiLoanDongMau_Text,
	                RoiLoanDongMau1 = :RoiLoanDongMau1,
	                RoiLoanDongMau2 = :RoiLoanDongMau2,
	                RoiLoanDongMau3 = :RoiLoanDongMau3,
	                RoiLoanDongMau4 = :RoiLoanDongMau4,
	                RoiLoanDongMau5 = :RoiLoanDongMau5,
	                HinhAnhHoc = :HinhAnhHoc,
	                KetQuaCT1 = :KetQuaCT1,
	                KetQuaCT2 = :KetQuaCT2,
	                ChongChiDinhRieng_Text = :ChongChiDinhRieng_Text,
	                ChongChiDinhRieng1 = :ChongChiDinhRieng1,
	                ChongChiDinhRieng2 = :ChongChiDinhRieng2,
	                ChongChiDinhRieng3 = :ChongChiDinhRieng3,
	                ChongChiDinhRieng4 = :ChongChiDinhRieng4,
	                ChongTriDinhTuongDoi_Text = :ChongTriDinhTuongDoi_Text,
	                ChongTriDinhTuongDoi1 = :ChongTriDinhTuongDoi1,
	                ChongTriDinhTuongDoi2 = :ChongTriDinhTuongDoi2,
	                ChongTriDinhTuongDoi3 = :ChongTriDinhTuongDoi3,
	                ChongTriDinhTuongDoi4 = :ChongTriDinhTuongDoi4,
	                ChongTriDinhTuongDoi5 = :ChongTriDinhTuongDoi5,
	                ChongTriDinhTuongDoi6 = :ChongTriDinhTuongDoi6,
	                ChongTriDinhTuongDoi7 = :ChongTriDinhTuongDoi7,
	                CanNhacDieuTri_Text = :CanNhacDieuTri_Text,
	                CanNhac1 = :CanNhac1,
	                CanNhac2 = :CanNhac2,
	                CanNhac3 = :CanNhac3,
	                CanNhacCanThiep_Text = :CanNhacCanThiep_Text,
	                CanThiep1 = :CanThiep1,
	                CanThiep2 = :CanThiep2,
	                CanThiep3 = :CanThiep3,
	                CanThiep4 = :CanThiep4,
	                CanThiep5 = :CanThiep5,
	                CanThiep6 = :CanThiep6,
	                CanThiep7 = :CanThiep7,
	                TinhHuong1_Text = :TinhHuong1_Text,
	                TinhHuong1_1 = :TinhHuong1_1,
	                TinhHuong1_2 = :TinhHuong1_2,
	                TinhHuong2_Text = :TinhHuong2_Text,
	                TinhHuong2_1 = :TinhHuong2_1,
	                TinhHuong2_2 = :TinhHuong2_2,
	                TinhHuong2_3 = :TinhHuong2_3,
	                TinhHuong3_Text = :TinhHuong3_Text,
	                TinhHuong3_1 = :TinhHuong3_1,
	                TinhHuong3_2 = :TinhHuong3_2,
	                TinhHuong4_Text = :TinhHuong4_Text,
	                TinhHuong4_1 = :TinhHuong4_1,
	                TinhHuong4_2 = :TinhHuong4_2,
	                TinhHuong5_Text = :TinhHuong5_Text,
	                TinhHuong5 = :TinhHuong5,
	                NhanThanHieu = :NhanThanHieu,
	                Alteplase = :Alteplase,
	                CanNang1 = :CanNang1,
	                CanNang2 = :CanNang2,
	                Mg1 = :Mg1,
	                Mg2 = :Mg2,
	                Bolus1 = :Bolus1,
	                Bolus2 = :Bolus2,
	                KetQuaMCTA = :KetQuaMCTA, 
	                CanThiepNoiMach = :CanThiepNoiMach,
	                BacSyRaQuyetDinh = :BacSyRaQuyetDinh, 
	                MaBacSyRaQuyetDinh = :MaBacSyRaQuyetDinh,
                    NGUOISUA = :NGUOISUA,
                    NGAYSUA = :NGAYSUA
                    WHERE ID = " + bangDieuTri.ID;
                }
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", bangDieuTri.MaQuanLy));
                Command.Parameters.Add(new MDB.MDBParameter("MaBenhNhan", bangDieuTri.MaBenhNhan));
                Command.Parameters.Add(new MDB.MDBParameter("CanNang", bangDieuTri.CanNang));
                Command.Parameters.Add(new MDB.MDBParameter("ThoiDiemDenKhoacapCuu", bangDieuTri.ThoiDiemDenKhoacapCuu));
                Command.Parameters.Add(new MDB.MDBParameter("ThoiDiemPhatHienDotQuy", bangDieuTri.ThoiDiemPhatHienDotQuy));
                Command.Parameters.Add(new MDB.MDBParameter("ThoiDiemThayBinhThuong", bangDieuTri.ThoiDiemThayBinhThuong));
                Command.Parameters.Add(new MDB.MDBParameter("ThoiDiemBSThanKinhCoMat", bangDieuTri.ThoiDiemBSThanKinhCoMat));
                Command.Parameters.Add(new MDB.MDBParameter("ThoiDiemChupCT", bangDieuTri.ThoiDiemChupCT));
                Command.Parameters.Add(new MDB.MDBParameter("ThoiDiemBolus", bangDieuTri.ThoiDiemBolus));
                Command.Parameters.Add(new MDB.MDBParameter("ThoiDiemBSCanThiepTK", bangDieuTri.ThoiDiemBSCanThiepTK));
                Command.Parameters.Add(new MDB.MDBParameter("ThoiDiemTrichDM", bangDieuTri.ThoiDiemTrichDM));
                Command.Parameters.Add(new MDB.MDBParameter("ThoiDiemTaithongDauTien", bangDieuTri.ThoiDiemTaithongDauTien));
                Command.Parameters.Add(new MDB.MDBParameter("ThoiDiemTaiThongHoanTat", bangDieuTri.ThoiDiemTaiThongHoanTat));
                Command.Parameters.Add(new MDB.MDBParameter("BenhCanh_Text", bangDieuTri.BenhCanh_Text));
                Command.Parameters.Add(new MDB.MDBParameter("BenhCanh1", bangDieuTri.BenhCanh1));
                Command.Parameters.Add(new MDB.MDBParameter("BenhCanh2", bangDieuTri.BenhCanh2));
                Command.Parameters.Add(new MDB.MDBParameter("BenhCanh3", bangDieuTri.BenhCanh3));
                Command.Parameters.Add(new MDB.MDBParameter("LamSang_Text", bangDieuTri.LamSang_Text));
                Command.Parameters.Add(new MDB.MDBParameter("HuyetAp", bangDieuTri.HuyetAp));
                Command.Parameters.Add(new MDB.MDBParameter("DuongHuyet", bangDieuTri.DuongHuyet));
                Command.Parameters.Add(new MDB.MDBParameter("TieuCau", bangDieuTri.TieuCau));
                Command.Parameters.Add(new MDB.MDBParameter("LamSang1", bangDieuTri.LamSang1));
                Command.Parameters.Add(new MDB.MDBParameter("LamSang2", bangDieuTri.LamSang2));
                Command.Parameters.Add(new MDB.MDBParameter("LamSang3", bangDieuTri.LamSang3));
                Command.Parameters.Add(new MDB.MDBParameter("LamSang4", bangDieuTri.LamSang4));
                Command.Parameters.Add(new MDB.MDBParameter("TienCan_Text", bangDieuTri.TienCan_Text));
                Command.Parameters.Add(new MDB.MDBParameter("TienCan1", bangDieuTri.TienCan1));
                Command.Parameters.Add(new MDB.MDBParameter("TienCan2", bangDieuTri.TienCan2));
                Command.Parameters.Add(new MDB.MDBParameter("TienCan3", bangDieuTri.TienCan3));
                Command.Parameters.Add(new MDB.MDBParameter("TienCan4", bangDieuTri.TienCan4));
                Command.Parameters.Add(new MDB.MDBParameter("TienCan5", bangDieuTri.TienCan5));
                Command.Parameters.Add(new MDB.MDBParameter("TienCan6", bangDieuTri.TienCan6));
                Command.Parameters.Add(new MDB.MDBParameter("RoiLoanDongMau_Text", bangDieuTri.RoiLoanDongMau_Text));
                Command.Parameters.Add(new MDB.MDBParameter("RoiLoanDongMau1", bangDieuTri.RoiLoanDongMau1));
                Command.Parameters.Add(new MDB.MDBParameter("RoiLoanDongMau2", bangDieuTri.RoiLoanDongMau2));
                Command.Parameters.Add(new MDB.MDBParameter("RoiLoanDongMau3", bangDieuTri.RoiLoanDongMau3));
                Command.Parameters.Add(new MDB.MDBParameter("RoiLoanDongMau4", bangDieuTri.RoiLoanDongMau4));
                Command.Parameters.Add(new MDB.MDBParameter("RoiLoanDongMau5", bangDieuTri.RoiLoanDongMau5));
                Command.Parameters.Add(new MDB.MDBParameter("HinhAnhHoc", bangDieuTri.HinhAnhHoc));
                Command.Parameters.Add(new MDB.MDBParameter("KetQuaCT1", bangDieuTri.KetQuaCT1));
                Command.Parameters.Add(new MDB.MDBParameter("KetQuaCT2", bangDieuTri.KetQuaCT2));
                Command.Parameters.Add(new MDB.MDBParameter("ChongChiDinhRieng_Text", bangDieuTri.ChongChiDinhRieng_Text));
                Command.Parameters.Add(new MDB.MDBParameter("ChongChiDinhRieng1", bangDieuTri.ChongChiDinhRieng1));
                Command.Parameters.Add(new MDB.MDBParameter("ChongChiDinhRieng2", bangDieuTri.ChongChiDinhRieng2));
                Command.Parameters.Add(new MDB.MDBParameter("ChongChiDinhRieng3", bangDieuTri.ChongChiDinhRieng3));
                Command.Parameters.Add(new MDB.MDBParameter("ChongChiDinhRieng4", bangDieuTri.ChongChiDinhRieng4));
                Command.Parameters.Add(new MDB.MDBParameter("ChongTriDinhTuongDoi_Text", bangDieuTri.ChongTriDinhTuongDoi_Text));
                Command.Parameters.Add(new MDB.MDBParameter("ChongTriDinhTuongDoi1", bangDieuTri.ChongTriDinhTuongDoi1));
                Command.Parameters.Add(new MDB.MDBParameter("ChongTriDinhTuongDoi2", bangDieuTri.ChongTriDinhTuongDoi2));
                Command.Parameters.Add(new MDB.MDBParameter("ChongTriDinhTuongDoi3", bangDieuTri.ChongTriDinhTuongDoi3));
                Command.Parameters.Add(new MDB.MDBParameter("ChongTriDinhTuongDoi4", bangDieuTri.ChongTriDinhTuongDoi4));
                Command.Parameters.Add(new MDB.MDBParameter("ChongTriDinhTuongDoi5", bangDieuTri.ChongTriDinhTuongDoi5));
                Command.Parameters.Add(new MDB.MDBParameter("ChongTriDinhTuongDoi6", bangDieuTri.ChongTriDinhTuongDoi6));
                Command.Parameters.Add(new MDB.MDBParameter("ChongTriDinhTuongDoi7", bangDieuTri.ChongTriDinhTuongDoi7));
                Command.Parameters.Add(new MDB.MDBParameter("CanNhacDieuTri_Text", bangDieuTri.CanNhacDieuTri_Text));
                Command.Parameters.Add(new MDB.MDBParameter("CanNhac1", bangDieuTri.CanNhac1));
                Command.Parameters.Add(new MDB.MDBParameter("CanNhac2", bangDieuTri.CanNhac2));
                Command.Parameters.Add(new MDB.MDBParameter("CanNhac3", bangDieuTri.CanNhac3));
                Command.Parameters.Add(new MDB.MDBParameter("CanNhacCanThiep_Text", bangDieuTri.CanNhacCanThiep_Text));
                Command.Parameters.Add(new MDB.MDBParameter("CanThiep1", bangDieuTri.CanThiep1));
                Command.Parameters.Add(new MDB.MDBParameter("CanThiep2", bangDieuTri.CanThiep2));
                Command.Parameters.Add(new MDB.MDBParameter("CanThiep3", bangDieuTri.CanThiep3));
                Command.Parameters.Add(new MDB.MDBParameter("CanThiep4", bangDieuTri.CanThiep4));
                Command.Parameters.Add(new MDB.MDBParameter("CanThiep5", bangDieuTri.CanThiep5));
                Command.Parameters.Add(new MDB.MDBParameter("CanThiep6", bangDieuTri.CanThiep6));
                Command.Parameters.Add(new MDB.MDBParameter("CanThiep7", bangDieuTri.CanThiep7));
                Command.Parameters.Add(new MDB.MDBParameter("TinhHuong1_Text", bangDieuTri.TinhHuong1_Text));
                Command.Parameters.Add(new MDB.MDBParameter("TinhHuong1_1", bangDieuTri.TinhHuong1_1));
                Command.Parameters.Add(new MDB.MDBParameter("TinhHuong1_2", bangDieuTri.TinhHuong1_2));
                Command.Parameters.Add(new MDB.MDBParameter("TinhHuong2_Text", bangDieuTri.TinhHuong2_Text));
                Command.Parameters.Add(new MDB.MDBParameter("TinhHuong2_1", bangDieuTri.TinhHuong2_1));
                Command.Parameters.Add(new MDB.MDBParameter("TinhHuong2_2", bangDieuTri.TinhHuong2_2));
                Command.Parameters.Add(new MDB.MDBParameter("TinhHuong2_3", bangDieuTri.TinhHuong2_3));
                Command.Parameters.Add(new MDB.MDBParameter("TinhHuong3_Text", bangDieuTri.TinhHuong3_Text));
                Command.Parameters.Add(new MDB.MDBParameter("TinhHuong3_1", bangDieuTri.TinhHuong3_1));
                Command.Parameters.Add(new MDB.MDBParameter("TinhHuong3_2", bangDieuTri.TinhHuong3_2));
                Command.Parameters.Add(new MDB.MDBParameter("TinhHuong4_Text", bangDieuTri.TinhHuong4_Text));
                Command.Parameters.Add(new MDB.MDBParameter("TinhHuong4_1", bangDieuTri.TinhHuong4_1));
                Command.Parameters.Add(new MDB.MDBParameter("TinhHuong4_2", bangDieuTri.TinhHuong4_2));
                Command.Parameters.Add(new MDB.MDBParameter("TinhHuong5_Text", bangDieuTri.TinhHuong5_Text));
                Command.Parameters.Add(new MDB.MDBParameter("TinhHuong5", bangDieuTri.TinhHuong5));
                Command.Parameters.Add(new MDB.MDBParameter("NhanThanHieu", bangDieuTri.NhanThanHieu));
                Command.Parameters.Add(new MDB.MDBParameter("Alteplase", bangDieuTri.Alteplase));
                Command.Parameters.Add(new MDB.MDBParameter("CanNang1", bangDieuTri.CanNang1));
                Command.Parameters.Add(new MDB.MDBParameter("CanNang2", bangDieuTri.CanNang2));
                Command.Parameters.Add(new MDB.MDBParameter("Mg1", bangDieuTri.Mg1));
                Command.Parameters.Add(new MDB.MDBParameter("Mg2", bangDieuTri.Mg2));
                Command.Parameters.Add(new MDB.MDBParameter("Bolus1", bangDieuTri.Bolus1));
                Command.Parameters.Add(new MDB.MDBParameter("Bolus2", bangDieuTri.Bolus2));
                Command.Parameters.Add(new MDB.MDBParameter("KetQuaMCTA", bangDieuTri.KetQuaMCTA));
                Command.Parameters.Add(new MDB.MDBParameter("CanThiepNoiMach", bangDieuTri.CanThiepNoiMach));
                Command.Parameters.Add(new MDB.MDBParameter("BacSyRaQuyetDinh", bangDieuTri.BacSyRaQuyetDinh));
                Command.Parameters.Add(new MDB.MDBParameter("MaBacSyRaQuyetDinh", bangDieuTri.MaBacSyRaQuyetDinh));
                Command.Parameters.Add(new MDB.MDBParameter("NGUOISUA", bangDieuTri.NguoiSua));
                Command.Parameters.Add(new MDB.MDBParameter("NGAYSUA", bangDieuTri.NgaySua));
                if (bangDieuTri.ID == 0)
                {
                    Command.Parameters.Add(new MDB.MDBParameter("ID", bangDieuTri.ID));
                    Command.Parameters.Add(new MDB.MDBParameter("NGUOITAO", bangDieuTri.NguoiTao));
                    Command.Parameters.Add(new MDB.MDBParameter("NGAYTAO", bangDieuTri.NgayTao));
                }
                Command.BindByName = true;
                int n = Command.ExecuteNonQuery();
                if (bangDieuTri.ID == 0)
                {
                    long nextval = Convert.ToInt64((Command.Parameters["ID"] as MDB.MDBParameter).Value);
                    bangDieuTri.ID = nextval;
                }
                return n > 0 ? true : false;
            }
            catch (Exception ex)
            {
                XuLyLoi.Handle(ex);
            }
            return false;
        }
        public static bool delete(MDB.MDBConnection MyConnection, long id)
        {
            try
            {
                string sql = "DELETE FROM BangDieuTriTaiThongBacSy WHERE ID = :ID";
                MDB.MDBCommand command = new MDB.MDBCommand(sql, MyConnection);
                command.Parameters.Add(new MDB.MDBParameter("ID", id));
                command.BindByName = true;
                int n = command.ExecuteNonQuery();
                return n > 0 ? true : false;
            }
            catch (Exception ex)
            {
                XuLyLoi.Handle(ex);
            }
            return false;
        }
        public static DataSet getDataSet(MDB.MDBConnection MyConnection, long id)
        {
            string sql = @"SELECT
                B.*,
                T.MABENHAN,
                H.GIOITINH,
                H.NGAYSINH,
	            H.TENBENHNHAN,
                H.TUOI
            FROM
                BangDieuTriTaiThongBacSy B
                LEFT JOIN THONGTINDIEUTRI T ON B.MAQUANLY = T.MAQUANLY
                LEFT JOIN HANHCHINHBENHNHAN H ON B.MABENHNHAN = H.MABENHNHAN
            WHERE
                ID = " + id;

            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);

            MDB.MDBDataAdapter adt = new MDB.MDBDataAdapter(Command);
            var ds = new DataSet();

            adt.Fill(ds, "BK");

            /*DataTable thongTinVien = new DataTable("HEADER");

            thongTinVien.Columns.Add("BENHVIEN");
            thongTinVien.Columns.Add("KHOA");
			if (XemBenhAn._HanhChinhBenhNhan == null) XemBenhAn._HanhChinhBenhNhan = new HanhChinhBenhNhan();
            if (XemBenhAn._ThongTinDieuTri == null) XemBenhAn._ThongTinDieuTri = new ThongTinDieuTri();
            thongTinVien.Rows.Add(XemBenhAn._HanhChinhBenhNhan.BenhVien, XemBenhAn._ThongTinDieuTri.Khoa);
            ds.Tables.Add(thongTinVien);*/

            return ds;
        }
    }
}
