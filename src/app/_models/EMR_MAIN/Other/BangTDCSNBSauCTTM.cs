using EMR.KyDienTu;
using PMS.Access;
using System;
using System.Collections.Generic;
using System.Data;

namespace EMR_MAIN.DATABASE.Other
{
    public class BangTDCSNBSauCTTM : ThongTinKy
    {
        public BangTDCSNBSauCTTM()
        {
            TableName = "BangTDCSNBSauCTTM";
            TablePrimaryKeyName = "ID";
            IDMauPhieu = (int)DanhMucPhieu.BTDCSNBSCTTM;
            TenMauPhieu = DanhMucPhieu.BTDCSNBSCTTM.Description();
        }
        [MoTaDuLieu("Mã định danh")]
		public long ID { get; set; }
        [MoTaDuLieu("Mã quản lý: mã duy nhất trong 1 đợt khám chữa bệnh (kcb), không trùng giữa các đợt kcb khác nhau","",1)]
		public decimal MaQuanLy { get; set; }
        [MoTaDuLieu("Mã bệnh nhân")]
		public string MaBenhNhan { get; set; }
        [MoTaDuLieu("Họ và tên bệnh nhân")]
        public string HoVaTenBN { get; set; }
        [MoTaDuLieu("Tuổi bệnh nhân")]
		public string Tuoi { get; set; }
        [MoTaDuLieu("Giới tính bệnh nhân")]
		public string GioiTinh { get; set; }
        [MoTaDuLieu("Số giường")]
        public string SoGiuong { get; set; }
        [MoTaDuLieu("Buồng")]
		public string Buong { get; set; }
        [MoTaDuLieu("Chẩn đoán bệnh")]
		public string ChanDoan { get; set; }
        [MoTaDuLieu("Chăm sóc cấp")]
        public string ChamSocCap { get; set; }
        [MoTaDuLieu("Ngày can thiệp")]
        public DateTime? NgayCanThiep { get; set; }
        [MoTaDuLieu("Giờ can thiệp")]
        public DateTime? NgayCanThiep_Gio { get; set; }
        [MoTaDuLieu("Thời gian")]
        public DateTime? ThoiGian { get; set; }
        [MoTaDuLieu("Giờ")]
        public DateTime? ThoiGian_Gio { get; set; }
        [MoTaDuLieu("Giờ về khoa")]
        public DateTime? GioVaoKhoa { get; set; }
        public bool[] TriGiacArray { get; } = new bool[] { false, false, false };
        [MoTaDuLieu("Tri giác")]
        public int TriGiac
        {
            get
            {
                return Array.IndexOf(TriGiacArray, true) + 1;
            }
            set
            {
                for (int i = 0; i < TriGiacArray.Length; i++)
                {
                    if (i == (value - 1)) TriGiacArray[i] = true;
                    else TriGiacArray[i] = false;
                }
            }
        }
        public bool[] MachArray { get; } = new bool[] { false, false };
        [MoTaDuLieu("Mạch")]
        public int Mach
        {
            get
            {
                return Array.IndexOf(MachArray, true) + 1;
            }
            set
            {
                for (int i = 0; i < MachArray.Length; i++)
                {
                    if (i == (value - 1)) MachArray[i] = true;
                    else MachArray[i] = false;
                }
            }
        }
        public bool[] NhipTimArray { get; } = new bool[] { false, false, false };
        [MoTaDuLieu("Nhịp tim")]
        public int NhipTim
        {
            get
            {
                return Array.IndexOf(NhipTimArray, true) + 1;
            }
            set
            {
                for (int i = 0; i < NhipTimArray.Length; i++)
                {
                    if (i == (value - 1)) NhipTimArray[i] = true;
                    else NhipTimArray[i] = false;
                }
            }
        }

        public bool[] RoiLoanNhipArray { get; } = new bool[] { false, false };
        [MoTaDuLieu("Rối loạn nhịp")]
        public int RoiLoanNhip
        {
            get
            {
                return Array.IndexOf(RoiLoanNhipArray, true) + 1;
            }
            set
            {
                for (int i = 0; i < RoiLoanNhipArray.Length; i++)
                {
                    if (i == (value - 1)) RoiLoanNhipArray[i] = true;
                    else RoiLoanNhipArray[i] = false;
                }
            }
        }
        public bool[] HuyetApArray { get; } = new bool[] { false, false, false };
        [MoTaDuLieu("Huyết áp")]
        public int HuyetAp
        {
            get
            {
                return Array.IndexOf(HuyetApArray, true) + 1;
            }
            set
            {
                for (int i = 0; i < HuyetApArray.Length; i++)
                {
                    if (i == (value - 1)) HuyetApArray[i] = true;
                    else HuyetApArray[i] = false;
                }
            }
        }
        public bool[] TuThoArray { get; } = new bool[] { false, false };
        [MoTaDuLieu("Tự thở")]
        public int TuTho
        {
            get
            {
                return Array.IndexOf(TuThoArray, true) + 1;
            }
            set
            {
                for (int i = 0; i < TuThoArray.Length; i++)
                {
                    if (i == (value - 1)) TuThoArray[i] = true;
                    else TuThoArray[i] = false;
                }
            }
        }
        public bool[] HoTroArray { get; } = new bool[] { false, false };
        [MoTaDuLieu("Hỗ trợ")]
        public int HoTro
        {
            get
            {
                return Array.IndexOf(HoTroArray, true) + 1;
            }
            set
            {
                for (int i = 0; i < HoTroArray.Length; i++)
                {
                    if (i == (value - 1)) HoTroArray[i] = true;
                    else HoTroArray[i] = false;
                }
            }
        }
        [MoTaDuLieu("Hỗ trợ bao nhiêu lít/phút")]
        public double? HoTro_Number { get; set; }
        [MoTaDuLieu("Sp02")]
        public double? SpO2 { get; set; }
        public bool[] ThanNhietArray { get; } = new bool[] { false, false, false,false };
        [MoTaDuLieu("Thân nhiệt")]
        public int ThanNhiet
        {
            get
            {
                return Array.IndexOf(ThanNhietArray, true) + 1;
            }
            set
            {
                for (int i = 0; i < ThanNhietArray.Length; i++)
                {
                    if (i == (value - 1)) ThanNhietArray[i] = true;
                    else ThanNhietArray[i] = false;
                }
            }
        }
        public bool[] MucDoDauArray { get; } = new bool[] { false, false, false };
        [MoTaDuLieu("Mức độ đau")]
        public int MucDoDau
        {
            get
            {
                return Array.IndexOf(MucDoDauArray, true) + 1;
            }
            set
            {
                for (int i = 0; i < MucDoDauArray.Length; i++)
                {
                    if (i == (value - 1)) MucDoDauArray[i] = true;
                    else MucDoDauArray[i] = false;
                }
            }
        }
        public bool[] ViTriDauArray { get; } = new bool[] { false, false, false, false, false };
        [MoTaDuLieu("Vị trí đau")]
        public int ViTriDau
        {
            get
            {
                return Array.IndexOf(ViTriDauArray, true) + 1;
            }
            set
            {
                for (int i = 0; i < ViTriDauArray.Length; i++)
                {
                    if (i == (value - 1)) ViTriDauArray[i] = true;
                    else ViTriDauArray[i] = false;
                }
            }
        }

