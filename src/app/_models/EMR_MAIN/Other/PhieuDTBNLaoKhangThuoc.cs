using EMR.KyDienTu;
using Newtonsoft.Json;
using PMS.Access;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Linq;

namespace EMR_MAIN.DATABASE.Other
{
    public class PhieuDTBNLaoKhangThuoc:ThongTinKy
    {
        public PhieuDTBNLaoKhangThuoc()
        {
            TableName = "PhieuDTBNLaoKhangThuoc";
            TablePrimaryKeyName = "ID";
            IDMauPhieu = (int)DanhMucPhieu.PDTBNLKT;
            TenMauPhieu = DanhMucPhieu.PDTBNLKT.Description();
        }
        [MoTaDuLieu("Mã định danh")]
        public long ID { get; set; }
        [MoTaDuLieu("Mã quản lý: mã duy nhất trong 1 đợt khám chữa bệnh (kcb), không trùng giữa các đợt kcb khác nhau", "", 1)]
        public decimal MaQuanLy { get; set; }
        [MoTaDuLieu("Mã bệnh nhân")]
        public string MaBenhNhan { get; set; }
        [MoTaDuLieu("Họ và tên")]
        public string HoVaTen { get; set; }
        [MoTaDuLieu("Giới tính")]
        public string GioiTinh { get; set; }
        [MoTaDuLieu("Tuổi")]
        public string Tuoi { get; set; }
        [MoTaDuLieu("Ngày ĐKĐT LKT")]
        public DateTime? NgayDKDTLKT { get; set; }
        [MoTaDuLieu("Số ĐKĐT LKT")]
        public string SoDKDTLKT { get; set; }
        [MoTaDuLieu("Số ĐK trên eTBM")]
        public string SoDKTrenETBM { get; set; }
        [MoTaDuLieu("Số ĐKĐT PĐI,II,IV/gần nhất ")]
        public string SoDKDTPDI { get; set; }
        [MoTaDuLieu("Địa chỉ")]
        public string DiaChi { get; set; }
        [MoTaDuLieu("Xã huyện")]
        public string XaHuyen { get; set; }
        [MoTaDuLieu("Tỉnh")]
        public string Tinh { get; set; }
        [MoTaDuLieu("Số ĐT")]
        public string SoDT { get; set; }
        [MoTaDuLieu("Ngày sinh")]
        public DateTime? NgaySinh { get; set; }
        [MoTaDuLieu("Cân nặng ban đầu")]
        public string CanNangBanDau { get; set; }
        [MoTaDuLieu("Chiều cao")]
        public string ChieuCao { get; set; }
        [MoTaDuLieu("Vị trí, 1 -> phổi, 2 -> ngoài phổi")]
        public int ViTri { get; set; }
        [MoTaDuLieu("Vị trí ngoài phổi, ghi rõ vị trí")]
        public string ViTriNgoaiPhoi_Text { get; set; }
        [MoTaDuLieu("Phân loại bệnh nhân")]
        public int PhanLoaiBenhNhan { get; set; }
        [MoTaDuLieu("Phân loại bệnh nhân, khác")]
        public string PhanLoaiBenhNhan_Khac { get; set; }
        [MoTaDuLieu("Chuyển đến, 1-> có, 2-> không")]
        public int ChuyenDen { get; set; }
        [MoTaDuLieu("Nếu có, tên đơn vị chuyển")]
        public string TenDonViChuyen { get; set; }
        [MoTaDuLieu("Ngày chuyển")]
        public DateTime? NgayChuyen { get; set; }
        [MoTaDuLieu("Ngày tiếp nhận")]
        public DateTime? NgayTiepNhan { get; set; }
        [MoTaDuLieu("Đã XN HIV, 1-> có, 2-> không, 3-> không rõ")]
        public int DaXNHIV { get; set; }
        [MoTaDuLieu("Ngày xét nghiệm")]
        public DateTime? NgayXN { get; set; }
        [MoTaDuLieu("Kết quả")]
        public string KetQua { get; set; }
        [MoTaDuLieu("ART, 1-> có, 2-> không")]
        public int ART { get; set; }
        [MoTaDuLieu("ART, ngày")]
        public DateTime? ART_Ngay { get; set; }
        [MoTaDuLieu("CPT, 1-> có, 2 -> không")]
        public int CPT { get; set; }
        [MoTaDuLieu("CPT, ngày")]
        public DateTime? CPT_Ngay { get; set; }
        [MoTaDuLieu("Phương pháp chẩn đoán, HAIN(LPA) ")]
        public int HAIN_LPA { get; set; }
        [MoTaDuLieu("Phương pháp chẩn đoán, Xpert")]
        public int Xpert { get; set; }
        [MoTaDuLieu("Kết quả kháng thuốc, R")]
        public int KQKT_R { get; set; }
        [MoTaDuLieu("Kết quả kháng thuốc, H")]
        public int KQKT_H { get; set; }
        [MoTaDuLieu("Kết quả kháng thuốc, Khác")]
        public int KQKT_Khac { get; set; }
        [MoTaDuLieu("Kết quả kháng thuốc, ghi rõ")]
        public string KQKT_GhiRo { get; set; }
        [MoTaDuLieu("Hội chẩn: ngày và chỉ định")]
        public ObservableCollection<HoiChanLaoKhangThuoc> HoiChans { get; set; }
        [MoTaDuLieu("Quá trình điều trị lao trước đây")]
        public ObservableCollection<QuaTrinhDieuTriLao> QuaTrinhDieuTris { get; set; }
        [MoTaDuLieu("Dùng thuốc hàng 2 trước đây, 1-> có, 2-> không, 3-> không rõ")]
        public int DungThuocHang2 { get; set; }
        [MoTaDuLieu("Dùng thuốc hàng 2 trước đây, nếu có, ghi rõ")]
        public string DungThuocHang2_Text { get; set; }
        [MoTaDuLieu("Tên thuốc, viết tắt khác")]
        public string TenThuocKhac_GhiRo { get; set; }
        [MoTaDuLieu("Phụ lục")]
        public string PhuLuc { get; set; }
        [MoTaDuLieu("Soi đờm trực tiếp")]
        public ObservableCollection<SoiDomNoiCay> SoiDomTrucTiep { get; set; }
        [MoTaDuLieu("Nuôi cấy")]
        public ObservableCollection<SoiDomNoiCay> NuoiCay { get; set; }
        [MoTaDuLieu("Kết quả xét nghiệm kháng sinh đồ, header khác 1")]
        public string KSD_Khac1 { get; set; }
        [MoTaDuLieu("Kết quả xét nghiệm kháng sinh đồ, header khác 2")]
        public string KSD_Khac2 { get; set; }
        [MoTaDuLieu("Kết quả xét nghiệm kháng sinh đồ (KSĐ/Hain test (LPA) hàng 2")]
        public ObservableCollection<KetQuaXNKhangSinhDo> KetQuaXNKSD { get; set; }
        [MoTaDuLieu("Phác đồ điều trị lao kháng thuốc, header khác 1")]
        public string PDDT_Khac1 { get; set; }
        [MoTaDuLieu("Phác đồ điều trị lao kháng thuốc, header khác 2")]
        public string PDDT_Khac2 { get; set; }
        [MoTaDuLieu("Phác đồ điều trị lao kháng thuốc, header khác 3")]
        public string PDDT_Khac3 { get; set; }
        [MoTaDuLieu("Phác đồ điều trị lao kháng thuốc, header khác 4")]
        public string PDDT_Khac4 { get; set; }

