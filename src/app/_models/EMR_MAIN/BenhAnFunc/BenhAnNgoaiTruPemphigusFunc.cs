using EMR_MAIN.DATABASE.BenhAn;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;

namespace EMR_MAIN.DATABASE.BenhAnFunc
{
    public class BenhAnNgoaiTruPemphigusFunc
    {
        public static void WriteXml(MDB.MDBConnection MyConnection)
        {
            string sql =
                   @"
                  select  a.*,  CTScanner HoSo_CTScanner, SieuAm HoSo_SieuAm, XetNghiem HoSo_XetNghiem,  Khac HoSo_Khac,  Khac_Text HoSo_Khac_Text,  ToanBoHoSo HoSo_ToanBoHoSo, Mach DauSinhTon_Mach,  NhietDo DauSinhTon_NhietDo,  HuyetAp DauSinhTon_HuyetAp,  NhipTho DauSinhTon_NhipTho,  CanNang DauSinhTon_CanNang  
                  from BenhAnNgoaiTruPemphigus a inner join thongtindieutri b on a.maquanly = b.maquanly
                  where rownum = 1
                    ";
            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
            MDB.MDBDataReader DataReader = Command.ExecuteReader();

            var DataTable = new DataTable { TableName = "BenhAnNgoaiTruPemphigus" };
            DataTable.Load(DataReader as IDataReader);
            DataTable.WriteXml("rptBenhAnNgoaiTruPemphigus.xml");
        }
        public static DataSet SelectDataSet(MDB.MDBConnection MyConnection, decimal MaQuanLy)
        {
            string sql =
                   @"
                  select  a.*, f.hovaten BacSyDieuTriHoVaTen, g.hovaten TK_BacSyDieuTriHoVaTen, h.hovaten TongKet_BacSyDieuTriHoVaTen,  d.hovaten NguoiGiaoHoSoHoVaTen,e.hovaten NguoiNhanHoSoHoVaTen, b.XQuang HoSo_XQuang, b.CTScanner HoSo_CTScanner, b.SieuAm HoSo_SieuAm, b.XetNghiem HoSo_XetNghiem,  b.Khac HoSo_Khac,  b.Khac_Text HoSo_Khac_Text,  b.ToanBoHoSo HoSo_ToanBoHoSo, b.Mach DauSinhTon_Mach, b.NhietDo DauSinhTon_NhietDo,  b.HuyetAp DauSinhTon_HuyetAp,  b.NhipTho DauSinhTon_NhipTho,  b.CanNang DauSinhTon_CanNang  , b.ChieuCao DauSinhTon_ChieuCao, b.BMI DauSinhTon_BMI, b.NgayRaVien 
                        from BenhAnNgoaiTruPemphigus a  
                  left join thongtindieutri b on a.maquanly = b.maquanly 
                  left join nhanvien f on a.BacSyDieuTri = f.manhanvien
                  left join nhanvien g on a.TK_BacSyDieuTri = g.manhanvien
                  left join nhanvien h on a.TongKet_BacSyDieuTri = h.manhanvien
                  left join nhanvien d on a.NguoiGiaoHoSo = d.manhanvien
                  left join nhanvien e on a.NguoiNhanHoSo = e.manhanvien where a.maquanly = " + MaQuanLy.ToString(System.Globalization.CultureInfo.InvariantCulture);
            MDB.MDBDataAdapter adt = new MDB.MDBDataAdapter(sql, MyConnection);
            var ds = new DataSet();
            adt.Fill(ds, "Table");
            
            return ds;

        }
        public static BenhAnNgoaiTruPemphigus Select(MDB.MDBConnection MyConnection, decimal MaQuanLy)
        {
            var obj = new BenhAnNgoaiTruPemphigus();
            try
            {
                #region
                string sql =
                          @"select * 
                        from BenhAnNgoaiTruPemphigus 
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
                    obj.KhoiPhatBenh = DataReader["KhoiPhatBenh"].ToString();
                    obj.TuoiBatDauBiBenh = DataReader["TuoiBatDauBiBenh"].ToString();
                    obj.VaoVienLanThu = DataReader["VaoVienLanThu"].ToString();
                    obj.TrieuChungKhoiPhatDauTien = DataReader["TrieuChungKhoiPhatDauTien"].ToString();
                    obj.QuaTrinhBenhLy = DataReader["QuaTrinhBenhLy"].ToString();
                    obj.DieuTriTruocDay = DataReader["DieuTriTruocDay"].ToString();
                    obj.DiUngThuoc = DataReader["DiUngThuoc"].ToString();
                    obj.TSBT_BenhKhac = DataReader["TSBT_BenhKhac"].ToString();
                    obj.TSGD_BenhKhac = DataReader["TSGD_BenhKhac"].ToString();
                    obj.KhamBenh_ToanThan = DataReader["KhamBenh_ToanThan"].ToString();
                    obj.KhamBenh_CacBoPhan = DataReader["KhamBenh_CacBoPhan"].ToString();
                    obj.Ngua = DataReader.GetInt("Ngua");
                    obj.SutCan = DataReader.GetInt("SutCan");
                    obj.KemAn = DataReader.GetInt("KemAn");
                    obj.Met = DataReader.GetInt("Met");
                    obj.DauRat = DataReader.GetInt("DauRat");
                    obj.TrieuChungCoNang_Khac = DataReader["TrieuChungCoNang_Khac"].ToString();
                    obj.BongNuoc_NhanNheo = DataReader.GetInt("BongNuoc_NhanNheo");
                    obj.BongNuoc_Cang = DataReader.GetInt("BongNuoc_Cang");
                    obj.BongNuoc_DichBongNuoc = DataReader.GetInt("BongNuoc_DichBongNuoc");
                    obj.BongNuoc_DichXuatHuyet = DataReader.GetInt("BongNuoc_DichXuatHuyet");
                    obj.BongNuoc_DichTrong = DataReader.GetInt("BongNuoc_DichTrong");
                    obj.BongNuoc_DichMu = DataReader.GetInt("BongNuoc_DichMu");
                    obj.BongNuoc_NenDaBongNuoc = DataReader.GetInt("BongNuoc_NenDaBongNuoc");
                    obj.BongNuoc_TrenNenDaLanh = DataReader.GetInt("BongNuoc_TrenNenDaLanh");
                    obj.BongNuoc_TrenNenDaDo = DataReader.GetInt("BongNuoc_TrenNenDaDo");
                    obj.BongNuoc_KichThuoc = DataReader["BongNuoc_KichThuoc"].ToString();
                    obj.BongNuoc_SoLuong = DataReader["BongNuoc_SoLuong"].ToString();
                    obj.VetTrot = DataReader.GetInt("VetTrot");
                    obj.VetTrot_SoLuong = DataReader["VetTrot_SoLuong"].ToString();
                    obj.VayTiet = DataReader.GetInt("VayTiet");
                    obj.Sui = DataReader.GetInt("Sui");
                    obj.ViTriTonThuong = DataReader["ViTriTonThuong"].ToString();
                    obj.DauHieuNikolsky = DataReader["DauHieuNikolsky"].ToString();
                    obj.TongDiemAbsis = DataReader["TongDiemAbsis"].ToString();
                    obj.TongDiemPVAS = DataReader["TongDiemPVAS"].ToString();
                    obj.DiemDanhGiaChatLuongCuocSong = DataReader["DiemDanhGiaChatLuongCuocSong"].ToString();
                    obj.GhiChu = DataReader["GhiChu"].ToString();
                    obj.CongThucMau = DataReader.GetInt("CongThucMau");
                    obj.CongThucMau_Text = DataReader["CongThucMau_Text"].ToString();
                    obj.SinhHoaMau = DataReader.GetInt("SinhHoaMau");
                    obj.SinhHoaMau_Text = DataReader["SinhHoaMau_Text"].ToString();
                    obj.TongPhanTichNuocTieu = DataReader.GetInt("TongPhanTichNuocTieu");
                    obj.TongPhanTichNuocTieu_Text = DataReader["TongPhanTichNuocTieu_Text"].ToString();
                    obj.XquangNguc = DataReader.GetInt("XquangNguc");
                    obj.XquangNguc_Text = DataReader["XquangNguc_Text"].ToString();
                    obj.SieuAmOBung = DataReader.GetInt("SieuAmOBung");
                    obj.SieuAmOBung_Text = DataReader["SieuAmOBung_Text"].ToString();
                    obj.SoiTuoiTimNam = DataReader.GetInt("SoiTuoiTimNam");
                    obj.XetNghiemTeBaoTzanck = DataReader["XetNghiemTeBaoTzanck"].ToString();
                    obj.MienDichHuynhQuangTrucTiep = DataReader["MienDichHuynhQuangTrucTiep"].ToString();
                    obj.MienDichHuynhQuangGianTiep = DataReader["MienDichHuynhQuangGianTiep"].ToString();
                    obj.SinhThietDa = DataReader["SinhThietDa"].ToString();
                    obj.XetNghiemKhac = DataReader["XetNghiemKhac"].ToString();
                    obj.PemphigusThongThuong = DataReader.GetInt("PemphigusThongThuong");
                    obj.PemphigusSui = DataReader.GetInt("PemphigusSui");
                    obj.PemphigusVayLa = DataReader.GetInt("PemphigusVayLa");
                    obj.PemphigusDaMo = DataReader.GetInt("PemphigusDaMo");
                    obj.PemphigusGiaDinh = DataReader.GetInt("PemphigusGiaDinh");
                    obj.PemphigusAU = DataReader.GetInt("PemphigusAU");
                    obj.PemphigusDoThuoc = DataReader.GetInt("PemphigusDoThuoc");
                    obj.DieuTri = DataReader["DieuTri"].ToString();
                    obj.HenKhamLai = DataReader["HenKhamLai"] != DBNull.Value ? (DateTime?)Convert.ToDateTime(DataReader["HenKhamLai"]) : null;
                    obj.BacSyDieuTri = DataReader["BacSyDieuTri"].ToString();
                    obj.TK_HoTen = DataReader["TK_HoTen"].ToString();
                    obj.TK_Ngay = DataReader["TK_Ngay"] != DBNull.Value ? (DateTime?)Convert.ToDateTime(DataReader["TK_Ngay"]) : null;
                    obj.Mach = DataReader["Mach"].ToString();
                    obj.BenhNhanTuDanhGia = DataReader["BenhNhanTuDanhGia"].ToString();
                    obj.LamSangDaNiemMac = DataReader.GetInt("LamSangDaNiemMac");
                    obj.ToanThan_Than = DataReader["ToanThan_Than"].ToString();
                    obj.ToanThan_Phoi = DataReader["ToanThan_Phoi"].ToString();
                    obj.ToanThan_TieuHoa = DataReader["ToanThan_TieuHoa"].ToString();
                    obj.ToanThan_Tim = DataReader["ToanThan_Tim"].ToString();
                    obj.ToanThan_ThanKinh = DataReader["ToanThan_ThanKinh"].ToString();
                    obj.ToanThan_CoXuongKhop = DataReader["ToanThan_CoXuongKhop"].ToString();
                    obj.ToanThan_CoQuanKhac = DataReader["ToanThan_CoQuanKhac"].ToString();
                    obj.CanLamSang = DataReader["CanLamSang"].ToString();
                    obj.TacDungPhuCuaThuoc = DataReader["TacDungPhuCuaThuoc"].ToString();
                    obj.HuongDieuTriTiepTheo = DataReader["HuongDieuTriTiepTheo"].ToString();
                    obj.TK_HenKhamLai = DataReader["TK_HenKhamLai"] != DBNull.Value ? (DateTime?) Convert.ToDateTime(DataReader["TK_HenKhamLai"]) : null;
                    obj.TK_BacSyDieuTri = DataReader["TK_BacSyDieuTri"].ToString();


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
        public static bool InsertOrUpdate(MDB.MDBConnection MyConnection, BenhAnNgoaiTruPemphigus BenhAnNgoaiTruPemphigus)
        {
            try
            {
                string sql =
                          @"select MaQuanLy 
                            from BenhAnNgoaiTruPemphigus
                            where MaQuanLy = :MaQuanLy";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", BenhAnNgoaiTruPemphigus.MaQuanLy));
                MDB.MDBDataReader DataReader = Command.ExecuteReader();
                int rowCount = 0;
                while (DataReader.Read()) rowCount++;
                if (rowCount == 1) return Update(MyConnection, BenhAnNgoaiTruPemphigus);
                sql = @"
                       INSERT INTO BenhAnNgoaiTruPemphigus 
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
                            KhoiPhatBenh,
                            TuoiBatDauBiBenh,
                            VaoVienLanThu,
                            TrieuChungKhoiPhatDauTien,
                            QuaTrinhBenhLy,
                            DieuTriTruocDay,
                            DiUngThuoc,
                            TSBT_BenhKhac,
                            TSGD_BenhKhac,
                            KhamBenh_ToanThan,
                            KhamBenh_CacBoPhan,
                            Ngua,
                            SutCan,
                            KemAn,
                            Met,
                            DauRat,
                            TrieuChungCoNang_Khac,
                            BongNuoc_NhanNheo,
                            BongNuoc_Cang,
                            BongNuoc_DichBongNuoc,
                            BongNuoc_DichXuatHuyet,
                            BongNuoc_DichTrong,
                            BongNuoc_DichMu,
                            BongNuoc_NenDaBongNuoc,
                            BongNuoc_TrenNenDaLanh,
                            BongNuoc_TrenNenDaDo,
                            BongNuoc_KichThuoc,
                            BongNuoc_SoLuong,
                            VetTrot,
                            VetTrot_SoLuong,
                            VayTiet,
                            Sui,
                            ViTriTonThuong,
                            DauHieuNikolsky,
                            TongDiemAbsis,
                            TongDiemPVAS,
                            DiemDanhGiaChatLuongCuocSong,
                            GhiChu,
                            CongThucMau,
                            CongThucMau_Text,
                            SinhHoaMau,
                            SinhHoaMau_Text,
                            TongPhanTichNuocTieu,
                            TongPhanTichNuocTieu_Text,
                            XquangNguc,
                            XquangNguc_Text,
                            SieuAmOBung,
                            SieuAmOBung_Text,
                            SoiTuoiTimNam,
                            XetNghiemTeBaoTzanck,
                            MienDichHuynhQuangTrucTiep,
                            MienDichHuynhQuangGianTiep,
                            SinhThietDa,
                            XetNghiemKhac,
                            PemphigusThongThuong,
                            PemphigusSui,
                            PemphigusVayLa,
                            PemphigusDaMo,
                            PemphigusGiaDinh,
                            PemphigusAU,
                            PemphigusDoThuoc,
                            DieuTri,
                            HenKhamLai,
                            BacSyDieuTri,
                            TK_HoTen,
                            TK_Ngay,
                            Mach,
                            BenhNhanTuDanhGia,
                            LamSangDaNiemMac,
                            ToanThan_Than,
                            ToanThan_Phoi,
                            ToanThan_TieuHoa,
                            ToanThan_Tim,
                            ToanThan_ThanKinh,
                            ToanThan_CoXuongKhop,
                            ToanThan_CoQuanKhac,
                            CanLamSang,
                            TacDungPhuCuaThuoc,
                            HuongDieuTriTiepTheo,
                            TK_HenKhamLai,
                            TK_BacSyDieuTri,
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
                            :KhoiPhatBenh,
                            :TuoiBatDauBiBenh,
                            :VaoVienLanThu,
                            :TrieuChungKhoiPhatDauTien,
                            :QuaTrinhBenhLy,
                            :DieuTriTruocDay,
                            :DiUngThuoc,
                            :TSBT_BenhKhac,
                            :TSGD_BenhKhac,
                            :KhamBenh_ToanThan,
                            :KhamBenh_CacBoPhan,
                            :Ngua,
                            :SutCan,
                            :KemAn,
                            :Met,
                            :DauRat,
                            :TrieuChungCoNang_Khac,
                            :BongNuoc_NhanNheo,
                            :BongNuoc_Cang,
                            :BongNuoc_DichBongNuoc,
                            :BongNuoc_DichXuatHuyet,
                            :BongNuoc_DichTrong,
                            :BongNuoc_DichMu,
                            :BongNuoc_NenDaBongNuoc,
                            :BongNuoc_TrenNenDaLanh,
                            :BongNuoc_TrenNenDaDo,
                            :BongNuoc_KichThuoc,
                            :BongNuoc_SoLuong,
                            :VetTrot,
                            :VetTrot_SoLuong,
                            :VayTiet,
                            :Sui,
                            :ViTriTonThuong,
                            :DauHieuNikolsky,
                            :TongDiemAbsis,
                            :TongDiemPVAS,
                            :DiemDanhGiaChatLuongCuocSong,
                            :GhiChu,
                            :CongThucMau,
                            :CongThucMau_Text,
                            :SinhHoaMau,
                            :SinhHoaMau_Text,
                            :TongPhanTichNuocTieu,
                            :TongPhanTichNuocTieu_Text,
                            :XquangNguc,
                            :XquangNguc_Text,
                            :SieuAmOBung,
                            :SieuAmOBung_Text,
                            :SoiTuoiTimNam,
                            :XetNghiemTeBaoTzanck,
                            :MienDichHuynhQuangTrucTiep,
                            :MienDichHuynhQuangGianTiep,
                            :SinhThietDa,
                            :XetNghiemKhac,
                            :PemphigusThongThuong,
                            :PemphigusSui,
                            :PemphigusVayLa,
                            :PemphigusDaMo,
                            :PemphigusGiaDinh,
                            :PemphigusAU,
                            :PemphigusDoThuoc,
                            :DieuTri,
                            :HenKhamLai,
                            :BacSyDieuTri,
                            :TK_HoTen,
                            :TK_Ngay,
                            :Mach,
                            :BenhNhanTuDanhGia,
                            :LamSangDaNiemMac,
                            :ToanThan_Than,
                            :ToanThan_Phoi,
                            :ToanThan_TieuHoa,
                            :ToanThan_Tim,
                            :ToanThan_ThanKinh,
                            :ToanThan_CoXuongKhop,
                            :ToanThan_CoQuanKhac,
                            :CanLamSang,
                            :TacDungPhuCuaThuoc,
                            :HuongDieuTriTiepTheo,
                            :TK_HenKhamLai,
                            :TK_BacSyDieuTri,
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
                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", BenhAnNgoaiTruPemphigus.MaQuanLy));
                Command.Parameters.Add(new MDB.MDBParameter("DieuTriNgoaiTruTu", BenhAnNgoaiTruPemphigus.DieuTriNgoaiTruTu));
                Command.Parameters.Add(new MDB.MDBParameter("DieuTriNgoaiTruDen", BenhAnNgoaiTruPemphigus.DieuTriNgoaiTruDen));
                Command.Parameters.Add(new MDB.MDBParameter("SoCMND", BenhAnNgoaiTruPemphigus.SoCMND));
                Command.Parameters.Add(new MDB.MDBParameter("BaoHiem", BenhAnNgoaiTruPemphigus.BaoHiem));
                Command.Parameters.Add(new MDB.MDBParameter("ChanDoan_TuyenTruoc", BenhAnNgoaiTruPemphigus.ChanDoan_TuyenTruoc));
                Command.Parameters.Add(new MDB.MDBParameter("ChanDoanBanDau", BenhAnNgoaiTruPemphigus.ChanDoanBanDau));
                Command.Parameters.Add(new MDB.MDBParameter("ChanDoanTaiKham1", BenhAnNgoaiTruPemphigus.ChanDoanTaiKham1));
                Command.Parameters.Add(new MDB.MDBParameter("ChanDoanTaiKham2", BenhAnNgoaiTruPemphigus.ChanDoanTaiKham2));
                Command.Parameters.Add(new MDB.MDBParameter("ChanDoanTaiKham3", BenhAnNgoaiTruPemphigus.ChanDoanTaiKham3));
                Command.Parameters.Add(new MDB.MDBParameter("ChanDoanTaiKham4", BenhAnNgoaiTruPemphigus.ChanDoanTaiKham4));
                Command.Parameters.Add(new MDB.MDBParameter("BenhPhu", BenhAnNgoaiTruPemphigus.BenhPhu));
                Command.Parameters.Add(new MDB.MDBParameter("KetQuaDieuTri", BenhAnNgoaiTruPemphigus.KetQuaDieuTri));
                Command.Parameters.Add(new MDB.MDBParameter("BienChung_Text", BenhAnNgoaiTruPemphigus.BienChung_Text));
                Command.Parameters.Add(new MDB.MDBParameter("GDPhongKeHoach", BenhAnNgoaiTruPemphigus.GDPhongKeHoach));
                Command.Parameters.Add(new MDB.MDBParameter("GDPhongKhamBenh", BenhAnNgoaiTruPemphigus.GDPhongKhamBenh));

                Command.Parameters.Add(new MDB.MDBParameter("KhoiPhatBenh", BenhAnNgoaiTruPemphigus.KhoiPhatBenh));
                Command.Parameters.Add(new MDB.MDBParameter("TuoiBatDauBiBenh", BenhAnNgoaiTruPemphigus.TuoiBatDauBiBenh));
                Command.Parameters.Add(new MDB.MDBParameter("VaoVienLanThu", BenhAnNgoaiTruPemphigus.VaoVienLanThu));
                Command.Parameters.Add(new MDB.MDBParameter("TrieuChungKhoiPhatDauTien", BenhAnNgoaiTruPemphigus.TrieuChungKhoiPhatDauTien));
                Command.Parameters.Add(new MDB.MDBParameter("QuaTrinhBenhLy", BenhAnNgoaiTruPemphigus.QuaTrinhBenhLy));
                Command.Parameters.Add(new MDB.MDBParameter("DieuTriTruocDay", BenhAnNgoaiTruPemphigus.DieuTriTruocDay));
                Command.Parameters.Add(new MDB.MDBParameter("DiUngThuoc", BenhAnNgoaiTruPemphigus.DiUngThuoc));
                Command.Parameters.Add(new MDB.MDBParameter("TSBT_BenhKhac", BenhAnNgoaiTruPemphigus.TSBT_BenhKhac));
                Command.Parameters.Add(new MDB.MDBParameter("TSGD_BenhKhac", BenhAnNgoaiTruPemphigus.TSGD_BenhKhac));
                Command.Parameters.Add(new MDB.MDBParameter("KhamBenh_ToanThan", BenhAnNgoaiTruPemphigus.KhamBenh_ToanThan));
                Command.Parameters.Add(new MDB.MDBParameter("KhamBenh_CacBoPhan", BenhAnNgoaiTruPemphigus.KhamBenh_CacBoPhan));
                Command.Parameters.Add(new MDB.MDBParameter("Ngua", BenhAnNgoaiTruPemphigus.Ngua));
                Command.Parameters.Add(new MDB.MDBParameter("SutCan", BenhAnNgoaiTruPemphigus.SutCan));
                Command.Parameters.Add(new MDB.MDBParameter("KemAn", BenhAnNgoaiTruPemphigus.KemAn));
                Command.Parameters.Add(new MDB.MDBParameter("Met", BenhAnNgoaiTruPemphigus.Met));
                Command.Parameters.Add(new MDB.MDBParameter("DauRat", BenhAnNgoaiTruPemphigus.DauRat));
                Command.Parameters.Add(new MDB.MDBParameter("TrieuChungCoNang_Khac", BenhAnNgoaiTruPemphigus.TrieuChungCoNang_Khac));
                Command.Parameters.Add(new MDB.MDBParameter("BongNuoc_NhanNheo", BenhAnNgoaiTruPemphigus.BongNuoc_NhanNheo));
                Command.Parameters.Add(new MDB.MDBParameter("BongNuoc_Cang", BenhAnNgoaiTruPemphigus.BongNuoc_Cang));
                Command.Parameters.Add(new MDB.MDBParameter("BongNuoc_DichBongNuoc", BenhAnNgoaiTruPemphigus.BongNuoc_DichBongNuoc));
                Command.Parameters.Add(new MDB.MDBParameter("BongNuoc_DichXuatHuyet", BenhAnNgoaiTruPemphigus.BongNuoc_DichXuatHuyet));
                Command.Parameters.Add(new MDB.MDBParameter("BongNuoc_DichTrong", BenhAnNgoaiTruPemphigus.BongNuoc_DichTrong));
                Command.Parameters.Add(new MDB.MDBParameter("BongNuoc_DichMu", BenhAnNgoaiTruPemphigus.BongNuoc_DichMu));
                Command.Parameters.Add(new MDB.MDBParameter("BongNuoc_NenDaBongNuoc", BenhAnNgoaiTruPemphigus.BongNuoc_NenDaBongNuoc));
                Command.Parameters.Add(new MDB.MDBParameter("BongNuoc_TrenNenDaLanh", BenhAnNgoaiTruPemphigus.BongNuoc_TrenNenDaLanh));
                Command.Parameters.Add(new MDB.MDBParameter("BongNuoc_TrenNenDaDo", BenhAnNgoaiTruPemphigus.BongNuoc_TrenNenDaDo));
                Command.Parameters.Add(new MDB.MDBParameter("BongNuoc_KichThuoc", BenhAnNgoaiTruPemphigus.BongNuoc_KichThuoc));
                Command.Parameters.Add(new MDB.MDBParameter("BongNuoc_SoLuong", BenhAnNgoaiTruPemphigus.BongNuoc_SoLuong));
                Command.Parameters.Add(new MDB.MDBParameter("VetTrot", BenhAnNgoaiTruPemphigus.VetTrot));
                Command.Parameters.Add(new MDB.MDBParameter("VetTrot_SoLuong", BenhAnNgoaiTruPemphigus.VetTrot_SoLuong));
                Command.Parameters.Add(new MDB.MDBParameter("VayTiet", BenhAnNgoaiTruPemphigus.VayTiet));
                Command.Parameters.Add(new MDB.MDBParameter("Sui", BenhAnNgoaiTruPemphigus.Sui));
                Command.Parameters.Add(new MDB.MDBParameter("ViTriTonThuong", BenhAnNgoaiTruPemphigus.ViTriTonThuong));
                Command.Parameters.Add(new MDB.MDBParameter("DauHieuNikolsky", BenhAnNgoaiTruPemphigus.DauHieuNikolsky));
                Command.Parameters.Add(new MDB.MDBParameter("TongDiemAbsis", BenhAnNgoaiTruPemphigus.TongDiemAbsis));
                Command.Parameters.Add(new MDB.MDBParameter("TongDiemPVAS", BenhAnNgoaiTruPemphigus.TongDiemPVAS));
                Command.Parameters.Add(new MDB.MDBParameter("DiemDanhGiaChatLuongCuocSong", BenhAnNgoaiTruPemphigus.DiemDanhGiaChatLuongCuocSong));
                Command.Parameters.Add(new MDB.MDBParameter("GhiChu", BenhAnNgoaiTruPemphigus.GhiChu));
                Command.Parameters.Add(new MDB.MDBParameter("CongThucMau", BenhAnNgoaiTruPemphigus.CongThucMau));
                Command.Parameters.Add(new MDB.MDBParameter("CongThucMau_Text", BenhAnNgoaiTruPemphigus.CongThucMau_Text));
                Command.Parameters.Add(new MDB.MDBParameter("SinhHoaMau", BenhAnNgoaiTruPemphigus.SinhHoaMau));
                Command.Parameters.Add(new MDB.MDBParameter("SinhHoaMau_Text", BenhAnNgoaiTruPemphigus.SinhHoaMau_Text));
                Command.Parameters.Add(new MDB.MDBParameter("TongPhanTichNuocTieu", BenhAnNgoaiTruPemphigus.TongPhanTichNuocTieu));
                Command.Parameters.Add(new MDB.MDBParameter("TongPhanTichNuocTieu_Text", BenhAnNgoaiTruPemphigus.TongPhanTichNuocTieu_Text));
                Command.Parameters.Add(new MDB.MDBParameter("XquangNguc", BenhAnNgoaiTruPemphigus.XquangNguc));
                Command.Parameters.Add(new MDB.MDBParameter("XquangNguc_Text", BenhAnNgoaiTruPemphigus.XquangNguc_Text));
                Command.Parameters.Add(new MDB.MDBParameter("SieuAmOBung", BenhAnNgoaiTruPemphigus.SieuAmOBung));
                Command.Parameters.Add(new MDB.MDBParameter("SieuAmOBung_Text", BenhAnNgoaiTruPemphigus.SieuAmOBung_Text));
                Command.Parameters.Add(new MDB.MDBParameter("SoiTuoiTimNam", BenhAnNgoaiTruPemphigus.SoiTuoiTimNam));
                Command.Parameters.Add(new MDB.MDBParameter("XetNghiemTeBaoTzanck", BenhAnNgoaiTruPemphigus.XetNghiemTeBaoTzanck));
                Command.Parameters.Add(new MDB.MDBParameter("MienDichHuynhQuangTrucTiep", BenhAnNgoaiTruPemphigus.MienDichHuynhQuangTrucTiep));
                Command.Parameters.Add(new MDB.MDBParameter("MienDichHuynhQuangGianTiep", BenhAnNgoaiTruPemphigus.MienDichHuynhQuangGianTiep));
                Command.Parameters.Add(new MDB.MDBParameter("SinhThietDa", BenhAnNgoaiTruPemphigus.SinhThietDa));
                Command.Parameters.Add(new MDB.MDBParameter("XetNghiemKhac", BenhAnNgoaiTruPemphigus.XetNghiemKhac));
                Command.Parameters.Add(new MDB.MDBParameter("PemphigusThongThuong", BenhAnNgoaiTruPemphigus.PemphigusThongThuong));
                Command.Parameters.Add(new MDB.MDBParameter("PemphigusSui", BenhAnNgoaiTruPemphigus.PemphigusSui));
                Command.Parameters.Add(new MDB.MDBParameter("PemphigusVayLa", BenhAnNgoaiTruPemphigus.PemphigusVayLa));
                Command.Parameters.Add(new MDB.MDBParameter("PemphigusDaMo", BenhAnNgoaiTruPemphigus.PemphigusDaMo));
                Command.Parameters.Add(new MDB.MDBParameter("PemphigusGiaDinh", BenhAnNgoaiTruPemphigus.PemphigusGiaDinh));
                Command.Parameters.Add(new MDB.MDBParameter("PemphigusAU", BenhAnNgoaiTruPemphigus.PemphigusAU));
                Command.Parameters.Add(new MDB.MDBParameter("PemphigusDoThuoc", BenhAnNgoaiTruPemphigus.PemphigusDoThuoc));
                Command.Parameters.Add(new MDB.MDBParameter("DieuTri", BenhAnNgoaiTruPemphigus.DieuTri));
                Command.Parameters.Add(new MDB.MDBParameter("HenKhamLai", BenhAnNgoaiTruPemphigus.HenKhamLai));
                Command.Parameters.Add(new MDB.MDBParameter("BacSyDieuTri", BenhAnNgoaiTruPemphigus.BacSyDieuTri));
                Command.Parameters.Add(new MDB.MDBParameter("TK_HoTen", BenhAnNgoaiTruPemphigus.TK_HoTen));
                Command.Parameters.Add(new MDB.MDBParameter("TK_Ngay", BenhAnNgoaiTruPemphigus.TK_Ngay));
                Command.Parameters.Add(new MDB.MDBParameter("Mach", BenhAnNgoaiTruPemphigus.Mach));
                Command.Parameters.Add(new MDB.MDBParameter("BenhNhanTuDanhGia", BenhAnNgoaiTruPemphigus.BenhNhanTuDanhGia));
                Command.Parameters.Add(new MDB.MDBParameter("LamSangDaNiemMac", BenhAnNgoaiTruPemphigus.LamSangDaNiemMac));
                Command.Parameters.Add(new MDB.MDBParameter("ToanThan_Than", BenhAnNgoaiTruPemphigus.ToanThan_Than));
                Command.Parameters.Add(new MDB.MDBParameter("ToanThan_Phoi", BenhAnNgoaiTruPemphigus.ToanThan_Phoi));
                Command.Parameters.Add(new MDB.MDBParameter("ToanThan_TieuHoa", BenhAnNgoaiTruPemphigus.ToanThan_TieuHoa));
                Command.Parameters.Add(new MDB.MDBParameter("ToanThan_Tim", BenhAnNgoaiTruPemphigus.ToanThan_Tim));
                Command.Parameters.Add(new MDB.MDBParameter("ToanThan_ThanKinh", BenhAnNgoaiTruPemphigus.ToanThan_ThanKinh));
                Command.Parameters.Add(new MDB.MDBParameter("ToanThan_CoXuongKhop", BenhAnNgoaiTruPemphigus.ToanThan_CoXuongKhop));
                Command.Parameters.Add(new MDB.MDBParameter("ToanThan_CoQuanKhac", BenhAnNgoaiTruPemphigus.ToanThan_CoQuanKhac));
                Command.Parameters.Add(new MDB.MDBParameter("CanLamSang", BenhAnNgoaiTruPemphigus.CanLamSang));
                Command.Parameters.Add(new MDB.MDBParameter("TacDungPhuCuaThuoc", BenhAnNgoaiTruPemphigus.TacDungPhuCuaThuoc));
                Command.Parameters.Add(new MDB.MDBParameter("HuongDieuTriTiepTheo", BenhAnNgoaiTruPemphigus.HuongDieuTriTiepTheo));
                Command.Parameters.Add(new MDB.MDBParameter("TK_HenKhamLai", BenhAnNgoaiTruPemphigus.TK_HenKhamLai));
                Command.Parameters.Add(new MDB.MDBParameter("TK_BacSyDieuTri", BenhAnNgoaiTruPemphigus.TK_BacSyDieuTri));

                // Tống kết
                Command.Parameters.Add(new MDB.MDBParameter("TongKet_QuaTrinhBenhLy", BenhAnNgoaiTruPemphigus.TongKet_QuaTrinhBenhLy));
                Command.Parameters.Add(new MDB.MDBParameter("TomTatKetQua", BenhAnNgoaiTruPemphigus.TomTatKetQua));
                Command.Parameters.Add(new MDB.MDBParameter("BenhChinh", BenhAnNgoaiTruPemphigus.BenhChinh));
                Command.Parameters.Add(new MDB.MDBParameter("MaBenhChinh", BenhAnNgoaiTruPemphigus.MaBenhChinh));
                Command.Parameters.Add(new MDB.MDBParameter("BenhKemTheo", BenhAnNgoaiTruPemphigus.BenhKemTheo));
                Command.Parameters.Add(new MDB.MDBParameter("MaBenhKemTheo", BenhAnNgoaiTruPemphigus.MaBenhKemTheo));
                Command.Parameters.Add(new MDB.MDBParameter("PhuongPhapDieuTri", BenhAnNgoaiTruPemphigus.PhuongPhapDieuTri));
                Command.Parameters.Add(new MDB.MDBParameter("TinhTrangRaVien", BenhAnNgoaiTruPemphigus.TinhTrangRaVien));
                Command.Parameters.Add(new MDB.MDBParameter("HuongDieuTri", BenhAnNgoaiTruPemphigus.HuongDieuTri));
                Command.Parameters.Add(new MDB.MDBParameter("NguoiNhanHoSo", BenhAnNgoaiTruPemphigus.NguoiNhanHoSo));
                Command.Parameters.Add(new MDB.MDBParameter("NguoiGiaoHoSo", BenhAnNgoaiTruPemphigus.NguoiGiaoHoSo));
                Command.Parameters.Add(new MDB.MDBParameter("NgayTongKet", BenhAnNgoaiTruPemphigus.NgayTongKet));
                Command.Parameters.Add(new MDB.MDBParameter("TongKet_BacSyDieuTri", BenhAnNgoaiTruPemphigus.TongKet_BacSyDieuTri));
                Command.Parameters.Add(new MDB.MDBParameter("TongKet_MaBacSyDieuTri", BenhAnNgoaiTruPemphigus.TongKet_MaBacSyDieuTri));


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
        public static bool Update(MDB.MDBConnection MyConnection, BenhAnNgoaiTruPemphigus BenhAnNgoaiTruPemphigus)
        {
            try
            {
                string sql = @"UPDATE BenhAnNgoaiTruPemphigus SET 
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
                            KhoiPhatBenh=:KhoiPhatBenh,
                            TuoiBatDauBiBenh=:TuoiBatDauBiBenh,
                            VaoVienLanThu=:VaoVienLanThu,
                            TrieuChungKhoiPhatDauTien=:TrieuChungKhoiPhatDauTien,
                            QuaTrinhBenhLy=:QuaTrinhBenhLy,
                            DieuTriTruocDay=:DieuTriTruocDay,
                            DiUngThuoc=:DiUngThuoc,
                            TSBT_BenhKhac=:TSBT_BenhKhac,
                            TSGD_BenhKhac=:TSGD_BenhKhac,
                            KhamBenh_ToanThan=:KhamBenh_ToanThan,
                            KhamBenh_CacBoPhan=:KhamBenh_CacBoPhan,
                            Ngua=:Ngua,
                            SutCan=:SutCan,
                            KemAn=:KemAn,
                            Met=:Met,
                            DauRat=:DauRat,
                            TrieuChungCoNang_Khac=:TrieuChungCoNang_Khac,
                            BongNuoc_NhanNheo=:BongNuoc_NhanNheo,
                            BongNuoc_Cang=:BongNuoc_Cang,
                            BongNuoc_DichBongNuoc=:BongNuoc_DichBongNuoc,
                            BongNuoc_DichXuatHuyet=:BongNuoc_DichXuatHuyet,
                            BongNuoc_DichTrong=:BongNuoc_DichTrong,
                            BongNuoc_DichMu=:BongNuoc_DichMu,
                            BongNuoc_NenDaBongNuoc=:BongNuoc_NenDaBongNuoc,
                            BongNuoc_TrenNenDaLanh=:BongNuoc_TrenNenDaLanh,
                            BongNuoc_TrenNenDaDo=:BongNuoc_TrenNenDaDo,
                            BongNuoc_KichThuoc=:BongNuoc_KichThuoc,
                            BongNuoc_SoLuong=:BongNuoc_SoLuong,
                            VetTrot=:VetTrot,
                            VetTrot_SoLuong=:VetTrot_SoLuong,
                            VayTiet=:VayTiet,
                            Sui=:Sui,
                            ViTriTonThuong=:ViTriTonThuong,
                            DauHieuNikolsky=:DauHieuNikolsky,
                            TongDiemAbsis=:TongDiemAbsis,
                            TongDiemPVAS=:TongDiemPVAS,
                            DiemDanhGiaChatLuongCuocSong=:DiemDanhGiaChatLuongCuocSong,
                            GhiChu=:GhiChu,
                            CongThucMau=:CongThucMau,
                            CongThucMau_Text=:CongThucMau_Text,
                            SinhHoaMau=:SinhHoaMau,
                            SinhHoaMau_Text=:SinhHoaMau_Text,
                            TongPhanTichNuocTieu=:TongPhanTichNuocTieu,
                            TongPhanTichNuocTieu_Text=:TongPhanTichNuocTieu_Text,
                            XquangNguc=:XquangNguc,
                            XquangNguc_Text=:XquangNguc_Text,
                            SieuAmOBung=:SieuAmOBung,
                            SieuAmOBung_Text=:SieuAmOBung_Text,
                            SoiTuoiTimNam=:SoiTuoiTimNam,
                            XetNghiemTeBaoTzanck=:XetNghiemTeBaoTzanck,
                            MienDichHuynhQuangTrucTiep=:MienDichHuynhQuangTrucTiep,
                            MienDichHuynhQuangGianTiep=:MienDichHuynhQuangGianTiep,
                            SinhThietDa=:SinhThietDa,
                            XetNghiemKhac=:XetNghiemKhac,
                            PemphigusThongThuong=:PemphigusThongThuong,
                            PemphigusSui=:PemphigusSui,
                            PemphigusVayLa=:PemphigusVayLa,
                            PemphigusDaMo=:PemphigusDaMo,
                            PemphigusGiaDinh=:PemphigusGiaDinh,
                            PemphigusAU=:PemphigusAU,
                            PemphigusDoThuoc=:PemphigusDoThuoc,
                            DieuTri=:DieuTri,
                            HenKhamLai=:HenKhamLai,
                            BacSyDieuTri=:BacSyDieuTri,
                            TK_HoTen=:TK_HoTen,
                            TK_Ngay=:TK_Ngay,
                            Mach=:Mach,
                            BenhNhanTuDanhGia=:BenhNhanTuDanhGia,
                            LamSangDaNiemMac=:LamSangDaNiemMac,
                            ToanThan_Than=:ToanThan_Than,
                            ToanThan_Phoi=:ToanThan_Phoi,
                            ToanThan_TieuHoa=:ToanThan_TieuHoa,
                            ToanThan_Tim=:ToanThan_Tim,
                            ToanThan_ThanKinh=:ToanThan_ThanKinh,
                            ToanThan_CoXuongKhop=:ToanThan_CoXuongKhop,
                            ToanThan_CoQuanKhac=:ToanThan_CoQuanKhac,
                            CanLamSang=:CanLamSang,
                            TacDungPhuCuaThuoc=:TacDungPhuCuaThuoc,
                            HuongDieuTriTiepTheo=:HuongDieuTriTiepTheo,
                            TK_HenKhamLai=:TK_HenKhamLai,
                            TK_BacSyDieuTri=:TK_BacSyDieuTri,
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
                Command.Parameters.Add(new MDB.MDBParameter("DieuTriNgoaiTruTu", BenhAnNgoaiTruPemphigus.DieuTriNgoaiTruTu));
                Command.Parameters.Add(new MDB.MDBParameter("DieuTriNgoaiTruDen", BenhAnNgoaiTruPemphigus.DieuTriNgoaiTruDen));
                Command.Parameters.Add(new MDB.MDBParameter("SoCMND", BenhAnNgoaiTruPemphigus.SoCMND));
                Command.Parameters.Add(new MDB.MDBParameter("BaoHiem", BenhAnNgoaiTruPemphigus.BaoHiem));
                Command.Parameters.Add(new MDB.MDBParameter("ChanDoan_TuyenTruoc", BenhAnNgoaiTruPemphigus.ChanDoan_TuyenTruoc));
                Command.Parameters.Add(new MDB.MDBParameter("ChanDoanBanDau", BenhAnNgoaiTruPemphigus.ChanDoanBanDau));
                Command.Parameters.Add(new MDB.MDBParameter("ChanDoanTaiKham1", BenhAnNgoaiTruPemphigus.ChanDoanTaiKham1));
                Command.Parameters.Add(new MDB.MDBParameter("ChanDoanTaiKham2", BenhAnNgoaiTruPemphigus.ChanDoanTaiKham2));
                Command.Parameters.Add(new MDB.MDBParameter("ChanDoanTaiKham3", BenhAnNgoaiTruPemphigus.ChanDoanTaiKham3));
                Command.Parameters.Add(new MDB.MDBParameter("ChanDoanTaiKham4", BenhAnNgoaiTruPemphigus.ChanDoanTaiKham4));
                Command.Parameters.Add(new MDB.MDBParameter("BenhPhu", BenhAnNgoaiTruPemphigus.BenhPhu));
                Command.Parameters.Add(new MDB.MDBParameter("KetQuaDieuTri", BenhAnNgoaiTruPemphigus.KetQuaDieuTri));
                Command.Parameters.Add(new MDB.MDBParameter("BienChung_Text", BenhAnNgoaiTruPemphigus.BienChung_Text));
                Command.Parameters.Add(new MDB.MDBParameter("GDPhongKeHoach", BenhAnNgoaiTruPemphigus.GDPhongKeHoach));
                Command.Parameters.Add(new MDB.MDBParameter("GDPhongKhamBenh", BenhAnNgoaiTruPemphigus.GDPhongKhamBenh));
                // hỏi bệnh, khám bệnh
                Command.Parameters.Add(new MDB.MDBParameter("KhoiPhatBenh", BenhAnNgoaiTruPemphigus.KhoiPhatBenh));
                Command.Parameters.Add(new MDB.MDBParameter("TuoiBatDauBiBenh", BenhAnNgoaiTruPemphigus.TuoiBatDauBiBenh));
                Command.Parameters.Add(new MDB.MDBParameter("VaoVienLanThu", BenhAnNgoaiTruPemphigus.VaoVienLanThu));
                Command.Parameters.Add(new MDB.MDBParameter("TrieuChungKhoiPhatDauTien", BenhAnNgoaiTruPemphigus.TrieuChungKhoiPhatDauTien));
                Command.Parameters.Add(new MDB.MDBParameter("QuaTrinhBenhLy", BenhAnNgoaiTruPemphigus.QuaTrinhBenhLy));
                Command.Parameters.Add(new MDB.MDBParameter("DieuTriTruocDay", BenhAnNgoaiTruPemphigus.DieuTriTruocDay));
                Command.Parameters.Add(new MDB.MDBParameter("DiUngThuoc", BenhAnNgoaiTruPemphigus.DiUngThuoc));
                Command.Parameters.Add(new MDB.MDBParameter("TSBT_BenhKhac", BenhAnNgoaiTruPemphigus.TSBT_BenhKhac));
                Command.Parameters.Add(new MDB.MDBParameter("TSGD_BenhKhac", BenhAnNgoaiTruPemphigus.TSGD_BenhKhac));
                Command.Parameters.Add(new MDB.MDBParameter("KhamBenh_ToanThan", BenhAnNgoaiTruPemphigus.KhamBenh_ToanThan));
                Command.Parameters.Add(new MDB.MDBParameter("KhamBenh_CacBoPhan", BenhAnNgoaiTruPemphigus.KhamBenh_CacBoPhan));
                Command.Parameters.Add(new MDB.MDBParameter("Ngua", BenhAnNgoaiTruPemphigus.Ngua));
                Command.Parameters.Add(new MDB.MDBParameter("SutCan", BenhAnNgoaiTruPemphigus.SutCan));
                Command.Parameters.Add(new MDB.MDBParameter("KemAn", BenhAnNgoaiTruPemphigus.KemAn));
                Command.Parameters.Add(new MDB.MDBParameter("Met", BenhAnNgoaiTruPemphigus.Met));
                Command.Parameters.Add(new MDB.MDBParameter("DauRat", BenhAnNgoaiTruPemphigus.DauRat));
                Command.Parameters.Add(new MDB.MDBParameter("TrieuChungCoNang_Khac", BenhAnNgoaiTruPemphigus.TrieuChungCoNang_Khac));
                Command.Parameters.Add(new MDB.MDBParameter("BongNuoc_NhanNheo", BenhAnNgoaiTruPemphigus.BongNuoc_NhanNheo));
                Command.Parameters.Add(new MDB.MDBParameter("BongNuoc_Cang", BenhAnNgoaiTruPemphigus.BongNuoc_Cang));
                Command.Parameters.Add(new MDB.MDBParameter("BongNuoc_DichBongNuoc", BenhAnNgoaiTruPemphigus.BongNuoc_DichBongNuoc));
                Command.Parameters.Add(new MDB.MDBParameter("BongNuoc_DichXuatHuyet", BenhAnNgoaiTruPemphigus.BongNuoc_DichXuatHuyet));
                Command.Parameters.Add(new MDB.MDBParameter("BongNuoc_DichTrong", BenhAnNgoaiTruPemphigus.BongNuoc_DichTrong));
                Command.Parameters.Add(new MDB.MDBParameter("BongNuoc_DichMu", BenhAnNgoaiTruPemphigus.BongNuoc_DichMu));
                Command.Parameters.Add(new MDB.MDBParameter("BongNuoc_NenDaBongNuoc", BenhAnNgoaiTruPemphigus.BongNuoc_NenDaBongNuoc));
                Command.Parameters.Add(new MDB.MDBParameter("BongNuoc_TrenNenDaLanh", BenhAnNgoaiTruPemphigus.BongNuoc_TrenNenDaLanh));
                Command.Parameters.Add(new MDB.MDBParameter("BongNuoc_TrenNenDaDo", BenhAnNgoaiTruPemphigus.BongNuoc_TrenNenDaDo));
                Command.Parameters.Add(new MDB.MDBParameter("BongNuoc_KichThuoc", BenhAnNgoaiTruPemphigus.BongNuoc_KichThuoc));
                Command.Parameters.Add(new MDB.MDBParameter("BongNuoc_SoLuong", BenhAnNgoaiTruPemphigus.BongNuoc_SoLuong));
                Command.Parameters.Add(new MDB.MDBParameter("VetTrot", BenhAnNgoaiTruPemphigus.VetTrot));
                Command.Parameters.Add(new MDB.MDBParameter("VetTrot_SoLuong", BenhAnNgoaiTruPemphigus.VetTrot_SoLuong));
                Command.Parameters.Add(new MDB.MDBParameter("VayTiet", BenhAnNgoaiTruPemphigus.VayTiet));
                Command.Parameters.Add(new MDB.MDBParameter("Sui", BenhAnNgoaiTruPemphigus.Sui));
                Command.Parameters.Add(new MDB.MDBParameter("ViTriTonThuong", BenhAnNgoaiTruPemphigus.ViTriTonThuong));
                Command.Parameters.Add(new MDB.MDBParameter("DauHieuNikolsky", BenhAnNgoaiTruPemphigus.DauHieuNikolsky));
                Command.Parameters.Add(new MDB.MDBParameter("TongDiemAbsis", BenhAnNgoaiTruPemphigus.TongDiemAbsis));
                Command.Parameters.Add(new MDB.MDBParameter("TongDiemPVAS", BenhAnNgoaiTruPemphigus.TongDiemPVAS));
                Command.Parameters.Add(new MDB.MDBParameter("DiemDanhGiaChatLuongCuocSong", BenhAnNgoaiTruPemphigus.DiemDanhGiaChatLuongCuocSong));
                Command.Parameters.Add(new MDB.MDBParameter("GhiChu", BenhAnNgoaiTruPemphigus.GhiChu));
                Command.Parameters.Add(new MDB.MDBParameter("CongThucMau", BenhAnNgoaiTruPemphigus.CongThucMau));
                Command.Parameters.Add(new MDB.MDBParameter("CongThucMau_Text", BenhAnNgoaiTruPemphigus.CongThucMau_Text));
                Command.Parameters.Add(new MDB.MDBParameter("SinhHoaMau", BenhAnNgoaiTruPemphigus.SinhHoaMau));
                Command.Parameters.Add(new MDB.MDBParameter("SinhHoaMau_Text", BenhAnNgoaiTruPemphigus.SinhHoaMau_Text));
                Command.Parameters.Add(new MDB.MDBParameter("TongPhanTichNuocTieu", BenhAnNgoaiTruPemphigus.TongPhanTichNuocTieu));
                Command.Parameters.Add(new MDB.MDBParameter("TongPhanTichNuocTieu_Text", BenhAnNgoaiTruPemphigus.TongPhanTichNuocTieu_Text));
                Command.Parameters.Add(new MDB.MDBParameter("XquangNguc", BenhAnNgoaiTruPemphigus.XquangNguc));
                Command.Parameters.Add(new MDB.MDBParameter("XquangNguc_Text", BenhAnNgoaiTruPemphigus.XquangNguc_Text));
                Command.Parameters.Add(new MDB.MDBParameter("SieuAmOBung", BenhAnNgoaiTruPemphigus.SieuAmOBung));
                Command.Parameters.Add(new MDB.MDBParameter("SieuAmOBung_Text", BenhAnNgoaiTruPemphigus.SieuAmOBung_Text));
                Command.Parameters.Add(new MDB.MDBParameter("SoiTuoiTimNam", BenhAnNgoaiTruPemphigus.SoiTuoiTimNam));
                Command.Parameters.Add(new MDB.MDBParameter("XetNghiemTeBaoTzanck", BenhAnNgoaiTruPemphigus.XetNghiemTeBaoTzanck));
                Command.Parameters.Add(new MDB.MDBParameter("MienDichHuynhQuangTrucTiep", BenhAnNgoaiTruPemphigus.MienDichHuynhQuangTrucTiep));
                Command.Parameters.Add(new MDB.MDBParameter("MienDichHuynhQuangGianTiep", BenhAnNgoaiTruPemphigus.MienDichHuynhQuangGianTiep));
                Command.Parameters.Add(new MDB.MDBParameter("SinhThietDa", BenhAnNgoaiTruPemphigus.SinhThietDa));
                Command.Parameters.Add(new MDB.MDBParameter("XetNghiemKhac", BenhAnNgoaiTruPemphigus.XetNghiemKhac));
                Command.Parameters.Add(new MDB.MDBParameter("PemphigusThongThuong", BenhAnNgoaiTruPemphigus.PemphigusThongThuong));
                Command.Parameters.Add(new MDB.MDBParameter("PemphigusSui", BenhAnNgoaiTruPemphigus.PemphigusSui));
                Command.Parameters.Add(new MDB.MDBParameter("PemphigusVayLa", BenhAnNgoaiTruPemphigus.PemphigusVayLa));
                Command.Parameters.Add(new MDB.MDBParameter("PemphigusDaMo", BenhAnNgoaiTruPemphigus.PemphigusDaMo));
                Command.Parameters.Add(new MDB.MDBParameter("PemphigusGiaDinh", BenhAnNgoaiTruPemphigus.PemphigusGiaDinh));
                Command.Parameters.Add(new MDB.MDBParameter("PemphigusAU", BenhAnNgoaiTruPemphigus.PemphigusAU));
                Command.Parameters.Add(new MDB.MDBParameter("PemphigusDoThuoc", BenhAnNgoaiTruPemphigus.PemphigusDoThuoc));
                Command.Parameters.Add(new MDB.MDBParameter("DieuTri", BenhAnNgoaiTruPemphigus.DieuTri));
                Command.Parameters.Add(new MDB.MDBParameter("HenKhamLai", BenhAnNgoaiTruPemphigus.HenKhamLai));
                Command.Parameters.Add(new MDB.MDBParameter("BacSyDieuTri", BenhAnNgoaiTruPemphigus.BacSyDieuTri));
                Command.Parameters.Add(new MDB.MDBParameter("TK_HoTen", BenhAnNgoaiTruPemphigus.TK_HoTen));
                Command.Parameters.Add(new MDB.MDBParameter("TK_Ngay", BenhAnNgoaiTruPemphigus.TK_Ngay));
                Command.Parameters.Add(new MDB.MDBParameter("Mach", BenhAnNgoaiTruPemphigus.Mach));
                Command.Parameters.Add(new MDB.MDBParameter("BenhNhanTuDanhGia", BenhAnNgoaiTruPemphigus.BenhNhanTuDanhGia));
                Command.Parameters.Add(new MDB.MDBParameter("LamSangDaNiemMac", BenhAnNgoaiTruPemphigus.LamSangDaNiemMac));
                Command.Parameters.Add(new MDB.MDBParameter("ToanThan_Than", BenhAnNgoaiTruPemphigus.ToanThan_Than));
                Command.Parameters.Add(new MDB.MDBParameter("ToanThan_Phoi", BenhAnNgoaiTruPemphigus.ToanThan_Phoi));
                Command.Parameters.Add(new MDB.MDBParameter("ToanThan_TieuHoa", BenhAnNgoaiTruPemphigus.ToanThan_TieuHoa));
                Command.Parameters.Add(new MDB.MDBParameter("ToanThan_Tim", BenhAnNgoaiTruPemphigus.ToanThan_Tim));
                Command.Parameters.Add(new MDB.MDBParameter("ToanThan_ThanKinh", BenhAnNgoaiTruPemphigus.ToanThan_ThanKinh));
                Command.Parameters.Add(new MDB.MDBParameter("ToanThan_CoXuongKhop", BenhAnNgoaiTruPemphigus.ToanThan_CoXuongKhop));
                Command.Parameters.Add(new MDB.MDBParameter("ToanThan_CoQuanKhac", BenhAnNgoaiTruPemphigus.ToanThan_CoQuanKhac));
                Command.Parameters.Add(new MDB.MDBParameter("CanLamSang", BenhAnNgoaiTruPemphigus.CanLamSang));
                Command.Parameters.Add(new MDB.MDBParameter("TacDungPhuCuaThuoc", BenhAnNgoaiTruPemphigus.TacDungPhuCuaThuoc));
                Command.Parameters.Add(new MDB.MDBParameter("HuongDieuTriTiepTheo", BenhAnNgoaiTruPemphigus.HuongDieuTriTiepTheo));
                Command.Parameters.Add(new MDB.MDBParameter("TK_HenKhamLai", BenhAnNgoaiTruPemphigus.TK_HenKhamLai));
                Command.Parameters.Add(new MDB.MDBParameter("TK_BacSyDieuTri", BenhAnNgoaiTruPemphigus.TK_BacSyDieuTri));

                // Tổng kết
                Command.Parameters.Add(new MDB.MDBParameter("TongKet_QuaTrinhBenhLy", BenhAnNgoaiTruPemphigus.TongKet_QuaTrinhBenhLy));
                Command.Parameters.Add(new MDB.MDBParameter("TomTatKetQua", BenhAnNgoaiTruPemphigus.TomTatKetQua));
                Command.Parameters.Add(new MDB.MDBParameter("BenhChinh", BenhAnNgoaiTruPemphigus.BenhChinh));
                Command.Parameters.Add(new MDB.MDBParameter("MaBenhChinh", BenhAnNgoaiTruPemphigus.MaBenhChinh));
                Command.Parameters.Add(new MDB.MDBParameter("BenhKemTheo", BenhAnNgoaiTruPemphigus.BenhKemTheo));
                Command.Parameters.Add(new MDB.MDBParameter("MaBenhKemTheo", BenhAnNgoaiTruPemphigus.MaBenhKemTheo));
                Command.Parameters.Add(new MDB.MDBParameter("PhuongPhapDieuTri", BenhAnNgoaiTruPemphigus.PhuongPhapDieuTri));
                Command.Parameters.Add(new MDB.MDBParameter("TinhTrangRaVien", BenhAnNgoaiTruPemphigus.TinhTrangRaVien));
                Command.Parameters.Add(new MDB.MDBParameter("HuongDieuTri", BenhAnNgoaiTruPemphigus.HuongDieuTri));
                Command.Parameters.Add(new MDB.MDBParameter("NguoiNhanHoSo", BenhAnNgoaiTruPemphigus.NguoiNhanHoSo));
                Command.Parameters.Add(new MDB.MDBParameter("NguoiGiaoHoSo", BenhAnNgoaiTruPemphigus.NguoiGiaoHoSo));
                Command.Parameters.Add(new MDB.MDBParameter("NgayTongKet", BenhAnNgoaiTruPemphigus.NgayTongKet));
                Command.Parameters.Add(new MDB.MDBParameter("TongKet_BacSyDieuTri", BenhAnNgoaiTruPemphigus.TongKet_BacSyDieuTri));
                Command.Parameters.Add(new MDB.MDBParameter("TongKet_MaBacSyDieuTri", BenhAnNgoaiTruPemphigus.TongKet_MaBacSyDieuTri));

                Command.BindByName = true;

                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", BenhAnNgoaiTruPemphigus.MaQuanLy));
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
