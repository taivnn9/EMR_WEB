
using EMR.KyDienTu;
using System;
using System.Collections.Generic;
using System.Data;

namespace EMR_MAIN.DATABASE.Other
{
    public class PhieuKetQuaBase : ThongTinKy
    {

        [MoTaDuLieu("Mã định danh")]
		public decimal IDKetQua { get; set; }
        [MoTaDuLieu("Mã định danh")]
		public decimal IDPhieu { get; set; }
        public decimal LoaiPhieu { get; set; }
        [MoTaDuLieu("Mã quản lý: mã duy nhất trong 1 đợt khám chữa bệnh (kcb), không trùng giữa các đợt kcb khác nhau","",1)]
		public decimal MaQuanLy { get; set; }
        [MoTaDuLieu("Chẩn đoán bệnh")]
		public string ChanDoan { get; set; }
        [MoTaDuLieu("Mã bệnh nhân")]
		public string MaBenhNhan { get; set; }
        [MoTaDuLieu("Họ và tên bệnh nhân")]
		public string TenBenhNhan { get; set; }
        [MoTaDuLieu("Khoa")]
		public string Khoa { get; set; }
        [MoTaDuLieu("Mã khoa")]
		public string MaKhoa { get; set; }
        [MoTaDuLieu("Buồng")]
		public string Buong { get; set; }
        [MoTaDuLieu("Giường")]
		public string Giuong { get; set; }
        [MoTaDuLieu("Mã giường")]
		public string MaGiuong { get; set; }
        [MoTaDuLieu("Ngày tạo", null, 0, 0)]
		public DateTime NgayTao { get; set; }
        [MoTaDuLieu("Ngày sửa", null, 0, 0)]
		public DateTime NgaySua { get; set; }
        public int? FLgUse { get; set; }
        [MoTaDuLieu("Chọn", null, 0, 0)]
		public bool Chon { get; set; }
        //public string MaSoKyTen { get; set; }
        [MoTaDuLieu("Đã ký", null, 0, 0)]
		public bool DaKy { get; set; }
    }
    public class PhieuTraKetQuaTimTbl : PhieuKetQuaBase
    {
        public const string TableName = "PhieuTraKetQuaTim";
        public const string TablePrimaryKeyName = "IDKetqua ";
        [MoTaDuLieu("Địa chỉ nhà bệnh nhân")]
		public string DiaChi { get; set; }
        [MoTaDuLieu("Giới tính bệnh nhân")]
		public string GioiTinh { get; set; }
        [MoTaDuLieu("Mã bác sỹ điều trị")]
		public string MaBacSyDieuTri { get; set; }
        public string TenBacSyDieuTri { get; set; }
        public string MaBacSyThuThuat { get; set; }
        public string TenBacSyThuThuat { get; set; }
        public DateTime NgayThucHienTT { get; set; }
        public string Introducer { get; set; }
        public string DCCatheter { get; set; }
        public string DCWidewire { get; set; }
        public string DCSuperStiff { get; set; }
        public string DCSizingBalloon { get; set; }
        public string DCThuocCanQuang { get; set; }
        public string DCDelivery { get; set; }
        public string DCBitCo { get; set; }
        public string TTQTDuongVao { get; set; }
        public string TTQTTienTrinh { get; set; }
        public string TTQTAnhMaTaPath { get; set; }
        public float? TSCao { get; set; }
        public float? TSNang { get; set; }
        public float? TSBSA { get; set; }
        public float? TSHb { get; set; }
        public float? TSHct { get; set; }
        public float? TSCO { get; set; }
        public float? TSCL { get; set; }
        public float? TSQp { get; set; }
        public float? TSsp { get; set; }
        public float? TSQpPerQs { get; set; }
        public float? TSSVR { get; set; }
        public float? TSPVR { get; set; }
        public float? TSSVRPerPVR { get; set; }
        public float? TSTMCTApLuc { get; set; }
        public string TSTMCTBHOxy { get; set; }
        public string TSTMCTNhanXet { get; set; }
        public float? TSTMCDApLuc { get; set; }
        public string TSTMCDBHOxy { get; set; }
        public string TSTMCDNhanXet { get; set; }
        public float? TSNhiPhaiCaoApLuc { get; set; }
        public string TSNhiPhaiCaoBHOxy { get; set; }
        public string TSNhiPhaiCaoNhanXet { get; set; }
        public float? TSNhiPhaiGiuaApLuc { get; set; }
        public string TSNhiPhaiGiuaBHOxy { get; set; }
        public string TSNhiPhaiGiuaNhanXet { get; set; }
        public float? TSNhiPhaiThapApLuc { get; set; }
        public string TSNhiPhaiThapBHOxy { get; set; }
        public string TSNhiPhaiThapNhanXet { get; set; }
        public float? TSDuongRaTPApLuc { get; set; }
        public string TSDuongRaTPBHOxy { get; set; }
        public string TSDuongRaTPNhanXet { get; set; }
        public float? TSThatPhaiApLuc { get; set; }
        public string TSThatPhaiBHOxy { get; set; }
        public string TSThatPhaiNhanXet { get; set; }
        public float? TSThanDMPhoiApLuc { get; set; }
        public string TSThanDMPhoiBHOxy { get; set; }
        public string TSThanDMPhoiNhanXet { get; set; }
        public float? TSDMPhoiTraiApLuc { get; set; }
        public string TSDMPhoiTraiBHOxy { get; set; }
        public string TSDMPhoiTraiNhanXet { get; set; }
        public float? TSDMPhoiPhaiApLuc { get; set; }
        public string TSDMPhoiPhaiBHOxy { get; set; }
        public string TSDMPhoiPhaiNhanXet { get; set; }
        public float? TSThatTraiApLuc { get; set; }
        public string TSThatTraiBHOxy { get; set; }
        public string TSThatTraiNhanXet { get; set; }
        public float? TSDMChuApLuc { get; set; }
        public string TSDMChuBHOxy { get; set; }
        public string TSDMChuNhanXet { get; set; }
        public float? TSNhiTraiApLuc { get; set; }
        public string TSNhiTraiBHOxy { get; set; }
        public string TSNhiTraiNhanXet { get; set; }
        public string KetQuaChupBuongTM { get; set; }
        public int BienChungVaXuLy { get; set; }
        public string KetLuan { get; set; }
    }
    public class PhieuTraKetQuaDongMachTbl : PhieuKetQuaBase
    {
        public const string TableName = "PhieuTraKetQuaDongMach";
        public const string TablePrimaryKeyName = "IDKetqua ";
        [MoTaDuLieu("Địa chỉ nhà bệnh nhân")]
		public string DiaChi { get; set; }
        [MoTaDuLieu("Giới tính bệnh nhân")]
		public string GioiTinh { get; set; }
        [MoTaDuLieu("Mã bác sỹ điều trị")]
		public string MaBacSyDieuTri { get; set; }
        public string TenBacSyDieuTri { get; set; }
        public string MaBacSyThuThuat { get; set; }
        public string TenBacSyThuThuat { get; set; }
        public DateTime NgayThucHienTT { get; set; }
        public string Introducer { get; set; }
        public string DCCatheter { get; set; }
        public string DCGuidewire { get; set; }
        public string DCPigtail { get; set; }
        public string DCBongNong { get; set; }
        public string DCStent { get; set; }
        public string DCLoaiKhac{ get; set; }
        public string DCThuocCanQuang { get; set; }
        public string TTQTDuongVao { get; set; }
        public string TTQTTienTrinh { get; set; }
        public string TTQTAnhMaTaPath { get; set; }
        public string TraiDMCBung { get; set; }
        public string PhaiDMCBung { get; set; }
        public string TraiDMThan { get; set; }
        public string PhaiDMThan { get; set; }
        public string TraiChauGoc { get; set; }
        public string PhaiChauGoc { get; set; }
        public string TraiChauNgoai { get; set; }
        public string PhaiChauNgoai { get; set; }
        public string TraiChauTrong { get; set; }
        public string PhaiChauTrong { get; set; }
        public string TraiDuiChung { get; set; }
        public string PhaiDuiChung { get; set; }
        public string TraiDuiNong { get; set; }
        public string PhaiDuiNong { get; set; }
        public string TraiDuiSau { get; set; }
        public string PhaiDuiSau { get; set; }
        public string TraiKhoeo { get; set; }
        public string PhaiKhoeo { get; set; }
        public string TraiChayTruoc { get; set; }
        public string PhaiChayTruoc { get; set; }
        public string TraiChaySau { get; set; }
        public string PhaiChaySau { get; set; }
        public string TraiMac { get; set; }
        public string PhaiMac { get; set; }
        public string KetLuan { get; set; }
    }
    public class PhieuTraKetQuaDongMachCanhTbl : PhieuKetQuaBase
    {
        public const string TableName = "PhieuTraKetQuaDongMachCanh";
        public const string TablePrimaryKeyName = "IDKetqua ";
        [MoTaDuLieu("Địa chỉ nhà bệnh nhân")]
		public string DiaChi { get; set; }
        [MoTaDuLieu("Giới tính bệnh nhân")]
		public string GioiTinh { get; set; }
        [MoTaDuLieu("Mã bác sỹ điều trị")]
		public string MaBacSyDieuTri { get; set; }
        public string TenBacSyDieuTri { get; set; }
        public string MaBacSyThuThuat { get; set; }
        public string TenBacSyThuThuat { get; set; }
        public DateTime NgayThucHienTT { get; set; }
        public string Introducer { get; set; }
        public string DCCatheter { get; set; }
        public string DCGuidewire { get; set; }
        public string DCBongNong { get; set; }
        public string DCBomApLuc { get; set; }
        public string DCStent { get; set; }
        public string DCLoaiKhac { get; set; }
        public string DCThuocCanQuang { get; set; }
        public string TTQTDuongVao { get; set; }
        public string TTQTTienTrinh { get; set; }
        public string TTQTAnhMaTaPath { get; set; }
        public string KQDMCChungP { get; set; }
        public string KQDMCTrongP { get; set; }
        public string KQDMCNgoaiP { get; set; }
        public string KQDMCChungT { get; set; }
        public string KQDMCTrongT { get; set; }
        public string KQDMCNgoaiT { get; set; }
        public string KQDMDotSong { get; set; }
        public string ViTriCanThiep { get; set; }
        public string TenThuThuat { get; set; }
        public string KetQua { get; set; }
        public string NhanXetKhac { get; set; }
        public int BienChungVaXuLi { get; set; }
        public string KetLuan { get; set; }
    }
    public class PhieuTraKetQuaDongMachVanhTbl : PhieuKetQuaBase
    {
        public const string TableName = "PhieuTraKetQuaDongMachVanh";
        public const string TablePrimaryKeyName = "IDKetqua ";
        [MoTaDuLieu("Địa chỉ nhà bệnh nhân")]
		public string DiaChi { get; set; }
        [MoTaDuLieu("Giới tính bệnh nhân")]
		public string GioiTinh { get; set; }
        [MoTaDuLieu("Mã bác sỹ điều trị")]
		public string MaBacSyDieuTri { get; set; }
        public string TenBacSyDieuTri { get; set; }
        public string MaBacSyThuThuat { get; set; }
        public string TenBacSyThuThuat { get; set; }
        public DateTime NgayThucHienTT { get; set; }
        public string Introducer { get; set; }
        public string DCLoaiKhac { get; set; }
        public string DCPhai { get; set; }
        public string DCPigtail { get; set; }
        public string DCThuocCanQuang { get; set; }
        public string TTQTDuongVao { get; set; }
        public string TTQTTienTrinh { get; set; }
        public string TTQTAnhMaTaPath { get; set; }
        public string KQDMCVanhTrai { get; set; }
        public string KQDMCLienThatTruoc { get; set; }
        public string KQDMMu { get; set; }
        public string KQDMVanhPhai { get; set; }
        public string KQCBTEF { get; set; }
        public string KQCBTRoiLoan { get; set; }
        public string ThamDoKemTheo { get; set; }
        public int BienChungVaXuLi { get; set; }
        public string NhanXetKhac { get; set; }
        public string KetLuan { get; set; }
    }
    public class DanhSachPhieuKetQuaFunc
    {