        [MoTaDuLieu("Đau khác")]
        public string DauKhac { get; set; }
        [MoTaDuLieu("Thời gian đau")]
        public double? ThoiGianDau { get; set; }
        [MoTaDuLieu("Điểm đau")]
        public double? DiemDau { get; set; }
        public bool[] ViTriCanThiep_1_Array { get; } = new bool[] { false, false};
        [MoTaDuLieu("Vị trí can thiệp thứ 1")]
        public int ViTriCanThiep_1
        {
            get
            {
                return Array.IndexOf(ViTriCanThiep_1_Array, true) + 1;
            }
            set
            {
                for (int i = 0; i < ViTriCanThiep_1_Array.Length; i++)
                {
                    if (i == (value - 1)) ViTriCanThiep_1_Array[i] = true;
                    else ViTriCanThiep_1_Array[i] = false;
                }
            }
        }
        public bool[] ViTriCanThiep_2_Array { get; } = new bool[] { false, false, false };
        [MoTaDuLieu("Vị trí can thiệp thứ 2")]
        public int ViTriCanThiep_2
        {
            get
            {
                return Array.IndexOf(ViTriCanThiep_2_Array, true) + 1;
            }
            set
            {
                for (int i = 0; i < ViTriCanThiep_2_Array.Length; i++)
                {
                    if (i == (value - 1)) ViTriCanThiep_2_Array[i] = true;
                    else ViTriCanThiep_2_Array[i] = false;
                }
            }
        }
        public bool[] ViTriCanThiep_3_Array { get; } = new bool[] { false, false, false };
        [MoTaDuLieu("Vị trí can thiệp thứ 3")]
        public int ViTriCanThiep_3
        {
            get
            {
                return Array.IndexOf(ViTriCanThiep_3_Array, true) + 1;
            }
            set
            {
                for (int i = 0; i < ViTriCanThiep_3_Array.Length; i++)
                {
                    if (i == (value - 1)) ViTriCanThiep_3_Array[i] = true;
                    else ViTriCanThiep_3_Array[i] = false;
                }
            }
        }
        public bool[] ChiBenCanThiep_1_Array { get; } = new bool[] { false, false, false };
        [MoTaDuLieu("Chi bên can thiệp thứ 1")]
        public int ChiBenCanThiep_1
        {
            get
            {
                return Array.IndexOf(ChiBenCanThiep_1_Array, true) + 1;
            }
            set
            {
                for (int i = 0; i < ChiBenCanThiep_1_Array.Length; i++)
                {
                    if (i == (value - 1)) ChiBenCanThiep_1_Array[i] = true;
                    else ChiBenCanThiep_1_Array[i] = false;
                }
            }
        }
        public bool[] ChiBenCanThiep_2_Array { get; } = new bool[] { false, false, false };
        [MoTaDuLieu("Chi bên can thiệp thứ 2")]
        public int ChiBenCanThiep_2
        {
            get
            {
                return Array.IndexOf(ChiBenCanThiep_2_Array, true) + 1;
            }
            set
            {
                for (int i = 0; i < ChiBenCanThiep_2_Array.Length; i++)
                {
                    if (i == (value - 1)) ChiBenCanThiep_2_Array[i] = true;
                    else ChiBenCanThiep_2_Array[i] = false;
                }
            }
        }
        public bool[] ChiBenCanThiep_3_Array { get; } = new bool[] { false, false };
        [MoTaDuLieu("Chi bên can thiệp thứ 3")]
        public int ChiBenCanThiep_3
        {
            get
            {
                return Array.IndexOf(ChiBenCanThiep_3_Array, true) + 1;
            }
            set
            {
                for (int i = 0; i < ChiBenCanThiep_3_Array.Length; i++)
                {
                    if (i == (value - 1)) ChiBenCanThiep_3_Array[i] = true;
                    else ChiBenCanThiep_3_Array[i] = false;
                }
            }
        }
        [MoTaDuLieu("Chi bên can thiệp SpO2")]
        public double? ChiBenCanThiep_SpO2 { get; set; }
        [MoTaDuLieu("Đường kính DC can thiệp")]
        public int DuongKinhDC { get; set; }
        [MoTaDuLieu("Đường kính DC khác")]
        public string DuongKinhDCKhac { get; set; }
        public bool[] BaiTietTaiArray { get; } = new bool[] { false, false };
        [MoTaDuLieu("Bài tiết tại")]
        public int BaiTietTai
        {
            get
            {
                return Array.IndexOf(BaiTietTaiArray, true) + 1;
            }
            set
            {
                for (int i = 0; i < BaiTietTaiArray.Length; i++)
                {
                    if (i == (value - 1)) BaiTietTaiArray[i] = true;
                    else BaiTietTaiArray[i] = false;
                }
            }
        }
        public bool[] BaiTiet_Chuong_Array { get; } = new bool[] { false, false,false };
        [MoTaDuLieu("Bài tiết chướng")]
        public int BaiTiet_Chuong
        {
            get
            {
                return Array.IndexOf(BaiTiet_Chuong_Array, true) + 1;
            }
            set
            {
                for (int i = 0; i < BaiTiet_Chuong_Array.Length; i++)
                {
                    if (i == (value - 1)) BaiTiet_Chuong_Array[i] = true;
                    else BaiTiet_Chuong_Array[i] = false;
                }
            }
        }
        public bool[] CauBangQuangArray { get; } = new bool[] { false, false };
        [MoTaDuLieu("Cầu bàng quang")]
        public int CauBangQuang
        {
            get
            {
                return Array.IndexOf(CauBangQuangArray, true) + 1;
            }
            set
            {
                for (int i = 0; i < CauBangQuangArray.Length; i++)
                {
                    if (i == (value - 1)) CauBangQuangArray[i] = true;
                    else CauBangQuangArray[i] = false;
                }
            }
        }
        [MoTaDuLieu("Màu sắc tiểu trong CT")]
        public string MauSacTieuTrongCT { get; set; }
        [MoTaDuLieu("Số lượng bài tiết tại TMCT")]
        public double? SoLuongBaiTiet { get; set; }
        [MoTaDuLieu("Diễn biến đặc biết trong can thiệp 1")]
        public int DienBien1 { get; set; }
        [MoTaDuLieu("Diễn biến đặc biết trong can thiệp 2")]
        public int DienBien2 { get; set; }
        [MoTaDuLieu("Diễn biến đặc biết trong can thiệp 3")]
        public int DienBien3 { get; set; }
        [MoTaDuLieu("Diễn biến đặc biết trong can thiệp 4")]
        public int DienBien4 { get; set; }
        [MoTaDuLieu("Chi tiết nhịp nhanh")]
        public string NhipNhanhChiTiet { get; set; }
        public bool[] ViTriCTL1_SungNeArray { get; } = new bool[] { false, false };
        [MoTaDuLieu("Vị trí CT trước nối băng L1")]
        public int ViTriCTL1_SungNe
        {
            get
            {
                return Array.IndexOf(ViTriCTL1_SungNeArray, true) + 1;
            }
            set
            {
                for (int i = 0; i < ViTriCTL1_SungNeArray.Length; i++)
                {
                    if (i == (value - 1)) ViTriCTL1_SungNeArray[i] = true;
                    else ViTriCTL1_SungNeArray[i] = false;
                }
            }
        }
        [MoTaDuLieu("Vị trí CT trước nối băng L1: Sưng nề")]
        public string ViTriCTL1_SungNe_1_DK { get; set; }
        public bool[] ViTriCTL1_ChayMauArray { get; } = new bool[] { false, false };
        [MoTaDuLieu("Vị trí CT trước nối băng L1: Chảy máu")]
        public int ViTriCTL1_ChayMau
        {
            get
            {
                return Array.IndexOf(ViTriCTL1_ChayMauArray, true) + 1;
            }
            set
            {
                for (int i = 0; i < ViTriCTL1_ChayMauArray.Length; i++)
                {
                    if (i == (value - 1)) ViTriCTL1_ChayMauArray[i] = true;
                    else ViTriCTL1_ChayMauArray[i] = false;
                }
            }
        }
        [MoTaDuLieu("Vị trí CT trước nối băng L1: Tím-ĐK")]
        public string ViTriCTL1_Tim_1_DK { get; set; }
        public bool[] ViTriCTL1_TimArray { get; } = new bool[] { false, false };
        [MoTaDuLieu("Vị trí CT trước nối băng L1: Tím")]
        public int ViTriCTL1_Tim
        {
            get
            {
                return Array.IndexOf(ViTriCTL1_TimArray, true) + 1;
            }
            set
            {
                for (int i = 0; i < ViTriCTL1_TimArray.Length; i++)
                {
                    if (i == (value - 1)) ViTriCTL1_TimArray[i] = true;
                    else ViTriCTL1_TimArray[i] = false;
                }
            }
        }
        public bool[] ViTriCTL1_DauArray { get; } = new bool[] { false, false };
        [MoTaDuLieu("Vị trí CT trước nối băng L1: Đau")]
        public int ViTriCTL1_Dau
        {
            get
            {
                return Array.IndexOf(ViTriCTL1_DauArray, true) + 1;
            }
            set
            {
                for (int i = 0; i < ViTriCTL1_DauArray.Length; i++)
                {
                    if (i == (value - 1)) ViTriCTL1_DauArray[i] = true;
                    else ViTriCTL1_DauArray[i] = false;
                }
            }
        }
        public bool[] ViTriCTL2_SungNeArray { get; } = new bool[] { false, false };
        [MoTaDuLieu("Vị trí CT trước nối băng L2: Sưng nề")]
        public int ViTriCTL2_SungNe
        {
            get
            {
                return Array.IndexOf(ViTriCTL2_SungNeArray, true) + 1;
            }
            set
            {
                for (int i = 0; i < ViTriCTL2_SungNeArray.Length; i++)
                {
                    if (i == (value - 1)) ViTriCTL2_SungNeArray[i] = true;
                    else ViTriCTL2_SungNeArray[i] = false;
                }
            }
        }
        [MoTaDuLieu("Vị trí CT trước nối băng L2: Sưng nề-ĐK")]
        public string ViTriCTL2_SungNe_1_DK { get; set; }
        public bool[] ViTriCTL2_ChayMauArray { get; } = new bool[] { false, false };
        [MoTaDuLieu("Vị trí CT trước nối băng L2: Chảy máu")]
        public int ViTriCTL2_ChayMau
        {
            get
            {
                return Array.IndexOf(ViTriCTL2_ChayMauArray, true) + 1;
            }
            set
            {
                for (int i = 0; i < ViTriCTL2_ChayMauArray.Length; i++)
                {
                    if (i == (value - 1)) ViTriCTL2_ChayMauArray[i] = true;
                    else ViTriCTL2_ChayMauArray[i] = false;
                }
            }
        }
        [MoTaDuLieu("Vị trí CT trước nối băng L1: Tím-ĐK")]
        public string ViTriCTL2_Tim_1_DK { get; set; }
        public bool[] ViTriCTL2_TimArray { get; } = new bool[] { false, false };
        [MoTaDuLieu("Vị trí CT trước nối băng L2: Tím")]
        public int ViTriCTL2_Tim
        {
            get
            {
                return Array.IndexOf(ViTriCTL2_TimArray, true) + 1;
            }
            set
            {
                for (int i = 0; i < ViTriCTL2_TimArray.Length; i++)
                {
                    if (i == (value - 1)) ViTriCTL2_TimArray[i] = true;
                    else ViTriCTL2_TimArray[i] = false;
                }
            }
        }
        public bool[] ViTriCTL2_DauArray { get; } = new bool[] { false, false };
        [MoTaDuLieu("Vị trí CT trước nối băng L2: Đau")]
        public int ViTriCTL2_Dau
        {
            get
            {
                return Array.IndexOf(ViTriCTL2_DauArray, true) + 1;
            }
            set
            {
                for (int i = 0; i < ViTriCTL2_DauArray.Length; i++)
                {
                    if (i == (value - 1)) ViTriCTL2_DauArray[i] = true;
                    else ViTriCTL2_DauArray[i] = false;
                }
            }
        }
        public bool[] ViTriCTTB_SungNeArray { get; } = new bool[] { false, false };
        [MoTaDuLieu("Vị trí CT trước thao băng: Sưng nề")]
        public int ViTriCTTB_SungNe
        {
            get
            {
                return Array.IndexOf(ViTriCTTB_SungNeArray, true) + 1;
            }
            set
            {
                for (int i = 0; i < ViTriCTTB_SungNeArray.Length; i++)
                {
                    if (i == (value - 1)) ViTriCTTB_SungNeArray[i] = true;
                    else ViTriCTTB_SungNeArray[i] = false;
                }
            }
        }
        [MoTaDuLieu("Vị trí CT trước thao băng: Sưng nề-ĐK")]
        public string ViTriCTTB_SungNe_1_DK { get; set; }
        public bool[] ViTriCTTB_ChayMauArray { get; } = new bool[] { false, false };
        [MoTaDuLieu("Vị trí CT trước thao băng: Chảy máu")]
        public int ViTriCTTB_ChayMau
        {
            get
            {
                return Array.IndexOf(ViTriCTTB_ChayMauArray, true) + 1;
            }
            set
            {
                for (int i = 0; i < ViTriCTTB_ChayMauArray.Length; i++)
                {
                    if (i == (value - 1)) ViTriCTTB_ChayMauArray[i] = true;
                    else ViTriCTTB_ChayMauArray[i] = false;
                }
            }
        }
        [MoTaDuLieu("Vị trí CT trước thao băng: Tím-ĐK")]
        public string ViTriCTTB_Tim_1_DK { get; set; }
        public bool[] ViTriCTTB_TimArray { get; } = new bool[] { false, false };
        [MoTaDuLieu("Vị trí CT trước thao băng: Tím")]
        public int ViTriCTTB_Tim
        {
            get
            {
                return Array.IndexOf(ViTriCTTB_TimArray, true) + 1;
            }
            set
            {
                for (int i = 0; i < ViTriCTTB_TimArray.Length; i++)
                {
                    if (i == (value - 1)) ViTriCTTB_TimArray[i] = true;
                    else ViTriCTTB_TimArray[i] = false;
                }
            }
        }
        public bool[] ViTriCTTB_DauArray { get; } = new bool[] { false, false };
        [MoTaDuLieu("Vị trí CT trước thao băng: Đau")]
        public int ViTriCTTB_Dau
        {
            get
            {
                return Array.IndexOf(ViTriCTTB_DauArray, true) + 1;
            }
            set
            {
                for (int i = 0; i < ViTriCTTB_DauArray.Length; i++)
                {
                    if (i == (value - 1)) ViTriCTTB_DauArray[i] = true;
                    else ViTriCTTB_DauArray[i] = false;
                }
            }
        }
        // Ke Hoach Cham Soc
        [MoTaDuLieu("kế hoạch theo dõi DHST")]
        public int KH_TheoDoiDHST { get; set; }
        [MoTaDuLieu("Kế hoạc theo dõi vị trí can thiệp")]
        public int KH_TheoDoiVTCT { get; set; }

