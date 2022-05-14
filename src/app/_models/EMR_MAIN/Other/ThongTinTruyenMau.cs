
using EMR.KyDienTu;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using PMS.Access; 

namespace EMR_MAIN.DATABASE.Other
{
    public class ThongTinTruyenMau : ThongTinKy
    {
        public ThongTinTruyenMau()
        {
            TableName = "THONGTINTRUYENMAU";
            TablePrimaryKeyName = "ID";
            IDMauPhieu = (int)DanhMucPhieu.TM;
            TenMauPhieu = DanhMucPhieu.TM.Description();
        }
        [MoTaDuLieu("Mã định danh")]
		public decimal IDThongTinTruyenMau { get; set; }
		[MoTaDuLieu("Sở Y Tế")]
		public string SoYTe { get; set; }
        [MoTaDuLieu("Bệnh viện")]
		public string BenhVien { get; set; }
        public string MaSo { get; set; }
        public string SoVaoVien { get; set; }
        public string HoTen { get; set; }
        [MoTaDuLieu("Tuổi bệnh nhân")]
		public string Tuoi { get; set; }
        [MoTaDuLieu("Giới tính bệnh nhân")]
		public string GioiTinh { get; set; }
        [MoTaDuLieu("Chẩn đoán bệnh")]
		public string ChanDoan { get; set; }
        public string KhoaPhong { get; set; }
        public string SoGiuong { get; set; }
        public string LoaiChePhamMau { get; set; }
        public string SoLuong { get; set; }
        public string DonVi { get; set; }
        public string MaChePhamMau { get; set; }
        public DateTime NgayLayMau { get; set; }
        public DateTime HanDung { get; set; }
        public string NhomMauNguoiBenh { get; set; }
        public string NhomMauChePham { get; set; }
        public string XetNghiemKhac { get; set; }
        public string MoiTruongMuoiOng1 { get; set; }
        public string MoiTruongThuongOng1 { get; set; }
        public string MoiTruongMuoiOng2 { get; set; }
        public string MoiTruongThuongOng2 { get; set; }
        public DateTime ThoiGianKy { get; set; }
        public string PhuTrachXN { get; set; }
        public string NguoiLamXN1 { get; set; }
        public string NguoiLamXN2 { get; set; }
        public string LanTruyen { get; set; }
        public string DinhNhomMau { get; set; }
        public string DinhNhomNguoiNhan { get; set; }
        public string PhanUngCheo { get; set; }
        public DateTime ThoiGianBatDauTruyen { get; set; }
        public DateTime ThoiGianNgungTruyen { get; set; }
        public string SoLuongThucTe { get; set; }
        public string NhanXet { get; set; }
        [MoTaDuLieu("Bác sỹ điều trị")]
		public string BacSyDieuTri { get; set; }
        [MoTaDuLieu("Họ tên điều dưỡng")]
		public string DieuDuongTruyenMau { get; set; }
        [MoTaDuLieu("Ngày tạo", null, 0, 0)]
		public DateTime NgayTao { get; set; }
        [MoTaDuLieu("Ngày sửa", null, 0, 0)]
		public DateTime NgaySua { get; set; }
        public int TrangThai { get; set; } // 1: Hoat dong ; 0 : Da xoa

        public List<ThongTinTheoDoiTruyenMau> TheoDoiTruyenMau { get; set; }
        [MoTaDuLieu("Chọn", null, 0, 0)]
		public bool Chon { get; set; }
        public string MaNVPhuTrachXN { get; set; }
        public string MaNVNguoiLamXN1 { get; set; }
        public string MaNVNguoiLamXN2 { get; set; }
        public string MaNVBacSyDieuTri { get; set; }
        public string MaNVDieuDuongTruyenMau { get; set; }
        [MoTaDuLieu("Mã quản lý: mã duy nhất trong 1 đợt khám chữa bệnh (kcb), không trùng giữa các đợt kcb khác nhau","",1)]
		public decimal MaQuanLy { get; set; }
        public string NhomMauNguoiBenhRH { get; set; }
        public string NhomMauChePhamRH { get; set; } // 15/09/2021 End by Hòa Issues 73390 truyền danh sách phiếu máu qua EMR
        public string HanDungKhac { get; set; }
        public bool IsHanDungKhac { get; set; }
        //public string MaSoKyTen { get; set; }
        [MoTaDuLieu("Đã ký", null, 0, 0)]
		public bool DaKy { get; set; }
        public string TTMAUTRUYENChiTiet { get; set; }
        public List<TTMAUTRUYEN> listTTMAUTRUYEN { get; set; }
    }
    public class TTMAUTRUYEN
    {
        public int STT { get; set; }
        public string Maso { get; set; }
        public string TenLoaiChePham { get; set; }
        public string DonVi { get; set; }
        public string NgaySanXuat { get; set; }
        public string HanSuDung { get; set; }
    }