        [MoTaDuLieu("Phác đồ điều trị lao kháng thuốc")]
        public ObservableCollection<PhacDoDTLaoKhangThuoc> PhacDoDieuTriLKT { get; set; }
        [MoTaDuLieu("Uống, tiêm thuốc")]
        public ObservableCollection<UongTiemThuoc> UongTiemThuoc { get; set; }
        [MoTaDuLieu("Uống, tiêm thuốc tiếp theo")]
        public ObservableCollection<UongTiemThuoc> UongTiemThuocTiepTheo { get; set; }
        [MoTaDuLieu("Nhận xét")]
        public string NhanXet { get; set; }
        public ObservableCollection<KetQuaLaoKhangThuoc> KetQuas { get; set; }
        [MoTaDuLieu("Y, bác sỹ")]
        public string BacSy { get; set; }
        [MoTaDuLieu("Mã Y, bác sỹ")]
        public string MaBacSy { get; set; }
        // bắt buộc
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
    public class HoiChanLaoKhangThuoc
    {
        [MoTaDuLieu("Ngày")]
        public DateTime? Ngay { get; set; }
        [MoTaDuLieu("Chỉ định")]
        public string ChiDinh { get; set; }
        [MoTaDuLieu("Ngày hội chẩn tiếp")]
        public DateTime? NgayHCTiep { get; set; }
    }
    public class QuaTrinhDieuTriLao
    {
        [MoTaDuLieu("TT")]
        public string TT { get; set; }
        [MoTaDuLieu("Ngày bắt đầu")]
        public string NgayBatDau { get; set; }
        [MoTaDuLieu("Phác đồ")]
        public string PhacDo { get; set; }
        [MoTaDuLieu("Kết quả")]
        public string KetQua { get; set; }
    }
    public class SoiDomNoiCay
    {
        [MoTaDuLieu("Tháng thứ")]
        public string ThangThu { get; set; }
        [MoTaDuLieu("Ngày")]
        public string Ngay { get; set; }
        [MoTaDuLieu("Số XN")]
        public string SoXN { get; set; }
        [MoTaDuLieu("Kết quả")]
        public string KetQua { get; set; }
    }
    public class KetQuaXNKhangSinhDo
    {
        [MoTaDuLieu("Ngày")]
        public DateTime? Ngay { get; set; }
        [MoTaDuLieu("S")]
        public string S { get; set; }
        [MoTaDuLieu("H")]
        public string H { get; set; }
        [MoTaDuLieu("R")]
        public string R { get; set; }
        [MoTaDuLieu("E")]
        public string E { get; set; }
        [MoTaDuLieu("Z")]
        public string Z { get; set; }
        [MoTaDuLieu("Km")]
        public string Km { get; set; }
        [MoTaDuLieu("Am")]
        public string Am { get; set; }
        [MoTaDuLieu("Cm")]
        public string Cm { get; set; }
        [MoTaDuLieu("Fq")]
        public string Fq { get; set; }
        [MoTaDuLieu("Pto/Eto")]
        public string Pto { get; set; }
        [MoTaDuLieu("PAS")]
        public string PAS { get; set; }
        [MoTaDuLieu("Cs")]
        public string Cs { get; set; }
        [MoTaDuLieu("Khác, cột 1")]
        public string Khac_1 { get; set; }
        [MoTaDuLieu("Khác, cột 2")]
        public string Khac_2 { get; set; }
        public KetQuaXNKhangSinhDo Clone()
        {
            KetQuaXNKhangSinhDo other = (KetQuaXNKhangSinhDo)this.MemberwiseClone();
            return other;
        }
    }
    public class PhacDoDTLaoKhangThuoc
    {
        [MoTaDuLieu("Ngày")]
        public DateTime? Ngay { get; set; }
        [MoTaDuLieu("Z")]
        public string Z { get; set; }
        [MoTaDuLieu("E")]
        public string E { get; set; }
        [MoTaDuLieu("Km")]
        public string Km { get; set; }
        [MoTaDuLieu("Cm")]
        public string Cm { get; set; }
        [MoTaDuLieu("Lfx")]
        public string Lfx { get; set; }
        [MoTaDuLieu("Pto/Eto")]
        public string Pto { get; set; }
        [MoTaDuLieu("Cs")]
        public string Cs { get; set; }
        [MoTaDuLieu("PAS")]
        public string PAS { get; set; }
        [MoTaDuLieu("Am")]
        public string Am { get; set; }
        [MoTaDuLieu("Khác 1")]
        public string Khac_1 { get; set; }
        [MoTaDuLieu("Khác 2")]
        public string Khac_2 { get; set; }
        [MoTaDuLieu("Khác 3")]
        public string Khac_3 { get; set; }
        [MoTaDuLieu("Khác 4")]
        public string Khac_4 { get; set; }
        [MoTaDuLieu("Ghi chú")]
        public string GhiChu { get; set; }
        public PhacDoDTLaoKhangThuoc Clone()
        {
            PhacDoDTLaoKhangThuoc other = (PhacDoDTLaoKhangThuoc)this.MemberwiseClone();
            return other;
        }
    }
    public class UongTiemThuoc
    {
        [MoTaDuLieu("Tháng")]
        public string Thang { get; set; }
        [MoTaDuLieu("Ngày 1")]
        public string N1 { get; set; }
        [MoTaDuLieu("Ngày 2")]
        public string N2 { get; set; }
        [MoTaDuLieu("Ngày 3")]
        public string N3 { get; set; }
        [MoTaDuLieu("Ngày 4")]
        public string N4 { get; set; }
        [MoTaDuLieu("Ngày 5")]
        public string N5 { get; set; }
        [MoTaDuLieu("Ngày 6")]
        public string N6 { get; set; }
        [MoTaDuLieu("Ngày 7")]
        public string N7 { get; set; }
        [MoTaDuLieu("Ngày 8")]
        public string N8 { get; set; }
        [MoTaDuLieu("Ngày 9")]
        public string N9 { get; set; }
        [MoTaDuLieu("Ngày 10")]
        public string N10 { get; set; }
        [MoTaDuLieu("Ngày 11")]
        public string N11 { get; set; }
        [MoTaDuLieu("Ngày 12")]
        public string N12 { get; set; }
        [MoTaDuLieu("Ngày 13")]
        public string N13 { get; set; }
        [MoTaDuLieu("Ngày 14")]
        public string N14 { get; set; }
        [MoTaDuLieu("Ngày 15")]
        public string N15 { get; set; }
        [MoTaDuLieu("Ngày 16")]
        public string N16 { get; set; }
        [MoTaDuLieu("Ngày 17")]
        public string N17 { get; set; }
        [MoTaDuLieu("Ngày 18")]
        public string N18 { get; set; }
        [MoTaDuLieu("Ngày 19")]
        public string N19 { get; set; }
        [MoTaDuLieu("Ngày 20")]
        public string N20 { get; set; }
        [MoTaDuLieu("Ngày 21")]
        public string N21 { get; set; }
        [MoTaDuLieu("Ngày 22")]
        public string N22 { get; set; }
        [MoTaDuLieu("Ngày 23")]
        public string N23 { get; set; }
        [MoTaDuLieu("Ngày 24")]
        public string N24 { get; set; }
        [MoTaDuLieu("Ngày 25")]
        public string N25 { get; set; }
        [MoTaDuLieu("Ngày 26")]
        public string N26 { get; set; }
        [MoTaDuLieu("Ngày 27")]
        public string N27 { get; set; }
        [MoTaDuLieu("Ngày 28")]
        public string N28 { get; set; }
        [MoTaDuLieu("Ngày 29")]
        public string N29 { get; set; }
        [MoTaDuLieu("Ngày 30")]
        public string N30 { get; set; }
        [MoTaDuLieu("Ngày 31")]
        public string N31 { get; set; }
        [MoTaDuLieu("Cân nặng/ghi chú")]
        public string CN_GC { get; set; }
        public UongTiemThuoc Clone()
        {
            UongTiemThuoc other = (UongTiemThuoc)this.MemberwiseClone();
            return other;
        }
    }
    public class KetQuaLaoKhangThuoc
    {
        public string KetQua { get; set; }
        public DateTime? Ngay { get; set; }
    }
    public class PhieuDTBNLaoKhangThuocFunc
    {
        public const string TableName = "PhieuDTBNLaoKhangThuoc";
        public const string TablePrimaryKeyName = "ID";