        [MoTaDuLieu("Kế hoạch hướng dẫn bệnh nhân và người nhà")]
        public int KH_HuongDanBenhNhan { get; set; }
        [MoTaDuLieu("Nối băng ép lần 1")]
        public int NoiBangEpLan1 { get; set; }
        [MoTaDuLieu("Nối băng ép lần 2")]
        public int NoiBangEpLan2 { get; set; }

        [MoTaDuLieu("Tháo băng ép")]
        public int ThaoBangEp { get; set; }

        [MoTaDuLieu("Thực hiện kế hoạch chăm sóc: kẻ bảng theo dõi")]
        public int TH_KeBangTheoDoi { get; set; }
        [MoTaDuLieu("Thực hiện kế hoạch chăm sóc: Ghi điện tâm đồ")]
        public int TH_GhiDienTamDo { get; set; }
        [MoTaDuLieu("Thực hiện kế hoạch chăm sóc:mắc mornitoring theo dõi liên tục")]
        public int TH_TheoDoiLienTuc { get; set; }
        [MoTaDuLieu("Thực hiện kế hoạch chăm sóc: Bảo bác sĩ khám, thực hiện ý lệnh")]
        public int TH_ThucHienYLenh { get; set; }
        [MoTaDuLieu("Thực hiện kế hoạch chăm sóc: Đánh giá vị trí can thiệp")]
        public int TH_DanhGiaVTCT { get; set; }
        [MoTaDuLieu("Thực hiện kế hoạch chăm sóc: Bao ngay nhân viên y tế")]
        public int TH_BaoNhanVienYTe { get; set; }
        [MoTaDuLieu("Thực hiện kế hoạch chăm sóc: Kiểm tra vị trí can thiệp 30p/lần nếu chảy máu, sưng, đau...")]
        public int TH_KiemTraViTriCanThiep { get; set; }
        [MoTaDuLieu("Thực hiện kế hoạch chăm sóc: bất động chi bên can thiệp nếu băng ép đùi")]
        public int TH_CheDoVanDong1 { get; set; }
        [MoTaDuLieu("Thực hiện kế hoạch chăm sóc: Hạn chế gắng sức, không vận động mạch cổ tay bên can thiệp, không chống tay bên can thiệp xuống giường trong vòng 10 ngày")]
        public int TH_CheDoVanDong2 { get; set; }
        [MoTaDuLieu("Thực hiện kế hoạch chăm sóc: Không uống sữa sau can thiệp 4-6 giờ")]
        public int TH_CheDoAn1 { get; set; }
        [MoTaDuLieu("Thực hiện kế hoạch chăm sóc: Cho bệnh nhân uống thêm nước ấm")]
        public int TH_CheDoAn2 { get; set; }
        [MoTaDuLieu("Thực hiện kế hoạch chăm sóc: Cho bệnh nhân ăn uống theo nhu cầu")]
        public int TH_CheDoAn3 { get; set; }
        [MoTaDuLieu("Thực hiện kế hoạch chăm sóc: Sau can thiệp 3-4 giờ bệnh nhân không đi tiểu hoặc buồn tiểu không đi được => báo ngay NVYT")]
        public int TH_TheoDoiNuocTieu1 { get; set; }
        [MoTaDuLieu("Thực hiện kế hoạch chăm sóc: Theo dõi tình trạng đi tiểu, màu sắc nước tiểu (nước tiểu màu hồng/đỏ) => báo ngay NVYT")]
        public int TH_TheoDoiNuocTieu2 { get; set; }
        [MoTaDuLieu("Thực hiện kế hoạch chăm sóc: Nối ép băng lần 1")]
        public int TH_NoiBangEpLan1 { get; set; }
        [MoTaDuLieu("Thực hiện kế hoạch chăm sóc: Nối ép băng lần 2")]
        public int TH_NoiBangEpLan2 { get; set; }
        [MoTaDuLieu("Thực hiện kế hoạch chăm sóc: Tháo băng ép theo giờ bàn giao")]
        public int TH_NoiBangEpTruocThao { get; set; }


