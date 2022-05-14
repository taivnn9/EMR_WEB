using EMR_MAIN.DATABASE.BenhAn;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;

namespace EMR_MAIN.DATABASE.BenhAnFunc
{
    public class BenhAnNgoaiTruDuhringBrocqFunc
    {
        public static void WriteXml(MDB.MDBConnection MyConnection)
        {
            string sql =
                   @"
                  select  a.*,  CTScanner HoSo_CTScanner, SieuAm HoSo_SieuAm, XetNghiem HoSo_XetNghiem,  Khac HoSo_Khac,  Khac_Text HoSo_Khac_Text,  ToanBoHoSo HoSo_ToanBoHoSo, Mach DauSinhTon_Mach,  NhietDo DauSinhTon_NhietDo,  HuyetAp DauSinhTon_HuyetAp,  NhipTho DauSinhTon_NhipTho,  CanNang DauSinhTon_CanNang  
                  from BenhAnNgoaiTruDuhringBrocq a inner join thongtindieutri b on a.maquanly = b.maquanly
                  where rownum = 1
                    ";
            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
            MDB.MDBDataReader DataReader = Command.ExecuteReader();

            var DataTable = new DataTable { TableName = "BenhAnNgoaiTruDuhringBrocq" };
            DataTable.Load(DataReader as IDataReader);
            DataTable.WriteXml("rptBenhAnNgoaiTruDuhringBrocq.xml");
        }
        public static DataSet SelectDataSet(MDB.MDBConnection MyConnection, decimal MaQuanLy)
        {
            string sql =
                   @"
                  select  a.*, f.hovaten BacSyDieuTriHoVaTen, g.hovaten TK_BacSyDieuTriHoVaTen, h.hovaten TongKet_BacSyDieuTriHoVaTen, d.hovaten NguoiGiaoHoSoHoVaTen,e.hovaten NguoiNhanHoSoHoVaTen, b.XQuang HoSo_XQuang, b.CTScanner HoSo_CTScanner, b.SieuAm HoSo_SieuAm, b.XetNghiem HoSo_XetNghiem,  b.Khac HoSo_Khac,  b.Khac_Text HoSo_Khac_Text,  b.ToanBoHoSo HoSo_ToanBoHoSo, b.Mach DauSinhTon_Mach, b.NhietDo DauSinhTon_NhietDo,  b.HuyetAp DauSinhTon_HuyetAp,  b.NhipTho DauSinhTon_NhipTho,  b.CanNang DauSinhTon_CanNang  , b.ChieuCao DauSinhTon_ChieuCao, b.BMI DauSinhTon_BMI, b.NgayRaVien 
                        from BenhAnNgoaiTruDuhringBrocq a  
                  left join thongtindieutri b on a.maquanly = b.maquanly 
                  left join nhanvien f on a.BacSiDieuTri = f.manhanvien
                  left join nhanvien g on a.TK_BacSiDieuTri = g.manhanvien
                  left join nhanvien h on a.TongKet_BacSyDieuTri = h.manhanvien
                  left join nhanvien d on a.NguoiGiaoHoSo = d.manhanvien
                  left join nhanvien e on a.NguoiNhanHoSo = e.manhanvien where a.maquanly = " + MaQuanLy.ToString(System.Globalization.CultureInfo.InvariantCulture);
            MDB.MDBDataAdapter adt = new MDB.MDBDataAdapter(sql, MyConnection);
            var ds = new DataSet();
            adt.Fill(ds, "Table");
            
            return ds;

        }
        public static BenhAnNgoaiTruDuhringBrocq Select(MDB.MDBConnection MyConnection, decimal MaQuanLy)
        {
            var obj = new BenhAnNgoaiTruDuhringBrocq();
            try
            {
                #region
                string sql =
                          @"select * 
                        from BenhAnNgoaiTruDuhringBrocq 
                        where MaQuanLy = :MaQuanLy";
                #endregion
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", MaQuanLy));
                MDB.MDBDataReader DataReader = Command.ExecuteReader();
                while (DataReader.Read())
                {
                    // Phần chung Hành chính
                    obj.MaQuanLy = DataReader.GetDecimal("MaQuanLy");
                    obj.DieuTriNgoaiTruTu = DataReader["DieuTriNgoaiTruTu"] != DBNull.Value ? (DateTime?)Convert.ToDateTime(DataReader["DieuTriNgoaiTruTu"]) : null;
                    obj.DieuTriNgoaiTruDen = DataReader["DieuTriNgoaiTruDen"] != DBNull.Value ? (DateTime?)Convert.ToDateTime(DataReader["DieuTriNgoaiTruDen"]) : null;
                    obj.SoCMND = DataReader["SoCMND"].ToString();
                    obj.BaoHiem = DataReader["BaoHiem"] != DBNull.Value ? (DateTime?)Convert.ToDateTime(DataReader["BaoHiem"]) : null;
                    obj.ChanDoan_TuyenTruoc = DataReader["ChanDoan_TuyenTruoc"].ToString();
                    obj.ChanDoanBanDau = DataReader["ChanDoanBanDau"].ToString();
                    obj.ChanDoanTaiKham1 = DataReader["ChanDoanTaiKham1"].ToString();
                    obj.ChanDoanTaiKham2 = DataReader["ChanDoanTaiKham2"].ToString();
                    obj.ChanDoanTaiKham3 = DataReader["ChanDoanTaiKham3"].ToString();
                    obj.ChanDoanTaiKham4 = DataReader["ChanDoanTaiKham4"].ToString();
                    obj.BenhPhu = DataReader["BenhPhu"].ToString();
                    obj.KetQuaDieuTri = DataReader.GetInt("KetQuaDieuTri");
                    obj.BienChung_Text = DataReader["BienChung_Text"].ToString();
                    obj.GDPhongKeHoach = DataReader["GDPhongKeHoach"].ToString();
                    obj.GDPhongKhamBenh = DataReader["GDPhongKhamBenh"].ToString();

                    // hỏi bệnh, tái khám
                    obj.ThoiGianKhoiPhatBenh = DataReader["ThoiGianKhoiPhatBenh"].ToString();
                    obj.TuoiBatDauDieutri = DataReader["TuoiBatDauDieutri"].ToString();
                    obj.VaoVienLanThuMay = DataReader["VaoVienLanThuMay"].ToString();
                    obj.TrieuChungKhoiPhat = DataReader["TrieuChungKhoiPhat"].ToString();
                    obj.QuaTrinhBenhLy = DataReader["QuaTrinhBenhLy"].ToString();
                    obj.DieuTriTruocDay = DataReader["DieuTriTruocDay"].ToString();
                    obj.TienSuBanThan_DiUngThuoc = DataReader["TienSuBanThan_DiUngThuoc"].ToString();
                    obj.TienSuBanThan_BenhKhac = DataReader["TienSuBanThan_BenhKhac"].ToString();
                    obj.TienSuGiaDinh_Khac = DataReader["TienSuGiaDinh_Khac"].ToString();
                    obj.ToanThan = DataReader["ToanThan"].ToString();
                    obj.CacBoPhan = DataReader["CacBoPhan"].ToString();
                    obj.Ngua = DataReader.GetInt("Ngua");
                    obj.SutCan = DataReader.GetInt("SutCan");
                    obj.KemAn = DataReader.GetInt("KemAn");
                    obj.Met = DataReader.GetInt("Met");
                    obj.DauRat = DataReader.GetInt("DauRat");
                    obj.TrieuChungCoNang_Khac = DataReader["TrieuChungCoNang_Khac"].ToString();
                    obj.NhanNheo = DataReader.GetInt("NhanNheo");
                    obj.Cang = DataReader.GetInt("Cang");
                    obj.DichXuatHuyet = DataReader.GetInt("DichXuatHuyet");
                    obj.DichTrong = DataReader.GetInt("DichTrong");
                    obj.DichMu = DataReader.GetInt("DichMu");
                    obj.TrenNenDaLanh = DataReader.GetInt("TrenNenDaLanh");
                    obj.TrenNenDaDo = DataReader.GetInt("TrenNenDaDo");
                    obj.BongNuoc_KichThuoc = DataReader["BongNuoc_KichThuoc"].ToString();
                    obj.BongNuoc_SoLuong = DataReader["BongNuoc_SoLuong"].ToString();
                    obj.KhoDongVay = DataReader.GetInt("KhoDongVay");
                    obj.Uot = DataReader.GetInt("Uot");
                    obj.VetTrot_SoLuong = DataReader["VetTrot_SoLuong"].ToString();
                    obj.MauVangAm = DataReader.GetInt("MauVangAm");
                    obj.MauNauDen = DataReader.GetInt("MauNauDen");
                    obj.Sui_Co = DataReader.GetInt("Sui_Co");
                    obj.ViTriTonThuong = DataReader["ViTriTonThuong"].ToString();
                    obj.DauHieuNikolsky = DataReader["DauHieuNikolsky"].ToString();
                    obj.GhiChu = DataReader["GhiChu"].ToString();
                    obj.CongThucMau = DataReader.GetInt("CongThucMau");
                    obj.CongThucMau_Text = DataReader["CongThucMau_Text"].ToString();
                    obj.SinhHoaMau = DataReader.GetInt("SinhHoaMau");
                    obj.SinhHoaMau_Text = DataReader["SinhHoaMau_Text"].ToString();
                    obj.TongPhanTichNuocTieu = DataReader.GetInt("TongPhanTichNuocTieu");
                    obj.TongPhanTichNuocTieu_Text = DataReader["TongPhanTichNuocTieu_Text"].ToString();
                    obj.XQuanNguc = DataReader.GetInt("XQuanNguc");
                    obj.XQuanNguc_Text = DataReader["XQuanNguc_Text"].ToString();
                    obj.SieuAmOBung = DataReader.GetInt("SieuAmOBung");
                    obj.SieuAmOBung_Text = DataReader["SieuAmOBung_Text"].ToString();
                    obj.SoiTuoiTimNam = DataReader.GetInt("SoiTuoiTimNam");
                    obj.XetNghiemTeBaoTzanck = DataReader["XetNghiemTeBaoTzanck"].ToString();
                    obj.MDHuynhQuangTrucTiep = DataReader["MDHuynhQuangTrucTiep"].ToString();
                    obj.MDHuynhQuangGianTiep = DataReader["MDHuynhQuangGianTiep"].ToString();
                    obj.SinhThietDa = DataReader["SinhThietDa"].ToString();
                    obj.PCRHerpes = DataReader["PCRHerpes"].ToString();
                    obj.XetNghiemKhac = DataReader["XetNghiemKhac"].ToString();
                    obj.ChanDoan = DataReader["ChanDoan"].ToString();
                    obj.DieuTri = DataReader["DieuTri"].ToString();
                    obj.HenTaiKham = DataReader["HenTaiKham"] != DBNull.Value ? (DateTime?)Convert.ToDateTime(DataReader["HenTaiKham"]) : null;
                    obj.BacSiDieuTri = DataReader["BacSiDieuTri"].ToString();
                    obj.TK_NgayTaiKham = DataReader["TK_NgayTaiKham"] != DBNull.Value ? (DateTime?)Convert.ToDateTime(DataReader["TK_NgayTaiKham"]) : null;
                    obj.TK_HoTen = DataReader["TK_HoTen"].ToString();
                    obj.TK_Mach = DataReader["TK_Mach"].ToString();
                    obj.TK_BenhNhanTuDanhGia = DataReader["TK_BenhNhanTuDanhGia"].ToString();
                    obj.TK_LamSangDaNiemMac = DataReader.GetInt("TK_LamSangDaNiemMac");
                    obj.TK_Than = DataReader["TK_Than"].ToString();
                    obj.TK_Phoi = DataReader["TK_Phoi"].ToString();
                    obj.TK_TieuHoa = DataReader["TK_TieuHoa"].ToString();
                    obj.TK_Tim = DataReader["TK_Tim"].ToString();
                    obj.TK_ThanKinh = DataReader["TK_ThanKinh"].ToString();
                    obj.TK_CoXuongKhop = DataReader["TK_CoXuongKhop"].ToString();
                    obj.TK_CacCoQuanKhac = DataReader["TK_CacCoQuanKhac"].ToString();
                    obj.TK_CanLamSang = DataReader["TK_CanLamSang"].ToString();
                    obj.TK_TacDungPhuCuaThuoc = DataReader["TK_TacDungPhuCuaThuoc"].ToString();
                    obj.TK_HuongDieuTriTiepTheo = DataReader["TK_HuongDieuTriTiepTheo"].ToString();
                    obj.TK_HenTaiKham = DataReader["TK_HenTaiKham"] != DBNull.Value ? (DateTime?) Convert.ToDateTime(DataReader["TK_HenTaiKham"]) : null;
                    obj.TK_BacSiDieuTri = DataReader["TK_BacSiDieuTri"].ToString();
                    

                    // phần tổng kết
                    obj.TongKet_QuaTrinhBenhLy = DataReader["TongKet_QuaTrinhBenhLy"].ToString();
                    obj.TomTatKetQua = DataReader["TomTatKetQua"].ToString();
                    obj.BenhChinh = DataReader["BenhChinh"].ToString();
                    obj.MaBenhChinh = DataReader["MaBenhChinh"].ToString();
                    obj.BenhKemTheo = DataReader["BenhKemTheo"].ToString();
                    obj.MaBenhKemTheo = DataReader["MaBenhKemTheo"].ToString();
                    obj.PhuongPhapDieuTri = DataReader["PhuongPhapDieuTri"].ToString();
                    obj.TinhTrangRaVien = DataReader["TinhTrangRaVien"].ToString();
                    obj.HuongDieuTri = DataReader["HuongDieuTri"].ToString();
                    obj.NguoiNhanHoSo = DataReader["NguoiNhanHoSo"].ToString();
                    obj.NguoiGiaoHoSo = DataReader["NguoiGiaoHoSo"].ToString();
                    obj.NgayTongKet = DataReader["NgayTongKet"] != DBNull.Value ? Convert.ToDateTime(DataReader["NgayTongKet"]) : DateTime.Now;
                    obj.TongKet_BacSyDieuTri = DataReader["TongKet_BacSyDieuTri"].ToString();
                    obj.TongKet_MaBacSyDieuTri = DataReader["TongKet_MaBacSyDieuTri"].ToString();
                }
            }
            catch (Exception ex)
            {
                XuLyLoi.Handle(ex);
            }

            return obj;
        }
        public static bool InsertOrUpdate(MDB.MDBConnection MyConnection, BenhAnNgoaiTruDuhringBrocq BenhAnNgoaiTruDuhringBrocq)
        {
            try
            {
                string sql =
                          @"select MaQuanLy 
                            from BenhAnNgoaiTruDuhringBrocq
                            where MaQuanLy = :MaQuanLy";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", BenhAnNgoaiTruDuhringBrocq.MaQuanLy));
                MDB.MDBDataReader DataReader = Command.ExecuteReader();
                int rowCount = 0;
                while (DataReader.Read()) rowCount++;
                if (rowCount == 1) return Update(MyConnection, BenhAnNgoaiTruDuhringBrocq);
                sql = @"
                       INSERT INTO BenhAnNgoaiTruDuhringBrocq 
                        (
                            MaQuanLy,
                            DieuTriNgoaiTruTu,
                            DieuTriNgoaiTruDen,
                            SoCMND,
                            BaoHiem,
                            ChanDoan_TuyenTruoc,
                            ChanDoanBanDau,
                            ChanDoanTaiKham1,
                            ChanDoanTaiKham2,
                            ChanDoanTaiKham3,
                            ChanDoanTaiKham4,
                            BenhPhu,
                            KetQuaDieuTri,
                            BienChung_Text,
                            GDPhongKeHoach,
                            GDPhongKhamBenh,
                            ThoiGianKhoiPhatBenh,
                            TuoiBatDauDieutri,
                            VaoVienLanThuMay,
                            TrieuChungKhoiPhat,
                            QuaTrinhBenhLy,
                            DieuTriTruocDay,
                            TienSuBanThan_DiUngThuoc,
                            TienSuBanThan_BenhKhac,
                            TienSuGiaDinh_Khac,
                            ToanThan,
                            CacBoPhan,
                            Ngua,
                            SutCan,
                            KemAn,
                            Met,
                            DauRat,
                            TrieuChungCoNang_Khac,
                            NhanNheo,
                            Cang,
                            DichXuatHuyet,
                            DichTrong,
                            DichMu,
                            TrenNenDaLanh,
                            TrenNenDaDo,
                            BongNuoc_KichThuoc,
                            BongNuoc_SoLuong,
                            KhoDongVay,
                            Uot,
                            VetTrot_SoLuong,
                            MauVangAm,
                            MauNauDen,
                            Sui_Co,
                            ViTriTonThuong,
                            DauHieuNikolsky,
                            GhiChu,
                            CongThucMau,
                            CongThucMau_Text,
                            SinhHoaMau,
                            SinhHoaMau_Text,
                            TongPhanTichNuocTieu,
                            TongPhanTichNuocTieu_Text,
                            XQuanNguc,
                            XQuanNguc_Text,
                            SieuAmOBung,
                            SieuAmOBung_Text,
                            SoiTuoiTimNam,
                            XetNghiemTeBaoTzanck,
                            MDHuynhQuangTrucTiep,
                            MDHuynhQuangGianTiep,
                            SinhThietDa,
                            PCRHerpes,
                            XetNghiemKhac,
                            ChanDoan,
                            DieuTri,
                            HenTaiKham,
                            BacSiDieuTri,
                            TK_NgayTaiKham,
                            TK_HoTen,
                            TK_Mach,
                            TK_BenhNhanTuDanhGia,
                            TK_LamSangDaNiemMac,
                            TK_Than,
                            TK_Phoi,
                            TK_TieuHoa,
                            TK_Tim,
                            TK_ThanKinh,
                            TK_CoXuongKhop,
                            TK_CacCoQuanKhac,
                            TK_CanLamSang,
                            TK_TacDungPhuCuaThuoc,
                            TK_HuongDieuTriTiepTheo,
                            TK_HenTaiKham,
                            TK_BacSiDieuTri,
                            TongKet_QuaTrinhBenhLy,
                            TomTatKetQua,
                            BenhChinh,
                            MaBenhChinh,
                            BenhKemTheo,
                            MaBenhKemTheo,
                            PhuongPhapDieuTri,
                            TinhTrangRaVien,
                            HuongDieuTri,
                            NguoiNhanHoSo,
                            NguoiGiaoHoSo,
                            NgayTongKet,
                            TongKet_BacSyDieuTri,
                            TongKet_MaBacSyDieuTri
                        )                 
                        VALUES
                        (
                            :MaQuanLy,
                            :DieuTriNgoaiTruTu,
                            :DieuTriNgoaiTruDen,
                            :SoCMND,
                            :BaoHiem,
                            :ChanDoan_TuyenTruoc,
                            :ChanDoanBanDau,
                            :ChanDoanTaiKham1,
                            :ChanDoanTaiKham2,
                            :ChanDoanTaiKham3,
                            :ChanDoanTaiKham4,
                            :BenhPhu,
                            :KetQuaDieuTri,
                            :BienChung_Text,
                            :GDPhongKeHoach,
                            :GDPhongKhamBenh,
                            :ThoiGianKhoiPhatBenh,
                            :TuoiBatDauDieutri,
                            :VaoVienLanThuMay,
                            :TrieuChungKhoiPhat,
                            :QuaTrinhBenhLy,
                            :DieuTriTruocDay,
                            :TienSuBanThan_DiUngThuoc,
                            :TienSuBanThan_BenhKhac,
                            :TienSuGiaDinh_Khac,
                            :ToanThan,
                            :CacBoPhan,
                            :Ngua,
                            :SutCan,
                            :KemAn,
                            :Met,
                            :DauRat,
                            :TrieuChungCoNang_Khac,
                            :NhanNheo,
                            :Cang,
                            :DichXuatHuyet,
                            :DichTrong,
                            :DichMu,
                            :TrenNenDaLanh,
                            :TrenNenDaDo,
                            :BongNuoc_KichThuoc,
                            :BongNuoc_SoLuong,
                            :KhoDongVay,
                            :Uot,
                            :VetTrot_SoLuong,
                            :MauVangAm,
                            :MauNauDen,
                            :Sui_Co,
                            :ViTriTonThuong,
                            :DauHieuNikolsky,
                            :GhiChu,
                            :CongThucMau,
                            :CongThucMau_Text,
                            :SinhHoaMau,
                            :SinhHoaMau_Text,
                            :TongPhanTichNuocTieu,
                            :TongPhanTichNuocTieu_Text,
                            :XQuanNguc,
                            :XQuanNguc_Text,
                            :SieuAmOBung,
                            :SieuAmOBung_Text,
                            :SoiTuoiTimNam,
                            :XetNghiemTeBaoTzanck,
                            :MDHuynhQuangTrucTiep,
                            :MDHuynhQuangGianTiep,
                            :SinhThietDa,
                            :PCRHerpes,
                            :XetNghiemKhac,
                            :ChanDoan,
                            :DieuTri,
                            :HenTaiKham,
                            :BacSiDieuTri,
                            :TK_NgayTaiKham,
                            :TK_HoTen,
                            :TK_Mach,
                            :TK_BenhNhanTuDanhGia,
                            :TK_LamSangDaNiemMac,
                            :TK_Than,
                            :TK_Phoi,
                            :TK_TieuHoa,
                            :TK_Tim,
                            :TK_ThanKinh,
                            :TK_CoXuongKhop,
                            :TK_CacCoQuanKhac,
                            :TK_CanLamSang,
                            :TK_TacDungPhuCuaThuoc,
                            :TK_HuongDieuTriTiepTheo,
                            :TK_HenTaiKham,
                            :TK_BacSiDieuTri,
                            :TongKet_QuaTrinhBenhLy,
                            :TomTatKetQua,
                            :BenhChinh,
                            :MaBenhChinh,
                            :BenhKemTheo,
                            :MaBenhKemTheo,
                            :PhuongPhapDieuTri,
                            :TinhTrangRaVien,
                            :HuongDieuTri,
                            :NguoiNhanHoSo,
                            :NguoiGiaoHoSo,
                            :NgayTongKet,
                            :TongKet_BacSyDieuTri,
                            :TongKet_MaBacSyDieuTri                          
                        )";
                Command = new MDB.MDBCommand(sql, MyConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", BenhAnNgoaiTruDuhringBrocq.MaQuanLy));
                Command.Parameters.Add(new MDB.MDBParameter("DieuTriNgoaiTruTu", BenhAnNgoaiTruDuhringBrocq.DieuTriNgoaiTruTu));
                Command.Parameters.Add(new MDB.MDBParameter("DieuTriNgoaiTruDen", BenhAnNgoaiTruDuhringBrocq.DieuTriNgoaiTruDen));
                Command.Parameters.Add(new MDB.MDBParameter("SoCMND", BenhAnNgoaiTruDuhringBrocq.SoCMND));
                Command.Parameters.Add(new MDB.MDBParameter("BaoHiem", BenhAnNgoaiTruDuhringBrocq.BaoHiem));
                Command.Parameters.Add(new MDB.MDBParameter("ChanDoan_TuyenTruoc", BenhAnNgoaiTruDuhringBrocq.ChanDoan_TuyenTruoc));
                Command.Parameters.Add(new MDB.MDBParameter("ChanDoanBanDau", BenhAnNgoaiTruDuhringBrocq.ChanDoanBanDau));
                Command.Parameters.Add(new MDB.MDBParameter("ChanDoanTaiKham1", BenhAnNgoaiTruDuhringBrocq.ChanDoanTaiKham1));
                Command.Parameters.Add(new MDB.MDBParameter("ChanDoanTaiKham2", BenhAnNgoaiTruDuhringBrocq.ChanDoanTaiKham2));
                Command.Parameters.Add(new MDB.MDBParameter("ChanDoanTaiKham3", BenhAnNgoaiTruDuhringBrocq.ChanDoanTaiKham3));
                Command.Parameters.Add(new MDB.MDBParameter("ChanDoanTaiKham4", BenhAnNgoaiTruDuhringBrocq.ChanDoanTaiKham4));
                Command.Parameters.Add(new MDB.MDBParameter("BenhPhu", BenhAnNgoaiTruDuhringBrocq.BenhPhu));
                Command.Parameters.Add(new MDB.MDBParameter("KetQuaDieuTri", BenhAnNgoaiTruDuhringBrocq.KetQuaDieuTri));
                Command.Parameters.Add(new MDB.MDBParameter("BienChung_Text", BenhAnNgoaiTruDuhringBrocq.BienChung_Text));
                Command.Parameters.Add(new MDB.MDBParameter("GDPhongKeHoach", BenhAnNgoaiTruDuhringBrocq.GDPhongKeHoach));
                Command.Parameters.Add(new MDB.MDBParameter("GDPhongKhamBenh", BenhAnNgoaiTruDuhringBrocq.GDPhongKhamBenh));

                // hỏi bệnh, khám bệnh
                Command.Parameters.Add(new MDB.MDBParameter("ThoiGianKhoiPhatBenh", BenhAnNgoaiTruDuhringBrocq.ThoiGianKhoiPhatBenh));
                Command.Parameters.Add(new MDB.MDBParameter("TuoiBatDauDieutri", BenhAnNgoaiTruDuhringBrocq.TuoiBatDauDieutri));
                Command.Parameters.Add(new MDB.MDBParameter("VaoVienLanThuMay", BenhAnNgoaiTruDuhringBrocq.VaoVienLanThuMay));
                Command.Parameters.Add(new MDB.MDBParameter("TrieuChungKhoiPhat", BenhAnNgoaiTruDuhringBrocq.TrieuChungKhoiPhat));
                Command.Parameters.Add(new MDB.MDBParameter("QuaTrinhBenhLy", BenhAnNgoaiTruDuhringBrocq.QuaTrinhBenhLy));
                Command.Parameters.Add(new MDB.MDBParameter("DieuTriTruocDay", BenhAnNgoaiTruDuhringBrocq.DieuTriTruocDay));
                Command.Parameters.Add(new MDB.MDBParameter("TienSuBanThan_DiUngThuoc", BenhAnNgoaiTruDuhringBrocq.TienSuBanThan_DiUngThuoc));
                Command.Parameters.Add(new MDB.MDBParameter("TienSuBanThan_BenhKhac", BenhAnNgoaiTruDuhringBrocq.TienSuBanThan_BenhKhac));
                Command.Parameters.Add(new MDB.MDBParameter("TienSuGiaDinh_Khac", BenhAnNgoaiTruDuhringBrocq.TienSuGiaDinh_Khac));
                Command.Parameters.Add(new MDB.MDBParameter("ToanThan", BenhAnNgoaiTruDuhringBrocq.ToanThan));
                Command.Parameters.Add(new MDB.MDBParameter("CacBoPhan", BenhAnNgoaiTruDuhringBrocq.CacBoPhan));
                Command.Parameters.Add(new MDB.MDBParameter("Ngua", BenhAnNgoaiTruDuhringBrocq.Ngua));
                Command.Parameters.Add(new MDB.MDBParameter("SutCan", BenhAnNgoaiTruDuhringBrocq.SutCan));
                Command.Parameters.Add(new MDB.MDBParameter("KemAn", BenhAnNgoaiTruDuhringBrocq.KemAn));
                Command.Parameters.Add(new MDB.MDBParameter("Met", BenhAnNgoaiTruDuhringBrocq.Met));
                Command.Parameters.Add(new MDB.MDBParameter("DauRat", BenhAnNgoaiTruDuhringBrocq.DauRat));
                Command.Parameters.Add(new MDB.MDBParameter("TrieuChungCoNang_Khac", BenhAnNgoaiTruDuhringBrocq.TrieuChungCoNang_Khac));
                Command.Parameters.Add(new MDB.MDBParameter("NhanNheo", BenhAnNgoaiTruDuhringBrocq.NhanNheo));
                Command.Parameters.Add(new MDB.MDBParameter("Cang", BenhAnNgoaiTruDuhringBrocq.Cang));
                Command.Parameters.Add(new MDB.MDBParameter("DichXuatHuyet", BenhAnNgoaiTruDuhringBrocq.DichXuatHuyet));
                Command.Parameters.Add(new MDB.MDBParameter("DichTrong", BenhAnNgoaiTruDuhringBrocq.DichTrong));
                Command.Parameters.Add(new MDB.MDBParameter("DichMu", BenhAnNgoaiTruDuhringBrocq.DichMu));
                Command.Parameters.Add(new MDB.MDBParameter("TrenNenDaLanh", BenhAnNgoaiTruDuhringBrocq.TrenNenDaLanh));
                Command.Parameters.Add(new MDB.MDBParameter("TrenNenDaDo", BenhAnNgoaiTruDuhringBrocq.TrenNenDaDo));
                Command.Parameters.Add(new MDB.MDBParameter("BongNuoc_KichThuoc", BenhAnNgoaiTruDuhringBrocq.BongNuoc_KichThuoc));
                Command.Parameters.Add(new MDB.MDBParameter("BongNuoc_SoLuong", BenhAnNgoaiTruDuhringBrocq.BongNuoc_SoLuong));
                Command.Parameters.Add(new MDB.MDBParameter("KhoDongVay", BenhAnNgoaiTruDuhringBrocq.KhoDongVay));
                Command.Parameters.Add(new MDB.MDBParameter("Uot", BenhAnNgoaiTruDuhringBrocq.Uot));
                Command.Parameters.Add(new MDB.MDBParameter("VetTrot_SoLuong", BenhAnNgoaiTruDuhringBrocq.VetTrot_SoLuong));
                Command.Parameters.Add(new MDB.MDBParameter("MauVangAm", BenhAnNgoaiTruDuhringBrocq.MauVangAm));
                Command.Parameters.Add(new MDB.MDBParameter("MauNauDen", BenhAnNgoaiTruDuhringBrocq.MauNauDen));
                Command.Parameters.Add(new MDB.MDBParameter("Sui_Co", BenhAnNgoaiTruDuhringBrocq.Sui_Co));
                Command.Parameters.Add(new MDB.MDBParameter("ViTriTonThuong", BenhAnNgoaiTruDuhringBrocq.ViTriTonThuong));
                Command.Parameters.Add(new MDB.MDBParameter("DauHieuNikolsky", BenhAnNgoaiTruDuhringBrocq.DauHieuNikolsky));
                Command.Parameters.Add(new MDB.MDBParameter("GhiChu", BenhAnNgoaiTruDuhringBrocq.GhiChu));
                Command.Parameters.Add(new MDB.MDBParameter("CongThucMau", BenhAnNgoaiTruDuhringBrocq.CongThucMau));
                Command.Parameters.Add(new MDB.MDBParameter("CongThucMau_Text", BenhAnNgoaiTruDuhringBrocq.CongThucMau_Text));
                Command.Parameters.Add(new MDB.MDBParameter("SinhHoaMau", BenhAnNgoaiTruDuhringBrocq.SinhHoaMau));
                Command.Parameters.Add(new MDB.MDBParameter("SinhHoaMau_Text", BenhAnNgoaiTruDuhringBrocq.SinhHoaMau_Text));
                Command.Parameters.Add(new MDB.MDBParameter("TongPhanTichNuocTieu", BenhAnNgoaiTruDuhringBrocq.TongPhanTichNuocTieu));
                Command.Parameters.Add(new MDB.MDBParameter("TongPhanTichNuocTieu_Text", BenhAnNgoaiTruDuhringBrocq.TongPhanTichNuocTieu_Text));
                Command.Parameters.Add(new MDB.MDBParameter("XQuanNguc", BenhAnNgoaiTruDuhringBrocq.XQuanNguc));
                Command.Parameters.Add(new MDB.MDBParameter("XQuanNguc_Text", BenhAnNgoaiTruDuhringBrocq.XQuanNguc_Text));
                Command.Parameters.Add(new MDB.MDBParameter("SieuAmOBung", BenhAnNgoaiTruDuhringBrocq.SieuAmOBung));
                Command.Parameters.Add(new MDB.MDBParameter("SieuAmOBung_Text", BenhAnNgoaiTruDuhringBrocq.SieuAmOBung_Text));
                Command.Parameters.Add(new MDB.MDBParameter("SoiTuoiTimNam", BenhAnNgoaiTruDuhringBrocq.SoiTuoiTimNam));
                Command.Parameters.Add(new MDB.MDBParameter("XetNghiemTeBaoTzanck", BenhAnNgoaiTruDuhringBrocq.XetNghiemTeBaoTzanck));
                Command.Parameters.Add(new MDB.MDBParameter("MDHuynhQuangTrucTiep", BenhAnNgoaiTruDuhringBrocq.MDHuynhQuangTrucTiep));
                Command.Parameters.Add(new MDB.MDBParameter("MDHuynhQuangGianTiep", BenhAnNgoaiTruDuhringBrocq.MDHuynhQuangGianTiep));
                Command.Parameters.Add(new MDB.MDBParameter("SinhThietDa", BenhAnNgoaiTruDuhringBrocq.SinhThietDa));
                Command.Parameters.Add(new MDB.MDBParameter("PCRHerpes", BenhAnNgoaiTruDuhringBrocq.PCRHerpes));
                Command.Parameters.Add(new MDB.MDBParameter("XetNghiemKhac", BenhAnNgoaiTruDuhringBrocq.XetNghiemKhac));
                Command.Parameters.Add(new MDB.MDBParameter("ChanDoan", BenhAnNgoaiTruDuhringBrocq.ChanDoan));
                Command.Parameters.Add(new MDB.MDBParameter("DieuTri", BenhAnNgoaiTruDuhringBrocq.DieuTri));
                Command.Parameters.Add(new MDB.MDBParameter("HenTaiKham", BenhAnNgoaiTruDuhringBrocq.HenTaiKham));
                Command.Parameters.Add(new MDB.MDBParameter("BacSiDieuTri", BenhAnNgoaiTruDuhringBrocq.BacSiDieuTri));
                Command.Parameters.Add(new MDB.MDBParameter("TK_NgayTaiKham", BenhAnNgoaiTruDuhringBrocq.TK_NgayTaiKham));
                Command.Parameters.Add(new MDB.MDBParameter("TK_HoTen", BenhAnNgoaiTruDuhringBrocq.TK_HoTen));
                Command.Parameters.Add(new MDB.MDBParameter("TK_Mach", BenhAnNgoaiTruDuhringBrocq.TK_Mach));
                Command.Parameters.Add(new MDB.MDBParameter("TK_BenhNhanTuDanhGia", BenhAnNgoaiTruDuhringBrocq.TK_BenhNhanTuDanhGia));
                Command.Parameters.Add(new MDB.MDBParameter("TK_LamSangDaNiemMac", BenhAnNgoaiTruDuhringBrocq.TK_LamSangDaNiemMac));
                Command.Parameters.Add(new MDB.MDBParameter("TK_Than", BenhAnNgoaiTruDuhringBrocq.TK_Than));
                Command.Parameters.Add(new MDB.MDBParameter("TK_Phoi", BenhAnNgoaiTruDuhringBrocq.TK_Phoi));
                Command.Parameters.Add(new MDB.MDBParameter("TK_TieuHoa", BenhAnNgoaiTruDuhringBrocq.TK_TieuHoa));
                Command.Parameters.Add(new MDB.MDBParameter("TK_Tim", BenhAnNgoaiTruDuhringBrocq.TK_Tim));
                Command.Parameters.Add(new MDB.MDBParameter("TK_ThanKinh", BenhAnNgoaiTruDuhringBrocq.TK_ThanKinh));
                Command.Parameters.Add(new MDB.MDBParameter("TK_CoXuongKhop", BenhAnNgoaiTruDuhringBrocq.TK_CoXuongKhop));
                Command.Parameters.Add(new MDB.MDBParameter("TK_CacCoQuanKhac", BenhAnNgoaiTruDuhringBrocq.TK_CacCoQuanKhac));
                Command.Parameters.Add(new MDB.MDBParameter("TK_CanLamSang", BenhAnNgoaiTruDuhringBrocq.TK_CanLamSang));
                Command.Parameters.Add(new MDB.MDBParameter("TK_TacDungPhuCuaThuoc", BenhAnNgoaiTruDuhringBrocq.TK_TacDungPhuCuaThuoc));
                Command.Parameters.Add(new MDB.MDBParameter("TK_HuongDieuTriTiepTheo", BenhAnNgoaiTruDuhringBrocq.TK_HuongDieuTriTiepTheo));
                Command.Parameters.Add(new MDB.MDBParameter("TK_HenTaiKham", BenhAnNgoaiTruDuhringBrocq.TK_HenTaiKham));
                Command.Parameters.Add(new MDB.MDBParameter("TK_BacSiDieuTri", BenhAnNgoaiTruDuhringBrocq.TK_BacSiDieuTri));
                Command.Parameters.Add(new MDB.MDBParameter("TongKet_QuaTrinhBenhLy", BenhAnNgoaiTruDuhringBrocq.TongKet_QuaTrinhBenhLy));
                Command.Parameters.Add(new MDB.MDBParameter("TomTatKetQua", BenhAnNgoaiTruDuhringBrocq.TomTatKetQua));
                Command.Parameters.Add(new MDB.MDBParameter("BenhChinh", BenhAnNgoaiTruDuhringBrocq.BenhChinh));
                Command.Parameters.Add(new MDB.MDBParameter("MaBenhChinh", BenhAnNgoaiTruDuhringBrocq.MaBenhChinh));
                Command.Parameters.Add(new MDB.MDBParameter("BenhKemTheo", BenhAnNgoaiTruDuhringBrocq.BenhKemTheo));
                Command.Parameters.Add(new MDB.MDBParameter("MaBenhKemTheo", BenhAnNgoaiTruDuhringBrocq.MaBenhKemTheo));
                Command.Parameters.Add(new MDB.MDBParameter("PhuongPhapDieuTri", BenhAnNgoaiTruDuhringBrocq.PhuongPhapDieuTri));
                Command.Parameters.Add(new MDB.MDBParameter("TinhTrangRaVien", BenhAnNgoaiTruDuhringBrocq.TinhTrangRaVien));
                Command.Parameters.Add(new MDB.MDBParameter("HuongDieuTri", BenhAnNgoaiTruDuhringBrocq.HuongDieuTri));
                Command.Parameters.Add(new MDB.MDBParameter("NguoiNhanHoSo", BenhAnNgoaiTruDuhringBrocq.NguoiNhanHoSo));
                Command.Parameters.Add(new MDB.MDBParameter("NguoiGiaoHoSo", BenhAnNgoaiTruDuhringBrocq.NguoiGiaoHoSo));
                Command.Parameters.Add(new MDB.MDBParameter("NgayTongKet", BenhAnNgoaiTruDuhringBrocq.NgayTongKet));
                Command.Parameters.Add(new MDB.MDBParameter("TongKet_BacSyDieuTri", BenhAnNgoaiTruDuhringBrocq.TongKet_BacSyDieuTri));
                Command.Parameters.Add(new MDB.MDBParameter("TongKet_MaBacSyDieuTri", BenhAnNgoaiTruDuhringBrocq.TongKet_MaBacSyDieuTri));


                Command.BindByName = true;
                int n = Command.ExecuteNonQuery(); // C#
                return n > 0 ? true : false;
            }
            catch (Exception ex)
            {
                XuLyLoi.Handle(ex);
            }
            return false;
        }
        public static bool Update(MDB.MDBConnection MyConnection, BenhAnNgoaiTruDuhringBrocq BenhAnNgoaiTruDuhringBrocq)
        {
            try
            {
                string sql = @"UPDATE BenhAnNgoaiTruDuhringBrocq SET 
                            DieuTriNgoaiTruTu=:DieuTriNgoaiTruTu,
                            DieuTriNgoaiTruDen=:DieuTriNgoaiTruDen,
                            SoCMND=:SoCMND,
                            BaoHiem=:BaoHiem,
                            ChanDoan_TuyenTruoc=:ChanDoan_TuyenTruoc,
                            ChanDoanBanDau=:ChanDoanBanDau,
                            ChanDoanTaiKham1=:ChanDoanTaiKham1,
                            ChanDoanTaiKham2=:ChanDoanTaiKham2,
                            ChanDoanTaiKham3=:ChanDoanTaiKham3,
                            ChanDoanTaiKham4=:ChanDoanTaiKham4,
                            BenhPhu=:BenhPhu,
                            KetQuaDieuTri=:KetQuaDieuTri,
                            BienChung_Text=:BienChung_Text,
                            GDPhongKeHoach=:GDPhongKeHoach,
                            GDPhongKhamBenh=:GDPhongKhamBenh,
                            ThoiGianKhoiPhatBenh=:ThoiGianKhoiPhatBenh,
                            TuoiBatDauDieutri=:TuoiBatDauDieutri,
                            VaoVienLanThuMay=:VaoVienLanThuMay,
                            TrieuChungKhoiPhat=:TrieuChungKhoiPhat,
                            QuaTrinhBenhLy=:QuaTrinhBenhLy,
                            DieuTriTruocDay=:DieuTriTruocDay,
                            TienSuBanThan_DiUngThuoc=:TienSuBanThan_DiUngThuoc,
                            TienSuBanThan_BenhKhac=:TienSuBanThan_BenhKhac,
                            TienSuGiaDinh_Khac=:TienSuGiaDinh_Khac,
                            ToanThan=:ToanThan,
                            CacBoPhan=:CacBoPhan,
                            Ngua=:Ngua,
                            SutCan=:SutCan,
                            KemAn=:KemAn,
                            Met=:Met,
                            DauRat=:DauRat,
                            TrieuChungCoNang_Khac=:TrieuChungCoNang_Khac,
                            NhanNheo=:NhanNheo,
                            Cang=:Cang,
                            DichXuatHuyet=:DichXuatHuyet,
                            DichTrong=:DichTrong,
                            DichMu=:DichMu,
                            TrenNenDaLanh=:TrenNenDaLanh,
                            TrenNenDaDo=:TrenNenDaDo,
                            BongNuoc_KichThuoc=:BongNuoc_KichThuoc,
                            BongNuoc_SoLuong=:BongNuoc_SoLuong,
                            KhoDongVay=:KhoDongVay,
                            Uot=:Uot,
                            VetTrot_SoLuong=:VetTrot_SoLuong,
                            MauVangAm=:MauVangAm,
                            MauNauDen=:MauNauDen,
                            Sui_Co=:Sui_Co,
                            ViTriTonThuong=:ViTriTonThuong,
                            DauHieuNikolsky=:DauHieuNikolsky,
                            GhiChu=:GhiChu,
                            CongThucMau=:CongThucMau,
                            CongThucMau_Text=:CongThucMau_Text,
                            SinhHoaMau=:SinhHoaMau,
                            SinhHoaMau_Text=:SinhHoaMau_Text,
                            TongPhanTichNuocTieu=:TongPhanTichNuocTieu,
                            TongPhanTichNuocTieu_Text=:TongPhanTichNuocTieu_Text,
                            XQuanNguc=:XQuanNguc,
                            XQuanNguc_Text=:XQuanNguc_Text,
                            SieuAmOBung=:SieuAmOBung,
                            SieuAmOBung_Text=:SieuAmOBung_Text,
                            SoiTuoiTimNam=:SoiTuoiTimNam,
                            XetNghiemTeBaoTzanck=:XetNghiemTeBaoTzanck,
                            MDHuynhQuangTrucTiep=:MDHuynhQuangTrucTiep,
                            MDHuynhQuangGianTiep=:MDHuynhQuangGianTiep,
                            SinhThietDa=:SinhThietDa,
                            PCRHerpes=:PCRHerpes,
                            XetNghiemKhac=:XetNghiemKhac,
                            ChanDoan=:ChanDoan,
                            DieuTri=:DieuTri,
                            HenTaiKham=:HenTaiKham,
                            BacSiDieuTri=:BacSiDieuTri,
                            TK_NgayTaiKham=:TK_NgayTaiKham,
                            TK_HoTen=:TK_HoTen,
                            TK_Mach=:TK_Mach,
                            TK_BenhNhanTuDanhGia = :TK_BenhNhanTuDanhGia,
                            TK_LamSangDaNiemMac=:TK_LamSangDaNiemMac,
                            TK_Than=:TK_Than,
                            TK_Phoi=:TK_Phoi,
                            TK_TieuHoa=:TK_TieuHoa,
                            TK_Tim=:TK_Tim,
                            TK_ThanKinh=:TK_ThanKinh,
                            TK_CoXuongKhop=:TK_CoXuongKhop,
                            TK_CacCoQuanKhac=:TK_CacCoQuanKhac,
                            TK_CanLamSang=:TK_CanLamSang,
                            TK_TacDungPhuCuaThuoc=:TK_TacDungPhuCuaThuoc,
                            TK_HuongDieuTriTiepTheo=:TK_HuongDieuTriTiepTheo,
                            TK_HenTaiKham=:TK_HenTaiKham,
                            TK_BacSiDieuTri=:TK_BacSiDieuTri,
                            TongKet_QuaTrinhBenhLy=:TongKet_QuaTrinhBenhLy,
                            TomTatKetQua=:TomTatKetQua,
                            BenhChinh=:BenhChinh,
                            MaBenhChinh=:MaBenhChinh,
                            BenhKemTheo=:BenhKemTheo,
                            MaBenhKemTheo=:MaBenhKemTheo,
                            PhuongPhapDieuTri=:PhuongPhapDieuTri,
                            TinhTrangRaVien=:TinhTrangRaVien,
                            HuongDieuTri=:HuongDieuTri,
                            NguoiNhanHoSo=:NguoiNhanHoSo,
                            NguoiGiaoHoSo=:NguoiGiaoHoSo,
                            NgayTongKet=:NgayTongKet,
                            TongKet_BacSyDieuTri=:TongKet_BacSyDieuTri,
                            TongKet_MaBacSyDieuTri=:TongKet_MaBacSyDieuTri 
                            WHERE MaQuanLy = :MaQuanLy";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
                Command.Parameters.Add(new MDB.MDBParameter("DieuTriNgoaiTruTu", BenhAnNgoaiTruDuhringBrocq.DieuTriNgoaiTruTu));
                Command.Parameters.Add(new MDB.MDBParameter("DieuTriNgoaiTruDen", BenhAnNgoaiTruDuhringBrocq.DieuTriNgoaiTruDen));
                Command.Parameters.Add(new MDB.MDBParameter("SoCMND", BenhAnNgoaiTruDuhringBrocq.SoCMND));
                Command.Parameters.Add(new MDB.MDBParameter("BaoHiem", BenhAnNgoaiTruDuhringBrocq.BaoHiem));
                Command.Parameters.Add(new MDB.MDBParameter("ChanDoan_TuyenTruoc", BenhAnNgoaiTruDuhringBrocq.ChanDoan_TuyenTruoc));
                Command.Parameters.Add(new MDB.MDBParameter("ChanDoanBanDau", BenhAnNgoaiTruDuhringBrocq.ChanDoanBanDau));
                Command.Parameters.Add(new MDB.MDBParameter("ChanDoanTaiKham1", BenhAnNgoaiTruDuhringBrocq.ChanDoanTaiKham1));
                Command.Parameters.Add(new MDB.MDBParameter("ChanDoanTaiKham2", BenhAnNgoaiTruDuhringBrocq.ChanDoanTaiKham2));
                Command.Parameters.Add(new MDB.MDBParameter("ChanDoanTaiKham3", BenhAnNgoaiTruDuhringBrocq.ChanDoanTaiKham3));
                Command.Parameters.Add(new MDB.MDBParameter("ChanDoanTaiKham4", BenhAnNgoaiTruDuhringBrocq.ChanDoanTaiKham4));
                Command.Parameters.Add(new MDB.MDBParameter("BenhPhu", BenhAnNgoaiTruDuhringBrocq.BenhPhu));
                Command.Parameters.Add(new MDB.MDBParameter("KetQuaDieuTri", BenhAnNgoaiTruDuhringBrocq.KetQuaDieuTri));
                Command.Parameters.Add(new MDB.MDBParameter("BienChung_Text", BenhAnNgoaiTruDuhringBrocq.BienChung_Text));
                Command.Parameters.Add(new MDB.MDBParameter("GDPhongKeHoach", BenhAnNgoaiTruDuhringBrocq.GDPhongKeHoach));
                Command.Parameters.Add(new MDB.MDBParameter("GDPhongKhamBenh", BenhAnNgoaiTruDuhringBrocq.GDPhongKhamBenh));
                // hỏi bệnh, khám bệnh
                Command.Parameters.Add(new MDB.MDBParameter("ThoiGianKhoiPhatBenh", BenhAnNgoaiTruDuhringBrocq.ThoiGianKhoiPhatBenh));
                Command.Parameters.Add(new MDB.MDBParameter("TuoiBatDauDieutri", BenhAnNgoaiTruDuhringBrocq.TuoiBatDauDieutri));
                Command.Parameters.Add(new MDB.MDBParameter("VaoVienLanThuMay", BenhAnNgoaiTruDuhringBrocq.VaoVienLanThuMay));
                Command.Parameters.Add(new MDB.MDBParameter("TrieuChungKhoiPhat", BenhAnNgoaiTruDuhringBrocq.TrieuChungKhoiPhat));
                Command.Parameters.Add(new MDB.MDBParameter("QuaTrinhBenhLy", BenhAnNgoaiTruDuhringBrocq.QuaTrinhBenhLy));
                Command.Parameters.Add(new MDB.MDBParameter("DieuTriTruocDay", BenhAnNgoaiTruDuhringBrocq.DieuTriTruocDay));
                Command.Parameters.Add(new MDB.MDBParameter("TienSuBanThan_DiUngThuoc", BenhAnNgoaiTruDuhringBrocq.TienSuBanThan_DiUngThuoc));
                Command.Parameters.Add(new MDB.MDBParameter("TienSuBanThan_BenhKhac", BenhAnNgoaiTruDuhringBrocq.TienSuBanThan_BenhKhac));
                Command.Parameters.Add(new MDB.MDBParameter("TienSuGiaDinh_Khac", BenhAnNgoaiTruDuhringBrocq.TienSuGiaDinh_Khac));
                Command.Parameters.Add(new MDB.MDBParameter("ToanThan", BenhAnNgoaiTruDuhringBrocq.ToanThan));
                Command.Parameters.Add(new MDB.MDBParameter("CacBoPhan", BenhAnNgoaiTruDuhringBrocq.CacBoPhan));
                Command.Parameters.Add(new MDB.MDBParameter("Ngua", BenhAnNgoaiTruDuhringBrocq.Ngua));
                Command.Parameters.Add(new MDB.MDBParameter("SutCan", BenhAnNgoaiTruDuhringBrocq.SutCan));
                Command.Parameters.Add(new MDB.MDBParameter("KemAn", BenhAnNgoaiTruDuhringBrocq.KemAn));
                Command.Parameters.Add(new MDB.MDBParameter("Met", BenhAnNgoaiTruDuhringBrocq.Met));
                Command.Parameters.Add(new MDB.MDBParameter("DauRat", BenhAnNgoaiTruDuhringBrocq.DauRat));
                Command.Parameters.Add(new MDB.MDBParameter("TrieuChungCoNang_Khac", BenhAnNgoaiTruDuhringBrocq.TrieuChungCoNang_Khac));
                Command.Parameters.Add(new MDB.MDBParameter("NhanNheo", BenhAnNgoaiTruDuhringBrocq.NhanNheo));
                Command.Parameters.Add(new MDB.MDBParameter("Cang", BenhAnNgoaiTruDuhringBrocq.Cang));
                Command.Parameters.Add(new MDB.MDBParameter("DichXuatHuyet", BenhAnNgoaiTruDuhringBrocq.DichXuatHuyet));
                Command.Parameters.Add(new MDB.MDBParameter("DichTrong", BenhAnNgoaiTruDuhringBrocq.DichTrong));
                Command.Parameters.Add(new MDB.MDBParameter("DichMu", BenhAnNgoaiTruDuhringBrocq.DichMu));
                Command.Parameters.Add(new MDB.MDBParameter("TrenNenDaLanh", BenhAnNgoaiTruDuhringBrocq.TrenNenDaLanh));
                Command.Parameters.Add(new MDB.MDBParameter("TrenNenDaDo", BenhAnNgoaiTruDuhringBrocq.TrenNenDaDo));
                Command.Parameters.Add(new MDB.MDBParameter("BongNuoc_KichThuoc", BenhAnNgoaiTruDuhringBrocq.BongNuoc_KichThuoc));
                Command.Parameters.Add(new MDB.MDBParameter("BongNuoc_SoLuong", BenhAnNgoaiTruDuhringBrocq.BongNuoc_SoLuong));
                Command.Parameters.Add(new MDB.MDBParameter("KhoDongVay", BenhAnNgoaiTruDuhringBrocq.KhoDongVay));
                Command.Parameters.Add(new MDB.MDBParameter("Uot", BenhAnNgoaiTruDuhringBrocq.Uot));
                Command.Parameters.Add(new MDB.MDBParameter("VetTrot_SoLuong", BenhAnNgoaiTruDuhringBrocq.VetTrot_SoLuong));
                Command.Parameters.Add(new MDB.MDBParameter("MauVangAm", BenhAnNgoaiTruDuhringBrocq.MauVangAm));
                Command.Parameters.Add(new MDB.MDBParameter("MauNauDen", BenhAnNgoaiTruDuhringBrocq.MauNauDen));
                Command.Parameters.Add(new MDB.MDBParameter("Sui_Co", BenhAnNgoaiTruDuhringBrocq.Sui_Co));
                Command.Parameters.Add(new MDB.MDBParameter("ViTriTonThuong", BenhAnNgoaiTruDuhringBrocq.ViTriTonThuong));
                Command.Parameters.Add(new MDB.MDBParameter("DauHieuNikolsky", BenhAnNgoaiTruDuhringBrocq.DauHieuNikolsky));
                Command.Parameters.Add(new MDB.MDBParameter("GhiChu", BenhAnNgoaiTruDuhringBrocq.GhiChu));
                Command.Parameters.Add(new MDB.MDBParameter("CongThucMau", BenhAnNgoaiTruDuhringBrocq.CongThucMau));
                Command.Parameters.Add(new MDB.MDBParameter("CongThucMau_Text", BenhAnNgoaiTruDuhringBrocq.CongThucMau_Text));
                Command.Parameters.Add(new MDB.MDBParameter("SinhHoaMau", BenhAnNgoaiTruDuhringBrocq.SinhHoaMau));
                Command.Parameters.Add(new MDB.MDBParameter("SinhHoaMau_Text", BenhAnNgoaiTruDuhringBrocq.SinhHoaMau_Text));
                Command.Parameters.Add(new MDB.MDBParameter("TongPhanTichNuocTieu", BenhAnNgoaiTruDuhringBrocq.TongPhanTichNuocTieu));
                Command.Parameters.Add(new MDB.MDBParameter("TongPhanTichNuocTieu_Text", BenhAnNgoaiTruDuhringBrocq.TongPhanTichNuocTieu_Text));
                Command.Parameters.Add(new MDB.MDBParameter("XQuanNguc", BenhAnNgoaiTruDuhringBrocq.XQuanNguc));
                Command.Parameters.Add(new MDB.MDBParameter("XQuanNguc_Text", BenhAnNgoaiTruDuhringBrocq.XQuanNguc_Text));
                Command.Parameters.Add(new MDB.MDBParameter("SieuAmOBung", BenhAnNgoaiTruDuhringBrocq.SieuAmOBung));
                Command.Parameters.Add(new MDB.MDBParameter("SieuAmOBung_Text", BenhAnNgoaiTruDuhringBrocq.SieuAmOBung_Text));
                Command.Parameters.Add(new MDB.MDBParameter("SoiTuoiTimNam", BenhAnNgoaiTruDuhringBrocq.SoiTuoiTimNam));
                Command.Parameters.Add(new MDB.MDBParameter("XetNghiemTeBaoTzanck", BenhAnNgoaiTruDuhringBrocq.XetNghiemTeBaoTzanck));
                Command.Parameters.Add(new MDB.MDBParameter("MDHuynhQuangTrucTiep", BenhAnNgoaiTruDuhringBrocq.MDHuynhQuangTrucTiep));
                Command.Parameters.Add(new MDB.MDBParameter("MDHuynhQuangGianTiep", BenhAnNgoaiTruDuhringBrocq.MDHuynhQuangGianTiep));
                Command.Parameters.Add(new MDB.MDBParameter("SinhThietDa", BenhAnNgoaiTruDuhringBrocq.SinhThietDa));
                Command.Parameters.Add(new MDB.MDBParameter("PCRHerpes", BenhAnNgoaiTruDuhringBrocq.PCRHerpes));
                Command.Parameters.Add(new MDB.MDBParameter("XetNghiemKhac", BenhAnNgoaiTruDuhringBrocq.XetNghiemKhac));
                Command.Parameters.Add(new MDB.MDBParameter("ChanDoan", BenhAnNgoaiTruDuhringBrocq.ChanDoan));
                Command.Parameters.Add(new MDB.MDBParameter("DieuTri", BenhAnNgoaiTruDuhringBrocq.DieuTri));
                Command.Parameters.Add(new MDB.MDBParameter("HenTaiKham", BenhAnNgoaiTruDuhringBrocq.HenTaiKham));
                Command.Parameters.Add(new MDB.MDBParameter("BacSiDieuTri", BenhAnNgoaiTruDuhringBrocq.BacSiDieuTri));
                Command.Parameters.Add(new MDB.MDBParameter("TK_NgayTaiKham", BenhAnNgoaiTruDuhringBrocq.TK_NgayTaiKham));
                Command.Parameters.Add(new MDB.MDBParameter("TK_HoTen", BenhAnNgoaiTruDuhringBrocq.TK_HoTen));
                Command.Parameters.Add(new MDB.MDBParameter("TK_Mach", BenhAnNgoaiTruDuhringBrocq.TK_Mach));
                Command.Parameters.Add(new MDB.MDBParameter("TK_BenhNhanTuDanhGia", BenhAnNgoaiTruDuhringBrocq.TK_BenhNhanTuDanhGia));
                Command.Parameters.Add(new MDB.MDBParameter("TK_LamSangDaNiemMac", BenhAnNgoaiTruDuhringBrocq.TK_LamSangDaNiemMac));
                Command.Parameters.Add(new MDB.MDBParameter("TK_Than", BenhAnNgoaiTruDuhringBrocq.TK_Than));
                Command.Parameters.Add(new MDB.MDBParameter("TK_Phoi", BenhAnNgoaiTruDuhringBrocq.TK_Phoi));
                Command.Parameters.Add(new MDB.MDBParameter("TK_TieuHoa", BenhAnNgoaiTruDuhringBrocq.TK_TieuHoa));
                Command.Parameters.Add(new MDB.MDBParameter("TK_Tim", BenhAnNgoaiTruDuhringBrocq.TK_Tim));
                Command.Parameters.Add(new MDB.MDBParameter("TK_ThanKinh", BenhAnNgoaiTruDuhringBrocq.TK_ThanKinh));
                Command.Parameters.Add(new MDB.MDBParameter("TK_CoXuongKhop", BenhAnNgoaiTruDuhringBrocq.TK_CoXuongKhop));
                Command.Parameters.Add(new MDB.MDBParameter("TK_CacCoQuanKhac", BenhAnNgoaiTruDuhringBrocq.TK_CacCoQuanKhac));
                Command.Parameters.Add(new MDB.MDBParameter("TK_CanLamSang", BenhAnNgoaiTruDuhringBrocq.TK_CanLamSang));
                Command.Parameters.Add(new MDB.MDBParameter("TK_TacDungPhuCuaThuoc", BenhAnNgoaiTruDuhringBrocq.TK_TacDungPhuCuaThuoc));
                Command.Parameters.Add(new MDB.MDBParameter("TK_HuongDieuTriTiepTheo", BenhAnNgoaiTruDuhringBrocq.TK_HuongDieuTriTiepTheo));
                Command.Parameters.Add(new MDB.MDBParameter("TK_HenTaiKham", BenhAnNgoaiTruDuhringBrocq.TK_HenTaiKham));
                Command.Parameters.Add(new MDB.MDBParameter("TK_BacSiDieuTri", BenhAnNgoaiTruDuhringBrocq.TK_BacSiDieuTri));
                Command.Parameters.Add(new MDB.MDBParameter("TongKet_QuaTrinhBenhLy", BenhAnNgoaiTruDuhringBrocq.TongKet_QuaTrinhBenhLy));
                Command.Parameters.Add(new MDB.MDBParameter("TomTatKetQua", BenhAnNgoaiTruDuhringBrocq.TomTatKetQua));
                Command.Parameters.Add(new MDB.MDBParameter("BenhChinh", BenhAnNgoaiTruDuhringBrocq.BenhChinh));
                Command.Parameters.Add(new MDB.MDBParameter("MaBenhChinh", BenhAnNgoaiTruDuhringBrocq.MaBenhChinh));
                Command.Parameters.Add(new MDB.MDBParameter("BenhKemTheo", BenhAnNgoaiTruDuhringBrocq.BenhKemTheo));
                Command.Parameters.Add(new MDB.MDBParameter("MaBenhKemTheo", BenhAnNgoaiTruDuhringBrocq.MaBenhKemTheo));
                Command.Parameters.Add(new MDB.MDBParameter("PhuongPhapDieuTri", BenhAnNgoaiTruDuhringBrocq.PhuongPhapDieuTri));
                Command.Parameters.Add(new MDB.MDBParameter("TinhTrangRaVien", BenhAnNgoaiTruDuhringBrocq.TinhTrangRaVien));
                Command.Parameters.Add(new MDB.MDBParameter("HuongDieuTri", BenhAnNgoaiTruDuhringBrocq.HuongDieuTri));
                Command.Parameters.Add(new MDB.MDBParameter("NguoiNhanHoSo", BenhAnNgoaiTruDuhringBrocq.NguoiNhanHoSo));
                Command.Parameters.Add(new MDB.MDBParameter("NguoiGiaoHoSo", BenhAnNgoaiTruDuhringBrocq.NguoiGiaoHoSo));
                Command.Parameters.Add(new MDB.MDBParameter("NgayTongKet", BenhAnNgoaiTruDuhringBrocq.NgayTongKet));
                Command.Parameters.Add(new MDB.MDBParameter("TongKet_BacSyDieuTri", BenhAnNgoaiTruDuhringBrocq.TongKet_BacSyDieuTri));
                Command.Parameters.Add(new MDB.MDBParameter("TongKet_MaBacSyDieuTri", BenhAnNgoaiTruDuhringBrocq.TongKet_MaBacSyDieuTri));

                Command.BindByName = true;

                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", BenhAnNgoaiTruDuhringBrocq.MaQuanLy));
                Command.BindByName = true;
                int n = Command.ExecuteNonQuery(); // C#
                return n > 0 ? true : false;
            }
            catch (Exception ex)
            {
                XuLyLoi.Handle(ex);
            }
            return false;
        }
    }
}