        //public static PhieuTraKetQuaTimTbl SelectRecord(decimal MaQuanLy, decimal loaiPhieu)
        //{
        //    try
        //    {
        //        {
        //            PhieuTraKetQuaTimTbl obj = new PhieuTraKetQuaTimTbl();
        //            string sql = @"SELECT t.*
        //            FROM PhieuTraKetQuaTim t
        //            WHERE t.MaQuanLy = :MaQuanLy AND t.LoaiPhieu = :LoaiPhieu ORDER BY t.NgayTao DESC";
        //            MDB.MDBCommand Command = new MDB.MDBCommand(sql, XemBenhAn.MyConnection);
        //            Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", MaQuanLy));
        //            Command.Parameters.Add(new MDB.MDBParameter("LoaiPhieu", loaiPhieu));
        //            MDB.MDBDataReader DataReader = Command.ExecuteReader();
        //            while (DataReader.Read())
        //            {
        //                obj.IDKetQua = Common.ConDB_Decimal(DataReader["IDKetqua"]);
        //                obj.LoaiPhieu = Common.ConDB_Int(DataReader["LoaiPhieu"]);
        //                obj.IDPhieu = Common.ConDB_Decimal(DataReader["IDPhieu"]);
        //                obj.MaQuanLy = Common.ConDB_Decimal(DataReader["MaQuanLy"]);
        //                obj.ChanDoan = Common.ConDBNull(DataReader["ChanDoan"]);
        //                obj.MaBenhNhan = Common.ConDBNull(DataReader["MaBenhNhan"]);
        //                obj.TenBenhNhan = Common.ConDBNull(DataReader["TenBenhNhan"]);
        //                obj.Khoa = Common.ConDBNull(DataReader["Khoa"]);
        //                obj.MaKhoa = Common.ConDBNull(DataReader["MaKhoa"]);
        //                obj.Buong = Common.ConDBNull(DataReader["Buong"]);
        //                obj.Giuong = Common.ConDBNull(DataReader["Giuong"]);
        //                obj.MaGiuong = Common.ConDBNull(DataReader["MaGiuong"]);
        //                obj.NgayTao = Common.ConDB_DateTime(DataReader["NgayTao"]);
        //                obj.NgaySua = Common.ConDB_DateTime(DataReader["NgaySua"]);
        //                obj.FLgUse = Common.ConDB_Int(DataReader["FLgUse"]);
        //                obj.MaSoKyTen = Common.ConDBNull(DataReader["MaSoKyTen"]);
        //                obj.DiaChi = Common.ConDBNull(DataReader["DiaChi"]);
        //                obj.GioiTinh = Common.ConDBNull(DataReader["GioiTinh"]);
        //                obj.MaBacSyDieuTri = Common.ConDBNull(DataReader["MaBacSyDieuTri"]);
        //                obj.TenBacSyDieuTri = Common.ConDBNull(DataReader["TenBacSyDieuTri"]);
        //                obj.MaBacSyThuThuat = Common.ConDBNull(DataReader["MaBacSyThuThuat"]);
        //                obj.TenBacSyThuThuat = Common.ConDBNull(DataReader["TenBacSyThuThuat"]);
        //                obj.NgayThucHienTT = Common.ConDB_DateTime(DataReader["NgayThucHienTT"]);
        //                obj.Introducer = Common.ConDBNull(DataReader["Introducer"]);
        //                obj.DCCatheter = Common.ConDBNull(DataReader["DCCatheter"]);
        //                obj.DCWidewire = Common.ConDBNull(DataReader["DCWidewire"]);
        //                obj.DCSuperStiff = Common.ConDBNull(DataReader["DCSuperStiff"]);
        //                obj.DCSizingBalloon = Common.ConDBNull(DataReader["DCSizingBalloon"]);
        //                obj.DCThuocCanQuang = Common.ConDBNull(DataReader["DCThuocCanQuang"]);
        //                obj.DCDelivery = Common.ConDBNull(DataReader["DCDelivery"]);
        //                obj.DCBitCo = Common.ConDBNull(DataReader["DCBitCo"]);
        //                obj.TTQTDuongVao = Common.ConDBNull(DataReader["TTQTDuongVao"]);
        //                obj.TTQTTienTrinh = Common.ConDBNull(DataReader["TTQTTienTrinh"]);
        //                obj.TTQTAnhMaTaPath = Common.ConDBNull(DataReader["TTQTAnhMaTaPath"]);
        //                obj.TSCao = Common.ConDBNull_float(DataReader["TSCao"]);
        //                obj.TSNang = Common.ConDBNull_float(DataReader["TSNang"]);
        //                obj.TSBSA = Common.ConDBNull_float(DataReader["TSBSA"]);
        //                obj.TSHb = Common.ConDBNull_float(DataReader["TSHb"]);
        //                obj.TSHct = Common.ConDBNull_float(DataReader["TSHct"]);
        //                obj.TSCO = Common.ConDBNull_float(DataReader["TSCO"]);
        //                obj.TSCL = Common.ConDBNull_float(DataReader["TSCL"]);
        //                obj.TSQp = Common.ConDBNull_float(DataReader["TSQp"]);
        //                obj.TSsp = Common.ConDBNull_float(DataReader["TSsp"]);
        //                obj.TSQpPerQs = Common.ConDBNull_float(DataReader["TSQpPerQs"]);
        //                obj.TSSVR = Common.ConDBNull_float(DataReader["TSSVR"]);
        //                obj.TSPVR = Common.ConDBNull_float(DataReader["TSPVR"]);
        //                obj.TSSVRPerPVR = Common.ConDBNull_float(DataReader["TSSVRPerPVR"]);
        //                obj.TSTMCTApLuc = Common.ConDBNull_float(DataReader["TSTMCTApLuc"]);
        //                obj.TSTMCTBHOxy = Common.ConDBNull(DataReader["TSTMCTBHOxy"]);
        //                obj.TSTMCTNhanXet = Common.ConDBNull(DataReader["TSTMCTNhanXet"]);
        //                obj.TSTMCDApLuc = Common.ConDBNull_float(DataReader["TSTMCDApLuc"]);
        //                obj.TSTMCDBHOxy = Common.ConDBNull(DataReader["TSTMCDBHOxy"]);
        //                obj.TSTMCDNhanXet = Common.ConDBNull(DataReader["TSTMCDNhanXet"]);
        //                obj.TSNhiPhaiCaoApLuc = Common.ConDBNull_float(DataReader["TSNhiPhaiCaoApLuc"]);
        //                obj.TSNhiPhaiCaoBHOxy = Common.ConDBNull(DataReader["TSNhiPhaiCaoBHOxy"]);
        //                obj.TSNhiPhaiCaoNhanXet = Common.ConDBNull(DataReader["TSNhiPhaiCaoNhanXet"]);
        //                obj.TSNhiPhaiGiuaApLuc = Common.ConDBNull_float(DataReader["TSNhiPhaiGiuaApLuc"]);
        //                obj.TSNhiPhaiGiuaBHOxy = Common.ConDBNull(DataReader["TSNhiPhaiGiuaBHOxy"]);
        //                obj.TSNhiPhaiGiuaNhanXet = Common.ConDBNull(DataReader["TSNhiPhaiGiuaNhanXet"]);
        //                obj.TSNhiPhaiThapApLuc = Common.ConDBNull_float(DataReader["TSNhiPhaiThapApLuc"]);
        //                obj.TSNhiPhaiThapBHOxy = Common.ConDBNull(DataReader["TSNhiPhaiThapBHOxy"]);
        //                obj.TSNhiPhaiThapNhanXet = Common.ConDBNull(DataReader["TSNhiPhaiThapNhanXet"]);
        //                obj.TSDuongRaTPApLuc = Common.ConDBNull_float(DataReader["TSDuongRaTPApLuc"]);
        //                obj.TSDuongRaTPBHOxy = Common.ConDBNull(DataReader["TSDuongRaTPBHOxy"]);
        //                obj.TSDuongRaTPNhanXet = Common.ConDBNull(DataReader["TSDuongRaTPNhanXet"]);
        //                obj.TSThatPhaiApLuc = Common.ConDBNull_float(DataReader["TSThatPhaiApLuc"]);
        //                obj.TSThatPhaiBHOxy = Common.ConDBNull(DataReader["TSThatPhaiBHOxy"]);
        //                obj.TSThatPhaiNhanXet = Common.ConDBNull(DataReader["TSThatPhaiNhanXet"]);
        //                obj.TSThanDMPhoiApLuc = Common.ConDBNull_float(DataReader["TSThanDMPhoiApLuc"]);
        //                obj.TSThanDMPhoiBHOxy = Common.ConDBNull(DataReader["TSThanDMPhoiBHOxy"]);
        //                obj.TSThanDMPhoiNhanXet = Common.ConDBNull(DataReader["TSThanDMPhoiNhanXet"]);
        //                obj.TSDMPhoiTraiApLuc = Common.ConDBNull_float(DataReader["TSDMPhoiTraiApLuc"]);
        //                obj.TSDMPhoiTraiBHOxy = Common.ConDBNull(DataReader["TSDMPhoiTraiBHOxy"]);
        //                obj.TSDMPhoiTraiNhanXet = Common.ConDBNull(DataReader["TSDMPhoiTraiNhanXet"]);
        //                obj.TSDMPhoiPhaiApLuc = Common.ConDBNull_float(DataReader["TSDMPhoiPhaiApLuc"]);
        //                obj.TSDMPhoiPhaiBHOxy = Common.ConDBNull(DataReader["TSDMPhoiPhaiBHOxy"]);
        //                obj.TSDMPhoiPhaiNhanXet = Common.ConDBNull(DataReader["TSDMPhoiPhaiNhanXet"]);
        //                obj.TSThatTraiApLuc = Common.ConDBNull_float(DataReader["TSThatTraiApLuc"]);
        //                obj.TSThatTraiBHOxy = Common.ConDBNull(DataReader["TSThatTraiBHOxy"]);
        //                obj.TSThatTraiNhanXet = Common.ConDBNull(DataReader["TSThatTraiNhanXet"]);
        //                obj.TSDMChuApLuc = Common.ConDBNull_float(DataReader["TSDMChuApLuc"]);
        //                obj.TSDMChuBHOxy = Common.ConDBNull(DataReader["TSDMChuBHOxy"]);
        //                obj.TSDMChuNhanXet = Common.ConDBNull(DataReader["TSDMChuNhanXet"]);
        //                obj.TSNhiTraiApLuc = Common.ConDBNull_float(DataReader["TSNhiTraiApLuc"]);
        //                obj.TSNhiTraiBHOxy = Common.ConDBNull(DataReader["TSNhiTraiBHOxy"]);
        //                obj.TSNhiTraiNhanXet = Common.ConDBNull(DataReader["TSNhiTraiNhanXet"]);
        //                obj.KetQuaChupBuongTM = Common.ConDBNull(DataReader["KetQuaChupBuongTM"]);
        //                obj.BienChungVaXuLy = Common.ConDB_Int(DataReader["BienChungVaXuLy"]);
        //                obj.KetLuan = Common.ConDBNull(DataReader["KetLuan"]);
        //                obj.MaSoKyTen = Common.ConDBNull(DataReader["MaSoKyTen"]);
        //                obj.DaKy = !string.IsNullOrEmpty(obj.MaSoKyTen) ? true : false;
        //            }

