using EMR.KyDienTu;
using PMS.Access;
using System;
using System.Collections.Generic;
using System.Data;

namespace EMR_MAIN.DATABASE.Other
{
    public class BangDanhGiaNguyCoNgaVaHuongCanThiep : ThongTinKy
    {
        public BangDanhGiaNguyCoNgaVaHuongCanThiep()
        {
            TableName = "BangDGNguyCoTeNgaVaHCT";
            TablePrimaryKeyName = "ID";
            IDMauPhieu = (int)DanhMucPhieu.DGNCNVHCT;
            TenMauPhieu = DanhMucPhieu.DGNCNVHCT.Description();
        }
        [MoTaDuLieu("Mã định danh")]
		public long ID { get; set; }
        [MoTaDuLieu("Mã quản lý: mã duy nhất trong 1 đợt khám chữa bệnh (kcb), không trùng giữa các đợt kcb khác nhau","",1)]
		public decimal MaQuanLy { get; set; }
        [MoTaDuLieu("Mã bệnh nhân")]
		public string MaBenhNhan { get; set; }
        [MoTaDuLieu("Khoa")]
		public string Khoa { get; set; }
        [MoTaDuLieu("Mã khoa")]
		public string MaKhoa { get; set; }
        [MoTaDuLieu(" Họ và tên bệnh nhân")]
        public string HoTenBenhNhan { get; set; }
        [MoTaDuLieu("Tuổi bệnh nhân")]
		public string Tuoi { get; set; }
        [MoTaDuLieu("Giới tính bệnh nhân")]
		public string GioiTinh { get; set; }
        [MoTaDuLieu("Chẩn đoán bệnh")]
		public string ChanDoan { get; set; }
        [MoTaDuLieu("Ngày đánh giá lần thứ 1")]
        public DateTime? NgayDG1 { get; set; }
        [MoTaDuLieu("Giờ đánh giá lần thứ 1")]
        public DateTime? NgayDG1_Gio { get; set; }
        [MoTaDuLieu("Ngày đánh giá lần thứ 2")]
        public DateTime? NgayDG2 { get; set; }
        [MoTaDuLieu("Giờ đánh giá lần thứ 2")]
        public DateTime? NgayDG2_Gio { get; set; }
        [MoTaDuLieu("Ngày đánh giá lần thứ 3")]
        public DateTime? NgayDG3 { get; set; }
        [MoTaDuLieu("Giờ đánh giá lần thứ 3")]
        public DateTime? NgayDG3_Gio { get; set; }
        [MoTaDuLieu("Ngày đánh giá lần thứ 4")]
        public DateTime? NgayDG4 { get; set; }
        [MoTaDuLieu("Giờ đánh giá lần thứ 4")]
        public DateTime? NgayDG4_Gio { get; set; }
        [MoTaDuLieu("Ngày đánh giá lần thứ 5")]
        public DateTime? NgayDG5 { get; set; }
        [MoTaDuLieu("Giờ đánh giá lần thứ 5")]
        public DateTime? NgayDG5_Gio { get; set; }
        [MoTaDuLieu("Ngày đánh giá lần thứ 6")]
        public DateTime? NgayDG6 { get; set; }
        [MoTaDuLieu("Giờ đánh giá lần thứ 6")]
        public DateTime? NgayDG6_Gio { get; set; }
        [MoTaDuLieu("Ngày đánh giá lần thứ 7")]
        public DateTime? NgayDG7 { get; set; }
        [MoTaDuLieu("Giờ đánh giá lần thứ 6")]
        public DateTime? NgayDG7_Gio { get; set; }
        [MoTaDuLieu("Ngày can thiệp lần thứ 1")]
        public DateTime? NgayCT1 { get; set; }
        [MoTaDuLieu("Giờ can thiệp lần thứ 1")]
        public DateTime? NgayCT1_Gio { get; set; }
        [MoTaDuLieu("Ngày can thiệp lần thứ 2")]
        public DateTime? NgayCT2 { get; set; }
        [MoTaDuLieu("Giờ can thiệp lần thứ 2")]
        public DateTime? NgayCT2_Gio { get; set; }
        [MoTaDuLieu("Ngày can thiệp lần thứ 3")]
        public DateTime? NgayCT3 { get; set; }
        [MoTaDuLieu("Giờ can thiệp lần thứ 3")]
        public DateTime? NgayCT3_Gio { get; set; }
        [MoTaDuLieu("Ngày can thiệp lần thứ 4")]
        public DateTime? NgayCT4 { get; set; }
        [MoTaDuLieu("Giờ can thiệp lần thứ 4")]
        public DateTime? NgayCT4_Gio { get; set; }
        [MoTaDuLieu("Ngày can thiệp lần thứ 5")]
        public DateTime? NgayCT5 { get; set; }
        [MoTaDuLieu("Giờ can thiệp lần thứ 5")]
        public DateTime? NgayCT5_Gio { get; set; }
        [MoTaDuLieu("Ngày can thiệp lần thứ 6")]
        public DateTime? NgayCT6 { get; set; }
        [MoTaDuLieu("Giờ can thiệp lần thứ 6")]
        public DateTime? NgayCT6_Gio { get; set; }
        [MoTaDuLieu("Ngày can thiệp lần thứ 7")]
        public DateTime? NgayCT7 { get; set; }
        [MoTaDuLieu("Giờ can thiệp lần thứ 7")]
        public DateTime? NgayCT7_Gio { get; set; }
        public bool[] ND1Array { get; } = new bool[] { false, false, false, false, false, false, false };
        public string ND1
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < ND1Array.Length; i++)
                    temp += (ND1Array[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        ND1Array[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public bool[] ND2Array { get; } = new bool[] { false, false, false, false, false, false, false };
        public string ND2
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < ND2Array.Length; i++)
                    temp += (ND2Array[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        ND2Array[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public bool[] ND3Array { get; } = new bool[] { false, false, false, false, false, false, false };
        public string ND3
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < ND3Array.Length; i++)
                    temp += (ND3Array[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        ND3Array[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public bool[] ND4Array { get; } = new bool[] { false, false, false, false, false, false, false };
        public string ND4
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < ND4Array.Length; i++)
                    temp += (ND4Array[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        ND4Array[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public bool[] ND5Array { get; } = new bool[] { false, false, false, false, false, false, false };
        public string ND5
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < ND5Array.Length; i++)
                    temp += (ND5Array[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        ND5Array[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public bool[] ND6Array { get; } = new bool[] { false, false, false, false, false, false, false };
        public string ND6
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < ND6Array.Length; i++)
                    temp += (ND6Array[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        ND6Array[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public bool[] ND7Array { get; } = new bool[] { false, false, false, false, false, false, false };
        public string ND7
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < ND7Array.Length; i++)
                    temp += (ND7Array[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        ND7Array[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public bool[] ND8Array { get; } = new bool[] { false, false, false, false, false, false, false };
        public string ND8
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < ND8Array.Length; i++)
                    temp += (ND8Array[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        ND8Array[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public bool[] ND9Array { get; } = new bool[] { false, false, false, false, false, false, false };
        public string ND9
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < ND9Array.Length; i++)
                    temp += (ND9Array[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        ND9Array[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public bool[] ND10Array { get; } = new bool[] { false, false, false, false, false, false, false };
        public string ND10
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < ND10Array.Length; i++)
                    temp += (ND10Array[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        ND10Array[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public bool[] ND11Array { get; } = new bool[] { false, false, false, false, false, false, false };
        public string ND11
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < ND11Array.Length; i++)
                    temp += (ND11Array[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        ND11Array[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public bool[] ND12Array { get; } = new bool[] { false, false, false, false, false, false, false };
        public string ND12
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < ND12Array.Length; i++)
                    temp += (ND12Array[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        ND12Array[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public bool[] ND13Array { get; } = new bool[] { false, false, false, false, false, false, false };
        public string ND13
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < ND13Array.Length; i++)
                    temp += (ND13Array[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        ND13Array[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public bool[] ND14Array { get; } = new bool[] { false, false, false, false, false, false, false };
        public string ND14
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < ND14Array.Length; i++)
                    temp += (ND14Array[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        ND14Array[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public bool[] ND15Array { get; } = new bool[] { false, false, false, false, false, false, false };
        public string ND15
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < ND15Array.Length; i++)
                    temp += (ND15Array[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        ND15Array[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public bool[] ND16Array { get; } = new bool[] { false, false, false, false, false, false, false };
        public string ND16
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < ND16Array.Length; i++)
                    temp += (ND16Array[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        ND16Array[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public bool[] ND17Array { get; } = new bool[] { false, false, false, false, false, false, false };
        public string ND17
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < ND17Array.Length; i++)
                    temp += (ND17Array[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        ND17Array[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public bool[] ND18Array { get; } = new bool[] { false, false, false, false, false, false, false };
        public string ND18
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < ND18Array.Length; i++)
                    temp += (ND18Array[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        ND18Array[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public bool[] ND19Array { get; } = new bool[] { false, false, false, false, false, false, false };
        public string ND19
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < ND19Array.Length; i++)
                    temp += (ND19Array[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        ND19Array[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public bool[] ND20Array { get; } = new bool[] { false, false, false, false, false, false, false };
        public string ND20
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < ND20Array.Length; i++)
                    temp += (ND20Array[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        ND20Array[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public bool[] ND21Array { get; } = new bool[] { false, false, false, false, false, false, false };
        public string ND21
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < ND21Array.Length; i++)
                    temp += (ND21Array[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        ND21Array[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public bool[] ND22Array { get; } = new bool[] { false, false, false, false, false, false, false };
        public string ND22
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < ND22Array.Length; i++)
                    temp += (ND22Array[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        ND22Array[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public bool[] ND23Array { get; } = new bool[] { false, false, false, false, false, false, false };
        public string ND23
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < ND23Array.Length; i++)
                    temp += (ND23Array[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        ND23Array[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }



        public bool[] NC1Array { get; } = new bool[] { false, false, false, false, false, false, false };
        public string NC1
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < NC1Array.Length; i++)
                    temp += (NC1Array[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        NC1Array[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public bool[] NC2Array { get; } = new bool[] { false, false, false, false, false, false, false };
        public string NC2
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < NC2Array.Length; i++)
                    temp += (NC2Array[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        NC2Array[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public bool[] NC3Array { get; } = new bool[] { false, false, false, false, false, false, false };
        public string NC3
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < NC3Array.Length; i++)
                    temp += (NC3Array[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        NC3Array[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public bool[] NC4Array { get; } = new bool[] { false, false, false, false, false, false, false };
        public string NC4
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < NC4Array.Length; i++)
                    temp += (NC4Array[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        NC4Array[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public bool[] NC5Array { get; } = new bool[] { false, false, false, false, false, false, false };
        public string NC5
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < NC5Array.Length; i++)
                    temp += (NC5Array[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        NC5Array[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public bool[] NC6Array { get; } = new bool[] { false, false, false, false, false, false, false };
        public string NC6
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < NC6Array.Length; i++)
                    temp += (NC6Array[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        NC6Array[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public bool[] NC7Array { get; } = new bool[] { false, false, false, false, false, false, false };
        public string NC7
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < NC7Array.Length; i++)
                    temp += (NC7Array[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        NC7Array[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public bool[] NC8Array { get; } = new bool[] { false, false, false, false, false, false, false };
        public string NC8
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < NC8Array.Length; i++)
                    temp += (NC8Array[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        NC8Array[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public bool[] NC9Array { get; } = new bool[] { false, false, false, false, false, false, false };
        public string NC9
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < NC9Array.Length; i++)
                    temp += (NC9Array[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        NC9Array[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public bool[] NC10Array { get; } = new bool[] { false, false, false, false, false, false, false };
        public string NC10
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < NC10Array.Length; i++)
                    temp += (NC10Array[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        NC10Array[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public bool[] NC11Array { get; } = new bool[] { false, false, false, false, false, false, false };
        public string NC11
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < NC11Array.Length; i++)
                    temp += (NC11Array[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        NC11Array[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public bool[] NC12Array { get; } = new bool[] { false, false, false, false, false, false, false };
        public string NC12
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < NC12Array.Length; i++)
                    temp += (NC12Array[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        NC12Array[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        [MoTaDuLieu("Tổng điểm đánh giá lần 1")]
        public int? TongDiem1 { get; set; }
        [MoTaDuLieu("Tổng điểm đánh giá lần 2")]
        public int? TongDiem2 { get; set; }
        [MoTaDuLieu("Tổng điểm đánh giá lần 3")]
        public int? TongDiem3 { get; set; }
        [MoTaDuLieu("Tổng điểm đánh giá lần 4")]
        public int? TongDiem4 { get; set; }
        [MoTaDuLieu("Tổng điểm đánh giá lần 5")]
        public int? TongDiem5 { get; set; }
        [MoTaDuLieu("Tổng điểm đánh giá lần 6")]
        public int? TongDiem6 { get; set; }
        [MoTaDuLieu("Tổng điểm đánh giá lần 7")]
        public int? TongDiem7 { get; set; }
        [MoTaDuLieu("Mã người đánh giá lần 1")]
        public string MaNguoiDanhGia1 { get; set; }
        [MoTaDuLieu("Họ tên người đánh giá lần 1")]
        public string NguoiDanhGia1 { get; set; }
        [MoTaDuLieu("Mã người can thiệp lần 1")]
        public string MaNguoiCanThiep1 { get; set; }
        [MoTaDuLieu("Họ tên người can thiệp lần 1")]
        public string NguoiCanThiep1 { get; set; }
        [MoTaDuLieu("Mã người đánh giá lần 2")]
        public string MaNguoiDanhGia2 { get; set; }
        [MoTaDuLieu("Họ tên người đánh giá lần 2")]
        public string NguoiDanhGia2 { get; set; }
        [MoTaDuLieu("Mã người can thiệp lần 2")]
        public string MaNguoiCanThiep2 { get; set; }
        [MoTaDuLieu("Họ tên người can thiệp lần 2")]
        public string NguoiCanThiep2 { get; set; }
        [MoTaDuLieu("Mã người đánh giá lần 3")]
        public string MaNguoiDanhGia3 { get; set; }
        [MoTaDuLieu("Họ tên người đánh giá lần 3")]
        public string NguoiDanhGia3 { get; set; }
        [MoTaDuLieu("Mã người can thiệp lần 3")]
        public string MaNguoiCanThiep3 { get; set; }
        [MoTaDuLieu("Họ tên người can thiệp lần 3")]
        public string NguoiCanThiep3 { get; set; }
        [MoTaDuLieu("Mã người đánh giá lần 4")]
        public string MaNguoiDanhGia4 { get; set; }
        [MoTaDuLieu("Họ tên người đánh giá lần 4")]
        public string NguoiDanhGia4 { get; set; }
        [MoTaDuLieu("Mã người can thiệp lần 4")]
        public string MaNguoiCanThiep4 { get; set; }
        [MoTaDuLieu("Họ tên người can thiệp lần 4")]
        public string NguoiCanThiep4 { get; set; }
        [MoTaDuLieu("Mã người đánh giá lần 5")]
        public string MaNguoiDanhGia5 { get; set; }
        [MoTaDuLieu("Họ tên người đánh giá lần 5")]
        public string NguoiDanhGia5 { get; set; }
        [MoTaDuLieu("Mã người can thiệp lần 5")]
        public string MaNguoiCanThiep5 { get; set; }
        [MoTaDuLieu("Họ tên người can thiệp lần 5")]
        public string NguoiCanThiep5 { get; set; }
        [MoTaDuLieu("Mã người đánh giá lần 6")]
        public string MaNguoiDanhGia6 { get; set; }
        [MoTaDuLieu("Họ tên người đánh giá lần 6")]
        public string NguoiDanhGia6 { get; set; }
        [MoTaDuLieu("Mã người can thiệp lần 6")]
        public string MaNguoiCanThiep6 { get; set; }
        [MoTaDuLieu("Họ tên người can thiệp lần 6")]
        public string NguoiCanThiep6 { get; set; }
        [MoTaDuLieu("Mã người đánh giá lần 7")]
        public string MaNguoiDanhGia7 { get; set; }
        [MoTaDuLieu("Họ tên người đánh giá lần 7")]
        public string NguoiDanhGia7 { get; set; }
        [MoTaDuLieu("Mã người can thiệp lần 7")]
        public string MaNguoiCanThiep7 { get; set; }
        [MoTaDuLieu("Họ tên người can thiệp lần 7")]
        public string NguoiCanThiep7 { get; set; }
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
    public class BangDanhGiaNguyCoNgaVaHuongCanThiepFunc
    {
        public const string TableName = "BangDGNguyCoTeNgaVaHCT";
        public const string TablePrimaryKeyName = "ID";
        public static List<BangDanhGiaNguyCoNgaVaHuongCanThiep> GetListData(MDB.MDBConnection _OracleConnection, decimal maquanly)
        {
            List<BangDanhGiaNguyCoNgaVaHuongCanThiep> list = new List<BangDanhGiaNguyCoNgaVaHuongCanThiep>();
            try
            {
                string sql = @"SELECT * FROM BangDGNguyCoTeNgaVaHCT where MaQuanLy = :MaQuanLy";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, _OracleConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", maquanly));
                MDB.MDBDataReader DataReader = Command.ExecuteReader();
                while (DataReader.Read())
                {
                    BangDanhGiaNguyCoNgaVaHuongCanThiep data = new BangDanhGiaNguyCoNgaVaHuongCanThiep();
                    data.ID = Convert.ToInt64(DataReader.GetLong("ID").ToString());
                    data.MaQuanLy = maquanly;
                    data.MaBenhNhan = DataReader["MaBenhNhan"].ToString();
                    data.Khoa = DataReader["Khoa"].ToString();
                    data.MaKhoa = DataReader["MaKhoa"].ToString();
                    data.HoTenBenhNhan = XemBenhAn._HanhChinhBenhNhan.TenBenhNhan;
                    data.Tuoi = XemBenhAn._HanhChinhBenhNhan.Tuoi;
                    data.GioiTinh = XemBenhAn._HanhChinhBenhNhan.GioiTinh.Description();
                    data.ChanDoan = DataReader["ChanDoan"].ToString();

                    data.NgayDG1 = DataReader["NgayDG1"] != DBNull.Value ? (DateTime?)Convert.ToDateTime(DataReader["NgayDG1"]): null;
                    data.NgayDG2 = DataReader["NgayDG2"] != DBNull.Value ? (DateTime?)Convert.ToDateTime(DataReader["NgayDG2"]): null;
                    data.NgayDG3 = DataReader["NgayDG3"] != DBNull.Value ? (DateTime?)Convert.ToDateTime(DataReader["NgayDG3"]): null;
                    data.NgayDG4 = DataReader["NgayDG4"] != DBNull.Value ? (DateTime?)Convert.ToDateTime(DataReader["NgayDG4"]): null;
                    data.NgayDG5 = DataReader["NgayDG5"] != DBNull.Value ? (DateTime?)Convert.ToDateTime(DataReader["NgayDG5"]): null;
                    data.NgayDG6 = DataReader["NgayDG6"] != DBNull.Value ? (DateTime?)Convert.ToDateTime(DataReader["NgayDG6"]): null;
                    data.NgayDG7 = DataReader["NgayDG7"] != DBNull.Value ? (DateTime?)Convert.ToDateTime(DataReader["NgayDG7"]): null;
                    data.NgayDG1_Gio = DataReader["NgayDG1_Gio"] != DBNull.Value ? (DateTime?)Convert.ToDateTime(DataReader["NgayDG1_Gio"]) : null;
                    data.NgayDG2_Gio = DataReader["NgayDG2_Gio"] != DBNull.Value ? (DateTime?)Convert.ToDateTime(DataReader["NgayDG2_Gio"]) : null;
                    data.NgayDG3_Gio = DataReader["NgayDG3_Gio"] != DBNull.Value ? (DateTime?)Convert.ToDateTime(DataReader["NgayDG3_Gio"]) : null;
                    data.NgayDG4_Gio = DataReader["NgayDG4_Gio"] != DBNull.Value ? (DateTime?)Convert.ToDateTime(DataReader["NgayDG4_Gio"]) : null;
                    data.NgayDG5_Gio = DataReader["NgayDG5_Gio"] != DBNull.Value ? (DateTime?)Convert.ToDateTime(DataReader["NgayDG5_Gio"]) : null;
                    data.NgayDG6_Gio = DataReader["NgayDG6_Gio"] != DBNull.Value ? (DateTime?)Convert.ToDateTime(DataReader["NgayDG6_Gio"]) : null;
                    data.NgayDG7_Gio = DataReader["NgayDG7_Gio"] != DBNull.Value ? (DateTime?)Convert.ToDateTime(DataReader["NgayDG7_Gio"]) : null;

                    data.NgayCT1 = DataReader["NgayCT1"] != DBNull.Value ? (DateTime?)Convert.ToDateTime(DataReader["NgayCT1"]) : null;
                    data.NgayCT2 = DataReader["NgayCT2"] != DBNull.Value ? (DateTime?)Convert.ToDateTime(DataReader["NgayCT2"]) : null;
                    data.NgayCT3 = DataReader["NgayCT3"] != DBNull.Value ? (DateTime?)Convert.ToDateTime(DataReader["NgayCT3"]) : null;
                    data.NgayCT4 = DataReader["NgayCT4"] != DBNull.Value ? (DateTime?)Convert.ToDateTime(DataReader["NgayCT4"]) : null;
                    data.NgayCT5 = DataReader["NgayCT5"] != DBNull.Value ? (DateTime?)Convert.ToDateTime(DataReader["NgayCT5"]) : null;
                    data.NgayCT6 = DataReader["NgayCT6"] != DBNull.Value ? (DateTime?)Convert.ToDateTime(DataReader["NgayCT6"]) : null;
                    data.NgayCT7 = DataReader["NgayCT7"] != DBNull.Value ? (DateTime?)Convert.ToDateTime(DataReader["NgayCT7"]) : null;

                    data.NgayCT1_Gio = DataReader["NgayCT1_Gio"] != DBNull.Value ? (DateTime?)Convert.ToDateTime(DataReader["NgayCT1_Gio"]) : null;
                    data.NgayCT2_Gio = DataReader["NgayCT2_Gio"] != DBNull.Value ? (DateTime?)Convert.ToDateTime(DataReader["NgayCT2_Gio"]) : null;
                    data.NgayCT3_Gio = DataReader["NgayCT3_Gio"] != DBNull.Value ? (DateTime?)Convert.ToDateTime(DataReader["NgayCT3_Gio"]) : null;
                    data.NgayCT4_Gio = DataReader["NgayCT4_Gio"] != DBNull.Value ? (DateTime?)Convert.ToDateTime(DataReader["NgayCT4_Gio"]) : null;
                    data.NgayCT5_Gio = DataReader["NgayCT5_Gio"] != DBNull.Value ? (DateTime?)Convert.ToDateTime(DataReader["NgayCT5_Gio"]) : null;
                    data.NgayCT6_Gio = DataReader["NgayCT6_Gio"] != DBNull.Value ? (DateTime?)Convert.ToDateTime(DataReader["NgayCT6_Gio"]) : null;
                    data.NgayCT7_Gio = DataReader["NgayCT7_Gio"] != DBNull.Value ? (DateTime?)Convert.ToDateTime(DataReader["NgayCT7_Gio"]) : null;


                    data.ND1 = DataReader["ND1"].ToString();
                    data.ND2 = DataReader["ND2"].ToString();
                    data.ND3 = DataReader["ND3"].ToString();
                    data.ND4 = DataReader["ND4"].ToString();
                    data.ND5 = DataReader["ND5"].ToString();
                    data.ND6 = DataReader["ND6"].ToString();
                    data.ND7 = DataReader["ND7"].ToString();
                    data.ND8 = DataReader["ND8"].ToString();
                    data.ND9 = DataReader["ND9"].ToString();
                    data.ND10 = DataReader["ND10"].ToString();
                    data.ND11 = DataReader["ND11"].ToString();
                    data.ND12 = DataReader["ND12"].ToString();
                    data.ND13 = DataReader["ND13"].ToString();
                    data.ND14 = DataReader["ND14"].ToString();
                    data.ND15 = DataReader["ND15"].ToString();
                    data.ND16 = DataReader["ND16"].ToString();
                    data.ND17 = DataReader["ND17"].ToString();
                    data.ND18 = DataReader["ND18"].ToString();
                    data.ND19 = DataReader["ND19"].ToString();
                    data.ND20 = DataReader["ND20"].ToString();
                    data.ND21 = DataReader["ND21"].ToString();
                    data.ND22 = DataReader["ND22"].ToString();
                    data.ND23 = DataReader["ND23"].ToString();

                    data.NC1 = DataReader["NC1"].ToString();
                    data.NC2 = DataReader["NC2"].ToString();
                    data.NC3 = DataReader["NC3"].ToString();
                    data.NC4 = DataReader["NC4"].ToString();
                    data.NC5 = DataReader["NC5"].ToString();
                    data.NC6 = DataReader["NC6"].ToString();
                    data.NC7 = DataReader["NC7"].ToString();
                    data.NC8 = DataReader["NC8"].ToString();
                    data.NC9 = DataReader["NC9"].ToString();
                    data.NC10 = DataReader["NC10"].ToString();
                    data.NC11 = DataReader["NC11"].ToString();
                    data.NC12 = DataReader["NC12"].ToString();

                    int tempInt = 0;
                    data.TongDiem1 = int.TryParse(DataReader["TongDiem1"].ToString(), out tempInt) ? tempInt : 0;

                    data.MaNguoiDanhGia1 = DataReader["MaNguoiDanhGia1"].ToString();
                    data.NguoiDanhGia1 = DataReader["NguoiDanhGia1"].ToString();
                    data.MaNguoiCanThiep1 = DataReader["MaNguoiCanThiep1"].ToString();
                    data.NguoiCanThiep1 = DataReader["NguoiCanThiep1"].ToString();
                    data.MaNguoiDanhGia2 = DataReader["MaNguoiDanhGia2"].ToString();
                    data.NguoiDanhGia2 = DataReader["NguoiDanhGia2"].ToString();
                    data.MaNguoiCanThiep2 = DataReader["MaNguoiCanThiep2"].ToString();
                    data.NguoiCanThiep2 = DataReader["NguoiCanThiep2"].ToString();
                    data.MaNguoiDanhGia3 = DataReader["MaNguoiDanhGia3"].ToString();
                    data.NguoiDanhGia3 = DataReader["NguoiDanhGia3"].ToString();
                    data.MaNguoiCanThiep3 = DataReader["MaNguoiCanThiep3"].ToString();
                    data.NguoiCanThiep3 = DataReader["NguoiCanThiep3"].ToString();
                    data.MaNguoiDanhGia4 = DataReader["MaNguoiDanhGia4"].ToString();
                    data.NguoiDanhGia4 = DataReader["NguoiDanhGia4"].ToString();
                    data.MaNguoiCanThiep4 = DataReader["MaNguoiCanThiep4"].ToString();
                    data.NguoiCanThiep4 = DataReader["NguoiCanThiep4"].ToString();
                    data.MaNguoiDanhGia5 = DataReader["MaNguoiDanhGia5"].ToString();
                    data.NguoiDanhGia5 = DataReader["NguoiDanhGia5"].ToString();
                    data.MaNguoiCanThiep5 = DataReader["MaNguoiCanThiep5"].ToString();
                    data.NguoiCanThiep5 = DataReader["NguoiCanThiep5"].ToString();
                    data.MaNguoiDanhGia6 = DataReader["MaNguoiDanhGia6"].ToString();
                    data.NguoiDanhGia6 = DataReader["NguoiDanhGia6"].ToString();
                    data.MaNguoiCanThiep6 = DataReader["MaNguoiCanThiep6"].ToString();
                    data.NguoiCanThiep6 = DataReader["NguoiCanThiep6"].ToString();
                    data.MaNguoiDanhGia7 = DataReader["MaNguoiDanhGia7"].ToString();
                    data.NguoiDanhGia7 = DataReader["NguoiDanhGia7"].ToString();
                    data.MaNguoiCanThiep7 = DataReader["MaNguoiCanThiep7"].ToString();
                    data.NguoiCanThiep7 = DataReader["NguoiCanThiep7"].ToString();


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
        public static bool InsertOrUpdate(MDB.MDBConnection MyConnection, ref BangDanhGiaNguyCoNgaVaHuongCanThiep ketQua)
        {
            try
            {
                string sql = @"INSERT INTO BangDGNguyCoTeNgaVaHCT
                (
                    MAQUANLY,
                    MaBenhNhan,
                    ChanDoan,
                    Khoa,
                    MaKhoa,
                    NgayDG1,
                    NgayDG2,
                    NgayDG3,
                    NgayDG4,
                    NgayDG5,
                    NgayDG6,
                    NgayDG7,
                    NgayCT1,
                    NgayCT2,
                    NgayCT3,
                    NgayCT4,
                    NgayCT5,
                    NgayCT6,
                    NgayCT7,
                    NgayDG1_Gio,
                    NgayDG2_Gio,
                    NgayDG3_Gio,
                    NgayDG4_Gio,
                    NgayDG5_Gio,
                    NgayDG6_Gio,
                    NgayDG7_Gio,
                    NgayCT1_Gio,
                    NgayCT2_Gio,
                    NgayCT3_Gio,
                    NgayCT4_Gio,
                    NgayCT5_Gio,
                    NgayCT6_Gio,
                    NgayCT7_Gio,   
                    ND1,
                    ND2,
                    ND3,
                    ND4,
                    ND5,
                    ND6,
                    ND7,
                    ND8,
                    ND9,
                    ND10,
                    ND11,
                    ND12,
                    ND13,
                    ND14,
                    ND15,
                    ND16,
                    ND17,
                    ND18,
                    ND19,
                    ND20,
                    ND21,
                    ND22,
                    ND23,
                    NC1,
                    NC2,
                    NC3,
                    NC4,
                    NC5,
                    NC6,
                    NC7,
                    NC8,
                    NC9,
                    NC10,
                    NC11,
                    NC12,
                    TongDiem1,
                    TongDiem2,
                    TongDiem3,
                    TongDiem4,
                    TongDiem5,
                    TongDiem6,
                    TongDiem7,
                    MaNguoiDanhGia1,
                    NguoiDanhGia1,
                    MaNguoiCanThiep1,
                    NguoiCanThiep1,
                    MaNguoiDanhGia2,
                    NguoiDanhGia2,
                    MaNguoiCanThiep2,
                    NguoiCanThiep2,
                    MaNguoiDanhGia3,
                    NguoiDanhGia3,
                    MaNguoiCanThiep3,
                    NguoiCanThiep3,
                    MaNguoiDanhGia4,
                    NguoiDanhGia4,
                    MaNguoiCanThiep4,
                    NguoiCanThiep4,
                    MaNguoiDanhGia5,
                    NguoiDanhGia5,
                    MaNguoiCanThiep5,
                    NguoiCanThiep5,
                    MaNguoiDanhGia6,
                    NguoiDanhGia6,
                    MaNguoiCanThiep6,
                    NguoiCanThiep6,
                    MaNguoiDanhGia7,
                    NguoiDanhGia7,
                    MaNguoiCanThiep7,
                    NguoiCanThiep7,
                    NGUOITAO,
                    NGUOISUA,
                    NGAYTAO,
                    NGAYSUA)  VALUES
                 (
				    :MAQUANLY,
                    :MaBenhNhan,
                    :ChanDoan,
                    :Khoa,
                    :MaKhoa,
                    :NgayDG1,
                    :NgayDG2,
                    :NgayDG3,
                    :NgayDG4,
                    :NgayDG5,
                    :NgayDG6,
                    :NgayDG7,
                    :NgayCT1,
                    :NgayCT2,
                    :NgayCT3,
                    :NgayCT4,
                    :NgayCT5,
                    :NgayCT6,
                    :NgayCT7,
                    :NgayDG1_Gio,
                    :NgayDG2_Gio,
                    :NgayDG3_Gio,
                    :NgayDG4_Gio,
                    :NgayDG5_Gio,
                    :NgayDG6_Gio,
                    :NgayDG7_Gio,
                    :NgayCT1_Gio,
                    :NgayCT2_Gio,
                    :NgayCT3_Gio,
                    :NgayCT4_Gio,
                    :NgayCT5_Gio,
                    :NgayCT6_Gio,
                    :NgayCT7_Gio,
                    :ND1,
                    :ND2,
                    :ND3,
                    :ND4,
                    :ND5,
                    :ND6,
                    :ND7,
                    :ND8,
                    :ND9,
                    :ND10,
                    :ND11,
                    :ND12,
                    :ND13,
                    :ND14,
                    :ND15,
                    :ND16,
                    :ND17,
                    :ND18,
                    :ND19,
                    :ND20,
                    :ND21,
                    :ND22,
                    :ND23,
                    :NC1,
                    :NC2,
                    :NC3,
                    :NC4,
                    :NC5,
                    :NC6,
                    :NC7,
                    :NC8,
                    :NC9,
                    :NC10,
                    :NC11,
                    :NC12,
                    :TongDiem1,
                    :TongDiem2,
                    :TongDiem3,
                    :TongDiem4,
                    :TongDiem5,
                    :TongDiem6,
                    :TongDiem7,
                    :MaNguoiDanhGia1,
                    :NguoiDanhGia1,
                    :MaNguoiCanThiep1,
                    :NguoiCanThiep1,
                    :MaNguoiDanhGia2,
                    :NguoiDanhGia2,
                    :MaNguoiCanThiep2,
                    :NguoiCanThiep2,
                    :MaNguoiDanhGia3,
                    :NguoiDanhGia3,
                    :MaNguoiCanThiep3,
                    :NguoiCanThiep3,
                    :MaNguoiDanhGia4,
                    :NguoiDanhGia4,
                    :MaNguoiCanThiep4,
                    :NguoiCanThiep4,
                    :MaNguoiDanhGia5,
                    :NguoiDanhGia5,
                    :MaNguoiCanThiep5,
                    :NguoiCanThiep5,
                    :MaNguoiDanhGia6,
                    :NguoiDanhGia6,
                    :MaNguoiCanThiep6,
                    :NguoiCanThiep6,
                    :MaNguoiDanhGia7,
                    :NguoiDanhGia7,
                    :MaNguoiCanThiep7,
                    :NguoiCanThiep7,
                    :NGUOITAO,
                    :NGUOISUA,
                    :NGAYTAO,
                    :NGAYSUA
                 )  RETURNING ID INTO :ID";
                if (ketQua.ID != 0)
                {
                    sql = @"UPDATE BangDGNguyCoTeNgaVaHCT SET 
                    MAQUANLY = :MAQUANLY,
                    MaBenhNhan = :MaBenhNhan,
                    ChanDoan = :ChanDoan,
                    Khoa = :Khoa,
                    MaKhoa = :MaKhoa,
                    NgayDG1 = :NgayDG1,
                    NgayDG2 = :NgayDG2,
                    NgayDG3 = :NgayDG3,
                    NgayDG4 = :NgayDG4,
                    NgayDG5 = :NgayDG5,
                    NgayDG6 = :NgayDG6,
                    NgayDG7 = :NgayDG7,
                    NgayCT1 = :NgayCT1,
                    NgayCT2 = :NgayCT2,
                    NgayCT3 = :NgayCT3,
                    NgayCT4 = :NgayCT4,
                    NgayCT5 = :NgayCT5,
                    NgayCT6 = :NgayCT6,
                    NgayCT7 = :NgayCT7,
                    NgayDG1_Gio = :NgayDG1_Gio,
                    NgayDG2_Gio = :NgayDG2_Gio,
                    NgayDG3_Gio = :NgayDG3_Gio,
                    NgayDG4_Gio = :NgayDG4_Gio,
                    NgayDG5_Gio = :NgayDG5_Gio,
                    NgayDG6_Gio = :NgayDG6_Gio,
                    NgayDG7_Gio = :NgayDG7_Gio,
                    NgayCT1_Gio = :NgayCT1_Gio,
                    NgayCT2_Gio = :NgayCT2_Gio,
                    NgayCT3_Gio = :NgayCT3_Gio,
                    NgayCT4_Gio = :NgayCT4_Gio,
                    NgayCT5_Gio = :NgayCT5_Gio,
                    NgayCT6_Gio = :NgayCT6_Gio,
                    NgayCT7_Gio = :NgayCT7_Gio,
                    ND1 = :ND1,
                    ND2 = :ND2,
                    ND3 = :ND3,
                    ND4 = :ND4,
                    ND5 = :ND5,
                    ND6 = :ND6,
                    ND7 = :ND7,
                    ND8 = :ND8,
                    ND9 = :ND9,
                    ND10 = :ND10,
                    ND11 = :ND11,
                    ND12 = :ND12,
                    ND13 = :ND13,
                    ND14 = :ND14,
                    ND15 = :ND15,
                    ND16 = :ND16,
                    ND17 = :ND17,
                    ND18 = :ND18,
                    ND19 = :ND19,
                    ND20 = :ND20,
                    ND21 = :ND21,
                    ND22 = :ND22,
                    ND23 = :ND23,
                    NC1 = :NC1,
                    NC2 = :NC2,
                    NC3 = :NC3,
                    NC4 = :NC4,
                    NC5 = :NC5,
                    NC6 = :NC6,
                    NC7 = :NC7,
                    NC8 = :NC8,
                    NC9 = :NC9,
                    NC10 = :NC10,
                    NC11 = :NC11,
                    NC12 = :NC12,
                    TongDiem1 = :TongDiem1,
                    TongDiem2 = :TongDiem2,
                    TongDiem3 = :TongDiem3,
                    TongDiem4 = :TongDiem4,
                    TongDiem5 = :TongDiem5,
                    TongDiem6 = :TongDiem6,
                    TongDiem7 = :TongDiem7,
                    MaNguoiDanhGia1 = :MaNguoiDanhGia1,
                    NguoiDanhGia1 = :NguoiDanhGia1,
                    MaNguoiCanThiep1 = :MaNguoiCanThiep1,
                    NguoiCanThiep1 = :NguoiCanThiep1,
                    MaNguoiDanhGia2 = :MaNguoiDanhGia2,
                    NguoiDanhGia2 = :NguoiDanhGia2,
                    MaNguoiCanThiep2 = :MaNguoiCanThiep2,
                    NguoiCanThiep2 = :NguoiCanThiep2,
                    MaNguoiDanhGia3 = :MaNguoiDanhGia3,
                    NguoiDanhGia3 = :NguoiDanhGia3,
                    MaNguoiCanThiep3 = :MaNguoiCanThiep3,
                    NguoiCanThiep3 = :NguoiCanThiep3,
                    MaNguoiDanhGia4 = :MaNguoiDanhGia4,
                    NguoiDanhGia4 = :NguoiDanhGia4,
                    MaNguoiCanThiep4 = :MaNguoiCanThiep4,
                    NguoiCanThiep4 = :NguoiCanThiep4,
                    MaNguoiDanhGia5 = :MaNguoiDanhGia5,
                    NguoiDanhGia5 = :NguoiDanhGia5,
                    MaNguoiCanThiep5 = :MaNguoiCanThiep5,
                    NguoiCanThiep5 = :NguoiCanThiep5,
                    MaNguoiDanhGia6 = :MaNguoiDanhGia6,
                    NguoiDanhGia6 = :NguoiDanhGia6,
                    MaNguoiCanThiep6 = :MaNguoiCanThiep6,
                    NguoiCanThiep6 = :NguoiCanThiep6,
                    MaNguoiDanhGia7 = :MaNguoiDanhGia7,
                    NguoiDanhGia7 = :NguoiDanhGia7,
                    MaNguoiCanThiep7 = :MaNguoiCanThiep7,
                    NguoiCanThiep7 = :NguoiCanThiep7,
                    NGUOISUA = :NGUOISUA,
                    NGAYSUA = :NGAYSUA
                    WHERE ID = " + ketQua.ID;
                }
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MAQUANLY", ketQua.MaQuanLy));
                Command.Parameters.Add(new MDB.MDBParameter("MaBenhNhan", ketQua.MaBenhNhan));
                Command.Parameters.Add(new MDB.MDBParameter("ChanDoan", ketQua.ChanDoan));
                Command.Parameters.Add(new MDB.MDBParameter("Khoa", ketQua.Khoa));
                Command.Parameters.Add(new MDB.MDBParameter("MaKhoa", ketQua.MaKhoa));

                Command.Parameters.Add(new MDB.MDBParameter("NgayDG1", ketQua.NgayDG1));
                Command.Parameters.Add(new MDB.MDBParameter("NgayDG2", ketQua.NgayDG2));
                Command.Parameters.Add(new MDB.MDBParameter("NgayDG3", ketQua.NgayDG3));
                Command.Parameters.Add(new MDB.MDBParameter("NgayDG4", ketQua.NgayDG4));
                Command.Parameters.Add(new MDB.MDBParameter("NgayDG5", ketQua.NgayDG5));
                Command.Parameters.Add(new MDB.MDBParameter("NgayDG6", ketQua.NgayDG6));
                Command.Parameters.Add(new MDB.MDBParameter("NgayDG7", ketQua.NgayDG7));

                Command.Parameters.Add(new MDB.MDBParameter("NgayCT1", ketQua.NgayCT1));
                Command.Parameters.Add(new MDB.MDBParameter("NgayCT2", ketQua.NgayCT2));
                Command.Parameters.Add(new MDB.MDBParameter("NgayCT3", ketQua.NgayCT3));
                Command.Parameters.Add(new MDB.MDBParameter("NgayCT4", ketQua.NgayCT4));
                Command.Parameters.Add(new MDB.MDBParameter("NgayCT5", ketQua.NgayCT5));
                Command.Parameters.Add(new MDB.MDBParameter("NgayCT6", ketQua.NgayCT6));
                Command.Parameters.Add(new MDB.MDBParameter("NgayCT7", ketQua.NgayCT7));

                Command.Parameters.Add(new MDB.MDBParameter("NgayDG1_Gio", ketQua.NgayDG1_Gio));
                Command.Parameters.Add(new MDB.MDBParameter("NgayDG2_Gio", ketQua.NgayDG2_Gio));
                Command.Parameters.Add(new MDB.MDBParameter("NgayDG3_Gio", ketQua.NgayDG3_Gio));
                Command.Parameters.Add(new MDB.MDBParameter("NgayDG4_Gio", ketQua.NgayDG4_Gio));
                Command.Parameters.Add(new MDB.MDBParameter("NgayDG5_Gio", ketQua.NgayDG5_Gio));
                Command.Parameters.Add(new MDB.MDBParameter("NgayDG6_Gio", ketQua.NgayDG6_Gio));
                Command.Parameters.Add(new MDB.MDBParameter("NgayDG7_Gio", ketQua.NgayDG7_Gio));

                Command.Parameters.Add(new MDB.MDBParameter("NgayCT1_Gio", ketQua.NgayCT1_Gio));
                Command.Parameters.Add(new MDB.MDBParameter("NgayCT2_Gio", ketQua.NgayCT2_Gio));
                Command.Parameters.Add(new MDB.MDBParameter("NgayCT3_Gio", ketQua.NgayCT3_Gio));
                Command.Parameters.Add(new MDB.MDBParameter("NgayCT4_Gio", ketQua.NgayCT4_Gio));
                Command.Parameters.Add(new MDB.MDBParameter("NgayCT5_Gio", ketQua.NgayCT5_Gio));
                Command.Parameters.Add(new MDB.MDBParameter("NgayCT6_Gio", ketQua.NgayCT6_Gio));
                Command.Parameters.Add(new MDB.MDBParameter("NgayCT7_Gio", ketQua.NgayCT7_Gio));

                Command.Parameters.Add(new MDB.MDBParameter("ND1", ketQua.ND1));
                Command.Parameters.Add(new MDB.MDBParameter("ND2", ketQua.ND2));
                Command.Parameters.Add(new MDB.MDBParameter("ND3", ketQua.ND3));
                Command.Parameters.Add(new MDB.MDBParameter("ND4", ketQua.ND4));
                Command.Parameters.Add(new MDB.MDBParameter("ND5", ketQua.ND5));
                Command.Parameters.Add(new MDB.MDBParameter("ND6", ketQua.ND6));
                Command.Parameters.Add(new MDB.MDBParameter("ND7", ketQua.ND7));
                Command.Parameters.Add(new MDB.MDBParameter("ND8", ketQua.ND8));
                Command.Parameters.Add(new MDB.MDBParameter("ND9", ketQua.ND9));
                Command.Parameters.Add(new MDB.MDBParameter("ND10", ketQua.ND10));
                Command.Parameters.Add(new MDB.MDBParameter("ND11", ketQua.ND11));
                Command.Parameters.Add(new MDB.MDBParameter("ND12", ketQua.ND12));
                Command.Parameters.Add(new MDB.MDBParameter("ND13", ketQua.ND13));
                Command.Parameters.Add(new MDB.MDBParameter("ND14", ketQua.ND14));
                Command.Parameters.Add(new MDB.MDBParameter("ND15", ketQua.ND15));
                Command.Parameters.Add(new MDB.MDBParameter("ND16", ketQua.ND16));
                Command.Parameters.Add(new MDB.MDBParameter("ND17", ketQua.ND17));
                Command.Parameters.Add(new MDB.MDBParameter("ND18", ketQua.ND18));
                Command.Parameters.Add(new MDB.MDBParameter("ND19", ketQua.ND19));
                Command.Parameters.Add(new MDB.MDBParameter("ND20", ketQua.ND20));
                Command.Parameters.Add(new MDB.MDBParameter("ND21", ketQua.ND21));
                Command.Parameters.Add(new MDB.MDBParameter("ND22", ketQua.ND22));
                Command.Parameters.Add(new MDB.MDBParameter("ND23", ketQua.ND23));
                Command.Parameters.Add(new MDB.MDBParameter("NC1", ketQua.NC1));
                Command.Parameters.Add(new MDB.MDBParameter("NC2", ketQua.NC2));
                Command.Parameters.Add(new MDB.MDBParameter("NC3", ketQua.NC3));
                Command.Parameters.Add(new MDB.MDBParameter("NC4", ketQua.NC4));
                Command.Parameters.Add(new MDB.MDBParameter("NC5", ketQua.NC5));
                Command.Parameters.Add(new MDB.MDBParameter("NC6", ketQua.NC6));
                Command.Parameters.Add(new MDB.MDBParameter("NC7", ketQua.NC7));
                Command.Parameters.Add(new MDB.MDBParameter("NC8", ketQua.NC8));
                Command.Parameters.Add(new MDB.MDBParameter("NC9", ketQua.NC9));
                Command.Parameters.Add(new MDB.MDBParameter("NC10", ketQua.NC10));
                Command.Parameters.Add(new MDB.MDBParameter("NC11", ketQua.NC11));
                Command.Parameters.Add(new MDB.MDBParameter("NC12", ketQua.NC12));
                Command.Parameters.Add(new MDB.MDBParameter("TongDiem1", ketQua.TongDiem1));
                Command.Parameters.Add(new MDB.MDBParameter("TongDiem2", ketQua.TongDiem2));
                Command.Parameters.Add(new MDB.MDBParameter("TongDiem3", ketQua.TongDiem3));
                Command.Parameters.Add(new MDB.MDBParameter("TongDiem4", ketQua.TongDiem4));
                Command.Parameters.Add(new MDB.MDBParameter("TongDiem5", ketQua.TongDiem5));
                Command.Parameters.Add(new MDB.MDBParameter("TongDiem6", ketQua.TongDiem6));
                Command.Parameters.Add(new MDB.MDBParameter("TongDiem7", ketQua.TongDiem7));
                Command.Parameters.Add(new MDB.MDBParameter("MaNguoiDanhGia1", ketQua.MaNguoiDanhGia1));
                Command.Parameters.Add(new MDB.MDBParameter("NguoiDanhGia1", ketQua.NguoiDanhGia1));
                Command.Parameters.Add(new MDB.MDBParameter("MaNguoiCanThiep1", ketQua.MaNguoiCanThiep1));
                Command.Parameters.Add(new MDB.MDBParameter("NguoiCanThiep1", ketQua.NguoiCanThiep1));
                Command.Parameters.Add(new MDB.MDBParameter("MaNguoiDanhGia2", ketQua.MaNguoiDanhGia2));
                Command.Parameters.Add(new MDB.MDBParameter("NguoiDanhGia2", ketQua.NguoiDanhGia2));
                Command.Parameters.Add(new MDB.MDBParameter("MaNguoiCanThiep2", ketQua.MaNguoiCanThiep2));
                Command.Parameters.Add(new MDB.MDBParameter("NguoiCanThiep2", ketQua.NguoiCanThiep2));
                Command.Parameters.Add(new MDB.MDBParameter("MaNguoiDanhGia3", ketQua.MaNguoiDanhGia3));
                Command.Parameters.Add(new MDB.MDBParameter("NguoiDanhGia3", ketQua.NguoiDanhGia3));
                Command.Parameters.Add(new MDB.MDBParameter("MaNguoiCanThiep3", ketQua.MaNguoiCanThiep3));
                Command.Parameters.Add(new MDB.MDBParameter("NguoiCanThiep3", ketQua.NguoiCanThiep3));
                Command.Parameters.Add(new MDB.MDBParameter("MaNguoiDanhGia4", ketQua.MaNguoiDanhGia4));
                Command.Parameters.Add(new MDB.MDBParameter("NguoiDanhGia4", ketQua.NguoiDanhGia4));
                Command.Parameters.Add(new MDB.MDBParameter("MaNguoiCanThiep4", ketQua.MaNguoiCanThiep4));
                Command.Parameters.Add(new MDB.MDBParameter("NguoiCanThiep4", ketQua.NguoiCanThiep4));
                Command.Parameters.Add(new MDB.MDBParameter("MaNguoiDanhGia5", ketQua.MaNguoiDanhGia5));
                Command.Parameters.Add(new MDB.MDBParameter("NguoiDanhGia5", ketQua.NguoiDanhGia5));
                Command.Parameters.Add(new MDB.MDBParameter("MaNguoiCanThiep5", ketQua.MaNguoiCanThiep5));
                Command.Parameters.Add(new MDB.MDBParameter("NguoiCanThiep5", ketQua.NguoiCanThiep5));
                Command.Parameters.Add(new MDB.MDBParameter("MaNguoiDanhGia6", ketQua.MaNguoiDanhGia6));
                Command.Parameters.Add(new MDB.MDBParameter("NguoiDanhGia6", ketQua.NguoiDanhGia6));
                Command.Parameters.Add(new MDB.MDBParameter("MaNguoiCanThiep6", ketQua.MaNguoiCanThiep6));
                Command.Parameters.Add(new MDB.MDBParameter("NguoiCanThiep6", ketQua.NguoiCanThiep6));
                Command.Parameters.Add(new MDB.MDBParameter("MaNguoiDanhGia7", ketQua.MaNguoiDanhGia7));
                Command.Parameters.Add(new MDB.MDBParameter("NguoiDanhGia7", ketQua.NguoiDanhGia7));
                Command.Parameters.Add(new MDB.MDBParameter("MaNguoiCanThiep7", ketQua.MaNguoiCanThiep7));
                Command.Parameters.Add(new MDB.MDBParameter("NguoiCanThiep7", ketQua.NguoiCanThiep7));

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
                string sql = "DELETE FROM BangDGNguyCoTeNgaVaHCT WHERE ID = :ID";
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
                BangDGNguyCoTeNgaVaHCT P
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
            ds.Tables[0].AddColumn("KHOA", typeof(string));
            ds.Tables[0].AddColumn("MABN", typeof(string));

            ds.Tables[0].Rows[0]["TenBenhNhan"] = XemBenhAn._HanhChinhBenhNhan.TenBenhNhan;
            ds.Tables[0].Rows[0]["Tuoi"] = XemBenhAn._HanhChinhBenhNhan.Tuoi;
            ds.Tables[0].Rows[0]["NamSinh"] = XemBenhAn._HanhChinhBenhNhan.NgaySinh.HasValue ? XemBenhAn._HanhChinhBenhNhan.NgaySinh.Value.Year + "" : "";
            ds.Tables[0].Rows[0]["GioiTinh"] = (int)XemBenhAn._HanhChinhBenhNhan.GioiTinh;
            ds.Tables[0].Rows[0]["SOYTE"] = XemBenhAn._HanhChinhBenhNhan.SoYTe;
            ds.Tables[0].Rows[0]["BENHVIEN"] = XemBenhAn._HanhChinhBenhNhan.BenhVien;
            ds.Tables[0].Rows[0]["KHOA"] = XemBenhAn._ThongTinDieuTri.Khoa;
            ds.Tables[0].Rows[0]["MABN"] = XemBenhAn._HanhChinhBenhNhan.MaBenhNhan;
            return ds;
        }
    }
}
