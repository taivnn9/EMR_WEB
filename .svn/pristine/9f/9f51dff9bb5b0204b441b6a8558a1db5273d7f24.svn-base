using System.Data;

namespace EMR_MAIN
{
    public class BenhAnMatBanPhanTruocFunc
    {
        public static void WriteXml(MDB.MDBConnection MyConnection)
        {
            string sql =
                   @"
                  select  a.*,  CTScanner HoSo_CTScanner, SieuAm HoSo_SieuAm, XetNghiem HoSo_XetNghiem,  Khac HoSo_Khac,  Khac_Text HoSo_Khac_Text,  ToanBoHoSo HoSo_ToanBoHoSo, Mach DauSinhTon_Mach,  NhietDo DauSinhTon_NhietDo,  HuyetAp DauSinhTon_HuyetAp,  NhipTho DauSinhTon_NhipTho,  CanNang DauSinhTon_CanNang  
                  from BenhAnMatBanPhanTruoc a inner join thongtindieutri b on a.maquanly = b.maquanly
                  where rownum = 1
                    ";
            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
            MDB.MDBDataReader DataReader = Command.ExecuteReader();

            var DataTable = new DataTable { TableName = "BenhAnMatBanPhanTruoc" };
            DataTable.Load(DataReader as IDataReader);
            DataTable.WriteXml("rptBenhAnMatBanPhanTruoc.xml");
        }
        public static DataSet SelectDataSet(MDB.MDBConnection MyConnection, decimal MaQuanLy)
        {
            string sql =
                   @"
                 select  a.*,f.hovaten BacSyLamBenhAnHoVaTen ,c.hovaten BacSyDieuTriHoVaTen,d.hovaten NguoiGiaoHoSoHoVaTen,e.hovaten NguoiNhanHoSoHoVaTen, b.XQuang HoSo_XQuang,   b.CTScanner HoSo_CTScanner, b.SieuAm HoSo_SieuAm, b.XetNghiem HoSo_XetNghiem,  b.Khac HoSo_Khac,  b.Khac_Text HoSo_Khac_Text,  b.ToanBoHoSo HoSo_ToanBoHoSo, b.Mach DauSinhTon_Mach, b.NhietDo DauSinhTon_NhietDo,  b.HuyetAp DauSinhTon_HuyetAp,  b.NhipTho DauSinhTon_NhipTho,  b.CanNang DauSinhTon_CanNang  , b.ChieuCao DauSinhTon_ChieuCao, b.BMI DauSinhTon_BMI, b.NgayRaVien 
                 from BenhAnMatBanPhanTruoc a 
                 left join thongtindieutri b on a.maquanly = b.maquanly 
                  left join nhanvien c on a.bacsydieutri = c.manhanvien
                  left join nhanvien d on a.nguoigiaohoso = d.manhanvien
                  left join nhanvien e on a.nguoinhanhoso = e.manhanvien
                  left join nhanvien f on a.BacSyLamBenhAn = f.manhanvien
                  where a.maquanly = " + MaQuanLy.ToString(System.Globalization.CultureInfo.InvariantCulture);
            MDB.MDBDataAdapter adt = new MDB.MDBDataAdapter(sql, MyConnection);
            var ds = new DataSet();
            adt.Fill(ds, "Table");


            string sql2 =
                @"select a.*,c.hovaten BacSyPhauThuatHoVaTen, d.hovaten BacSyGayMeHoVaTen
                  from PhauThuatThuThuat a
                  left join nhanvien c on a.bacsyphauthuat  = c.manhanvien
                  left join nhanvien d on a.bacsygayme= d.manhanvien
                  where a.maquanly = " + MaQuanLy.ToString(System.Globalization.CultureInfo.InvariantCulture);
            adt = new MDB.MDBDataAdapter(sql2, MyConnection);
            adt.Fill(ds, "Table2");
            return ds;
        }
        public static BenhAnMatBanPhanTruoc Select(MDB.MDBConnection MyConnection, decimal MaQuanLy)
        {
            #region
            string sql =
                      @"select * 
                        from BenhAnMatBanPhanTruoc a
                        where MaQuanLy = :MaQuanLy";
            #endregion
            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
            Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", MaQuanLy));
            MDB.MDBDataReader DataReader = Command.ExecuteReader();
            var value = new BenhAnMatBanPhanTruoc();
            value.DacDiemLienQuanBenh = new DacDiemLienQuanBenh();
            while (DataReader.Read())
            {
                value.MaQuanLy =  DataReader.GetDecimal("MaQuanLy");
                value.LyDoVaoVien = DataReader["LyDoVaoVien"].ToString();
                value.VaoNgayThu = DataReader.GetInt("VaoNgayThu");
                value.QuaTrinhBenhLy = DataReader["QuaTrinhBenhLy"].ToString();
                value.TienSuBenhBanThan = DataReader["TienSuBenhBanThan"].ToString();
                value.TienSuBenhGiaDinh = DataReader["TienSuBenhGiaDinh"].ToString();
                value.ToanThan = DataReader["ToanThan"].ToString();
                value.TuanHoan = DataReader["TuanHoan"].ToString();
                value.HoHap = DataReader["HoHap"].ToString();
                value.TieuHoa = DataReader["TieuHoa"].ToString();
                value.ThanTietNieuSinhDuc = DataReader["ThanTietNieuSinhDuc"].ToString();
                value.ThanKinh = DataReader["ThanKinh"].ToString();
                value.CoXuongKhop = DataReader["CoXuongKhop"].ToString();
                value.TaiMuiHong = DataReader["TaiMuiHong"].ToString();
                value.RangHamMat = DataReader["RangHamMat"].ToString();
                value.Mat = DataReader["Mat"].ToString();
                value.Khac_CacCoQuan = DataReader["Khac_CacCoQuan"].ToString();
                value.CacXetNghiemCanLamSangCanLam = DataReader["CacXetNghiemCanLamSangCanLam"].ToString();
                value.TomTatBenhAn = DataReader["TomTatBenhAn"].ToString();
                value.BenhChinh = DataReader["BenhChinh"].ToString();
                value.BenhKemTheo = DataReader["BenhKemTheo"].ToString();
                value.PhanBiet = DataReader["PhanBiet"].ToString();
                value.TienLuong = DataReader["TienLuong"].ToString();
                value.HuongDieuTri = DataReader["HuongDieuTri"].ToString();
                value.NgayKhamBenh = DataReader.GetDate("NgayKhamBenh");
                value.BacSyLamBenhAn = DataReader["BacSyLamBenhAn"].ToString();
                value.QuaTrinhBenhLyVaDienBien = DataReader["QuaTrinhBenhLyVaDienBien"].ToString();
                value.TomTatKetQuaXetNghiem = DataReader["TomTatKetQuaXetNghiem"].ToString();
                value.PhuongPhapDieuTri = DataReader["PhuongPhapDieuTri"].ToString();
                value.TinhTrangNguoiBenhRaVien = DataReader["TinhTrangNguoiBenhRaVien"].ToString();
                value.HuongDieuTriVaCacCheDoTiepTheo = DataReader["HuongDieuTriVaCacCheDoTiepTheo"].ToString();
                value.NguoiNhanHoSo = DataReader["NguoiNhanHoSo"].ToString();
                value.NguoiGiaoHoSo = DataReader["NguoiGiaoHoSo"].ToString();
                value.NgayTongKet = DataReader.GetDate("NgayTongKet");
                value.BacSyDieuTri = DataReader["BacSyDieuTri"].ToString();
                value.DacDiemLienQuanBenh.DiUng = DataReader["DiUng"].ToString() == "1" ? true : false;
                value.DacDiemLienQuanBenh.DiUng_Text = DataReader["DiUng_Text"].ToString();
                value.DacDiemLienQuanBenh.Khac_DacDiemLienQuanBenh = DataReader["Khac_DacDiemLienQuanBenh"].ToString() == "1" ? true : false;
                value.DacDiemLienQuanBenh.Khac_DacDiemLienQuanBenh_Text = DataReader["Khac_DacDiemLienQuanBenh_Text"].ToString();
                value.DacDiemLienQuanBenh.MaTuy = DataReader["MaTuy"].ToString() == "1" ? true : false;
                value.DacDiemLienQuanBenh.MaTuy_Text = DataReader["MaTuy_Text"].ToString();
                value.DacDiemLienQuanBenh.RuouBia = DataReader["RuouBia"].ToString() == "1" ? true : false;
                value.DacDiemLienQuanBenh.RuouBia_Text = DataReader["RuouBia_Text"].ToString();
                value.DacDiemLienQuanBenh.ThuocLa = DataReader["ThuocLa"].ToString() == "1" ? true : false;
                value.DacDiemLienQuanBenh.ThuocLa_Text = DataReader["ThuocLa_Text"].ToString();
                value.DacDiemLienQuanBenh.ThuocLao = DataReader["ThuocLao"].ToString() == "1" ? true : false;
                value.DacDiemLienQuanBenh.ThuocLao_Text = DataReader["ThuocLao_Text"].ToString();
                value.ThoiGianXuatHienBenh = DataReader["ThoiGianXuatHienBenh"].ToString();
                value.NguyenNhan_BenhSu = DataReader["NguyenNhan_BenhSu"].ToString();
                value.CacPhuongPhapDaDieuTri_BenhSu = DataReader["CacPhuongPhapDaDieuTri_BenhSu"].ToString();
                value.TienSuBenhBanThan_Mat = DataReader["TienSuBenhBanThan_Mat"].ToString();
                value.TienSuBenhGiaDinh_Mat = DataReader["TienSuBenhGiaDinh_Mat"].ToString();
                value.KhongKinh_ThiLuc_MP = DataReader["KhongKinh_ThiLuc_MP"].ToString();
                value.QuaLo_ThiLuc_MP = DataReader["QuaLo_ThiLuc_MP"].ToString();
                value.CoChinhKinh_ThiLuc_MP = DataReader["CoChinhKinh_ThiLuc_MP"].ToString();
                value.NhinGan_ThiLuc_MP = DataReader["NhinGan_ThiLuc_MP"].ToString();
                value.NhanAp_MP = DataReader["NhanAp_MP"].ToString();
                value.LacVaVanNhan_MP = DataReader["LacVaVanNhan_MP"].ToString();
                value.ThoatNuocTot_MP = DataReader["ThoatNuocTot_MP"].ToString() == "1" ? true : false;
                value.TraoLeQuanDoiDien_MP = DataReader["TraoLeQuanDoiDien_MP"].ToString() == "1" ? true : false;
                value.TraoLeQuanTaiCho_MP = DataReader["TraoLeQuanTaiCho_MP"].ToString() == "1" ? true : false;
                value.MiMat_MP = DataReader.GetInt("MiMat_MP");
                value.Khac_MiMat_MP = DataReader["Khac_MiMat_MP"].ToString();
                value.UMi_MP = DataReader["UMi_MP"].ToString() == "1" ? true : false;
                value.TinhChatU_UMi_MP = DataReader["TinhChatU_UMi_MP"].ToString();
                value.ViTri_UMi_MP = DataReader["ViTri_UMi_MP"].ToString();
                value.KichThuoc_UMi_MP = DataReader["KichThuoc_UMi_MP"].ToString();
                value.iQuam_MiMat_MP = DataReader.GetInt("Quam_MiMat_MP");
                value.MiTren_MiMat_MP = DataReader.GetInt("MiTren_MiMat_MP");
                value.MiDuoi_MiMat_MP = DataReader.GetInt("MiDuoi_MiMat_MP");
                value.HoMi_MiMat_MP = DataReader["HoMi_MiMat_MP"].ToString() == "1" ? true : false;
                value.TreMi_MiMat_MP = DataReader["TreMi_MiMat_MP"].ToString() == "1" ? true : false;
                value.KhuyetMi_MiMat_MP = DataReader.GetInt("KhuyetMi_MiMat_MP");
                value.TuyetBoMi_MiMat_MP = DataReader.GetInt("TuyetBoMi_MiMat_MP");
                value.ViemBoMi_MiMat_MP = DataReader["ViemBoMi_MiMat_MP"].ToString() == "1" ? true : false;
                value.TonThuongKhac_MiMat_MP = DataReader["TonThuongKhac_MiMat_MP"].ToString();
                value.CuongTu_KetMac_MP = DataReader.GetInt("CuongTu_KetMac_MP");
                value.PhuNe_KetMac_MP = DataReader["PhuNe_KetMac_MP"].ToString() == "1" ? true : false;
                value.XuatHuyet_KetMac_MP = DataReader["XuatHuyet_KetMac_MP"].ToString() == "1" ? true : false;
                value.SungHoa_KetMac_MP = DataReader["SungHoa_KetMac_MP"].ToString() == "1" ? true : false;
                value.Nhu_KetMac_MP = DataReader["Nhu_KetMac_MP"].ToString() == "1" ? true : false;
                value.Hot_KetMac_MP = DataReader["Hot_KetMac_MP"].ToString() == "1" ? true : false;
                value.Seo_KetMac_MP = DataReader["Seo_KetMac_MP"].ToString() == "1" ? true : false;
                value.TietToMu_KetMac_MP = DataReader["TietToMu_KetMac_MP"].ToString() == "1" ? true : false;
                value.TietToTrong_KetMac_MP = DataReader["TietToTrong_KetMac_MP"].ToString() == "1" ? true : false;
                value.GiaMac_KetMac_MP = DataReader["GiaMac_KetMac_MP"].ToString() == "1" ? true : false;
                value.BatMauFluor_KetMac_MP = DataReader["BatMauFluor_KetMac_MP"].ToString() == "1" ? true : false;
                value.TinhChat_UKetMac_MP = DataReader["TinhChat_UKetMac_MP"].ToString();
                value.ViTri_UKetMac_MP = DataReader["ViTri_UKetMac_MP"].ToString();
                value.KichThuoc_UKetMac_MP = DataReader["KichThuoc_UKetMac_MP"].ToString();
                value.CungDo_KetMac_MP = DataReader.GetInt("CungDo_KetMac_MP");
                value.ChieuCaoCuaCauDinh_KetMac_MP = DataReader.GetInt("ChieuCaoCuaCauDinh_KetMac_MP");
                value.DoRongCuaCauDinh_KetMac_MP = DataReader.GetInt("DoRongCuaCauDinh_KetMac_MP");
                value.TonThuongKhac_KetMac_MP = DataReader["TonThuongKhac_KetMac_MP"].ToString();
                value.KichThuoc_GiacMac_MP = DataReader.GetInt("KichThuoc_GiacMac_MP");
                value.HinhDang_GiacMac_MP = DataReader.GetInt("HinhDang_GiacMac_MP");
                value.BieuMo_GiacMac_MP = DataReader["BieuMo_GiacMac_MP"].ToString() == "1" ? true : false;
                value.PhuBongBieuMo_GiacMac_MP = DataReader.GetInt("PhuBongBieuMo_GiacMac_MP");
                value.MatBieuMo_GiacMac_MP = DataReader.GetInt("MatBieuMo_GiacMac_MP");
                value.MatBieuMoKhoangCach_MP = DataReader.GetInt("MatBieuMoKhoangCach_MP");
                value.BoTonThuong_GM_MP = DataReader.GetInt("BoTonThuong_GM_MP");
                value.ThoaiThoaDaiBang_MP = DataReader["ThoaiThoaDaiBang_MP"].ToString() == "1" ? true : false;
                value.LangDongThuoc_MP = DataReader["LangDongThuoc_MP"].ToString() == "1" ? true : false;
                value.TonThuongKhac_BieuMo_GM_MP = DataReader["TonThuongKhac_BieuMo_GM_MP"].ToString();
                value.Phu_NhuMo_GiacMac_MP = DataReader.GetInt("Phu_NhuMo_GiacMac_MP");
                value.ThamLau_NhuMo_GiacMac_MP = DataReader.GetInt("ThamLau_NhuMo_GiacMac_MP");
                value.ThamLau_Vtri_NhuMo_GiacMac_MP = DataReader.GetInt("ThamLau_Vtri_NhuMo_GiacMac_MP");
                value.TieuMong_NhuMo_GiacMac_MP = DataReader.GetInt("TieuMong_NhuMo_GiacMac_MP");
                value.TieuMong_Vtri_NhuMo_GiacMac_MP = DataReader.GetInt("TieuMong_Vtri_NhuMo_GiacMac_MP");
                value.TonThuongKhac_NhuMo_GiacMac_MP = DataReader["TonThuongKhac_NhuMo_GiacMac_MP"].ToString();
                value.NepGap_NoiMo_GiacMac_MP = DataReader.GetInt("NepGap_NoiMo_GiacMac_MP");
                value.TuaSacToMacSauGM_MP = DataReader["TuaSacToMacSauGM_MP"].ToString() == "1" ? true : false;
                value.MuMatSau_NoiMo_MP = DataReader["MuMatSau_NoiMo_MP"].ToString() == "1" ? true : false;
                value.XuatTietMatSau_NoiMo_MP = DataReader["XuatTietMatSau_NoiMo_MP"].ToString() == "1" ? true : false;
                value.Guttata_NoiMo_MP = DataReader["Guttata_NoiMo_MP"].ToString() == "1" ? true : false;
                value.RanMangDescemet_NoiMo_MP = DataReader["RanMangDescemet_NoiMo_MP"].ToString() == "1" ? true : false;
                value.CuonDescemet_NoiMo_MP = DataReader["CuonDescemet_NoiMo_MP"].ToString() == "1" ? true : false;
                value.TonThuongKhac_NoiMo_MP = DataReader["TonThuongKhac_NoiMo_MP"].ToString();
                value.DoaThung_GiacMac_MP = DataReader["DoaThung_GiacMac_MP"].ToString() == "1" ? true : false;
                value.KetMongMat_GiacMac_MP = DataReader["KetMongMat_GiacMac_MP"].ToString() == "1" ? true : false;
                value.ThungGiacMac_MP = DataReader.GetInt("ThungGiacMac_MP");
                value.Seidel_MP = DataReader["Seidel_MP"].ToString() == "1" ? true : false;
                value.DuongKinhThungGiacMac_MP = DataReader["DuongKinhThungGiacMac_MP"].ToString();
                value.iThungBit_GM_MP = DataReader.GetInt("ThungBit_GM_MP");
                value.CamGiacGiacMac_MP = DataReader.GetInt("CamGiacGiacMac_MP");
                value.TanMach_GiacMac_MP = DataReader.GetInt("TanMach_GiacMac_MP");
                value.MucDo_TanMach_GiacMac_MP = DataReader.GetInt("MucDo_TanMach_GiacMac_MP");
                value.SuyTeBaoNguon_MP = DataReader["SuyTeBaoNguon_MP"].ToString() == "1" ? true : false;
                value.ThoaiHoaGia_MP = DataReader["ThoaiHoaGia_MP"].ToString() == "1" ? true : false;
                value.LangDongCanXi_MP = DataReader["LangDongCanXi_MP"].ToString() == "1" ? true : false;
                value.BatThuongKhac_GiacMac_MP = DataReader["BatThuongKhac_GiacMac_MP"].ToString();
                value.Viem_CungMac_MP = DataReader.GetInt("Viem_CungMac_MP");
                value.iViem_NongSau_CungMac_MP = DataReader.GetInt("Viem_NongSau_CungMac_MP");
                value.ViemThuongCungMac_MP = DataReader["ViemThuongCungMac_MP"].ToString() == "1" ? true : false;
                value.GianLoi_TieuMong_HoaiTu_MP = DataReader.GetInt("GianLoi_TieuMong_HoaiTu_MP");
                value.ChiTietKhac_CungMac_MP = DataReader["ChiTietKhac_CungMac_MP"].ToString();
                value.TienPhong_MP = DataReader.GetInt("TienPhong_MP");
                value.Mu_TienPhong_MP = DataReader["Mu_TienPhong_MP"].ToString();
                value.Tydal_MP = DataReader["Tydal_MP"].ToString() == "1" ? true : false;
                value.MangXuatTiet_MP = DataReader["MangXuatTiet_MP"].ToString() == "1" ? true : false;
                value.Mau_TienPhong_MP = DataReader["Mau_TienPhong_MP"].ToString();
                value.TonThuongKhac_TienPhong_MP = DataReader["TonThuongKhac_TienPhong_MP"].ToString();
                value.NauXop_MP = DataReader["NauXop_MP"].ToString() == "1" ? true : false;
                value.XoTeo_MP = DataReader["XoTeo_MP"].ToString() == "1" ? true : false;
                value.CuongTu_MP = DataReader["CuongTu_MP"].ToString() == "1" ? true : false;
                value.TanMach_MP = DataReader["TanMach_MP"].ToString() == "1" ? true : false;
                value.Phoi_MP = DataReader["Phoi_MP"].ToString() == "1" ? true : false;
                value.Ket_MP = DataReader["Ket_MP"].ToString() == "1" ? true : false;
                value.DuongKinh_DongTu_MP = DataReader["DuongKinh_DongTu_MP"].ToString();
                value.DongTuTronMeoDinh_MP = DataReader.GetInt("DongTuTronMeoDinh_MP");
                value.ViTriDinh_DongTu_MP = DataReader["ViTriDinh_DongTu_MP"].ToString();
                value.PhanXaDongTu_MP = DataReader.GetInt("PhanXaDongTu_MP");
                value.TonThuongKhac_DongTu_MP = DataReader["TonThuongKhac_DongTu_MP"].ToString();
                value.iThuyTinhThe_MP = DataReader.GetInt("ThuyTinhThe_MP");
                value.HinhThaiDuc_ThuyTinhthe_MP = DataReader["HinhThaiDuc_ThuyTinhthe_MP"].ToString();
                value.IOL_CanLechDuc_MP = DataReader.GetInt("IOL_CanLechDuc_MP");
                value.iIOL_TrongTPHP_MP = DataReader.GetInt("IOL_TrongTPHP_MP");
                value.TonThuongKhac_ThuyTinhthe_MP = DataReader["TonThuongKhac_ThuyTinhthe_MP"].ToString();
                value.AnhDongTu_MP = DataReader.GetInt("AnhDongTu_MP");
                value.DichKinh_MP = DataReader.GetInt("DichKinh_MP");
                value.TonThuongKhac_DichKinh_MP = DataReader["TonThuongKhac_DichKinh_MP"].ToString();
                value.DayMat_MP = DataReader.GetInt("DayMat_MP");
                value.CD_DayMat_MP = DataReader["CD_DayMat_MP"].ToString();
                value.PhuGai_MP = DataReader["PhuGai_MP"].ToString() == "1" ? true : false;
                value.BacMauGaiThi_MP = DataReader["BacMauGaiThi_MP"].ToString() == "1" ? true : false;
                value.VongMac_DayMat_MP = DataReader["VongMac_DayMat_MP"].ToString();
                value.HeMachMau_DayMat_MP = DataReader["HeMachMau_DayMat_MP"].ToString();
                value.TonThuongKhac_DayMat_MP = DataReader["TonThuongKhac_DayMat_MP"].ToString();
                value.KhongKinh_ThiLuc_MT = DataReader["KhongKinh_ThiLuc_MT"].ToString();
                value.QuaLo_ThiLuc_MT = DataReader["QuaLo_ThiLuc_MT"].ToString();
                value.CoChinhKinh_ThiLuc_MT = DataReader["CoChinhKinh_ThiLuc_MT"].ToString();
                value.NhinGan_ThiLuc_MT = DataReader["NhinGan_ThiLuc_MT"].ToString();
                value.NhanAp_MT = DataReader["NhanAp_MT"].ToString();
                value.LacVaVanNhan_MT = DataReader["LacVaVanNhan_MT"].ToString();
                value.ThoatNuocTot_MT = DataReader["ThoatNuocTot_MT"].ToString() == "1" ? true : false;
                value.TraoLeQuanDoiDien_MT = DataReader["TraoLeQuanDoiDien_MT"].ToString() == "1" ? true : false;
                value.TraoLeQuanTaiCho_MT = DataReader["TraoLeQuanTaiCho_MT"].ToString() == "1" ? true : false;
                value.MiMat_MT = DataReader.GetInt("MiMat_MT");
                value.Khac_MiMat_MT = DataReader["Khac_MiMat_MT"].ToString();
                value.UMi_MT = DataReader["UMi_MT"].ToString() == "1" ? true : false;
                value.TinhChatU_UMi_MT = DataReader["TinhChatU_UMi_MT"].ToString();
                value.ViTri_UMi_MT = DataReader["ViTri_UMi_MT"].ToString();
                value.KichThuoc_UMi_MT = DataReader["KichThuoc_UMi_MT"].ToString();
                value.iQuam_MiMat_MT = DataReader.GetInt("Quam_MiMat_MT");
                value.MiTren_MiMat_MT = DataReader.GetInt("MiTren_MiMat_MT");
                value.MiDuoi_MiMat_MT = DataReader.GetInt("MiDuoi_MiMat_MT");
                value.HoMi_MiMat_MT = DataReader["HoMi_MiMat_MT"].ToString() == "1" ? true : false;
                value.TreMi_MiMat_MT = DataReader["TreMi_MiMat_MT"].ToString() == "1" ? true : false;
                value.KhuyetMi_MiMat_MT = DataReader.GetInt("KhuyetMi_MiMat_MT");
                value.TuyetBoMi_MiMat_MT = DataReader.GetInt("TuyetBoMi_MiMat_MT");
                value.ViemBoMi_MiMat_MT = DataReader["ViemBoMi_MiMat_MT"].ToString() == "1" ? true : false;
                value.TonThuongKhac_MiMat_MT = DataReader["TonThuongKhac_MiMat_MT"].ToString();
                value.CuongTu_KetMac_MT = DataReader.GetInt("CuongTu_KetMac_MT");
                value.PhuNe_KetMac_MT = DataReader["PhuNe_KetMac_MT"].ToString() == "1" ? true : false;
                value.XuatHuyet_KetMac_MT = DataReader["XuatHuyet_KetMac_MT"].ToString() == "1" ? true : false;
                value.SungHoa_KetMac_MT = DataReader["SungHoa_KetMac_MT"].ToString() == "1" ? true : false;
                value.Nhu_KetMac_MT = DataReader["Nhu_KetMac_MT"].ToString() == "1" ? true : false;
                value.Hot_KetMac_MT = DataReader["Hot_KetMac_MT"].ToString() == "1" ? true : false;
                value.Seo_KetMac_MT = DataReader["Seo_KetMac_MT"].ToString() == "1" ? true : false;
                value.TietToMu_KetMac_MT = DataReader["TietToMu_KetMac_MT"].ToString() == "1" ? true : false;
                value.TietToTrong_KetMac_MT = DataReader["TietToTrong_KetMac_MT"].ToString() == "1" ? true : false;
                value.GiaMac_KetMac_MT = DataReader["GiaMac_KetMac_MT"].ToString() == "1" ? true : false;
                value.BatMauFluor_KetMac_MT = DataReader["BatMauFluor_KetMac_MT"].ToString() == "1" ? true : false;
                value.TinhChat_UKetMac_MT = DataReader["TinhChat_UKetMac_MT"].ToString();
                value.ViTri_UKetMac_MT = DataReader["ViTri_UKetMac_MT"].ToString();
                value.KichThuoc_UKetMac_MT = DataReader["KichThuoc_UKetMac_MT"].ToString();
                value.CungDo_KetMac_MT = DataReader.GetInt("CungDo_KetMac_MT");
                value.ChieuCaoCuaCauDinh_KetMac_MT = DataReader.GetInt("ChieuCaoCuaCauDinh_KetMac_MT");
                value.DoRongCuaCauDinh_KetMac_MT = DataReader.GetInt("DoRongCuaCauDinh_KetMac_MT");
                value.TonThuongKhac_KetMac_MT = DataReader["TonThuongKhac_KetMac_MT"].ToString();
                value.KichThuoc_GiacMac_MT = DataReader.GetInt("KichThuoc_GiacMac_MT");
                value.HinhDang_GiacMac_MT = DataReader.GetInt("HinhDang_GiacMac_MT");
                value.BieuMo_GiacMac_MT = DataReader["BieuMo_GiacMac_MT"].ToString() == "1" ? true : false;
                value.PhuBongBieuMo_GiacMac_MT = DataReader.GetInt("PhuBongBieuMo_GiacMac_MT");
                value.MatBieuMo_GiacMac_MT = DataReader.GetInt("MatBieuMo_GiacMac_MT");
                value.MatBieuMoKhoangCach_MT = DataReader.GetInt("MatBieuMoKhoangCach_MT");
                value.BoTonThuong_GM_MT = DataReader.GetInt("BoTonThuong_GM_MT");
                value.ThoaiThoaDaiBang_MT = DataReader["ThoaiThoaDaiBang_MT"].ToString() == "1" ? true : false;
                value.LangDongThuoc_MT = DataReader["LangDongThuoc_MT"].ToString() == "1" ? true : false;
                value.TonThuongKhac_BieuMo_GM_MT_TXT = DataReader["TonThuongKhac_BieuMo_GM_MT_TXT"].ToString();
                value.Phu_NhuMo_GiacMac_MT = DataReader.GetInt("Phu_NhuMo_GiacMac_MT");
                value.ThamLau_NhuMo_GiacMac_MT = DataReader.GetInt("ThamLau_NhuMo_GiacMac_MT");
                value.ThamLau_Vtri_NhuMo_GiacMac_MT = DataReader.GetInt("ThamLau_Vtri_NhuMo_GiacMac_MT");
                value.TieuMong_NhuMo_GiacMac_MT = DataReader.GetInt("TieuMong_NhuMo_GiacMac_MT");
                value.TieuMong_Vtri_NhuMo_GiacMac_MT = DataReader.GetInt("TieuMong_Vtri_NhuMo_GiacMac_MT");
                value.TonThuongKhac_NhuMo_GiacMac_MT = DataReader["TonThuongKhac_NhuMo_GiacMac_MT"].ToString();
                value.NepGap_NoiMo_GiacMac_MT = DataReader.GetInt("NepGap_NoiMo_GiacMac_MT");
                value.TuaSacToMacSauGM_MT = DataReader["TuaSacToMacSauGM_MT"].ToString() == "1" ? true : false;
                value.MuMatSau_NoiMo_MT = DataReader["MuMatSau_NoiMo_MT"].ToString() == "1" ? true : false;
                value.XuatTietMatSau_NoiMo_MT = DataReader["XuatTietMatSau_NoiMo_MT"].ToString() == "1" ? true : false;
                value.Guttata_NoiMo_MT = DataReader["Guttata_NoiMo_MT"].ToString() == "1" ? true : false;
                value.RanMangDescemet_NoiMo_MT = DataReader["RanMangDescemet_NoiMo_MT"].ToString() == "1" ? true : false;
                value.CuonDescemet_NoiMo_MT = DataReader["CuonDescemet_NoiMo_MT"].ToString() == "1" ? true : false;
                value.TonThuongKhac_NoiMo_MT = DataReader["TonThuongKhac_NoiMo_MT"].ToString();
                value.DoaThung_GiacMac_MT = DataReader["DoaThung_GiacMac_MT"].ToString() == "1" ? true : false;
                value.KetMongMat_GiacMac_MT = DataReader["KetMongMat_GiacMac_MT"].ToString() == "1" ? true : false;
                value.ThungGiacMac_MT = DataReader.GetInt("ThungGiacMac_MT");
                value.Seidel_MT = DataReader["Seidel_MT"].ToString() == "1" ? true : false;
                value.DuongKinhThungGiacMac_MT = DataReader["DuongKinhThungGiacMac_MT"].ToString();
                value.iThungBit_GM_MT = DataReader.GetInt("ThungBit_GM_MT");
                value.CamGiacGiacMac_MT = DataReader.GetInt("CamGiacGiacMac_MT");
                value.TanMach_GiacMac_MT = DataReader.GetInt("TanMach_GiacMac_MT");
                value.MucDo_TanMach_GiacMac_MT = DataReader.GetInt("MucDo_TanMach_GiacMac_MT");
                value.SuyTeBaoNguon_MT = DataReader["SuyTeBaoNguon_MT"].ToString() == "1" ? true : false;
                value.ThoaiHoaGia_MT = DataReader["ThoaiHoaGia_MT"].ToString() == "1" ? true : false;
                value.LangDongCanXi_MT = DataReader["LangDongCanXi_MT"].ToString() == "1" ? true : false;
                value.BatThuongKhac_GiacMac_MT = DataReader["BatThuongKhac_GiacMac_MT"].ToString();
                value.Viem_CungMac_MT = DataReader.GetInt("Viem_CungMac_MT");
                value.iViem_NongSau_CungMac_MT = DataReader.GetInt("Viem_NongSau_CungMac_MT");
                value.ViemThuongCungMac_MT = DataReader["ViemThuongCungMac_MT"].ToString() == "1" ? true : false;
                value.GianLoi_TieuMong_HoaiTu_MT = DataReader.GetInt("GianLoi_TieuMong_HoaiTu_MT");
                value.ChiTietKhac_CungMac_MT = DataReader["ChiTietKhac_CungMac_MT"].ToString();
                value.TienPhong_MT = DataReader.GetInt("TienPhong_MT");
                value.Mu_TienPhong_MT = DataReader["Mu_TienPhong_MT"].ToString();
                value.Tydal_MT = DataReader["Tydal_MT"].ToString() == "1" ? true : false;
                value.MangXuatTiet_MT = DataReader["MangXuatTiet_MT"].ToString() == "1" ? true : false;
                value.Mau_TienPhong_MT = DataReader["Mau_TienPhong_MT"].ToString();
                value.TonThuongKhac_TienPhong_MT = DataReader["TonThuongKhac_TienPhong_MT"].ToString();
                value.NauXop_MT = DataReader["NauXop_MT"].ToString() == "1" ? true : false;
                value.XoTeo_MT = DataReader["XoTeo_MT"].ToString() == "1" ? true : false;
                value.CuongTu_MT = DataReader["CuongTu_MT"].ToString() == "1" ? true : false;
                value.TanMach_MT = DataReader["TanMach_MT"].ToString() == "1" ? true : false;
                value.Phoi_MT = DataReader["Phoi_MT"].ToString() == "1" ? true : false;
                value.Ket_MT = DataReader["Ket_MT"].ToString() == "1" ? true : false;
                value.DuongKinh_DongTu_MT = DataReader["DuongKinh_DongTu_MT"].ToString();
                value.DongTuTronMeoDinh_MT = DataReader.GetInt("DongTuTronMeoDinh_MT");
                value.ViTriDinh_DongTu_MT = DataReader["ViTriDinh_DongTu_MT"].ToString();
                value.PhanXaDongTu_MT = DataReader.GetInt("PhanXaDongTu_MT");
                value.TonThuongKhac_DongTu_MT = DataReader["TonThuongKhac_DongTu_MT"].ToString();
                value.iThuyTinhThe_MT = DataReader.GetInt("ThuyTinhThe_MT");
                value.HinhThaiDuc_ThuyTinhthe_MT = DataReader["HinhThaiDuc_ThuyTinhthe_MT"].ToString();
                value.IOL_CanLechDuc_MT = DataReader.GetInt("IOL_CanLechDuc_MT");
                value.iIOL_TrongTPHP_MT = DataReader.GetInt("IOL_TrongTPHP_MT");
                value.TonThuongKhac_ThuyTinhthe_MT = DataReader["TonThuongKhac_ThuyTinhthe_MT"].ToString();
                value.AnhDongTu_MT = DataReader.GetInt("AnhDongTu_MT");
                value.DichKinh_MT = DataReader.GetInt("DichKinh_MT");
                value.TonThuongKhac_DichKinh_MT = DataReader["TonThuongKhac_DichKinh_MT"].ToString();
                value.DayMat_MT = DataReader.GetInt("DayMat_MT");
                value.CD_DayMat_MT = DataReader["CD_DayMat_MT"].ToString();
                value.PhuGai_MT = DataReader["PhuGai_MT"].ToString() == "1" ? true : false;
                value.BacMauGaiThi_MT = DataReader["BacMauGaiThi_MT"].ToString() == "1" ? true : false;
                value.VongMac_DayMat_MT = DataReader["VongMac_DayMat_MT"].ToString();
                value.HeMachMau_DayMat_MT = DataReader["HeMachMau_DayMat_MT"].ToString();
                value.TonThuongKhac_DayMat_MT = DataReader["TonThuongKhac_DayMat_MT"].ToString();
                value.HuyetAp_ToanThan = DataReader["HuyetAp_ToanThan"].ToString();
                value.NhietDo_ToanThan = DataReader["NhietDo_ToanThan"].ToString();
                value.Mach_ToanThan = DataReader["Mach_ToanThan"].ToString();
                value.NoiTiet_Tick = DataReader["NoiTiet_Tick"].ToString() == "1" ? true : false;
                value.NoiTiet = DataReader["NoiTiet"].ToString();
                value.ThanKinh_Tick = DataReader["ThanKinh_Tick"].ToString() == "1" ? true : false;
                value.TuanHoan_Tick = DataReader["TuanHoan_Tick"].ToString() == "1" ? true : false;
                value.HoHap_Tick = DataReader["HoHap_Tick"].ToString() == "1" ? true : false;
                value.TieuHoa_Tick = DataReader["TieuHoa_Tick"].ToString() == "1" ? true : false;
                value.CoXuongKhop_Tick = DataReader["CoXuongKhop_Tick"].ToString() == "1" ? true : false;
                value.ThanTietNieu_Tick = DataReader["ThanTietNieu_Tick"].ToString() == "1" ? true : false;
                value.BenhChinh_MatPhai = DataReader["BenhChinh_MatPhai"].ToString();
                value.BenhChinh_MatTrai = DataReader["BenhChinh_MatTrai"].ToString();
                value.PhuongPhapChinh = DataReader["PhuongPhapChinh"].ToString();
                value.CheDoAnUong = DataReader["CheDoAnUong"].ToString();
                value.CheDoChamSoc = DataReader["CheDoChamSoc"].ToString();
                value.ChanDoanBenhChinh_LamSang = DataReader["ChanDoanBenhChinh_LamSang"].ToString();
                value.ChanDoanBenhChinh_NguyenNhan = DataReader["ChanDoanBenhChinh_NguyenNhan"].ToString();
                value.QuaTrinhDieuTri_NoiKhoa = DataReader["QuaTrinhDieuTri_NoiKhoa"].ToString();
                value.QuaTrinhDieuTri_KetQua = DataReader["QuaTrinhDieuTri_KetQua"].ToString();
                value.QuaTrinhDieuTri_BienChung = DataReader["QuaTrinhDieuTri_BienChung"].ToString();
                value.HuongDieuTriTiep = DataReader["HuongDieuTriTiep"].ToString();
                value.MiMat_T = DataReader["MiMat_T"].ToString();
                value.MiMat_P = DataReader["MiMat_P"].ToString();
                value.ChuaThayBenhLy = DataReader["ChuaThayBenhLy"].ToString().Equals("1") ? true : false;
                value.BenhLy = DataReader["BenhLy"].ToString().Equals("1") ? true : false;
                value.BenhLy_Text = DataReader["BenhLy_Text"].ToString();
                value.PhauThuat = DataReader["PhauThuat"].ToString() == "1" ? true : false;
                value.ThuThuat = DataReader["ThuThuat"].ToString() == "1" ? true : false;
                value.ThiLucKhiRaVien_KhongKinh_MP = DataReader["ThiLucKhiRaVien_KhongKinh_MP"].ToString();
                value.ThiLucKhiRaVien_KhongKinh_MT = DataReader["ThiLucKhiRaVien_KhongKinh_MT"].ToString();
                value.ThiLucKhiRaVien_CoKinh_MP = DataReader["ThiLucKhiRaVien_CoKinh_MP"].ToString();
                value.ThiLucKhiRaVien_CoKinh_MT = DataReader["ThiLucKhiRaVien_CoKinh_MT"].ToString();
                value.NhanApRaVien_MP = DataReader["NhanApRaVien_MP"].ToString();
                value.NhanApRaVien_MT = DataReader["NhanApRaVien_MT"].ToString();
                value.ThoatNuocTot_MP_Text = DataReader["ThoatNuocTot_MP_Text"].ToString();
                value.ThoatNuocTot_MT_Text = DataReader["ThoatNuocTot_MT_Text"].ToString();
                value.TraoLeQuanDoiDien_MP_Text = DataReader["TraoLeQuanDoiDien_MP_Text"].ToString();
                value.TraoLeQuanDoiDien_MT_Text = DataReader["TraoLeQuanDoiDien_MT_Text"].ToString();
                value.TraoLeQuanTaiCho_MP_Text = DataReader["TraoLeQuanTaiCho_MP_Text"].ToString();
                value.TraoLeQuanTaiCho_MT_Text = DataReader["TraoLeQuanTaiCho_MT_Text"].ToString();
                value.KetMac_Mong_MP = DataReader.GetInt("KetMac_Mong_MP");
                value.KetMac_Mong_MT = DataReader.GetInt("KetMac_Mong_MT");
                value.GhepGiacMac_MP = DataReader["GhepGiacMac_MP"].ToString().Equals("1") ? true : false;
                value.GhepGiacMac_MT = DataReader["GhepGiacMac_MT"].ToString().Equals("1") ? true : false;
                value.BieuMo_GiacMac_BT_MP = DataReader["BieuMo_GiacMac_BT_MP"].ToString().Equals("1") ? true : false;
                value.BieuMo_GiacMac_BT_MT = DataReader["BieuMo_GiacMac_BT_MT"].ToString().Equals("1") ? true : false;
                value.NhuMo_GiacMac_BT_MP = DataReader["NhuMo_GiacMac_BT_MP"].ToString().Equals("1") ? true : false;
                value.NhuMo_GiacMac_BT_MT = DataReader["NhuMo_GiacMac_BT_MT"].ToString().Equals("1") ? true : false;
                value.NoiMo_GiacMac_BT_MP = DataReader["NoiMo_GiacMac_BT_MP"].ToString().Equals("1") ? true : false;
                value.NoiMo_GiacMac_BT_MT = DataReader["NoiMo_GiacMac_BT_MT"].ToString().Equals("1") ? true : false;
                value.CungMac_BT_MP = DataReader["CungMac_BT_MP"].ToString().Equals("1") ? true : false;
                value.CungMac_BT_MT = DataReader["CungMac_BT_MT"].ToString().Equals("1") ? true : false;
                value.Khuyet_MP = DataReader["Khuyet_MP"].ToString().Equals("1") ? true : false;
                value.Khuyet_MT = DataReader["Khuyet_MT"].ToString().Equals("1") ? true : false;
                value.Khac_MongMat_MP = DataReader["Khac_MongMat_MP"].ToString();
                value.Khac_MongMat_MT = DataReader["Khac_MongMat_MT"].ToString();

                int tempInt = 0;
                value.NoiTietCheck = int.TryParse(DataReader["NoiTietCheck"].ToString(), out tempInt) ? tempInt : 0;
                value.NoiTiet_Text = DataReader["NoiTiet_Text"].ToString();

                tempInt = 0;
                value.ThanKinhCheck = int.TryParse(DataReader["ThanKinhCheck"].ToString(), out tempInt) ? tempInt : 0;
                value.ThanKinh_Text = DataReader["ThanKinh_Text"].ToString();

                tempInt = 0;
                value.TuanHoanCheck = int.TryParse(DataReader["TuanHoanCheck"].ToString(), out tempInt) ? tempInt : 0;
                value.TuanHoan_Text = DataReader["TuanHoan_Text"].ToString();

                tempInt = 0;
                value.HoHapCheck = int.TryParse(DataReader["HoHapCheck"].ToString(), out tempInt) ? tempInt : 0;
                value.HoHap_Text = DataReader["HoHap_Text"].ToString();

                tempInt = 0;
                value.TieuHoaCheck = int.TryParse(DataReader["TieuHoaCheck"].ToString(), out tempInt) ? tempInt : 0;
                value.TieuHoa_Text = DataReader["TieuHoa_Text"].ToString();

                tempInt = 0;
                value.CoXuongKhopCheck = int.TryParse(DataReader["CoXuongKhopCheck"].ToString(), out tempInt) ? tempInt : 0;
                value.CoXuongKhop_Text = DataReader["CoXuongKhop_Text"].ToString();

                tempInt = 0;
                value.TietNieuSinhDucCheck = int.TryParse(DataReader["TietNieuSinhDucCheck"].ToString(), out tempInt) ? tempInt : 0;
                value.TietNieuSinhDuc_Text = DataReader["TietNieuSinhDuc_Text"].ToString();

                value.KhamBenhToanThan_Khac = DataReader["KhamBenhToanThan_Khac"].ToString();

                value.MaSoKyTen = DataReader["masokyten"].ToString();
                value.MaSoKyTen_KB = DataReader["masokyten_kb"].ToString();
                value.MaSoKyTen_TK = DataReader["masokyten_tk"].ToString();
            }
            return value;
        }

