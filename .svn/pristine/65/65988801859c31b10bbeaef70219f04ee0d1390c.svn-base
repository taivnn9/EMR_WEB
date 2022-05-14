
using EMR.KyDienTu;
using Newtonsoft.Json;
using PMS.Access;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;

namespace EMR_MAIN.DATABASE.Other
{
    public class PhieuSanSocDaKhoaLaser : ThongTinKy
    {
        public PhieuSanSocDaKhoaLaser()
        {
            TableName = "PhieuSanSocDaKhoaLaser";
            TablePrimaryKeyName = "ID";
            IDMauPhieu = (int)DanhMucPhieu.PSSDKL;
            TenMauPhieu = DanhMucPhieu.PSSDKL.Description();
        }
        [MoTaDuLieu("Mã định danh")]
		public long ID { get; set; }
        [MoTaDuLieu("Mã quản lý: mã duy nhất trong 1 đợt khám chữa bệnh (kcb), không trùng giữa các đợt kcb khác nhau","",1)]
		public decimal MaQuanLy { get; set; }
        [MoTaDuLieu("Mã bệnh nhân")]
		public string MaBenhNhan { get; set; }
        [MoTaDuLieu("Họ và tên bệnh nhân")]
		public string TenBenhNhan { get; set; }
        [MoTaDuLieu("Khoa")]
		public string Khoa { get; set; }
        [MoTaDuLieu("Năm sinh")]
		public string NamSinh { get; set; }
        [MoTaDuLieu("Giới tính bệnh nhân")]
		public string GioiTinh { get; set; }
        [MoTaDuLieu("Địa chỉ nhà bệnh nhân")]
		public string DiaChi { get; set; }
        [MoTaDuLieu("Nghề nghiệp")]
		public string NgheNghiep { get; set; }
        public string BoMe { get; set; }
        public string DienThoai { get; set; }
        public DateTime? Ngay { get; set; }

        public bool[] DieuTri_1_Array { get; } = new bool[] { false, false };
        public int DieuTri_1
        {
            get
            {
                return Array.IndexOf(DieuTri_1_Array, true) + 1;
            }
            set
            {
                for (int i = 0; i < DieuTri_1_Array.Length; i++)
                {
                    if (i == (value - 1)) DieuTri_1_Array[i] = true;
                    else DieuTri_1_Array[i] = false;
                }
            }
        }
        public string DieuTri_1_Text { get; set; }
        public bool[] DieuTri_2_Array { get; } = new bool[] { false, false, false };
        public int DieuTri_2
        {
            get
            {
                return Array.IndexOf(DieuTri_2_Array, true) + 1;
            }
            set
            {
                for (int i = 0; i < DieuTri_2_Array.Length; i++)
                {
                    if (i == (value - 1)) DieuTri_2_Array[i] = true;
                    else DieuTri_2_Array[i] = false;
                }
            }
        }
        public bool[] DieuTri_3_Array { get; } = new bool[] { false, false, false };
        public int DieuTri_3
        {
            get
            {
                return Array.IndexOf(DieuTri_3_Array, true) + 1;
            }
            set
            {
                for (int i = 0; i < DieuTri_3_Array.Length; i++)
                {
                    if (i == (value - 1)) DieuTri_3_Array[i] = true;
                    else DieuTri_3_Array[i] = false;
                }
            }
        }
        public bool[] DieuTri_4_Array { get; } = new bool[] { false, false };
        public int DieuTri_4
        {
            get
            {
                return Array.IndexOf(DieuTri_4_Array, true) + 1;
            }
            set
            {
                for (int i = 0; i < DieuTri_4_Array.Length; i++)
                {
                    if (i == (value - 1)) DieuTri_4_Array[i] = true;
                    else DieuTri_4_Array[i] = false;
                }
            }
        }
        public string DieuTri_4_Text { get; set; }

        public bool[] DieuTri_5_Array { get; } = new bool[] { false, false, false };
        public int DieuTri_5
        {
            get
            {
                return Array.IndexOf(DieuTri_5_Array, true) + 1;
            }
            set
            {
                for (int i = 0; i < DieuTri_5_Array.Length; i++)
                {
                    if (i == (value - 1)) DieuTri_5_Array[i] = true;
                    else DieuTri_5_Array[i] = false;
                }
            }
        }
        public bool[] DieuTri_6_Array { get; } = new bool[] { false, false,false };
        public int DieuTri_6
        {
            get
            {
                return Array.IndexOf(DieuTri_6_Array, true) + 1;
            }
            set
            {
                for (int i = 0; i < DieuTri_6_Array.Length; i++)
                {
                    if (i == (value - 1)) DieuTri_6_Array[i] = true;
                    else DieuTri_6_Array[i] = false;
                }
            }
        }
        public bool[] DieuTri_7_Array { get; } = new bool[] { false, false };
        public int DieuTri_7
        {
            get
            {
                return Array.IndexOf(DieuTri_7_Array, true) + 1;
            }
            set
            {
                for (int i = 0; i < DieuTri_7_Array.Length; i++)
                {
                    if (i == (value - 1)) DieuTri_7_Array[i] = true;
                    else DieuTri_7_Array[i] = false;
                }
            }
        }

        public string DieuTri_7_Text { get; set; }
        public bool[] DieuTri_8_Array { get; } = new bool[] { false, false, false, false, false, false };
        public int DieuTri_8
        {
            get
            {
                return Array.IndexOf(DieuTri_8_Array, true) + 1;
            }
            set
            {
                for (int i = 0; i < DieuTri_8_Array.Length; i++)
                {
                    if (i == (value - 1)) DieuTri_8_Array[i] = true;
                    else DieuTri_8_Array[i] = false;
                }
            }
        }
        public string DieuTri_9_Text { get; set; }
        public bool[] DieuTri_10_Array { get; } = new bool[] { false, false, false, false, false, false };
        public int DieuTri_10
        {
            get
            {
                return Array.IndexOf(DieuTri_10_Array, true) + 1;
            }
            set
            {
                for (int i = 0; i < DieuTri_10_Array.Length; i++)
                {
                    if (i == (value - 1)) DieuTri_10_Array[i] = true;
                    else DieuTri_10_Array[i] = false;
                }
            }
        }
        public bool[] DieuTri_11_Array { get; } = new bool[] { false, false, false, false, false, false };
        public int DieuTri_11
        {
            get
            {
                return Array.IndexOf(DieuTri_11_Array, true) + 1;
            }
            set
            {
                for (int i = 0; i < DieuTri_11_Array.Length; i++)
                {
                    if (i == (value - 1)) DieuTri_11_Array[i] = true;
                    else DieuTri_11_Array[i] = false;
                }
            }
        }
        public bool[] DieuTri_12_Array { get; } = new bool[] { false, false, false, false, false, false };
        public int DieuTri_12
        {
            get
            {
                return Array.IndexOf(DieuTri_12_Array, true) + 1;
            }
            set
            {
                for (int i = 0; i < DieuTri_12_Array.Length; i++)
                {
                    if (i == (value - 1)) DieuTri_12_Array[i] = true;
                    else DieuTri_12_Array[i] = false;
                }
            }
        }
        public bool[] DieuTri_13_Array { get; } = new bool[] { false, false, false};
        public int DieuTri_13
        {
            get
            {
                return Array.IndexOf(DieuTri_13_Array, true) + 1;
            }
            set
            {
                for (int i = 0; i < DieuTri_13_Array.Length; i++)
                {
                    if (i == (value - 1)) DieuTri_13_Array[i] = true;
                    else DieuTri_13_Array[i] = false;
                }
            }
        }
        public bool[] DieuTri_14_Array { get; } = new bool[] { false, false, false, false, false, false };
        public int DieuTri_14
        {
            get
            {
                return Array.IndexOf(DieuTri_14_Array, true) + 1;
            }
            set
            {
                for (int i = 0; i < DieuTri_14_Array.Length; i++)
                {
                    if (i == (value - 1)) DieuTri_14_Array[i] = true;
                    else DieuTri_14_Array[i] = false;
                }
            }
        }
        public bool[] DieuTri_15_Array { get; } = new bool[] { false, false, false, false, false, false };
        public int DieuTri_15
        {
            get
            {
                return Array.IndexOf(DieuTri_15_Array, true) + 1;
            }
            set
            {
                for (int i = 0; i < DieuTri_15_Array.Length; i++)
                {
                    if (i == (value - 1)) DieuTri_15_Array[i] = true;
                    else DieuTri_15_Array[i] = false;
                }
            }
        }
        public bool[] DieuTri_16_Array { get; } = new bool[] { false, false, false, false, false, false };
        public int DieuTri_16
        {
            get
            {
                return Array.IndexOf(DieuTri_16_Array, true) + 1;
            }
            set
            {
                for (int i = 0; i < DieuTri_16_Array.Length; i++)
                {
                    if (i == (value - 1)) DieuTri_16_Array[i] = true;
                    else DieuTri_16_Array[i] = false;
                }
            }
        }
        public bool[] DieuTri_17_Array { get; } = new bool[] { false, false, false, false, false, false };
        public int DieuTri_17
        {
            get
            {
                return Array.IndexOf(DieuTri_17_Array, true) + 1;
            }
            set
            {
                for (int i = 0; i < DieuTri_17_Array.Length; i++)
                {
                    if (i == (value - 1)) DieuTri_17_Array[i] = true;
                    else DieuTri_17_Array[i] = false;
                }
            }
        }
        public bool[] DieuTri_18_Array { get; } = new bool[] { false, false, false, false, false, false };
        public int DieuTri_18
        {
            get
            {
                return Array.IndexOf(DieuTri_18_Array, true) + 1;
            }
            set
            {
                for (int i = 0; i < DieuTri_18_Array.Length; i++)
                {
                    if (i == (value - 1)) DieuTri_18_Array[i] = true;
                    else DieuTri_18_Array[i] = false;
                }
            }
        }
        public bool[] DieuTri_19_Array { get; } = new bool[] { false, false, false, false, false, false };
        public int DieuTri_19
        {
            get
            {
                return Array.IndexOf(DieuTri_19_Array, true) + 1;
            }
            set
            {
                for (int i = 0; i < DieuTri_19_Array.Length; i++)
                {
                    if (i == (value - 1)) DieuTri_19_Array[i] = true;
                    else DieuTri_19_Array[i] = false;
                }
            }
        }
        public bool[] DieuTri_20_Array { get; } = new bool[] { false, false, false, false, false, false };
        public int DieuTri_20
        {
            get
            {
                return Array.IndexOf(DieuTri_20_Array, true) + 1;
            }
            set
            {
                for (int i = 0; i < DieuTri_20_Array.Length; i++)
                {
                    if (i == (value - 1)) DieuTri_20_Array[i] = true;
                    else DieuTri_20_Array[i] = false;
                }
            }
        }
        public bool[] DieuTri_21_Array { get; } = new bool[] { false, false, false, false, false, false };
        public int DieuTri_21
        {
            get
            {
                return Array.IndexOf(DieuTri_21_Array, true) + 1;
            }
            set
            {
                for (int i = 0; i < DieuTri_21_Array.Length; i++)
                {
                    if (i == (value - 1)) DieuTri_21_Array[i] = true;
                    else DieuTri_21_Array[i] = false;
                }
            }
        }
        public string DieuTri_22_Text { get; set; }
        public string DieuTri_23_Text { get; set; }
        public string DieuTri_24_Text { get; set; }
        public bool[] DieuTri_25_Array { get; } = new bool[] { false, false, false, false, false, false };
        public int DieuTri_25
        {
            get
            {
                return Array.IndexOf(DieuTri_25_Array, true) + 1;
            }
            set
            {
                for (int i = 0; i < DieuTri_25_Array.Length; i++)
                {
                    if (i == (value - 1)) DieuTri_25_Array[i] = true;
                    else DieuTri_25_Array[i] = false;
                }
            }
        }
        public bool[] DieuTri_26_Array { get; } = new bool[] { false, false, false, false, false, false };
        public int DieuTri_26
        {
            get
            {
                return Array.IndexOf(DieuTri_26_Array, true) + 1;
            }
            set
            {
                for (int i = 0; i < DieuTri_26_Array.Length; i++)
                {
                    if (i == (value - 1)) DieuTri_26_Array[i] = true;
                    else DieuTri_26_Array[i] = false;
                }
            }
        }
        public bool[] DieuTri_27_Array { get; } = new bool[] { false, false, false, false, false, false };
        public int DieuTri_27
        {
            get
            {
                return Array.IndexOf(DieuTri_27_Array, true) + 1;
            }
            set
            {
                for (int i = 0; i < DieuTri_27_Array.Length; i++)
                {
                    if (i == (value - 1)) DieuTri_27_Array[i] = true;
                    else DieuTri_27_Array[i] = false;
                }
            }
        }
        public string DieuTri_28_Text { get; set; }
        public string DieuTri_29_Text { get; set; }