        // danh gia
        [MoTaDuLieu("Nhận xét khác")]
        public string NhanXetKhac { get; set; }
        [MoTaDuLieu("Đánh giá")]
        public string DanhGia { get; set; }
        [MoTaDuLieu("Họ và tên điều dưỡng")]
        public string TenDieuDuong { get; set; }
        [MoTaDuLieu("Mã điều dưỡng")]
        public string MaTenDieuDuong { get; set; }

        [MoTaDuLieu("Đã ký", null, 0, 0)]
		public bool DaKy { get; set; }
        [MoTaDuLieu("Ngày tạo", null, 0, 0)]
		public DateTime NgayTao { get; set; }
        [MoTaDuLieu("Người tạo", null, 0, 0)]
		public string NguoiTao { get; set; }
        [MoTaDuLieu("Ngày sửa", null, 0, 0)]
		public DateTime NgaySua { get; set; }
        [MoTaDuLieu("Người sửa", null, 0, 0)]
		public string NguoiSua { get; set; }
        [MoTaDuLieu("Chọn", null, 0, 0)]
		public bool Chon { get; set; }
    }
    public class BangTDCSNBSauCTTMFunc
    {
        public const string TableName = "BangTDCSNBSauCTTM";
        public const string TablePrimaryKeyName = "ID";
        public static List<BangTDCSNBSauCTTM> GetListData(MDB.MDBConnection _OracleConnection, decimal maquanly)
        {
            List<BangTDCSNBSauCTTM> list = new List<BangTDCSNBSauCTTM>();
            try
            {
                string sql = @"SELECT * FROM BangTDCSNBSauCTTM where MaQuanLy = :MaQuanLy";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, _OracleConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", maquanly));
                MDB.MDBDataReader DataReader = Command.ExecuteReader();
                while (DataReader.Read())
                {
                    BangTDCSNBSauCTTM data = new BangTDCSNBSauCTTM();
                    data.ID = Convert.ToInt64(DataReader.GetLong("ID").ToString());
                    data.MaQuanLy = maquanly;
                    data.MaBenhNhan = DataReader["MaBenhNhan"].ToString();
                    data.HoVaTenBN = XemBenhAn._HanhChinhBenhNhan.TenBenhNhan;
                    data.Tuoi = XemBenhAn._HanhChinhBenhNhan.Tuoi;
                    data.GioiTinh = XemBenhAn._HanhChinhBenhNhan.GioiTinh.Description();
                    data.SoGiuong = DataReader["SoGiuong"].ToString();
                    data.Buong = DataReader["Buong"].ToString();
                    data.ChanDoan = DataReader["ChanDoan"].ToString();
                    data.NgayCanThiep = DataReader["NgayCanThiep"] == DBNull.Value ? (DateTime?)null : DataReader.GetDate("NgayCanThiep");
                    data.ThoiGian = DataReader["ThoiGian"] == DBNull.Value ? (DateTime?)null : DataReader.GetDate("ThoiGian");
                    data.GioVaoKhoa = DataReader["GioVaoKhoa"] == DBNull.Value ? (DateTime?)null : DataReader.GetDate("GioVaoKhoa");
                    data.NgayCanThiep_Gio = data.NgayCanThiep;
                    data.ThoiGian_Gio = data.ThoiGian;
                    data.TriGiac = DataReader.GetInt("TriGiac");
                    data.Mach = DataReader.GetInt("Mach");
                    data.NhipTim = DataReader.GetInt("NhipTim");
                    data.RoiLoanNhip = DataReader.GetInt("RoiLoanNhip");
                    data.HuyetAp = DataReader.GetInt("HuyetAp");
                    data.TuTho = DataReader.GetInt("TuTho");
                    data.HoTro = DataReader.GetInt("HoTro");
                    double tempDouble = 0;
                    data.HoTro_Number = double.TryParse(DataReader["HoTro_Number"].ToString(), out tempDouble) ? (double?)tempDouble : null;
                    tempDouble = 0;
                    data.SpO2 = double.TryParse(DataReader["SpO2"].ToString(), out tempDouble) ? (double?)tempDouble : null;

                    data.ThanNhiet = DataReader.GetInt("ThanNhiet");
                    data.MucDoDau = DataReader.GetInt("MucDoDau");
                    data.ViTriDau = DataReader.GetInt("ViTriDau");
                    data.DauKhac = DataReader["DauKhac"].ToString();
                    tempDouble = 0;
                    data.ThoiGianDau = double.TryParse(DataReader["ThoiGianDau"].ToString(), out tempDouble) ? (double?)tempDouble : null;
                    tempDouble = 0;
                    data.DiemDau = double.TryParse(DataReader["DiemDau"].ToString(), out tempDouble) ? (double?)tempDouble : null;
                    data.ViTriCanThiep_1 = DataReader.GetInt("ViTriCanThiep_1");
                    data.ViTriCanThiep_2 = DataReader.GetInt("ViTriCanThiep_2");
                    data.ViTriCanThiep_3 = DataReader.GetInt("ViTriCanThiep_3");
                    data.ChiBenCanThiep_1 = DataReader.GetInt("ChiBenCanThiep_1");
                    data.ChiBenCanThiep_2 = DataReader.GetInt("ChiBenCanThiep_2");
                    data.ChiBenCanThiep_3 = DataReader.GetInt("ChiBenCanThiep_3");
                    tempDouble = 0;
                    data.ChiBenCanThiep_SpO2 = double.TryParse(DataReader["ChiBenCanThiep_SpO2"].ToString(), out tempDouble) ? (double?)tempDouble : null;
                    data.DuongKinhDC = DataReader.GetInt("DuongKinhDC");
                    data.DuongKinhDCKhac = DataReader["DuongKinhDCKhac"].ToString();
                    data.BaiTietTai = DataReader.GetInt("BaiTietTai");
                    data.BaiTiet_Chuong = DataReader.GetInt("BaiTiet_Chuong");
                    data.CauBangQuang = DataReader.GetInt("CauBangQuang");
                    data.MauSacTieuTrongCT = DataReader["MauSacTieuTrongCT"].ToString();
                    tempDouble = 0;
                    data.SoLuongBaiTiet = double.TryParse(DataReader["SoLuongBaiTiet"].ToString(), out tempDouble) ? (double?)tempDouble : null;
                    data.DienBien1 = DataReader.GetInt("DienBien1");
                    data.DienBien2 = DataReader.GetInt("DienBien2");
                    data.DienBien3 = DataReader.GetInt("DienBien3");
                    data.DienBien4 = DataReader.GetInt("DienBien4");
                    data.NhipNhanhChiTiet = DataReader["NhipNhanhChiTiet"].ToString();
                    data.ViTriCTL1_SungNe = DataReader.GetInt("ViTriCTL1_SungNe");
                    data.ViTriCTL1_SungNe_1_DK = DataReader["ViTriCTL1_SungNe_1_DK"].ToString();
                    data.ViTriCTL1_ChayMau = DataReader.GetInt("ViTriCTL1_ChayMau");
                    data.ViTriCTL1_Tim = DataReader.GetInt("ViTriCTL1_Tim");
                    data.ViTriCTL1_Tim_1_DK = DataReader["ViTriCTL1_Tim_1_DK"].ToString();
                    data.ViTriCTL1_Dau = DataReader.GetInt("ViTriCTL1_Dau");

                    data.ViTriCTL2_SungNe = DataReader.GetInt("ViTriCTL2_SungNe");
                    data.ViTriCTL2_SungNe_1_DK = DataReader["ViTriCTL2_SungNe_1_DK"].ToString();
                    data.ViTriCTL2_ChayMau = DataReader.GetInt("ViTriCTL2_ChayMau");
                    data.ViTriCTL2_Tim = DataReader.GetInt("ViTriCTL2_Tim");
                    data.ViTriCTL2_Tim_1_DK = DataReader["ViTriCTL2_Tim_1_DK"].ToString();
                    data.ViTriCTL2_Dau = DataReader.GetInt("ViTriCTL2_Dau");

                    data.ViTriCTTB_SungNe = DataReader.GetInt("ViTriCTTB_SungNe");
                    data.ViTriCTTB_SungNe_1_DK = DataReader["ViTriCTTB_SungNe_1_DK"].ToString();
                    data.ViTriCTTB_ChayMau = DataReader.GetInt("ViTriCTTB_ChayMau");
                    data.ViTriCTTB_Tim = DataReader.GetInt("ViTriCTTB_Tim");
                    data.ViTriCTTB_Tim_1_DK = DataReader["ViTriCTTB_Tim_1_DK"].ToString();
                    data.ViTriCTTB_Dau = DataReader.GetInt("ViTriCTTB_Dau");

                    data.KH_TheoDoiDHST = DataReader.GetInt("KH_TheoDoiDHST");
                    data.KH_TheoDoiVTCT = DataReader.GetInt("KH_TheoDoiVTCT");
                    data.KH_HuongDanBenhNhan = DataReader.GetInt("KH_HuongDanBenhNhan");
                    data.NoiBangEpLan1 = DataReader.GetInt("NoiBangEpLan1");
                    data.NoiBangEpLan2 = DataReader.GetInt("NoiBangEpLan2");
                    data.ThaoBangEp = DataReader.GetInt("ThaoBangEp");

                    data.TH_KeBangTheoDoi = DataReader.GetInt("TH_KeBangTheoDoi");
                    data.TH_GhiDienTamDo = DataReader.GetInt("TH_GhiDienTamDo");
                    data.TH_TheoDoiLienTuc = DataReader.GetInt("TH_TheoDoiLienTuc");
                    data.TH_ThucHienYLenh = DataReader.GetInt("TH_ThucHienYLenh");
                    data.TH_DanhGiaVTCT = DataReader.GetInt("TH_DanhGiaVTCT");
                    data.TH_BaoNhanVienYTe = DataReader.GetInt("TH_BaoNhanVienYTe");
                    data.TH_KiemTraViTriCanThiep = DataReader.GetInt("TH_KiemTraViTriCanThiep");
                    data.TH_CheDoAn1 = DataReader.GetInt("TH_CheDoAn1");
                    data.TH_CheDoAn2 = DataReader.GetInt("TH_CheDoAn2");
                    data.TH_CheDoAn3 = DataReader.GetInt("TH_CheDoAn3");
                    data.TH_CheDoVanDong1 = DataReader.GetInt("TH_CheDoVanDong1");
                    data.TH_CheDoVanDong2 = DataReader.GetInt("TH_CheDoVanDong2");
                    data.TH_TheoDoiNuocTieu1 = DataReader.GetInt("TH_TheoDoiNuocTieu1");
                    data.TH_TheoDoiNuocTieu2 = DataReader.GetInt("TH_TheoDoiNuocTieu2");
                    data.TH_NoiBangEpLan1 = DataReader.GetInt("TH_NoiBangEpLan1");
                    data.TH_NoiBangEpLan2 = DataReader.GetInt("TH_NoiBangEpLan2");
                    data.TH_NoiBangEpTruocThao = DataReader.GetInt("TH_NoiBangEpTruocThao");

                    data.TenDieuDuong = DataReader["TenDieuDuong"].ToString();
                    data.MaTenDieuDuong = DataReader["MaTenDieuDuong"].ToString();
                    data.NhanXetKhac = DataReader["NhanXetKhac"].ToString();
                    data.DanhGia = DataReader["DanhGia"].ToString();
                    data.ChamSocCap = DataReader["ChamSocCap"].ToString();
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
        public static bool InsertOrUpdate(MDB.MDBConnection MyConnection, ref BangTDCSNBSauCTTM keHoach)
        {
            try
            {
                string sql = @"INSERT INTO BangTDCSNBSauCTTM
                (
                    MAQUANLY,
                    MaBenhNhan,
                    SoGiuong,
	                Buong,
	                ChanDoan,
	                NgayCanThiep,
                    ThoiGian,
                    GioVaoKhoa,
	                TriGiac,
	                Mach,
	                NhipTim,
	                RoiLoanNhip,
	                HuyetAp,
	                TuTho,
	                HoTro,
	                HoTro_Number,
	                SpO2,
	                ThanNhiet,
	                MucDoDau,
	                ViTriDau,
	                DauKhac,
	                ThoiGianDau,
	                DiemDau,
	                ViTriCanThiep_1,
	                ViTriCanThiep_2,
	                ViTriCanThiep_3,
	                ChiBenCanThiep_1,
	                ChiBenCanThiep_2,
	                ChiBenCanThiep_3,
	                ChiBenCanThiep_SpO2,
	                DuongKinhDC,
	                DuongKinhDCKhac,
	                BaiTietTai,
                    BaiTiet_Chuong,
	                CauBangQuang,
	                MauSacTieuTrongCT,
	                SoLuongBaiTiet,
	                DienBien1,
	                DienBien2,
	                DienBien3,
	                DienBien4,
	                NhipNhanhChiTiet,
	                ViTriCTL1_SungNe,
	                ViTriCTL1_SungNe_1_DK,
	                ViTriCTL1_ChayMau,
	                ViTriCTL1_Tim,
	                ViTriCTL1_Tim_1_DK,
	                ViTriCTL1_Dau,
	                ViTriCTL2_SungNe,
	                ViTriCTL2_SungNe_1_DK,
	                ViTriCTL2_ChayMau,
	                ViTriCTL2_Tim,
	                ViTriCTL2_Tim_1_DK,
	                ViTriCTL2_Dau,
	                ViTriCTTB_SungNe,
	                ViTriCTTB_SungNe_1_DK,
	                ViTriCTTB_ChayMau,
	                ViTriCTTB_Tim,
	                ViTriCTTB_Tim_1_DK,
	                ViTriCTTB_Dau,
	                KH_TheoDoiDHST,
	                KH_TheoDoiVTCT,
	                KH_HuongDanBenhNhan,
	                NoiBangEpLan1,
	                NoiBangEpLan2,
	                ThaoBangEp,
	                TH_KeBangTheoDoi,
	                TH_GhiDienTamDo,
	                TH_TheoDoiLienTuc,
	                TH_ThucHienYLenh,
	                TH_DanhGiaVTCT,
	                TH_BaoNhanVienYTe,
                    TH_KiemTraViTriCanThiep,
                    TH_CheDoAn1,
                    TH_CheDoAn2,
                    TH_CheDoAn3,
                    TH_CheDoVanDong1,
                    TH_CheDoVanDong2,
                    TH_TheoDoiNuocTieu1,
                    TH_TheoDoiNuocTieu2,
                    TH_NoiBangEpLan1,
                    TH_NoiBangEpLan2,
                    TH_NoiBangEpTruocThao,
	                TenDieuDuong,
	                MaTenDieuDuong,
                    NhanXetKhac,
                    DanhGia,
                    ChamSocCap,
                    NGUOITAO,
                    NGUOISUA,
                    NGAYTAO,
                    NGAYSUA)  VALUES
                 (
				    :MAQUANLY,
                    :MaBenhNhan,
                    :SoGiuong,
	                :Buong,
	                :ChanDoan,
	                :NgayCanThiep,
	                :ThoiGian,
                    :GioVaoKhoa,
	                :TriGiac,
	                :Mach,
	                :NhipTim,
	                :RoiLoanNhip,
	                :HuyetAp,
	                :TuTho,
	                :HoTro,
	                :HoTro_Number,
	                :SpO2,
	                :ThanNhiet,
	                :MucDoDau,
	                :ViTriDau,
	                :DauKhac,
	                :ThoiGianDau,
	                :DiemDau,
	                :ViTriCanThiep_1,
	                :ViTriCanThiep_2,
	                :ViTriCanThiep_3,
	                :ChiBenCanThiep_1,
	                :ChiBenCanThiep_2,
	                :ChiBenCanThiep_3,
	                :ChiBenCanThiep_SpO2,
	                :DuongKinhDC,
	                :DuongKinhDCKhac,
	                :BaiTietTai,
	                :BaiTiet_Chuong,
	                :CauBangQuang,
	                :MauSacTieuTrongCT,
	                :SoLuongBaiTiet,
	                :DienBien1,
	                :DienBien2,
	                :DienBien3,
	                :DienBien4,
	                :NhipNhanhChiTiet,
	                :ViTriCTL1_SungNe,
	                :ViTriCTL1_SungNe_1_DK,
	                :ViTriCTL1_ChayMau,
	                :ViTriCTL1_Tim,
	                :ViTriCTL1_Tim_1_DK,
	                :ViTriCTL1_Dau,
	                :ViTriCTL2_SungNe,
	                :ViTriCTL2_SungNe_1_DK,
	                :ViTriCTL2_ChayMau,
	                :ViTriCTL2_Tim,
	                :ViTriCTL2_Tim_1_DK,
	                :ViTriCTL2_Dau,
	                :ViTriCTTB_SungNe,
	                :ViTriCTTB_SungNe_1_DK,
	                :ViTriCTTB_ChayMau,
	                :ViTriCTTB_Tim,
	                :ViTriCTTB_Tim_1_DK,
	                :ViTriCTTB_Dau,
	                :KH_TheoDoiDHST,
	                :KH_TheoDoiVTCT,
	                :KH_HuongDanBenhNhan,
	                :NoiBangEpLan1,
	                :NoiBangEpLan2,
	                :ThaoBangEp,
	                :TH_KeBangTheoDoi,
	                :TH_GhiDienTamDo,
	                :TH_TheoDoiLienTuc,
	                :TH_ThucHienYLenh,
	                :TH_DanhGiaVTCT,
	                :TH_BaoNhanVienYTe,
                    :TH_KiemTraViTriCanThiep,
                    :TH_CheDoAn1,
                    :TH_CheDoAn2,
                    :TH_CheDoAn3,
                    :TH_CheDoVanDong1,
                    :TH_CheDoVanDong2,
                    :TH_TheoDoiNuocTieu1,
                    :TH_TheoDoiNuocTieu2,
                    :TH_NoiBangEpLan1,
                    :TH_NoiBangEpLan2,
                    :TH_NoiBangEpTruocThao,
	                :TenDieuDuong,
	                :MaTenDieuDuong,
                    :NhanXetKhac,
                    :DanhGia,
                    :ChamSocCap,
                    :NGUOITAO,
                    :NGUOISUA,
                    :NGAYTAO,
                    :NGAYSUA
                 )  RETURNING ID INTO :ID";
                if (keHoach.ID != 0)
                {
                    sql = @"UPDATE BangTDCSNBSauCTTM SET 
                    MAQUANLY = :MAQUANLY,
                    MaBenhNhan = :MaBenhNhan,
                    SoGiuong = :SoGiuong,
	                Buong = :Buong,
	                ChanDoan = :ChanDoan,
	                NgayCanThiep = :NgayCanThiep,
	                ThoiGian = :ThoiGian,
                    GioVaoKhoa = :GioVaoKhoa,
	                TriGiac = :TriGiac,
	                Mach = :Mach,
	                NhipTim = :NhipTim,
	                RoiLoanNhip = :RoiLoanNhip,
	                HuyetAp = :HuyetAp,
	                TuTho = :TuTho,
	                HoTro = :HoTro,
	                HoTro_Number = :HoTro_Number,
	                SpO2 = :SpO2,
	                ThanNhiet = :ThanNhiet,
	                MucDoDau = :MucDoDau,
	                ViTriDau = :ViTriDau,
	                DauKhac = :DauKhac,
	                ThoiGianDau = :ThoiGianDau,
	                DiemDau = :DiemDau,
	                ViTriCanThiep_1 = :ViTriCanThiep_1,
	                ViTriCanThiep_2 = :ViTriCanThiep_2,
	                ViTriCanThiep_3 = :ViTriCanThiep_3,
	                ChiBenCanThiep_1 = :ChiBenCanThiep_1,
	                ChiBenCanThiep_2 = :ChiBenCanThiep_2,
	                ChiBenCanThiep_3 = :ChiBenCanThiep_3,
	                ChiBenCanThiep_SpO2 = :ChiBenCanThiep_SpO2,
	                DuongKinhDC = :DuongKinhDC,
	                DuongKinhDCKhac = :DuongKinhDCKhac,
	                BaiTietTai = :BaiTietTai,
	                BaiTiet_Chuong = :BaiTiet_Chuong,
	                CauBangQuang = :CauBangQuang,
	                MauSacTieuTrongCT = :MauSacTieuTrongCT,
	                SoLuongBaiTiet = :SoLuongBaiTiet,
	                DienBien1 = :DienBien1,
	                DienBien2 = :DienBien2,
	                DienBien3 = :DienBien3,
	                DienBien4 = :DienBien4,
	                NhipNhanhChiTiet = :NhipNhanhChiTiet,
	                ViTriCTL1_SungNe = :ViTriCTL1_SungNe,
	                ViTriCTL1_SungNe_1_DK = :ViTriCTL1_SungNe_1_DK,
	                ViTriCTL1_ChayMau = :ViTriCTL1_ChayMau,
	                ViTriCTL1_Tim = :ViTriCTL1_Tim,
	                ViTriCTL1_Tim_1_DK = :ViTriCTL1_Tim_1_DK,
	                ViTriCTL1_Dau = :ViTriCTL1_Dau,
	                ViTriCTL2_SungNe = :ViTriCTL2_SungNe,
	                ViTriCTL2_SungNe_1_DK = :ViTriCTL2_SungNe_1_DK,
	                ViTriCTL2_ChayMau = :ViTriCTL2_ChayMau,
	                ViTriCTL2_Tim = :ViTriCTL2_Tim,
	                ViTriCTL2_Tim_1_DK = :ViTriCTL2_Tim_1_DK,
	                ViTriCTL2_Dau = :ViTriCTL2_Dau,
	                ViTriCTTB_SungNe = :ViTriCTTB_SungNe,
	                ViTriCTTB_SungNe_1_DK = :ViTriCTTB_SungNe_1_DK,
	                ViTriCTTB_ChayMau = :ViTriCTTB_ChayMau,
	                ViTriCTTB_Tim = :ViTriCTTB_Tim,
	                ViTriCTTB_Tim_1_DK = :ViTriCTTB_Tim_1_DK,
	                ViTriCTTB_Dau = :ViTriCTTB_Dau,
	                KH_TheoDoiDHST = :KH_TheoDoiDHST,
	                KH_TheoDoiVTCT = :KH_TheoDoiVTCT,
	                KH_HuongDanBenhNhan = :KH_HuongDanBenhNhan,
	                NoiBangEpLan1 = :NoiBangEpLan1,
	                NoiBangEpLan2 = :NoiBangEpLan2,
	                ThaoBangEp = :ThaoBangEp,
	                TH_KeBangTheoDoi = :TH_KeBangTheoDoi,
	                TH_GhiDienTamDo = :TH_GhiDienTamDo,
	                TH_TheoDoiLienTuc = :TH_TheoDoiLienTuc,
	                TH_ThucHienYLenh = :TH_ThucHienYLenh,
	                TH_DanhGiaVTCT = :TH_DanhGiaVTCT,
	                TH_BaoNhanVienYTe = :TH_BaoNhanVienYTe,
                    TH_KiemTraViTriCanThiep = :TH_KiemTraViTriCanThiep,
                    TH_CheDoAn1 = :TH_CheDoAn1,
                    TH_CheDoAn2 = :TH_CheDoAn2,
                    TH_CheDoAn3 = :TH_CheDoAn3,
                    TH_CheDoVanDong1 = :TH_CheDoVanDong1,
                    TH_CheDoVanDong2 = :TH_CheDoVanDong2,
                    TH_TheoDoiNuocTieu1 = :TH_TheoDoiNuocTieu1,
                    TH_TheoDoiNuocTieu2 = :TH_TheoDoiNuocTieu2,
                    TH_NoiBangEpLan1 = :TH_NoiBangEpLan1,
                    TH_NoiBangEpLan2 = :TH_NoiBangEpLan2,
                    TH_NoiBangEpTruocThao = :TH_NoiBangEpTruocThao,
	                TenDieuDuong = :TenDieuDuong,
	                MaTenDieuDuong = :MaTenDieuDuong,
                    NhanXetKhac = :NhanXetKhac,
                    DanhGia = :DanhGia,
                    ChamSocCap = :ChamSocCap,
                    NGUOISUA = :NGUOISUA,
                    NGAYSUA = :NGAYSUA 
                    WHERE ID = " + keHoach.ID;
                }
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MAQUANLY", keHoach.MaQuanLy));
                Command.Parameters.Add(new MDB.MDBParameter("MaBenhNhan", keHoach.MaBenhNhan));
                Command.Parameters.Add(new MDB.MDBParameter("SoGiuong", keHoach.SoGiuong));
                Command.Parameters.Add(new MDB.MDBParameter("Buong", keHoach.Buong));
                Command.Parameters.Add(new MDB.MDBParameter("ChanDoan", keHoach.ChanDoan));
                DateTime? Ngay = keHoach.NgayCanThiep.HasValue ? keHoach.NgayCanThiep.Value.Add(new TimeSpan(0, 0, 0)) : (DateTime?) null;
                var NgayGio = Ngay;
                if (Ngay != null)
                {
                    var Gio = keHoach.NgayCanThiep_Gio.HasValue ? keHoach.NgayCanThiep_Gio.Value.TimeOfDay : new TimeSpan(0, 0, 0);
                    NgayGio = Ngay + Gio;
                }
                Command.Parameters.Add(new MDB.MDBParameter("NgayCanThiep", NgayGio));
                DateTime? ThoiGianNgay = keHoach.ThoiGian.HasValue ? keHoach.ThoiGian.Value.Add(new TimeSpan(0, 0, 0)) : (DateTime?)null;
                var ThoiGian = ThoiGianNgay;
                if (ThoiGianNgay != null)
                {
                    var ThoiGianGio = keHoach.ThoiGian_Gio.HasValue ? keHoach.ThoiGian_Gio.Value.TimeOfDay : new TimeSpan(0, 0, 0);
                    ThoiGian = ThoiGianNgay + ThoiGianGio;
                }
                Command.Parameters.Add(new MDB.MDBParameter("ThoiGian", ThoiGian));
                Command.Parameters.Add(new MDB.MDBParameter("GioVaoKhoa", keHoach.GioVaoKhoa));
                Command.Parameters.Add(new MDB.MDBParameter("TriGiac", keHoach.TriGiac));
                Command.Parameters.Add(new MDB.MDBParameter("Mach", keHoach.Mach));
                Command.Parameters.Add(new MDB.MDBParameter("NhipTim", keHoach.NhipTim));
                Command.Parameters.Add(new MDB.MDBParameter("RoiLoanNhip", keHoach.RoiLoanNhip));
                Command.Parameters.Add(new MDB.MDBParameter("HuyetAp", keHoach.HuyetAp));
                Command.Parameters.Add(new MDB.MDBParameter("TuTho", keHoach.TuTho));
                Command.Parameters.Add(new MDB.MDBParameter("HoTro", keHoach.HoTro));
                Command.Parameters.Add(new MDB.MDBParameter("HoTro_Number", keHoach.HoTro_Number));
                Command.Parameters.Add(new MDB.MDBParameter("SpO2", keHoach.SpO2));
                Command.Parameters.Add(new MDB.MDBParameter("ThanNhiet", keHoach.ThanNhiet));
                Command.Parameters.Add(new MDB.MDBParameter("MucDoDau", keHoach.MucDoDau));
                Command.Parameters.Add(new MDB.MDBParameter("ViTriDau", keHoach.ViTriDau));
                Command.Parameters.Add(new MDB.MDBParameter("DauKhac", keHoach.DauKhac));
                Command.Parameters.Add(new MDB.MDBParameter("ThoiGianDau", keHoach.ThoiGianDau));
                Command.Parameters.Add(new MDB.MDBParameter("DiemDau", keHoach.DiemDau));
                Command.Parameters.Add(new MDB.MDBParameter("ViTriCanThiep_1", keHoach.ViTriCanThiep_1));
                Command.Parameters.Add(new MDB.MDBParameter("ViTriCanThiep_2", keHoach.ViTriCanThiep_2));
                Command.Parameters.Add(new MDB.MDBParameter("ViTriCanThiep_3", keHoach.ViTriCanThiep_3));
                Command.Parameters.Add(new MDB.MDBParameter("ChiBenCanThiep_1", keHoach.ChiBenCanThiep_1));
                Command.Parameters.Add(new MDB.MDBParameter("ChiBenCanThiep_2", keHoach.ChiBenCanThiep_2));
                Command.Parameters.Add(new MDB.MDBParameter("ChiBenCanThiep_3", keHoach.ChiBenCanThiep_3));
                Command.Parameters.Add(new MDB.MDBParameter("ChiBenCanThiep_SpO2", keHoach.ChiBenCanThiep_SpO2));
                Command.Parameters.Add(new MDB.MDBParameter("DuongKinhDC", keHoach.DuongKinhDC));
                Command.Parameters.Add(new MDB.MDBParameter("DuongKinhDCKhac", keHoach.DuongKinhDCKhac));
                Command.Parameters.Add(new MDB.MDBParameter("BaiTietTai", keHoach.BaiTietTai));
                Command.Parameters.Add(new MDB.MDBParameter("BaiTiet_Chuong", keHoach.BaiTiet_Chuong));
                Command.Parameters.Add(new MDB.MDBParameter("CauBangQuang", keHoach.CauBangQuang));
                Command.Parameters.Add(new MDB.MDBParameter("MauSacTieuTrongCT", keHoach.MauSacTieuTrongCT));
                Command.Parameters.Add(new MDB.MDBParameter("SoLuongBaiTiet", keHoach.SoLuongBaiTiet));
                Command.Parameters.Add(new MDB.MDBParameter("DienBien1", keHoach.DienBien1));
                Command.Parameters.Add(new MDB.MDBParameter("DienBien2", keHoach.DienBien2));
                Command.Parameters.Add(new MDB.MDBParameter("DienBien3", keHoach.DienBien3));
                Command.Parameters.Add(new MDB.MDBParameter("DienBien4", keHoach.DienBien4));
                Command.Parameters.Add(new MDB.MDBParameter("NhipNhanhChiTiet", keHoach.NhipNhanhChiTiet));
                Command.Parameters.Add(new MDB.MDBParameter("ViTriCTL1_SungNe", keHoach.ViTriCTL1_SungNe));
                Command.Parameters.Add(new MDB.MDBParameter("ViTriCTL1_SungNe_1_DK", keHoach.ViTriCTL1_SungNe_1_DK));
                Command.Parameters.Add(new MDB.MDBParameter("ViTriCTL1_ChayMau", keHoach.ViTriCTL1_ChayMau));
                Command.Parameters.Add(new MDB.MDBParameter("ViTriCTL1_Tim", keHoach.ViTriCTL1_Tim));
                Command.Parameters.Add(new MDB.MDBParameter("ViTriCTL1_Tim_1_DK", keHoach.ViTriCTL1_Tim_1_DK));
                Command.Parameters.Add(new MDB.MDBParameter("ViTriCTL1_Dau", keHoach.ViTriCTL1_Dau));
                Command.Parameters.Add(new MDB.MDBParameter("ViTriCTL2_SungNe", keHoach.ViTriCTL2_SungNe));
                Command.Parameters.Add(new MDB.MDBParameter("ViTriCTL2_SungNe_1_DK", keHoach.ViTriCTL2_SungNe_1_DK));
                Command.Parameters.Add(new MDB.MDBParameter("ViTriCTL2_ChayMau", keHoach.ViTriCTL2_ChayMau));
                Command.Parameters.Add(new MDB.MDBParameter("ViTriCTL2_Tim", keHoach.ViTriCTL2_Tim));
                Command.Parameters.Add(new MDB.MDBParameter("ViTriCTL2_Tim_1_DK", keHoach.ViTriCTL2_Tim_1_DK));
                Command.Parameters.Add(new MDB.MDBParameter("ViTriCTL2_Dau", keHoach.ViTriCTL2_Dau));
                Command.Parameters.Add(new MDB.MDBParameter("ViTriCTTB_SungNe", keHoach.ViTriCTTB_SungNe));
                Command.Parameters.Add(new MDB.MDBParameter("ViTriCTTB_SungNe_1_DK", keHoach.ViTriCTTB_SungNe_1_DK));
                Command.Parameters.Add(new MDB.MDBParameter("ViTriCTTB_ChayMau", keHoach.ViTriCTTB_ChayMau));
                Command.Parameters.Add(new MDB.MDBParameter("ViTriCTTB_Tim", keHoach.ViTriCTTB_Tim));
                Command.Parameters.Add(new MDB.MDBParameter("ViTriCTTB_Tim_1_DK", keHoach.ViTriCTTB_Tim_1_DK));
                Command.Parameters.Add(new MDB.MDBParameter("ViTriCTTB_Dau", keHoach.ViTriCTTB_Dau));
                Command.Parameters.Add(new MDB.MDBParameter("KH_TheoDoiDHST", keHoach.KH_TheoDoiDHST));
                Command.Parameters.Add(new MDB.MDBParameter("KH_TheoDoiVTCT", keHoach.KH_TheoDoiVTCT));
                Command.Parameters.Add(new MDB.MDBParameter("KH_HuongDanBenhNhan", keHoach.KH_HuongDanBenhNhan));
                Command.Parameters.Add(new MDB.MDBParameter("NoiBangEpLan1", keHoach.NoiBangEpLan1));
                Command.Parameters.Add(new MDB.MDBParameter("NoiBangEpLan2", keHoach.NoiBangEpLan2));
                Command.Parameters.Add(new MDB.MDBParameter("ThaoBangEp", keHoach.ThaoBangEp));
                Command.Parameters.Add(new MDB.MDBParameter("TH_KeBangTheoDoi", keHoach.TH_KeBangTheoDoi));
                Command.Parameters.Add(new MDB.MDBParameter("TH_GhiDienTamDo", keHoach.TH_GhiDienTamDo));
                Command.Parameters.Add(new MDB.MDBParameter("TH_TheoDoiLienTuc", keHoach.TH_TheoDoiLienTuc));
                Command.Parameters.Add(new MDB.MDBParameter("TH_ThucHienYLenh", keHoach.TH_ThucHienYLenh));
                Command.Parameters.Add(new MDB.MDBParameter("TH_DanhGiaVTCT", keHoach.TH_DanhGiaVTCT));
                Command.Parameters.Add(new MDB.MDBParameter("TH_BaoNhanVienYTe", keHoach.TH_BaoNhanVienYTe));

                Command.Parameters.Add(new MDB.MDBParameter("TH_KiemTraViTriCanThiep", keHoach.TH_KiemTraViTriCanThiep));
                Command.Parameters.Add(new MDB.MDBParameter("TH_CheDoAn1", keHoach.TH_CheDoAn1));
                Command.Parameters.Add(new MDB.MDBParameter("TH_CheDoAn2", keHoach.TH_CheDoAn2));
                Command.Parameters.Add(new MDB.MDBParameter("TH_CheDoAn3", keHoach.TH_CheDoAn3));
                Command.Parameters.Add(new MDB.MDBParameter("TH_CheDoVanDong1", keHoach.TH_CheDoVanDong1));
                Command.Parameters.Add(new MDB.MDBParameter("TH_CheDoVanDong2", keHoach.TH_CheDoVanDong2));
                Command.Parameters.Add(new MDB.MDBParameter("TH_TheoDoiNuocTieu1", keHoach.TH_TheoDoiNuocTieu1));
                Command.Parameters.Add(new MDB.MDBParameter("TH_TheoDoiNuocTieu2", keHoach.TH_TheoDoiNuocTieu2));
                Command.Parameters.Add(new MDB.MDBParameter("TH_NoiBangEpLan1", keHoach.TH_NoiBangEpLan1));
                Command.Parameters.Add(new MDB.MDBParameter("TH_NoiBangEpLan2", keHoach.TH_NoiBangEpLan2));
                Command.Parameters.Add(new MDB.MDBParameter("TH_NoiBangEpTruocThao", keHoach.TH_NoiBangEpTruocThao));
                Command.Parameters.Add(new MDB.MDBParameter("TenDieuDuong", keHoach.TenDieuDuong));
                Command.Parameters.Add(new MDB.MDBParameter("MaTenDieuDuong", keHoach.MaTenDieuDuong));
                Command.Parameters.Add(new MDB.MDBParameter("NhanXetKhac", keHoach.NhanXetKhac));
                Command.Parameters.Add(new MDB.MDBParameter("DanhGia", keHoach.DanhGia));
                Command.Parameters.Add(new MDB.MDBParameter("ChamSocCap", keHoach.ChamSocCap));

                Command.Parameters.Add(new MDB.MDBParameter("NGUOISUA", keHoach.NguoiSua));
                Command.Parameters.Add(new MDB.MDBParameter("NGAYSUA", keHoach.NgaySua));
                if (keHoach.ID == 0)
                {
                    Command.Parameters.Add(new MDB.MDBParameter("ID", keHoach.ID));
                    Command.Parameters.Add(new MDB.MDBParameter("NGUOITAO", keHoach.NguoiTao));
                    Command.Parameters.Add(new MDB.MDBParameter("NGAYTAO", keHoach.NgayTao));
                }
                Command.BindByName = true;
                int n = Command.ExecuteNonQuery();
                if (keHoach.ID == 0)
                {
                    long nextval = Convert.ToInt64((Command.Parameters["ID"] as MDB.MDBParameter).Value);
                    keHoach.ID = nextval;
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
                string sql = "DELETE FROM BangTDCSNBSauCTTM WHERE ID = :ID";
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
                H.SOYTE,
                H.BENHVIEN,
                H.TenBenhNhan,
                H.Tuoi,
                H.GioiTinh,
                T.KHOA
            FROM
                BangTDCSNBSauCTTM B
                LEFT JOIN HANHCHINHBENHNHAN H ON B.MABENHNHAN = H.MABENHNHAN
                LEFT JOIN THONGTINDIEUTRI T ON B.MAQUANLY = T.MAQUANLY
            WHERE
                ID = " + id;

            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
            MDB.MDBDataAdapter adt = new MDB.MDBDataAdapter(Command);
            var ds = new DataSet();

            adt.Fill(ds, "KH");
            return ds;
        }
    }
}
