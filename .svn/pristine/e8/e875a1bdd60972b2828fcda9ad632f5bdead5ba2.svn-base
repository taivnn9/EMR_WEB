
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
    public class PhieuPhauThuatLac : ThongTinKy
    {
        public PhieuPhauThuatLac()
        {
            TableName = "PhieuPhauThuatLac";
            TablePrimaryKeyName = "ID";
            IDMauPhieu = (int)DanhMucPhieu.PPTL;
            TenMauPhieu = DanhMucPhieu.PPTL.Description();
        }
        [MoTaDuLieu("Mã định danh")]
		public long IDPhieu { get; set; }
        [MoTaDuLieu("Mã quản lý: mã duy nhất trong 1 đợt khám chữa bệnh (kcb), không trùng giữa các đợt kcb khác nhau","",1)]
		public decimal MaQuanLy { get; set; }
        [MoTaDuLieu("Mã bệnh nhân")]
		public string MaBenhNhan { get; set; }
        [MoTaDuLieu("Khoa")]
		public string Khoa { get; set; }
        [MoTaDuLieu("Mã khoa")]
		public string MaKhoa { get; set; }
        public DateTime? NgayVaoVien { get; set; }
        public DateTime? NgayPhauThuat { get; set; }
        public string PhauThuatVienChinh { get; set; }
        public string MaPhauThuatVienChinh { get; set; }
        public string PhauThuatVienPhu { get; set; }
        public string MaPhauThuatVienPhu { get; set; }
        public string BacSyGayMe { get; set; }
        public string MaBacSyGayMe { get; set; }
        public string pathLocalAnh1 { get; set; }
        public string pathLocalAnh2 { get; set; }
        public string pathLocalAnh3 { get; set; }
        [MoTaDuLieu("Chẩn đoán bệnh")]
		public string ChanDoan { get; set; }
        public string ChiDinhTxt { get; set; }
        public string LoaiThuocTe { get; set; }
        public string DungTichThuocTe { get; set; }
        public string MoKetMacVTLC { get; set; }
        public string LoaiChiLC { get; set; }
        public string DoDaiVetKhauLC { get; set; }
        public string FadenLCTxt { get; set; }
        public string MoKetMacVTRNC { get; set; }
        public string DoDaiVetKhauRNC { get; set; }
        public string KhauCoRNC { get; set; }
        public string KhauGapCoRNC { get; set; }
        public string MoKetMacVTCC { get; set; }
        public string MoKetMacBLCC { get; set; }
        public string TTCoCC1Txt { get; set; }
        public string TTCoCC2Txt { get; set; }
        public string KhauVetCCTxt { get; set; }
        public string TraMatCCTxt { get; set; }
        public bool[] ChiDinhArray { get; } = new bool[] { false, false };
        public string ChiDinh
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < ChiDinhArray.Length; i++)
                    temp += (ChiDinhArray[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        ChiDinhArray[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public bool[] PPVocamArray { get; } = new bool[] { false, false };
        public string PPVocam
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < PPVocamArray.Length; i++)
                    temp += (PPVocamArray[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        PPVocamArray[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public bool[] LuiCoArray { get; } = new bool[] { false, false, false };
        public string LuiCo
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < LuiCoArray.Length; i++)
                    temp += (LuiCoArray[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        LuiCoArray[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public bool[] MoKetMacLCArray { get; } = new bool[] { false, false };
        public string MoKetMacLC
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < MoKetMacLCArray.Length; i++)
                    temp += (MoKetMacLCArray[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        MoKetMacLCArray[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public bool[] BoLocCoLCArray { get; } = new bool[] { false, false, false, false };
        public string BoLocCoLC
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < BoLocCoLCArray.Length; i++)
                    temp += (BoLocCoLCArray[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        BoLocCoLCArray[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public bool[] KhauCoLCArray { get; } = new bool[] { false, false };
        public string KhauCoLC
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < KhauCoLCArray.Length; i++)
                    temp += (KhauCoLCArray[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        KhauCoLCArray[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public bool[] LoaiKhauLCArray { get; } = new bool[] { false, false };
        public string LoaiKhauLC
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < LoaiKhauLCArray.Length; i++)
                    temp += (LoaiKhauLCArray[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        LoaiKhauLCArray[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public bool[] DiChuyenLCArray { get; } = new bool[] { false, false, false, false };
        public string DiChuyenLC
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < DiChuyenLCArray.Length; i++)
                    temp += (DiChuyenLCArray[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        DiChuyenLCArray[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public bool[] FadenLCArray { get; } = new bool[] { false, false};
        public string FadenLC
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < FadenLCArray.Length; i++)
                    temp += (FadenLCArray[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        FadenLCArray[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public bool[] KhauKMLCArray { get; } = new bool[] { false, false };
        public string KhauKMLC
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < KhauKMLCArray.Length; i++)
                    temp += (KhauKMLCArray[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        KhauKMLCArray[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public bool[] RutNganCoArray { get; } = new bool[] { false, false, false };
        public string RutNganCo
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < RutNganCoArray.Length; i++)
                    temp += (RutNganCoArray[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        RutNganCoArray[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public bool[] MoKetMacRNCArray { get; } = new bool[] { false, false };
        public string MoKetMacRNC
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < MoKetMacRNCArray.Length; i++)
                    temp += (MoKetMacRNCArray[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        MoKetMacRNCArray[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public bool[] BoLocCoRNCArray { get; } = new bool[] { false, false, false, false };
        public string BoLocCoRNC
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < BoLocCoRNCArray.Length; i++)
                    temp += (BoLocCoRNCArray[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        BoLocCoRNCArray[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public bool[] KhauKMRNCArray { get; } = new bool[] { false, false };
        public string KhauKMRNC
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < KhauKMRNCArray.Length; i++)
                    temp += (KhauKMRNCArray[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        KhauKMRNCArray[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public bool[] CoCheoArray { get; } = new bool[] { false, false, false };
        public string CoCheo
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < CoCheoArray.Length; i++)
                    temp += (CoCheoArray[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        CoCheoArray[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public bool[] MoKetMacCCArray { get; } = new bool[] { false };
        public string MoKetMacCC
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < MoKetMacCCArray.Length; i++)
                    temp += (MoKetMacCCArray[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        MoKetMacCCArray[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public bool[] TTCoCCArray { get; } = new bool[] { false , false , false };
        public string TTCoCC
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < TTCoCCArray.Length; i++)
                    temp += (TTCoCCArray[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        TTCoCCArray[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public bool[] LoaiChiCCArray { get; } = new bool[] { false, false};
        public string LoaiChiCC
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < LoaiChiCCArray.Length; i++)
                    temp += (LoaiChiCCArray[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        LoaiChiCCArray[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public bool[] KhauVetCCArray { get; } = new bool[] { false, false, false, false };
        public string KhauVetCC
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < KhauVetCCArray.Length; i++)
                    temp += (KhauVetCCArray[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        KhauVetCCArray[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public bool[] TraMatCCArray { get; } = new bool[] { false, false};
        public string TraMatCC
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < TraMatCCArray.Length; i++)
                    temp += (TraMatCCArray[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        TraMatCCArray[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public bool[] BangMatCCArray { get; } = new bool[] { false, false };
        public string BangMatCC
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < BangMatCCArray.Length; i++)
                    temp += (BangMatCCArray[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        BangMatCCArray[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        [MoTaDuLieu("Người tạo", null, 0, 0)]
		public string NguoiTao { get; set; }
        [MoTaDuLieu("Ngày tạo", null, 0, 0)]
		public DateTime NgayTao { get; set; }
        [MoTaDuLieu("Người sửa", null, 0, 0)]
		public string NguoiSua { get; set; }
        [MoTaDuLieu("Ngày sửa", null, 0, 0)]
		public DateTime NgaySua { get; set; }
        //public string MaSoKyTen { get; set; }
        [MoTaDuLieu("Đã ký", null, 0, 0)]
		public bool DaKy { get; set; }
        [MoTaDuLieu("Chọn", null, 0, 0)]
		public bool Chon { get; set; }
        public string SoYTe
        {
            get
            {
                return XemBenhAn._HanhChinhBenhNhan.SoYTe;
            }
        }
        public string SoBenhAn
        {
            get
            {
                return XemBenhAn._HanhChinhBenhNhan.MaBenhNhan;
            }
        }
        public string BenhVien
        {
            get
            {
                return XemBenhAn._HanhChinhBenhNhan.BenhVien;
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
        [MoTaDuLieu("Tuổi bệnh nhân")]
		public string Tuoi
        {
            get
            {
                return XemBenhAn._HanhChinhBenhNhan.Tuoi;
            }
        }
        public string MaBenhAn
        {
            get
            {
                return XemBenhAn._ThongTinDieuTri.MaBenhAn;
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

    }
    public class PhieuPhauThuatLacFunc
    {
        public static bool InsertOrUpdate(PhieuPhauThuatLac obj, MDB.MDBConnection conn)
        {
            try
            {
                string sql = "";
                if (obj.IDPhieu > 0)
                    sql = @"UPDATE PhieuPhauThuatLac SET 
                    MaQuanLy=:MaQuanLy,
                    MaBenhNhan=:MaBenhNhan,
                    Khoa=:Khoa,
                    MaKhoa=:MaKhoa,
                    NgayVaoVien=:NgayVaoVien,
                    NgayPhauThuat=:NgayPhauThuat,
                    PhauThuatVienChinh=:PhauThuatVienChinh,
                    MaPhauThuatVienChinh=:MaPhauThuatVienChinh,
                    PhauThuatVienPhu=:PhauThuatVienPhu,
                    MaPhauThuatVienPhu=:MaPhauThuatVienPhu,
                    BacSyGayMe=:BacSyGayMe,
                    MaBacSyGayMe=:MaBacSyGayMe,
                    pathLocalAnh1=:pathLocalAnh1,
                    pathLocalAnh2=:pathLocalAnh2,
                    pathLocalAnh3=:pathLocalAnh3,
                    ChanDoan=:ChanDoan,
                    ChiDinhTxt=:ChiDinhTxt,
                    LoaiThuocTe=:LoaiThuocTe,
                    DungTichThuocTe=:DungTichThuocTe,
                    MoKetMacVTLC=:MoKetMacVTLC,
                    LoaiChiLC=:LoaiChiLC,
                    DoDaiVetKhauLC=:DoDaiVetKhauLC,
                    FadenLCTxt=:FadenLCTxt,
                    MoKetMacVTRNC=:MoKetMacVTRNC,
                    DoDaiVetKhauRNC=:DoDaiVetKhauRNC,
                    KhauCoRNC=:KhauCoRNC,
                    KhauGapCoRNC=:KhauGapCoRNC,
                    MoKetMacVTCC=:MoKetMacVTCC,
                    MoKetMacBLCC=:MoKetMacBLCC,
                    TTCoCC1Txt=:TTCoCC1Txt,
                    TTCoCC2Txt=:TTCoCC2Txt,
                    KhauVetCCTxt=:KhauVetCCTxt,
                    TraMatCCTxt=:TraMatCCTxt,
                    ChiDinh=:ChiDinh,
                    PPVocam=:PPVocam,
                    LuiCo=:LuiCo,
                    MoKetMacLC=:MoKetMacLC,
                    BoLocCoLC=:BoLocCoLC,
                    KhauCoLC=:KhauCoLC,
                    LoaiKhauLC=:LoaiKhauLC,
                    DiChuyenLC=:DiChuyenLC,
                    FadenLC=:FadenLC,
                    KhauKMLC=:KhauKMLC,
                    RutNganCo=:RutNganCo,
                    MoKetMacRNC=:MoKetMacRNC,
                    BoLocCoRNC=:BoLocCoRNC,
                    KhauKMRNC=:KhauKMRNC,
                    CoCheo=:CoCheo,
                    MoKetMacCC=:MoKetMacCC,
                    TTCoCC=:TTCoCC,
                    LoaiChiCC=:LoaiChiCC,
                    KhauVetCC=:KhauVetCC,
                    TraMatCC=:TraMatCC,
                    BangMatCC=:BangMatCC,
                    NguoiSua=:NguoiSua,
                    NgaySua=:NgaySua
                    WHERE IDPhieu = " + obj.IDPhieu;
                else

                    sql = @"INSERT INTO PhieuPhauThuatLac
                (
                    MaQuanLy,
                    MaBenhNhan,
                    Khoa,
                    MaKhoa,
                    NgayVaoVien,
                    NgayPhauThuat,
                    PhauThuatVienChinh,
                    MaPhauThuatVienChinh,
                    PhauThuatVienPhu,
                    MaPhauThuatVienPhu,
                    BacSyGayMe,
                    MaBacSyGayMe,
                    pathLocalAnh1,
                    pathLocalAnh2,
                    pathLocalAnh3,
                    ChanDoan,
                    ChiDinhTxt,
                    LoaiThuocTe,
                    DungTichThuocTe,
                    MoKetMacVTLC,
                    LoaiChiLC,
                    DoDaiVetKhauLC,
                    FadenLCTxt,
                    MoKetMacVTRNC,
                    DoDaiVetKhauRNC,
                    KhauCoRNC,
                    KhauGapCoRNC,
                    MoKetMacVTCC,
                    MoKetMacBLCC,
                    TTCoCC1Txt,
                    TTCoCC2Txt,
                    KhauVetCCTxt,
                    TraMatCCTxt,
                    ChiDinh,
                    PPVocam,
                    LuiCo,
                    MoKetMacLC,
                    BoLocCoLC,
                    KhauCoLC,
                    LoaiKhauLC,
                    DiChuyenLC,
                    FadenLC,
                    KhauKMLC,
                    RutNganCo,
                    MoKetMacRNC,
                    BoLocCoRNC,
                    KhauKMRNC,
                    CoCheo,
                    MoKetMacCC,
                    TTCoCC,
                    LoaiChiCC,
                    KhauVetCC,
                    TraMatCC,
                    BangMatCC,
                    NguoiTao,
                    NgayTao,
                    NguoiSua,
                    NgaySua
                 )  VALUES
                 (
                    :MaQuanLy,
                    :MaBenhNhan,
                    :Khoa,
                    :MaKhoa,
                    :NgayVaoVien,
                    :NgayPhauThuat,
                    :PhauThuatVienChinh,
                    :MaPhauThuatVienChinh,
                    :PhauThuatVienPhu,
                    :MaPhauThuatVienPhu,
                    :BacSyGayMe,
                    :MaBacSyGayMe,
                    :pathLocalAnh1,
                    :pathLocalAnh2,
                    :pathLocalAnh3,
                    :ChanDoan,
                    :ChiDinhTxt,
                    :LoaiThuocTe,
                    :DungTichThuocTe,
                    :MoKetMacVTLC,
                    :LoaiChiLC,
                    :DoDaiVetKhauLC,
                    :FadenLCTxt,
                    :MoKetMacVTRNC,
                    :DoDaiVetKhauRNC,
                    :KhauCoRNC,
                    :KhauGapCoRNC,
                    :MoKetMacVTCC,
                    :MoKetMacBLCC,
                    :TTCoCC1Txt,
                    :TTCoCC2Txt,
                    :KhauVetCCTxt,
                    :TraMatCCTxt,
                    :ChiDinh,
                    :PPVocam,
                    :LuiCo,
                    :MoKetMacLC,
                    :BoLocCoLC,
                    :KhauCoLC,
                    :LoaiKhauLC,
                    :DiChuyenLC,
                    :FadenLC,
                    :KhauKMLC,
                    :RutNganCo,
                    :MoKetMacRNC,
                    :BoLocCoRNC,
                    :KhauKMRNC,
                    :CoCheo,
                    :MoKetMacCC,
                    :TTCoCC,
                    :LoaiChiCC,
                    :KhauVetCC,
                    :TraMatCC,
                    :BangMatCC,
                    :NguoiTao,
                    :NgayTao,
                    :NguoiSua,
                    :NgaySua
                 )  RETURNING IDPhieu INTO :IDPhieu";
                MDB.MDBCommand oracleCommand = new MDB.MDBCommand(sql, conn);
                oracleCommand.Parameters.Add(new MDB.MDBParameter("MaQuanLy", obj.MaQuanLy));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("MaBenhNhan", obj.MaBenhNhan));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("Khoa", obj.Khoa));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("MaKhoa", obj.MaKhoa));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("NgayVaoVien", obj.NgayVaoVien));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("NgayPhauThuat", obj.NgayPhauThuat));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("PhauThuatVienChinh", obj.PhauThuatVienChinh));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("MaPhauThuatVienChinh", obj.MaPhauThuatVienChinh));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("PhauThuatVienPhu", obj.PhauThuatVienPhu));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("MaPhauThuatVienPhu", obj.MaPhauThuatVienPhu));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("BacSyGayMe", obj.BacSyGayMe));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("MaBacSyGayMe", obj.MaBacSyGayMe));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("pathLocalAnh1", obj.pathLocalAnh1));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("pathLocalAnh2", obj.pathLocalAnh2));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("pathLocalAnh3", obj.pathLocalAnh3));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("ChanDoan", obj.ChanDoan));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("ChiDinhTxt", obj.ChiDinhTxt));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("LoaiThuocTe", obj.LoaiThuocTe));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("DungTichThuocTe", obj.DungTichThuocTe));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("MoKetMacVTLC", obj.MoKetMacVTLC));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("LoaiChiLC", obj.LoaiChiLC));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("DoDaiVetKhauLC", obj.DoDaiVetKhauLC));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("FadenLCTxt", obj.FadenLCTxt));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("MoKetMacVTRNC", obj.MoKetMacVTRNC));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("DoDaiVetKhauRNC", obj.DoDaiVetKhauRNC));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("KhauCoRNC", obj.KhauCoRNC));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("KhauGapCoRNC", obj.KhauGapCoRNC));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("MoKetMacVTCC", obj.MoKetMacVTCC));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("MoKetMacBLCC", obj.MoKetMacBLCC));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("TTCoCC1Txt", obj.TTCoCC1Txt));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("TTCoCC2Txt", obj.TTCoCC2Txt));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("KhauVetCCTxt", obj.KhauVetCCTxt));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("TraMatCCTxt", obj.TraMatCCTxt));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("ChiDinh", obj.ChiDinh));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("PPVocam", obj.PPVocam));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("LuiCo", obj.LuiCo));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("MoKetMacLC", obj.MoKetMacLC));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("BoLocCoLC", obj.BoLocCoLC));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("KhauCoLC", obj.KhauCoLC));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("LoaiKhauLC", obj.LoaiKhauLC));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("DiChuyenLC", obj.DiChuyenLC));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("FadenLC", obj.FadenLC));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("KhauKMLC", obj.KhauKMLC));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("RutNganCo", obj.RutNganCo));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("MoKetMacRNC", obj.MoKetMacRNC));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("BoLocCoRNC", obj.BoLocCoRNC));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("KhauKMRNC", obj.KhauKMRNC));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("CoCheo", obj.CoCheo));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("MoKetMacCC", obj.MoKetMacCC));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("TTCoCC", obj.TTCoCC));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("LoaiChiCC", obj.LoaiChiCC));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("KhauVetCC", obj.KhauVetCC));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("TraMatCC", obj.TraMatCC));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("BangMatCC", obj.BangMatCC));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("NguoiSua", Common.getUserLogin()));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("NgaySua", DateTime.Now));

                if (obj.IDPhieu == 0)
                {
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("IDPhieu", obj.IDPhieu));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("NGUOITAO", Common.getUserLogin()));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("NGAYTAO", DateTime.Now));
                }
                oracleCommand.BindByName = true;
                int n = oracleCommand.ExecuteNonQuery();
                if (obj.IDPhieu == 0)
                {
                    long nextval = Convert.ToInt64((oracleCommand.Parameters["IDPhieu"] as MDB.MDBParameter).Value);
                    obj.IDPhieu = nextval;
                }
                return n > 0 ? true : false;
            }
            catch (Exception ex)
            {
                XuLyLoi.Handle(ex);
            }
            return false;
        }
      
        public static List<PhieuPhauThuatLac> GetData(decimal MaQuanLy, MDB.MDBConnection conn)
        {
            List<PhieuPhauThuatLac> lstObject = new List<PhieuPhauThuatLac>();
            try
            {
                string sql = "SELECT * FROM PhieuPhauThuatLac WHERE MAQUANLY = :MAQUANLY ORDER BY IDPhieu DESC";
                MDB.MDBCommand command = new MDB.MDBCommand(sql, conn);
                command.Parameters.Add(new MDB.MDBParameter("MAQUANLY", MaQuanLy));
                MDB.MDBDataReader DataReader = command.ExecuteReader();
                while (DataReader.Read())
                {
                    PhieuPhauThuatLac obj = new PhieuPhauThuatLac();
                    obj.IDPhieu = DataReader.GetLong("IDPhieu");
                    obj.MaQuanLy = Common.ConDB_Decimal(DataReader["MaQuanLy"]);
                    obj.MaBenhNhan = Common.ConDBNull(DataReader["MaBenhNhan"]);
                    obj.Khoa = Common.ConDBNull(DataReader["Khoa"]);
                    obj.MaKhoa = Common.ConDBNull(DataReader["MaKhoa"]);
                    obj.NgayVaoVien = Common.ConDB_DateTimeNull(DataReader["NgayVaoVien"]);
                    obj.NgayPhauThuat = Common.ConDB_DateTimeNull(DataReader["NgayPhauThuat"]);
                    obj.PhauThuatVienChinh = Common.ConDBNull(DataReader["PhauThuatVienChinh"]);
                    obj.MaPhauThuatVienChinh = Common.ConDBNull(DataReader["MaPhauThuatVienChinh"]);
                    obj.PhauThuatVienPhu = Common.ConDBNull(DataReader["PhauThuatVienPhu"]);
                    obj.MaPhauThuatVienPhu = Common.ConDBNull(DataReader["MaPhauThuatVienPhu"]);
                    obj.BacSyGayMe = Common.ConDBNull(DataReader["BacSyGayMe"]);
                    obj.MaBacSyGayMe = Common.ConDBNull(DataReader["MaBacSyGayMe"]);
                    obj.pathLocalAnh1 = Common.ConDBNull(DataReader["pathLocalAnh1"]);
                    obj.pathLocalAnh2 = Common.ConDBNull(DataReader["pathLocalAnh2"]);
                    obj.pathLocalAnh3 = Common.ConDBNull(DataReader["pathLocalAnh3"]);
                    obj.ChanDoan = Common.ConDBNull(DataReader["ChanDoan"]);
                    obj.ChiDinhTxt = Common.ConDBNull(DataReader["ChiDinhTxt"]);
                    obj.LoaiThuocTe = Common.ConDBNull(DataReader["LoaiThuocTe"]);
                    obj.DungTichThuocTe = Common.ConDBNull(DataReader["DungTichThuocTe"]);
                    obj.MoKetMacVTLC = Common.ConDBNull(DataReader["MoKetMacVTLC"]);
                    obj.LoaiChiLC = Common.ConDBNull(DataReader["LoaiChiLC"]);
                    obj.DoDaiVetKhauLC = Common.ConDBNull(DataReader["DoDaiVetKhauLC"]);
                    obj.FadenLCTxt = Common.ConDBNull(DataReader["FadenLCTxt"]);
                    obj.MoKetMacVTRNC = Common.ConDBNull(DataReader["MoKetMacVTRNC"]);
                    obj.DoDaiVetKhauRNC = Common.ConDBNull(DataReader["DoDaiVetKhauRNC"]);
                    obj.KhauCoRNC = Common.ConDBNull(DataReader["KhauCoRNC"]);
                    obj.KhauGapCoRNC = Common.ConDBNull(DataReader["KhauGapCoRNC"]);
                    obj.MoKetMacVTCC = Common.ConDBNull(DataReader["MoKetMacVTCC"]);
                    obj.MoKetMacBLCC = Common.ConDBNull(DataReader["MoKetMacBLCC"]);
                    obj.TTCoCC1Txt = Common.ConDBNull(DataReader["TTCoCC1Txt"]);
                    obj.TTCoCC2Txt = Common.ConDBNull(DataReader["TTCoCC2Txt"]);
                    obj.KhauVetCCTxt = Common.ConDBNull(DataReader["KhauVetCCTxt"]);
                    obj.TraMatCCTxt = Common.ConDBNull(DataReader["TraMatCCTxt"]);
                    obj.ChiDinh = Common.ConDBNull(DataReader["ChiDinh"]);
                    obj.PPVocam = Common.ConDBNull(DataReader["PPVocam"]);
                    obj.LuiCo = Common.ConDBNull(DataReader["LuiCo"]);
                    obj.MoKetMacLC = Common.ConDBNull(DataReader["MoKetMacLC"]);
                    obj.BoLocCoLC = Common.ConDBNull(DataReader["BoLocCoLC"]);
                    obj.KhauCoLC = Common.ConDBNull(DataReader["KhauCoLC"]);
                    obj.LoaiKhauLC = Common.ConDBNull(DataReader["LoaiKhauLC"]);
                    obj.DiChuyenLC = Common.ConDBNull(DataReader["DiChuyenLC"]);
                    obj.FadenLC = Common.ConDBNull(DataReader["FadenLC"]);
                    obj.KhauKMLC = Common.ConDBNull(DataReader["KhauKMLC"]);
                    obj.RutNganCo = Common.ConDBNull(DataReader["RutNganCo"]);
                    obj.MoKetMacRNC = Common.ConDBNull(DataReader["MoKetMacRNC"]);
                    obj.BoLocCoRNC = Common.ConDBNull(DataReader["BoLocCoRNC"]);
                    obj.KhauKMRNC = Common.ConDBNull(DataReader["KhauKMRNC"]);
                    obj.CoCheo = Common.ConDBNull(DataReader["CoCheo"]);
                    obj.MoKetMacCC = Common.ConDBNull(DataReader["MoKetMacCC"]);
                    obj.TTCoCC = Common.ConDBNull(DataReader["TTCoCC"]);
                    obj.LoaiChiCC = Common.ConDBNull(DataReader["LoaiChiCC"]);
                    obj.KhauVetCC = Common.ConDBNull(DataReader["KhauVetCC"]);
                    obj.TraMatCC = Common.ConDBNull(DataReader["TraMatCC"]);
                    obj.BangMatCC = Common.ConDBNull(DataReader["BangMatCC"]);
                    obj.NguoiTao = Common.ConDBNull(DataReader["NguoiTao"]);
                    obj.NgayTao = Common.ConDB_DateTime(DataReader["NgayTao"]);
                    obj.NguoiSua = Common.ConDBNull(DataReader["NguoiSua"]);
                    obj.NgaySua = Common.ConDB_DateTime(DataReader["NgaySua"]);
                    obj.MaSoKy = DataReader.GetString("masokyten");
                    obj.NgayKy = DataReader.GetDate("ngayky");
                    obj.TenFileKy = DataReader.GetString("tenfileky");
                    obj.UserNameKy = DataReader.GetString("usernameky");
                    obj.DaKy = !string.IsNullOrEmpty(obj.MaSoKy) ? true : false;

                    obj.Chon = false;
                    lstObject.Add(obj);
                }
            }
            catch (Exception ex)
            {
                XuLyLoi.Handle(ex);
            }
            return lstObject;
        }
     
        public static bool Delete(decimal IDPhieu, MDB.MDBConnection conn)
        {
            try
            {
                string sql = "DELETE FROM PhieuPhauThuatLac WHERE IDPhieu = :IDPhieu";
                MDB.MDBCommand command = new MDB.MDBCommand(sql, conn);
                command.Parameters.Add(new MDB.MDBParameter("IDPhieu", IDPhieu));
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
        public static DataSet GetDataSet(decimal IDPhieu, MDB.MDBConnection conn)
        {
            try
            {
                string sql = @"SELECT P.*, '' MaBenhAn,
                '' TUOI,'' SoYTe, '' BENHVIEN, 
                '' GIOITINH,  '' TenBenhNhan
              FROM PhieuPhauThuatLac P
                where IDPhieu = :IDPhieu";
                MDB.MDBCommand command = new MDB.MDBCommand(sql, conn);
                command.Parameters.Add(new MDB.MDBParameter("IDPhieu", IDPhieu));
                MDB.MDBDataAdapter dataAdapter = new MDB.MDBDataAdapter(command);
                DataSet ds = new DataSet();
                dataAdapter.Fill(ds, "Table");
                if (ds != null || ds.Tables[0].Rows.Count > 0)
                {
                    ds.Tables[0].Rows[0]["MaBenhAn"] = XemBenhAn._ThongTinDieuTri.MaBenhAn;
                    ds.Tables[0].Rows[0]["TUOI"] = XemBenhAn._HanhChinhBenhNhan.Tuoi;
                    ds.Tables[0].Rows[0]["SoYTe"] = XemBenhAn._HanhChinhBenhNhan.SoYTe;
                    ds.Tables[0].Rows[0]["BENHVIEN"] = XemBenhAn._HanhChinhBenhNhan.BenhVien;
                    ds.Tables[0].Rows[0]["TenBenhNhan"] = XemBenhAn._HanhChinhBenhNhan.TenBenhNhan;
                    ds.Tables[0].Rows[0]["GioiTinh"] = XemBenhAn._HanhChinhBenhNhan.GioiTinh.Description();
                }
                return ds;
            }
            catch (Exception ex)
            {
                XuLyLoi.Handle(ex);
            }
            return null;
        }
        public static string DownloadAnhMoTa(decimal IDPhieu, decimal maQuanLy, bool WSActive, bool IsReplace, string LoaiAnh)
        {
            string fullPath = "";
            try
            {
                string FileHinhAnh = @"\PPTLac" + @"\" + maQuanLy;
                if (IDPhieu != 0M)
                {
                    if (WSActive)
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
                                string fileName = FileHinhAnh.Trim('\\') + "\\" + IDPhieu +"_"+ LoaiAnh + ".bmp";
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
                    else
                    {
                        if (IsReplace)
                        {
                            string PathHAMau_Local = @"\PaintLibrary\HinhAnh\PPTLac\";
                            string FileAnhMau = "PhieuPhauThuatLac"  + LoaiAnh + ".bmp";
                            string AppPath = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
                            string FullPathTmp = AppPath + PathHAMau_Local + FileAnhMau;

                            string tempPath = System.IO.Path.GetTempPath().Trim('\\');
                            tempPath = tempPath.Trim('\\') + "\\" + FileHinhAnh.Trim('\\');
                            if (!System.IO.Directory.Exists(tempPath)) { System.IO.Directory.CreateDirectory(tempPath); }
                            fullPath = tempPath.Trim('\\') + "\\" + IDPhieu + "_" + LoaiAnh + ".bmp";
                            if (File.Exists(FullPathTmp))
                            {
                                try
                                {
                                    File.Copy(FullPathTmp, fullPath, true);
                                }
                                catch { }
                                finally { }

                            }
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
