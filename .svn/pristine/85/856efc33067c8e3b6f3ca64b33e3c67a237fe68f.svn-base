using EMR.KyDienTu;
using PMS.Access;
using System;
using System.Collections.Generic;
using System.Data;

namespace EMR_MAIN.DATABASE.Other
{
    public class PhieuChuanBiBanGiaoNguoiBenhTruocPTTT : ThongTinKy
    {
        public PhieuChuanBiBanGiaoNguoiBenhTruocPTTT()
        {
            TableName = "PhieuCBBGNBTruocPTTT";
            TablePrimaryKeyName = "ID";
            IDMauPhieu = (int)DanhMucPhieu.CBBGNBTPTTT;
            TenMauPhieu = DanhMucPhieu.CBBGNBTPTTT.Description();
        }
        [MoTaDuLieu("Bệnh viện")]
        public string BenhVien
        {
            get
            {
                return XemBenhAn._HanhChinhBenhNhan.BenhVien;
            }
        }
        [MoTaDuLieu("Khoa")]
        public string Khoa
        {
            get
            {
                return XemBenhAn._ThongTinDieuTri.Khoa;
            }
        }
        [MoTaDuLieu("Họ và tên bệnh nhân")]
		public string TenBenhNhan
        {
            get
            {
                return XemBenhAn._HanhChinhBenhNhan.TenBenhNhan;
            }
        }
        [MoTaDuLieu("Mã bệnh nhân")]
		public string MaBenhNhan
        {
            get
            {
                return XemBenhAn._HanhChinhBenhNhan.MaBenhNhan;
            }
        }
        [MoTaDuLieu("Tuổi bệnh nhân")]
		public string Tuoi
        {
            get
            {
                return XemBenhAn._HanhChinhBenhNhan.Tuoi;
            }
        }
        [MoTaDuLieu("Giới tính bệnh nhân")]
		public string GioiTinh
        {
            get
            {
                return XemBenhAn._HanhChinhBenhNhan.GioiTinh.Description();
            }
        }
        [MoTaDuLieu("Chẩn đoán bệnh")]
		public string ChanDoan
        {
            get
            {
                return XemBenhAn._ThongTinDieuTri.ChanDoanTruocPhauThuat;
            }
        }