        public string NgayThang_L1 { get; set; }
        public string NgayThang_L2 { get; set; }
        public string NgayThang_L3 { get; set; }
        public string NgayThang_L4 { get; set; }
        public string NgayThang_L5 { get; set; }
        public string NgayThang_L6 { get; set; }
        public string NgayThang_L7 { get; set; }
        public string NgayThang_L8 { get; set; }
        public string NgayThang_L9 { get; set; }
        public string NgayThang_L10 { get; set; }
        public string NgayThang_GhiChu { get; set; }

        public int TayTrang_L1 { get; set; }
        public int TayTrang_L2 { get; set; }
        public int TayTrang_L3 { get; set; }
        public int TayTrang_L4 { get; set; }
        public int TayTrang_L5 { get; set; }
        public int TayTrang_L6 { get; set; }
        public int TayTrang_L7 { get; set; }
        public int TayTrang_L8 { get; set; }
        public int TayTrang_L9 { get; set; }
        public int TayTrang_L10 { get; set; }
        public string TayTrang_GhiChu { get; set; }

        public int RuaMat_L1 { get; set; }
        public int RuaMat_L2 { get; set; }
        public int RuaMat_L3 { get; set; }
        public int RuaMat_L4 { get; set; }
        public int RuaMat_L5 { get; set; }
        public int RuaMat_L6 { get; set; }
        public int RuaMat_L7 { get; set; }
        public int RuaMat_L8 { get; set; }
        public int RuaMat_L9 { get; set; }
        public int RuaMat_L10 { get; set; }
        public string RuaMat_GhiChu { get; set; }
        public int CanBang1_L1 { get; set; }
        public int CanBang1_L2 { get; set; }
        public int CanBang1_L3 { get; set; }
        public int CanBang1_L4 { get; set; }
        public int CanBang1_L5 { get; set; }
        public int CanBang1_L6 { get; set; }
        public int CanBang1_L7 { get; set; }
        public int CanBang1_L8 { get; set; }
        public int CanBang1_L9 { get; set; }
        public int CanBang1_L10 { get; set; }
        public string CanBang1_GhiChu { get; set; }
        public int TayTBChet_L1 { get; set; }
        public int TayTBChet_L2 { get; set; }
        public int TayTBChet_L3 { get; set; }
        public int TayTBChet_L4 { get; set; }
        public int TayTBChet_L5 { get; set; }
        public int TayTBChet_L6 { get; set; }
        public int TayTBChet_L7 { get; set; }
        public int TayTBChet_L8 { get; set; }
        public int TayTBChet_L9 { get; set; }
        public int TayTBChet_L10 { get; set; }
        public string TayTBChet_GhiChu { get; set; }
        public int CanBang2_L1 { get; set; }
        public int CanBang2_L2 { get; set; }
        public int CanBang2_L3 { get; set; }
        public int CanBang2_L4 { get; set; }
        public int CanBang2_L5 { get; set; }
        public int CanBang2_L6 { get; set; }
        public int CanBang2_L7 { get; set; }
        public int CanBang2_L8 { get; set; }
        public int CanBang2_L9 { get; set; }
        public int CanBang2_L10 { get; set; }
        public string CanBang2_GhiChu { get; set; }
        public int XongHoi1_L1 { get; set; }
        public int XongHoi1_L2 { get; set; }
        public int XongHoi1_L3 { get; set; }
        public int XongHoi1_L4 { get; set; }
        public int XongHoi1_L5 { get; set; }
        public int XongHoi1_L6 { get; set; }
        public int XongHoi1_L7 { get; set; }
        public int XongHoi1_L8 { get; set; }
        public int XongHoi1_L9 { get; set; }
        public int XongHoi1_L10 { get; set; }
        public string XongHoi1_GhiChu { get; set; }
        public int Massage_L1 { get; set; }
        public int Massage_L2 { get; set; }
        public int Massage_L3 { get; set; }
        public int Massage_L4 { get; set; }
        public int Massage_L5 { get; set; }
        public int Massage_L6 { get; set; }
        public int Massage_L7 { get; set; }
        public int Massage_L8 { get; set; }
        public int Massage_L9 { get; set; }
        public int Massage_L10 { get; set; }
        public string Massage_GhiChu { get; set; }
        public int XitKhoang_L1 { get; set; }
        public int XitKhoang_L2 { get; set; }
        public int XitKhoang_L3 { get; set; }
        public int XitKhoang_L4 { get; set; }
        public int XitKhoang_L5 { get; set; }
        public int XitKhoang_L6 { get; set; }
        public int XitKhoang_L7 { get; set; }
        public int XitKhoang_L8 { get; set; }
        public int XitKhoang_L9 { get; set; }
        public int XitKhoang_L10 { get; set; }
        public string XitKhoang_GhiChu { get; set; }
        public int ChayMay_L1 { get; set; }
        public int ChayMay_L2 { get; set; }
        public int ChayMay_L3 { get; set; }
        public int ChayMay_L4 { get; set; }
        public int ChayMay_L5 { get; set; }
        public int ChayMay_L6 { get; set; }
        public int ChayMay_L7 { get; set; }
        public int ChayMay_L8 { get; set; }
        public int ChayMay_L9 { get; set; }
        public int ChayMay_L10 { get; set; }
        public string ChayMay_GhiChu { get; set; }
        public int DapMat_L1 { get; set; }
        public int DapMat_L2 { get; set; }
        public int DapMat_L3 { get; set; }
        public int DapMat_L4 { get; set; }
        public int DapMat_L5 { get; set; }
        public int DapMat_L6 { get; set; }
        public int DapMat_L7 { get; set; }
        public int DapMat_L8 { get; set; }
        public int DapMat_L9 { get; set; }
        public int DapMat_L10 { get; set; }
        public string DapMat_GhiChu { get; set; }
        public int XongHoi2_L1 { get; set; }
        public int XongHoi2_L2 { get; set; }
        public int XongHoi2_L3 { get; set; }
        public int XongHoi2_L4 { get; set; }
        public int XongHoi2_L5 { get; set; }
        public int XongHoi2_L6 { get; set; }
        public int XongHoi2_L7 { get; set; }
        public int XongHoi2_L8 { get; set; }
        public int XongHoi2_L9 { get; set; }
        public int XongHoi2_L10 { get; set; }
        public string XongHoi2_GhiChu { get; set; }
        public int DuongDa_L1 { get; set; }
        public int DuongDa_L2 { get; set; }
        public int DuongDa_L3 { get; set; }
        public int DuongDa_L4 { get; set; }
        public int DuongDa_L5 { get; set; }
        public int DuongDa_L6 { get; set; }
        public int DuongDa_L7 { get; set; }
        public int DuongDa_L8 { get; set; }
        public int DuongDa_L9 { get; set; }
        public int DuongDa_L10 { get; set; }
        public string DuongDa_GhiChu { get; set; }
        public int ChongNang_L1 { get; set; }
        public int ChongNang_L2 { get; set; }
        public int ChongNang_L3 { get; set; }
        public int ChongNang_L4 { get; set; }
        public int ChongNang_L5 { get; set; }
        public int ChongNang_L6 { get; set; }
        public int ChongNang_L7 { get; set; }
        public int ChongNang_L8 { get; set; }
        public int ChongNang_L9 { get; set; }
        public int ChongNang_L10 { get; set; }
        public string ChongNang_GhiChu { get; set; }
        public string BacSiCDL1 { get; set; }
        public string BacSiCDL2 { get; set; }
        public string BacSiCDL3 { get; set; }
        public string BacSiCDL4 { get; set; }
        public string BacSiCDL5 { get; set; }
        public string BacSiCDL6 { get; set; }
        public string BacSiCDL7 { get; set; }
        public string BacSiCDL8 { get; set; }
        public string BacSiCDL9 { get; set; }
        public string BacSiCDL10 { get; set; }
        public string BacSiCD_GhiChu { get; set; }
        public string MaBacSiCDL1 { get; set; }
        public string MaBacSiCDL2 { get; set; }
        public string MaBacSiCDL3 { get; set; }
        public string MaBacSiCDL4 { get; set; }
        public string MaBacSiCDL5 { get; set; }
        public string MaBacSiCDL6 { get; set; }
        public string MaBacSiCDL7 { get; set; }
        public string MaBacSiCDL8 { get; set; }
        public string MaBacSiCDL9 { get; set; }
        public string MaBacSiCDL10 { get; set; }
        public string KTVL1 { get; set; }
        public string KTVL2 { get; set; }
        public string KTVL3 { get; set; }
        public string KTVL4 { get; set; }
        public string KTVL5 { get; set; }
        public string KTVL6 { get; set; }
        public string KTVL7 { get; set; }
        public string KTVL8 { get; set; }
        public string KTVL9 { get; set; }
        public string KTVL10 { get; set; }
        public string KTV_GhiChu { get; set; }
        public string MaKTVL1 { get; set; }
        public string MaKTVL2 { get; set; }
        public string MaKTVL3 { get; set; }
        public string MaKTVL4 { get; set; }
        public string MaKTVL5 { get; set; }
        public string MaKTVL6 { get; set; }
        public string MaKTVL7 { get; set; }
        public string MaKTVL8 { get; set; }
        public string MaKTVL9 { get; set; }
        public string MaKTVL10 { get; set; }
        [MoTaDuLieu("Người tạo", null, 0, 0)]
		public string NguoiTao { get; set; }
        [MoTaDuLieu("Người sửa", null, 0, 0)]
		public string NguoiSua { get; set; }
        [MoTaDuLieu("Ngày tạo", null, 0, 0)]
		public DateTime NgayTao { get; set; }
        [MoTaDuLieu("Ngày sửa", null, 0, 0)]
		public DateTime NgaySua { get; set; }
        [MoTaDuLieu("Chọn", null, 0, 0)]
		public bool Chon { get; set; }
        //public string MaSoKyTen { get; set; }
        [MoTaDuLieu("Đã ký", null, 0, 0)]
		public bool DaKy { get; set; }
    }


    public class PhieuSanSocDaKhoaLaserFunc
    {
        public const string TableName = "PhieuSanSocDaKhoaLaser";
        public const string TablePrimaryKeyName = "ID";

