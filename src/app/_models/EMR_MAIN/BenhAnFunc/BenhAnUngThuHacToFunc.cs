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
using System.Windows;
using System.Windows.Media.Imaging;

namespace EMR_MAIN.DATABASE.BenhAnFunc
{
    public class BenhAnUngThuHacToFunc
    {
        public static void WriteXml(MDB.MDBConnection MyConnection)
        {
            string sql =
                   @"
                  select  a.*,  CTScanner HoSo_CTScanner, SieuAm HoSo_SieuAm, XetNghiem HoSo_XetNghiem,  Khac HoSo_Khac,  Khac_Text HoSo_Khac_Text,  ToanBoHoSo HoSo_ToanBoHoSo, Mach DauSinhTon_Mach,  NhietDo DauSinhTon_NhietDo,  HuyetAp DauSinhTon_HuyetAp,  NhipTho DauSinhTon_NhipTho,  CanNang DauSinhTon_CanNang  
                  from BenhAnUngThuHacTo a inner join thongtindieutri b on a.maquanly = b.maquanly
                  where rownum = 1
                    ";
            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
            MDB.MDBDataReader DataReader = Command.ExecuteReader();

            var DataTable = new DataTable { TableName = "BenhAnUngThuHacTo" };
            DataTable.Load(DataReader as IDataReader);
            DataTable.WriteXml("rptBenhAnUngThuHacTo.xml");
        }
        public static DataSet SelectDataSet(MDB.MDBConnection MyConnection, decimal MaQuanLy)
        {
            string sql =
                   @"
                  select  a.*, g.hovaten TK_BacSyDieuTriHoVaTen, d.hovaten NguoiGiaoHoSoHoVaTen,e.hovaten NguoiNhanHoSoHoVaTen, b.XQuang HoSo_XQuang, b.CTScanner HoSo_CTScanner, b.SieuAm HoSo_SieuAm, b.XetNghiem HoSo_XetNghiem,  b.Khac HoSo_Khac,  b.Khac_Text HoSo_Khac_Text,  b.ToanBoHoSo HoSo_ToanBoHoSo, b.Mach DauSinhTon_Mach, b.NhietDo DauSinhTon_NhietDo,  b.HuyetAp DauSinhTon_HuyetAp,  b.NhipTho DauSinhTon_NhipTho,  b.CanNang DauSinhTon_CanNang  , b.ChieuCao DauSinhTon_ChieuCao, b.BMI DauSinhTon_BMI, b.NgayRaVien 
                        from BenhAnUngThuHacTo a  
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
        public static BenhAnUngThuHacTo Select(MDB.MDBConnection MyConnection, decimal MaQuanLy)
        {
            var obj = new BenhAnUngThuHacTo();
            try
            {
                #region
                string sql =
                          @"select * 
                        from BenhAnUngThuHacTo 
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
                    obj.ViemMoiAnhNang = DataReader.GetInt("ViemMoiAnhNang");
                    obj.ViemDaAnhNang = DataReader.GetInt("ViemDaAnhNang");
                    obj.ViemDaTiaXa = DataReader.GetInt("ViemDaTiaXa");
                    obj.DaySungAnhNang = DataReader.GetInt("DaySungAnhNang");
                    obj.LupusBanDoHeThong = DataReader.GetInt("LupusBanDoHeThong");
                    obj.LichenPhang = DataReader.GetInt("LichenPhang");
                    obj.SeoBong = DataReader.GetInt("SeoBong");
                    obj.LoetManTinh = DataReader.GetInt("LoetManTinh");
                    obj.NotRuoiKhongDienHinh = DataReader.GetInt("NotRuoiKhongDienHinh");
                    obj.BotKhongDienHinh = DataReader.GetInt("BotKhongDienHinh");
                    obj.BotSacToBamSinh = DataReader.GetInt("BotSacToBamSinh");
                    obj.BachTang = DataReader.GetInt("BachTang");
                    obj.BachBien = DataReader.GetInt("BachBien");
                    obj.KhoDaSacTo = DataReader.GetInt("KhoDaSacTo");
                    obj.LoanSanThuongBi = DataReader.GetInt("LoanSanThuongBi");
                    obj.HoiChungGorlin = DataReader.GetInt("HoiChungGorlin");
                    obj.HoiChungBazex = DataReader.GetInt("HoiChungBazex");
                    obj.BachSan = DataReader.GetInt("BachSan");
                    obj.TonThuongTienUngThu_Khac = DataReader["TonThuongTienUngThu_Khac"].ToString();
                    obj.HoatDongDuoiAnhNang = DataReader.GetInt("HoatDongDuoiAnhNang");
                    obj.TanSuat = DataReader["TanSuat"].ToString();
                    obj.ThoiGian = DataReader["ThoiGian"].ToString();
                    obj.ThoiDiem1016h = DataReader.GetInt("ThoiDiem1016h");
                    obj.ThoiDiem_Khac = DataReader["ThoiDiem_Khac"].ToString();
                    obj.BienPhapBaoVe = DataReader.GetInt("BienPhapBaoVe");
                    obj.QuanAo = DataReader.GetInt("QuanAo");
                    obj.KemChongNang = DataReader.GetInt("KemChongNang");
                    obj.PhuongPhapKhac = DataReader.GetInt("PhuongPhapKhac");
                    obj.DungThuocUCMD = DataReader.GetInt("DungThuocUCMD");
                    obj.GhepTangCuThe = DataReader.GetInt("GhepTangCuThe");
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
                    obj.DoiXung = DataReader.GetInt("DoiXung");
                    obj.Bo = DataReader.GetInt("Bo");
                    obj.MauSac = DataReader.GetInt("MauSac");
                    obj.DuongKinh = DataReader.GetInt("DuongKinh");
                    obj.TienTrien = DataReader.GetInt("TienTrien");
                    obj.Loet = DataReader.GetInt("Loet");
                    obj.RanhGioi = DataReader.GetInt("RanhGioi");
                    obj.KichThuoc = DataReader["KichThuoc"].ToString();
                    obj.SoLuong = DataReader["SoLuong"].ToString();
                    obj.Hach = DataReader.GetInt("Hach");
                    obj.ViTriSoLuongHach = DataReader["ViTriSoLuongHach"].ToString();
                    obj.BatThuongBoPhanKhac = DataReader["BatThuongBoPhanKhac"].ToString();
                    obj.HC = DataReader["HC"].ToString();
                    obj.Hb = DataReader["Hb"].ToString();
                    obj.BC = DataReader["BC"].ToString();
                    obj.Lympho = DataReader["Lympho"].ToString();
                    obj.TC = DataReader["TC"].ToString();
                    obj.NhomMau = DataReader["NhomMau"].ToString();
                    obj.Glucose = DataReader["Glucose"].ToString();
                    obj.Ure = DataReader["Ure"].ToString();
                    obj.Creatinin = DataReader["Creatinin"].ToString();
                    obj.Cholesterol = DataReader["Cholesterol"].ToString();
                    obj.Triglycerid = DataReader["Triglycerid"].ToString();
                    obj.HDLC = DataReader["HDLC"].ToString();
                    obj.LDLC = DataReader["LDLC"].ToString();
                    obj.GOT = DataReader["GOT"].ToString();
                    obj.GPT = DataReader["GPT"].ToString();
                    obj.ProteinTP = DataReader["ProteinTP"].ToString();
                    obj.Albumin = DataReader["Albumin"].ToString();
                    obj.Na = DataReader["Na"].ToString();
                    obj.K = DataReader["K"].ToString();
                    obj.Cl = DataReader["Cl"].ToString();
                    obj.HinhAnhDermoscopy = DataReader["HinhAnhDermoscopy"].ToString();
                    obj.XQuang = DataReader["XQuang"].ToString();
                    obj.SieuAm = DataReader["SieuAm"].ToString();
                    obj.CLVT = DataReader["CLVT"].ToString();
                    obj.PET = DataReader["PET"].ToString();
                    obj.ChanDoanHinhAnh_Khac = DataReader["ChanDoanHinhAnh_Khac"].ToString();
                    obj.TheMoHoc = DataReader.GetInt("TheMoHoc");
                    obj.DoBietHoa = DataReader.GetInt("DoBietHoa");
                    obj.XamLanThanKinh = DataReader.GetInt("XamLanThanKinh");
                    obj.XamLanMachMau = DataReader.GetInt("XamLanMachMau");
                    obj.ChiSoPhanBao = DataReader["ChiSoPhanBao"].ToString();
                    obj.ChiSoBreslow = DataReader["ChiSoBreslow"].ToString();
                    obj.ChiSoClark = DataReader["ChiSoClark"].ToString();
                    obj.LoetViThe = DataReader.GetInt("LoetViThe");
                    obj.TonThuongVeTinh = DataReader.GetInt("TonThuongVeTinh");
                    obj.S100 = DataReader.GetInt("S100");
                    obj.Ki67 = DataReader.GetInt("Ki67");
                    obj.Vimentine = DataReader.GetInt("Vimentine");
                    obj.HMB45 = DataReader.GetInt("HMB45");
                    obj.CD34 = DataReader.GetInt("CD34");
                    obj.CK = DataReader.GetInt("CK");
                    obj.HoaMoMienDich_Khac = DataReader["HoaMoMienDich_Khac"].ToString();
                    obj.ChocHutTeBao_HachViem = DataReader.GetInt("ChocHutTeBao_HachViem");
                    obj.ChocHutTeBao_HachDiCan = DataReader.GetInt("ChocHutTeBao_HachDiCan");
                    obj.ChocHutTeBaoHach_ViTri = DataReader["ChocHutTeBaoHach_ViTri"].ToString();
                    obj.SinhThietHach_HachViem = DataReader.GetInt("SinhThietHach_HachViem");
                    obj.SinhThietHach_HachDiCan = DataReader.GetInt("SinhThietHach_HachDiCan");
                    obj.SinhThietHach_ViTri = DataReader["SinhThietHach_ViTri"].ToString();
                    obj.SoLuongHachDican = DataReader["SoLuongHachDican"].ToString();
                    obj.BRAF = DataReader.GetInt("BRAF");
                    obj.p53 = DataReader.GetInt("p53");
                    obj.Patched = DataReader.GetInt("Patched");
                    obj.Gen_Khac = DataReader["Gen_Khac"].ToString();
                    obj.CacXetNghiemKhac = DataReader["CacXetNghiemKhac"].ToString();
                    obj.TheNongSMM = DataReader.GetInt("TheNongSMM");
                    obj.TheCuaDubreuih = DataReader.GetInt("TheCuaDubreuih");
                    obj.TheDauCuc = DataReader.GetInt("TheDauCuc");
                    obj.TheU = DataReader.GetInt("TheU");
                    obj.TheUngThu_Khac = DataReader["TheUngThu_Khac"].ToString();
                    obj.TheUngThu_ChiSoBreslow = DataReader["TheUngThu_ChiSoBreslow"].ToString();
                    obj.TNM_T = DataReader["TNM_T"].ToString();
                    obj.TNM_N = DataReader["TNM_N"].ToString();
                    obj.TNM_M = DataReader["TNM_M"].ToString();
                    obj.PhanLoaiGiaiDoan_TNM = DataReader.GetInt("PhanLoaiGiaiDoan_TNM");
                    obj.CatRongCoDien = DataReader.GetInt("CatRongCoDien");
                    obj.CatBoThuongTon = DataReader["CatBoThuongTon"].ToString();
                    obj.Mosh = DataReader.GetInt("Mosh");
                    obj.SoLuongCatMosh = DataReader["SoLuongCatMosh"].ToString();
                    obj.TuLien = DataReader.GetInt("TuLien");
                    obj.GhepDa = DataReader.GetInt("GhepDa");
                    obj.VatTaiCho = DataReader.GetInt("VatTaiCho");
                    obj.VatXa = DataReader.GetInt("VatXa");
                    obj.VatTuDo = DataReader.GetInt("VatTuDo");
                    obj.TaoHinhKhuyetDa_Khac = DataReader["TaoHinhKhuyetDa_Khac"].ToString();
                    obj.NaoVetHach_ToanBo = DataReader.GetInt("NaoVetHach_ToanBo");
                    obj.NaoVetHach_ChonLoc = DataReader.GetInt("NaoVetHach_ChonLoc");
                    obj.TiaXaHoaChat = DataReader["TiaXaHoaChat"].ToString();
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
        public static bool InsertOrUpdate(MDB.MDBConnection MyConnection, BenhAnUngThuHacTo BenhAnUngThuHacTo)
        {
            try
            {
                string sql =
                          @"select MaQuanLy 
                            from BenhAnUngThuHacTo
                            where MaQuanLy = :MaQuanLy";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", BenhAnUngThuHacTo.MaQuanLy));
                MDB.MDBDataReader DataReader = Command.ExecuteReader();
                int rowCount = 0;
                while (DataReader.Read()) rowCount++;
                if (rowCount == 1) return Update(MyConnection, BenhAnUngThuHacTo);
                sql = @"
                       INSERT INTO BenhAnUngThuHacTo 
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
                            ViemMoiAnhNang,
                            ViemDaAnhNang,
                            ViemDaTiaXa,
                            DaySungAnhNang,
                            LupusBanDoHeThong,
                            LichenPhang,
                            SeoBong,
                            LoetManTinh,
                            NotRuoiKhongDienHinh,
                            BotKhongDienHinh,
                            BotSacToBamSinh,
                            BachTang,
                            BachBien,
                            KhoDaSacTo,
                            LoanSanThuongBi,
                            HoiChungGorlin,
                            HoiChungBazex,
                            BachSan,
                            TonThuongTienUngThu_Khac,
                            HoatDongDuoiAnhNang,
                            TanSuat,
                            ThoiGian,
                            ThoiDiem1016h,
                            ThoiDiem_Khac,
                            BienPhapBaoVe,
                            QuanAo,
                            KemChongNang,
                            PhuongPhapKhac,
                            DungThuocUCMD,
                            GhepTangCuThe,
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
                            DoiXung,
                            Bo,
                            MauSac,
                            DuongKinh,
                            TienTrien,
                            Loet,
                            RanhGioi,
                            KichThuoc,
                            SoLuong,
                            Hach,
                            ViTriSoLuongHach,
                            BatThuongBoPhanKhac,
                            HC,
                            Hb,
                            BC,
                            Lympho,
                            TC,
                            NhomMau,
                            Glucose,
                            Ure,
                            Creatinin,
                            Cholesterol,
                            Triglycerid,
                            HDLC,
                            LDLC,
                            GOT,
                            GPT,
                            ProteinTP,
                            Albumin,
                            Na,
                            K,
                            Cl,
                            HinhAnhDermoscopy,
                            XQuang,
                            SieuAm,
                            CLVT,
                            PET,
                            ChanDoanHinhAnh_Khac,
                            TheMoHoc,
                            DoBietHoa,
                            XamLanThanKinh,
                            XamLanMachMau,
                            ChiSoPhanBao,
                            ChiSoBreslow,
                            ChiSoClark,
                            LoetViThe,
                            TonThuongVeTinh,
                            S100,
                            Ki67,
                            Vimentine,
                            HMB45,
                            CD34,
                            CK,
                            HoaMoMienDich_Khac,
                            ChocHutTeBao_HachViem,
                            ChocHutTeBao_HachDiCan,
                            ChocHutTeBaoHach_ViTri,
                            SinhThietHach_HachViem,
                            SinhThietHach_HachDiCan,
                            SinhThietHach_ViTri,
                            SoLuongHachDican,
                            BRAF,
                            p53,
                            Patched,
                            Gen_Khac,
                            CacXetNghiemKhac,
                            TheNongSMM,
                            TheCuaDubreuih,
                            TheDauCuc,
                            TheU,
                            TheUngThu_Khac,
                            TheUngThu_ChiSoBreslow,
                            TNM_T,
                            TNM_N,
                            TNM_M,
                            PhanLoaiGiaiDoan_TNM,
                            CatRongCoDien,
                            CatBoThuongTon,
                            Mosh,
                            SoLuongCatMosh,
                            TuLien,
                            GhepDa,
                            VatTaiCho,
                            VatXa,
                            VatTuDo,
                            TaoHinhKhuyetDa_Khac,
                            NaoVetHach_ToanBo,
                            NaoVetHach_ChonLoc,
                            TiaXaHoaChat,
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
                            :ViemMoiAnhNang,
                            :ViemDaAnhNang,
                            :ViemDaTiaXa,
                            :DaySungAnhNang,
                            :LupusBanDoHeThong,
                            :LichenPhang,
                            :SeoBong,
                            :LoetManTinh,
                            :NotRuoiKhongDienHinh,
                            :BotKhongDienHinh,
                            :BotSacToBamSinh,
                            :BachTang,
                            :BachBien,
                            :KhoDaSacTo,
                            :LoanSanThuongBi,
                            :HoiChungGorlin,
                            :HoiChungBazex,
                            :BachSan,
                            :TonThuongTienUngThu_Khac,
                            :HoatDongDuoiAnhNang,
                            :TanSuat,
                            :ThoiGian,
                            :ThoiDiem1016h,
                            :ThoiDiem_Khac,
                            :BienPhapBaoVe,
                            :QuanAo,
                            :KemChongNang,
                            :PhuongPhapKhac,
                            :DungThuocUCMD,
                            :GhepTangCuThe,
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
                            :DoiXung,
                            :Bo,
                            :MauSac,
                            :DuongKinh,
                            :TienTrien,
                            :Loet,
                            :RanhGioi,
                            :KichThuoc,
                            :SoLuong,
                            :Hach,
                            :ViTriSoLuongHach,
                            :BatThuongBoPhanKhac,
                            :HC,
                            :Hb,
                            :BC,
                            :Lympho,
                            :TC,
                            :NhomMau,
                            :Glucose,
                            :Ure,
                            :Creatinin,
                            :Cholesterol,
                            :Triglycerid,
                            :HDLC,
                            :LDLC,
                            :GOT,
                            :GPT,
                            :ProteinTP,
                            :Albumin,
                            :Na,
                            :K,
                            :Cl,
                            :HinhAnhDermoscopy,
                            :XQuang,
                            :SieuAm,
                            :CLVT,
                            :PET,
                            :ChanDoanHinhAnh_Khac,
                            :TheMoHoc,
                            :DoBietHoa,
                            :XamLanThanKinh,
                            :XamLanMachMau,
                            :ChiSoPhanBao,
                            :ChiSoBreslow,
                            :ChiSoClark,
                            :LoetViThe,
                            :TonThuongVeTinh,
                            :S100,
                            :Ki67,
                            :Vimentine,
                            :HMB45,
                            :CD34,
                            :CK,
                            :HoaMoMienDich_Khac,
                            :ChocHutTeBao_HachViem,
                            :ChocHutTeBao_HachDiCan,
                            :ChocHutTeBaoHach_ViTri,
                            :SinhThietHach_HachViem,
                            :SinhThietHach_HachDiCan,
                            :SinhThietHach_ViTri,
                            :SoLuongHachDican,
                            :BRAF,
                            :p53,
                            :Patched,
                            :Gen_Khac,
                            :CacXetNghiemKhac,
                            :TheNongSMM,
                            :TheCuaDubreuih,
                            :TheDauCuc,
                            :TheU,
                            :TheUngThu_Khac,
                            :TheUngThu_ChiSoBreslow,
                            :TNM_T,
                            :TNM_N,
                            :TNM_M,
                            :PhanLoaiGiaiDoan_TNM,
                            :CatRongCoDien,
                            :CatBoThuongTon,
                            :Mosh,
                            :SoLuongCatMosh,
                            :TuLien,
                            :GhepDa,
                            :VatTaiCho,
                            :VatXa,
                            :VatTuDo,
                            :TaoHinhKhuyetDa_Khac,
                            :NaoVetHach_ToanBo,
                            :NaoVetHach_ChonLoc,
                            :TiaXaHoaChat,
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
                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", BenhAnUngThuHacTo.MaQuanLy));
                Command.Parameters.Add(new MDB.MDBParameter("DieuTriNgoaiTruTu", BenhAnUngThuHacTo.DieuTriNgoaiTruTu));
                Command.Parameters.Add(new MDB.MDBParameter("DieuTriNgoaiTruDen", BenhAnUngThuHacTo.DieuTriNgoaiTruDen));
                Command.Parameters.Add(new MDB.MDBParameter("SoCMND", BenhAnUngThuHacTo.SoCMND));
                Command.Parameters.Add(new MDB.MDBParameter("BaoHiem", BenhAnUngThuHacTo.BaoHiem));
                Command.Parameters.Add(new MDB.MDBParameter("ChanDoan_TuyenTruoc", BenhAnUngThuHacTo.ChanDoan_TuyenTruoc));
                Command.Parameters.Add(new MDB.MDBParameter("ChanDoanBanDau", BenhAnUngThuHacTo.ChanDoanBanDau));
                Command.Parameters.Add(new MDB.MDBParameter("ChanDoanTaiKham1", BenhAnUngThuHacTo.ChanDoanTaiKham1));
                Command.Parameters.Add(new MDB.MDBParameter("ChanDoanTaiKham2", BenhAnUngThuHacTo.ChanDoanTaiKham2));
                Command.Parameters.Add(new MDB.MDBParameter("ChanDoanTaiKham3", BenhAnUngThuHacTo.ChanDoanTaiKham3));
                Command.Parameters.Add(new MDB.MDBParameter("ChanDoanTaiKham4", BenhAnUngThuHacTo.ChanDoanTaiKham4));
                Command.Parameters.Add(new MDB.MDBParameter("BenhPhu", BenhAnUngThuHacTo.BenhPhu));
                Command.Parameters.Add(new MDB.MDBParameter("KetQuaDieuTri", BenhAnUngThuHacTo.KetQuaDieuTri));
                Command.Parameters.Add(new MDB.MDBParameter("BienChung_Text", BenhAnUngThuHacTo.BienChung_Text));
                Command.Parameters.Add(new MDB.MDBParameter("GDPhongKeHoach", BenhAnUngThuHacTo.GDPhongKeHoach));
                Command.Parameters.Add(new MDB.MDBParameter("GDPhongKhamBenh", BenhAnUngThuHacTo.GDPhongKhamBenh));
                // hỏi bệnh, khám bệnh
                Command.Parameters.Add(new MDB.MDBParameter("HB_TGPhatBenh", BenhAnUngThuHacTo.HB_TGPhatBenh));
                Command.Parameters.Add(new MDB.MDBParameter("HB_TrieuTrungDauTien", BenhAnUngThuHacTo.HB_TrieuTrungDauTien));
                Command.Parameters.Add(new MDB.MDBParameter("XuatHienTrenVungDa", BenhAnUngThuHacTo.XuatHienTrenVungDa));
                Command.Parameters.Add(new MDB.MDBParameter("HB_QuaTrinhBenhLy", BenhAnUngThuHacTo.HB_QuaTrinhBenhLy));
                Command.Parameters.Add(new MDB.MDBParameter("DieuTriTruocDay", BenhAnUngThuHacTo.DieuTriTruocDay));
                Command.Parameters.Add(new MDB.MDBParameter("HB_PhuongPhapDieuTri", BenhAnUngThuHacTo.HB_PhuongPhapDieuTri));
                Command.Parameters.Add(new MDB.MDBParameter("HB_KetQuaDieuTri", BenhAnUngThuHacTo.HB_KetQuaDieuTri));
                Command.Parameters.Add(new MDB.MDBParameter("TienSuBanThan", BenhAnUngThuHacTo.TienSuBanThan));
                Command.Parameters.Add(new MDB.MDBParameter("TienSuBenhLyNoiNgoai", BenhAnUngThuHacTo.TienSuBenhLyNoiNgoai));
                Command.Parameters.Add(new MDB.MDBParameter("ViemMoiAnhNang", BenhAnUngThuHacTo.ViemMoiAnhNang));
                Command.Parameters.Add(new MDB.MDBParameter("ViemDaAnhNang", BenhAnUngThuHacTo.ViemDaAnhNang));
                Command.Parameters.Add(new MDB.MDBParameter("ViemDaTiaXa", BenhAnUngThuHacTo.ViemDaTiaXa));
                Command.Parameters.Add(new MDB.MDBParameter("DaySungAnhNang", BenhAnUngThuHacTo.DaySungAnhNang));
                Command.Parameters.Add(new MDB.MDBParameter("LupusBanDoHeThong", BenhAnUngThuHacTo.LupusBanDoHeThong));
                Command.Parameters.Add(new MDB.MDBParameter("LichenPhang", BenhAnUngThuHacTo.LichenPhang));
                Command.Parameters.Add(new MDB.MDBParameter("SeoBong", BenhAnUngThuHacTo.SeoBong));
                Command.Parameters.Add(new MDB.MDBParameter("LoetManTinh", BenhAnUngThuHacTo.LoetManTinh));
                Command.Parameters.Add(new MDB.MDBParameter("NotRuoiKhongDienHinh", BenhAnUngThuHacTo.NotRuoiKhongDienHinh));
                Command.Parameters.Add(new MDB.MDBParameter("BotKhongDienHinh", BenhAnUngThuHacTo.BotKhongDienHinh));
                Command.Parameters.Add(new MDB.MDBParameter("BotSacToBamSinh", BenhAnUngThuHacTo.BotSacToBamSinh));
                Command.Parameters.Add(new MDB.MDBParameter("BachTang", BenhAnUngThuHacTo.BachTang));
                Command.Parameters.Add(new MDB.MDBParameter("BachBien", BenhAnUngThuHacTo.BachBien));
                Command.Parameters.Add(new MDB.MDBParameter("KhoDaSacTo", BenhAnUngThuHacTo.KhoDaSacTo));
                Command.Parameters.Add(new MDB.MDBParameter("LoanSanThuongBi", BenhAnUngThuHacTo.LoanSanThuongBi));
                Command.Parameters.Add(new MDB.MDBParameter("HoiChungGorlin", BenhAnUngThuHacTo.HoiChungGorlin));
                Command.Parameters.Add(new MDB.MDBParameter("HoiChungBazex", BenhAnUngThuHacTo.HoiChungBazex));
                Command.Parameters.Add(new MDB.MDBParameter("BachSan", BenhAnUngThuHacTo.BachSan));
                Command.Parameters.Add(new MDB.MDBParameter("TonThuongTienUngThu_Khac", BenhAnUngThuHacTo.TonThuongTienUngThu_Khac));
                Command.Parameters.Add(new MDB.MDBParameter("HoatDongDuoiAnhNang", BenhAnUngThuHacTo.HoatDongDuoiAnhNang));
                Command.Parameters.Add(new MDB.MDBParameter("TanSuat", BenhAnUngThuHacTo.TanSuat));
                Command.Parameters.Add(new MDB.MDBParameter("ThoiGian", BenhAnUngThuHacTo.ThoiGian));
                Command.Parameters.Add(new MDB.MDBParameter("ThoiDiem1016h", BenhAnUngThuHacTo.ThoiDiem1016h));
                Command.Parameters.Add(new MDB.MDBParameter("ThoiDiem_Khac", BenhAnUngThuHacTo.ThoiDiem_Khac));
                Command.Parameters.Add(new MDB.MDBParameter("BienPhapBaoVe", BenhAnUngThuHacTo.BienPhapBaoVe));
                Command.Parameters.Add(new MDB.MDBParameter("QuanAo", BenhAnUngThuHacTo.QuanAo));
                Command.Parameters.Add(new MDB.MDBParameter("KemChongNang", BenhAnUngThuHacTo.KemChongNang));
                Command.Parameters.Add(new MDB.MDBParameter("PhuongPhapKhac", BenhAnUngThuHacTo.PhuongPhapKhac));
                Command.Parameters.Add(new MDB.MDBParameter("DungThuocUCMD", BenhAnUngThuHacTo.DungThuocUCMD));
                Command.Parameters.Add(new MDB.MDBParameter("GhepTangCuThe", BenhAnUngThuHacTo.GhepTangCuThe));
                Command.Parameters.Add(new MDB.MDBParameter("NhiemHIVAIDS", BenhAnUngThuHacTo.NhiemHIVAIDS));
                Command.Parameters.Add(new MDB.MDBParameter("SuyGiamMienDich_Khac", BenhAnUngThuHacTo.SuyGiamMienDich_Khac));
                Command.Parameters.Add(new MDB.MDBParameter("CoNguoiBiUngThuDa", BenhAnUngThuHacTo.CoNguoiBiUngThuDa));
                Command.Parameters.Add(new MDB.MDBParameter("LoaiUngThuDa", BenhAnUngThuHacTo.LoaiUngThuDa));
                Command.Parameters.Add(new MDB.MDBParameter("CoNguoiBiUngThuKhac", BenhAnUngThuHacTo.CoNguoiBiUngThuKhac));
                Command.Parameters.Add(new MDB.MDBParameter("LoaiUngThuKhac", BenhAnUngThuHacTo.LoaiUngThuKhac));
                Command.Parameters.Add(new MDB.MDBParameter("TienSuGiaDinh_Khac", BenhAnUngThuHacTo.TienSuGiaDinh_Khac));
                Command.Parameters.Add(new MDB.MDBParameter("ToanThan", BenhAnUngThuHacTo.ToanThan));
                Command.Parameters.Add(new MDB.MDBParameter("CacBoPhan", BenhAnUngThuHacTo.CacBoPhan));
                Command.Parameters.Add(new MDB.MDBParameter("TypDa", BenhAnUngThuHacTo.TypDa));
                Command.Parameters.Add(new MDB.MDBParameter("ThuongTonCoBan", BenhAnUngThuHacTo.ThuongTonCoBan));
                Command.Parameters.Add(new MDB.MDBParameter("DoiXung", BenhAnUngThuHacTo.DoiXung));
                Command.Parameters.Add(new MDB.MDBParameter("Bo", BenhAnUngThuHacTo.Bo));
                Command.Parameters.Add(new MDB.MDBParameter("MauSac", BenhAnUngThuHacTo.MauSac));
                Command.Parameters.Add(new MDB.MDBParameter("DuongKinh", BenhAnUngThuHacTo.DuongKinh));
                Command.Parameters.Add(new MDB.MDBParameter("TienTrien", BenhAnUngThuHacTo.TienTrien));
                Command.Parameters.Add(new MDB.MDBParameter("Loet", BenhAnUngThuHacTo.Loet));
                Command.Parameters.Add(new MDB.MDBParameter("RanhGioi", BenhAnUngThuHacTo.RanhGioi));
                Command.Parameters.Add(new MDB.MDBParameter("KichThuoc", BenhAnUngThuHacTo.KichThuoc));
                Command.Parameters.Add(new MDB.MDBParameter("SoLuong", BenhAnUngThuHacTo.SoLuong));
                Command.Parameters.Add(new MDB.MDBParameter("Hach", BenhAnUngThuHacTo.Hach));
                Command.Parameters.Add(new MDB.MDBParameter("ViTriSoLuongHach", BenhAnUngThuHacTo.ViTriSoLuongHach));
                Command.Parameters.Add(new MDB.MDBParameter("BatThuongBoPhanKhac", BenhAnUngThuHacTo.BatThuongBoPhanKhac));
                Command.Parameters.Add(new MDB.MDBParameter("HC", BenhAnUngThuHacTo.HC));
                Command.Parameters.Add(new MDB.MDBParameter("Hb", BenhAnUngThuHacTo.Hb));
                Command.Parameters.Add(new MDB.MDBParameter("BC", BenhAnUngThuHacTo.BC));
                Command.Parameters.Add(new MDB.MDBParameter("Lympho", BenhAnUngThuHacTo.Lympho));
                Command.Parameters.Add(new MDB.MDBParameter("TC", BenhAnUngThuHacTo.TC));
                Command.Parameters.Add(new MDB.MDBParameter("NhomMau", BenhAnUngThuHacTo.NhomMau));
                Command.Parameters.Add(new MDB.MDBParameter("Glucose", BenhAnUngThuHacTo.Glucose));
                Command.Parameters.Add(new MDB.MDBParameter("Ure", BenhAnUngThuHacTo.Ure));
                Command.Parameters.Add(new MDB.MDBParameter("Creatinin", BenhAnUngThuHacTo.Creatinin));
                Command.Parameters.Add(new MDB.MDBParameter("Cholesterol", BenhAnUngThuHacTo.Cholesterol));
                Command.Parameters.Add(new MDB.MDBParameter("Triglycerid", BenhAnUngThuHacTo.Triglycerid));
                Command.Parameters.Add(new MDB.MDBParameter("HDLC", BenhAnUngThuHacTo.HDLC));
                Command.Parameters.Add(new MDB.MDBParameter("LDLC", BenhAnUngThuHacTo.LDLC));
                Command.Parameters.Add(new MDB.MDBParameter("GOT", BenhAnUngThuHacTo.GOT));
                Command.Parameters.Add(new MDB.MDBParameter("GPT", BenhAnUngThuHacTo.GPT));
                Command.Parameters.Add(new MDB.MDBParameter("ProteinTP", BenhAnUngThuHacTo.ProteinTP));
                Command.Parameters.Add(new MDB.MDBParameter("Albumin", BenhAnUngThuHacTo.Albumin));
                Command.Parameters.Add(new MDB.MDBParameter("Na", BenhAnUngThuHacTo.Na));
                Command.Parameters.Add(new MDB.MDBParameter("K", BenhAnUngThuHacTo.K));
                Command.Parameters.Add(new MDB.MDBParameter("Cl", BenhAnUngThuHacTo.Cl));
                Command.Parameters.Add(new MDB.MDBParameter("HinhAnhDermoscopy", BenhAnUngThuHacTo.HinhAnhDermoscopy));
                Command.Parameters.Add(new MDB.MDBParameter("XQuang", BenhAnUngThuHacTo.XQuang));
                Command.Parameters.Add(new MDB.MDBParameter("SieuAm", BenhAnUngThuHacTo.SieuAm));
                Command.Parameters.Add(new MDB.MDBParameter("CLVT", BenhAnUngThuHacTo.CLVT));
                Command.Parameters.Add(new MDB.MDBParameter("PET", BenhAnUngThuHacTo.PET));
                Command.Parameters.Add(new MDB.MDBParameter("ChanDoanHinhAnh_Khac", BenhAnUngThuHacTo.ChanDoanHinhAnh_Khac));
                Command.Parameters.Add(new MDB.MDBParameter("TheMoHoc", BenhAnUngThuHacTo.TheMoHoc));
                Command.Parameters.Add(new MDB.MDBParameter("DoBietHoa", BenhAnUngThuHacTo.DoBietHoa));
                Command.Parameters.Add(new MDB.MDBParameter("XamLanThanKinh", BenhAnUngThuHacTo.XamLanThanKinh));
                Command.Parameters.Add(new MDB.MDBParameter("XamLanMachMau", BenhAnUngThuHacTo.XamLanMachMau));
                Command.Parameters.Add(new MDB.MDBParameter("ChiSoPhanBao", BenhAnUngThuHacTo.ChiSoPhanBao));
                Command.Parameters.Add(new MDB.MDBParameter("ChiSoBreslow", BenhAnUngThuHacTo.ChiSoBreslow));
                Command.Parameters.Add(new MDB.MDBParameter("ChiSoClark", BenhAnUngThuHacTo.ChiSoClark));
                Command.Parameters.Add(new MDB.MDBParameter("LoetViThe", BenhAnUngThuHacTo.LoetViThe));
                Command.Parameters.Add(new MDB.MDBParameter("TonThuongVeTinh", BenhAnUngThuHacTo.TonThuongVeTinh));
                Command.Parameters.Add(new MDB.MDBParameter("S100", BenhAnUngThuHacTo.S100));
                Command.Parameters.Add(new MDB.MDBParameter("Ki67", BenhAnUngThuHacTo.Ki67));
                Command.Parameters.Add(new MDB.MDBParameter("Vimentine", BenhAnUngThuHacTo.Vimentine));
                Command.Parameters.Add(new MDB.MDBParameter("HMB45", BenhAnUngThuHacTo.HMB45));
                Command.Parameters.Add(new MDB.MDBParameter("CD34", BenhAnUngThuHacTo.CD34));
                Command.Parameters.Add(new MDB.MDBParameter("CK", BenhAnUngThuHacTo.CK));
                Command.Parameters.Add(new MDB.MDBParameter("HoaMoMienDich_Khac", BenhAnUngThuHacTo.HoaMoMienDich_Khac));
                Command.Parameters.Add(new MDB.MDBParameter("ChocHutTeBao_HachViem", BenhAnUngThuHacTo.ChocHutTeBao_HachViem));
                Command.Parameters.Add(new MDB.MDBParameter("ChocHutTeBao_HachDiCan", BenhAnUngThuHacTo.ChocHutTeBao_HachDiCan));
                Command.Parameters.Add(new MDB.MDBParameter("ChocHutTeBaoHach_ViTri", BenhAnUngThuHacTo.ChocHutTeBaoHach_ViTri));
                Command.Parameters.Add(new MDB.MDBParameter("SinhThietHach_HachViem", BenhAnUngThuHacTo.SinhThietHach_HachViem));
                Command.Parameters.Add(new MDB.MDBParameter("SinhThietHach_HachDiCan", BenhAnUngThuHacTo.SinhThietHach_HachDiCan));
                Command.Parameters.Add(new MDB.MDBParameter("SinhThietHach_ViTri", BenhAnUngThuHacTo.SinhThietHach_ViTri));
                Command.Parameters.Add(new MDB.MDBParameter("SoLuongHachDican", BenhAnUngThuHacTo.SoLuongHachDican));
                Command.Parameters.Add(new MDB.MDBParameter("BRAF", BenhAnUngThuHacTo.BRAF));
                Command.Parameters.Add(new MDB.MDBParameter("p53", BenhAnUngThuHacTo.p53));
                Command.Parameters.Add(new MDB.MDBParameter("Patched", BenhAnUngThuHacTo.Patched));
                Command.Parameters.Add(new MDB.MDBParameter("Gen_Khac", BenhAnUngThuHacTo.Gen_Khac));
                Command.Parameters.Add(new MDB.MDBParameter("CacXetNghiemKhac", BenhAnUngThuHacTo.CacXetNghiemKhac));
                Command.Parameters.Add(new MDB.MDBParameter("TheNongSMM", BenhAnUngThuHacTo.TheNongSMM));
                Command.Parameters.Add(new MDB.MDBParameter("TheCuaDubreuih", BenhAnUngThuHacTo.TheCuaDubreuih));
                Command.Parameters.Add(new MDB.MDBParameter("TheDauCuc", BenhAnUngThuHacTo.TheDauCuc));
                Command.Parameters.Add(new MDB.MDBParameter("TheU", BenhAnUngThuHacTo.TheU));
                Command.Parameters.Add(new MDB.MDBParameter("TheUngThu_Khac", BenhAnUngThuHacTo.TheUngThu_Khac));
                Command.Parameters.Add(new MDB.MDBParameter("TheUngThu_ChiSoBreslow", BenhAnUngThuHacTo.TheUngThu_ChiSoBreslow));
                Command.Parameters.Add(new MDB.MDBParameter("TNM_T", BenhAnUngThuHacTo.TNM_T));
                Command.Parameters.Add(new MDB.MDBParameter("TNM_N", BenhAnUngThuHacTo.TNM_N));
                Command.Parameters.Add(new MDB.MDBParameter("TNM_M", BenhAnUngThuHacTo.TNM_M));
                Command.Parameters.Add(new MDB.MDBParameter("PhanLoaiGiaiDoan_TNM", BenhAnUngThuHacTo.PhanLoaiGiaiDoan_TNM));
                Command.Parameters.Add(new MDB.MDBParameter("CatRongCoDien", BenhAnUngThuHacTo.CatRongCoDien));
                Command.Parameters.Add(new MDB.MDBParameter("CatBoThuongTon", BenhAnUngThuHacTo.CatBoThuongTon));
                Command.Parameters.Add(new MDB.MDBParameter("Mosh", BenhAnUngThuHacTo.Mosh));
                Command.Parameters.Add(new MDB.MDBParameter("SoLuongCatMosh", BenhAnUngThuHacTo.SoLuongCatMosh));
                Command.Parameters.Add(new MDB.MDBParameter("TuLien", BenhAnUngThuHacTo.TuLien));
                Command.Parameters.Add(new MDB.MDBParameter("GhepDa", BenhAnUngThuHacTo.GhepDa));
                Command.Parameters.Add(new MDB.MDBParameter("VatTaiCho", BenhAnUngThuHacTo.VatTaiCho));
                Command.Parameters.Add(new MDB.MDBParameter("VatXa", BenhAnUngThuHacTo.VatXa));
                Command.Parameters.Add(new MDB.MDBParameter("VatTuDo", BenhAnUngThuHacTo.VatTuDo));
                Command.Parameters.Add(new MDB.MDBParameter("TaoHinhKhuyetDa_Khac", BenhAnUngThuHacTo.TaoHinhKhuyetDa_Khac));
                Command.Parameters.Add(new MDB.MDBParameter("NaoVetHach_ToanBo", BenhAnUngThuHacTo.NaoVetHach_ToanBo));
                Command.Parameters.Add(new MDB.MDBParameter("NaoVetHach_ChonLoc", BenhAnUngThuHacTo.NaoVetHach_ChonLoc));
                Command.Parameters.Add(new MDB.MDBParameter("TiaXaHoaChat", BenhAnUngThuHacTo.TiaXaHoaChat));
                Command.Parameters.Add(new MDB.MDBParameter("DieuTri_PhuongPhapKhac", BenhAnUngThuHacTo.DieuTri_PhuongPhapKhac));
                Command.Parameters.Add(new MDB.MDBParameter("PhauThuatLanh", BenhAnUngThuHacTo.PhauThuatLanh));
                Command.Parameters.Add(new MDB.MDBParameter("HoaChatTaiCho", BenhAnUngThuHacTo.HoaChatTaiCho));
                Command.Parameters.Add(new MDB.MDBParameter("TenThuoc", BenhAnUngThuHacTo.TenThuoc));
                Command.Parameters.Add(new MDB.MDBParameter("PhaHuyBangNhiet", BenhAnUngThuHacTo.PhaHuyBangNhiet));
                Command.Parameters.Add(new MDB.MDBParameter("TongKet_QuaTrinhBenhLy", BenhAnUngThuHacTo.TongKet_QuaTrinhBenhLy));
                Command.Parameters.Add(new MDB.MDBParameter("TomTatKetQua", BenhAnUngThuHacTo.TomTatKetQua));
                Command.Parameters.Add(new MDB.MDBParameter("BenhChinh", BenhAnUngThuHacTo.BenhChinh));
                Command.Parameters.Add(new MDB.MDBParameter("MaBenhChinh", BenhAnUngThuHacTo.MaBenhChinh));
                Command.Parameters.Add(new MDB.MDBParameter("BenhKemTheo", BenhAnUngThuHacTo.BenhKemTheo));
                Command.Parameters.Add(new MDB.MDBParameter("MaBenhKemTheo", BenhAnUngThuHacTo.MaBenhKemTheo));
                Command.Parameters.Add(new MDB.MDBParameter("PhuongPhapDieuTri", BenhAnUngThuHacTo.PhuongPhapDieuTri));
                Command.Parameters.Add(new MDB.MDBParameter("TinhTrangRaVien", BenhAnUngThuHacTo.TinhTrangRaVien));
                Command.Parameters.Add(new MDB.MDBParameter("HuongDieuTri", BenhAnUngThuHacTo.HuongDieuTri));
                Command.Parameters.Add(new MDB.MDBParameter("NguoiNhanHoSo", BenhAnUngThuHacTo.NguoiNhanHoSo));
                Command.Parameters.Add(new MDB.MDBParameter("NguoiGiaoHoSo", BenhAnUngThuHacTo.NguoiGiaoHoSo));
                Command.Parameters.Add(new MDB.MDBParameter("NgayTongKet", BenhAnUngThuHacTo.NgayTongKet));
                Command.Parameters.Add(new MDB.MDBParameter("TongKet_BacSyDieuTri", BenhAnUngThuHacTo.TongKet_BacSyDieuTri));
                Command.Parameters.Add(new MDB.MDBParameter("TongKet_MaBacSyDieuTri", BenhAnUngThuHacTo.TongKet_MaBacSyDieuTri));
                Command.Parameters.Add(new MDB.MDBParameter("TheoDoiDieuTris", JsonConvert.SerializeObject(BenhAnUngThuHacTo.TheoDoiDieuTris)));
                Command.Parameters.Add(new MDB.MDBParameter("ThoiGianSongSauDieuTri", BenhAnUngThuHacTo.ThoiGianSongSauDieuTri));
                Command.Parameters.Add(new MDB.MDBParameter("ChayMau", BenhAnUngThuHacTo.ChayMau));
                Command.Parameters.Add(new MDB.MDBParameter("TuMau", BenhAnUngThuHacTo.TuMau));
                Command.Parameters.Add(new MDB.MDBParameter("NhiemTrung", BenhAnUngThuHacTo.NhiemTrung));
                Command.Parameters.Add(new MDB.MDBParameter("LauLienVetMo", BenhAnUngThuHacTo.LauLienVetMo));
                Command.Parameters.Add(new MDB.MDBParameter("SeoXau", BenhAnUngThuHacTo.SeoXau));
                Command.Parameters.Add(new MDB.MDBParameter("PhuBachMach", BenhAnUngThuHacTo.PhuBachMach));
                Command.Parameters.Add(new MDB.MDBParameter("AnhHuongChucNang", BenhAnUngThuHacTo.AnhHuongChucNang));
                Command.Parameters.Add(new MDB.MDBParameter("BienChungXa_Khac", BenhAnUngThuHacTo.BienChungXa_Khac));

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
        public static bool Update(MDB.MDBConnection MyConnection, BenhAnUngThuHacTo BenhAnUngThuHacTo)
        {
            try
            {
                string sql = @"UPDATE BenhAnUngThuHacTo SET 
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
                            ViemMoiAnhNang=:ViemMoiAnhNang,
                            ViemDaAnhNang=:ViemDaAnhNang,
                            ViemDaTiaXa=:ViemDaTiaXa,
                            DaySungAnhNang=:DaySungAnhNang,
                            LupusBanDoHeThong=:LupusBanDoHeThong,
                            LichenPhang=:LichenPhang,
                            SeoBong=:SeoBong,
                            LoetManTinh=:LoetManTinh,
                            NotRuoiKhongDienHinh=:NotRuoiKhongDienHinh,
                            BotKhongDienHinh=:BotKhongDienHinh,
                            BotSacToBamSinh=:BotSacToBamSinh,
                            BachTang=:BachTang,
                            BachBien=:BachBien,
                            KhoDaSacTo=:KhoDaSacTo,
                            LoanSanThuongBi=:LoanSanThuongBi,
                            HoiChungGorlin=:HoiChungGorlin,
                            HoiChungBazex=:HoiChungBazex,
                            BachSan=:BachSan,
                            TonThuongTienUngThu_Khac=:TonThuongTienUngThu_Khac,
                            HoatDongDuoiAnhNang=:HoatDongDuoiAnhNang,
                            TanSuat=:TanSuat,
                            ThoiGian=:ThoiGian,
                            ThoiDiem1016h=:ThoiDiem1016h,
                            ThoiDiem_Khac=:ThoiDiem_Khac,
                            BienPhapBaoVe=:BienPhapBaoVe,
                            QuanAo=:QuanAo,
                            KemChongNang=:KemChongNang,
                            PhuongPhapKhac=:PhuongPhapKhac,
                            DungThuocUCMD=:DungThuocUCMD,
                            GhepTangCuThe=:GhepTangCuThe,
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
                            DoiXung=:DoiXung,
                            Bo=:Bo,
                            MauSac=:MauSac,
                            DuongKinh=:DuongKinh,
                            TienTrien=:TienTrien,
                            Loet=:Loet,
                            RanhGioi=:RanhGioi,
                            KichThuoc=:KichThuoc,
                            SoLuong=:SoLuong,
                            Hach=:Hach,
                            ViTriSoLuongHach=:ViTriSoLuongHach,
                            BatThuongBoPhanKhac=:BatThuongBoPhanKhac,
                            HC=:HC,
                            Hb=:Hb,
                            BC=:BC,
                            Lympho=:Lympho,
                            TC=:TC,
                            NhomMau=:NhomMau,
                            Glucose=:Glucose,
                            Ure=:Ure,
                            Creatinin=:Creatinin,
                            Cholesterol=:Cholesterol,
                            Triglycerid=:Triglycerid,
                            HDLC=:HDLC,
                            LDLC=:LDLC,
                            GOT=:GOT,
                            GPT=:GPT,
                            ProteinTP=:ProteinTP,
                            Albumin=:Albumin,
                            Na=:Na,
                            K=:K,
                            Cl=:Cl,
                            HinhAnhDermoscopy=:HinhAnhDermoscopy,
                            XQuang=:XQuang,
                            SieuAm=:SieuAm,
                            CLVT=:CLVT,
                            PET=:PET,
                            ChanDoanHinhAnh_Khac=:ChanDoanHinhAnh_Khac,
                            TheMoHoc=:TheMoHoc,
                            DoBietHoa=:DoBietHoa,
                            XamLanThanKinh=:XamLanThanKinh,
                            XamLanMachMau=:XamLanMachMau,
                            ChiSoPhanBao=:ChiSoPhanBao,
                            ChiSoBreslow=:ChiSoBreslow,
                            ChiSoClark=:ChiSoClark,
                            LoetViThe=:LoetViThe,
                            TonThuongVeTinh=:TonThuongVeTinh,
                            S100=:S100,
                            Ki67=:Ki67,
                            Vimentine=:Vimentine,
                            HMB45=:HMB45,
                            CD34=:CD34,
                            CK=:CK,
                            HoaMoMienDich_Khac=:HoaMoMienDich_Khac,
                            ChocHutTeBao_HachViem=:ChocHutTeBao_HachViem,
                            ChocHutTeBao_HachDiCan=:ChocHutTeBao_HachDiCan,
                            ChocHutTeBaoHach_ViTri=:ChocHutTeBaoHach_ViTri,
                            SinhThietHach_HachViem=:SinhThietHach_HachViem,
                            SinhThietHach_HachDiCan=:SinhThietHach_HachDiCan,
                            SinhThietHach_ViTri=:SinhThietHach_ViTri,
                            SoLuongHachDican=:SoLuongHachDican,
                            BRAF=:BRAF,
                            p53=:p53,
                            Patched=:Patched,
                            Gen_Khac=:Gen_Khac,
                            CacXetNghiemKhac=:CacXetNghiemKhac,
                            TheNongSMM=:TheNongSMM,
                            TheCuaDubreuih=:TheCuaDubreuih,
                            TheDauCuc=:TheDauCuc,
                            TheU=:TheU,
                            TheUngThu_Khac=:TheUngThu_Khac,
                            TheUngThu_ChiSoBreslow=:TheUngThu_ChiSoBreslow,
                            TNM_T=:TNM_T,
                            TNM_N=:TNM_N,
                            TNM_M=:TNM_M,
                            PhanLoaiGiaiDoan_TNM=:PhanLoaiGiaiDoan_TNM,
                            CatRongCoDien=:CatRongCoDien,
                            CatBoThuongTon=:CatBoThuongTon,
                            Mosh=:Mosh,
                            SoLuongCatMosh=:SoLuongCatMosh,
                            TuLien=:TuLien,
                            GhepDa=:GhepDa,
                            VatTaiCho=:VatTaiCho,
                            VatXa=:VatXa,
                            VatTuDo=:VatTuDo,
                            TaoHinhKhuyetDa_Khac=:TaoHinhKhuyetDa_Khac,
                            NaoVetHach_ToanBo=:NaoVetHach_ToanBo,
                            NaoVetHach_ChonLoc=:NaoVetHach_ChonLoc,
                            TiaXaHoaChat=:TiaXaHoaChat,
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
                Command.Parameters.Add(new MDB.MDBParameter("DieuTriNgoaiTruTu", BenhAnUngThuHacTo.DieuTriNgoaiTruTu));
                Command.Parameters.Add(new MDB.MDBParameter("DieuTriNgoaiTruDen", BenhAnUngThuHacTo.DieuTriNgoaiTruDen));
                Command.Parameters.Add(new MDB.MDBParameter("SoCMND", BenhAnUngThuHacTo.SoCMND));
                Command.Parameters.Add(new MDB.MDBParameter("BaoHiem", BenhAnUngThuHacTo.BaoHiem));
                Command.Parameters.Add(new MDB.MDBParameter("ChanDoan_TuyenTruoc", BenhAnUngThuHacTo.ChanDoan_TuyenTruoc));
                Command.Parameters.Add(new MDB.MDBParameter("ChanDoanBanDau", BenhAnUngThuHacTo.ChanDoanBanDau));
                Command.Parameters.Add(new MDB.MDBParameter("ChanDoanTaiKham1", BenhAnUngThuHacTo.ChanDoanTaiKham1));
                Command.Parameters.Add(new MDB.MDBParameter("ChanDoanTaiKham2", BenhAnUngThuHacTo.ChanDoanTaiKham2));
                Command.Parameters.Add(new MDB.MDBParameter("ChanDoanTaiKham3", BenhAnUngThuHacTo.ChanDoanTaiKham3));
                Command.Parameters.Add(new MDB.MDBParameter("ChanDoanTaiKham4", BenhAnUngThuHacTo.ChanDoanTaiKham4));
                Command.Parameters.Add(new MDB.MDBParameter("BenhPhu", BenhAnUngThuHacTo.BenhPhu));
                Command.Parameters.Add(new MDB.MDBParameter("KetQuaDieuTri", BenhAnUngThuHacTo.KetQuaDieuTri));
                Command.Parameters.Add(new MDB.MDBParameter("BienChung_Text", BenhAnUngThuHacTo.BienChung_Text));
                Command.Parameters.Add(new MDB.MDBParameter("GDPhongKeHoach", BenhAnUngThuHacTo.GDPhongKeHoach));
                Command.Parameters.Add(new MDB.MDBParameter("GDPhongKhamBenh", BenhAnUngThuHacTo.GDPhongKhamBenh));
                // hỏi bệnh, khám bệnh
                Command.Parameters.Add(new MDB.MDBParameter("HB_TGPhatBenh", BenhAnUngThuHacTo.HB_TGPhatBenh));
                Command.Parameters.Add(new MDB.MDBParameter("HB_TrieuTrungDauTien", BenhAnUngThuHacTo.HB_TrieuTrungDauTien));
                Command.Parameters.Add(new MDB.MDBParameter("XuatHienTrenVungDa", BenhAnUngThuHacTo.XuatHienTrenVungDa));
                Command.Parameters.Add(new MDB.MDBParameter("HB_QuaTrinhBenhLy", BenhAnUngThuHacTo.HB_QuaTrinhBenhLy));
                Command.Parameters.Add(new MDB.MDBParameter("DieuTriTruocDay", BenhAnUngThuHacTo.DieuTriTruocDay));
                Command.Parameters.Add(new MDB.MDBParameter("HB_PhuongPhapDieuTri", BenhAnUngThuHacTo.HB_PhuongPhapDieuTri));
                Command.Parameters.Add(new MDB.MDBParameter("HB_KetQuaDieuTri", BenhAnUngThuHacTo.HB_KetQuaDieuTri));
                Command.Parameters.Add(new MDB.MDBParameter("TienSuBanThan", BenhAnUngThuHacTo.TienSuBanThan));
                Command.Parameters.Add(new MDB.MDBParameter("TienSuBenhLyNoiNgoai", BenhAnUngThuHacTo.TienSuBenhLyNoiNgoai));
                Command.Parameters.Add(new MDB.MDBParameter("ViemMoiAnhNang", BenhAnUngThuHacTo.ViemMoiAnhNang));
                Command.Parameters.Add(new MDB.MDBParameter("ViemDaAnhNang", BenhAnUngThuHacTo.ViemDaAnhNang));
                Command.Parameters.Add(new MDB.MDBParameter("ViemDaTiaXa", BenhAnUngThuHacTo.ViemDaTiaXa));
                Command.Parameters.Add(new MDB.MDBParameter("DaySungAnhNang", BenhAnUngThuHacTo.DaySungAnhNang));
                Command.Parameters.Add(new MDB.MDBParameter("LupusBanDoHeThong", BenhAnUngThuHacTo.LupusBanDoHeThong));
                Command.Parameters.Add(new MDB.MDBParameter("LichenPhang", BenhAnUngThuHacTo.LichenPhang));
                Command.Parameters.Add(new MDB.MDBParameter("SeoBong", BenhAnUngThuHacTo.SeoBong));
                Command.Parameters.Add(new MDB.MDBParameter("LoetManTinh", BenhAnUngThuHacTo.LoetManTinh));
                Command.Parameters.Add(new MDB.MDBParameter("NotRuoiKhongDienHinh", BenhAnUngThuHacTo.NotRuoiKhongDienHinh));
                Command.Parameters.Add(new MDB.MDBParameter("BotKhongDienHinh", BenhAnUngThuHacTo.BotKhongDienHinh));
                Command.Parameters.Add(new MDB.MDBParameter("BotSacToBamSinh", BenhAnUngThuHacTo.BotSacToBamSinh));
                Command.Parameters.Add(new MDB.MDBParameter("BachTang", BenhAnUngThuHacTo.BachTang));
                Command.Parameters.Add(new MDB.MDBParameter("BachBien", BenhAnUngThuHacTo.BachBien));
                Command.Parameters.Add(new MDB.MDBParameter("KhoDaSacTo", BenhAnUngThuHacTo.KhoDaSacTo));
                Command.Parameters.Add(new MDB.MDBParameter("LoanSanThuongBi", BenhAnUngThuHacTo.LoanSanThuongBi));
                Command.Parameters.Add(new MDB.MDBParameter("HoiChungGorlin", BenhAnUngThuHacTo.HoiChungGorlin));
                Command.Parameters.Add(new MDB.MDBParameter("HoiChungBazex", BenhAnUngThuHacTo.HoiChungBazex));
                Command.Parameters.Add(new MDB.MDBParameter("BachSan", BenhAnUngThuHacTo.BachSan));
                Command.Parameters.Add(new MDB.MDBParameter("TonThuongTienUngThu_Khac", BenhAnUngThuHacTo.TonThuongTienUngThu_Khac));
                Command.Parameters.Add(new MDB.MDBParameter("HoatDongDuoiAnhNang", BenhAnUngThuHacTo.HoatDongDuoiAnhNang));
                Command.Parameters.Add(new MDB.MDBParameter("TanSuat", BenhAnUngThuHacTo.TanSuat));
                Command.Parameters.Add(new MDB.MDBParameter("ThoiGian", BenhAnUngThuHacTo.ThoiGian));
                Command.Parameters.Add(new MDB.MDBParameter("ThoiDiem1016h", BenhAnUngThuHacTo.ThoiDiem1016h));
                Command.Parameters.Add(new MDB.MDBParameter("ThoiDiem_Khac", BenhAnUngThuHacTo.ThoiDiem_Khac));
                Command.Parameters.Add(new MDB.MDBParameter("BienPhapBaoVe", BenhAnUngThuHacTo.BienPhapBaoVe));
                Command.Parameters.Add(new MDB.MDBParameter("QuanAo", BenhAnUngThuHacTo.QuanAo));
                Command.Parameters.Add(new MDB.MDBParameter("KemChongNang", BenhAnUngThuHacTo.KemChongNang));
                Command.Parameters.Add(new MDB.MDBParameter("PhuongPhapKhac", BenhAnUngThuHacTo.PhuongPhapKhac));
                Command.Parameters.Add(new MDB.MDBParameter("DungThuocUCMD", BenhAnUngThuHacTo.DungThuocUCMD));
                Command.Parameters.Add(new MDB.MDBParameter("GhepTangCuThe", BenhAnUngThuHacTo.GhepTangCuThe));
                Command.Parameters.Add(new MDB.MDBParameter("NhiemHIVAIDS", BenhAnUngThuHacTo.NhiemHIVAIDS));
                Command.Parameters.Add(new MDB.MDBParameter("SuyGiamMienDich_Khac", BenhAnUngThuHacTo.SuyGiamMienDich_Khac));
                Command.Parameters.Add(new MDB.MDBParameter("CoNguoiBiUngThuDa", BenhAnUngThuHacTo.CoNguoiBiUngThuDa));
                Command.Parameters.Add(new MDB.MDBParameter("LoaiUngThuDa", BenhAnUngThuHacTo.LoaiUngThuDa));
                Command.Parameters.Add(new MDB.MDBParameter("CoNguoiBiUngThuKhac", BenhAnUngThuHacTo.CoNguoiBiUngThuKhac));
                Command.Parameters.Add(new MDB.MDBParameter("LoaiUngThuKhac", BenhAnUngThuHacTo.LoaiUngThuKhac));
                Command.Parameters.Add(new MDB.MDBParameter("TienSuGiaDinh_Khac", BenhAnUngThuHacTo.TienSuGiaDinh_Khac));
                Command.Parameters.Add(new MDB.MDBParameter("ToanThan", BenhAnUngThuHacTo.ToanThan));
                Command.Parameters.Add(new MDB.MDBParameter("CacBoPhan", BenhAnUngThuHacTo.CacBoPhan));
                Command.Parameters.Add(new MDB.MDBParameter("TypDa", BenhAnUngThuHacTo.TypDa));
                Command.Parameters.Add(new MDB.MDBParameter("ThuongTonCoBan", BenhAnUngThuHacTo.ThuongTonCoBan));
                Command.Parameters.Add(new MDB.MDBParameter("DoiXung", BenhAnUngThuHacTo.DoiXung));
                Command.Parameters.Add(new MDB.MDBParameter("Bo", BenhAnUngThuHacTo.Bo));
                Command.Parameters.Add(new MDB.MDBParameter("MauSac", BenhAnUngThuHacTo.MauSac));
                Command.Parameters.Add(new MDB.MDBParameter("DuongKinh", BenhAnUngThuHacTo.DuongKinh));
                Command.Parameters.Add(new MDB.MDBParameter("TienTrien", BenhAnUngThuHacTo.TienTrien));
                Command.Parameters.Add(new MDB.MDBParameter("Loet", BenhAnUngThuHacTo.Loet));
                Command.Parameters.Add(new MDB.MDBParameter("RanhGioi", BenhAnUngThuHacTo.RanhGioi));
                Command.Parameters.Add(new MDB.MDBParameter("KichThuoc", BenhAnUngThuHacTo.KichThuoc));
                Command.Parameters.Add(new MDB.MDBParameter("SoLuong", BenhAnUngThuHacTo.SoLuong));
                Command.Parameters.Add(new MDB.MDBParameter("Hach", BenhAnUngThuHacTo.Hach));
                Command.Parameters.Add(new MDB.MDBParameter("ViTriSoLuongHach", BenhAnUngThuHacTo.ViTriSoLuongHach));
                Command.Parameters.Add(new MDB.MDBParameter("BatThuongBoPhanKhac", BenhAnUngThuHacTo.BatThuongBoPhanKhac));
                Command.Parameters.Add(new MDB.MDBParameter("HC", BenhAnUngThuHacTo.HC));
                Command.Parameters.Add(new MDB.MDBParameter("Hb", BenhAnUngThuHacTo.Hb));
                Command.Parameters.Add(new MDB.MDBParameter("BC", BenhAnUngThuHacTo.BC));
                Command.Parameters.Add(new MDB.MDBParameter("Lympho", BenhAnUngThuHacTo.Lympho));
                Command.Parameters.Add(new MDB.MDBParameter("TC", BenhAnUngThuHacTo.TC));
                Command.Parameters.Add(new MDB.MDBParameter("NhomMau", BenhAnUngThuHacTo.NhomMau));
                Command.Parameters.Add(new MDB.MDBParameter("Glucose", BenhAnUngThuHacTo.Glucose));
                Command.Parameters.Add(new MDB.MDBParameter("Ure", BenhAnUngThuHacTo.Ure));
                Command.Parameters.Add(new MDB.MDBParameter("Creatinin", BenhAnUngThuHacTo.Creatinin));
                Command.Parameters.Add(new MDB.MDBParameter("Cholesterol", BenhAnUngThuHacTo.Cholesterol));
                Command.Parameters.Add(new MDB.MDBParameter("Triglycerid", BenhAnUngThuHacTo.Triglycerid));
                Command.Parameters.Add(new MDB.MDBParameter("HDLC", BenhAnUngThuHacTo.HDLC));
                Command.Parameters.Add(new MDB.MDBParameter("LDLC", BenhAnUngThuHacTo.LDLC));
                Command.Parameters.Add(new MDB.MDBParameter("GOT", BenhAnUngThuHacTo.GOT));
                Command.Parameters.Add(new MDB.MDBParameter("GPT", BenhAnUngThuHacTo.GPT));
                Command.Parameters.Add(new MDB.MDBParameter("ProteinTP", BenhAnUngThuHacTo.ProteinTP));
                Command.Parameters.Add(new MDB.MDBParameter("Albumin", BenhAnUngThuHacTo.Albumin));
                Command.Parameters.Add(new MDB.MDBParameter("Na", BenhAnUngThuHacTo.Na));
                Command.Parameters.Add(new MDB.MDBParameter("K", BenhAnUngThuHacTo.K));
                Command.Parameters.Add(new MDB.MDBParameter("Cl", BenhAnUngThuHacTo.Cl));
                Command.Parameters.Add(new MDB.MDBParameter("HinhAnhDermoscopy", BenhAnUngThuHacTo.HinhAnhDermoscopy));
                Command.Parameters.Add(new MDB.MDBParameter("XQuang", BenhAnUngThuHacTo.XQuang));
                Command.Parameters.Add(new MDB.MDBParameter("SieuAm", BenhAnUngThuHacTo.SieuAm));
                Command.Parameters.Add(new MDB.MDBParameter("CLVT", BenhAnUngThuHacTo.CLVT));
                Command.Parameters.Add(new MDB.MDBParameter("PET", BenhAnUngThuHacTo.PET));
                Command.Parameters.Add(new MDB.MDBParameter("ChanDoanHinhAnh_Khac", BenhAnUngThuHacTo.ChanDoanHinhAnh_Khac));
                Command.Parameters.Add(new MDB.MDBParameter("TheMoHoc", BenhAnUngThuHacTo.TheMoHoc));
                Command.Parameters.Add(new MDB.MDBParameter("DoBietHoa", BenhAnUngThuHacTo.DoBietHoa));
                Command.Parameters.Add(new MDB.MDBParameter("XamLanThanKinh", BenhAnUngThuHacTo.XamLanThanKinh));
                Command.Parameters.Add(new MDB.MDBParameter("XamLanMachMau", BenhAnUngThuHacTo.XamLanMachMau));
                Command.Parameters.Add(new MDB.MDBParameter("ChiSoPhanBao", BenhAnUngThuHacTo.ChiSoPhanBao));
                Command.Parameters.Add(new MDB.MDBParameter("ChiSoBreslow", BenhAnUngThuHacTo.ChiSoBreslow));
                Command.Parameters.Add(new MDB.MDBParameter("ChiSoClark", BenhAnUngThuHacTo.ChiSoClark));
                Command.Parameters.Add(new MDB.MDBParameter("LoetViThe", BenhAnUngThuHacTo.LoetViThe));
                Command.Parameters.Add(new MDB.MDBParameter("TonThuongVeTinh", BenhAnUngThuHacTo.TonThuongVeTinh));
                Command.Parameters.Add(new MDB.MDBParameter("S100", BenhAnUngThuHacTo.S100));
                Command.Parameters.Add(new MDB.MDBParameter("Ki67", BenhAnUngThuHacTo.Ki67));
                Command.Parameters.Add(new MDB.MDBParameter("Vimentine", BenhAnUngThuHacTo.Vimentine));
                Command.Parameters.Add(new MDB.MDBParameter("HMB45", BenhAnUngThuHacTo.HMB45));
                Command.Parameters.Add(new MDB.MDBParameter("CD34", BenhAnUngThuHacTo.CD34));
                Command.Parameters.Add(new MDB.MDBParameter("CK", BenhAnUngThuHacTo.CK));
                Command.Parameters.Add(new MDB.MDBParameter("HoaMoMienDich_Khac", BenhAnUngThuHacTo.HoaMoMienDich_Khac));
                Command.Parameters.Add(new MDB.MDBParameter("ChocHutTeBao_HachViem", BenhAnUngThuHacTo.ChocHutTeBao_HachViem));
                Command.Parameters.Add(new MDB.MDBParameter("ChocHutTeBao_HachDiCan", BenhAnUngThuHacTo.ChocHutTeBao_HachDiCan));
                Command.Parameters.Add(new MDB.MDBParameter("ChocHutTeBaoHach_ViTri", BenhAnUngThuHacTo.ChocHutTeBaoHach_ViTri));
                Command.Parameters.Add(new MDB.MDBParameter("SinhThietHach_HachViem", BenhAnUngThuHacTo.SinhThietHach_HachViem));
                Command.Parameters.Add(new MDB.MDBParameter("SinhThietHach_HachDiCan", BenhAnUngThuHacTo.SinhThietHach_HachDiCan));
                Command.Parameters.Add(new MDB.MDBParameter("SinhThietHach_ViTri", BenhAnUngThuHacTo.SinhThietHach_ViTri));
                Command.Parameters.Add(new MDB.MDBParameter("SoLuongHachDican", BenhAnUngThuHacTo.SoLuongHachDican));
                Command.Parameters.Add(new MDB.MDBParameter("BRAF", BenhAnUngThuHacTo.BRAF));
                Command.Parameters.Add(new MDB.MDBParameter("p53", BenhAnUngThuHacTo.p53));
                Command.Parameters.Add(new MDB.MDBParameter("Patched", BenhAnUngThuHacTo.Patched));
                Command.Parameters.Add(new MDB.MDBParameter("Gen_Khac", BenhAnUngThuHacTo.Gen_Khac));
                Command.Parameters.Add(new MDB.MDBParameter("CacXetNghiemKhac", BenhAnUngThuHacTo.CacXetNghiemKhac));
                Command.Parameters.Add(new MDB.MDBParameter("TheNongSMM", BenhAnUngThuHacTo.TheNongSMM));
                Command.Parameters.Add(new MDB.MDBParameter("TheCuaDubreuih", BenhAnUngThuHacTo.TheCuaDubreuih));
                Command.Parameters.Add(new MDB.MDBParameter("TheDauCuc", BenhAnUngThuHacTo.TheDauCuc));
                Command.Parameters.Add(new MDB.MDBParameter("TheU", BenhAnUngThuHacTo.TheU));
                Command.Parameters.Add(new MDB.MDBParameter("TheUngThu_Khac", BenhAnUngThuHacTo.TheUngThu_Khac));
                Command.Parameters.Add(new MDB.MDBParameter("TheUngThu_ChiSoBreslow", BenhAnUngThuHacTo.TheUngThu_ChiSoBreslow));
                Command.Parameters.Add(new MDB.MDBParameter("TNM_T", BenhAnUngThuHacTo.TNM_T));
                Command.Parameters.Add(new MDB.MDBParameter("TNM_N", BenhAnUngThuHacTo.TNM_N));
                Command.Parameters.Add(new MDB.MDBParameter("TNM_M", BenhAnUngThuHacTo.TNM_M));
                Command.Parameters.Add(new MDB.MDBParameter("PhanLoaiGiaiDoan_TNM", BenhAnUngThuHacTo.PhanLoaiGiaiDoan_TNM));
                Command.Parameters.Add(new MDB.MDBParameter("CatRongCoDien", BenhAnUngThuHacTo.CatRongCoDien));
                Command.Parameters.Add(new MDB.MDBParameter("CatBoThuongTon", BenhAnUngThuHacTo.CatBoThuongTon));
                Command.Parameters.Add(new MDB.MDBParameter("Mosh", BenhAnUngThuHacTo.Mosh));
                Command.Parameters.Add(new MDB.MDBParameter("SoLuongCatMosh", BenhAnUngThuHacTo.SoLuongCatMosh));
                Command.Parameters.Add(new MDB.MDBParameter("TuLien", BenhAnUngThuHacTo.TuLien));
                Command.Parameters.Add(new MDB.MDBParameter("GhepDa", BenhAnUngThuHacTo.GhepDa));
                Command.Parameters.Add(new MDB.MDBParameter("VatTaiCho", BenhAnUngThuHacTo.VatTaiCho));
                Command.Parameters.Add(new MDB.MDBParameter("VatXa", BenhAnUngThuHacTo.VatXa));
                Command.Parameters.Add(new MDB.MDBParameter("VatTuDo", BenhAnUngThuHacTo.VatTuDo));
                Command.Parameters.Add(new MDB.MDBParameter("TaoHinhKhuyetDa_Khac", BenhAnUngThuHacTo.TaoHinhKhuyetDa_Khac));
                Command.Parameters.Add(new MDB.MDBParameter("NaoVetHach_ToanBo", BenhAnUngThuHacTo.NaoVetHach_ToanBo));
                Command.Parameters.Add(new MDB.MDBParameter("NaoVetHach_ChonLoc", BenhAnUngThuHacTo.NaoVetHach_ChonLoc));
                Command.Parameters.Add(new MDB.MDBParameter("TiaXaHoaChat", BenhAnUngThuHacTo.TiaXaHoaChat));
                Command.Parameters.Add(new MDB.MDBParameter("DieuTri_PhuongPhapKhac", BenhAnUngThuHacTo.DieuTri_PhuongPhapKhac));
                Command.Parameters.Add(new MDB.MDBParameter("PhauThuatLanh", BenhAnUngThuHacTo.PhauThuatLanh));
                Command.Parameters.Add(new MDB.MDBParameter("HoaChatTaiCho", BenhAnUngThuHacTo.HoaChatTaiCho));
                Command.Parameters.Add(new MDB.MDBParameter("TenThuoc", BenhAnUngThuHacTo.TenThuoc));
                Command.Parameters.Add(new MDB.MDBParameter("PhaHuyBangNhiet", BenhAnUngThuHacTo.PhaHuyBangNhiet));
                Command.Parameters.Add(new MDB.MDBParameter("TongKet_QuaTrinhBenhLy", BenhAnUngThuHacTo.TongKet_QuaTrinhBenhLy));
                Command.Parameters.Add(new MDB.MDBParameter("TomTatKetQua", BenhAnUngThuHacTo.TomTatKetQua));
                Command.Parameters.Add(new MDB.MDBParameter("BenhChinh", BenhAnUngThuHacTo.BenhChinh));
                Command.Parameters.Add(new MDB.MDBParameter("MaBenhChinh", BenhAnUngThuHacTo.MaBenhChinh));
                Command.Parameters.Add(new MDB.MDBParameter("BenhKemTheo", BenhAnUngThuHacTo.BenhKemTheo));
                Command.Parameters.Add(new MDB.MDBParameter("MaBenhKemTheo", BenhAnUngThuHacTo.MaBenhKemTheo));
                Command.Parameters.Add(new MDB.MDBParameter("PhuongPhapDieuTri", BenhAnUngThuHacTo.PhuongPhapDieuTri));
                Command.Parameters.Add(new MDB.MDBParameter("TinhTrangRaVien", BenhAnUngThuHacTo.TinhTrangRaVien));
                Command.Parameters.Add(new MDB.MDBParameter("HuongDieuTri", BenhAnUngThuHacTo.HuongDieuTri));
                Command.Parameters.Add(new MDB.MDBParameter("NguoiNhanHoSo", BenhAnUngThuHacTo.NguoiNhanHoSo));
                Command.Parameters.Add(new MDB.MDBParameter("NguoiGiaoHoSo", BenhAnUngThuHacTo.NguoiGiaoHoSo));
                Command.Parameters.Add(new MDB.MDBParameter("NgayTongKet", BenhAnUngThuHacTo.NgayTongKet));
                Command.Parameters.Add(new MDB.MDBParameter("TongKet_BacSyDieuTri", BenhAnUngThuHacTo.TongKet_BacSyDieuTri));
                Command.Parameters.Add(new MDB.MDBParameter("TongKet_MaBacSyDieuTri", BenhAnUngThuHacTo.TongKet_MaBacSyDieuTri));
                Command.Parameters.Add(new MDB.MDBParameter("TheoDoiDieuTris", JsonConvert.SerializeObject(BenhAnUngThuHacTo.TheoDoiDieuTris)));
                Command.Parameters.Add(new MDB.MDBParameter("ThoiGianSongSauDieuTri", BenhAnUngThuHacTo.ThoiGianSongSauDieuTri));
                Command.Parameters.Add(new MDB.MDBParameter("ChayMau", BenhAnUngThuHacTo.ChayMau));
                Command.Parameters.Add(new MDB.MDBParameter("TuMau", BenhAnUngThuHacTo.TuMau));
                Command.Parameters.Add(new MDB.MDBParameter("NhiemTrung", BenhAnUngThuHacTo.NhiemTrung));
                Command.Parameters.Add(new MDB.MDBParameter("LauLienVetMo", BenhAnUngThuHacTo.LauLienVetMo));
                Command.Parameters.Add(new MDB.MDBParameter("SeoXau", BenhAnUngThuHacTo.SeoXau));
                Command.Parameters.Add(new MDB.MDBParameter("PhuBachMach", BenhAnUngThuHacTo.PhuBachMach));
                Command.Parameters.Add(new MDB.MDBParameter("AnhHuongChucNang", BenhAnUngThuHacTo.AnhHuongChucNang));
                Command.Parameters.Add(new MDB.MDBParameter("BienChungXa_Khac", BenhAnUngThuHacTo.BienChungXa_Khac));


                Command.BindByName = true;

                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", BenhAnUngThuHacTo.MaQuanLy));
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
        public static string DownloadFile(string FileHinhAnh, string tempPath)
        {
            string fullPath = "";
            string pathLocalAnh = string.Empty;
            using (var client = new HttpClient())
            {
                try
                {
                    string URL = ERMDatabase.WebServiceEMR;
                    client.BaseAddress = new Uri(URL);
                    client.DefaultRequestHeaders.Accept.Clear();
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                    client.Timeout = new TimeSpan(0, 0, 1000);
                    string fileName = FileHinhAnh.Trim('\\') + "\\" + XemBenhAn._ThongTinDieuTri.MaQuanLy + ".png";
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
                                BitmapImage image = Common.CreateBitmapFromSource(fileHinhAnh);
                                    
                                pathLocalAnh = fileHinhAnh;
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    XuLyLoi.LogError(ex);
                    MessageBox.Show("Lỗi download file\nKiểm tra lại webservice " + ERMDatabase.WebServiceEMR);
                }
            }
            return pathLocalAnh;
        }
    }
}
