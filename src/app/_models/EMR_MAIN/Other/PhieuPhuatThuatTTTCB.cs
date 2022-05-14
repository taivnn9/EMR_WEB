using EMR.KyDienTu;
using EMR_MAIN.ViewModel;
using Newtonsoft.Json;
using PMS.Access;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Net.Http;
using System.Net.Http.Headers;

namespace EMR_MAIN.DATABASE.Other
{
    public class PhieuPhuatThuatTTTCB : ThongTinKy
    {
        public PhieuPhuatThuatTTTCB()
        {
            TableName = "PhieuPhuatThuatTTTCB";
            TablePrimaryKeyName = "ID";
            IDMauPhieu = (int)DanhMucPhieu.PTTTTCB;
            TenMauPhieu = DanhMucPhieu.PTTTTCB.Description();
        }
        [MoTaDuLieu("Mã định danh")]
		public long ID { get; set; }
        [MoTaDuLieu("Mã quản lý: mã duy nhất trong 1 đợt khám chữa bệnh (kcb), không trùng giữa các đợt kcb khác nhau","",1)]
		public decimal MaQuanLy { get; set; }
        [MoTaDuLieu("Mã bệnh nhân")]
		public string MaBenhNhan { get; set; }
        [MoTaDuLieu("Mã bệnh án")]
		public string MaBenhAn { get; set; }
        [MoTaDuLieu("Họ và tên bệnh nhân")]
		public string TenBenhNhan { get; set; }
        [MoTaDuLieu("Tuổi bệnh nhân")]
		public string Tuoi { get; set; }
        [MoTaDuLieu("Giới tính bệnh nhân")]
		public string GioiTinh { get; set; }
        public bool[] ChanDoanArray { get; } = new bool[] { false, false, false, false };
        [MoTaDuLieu("Chẩn đoán bệnh")]
		public string ChanDoan
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < ChanDoanArray.Length; i++)
                    temp += (ChanDoanArray[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        ChanDoanArray[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public DateTime? NgayVaoVien { get; set; }
        public DateTime? NgayPhauThuat { get; set; }
        public DateTime? NgayPhauThuat_Gio { get; set; }
        public bool[] PhuongPhapPTArray { get; } = new bool[] { false, false, false };
        public string PhuongPhapPT
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < PhuongPhapPTArray.Length; i++)
                    temp += (PhuongPhapPTArray[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        PhuongPhapPTArray[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public string PhauThuatVienChinh { get; set; }
        public string MaPhauThuatVienChinh { get; set; }
        public string PhauThuatVienPhu { get; set; }
        public string MaPhauThuatVienPhu { get; set; }
        public string BacSyGayMe { get; set; }
        public string MaBacSyGayMe { get; set; }
        public bool[] PhuongPhapVoCamArray { get; } = new bool[] { false, false };
        public string PhuongPhapVoCam
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < PhuongPhapVoCamArray.Length; i++)
                    temp += (PhuongPhapVoCamArray[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        PhuongPhapVoCamArray[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public string TeTaiMat_Text { get; set; }
        public string LoaiThuocTe { get; set; }
        public bool[] CoDinhNhanCauArray { get; } = new bool[] { false, false, false };
        public string CoDinhNhanCau
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < CoDinhNhanCauArray.Length; i++)
                    temp += (CoDinhNhanCauArray[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        CoDinhNhanCauArray[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public string TaoVatKM_KinhTuyen { get; set; }
        public bool[] TaoVatKMArray { get; } = new bool[] { false, false };
        public string TaoVatKM
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < TaoVatKMArray.Length; i++)
                    temp += (TaoVatKMArray[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        TaoVatKMArray[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public bool[] TinhTrangBaoTenonArray { get; } = new bool[] { false, false, false };
        public string TinhTrangBaoTenon
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < TinhTrangBaoTenonArray.Length; i++)
                    temp += (TinhTrangBaoTenonArray[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        TinhTrangBaoTenonArray[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public bool[] UcCheTaoXoArray { get; } = new bool[] { false, false, false };
        public string UcCheTaoXo
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < UcCheTaoXoArray.Length; i++)
                    temp += (UcCheTaoXoArray[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        UcCheTaoXoArray[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public string UcCheTaoXo_Khac { get; set; }
        public bool[] ViTriCMArray { get; } = new bool[] { false, false, false };
        public string ViTriCM
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < ViTriCMArray.Length; i++)
                    temp += (ViTriCMArray[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        ViTriCMArray[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public string ThoiGianApThuoc { get; set; }
        public bool[] LangBotBaoTenonArray { get; } = new bool[] { false, false };
        public string LangBotBaoTenon
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < LangBotBaoTenonArray.Length; i++)
                    temp += (LangBotBaoTenonArray[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        LangBotBaoTenonArray[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public string TaoVatCM_ViTri { get; set; }
        public string TaoVatCM_KichThuoc { get; set; }
        public bool[] MoVaoTPArray { get; } = new bool[] { false, false, false };
        public string MoVaoTP
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < MoVaoTPArray.Length; i++)
                    temp += (MoVaoTPArray[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        MoVaoTPArray[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public string MoVaoTP_ViTri { get; set; }
        public string MoVaoTP_KichThuoc { get; set; }
        public bool[] NhuomBaoArray { get; } = new bool[] { false, false};
        public string NhuomBao
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < NhuomBaoArray.Length; i++)
                    temp += (NhuomBaoArray[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        NhuomBaoArray[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public bool[] XeBaoTruocTTTArray { get; } = new bool[] { false, false };
        public string XeBaoTruocTTT
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < XeBaoTruocTTTArray.Length; i++)
                    temp += (XeBaoTruocTTTArray[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        XeBaoTruocTTTArray[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public bool[] TachXoayNhanArray { get; } = new bool[] { false, false, false };
        public string TachXoayNhan
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < TachXoayNhanArray.Length; i++)
                    temp += (TachXoayNhanArray[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        TachXoayNhanArray[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public bool[] DayNhanRaNgoaiArray { get; } = new bool[] { false, false, false };
        public string DayNhanRaNgoai
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < DayNhanRaNgoaiArray.Length; i++)
                    temp += (DayNhanRaNgoaiArray[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        DayNhanRaNgoaiArray[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public string TachNhanNangLuong { get; set; }
        public string TachNhanLucHut { get; set; }
        public string TachNhanTocDoDongChay { get; set; }
        public bool[] HutChatTTTArray { get; } = new bool[] { false, false };
        public string HutChatTTT
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < HutChatTTTArray.Length; i++)
                    temp += (HutChatTTTArray[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        HutChatTTTArray[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public bool[] DatIOLArray { get; } = new bool[] { false, false, false, false, false, false, false };
        public string DatIOL
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < DatIOLArray.Length; i++)
                    temp += (DatIOLArray[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        DatIOLArray[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public bool[] CatMauBeArray { get; } = new bool[] { false, false };
        public string CatMauBe
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < CatMauBeArray.Length; i++)
                    temp += (CatMauBeArray[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        CatMauBeArray[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public bool[] CatMongMatArray { get; } = new bool[] { false, false, false, false };
        public string CatMongMat
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < CatMongMatArray.Length; i++)
                    temp += (CatMongMatArray[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        CatMongMatArray[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public bool[] PhucHoiVetMoArray { get; } = new bool[] { false, false, false };
        public string PhucHoiVetMo
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < PhucHoiVetMoArray.Length; i++)
                    temp += (PhucHoiVetMoArray[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        PhucHoiVetMoArray[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public string SoMui { get; set; }
        public string LoaiChi { get; set; }
        public string KhauNapCM_SoMui { get; set; }
        public string KhauNapCM_LoaiChi { get; set; }
        public bool[] TaiTaoTPArray { get; } = new bool[] { false, false };
        public string TaiTaoTP
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < TaiTaoTPArray.Length; i++)
                    temp += (TaiTaoTPArray[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        TaiTaoTPArray[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public string KhauKM_NyLon { get; set; }
        public string KhauKM_Vicryl { get; set; }
        public bool[] KhauKMArray { get; } = new bool[] { false, false, false, false };
        public string KhauKM
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < KhauKMArray.Length; i++)
                    temp += (KhauKMArray[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        KhauKMArray[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public string KhauKM_MuiRoi { get; set; }
        public string ThuocTraMat { get; set; }
        public string DienBienKhac { get; set; }
        public bool[] TiemMatArray { get; } = new bool[] { false, false, false };
        public string TiemMat
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < TiemMatArray.Length; i++)
                    temp += (TiemMatArray[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        TiemMatArray[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public string TiemMat_Thuoc { get; set; }
        public string PhauThuatVien { get; set; }
        public string MaPhauThuatVien { get; set; }
        public string LuocDoPhauThuat { get; set; }
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

    public class PhieuPhuatThuatTTTCBFunc
    {
        public const string TableName = "PhieuPhuatThuatTTTCB";
        public const string TablePrimaryKeyName = "ID";
        public static List<PhieuPhuatThuatTTTCB> GetListData(MDB.MDBConnection _OracleConnection, decimal maquanly)
        {
            List<PhieuPhuatThuatTTTCB> list = new List<PhieuPhuatThuatTTTCB>();
            try
            {
                string sql = @"SELECT * FROM PhieuPhuatThuatTTTCB where MaQuanLy = :MaQuanLy";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, _OracleConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", maquanly));
                MDB.MDBDataReader DataReader = Command.ExecuteReader();
                while (DataReader.Read())
                {
                    PhieuPhuatThuatTTTCB data = new PhieuPhuatThuatTTTCB();
                    data.ID = Convert.ToInt64(DataReader.GetLong("ID").ToString());
                    data.MaQuanLy = maquanly;

                    data.MaBenhNhan = XemBenhAn._HanhChinhBenhNhan.MaBenhNhan;
                    data.MaBenhAn = XemBenhAn._ThongTinDieuTri.MaBenhAn;
                    data.TenBenhNhan = XemBenhAn._HanhChinhBenhNhan.TenBenhNhan;
                    data.Tuoi = XemBenhAn._HanhChinhBenhNhan.Tuoi;
                    data.GioiTinh = XemBenhAn._HanhChinhBenhNhan.GioiTinh.Description();
                    data.NgayVaoVien = DataReader["NgayVaoVien"] != DBNull.Value ? (DateTime?)Convert.ToDateTime(DataReader["NgayVaoVien"]) : null;
                    data.NgayPhauThuat = DataReader["NgayPhauThuat"] != DBNull.Value ? (DateTime?)Convert.ToDateTime(DataReader["NgayPhauThuat"]) : null;
                    data.NgayPhauThuat_Gio = data.NgayPhauThuat;
                    data.ChanDoan = DataReader["ChanDoan"].ToString();
                    data.PhuongPhapPT = DataReader["PhuongPhapPT"].ToString();
                    data.PhauThuatVienChinh = DataReader["PhauThuatVienChinh"].ToString();
                    data.MaPhauThuatVienChinh = DataReader["MaPhauThuatVienChinh"].ToString();
                    data.PhauThuatVienPhu = DataReader["PhauThuatVienPhu"].ToString();
                    data.MaPhauThuatVienPhu = DataReader["MaPhauThuatVienPhu"].ToString();
                    data.BacSyGayMe = DataReader["BacSyGayMe"].ToString();
                    data.MaBacSyGayMe = DataReader["MaBacSyGayMe"].ToString();
                    data.PhuongPhapVoCam = DataReader["PhuongPhapVoCam"].ToString();
                    data.TeTaiMat_Text = DataReader["TeTaiMat_Text"].ToString();
                    data.LoaiThuocTe = DataReader["LoaiThuocTe"].ToString();
                    data.CoDinhNhanCau = DataReader["CoDinhNhanCau"].ToString();
                    data.TaoVatKM_KinhTuyen = DataReader["TaoVatKM_KinhTuyen"].ToString();
                    data.TaoVatKM = DataReader["TaoVatKM"].ToString();
                    data.TinhTrangBaoTenon = DataReader["TinhTrangBaoTenon"].ToString();
                    data.UcCheTaoXo = DataReader["UcCheTaoXo"].ToString();
                    data.UcCheTaoXo_Khac = DataReader["UcCheTaoXo_Khac"].ToString();
                    data.ViTriCM = DataReader["ViTriCM"].ToString();
                    data.ThoiGianApThuoc = DataReader["ThoiGianApThuoc"].ToString();
                    data.LangBotBaoTenon = DataReader["LangBotBaoTenon"].ToString();
                    data.TaoVatCM_ViTri = DataReader["TaoVatCM_ViTri"].ToString();
                    data.TaoVatCM_KichThuoc = DataReader["TaoVatCM_KichThuoc"].ToString();
                    data.MoVaoTP = DataReader["MoVaoTP"].ToString();
                    data.MoVaoTP_ViTri = DataReader["MoVaoTP_ViTri"].ToString();
                    data.MoVaoTP_KichThuoc = DataReader["MoVaoTP_KichThuoc"].ToString();
                    data.NhuomBao = DataReader["NhuomBao"].ToString();
                    data.XeBaoTruocTTT = DataReader["XeBaoTruocTTT"].ToString();
                    data.TachXoayNhan = DataReader["TachXoayNhan"].ToString();
                    data.DayNhanRaNgoai = DataReader["DayNhanRaNgoai"].ToString();
                    data.TachNhanNangLuong = DataReader["TachNhanNangLuong"].ToString();
                    data.TachNhanLucHut = DataReader["TachNhanLucHut"].ToString();
                    data.TachNhanTocDoDongChay = DataReader["TachNhanTocDoDongChay"].ToString();
                    data.HutChatTTT = DataReader["HutChatTTT"].ToString();
                    data.DatIOL = DataReader["DatIOL"].ToString();
                    data.CatMauBe = DataReader["CatMauBe"].ToString();
                    data.CatMongMat = DataReader["CatMongMat"].ToString();
                    data.PhucHoiVetMo = DataReader["PhucHoiVetMo"].ToString();
                    data.SoMui = DataReader["SoMui"].ToString();
                    data.LoaiChi = DataReader["LoaiChi"].ToString();
                    data.KhauNapCM_SoMui = DataReader["KhauNapCM_SoMui"].ToString();
                    data.KhauNapCM_LoaiChi = DataReader["KhauNapCM_LoaiChi"].ToString();
                    data.TaiTaoTP = DataReader["TaiTaoTP"].ToString();
                    data.KhauKM_NyLon = DataReader["KhauKM_NyLon"].ToString();
                    data.KhauKM_Vicryl = DataReader["KhauKM_Vicryl"].ToString();
                    data.KhauKM = DataReader["KhauKM"].ToString();
                    data.KhauKM_MuiRoi = DataReader["KhauKM_MuiRoi"].ToString();
                    data.ThuocTraMat = DataReader["ThuocTraMat"].ToString();
                    data.DienBienKhac = DataReader["DienBienKhac"].ToString();
                    data.TiemMat = DataReader["TiemMat"].ToString();
                    data.TiemMat_Thuoc = DataReader["TiemMat_Thuoc"].ToString();

                    data.PhauThuatVien = DataReader["PhauThuatVien"].ToString();
                    data.MaPhauThuatVien = DataReader["MaPhauThuatVien"].ToString();
                    data.LuocDoPhauThuat = DataReader["LuocDoPhauThuat"].ToString();

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
        public static bool InsertOrUpdate(MDB.MDBConnection MyConnection, ref PhieuPhuatThuatTTTCB ketQua)
        {
            try
            {
                string sql = @"INSERT INTO PhieuPhuatThuatTTTCB
                (
                    MaQuanLy,
                    MaBenhNhan,
                    ChanDoan,
                    NgayVaoVien,
                    NgayPhauThuat,
                    PhuongPhapPT,
                    PhauThuatVienChinh,
                    MaPhauThuatVienChinh,
                    PhauThuatVienPhu,
                    MaPhauThuatVienPhu,
                    BacSyGayMe,
                    MaBacSyGayMe,
                    PhuongPhapVoCam,
                    TeTaiMat_Text,
                    LoaiThuocTe,
                    CoDinhNhanCau,
                    TaoVatKM_KinhTuyen,
                    TaoVatKM,
                    TinhTrangBaoTenon,
                    UcCheTaoXo,
                    UcCheTaoXo_Khac,
                    ViTriCM,
                    ThoiGianApThuoc,
                    LangBotBaoTenon,
                    TaoVatCM_ViTri,
                    TaoVatCM_KichThuoc,
                    MoVaoTP,
                    MoVaoTP_ViTri,
                    MoVaoTP_KichThuoc,
                    NhuomBao,
                    XeBaoTruocTTT,
                    TachXoayNhan,
                    DayNhanRaNgoai,
                    TachNhanNangLuong,
                    TachNhanLucHut,
                    TachNhanTocDoDongChay,
                    HutChatTTT,
                    DatIOL,
                    CatMauBe,
                    CatMongMat,
                    PhucHoiVetMo,
                    SoMui,
                    LoaiChi,
                    KhauNapCM_SoMui,
                    KhauNapCM_LoaiChi,
                    TaiTaoTP,
                    KhauKM_NyLon,
                    KhauKM_Vicryl,
                    KhauKM,
                    KhauKM_MuiRoi,
                    ThuocTraMat,
                    DienBienKhac,
                    TiemMat,
                    TiemMat_Thuoc,
                    PhauThuatVien,
                    MaPhauThuatVien,
                    LuocDoPhauThuat,
                    NGUOITAO,
                    NGUOISUA,
                    NGAYTAO,
                    NGAYSUA)  VALUES
                 (
				    :MaQuanLy,
                    :MaBenhNhan,
                    :ChanDoan,
                    :NgayVaoVien,
                    :NgayPhauThuat,
                    :PhuongPhapPT,
                    :PhauThuatVienChinh,
                    :MaPhauThuatVienChinh,
                    :PhauThuatVienPhu,
                    :MaPhauThuatVienPhu,
                    :BacSyGayMe,
                    :MaBacSyGayMe,
                    :PhuongPhapVoCam,
                    :TeTaiMat_Text,
                    :LoaiThuocTe,
                    :CoDinhNhanCau,
                    :TaoVatKM_KinhTuyen,
                    :TaoVatKM,
                    :TinhTrangBaoTenon,
                    :UcCheTaoXo,
                    :UcCheTaoXo_Khac,
                    :ViTriCM,
                    :ThoiGianApThuoc,
                    :LangBotBaoTenon,
                    :TaoVatCM_ViTri,
                    :TaoVatCM_KichThuoc,
                    :MoVaoTP,
                    :MoVaoTP_ViTri,
                    :MoVaoTP_KichThuoc,
                    :NhuomBao,
                    :XeBaoTruocTTT,
                    :TachXoayNhan,
                    :DayNhanRaNgoai,
                    :TachNhanNangLuong,
                    :TachNhanLucHut,
                    :TachNhanTocDoDongChay,
                    :HutChatTTT,
                    :DatIOL,
                    :CatMauBe,
                    :CatMongMat,
                    :PhucHoiVetMo,
                    :SoMui,
                    :LoaiChi,
                    :KhauNapCM_SoMui,
                    :KhauNapCM_LoaiChi,
                    :TaiTaoTP,
                    :KhauKM_NyLon,
                    :KhauKM_Vicryl,
                    :KhauKM,
                    :KhauKM_MuiRoi,
                    :ThuocTraMat,
                    :DienBienKhac,
                    :TiemMat,
                    :TiemMat_Thuoc,
                    :PhauThuatVien,
                    :MaPhauThuatVien,
                    :LuocDoPhauThuat,
                    :NGUOITAO,
                    :NGUOISUA,
                    :NGAYTAO,
                    :NGAYSUA
                 )  RETURNING ID INTO :ID";
                if (ketQua.ID != 0)
                {
                    sql = @"UPDATE PhieuPhuatThuatTTTCB SET 
                    MaQuanLy = :MaQuanLy,
                    MaBenhNhan = :MaBenhNhan,
                    ChanDoan = :ChanDoan,
                    NgayVaoVien = :NgayVaoVien,
                    NgayPhauThuat = :NgayPhauThuat,
                    PhuongPhapPT = :PhuongPhapPT,
                    PhauThuatVienChinh = :PhauThuatVienChinh,
                    MaPhauThuatVienChinh = :MaPhauThuatVienChinh,
                    PhauThuatVienPhu = :PhauThuatVienPhu,
                    MaPhauThuatVienPhu = :MaPhauThuatVienPhu,
                    BacSyGayMe = :BacSyGayMe,
                    MaBacSyGayMe = :MaBacSyGayMe,
                    PhuongPhapVoCam = :PhuongPhapVoCam,
                    TeTaiMat_Text = :TeTaiMat_Text,
                    LoaiThuocTe = :LoaiThuocTe,
                    CoDinhNhanCau = :CoDinhNhanCau,
                    TaoVatKM_KinhTuyen = :TaoVatKM_KinhTuyen,
                    TaoVatKM = :TaoVatKM,
                    TinhTrangBaoTenon = :TinhTrangBaoTenon,
                    UcCheTaoXo = :UcCheTaoXo,
                    UcCheTaoXo_Khac = :UcCheTaoXo_Khac,
                    ViTriCM = :ViTriCM,
                    ThoiGianApThuoc = :ThoiGianApThuoc,
                    LangBotBaoTenon = :LangBotBaoTenon,
                    TaoVatCM_ViTri = :TaoVatCM_ViTri,
                    TaoVatCM_KichThuoc = :TaoVatCM_KichThuoc,
                    MoVaoTP = :MoVaoTP,
                    MoVaoTP_ViTri = :MoVaoTP_ViTri,
                    MoVaoTP_KichThuoc = :MoVaoTP_KichThuoc,
                    NhuomBao = :NhuomBao,
                    XeBaoTruocTTT = :XeBaoTruocTTT,
                    TachXoayNhan = :TachXoayNhan,
                    DayNhanRaNgoai = :DayNhanRaNgoai,
                    TachNhanNangLuong = :TachNhanNangLuong,
                    TachNhanLucHut = :TachNhanLucHut,
                    TachNhanTocDoDongChay = :TachNhanTocDoDongChay,
                    HutChatTTT = :HutChatTTT,
                    DatIOL = :DatIOL,
                    CatMauBe = :CatMauBe,
                    CatMongMat = :CatMongMat,
                    PhucHoiVetMo = :PhucHoiVetMo,
                    SoMui = :SoMui,
                    LoaiChi = :LoaiChi,
                    KhauNapCM_SoMui = :KhauNapCM_SoMui,
                    KhauNapCM_LoaiChi = :KhauNapCM_LoaiChi,
                    TaiTaoTP = :TaiTaoTP,
                    KhauKM_NyLon = :KhauKM_NyLon,
                    KhauKM_Vicryl = :KhauKM_Vicryl,
                    KhauKM = :KhauKM,
                    KhauKM_MuiRoi = :KhauKM_MuiRoi,
                    ThuocTraMat = :ThuocTraMat,
                    DienBienKhac = :DienBienKhac,
                    TiemMat = :TiemMat,
                    TiemMat_Thuoc = :TiemMat_Thuoc,
                    PhauThuatVien = :PhauThuatVien,
                    MaPhauThuatVien = :MaPhauThuatVien,
                    LuocDoPhauThuat = :LuocDoPhauThuat,
                    NGUOISUA = :NGUOISUA,
                    NGAYSUA = :NGAYSUA 
                    WHERE ID = " + ketQua.ID;
                }
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", ketQua.MaQuanLy));
                Command.Parameters.Add(new MDB.MDBParameter("MaBenhNhan", ketQua.MaBenhNhan));
                Command.Parameters.Add(new MDB.MDBParameter("ChanDoan", ketQua.ChanDoan));
                Command.Parameters.Add(new MDB.MDBParameter("NgayVaoVien", ketQua.NgayVaoVien));
                DateTime? Ngay = ketQua.NgayPhauThuat.HasValue ? ketQua.NgayPhauThuat.ToDateTime().Date : (DateTime?)null;
                var NgayGio = Ngay;
                if (Ngay != null)
                {
                    var Gio = ketQua.NgayPhauThuat_Gio.HasValue ? ketQua.NgayPhauThuat_Gio.Value.TimeOfDay : new TimeSpan(0, 0, 0);
                    NgayGio = Ngay + Gio;
                }
                Command.Parameters.Add(new MDB.MDBParameter("NgayPhauThuat", NgayGio));

                Command.Parameters.Add(new MDB.MDBParameter("PhuongPhapPT", ketQua.PhuongPhapPT));
                Command.Parameters.Add(new MDB.MDBParameter("PhauThuatVienChinh", ketQua.PhauThuatVienChinh));
                Command.Parameters.Add(new MDB.MDBParameter("MaPhauThuatVienChinh", ketQua.MaPhauThuatVienChinh));
                Command.Parameters.Add(new MDB.MDBParameter("PhauThuatVienPhu", ketQua.PhauThuatVienPhu));
                Command.Parameters.Add(new MDB.MDBParameter("MaPhauThuatVienPhu", ketQua.MaPhauThuatVienPhu));
                Command.Parameters.Add(new MDB.MDBParameter("BacSyGayMe", ketQua.BacSyGayMe));
                Command.Parameters.Add(new MDB.MDBParameter("MaBacSyGayMe", ketQua.MaBacSyGayMe));
                Command.Parameters.Add(new MDB.MDBParameter("PhuongPhapVoCam", ketQua.PhuongPhapVoCam));
                Command.Parameters.Add(new MDB.MDBParameter("TeTaiMat_Text", ketQua.TeTaiMat_Text));
                Command.Parameters.Add(new MDB.MDBParameter("LoaiThuocTe", ketQua.LoaiThuocTe));
                Command.Parameters.Add(new MDB.MDBParameter("CoDinhNhanCau", ketQua.CoDinhNhanCau));
                Command.Parameters.Add(new MDB.MDBParameter("TaoVatKM_KinhTuyen", ketQua.TaoVatKM_KinhTuyen));
                Command.Parameters.Add(new MDB.MDBParameter("TaoVatKM", ketQua.TaoVatKM));
                Command.Parameters.Add(new MDB.MDBParameter("TinhTrangBaoTenon", ketQua.TinhTrangBaoTenon));
                Command.Parameters.Add(new MDB.MDBParameter("UcCheTaoXo", ketQua.UcCheTaoXo));
                Command.Parameters.Add(new MDB.MDBParameter("UcCheTaoXo_Khac", ketQua.UcCheTaoXo_Khac));
                Command.Parameters.Add(new MDB.MDBParameter("ViTriCM", ketQua.ViTriCM));
                Command.Parameters.Add(new MDB.MDBParameter("ThoiGianApThuoc", ketQua.ThoiGianApThuoc));
                Command.Parameters.Add(new MDB.MDBParameter("LangBotBaoTenon", ketQua.LangBotBaoTenon));
                Command.Parameters.Add(new MDB.MDBParameter("TaoVatCM_ViTri", ketQua.TaoVatCM_ViTri));
                Command.Parameters.Add(new MDB.MDBParameter("TaoVatCM_KichThuoc", ketQua.TaoVatCM_KichThuoc));
                Command.Parameters.Add(new MDB.MDBParameter("MoVaoTP", ketQua.MoVaoTP));
                Command.Parameters.Add(new MDB.MDBParameter("MoVaoTP_ViTri", ketQua.MoVaoTP_ViTri));
                Command.Parameters.Add(new MDB.MDBParameter("MoVaoTP_KichThuoc", ketQua.MoVaoTP_KichThuoc));
                Command.Parameters.Add(new MDB.MDBParameter("NhuomBao", ketQua.NhuomBao));
                Command.Parameters.Add(new MDB.MDBParameter("XeBaoTruocTTT", ketQua.XeBaoTruocTTT));
                Command.Parameters.Add(new MDB.MDBParameter("TachXoayNhan", ketQua.TachXoayNhan));
                Command.Parameters.Add(new MDB.MDBParameter("DayNhanRaNgoai", ketQua.DayNhanRaNgoai));
                Command.Parameters.Add(new MDB.MDBParameter("TachNhanNangLuong", ketQua.TachNhanNangLuong));
                Command.Parameters.Add(new MDB.MDBParameter("TachNhanLucHut", ketQua.TachNhanLucHut));
                Command.Parameters.Add(new MDB.MDBParameter("TachNhanTocDoDongChay", ketQua.TachNhanTocDoDongChay));
                Command.Parameters.Add(new MDB.MDBParameter("HutChatTTT", ketQua.HutChatTTT));
                Command.Parameters.Add(new MDB.MDBParameter("DatIOL", ketQua.DatIOL));
                Command.Parameters.Add(new MDB.MDBParameter("CatMauBe", ketQua.CatMauBe));
                Command.Parameters.Add(new MDB.MDBParameter("CatMongMat", ketQua.CatMongMat));
                Command.Parameters.Add(new MDB.MDBParameter("PhucHoiVetMo", ketQua.PhucHoiVetMo));
                Command.Parameters.Add(new MDB.MDBParameter("SoMui", ketQua.SoMui));
                Command.Parameters.Add(new MDB.MDBParameter("LoaiChi", ketQua.LoaiChi));
                Command.Parameters.Add(new MDB.MDBParameter("KhauNapCM_SoMui", ketQua.KhauNapCM_SoMui));
                Command.Parameters.Add(new MDB.MDBParameter("KhauNapCM_LoaiChi", ketQua.KhauNapCM_LoaiChi));
                Command.Parameters.Add(new MDB.MDBParameter("TaiTaoTP", ketQua.TaiTaoTP));
                Command.Parameters.Add(new MDB.MDBParameter("KhauKM_NyLon", ketQua.KhauKM_NyLon));
                Command.Parameters.Add(new MDB.MDBParameter("KhauKM_Vicryl", ketQua.KhauKM_Vicryl));
                Command.Parameters.Add(new MDB.MDBParameter("KhauKM", ketQua.KhauKM));
                Command.Parameters.Add(new MDB.MDBParameter("KhauKM_MuiRoi", ketQua.KhauKM_MuiRoi));
                Command.Parameters.Add(new MDB.MDBParameter("ThuocTraMat", ketQua.ThuocTraMat));
                Command.Parameters.Add(new MDB.MDBParameter("DienBienKhac", ketQua.DienBienKhac));
                Command.Parameters.Add(new MDB.MDBParameter("TiemMat", ketQua.TiemMat));
                Command.Parameters.Add(new MDB.MDBParameter("TiemMat_Thuoc", ketQua.TiemMat_Thuoc));
                Command.Parameters.Add(new MDB.MDBParameter("PhauThuatVien", ketQua.PhauThuatVien));
                Command.Parameters.Add(new MDB.MDBParameter("MaPhauThuatVien", ketQua.MaPhauThuatVien));
                Command.Parameters.Add(new MDB.MDBParameter("LuocDoPhauThuat", ketQua.LuocDoPhauThuat));
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
                XuLyLoi.LogError(ex);
            }
            return false;
        }
        public static bool Delete(MDB.MDBConnection oracleConnection, long ID)
        {
            try
            {
                string sql = "";
                MDB.MDBCommand oracleCommand;
                sql = @"DELETE FROM PhieuPhuatThuatTTTCB WHERE ID =" + ID;
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
            string sql = @"SELECT P.*, 
                T.SoNhapVien, T.Khoa, T.NgayVaoVien,  T.MaKhoa, T.MaBenhAn, T.Giuong, T.Buong,    
				H.TUOI, H.SoYTe, H.BENHVIEN, 
				H.GIOITINH,  H.TenBenhNhan, H.maBenhNhan
			  FROM PhieuPhuatThuatTTTCB P 
				Left JOIN THONGTINDIEUTRI T ON P.MAQUANLY = T.MAQUANLY
				Left JOIN HANHCHINHBENHNHAN H ON T.MABENHNHAN = H.MABENHNHAN
			  where ID = :IDPhieu";
            MDB.MDBCommand Command;
            MDB.MDBDataAdapter adt;
            using (Command = new MDB.MDBCommand(sql, MyConnection))
            {
                Command.Parameters.Add(new MDB.MDBParameter("ID", IDBienBan));
                adt = new MDB.MDBDataAdapter(Command);
            }
            var ds = new DataSet();
            adt.Fill(ds, "PT");

            return ds;
        }
        public static string DownloadAnhMoTa(decimal ID, decimal maQuanLy, string FilePath)
        {
            string fullPath = "";
            try
            {
                string FileHinhAnh = @"\" + FilePath + @"\" + maQuanLy;
                if (ID != 0M)
                {
                    using (var client = new HttpClient())
                    {
                        try
                        {
                            string URL = ERMDatabase.WebServiceEMR;
                            client.BaseAddress = new Uri(URL);
                            client.DefaultRequestHeaders.Accept.Clear();
                            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                            client.Timeout = new TimeSpan(0, 0, 1000);
                            string fileName = FileHinhAnh.Trim('\\') + "\\" + ID + ".png";
                            var url = "api/KetXuat/Get1File?PathFile=" + fileName;
                            HttpResponseMessage response = client.GetAsync(url).Result;
                            response.EnsureSuccessStatusCode();
                            if (response.IsSuccessStatusCode)
                            {
                                string result = response.Content.ReadAsStringAsync().Result;
                                if (result != "null" && result != "[]")
                                {
                                    FileCopy lstFile = JsonConvert.DeserializeObject<FileCopy>(result);
                                    if (lstFile != null)
                                    {
                                        string tempPath = System.IO.Path.GetTempPath().Trim('\\');
                                        fullPath = tempPath.Trim('\\') + "\\" + FileHinhAnh.Trim('\\');
                                        if (!System.IO.Directory.Exists(fullPath)) { System.IO.Directory.CreateDirectory(fullPath); }
                                        string fileHinhAnh = fullPath.Trim('\\') + "\\" + lstFile.FileName;
                                        try
                                        {
                                            File.WriteAllBytes(fileHinhAnh, lstFile.ArrayBytes);
                                        }
                                        catch
                                        {
                                            fileHinhAnh = fullPath.Trim('\\') + "\\COPY_" + lstFile.FileName;
                                            File.WriteAllBytes(fileHinhAnh, lstFile.ArrayBytes);
                                        }
                                    }
                                }
                            }
                        }
                        catch (Exception ex)
                        {
                            XuLyLoi.LogError(ex);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                XuLyLoi.Handle(ex);
            }
            return fullPath;
        }
    }
}