        //            return obj;
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //}
        public static List<PhieuTraKetQuaTimTbl> Select(MDB.MDBConnection MyConnection,decimal MaQuanLy, decimal loaiPhieu)
        {
            try
            {
                {
                    List<PhieuTraKetQuaTimTbl> listResult = new List<PhieuTraKetQuaTimTbl>();
                    string sql = @"SELECT t.*
                    FROM PhieuTraKetQuaTim t";

                    if (MaQuanLy > 0)
                    {
                        sql = sql + " WHERE t.MaQuanLy = " + MaQuanLy.ToString() + " AND t.LoaiPhieu = :LoaiPhieu ORDER BY t.NgayTao DESC";
                    }
                    else
                    {
                        sql = sql + " WHERE  t.LoaiPhieu = :LoaiPhieu ORDER BY t.NgayTao DESC";
                    }
                    MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
                    Command.Parameters.Add(new MDB.MDBParameter("LoaiPhieu", loaiPhieu));
                    MDB.MDBDataReader DataReader = Command.ExecuteReader();
                    while (DataReader.Read())
                    {
                        var obj = new PhieuTraKetQuaTimTbl();
                        obj.IDKetQua = Common.ConDB_Decimal(DataReader["IDKetqua"]);
                        obj.LoaiPhieu = Common.ConDB_Decimal(DataReader["LoaiPhieu"]);
                        obj.IDPhieu = Common.ConDB_Decimal(DataReader["IDPhieu"]);
                        obj.MaQuanLy = Common.ConDB_Decimal(DataReader["MaQuanLy"]);
                        obj.ChanDoan = Common.ConDBNull(DataReader["ChanDoan"]);
                        obj.MaBenhNhan = Common.ConDBNull(DataReader["MaBenhNhan"]);
                        obj.TenBenhNhan = Common.ConDBNull(DataReader["TenBenhNhan"]);
                        obj.Khoa = Common.ConDBNull(DataReader["Khoa"]);
                        obj.MaKhoa = Common.ConDBNull(DataReader["MaKhoa"]);
                        obj.Buong = Common.ConDBNull(DataReader["Buong"]);
                        obj.Giuong = Common.ConDBNull(DataReader["Giuong"]);
                        obj.MaGiuong = Common.ConDBNull(DataReader["MaGiuong"]);
                        obj.NgayTao = Common.ConDB_DateTime(DataReader["NgayTao"]);
                        obj.NgaySua = Common.ConDB_DateTime(DataReader["NgaySua"]);
                        obj.FLgUse = Common.ConDB_Int(DataReader["FLgUse"]);
                        obj.MaSoKy = Common.ConDBNull(DataReader["MaSoKyTen"]);
                        obj.DiaChi = Common.ConDBNull(DataReader["DiaChi"]);
                        obj.GioiTinh = Common.ConDBNull(DataReader["GioiTinh"]);
                        obj.MaBacSyDieuTri = Common.ConDBNull(DataReader["MaBacSyDieuTri"]);
                        obj.TenBacSyDieuTri = Common.ConDBNull(DataReader["TenBacSyDieuTri"]);
                        obj.MaBacSyThuThuat = Common.ConDBNull(DataReader["MaBacSyThuThuat"]);
                        obj.TenBacSyThuThuat = Common.ConDBNull(DataReader["TenBacSyThuThuat"]);
                        obj.NgayThucHienTT = Common.ConDB_DateTime(DataReader["NgayThucHienTT"]);
                        obj.Introducer = Common.ConDBNull(DataReader["Introducer"]);
                        obj.DCCatheter = Common.ConDBNull(DataReader["DCCatheter"]);
                        obj.DCWidewire = Common.ConDBNull(DataReader["DCWidewire"]);
                        obj.DCSuperStiff = Common.ConDBNull(DataReader["DCSuperStiff"]);
                        obj.DCSizingBalloon = Common.ConDBNull(DataReader["DCSizingBalloon"]);
                        obj.DCThuocCanQuang = Common.ConDBNull(DataReader["DCThuocCanQuang"]);
                        obj.DCDelivery = Common.ConDBNull(DataReader["DCDelivery"]);
                        obj.DCBitCo = Common.ConDBNull(DataReader["DCBitCo"]);
                        obj.TTQTDuongVao = Common.ConDBNull(DataReader["TTQTDuongVao"]);
                        obj.TTQTTienTrinh = Common.ConDBNull(DataReader["TTQTTienTrinh"]);
                        obj.TTQTAnhMaTaPath = Common.ConDBNull(DataReader["TTQTAnhMaTaPath"]);
                        obj.TSCao = Common.ConDBNull_float(DataReader["TSCao"]);
                        obj.TSNang = Common.ConDBNull_float(DataReader["TSNang"]);
                        obj.TSBSA = Common.ConDBNull_float(DataReader["TSBSA"]);
                        obj.TSHb = Common.ConDBNull_float(DataReader["TSHb"]);
                        obj.TSHct = Common.ConDBNull_float(DataReader["TSHct"]);
                        obj.TSCO = Common.ConDBNull_float(DataReader["TSCO"]);
                        obj.TSCL = Common.ConDBNull_float(DataReader["TSCL"]);
                        obj.TSQp = Common.ConDBNull_float(DataReader["TSQp"]);
                        obj.TSsp = Common.ConDBNull_float(DataReader["TSsp"]);
                        obj.TSQpPerQs = Common.ConDBNull_float(DataReader["TSQpPerQs"]);
                        obj.TSSVR = Common.ConDBNull_float(DataReader["TSSVR"]);
                        obj.TSPVR = Common.ConDBNull_float(DataReader["TSPVR"]);
                        obj.TSSVRPerPVR = Common.ConDBNull_float(DataReader["TSSVRPerPVR"]);
                        obj.TSTMCTApLuc = Common.ConDBNull_float(DataReader["TSTMCTApLuc"]);
                        obj.TSTMCTBHOxy = Common.ConDBNull(DataReader["TSTMCTBHOxy"]);
                        obj.TSTMCTNhanXet = Common.ConDBNull(DataReader["TSTMCTNhanXet"]);
                        obj.TSTMCDApLuc = Common.ConDBNull_float(DataReader["TSTMCDApLuc"]);
                        obj.TSTMCDBHOxy = Common.ConDBNull(DataReader["TSTMCDBHOxy"]);
                        obj.TSTMCDNhanXet = Common.ConDBNull(DataReader["TSTMCDNhanXet"]);
                        obj.TSNhiPhaiCaoApLuc = Common.ConDBNull_float(DataReader["TSNhiPhaiCaoApLuc"]);
                        obj.TSNhiPhaiCaoBHOxy = Common.ConDBNull(DataReader["TSNhiPhaiCaoBHOxy"]);
                        obj.TSNhiPhaiCaoNhanXet = Common.ConDBNull(DataReader["TSNhiPhaiCaoNhanXet"]);
                        obj.TSNhiPhaiGiuaApLuc = Common.ConDBNull_float(DataReader["TSNhiPhaiGiuaApLuc"]);
                        obj.TSNhiPhaiGiuaBHOxy = Common.ConDBNull(DataReader["TSNhiPhaiGiuaBHOxy"]);
                        obj.TSNhiPhaiGiuaNhanXet = Common.ConDBNull(DataReader["TSNhiPhaiGiuaNhanXet"]);
                        obj.TSNhiPhaiThapApLuc = Common.ConDBNull_float(DataReader["TSNhiPhaiThapApLuc"]);
                        obj.TSNhiPhaiThapBHOxy = Common.ConDBNull(DataReader["TSNhiPhaiThapBHOxy"]);
                        obj.TSNhiPhaiThapNhanXet = Common.ConDBNull(DataReader["TSNhiPhaiThapNhanXet"]);
                        obj.TSDuongRaTPApLuc = Common.ConDBNull_float(DataReader["TSDuongRaTPApLuc"]);
                        obj.TSDuongRaTPBHOxy = Common.ConDBNull(DataReader["TSDuongRaTPBHOxy"]);
                        obj.TSDuongRaTPNhanXet = Common.ConDBNull(DataReader["TSDuongRaTPNhanXet"]);
                        obj.TSThatPhaiApLuc = Common.ConDBNull_float(DataReader["TSThatPhaiApLuc"]);
                        obj.TSThatPhaiBHOxy = Common.ConDBNull(DataReader["TSThatPhaiBHOxy"]);
                        obj.TSThatPhaiNhanXet = Common.ConDBNull(DataReader["TSThatPhaiNhanXet"]);
                        obj.TSThanDMPhoiApLuc = Common.ConDBNull_float(DataReader["TSThanDMPhoiApLuc"]);
                        obj.TSThanDMPhoiBHOxy = Common.ConDBNull(DataReader["TSThanDMPhoiBHOxy"]);
                        obj.TSThanDMPhoiNhanXet = Common.ConDBNull(DataReader["TSThanDMPhoiNhanXet"]);
                        obj.TSDMPhoiTraiApLuc = Common.ConDBNull_float(DataReader["TSDMPhoiTraiApLuc"]);
                        obj.TSDMPhoiTraiBHOxy = Common.ConDBNull(DataReader["TSDMPhoiTraiBHOxy"]);
                        obj.TSDMPhoiTraiNhanXet = Common.ConDBNull(DataReader["TSDMPhoiTraiNhanXet"]);
                        obj.TSDMPhoiPhaiApLuc = Common.ConDBNull_float(DataReader["TSDMPhoiPhaiApLuc"]);
                        obj.TSDMPhoiPhaiBHOxy = Common.ConDBNull(DataReader["TSDMPhoiPhaiBHOxy"]);
                        obj.TSDMPhoiPhaiNhanXet = Common.ConDBNull(DataReader["TSDMPhoiPhaiNhanXet"]);
                        obj.TSThatTraiApLuc = Common.ConDBNull_float(DataReader["TSThatTraiApLuc"]);
                        obj.TSThatTraiBHOxy = Common.ConDBNull(DataReader["TSThatTraiBHOxy"]);
                        obj.TSThatTraiNhanXet = Common.ConDBNull(DataReader["TSThatTraiNhanXet"]);
                        obj.TSDMChuApLuc = Common.ConDBNull_float(DataReader["TSDMChuApLuc"]);
                        obj.TSDMChuBHOxy = Common.ConDBNull(DataReader["TSDMChuBHOxy"]);
                        obj.TSDMChuNhanXet = Common.ConDBNull(DataReader["TSDMChuNhanXet"]);
                        obj.TSNhiTraiApLuc = Common.ConDBNull_float(DataReader["TSNhiTraiApLuc"]);
                        obj.TSNhiTraiBHOxy = Common.ConDBNull(DataReader["TSNhiTraiBHOxy"]);
                        obj.TSNhiTraiNhanXet = Common.ConDBNull(DataReader["TSNhiTraiNhanXet"]);
                        obj.KetQuaChupBuongTM = Common.ConDBNull(DataReader["KetQuaChupBuongTM"]);
                        obj.BienChungVaXuLy = Common.ConDB_Int(DataReader["BienChungVaXuLy"]);
                        obj.KetLuan = Common.ConDBNull(DataReader["KetLuan"]);
                        obj.MaSoKy = Common.ConDBNull(DataReader["MaSoKyTen"]);
                        obj.DaKy = !string.IsNullOrEmpty(obj.MaSoKy) ? true : false;
                        listResult.Add(obj);
                    }

                    return listResult;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static DataSet GetDataSet(MDB.MDBConnection MyConnection, decimal IDBienBan, decimal typ)
        {
            string sql = @"SELECT P.*, T.SoNhapVien,
                H.TUOI,H.SoYTe, H.BENHVIEN
                  FROM PhieuTraKetQuaTim P 
                Left JOIN THONGTINDIEUTRI T ON P.MAQUANLY = T.MAQUANLY
                Left JOIN HANHCHINHBENHNHAN H ON T.MABENHNHAN = H.MABENHNHAN
                  where IDKetqua  = :IDKetqua  and LoaiPhieu = :LoaiPhieu";
            MDB.MDBCommand Command;
            MDB.MDBDataAdapter adt;
            using (Command = new MDB.MDBCommand(sql, MyConnection))
            {
                Command.Parameters.Add(new MDB.MDBParameter("IDKetqua ", IDBienBan));
                Command.Parameters.Add(new MDB.MDBParameter("LoaiPhieu", typ));
                adt = new MDB.MDBDataAdapter(Command);
            }
            var ds = new DataSet();
            adt.Fill(ds, "TBL");
            return ds;
        }
        public static bool InsertOrUpdate(MDB.MDBConnection oracleConnection, PhieuTraKetQuaTimTbl obj, ref bool isUpdate)
        {
            try
            {
                string sql = @"SELECT COUNT(*) RECNUM FROM PhieuTraKetQuaTim WHERE IDKetqua  = :IDKetqua   and LoaiPhieu = :LoaiPhieu";
                MDB.MDBCommand oracleCommand;
                int rowCount = 0;
                int nRecord = 0;
                decimal IDphieuNext = 0;
                oracleCommand = new MDB.MDBCommand(sql, oracleConnection);
                oracleCommand.Parameters.Add("IDKetqua ", obj.IDKetQua);
                oracleCommand.Parameters.Add("LoaiPhieu", obj.LoaiPhieu);
                MDB.MDBDataReader oracleDataReader = oracleCommand.ExecuteReader();
                while (oracleDataReader.Read())
                {
                    rowCount = int.Parse(oracleDataReader["RECNUM"].ToString());
                }


                if (rowCount > 0)
                {
                    isUpdate = true;
                    sql = "update PhieuTraKetQuaTim set MaQuanLy= :MaQuanLy,ChanDoan= :ChanDoan,MaBenhNhan= :MaBenhNhan,TenBenhNhan= :TenBenhNhan,Khoa= :Khoa,MaKhoa= :MaKhoa, Buong= :Buong,Giuong= :Giuong,MaGiuong= :MaGiuong,NgayTao= :NgayTao,NgaySua= :NgaySua,FLgUse= :FLgUse,MaSoKyTen= :MaSoKyTen,DiaChi= :DiaChi,GioiTinh= :GioiTinh,MaBacSyDieuTri= :MaBacSyDieuTri,TenBacSyDieuTri= :TenBacSyDieuTri,MaBacSyThuThuat= :MaBacSyThuThuat,TenBacSyThuThuat= :TenBacSyThuThuat,NgayThucHienTT= :NgayThucHienTT,Introducer= :Introducer,DCCatheter= :DCCatheter,DCWidewire= :DCWidewire,DCSuperStiff= :DCSuperStiff,DCSizingBalloon= :DCSizingBalloon,DCThuocCanQuang= :DCThuocCanQuang,DCDelivery= :DCDelivery,DCBitCo= :DCBitCo,TTQTDuongVao= :TTQTDuongVao,TTQTTienTrinh= :TTQTTienTrinh,TTQTAnhMaTaPath= :TTQTAnhMaTaPath,TSCao= :TSCao,TSNang= :TSNang,TSBSA= :TSBSA,TSHb= :TSHb,TSHct= :TSHct,TSCO= :TSCO,TSCL= :TSCL,TSQp= :TSQp,TSsp= :TSsp,TSQpPerQs= :TSQpPerQs,TSSVR= :TSSVR,TSPVR= :TSPVR,TSSVRPerPVR= :TSSVRPerPVR,TSTMCTApLuc= :TSTMCTApLuc,TSTMCTBHOxy= :TSTMCTBHOxy,TSTMCTNhanXet= :TSTMCTNhanXet,TSTMCDApLuc= :TSTMCDApLuc,TSTMCDBHOxy= :TSTMCDBHOxy,TSTMCDNhanXet= :TSTMCDNhanXet,TSNhiPhaiCaoApLuc= :TSNhiPhaiCaoApLuc,TSNhiPhaiCaoBHOxy= :TSNhiPhaiCaoBHOxy,TSNhiPhaiCaoNhanXet= :TSNhiPhaiCaoNhanXet,TSNhiPhaiGiuaApLuc= :TSNhiPhaiGiuaApLuc,TSNhiPhaiGiuaBHOxy= :TSNhiPhaiGiuaBHOxy,TSNhiPhaiGiuaNhanXet= :TSNhiPhaiGiuaNhanXet,TSNhiPhaiThapApLuc= :TSNhiPhaiThapApLuc,TSNhiPhaiThapBHOxy= :TSNhiPhaiThapBHOxy,TSNhiPhaiThapNhanXet= :TSNhiPhaiThapNhanXet,TSDuongRaTPApLuc= :TSDuongRaTPApLuc,TSDuongRaTPBHOxy= :TSDuongRaTPBHOxy,TSDuongRaTPNhanXet= :TSDuongRaTPNhanXet,TSThatPhaiApLuc= :TSThatPhaiApLuc,TSThatPhaiBHOxy= :TSThatPhaiBHOxy,TSThatPhaiNhanXet= :TSThatPhaiNhanXet,TSThanDMPhoiApLuc= :TSThanDMPhoiApLuc,TSThanDMPhoiBHOxy= :TSThanDMPhoiBHOxy,TSThanDMPhoiNhanXet= :TSThanDMPhoiNhanXet,TSDMPhoiTraiApLuc= :TSDMPhoiTraiApLuc,TSDMPhoiTraiBHOxy= :TSDMPhoiTraiBHOxy,TSDMPhoiTraiNhanXet= :TSDMPhoiTraiNhanXet,TSDMPhoiPhaiApLuc= :TSDMPhoiPhaiApLuc,TSDMPhoiPhaiBHOxy= :TSDMPhoiPhaiBHOxy,TSDMPhoiPhaiNhanXet= :TSDMPhoiPhaiNhanXet,TSThatTraiApLuc= :TSThatTraiApLuc,TSThatTraiBHOxy= :TSThatTraiBHOxy,TSThatTraiNhanXet= :TSThatTraiNhanXet,TSDMChuApLuc= :TSDMChuApLuc,TSDMChuBHOxy= :TSDMChuBHOxy,TSDMChuNhanXet= :TSDMChuNhanXet,TSNhiTraiApLuc= :TSNhiTraiApLuc,TSNhiTraiBHOxy= :TSNhiTraiBHOxy,TSNhiTraiNhanXet= :TSNhiTraiNhanXet,KetQuaChupBuongTM= :KetQuaChupBuongTM,BienChungVaXuLy= :BienChungVaXuLy,KetLuan= :KetLuan";
                    sql = sql + " WHERE IDKetqua  = " + obj.IDKetQua.ToString() + " and LoaiPhieu = " + obj.LoaiPhieu.ToString();
                }
                else
                {
                    sql = @"select NVL(MAX(IDPhieu),0) AS IDPhieu from PhieuTraKetQuaTim WHERE LoaiPhieu = " + obj.LoaiPhieu.ToString();
                    oracleCommand = new MDB.MDBCommand(sql, oracleConnection);
                    oracleDataReader = oracleCommand.ExecuteReader();
                    while (oracleDataReader.Read())
                    {
                        IDphieuNext = Common.ConDB_Decimal(oracleDataReader["IDPhieu"]) + 1;
                    }
                    sql = @"insert into PhieuTraKetQuaTim(LoaiPhieu,IDPhieu, MaQuanLy,ChanDoan,MaBenhNhan,TenBenhNhan,Khoa,MaKhoa,Buong,Giuong,MaGiuong,NgayTao,NgaySua,FLgUse,MaSoKyTen,DiaChi,GioiTinh,MaBacSyDieuTri,TenBacSyDieuTri,MaBacSyThuThuat,TenBacSyThuThuat,NgayThucHienTT,Introducer,DCCatheter,DCWidewire,DCSuperStiff,DCSizingBalloon,DCThuocCanQuang,DCDelivery,DCBitCo,TTQTDuongVao,TTQTTienTrinh,TTQTAnhMaTaPath,TSCao,TSNang,TSBSA,TSHb,TSHct,TSCO,TSCL,TSQp,TSsp,TSQpPerQs,TSSVR,TSPVR,TSSVRPerPVR,TSTMCTApLuc,TSTMCTBHOxy,TSTMCTNhanXet,TSTMCDApLuc,TSTMCDBHOxy,TSTMCDNhanXet,TSNhiPhaiCaoApLuc,TSNhiPhaiCaoBHOxy,TSNhiPhaiCaoNhanXet,TSNhiPhaiGiuaApLuc,TSNhiPhaiGiuaBHOxy,TSNhiPhaiGiuaNhanXet,TSNhiPhaiThapApLuc,TSNhiPhaiThapBHOxy,TSNhiPhaiThapNhanXet,TSDuongRaTPApLuc,TSDuongRaTPBHOxy,TSDuongRaTPNhanXet,TSThatPhaiApLuc,TSThatPhaiBHOxy,TSThatPhaiNhanXet,TSThanDMPhoiApLuc,TSThanDMPhoiBHOxy,TSThanDMPhoiNhanXet,TSDMPhoiTraiApLuc,TSDMPhoiTraiBHOxy,TSDMPhoiTraiNhanXet,TSDMPhoiPhaiApLuc,TSDMPhoiPhaiBHOxy,TSDMPhoiPhaiNhanXet,TSThatTraiApLuc,TSThatTraiBHOxy,TSThatTraiNhanXet,TSDMChuApLuc,TSDMChuBHOxy,TSDMChuNhanXet,TSNhiTraiApLuc,TSNhiTraiBHOxy,TSNhiTraiNhanXet,KetQuaChupBuongTM,BienChungVaXuLy,KetLuan" +
                        ")";
                    sql = sql + @"Values(:LoaiPhieu, :IDPhieu, :MaQuanLy, :ChanDoan, :MaBenhNhan, :TenBenhNhan, :Khoa, :MaKhoa, :Buong, :Giuong, :MaGiuong, :NgayTao, :NgaySua, :FLgUse, :MaSoKyTen, :DiaChi, :GioiTinh,:MaBacSyDieuTri, :TenBacSyDieuTri, :MaBacSyThuThuat, :TenBacSyThuThuat, :NgayThucHienTT, :Introducer, :DCCatheter, :DCWidewire, :DCSuperStiff, :DCSizingBalloon, :DCThuocCanQuang, :DCDelivery, :DCBitCo, :TTQTDuongVao, :TTQTTienTrinh, :TTQTAnhMaTaPath, :TSCao, :TSNang, :TSBSA, :TSHb, :TSHct, :TSCO, :TSCL, :TSQp, :TSsp, :TSQpPerQs, :TSSVR, :TSPVR, :TSSVRPerPVR, :TSTMCTApLuc, :TSTMCTBHOxy, :TSTMCTNhanXet, :TSTMCDApLuc, :TSTMCDBHOxy, :TSTMCDNhanXet, :TSNhiPhaiCaoApLuc, :TSNhiPhaiCaoBHOxy, :TSNhiPhaiCaoNhanXet, :TSNhiPhaiGiuaApLuc, :TSNhiPhaiGiuaBHOxy, :TSNhiPhaiGiuaNhanXet, :TSNhiPhaiThapApLuc, :TSNhiPhaiThapBHOxy, :TSNhiPhaiThapNhanXet, :TSDuongRaTPApLuc, :TSDuongRaTPBHOxy, :TSDuongRaTPNhanXet, :TSThatPhaiApLuc, :TSThatPhaiBHOxy, :TSThatPhaiNhanXet, :TSThanDMPhoiApLuc, :TSThanDMPhoiBHOxy, :TSThanDMPhoiNhanXet, :TSDMPhoiTraiApLuc, :TSDMPhoiTraiBHOxy, :TSDMPhoiTraiNhanXet, :TSDMPhoiPhaiApLuc, :TSDMPhoiPhaiBHOxy, :TSDMPhoiPhaiNhanXet, :TSThatTraiApLuc, :TSThatTraiBHOxy, :TSThatTraiNhanXet, :TSDMChuApLuc, :TSDMChuBHOxy, :TSDMChuNhanXet, :TSNhiTraiApLuc, :TSNhiTraiBHOxy, :TSNhiTraiNhanXet, :KetQuaChupBuongTM, :BienChungVaXuLy, :KetLuan" +
                        ")   RETURNING IDKetQua INTO :IDKetQua";
                }
                oracleCommand = new MDB.MDBCommand(sql, oracleConnection);
                if (rowCount <= 0)
                {
                    obj.IDPhieu = IDphieuNext;
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("LoaiPhieu", obj.LoaiPhieu));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("IDPhieu", obj.IDPhieu));// thua
                }
                oracleCommand.Parameters.Add(new MDB.MDBParameter("MaQuanLy", obj.MaQuanLy));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("ChanDoan", obj.ChanDoan));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("MaBenhNhan", obj.MaBenhNhan));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("TenBenhNhan", obj.TenBenhNhan));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("Khoa", obj.Khoa));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("MaKhoa", obj.MaKhoa));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("Buong", obj.Buong));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("Giuong", obj.Giuong));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("MaGiuong", obj.MaGiuong));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("NgayTao", obj.NgayTao));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("NgaySua", DateTime.Now));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("FLgUse", obj.FLgUse));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("MaSoKyTen", obj.MaSoKy));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("DiaChi", obj.DiaChi));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("GioiTinh", obj.GioiTinh));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("MaBacSyDieuTri", obj.MaBacSyDieuTri));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("TenBacSyDieuTri", obj.TenBacSyDieuTri));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("MaBacSyThuThuat", obj.MaBacSyThuThuat));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("TenBacSyThuThuat", obj.TenBacSyThuThuat));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("NgayThucHienTT", obj.NgayThucHienTT));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("Introducer", obj.Introducer));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("DCCatheter", obj.DCCatheter));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("DCWidewire", obj.DCWidewire));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("DCSuperStiff", obj.DCSuperStiff));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("DCSizingBalloon", obj.DCSizingBalloon));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("DCThuocCanQuang", obj.DCThuocCanQuang));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("DCDelivery", obj.DCDelivery));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("DCBitCo", obj.DCBitCo));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("TTQTDuongVao", obj.TTQTDuongVao));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("TTQTTienTrinh", obj.TTQTTienTrinh));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("TTQTAnhMaTaPath", obj.TTQTAnhMaTaPath));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("TSCao", obj.TSCao));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("TSNang", obj.TSNang));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("TSBSA", obj.TSBSA));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("TSHb", obj.TSHb));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("TSHct", obj.TSHct));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("TSCO", obj.TSCO));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("TSCL", obj.TSCL));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("TSQp", obj.TSQp));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("TSsp", obj.TSsp));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("TSQpPerQs", obj.TSQpPerQs));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("TSSVR", obj.TSSVR));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("TSPVR", obj.TSPVR));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("TSSVRPerPVR", obj.TSSVRPerPVR));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("TSTMCTApLuc", obj.TSTMCTApLuc));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("TSTMCTBHOxy", obj.TSTMCTBHOxy));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("TSTMCTNhanXet", obj.TSTMCTNhanXet));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("TSTMCDApLuc", obj.TSTMCDApLuc));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("TSTMCDBHOxy", obj.TSTMCDBHOxy));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("TSTMCDNhanXet", obj.TSTMCDNhanXet));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("TSNhiPhaiCaoApLuc", obj.TSNhiPhaiCaoApLuc));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("TSNhiPhaiCaoBHOxy", obj.TSNhiPhaiCaoBHOxy));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("TSNhiPhaiCaoNhanXet", obj.TSNhiPhaiCaoNhanXet));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("TSNhiPhaiGiuaApLuc", obj.TSNhiPhaiGiuaApLuc));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("TSNhiPhaiGiuaBHOxy", obj.TSNhiPhaiGiuaBHOxy));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("TSNhiPhaiGiuaNhanXet", obj.TSNhiPhaiGiuaNhanXet));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("TSNhiPhaiThapApLuc", obj.TSNhiPhaiThapApLuc));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("TSNhiPhaiThapBHOxy", obj.TSNhiPhaiThapBHOxy));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("TSNhiPhaiThapNhanXet", obj.TSNhiPhaiThapNhanXet));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("TSDuongRaTPApLuc", obj.TSDuongRaTPApLuc));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("TSDuongRaTPBHOxy", obj.TSDuongRaTPBHOxy));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("TSDuongRaTPNhanXet", obj.TSDuongRaTPNhanXet));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("TSThatPhaiApLuc", obj.TSThatPhaiApLuc));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("TSThatPhaiBHOxy", obj.TSThatPhaiBHOxy));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("TSThatPhaiNhanXet", obj.TSThatPhaiNhanXet));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("TSThanDMPhoiApLuc", obj.TSThanDMPhoiApLuc));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("TSThanDMPhoiBHOxy", obj.TSThanDMPhoiBHOxy));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("TSThanDMPhoiNhanXet", obj.TSThanDMPhoiNhanXet));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("TSDMPhoiTraiApLuc", obj.TSDMPhoiTraiApLuc));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("TSDMPhoiTraiBHOxy", obj.TSDMPhoiTraiBHOxy));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("TSDMPhoiTraiNhanXet", obj.TSDMPhoiTraiNhanXet));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("TSDMPhoiPhaiApLuc", obj.TSDMPhoiPhaiApLuc));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("TSDMPhoiPhaiBHOxy", obj.TSDMPhoiPhaiBHOxy));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("TSDMPhoiPhaiNhanXet", obj.TSDMPhoiPhaiNhanXet));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("TSThatTraiApLuc", obj.TSThatTraiApLuc));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("TSThatTraiBHOxy", obj.TSThatTraiBHOxy));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("TSThatTraiNhanXet", obj.TSThatTraiNhanXet));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("TSDMChuApLuc", obj.TSDMChuApLuc));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("TSDMChuBHOxy", obj.TSDMChuBHOxy));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("TSDMChuNhanXet", obj.TSDMChuNhanXet));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("TSNhiTraiApLuc", obj.TSNhiTraiApLuc));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("TSNhiTraiBHOxy", obj.TSNhiTraiBHOxy));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("TSNhiTraiNhanXet", obj.TSNhiTraiNhanXet));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("KetQuaChupBuongTM", obj.KetQuaChupBuongTM));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("BienChungVaXuLy", obj.BienChungVaXuLy));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("KetLuan", obj.KetLuan));
                if (!isUpdate)
                {
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("IDKetQua", obj.IDKetQua));
                }
                nRecord = oracleCommand.ExecuteNonQuery();
                if (nRecord > 0)
                {
                    if (!isUpdate)
                    {
                        decimal nextval = Common.ConDB_Decimal((oracleCommand.Parameters["IDKetQua"] as MDB.MDBParameter).Value);
                        obj.IDKetQua = nextval;
                    }
                }
                return nRecord > 0 ? true : false;
            }
            catch (Exception ex)
            {
                XuLyLoi.LogError(ex);
            }
            return false;
        }
        public static bool DeleteByIDKetqua(MDB.MDBConnection oracleConnection, decimal IDBienBan, decimal typ)
        {
            try
            {
                string sql = "";
                MDB.MDBCommand oracleCommand;
                sql = @"DELETE FROM PhieuTraKetQuaTim WHERE IDKetqua  = " + IDBienBan.ToString() + " and LoaiPhieu = " + typ.ToString();
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
    }
    public class PhieuTraKetQuaDongMachFunc
    {

        //public static PhieuTraKetQuaDongMachChiTbl SelectRecord(decimal MaQuanLy, decimal loaiPhieu)
        //{
        //    try
        //    {
        //        {
        //            PhieuTraKetQuaDongMachChiTbl obj = new PhieuTraKetQuaDongMachChiTbl();
        //            string sql = @"SELECT t.*
        //            FROM PhieuTraKetQuaDongMachChi t
        //            WHERE t.MaQuanLy = :MaQuanLy AND t.LoaiPhieu = :LoaiPhieu ORDER BY t.NgayTao DESC";
        //            MDB.MDBCommand Command = new MDB.MDBCommand(sql, XemBenhAn.MyConnection);
        //            Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", MaQuanLy));
        //            Command.Parameters.Add(new MDB.MDBParameter("LoaiPhieu", loaiPhieu));
        //            MDB.MDBDataReader DataReader = Command.ExecuteReader();
        //            while (DataReader.Read())
        //            {
        //                obj.IDKetQua = Common.ConDB_Decimal(DataReader["IDKetQua"]);
        //                obj.IDPhieu = Common.ConDB_Decimal(DataReader["IDPhieu"]);
        //                obj.LoaiPhieu = Common.ConDB_Decimal(DataReader["LoaiPhieu"]);
        //                obj.MaQuanLy = Common.ConDBNull(DataReader["MaQuanLy"]);
        //                obj.ChanDoan = Common.ConDBNull(DataReader["ChanDoan"]);
        //                obj.MaBenhNhan = Common.ConDBNull(DataReader["MaBenhNhan"]);
        //                obj.TenBenhNhan = Common.ConDBNull(DataReader["TenBenhNhan"]);
        //                obj.Khoa = Common.ConDBNull(DataReader["Khoa"]);
        //                obj.MaKhoa = Common.ConDBNull(DataReader["MaKhoa"]);
        //                obj.Buong = Common.ConDBNull(DataReader["Buong"]);
        //                obj.Giuong = Common.ConDBNull(DataReader["Giuong"]);
        //                obj.MaGiuong = Common.ConDBNull(DataReader["MaGiuong"]);
        //                obj.NgayTao = Common.ConDB_DateTime(DataReader["NgayTao"]);
        //                obj.NgaySua = Common.ConDB_DateTime(DataReader["NgaySua"]);
        //                obj.FLgUse = Common.ConDB_Int(DataReader["FLgUse"]);
        //                obj.MaSoKyTen = Common.ConDBNull(DataReader["MaSoKyTen"]);
        //                obj.DiaChi = Common.ConDBNull(DataReader["DiaChi"]);
        //                obj.GioiTinh = Common.ConDBNull(DataReader["GioiTinh"]);
        //                obj.MaBacSyDieuTri = Common.ConDBNull(DataReader["MaBacSyDieuTri"]);
        //                obj.TenBacSyDieuTri = Common.ConDBNull(DataReader["TenBacSyDieuTri"]);
        //                obj.MaBacSyThuThuat = Common.ConDBNull(DataReader["MaBacSyThuThuat"]);
        //                obj.TenBacSyThuThuat = Common.ConDBNull(DataReader["TenBacSyThuThuat"]);
        //                obj.NgayThucHienTT = Common.ConDB_DateTime(DataReader["NgayThucHienTT"]);
        //                obj.Introducer = Common.ConDBNull(DataReader["Introducer"]);
        //                obj.DCCatheter = Common.ConDBNull(DataReader["DCCatheter"]);
        //                obj.DCGuidewire = Common.ConDBNull(DataReader["DCGuidewire"]);
        //                obj.DCPigtail = Common.ConDBNull(DataReader["DCPigtail"]);
        //                obj.DCBongNong = Common.ConDBNull(DataReader["DCBongNong"]);
        //                obj.DCStent = Common.ConDBNull(DataReader["DCStent"]);
        //                obj.DCLoaiKhac = Common.ConDBNull(DataReader["DCLoaiKhac"]);
        //                obj.DCThuocCanQuang = Common.ConDBNull(DataReader["DCThuocCanQuang"]);
        //                obj.TTQTDuongVao = Common.ConDBNull(DataReader["TTQTDuongVao"]);
        //                obj.TTQTTienTrinh = Common.ConDBNull(DataReader["TTQTTienTrinh"]);
        //                obj.TTQTAnhMaTaPath = Common.ConDBNull(DataReader["TTQTAnhMaTaPath"]);
        //                obj.TraiDMCBung = Common.ConDBNull(DataReader["TraiDMCBung"]);
        //                obj.PhaiDMCBung = Common.ConDBNull(DataReader["PhaiDMCBung"]);
        //                obj.TraiDMThan = Common.ConDBNull(DataReader["TraiDMThan"]);
        //                obj.PhaiDMThan = Common.ConDBNull(DataReader["PhaiDMThan"]);
        //                obj.TraiChauGoc = Common.ConDBNull(DataReader["TraiChauGoc"]);
        //                obj.PhaiChauGoc = Common.ConDBNull(DataReader["PhaiChauGoc"]);
        //                obj.TraiChauNgoai = Common.ConDBNull(DataReader["TraiChauNgoai"]);
        //                obj.PhaiChauNgoai = Common.ConDBNull(DataReader["PhaiChauNgoai"]);
        //                obj.TraiChauTrong = Common.ConDBNull(DataReader["TraiChauTrong"]);
        //                obj.PhaiChauTrong = Common.ConDBNull(DataReader["PhaiChauTrong"]);
        //                obj.TraiDuiChung = Common.ConDBNull(DataReader["TraiDuiChung"]);
        //                obj.PhaiDuiChung = Common.ConDBNull(DataReader["PhaiDuiChung"]);
        //                obj.TraiDuiNong = Common.ConDBNull(DataReader["TraiDuiNong"]);
        //                obj.PhaiDuiNong = Common.ConDBNull(DataReader["PhaiDuiNong"]);
        //                obj.TraiDuiSau = Common.ConDBNull(DataReader["TraiDuiSau"]);
        //                obj.PhaiDuiSau = Common.ConDBNull(DataReader["PhaiDuiSau"]);
        //                obj.TraiKhoeo = Common.ConDBNull(DataReader["TraiKhoeo"]);
        //                obj.PhaiKhoeo = Common.ConDBNull(DataReader["PhaiKhoeo"]);
        //                obj.TraiChayTruoc = Common.ConDBNull(DataReader["TraiChayTruoc"]);
        //                obj.PhaiChayTruoc = Common.ConDBNull(DataReader["PhaiChayTruoc"]);
        //                obj.TraiChaySau = Common.ConDBNull(DataReader["TraiChaySau"]);
        //                obj.PhaiChaySau = Common.ConDBNull(DataReader["PhaiChaySau"]);
        //                obj.TraiMac = Common.ConDBNull(DataReader["TraiMac"]);
        //                obj.PhaiMac = Common.ConDBNull(DataReader["PhaiMac"]);
        //                obj.KetLuan = Common.ConDBNull(DataReader["KetLuan"]);
        //                obj.DaKy = !string.IsNullOrEmpty(obj.MaSoKyTen) ? true : false;
        //            }

        //            return obj;
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //}
        public static List<PhieuTraKetQuaDongMachTbl> Select(MDB.MDBConnection MyConnection,decimal MaQuanLy, decimal loaiPhieu)
        {
            try
            {
                {
                    List<PhieuTraKetQuaDongMachTbl> listResult = new List<PhieuTraKetQuaDongMachTbl>();
                    string sql = @"SELECT t.*
                    FROM PhieuTraKetQuaDongMach t";

                    if (MaQuanLy > 0)
                    {
                        sql = sql + " WHERE t.MaQuanLy = " + MaQuanLy.ToString() + " AND t.LoaiPhieu = :LoaiPhieu ORDER BY t.NgayTao DESC";
                    }
                    else
                    {
                        sql = sql + " WHERE  t.LoaiPhieu = :LoaiPhieu ORDER BY t.NgayTao DESC";
                    }
                    MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
                    Command.Parameters.Add(new MDB.MDBParameter("LoaiPhieu", loaiPhieu));
                    MDB.MDBDataReader DataReader = Command.ExecuteReader();
                    while (DataReader.Read())
                    {
                        var obj = new PhieuTraKetQuaDongMachTbl();
                        obj.IDKetQua = Common.ConDB_Decimal(DataReader["IDKetQua"]);
                        obj.IDPhieu = Common.ConDB_Decimal(DataReader["IDPhieu"]);
                        obj.LoaiPhieu = Common.ConDB_Decimal(DataReader["LoaiPhieu"]);
                        obj.MaQuanLy = Common.ConDB_Decimal(DataReader["MaQuanLy"]);
                        obj.ChanDoan = Common.ConDBNull(DataReader["ChanDoan"]);
                        obj.MaBenhNhan = Common.ConDBNull(DataReader["MaBenhNhan"]);
                        obj.TenBenhNhan = Common.ConDBNull(DataReader["TenBenhNhan"]);
                        obj.Khoa = Common.ConDBNull(DataReader["Khoa"]);
                        obj.MaKhoa = Common.ConDBNull(DataReader["MaKhoa"]);
                        obj.Buong = Common.ConDBNull(DataReader["Buong"]);
                        obj.Giuong = Common.ConDBNull(DataReader["Giuong"]);
                        obj.MaGiuong = Common.ConDBNull(DataReader["MaGiuong"]);
                        obj.NgayTao = Common.ConDB_DateTime(DataReader["NgayTao"]);
                        obj.NgaySua = Common.ConDB_DateTime(DataReader["NgaySua"]);
                        obj.FLgUse = Common.ConDB_Int(DataReader["FLgUse"]);
                        obj.MaSoKy = Common.ConDBNull(DataReader["MaSoKyTen"]);
                        obj.DiaChi = Common.ConDBNull(DataReader["DiaChi"]);
                        obj.GioiTinh = Common.ConDBNull(DataReader["GioiTinh"]);
                        obj.MaBacSyDieuTri = Common.ConDBNull(DataReader["MaBacSyDieuTri"]);
                        obj.TenBacSyDieuTri = Common.ConDBNull(DataReader["TenBacSyDieuTri"]);
                        obj.MaBacSyThuThuat = Common.ConDBNull(DataReader["MaBacSyThuThuat"]);
                        obj.TenBacSyThuThuat = Common.ConDBNull(DataReader["TenBacSyThuThuat"]);
                        obj.NgayThucHienTT = Common.ConDB_DateTime(DataReader["NgayThucHienTT"]);
                        obj.Introducer = Common.ConDBNull(DataReader["Introducer"]);
                        obj.DCCatheter = Common.ConDBNull(DataReader["DCCatheter"]);
                        obj.DCGuidewire = Common.ConDBNull(DataReader["DCGuidewire"]);
                        obj.DCPigtail = Common.ConDBNull(DataReader["DCPigtail"]);
                        obj.DCBongNong = Common.ConDBNull(DataReader["DCBongNong"]);
                        obj.DCStent = Common.ConDBNull(DataReader["DCStent"]);
                        obj.DCLoaiKhac = Common.ConDBNull(DataReader["DCLoaiKhac"]);
                        obj.DCThuocCanQuang = Common.ConDBNull(DataReader["DCThuocCanQuang"]);
                        obj.TTQTDuongVao = Common.ConDBNull(DataReader["TTQTDuongVao"]);
                        obj.TTQTTienTrinh = Common.ConDBNull(DataReader["TTQTTienTrinh"]);
                        obj.TTQTAnhMaTaPath = Common.ConDBNull(DataReader["TTQTAnhMaTaPath"]);
                        obj.TraiDMCBung = Common.ConDBNull(DataReader["TraiDMCBung"]);
                        obj.PhaiDMCBung = Common.ConDBNull(DataReader["PhaiDMCBung"]);
                        obj.TraiDMThan = Common.ConDBNull(DataReader["TraiDMThan"]);
                        obj.PhaiDMThan = Common.ConDBNull(DataReader["PhaiDMThan"]);
                        obj.TraiChauGoc = Common.ConDBNull(DataReader["TraiChauGoc"]);
                        obj.PhaiChauGoc = Common.ConDBNull(DataReader["PhaiChauGoc"]);
                        obj.TraiChauNgoai = Common.ConDBNull(DataReader["TraiChauNgoai"]);
                        obj.PhaiChauNgoai = Common.ConDBNull(DataReader["PhaiChauNgoai"]);
                        obj.TraiChauTrong = Common.ConDBNull(DataReader["TraiChauTrong"]);
                        obj.PhaiChauTrong = Common.ConDBNull(DataReader["PhaiChauTrong"]);
                        obj.TraiDuiChung = Common.ConDBNull(DataReader["TraiDuiChung"]);
                        obj.PhaiDuiChung = Common.ConDBNull(DataReader["PhaiDuiChung"]);
                        obj.TraiDuiNong = Common.ConDBNull(DataReader["TraiDuiNong"]);
                        obj.PhaiDuiNong = Common.ConDBNull(DataReader["PhaiDuiNong"]);
                        obj.TraiDuiSau = Common.ConDBNull(DataReader["TraiDuiSau"]);
                        obj.PhaiDuiSau = Common.ConDBNull(DataReader["PhaiDuiSau"]);
                        obj.TraiKhoeo = Common.ConDBNull(DataReader["TraiKhoeo"]);
                        obj.PhaiKhoeo = Common.ConDBNull(DataReader["PhaiKhoeo"]);
                        obj.TraiChayTruoc = Common.ConDBNull(DataReader["TraiChayTruoc"]);
                        obj.PhaiChayTruoc = Common.ConDBNull(DataReader["PhaiChayTruoc"]);
                        obj.TraiChaySau = Common.ConDBNull(DataReader["TraiChaySau"]);
                        obj.PhaiChaySau = Common.ConDBNull(DataReader["PhaiChaySau"]);
                        obj.TraiMac = Common.ConDBNull(DataReader["TraiMac"]);
                        obj.PhaiMac = Common.ConDBNull(DataReader["PhaiMac"]);
                        obj.KetLuan = Common.ConDBNull(DataReader["KetLuan"]);
                        obj.DaKy = !string.IsNullOrEmpty(obj.MaSoKy) ? true : false;
                        listResult.Add(obj);
                    }

                    return listResult;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static DataSet GetDataSet(MDB.MDBConnection MyConnection, decimal IDBienBan, decimal typ)
        {
            string sql = @"SELECT P.*, T.SoNhapVien,
                H.TUOI,H.SoYTe, H.BENHVIEN, H.DienThoaiLienLac
                  FROM PhieuTraKetQuaDongMach P 
                Left JOIN THONGTINDIEUTRI T ON P.MAQUANLY = T.MAQUANLY
                Left JOIN HANHCHINHBENHNHAN H ON T.MABENHNHAN = H.MABENHNHAN
                  where IDKetqua  = :IDKetqua  and LoaiPhieu = :LoaiPhieu";
            MDB.MDBCommand Command;
            MDB.MDBDataAdapter adt;
            using (Command = new MDB.MDBCommand(sql, MyConnection))
            {
                Command.Parameters.Add(new MDB.MDBParameter("IDKetqua ", IDBienBan));
                Command.Parameters.Add(new MDB.MDBParameter("LoaiPhieu", typ));
                adt = new MDB.MDBDataAdapter(Command);
            }
            var ds = new DataSet();
            adt.Fill(ds, "TBL");
            return ds;
        }
        public static bool InsertOrUpdate(MDB.MDBConnection oracleConnection, PhieuTraKetQuaDongMachTbl obj, ref bool isUpdate)
        {
            try
            {
                string sql = @"SELECT COUNT(*) RECNUM FROM PhieuTraKetQuaDongMach WHERE IDKetqua  = :IDKetqua   and LoaiPhieu = :LoaiPhieu";
                MDB.MDBCommand oracleCommand;
                int rowCount = 0;
                int nRecord = 0;
                decimal IDphieuNext = 0;
                oracleCommand = new MDB.MDBCommand(sql, oracleConnection);
                oracleCommand.Parameters.Add("IDKetqua ", obj.IDKetQua);
                oracleCommand.Parameters.Add("LoaiPhieu", obj.LoaiPhieu);
                MDB.MDBDataReader oracleDataReader = oracleCommand.ExecuteReader();
                while (oracleDataReader.Read())
                {
                    rowCount = int.Parse(oracleDataReader["RECNUM"].ToString());
                }


                if (rowCount > 0)
                {
                    isUpdate = true;
                    IDphieuNext = obj.IDKetQua;
                    sql = "update PhieuTraKetQuaDongMach set MaQuanLy = :MaQuanLy,ChanDoan = :ChanDoan,MaBenhNhan = :MaBenhNhan,TenBenhNhan = :TenBenhNhan,Khoa = :Khoa,MaKhoa = :MaKhoa,Buong = :Buong,Giuong = :Giuong,MaGiuong = :MaGiuong,NgayTao = :NgayTao,NgaySua = :NgaySua,FLgUse = :FLgUse,MaSoKyTen = :MaSoKyTen,DiaChi = :DiaChi,GioiTinh = :GioiTinh,MaBacSyDieuTri = :MaBacSyDieuTri,TenBacSyDieuTri = :TenBacSyDieuTri,MaBacSyThuThuat = :MaBacSyThuThuat,TenBacSyThuThuat = :TenBacSyThuThuat,NgayThucHienTT = :NgayThucHienTT,Introducer = :Introducer,DCCatheter = :DCCatheter,DCGuidewire = :DCGuidewire,DCPigtail = :DCPigtail,DCBongNong = :DCBongNong,DCStent = :DCStent,DCLoaiKhac = :DCLoaiKhac,DCThuocCanQuang = :DCThuocCanQuang,TTQTDuongVao = :TTQTDuongVao,TTQTTienTrinh = :TTQTTienTrinh,TTQTAnhMaTaPath = :TTQTAnhMaTaPath,TraiDMCBung = :TraiDMCBung,PhaiDMCBung = :PhaiDMCBung,TraiDMThan = :TraiDMThan,PhaiDMThan = :PhaiDMThan,TraiChauGoc = :TraiChauGoc,PhaiChauGoc = :PhaiChauGoc,TraiChauNgoai = :TraiChauNgoai,PhaiChauNgoai = :PhaiChauNgoai,TraiChauTrong = :TraiChauTrong,PhaiChauTrong = :PhaiChauTrong,TraiDuiChung = :TraiDuiChung,PhaiDuiChung = :PhaiDuiChung,TraiDuiNong = :TraiDuiNong,PhaiDuiNong = :PhaiDuiNong,TraiDuiSau = :TraiDuiSau,PhaiDuiSau = :PhaiDuiSau,TraiKhoeo = :TraiKhoeo,PhaiKhoeo = :PhaiKhoeo,TraiChayTruoc = :TraiChayTruoc,PhaiChayTruoc = :PhaiChayTruoc,TraiChaySau = :TraiChaySau,PhaiChaySau = :PhaiChaySau,TraiMac = :TraiMac,PhaiMac = :PhaiMac,KetLuan = :KetLuan";
                    sql = sql + " WHERE IDKetqua  = " + obj.IDKetQua.ToString() + " and LoaiPhieu = " + obj.LoaiPhieu.ToString();
                }
                else
                {
                    sql = @"select NVL(MAX(IDPhieu),0) AS IDPhieu from PhieuTraKetQuaDongMach WHERE LoaiPhieu = " + obj.LoaiPhieu.ToString();
                    oracleCommand = new MDB.MDBCommand(sql, oracleConnection);
                    oracleDataReader = oracleCommand.ExecuteReader();
                    while (oracleDataReader.Read())
                    {
                        IDphieuNext = Common.ConDB_Decimal(oracleDataReader["IDPhieu"]) + 1;
                    }
                    sql = @"insert into PhieuTraKetQuaDongMach(IDPhieu, LoaiPhieu,MaQuanLy,ChanDoan,MaBenhNhan,TenBenhNhan,Khoa,MaKhoa,Buong,Giuong,MaGiuong,NgayTao,NgaySua,FLgUse,MaSoKyTen,DiaChi,GioiTinh,MaBacSyDieuTri,TenBacSyDieuTri,MaBacSyThuThuat,TenBacSyThuThuat,NgayThucHienTT,Introducer,DCCatheter,DCGuidewire,DCPigtail,DCBongNong,DCStent,DCLoaiKhac,DCThuocCanQuang,TTQTDuongVao,TTQTTienTrinh,TTQTAnhMaTaPath,TraiDMCBung,PhaiDMCBung,TraiDMThan,PhaiDMThan,TraiChauGoc,PhaiChauGoc,TraiChauNgoai,PhaiChauNgoai,TraiChauTrong,PhaiChauTrong,TraiDuiChung,PhaiDuiChung,TraiDuiNong,PhaiDuiNong,TraiDuiSau,PhaiDuiSau,TraiKhoeo,PhaiKhoeo,TraiChayTruoc,PhaiChayTruoc,TraiChaySau,PhaiChaySau,TraiMac,PhaiMac,KetLuan" +
                        ")";
                    sql = sql + @"Values(:IDPhieu,:LoaiPhieu, :MaQuanLy, :ChanDoan, :MaBenhNhan, :TenBenhNhan, :Khoa, :MaKhoa, :Buong, :Giuong, :MaGiuong, :NgayTao, :NgaySua, :FLgUse, :MaSoKyTen, :DiaChi, :GioiTinh, :MaBacSyDieuTri, :TenBacSyDieuTri, :MaBacSyThuThuat, :TenBacSyThuThuat, :NgayThucHienTT, :Introducer, :DCCatheter, :DCGuidewire, :DCPigtail, :DCBongNong, :DCStent, :DCLoaiKhac, :DCThuocCanQuang, :TTQTDuongVao, :TTQTTienTrinh, :TTQTAnhMaTaPath, :TraiDMCBung, :PhaiDMCBung, :TraiDMThan, :PhaiDMThan, :TraiChauGoc, :PhaiChauGoc, :TraiChauNgoai, :PhaiChauNgoai, :TraiChauTrong, :PhaiChauTrong, :TraiDuiChung, :PhaiDuiChung, :TraiDuiNong, :PhaiDuiNong, :TraiDuiSau, :PhaiDuiSau, :TraiKhoeo, :PhaiKhoeo, :TraiChayTruoc, :PhaiChayTruoc, :TraiChaySau, :PhaiChaySau, :TraiMac, :PhaiMac, :KetLuan" +
                        ")   RETURNING IDKetQua INTO :IDKetQua";
                }
                oracleCommand = new MDB.MDBCommand(sql, oracleConnection);
                if (rowCount <= 0)
                {
                    obj.IDPhieu = IDphieuNext;
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("IDPhieu", obj.IDPhieu));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("LoaiPhieu", obj.LoaiPhieu));
                }
                oracleCommand.Parameters.Add(new MDB.MDBParameter("MaQuanLy", obj.MaQuanLy));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("ChanDoan", obj.ChanDoan));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("MaBenhNhan", obj.MaBenhNhan));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("TenBenhNhan", obj.TenBenhNhan));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("Khoa", obj.Khoa));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("MaKhoa", obj.MaKhoa));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("Buong", obj.Buong));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("Giuong", obj.Giuong));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("MaGiuong", obj.MaGiuong));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("NgayTao", DateTime.Now));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("NgaySua", obj.NgaySua));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("FLgUse", obj.FLgUse));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("MaSoKyTen", obj.MaSoKy));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("DiaChi", obj.DiaChi));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("GioiTinh", obj.GioiTinh));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("MaBacSyDieuTri", obj.MaBacSyDieuTri));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("TenBacSyDieuTri", obj.TenBacSyDieuTri));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("MaBacSyThuThuat", obj.MaBacSyThuThuat));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("TenBacSyThuThuat", obj.TenBacSyThuThuat));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("NgayThucHienTT", obj.NgayThucHienTT));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("Introducer", obj.Introducer));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("DCCatheter", obj.DCCatheter));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("DCGuidewire", obj.DCGuidewire));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("DCPigtail", obj.DCPigtail));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("DCBongNong", obj.DCBongNong));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("DCStent", obj.DCStent));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("DCLoaiKhac", obj.DCLoaiKhac));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("DCThuocCanQuang", obj.DCThuocCanQuang));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("TTQTDuongVao", obj.TTQTDuongVao));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("TTQTTienTrinh", obj.TTQTTienTrinh));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("TTQTAnhMaTaPath", obj.TTQTAnhMaTaPath));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("TraiDMCBung", obj.TraiDMCBung));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("PhaiDMCBung", obj.PhaiDMCBung));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("TraiDMThan", obj.TraiDMThan));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("PhaiDMThan", obj.PhaiDMThan));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("TraiChauGoc", obj.TraiChauGoc));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("PhaiChauGoc", obj.PhaiChauGoc));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("TraiChauNgoai", obj.TraiChauNgoai));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("PhaiChauNgoai", obj.PhaiChauNgoai));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("TraiChauTrong", obj.TraiChauTrong));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("PhaiChauTrong", obj.PhaiChauTrong));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("TraiDuiChung", obj.TraiDuiChung));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("PhaiDuiChung", obj.PhaiDuiChung));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("TraiDuiNong", obj.TraiDuiNong));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("PhaiDuiNong", obj.PhaiDuiNong));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("TraiDuiSau", obj.TraiDuiSau));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("PhaiDuiSau", obj.PhaiDuiSau));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("TraiKhoeo", obj.TraiKhoeo));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("PhaiKhoeo", obj.PhaiKhoeo));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("TraiChayTruoc", obj.TraiChayTruoc));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("PhaiChayTruoc", obj.PhaiChayTruoc));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("TraiChaySau", obj.TraiChaySau));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("PhaiChaySau", obj.PhaiChaySau));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("TraiMac", obj.TraiMac));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("PhaiMac", obj.PhaiMac));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("KetLuan", obj.KetLuan));

                if (!isUpdate)
                {
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("IDKetQua", obj.IDKetQua));
                }
                nRecord = oracleCommand.ExecuteNonQuery();
                if (nRecord > 0)
                {
                    if (!isUpdate)
                    {
                        decimal nextval = Common.ConDB_Decimal((oracleCommand.Parameters["IDKetQua"] as MDB.MDBParameter).Value);
                        obj.IDKetQua = nextval;
                    }
                }
                return nRecord > 0 ? true : false;
            }
            catch (Exception ex)
            {
                XuLyLoi.LogError(ex);
            }
            return false;
        }
        public static bool DeleteByIDKetqua(MDB.MDBConnection oracleConnection, decimal IDBienBan, decimal typ)
        {
            try
            {
                string sql = "";
                MDB.MDBCommand oracleCommand;
                sql = @"DELETE FROM PhieuTraKetQuaDongMach WHERE IDKetqua  = " + IDBienBan.ToString() + " and LoaiPhieu = " + typ.ToString();
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
    }
    public class PhieuTraKetQuaDongMachCanhFunc
    {
        public static List<PhieuTraKetQuaDongMachCanhTbl> Select(MDB.MDBConnection MyConnection,decimal MaQuanLy, decimal loaiPhieu)
        {
            try
            {
                {
                    List<PhieuTraKetQuaDongMachCanhTbl> listResult = new List<PhieuTraKetQuaDongMachCanhTbl>();
                    string sql = @"SELECT t.*
                    FROM PhieuTraKetQuaDongMachCanh t";

                    if (MaQuanLy > 0)
                    {
                        sql = sql + " WHERE t.MaQuanLy = " + MaQuanLy.ToString() + " AND t.LoaiPhieu = :LoaiPhieu ORDER BY t.NgayTao DESC";
                    }
                    else
                    {
                        sql = sql + " WHERE  t.LoaiPhieu = :LoaiPhieu ORDER BY t.NgayTao DESC";
                    }
                    MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
                    Command.Parameters.Add(new MDB.MDBParameter("LoaiPhieu", loaiPhieu));
                    MDB.MDBDataReader DataReader = Command.ExecuteReader();
                    while (DataReader.Read())
                    {
                        var obj = new PhieuTraKetQuaDongMachCanhTbl();
                        obj.IDKetQua = Common.ConDB_Decimal(DataReader["IDKetQua"]);
                        obj.IDPhieu = Common.ConDB_Decimal(DataReader["IDPhieu"]);
                        obj.LoaiPhieu = Common.ConDB_Decimal(DataReader["LoaiPhieu"]);
                        obj.MaQuanLy = Common.ConDB_Decimal(DataReader["FMaQuanLy"]);
                        obj.ChanDoan = Common.ConDBNull(DataReader["ChanDoan"]);
                        obj.MaBenhNhan = Common.ConDBNull(DataReader["MaBenhNhan"]);
                        obj.TenBenhNhan = Common.ConDBNull(DataReader["TenBenhNhan"]);
                        obj.Khoa = Common.ConDBNull(DataReader["Khoa"]);
                        obj.MaKhoa = Common.ConDBNull(DataReader["MaKhoa"]);
                        obj.Buong = Common.ConDBNull(DataReader["Buong"]);
                        obj.Giuong = Common.ConDBNull(DataReader["Giuong"]);
                        obj.MaGiuong = Common.ConDBNull(DataReader["MaGiuong"]);
                        obj.NgayTao = Common.ConDB_DateTime(DataReader["NgayTao"]);
                        obj.NgaySua = Common.ConDB_DateTime(DataReader["NgaySua"]);
                        obj.FLgUse = Common.ConDB_Int(DataReader["FLgUse"]);
                        obj.MaSoKy = Common.ConDBNull(DataReader["MaSoKyTen"]);
                        obj.DiaChi = Common.ConDBNull(DataReader["DiaChi"]);
                        obj.GioiTinh = Common.ConDBNull(DataReader["GioiTinh"]);
                        obj.MaBacSyDieuTri = Common.ConDBNull(DataReader["MaBacSyDieuTri"]);
                        obj.TenBacSyDieuTri = Common.ConDBNull(DataReader["TenBacSyDieuTri"]);
                        obj.MaBacSyThuThuat = Common.ConDBNull(DataReader["MaBacSyThuThuat"]);
                        obj.TenBacSyThuThuat = Common.ConDBNull(DataReader["TenBacSyThuThuat"]);
                        obj.NgayThucHienTT = Common.ConDB_DateTime(DataReader["NgayThucHienTT"]);
                        obj.Introducer = Common.ConDBNull(DataReader["Introducer"]);
                        obj.DCCatheter = Common.ConDBNull(DataReader["DCCatheter"]);
                        obj.DCGuidewire = Common.ConDBNull(DataReader["DCGuidewire"]);
                        obj.DCBongNong = Common.ConDBNull(DataReader["DCBongNong"]);
                        obj.DCBomApLuc = Common.ConDBNull(DataReader["DCBomApLuc"]);
                        obj.DCStent = Common.ConDBNull(DataReader["DCStent"]);
                        obj.DCLoaiKhac = Common.ConDBNull(DataReader["DCLoaiKhac"]);
                        obj.DCThuocCanQuang = Common.ConDBNull(DataReader["DCThuocCanQuang"]);
                        obj.TTQTDuongVao = Common.ConDBNull(DataReader["TTQTDuongVao"]);
                        obj.TTQTTienTrinh = Common.ConDBNull(DataReader["TTQTTienTrinh"]);
                        obj.TTQTAnhMaTaPath = Common.ConDBNull(DataReader["TTQTAnhMaTaPath"]);
                        obj.KQDMCChungP = Common.ConDBNull(DataReader["KQDMCChungP"]);
                        obj.KQDMCTrongP = Common.ConDBNull(DataReader["KQDMCTrongP"]);
                        obj.KQDMCNgoaiP = Common.ConDBNull(DataReader["KQDMCNgoaiP"]);
                        obj.KQDMCChungT = Common.ConDBNull(DataReader["KQDMCChungT"]);
                        obj.KQDMCTrongT = Common.ConDBNull(DataReader["KQDMCTrongT"]);
                        obj.KQDMCNgoaiT = Common.ConDBNull(DataReader["KQDMCNgoaiT"]);
                        obj.KQDMDotSong = Common.ConDBNull(DataReader["KQDMDotSong"]);
                        obj.ViTriCanThiep = Common.ConDBNull(DataReader["ViTriCanThiep"]);
                        obj.TenThuThuat = Common.ConDBNull(DataReader["TenThuThuat"]);
                        obj.KetQua = Common.ConDBNull(DataReader["KetQua"]);
                        obj.NhanXetKhac = Common.ConDBNull(DataReader["NhanXetKhac"]);
                        obj.BienChungVaXuLi = Common.ConDB_Int(DataReader["BienChungVaXuLi"]);
                        obj.KetLuan = Common.ConDBNull(DataReader["KetLuan"]);
                        obj.DaKy = !string.IsNullOrEmpty(obj.MaSoKy) ? true : false;
                        listResult.Add(obj);
                    }

                    return listResult;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static DataSet GetDataSet(MDB.MDBConnection MyConnection, decimal IDBienBan, decimal typ)
        {
            string sql = @"SELECT P.*, T.SoNhapVien,
                H.TUOI,H.SoYTe, H.BENHVIEN, H.DienThoaiLienLac
                  FROM PhieuTraKetQuaDongMachCanh P 
                Left JOIN THONGTINDIEUTRI T ON P.MAQUANLY = T.MAQUANLY
                Left JOIN HANHCHINHBENHNHAN H ON T.MABENHNHAN = H.MABENHNHAN
                  where IDKetqua  = :IDKetqua  and LoaiPhieu = :LoaiPhieu";
            MDB.MDBCommand Command;
            MDB.MDBDataAdapter adt;
            using (Command = new MDB.MDBCommand(sql, MyConnection))
            {
                Command.Parameters.Add(new MDB.MDBParameter("IDKetqua ", IDBienBan));
                Command.Parameters.Add(new MDB.MDBParameter("LoaiPhieu", typ));
                adt = new MDB.MDBDataAdapter(Command);
            }
            var ds = new DataSet();
            adt.Fill(ds, "TBL");
            return ds;
        }
        public static bool InsertOrUpdate(MDB.MDBConnection oracleConnection, PhieuTraKetQuaDongMachCanhTbl obj, ref bool isUpdate)
        {
            try
            {
                string sql = @"SELECT COUNT(*) RECNUM FROM PhieuTraKetQuaDongMachCanh WHERE IDKetqua  = :IDKetqua   and LoaiPhieu = :LoaiPhieu";
                MDB.MDBCommand oracleCommand;
                int rowCount = 0;
                int nRecord = 0;
                decimal IDphieuNext = 0;
                oracleCommand = new MDB.MDBCommand(sql, oracleConnection);
                oracleCommand.Parameters.Add("IDKetqua ", obj.IDKetQua);
                oracleCommand.Parameters.Add("LoaiPhieu", obj.LoaiPhieu);
                MDB.MDBDataReader oracleDataReader = oracleCommand.ExecuteReader();
                while (oracleDataReader.Read())
                {
                    rowCount = int.Parse(oracleDataReader["RECNUM"].ToString());
                }


                if (rowCount > 0)
                {
                    isUpdate = true;
                    IDphieuNext = obj.IDKetQua;
                    sql = "update PhieuTraKetQuaDongMachCanh set MaQuanLy = :MaQuanLy,ChanDoan = :ChanDoan,MaBenhNhan = :MaBenhNhan,TenBenhNhan = :TenBenhNhan,Khoa = :Khoa,MaKhoa = :MaKhoa,Buong = :Buong,Giuong = :Giuong,MaGiuong = :MaGiuong,NgayTao = :NgayTao,NgaySua = :NgaySua,FLgUse = :FLgUse,MaSoKyTen = :MaSoKyTen,DiaChi = :DiaChi,GioiTinh = :GioiTinh,MaBacSyDieuTri = :MaBacSyDieuTri,TenBacSyDieuTri = :TenBacSyDieuTri,MaBacSyThuThuat = :MaBacSyThuThuat,TenBacSyThuThuat = :TenBacSyThuThuat,NgayThucHienTT = :NgayThucHienTT,Introducer = :Introducer,DCCatheter = :DCCatheter,DCGuidewire = :DCGuidewire,DCBongNong = :DCBongNong,DCBomApLuc = :DCBomApLuc,DCStent = :DCStent,DCLoaiKhac = :DCLoaiKhac,DCThuocCanQuang = :DCThuocCanQuang,TTQTDuongVao = :TTQTDuongVao,TTQTTienTrinh = :TTQTTienTrinh,TTQTAnhMaTaPath = :TTQTAnhMaTaPath,KQDMCChungP = :KQDMCChungP,KQDMCTrongP = :KQDMCTrongP,KQDMCNgoaiP = :KQDMCNgoaiP,KQDMCChungT = :KQDMCChungT,KQDMCTrongT = :KQDMCTrongT,KQDMCNgoaiT = :KQDMCNgoaiT,KQDMDotSong = :KQDMDotSong,ViTriCanThiep = :ViTriCanThiep,TenThuThuat = :TenThuThuat,KetQua = :KetQua,NhanXetKhac = :NhanXetKhac,BienChungVaXuLi = :BienChungVaXuLi,KetLuan = :KetLuan";
                    sql = sql + " WHERE IDKetqua  = " + obj.IDKetQua.ToString() + " and LoaiPhieu = " + obj.LoaiPhieu.ToString();
                }
                else
                {
                    sql = @"select NVL(MAX(IDPhieu),0) AS IDPhieu from PhieuTraKetQuaDongMachCanh WHERE LoaiPhieu = " + obj.LoaiPhieu.ToString();
                    oracleCommand = new MDB.MDBCommand(sql, oracleConnection);
                    oracleDataReader = oracleCommand.ExecuteReader();
                    while (oracleDataReader.Read())
                    {
                        IDphieuNext = Common.ConDB_Decimal(oracleDataReader["IDPhieu"]) + 1;
                    }
                    sql = @"insert into PhieuTraKetQuaDongMachCanh(IDPhieu,LoaiPhieu,MaQuanLy,ChanDoan,MaBenhNhan,TenBenhNhan,Khoa,MaKhoa,Buong,Giuong,MaGiuong,NgayTao,NgaySua,FLgUse,MaSoKyTen,DiaChi,GioiTinh,MaBacSyDieuTri,TenBacSyDieuTri,MaBacSyThuThuat,TenBacSyThuThuat,NgayThucHienTT,Introducer,DCCatheter,DCGuidewire,DCBongNong,DCBomApLuc,DCStent,DCLoaiKhac,DCThuocCanQuang,TTQTDuongVao,TTQTTienTrinh,TTQTAnhMaTaPath,KQDMCChungP,KQDMCTrongP,KQDMCNgoaiP,KQDMCChungT,KQDMCTrongT,KQDMCNgoaiT,KQDMDotSong,ViTriCanThiep,TenThuThuat,KetQua,NhanXetKhac,BienChungVaXuLi,KetLuan" +
                        ")";
                    sql = sql + @"Values(:IDPhieu, :LoaiPhieu, :MaQuanLy, :ChanDoan, :MaBenhNhan, :TenBenhNhan, :Khoa, :MaKhoa, :Buong, :Giuong, :MaGiuong, :NgayTao, :NgaySua, :FLgUse, :MaSoKyTen, :DiaChi, :GioiTinh, :MaBacSyDieuTri, :TenBacSyDieuTri, :MaBacSyThuThuat, :TenBacSyThuThuat, :NgayThucHienTT, :Introducer, :DCCatheter, :DCGuidewire, :DCBongNong, :DCBomApLuc, :DCStent, :DCLoaiKhac, :DCThuocCanQuang, :TTQTDuongVao, :TTQTTienTrinh, :TTQTAnhMaTaPath, :KQDMCChungP, :KQDMCTrongP, :KQDMCNgoaiP, :KQDMCChungT, :KQDMCTrongT, :KQDMCNgoaiT, :KQDMDotSong, :ViTriCanThiep, :TenThuThuat, :KetQua, :NhanXetKhac, :BienChungVaXuLi, :KetLuan" +
                        ")   RETURNING IDKetQua INTO :IDKetQua";
                }
                oracleCommand = new MDB.MDBCommand(sql, oracleConnection);
                if (rowCount <= 0)
                {
                    obj.IDPhieu = IDphieuNext;
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("IDPhieu", obj.IDPhieu));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("LoaiPhieu", obj.LoaiPhieu));
                }
                oracleCommand.Parameters.Add(new MDB.MDBParameter("MaQuanLy", obj.MaQuanLy));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("ChanDoan", obj.ChanDoan));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("MaBenhNhan", obj.MaBenhNhan));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("TenBenhNhan", obj.TenBenhNhan));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("Khoa", obj.Khoa));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("MaKhoa", obj.MaKhoa));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("Buong", obj.Buong));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("Giuong", obj.Giuong));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("MaGiuong", obj.MaGiuong));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("NgayTao", obj.NgayTao));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("NgaySua", DateTime.Now));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("FLgUse", obj.FLgUse));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("MaSoKyTen", obj.MaSoKy));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("DiaChi", obj.DiaChi));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("GioiTinh", obj.GioiTinh));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("MaBacSyDieuTri", obj.MaBacSyDieuTri));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("TenBacSyDieuTri", obj.TenBacSyDieuTri));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("MaBacSyThuThuat", obj.MaBacSyThuThuat));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("TenBacSyThuThuat", obj.TenBacSyThuThuat));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("NgayThucHienTT", obj.NgayThucHienTT));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("Introducer", obj.Introducer));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("DCCatheter", obj.DCCatheter));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("DCGuidewire", obj.DCGuidewire));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("DCBongNong", obj.DCBongNong));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("DCBomApLuc", obj.DCBomApLuc));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("DCStent", obj.DCStent));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("DCLoaiKhac", obj.DCLoaiKhac));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("DCThuocCanQuang", obj.DCThuocCanQuang));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("TTQTDuongVao", obj.TTQTDuongVao));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("TTQTTienTrinh", obj.TTQTTienTrinh));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("TTQTAnhMaTaPath", obj.TTQTAnhMaTaPath));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("KQDMCChungP", obj.KQDMCChungP));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("KQDMCTrongP", obj.KQDMCTrongP));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("KQDMCNgoaiP", obj.KQDMCNgoaiP));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("KQDMCChungT", obj.KQDMCChungT));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("KQDMCTrongT", obj.KQDMCTrongT));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("KQDMCNgoaiT", obj.KQDMCNgoaiT));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("KQDMDotSong", obj.KQDMDotSong));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("ViTriCanThiep", obj.ViTriCanThiep));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("TenThuThuat", obj.TenThuThuat));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("KetQua", obj.KetQua));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("NhanXetKhac", obj.NhanXetKhac));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("BienChungVaXuLi", obj.BienChungVaXuLi));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("KetLuan", obj.KetLuan));
                if (!isUpdate)
                {
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("IDKetQua", obj.IDKetQua));
                }
                nRecord = oracleCommand.ExecuteNonQuery();
                if (nRecord > 0)
                {
                    if (!isUpdate)
                    {
                        decimal nextval = Common.ConDB_Decimal((oracleCommand.Parameters["IDKetQua"] as MDB.MDBParameter).Value);
                        obj.IDKetQua = nextval;
                    }
                }
                return nRecord > 0 ? true : false;
            }
            catch (Exception ex)
            {
                XuLyLoi.LogError(ex);
            }
            return false;
        }
        public static bool DeleteByIDKetqua(MDB.MDBConnection oracleConnection, decimal IDBienBan, decimal typ)
        {
            try
            {
                string sql = "";
                MDB.MDBCommand oracleCommand;
                sql = @"DELETE FROM PhieuTraKetQuaDongMachCanh WHERE IDKetqua  = " + IDBienBan.ToString() + " and LoaiPhieu = " + typ.ToString();
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
    }
    public class PhieuTraKetQuaDongMachVanhFunc
    {
        public static List<PhieuTraKetQuaDongMachVanhTbl> Select(MDB.MDBConnection MyConnection ,decimal MaQuanLy, decimal loaiPhieu)
        {
            try
            {
                {
                    List<PhieuTraKetQuaDongMachVanhTbl> listResult = new List<PhieuTraKetQuaDongMachVanhTbl>();
                    string sql = @"SELECT t.*
                    FROM PhieuTraKetQuaDongMachVanh t";

                    if (MaQuanLy > 0)
                    {
                        sql = sql + " WHERE t.MaQuanLy = " + MaQuanLy.ToString() + " AND t.LoaiPhieu = :LoaiPhieu ORDER BY t.NgayTao DESC";
                    }
                    else
                    {
                        sql = sql + " WHERE  t.LoaiPhieu = :LoaiPhieu ORDER BY t.NgayTao DESC";
                    }
                    MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
                    Command.Parameters.Add(new MDB.MDBParameter("LoaiPhieu", loaiPhieu));
                    MDB.MDBDataReader DataReader = Command.ExecuteReader();
                    while (DataReader.Read())
                    {
                        var obj = new PhieuTraKetQuaDongMachVanhTbl();
                        obj.IDKetQua = Common.ConDB_Decimal(DataReader["IDKetQua"]);
                        obj.IDPhieu = Common.ConDB_Decimal(DataReader["IDPhieu"]);
                        obj.LoaiPhieu = Common.ConDB_Decimal(DataReader["LoaiPhieu"]);
                        obj.MaQuanLy = Common.ConDB_Decimal(DataReader["MaQuanLy"]);
                        obj.ChanDoan = Common.ConDBNull(DataReader["ChanDoan"]);
                        obj.MaBenhNhan = Common.ConDBNull(DataReader["MaBenhNhan"]);
                        obj.TenBenhNhan = Common.ConDBNull(DataReader["TenBenhNhan"]);
                        obj.Khoa = Common.ConDBNull(DataReader["Khoa"]);
                        obj.MaKhoa = Common.ConDBNull(DataReader["MaKhoa"]);
                        obj.Buong = Common.ConDBNull(DataReader["Buong"]);
                        obj.Giuong = Common.ConDBNull(DataReader["Giuong"]);
                        obj.MaGiuong = Common.ConDBNull(DataReader["MaGiuong"]);
                        obj.NgayTao = Common.ConDB_DateTime(DataReader["NgayTao"]);
                        obj.NgaySua = Common.ConDB_DateTime(DataReader["NgaySua"]);
                        obj.FLgUse = Common.ConDB_Int(DataReader["FLgUse"]);
                        obj.MaSoKy = Common.ConDBNull(DataReader["MaSoKyTen"]);
                        obj.DiaChi = Common.ConDBNull(DataReader["DiaChi"]);
                        obj.GioiTinh = Common.ConDBNull(DataReader["GioiTinh"]);
                        obj.MaBacSyDieuTri = Common.ConDBNull(DataReader["MaBacSyDieuTri"]);
                        obj.TenBacSyDieuTri = Common.ConDBNull(DataReader["TenBacSyDieuTri"]);
                        obj.MaBacSyThuThuat = Common.ConDBNull(DataReader["MaBacSyThuThuat"]);
                        obj.TenBacSyThuThuat = Common.ConDBNull(DataReader["TenBacSyThuThuat"]);
                        obj.NgayThucHienTT = Common.ConDB_DateTime(DataReader["NgayThucHienTT"]);
                        obj.Introducer = Common.ConDBNull(DataReader["Introducer"]);
                        obj.DCLoaiKhac = Common.ConDBNull(DataReader["DCLoaiKhac"]);
                        obj.DCPhai = Common.ConDBNull(DataReader["DCPhai"]);
                        obj.DCPigtail = Common.ConDBNull(DataReader["DCPigtail"]);
                        obj.DCThuocCanQuang = Common.ConDBNull(DataReader["DCThuocCanQuang"]);
                        obj.TTQTDuongVao = Common.ConDBNull(DataReader["TTQTDuongVao"]);
                        obj.TTQTTienTrinh = Common.ConDBNull(DataReader["TTQTTienTrinh"]);
                        obj.TTQTAnhMaTaPath = Common.ConDBNull(DataReader["TTQTAnhMaTaPath"]);
                        obj.KQDMCVanhTrai = Common.ConDBNull(DataReader["KQDMCVanhTrai"]);
                        obj.KQDMCLienThatTruoc = Common.ConDBNull(DataReader["KQDMCLienThatTruoc"]);
                        obj.KQDMMu = Common.ConDBNull(DataReader["KQDMMu"]);
                        obj.KQDMVanhPhai = Common.ConDBNull(DataReader["KQDMVanhPhai"]);
                        obj.KQCBTEF = Common.ConDBNull(DataReader["KQCBTEF"]);
                        obj.KQCBTRoiLoan = Common.ConDBNull(DataReader["KQCBTRoiLoan"]);
                        obj.ThamDoKemTheo = Common.ConDBNull(DataReader["ThamDoKemTheo"]);
                        obj.BienChungVaXuLi = Common.ConDB_Int(DataReader["BienChungVaXuLi"]);
                        obj.NhanXetKhac = Common.ConDBNull(DataReader["NhanXetKhac"]);
                        obj.KetLuan = Common.ConDBNull(DataReader["KetLuan"]);
                        obj.DaKy = !string.IsNullOrEmpty(obj.MaSoKy) ? true : false;
                        listResult.Add(obj);
                    }

                    return listResult;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static DataSet GetDataSet(MDB.MDBConnection MyConnection, decimal IDBienBan, decimal typ)
        {
            string sql = @"SELECT P.*, T.SoNhapVien,
                H.TUOI,H.SoYTe, H.BENHVIEN, H.DienThoaiLienLac
                  FROM PhieuTraKetQuaDongMachVanh P 
                Left JOIN THONGTINDIEUTRI T ON P.MAQUANLY = T.MAQUANLY
                Left JOIN HANHCHINHBENHNHAN H ON T.MABENHNHAN = H.MABENHNHAN
                  where IDKetqua  = :IDKetqua  and LoaiPhieu = :LoaiPhieu";
            MDB.MDBCommand Command;
            MDB.MDBDataAdapter adt;
            using (Command = new MDB.MDBCommand(sql, MyConnection))
            {
                Command.Parameters.Add(new MDB.MDBParameter("IDKetqua ", IDBienBan));
                Command.Parameters.Add(new MDB.MDBParameter("LoaiPhieu", typ));
                adt = new MDB.MDBDataAdapter(Command);
            }
            var ds = new DataSet();
            adt.Fill(ds, "TBL");
            return ds;
        }
        public static bool InsertOrUpdate(MDB.MDBConnection oracleConnection, PhieuTraKetQuaDongMachVanhTbl obj, ref bool isUpdate)
        {
            try
            {
                string sql = @"SELECT COUNT(*) RECNUM FROM PhieuTraKetQuaDongMachVanh WHERE IDKetqua  = :IDKetqua   and LoaiPhieu = :LoaiPhieu";
                MDB.MDBCommand oracleCommand;
                int rowCount = 0;
                int nRecord = 0;
                decimal IDphieuNext = 0;
                oracleCommand = new MDB.MDBCommand(sql, oracleConnection);
                oracleCommand.Parameters.Add("IDKetqua ", obj.IDKetQua);
                oracleCommand.Parameters.Add("LoaiPhieu", obj.LoaiPhieu);
                MDB.MDBDataReader oracleDataReader = oracleCommand.ExecuteReader();
                while (oracleDataReader.Read())
                {
                    rowCount = int.Parse(oracleDataReader["RECNUM"].ToString());
                }


                if (rowCount > 0)
                {
                    isUpdate = true;
                    IDphieuNext = obj.IDKetQua;
                    sql = "update PhieuTraKetQuaDongMachVanh set MaQuanLy = :MaQuanLy,ChanDoan = :ChanDoan,MaBenhNhan = :MaBenhNhan,TenBenhNhan = :TenBenhNhan,Khoa = :Khoa,MaKhoa = :MaKhoa,Buong = :Buong,Giuong = :Giuong,MaGiuong = :MaGiuong,NgayTao = :NgayTao,NgaySua = :NgaySua,FLgUse = :FLgUse,MaSoKyTen = :MaSoKyTen,DiaChi = :DiaChi,GioiTinh = :GioiTinh,MaBacSyDieuTri = :MaBacSyDieuTri,TenBacSyDieuTri = :TenBacSyDieuTri,MaBacSyThuThuat = :MaBacSyThuThuat,TenBacSyThuThuat = :TenBacSyThuThuat,NgayThucHienTT = :NgayThucHienTT,Introducer = :Introducer,DCCatheter = :DCCatheter,DCGuidewire = :DCGuidewire,DCBongNong = :DCBongNong,DCBomApLuc = :DCBomApLuc,DCStent = :DCStent,DCLoaiKhac = :DCLoaiKhac,DCThuocCanQuang = :DCThuocCanQuang,TTQTDuongVao = :TTQTDuongVao,TTQTTienTrinh = :TTQTTienTrinh,TTQTAnhMaTaPath = :TTQTAnhMaTaPath,KQDMCChungP = :KQDMCChungP,KQDMCTrongP = :KQDMCTrongP,KQDMCNgoaiP = :KQDMCNgoaiP,KQDMCChungT = :KQDMCChungT,KQDMCTrongT = :KQDMCTrongT,KQDMCNgoaiT = :KQDMCNgoaiT,KQDMDotSong = :KQDMDotSong,ViTriCanThiep = :ViTriCanThiep,TenThuThuat = :TenThuThuat,KetQua = :KetQua,NhanXetKhac = :NhanXetKhac,BienChungVaXuLi = :BienChungVaXuLi,KetLuan = :KetLuan";
                    sql = sql + " WHERE IDKetqua  = " + obj.IDKetQua.ToString() + " and LoaiPhieu = " + obj.LoaiPhieu.ToString();
                }
                else
                {
                    sql = @"select NVL(MAX(IDPhieu),0) AS IDPhieu from PhieuTraKetQuaDongMachVanh WHERE LoaiPhieu = " + obj.LoaiPhieu.ToString();
                    oracleCommand = new MDB.MDBCommand(sql, oracleConnection);
                    oracleDataReader = oracleCommand.ExecuteReader();
                    while (oracleDataReader.Read())
                    {
                        IDphieuNext = Common.ConDB_Decimal(oracleDataReader["IDPhieu"]) + 1;
                    }
                    sql = @"insert into PhieuTraKetQuaDongMachVanh(IDPhieu,LoaiPhieu,MaQuanLy,ChanDoan,MaBenhNhan,TenBenhNhan,Khoa,MaKhoa,Buong,Giuong,MaGiuong,NgayTao,NgaySua,FLgUse,MaSoKyTen,DiaChi,GioiTinh,MaBacSyDieuTri,TenBacSyDieuTri,MaBacSyThuThuat,TenBacSyThuThuat,NgayThucHienTT,Introducer,DCLoaiKhac,DCPhai,DCPigtail,DCThuocCanQuang,TTQTDuongVao,TTQTTienTrinh,TTQTAnhMaTaPath,KQDMCVanhTrai,KQDMCLienThatTruoc,KQDMMu,KQDMVanhPhai,KQCBTEF,KQCBTRoiLoan,ThamDoKemTheo,BienChungVaXuLi,NhanXetKhac,KetLuan" +
                        ")";
                    sql = sql + @"Values(:IDPhieu, :LoaiPhieu, :MaQuanLy, :ChanDoan, :MaBenhNhan, :TenBenhNhan, :Khoa, :MaKhoa, :Buong, :Giuong, :MaGiuong, :NgayTao, :NgaySua, :FLgUse, :MaSoKyTen, :DiaChi, :GioiTinh, :MaBacSyDieuTri, :TenBacSyDieuTri, :MaBacSyThuThuat, :TenBacSyThuThuat, :NgayThucHienTT, :Introducer, :DCLoaiKhac, :DCPhai, :DCPigtail, :DCThuocCanQuang, :TTQTDuongVao, :TTQTTienTrinh, :TTQTAnhMaTaPath, :KQDMCVanhTrai, :KQDMCLienThatTruoc, :KQDMMu, :KQDMVanhPhai, :KQCBTEF, :KQCBTRoiLoan, :ThamDoKemTheo, :BienChungVaXuLi, :NhanXetKhac, :KetLuan" +
                        ")   RETURNING IDKetQua INTO :IDKetQua";
                }
                oracleCommand = new MDB.MDBCommand(sql, oracleConnection);
                if (rowCount <= 0)
                {
                    obj.IDPhieu = IDphieuNext;
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("IDPhieu", obj.IDPhieu));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("LoaiPhieu", obj.LoaiPhieu));
                }
                oracleCommand.Parameters.Add(new MDB.MDBParameter("MaQuanLy", obj.MaQuanLy));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("ChanDoan", obj.ChanDoan));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("MaBenhNhan", obj.MaBenhNhan));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("TenBenhNhan", obj.TenBenhNhan));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("Khoa", obj.Khoa));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("MaKhoa", obj.MaKhoa));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("Buong", obj.Buong));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("Giuong", obj.Giuong));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("MaGiuong", obj.MaGiuong));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("NgayTao", obj.NgayTao));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("NgaySua", obj.NgaySua));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("FLgUse", obj.FLgUse));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("MaSoKyTen", obj.MaSoKy));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("DiaChi", obj.DiaChi));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("GioiTinh", obj.GioiTinh));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("MaBacSyDieuTri", obj.MaBacSyDieuTri));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("TenBacSyDieuTri", obj.TenBacSyDieuTri));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("MaBacSyThuThuat", obj.MaBacSyThuThuat));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("TenBacSyThuThuat", obj.TenBacSyThuThuat));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("NgayThucHienTT", obj.NgayThucHienTT));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("Introducer", obj.Introducer));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("DCLoaiKhac", obj.DCLoaiKhac));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("DCPhai", obj.DCPhai));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("DCPigtail", obj.DCPigtail));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("DCThuocCanQuang", obj.DCThuocCanQuang));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("TTQTDuongVao", obj.TTQTDuongVao));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("TTQTTienTrinh", obj.TTQTTienTrinh));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("TTQTAnhMaTaPath", obj.TTQTAnhMaTaPath));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("KQDMCVanhTrai", obj.KQDMCVanhTrai));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("KQDMCLienThatTruoc", obj.KQDMCLienThatTruoc));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("KQDMMu", obj.KQDMMu));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("KQDMVanhPhai", obj.KQDMVanhPhai));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("KQCBTEF", obj.KQCBTEF));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("KQCBTRoiLoan", obj.KQCBTRoiLoan));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("ThamDoKemTheo", obj.ThamDoKemTheo));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("BienChungVaXuLi", obj.BienChungVaXuLi));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("NhanXetKhac", obj.NhanXetKhac));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("KetLuan", obj.KetLuan));

                if (!isUpdate)
                {
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("IDKetQua", obj.IDKetQua));
                }
                nRecord = oracleCommand.ExecuteNonQuery();
                if (nRecord > 0)
                {
                    if (!isUpdate)
                    {
                        decimal nextval = Common.ConDB_Decimal((oracleCommand.Parameters["IDKetQua"] as MDB.MDBParameter).Value);
                        obj.IDKetQua = nextval;
                    }
                }
                return nRecord > 0 ? true : false;
            }
            catch (Exception ex)
            {
                XuLyLoi.LogError(ex);
            }
            return false;
        }
        public static bool DeleteByIDKetqua(MDB.MDBConnection oracleConnection, decimal IDBienBan, decimal typ)
        {
            try
            {
                string sql = "";
                MDB.MDBCommand oracleCommand;
                sql = @"DELETE FROM PhieuTraKetQuaDongMachVanh WHERE IDKetqua  = " + IDBienBan.ToString() + " and LoaiPhieu = " + typ.ToString();
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
    }
}
