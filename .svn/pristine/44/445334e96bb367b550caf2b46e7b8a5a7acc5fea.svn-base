using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EMR.KyDienTu;
using PMS.Access;

namespace EMR_MAIN.DATABASE.Other
{
    public class KHCSNguoiBenhCovid19_2 : ThongTinKy
    {
        [MoTaDuLieu("Mã định danh")]
        public long ID { get; set; }
        [MoTaDuLieu("Mã quản lý: mã duy nhất trong 1 đợt khám chữa bệnh (kcb), không trùng giữa các đợt kcb khác nhau", "", 1)]
        public decimal MaQuanLy { get; set; }
        [MoTaDuLieu("Mã bệnh nhân")]
        public string MaBenhNhan { set; get; }
        [MoTaDuLieu("Họ và tên bệnh nhân")]
        public string TenBenhNhan { set; get; }
        [MoTaDuLieu("Tuổi bệnh nhân")]
        public string Tuoi { set; get; }
        [MoTaDuLieu("Giới tính bệnh nhân")]
        public string GioiTinh { get; set; }
        [MoTaDuLieu("Ngày nhập viện")]
        public DateTime? NgayNhapVien { get; set; }
        [MoTaDuLieu("Chẩn đoán")]
        public string ChanDoan { get; set; }
        [MoTaDuLieu("Ngày tháng trang 1")]
        public DateTime? NgayThang1 { get; set; }
        [MoTaDuLieu("Giờ thực hiện 1")]
        public DateTime? GioThucHien1 { get; set; }
        [MoTaDuLieu("Giờ thực hiện 2")]
        public DateTime? GioThucHien2 { get; set; }
        [MoTaDuLieu("Giờ thực hiện 3")]
        public DateTime? GioThucHien3 { get; set; }
        [MoTaDuLieu("Giờ thực hiện 4")]
        public DateTime? GioThucHien4 { get; set; }
        [MoTaDuLieu("Giờ thực hiện 5")]
        public DateTime? GioThucHien5 { get; set; }
        [MoTaDuLieu("Giờ thực hiện 6")]
        public DateTime? GioThucHien6 { get; set; }
        [MoTaDuLieu("Giờ thực hiện 7")]
        public DateTime? GioThucHien7 { get; set; }
        // khai báo các vấn đề sức khỏe
        // 1. Tri giác
        public bool[] TriGiac11_Array { get; } = new bool[] { false, false, false, false, false, false, false };
        [MoTaDuLieu("1. Tri giác: 1.1 Tỉnh, tiếp xúc tốt")]
        public string TriGiac11
        {
            get
            {
                string temp = "";
                for (int i = 0; i < TriGiac11_Array.Length; i++)
                    temp += (TriGiac11_Array[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        TriGiac11_Array[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public bool[] TriGiac12_Array { get; } = new bool[] { false, false, false, false, false, false, false };
        [MoTaDuLieu("1. Tri giác: 1.1 Mệt đừ")]
        public string TriGiac12
        {
            get
            {
                string temp = "";
                for (int i = 0; i < TriGiac12_Array.Length; i++)
                    temp += (TriGiac12_Array[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        TriGiac12_Array[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public bool[] TriGiac13_Array { get; } = new bool[] { false, false, false, false, false, false, false };
        [MoTaDuLieu("1. Tri giác: 1.3	Li bì, lơ mơ")]
        public string TriGiac13
        {
            get
            {
                string temp = "";
                for (int i = 0; i < TriGiac13_Array.Length; i++)
                    temp += (TriGiac13_Array[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        TriGiac13_Array[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public bool[] TriGiac14_Array { get; } = new bool[] { false, false, false, false, false, false, false };
        [MoTaDuLieu("1. Tri giác: 1.4	Hôn mê")]
        public string TriGiac14
        {
            get
            {
                string temp = "";
                for (int i = 0; i < TriGiac14_Array.Length; i++)
                    temp += (TriGiac14_Array[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        TriGiac14_Array[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public bool[] DaNiem21_Array { get; } = new bool[] { false, false, false, false, false, false, false };
        [MoTaDuLieu("2. Da niêm: 2.1	Da niêm hồng")]
        public string DaNiem21
        {
            get
            {
                string temp = "";
                for (int i = 0; i < DaNiem21_Array.Length; i++)
                    temp += (DaNiem21_Array[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        DaNiem21_Array[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public bool[] DaNiem22_Array { get; } = new bool[] { false, false, false, false, false, false, false };
        [MoTaDuLieu("2. Da niêm: 2.1	Da niêm hồng")]
        public string DaNiem22
        {
            get
            {
                string temp = "";
                for (int i = 0; i < DaNiem22_Array.Length; i++)
                    temp += (DaNiem22_Array[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        DaNiem22_Array[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public bool[] DaNiem23_Array { get; } = new bool[] { false, false, false, false, false, false, false };
        [MoTaDuLieu("2. Da niêm: 2.1	Da niêm hồng")]
        public string DaNiem23
        {
            get
            {
                string temp = "";
                for (int i = 0; i < DaNiem23_Array.Length; i++)
                    temp += (DaNiem23_Array[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        DaNiem23_Array[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        [MoTaDuLieu("3. Dấu hiệu sinh tồn: 3.1	Mạch (lần/phút), ngày 1")]
        public string Mach_1 { get; set; }
        [MoTaDuLieu("3. Dấu hiệu sinh tồn: 3.1	Mạch (lần/phút), ngày 2")]
        public string Mach_2 { get; set; }
        [MoTaDuLieu("3. Dấu hiệu sinh tồn: 3.1	Mạch (lần/phút), ngày 3")]
        public string Mach_3 { get; set; }
        [MoTaDuLieu("3. Dấu hiệu sinh tồn: 3.1	Mạch (lần/phút), ngày 4")]
        public string Mach_4 { get; set; }
        [MoTaDuLieu("3. Dấu hiệu sinh tồn: 3.1	Mạch (lần/phút), ngày 5")]
        public string Mach_5 { get; set; }
        [MoTaDuLieu("3. Dấu hiệu sinh tồn: 3.1	Mạch (lần/phút), ngày 6")]
        public string Mach_6 { get; set; }
        [MoTaDuLieu("3. Dấu hiệu sinh tồn: 3.1	Mạch (lần/phút), ngày 7")]
        public string Mach_7 { get; set; }
        [MoTaDuLieu("3. Dấu hiệu sinh tồn: 3.2	Nhiệt độ(độ C), ngày 1")]
        public string NhietDo_1 { get; set; }
        [MoTaDuLieu("3. Dấu hiệu sinh tồn: 3.2	Nhiệt độ(độ C), ngày 2")]
        public string NhietDo_2 { get; set; }
        [MoTaDuLieu("3. Dấu hiệu sinh tồn: 3.2	Nhiệt độ(độ C), ngày 3")]
        public string NhietDo_3 { get; set; }
        [MoTaDuLieu("3. Dấu hiệu sinh tồn: 3.2	Nhiệt độ(độ C), ngày 4")]
        public string NhietDo_4 { get; set; }
        [MoTaDuLieu("3. Dấu hiệu sinh tồn: 3.2	Nhiệt độ(độ C), ngày 5")]
        public string NhietDo_5 { get; set; }
        [MoTaDuLieu("3. Dấu hiệu sinh tồn: 3.2	Nhiệt độ(độ C), ngày 6")]
        public string NhietDo_6 { get; set; }
        [MoTaDuLieu("3. Dấu hiệu sinh tồn: 3.2	Nhiệt độ(độ C), ngày 7")]
        public string NhietDo_7 { get; set; }
        [MoTaDuLieu("3. Dấu hiệu sinh tồn: 3.3	Huyết áp(mmHg), ngày 1")]
        public string HuyetAp_1 { get; set; }
        [MoTaDuLieu("3. Dấu hiệu sinh tồn: 3.3	Huyết áp(mmHg), ngày 2")]
        public string HuyetAp_2 { get; set; }
        [MoTaDuLieu("3. Dấu hiệu sinh tồn: 3.3	Huyết áp(mmHg), ngày 3")]
        public string HuyetAp_3 { get; set; }
        [MoTaDuLieu("3. Dấu hiệu sinh tồn: 3.3	Huyết áp(mmHg), ngày 4")]
        public string HuyetAp_4 { get; set; }
        [MoTaDuLieu("3. Dấu hiệu sinh tồn: 3.3	Huyết áp(mmHg), ngày 5")]
        public string HuyetAp_5 { get; set; }
        [MoTaDuLieu("3. Dấu hiệu sinh tồn: 3.3	Huyết áp(mmHg), ngày 6")]
        public string HuyetAp_6 { get; set; }
        [MoTaDuLieu("3. Dấu hiệu sinh tồn: 3.3	Huyết áp(mmHg), ngày 7")]
        public string HuyetAp_7 { get; set; }
        [MoTaDuLieu("3. Dấu hiệu sinh tồn: 3.4	Nhịp thở(lần/phút), ngày 1")]
        public string NhipTho_1 { get; set; }
        [MoTaDuLieu("3. Dấu hiệu sinh tồn: 3.4	Nhịp thở(lần/phút), ngày 2")]
        public string NhipTho_2 { get; set; }
        [MoTaDuLieu("3. Dấu hiệu sinh tồn: 3.4	Nhịp thở(lần/phút), ngày 3")]
        public string NhipTho_3 { get; set; }
        [MoTaDuLieu("3. Dấu hiệu sinh tồn: 3.4	Nhịp thở(lần/phút), ngày 4")]
        public string NhipTho_4 { get; set; }
        [MoTaDuLieu("3. Dấu hiệu sinh tồn: 3.4	Nhịp thở(lần/phút), ngày 5")]
        public string NhipTho_5 { get; set; }
        [MoTaDuLieu("3. Dấu hiệu sinh tồn: 3.4	Nhịp thở(lần/phút), ngày 6")]
        public string NhipTho_6 { get; set; }
        [MoTaDuLieu("3. Dấu hiệu sinh tồn: 3.4	Nhịp thở(lần/phút), ngày 7")]
        public string NhipTho_7 { get; set; }
        [MoTaDuLieu("4. Tính chất hô hấp: 4.1	SpO2), ngày 1")]
        public string SpO2_1 { get; set; }
        [MoTaDuLieu("4. Tính chất hô hấp: 4.1	SpO2), ngày 2")]
        public string SpO2_2 { get; set; }
        [MoTaDuLieu("4. Tính chất hô hấp: 4.1	SpO2), ngày 3")]
        public string SpO2_3 { get; set; }
        [MoTaDuLieu("4. Tính chất hô hấp: 4.1	SpO2), ngày 4")]
        public string SpO2_4 { get; set; }
        [MoTaDuLieu("4. Tính chất hô hấp: 4.1	SpO2), ngày 5")]
        public string SpO2_5 { get; set; }
        [MoTaDuLieu("4. Tính chất hô hấp: 4.1	SpO2), ngày 6")]
        public string SpO2_6 { get; set; }
        [MoTaDuLieu("4. Tính chất hô hấp: 4.1	SpO2), ngày 7")]
        public string SpO2_7 { get; set; }
        public bool[] TinhChatHoHap42_Array { get; } = new bool[] { false, false, false, false, false, false, false };
        [MoTaDuLieu("4. Tính chất hô hấp: 4.2	Thở nhanh, co kéo")]
        public string TinhChatHoHap42
        {
            get
            {
                string temp = "";
                for (int i = 0; i < TinhChatHoHap42_Array.Length; i++)
                    temp += (TinhChatHoHap42_Array[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        TinhChatHoHap42_Array[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public bool[] TinhChatHoHap43_Array { get; } = new bool[] { false, false, false, false, false, false, false };
        [MoTaDuLieu("4. Tính chất hô hấp: 4.3	Khó thở")]
        public string TinhChatHoHap43
        {
            get
            {
                string temp = "";
                for (int i = 0; i < TinhChatHoHap43_Array.Length; i++)
                    temp += (TinhChatHoHap43_Array[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        TinhChatHoHap43_Array[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public bool[] TinhChatKhac51_Array { get; } = new bool[] { false, false, false, false, false, false, false };
        [MoTaDuLieu("5. Tính chất khác: 5.1	Ho có đàm")]
        public string TinhChatKhac51
        {
            get
            {
                string temp = "";
                for (int i = 0; i < TinhChatKhac51_Array.Length; i++)
                    temp += (TinhChatKhac51_Array[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        TinhChatKhac51_Array[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public bool[] TinhChatKhac52_Array { get; } = new bool[] { false, false, false, false, false, false, false };
        [MoTaDuLieu("5. Tính chất khác: 5.2	Ho khan")]
        public string TinhChatKhac52
        {
            get
            {
                string temp = "";
                for (int i = 0; i < TinhChatKhac52_Array.Length; i++)
                    temp += (TinhChatKhac52_Array[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        TinhChatKhac52_Array[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public bool[] TinhChatKhac53_Array { get; } = new bool[] { false, false, false, false, false, false, false };
        [MoTaDuLieu("5. Tính chất khác: 5.3	Mệt mỏi")]
        public string TinhChatKhac53
        {
            get
            {
                string temp = "";
                for (int i = 0; i < TinhChatKhac53_Array.Length; i++)
                    temp += (TinhChatKhac53_Array[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        TinhChatKhac53_Array[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public bool[] TinhChatKhac54_Array { get; } = new bool[] { false, false, false, false, false, false, false };
        [MoTaDuLieu("5. Tính chất khác: 5.4	Đau cơ")]
        public string TinhChatKhac54
        {
            get
            {
                string temp = "";
                for (int i = 0; i < TinhChatKhac54_Array.Length; i++)
                    temp += (TinhChatKhac54_Array[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        TinhChatKhac54_Array[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public bool[] TinhChatKhac55_Array { get; } = new bool[] { false, false, false, false, false, false, false };
        [MoTaDuLieu("5. Tính chất khác: 5.5	Mất vị giác")]
        public string TinhChatKhac55
        {
            get
            {
                string temp = "";
                for (int i = 0; i < TinhChatKhac55_Array.Length; i++)
                    temp += (TinhChatKhac55_Array[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        TinhChatKhac55_Array[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public bool[] TinhChatKhac56_Array { get; } = new bool[] { false, false, false, false, false, false, false };
        [MoTaDuLieu("5. Tính chất khác: 5.6	Mất mùi")]
        public string TinhChatKhac56
        {
            get
            {
                string temp = "";
                for (int i = 0; i < TinhChatKhac56_Array.Length; i++)
                    temp += (TinhChatKhac56_Array[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        TinhChatKhac56_Array[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public bool[] TinhChatKhac57_Array { get; } = new bool[] { false, false, false, false, false, false, false };
        [MoTaDuLieu("5. Tính chất khác: 5.7	Đau họng")]
        public string TinhChatKhac57
        {
            get
            {
                string temp = "";
                for (int i = 0; i < TinhChatKhac57_Array.Length; i++)
                    temp += (TinhChatKhac57_Array[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        TinhChatKhac57_Array[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public bool[] TinhChatKhac58_Array { get; } = new bool[] { false, false, false, false, false, false, false };
        [MoTaDuLieu("5. Tính chất khác: 5.8	Đau đầu")]
        public string TinhChatKhac58
        {
            get
            {
                string temp = "";
                for (int i = 0; i < TinhChatKhac58_Array.Length; i++)
                    temp += (TinhChatKhac58_Array[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        TinhChatKhac58_Array[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public bool[] TinhChatKhac59_Array { get; } = new bool[] { false, false, false, false, false, false, false };
        [MoTaDuLieu("5. Tính chất khác: 5.9	Nghẹt mũi")]
        public string TinhChatKhac59
        {
            get
            {
                string temp = "";
                for (int i = 0; i < TinhChatKhac59_Array.Length; i++)
                    temp += (TinhChatKhac59_Array[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        TinhChatKhac59_Array[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public bool[] TinhChatKhac510_Array { get; } = new bool[] { false, false, false, false, false, false, false };
        [MoTaDuLieu("5. Tính chất khác: 5.10	Tiêu chảy")]
        public string TinhChatKhac510
        {
            get
            {
                string temp = "";
                for (int i = 0; i < TinhChatKhac510_Array.Length; i++)
                    temp += (TinhChatKhac510_Array[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        TinhChatKhac510_Array[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public bool[] DinhDuong61_Array { get; } = new bool[] { false, false, false, false, false, false, false };
        [MoTaDuLieu("6. Dinh dưỡng: 6.1	Ăn uống qua miệng")]
        public string DinhDuong61
        {
            get
            {
                string temp = "";
                for (int i = 0; i < DinhDuong61_Array.Length; i++)
                    temp += (DinhDuong61_Array[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        DinhDuong61_Array[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public bool[] DinhDuong62_Array { get; } = new bool[] { false, false, false, false, false, false, false };
        [MoTaDuLieu("6. Dinh dưỡng: 6.2	Nuôi dưỡi qua sonde DD")]
        public string DinhDuong62
        {
            get
            {
                string temp = "";
                for (int i = 0; i < DinhDuong62_Array.Length; i++)
                    temp += (DinhDuong62_Array[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        DinhDuong62_Array[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        [MoTaDuLieu("7. Tình trạng bất thường khác, ngày 1")]
        public string TinhTrangBatThuong_1 { get; set; }
        [MoTaDuLieu("7. Tình trạng bất thường khác, ngày 2")]
        public string TinhTrangBatThuong_2 { get; set; }
        [MoTaDuLieu("7. Tình trạng bất thường khác, ngày 3")]
        public string TinhTrangBatThuong_3 { get; set; }
        [MoTaDuLieu("7. Tình trạng bất thường khác, ngày 4")]
        public string TinhTrangBatThuong_4 { get; set; }
        [MoTaDuLieu("7. Tình trạng bất thường khác, ngày 5")]
        public string TinhTrangBatThuong_5 { get; set; }
        [MoTaDuLieu("7. Tình trạng bất thường khác, ngày 6")]
        public string TinhTrangBatThuong_6 { get; set; }
        [MoTaDuLieu("7. Tình trạng bất thường khác, ngày 7")]
        public string TinhTrangBatThuong_7 { get; set; }
        [MoTaDuLieu("ĐD chăm sóc ghi tên, ngày 1")]
        public string DieuDuong1_1 { get; set; }
        [MoTaDuLieu("ĐD chăm sóc ghi tên, ngày 2")]
        public string DieuDuong1_2 { get; set; }
        [MoTaDuLieu("ĐD chăm sóc ghi tên, ngày 3")]
        public string DieuDuong1_3 { get; set; }
        [MoTaDuLieu("ĐD chăm sóc ghi tên, ngày 4")]
        public string DieuDuong1_4 { get; set; }
        [MoTaDuLieu("ĐD chăm sóc ghi tên, ngày 5")]
        public string DieuDuong1_5 { get; set; }
        [MoTaDuLieu("ĐD chăm sóc ghi tên, ngày 6")]
        public string DieuDuong1_6 { get; set; }
        [MoTaDuLieu("ĐD chăm sóc ghi tên, ngày 7")]
        public string DieuDuong1_7 { get; set; }
        [MoTaDuLieu("Ngày tháng trang 2")]
        public DateTime? NgayThang2 { get; set; }
        [MoTaDuLieu("Giờ thực hiện trang 1")]
        public DateTime? GioThucHien11 { get; set; }
        [MoTaDuLieu("Giờ thực hiện trang 2")]
        public DateTime? GioThucHien12 { get; set; }
        [MoTaDuLieu("Giờ thực hiện trang 3")]
        public DateTime? GioThucHien13 { get; set; }
        [MoTaDuLieu("Giờ thực hiện trang 4")]
        public DateTime? GioThucHien14 { get; set; }
        [MoTaDuLieu("Giờ thực hiện trang 5")]
        public DateTime? GioThucHien15 { get; set; }
        [MoTaDuLieu("Giờ thực hiện trang 6")]
        public DateTime? GioThucHien16 { get; set; }
        [MoTaDuLieu("Giờ thực hiện trang 7")]
        public DateTime? GioThucHien17 { get; set; }
        [MoTaDuLieu("8. Cấp cứu, 1.1	Đánh giá điểm glassgow ngày 1")]
        public string CapCuu81_1 { get; set; }
        [MoTaDuLieu("8. Cấp cứu, 1.1	Đánh giá điểm glassgow ngày 2")]
        public string CapCuu81_2 { get; set; }
        [MoTaDuLieu("8. Cấp cứu, 1.1	Đánh giá điểm glassgow ngày 3")]
        public string CapCuu81_3 { get; set; }
        [MoTaDuLieu("8. Cấp cứu, 1.1	Đánh giá điểm glassgow ngày 4")]
        public string CapCuu81_4 { get; set; }
        [MoTaDuLieu("8. Cấp cứu, 1.1	Đánh giá điểm glassgow ngày 5")]
        public string CapCuu81_5 { get; set; }
        [MoTaDuLieu("8. Cấp cứu, 1.1	Đánh giá điểm glassgow ngày 6")]
        public string CapCuu81_6 { get; set; }
        [MoTaDuLieu("8. Cấp cứu, 1.1	Đánh giá điểm glassgow ngày 7")]
        public string CapCuu81_7 { get; set; }
        [MoTaDuLieu("8. Cấp cứu, 1.2 Thở oxy gọng mũi (lít/phút) ngày 1")]
        public string CapCuu821_1 { get; set; }
        [MoTaDuLieu("8. Cấp cứu, 1.2 Thở oxy gọng mũi (lít/phút) ngày 2")]
        public string CapCuu821_2 { get; set; }
        [MoTaDuLieu("8. Cấp cứu, 1.2 Thở oxy gọng mũi (lít/phút) ngày 3")]
        public string CapCuu821_3 { get; set; }
        [MoTaDuLieu("8. Cấp cứu, 1.2 Thở oxy gọng mũi (lít/phút) ngày 4")]
        public string CapCuu821_4 { get; set; }
        [MoTaDuLieu("8. Cấp cứu, 1.2 Thở oxy gọng mũi (lít/phút) ngày 5")]
        public string CapCuu821_5 { get; set; }
        [MoTaDuLieu("8. Cấp cứu, 1.2 Thở oxy gọng mũi (lít/phút) ngày 6")]
        public string CapCuu821_6 { get; set; }
        [MoTaDuLieu("8. Cấp cứu, 1.2 Thở oxy gọng mũi (lít/phút) ngày 7")]
        public string CapCuu821_7 { get; set; }
        [MoTaDuLieu("8. Cấp cứu, 1.2 Thở oxy qua mask /venturi ngày 1")]
        public string CapCuu822_1 { get; set; }
        [MoTaDuLieu("8. Cấp cứu, 1.2 Thở oxy qua mask /venturi ngày 2")]
        public string CapCuu822_2 { get; set; }
        [MoTaDuLieu("8. Cấp cứu, 1.2 Thở oxy qua mask /venturi ngày 3")]
        public string CapCuu822_3 { get; set; }
        [MoTaDuLieu("8. Cấp cứu, 1.2 Thở oxy qua mask /venturi ngày 4")]
        public string CapCuu822_4 { get; set; }
        [MoTaDuLieu("8. Cấp cứu, 1.2 Thở oxy qua mask /venturi ngày 5")]
        public string CapCuu822_5 { get; set; }
        [MoTaDuLieu("8. Cấp cứu, 1.2 Thở oxy qua mask /venturi ngày 6")]
        public string CapCuu822_6 { get; set; }
        [MoTaDuLieu("8. Cấp cứu, 1.2 Thở oxy qua mask /venturi ngày 7")]
        public string CapCuu822_7 { get; set; }
        [MoTaDuLieu("8. Cấp cứu, 1.2 Thở HFNC ngày 1")]
        public string CapCuu823_1 { get; set; }
        [MoTaDuLieu("8. Cấp cứu, 1.2 Thở HFNC ngày 2")]
        public string CapCuu823_2 { get; set; }
        [MoTaDuLieu("8. Cấp cứu, 1.2 Thở HFNC ngày 3")]
        public string CapCuu823_3 { get; set; }
        [MoTaDuLieu("8. Cấp cứu, 1.2 Thở HFNC ngày 4")]
        public string CapCuu823_4 { get; set; }
        [MoTaDuLieu("8. Cấp cứu, 1.2 Thở HFNC ngày 5")]
        public string CapCuu823_5 { get; set; }
        [MoTaDuLieu("8. Cấp cứu, 1.2 Thở HFNC ngày 6")]
        public string CapCuu823_6 { get; set; }
        [MoTaDuLieu("8. Cấp cứu, 1.2 Thở HFNC ngày 7")]
        public string CapCuu823_7 { get; set; }
        [MoTaDuLieu("8. Cấp cứu, 1.2 TM không xâm lấn ngày 1")]
        public string CapCuu824_1 { get; set; }
        [MoTaDuLieu("8. Cấp cứu, 1.2 TM không xâm lấn ngày 2")]
        public string CapCuu824_2 { get; set; }
        [MoTaDuLieu("8. Cấp cứu, 1.2 TM không xâm lấn ngày 3")]
        public string CapCuu824_3 { get; set; }
        [MoTaDuLieu("8. Cấp cứu, 1.2 TM không xâm lấn ngày 4")]
        public string CapCuu824_4 { get; set; }
        [MoTaDuLieu("8. Cấp cứu, 1.2 TM không xâm lấn ngày 5")]
        public string CapCuu824_5 { get; set; }
        [MoTaDuLieu("8. Cấp cứu, 1.2 TM không xâm lấn ngày 6")]
        public string CapCuu824_6 { get; set; }
        [MoTaDuLieu("8. Cấp cứu, 1.2 TM không xâm lấn ngày 7")]
        public string CapCuu824_7 { get; set; }
        [MoTaDuLieu("8. Cấp cứu, 1.2 TM xâm lấn ngày 1")]
        public string CapCuu825_1 { get; set; }
        [MoTaDuLieu("8. Cấp cứu, 1.2 TM xâm lấn ngày 2")]
        public string CapCuu825_2 { get; set; }
        [MoTaDuLieu("8. Cấp cứu, 1.2 TM xâm lấn ngày 3")]
        public string CapCuu825_3 { get; set; }
        [MoTaDuLieu("8. Cấp cứu, 1.2 TM xâm lấn ngày 4")]
        public string CapCuu825_4 { get; set; }
        [MoTaDuLieu("8. Cấp cứu, 1.2 TM xâm lấn ngày 5")]
        public string CapCuu825_5 { get; set; }
        [MoTaDuLieu("8. Cấp cứu, 1.2 TM xâm lấn ngày 6")]
        public string CapCuu825_6 { get; set; }
        [MoTaDuLieu("8. Cấp cứu, 1.2 TM xâm lấn ngày 7")]
        public string CapCuu825_7 { get; set; }
        [MoTaDuLieu("8. Cấp cứu, 1.3	Lâu ấm hạ sốt ngày 1")]
        public string CapCuu83_1 { get; set; }
        [MoTaDuLieu("8. Cấp cứu, 1.3	Lâu ấm hạ sốt ngày 2")]
        public string CapCuu83_2 { get; set; }
        [MoTaDuLieu("8. Cấp cứu, 1.3	Lâu ấm hạ sốt ngày 3")]
        public string CapCuu83_3 { get; set; }
        [MoTaDuLieu("8. Cấp cứu, 1.3	Lâu ấm hạ sốt ngày 4")]
        public string CapCuu83_4 { get; set; }
        [MoTaDuLieu("8. Cấp cứu, 1.3	Lâu ấm hạ sốt ngày 5")]
        public string CapCuu83_5 { get; set; }
        [MoTaDuLieu("8. Cấp cứu, 1.3	Lâu ấm hạ sốt ngày 6")]
        public string CapCuu83_6 { get; set; }
        [MoTaDuLieu("8. Cấp cứu, 1.3	Lâu ấm hạ sốt ngày 7")]
        public string CapCuu83_7 { get; set; }
        [MoTaDuLieu("8. Cấp cứu, 1.4	Thực hiện y lệnh thuốc ngày 1")]
        public string CapCuu84_1 { get; set; }
        [MoTaDuLieu("8. Cấp cứu, 1.4	Thực hiện y lệnh thuốc ngày 2")]
        public string CapCuu84_2 { get; set; }
        [MoTaDuLieu("8. Cấp cứu, 1.4	Thực hiện y lệnh thuốc ngày 3")]
        public string CapCuu84_3 { get; set; }
        [MoTaDuLieu("8. Cấp cứu, 1.4	Thực hiện y lệnh thuốc ngày 4")]
        public string CapCuu84_4 { get; set; }
        [MoTaDuLieu("8. Cấp cứu, 1.4	Thực hiện y lệnh thuốc ngày 5")]
        public string CapCuu84_5 { get; set; }
        [MoTaDuLieu("8. Cấp cứu, 1.4	Thực hiện y lệnh thuốc ngày 6")]
        public string CapCuu84_6 { get; set; }
        [MoTaDuLieu("8. Cấp cứu, 1.4	Thực hiện y lệnh thuốc ngày 7")]
        public string CapCuu84_7 { get; set; }
        public string XuTriKhac_NoiDung_1 { get; set; }
        public string XuTriKhac_NoiDung_2 { get; set; }
        public string XuTriKhac_NoiDung_3 { get; set; }
        [MoTaDuLieu("8. Cấp cứu,1.5	Xử trí khác h ngày 1")]
        public string CapCuu851_1 { get; set; }
        [MoTaDuLieu("8. Cấp cứu,1.5	Xử trí khác ngày 2")]
        public string CapCuu851_2 { get; set; }
        [MoTaDuLieu("8. Cấp cứu,1.5	Xử trí khác ngày 3")]
        public string CapCuu851_3 { get; set; }
        [MoTaDuLieu("8. Cấp cứu,1.5	Xử trí khác ngày 4")]
        public string CapCuu851_4 { get; set; }
        [MoTaDuLieu("8. Cấp cứu,1.5	Xử trí khác ngày 5")]
        public string CapCuu851_5 { get; set; }
        [MoTaDuLieu("8. Cấp cứu,1.5	Xử trí khác ngày 6")]
        public string CapCuu851_6 { get; set; }
        [MoTaDuLieu("8. Cấp cứu,1.5	Xử trí khác ngày 7")]
        public string CapCuu851_7 { get; set; }
        [MoTaDuLieu("8. Cấp cứu,1.5	Xử trí khác h ngày 1")]
        public string CapCuu852_1 { get; set; }
        [MoTaDuLieu("8. Cấp cứu,1.5	Xử trí khác ngày 2")]
        public string CapCuu852_2 { get; set; }
        [MoTaDuLieu("8. Cấp cứu,1.5	Xử trí khác ngày 3")]
        public string CapCuu852_3 { get; set; }
        [MoTaDuLieu("8. Cấp cứu,1.5	Xử trí khác ngày 4")]
        public string CapCuu852_4 { get; set; }
        [MoTaDuLieu("8. Cấp cứu,1.5	Xử trí khác ngày 5")]
        public string CapCuu852_5 { get; set; }
        [MoTaDuLieu("8. Cấp cứu,1.5	Xử trí khác ngày 6")]
        public string CapCuu852_6 { get; set; }
        [MoTaDuLieu("8. Cấp cứu,1.5	Xử trí khác ngày 7")]
        public string CapCuu852_7 { get; set; }
        [MoTaDuLieu("8. Cấp cứu,1.5	Xử trí khác h ngày 1")]
        public string CapCuu853_1 { get; set; }
        [MoTaDuLieu("8. Cấp cứu,1.5	Xử trí khác ngày 2")]
        public string CapCuu853_2 { get; set; }
        [MoTaDuLieu("8. Cấp cứu,1.5	Xử trí khác ngày 3")]
        public string CapCuu853_3 { get; set; }
        [MoTaDuLieu("8. Cấp cứu,1.5	Xử trí khác ngày 4")]
        public string CapCuu853_4 { get; set; }
        [MoTaDuLieu("8. Cấp cứu,1.5	Xử trí khác ngày 5")]
        public string CapCuu853_5 { get; set; }
        [MoTaDuLieu("8. Cấp cứu,1.5	Xử trí khác ngày 6")]
        public string CapCuu853_6 { get; set; }
        [MoTaDuLieu("8. Cấp cứu,1.5	Xử trí khác ngày 7")]
        public string CapCuu853_7 { get; set; }
        public bool[] ChamSocHoTro91_Array { get; } = new bool[] { false, false, false, false, false, false, false };
        [MoTaDuLieu("9. Chăm sóc hỗ trợ: 2.1	Cho NB nằm sấp")]
        public string ChamSocHoTro91
        {
            get
            {
                string temp = "";
                for (int i = 0; i < ChamSocHoTro91_Array.Length; i++)
                    temp += (ChamSocHoTro91_Array[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        ChamSocHoTro91_Array[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public bool[] ChamSocHoTro92_Array { get; } = new bool[] { false, false, false, false, false, false, false };
        [MoTaDuLieu("9. Chăm sóc hỗ trợ: 2.1	Tập thở, VLTL hô hấp")]
        public string ChamSocHoTro92
        {
            get
            {
                string temp = "";
                for (int i = 0; i < ChamSocHoTro92_Array.Length; i++)
                    temp += (ChamSocHoTro92_Array[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        ChamSocHoTro92_Array[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public bool[] ChamSocHoTro93_Array { get; } = new bool[] { false, false, false, false, false, false, false };
        [MoTaDuLieu("9. Chăm sóc hỗ trợ: 2.3	Hướng dẫn NB uống đủ nước")]
        public string ChamSocHoTro93
        {
            get
            {
                string temp = "";
                for (int i = 0; i < ChamSocHoTro93_Array.Length; i++)
                    temp += (ChamSocHoTro93_Array[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        ChamSocHoTro93_Array[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public bool[] ChamSocHoTro94_Array { get; } = new bool[] { false, false, false, false, false, false, false };
        [MoTaDuLieu("9. Chăm sóc hỗ trợ: 2,4	Hướng dẫn NB theo dõi dấu hiệu chuyển nặng (tri giác, thở mệt, sốt, nôn ói, …)")]
        public string ChamSocHoTro94
        {
            get
            {
                string temp = "";
                for (int i = 0; i < ChamSocHoTro94_Array.Length; i++)
                    temp += (ChamSocHoTro94_Array[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        ChamSocHoTro94_Array[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public bool[] ChamSocHoTro95_Array { get; } = new bool[] { false, false, false, false, false, false, false };
        [MoTaDuLieu("9. Chăm sóc hỗ trợ: 2.5	Cơm bệnh lý, cử/ngày")]
        public string ChamSocHoTro95
        {
            get
            {
                string temp = "";
                for (int i = 0; i < ChamSocHoTro95_Array.Length; i++)
                    temp += (ChamSocHoTro95_Array[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        ChamSocHoTro95_Array[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public bool[] ChamSocHoTro96_Array { get; } = new bool[] { false, false, false, false, false, false, false };
        [MoTaDuLieu("9. Chăm sóc hỗ trợ: 2.6	Cung cấp nhu yếu phẩm")]
        public string ChamSocHoTro96
        {
            get
            {
                string temp = "";
                for (int i = 0; i < ChamSocHoTro96_Array.Length; i++)
                    temp += (ChamSocHoTro96_Array[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        ChamSocHoTro96_Array[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public string HoTroKhac { get; set; }
        [MoTaDuLieu("9. Chăm sóc hỗ trợ,2.7	Hỗ trợ khác ngày 1")]
        public string ChamSocHoTro97_1 { get; set; }
        [MoTaDuLieu("9. Chăm sóc hỗ trợ,2.7	Hỗ trợ khác ngày 2")]
        public string ChamSocHoTro97_2 { get; set; }
        [MoTaDuLieu("9. Chăm sóc hỗ trợ,2.7	Hỗ trợ khác ngày 3")]
        public string ChamSocHoTro97_3 { get; set; }
        [MoTaDuLieu("9. Chăm sóc hỗ trợ,2.7	Hỗ trợ khác ngày 4")]
        public string ChamSocHoTro97_4 { get; set; }
        [MoTaDuLieu("9. Chăm sóc hỗ trợ,2.7	Hỗ trợ khác ngày 5")]
        public string ChamSocHoTro97_5 { get; set; }
        [MoTaDuLieu("9. Chăm sóc hỗ trợ,2.7	Hỗ trợ khác ngày 6")]
        public string ChamSocHoTro97_6 { get; set; }
        [MoTaDuLieu("9. Chăm sóc hỗ trợ,2.7	Hỗ trợ khác ngày 7")]
        public string ChamSocHoTro97_7 { get; set; }
        [MoTaDuLieu("10. Can thiệp khác ngày 1")]
        public string CanThiepKhac_1 { get; set; }
        [MoTaDuLieu("10. Can thiệp khác ngày 2")]
        public string CanThiepKhac_2 { get; set; }
        [MoTaDuLieu("10. Can thiệp khác ngày 3")]
        public string CanThiepKhac_3 { get; set; }
        [MoTaDuLieu("10. Can thiệp khác ngày 4")]
        public string CanThiepKhac_4 { get; set; }
        [MoTaDuLieu("10. Can thiệp khác ngày 5")]
        public string CanThiepKhac_5 { get; set; }
        [MoTaDuLieu("10. Can thiệp khác ngày 6")]
        public string CanThiepKhac_6 { get; set; }
        [MoTaDuLieu("10. Can thiệp khác ngày 7")]
        public string CanThiepKhac_7 { get; set; }
        [MoTaDuLieu("ĐD chăm sóc ghi tên, ngày 1")]
        public string DieuDuong2_1 { get; set; }
        [MoTaDuLieu("ĐD chăm sóc ghi tên, ngày 2")]
        public string DieuDuong2_2 { get; set; }
        [MoTaDuLieu("ĐD chăm sóc ghi tên, ngày 3")]
        public string DieuDuong2_3 { get; set; }
        [MoTaDuLieu("ĐD chăm sóc ghi tên, ngày 4")]
        public string DieuDuong2_4 { get; set; }
        [MoTaDuLieu("ĐD chăm sóc ghi tên, ngày 5")]
        public string DieuDuong2_5 { get; set; }
        [MoTaDuLieu("ĐD chăm sóc ghi tên, ngày 6")]
        public string DieuDuong2_6 { get; set; }
        [MoTaDuLieu("ĐD chăm sóc ghi tên, ngày 7")]
        public string DieuDuong2_7 { get; set; }
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
    public class KHCSNguoiBenhCovid19_2Func
    {
        public const string TableName = "KHCSNguoiBenhCovid19_2";
        public const string TablePrimaryKeyName = "ID";
        public static List<KHCSNguoiBenhCovid19_2> GetListData(MDB.MDBConnection _OracleConnection, decimal maquanly)
        {
            List<KHCSNguoiBenhCovid19_2> list = new List<KHCSNguoiBenhCovid19_2>();
            try
            {
                string sql = @"SELECT * FROM KHCSNguoiBenhCovid19_2 where MaQuanLy = :MaQuanLy";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, _OracleConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", maquanly));
                MDB.MDBDataReader DataReader = Command.ExecuteReader();
                while (DataReader.Read())
                {
                    KHCSNguoiBenhCovid19_2 data = new KHCSNguoiBenhCovid19_2();
                    data.ID = Convert.ToInt64(DataReader.GetLong("ID").ToString());
                    data.MaQuanLy = maquanly;
                    data.MaBenhNhan = DataReader["MaBenhNhan"].ToString();
                    data.TenBenhNhan = XemBenhAn._HanhChinhBenhNhan.TenBenhNhan;
                    data.Tuoi = XemBenhAn._HanhChinhBenhNhan.Tuoi;
                    data.GioiTinh = XemBenhAn._HanhChinhBenhNhan.GioiTinh.Description();

                    data.NgayNhapVien = DataReader["NgayNhapVien"] != DBNull.Value ? (DateTime?) Convert.ToDateTime(DataReader["NgayNhapVien"].ToString()): null; 
                    data.ChanDoan = DataReader["ChanDoan"].ToString();
                    data.NgayThang1 = DataReader["NgayThang1"] != DBNull.Value ? (DateTime?)Convert.ToDateTime(DataReader["NgayThang1"].ToString()) : null;
                    data.GioThucHien1 = DataReader["GioThucHien1"] != DBNull.Value ? (DateTime?)Convert.ToDateTime(DataReader["GioThucHien1"].ToString()) : null;
                    data.GioThucHien2 = DataReader["GioThucHien2"] != DBNull.Value ? (DateTime?)Convert.ToDateTime(DataReader["GioThucHien2"].ToString()) : null;
                    data.GioThucHien3 = DataReader["GioThucHien3"] != DBNull.Value ? (DateTime?)Convert.ToDateTime(DataReader["GioThucHien3"].ToString()) : null;
                    data.GioThucHien4 = DataReader["GioThucHien4"] != DBNull.Value ? (DateTime?)Convert.ToDateTime(DataReader["GioThucHien4"].ToString()) : null;
                    data.GioThucHien5 = DataReader["GioThucHien5"] != DBNull.Value ? (DateTime?)Convert.ToDateTime(DataReader["GioThucHien5"].ToString()) : null;
                    data.GioThucHien6 = DataReader["GioThucHien6"] != DBNull.Value ? (DateTime?)Convert.ToDateTime(DataReader["GioThucHien6"].ToString()) : null;
                    data.GioThucHien7 = DataReader["GioThucHien7"] != DBNull.Value ? (DateTime?)Convert.ToDateTime(DataReader["GioThucHien7"].ToString()) : null;
                    data.TriGiac11 = DataReader["TriGiac11"].ToString();
                    data.TriGiac12 = DataReader["TriGiac12"].ToString();
                    data.TriGiac13 = DataReader["TriGiac13"].ToString();
                    data.TriGiac14 = DataReader["TriGiac14"].ToString();
                    data.DaNiem21 = DataReader["DaNiem21"].ToString();
                    data.DaNiem22 = DataReader["DaNiem22"].ToString();
                    data.DaNiem23 = DataReader["DaNiem23"].ToString();
                    data.Mach_1 = DataReader["Mach_1"].ToString();
                    data.Mach_2 = DataReader["Mach_2"].ToString();
                    data.Mach_3 = DataReader["Mach_3"].ToString();
                    data.Mach_4 = DataReader["Mach_4"].ToString();
                    data.Mach_5 = DataReader["Mach_5"].ToString();
                    data.Mach_6 = DataReader["Mach_6"].ToString();
                    data.Mach_7 = DataReader["Mach_7"].ToString();
                    data.NhietDo_1 = DataReader["NhietDo_1"].ToString();
                    data.NhietDo_2 = DataReader["NhietDo_2"].ToString();
                    data.NhietDo_3 = DataReader["NhietDo_3"].ToString();
                    data.NhietDo_4 = DataReader["NhietDo_4"].ToString();
                    data.NhietDo_5 = DataReader["NhietDo_5"].ToString();
                    data.NhietDo_6 = DataReader["NhietDo_6"].ToString();
                    data.NhietDo_7 = DataReader["NhietDo_7"].ToString();
                    data.HuyetAp_1 = DataReader["HuyetAp_1"].ToString();
                    data.HuyetAp_2 = DataReader["HuyetAp_2"].ToString();
                    data.HuyetAp_3 = DataReader["HuyetAp_3"].ToString();
                    data.HuyetAp_4 = DataReader["HuyetAp_4"].ToString();
                    data.HuyetAp_5 = DataReader["HuyetAp_5"].ToString();
                    data.HuyetAp_6 = DataReader["HuyetAp_6"].ToString();
                    data.HuyetAp_7 = DataReader["HuyetAp_7"].ToString();
                    data.NhipTho_1 = DataReader["NhipTho_1"].ToString();
                    data.NhipTho_2 = DataReader["NhipTho_2"].ToString();
                    data.NhipTho_3 = DataReader["NhipTho_3"].ToString();
                    data.NhipTho_4 = DataReader["NhipTho_4"].ToString();
                    data.NhipTho_5 = DataReader["NhipTho_5"].ToString();
                    data.NhipTho_6 = DataReader["NhipTho_6"].ToString();
                    data.NhipTho_7 = DataReader["NhipTho_7"].ToString();
                    data.SpO2_1 = DataReader["SpO2_1"].ToString();
                    data.SpO2_2 = DataReader["SpO2_2"].ToString();
                    data.SpO2_3 = DataReader["SpO2_3"].ToString();
                    data.SpO2_4 = DataReader["SpO2_4"].ToString();
                    data.SpO2_5 = DataReader["SpO2_5"].ToString();
                    data.SpO2_6 = DataReader["SpO2_6"].ToString();
                    data.SpO2_7 = DataReader["SpO2_7"].ToString();
                    data.TinhChatHoHap42 = DataReader["TinhChatHoHap42"].ToString();
                    data.TinhChatHoHap43 = DataReader["TinhChatHoHap43"].ToString();
                    data.TinhChatKhac51 = DataReader["TinhChatKhac51"].ToString();
                    data.TinhChatKhac52 = DataReader["TinhChatKhac52"].ToString();
                    data.TinhChatKhac53 = DataReader["TinhChatKhac53"].ToString();
                    data.TinhChatKhac54 = DataReader["TinhChatKhac54"].ToString();
                    data.TinhChatKhac55 = DataReader["TinhChatKhac55"].ToString();
                    data.TinhChatKhac56 = DataReader["TinhChatKhac56"].ToString();
                    data.TinhChatKhac57 = DataReader["TinhChatKhac57"].ToString();
                    data.TinhChatKhac58 = DataReader["TinhChatKhac58"].ToString();
                    data.TinhChatKhac59 = DataReader["TinhChatKhac59"].ToString();
                    data.TinhChatKhac510 = DataReader["TinhChatKhac510"].ToString();
                    data.DinhDuong61 = DataReader["DinhDuong61"].ToString();
                    data.DinhDuong62 = DataReader["DinhDuong62"].ToString();
                    data.TinhTrangBatThuong_1 = DataReader["TinhTrangBatThuong_1"].ToString();
                    data.TinhTrangBatThuong_2 = DataReader["TinhTrangBatThuong_2"].ToString();
                    data.TinhTrangBatThuong_3 = DataReader["TinhTrangBatThuong_3"].ToString();
                    data.TinhTrangBatThuong_4 = DataReader["TinhTrangBatThuong_4"].ToString();
                    data.TinhTrangBatThuong_5 = DataReader["TinhTrangBatThuong_5"].ToString();
                    data.TinhTrangBatThuong_6 = DataReader["TinhTrangBatThuong_6"].ToString();
                    data.TinhTrangBatThuong_7 = DataReader["TinhTrangBatThuong_7"].ToString();
                    data.DieuDuong1_1 = DataReader["DieuDuong1_1"].ToString();
                    data.DieuDuong1_2 = DataReader["DieuDuong1_2"].ToString();
                    data.DieuDuong1_3 = DataReader["DieuDuong1_3"].ToString();
                    data.DieuDuong1_4 = DataReader["DieuDuong1_4"].ToString();
                    data.DieuDuong1_5 = DataReader["DieuDuong1_5"].ToString();
                    data.DieuDuong1_6 = DataReader["DieuDuong1_6"].ToString();
                    data.DieuDuong1_7 = DataReader["DieuDuong1_7"].ToString();
                    data.NgayThang2 = DataReader["NgayThang2"] != DBNull.Value ? (DateTime?)Convert.ToDateTime(DataReader["NgayThang2"].ToString()) : null;
                    data.GioThucHien11 = DataReader["GioThucHien11"] != DBNull.Value ? (DateTime?)Convert.ToDateTime(DataReader["GioThucHien11"].ToString()) : null;
                    data.GioThucHien12 = DataReader["GioThucHien12"] != DBNull.Value ? (DateTime?)Convert.ToDateTime(DataReader["GioThucHien12"].ToString()) : null;
                    data.GioThucHien13 = DataReader["GioThucHien13"] != DBNull.Value ? (DateTime?)Convert.ToDateTime(DataReader["GioThucHien13"].ToString()) : null;
                    data.GioThucHien14 = DataReader["GioThucHien14"] != DBNull.Value ? (DateTime?)Convert.ToDateTime(DataReader["GioThucHien14"].ToString()) : null;
                    data.GioThucHien15 = DataReader["GioThucHien15"] != DBNull.Value ? (DateTime?)Convert.ToDateTime(DataReader["GioThucHien15"].ToString()) : null;
                    data.GioThucHien16 = DataReader["GioThucHien16"] != DBNull.Value ? (DateTime?)Convert.ToDateTime(DataReader["GioThucHien16"].ToString()) : null;
                    data.GioThucHien17 = DataReader["GioThucHien17"] != DBNull.Value ? (DateTime?)Convert.ToDateTime(DataReader["GioThucHien17"].ToString()) : null;
                    data.CapCuu81_1 = DataReader["CapCuu81_1"].ToString();
                    data.CapCuu81_2 = DataReader["CapCuu81_2"].ToString();
                    data.CapCuu81_3 = DataReader["CapCuu81_3"].ToString();
                    data.CapCuu81_4 = DataReader["CapCuu81_4"].ToString();
                    data.CapCuu81_5 = DataReader["CapCuu81_5"].ToString();
                    data.CapCuu81_6 = DataReader["CapCuu81_6"].ToString();
                    data.CapCuu81_7 = DataReader["CapCuu81_7"].ToString();
                    data.CapCuu821_1 = DataReader["CapCuu821_1"].ToString();
                    data.CapCuu821_2 = DataReader["CapCuu821_2"].ToString();
                    data.CapCuu821_3 = DataReader["CapCuu821_3"].ToString();
                    data.CapCuu821_4 = DataReader["CapCuu821_4"].ToString();
                    data.CapCuu821_5 = DataReader["CapCuu821_5"].ToString();
                    data.CapCuu821_6 = DataReader["CapCuu821_6"].ToString();
                    data.CapCuu821_7 = DataReader["CapCuu821_7"].ToString();
                    data.CapCuu822_1 = DataReader["CapCuu822_1"].ToString();
                    data.CapCuu822_2 = DataReader["CapCuu822_2"].ToString();
                    data.CapCuu822_3 = DataReader["CapCuu822_3"].ToString();
                    data.CapCuu822_4 = DataReader["CapCuu822_4"].ToString();
                    data.CapCuu822_5 = DataReader["CapCuu822_5"].ToString();
                    data.CapCuu822_6 = DataReader["CapCuu822_6"].ToString();
                    data.CapCuu822_7 = DataReader["CapCuu822_7"].ToString();
                    data.CapCuu823_1 = DataReader["CapCuu823_1"].ToString();
                    data.CapCuu823_2 = DataReader["CapCuu823_2"].ToString();
                    data.CapCuu823_3 = DataReader["CapCuu823_3"].ToString();
                    data.CapCuu823_4 = DataReader["CapCuu823_4"].ToString();
                    data.CapCuu823_5 = DataReader["CapCuu823_5"].ToString();
                    data.CapCuu823_6 = DataReader["CapCuu823_6"].ToString();
                    data.CapCuu823_7 = DataReader["CapCuu823_7"].ToString();
                    data.CapCuu824_1 = DataReader["CapCuu824_1"].ToString();
                    data.CapCuu824_2 = DataReader["CapCuu824_2"].ToString();
                    data.CapCuu824_3 = DataReader["CapCuu824_3"].ToString();
                    data.CapCuu824_4 = DataReader["CapCuu824_4"].ToString();
                    data.CapCuu824_5 = DataReader["CapCuu824_5"].ToString();
                    data.CapCuu824_6 = DataReader["CapCuu824_6"].ToString();
                    data.CapCuu824_7 = DataReader["CapCuu824_7"].ToString();
                    data.CapCuu825_1 = DataReader["CapCuu825_1"].ToString();
                    data.CapCuu825_2 = DataReader["CapCuu825_2"].ToString();
                    data.CapCuu825_3 = DataReader["CapCuu825_3"].ToString();
                    data.CapCuu825_4 = DataReader["CapCuu825_4"].ToString();
                    data.CapCuu825_5 = DataReader["CapCuu825_5"].ToString();
                    data.CapCuu825_6 = DataReader["CapCuu825_6"].ToString();
                    data.CapCuu825_7 = DataReader["CapCuu825_7"].ToString();
                    data.CapCuu83_1 = DataReader["CapCuu83_1"].ToString();
                    data.CapCuu83_2 = DataReader["CapCuu83_2"].ToString();
                    data.CapCuu83_3 = DataReader["CapCuu83_3"].ToString();
                    data.CapCuu83_4 = DataReader["CapCuu83_4"].ToString();
                    data.CapCuu83_5 = DataReader["CapCuu83_5"].ToString();
                    data.CapCuu83_6 = DataReader["CapCuu83_6"].ToString();
                    data.CapCuu83_7 = DataReader["CapCuu83_7"].ToString();
                    data.CapCuu84_1 = DataReader["CapCuu84_1"].ToString();
                    data.CapCuu84_2 = DataReader["CapCuu84_2"].ToString();
                    data.CapCuu84_3 = DataReader["CapCuu84_3"].ToString();
                    data.CapCuu84_4 = DataReader["CapCuu84_4"].ToString();
                    data.CapCuu84_5 = DataReader["CapCuu84_5"].ToString();
                    data.CapCuu84_6 = DataReader["CapCuu84_6"].ToString();
                    data.CapCuu84_7 = DataReader["CapCuu84_7"].ToString();
                    data.XuTriKhac_NoiDung_1 = DataReader["XuTriKhac_NoiDung_1"].ToString();
                    data.XuTriKhac_NoiDung_2 = DataReader["XuTriKhac_NoiDung_2"].ToString();
                    data.XuTriKhac_NoiDung_3 = DataReader["XuTriKhac_NoiDung_3"].ToString();
                    data.CapCuu851_1 = DataReader["CapCuu851_1"].ToString();
                    data.CapCuu851_2 = DataReader["CapCuu851_2"].ToString();
                    data.CapCuu851_3 = DataReader["CapCuu851_3"].ToString();
                    data.CapCuu851_4 = DataReader["CapCuu851_4"].ToString();
                    data.CapCuu851_5 = DataReader["CapCuu851_5"].ToString();
                    data.CapCuu851_6 = DataReader["CapCuu851_6"].ToString();
                    data.CapCuu851_7 = DataReader["CapCuu851_7"].ToString();
                    data.CapCuu852_1 = DataReader["CapCuu852_1"].ToString();
                    data.CapCuu852_2 = DataReader["CapCuu852_2"].ToString();
                    data.CapCuu852_3 = DataReader["CapCuu852_3"].ToString();
                    data.CapCuu852_4 = DataReader["CapCuu852_4"].ToString();
                    data.CapCuu852_5 = DataReader["CapCuu852_5"].ToString();
                    data.CapCuu852_6 = DataReader["CapCuu852_6"].ToString();
                    data.CapCuu852_7 = DataReader["CapCuu852_7"].ToString();
                    data.CapCuu853_1 = DataReader["CapCuu853_1"].ToString();
                    data.CapCuu853_2 = DataReader["CapCuu853_2"].ToString();
                    data.CapCuu853_3 = DataReader["CapCuu853_3"].ToString();
                    data.CapCuu853_4 = DataReader["CapCuu853_4"].ToString();
                    data.CapCuu853_5 = DataReader["CapCuu853_5"].ToString();
                    data.CapCuu853_6 = DataReader["CapCuu853_6"].ToString();
                    data.CapCuu853_7 = DataReader["CapCuu853_7"].ToString();
                    data.ChamSocHoTro91 = DataReader["ChamSocHoTro91"].ToString();
                    data.ChamSocHoTro92 = DataReader["ChamSocHoTro92"].ToString();
                    data.ChamSocHoTro93 = DataReader["ChamSocHoTro93"].ToString();
                    data.ChamSocHoTro94 = DataReader["ChamSocHoTro94"].ToString();
                    data.ChamSocHoTro95 = DataReader["ChamSocHoTro95"].ToString();
                    data.ChamSocHoTro96 = DataReader["ChamSocHoTro96"].ToString();
                    data.HoTroKhac = DataReader["HoTroKhac"].ToString();
                    data.ChamSocHoTro97_1 = DataReader["ChamSocHoTro97_1"].ToString();
                    data.ChamSocHoTro97_2 = DataReader["ChamSocHoTro97_2"].ToString();
                    data.ChamSocHoTro97_3 = DataReader["ChamSocHoTro97_3"].ToString();
                    data.ChamSocHoTro97_4 = DataReader["ChamSocHoTro97_4"].ToString();
                    data.ChamSocHoTro97_5 = DataReader["ChamSocHoTro97_5"].ToString();
                    data.ChamSocHoTro97_6 = DataReader["ChamSocHoTro97_6"].ToString();
                    data.ChamSocHoTro97_7 = DataReader["ChamSocHoTro97_7"].ToString();
                    data.CanThiepKhac_1 = DataReader["CanThiepKhac_1"].ToString();
                    data.CanThiepKhac_2 = DataReader["CanThiepKhac_2"].ToString();
                    data.CanThiepKhac_3 = DataReader["CanThiepKhac_3"].ToString();
                    data.CanThiepKhac_4 = DataReader["CanThiepKhac_4"].ToString();
                    data.CanThiepKhac_5 = DataReader["CanThiepKhac_5"].ToString();
                    data.CanThiepKhac_6 = DataReader["CanThiepKhac_6"].ToString();
                    data.CanThiepKhac_7 = DataReader["CanThiepKhac_7"].ToString();
                    data.DieuDuong2_1 = DataReader["DieuDuong2_1"].ToString();
                    data.DieuDuong2_2 = DataReader["DieuDuong2_2"].ToString();
                    data.DieuDuong2_3 = DataReader["DieuDuong2_3"].ToString();
                    data.DieuDuong2_4 = DataReader["DieuDuong2_4"].ToString();
                    data.DieuDuong2_5 = DataReader["DieuDuong2_5"].ToString();
                    data.DieuDuong2_6 = DataReader["DieuDuong2_6"].ToString();
                    data.DieuDuong2_7 = DataReader["DieuDuong2_7"].ToString();

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
        public static bool InsertOrUpdate(MDB.MDBConnection MyConnection, ref KHCSNguoiBenhCovid19_2 ketQua)
        {
            try
            {
                string sql = @"INSERT INTO KHCSNguoiBenhCovid19_2
                (
                    MAQUANLY,
                    MaBenhNhan,
                    NgayNhapVien,
                    ChanDoan,
                    NgayThang1,
                    GioThucHien1,
                    GioThucHien2,
                    GioThucHien3,
                    GioThucHien4,
                    GioThucHien5,
                    GioThucHien6,
                    GioThucHien7,
                    TriGiac11,
                    TriGiac12,
                    TriGiac13,
                    TriGiac14,
                    DaNiem21,
                    DaNiem22,
                    DaNiem23,
                    Mach_1,
                    Mach_2,
                    Mach_3,
                    Mach_4,
                    Mach_5,
                    Mach_6,
                    Mach_7,
                    NhietDo_1,
                    NhietDo_2,
                    NhietDo_3,
                    NhietDo_4,
                    NhietDo_5,
                    NhietDo_6,
                    NhietDo_7,
                    HuyetAp_1,
                    HuyetAp_2,
                    HuyetAp_3,
                    HuyetAp_4,
                    HuyetAp_5,
                    HuyetAp_6,
                    HuyetAp_7,
                    NhipTho_1,
                    NhipTho_2,
                    NhipTho_3,
                    NhipTho_4,
                    NhipTho_5,
                    NhipTho_6,
                    NhipTho_7,
                    SpO2_1,
                    SpO2_2,
                    SpO2_3,
                    SpO2_4,
                    SpO2_5,
                    SpO2_6,
                    SpO2_7,
                    TinhChatHoHap42,
                    TinhChatHoHap43,
                    TinhChatKhac51,
                    TinhChatKhac52,
                    TinhChatKhac53,
                    TinhChatKhac54,
                    TinhChatKhac55,
                    TinhChatKhac56,
                    TinhChatKhac57,
                    TinhChatKhac58,
                    TinhChatKhac59,
                    TinhChatKhac510,
                    DinhDuong61,
                    DinhDuong62,
                    TinhTrangBatThuong_1,
                    TinhTrangBatThuong_2,
                    TinhTrangBatThuong_3,
                    TinhTrangBatThuong_4,
                    TinhTrangBatThuong_5,
                    TinhTrangBatThuong_6,
                    TinhTrangBatThuong_7,
                    DieuDuong1_1,
                    DieuDuong1_2,
                    DieuDuong1_3,
                    DieuDuong1_4,
                    DieuDuong1_5,
                    DieuDuong1_6,
                    DieuDuong1_7,
                    NgayThang2,
                    GioThucHien11,
                    GioThucHien12,
                    GioThucHien13,
                    GioThucHien14,
                    GioThucHien15,
                    GioThucHien16,
                    GioThucHien17,
                    CapCuu81_1,
                    CapCuu81_2,
                    CapCuu81_3,
                    CapCuu81_4,
                    CapCuu81_5,
                    CapCuu81_6,
                    CapCuu81_7,
                    CapCuu821_1,
                    CapCuu821_2,
                    CapCuu821_3,
                    CapCuu821_4,
                    CapCuu821_5,
                    CapCuu821_6,
                    CapCuu821_7,
                    CapCuu822_1,
                    CapCuu822_2,
                    CapCuu822_3,
                    CapCuu822_4,
                    CapCuu822_5,
                    CapCuu822_6,
                    CapCuu822_7,
                    CapCuu823_1,
                    CapCuu823_2,
                    CapCuu823_3,
                    CapCuu823_4,
                    CapCuu823_5,
                    CapCuu823_6,
                    CapCuu823_7,
                    CapCuu824_1,
                    CapCuu824_2,
                    CapCuu824_3,
                    CapCuu824_4,
                    CapCuu824_5,
                    CapCuu824_6,
                    CapCuu824_7,
                    CapCuu825_1,
                    CapCuu825_2,
                    CapCuu825_3,
                    CapCuu825_4,
                    CapCuu825_5,
                    CapCuu825_6,
                    CapCuu825_7,
                    CapCuu83_1,
                    CapCuu83_2,
                    CapCuu83_3,
                    CapCuu83_4,
                    CapCuu83_5,
                    CapCuu83_6,
                    CapCuu83_7,
                    CapCuu84_1,
                    CapCuu84_2,
                    CapCuu84_3,
                    CapCuu84_4,
                    CapCuu84_5,
                    CapCuu84_6,
                    CapCuu84_7,
                    XuTriKhac_NoiDung_1,
                    XuTriKhac_NoiDung_2,
                    XuTriKhac_NoiDung_3,
                    CapCuu851_1,
                    CapCuu851_2,
                    CapCuu851_3,
                    CapCuu851_4,
                    CapCuu851_5,
                    CapCuu851_6,
                    CapCuu851_7,
                    CapCuu852_1,
                    CapCuu852_2,
                    CapCuu852_3,
                    CapCuu852_4,
                    CapCuu852_5,
                    CapCuu852_6,
                    CapCuu852_7,
                    CapCuu853_1,
                    CapCuu853_2,
                    CapCuu853_3,
                    CapCuu853_4,
                    CapCuu853_5,
                    CapCuu853_6,
                    CapCuu853_7,
                    ChamSocHoTro91,
                    ChamSocHoTro92,
                    ChamSocHoTro93,
                    ChamSocHoTro94,
                    ChamSocHoTro95,
                    ChamSocHoTro96,
                    HoTroKhac,
                    ChamSocHoTro97_1,
                    ChamSocHoTro97_2,
                    ChamSocHoTro97_3,
                    ChamSocHoTro97_4,
                    ChamSocHoTro97_5,
                    ChamSocHoTro97_6,
                    ChamSocHoTro97_7,
                    CanThiepKhac_1,
                    CanThiepKhac_2,
                    CanThiepKhac_3,
                    CanThiepKhac_4,
                    CanThiepKhac_5,
                    CanThiepKhac_6,
                    CanThiepKhac_7,
                    DieuDuong2_1,
                    DieuDuong2_2,
                    DieuDuong2_3,
                    DieuDuong2_4,
                    DieuDuong2_5,
                    DieuDuong2_6,
                    DieuDuong2_7,
                    NGUOITAO,
                    NGUOISUA,
                    NGAYTAO,
                    NGAYSUA)  VALUES
                 (
				    :MAQUANLY,
                    :MaBenhNhan,
                    :NgayNhapVien,
                    :ChanDoan,
                    :NgayThang1,
                    :GioThucHien1,
                    :GioThucHien2,
                    :GioThucHien3,
                    :GioThucHien4,
                    :GioThucHien5,
                    :GioThucHien6,
                    :GioThucHien7,
                    :TriGiac11,
                    :TriGiac12,
                    :TriGiac13,
                    :TriGiac14,
                    :DaNiem21,
                    :DaNiem22,
                    :DaNiem23,
                    :Mach_1,
                    :Mach_2,
                    :Mach_3,
                    :Mach_4,
                    :Mach_5,
                    :Mach_6,
                    :Mach_7,
                    :NhietDo_1,
                    :NhietDo_2,
                    :NhietDo_3,
                    :NhietDo_4,
                    :NhietDo_5,
                    :NhietDo_6,
                    :NhietDo_7,
                    :HuyetAp_1,
                    :HuyetAp_2,
                    :HuyetAp_3,
                    :HuyetAp_4,
                    :HuyetAp_5,
                    :HuyetAp_6,
                    :HuyetAp_7,
                    :NhipTho_1,
                    :NhipTho_2,
                    :NhipTho_3,
                    :NhipTho_4,
                    :NhipTho_5,
                    :NhipTho_6,
                    :NhipTho_7,
                    :SpO2_1,
                    :SpO2_2,
                    :SpO2_3,
                    :SpO2_4,
                    :SpO2_5,
                    :SpO2_6,
                    :SpO2_7,
                    :TinhChatHoHap42,
                    :TinhChatHoHap43,
                    :TinhChatKhac51,
                    :TinhChatKhac52,
                    :TinhChatKhac53,
                    :TinhChatKhac54,
                    :TinhChatKhac55,
                    :TinhChatKhac56,
                    :TinhChatKhac57,
                    :TinhChatKhac58,
                    :TinhChatKhac59,
                    :TinhChatKhac510,
                    :DinhDuong61,
                    :DinhDuong62,
                    :TinhTrangBatThuong_1,
                    :TinhTrangBatThuong_2,
                    :TinhTrangBatThuong_3,
                    :TinhTrangBatThuong_4,
                    :TinhTrangBatThuong_5,
                    :TinhTrangBatThuong_6,
                    :TinhTrangBatThuong_7,
                    :DieuDuong1_1,
                    :DieuDuong1_2,
                    :DieuDuong1_3,
                    :DieuDuong1_4,
                    :DieuDuong1_5,
                    :DieuDuong1_6,
                    :DieuDuong1_7,
                    :NgayThang2,
                    :GioThucHien11,
                    :GioThucHien12,
                    :GioThucHien13,
                    :GioThucHien14,
                    :GioThucHien15,
                    :GioThucHien16,
                    :GioThucHien17,
                    :CapCuu81_1,
                    :CapCuu81_2,
                    :CapCuu81_3,
                    :CapCuu81_4,
                    :CapCuu81_5,
                    :CapCuu81_6,
                    :CapCuu81_7,
                    :CapCuu821_1,
                    :CapCuu821_2,
                    :CapCuu821_3,
                    :CapCuu821_4,
                    :CapCuu821_5,
                    :CapCuu821_6,
                    :CapCuu821_7,
                    :CapCuu822_1,
                    :CapCuu822_2,
                    :CapCuu822_3,
                    :CapCuu822_4,
                    :CapCuu822_5,
                    :CapCuu822_6,
                    :CapCuu822_7,
                    :CapCuu823_1,
                    :CapCuu823_2,
                    :CapCuu823_3,
                    :CapCuu823_4,
                    :CapCuu823_5,
                    :CapCuu823_6,
                    :CapCuu823_7,
                    :CapCuu824_1,
                    :CapCuu824_2,
                    :CapCuu824_3,
                    :CapCuu824_4,
                    :CapCuu824_5,
                    :CapCuu824_6,
                    :CapCuu824_7,
                    :CapCuu825_1,
                    :CapCuu825_2,
                    :CapCuu825_3,
                    :CapCuu825_4,
                    :CapCuu825_5,
                    :CapCuu825_6,
                    :CapCuu825_7,
                    :CapCuu83_1,
                    :CapCuu83_2,
                    :CapCuu83_3,
                    :CapCuu83_4,
                    :CapCuu83_5,
                    :CapCuu83_6,
                    :CapCuu83_7,
                    :CapCuu84_1,
                    :CapCuu84_2,
                    :CapCuu84_3,
                    :CapCuu84_4,
                    :CapCuu84_5,
                    :CapCuu84_6,
                    :CapCuu84_7,
                    :XuTriKhac_NoiDung_1,
                    :XuTriKhac_NoiDung_2,
                    :XuTriKhac_NoiDung_3,
                    :CapCuu851_1,
                    :CapCuu851_2,
                    :CapCuu851_3,
                    :CapCuu851_4,
                    :CapCuu851_5,
                    :CapCuu851_6,
                    :CapCuu851_7,
                    :CapCuu852_1,
                    :CapCuu852_2,
                    :CapCuu852_3,
                    :CapCuu852_4,
                    :CapCuu852_5,
                    :CapCuu852_6,
                    :CapCuu852_7,
                    :CapCuu853_1,
                    :CapCuu853_2,
                    :CapCuu853_3,
                    :CapCuu853_4,
                    :CapCuu853_5,
                    :CapCuu853_6,
                    :CapCuu853_7,
                    :ChamSocHoTro91,
                    :ChamSocHoTro92,
                    :ChamSocHoTro93,
                    :ChamSocHoTro94,
                    :ChamSocHoTro95,
                    :ChamSocHoTro96,
                    :HoTroKhac,
                    :ChamSocHoTro97_1,
                    :ChamSocHoTro97_2,
                    :ChamSocHoTro97_3,
                    :ChamSocHoTro97_4,
                    :ChamSocHoTro97_5,
                    :ChamSocHoTro97_6,
                    :ChamSocHoTro97_7,
                    :CanThiepKhac_1,
                    :CanThiepKhac_2,
                    :CanThiepKhac_3,
                    :CanThiepKhac_4,
                    :CanThiepKhac_5,
                    :CanThiepKhac_6,
                    :CanThiepKhac_7,
                    :DieuDuong2_1,
                    :DieuDuong2_2,
                    :DieuDuong2_3,
                    :DieuDuong2_4,
                    :DieuDuong2_5,
                    :DieuDuong2_6,
                    :DieuDuong2_7,
                    :NGUOITAO,
                    :NGUOISUA,
                    :NGAYTAO,
                    :NGAYSUA
                 )  RETURNING ID INTO :ID";
                if (ketQua.ID != 0)
                {
                    sql = @"UPDATE KHCSNguoiBenhCovid19_2 SET 
                    MAQUANLY = :MAQUANLY,
                    MaBenhNhan = :MaBenhNhan,
                    NgayNhapVien=:NgayNhapVien,
                    ChanDoan=:ChanDoan,
                    NgayThang1=:NgayThang1,
                    GioThucHien1=:GioThucHien1,
                    GioThucHien2=:GioThucHien2,
                    GioThucHien3=:GioThucHien3,
                    GioThucHien4=:GioThucHien4,
                    GioThucHien5=:GioThucHien5,
                    GioThucHien6=:GioThucHien6,
                    GioThucHien7=:GioThucHien7,
                    TriGiac11=:TriGiac11,
                    TriGiac12=:TriGiac12,
                    TriGiac13=:TriGiac13,
                    TriGiac14=:TriGiac14,
                    DaNiem21=:DaNiem21,
                    DaNiem22=:DaNiem22,
                    DaNiem23=:DaNiem23,
                    Mach_1=:Mach_1,
                    Mach_2=:Mach_2,
                    Mach_3=:Mach_3,
                    Mach_4=:Mach_4,
                    Mach_5=:Mach_5,
                    Mach_6=:Mach_6,
                    Mach_7=:Mach_7,
                    NhietDo_1=:NhietDo_1,
                    NhietDo_2=:NhietDo_2,
                    NhietDo_3=:NhietDo_3,
                    NhietDo_4=:NhietDo_4,
                    NhietDo_5=:NhietDo_5,
                    NhietDo_6=:NhietDo_6,
                    NhietDo_7=:NhietDo_7,
                    HuyetAp_1=:HuyetAp_1,
                    HuyetAp_2=:HuyetAp_2,
                    HuyetAp_3=:HuyetAp_3,
                    HuyetAp_4=:HuyetAp_4,
                    HuyetAp_5=:HuyetAp_5,
                    HuyetAp_6=:HuyetAp_6,
                    HuyetAp_7=:HuyetAp_7,
                    NhipTho_1=:NhipTho_1,
                    NhipTho_2=:NhipTho_2,
                    NhipTho_3=:NhipTho_3,
                    NhipTho_4=:NhipTho_4,
                    NhipTho_5=:NhipTho_5,
                    NhipTho_6=:NhipTho_6,
                    NhipTho_7=:NhipTho_7,
                    SpO2_1=:SpO2_1,
                    SpO2_2=:SpO2_2,
                    SpO2_3=:SpO2_3,
                    SpO2_4=:SpO2_4,
                    SpO2_5=:SpO2_5,
                    SpO2_6=:SpO2_6,
                    SpO2_7=:SpO2_7,
                    TinhChatHoHap42=:TinhChatHoHap42,
                    TinhChatHoHap43=:TinhChatHoHap43,
                    TinhChatKhac51=:TinhChatKhac51,
                    TinhChatKhac52=:TinhChatKhac52,
                    TinhChatKhac53=:TinhChatKhac53,
                    TinhChatKhac54=:TinhChatKhac54,
                    TinhChatKhac55=:TinhChatKhac55,
                    TinhChatKhac56=:TinhChatKhac56,
                    TinhChatKhac57=:TinhChatKhac57,
                    TinhChatKhac58=:TinhChatKhac58,
                    TinhChatKhac59=:TinhChatKhac59,
                    TinhChatKhac510=:TinhChatKhac510,
                    DinhDuong61=:DinhDuong61,
                    DinhDuong62=:DinhDuong62,
                    TinhTrangBatThuong_1=:TinhTrangBatThuong_1,
                    TinhTrangBatThuong_2=:TinhTrangBatThuong_2,
                    TinhTrangBatThuong_3=:TinhTrangBatThuong_3,
                    TinhTrangBatThuong_4=:TinhTrangBatThuong_4,
                    TinhTrangBatThuong_5=:TinhTrangBatThuong_5,
                    TinhTrangBatThuong_6=:TinhTrangBatThuong_6,
                    TinhTrangBatThuong_7=:TinhTrangBatThuong_7,
                    DieuDuong1_1=:DieuDuong1_1,
                    DieuDuong1_2=:DieuDuong1_2,
                    DieuDuong1_3=:DieuDuong1_3,
                    DieuDuong1_4=:DieuDuong1_4,
                    DieuDuong1_5=:DieuDuong1_5,
                    DieuDuong1_6=:DieuDuong1_6,
                    DieuDuong1_7=:DieuDuong1_7,
                    NgayThang2=:NgayThang2,
                    GioThucHien11=:GioThucHien11,
                    GioThucHien12=:GioThucHien12,
                    GioThucHien13=:GioThucHien13,
                    GioThucHien14=:GioThucHien14,
                    GioThucHien15=:GioThucHien15,
                    GioThucHien16=:GioThucHien16,
                    GioThucHien17=:GioThucHien17,
                    CapCuu81_1=:CapCuu81_1,
                    CapCuu81_2=:CapCuu81_2,
                    CapCuu81_3=:CapCuu81_3,
                    CapCuu81_4=:CapCuu81_4,
                    CapCuu81_5=:CapCuu81_5,
                    CapCuu81_6=:CapCuu81_6,
                    CapCuu81_7=:CapCuu81_7,
                    CapCuu821_1=:CapCuu821_1,
                    CapCuu821_2=:CapCuu821_2,
                    CapCuu821_3=:CapCuu821_3,
                    CapCuu821_4=:CapCuu821_4,
                    CapCuu821_5=:CapCuu821_5,
                    CapCuu821_6=:CapCuu821_6,
                    CapCuu821_7=:CapCuu821_7,
                    CapCuu822_1=:CapCuu822_1,
                    CapCuu822_2=:CapCuu822_2,
                    CapCuu822_3=:CapCuu822_3,
                    CapCuu822_4=:CapCuu822_4,
                    CapCuu822_5=:CapCuu822_5,
                    CapCuu822_6=:CapCuu822_6,
                    CapCuu822_7=:CapCuu822_7,
                    CapCuu823_1=:CapCuu823_1,
                    CapCuu823_2=:CapCuu823_2,
                    CapCuu823_3=:CapCuu823_3,
                    CapCuu823_4=:CapCuu823_4,
                    CapCuu823_5=:CapCuu823_5,
                    CapCuu823_6=:CapCuu823_6,
                    CapCuu823_7=:CapCuu823_7,
                    CapCuu824_1=:CapCuu824_1,
                    CapCuu824_2=:CapCuu824_2,
                    CapCuu824_3=:CapCuu824_3,
                    CapCuu824_4=:CapCuu824_4,
                    CapCuu824_5=:CapCuu824_5,
                    CapCuu824_6=:CapCuu824_6,
                    CapCuu824_7=:CapCuu824_7,
                    CapCuu825_1=:CapCuu825_1,
                    CapCuu825_2=:CapCuu825_2,
                    CapCuu825_3=:CapCuu825_3,
                    CapCuu825_4=:CapCuu825_4,
                    CapCuu825_5=:CapCuu825_5,
                    CapCuu825_6=:CapCuu825_6,
                    CapCuu825_7=:CapCuu825_7,
                    CapCuu83_1=:CapCuu83_1,
                    CapCuu83_2=:CapCuu83_2,
                    CapCuu83_3=:CapCuu83_3,
                    CapCuu83_4=:CapCuu83_4,
                    CapCuu83_5=:CapCuu83_5,
                    CapCuu83_6=:CapCuu83_6,
                    CapCuu83_7=:CapCuu83_7,
                    CapCuu84_1=:CapCuu84_1,
                    CapCuu84_2=:CapCuu84_2,
                    CapCuu84_3=:CapCuu84_3,
                    CapCuu84_4=:CapCuu84_4,
                    CapCuu84_5=:CapCuu84_5,
                    CapCuu84_6=:CapCuu84_6,
                    CapCuu84_7=:CapCuu84_7,
                    XuTriKhac_NoiDung_1=:XuTriKhac_NoiDung_1,
                    XuTriKhac_NoiDung_2=:XuTriKhac_NoiDung_2,
                    XuTriKhac_NoiDung_3=:XuTriKhac_NoiDung_3,
                    CapCuu851_1=:CapCuu851_1,
                    CapCuu851_2=:CapCuu851_2,
                    CapCuu851_3=:CapCuu851_3,
                    CapCuu851_4=:CapCuu851_4,
                    CapCuu851_5=:CapCuu851_5,
                    CapCuu851_6=:CapCuu851_6,
                    CapCuu851_7=:CapCuu851_7,
                    CapCuu852_1=:CapCuu852_1,
                    CapCuu852_2=:CapCuu852_2,
                    CapCuu852_3=:CapCuu852_3,
                    CapCuu852_4=:CapCuu852_4,
                    CapCuu852_5=:CapCuu852_5,
                    CapCuu852_6=:CapCuu852_6,
                    CapCuu852_7=:CapCuu852_7,
                    CapCuu853_1=:CapCuu853_1,
                    CapCuu853_2=:CapCuu853_2,
                    CapCuu853_3=:CapCuu853_3,
                    CapCuu853_4=:CapCuu853_4,
                    CapCuu853_5=:CapCuu853_5,
                    CapCuu853_6=:CapCuu853_6,
                    CapCuu853_7=:CapCuu853_7,
                    ChamSocHoTro91=:ChamSocHoTro91,
                    ChamSocHoTro92=:ChamSocHoTro92,
                    ChamSocHoTro93=:ChamSocHoTro93,
                    ChamSocHoTro94=:ChamSocHoTro94,
                    ChamSocHoTro95=:ChamSocHoTro95,
                    ChamSocHoTro96=:ChamSocHoTro96,
                    HoTroKhac=:HoTroKhac,
                    ChamSocHoTro97_1=:ChamSocHoTro97_1,
                    ChamSocHoTro97_2=:ChamSocHoTro97_2,
                    ChamSocHoTro97_3=:ChamSocHoTro97_3,
                    ChamSocHoTro97_4=:ChamSocHoTro97_4,
                    ChamSocHoTro97_5=:ChamSocHoTro97_5,
                    ChamSocHoTro97_6=:ChamSocHoTro97_6,
                    ChamSocHoTro97_7=:ChamSocHoTro97_7,
                    CanThiepKhac_1=:CanThiepKhac_1,
                    CanThiepKhac_2=:CanThiepKhac_2,
                    CanThiepKhac_3=:CanThiepKhac_3,
                    CanThiepKhac_4=:CanThiepKhac_4,
                    CanThiepKhac_5=:CanThiepKhac_5,
                    CanThiepKhac_6=:CanThiepKhac_6,
                    CanThiepKhac_7=:CanThiepKhac_7,
                    DieuDuong2_1=:DieuDuong2_1,
                    DieuDuong2_2=:DieuDuong2_2,
                    DieuDuong2_3=:DieuDuong2_3,
                    DieuDuong2_4=:DieuDuong2_4,
                    DieuDuong2_5=:DieuDuong2_5,
                    DieuDuong2_6=:DieuDuong2_6,
                    DieuDuong2_7=:DieuDuong2_7,
                    NGUOISUA = :NGUOISUA,
                    NGAYSUA = :NGAYSUA
                    WHERE ID = " + ketQua.ID;
                }
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MAQUANLY", ketQua.MaQuanLy));
                Command.Parameters.Add(new MDB.MDBParameter("MaBenhNhan", ketQua.MaBenhNhan));
                Command.Parameters.Add(new MDB.MDBParameter("NgayNhapVien", ketQua.NgayNhapVien));
                Command.Parameters.Add(new MDB.MDBParameter("ChanDoan", ketQua.ChanDoan));
                Command.Parameters.Add(new MDB.MDBParameter("NgayThang1", ketQua.NgayThang1));
                Command.Parameters.Add(new MDB.MDBParameter("GioThucHien1", ketQua.GioThucHien1));
                Command.Parameters.Add(new MDB.MDBParameter("GioThucHien2", ketQua.GioThucHien2));
                Command.Parameters.Add(new MDB.MDBParameter("GioThucHien3", ketQua.GioThucHien3));
                Command.Parameters.Add(new MDB.MDBParameter("GioThucHien4", ketQua.GioThucHien4));
                Command.Parameters.Add(new MDB.MDBParameter("GioThucHien5", ketQua.GioThucHien5));
                Command.Parameters.Add(new MDB.MDBParameter("GioThucHien6", ketQua.GioThucHien6));
                Command.Parameters.Add(new MDB.MDBParameter("GioThucHien7", ketQua.GioThucHien7));
                Command.Parameters.Add(new MDB.MDBParameter("TriGiac11", ketQua.TriGiac11));
                Command.Parameters.Add(new MDB.MDBParameter("TriGiac12", ketQua.TriGiac12));
                Command.Parameters.Add(new MDB.MDBParameter("TriGiac13", ketQua.TriGiac13));
                Command.Parameters.Add(new MDB.MDBParameter("TriGiac14", ketQua.TriGiac14));
                Command.Parameters.Add(new MDB.MDBParameter("DaNiem21", ketQua.DaNiem21));
                Command.Parameters.Add(new MDB.MDBParameter("DaNiem22", ketQua.DaNiem22));
                Command.Parameters.Add(new MDB.MDBParameter("DaNiem23", ketQua.DaNiem23));
                Command.Parameters.Add(new MDB.MDBParameter("Mach_1", ketQua.Mach_1));
                Command.Parameters.Add(new MDB.MDBParameter("Mach_2", ketQua.Mach_2));
                Command.Parameters.Add(new MDB.MDBParameter("Mach_3", ketQua.Mach_3));
                Command.Parameters.Add(new MDB.MDBParameter("Mach_4", ketQua.Mach_4));
                Command.Parameters.Add(new MDB.MDBParameter("Mach_5", ketQua.Mach_5));
                Command.Parameters.Add(new MDB.MDBParameter("Mach_6", ketQua.Mach_6));
                Command.Parameters.Add(new MDB.MDBParameter("Mach_7", ketQua.Mach_7));
                Command.Parameters.Add(new MDB.MDBParameter("NhietDo_1", ketQua.NhietDo_1));
                Command.Parameters.Add(new MDB.MDBParameter("NhietDo_2", ketQua.NhietDo_2));
                Command.Parameters.Add(new MDB.MDBParameter("NhietDo_3", ketQua.NhietDo_3));
                Command.Parameters.Add(new MDB.MDBParameter("NhietDo_4", ketQua.NhietDo_4));
                Command.Parameters.Add(new MDB.MDBParameter("NhietDo_5", ketQua.NhietDo_5));
                Command.Parameters.Add(new MDB.MDBParameter("NhietDo_6", ketQua.NhietDo_6));
                Command.Parameters.Add(new MDB.MDBParameter("NhietDo_7", ketQua.NhietDo_7));
                Command.Parameters.Add(new MDB.MDBParameter("HuyetAp_1", ketQua.HuyetAp_1));
                Command.Parameters.Add(new MDB.MDBParameter("HuyetAp_2", ketQua.HuyetAp_2));
                Command.Parameters.Add(new MDB.MDBParameter("HuyetAp_3", ketQua.HuyetAp_3));
                Command.Parameters.Add(new MDB.MDBParameter("HuyetAp_4", ketQua.HuyetAp_4));
                Command.Parameters.Add(new MDB.MDBParameter("HuyetAp_5", ketQua.HuyetAp_5));
                Command.Parameters.Add(new MDB.MDBParameter("HuyetAp_6", ketQua.HuyetAp_6));
                Command.Parameters.Add(new MDB.MDBParameter("HuyetAp_7", ketQua.HuyetAp_7));
                Command.Parameters.Add(new MDB.MDBParameter("NhipTho_1", ketQua.NhipTho_1));
                Command.Parameters.Add(new MDB.MDBParameter("NhipTho_2", ketQua.NhipTho_2));
                Command.Parameters.Add(new MDB.MDBParameter("NhipTho_3", ketQua.NhipTho_3));
                Command.Parameters.Add(new MDB.MDBParameter("NhipTho_4", ketQua.NhipTho_4));
                Command.Parameters.Add(new MDB.MDBParameter("NhipTho_5", ketQua.NhipTho_5));
                Command.Parameters.Add(new MDB.MDBParameter("NhipTho_6", ketQua.NhipTho_6));
                Command.Parameters.Add(new MDB.MDBParameter("NhipTho_7", ketQua.NhipTho_7));
                Command.Parameters.Add(new MDB.MDBParameter("SpO2_1", ketQua.SpO2_1));
                Command.Parameters.Add(new MDB.MDBParameter("SpO2_2", ketQua.SpO2_2));
                Command.Parameters.Add(new MDB.MDBParameter("SpO2_3", ketQua.SpO2_3));
                Command.Parameters.Add(new MDB.MDBParameter("SpO2_4", ketQua.SpO2_4));
                Command.Parameters.Add(new MDB.MDBParameter("SpO2_5", ketQua.SpO2_5));
                Command.Parameters.Add(new MDB.MDBParameter("SpO2_6", ketQua.SpO2_6));
                Command.Parameters.Add(new MDB.MDBParameter("SpO2_7", ketQua.SpO2_7));
                Command.Parameters.Add(new MDB.MDBParameter("TinhChatHoHap42", ketQua.TinhChatHoHap42));
                Command.Parameters.Add(new MDB.MDBParameter("TinhChatHoHap43", ketQua.TinhChatHoHap43));
                Command.Parameters.Add(new MDB.MDBParameter("TinhChatKhac51", ketQua.TinhChatKhac51));
                Command.Parameters.Add(new MDB.MDBParameter("TinhChatKhac52", ketQua.TinhChatKhac52));
                Command.Parameters.Add(new MDB.MDBParameter("TinhChatKhac53", ketQua.TinhChatKhac53));
                Command.Parameters.Add(new MDB.MDBParameter("TinhChatKhac54", ketQua.TinhChatKhac54));
                Command.Parameters.Add(new MDB.MDBParameter("TinhChatKhac55", ketQua.TinhChatKhac55));
                Command.Parameters.Add(new MDB.MDBParameter("TinhChatKhac56", ketQua.TinhChatKhac56));
                Command.Parameters.Add(new MDB.MDBParameter("TinhChatKhac57", ketQua.TinhChatKhac57));
                Command.Parameters.Add(new MDB.MDBParameter("TinhChatKhac58", ketQua.TinhChatKhac58));
                Command.Parameters.Add(new MDB.MDBParameter("TinhChatKhac59", ketQua.TinhChatKhac59));
                Command.Parameters.Add(new MDB.MDBParameter("TinhChatKhac510", ketQua.TinhChatKhac510));
                Command.Parameters.Add(new MDB.MDBParameter("DinhDuong61", ketQua.DinhDuong61));
                Command.Parameters.Add(new MDB.MDBParameter("DinhDuong62", ketQua.DinhDuong62));
                Command.Parameters.Add(new MDB.MDBParameter("TinhTrangBatThuong_1", ketQua.TinhTrangBatThuong_1));
                Command.Parameters.Add(new MDB.MDBParameter("TinhTrangBatThuong_2", ketQua.TinhTrangBatThuong_2));
                Command.Parameters.Add(new MDB.MDBParameter("TinhTrangBatThuong_3", ketQua.TinhTrangBatThuong_3));
                Command.Parameters.Add(new MDB.MDBParameter("TinhTrangBatThuong_4", ketQua.TinhTrangBatThuong_4));
                Command.Parameters.Add(new MDB.MDBParameter("TinhTrangBatThuong_5", ketQua.TinhTrangBatThuong_5));
                Command.Parameters.Add(new MDB.MDBParameter("TinhTrangBatThuong_6", ketQua.TinhTrangBatThuong_6));
                Command.Parameters.Add(new MDB.MDBParameter("TinhTrangBatThuong_7", ketQua.TinhTrangBatThuong_7));
                Command.Parameters.Add(new MDB.MDBParameter("DieuDuong1_1", ketQua.DieuDuong1_1));
                Command.Parameters.Add(new MDB.MDBParameter("DieuDuong1_2", ketQua.DieuDuong1_2));
                Command.Parameters.Add(new MDB.MDBParameter("DieuDuong1_3", ketQua.DieuDuong1_3));
                Command.Parameters.Add(new MDB.MDBParameter("DieuDuong1_4", ketQua.DieuDuong1_4));
                Command.Parameters.Add(new MDB.MDBParameter("DieuDuong1_5", ketQua.DieuDuong1_5));
                Command.Parameters.Add(new MDB.MDBParameter("DieuDuong1_6", ketQua.DieuDuong1_6));
                Command.Parameters.Add(new MDB.MDBParameter("DieuDuong1_7", ketQua.DieuDuong1_7));
                Command.Parameters.Add(new MDB.MDBParameter("NgayThang2", ketQua.NgayThang2));
                Command.Parameters.Add(new MDB.MDBParameter("GioThucHien11", ketQua.GioThucHien11));
                Command.Parameters.Add(new MDB.MDBParameter("GioThucHien12", ketQua.GioThucHien12));
                Command.Parameters.Add(new MDB.MDBParameter("GioThucHien13", ketQua.GioThucHien13));
                Command.Parameters.Add(new MDB.MDBParameter("GioThucHien14", ketQua.GioThucHien14));
                Command.Parameters.Add(new MDB.MDBParameter("GioThucHien15", ketQua.GioThucHien15));
                Command.Parameters.Add(new MDB.MDBParameter("GioThucHien16", ketQua.GioThucHien16));
                Command.Parameters.Add(new MDB.MDBParameter("GioThucHien17", ketQua.GioThucHien17));
                Command.Parameters.Add(new MDB.MDBParameter("CapCuu81_1", ketQua.CapCuu81_1));
                Command.Parameters.Add(new MDB.MDBParameter("CapCuu81_2", ketQua.CapCuu81_2));
                Command.Parameters.Add(new MDB.MDBParameter("CapCuu81_3", ketQua.CapCuu81_3));
                Command.Parameters.Add(new MDB.MDBParameter("CapCuu81_4", ketQua.CapCuu81_4));
                Command.Parameters.Add(new MDB.MDBParameter("CapCuu81_5", ketQua.CapCuu81_5));
                Command.Parameters.Add(new MDB.MDBParameter("CapCuu81_6", ketQua.CapCuu81_6));
                Command.Parameters.Add(new MDB.MDBParameter("CapCuu81_7", ketQua.CapCuu81_7));
                Command.Parameters.Add(new MDB.MDBParameter("CapCuu821_1", ketQua.CapCuu821_1));
                Command.Parameters.Add(new MDB.MDBParameter("CapCuu821_2", ketQua.CapCuu821_2));
                Command.Parameters.Add(new MDB.MDBParameter("CapCuu821_3", ketQua.CapCuu821_3));
                Command.Parameters.Add(new MDB.MDBParameter("CapCuu821_4", ketQua.CapCuu821_4));
                Command.Parameters.Add(new MDB.MDBParameter("CapCuu821_5", ketQua.CapCuu821_5));
                Command.Parameters.Add(new MDB.MDBParameter("CapCuu821_6", ketQua.CapCuu821_6));
                Command.Parameters.Add(new MDB.MDBParameter("CapCuu821_7", ketQua.CapCuu821_7));
                Command.Parameters.Add(new MDB.MDBParameter("CapCuu822_1", ketQua.CapCuu822_1));
                Command.Parameters.Add(new MDB.MDBParameter("CapCuu822_2", ketQua.CapCuu822_2));
                Command.Parameters.Add(new MDB.MDBParameter("CapCuu822_3", ketQua.CapCuu822_3));
                Command.Parameters.Add(new MDB.MDBParameter("CapCuu822_4", ketQua.CapCuu822_4));
                Command.Parameters.Add(new MDB.MDBParameter("CapCuu822_5", ketQua.CapCuu822_5));
                Command.Parameters.Add(new MDB.MDBParameter("CapCuu822_6", ketQua.CapCuu822_6));
                Command.Parameters.Add(new MDB.MDBParameter("CapCuu822_7", ketQua.CapCuu822_7));
                Command.Parameters.Add(new MDB.MDBParameter("CapCuu823_1", ketQua.CapCuu823_1));
                Command.Parameters.Add(new MDB.MDBParameter("CapCuu823_2", ketQua.CapCuu823_2));
                Command.Parameters.Add(new MDB.MDBParameter("CapCuu823_3", ketQua.CapCuu823_3));
                Command.Parameters.Add(new MDB.MDBParameter("CapCuu823_4", ketQua.CapCuu823_4));
                Command.Parameters.Add(new MDB.MDBParameter("CapCuu823_5", ketQua.CapCuu823_5));
                Command.Parameters.Add(new MDB.MDBParameter("CapCuu823_6", ketQua.CapCuu823_6));
                Command.Parameters.Add(new MDB.MDBParameter("CapCuu823_7", ketQua.CapCuu823_7));
                Command.Parameters.Add(new MDB.MDBParameter("CapCuu824_1", ketQua.CapCuu824_1));
                Command.Parameters.Add(new MDB.MDBParameter("CapCuu824_2", ketQua.CapCuu824_2));
                Command.Parameters.Add(new MDB.MDBParameter("CapCuu824_3", ketQua.CapCuu824_3));
                Command.Parameters.Add(new MDB.MDBParameter("CapCuu824_4", ketQua.CapCuu824_4));
                Command.Parameters.Add(new MDB.MDBParameter("CapCuu824_5", ketQua.CapCuu824_5));
                Command.Parameters.Add(new MDB.MDBParameter("CapCuu824_6", ketQua.CapCuu824_6));
                Command.Parameters.Add(new MDB.MDBParameter("CapCuu824_7", ketQua.CapCuu824_7));
                Command.Parameters.Add(new MDB.MDBParameter("CapCuu825_1", ketQua.CapCuu825_1));
                Command.Parameters.Add(new MDB.MDBParameter("CapCuu825_2", ketQua.CapCuu825_2));
                Command.Parameters.Add(new MDB.MDBParameter("CapCuu825_3", ketQua.CapCuu825_3));
                Command.Parameters.Add(new MDB.MDBParameter("CapCuu825_4", ketQua.CapCuu825_4));
                Command.Parameters.Add(new MDB.MDBParameter("CapCuu825_5", ketQua.CapCuu825_5));
                Command.Parameters.Add(new MDB.MDBParameter("CapCuu825_6", ketQua.CapCuu825_6));
                Command.Parameters.Add(new MDB.MDBParameter("CapCuu825_7", ketQua.CapCuu825_7));
                Command.Parameters.Add(new MDB.MDBParameter("CapCuu83_1", ketQua.CapCuu83_1));
                Command.Parameters.Add(new MDB.MDBParameter("CapCuu83_2", ketQua.CapCuu83_2));
                Command.Parameters.Add(new MDB.MDBParameter("CapCuu83_3", ketQua.CapCuu83_3));
                Command.Parameters.Add(new MDB.MDBParameter("CapCuu83_4", ketQua.CapCuu83_4));
                Command.Parameters.Add(new MDB.MDBParameter("CapCuu83_5", ketQua.CapCuu83_5));
                Command.Parameters.Add(new MDB.MDBParameter("CapCuu83_6", ketQua.CapCuu83_6));
                Command.Parameters.Add(new MDB.MDBParameter("CapCuu83_7", ketQua.CapCuu83_7));
                Command.Parameters.Add(new MDB.MDBParameter("CapCuu84_1", ketQua.CapCuu84_1));
                Command.Parameters.Add(new MDB.MDBParameter("CapCuu84_2", ketQua.CapCuu84_2));
                Command.Parameters.Add(new MDB.MDBParameter("CapCuu84_3", ketQua.CapCuu84_3));
                Command.Parameters.Add(new MDB.MDBParameter("CapCuu84_4", ketQua.CapCuu84_4));
                Command.Parameters.Add(new MDB.MDBParameter("CapCuu84_5", ketQua.CapCuu84_5));
                Command.Parameters.Add(new MDB.MDBParameter("CapCuu84_6", ketQua.CapCuu84_6));
                Command.Parameters.Add(new MDB.MDBParameter("CapCuu84_7", ketQua.CapCuu84_7));
                Command.Parameters.Add(new MDB.MDBParameter("XuTriKhac_NoiDung_1", ketQua.XuTriKhac_NoiDung_1));
                Command.Parameters.Add(new MDB.MDBParameter("XuTriKhac_NoiDung_2", ketQua.XuTriKhac_NoiDung_2));
                Command.Parameters.Add(new MDB.MDBParameter("XuTriKhac_NoiDung_3", ketQua.XuTriKhac_NoiDung_3));
                Command.Parameters.Add(new MDB.MDBParameter("CapCuu851_1", ketQua.CapCuu851_1));
                Command.Parameters.Add(new MDB.MDBParameter("CapCuu851_2", ketQua.CapCuu851_2));
                Command.Parameters.Add(new MDB.MDBParameter("CapCuu851_3", ketQua.CapCuu851_3));
                Command.Parameters.Add(new MDB.MDBParameter("CapCuu851_4", ketQua.CapCuu851_4));
                Command.Parameters.Add(new MDB.MDBParameter("CapCuu851_5", ketQua.CapCuu851_5));
                Command.Parameters.Add(new MDB.MDBParameter("CapCuu851_6", ketQua.CapCuu851_6));
                Command.Parameters.Add(new MDB.MDBParameter("CapCuu851_7", ketQua.CapCuu851_7));
                Command.Parameters.Add(new MDB.MDBParameter("CapCuu852_1", ketQua.CapCuu852_1));
                Command.Parameters.Add(new MDB.MDBParameter("CapCuu852_2", ketQua.CapCuu852_2));
                Command.Parameters.Add(new MDB.MDBParameter("CapCuu852_3", ketQua.CapCuu852_3));
                Command.Parameters.Add(new MDB.MDBParameter("CapCuu852_4", ketQua.CapCuu852_4));
                Command.Parameters.Add(new MDB.MDBParameter("CapCuu852_5", ketQua.CapCuu852_5));
                Command.Parameters.Add(new MDB.MDBParameter("CapCuu852_6", ketQua.CapCuu852_6));
                Command.Parameters.Add(new MDB.MDBParameter("CapCuu852_7", ketQua.CapCuu852_7));
                Command.Parameters.Add(new MDB.MDBParameter("CapCuu853_1", ketQua.CapCuu853_1));
                Command.Parameters.Add(new MDB.MDBParameter("CapCuu853_2", ketQua.CapCuu853_2));
                Command.Parameters.Add(new MDB.MDBParameter("CapCuu853_3", ketQua.CapCuu853_3));
                Command.Parameters.Add(new MDB.MDBParameter("CapCuu853_4", ketQua.CapCuu853_4));
                Command.Parameters.Add(new MDB.MDBParameter("CapCuu853_5", ketQua.CapCuu853_5));
                Command.Parameters.Add(new MDB.MDBParameter("CapCuu853_6", ketQua.CapCuu853_6));
                Command.Parameters.Add(new MDB.MDBParameter("CapCuu853_7", ketQua.CapCuu853_7));
                Command.Parameters.Add(new MDB.MDBParameter("ChamSocHoTro91", ketQua.ChamSocHoTro91));
                Command.Parameters.Add(new MDB.MDBParameter("ChamSocHoTro92", ketQua.ChamSocHoTro92));
                Command.Parameters.Add(new MDB.MDBParameter("ChamSocHoTro93", ketQua.ChamSocHoTro93));
                Command.Parameters.Add(new MDB.MDBParameter("ChamSocHoTro94", ketQua.ChamSocHoTro94));
                Command.Parameters.Add(new MDB.MDBParameter("ChamSocHoTro95", ketQua.ChamSocHoTro95));
                Command.Parameters.Add(new MDB.MDBParameter("ChamSocHoTro96", ketQua.ChamSocHoTro96));
                Command.Parameters.Add(new MDB.MDBParameter("HoTroKhac", ketQua.HoTroKhac));
                Command.Parameters.Add(new MDB.MDBParameter("ChamSocHoTro97_1", ketQua.ChamSocHoTro97_1));
                Command.Parameters.Add(new MDB.MDBParameter("ChamSocHoTro97_2", ketQua.ChamSocHoTro97_2));
                Command.Parameters.Add(new MDB.MDBParameter("ChamSocHoTro97_3", ketQua.ChamSocHoTro97_3));
                Command.Parameters.Add(new MDB.MDBParameter("ChamSocHoTro97_4", ketQua.ChamSocHoTro97_4));
                Command.Parameters.Add(new MDB.MDBParameter("ChamSocHoTro97_5", ketQua.ChamSocHoTro97_5));
                Command.Parameters.Add(new MDB.MDBParameter("ChamSocHoTro97_6", ketQua.ChamSocHoTro97_6));
                Command.Parameters.Add(new MDB.MDBParameter("ChamSocHoTro97_7", ketQua.ChamSocHoTro97_7));
                Command.Parameters.Add(new MDB.MDBParameter("CanThiepKhac_1", ketQua.CanThiepKhac_1));
                Command.Parameters.Add(new MDB.MDBParameter("CanThiepKhac_2", ketQua.CanThiepKhac_2));
                Command.Parameters.Add(new MDB.MDBParameter("CanThiepKhac_3", ketQua.CanThiepKhac_3));
                Command.Parameters.Add(new MDB.MDBParameter("CanThiepKhac_4", ketQua.CanThiepKhac_4));
                Command.Parameters.Add(new MDB.MDBParameter("CanThiepKhac_5", ketQua.CanThiepKhac_5));
                Command.Parameters.Add(new MDB.MDBParameter("CanThiepKhac_6", ketQua.CanThiepKhac_6));
                Command.Parameters.Add(new MDB.MDBParameter("CanThiepKhac_7", ketQua.CanThiepKhac_7));
                Command.Parameters.Add(new MDB.MDBParameter("DieuDuong2_1", ketQua.DieuDuong2_1));
                Command.Parameters.Add(new MDB.MDBParameter("DieuDuong2_2", ketQua.DieuDuong2_2));
                Command.Parameters.Add(new MDB.MDBParameter("DieuDuong2_3", ketQua.DieuDuong2_3));
                Command.Parameters.Add(new MDB.MDBParameter("DieuDuong2_4", ketQua.DieuDuong2_4));
                Command.Parameters.Add(new MDB.MDBParameter("DieuDuong2_5", ketQua.DieuDuong2_5));
                Command.Parameters.Add(new MDB.MDBParameter("DieuDuong2_6", ketQua.DieuDuong2_6));
                Command.Parameters.Add(new MDB.MDBParameter("DieuDuong2_7", ketQua.DieuDuong2_7));
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
                string sql = "DELETE FROM KHCSNguoiBenhCovid19_2 WHERE ID = :ID";
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
                P.*,
                H.TenBenhNhan,
                H.Tuoi,
                H.GioiTinh,
                H.SOYTE,
                H.BENHVIEN,
                T.KHOA,
                T.SoNhapVien,
                T.Giuong,
                cc.hovaten DieuDuong1_1_HoTen,
                dd.hovaten DieuDuong1_2_HoTen,
                ee.hovaten DieuDuong1_3_HoTen,
                ff.hovaten DieuDuong1_4_HoTen,
                gg.hovaten DieuDuong1_5_HoTen,
                kk.hovaten DieuDuong1_6_HoTen,
                ii.hovaten DieuDuong1_7_HoTen,
                ccc.hovaten DieuDuong2_1_HoTen,
                ddd.hovaten DieuDuong2_2_HoTen,
                eee.hovaten DieuDuong2_3_HoTen,
                fff.hovaten DieuDuong2_4_HoTen,
                ggg.hovaten DieuDuong2_5_HoTen,
                kkk.hovaten DieuDuong2_6_HoTen,
                iii.hovaten DieuDuong2_7_HoTen
            FROM
                KHCSNguoiBenhCovid19_2 P
                LEFT JOIN HANHCHINHBENHNHAN H ON P.MABENHNHAN = H.MABENHNHAN
                LEFT JOIN THONGTINDIEUTRI T ON P.MAQUANLY = T.MAQUANLY
                left join nhanvien cc on P.DieuDuong1_1 = cc.manhanvien
                left join nhanvien dd on P.DieuDuong1_2 = dd.manhanvien
                left join nhanvien ee on P.DieuDuong1_3 = ee.manhanvien
                left join nhanvien ff on P.DieuDuong1_4 = ff.manhanvien
                left join nhanvien gg on P.DieuDuong1_5 = gg.manhanvien
                left join nhanvien kk on P.DieuDuong1_6 = kk.manhanvien
                left join nhanvien ii on P.DieuDuong1_7 = ii.manhanvien
                left join nhanvien ccc on P.DieuDuong2_1 = ccc.manhanvien
                left join nhanvien ddd on P.DieuDuong2_2 = ddd.manhanvien
                left join nhanvien eee on P.DieuDuong2_3 = eee.manhanvien
                left join nhanvien fff on P.DieuDuong2_4 = fff.manhanvien
                left join nhanvien ggg on P.DieuDuong2_5 = ggg.manhanvien
                left join nhanvien kkk on P.DieuDuong2_6 = kkk.manhanvien
                left join nhanvien iii on P.DieuDuong2_7 = iii.manhanvien
            WHERE
                P.ID = " + id;

            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
            MDB.MDBDataAdapter adt = new MDB.MDBDataAdapter(Command);
            var ds = new DataSet();

            adt.Fill(ds, "KQ");

            return ds;
        }
    }
}
