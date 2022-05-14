using EMR.KyDienTu;
using PMS.Access;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMR_MAIN.DATABASE.Other
{
    public class TuVanGiaoDucSucKhoe : ThongTinKy
    {
        public TuVanGiaoDucSucKhoe()
        {
            TableName = "TuVanGiaoDucSucKhoe";
            TablePrimaryKeyName = "ID";
            IDMauPhieu = (int)DanhMucPhieu.TVGDSK;
            TenMauPhieu = DanhMucPhieu.TVGDSK.Description();
        }
        [MoTaDuLieu("Mã định danh")]
		public long ID { get; set; }
        [MoTaDuLieu("Mã quản lý: mã duy nhất trong 1 đợt khám chữa bệnh (kcb), không trùng giữa các đợt kcb khác nhau","",1)]
		public decimal MaQuanLy { get; set; }
        [MoTaDuLieu("Mã bệnh nhân")]
		public string MaBenhNhan { get; set; }
        [MoTaDuLieu("Mã bệnh án")]
		public string MaBenhAn { get; set; }
        public string HoTenBenhNhan { get; set; }
        [MoTaDuLieu("Tuổi bệnh nhân")]
		public string Tuoi { get; set; }
        [MoTaDuLieu("Giới tính bệnh nhân")]
		public string GioiTinh { get; set; }
        public string SoGiuong { get; set; }
        public DateTime? NgayVaoVien { get; set; }
        [MoTaDuLieu("Chẩn đoán bệnh")]
		public string ChanDoan { get; set; }
        [MoTaDuLieu("Khoa")]
		public string Khoa { get; set; }
        [MoTaDuLieu("Mã khoa")]
		public string MaKhoa { get; set; }
        // TT1
        public bool NhuCau1 { get; set; }
        public bool[] PhuongPhap1_Array { get; } = new bool[] { false, false, false, false, false };
        public string PhuongPhap1
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < PhuongPhap1_Array.Length; i++)
                    temp += (PhuongPhap1_Array[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        PhuongPhap1_Array[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public string PhuongPhap1_Khac { get; set; }
        public bool[] NguoiTiepNhan1_Array { get; } = new bool[] { false, false };
        public string NguoiTiepNhan1
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < NguoiTiepNhan1_Array.Length; i++)
                    temp += (NguoiTiepNhan1_Array[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        NguoiTiepNhan1_Array[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }

        // TT2
        public bool NhuCau2 { get; set; }
        public bool[] PhuongPhap2_Array { get; } = new bool[] { false, false, false, false, false };
        public string PhuongPhap2
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < PhuongPhap2_Array.Length; i++)
                    temp += (PhuongPhap2_Array[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        PhuongPhap2_Array[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public string PhuongPhap2_Khac { get; set; }
        public bool[] NguoiTiepNhan2_Array { get; } = new bool[] { false, false };
        public string NguoiTiepNhan2
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < NguoiTiepNhan2_Array.Length; i++)
                    temp += (NguoiTiepNhan2_Array[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        NguoiTiepNhan2_Array[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        // TT3
        public bool NhuCau3 { get; set; }
        public bool[] PhuongPhap3_Array { get; } = new bool[] { false, false, false, false, false };
        public string PhuongPhap3
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < PhuongPhap3_Array.Length; i++)
                    temp += (PhuongPhap3_Array[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        PhuongPhap3_Array[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public string PhuongPhap3_Khac { get; set; }
        public bool[] NguoiTiepNhan3_Array { get; } = new bool[] { false, false };
        public string NguoiTiepNhan3
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < NguoiTiepNhan3_Array.Length; i++)
                    temp += (NguoiTiepNhan3_Array[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        NguoiTiepNhan3_Array[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        // TT4
        public bool NhuCau4 { get; set; }
        public bool[] PhuongPhap4_Array { get; } = new bool[] { false, false, false, false, false };
        public string PhuongPhap4
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < PhuongPhap4_Array.Length; i++)
                    temp += (PhuongPhap4_Array[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        PhuongPhap4_Array[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public string PhuongPhap4_Khac { get; set; }
        public bool[] NguoiTiepNhan4_Array { get; } = new bool[] { false, false };
        public string NguoiTiepNhan4
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < NguoiTiepNhan4_Array.Length; i++)
                    temp += (NguoiTiepNhan4_Array[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        NguoiTiepNhan4_Array[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        // TT5
        public bool NhuCau5 { get; set; }
        public bool[] PhuongPhap5_Array { get; } = new bool[] { false, false, false, false, false };
        public string PhuongPhap5
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < PhuongPhap5_Array.Length; i++)
                    temp += (PhuongPhap5_Array[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        PhuongPhap5_Array[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public string PhuongPhap5_Khac { get; set; }
        public bool[] NguoiTiepNhan5_Array { get; } = new bool[] { false, false };
        public string NguoiTiepNhan5
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < NguoiTiepNhan5_Array.Length; i++)
                    temp += (NguoiTiepNhan5_Array[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        NguoiTiepNhan5_Array[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        // TT6
        public bool NhuCau6 { get; set; }
        public bool[] PhuongPhap6_Array { get; } = new bool[] { false, false, false, false, false };
        public string PhuongPhap6
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < PhuongPhap6_Array.Length; i++)
                    temp += (PhuongPhap6_Array[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        PhuongPhap6_Array[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public string PhuongPhap6_Khac { get; set; }
        public bool[] NguoiTiepNhan6_Array { get; } = new bool[] { false, false };
        public string NguoiTiepNhan6
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < NguoiTiepNhan6_Array.Length; i++)
                    temp += (NguoiTiepNhan6_Array[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        NguoiTiepNhan6_Array[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        // TT7
        public bool NhuCau7 { get; set; }
        public bool[] PhuongPhap7_Array { get; } = new bool[] { false, false, false, false, false };
        public string PhuongPhap7
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < PhuongPhap7_Array.Length; i++)
                    temp += (PhuongPhap7_Array[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        PhuongPhap7_Array[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public string PhuongPhap7_Khac { get; set; }
        public bool[] NguoiTiepNhan7_Array { get; } = new bool[] { false, false };
        public string NguoiTiepNhan7
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < NguoiTiepNhan7_Array.Length; i++)
                    temp += (NguoiTiepNhan7_Array[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        NguoiTiepNhan7_Array[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        // TT8
        public bool NhuCau8 { get; set; }
        public bool[] PhuongPhap8_Array { get; } = new bool[] { false, false, false, false, false };
        public string PhuongPhap8
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < PhuongPhap8_Array.Length; i++)
                    temp += (PhuongPhap8_Array[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        PhuongPhap8_Array[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public string PhuongPhap8_Khac { get; set; }
        public bool[] NguoiTiepNhan8_Array { get; } = new bool[] { false, false };
        public string NguoiTiepNhan8
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < NguoiTiepNhan8_Array.Length; i++)
                    temp += (NguoiTiepNhan8_Array[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        NguoiTiepNhan8_Array[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        // TT9
        public bool NhuCau9 { get; set; }
        public bool[] PhuongPhap9_Array { get; } = new bool[] { false, false, false, false, false };
        public string PhuongPhap9
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < PhuongPhap9_Array.Length; i++)
                    temp += (PhuongPhap9_Array[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        PhuongPhap9_Array[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public string PhuongPhap9_Khac { get; set; }
        public bool[] NguoiTiepNhan9_Array { get; } = new bool[] { false, false };
        public string NguoiTiepNhan9
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < NguoiTiepNhan9_Array.Length; i++)
                    temp += (NguoiTiepNhan9_Array[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        NguoiTiepNhan9_Array[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        // TT10
        public bool NhuCau10 { get; set; }
        public bool[] PhuongPhap10_Array { get; } = new bool[] { false, false, false, false, false };
        public string PhuongPhap10
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < PhuongPhap10_Array.Length; i++)
                    temp += (PhuongPhap10_Array[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        PhuongPhap10_Array[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public string PhuongPhap10_Khac { get; set; }
        public bool[] NguoiTiepNhan10_Array { get; } = new bool[] { false, false };
        public string NguoiTiepNhan10
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < NguoiTiepNhan10_Array.Length; i++)
                    temp += (NguoiTiepNhan10_Array[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        NguoiTiepNhan10_Array[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        // TT11
        public bool NhuCau11 { get; set; }
        public bool[] PhuongPhap11_Array { get; } = new bool[] { false, false, false, false, false };
        public string PhuongPhap11
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < PhuongPhap11_Array.Length; i++)
                    temp += (PhuongPhap11_Array[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        PhuongPhap11_Array[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public string PhuongPhap11_Khac { get; set; }
        public bool[] NguoiTiepNhan11_Array { get; } = new bool[] { false, false };
        public string NguoiTiepNhan11
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < NguoiTiepNhan11_Array.Length; i++)
                    temp += (NguoiTiepNhan11_Array[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        NguoiTiepNhan11_Array[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        // TT12
        public string NhuCau12_Text { get; set; }
        public bool NhuCau12 { get; set; }
        public bool[] PhuongPhap12_Array { get; } = new bool[] { false, false, false, false, false };
        public string PhuongPhap12
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < PhuongPhap12_Array.Length; i++)
                    temp += (PhuongPhap12_Array[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        PhuongPhap12_Array[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public string PhuongPhap12_Khac { get; set; }
        public bool[] NguoiTiepNhan12_Array { get; } = new bool[] { false, false };
        public string NguoiTiepNhan12
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < NguoiTiepNhan12_Array.Length; i++)
                    temp += (NguoiTiepNhan12_Array[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        NguoiTiepNhan12_Array[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        // TT13
        public bool NhuCau13 { get; set; }
        public bool[] PhuongPhap13_Array { get; } = new bool[] { false, false, false, false, false };
        public string PhuongPhap13
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < PhuongPhap13_Array.Length; i++)
                    temp += (PhuongPhap13_Array[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        PhuongPhap13_Array[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public string PhuongPhap13_Khac { get; set; }
        public bool[] NguoiTiepNhan13_Array { get; } = new bool[] { false, false };
        public string NguoiTiepNhan13
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < NguoiTiepNhan13_Array.Length; i++)
                    temp += (NguoiTiepNhan13_Array[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        NguoiTiepNhan13_Array[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        // TT14
        public bool NhuCau14 { get; set; }
        public bool[] PhuongPhap14_Array { get; } = new bool[] { false, false, false, false, false };
        public string PhuongPhap14
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < PhuongPhap14_Array.Length; i++)
                    temp += (PhuongPhap14_Array[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        PhuongPhap14_Array[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public string PhuongPhap14_Khac { get; set; }
        public bool[] NguoiTiepNhan14_Array { get; } = new bool[] { false, false };
        public string NguoiTiepNhan14
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < NguoiTiepNhan14_Array.Length; i++)
                    temp += (NguoiTiepNhan14_Array[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        NguoiTiepNhan14_Array[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        // TT15
        public bool NhuCau15 { get; set; }
        public bool[] PhuongPhap15_Array { get; } = new bool[] { false, false, false, false, false };
        public string PhuongPhap15
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < PhuongPhap15_Array.Length; i++)
                    temp += (PhuongPhap15_Array[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        PhuongPhap15_Array[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public string PhuongPhap15_Khac { get; set; }
        public bool[] NguoiTiepNhan15_Array { get; } = new bool[] { false, false };
        public string NguoiTiepNhan15
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < NguoiTiepNhan15_Array.Length; i++)
                    temp += (NguoiTiepNhan15_Array[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        NguoiTiepNhan15_Array[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        // TT16
        public bool NhuCau16 { get; set; }
        public bool[] PhuongPhap16_Array { get; } = new bool[] { false, false, false, false, false };
        public string PhuongPhap16
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < PhuongPhap16_Array.Length; i++)
                    temp += (PhuongPhap16_Array[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        PhuongPhap16_Array[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public string PhuongPhap16_Khac { get; set; }
        public bool[] NguoiTiepNhan16_Array { get; } = new bool[] { false, false };
        public string NguoiTiepNhan16
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < NguoiTiepNhan16_Array.Length; i++)
                    temp += (NguoiTiepNhan16_Array[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        NguoiTiepNhan16_Array[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        // TT17
        public bool NhuCau17 { get; set; }
        public bool[] PhuongPhap17_Array { get; } = new bool[] { false, false, false, false, false };
        public string PhuongPhap17
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < PhuongPhap17_Array.Length; i++)
                    temp += (PhuongPhap17_Array[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        PhuongPhap17_Array[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public string PhuongPhap17_Khac { get; set; }
        public bool[] NguoiTiepNhan17_Array { get; } = new bool[] { false, false };
        public string NguoiTiepNhan17
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < NguoiTiepNhan17_Array.Length; i++)
                    temp += (NguoiTiepNhan17_Array[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        NguoiTiepNhan17_Array[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        // TT18
        public string NhuCau18_Text { get; set; }
        public bool NhuCau18 { get; set; }
        public bool[] PhuongPhap18_Array { get; } = new bool[] { false, false, false, false, false };
        public string PhuongPhap18
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < PhuongPhap18_Array.Length; i++)
                    temp += (PhuongPhap18_Array[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        PhuongPhap18_Array[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public string PhuongPhap18_Khac { get; set; }
        public bool[] NguoiTiepNhan18_Array { get; } = new bool[] { false, false };
        public string NguoiTiepNhan18
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < NguoiTiepNhan18_Array.Length; i++)
                    temp += (NguoiTiepNhan18_Array[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        NguoiTiepNhan18_Array[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public DateTime? NgayThangSauNhapVien { get; set; }
        public DateTime? NgayThangTruocNhapVien { get; set; }
        [MoTaDuLieu("Mã điều dưỡng")]
		public string MaDieuDuongTruoc { get; set; }
        [MoTaDuLieu("Họ tên điều dưỡng")]
		public string DieuDuongTruoc { get; set; }
        [MoTaDuLieu("Mã điều dưỡng")]
		public string MaDieuDuongSau { get; set; }
        [MoTaDuLieu("Họ tên điều dưỡng")]
		public string DieuDuongSau { get; set; }
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
    public class TuVanGiaoDucSucKhoeFunc
    {
        public const string TableName = "TuVanGiaoDucSucKhoe";
        public const string TablePrimaryKeyName = "ID";
        public static List<TuVanGiaoDucSucKhoe> GetListData(MDB.MDBConnection _OracleConnection, decimal maquanly)
        {
            List<TuVanGiaoDucSucKhoe> list = new List<TuVanGiaoDucSucKhoe>();
            try
            {
                string sql = @"SELECT * FROM TuVanGiaoDucSucKhoe where MaQuanLy = :MaQuanLy";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, _OracleConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", maquanly));
                MDB.MDBDataReader DataReader = Command.ExecuteReader();
                while (DataReader.Read())
                {
                    TuVanGiaoDucSucKhoe data = new TuVanGiaoDucSucKhoe();
                    data.ID = Convert.ToInt64(DataReader.GetLong("ID").ToString());
                    data.MaQuanLy = maquanly;
                    data.MaBenhNhan = DataReader["MaBenhNhan"].ToString();
                    data.HoTenBenhNhan = XemBenhAn._HanhChinhBenhNhan.TenBenhNhan;
                    data.MaBenhAn = XemBenhAn._ThongTinDieuTri.MaBenhAn;
                    data.Tuoi = XemBenhAn._HanhChinhBenhNhan.Tuoi;
                    data.GioiTinh = XemBenhAn._HanhChinhBenhNhan.GioiTinh.Description();
                    data.ChanDoan = DataReader["ChanDoan"].ToString();
                    data.SoGiuong = DataReader["SoGiuong"].ToString();
                    data.Khoa = DataReader["Khoa"].ToString();
                    data.MaKhoa = DataReader["MaKhoa"].ToString();
                    data.NgayVaoVien = DataReader["NgayVaoVien"] != DBNull.Value ? (DateTime?) Convert.ToDateTime(DataReader["NgayVaoVien"]): null;

                    int tempInt = 0;

                    data.NhuCau1 = DataReader["NhuCau1"].ToString().Equals("1") ? true : false;
                    data.PhuongPhap1 = DataReader["PhuongPhap1"].ToString();
                    data.PhuongPhap1_Khac = DataReader["PhuongPhap1_Khac"].ToString();
                    data.NguoiTiepNhan1 = DataReader["NguoiTiepNhan1"].ToString();

                    data.NhuCau2 = DataReader["NhuCau2"].ToString().Equals("1") ? true : false;
                    data.PhuongPhap2 = DataReader["PhuongPhap2"].ToString();
                    data.PhuongPhap2_Khac = DataReader["PhuongPhap2_Khac"].ToString();
                    data.NguoiTiepNhan2 = DataReader["NguoiTiepNhan2"].ToString();

                    data.NhuCau3 = DataReader["NhuCau3"].ToString().Equals("1") ? true : false;
                    data.PhuongPhap3 = DataReader["PhuongPhap3"].ToString();
                    data.PhuongPhap3_Khac = DataReader["PhuongPhap3_Khac"].ToString();
                    data.NguoiTiepNhan3 = DataReader["NguoiTiepNhan3"].ToString();

                    data.NhuCau4 = DataReader["NhuCau4"].ToString().Equals("1") ? true : false;
                    data.PhuongPhap4 = DataReader["PhuongPhap4"].ToString();
                    data.PhuongPhap4_Khac = DataReader["PhuongPhap4_Khac"].ToString();
                    data.NguoiTiepNhan4 = DataReader["NguoiTiepNhan4"].ToString();

                    data.NhuCau5 = DataReader["NhuCau5"].ToString().Equals("1") ? true : false;
                    data.PhuongPhap5 = DataReader["PhuongPhap5"].ToString();
                    data.PhuongPhap5_Khac = DataReader["PhuongPhap5_Khac"].ToString();
                    data.NguoiTiepNhan5 = DataReader["NguoiTiepNhan5"].ToString();

                    data.NhuCau6 = DataReader["NhuCau6"].ToString().Equals("1") ? true : false;
                    data.PhuongPhap6 = DataReader["PhuongPhap6"].ToString();
                    data.PhuongPhap6_Khac = DataReader["PhuongPhap6_Khac"].ToString();
                    data.NguoiTiepNhan6 = DataReader["NguoiTiepNhan6"].ToString();

                    data.NhuCau7 = DataReader["NhuCau7"].ToString().Equals("1") ? true : false;
                    data.PhuongPhap7 = DataReader["PhuongPhap7"].ToString();
                    data.PhuongPhap7_Khac = DataReader["PhuongPhap7_Khac"].ToString();
                    data.NguoiTiepNhan7 = DataReader["NguoiTiepNhan7"].ToString();

                    data.NhuCau8 = DataReader["NhuCau8"].ToString().Equals("1") ? true : false;
                    data.PhuongPhap8 = DataReader["PhuongPhap8"].ToString();
                    data.PhuongPhap8_Khac = DataReader["PhuongPhap8_Khac"].ToString();
                    data.NguoiTiepNhan8 = DataReader["NguoiTiepNhan8"].ToString();

                    data.NhuCau9 = DataReader["NhuCau9"].ToString().Equals("1") ? true : false;
                    data.PhuongPhap9 = DataReader["PhuongPhap9"].ToString();
                    data.PhuongPhap9_Khac = DataReader["PhuongPhap9_Khac"].ToString();
                    data.NguoiTiepNhan9 = DataReader["NguoiTiepNhan9"].ToString();

                    data.NhuCau10 = DataReader["NhuCau10"].ToString().Equals("1") ? true : false;
                    data.PhuongPhap10 = DataReader["PhuongPhap10"].ToString();
                    data.PhuongPhap10_Khac = DataReader["PhuongPhap10_Khac"].ToString();
                    data.NguoiTiepNhan10 = DataReader["NguoiTiepNhan10"].ToString();

                    data.NhuCau11 = DataReader["NhuCau11"].ToString().Equals("1") ? true : false;
                    data.PhuongPhap11 = DataReader["PhuongPhap11"].ToString();
                    data.PhuongPhap11_Khac = DataReader["PhuongPhap11_Khac"].ToString();
                    data.NguoiTiepNhan11 = DataReader["NguoiTiepNhan11"].ToString();

                    data.NhuCau12_Text = DataReader["NhuCau12_Text"].ToString();
                    data.NhuCau12 = DataReader["NhuCau12"].ToString().Equals("1") ? true : false;
                    data.PhuongPhap12 = DataReader["PhuongPhap12"].ToString();
                    data.PhuongPhap12_Khac = DataReader["PhuongPhap12_Khac"].ToString();
                    data.NguoiTiepNhan12 = DataReader["NguoiTiepNhan12"].ToString();

                    data.NhuCau13 = DataReader["NhuCau13"].ToString().Equals("1") ? true : false;
                    data.PhuongPhap13 = DataReader["PhuongPhap13"].ToString();
                    data.PhuongPhap13_Khac = DataReader["PhuongPhap13_Khac"].ToString();
                    data.NguoiTiepNhan13 = DataReader["NguoiTiepNhan13"].ToString();

                    data.NhuCau14 = DataReader["NhuCau14"].ToString().Equals("1") ? true : false;
                    data.PhuongPhap14 = DataReader["PhuongPhap14"].ToString();
                    data.PhuongPhap14_Khac = DataReader["PhuongPhap14_Khac"].ToString();
                    data.NguoiTiepNhan14 = DataReader["NguoiTiepNhan14"].ToString();

                    data.NhuCau15 = DataReader["NhuCau15"].ToString().Equals("1") ? true : false;
                    data.PhuongPhap15 = DataReader["PhuongPhap15"].ToString();
                    data.PhuongPhap15_Khac = DataReader["PhuongPhap15_Khac"].ToString();
                    data.NguoiTiepNhan15 = DataReader["NguoiTiepNhan15"].ToString();

                    data.NhuCau16 = DataReader["NhuCau16"].ToString().Equals("1") ? true : false;
                    data.PhuongPhap16 = DataReader["PhuongPhap16"].ToString();
                    data.PhuongPhap16_Khac = DataReader["PhuongPhap16_Khac"].ToString();
                    data.NguoiTiepNhan16 = DataReader["NguoiTiepNhan16"].ToString();

                    data.NhuCau17 = DataReader["NhuCau17"].ToString().Equals("1") ? true : false;
                    data.PhuongPhap17 = DataReader["PhuongPhap17"].ToString();
                    data.PhuongPhap17_Khac = DataReader["PhuongPhap17_Khac"].ToString();
                    data.NguoiTiepNhan17 = DataReader["NguoiTiepNhan17"].ToString();

                    data.NhuCau18_Text = DataReader["NhuCau18_Text"].ToString();
                    data.NhuCau18 = DataReader["NhuCau18"].ToString().Equals("1") ? true : false;
                    data.PhuongPhap18 = DataReader["PhuongPhap18"].ToString();
                    data.PhuongPhap18_Khac = DataReader["PhuongPhap18_Khac"].ToString();
                    data.NguoiTiepNhan18 = DataReader["NguoiTiepNhan18"].ToString();

                    data.NgayThangSauNhapVien = DataReader["NgayThangSauNhapVien"] != DBNull.Value ? (DateTime?)Convert.ToDateTime(DataReader["NgayThangSauNhapVien"]) : null;
                    data.NgayThangTruocNhapVien = DataReader["NgayThangTruocNhapVien"] != DBNull.Value ? (DateTime?)Convert.ToDateTime(DataReader["NgayThangTruocNhapVien"]) : null;

                    data.MaDieuDuongTruoc = DataReader["MaDieuDuongTruoc"].ToString();
                    data.DieuDuongTruoc = DataReader["DieuDuongTruoc"].ToString();
                    data.MaDieuDuongSau = DataReader["MaDieuDuongSau"].ToString();
                    data.DieuDuongSau = DataReader["DieuDuongSau"].ToString();

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
        public static bool InsertOrUpdate(MDB.MDBConnection MyConnection, ref TuVanGiaoDucSucKhoe ketQua)
        {
            try
            {
                string sql = @"INSERT INTO TuVanGiaoDucSucKhoe
                (
                    MaQuanLy,
                    MaBenhNhan,
                    MaBenhAn,
                    Khoa,
                    MaKhoa,
                    SoGiuong,
                    NgayVaoVien,
                    ChanDoan,
                    NhuCau1,
                    PhuongPhap1,
                    PhuongPhap1_Khac,
                    NguoiTiepNhan1,
                    NhuCau2,
                    PhuongPhap2,
                    PhuongPhap2_Khac,
                    NguoiTiepNhan2,
                    NhuCau3,
                    PhuongPhap3,
                    PhuongPhap3_Khac,
                    NguoiTiepNhan3,
                    NhuCau4,
                    PhuongPhap4,
                    PhuongPhap4_Khac,
                    NguoiTiepNhan4,
                    NhuCau5,
                    PhuongPhap5,
                    PhuongPhap5_Khac,
                    NguoiTiepNhan5,
                    NhuCau6,
                    PhuongPhap6,
                    PhuongPhap6_Khac,
                    NguoiTiepNhan6,
                    NhuCau7,
                    PhuongPhap7,
                    PhuongPhap7_Khac,
                    NguoiTiepNhan7,
                    NhuCau8,
                    PhuongPhap8,
                    PhuongPhap8_Khac,
                    NguoiTiepNhan8,
                    NhuCau9,
                    PhuongPhap9,
                    PhuongPhap9_Khac,
                    NguoiTiepNhan9,
                    NhuCau10,
                    PhuongPhap10,
                    PhuongPhap10_Khac,
                    NguoiTiepNhan10,
                    NhuCau11,
                    PhuongPhap11,
                    PhuongPhap11_Khac,
                    NguoiTiepNhan11,
                    NhuCau12_Text,
                    NhuCau12,
                    PhuongPhap12,
                    PhuongPhap12_Khac,
                    NguoiTiepNhan12,
                    NhuCau13,
                    PhuongPhap13,
                    PhuongPhap13_Khac,
                    NguoiTiepNhan13,
                    NhuCau14,
                    PhuongPhap14,
                    PhuongPhap14_Khac,
                    NguoiTiepNhan14,
                    NhuCau15,
                    PhuongPhap15,
                    PhuongPhap15_Khac,
                    NguoiTiepNhan15,
                    NhuCau16,
                    PhuongPhap16,
                    PhuongPhap16_Khac,
                    NguoiTiepNhan16,
                    NhuCau17,
                    PhuongPhap17,
                    PhuongPhap17_Khac,
                    NguoiTiepNhan17,
                    NhuCau18_Text,
                    NhuCau18,
                    PhuongPhap18,
                    PhuongPhap18_Khac,
                    NguoiTiepNhan18,
                    NgayThangSauNhapVien,
                    NgayThangTruocNhapVien,
                    MaDieuDuongTruoc,
                    DieuDuongTruoc,
                    MaDieuDuongSau,
                    DieuDuongSau,
                    NGUOITAO,
                    NGUOISUA,
                    NGAYTAO,
                    NGAYSUA)  VALUES
                 (
				    :MaQuanLy,
                    :MaBenhNhan,
                    :MaBenhAn,
                    :Khoa,
                    :MaKhoa,
                    :SoGiuong,
                    :NgayVaoVien,
                    :ChanDoan,
                    :NhuCau1,
                    :PhuongPhap1,
                    :PhuongPhap1_Khac,
                    :NguoiTiepNhan1,
                    :NhuCau2,
                    :PhuongPhap2,
                    :PhuongPhap2_Khac,
                    :NguoiTiepNhan2,
                    :NhuCau3,
                    :PhuongPhap3,
                    :PhuongPhap3_Khac,
                    :NguoiTiepNhan3,
                    :NhuCau4,
                    :PhuongPhap4,
                    :PhuongPhap4_Khac,
                    :NguoiTiepNhan4,
                    :NhuCau5,
                    :PhuongPhap5,
                    :PhuongPhap5_Khac,
                    :NguoiTiepNhan5,
                    :NhuCau6,
                    :PhuongPhap6,
                    :PhuongPhap6_Khac,
                    :NguoiTiepNhan6,
                    :NhuCau7,
                    :PhuongPhap7,
                    :PhuongPhap7_Khac,
                    :NguoiTiepNhan7,
                    :NhuCau8,
                    :PhuongPhap8,
                    :PhuongPhap8_Khac,
                    :NguoiTiepNhan8,
                    :NhuCau9,
                    :PhuongPhap9,
                    :PhuongPhap9_Khac,
                    :NguoiTiepNhan9,
                    :NhuCau10,
                    :PhuongPhap10,
                    :PhuongPhap10_Khac,
                    :NguoiTiepNhan10,
                    :NhuCau11,
                    :PhuongPhap11,
                    :PhuongPhap11_Khac,
                    :NguoiTiepNhan11,
                    :NhuCau12_Text,
                    :NhuCau12,
                    :PhuongPhap12,
                    :PhuongPhap12_Khac,
                    :NguoiTiepNhan12,
                    :NhuCau13,
                    :PhuongPhap13,
                    :PhuongPhap13_Khac,
                    :NguoiTiepNhan13,
                    :NhuCau14,
                    :PhuongPhap14,
                    :PhuongPhap14_Khac,
                    :NguoiTiepNhan14,
                    :NhuCau15,
                    :PhuongPhap15,
                    :PhuongPhap15_Khac,
                    :NguoiTiepNhan15,
                    :NhuCau16,
                    :PhuongPhap16,
                    :PhuongPhap16_Khac,
                    :NguoiTiepNhan16,
                    :NhuCau17,
                    :PhuongPhap17,
                    :PhuongPhap17_Khac,
                    :NguoiTiepNhan17,
                    :NhuCau18_Text,
                    :NhuCau18,
                    :PhuongPhap18,
                    :PhuongPhap18_Khac,
                    :NguoiTiepNhan18,
                    :NgayThangSauNhapVien,
                    :NgayThangTruocNhapVien,
                    :MaDieuDuongTruoc,
                    :DieuDuongTruoc,
                    :MaDieuDuongSau,
                    :DieuDuongSau,
                    :NGUOITAO,
                    :NGUOISUA,
                    :NGAYTAO,
                    :NGAYSUA
                 )  RETURNING ID INTO :ID";
                if (ketQua.ID != 0)
                {
                    sql = @"UPDATE TuVanGiaoDucSucKhoe SET 
                    MaQuanLy = :MaQuanLy,
                    MaBenhNhan = :MaBenhNhan,
                    MaBenhAn = :MaBenhAn,
                    Khoa = :Khoa,
                    MaKhoa = :MaKhoa,
                    SoGiuong = :SoGiuong,
                    NgayVaoVien = :NgayVaoVien,
                    ChanDoan = :ChanDoan,
                    NhuCau1 = :NhuCau1,
                    PhuongPhap1 = :PhuongPhap1,
                    PhuongPhap1_Khac = :PhuongPhap1_Khac,
                    NguoiTiepNhan1 = :NguoiTiepNhan1,
                    NhuCau2 = :NhuCau2,
                    PhuongPhap2 = :PhuongPhap2,
                    PhuongPhap2_Khac = :PhuongPhap2_Khac,
                    NguoiTiepNhan2 = :NguoiTiepNhan2,
                    NhuCau3 = :NhuCau3,
                    PhuongPhap3 = :PhuongPhap3,
                    PhuongPhap3_Khac = :PhuongPhap3_Khac,
                    NguoiTiepNhan3 = :NguoiTiepNhan3,
                    NhuCau4 = :NhuCau4,
                    PhuongPhap4 = :PhuongPhap4,
                    PhuongPhap4_Khac = :PhuongPhap4_Khac,
                    NguoiTiepNhan4 = :NguoiTiepNhan4,
                    NhuCau5 = :NhuCau5,
                    PhuongPhap5 = :PhuongPhap5,
                    PhuongPhap5_Khac = :PhuongPhap5_Khac,
                    NguoiTiepNhan5 = :NguoiTiepNhan5,
                    NhuCau6 = :NhuCau6,
                    PhuongPhap6 = :PhuongPhap6,
                    PhuongPhap6_Khac = :PhuongPhap6_Khac,
                    NguoiTiepNhan6 = :NguoiTiepNhan6,
                    NhuCau7 = :NhuCau7,
                    PhuongPhap7 = :PhuongPhap7,
                    PhuongPhap7_Khac = :PhuongPhap7_Khac,
                    NguoiTiepNhan7 = :NguoiTiepNhan7,
                    NhuCau8 = :NhuCau8,
                    PhuongPhap8 = :PhuongPhap8,
                    PhuongPhap8_Khac = :PhuongPhap8_Khac,
                    NguoiTiepNhan8 = :NguoiTiepNhan8,
                    NhuCau9 = :NhuCau9,
                    PhuongPhap9 = :PhuongPhap9,
                    PhuongPhap9_Khac = :PhuongPhap9_Khac,
                    NguoiTiepNhan9 = :NguoiTiepNhan9,
                    NhuCau10 = :NhuCau10,
                    PhuongPhap10 = :PhuongPhap10,
                    PhuongPhap10_Khac = :PhuongPhap10_Khac,
                    NguoiTiepNhan10 = :NguoiTiepNhan10,
                    NhuCau11 = :NhuCau11,
                    PhuongPhap11 = :PhuongPhap11,
                    PhuongPhap11_Khac = :PhuongPhap11_Khac,
                    NguoiTiepNhan11 = :NguoiTiepNhan11,
                    NhuCau12_Text = :NhuCau12_Text,
                    NhuCau12 = :NhuCau12,
                    PhuongPhap12 = :PhuongPhap12,
                    PhuongPhap12_Khac = :PhuongPhap12_Khac,
                    NguoiTiepNhan12 = :NguoiTiepNhan12,
                    NhuCau13 = :NhuCau13,
                    PhuongPhap13 = :PhuongPhap13,
                    PhuongPhap13_Khac = :PhuongPhap13_Khac,
                    NguoiTiepNhan13 = :NguoiTiepNhan13,
                    NhuCau14 = :NhuCau14,
                    PhuongPhap14 = :PhuongPhap14,
                    PhuongPhap14_Khac = :PhuongPhap14_Khac,
                    NguoiTiepNhan14 = :NguoiTiepNhan14,
                    NhuCau15 = :NhuCau15,
                    PhuongPhap15 = :PhuongPhap15,
                    PhuongPhap15_Khac = :PhuongPhap15_Khac,
                    NguoiTiepNhan15 = :NguoiTiepNhan15,
                    NhuCau16 = :NhuCau16,
                    PhuongPhap16 = :PhuongPhap16,
                    PhuongPhap16_Khac = :PhuongPhap16_Khac,
                    NguoiTiepNhan16 = :NguoiTiepNhan16,
                    NhuCau17 = :NhuCau17,
                    PhuongPhap17 = :PhuongPhap17,
                    PhuongPhap17_Khac = :PhuongPhap17_Khac,
                    NguoiTiepNhan17 = :NguoiTiepNhan17,
                    NhuCau18_Text = :NhuCau18_Text,
                    NhuCau18 = :NhuCau18,
                    PhuongPhap18 = :PhuongPhap18,
                    PhuongPhap18_Khac = :PhuongPhap18_Khac,
                    NguoiTiepNhan18 = :NguoiTiepNhan18,
                    NgayThangSauNhapVien = :NgayThangSauNhapVien,
                    NgayThangTruocNhapVien = :NgayThangTruocNhapVien,
                    MaDieuDuongTruoc = :MaDieuDuongTruoc,
                    DieuDuongTruoc = :DieuDuongTruoc,
                    MaDieuDuongSau = :MaDieuDuongSau,
                    DieuDuongSau = :DieuDuongSau,
                    NGUOISUA = :NGUOISUA,
                    NGAYSUA = :NGAYSUA
                    WHERE ID = " + ketQua.ID;
                }
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MAQUANLY", ketQua.MaQuanLy));
                Command.Parameters.Add(new MDB.MDBParameter("MaBenhNhan", ketQua.MaBenhNhan));
                Command.Parameters.Add(new MDB.MDBParameter("MaBenhAn", ketQua.MaBenhAn));
                Command.Parameters.Add(new MDB.MDBParameter("Khoa", ketQua.Khoa));
                Command.Parameters.Add(new MDB.MDBParameter("MaKhoa", ketQua.MaKhoa));
                Command.Parameters.Add(new MDB.MDBParameter("SoGiuong", ketQua.SoGiuong));
                Command.Parameters.Add(new MDB.MDBParameter("NgayVaoVien", ketQua.NgayVaoVien));
                Command.Parameters.Add(new MDB.MDBParameter("ChanDoan", ketQua.ChanDoan));

                Command.Parameters.Add(new MDB.MDBParameter("NhuCau1", ketQua.NhuCau1 ? 1:0));
                Command.Parameters.Add(new MDB.MDBParameter("PhuongPhap1", ketQua.PhuongPhap1));
                Command.Parameters.Add(new MDB.MDBParameter("PhuongPhap1_Khac", ketQua.PhuongPhap1_Khac));
                Command.Parameters.Add(new MDB.MDBParameter("NguoiTiepNhan1", ketQua.NguoiTiepNhan1));

                Command.Parameters.Add(new MDB.MDBParameter("NhuCau2", ketQua.NhuCau2 ? 1 : 0));
                Command.Parameters.Add(new MDB.MDBParameter("PhuongPhap2", ketQua.PhuongPhap2));
                Command.Parameters.Add(new MDB.MDBParameter("PhuongPhap2_Khac", ketQua.PhuongPhap2_Khac));
                Command.Parameters.Add(new MDB.MDBParameter("NguoiTiepNhan2", ketQua.NguoiTiepNhan2));

                Command.Parameters.Add(new MDB.MDBParameter("NhuCau3", ketQua.NhuCau3 ? 1 : 0));
                Command.Parameters.Add(new MDB.MDBParameter("PhuongPhap3", ketQua.PhuongPhap3));
                Command.Parameters.Add(new MDB.MDBParameter("PhuongPhap3_Khac", ketQua.PhuongPhap3_Khac));
                Command.Parameters.Add(new MDB.MDBParameter("NguoiTiepNhan3", ketQua.NguoiTiepNhan3));

                Command.Parameters.Add(new MDB.MDBParameter("NhuCau4", ketQua.NhuCau4 ? 1 : 0));
                Command.Parameters.Add(new MDB.MDBParameter("PhuongPhap4", ketQua.PhuongPhap4));
                Command.Parameters.Add(new MDB.MDBParameter("PhuongPhap4_Khac", ketQua.PhuongPhap4_Khac));
                Command.Parameters.Add(new MDB.MDBParameter("NguoiTiepNhan4", ketQua.NguoiTiepNhan4));

                Command.Parameters.Add(new MDB.MDBParameter("NhuCau5", ketQua.NhuCau5 ? 1 : 0));
                Command.Parameters.Add(new MDB.MDBParameter("PhuongPhap5", ketQua.PhuongPhap5));
                Command.Parameters.Add(new MDB.MDBParameter("PhuongPhap5_Khac", ketQua.PhuongPhap5_Khac));
                Command.Parameters.Add(new MDB.MDBParameter("NguoiTiepNhan5", ketQua.NguoiTiepNhan5));

                Command.Parameters.Add(new MDB.MDBParameter("NhuCau6", ketQua.NhuCau6 ? 1 : 0));
                Command.Parameters.Add(new MDB.MDBParameter("PhuongPhap6", ketQua.PhuongPhap6));
                Command.Parameters.Add(new MDB.MDBParameter("PhuongPhap6_Khac", ketQua.PhuongPhap6_Khac));
                Command.Parameters.Add(new MDB.MDBParameter("NguoiTiepNhan6", ketQua.NguoiTiepNhan6));

                Command.Parameters.Add(new MDB.MDBParameter("NhuCau7", ketQua.NhuCau7 ? 1 : 0));
                Command.Parameters.Add(new MDB.MDBParameter("PhuongPhap7", ketQua.PhuongPhap7));
                Command.Parameters.Add(new MDB.MDBParameter("PhuongPhap7_Khac", ketQua.PhuongPhap7_Khac));
                Command.Parameters.Add(new MDB.MDBParameter("NguoiTiepNhan7", ketQua.NguoiTiepNhan7));

                Command.Parameters.Add(new MDB.MDBParameter("NhuCau8", ketQua.NhuCau8 ? 1 : 0));
                Command.Parameters.Add(new MDB.MDBParameter("PhuongPhap8", ketQua.PhuongPhap8));
                Command.Parameters.Add(new MDB.MDBParameter("PhuongPhap8_Khac", ketQua.PhuongPhap8_Khac));
                Command.Parameters.Add(new MDB.MDBParameter("NguoiTiepNhan8", ketQua.NguoiTiepNhan8));

                Command.Parameters.Add(new MDB.MDBParameter("NhuCau9", ketQua.NhuCau9 ? 1 : 0));
                Command.Parameters.Add(new MDB.MDBParameter("PhuongPhap9", ketQua.PhuongPhap9));
                Command.Parameters.Add(new MDB.MDBParameter("PhuongPhap9_Khac", ketQua.PhuongPhap9_Khac));
                Command.Parameters.Add(new MDB.MDBParameter("NguoiTiepNhan9", ketQua.NguoiTiepNhan9));

                Command.Parameters.Add(new MDB.MDBParameter("NhuCau10", ketQua.NhuCau10 ? 1 : 0));
                Command.Parameters.Add(new MDB.MDBParameter("PhuongPhap10", ketQua.PhuongPhap10));
                Command.Parameters.Add(new MDB.MDBParameter("PhuongPhap10_Khac", ketQua.PhuongPhap10_Khac));
                Command.Parameters.Add(new MDB.MDBParameter("NguoiTiepNhan10", ketQua.NguoiTiepNhan10));

                Command.Parameters.Add(new MDB.MDBParameter("NhuCau11", ketQua.NhuCau11 ? 1 : 0));
                Command.Parameters.Add(new MDB.MDBParameter("PhuongPhap11", ketQua.PhuongPhap11));
                Command.Parameters.Add(new MDB.MDBParameter("PhuongPhap11_Khac", ketQua.PhuongPhap11_Khac));
                Command.Parameters.Add(new MDB.MDBParameter("NguoiTiepNhan11", ketQua.NguoiTiepNhan11));

                Command.Parameters.Add(new MDB.MDBParameter("NhuCau12_Text", ketQua.NhuCau12_Text));
                Command.Parameters.Add(new MDB.MDBParameter("NhuCau12", ketQua.NhuCau12 ? 1 : 0));
                Command.Parameters.Add(new MDB.MDBParameter("PhuongPhap12", ketQua.PhuongPhap12));
                Command.Parameters.Add(new MDB.MDBParameter("PhuongPhap12_Khac", ketQua.PhuongPhap12_Khac));
                Command.Parameters.Add(new MDB.MDBParameter("NguoiTiepNhan12", ketQua.NguoiTiepNhan12));

                Command.Parameters.Add(new MDB.MDBParameter("NhuCau13", ketQua.NhuCau13 ? 1 : 0));
                Command.Parameters.Add(new MDB.MDBParameter("PhuongPhap13", ketQua.PhuongPhap13));
                Command.Parameters.Add(new MDB.MDBParameter("PhuongPhap13_Khac", ketQua.PhuongPhap13_Khac));
                Command.Parameters.Add(new MDB.MDBParameter("NguoiTiepNhan13", ketQua.NguoiTiepNhan13));

                Command.Parameters.Add(new MDB.MDBParameter("NhuCau14", ketQua.NhuCau14 ? 1 : 0));
                Command.Parameters.Add(new MDB.MDBParameter("PhuongPhap14", ketQua.PhuongPhap14));
                Command.Parameters.Add(new MDB.MDBParameter("PhuongPhap14_Khac", ketQua.PhuongPhap14_Khac));
                Command.Parameters.Add(new MDB.MDBParameter("NguoiTiepNhan14", ketQua.NguoiTiepNhan14));

                Command.Parameters.Add(new MDB.MDBParameter("NhuCau15", ketQua.NhuCau15 ? 1 : 0));
                Command.Parameters.Add(new MDB.MDBParameter("PhuongPhap15", ketQua.PhuongPhap15));
                Command.Parameters.Add(new MDB.MDBParameter("PhuongPhap15_Khac", ketQua.PhuongPhap15_Khac));
                Command.Parameters.Add(new MDB.MDBParameter("NguoiTiepNhan15", ketQua.NguoiTiepNhan15));

                Command.Parameters.Add(new MDB.MDBParameter("NhuCau16", ketQua.NhuCau16 ? 1 : 0));
                Command.Parameters.Add(new MDB.MDBParameter("PhuongPhap16", ketQua.PhuongPhap16));
                Command.Parameters.Add(new MDB.MDBParameter("PhuongPhap16_Khac", ketQua.PhuongPhap16_Khac));
                Command.Parameters.Add(new MDB.MDBParameter("NguoiTiepNhan16", ketQua.NguoiTiepNhan16));

                Command.Parameters.Add(new MDB.MDBParameter("NhuCau17", ketQua.NhuCau17 ? 1 : 0));
                Command.Parameters.Add(new MDB.MDBParameter("PhuongPhap17", ketQua.PhuongPhap17));
                Command.Parameters.Add(new MDB.MDBParameter("PhuongPhap17_Khac", ketQua.PhuongPhap17_Khac));
                Command.Parameters.Add(new MDB.MDBParameter("NguoiTiepNhan17", ketQua.NguoiTiepNhan17));

                Command.Parameters.Add(new MDB.MDBParameter("NhuCau18_Text", ketQua.NhuCau18_Text));
                Command.Parameters.Add(new MDB.MDBParameter("NhuCau18", ketQua.NhuCau18 ? 1 : 0));
                Command.Parameters.Add(new MDB.MDBParameter("PhuongPhap18", ketQua.PhuongPhap18));
                Command.Parameters.Add(new MDB.MDBParameter("PhuongPhap18_Khac", ketQua.PhuongPhap18_Khac));
                Command.Parameters.Add(new MDB.MDBParameter("NguoiTiepNhan18", ketQua.NguoiTiepNhan18));

                Command.Parameters.Add(new MDB.MDBParameter("NgayThangSauNhapVien", ketQua.NgayThangSauNhapVien));
                Command.Parameters.Add(new MDB.MDBParameter("NgayThangTruocNhapVien", ketQua.NgayThangTruocNhapVien));
                Command.Parameters.Add(new MDB.MDBParameter("MaDieuDuongTruoc", ketQua.MaDieuDuongTruoc));
                Command.Parameters.Add(new MDB.MDBParameter("DieuDuongTruoc", ketQua.DieuDuongTruoc));
                Command.Parameters.Add(new MDB.MDBParameter("MaDieuDuongSau", ketQua.MaDieuDuongSau));
                Command.Parameters.Add(new MDB.MDBParameter("DieuDuongSau", ketQua.DieuDuongSau));
                Command.Parameters.Add(new MDB.MDBParameter("NGUOISUA", ketQua.NguoiSua));
                Command.Parameters.Add(new MDB.MDBParameter("NGAYSUA", ketQua.NgaySua));
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
                XuLyLoi.Handle(ex);
            }
            return false;
        }
        public static bool delete(MDB.MDBConnection MyConnection, long id)
        {
            try
            {
                string sql = "DELETE FROM TuVanGiaoDucSucKhoe WHERE ID = :ID";
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
                P.* 
            FROM
                TuVanGiaoDucSucKhoe P
            WHERE
                ID = " + id;

            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
            MDB.MDBDataAdapter adt = new MDB.MDBDataAdapter(Command);
            var ds = new DataSet();

            adt.Fill(ds, "KQ");

            ds.Tables[0].AddColumn("TenBenhNhan", typeof(string));
            ds.Tables[0].AddColumn("Tuoi", typeof(string));
            ds.Tables[0].AddColumn("NamSinh", typeof(string));
            ds.Tables[0].AddColumn("GioiTinh", typeof(int));
            ds.Tables[0].AddColumn("SOYTE", typeof(string));
            ds.Tables[0].AddColumn("BENHVIEN", typeof(string));

            ds.Tables[0].Rows[0]["TenBenhNhan"] = XemBenhAn._HanhChinhBenhNhan.TenBenhNhan;
            ds.Tables[0].Rows[0]["Tuoi"] = XemBenhAn._HanhChinhBenhNhan.Tuoi;
            ds.Tables[0].Rows[0]["NamSinh"] = XemBenhAn._HanhChinhBenhNhan.NgaySinh.HasValue ? XemBenhAn._HanhChinhBenhNhan.NgaySinh.Value.Year + "" : "";
            ds.Tables[0].Rows[0]["GioiTinh"] = (int)XemBenhAn._HanhChinhBenhNhan.GioiTinh;
            ds.Tables[0].Rows[0]["SOYTE"] = XemBenhAn._HanhChinhBenhNhan.SoYTe;
            ds.Tables[0].Rows[0]["BENHVIEN"] = XemBenhAn._HanhChinhBenhNhan.BenhVien;

            return ds;
        }
    }
}