        public static bool InsertOrUpdate(MDB.MDBConnection MyConnection, BenhAnMatBanPhanTruoc BenhAnMatBanPhanTruoc)
        {
            string sql =
                      @"select MaQuanLy 
                        from BenhAnMatBanPhanTruoc
                        where MaQuanLy = :MaQuanLy";
            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
            Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", BenhAnMatBanPhanTruoc.MaQuanLy));
            MDB.MDBDataReader DataReader = Command.ExecuteReader();
            int rowCount = 0;
            while (DataReader.Read()) rowCount++;
            if (rowCount == 1) return Update(MyConnection, BenhAnMatBanPhanTruoc);
            sql = @"
                   INSERT INTO BenhAnMatBanPhanTruoc (MaQuanLy, LyDoVaoVien, VaoNgayThu, QuaTrinhBenhLy, TienSuBenhBanThan, TienSuBenhGiaDinh, ToanThan, TuanHoan, HoHap, TieuHoa, ThanTietNieuSinhDuc, ThanKinh, CoXuongKhop, TaiMuiHong, RangHamMat, Mat, Khac_CacCoQuan, CacXetNghiemCanLamSangCanLam, TomTatBenhAn, BenhChinh, BenhKemTheo, PhanBiet, TienLuong, HuongDieuTri, NgayKhamBenh, BacSyLamBenhAn, QuaTrinhBenhLyVaDienBien, TomTatKetQuaXetNghiem, PhuongPhapDieuTri, TinhTrangNguoiBenhRaVien, HuongDieuTriVaCacCheDoTiepTheo, NguoiNhanHoSo, NguoiGiaoHoSo, NgayTongKet, BacSyDieuTri, DiUng, DiUng_Text, MaTuy, MaTuy_Text, RuouBia, RuouBia_Text, ThuocLa, ThuocLa_Text, ThuocLao, ThuocLao_Text, Khac_DacDiemLienQuanBenh, Khac_DacDiemLienQuanBenh_Text, ThoiGianXuatHienBenh, NguyenNhan_BenhSu, CacPhuongPhapDaDieuTri_BenhSu, TienSuBenhBanThan_Mat, TienSuBenhGiaDinh_Mat, KhongKinh_ThiLuc_MP, QuaLo_ThiLuc_MP, CoChinhKinh_ThiLuc_MP, NhinGan_ThiLuc_MP, NhanAp_MP, LacVaVanNhan_MP, ThoatNuocTot_MP, TraoLeQuanDoiDien_MP, TraoLeQuanTaiCho_MP, MiMat_MP, Khac_MiMat_MP, UMi_MP, TinhChatU_UMi_MP, ViTri_UMi_MP, KichThuoc_UMi_MP, Quam_MiMat_MP, MiTren_MiMat_MP, MiDuoi_MiMat_MP, HoMi_MiMat_MP, TreMi_MiMat_MP, KhuyetMi_MiMat_MP, TuyetBoMi_MiMat_MP, ViemBoMi_MiMat_MP, TonThuongKhac_MiMat_MP, CuongTu_KetMac_MP, PhuNe_KetMac_MP, XuatHuyet_KetMac_MP, SungHoa_KetMac_MP, Nhu_KetMac_MP, Hot_KetMac_MP, Seo_KetMac_MP, TietToMu_KetMac_MP, TietToTrong_KetMac_MP, GiaMac_KetMac_MP, BatMauFluor_KetMac_MP, TinhChat_UKetMac_MP, ViTri_UKetMac_MP, KichThuoc_UKetMac_MP, CungDo_KetMac_MP, ChieuCaoCuaCauDinh_KetMac_MP, DoRongCuaCauDinh_KetMac_MP, TonThuongKhac_KetMac_MP, KichThuoc_GiacMac_MP, HinhDang_GiacMac_MP, BieuMo_GiacMac_MP, PhuBongBieuMo_GiacMac_MP, MatBieuMo_GiacMac_MP, MatBieuMoKhoangCach_MP, BoTonThuong_GM_MP, ThoaiThoaDaiBang_MP, LangDongThuoc_MP, TonThuongKhac_BieuMo_GM_MP, Phu_NhuMo_GiacMac_MP, ThamLau_NhuMo_GiacMac_MP, ThamLau_Vtri_NhuMo_GiacMac_MP, TieuMong_NhuMo_GiacMac_MP, TieuMong_Vtri_NhuMo_GiacMac_MP, TonThuongKhac_NhuMo_GiacMac_MP, NepGap_NoiMo_GiacMac_MP, TuaSacToMacSauGM_MP, MuMatSau_NoiMo_MP, XuatTietMatSau_NoiMo_MP, Guttata_NoiMo_MP, RanMangDescemet_NoiMo_MP, CuonDescemet_NoiMo_MP, TonThuongKhac_NoiMo_MP, DoaThung_GiacMac_MP, KetMongMat_GiacMac_MP, ThungGiacMac_MP, Seidel_MP, DuongKinhThungGiacMac_MP, ThungBit_GM_MP, CamGiacGiacMac_MP, TanMach_GiacMac_MP, MucDo_TanMach_GiacMac_MP, SuyTeBaoNguon_MP, ThoaiHoaGia_MP, LangDongCanXi_MP, BatThuongKhac_GiacMac_MP, Viem_CungMac_MP, Viem_NongSau_CungMac_MP, ViemThuongCungMac_MP, GianLoi_TieuMong_HoaiTu_MP, ChiTietKhac_CungMac_MP, TienPhong_MP, Mu_TienPhong_MP, Tydal_MP, MangXuatTiet_MP, Mau_TienPhong_MP, TonThuongKhac_TienPhong_MP, NauXop_MP, XoTeo_MP, CuongTu_MP, TanMach_MP, Phoi_MP, Ket_MP, DuongKinh_DongTu_MP, DongTuTronMeoDinh_MP, ViTriDinh_DongTu_MP, PhanXaDongTu_MP, TonThuongKhac_DongTu_MP, ThuyTinhThe_MP, HinhThaiDuc_ThuyTinhthe_MP, IOL_CanLechDuc_MP, IOL_TrongTPHP_MP, TonThuongKhac_ThuyTinhthe_MP, AnhDongTu_MP, DichKinh_MP, TonThuongKhac_DichKinh_MP, DayMat_MP, CD_DayMat_MP, PhuGai_MP, BacMauGaiThi_MP, VongMac_DayMat_MP, HeMachMau_DayMat_MP, TonThuongKhac_DayMat_MP, KhongKinh_ThiLuc_MT, QuaLo_ThiLuc_MT, CoChinhKinh_ThiLuc_MT, NhinGan_ThiLuc_MT, NhanAp_MT, LacVaVanNhan_MT, ThoatNuocTot_MT, TraoLeQuanDoiDien_MT, TraoLeQuanTaiCho_MT, MiMat_MT, Khac_MiMat_MT, UMi_MT, TinhChatU_UMi_MT, ViTri_UMi_MT, KichThuoc_UMi_MT, Quam_MiMat_MT, MiTren_MiMat_MT, MiDuoi_MiMat_MT, HoMi_MiMat_MT, TreMi_MiMat_MT, KhuyetMi_MiMat_MT, TuyetBoMi_MiMat_MT, ViemBoMi_MiMat_MT, TonThuongKhac_MiMat_MT, CuongTu_KetMac_MT, PhuNe_KetMac_MT, XuatHuyet_KetMac_MT, SungHoa_KetMac_MT, Nhu_KetMac_MT, Hot_KetMac_MT, Seo_KetMac_MT, TietToMu_KetMac_MT, TietToTrong_KetMac_MT, GiaMac_KetMac_MT, BatMauFluor_KetMac_MT, TinhChat_UKetMac_MT, ViTri_UKetMac_MT, KichThuoc_UKetMac_MT, CungDo_KetMac_MT, ChieuCaoCuaCauDinh_KetMac_MT, DoRongCuaCauDinh_KetMac_MT, TonThuongKhac_KetMac_MT, KichThuoc_GiacMac_MT, HinhDang_GiacMac_MT, BieuMo_GiacMac_MT, PhuBongBieuMo_GiacMac_MT, MatBieuMo_GiacMac_MT, MatBieuMoKhoangCach_MT, BoTonThuong_GM_MT, ThoaiThoaDaiBang_MT, LangDongThuoc_MT, TonThuongKhac_BieuMo_GM_MT_TXT, Phu_NhuMo_GiacMac_MT, ThamLau_NhuMo_GiacMac_MT, ThamLau_Vtri_NhuMo_GiacMac_MT, TieuMong_NhuMo_GiacMac_MT, TieuMong_Vtri_NhuMo_GiacMac_MT, TonThuongKhac_NhuMo_GiacMac_MT, NepGap_NoiMo_GiacMac_MT, TuaSacToMacSauGM_MT, MuMatSau_NoiMo_MT, XuatTietMatSau_NoiMo_MT, Guttata_NoiMo_MT, RanMangDescemet_NoiMo_MT, CuonDescemet_NoiMo_MT, TonThuongKhac_NoiMo_MT, DoaThung_GiacMac_MT, KetMongMat_GiacMac_MT, ThungGiacMac_MT, Seidel_MT, DuongKinhThungGiacMac_MT, ThungBit_GM_MT, CamGiacGiacMac_MT, TanMach_GiacMac_MT, MucDo_TanMach_GiacMac_MT, SuyTeBaoNguon_MT, ThoaiHoaGia_MT, LangDongCanXi_MT, BatThuongKhac_GiacMac_MT, Viem_CungMac_MT, Viem_NongSau_CungMac_MT, ViemThuongCungMac_MT, GianLoi_TieuMong_HoaiTu_MT, ChiTietKhac_CungMac_MT, TienPhong_MT, Mu_TienPhong_MT, Tydal_MT, MangXuatTiet_MT, Mau_TienPhong_MT, TonThuongKhac_TienPhong_MT, NauXop_MT, XoTeo_MT, CuongTu_MT, TanMach_MT, Phoi_MT, Ket_MT, DuongKinh_DongTu_MT, DongTuTronMeoDinh_MT, ViTriDinh_DongTu_MT, PhanXaDongTu_MT, TonThuongKhac_DongTu_MT, ThuyTinhThe_MT, HinhThaiDuc_ThuyTinhthe_MT, IOL_CanLechDuc_MT, IOL_TrongTPHP_MT, TonThuongKhac_ThuyTinhthe_MT, AnhDongTu_MT, DichKinh_MT, TonThuongKhac_DichKinh_MT, DayMat_MT, CD_DayMat_MT, PhuGai_MT, BacMauGaiThi_MT, VongMac_DayMat_MT, HeMachMau_DayMat_MT, TonThuongKhac_DayMat_MT, HuyetAp_ToanThan, NhietDo_ToanThan, Mach_ToanThan, NoiTiet_Tick, NoiTiet, ThanKinh_Tick, TuanHoan_Tick, HoHap_Tick, TieuHoa_Tick, CoXuongKhop_Tick, ThanTietNieu_Tick, BenhChinh_MatPhai, BenhChinh_MatTrai, PhuongPhapChinh, CheDoAnUong, CheDoChamSoc, ChanDoanBenhChinh_LamSang, ChanDoanBenhChinh_NguyenNhan, QuaTrinhDieuTri_NoiKhoa, QuaTrinhDieuTri_KetQua, QuaTrinhDieuTri_BienChung, HuongDieuTriTiep, MiMat_T, MiMat_P, ChuaThayBenhLy, BenhLy, BenhLy_Text, PhauThuat, ThuThuat, ThiLucKhiRaVien_KhongKinh_MP, ThiLucKhiRaVien_KhongKinh_MT, ThiLucKhiRaVien_CoKinh_MP, ThiLucKhiRaVien_CoKinh_MT, NhanApRaVien_MP, NhanApRaVien_MT, ThoatNuocTot_MP_Text, ThoatNuocTot_MT_Text, TraoLeQuanDoiDien_MP_Text, TraoLeQuanDoiDien_MT_Text, TraoLeQuanTaiCho_MP_Text, TraoLeQuanTaiCho_MT_Text, KetMac_Mong_MP, KetMac_Mong_MT, GhepGiacMac_MP, GhepGiacMac_MT, BieuMo_GiacMac_BT_MP, BieuMo_GiacMac_BT_MT, NhuMo_GiacMac_BT_MP, NhuMo_GiacMac_BT_MT, NoiMo_GiacMac_BT_MP, NoiMo_GiacMac_BT_MT, CungMac_BT_MP, CungMac_BT_MT, Khuyet_MP, Khuyet_MT, Khac_MongMat_MP, Khac_MongMat_MT, NoiTietCheck, NoiTiet_Text, ThanKinhCheck, ThanKinh_Text, TuanHoanCheck, TuanHoan_Text, HoHapCheck, HoHap_Text, TieuHoaCheck, TieuHoa_Text, CoXuongKhopCheck , CoXuongKhop_Text, TietNieuSinhDucCheck, TietNieuSinhDuc_Text, KhamBenhToanThan_Khac)
                   VALUES(:MaQuanLy, :LyDoVaoVien, :VaoNgayThu, :QuaTrinhBenhLy, :TienSuBenhBanThan, :TienSuBenhGiaDinh, :ToanThan, :TuanHoan, :HoHap, :TieuHoa, :ThanTietNieuSinhDuc, :ThanKinh, :CoXuongKhop, :TaiMuiHong, :RangHamMat, :Mat, :Khac_CacCoQuan, :CacXetNghiemCanLamSangCanLam, :TomTatBenhAn, :BenhChinh, :BenhKemTheo, :PhanBiet, :TienLuong, :HuongDieuTri, :NgayKhamBenh, :BacSyLamBenhAn, :QuaTrinhBenhLyVaDienBien, :TomTatKetQuaXetNghiem, :PhuongPhapDieuTri, :TinhTrangNguoiBenhRaVien, :HuongDieuTriVaCacCheDoTiepTheo, :NguoiNhanHoSo, :NguoiGiaoHoSo, :NgayTongKet, :BacSyDieuTri, :DiUng, :DiUng_Text, :MaTuy, :MaTuy_Text, :RuouBia, :RuouBia_Text, :ThuocLa, :ThuocLa_Text, :ThuocLao, :ThuocLao_Text, :Khac_DacDiemLienQuanBenh, :Khac_DacDiemLienQuanBenh_Text, :ThoiGianXuatHienBenh, :NguyenNhan_BenhSu, :CacPhuongPhapDaDieuTri_BenhSu, :TienSuBenhBanThan_Mat, :TienSuBenhGiaDinh_Mat, :KhongKinh_ThiLuc_MP, :QuaLo_ThiLuc_MP, :CoChinhKinh_ThiLuc_MP, :NhinGan_ThiLuc_MP, :NhanAp_MP, :LacVaVanNhan_MP, :ThoatNuocTot_MP, :TraoLeQuanDoiDien_MP, :TraoLeQuanTaiCho_MP, :MiMat_MP, :Khac_MiMat_MP, :UMi_MP, :TinhChatU_UMi_MP, :ViTri_UMi_MP, :KichThuoc_UMi_MP, :Quam_MiMat_MP, :MiTren_MiMat_MP, :MiDuoi_MiMat_MP, :HoMi_MiMat_MP, :TreMi_MiMat_MP, :KhuyetMi_MiMat_MP, :TuyetBoMi_MiMat_MP, :ViemBoMi_MiMat_MP, :TonThuongKhac_MiMat_MP, :CuongTu_KetMac_MP, :PhuNe_KetMac_MP, :XuatHuyet_KetMac_MP, :SungHoa_KetMac_MP, :Nhu_KetMac_MP, :Hot_KetMac_MP, :Seo_KetMac_MP, :TietToMu_KetMac_MP, :TietToTrong_KetMac_MP, :GiaMac_KetMac_MP, :BatMauFluor_KetMac_MP, :TinhChat_UKetMac_MP, :ViTri_UKetMac_MP, :KichThuoc_UKetMac_MP, :CungDo_KetMac_MP, :ChieuCaoCuaCauDinh_KetMac_MP, :DoRongCuaCauDinh_KetMac_MP, :TonThuongKhac_KetMac_MP, :KichThuoc_GiacMac_MP, :HinhDang_GiacMac_MP, :BieuMo_GiacMac_MP, :PhuBongBieuMo_GiacMac_MP, :MatBieuMo_GiacMac_MP, :MatBieuMoKhoangCach_MP, :BoTonThuong_GM_MP, :ThoaiThoaDaiBang_MP, :LangDongThuoc_MP, :TonThuongKhac_BieuMo_GM_MP, :Phu_NhuMo_GiacMac_MP, :ThamLau_NhuMo_GiacMac_MP, :ThamLau_Vtri_NhuMo_GiacMac_MP, :TieuMong_NhuMo_GiacMac_MP, :TieuMong_Vtri_NhuMo_GiacMac_MP, :TonThuongKhac_NhuMo_GiacMac_MP, :NepGap_NoiMo_GiacMac_MP, :TuaSacToMacSauGM_MP, :MuMatSau_NoiMo_MP, :XuatTietMatSau_NoiMo_MP, :Guttata_NoiMo_MP, :RanMangDescemet_NoiMo_MP, :CuonDescemet_NoiMo_MP, :TonThuongKhac_NoiMo_MP, :DoaThung_GiacMac_MP, :KetMongMat_GiacMac_MP, :ThungGiacMac_MP, :Seidel_MP, :DuongKinhThungGiacMac_MP, :ThungBit_GM_MP, :CamGiacGiacMac_MP, :TanMach_GiacMac_MP, :MucDo_TanMach_GiacMac_MP, :SuyTeBaoNguon_MP, :ThoaiHoaGia_MP, :LangDongCanXi_MP, :BatThuongKhac_GiacMac_MP, :Viem_CungMac_MP, :Viem_NongSau_CungMac_MP, :ViemThuongCungMac_MP, :GianLoi_TieuMong_HoaiTu_MP, :ChiTietKhac_CungMac_MP, :TienPhong_MP, :Mu_TienPhong_MP, :Tydal_MP, :MangXuatTiet_MP, :Mau_TienPhong_MP, :TonThuongKhac_TienPhong_MP, :NauXop_MP, :XoTeo_MP, :CuongTu_MP, :TanMach_MP, :Phoi_MP, :Ket_MP, :DuongKinh_DongTu_MP, :DongTuTronMeoDinh_MP, :ViTriDinh_DongTu_MP, :PhanXaDongTu_MP, :TonThuongKhac_DongTu_MP, :ThuyTinhThe_MP, :HinhThaiDuc_ThuyTinhthe_MP, :IOL_CanLechDuc_MP, :IOL_TrongTPHP_MP, :TonThuongKhac_ThuyTinhthe_MP, :AnhDongTu_MP, :DichKinh_MP, :TonThuongKhac_DichKinh_MP, :DayMat_MP, :CD_DayMat_MP, :PhuGai_MP, :BacMauGaiThi_MP, :VongMac_DayMat_MP, :HeMachMau_DayMat_MP, :TonThuongKhac_DayMat_MP, :KhongKinh_ThiLuc_MT, :QuaLo_ThiLuc_MT, :CoChinhKinh_ThiLuc_MT, :NhinGan_ThiLuc_MT, :NhanAp_MT, :LacVaVanNhan_MT, :ThoatNuocTot_MT, :TraoLeQuanDoiDien_MT, :TraoLeQuanTaiCho_MT, :MiMat_MT, :Khac_MiMat_MT, :UMi_MT, :TinhChatU_UMi_MT, :ViTri_UMi_MT, :KichThuoc_UMi_MT, :Quam_MiMat_MT, :MiTren_MiMat_MT, :MiDuoi_MiMat_MT, :HoMi_MiMat_MT, :TreMi_MiMat_MT, :KhuyetMi_MiMat_MT, :TuyetBoMi_MiMat_MT, :ViemBoMi_MiMat_MT, :TonThuongKhac_MiMat_MT, :CuongTu_KetMac_MT, :PhuNe_KetMac_MT, :XuatHuyet_KetMac_MT, :SungHoa_KetMac_MT, :Nhu_KetMac_MT, :Hot_KetMac_MT, :Seo_KetMac_MT, :TietToMu_KetMac_MT, :TietToTrong_KetMac_MT, :GiaMac_KetMac_MT, :BatMauFluor_KetMac_MT, :TinhChat_UKetMac_MT, :ViTri_UKetMac_MT, :KichThuoc_UKetMac_MT, :CungDo_KetMac_MT, :ChieuCaoCuaCauDinh_KetMac_MT, :DoRongCuaCauDinh_KetMac_MT, :TonThuongKhac_KetMac_MT, :KichThuoc_GiacMac_MT, :HinhDang_GiacMac_MT, :BieuMo_GiacMac_MT, :PhuBongBieuMo_GiacMac_MT, :MatBieuMo_GiacMac_MT, :MatBieuMoKhoangCach_MT, :BoTonThuong_GM_MT, :ThoaiThoaDaiBang_MT, :LangDongThuoc_MT, :TonThuongKhac_BieuMo_GM_MT_TXT, :Phu_NhuMo_GiacMac_MT, :ThamLau_NhuMo_GiacMac_MT, :ThamLau_Vtri_NhuMo_GiacMac_MT, :TieuMong_NhuMo_GiacMac_MT, :TieuMong_Vtri_NhuMo_GiacMac_MT, :TonThuongKhac_NhuMo_GiacMac_MT, :NepGap_NoiMo_GiacMac_MT, :TuaSacToMacSauGM_MT, :MuMatSau_NoiMo_MT, :XuatTietMatSau_NoiMo_MT, :Guttata_NoiMo_MT, :RanMangDescemet_NoiMo_MT, :CuonDescemet_NoiMo_MT, :TonThuongKhac_NoiMo_MT, :DoaThung_GiacMac_MT, :KetMongMat_GiacMac_MT, :ThungGiacMac_MT, :Seidel_MT, :DuongKinhThungGiacMac_MT, :ThungBit_GM_MT, :CamGiacGiacMac_MT, :TanMach_GiacMac_MT, :MucDo_TanMach_GiacMac_MT, :SuyTeBaoNguon_MT, :ThoaiHoaGia_MT, :LangDongCanXi_MT, :BatThuongKhac_GiacMac_MT, :Viem_CungMac_MT, :Viem_NongSau_CungMac_MT, :ViemThuongCungMac_MT, :GianLoi_TieuMong_HoaiTu_MT, :ChiTietKhac_CungMac_MT, :TienPhong_MT, :Mu_TienPhong_MT, :Tydal_MT, :MangXuatTiet_MT, :Mau_TienPhong_MT, :TonThuongKhac_TienPhong_MT, :NauXop_MT, :XoTeo_MT, :CuongTu_MT, :TanMach_MT, :Phoi_MT, :Ket_MT, :DuongKinh_DongTu_MT, :DongTuTronMeoDinh_MT, :ViTriDinh_DongTu_MT, :PhanXaDongTu_MT, :TonThuongKhac_DongTu_MT, :ThuyTinhThe_MT, :HinhThaiDuc_ThuyTinhthe_MT, :IOL_CanLechDuc_MT, :IOL_TrongTPHP_MT, :TonThuongKhac_ThuyTinhthe_MT, :AnhDongTu_MT, :DichKinh_MT, :TonThuongKhac_DichKinh_MT, :DayMat_MT, :CD_DayMat_MT, :PhuGai_MT, :BacMauGaiThi_MT, :VongMac_DayMat_MT, :HeMachMau_DayMat_MT, :TonThuongKhac_DayMat_MT, :HuyetAp_ToanThan, :NhietDo_ToanThan, :Mach_ToanThan, :NoiTiet_Tick, :NoiTiet, :ThanKinh_Tick, :TuanHoan_Tick, :HoHap_Tick, :TieuHoa_Tick, :CoXuongKhop_Tick, :ThanTietNieu_Tick, :BenhChinh_MatPhai, :BenhChinh_MatTrai, :PhuongPhapChinh, :CheDoAnUong, :CheDoChamSoc, :ChanDoanBenhChinh_LamSang, :ChanDoanBenhChinh_NguyenNhan, :QuaTrinhDieuTri_NoiKhoa, :QuaTrinhDieuTri_KetQua, :QuaTrinhDieuTri_BienChung, :HuongDieuTriTiep, :MiMat_T, :MiMat_P, :ChuaThayBenhLy, :BenhLy, :BenhLy_Text, :PhauThuat, :ThuThuat, :ThiLucKhiRaVien_KhongKinh_MP, :ThiLucKhiRaVien_KhongKinh_MT, :ThiLucKhiRaVien_CoKinh_MP, :ThiLucKhiRaVien_CoKinh_MT, :NhanApRaVien_MP, :NhanApRaVien_MT, :ThoatNuocTot_MP_Text, :ThoatNuocTot_MT_Text, :TraoLeQuanDoiDien_MP_Text, :TraoLeQuanDoiDien_MT_Text, :TraoLeQuanTaiCho_MP_Text, :TraoLeQuanTaiCho_MT_Text, :KetMac_Mong_MP, :KetMac_Mong_MT, :GhepGiacMac_MP, :GhepGiacMac_MT, :BieuMo_GiacMac_BT_MP, :BieuMo_GiacMac_BT_MT, :NhuMo_GiacMac_BT_MP, :NhuMo_GiacMac_BT_MT, :NoiMo_GiacMac_BT_MP, :NoiMo_GiacMac_BT_MT, :CungMac_BT_MP, :CungMac_BT_MT, :Khuyet_MP, :Khuyet_MT, :Khac_MongMat_MP, :Khac_MongMat_MT, :NoiTietCheck, :NoiTiet_Text, :ThanKinhCheck, :ThanKinh_Text, :TuanHoanCheck, :TuanHoan_Text, :HoHapCheck, :HoHap_Text, :TieuHoaCheck, :TieuHoa_Text, :CoXuongKhopCheck , :CoXuongKhop_Text, :TietNieuSinhDucCheck, :TietNieuSinhDuc_Text, :KhamBenhToanThan_Khac)
                   ";
            Command = new MDB.MDBCommand(sql, MyConnection);
            Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", BenhAnMatBanPhanTruoc.MaQuanLy));
            Command.Parameters.Add(new MDB.MDBParameter("LyDoVaoVien", BenhAnMatBanPhanTruoc.LyDoVaoVien));
            Command.Parameters.Add(new MDB.MDBParameter("VaoNgayThu", BenhAnMatBanPhanTruoc.VaoNgayThu));
            Command.Parameters.Add(new MDB.MDBParameter("QuaTrinhBenhLy", BenhAnMatBanPhanTruoc.QuaTrinhBenhLy));
            Command.Parameters.Add(new MDB.MDBParameter("TienSuBenhBanThan", BenhAnMatBanPhanTruoc.TienSuBenhBanThan));
            Command.Parameters.Add(new MDB.MDBParameter("TienSuBenhGiaDinh", BenhAnMatBanPhanTruoc.TienSuBenhGiaDinh));
            Command.Parameters.Add(new MDB.MDBParameter("ToanThan", BenhAnMatBanPhanTruoc.ToanThan));
            Command.Parameters.Add(new MDB.MDBParameter("TuanHoan", BenhAnMatBanPhanTruoc.TuanHoan));
            Command.Parameters.Add(new MDB.MDBParameter("HoHap", BenhAnMatBanPhanTruoc.HoHap));
            Command.Parameters.Add(new MDB.MDBParameter("TieuHoa", BenhAnMatBanPhanTruoc.TieuHoa));
            Command.Parameters.Add(new MDB.MDBParameter("ThanTietNieuSinhDuc", BenhAnMatBanPhanTruoc.ThanTietNieuSinhDuc));
            Command.Parameters.Add(new MDB.MDBParameter("ThanKinh", BenhAnMatBanPhanTruoc.ThanKinh));
            Command.Parameters.Add(new MDB.MDBParameter("CoXuongKhop", BenhAnMatBanPhanTruoc.CoXuongKhop));
            Command.Parameters.Add(new MDB.MDBParameter("TaiMuiHong", BenhAnMatBanPhanTruoc.TaiMuiHong));
            Command.Parameters.Add(new MDB.MDBParameter("RangHamMat", BenhAnMatBanPhanTruoc.RangHamMat));
            Command.Parameters.Add(new MDB.MDBParameter("Mat", BenhAnMatBanPhanTruoc.Mat));
            Command.Parameters.Add(new MDB.MDBParameter("Khac_CacCoQuan", BenhAnMatBanPhanTruoc.Khac_CacCoQuan));
            Command.Parameters.Add(new MDB.MDBParameter("CacXetNghiemCanLamSangCanLam", BenhAnMatBanPhanTruoc.CacXetNghiemCanLamSangCanLam));
            Command.Parameters.Add(new MDB.MDBParameter("TomTatBenhAn", BenhAnMatBanPhanTruoc.TomTatBenhAn));
            Command.Parameters.Add(new MDB.MDBParameter("BenhChinh", BenhAnMatBanPhanTruoc.BenhChinh));
            Command.Parameters.Add(new MDB.MDBParameter("BenhKemTheo", BenhAnMatBanPhanTruoc.BenhKemTheo));
            Command.Parameters.Add(new MDB.MDBParameter("PhanBiet", BenhAnMatBanPhanTruoc.PhanBiet));
            Command.Parameters.Add(new MDB.MDBParameter("TienLuong", BenhAnMatBanPhanTruoc.TienLuong));
            Command.Parameters.Add(new MDB.MDBParameter("HuongDieuTri", BenhAnMatBanPhanTruoc.HuongDieuTri));
            Command.Parameters.Add(new MDB.MDBParameter("NgayKhamBenh", BenhAnMatBanPhanTruoc.NgayKhamBenh));
            Command.Parameters.Add(new MDB.MDBParameter("BacSyLamBenhAn", BenhAnMatBanPhanTruoc.BacSyLamBenhAn));
            Command.Parameters.Add(new MDB.MDBParameter("QuaTrinhBenhLyVaDienBien", BenhAnMatBanPhanTruoc.QuaTrinhBenhLyVaDienBien));
            Command.Parameters.Add(new MDB.MDBParameter("TomTatKetQuaXetNghiem", BenhAnMatBanPhanTruoc.TomTatKetQuaXetNghiem));
            Command.Parameters.Add(new MDB.MDBParameter("PhuongPhapDieuTri", BenhAnMatBanPhanTruoc.PhuongPhapDieuTri));
            Command.Parameters.Add(new MDB.MDBParameter("TinhTrangNguoiBenhRaVien", BenhAnMatBanPhanTruoc.TinhTrangNguoiBenhRaVien));
            Command.Parameters.Add(new MDB.MDBParameter("HuongDieuTriVaCacCheDoTiepTheo", BenhAnMatBanPhanTruoc.HuongDieuTriVaCacCheDoTiepTheo));
            Command.Parameters.Add(new MDB.MDBParameter("NguoiNhanHoSo", BenhAnMatBanPhanTruoc.NguoiNhanHoSo));
            Command.Parameters.Add(new MDB.MDBParameter("NguoiGiaoHoSo", BenhAnMatBanPhanTruoc.NguoiGiaoHoSo));
            Command.Parameters.Add(new MDB.MDBParameter("NgayTongKet", BenhAnMatBanPhanTruoc.NgayTongKet));
            Command.Parameters.Add(new MDB.MDBParameter("BacSyDieuTri", BenhAnMatBanPhanTruoc.BacSyDieuTri));
            Command.Parameters.Add(new MDB.MDBParameter("DiUng", BenhAnMatBanPhanTruoc.DacDiemLienQuanBenh.DiUng == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("DiUng_Text", BenhAnMatBanPhanTruoc.DacDiemLienQuanBenh.DiUng_Text));
            Command.Parameters.Add(new MDB.MDBParameter("MaTuy", BenhAnMatBanPhanTruoc.DacDiemLienQuanBenh.MaTuy == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("MaTuy_Text", BenhAnMatBanPhanTruoc.DacDiemLienQuanBenh.MaTuy_Text));
            Command.Parameters.Add(new MDB.MDBParameter("RuouBia", BenhAnMatBanPhanTruoc.DacDiemLienQuanBenh.RuouBia == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("RuouBia_Text", BenhAnMatBanPhanTruoc.DacDiemLienQuanBenh.RuouBia_Text));
            Command.Parameters.Add(new MDB.MDBParameter("ThuocLa", BenhAnMatBanPhanTruoc.DacDiemLienQuanBenh.ThuocLa == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("ThuocLa_Text", BenhAnMatBanPhanTruoc.DacDiemLienQuanBenh.ThuocLa_Text));
            Command.Parameters.Add(new MDB.MDBParameter("ThuocLao", BenhAnMatBanPhanTruoc.DacDiemLienQuanBenh.ThuocLao == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("ThuocLao_Text", BenhAnMatBanPhanTruoc.DacDiemLienQuanBenh.ThuocLao_Text));
            Command.Parameters.Add(new MDB.MDBParameter("Khac_DacDiemLienQuanBenh", BenhAnMatBanPhanTruoc.DacDiemLienQuanBenh.Khac_DacDiemLienQuanBenh == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("Khac_DacDiemLienQuanBenh_Text", BenhAnMatBanPhanTruoc.DacDiemLienQuanBenh.Khac_DacDiemLienQuanBenh_Text));
            Command.Parameters.Add(new MDB.MDBParameter("ThoiGianXuatHienBenh", BenhAnMatBanPhanTruoc.ThoiGianXuatHienBenh));
            Command.Parameters.Add(new MDB.MDBParameter("NguyenNhan_BenhSu", BenhAnMatBanPhanTruoc.NguyenNhan_BenhSu));
            Command.Parameters.Add(new MDB.MDBParameter("CacPhuongPhapDaDieuTri_BenhSu", BenhAnMatBanPhanTruoc.CacPhuongPhapDaDieuTri_BenhSu));
            Command.Parameters.Add(new MDB.MDBParameter("TienSuBenhBanThan_Mat", BenhAnMatBanPhanTruoc.TienSuBenhBanThan_Mat));
            Command.Parameters.Add(new MDB.MDBParameter("TienSuBenhGiaDinh_Mat", BenhAnMatBanPhanTruoc.TienSuBenhGiaDinh_Mat));
            Command.Parameters.Add(new MDB.MDBParameter("KhongKinh_ThiLuc_MP", BenhAnMatBanPhanTruoc.KhongKinh_ThiLuc_MP));
            Command.Parameters.Add(new MDB.MDBParameter("QuaLo_ThiLuc_MP", BenhAnMatBanPhanTruoc.QuaLo_ThiLuc_MP));
            Command.Parameters.Add(new MDB.MDBParameter("CoChinhKinh_ThiLuc_MP", BenhAnMatBanPhanTruoc.CoChinhKinh_ThiLuc_MP));
            Command.Parameters.Add(new MDB.MDBParameter("NhinGan_ThiLuc_MP", BenhAnMatBanPhanTruoc.NhinGan_ThiLuc_MP));
            Command.Parameters.Add(new MDB.MDBParameter("NhanAp_MP", BenhAnMatBanPhanTruoc.NhanAp_MP));
            Command.Parameters.Add(new MDB.MDBParameter("LacVaVanNhan_MP", BenhAnMatBanPhanTruoc.LacVaVanNhan_MP));
            Command.Parameters.Add(new MDB.MDBParameter("ThoatNuocTot_MP", BenhAnMatBanPhanTruoc.ThoatNuocTot_MP == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("TraoLeQuanDoiDien_MP", BenhAnMatBanPhanTruoc.TraoLeQuanDoiDien_MP == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("TraoLeQuanTaiCho_MP", BenhAnMatBanPhanTruoc.TraoLeQuanTaiCho_MP == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("MiMat_MP", BenhAnMatBanPhanTruoc.MiMat_MP));
            Command.Parameters.Add(new MDB.MDBParameter("Khac_MiMat_MP", BenhAnMatBanPhanTruoc.Khac_MiMat_MP));
            Command.Parameters.Add(new MDB.MDBParameter("UMi_MP", BenhAnMatBanPhanTruoc.UMi_MP == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("TinhChatU_UMi_MP", BenhAnMatBanPhanTruoc.TinhChatU_UMi_MP));
            Command.Parameters.Add(new MDB.MDBParameter("ViTri_UMi_MP", BenhAnMatBanPhanTruoc.ViTri_UMi_MP));
            Command.Parameters.Add(new MDB.MDBParameter("KichThuoc_UMi_MP", BenhAnMatBanPhanTruoc.KichThuoc_UMi_MP));
            Command.Parameters.Add(new MDB.MDBParameter("Quam_MiMat_MP", BenhAnMatBanPhanTruoc.iQuam_MiMat_MP));
            Command.Parameters.Add(new MDB.MDBParameter("MiTren_MiMat_MP", BenhAnMatBanPhanTruoc.MiTren_MiMat_MP));
            Command.Parameters.Add(new MDB.MDBParameter("MiDuoi_MiMat_MP", BenhAnMatBanPhanTruoc.MiDuoi_MiMat_MP));
            Command.Parameters.Add(new MDB.MDBParameter("HoMi_MiMat_MP", BenhAnMatBanPhanTruoc.HoMi_MiMat_MP == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("TreMi_MiMat_MP", BenhAnMatBanPhanTruoc.TreMi_MiMat_MP == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("KhuyetMi_MiMat_MP", BenhAnMatBanPhanTruoc.KhuyetMi_MiMat_MP));
            Command.Parameters.Add(new MDB.MDBParameter("TuyetBoMi_MiMat_MP", BenhAnMatBanPhanTruoc.TuyetBoMi_MiMat_MP));
            Command.Parameters.Add(new MDB.MDBParameter("ViemBoMi_MiMat_MP", BenhAnMatBanPhanTruoc.ViemBoMi_MiMat_MP == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("TonThuongKhac_MiMat_MP", BenhAnMatBanPhanTruoc.TonThuongKhac_MiMat_MP));
            Command.Parameters.Add(new MDB.MDBParameter("CuongTu_KetMac_MP", BenhAnMatBanPhanTruoc.CuongTu_KetMac_MP));
            Command.Parameters.Add(new MDB.MDBParameter("PhuNe_KetMac_MP", BenhAnMatBanPhanTruoc.PhuNe_KetMac_MP == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("XuatHuyet_KetMac_MP", BenhAnMatBanPhanTruoc.XuatHuyet_KetMac_MP == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("SungHoa_KetMac_MP", BenhAnMatBanPhanTruoc.SungHoa_KetMac_MP == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("Nhu_KetMac_MP", BenhAnMatBanPhanTruoc.Nhu_KetMac_MP == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("Hot_KetMac_MP", BenhAnMatBanPhanTruoc.Hot_KetMac_MP == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("Seo_KetMac_MP", BenhAnMatBanPhanTruoc.Seo_KetMac_MP == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("TietToMu_KetMac_MP", BenhAnMatBanPhanTruoc.TietToMu_KetMac_MP == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("TietToTrong_KetMac_MP", BenhAnMatBanPhanTruoc.TietToTrong_KetMac_MP == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("GiaMac_KetMac_MP", BenhAnMatBanPhanTruoc.GiaMac_KetMac_MP == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("BatMauFluor_KetMac_MP", BenhAnMatBanPhanTruoc.BatMauFluor_KetMac_MP == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("TinhChat_UKetMac_MP", BenhAnMatBanPhanTruoc.TinhChat_UKetMac_MP));
            Command.Parameters.Add(new MDB.MDBParameter("ViTri_UKetMac_MP", BenhAnMatBanPhanTruoc.ViTri_UKetMac_MP));
            Command.Parameters.Add(new MDB.MDBParameter("KichThuoc_UKetMac_MP", BenhAnMatBanPhanTruoc.KichThuoc_UKetMac_MP));
            Command.Parameters.Add(new MDB.MDBParameter("CungDo_KetMac_MP", BenhAnMatBanPhanTruoc.CungDo_KetMac_MP));
            Command.Parameters.Add(new MDB.MDBParameter("ChieuCaoCuaCauDinh_KetMac_MP", BenhAnMatBanPhanTruoc.ChieuCaoCuaCauDinh_KetMac_MP));
            Command.Parameters.Add(new MDB.MDBParameter("DoRongCuaCauDinh_KetMac_MP", BenhAnMatBanPhanTruoc.DoRongCuaCauDinh_KetMac_MP));
            Command.Parameters.Add(new MDB.MDBParameter("TonThuongKhac_KetMac_MP", BenhAnMatBanPhanTruoc.TonThuongKhac_KetMac_MP));
            Command.Parameters.Add(new MDB.MDBParameter("KichThuoc_GiacMac_MP", BenhAnMatBanPhanTruoc.KichThuoc_GiacMac_MP));
            Command.Parameters.Add(new MDB.MDBParameter("HinhDang_GiacMac_MP", BenhAnMatBanPhanTruoc.HinhDang_GiacMac_MP));
            Command.Parameters.Add(new MDB.MDBParameter("BieuMo_GiacMac_MP", BenhAnMatBanPhanTruoc.BieuMo_GiacMac_MP == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("PhuBongBieuMo_GiacMac_MP", BenhAnMatBanPhanTruoc.PhuBongBieuMo_GiacMac_MP));
            Command.Parameters.Add(new MDB.MDBParameter("MatBieuMo_GiacMac_MP", BenhAnMatBanPhanTruoc.MatBieuMo_GiacMac_MP));
            Command.Parameters.Add(new MDB.MDBParameter("MatBieuMoKhoangCach_MP", BenhAnMatBanPhanTruoc.MatBieuMoKhoangCach_MP));
            Command.Parameters.Add(new MDB.MDBParameter("BoTonThuong_GM_MP", BenhAnMatBanPhanTruoc.BoTonThuong_GM_MP));
            Command.Parameters.Add(new MDB.MDBParameter("ThoaiThoaDaiBang_MP", BenhAnMatBanPhanTruoc.ThoaiThoaDaiBang_MP == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("LangDongThuoc_MP", BenhAnMatBanPhanTruoc.LangDongThuoc_MP == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("TonThuongKhac_BieuMo_GM_MP", BenhAnMatBanPhanTruoc.TonThuongKhac_BieuMo_GM_MP));
            Command.Parameters.Add(new MDB.MDBParameter("Phu_NhuMo_GiacMac_MP", BenhAnMatBanPhanTruoc.Phu_NhuMo_GiacMac_MP));
            Command.Parameters.Add(new MDB.MDBParameter("ThamLau_NhuMo_GiacMac_MP", BenhAnMatBanPhanTruoc.ThamLau_NhuMo_GiacMac_MP));
            Command.Parameters.Add(new MDB.MDBParameter("ThamLau_Vtri_NhuMo_GiacMac_MP", BenhAnMatBanPhanTruoc.ThamLau_Vtri_NhuMo_GiacMac_MP));
            Command.Parameters.Add(new MDB.MDBParameter("TieuMong_NhuMo_GiacMac_MP", BenhAnMatBanPhanTruoc.TieuMong_NhuMo_GiacMac_MP));
            Command.Parameters.Add(new MDB.MDBParameter("TieuMong_Vtri_NhuMo_GiacMac_MP", BenhAnMatBanPhanTruoc.TieuMong_Vtri_NhuMo_GiacMac_MP));
            Command.Parameters.Add(new MDB.MDBParameter("TonThuongKhac_NhuMo_GiacMac_MP", BenhAnMatBanPhanTruoc.TonThuongKhac_NhuMo_GiacMac_MP));
            Command.Parameters.Add(new MDB.MDBParameter("NepGap_NoiMo_GiacMac_MP", BenhAnMatBanPhanTruoc.NepGap_NoiMo_GiacMac_MP));
            Command.Parameters.Add(new MDB.MDBParameter("TuaSacToMacSauGM_MP", BenhAnMatBanPhanTruoc.TuaSacToMacSauGM_MP == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("MuMatSau_NoiMo_MP", BenhAnMatBanPhanTruoc.MuMatSau_NoiMo_MP == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("XuatTietMatSau_NoiMo_MP", BenhAnMatBanPhanTruoc.XuatTietMatSau_NoiMo_MP == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("Guttata_NoiMo_MP", BenhAnMatBanPhanTruoc.Guttata_NoiMo_MP == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("RanMangDescemet_NoiMo_MP", BenhAnMatBanPhanTruoc.RanMangDescemet_NoiMo_MP == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("CuonDescemet_NoiMo_MP", BenhAnMatBanPhanTruoc.CuonDescemet_NoiMo_MP == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("TonThuongKhac_NoiMo_MP", BenhAnMatBanPhanTruoc.TonThuongKhac_NoiMo_MP));
            Command.Parameters.Add(new MDB.MDBParameter("DoaThung_GiacMac_MP", BenhAnMatBanPhanTruoc.DoaThung_GiacMac_MP == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("KetMongMat_GiacMac_MP", BenhAnMatBanPhanTruoc.KetMongMat_GiacMac_MP == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("ThungGiacMac_MP", BenhAnMatBanPhanTruoc.ThungGiacMac_MP));
            Command.Parameters.Add(new MDB.MDBParameter("Seidel_MP", BenhAnMatBanPhanTruoc.Seidel_MP == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("DuongKinhThungGiacMac_MP", BenhAnMatBanPhanTruoc.DuongKinhThungGiacMac_MP));
            Command.Parameters.Add(new MDB.MDBParameter("ThungBit_GM_MP", BenhAnMatBanPhanTruoc.iThungBit_GM_MP));
            Command.Parameters.Add(new MDB.MDBParameter("CamGiacGiacMac_MP", BenhAnMatBanPhanTruoc.CamGiacGiacMac_MP));
            Command.Parameters.Add(new MDB.MDBParameter("TanMach_GiacMac_MP", BenhAnMatBanPhanTruoc.TanMach_GiacMac_MP));
            Command.Parameters.Add(new MDB.MDBParameter("MucDo_TanMach_GiacMac_MP", BenhAnMatBanPhanTruoc.MucDo_TanMach_GiacMac_MP));
            Command.Parameters.Add(new MDB.MDBParameter("SuyTeBaoNguon_MP", BenhAnMatBanPhanTruoc.SuyTeBaoNguon_MP == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("ThoaiHoaGia_MP", BenhAnMatBanPhanTruoc.ThoaiHoaGia_MP == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("LangDongCanXi_MP", BenhAnMatBanPhanTruoc.LangDongCanXi_MP == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("BatThuongKhac_GiacMac_MP", BenhAnMatBanPhanTruoc.BatThuongKhac_GiacMac_MP));
            Command.Parameters.Add(new MDB.MDBParameter("Viem_CungMac_MP", BenhAnMatBanPhanTruoc.Viem_CungMac_MP));
            Command.Parameters.Add(new MDB.MDBParameter("Viem_NongSau_CungMac_MP", BenhAnMatBanPhanTruoc.iViem_NongSau_CungMac_MP));
            Command.Parameters.Add(new MDB.MDBParameter("ViemThuongCungMac_MP", BenhAnMatBanPhanTruoc.ViemThuongCungMac_MP == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("GianLoi_TieuMong_HoaiTu_MP", BenhAnMatBanPhanTruoc.GianLoi_TieuMong_HoaiTu_MP));
            Command.Parameters.Add(new MDB.MDBParameter("ChiTietKhac_CungMac_MP", BenhAnMatBanPhanTruoc.ChiTietKhac_CungMac_MP));
            Command.Parameters.Add(new MDB.MDBParameter("TienPhong_MP", BenhAnMatBanPhanTruoc.TienPhong_MP));
            Command.Parameters.Add(new MDB.MDBParameter("Mu_TienPhong_MP", BenhAnMatBanPhanTruoc.Mu_TienPhong_MP));
            Command.Parameters.Add(new MDB.MDBParameter("Tydal_MP", BenhAnMatBanPhanTruoc.Tydal_MP == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("MangXuatTiet_MP", BenhAnMatBanPhanTruoc.MangXuatTiet_MP == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("Mau_TienPhong_MP", BenhAnMatBanPhanTruoc.Mau_TienPhong_MP));
            Command.Parameters.Add(new MDB.MDBParameter("TonThuongKhac_TienPhong_MP", BenhAnMatBanPhanTruoc.TonThuongKhac_TienPhong_MP));
            Command.Parameters.Add(new MDB.MDBParameter("NauXop_MP", BenhAnMatBanPhanTruoc.NauXop_MP == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("XoTeo_MP", BenhAnMatBanPhanTruoc.XoTeo_MP == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("CuongTu_MP", BenhAnMatBanPhanTruoc.CuongTu_MP == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("TanMach_MP", BenhAnMatBanPhanTruoc.TanMach_MP == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("Phoi_MP", BenhAnMatBanPhanTruoc.Phoi_MP == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("Ket_MP", BenhAnMatBanPhanTruoc.Ket_MP == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("DuongKinh_DongTu_MP", BenhAnMatBanPhanTruoc.DuongKinh_DongTu_MP));
            Command.Parameters.Add(new MDB.MDBParameter("DongTuTronMeoDinh_MP", BenhAnMatBanPhanTruoc.DongTuTronMeoDinh_MP));
            Command.Parameters.Add(new MDB.MDBParameter("ViTriDinh_DongTu_MP", BenhAnMatBanPhanTruoc.ViTriDinh_DongTu_MP));
            Command.Parameters.Add(new MDB.MDBParameter("PhanXaDongTu_MP", BenhAnMatBanPhanTruoc.PhanXaDongTu_MP));
            Command.Parameters.Add(new MDB.MDBParameter("TonThuongKhac_DongTu_MP", BenhAnMatBanPhanTruoc.TonThuongKhac_DongTu_MP));
            Command.Parameters.Add(new MDB.MDBParameter("ThuyTinhThe_MP", BenhAnMatBanPhanTruoc.iThuyTinhThe_MP));
            Command.Parameters.Add(new MDB.MDBParameter("HinhThaiDuc_ThuyTinhthe_MP", BenhAnMatBanPhanTruoc.HinhThaiDuc_ThuyTinhthe_MP));
            Command.Parameters.Add(new MDB.MDBParameter("IOL_CanLechDuc_MP", BenhAnMatBanPhanTruoc.IOL_CanLechDuc_MP));
            Command.Parameters.Add(new MDB.MDBParameter("IOL_TrongTPHP_MP", BenhAnMatBanPhanTruoc.iIOL_TrongTPHP_MP));
            Command.Parameters.Add(new MDB.MDBParameter("TonThuongKhac_ThuyTinhthe_MP", BenhAnMatBanPhanTruoc.TonThuongKhac_ThuyTinhthe_MP));
            Command.Parameters.Add(new MDB.MDBParameter("AnhDongTu_MP", BenhAnMatBanPhanTruoc.AnhDongTu_MP));
            Command.Parameters.Add(new MDB.MDBParameter("DichKinh_MP", BenhAnMatBanPhanTruoc.DichKinh_MP));
            Command.Parameters.Add(new MDB.MDBParameter("TonThuongKhac_DichKinh_MP", BenhAnMatBanPhanTruoc.TonThuongKhac_DichKinh_MP));
            Command.Parameters.Add(new MDB.MDBParameter("DayMat_MP", BenhAnMatBanPhanTruoc.DayMat_MP));
            Command.Parameters.Add(new MDB.MDBParameter("CD_DayMat_MP", BenhAnMatBanPhanTruoc.CD_DayMat_MP));
            Command.Parameters.Add(new MDB.MDBParameter("PhuGai_MP", BenhAnMatBanPhanTruoc.PhuGai_MP == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("BacMauGaiThi_MP", BenhAnMatBanPhanTruoc.BacMauGaiThi_MP == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("VongMac_DayMat_MP", BenhAnMatBanPhanTruoc.VongMac_DayMat_MP));
            Command.Parameters.Add(new MDB.MDBParameter("HeMachMau_DayMat_MP", BenhAnMatBanPhanTruoc.HeMachMau_DayMat_MP));
            Command.Parameters.Add(new MDB.MDBParameter("TonThuongKhac_DayMat_MP", BenhAnMatBanPhanTruoc.TonThuongKhac_DayMat_MP));
            Command.Parameters.Add(new MDB.MDBParameter("KhongKinh_ThiLuc_MT", BenhAnMatBanPhanTruoc.KhongKinh_ThiLuc_MT));
            Command.Parameters.Add(new MDB.MDBParameter("QuaLo_ThiLuc_MT", BenhAnMatBanPhanTruoc.QuaLo_ThiLuc_MT));
            Command.Parameters.Add(new MDB.MDBParameter("CoChinhKinh_ThiLuc_MT", BenhAnMatBanPhanTruoc.CoChinhKinh_ThiLuc_MT));
            Command.Parameters.Add(new MDB.MDBParameter("NhinGan_ThiLuc_MT", BenhAnMatBanPhanTruoc.NhinGan_ThiLuc_MT));
            Command.Parameters.Add(new MDB.MDBParameter("NhanAp_MT", BenhAnMatBanPhanTruoc.NhanAp_MT));
            Command.Parameters.Add(new MDB.MDBParameter("LacVaVanNhan_MT", BenhAnMatBanPhanTruoc.LacVaVanNhan_MT));
            Command.Parameters.Add(new MDB.MDBParameter("ThoatNuocTot_MT", BenhAnMatBanPhanTruoc.ThoatNuocTot_MT == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("TraoLeQuanDoiDien_MT", BenhAnMatBanPhanTruoc.TraoLeQuanDoiDien_MT == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("TraoLeQuanTaiCho_MT", BenhAnMatBanPhanTruoc.TraoLeQuanTaiCho_MT == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("MiMat_MT", BenhAnMatBanPhanTruoc.MiMat_MT));
            Command.Parameters.Add(new MDB.MDBParameter("Khac_MiMat_MT", BenhAnMatBanPhanTruoc.Khac_MiMat_MT));
            Command.Parameters.Add(new MDB.MDBParameter("UMi_MT", BenhAnMatBanPhanTruoc.UMi_MT == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("TinhChatU_UMi_MT", BenhAnMatBanPhanTruoc.TinhChatU_UMi_MT));
            Command.Parameters.Add(new MDB.MDBParameter("ViTri_UMi_MT", BenhAnMatBanPhanTruoc.ViTri_UMi_MT));
            Command.Parameters.Add(new MDB.MDBParameter("KichThuoc_UMi_MT", BenhAnMatBanPhanTruoc.KichThuoc_UMi_MT));
            Command.Parameters.Add(new MDB.MDBParameter("Quam_MiMat_MT", BenhAnMatBanPhanTruoc.iQuam_MiMat_MT));
            Command.Parameters.Add(new MDB.MDBParameter("MiTren_MiMat_MT", BenhAnMatBanPhanTruoc.MiTren_MiMat_MT));
            Command.Parameters.Add(new MDB.MDBParameter("MiDuoi_MiMat_MT", BenhAnMatBanPhanTruoc.MiDuoi_MiMat_MT));
            Command.Parameters.Add(new MDB.MDBParameter("HoMi_MiMat_MT", BenhAnMatBanPhanTruoc.HoMi_MiMat_MT == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("TreMi_MiMat_MT", BenhAnMatBanPhanTruoc.TreMi_MiMat_MT == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("KhuyetMi_MiMat_MT", BenhAnMatBanPhanTruoc.KhuyetMi_MiMat_MT));
            Command.Parameters.Add(new MDB.MDBParameter("TuyetBoMi_MiMat_MT", BenhAnMatBanPhanTruoc.TuyetBoMi_MiMat_MT));
            Command.Parameters.Add(new MDB.MDBParameter("ViemBoMi_MiMat_MT", BenhAnMatBanPhanTruoc.ViemBoMi_MiMat_MT == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("TonThuongKhac_MiMat_MT", BenhAnMatBanPhanTruoc.TonThuongKhac_MiMat_MT));
            Command.Parameters.Add(new MDB.MDBParameter("CuongTu_KetMac_MT", BenhAnMatBanPhanTruoc.CuongTu_KetMac_MT));
            Command.Parameters.Add(new MDB.MDBParameter("PhuNe_KetMac_MT", BenhAnMatBanPhanTruoc.PhuNe_KetMac_MT == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("XuatHuyet_KetMac_MT", BenhAnMatBanPhanTruoc.XuatHuyet_KetMac_MT == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("SungHoa_KetMac_MT", BenhAnMatBanPhanTruoc.SungHoa_KetMac_MT == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("Nhu_KetMac_MT", BenhAnMatBanPhanTruoc.Nhu_KetMac_MT == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("Hot_KetMac_MT", BenhAnMatBanPhanTruoc.Hot_KetMac_MT == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("Seo_KetMac_MT", BenhAnMatBanPhanTruoc.Seo_KetMac_MT == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("TietToMu_KetMac_MT", BenhAnMatBanPhanTruoc.TietToMu_KetMac_MT == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("TietToTrong_KetMac_MT", BenhAnMatBanPhanTruoc.TietToTrong_KetMac_MT == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("GiaMac_KetMac_MT", BenhAnMatBanPhanTruoc.GiaMac_KetMac_MT == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("BatMauFluor_KetMac_MT", BenhAnMatBanPhanTruoc.BatMauFluor_KetMac_MT == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("TinhChat_UKetMac_MT", BenhAnMatBanPhanTruoc.TinhChat_UKetMac_MT));
            Command.Parameters.Add(new MDB.MDBParameter("ViTri_UKetMac_MT", BenhAnMatBanPhanTruoc.ViTri_UKetMac_MT));
            Command.Parameters.Add(new MDB.MDBParameter("KichThuoc_UKetMac_MT", BenhAnMatBanPhanTruoc.KichThuoc_UKetMac_MT));
            Command.Parameters.Add(new MDB.MDBParameter("CungDo_KetMac_MT", BenhAnMatBanPhanTruoc.CungDo_KetMac_MT));
            Command.Parameters.Add(new MDB.MDBParameter("ChieuCaoCuaCauDinh_KetMac_MT", BenhAnMatBanPhanTruoc.ChieuCaoCuaCauDinh_KetMac_MT));
            Command.Parameters.Add(new MDB.MDBParameter("DoRongCuaCauDinh_KetMac_MT", BenhAnMatBanPhanTruoc.DoRongCuaCauDinh_KetMac_MT));
            Command.Parameters.Add(new MDB.MDBParameter("TonThuongKhac_KetMac_MT", BenhAnMatBanPhanTruoc.TonThuongKhac_KetMac_MT));
            Command.Parameters.Add(new MDB.MDBParameter("KichThuoc_GiacMac_MT", BenhAnMatBanPhanTruoc.KichThuoc_GiacMac_MT));
            Command.Parameters.Add(new MDB.MDBParameter("HinhDang_GiacMac_MT", BenhAnMatBanPhanTruoc.HinhDang_GiacMac_MT));
            Command.Parameters.Add(new MDB.MDBParameter("BieuMo_GiacMac_MT", BenhAnMatBanPhanTruoc.BieuMo_GiacMac_MT == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("PhuBongBieuMo_GiacMac_MT", BenhAnMatBanPhanTruoc.PhuBongBieuMo_GiacMac_MT));
            Command.Parameters.Add(new MDB.MDBParameter("MatBieuMo_GiacMac_MT", BenhAnMatBanPhanTruoc.MatBieuMo_GiacMac_MT));
            Command.Parameters.Add(new MDB.MDBParameter("MatBieuMoKhoangCach_MT", BenhAnMatBanPhanTruoc.MatBieuMoKhoangCach_MT));
            Command.Parameters.Add(new MDB.MDBParameter("BoTonThuong_GM_MT", BenhAnMatBanPhanTruoc.BoTonThuong_GM_MT));
            Command.Parameters.Add(new MDB.MDBParameter("ThoaiThoaDaiBang_MT", BenhAnMatBanPhanTruoc.ThoaiThoaDaiBang_MT == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("LangDongThuoc_MT", BenhAnMatBanPhanTruoc.LangDongThuoc_MT == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("TonThuongKhac_BieuMo_GM_MT_TXT", BenhAnMatBanPhanTruoc.TonThuongKhac_BieuMo_GM_MT_TXT));
            Command.Parameters.Add(new MDB.MDBParameter("Phu_NhuMo_GiacMac_MT", BenhAnMatBanPhanTruoc.Phu_NhuMo_GiacMac_MT));
            Command.Parameters.Add(new MDB.MDBParameter("ThamLau_NhuMo_GiacMac_MT", BenhAnMatBanPhanTruoc.ThamLau_NhuMo_GiacMac_MT));
            Command.Parameters.Add(new MDB.MDBParameter("ThamLau_Vtri_NhuMo_GiacMac_MT", BenhAnMatBanPhanTruoc.ThamLau_Vtri_NhuMo_GiacMac_MT));
            Command.Parameters.Add(new MDB.MDBParameter("TieuMong_NhuMo_GiacMac_MT", BenhAnMatBanPhanTruoc.TieuMong_NhuMo_GiacMac_MT));
            Command.Parameters.Add(new MDB.MDBParameter("TieuMong_Vtri_NhuMo_GiacMac_MT", BenhAnMatBanPhanTruoc.TieuMong_Vtri_NhuMo_GiacMac_MT));
            Command.Parameters.Add(new MDB.MDBParameter("TonThuongKhac_NhuMo_GiacMac_MT", BenhAnMatBanPhanTruoc.TonThuongKhac_NhuMo_GiacMac_MT));
            Command.Parameters.Add(new MDB.MDBParameter("NepGap_NoiMo_GiacMac_MT", BenhAnMatBanPhanTruoc.NepGap_NoiMo_GiacMac_MT));
            Command.Parameters.Add(new MDB.MDBParameter("TuaSacToMacSauGM_MT", BenhAnMatBanPhanTruoc.TuaSacToMacSauGM_MT == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("MuMatSau_NoiMo_MT", BenhAnMatBanPhanTruoc.MuMatSau_NoiMo_MT == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("XuatTietMatSau_NoiMo_MT", BenhAnMatBanPhanTruoc.XuatTietMatSau_NoiMo_MT == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("Guttata_NoiMo_MT", BenhAnMatBanPhanTruoc.Guttata_NoiMo_MT == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("RanMangDescemet_NoiMo_MT", BenhAnMatBanPhanTruoc.RanMangDescemet_NoiMo_MT == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("CuonDescemet_NoiMo_MT", BenhAnMatBanPhanTruoc.CuonDescemet_NoiMo_MT == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("TonThuongKhac_NoiMo_MT", BenhAnMatBanPhanTruoc.TonThuongKhac_NoiMo_MT));
            Command.Parameters.Add(new MDB.MDBParameter("DoaThung_GiacMac_MT", BenhAnMatBanPhanTruoc.DoaThung_GiacMac_MT == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("KetMongMat_GiacMac_MT", BenhAnMatBanPhanTruoc.KetMongMat_GiacMac_MT == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("ThungGiacMac_MT", BenhAnMatBanPhanTruoc.ThungGiacMac_MT));
            Command.Parameters.Add(new MDB.MDBParameter("Seidel_MT", BenhAnMatBanPhanTruoc.Seidel_MT == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("DuongKinhThungGiacMac_MT", BenhAnMatBanPhanTruoc.DuongKinhThungGiacMac_MT));
            Command.Parameters.Add(new MDB.MDBParameter("ThungBit_GM_MT", BenhAnMatBanPhanTruoc.iThungBit_GM_MT));
            Command.Parameters.Add(new MDB.MDBParameter("CamGiacGiacMac_MT", BenhAnMatBanPhanTruoc.CamGiacGiacMac_MT));
            Command.Parameters.Add(new MDB.MDBParameter("TanMach_GiacMac_MT", BenhAnMatBanPhanTruoc.TanMach_GiacMac_MT));
            Command.Parameters.Add(new MDB.MDBParameter("MucDo_TanMach_GiacMac_MT", BenhAnMatBanPhanTruoc.MucDo_TanMach_GiacMac_MT));
            Command.Parameters.Add(new MDB.MDBParameter("SuyTeBaoNguon_MT", BenhAnMatBanPhanTruoc.SuyTeBaoNguon_MT == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("ThoaiHoaGia_MT", BenhAnMatBanPhanTruoc.ThoaiHoaGia_MT == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("LangDongCanXi_MT", BenhAnMatBanPhanTruoc.LangDongCanXi_MT == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("BatThuongKhac_GiacMac_MT", BenhAnMatBanPhanTruoc.BatThuongKhac_GiacMac_MT));
            Command.Parameters.Add(new MDB.MDBParameter("Viem_CungMac_MT", BenhAnMatBanPhanTruoc.Viem_CungMac_MT));
            Command.Parameters.Add(new MDB.MDBParameter("Viem_NongSau_CungMac_MT", BenhAnMatBanPhanTruoc.iViem_NongSau_CungMac_MT));
            Command.Parameters.Add(new MDB.MDBParameter("ViemThuongCungMac_MT", BenhAnMatBanPhanTruoc.ViemThuongCungMac_MT == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("GianLoi_TieuMong_HoaiTu_MT", BenhAnMatBanPhanTruoc.GianLoi_TieuMong_HoaiTu_MT));
            Command.Parameters.Add(new MDB.MDBParameter("ChiTietKhac_CungMac_MT", BenhAnMatBanPhanTruoc.ChiTietKhac_CungMac_MT));
            Command.Parameters.Add(new MDB.MDBParameter("TienPhong_MT", BenhAnMatBanPhanTruoc.TienPhong_MT));
            Command.Parameters.Add(new MDB.MDBParameter("Mu_TienPhong_MT", BenhAnMatBanPhanTruoc.Mu_TienPhong_MT));
            Command.Parameters.Add(new MDB.MDBParameter("Tydal_MT", BenhAnMatBanPhanTruoc.Tydal_MT == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("MangXuatTiet_MT", BenhAnMatBanPhanTruoc.MangXuatTiet_MT == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("Mau_TienPhong_MT", BenhAnMatBanPhanTruoc.Mau_TienPhong_MT));
            Command.Parameters.Add(new MDB.MDBParameter("TonThuongKhac_TienPhong_MT", BenhAnMatBanPhanTruoc.TonThuongKhac_TienPhong_MT));
            Command.Parameters.Add(new MDB.MDBParameter("NauXop_MT", BenhAnMatBanPhanTruoc.NauXop_MT == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("XoTeo_MT", BenhAnMatBanPhanTruoc.XoTeo_MT == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("CuongTu_MT", BenhAnMatBanPhanTruoc.CuongTu_MT == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("TanMach_MT", BenhAnMatBanPhanTruoc.TanMach_MT == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("Phoi_MT", BenhAnMatBanPhanTruoc.Phoi_MT == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("Ket_MT", BenhAnMatBanPhanTruoc.Ket_MT == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("DuongKinh_DongTu_MT", BenhAnMatBanPhanTruoc.DuongKinh_DongTu_MT));
            Command.Parameters.Add(new MDB.MDBParameter("DongTuTronMeoDinh_MT", BenhAnMatBanPhanTruoc.DongTuTronMeoDinh_MT));
            Command.Parameters.Add(new MDB.MDBParameter("ViTriDinh_DongTu_MT", BenhAnMatBanPhanTruoc.ViTriDinh_DongTu_MT));
            Command.Parameters.Add(new MDB.MDBParameter("PhanXaDongTu_MT", BenhAnMatBanPhanTruoc.PhanXaDongTu_MT));
            Command.Parameters.Add(new MDB.MDBParameter("TonThuongKhac_DongTu_MT", BenhAnMatBanPhanTruoc.TonThuongKhac_DongTu_MT));
            Command.Parameters.Add(new MDB.MDBParameter("ThuyTinhThe_MT", BenhAnMatBanPhanTruoc.iThuyTinhThe_MT));
            Command.Parameters.Add(new MDB.MDBParameter("HinhThaiDuc_ThuyTinhthe_MT", BenhAnMatBanPhanTruoc.HinhThaiDuc_ThuyTinhthe_MT));
            Command.Parameters.Add(new MDB.MDBParameter("IOL_CanLechDuc_MT", BenhAnMatBanPhanTruoc.IOL_CanLechDuc_MT));
            Command.Parameters.Add(new MDB.MDBParameter("IOL_TrongTPHP_MT", BenhAnMatBanPhanTruoc.iIOL_TrongTPHP_MT));
            Command.Parameters.Add(new MDB.MDBParameter("TonThuongKhac_ThuyTinhthe_MT", BenhAnMatBanPhanTruoc.TonThuongKhac_ThuyTinhthe_MT));
            Command.Parameters.Add(new MDB.MDBParameter("AnhDongTu_MT", BenhAnMatBanPhanTruoc.AnhDongTu_MT));
            Command.Parameters.Add(new MDB.MDBParameter("DichKinh_MT", BenhAnMatBanPhanTruoc.DichKinh_MT));
            Command.Parameters.Add(new MDB.MDBParameter("TonThuongKhac_DichKinh_MT", BenhAnMatBanPhanTruoc.TonThuongKhac_DichKinh_MT));
            Command.Parameters.Add(new MDB.MDBParameter("DayMat_MT", BenhAnMatBanPhanTruoc.DayMat_MT));
            Command.Parameters.Add(new MDB.MDBParameter("CD_DayMat_MT", BenhAnMatBanPhanTruoc.CD_DayMat_MT));
            Command.Parameters.Add(new MDB.MDBParameter("PhuGai_MT", BenhAnMatBanPhanTruoc.PhuGai_MT == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("BacMauGaiThi_MT", BenhAnMatBanPhanTruoc.BacMauGaiThi_MT == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("VongMac_DayMat_MT", BenhAnMatBanPhanTruoc.VongMac_DayMat_MT));
            Command.Parameters.Add(new MDB.MDBParameter("HeMachMau_DayMat_MT", BenhAnMatBanPhanTruoc.HeMachMau_DayMat_MT));
            Command.Parameters.Add(new MDB.MDBParameter("TonThuongKhac_DayMat_MT", BenhAnMatBanPhanTruoc.TonThuongKhac_DayMat_MT));
            Command.Parameters.Add(new MDB.MDBParameter("HuyetAp_ToanThan", BenhAnMatBanPhanTruoc.HuyetAp_ToanThan));
            Command.Parameters.Add(new MDB.MDBParameter("NhietDo_ToanThan", BenhAnMatBanPhanTruoc.NhietDo_ToanThan));
            Command.Parameters.Add(new MDB.MDBParameter("Mach_ToanThan", BenhAnMatBanPhanTruoc.Mach_ToanThan));
            Command.Parameters.Add(new MDB.MDBParameter("NoiTiet_Tick", BenhAnMatBanPhanTruoc.NoiTiet_Tick == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("NoiTiet", BenhAnMatBanPhanTruoc.NoiTiet));
            Command.Parameters.Add(new MDB.MDBParameter("ThanKinh_Tick", BenhAnMatBanPhanTruoc.ThanKinh_Tick == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("TuanHoan_Tick", BenhAnMatBanPhanTruoc.TuanHoan_Tick == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("HoHap_Tick", BenhAnMatBanPhanTruoc.HoHap_Tick == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("TieuHoa_Tick", BenhAnMatBanPhanTruoc.TieuHoa_Tick == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("CoXuongKhop_Tick", BenhAnMatBanPhanTruoc.CoXuongKhop_Tick == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("ThanTietNieu_Tick", BenhAnMatBanPhanTruoc.ThanTietNieu_Tick == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("BenhChinh_MatPhai", BenhAnMatBanPhanTruoc.BenhChinh_MatPhai));
            Command.Parameters.Add(new MDB.MDBParameter("BenhChinh_MatTrai", BenhAnMatBanPhanTruoc.BenhChinh_MatTrai));
            Command.Parameters.Add(new MDB.MDBParameter("PhuongPhapChinh", BenhAnMatBanPhanTruoc.PhuongPhapChinh));
            Command.Parameters.Add(new MDB.MDBParameter("CheDoAnUong", BenhAnMatBanPhanTruoc.CheDoAnUong));
            Command.Parameters.Add(new MDB.MDBParameter("CheDoChamSoc", BenhAnMatBanPhanTruoc.CheDoChamSoc));
            Command.Parameters.Add(new MDB.MDBParameter("ChanDoanBenhChinh_LamSang", BenhAnMatBanPhanTruoc.ChanDoanBenhChinh_LamSang));
            Command.Parameters.Add(new MDB.MDBParameter("ChanDoanBenhChinh_NguyenNhan", BenhAnMatBanPhanTruoc.ChanDoanBenhChinh_NguyenNhan));
            Command.Parameters.Add(new MDB.MDBParameter("QuaTrinhDieuTri_NoiKhoa", BenhAnMatBanPhanTruoc.QuaTrinhDieuTri_NoiKhoa));
            Command.Parameters.Add(new MDB.MDBParameter("QuaTrinhDieuTri_KetQua", BenhAnMatBanPhanTruoc.QuaTrinhDieuTri_KetQua));
            Command.Parameters.Add(new MDB.MDBParameter("QuaTrinhDieuTri_BienChung", BenhAnMatBanPhanTruoc.QuaTrinhDieuTri_BienChung));
            Command.Parameters.Add(new MDB.MDBParameter("HuongDieuTriTiep", BenhAnMatBanPhanTruoc.HuongDieuTriTiep));
            Command.Parameters.Add(new MDB.MDBParameter("MiMat_T", BenhAnMatBanPhanTruoc.MiMat_T));
            Command.Parameters.Add(new MDB.MDBParameter("MiMat_P", BenhAnMatBanPhanTruoc.MiMat_P));
            Command.Parameters.Add(new MDB.MDBParameter("ChuaThayBenhLy", BenhAnMatBanPhanTruoc.ChuaThayBenhLy ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("BenhLy", BenhAnMatBanPhanTruoc.BenhLy ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("BenhLy_Text", BenhAnMatBanPhanTruoc.BenhLy_Text));
            Command.Parameters.Add(new MDB.MDBParameter("PhauThuat", BenhAnMatBanPhanTruoc.PhauThuat == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("ThuThuat", BenhAnMatBanPhanTruoc.ThuThuat == true ? "1" : "0"));

            Command.Parameters.Add(new MDB.MDBParameter("ThiLucKhiRaVien_KhongKinh_MP", BenhAnMatBanPhanTruoc.ThiLucKhiRaVien_KhongKinh_MP));
            Command.Parameters.Add(new MDB.MDBParameter("ThiLucKhiRaVien_KhongKinh_MT", BenhAnMatBanPhanTruoc.ThiLucKhiRaVien_KhongKinh_MT));
            Command.Parameters.Add(new MDB.MDBParameter("ThiLucKhiRaVien_CoKinh_MP", BenhAnMatBanPhanTruoc.ThiLucKhiRaVien_CoKinh_MP));
            Command.Parameters.Add(new MDB.MDBParameter("ThiLucKhiRaVien_CoKinh_MT", BenhAnMatBanPhanTruoc.ThiLucKhiRaVien_CoKinh_MT));
            Command.Parameters.Add(new MDB.MDBParameter("NhanApRaVien_MT", BenhAnMatBanPhanTruoc.NhanApRaVien_MT));
            Command.Parameters.Add(new MDB.MDBParameter("NhanApRaVien_MP", BenhAnMatBanPhanTruoc.NhanApRaVien_MP));
            Command.Parameters.Add(new MDB.MDBParameter("ThoatNuocTot_MP_Text", BenhAnMatBanPhanTruoc.ThoatNuocTot_MP_Text));
            Command.Parameters.Add(new MDB.MDBParameter("ThoatNuocTot_MT_Text", BenhAnMatBanPhanTruoc.ThoatNuocTot_MT_Text));
            Command.Parameters.Add(new MDB.MDBParameter("TraoLeQuanDoiDien_MP_Text", BenhAnMatBanPhanTruoc.TraoLeQuanDoiDien_MP_Text));
            Command.Parameters.Add(new MDB.MDBParameter("TraoLeQuanDoiDien_MT_Text", BenhAnMatBanPhanTruoc.TraoLeQuanDoiDien_MT_Text));
            Command.Parameters.Add(new MDB.MDBParameter("TraoLeQuanTaiCho_MP_Text", BenhAnMatBanPhanTruoc.TraoLeQuanTaiCho_MP_Text));
            Command.Parameters.Add(new MDB.MDBParameter("TraoLeQuanTaiCho_MT_Text", BenhAnMatBanPhanTruoc.TraoLeQuanTaiCho_MT_Text));
            Command.Parameters.Add(new MDB.MDBParameter("KetMac_Mong_MP", BenhAnMatBanPhanTruoc.KetMac_Mong_MP));
            Command.Parameters.Add(new MDB.MDBParameter("KetMac_Mong_MT", BenhAnMatBanPhanTruoc.KetMac_Mong_MT));
            Command.Parameters.Add(new MDB.MDBParameter("GhepGiacMac_MP", BenhAnMatBanPhanTruoc.GhepGiacMac_MP ? "1":"0"));
            Command.Parameters.Add(new MDB.MDBParameter("GhepGiacMac_MT", BenhAnMatBanPhanTruoc.GhepGiacMac_MT ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("BieuMo_GiacMac_BT_MP", BenhAnMatBanPhanTruoc.BieuMo_GiacMac_BT_MP ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("BieuMo_GiacMac_BT_MT", BenhAnMatBanPhanTruoc.BieuMo_GiacMac_BT_MT ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("NhuMo_GiacMac_BT_MP", BenhAnMatBanPhanTruoc.NhuMo_GiacMac_BT_MP ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("NhuMo_GiacMac_BT_MT", BenhAnMatBanPhanTruoc.NhuMo_GiacMac_BT_MT ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("NoiMo_GiacMac_BT_MP", BenhAnMatBanPhanTruoc.NoiMo_GiacMac_BT_MP ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("NoiMo_GiacMac_BT_MT", BenhAnMatBanPhanTruoc.NoiMo_GiacMac_BT_MT ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("CungMac_BT_MP", BenhAnMatBanPhanTruoc.CungMac_BT_MP ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("CungMac_BT_MT", BenhAnMatBanPhanTruoc.CungMac_BT_MT ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("Khuyet_MP", BenhAnMatBanPhanTruoc.Khuyet_MP ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("Khuyet_MT", BenhAnMatBanPhanTruoc.Khuyet_MT ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("Khac_MongMat_MP", BenhAnMatBanPhanTruoc.Khac_MongMat_MP));
            Command.Parameters.Add(new MDB.MDBParameter("Khac_MongMat_MT", BenhAnMatBanPhanTruoc.Khac_MongMat_MT));

            Command.Parameters.Add(new MDB.MDBParameter("NoiTietCheck", BenhAnMatBanPhanTruoc.NoiTietCheck));
            Command.Parameters.Add(new MDB.MDBParameter("NoiTiet_Text", BenhAnMatBanPhanTruoc.NoiTiet_Text));
            Command.Parameters.Add(new MDB.MDBParameter("ThanKinhCheck", BenhAnMatBanPhanTruoc.ThanKinhCheck));
            Command.Parameters.Add(new MDB.MDBParameter("ThanKinh_Text", BenhAnMatBanPhanTruoc.ThanKinh_Text));
            Command.Parameters.Add(new MDB.MDBParameter("TuanHoanCheck", BenhAnMatBanPhanTruoc.TuanHoanCheck));
            Command.Parameters.Add(new MDB.MDBParameter("TuanHoan_Text", BenhAnMatBanPhanTruoc.TuanHoan_Text));
            Command.Parameters.Add(new MDB.MDBParameter("HoHapCheck", BenhAnMatBanPhanTruoc.HoHapCheck));
            Command.Parameters.Add(new MDB.MDBParameter("HoHap_Text", BenhAnMatBanPhanTruoc.HoHap_Text));
            Command.Parameters.Add(new MDB.MDBParameter("TieuHoaCheck", BenhAnMatBanPhanTruoc.TieuHoaCheck));
            Command.Parameters.Add(new MDB.MDBParameter("TieuHoa_Text", BenhAnMatBanPhanTruoc.TieuHoa_Text));
            Command.Parameters.Add(new MDB.MDBParameter("CoXuongKhopCheck", BenhAnMatBanPhanTruoc.CoXuongKhopCheck));
            Command.Parameters.Add(new MDB.MDBParameter("CoXuongKhop_Text", BenhAnMatBanPhanTruoc.CoXuongKhop_Text));
            Command.Parameters.Add(new MDB.MDBParameter("TietNieuSinhDucCheck", BenhAnMatBanPhanTruoc.TietNieuSinhDucCheck));
            Command.Parameters.Add(new MDB.MDBParameter("TietNieuSinhDuc_Text", BenhAnMatBanPhanTruoc.TietNieuSinhDuc_Text));
            Command.Parameters.Add(new MDB.MDBParameter("KhamBenhToanThan_Khac", BenhAnMatBanPhanTruoc.KhamBenhToanThan_Khac));

            int n = Command.ExecuteNonQuery(); // C#
            return n > 0 ? true : false;
        }
        public static bool Update(MDB.MDBConnection MyConnection, BenhAnMatBanPhanTruoc BenhAnMatBanPhanTruoc)
        {
            string sql = @"UPDATE BenhAnMatBanPhanTruoc SET 
                        LyDoVaoVien = :LyDoVaoVien,
                        VaoNgayThu = :VaoNgayThu,
                        QuaTrinhBenhLy = :QuaTrinhBenhLy,
                        TienSuBenhBanThan = :TienSuBenhBanThan,
                        TienSuBenhGiaDinh = :TienSuBenhGiaDinh,
                        ToanThan = :ToanThan,
                        TuanHoan = :TuanHoan,
                        HoHap = :HoHap,
                        TieuHoa = :TieuHoa,
                        ThanTietNieuSinhDuc = :ThanTietNieuSinhDuc,
                        ThanKinh = :ThanKinh,
                        CoXuongKhop = :CoXuongKhop,
                        TaiMuiHong = :TaiMuiHong,
                        RangHamMat = :RangHamMat,
                        Mat = :Mat,
                        Khac_CacCoQuan = :Khac_CacCoQuan,
                        CacXetNghiemCanLamSangCanLam = :CacXetNghiemCanLamSangCanLam,
                        TomTatBenhAn = :TomTatBenhAn,
                        BenhChinh = :BenhChinh,
                        BenhKemTheo = :BenhKemTheo,
                        PhanBiet = :PhanBiet,
                        TienLuong = :TienLuong,
                        HuongDieuTri = :HuongDieuTri,
                        NgayKhamBenh = :NgayKhamBenh,
                        BacSyLamBenhAn = :BacSyLamBenhAn,
                        QuaTrinhBenhLyVaDienBien = :QuaTrinhBenhLyVaDienBien,
                        TomTatKetQuaXetNghiem = :TomTatKetQuaXetNghiem,
                        PhuongPhapDieuTri = :PhuongPhapDieuTri,
                        TinhTrangNguoiBenhRaVien = :TinhTrangNguoiBenhRaVien,
                        HuongDieuTriVaCacCheDoTiepTheo = :HuongDieuTriVaCacCheDoTiepTheo,
                        NguoiNhanHoSo = :NguoiNhanHoSo,
                        NguoiGiaoHoSo = :NguoiGiaoHoSo,
                        NgayTongKet = :NgayTongKet,
                        BacSyDieuTri = :BacSyDieuTri,
                        DiUng = :DiUng,
                        DiUng_Text = :DiUng_Text,
                        MaTuy = :MaTuy,
                        MaTuy_Text = :MaTuy_Text,
                        RuouBia = :RuouBia,
                        RuouBia_Text = :RuouBia_Text,
                        ThuocLa = :ThuocLa,
                        ThuocLa_Text = :ThuocLa_Text,
                        ThuocLao = :ThuocLao,
                        ThuocLao_Text = :ThuocLao_Text,
                        Khac_DacDiemLienQuanBenh = :Khac_DacDiemLienQuanBenh,
                        Khac_DacDiemLienQuanBenh_Text = :Khac_DacDiemLienQuanBenh_Text,
ThoiGianXuatHienBenh = :ThoiGianXuatHienBenh,
NguyenNhan_BenhSu = :NguyenNhan_BenhSu,
CacPhuongPhapDaDieuTri_BenhSu = :CacPhuongPhapDaDieuTri_BenhSu,
TienSuBenhBanThan_Mat = :TienSuBenhBanThan_Mat,
TienSuBenhGiaDinh_Mat = :TienSuBenhGiaDinh_Mat,
KhongKinh_ThiLuc_MP = :KhongKinh_ThiLuc_MP,
QuaLo_ThiLuc_MP = :QuaLo_ThiLuc_MP,
CoChinhKinh_ThiLuc_MP = :CoChinhKinh_ThiLuc_MP,
NhinGan_ThiLuc_MP = :NhinGan_ThiLuc_MP,
NhanAp_MP = :NhanAp_MP,
LacVaVanNhan_MP = :LacVaVanNhan_MP,
ThoatNuocTot_MP = :ThoatNuocTot_MP,
TraoLeQuanDoiDien_MP = :TraoLeQuanDoiDien_MP,
TraoLeQuanTaiCho_MP = :TraoLeQuanTaiCho_MP,
MiMat_MP = :MiMat_MP,
Khac_MiMat_MP = :Khac_MiMat_MP,
UMi_MP = :UMi_MP,
TinhChatU_UMi_MP = :TinhChatU_UMi_MP,
ViTri_UMi_MP = :ViTri_UMi_MP,
KichThuoc_UMi_MP = :KichThuoc_UMi_MP,
Quam_MiMat_MP = :Quam_MiMat_MP,
MiTren_MiMat_MP = :MiTren_MiMat_MP,
MiDuoi_MiMat_MP = :MiDuoi_MiMat_MP,
HoMi_MiMat_MP = :HoMi_MiMat_MP,
TreMi_MiMat_MP = :TreMi_MiMat_MP,
KhuyetMi_MiMat_MP = :KhuyetMi_MiMat_MP,
TuyetBoMi_MiMat_MP = :TuyetBoMi_MiMat_MP,
ViemBoMi_MiMat_MP = :ViemBoMi_MiMat_MP,
TonThuongKhac_MiMat_MP = :TonThuongKhac_MiMat_MP,
CuongTu_KetMac_MP = :CuongTu_KetMac_MP,
PhuNe_KetMac_MP = :PhuNe_KetMac_MP,
XuatHuyet_KetMac_MP = :XuatHuyet_KetMac_MP,
SungHoa_KetMac_MP = :SungHoa_KetMac_MP,
Nhu_KetMac_MP = :Nhu_KetMac_MP,
Hot_KetMac_MP = :Hot_KetMac_MP,
Seo_KetMac_MP = :Seo_KetMac_MP,
TietToMu_KetMac_MP = :TietToMu_KetMac_MP,
TietToTrong_KetMac_MP = :TietToTrong_KetMac_MP,
GiaMac_KetMac_MP = :GiaMac_KetMac_MP,
BatMauFluor_KetMac_MP = :BatMauFluor_KetMac_MP,
TinhChat_UKetMac_MP = :TinhChat_UKetMac_MP,
ViTri_UKetMac_MP = :ViTri_UKetMac_MP,
KichThuoc_UKetMac_MP = :KichThuoc_UKetMac_MP,
CungDo_KetMac_MP = :CungDo_KetMac_MP,
ChieuCaoCuaCauDinh_KetMac_MP = :ChieuCaoCuaCauDinh_KetMac_MP,
DoRongCuaCauDinh_KetMac_MP = :DoRongCuaCauDinh_KetMac_MP,
TonThuongKhac_KetMac_MP = :TonThuongKhac_KetMac_MP,
KichThuoc_GiacMac_MP = :KichThuoc_GiacMac_MP,
HinhDang_GiacMac_MP = :HinhDang_GiacMac_MP,
BieuMo_GiacMac_MP = :BieuMo_GiacMac_MP,
PhuBongBieuMo_GiacMac_MP = :PhuBongBieuMo_GiacMac_MP,
MatBieuMo_GiacMac_MP = :MatBieuMo_GiacMac_MP,
MatBieuMoKhoangCach_MP = :MatBieuMoKhoangCach_MP,
BoTonThuong_GM_MP = :BoTonThuong_GM_MP,
ThoaiThoaDaiBang_MP = :ThoaiThoaDaiBang_MP,
LangDongThuoc_MP = :LangDongThuoc_MP,
TonThuongKhac_BieuMo_GM_MP = :TonThuongKhac_BieuMo_GM_MP,
Phu_NhuMo_GiacMac_MP = :Phu_NhuMo_GiacMac_MP,
ThamLau_NhuMo_GiacMac_MP = :ThamLau_NhuMo_GiacMac_MP,
ThamLau_Vtri_NhuMo_GiacMac_MP = :ThamLau_Vtri_NhuMo_GiacMac_MP,
TieuMong_NhuMo_GiacMac_MP = :TieuMong_NhuMo_GiacMac_MP,
TieuMong_Vtri_NhuMo_GiacMac_MP = :TieuMong_Vtri_NhuMo_GiacMac_MP,
TonThuongKhac_NhuMo_GiacMac_MP = :TonThuongKhac_NhuMo_GiacMac_MP,
NepGap_NoiMo_GiacMac_MP = :NepGap_NoiMo_GiacMac_MP,
TuaSacToMacSauGM_MP = :TuaSacToMacSauGM_MP,
MuMatSau_NoiMo_MP = :MuMatSau_NoiMo_MP,
XuatTietMatSau_NoiMo_MP = :XuatTietMatSau_NoiMo_MP,
Guttata_NoiMo_MP = :Guttata_NoiMo_MP,
RanMangDescemet_NoiMo_MP = :RanMangDescemet_NoiMo_MP,
CuonDescemet_NoiMo_MP = :CuonDescemet_NoiMo_MP,
TonThuongKhac_NoiMo_MP = :TonThuongKhac_NoiMo_MP,
DoaThung_GiacMac_MP = :DoaThung_GiacMac_MP,
KetMongMat_GiacMac_MP = :KetMongMat_GiacMac_MP,
ThungGiacMac_MP = :ThungGiacMac_MP,
Seidel_MP = :Seidel_MP,
DuongKinhThungGiacMac_MP = :DuongKinhThungGiacMac_MP,
ThungBit_GM_MP = :ThungBit_GM_MP,
CamGiacGiacMac_MP = :CamGiacGiacMac_MP,
TanMach_GiacMac_MP = :TanMach_GiacMac_MP,
MucDo_TanMach_GiacMac_MP = :MucDo_TanMach_GiacMac_MP,
SuyTeBaoNguon_MP = :SuyTeBaoNguon_MP,
ThoaiHoaGia_MP = :ThoaiHoaGia_MP,
LangDongCanXi_MP = :LangDongCanXi_MP,
BatThuongKhac_GiacMac_MP = :BatThuongKhac_GiacMac_MP,
Viem_CungMac_MP = :Viem_CungMac_MP,
Viem_NongSau_CungMac_MP = :Viem_NongSau_CungMac_MP,
ViemThuongCungMac_MP = :ViemThuongCungMac_MP,
GianLoi_TieuMong_HoaiTu_MP = :GianLoi_TieuMong_HoaiTu_MP,
ChiTietKhac_CungMac_MP = :ChiTietKhac_CungMac_MP,
TienPhong_MP = :TienPhong_MP,
Mu_TienPhong_MP = :Mu_TienPhong_MP,
Tydal_MP = :Tydal_MP,
MangXuatTiet_MP = :MangXuatTiet_MP,
Mau_TienPhong_MP = :Mau_TienPhong_MP,
TonThuongKhac_TienPhong_MP = :TonThuongKhac_TienPhong_MP,
NauXop_MP = :NauXop_MP,
XoTeo_MP = :XoTeo_MP,
CuongTu_MP = :CuongTu_MP,
TanMach_MP = :TanMach_MP,
Phoi_MP = :Phoi_MP,
Ket_MP = :Ket_MP,
DuongKinh_DongTu_MP = :DuongKinh_DongTu_MP,
DongTuTronMeoDinh_MP = :DongTuTronMeoDinh_MP,
ViTriDinh_DongTu_MP = :ViTriDinh_DongTu_MP,
PhanXaDongTu_MP = :PhanXaDongTu_MP,
TonThuongKhac_DongTu_MP = :TonThuongKhac_DongTu_MP,
ThuyTinhThe_MP = :ThuyTinhThe_MP,
HinhThaiDuc_ThuyTinhthe_MP = :HinhThaiDuc_ThuyTinhthe_MP,
IOL_CanLechDuc_MP = :IOL_CanLechDuc_MP,
IOL_TrongTPHP_MP = :IOL_TrongTPHP_MP,
TonThuongKhac_ThuyTinhthe_MP = :TonThuongKhac_ThuyTinhthe_MP,
AnhDongTu_MP = :AnhDongTu_MP,
DichKinh_MP = :DichKinh_MP,
TonThuongKhac_DichKinh_MP = :TonThuongKhac_DichKinh_MP,
DayMat_MP = :DayMat_MP,
CD_DayMat_MP = :CD_DayMat_MP,
PhuGai_MP = :PhuGai_MP,
BacMauGaiThi_MP = :BacMauGaiThi_MP,
VongMac_DayMat_MP = :VongMac_DayMat_MP,
HeMachMau_DayMat_MP = :HeMachMau_DayMat_MP,
TonThuongKhac_DayMat_MP = :TonThuongKhac_DayMat_MP,
KhongKinh_ThiLuc_MT = :KhongKinh_ThiLuc_MT,
QuaLo_ThiLuc_MT = :QuaLo_ThiLuc_MT,
CoChinhKinh_ThiLuc_MT = :CoChinhKinh_ThiLuc_MT,
NhinGan_ThiLuc_MT = :NhinGan_ThiLuc_MT,
NhanAp_MT = :NhanAp_MT,
LacVaVanNhan_MT = :LacVaVanNhan_MT,
ThoatNuocTot_MT = :ThoatNuocTot_MT,
TraoLeQuanDoiDien_MT = :TraoLeQuanDoiDien_MT,
TraoLeQuanTaiCho_MT = :TraoLeQuanTaiCho_MT,
MiMat_MT = :MiMat_MT,
Khac_MiMat_MT = :Khac_MiMat_MT,
UMi_MT = :UMi_MT,
TinhChatU_UMi_MT = :TinhChatU_UMi_MT,
ViTri_UMi_MT = :ViTri_UMi_MT,
KichThuoc_UMi_MT = :KichThuoc_UMi_MT,
Quam_MiMat_MT = :Quam_MiMat_MT,
MiTren_MiMat_MT = :MiTren_MiMat_MT,
MiDuoi_MiMat_MT = :MiDuoi_MiMat_MT,
HoMi_MiMat_MT = :HoMi_MiMat_MT,
TreMi_MiMat_MT = :TreMi_MiMat_MT,
KhuyetMi_MiMat_MT = :KhuyetMi_MiMat_MT,
TuyetBoMi_MiMat_MT = :TuyetBoMi_MiMat_MT,
ViemBoMi_MiMat_MT = :ViemBoMi_MiMat_MT,
TonThuongKhac_MiMat_MT = :TonThuongKhac_MiMat_MT,
CuongTu_KetMac_MT = :CuongTu_KetMac_MT,
PhuNe_KetMac_MT = :PhuNe_KetMac_MT,
XuatHuyet_KetMac_MT = :XuatHuyet_KetMac_MT,
SungHoa_KetMac_MT = :SungHoa_KetMac_MT,
Nhu_KetMac_MT = :Nhu_KetMac_MT,
Hot_KetMac_MT = :Hot_KetMac_MT,
Seo_KetMac_MT = :Seo_KetMac_MT,
TietToMu_KetMac_MT = :TietToMu_KetMac_MT,
TietToTrong_KetMac_MT = :TietToTrong_KetMac_MT,
GiaMac_KetMac_MT = :GiaMac_KetMac_MT,
BatMauFluor_KetMac_MT = :BatMauFluor_KetMac_MT,
TinhChat_UKetMac_MT = :TinhChat_UKetMac_MT,
ViTri_UKetMac_MT = :ViTri_UKetMac_MT,
KichThuoc_UKetMac_MT = :KichThuoc_UKetMac_MT,
CungDo_KetMac_MT = :CungDo_KetMac_MT,
ChieuCaoCuaCauDinh_KetMac_MT = :ChieuCaoCuaCauDinh_KetMac_MT,
DoRongCuaCauDinh_KetMac_MT = :DoRongCuaCauDinh_KetMac_MT,
TonThuongKhac_KetMac_MT = :TonThuongKhac_KetMac_MT,
KichThuoc_GiacMac_MT = :KichThuoc_GiacMac_MT,
HinhDang_GiacMac_MT = :HinhDang_GiacMac_MT,
BieuMo_GiacMac_MT = :BieuMo_GiacMac_MT,
PhuBongBieuMo_GiacMac_MT = :PhuBongBieuMo_GiacMac_MT,
MatBieuMo_GiacMac_MT = :MatBieuMo_GiacMac_MT,
MatBieuMoKhoangCach_MT = :MatBieuMoKhoangCach_MT,
BoTonThuong_GM_MT = :BoTonThuong_GM_MT,
ThoaiThoaDaiBang_MT = :ThoaiThoaDaiBang_MT,
LangDongThuoc_MT = :LangDongThuoc_MT,
TonThuongKhac_BieuMo_GM_MT_TXT = :TonThuongKhac_BieuMo_GM_MT_TXT,
Phu_NhuMo_GiacMac_MT = :Phu_NhuMo_GiacMac_MT,
ThamLau_NhuMo_GiacMac_MT = :ThamLau_NhuMo_GiacMac_MT,
ThamLau_Vtri_NhuMo_GiacMac_MT = :ThamLau_Vtri_NhuMo_GiacMac_MT,
TieuMong_NhuMo_GiacMac_MT = :TieuMong_NhuMo_GiacMac_MT,
TieuMong_Vtri_NhuMo_GiacMac_MT = :TieuMong_Vtri_NhuMo_GiacMac_MT,
TonThuongKhac_NhuMo_GiacMac_MT = :TonThuongKhac_NhuMo_GiacMac_MT,
NepGap_NoiMo_GiacMac_MT = :NepGap_NoiMo_GiacMac_MT,
TuaSacToMacSauGM_MT = :TuaSacToMacSauGM_MT,
MuMatSau_NoiMo_MT = :MuMatSau_NoiMo_MT,
XuatTietMatSau_NoiMo_MT = :XuatTietMatSau_NoiMo_MT,
Guttata_NoiMo_MT = :Guttata_NoiMo_MT,
RanMangDescemet_NoiMo_MT = :RanMangDescemet_NoiMo_MT,
CuonDescemet_NoiMo_MT = :CuonDescemet_NoiMo_MT,
TonThuongKhac_NoiMo_MT = :TonThuongKhac_NoiMo_MT,
DoaThung_GiacMac_MT = :DoaThung_GiacMac_MT,
KetMongMat_GiacMac_MT = :KetMongMat_GiacMac_MT,
ThungGiacMac_MT = :ThungGiacMac_MT,
Seidel_MT = :Seidel_MT,
DuongKinhThungGiacMac_MT = :DuongKinhThungGiacMac_MT,
ThungBit_GM_MT = :ThungBit_GM_MT,
CamGiacGiacMac_MT = :CamGiacGiacMac_MT,
TanMach_GiacMac_MT = :TanMach_GiacMac_MT,
MucDo_TanMach_GiacMac_MT = :MucDo_TanMach_GiacMac_MT,
SuyTeBaoNguon_MT = :SuyTeBaoNguon_MT,
ThoaiHoaGia_MT = :ThoaiHoaGia_MT,
LangDongCanXi_MT = :LangDongCanXi_MT,
BatThuongKhac_GiacMac_MT = :BatThuongKhac_GiacMac_MT,
Viem_CungMac_MT = :Viem_CungMac_MT,
Viem_NongSau_CungMac_MT = :Viem_NongSau_CungMac_MT,
ViemThuongCungMac_MT = :ViemThuongCungMac_MT,
GianLoi_TieuMong_HoaiTu_MT = :GianLoi_TieuMong_HoaiTu_MT,
ChiTietKhac_CungMac_MT = :ChiTietKhac_CungMac_MT,
TienPhong_MT = :TienPhong_MT,
Mu_TienPhong_MT = :Mu_TienPhong_MT,
Tydal_MT = :Tydal_MT,
MangXuatTiet_MT = :MangXuatTiet_MT,
Mau_TienPhong_MT = :Mau_TienPhong_MT,
TonThuongKhac_TienPhong_MT = :TonThuongKhac_TienPhong_MT,
NauXop_MT = :NauXop_MT,
XoTeo_MT = :XoTeo_MT,
CuongTu_MT = :CuongTu_MT,
TanMach_MT = :TanMach_MT,
Phoi_MT = :Phoi_MT,
Ket_MT = :Ket_MT,
DuongKinh_DongTu_MT = :DuongKinh_DongTu_MT,
DongTuTronMeoDinh_MT = :DongTuTronMeoDinh_MT,
ViTriDinh_DongTu_MT = :ViTriDinh_DongTu_MT,
PhanXaDongTu_MT = :PhanXaDongTu_MT,
TonThuongKhac_DongTu_MT = :TonThuongKhac_DongTu_MT,
ThuyTinhThe_MT = :ThuyTinhThe_MT,
HinhThaiDuc_ThuyTinhthe_MT = :HinhThaiDuc_ThuyTinhthe_MT,
IOL_CanLechDuc_MT = :IOL_CanLechDuc_MT,
IOL_TrongTPHP_MT = :IOL_TrongTPHP_MT,
TonThuongKhac_ThuyTinhthe_MT = :TonThuongKhac_ThuyTinhthe_MT,
AnhDongTu_MT = :AnhDongTu_MT,
DichKinh_MT = :DichKinh_MT,
TonThuongKhac_DichKinh_MT = :TonThuongKhac_DichKinh_MT,
DayMat_MT = :DayMat_MT,
CD_DayMat_MT = :CD_DayMat_MT,
PhuGai_MT = :PhuGai_MT,
BacMauGaiThi_MT = :BacMauGaiThi_MT,
VongMac_DayMat_MT = :VongMac_DayMat_MT,
HeMachMau_DayMat_MT = :HeMachMau_DayMat_MT,
TonThuongKhac_DayMat_MT = :TonThuongKhac_DayMat_MT,
HuyetAp_ToanThan = :HuyetAp_ToanThan,
NhietDo_ToanThan = :NhietDo_ToanThan,
Mach_ToanThan = :Mach_ToanThan,
NoiTiet_Tick = :NoiTiet_Tick,
NoiTiet = :NoiTiet,
ThanKinh_Tick = :ThanKinh_Tick,
TuanHoan_Tick = :TuanHoan_Tick,
HoHap_Tick = :HoHap_Tick,
TieuHoa_Tick = :TieuHoa_Tick,
CoXuongKhop_Tick = :CoXuongKhop_Tick,
ThanTietNieu_Tick = :ThanTietNieu_Tick,
BenhChinh_MatPhai = :BenhChinh_MatPhai,
BenhChinh_MatTrai = :BenhChinh_MatTrai,
PhuongPhapChinh = :PhuongPhapChinh,
CheDoAnUong = :CheDoAnUong,
CheDoChamSoc = :CheDoChamSoc,
ChanDoanBenhChinh_LamSang = :ChanDoanBenhChinh_LamSang,
ChanDoanBenhChinh_NguyenNhan = :ChanDoanBenhChinh_NguyenNhan,
QuaTrinhDieuTri_NoiKhoa = :QuaTrinhDieuTri_NoiKhoa,
QuaTrinhDieuTri_KetQua = :QuaTrinhDieuTri_KetQua,
QuaTrinhDieuTri_BienChung = :QuaTrinhDieuTri_BienChung,
HuongDieuTriTiep = :HuongDieuTriTiep,
MiMat_T = :MiMat_T,
MiMat_P = :MiMat_P,
ChuaThayBenhLy = :ChuaThayBenhLy,
BenhLy = :BenhLy,
BenhLy_Text = :BenhLy_Text,
PhauThuat = :PhauThuat,
ThuThuat = :ThuThuat,
ThiLucKhiRaVien_KhongKinh_MP = :ThiLucKhiRaVien_KhongKinh_MP,
ThiLucKhiRaVien_KhongKinh_MT = :ThiLucKhiRaVien_KhongKinh_MT,
ThiLucKhiRaVien_CoKinh_MP = :ThiLucKhiRaVien_CoKinh_MP,
ThiLucKhiRaVien_CoKinh_MT = :ThiLucKhiRaVien_CoKinh_MT,
NhanApRaVien_MP = :NhanApRaVien_MP,
NhanApRaVien_MT = :NhanApRaVien_MT,
ThoatNuocTot_MP_Text = :ThoatNuocTot_MP_Text,
ThoatNuocTot_MT_Text = :ThoatNuocTot_MT_Text,
TraoLeQuanDoiDien_MP_Text = :TraoLeQuanDoiDien_MP_Text,
TraoLeQuanDoiDien_MT_Text = :TraoLeQuanDoiDien_MT_Text,
TraoLeQuanTaiCho_MP_Text = :TraoLeQuanTaiCho_MP_Text,
TraoLeQuanTaiCho_MT_Text = :TraoLeQuanTaiCho_MT_Text,
KetMac_Mong_MP = :KetMac_Mong_MP,
KetMac_Mong_MT = :KetMac_Mong_MT,
GhepGiacMac_MP = :GhepGiacMac_MP,
GhepGiacMac_MT = :GhepGiacMac_MT,
BieuMo_GiacMac_BT_MP = :BieuMo_GiacMac_BT_MP,
BieuMo_GiacMac_BT_MT = :BieuMo_GiacMac_BT_MT,
NhuMo_GiacMac_BT_MP = :NhuMo_GiacMac_BT_MP,
NhuMo_GiacMac_BT_MT = :NhuMo_GiacMac_BT_MT,
NoiMo_GiacMac_BT_MP = :NoiMo_GiacMac_BT_MP,
NoiMo_GiacMac_BT_MT = :NoiMo_GiacMac_BT_MT,
CungMac_BT_MP = :CungMac_BT_MP,
CungMac_BT_MT = :CungMac_BT_MT,
Khuyet_MP = :Khuyet_MP,
Khuyet_MT = :Khuyet_MT,
Khac_MongMat_MP = :Khac_MongMat_MP,
Khac_MongMat_MT = :Khac_MongMat_MT,
NoiTietCheck = :NoiTietCheck, 
NoiTiet_Text = :NoiTiet_Text,
ThanKinhCheck = :ThanKinhCheck, 
ThanKinh_Text = :ThanKinh_Text,
TuanHoanCheck = :TuanHoanCheck, 
TuanHoan_Text = :TuanHoan_Text,
HoHapCheck = :HoHapCheck, 
HoHap_Text = :HoHap_Text,
TieuHoaCheck = :TieuHoaCheck, 
TieuHoa_Text = :TieuHoa_Text,
CoXuongKhopCheck = :CoXuongKhopCheck, 
CoXuongKhop_Text = :CoXuongKhop_Text,
TietNieuSinhDucCheck = :TietNieuSinhDucCheck, 
TietNieuSinhDuc_Text = :TietNieuSinhDuc_Text,
KhamBenhToanThan_Khac = :KhamBenhToanThan_Khac 
                        WHERE MaQuanLy = :MaQuanLy";
            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
            Command.Parameters.Add(new MDB.MDBParameter("LyDoVaoVien", BenhAnMatBanPhanTruoc.LyDoVaoVien));
            Command.Parameters.Add(new MDB.MDBParameter("VaoNgayThu", BenhAnMatBanPhanTruoc.VaoNgayThu));
            Command.Parameters.Add(new MDB.MDBParameter("QuaTrinhBenhLy", BenhAnMatBanPhanTruoc.QuaTrinhBenhLy));
            Command.Parameters.Add(new MDB.MDBParameter("TienSuBenhBanThan", BenhAnMatBanPhanTruoc.TienSuBenhBanThan));
            Command.Parameters.Add(new MDB.MDBParameter("TienSuBenhGiaDinh", BenhAnMatBanPhanTruoc.TienSuBenhGiaDinh));
            Command.Parameters.Add(new MDB.MDBParameter("ToanThan", BenhAnMatBanPhanTruoc.ToanThan));
            Command.Parameters.Add(new MDB.MDBParameter("TuanHoan", BenhAnMatBanPhanTruoc.TuanHoan));
            Command.Parameters.Add(new MDB.MDBParameter("HoHap", BenhAnMatBanPhanTruoc.HoHap));
            Command.Parameters.Add(new MDB.MDBParameter("TieuHoa", BenhAnMatBanPhanTruoc.TieuHoa));
            Command.Parameters.Add(new MDB.MDBParameter("ThanTietNieuSinhDuc", BenhAnMatBanPhanTruoc.ThanTietNieuSinhDuc));
            Command.Parameters.Add(new MDB.MDBParameter("ThanKinh", BenhAnMatBanPhanTruoc.ThanKinh));
            Command.Parameters.Add(new MDB.MDBParameter("CoXuongKhop", BenhAnMatBanPhanTruoc.CoXuongKhop));
            Command.Parameters.Add(new MDB.MDBParameter("TaiMuiHong", BenhAnMatBanPhanTruoc.TaiMuiHong));
            Command.Parameters.Add(new MDB.MDBParameter("RangHamMat", BenhAnMatBanPhanTruoc.RangHamMat));
            Command.Parameters.Add(new MDB.MDBParameter("Mat", BenhAnMatBanPhanTruoc.Mat));
            Command.Parameters.Add(new MDB.MDBParameter("Khac_CacCoQuan", BenhAnMatBanPhanTruoc.Khac_CacCoQuan));
            Command.Parameters.Add(new MDB.MDBParameter("CacXetNghiemCanLamSangCanLam", BenhAnMatBanPhanTruoc.CacXetNghiemCanLamSangCanLam));
            Command.Parameters.Add(new MDB.MDBParameter("TomTatBenhAn", BenhAnMatBanPhanTruoc.TomTatBenhAn));
            Command.Parameters.Add(new MDB.MDBParameter("BenhChinh", BenhAnMatBanPhanTruoc.BenhChinh));
            Command.Parameters.Add(new MDB.MDBParameter("BenhKemTheo", BenhAnMatBanPhanTruoc.BenhKemTheo));
            Command.Parameters.Add(new MDB.MDBParameter("PhanBiet", BenhAnMatBanPhanTruoc.PhanBiet));
            Command.Parameters.Add(new MDB.MDBParameter("TienLuong", BenhAnMatBanPhanTruoc.TienLuong));
            Command.Parameters.Add(new MDB.MDBParameter("HuongDieuTri", BenhAnMatBanPhanTruoc.HuongDieuTri));
            Command.Parameters.Add(new MDB.MDBParameter("NgayKhamBenh", BenhAnMatBanPhanTruoc.NgayKhamBenh));
            Command.Parameters.Add(new MDB.MDBParameter("BacSyLamBenhAn", BenhAnMatBanPhanTruoc.BacSyLamBenhAn));
            Command.Parameters.Add(new MDB.MDBParameter("QuaTrinhBenhLyVaDienBien", BenhAnMatBanPhanTruoc.QuaTrinhBenhLyVaDienBien));
            Command.Parameters.Add(new MDB.MDBParameter("TomTatKetQuaXetNghiem", BenhAnMatBanPhanTruoc.TomTatKetQuaXetNghiem));
            Command.Parameters.Add(new MDB.MDBParameter("PhuongPhapDieuTri", BenhAnMatBanPhanTruoc.PhuongPhapDieuTri));
            Command.Parameters.Add(new MDB.MDBParameter("TinhTrangNguoiBenhRaVien", BenhAnMatBanPhanTruoc.TinhTrangNguoiBenhRaVien));
            Command.Parameters.Add(new MDB.MDBParameter("HuongDieuTriVaCacCheDoTiepTheo", BenhAnMatBanPhanTruoc.HuongDieuTriVaCacCheDoTiepTheo));
            Command.Parameters.Add(new MDB.MDBParameter("NguoiNhanHoSo", BenhAnMatBanPhanTruoc.NguoiNhanHoSo));
            Command.Parameters.Add(new MDB.MDBParameter("NguoiGiaoHoSo", BenhAnMatBanPhanTruoc.NguoiGiaoHoSo));
            Command.Parameters.Add(new MDB.MDBParameter("NgayTongKet", BenhAnMatBanPhanTruoc.NgayTongKet));
            Command.Parameters.Add(new MDB.MDBParameter("BacSyDieuTri", BenhAnMatBanPhanTruoc.BacSyDieuTri));
            Command.Parameters.Add(new MDB.MDBParameter("DiUng", BenhAnMatBanPhanTruoc.DacDiemLienQuanBenh.DiUng == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("DiUng_Text", BenhAnMatBanPhanTruoc.DacDiemLienQuanBenh.DiUng_Text));
            Command.Parameters.Add(new MDB.MDBParameter("MaTuy", BenhAnMatBanPhanTruoc.DacDiemLienQuanBenh.MaTuy == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("MaTuy_Text", BenhAnMatBanPhanTruoc.DacDiemLienQuanBenh.MaTuy_Text));
            Command.Parameters.Add(new MDB.MDBParameter("RuouBia", BenhAnMatBanPhanTruoc.DacDiemLienQuanBenh.RuouBia == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("RuouBia_Text", BenhAnMatBanPhanTruoc.DacDiemLienQuanBenh.RuouBia_Text));
            Command.Parameters.Add(new MDB.MDBParameter("ThuocLa", BenhAnMatBanPhanTruoc.DacDiemLienQuanBenh.ThuocLa == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("ThuocLa_Text", BenhAnMatBanPhanTruoc.DacDiemLienQuanBenh.ThuocLa_Text));
            Command.Parameters.Add(new MDB.MDBParameter("ThuocLao", BenhAnMatBanPhanTruoc.DacDiemLienQuanBenh.ThuocLao == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("ThuocLao_Text", BenhAnMatBanPhanTruoc.DacDiemLienQuanBenh.ThuocLao_Text));
            Command.Parameters.Add(new MDB.MDBParameter("Khac_DacDiemLienQuanBenh", BenhAnMatBanPhanTruoc.DacDiemLienQuanBenh.Khac_DacDiemLienQuanBenh == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("Khac_DacDiemLienQuanBenh_Text", BenhAnMatBanPhanTruoc.DacDiemLienQuanBenh.Khac_DacDiemLienQuanBenh_Text));
            Command.Parameters.Add(new MDB.MDBParameter("ThoiGianXuatHienBenh", BenhAnMatBanPhanTruoc.ThoiGianXuatHienBenh));
            Command.Parameters.Add(new MDB.MDBParameter("NguyenNhan_BenhSu", BenhAnMatBanPhanTruoc.NguyenNhan_BenhSu));
            Command.Parameters.Add(new MDB.MDBParameter("CacPhuongPhapDaDieuTri_BenhSu", BenhAnMatBanPhanTruoc.CacPhuongPhapDaDieuTri_BenhSu));
            Command.Parameters.Add(new MDB.MDBParameter("TienSuBenhBanThan_Mat", BenhAnMatBanPhanTruoc.TienSuBenhBanThan_Mat));
            Command.Parameters.Add(new MDB.MDBParameter("TienSuBenhGiaDinh_Mat", BenhAnMatBanPhanTruoc.TienSuBenhGiaDinh_Mat));
            Command.Parameters.Add(new MDB.MDBParameter("KhongKinh_ThiLuc_MP", BenhAnMatBanPhanTruoc.KhongKinh_ThiLuc_MP));
            Command.Parameters.Add(new MDB.MDBParameter("QuaLo_ThiLuc_MP", BenhAnMatBanPhanTruoc.QuaLo_ThiLuc_MP));
            Command.Parameters.Add(new MDB.MDBParameter("CoChinhKinh_ThiLuc_MP", BenhAnMatBanPhanTruoc.CoChinhKinh_ThiLuc_MP));
            Command.Parameters.Add(new MDB.MDBParameter("NhinGan_ThiLuc_MP", BenhAnMatBanPhanTruoc.NhinGan_ThiLuc_MP));
            Command.Parameters.Add(new MDB.MDBParameter("NhanAp_MP", BenhAnMatBanPhanTruoc.NhanAp_MP));
            Command.Parameters.Add(new MDB.MDBParameter("LacVaVanNhan_MP", BenhAnMatBanPhanTruoc.LacVaVanNhan_MP));
            Command.Parameters.Add(new MDB.MDBParameter("ThoatNuocTot_MP", BenhAnMatBanPhanTruoc.ThoatNuocTot_MP == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("TraoLeQuanDoiDien_MP", BenhAnMatBanPhanTruoc.TraoLeQuanDoiDien_MP == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("TraoLeQuanTaiCho_MP", BenhAnMatBanPhanTruoc.TraoLeQuanTaiCho_MP == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("MiMat_MP", BenhAnMatBanPhanTruoc.MiMat_MP));
            Command.Parameters.Add(new MDB.MDBParameter("Khac_MiMat_MP", BenhAnMatBanPhanTruoc.Khac_MiMat_MP));
            Command.Parameters.Add(new MDB.MDBParameter("UMi_MP", BenhAnMatBanPhanTruoc.UMi_MP == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("TinhChatU_UMi_MP", BenhAnMatBanPhanTruoc.TinhChatU_UMi_MP));
            Command.Parameters.Add(new MDB.MDBParameter("ViTri_UMi_MP", BenhAnMatBanPhanTruoc.ViTri_UMi_MP));
            Command.Parameters.Add(new MDB.MDBParameter("KichThuoc_UMi_MP", BenhAnMatBanPhanTruoc.KichThuoc_UMi_MP));
            Command.Parameters.Add(new MDB.MDBParameter("Quam_MiMat_MP", BenhAnMatBanPhanTruoc.iQuam_MiMat_MP));
            Command.Parameters.Add(new MDB.MDBParameter("MiTren_MiMat_MP", BenhAnMatBanPhanTruoc.MiTren_MiMat_MP));
            Command.Parameters.Add(new MDB.MDBParameter("MiDuoi_MiMat_MP", BenhAnMatBanPhanTruoc.MiDuoi_MiMat_MP));
            Command.Parameters.Add(new MDB.MDBParameter("HoMi_MiMat_MP", BenhAnMatBanPhanTruoc.HoMi_MiMat_MP == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("TreMi_MiMat_MP", BenhAnMatBanPhanTruoc.TreMi_MiMat_MP == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("KhuyetMi_MiMat_MP", BenhAnMatBanPhanTruoc.KhuyetMi_MiMat_MP));
            Command.Parameters.Add(new MDB.MDBParameter("TuyetBoMi_MiMat_MP", BenhAnMatBanPhanTruoc.TuyetBoMi_MiMat_MP));
            Command.Parameters.Add(new MDB.MDBParameter("ViemBoMi_MiMat_MP", BenhAnMatBanPhanTruoc.ViemBoMi_MiMat_MP == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("TonThuongKhac_MiMat_MP", BenhAnMatBanPhanTruoc.TonThuongKhac_MiMat_MP));
            Command.Parameters.Add(new MDB.MDBParameter("CuongTu_KetMac_MP", BenhAnMatBanPhanTruoc.CuongTu_KetMac_MP));
            Command.Parameters.Add(new MDB.MDBParameter("PhuNe_KetMac_MP", BenhAnMatBanPhanTruoc.PhuNe_KetMac_MP == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("XuatHuyet_KetMac_MP", BenhAnMatBanPhanTruoc.XuatHuyet_KetMac_MP == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("SungHoa_KetMac_MP", BenhAnMatBanPhanTruoc.SungHoa_KetMac_MP == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("Nhu_KetMac_MP", BenhAnMatBanPhanTruoc.Nhu_KetMac_MP == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("Hot_KetMac_MP", BenhAnMatBanPhanTruoc.Hot_KetMac_MP == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("Seo_KetMac_MP", BenhAnMatBanPhanTruoc.Seo_KetMac_MP == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("TietToMu_KetMac_MP", BenhAnMatBanPhanTruoc.TietToMu_KetMac_MP == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("TietToTrong_KetMac_MP", BenhAnMatBanPhanTruoc.TietToTrong_KetMac_MP == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("GiaMac_KetMac_MP", BenhAnMatBanPhanTruoc.GiaMac_KetMac_MP == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("BatMauFluor_KetMac_MP", BenhAnMatBanPhanTruoc.BatMauFluor_KetMac_MP == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("TinhChat_UKetMac_MP", BenhAnMatBanPhanTruoc.TinhChat_UKetMac_MP));
            Command.Parameters.Add(new MDB.MDBParameter("ViTri_UKetMac_MP", BenhAnMatBanPhanTruoc.ViTri_UKetMac_MP));
            Command.Parameters.Add(new MDB.MDBParameter("KichThuoc_UKetMac_MP", BenhAnMatBanPhanTruoc.KichThuoc_UKetMac_MP));
            Command.Parameters.Add(new MDB.MDBParameter("CungDo_KetMac_MP", BenhAnMatBanPhanTruoc.CungDo_KetMac_MP));
            Command.Parameters.Add(new MDB.MDBParameter("ChieuCaoCuaCauDinh_KetMac_MP", BenhAnMatBanPhanTruoc.ChieuCaoCuaCauDinh_KetMac_MP));
            Command.Parameters.Add(new MDB.MDBParameter("DoRongCuaCauDinh_KetMac_MP", BenhAnMatBanPhanTruoc.DoRongCuaCauDinh_KetMac_MP));
            Command.Parameters.Add(new MDB.MDBParameter("TonThuongKhac_KetMac_MP", BenhAnMatBanPhanTruoc.TonThuongKhac_KetMac_MP));
            Command.Parameters.Add(new MDB.MDBParameter("KichThuoc_GiacMac_MP", BenhAnMatBanPhanTruoc.KichThuoc_GiacMac_MP));
            Command.Parameters.Add(new MDB.MDBParameter("HinhDang_GiacMac_MP", BenhAnMatBanPhanTruoc.HinhDang_GiacMac_MP));
            Command.Parameters.Add(new MDB.MDBParameter("BieuMo_GiacMac_MP", BenhAnMatBanPhanTruoc.BieuMo_GiacMac_MP == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("PhuBongBieuMo_GiacMac_MP", BenhAnMatBanPhanTruoc.PhuBongBieuMo_GiacMac_MP));
            Command.Parameters.Add(new MDB.MDBParameter("MatBieuMo_GiacMac_MP", BenhAnMatBanPhanTruoc.MatBieuMo_GiacMac_MP));
            Command.Parameters.Add(new MDB.MDBParameter("MatBieuMoKhoangCach_MP", BenhAnMatBanPhanTruoc.MatBieuMoKhoangCach_MP));
            Command.Parameters.Add(new MDB.MDBParameter("BoTonThuong_GM_MP", BenhAnMatBanPhanTruoc.BoTonThuong_GM_MP));
            Command.Parameters.Add(new MDB.MDBParameter("ThoaiThoaDaiBang_MP", BenhAnMatBanPhanTruoc.ThoaiThoaDaiBang_MP == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("LangDongThuoc_MP", BenhAnMatBanPhanTruoc.LangDongThuoc_MP == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("TonThuongKhac_BieuMo_GM_MP", BenhAnMatBanPhanTruoc.TonThuongKhac_BieuMo_GM_MP));
            Command.Parameters.Add(new MDB.MDBParameter("Phu_NhuMo_GiacMac_MP", BenhAnMatBanPhanTruoc.Phu_NhuMo_GiacMac_MP));
            Command.Parameters.Add(new MDB.MDBParameter("ThamLau_NhuMo_GiacMac_MP", BenhAnMatBanPhanTruoc.ThamLau_NhuMo_GiacMac_MP));
            Command.Parameters.Add(new MDB.MDBParameter("ThamLau_Vtri_NhuMo_GiacMac_MP", BenhAnMatBanPhanTruoc.ThamLau_Vtri_NhuMo_GiacMac_MP));
            Command.Parameters.Add(new MDB.MDBParameter("TieuMong_NhuMo_GiacMac_MP", BenhAnMatBanPhanTruoc.TieuMong_NhuMo_GiacMac_MP));
            Command.Parameters.Add(new MDB.MDBParameter("TieuMong_Vtri_NhuMo_GiacMac_MP", BenhAnMatBanPhanTruoc.TieuMong_Vtri_NhuMo_GiacMac_MP));
            Command.Parameters.Add(new MDB.MDBParameter("TonThuongKhac_NhuMo_GiacMac_MP", BenhAnMatBanPhanTruoc.TonThuongKhac_NhuMo_GiacMac_MP));
            Command.Parameters.Add(new MDB.MDBParameter("NepGap_NoiMo_GiacMac_MP", BenhAnMatBanPhanTruoc.NepGap_NoiMo_GiacMac_MP));
            Command.Parameters.Add(new MDB.MDBParameter("TuaSacToMacSauGM_MP", BenhAnMatBanPhanTruoc.TuaSacToMacSauGM_MP == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("MuMatSau_NoiMo_MP", BenhAnMatBanPhanTruoc.MuMatSau_NoiMo_MP == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("XuatTietMatSau_NoiMo_MP", BenhAnMatBanPhanTruoc.XuatTietMatSau_NoiMo_MP == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("Guttata_NoiMo_MP", BenhAnMatBanPhanTruoc.Guttata_NoiMo_MP == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("RanMangDescemet_NoiMo_MP", BenhAnMatBanPhanTruoc.RanMangDescemet_NoiMo_MP == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("CuonDescemet_NoiMo_MP", BenhAnMatBanPhanTruoc.CuonDescemet_NoiMo_MP == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("TonThuongKhac_NoiMo_MP", BenhAnMatBanPhanTruoc.TonThuongKhac_NoiMo_MP));
            Command.Parameters.Add(new MDB.MDBParameter("DoaThung_GiacMac_MP", BenhAnMatBanPhanTruoc.DoaThung_GiacMac_MP == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("KetMongMat_GiacMac_MP", BenhAnMatBanPhanTruoc.KetMongMat_GiacMac_MP == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("ThungGiacMac_MP", BenhAnMatBanPhanTruoc.ThungGiacMac_MP));
            Command.Parameters.Add(new MDB.MDBParameter("Seidel_MP", BenhAnMatBanPhanTruoc.Seidel_MP == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("DuongKinhThungGiacMac_MP", BenhAnMatBanPhanTruoc.DuongKinhThungGiacMac_MP));
            Command.Parameters.Add(new MDB.MDBParameter("ThungBit_GM_MP", BenhAnMatBanPhanTruoc.iThungBit_GM_MP));
            Command.Parameters.Add(new MDB.MDBParameter("CamGiacGiacMac_MP", BenhAnMatBanPhanTruoc.CamGiacGiacMac_MP));
            Command.Parameters.Add(new MDB.MDBParameter("TanMach_GiacMac_MP", BenhAnMatBanPhanTruoc.TanMach_GiacMac_MP));
            Command.Parameters.Add(new MDB.MDBParameter("MucDo_TanMach_GiacMac_MP", BenhAnMatBanPhanTruoc.MucDo_TanMach_GiacMac_MP));
            Command.Parameters.Add(new MDB.MDBParameter("SuyTeBaoNguon_MP", BenhAnMatBanPhanTruoc.SuyTeBaoNguon_MP == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("ThoaiHoaGia_MP", BenhAnMatBanPhanTruoc.ThoaiHoaGia_MP == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("LangDongCanXi_MP", BenhAnMatBanPhanTruoc.LangDongCanXi_MP == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("BatThuongKhac_GiacMac_MP", BenhAnMatBanPhanTruoc.BatThuongKhac_GiacMac_MP));
            Command.Parameters.Add(new MDB.MDBParameter("Viem_CungMac_MP", BenhAnMatBanPhanTruoc.Viem_CungMac_MP));
            Command.Parameters.Add(new MDB.MDBParameter("Viem_NongSau_CungMac_MP", BenhAnMatBanPhanTruoc.iViem_NongSau_CungMac_MP));
            Command.Parameters.Add(new MDB.MDBParameter("ViemThuongCungMac_MP", BenhAnMatBanPhanTruoc.ViemThuongCungMac_MP == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("GianLoi_TieuMong_HoaiTu_MP", BenhAnMatBanPhanTruoc.GianLoi_TieuMong_HoaiTu_MP));
            Command.Parameters.Add(new MDB.MDBParameter("ChiTietKhac_CungMac_MP", BenhAnMatBanPhanTruoc.ChiTietKhac_CungMac_MP));
            Command.Parameters.Add(new MDB.MDBParameter("TienPhong_MP", BenhAnMatBanPhanTruoc.TienPhong_MP));
            Command.Parameters.Add(new MDB.MDBParameter("Mu_TienPhong_MP", BenhAnMatBanPhanTruoc.Mu_TienPhong_MP));
            Command.Parameters.Add(new MDB.MDBParameter("Tydal_MP", BenhAnMatBanPhanTruoc.Tydal_MP == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("MangXuatTiet_MP", BenhAnMatBanPhanTruoc.MangXuatTiet_MP == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("Mau_TienPhong_MP", BenhAnMatBanPhanTruoc.Mau_TienPhong_MP));
            Command.Parameters.Add(new MDB.MDBParameter("TonThuongKhac_TienPhong_MP", BenhAnMatBanPhanTruoc.TonThuongKhac_TienPhong_MP));
            Command.Parameters.Add(new MDB.MDBParameter("NauXop_MP", BenhAnMatBanPhanTruoc.NauXop_MP == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("XoTeo_MP", BenhAnMatBanPhanTruoc.XoTeo_MP == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("CuongTu_MP", BenhAnMatBanPhanTruoc.CuongTu_MP == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("TanMach_MP", BenhAnMatBanPhanTruoc.TanMach_MP == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("Phoi_MP", BenhAnMatBanPhanTruoc.Phoi_MP == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("Ket_MP", BenhAnMatBanPhanTruoc.Ket_MP == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("DuongKinh_DongTu_MP", BenhAnMatBanPhanTruoc.DuongKinh_DongTu_MP));
            Command.Parameters.Add(new MDB.MDBParameter("DongTuTronMeoDinh_MP", BenhAnMatBanPhanTruoc.DongTuTronMeoDinh_MP));
            Command.Parameters.Add(new MDB.MDBParameter("ViTriDinh_DongTu_MP", BenhAnMatBanPhanTruoc.ViTriDinh_DongTu_MP));
            Command.Parameters.Add(new MDB.MDBParameter("PhanXaDongTu_MP", BenhAnMatBanPhanTruoc.PhanXaDongTu_MP));
            Command.Parameters.Add(new MDB.MDBParameter("TonThuongKhac_DongTu_MP", BenhAnMatBanPhanTruoc.TonThuongKhac_DongTu_MP));
            Command.Parameters.Add(new MDB.MDBParameter("ThuyTinhThe_MP", BenhAnMatBanPhanTruoc.iThuyTinhThe_MP));
            Command.Parameters.Add(new MDB.MDBParameter("HinhThaiDuc_ThuyTinhthe_MP", BenhAnMatBanPhanTruoc.HinhThaiDuc_ThuyTinhthe_MP));
            Command.Parameters.Add(new MDB.MDBParameter("IOL_CanLechDuc_MP", BenhAnMatBanPhanTruoc.IOL_CanLechDuc_MP));
            Command.Parameters.Add(new MDB.MDBParameter("IOL_TrongTPHP_MP", BenhAnMatBanPhanTruoc.iIOL_TrongTPHP_MP));
            Command.Parameters.Add(new MDB.MDBParameter("TonThuongKhac_ThuyTinhthe_MP", BenhAnMatBanPhanTruoc.TonThuongKhac_ThuyTinhthe_MP));
            Command.Parameters.Add(new MDB.MDBParameter("AnhDongTu_MP", BenhAnMatBanPhanTruoc.AnhDongTu_MP));
            Command.Parameters.Add(new MDB.MDBParameter("DichKinh_MP", BenhAnMatBanPhanTruoc.DichKinh_MP));
            Command.Parameters.Add(new MDB.MDBParameter("TonThuongKhac_DichKinh_MP", BenhAnMatBanPhanTruoc.TonThuongKhac_DichKinh_MP));
            Command.Parameters.Add(new MDB.MDBParameter("DayMat_MP", BenhAnMatBanPhanTruoc.DayMat_MP));
            Command.Parameters.Add(new MDB.MDBParameter("CD_DayMat_MP", BenhAnMatBanPhanTruoc.CD_DayMat_MP));
            Command.Parameters.Add(new MDB.MDBParameter("PhuGai_MP", BenhAnMatBanPhanTruoc.PhuGai_MP == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("BacMauGaiThi_MP", BenhAnMatBanPhanTruoc.BacMauGaiThi_MP == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("VongMac_DayMat_MP", BenhAnMatBanPhanTruoc.VongMac_DayMat_MP));
            Command.Parameters.Add(new MDB.MDBParameter("HeMachMau_DayMat_MP", BenhAnMatBanPhanTruoc.HeMachMau_DayMat_MP));
            Command.Parameters.Add(new MDB.MDBParameter("TonThuongKhac_DayMat_MP", BenhAnMatBanPhanTruoc.TonThuongKhac_DayMat_MP));
            Command.Parameters.Add(new MDB.MDBParameter("KhongKinh_ThiLuc_MT", BenhAnMatBanPhanTruoc.KhongKinh_ThiLuc_MT));
            Command.Parameters.Add(new MDB.MDBParameter("QuaLo_ThiLuc_MT", BenhAnMatBanPhanTruoc.QuaLo_ThiLuc_MT));
            Command.Parameters.Add(new MDB.MDBParameter("CoChinhKinh_ThiLuc_MT", BenhAnMatBanPhanTruoc.CoChinhKinh_ThiLuc_MT));
            Command.Parameters.Add(new MDB.MDBParameter("NhinGan_ThiLuc_MT", BenhAnMatBanPhanTruoc.NhinGan_ThiLuc_MT));
            Command.Parameters.Add(new MDB.MDBParameter("NhanAp_MT", BenhAnMatBanPhanTruoc.NhanAp_MT));
            Command.Parameters.Add(new MDB.MDBParameter("LacVaVanNhan_MT", BenhAnMatBanPhanTruoc.LacVaVanNhan_MT));
            Command.Parameters.Add(new MDB.MDBParameter("ThoatNuocTot_MT", BenhAnMatBanPhanTruoc.ThoatNuocTot_MT == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("TraoLeQuanDoiDien_MT", BenhAnMatBanPhanTruoc.TraoLeQuanDoiDien_MT == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("TraoLeQuanTaiCho_MT", BenhAnMatBanPhanTruoc.TraoLeQuanTaiCho_MT == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("MiMat_MT", BenhAnMatBanPhanTruoc.MiMat_MT));
            Command.Parameters.Add(new MDB.MDBParameter("Khac_MiMat_MT", BenhAnMatBanPhanTruoc.Khac_MiMat_MT));
            Command.Parameters.Add(new MDB.MDBParameter("UMi_MT", BenhAnMatBanPhanTruoc.UMi_MT == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("TinhChatU_UMi_MT", BenhAnMatBanPhanTruoc.TinhChatU_UMi_MT));
            Command.Parameters.Add(new MDB.MDBParameter("ViTri_UMi_MT", BenhAnMatBanPhanTruoc.ViTri_UMi_MT));
            Command.Parameters.Add(new MDB.MDBParameter("KichThuoc_UMi_MT", BenhAnMatBanPhanTruoc.KichThuoc_UMi_MT));
            Command.Parameters.Add(new MDB.MDBParameter("Quam_MiMat_MT", BenhAnMatBanPhanTruoc.iQuam_MiMat_MT));
            Command.Parameters.Add(new MDB.MDBParameter("MiTren_MiMat_MT", BenhAnMatBanPhanTruoc.MiTren_MiMat_MT));
            Command.Parameters.Add(new MDB.MDBParameter("MiDuoi_MiMat_MT", BenhAnMatBanPhanTruoc.MiDuoi_MiMat_MT));
            Command.Parameters.Add(new MDB.MDBParameter("HoMi_MiMat_MT", BenhAnMatBanPhanTruoc.HoMi_MiMat_MT == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("TreMi_MiMat_MT", BenhAnMatBanPhanTruoc.TreMi_MiMat_MT == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("KhuyetMi_MiMat_MT", BenhAnMatBanPhanTruoc.KhuyetMi_MiMat_MT));
            Command.Parameters.Add(new MDB.MDBParameter("TuyetBoMi_MiMat_MT", BenhAnMatBanPhanTruoc.TuyetBoMi_MiMat_MT));
            Command.Parameters.Add(new MDB.MDBParameter("ViemBoMi_MiMat_MT", BenhAnMatBanPhanTruoc.ViemBoMi_MiMat_MT == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("TonThuongKhac_MiMat_MT", BenhAnMatBanPhanTruoc.TonThuongKhac_MiMat_MT));
            Command.Parameters.Add(new MDB.MDBParameter("CuongTu_KetMac_MT", BenhAnMatBanPhanTruoc.CuongTu_KetMac_MT));
            Command.Parameters.Add(new MDB.MDBParameter("PhuNe_KetMac_MT", BenhAnMatBanPhanTruoc.PhuNe_KetMac_MT == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("XuatHuyet_KetMac_MT", BenhAnMatBanPhanTruoc.XuatHuyet_KetMac_MT == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("SungHoa_KetMac_MT", BenhAnMatBanPhanTruoc.SungHoa_KetMac_MT == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("Nhu_KetMac_MT", BenhAnMatBanPhanTruoc.Nhu_KetMac_MT == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("Hot_KetMac_MT", BenhAnMatBanPhanTruoc.Hot_KetMac_MT == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("Seo_KetMac_MT", BenhAnMatBanPhanTruoc.Seo_KetMac_MT == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("TietToMu_KetMac_MT", BenhAnMatBanPhanTruoc.TietToMu_KetMac_MT == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("TietToTrong_KetMac_MT", BenhAnMatBanPhanTruoc.TietToTrong_KetMac_MT == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("GiaMac_KetMac_MT", BenhAnMatBanPhanTruoc.GiaMac_KetMac_MT == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("BatMauFluor_KetMac_MT", BenhAnMatBanPhanTruoc.BatMauFluor_KetMac_MT == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("TinhChat_UKetMac_MT", BenhAnMatBanPhanTruoc.TinhChat_UKetMac_MT));
            Command.Parameters.Add(new MDB.MDBParameter("ViTri_UKetMac_MT", BenhAnMatBanPhanTruoc.ViTri_UKetMac_MT));
            Command.Parameters.Add(new MDB.MDBParameter("KichThuoc_UKetMac_MT", BenhAnMatBanPhanTruoc.KichThuoc_UKetMac_MT));
            Command.Parameters.Add(new MDB.MDBParameter("CungDo_KetMac_MT", BenhAnMatBanPhanTruoc.CungDo_KetMac_MT));
            Command.Parameters.Add(new MDB.MDBParameter("ChieuCaoCuaCauDinh_KetMac_MT", BenhAnMatBanPhanTruoc.ChieuCaoCuaCauDinh_KetMac_MT));
            Command.Parameters.Add(new MDB.MDBParameter("DoRongCuaCauDinh_KetMac_MT", BenhAnMatBanPhanTruoc.DoRongCuaCauDinh_KetMac_MT));
            Command.Parameters.Add(new MDB.MDBParameter("TonThuongKhac_KetMac_MT", BenhAnMatBanPhanTruoc.TonThuongKhac_KetMac_MT));
            Command.Parameters.Add(new MDB.MDBParameter("KichThuoc_GiacMac_MT", BenhAnMatBanPhanTruoc.KichThuoc_GiacMac_MT));
            Command.Parameters.Add(new MDB.MDBParameter("HinhDang_GiacMac_MT", BenhAnMatBanPhanTruoc.HinhDang_GiacMac_MT));
            Command.Parameters.Add(new MDB.MDBParameter("BieuMo_GiacMac_MT", BenhAnMatBanPhanTruoc.BieuMo_GiacMac_MT == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("PhuBongBieuMo_GiacMac_MT", BenhAnMatBanPhanTruoc.PhuBongBieuMo_GiacMac_MT));
            Command.Parameters.Add(new MDB.MDBParameter("MatBieuMo_GiacMac_MT", BenhAnMatBanPhanTruoc.MatBieuMo_GiacMac_MT));
            Command.Parameters.Add(new MDB.MDBParameter("MatBieuMoKhoangCach_MT", BenhAnMatBanPhanTruoc.MatBieuMoKhoangCach_MT));
            Command.Parameters.Add(new MDB.MDBParameter("BoTonThuong_GM_MT", BenhAnMatBanPhanTruoc.BoTonThuong_GM_MT));
            Command.Parameters.Add(new MDB.MDBParameter("ThoaiThoaDaiBang_MT", BenhAnMatBanPhanTruoc.ThoaiThoaDaiBang_MT == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("LangDongThuoc_MT", BenhAnMatBanPhanTruoc.LangDongThuoc_MT == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("TonThuongKhac_BieuMo_GM_MT_TXT", BenhAnMatBanPhanTruoc.TonThuongKhac_BieuMo_GM_MT_TXT));
            Command.Parameters.Add(new MDB.MDBParameter("Phu_NhuMo_GiacMac_MT", BenhAnMatBanPhanTruoc.Phu_NhuMo_GiacMac_MT));
            Command.Parameters.Add(new MDB.MDBParameter("ThamLau_NhuMo_GiacMac_MT", BenhAnMatBanPhanTruoc.ThamLau_NhuMo_GiacMac_MT));
            Command.Parameters.Add(new MDB.MDBParameter("ThamLau_Vtri_NhuMo_GiacMac_MT", BenhAnMatBanPhanTruoc.ThamLau_Vtri_NhuMo_GiacMac_MT));
            Command.Parameters.Add(new MDB.MDBParameter("TieuMong_NhuMo_GiacMac_MT", BenhAnMatBanPhanTruoc.TieuMong_NhuMo_GiacMac_MT));
            Command.Parameters.Add(new MDB.MDBParameter("TieuMong_Vtri_NhuMo_GiacMac_MT", BenhAnMatBanPhanTruoc.TieuMong_Vtri_NhuMo_GiacMac_MT));
            Command.Parameters.Add(new MDB.MDBParameter("TonThuongKhac_NhuMo_GiacMac_MT", BenhAnMatBanPhanTruoc.TonThuongKhac_NhuMo_GiacMac_MT));
            Command.Parameters.Add(new MDB.MDBParameter("NepGap_NoiMo_GiacMac_MT", BenhAnMatBanPhanTruoc.NepGap_NoiMo_GiacMac_MT));
            Command.Parameters.Add(new MDB.MDBParameter("TuaSacToMacSauGM_MT", BenhAnMatBanPhanTruoc.TuaSacToMacSauGM_MT == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("MuMatSau_NoiMo_MT", BenhAnMatBanPhanTruoc.MuMatSau_NoiMo_MT == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("XuatTietMatSau_NoiMo_MT", BenhAnMatBanPhanTruoc.XuatTietMatSau_NoiMo_MT == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("Guttata_NoiMo_MT", BenhAnMatBanPhanTruoc.Guttata_NoiMo_MT == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("RanMangDescemet_NoiMo_MT", BenhAnMatBanPhanTruoc.RanMangDescemet_NoiMo_MT == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("CuonDescemet_NoiMo_MT", BenhAnMatBanPhanTruoc.CuonDescemet_NoiMo_MT == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("TonThuongKhac_NoiMo_MT", BenhAnMatBanPhanTruoc.TonThuongKhac_NoiMo_MT));
            Command.Parameters.Add(new MDB.MDBParameter("DoaThung_GiacMac_MT", BenhAnMatBanPhanTruoc.DoaThung_GiacMac_MT == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("KetMongMat_GiacMac_MT", BenhAnMatBanPhanTruoc.KetMongMat_GiacMac_MT == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("ThungGiacMac_MT", BenhAnMatBanPhanTruoc.ThungGiacMac_MT));
            Command.Parameters.Add(new MDB.MDBParameter("Seidel_MT", BenhAnMatBanPhanTruoc.Seidel_MT == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("DuongKinhThungGiacMac_MT", BenhAnMatBanPhanTruoc.DuongKinhThungGiacMac_MT));
            Command.Parameters.Add(new MDB.MDBParameter("ThungBit_GM_MT" , BenhAnMatBanPhanTruoc.iThungBit_GM_MT));
            Command.Parameters.Add(new MDB.MDBParameter("CamGiacGiacMac_MT", BenhAnMatBanPhanTruoc.CamGiacGiacMac_MT));
            Command.Parameters.Add(new MDB.MDBParameter("TanMach_GiacMac_MT", BenhAnMatBanPhanTruoc.TanMach_GiacMac_MT));
            Command.Parameters.Add(new MDB.MDBParameter("MucDo_TanMach_GiacMac_MT", BenhAnMatBanPhanTruoc.MucDo_TanMach_GiacMac_MT));
            Command.Parameters.Add(new MDB.MDBParameter("SuyTeBaoNguon_MT", BenhAnMatBanPhanTruoc.SuyTeBaoNguon_MT == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("ThoaiHoaGia_MT", BenhAnMatBanPhanTruoc.ThoaiHoaGia_MT == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("LangDongCanXi_MT", BenhAnMatBanPhanTruoc.LangDongCanXi_MT == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("BatThuongKhac_GiacMac_MT", BenhAnMatBanPhanTruoc.BatThuongKhac_GiacMac_MT));
            Command.Parameters.Add(new MDB.MDBParameter("Viem_CungMac_MT", BenhAnMatBanPhanTruoc.Viem_CungMac_MT));
            Command.Parameters.Add(new MDB.MDBParameter("Viem_NongSau_CungMac_MT", BenhAnMatBanPhanTruoc.iViem_NongSau_CungMac_MT));
            Command.Parameters.Add(new MDB.MDBParameter("ViemThuongCungMac_MT", BenhAnMatBanPhanTruoc.ViemThuongCungMac_MT == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("GianLoi_TieuMong_HoaiTu_MT", BenhAnMatBanPhanTruoc.GianLoi_TieuMong_HoaiTu_MT));
            Command.Parameters.Add(new MDB.MDBParameter("ChiTietKhac_CungMac_MT", BenhAnMatBanPhanTruoc.ChiTietKhac_CungMac_MT));
            Command.Parameters.Add(new MDB.MDBParameter("TienPhong_MT", BenhAnMatBanPhanTruoc.TienPhong_MT));
            Command.Parameters.Add(new MDB.MDBParameter("Mu_TienPhong_MT", BenhAnMatBanPhanTruoc.Mu_TienPhong_MT));
            Command.Parameters.Add(new MDB.MDBParameter("Tydal_MT", BenhAnMatBanPhanTruoc.Tydal_MT == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("MangXuatTiet_MT", BenhAnMatBanPhanTruoc.MangXuatTiet_MT == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("Mau_TienPhong_MT", BenhAnMatBanPhanTruoc.Mau_TienPhong_MT));
            Command.Parameters.Add(new MDB.MDBParameter("TonThuongKhac_TienPhong_MT", BenhAnMatBanPhanTruoc.TonThuongKhac_TienPhong_MT));
            Command.Parameters.Add(new MDB.MDBParameter("NauXop_MT", BenhAnMatBanPhanTruoc.NauXop_MT == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("XoTeo_MT", BenhAnMatBanPhanTruoc.XoTeo_MT == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("CuongTu_MT", BenhAnMatBanPhanTruoc.CuongTu_MT == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("TanMach_MT", BenhAnMatBanPhanTruoc.TanMach_MT == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("Phoi_MT", BenhAnMatBanPhanTruoc.Phoi_MT == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("Ket_MT", BenhAnMatBanPhanTruoc.Ket_MT == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("DuongKinh_DongTu_MT", BenhAnMatBanPhanTruoc.DuongKinh_DongTu_MT));
            Command.Parameters.Add(new MDB.MDBParameter("DongTuTronMeoDinh_MT", BenhAnMatBanPhanTruoc.DongTuTronMeoDinh_MT));
            Command.Parameters.Add(new MDB.MDBParameter("ViTriDinh_DongTu_MT", BenhAnMatBanPhanTruoc.ViTriDinh_DongTu_MT));
            Command.Parameters.Add(new MDB.MDBParameter("PhanXaDongTu_MT", BenhAnMatBanPhanTruoc.PhanXaDongTu_MT));
            Command.Parameters.Add(new MDB.MDBParameter("TonThuongKhac_DongTu_MT", BenhAnMatBanPhanTruoc.TonThuongKhac_DongTu_MT));
            Command.Parameters.Add(new MDB.MDBParameter("ThuyTinhThe_MT", BenhAnMatBanPhanTruoc.iThuyTinhThe_MT));
            Command.Parameters.Add(new MDB.MDBParameter("HinhThaiDuc_ThuyTinhthe_MT", BenhAnMatBanPhanTruoc.HinhThaiDuc_ThuyTinhthe_MT));
            Command.Parameters.Add(new MDB.MDBParameter("IOL_CanLechDuc_MT", BenhAnMatBanPhanTruoc.IOL_CanLechDuc_MT));
            Command.Parameters.Add(new MDB.MDBParameter("IOL_TrongTPHP_MT", BenhAnMatBanPhanTruoc.iIOL_TrongTPHP_MT));
            Command.Parameters.Add(new MDB.MDBParameter("TonThuongKhac_ThuyTinhthe_MT", BenhAnMatBanPhanTruoc.TonThuongKhac_ThuyTinhthe_MT));
            Command.Parameters.Add(new MDB.MDBParameter("AnhDongTu_MT", BenhAnMatBanPhanTruoc.AnhDongTu_MT));
            Command.Parameters.Add(new MDB.MDBParameter("DichKinh_MT", BenhAnMatBanPhanTruoc.DichKinh_MT));
            Command.Parameters.Add(new MDB.MDBParameter("TonThuongKhac_DichKinh_MT", BenhAnMatBanPhanTruoc.TonThuongKhac_DichKinh_MT));
            Command.Parameters.Add(new MDB.MDBParameter("DayMat_MT", BenhAnMatBanPhanTruoc.DayMat_MT));
            Command.Parameters.Add(new MDB.MDBParameter("CD_DayMat_MT", BenhAnMatBanPhanTruoc.CD_DayMat_MT));
            Command.Parameters.Add(new MDB.MDBParameter("PhuGai_MT", BenhAnMatBanPhanTruoc.PhuGai_MT == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("BacMauGaiThi_MT", BenhAnMatBanPhanTruoc.BacMauGaiThi_MT == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("VongMac_DayMat_MT", BenhAnMatBanPhanTruoc.VongMac_DayMat_MT));
            Command.Parameters.Add(new MDB.MDBParameter("HeMachMau_DayMat_MT", BenhAnMatBanPhanTruoc.HeMachMau_DayMat_MT));
            Command.Parameters.Add(new MDB.MDBParameter("TonThuongKhac_DayMat_MT", BenhAnMatBanPhanTruoc.TonThuongKhac_DayMat_MT));
            Command.Parameters.Add(new MDB.MDBParameter("HuyetAp_ToanThan", BenhAnMatBanPhanTruoc.HuyetAp_ToanThan));
            Command.Parameters.Add(new MDB.MDBParameter("NhietDo_ToanThan", BenhAnMatBanPhanTruoc.NhietDo_ToanThan));
            Command.Parameters.Add(new MDB.MDBParameter("Mach_ToanThan", BenhAnMatBanPhanTruoc.Mach_ToanThan));
            Command.Parameters.Add(new MDB.MDBParameter("NoiTiet_Tick", BenhAnMatBanPhanTruoc.NoiTiet_Tick == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("NoiTiet", BenhAnMatBanPhanTruoc.NoiTiet));
            Command.Parameters.Add(new MDB.MDBParameter("ThanKinh_Tick", BenhAnMatBanPhanTruoc.ThanKinh_Tick == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("TuanHoan_Tick", BenhAnMatBanPhanTruoc.TuanHoan_Tick == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("HoHap_Tick", BenhAnMatBanPhanTruoc.HoHap_Tick == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("TieuHoa_Tick", BenhAnMatBanPhanTruoc.TieuHoa_Tick == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("CoXuongKhop_Tick", BenhAnMatBanPhanTruoc.CoXuongKhop_Tick == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("ThanTietNieu_Tick", BenhAnMatBanPhanTruoc.ThanTietNieu_Tick == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("BenhChinh_MatPhai", BenhAnMatBanPhanTruoc.BenhChinh_MatPhai));
            Command.Parameters.Add(new MDB.MDBParameter("BenhChinh_MatTrai", BenhAnMatBanPhanTruoc.BenhChinh_MatTrai));
            Command.Parameters.Add(new MDB.MDBParameter("PhuongPhapChinh", BenhAnMatBanPhanTruoc.PhuongPhapChinh));
            Command.Parameters.Add(new MDB.MDBParameter("CheDoAnUong", BenhAnMatBanPhanTruoc.CheDoAnUong));
            Command.Parameters.Add(new MDB.MDBParameter("CheDoChamSoc", BenhAnMatBanPhanTruoc.CheDoChamSoc));
            Command.Parameters.Add(new MDB.MDBParameter("ChanDoanBenhChinh_LamSang", BenhAnMatBanPhanTruoc.ChanDoanBenhChinh_LamSang));
            Command.Parameters.Add(new MDB.MDBParameter("ChanDoanBenhChinh_NguyenNhan", BenhAnMatBanPhanTruoc.ChanDoanBenhChinh_NguyenNhan));
            Command.Parameters.Add(new MDB.MDBParameter("QuaTrinhDieuTri_NoiKhoa", BenhAnMatBanPhanTruoc.QuaTrinhDieuTri_NoiKhoa));
            Command.Parameters.Add(new MDB.MDBParameter("QuaTrinhDieuTri_KetQua", BenhAnMatBanPhanTruoc.QuaTrinhDieuTri_KetQua));
            Command.Parameters.Add(new MDB.MDBParameter("QuaTrinhDieuTri_BienChung", BenhAnMatBanPhanTruoc.QuaTrinhDieuTri_BienChung));
            Command.Parameters.Add(new MDB.MDBParameter("HuongDieuTriTiep", BenhAnMatBanPhanTruoc.HuongDieuTriTiep));
            Command.Parameters.Add(new MDB.MDBParameter("MiMat_T", BenhAnMatBanPhanTruoc.MiMat_T));
            Command.Parameters.Add(new MDB.MDBParameter("MiMat_P", BenhAnMatBanPhanTruoc.MiMat_P));
            Command.Parameters.Add(new MDB.MDBParameter("ChuaThayBenhLy", BenhAnMatBanPhanTruoc.ChuaThayBenhLy ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("BenhLy", BenhAnMatBanPhanTruoc.BenhLy ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("BenhLy_Text", BenhAnMatBanPhanTruoc.BenhLy_Text));
            Command.Parameters.Add(new MDB.MDBParameter("PhauThuat", BenhAnMatBanPhanTruoc.PhauThuat == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("ThuThuat", BenhAnMatBanPhanTruoc.ThuThuat == true ? "1" : "0"));

            Command.Parameters.Add(new MDB.MDBParameter("ThiLucKhiRaVien_KhongKinh_MP", BenhAnMatBanPhanTruoc.ThiLucKhiRaVien_KhongKinh_MP));
            Command.Parameters.Add(new MDB.MDBParameter("ThiLucKhiRaVien_KhongKinh_MT", BenhAnMatBanPhanTruoc.ThiLucKhiRaVien_KhongKinh_MT));
            Command.Parameters.Add(new MDB.MDBParameter("ThiLucKhiRaVien_CoKinh_MP", BenhAnMatBanPhanTruoc.ThiLucKhiRaVien_CoKinh_MP));
            Command.Parameters.Add(new MDB.MDBParameter("ThiLucKhiRaVien_CoKinh_MT", BenhAnMatBanPhanTruoc.ThiLucKhiRaVien_CoKinh_MT));
            Command.Parameters.Add(new MDB.MDBParameter("NhanApRaVien_MT", BenhAnMatBanPhanTruoc.NhanApRaVien_MT));
            Command.Parameters.Add(new MDB.MDBParameter("NhanApRaVien_MP", BenhAnMatBanPhanTruoc.NhanApRaVien_MP));

            Command.Parameters.Add(new MDB.MDBParameter("ThoatNuocTot_MP_Text", BenhAnMatBanPhanTruoc.ThoatNuocTot_MP_Text));
            Command.Parameters.Add(new MDB.MDBParameter("ThoatNuocTot_MT_Text", BenhAnMatBanPhanTruoc.ThoatNuocTot_MT_Text));
            Command.Parameters.Add(new MDB.MDBParameter("TraoLeQuanDoiDien_MP_Text", BenhAnMatBanPhanTruoc.TraoLeQuanDoiDien_MP_Text));
            Command.Parameters.Add(new MDB.MDBParameter("TraoLeQuanDoiDien_MT_Text", BenhAnMatBanPhanTruoc.TraoLeQuanDoiDien_MT_Text));
            Command.Parameters.Add(new MDB.MDBParameter("TraoLeQuanTaiCho_MP_Text", BenhAnMatBanPhanTruoc.TraoLeQuanTaiCho_MP_Text));
            Command.Parameters.Add(new MDB.MDBParameter("TraoLeQuanTaiCho_MT_Text", BenhAnMatBanPhanTruoc.TraoLeQuanTaiCho_MT_Text));
            Command.Parameters.Add(new MDB.MDBParameter("KetMac_Mong_MP", BenhAnMatBanPhanTruoc.KetMac_Mong_MP));
            Command.Parameters.Add(new MDB.MDBParameter("KetMac_Mong_MT", BenhAnMatBanPhanTruoc.KetMac_Mong_MT));
            Command.Parameters.Add(new MDB.MDBParameter("GhepGiacMac_MP", BenhAnMatBanPhanTruoc.GhepGiacMac_MP ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("GhepGiacMac_MT", BenhAnMatBanPhanTruoc.GhepGiacMac_MT ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("BieuMo_GiacMac_BT_MP", BenhAnMatBanPhanTruoc.BieuMo_GiacMac_BT_MP ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("BieuMo_GiacMac_BT_MT", BenhAnMatBanPhanTruoc.BieuMo_GiacMac_BT_MT ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("NhuMo_GiacMac_BT_MP", BenhAnMatBanPhanTruoc.NhuMo_GiacMac_BT_MP ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("NhuMo_GiacMac_BT_MT", BenhAnMatBanPhanTruoc.NhuMo_GiacMac_BT_MT ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("NoiMo_GiacMac_BT_MP", BenhAnMatBanPhanTruoc.NoiMo_GiacMac_BT_MP ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("NoiMo_GiacMac_BT_MT", BenhAnMatBanPhanTruoc.NoiMo_GiacMac_BT_MT ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("CungMac_BT_MP", BenhAnMatBanPhanTruoc.CungMac_BT_MP ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("CungMac_BT_MT", BenhAnMatBanPhanTruoc.CungMac_BT_MT ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("Khuyet_MP", BenhAnMatBanPhanTruoc.Khuyet_MP ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("Khuyet_MT", BenhAnMatBanPhanTruoc.Khuyet_MT ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("Khac_MongMat_MP", BenhAnMatBanPhanTruoc.Khac_MongMat_MP));
            Command.Parameters.Add(new MDB.MDBParameter("Khac_MongMat_MT", BenhAnMatBanPhanTruoc.Khac_MongMat_MT));

            Command.Parameters.Add(new MDB.MDBParameter("NoiTietCheck", BenhAnMatBanPhanTruoc.NoiTietCheck));
            Command.Parameters.Add(new MDB.MDBParameter("NoiTiet_Text", BenhAnMatBanPhanTruoc.NoiTiet_Text));
            Command.Parameters.Add(new MDB.MDBParameter("ThanKinhCheck", BenhAnMatBanPhanTruoc.ThanKinhCheck));
            Command.Parameters.Add(new MDB.MDBParameter("ThanKinh_Text", BenhAnMatBanPhanTruoc.ThanKinh_Text));
            Command.Parameters.Add(new MDB.MDBParameter("TuanHoanCheck", BenhAnMatBanPhanTruoc.TuanHoanCheck));
            Command.Parameters.Add(new MDB.MDBParameter("TuanHoan_Text", BenhAnMatBanPhanTruoc.TuanHoan_Text));
            Command.Parameters.Add(new MDB.MDBParameter("HoHapCheck", BenhAnMatBanPhanTruoc.HoHapCheck));
            Command.Parameters.Add(new MDB.MDBParameter("HoHap_Text", BenhAnMatBanPhanTruoc.HoHap_Text));
            Command.Parameters.Add(new MDB.MDBParameter("TieuHoaCheck", BenhAnMatBanPhanTruoc.TieuHoaCheck));
            Command.Parameters.Add(new MDB.MDBParameter("TieuHoa_Text", BenhAnMatBanPhanTruoc.TieuHoa_Text));
            Command.Parameters.Add(new MDB.MDBParameter("CoXuongKhopCheck", BenhAnMatBanPhanTruoc.CoXuongKhopCheck));
            Command.Parameters.Add(new MDB.MDBParameter("CoXuongKhop_Text", BenhAnMatBanPhanTruoc.CoXuongKhop_Text));
            Command.Parameters.Add(new MDB.MDBParameter("TietNieuSinhDucCheck", BenhAnMatBanPhanTruoc.TietNieuSinhDucCheck));
            Command.Parameters.Add(new MDB.MDBParameter("TietNieuSinhDuc_Text", BenhAnMatBanPhanTruoc.TietNieuSinhDuc_Text));
            Command.Parameters.Add(new MDB.MDBParameter("KhamBenhToanThan_Khac", BenhAnMatBanPhanTruoc.KhamBenhToanThan_Khac));

            Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", BenhAnMatBanPhanTruoc.MaQuanLy));
            int n = Command.ExecuteNonQuery(); // C#
            return n > 0 ? true : false;
        }
        public static bool Delete(MDB.MDBConnection MyConnection, BenhAnMatBanPhanTruoc BenhAnMatBanPhanTruoc)
        {
            string sql = @"DELETE FROM BenhAnMatBanPhanTruoc 
                           WHERE MaQuanLy = :MaQuanLy";
            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
            Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", BenhAnMatBanPhanTruoc.MaQuanLy));

            int n = Command.ExecuteNonQuery(); // C#
            return n > 0 ? true : false;
        }
    }
}
