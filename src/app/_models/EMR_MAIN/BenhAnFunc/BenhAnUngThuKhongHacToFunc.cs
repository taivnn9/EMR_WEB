using EMR_MAIN.DATABASE.BenhAn;
using EMR_MAIN.ViewModel;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.IO;
using System.Net.Http;
using System.Net.Http.Headers;

namespace EMR_MAIN.DATABASE.BenhAnFunc
{
    public class BenhAnUngThuKhongHacToFunc
    {
        public static void WriteXml(MDB.MDBConnection MyConnection)
        {
            string sql =
                   @"
                  select  a.*,  CTScanner HoSo_CTScanner, SieuAm HoSo_SieuAm, XetNghiem HoSo_XetNghiem,  Khac HoSo_Khac,  Khac_Text HoSo_Khac_Text,  ToanBoHoSo HoSo_ToanBoHoSo, Mach DauSinhTon_Mach,  NhietDo DauSinhTon_NhietDo,  HuyetAp DauSinhTon_HuyetAp,  NhipTho DauSinhTon_NhipTho,  CanNang DauSinhTon_CanNang  
                  from BenhAnUngThuKhongHacTo a inner join thongtindieutri b on a.maquanly = b.maquanly
                  where rownum = 1
                    ";
            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
            MDB.MDBDataReader DataReader = Command.ExecuteReader();

            var DataTable = new DataTable { TableName = "BenhAnUngThuKhongHacTo" };
            DataTable.Load(DataReader as IDataReader);
            DataTable.WriteXml("rptBenhAnUngThuKhongHacTo.xml");
        }
        public static DataSet SelectDataSet(MDB.MDBConnection MyConnection, decimal MaQuanLy)
        {
            string sql =
                   @"
                  select  a.*, g.hovaten TK_BacSyDieuTriHoVaTen, d.hovaten NguoiGiaoHoSoHoVaTen,e.hovaten NguoiNhanHoSoHoVaTen, b.XQuang HoSo_XQuang, b.CTScanner HoSo_CTScanner, b.SieuAm HoSo_SieuAm, b.XetNghiem HoSo_XetNghiem,  b.Khac HoSo_Khac,  b.Khac_Text HoSo_Khac_Text,  b.ToanBoHoSo HoSo_ToanBoHoSo, b.Mach DauSinhTon_Mach, b.NhietDo DauSinhTon_NhietDo,  b.HuyetAp DauSinhTon_HuyetAp,  b.NhipTho DauSinhTon_NhipTho,  b.CanNang DauSinhTon_CanNang  , b.ChieuCao DauSinhTon_ChieuCao, b.BMI DauSinhTon_BMI, b.NgayRaVien 
                        from BenhAnUngThuKhongHacTo a  
                  left join thongtindieutri b on a.maquanly = b.maquanly 
                  left join nhanvien g on a.TongKet_BacSyDieuTri = g.manhanvien
                  left join nhanvien d on a.NguoiGiaoHoSo = d.manhanvien
                  left join nhanvien e on a.NguoiNhanHoSo = e.manhanvien where a.maquanly = " + MaQuanLy.ToString(System.Globalization.CultureInfo.InvariantCulture);
            MDB.MDBDataAdapter adt = new MDB.MDBDataAdapter(sql, MyConnection);
            var ds = new DataSet();
            adt.Fill(ds, "Table");
            ObservableCollection<TheoDoiDieuTri_BAUngThuDaHacTo>  TheoDoiDieuTris = JsonConvert.DeserializeObject<ObservableCollection<TheoDoiDieuTri_BAUngThuDaHacTo>>(ds.Tables[0].Rows[0]["TheoDoiDieuTris"].ToString());
            ds.Tables.Add(Common.ListToDataTable(TheoDoiDieuTris, "CT"));
            return ds;
        }
        public static BenhAnUngThuKhongHacTo Select(MDB.MDBConnection MyConnection, decimal MaQuanLy)
        {
            var obj = new BenhAnUngThuKhongHacTo();
            try
            {
                #region
                string sql =
                          @"select * 
                        from BenhAnUngThuKhongHacTo 
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
                    obj.HB_TGPhatBenh = DataReader["HB_TGPhatBenh"].ToString();
                    obj.HB_TrieuTrungDauTien = DataReader["HB_TrieuTrungDauTien"].ToString();
                    obj.XuatHienTrenVungDa = DataReader.GetInt("XuatHienTrenVungDa");
                    obj.HB_QuaTrinhBenhLy = DataReader["HB_QuaTrinhBenhLy"].ToString();
                    obj.DieuTriTruocDay = DataReader.GetInt("DieuTriTruocDay");
                    obj.HB_PhuongPhapDieuTri = DataReader["HB_PhuongPhapDieuTri"].ToString();
                    obj.HB_KetQuaDieuTri = DataReader["HB_KetQuaDieuTri"].ToString();
                    obj.TienSuBanThan = DataReader["TienSuBanThan"].ToString();
                    obj.TienSuBenhLyNoiNgoai = DataReader["TienSuBenhLyNoiNgoai"].ToString();
                    obj.TienSuBenhLyDaManTinh = DataReader["TienSuBenhLyDaManTinh"].ToString();
                    obj.HutThuocLa = DataReader.GetInt("HutThuocLa");
                    obj.HutThuocLa_SoBao = DataReader["HutThuocLa_SoBao"].ToString();
                    obj.AnTrau = DataReader.GetInt("AnTrau");
                    obj.AnTrau_SoNam = DataReader["AnTrau_SoNam"].ToString();
                    obj.UongRuou = DataReader.GetInt("UongRuou");
                    obj.UongRuou_Ml = DataReader["UongRuou_Ml"].ToString();
                    obj.ThoiQuenSinhHoat_Khac = DataReader["ThoiQuenSinhHoat_Khac"].ToString();
                    obj.TienSuTiepXucMatTroi = DataReader.GetInt("TienSuTiepXucMatTroi");
                    obj.TanSuat_TiepXucMatTroi = DataReader["TanSuat_TiepXucMatTroi"].ToString();
                    obj.ThoiGian_TiepXucMatTroi = DataReader["ThoiGian_TiepXucMatTroi"].ToString();
                    obj.ThoiDiem1016h = DataReader.GetInt("ThoiDiem1016h");
                    obj.ThoiDiem_Khac = DataReader["ThoiDiem_Khac"].ToString();
                    obj.BienPhapBaoVe = DataReader.GetInt("BienPhapBaoVe");
                    obj.QuanAo = DataReader.GetInt("QuanAo");
                    obj.KemChongNang = DataReader.GetInt("KemChongNang");
                    obj.PhuongPhapKhac = DataReader.GetInt("PhuongPhapKhac");
                    obj.LamInPhoTo = DataReader.GetInt("LamInPhoTo");
                    obj.TiepXucNhuaDuong = DataReader.GetInt("TiepXucNhuaDuong");
                    obj.SuDungBepThanToOng = DataReader.GetInt("SuDungBepThanToOng");
                    obj.BienPhapBaoVe_HacIn = DataReader.GetInt("BienPhapBaoVe_HacIn");
                    obj.DungThuocChuaArsen = DataReader.GetInt("DungThuocChuaArsen");
                    obj.DungNuocGiengKhoan = DataReader.GetInt("DungNuocGiengKhoan");
                    obj.DungTamLopFibroXiMang = DataReader.GetInt("DungTamLopFibroXiMang");
                    obj.TienSuTiepXucArsen_Khac = DataReader["TienSuTiepXucArsen_Khac"].ToString();
                    obj.TienSuTiepXucPhongXa = DataReader.GetInt("TienSuTiepXucPhongXa");
                    obj.TanSuat_TiepXucPhongXa = DataReader["TanSuat_TiepXucPhongXa"].ToString();
                    obj.ThoiGian_TiepXucPhongXa = DataReader["ThoiGian_TiepXucPhongXa"].ToString();
                    obj.MoiTruongONhiem = DataReader.GetInt("MoiTruongONhiem");
                    obj.ThuocDietNam = DataReader.GetInt("ThuocDietNam");
                    obj.HoaChatKhac = DataReader.GetInt("HoaChatKhac");
                    obj.ChatDietCo = DataReader.GetInt("ChatDietCo");
                    obj.ThuocTruSau = DataReader.GetInt("ThuocTruSau");
                    obj.ThoiGianTiepXuc = DataReader["ThoiGianTiepXuc"].ToString();
                    obj.DungThuocUCMD = DataReader.GetInt("DungThuocUCMD");
                    obj.GhepTang = DataReader.GetInt("GhepTang");
                    obj.GhepTang_CuThe = DataReader["GhepTang_CuThe"].ToString();
                    obj.NhiemHIVAIDS = DataReader.GetInt("NhiemHIVAIDS");
                    obj.SuyGiamMienDich_Khac = DataReader["SuyGiamMienDich_Khac"].ToString();
                    obj.CoNguoiBiUngThuDa = DataReader.GetInt("CoNguoiBiUngThuDa");
                    obj.LoaiUngThuDa = DataReader["LoaiUngThuDa"].ToString();
                    obj.CoNguoiBiUngThuKhac = DataReader.GetInt("CoNguoiBiUngThuKhac");
                    obj.LoaiUngThuKhac = DataReader["LoaiUngThuKhac"].ToString();
                    obj.TienSuGiaDinh_Khac = DataReader["TienSuGiaDinh_Khac"].ToString();
                    obj.ToanThan = DataReader["ToanThan"].ToString();
                    obj.CacBoPhan = DataReader["CacBoPhan"].ToString();
                    obj.TypDa = DataReader.GetInt("TypDa");
                    obj.ThuongTonCoBan = DataReader["ThuongTonCoBan"].ToString();
                    obj.TangSacTo_DongNhat = DataReader.GetInt("TangSacTo_DongNhat");
                    obj.TangSacTo_KhongDongNhat = DataReader.GetInt("TangSacTo_KhongDongNhat");
                    obj.TangSacTo_Khong = DataReader.GetInt("TangSacTo_Khong");
                    obj.BoThuongTon_Deu = DataReader.GetInt("BoThuongTon_Deu");
                    obj.BoThuongTon_KhongDeu = DataReader.GetInt("BoThuongTon_KhongDeu");
                    obj.BoThuongTon_NoiCao = DataReader.GetInt("BoThuongTon_NoiCao");
                    obj.BoThuongTon_BangPhang = DataReader.GetInt("BoThuongTon_BangPhang");
                    obj.BoThuongTon_CoHatNgoc = DataReader.GetInt("BoThuongTon_CoHatNgoc");
                    obj.DoiXung = DataReader.GetInt("DoiXung");
                    obj.TienTrienTrongThoiGian = DataReader.GetInt("TienTrienTrongThoiGian");
                    obj.GianMachQuanhThuongTon = DataReader.GetInt("GianMachQuanhThuongTon");
                    obj.KichThuoc = DataReader["KichThuoc"].ToString();
                    obj.SoLuong = DataReader["SoLuong"].ToString();
                    obj.BienDangCacCoQuan = DataReader.GetInt("BienDangCacCoQuan");
                    obj.TinhTrangBienDang = DataReader["TinhTrangBienDang"].ToString();
                    obj.Hach = DataReader.GetInt("Hach");
                    obj.ViTriSoLuongHach = DataReader["ViTriSoLuongHach"].ToString();
                    obj.BatThuongBoPhanKhac = DataReader["BatThuongBoPhanKhac"].ToString();
                    obj.TheU = DataReader.GetInt("TheU");
                    obj.TheNang = DataReader.GetInt("TheNang");
                    obj.TheXoHoa = DataReader.GetInt("TheXoHoa");
                    obj.TheNong = DataReader.GetInt("TheNong");
                    obj.UngThuBieuMo_Khac = DataReader["UngThuBieuMo_Khac"].ToString();
                    obj.SCCSui = DataReader.GetInt("SCCSui");
                    obj.SCCSinhDucHauMon = DataReader.GetInt("SCCSinhDucHauMon");
                    obj.LoetMarjolin = DataReader.GetInt("LoetMarjolin");
                    obj.SCCQuanhMong = DataReader.GetInt("SCCQuanhMong");
                    obj.SCCQuanhMieng = DataReader.GetInt("SCCQuanhMieng");
                    obj.Bowen = DataReader.GetInt("Bowen");
                    obj.Keratoacanthoma = DataReader.GetInt("Keratoacanthoma");
                    obj.UngThuBieuMoTeBao_Khac = DataReader["UngThuBieuMoTeBao_Khac"].ToString();
                    obj.TheUngThu = DataReader["TheUngThu"].ToString();
                    obj.TNM_T = DataReader["TNM_T"].ToString();
                    obj.TNM_N = DataReader["TNM_N"].ToString();
                    obj.TNM_M = DataReader["TNM_M"].ToString();
                    obj.PhanLoaiGiaiDoan_TNM = DataReader.GetInt("PhanLoaiGiaiDoan_TNM");
                    obj.CatRongCoDien = DataReader.GetInt("CatRongCoDien");
                    obj.CatBoThuongTon = DataReader["CatBoThuongTon"].ToString();
                    obj.Mosh = DataReader.GetInt("Mosh");
                    obj.SoLuongCatMosh = DataReader["SoLuongCatMosh"].ToString();
                    obj.TuLien = DataReader.GetInt("TuLien");
                    obj.DongTrucTiep = DataReader.GetInt("DongTrucTiep");
                    obj.VatTaiCho = DataReader.GetInt("VatTaiCho");
                    obj.VatXa = DataReader.GetInt("VatXa");
                    obj.VatViPhau = DataReader.GetInt("VatViPhau");
                    obj.GhepDa = DataReader.GetInt("GhepDa");
                    obj.TaoHinhKhuyetDa_Khac = DataReader["TaoHinhKhuyetDa_Khac"].ToString();
                    obj.NaoVetHach_ToanBo = DataReader.GetInt("NaoVetHach_ToanBo");
                    obj.NaoVetHach_HachGac = DataReader.GetInt("NaoVetHach_HachGac");
                    obj.TiaXaHoacHoaChat = DataReader["TiaXaHoacHoaChat"].ToString();
                    obj.DieuTri_PhuongPhapKhac = DataReader["DieuTri_PhuongPhapKhac"].ToString();
                    obj.PhauThuatLanh = DataReader.GetInt("PhauThuatLanh");
                    obj.HoaChatTaiCho = DataReader.GetInt("HoaChatTaiCho");
                    obj.TenThuoc = DataReader["TenThuoc"].ToString();
                    obj.PhaHuyBangNhiet = DataReader.GetInt("PhaHuyBangNhiet");

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
                    obj.NgayTongKet = DataReader["NgayTongKet"] != DBNull.Value ? (DateTime?)Convert.ToDateTime(DataReader["NgayTongKet"]) : null;
                    obj.TongKet_BacSyDieuTri = DataReader["TongKet_BacSyDieuTri"].ToString();
                    obj.TongKet_MaBacSyDieuTri = DataReader["TongKet_MaBacSyDieuTri"].ToString();
                    obj.TheoDoiDieuTris = JsonConvert.DeserializeObject<ObservableCollection<TheoDoiDieuTri_BAUngThuDaHacTo>>(DataReader["TheoDoiDieuTris"].ToString());
                    obj.ThoiGianSongSauDieuTri = DataReader.GetInt("ThoiGianSongSauDieuTri");
                    obj.ChayMau = DataReader.GetInt("ChayMau");
                    obj.TuMau = DataReader.GetInt("TuMau");
                    obj.NhiemTrung = DataReader.GetInt("NhiemTrung");
                    obj.LauLienVetMo = DataReader.GetInt("LauLienVetMo");
                    obj.SeoXau = DataReader.GetInt("SeoXau");
                    obj.PhuBachMach = DataReader.GetInt("PhuBachMach");
                    obj.AnhHuongChucNang = DataReader.GetInt("AnhHuongChucNang");
                    obj.BienChungXa_Khac = DataReader["BienChungXa_Khac"].ToString();

                }
            }
            catch (Exception ex)
            {
                XuLyLoi.Handle(ex);
            }