        public static List<PhieuDTBNLaoKhangThuoc> GetListData(MDB.MDBConnection _OracleConnection, decimal maquanly)
        {
            List<PhieuDTBNLaoKhangThuoc> list = new List<PhieuDTBNLaoKhangThuoc>();
            try
            {
                string sql = @"SELECT * FROM PhieuDTBNLaoKhangThuoc where MaQuanLy = :MaQuanLy";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, _OracleConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", maquanly));
                MDB.MDBDataReader DataReader = Command.ExecuteReader();
                while (DataReader.Read())
                {
                    PhieuDTBNLaoKhangThuoc data = new PhieuDTBNLaoKhangThuoc();
                    data.ID = Convert.ToInt64(DataReader.GetLong("ID").ToString());
                    data.MaQuanLy = maquanly;
                    data.MaBenhNhan = DataReader["MaBenhNhan"].ToString();
                    data.HoVaTen = XemBenhAn._HanhChinhBenhNhan.TenBenhNhan;
                    data.Tuoi = XemBenhAn._HanhChinhBenhNhan.Tuoi;
                    data.GioiTinh = XemBenhAn._HanhChinhBenhNhan.GioiTinh.Description();
                    data.NgayDKDTLKT = DataReader["NgayDKDTLKT"] != DBNull.Value ? (DateTime?) Convert.ToDateTime(DataReader["NgayDKDTLKT"]): null;
                    data.SoDKDTLKT = DataReader["SoDKDTLKT"].ToString();
                    data.SoDKTrenETBM = DataReader["SoDKTrenETBM"].ToString();
                    data.SoDKDTPDI = DataReader["SoDKDTPDI"].ToString();
                    data.DiaChi = DataReader["DiaChi"].ToString();
                    data.XaHuyen = DataReader["XaHuyen"].ToString();
                    data.Tinh = DataReader["Tinh"].ToString();
                    data.SoDT = DataReader["SoDT"].ToString();
                    data.NgaySinh = DataReader["NgaySinh"] != DBNull.Value ? (DateTime?)Convert.ToDateTime(DataReader["NgaySinh"]) : null;
                    data.CanNangBanDau = DataReader["CanNangBanDau"].ToString();
                    data.ChieuCao = DataReader["ChieuCao"].ToString();
                    data.ViTri = DataReader.GetInt("ViTri");
                    data.ViTriNgoaiPhoi_Text = DataReader["ViTriNgoaiPhoi_Text"].ToString();
                    data.PhanLoaiBenhNhan = DataReader.GetInt("PhanLoaiBenhNhan");
                    data.PhanLoaiBenhNhan_Khac = DataReader["PhanLoaiBenhNhan_Khac"].ToString();
                    data.ChuyenDen = DataReader.GetInt("ChuyenDen");
                    data.TenDonViChuyen = DataReader["TenDonViChuyen"].ToString();
                    data.NgayChuyen = DataReader["NgayChuyen"] != DBNull.Value ? (DateTime?)Convert.ToDateTime(DataReader["NgayChuyen"]) : null;
                    data.NgayTiepNhan = DataReader["NgayTiepNhan"] != DBNull.Value ? (DateTime?)Convert.ToDateTime(DataReader["NgayTiepNhan"]) : null;
                    data.DaXNHIV = DataReader.GetInt("DaXNHIV");
                    data.NgayXN = DataReader["NgayXN"] != DBNull.Value ? (DateTime?)Convert.ToDateTime(DataReader["NgayXN"]) : null;
                    data.KetQua = DataReader["KetQua"].ToString();
                    data.ART = DataReader.GetInt("ART");
                    data.ART_Ngay = DataReader["ART_Ngay"] != DBNull.Value ? (DateTime?)Convert.ToDateTime(DataReader["ART_Ngay"]) : null;
                    data.CPT = DataReader.GetInt("CPT");
                    data.CPT_Ngay = DataReader["CPT_Ngay"] != DBNull.Value ? (DateTime?)Convert.ToDateTime(DataReader["CPT_Ngay"]) : null;
                    data.HAIN_LPA = DataReader.GetInt("HAIN_LPA");
                    data.Xpert = DataReader.GetInt("Xpert");
                    data.KQKT_R = DataReader.GetInt("KQKT_R");
                    data.KQKT_H = DataReader.GetInt("KQKT_H");
                    data.KQKT_Khac = DataReader.GetInt("KQKT_Khac");
                    data.KQKT_GhiRo = DataReader["KQKT_GhiRo"].ToString();
                    data.HoiChans = JsonConvert.DeserializeObject<ObservableCollection<HoiChanLaoKhangThuoc>>(DataReader["HoiChans"].ToString());
                    data.QuaTrinhDieuTris = JsonConvert.DeserializeObject<ObservableCollection<QuaTrinhDieuTriLao>>(DataReader["QuaTrinhDieuTris"].ToString());
                    data.DungThuocHang2 = DataReader.GetInt("DungThuocHang2");
                    data.DungThuocHang2_Text = DataReader["DungThuocHang2_Text"].ToString();
                    data.TenThuocKhac_GhiRo = DataReader["TenThuocKhac_GhiRo"].ToString();
                    data.PhuLuc = DataReader["PhuLuc"].ToString();
                    data.SoiDomTrucTiep = JsonConvert.DeserializeObject<ObservableCollection<SoiDomNoiCay>>(DataReader["SoiDomTrucTiep"].ToString());
                    data.NuoiCay = JsonConvert.DeserializeObject<ObservableCollection<SoiDomNoiCay>>(DataReader["NuoiCay"].ToString());
                    data.KSD_Khac1 = DataReader["KSD_Khac1"].ToString();
                    data.KSD_Khac2 = DataReader["KSD_Khac2"].ToString();
                    data.KetQuaXNKSD = JsonConvert.DeserializeObject<ObservableCollection<KetQuaXNKhangSinhDo>>(DataReader["KetQuaXNKSD"].ToString());
                    data.PDDT_Khac1 = DataReader["PDDT_Khac1"].ToString();
                    data.PDDT_Khac2 = DataReader["PDDT_Khac2"].ToString();
                    data.PDDT_Khac3 = DataReader["PDDT_Khac3"].ToString();
                    data.PDDT_Khac4 = DataReader["PDDT_Khac4"].ToString();
                    data.PhacDoDieuTriLKT = JsonConvert.DeserializeObject<ObservableCollection<PhacDoDTLaoKhangThuoc>>(DataReader["PhacDoDieuTriLKT"].ToString());
                    string UongTiemThuoc = DataReader["UongTiemThuoc_1"].ToString();
                    if (DataReader["UongTiemThuoc_2"] != DBNull.Value)
                        UongTiemThuoc += DataReader["UongTiemThuoc_2"].ToString();
                    data.UongTiemThuoc = JsonConvert.DeserializeObject<ObservableCollection<UongTiemThuoc>>(UongTiemThuoc);
                    string UongTiemThuocTiepTheo = DataReader["UongTiemThuocTiepTheo_1"].ToString();
                    if (DataReader["UongTiemThuocTiepTheo_2"] != DBNull.Value)
                        UongTiemThuoc += DataReader["UongTiemThuocTiepTheo_2"].ToString();
                    data.UongTiemThuocTiepTheo = JsonConvert.DeserializeObject<ObservableCollection<UongTiemThuoc>>(UongTiemThuocTiepTheo);

                    data.NhanXet = DataReader["NhanXet"].ToString();
                    data.KetQuas = JsonConvert.DeserializeObject<ObservableCollection<KetQuaLaoKhangThuoc>>(DataReader["KetQuas"].ToString());
                    data.BacSy = DataReader["BacSy"].ToString();
                    data.MaBacSy = DataReader["MaBacSy"].ToString();


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
        public static bool InsertOrUpdate(MDB.MDBConnection MyConnection, ref PhieuDTBNLaoKhangThuoc ketQua)
        {
            try
            {
                string sql = @"INSERT INTO PhieuDTBNLaoKhangThuoc
                (
                    MAQUANLY,
                    MaBenhNhan,
                    NgayDKDTLKT,
                    SoDKDTLKT,
                    SoDKTrenETBM,
                    SoDKDTPDI,
                    DiaChi,
                    XaHuyen,
                    Tinh,
                    SoDT,
                    NgaySinh,
                    CanNangBanDau,
                    ChieuCao,
                    ViTri,
                    ViTriNgoaiPhoi_Text,
                    PhanLoaiBenhNhan,
                    PhanLoaiBenhNhan_Khac,
                    ChuyenDen,
                    TenDonViChuyen,
                    NgayChuyen,
                    NgayTiepNhan,
                    DaXNHIV,
                    NgayXN,
                    KetQua,
                    ART,
                    ART_Ngay,
                    CPT,
                    CPT_Ngay,
                    HAIN_LPA,
                    Xpert,
                    KQKT_R,
                    KQKT_H,
                    KQKT_Khac,
                    KQKT_GhiRo,
                    HoiChans,
                    QuaTrinhDieuTris,
                    DungThuocHang2,
                    DungThuocHang2_Text,
                    TenThuocKhac_GhiRo,
                    PhuLuc,
                    SoiDomTrucTiep,
                    NuoiCay,
                    KSD_Khac1,
                    KSD_Khac2,
                    KetQuaXNKSD,
                    PDDT_Khac1,
                    PDDT_Khac2,
                    PDDT_Khac3,
                    PDDT_Khac4,
                    PhacDoDieuTriLKT,
                    UongTiemThuoc_1,
                    UongTiemThuoc_2,
                    UongTiemThuocTiepTheo_1,
                    UongTiemThuocTiepTheo_2,
                    NhanXet,
                    KetQuas,
                    BacSy,
                    MaBacSy,
                    NGUOITAO,
                    NGUOISUA,
                    NGAYTAO,
                    NGAYSUA)  VALUES
                 (
				    :MAQUANLY,
                    :MaBenhNhan,
                    :NgayDKDTLKT,
                    :SoDKDTLKT,
                    :SoDKTrenETBM,
                    :SoDKDTPDI,
                    :DiaChi,
                    :XaHuyen,
                    :Tinh,
                    :SoDT,
                    :NgaySinh,
                    :CanNangBanDau,
                    :ChieuCao,
                    :ViTri,
                    :ViTriNgoaiPhoi_Text,
                    :PhanLoaiBenhNhan,
                    :PhanLoaiBenhNhan_Khac,
                    :ChuyenDen,
                    :TenDonViChuyen,
                    :NgayChuyen,
                    :NgayTiepNhan,
                    :DaXNHIV,
                    :NgayXN,
                    :KetQua,
                    :ART,
                    :ART_Ngay,
                    :CPT,
                    :CPT_Ngay,
                    :HAIN_LPA,
                    :Xpert,
                    :KQKT_R,
                    :KQKT_H,
                    :KQKT_Khac,
                    :KQKT_GhiRo,
                    :HoiChans,
                    :QuaTrinhDieuTris,
                    :DungThuocHang2,
                    :DungThuocHang2_Text,
                    :TenThuocKhac_GhiRo,
                    :PhuLuc,
                    :SoiDomTrucTiep,
                    :NuoiCay,
                    :KSD_Khac1,
                    :KSD_Khac2,
                    :KetQuaXNKSD,
                    :PDDT_Khac1,
                    :PDDT_Khac2,
                    :PDDT_Khac3,
                    :PDDT_Khac4,
                    :PhacDoDieuTriLKT,
                    :UongTiemThuoc_1,
                    :UongTiemThuoc_2,
                    :UongTiemThuocTiepTheo_1,
                    :UongTiemThuocTiepTheo_2,
                    :NhanXet,
                    :KetQuas,
                    :BacSy,
                    :MaBacSy,
                    :NGUOITAO,
                    :NGUOISUA,
                    :NGAYTAO,
                    :NGAYSUA
                 )  RETURNING ID INTO :ID";
                if (ketQua.ID != 0)
                {
                    sql = @"UPDATE PhieuDTBNLaoKhangThuoc SET 
                    MAQUANLY = :MAQUANLY,
                    MaBenhNhan = :MaBenhNhan,
                    NgayDKDTLKT=:NgayDKDTLKT,
                    SoDKDTLKT=:SoDKDTLKT,
                    SoDKTrenETBM=:SoDKTrenETBM,
                    SoDKDTPDI=:SoDKDTPDI,
                    DiaChi=:DiaChi,
                    XaHuyen=:XaHuyen,
                    Tinh=:Tinh,
                    SoDT=:SoDT,
                    NgaySinh=:NgaySinh,
                    CanNangBanDau=:CanNangBanDau,
                    ChieuCao=:ChieuCao,
                    ViTri=:ViTri,
                    ViTriNgoaiPhoi_Text=:ViTriNgoaiPhoi_Text,
                    PhanLoaiBenhNhan=:PhanLoaiBenhNhan,
                    PhanLoaiBenhNhan_Khac=:PhanLoaiBenhNhan_Khac,
                    ChuyenDen=:ChuyenDen,
                    TenDonViChuyen=:TenDonViChuyen,
                    NgayChuyen=:NgayChuyen,
                    NgayTiepNhan=:NgayTiepNhan,
                    DaXNHIV=:DaXNHIV,
                    NgayXN=:NgayXN,
                    KetQua=:KetQua,
                    ART=:ART,
                    ART_Ngay=:ART_Ngay,
                    CPT=:CPT,
                    CPT_Ngay=:CPT_Ngay,
                    HAIN_LPA=:HAIN_LPA,
                    Xpert=:Xpert,
                    KQKT_R=:KQKT_R,
                    KQKT_H=:KQKT_H,
                    KQKT_Khac=:KQKT_Khac,
                    KQKT_GhiRo=:KQKT_GhiRo,
                    HoiChans=:HoiChans,
                    QuaTrinhDieuTris=:QuaTrinhDieuTris,
                    DungThuocHang2=:DungThuocHang2,
                    DungThuocHang2_Text=:DungThuocHang2_Text,
                    TenThuocKhac_GhiRo=:TenThuocKhac_GhiRo,
                    PhuLuc=:PhuLuc,
                    SoiDomTrucTiep=:SoiDomTrucTiep,
                    NuoiCay=:NuoiCay,
                    KSD_Khac1=:KSD_Khac1,
                    KSD_Khac2=:KSD_Khac2,
                    KetQuaXNKSD=:KetQuaXNKSD,
                    PDDT_Khac1=:PDDT_Khac1,
                    PDDT_Khac2=:PDDT_Khac2,
                    PDDT_Khac3=:PDDT_Khac3,
                    PDDT_Khac4=:PDDT_Khac4,
                    PhacDoDieuTriLKT=:PhacDoDieuTriLKT,
                    UongTiemThuoc_1=:UongTiemThuoc_1,
                    UongTiemThuoc_2=:UongTiemThuoc_2,
                    UongTiemThuocTiepTheo_1=:UongTiemThuocTiepTheo_1,
                    UongTiemThuocTiepTheo_2=:UongTiemThuocTiepTheo_2,
                    NhanXet=:NhanXet,
                    KetQuas=:KetQuas,
                    BacSy=:BacSy,
                    MaBacSy=:MaBacSy,
                    NGUOISUA = :NGUOISUA,
                    NGAYSUA = :NGAYSUA
                    WHERE ID = " + ketQua.ID;
                }
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MAQUANLY", ketQua.MaQuanLy));
                Command.Parameters.Add(new MDB.MDBParameter("MaBenhNhan", ketQua.MaBenhNhan));
                Command.Parameters.Add(new MDB.MDBParameter("NgayDKDTLKT", ketQua.NgayDKDTLKT));
                Command.Parameters.Add(new MDB.MDBParameter("SoDKDTLKT", ketQua.SoDKDTLKT));
                Command.Parameters.Add(new MDB.MDBParameter("SoDKTrenETBM", ketQua.SoDKTrenETBM));
                Command.Parameters.Add(new MDB.MDBParameter("SoDKDTPDI", ketQua.SoDKDTPDI));
                Command.Parameters.Add(new MDB.MDBParameter("DiaChi", ketQua.DiaChi));
                Command.Parameters.Add(new MDB.MDBParameter("XaHuyen", ketQua.XaHuyen));
                Command.Parameters.Add(new MDB.MDBParameter("Tinh", ketQua.Tinh));
                Command.Parameters.Add(new MDB.MDBParameter("SoDT", ketQua.SoDT));
                Command.Parameters.Add(new MDB.MDBParameter("NgaySinh", ketQua.NgaySinh));
                Command.Parameters.Add(new MDB.MDBParameter("CanNangBanDau", ketQua.CanNangBanDau));
                Command.Parameters.Add(new MDB.MDBParameter("ChieuCao", ketQua.ChieuCao));
                Command.Parameters.Add(new MDB.MDBParameter("ViTri", ketQua.ViTri));
                Command.Parameters.Add(new MDB.MDBParameter("ViTriNgoaiPhoi_Text", ketQua.ViTriNgoaiPhoi_Text));
                Command.Parameters.Add(new MDB.MDBParameter("PhanLoaiBenhNhan", ketQua.PhanLoaiBenhNhan));
                Command.Parameters.Add(new MDB.MDBParameter("PhanLoaiBenhNhan_Khac", ketQua.PhanLoaiBenhNhan_Khac));
                Command.Parameters.Add(new MDB.MDBParameter("ChuyenDen", ketQua.ChuyenDen));
                Command.Parameters.Add(new MDB.MDBParameter("TenDonViChuyen", ketQua.TenDonViChuyen));
                Command.Parameters.Add(new MDB.MDBParameter("NgayChuyen", ketQua.NgayChuyen));
                Command.Parameters.Add(new MDB.MDBParameter("NgayTiepNhan", ketQua.NgayTiepNhan));
                Command.Parameters.Add(new MDB.MDBParameter("DaXNHIV", ketQua.DaXNHIV));
                Command.Parameters.Add(new MDB.MDBParameter("NgayXN", ketQua.NgayXN));
                Command.Parameters.Add(new MDB.MDBParameter("KetQua", ketQua.KetQua));
                Command.Parameters.Add(new MDB.MDBParameter("ART", ketQua.ART));
                Command.Parameters.Add(new MDB.MDBParameter("ART_Ngay", ketQua.ART_Ngay));
                Command.Parameters.Add(new MDB.MDBParameter("CPT", ketQua.CPT));
                Command.Parameters.Add(new MDB.MDBParameter("CPT_Ngay", ketQua.CPT_Ngay));
                Command.Parameters.Add(new MDB.MDBParameter("HAIN_LPA", ketQua.HAIN_LPA));
                Command.Parameters.Add(new MDB.MDBParameter("Xpert", ketQua.Xpert));
                Command.Parameters.Add(new MDB.MDBParameter("KQKT_R", ketQua.KQKT_R));
                Command.Parameters.Add(new MDB.MDBParameter("KQKT_H", ketQua.KQKT_H));
                Command.Parameters.Add(new MDB.MDBParameter("KQKT_Khac", ketQua.KQKT_Khac));
                Command.Parameters.Add(new MDB.MDBParameter("KQKT_GhiRo", ketQua.KQKT_GhiRo));
                Command.Parameters.Add(new MDB.MDBParameter("HoiChans", JsonConvert.SerializeObject(ketQua.HoiChans)));
                Command.Parameters.Add(new MDB.MDBParameter("QuaTrinhDieuTris", JsonConvert.SerializeObject(ketQua.QuaTrinhDieuTris)));
                Command.Parameters.Add(new MDB.MDBParameter("DungThuocHang2", ketQua.DungThuocHang2));
                Command.Parameters.Add(new MDB.MDBParameter("DungThuocHang2_Text", ketQua.DungThuocHang2_Text));
                Command.Parameters.Add(new MDB.MDBParameter("TenThuocKhac_GhiRo", ketQua.TenThuocKhac_GhiRo));
                Command.Parameters.Add(new MDB.MDBParameter("PhuLuc", ketQua.PhuLuc));
                Command.Parameters.Add(new MDB.MDBParameter("SoiDomTrucTiep", JsonConvert.SerializeObject(ketQua.SoiDomTrucTiep)));
                Command.Parameters.Add(new MDB.MDBParameter("NuoiCay", JsonConvert.SerializeObject(ketQua.NuoiCay)));
                Command.Parameters.Add(new MDB.MDBParameter("KSD_Khac1", ketQua.KSD_Khac1));
                Command.Parameters.Add(new MDB.MDBParameter("KSD_Khac2", ketQua.KSD_Khac2));
                Command.Parameters.Add(new MDB.MDBParameter("KetQuaXNKSD", JsonConvert.SerializeObject(ketQua.KetQuaXNKSD)));
                Command.Parameters.Add(new MDB.MDBParameter("PDDT_Khac1", ketQua.PDDT_Khac1));
                Command.Parameters.Add(new MDB.MDBParameter("PDDT_Khac2", ketQua.PDDT_Khac2));
                Command.Parameters.Add(new MDB.MDBParameter("PDDT_Khac3", ketQua.PDDT_Khac3));
                Command.Parameters.Add(new MDB.MDBParameter("PDDT_Khac4", ketQua.PDDT_Khac4));
                Command.Parameters.Add(new MDB.MDBParameter("PhacDoDieuTriLKT", JsonConvert.SerializeObject(ketQua.PhacDoDieuTriLKT)));

                List<string> listJson = Common.SplitByLength(JsonConvert.SerializeObject(ketQua.UongTiemThuoc), 3999).ToList();
                Command.Parameters.Add(new MDB.MDBParameter("UongTiemThuoc_1", listJson[0]));
                Command.Parameters.Add(new MDB.MDBParameter("UongTiemThuoc_2", listJson.Count > 1 ? listJson[1] : null));
                listJson = Common.SplitByLength(JsonConvert.SerializeObject(ketQua.UongTiemThuocTiepTheo), 3999).ToList();

                Command.Parameters.Add(new MDB.MDBParameter("UongTiemThuocTiepTheo_1", listJson[0]));
                Command.Parameters.Add(new MDB.MDBParameter("UongTiemThuocTiepTheo_2", listJson.Count > 1 ? listJson[1] : null));
                Command.Parameters.Add(new MDB.MDBParameter("NhanXet", ketQua.NhanXet));
                Command.Parameters.Add(new MDB.MDBParameter("KetQuas", JsonConvert.SerializeObject(ketQua.KetQuas)));
                Command.Parameters.Add(new MDB.MDBParameter("BacSy", ketQua.BacSy));
                Command.Parameters.Add(new MDB.MDBParameter("MaBacSy", ketQua.MaBacSy));

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
                string sql = "DELETE FROM PhieuDTBNLaoKhangThuoc WHERE ID = :ID";
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
                PhieuDTBNLaoKhangThuoc P
            WHERE
                ID = " + id;

            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
            MDB.MDBDataAdapter adt = new MDB.MDBDataAdapter(Command);
            var ds = new DataSet();

            adt.Fill(ds, "KQ");

            ObservableCollection<HoiChanLaoKhangThuoc> HoiChans = JsonConvert.DeserializeObject<ObservableCollection<HoiChanLaoKhangThuoc>>(ds.Tables[0].Rows[0]["HoiChans"].ToString());
            ObservableCollection<QuaTrinhDieuTriLao> QuaTrinhDieuTris = JsonConvert.DeserializeObject<ObservableCollection<QuaTrinhDieuTriLao>>(ds.Tables[0].Rows[0]["QuaTrinhDieuTris"].ToString());
            ObservableCollection<SoiDomNoiCay> SoiDomTrucTiep = JsonConvert.DeserializeObject<ObservableCollection<SoiDomNoiCay>>(ds.Tables[0].Rows[0]["SoiDomTrucTiep"].ToString());
            ObservableCollection<SoiDomNoiCay> NuoiCay = JsonConvert.DeserializeObject<ObservableCollection<SoiDomNoiCay>>(ds.Tables[0].Rows[0]["NuoiCay"].ToString());
            ObservableCollection<KetQuaXNKhangSinhDo> KetQuaXNKSD = JsonConvert.DeserializeObject<ObservableCollection<KetQuaXNKhangSinhDo>>(ds.Tables[0].Rows[0]["KetQuaXNKSD"].ToString());
            
            ObservableCollection<PhacDoDTLaoKhangThuoc> PhacDoDieuTriLKT = JsonConvert.DeserializeObject<ObservableCollection<PhacDoDTLaoKhangThuoc>>(ds.Tables[0].Rows[0]["PhacDoDieuTriLKT"].ToString());
           
            string UongTiemThuoc = ds.Tables[0].Rows[0]["UongTiemThuoc_1"].ToString();
            if (ds.Tables[0].Rows[0]["UongTiemThuoc_2"] != DBNull.Value)
                UongTiemThuoc += ds.Tables[0].Rows[0]["UongTiemThuoc_2"].ToString();
            ObservableCollection<UongTiemThuoc> lstUongTiemThuoc = JsonConvert.DeserializeObject<ObservableCollection<UongTiemThuoc>>(UongTiemThuoc);
            string UongTiemThuocTiepTheo = ds.Tables[0].Rows[0]["UongTiemThuocTiepTheo_1"].ToString();
            if (ds.Tables[0].Rows[0]["UongTiemThuocTiepTheo_2"] != DBNull.Value)
                UongTiemThuoc += ds.Tables[0].Rows[0]["UongTiemThuocTiepTheo_2"].ToString();
            ObservableCollection<UongTiemThuoc> lstUongTiemThuocTiepTheo = JsonConvert.DeserializeObject<ObservableCollection<UongTiemThuoc>>(UongTiemThuocTiepTheo);

            ObservableCollection<KetQuaLaoKhangThuoc> KetQuas = JsonConvert.DeserializeObject<ObservableCollection<KetQuaLaoKhangThuoc>>(ds.Tables[0].Rows[0]["KetQuas"].ToString());

            ds.Tables.Add(Common.ListToDataTable(HoiChans, "HoiChans"));
            ds.Tables.Add(Common.ListToDataTable(QuaTrinhDieuTris, "QuaTrinhDieuTris"));
            ds.Tables.Add(Common.ListToDataTable(SoiDomTrucTiep, "SoiDomTrucTiep"));
            ds.Tables.Add(Common.ListToDataTable(NuoiCay, "NuoiCay"));
            ds.Tables.Add(Common.ListToDataTable(KetQuaXNKSD, "KetQuaXNKSD"));
            ds.Tables.Add(Common.ListToDataTable(PhacDoDieuTriLKT, "PhacDoDieuTriLKT"));
            ds.Tables.Add(Common.ListToDataTable(lstUongTiemThuoc, "UongTiemThuoc"));
            ds.Tables.Add(Common.ListToDataTable(lstUongTiemThuocTiepTheo, "UongTiemThuocTiepTheo"));
            ds.Tables.Add(Common.ListToDataTable(KetQuas, "KetQuas"));

            ds.Tables[0].AddColumn("TenBenhNhan", typeof(string));
            ds.Tables[0].AddColumn("Tuoi", typeof(string));
            ds.Tables[0].AddColumn("NamSinh", typeof(string));
            ds.Tables[0].AddColumn("GioiTinh", typeof(int));
            ds.Tables[0].AddColumn("SOYTE", typeof(string));
            ds.Tables[0].AddColumn("BENHVIEN", typeof(string));
            ds.Tables[0].AddColumn("KHOA", typeof(string));

            ds.Tables[0].Rows[0]["TenBenhNhan"] = XemBenhAn._HanhChinhBenhNhan.TenBenhNhan;
            ds.Tables[0].Rows[0]["Tuoi"] = XemBenhAn._HanhChinhBenhNhan.Tuoi;
            ds.Tables[0].Rows[0]["NamSinh"] = XemBenhAn._HanhChinhBenhNhan.NgaySinh.HasValue ? XemBenhAn._HanhChinhBenhNhan.NgaySinh.Value.Year + "" : "";
            ds.Tables[0].Rows[0]["GioiTinh"] = (int)XemBenhAn._HanhChinhBenhNhan.GioiTinh;
            ds.Tables[0].Rows[0]["SOYTE"] = XemBenhAn._HanhChinhBenhNhan.SoYTe;
            ds.Tables[0].Rows[0]["BENHVIEN"] = XemBenhAn._HanhChinhBenhNhan.BenhVien;
            ds.Tables[0].Rows[0]["KHOA"] = XemBenhAn._ThongTinDieuTri.Khoa;

            return ds;
        }
    }
}