        public static List<PhieuSanSocDaKhoaLaser> GetListData(MDB.MDBConnection _OracleConnection, decimal maquanly)
        {
            List<PhieuSanSocDaKhoaLaser> list = new List<PhieuSanSocDaKhoaLaser>();
            try
            {
                string sql = @"SELECT * FROM PhieuSanSocDaKhoaLaser where MaQuanLy = :MaQuanLy";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, _OracleConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", maquanly));
                MDB.MDBDataReader DataReader = Command.ExecuteReader();
                while (DataReader.Read())
                {
                    PhieuSanSocDaKhoaLaser data = new PhieuSanSocDaKhoaLaser();
                    data.ID = Convert.ToInt64(DataReader.GetLong("ID").ToString());
                    data.MaQuanLy = maquanly;

                    data.MaBenhNhan = XemBenhAn._HanhChinhBenhNhan.MaBenhNhan;
                    data.TenBenhNhan = XemBenhAn._HanhChinhBenhNhan.TenBenhNhan;
                    data.NamSinh = XemBenhAn._HanhChinhBenhNhan.Tuoi;
                    data.GioiTinh = XemBenhAn._HanhChinhBenhNhan.GioiTinh.Description();
                    data.Khoa = XemBenhAn._ThongTinDieuTri.Khoa;

                    data.DiaChi = DataReader["DiaChi"].ToString();
                    data.NgheNghiep = DataReader["NgheNghiep"].ToString();
                    data.DienThoai = DataReader["DienThoai"].ToString();
                    data.BoMe = DataReader["BoMe"].ToString();

                    data.DieuTri_1 = DataReader.GetInt("DieuTri_1");
                    data.DieuTri_1_Text = DataReader["DieuTri_1_Text"].ToString();
                    data.DieuTri_2 = DataReader.GetInt("DieuTri_2");
                    data.DieuTri_3 = DataReader.GetInt("DieuTri_3");
                    data.DieuTri_4 = DataReader.GetInt("DieuTri_4");
                    data.DieuTri_4_Text = DataReader["DieuTri_4_Text"].ToString();
                    data.DieuTri_5 = DataReader.GetInt("DieuTri_5");
                    data.DieuTri_6 = DataReader.GetInt("DieuTri_6");
                    data.DieuTri_7 = DataReader.GetInt("DieuTri_7");
                    data.DieuTri_7_Text = DataReader["DieuTri_7_Text"].ToString();
                    data.DieuTri_8 = DataReader.GetInt("DieuTri_8");
                    data.DieuTri_9_Text = DataReader["DieuTri_9_Text"].ToString();

                    data.DieuTri_10 = DataReader.GetInt("DieuTri_10");
                    data.DieuTri_11 = DataReader.GetInt("DieuTri_11");
                    data.DieuTri_12 = DataReader.GetInt("DieuTri_12");
                    data.DieuTri_13 = DataReader.GetInt("DieuTri_13");
                    data.DieuTri_14 = DataReader.GetInt("DieuTri_14");
                    data.DieuTri_15 = DataReader.GetInt("DieuTri_15");
                    data.DieuTri_16 = DataReader.GetInt("DieuTri_16");
                    data.DieuTri_17 = DataReader.GetInt("DieuTri_17");
                    data.DieuTri_18 = DataReader.GetInt("DieuTri_18");
                    data.DieuTri_19 = DataReader.GetInt("DieuTri_19");
                    data.DieuTri_20 = DataReader.GetInt("DieuTri_20");
                    data.DieuTri_21 = DataReader.GetInt("DieuTri_21");
                    data.DieuTri_22_Text = DataReader["DieuTri_22_Text"].ToString();
                    data.DieuTri_23_Text = DataReader["DieuTri_23_Text"].ToString();
                    data.DieuTri_24_Text = DataReader["DieuTri_24_Text"].ToString();
                    data.DieuTri_25 = DataReader.GetInt("DieuTri_25");
                    data.DieuTri_26 = DataReader.GetInt("DieuTri_26");
                    data.DieuTri_27 = DataReader.GetInt("DieuTri_27");
                    data.DieuTri_28_Text = DataReader["DieuTri_28_Text"].ToString();
                    data.DieuTri_29_Text = DataReader["DieuTri_29_Text"].ToString();

                    data.NgayThang_L1 = DataReader["NgayThang_L1"].ToString();
                    data.NgayThang_L2 = DataReader["NgayThang_L2"].ToString();
                    data.NgayThang_L3 = DataReader["NgayThang_L3"].ToString();
                    data.NgayThang_L4 = DataReader["NgayThang_L4"].ToString();
                    data.NgayThang_L5 = DataReader["NgayThang_L5"].ToString();
                    data.NgayThang_L6 = DataReader["NgayThang_L6"].ToString();
                    data.NgayThang_L7 = DataReader["NgayThang_L7"].ToString();
                    data.NgayThang_L8 = DataReader["NgayThang_L8"].ToString();
                    data.NgayThang_L9 = DataReader["NgayThang_L9"].ToString();
                    data.NgayThang_L10 = DataReader["NgayThang_L10"].ToString();
                    data.NgayThang_GhiChu = DataReader["NgayThang_GhiChu"].ToString();

                    data.TayTrang_L1 = DataReader.GetInt("TayTrang_L1");
                    data.TayTrang_L2 = DataReader.GetInt("TayTrang_L2");
                    data.TayTrang_L3 = DataReader.GetInt("TayTrang_L3");
                    data.TayTrang_L4 = DataReader.GetInt("TayTrang_L4");
                    data.TayTrang_L5 = DataReader.GetInt("TayTrang_L5");
                    data.TayTrang_L6 = DataReader.GetInt("TayTrang_L6");
                    data.TayTrang_L7 = DataReader.GetInt("TayTrang_L7");
                    data.TayTrang_L8 = DataReader.GetInt("TayTrang_L8");
                    data.TayTrang_L9 = DataReader.GetInt("TayTrang_L9");
                    data.TayTrang_L10 = DataReader.GetInt("TayTrang_L10");
                    data.TayTrang_GhiChu = DataReader["TayTrang_GhiChu"].ToString();

                    data.RuaMat_L1 = DataReader.GetInt("RuaMat_L1");
                    data.RuaMat_L2 = DataReader.GetInt("RuaMat_L2");
                    data.RuaMat_L3 = DataReader.GetInt("RuaMat_L3");
                    data.RuaMat_L4 = DataReader.GetInt("RuaMat_L4");
                    data.RuaMat_L5 = DataReader.GetInt("RuaMat_L5");
                    data.RuaMat_L6 = DataReader.GetInt("RuaMat_L6");
                    data.RuaMat_L7 = DataReader.GetInt("RuaMat_L7");
                    data.RuaMat_L8 = DataReader.GetInt("RuaMat_L8");
                    data.RuaMat_L9 = DataReader.GetInt("RuaMat_L9");
                    data.RuaMat_L10 = DataReader.GetInt("RuaMat_L10");
                    data.RuaMat_GhiChu = DataReader["RuaMat_GhiChu"].ToString();

                    data.CanBang1_L1 = DataReader.GetInt("CanBang1_L1");
                    data.CanBang1_L2 = DataReader.GetInt("CanBang1_L2");
                    data.CanBang1_L3 = DataReader.GetInt("CanBang1_L3");
                    data.CanBang1_L4 = DataReader.GetInt("CanBang1_L4");
                    data.CanBang1_L5 = DataReader.GetInt("CanBang1_L5");
                    data.CanBang1_L6 = DataReader.GetInt("CanBang1_L6");
                    data.CanBang1_L7 = DataReader.GetInt("CanBang1_L7");
                    data.CanBang1_L8 = DataReader.GetInt("CanBang1_L8");
                    data.CanBang1_L9 = DataReader.GetInt("CanBang1_L9");
                    data.CanBang1_L10 = DataReader.GetInt("CanBang1_L10");
                    data.CanBang1_GhiChu = DataReader["CanBang1_GhiChu"].ToString();

                    data.TayTBChet_L1 = DataReader.GetInt("TayTBChet_L1");
                    data.TayTBChet_L2 = DataReader.GetInt("TayTBChet_L2");
                    data.TayTBChet_L3 = DataReader.GetInt("TayTBChet_L3");
                    data.TayTBChet_L4 = DataReader.GetInt("TayTBChet_L4");
                    data.TayTBChet_L5 = DataReader.GetInt("TayTBChet_L5");
                    data.TayTBChet_L6 = DataReader.GetInt("TayTBChet_L6");
                    data.TayTBChet_L7 = DataReader.GetInt("TayTBChet_L7");
                    data.TayTBChet_L8 = DataReader.GetInt("TayTBChet_L8");
                    data.TayTBChet_L9 = DataReader.GetInt("TayTBChet_L9");
                    data.TayTBChet_L10 = DataReader.GetInt("TayTBChet_L10");
                    data.TayTBChet_GhiChu = DataReader["TayTBChet_GhiChu"].ToString();

                    data.CanBang2_L1 = DataReader.GetInt("CanBang2_L1");
                    data.CanBang2_L2 = DataReader.GetInt("CanBang2_L2");
                    data.CanBang2_L3 = DataReader.GetInt("CanBang2_L3");
                    data.CanBang2_L4 = DataReader.GetInt("CanBang2_L4");
                    data.CanBang2_L5 = DataReader.GetInt("CanBang2_L5");
                    data.CanBang2_L6 = DataReader.GetInt("CanBang2_L6");
                    data.CanBang2_L7 = DataReader.GetInt("CanBang2_L7");
                    data.CanBang2_L8 = DataReader.GetInt("CanBang2_L8");
                    data.CanBang2_L9 = DataReader.GetInt("CanBang2_L9");
                    data.CanBang2_L10 = DataReader.GetInt("CanBang2_L10");
                    data.CanBang2_GhiChu = DataReader["CanBang2_GhiChu"].ToString();

                    data.XongHoi1_L1 = DataReader.GetInt("XongHoi1_L1");
                    data.XongHoi1_L2 = DataReader.GetInt("XongHoi1_L2");
                    data.XongHoi1_L3 = DataReader.GetInt("XongHoi1_L3");
                    data.XongHoi1_L4 = DataReader.GetInt("XongHoi1_L4");
                    data.XongHoi1_L5 = DataReader.GetInt("XongHoi1_L5");
                    data.XongHoi1_L6 = DataReader.GetInt("XongHoi1_L6");
                    data.XongHoi1_L7 = DataReader.GetInt("XongHoi1_L7");
                    data.XongHoi1_L8 = DataReader.GetInt("XongHoi1_L8");
                    data.XongHoi1_L9 = DataReader.GetInt("XongHoi1_L9");
                    data.XongHoi1_L10 = DataReader.GetInt("XongHoi1_L10");
                    data.XongHoi1_GhiChu = DataReader["XongHoi1_GhiChu"].ToString();

                    data.Massage_L1 = DataReader.GetInt("Massage_L1");
                    data.Massage_L2 = DataReader.GetInt("Massage_L2");
                    data.Massage_L3 = DataReader.GetInt("Massage_L3");
                    data.Massage_L4 = DataReader.GetInt("Massage_L4");
                    data.Massage_L5 = DataReader.GetInt("Massage_L5");
                    data.Massage_L6 = DataReader.GetInt("Massage_L6");
                    data.Massage_L7 = DataReader.GetInt("Massage_L7");
                    data.Massage_L8 = DataReader.GetInt("Massage_L8");
                    data.Massage_L9 = DataReader.GetInt("Massage_L9");
                    data.Massage_L10 = DataReader.GetInt("Massage_L10");
                    data.Massage_GhiChu = DataReader["Massage_GhiChu"].ToString();

                    data.XitKhoang_L1 = DataReader.GetInt("XitKhoang_L1");
                    data.XitKhoang_L2 = DataReader.GetInt("XitKhoang_L2");
                    data.XitKhoang_L3 = DataReader.GetInt("XitKhoang_L3");
                    data.XitKhoang_L4 = DataReader.GetInt("XitKhoang_L4");
                    data.XitKhoang_L5 = DataReader.GetInt("XitKhoang_L5");
                    data.XitKhoang_L6 = DataReader.GetInt("XitKhoang_L6");
                    data.XitKhoang_L7 = DataReader.GetInt("XitKhoang_L7");
                    data.XitKhoang_L8 = DataReader.GetInt("XitKhoang_L8");
                    data.XitKhoang_L9 = DataReader.GetInt("XitKhoang_L9");
                    data.XitKhoang_L10 = DataReader.GetInt("XitKhoang_L10");
                    data.XitKhoang_GhiChu = DataReader["XitKhoang_GhiChu"].ToString();

                    data.ChayMay_L1 = DataReader.GetInt("ChayMay_L1");
                    data.ChayMay_L2 = DataReader.GetInt("ChayMay_L2");
                    data.ChayMay_L3 = DataReader.GetInt("ChayMay_L3");
                    data.ChayMay_L4 = DataReader.GetInt("ChayMay_L4");
                    data.ChayMay_L5 = DataReader.GetInt("ChayMay_L5");
                    data.ChayMay_L6 = DataReader.GetInt("ChayMay_L6");
                    data.ChayMay_L7 = DataReader.GetInt("ChayMay_L7");
                    data.ChayMay_L8 = DataReader.GetInt("ChayMay_L8");
                    data.ChayMay_L9 = DataReader.GetInt("ChayMay_L9");
                    data.ChayMay_L10 = DataReader.GetInt("ChayMay_L10");
                    data.ChayMay_GhiChu = DataReader["ChayMay_GhiChu"].ToString();

                    data.DapMat_L1 = DataReader.GetInt("DapMat_L1");
                    data.DapMat_L2 = DataReader.GetInt("DapMat_L2");
                    data.DapMat_L3 = DataReader.GetInt("DapMat_L3");
                    data.DapMat_L4 = DataReader.GetInt("DapMat_L4");
                    data.DapMat_L5 = DataReader.GetInt("DapMat_L5");
                    data.DapMat_L6 = DataReader.GetInt("DapMat_L6");
                    data.DapMat_L7 = DataReader.GetInt("DapMat_L7");
                    data.DapMat_L8 = DataReader.GetInt("DapMat_L8");
                    data.DapMat_L9 = DataReader.GetInt("DapMat_L9");
                    data.DapMat_L10 = DataReader.GetInt("DapMat_L10");
                    data.DapMat_GhiChu = DataReader["DapMat_GhiChu"].ToString();

                    data.XongHoi2_L1 = DataReader.GetInt("XongHoi2_L1");
                    data.XongHoi2_L2 = DataReader.GetInt("XongHoi2_L2");
                    data.XongHoi2_L3 = DataReader.GetInt("XongHoi2_L3");
                    data.XongHoi2_L4 = DataReader.GetInt("XongHoi2_L4");
                    data.XongHoi2_L5 = DataReader.GetInt("XongHoi2_L5");
                    data.XongHoi2_L6 = DataReader.GetInt("XongHoi2_L6");
                    data.XongHoi2_L7 = DataReader.GetInt("XongHoi2_L7");
                    data.XongHoi2_L8 = DataReader.GetInt("XongHoi2_L8");
                    data.XongHoi2_L9 = DataReader.GetInt("XongHoi2_L9");
                    data.XongHoi2_L10 = DataReader.GetInt("XongHoi2_L10");
                    data.XongHoi2_GhiChu = DataReader["XongHoi2_GhiChu"].ToString();

                    data.DuongDa_L1 = DataReader.GetInt("DuongDa_L1");
                    data.DuongDa_L2 = DataReader.GetInt("DuongDa_L2");
                    data.DuongDa_L3 = DataReader.GetInt("DuongDa_L3");
                    data.DuongDa_L4 = DataReader.GetInt("DuongDa_L4");
                    data.DuongDa_L5 = DataReader.GetInt("DuongDa_L5");
                    data.DuongDa_L6 = DataReader.GetInt("DuongDa_L6");
                    data.DuongDa_L7 = DataReader.GetInt("DuongDa_L7");
                    data.DuongDa_L8 = DataReader.GetInt("DuongDa_L8");
                    data.DuongDa_L9 = DataReader.GetInt("DuongDa_L9");
                    data.DuongDa_L10 = DataReader.GetInt("DuongDa_L10");
                    data.DuongDa_GhiChu = DataReader["DuongDa_GhiChu"].ToString();

                    data.ChongNang_L1 = DataReader.GetInt("ChongNang_L1");
                    data.ChongNang_L2 = DataReader.GetInt("ChongNang_L2");
                    data.ChongNang_L3 = DataReader.GetInt("ChongNang_L3");
                    data.ChongNang_L4 = DataReader.GetInt("ChongNang_L4");
                    data.ChongNang_L5 = DataReader.GetInt("ChongNang_L5");
                    data.ChongNang_L6 = DataReader.GetInt("ChongNang_L6");
                    data.ChongNang_L7 = DataReader.GetInt("ChongNang_L7");
                    data.ChongNang_L8 = DataReader.GetInt("ChongNang_L8");
                    data.ChongNang_L9 = DataReader.GetInt("ChongNang_L9");
                    data.ChongNang_L10 = DataReader.GetInt("ChongNang_L10");
                    data.ChongNang_GhiChu = DataReader["ChongNang_GhiChu"].ToString();

                    data.BacSiCDL1 = DataReader["BacSiCDL1"].ToString();
                    data.BacSiCDL2 = DataReader["BacSiCDL2"].ToString();
                    data.BacSiCDL3 = DataReader["BacSiCDL3"].ToString();
                    data.BacSiCDL4 = DataReader["BacSiCDL4"].ToString();
                    data.BacSiCDL5 = DataReader["BacSiCDL5"].ToString();
                    data.BacSiCDL6 = DataReader["BacSiCDL6"].ToString();
                    data.BacSiCDL7 = DataReader["BacSiCDL7"].ToString();
                    data.BacSiCDL8 = DataReader["BacSiCDL8"].ToString();
                    data.BacSiCDL9 = DataReader["BacSiCDL9"].ToString();
                    data.BacSiCDL10 = DataReader["BacSiCDL10"].ToString();
                    data.BacSiCD_GhiChu = DataReader["BacSiCD_GhiChu"].ToString();
                    data.MaBacSiCDL1 = DataReader["MaBacSiCDL1"].ToString();
                    data.MaBacSiCDL2 = DataReader["MaBacSiCDL2"].ToString();
                    data.MaBacSiCDL3 = DataReader["MaBacSiCDL3"].ToString();
                    data.MaBacSiCDL4 = DataReader["MaBacSiCDL4"].ToString();
                    data.MaBacSiCDL5 = DataReader["MaBacSiCDL5"].ToString();
                    data.MaBacSiCDL6 = DataReader["MaBacSiCDL6"].ToString();
                    data.MaBacSiCDL7 = DataReader["MaBacSiCDL7"].ToString();
                    data.MaBacSiCDL8 = DataReader["MaBacSiCDL8"].ToString();
                    data.MaBacSiCDL9 = DataReader["MaBacSiCDL9"].ToString();
                    data.MaBacSiCDL10 = DataReader["MaBacSiCDL10"].ToString();

                    data.KTVL1 = DataReader["KTVL1"].ToString();
                    data.KTVL2 = DataReader["KTVL2"].ToString();
                    data.KTVL3 = DataReader["KTVL3"].ToString();
                    data.KTVL4 = DataReader["KTVL4"].ToString();
                    data.KTVL5 = DataReader["KTVL5"].ToString();
                    data.KTVL6 = DataReader["KTVL6"].ToString();
                    data.KTVL7 = DataReader["KTVL7"].ToString();
                    data.KTVL8 = DataReader["KTVL8"].ToString();
                    data.KTVL9 = DataReader["KTVL9"].ToString();
                    data.KTVL10 = DataReader["KTVL10"].ToString();
                    data.KTV_GhiChu = DataReader["KTV_GhiChu"].ToString();
                    data.MaKTVL1 = DataReader["MaKTVL1"].ToString();
                    data.MaKTVL2 = DataReader["MaKTVL2"].ToString();
                    data.MaKTVL3 = DataReader["MaKTVL3"].ToString();
                    data.MaKTVL4 = DataReader["MaKTVL4"].ToString();
                    data.MaKTVL5 = DataReader["MaKTVL5"].ToString();
                    data.MaKTVL6 = DataReader["MaKTVL6"].ToString();
                    data.MaKTVL7 = DataReader["MaKTVL7"].ToString();
                    data.MaKTVL8 = DataReader["MaKTVL8"].ToString();
                    data.MaKTVL9 = DataReader["MaKTVL9"].ToString();
                    data.MaKTVL10 = DataReader["MaKTVL10"].ToString();

                    data.Ngay = Convert.ToDateTime(DataReader["Ngay"] == DBNull.Value ? DateTime.Now : DataReader["Ngay"]);

                    data.NgayTao = Convert.ToDateTime(DataReader["NGAYTAO"] == DBNull.Value ? DateTime.Now : DataReader["NGAYTAO"]);
                    data.NguoiTao = DataReader["NGUOITAO"].ToString();
                    data.NgaySua = Convert.ToDateTime(DataReader["NGAYSUA"] == DBNull.Value ? DateTime.Now : DataReader["NGAYSUA"]);
                    data.NguoiSua = DataReader["NGUOISUA"].ToString();

                    data.MaSoKy = DataReader["masokyten"].ToString();
                    data.DaKy = !string.IsNullOrEmpty(data.MaSoKy) ? true : false;
                    list.Add(data);
                }
            }
            catch (Exception ex) { XuLyLoi.Handle(ex); }
            return list;
        }
        public static bool DeleteByIDPhieu(MDB.MDBConnection oracleConnection, decimal IDBienBan)
        {
            try
            {
                string sql = "";
                MDB.MDBCommand oracleCommand;
                sql = @"DELETE FROM PhieuSanSocDaKhoaLaser WHERE ID =" + IDBienBan;
                using (oracleCommand = new MDB.MDBCommand(sql, oracleConnection))
                {
                    oracleCommand.ExecuteNonQuery();
                }
                return true;
            }
            catch (Exception ex)
            {
                XuLyLoi.LogError(ex);
            }
            return false;
        }
        public static DataSet GetDataSet(MDB.MDBConnection MyConnection, long IDBienBan)
        {
            string sql = @"SELECT
                P.* 
            FROM
                PhieuSanSocDaKhoaLaser P
            WHERE
                ID = " + IDBienBan;

            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
            MDB.MDBDataAdapter adt = new MDB.MDBDataAdapter(Command);
            var ds = new DataSet();

            adt.Fill(ds, "TB");

            ds.Tables[0].AddColumn("TenBenhNhan", typeof(string));
            ds.Tables[0].AddColumn("MaBenhNhan", typeof(string));
            ds.Tables[0].AddColumn("NamSinh", typeof(string));
            ds.Tables[0].AddColumn("GioiTinh", typeof(string));
            ds.Tables[0].AddColumn("Khoa", typeof(string));
            ds.Tables[0].AddColumn("BenhVien", typeof(string));
            ds.Tables[0].Rows[0]["TenBenhNhan"] = XemBenhAn._HanhChinhBenhNhan.TenBenhNhan;
            ds.Tables[0].Rows[0]["MaBenhNhan"] = XemBenhAn._HanhChinhBenhNhan.MaBenhNhan;
            ds.Tables[0].Rows[0]["NamSinh"] = XemBenhAn._HanhChinhBenhNhan.NgaySinh?.Year + "";
            ds.Tables[0].Rows[0]["GioiTinh"] = XemBenhAn._HanhChinhBenhNhan.GioiTinh.Description();
            ds.Tables[0].Rows[0]["Khoa"] = XemBenhAn._ThongTinDieuTri.Khoa;
            ds.Tables[0].Rows[0]["BenhVien"] = XemBenhAn._HanhChinhBenhNhan.BenhVien;

            return ds;
        }
        public static bool InsertOrUpdate(MDB.MDBConnection MyConnection, ref PhieuSanSocDaKhoaLaser ketQua)
        {
            try
            {
                string sql = @"INSERT INTO PhieuSanSocDaKhoaLaser
                (
                    MaQuanLy,
                    DiaChi,
                    NgheNghiep,
                    BoMe,
                    DienThoai,
                    Ngay,
                    DieuTri_1,
                    DieuTri_1_Text,
                    DieuTri_2,
                    DieuTri_3,
                    DieuTri_4,
                    DieuTri_4_Text,
                    DieuTri_5,
                    DieuTri_6,
                    DieuTri_7,
                    DieuTri_7_Text,
                    DieuTri_8,
                    DieuTri_9_Text,
                    DieuTri_10,
                    DieuTri_11,
                    DieuTri_12,
                    DieuTri_13,
                    DieuTri_14,
                    DieuTri_15,
                    DieuTri_16,
                    DieuTri_17,
                    DieuTri_18,
                    DieuTri_19,
                    DieuTri_20,
                    DieuTri_21,
                    DieuTri_22_Text,
                    DieuTri_23_Text,
                    DieuTri_24_Text,
                    DieuTri_25,
                    DieuTri_26,
                    DieuTri_27,
                    DieuTri_28_Text,
                    DieuTri_29_Text,
                    NgayThang_L1,
                    NgayThang_L2,
                    NgayThang_L3,
                    NgayThang_L4,
                    NgayThang_L5,
                    NgayThang_L6,
                    NgayThang_L7,
                    NgayThang_L8,
                    NgayThang_L9,
                    NgayThang_L10,
                    NgayThang_GhiChu,
                    TayTrang_L1,
                    TayTrang_L2,
                    TayTrang_L3,
                    TayTrang_L4,
                    TayTrang_L5,
                    TayTrang_L6,
                    TayTrang_L7,
                    TayTrang_L8,
                    TayTrang_L9,
                    TayTrang_L10,
                    TayTrang_GhiChu,
                    RuaMat_L1,
                    RuaMat_L2,
                    RuaMat_L3,
                    RuaMat_L4,
                    RuaMat_L5,
                    RuaMat_L6,
                    RuaMat_L7,
                    RuaMat_L8,
                    RuaMat_L9,
                    RuaMat_L10,
                    RuaMat_GhiChu,
                    CanBang1_L1,
                    CanBang1_L2,
                    CanBang1_L3,
                    CanBang1_L4,
                    CanBang1_L5,
                    CanBang1_L6,
                    CanBang1_L7,
                    CanBang1_L8,
                    CanBang1_L9,
                    CanBang1_L10,
                    CanBang1_GhiChu,
                    TayTBChet_L1,
                    TayTBChet_L2,
                    TayTBChet_L3,
                    TayTBChet_L4,
                    TayTBChet_L5,
                    TayTBChet_L6,
                    TayTBChet_L7,
                    TayTBChet_L8,
                    TayTBChet_L9,
                    TayTBChet_L10,
                    TayTBChet_GhiChu,
                    CanBang2_L1,
                    CanBang2_L2,
                    CanBang2_L3,
                    CanBang2_L4,
                    CanBang2_L5,
                    CanBang2_L6,
                    CanBang2_L7,
                    CanBang2_L8,
                    CanBang2_L9,
                    CanBang2_L10,
                    CanBang2_GhiChu,
                    XongHoi1_L1,
                    XongHoi1_L2,
                    XongHoi1_L3,
                    XongHoi1_L4,
                    XongHoi1_L5,
                    XongHoi1_L6,
                    XongHoi1_L7,
                    XongHoi1_L8,
                    XongHoi1_L9,
                    XongHoi1_L10,
                    XongHoi1_GhiChu,
                    Massage_L1,
                    Massage_L2,
                    Massage_L3,
                    Massage_L4,
                    Massage_L5,
                    Massage_L6,
                    Massage_L7,
                    Massage_L8,
                    Massage_L9,
                    Massage_L10,
                    Massage_GhiChu,
                    XitKhoang_L1,
                    XitKhoang_L2,
                    XitKhoang_L3,
                    XitKhoang_L4,
                    XitKhoang_L5,
                    XitKhoang_L6,
                    XitKhoang_L7,
                    XitKhoang_L8,
                    XitKhoang_L9,
                    XitKhoang_L10,
                    XitKhoang_GhiChu,
                    ChayMay_L1,
                    ChayMay_L2,
                    ChayMay_L3,
                    ChayMay_L4,
                    ChayMay_L5,
                    ChayMay_L6,
                    ChayMay_L7,
                    ChayMay_L8,
                    ChayMay_L9,
                    ChayMay_L10,
                    ChayMay_GhiChu,
                    DapMat_L1,
                    DapMat_L2,
                    DapMat_L3,
                    DapMat_L4,
                    DapMat_L5,
                    DapMat_L6,
                    DapMat_L7,
                    DapMat_L8,
                    DapMat_L9,
                    DapMat_L10,
                    DapMat_GhiChu,
                    XongHoi2_L1,
                    XongHoi2_L2,
                    XongHoi2_L3,
                    XongHoi2_L4,
                    XongHoi2_L5,
                    XongHoi2_L6,
                    XongHoi2_L7,
                    XongHoi2_L8,
                    XongHoi2_L9,
                    XongHoi2_L10,
                    XongHoi2_GhiChu,
                    DuongDa_L1,
                    DuongDa_L2,
                    DuongDa_L3,
                    DuongDa_L4,
                    DuongDa_L5,
                    DuongDa_L6,
                    DuongDa_L7,
                    DuongDa_L8,
                    DuongDa_L9,
                    DuongDa_L10,
                    DuongDa_GhiChu,
                    ChongNang_L1,
                    ChongNang_L2,
                    ChongNang_L3,
                    ChongNang_L4,
                    ChongNang_L5,
                    ChongNang_L6,
                    ChongNang_L7,
                    ChongNang_L8,
                    ChongNang_L9,
                    ChongNang_L10,
                    ChongNang_GhiChu,
                    BacSiCDL1,
                    BacSiCDL2,
                    BacSiCDL3,
                    BacSiCDL4,
                    BacSiCDL5,
                    BacSiCDL6,
                    BacSiCDL7,
                    BacSiCDL8,
                    BacSiCDL9,
                    BacSiCDL10,
                    BacSiCD_GhiChu,
                    MaBacSiCDL1,
                    MaBacSiCDL2,
                    MaBacSiCDL3,
                    MaBacSiCDL4,
                    MaBacSiCDL5,
                    MaBacSiCDL6,
                    MaBacSiCDL7,
                    MaBacSiCDL8,
                    MaBacSiCDL9,
                    MaBacSiCDL10,
                    KTVL1,
                    KTVL2,
                    KTVL3,
                    KTVL4,
                    KTVL5,
                    KTVL6,
                    KTVL7,
                    KTVL8,
                    KTVL9,
                    KTVL10,
                    KTV_GhiChu,
                    MaKTVL1,
                    MaKTVL2,
                    MaKTVL3,
                    MaKTVL4,
                    MaKTVL5,
                    MaKTVL6,
                    MaKTVL7,
                    MaKTVL8,
                    MaKTVL9,
                    MaKTVL10,
                    NGUOITAO,
                    NGUOISUA,
                    NGAYTAO,
                    NGAYSUA)  VALUES
                 (
				    :MaQuanLy,
                    :DiaChi,
                    :NgheNghiep,
                    :BoMe,
                    :DienThoai,
                    :Ngay,
                    :DieuTri_1,
                    :DieuTri_1_Text,
                    :DieuTri_2,
                    :DieuTri_3,
                    :DieuTri_4,
                    :DieuTri_4_Text,
                    :DieuTri_5,
                    :DieuTri_6,
                    :DieuTri_7,
                    :DieuTri_7_Text,
                    :DieuTri_8,
                    :DieuTri_9_Text,
                    :DieuTri_10,
                    :DieuTri_11,
                    :DieuTri_12,
                    :DieuTri_13,
                    :DieuTri_14,
                    :DieuTri_15,
                    :DieuTri_16,
                    :DieuTri_17,
                    :DieuTri_18,
                    :DieuTri_19,
                    :DieuTri_20,
                    :DieuTri_21,
                    :DieuTri_22_Text,
                    :DieuTri_23_Text,
                    :DieuTri_24_Text,
                    :DieuTri_25,
                    :DieuTri_26,
                    :DieuTri_27,
                    :DieuTri_28_Text,
                    :DieuTri_29_Text,
                    :NgayThang_L1,
                    :NgayThang_L2,
                    :NgayThang_L3,
                    :NgayThang_L4,
                    :NgayThang_L5,
                    :NgayThang_L6,
                    :NgayThang_L7,
                    :NgayThang_L8,
                    :NgayThang_L9,
                    :NgayThang_L10,
                    :NgayThang_GhiChu,
                    :TayTrang_L1,
                    :TayTrang_L2,
                    :TayTrang_L3,
                    :TayTrang_L4,
                    :TayTrang_L5,
                    :TayTrang_L6,
                    :TayTrang_L7,
                    :TayTrang_L8,
                    :TayTrang_L9,
                    :TayTrang_L10,
                    :TayTrang_GhiChu,
                    :RuaMat_L1,
                    :RuaMat_L2,
                    :RuaMat_L3,
                    :RuaMat_L4,
                    :RuaMat_L5,
                    :RuaMat_L6,
                    :RuaMat_L7,
                    :RuaMat_L8,
                    :RuaMat_L9,
                    :RuaMat_L10,
                    :RuaMat_GhiChu,
                    :CanBang1_L1,
                    :CanBang1_L2,
                    :CanBang1_L3,
                    :CanBang1_L4,
                    :CanBang1_L5,
                    :CanBang1_L6,
                    :CanBang1_L7,
                    :CanBang1_L8,
                    :CanBang1_L9,
                    :CanBang1_L10,
                    :CanBang1_GhiChu,
                    :TayTBChet_L1,
                    :TayTBChet_L2,
                    :TayTBChet_L3,
                    :TayTBChet_L4,
                    :TayTBChet_L5,
                    :TayTBChet_L6,
                    :TayTBChet_L7,
                    :TayTBChet_L8,
                    :TayTBChet_L9,
                    :TayTBChet_L10,
                    :TayTBChet_GhiChu,
                    :CanBang2_L1,
                    :CanBang2_L2,
                    :CanBang2_L3,
                    :CanBang2_L4,
                    :CanBang2_L5,
                    :CanBang2_L6,
                    :CanBang2_L7,
                    :CanBang2_L8,
                    :CanBang2_L9,
                    :CanBang2_L10,
                    :CanBang2_GhiChu,
                    :XongHoi1_L1,
                    :XongHoi1_L2,
                    :XongHoi1_L3,
                    :XongHoi1_L4,
                    :XongHoi1_L5,
                    :XongHoi1_L6,
                    :XongHoi1_L7,
                    :XongHoi1_L8,
                    :XongHoi1_L9,
                    :XongHoi1_L10,
                    :XongHoi1_GhiChu,
                    :Massage_L1,
                    :Massage_L2,
                    :Massage_L3,
                    :Massage_L4,
                    :Massage_L5,
                    :Massage_L6,
                    :Massage_L7,
                    :Massage_L8,
                    :Massage_L9,
                    :Massage_L10,
                    :Massage_GhiChu,
                    :XitKhoang_L1,
                    :XitKhoang_L2,
                    :XitKhoang_L3,
                    :XitKhoang_L4,
                    :XitKhoang_L5,
                    :XitKhoang_L6,
                    :XitKhoang_L7,
                    :XitKhoang_L8,
                    :XitKhoang_L9,
                    :XitKhoang_L10,
                    :XitKhoang_GhiChu,
                    :ChayMay_L1,
                    :ChayMay_L2,
                    :ChayMay_L3,
                    :ChayMay_L4,
                    :ChayMay_L5,
                    :ChayMay_L6,
                    :ChayMay_L7,
                    :ChayMay_L8,
                    :ChayMay_L9,
                    :ChayMay_L10,
                    :ChayMay_GhiChu,
                    :DapMat_L1,
                    :DapMat_L2,
                    :DapMat_L3,
                    :DapMat_L4,
                    :DapMat_L5,
                    :DapMat_L6,
                    :DapMat_L7,
                    :DapMat_L8,
                    :DapMat_L9,
                    :DapMat_L10,
                    :DapMat_GhiChu,
                    :XongHoi2_L1,
                    :XongHoi2_L2,
                    :XongHoi2_L3,
                    :XongHoi2_L4,
                    :XongHoi2_L5,
                    :XongHoi2_L6,
                    :XongHoi2_L7,
                    :XongHoi2_L8,
                    :XongHoi2_L9,
                    :XongHoi2_L10,
                    :XongHoi2_GhiChu,
                    :DuongDa_L1,
                    :DuongDa_L2,
                    :DuongDa_L3,
                    :DuongDa_L4,
                    :DuongDa_L5,
                    :DuongDa_L6,
                    :DuongDa_L7,
                    :DuongDa_L8,
                    :DuongDa_L9,
                    :DuongDa_L10,
                    :DuongDa_GhiChu,
                    :ChongNang_L1,
                    :ChongNang_L2,
                    :ChongNang_L3,
                    :ChongNang_L4,
                    :ChongNang_L5,
                    :ChongNang_L6,
                    :ChongNang_L7,
                    :ChongNang_L8,
                    :ChongNang_L9,
                    :ChongNang_L10,
                    :ChongNang_GhiChu,
                    :BacSiCDL1,
                    :BacSiCDL2,
                    :BacSiCDL3,
                    :BacSiCDL4,
                    :BacSiCDL5,
                    :BacSiCDL6,
                    :BacSiCDL7,
                    :BacSiCDL8,
                    :BacSiCDL9,
                    :BacSiCDL10,
                    :BacSiCD_GhiChu,
                    :MaBacSiCDL1,
                    :MaBacSiCDL2,
                    :MaBacSiCDL3,
                    :MaBacSiCDL4,
                    :MaBacSiCDL5,
                    :MaBacSiCDL6,
                    :MaBacSiCDL7,
                    :MaBacSiCDL8,
                    :MaBacSiCDL9,
                    :MaBacSiCDL10,
                    :KTVL1,
                    :KTVL2,
                    :KTVL3,
                    :KTVL4,
                    :KTVL5,
                    :KTVL6,
                    :KTVL7,
                    :KTVL8,
                    :KTVL9,
                    :KTVL10,
                    :KTV_GhiChu,
                    :MaKTVL1,
                    :MaKTVL2,
                    :MaKTVL3,
                    :MaKTVL4,
                    :MaKTVL5,
                    :MaKTVL6,
                    :MaKTVL7,
                    :MaKTVL8,
                    :MaKTVL9,
                    :MaKTVL10,
                    :NGUOITAO,
                    :NGUOISUA,
                    :NGAYTAO,
                    :NGAYSUA
                 )  RETURNING ID INTO :ID";
                if (ketQua.ID != 0)
                {
                    sql = @"UPDATE PhieuSanSocDaKhoaLaser SET 
                    MaQuanLy = :MaQuanLy,
                    DiaChi = :DiaChi,
                    NgheNghiep = :NgheNghiep,
                    BoMe = :BoMe,
                    DienThoai = :DienThoai,
                    Ngay = :Ngay,
                    DieuTri_1 = :DieuTri_1,
                    DieuTri_1_Text = :DieuTri_1_Text,
                    DieuTri_2 = :DieuTri_2,
                    DieuTri_3 = :DieuTri_3,
                    DieuTri_4 = :DieuTri_4,
                    DieuTri_4_Text = :DieuTri_4_Text,
                    DieuTri_5 = :DieuTri_5,
                    DieuTri_6 = :DieuTri_6,
                    DieuTri_7 = :DieuTri_7,
                    DieuTri_7_Text = :DieuTri_7_Text,
                    DieuTri_8 = :DieuTri_8,
                    DieuTri_9_Text = :DieuTri_9_Text,
                    DieuTri_10 = :DieuTri_10,
                    DieuTri_11 = :DieuTri_11,
                    DieuTri_12 = :DieuTri_12,
                    DieuTri_13 = :DieuTri_13,
                    DieuTri_14 = :DieuTri_14,
                    DieuTri_15 = :DieuTri_15,
                    DieuTri_16 = :DieuTri_16,
                    DieuTri_17 = :DieuTri_17,
                    DieuTri_18 = :DieuTri_18,
                    DieuTri_19 = :DieuTri_19,
                    DieuTri_20 = :DieuTri_20,
                    DieuTri_21 = :DieuTri_21,
                    DieuTri_22_Text = :DieuTri_22_Text,
                    DieuTri_23_Text = :DieuTri_23_Text,
                    DieuTri_24_Text = :DieuTri_24_Text,
                    DieuTri_25 = :DieuTri_25,
                    DieuTri_26 = :DieuTri_26,
                    DieuTri_27 = :DieuTri_27,
                    DieuTri_28_Text = :DieuTri_28_Text,
                    DieuTri_29_Text = :DieuTri_29_Text,
                    NgayThang_L1 = :NgayThang_L1,
                    NgayThang_L2 = :NgayThang_L2,
                    NgayThang_L3 = :NgayThang_L3,
                    NgayThang_L4 = :NgayThang_L4,
                    NgayThang_L5 = :NgayThang_L5,
                    NgayThang_L6 = :NgayThang_L6,
                    NgayThang_L7 = :NgayThang_L7,
                    NgayThang_L8 = :NgayThang_L8,
                    NgayThang_L9 = :NgayThang_L9,
                    NgayThang_L10 = :NgayThang_L10,
                    NgayThang_GhiChu = :NgayThang_GhiChu,
			        TayTrang_L1 = :TayTrang_L1,
                    TayTrang_L2 = :TayTrang_L2,
                    TayTrang_L3 = :TayTrang_L3,
                    TayTrang_L4 = :TayTrang_L4,
                    TayTrang_L5 = :TayTrang_L5,
                    TayTrang_L6 = :TayTrang_L6,
                    TayTrang_L7 = :TayTrang_L7,
                    TayTrang_L8 = :TayTrang_L8,
                    TayTrang_L9 = :TayTrang_L9,
                    TayTrang_L10 = :TayTrang_L10,
                    TayTrang_GhiChu = :TayTrang_GhiChu,
                    RuaMat_L1 = :RuaMat_L1,
                    RuaMat_L2 = :RuaMat_L2,
                    RuaMat_L3 = :RuaMat_L3,
                    RuaMat_L4 = :RuaMat_L4,
                    RuaMat_L5 = :RuaMat_L5,
                    RuaMat_L6 = :RuaMat_L6,
                    RuaMat_L7 = :RuaMat_L7,
                    RuaMat_L8 = :RuaMat_L8,
                    RuaMat_L9 = :RuaMat_L9,
                    RuaMat_L10 = :RuaMat_L10,
                    RuaMat_GhiChu = :RuaMat_GhiChu,
                    CanBang1_L1 = :CanBang1_L1,
                    CanBang1_L2 = :CanBang1_L2,
                    CanBang1_L3 = :CanBang1_L3,
                    CanBang1_L4 = :CanBang1_L4,
                    CanBang1_L5 = :CanBang1_L5,
                    CanBang1_L6 = :CanBang1_L6,
                    CanBang1_L7 = :CanBang1_L7,
                    CanBang1_L8 = :CanBang1_L8,
                    CanBang1_L9 = :CanBang1_L9,
                    CanBang1_L10 = :CanBang1_L10,
                    CanBang1_GhiChu = :CanBang1_GhiChu,
                    TayTBChet_L1 = :TayTBChet_L1,
                    TayTBChet_L2 = :TayTBChet_L2,
                    TayTBChet_L3= :TayTBChet_L3,
                    TayTBChet_L4 = :TayTBChet_L4,
                    TayTBChet_L5 = :TayTBChet_L5,
                    TayTBChet_L6 = :TayTBChet_L6,
                    TayTBChet_L7 = :TayTBChet_L7,
                    TayTBChet_L8 = :TayTBChet_L8,
                    TayTBChet_L9 = :TayTBChet_L9,
                    TayTBChet_L10 = :TayTBChet_L10,
                    TayTBChet_GhiChu = :TayTBChet_GhiChu,
                    CanBang2_L1 = :CanBang2_L1,
                    CanBang2_L2 = :CanBang2_L2,
                    CanBang2_L3 = :CanBang2_L3,
                    CanBang2_L4 = :CanBang2_L4,
                    CanBang2_L5 = :CanBang2_L5,
                    CanBang2_L6 = :CanBang2_L6,
                    CanBang2_L7 = :CanBang2_L7,
                    CanBang2_L8 = :CanBang2_L8,
                    CanBang2_L9 = :CanBang2_L9,
                    CanBang2_L10 = :CanBang2_L10,
                    CanBang2_GhiChu = :CanBang2_GhiChu,
                    XongHoi1_L1 = :XongHoi1_L1,
                    XongHoi1_L2 = :XongHoi1_L2,
                    XongHoi1_L3 = :XongHoi1_L3,
                    XongHoi1_L4 = :XongHoi1_L4,
                    XongHoi1_L5 = :XongHoi1_L5,
                    XongHoi1_L6 = :XongHoi1_L6,
                    XongHoi1_L7 = :XongHoi1_L7,
                    XongHoi1_L8 = :XongHoi1_L8,
                    XongHoi1_L9 = :XongHoi1_L9,
                    XongHoi1_L10 = :XongHoi1_L10,
                    XongHoi1_GhiChu = :XongHoi1_GhiChu,
                    Massage_L1 = :Massage_L1,
                    Massage_L2 = :Massage_L2,
                    Massage_L3 = :Massage_L3,
                    Massage_L4 = :Massage_L4,
                    Massage_L5 = :Massage_L5,
                    Massage_L6 = :Massage_L6,
                    Massage_L7 = :Massage_L7,
                    Massage_L8 = :Massage_L8,
                    Massage_L9 = :Massage_L9,
                    Massage_L10 = :Massage_L10,
                    Massage_GhiChu = :Massage_GhiChu,
                    XitKhoang_L1 = :XitKhoang_L1,
                    XitKhoang_L2 = :XitKhoang_L2,
                    XitKhoang_L3 = :XitKhoang_L3,
                    XitKhoang_L4 = :XitKhoang_L4,
                    XitKhoang_L5 = :XitKhoang_L5,
                    XitKhoang_L6 = :XitKhoang_L6,
                    XitKhoang_L7 = :XitKhoang_L7,
                    XitKhoang_L8 = :XitKhoang_L8,
                    XitKhoang_L9 = :XitKhoang_L9,
                    XitKhoang_L10 = :XitKhoang_L10,
                    XitKhoang_GhiChu = :XitKhoang_GhiChu,
                    ChayMay_L1 = :ChayMay_L1,
                    ChayMay_L2 = :ChayMay_L2,
                    ChayMay_L3 = :ChayMay_L3,
                    ChayMay_L4 = :ChayMay_L4,
                    ChayMay_L5 = :ChayMay_L5,
                    ChayMay_L6 = :ChayMay_L6,
                    ChayMay_L7 = :ChayMay_L7,
                    ChayMay_L8 = :ChayMay_L8,
                    ChayMay_L9 = :ChayMay_L9,
                    ChayMay_L10 = :ChayMay_L10,
                    ChayMay_GhiChu = :ChayMay_GhiChu,
                    DapMat_L1 = :DapMat_L1,
                    DapMat_L2 = :DapMat_L2,
                    DapMat_L3 = :DapMat_L3,
                    DapMat_L4 = :DapMat_L4,
                    DapMat_L5 = :DapMat_L5,
                    DapMat_L6 = :DapMat_L6,
                    DapMat_L7 = :DapMat_L7,
                    DapMat_L8 = :DapMat_L8,
                    DapMat_L9 = :DapMat_L9,
                    DapMat_L10 = :DapMat_L10,
                    DapMat_GhiChu = :DapMat_GhiChu,
                    XongHoi2_L1 = :XongHoi2_L1,
                    XongHoi2_L2 = :XongHoi2_L2,
                    XongHoi2_L3 = :XongHoi2_L3,
                    XongHoi2_L4 = :XongHoi2_L4,
                    XongHoi2_L5 = :XongHoi2_L5,
                    XongHoi2_L6 = :XongHoi2_L6,
                    XongHoi2_L7 = :XongHoi2_L7,
                    XongHoi2_L8 = :XongHoi2_L8,
                    XongHoi2_L9 = :XongHoi2_L9,
                    XongHoi2_L10 = :XongHoi2_L10,
                    XongHoi2_GhiChu = :XongHoi2_GhiChu,
                    DuongDa_L1 = :DuongDa_L1,
                    DuongDa_L2 = :DuongDa_L2,
                    DuongDa_L3 = :DuongDa_L3,
                    DuongDa_L4 = :DuongDa_L4,
                    DuongDa_L5 = :DuongDa_L5,
                    DuongDa_L6 = :DuongDa_L6,
                    DuongDa_L7 = :DuongDa_L7,
                    DuongDa_L8 = :DuongDa_L8,
                    DuongDa_L9 = :DuongDa_L9,
                    DuongDa_L10 = :DuongDa_L10,
                    DuongDa_GhiChu = :DuongDa_GhiChu,
                    ChongNang_L1 = :ChongNang_L1,
                    ChongNang_L2 = :ChongNang_L2,
                    ChongNang_L3 = :ChongNang_L3,
                    ChongNang_L4 = :ChongNang_L4,
                    ChongNang_L5 = :ChongNang_L5,
                    ChongNang_L6 = :ChongNang_L6,
                    ChongNang_L7 = :ChongNang_L7,
                    ChongNang_L8 = :ChongNang_L8,
                    ChongNang_L9 = :ChongNang_L9,
                    ChongNang_L10 = :ChongNang_L10,
                    ChongNang_GhiChu = :ChongNang_GhiChu,
                    BacSiCDL1 = :BacSiCDL1,
                    BacSiCDL2 = :BacSiCDL2,
                    BacSiCDL3 = :BacSiCDL3,
                    BacSiCDL4 = :BacSiCDL4,
                    BacSiCDL5 = :BacSiCDL5,
                    BacSiCDL6 = :BacSiCDL6,
                    BacSiCDL7 = :BacSiCDL7,
                    BacSiCDL8 = :BacSiCDL8,
                    BacSiCDL9 = :BacSiCDL9,
                    BacSiCDL10 = :BacSiCDL10,
                    BacSiCD_GhiChu = :BacSiCD_GhiChu,
                    MaBacSiCDL1 = :MaBacSiCDL1,
                    MaBacSiCDL2 = :MaBacSiCDL2,
                    MaBacSiCDL3 = :MaBacSiCDL3,
                    MaBacSiCDL4 = :MaBacSiCDL4,
                    MaBacSiCDL5 = :MaBacSiCDL5,
                    MaBacSiCDL6 = :MaBacSiCDL6,
                    MaBacSiCDL7 = :MaBacSiCDL7,
                    MaBacSiCDL8 = :MaBacSiCDL8,
                    MaBacSiCDL9 = :MaBacSiCDL9,
                    MaBacSiCDL10 = :MaBacSiCDL10,
                    KTVL1 = :KTVL1,
                    KTVL2 = :KTVL2,
                    KTVL3 = :KTVL3,
                    KTVL4 = :KTVL4,
                    KTVL5 = :KTVL5,
                    KTVL6 = :KTVL6,
                    KTVL7 = :KTVL7,
                    KTVL8 = :KTVL8,
                    KTVL9 = :KTVL9,
                    KTVL10 = :KTVL10,
                    KTV_GhiChu = :KTV_GhiChu,
                    MaKTVL1 = :MaKTVL1,
                    MaKTVL2 = :MaKTVL2,
                    MaKTVL3 = :MaKTVL3,
                    MaKTVL4 = :MaKTVL4,
                    MaKTVL5 = :MaKTVL5,
                    MaKTVL6 = :MaKTVL6,
                    MaKTVL7 = :MaKTVL7,
                    MaKTVL8 = :MaKTVL8,
                    MaKTVL9 = :MaKTVL9,
                    MaKTVL10 = :MaKTVL10,
                    NGUOISUA = :NGUOISUA,
                    NGAYSUA = :NGAYSUA 
                    WHERE ID = " + ketQua.ID;
                }
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);

                Command.Parameters.Add(new MDB.MDBParameter("NGUOISUA", ketQua.NguoiSua));
                Command.Parameters.Add(new MDB.MDBParameter("NGAYSUA", ketQua.NgaySua));

                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", ketQua.MaQuanLy));

                Command.Parameters.Add(new MDB.MDBParameter("DiaChi", ketQua.DiaChi));
                Command.Parameters.Add(new MDB.MDBParameter("NgheNghiep", ketQua.NgheNghiep));
                Command.Parameters.Add(new MDB.MDBParameter("BoMe", ketQua.BoMe));
                Command.Parameters.Add(new MDB.MDBParameter("DienThoai", ketQua.DienThoai));
                Command.Parameters.Add(new MDB.MDBParameter("Ngay", ketQua.Ngay));

                Command.Parameters.Add(new MDB.MDBParameter("DieuTri_1", ketQua.DieuTri_1));
                Command.Parameters.Add(new MDB.MDBParameter("DieuTri_2", ketQua.DieuTri_2));
                Command.Parameters.Add(new MDB.MDBParameter("DieuTri_3", ketQua.DieuTri_3));
                Command.Parameters.Add(new MDB.MDBParameter("DieuTri_4", ketQua.DieuTri_4));
                Command.Parameters.Add(new MDB.MDBParameter("DieuTri_5", ketQua.DieuTri_5));
                Command.Parameters.Add(new MDB.MDBParameter("DieuTri_6", ketQua.DieuTri_6));
                Command.Parameters.Add(new MDB.MDBParameter("DieuTri_7", ketQua.DieuTri_7));
                Command.Parameters.Add(new MDB.MDBParameter("DieuTri_8", ketQua.DieuTri_8));
                Command.Parameters.Add(new MDB.MDBParameter("DieuTri_10", ketQua.DieuTri_10));
                Command.Parameters.Add(new MDB.MDBParameter("DieuTri_11", ketQua.DieuTri_11));
                Command.Parameters.Add(new MDB.MDBParameter("DieuTri_12", ketQua.DieuTri_12));
                Command.Parameters.Add(new MDB.MDBParameter("DieuTri_13", ketQua.DieuTri_13));
                Command.Parameters.Add(new MDB.MDBParameter("DieuTri_14", ketQua.DieuTri_14));
                Command.Parameters.Add(new MDB.MDBParameter("DieuTri_15", ketQua.DieuTri_15));
                Command.Parameters.Add(new MDB.MDBParameter("DieuTri_16", ketQua.DieuTri_16));
                Command.Parameters.Add(new MDB.MDBParameter("DieuTri_17", ketQua.DieuTri_17));
                Command.Parameters.Add(new MDB.MDBParameter("DieuTri_18", ketQua.DieuTri_18));
                Command.Parameters.Add(new MDB.MDBParameter("DieuTri_19", ketQua.DieuTri_19));
                Command.Parameters.Add(new MDB.MDBParameter("DieuTri_20", ketQua.DieuTri_20));
                Command.Parameters.Add(new MDB.MDBParameter("DieuTri_21", ketQua.DieuTri_21));
                Command.Parameters.Add(new MDB.MDBParameter("DieuTri_25", ketQua.DieuTri_25));
                Command.Parameters.Add(new MDB.MDBParameter("DieuTri_26", ketQua.DieuTri_26));
                Command.Parameters.Add(new MDB.MDBParameter("DieuTri_27", ketQua.DieuTri_27));
                Command.Parameters.Add(new MDB.MDBParameter("DieuTri_1_Text", ketQua.DieuTri_1_Text));
                Command.Parameters.Add(new MDB.MDBParameter("DieuTri_4_Text", ketQua.DieuTri_4_Text));
                Command.Parameters.Add(new MDB.MDBParameter("DieuTri_7_Text", ketQua.DieuTri_7_Text));
                Command.Parameters.Add(new MDB.MDBParameter("DieuTri_9_Text", ketQua.DieuTri_9_Text));
                Command.Parameters.Add(new MDB.MDBParameter("DieuTri_22_Text", ketQua.DieuTri_22_Text));
                Command.Parameters.Add(new MDB.MDBParameter("DieuTri_23_Text", ketQua.DieuTri_23_Text));
                Command.Parameters.Add(new MDB.MDBParameter("DieuTri_24_Text", ketQua.DieuTri_24_Text));
                Command.Parameters.Add(new MDB.MDBParameter("DieuTri_28_Text", ketQua.DieuTri_28_Text));
                Command.Parameters.Add(new MDB.MDBParameter("DieuTri_29_Text", ketQua.DieuTri_29_Text));

                Command.Parameters.Add(new MDB.MDBParameter("NgayThang_L1", ketQua.NgayThang_L1));
                Command.Parameters.Add(new MDB.MDBParameter("NgayThang_L2", ketQua.NgayThang_L2));
                Command.Parameters.Add(new MDB.MDBParameter("NgayThang_L3", ketQua.NgayThang_L3));
                Command.Parameters.Add(new MDB.MDBParameter("NgayThang_L4", ketQua.NgayThang_L4));
                Command.Parameters.Add(new MDB.MDBParameter("NgayThang_L5", ketQua.NgayThang_L5));
                Command.Parameters.Add(new MDB.MDBParameter("NgayThang_L6", ketQua.NgayThang_L6));
                Command.Parameters.Add(new MDB.MDBParameter("NgayThang_L7", ketQua.NgayThang_L7));
                Command.Parameters.Add(new MDB.MDBParameter("NgayThang_L8", ketQua.NgayThang_L8));
                Command.Parameters.Add(new MDB.MDBParameter("NgayThang_L9", ketQua.NgayThang_L9));
                Command.Parameters.Add(new MDB.MDBParameter("NgayThang_L10", ketQua.NgayThang_L10));
                Command.Parameters.Add(new MDB.MDBParameter("NgayThang_GhiChu", ketQua.NgayThang_GhiChu));

                Command.Parameters.Add(new MDB.MDBParameter("TayTrang_L1", ketQua.TayTrang_L1));
                Command.Parameters.Add(new MDB.MDBParameter("TayTrang_L2", ketQua.TayTrang_L2));
                Command.Parameters.Add(new MDB.MDBParameter("TayTrang_L3", ketQua.TayTrang_L3));
                Command.Parameters.Add(new MDB.MDBParameter("TayTrang_L4", ketQua.TayTrang_L4));
                Command.Parameters.Add(new MDB.MDBParameter("TayTrang_L5", ketQua.TayTrang_L5));
                Command.Parameters.Add(new MDB.MDBParameter("TayTrang_L6", ketQua.TayTrang_L6));
                Command.Parameters.Add(new MDB.MDBParameter("TayTrang_L7", ketQua.TayTrang_L7));
                Command.Parameters.Add(new MDB.MDBParameter("TayTrang_L8", ketQua.TayTrang_L8));
                Command.Parameters.Add(new MDB.MDBParameter("TayTrang_L9", ketQua.TayTrang_L9));
                Command.Parameters.Add(new MDB.MDBParameter("TayTrang_L10", ketQua.TayTrang_L10));
                Command.Parameters.Add(new MDB.MDBParameter("TayTrang_GhiChu", ketQua.TayTrang_GhiChu));

                Command.Parameters.Add(new MDB.MDBParameter("RuaMat_L1", ketQua.RuaMat_L1));
                Command.Parameters.Add(new MDB.MDBParameter("RuaMat_L2", ketQua.RuaMat_L2));
                Command.Parameters.Add(new MDB.MDBParameter("RuaMat_L3", ketQua.RuaMat_L3));
                Command.Parameters.Add(new MDB.MDBParameter("RuaMat_L4", ketQua.RuaMat_L4));
                Command.Parameters.Add(new MDB.MDBParameter("RuaMat_L5", ketQua.RuaMat_L5));
                Command.Parameters.Add(new MDB.MDBParameter("RuaMat_L6", ketQua.RuaMat_L6));
                Command.Parameters.Add(new MDB.MDBParameter("RuaMat_L7", ketQua.RuaMat_L7));
                Command.Parameters.Add(new MDB.MDBParameter("RuaMat_L8", ketQua.RuaMat_L8));
                Command.Parameters.Add(new MDB.MDBParameter("RuaMat_L9", ketQua.RuaMat_L9));
                Command.Parameters.Add(new MDB.MDBParameter("RuaMat_L10", ketQua.RuaMat_L10));
                Command.Parameters.Add(new MDB.MDBParameter("RuaMat_GhiChu", ketQua.RuaMat_GhiChu));

                Command.Parameters.Add(new MDB.MDBParameter("CanBang1_L1", ketQua.CanBang1_L1));
                Command.Parameters.Add(new MDB.MDBParameter("CanBang1_L2", ketQua.CanBang1_L2));
                Command.Parameters.Add(new MDB.MDBParameter("CanBang1_L3", ketQua.CanBang1_L3));
                Command.Parameters.Add(new MDB.MDBParameter("CanBang1_L4", ketQua.CanBang1_L4));
                Command.Parameters.Add(new MDB.MDBParameter("CanBang1_L5", ketQua.CanBang1_L5));
                Command.Parameters.Add(new MDB.MDBParameter("CanBang1_L6", ketQua.CanBang1_L6));
                Command.Parameters.Add(new MDB.MDBParameter("CanBang1_L7", ketQua.CanBang1_L7));
                Command.Parameters.Add(new MDB.MDBParameter("CanBang1_L8", ketQua.CanBang1_L8));
                Command.Parameters.Add(new MDB.MDBParameter("CanBang1_L9", ketQua.CanBang1_L9));
                Command.Parameters.Add(new MDB.MDBParameter("CanBang1_L10", ketQua.CanBang1_L10));
                Command.Parameters.Add(new MDB.MDBParameter("CanBang1_GhiChu", ketQua.CanBang1_GhiChu));

                Command.Parameters.Add(new MDB.MDBParameter("TayTBChet_L1", ketQua.TayTBChet_L1));
                Command.Parameters.Add(new MDB.MDBParameter("TayTBChet_L2", ketQua.TayTBChet_L2));
                Command.Parameters.Add(new MDB.MDBParameter("TayTBChet_L3", ketQua.TayTBChet_L3));
                Command.Parameters.Add(new MDB.MDBParameter("TayTBChet_L4", ketQua.TayTBChet_L4));
                Command.Parameters.Add(new MDB.MDBParameter("TayTBChet_L5", ketQua.TayTBChet_L5));
                Command.Parameters.Add(new MDB.MDBParameter("TayTBChet_L6", ketQua.TayTBChet_L6));
                Command.Parameters.Add(new MDB.MDBParameter("TayTBChet_L7", ketQua.TayTBChet_L7));
                Command.Parameters.Add(new MDB.MDBParameter("TayTBChet_L8", ketQua.TayTBChet_L8));
                Command.Parameters.Add(new MDB.MDBParameter("TayTBChet_L9", ketQua.TayTBChet_L9));
                Command.Parameters.Add(new MDB.MDBParameter("TayTBChet_L10", ketQua.TayTBChet_L10));
                Command.Parameters.Add(new MDB.MDBParameter("TayTBChet_GhiChu", ketQua.TayTBChet_GhiChu));

                Command.Parameters.Add(new MDB.MDBParameter("CanBang2_L1", ketQua.CanBang2_L1));
                Command.Parameters.Add(new MDB.MDBParameter("CanBang2_L2", ketQua.CanBang2_L2));
                Command.Parameters.Add(new MDB.MDBParameter("CanBang2_L3", ketQua.CanBang2_L3));
                Command.Parameters.Add(new MDB.MDBParameter("CanBang2_L4", ketQua.CanBang2_L4));
                Command.Parameters.Add(new MDB.MDBParameter("CanBang2_L5", ketQua.CanBang2_L5));
                Command.Parameters.Add(new MDB.MDBParameter("CanBang2_L6", ketQua.CanBang2_L6));
                Command.Parameters.Add(new MDB.MDBParameter("CanBang2_L7", ketQua.CanBang2_L7));
                Command.Parameters.Add(new MDB.MDBParameter("CanBang2_L8", ketQua.CanBang2_L8));
                Command.Parameters.Add(new MDB.MDBParameter("CanBang2_L9", ketQua.CanBang2_L9));
                Command.Parameters.Add(new MDB.MDBParameter("CanBang2_L10", ketQua.CanBang2_L10));
                Command.Parameters.Add(new MDB.MDBParameter("CanBang2_GhiChu", ketQua.CanBang2_GhiChu));

                Command.Parameters.Add(new MDB.MDBParameter("XongHoi1_L1", ketQua.XongHoi1_L1));
                Command.Parameters.Add(new MDB.MDBParameter("XongHoi1_L2", ketQua.XongHoi1_L2));
                Command.Parameters.Add(new MDB.MDBParameter("XongHoi1_L3", ketQua.XongHoi1_L3));
                Command.Parameters.Add(new MDB.MDBParameter("XongHoi1_L4", ketQua.XongHoi1_L4));
                Command.Parameters.Add(new MDB.MDBParameter("XongHoi1_L5", ketQua.XongHoi1_L5));
                Command.Parameters.Add(new MDB.MDBParameter("XongHoi1_L6", ketQua.XongHoi1_L6));
                Command.Parameters.Add(new MDB.MDBParameter("XongHoi1_L7", ketQua.XongHoi1_L7));
                Command.Parameters.Add(new MDB.MDBParameter("XongHoi1_L8", ketQua.XongHoi1_L8));
                Command.Parameters.Add(new MDB.MDBParameter("XongHoi1_L9", ketQua.XongHoi1_L9));
                Command.Parameters.Add(new MDB.MDBParameter("XongHoi1_L10", ketQua.XongHoi1_L10));
                Command.Parameters.Add(new MDB.MDBParameter("XongHoi1_GhiChu", ketQua.XongHoi1_GhiChu));

                Command.Parameters.Add(new MDB.MDBParameter("Massage_L1", ketQua.Massage_L1));
                Command.Parameters.Add(new MDB.MDBParameter("Massage_L2", ketQua.Massage_L2));
                Command.Parameters.Add(new MDB.MDBParameter("Massage_L3", ketQua.Massage_L3));
                Command.Parameters.Add(new MDB.MDBParameter("Massage_L4", ketQua.Massage_L4));
                Command.Parameters.Add(new MDB.MDBParameter("Massage_L5", ketQua.Massage_L5));
                Command.Parameters.Add(new MDB.MDBParameter("Massage_L6", ketQua.Massage_L6));
                Command.Parameters.Add(new MDB.MDBParameter("Massage_L7", ketQua.Massage_L7));
                Command.Parameters.Add(new MDB.MDBParameter("Massage_L8", ketQua.Massage_L8));
                Command.Parameters.Add(new MDB.MDBParameter("Massage_L9", ketQua.Massage_L9));
                Command.Parameters.Add(new MDB.MDBParameter("Massage_L10", ketQua.Massage_L10));
                Command.Parameters.Add(new MDB.MDBParameter("Massage_GhiChu", ketQua.Massage_GhiChu));

                Command.Parameters.Add(new MDB.MDBParameter("XitKhoang_L1", ketQua.XitKhoang_L1));
                Command.Parameters.Add(new MDB.MDBParameter("XitKhoang_L2", ketQua.XitKhoang_L2));
                Command.Parameters.Add(new MDB.MDBParameter("XitKhoang_L3", ketQua.XitKhoang_L3));
                Command.Parameters.Add(new MDB.MDBParameter("XitKhoang_L4", ketQua.XitKhoang_L4));
                Command.Parameters.Add(new MDB.MDBParameter("XitKhoang_L5", ketQua.XitKhoang_L5));
                Command.Parameters.Add(new MDB.MDBParameter("XitKhoang_L6", ketQua.XitKhoang_L6));
                Command.Parameters.Add(new MDB.MDBParameter("XitKhoang_L7", ketQua.XitKhoang_L7));
                Command.Parameters.Add(new MDB.MDBParameter("XitKhoang_L8", ketQua.XitKhoang_L8));
                Command.Parameters.Add(new MDB.MDBParameter("XitKhoang_L9", ketQua.XitKhoang_L9));
                Command.Parameters.Add(new MDB.MDBParameter("XitKhoang_L10", ketQua.XitKhoang_L10));
                Command.Parameters.Add(new MDB.MDBParameter("XitKhoang_GhiChu", ketQua.XitKhoang_GhiChu));

                Command.Parameters.Add(new MDB.MDBParameter("ChayMay_L1", ketQua.ChayMay_L1));
                Command.Parameters.Add(new MDB.MDBParameter("ChayMay_L2", ketQua.ChayMay_L2));
                Command.Parameters.Add(new MDB.MDBParameter("ChayMay_L3", ketQua.ChayMay_L3));
                Command.Parameters.Add(new MDB.MDBParameter("ChayMay_L4", ketQua.ChayMay_L4));
                Command.Parameters.Add(new MDB.MDBParameter("ChayMay_L5", ketQua.ChayMay_L5));
                Command.Parameters.Add(new MDB.MDBParameter("ChayMay_L6", ketQua.ChayMay_L6));
                Command.Parameters.Add(new MDB.MDBParameter("ChayMay_L7", ketQua.ChayMay_L7));
                Command.Parameters.Add(new MDB.MDBParameter("ChayMay_L8", ketQua.ChayMay_L8));
                Command.Parameters.Add(new MDB.MDBParameter("ChayMay_L9", ketQua.ChayMay_L9));
                Command.Parameters.Add(new MDB.MDBParameter("ChayMay_L10", ketQua.ChayMay_L10));
                Command.Parameters.Add(new MDB.MDBParameter("ChayMay_GhiChu", ketQua.ChayMay_GhiChu));

                Command.Parameters.Add(new MDB.MDBParameter("DapMat_L1", ketQua.DapMat_L1));
                Command.Parameters.Add(new MDB.MDBParameter("DapMat_L2", ketQua.DapMat_L2));
                Command.Parameters.Add(new MDB.MDBParameter("DapMat_L3", ketQua.DapMat_L3));
                Command.Parameters.Add(new MDB.MDBParameter("DapMat_L4", ketQua.DapMat_L4));
                Command.Parameters.Add(new MDB.MDBParameter("DapMat_L5", ketQua.DapMat_L5));
                Command.Parameters.Add(new MDB.MDBParameter("DapMat_L6", ketQua.DapMat_L6));
                Command.Parameters.Add(new MDB.MDBParameter("DapMat_L7", ketQua.DapMat_L7));
                Command.Parameters.Add(new MDB.MDBParameter("DapMat_L8", ketQua.DapMat_L8));
                Command.Parameters.Add(new MDB.MDBParameter("DapMat_L9", ketQua.DapMat_L9));
                Command.Parameters.Add(new MDB.MDBParameter("DapMat_L10", ketQua.DapMat_L10));
                Command.Parameters.Add(new MDB.MDBParameter("DapMat_GhiChu", ketQua.DapMat_GhiChu));

                Command.Parameters.Add(new MDB.MDBParameter("XongHoi2_L1", ketQua.XongHoi2_L1));
                Command.Parameters.Add(new MDB.MDBParameter("XongHoi2_L2", ketQua.XongHoi2_L2));
                Command.Parameters.Add(new MDB.MDBParameter("XongHoi2_L3", ketQua.XongHoi2_L3));
                Command.Parameters.Add(new MDB.MDBParameter("XongHoi2_L4", ketQua.XongHoi2_L4));
                Command.Parameters.Add(new MDB.MDBParameter("XongHoi2_L5", ketQua.XongHoi2_L5));
                Command.Parameters.Add(new MDB.MDBParameter("XongHoi2_L6", ketQua.XongHoi2_L6));
                Command.Parameters.Add(new MDB.MDBParameter("XongHoi2_L7", ketQua.XongHoi2_L7));
                Command.Parameters.Add(new MDB.MDBParameter("XongHoi2_L8", ketQua.XongHoi2_L8));
                Command.Parameters.Add(new MDB.MDBParameter("XongHoi2_L9", ketQua.XongHoi2_L9));
                Command.Parameters.Add(new MDB.MDBParameter("XongHoi2_L10", ketQua.XongHoi2_L10));
                Command.Parameters.Add(new MDB.MDBParameter("XongHoi2_GhiChu", ketQua.XongHoi2_GhiChu));

                Command.Parameters.Add(new MDB.MDBParameter("DuongDa_L1", ketQua.DuongDa_L1));
                Command.Parameters.Add(new MDB.MDBParameter("DuongDa_L2", ketQua.DuongDa_L2));
                Command.Parameters.Add(new MDB.MDBParameter("DuongDa_L3", ketQua.DuongDa_L3));
                Command.Parameters.Add(new MDB.MDBParameter("DuongDa_L4", ketQua.DuongDa_L4));
                Command.Parameters.Add(new MDB.MDBParameter("DuongDa_L5", ketQua.DuongDa_L5));
                Command.Parameters.Add(new MDB.MDBParameter("DuongDa_L6", ketQua.DuongDa_L6));
                Command.Parameters.Add(new MDB.MDBParameter("DuongDa_L7", ketQua.DuongDa_L7));
                Command.Parameters.Add(new MDB.MDBParameter("DuongDa_L8", ketQua.DuongDa_L8));
                Command.Parameters.Add(new MDB.MDBParameter("DuongDa_L9", ketQua.DuongDa_L9));
                Command.Parameters.Add(new MDB.MDBParameter("DuongDa_L10", ketQua.DuongDa_L10));
                Command.Parameters.Add(new MDB.MDBParameter("DuongDa_GhiChu", ketQua.DuongDa_GhiChu));

                Command.Parameters.Add(new MDB.MDBParameter("ChongNang_L1", ketQua.ChongNang_L1));
                Command.Parameters.Add(new MDB.MDBParameter("ChongNang_L2", ketQua.ChongNang_L2));
                Command.Parameters.Add(new MDB.MDBParameter("ChongNang_L3", ketQua.ChongNang_L3));
                Command.Parameters.Add(new MDB.MDBParameter("ChongNang_L4", ketQua.ChongNang_L4));
                Command.Parameters.Add(new MDB.MDBParameter("ChongNang_L5", ketQua.ChongNang_L5));
                Command.Parameters.Add(new MDB.MDBParameter("ChongNang_L6", ketQua.ChongNang_L6));
                Command.Parameters.Add(new MDB.MDBParameter("ChongNang_L7", ketQua.ChongNang_L7));
                Command.Parameters.Add(new MDB.MDBParameter("ChongNang_L8", ketQua.ChongNang_L8));
                Command.Parameters.Add(new MDB.MDBParameter("ChongNang_L9", ketQua.ChongNang_L9));
                Command.Parameters.Add(new MDB.MDBParameter("ChongNang_L10", ketQua.ChongNang_L10));
                Command.Parameters.Add(new MDB.MDBParameter("ChongNang_GhiChu", ketQua.ChongNang_GhiChu));

                Command.Parameters.Add(new MDB.MDBParameter("BacSiCDL1", ketQua.BacSiCDL1));
                Command.Parameters.Add(new MDB.MDBParameter("BacSiCDL2", ketQua.BacSiCDL2));
                Command.Parameters.Add(new MDB.MDBParameter("BacSiCDL3", ketQua.BacSiCDL3));
                Command.Parameters.Add(new MDB.MDBParameter("BacSiCDL4", ketQua.BacSiCDL4));
                Command.Parameters.Add(new MDB.MDBParameter("BacSiCDL5", ketQua.BacSiCDL5));
                Command.Parameters.Add(new MDB.MDBParameter("BacSiCDL6", ketQua.BacSiCDL6));
                Command.Parameters.Add(new MDB.MDBParameter("BacSiCDL7", ketQua.BacSiCDL7));
                Command.Parameters.Add(new MDB.MDBParameter("BacSiCDL8", ketQua.BacSiCDL8));
                Command.Parameters.Add(new MDB.MDBParameter("BacSiCDL9", ketQua.BacSiCDL9));
                Command.Parameters.Add(new MDB.MDBParameter("BacSiCDL10", ketQua.BacSiCDL10));
                Command.Parameters.Add(new MDB.MDBParameter("BacSiCD_GhiChu", ketQua.BacSiCD_GhiChu));
                Command.Parameters.Add(new MDB.MDBParameter("MaBacSiCDL1", ketQua.MaBacSiCDL1));
                Command.Parameters.Add(new MDB.MDBParameter("MaBacSiCDL2", ketQua.MaBacSiCDL2));
                Command.Parameters.Add(new MDB.MDBParameter("MaBacSiCDL3", ketQua.MaBacSiCDL3));
                Command.Parameters.Add(new MDB.MDBParameter("MaBacSiCDL4", ketQua.MaBacSiCDL4));
                Command.Parameters.Add(new MDB.MDBParameter("MaBacSiCDL5", ketQua.MaBacSiCDL5));
                Command.Parameters.Add(new MDB.MDBParameter("MaBacSiCDL6", ketQua.MaBacSiCDL6));
                Command.Parameters.Add(new MDB.MDBParameter("MaBacSiCDL7", ketQua.MaBacSiCDL7));
                Command.Parameters.Add(new MDB.MDBParameter("MaBacSiCDL8", ketQua.MaBacSiCDL8));
                Command.Parameters.Add(new MDB.MDBParameter("MaBacSiCDL9", ketQua.MaBacSiCDL9));
                Command.Parameters.Add(new MDB.MDBParameter("MaBacSiCDL10", ketQua.MaBacSiCDL10));

                Command.Parameters.Add(new MDB.MDBParameter("KTVL1", ketQua.KTVL1));
                Command.Parameters.Add(new MDB.MDBParameter("KTVL2", ketQua.KTVL2));
                Command.Parameters.Add(new MDB.MDBParameter("KTVL3", ketQua.KTVL3));
                Command.Parameters.Add(new MDB.MDBParameter("KTVL4", ketQua.KTVL4));
                Command.Parameters.Add(new MDB.MDBParameter("KTVL5", ketQua.KTVL5));
                Command.Parameters.Add(new MDB.MDBParameter("KTVL6", ketQua.KTVL6));
                Command.Parameters.Add(new MDB.MDBParameter("KTVL7", ketQua.KTVL7));
                Command.Parameters.Add(new MDB.MDBParameter("KTVL8", ketQua.KTVL8));
                Command.Parameters.Add(new MDB.MDBParameter("KTVL9", ketQua.KTVL9));
                Command.Parameters.Add(new MDB.MDBParameter("KTVL10", ketQua.KTVL10));
                Command.Parameters.Add(new MDB.MDBParameter("KTV_GhiChu", ketQua.KTV_GhiChu));
                Command.Parameters.Add(new MDB.MDBParameter("MaKTVL1", ketQua.MaKTVL1));
                Command.Parameters.Add(new MDB.MDBParameter("MaKTVL2", ketQua.MaKTVL2));
                Command.Parameters.Add(new MDB.MDBParameter("MaKTVL3", ketQua.MaKTVL3));
                Command.Parameters.Add(new MDB.MDBParameter("MaKTVL4", ketQua.MaKTVL4));
                Command.Parameters.Add(new MDB.MDBParameter("MaKTVL5", ketQua.MaKTVL5));
                Command.Parameters.Add(new MDB.MDBParameter("MaKTVL6", ketQua.MaKTVL6));
                Command.Parameters.Add(new MDB.MDBParameter("MaKTVL7", ketQua.MaKTVL7));
                Command.Parameters.Add(new MDB.MDBParameter("MaKTVL8", ketQua.MaKTVL8));
                Command.Parameters.Add(new MDB.MDBParameter("MaKTVL9", ketQua.MaKTVL9));
                Command.Parameters.Add(new MDB.MDBParameter("MaKTVL10", ketQua.MaKTVL10));

                if (ketQua.ID == 0)
                {
                    Command.Parameters.Add(new MDB.MDBParameter("ID", ketQua.ID));
                    Command.Parameters.Add(new MDB.MDBParameter("NGUOITAO", ketQua.NguoiTao));
                    Command.Parameters.Add(new MDB.MDBParameter("NGAYTAO", ketQua.NgayTao));
                }
                Command.BindByName = true;
                int n = Command.ExecuteNonQuery();
                if (ketQua.ID == 0)
                {
                    long nextval = Convert.ToInt64((Command.Parameters["ID"] as MDB.MDBParameter).Value);
                    ketQua.ID = nextval;
                }
                return n > 0 ? true : false;
            }
            catch (Exception ex)
            {
                XuLyLoi.LogError(ex);
            }
            return false;
        }
    }
}