        [MoTaDuLieu("Mã định danh")]
		public long ID { get; set; }
        [MoTaDuLieu("Mã quản lý: mã duy nhất trong 1 đợt khám chữa bệnh (kcb), không trùng giữa các đợt kcb khác nhau","",1)]
		public decimal MaQuanLy { get; set; }
        [MoTaDuLieu("Phẩu thuật - Thủ thuật cấp cứu")]
        public int PhauThuatThuThuat { get; set; }
        [MoTaDuLieu("Thời gian")]
        public DateTime ThoiGian { get; set; }
        [MoTaDuLieu("Tiền sử dị ứng")]
        public int TienSuDiUng { get; set; }
        [MoTaDuLieu("Mạch")]
		public string Mach { get; set; }
        [MoTaDuLieu("Huyết áp")]
		public string HuyetAp { get; set; }
        [MoTaDuLieu("Nhiệt độ")]
		public string NhietDo { get; set; }
        [MoTaDuLieu("Nhịp thở")]
		public string NhipTho { get; set; }
        [MoTaDuLieu("Cân nặng")]
		public string CanNang { get; set; }
        [MoTaDuLieu("Chiều cao")]
		public string ChieuCao { get; set; }
        [MoTaDuLieu("Chỉ số BMI")]
        public string ChiSoBMI { get; set; }
        public bool[] TinhTiepXucArray { get; } = new bool[] { false, false, false, false };
        [MoTaDuLieu("Tính tiếp xúc tốt")]
        public string TinhTiepXuc
        {
            get
            {
                string temp = "";
                for (int i = 0; i < TinhTiepXucArray.Length; i++)
                    temp += (TinhTiepXucArray[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        TinhTiepXucArray[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public bool[] LoaiBoLongTocArray { get; } = new bool[] { false, false, false, false };
        [MoTaDuLieu("Loại bỏ lông, tóc, móng vùng phẫu thuật/thủ thuật")]
        public string LoaiBoLongToc
        {
            get
            {
                string temp = "";
                for (int i = 0; i < LoaiBoLongTocArray.Length; i++)
                    temp += (LoaiBoLongTocArray[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        LoaiBoLongTocArray[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public bool[] LamSachVungPTTTArray { get; } = new bool[] { false, false, false, false };
        [MoTaDuLieu("Làm sạch vùng phẫu thuật/thủ thuật")]
        public string LamSachVungPTTT
        {
            get
            {
                string temp = "";
                for (int i = 0; i < LamSachVungPTTTArray.Length; i++)
                    temp += (LamSachVungPTTTArray[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        LamSachVungPTTTArray[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }

        public bool[] DanhDauVungPTTTArray { get; } = new bool[] { false, false, false, false };
        [MoTaDuLieu("Đánh dấu vùng phẫu thuật/thủ thuật")]
        public string DanhDauVungPTTT
        {
            get
            {
                string temp = "";
                for (int i = 0; i < DanhDauVungPTTTArray.Length; i++)
                    temp += (DanhDauVungPTTTArray[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        DanhDauVungPTTTArray[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public bool[] NhinAnArray { get; } = new bool[] { false, false, false, false };
        [MoTaDuLieu("Nhịn ăn")]
        public string NhinAn
        {
            get
            {
                string temp = "";
                for (int i = 0; i < NhinAnArray.Length; i++)
                    temp += (NhinAnArray[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        NhinAnArray[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        [MoTaDuLieu("Thời gian người bệnh ngừng ăn uống")]
        public DateTime? NBNgungAn_Date { get; set; }
        public bool[] NBNgungAnArray { get; } = new bool[] { false, false, false, false };
        [MoTaDuLieu("Người bệnh ngừng ăn")]
        public string NBNgungAn
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < NBNgungAnArray.Length; i++)
                    temp += (NBNgungAnArray[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        NBNgungAnArray[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public bool[] CoRangGiaArray { get; } = new bool[] { false, false, false, false };
        [MoTaDuLieu("Có răng giả")]
        public string CoRangGia
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < CoRangGiaArray.Length; i++)
                    temp += (CoRangGiaArray[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        CoRangGiaArray[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }

        public bool[] CoKinhApTrongArray { get; } = new bool[] { false, false, false, false };
        [MoTaDuLieu("Có kính áp tròng")]
        public string CoKinhApTrong
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < CoKinhApTrongArray.Length; i++)
                    temp += (CoKinhApTrongArray[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        CoKinhApTrongArray[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }

        public bool[] ThePTTTArray { get; } = new bool[] { false, false, false, false };
        [MoTaDuLieu("Thẻ phẫu thuật/thủ thuật")]
        public string ThePTTT
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < ThePTTTArray.Length; i++)
                    temp += (ThePTTTArray[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        ThePTTTArray[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }

        public bool[] PhieuKhamBenhArray { get; } = new bool[] { false, false, false, false };
        [MoTaDuLieu("Phiếu khám bệnh")]
        public string PhieuKhamBenh
        {
            get
            {
                string temp = "";
                for (int i = 0; i < PhieuKhamBenhArray.Length; i++)
                    temp += (PhieuKhamBenhArray[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        PhieuKhamBenhArray[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public bool[] PhieuChiDinhPTTTArray { get; } = new bool[] { false, false, false, false };
        [MoTaDuLieu("Phiếu chỉ định phẫu thuật/thủ thuật")]
        public string PhieuChiDinhPTTT
        {
            get
            {
                string temp = "";
                for (int i = 0; i < PhieuChiDinhPTTTArray.Length; i++)
                    temp += (PhieuChiDinhPTTTArray[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        PhieuChiDinhPTTTArray[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public bool[] PhieuHoiChanPTTTArray { get; } = new bool[] { false, false, false, false };
        [MoTaDuLieu("Phiếu hội chẩn phẫu thuật/thủ thuật")]
        public string PhieuHoiChanPTTT
        {
            get
            {
                string temp = "";
                for (int i = 0; i < PhieuHoiChanPTTTArray.Length; i++)
                    temp += (PhieuHoiChanPTTTArray[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        PhieuHoiChanPTTTArray[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }

        public bool[] GiayCamDoanPTTTArray { get; } = new bool[] { false, false, false, false };
        [MoTaDuLieu("Giấy cam đoan chấp nhận phẫu thuật/thủ thuật")]
        public string GiayCamDoanPTTT
        {
            get
            {
                string temp = "";
                for (int i = 0; i < GiayCamDoanPTTTArray.Length; i++)
                    temp += (GiayCamDoanPTTTArray[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        GiayCamDoanPTTTArray[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }

        public bool[] PhieuChuanBiPTTTArray { get; } = new bool[] { false, false, false, false };
        [MoTaDuLieu("Phiếu chuẩn bị phẫu thuật/thủ thuật")]
        public string PhieuChuanBiPTTT
        {
            get
            {
                string temp = "";
                for (int i = 0; i < PhieuChuanBiPTTTArray.Length; i++)
                    temp += (PhieuChuanBiPTTTArray[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        PhieuChuanBiPTTTArray[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }

        public bool[] PhieuKhamGayMeHoiSucArray { get; } = new bool[] { false, false, false, false };
        [MoTaDuLieu("Phiếu chuẩn bị phẫu thuật/thủ thuật")]
        public string PhieuKhamGayMeHoiSuc
        {
            get
            {
                string temp = "";
                for (int i = 0; i < PhieuKhamGayMeHoiSucArray.Length; i++)
                    temp += (PhieuKhamGayMeHoiSucArray[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        PhieuKhamGayMeHoiSucArray[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }

        public bool[] XNCBArray { get; } = new bool[] { false, false, false, false, false, false};
        [MoTaDuLieu("Xét nghiệm cơ bản")]
        public string XNCB
        {
            get
            {
                string temp = "";
                for (int i = 0; i < XNCBArray.Length; i++)
                    temp += (XNCBArray[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        XNCBArray[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }

        public bool[] NhomMauArray { get; } = new bool[] { false, false, false, false };
        [MoTaDuLieu("Nhóm máu")]
		public string NhomMau {
            get
            {
                string temp = "";
                for (int i = 0; i < NhomMauArray.Length; i++)
                    temp += (NhomMauArray[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        NhomMauArray[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public bool[] DienTimArray { get; } = new bool[] { false, false, false, false };
        [MoTaDuLieu("Điện tim")]
        public string DienTim
        {
            get
            {
                string temp = "";
                for (int i = 0; i < DienTimArray.Length; i++)
                    temp += (DienTimArray[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        DienTimArray[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public bool[] SieuAmTimArray { get; } = new bool[] { false, false, false, false };
        [MoTaDuLieu("Siêu âm tim")]
        public string SieuAmTim
        {
            get
            {
                string temp = "";
                for (int i = 0; i < SieuAmTimArray.Length; i++)
                    temp += (SieuAmTimArray[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        SieuAmTimArray[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }

        public bool[] GiaiPhauBenhArray { get; } = new bool[] { false, false, false, false };
        [MoTaDuLieu("Giải phẫu bệnh")]
        public string GiaiPhauBenh
        {
            get
            {
                string temp = "";
                for (int i = 0; i < GiaiPhauBenhArray.Length; i++)
                    temp += (GiaiPhauBenhArray[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        GiaiPhauBenhArray[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }

        public bool[] XQuangTimPhoiArray { get; } = new bool[] { false, false, false, false };
        [MoTaDuLieu("X-quang tim, phổi")]
        public string XQuangTimPhoi
        {
            get
            {
                string temp = "";
                for (int i = 0; i < XQuangTimPhoiArray.Length; i++)
                    temp += (XQuangTimPhoiArray[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        XQuangTimPhoiArray[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public bool[] KhacArray { get; } = new bool[] { false, false, false, false };
        [MoTaDuLieu("Khác")]
        public string Khac
        {
            get
            {
                string temp = "";
                for (int i = 0; i < KhacArray.Length; i++)
                    temp += (KhacArray[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        KhacArray[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        [MoTaDuLieu("Số lượng Khác")]
        public string KhacSoLuong { get; set; }
        [MoTaDuLieu("Họ tên người chuẩn bị")]
        public string NguoiChuanBi { get; set; }
        [MoTaDuLieu("Mã người chuẩn bị")]
        public string MaNguoiChuanBi { get; set; }
        [MoTaDuLieu("Họ tên người bàn giao")]
        public string NguoiBanGiao { get; set; }
        [MoTaDuLieu("Mã người bàn giao")]
        public string MaNguoiBanGiao { get; set; }
        [MoTaDuLieu("Họ tên người nhận bàn giao")]
        public string NguoiNhanBanGiao { get; set; }
        [MoTaDuLieu("Mã người nhận bàn giao")]
        public string MaNguoiNhanBanGiao { get; set; }
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
    public class PhieuChuanBiBanGiaoNguoiBenhTruocPTTTFunc
    {
        public const string TableName = "PhieuCBBGNBTruocPTTT";
        public const string TablePrimaryKeyName = "ID";
        public static List<PhieuChuanBiBanGiaoNguoiBenhTruocPTTT> GetListData(MDB.MDBConnection _OracleConnection, decimal maquanly)
        {
            List<PhieuChuanBiBanGiaoNguoiBenhTruocPTTT> list = new List<PhieuChuanBiBanGiaoNguoiBenhTruocPTTT>();
            try
            {
                string sql = @"SELECT * FROM PhieuCBBGNBTruocPTTT where MaQuanLy = :MaQuanLy";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, _OracleConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", maquanly));
                MDB.MDBDataReader DataReader = Command.ExecuteReader();
                while (DataReader.Read())
                {
                    PhieuChuanBiBanGiaoNguoiBenhTruocPTTT data = new PhieuChuanBiBanGiaoNguoiBenhTruocPTTT();
                    data.ID = Convert.ToInt64(DataReader.GetLong("ID").ToString());
                    data.MaQuanLy = maquanly;
                    data.PhauThuatThuThuat = DataReader.GetInt("PhauThuatThuThuat");
                    data.ThoiGian = Convert.ToDateTime(DataReader["ThoiGian"] == DBNull.Value ? DateTime.Now : DataReader["ThoiGian"]);
                    data.TienSuDiUng = DataReader.GetInt("TienSuDiUng");
                    data.Mach = DataReader["Mach"].ToString();
                    data.HuyetAp = DataReader["HuyetAp"].ToString();
                    data.NhietDo = DataReader["NhietDo"].ToString();
                    data.NhipTho = DataReader["NhipTho"].ToString();
                    data.CanNang = DataReader["CanNang"].ToString();
                    data.ChieuCao = DataReader["ChieuCao"].ToString();
                    data.ChiSoBMI = DataReader["BMI"].ToString();
                    data.TinhTiepXuc = DataReader["TinhTiepXuc"].ToString();
                    data.LoaiBoLongToc = DataReader["LoaiBoLongToc"].ToString();
                    data.LamSachVungPTTT = DataReader["LamSachVungPTTT"].ToString();
                    data.DanhDauVungPTTT = DataReader["DanhDauVungPTTT"].ToString();
                    data.CoRangGia = DataReader["CoRangGia"].ToString();
                    data.CoKinhApTrong = DataReader["KinhApTrong"].ToString();
                    data.NhinAn = DataReader["NhinAn"].ToString();
                    data.NBNgungAn_Date = Convert.ToDateTime(DataReader["NBNgungAn_Date"] == DBNull.Value ? DateTime.Now : DataReader["NBNgungAn_Date"]);
                    data.NBNgungAn = DataReader["NBNgungAn"].ToString();
                    data.ThePTTT = DataReader["ThePTTT"].ToString();
                    data.PhieuKhamBenh = DataReader["PhieuKhamBenh"].ToString();
                    data.PhieuChiDinhPTTT = DataReader["PhieuChiDinhPTTT"].ToString();
                    data.PhieuHoiChanPTTT = DataReader["PhieuHoiChanPTTT"].ToString();
                    data.GiayCamDoanPTTT = DataReader["GiayCamDoanPTTT"].ToString();
                    data.PhieuChuanBiPTTT = DataReader["PhieuChuanBiPTTT"].ToString();
                    data.PhieuKhamGayMeHoiSuc = DataReader["PhieuKhamGayMeHoiSuc"].ToString();
                    data.XNCB = DataReader["XNCB"].ToString();
                    data.NhomMau = DataReader["NhomMau"].ToString();
                    data.DienTim = DataReader["DienTim"].ToString();
                    data.SieuAmTim = DataReader["SieuAmTim"].ToString();
                    data.XQuangTimPhoi = DataReader["XQTimPhoi"].ToString();
                    data.Khac = DataReader["Khac"].ToString();
                    data.KhacSoLuong = DataReader["KhacSoLuong"].ToString();
                    data.NguoiChuanBi = DataReader["NguoiChuanBi"].ToString();
                    data.MaNguoiChuanBi = DataReader["MaNguoiChuanBi"].ToString();
                    data.NguoiBanGiao = DataReader["NguoiBanGiao"].ToString();
                    data.MaNguoiBanGiao = DataReader["MaNguoiBanGiao"].ToString();
                    data.NguoiNhanBanGiao = DataReader["NguoiNhanBanGiao"].ToString();
                    data.MaNguoiNhanBanGiao = DataReader["MaNguoiNhanBanGiao"].ToString();

                    data.NguoiTao = DataReader["NguoiTao"].ToString();
                    data.NguoiSua = DataReader["NguoiSua"].ToString();
                    data.NgayTao = Convert.ToDateTime(DataReader["NgayTao"] == DBNull.Value ? DateTime.Now : DataReader["NgayTao"]);
                    data.NgaySua = Convert.ToDateTime(DataReader["NgaySua"] == DBNull.Value ? DateTime.Now : DataReader["NgaySua"]);

                    data.MaSoKy = DataReader["masokyten"].ToString();
                    data.DaKy = !string.IsNullOrEmpty(data.MaSoKy) ? true : false;
                    list.Add(data);
                }
            }
            catch (Exception ex) { XuLyLoi.Handle(ex); }
            return list;
        }
        public static bool InsertOrUpdate(MDB.MDBConnection MyConnection, ref PhieuChuanBiBanGiaoNguoiBenhTruocPTTT data)
        {
            try
            {
                string sql = @"INSERT INTO PhieuCBBGNBTruocPTTT
                (
                    MaQuanLy,
                    PhauThuatThuThuat,
                    ThoiGian,
                    TienSuDiUng,
                    Mach,
                    HuyetAp,
                    NhietDo,
                    NhipTho,
                    CanNang,
                    ChieuCao,
                    BMI,
                    TinhTiepXuc,
                    LoaiBoLongToc,
                    LamSachVungPTTT,
                    DanhDauVungPTTT,
                    CoRangGia,
                    KinhApTrong,
                    NhinAn,
                    NBNgungAn_Date,
                    NBNgungAn,
                    ThePTTT,
                    PhieuKhamBenh,
                    PhieuChiDinhPTTT,
                    PhieuHoiChanPTTT,
                    GiayCamDoanPTTT,
                    PhieuChuanBiPTTT,
                    PhieuKhamGayMeHoiSuc,
                    XNCB,
                    NhomMau,
                    DienTim,
                    SieuAmTim,
                    GiaiPhauBenh,
                    XQTimPhoi,
                    Khac,
                    KhacSoLuong,
                    NguoiChuanBi,
                    MaNguoiChuanBi,
                    NguoiBanGiao,
                    MaNguoiBanGiao,
                    NguoiNhanBanGiao,
                    MaNguoiNhanBanGiao,
                    NGUOITAO,
                    NGUOISUA,
                    NGAYTAO,
                    NGAYSUA)  VALUES
                 (
				    :MaQuanLy,
                    :PhauThuatThuThuat,
                    :ThoiGian,
                    :TienSuDiUng,
                    :Mach,
                    :HuyetAp,
                    :NhietDo,
                    :NhipTho,
                    :CanNang,
                    :ChieuCao,
                    :BMI,
                    :TinhTiepXuc,
                    :LoaiBoLongToc,
                    :LamSachVungPTTT,
                    :DanhDauVungPTTT,
                    :CoRangGia,
                    :KinhApTrong,
                    :NhinAn,
                    :NBNgungAn_Date,
                    :NBNgungAn,
                    :ThePTTT,
                    :PhieuKhamBenh,
                    :PhieuChiDinhPTTT,
                    :PhieuHoiChanPTTT,
                    :GiayCamDoanPTTT,
                    :PhieuChuanBiPTTT,
                    :PhieuKhamGayMeHoiSuc,
                    :XNCB,
                    :NhomMau,
                    :DienTim,
                    :SieuAmTim,
                    :GiaiPhauBenh,
                    :XQTimPhoi,
                    :Khac,
                    :KhacSoLuong,
                    :NguoiChuanBi,
                    :MaNguoiChuanBi,
                    :NguoiBanGiao,
                    :MaNguoiBanGiao,
                    :NguoiNhanBanGiao,
                    :MaNguoiNhanBanGiao,
                    :NGUOITAO,
                    :NGUOISUA,
                    :NGAYTAO,
                    :NGAYSUA
                 )  RETURNING ID INTO :ID";
                if (data.ID != 0)
                {
                    sql = @"UPDATE PhieuCBBGNBTruocPTTT SET 
                    MaQuanLy=:MaQuanLy,
                    PhauThuatThuThuat=:PhauThuatThuThuat,
                    ThoiGian=:ThoiGian,
                    TienSuDiUng=:TienSuDiUng,
                    Mach=:Mach,
                    HuyetAp=:HuyetAp,
                    NhietDo=:NhietDo,
                    NhipTho=:NhipTho,
                    CanNang=:CanNang,
                    ChieuCao=:ChieuCao,
                    BMI=:BMI,
                    TinhTiepXuc=:TinhTiepXuc,
                    LoaiBoLongToc=:LoaiBoLongToc,
                    LamSachVungPTTT=:LamSachVungPTTT,
                    DanhDauVungPTTT=:DanhDauVungPTTT,
                    CoRangGia=:CoRangGia,
                    KinhApTrong=:KinhApTrong,
                    NhinAn=:NhinAn,
                    NBNgungAn_Date=:NBNgungAn_Date,
                    NBNgungAn=:NBNgungAn,
                    ThePTTT=:ThePTTT,
                    PhieuKhamBenh=:PhieuKhamBenh,
                    PhieuChiDinhPTTT=:PhieuChiDinhPTTT,
                    PhieuHoiChanPTTT=:PhieuHoiChanPTTT,
                    GiayCamDoanPTTT=:GiayCamDoanPTTT,
                    PhieuChuanBiPTTT=:PhieuChuanBiPTTT,
                    PhieuKhamGayMeHoiSuc=:PhieuKhamGayMeHoiSuc,
                    XNCB=:XNCB,
                    NhomMau=:NhomMau,
                    DienTim=:DienTim,
                    SieuAmTim=:SieuAmTim,
                    GiaiPhauBenh=:GiaiPhauBenh,
                    XQTimPhoi=:XQTimPhoi,
                    Khac=:Khac,
                    KhacSoLuong=:KhacSoLuong,
                    NguoiChuanBi=:NguoiChuanBi,
                    MaNguoiChuanBi=:MaNguoiChuanBi,
                    NguoiBanGiao=:NguoiBanGiao,
                    MaNguoiBanGiao=:MaNguoiBanGiao,
                    NguoiNhanBanGiao=:NguoiNhanBanGiao,
                    MaNguoiNhanBanGiao=:MaNguoiNhanBanGiao,
                    NGUOITAO=:NGUOITAO,
                    NGUOISUA=:NGUOISUA,
                    NGAYTAO=:NGAYTAO,
                    NGAYSUA=:NGAYSUA 
                    WHERE ID = " + data.ID;
                }

                MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", data.MaQuanLy));
                Command.Parameters.Add(new MDB.MDBParameter("PhauThuatThuThuat", data.PhauThuatThuThuat));
                Command.Parameters.Add(new MDB.MDBParameter("ThoiGian", data.ThoiGian));
                Command.Parameters.Add(new MDB.MDBParameter("TienSuDiUng", data.TienSuDiUng));
                Command.Parameters.Add(new MDB.MDBParameter("Mach", data.Mach));
                Command.Parameters.Add(new MDB.MDBParameter("HuyetAp", data.HuyetAp));
                Command.Parameters.Add(new MDB.MDBParameter("NhietDo", data.NhietDo));
                Command.Parameters.Add(new MDB.MDBParameter("NhipTho", data.NhipTho));
                Command.Parameters.Add(new MDB.MDBParameter("CanNang", data.CanNang));
                Command.Parameters.Add(new MDB.MDBParameter("ChieuCao", data.ChieuCao));
                Command.Parameters.Add(new MDB.MDBParameter("BMI", data.ChiSoBMI));
                Command.Parameters.Add(new MDB.MDBParameter("TinhTiepXuc", data.TinhTiepXuc));
                Command.Parameters.Add(new MDB.MDBParameter("LoaiBoLongToc", data.LoaiBoLongToc));
                Command.Parameters.Add(new MDB.MDBParameter("LamSachVungPTTT", data.LamSachVungPTTT));
                Command.Parameters.Add(new MDB.MDBParameter("DanhDauVungPTTT", data.DanhDauVungPTTT));
                Command.Parameters.Add(new MDB.MDBParameter("CoRangGia", data.CoRangGia));
                Command.Parameters.Add(new MDB.MDBParameter("KinhApTrong", data.CoKinhApTrong));
                Command.Parameters.Add(new MDB.MDBParameter("NhinAn", data.NhinAn));
                Command.Parameters.Add(new MDB.MDBParameter("NBNgungAn_Date", data.NBNgungAn_Date));
                Command.Parameters.Add(new MDB.MDBParameter("NBNgungAn", data.NBNgungAn));
                Command.Parameters.Add(new MDB.MDBParameter("ThePTTT", data.ThePTTT));
                Command.Parameters.Add(new MDB.MDBParameter("PhieuKhamBenh", data.PhieuKhamBenh));
                Command.Parameters.Add(new MDB.MDBParameter("PhieuChiDinhPTTT", data.PhieuChiDinhPTTT));
                Command.Parameters.Add(new MDB.MDBParameter("PhieuHoiChanPTTT", data.PhieuHoiChanPTTT));
                Command.Parameters.Add(new MDB.MDBParameter("GiayCamDoanPTTT", data.GiayCamDoanPTTT));
                Command.Parameters.Add(new MDB.MDBParameter("PhieuChuanBiPTTT", data.PhieuChuanBiPTTT));
                Command.Parameters.Add(new MDB.MDBParameter("PhieuKhamGayMeHoiSuc", data.PhieuKhamGayMeHoiSuc));
                Command.Parameters.Add(new MDB.MDBParameter("XNCB", data.XNCB));
                Command.Parameters.Add(new MDB.MDBParameter("NhomMau", data.NhomMau));
                Command.Parameters.Add(new MDB.MDBParameter("DienTim", data.DienTim));
                Command.Parameters.Add(new MDB.MDBParameter("SieuAmTim", data.SieuAmTim));
                Command.Parameters.Add(new MDB.MDBParameter("GiaiPhauBenh", data.GiaiPhauBenh));
                Command.Parameters.Add(new MDB.MDBParameter("XQTimPhoi", data.XQuangTimPhoi));
                Command.Parameters.Add(new MDB.MDBParameter("Khac", data.Khac));
                Command.Parameters.Add(new MDB.MDBParameter("KhacSoLuong", data.KhacSoLuong));
                Command.Parameters.Add(new MDB.MDBParameter("NguoiChuanBi", data.NguoiChuanBi));
                Command.Parameters.Add(new MDB.MDBParameter("MaNguoiChuanBi", data.MaNguoiChuanBi));
                Command.Parameters.Add(new MDB.MDBParameter("NguoiBanGiao", data.NguoiBanGiao));
                Command.Parameters.Add(new MDB.MDBParameter("MaNguoiBanGiao", data.MaNguoiBanGiao));
                Command.Parameters.Add(new MDB.MDBParameter("NguoiNhanBanGiao", data.NguoiNhanBanGiao));
                Command.Parameters.Add(new MDB.MDBParameter("MaNguoiNhanBanGiao", data.MaNguoiNhanBanGiao));

                Command.Parameters.Add(new MDB.MDBParameter("NGUOISUA", data.NguoiSua));
                Command.Parameters.Add(new MDB.MDBParameter("NGAYSUA", data.NgaySua));
                if (data.ID == 0)
                {
                    Command.Parameters.Add(new MDB.MDBParameter("ID", data.ID));
                    Command.Parameters.Add(new MDB.MDBParameter("NGUOITAO", data.NguoiTao));
                    Command.Parameters.Add(new MDB.MDBParameter("NGAYTAO", data.NgayTao));
                }
                Command.BindByName = true;
                int n = Command.ExecuteNonQuery();
                if (data.ID == 0)
                {
                    long nextval = Convert.ToInt64((Command.Parameters["ID"] as MDB.MDBParameter).Value);
                    data.ID = nextval;
                }
                return n > 0;
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
                string sql = "DELETE FROM PhieuCBBGNBTruocPTTT WHERE ID = :ID";
                MDB.MDBCommand command = new MDB.MDBCommand(sql, MyConnection);
                command.Parameters.Add(new MDB.MDBParameter("ID", id));
                command.BindByName = true;
                return command.ExecuteNonQuery() > 0;
            }
            catch (Exception ex)
            {
                XuLyLoi.Handle(ex);
            }
            return false;
        }
        public static DataSet getDataSet(MDB.MDBConnection MyConnection, long id, string MaBenhNhan)
        {
            string sql = @"SELECT
                B.*, '' TenBenhNhan, '' TUOI, '' GioiTinh, '' MaBenhAn, '' MaBenhNhan, '' ChanDoan,
                '' SOYTE,
                '' BENHVIEN,
                '' KHOA
            FROM
                PhieuCBBGNBTruocPTTT B
            WHERE
                ID = " + id;
            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
            Command.BindByName = true;
            MDB.MDBDataAdapter adt = new MDB.MDBDataAdapter(Command);
            var ds = new DataSet();

            adt.Fill(ds, "BK");
            if (ds != null || ds.Tables[0].Rows.Count > 0)
            {
                ds.Tables[0].Rows[0]["SoYTe"] = XemBenhAn._HanhChinhBenhNhan.SoYTe;
                ds.Tables[0].Rows[0]["BENHVIEN"] = XemBenhAn._HanhChinhBenhNhan.BenhVien;
                ds.Tables[0].Rows[0]["Khoa"] = XemBenhAn._ThongTinDieuTri.Khoa;
                ds.Tables[0].Rows[0]["TenBenhNhan"] = XemBenhAn._HanhChinhBenhNhan.TenBenhNhan;
                ds.Tables[0].Rows[0]["TUOI"] = XemBenhAn._HanhChinhBenhNhan.Tuoi;
                ds.Tables[0].Rows[0]["GioiTinh"] = XemBenhAn._HanhChinhBenhNhan.GioiTinh.Description();
                ds.Tables[0].Rows[0]["MaBenhAn"] = XemBenhAn._ThongTinDieuTri.MaBenhAn;
                ds.Tables[0].Rows[0]["MaBenhNhan"] = XemBenhAn._ThongTinDieuTri.MaBenhNhan;
                ds.Tables[0].Rows[0]["ChanDoan"] = XemBenhAn._ThongTinDieuTri.ChanDoanTruocPhauThuat;
            }
            return ds;
        }
    }
}