    public class ThongTinTheoDoiTruyenMau
    {
        [MoTaDuLieu("Mã định danh")]
		public decimal IDThongTinTheoDoiTruyenMau { get; set; }
        [MoTaDuLieu("Mã định danh")]
		public decimal IDThongTinTruyenMau { get; set; }
        public DateTime ThoiGianTheoDoi { get; set; }
        public string TocDoTruyen { get; set; }
        public string MauSacDa { get; set; }
        [MoTaDuLieu("Nhịp thở")]
		public string NhipTho { get; set; }
        [MoTaDuLieu("Mạch")]
		public string Mach { get; set; }
        [MoTaDuLieu("Huyết áp")]
		public string HuyetAp { get; set; }
        public string ThanNhiet { get; set; }
        public string DienBienKhac { get; set; }

        public static bool InsertOrUpdate(MDB.MDBConnection oracleConnection, ThongTinTheoDoiTruyenMau thongTinTheoDoiTruyenMau)
        {
            try
            {
                string sql = @"SELECT IDTHONGTINTHEODOITRUYENMAU FROM THONGTINTRUYENMAU_THEODOI WHERE IDTHONGTINTHEODOITRUYENMAU = :IDTHONGTINTHEODOITRUYENMAU";
                MDB.MDBCommand oracleCommand = new MDB.MDBCommand(sql, oracleConnection);
                oracleCommand.Parameters.Add("IDTHONGTINTHEODOITRUYENMAU", thongTinTheoDoiTruyenMau.IDThongTinTheoDoiTruyenMau);
                MDB.MDBDataReader oracleDataReader = oracleCommand.ExecuteReader();
                int rowCount = 0;
                while (oracleDataReader.Read()) rowCount++;
                if (rowCount > 0)
                {
                    sql = "update THONGTINTRUYENMAU_THEODOI set IDThongTinTruyenMau =:IDThongTinTruyenMau, ThoiGianTheoDoi= to_date(:ThoiGianTheoDoi,'yyyyMMddHH24mi'), TocDoTruyen =:TocDoTruyen,"
                           + " MauSacDa = :MauSacDa, NhipTho =:NhipTho, Mach =:Mach, HuyetAp =:HuyetAp, ThanNhiet =:ThanNhiet,DienBienKhac =:DienBienKhac where IDTHONGTINTHEODOITRUYENMAU = " + thongTinTheoDoiTruyenMau.IDThongTinTheoDoiTruyenMau + "";
                }
                else
                {
                    sql = @"insert into THONGTINTRUYENMAU_THEODOI(IDTHONGTINTRUYENMAU,ThoiGianTheoDoi, TocDoTruyen, MauSacDa, NhipTho, Mach, HuyetAp, ThanNhiet, DienBienKhac) values (:IDTHONGTINTRUYENMAU,to_date(:ThoiGianTheoDoi,'yyyyMMddHH24mi'), :TocDoTruyen, :MauSacDa, :NhipTho, :Mach, :HuyetAp, :ThanNhiet, :DienBienKhac)";
                }
                oracleCommand = new MDB.MDBCommand(sql, oracleConnection);
                oracleCommand.Parameters.Add(new MDB.MDBParameter("IDThongTinTruyenMau", thongTinTheoDoiTruyenMau.IDThongTinTruyenMau));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("ThoiGianTheoDoi", thongTinTheoDoiTruyenMau.ThoiGianTheoDoi.ToString("yyyyMMddHHmm")));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("TocDoTruyen", thongTinTheoDoiTruyenMau.TocDoTruyen));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("MauSacDa", thongTinTheoDoiTruyenMau.MauSacDa));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("NhipTho", thongTinTheoDoiTruyenMau.NhipTho));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("Mach", thongTinTheoDoiTruyenMau.Mach));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("HuyetAp", thongTinTheoDoiTruyenMau.HuyetAp));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("ThanNhiet", thongTinTheoDoiTruyenMau.ThanNhiet));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("DienBienKhac", thongTinTheoDoiTruyenMau.DienBienKhac));

                int n = oracleCommand.ExecuteNonQuery();
                return n > 0 ? true : false;
            }
            catch (Exception ex)
            {
                XuLyLoi.LogError(ex);
            }
            return false;
        }
        public static bool DeleteByID(MDB.MDBConnection oracleConnection, decimal ID)
        {
            try
            {
                string sql = @"delete from thongtintruyenmau_theodoi where IDThongTinTheoDoiTruyenMau = :IDThongTinTheoDoiTruyenMau";
                MDB.MDBCommand oracleCommand = new MDB.MDBCommand(sql, oracleConnection);
                oracleCommand.Parameters.Add("IDThongTinTheoDoiTruyenMau", ID);
                int n = oracleCommand.ExecuteNonQuery();
                return n > 0 ? true : false;
            }
            catch (Exception ex)
            {
                XuLyLoi.LogError(ex);
            }
            return false;
        }
        public static bool DeleteByIDThongTinTruyenMau(MDB.MDBConnection oracleConnection, decimal IDTruyenMau)
        {
            try
            {
                string sql = @"SELECT IDTHONGTINTHEODOITRUYENMAU FROM THONGTINTRUYENMAU_THEODOI WHERE IDTHONGTINTRUYENMAU = :IDTHONGTINTRUYENMAU";
                MDB.MDBCommand oracleCommand = new MDB.MDBCommand(sql, oracleConnection);
                oracleCommand.Parameters.Add("IDTHONGTINTRUYENMAU", IDTruyenMau);
                MDB.MDBDataReader oracleDataReader = oracleCommand.ExecuteReader();
                int rowCount = 0;
                while (oracleDataReader.Read()) rowCount++;
                if (rowCount > 0)
                {
                    sql = @"DELETE FROM THONGTINTRUYENMAU_THEODOI WHERE IDTHONGTINTRUYENMAU = :IDTHONGTINTRUYENMAU";
                    oracleCommand = new MDB.MDBCommand(sql, oracleConnection);
                    oracleCommand.Parameters.Add("IDTHONGTINTRUYENMAU", IDTruyenMau);
                    int n = oracleCommand.ExecuteNonQuery();
                    return n > 0;
                }
                else
                {
                    return true;
                }
            }
            catch (Exception ex)
            {
                XuLyLoi.LogError(ex);
            }
            return false;
        }

    }

    public class ThongTinTruyenMauFunc
    {
        public const string TableName = "thongtintruyenmau";
        public const string TablePrimaryKeyName = "idthongtintruyenmau";

        public static decimal InsertOrUpdate(MDB.MDBConnection MyConnection, ThongTinTruyenMau ThongTinTruyenMau)
        {
            string sql = @"SELECT IDTHONGTINTRUYENMAU FROM THONGTINTRUYENMAU WHERE IDTHONGTINTRUYENMAU = :IDTHONGTINTRUYENMAU";
            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
            Command.Parameters.Add(new MDB.MDBParameter("IDTHONGTINTRUYENMAU", ThongTinTruyenMau.IDThongTinTruyenMau));
            MDB.MDBDataReader DataReader = Command.ExecuteReader();
            int rowCount = 0;
            while (DataReader.Read()) rowCount++;
            decimal sequence_nextval = 0;
            if (rowCount == 1)
            {
                sequence_nextval = ThongTinTruyenMau.IDThongTinTruyenMau;
                sql = @"update THONGTINTRUYENMAU set SoYTe =:SoYTe, BenhVien=:BenhVien, MaSo=:MaSo, MaQuanLy=:MaQuanLy, SoVaoVien=:SoVaoVien, HoTen=:HoTen, Tuoi=:Tuoi, GioiTinh=:GioiTinh, ChanDoan=:ChanDoan, KhoaPhong=:KhoaPhong,"
                        + " SoGiuong= :SoGiuong, LoaiChePhamMau=:LoaiChePhamMau, SoLuong =:SoLuong, DonVi =:DonVi, MaChePhamMau =:MaChePhamMau, NgayLayMau= to_date(:NgayLayMau,'yyyyMMddHH24mi'), HanDung= to_date(:HanDung,'yyyyMMddHH24mi'),"
                        + " NhomMauNguoiBenh=:NhomMauNguoiBenh,NhomMauChePham= :NhomMauChePham, XetNghiemKhac= :XetNghiemKhac, MoiTruongMuoiOng1= :MoiTruongMuoiOng1,MoiTruongThuongOng1 =:MoiTruongThuongOng1,"
                        + " MoiTruongMuoiOng2=:MoiTruongMuoiOng2,MoiTruongThuongOng2 =:MoiTruongThuongOng2,ThoiGianKy= to_date(:ThoiGianKy,'yyyyMMddHH24mi'), PhuTrachXN = :PhuTrachXN, NguoiLamXN1 =:NguoiLamXN1,"
                        + " NguoiLamXN2 =:NguoiLamXN2, LanTruyen =:LanTruyen, DinhNhomMau = :DinhNhomMau,DinhNhomNguoiNhan=:DinhNhomNguoiNhan,PhanUngCheo=:PhanUngCheo,ThoiGianBatDauTruyen= to_date(:ThoiGianBatDauTruyen,'yyyyMMddHH24mi'),"
                        + " ThoiGianNgungTruyen= to_date(:ThoiGianNgungTruyen,'yyyyMMddHH24mi'), SoLuongThucTe=:SoLuongThucTe, NhanXet =:NhanXet, BacSyDieuTri=:BacSyDieuTri, DieuDuongTruyenMau =:DieuDuongTruyenMau,"
                        + " NgayTao= to_date(:NgayTao,'yyyyMMddHH24mi'), NgaySua= to_date(:NgaySua,'yyyyMMddHH24mi'), MaNVPhuTrachXN = :MaNVPhuTrachXN, MaNVNguoiLamXN1 = :MaNVNguoiLamXN1, MaNVNguoiLamXN2 = :MaNVNguoiLamXN2, "
                        + " MaNVBacSyDieuTri= :MaNVBacSyDieuTri, MaNVDieuDuongTruyenMau = :MaNVDieuDuongTruyenMau, NhomMauNguoiBenhRH=:NhomMauNguoiBenhRH, HanDungKhac=:HanDungKhac, IsHanDungKhac=:IsHanDungKhac, TTMAUTRUYENChiTiet = :TTMAUTRUYENChiTiet"
                        + " WHERE IDThongTinTruyenMau = " + ThongTinTruyenMau.IDThongTinTruyenMau + "";
            }
            else
            {
                sql = @"select ID_THONGTINTRUYENMAU_SEQ.nextval sequence_nextval from dual";
                Command = new MDB.MDBCommand(sql, MyConnection);
                DataReader = Command.ExecuteReader();
                while (DataReader.Read())
                {
                    sequence_nextval = decimal.Parse(DataReader["sequence_nextval"].ToString());
                }
                sql = @"insert into THONGTINTRUYENMAU (IDThongTinTruyenMau, SoYTe, BenhVien, MaSo, MaQuanLy, SoVaoVien, HoTen, Tuoi, GioiTinh, ChanDoan, KhoaPhong, SoGiuong,LoaiChePhamMau, SoLuong, DonVi,"
                        + " MaChePhamMau,NgayLayMau,HanDung, NhomMauNguoiBenh, NhomMauChePham, XetNghiemKhac, MoiTruongMuoiOng1, MoiTruongThuongOng1, MoiTruongMuoiOng2, MoiTruongThuongOng2, ThoiGianKy, PhuTrachXN, "
                        + " NguoiLamXN1, NguoiLamXN2, LanTruyen, DinhNhomMau, DinhNhomNguoiNhan, PhanUngCheo, ThoiGianBatDauTruyen, ThoiGianNgungTruyen, SoLuongThucTe, NhanXet, BacSyDieuTri, DieuDuongTruyenMau, NgayTao, NgaySua, "
                        + " MaNVPhuTrachXN, MaNVNguoiLamXN1, MaNVNguoiLamXN2, MaNVBacSyDieuTri, MaNVDieuDuongTruyenMau, NhomMauNguoiBenhRH,HanDungKhac, IsHanDungKhac, TTMAUTRUYENChiTiet) "
                        + " values (:IDThongTinTruyenMau, :SoYTe, :BenhVien, :MaSo, :MaQuanLy, :SoVaoVien, :HoTen, :Tuoi, :GioiTinh, :ChanDoan, :KhoaPhong, :SoGiuong,:LoaiChePhamMau, :SoLuong, :DonVi,"
                        + " :MaChePhamMau,to_date(:NgayLayMau,'yyyyMMddHH24mi'),to_date(:HanDung,'yyyyMMddHH24mi'), :NhomMauNguoiBenh, :NhomMauChePham, :XetNghiemKhac, :MoiTruongMuoiOng1, :MoiTruongThuongOng1, :MoiTruongMuoiOng2, :MoiTruongThuongOng2, to_date(:ThoiGianKy,'yyyyMMddHH24mi'), :PhuTrachXN, "
                        + " :NguoiLamXN1, :NguoiLamXN2, :LanTruyen, :DinhNhomMau, :DinhNhomNguoiNhan, :PhanUngCheo, to_date(:ThoiGianBatDauTruyen,'yyyyMMddHH24mi'), to_date(:ThoiGianNgungTruyen,'yyyyMMddHH24mi'), :SoLuongThucTe, :NhanXet, :BacSyDieuTri, :DieuDuongTruyenMau, to_date(:NgayTao,'yyyyMMddHH24mi'), to_date(:NgaySua,'yyyyMMddHH24mi'), "
                        + " :MaNVPhuTrachXN, :MaNVNguoiLamXN1, :MaNVNguoiLamXN2, :MaNVBacSyDieuTri, :MaNVDieuDuongTruyenMau, :NhomMauNguoiBenhRH,:HanDungKhac,:IsHanDungKhac, :TTMAUTRUYENChiTiet)";
            }
            Command = new MDB.MDBCommand(sql, MyConnection);
            if (rowCount != 1)
            {
                Command.Parameters.Add(new MDB.MDBParameter("IDThongTinTruyenMau", sequence_nextval));
            }
            Command.Parameters.Add(new MDB.MDBParameter("SoYTe", ThongTinTruyenMau.SoYTe));
            Command.Parameters.Add(new MDB.MDBParameter("BenhVien", ThongTinTruyenMau.BenhVien));
            Command.Parameters.Add(new MDB.MDBParameter("MaSo", ThongTinTruyenMau.MaSo));
            Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", ThongTinTruyenMau.MaQuanLy));
            Command.Parameters.Add(new MDB.MDBParameter("SoVaoVien", ThongTinTruyenMau.SoVaoVien));
            Command.Parameters.Add(new MDB.MDBParameter("HoTen", ThongTinTruyenMau.HoTen));
            Command.Parameters.Add(new MDB.MDBParameter("Tuoi", ThongTinTruyenMau.Tuoi));
            Command.Parameters.Add(new MDB.MDBParameter("GioiTinh", ThongTinTruyenMau.GioiTinh));
            Command.Parameters.Add(new MDB.MDBParameter("ChanDoan", ThongTinTruyenMau.ChanDoan));
            Command.Parameters.Add(new MDB.MDBParameter("KhoaPhong", ThongTinTruyenMau.KhoaPhong));
            Command.Parameters.Add(new MDB.MDBParameter("SoGiuong", ThongTinTruyenMau.SoGiuong));
            Command.Parameters.Add(new MDB.MDBParameter("LoaiChePhamMau", ThongTinTruyenMau.LoaiChePhamMau));
            Command.Parameters.Add(new MDB.MDBParameter("SoLuong", ThongTinTruyenMau.SoLuong));
            Command.Parameters.Add(new MDB.MDBParameter("DonVi", ThongTinTruyenMau.DonVi));
            Command.Parameters.Add(new MDB.MDBParameter("MaChePhamMau", ThongTinTruyenMau.MaChePhamMau));
            Command.Parameters.Add(new MDB.MDBParameter("NgayLayMau", ThongTinTruyenMau.NgayLayMau.ToString("yyyyMMddHHmm")));
            Command.Parameters.Add(new MDB.MDBParameter("HanDung", ThongTinTruyenMau.HanDung.ToString("yyyyMMddHHmm")));
            Command.Parameters.Add(new MDB.MDBParameter("NhomMauNguoiBenh", ThongTinTruyenMau.NhomMauNguoiBenh));
            Command.Parameters.Add(new MDB.MDBParameter("NhomMauChePham", ThongTinTruyenMau.NhomMauChePham));
            Command.Parameters.Add(new MDB.MDBParameter("XetNghiemKhac", ThongTinTruyenMau.XetNghiemKhac));
            Command.Parameters.Add(new MDB.MDBParameter("MoiTruongMuoiOng1", ThongTinTruyenMau.MoiTruongMuoiOng1));
            Command.Parameters.Add(new MDB.MDBParameter("MoiTruongThuongOng1", ThongTinTruyenMau.MoiTruongThuongOng1));
            Command.Parameters.Add(new MDB.MDBParameter("MoiTruongMuoiOng2", ThongTinTruyenMau.MoiTruongMuoiOng2));
            Command.Parameters.Add(new MDB.MDBParameter("MoiTruongThuongOng2", ThongTinTruyenMau.MoiTruongThuongOng2));
            Command.Parameters.Add(new MDB.MDBParameter("ThoiGianKy", ThongTinTruyenMau.ThoiGianKy.ToString("yyyyMMddHHmm")));
            Command.Parameters.Add(new MDB.MDBParameter("PhuTrachXN", ThongTinTruyenMau.PhuTrachXN));
            Command.Parameters.Add(new MDB.MDBParameter("NguoiLamXN1", ThongTinTruyenMau.NguoiLamXN1));
            Command.Parameters.Add(new MDB.MDBParameter("NguoiLamXN2", ThongTinTruyenMau.NguoiLamXN2));
            Command.Parameters.Add(new MDB.MDBParameter("LanTruyen", ThongTinTruyenMau.LanTruyen));
            Command.Parameters.Add(new MDB.MDBParameter("DinhNhomMau", ThongTinTruyenMau.DinhNhomMau));
            Command.Parameters.Add(new MDB.MDBParameter("DinhNhomNguoiNhan", ThongTinTruyenMau.DinhNhomNguoiNhan));
            Command.Parameters.Add(new MDB.MDBParameter("PhanUngCheo", ThongTinTruyenMau.PhanUngCheo));
            Command.Parameters.Add(new MDB.MDBParameter("ThoiGianBatDauTruyen", ThongTinTruyenMau.ThoiGianBatDauTruyen.ToString("yyyyMMddHHmm")));
            Command.Parameters.Add(new MDB.MDBParameter("ThoiGianNgungTruyen", ThongTinTruyenMau.ThoiGianNgungTruyen.ToString("yyyyMMddHHmm")));
            Command.Parameters.Add(new MDB.MDBParameter("SoLuongThucTe", ThongTinTruyenMau.SoLuongThucTe));
            Command.Parameters.Add(new MDB.MDBParameter("NhanXet", ThongTinTruyenMau.NhanXet));
            Command.Parameters.Add(new MDB.MDBParameter("BacSyDieuTri", ThongTinTruyenMau.BacSyDieuTri));
            Command.Parameters.Add(new MDB.MDBParameter("DieuDuongTruyenMau", ThongTinTruyenMau.DieuDuongTruyenMau));
            Command.Parameters.Add(new MDB.MDBParameter("NgayTao", ThongTinTruyenMau.NgayTao.ToString("yyyyMMddHHmm")));
            Command.Parameters.Add(new MDB.MDBParameter("NgaySua", ThongTinTruyenMau.NgaySua.ToString("yyyyMMddHHmm")));
            Command.Parameters.Add(new MDB.MDBParameter("MaNVPhuTrachXN", ThongTinTruyenMau.MaNVPhuTrachXN));
            Command.Parameters.Add(new MDB.MDBParameter("MaNVNguoiLamXN1", ThongTinTruyenMau.MaNVNguoiLamXN1));
            Command.Parameters.Add(new MDB.MDBParameter("MaNVNguoiLamXN2", ThongTinTruyenMau.MaNVNguoiLamXN2));
            Command.Parameters.Add(new MDB.MDBParameter("MaNVBacSyDieuTri", ThongTinTruyenMau.MaNVBacSyDieuTri));
            Command.Parameters.Add(new MDB.MDBParameter("MaNVDieuDuongTruyenMau", ThongTinTruyenMau.MaNVDieuDuongTruyenMau));
            Command.Parameters.Add(new MDB.MDBParameter("NhomMauNguoiBenhRH", ThongTinTruyenMau.NhomMauNguoiBenhRH));
            Command.Parameters.Add(new MDB.MDBParameter("HanDungKhac", ThongTinTruyenMau.HanDungKhac));
            Command.Parameters.Add(new MDB.MDBParameter("IsHanDungKhac", ThongTinTruyenMau.IsHanDungKhac ? 1 : 0));
            Command.Parameters.Add(new MDB.MDBParameter("TTMAUTRUYENChiTiet", ThongTinTruyenMau.TTMAUTRUYENChiTiet));

            int n = Command.ExecuteNonQuery();
            bool IsSuccess;
            if (n > 0 && ThongTinTruyenMau.TheoDoiTruyenMau != null && ThongTinTruyenMau.TheoDoiTruyenMau.Count > 0)
            {
                foreach (ThongTinTheoDoiTruyenMau TheoDoiTruyenMau in ThongTinTruyenMau.TheoDoiTruyenMau)
                {
                    TheoDoiTruyenMau.IDThongTinTruyenMau = sequence_nextval;
                    IsSuccess = ThongTinTheoDoiTruyenMau.InsertOrUpdate(MyConnection, TheoDoiTruyenMau);
                }
            }
            return sequence_nextval;
        }
        public static List<ThongTinTruyenMau> GetData(MDB.MDBConnection MyConnection, string IDThongTinTruyenMau, decimal MaQuanLy, string TenKhoa)
        {
            List<ThongTinTruyenMau> lstData = new List<ThongTinTruyenMau>();
            string sql = @"select * from THONGTINTRUYENMAU WHERE MaQuanLy = :MaQuanLy ";
            if (!String.IsNullOrEmpty(IDThongTinTruyenMau))
            {
                sql += " and IDThongTinTruyenMau = " + IDThongTinTruyenMau + "";
            }
            sql += " ORDER BY NgayTao, NgaySua asc";
            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
            Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", MaQuanLy));
            MDB.MDBDataReader DataReader = Command.ExecuteReader();
            while (DataReader.Read())
            {
                List<ThongTinTheoDoiTruyenMau> lstTheoDoi = new List<ThongTinTheoDoiTruyenMau>();
                sql = @"select * from THONGTINTRUYENMAU_THEODOI where IDTHONGTINTRUYENMAU = " + DataReader["IDThongTinTruyenMau"].ToString() + " ORDER BY ThoiGianTheoDoi";
                MDB.MDBCommand OracleCommand1 = new MDB.MDBCommand(sql, MyConnection);
                MDB.MDBDataReader OracleDataReader1 = OracleCommand1.ExecuteReader();
                while (OracleDataReader1.Read())
                {
                    lstTheoDoi.Add(new ThongTinTheoDoiTruyenMau
                    {
                        IDThongTinTheoDoiTruyenMau = decimal.Parse(OracleDataReader1["IDThongTinTheoDoiTruyenMau"].ToString()),
                        IDThongTinTruyenMau = decimal.Parse(OracleDataReader1["IDThongTinTruyenMau"].ToString()),
                        DienBienKhac = OracleDataReader1["DienBienKhac"].ToString(),
                        HuyetAp = OracleDataReader1["HuyetAp"].ToString(),
                        Mach = OracleDataReader1["Mach"].ToString(),
                        MauSacDa = OracleDataReader1["MauSacDa"].ToString(),
                        NhipTho = OracleDataReader1["NhipTho"].ToString(),
                        ThanNhiet = OracleDataReader1["ThanNhiet"].ToString(),
                        TocDoTruyen = OracleDataReader1["TocDoTruyen"].ToString(),
                        ThoiGianTheoDoi = (DateTime)OracleDataReader1["ThoiGianTheoDoi"]
                    });
                }
                lstData.Add(new ThongTinTruyenMau
                {
                    IDThongTinTruyenMau = decimal.Parse(DataReader["IDThongTinTruyenMau"].ToString()),
                    MaQuanLy = decimal.Parse(DataReader["MaQuanLy"].ToString()),
                    SoYTe = DataReader["SoYTe"].ToString(),
                    BenhVien = DataReader["BenhVien"].ToString(),
                    MaSo = DataReader["MaSo"].ToString(),
                    SoVaoVien = DataReader["SoVaoVien"].ToString(),
                    HoTen = DataReader["HoTen"].ToString(),
                    GioiTinh = DataReader["GioiTinh"].ToString(),
                    Tuoi = DataReader["Tuoi"].ToString(),
                    ChanDoan = DataReader["ChanDoan"].ToString(),
                    KhoaPhong = DataReader["KhoaPhong"].ToString(),
                    SoGiuong = DataReader["SoGiuong"].ToString(),
                    LoaiChePhamMau = DataReader["LoaiChePhamMau"].ToString(),
                    SoLuong = DataReader["SoLuong"].ToString(),
                    DonVi = DataReader["DonVi"].ToString(),
                    MaChePhamMau = DataReader["MaChePhamMau"].ToString(),
                    NhomMauNguoiBenh = DataReader["NhomMauNguoiBenh"].ToString(),
                    NhomMauChePham = DataReader["NhomMauChePham"].ToString(),
                    XetNghiemKhac = DataReader["XetNghiemKhac"].ToString(),
                    MoiTruongMuoiOng1 = DataReader["MoiTruongMuoiOng1"].ToString(),
                    MoiTruongMuoiOng2 = DataReader["MoiTruongMuoiOng2"].ToString(),
                    MoiTruongThuongOng1 = DataReader["MoiTruongThuongOng1"].ToString(),
                    MoiTruongThuongOng2 = DataReader["MoiTruongThuongOng2"].ToString(),
                    PhuTrachXN = DataReader["PhuTrachXN"].ToString(),
                    NguoiLamXN1 = DataReader["NguoiLamXN1"].ToString(),
                    NguoiLamXN2 = DataReader["NguoiLamXN2"].ToString(),
                    LanTruyen = DataReader["LanTruyen"].ToString(),
                    DinhNhomMau = DataReader["DinhNhomMau"].ToString(),
                    DinhNhomNguoiNhan = DataReader["DinhNhomNguoiNhan"].ToString(),
                    PhanUngCheo = DataReader["PhanUngCheo"].ToString(),
                    SoLuongThucTe = DataReader["SoLuongThucTe"].ToString(),
                    NhanXet = DataReader["NhanXet"].ToString(),
                    BacSyDieuTri = DataReader["BacSyDieuTri"].ToString(),
                    DieuDuongTruyenMau = DataReader["DieuDuongTruyenMau"].ToString(),
                    ThoiGianBatDauTruyen = (DateTime)DataReader["ThoiGianBatDauTruyen"],
                    NgayLayMau = (DateTime)DataReader["NgayLayMau"],
                    HanDung = (DateTime)DataReader["HanDung"],
                    ThoiGianKy = (DateTime)DataReader["ThoiGianKy"],
                    ThoiGianNgungTruyen = (DateTime)DataReader["ThoiGianNgungTruyen"],
                    NgaySua = (DateTime)DataReader["NgaySua"],
                    NgayTao = (DateTime)DataReader["NgayTao"],
                    MaNVPhuTrachXN = DataReader["MaNVPhuTrachXN"].ToString(),
                    MaNVNguoiLamXN1 = DataReader["MaNVNguoiLamXN1"].ToString(),
                    MaNVNguoiLamXN2 = DataReader["MaNVNguoiLamXN2"].ToString(),
                    MaNVBacSyDieuTri = DataReader["MaNVBacSyDieuTri"].ToString(),
                    MaNVDieuDuongTruyenMau = DataReader["MaNVDieuDuongTruyenMau"].ToString(),
                    TheoDoiTruyenMau = lstTheoDoi,
                    Chon = false,
                    NhomMauNguoiBenhRH = DataReader["NhomMauNguoiBenhRH"].ToString(),
                    IsHanDungKhac = DataReader["IsHanDungKhac"].ToString().Equals("1") ? true : false,
                    HanDungKhac = DataReader["HanDungKhac"].ToString(),
                    MaSoKy = DataReader["masokyten"].ToString(),
                    DaKy = !string.IsNullOrEmpty(DataReader["masokyten"].ToString()) ? true : false,
                    TTMAUTRUYENChiTiet = DataReader["TTMAUTRUYENChiTiet"].ToString()
                });
            }
            return lstData;
        }
        public static DataSet GetDataSet(MDB.MDBConnection MyConnection, string IDThongTinTruyenMau)
        {
            string sql = @"select a.*, to_char(NgayLayMau, 'dd/MM/yyyy') rptNgayLayMau, to_char(HanDung, 'dd/MM/yyyy') rptHanDung,to_char(ThoiGianKy, 'HH24:mi dd/MM/yyyy') rptThoiGianKy,"
                            + " to_char(ThoiGianBatDauTruyen, 'HH24:mi dd/MM/yyyy') rptThoiGianBatDauTruyen,to_char(ThoiGianNgungTruyen, 'HH24:mi dd/MM/yyyy') rptThoiGianNgungTruyenn  "
                            + " from THONGTINTRUYENMAU a WHERE IDThongTinTruyenMau =: IDThongTinTruyenMau ORDER BY NgayTao, NgaySua asc";
            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
            Command.Parameters.Add(new MDB.MDBParameter("IDThongTinTruyenMau", IDThongTinTruyenMau));
            MDB.MDBDataAdapter adt = new MDB.MDBDataAdapter(Command);
            var ds = new DataSet();
            adt.Fill(ds, "ThongTinTruyenMau");

            List<TTMAUTRUYEN> listTTMAUTRUYEN_In = new List<TTMAUTRUYEN>();
            if (ds.Tables[0].Rows.Count > 0)
            {
                string TTMAUTRUYENChiTiet = ds.Tables[0].Rows[0]["TTMAUTRUYENChiTiet"].ToString();
                     try
                {
                    listTTMAUTRUYEN_In = JsonConvert.DeserializeObject<List<TTMAUTRUYEN>>(TTMAUTRUYENChiTiet);
                }
                catch { listTTMAUTRUYEN_In = new List<TTMAUTRUYEN>(); }
                if(listTTMAUTRUYEN_In == null)
                {
                    listTTMAUTRUYEN_In =  new List<TTMAUTRUYEN>();
                }
            }
            DataTable dt = new DataTable("TTMAUTRUYEN");
            dt.Columns.Add("STT");
            dt.Columns.Add("Maso");
            dt.Columns.Add("TenLoaiChePham");
            dt.Columns.Add("DonVi");
            dt.Columns.Add("NgaySanXuat");
            dt.Columns.Add("HanSuDung");
            int i = 0;
            for ( i = 0; i < listTTMAUTRUYEN_In.Count; i++)
            {
                TTMAUTRUYEN item = listTTMAUTRUYEN_In[i];
                DataRow row = dt.NewRow();
                row[0] = item.STT;
                row[1] = item.Maso;
                row[2] = item.TenLoaiChePham;
                row[3] = item.DonVi;
                row[4] = item.NgaySanXuat;
                row[5] = item.HanSuDung;
                dt.Rows.Add(row);
            }
            if(i ==0)
            {
                TTMAUTRUYEN item = new TTMAUTRUYEN();
                DataRow row = dt.NewRow();
                row[0] ="";
                row[1] = "";
                row[2] ="";
                row[3] ="";
                row[4] = "";
                row[5] = "";
                dt.Rows.Add(row);
            }
            ds.Merge(dt);
            sql = @"select a.* , to_char(ThoiGianTheoDoi, 'HH24:mi dd/MM/yyyy') rptThoiGianTheoDoi from THONGTINTRUYENMAU_THEODOI a where IDThongTinTruyenMau = :IDThongTinTruyenMau ORDER BY ThoiGianTheoDoi";
            Command = new MDB.MDBCommand(sql, MyConnection);
            Command.Parameters.Add(new MDB.MDBParameter("IDThongTinTruyenMau", IDThongTinTruyenMau));
            MDB.MDBDataAdapter adt1 = new MDB.MDBDataAdapter(Command);
            adt1.Fill(ds, "TheoDoiTruyenMau");

            return ds;
        }
        public static List<string> GetListIdThongTinTruyenMau(MDB.MDBConnection oracleConnection, decimal MaQuanLy)
        {
            string sql = @"select IdThongTinTruyenMau from ThongTinTruyenMau where MaQuanLy = :MaQuanLy";
            MDB.MDBCommand oracleCommand = new MDB.MDBCommand(sql, oracleConnection);
            oracleCommand.Parameters.Add("MaQuanLy", MaQuanLy);
            MDB.MDBDataReader oracleDataReader = oracleCommand.ExecuteReader();
            List<string> listId = new List<string>();
            while (oracleDataReader.Read())
            {
                listId.Add(oracleDataReader["IdThongTinTruyenMau"].ToString());
            }
            return listId;
        }
        public static bool Delete(MDB.MDBConnection MyConnection, decimal IDThongTinTruyenMau)
        {
            bool deleteTheoDoi = ThongTinTheoDoiTruyenMau.DeleteByIDThongTinTruyenMau(MyConnection, IDThongTinTruyenMau);
            if (deleteTheoDoi)
            {
                string sql = @"DELETE FROM THONGTINTRUYENMAU WHERE IDTHONGTINTRUYENMAU = :IDTHONGTINTRUYENMAU";
                MDB.MDBCommand oracleCommand = new MDB.MDBCommand(sql, MyConnection);
                oracleCommand.Parameters.Add(new MDB.MDBParameter("IDTHONGTINTRUYENMAU", IDThongTinTruyenMau));
                int n = oracleCommand.ExecuteNonQuery();
                return n > 0;
            }
            return false;
        }
        public static int countPhieu(MDB.MDBConnection oracleConnection, string MaBenhAn)
        {
            int count = 0;
            string sql = @"SELECT COUNT(IDTHONGTINTRUYENMAU) FROM THONGTINTRUYENMAU WHERE MaSo = :MaBenhAn";
            MDB.MDBCommand oracleCommand = new MDB.MDBCommand(sql, oracleConnection);
            oracleCommand.Parameters.Add("MaBenhAn", MaBenhAn);
            oracleCommand.BindByName = true;
            MDB.MDBDataReader DataReader = oracleCommand.ExecuteReader();
            while (DataReader.Read())
            {
                int temp = 0;
                int.TryParse(DataReader["COUNT(IDTHONGTINTRUYENMAU)"].ToString(), out temp);
                count = temp;
                break;
            }
            return count;
        }
    }
}
