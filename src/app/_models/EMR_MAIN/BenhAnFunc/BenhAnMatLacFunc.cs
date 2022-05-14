using System.Data;

namespace EMR_MAIN
{
    public class BenhAnMatLacFunc
    {
        public static void WriteXml(MDB.MDBConnection MyConnection)
        {
            string sql =
                   @"
                  select  a.*,  CTScanner HoSo_CTScanner, SieuAm HoSo_SieuAm, XetNghiem HoSo_XetNghiem,  Khac HoSo_Khac,  Khac_Text HoSo_Khac_Text,  ToanBoHoSo HoSo_ToanBoHoSo, Mach DauSinhTon_Mach,  NhietDo DauSinhTon_NhietDo,  HuyetAp DauSinhTon_HuyetAp,  NhipTho DauSinhTon_NhipTho,  CanNang DauSinhTon_CanNang  
                  from BenhAnMatLac a inner join thongtindieutri b on a.maquanly = b.maquanly
                  where rownum = 1
                    ";
            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
            MDB.MDBDataReader DataReader = Command.ExecuteReader();

            var DataTable = new DataTable { TableName = "BenhAnMatLac" };
            DataTable.Load(DataReader as IDataReader);
            DataTable.WriteXml("rptBenhAnMatLac.xml");
        }
        public static DataSet SelectDataSet(MDB.MDBConnection MyConnection, decimal MaQuanLy)
        {
            string sql =
                   @"
                    select  a.*,f.hovaten BacSyLamBenhAnHoVaTen ,c.hovaten BacSyDieuTriHoVaTen,d.hovaten NguoiGiaoHoSoHoVaTen,e.hovaten NguoiNhanHoSoHoVaTen, b.XQuang HoSo_XQuang,   b.CTScanner HoSo_CTScanner, b.SieuAm HoSo_SieuAm, b.XetNghiem HoSo_XetNghiem,  b.Khac HoSo_Khac,  b.Khac_Text HoSo_Khac_Text,  b.ToanBoHoSo HoSo_ToanBoHoSo, b.Mach DauSinhTon_Mach, b.NhietDo DauSinhTon_NhietDo,  b.HuyetAp DauSinhTon_HuyetAp,  b.NhipTho DauSinhTon_NhipTho,  b.CanNang DauSinhTon_CanNang  , b.ChieuCao DauSinhTon_ChieuCao, b.BMI DauSinhTon_BMI, b.NgayRaVien 
                 from BenhAnMatLac a 
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
                @"   select a.*,c.hovaten BacSyPhauThuatHoVaTen, d.hovaten BacSyGayMeHoVaTen
                  from PhauThuatThuThuat a
                  left join nhanvien c on a.bacsyphauthuat  = c.manhanvien
                  left join nhanvien d on a.bacsygayme= d.manhanvien
                  where a.maquanly = " + MaQuanLy.ToString(System.Globalization.CultureInfo.InvariantCulture);
            adt = new MDB.MDBDataAdapter(sql2, MyConnection);
            adt.Fill(ds, "Table2");
            return ds;
        }
        public static BenhAnMatLac Select(MDB.MDBConnection MyConnection, decimal MaQuanLy)
        {
            #region
            string sql =
                      @"select * 
                        from BenhAnMatLac a
                        where MaQuanLy = :MaQuanLy";
            #endregion
            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
            Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", MaQuanLy));
            MDB.MDBDataReader DataReader = Command.ExecuteReader();
            var value = new BenhAnMatLac();
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
                value.LyDoVaoVien_Lac = DataReader["LyDoVaoVien_Lac"].ToString() == "1" ? true : false;
                value.LyDoVaoVien_SupMi = DataReader["LyDoVaoVien_SupMi"].ToString() == "1" ? true : false;
                value.LyDoVaoVien_Khac = DataReader["LyDoVaoVien_Khac"].ToString() == "1" ? true : false;
                value.QuaTrinhBenhLy_NguyenNhan = DataReader["QuaTrinhBenhLy_NguyenNhan"].ToString() == "1" ? true : false;
                value.NguyenNhan_TuBaoGio = DataReader["NguyenNhan_TuBaoGio"].ToString();
                value.TrieuChungChinh = DataReader.GetInt("TrieuChungChinh");
                value.TrieuChung_SupMi = DataReader["TrieuChung_SupMi"].ToString() == "1" ? true : false;
                value.TrieuChung_RungGiatNhanCau = DataReader["TrieuChung_RungGiatNhanCau"].ToString() == "1" ? true : false;
                value.TrieuChung_Khac = DataReader["TrieuChung_Khac"].ToString() == "1" ? true : false;
                value.TrieuChung_Khac_Text = DataReader["TrieuChung_Khac_Text"].ToString();
                value.DaDieuTri_TapNhuocThi = DataReader["DaDieuTri_TapNhuocThi"].ToString() == "1" ? true : false;
                value.TapNhuocThi_PhuongPhap = DataReader["TapNhuocThi_PhuongPhap"].ToString();
                value.TapNhuocThi_KetQua = DataReader.GetInt("TapNhuocThi_KetQua");
                value.DaDieuTri_PhauThuat = DataReader["DaDieuTri_PhauThuat"].ToString() == "1" ? true : false;
                value.DaDieuTri_PhauThuat_PhuongPhap = DataReader["DaDieuTri_PhauThuat_PhuongPhap"].ToString();
                value.KetQua_PhauThuat_Tot = DataReader["KetQua_PhauThuat_Tot"].ToString() == "1" ? true : false;
                value.KetQua_PhauThuat_MoNon = DataReader["KetQua_PhauThuat_MoNon"].ToString() == "1" ? true : false;
                value.KetQua_PhauThuat_MoNon_Text = DataReader["KetQua_PhauThuat_MoNon_Text"].ToString();
                value.KetQua_PhauThuat_MoGia = DataReader["KetQua_PhauThuat_MoGia"].ToString() == "1" ? true : false;
                value.KetQua_PhauThuat_MoGiaText = DataReader["KetQua_PhauThuat_MoGiaText"].ToString();
                value.TienSuBenhBanThan_Tick = DataReader["TienSuBenhBanThan_Tick"].ToString() == "1" ? true : false;
                value.TienSuBenhGiaDinh_Tick = DataReader["TienSuBenhGiaDinh_Tick"].ToString() == "1" ? true : false;
                value.KhucXaMay_TruocAtropine_MP = DataReader["KhucXaMay_TruocAtropine_MP"].ToString();
                value.KhucXaMay_SauAtropine_MP = DataReader["KhucXaMay_SauAtropine_MP"].ToString();
                value.KhucXaMay_SauAtropine_MT = DataReader["KhucXaMay_SauAtropine_MT"].ToString();
                value.KhucXaMay_TruocAtropine_MT = DataReader["KhucXaMay_TruocAtropine_MT"].ToString();
                value.VanNhanNoiTai_MP = DataReader["VanNhanNoiTai_MP"].ToString() == "1" ? true : false;
                value.VanNhanNoiTai_Text_MP = DataReader["VanNhanNoiTai_Text_MP"].ToString();
                value.VanNhanNoiTai_MT = DataReader["VanNhanNoiTai_MT"].ToString() == "1" ? true : false;
                value.VanNhanNoiTai_TextMT = DataReader["VanNhanNoiTai_TextMT"].ToString();
                value.DiemCanQuyTu = DataReader["DiemCanQuyTu"].ToString() == "1" ? true : false;
                value.DiemCanQuyTu_Text = DataReader["DiemCanQuyTu_Text"].ToString();
                value.RungGiatNhanCau = DataReader["RungGiatNhanCau"].ToString() == "1" ? true : false;
                value.RungGiatNhanCau_Text = DataReader["RungGiatNhanCau_Text"].ToString();
                value.KieuRGNC = DataReader["KieuRGNC"].ToString();
                value.GocHam = DataReader["GocHam"].ToString() == "1" ? true : false;
                value.ThiNghiemCheMat = DataReader.GetInt("ThiNghiemCheMat");
                value.HinhThaiVaTinhChatLac = DataReader["HinhThaiVaTinhChatLac"].ToString();
                value.Hirschberg_Truoc_atropine = DataReader["Hirschberg_Truoc_atropine"].ToString();
                value.Hirschberg_Sau_atropine = DataReader["Hirschberg_Sau_atropine"].ToString();
                value.LangKinh_Truoc_atropine = DataReader["LangKinh_Truoc_atropine"].ToString();
                value.LangKinh_Sau_atropine = DataReader["LangKinh_Sau_atropine"].ToString();
                value.NhinGan = DataReader["NhinGan"].ToString();
                value.NhinLen = DataReader["NhinLen"].ToString();
                value.NhinXa = DataReader["NhinXa"].ToString();
                value.NhinXuong = DataReader["NhinXuong"].ToString();
                value.HoiChung = DataReader["HoiChung"].ToString();
                value.Synoptophore_KhacQuan = DataReader["Synoptophore_KhacQuan"].ToString();
                value.Synoptophore_ChuQuan = DataReader["Synoptophore_ChuQuan"].ToString();
                value.TinhTrangThiGiacHaiMat = DataReader.GetInt("TinhTrangThiGiacHaiMat");
                value.TinhTrangThiGiacHaiMat_Text = DataReader["TinhTrangThiGiacHaiMat_Text"].ToString();
                value.BienDoHopThi = DataReader["BienDoHopThi"].ToString();
                value.TuongUngVongMac = DataReader["TuongUngVongMac"].ToString() == "1" ? true : false;
                value.SongThi = DataReader["SongThi"].ToString() == "1" ? true : false;
                value.SongThi_Text = DataReader["SongThi_Text"].ToString();
                value.TuTheBuTru = DataReader["TuTheBuTru"].ToString() == "1" ? true : false;
                value.TuTheBuTru_Text = DataReader["TuTheBuTru_Text"].ToString();
                value.MiMat_MP = DataReader["MiMat_MP"].ToString() == "1" ? true : false;
                value.SupMi_MP = DataReader["SupMi_MP"].ToString() == "1" ? true : false;
                value.SupMi_MucDo_MP = DataReader.GetInt("SupMi_MucDo_MP");
                value.Epicanthus_MP = DataReader["Epicanthus_MP"].ToString() == "1" ? true : false;
                value.CoNangMi_MP = DataReader.GetInt("CoNangMi_MP");
                value.Marcusgunn_MP = DataReader["Marcusgunn_MP"].ToString() == "1" ? true : false;
                value.Bell_MP = DataReader["Bell_MP"].ToString() == "1" ? true : false;
                value.Khac_MiMat_MP = DataReader["Khac_MiMat_MP"].ToString();
                value.KetMac_MP = DataReader["KetMac_MP"].ToString() == "1" ? true : false;
                value.KetMac_Text_MP = DataReader["KetMac_Text_MP"].ToString();
                value.PhanNhanCauTruoc_MP = DataReader["PhanNhanCauTruoc_MP"].ToString() == "1" ? true : false;
                value.PhanNhanCauTruoc_Text_MP = DataReader["PhanNhanCauTruoc_Text_MP"].ToString();
                value.PhanNhanCauSau_MP = DataReader["PhanNhanCauSau_MP"].ToString() == "1" ? true : false;
                value.PhanNhanCauSau_Text_MP = DataReader["PhanNhanCauSau_Text_MP"].ToString();
                value.DinhThi_MP = DataReader.GetInt("DinhThi_MP");
                value.MiMat_MT = DataReader["MiMat_MT"].ToString() == "1" ? true : false;
                value.SupMi_MT = DataReader["SupMi_MT"].ToString() == "1" ? true : false;
                value.SupMi_MucDo_MT = DataReader.GetInt("SupMi_MucDo_MT");
                value.Epicanthus_MT = DataReader["Epicanthus_MT"].ToString() == "1" ? true : false;
                value.CoNangMi_MT = DataReader.GetInt("CoNangMi_MT");
                value.Marcusgunn_MT = DataReader["Marcusgunn_MT"].ToString() == "1" ? true : false;
                value.Bell_MT = DataReader["Bell_MT"].ToString() == "1" ? true : false;
                value.Khac_MiMat_MT = DataReader["Khac_MiMat_MT"].ToString();
                value.KetMac_MT = DataReader["KetMac_MT"].ToString() == "1" ? true : false;
                value.KetMac_Text_MT = DataReader["KetMac_Text_MT"].ToString();
                value.PhanNhanCauTruoc_MT = DataReader["PhanNhanCauTruoc_MT"].ToString() == "1" ? true : false;
                value.PhanNhanCauTruoc_Text_MT = DataReader["PhanNhanCauTruoc_Text_MT"].ToString();
                value.PhanNhanCauSau_MT = DataReader["PhanNhanCauSau_MT"].ToString() == "1" ? true : false;
                value.PhanNhanCauSau_Text_MT = DataReader["PhanNhanCauSau_Text_MT"].ToString();
                value.DinhThi_MT = DataReader.GetInt("DinhThi_MT");
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
                value.MaICD_BenhChinh = DataReader["MaICD_BenhChinh"].ToString();
                value.MaICD_BenhKemTheo = DataReader["MaICD_BenhKemTheo"].ToString();
                value.PhuongPhapChinh = DataReader["PhuongPhapChinh"].ToString();
                value.CheDoAnUong = DataReader["CheDoAnUong"].ToString();
                value.CheDoChamSoc = DataReader["CheDoChamSoc"].ToString();
                value.ChanDoanBenhChinh_LamSang = DataReader["ChanDoanBenhChinh_LamSang"].ToString();
                value.ChanDoanBenhChinh_NguyenNhan = DataReader["ChanDoanBenhChinh_NguyenNhan"].ToString();
                value.QuaTrinhDieuTri_NoiKhoa = DataReader["QuaTrinhDieuTri_NoiKhoa"].ToString();
                value.PhauThuat = DataReader["PhauThuat"].ToString() == "1" ? true : false;
                value.ThuThuat = DataReader["ThuThuat"].ToString() == "1" ? true : false;
                value.ThiLucRaVienKhongKinhMPTongKet = DataReader["ThiLucRaVienKhongKinhMPTongKet"].ToString();
                value.ThiLucRaVienKhongKinhMTTongKet = DataReader["ThiLucRaVienKhongKinhMTTongKet"].ToString();
                value.ThiLucRaVienCoKinhMPTongKet = DataReader["ThiLucRaVienCoKinhMPTongKet"].ToString();
                value.ThiLucRaVienCoKinhMTTongKet = DataReader["ThiLucRaVienCoKinhMTTongKet"].ToString();
                value.NhanApRaVienMPTongKet = DataReader["NhanApRaVienMPTongKet"].ToString();
                value.NhanApRaVienMTTongKet = DataReader["NhanApRaVienMTTongKet"].ToString();
                value.HuongDieuTriTiep = DataReader["HuongDieuTriTiep"].ToString();
                value.ThiLucKhiVaoVien_KhongKinh_MP = DataReader["ThiLucKhiVaoVien_KhongKinh_MP"].ToString();
                value.ThiLucKhiVaoVien_KhongKinh_MT = DataReader["ThiLucKhiVaoVien_KhongKinh_MT"].ToString();
                value.ThiLucKhiVaoVien_CoKinh_MP = DataReader["ThiLucKhiVaoVien_CoKinh_MP"].ToString();
                value.ThiLucKhiVaoVien_CoKinh_MT = DataReader["ThiLucKhiVaoVien_CoKinh_MT"].ToString();
                value.NhanApVaoVien_MT = DataReader["NhanApVaoVien_MT"].ToString();
                value.NhanApVaoVien_MP = DataReader["NhanApVaoVien_MP"].ToString();
                value.ThiTruong_MP = DataReader["ThiTruong_MP"].ToString();
                value.ThiTruong_MT = DataReader["ThiTruong_MT"].ToString();
                value.ChuaThayBenhLy = DataReader["ChuaThayBenhLy"].ToString().Equals("1") ? true : false;
                value.BenhLy = DataReader["BenhLy"].ToString().Equals("1") ? true : false;
                value.BenhLy_Text = DataReader["BenhLy_Text"].ToString();
                value.MaSoKyTen = DataReader["masokyten"].ToString();
                value.MaSoKyTen_KB = DataReader["masokyten_kb"].ToString();
                value.MaSoKyTen_TK = DataReader["masokyten_tk"].ToString();
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
            }
            return value;
        }