            return obj;
        }
        public static bool InsertOrUpdate(MDB.MDBConnection MyConnection, BenhAnUngThuKhongHacTo BenhAnUngThuKhongHacTo)
        {
            try
            {
                string sql =
                          @"select MaQuanLy 
                            from BenhAnUngThuKhongHacTo
                            where MaQuanLy = :MaQuanLy";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", BenhAnUngThuKhongHacTo.MaQuanLy));
                MDB.MDBDataReader DataReader = Command.ExecuteReader();
                int rowCount = 0;
                while (DataReader.Read()) rowCount++;
                if (rowCount == 1) return Update(MyConnection, BenhAnUngThuKhongHacTo);
                sql = @"
                       INSERT INTO BenhAnUngThuKhongHacTo 
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
                            HB_TGPhatBenh,
                            HB_TrieuTrungDauTien,
                            XuatHienTrenVungDa,
                            HB_QuaTrinhBenhLy,
                            DieuTriTruocDay,
                            HB_PhuongPhapDieuTri,
                            HB_KetQuaDieuTri,
                            TienSuBanThan,
                            TienSuBenhLyNoiNgoai,
                            TienSuBenhLyDaManTinh,
                            HutThuocLa,
                            HutThuocLa_SoBao,
                            AnTrau,
                            AnTrau_SoNam,
                            UongRuou,
                            UongRuou_Ml,
                            ThoiQuenSinhHoat_Khac,
                            TienSuTiepXucMatTroi,
                            TanSuat_TiepXucMatTroi,
                            ThoiGian_TiepXucMatTroi,
                            ThoiDiem1016h,
                            ThoiDiem_Khac,
                            BienPhapBaoVe,
                            QuanAo,
                            KemChongNang,
                            PhuongPhapKhac,
                            LamInPhoTo,
                            TiepXucNhuaDuong,
                            SuDungBepThanToOng,
                            BienPhapBaoVe_HacIn,
                            DungThuocChuaArsen,
                            DungNuocGiengKhoan,
                            DungTamLopFibroXiMang,
                            TienSuTiepXucArsen_Khac,
                            TienSuTiepXucPhongXa,
                            TanSuat_TiepXucPhongXa,
                            ThoiGian_TiepXucPhongXa,
                            MoiTruongONhiem,
                            ThuocDietNam,
                            HoaChatKhac,
                            ChatDietCo,
                            ThuocTruSau,
                            ThoiGianTiepXuc,
                            DungThuocUCMD,
                            GhepTang,
                            GhepTang_CuThe,
                            NhiemHIVAIDS,
                            SuyGiamMienDich_Khac,
                            CoNguoiBiUngThuDa,
                            LoaiUngThuDa,
                            CoNguoiBiUngThuKhac,
                            LoaiUngThuKhac,
                            TienSuGiaDinh_Khac,
                            ToanThan,
                            CacBoPhan,
                            TypDa,
                            ThuongTonCoBan,
                            TangSacTo_DongNhat,
                            TangSacTo_KhongDongNhat,
                            TangSacTo_Khong,
                            BoThuongTon_Deu,
                            BoThuongTon_KhongDeu,
                            BoThuongTon_NoiCao,
                            BoThuongTon_BangPhang,
                            BoThuongTon_CoHatNgoc,
                            DoiXung,
                            TienTrienTrongThoiGian,
                            GianMachQuanhThuongTon,
                            KichThuoc,
                            SoLuong,
                            BienDangCacCoQuan,
                            TinhTrangBienDang,
                            Hach,
                            ViTriSoLuongHach,
                            BatThuongBoPhanKhac,
                            TheU,
                            TheNang,
                            TheXoHoa,
                            TheNong,
                            UngThuBieuMo_Khac,
                            SCCSui,
                            SCCSinhDucHauMon,
                            LoetMarjolin,
                            SCCQuanhMong,
                            SCCQuanhMieng,
                            Bowen,
                            Keratoacanthoma,
                            UngThuBieuMoTeBao_Khac,
                            TheUngThu,
                            TNM_T,
                            TNM_N,
                            TNM_M,
                            PhanLoaiGiaiDoan_TNM,
                            CatRongCoDien,
                            CatBoThuongTon,
                            Mosh,
                            SoLuongCatMosh,
                            TuLien,
                            DongTrucTiep,
                            VatTaiCho,
                            VatXa,
                            VatViPhau,
                            GhepDa,
                            TaoHinhKhuyetDa_Khac,
                            NaoVetHach_ToanBo,
                            NaoVetHach_HachGac,
                            TiaXaHoacHoaChat,
                            DieuTri_PhuongPhapKhac,
                            PhauThuatLanh,
                            HoaChatTaiCho,
                            TenThuoc,
                            PhaHuyBangNhiet,
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
                            TongKet_MaBacSyDieuTri,
                            TheoDoiDieuTris,
                            ThoiGianSongSauDieuTri,
                            ChayMau,
                            TuMau,
                            NhiemTrung,
                            LauLienVetMo,
                            SeoXau,
                            PhuBachMach,
                            AnhHuongChucNang,
                            BienChungXa_Khac
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
                            :HB_TGPhatBenh,
                            :HB_TrieuTrungDauTien,
                            :XuatHienTrenVungDa,
                            :HB_QuaTrinhBenhLy,
                            :DieuTriTruocDay,
                            :HB_PhuongPhapDieuTri,
                            :HB_KetQuaDieuTri,
                            :TienSuBanThan,
                            :TienSuBenhLyNoiNgoai,
                            :TienSuBenhLyDaManTinh,
                            :HutThuocLa,
                            :HutThuocLa_SoBao,
                            :AnTrau,
                            :AnTrau_SoNam,
                            :UongRuou,
                            :UongRuou_Ml,
                            :ThoiQuenSinhHoat_Khac,
                            :TienSuTiepXucMatTroi,
                            :TanSuat_TiepXucMatTroi,
                            :ThoiGian_TiepXucMatTroi,
                            :ThoiDiem1016h,
                            :ThoiDiem_Khac,
                            :BienPhapBaoVe,
                            :QuanAo,
                            :KemChongNang,
                            :PhuongPhapKhac,
                            :LamInPhoTo,
                            :TiepXucNhuaDuong,
                            :SuDungBepThanToOng,
                            :BienPhapBaoVe_HacIn,
                            :DungThuocChuaArsen,
                            :DungNuocGiengKhoan,
                            :DungTamLopFibroXiMang,
                            :TienSuTiepXucArsen_Khac,
                            :TienSuTiepXucPhongXa,
                            :TanSuat_TiepXucPhongXa,
                            :ThoiGian_TiepXucPhongXa,
                            :MoiTruongONhiem,
                            :ThuocDietNam,
                            :HoaChatKhac,
                            :ChatDietCo,
                            :ThuocTruSau,
                            :ThoiGianTiepXuc,
                            :DungThuocUCMD,
                            :GhepTang,
                            :GhepTang_CuThe,
                            :NhiemHIVAIDS,
                            :SuyGiamMienDich_Khac,
                            :CoNguoiBiUngThuDa,
                            :LoaiUngThuDa,
                            :CoNguoiBiUngThuKhac,
                            :LoaiUngThuKhac,
                            :TienSuGiaDinh_Khac,
                            :ToanThan,
                            :CacBoPhan,
                            :TypDa,
                            :ThuongTonCoBan,
                            :TangSacTo_DongNhat,
                            :TangSacTo_KhongDongNhat,
                            :TangSacTo_Khong,
                            :BoThuongTon_Deu,
                            :BoThuongTon_KhongDeu,
                            :BoThuongTon_NoiCao,
                            :BoThuongTon_BangPhang,
                            :BoThuongTon_CoHatNgoc,
                            :DoiXung,
                            :TienTrienTrongThoiGian,
                            :GianMachQuanhThuongTon,
                            :KichThuoc,
                            :SoLuong,
                            :BienDangCacCoQuan,
                            :TinhTrangBienDang,
                            :Hach,
                            :ViTriSoLuongHach,
                            :BatThuongBoPhanKhac,
                            :TheU,
                            :TheNang,
                            :TheXoHoa,
                            :TheNong,
                            :UngThuBieuMo_Khac,
                            :SCCSui,
                            :SCCSinhDucHauMon,
                            :LoetMarjolin,
                            :SCCQuanhMong,
                            :SCCQuanhMieng,
                            :Bowen,
                            :Keratoacanthoma,
                            :UngThuBieuMoTeBao_Khac,
                            :TheUngThu,
                            :TNM_T,
                            :TNM_N,
                            :TNM_M,
                            :PhanLoaiGiaiDoan_TNM,
                            :CatRongCoDien,
                            :CatBoThuongTon,
                            :Mosh,
                            :SoLuongCatMosh,
                            :TuLien,
                            :DongTrucTiep,
                            :VatTaiCho,
                            :VatXa,
                            :VatViPhau,
                            :GhepDa,
                            :TaoHinhKhuyetDa_Khac,
                            :NaoVetHach_ToanBo,
                            :NaoVetHach_HachGac,
                            :TiaXaHoacHoaChat,
                            :DieuTri_PhuongPhapKhac,
                            :PhauThuatLanh,
                            :HoaChatTaiCho,
                            :TenThuoc,
                            :PhaHuyBangNhiet,
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
                            :TongKet_MaBacSyDieuTri,
                            :TheoDoiDieuTris,
                            :ThoiGianSongSauDieuTri,
                            :ChayMau,
                            :TuMau,
                            :NhiemTrung,
                            :LauLienVetMo,
                            :SeoXau,
                            :PhuBachMach,
                            :AnhHuongChucNang,
                            :BienChungXa_Khac                      
                        )";
                Command = new MDB.MDBCommand(sql, MyConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", BenhAnUngThuKhongHacTo.MaQuanLy));
                Command.Parameters.Add(new MDB.MDBParameter("DieuTriNgoaiTruTu", BenhAnUngThuKhongHacTo.DieuTriNgoaiTruTu));
                Command.Parameters.Add(new MDB.MDBParameter("DieuTriNgoaiTruDen", BenhAnUngThuKhongHacTo.DieuTriNgoaiTruDen));
                Command.Parameters.Add(new MDB.MDBParameter("SoCMND", BenhAnUngThuKhongHacTo.SoCMND));
                Command.Parameters.Add(new MDB.MDBParameter("BaoHiem", BenhAnUngThuKhongHacTo.BaoHiem));
                Command.Parameters.Add(new MDB.MDBParameter("ChanDoan_TuyenTruoc", BenhAnUngThuKhongHacTo.ChanDoan_TuyenTruoc));
                Command.Parameters.Add(new MDB.MDBParameter("ChanDoanBanDau", BenhAnUngThuKhongHacTo.ChanDoanBanDau));
                Command.Parameters.Add(new MDB.MDBParameter("ChanDoanTaiKham1", BenhAnUngThuKhongHacTo.ChanDoanTaiKham1));
                Command.Parameters.Add(new MDB.MDBParameter("ChanDoanTaiKham2", BenhAnUngThuKhongHacTo.ChanDoanTaiKham2));
                Command.Parameters.Add(new MDB.MDBParameter("ChanDoanTaiKham3", BenhAnUngThuKhongHacTo.ChanDoanTaiKham3));
                Command.Parameters.Add(new MDB.MDBParameter("ChanDoanTaiKham4", BenhAnUngThuKhongHacTo.ChanDoanTaiKham4));
                Command.Parameters.Add(new MDB.MDBParameter("BenhPhu", BenhAnUngThuKhongHacTo.BenhPhu));
                Command.Parameters.Add(new MDB.MDBParameter("KetQuaDieuTri", BenhAnUngThuKhongHacTo.KetQuaDieuTri));
                Command.Parameters.Add(new MDB.MDBParameter("BienChung_Text", BenhAnUngThuKhongHacTo.BienChung_Text));
                Command.Parameters.Add(new MDB.MDBParameter("GDPhongKeHoach", BenhAnUngThuKhongHacTo.GDPhongKeHoach));
                Command.Parameters.Add(new MDB.MDBParameter("GDPhongKhamBenh", BenhAnUngThuKhongHacTo.GDPhongKhamBenh));
                // hỏi bệnh, khám bệnh
                Command.Parameters.Add(new MDB.MDBParameter("HB_TGPhatBenh", BenhAnUngThuKhongHacTo.HB_TGPhatBenh));
                Command.Parameters.Add(new MDB.MDBParameter("HB_TrieuTrungDauTien", BenhAnUngThuKhongHacTo.HB_TrieuTrungDauTien));
                Command.Parameters.Add(new MDB.MDBParameter("XuatHienTrenVungDa", BenhAnUngThuKhongHacTo.XuatHienTrenVungDa));
                Command.Parameters.Add(new MDB.MDBParameter("HB_QuaTrinhBenhLy", BenhAnUngThuKhongHacTo.HB_QuaTrinhBenhLy));
                Command.Parameters.Add(new MDB.MDBParameter("DieuTriTruocDay", BenhAnUngThuKhongHacTo.DieuTriTruocDay));
                Command.Parameters.Add(new MDB.MDBParameter("HB_PhuongPhapDieuTri", BenhAnUngThuKhongHacTo.HB_PhuongPhapDieuTri));
                Command.Parameters.Add(new MDB.MDBParameter("HB_KetQuaDieuTri", BenhAnUngThuKhongHacTo.HB_KetQuaDieuTri));
                Command.Parameters.Add(new MDB.MDBParameter("TienSuBanThan", BenhAnUngThuKhongHacTo.TienSuBanThan));
                Command.Parameters.Add(new MDB.MDBParameter("TienSuBenhLyNoiNgoai", BenhAnUngThuKhongHacTo.TienSuBenhLyNoiNgoai));
                Command.Parameters.Add(new MDB.MDBParameter("TienSuBenhLyDaManTinh", BenhAnUngThuKhongHacTo.TienSuBenhLyDaManTinh));
                Command.Parameters.Add(new MDB.MDBParameter("HutThuocLa", BenhAnUngThuKhongHacTo.HutThuocLa));
                Command.Parameters.Add(new MDB.MDBParameter("HutThuocLa_SoBao", BenhAnUngThuKhongHacTo.HutThuocLa_SoBao));
                Command.Parameters.Add(new MDB.MDBParameter("AnTrau", BenhAnUngThuKhongHacTo.AnTrau));
                Command.Parameters.Add(new MDB.MDBParameter("AnTrau_SoNam", BenhAnUngThuKhongHacTo.AnTrau_SoNam));
                Command.Parameters.Add(new MDB.MDBParameter("UongRuou", BenhAnUngThuKhongHacTo.UongRuou));
                Command.Parameters.Add(new MDB.MDBParameter("UongRuou_Ml", BenhAnUngThuKhongHacTo.UongRuou_Ml));
                Command.Parameters.Add(new MDB.MDBParameter("ThoiQuenSinhHoat_Khac", BenhAnUngThuKhongHacTo.ThoiQuenSinhHoat_Khac));
                Command.Parameters.Add(new MDB.MDBParameter("TienSuTiepXucMatTroi", BenhAnUngThuKhongHacTo.TienSuTiepXucMatTroi));
                Command.Parameters.Add(new MDB.MDBParameter("TanSuat_TiepXucMatTroi", BenhAnUngThuKhongHacTo.TanSuat_TiepXucMatTroi));
                Command.Parameters.Add(new MDB.MDBParameter("ThoiGian_TiepXucMatTroi", BenhAnUngThuKhongHacTo.ThoiGian_TiepXucMatTroi));
                Command.Parameters.Add(new MDB.MDBParameter("ThoiDiem1016h", BenhAnUngThuKhongHacTo.ThoiDiem1016h));
                Command.Parameters.Add(new MDB.MDBParameter("ThoiDiem_Khac", BenhAnUngThuKhongHacTo.ThoiDiem_Khac));
                Command.Parameters.Add(new MDB.MDBParameter("BienPhapBaoVe", BenhAnUngThuKhongHacTo.BienPhapBaoVe));
                Command.Parameters.Add(new MDB.MDBParameter("QuanAo", BenhAnUngThuKhongHacTo.QuanAo));
                Command.Parameters.Add(new MDB.MDBParameter("KemChongNang", BenhAnUngThuKhongHacTo.KemChongNang));
                Command.Parameters.Add(new MDB.MDBParameter("PhuongPhapKhac", BenhAnUngThuKhongHacTo.PhuongPhapKhac));
                Command.Parameters.Add(new MDB.MDBParameter("LamInPhoTo", BenhAnUngThuKhongHacTo.LamInPhoTo));
                Command.Parameters.Add(new MDB.MDBParameter("TiepXucNhuaDuong", BenhAnUngThuKhongHacTo.TiepXucNhuaDuong));
                Command.Parameters.Add(new MDB.MDBParameter("SuDungBepThanToOng", BenhAnUngThuKhongHacTo.SuDungBepThanToOng));
                Command.Parameters.Add(new MDB.MDBParameter("BienPhapBaoVe_HacIn", BenhAnUngThuKhongHacTo.BienPhapBaoVe_HacIn));
                Command.Parameters.Add(new MDB.MDBParameter("DungThuocChuaArsen", BenhAnUngThuKhongHacTo.DungThuocChuaArsen));
                Command.Parameters.Add(new MDB.MDBParameter("DungNuocGiengKhoan", BenhAnUngThuKhongHacTo.DungNuocGiengKhoan));
                Command.Parameters.Add(new MDB.MDBParameter("DungTamLopFibroXiMang", BenhAnUngThuKhongHacTo.DungTamLopFibroXiMang));
                Command.Parameters.Add(new MDB.MDBParameter("TienSuTiepXucArsen_Khac", BenhAnUngThuKhongHacTo.TienSuTiepXucArsen_Khac));
                Command.Parameters.Add(new MDB.MDBParameter("TienSuTiepXucPhongXa", BenhAnUngThuKhongHacTo.TienSuTiepXucPhongXa));
                Command.Parameters.Add(new MDB.MDBParameter("TanSuat_TiepXucPhongXa", BenhAnUngThuKhongHacTo.TanSuat_TiepXucPhongXa));
                Command.Parameters.Add(new MDB.MDBParameter("ThoiGian_TiepXucPhongXa", BenhAnUngThuKhongHacTo.ThoiGian_TiepXucPhongXa));
                Command.Parameters.Add(new MDB.MDBParameter("MoiTruongONhiem", BenhAnUngThuKhongHacTo.MoiTruongONhiem));
                Command.Parameters.Add(new MDB.MDBParameter("ThuocDietNam", BenhAnUngThuKhongHacTo.ThuocDietNam));
                Command.Parameters.Add(new MDB.MDBParameter("HoaChatKhac", BenhAnUngThuKhongHacTo.HoaChatKhac));
                Command.Parameters.Add(new MDB.MDBParameter("ChatDietCo", BenhAnUngThuKhongHacTo.ChatDietCo));
                Command.Parameters.Add(new MDB.MDBParameter("ThuocTruSau", BenhAnUngThuKhongHacTo.ThuocTruSau));
                Command.Parameters.Add(new MDB.MDBParameter("ThoiGianTiepXuc", BenhAnUngThuKhongHacTo.ThoiGianTiepXuc));
                Command.Parameters.Add(new MDB.MDBParameter("DungThuocUCMD", BenhAnUngThuKhongHacTo.DungThuocUCMD));
                Command.Parameters.Add(new MDB.MDBParameter("GhepTang", BenhAnUngThuKhongHacTo.GhepTang));
                Command.Parameters.Add(new MDB.MDBParameter("GhepTang_CuThe", BenhAnUngThuKhongHacTo.GhepTang_CuThe));
                Command.Parameters.Add(new MDB.MDBParameter("NhiemHIVAIDS", BenhAnUngThuKhongHacTo.NhiemHIVAIDS));
                Command.Parameters.Add(new MDB.MDBParameter("SuyGiamMienDich_Khac", BenhAnUngThuKhongHacTo.SuyGiamMienDich_Khac));
                Command.Parameters.Add(new MDB.MDBParameter("CoNguoiBiUngThuDa", BenhAnUngThuKhongHacTo.CoNguoiBiUngThuDa));
                Command.Parameters.Add(new MDB.MDBParameter("LoaiUngThuDa", BenhAnUngThuKhongHacTo.LoaiUngThuDa));
                Command.Parameters.Add(new MDB.MDBParameter("CoNguoiBiUngThuKhac", BenhAnUngThuKhongHacTo.CoNguoiBiUngThuKhac));
                Command.Parameters.Add(new MDB.MDBParameter("LoaiUngThuKhac", BenhAnUngThuKhongHacTo.LoaiUngThuKhac));
                Command.Parameters.Add(new MDB.MDBParameter("TienSuGiaDinh_Khac", BenhAnUngThuKhongHacTo.TienSuGiaDinh_Khac));
                Command.Parameters.Add(new MDB.MDBParameter("ToanThan", BenhAnUngThuKhongHacTo.ToanThan));
                Command.Parameters.Add(new MDB.MDBParameter("CacBoPhan", BenhAnUngThuKhongHacTo.CacBoPhan));
                Command.Parameters.Add(new MDB.MDBParameter("TypDa", BenhAnUngThuKhongHacTo.TypDa));
                Command.Parameters.Add(new MDB.MDBParameter("ThuongTonCoBan", BenhAnUngThuKhongHacTo.ThuongTonCoBan));
                Command.Parameters.Add(new MDB.MDBParameter("TangSacTo_DongNhat", BenhAnUngThuKhongHacTo.TangSacTo_DongNhat));
                Command.Parameters.Add(new MDB.MDBParameter("TangSacTo_KhongDongNhat", BenhAnUngThuKhongHacTo.TangSacTo_KhongDongNhat));
                Command.Parameters.Add(new MDB.MDBParameter("TangSacTo_Khong", BenhAnUngThuKhongHacTo.TangSacTo_Khong));
                Command.Parameters.Add(new MDB.MDBParameter("BoThuongTon_Deu", BenhAnUngThuKhongHacTo.BoThuongTon_Deu));
                Command.Parameters.Add(new MDB.MDBParameter("BoThuongTon_KhongDeu", BenhAnUngThuKhongHacTo.BoThuongTon_KhongDeu));
                Command.Parameters.Add(new MDB.MDBParameter("BoThuongTon_NoiCao", BenhAnUngThuKhongHacTo.BoThuongTon_NoiCao));
                Command.Parameters.Add(new MDB.MDBParameter("BoThuongTon_BangPhang", BenhAnUngThuKhongHacTo.BoThuongTon_BangPhang));
                Command.Parameters.Add(new MDB.MDBParameter("BoThuongTon_CoHatNgoc", BenhAnUngThuKhongHacTo.BoThuongTon_CoHatNgoc));
                Command.Parameters.Add(new MDB.MDBParameter("DoiXung", BenhAnUngThuKhongHacTo.DoiXung));
                Command.Parameters.Add(new MDB.MDBParameter("TienTrienTrongThoiGian", BenhAnUngThuKhongHacTo.TienTrienTrongThoiGian));
                Command.Parameters.Add(new MDB.MDBParameter("GianMachQuanhThuongTon", BenhAnUngThuKhongHacTo.GianMachQuanhThuongTon));
                Command.Parameters.Add(new MDB.MDBParameter("KichThuoc", BenhAnUngThuKhongHacTo.KichThuoc));
                Command.Parameters.Add(new MDB.MDBParameter("SoLuong", BenhAnUngThuKhongHacTo.SoLuong));
                Command.Parameters.Add(new MDB.MDBParameter("BienDangCacCoQuan", BenhAnUngThuKhongHacTo.BienDangCacCoQuan));
                Command.Parameters.Add(new MDB.MDBParameter("TinhTrangBienDang", BenhAnUngThuKhongHacTo.TinhTrangBienDang));
                Command.Parameters.Add(new MDB.MDBParameter("Hach", BenhAnUngThuKhongHacTo.Hach));
                Command.Parameters.Add(new MDB.MDBParameter("ViTriSoLuongHach", BenhAnUngThuKhongHacTo.ViTriSoLuongHach));
                Command.Parameters.Add(new MDB.MDBParameter("BatThuongBoPhanKhac", BenhAnUngThuKhongHacTo.BatThuongBoPhanKhac));
                Command.Parameters.Add(new MDB.MDBParameter("TheU", BenhAnUngThuKhongHacTo.TheU));
                Command.Parameters.Add(new MDB.MDBParameter("TheNang", BenhAnUngThuKhongHacTo.TheNang));
                Command.Parameters.Add(new MDB.MDBParameter("TheXoHoa", BenhAnUngThuKhongHacTo.TheXoHoa));
                Command.Parameters.Add(new MDB.MDBParameter("TheNong", BenhAnUngThuKhongHacTo.TheNong));
                Command.Parameters.Add(new MDB.MDBParameter("UngThuBieuMo_Khac", BenhAnUngThuKhongHacTo.UngThuBieuMo_Khac));
                Command.Parameters.Add(new MDB.MDBParameter("SCCSui", BenhAnUngThuKhongHacTo.SCCSui));
                Command.Parameters.Add(new MDB.MDBParameter("SCCSinhDucHauMon", BenhAnUngThuKhongHacTo.SCCSinhDucHauMon));
                Command.Parameters.Add(new MDB.MDBParameter("LoetMarjolin", BenhAnUngThuKhongHacTo.LoetMarjolin));
                Command.Parameters.Add(new MDB.MDBParameter("SCCQuanhMong", BenhAnUngThuKhongHacTo.SCCQuanhMong));
                Command.Parameters.Add(new MDB.MDBParameter("SCCQuanhMieng", BenhAnUngThuKhongHacTo.SCCQuanhMieng));
                Command.Parameters.Add(new MDB.MDBParameter("Bowen", BenhAnUngThuKhongHacTo.Bowen));
                Command.Parameters.Add(new MDB.MDBParameter("Keratoacanthoma", BenhAnUngThuKhongHacTo.Keratoacanthoma));
                Command.Parameters.Add(new MDB.MDBParameter("UngThuBieuMoTeBao_Khac", BenhAnUngThuKhongHacTo.UngThuBieuMoTeBao_Khac));
                Command.Parameters.Add(new MDB.MDBParameter("TheUngThu", BenhAnUngThuKhongHacTo.TheUngThu));
                Command.Parameters.Add(new MDB.MDBParameter("TNM_T", BenhAnUngThuKhongHacTo.TNM_T));
                Command.Parameters.Add(new MDB.MDBParameter("TNM_N", BenhAnUngThuKhongHacTo.TNM_N));
                Command.Parameters.Add(new MDB.MDBParameter("TNM_M", BenhAnUngThuKhongHacTo.TNM_M));
                Command.Parameters.Add(new MDB.MDBParameter("PhanLoaiGiaiDoan_TNM", BenhAnUngThuKhongHacTo.PhanLoaiGiaiDoan_TNM));
                Command.Parameters.Add(new MDB.MDBParameter("CatRongCoDien", BenhAnUngThuKhongHacTo.CatRongCoDien));
                Command.Parameters.Add(new MDB.MDBParameter("CatBoThuongTon", BenhAnUngThuKhongHacTo.CatBoThuongTon));
                Command.Parameters.Add(new MDB.MDBParameter("Mosh", BenhAnUngThuKhongHacTo.Mosh));
                Command.Parameters.Add(new MDB.MDBParameter("SoLuongCatMosh", BenhAnUngThuKhongHacTo.SoLuongCatMosh));
                Command.Parameters.Add(new MDB.MDBParameter("TuLien", BenhAnUngThuKhongHacTo.TuLien));
                Command.Parameters.Add(new MDB.MDBParameter("DongTrucTiep", BenhAnUngThuKhongHacTo.DongTrucTiep));
                Command.Parameters.Add(new MDB.MDBParameter("VatTaiCho", BenhAnUngThuKhongHacTo.VatTaiCho));
                Command.Parameters.Add(new MDB.MDBParameter("VatXa", BenhAnUngThuKhongHacTo.VatXa));
                Command.Parameters.Add(new MDB.MDBParameter("VatViPhau", BenhAnUngThuKhongHacTo.VatViPhau));
                Command.Parameters.Add(new MDB.MDBParameter("GhepDa", BenhAnUngThuKhongHacTo.GhepDa));
                Command.Parameters.Add(new MDB.MDBParameter("TaoHinhKhuyetDa_Khac", BenhAnUngThuKhongHacTo.TaoHinhKhuyetDa_Khac));
                Command.Parameters.Add(new MDB.MDBParameter("NaoVetHach_ToanBo", BenhAnUngThuKhongHacTo.NaoVetHach_ToanBo));
                Command.Parameters.Add(new MDB.MDBParameter("NaoVetHach_HachGac", BenhAnUngThuKhongHacTo.NaoVetHach_HachGac));
                Command.Parameters.Add(new MDB.MDBParameter("TiaXaHoacHoaChat", BenhAnUngThuKhongHacTo.TiaXaHoacHoaChat));
                Command.Parameters.Add(new MDB.MDBParameter("DieuTri_PhuongPhapKhac", BenhAnUngThuKhongHacTo.DieuTri_PhuongPhapKhac));
                Command.Parameters.Add(new MDB.MDBParameter("PhauThuatLanh", BenhAnUngThuKhongHacTo.PhauThuatLanh));
                Command.Parameters.Add(new MDB.MDBParameter("HoaChatTaiCho", BenhAnUngThuKhongHacTo.HoaChatTaiCho));
                Command.Parameters.Add(new MDB.MDBParameter("TenThuoc", BenhAnUngThuKhongHacTo.TenThuoc));
                Command.Parameters.Add(new MDB.MDBParameter("PhaHuyBangNhiet", BenhAnUngThuKhongHacTo.PhaHuyBangNhiet));

                Command.Parameters.Add(new MDB.MDBParameter("TongKet_QuaTrinhBenhLy", BenhAnUngThuKhongHacTo.TongKet_QuaTrinhBenhLy));
                Command.Parameters.Add(new MDB.MDBParameter("TomTatKetQua", BenhAnUngThuKhongHacTo.TomTatKetQua));
                Command.Parameters.Add(new MDB.MDBParameter("BenhChinh", BenhAnUngThuKhongHacTo.BenhChinh));
                Command.Parameters.Add(new MDB.MDBParameter("MaBenhChinh", BenhAnUngThuKhongHacTo.MaBenhChinh));
                Command.Parameters.Add(new MDB.MDBParameter("BenhKemTheo", BenhAnUngThuKhongHacTo.BenhKemTheo));
                Command.Parameters.Add(new MDB.MDBParameter("MaBenhKemTheo", BenhAnUngThuKhongHacTo.MaBenhKemTheo));
                Command.Parameters.Add(new MDB.MDBParameter("PhuongPhapDieuTri", BenhAnUngThuKhongHacTo.PhuongPhapDieuTri));
                Command.Parameters.Add(new MDB.MDBParameter("TinhTrangRaVien", BenhAnUngThuKhongHacTo.TinhTrangRaVien));
                Command.Parameters.Add(new MDB.MDBParameter("HuongDieuTri", BenhAnUngThuKhongHacTo.HuongDieuTri));
                Command.Parameters.Add(new MDB.MDBParameter("NguoiNhanHoSo", BenhAnUngThuKhongHacTo.NguoiNhanHoSo));
                Command.Parameters.Add(new MDB.MDBParameter("NguoiGiaoHoSo", BenhAnUngThuKhongHacTo.NguoiGiaoHoSo));
                Command.Parameters.Add(new MDB.MDBParameter("NgayTongKet", BenhAnUngThuKhongHacTo.NgayTongKet));
                Command.Parameters.Add(new MDB.MDBParameter("TongKet_BacSyDieuTri", BenhAnUngThuKhongHacTo.TongKet_BacSyDieuTri));
                Command.Parameters.Add(new MDB.MDBParameter("TongKet_MaBacSyDieuTri", BenhAnUngThuKhongHacTo.TongKet_MaBacSyDieuTri));
                Command.Parameters.Add(new MDB.MDBParameter("TheoDoiDieuTris", JsonConvert.SerializeObject(BenhAnUngThuKhongHacTo.TheoDoiDieuTris)));
                Command.Parameters.Add(new MDB.MDBParameter("ThoiGianSongSauDieuTri", BenhAnUngThuKhongHacTo.ThoiGianSongSauDieuTri));
                Command.Parameters.Add(new MDB.MDBParameter("ChayMau", BenhAnUngThuKhongHacTo.ChayMau));
                Command.Parameters.Add(new MDB.MDBParameter("TuMau", BenhAnUngThuKhongHacTo.TuMau));
                Command.Parameters.Add(new MDB.MDBParameter("NhiemTrung", BenhAnUngThuKhongHacTo.NhiemTrung));
                Command.Parameters.Add(new MDB.MDBParameter("LauLienVetMo", BenhAnUngThuKhongHacTo.LauLienVetMo));
                Command.Parameters.Add(new MDB.MDBParameter("SeoXau", BenhAnUngThuKhongHacTo.SeoXau));
                Command.Parameters.Add(new MDB.MDBParameter("PhuBachMach", BenhAnUngThuKhongHacTo.PhuBachMach));
                Command.Parameters.Add(new MDB.MDBParameter("AnhHuongChucNang", BenhAnUngThuKhongHacTo.AnhHuongChucNang));
                Command.Parameters.Add(new MDB.MDBParameter("BienChungXa_Khac", BenhAnUngThuKhongHacTo.BienChungXa_Khac));

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
        public static bool Update(MDB.MDBConnection MyConnection, BenhAnUngThuKhongHacTo BenhAnUngThuKhongHacTo)
        {
            try
            {
                string sql = @"UPDATE BenhAnUngThuKhongHacTo SET 
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
                            HB_TGPhatBenh=:HB_TGPhatBenh,
                            HB_TrieuTrungDauTien=:HB_TrieuTrungDauTien,
                            XuatHienTrenVungDa=:XuatHienTrenVungDa,
                            HB_QuaTrinhBenhLy=:HB_QuaTrinhBenhLy,
                            DieuTriTruocDay=:DieuTriTruocDay,
                            HB_PhuongPhapDieuTri=:HB_PhuongPhapDieuTri,
                            HB_KetQuaDieuTri=:HB_KetQuaDieuTri,
                            TienSuBanThan=:TienSuBanThan,
                            TienSuBenhLyNoiNgoai=:TienSuBenhLyNoiNgoai,
                            TienSuBenhLyDaManTinh=:TienSuBenhLyDaManTinh,
                            HutThuocLa=:HutThuocLa,
                            HutThuocLa_SoBao=:HutThuocLa_SoBao,
                            AnTrau=:AnTrau,
                            AnTrau_SoNam=:AnTrau_SoNam,
                            UongRuou=:UongRuou,
                            UongRuou_Ml=:UongRuou_Ml,
                            ThoiQuenSinhHoat_Khac=:ThoiQuenSinhHoat_Khac,
                            TienSuTiepXucMatTroi=:TienSuTiepXucMatTroi,
                            TanSuat_TiepXucMatTroi=:TanSuat_TiepXucMatTroi,
                            ThoiGian_TiepXucMatTroi=:ThoiGian_TiepXucMatTroi,
                            ThoiDiem1016h=:ThoiDiem1016h,
                            ThoiDiem_Khac=:ThoiDiem_Khac,
                            BienPhapBaoVe=:BienPhapBaoVe,
                            QuanAo=:QuanAo,
                            KemChongNang=:KemChongNang,
                            PhuongPhapKhac=:PhuongPhapKhac,
                            LamInPhoTo=:LamInPhoTo,
                            TiepXucNhuaDuong=:TiepXucNhuaDuong,
                            SuDungBepThanToOng=:SuDungBepThanToOng,
                            BienPhapBaoVe_HacIn=:BienPhapBaoVe_HacIn,
                            DungThuocChuaArsen=:DungThuocChuaArsen,
                            DungNuocGiengKhoan=:DungNuocGiengKhoan,
                            DungTamLopFibroXiMang=:DungTamLopFibroXiMang,
                            TienSuTiepXucArsen_Khac=:TienSuTiepXucArsen_Khac,
                            TienSuTiepXucPhongXa=:TienSuTiepXucPhongXa,
                            TanSuat_TiepXucPhongXa=:TanSuat_TiepXucPhongXa,
                            ThoiGian_TiepXucPhongXa=:ThoiGian_TiepXucPhongXa,
                            MoiTruongONhiem=:MoiTruongONhiem,
                            ThuocDietNam=:ThuocDietNam,
                            HoaChatKhac=:HoaChatKhac,
                            ChatDietCo=:ChatDietCo,
                            ThuocTruSau=:ThuocTruSau,
                            ThoiGianTiepXuc=:ThoiGianTiepXuc,
                            DungThuocUCMD=:DungThuocUCMD,
                            GhepTang=:GhepTang,
                            GhepTang_CuThe=:GhepTang_CuThe,
                            NhiemHIVAIDS=:NhiemHIVAIDS,
                            SuyGiamMienDich_Khac=:SuyGiamMienDich_Khac,
                            CoNguoiBiUngThuDa=:CoNguoiBiUngThuDa,
                            LoaiUngThuDa=:LoaiUngThuDa,
                            CoNguoiBiUngThuKhac=:CoNguoiBiUngThuKhac,
                            LoaiUngThuKhac=:LoaiUngThuKhac,
                            TienSuGiaDinh_Khac=:TienSuGiaDinh_Khac,
                            ToanThan=:ToanThan,
                            CacBoPhan=:CacBoPhan,
                            TypDa=:TypDa,
                            ThuongTonCoBan=:ThuongTonCoBan,
                            TangSacTo_DongNhat=:TangSacTo_DongNhat,
                            TangSacTo_KhongDongNhat=:TangSacTo_KhongDongNhat,
                            TangSacTo_Khong=:TangSacTo_Khong,
                            BoThuongTon_Deu=:BoThuongTon_Deu,
                            BoThuongTon_KhongDeu=:BoThuongTon_KhongDeu,
                            BoThuongTon_NoiCao=:BoThuongTon_NoiCao,
                            BoThuongTon_BangPhang=:BoThuongTon_BangPhang,
                            BoThuongTon_CoHatNgoc=:BoThuongTon_CoHatNgoc,
                            DoiXung=:DoiXung,
                            TienTrienTrongThoiGian=:TienTrienTrongThoiGian,
                            GianMachQuanhThuongTon=:GianMachQuanhThuongTon,
                            KichThuoc=:KichThuoc,
                            SoLuong=:SoLuong,
                            BienDangCacCoQuan=:BienDangCacCoQuan,
                            TinhTrangBienDang=:TinhTrangBienDang,
                            Hach=:Hach,
                            ViTriSoLuongHach=:ViTriSoLuongHach,
                            BatThuongBoPhanKhac=:BatThuongBoPhanKhac,
                            TheU=:TheU,
                            TheNang=:TheNang,
                            TheXoHoa=:TheXoHoa,
                            TheNong=:TheNong,
                            UngThuBieuMo_Khac=:UngThuBieuMo_Khac,
                            SCCSui=:SCCSui,
                            SCCSinhDucHauMon=:SCCSinhDucHauMon,
                            LoetMarjolin=:LoetMarjolin,
                            SCCQuanhMong=:SCCQuanhMong,
                            SCCQuanhMieng=:SCCQuanhMieng,
                            Bowen=:Bowen,
                            Keratoacanthoma=:Keratoacanthoma,
                            UngThuBieuMoTeBao_Khac=:UngThuBieuMoTeBao_Khac,
                            TheUngThu=:TheUngThu,
                            TNM_T=:TNM_T,
                            TNM_N=:TNM_N,
                            TNM_M=:TNM_M,
                            PhanLoaiGiaiDoan_TNM=:PhanLoaiGiaiDoan_TNM,
                            CatRongCoDien=:CatRongCoDien,
                            CatBoThuongTon=:CatBoThuongTon,
                            Mosh=:Mosh,
                            SoLuongCatMosh=:SoLuongCatMosh,
                            TuLien=:TuLien,
                            DongTrucTiep=:DongTrucTiep,
                            VatTaiCho=:VatTaiCho,
                            VatXa=:VatXa,
                            VatViPhau=:VatViPhau,
                            GhepDa=:GhepDa,
                            TaoHinhKhuyetDa_Khac=:TaoHinhKhuyetDa_Khac,
                            NaoVetHach_ToanBo=:NaoVetHach_ToanBo,
                            NaoVetHach_HachGac=:NaoVetHach_HachGac,
                            TiaXaHoacHoaChat=:TiaXaHoacHoaChat,
                            DieuTri_PhuongPhapKhac=:DieuTri_PhuongPhapKhac,
                            PhauThuatLanh=:PhauThuatLanh,
                            HoaChatTaiCho=:HoaChatTaiCho,
                            TenThuoc=:TenThuoc,
                            PhaHuyBangNhiet=:PhaHuyBangNhiet,
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
                            TongKet_MaBacSyDieuTri=:TongKet_MaBacSyDieuTri,
                            TheoDoiDieuTris=:TheoDoiDieuTris,
                            ThoiGianSongSauDieuTri=:ThoiGianSongSauDieuTri,
                            ChayMau=:ChayMau,
                            TuMau=:TuMau,
                            NhiemTrung=:NhiemTrung,
                            LauLienVetMo=:LauLienVetMo,
                            SeoXau=:SeoXau,
                            PhuBachMach=:PhuBachMach,
                            AnhHuongChucNang=:AnhHuongChucNang,
                            BienChungXa_Khac=:BienChungXa_Khac
                            WHERE MaQuanLy = :MaQuanLy";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
                Command.Parameters.Add(new MDB.MDBParameter("DieuTriNgoaiTruTu", BenhAnUngThuKhongHacTo.DieuTriNgoaiTruTu));
                Command.Parameters.Add(new MDB.MDBParameter("DieuTriNgoaiTruDen", BenhAnUngThuKhongHacTo.DieuTriNgoaiTruDen));
                Command.Parameters.Add(new MDB.MDBParameter("SoCMND", BenhAnUngThuKhongHacTo.SoCMND));
                Command.Parameters.Add(new MDB.MDBParameter("BaoHiem", BenhAnUngThuKhongHacTo.BaoHiem));
                Command.Parameters.Add(new MDB.MDBParameter("ChanDoan_TuyenTruoc", BenhAnUngThuKhongHacTo.ChanDoan_TuyenTruoc));
                Command.Parameters.Add(new MDB.MDBParameter("ChanDoanBanDau", BenhAnUngThuKhongHacTo.ChanDoanBanDau));
                Command.Parameters.Add(new MDB.MDBParameter("ChanDoanTaiKham1", BenhAnUngThuKhongHacTo.ChanDoanTaiKham1));
                Command.Parameters.Add(new MDB.MDBParameter("ChanDoanTaiKham2", BenhAnUngThuKhongHacTo.ChanDoanTaiKham2));
                Command.Parameters.Add(new MDB.MDBParameter("ChanDoanTaiKham3", BenhAnUngThuKhongHacTo.ChanDoanTaiKham3));
                Command.Parameters.Add(new MDB.MDBParameter("ChanDoanTaiKham4", BenhAnUngThuKhongHacTo.ChanDoanTaiKham4));
                Command.Parameters.Add(new MDB.MDBParameter("BenhPhu", BenhAnUngThuKhongHacTo.BenhPhu));
                Command.Parameters.Add(new MDB.MDBParameter("KetQuaDieuTri", BenhAnUngThuKhongHacTo.KetQuaDieuTri));
                Command.Parameters.Add(new MDB.MDBParameter("BienChung_Text", BenhAnUngThuKhongHacTo.BienChung_Text));
                Command.Parameters.Add(new MDB.MDBParameter("GDPhongKeHoach", BenhAnUngThuKhongHacTo.GDPhongKeHoach));
                Command.Parameters.Add(new MDB.MDBParameter("GDPhongKhamBenh", BenhAnUngThuKhongHacTo.GDPhongKhamBenh));
                // hỏi bệnh, khám bệnh
                Command.Parameters.Add(new MDB.MDBParameter("HB_TGPhatBenh", BenhAnUngThuKhongHacTo.HB_TGPhatBenh));
                Command.Parameters.Add(new MDB.MDBParameter("HB_TrieuTrungDauTien", BenhAnUngThuKhongHacTo.HB_TrieuTrungDauTien));
                Command.Parameters.Add(new MDB.MDBParameter("XuatHienTrenVungDa", BenhAnUngThuKhongHacTo.XuatHienTrenVungDa));
                Command.Parameters.Add(new MDB.MDBParameter("HB_QuaTrinhBenhLy", BenhAnUngThuKhongHacTo.HB_QuaTrinhBenhLy));
                Command.Parameters.Add(new MDB.MDBParameter("DieuTriTruocDay", BenhAnUngThuKhongHacTo.DieuTriTruocDay));
                Command.Parameters.Add(new MDB.MDBParameter("HB_PhuongPhapDieuTri", BenhAnUngThuKhongHacTo.HB_PhuongPhapDieuTri));
                Command.Parameters.Add(new MDB.MDBParameter("HB_KetQuaDieuTri", BenhAnUngThuKhongHacTo.HB_KetQuaDieuTri));
                Command.Parameters.Add(new MDB.MDBParameter("TienSuBanThan", BenhAnUngThuKhongHacTo.TienSuBanThan));
                Command.Parameters.Add(new MDB.MDBParameter("TienSuBenhLyNoiNgoai", BenhAnUngThuKhongHacTo.TienSuBenhLyNoiNgoai));
                Command.Parameters.Add(new MDB.MDBParameter("TienSuBenhLyDaManTinh", BenhAnUngThuKhongHacTo.TienSuBenhLyDaManTinh));
                Command.Parameters.Add(new MDB.MDBParameter("HutThuocLa", BenhAnUngThuKhongHacTo.HutThuocLa));
                Command.Parameters.Add(new MDB.MDBParameter("HutThuocLa_SoBao", BenhAnUngThuKhongHacTo.HutThuocLa_SoBao));
                Command.Parameters.Add(new MDB.MDBParameter("AnTrau", BenhAnUngThuKhongHacTo.AnTrau));
                Command.Parameters.Add(new MDB.MDBParameter("AnTrau_SoNam", BenhAnUngThuKhongHacTo.AnTrau_SoNam));
                Command.Parameters.Add(new MDB.MDBParameter("UongRuou", BenhAnUngThuKhongHacTo.UongRuou));
                Command.Parameters.Add(new MDB.MDBParameter("UongRuou_Ml", BenhAnUngThuKhongHacTo.UongRuou_Ml));
                Command.Parameters.Add(new MDB.MDBParameter("ThoiQuenSinhHoat_Khac", BenhAnUngThuKhongHacTo.ThoiQuenSinhHoat_Khac));
                Command.Parameters.Add(new MDB.MDBParameter("TienSuTiepXucMatTroi", BenhAnUngThuKhongHacTo.TienSuTiepXucMatTroi));
                Command.Parameters.Add(new MDB.MDBParameter("TanSuat_TiepXucMatTroi", BenhAnUngThuKhongHacTo.TanSuat_TiepXucMatTroi));
                Command.Parameters.Add(new MDB.MDBParameter("ThoiGian_TiepXucMatTroi", BenhAnUngThuKhongHacTo.ThoiGian_TiepXucMatTroi));
                Command.Parameters.Add(new MDB.MDBParameter("ThoiDiem1016h", BenhAnUngThuKhongHacTo.ThoiDiem1016h));
                Command.Parameters.Add(new MDB.MDBParameter("ThoiDiem_Khac", BenhAnUngThuKhongHacTo.ThoiDiem_Khac));
                Command.Parameters.Add(new MDB.MDBParameter("BienPhapBaoVe", BenhAnUngThuKhongHacTo.BienPhapBaoVe));
                Command.Parameters.Add(new MDB.MDBParameter("QuanAo", BenhAnUngThuKhongHacTo.QuanAo));
                Command.Parameters.Add(new MDB.MDBParameter("KemChongNang", BenhAnUngThuKhongHacTo.KemChongNang));
                Command.Parameters.Add(new MDB.MDBParameter("PhuongPhapKhac", BenhAnUngThuKhongHacTo.PhuongPhapKhac));
                Command.Parameters.Add(new MDB.MDBParameter("LamInPhoTo", BenhAnUngThuKhongHacTo.LamInPhoTo));
                Command.Parameters.Add(new MDB.MDBParameter("TiepXucNhuaDuong", BenhAnUngThuKhongHacTo.TiepXucNhuaDuong));
                Command.Parameters.Add(new MDB.MDBParameter("SuDungBepThanToOng", BenhAnUngThuKhongHacTo.SuDungBepThanToOng));
                Command.Parameters.Add(new MDB.MDBParameter("BienPhapBaoVe_HacIn", BenhAnUngThuKhongHacTo.BienPhapBaoVe_HacIn));
                Command.Parameters.Add(new MDB.MDBParameter("DungThuocChuaArsen", BenhAnUngThuKhongHacTo.DungThuocChuaArsen));
                Command.Parameters.Add(new MDB.MDBParameter("DungNuocGiengKhoan", BenhAnUngThuKhongHacTo.DungNuocGiengKhoan));
                Command.Parameters.Add(new MDB.MDBParameter("DungTamLopFibroXiMang", BenhAnUngThuKhongHacTo.DungTamLopFibroXiMang));
                Command.Parameters.Add(new MDB.MDBParameter("TienSuTiepXucArsen_Khac", BenhAnUngThuKhongHacTo.TienSuTiepXucArsen_Khac));
                Command.Parameters.Add(new MDB.MDBParameter("TienSuTiepXucPhongXa", BenhAnUngThuKhongHacTo.TienSuTiepXucPhongXa));
                Command.Parameters.Add(new MDB.MDBParameter("TanSuat_TiepXucPhongXa", BenhAnUngThuKhongHacTo.TanSuat_TiepXucPhongXa));
                Command.Parameters.Add(new MDB.MDBParameter("ThoiGian_TiepXucPhongXa", BenhAnUngThuKhongHacTo.ThoiGian_TiepXucPhongXa));
                Command.Parameters.Add(new MDB.MDBParameter("MoiTruongONhiem", BenhAnUngThuKhongHacTo.MoiTruongONhiem));
                Command.Parameters.Add(new MDB.MDBParameter("ThuocDietNam", BenhAnUngThuKhongHacTo.ThuocDietNam));
                Command.Parameters.Add(new MDB.MDBParameter("HoaChatKhac", BenhAnUngThuKhongHacTo.HoaChatKhac));
                Command.Parameters.Add(new MDB.MDBParameter("ChatDietCo", BenhAnUngThuKhongHacTo.ChatDietCo));
                Command.Parameters.Add(new MDB.MDBParameter("ThuocTruSau", BenhAnUngThuKhongHacTo.ThuocTruSau));
                Command.Parameters.Add(new MDB.MDBParameter("ThoiGianTiepXuc", BenhAnUngThuKhongHacTo.ThoiGianTiepXuc));
                Command.Parameters.Add(new MDB.MDBParameter("DungThuocUCMD", BenhAnUngThuKhongHacTo.DungThuocUCMD));
                Command.Parameters.Add(new MDB.MDBParameter("GhepTang", BenhAnUngThuKhongHacTo.GhepTang));
                Command.Parameters.Add(new MDB.MDBParameter("GhepTang_CuThe", BenhAnUngThuKhongHacTo.GhepTang_CuThe));
                Command.Parameters.Add(new MDB.MDBParameter("NhiemHIVAIDS", BenhAnUngThuKhongHacTo.NhiemHIVAIDS));
                Command.Parameters.Add(new MDB.MDBParameter("SuyGiamMienDich_Khac", BenhAnUngThuKhongHacTo.SuyGiamMienDich_Khac));
                Command.Parameters.Add(new MDB.MDBParameter("CoNguoiBiUngThuDa", BenhAnUngThuKhongHacTo.CoNguoiBiUngThuDa));
                Command.Parameters.Add(new MDB.MDBParameter("LoaiUngThuDa", BenhAnUngThuKhongHacTo.LoaiUngThuDa));
                Command.Parameters.Add(new MDB.MDBParameter("CoNguoiBiUngThuKhac", BenhAnUngThuKhongHacTo.CoNguoiBiUngThuKhac));
                Command.Parameters.Add(new MDB.MDBParameter("LoaiUngThuKhac", BenhAnUngThuKhongHacTo.LoaiUngThuKhac));
                Command.Parameters.Add(new MDB.MDBParameter("TienSuGiaDinh_Khac", BenhAnUngThuKhongHacTo.TienSuGiaDinh_Khac));
                Command.Parameters.Add(new MDB.MDBParameter("ToanThan", BenhAnUngThuKhongHacTo.ToanThan));
                Command.Parameters.Add(new MDB.MDBParameter("CacBoPhan", BenhAnUngThuKhongHacTo.CacBoPhan));
                Command.Parameters.Add(new MDB.MDBParameter("TypDa", BenhAnUngThuKhongHacTo.TypDa));
                Command.Parameters.Add(new MDB.MDBParameter("ThuongTonCoBan", BenhAnUngThuKhongHacTo.ThuongTonCoBan));
                Command.Parameters.Add(new MDB.MDBParameter("TangSacTo_DongNhat", BenhAnUngThuKhongHacTo.TangSacTo_DongNhat));
                Command.Parameters.Add(new MDB.MDBParameter("TangSacTo_KhongDongNhat", BenhAnUngThuKhongHacTo.TangSacTo_KhongDongNhat));
                Command.Parameters.Add(new MDB.MDBParameter("TangSacTo_Khong", BenhAnUngThuKhongHacTo.TangSacTo_Khong));
                Command.Parameters.Add(new MDB.MDBParameter("BoThuongTon_Deu", BenhAnUngThuKhongHacTo.BoThuongTon_Deu));
                Command.Parameters.Add(new MDB.MDBParameter("BoThuongTon_KhongDeu", BenhAnUngThuKhongHacTo.BoThuongTon_KhongDeu));
                Command.Parameters.Add(new MDB.MDBParameter("BoThuongTon_NoiCao", BenhAnUngThuKhongHacTo.BoThuongTon_NoiCao));
                Command.Parameters.Add(new MDB.MDBParameter("BoThuongTon_BangPhang", BenhAnUngThuKhongHacTo.BoThuongTon_BangPhang));
                Command.Parameters.Add(new MDB.MDBParameter("BoThuongTon_CoHatNgoc", BenhAnUngThuKhongHacTo.BoThuongTon_CoHatNgoc));
                Command.Parameters.Add(new MDB.MDBParameter("DoiXung", BenhAnUngThuKhongHacTo.DoiXung));
                Command.Parameters.Add(new MDB.MDBParameter("TienTrienTrongThoiGian", BenhAnUngThuKhongHacTo.TienTrienTrongThoiGian));
                Command.Parameters.Add(new MDB.MDBParameter("GianMachQuanhThuongTon", BenhAnUngThuKhongHacTo.GianMachQuanhThuongTon));
                Command.Parameters.Add(new MDB.MDBParameter("KichThuoc", BenhAnUngThuKhongHacTo.KichThuoc));
                Command.Parameters.Add(new MDB.MDBParameter("SoLuong", BenhAnUngThuKhongHacTo.SoLuong));
                Command.Parameters.Add(new MDB.MDBParameter("BienDangCacCoQuan", BenhAnUngThuKhongHacTo.BienDangCacCoQuan));
                Command.Parameters.Add(new MDB.MDBParameter("TinhTrangBienDang", BenhAnUngThuKhongHacTo.TinhTrangBienDang));
                Command.Parameters.Add(new MDB.MDBParameter("Hach", BenhAnUngThuKhongHacTo.Hach));
                Command.Parameters.Add(new MDB.MDBParameter("ViTriSoLuongHach", BenhAnUngThuKhongHacTo.ViTriSoLuongHach));
                Command.Parameters.Add(new MDB.MDBParameter("BatThuongBoPhanKhac", BenhAnUngThuKhongHacTo.BatThuongBoPhanKhac));
                Command.Parameters.Add(new MDB.MDBParameter("TheU", BenhAnUngThuKhongHacTo.TheU));
                Command.Parameters.Add(new MDB.MDBParameter("TheNang", BenhAnUngThuKhongHacTo.TheNang));
                Command.Parameters.Add(new MDB.MDBParameter("TheXoHoa", BenhAnUngThuKhongHacTo.TheXoHoa));
                Command.Parameters.Add(new MDB.MDBParameter("TheNong", BenhAnUngThuKhongHacTo.TheNong));
                Command.Parameters.Add(new MDB.MDBParameter("UngThuBieuMo_Khac", BenhAnUngThuKhongHacTo.UngThuBieuMo_Khac));
                Command.Parameters.Add(new MDB.MDBParameter("SCCSui", BenhAnUngThuKhongHacTo.SCCSui));
                Command.Parameters.Add(new MDB.MDBParameter("SCCSinhDucHauMon", BenhAnUngThuKhongHacTo.SCCSinhDucHauMon));
                Command.Parameters.Add(new MDB.MDBParameter("LoetMarjolin", BenhAnUngThuKhongHacTo.LoetMarjolin));
                Command.Parameters.Add(new MDB.MDBParameter("SCCQuanhMong", BenhAnUngThuKhongHacTo.SCCQuanhMong));
                Command.Parameters.Add(new MDB.MDBParameter("SCCQuanhMieng", BenhAnUngThuKhongHacTo.SCCQuanhMieng));
                Command.Parameters.Add(new MDB.MDBParameter("Bowen", BenhAnUngThuKhongHacTo.Bowen));
                Command.Parameters.Add(new MDB.MDBParameter("Keratoacanthoma", BenhAnUngThuKhongHacTo.Keratoacanthoma));
                Command.Parameters.Add(new MDB.MDBParameter("UngThuBieuMoTeBao_Khac", BenhAnUngThuKhongHacTo.UngThuBieuMoTeBao_Khac));
                Command.Parameters.Add(new MDB.MDBParameter("TheUngThu", BenhAnUngThuKhongHacTo.TheUngThu));
                Command.Parameters.Add(new MDB.MDBParameter("TNM_T", BenhAnUngThuKhongHacTo.TNM_T));
                Command.Parameters.Add(new MDB.MDBParameter("TNM_N", BenhAnUngThuKhongHacTo.TNM_N));
                Command.Parameters.Add(new MDB.MDBParameter("TNM_M", BenhAnUngThuKhongHacTo.TNM_M));
                Command.Parameters.Add(new MDB.MDBParameter("PhanLoaiGiaiDoan_TNM", BenhAnUngThuKhongHacTo.PhanLoaiGiaiDoan_TNM));
                Command.Parameters.Add(new MDB.MDBParameter("CatRongCoDien", BenhAnUngThuKhongHacTo.CatRongCoDien));
                Command.Parameters.Add(new MDB.MDBParameter("CatBoThuongTon", BenhAnUngThuKhongHacTo.CatBoThuongTon));
                Command.Parameters.Add(new MDB.MDBParameter("Mosh", BenhAnUngThuKhongHacTo.Mosh));
                Command.Parameters.Add(new MDB.MDBParameter("SoLuongCatMosh", BenhAnUngThuKhongHacTo.SoLuongCatMosh));
                Command.Parameters.Add(new MDB.MDBParameter("TuLien", BenhAnUngThuKhongHacTo.TuLien));
                Command.Parameters.Add(new MDB.MDBParameter("DongTrucTiep", BenhAnUngThuKhongHacTo.DongTrucTiep));
                Command.Parameters.Add(new MDB.MDBParameter("VatTaiCho", BenhAnUngThuKhongHacTo.VatTaiCho));
                Command.Parameters.Add(new MDB.MDBParameter("VatXa", BenhAnUngThuKhongHacTo.VatXa));
                Command.Parameters.Add(new MDB.MDBParameter("VatViPhau", BenhAnUngThuKhongHacTo.VatViPhau));
                Command.Parameters.Add(new MDB.MDBParameter("GhepDa", BenhAnUngThuKhongHacTo.GhepDa));
                Command.Parameters.Add(new MDB.MDBParameter("TaoHinhKhuyetDa_Khac", BenhAnUngThuKhongHacTo.TaoHinhKhuyetDa_Khac));
                Command.Parameters.Add(new MDB.MDBParameter("NaoVetHach_ToanBo", BenhAnUngThuKhongHacTo.NaoVetHach_ToanBo));
                Command.Parameters.Add(new MDB.MDBParameter("NaoVetHach_HachGac", BenhAnUngThuKhongHacTo.NaoVetHach_HachGac));
                Command.Parameters.Add(new MDB.MDBParameter("TiaXaHoacHoaChat", BenhAnUngThuKhongHacTo.TiaXaHoacHoaChat));
                Command.Parameters.Add(new MDB.MDBParameter("DieuTri_PhuongPhapKhac", BenhAnUngThuKhongHacTo.DieuTri_PhuongPhapKhac));
                Command.Parameters.Add(new MDB.MDBParameter("PhauThuatLanh", BenhAnUngThuKhongHacTo.PhauThuatLanh));
                Command.Parameters.Add(new MDB.MDBParameter("HoaChatTaiCho", BenhAnUngThuKhongHacTo.HoaChatTaiCho));
                Command.Parameters.Add(new MDB.MDBParameter("TenThuoc", BenhAnUngThuKhongHacTo.TenThuoc));
                Command.Parameters.Add(new MDB.MDBParameter("PhaHuyBangNhiet", BenhAnUngThuKhongHacTo.PhaHuyBangNhiet));

                Command.Parameters.Add(new MDB.MDBParameter("TongKet_QuaTrinhBenhLy", BenhAnUngThuKhongHacTo.TongKet_QuaTrinhBenhLy));
                Command.Parameters.Add(new MDB.MDBParameter("TomTatKetQua", BenhAnUngThuKhongHacTo.TomTatKetQua));
                Command.Parameters.Add(new MDB.MDBParameter("BenhChinh", BenhAnUngThuKhongHacTo.BenhChinh));
                Command.Parameters.Add(new MDB.MDBParameter("MaBenhChinh", BenhAnUngThuKhongHacTo.MaBenhChinh));
                Command.Parameters.Add(new MDB.MDBParameter("BenhKemTheo", BenhAnUngThuKhongHacTo.BenhKemTheo));
                Command.Parameters.Add(new MDB.MDBParameter("MaBenhKemTheo", BenhAnUngThuKhongHacTo.MaBenhKemTheo));
                Command.Parameters.Add(new MDB.MDBParameter("PhuongPhapDieuTri", BenhAnUngThuKhongHacTo.PhuongPhapDieuTri));
                Command.Parameters.Add(new MDB.MDBParameter("TinhTrangRaVien", BenhAnUngThuKhongHacTo.TinhTrangRaVien));
                Command.Parameters.Add(new MDB.MDBParameter("HuongDieuTri", BenhAnUngThuKhongHacTo.HuongDieuTri));
                Command.Parameters.Add(new MDB.MDBParameter("NguoiNhanHoSo", BenhAnUngThuKhongHacTo.NguoiNhanHoSo));
                Command.Parameters.Add(new MDB.MDBParameter("NguoiGiaoHoSo", BenhAnUngThuKhongHacTo.NguoiGiaoHoSo));
                Command.Parameters.Add(new MDB.MDBParameter("NgayTongKet", BenhAnUngThuKhongHacTo.NgayTongKet));
                Command.Parameters.Add(new MDB.MDBParameter("TongKet_BacSyDieuTri", BenhAnUngThuKhongHacTo.TongKet_BacSyDieuTri));
                Command.Parameters.Add(new MDB.MDBParameter("TongKet_MaBacSyDieuTri", BenhAnUngThuKhongHacTo.TongKet_MaBacSyDieuTri));
                Command.Parameters.Add(new MDB.MDBParameter("TheoDoiDieuTris", JsonConvert.SerializeObject(BenhAnUngThuKhongHacTo.TheoDoiDieuTris)));
                Command.Parameters.Add(new MDB.MDBParameter("ThoiGianSongSauDieuTri", BenhAnUngThuKhongHacTo.ThoiGianSongSauDieuTri));
                Command.Parameters.Add(new MDB.MDBParameter("ChayMau", BenhAnUngThuKhongHacTo.ChayMau));
                Command.Parameters.Add(new MDB.MDBParameter("TuMau", BenhAnUngThuKhongHacTo.TuMau));
                Command.Parameters.Add(new MDB.MDBParameter("NhiemTrung", BenhAnUngThuKhongHacTo.NhiemTrung));
                Command.Parameters.Add(new MDB.MDBParameter("LauLienVetMo", BenhAnUngThuKhongHacTo.LauLienVetMo));
                Command.Parameters.Add(new MDB.MDBParameter("SeoXau", BenhAnUngThuKhongHacTo.SeoXau));
                Command.Parameters.Add(new MDB.MDBParameter("PhuBachMach", BenhAnUngThuKhongHacTo.PhuBachMach));
                Command.Parameters.Add(new MDB.MDBParameter("AnhHuongChucNang", BenhAnUngThuKhongHacTo.AnhHuongChucNang));
                Command.Parameters.Add(new MDB.MDBParameter("BienChungXa_Khac", BenhAnUngThuKhongHacTo.BienChungXa_Khac));


                Command.BindByName = true;

                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", BenhAnUngThuKhongHacTo.MaQuanLy));
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
