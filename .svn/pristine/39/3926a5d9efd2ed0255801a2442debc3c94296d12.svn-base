using EMR.KyDienTu;
using PMS.Access;
using System;
using System.Collections.Generic;
using System.Data;

namespace EMR_MAIN.DATABASE.Other
{
    public class BangKiemBanGiaoNguoiBenhTruocPTTT2 : ThongTinKy
    {
        public BangKiemBanGiaoNguoiBenhTruocPTTT2()
        {
            TableName = "BangKiemCBBGTruocPTTT2";
            TablePrimaryKeyName = "ID";
            IDMauPhieu = (int)DanhMucPhieu.BKCBBGTPTTT2;
            TenMauPhieu = DanhMucPhieu.BKCBBGTPTTT2.Description();
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
                return Common.getChanDoan();
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
        public string TienSuDiUng { get; set; }
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
        public bool[] HonMeArray { get; } = new bool[] { false, false, false, false };
        [MoTaDuLieu("Hôn mê")]
        public string HonMe
        {
            get
            {
                string temp = "";
                for (int i = 0; i < HonMeArray.Length; i++)
                    temp += (HonMeArray[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        HonMeArray[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public bool[] BienTenArray { get; } = new bool[] { false, false, false, false };
        [MoTaDuLieu("Biển tên")]
        public string BienTen
        {
            get
            {
                string temp = "";
                for (int i = 0; i < BienTenArray.Length; i++)
                    temp += (BienTenArray[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        BienTenArray[i] = intTemp == 1 ? true : false;
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
        [MoTaDuLieu("Người bệnh ngừng ăn từ")]
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
        public bool[] ThutThaoArray { get; set; } = new bool[] { false, false, false, false, false, false };
        [MoTaDuLieu("Thụt tháo")]
        public string ThutThao
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < ThutThaoArray.Length; i++)
                    temp += (ThutThaoArray[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        ThutThaoArray[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public bool[] KhuKhuanArray { get; } = new bool[] { false, false, false, false };
        [MoTaDuLieu("Khử khuẩn")]
        public string KhuKhuan
        {
            get
            {
                string temp = "";
                for (int i = 0; i < KhuKhuanArray.Length; i++)
                    temp += (KhuKhuanArray[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        KhuKhuanArray[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public bool[] BangVoTrungArray { get; } = new bool[] { false, false, false, false };
        [MoTaDuLieu("Băng vô trùng vùng mổ")]
        public string BangVoTrung
        {
            get
            {
                string temp = "";
                for (int i = 0; i < BangVoTrungArray.Length; i++)
                    temp += (BangVoTrungArray[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        BangVoTrungArray[i] = intTemp == 1 ? true : false;
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
        public bool[] LongTocArray { get; } = new bool[] { false, false, false, false };
        [MoTaDuLieu("Loại bỏ lông, tóc, mông(vùng PT)")]
        public string LongToc
        {
            get
            {
                string temp = "";
                for (int i = 0; i < LongTocArray.Length; i++)
                    temp += (LongTocArray[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        LongTocArray[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public bool[] PhieuChuanBiMoArray { get; } = new bool[] { false, false, false, false };
        [MoTaDuLieu("Phiếu chuẩn bị mổ")]
        public string PhieuChuanBiMo
        {
            get
            {
                string temp = "";
                for (int i = 0; i < PhieuChuanBiMoArray.Length; i++)
                    temp += (PhieuChuanBiMoArray[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        PhieuChuanBiMoArray[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public bool[] BHYTArray { get; } = new bool[] { false, false, false, false, false, false };
        [MoTaDuLieu("Bảo hiểm y tế")]
        public string BHYT
        {
            get
            {
                string temp = "";
                for (int i = 0; i < BHYTArray.Length; i++)
                    temp += (BHYTArray[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        BHYTArray[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public bool[] BoPhieuChamSocArray { get; } = new bool[] { false, false, false, false };
        [MoTaDuLieu("Bộ phiếu chăm sóc")]
        public string BoPhieuChamSoc
        {
            get
            {
                string temp = "";
                for (int i = 0; i < BoPhieuChamSocArray.Length; i++)
                    temp += (BoPhieuChamSocArray[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        BoPhieuChamSocArray[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public bool[] ThuTestKhangSinhArray { get; } = new bool[] { false, false, false, false };
        [MoTaDuLieu("Thử test kháng sinh")]
        public string ThuTestKhangSinh
        {
            get
            {
                string temp = "";
                for (int i = 0; i < ThuTestKhangSinhArray.Length; i++)
                    temp += (ThuTestKhangSinhArray[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        ThuTestKhangSinhArray[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public bool[] XNCBArray { get; } = new bool[] { false, false, false, false, false, false, false, false, false, false };
        [MoTaDuLieu("Bộ XNCB")]
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
        [MoTaDuLieu("HIV")]
		public string HIV { get; set; }
        [MoTaDuLieu("HbsAg")]
        public string HBS { get; set; }
        [MoTaDuLieu("Nhóm máu")]
		public string NhomMau { get; set; }
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
        public bool[] SieuAmArray { get; } = new bool[] { false, false, false, false };
        [MoTaDuLieu("Siêu âm")]
        public string SieuAm
        {
            get
            {
                string temp = "";
                for (int i = 0; i < SieuAmArray.Length; i++)
                    temp += (SieuAmArray[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        SieuAmArray[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public bool[] XQArray { get; } = new bool[] { false, false, false, false };
        [MoTaDuLieu("XQ")]
        public string XQ
        {
            get
            {
                string temp = "";
                for (int i = 0; i < XQArray.Length; i++)
                    temp += (XQArray[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        XQArray[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        [MoTaDuLieu("Số lượng XQ")]
        public string XQSoLuong { get; set; }
        public bool[] CTArray { get; } = new bool[] { false, false, false, false };
        [MoTaDuLieu("CT")]
        public string CT
        {
            get
            {
                string temp = "";
                for (int i = 0; i < CTArray.Length; i++)
                    temp += (CTArray[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        CTArray[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        [MoTaDuLieu("Số lượng CT")]
        public string CTSoLuong { get; set; }
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
    public class BangKiemBanGiaoNguoiBenhTruocPTTT2Func
    {
        public const string TableName = "BangKiemCBBGTruocPTTT2";
        public const string TablePrimaryKeyName = "ID";
        public static List<BangKiemBanGiaoNguoiBenhTruocPTTT2> GetListData(MDB.MDBConnection _OracleConnection, decimal maquanly)
        {
            List<BangKiemBanGiaoNguoiBenhTruocPTTT2> list = new List<BangKiemBanGiaoNguoiBenhTruocPTTT2>();
            try
            {
                string sql = @"SELECT * FROM BangKiemCBBGTruocPTTT2 where MaQuanLy = :MaQuanLy";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, _OracleConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", maquanly));
                MDB.MDBDataReader DataReader = Command.ExecuteReader();
                while (DataReader.Read())
                {
                    BangKiemBanGiaoNguoiBenhTruocPTTT2 data = new BangKiemBanGiaoNguoiBenhTruocPTTT2();
                    data.ID = Convert.ToInt64(DataReader.GetLong("ID").ToString());
                    data.MaQuanLy = maquanly;
                    data.PhauThuatThuThuat = DataReader.GetInt("PhauThuatThuThuat");
                    data.ThoiGian = Convert.ToDateTime(DataReader["ThoiGian"] == DBNull.Value ? DateTime.Now : DataReader["ThoiGian"]);
                    data.TienSuDiUng = DataReader["TienSuDiUng"].ToString();
                    data.Mach = DataReader["Mach"].ToString();
                    data.HuyetAp = DataReader["HuyetAp"].ToString();
                    data.NhietDo = DataReader["NhietDo"].ToString();
                    data.NhipTho = DataReader["NhipTho"].ToString();
                    data.CanNang = DataReader["CanNang"].ToString();
                    data.ChieuCao = DataReader["ChieuCao"].ToString();
                    data.TinhTiepXuc = DataReader["TinhTiepXuc"].ToString();
                    data.HonMe = DataReader["HonMe"].ToString();
                    data.BienTen = DataReader["BienTen"].ToString();
                    data.NhinAn = DataReader["NhinAn"].ToString();
                    data.NBNgungAn_Date = Convert.ToDateTime(DataReader["NBNgungAn_Date"] == DBNull.Value ? DateTime.Now : DataReader["NBNgungAn_Date"]);
                    data.NBNgungAn = DataReader["NBNgungAn"].ToString();
                    data.ThutThao = DataReader["ThutThao"].ToString();
                    data.KhuKhuan = DataReader["KhuKhuan"].ToString();
                    data.BangVoTrung = DataReader["BangVoTrung"].ToString();
                    data.CoRangGia = DataReader["CoRangGia"].ToString();
                    data.LongToc = DataReader["LongToc"].ToString();
                    data.PhieuChuanBiMo = DataReader["PhieuChuanBiMo"].ToString();
                    data.BHYT = DataReader["BHYT"].ToString();
                    data.BoPhieuChamSoc = DataReader["BoPhieuChamSoc"].ToString();
                    data.ThuTestKhangSinh = DataReader["ThuTestKhangSinh"].ToString();
                    data.XNCB = DataReader["XNCB"].ToString();
                    data.HIV = DataReader["HIV"].ToString();
                    data.HBS = DataReader["HBS"].ToString();
                    data.NhomMau = DataReader["NhomMau"].ToString();
                    data.DienTim = DataReader["DienTim"].ToString();
                    data.SieuAm = DataReader["SieuAm"].ToString();
                    data.XQ = DataReader["XQ"].ToString();
                    data.XQSoLuong = DataReader["XQSoLuong"].ToString();
                    data.CT = DataReader["CT"].ToString();
                    data.CTSoLuong = DataReader["CTSoLuong"].ToString();
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
        public static bool InsertOrUpdate(MDB.MDBConnection MyConnection, ref BangKiemBanGiaoNguoiBenhTruocPTTT2 data)
        {
            try
            {
                string sql = @"INSERT INTO BangKiemCBBGTruocPTTT2
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
                    TinhTiepXuc,
                    HonMe,
                    BienTen,
                    NhinAn,
                    NBNgungAn_Date,
                    NBNgungAn,
                    ThutThao,
                    KhuKhuan,
                    BangVoTrung,
                    CoRangGia,
                    LongToc,
                    PhieuChuanBiMo,
                    BHYT,
                    BoPhieuChamSoc,
                    ThuTestKhangSinh,
                    XNCB,
                    HIV,
                    HBS,
                    NhomMau,
                    DienTim,
                    SieuAm,
                    XQ,
                    XQSoLuong,
                    CT,
                    CTSoLuong,
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
                    :TinhTiepXuc,
                    :HonMe,
                    :BienTen,
                    :NhinAn,
                    :NBNgungAn_Date,
                    :NBNgungAn,
                    :ThutThao,
                    :KhuKhuan,
                    :BangVoTrung,
                    :CoRangGia,
                    :LongToc,
                    :PhieuChuanBiMo,
                    :BHYT,
                    :BoPhieuChamSoc,
                    :ThuTestKhangSinh,
                    :XNCB,
                    :HIV,
                    :HBS,
                    :NhomMau,
                    :DienTim,
                    :SieuAm,
                    :XQ,
                    :XQSoLuong,
                    :CT,
                    :CTSoLuong,
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
                    sql = @"UPDATE BangKiemCBBGTruocPTTT2 SET 
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
                    TinhTiepXuc=:TinhTiepXuc,
                    HonMe=:HonMe,
                    BienTen=:BienTen,
                    NhinAn=:NhinAn,
                    NBNgungAn_Date=:NBNgungAn_Date,
                    NBNgungAn=:NBNgungAn,
                    ThutThao=:ThutThao,
                    KhuKhuan=:KhuKhuan,
                    BangVoTrung=:BangVoTrung,
                    CoRangGia=:CoRangGia,
                    LongToc=:LongToc,
                    PhieuChuanBiMo=:PhieuChuanBiMo,
                    BHYT=:BHYT,
                    BoPhieuChamSoc=:BoPhieuChamSoc,
                    ThuTestKhangSinh=:ThuTestKhangSinh,
                    XNCB=:XNCB,
                    HIV=:HIV,
                    HBS=:HBS,
                    NhomMau=:NhomMau,
                    DienTim=:DienTim,
                    SieuAm=:SieuAm,
                    XQ=:XQ,
                    XQSoLuong=:XQSoLuong,
                    CT=:CT,
                    CTSoLuong=:CTSoLuong,
                    Khac=:Khac,
                    KhacSoLuong=:KhacSoLuong,
                    NguoiChuanBi=:NguoiChuanBi,
                    MaNguoiChuanBi=:MaNguoiChuanBi,
                    NguoiBanGiao=:NguoiBanGiao,
                    MaNguoiBanGiao=:MaNguoiBanGiao,
                    NguoiNhanBanGiao=:NguoiNhanBanGiao,
                    MaNguoiNhanBanGiao=:MaNguoiNhanBanGiao,
                    NGUOISUA = :NGUOISUA,
                    NGAYSUA = :NGAYSUA 
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
                Command.Parameters.Add(new MDB.MDBParameter("TinhTiepXuc", data.TinhTiepXuc));
                Command.Parameters.Add(new MDB.MDBParameter("HonMe", data.HonMe));
                Command.Parameters.Add(new MDB.MDBParameter("BienTen", data.BienTen));
                Command.Parameters.Add(new MDB.MDBParameter("NhinAn", data.NhinAn));
                Command.Parameters.Add(new MDB.MDBParameter("NBNgungAn_Date", data.NBNgungAn_Date));
                Command.Parameters.Add(new MDB.MDBParameter("NBNgungAn", data.NBNgungAn));
                Command.Parameters.Add(new MDB.MDBParameter("ThutThao", data.ThutThao));
                Command.Parameters.Add(new MDB.MDBParameter("KhuKhuan", data.KhuKhuan));
                Command.Parameters.Add(new MDB.MDBParameter("BangVoTrung", data.BangVoTrung));
                Command.Parameters.Add(new MDB.MDBParameter("CoRangGia", data.CoRangGia));
                Command.Parameters.Add(new MDB.MDBParameter("LongToc", data.LongToc));
                Command.Parameters.Add(new MDB.MDBParameter("PhieuChuanBiMo", data.PhieuChuanBiMo));
                Command.Parameters.Add(new MDB.MDBParameter("BHYT", data.BHYT));
                Command.Parameters.Add(new MDB.MDBParameter("BoPhieuChamSoc", data.BoPhieuChamSoc));
                Command.Parameters.Add(new MDB.MDBParameter("ThuTestKhangSinh", data.ThuTestKhangSinh));
                Command.Parameters.Add(new MDB.MDBParameter("XNCB", data.XNCB));
                Command.Parameters.Add(new MDB.MDBParameter("HIV", data.HIV));
                Command.Parameters.Add(new MDB.MDBParameter("HBS", data.HBS));
                Command.Parameters.Add(new MDB.MDBParameter("NhomMau", data.NhomMau));
                Command.Parameters.Add(new MDB.MDBParameter("DienTim", data.DienTim));
                Command.Parameters.Add(new MDB.MDBParameter("SieuAm", data.SieuAm));
                Command.Parameters.Add(new MDB.MDBParameter("XQ", data.XQ));
                Command.Parameters.Add(new MDB.MDBParameter("XQSoLuong", data.XQSoLuong));
                Command.Parameters.Add(new MDB.MDBParameter("CT", data.CT));
                Command.Parameters.Add(new MDB.MDBParameter("CTSoLuong", data.CTSoLuong));
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
                string sql = "DELETE FROM BangKiemCBBGTruocPTTT2 WHERE ID = :ID";
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
                B.*, '' TenBenhNhan, '' TUOI, '' GioiTinh, '' MaBenhAn, '' MaBenhNhan,
                '' SOYTE,
                '' BENHVIEN,
                '' KHOA
            FROM
                BangKiemCBBGTruocPTTT2 B
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
            }
            return ds;
        }
    }
}