        public static bool InsertOrUpdate(MDB.MDBConnection MyConnection, BenhAnMatLac BenhAnMatLac)
        {
            string sql =
                      @"select MaQuanLy 
                        from BenhAnMatLac
                        where MaQuanLy = :MaQuanLy";
            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
            Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", BenhAnMatLac.MaQuanLy));
            MDB.MDBDataReader DataReader = Command.ExecuteReader();
            int rowCount = 0;
            while (DataReader.Read()) rowCount++;
            if (rowCount == 1) return Update(MyConnection, BenhAnMatLac);
            sql = @"
                   INSERT INTO BenhAnMatLac (MaQuanLy, LyDoVaoVien, VaoNgayThu, QuaTrinhBenhLy, TienSuBenhBanThan, TienSuBenhGiaDinh, ToanThan, TuanHoan, HoHap, TieuHoa, ThanTietNieuSinhDuc, ThanKinh, CoXuongKhop, TaiMuiHong, RangHamMat, Mat, Khac_CacCoQuan, CacXetNghiemCanLamSangCanLam, TomTatBenhAn, BenhChinh, BenhKemTheo, PhanBiet, TienLuong, HuongDieuTri, NgayKhamBenh, BacSyLamBenhAn, QuaTrinhBenhLyVaDienBien, TomTatKetQuaXetNghiem, PhuongPhapDieuTri, TinhTrangNguoiBenhRaVien, HuongDieuTriVaCacCheDoTiepTheo, NguoiNhanHoSo, NguoiGiaoHoSo, NgayTongKet, BacSyDieuTri, DiUng, DiUng_Text, MaTuy, MaTuy_Text, RuouBia, RuouBia_Text, ThuocLa, ThuocLa_Text, ThuocLao, ThuocLao_Text, Khac_DacDiemLienQuanBenh, Khac_DacDiemLienQuanBenh_Text, LyDoVaoVien_Lac, LyDoVaoVien_SupMi, LyDoVaoVien_Khac, QuaTrinhBenhLy_NguyenNhan, NguyenNhan_TuBaoGio, TrieuChungChinh, TrieuChung_SupMi, TrieuChung_RungGiatNhanCau, TrieuChung_Khac, TrieuChung_Khac_Text, DaDieuTri_TapNhuocThi, TapNhuocThi_PhuongPhap, TapNhuocThi_KetQua, DaDieuTri_PhauThuat, DaDieuTri_PhauThuat_PhuongPhap, KetQua_PhauThuat_Tot, KetQua_PhauThuat_MoNon, KetQua_PhauThuat_MoNon_Text, KetQua_PhauThuat_MoGia, KetQua_PhauThuat_MoGiaText, TienSuBenhBanThan_Tick, TienSuBenhGiaDinh_Tick, KhucXaMay_TruocAtropine_MP, KhucXaMay_SauAtropine_MP, KhucXaMay_SauAtropine_MT, KhucXaMay_TruocAtropine_MT, VanNhanNoiTai_MP, VanNhanNoiTai_Text_MP, VanNhanNoiTai_MT, VanNhanNoiTai_TextMT, DiemCanQuyTu, DiemCanQuyTu_Text, RungGiatNhanCau, RungGiatNhanCau_Text, KieuRGNC, GocHam, ThiNghiemCheMat, HinhThaiVaTinhChatLac, Hirschberg_Truoc_atropine, Hirschberg_Sau_atropine, LangKinh_Truoc_atropine, LangKinh_Sau_atropine, NhinGan, NhinLen, NhinXa, NhinXuong, HoiChung, Synoptophore_KhacQuan, Synoptophore_ChuQuan, TinhTrangThiGiacHaiMat, TinhTrangThiGiacHaiMat_Text, BienDoHopThi, TuongUngVongMac, SongThi, SongThi_Text, TuTheBuTru, TuTheBuTru_Text, MiMat_MP, SupMi_MP, SupMi_MucDo_MP, Epicanthus_MP, CoNangMi_MP, Marcusgunn_MP, Bell_MP, Khac_MiMat_MP, KetMac_MP, KetMac_Text_MP, PhanNhanCauTruoc_MP, PhanNhanCauTruoc_Text_MP, PhanNhanCauSau_MP, PhanNhanCauSau_Text_MP, DinhThi_MP, MiMat_MT, SupMi_MT, SupMi_MucDo_MT, Epicanthus_MT, CoNangMi_MT, Marcusgunn_MT, Bell_MT, Khac_MiMat_MT, KetMac_MT, KetMac_Text_MT, PhanNhanCauTruoc_MT, PhanNhanCauTruoc_Text_MT, PhanNhanCauSau_MT, PhanNhanCauSau_Text_MT, DinhThi_MT, HuyetAp_ToanThan, NhietDo_ToanThan, Mach_ToanThan, NoiTiet_Tick, NoiTiet, ThanKinh_Tick, TuanHoan_Tick, HoHap_Tick, TieuHoa_Tick, CoXuongKhop_Tick, ThanTietNieu_Tick, MaICD_BenhChinh, MaICD_BenhKemTheo, PhuongPhapChinh, CheDoAnUong, CheDoChamSoc, ChanDoanBenhChinh_LamSang, ChanDoanBenhChinh_NguyenNhan, QuaTrinhDieuTri_NoiKhoa, PhauThuat, ThuThuat, ThiLucRaVienKhongKinhMPTongKet, ThiLucRaVienKhongKinhMTTongKet, ThiLucRaVienCoKinhMPTongKet, ThiLucRaVienCoKinhMTTongKet, NhanApRaVienMPTongKet, NhanApRaVienMTTongKet, HuongDieuTriTiep, ThiLucKhiVaoVien_KhongKinh_MP, ThiLucKhiVaoVien_KhongKinh_MT, ThiLucKhiVaoVien_CoKinh_MP, ThiLucKhiVaoVien_CoKinh_MT, NhanApVaoVien_MT, NhanApVaoVien_MP, ThiTruong_MP, ThiTruong_MT, ChuaThayBenhLy, BenhLy, BenhLy_Text, NoiTietCheck, NoiTiet_Text, ThanKinhCheck, ThanKinh_Text, TuanHoanCheck, TuanHoan_Text, HoHapCheck, HoHap_Text, TieuHoaCheck, TieuHoa_Text, CoXuongKhopCheck , CoXuongKhop_Text, TietNieuSinhDucCheck, TietNieuSinhDuc_Text, KhamBenhToanThan_Khac)
                   VALUES(:MaQuanLy, :LyDoVaoVien, :VaoNgayThu, :QuaTrinhBenhLy, :TienSuBenhBanThan, :TienSuBenhGiaDinh, :ToanThan, :TuanHoan, :HoHap, :TieuHoa, :ThanTietNieuSinhDuc, :ThanKinh, :CoXuongKhop, :TaiMuiHong, :RangHamMat, :Mat, :Khac_CacCoQuan, :CacXetNghiemCanLamSangCanLam, :TomTatBenhAn, :BenhChinh, :BenhKemTheo, :PhanBiet, :TienLuong, :HuongDieuTri, :NgayKhamBenh, :BacSyLamBenhAn, :QuaTrinhBenhLyVaDienBien, :TomTatKetQuaXetNghiem, :PhuongPhapDieuTri, :TinhTrangNguoiBenhRaVien, :HuongDieuTriVaCacCheDoTiepTheo, :NguoiNhanHoSo, :NguoiGiaoHoSo, :NgayTongKet, :BacSyDieuTri, :DiUng, :DiUng_Text, :MaTuy, :MaTuy_Text, :RuouBia, :RuouBia_Text, :ThuocLa, :ThuocLa_Text, :ThuocLao, :ThuocLao_Text, :Khac_DacDiemLienQuanBenh, :Khac_DacDiemLienQuanBenh_Text, :LyDoVaoVien_Lac, :LyDoVaoVien_SupMi, :LyDoVaoVien_Khac, :QuaTrinhBenhLy_NguyenNhan, :NguyenNhan_TuBaoGio, :TrieuChungChinh, :TrieuChung_SupMi, :TrieuChung_RungGiatNhanCau, :TrieuChung_Khac, :TrieuChung_Khac_Text, :DaDieuTri_TapNhuocThi, :TapNhuocThi_PhuongPhap, :TapNhuocThi_KetQua, :DaDieuTri_PhauThuat, :DaDieuTri_PhauThuat_PhuongPhap, :KetQua_PhauThuat_Tot, :KetQua_PhauThuat_MoNon, :KetQua_PhauThuat_MoNon_Text, :KetQua_PhauThuat_MoGia, :KetQua_PhauThuat_MoGiaText, :TienSuBenhBanThan_Tick, :TienSuBenhGiaDinh_Tick, :KhucXaMay_TruocAtropine_MP, :KhucXaMay_SauAtropine_MP, :KhucXaMay_SauAtropine_MT, :KhucXaMay_TruocAtropine_MT, :VanNhanNoiTai_MP, :VanNhanNoiTai_Text_MP, :VanNhanNoiTai_MT, :VanNhanNoiTai_TextMT, :DiemCanQuyTu, :DiemCanQuyTu_Text, :RungGiatNhanCau, :RungGiatNhanCau_Text, :KieuRGNC, :GocHam, :ThiNghiemCheMat, :HinhThaiVaTinhChatLac, :Hirschberg_Truoc_atropine, :Hirschberg_Sau_atropine, :LangKinh_Truoc_atropine, :LangKinh_Sau_atropine, :NhinGan, :NhinLen, :NhinXa, :NhinXuong, :HoiChung, :Synoptophore_KhacQuan, :Synoptophore_ChuQuan, :TinhTrangThiGiacHaiMat, :TinhTrangThiGiacHaiMat_Text, :BienDoHopThi, :TuongUngVongMac, :SongThi, :SongThi_Text, :TuTheBuTru, :TuTheBuTru_Text, :MiMat_MP, :SupMi_MP, :SupMi_MucDo_MP, :Epicanthus_MP, :CoNangMi_MP, :Marcusgunn_MP, :Bell_MP, :Khac_MiMat_MP, :KetMac_MP, :KetMac_Text_MP, :PhanNhanCauTruoc_MP, :PhanNhanCauTruoc_Text_MP, :PhanNhanCauSau_MP, :PhanNhanCauSau_Text_MP, :DinhThi_MP, :MiMat_MT, :SupMi_MT, :SupMi_MucDo_MT, :Epicanthus_MT, :CoNangMi_MT, :Marcusgunn_MT, :Bell_MT, :Khac_MiMat_MT, :KetMac_MT, :KetMac_Text_MT, :PhanNhanCauTruoc_MT, :PhanNhanCauTruoc_Text_MT, :PhanNhanCauSau_MT, :PhanNhanCauSau_Text_MT, :DinhThi_MT, :HuyetAp_ToanThan, :NhietDo_ToanThan, :Mach_ToanThan, :NoiTiet_Tick, :NoiTiet, :ThanKinh_Tick, :TuanHoan_Tick, :HoHap_Tick, :TieuHoa_Tick, :CoXuongKhop_Tick, :ThanTietNieu_Tick, :MaICD_BenhChinh, :MaICD_BenhKemTheo, :PhuongPhapChinh, :CheDoAnUong, :CheDoChamSoc, :ChanDoanBenhChinh_LamSang, :ChanDoanBenhChinh_NguyenNhan, :QuaTrinhDieuTri_NoiKhoa, :PhauThuat, :ThuThuat, :ThiLucRaVienKhongKinhMPTongKet, :ThiLucRaVienKhongKinhMTTongKet, :ThiLucRaVienCoKinhMPTongKet, :ThiLucRaVienCoKinhMTTongKet, :NhanApRaVienMPTongKet, :NhanApRaVienMTTongKet, :HuongDieuTriTiep, :ThiLucKhiVaoVien_KhongKinh_MP, :ThiLucKhiVaoVien_KhongKinh_MT, :ThiLucKhiVaoVien_CoKinh_MP, :ThiLucKhiVaoVien_CoKinh_MT, :NhanApVaoVien_MT, :NhanApVaoVien_MP, :ThiTruong_MP, :ThiTruong_MT, :ChuaThayBenhLy, :BenhLy, :BenhLy_Text, :NoiTietCheck, :NoiTiet_Text, :ThanKinhCheck, :ThanKinh_Text, :TuanHoanCheck, :TuanHoan_Text, :HoHapCheck, :HoHap_Text, :TieuHoaCheck, :TieuHoa_Text, :CoXuongKhopCheck , :CoXuongKhop_Text, :TietNieuSinhDucCheck, :TietNieuSinhDuc_Text, :KhamBenhToanThan_Khac)
                   ";
            Command = new MDB.MDBCommand(sql, MyConnection);
            Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", BenhAnMatLac.MaQuanLy));
            Command.Parameters.Add(new MDB.MDBParameter("LyDoVaoVien", BenhAnMatLac.LyDoVaoVien));
            Command.Parameters.Add(new MDB.MDBParameter("VaoNgayThu", BenhAnMatLac.VaoNgayThu));
            Command.Parameters.Add(new MDB.MDBParameter("QuaTrinhBenhLy", BenhAnMatLac.QuaTrinhBenhLy));
            Command.Parameters.Add(new MDB.MDBParameter("TienSuBenhBanThan", BenhAnMatLac.TienSuBenhBanThan));
            Command.Parameters.Add(new MDB.MDBParameter("TienSuBenhGiaDinh", BenhAnMatLac.TienSuBenhGiaDinh));
            Command.Parameters.Add(new MDB.MDBParameter("ToanThan", BenhAnMatLac.ToanThan));
            Command.Parameters.Add(new MDB.MDBParameter("TuanHoan", BenhAnMatLac.TuanHoan));
            Command.Parameters.Add(new MDB.MDBParameter("HoHap", BenhAnMatLac.HoHap));
            Command.Parameters.Add(new MDB.MDBParameter("TieuHoa", BenhAnMatLac.TieuHoa));
            Command.Parameters.Add(new MDB.MDBParameter("ThanTietNieuSinhDuc", BenhAnMatLac.ThanTietNieuSinhDuc));
            Command.Parameters.Add(new MDB.MDBParameter("ThanKinh", BenhAnMatLac.ThanKinh));
            Command.Parameters.Add(new MDB.MDBParameter("CoXuongKhop", BenhAnMatLac.CoXuongKhop));
            Command.Parameters.Add(new MDB.MDBParameter("TaiMuiHong", BenhAnMatLac.TaiMuiHong));
            Command.Parameters.Add(new MDB.MDBParameter("RangHamMat", BenhAnMatLac.RangHamMat));
            Command.Parameters.Add(new MDB.MDBParameter("Mat", BenhAnMatLac.Mat));
            Command.Parameters.Add(new MDB.MDBParameter("Khac_CacCoQuan", BenhAnMatLac.Khac_CacCoQuan));
            Command.Parameters.Add(new MDB.MDBParameter("CacXetNghiemCanLamSangCanLam", BenhAnMatLac.CacXetNghiemCanLamSangCanLam));
            Command.Parameters.Add(new MDB.MDBParameter("TomTatBenhAn", BenhAnMatLac.TomTatBenhAn));
            Command.Parameters.Add(new MDB.MDBParameter("BenhChinh", BenhAnMatLac.BenhChinh));
            Command.Parameters.Add(new MDB.MDBParameter("BenhKemTheo", BenhAnMatLac.BenhKemTheo));
            Command.Parameters.Add(new MDB.MDBParameter("PhanBiet", BenhAnMatLac.PhanBiet));
            Command.Parameters.Add(new MDB.MDBParameter("TienLuong", BenhAnMatLac.TienLuong));
            Command.Parameters.Add(new MDB.MDBParameter("HuongDieuTri", BenhAnMatLac.HuongDieuTri));
            Command.Parameters.Add(new MDB.MDBParameter("NgayKhamBenh", BenhAnMatLac.NgayKhamBenh));
            Command.Parameters.Add(new MDB.MDBParameter("BacSyLamBenhAn", BenhAnMatLac.BacSyLamBenhAn));
            Command.Parameters.Add(new MDB.MDBParameter("QuaTrinhBenhLyVaDienBien", BenhAnMatLac.QuaTrinhBenhLyVaDienBien));
            Command.Parameters.Add(new MDB.MDBParameter("TomTatKetQuaXetNghiem", BenhAnMatLac.TomTatKetQuaXetNghiem));
            Command.Parameters.Add(new MDB.MDBParameter("PhuongPhapDieuTri", BenhAnMatLac.PhuongPhapDieuTri));
            Command.Parameters.Add(new MDB.MDBParameter("TinhTrangNguoiBenhRaVien", BenhAnMatLac.TinhTrangNguoiBenhRaVien));
            Command.Parameters.Add(new MDB.MDBParameter("HuongDieuTriVaCacCheDoTiepTheo", BenhAnMatLac.HuongDieuTriVaCacCheDoTiepTheo));
            Command.Parameters.Add(new MDB.MDBParameter("NguoiNhanHoSo", BenhAnMatLac.NguoiNhanHoSo));
            Command.Parameters.Add(new MDB.MDBParameter("NguoiGiaoHoSo", BenhAnMatLac.NguoiGiaoHoSo));
            Command.Parameters.Add(new MDB.MDBParameter("NgayTongKet", BenhAnMatLac.NgayTongKet));
            Command.Parameters.Add(new MDB.MDBParameter("BacSyDieuTri", BenhAnMatLac.BacSyDieuTri));
            Command.Parameters.Add(new MDB.MDBParameter("DiUng", BenhAnMatLac.DacDiemLienQuanBenh.DiUng == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("DiUng_Text", BenhAnMatLac.DacDiemLienQuanBenh.DiUng_Text));
            Command.Parameters.Add(new MDB.MDBParameter("MaTuy", BenhAnMatLac.DacDiemLienQuanBenh.MaTuy == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("MaTuy_Text", BenhAnMatLac.DacDiemLienQuanBenh.MaTuy_Text));
            Command.Parameters.Add(new MDB.MDBParameter("RuouBia", BenhAnMatLac.DacDiemLienQuanBenh.RuouBia == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("RuouBia_Text", BenhAnMatLac.DacDiemLienQuanBenh.RuouBia_Text));
            Command.Parameters.Add(new MDB.MDBParameter("ThuocLa", BenhAnMatLac.DacDiemLienQuanBenh.ThuocLa == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("ThuocLa_Text", BenhAnMatLac.DacDiemLienQuanBenh.ThuocLa_Text));
            Command.Parameters.Add(new MDB.MDBParameter("ThuocLao", BenhAnMatLac.DacDiemLienQuanBenh.ThuocLao == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("ThuocLao_Text", BenhAnMatLac.DacDiemLienQuanBenh.ThuocLao_Text));
            Command.Parameters.Add(new MDB.MDBParameter("Khac_DacDiemLienQuanBenh", BenhAnMatLac.DacDiemLienQuanBenh.Khac_DacDiemLienQuanBenh == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("Khac_DacDiemLienQuanBenh_Text", BenhAnMatLac.DacDiemLienQuanBenh.Khac_DacDiemLienQuanBenh_Text));
            Command.Parameters.Add(new MDB.MDBParameter("LyDoVaoVien_Lac", BenhAnMatLac.LyDoVaoVien_Lac == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("LyDoVaoVien_SupMi", BenhAnMatLac.LyDoVaoVien_SupMi == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("LyDoVaoVien_Khac", BenhAnMatLac.LyDoVaoVien_Khac == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("QuaTrinhBenhLy_NguyenNhan", BenhAnMatLac.QuaTrinhBenhLy_NguyenNhan == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("NguyenNhan_TuBaoGio", BenhAnMatLac.NguyenNhan_TuBaoGio));
            Command.Parameters.Add(new MDB.MDBParameter("TrieuChungChinh", BenhAnMatLac.TrieuChungChinh));
            Command.Parameters.Add(new MDB.MDBParameter("TrieuChung_SupMi", BenhAnMatLac.TrieuChung_SupMi == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("TrieuChung_RungGiatNhanCau", BenhAnMatLac.TrieuChung_RungGiatNhanCau == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("TrieuChung_Khac", BenhAnMatLac.TrieuChung_Khac == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("TrieuChung_Khac_Text", BenhAnMatLac.TrieuChung_Khac_Text));
            Command.Parameters.Add(new MDB.MDBParameter("DaDieuTri_TapNhuocThi", BenhAnMatLac.DaDieuTri_TapNhuocThi == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("TapNhuocThi_PhuongPhap", BenhAnMatLac.TapNhuocThi_PhuongPhap));
            Command.Parameters.Add(new MDB.MDBParameter("TapNhuocThi_KetQua", BenhAnMatLac.TapNhuocThi_KetQua));
            Command.Parameters.Add(new MDB.MDBParameter("DaDieuTri_PhauThuat", BenhAnMatLac.DaDieuTri_PhauThuat == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("DaDieuTri_PhauThuat_PhuongPhap", BenhAnMatLac.DaDieuTri_PhauThuat_PhuongPhap));
            Command.Parameters.Add(new MDB.MDBParameter("KetQua_PhauThuat_Tot", BenhAnMatLac.KetQua_PhauThuat_Tot == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("KetQua_PhauThuat_MoNon", BenhAnMatLac.KetQua_PhauThuat_MoNon == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("KetQua_PhauThuat_MoNon_Text", BenhAnMatLac.KetQua_PhauThuat_MoNon_Text));
            Command.Parameters.Add(new MDB.MDBParameter("KetQua_PhauThuat_MoGia", BenhAnMatLac.KetQua_PhauThuat_MoGia == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("KetQua_PhauThuat_MoGiaText", BenhAnMatLac.KetQua_PhauThuat_MoGiaText));
            Command.Parameters.Add(new MDB.MDBParameter("TienSuBenhBanThan_Tick", BenhAnMatLac.TienSuBenhBanThan_Tick == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("TienSuBenhGiaDinh_Tick", BenhAnMatLac.TienSuBenhGiaDinh_Tick == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("KhucXaMay_TruocAtropine_MP", BenhAnMatLac.KhucXaMay_TruocAtropine_MP));
            Command.Parameters.Add(new MDB.MDBParameter("KhucXaMay_SauAtropine_MP", BenhAnMatLac.KhucXaMay_SauAtropine_MP));
            Command.Parameters.Add(new MDB.MDBParameter("KhucXaMay_SauAtropine_MT", BenhAnMatLac.KhucXaMay_SauAtropine_MT));
            Command.Parameters.Add(new MDB.MDBParameter("KhucXaMay_TruocAtropine_MT", BenhAnMatLac.KhucXaMay_TruocAtropine_MT));
            Command.Parameters.Add(new MDB.MDBParameter("VanNhanNoiTai_MP", BenhAnMatLac.VanNhanNoiTai_MP == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("VanNhanNoiTai_Text_MP", BenhAnMatLac.VanNhanNoiTai_Text_MP));
            Command.Parameters.Add(new MDB.MDBParameter("VanNhanNoiTai_MT", BenhAnMatLac.VanNhanNoiTai_MT == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("VanNhanNoiTai_TextMT", BenhAnMatLac.VanNhanNoiTai_TextMT));
            Command.Parameters.Add(new MDB.MDBParameter("DiemCanQuyTu", BenhAnMatLac.DiemCanQuyTu == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("DiemCanQuyTu_Text", BenhAnMatLac.DiemCanQuyTu_Text));
            Command.Parameters.Add(new MDB.MDBParameter("RungGiatNhanCau", BenhAnMatLac.RungGiatNhanCau == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("RungGiatNhanCau_Text", BenhAnMatLac.RungGiatNhanCau_Text));
            Command.Parameters.Add(new MDB.MDBParameter("KieuRGNC", BenhAnMatLac.KieuRGNC));
            Command.Parameters.Add(new MDB.MDBParameter("GocHam", BenhAnMatLac.GocHam == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("ThiNghiemCheMat", BenhAnMatLac.ThiNghiemCheMat));
            Command.Parameters.Add(new MDB.MDBParameter("HinhThaiVaTinhChatLac", BenhAnMatLac.HinhThaiVaTinhChatLac));
            Command.Parameters.Add(new MDB.MDBParameter("Hirschberg_Truoc_atropine", BenhAnMatLac.Hirschberg_Truoc_atropine));
            Command.Parameters.Add(new MDB.MDBParameter("Hirschberg_Sau_atropine", BenhAnMatLac.Hirschberg_Sau_atropine));
            Command.Parameters.Add(new MDB.MDBParameter("LangKinh_Truoc_atropine", BenhAnMatLac.LangKinh_Truoc_atropine));
            Command.Parameters.Add(new MDB.MDBParameter("LangKinh_Sau_atropine", BenhAnMatLac.LangKinh_Sau_atropine));
            Command.Parameters.Add(new MDB.MDBParameter("NhinGan", BenhAnMatLac.NhinGan));
            Command.Parameters.Add(new MDB.MDBParameter("NhinLen", BenhAnMatLac.NhinLen));
            Command.Parameters.Add(new MDB.MDBParameter("NhinXa", BenhAnMatLac.NhinXa));
            Command.Parameters.Add(new MDB.MDBParameter("NhinXuong", BenhAnMatLac.NhinXuong));
            Command.Parameters.Add(new MDB.MDBParameter("HoiChung", BenhAnMatLac.HoiChung));
            Command.Parameters.Add(new MDB.MDBParameter("Synoptophore_KhacQuan", BenhAnMatLac.Synoptophore_KhacQuan));
            Command.Parameters.Add(new MDB.MDBParameter("Synoptophore_ChuQuan", BenhAnMatLac.Synoptophore_ChuQuan));
            Command.Parameters.Add(new MDB.MDBParameter("TinhTrangThiGiacHaiMat", BenhAnMatLac.TinhTrangThiGiacHaiMat));
            Command.Parameters.Add(new MDB.MDBParameter("TinhTrangThiGiacHaiMat_Text", BenhAnMatLac.TinhTrangThiGiacHaiMat_Text));
            Command.Parameters.Add(new MDB.MDBParameter("BienDoHopThi", BenhAnMatLac.BienDoHopThi));
            Command.Parameters.Add(new MDB.MDBParameter("TuongUngVongMac", BenhAnMatLac.TuongUngVongMac == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("SongThi", BenhAnMatLac.SongThi == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("SongThi_Text", BenhAnMatLac.SongThi_Text));
            Command.Parameters.Add(new MDB.MDBParameter("TuTheBuTru", BenhAnMatLac.TuTheBuTru == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("TuTheBuTru_Text", BenhAnMatLac.TuTheBuTru_Text));
            Command.Parameters.Add(new MDB.MDBParameter("MiMat_MP", BenhAnMatLac.MiMat_MP == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("SupMi_MP", BenhAnMatLac.SupMi_MP == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("SupMi_MucDo_MP", BenhAnMatLac.SupMi_MucDo_MP));
            Command.Parameters.Add(new MDB.MDBParameter("Epicanthus_MP", BenhAnMatLac.Epicanthus_MP == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("CoNangMi_MP", BenhAnMatLac.CoNangMi_MP));
            Command.Parameters.Add(new MDB.MDBParameter("Marcusgunn_MP", BenhAnMatLac.Marcusgunn_MP == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("Bell_MP", BenhAnMatLac.Bell_MP == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("Khac_MiMat_MP", BenhAnMatLac.Khac_MiMat_MP));
            Command.Parameters.Add(new MDB.MDBParameter("KetMac_MP", BenhAnMatLac.KetMac_MP == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("KetMac_Text_MP", BenhAnMatLac.KetMac_Text_MP));
            Command.Parameters.Add(new MDB.MDBParameter("PhanNhanCauTruoc_MP", BenhAnMatLac.PhanNhanCauTruoc_MP == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("PhanNhanCauTruoc_Text_MP", BenhAnMatLac.PhanNhanCauTruoc_Text_MP));
            Command.Parameters.Add(new MDB.MDBParameter("PhanNhanCauSau_MP", BenhAnMatLac.PhanNhanCauSau_MP == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("PhanNhanCauSau_Text_MP", BenhAnMatLac.PhanNhanCauSau_Text_MP));
            Command.Parameters.Add(new MDB.MDBParameter("DinhThi_MP", BenhAnMatLac.DinhThi_MP));
            Command.Parameters.Add(new MDB.MDBParameter("MiMat_MT", BenhAnMatLac.MiMat_MT == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("SupMi_MT", BenhAnMatLac.SupMi_MT == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("SupMi_MucDo_MT", BenhAnMatLac.SupMi_MucDo_MT));
            Command.Parameters.Add(new MDB.MDBParameter("Epicanthus_MT", BenhAnMatLac.Epicanthus_MT == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("CoNangMi_MT", BenhAnMatLac.CoNangMi_MT));
            Command.Parameters.Add(new MDB.MDBParameter("Marcusgunn_MT", BenhAnMatLac.Marcusgunn_MT == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("Bell_MT", BenhAnMatLac.Bell_MT == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("Khac_MiMat_MT", BenhAnMatLac.Khac_MiMat_MT));
            Command.Parameters.Add(new MDB.MDBParameter("KetMac_MT", BenhAnMatLac.KetMac_MT == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("KetMac_Text_MT", BenhAnMatLac.KetMac_Text_MT));
            Command.Parameters.Add(new MDB.MDBParameter("PhanNhanCauTruoc_MT", BenhAnMatLac.PhanNhanCauTruoc_MT == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("PhanNhanCauTruoc_Text_MT", BenhAnMatLac.PhanNhanCauTruoc_Text_MT));
            Command.Parameters.Add(new MDB.MDBParameter("PhanNhanCauSau_MT", BenhAnMatLac.PhanNhanCauSau_MT == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("PhanNhanCauSau_Text_MT", BenhAnMatLac.PhanNhanCauSau_Text_MT));
            Command.Parameters.Add(new MDB.MDBParameter("DinhThi_MT", BenhAnMatLac.DinhThi_MT));
            Command.Parameters.Add(new MDB.MDBParameter("HuyetAp_ToanThan", BenhAnMatLac.HuyetAp_ToanThan));
            Command.Parameters.Add(new MDB.MDBParameter("NhietDo_ToanThan", BenhAnMatLac.NhietDo_ToanThan));
            Command.Parameters.Add(new MDB.MDBParameter("Mach_ToanThan", BenhAnMatLac.Mach_ToanThan));
            Command.Parameters.Add(new MDB.MDBParameter("NoiTiet_Tick", BenhAnMatLac.NoiTiet_Tick == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("NoiTiet", BenhAnMatLac.NoiTiet));
            Command.Parameters.Add(new MDB.MDBParameter("ThanKinh_Tick", BenhAnMatLac.ThanKinh_Tick == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("TuanHoan_Tick", BenhAnMatLac.TuanHoan_Tick == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("HoHap_Tick", BenhAnMatLac.HoHap_Tick == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("TieuHoa_Tick", BenhAnMatLac.TieuHoa_Tick == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("CoXuongKhop_Tick", BenhAnMatLac.CoXuongKhop_Tick == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("ThanTietNieu_Tick", BenhAnMatLac.ThanTietNieu_Tick == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("MaICD_BenhChinh", BenhAnMatLac.MaICD_BenhChinh));
            Command.Parameters.Add(new MDB.MDBParameter("MaICD_BenhKemTheo", BenhAnMatLac.MaICD_BenhKemTheo));
            Command.Parameters.Add(new MDB.MDBParameter("PhuongPhapChinh", BenhAnMatLac.PhuongPhapChinh));
            Command.Parameters.Add(new MDB.MDBParameter("CheDoAnUong", BenhAnMatLac.CheDoAnUong));
            Command.Parameters.Add(new MDB.MDBParameter("CheDoChamSoc", BenhAnMatLac.CheDoChamSoc));
            Command.Parameters.Add(new MDB.MDBParameter("ChanDoanBenhChinh_LamSang", BenhAnMatLac.ChanDoanBenhChinh_LamSang));
            Command.Parameters.Add(new MDB.MDBParameter("ChanDoanBenhChinh_NguyenNhan", BenhAnMatLac.ChanDoanBenhChinh_NguyenNhan));
            Command.Parameters.Add(new MDB.MDBParameter("QuaTrinhDieuTri_NoiKhoa", BenhAnMatLac.QuaTrinhDieuTri_NoiKhoa));
            Command.Parameters.Add(new MDB.MDBParameter("PhauThuat", BenhAnMatLac.PhauThuat == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("ThuThuat", BenhAnMatLac.ThuThuat == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("ThiLucRaVienKhongKinhMPTongKet", BenhAnMatLac.ThiLucRaVienKhongKinhMPTongKet));
            Command.Parameters.Add(new MDB.MDBParameter("ThiLucRaVienKhongKinhMTTongKet", BenhAnMatLac.ThiLucRaVienKhongKinhMTTongKet));
            Command.Parameters.Add(new MDB.MDBParameter("ThiLucRaVienCoKinhMPTongKet", BenhAnMatLac.ThiLucRaVienCoKinhMPTongKet));
            Command.Parameters.Add(new MDB.MDBParameter("ThiLucRaVienCoKinhMTTongKet", BenhAnMatLac.ThiLucRaVienCoKinhMTTongKet));
            Command.Parameters.Add(new MDB.MDBParameter("NhanApRaVienMPTongKet", BenhAnMatLac.NhanApRaVienMPTongKet));
            Command.Parameters.Add(new MDB.MDBParameter("NhanApRaVienMTTongKet", BenhAnMatLac.NhanApRaVienMTTongKet));
            Command.Parameters.Add(new MDB.MDBParameter("HuongDieuTriTiep", BenhAnMatLac.HuongDieuTriTiep));
            Command.Parameters.Add(new MDB.MDBParameter("ThiLucKhiVaoVien_KhongKinh_MP", BenhAnMatLac.ThiLucKhiVaoVien_KhongKinh_MP));
            Command.Parameters.Add(new MDB.MDBParameter("ThiLucKhiVaoVien_KhongKinh_MT", BenhAnMatLac.ThiLucKhiVaoVien_KhongKinh_MT));
            Command.Parameters.Add(new MDB.MDBParameter("ThiLucKhiVaoVien_CoKinh_MP", BenhAnMatLac.ThiLucKhiVaoVien_CoKinh_MP));
            Command.Parameters.Add(new MDB.MDBParameter("ThiLucKhiVaoVien_CoKinh_MT", BenhAnMatLac.ThiLucKhiVaoVien_CoKinh_MT));
            Command.Parameters.Add(new MDB.MDBParameter("NhanApVaoVien_MT", BenhAnMatLac.NhanApVaoVien_MT));
            Command.Parameters.Add(new MDB.MDBParameter("NhanApVaoVien_MP", BenhAnMatLac.NhanApVaoVien_MP));
            Command.Parameters.Add(new MDB.MDBParameter("ThiTruong_MP", BenhAnMatLac.ThiTruong_MP));
            Command.Parameters.Add(new MDB.MDBParameter("ThiTruong_MT", BenhAnMatLac.ThiTruong_MT));
            Command.Parameters.Add(new MDB.MDBParameter("ChuaThayBenhLy", BenhAnMatLac.ChuaThayBenhLy ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("BenhLy", BenhAnMatLac.BenhLy ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("BenhLy_Text", BenhAnMatLac.BenhLy_Text));
            Command.Parameters.Add(new MDB.MDBParameter("NoiTietCheck", BenhAnMatLac.NoiTietCheck));
            Command.Parameters.Add(new MDB.MDBParameter("NoiTiet_Text", BenhAnMatLac.NoiTiet_Text));
            Command.Parameters.Add(new MDB.MDBParameter("ThanKinhCheck", BenhAnMatLac.ThanKinhCheck));
            Command.Parameters.Add(new MDB.MDBParameter("ThanKinh_Text", BenhAnMatLac.ThanKinh_Text));
            Command.Parameters.Add(new MDB.MDBParameter("TuanHoanCheck", BenhAnMatLac.TuanHoanCheck));
            Command.Parameters.Add(new MDB.MDBParameter("TuanHoan_Text", BenhAnMatLac.TuanHoan_Text));
            Command.Parameters.Add(new MDB.MDBParameter("HoHapCheck", BenhAnMatLac.HoHapCheck));
            Command.Parameters.Add(new MDB.MDBParameter("HoHap_Text", BenhAnMatLac.HoHap_Text));
            Command.Parameters.Add(new MDB.MDBParameter("TieuHoaCheck", BenhAnMatLac.TieuHoaCheck));
            Command.Parameters.Add(new MDB.MDBParameter("TieuHoa_Text", BenhAnMatLac.TieuHoa_Text));
            Command.Parameters.Add(new MDB.MDBParameter("CoXuongKhopCheck", BenhAnMatLac.CoXuongKhopCheck));
            Command.Parameters.Add(new MDB.MDBParameter("CoXuongKhop_Text", BenhAnMatLac.CoXuongKhop_Text));
            Command.Parameters.Add(new MDB.MDBParameter("TietNieuSinhDucCheck", BenhAnMatLac.TietNieuSinhDucCheck));
            Command.Parameters.Add(new MDB.MDBParameter("TietNieuSinhDuc_Text", BenhAnMatLac.TietNieuSinhDuc_Text));
            Command.Parameters.Add(new MDB.MDBParameter("KhamBenhToanThan_Khac", BenhAnMatLac.KhamBenhToanThan_Khac));
            int n = Command.ExecuteNonQuery(); // C#
            return n > 0 ? true : false;
        }
        public static bool Update(MDB.MDBConnection MyConnection, BenhAnMatLac BenhAnMatLac)
        {
            string sql = @"UPDATE BenhAnMatLac SET 
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
LyDoVaoVien_Lac = :LyDoVaoVien_Lac,
LyDoVaoVien_SupMi = :LyDoVaoVien_SupMi,
LyDoVaoVien_Khac = :LyDoVaoVien_Khac,
QuaTrinhBenhLy_NguyenNhan = :QuaTrinhBenhLy_NguyenNhan,
NguyenNhan_TuBaoGio = :NguyenNhan_TuBaoGio,
TrieuChungChinh = :TrieuChungChinh,
TrieuChung_SupMi = :TrieuChung_SupMi,
TrieuChung_RungGiatNhanCau = :TrieuChung_RungGiatNhanCau,
TrieuChung_Khac = :TrieuChung_Khac,
TrieuChung_Khac_Text = :TrieuChung_Khac_Text,
DaDieuTri_TapNhuocThi = :DaDieuTri_TapNhuocThi,
TapNhuocThi_PhuongPhap = :TapNhuocThi_PhuongPhap,
TapNhuocThi_KetQua = :TapNhuocThi_KetQua,
DaDieuTri_PhauThuat = :DaDieuTri_PhauThuat,
DaDieuTri_PhauThuat_PhuongPhap = :DaDieuTri_PhauThuat_PhuongPhap,
KetQua_PhauThuat_Tot = :KetQua_PhauThuat_Tot,
KetQua_PhauThuat_MoNon = :KetQua_PhauThuat_MoNon,
KetQua_PhauThuat_MoNon_Text = :KetQua_PhauThuat_MoNon_Text,
KetQua_PhauThuat_MoGia = :KetQua_PhauThuat_MoGia,
KetQua_PhauThuat_MoGiaText = :KetQua_PhauThuat_MoGiaText,
TienSuBenhBanThan_Tick = :TienSuBenhBanThan_Tick,
TienSuBenhGiaDinh_Tick = :TienSuBenhGiaDinh_Tick,
KhucXaMay_TruocAtropine_MP = :KhucXaMay_TruocAtropine_MP,
KhucXaMay_SauAtropine_MP = :KhucXaMay_SauAtropine_MP,
KhucXaMay_SauAtropine_MT = :KhucXaMay_SauAtropine_MT,
KhucXaMay_TruocAtropine_MT = :KhucXaMay_TruocAtropine_MT,
VanNhanNoiTai_MP = :VanNhanNoiTai_MP,
VanNhanNoiTai_Text_MP = :VanNhanNoiTai_Text_MP,
VanNhanNoiTai_MT = :VanNhanNoiTai_MT,
VanNhanNoiTai_TextMT = :VanNhanNoiTai_TextMT,
DiemCanQuyTu = :DiemCanQuyTu,
DiemCanQuyTu_Text = :DiemCanQuyTu_Text,
RungGiatNhanCau = :RungGiatNhanCau,
RungGiatNhanCau_Text = :RungGiatNhanCau_Text,
KieuRGNC = :KieuRGNC,
GocHam = :GocHam,
ThiNghiemCheMat = :ThiNghiemCheMat,
HinhThaiVaTinhChatLac = :HinhThaiVaTinhChatLac,
Hirschberg_Truoc_atropine = :Hirschberg_Truoc_atropine,
Hirschberg_Sau_atropine = :Hirschberg_Sau_atropine,
LangKinh_Truoc_atropine = :LangKinh_Truoc_atropine,
LangKinh_Sau_atropine = :LangKinh_Sau_atropine,
NhinGan = :NhinGan,
NhinLen = :NhinLen,
NhinXa = :NhinXa,
NhinXuong = :NhinXuong,
HoiChung = :HoiChung,
Synoptophore_KhacQuan = :Synoptophore_KhacQuan,
Synoptophore_ChuQuan = :Synoptophore_ChuQuan,
TinhTrangThiGiacHaiMat = :TinhTrangThiGiacHaiMat,
TinhTrangThiGiacHaiMat_Text = :TinhTrangThiGiacHaiMat_Text,
BienDoHopThi = :BienDoHopThi,
TuongUngVongMac = :TuongUngVongMac,
SongThi = :SongThi,
SongThi_Text = :SongThi_Text,
TuTheBuTru = :TuTheBuTru,
TuTheBuTru_Text = :TuTheBuTru_Text,
MiMat_MP = :MiMat_MP,
SupMi_MP = :SupMi_MP,
SupMi_MucDo_MP = :SupMi_MucDo_MP,
Epicanthus_MP = :Epicanthus_MP,
CoNangMi_MP = :CoNangMi_MP,
Marcusgunn_MP = :Marcusgunn_MP,
Bell_MP = :Bell_MP,
Khac_MiMat_MP = :Khac_MiMat_MP,
KetMac_MP = :KetMac_MP,
KetMac_Text_MP = :KetMac_Text_MP,
PhanNhanCauTruoc_MP = :PhanNhanCauTruoc_MP,
PhanNhanCauTruoc_Text_MP = :PhanNhanCauTruoc_Text_MP,
PhanNhanCauSau_MP = :PhanNhanCauSau_MP,
PhanNhanCauSau_Text_MP = :PhanNhanCauSau_Text_MP,
DinhThi_MP = :DinhThi_MP,
MiMat_MT = :MiMat_MT,
SupMi_MT = :SupMi_MT,
SupMi_MucDo_MT = :SupMi_MucDo_MT,
Epicanthus_MT = :Epicanthus_MT,
CoNangMi_MT = :CoNangMi_MT,
Marcusgunn_MT = :Marcusgunn_MT,
Bell_MT = :Bell_MT,
Khac_MiMat_MT = :Khac_MiMat_MT,
KetMac_MT = :KetMac_MT,
KetMac_Text_MT = :KetMac_Text_MT,
PhanNhanCauTruoc_MT = :PhanNhanCauTruoc_MT,
PhanNhanCauTruoc_Text_MT = :PhanNhanCauTruoc_Text_MT,
PhanNhanCauSau_MT = :PhanNhanCauSau_MT,
PhanNhanCauSau_Text_MT = :PhanNhanCauSau_Text_MT,
DinhThi_MT = :DinhThi_MT,
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
MaICD_BenhChinh = :MaICD_BenhChinh,
MaICD_BenhKemTheo = :MaICD_BenhKemTheo,
PhuongPhapChinh = :PhuongPhapChinh,
CheDoAnUong = :CheDoAnUong,
CheDoChamSoc = :CheDoChamSoc,
ChanDoanBenhChinh_LamSang = :ChanDoanBenhChinh_LamSang,
ChanDoanBenhChinh_NguyenNhan = :ChanDoanBenhChinh_NguyenNhan,
QuaTrinhDieuTri_NoiKhoa = :QuaTrinhDieuTri_NoiKhoa,
PhauThuat = :PhauThuat,
ThuThuat = :ThuThuat,
ThiLucRaVienKhongKinhMPTongKet = :ThiLucRaVienKhongKinhMPTongKet,
ThiLucRaVienKhongKinhMTTongKet = :ThiLucRaVienKhongKinhMTTongKet,
ThiLucRaVienCoKinhMPTongKet = :ThiLucRaVienCoKinhMPTongKet,
ThiLucRaVienCoKinhMTTongKet = :ThiLucRaVienCoKinhMTTongKet,
NhanApRaVienMPTongKet = :NhanApRaVienMPTongKet,
NhanApRaVienMTTongKet = :NhanApRaVienMTTongKet,
HuongDieuTriTiep = :HuongDieuTriTiep,
ThiLucKhiVaoVien_KhongKinh_MP = :ThiLucKhiVaoVien_KhongKinh_MP,
ThiLucKhiVaoVien_KhongKinh_MT = :ThiLucKhiVaoVien_KhongKinh_MT,
ThiLucKhiVaoVien_CoKinh_MP = :ThiLucKhiVaoVien_CoKinh_MP,
ThiLucKhiVaoVien_CoKinh_MT = :ThiLucKhiVaoVien_CoKinh_MT,
NhanApVaoVien_MT = :NhanApVaoVien_MT,
NhanApVaoVien_MP = :NhanApVaoVien_MP,
ThiTruong_MP = :ThiTruong_MP,
ThiTruong_MT = :ThiTruong_MT,
ChuaThayBenhLy = :ChuaThayBenhLy,
BenhLy = :BenhLy,
BenhLy_Text = :BenhLy_Text,
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
            Command.Parameters.Add(new MDB.MDBParameter("LyDoVaoVien", BenhAnMatLac.LyDoVaoVien));
            Command.Parameters.Add(new MDB.MDBParameter("VaoNgayThu", BenhAnMatLac.VaoNgayThu));
            Command.Parameters.Add(new MDB.MDBParameter("QuaTrinhBenhLy", BenhAnMatLac.QuaTrinhBenhLy));
            Command.Parameters.Add(new MDB.MDBParameter("TienSuBenhBanThan", BenhAnMatLac.TienSuBenhBanThan));
            Command.Parameters.Add(new MDB.MDBParameter("TienSuBenhGiaDinh", BenhAnMatLac.TienSuBenhGiaDinh));
            Command.Parameters.Add(new MDB.MDBParameter("ToanThan", BenhAnMatLac.ToanThan));
            Command.Parameters.Add(new MDB.MDBParameter("TuanHoan", BenhAnMatLac.TuanHoan));
            Command.Parameters.Add(new MDB.MDBParameter("HoHap", BenhAnMatLac.HoHap));
            Command.Parameters.Add(new MDB.MDBParameter("TieuHoa", BenhAnMatLac.TieuHoa));
            Command.Parameters.Add(new MDB.MDBParameter("ThanTietNieuSinhDuc", BenhAnMatLac.ThanTietNieuSinhDuc));
            Command.Parameters.Add(new MDB.MDBParameter("ThanKinh", BenhAnMatLac.ThanKinh));
            Command.Parameters.Add(new MDB.MDBParameter("CoXuongKhop", BenhAnMatLac.CoXuongKhop));
            Command.Parameters.Add(new MDB.MDBParameter("TaiMuiHong", BenhAnMatLac.TaiMuiHong));
            Command.Parameters.Add(new MDB.MDBParameter("RangHamMat", BenhAnMatLac.RangHamMat));
            Command.Parameters.Add(new MDB.MDBParameter("Mat", BenhAnMatLac.Mat));
            Command.Parameters.Add(new MDB.MDBParameter("Khac_CacCoQuan", BenhAnMatLac.Khac_CacCoQuan));
            Command.Parameters.Add(new MDB.MDBParameter("CacXetNghiemCanLamSangCanLam", BenhAnMatLac.CacXetNghiemCanLamSangCanLam));
            Command.Parameters.Add(new MDB.MDBParameter("TomTatBenhAn", BenhAnMatLac.TomTatBenhAn));
            Command.Parameters.Add(new MDB.MDBParameter("BenhChinh", BenhAnMatLac.BenhChinh));
            Command.Parameters.Add(new MDB.MDBParameter("BenhKemTheo", BenhAnMatLac.BenhKemTheo));
            Command.Parameters.Add(new MDB.MDBParameter("PhanBiet", BenhAnMatLac.PhanBiet));
            Command.Parameters.Add(new MDB.MDBParameter("TienLuong", BenhAnMatLac.TienLuong));
            Command.Parameters.Add(new MDB.MDBParameter("HuongDieuTri", BenhAnMatLac.HuongDieuTri));
            Command.Parameters.Add(new MDB.MDBParameter("NgayKhamBenh", BenhAnMatLac.NgayKhamBenh));
            Command.Parameters.Add(new MDB.MDBParameter("BacSyLamBenhAn", BenhAnMatLac.BacSyLamBenhAn));
            Command.Parameters.Add(new MDB.MDBParameter("QuaTrinhBenhLyVaDienBien", BenhAnMatLac.QuaTrinhBenhLyVaDienBien));
            Command.Parameters.Add(new MDB.MDBParameter("TomTatKetQuaXetNghiem", BenhAnMatLac.TomTatKetQuaXetNghiem));
            Command.Parameters.Add(new MDB.MDBParameter("PhuongPhapDieuTri", BenhAnMatLac.PhuongPhapDieuTri));
            Command.Parameters.Add(new MDB.MDBParameter("TinhTrangNguoiBenhRaVien", BenhAnMatLac.TinhTrangNguoiBenhRaVien));
            Command.Parameters.Add(new MDB.MDBParameter("HuongDieuTriVaCacCheDoTiepTheo", BenhAnMatLac.HuongDieuTriVaCacCheDoTiepTheo));
            Command.Parameters.Add(new MDB.MDBParameter("NguoiNhanHoSo", BenhAnMatLac.NguoiNhanHoSo));
            Command.Parameters.Add(new MDB.MDBParameter("NguoiGiaoHoSo", BenhAnMatLac.NguoiGiaoHoSo));
            Command.Parameters.Add(new MDB.MDBParameter("NgayTongKet", BenhAnMatLac.NgayTongKet));
            Command.Parameters.Add(new MDB.MDBParameter("BacSyDieuTri", BenhAnMatLac.BacSyDieuTri));
            Command.Parameters.Add(new MDB.MDBParameter("DiUng", BenhAnMatLac.DacDiemLienQuanBenh.DiUng == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("DiUng_Text", BenhAnMatLac.DacDiemLienQuanBenh.DiUng_Text));
            Command.Parameters.Add(new MDB.MDBParameter("MaTuy", BenhAnMatLac.DacDiemLienQuanBenh.MaTuy == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("MaTuy_Text", BenhAnMatLac.DacDiemLienQuanBenh.MaTuy_Text));
            Command.Parameters.Add(new MDB.MDBParameter("RuouBia", BenhAnMatLac.DacDiemLienQuanBenh.RuouBia == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("RuouBia_Text", BenhAnMatLac.DacDiemLienQuanBenh.RuouBia_Text));
            Command.Parameters.Add(new MDB.MDBParameter("ThuocLa", BenhAnMatLac.DacDiemLienQuanBenh.ThuocLa == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("ThuocLa_Text", BenhAnMatLac.DacDiemLienQuanBenh.ThuocLa_Text));
            Command.Parameters.Add(new MDB.MDBParameter("ThuocLao", BenhAnMatLac.DacDiemLienQuanBenh.ThuocLao == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("ThuocLao_Text", BenhAnMatLac.DacDiemLienQuanBenh.ThuocLao_Text));
            Command.Parameters.Add(new MDB.MDBParameter("Khac_DacDiemLienQuanBenh", BenhAnMatLac.DacDiemLienQuanBenh.Khac_DacDiemLienQuanBenh == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("Khac_DacDiemLienQuanBenh_Text", BenhAnMatLac.DacDiemLienQuanBenh.Khac_DacDiemLienQuanBenh_Text));
            Command.Parameters.Add(new MDB.MDBParameter("LyDoVaoVien_Lac", BenhAnMatLac.LyDoVaoVien_Lac == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("LyDoVaoVien_SupMi", BenhAnMatLac.LyDoVaoVien_SupMi == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("LyDoVaoVien_Khac", BenhAnMatLac.LyDoVaoVien_Khac == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("QuaTrinhBenhLy_NguyenNhan", BenhAnMatLac.QuaTrinhBenhLy_NguyenNhan == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("NguyenNhan_TuBaoGio", BenhAnMatLac.NguyenNhan_TuBaoGio));
            Command.Parameters.Add(new MDB.MDBParameter("TrieuChungChinh", BenhAnMatLac.TrieuChungChinh));
            Command.Parameters.Add(new MDB.MDBParameter("TrieuChung_SupMi", BenhAnMatLac.TrieuChung_SupMi == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("TrieuChung_RungGiatNhanCau", BenhAnMatLac.TrieuChung_RungGiatNhanCau == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("TrieuChung_Khac", BenhAnMatLac.TrieuChung_Khac == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("TrieuChung_Khac_Text", BenhAnMatLac.TrieuChung_Khac_Text));
            Command.Parameters.Add(new MDB.MDBParameter("DaDieuTri_TapNhuocThi", BenhAnMatLac.DaDieuTri_TapNhuocThi == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("TapNhuocThi_PhuongPhap", BenhAnMatLac.TapNhuocThi_PhuongPhap));
            Command.Parameters.Add(new MDB.MDBParameter("TapNhuocThi_KetQua", BenhAnMatLac.TapNhuocThi_KetQua));
            Command.Parameters.Add(new MDB.MDBParameter("DaDieuTri_PhauThuat", BenhAnMatLac.DaDieuTri_PhauThuat == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("DaDieuTri_PhauThuat_PhuongPhap", BenhAnMatLac.DaDieuTri_PhauThuat_PhuongPhap));
            Command.Parameters.Add(new MDB.MDBParameter("KetQua_PhauThuat_Tot", BenhAnMatLac.KetQua_PhauThuat_Tot == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("KetQua_PhauThuat_MoNon", BenhAnMatLac.KetQua_PhauThuat_MoNon == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("KetQua_PhauThuat_MoNon_Text", BenhAnMatLac.KetQua_PhauThuat_MoNon_Text));
            Command.Parameters.Add(new MDB.MDBParameter("KetQua_PhauThuat_MoGia", BenhAnMatLac.KetQua_PhauThuat_MoGia == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("KetQua_PhauThuat_MoGiaText", BenhAnMatLac.KetQua_PhauThuat_MoGiaText));
            Command.Parameters.Add(new MDB.MDBParameter("TienSuBenhBanThan_Tick", BenhAnMatLac.TienSuBenhBanThan_Tick == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("TienSuBenhGiaDinh_Tick", BenhAnMatLac.TienSuBenhGiaDinh_Tick == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("KhucXaMay_TruocAtropine_MP", BenhAnMatLac.KhucXaMay_TruocAtropine_MP));
            Command.Parameters.Add(new MDB.MDBParameter("KhucXaMay_SauAtropine_MP", BenhAnMatLac.KhucXaMay_SauAtropine_MP));
            Command.Parameters.Add(new MDB.MDBParameter("KhucXaMay_SauAtropine_MT", BenhAnMatLac.KhucXaMay_SauAtropine_MT));
            Command.Parameters.Add(new MDB.MDBParameter("KhucXaMay_TruocAtropine_MT", BenhAnMatLac.KhucXaMay_TruocAtropine_MT));
            Command.Parameters.Add(new MDB.MDBParameter("VanNhanNoiTai_MP", BenhAnMatLac.VanNhanNoiTai_MP == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("VanNhanNoiTai_Text_MP", BenhAnMatLac.VanNhanNoiTai_Text_MP));
            Command.Parameters.Add(new MDB.MDBParameter("VanNhanNoiTai_MT", BenhAnMatLac.VanNhanNoiTai_MT == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("VanNhanNoiTai_TextMT", BenhAnMatLac.VanNhanNoiTai_TextMT));
            Command.Parameters.Add(new MDB.MDBParameter("DiemCanQuyTu", BenhAnMatLac.DiemCanQuyTu == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("DiemCanQuyTu_Text", BenhAnMatLac.DiemCanQuyTu_Text));
            Command.Parameters.Add(new MDB.MDBParameter("RungGiatNhanCau", BenhAnMatLac.RungGiatNhanCau == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("RungGiatNhanCau_Text", BenhAnMatLac.RungGiatNhanCau_Text));
            Command.Parameters.Add(new MDB.MDBParameter("KieuRGNC", BenhAnMatLac.KieuRGNC));
            Command.Parameters.Add(new MDB.MDBParameter("GocHam", BenhAnMatLac.GocHam == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("ThiNghiemCheMat", BenhAnMatLac.ThiNghiemCheMat));
            Command.Parameters.Add(new MDB.MDBParameter("HinhThaiVaTinhChatLac", BenhAnMatLac.HinhThaiVaTinhChatLac));
            Command.Parameters.Add(new MDB.MDBParameter("Hirschberg_Truoc_atropine", BenhAnMatLac.Hirschberg_Truoc_atropine));
            Command.Parameters.Add(new MDB.MDBParameter("Hirschberg_Sau_atropine", BenhAnMatLac.Hirschberg_Sau_atropine));
            Command.Parameters.Add(new MDB.MDBParameter("LangKinh_Truoc_atropine", BenhAnMatLac.LangKinh_Truoc_atropine));
            Command.Parameters.Add(new MDB.MDBParameter("LangKinh_Sau_atropine", BenhAnMatLac.LangKinh_Sau_atropine));
            Command.Parameters.Add(new MDB.MDBParameter("NhinGan", BenhAnMatLac.NhinGan));
            Command.Parameters.Add(new MDB.MDBParameter("NhinLen", BenhAnMatLac.NhinLen));
            Command.Parameters.Add(new MDB.MDBParameter("NhinXa", BenhAnMatLac.NhinXa));
            Command.Parameters.Add(new MDB.MDBParameter("NhinXuong", BenhAnMatLac.NhinXuong));
            Command.Parameters.Add(new MDB.MDBParameter("HoiChung", BenhAnMatLac.HoiChung));
            Command.Parameters.Add(new MDB.MDBParameter("Synoptophore_KhacQuan", BenhAnMatLac.Synoptophore_KhacQuan));
            Command.Parameters.Add(new MDB.MDBParameter("Synoptophore_ChuQuan", BenhAnMatLac.Synoptophore_ChuQuan));
            Command.Parameters.Add(new MDB.MDBParameter("TinhTrangThiGiacHaiMat", BenhAnMatLac.TinhTrangThiGiacHaiMat));
            Command.Parameters.Add(new MDB.MDBParameter("TinhTrangThiGiacHaiMat_Text", BenhAnMatLac.TinhTrangThiGiacHaiMat_Text));
            Command.Parameters.Add(new MDB.MDBParameter("BienDoHopThi", BenhAnMatLac.BienDoHopThi));
            Command.Parameters.Add(new MDB.MDBParameter("TuongUngVongMac", BenhAnMatLac.TuongUngVongMac == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("SongThi", BenhAnMatLac.SongThi == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("SongThi_Text", BenhAnMatLac.SongThi_Text));
            Command.Parameters.Add(new MDB.MDBParameter("TuTheBuTru", BenhAnMatLac.TuTheBuTru == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("TuTheBuTru_Text", BenhAnMatLac.TuTheBuTru_Text));
            Command.Parameters.Add(new MDB.MDBParameter("MiMat_MP", BenhAnMatLac.MiMat_MP == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("SupMi_MP", BenhAnMatLac.SupMi_MP == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("SupMi_MucDo_MP", BenhAnMatLac.SupMi_MucDo_MP));
            Command.Parameters.Add(new MDB.MDBParameter("Epicanthus_MP", BenhAnMatLac.Epicanthus_MP == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("CoNangMi_MP", BenhAnMatLac.CoNangMi_MP));
            Command.Parameters.Add(new MDB.MDBParameter("Marcusgunn_MP", BenhAnMatLac.Marcusgunn_MP == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("Bell_MP", BenhAnMatLac.Bell_MP == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("Khac_MiMat_MP", BenhAnMatLac.Khac_MiMat_MP));
            Command.Parameters.Add(new MDB.MDBParameter("KetMac_MP", BenhAnMatLac.KetMac_MP == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("KetMac_Text_MP", BenhAnMatLac.KetMac_Text_MP));
            Command.Parameters.Add(new MDB.MDBParameter("PhanNhanCauTruoc_MP", BenhAnMatLac.PhanNhanCauTruoc_MP == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("PhanNhanCauTruoc_Text_MP", BenhAnMatLac.PhanNhanCauTruoc_Text_MP));
            Command.Parameters.Add(new MDB.MDBParameter("PhanNhanCauSau_MP", BenhAnMatLac.PhanNhanCauSau_MP == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("PhanNhanCauSau_Text_MP", BenhAnMatLac.PhanNhanCauSau_Text_MP));
            Command.Parameters.Add(new MDB.MDBParameter("DinhThi_MP", BenhAnMatLac.DinhThi_MP));
            Command.Parameters.Add(new MDB.MDBParameter("MiMat_MT", BenhAnMatLac.MiMat_MT == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("SupMi_MT", BenhAnMatLac.SupMi_MT == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("SupMi_MucDo_MT", BenhAnMatLac.SupMi_MucDo_MT));
            Command.Parameters.Add(new MDB.MDBParameter("Epicanthus_MT", BenhAnMatLac.Epicanthus_MT == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("CoNangMi_MT", BenhAnMatLac.CoNangMi_MT));
            Command.Parameters.Add(new MDB.MDBParameter("Marcusgunn_MT", BenhAnMatLac.Marcusgunn_MT == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("Bell_MT", BenhAnMatLac.Bell_MT == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("Khac_MiMat_MT", BenhAnMatLac.Khac_MiMat_MT));
            Command.Parameters.Add(new MDB.MDBParameter("KetMac_MT", BenhAnMatLac.KetMac_MT == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("KetMac_Text_MT", BenhAnMatLac.KetMac_Text_MT));
            Command.Parameters.Add(new MDB.MDBParameter("PhanNhanCauTruoc_MT", BenhAnMatLac.PhanNhanCauTruoc_MT == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("PhanNhanCauTruoc_Text_MT", BenhAnMatLac.PhanNhanCauTruoc_Text_MT));
            Command.Parameters.Add(new MDB.MDBParameter("PhanNhanCauSau_MT", BenhAnMatLac.PhanNhanCauSau_MT == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("PhanNhanCauSau_Text_MT", BenhAnMatLac.PhanNhanCauSau_Text_MT));
            Command.Parameters.Add(new MDB.MDBParameter("DinhThi_MT", BenhAnMatLac.DinhThi_MT));
            Command.Parameters.Add(new MDB.MDBParameter("HuyetAp_ToanThan", BenhAnMatLac.HuyetAp_ToanThan));
            Command.Parameters.Add(new MDB.MDBParameter("NhietDo_ToanThan", BenhAnMatLac.NhietDo_ToanThan));
            Command.Parameters.Add(new MDB.MDBParameter("Mach_ToanThan", BenhAnMatLac.Mach_ToanThan));
            Command.Parameters.Add(new MDB.MDBParameter("NoiTiet_Tick", BenhAnMatLac.NoiTiet_Tick == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("NoiTiet", BenhAnMatLac.NoiTiet));
            Command.Parameters.Add(new MDB.MDBParameter("ThanKinh_Tick", BenhAnMatLac.ThanKinh_Tick == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("TuanHoan_Tick", BenhAnMatLac.TuanHoan_Tick == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("HoHap_Tick", BenhAnMatLac.HoHap_Tick == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("TieuHoa_Tick", BenhAnMatLac.TieuHoa_Tick == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("CoXuongKhop_Tick", BenhAnMatLac.CoXuongKhop_Tick == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("ThanTietNieu_Tick", BenhAnMatLac.ThanTietNieu_Tick == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("MaICD_BenhChinh", BenhAnMatLac.MaICD_BenhChinh));
            Command.Parameters.Add(new MDB.MDBParameter("MaICD_BenhKemTheo", BenhAnMatLac.MaICD_BenhKemTheo));
            Command.Parameters.Add(new MDB.MDBParameter("PhuongPhapChinh", BenhAnMatLac.PhuongPhapChinh));
            Command.Parameters.Add(new MDB.MDBParameter("CheDoAnUong", BenhAnMatLac.CheDoAnUong));
            Command.Parameters.Add(new MDB.MDBParameter("CheDoChamSoc", BenhAnMatLac.CheDoChamSoc));
            Command.Parameters.Add(new MDB.MDBParameter("ChanDoanBenhChinh_LamSang", BenhAnMatLac.ChanDoanBenhChinh_LamSang));
            Command.Parameters.Add(new MDB.MDBParameter("ChanDoanBenhChinh_NguyenNhan", BenhAnMatLac.ChanDoanBenhChinh_NguyenNhan));
            Command.Parameters.Add(new MDB.MDBParameter("QuaTrinhDieuTri_NoiKhoa", BenhAnMatLac.QuaTrinhDieuTri_NoiKhoa));
            Command.Parameters.Add(new MDB.MDBParameter("PhauThuat", BenhAnMatLac.PhauThuat == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("ThuThuat", BenhAnMatLac.ThuThuat == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("ThiLucRaVienKhongKinhMPTongKet", BenhAnMatLac.ThiLucRaVienKhongKinhMPTongKet));
            Command.Parameters.Add(new MDB.MDBParameter("ThiLucRaVienKhongKinhMTTongKet", BenhAnMatLac.ThiLucRaVienKhongKinhMTTongKet));
            Command.Parameters.Add(new MDB.MDBParameter("ThiLucRaVienCoKinhMPTongKet", BenhAnMatLac.ThiLucRaVienCoKinhMPTongKet));
            Command.Parameters.Add(new MDB.MDBParameter("ThiLucRaVienCoKinhMTTongKet", BenhAnMatLac.ThiLucRaVienCoKinhMTTongKet));
            Command.Parameters.Add(new MDB.MDBParameter("NhanApRaVienMPTongKet", BenhAnMatLac.NhanApRaVienMPTongKet));
            Command.Parameters.Add(new MDB.MDBParameter("NhanApRaVienMTTongKet", BenhAnMatLac.NhanApRaVienMTTongKet));
            Command.Parameters.Add(new MDB.MDBParameter("HuongDieuTriTiep", BenhAnMatLac.HuongDieuTriTiep));
            Command.Parameters.Add(new MDB.MDBParameter("ThiLucKhiVaoVien_KhongKinh_MP", BenhAnMatLac.ThiLucKhiVaoVien_KhongKinh_MP));
            Command.Parameters.Add(new MDB.MDBParameter("ThiLucKhiVaoVien_KhongKinh_MT", BenhAnMatLac.ThiLucKhiVaoVien_KhongKinh_MT));
            Command.Parameters.Add(new MDB.MDBParameter("ThiLucKhiVaoVien_CoKinh_MP", BenhAnMatLac.ThiLucKhiVaoVien_CoKinh_MP));
            Command.Parameters.Add(new MDB.MDBParameter("ThiLucKhiVaoVien_CoKinh_MT", BenhAnMatLac.ThiLucKhiVaoVien_CoKinh_MT));
            Command.Parameters.Add(new MDB.MDBParameter("NhanApVaoVien_MT", BenhAnMatLac.NhanApVaoVien_MT));
            Command.Parameters.Add(new MDB.MDBParameter("NhanApVaoVien_MP", BenhAnMatLac.NhanApVaoVien_MP));
            Command.Parameters.Add(new MDB.MDBParameter("ThiTruong_MP", BenhAnMatLac.ThiTruong_MP));
            Command.Parameters.Add(new MDB.MDBParameter("ThiTruong_MT", BenhAnMatLac.ThiTruong_MT));
            Command.Parameters.Add(new MDB.MDBParameter("ChuaThayBenhLy", BenhAnMatLac.ChuaThayBenhLy ? "1":"0"));
            Command.Parameters.Add(new MDB.MDBParameter("BenhLy", BenhAnMatLac.BenhLy ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("BenhLy_Text", BenhAnMatLac.BenhLy_Text));
            Command.Parameters.Add(new MDB.MDBParameter("NoiTietCheck", BenhAnMatLac.NoiTietCheck));
            Command.Parameters.Add(new MDB.MDBParameter("NoiTiet_Text", BenhAnMatLac.NoiTiet_Text));
            Command.Parameters.Add(new MDB.MDBParameter("ThanKinhCheck", BenhAnMatLac.ThanKinhCheck));
            Command.Parameters.Add(new MDB.MDBParameter("ThanKinh_Text", BenhAnMatLac.ThanKinh_Text));
            Command.Parameters.Add(new MDB.MDBParameter("TuanHoanCheck", BenhAnMatLac.TuanHoanCheck));
            Command.Parameters.Add(new MDB.MDBParameter("TuanHoan_Text", BenhAnMatLac.TuanHoan_Text));
            Command.Parameters.Add(new MDB.MDBParameter("HoHapCheck", BenhAnMatLac.HoHapCheck));
            Command.Parameters.Add(new MDB.MDBParameter("HoHap_Text", BenhAnMatLac.HoHap_Text));
            Command.Parameters.Add(new MDB.MDBParameter("TieuHoaCheck", BenhAnMatLac.TieuHoaCheck));
            Command.Parameters.Add(new MDB.MDBParameter("TieuHoa_Text", BenhAnMatLac.TieuHoa_Text));
            Command.Parameters.Add(new MDB.MDBParameter("CoXuongKhopCheck", BenhAnMatLac.CoXuongKhopCheck));
            Command.Parameters.Add(new MDB.MDBParameter("CoXuongKhop_Text", BenhAnMatLac.CoXuongKhop_Text));
            Command.Parameters.Add(new MDB.MDBParameter("TietNieuSinhDucCheck", BenhAnMatLac.TietNieuSinhDucCheck));
            Command.Parameters.Add(new MDB.MDBParameter("TietNieuSinhDuc_Text", BenhAnMatLac.TietNieuSinhDuc_Text));
            Command.Parameters.Add(new MDB.MDBParameter("KhamBenhToanThan_Khac", BenhAnMatLac.KhamBenhToanThan_Khac));
            Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", BenhAnMatLac.MaQuanLy));
            int n = Command.ExecuteNonQuery(); // C#
            return n > 0 ? true : false;
        }
        public static bool Delete(MDB.MDBConnection MyConnection, BenhAnMatLac BenhAnMatLac)
        {
            string sql = @"DELETE FROM BenhAnMatLac 
                           WHERE MaQuanLy = :MaQuanLy";
            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
            Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", BenhAnMatLac.MaQuanLy));

            int n = Command.ExecuteNonQuery(); // C#
            return n > 0 ? true : false;
        }
    }
}
