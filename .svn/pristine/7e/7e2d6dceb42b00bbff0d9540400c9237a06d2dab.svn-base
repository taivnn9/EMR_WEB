using System.Data;

namespace EMR_MAIN
{
    public class BenhAnNoiTruYHCTFunc
    {
        public static void WriteXml(MDB.MDBConnection MyConnection)
        {
            string sql =
                   @"
                  select  a.*,  CTScanner HoSo_CTScanner, SieuAm HoSo_SieuAm, XetNghiem HoSo_XetNghiem,  Khac HoSo_Khac,  Khac_Text HoSo_Khac_Text,  ToanBoHoSo HoSo_ToanBoHoSo, Mach DauSinhTon_Mach,  NhietDo DauSinhTon_NhietDo,  HuyetAp DauSinhTon_HuyetAp,  NhipTho DauSinhTon_NhipTho,  CanNang DauSinhTon_CanNang ,  ChieuCao DauSinhTon_ChieuCao, BMI  DauSinhTon_BMI
                  from BenhAnNoiTruYHCT a inner join thongtindieutri b on a.maquanly = b.maquanly
                  where rownum = 1
                    ";
            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
            MDB.MDBDataReader DataReader = Command.ExecuteReader();

            var DataTable = new DataTable { TableName = "BenhAnNoiTruYHCT" };
            DataTable.Load(DataReader as IDataReader);
            DataTable.WriteXml("rptBenhAnNoiTruYHCT.xml");
        }
        public static DataSet SelectDataSet(MDB.MDBConnection MyConnection, decimal MaQuanLy)
        {
            string sql =
                   @"
                 select  a.*,f.hovaten BacSyLamBenhAnHoVaTen ,c.hovaten BacSyDieuTriHoVaTen,d.hovaten NguoiGiaoHoSoHoVaTen,e.hovaten NguoiNhanHoSoHoVaTen, b.XQuang HoSo_XQuang,   b.CTScanner HoSo_CTScanner, b.SieuAm HoSo_SieuAm, b.XetNghiem HoSo_XetNghiem,  b.Khac HoSo_Khac,  b.Khac_Text HoSo_Khac_Text,  b.ToanBoHoSo HoSo_ToanBoHoSo, b.Mach DauSinhTon_Mach, b.NhietDo DauSinhTon_NhietDo,  b.HuyetAp DauSinhTon_HuyetAp,  b.NhipTho DauSinhTon_NhipTho,  b.CanNang DauSinhTon_CanNang  , b.ChieuCao DauSinhTon_ChieuCao, b.BMI DauSinhTon_BMI, b.NgayRaVien 
                 from BenhAnNoiTruYHCT a 
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
        public static BenhAnNoiTruYHCT Select(MDB.MDBConnection MyConnection, decimal MaQuanLy)
        {
            #region
            string sql =
                      @"select * 
                        from BenhAnNoiTruYHCT a
                        where MaQuanLy = :MaQuanLy";
            #endregion
            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
            Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", MaQuanLy));
            MDB.MDBDataReader DataReader = Command.ExecuteReader();
            var value = new BenhAnNoiTruYHCT();
            value.DacDiemLienQuanBenh = new DacDiemLienQuanBenh();
            while (DataReader.Read())
            {
                value.MaQuanLy = DataReader.GetDecimal("MaQuanLy");
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
                value.BenhSu = DataReader["BenhSu"].ToString();
                value.MoTaChiTietCoQuanBenhLy = DataReader["MoTaChiTietCoQuanBenhLy"].ToString();
                value.HinhThai_Gay = DataReader["HinhThai_Gay"].ToString() == "1" ? true : false;
                // Add
                value.Bung_Dau = DataReader["Bung_Dau"].ToString() == "1" ? true : false;
                value.ChanTay_Dau = DataReader["ChanTay_Dau"].ToString() == "1" ? true : false;
                value.ChanTay_Te = DataReader["ChanTay_Te"].ToString() == "1" ? true : false;
                value.ChanTay_Buon = DataReader["ChanTay_Buon"].ToString() == "1" ? true : false;
                value.ChanTay_Moi = DataReader["ChanTay_Moi"].ToString() == "1" ? true : false;
                value.ChanTay_Nhuc = DataReader["ChanTay_Nhuc"].ToString() == "1" ? true : false;
                value.ChanTay_Nong = DataReader["ChanTay_Nong"].ToString() == "1" ? true : false;
                value.ChanTay_Lanh = DataReader["ChanTay_Lanh"].ToString() == "1" ? true : false;
                value.ChanTay_Khac = DataReader["ChanTay_Khac"].ToString() == "1" ? true : false;
                value.Nam_Khac = DataReader["Nam_Khac"].ToString() == "1" ? true : false;
                value.Nu_DongThai = DataReader["Nu_DongThai"].ToString() == "1" ? true : false;
                value.Nu_SayThai = DataReader["Nu_SayThai"].ToString() == "1" ? true : false;
                value.MacChan_Nhu = DataReader["MacChan_Nhu"].ToString() == "1" ? true : false;
                value.DinhViBenhTheo_Ve = DataReader["DinhViBenhTheo_Ve"].ToString() == "1" ? true : false;
                value.DinhViBenhTheo_Khi = DataReader["DinhViBenhTheo_Khi"].ToString() == "1" ? true : false;
                value.DinhViBenhTheo_Dinh = DataReader["DinhViBenhTheo_Dinh"].ToString() == "1" ? true : false;
                value.DinhViBenhTheo_Huyet = DataReader["DinhViBenhTheo_Huyet"].ToString() == "1" ? true : false;
                value.NguyenNhan_NoiNhan = DataReader["NguyenNhan_NoiNhan"].ToString() == "1" ? true : false;
                value.NguyenNhan_NgoaiNhan = DataReader["NguyenNhan_NgoaiNhan"].ToString() == "1" ? true : false;
                value.NguyenNhan_BatNoiNgoai = DataReader["NguyenNhan_BatNoiNgoai"].ToString() == "1" ? true : false;
                value.TangPhu_Tam = DataReader["TangPhu_Tam"].ToString() == "1" ? true : false;
                value.TangPhu_Lan = DataReader["TangPhu_Lan"].ToString() == "1" ? true : false;
                value.TangPhu_Ty = DataReader["TangPhu_Ty"].ToString() == "1" ? true : false;
                value.TangPhu_Phe = DataReader["TangPhu_Phe"].ToString() == "1" ? true : false;
                value.TangPhu_Than = DataReader["TangPhu_Than"].ToString() == "1" ? true : false;
                value.TangPhu_TamBao = DataReader["TangPhu_TamBao"].ToString() == "1" ? true : false;
                value.TangPhu_TieuTruong = DataReader["TangPhu_TieuTruong"].ToString() == "1" ? true : false;
                value.TangPhu_Dom = DataReader["TangPhu_Dom"].ToString() == "1" ? true : false;
                value.TangPhu_Vi = DataReader["TangPhu_Vi"].ToString() == "1" ? true : false;
                value.TangPhu_DaiTruong = DataReader["TangPhu_DaiTruong"].ToString() == "1" ? true : false;
                value.TangPhu_BangQuang = DataReader["TangPhu_BangQuang"].ToString() == "1" ? true : false;
                value.TangPhu_TamTieu = DataReader["TangPhu_TamTieu"].ToString() == "1" ? true : false;
                value.TangPhu_PhuKyHang = DataReader["TangPhu_PhuKyHang"].ToString() == "1" ? true : false;
                value.KinhMach_Tam = DataReader["KinhMach_Tam"].ToString() == "1" ? true : false;
                value.DauDau_DauThat = DataReader["DauDau_DauThat"].ToString() == "1" ? true : false;
                value.DauDau_Khac = DataReader["DauDau_Khac"].ToString() == "1" ? true : false;
                value.Mat_Dau = DataReader["Mat_Dau"].ToString() == "1" ? true : false;
                value.Mat_Khac = DataReader["Mat_Khac"].ToString() == "1" ? true : false;
                value.Mui_Khac = DataReader["Mui_Khac"].ToString() == "1" ? true : false;
                value.Hong_Khac = DataReader["Hong_Khac"].ToString() == "1" ? true : false;
                value.KinhMach_Lan = DataReader["KinhMach_Lan"].ToString() == "1" ? true : false;
                value.KinhMach_Ty = DataReader["KinhMach_Ty"].ToString() == "1" ? true : false;
                value.KinhMach_Phe = DataReader["KinhMach_Phe"].ToString() == "1" ? true : false;
                value.KinhMach_Than = DataReader["KinhMach_Than"].ToString() == "1" ? true : false;
                value.KinhMach_TamBao = DataReader["KinhMach_TamBao"].ToString() == "1" ? true : false;
                value.KinhMach_TieuTruong = DataReader["KinhMach_TieuTruong"].ToString() == "1" ? true : false;
                value.KinhMach_Dom = DataReader["KinhMach_Dom"].ToString() == "1" ? true : false;
                value.KinhMach_Vi = DataReader["KinhMach_Vi"].ToString() == "1" ? true : false;
                value.KinhMach_DaiTruong = DataReader["KinhMach_DaiTruong"].ToString() == "1" ? true : false;
                value.KinhMach_BangQuang = DataReader["KinhMach_BangQuang"].ToString() == "1" ? true : false;
                value.KinhMach_TamTieu = DataReader["KinhMach_TamTieu"].ToString() == "1" ? true : false;
                value.KinhMach_MachDoc = DataReader["KinhMach_MachDoc"].ToString() == "1" ? true : false;
                value.KinhMach_MachNham = DataReader["KinhMach_MachNham"].ToString() == "1" ? true : false;
                value.BatCuong_Bieu = DataReader["BatCuong_Bieu"].ToString() == "1" ? true : false;
                value.BatCuong_Ly = DataReader["BatCuong_Ly"].ToString() == "1" ? true : false;
                value.BatCuong_Hu = DataReader["BatCuong_Hu"].ToString() == "1" ? true : false;
                value.BatCuong_Thuc = DataReader["BatCuong_Thuc"].ToString() == "1" ? true : false;
                value.BatCuong_Han = DataReader["BatCuong_Han"].ToString() == "1" ? true : false;
                value.BatCuong_Nhiet = DataReader["BatCuong_Nhiet"].ToString() == "1" ? true : false;
                value.BatCuong_Am = DataReader["BatCuong_Am"].ToString() == "1" ? true : false;
                value.BatCuong_Duong = DataReader["BatCuong_Duong"].ToString() == "1" ? true : false;

                value.Bung= DataReader["Bung"].ToString() == "1" ? true : false;
                value.DoiHa= DataReader["DoiHa"].ToString() == "1" ? true : false;
                value.CoXuongKhop_BinhThuong= DataReader["CoXuongKhop_BinhThuong"].ToString() == "1" ? true : false;
                value.Bung_BinhThuong= DataReader["Bung_BinhThuong"].ToString() == "1" ? true : false;

                value.PPKhongDungThuoc = DataReader["PPKhongDungThuoc"].ToString();
                value.PPKhac = DataReader["PPKhac"].ToString();
                value.MotaTienSuBanThan = DataReader["MotaTienSuBanThan"].ToString();
                value.ChanDoanVVYHCT_BenhChinh = DataReader["ChanDoanVVYHCT_BenhChinh"].ToString();
                value.ChanDoanVVYHCT_KemTheo = DataReader["ChanDoanVVYHCT_KemTheo"].ToString();
                value.MaICDChanDoanVVYHCT_BenhChinh = DataReader["MaICDChanDoanVVYHCT_BenhChinh"].ToString();
                value.MaICDChanDoanVVYHCT_KemTheo = DataReader["MaICDChanDoanVVYHCT_KemTheo"].ToString();
                value.ChanDoanVVYHHD_BenhChinh = DataReader["ChanDoanVVYHHD_BenhChinh"].ToString();
                value.ChanDoanVVYHD_KemTheo = DataReader["ChanDoanVVYHD_KemTheo"].ToString();
                value.MaICDVVYHD_BenhChinh = DataReader["MaICDVVYHD_BenhChinh"].ToString();
                value.MaICDChanDoanVVYHD_KemTheo = DataReader["MaICDChanDoanVVYHD_KemTheo"].ToString();
                value.ChanDoanRVYHCT_BenhChinh = DataReader["ChanDoanRVYHCT_BenhChinh"].ToString();
                value.ChanDoanRVYHCT_KemTheo = DataReader["ChanDoanRVYHCT_KemTheo"].ToString();
                value.MaICDChanDoanRVYHCT_BenhChinh = DataReader["MaICDChanDoanRVYHCT_BenhChinh"].ToString();
                value.MaICDChanDoanRVYHCT_KemTheo = DataReader["MaICDChanDoanRVYHCT_KemTheo"].ToString();
                value.ChanDoanRVYHHD_BenhChinh = DataReader["ChanDoanRVYHHD_BenhChinh"].ToString();
                value.ChanDoanRVYHD_KemTheo = DataReader["ChanDoanRVYHD_KemTheo"].ToString();
                value.MaICDRVYHD_BenhChinh = DataReader["MaICDRVYHD_BenhChinh"].ToString();
                value.MaICDChanDoanRVYHD_KemTheo = DataReader["MaICDChanDoanRVYHD_KemTheo"].ToString();

                value.ChanDoan_NoiChuyenDen_YHCT = DataReader["ChanDoan_NoiChuyenDen_YHCT"].ToString();
                value.MaICD_NoiChuyenDen_YHCT = DataReader["MaICD_NoiChuyenDen_YHCT"].ToString();
                value.ChanDoan_KKB_CapCuu_YHCT = DataReader["ChanDoan_KKB_CapCuu_YHCT"].ToString();
                value.MaICD_KKB_CapCuu_YHCT = DataReader["MaICD_KKB_CapCuu_YHCT"].ToString();
                value.HOSOKQ_XQUANG = DataReader["HOSOKQ_XQUANG"].ToString();
                value.HOSOKQ_CTSCANNER = DataReader["HOSOKQ_CTSCANNER"].ToString();
                value.HOSOKQ_MRI = DataReader["HOSOKQ_MRI"].ToString();
                value.HOSOKQ_KHAC_TXT = DataReader["HOSOKQ_KHAC_TXT"].ToString();
                value.HOSOKQ_KHAC = DataReader["HOSOKQ_KHAC"].ToString();
                value.HOSOKQ_TOANBOHOSO = DataReader["HOSOKQ_TOANBOHOSO"].ToString();
                value.BenhChinh_YHCT = DataReader["BenhChinh_YHCT"].ToString();
                value.MaICD_BenhChinh_YHCT = DataReader["MaICD_BenhChinh_YHCT"].ToString();
                value.BenhKemTheo_YHCT = DataReader["BenhKemTheo_YHCT"].ToString();
                value.MaICD_BenhKemTheo_YHCT = DataReader["MaICD_BenhKemTheo_YHCT"].ToString();
                value.ThuThuat_YHCT = DataReader["ThuThuat_YHCT"].ToString() == "1" ? true : false;
                value.PhauThuat_YHCT = DataReader["PhauThuat_YHCT"].ToString() == "1" ? true : false;
                value.BenhChinh_RV_YHCT = DataReader["BenhChinh_RV_YHCT"].ToString();
                value.MaICD_BenhChinh_RV_YHCT = DataReader["MaICD_BenhChinh_RV_YHCT"].ToString();
                value.BenhKemTheo_RV_YHCT = DataReader["BenhKemTheo_RV_YHCT"].ToString();
                value.MaICD_BenhKemTheo_RV_YHCT = DataReader["MaICD_BenhKemTheo_RV_YHCT"].ToString();
                value.TaiBien_YHCT = DataReader["TaiBien_YHCT"].ToString() == "1" ? true : false;
                value.BienChung_YHCT = DataReader["BienChung_YHCT"].ToString() == "1" ? true : false;
                value.MaICD_BenhKemTheo_YHHD = DataReader["MaICD_BenhKemTheo_YHHD"].ToString();
                value.MaICD_BenhChinh_YHHD_CD = DataReader["MaICD_BenhChinh_YHHD_CD"].ToString();
                value.MaICD_BenhKemTheo_YHHD_CD = DataReader["MaICD_BenhKemTheo_YHHD_CD"].ToString();
                value.CheDoDinhDuong_Long = DataReader["CheDoDinhDuong_Long"].ToString() == "1" ? true : false;
                value.CheDoDinhDuong_Dac = DataReader["CheDoDinhDuong_Dac"].ToString() == "1" ? true : false;
                value.CheDoDinhDuong_Kieng = DataReader["CheDoDinhDuong_Kieng"].ToString() == "1" ? true : false;
                value.CheDoDinhDuong_Khac = DataReader["CheDoDinhDuong_Khac"].ToString() == "1" ? true : false;
                value.CheDoChamSoc_1 = DataReader["CheDoChamSoc_1"].ToString() == "1" ? true : false;
                value.CheDoChamSoc_2 = DataReader["CheDoChamSoc_2"].ToString() == "1" ? true : false;
                value.CheDoChamSoc_3 = DataReader["CheDoChamSoc_3"].ToString() == "1" ? true : false;

                //
                value.HinhThai_Beo = DataReader["HinhThai_Beo"].ToString() == "1" ? true : false;
                value.HinhThai_CanDoi = DataReader["HinhThai_CanDoi"].ToString() == "1" ? true : false;
                value.HinhThai_NamCo = DataReader["HinhThai_NamCo"].ToString() == "1" ? true : false;
                value.HinhThai_UaTinh = DataReader["HinhThai_UaTinh"].ToString() == "1" ? true : false;
                value.HinhThai_NamDuoi = DataReader["HinhThai_NamDuoi"].ToString() == "1" ? true : false;
                value.HinhThai_HieuDong = DataReader["HinhThai_HieuDong"].ToString() == "1" ? true : false;
                value.HinhThai_Khac = DataReader["HinhThai_Khac"].ToString() == "1" ? true : false;
                value.Than_ConThan = DataReader["Than_ConThan"].ToString() == "1" ? true : false;
                value.Than_KhongConThan = DataReader["Than_KhongConThan"].ToString() == "1" ? true : false;
                value.Than_Khac = DataReader["Than_Khac"].ToString() == "1" ? true : false;
                value.Sac_BechTrang = DataReader["Sac_BechTrang"].ToString() == "1" ? true : false;
                value.Sac_Do = DataReader["Sac_Do"].ToString() == "1" ? true : false;
                value.Sac_Vang = DataReader["Sac_Vang"].ToString() == "1" ? true : false;
                value.Sac_Xanh = DataReader["Sac_Xanh"].ToString() == "1" ? true : false;
                value.Sac_Den = DataReader["Sac_Den"].ToString() == "1" ? true : false;
                value.Sac_Khac = DataReader["Sac_Khac"].ToString() == "1" ? true : false;
                value.Sac_BinhThuong = DataReader["Sac_BinhThuong"].ToString() == "1" ? true : false;
                value.Trach_TuoiNhuan = DataReader["Trach_TuoiNhuan"].ToString() == "1" ? true : false;
                value.Trach_Kho = DataReader["Trach_Kho"].ToString() == "1" ? true : false;
                value.Trach_Khac = DataReader["Trach_Khac"].ToString() == "1" ? true : false;
                value.ChatLuoi_BinhThuong = DataReader["ChatLuoi_BinhThuong"].ToString() == "1" ? true : false;
                value.ChatLuoi_Beu = DataReader["ChatLuoi_Beu"].ToString() == "1" ? true : false;
                value.ChatLuoi_GayMong = DataReader["ChatLuoi_GayMong"].ToString() == "1" ? true : false;
                value.ChatLuoi_Nut = DataReader["ChatLuoi_Nut"].ToString() == "1" ? true : false;
                value.ChatLuoi_Cung = DataReader["ChatLuoi_Cung"].ToString() == "1" ? true : false;
                value.ChatLuoi_Loet = DataReader["ChatLuoi_Loet"].ToString() == "1" ? true : false;
                value.ChatLuoi_Lech = DataReader["ChatLuoi_Lech"].ToString() == "1" ? true : false;
                value.ChatLuoi_Rut = DataReader["ChatLuoi_Rut"].ToString() == "1" ? true : false;
                value.ChatLuoi_Khac = DataReader["ChatLuoi_Khac"].ToString() == "1" ? true : false;
                value.SacLuoi_Hong = DataReader["SacLuoi_Hong"].ToString() == "1" ? true : false;
                value.SacLuoi_Nhot = DataReader["SacLuoi_Nhot"].ToString() == "1" ? true : false;
                value.SacLuoi_Do = DataReader["SacLuoi_Do"].ToString() == "1" ? true : false;
                value.SacLuoi_DoSam = DataReader["SacLuoi_DoSam"].ToString() == "1" ? true : false;
                value.SacLuoi_XanhTim = DataReader["SacLuoi_XanhTim"].ToString() == "1" ? true : false;
                value.SacLuoi_DamUHuyet = DataReader["SacLuoi_DamUHuyet"].ToString() == "1" ? true : false;
                value.SacLuoi_Kho = DataReader["SacLuoi_Kho"].ToString() == "1" ? true : false;
                value.SacLuoi_Nhuan = DataReader["SacLuoi_Nhuan"].ToString() == "1" ? true : false;
                value.SacLuoi_Khac = DataReader["SacLuoi_Khac"].ToString() == "1" ? true : false;
                value.ReuLuoi_Co = DataReader["ReuLuoi_Co"].ToString() == "1" ? true : false;
                value.ReuLuoi_Khong = DataReader["ReuLuoi_Khong"].ToString() == "1" ? true : false;
                value.ReuLuoi_Bong = DataReader["ReuLuoi_Bong"].ToString() == "1" ? true : false;
                value.ReuLuoi_Day = DataReader["ReuLuoi_Day"].ToString() == "1" ? true : false;
                value.ReuLuoi_Mong = DataReader["ReuLuoi_Mong"].ToString() == "1" ? true : false;
                value.ReuLuoi_Uot = DataReader["ReuLuoi_Uot"].ToString() == "1" ? true : false;
                value.ReuLuoi_Kho = DataReader["ReuLuoi_Kho"].ToString() == "1" ? true : false;
                value.ReuLuoi_Dinh = DataReader["ReuLuoi_Dinh"].ToString() == "1" ? true : false;
                value.ReuLuoi_Trang = DataReader["ReuLuoi_Trang"].ToString() == "1" ? true : false;
                value.ReuLuoi_Vang = DataReader["ReuLuoi_Vang"].ToString() == "1" ? true : false;
                value.ReuLuoi_Den = DataReader["ReuLuoi_Den"].ToString() == "1" ? true : false;
                value.ReuLuoi_Khac = DataReader["ReuLuoi_Khac"].ToString() == "1" ? true : false;
                value.MoTaVongChan = DataReader["MoTaVongChan"].ToString();
                value.TiengNoi_BinhThuong = DataReader["TiengNoi_BinhThuong"].ToString() == "1" ? true : false;
                value.TiengNoi_To = DataReader["TiengNoi_To"].ToString() == "1" ? true : false;
                value.TiengNoi_Nho = DataReader["TiengNoi_Nho"].ToString() == "1" ? true : false;
                value.TiengNoi_DutQuang = DataReader["TiengNoi_DutQuang"].ToString() == "1" ? true : false;
                value.TiengNoi_Khan = DataReader["TiengNoi_Khan"].ToString() == "1" ? true : false;
                value.TiengNoi_Ngong = DataReader["TiengNoi_Ngong"].ToString() == "1" ? true : false;
                value.TiengNoi_Mat = DataReader["TiengNoi_Mat"].ToString() == "1" ? true : false;
                value.TiengNoi_Khac = DataReader["TiengNoi_Khac"].ToString() == "1" ? true : false;
                value.HoiTho_BinhThuong = DataReader["HoiTho_BinhThuong"].ToString() == "1" ? true : false;
                value.HoiTho_DutQuang = DataReader["HoiTho_DutQuang"].ToString() == "1" ? true : false;
                value.HoiTho_Ngan = DataReader["HoiTho_Ngan"].ToString() == "1" ? true : false;
                value.HoiTho_Manh = DataReader["HoiTho_Manh"].ToString() == "1" ? true : false;
                value.HoiTho_Yeu = DataReader["HoiTho_Yeu"].ToString() == "1" ? true : false;
                value.HoiTho_Tho = DataReader["HoiTho_Tho"].ToString() == "1" ? true : false;
                value.HoiTho_Rit = DataReader["HoiTho_Rit"].ToString() == "1" ? true : false;
                value.HoiTho_KhoKhe = DataReader["HoiTho_KhoKhe"].ToString() == "1" ? true : false;
                value.HoiTho_Cham = DataReader["HoiTho_Cham"].ToString() == "1" ? true : false;
                value.HoiTho_Gap = DataReader["HoiTho_Gap"].ToString() == "1" ? true : false;
                value.HoiTho_Khac = DataReader["HoiTho_Khac"].ToString() == "1" ? true : false;
                value.Ho = DataReader["Ho"].ToString() == "1" ? true : false;
                value.Ho_HoLienTuc = DataReader["Ho_HoLienTuc"].ToString() == "1" ? true : false;
                value.Ho_Con = DataReader["Ho_Con"].ToString() == "1" ? true : false;
                value.Ho_It = DataReader["Ho_It"].ToString() == "1" ? true : false;
                value.Ho_Nhieu = DataReader["Ho_Nhieu"].ToString() == "1" ? true : false;
                value.Ho_Khan = DataReader["Ho_Khan"].ToString() == "1" ? true : false;
                value.Ho_CoDom = DataReader["Ho_CoDom"].ToString() == "1" ? true : false;
                value.Ho_Khac = DataReader["Ho_Khac"].ToString() == "1" ? true : false;
                value.O = DataReader["O"].ToString() == "1" ? true : false;
                value.Nac = DataReader["Nac"].ToString() == "1" ? true : false;
                value.MuiCoThe = DataReader["MuiCoThe"].ToString() == "1" ? true : false;
                value.MuiCoThe_Chua = DataReader["MuiCoThe_Chua"].ToString() == "1" ? true : false;
                value.MuiCoThe_Kham = DataReader["MuiCoThe_Kham"].ToString() == "1" ? true : false;
                value.MuiCoThe_Tanh = DataReader["MuiCoThe_Tanh"].ToString() == "1" ? true : false;
                value.MuiCoThe_Thoi = DataReader["MuiCoThe_Thoi"].ToString() == "1" ? true : false;
                value.MuiCoThe_Hoi = DataReader["MuiCoThe_Hoi"].ToString() == "1" ? true : false;
                value.MuiCoThe_Khac = DataReader["MuiCoThe_Khac"].ToString() == "1" ? true : false;
                value.ChatThaiBieuHienBenhLy = DataReader["ChatThaiBieuHienBenhLy"].ToString() == "1" ? true : false;
                value.ChatThai_Dom = DataReader["ChatThai_Dom"].ToString() == "1" ? true : false;
                value.ChatThai_ChatNon = DataReader["ChatThai_ChatNon"].ToString() == "1" ? true : false;
                value.ChatThai_Phan = DataReader["ChatThai_Phan"].ToString() == "1" ? true : false;
                value.ChatThai_NuocTieu = DataReader["ChatThai_NuocTieu"].ToString() == "1" ? true : false;
                value.ChatThai_KhiHu = DataReader["ChatThai_KhiHu"].ToString() == "1" ? true : false;
                value.ChatThai_KinhNguyet = DataReader["ChatThai_KinhNguyet"].ToString() == "1" ? true : false;
                value.ChatThai_Khac = DataReader["ChatThai_Khac"].ToString() == "1" ? true : false;
                value.MoTaVanChan = DataReader["MoTaVanChan"].ToString();
                value.HanNhiet_BinhThuong = DataReader["HanNhiet_BinhThuong"].ToString() == "1" ? true : false;
                value.HanNhiet_Han = DataReader["HanNhiet_Han"].ToString() == "1" ? true : false;
                value.HanNhiet_Nhiet = DataReader["HanNhiet_Nhiet"].ToString() == "1" ? true : false;
                value.HanNhiet_Khac = DataReader["HanNhiet_Khac"].ToString() == "1" ? true : false;
                value.HanNhiet_ThichNong = DataReader["HanNhiet_ThichNong"].ToString() == "1" ? true : false;
                value.HanNhiet_SoNong = DataReader["HanNhiet_SoNong"].ToString() == "1" ? true : false;
                value.HanNhiet_ThichMat = DataReader["HanNhiet_ThichMat"].ToString() == "1" ? true : false;
                value.HanNhiet_SoLanh = DataReader["HanNhiet_SoLanh"].ToString() == "1" ? true : false;
                value.HanNhiet_TrongNguoiNong = DataReader["HanNhiet_TrongNguoiNong"].ToString() == "1" ? true : false;
                value.HanNhiet_TrongNguoiLanh = DataReader["HanNhiet_TrongNguoiLanh"].ToString() == "1" ? true : false;
                value.HanNhiet_RetRun = DataReader["HanNhiet_RetRun"].ToString() == "1" ? true : false;
                value.HanNhiet_HanNhietVangLai = DataReader["HanNhiet_HanNhietVangLai"].ToString() == "1" ? true : false;
                value.HanNhiet_Khac2 = DataReader["HanNhiet_Khac2"].ToString() == "1" ? true : false;
                value.MoHoi_BinhThuong_ThietChan = DataReader["MoHoi_BinhThuong_ThietChan"].ToString() == "1" ? true : false;
                value.MoHoi_BinhThuong = DataReader["MoHoi_BinhThuong"].ToString() == "1" ? true : false;
                value.MoHoi_KhongCoMoHoi = DataReader["MoHoi_KhongCoMoHoi"].ToString() == "1" ? true : false;
                value.MoHoi_TuHan = DataReader["MoHoi_TuHan"].ToString() == "1" ? true : false;
                value.MoHoi_DaoHan = DataReader["MoHoi_DaoHan"].ToString() == "1" ? true : false;
                value.MoHoi_Nhieu = DataReader["MoHoi_Nhieu"].ToString() == "1" ? true : false;
                value.MoHoi_It = DataReader["MoHoi_It"].ToString() == "1" ? true : false;
                value.MoHoi_Khac = DataReader["MoHoi_Khac"].ToString() == "1" ? true : false;
                value.DauMat = DataReader["DauMat"].ToString() == "1" ? true : false;
                value.DauDau_MotCho = DataReader["DauDau_MotCho"].ToString() == "1" ? true : false;
                value.DauDau_NuaDau = DataReader["DauDau_NuaDau"].ToString() == "1" ? true : false;
                value.DauDau_CaDau = DataReader["DauDau_CaDau"].ToString() == "1" ? true : false;
                value.DauDau_DiChuyen = DataReader["DauDau_DiChuyen"].ToString() == "1" ? true : false;
                value.DauDau_EAmNhuBiBuocLai = DataReader["DauDau_EAmNhuBiBuocLai"].ToString() == "1" ? true : false;
                value.DauDau_Nhoi = DataReader["DauDau_Nhoi"].ToString() == "1" ? true : false;
                value.DauDau_Cang = DataReader["DauDau_Cang"].ToString() == "1" ? true : false;
                value.DauDau_NangDau = DataReader["DauDau_NangDau"].ToString() == "1" ? true : false;
                value.Mat_HoaMatChongMat = DataReader["Mat_HoaMatChongMat"].ToString() == "1" ? true : false;
                value.Mat_NhinKhongRo = DataReader["Mat_NhinKhongRo"].ToString() == "1" ? true : false;
                value.Tai_U = DataReader["Tai_U"].ToString() == "1" ? true : false;
                value.Tai_Diec = DataReader["Tai_Diec"].ToString() == "1" ? true : false;
                value.Tai_Nang = DataReader["Tai_Nang"].ToString() == "1" ? true : false;
                value.Tai_ = DataReader["Tai_"].ToString() == "1" ? true : false;
                value.Tai_Dau = DataReader["Tai_Dau"].ToString() == "1" ? true : false;
                value.Mui_Ngat = DataReader["Mui_Ngat"].ToString() == "1" ? true : false;
                value.Mui_ChayNuoc = DataReader["Mui_ChayNuoc"].ToString() == "1" ? true : false;
                value.Mui_ChayMauCam = DataReader["Mui_ChayMauCam"].ToString() == "1" ? true : false;
                value.Mui_Dau = DataReader["Mui_Dau"].ToString() == "1" ? true : false;
                value.Hong_Dau = DataReader["Hong_Dau"].ToString() == "1" ? true : false;
                value.Hong_Kho = DataReader["Hong_Kho"].ToString() == "1" ? true : false;
                value.CoVai_Moi = DataReader["CoVai_Moi"].ToString() == "1" ? true : false;
                value.CoVai_Dau = DataReader["CoVai_Dau"].ToString() == "1" ? true : false;
                value.CoVai_KhoVanDong = DataReader["CoVai_KhoVanDong"].ToString() == "1" ? true : false;
                value.CoVai_Khac = DataReader["CoVai_Khac"].ToString() == "1" ? true : false;
                value.Lung = DataReader["Lung"].ToString() == "1" ? true : false;
                value.Lung_Dau = DataReader["Lung_Dau"].ToString() == "1" ? true : false;
                value.Lung_KhoVanDong = DataReader["Lung_KhoVanDong"].ToString() == "1" ? true : false;
                value.Lung_CoCungCo = DataReader["Lung_CoCungCo"].ToString() == "1" ? true : false;
                value.Lung_Khac = DataReader["Lung_Khac"].ToString() == "1" ? true : false;
                value.BungVaUc = DataReader["BungVaUc"].ToString() == "1" ? true : false;
                value.BungNguc_Tuc = DataReader["BungNguc_Tuc"].ToString() == "1" ? true : false;
                value.BungNguc_Dau = DataReader["BungNguc_Dau"].ToString() == "1" ? true : false;
                value.BungNguc_Soi = DataReader["BungNguc_Soi"].ToString() == "1" ? true : false;
                value.BungNguc_NongRuot = DataReader["BungNguc_NongRuot"].ToString() == "1" ? true : false;
                value.BungNguc_DayTruong = DataReader["BungNguc_DayTruong"].ToString() == "1" ? true : false;
                value.BungNguc_NgotNgatKhoTho = DataReader["BungNguc_NgotNgatKhoTho"].ToString() == "1" ? true : false;
                value.BungNguc_DauTucCanhSuon = DataReader["BungNguc_DauTucCanhSuon"].ToString() == "1" ? true : false;
                value.BungNguc_BonChonKhongYen = DataReader["BungNguc_BonChonKhongYen"].ToString() == "1" ? true : false;
                value.BungNguc_DanhTrongNguc = DataReader["BungNguc_DanhTrongNguc"].ToString() == "1" ? true : false;
                value.BungNguc_Khac = DataReader["BungNguc_Khac"].ToString() == "1" ? true : false;
                value.ChanTay = DataReader["ChanTay"].ToString() == "1" ? true : false;
                value.An = DataReader["An"].ToString() == "1" ? true : false;
                value.An_ThichNong = DataReader["An_ThichNong"].ToString() == "1" ? true : false;
                value.An_ThichMat = DataReader["An_ThichMat"].ToString() == "1" ? true : false;
                value.An_AnNhieu = DataReader["An_AnNhieu"].ToString() == "1" ? true : false;
                value.An_AnIt = DataReader["An_AnIt"].ToString() == "1" ? true : false;
                value.An_DangMieng = DataReader["An_DangMieng"].ToString() == "1" ? true : false;
                value.An_NhatMieng = DataReader["An_NhatMieng"].ToString() == "1" ? true : false;
                value.An_ThemAn = DataReader["An_ThemAn"].ToString() == "1" ? true : false;
                value.An_ChanAn = DataReader["An_ChanAn"].ToString() == "1" ? true : false;
                value.An_AnVaoBungChuong = DataReader["An_AnVaoBungChuong"].ToString() == "1" ? true : false;
                value.An_Khac = DataReader["An_Khac"].ToString() == "1" ? true : false;
                value.Uong = DataReader["Uong"].ToString() == "1" ? true : false;
                value.Uong_Mat = DataReader["Uong_Mat"].ToString() == "1" ? true : false;
                value.Uong_AmNong = DataReader["Uong_AmNong"].ToString() == "1" ? true : false;
                value.Uong_Nhieu = DataReader["Uong_Nhieu"].ToString() == "1" ? true : false;
                value.Uong_It = DataReader["Uong_It"].ToString() == "1" ? true : false;
                value.Uong_Khac = DataReader["Uong_Khac"].ToString() == "1" ? true : false;
                value.DaiTieuTien = DataReader["DaiTieuTien"].ToString() == "1" ? true : false;
                value.Tieutien_Vang = DataReader["Tieutien_Vang"].ToString() == "1" ? true : false;
                value.Tieutien_Do = DataReader["Tieutien_Do"].ToString() == "1" ? true : false;
                value.Tieutien_Duc = DataReader["Tieutien_Duc"].ToString() == "1" ? true : false;
                value.Tieutien_Buot = DataReader["Tieutien_Buot"].ToString() == "1" ? true : false;
                value.Tieutien_Dat = DataReader["Tieutien_Dat"].ToString() == "1" ? true : false;
                value.Tieutien_KhongTuChu = DataReader["Tieutien_KhongTuChu"].ToString() == "1" ? true : false;
                value.Tieutien_Bi = DataReader["Tieutien_Bi"].ToString() == "1" ? true : false;
                value.Tieutien_Khac = DataReader["Tieutien_Khac"].ToString() == "1" ? true : false;
                value.Daitien_Tao = DataReader["Daitien_Tao"].ToString() == "1" ? true : false;
                value.Daitien_Nhao = DataReader["Daitien_Nhao"].ToString() == "1" ? true : false;
                value.Daitien_Song = DataReader["Daitien_Song"].ToString() == "1" ? true : false;
                value.Daitien_ToanNuoc = DataReader["Daitien_ToanNuoc"].ToString() == "1" ? true : false;
                value.Daitien_NhayMui = DataReader["Daitien_NhayMui"].ToString() == "1" ? true : false;
                value.Daitien_Bi = DataReader["Daitien_Bi"].ToString() == "1" ? true : false;
                value.Daitien_Khac = DataReader["Daitien_Khac"].ToString() == "1" ? true : false;
                value.Ngu = DataReader["Ngu"].ToString() == "1" ? true : false;
                value.Ngu_KhoVaoGiacNgu = DataReader["Ngu_KhoVaoGiacNgu"].ToString() == "1" ? true : false;
                value.Ngu_HayTinh = DataReader["Ngu_HayTinh"].ToString() == "1" ? true : false;
                value.Ngu_DaySom = DataReader["Ngu_DaySom"].ToString() == "1" ? true : false;
                value.Ngu_HayMo = DataReader["Ngu_HayMo"].ToString() == "1" ? true : false;
                value.Ngu_Khac = DataReader["Ngu_Khac"].ToString() == "1" ? true : false;
                value.KinhNguyet = DataReader["KinhNguyet"].ToString() == "1" ? true : false;
                value.KinhNguyet_DenTruocKy = DataReader["KinhNguyet_DenTruocKy"].ToString() == "1" ? true : false;
                value.KinhNguyet_DenSauKy = DataReader["KinhNguyet_DenSauKy"].ToString() == "1" ? true : false;
                value.KinhNguyet_LucDenTruocLucDenS = DataReader["KinhNguyet_LucDenTruocLucDenS"].ToString() == "1" ? true : false;
                value.KinhNguyet_TacKinh = DataReader["KinhNguyet_TacKinh"].ToString() == "1" ? true : false;
                value.KinhNguyet_Khac = DataReader["KinhNguyet_Khac"].ToString() == "1" ? true : false;
                value.ThongKinh_DauTruocKy = DataReader["ThongKinh_DauTruocKy"].ToString() == "1" ? true : false;
                value.ThongKinh_DauTrongKy = DataReader["ThongKinh_DauTrongKy"].ToString() == "1" ? true : false;
                value.ThongKinh_DauSauKy = DataReader["ThongKinh_DauSauKy"].ToString() == "1" ? true : false;
                value.ThongKinh_Khac = DataReader["ThongKinh_Khac"].ToString() == "1" ? true : false;
                value.DoiHa_Vang = DataReader["DoiHa_Vang"].ToString() == "1" ? true : false;
                value.DoiHa_Trang = DataReader["DoiHa_Trang"].ToString() == "1" ? true : false;
                value.DoiHa_Hoi = DataReader["DoiHa_Hoi"].ToString() == "1" ? true : false;
                value.DoiHa_Hong = DataReader["DoiHa_Hong"].ToString() == "1" ? true : false;
                value.DoiHa_Khac = DataReader["DoiHa_Khac"].ToString() == "1" ? true : false;
                value.RoiHanKhaNangSinhDuc = DataReader.GetInt("RoiHanKhaNangSinhDuc");
                value.Nam_YeuKhiGiaoHop = DataReader["Nam_YeuKhiGiaoHop"].ToString() == "1" ? true : false;
                value.Nam_LietDuong = DataReader["Nam_LietDuong"].ToString() == "1" ? true : false;
                value.Nam_DiTinh = DataReader["Nam_DiTinh"].ToString() == "1" ? true : false;
                value.Nam_HoatTinh = DataReader["Nam_HoatTinh"].ToString() == "1" ? true : false;
                value.Nam_MongTinh = DataReader["Nam_MongTinh"].ToString() == "1" ? true : false;
                value.Nam_LanhTinh = DataReader["Nam_LanhTinh"].ToString() == "1" ? true : false;
                value.Nu_KhongThuThai = DataReader["Nu_KhongThuThai"].ToString() == "1" ? true : false;
                value.Nu_SayThai_DongThai = DataReader["Nu_SayThai_DongThai"].ToString() == "1" ? true : false;
                value.Nu_SayThaiLienTiep = DataReader["Nu_SayThaiLienTiep"].ToString() == "1" ? true : false;
                value.Nu_Khac = DataReader["Nu_Khac"].ToString() == "1" ? true : false;
                value.DieuKienXuatHienBenh = DataReader["DieuKienXuatHienBenh"].ToString() == "1" ? true : false;
                value.MoTaVaanChan = DataReader["MoTaVaanChan"].ToString();
                value.Da_BinhThuong = DataReader["Da_BinhThuong"].ToString() == "1" ? true : false;
                value.Da_Kho = DataReader["Da_Kho"].ToString() == "1" ? true : false;
                value.Da_Nong = DataReader["Da_Nong"].ToString() == "1" ? true : false;
                value.Da_Lanh = DataReader["Da_Lanh"].ToString() == "1" ? true : false;
                value.Da_Uot = DataReader["Da_Uot"].ToString() == "1" ? true : false;
                value.Da_ChanTayNong = DataReader["Da_ChanTayNong"].ToString() == "1" ? true : false;
                value.Da_ChanTayLanh = DataReader["Da_ChanTayLanh"].ToString() == "1" ? true : false;
                value.Da_AnLom = DataReader["Da_AnLom"].ToString() == "1" ? true : false;
                value.Da_AnDau = DataReader["Da_AnDau"].ToString() == "1" ? true : false;
                value.Da_CucCung = DataReader["Da_CucCung"].ToString() == "1" ? true : false;
                value.Da_Khac = DataReader["Da_Khac"].ToString() == "1" ? true : false;
                value.MoHoi_ToanThan = DataReader["MoHoi_ToanThan"].ToString() == "1" ? true : false;
                value.MoHoi_Tran = DataReader["MoHoi_Tran"].ToString() == "1" ? true : false;
                value.MoHoi_TayChan = DataReader["MoHoi_TayChan"].ToString() == "1" ? true : false;
                value.MoHoi_KhacXucChan = DataReader["MoHoi_KhacXucChan"].ToString() == "1" ? true : false;
                value.CoXuongKhop_SanChac = DataReader["CoXuongKhop_SanChac"].ToString() == "1" ? true : false;
                value.CoXuongKhop_Mem = DataReader["CoXuongKhop_Mem"].ToString() == "1" ? true : false;
                value.CoXuongKhop_CangCung = DataReader["CoXuongKhop_CangCung"].ToString() == "1" ? true : false;
                value.CoXuongKhop_CoCoAnDau = DataReader["CoXuongKhop_CoCoAnDau"].ToString() == "1" ? true : false;
                value.CoXuongKhop_GanDau = DataReader["CoXuongKhop_GanDau"].ToString() == "1" ? true : false;
                value.CoXuongKhop_XuongKhopDau = DataReader["CoXuongKhop_XuongKhopDau"].ToString() == "1" ? true : false;
                value.CoXuongKhop_Khac = DataReader["CoXuongKhop_Khac"].ToString() == "1" ? true : false;
                value.Bung_Mem = DataReader["Bung_Mem"].ToString() == "1" ? true : false;
                value.Bung_Chuong = DataReader["Bung_Chuong"].ToString() == "1" ? true : false;
                value.Bung_CoChuong = DataReader["Bung_CoChuong"].ToString() == "1" ? true : false;
                value.Bung_CoHonCuc = DataReader["Bung_CoHonCuc"].ToString() == "1" ? true : false;
                value.Bung_DauThienAn = DataReader["Bung_DauThienAn"].ToString() == "1" ? true : false;
                value.Bung_DauCuAn = DataReader["Bung_DauCuAn"].ToString() == "1" ? true : false;
                value.Bung_Khac = DataReader["Bung_Khac"].ToString() == "1" ? true : false;
                value.MacChan_Phu = DataReader["MacChan_Phu"].ToString() == "1" ? true : false;
                value.MacChan_Tram = DataReader["MacChan_Tram"].ToString() == "1" ? true : false;
                value.MacChan_Tri = DataReader["MacChan_Tri"].ToString() == "1" ? true : false;
                value.MacChan_Sac = DataReader["MacChan_Sac"].ToString() == "1" ? true : false;
                value.MacChan_Te = DataReader["MacChan_Te"].ToString() == "1" ? true : false;
                value.MacChan_Huyen = DataReader["MacChan_Huyen"].ToString() == "1" ? true : false;
                value.MacChan_Hoat = DataReader["MacChan_Hoat"].ToString() == "1" ? true : false;
                value.MacChan_VoLuc = DataReader["MacChan_VoLuc"].ToString() == "1" ? true : false;
                value.MacChan_CoLuc = DataReader["MacChan_CoLuc"].ToString() == "1" ? true : false;
                value.MacChan_Khac = DataReader["MacChan_Khac"].ToString() == "1" ? true : false;
                value.BenPhai_TongKhan = DataReader["BenPhai_TongKhan"].ToString();
                value.BenTrai_TongKhan = DataReader["BenTrai_TongKhan"].ToString();
                value.Ma_BenPhai_TongKhan = DataReader["Ma_BenPhai_TongKhan"].ToString();
                value.Ma_BenTrai_TongKhan = DataReader["Ma_BenTrai_TongKhan"].ToString();
                value.MachTayTrai_Thon1 = ConVSpecial(DataReader["MachTayTrai_Thon1"]);
                value.MachTayTrai_Thon2 = ConVSpecial(DataReader["MachTayTrai_Thon2"]);
                value.MachTayTrai_Thon3 = ConVSpecial(DataReader["MachTayTrai_Thon3"]);
                value.MachTayTrai_Thon4 = ConVSpecial(DataReader["MachTayTrai_Thon4"]);
                value.MachTayTrai_Quan1 = ConVSpecial(DataReader["MachTayTrai_Quan1"]);
                value.MachTayTrai_Quan2 = ConVSpecial(DataReader["MachTayTrai_Quan2"]);
                value.MachTayTrai_Quan3 = ConVSpecial(DataReader["MachTayTrai_Quan3"]);
                value.MachTayTrai_Quan4 = ConVSpecial(DataReader["MachTayTrai_Quan4"]);
                value.MachTayTrai_Xich1 = ConVSpecial(DataReader["MachTayTrai_Xich1"]);
                value.MachTayTrai_Xich2 = ConVSpecial(DataReader["MachTayTrai_Xich2"]);
                value.MachTayTrai_Xich3 = ConVSpecial(DataReader["MachTayTrai_Xich3"]);
                value.MachTayTrai_Xich4 = ConVSpecial(DataReader["MachTayTrai_Xich4"]);
                value.MachTayPhai_Thon1 = ConVSpecial(DataReader["MachTayPhai_Thon1"]);
                value.MachTayPhai_Thon2 = ConVSpecial(DataReader["MachTayPhai_Thon2"]);
                value.MachTayPhai_Thon3 = ConVSpecial(DataReader["MachTayPhai_Thon3"]);
                value.MachTayPhai_Thon4 = ConVSpecial(DataReader["MachTayPhai_Thon4"]);
                value.MachTayPhai_Quan1 = ConVSpecial(DataReader["MachTayPhai_Quan1"]);
                value.MachTayPhai_Quan2 = ConVSpecial(DataReader["MachTayPhai_Quan2"]);
                value.MachTayPhai_Quan3 = ConVSpecial(DataReader["MachTayPhai_Quan3"]);
                value.MachTayPhai_Quan4 = ConVSpecial(DataReader["MachTayPhai_Quan4"]);
                value.MachTayPhai_Xich1 = ConVSpecial(DataReader["MachTayPhai_Xich1"]);
                value.MachTayPhai_Xich2 = ConVSpecial(DataReader["MachTayPhai_Xich2"]);
                value.MachTayPhai_Xich3 = ConVSpecial(DataReader["MachTayPhai_Xich3"]);
                value.MachTayPhai_Xich4 = ConVSpecial(DataReader["MachTayPhai_Xich4"]);
                value.MoTaThietChan = DataReader["MoTaThietChan"].ToString();
                value.TomTatTuChan = DataReader["TomTatTuChan"].ToString();
                value.BienPhapLuanTri = DataReader["BienPhapLuanTri"].ToString();
                value.BietDanh = DataReader["BietDanh"].ToString();
                value.BatCuong = DataReader["BatCuong"].ToString();
                value.TangPhuKinhLac = DataReader["TangPhuKinhLac"].ToString();
                value.NguyenNhan = DataReader["NguyenNhan"].ToString();
                value.DieuTriYHCT = DataReader["DieuTriYHCT"].ToString() == "1" ? true : false;
                value.PhapDieuTri = DataReader["PhapDieuTri"].ToString();
                value.PhuongThuoc = DataReader["PhuongThuoc"].ToString();
                value.PhuongHuyet = DataReader["PhuongHuyet"].ToString();
                value.XoaBopBamHuyet = DataReader["XoaBopBamHuyet"].ToString();
                value.Khac_DieuTri = DataReader["Khac_DieuTri"].ToString();
                value.DieuTriKetHopVoiYHHD = DataReader["DieuTriKetHopVoiYHHD"].ToString() == "1" ? true : false;
                value.DieuTriKetHopVoiYHHD_Text = DataReader["DieuTriKetHopVoiYHHD_Text"].ToString();
                value.CheDoDinhDuong = DataReader.GetInt("CheDoDinhDuong");
                value.CheDoChamSoc = DataReader.GetInt("CheDoChamSoc");
                value.ChanDoanVaoVienTheoYHCT = DataReader["ChanDoanVaoVienTheoYHCT"].ToString();
                value.ChanDoanVaoVienTheoYHHD = DataReader["ChanDoanVaoVienTheoYHHD"].ToString();
                value.PhuongPhapDieuTriTheoYHHD = DataReader["PhuongPhapDieuTriTheoYHHD"].ToString();
                value.PhuongPhapDieuTriTheoYHCT = DataReader["PhuongPhapDieuTriTheoYHCT"].ToString();
                value.ChanDoanRaVienTheoYHCT = DataReader["ChanDoanRaVienTheoYHCT"].ToString();
                value.ChanDoanRaVienTheoYHHD = DataReader["ChanDoanRaVienTheoYHHD"].ToString();
                value.KetQuaDieuTriID = DataReader.GetInt("KetQuaDieuTriID");
                value.TinhTrangNguoiBenhKhiRavien = DataReader["TinhTrangNguoiBenhKhiRavien"].ToString();
                value.MaSoKyTen = DataReader["masokyten"].ToString();
                value.MaSoKyTen_KB = DataReader["masokyten_kb"].ToString();
                value.MaSoKyTen_TK = DataReader["masokyten_tk"].ToString();
            }
            return value;
        }
        public static int? ConDB_Int(object dbVal, int valDefault = 0)
        {
            int ret = valDefault;
            if (dbVal == null)
            {
                return null;
            }
            bool isSuccess = int.TryParse(dbVal.ToString(), out ret);
            if (!isSuccess)
            {
                return valDefault;
            }
            return ret;
        }
        public static int? ConVSpecial(object dbVal, int valDefault = 0)
        {
            int ret = valDefault;
            if (dbVal == null)
            {
                return null;
            }
            bool isSuccess = int.TryParse(dbVal.ToString(), out ret);
            if (!isSuccess)
            {
                return valDefault;
            }
            if (ret == -1)
            {
                ret = 0;
            }
             return ret;
        }
        public static bool Insert(MDB.MDBConnection MyConnection, BenhAnNoiTruYHCT BenhAnNoiTruYHCT)
        {
            if (BenhAnNoiTruYHCT == null) return false;
            if (BenhAnNoiTruYHCT.DacDiemLienQuanBenh == null) BenhAnNoiTruYHCT.DacDiemLienQuanBenh = new DacDiemLienQuanBenh();
            string sql =
                      @"select MaQuanLy 
                        from BenhAnNoiTruYHCT
                        where MaQuanLy = :MaQuanLy";
            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
            Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", BenhAnNoiTruYHCT.MaQuanLy));
            MDB.MDBDataReader DataReader = Command.ExecuteReader();
            int rowCount = 0;
            while (DataReader.Read()) rowCount++;
            if (rowCount == 1) return Update(MyConnection, BenhAnNoiTruYHCT);
            sql = @"INSERT INTO BenhAnNoiTruYHCT (MaQuanLy, LyDoVaoVien,VaoNgayThu,QuaTrinhBenhLy,TienSuBenhBanThan,TienSuBenhGiaDinh,ToanThan,TuanHoan,HoHap,TieuHoa,ThanTietNieuSinhDuc,ThanKinh,CoXuongKhop,TaiMuiHong,RangHamMat,Mat,Khac_CacCoQuan,CacXetNghiemCanLamSangCanLam,TomTatBenhAn,BenhChinh,BenhKemTheo,PhanBiet,TienLuong,HuongDieuTri,NgayKhamBenh,BacSyLamBenhAn,QuaTrinhBenhLyVaDienBien,TomTatKetQuaXetNghiem,PhuongPhapDieuTri,TinhTrangNguoiBenhRaVien,HuongDieuTriVaCacCheDoTiepTheo,NguoiNhanHoSo,NguoiGiaoHoSo,NgayTongKet,BacSyDieuTri,DiUng,DiUng_Text,MaTuy,MaTuy_Text,RuouBia,RuouBia_Text,ThuocLa,ThuocLa_Text,ThuocLao,ThuocLao_Text,Khac_DacDiemLienQuanBenh,Khac_DacDiemLienQuanBenh_Text,BenhSu,MoTaChiTietCoQuanBenhLy,HinhThai_Gay,Bung_Dau,ChanTay_Dau,ChanTay_Te,ChanTay_Buon,ChanTay_Moi,ChanTay_Nhuc,ChanTay_Nong,ChanTay_Lanh,ChanTay_Khac,Nam_Khac,Nu_DongThai,Nu_SayThai,MacChan_Nhu,DinhViBenhTheo_Ve,DinhViBenhTheo_Khi,DinhViBenhTheo_Dinh,DinhViBenhTheo_Huyet,NguyenNhan_NoiNhan,NguyenNhan_NgoaiNhan,NguyenNhan_BatNoiNgoai,TangPhu_Tam,TangPhu_Lan,TangPhu_Ty,TangPhu_Phe,TangPhu_Than,TangPhu_TamBao,TangPhu_TieuTruong,TangPhu_Dom,TangPhu_Vi,TangPhu_DaiTruong,TangPhu_BangQuang,TangPhu_TamTieu,TangPhu_PhuKyHang,KinhMach_Tam,DauDau_DauThat,DauDau_Khac,Mat_Dau,Mat_Khac,Mui_Khac,Hong_Khac,KinhMach_Lan,KinhMach_Ty,KinhMach_Phe,KinhMach_Than,KinhMach_TamBao,KinhMach_TieuTruong,KinhMach_Dom,KinhMach_Vi,KinhMach_DaiTruong,KinhMach_BangQuang,KinhMach_TamTieu,KinhMach_MachDoc,KinhMach_MachNham,BatCuong_Bieu,BatCuong_Ly,BatCuong_Hu,BatCuong_Thuc,BatCuong_Han,BatCuong_Nhiet,BatCuong_Am,BatCuong_Duong,Bung,DoiHa,CoXuongKhop_BinhThuong,Bung_BinhThuong,PPKhongDungThuoc,PPKhac,MotaTienSuBanThan,ChanDoanVVYHCT_BenhChinh,ChanDoanVVYHCT_KemTheo,MaICDChanDoanVVYHCT_BenhChinh,MaICDChanDoanVVYHCT_KemTheo,ChanDoanVVYHHD_BenhChinh,ChanDoanVVYHD_KemTheo,MaICDVVYHD_BenhChinh,MaICDChanDoanVVYHD_KemTheo,ChanDoanRVYHCT_BenhChinh,ChanDoanRVYHCT_KemTheo,MaICDChanDoanRVYHCT_BenhChinh,MaICDChanDoanRVYHCT_KemTheo,ChanDoanRVYHHD_BenhChinh,ChanDoanRVYHD_KemTheo,MaICDRVYHD_BenhChinh,MaICDChanDoanRVYHD_KemTheo,ChanDoan_NoiChuyenDen_YHCT,MaICD_NoiChuyenDen_YHCT,ChanDoan_KKB_CapCuu_YHCT,MaICD_KKB_CapCuu_YHCT,HOSOKQ_XQUANG,HOSOKQ_CTSCANNER,HOSOKQ_MRI,HOSOKQ_KHAC_TXT,HOSOKQ_KHAC,HOSOKQ_TOANBOHOSO,BenhChinh_YHCT,MaICD_BenhChinh_YHCT,BenhKemTheo_YHCT,MaICD_BenhKemTheo_YHCT,ThuThuat_YHCT,PhauThuat_YHCT,BenhChinh_RV_YHCT,MaICD_BenhChinh_RV_YHCT,BenhKemTheo_RV_YHCT,MaICD_BenhKemTheo_RV_YHCT,TaiBien_YHCT,BienChung_YHCT,MaICD_BenhKemTheo_YHHD,MaICD_BenhChinh_YHHD_CD,MaICD_BenhKemTheo_YHHD_CD,CheDoDinhDuong_Long,CheDoDinhDuong_Dac,CheDoDinhDuong_Kieng,CheDoDinhDuong_Khac,CheDoChamSoc_1   ,CheDoChamSoc_2   ,CheDoChamSoc_3   ,HinhThai_Beo,HinhThai_CanDoi,HinhThai_NamCo,HinhThai_UaTinh,HinhThai_NamDuoi,HinhThai_HieuDong,HinhThai_Khac,Than_ConThan,Than_KhongConThan,Than_Khac,Sac_BechTrang,Sac_Do,Sac_Vang,Sac_Xanh,Sac_Den,Sac_Khac,Sac_BinhThuong,Trach_TuoiNhuan,Trach_Kho,Trach_Khac,ChatLuoi_BinhThuong,ChatLuoi_Beu,ChatLuoi_GayMong,ChatLuoi_Nut,ChatLuoi_Cung,ChatLuoi_Loet,ChatLuoi_Lech,ChatLuoi_Rut,ChatLuoi_Khac,SacLuoi_Hong,SacLuoi_Nhot,SacLuoi_Do,SacLuoi_DoSam,SacLuoi_XanhTim,SacLuoi_DamUHuyet,SacLuoi_Kho,SacLuoi_Nhuan,SacLuoi_Khac,ReuLuoi_Co,ReuLuoi_Khong,ReuLuoi_Bong,ReuLuoi_Day,ReuLuoi_Mong,ReuLuoi_Uot,ReuLuoi_Kho,ReuLuoi_Dinh,ReuLuoi_Trang,ReuLuoi_Vang,ReuLuoi_Den,ReuLuoi_Khac,MoTaVongChan,TiengNoi_BinhThuong,TiengNoi_To,TiengNoi_Nho,TiengNoi_DutQuang,TiengNoi_Khan,TiengNoi_Ngong,TiengNoi_Mat,TiengNoi_Khac,HoiTho_BinhThuong,HoiTho_DutQuang,HoiTho_Ngan,HoiTho_Manh,HoiTho_Yeu,HoiTho_Tho,HoiTho_Rit,HoiTho_KhoKhe,HoiTho_Cham,HoiTho_Gap,HoiTho_Khac,Ho,Ho_HoLienTuc,Ho_Con,Ho_It,Ho_Nhieu,Ho_Khan,Ho_CoDom,Ho_Khac,O,Nac,MuiCoThe,MuiCoThe_Chua,MuiCoThe_Kham,MuiCoThe_Tanh,MuiCoThe_Thoi,MuiCoThe_Hoi,MuiCoThe_Khac,ChatThaiBieuHienBenhLy,ChatThai_Dom,ChatThai_ChatNon,ChatThai_Phan,ChatThai_NuocTieu,ChatThai_KhiHu,ChatThai_KinhNguyet,ChatThai_Khac,MoTaVanChan,HanNhiet_BinhThuong,HanNhiet_Han,HanNhiet_Nhiet,HanNhiet_Khac,HanNhiet_ThichNong,HanNhiet_SoNong,HanNhiet_ThichMat,HanNhiet_SoLanh,HanNhiet_TrongNguoiNong,HanNhiet_TrongNguoiLanh,HanNhiet_RetRun,HanNhiet_HanNhietVangLai,HanNhiet_Khac2,MoHoi_BinhThuong_ThietChan,MoHoi_BinhThuong,MoHoi_KhongCoMoHoi,MoHoi_TuHan,MoHoi_DaoHan,MoHoi_Nhieu,MoHoi_It,MoHoi_Khac,DauMat,DauDau_MotCho,DauDau_NuaDau,DauDau_CaDau,DauDau_DiChuyen,DauDau_EAmNhuBiBuocLai,DauDau_Nhoi,DauDau_Cang,DauDau_NangDau,Mat_HoaMatChongMat,Mat_NhinKhongRo,Tai_U,Tai_Diec,Tai_Nang,Tai_,Tai_Dau,Mui_Ngat,Mui_ChayNuoc,Mui_ChayMauCam,Mui_Dau,Hong_Dau,Hong_Kho,CoVai_Moi,CoVai_Dau,CoVai_KhoVanDong,CoVai_Khac,Lung,Lung_Dau,Lung_KhoVanDong,Lung_CoCungCo,Lung_Khac,BungVaUc,BungNguc_Tuc,BungNguc_Dau,BungNguc_Soi,BungNguc_NongRuot,BungNguc_DayTruong,BungNguc_NgotNgatKhoTho,BungNguc_DauTucCanhSuon,BungNguc_BonChonKhongYen,BungNguc_DanhTrongNguc,BungNguc_Khac,ChanTay,An,An_ThichNong,An_ThichMat,An_AnNhieu,An_AnIt,An_DangMieng,An_NhatMieng,An_ThemAn,An_ChanAn,An_AnVaoBungChuong,An_Khac,Uong,Uong_Mat,Uong_AmNong,Uong_Nhieu,Uong_It,Uong_Khac,DaiTieuTien,Tieutien_Vang,Tieutien_Do,Tieutien_Duc,Tieutien_Buot,Tieutien_Dat,Tieutien_KhongTuChu,Tieutien_Bi,Tieutien_Khac,Daitien_Tao,Daitien_Nhao,Daitien_Song,Daitien_ToanNuoc,Daitien_NhayMui,Daitien_Bi,Daitien_Khac,Ngu,Ngu_KhoVaoGiacNgu,Ngu_HayTinh,Ngu_DaySom,Ngu_HayMo,Ngu_Khac,KinhNguyet,KinhNguyet_DenTruocKy,KinhNguyet_DenSauKy,KinhNguyet_LucDenTruocLucDenS,KinhNguyet_TacKinh,KinhNguyet_Khac,ThongKinh_DauTruocKy,ThongKinh_DauTrongKy,ThongKinh_DauSauKy,ThongKinh_Khac,DoiHa_Vang,DoiHa_Trang,DoiHa_Hoi,DoiHa_Hong,DoiHa_Khac,RoiHanKhaNangSinhDuc,Nam_YeuKhiGiaoHop,Nam_LietDuong,Nam_DiTinh,Nam_HoatTinh,Nam_MongTinh,Nam_LanhTinh,Nu_KhongThuThai,Nu_SayThai_DongThai,Nu_SayThaiLienTiep,Nu_Khac,DieuKienXuatHienBenh,MoTaVaanChan,Da_BinhThuong,Da_Kho,Da_Nong,Da_Lanh,Da_Uot,Da_ChanTayNong,Da_ChanTayLanh,Da_AnLom,Da_AnDau,Da_CucCung,Da_Khac,MoHoi_ToanThan,MoHoi_Tran,MoHoi_TayChan,MoHoi_KhacXucChan,CoXuongKhop_SanChac,CoXuongKhop_Mem,CoXuongKhop_CangCung,CoXuongKhop_CoCoAnDau,CoXuongKhop_GanDau,CoXuongKhop_XuongKhopDau,CoXuongKhop_Khac,Bung_Mem,Bung_Chuong,Bung_CoChuong,Bung_CoHonCuc,Bung_DauThienAn,Bung_DauCuAn,Bung_Khac,MacChan_Phu,MacChan_Tram,MacChan_Tri,MacChan_Sac,MacChan_Te,MacChan_Huyen,MacChan_Hoat,MacChan_VoLuc,MacChan_CoLuc,MacChan_Khac,BenPhai_TongKhan,BenTrai_TongKhan,Ma_BenPhai_TongKhan,Ma_BenTrai_TongKhan,MachTayTrai_Thon1,MachTayTrai_Thon2,MachTayTrai_Thon3,MachTayTrai_Thon4,MachTayTrai_Quan1,MachTayTrai_Quan2,MachTayTrai_Quan3,MachTayTrai_Quan4,MachTayTrai_Xich1,MachTayTrai_Xich2,MachTayTrai_Xich3,MachTayTrai_Xich4,MachTayPhai_Thon1,MachTayPhai_Thon2,MachTayPhai_Thon3,MachTayPhai_Thon4,MachTayPhai_Quan1,MachTayPhai_Quan2,MachTayPhai_Quan3,MachTayPhai_Quan4,MachTayPhai_Xich1,MachTayPhai_Xich2,MachTayPhai_Xich3,MachTayPhai_Xich4,MoTaThietChan,TomTatTuChan,BienPhapLuanTri,BietDanh,BatCuong,TangPhuKinhLac,NguyenNhan,DieuTriYHCT,PhapDieuTri,PhuongThuoc,PhuongHuyet,XoaBopBamHuyet,Khac_DieuTri,DieuTriKetHopVoiYHHD,DieuTriKetHopVoiYHHD_Text,CheDoDinhDuong,CheDoChamSoc,ChanDoanVaoVienTheoYHCT,ChanDoanVaoVienTheoYHHD,PhuongPhapDieuTriTheoYHHD,PhuongPhapDieuTriTheoYHCT,ChanDoanRaVienTheoYHCT,ChanDoanRaVienTheoYHHD,KetQuaDieuTriID,TinhTrangNguoiBenhKhiRavien)";
            sql = sql + "VALUES(:MaQuanLy, :LyDoVaoVien,:VaoNgayThu,:QuaTrinhBenhLy,:TienSuBenhBanThan,:TienSuBenhGiaDinh,:ToanThan,:TuanHoan,:HoHap,:TieuHoa,:ThanTietNieuSinhDuc,:ThanKinh,:CoXuongKhop,:TaiMuiHong,:RangHamMat,:Mat,:Khac_CacCoQuan,:CacXetNghiemCanLamSangCanLam,:TomTatBenhAn,:BenhChinh,:BenhKemTheo,:PhanBiet,:TienLuong,:HuongDieuTri,:NgayKhamBenh,:BacSyLamBenhAn,:QuaTrinhBenhLyVaDienBien,:TomTatKetQuaXetNghiem,:PhuongPhapDieuTri,:TinhTrangNguoiBenhRaVien,:HuongDieuTriVaCacCheDoTiepTheo,:NguoiNhanHoSo,:NguoiGiaoHoSo,:NgayTongKet,:BacSyDieuTri,:DiUng,:DiUng_Text,:MaTuy,:MaTuy_Text,:RuouBia,:RuouBia_Text,:ThuocLa,:ThuocLa_Text,:ThuocLao,:ThuocLao_Text,:Khac_DacDiemLienQuanBenh,:Khac_DacDiemLienQuanBenh_Text,:BenhSu,:MoTaChiTietCoQuanBenhLy,:HinhThai_Gay,:Bung_Dau,:ChanTay_Dau,:ChanTay_Te,:ChanTay_Buon,:ChanTay_Moi,:ChanTay_Nhuc,:ChanTay_Nong,:ChanTay_Lanh,:ChanTay_Khac,:Nam_Khac,:Nu_DongThai,:Nu_SayThai,:MacChan_Nhu,:DinhViBenhTheo_Ve,:DinhViBenhTheo_Khi,:DinhViBenhTheo_Dinh,:DinhViBenhTheo_Huyet,:NguyenNhan_NoiNhan,:NguyenNhan_NgoaiNhan,:NguyenNhan_BatNoiNgoai,:TangPhu_Tam,:TangPhu_Lan,:TangPhu_Ty,:TangPhu_Phe,:TangPhu_Than,:TangPhu_TamBao,:TangPhu_TieuTruong,:TangPhu_Dom,:TangPhu_Vi,:TangPhu_DaiTruong,:TangPhu_BangQuang,:TangPhu_TamTieu,:TangPhu_PhuKyHang,:KinhMach_Tam,:DauDau_DauThat,:DauDau_Khac,:Mat_Dau,:Mat_Khac,:Mui_Khac,:Hong_Khac,:KinhMach_Lan,:KinhMach_Ty,:KinhMach_Phe,:KinhMach_Than,:KinhMach_TamBao,:KinhMach_TieuTruong,:KinhMach_Dom,:KinhMach_Vi,:KinhMach_DaiTruong,:KinhMach_BangQuang,:KinhMach_TamTieu,:KinhMach_MachDoc,:KinhMach_MachNham,:BatCuong_Bieu,:BatCuong_Ly,:BatCuong_Hu,:BatCuong_Thuc,:BatCuong_Han,:BatCuong_Nhiet,:BatCuong_Am,:BatCuong_Duong,:Bung,:DoiHa,:CoXuongKhop_BinhThuong,:Bung_BinhThuong,:PPKhongDungThuoc,:PPKhac,:MotaTienSuBanThan,:ChanDoanVVYHCT_BenhChinh,:ChanDoanVVYHCT_KemTheo,:MaICDChanDoanVVYHCT_BenhChinh,:MaICDChanDoanVVYHCT_KemTheo,:ChanDoanVVYHHD_BenhChinh,:ChanDoanVVYHD_KemTheo,:MaICDVVYHD_BenhChinh,:MaICDChanDoanVVYHD_KemTheo,:ChanDoanRVYHCT_BenhChinh,:ChanDoanRVYHCT_KemTheo,:MaICDChanDoanRVYHCT_BenhChinh,:MaICDChanDoanRVYHCT_KemTheo,:ChanDoanRVYHHD_BenhChinh,:ChanDoanRVYHD_KemTheo,:MaICDRVYHD_BenhChinh,:MaICDChanDoanRVYHD_KemTheo,:ChanDoan_NoiChuyenDen_YHCT,:MaICD_NoiChuyenDen_YHCT,:ChanDoan_KKB_CapCuu_YHCT,:MaICD_KKB_CapCuu_YHCT,:HOSOKQ_XQUANG,:HOSOKQ_CTSCANNER,:HOSOKQ_MRI,:HOSOKQ_KHAC_TXT,:HOSOKQ_KHAC,:HOSOKQ_TOANBOHOSO,:BenhChinh_YHCT,:MaICD_BenhChinh_YHCT,:BenhKemTheo_YHCT,:MaICD_BenhKemTheo_YHCT,:ThuThuat_YHCT,:PhauThuat_YHCT,:BenhChinh_RV_YHCT,:MaICD_BenhChinh_RV_YHCT,:BenhKemTheo_RV_YHCT,:MaICD_BenhKemTheo_RV_YHCT,:TaiBien_YHCT,:BienChung_YHCT,:MaICD_BenhKemTheo_YHHD,:MaICD_BenhChinh_YHHD_CD,:MaICD_BenhKemTheo_YHHD_CD,:CheDoDinhDuong_Long ,:CheDoDinhDuong_Dac  ,:CheDoDinhDuong_Kieng    ,:CheDoDinhDuong_Khac ,:CheDoChamSoc_1  ,:CheDoChamSoc_2  ,:CheDoChamSoc_3  ,:HinhThai_Beo,:HinhThai_CanDoi,:HinhThai_NamCo,:HinhThai_UaTinh,:HinhThai_NamDuoi,:HinhThai_HieuDong,:HinhThai_Khac,:Than_ConThan,:Than_KhongConThan,:Than_Khac,:Sac_BechTrang,:Sac_Do,:Sac_Vang,:Sac_Xanh,:Sac_Den,:Sac_Khac,:Sac_BinhThuong,:Trach_TuoiNhuan,:Trach_Kho,:Trach_Khac,:ChatLuoi_BinhThuong,:ChatLuoi_Beu,:ChatLuoi_GayMong,:ChatLuoi_Nut,:ChatLuoi_Cung,:ChatLuoi_Loet,:ChatLuoi_Lech,:ChatLuoi_Rut,:ChatLuoi_Khac,:SacLuoi_Hong,:SacLuoi_Nhot,:SacLuoi_Do,:SacLuoi_DoSam,:SacLuoi_XanhTim,:SacLuoi_DamUHuyet,:SacLuoi_Kho,:SacLuoi_Nhuan,:SacLuoi_Khac,:ReuLuoi_Co,:ReuLuoi_Khong,:ReuLuoi_Bong,:ReuLuoi_Day,:ReuLuoi_Mong,:ReuLuoi_Uot,:ReuLuoi_Kho,:ReuLuoi_Dinh,:ReuLuoi_Trang,:ReuLuoi_Vang,:ReuLuoi_Den,:ReuLuoi_Khac,:MoTaVongChan,:TiengNoi_BinhThuong,:TiengNoi_To,:TiengNoi_Nho,:TiengNoi_DutQuang,:TiengNoi_Khan,:TiengNoi_Ngong,:TiengNoi_Mat,:TiengNoi_Khac,:HoiTho_BinhThuong,:HoiTho_DutQuang,:HoiTho_Ngan,:HoiTho_Manh,:HoiTho_Yeu,:HoiTho_Tho,:HoiTho_Rit,:HoiTho_KhoKhe,:HoiTho_Cham,:HoiTho_Gap,:HoiTho_Khac,:Ho,:Ho_HoLienTuc,:Ho_Con,:Ho_It,:Ho_Nhieu,:Ho_Khan,:Ho_CoDom,:Ho_Khac,:O,:Nac,:MuiCoThe,:MuiCoThe_Chua,:MuiCoThe_Kham,:MuiCoThe_Tanh,:MuiCoThe_Thoi,:MuiCoThe_Hoi,:MuiCoThe_Khac,:ChatThaiBieuHienBenhLy,:ChatThai_Dom,:ChatThai_ChatNon,:ChatThai_Phan,:ChatThai_NuocTieu,:ChatThai_KhiHu,:ChatThai_KinhNguyet,:ChatThai_Khac,:MoTaVanChan,:HanNhiet_BinhThuong,:HanNhiet_Han,:HanNhiet_Nhiet,:HanNhiet_Khac,:HanNhiet_ThichNong,:HanNhiet_SoNong,:HanNhiet_ThichMat,:HanNhiet_SoLanh,:HanNhiet_TrongNguoiNong,:HanNhiet_TrongNguoiLanh,:HanNhiet_RetRun,:HanNhiet_HanNhietVangLai,:HanNhiet_Khac2,:MoHoi_BinhThuong_ThietChan,:MoHoi_BinhThuong,:MoHoi_KhongCoMoHoi,:MoHoi_TuHan,:MoHoi_DaoHan,:MoHoi_Nhieu,:MoHoi_It,:MoHoi_Khac,:DauMat,:DauDau_MotCho,:DauDau_NuaDau,:DauDau_CaDau,:DauDau_DiChuyen,:DauDau_EAmNhuBiBuocLai,:DauDau_Nhoi,:DauDau_Cang,:DauDau_NangDau,:Mat_HoaMatChongMat,:Mat_NhinKhongRo,:Tai_U,:Tai_Diec,:Tai_Nang,:Tai_,:Tai_Dau,:Mui_Ngat,:Mui_ChayNuoc,:Mui_ChayMauCam,:Mui_Dau,:Hong_Dau,:Hong_Kho,:CoVai_Moi,:CoVai_Dau,:CoVai_KhoVanDong,:CoVai_Khac,:Lung,:Lung_Dau,:Lung_KhoVanDong,:Lung_CoCungCo,:Lung_Khac,:BungVaUc,:BungNguc_Tuc,:BungNguc_Dau,:BungNguc_Soi,:BungNguc_NongRuot,:BungNguc_DayTruong,:BungNguc_NgotNgatKhoTho,:BungNguc_DauTucCanhSuon,:BungNguc_BonChonKhongYen,:BungNguc_DanhTrongNguc,:BungNguc_Khac,:ChanTay,:An,:An_ThichNong,:An_ThichMat,:An_AnNhieu,:An_AnIt,:An_DangMieng,:An_NhatMieng,:An_ThemAn,:An_ChanAn,:An_AnVaoBungChuong,:An_Khac,:Uong,:Uong_Mat,:Uong_AmNong,:Uong_Nhieu,:Uong_It,:Uong_Khac,:DaiTieuTien,:Tieutien_Vang,:Tieutien_Do,:Tieutien_Duc,:Tieutien_Buot,:Tieutien_Dat,:Tieutien_KhongTuChu,:Tieutien_Bi,:Tieutien_Khac,:Daitien_Tao,:Daitien_Nhao,:Daitien_Song,:Daitien_ToanNuoc,:Daitien_NhayMui,:Daitien_Bi,:Daitien_Khac,:Ngu,:Ngu_KhoVaoGiacNgu,:Ngu_HayTinh,:Ngu_DaySom,:Ngu_HayMo,:Ngu_Khac,:KinhNguyet,:KinhNguyet_DenTruocKy,:KinhNguyet_DenSauKy,:KinhNguyet_LucDenTruocLucDenS,:KinhNguyet_TacKinh,:KinhNguyet_Khac,:ThongKinh_DauTruocKy,:ThongKinh_DauTrongKy,:ThongKinh_DauSauKy,:ThongKinh_Khac,:DoiHa_Vang,:DoiHa_Trang,:DoiHa_Hoi,:DoiHa_Hong,:DoiHa_Khac,:RoiHanKhaNangSinhDuc,:Nam_YeuKhiGiaoHop,:Nam_LietDuong,:Nam_DiTinh,:Nam_HoatTinh,:Nam_MongTinh,:Nam_LanhTinh,:Nu_KhongThuThai,:Nu_SayThai_DongThai,:Nu_SayThaiLienTiep,:Nu_Khac,:DieuKienXuatHienBenh,:MoTaVaanChan,:Da_BinhThuong,:Da_Kho,:Da_Nong,:Da_Lanh,:Da_Uot,:Da_ChanTayNong,:Da_ChanTayLanh,:Da_AnLom,:Da_AnDau,:Da_CucCung,:Da_Khac,:MoHoi_ToanThan,:MoHoi_Tran,:MoHoi_TayChan,:MoHoi_KhacXucChan,:CoXuongKhop_SanChac,:CoXuongKhop_Mem,:CoXuongKhop_CangCung,:CoXuongKhop_CoCoAnDau,:CoXuongKhop_GanDau,:CoXuongKhop_XuongKhopDau,:CoXuongKhop_Khac,:Bung_Mem,:Bung_Chuong,:Bung_CoChuong,:Bung_CoHonCuc,:Bung_DauThienAn,:Bung_DauCuAn,:Bung_Khac,:MacChan_Phu,:MacChan_Tram,:MacChan_Tri,:MacChan_Sac,:MacChan_Te,:MacChan_Huyen,:MacChan_Hoat,:MacChan_VoLuc,:MacChan_CoLuc,:MacChan_Khac,:BenPhai_TongKhan,:BenTrai_TongKhan,:Ma_BenPhai_TongKhan,:Ma_BenTrai_TongKhan,:MachTayTrai_Thon1,:MachTayTrai_Thon2,:MachTayTrai_Thon3,:MachTayTrai_Thon4,:MachTayTrai_Quan1,:MachTayTrai_Quan2,:MachTayTrai_Quan3,:MachTayTrai_Quan4,:MachTayTrai_Xich1,:MachTayTrai_Xich2,:MachTayTrai_Xich3,:MachTayTrai_Xich4,:MachTayPhai_Thon1,:MachTayPhai_Thon2,:MachTayPhai_Thon3,:MachTayPhai_Thon4,:MachTayPhai_Quan1,:MachTayPhai_Quan2,:MachTayPhai_Quan3,:MachTayPhai_Quan4,:MachTayPhai_Xich1,:MachTayPhai_Xich2,:MachTayPhai_Xich3,:MachTayPhai_Xich4,:MoTaThietChan,:TomTatTuChan,:BienPhapLuanTri,:BietDanh,:BatCuong,:TangPhuKinhLac,:NguyenNhan,:DieuTriYHCT,:PhapDieuTri,:PhuongThuoc,:PhuongHuyet,:XoaBopBamHuyet,:Khac_DieuTri,:DieuTriKetHopVoiYHHD,:DieuTriKetHopVoiYHHD_Text,:CheDoDinhDuong,:CheDoChamSoc,:ChanDoanVaoVienTheoYHCT,:ChanDoanVaoVienTheoYHHD,:PhuongPhapDieuTriTheoYHHD,:PhuongPhapDieuTriTheoYHCT,:ChanDoanRaVienTheoYHCT,:ChanDoanRaVienTheoYHHD,:KetQuaDieuTriID,:TinhTrangNguoiBenhKhiRavien)";
            Command = new MDB.MDBCommand(sql, MyConnection);
            Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", BenhAnNoiTruYHCT.MaQuanLy));
            Command.Parameters.Add(new MDB.MDBParameter("LyDoVaoVien", BenhAnNoiTruYHCT.LyDoVaoVien));
            Command.Parameters.Add(new MDB.MDBParameter("VaoNgayThu", BenhAnNoiTruYHCT.VaoNgayThu));
            Command.Parameters.Add(new MDB.MDBParameter("QuaTrinhBenhLy", BenhAnNoiTruYHCT.QuaTrinhBenhLy));
            Command.Parameters.Add(new MDB.MDBParameter("TienSuBenhBanThan", BenhAnNoiTruYHCT.TienSuBenhBanThan));
            Command.Parameters.Add(new MDB.MDBParameter("TienSuBenhGiaDinh", BenhAnNoiTruYHCT.TienSuBenhGiaDinh));
            Command.Parameters.Add(new MDB.MDBParameter("ToanThan", BenhAnNoiTruYHCT.ToanThan));
            Command.Parameters.Add(new MDB.MDBParameter("TuanHoan", BenhAnNoiTruYHCT.TuanHoan));
            Command.Parameters.Add(new MDB.MDBParameter("HoHap", BenhAnNoiTruYHCT.HoHap));
            Command.Parameters.Add(new MDB.MDBParameter("TieuHoa", BenhAnNoiTruYHCT.TieuHoa));
            Command.Parameters.Add(new MDB.MDBParameter("ThanTietNieuSinhDuc", BenhAnNoiTruYHCT.ThanTietNieuSinhDuc));
            Command.Parameters.Add(new MDB.MDBParameter("ThanKinh", BenhAnNoiTruYHCT.ThanKinh));
            Command.Parameters.Add(new MDB.MDBParameter("CoXuongKhop", BenhAnNoiTruYHCT.CoXuongKhop));
            Command.Parameters.Add(new MDB.MDBParameter("TaiMuiHong", BenhAnNoiTruYHCT.TaiMuiHong));
            Command.Parameters.Add(new MDB.MDBParameter("RangHamMat", BenhAnNoiTruYHCT.RangHamMat));
            Command.Parameters.Add(new MDB.MDBParameter("Mat", BenhAnNoiTruYHCT.Mat));
            Command.Parameters.Add(new MDB.MDBParameter("Khac_CacCoQuan", BenhAnNoiTruYHCT.Khac_CacCoQuan));
            Command.Parameters.Add(new MDB.MDBParameter("CacXetNghiemCanLamSangCanLam", BenhAnNoiTruYHCT.CacXetNghiemCanLamSangCanLam));
            Command.Parameters.Add(new MDB.MDBParameter("TomTatBenhAn", BenhAnNoiTruYHCT.TomTatBenhAn));
            Command.Parameters.Add(new MDB.MDBParameter("BenhChinh", BenhAnNoiTruYHCT.BenhChinh));
            Command.Parameters.Add(new MDB.MDBParameter("BenhKemTheo", BenhAnNoiTruYHCT.BenhKemTheo));
            Command.Parameters.Add(new MDB.MDBParameter("PhanBiet", BenhAnNoiTruYHCT.PhanBiet));
            Command.Parameters.Add(new MDB.MDBParameter("TienLuong", BenhAnNoiTruYHCT.TienLuong));
            Command.Parameters.Add(new MDB.MDBParameter("HuongDieuTri", BenhAnNoiTruYHCT.HuongDieuTri));
            Command.Parameters.Add(new MDB.MDBParameter("NgayKhamBenh", BenhAnNoiTruYHCT.NgayKhamBenh));
            Command.Parameters.Add(new MDB.MDBParameter("BacSyLamBenhAn", BenhAnNoiTruYHCT.BacSyLamBenhAn));
            Command.Parameters.Add(new MDB.MDBParameter("QuaTrinhBenhLyVaDienBien", BenhAnNoiTruYHCT.QuaTrinhBenhLyVaDienBien));
            Command.Parameters.Add(new MDB.MDBParameter("TomTatKetQuaXetNghiem", BenhAnNoiTruYHCT.TomTatKetQuaXetNghiem));
            Command.Parameters.Add(new MDB.MDBParameter("PhuongPhapDieuTri", BenhAnNoiTruYHCT.PhuongPhapDieuTri));
            Command.Parameters.Add(new MDB.MDBParameter("TinhTrangNguoiBenhRaVien", BenhAnNoiTruYHCT.TinhTrangNguoiBenhRaVien));
            Command.Parameters.Add(new MDB.MDBParameter("HuongDieuTriVaCacCheDoTiepTheo", BenhAnNoiTruYHCT.HuongDieuTriVaCacCheDoTiepTheo));
            Command.Parameters.Add(new MDB.MDBParameter("NguoiNhanHoSo", BenhAnNoiTruYHCT.NguoiNhanHoSo));
            Command.Parameters.Add(new MDB.MDBParameter("NguoiGiaoHoSo", BenhAnNoiTruYHCT.NguoiGiaoHoSo));
            Command.Parameters.Add(new MDB.MDBParameter("NgayTongKet", BenhAnNoiTruYHCT.NgayTongKet));
            Command.Parameters.Add(new MDB.MDBParameter("BacSyDieuTri", BenhAnNoiTruYHCT.BacSyDieuTri));
            Command.Parameters.Add(new MDB.MDBParameter("DiUng", BenhAnNoiTruYHCT.DacDiemLienQuanBenh.DiUng == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("DiUng_Text", BenhAnNoiTruYHCT.DacDiemLienQuanBenh.DiUng_Text));
            Command.Parameters.Add(new MDB.MDBParameter("MaTuy", BenhAnNoiTruYHCT.DacDiemLienQuanBenh.MaTuy == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("MaTuy_Text", BenhAnNoiTruYHCT.DacDiemLienQuanBenh.MaTuy_Text));
            Command.Parameters.Add(new MDB.MDBParameter("RuouBia", BenhAnNoiTruYHCT.DacDiemLienQuanBenh.RuouBia == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("RuouBia_Text", BenhAnNoiTruYHCT.DacDiemLienQuanBenh.RuouBia_Text));
            Command.Parameters.Add(new MDB.MDBParameter("ThuocLa", BenhAnNoiTruYHCT.DacDiemLienQuanBenh.ThuocLa == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("ThuocLa_Text", BenhAnNoiTruYHCT.DacDiemLienQuanBenh.ThuocLa_Text));
            Command.Parameters.Add(new MDB.MDBParameter("ThuocLao", BenhAnNoiTruYHCT.DacDiemLienQuanBenh.ThuocLao == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("ThuocLao_Text", BenhAnNoiTruYHCT.DacDiemLienQuanBenh.ThuocLao_Text));
            Command.Parameters.Add(new MDB.MDBParameter("Khac_DacDiemLienQuanBenh", BenhAnNoiTruYHCT.DacDiemLienQuanBenh.Khac_DacDiemLienQuanBenh == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("Khac_DacDiemLienQuanBenh_Text", BenhAnNoiTruYHCT.DacDiemLienQuanBenh.Khac_DacDiemLienQuanBenh_Text));
            Command.Parameters.Add(new MDB.MDBParameter("BenhSu", BenhAnNoiTruYHCT.BenhSu));
            Command.Parameters.Add(new MDB.MDBParameter("MoTaChiTietCoQuanBenhLy", BenhAnNoiTruYHCT.MoTaChiTietCoQuanBenhLy));
            Command.Parameters.Add(new MDB.MDBParameter("HinhThai_Gay", BenhAnNoiTruYHCT.HinhThai_Gay == true ? "1" : "0"));
            // add
            Command.Parameters.Add(new MDB.MDBParameter("Bung_Dau", BenhAnNoiTruYHCT.Bung_Dau == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("ChanTay_Dau", BenhAnNoiTruYHCT.ChanTay_Dau == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("ChanTay_Te", BenhAnNoiTruYHCT.ChanTay_Te == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("ChanTay_Buon", BenhAnNoiTruYHCT.ChanTay_Buon == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("ChanTay_Moi", BenhAnNoiTruYHCT.ChanTay_Moi == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("ChanTay_Nhuc", BenhAnNoiTruYHCT.ChanTay_Nhuc == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("ChanTay_Nong", BenhAnNoiTruYHCT.ChanTay_Nong == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("ChanTay_Lanh", BenhAnNoiTruYHCT.ChanTay_Lanh == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("ChanTay_Khac", BenhAnNoiTruYHCT.ChanTay_Khac == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("Nam_Khac", BenhAnNoiTruYHCT.Nam_Khac == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("Nu_DongThai", BenhAnNoiTruYHCT.Nu_DongThai == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("Nu_SayThai", BenhAnNoiTruYHCT.Nu_SayThai == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("MacChan_Nhu", BenhAnNoiTruYHCT.MacChan_Nhu == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("DinhViBenhTheo_Ve", BenhAnNoiTruYHCT.DinhViBenhTheo_Ve == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("DinhViBenhTheo_Khi", BenhAnNoiTruYHCT.DinhViBenhTheo_Khi == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("DinhViBenhTheo_Dinh", BenhAnNoiTruYHCT.DinhViBenhTheo_Dinh == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("DinhViBenhTheo_Huyet", BenhAnNoiTruYHCT.DinhViBenhTheo_Huyet == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("NguyenNhan_NoiNhan", BenhAnNoiTruYHCT.NguyenNhan_NoiNhan == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("NguyenNhan_NgoaiNhan", BenhAnNoiTruYHCT.NguyenNhan_NgoaiNhan == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("NguyenNhan_BatNoiNgoai", BenhAnNoiTruYHCT.NguyenNhan_BatNoiNgoai == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("TangPhu_Tam", BenhAnNoiTruYHCT.TangPhu_Tam == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("TangPhu_Lan", BenhAnNoiTruYHCT.TangPhu_Lan == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("TangPhu_Ty", BenhAnNoiTruYHCT.TangPhu_Ty == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("TangPhu_Phe", BenhAnNoiTruYHCT.TangPhu_Phe == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("TangPhu_Than", BenhAnNoiTruYHCT.TangPhu_Than == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("TangPhu_TamBao", BenhAnNoiTruYHCT.TangPhu_TamBao == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("TangPhu_TieuTruong", BenhAnNoiTruYHCT.TangPhu_TieuTruong == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("TangPhu_Dom", BenhAnNoiTruYHCT.TangPhu_Dom == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("TangPhu_Vi", BenhAnNoiTruYHCT.TangPhu_Vi == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("TangPhu_DaiTruong", BenhAnNoiTruYHCT.TangPhu_DaiTruong == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("TangPhu_BangQuang", BenhAnNoiTruYHCT.TangPhu_BangQuang == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("TangPhu_TamTieu", BenhAnNoiTruYHCT.TangPhu_TamTieu == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("TangPhu_PhuKyHang", BenhAnNoiTruYHCT.TangPhu_PhuKyHang == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("KinhMach_Tam", BenhAnNoiTruYHCT.KinhMach_Tam == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("DauDau_DauThat", BenhAnNoiTruYHCT.DauDau_DauThat == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("DauDau_Khac", BenhAnNoiTruYHCT.DauDau_Khac == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("Mat_Dau", BenhAnNoiTruYHCT.Mat_Dau == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("Mat_Khac", BenhAnNoiTruYHCT.Mat_Khac == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("Mui_Khac", BenhAnNoiTruYHCT.Mui_Khac == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("Hong_Khac", BenhAnNoiTruYHCT.Hong_Khac == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("KinhMach_Lan", BenhAnNoiTruYHCT.KinhMach_Lan == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("KinhMach_Ty", BenhAnNoiTruYHCT.KinhMach_Ty == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("KinhMach_Phe", BenhAnNoiTruYHCT.KinhMach_Phe == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("KinhMach_Than", BenhAnNoiTruYHCT.KinhMach_Than == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("KinhMach_TamBao", BenhAnNoiTruYHCT.KinhMach_TamBao == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("KinhMach_TieuTruong", BenhAnNoiTruYHCT.KinhMach_TieuTruong == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("KinhMach_Dom", BenhAnNoiTruYHCT.KinhMach_Dom == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("KinhMach_Vi", BenhAnNoiTruYHCT.KinhMach_Vi == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("KinhMach_DaiTruong", BenhAnNoiTruYHCT.KinhMach_DaiTruong == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("KinhMach_BangQuang", BenhAnNoiTruYHCT.KinhMach_BangQuang == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("KinhMach_TamTieu", BenhAnNoiTruYHCT.KinhMach_TamTieu == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("KinhMach_MachDoc", BenhAnNoiTruYHCT.KinhMach_MachDoc == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("KinhMach_MachNham", BenhAnNoiTruYHCT.KinhMach_MachNham == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("BatCuong_Bieu", BenhAnNoiTruYHCT.BatCuong_Bieu == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("BatCuong_Ly", BenhAnNoiTruYHCT.BatCuong_Ly == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("BatCuong_Hu", BenhAnNoiTruYHCT.BatCuong_Hu == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("BatCuong_Thuc", BenhAnNoiTruYHCT.BatCuong_Thuc == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("BatCuong_Han", BenhAnNoiTruYHCT.BatCuong_Han == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("BatCuong_Nhiet", BenhAnNoiTruYHCT.BatCuong_Nhiet == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("BatCuong_Am", BenhAnNoiTruYHCT.BatCuong_Am == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("BatCuong_Duong", BenhAnNoiTruYHCT.BatCuong_Duong == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("Bung", BenhAnNoiTruYHCT.Bung == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("DoiHa", BenhAnNoiTruYHCT.DoiHa == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("CoXuongKhop_BinhThuong", BenhAnNoiTruYHCT.CoXuongKhop_BinhThuong == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("Bung_BinhThuong", BenhAnNoiTruYHCT.Bung_BinhThuong == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("PPKhongDungThuoc", BenhAnNoiTruYHCT.PPKhongDungThuoc));
            Command.Parameters.Add(new MDB.MDBParameter("PPKhac", BenhAnNoiTruYHCT.PPKhac));
            Command.Parameters.Add(new MDB.MDBParameter("MotaTienSuBanThan", BenhAnNoiTruYHCT.MotaTienSuBanThan));
            Command.Parameters.Add(new MDB.MDBParameter("ChanDoanVVYHCT_BenhChinh", BenhAnNoiTruYHCT.ChanDoanVVYHCT_BenhChinh));
            Command.Parameters.Add(new MDB.MDBParameter("ChanDoanVVYHCT_KemTheo", BenhAnNoiTruYHCT.ChanDoanVVYHCT_KemTheo));
            Command.Parameters.Add(new MDB.MDBParameter("MaICDChanDoanVVYHCT_BenhChinh", BenhAnNoiTruYHCT.MaICDChanDoanVVYHCT_BenhChinh));
            Command.Parameters.Add(new MDB.MDBParameter("MaICDChanDoanVVYHCT_KemTheo", BenhAnNoiTruYHCT.MaICDChanDoanVVYHCT_KemTheo));
            Command.Parameters.Add(new MDB.MDBParameter("ChanDoanVVYHHD_BenhChinh", BenhAnNoiTruYHCT.ChanDoanVVYHHD_BenhChinh));
            Command.Parameters.Add(new MDB.MDBParameter("ChanDoanVVYHD_KemTheo", BenhAnNoiTruYHCT.ChanDoanVVYHD_KemTheo));
            Command.Parameters.Add(new MDB.MDBParameter("MaICDVVYHD_BenhChinh", BenhAnNoiTruYHCT.MaICDVVYHD_BenhChinh));
            Command.Parameters.Add(new MDB.MDBParameter("MaICDChanDoanVVYHD_KemTheo", BenhAnNoiTruYHCT.MaICDChanDoanVVYHD_KemTheo));
            Command.Parameters.Add(new MDB.MDBParameter("ChanDoanRVYHCT_BenhChinh", BenhAnNoiTruYHCT.ChanDoanRVYHCT_BenhChinh));
            Command.Parameters.Add(new MDB.MDBParameter("ChanDoanRVYHCT_KemTheo", BenhAnNoiTruYHCT.ChanDoanRVYHCT_KemTheo));
            Command.Parameters.Add(new MDB.MDBParameter("MaICDChanDoanRVYHCT_BenhChinh", BenhAnNoiTruYHCT.MaICDChanDoanRVYHCT_BenhChinh));
            Command.Parameters.Add(new MDB.MDBParameter("MaICDChanDoanRVYHCT_KemTheo", BenhAnNoiTruYHCT.MaICDChanDoanRVYHCT_KemTheo));
            Command.Parameters.Add(new MDB.MDBParameter("ChanDoanRVYHHD_BenhChinh", BenhAnNoiTruYHCT.ChanDoanRVYHHD_BenhChinh));
            Command.Parameters.Add(new MDB.MDBParameter("ChanDoanRVYHD_KemTheo", BenhAnNoiTruYHCT.ChanDoanRVYHD_KemTheo));
            Command.Parameters.Add(new MDB.MDBParameter("MaICDRVYHD_BenhChinh", BenhAnNoiTruYHCT.MaICDRVYHD_BenhChinh));
            Command.Parameters.Add(new MDB.MDBParameter("MaICDChanDoanRVYHD_KemTheo", BenhAnNoiTruYHCT.MaICDChanDoanRVYHD_KemTheo));

            Command.Parameters.Add(new MDB.MDBParameter("ChanDoan_NoiChuyenDen_YHCT", BenhAnNoiTruYHCT.ChanDoan_NoiChuyenDen_YHCT));
            Command.Parameters.Add(new MDB.MDBParameter("MaICD_NoiChuyenDen_YHCT", BenhAnNoiTruYHCT.MaICD_NoiChuyenDen_YHCT));
            Command.Parameters.Add(new MDB.MDBParameter("ChanDoan_KKB_CapCuu_YHCT", BenhAnNoiTruYHCT.ChanDoan_KKB_CapCuu_YHCT));
            Command.Parameters.Add(new MDB.MDBParameter("MaICD_KKB_CapCuu_YHCT", BenhAnNoiTruYHCT.MaICD_KKB_CapCuu_YHCT));
            Command.Parameters.Add(new MDB.MDBParameter("HOSOKQ_XQUANG", BenhAnNoiTruYHCT.HOSOKQ_XQUANG));
            Command.Parameters.Add(new MDB.MDBParameter("HOSOKQ_CTSCANNER", BenhAnNoiTruYHCT.HOSOKQ_CTSCANNER));
            Command.Parameters.Add(new MDB.MDBParameter("HOSOKQ_MRI", BenhAnNoiTruYHCT.HOSOKQ_MRI));
            Command.Parameters.Add(new MDB.MDBParameter("HOSOKQ_KHAC_TXT", BenhAnNoiTruYHCT.HOSOKQ_KHAC_TXT));
            Command.Parameters.Add(new MDB.MDBParameter("HOSOKQ_KHAC", BenhAnNoiTruYHCT.HOSOKQ_KHAC));
            Command.Parameters.Add(new MDB.MDBParameter("HOSOKQ_TOANBOHOSO", BenhAnNoiTruYHCT.HOSOKQ_TOANBOHOSO));
            Command.Parameters.Add(new MDB.MDBParameter("BenhChinh_YHCT", BenhAnNoiTruYHCT.BenhChinh_YHCT));
            Command.Parameters.Add(new MDB.MDBParameter("MaICD_BenhChinh_YHCT", BenhAnNoiTruYHCT.MaICD_BenhChinh_YHCT));
            Command.Parameters.Add(new MDB.MDBParameter("BenhKemTheo_YHCT", BenhAnNoiTruYHCT.BenhKemTheo_YHCT));
            Command.Parameters.Add(new MDB.MDBParameter("MaICD_BenhKemTheo_YHCT", BenhAnNoiTruYHCT.MaICD_BenhKemTheo_YHCT));
            Command.Parameters.Add(new MDB.MDBParameter("ThuThuat_YHCT", BenhAnNoiTruYHCT.ThuThuat_YHCT == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("PhauThuat_YHCT", BenhAnNoiTruYHCT.PhauThuat_YHCT == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("BenhChinh_RV_YHCT", BenhAnNoiTruYHCT.BenhChinh_RV_YHCT));
            Command.Parameters.Add(new MDB.MDBParameter("MaICD_BenhChinh_RV_YHCT", BenhAnNoiTruYHCT.MaICD_BenhChinh_RV_YHCT));
            Command.Parameters.Add(new MDB.MDBParameter("BenhKemTheo_RV_YHCT", BenhAnNoiTruYHCT.BenhKemTheo_RV_YHCT));
            Command.Parameters.Add(new MDB.MDBParameter("MaICD_BenhKemTheo_RV_YHCT", BenhAnNoiTruYHCT.MaICD_BenhKemTheo_RV_YHCT));
            Command.Parameters.Add(new MDB.MDBParameter("TaiBien_YHCT", BenhAnNoiTruYHCT.TaiBien_YHCT == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("BienChung_YHCT", BenhAnNoiTruYHCT.BienChung_YHCT == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("MaICD_BenhKemTheo_YHHD", BenhAnNoiTruYHCT.MaICD_BenhKemTheo_YHHD));
            Command.Parameters.Add(new MDB.MDBParameter("MaICD_BenhChinh_YHHD_CD", BenhAnNoiTruYHCT.MaICD_BenhChinh_YHHD_CD));
            Command.Parameters.Add(new MDB.MDBParameter("MaICD_BenhKemTheo_YHHD_CD", BenhAnNoiTruYHCT.MaICD_BenhKemTheo_YHHD_CD));
            Command.Parameters.Add(new MDB.MDBParameter("CheDoDinhDuong_Long", BenhAnNoiTruYHCT.CheDoDinhDuong_Long == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("CheDoDinhDuong_Dac", BenhAnNoiTruYHCT.CheDoDinhDuong_Dac == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("CheDoDinhDuong_Kieng", BenhAnNoiTruYHCT.CheDoDinhDuong_Kieng == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("CheDoDinhDuong_Khac", BenhAnNoiTruYHCT.CheDoDinhDuong_Khac == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("CheDoChamSoc_1", BenhAnNoiTruYHCT.CheDoChamSoc_1 == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("CheDoChamSoc_2", BenhAnNoiTruYHCT.CheDoChamSoc_2 == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("CheDoChamSoc_3", BenhAnNoiTruYHCT.CheDoChamSoc_3 == true ? "1" : "0"));
            //
            Command.Parameters.Add(new MDB.MDBParameter("HinhThai_Beo", BenhAnNoiTruYHCT.HinhThai_Beo == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("HinhThai_CanDoi", BenhAnNoiTruYHCT.HinhThai_CanDoi == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("HinhThai_NamCo", BenhAnNoiTruYHCT.HinhThai_NamCo == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("HinhThai_UaTinh", BenhAnNoiTruYHCT.HinhThai_UaTinh == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("HinhThai_NamDuoi", BenhAnNoiTruYHCT.HinhThai_NamDuoi == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("HinhThai_HieuDong", BenhAnNoiTruYHCT.HinhThai_HieuDong == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("HinhThai_Khac", BenhAnNoiTruYHCT.HinhThai_Khac == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("Than_ConThan", BenhAnNoiTruYHCT.Than_ConThan == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("Than_KhongConThan", BenhAnNoiTruYHCT.Than_KhongConThan == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("Than_Khac", BenhAnNoiTruYHCT.Than_Khac == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("Sac_BechTrang", BenhAnNoiTruYHCT.Sac_BechTrang == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("Sac_Do", BenhAnNoiTruYHCT.Sac_Do == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("Sac_Vang", BenhAnNoiTruYHCT.Sac_Vang == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("Sac_Xanh", BenhAnNoiTruYHCT.Sac_Xanh == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("Sac_Den", BenhAnNoiTruYHCT.Sac_Den == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("Sac_Khac", BenhAnNoiTruYHCT.Sac_Khac == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("Sac_BinhThuong", BenhAnNoiTruYHCT.Sac_BinhThuong == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("Trach_TuoiNhuan", BenhAnNoiTruYHCT.Trach_TuoiNhuan == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("Trach_Kho", BenhAnNoiTruYHCT.Trach_Kho == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("Trach_Khac", BenhAnNoiTruYHCT.Trach_Khac == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("ChatLuoi_BinhThuong", BenhAnNoiTruYHCT.ChatLuoi_BinhThuong == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("ChatLuoi_Beu", BenhAnNoiTruYHCT.ChatLuoi_Beu == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("ChatLuoi_GayMong", BenhAnNoiTruYHCT.ChatLuoi_GayMong == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("ChatLuoi_Nut", BenhAnNoiTruYHCT.ChatLuoi_Nut == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("ChatLuoi_Cung", BenhAnNoiTruYHCT.ChatLuoi_Cung == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("ChatLuoi_Loet", BenhAnNoiTruYHCT.ChatLuoi_Loet == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("ChatLuoi_Lech", BenhAnNoiTruYHCT.ChatLuoi_Lech == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("ChatLuoi_Rut", BenhAnNoiTruYHCT.ChatLuoi_Rut == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("ChatLuoi_Khac", BenhAnNoiTruYHCT.ChatLuoi_Khac == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("SacLuoi_Hong", BenhAnNoiTruYHCT.SacLuoi_Hong == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("SacLuoi_Nhot", BenhAnNoiTruYHCT.SacLuoi_Nhot == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("SacLuoi_Do", BenhAnNoiTruYHCT.SacLuoi_Do == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("SacLuoi_DoSam", BenhAnNoiTruYHCT.SacLuoi_DoSam == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("SacLuoi_XanhTim", BenhAnNoiTruYHCT.SacLuoi_XanhTim == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("SacLuoi_DamUHuyet", BenhAnNoiTruYHCT.SacLuoi_DamUHuyet == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("SacLuoi_Kho", BenhAnNoiTruYHCT.SacLuoi_Kho == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("SacLuoi_Nhuan", BenhAnNoiTruYHCT.SacLuoi_Nhuan == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("SacLuoi_Khac", BenhAnNoiTruYHCT.SacLuoi_Khac == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("ReuLuoi_Co", BenhAnNoiTruYHCT.ReuLuoi_Co == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("ReuLuoi_Khong", BenhAnNoiTruYHCT.ReuLuoi_Khong == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("ReuLuoi_Bong", BenhAnNoiTruYHCT.ReuLuoi_Bong == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("ReuLuoi_Day", BenhAnNoiTruYHCT.ReuLuoi_Day == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("ReuLuoi_Mong", BenhAnNoiTruYHCT.ReuLuoi_Mong == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("ReuLuoi_Uot", BenhAnNoiTruYHCT.ReuLuoi_Uot == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("ReuLuoi_Kho", BenhAnNoiTruYHCT.ReuLuoi_Kho == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("ReuLuoi_Dinh", BenhAnNoiTruYHCT.ReuLuoi_Dinh == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("ReuLuoi_Trang", BenhAnNoiTruYHCT.ReuLuoi_Trang == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("ReuLuoi_Vang", BenhAnNoiTruYHCT.ReuLuoi_Vang == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("ReuLuoi_Den", BenhAnNoiTruYHCT.ReuLuoi_Den == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("ReuLuoi_Khac", BenhAnNoiTruYHCT.ReuLuoi_Khac == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("MoTaVongChan", BenhAnNoiTruYHCT.MoTaVongChan));
            Command.Parameters.Add(new MDB.MDBParameter("TiengNoi_BinhThuong", BenhAnNoiTruYHCT.TiengNoi_BinhThuong == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("TiengNoi_To", BenhAnNoiTruYHCT.TiengNoi_To == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("TiengNoi_Nho", BenhAnNoiTruYHCT.TiengNoi_Nho == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("TiengNoi_DutQuang", BenhAnNoiTruYHCT.TiengNoi_DutQuang == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("TiengNoi_Khan", BenhAnNoiTruYHCT.TiengNoi_Khan == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("TiengNoi_Ngong", BenhAnNoiTruYHCT.TiengNoi_Ngong == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("TiengNoi_Mat", BenhAnNoiTruYHCT.TiengNoi_Mat == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("TiengNoi_Khac", BenhAnNoiTruYHCT.TiengNoi_Khac == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("HoiTho_BinhThuong", BenhAnNoiTruYHCT.HoiTho_BinhThuong == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("HoiTho_DutQuang", BenhAnNoiTruYHCT.HoiTho_DutQuang == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("HoiTho_Ngan", BenhAnNoiTruYHCT.HoiTho_Ngan == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("HoiTho_Manh", BenhAnNoiTruYHCT.HoiTho_Manh == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("HoiTho_Yeu", BenhAnNoiTruYHCT.HoiTho_Yeu == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("HoiTho_Tho", BenhAnNoiTruYHCT.HoiTho_Tho == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("HoiTho_Rit", BenhAnNoiTruYHCT.HoiTho_Rit == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("HoiTho_KhoKhe", BenhAnNoiTruYHCT.HoiTho_KhoKhe == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("HoiTho_Cham", BenhAnNoiTruYHCT.HoiTho_Cham == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("HoiTho_Gap", BenhAnNoiTruYHCT.HoiTho_Gap == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("HoiTho_Khac", BenhAnNoiTruYHCT.HoiTho_Khac == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("Ho", BenhAnNoiTruYHCT.Ho == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("Ho_HoLienTuc", BenhAnNoiTruYHCT.Ho_HoLienTuc == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("Ho_Con", BenhAnNoiTruYHCT.Ho_Con == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("Ho_It", BenhAnNoiTruYHCT.Ho_It == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("Ho_Nhieu", BenhAnNoiTruYHCT.Ho_Nhieu == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("Ho_Khan", BenhAnNoiTruYHCT.Ho_Khan == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("Ho_CoDom", BenhAnNoiTruYHCT.Ho_CoDom == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("Ho_Khac", BenhAnNoiTruYHCT.Ho_Khac == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("O", BenhAnNoiTruYHCT.O == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("Nac", BenhAnNoiTruYHCT.Nac == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("MuiCoThe", BenhAnNoiTruYHCT.MuiCoThe == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("MuiCoThe_Chua", BenhAnNoiTruYHCT.MuiCoThe_Chua == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("MuiCoThe_Kham", BenhAnNoiTruYHCT.MuiCoThe_Kham == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("MuiCoThe_Tanh", BenhAnNoiTruYHCT.MuiCoThe_Tanh == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("MuiCoThe_Thoi", BenhAnNoiTruYHCT.MuiCoThe_Thoi == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("MuiCoThe_Hoi", BenhAnNoiTruYHCT.MuiCoThe_Hoi == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("MuiCoThe_Khac", BenhAnNoiTruYHCT.MuiCoThe_Khac == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("ChatThaiBieuHienBenhLy", BenhAnNoiTruYHCT.ChatThaiBieuHienBenhLy == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("ChatThai_Dom", BenhAnNoiTruYHCT.ChatThai_Dom == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("ChatThai_ChatNon", BenhAnNoiTruYHCT.ChatThai_ChatNon == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("ChatThai_Phan", BenhAnNoiTruYHCT.ChatThai_Phan == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("ChatThai_NuocTieu", BenhAnNoiTruYHCT.ChatThai_NuocTieu == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("ChatThai_KhiHu", BenhAnNoiTruYHCT.ChatThai_KhiHu == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("ChatThai_KinhNguyet", BenhAnNoiTruYHCT.ChatThai_KinhNguyet == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("ChatThai_Khac", BenhAnNoiTruYHCT.ChatThai_Khac == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("MoTaVanChan", BenhAnNoiTruYHCT.MoTaVanChan));
            Command.Parameters.Add(new MDB.MDBParameter("HanNhiet_BinhThuong", BenhAnNoiTruYHCT.HanNhiet_BinhThuong == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("HanNhiet_Han", BenhAnNoiTruYHCT.HanNhiet_Han == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("HanNhiet_Nhiet", BenhAnNoiTruYHCT.HanNhiet_Nhiet == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("HanNhiet_Khac", BenhAnNoiTruYHCT.HanNhiet_Khac == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("HanNhiet_ThichNong", BenhAnNoiTruYHCT.HanNhiet_ThichNong == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("HanNhiet_SoNong", BenhAnNoiTruYHCT.HanNhiet_SoNong == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("HanNhiet_ThichMat", BenhAnNoiTruYHCT.HanNhiet_ThichMat == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("HanNhiet_SoLanh", BenhAnNoiTruYHCT.HanNhiet_SoLanh == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("HanNhiet_TrongNguoiNong", BenhAnNoiTruYHCT.HanNhiet_TrongNguoiNong == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("HanNhiet_TrongNguoiLanh", BenhAnNoiTruYHCT.HanNhiet_TrongNguoiLanh == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("HanNhiet_RetRun", BenhAnNoiTruYHCT.HanNhiet_RetRun == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("HanNhiet_HanNhietVangLai", BenhAnNoiTruYHCT.HanNhiet_HanNhietVangLai == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("HanNhiet_Khac2", BenhAnNoiTruYHCT.HanNhiet_Khac2 == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("MoHoi_BinhThuong_ThietChan", BenhAnNoiTruYHCT.MoHoi_BinhThuong_ThietChan == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("MoHoi_BinhThuong", BenhAnNoiTruYHCT.MoHoi_BinhThuong == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("MoHoi_KhongCoMoHoi", BenhAnNoiTruYHCT.MoHoi_KhongCoMoHoi == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("MoHoi_TuHan", BenhAnNoiTruYHCT.MoHoi_TuHan == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("MoHoi_DaoHan", BenhAnNoiTruYHCT.MoHoi_DaoHan == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("MoHoi_Nhieu", BenhAnNoiTruYHCT.MoHoi_Nhieu == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("MoHoi_It", BenhAnNoiTruYHCT.MoHoi_It == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("MoHoi_Khac", BenhAnNoiTruYHCT.MoHoi_Khac == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("DauMat", BenhAnNoiTruYHCT.DauMat == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("DauDau_MotCho", BenhAnNoiTruYHCT.DauDau_MotCho == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("DauDau_NuaDau", BenhAnNoiTruYHCT.DauDau_NuaDau == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("DauDau_CaDau", BenhAnNoiTruYHCT.DauDau_CaDau == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("DauDau_DiChuyen", BenhAnNoiTruYHCT.DauDau_DiChuyen == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("DauDau_EAmNhuBiBuocLai", BenhAnNoiTruYHCT.DauDau_EAmNhuBiBuocLai == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("DauDau_Nhoi", BenhAnNoiTruYHCT.DauDau_Nhoi == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("DauDau_Cang", BenhAnNoiTruYHCT.DauDau_Cang == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("DauDau_NangDau", BenhAnNoiTruYHCT.DauDau_NangDau == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("Mat_HoaMatChongMat", BenhAnNoiTruYHCT.Mat_HoaMatChongMat == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("Mat_NhinKhongRo", BenhAnNoiTruYHCT.Mat_NhinKhongRo == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("Tai_U", BenhAnNoiTruYHCT.Tai_U == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("Tai_Diec", BenhAnNoiTruYHCT.Tai_Diec == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("Tai_Nang", BenhAnNoiTruYHCT.Tai_Nang == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("Tai_", BenhAnNoiTruYHCT.Tai_ == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("Tai_Dau", BenhAnNoiTruYHCT.Tai_Dau == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("Mui_Ngat", BenhAnNoiTruYHCT.Mui_Ngat == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("Mui_ChayNuoc", BenhAnNoiTruYHCT.Mui_ChayNuoc == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("Mui_ChayMauCam", BenhAnNoiTruYHCT.Mui_ChayMauCam == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("Mui_Dau", BenhAnNoiTruYHCT.Mui_Dau == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("Hong_Dau", BenhAnNoiTruYHCT.Hong_Dau == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("Hong_Kho", BenhAnNoiTruYHCT.Hong_Kho == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("CoVai_Moi", BenhAnNoiTruYHCT.CoVai_Moi == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("CoVai_Dau", BenhAnNoiTruYHCT.CoVai_Dau == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("CoVai_KhoVanDong", BenhAnNoiTruYHCT.CoVai_KhoVanDong == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("CoVai_Khac", BenhAnNoiTruYHCT.CoVai_Khac == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("Lung", BenhAnNoiTruYHCT.Lung == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("Lung_Dau", BenhAnNoiTruYHCT.Lung_Dau == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("Lung_KhoVanDong", BenhAnNoiTruYHCT.Lung_KhoVanDong == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("Lung_CoCungCo", BenhAnNoiTruYHCT.Lung_CoCungCo == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("Lung_Khac", BenhAnNoiTruYHCT.Lung_Khac == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("BungVaUc", BenhAnNoiTruYHCT.BungVaUc == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("BungNguc_Tuc", BenhAnNoiTruYHCT.BungNguc_Tuc == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("BungNguc_Dau", BenhAnNoiTruYHCT.BungNguc_Dau == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("BungNguc_Soi", BenhAnNoiTruYHCT.BungNguc_Soi == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("BungNguc_NongRuot", BenhAnNoiTruYHCT.BungNguc_NongRuot == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("BungNguc_DayTruong", BenhAnNoiTruYHCT.BungNguc_DayTruong == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("BungNguc_NgotNgatKhoTho", BenhAnNoiTruYHCT.BungNguc_NgotNgatKhoTho == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("BungNguc_DauTucCanhSuon", BenhAnNoiTruYHCT.BungNguc_DauTucCanhSuon == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("BungNguc_BonChonKhongYen", BenhAnNoiTruYHCT.BungNguc_BonChonKhongYen == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("BungNguc_DanhTrongNguc", BenhAnNoiTruYHCT.BungNguc_DanhTrongNguc == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("BungNguc_Khac", BenhAnNoiTruYHCT.BungNguc_Khac == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("ChanTay", BenhAnNoiTruYHCT.ChanTay == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("An", BenhAnNoiTruYHCT.An == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("An_ThichNong", BenhAnNoiTruYHCT.An_ThichNong == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("An_ThichMat", BenhAnNoiTruYHCT.An_ThichMat == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("An_AnNhieu", BenhAnNoiTruYHCT.An_AnNhieu == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("An_AnIt", BenhAnNoiTruYHCT.An_AnIt == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("An_DangMieng", BenhAnNoiTruYHCT.An_DangMieng == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("An_NhatMieng", BenhAnNoiTruYHCT.An_NhatMieng == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("An_ThemAn", BenhAnNoiTruYHCT.An_ThemAn == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("An_ChanAn", BenhAnNoiTruYHCT.An_ChanAn == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("An_AnVaoBungChuong", BenhAnNoiTruYHCT.An_AnVaoBungChuong == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("An_Khac", BenhAnNoiTruYHCT.An_Khac == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("Uong", BenhAnNoiTruYHCT.Uong == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("Uong_Mat", BenhAnNoiTruYHCT.Uong_Mat == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("Uong_AmNong", BenhAnNoiTruYHCT.Uong_AmNong == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("Uong_Nhieu", BenhAnNoiTruYHCT.Uong_Nhieu == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("Uong_It", BenhAnNoiTruYHCT.Uong_It == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("Uong_Khac", BenhAnNoiTruYHCT.Uong_Khac == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("DaiTieuTien", BenhAnNoiTruYHCT.DaiTieuTien == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("Tieutien_Vang", BenhAnNoiTruYHCT.Tieutien_Vang == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("Tieutien_Do", BenhAnNoiTruYHCT.Tieutien_Do == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("Tieutien_Duc", BenhAnNoiTruYHCT.Tieutien_Duc == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("Tieutien_Buot", BenhAnNoiTruYHCT.Tieutien_Buot == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("Tieutien_Dat", BenhAnNoiTruYHCT.Tieutien_Dat == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("Tieutien_KhongTuChu", BenhAnNoiTruYHCT.Tieutien_KhongTuChu == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("Tieutien_Bi", BenhAnNoiTruYHCT.Tieutien_Bi == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("Tieutien_Khac", BenhAnNoiTruYHCT.Tieutien_Khac == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("Daitien_Tao", BenhAnNoiTruYHCT.Daitien_Tao == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("Daitien_Nhao", BenhAnNoiTruYHCT.Daitien_Nhao == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("Daitien_Song", BenhAnNoiTruYHCT.Daitien_Song == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("Daitien_ToanNuoc", BenhAnNoiTruYHCT.Daitien_ToanNuoc == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("Daitien_NhayMui", BenhAnNoiTruYHCT.Daitien_NhayMui == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("Daitien_Bi", BenhAnNoiTruYHCT.Daitien_Bi == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("Daitien_Khac", BenhAnNoiTruYHCT.Daitien_Khac == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("Ngu", BenhAnNoiTruYHCT.Ngu == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("Ngu_KhoVaoGiacNgu", BenhAnNoiTruYHCT.Ngu_KhoVaoGiacNgu == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("Ngu_HayTinh", BenhAnNoiTruYHCT.Ngu_HayTinh == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("Ngu_DaySom", BenhAnNoiTruYHCT.Ngu_DaySom == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("Ngu_HayMo", BenhAnNoiTruYHCT.Ngu_HayMo == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("Ngu_Khac", BenhAnNoiTruYHCT.Ngu_Khac == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("KinhNguyet", BenhAnNoiTruYHCT.KinhNguyet == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("KinhNguyet_DenTruocKy", BenhAnNoiTruYHCT.KinhNguyet_DenTruocKy == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("KinhNguyet_DenSauKy", BenhAnNoiTruYHCT.KinhNguyet_DenSauKy == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("KinhNguyet_LucDenTruocLucDenS", BenhAnNoiTruYHCT.KinhNguyet_LucDenTruocLucDenS == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("KinhNguyet_TacKinh", BenhAnNoiTruYHCT.KinhNguyet_TacKinh == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("KinhNguyet_Khac", BenhAnNoiTruYHCT.KinhNguyet_Khac == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("ThongKinh_DauTruocKy", BenhAnNoiTruYHCT.ThongKinh_DauTruocKy == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("ThongKinh_DauTrongKy", BenhAnNoiTruYHCT.ThongKinh_DauTrongKy == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("ThongKinh_DauSauKy", BenhAnNoiTruYHCT.ThongKinh_DauSauKy == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("ThongKinh_Khac", BenhAnNoiTruYHCT.ThongKinh_Khac == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("DoiHa_Vang", BenhAnNoiTruYHCT.DoiHa_Vang == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("DoiHa_Trang", BenhAnNoiTruYHCT.DoiHa_Trang == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("DoiHa_Hoi", BenhAnNoiTruYHCT.DoiHa_Hoi == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("DoiHa_Hong", BenhAnNoiTruYHCT.DoiHa_Hong == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("DoiHa_Khac", BenhAnNoiTruYHCT.DoiHa_Khac == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("RoiHanKhaNangSinhDuc", BenhAnNoiTruYHCT.RoiHanKhaNangSinhDuc));
            Command.Parameters.Add(new MDB.MDBParameter("Nam_YeuKhiGiaoHop", BenhAnNoiTruYHCT.Nam_YeuKhiGiaoHop == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("Nam_LietDuong", BenhAnNoiTruYHCT.Nam_LietDuong == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("Nam_DiTinh", BenhAnNoiTruYHCT.Nam_DiTinh == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("Nam_HoatTinh", BenhAnNoiTruYHCT.Nam_HoatTinh == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("Nam_MongTinh", BenhAnNoiTruYHCT.Nam_MongTinh == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("Nam_LanhTinh", BenhAnNoiTruYHCT.Nam_LanhTinh == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("Nu_KhongThuThai", BenhAnNoiTruYHCT.Nu_KhongThuThai == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("Nu_SayThai_DongThai", BenhAnNoiTruYHCT.Nu_SayThai_DongThai == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("Nu_SayThaiLienTiep", BenhAnNoiTruYHCT.Nu_SayThaiLienTiep == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("Nu_Khac", BenhAnNoiTruYHCT.Nu_Khac == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("DieuKienXuatHienBenh", BenhAnNoiTruYHCT.DieuKienXuatHienBenh == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("MoTaVaanChan", BenhAnNoiTruYHCT.MoTaVaanChan));
            Command.Parameters.Add(new MDB.MDBParameter("Da_BinhThuong", BenhAnNoiTruYHCT.Da_BinhThuong == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("Da_Kho", BenhAnNoiTruYHCT.Da_Kho == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("Da_Nong", BenhAnNoiTruYHCT.Da_Nong == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("Da_Lanh", BenhAnNoiTruYHCT.Da_Lanh == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("Da_Uot", BenhAnNoiTruYHCT.Da_Uot == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("Da_ChanTayNong", BenhAnNoiTruYHCT.Da_ChanTayNong == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("Da_ChanTayLanh", BenhAnNoiTruYHCT.Da_ChanTayLanh == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("Da_AnLom", BenhAnNoiTruYHCT.Da_AnLom == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("Da_AnDau", BenhAnNoiTruYHCT.Da_AnDau == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("Da_CucCung", BenhAnNoiTruYHCT.Da_CucCung == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("Da_Khac", BenhAnNoiTruYHCT.Da_Khac == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("MoHoi_ToanThan", BenhAnNoiTruYHCT.MoHoi_ToanThan == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("MoHoi_Tran", BenhAnNoiTruYHCT.MoHoi_Tran == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("MoHoi_TayChan", BenhAnNoiTruYHCT.MoHoi_TayChan == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("MoHoi_KhacXucChan", BenhAnNoiTruYHCT.MoHoi_KhacXucChan == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("CoXuongKhop_SanChac", BenhAnNoiTruYHCT.CoXuongKhop_SanChac == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("CoXuongKhop_Mem", BenhAnNoiTruYHCT.CoXuongKhop_Mem == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("CoXuongKhop_CangCung", BenhAnNoiTruYHCT.CoXuongKhop_CangCung == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("CoXuongKhop_CoCoAnDau", BenhAnNoiTruYHCT.CoXuongKhop_CoCoAnDau == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("CoXuongKhop_GanDau", BenhAnNoiTruYHCT.CoXuongKhop_GanDau == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("CoXuongKhop_XuongKhopDau", BenhAnNoiTruYHCT.CoXuongKhop_XuongKhopDau == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("CoXuongKhop_Khac", BenhAnNoiTruYHCT.CoXuongKhop_Khac == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("Bung_Mem", BenhAnNoiTruYHCT.Bung_Mem == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("Bung_Chuong", BenhAnNoiTruYHCT.Bung_Chuong == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("Bung_CoChuong", BenhAnNoiTruYHCT.Bung_CoChuong == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("Bung_CoHonCuc", BenhAnNoiTruYHCT.Bung_CoHonCuc == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("Bung_DauThienAn", BenhAnNoiTruYHCT.Bung_DauThienAn == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("Bung_DauCuAn", BenhAnNoiTruYHCT.Bung_DauCuAn == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("Bung_Khac", BenhAnNoiTruYHCT.Bung_Khac == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("MacChan_Phu", BenhAnNoiTruYHCT.MacChan_Phu == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("MacChan_Tram", BenhAnNoiTruYHCT.MacChan_Tram == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("MacChan_Tri", BenhAnNoiTruYHCT.MacChan_Tri == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("MacChan_Sac", BenhAnNoiTruYHCT.MacChan_Sac == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("MacChan_Te", BenhAnNoiTruYHCT.MacChan_Te == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("MacChan_Huyen", BenhAnNoiTruYHCT.MacChan_Huyen == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("MacChan_Hoat", BenhAnNoiTruYHCT.MacChan_Hoat == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("MacChan_VoLuc", BenhAnNoiTruYHCT.MacChan_VoLuc == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("MacChan_CoLuc", BenhAnNoiTruYHCT.MacChan_CoLuc == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("MacChan_Khac", BenhAnNoiTruYHCT.MacChan_Khac == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("BenPhai_TongKhan", BenhAnNoiTruYHCT.BenPhai_TongKhan));
            Command.Parameters.Add(new MDB.MDBParameter("BenTrai_TongKhan", BenhAnNoiTruYHCT.BenTrai_TongKhan));
            Command.Parameters.Add(new MDB.MDBParameter("Ma_BenPhai_TongKhan", BenhAnNoiTruYHCT.Ma_BenPhai_TongKhan));
            Command.Parameters.Add(new MDB.MDBParameter("Ma_BenTrai_TongKhan", BenhAnNoiTruYHCT.Ma_BenTrai_TongKhan));
            Command.Parameters.Add(new MDB.MDBParameter("MachTayTrai_Thon1", BenhAnNoiTruYHCT.MachTayTrai_Thon1));
            Command.Parameters.Add(new MDB.MDBParameter("MachTayTrai_Thon2", BenhAnNoiTruYHCT.MachTayTrai_Thon2));
            Command.Parameters.Add(new MDB.MDBParameter("MachTayTrai_Thon3", BenhAnNoiTruYHCT.MachTayTrai_Thon3));
            Command.Parameters.Add(new MDB.MDBParameter("MachTayTrai_Thon4", BenhAnNoiTruYHCT.MachTayTrai_Thon4));
            Command.Parameters.Add(new MDB.MDBParameter("MachTayTrai_Quan1", BenhAnNoiTruYHCT.MachTayTrai_Quan1));
            Command.Parameters.Add(new MDB.MDBParameter("MachTayTrai_Quan2", BenhAnNoiTruYHCT.MachTayTrai_Quan2));
            Command.Parameters.Add(new MDB.MDBParameter("MachTayTrai_Quan3", BenhAnNoiTruYHCT.MachTayTrai_Quan3));
            Command.Parameters.Add(new MDB.MDBParameter("MachTayTrai_Quan4", BenhAnNoiTruYHCT.MachTayTrai_Quan4));
            Command.Parameters.Add(new MDB.MDBParameter("MachTayTrai_Xich1", BenhAnNoiTruYHCT.MachTayTrai_Xich1));
            Command.Parameters.Add(new MDB.MDBParameter("MachTayTrai_Xich2", BenhAnNoiTruYHCT.MachTayTrai_Xich2));
            Command.Parameters.Add(new MDB.MDBParameter("MachTayTrai_Xich3", BenhAnNoiTruYHCT.MachTayTrai_Xich3));
            Command.Parameters.Add(new MDB.MDBParameter("MachTayTrai_Xich4", BenhAnNoiTruYHCT.MachTayTrai_Xich4));
            Command.Parameters.Add(new MDB.MDBParameter("MachTayPhai_Thon1", BenhAnNoiTruYHCT.MachTayPhai_Thon1));
            Command.Parameters.Add(new MDB.MDBParameter("MachTayPhai_Thon2", BenhAnNoiTruYHCT.MachTayPhai_Thon2));
            Command.Parameters.Add(new MDB.MDBParameter("MachTayPhai_Thon3", BenhAnNoiTruYHCT.MachTayPhai_Thon3));
            Command.Parameters.Add(new MDB.MDBParameter("MachTayPhai_Thon4", BenhAnNoiTruYHCT.MachTayPhai_Thon4));
            Command.Parameters.Add(new MDB.MDBParameter("MachTayPhai_Quan1", BenhAnNoiTruYHCT.MachTayPhai_Quan1));
            Command.Parameters.Add(new MDB.MDBParameter("MachTayPhai_Quan2", BenhAnNoiTruYHCT.MachTayPhai_Quan2));
            Command.Parameters.Add(new MDB.MDBParameter("MachTayPhai_Quan3", BenhAnNoiTruYHCT.MachTayPhai_Quan3));
            Command.Parameters.Add(new MDB.MDBParameter("MachTayPhai_Quan4", BenhAnNoiTruYHCT.MachTayPhai_Quan4));
            Command.Parameters.Add(new MDB.MDBParameter("MachTayPhai_Xich1", BenhAnNoiTruYHCT.MachTayPhai_Xich1));
            Command.Parameters.Add(new MDB.MDBParameter("MachTayPhai_Xich2", BenhAnNoiTruYHCT.MachTayPhai_Xich2));
            Command.Parameters.Add(new MDB.MDBParameter("MachTayPhai_Xich3", BenhAnNoiTruYHCT.MachTayPhai_Xich3));
            Command.Parameters.Add(new MDB.MDBParameter("MachTayPhai_Xich4", BenhAnNoiTruYHCT.MachTayPhai_Xich4));
            Command.Parameters.Add(new MDB.MDBParameter("MoTaThietChan", BenhAnNoiTruYHCT.MoTaThietChan));
            Command.Parameters.Add(new MDB.MDBParameter("TomTatTuChan", BenhAnNoiTruYHCT.TomTatTuChan));
            Command.Parameters.Add(new MDB.MDBParameter("BienPhapLuanTri", BenhAnNoiTruYHCT.BienPhapLuanTri));
            Command.Parameters.Add(new MDB.MDBParameter("BietDanh", BenhAnNoiTruYHCT.BietDanh));
            Command.Parameters.Add(new MDB.MDBParameter("BatCuong", BenhAnNoiTruYHCT.BatCuong));
            Command.Parameters.Add(new MDB.MDBParameter("TangPhuKinhLac", BenhAnNoiTruYHCT.TangPhuKinhLac));
            Command.Parameters.Add(new MDB.MDBParameter("NguyenNhan", BenhAnNoiTruYHCT.NguyenNhan));
            Command.Parameters.Add(new MDB.MDBParameter("DieuTriYHCT", BenhAnNoiTruYHCT.DieuTriYHCT == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("PhapDieuTri", BenhAnNoiTruYHCT.PhapDieuTri));
            Command.Parameters.Add(new MDB.MDBParameter("PhuongThuoc", BenhAnNoiTruYHCT.PhuongThuoc));
            Command.Parameters.Add(new MDB.MDBParameter("PhuongHuyet", BenhAnNoiTruYHCT.PhuongHuyet));
            Command.Parameters.Add(new MDB.MDBParameter("XoaBopBamHuyet", BenhAnNoiTruYHCT.XoaBopBamHuyet));
            Command.Parameters.Add(new MDB.MDBParameter("Khac_DieuTri", BenhAnNoiTruYHCT.Khac_DieuTri));
            Command.Parameters.Add(new MDB.MDBParameter("DieuTriKetHopVoiYHHD", BenhAnNoiTruYHCT.DieuTriKetHopVoiYHHD == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("DieuTriKetHopVoiYHHD_Text", BenhAnNoiTruYHCT.DieuTriKetHopVoiYHHD_Text));
            Command.Parameters.Add(new MDB.MDBParameter("CheDoDinhDuong", BenhAnNoiTruYHCT.CheDoDinhDuong));
            Command.Parameters.Add(new MDB.MDBParameter("CheDoChamSoc", BenhAnNoiTruYHCT.CheDoChamSoc));
            Command.Parameters.Add(new MDB.MDBParameter("ChanDoanVaoVienTheoYHCT", BenhAnNoiTruYHCT.ChanDoanVaoVienTheoYHCT));
            Command.Parameters.Add(new MDB.MDBParameter("ChanDoanVaoVienTheoYHHD", BenhAnNoiTruYHCT.ChanDoanVaoVienTheoYHHD));
            Command.Parameters.Add(new MDB.MDBParameter("PhuongPhapDieuTriTheoYHHD", BenhAnNoiTruYHCT.PhuongPhapDieuTriTheoYHHD));
            Command.Parameters.Add(new MDB.MDBParameter("PhuongPhapDieuTriTheoYHCT", BenhAnNoiTruYHCT.PhuongPhapDieuTriTheoYHCT));
            Command.Parameters.Add(new MDB.MDBParameter("ChanDoanRaVienTheoYHCT", BenhAnNoiTruYHCT.ChanDoanRaVienTheoYHCT));
            Command.Parameters.Add(new MDB.MDBParameter("ChanDoanRaVienTheoYHHD", BenhAnNoiTruYHCT.ChanDoanRaVienTheoYHHD));
            Command.Parameters.Add(new MDB.MDBParameter("KetQuaDieuTriID", BenhAnNoiTruYHCT.KetQuaDieuTriID));
            Command.Parameters.Add(new MDB.MDBParameter("TinhTrangNguoiBenhKhiRavien", BenhAnNoiTruYHCT.TinhTrangNguoiBenhKhiRavien));
            int n = Command.ExecuteNonQuery(); // C#
            return n > 0 ? true : false;
        }
        public static bool Update(MDB.MDBConnection MyConnection, BenhAnNoiTruYHCT BenhAnNoiTruYHCT)
        {
            if (BenhAnNoiTruYHCT == null) return false;
            if (BenhAnNoiTruYHCT.DacDiemLienQuanBenh == null) BenhAnNoiTruYHCT.DacDiemLienQuanBenh = new DacDiemLienQuanBenh();
            string sql = @"UPDATE BenhAnNoiTruYHCT SET 
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
                        BenhSu = :BenhSu,
                        MoTaChiTietCoQuanBenhLy = :MoTaChiTietCoQuanBenhLy,
                        HinhThai_Gay = :HinhThai_Gay,
                        Bung_Dau = :Bung_Dau,
                        ChanTay_Dau = :ChanTay_Dau,
                        ChanTay_Te = :ChanTay_Te,
                        ChanTay_Buon = :ChanTay_Buon,
                        ChanTay_Moi = :ChanTay_Moi,
                        ChanTay_Nhuc = :ChanTay_Nhuc,
                        ChanTay_Nong = :ChanTay_Nong,
                        ChanTay_Lanh = :ChanTay_Lanh,
                        ChanTay_Khac = :ChanTay_Khac,
                        Nam_Khac = :Nam_Khac,
                        Nu_DongThai = :Nu_DongThai,
                        Nu_SayThai = :Nu_SayThai,
                        MacChan_Nhu = :MacChan_Nhu,
                        DinhViBenhTheo_Ve = :DinhViBenhTheo_Ve,
                        DinhViBenhTheo_Khi = :DinhViBenhTheo_Khi,
                        DinhViBenhTheo_Dinh = :DinhViBenhTheo_Dinh,
                        DinhViBenhTheo_Huyet = :DinhViBenhTheo_Huyet,
                        NguyenNhan_NoiNhan = :NguyenNhan_NoiNhan,
                        NguyenNhan_NgoaiNhan = :NguyenNhan_NgoaiNhan,
                        NguyenNhan_BatNoiNgoai = :NguyenNhan_BatNoiNgoai,
                        TangPhu_Tam = :TangPhu_Tam,
                        TangPhu_Lan = :TangPhu_Lan,
                        TangPhu_Ty = :TangPhu_Ty,
                        TangPhu_Phe = :TangPhu_Phe,
                        TangPhu_Than = :TangPhu_Than,
                        TangPhu_TamBao = :TangPhu_TamBao,
                        TangPhu_TieuTruong = :TangPhu_TieuTruong,
                        TangPhu_Dom = :TangPhu_Dom,
                        TangPhu_Vi = :TangPhu_Vi,
                        TangPhu_DaiTruong = :TangPhu_DaiTruong,
                        TangPhu_BangQuang = :TangPhu_BangQuang,
                        TangPhu_TamTieu = :TangPhu_TamTieu,
                        TangPhu_PhuKyHang = :TangPhu_PhuKyHang,
                        KinhMach_Tam = :KinhMach_Tam,
                        DauDau_DauThat = :DauDau_DauThat,
                        DauDau_Khac = :DauDau_Khac,
                        Mat_Dau = :Mat_Dau,
                        Mat_Khac = :Mat_Khac,
                        Mui_Khac = :Mui_Khac,
                        Hong_Khac = :Hong_Khac,
                        KinhMach_Lan = :KinhMach_Lan,
                        KinhMach_Ty = :KinhMach_Ty,
                        KinhMach_Phe = :KinhMach_Phe,
                        KinhMach_Than = :KinhMach_Than,
                        KinhMach_TamBao = :KinhMach_TamBao,
                        KinhMach_TieuTruong = :KinhMach_TieuTruong,
                        KinhMach_Dom = :KinhMach_Dom,
                        KinhMach_Vi = :KinhMach_Vi,
                        KinhMach_DaiTruong = :KinhMach_DaiTruong,
                        KinhMach_BangQuang = :KinhMach_BangQuang,
                        KinhMach_TamTieu = :KinhMach_TamTieu,
                        KinhMach_MachDoc = :KinhMach_MachDoc,
                        KinhMach_MachNham = :KinhMach_MachNham,
                        BatCuong_Bieu = :BatCuong_Bieu,
                        BatCuong_Ly = :BatCuong_Ly,
                        BatCuong_Hu = :BatCuong_Hu,
                        BatCuong_Thuc = :BatCuong_Thuc,
                        BatCuong_Han = :BatCuong_Han,
                        BatCuong_Nhiet = :BatCuong_Nhiet,
                        BatCuong_Am = :BatCuong_Am,
                        BatCuong_Duong = :BatCuong_Duong,
                        Bung = :Bung,
                        DoiHa = :DoiHa,
                        CoXuongKhop_BinhThuong = :CoXuongKhop_BinhThuong,
                        Bung_BinhThuong = :Bung_BinhThuong,
                        PPKhongDungThuoc = :PPKhongDungThuoc,
                        PPKhac = :PPKhac,
                        MotaTienSuBanThan = :MotaTienSuBanThan,
                        ChanDoanVVYHCT_BenhChinh = :ChanDoanVVYHCT_BenhChinh,
                        ChanDoanVVYHCT_KemTheo = :ChanDoanVVYHCT_KemTheo,
                        MaICDChanDoanVVYHCT_BenhChinh = :MaICDChanDoanVVYHCT_BenhChinh,
                        MaICDChanDoanVVYHCT_KemTheo = :MaICDChanDoanVVYHCT_KemTheo,
                        ChanDoanVVYHHD_BenhChinh = :ChanDoanVVYHHD_BenhChinh,
                        ChanDoanVVYHD_KemTheo = :ChanDoanVVYHD_KemTheo,
                        MaICDVVYHD_BenhChinh = :MaICDVVYHD_BenhChinh,
                        MaICDChanDoanVVYHD_KemTheo = :MaICDChanDoanVVYHD_KemTheo,
                        ChanDoanRVYHCT_BenhChinh = :ChanDoanRVYHCT_BenhChinh,
                        ChanDoanRVYHCT_KemTheo = :ChanDoanRVYHCT_KemTheo,
                        MaICDChanDoanRVYHCT_BenhChinh = :MaICDChanDoanRVYHCT_BenhChinh,
                        MaICDChanDoanRVYHCT_KemTheo = :MaICDChanDoanRVYHCT_KemTheo,
                        ChanDoanRVYHHD_BenhChinh = :ChanDoanRVYHHD_BenhChinh,
                        ChanDoanRVYHD_KemTheo = :ChanDoanRVYHD_KemTheo,
                        MaICDRVYHD_BenhChinh = :MaICDRVYHD_BenhChinh,
                        MaICDChanDoanRVYHD_KemTheo = :MaICDChanDoanRVYHD_KemTheo,
                        ChanDoan_NoiChuyenDen_YHCT = :ChanDoan_NoiChuyenDen_YHCT,
                        MaICD_NoiChuyenDen_YHCT = :MaICD_NoiChuyenDen_YHCT,
                        ChanDoan_KKB_CapCuu_YHCT = :ChanDoan_KKB_CapCuu_YHCT,
                        MaICD_KKB_CapCuu_YHCT = :MaICD_KKB_CapCuu_YHCT,
                        HOSOKQ_XQUANG = :HOSOKQ_XQUANG,
                        HOSOKQ_CTSCANNER = :HOSOKQ_CTSCANNER,
                        HOSOKQ_MRI = :HOSOKQ_MRI,
                        HOSOKQ_KHAC_TXT = :HOSOKQ_KHAC_TXT,
                        HOSOKQ_KHAC = :HOSOKQ_KHAC,
                        HOSOKQ_TOANBOHOSO = :HOSOKQ_TOANBOHOSO,
                        BenhChinh_YHCT = :BenhChinh_YHCT,
                        MaICD_BenhChinh_YHCT = :MaICD_BenhChinh_YHCT,
                        BenhKemTheo_YHCT = :BenhKemTheo_YHCT,
                        MaICD_BenhKemTheo_YHCT = :MaICD_BenhKemTheo_YHCT,
                        ThuThuat_YHCT = :ThuThuat_YHCT,
                        PhauThuat_YHCT = :PhauThuat_YHCT,
                        BenhChinh_RV_YHCT = :BenhChinh_RV_YHCT,
                        MaICD_BenhChinh_RV_YHCT = :MaICD_BenhChinh_RV_YHCT,
                        BenhKemTheo_RV_YHCT = :BenhKemTheo_RV_YHCT,
                        MaICD_BenhKemTheo_RV_YHCT = :MaICD_BenhKemTheo_RV_YHCT,
                        TaiBien_YHCT = :TaiBien_YHCT,
                        BienChung_YHCT = :BienChung_YHCT,
                        MaICD_BenhKemTheo_YHHD = :MaICD_BenhKemTheo_YHHD,
                        MaICD_BenhChinh_YHHD_CD = :MaICD_BenhChinh_YHHD_CD,
                        MaICD_BenhKemTheo_YHHD_CD = :MaICD_BenhKemTheo_YHHD_CD,
                        CheDoDinhDuong_Long	 = :CheDoDinhDuong_Long	,
                        CheDoDinhDuong_Dac	 = :CheDoDinhDuong_Dac	,
                        CheDoDinhDuong_Kieng	 = :CheDoDinhDuong_Kieng	,
                        CheDoDinhDuong_Khac	 = :CheDoDinhDuong_Khac	,
                        CheDoChamSoc_1	 = :CheDoChamSoc_1	,
                        CheDoChamSoc_2	 = :CheDoChamSoc_2	,
                        CheDoChamSoc_3	 = :CheDoChamSoc_3	,
                        HinhThai_Beo = :HinhThai_Beo,
                        HinhThai_CanDoi = :HinhThai_CanDoi,
                        HinhThai_NamCo = :HinhThai_NamCo,
                        HinhThai_UaTinh = :HinhThai_UaTinh,
                        HinhThai_NamDuoi = :HinhThai_NamDuoi,
                        HinhThai_HieuDong = :HinhThai_HieuDong,
                        HinhThai_Khac = :HinhThai_Khac,
                        Than_ConThan = :Than_ConThan,
                        Than_KhongConThan = :Than_KhongConThan,
                        Than_Khac = :Than_Khac,
                        Sac_BechTrang = :Sac_BechTrang,
                        Sac_Do = :Sac_Do,
                        Sac_Vang = :Sac_Vang,
                        Sac_Xanh = :Sac_Xanh,
                        Sac_Den = :Sac_Den,
                        Sac_Khac = :Sac_Khac,
                        Sac_BinhThuong = :Sac_BinhThuong,
                        Trach_TuoiNhuan = :Trach_TuoiNhuan,
                        Trach_Kho = :Trach_Kho,
                        Trach_Khac = :Trach_Khac,
                        ChatLuoi_BinhThuong = :ChatLuoi_BinhThuong,
                        ChatLuoi_Beu = :ChatLuoi_Beu,
                        ChatLuoi_GayMong = :ChatLuoi_GayMong,
                        ChatLuoi_Nut = :ChatLuoi_Nut,
                        ChatLuoi_Cung = :ChatLuoi_Cung,
                        ChatLuoi_Loet = :ChatLuoi_Loet,
                        ChatLuoi_Lech = :ChatLuoi_Lech,
                        ChatLuoi_Rut = :ChatLuoi_Rut,
                        ChatLuoi_Khac = :ChatLuoi_Khac,
                        SacLuoi_Hong = :SacLuoi_Hong,
                        SacLuoi_Nhot = :SacLuoi_Nhot,
                        SacLuoi_Do = :SacLuoi_Do,
                        SacLuoi_DoSam = :SacLuoi_DoSam,
                        SacLuoi_XanhTim = :SacLuoi_XanhTim,
                        SacLuoi_DamUHuyet = :SacLuoi_DamUHuyet,
                        SacLuoi_Kho = :SacLuoi_Kho,
                        SacLuoi_Nhuan = :SacLuoi_Nhuan,
                        SacLuoi_Khac = :SacLuoi_Khac,
                        ReuLuoi_Co = :ReuLuoi_Co,
                        ReuLuoi_Khong = :ReuLuoi_Khong,
                        ReuLuoi_Bong = :ReuLuoi_Bong,
                        ReuLuoi_Day = :ReuLuoi_Day,
                        ReuLuoi_Mong = :ReuLuoi_Mong,
                        ReuLuoi_Uot = :ReuLuoi_Uot,
                        ReuLuoi_Kho = :ReuLuoi_Kho,
                        ReuLuoi_Dinh = :ReuLuoi_Dinh,
                        ReuLuoi_Trang = :ReuLuoi_Trang,
                        ReuLuoi_Vang = :ReuLuoi_Vang,
                        ReuLuoi_Den = :ReuLuoi_Den,
                        ReuLuoi_Khac = :ReuLuoi_Khac,
                        MoTaVongChan = :MoTaVongChan,
                        TiengNoi_BinhThuong = :TiengNoi_BinhThuong,
                        TiengNoi_To = :TiengNoi_To,
                        TiengNoi_Nho = :TiengNoi_Nho,
                        TiengNoi_DutQuang = :TiengNoi_DutQuang,
                        TiengNoi_Khan = :TiengNoi_Khan,
                        TiengNoi_Ngong = :TiengNoi_Ngong,
                        TiengNoi_Mat = :TiengNoi_Mat,
                        TiengNoi_Khac = :TiengNoi_Khac,
                        HoiTho_BinhThuong = :HoiTho_BinhThuong,
                        HoiTho_DutQuang = :HoiTho_DutQuang,
                        HoiTho_Ngan = :HoiTho_Ngan,
                        HoiTho_Manh = :HoiTho_Manh,
                        HoiTho_Yeu = :HoiTho_Yeu,
                        HoiTho_Tho = :HoiTho_Tho,
                        HoiTho_Rit = :HoiTho_Rit,
                        HoiTho_KhoKhe = :HoiTho_KhoKhe,
                        HoiTho_Cham = :HoiTho_Cham,
                        HoiTho_Gap = :HoiTho_Gap,
                        HoiTho_Khac = :HoiTho_Khac,
                        Ho = :Ho,
                        Ho_HoLienTuc = :Ho_HoLienTuc,
                        Ho_Con = :Ho_Con,
                        Ho_It = :Ho_It,
                        Ho_Nhieu = :Ho_Nhieu,
                        Ho_Khan = :Ho_Khan,
                        Ho_CoDom = :Ho_CoDom,
                        Ho_Khac = :Ho_Khac,
                        O = :O,
                        Nac = :Nac,
                        MuiCoThe = :MuiCoThe,
                        MuiCoThe_Chua = :MuiCoThe_Chua,
                        MuiCoThe_Kham = :MuiCoThe_Kham,
                        MuiCoThe_Tanh = :MuiCoThe_Tanh,
                        MuiCoThe_Thoi = :MuiCoThe_Thoi,
                        MuiCoThe_Hoi = :MuiCoThe_Hoi,
                        MuiCoThe_Khac = :MuiCoThe_Khac,
                        ChatThaiBieuHienBenhLy = :ChatThaiBieuHienBenhLy,
                        ChatThai_Dom = :ChatThai_Dom,
                        ChatThai_ChatNon = :ChatThai_ChatNon,
                        ChatThai_Phan = :ChatThai_Phan,
                        ChatThai_NuocTieu = :ChatThai_NuocTieu,
                        ChatThai_KhiHu = :ChatThai_KhiHu,
                        ChatThai_KinhNguyet = :ChatThai_KinhNguyet,
                        ChatThai_Khac = :ChatThai_Khac,
                        MoTaVanChan = :MoTaVanChan,
                        HanNhiet_BinhThuong = :HanNhiet_BinhThuong,
                        HanNhiet_Han = :HanNhiet_Han,
                        HanNhiet_Nhiet = :HanNhiet_Nhiet,
                        HanNhiet_Khac = :HanNhiet_Khac,
                        HanNhiet_ThichNong = :HanNhiet_ThichNong,
                        HanNhiet_SoNong = :HanNhiet_SoNong,
                        HanNhiet_ThichMat = :HanNhiet_ThichMat,
                        HanNhiet_SoLanh = :HanNhiet_SoLanh,
                        HanNhiet_TrongNguoiNong = :HanNhiet_TrongNguoiNong,
                        HanNhiet_TrongNguoiLanh = :HanNhiet_TrongNguoiLanh,
                        HanNhiet_RetRun = :HanNhiet_RetRun,
                        HanNhiet_HanNhietVangLai = :HanNhiet_HanNhietVangLai,
                        HanNhiet_Khac2 = :HanNhiet_Khac2,
                        MoHoi_BinhThuong_ThietChan = :MoHoi_BinhThuong_ThietChan,
                        MoHoi_BinhThuong = :MoHoi_BinhThuong,
                        MoHoi_KhongCoMoHoi = :MoHoi_KhongCoMoHoi,
                        MoHoi_TuHan = :MoHoi_TuHan,
                        MoHoi_DaoHan = :MoHoi_DaoHan,
                        MoHoi_Nhieu = :MoHoi_Nhieu,
                        MoHoi_It = :MoHoi_It,
                        MoHoi_Khac = :MoHoi_Khac,
                        DauMat = :DauMat,
                        DauDau_MotCho = :DauDau_MotCho,
                        DauDau_NuaDau = :DauDau_NuaDau,
                        DauDau_CaDau = :DauDau_CaDau,
                        DauDau_DiChuyen = :DauDau_DiChuyen,
                        DauDau_EAmNhuBiBuocLai = :DauDau_EAmNhuBiBuocLai,
                        DauDau_Nhoi = :DauDau_Nhoi,
                        DauDau_Cang = :DauDau_Cang,
                        DauDau_NangDau = :DauDau_NangDau,
                        Mat_HoaMatChongMat = :Mat_HoaMatChongMat,
                        Mat_NhinKhongRo = :Mat_NhinKhongRo,
                        Tai_U = :Tai_U,
                        Tai_Diec = :Tai_Diec,
                        Tai_Nang = :Tai_Nang,
                        Tai_ = :Tai_,
                        Tai_Dau = :Tai_Dau,
                        Mui_Ngat = :Mui_Ngat,
                        Mui_ChayNuoc = :Mui_ChayNuoc,
                        Mui_ChayMauCam = :Mui_ChayMauCam,
                        Mui_Dau = :Mui_Dau,
                        Hong_Dau = :Hong_Dau,
                        Hong_Kho = :Hong_Kho,
                        CoVai_Moi = :CoVai_Moi,
                        CoVai_Dau = :CoVai_Dau,
                        CoVai_KhoVanDong = :CoVai_KhoVanDong,
                        CoVai_Khac = :CoVai_Khac,
                        Lung = :Lung,
                        Lung_Dau = :Lung_Dau,
                        Lung_KhoVanDong = :Lung_KhoVanDong,
                        Lung_CoCungCo = :Lung_CoCungCo,
                        Lung_Khac = :Lung_Khac,
                        BungVaUc = :BungVaUc,
                        BungNguc_Tuc = :BungNguc_Tuc,
                        BungNguc_Dau = :BungNguc_Dau,
                        BungNguc_Soi = :BungNguc_Soi,
                        BungNguc_NongRuot = :BungNguc_NongRuot,
                        BungNguc_DayTruong = :BungNguc_DayTruong,
                        BungNguc_NgotNgatKhoTho = :BungNguc_NgotNgatKhoTho,
                        BungNguc_DauTucCanhSuon = :BungNguc_DauTucCanhSuon,
                        BungNguc_BonChonKhongYen = :BungNguc_BonChonKhongYen,
                        BungNguc_DanhTrongNguc = :BungNguc_DanhTrongNguc,
                        BungNguc_Khac = :BungNguc_Khac,
                        ChanTay = :ChanTay,
                        An = :An,
                        An_ThichNong = :An_ThichNong,
                        An_ThichMat = :An_ThichMat,
                        An_AnNhieu = :An_AnNhieu,
                        An_AnIt = :An_AnIt,
                        An_DangMieng = :An_DangMieng,
                        An_NhatMieng = :An_NhatMieng,
                        An_ThemAn = :An_ThemAn,
                        An_ChanAn = :An_ChanAn,
                        An_AnVaoBungChuong = :An_AnVaoBungChuong,
                        An_Khac = :An_Khac,
                        Uong = :Uong,
                        Uong_Mat = :Uong_Mat,
                        Uong_AmNong = :Uong_AmNong,
                        Uong_Nhieu = :Uong_Nhieu,
                        Uong_It = :Uong_It,
                        Uong_Khac = :Uong_Khac,
                        DaiTieuTien = :DaiTieuTien,
                        Tieutien_Vang = :Tieutien_Vang,
                        Tieutien_Do = :Tieutien_Do,
                        Tieutien_Duc = :Tieutien_Duc,
                        Tieutien_Buot = :Tieutien_Buot,
                        Tieutien_Dat = :Tieutien_Dat,
                        Tieutien_KhongTuChu = :Tieutien_KhongTuChu,
                        Tieutien_Bi = :Tieutien_Bi,
                        Tieutien_Khac = :Tieutien_Khac,
                        Daitien_Tao = :Daitien_Tao,
                        Daitien_Nhao = :Daitien_Nhao,
                        Daitien_Song = :Daitien_Song,
                        Daitien_ToanNuoc = :Daitien_ToanNuoc,
                        Daitien_NhayMui = :Daitien_NhayMui,
                        Daitien_Bi = :Daitien_Bi,
                        Daitien_Khac = :Daitien_Khac,
                        Ngu = :Ngu,
                        Ngu_KhoVaoGiacNgu = :Ngu_KhoVaoGiacNgu,
                        Ngu_HayTinh = :Ngu_HayTinh,
                        Ngu_DaySom = :Ngu_DaySom,
                        Ngu_HayMo = :Ngu_HayMo,
                        Ngu_Khac = :Ngu_Khac,
                        KinhNguyet = :KinhNguyet,
                        KinhNguyet_DenTruocKy = :KinhNguyet_DenTruocKy,
                        KinhNguyet_DenSauKy = :KinhNguyet_DenSauKy,
                        KinhNguyet_LucDenTruocLucDenS = :KinhNguyet_LucDenTruocLucDenS,
                        KinhNguyet_TacKinh = :KinhNguyet_TacKinh,
                        KinhNguyet_Khac = :KinhNguyet_Khac,
                        ThongKinh_DauTruocKy = :ThongKinh_DauTruocKy,
                        ThongKinh_DauTrongKy = :ThongKinh_DauTrongKy,
                        ThongKinh_DauSauKy = :ThongKinh_DauSauKy,
                        ThongKinh_Khac = :ThongKinh_Khac,
                        DoiHa_Vang = :DoiHa_Vang,
                        DoiHa_Trang = :DoiHa_Trang,
                        DoiHa_Hoi = :DoiHa_Hoi,
                        DoiHa_Hong = :DoiHa_Hong,
                        DoiHa_Khac = :DoiHa_Khac,
                        RoiHanKhaNangSinhDuc = :RoiHanKhaNangSinhDuc,
                        Nam_YeuKhiGiaoHop = :Nam_YeuKhiGiaoHop,
                        Nam_LietDuong = :Nam_LietDuong,
                        Nam_DiTinh = :Nam_DiTinh,
                        Nam_HoatTinh = :Nam_HoatTinh,
                        Nam_MongTinh = :Nam_MongTinh,
                        Nam_LanhTinh = :Nam_LanhTinh,
                        Nu_KhongThuThai = :Nu_KhongThuThai,
                        Nu_SayThai_DongThai = :Nu_SayThai_DongThai,
                        Nu_SayThaiLienTiep = :Nu_SayThaiLienTiep,
                        Nu_Khac = :Nu_Khac,
                        DieuKienXuatHienBenh = :DieuKienXuatHienBenh,
                        MoTaVaanChan = :MoTaVaanChan,
                        Da_BinhThuong = :Da_BinhThuong,
                        Da_Kho = :Da_Kho,
                        Da_Nong = :Da_Nong,
                        Da_Lanh = :Da_Lanh,
                        Da_Uot = :Da_Uot,
                        Da_ChanTayNong = :Da_ChanTayNong,
                        Da_ChanTayLanh = :Da_ChanTayLanh,
                        Da_AnLom = :Da_AnLom,
                        Da_AnDau = :Da_AnDau,
                        Da_CucCung = :Da_CucCung,
                        Da_Khac = :Da_Khac,
                        MoHoi_ToanThan = :MoHoi_ToanThan,
                        MoHoi_Tran = :MoHoi_Tran,
                        MoHoi_TayChan = :MoHoi_TayChan,
                        MoHoi_KhacXucChan = :MoHoi_KhacXucChan,
                        CoXuongKhop_SanChac = :CoXuongKhop_SanChac,
                        CoXuongKhop_Mem = :CoXuongKhop_Mem,
                        CoXuongKhop_CangCung = :CoXuongKhop_CangCung,
                        CoXuongKhop_CoCoAnDau = :CoXuongKhop_CoCoAnDau,
                        CoXuongKhop_GanDau = :CoXuongKhop_GanDau,
                        CoXuongKhop_XuongKhopDau = :CoXuongKhop_XuongKhopDau,
                        CoXuongKhop_Khac = :CoXuongKhop_Khac,
                        Bung_Mem = :Bung_Mem,
                        Bung_Chuong = :Bung_Chuong,
                        Bung_CoChuong = :Bung_CoChuong,
                        Bung_CoHonCuc = :Bung_CoHonCuc,
                        Bung_DauThienAn = :Bung_DauThienAn,
                        Bung_DauCuAn = :Bung_DauCuAn,
                        Bung_Khac = :Bung_Khac,
                        MacChan_Phu = :MacChan_Phu,
                        MacChan_Tram = :MacChan_Tram,
                        MacChan_Tri = :MacChan_Tri,
                        MacChan_Sac = :MacChan_Sac,
                        MacChan_Te = :MacChan_Te,
                        MacChan_Huyen = :MacChan_Huyen,
                        MacChan_Hoat = :MacChan_Hoat,
                        MacChan_VoLuc = :MacChan_VoLuc,
                        MacChan_CoLuc = :MacChan_CoLuc,
                        MacChan_Khac = :MacChan_Khac,
                        BenPhai_TongKhan = :BenPhai_TongKhan,
                        BenTrai_TongKhan = :BenTrai_TongKhan,
                        Ma_BenPhai_TongKhan = :Ma_BenPhai_TongKhan,
                        Ma_BenTrai_TongKhan = :Ma_BenTrai_TongKhan,
                        MachTayTrai_Thon1 = :MachTayTrai_Thon1,
                        MachTayTrai_Thon2 = :MachTayTrai_Thon2,
                        MachTayTrai_Thon3 = :MachTayTrai_Thon3,
                        MachTayTrai_Thon4 = :MachTayTrai_Thon4,
                        MachTayTrai_Quan1 = :MachTayTrai_Quan1,
                        MachTayTrai_Quan2 = :MachTayTrai_Quan2,
                        MachTayTrai_Quan3 = :MachTayTrai_Quan3,
                        MachTayTrai_Quan4 = :MachTayTrai_Quan4,
                        MachTayTrai_Xich1 = :MachTayTrai_Xich1,
                        MachTayTrai_Xich2 = :MachTayTrai_Xich2,
                        MachTayTrai_Xich3 = :MachTayTrai_Xich3,
                        MachTayTrai_Xich4 = :MachTayTrai_Xich4,
                        MachTayPhai_Thon1 = :MachTayPhai_Thon1,
                        MachTayPhai_Thon2 = :MachTayPhai_Thon2,
                        MachTayPhai_Thon3 = :MachTayPhai_Thon3,
                        MachTayPhai_Thon4 = :MachTayPhai_Thon4,
                        MachTayPhai_Quan1 = :MachTayPhai_Quan1,
                        MachTayPhai_Quan2 = :MachTayPhai_Quan2,
                        MachTayPhai_Quan3 = :MachTayPhai_Quan3,
                        MachTayPhai_Quan4 = :MachTayPhai_Quan4,
                        MachTayPhai_Xich1 = :MachTayPhai_Xich1,
                        MachTayPhai_Xich2 = :MachTayPhai_Xich2,
                        MachTayPhai_Xich3 = :MachTayPhai_Xich3,
                        MachTayPhai_Xich4 = :MachTayPhai_Xich4,
                        MoTaThietChan = :MoTaThietChan,
                        TomTatTuChan = :TomTatTuChan,
                        BienPhapLuanTri = :BienPhapLuanTri,
                        BietDanh = :BietDanh,
                        BatCuong = :BatCuong,
                        TangPhuKinhLac = :TangPhuKinhLac,
                        NguyenNhan = :NguyenNhan,
                        DieuTriYHCT = :DieuTriYHCT,
                        PhapDieuTri = :PhapDieuTri,
                        PhuongThuoc = :PhuongThuoc,
                        PhuongHuyet = :PhuongHuyet,
                        XoaBopBamHuyet = :XoaBopBamHuyet,
                        Khac_DieuTri = :Khac_DieuTri,
                        DieuTriKetHopVoiYHHD = :DieuTriKetHopVoiYHHD,
                        DieuTriKetHopVoiYHHD_Text = :DieuTriKetHopVoiYHHD_Text,
                        CheDoDinhDuong = :CheDoDinhDuong,
                        CheDoChamSoc = :CheDoChamSoc,
                        ChanDoanVaoVienTheoYHCT = :ChanDoanVaoVienTheoYHCT,
                        ChanDoanVaoVienTheoYHHD = :ChanDoanVaoVienTheoYHHD,
                        PhuongPhapDieuTriTheoYHHD = :PhuongPhapDieuTriTheoYHHD,
                        PhuongPhapDieuTriTheoYHCT = :PhuongPhapDieuTriTheoYHCT,
                        ChanDoanRaVienTheoYHCT = :ChanDoanRaVienTheoYHCT,
                        ChanDoanRaVienTheoYHHD = :ChanDoanRaVienTheoYHHD,
                        KetQuaDieuTriID = :KetQuaDieuTriID,
                        TinhTrangNguoiBenhKhiRavien = :TinhTrangNguoiBenhKhiRavien
                        WHERE MaQuanLy = :MaQuanLy";
            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
            Command.Parameters.Add(new MDB.MDBParameter("LyDoVaoVien", BenhAnNoiTruYHCT.LyDoVaoVien));
            Command.Parameters.Add(new MDB.MDBParameter("VaoNgayThu", BenhAnNoiTruYHCT.VaoNgayThu));
            Command.Parameters.Add(new MDB.MDBParameter("QuaTrinhBenhLy", BenhAnNoiTruYHCT.QuaTrinhBenhLy));
            Command.Parameters.Add(new MDB.MDBParameter("TienSuBenhBanThan", BenhAnNoiTruYHCT.TienSuBenhBanThan));
            Command.Parameters.Add(new MDB.MDBParameter("TienSuBenhGiaDinh", BenhAnNoiTruYHCT.TienSuBenhGiaDinh));
            Command.Parameters.Add(new MDB.MDBParameter("ToanThan", BenhAnNoiTruYHCT.ToanThan));
            Command.Parameters.Add(new MDB.MDBParameter("TuanHoan", BenhAnNoiTruYHCT.TuanHoan));
            Command.Parameters.Add(new MDB.MDBParameter("HoHap", BenhAnNoiTruYHCT.HoHap));
            Command.Parameters.Add(new MDB.MDBParameter("TieuHoa", BenhAnNoiTruYHCT.TieuHoa));
            Command.Parameters.Add(new MDB.MDBParameter("ThanTietNieuSinhDuc", BenhAnNoiTruYHCT.ThanTietNieuSinhDuc));
            Command.Parameters.Add(new MDB.MDBParameter("ThanKinh", BenhAnNoiTruYHCT.ThanKinh));
            Command.Parameters.Add(new MDB.MDBParameter("CoXuongKhop", BenhAnNoiTruYHCT.CoXuongKhop));
            Command.Parameters.Add(new MDB.MDBParameter("TaiMuiHong", BenhAnNoiTruYHCT.TaiMuiHong));
            Command.Parameters.Add(new MDB.MDBParameter("RangHamMat", BenhAnNoiTruYHCT.RangHamMat));
            Command.Parameters.Add(new MDB.MDBParameter("Mat", BenhAnNoiTruYHCT.Mat));
            Command.Parameters.Add(new MDB.MDBParameter("Khac_CacCoQuan", BenhAnNoiTruYHCT.Khac_CacCoQuan));
            Command.Parameters.Add(new MDB.MDBParameter("CacXetNghiemCanLamSangCanLam", BenhAnNoiTruYHCT.CacXetNghiemCanLamSangCanLam));
            Command.Parameters.Add(new MDB.MDBParameter("TomTatBenhAn", BenhAnNoiTruYHCT.TomTatBenhAn));
            Command.Parameters.Add(new MDB.MDBParameter("BenhChinh", BenhAnNoiTruYHCT.BenhChinh));
            Command.Parameters.Add(new MDB.MDBParameter("BenhKemTheo", BenhAnNoiTruYHCT.BenhKemTheo));
            Command.Parameters.Add(new MDB.MDBParameter("PhanBiet", BenhAnNoiTruYHCT.PhanBiet));
            Command.Parameters.Add(new MDB.MDBParameter("TienLuong", BenhAnNoiTruYHCT.TienLuong));
            Command.Parameters.Add(new MDB.MDBParameter("HuongDieuTri", BenhAnNoiTruYHCT.HuongDieuTri));
            Command.Parameters.Add(new MDB.MDBParameter("NgayKhamBenh", BenhAnNoiTruYHCT.NgayKhamBenh));
            Command.Parameters.Add(new MDB.MDBParameter("BacSyLamBenhAn", BenhAnNoiTruYHCT.BacSyLamBenhAn));
            Command.Parameters.Add(new MDB.MDBParameter("QuaTrinhBenhLyVaDienBien", BenhAnNoiTruYHCT.QuaTrinhBenhLyVaDienBien));
            Command.Parameters.Add(new MDB.MDBParameter("TomTatKetQuaXetNghiem", BenhAnNoiTruYHCT.TomTatKetQuaXetNghiem));
            Command.Parameters.Add(new MDB.MDBParameter("PhuongPhapDieuTri", BenhAnNoiTruYHCT.PhuongPhapDieuTri));
            Command.Parameters.Add(new MDB.MDBParameter("TinhTrangNguoiBenhRaVien", BenhAnNoiTruYHCT.TinhTrangNguoiBenhRaVien));
            Command.Parameters.Add(new MDB.MDBParameter("HuongDieuTriVaCacCheDoTiepTheo", BenhAnNoiTruYHCT.HuongDieuTriVaCacCheDoTiepTheo));
            Command.Parameters.Add(new MDB.MDBParameter("NguoiNhanHoSo", BenhAnNoiTruYHCT.NguoiNhanHoSo));
            Command.Parameters.Add(new MDB.MDBParameter("NguoiGiaoHoSo", BenhAnNoiTruYHCT.NguoiGiaoHoSo));
            Command.Parameters.Add(new MDB.MDBParameter("NgayTongKet", BenhAnNoiTruYHCT.NgayTongKet));
            Command.Parameters.Add(new MDB.MDBParameter("BacSyDieuTri", BenhAnNoiTruYHCT.BacSyDieuTri));
            Command.Parameters.Add(new MDB.MDBParameter("DiUng", BenhAnNoiTruYHCT.DacDiemLienQuanBenh.DiUng == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("DiUng_Text", BenhAnNoiTruYHCT.DacDiemLienQuanBenh.DiUng_Text));
            Command.Parameters.Add(new MDB.MDBParameter("MaTuy", BenhAnNoiTruYHCT.DacDiemLienQuanBenh.MaTuy == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("MaTuy_Text", BenhAnNoiTruYHCT.DacDiemLienQuanBenh.MaTuy_Text));
            Command.Parameters.Add(new MDB.MDBParameter("RuouBia", BenhAnNoiTruYHCT.DacDiemLienQuanBenh.RuouBia == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("RuouBia_Text", BenhAnNoiTruYHCT.DacDiemLienQuanBenh.RuouBia_Text));
            Command.Parameters.Add(new MDB.MDBParameter("ThuocLa", BenhAnNoiTruYHCT.DacDiemLienQuanBenh.ThuocLa == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("ThuocLa_Text", BenhAnNoiTruYHCT.DacDiemLienQuanBenh.ThuocLa_Text));
            Command.Parameters.Add(new MDB.MDBParameter("ThuocLao", BenhAnNoiTruYHCT.DacDiemLienQuanBenh.ThuocLao == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("ThuocLao_Text", BenhAnNoiTruYHCT.DacDiemLienQuanBenh.ThuocLao_Text));
            Command.Parameters.Add(new MDB.MDBParameter("Khac_DacDiemLienQuanBenh", BenhAnNoiTruYHCT.DacDiemLienQuanBenh.Khac_DacDiemLienQuanBenh == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("Khac_DacDiemLienQuanBenh_Text", BenhAnNoiTruYHCT.DacDiemLienQuanBenh.Khac_DacDiemLienQuanBenh_Text));
            Command.Parameters.Add(new MDB.MDBParameter("BenhSu", BenhAnNoiTruYHCT.BenhSu));
            Command.Parameters.Add(new MDB.MDBParameter("MoTaChiTietCoQuanBenhLy", BenhAnNoiTruYHCT.MoTaChiTietCoQuanBenhLy));
            Command.Parameters.Add(new MDB.MDBParameter("HinhThai_Gay", BenhAnNoiTruYHCT.HinhThai_Gay == true ? "1" : "0"));
            // add
            Command.Parameters.Add(new MDB.MDBParameter("Bung_Dau", BenhAnNoiTruYHCT.Bung_Dau == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("ChanTay_Dau", BenhAnNoiTruYHCT.ChanTay_Dau == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("ChanTay_Te", BenhAnNoiTruYHCT.ChanTay_Te == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("ChanTay_Buon", BenhAnNoiTruYHCT.ChanTay_Buon == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("ChanTay_Moi", BenhAnNoiTruYHCT.ChanTay_Moi == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("ChanTay_Nhuc", BenhAnNoiTruYHCT.ChanTay_Nhuc == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("ChanTay_Nong", BenhAnNoiTruYHCT.ChanTay_Nong == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("ChanTay_Lanh", BenhAnNoiTruYHCT.ChanTay_Lanh == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("ChanTay_Khac", BenhAnNoiTruYHCT.ChanTay_Khac == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("Nam_Khac", BenhAnNoiTruYHCT.Nam_Khac == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("Nu_DongThai", BenhAnNoiTruYHCT.Nu_DongThai == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("Nu_SayThai", BenhAnNoiTruYHCT.Nu_SayThai == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("MacChan_Nhu", BenhAnNoiTruYHCT.MacChan_Nhu == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("DinhViBenhTheo_Ve", BenhAnNoiTruYHCT.DinhViBenhTheo_Ve == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("DinhViBenhTheo_Khi", BenhAnNoiTruYHCT.DinhViBenhTheo_Khi == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("DinhViBenhTheo_Dinh", BenhAnNoiTruYHCT.DinhViBenhTheo_Dinh == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("DinhViBenhTheo_Huyet", BenhAnNoiTruYHCT.DinhViBenhTheo_Huyet == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("NguyenNhan_NoiNhan", BenhAnNoiTruYHCT.NguyenNhan_NoiNhan == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("NguyenNhan_NgoaiNhan", BenhAnNoiTruYHCT.NguyenNhan_NgoaiNhan == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("NguyenNhan_BatNoiNgoai", BenhAnNoiTruYHCT.NguyenNhan_BatNoiNgoai == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("TangPhu_Tam", BenhAnNoiTruYHCT.TangPhu_Tam == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("TangPhu_Lan", BenhAnNoiTruYHCT.TangPhu_Lan == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("TangPhu_Ty", BenhAnNoiTruYHCT.TangPhu_Ty == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("TangPhu_Phe", BenhAnNoiTruYHCT.TangPhu_Phe == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("TangPhu_Than", BenhAnNoiTruYHCT.TangPhu_Than == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("TangPhu_TamBao", BenhAnNoiTruYHCT.TangPhu_TamBao == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("TangPhu_TieuTruong", BenhAnNoiTruYHCT.TangPhu_TieuTruong == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("TangPhu_Dom", BenhAnNoiTruYHCT.TangPhu_Dom == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("TangPhu_Vi", BenhAnNoiTruYHCT.TangPhu_Vi == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("TangPhu_DaiTruong", BenhAnNoiTruYHCT.TangPhu_DaiTruong == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("TangPhu_BangQuang", BenhAnNoiTruYHCT.TangPhu_BangQuang == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("TangPhu_TamTieu", BenhAnNoiTruYHCT.TangPhu_TamTieu == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("TangPhu_PhuKyHang", BenhAnNoiTruYHCT.TangPhu_PhuKyHang == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("KinhMach_Tam", BenhAnNoiTruYHCT.KinhMach_Tam == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("DauDau_DauThat", BenhAnNoiTruYHCT.DauDau_DauThat == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("DauDau_Khac", BenhAnNoiTruYHCT.DauDau_Khac == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("Mat_Dau", BenhAnNoiTruYHCT.Mat_Dau == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("Mat_Khac", BenhAnNoiTruYHCT.Mat_Khac == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("Mui_Khac", BenhAnNoiTruYHCT.Mui_Khac == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("Hong_Khac", BenhAnNoiTruYHCT.Hong_Khac == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("KinhMach_Lan", BenhAnNoiTruYHCT.KinhMach_Lan == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("KinhMach_Ty", BenhAnNoiTruYHCT.KinhMach_Ty == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("KinhMach_Phe", BenhAnNoiTruYHCT.KinhMach_Phe == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("KinhMach_Than", BenhAnNoiTruYHCT.KinhMach_Than == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("KinhMach_TamBao", BenhAnNoiTruYHCT.KinhMach_TamBao == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("KinhMach_TieuTruong", BenhAnNoiTruYHCT.KinhMach_TieuTruong == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("KinhMach_Dom", BenhAnNoiTruYHCT.KinhMach_Dom == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("KinhMach_Vi", BenhAnNoiTruYHCT.KinhMach_Vi == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("KinhMach_DaiTruong", BenhAnNoiTruYHCT.KinhMach_DaiTruong == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("KinhMach_BangQuang", BenhAnNoiTruYHCT.KinhMach_BangQuang == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("KinhMach_TamTieu", BenhAnNoiTruYHCT.KinhMach_TamTieu == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("KinhMach_MachDoc", BenhAnNoiTruYHCT.KinhMach_MachDoc == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("KinhMach_MachNham", BenhAnNoiTruYHCT.KinhMach_MachNham == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("BatCuong_Bieu", BenhAnNoiTruYHCT.BatCuong_Bieu == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("BatCuong_Ly", BenhAnNoiTruYHCT.BatCuong_Ly == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("BatCuong_Hu", BenhAnNoiTruYHCT.BatCuong_Hu == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("BatCuong_Thuc", BenhAnNoiTruYHCT.BatCuong_Thuc == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("BatCuong_Han", BenhAnNoiTruYHCT.BatCuong_Han == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("BatCuong_Nhiet", BenhAnNoiTruYHCT.BatCuong_Nhiet == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("BatCuong_Am", BenhAnNoiTruYHCT.BatCuong_Am == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("BatCuong_Duong", BenhAnNoiTruYHCT.BatCuong_Duong == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("Bung", BenhAnNoiTruYHCT.Bung == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("DoiHa", BenhAnNoiTruYHCT.DoiHa == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("CoXuongKhop_BinhThuong", BenhAnNoiTruYHCT.CoXuongKhop_BinhThuong == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("Bung_BinhThuong", BenhAnNoiTruYHCT.Bung_BinhThuong == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("PPKhongDungThuoc", BenhAnNoiTruYHCT.PPKhongDungThuoc));
            Command.Parameters.Add(new MDB.MDBParameter("PPKhac", BenhAnNoiTruYHCT.PPKhac));
            Command.Parameters.Add(new MDB.MDBParameter("MotaTienSuBanThan", BenhAnNoiTruYHCT.MotaTienSuBanThan));
            Command.Parameters.Add(new MDB.MDBParameter("ChanDoanVVYHCT_BenhChinh", BenhAnNoiTruYHCT.ChanDoanVVYHCT_BenhChinh));
            Command.Parameters.Add(new MDB.MDBParameter("ChanDoanVVYHCT_KemTheo", BenhAnNoiTruYHCT.ChanDoanVVYHCT_KemTheo));
            Command.Parameters.Add(new MDB.MDBParameter("MaICDChanDoanVVYHCT_BenhChinh", BenhAnNoiTruYHCT.MaICDChanDoanVVYHCT_BenhChinh));
            Command.Parameters.Add(new MDB.MDBParameter("MaICDChanDoanVVYHCT_KemTheo", BenhAnNoiTruYHCT.MaICDChanDoanVVYHCT_KemTheo));
            Command.Parameters.Add(new MDB.MDBParameter("ChanDoanVVYHHD_BenhChinh", BenhAnNoiTruYHCT.ChanDoanVVYHHD_BenhChinh));
            Command.Parameters.Add(new MDB.MDBParameter("ChanDoanVVYHD_KemTheo", BenhAnNoiTruYHCT.ChanDoanVVYHD_KemTheo));
            Command.Parameters.Add(new MDB.MDBParameter("MaICDVVYHD_BenhChinh", BenhAnNoiTruYHCT.MaICDVVYHD_BenhChinh));
            Command.Parameters.Add(new MDB.MDBParameter("MaICDChanDoanVVYHD_KemTheo", BenhAnNoiTruYHCT.MaICDChanDoanVVYHD_KemTheo));
            Command.Parameters.Add(new MDB.MDBParameter("ChanDoanRVYHCT_BenhChinh", BenhAnNoiTruYHCT.ChanDoanRVYHCT_BenhChinh));
            Command.Parameters.Add(new MDB.MDBParameter("ChanDoanRVYHCT_KemTheo", BenhAnNoiTruYHCT.ChanDoanRVYHCT_KemTheo));
            Command.Parameters.Add(new MDB.MDBParameter("MaICDChanDoanRVYHCT_BenhChinh", BenhAnNoiTruYHCT.MaICDChanDoanRVYHCT_BenhChinh));
            Command.Parameters.Add(new MDB.MDBParameter("MaICDChanDoanRVYHCT_KemTheo", BenhAnNoiTruYHCT.MaICDChanDoanRVYHCT_KemTheo));
            Command.Parameters.Add(new MDB.MDBParameter("ChanDoanRVYHHD_BenhChinh", BenhAnNoiTruYHCT.ChanDoanRVYHHD_BenhChinh));
            Command.Parameters.Add(new MDB.MDBParameter("ChanDoanRVYHD_KemTheo", BenhAnNoiTruYHCT.ChanDoanRVYHD_KemTheo));
            Command.Parameters.Add(new MDB.MDBParameter("MaICDRVYHD_BenhChinh", BenhAnNoiTruYHCT.MaICDRVYHD_BenhChinh));
            Command.Parameters.Add(new MDB.MDBParameter("MaICDChanDoanRVYHD_KemTheo", BenhAnNoiTruYHCT.MaICDChanDoanRVYHD_KemTheo));

            Command.Parameters.Add(new MDB.MDBParameter("ChanDoan_NoiChuyenDen_YHCT", BenhAnNoiTruYHCT.ChanDoan_NoiChuyenDen_YHCT));
            Command.Parameters.Add(new MDB.MDBParameter("MaICD_NoiChuyenDen_YHCT", BenhAnNoiTruYHCT.MaICD_NoiChuyenDen_YHCT));
            Command.Parameters.Add(new MDB.MDBParameter("ChanDoan_KKB_CapCuu_YHCT", BenhAnNoiTruYHCT.ChanDoan_KKB_CapCuu_YHCT));
            Command.Parameters.Add(new MDB.MDBParameter("MaICD_KKB_CapCuu_YHCT", BenhAnNoiTruYHCT.MaICD_KKB_CapCuu_YHCT));
            Command.Parameters.Add(new MDB.MDBParameter("HOSOKQ_XQUANG", BenhAnNoiTruYHCT.HOSOKQ_XQUANG));
            Command.Parameters.Add(new MDB.MDBParameter("HOSOKQ_CTSCANNER", BenhAnNoiTruYHCT.HOSOKQ_CTSCANNER));
            Command.Parameters.Add(new MDB.MDBParameter("HOSOKQ_MRI", BenhAnNoiTruYHCT.HOSOKQ_MRI));
            Command.Parameters.Add(new MDB.MDBParameter("HOSOKQ_KHAC_TXT", BenhAnNoiTruYHCT.HOSOKQ_KHAC_TXT));
            Command.Parameters.Add(new MDB.MDBParameter("HOSOKQ_KHAC", BenhAnNoiTruYHCT.HOSOKQ_KHAC));
            Command.Parameters.Add(new MDB.MDBParameter("HOSOKQ_TOANBOHOSO", BenhAnNoiTruYHCT.HOSOKQ_TOANBOHOSO));
            Command.Parameters.Add(new MDB.MDBParameter("BenhChinh_YHCT", BenhAnNoiTruYHCT.BenhChinh_YHCT));
            Command.Parameters.Add(new MDB.MDBParameter("MaICD_BenhChinh_YHCT", BenhAnNoiTruYHCT.MaICD_BenhChinh_YHCT));
            Command.Parameters.Add(new MDB.MDBParameter("BenhKemTheo_YHCT", BenhAnNoiTruYHCT.BenhKemTheo_YHCT));
            Command.Parameters.Add(new MDB.MDBParameter("MaICD_BenhKemTheo_YHCT", BenhAnNoiTruYHCT.MaICD_BenhKemTheo_YHCT));
            Command.Parameters.Add(new MDB.MDBParameter("ThuThuat_YHCT", BenhAnNoiTruYHCT.ThuThuat_YHCT == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("PhauThuat_YHCT", BenhAnNoiTruYHCT.PhauThuat_YHCT == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("BenhChinh_RV_YHCT", BenhAnNoiTruYHCT.BenhChinh_RV_YHCT));
            Command.Parameters.Add(new MDB.MDBParameter("MaICD_BenhChinh_RV_YHCT", BenhAnNoiTruYHCT.MaICD_BenhChinh_RV_YHCT));
            Command.Parameters.Add(new MDB.MDBParameter("BenhKemTheo_RV_YHCT", BenhAnNoiTruYHCT.BenhKemTheo_RV_YHCT));
            Command.Parameters.Add(new MDB.MDBParameter("MaICD_BenhKemTheo_RV_YHCT", BenhAnNoiTruYHCT.MaICD_BenhKemTheo_RV_YHCT));
            Command.Parameters.Add(new MDB.MDBParameter("TaiBien_YHCT", BenhAnNoiTruYHCT.TaiBien_YHCT == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("BienChung_YHCT", BenhAnNoiTruYHCT.BienChung_YHCT == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("MaICD_BenhKemTheo_YHHD", BenhAnNoiTruYHCT.MaICD_BenhKemTheo_YHHD));
            Command.Parameters.Add(new MDB.MDBParameter("MaICD_BenhChinh_YHHD_CD", BenhAnNoiTruYHCT.MaICD_BenhChinh_YHHD_CD));
            Command.Parameters.Add(new MDB.MDBParameter("MaICD_BenhKemTheo_YHHD_CD", BenhAnNoiTruYHCT.MaICD_BenhKemTheo_YHHD_CD));
            Command.Parameters.Add(new MDB.MDBParameter("CheDoDinhDuong_Long", BenhAnNoiTruYHCT.CheDoDinhDuong_Long == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("CheDoDinhDuong_Dac", BenhAnNoiTruYHCT.CheDoDinhDuong_Dac == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("CheDoDinhDuong_Kieng", BenhAnNoiTruYHCT.CheDoDinhDuong_Kieng == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("CheDoDinhDuong_Khac", BenhAnNoiTruYHCT.CheDoDinhDuong_Khac == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("CheDoChamSoc_1", BenhAnNoiTruYHCT.CheDoChamSoc_1 == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("CheDoChamSoc_2", BenhAnNoiTruYHCT.CheDoChamSoc_2 == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("CheDoChamSoc_3", BenhAnNoiTruYHCT.CheDoChamSoc_3 == true ? "1" : "0"));
            //
            Command.Parameters.Add(new MDB.MDBParameter("HinhThai_Beo", BenhAnNoiTruYHCT.HinhThai_Beo == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("HinhThai_CanDoi", BenhAnNoiTruYHCT.HinhThai_CanDoi == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("HinhThai_NamCo", BenhAnNoiTruYHCT.HinhThai_NamCo == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("HinhThai_UaTinh", BenhAnNoiTruYHCT.HinhThai_UaTinh == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("HinhThai_NamDuoi", BenhAnNoiTruYHCT.HinhThai_NamDuoi == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("HinhThai_HieuDong", BenhAnNoiTruYHCT.HinhThai_HieuDong == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("HinhThai_Khac", BenhAnNoiTruYHCT.HinhThai_Khac == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("Than_ConThan", BenhAnNoiTruYHCT.Than_ConThan == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("Than_KhongConThan", BenhAnNoiTruYHCT.Than_KhongConThan == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("Than_Khac", BenhAnNoiTruYHCT.Than_Khac == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("Sac_BechTrang", BenhAnNoiTruYHCT.Sac_BechTrang == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("Sac_Do", BenhAnNoiTruYHCT.Sac_Do == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("Sac_Vang", BenhAnNoiTruYHCT.Sac_Vang == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("Sac_Xanh", BenhAnNoiTruYHCT.Sac_Xanh == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("Sac_Den", BenhAnNoiTruYHCT.Sac_Den == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("Sac_Khac", BenhAnNoiTruYHCT.Sac_Khac == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("Sac_BinhThuong", BenhAnNoiTruYHCT.Sac_BinhThuong == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("Trach_TuoiNhuan", BenhAnNoiTruYHCT.Trach_TuoiNhuan == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("Trach_Kho", BenhAnNoiTruYHCT.Trach_Kho == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("Trach_Khac", BenhAnNoiTruYHCT.Trach_Khac == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("ChatLuoi_BinhThuong", BenhAnNoiTruYHCT.ChatLuoi_BinhThuong == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("ChatLuoi_Beu", BenhAnNoiTruYHCT.ChatLuoi_Beu == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("ChatLuoi_GayMong", BenhAnNoiTruYHCT.ChatLuoi_GayMong == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("ChatLuoi_Nut", BenhAnNoiTruYHCT.ChatLuoi_Nut == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("ChatLuoi_Cung", BenhAnNoiTruYHCT.ChatLuoi_Cung == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("ChatLuoi_Loet", BenhAnNoiTruYHCT.ChatLuoi_Loet == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("ChatLuoi_Lech", BenhAnNoiTruYHCT.ChatLuoi_Lech == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("ChatLuoi_Rut", BenhAnNoiTruYHCT.ChatLuoi_Rut == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("ChatLuoi_Khac", BenhAnNoiTruYHCT.ChatLuoi_Khac == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("SacLuoi_Hong", BenhAnNoiTruYHCT.SacLuoi_Hong == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("SacLuoi_Nhot", BenhAnNoiTruYHCT.SacLuoi_Nhot == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("SacLuoi_Do", BenhAnNoiTruYHCT.SacLuoi_Do == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("SacLuoi_DoSam", BenhAnNoiTruYHCT.SacLuoi_DoSam == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("SacLuoi_XanhTim", BenhAnNoiTruYHCT.SacLuoi_XanhTim == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("SacLuoi_DamUHuyet", BenhAnNoiTruYHCT.SacLuoi_DamUHuyet == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("SacLuoi_Kho", BenhAnNoiTruYHCT.SacLuoi_Kho == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("SacLuoi_Nhuan", BenhAnNoiTruYHCT.SacLuoi_Nhuan == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("SacLuoi_Khac", BenhAnNoiTruYHCT.SacLuoi_Khac == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("ReuLuoi_Co", BenhAnNoiTruYHCT.ReuLuoi_Co == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("ReuLuoi_Khong", BenhAnNoiTruYHCT.ReuLuoi_Khong == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("ReuLuoi_Bong", BenhAnNoiTruYHCT.ReuLuoi_Bong == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("ReuLuoi_Day", BenhAnNoiTruYHCT.ReuLuoi_Day == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("ReuLuoi_Mong", BenhAnNoiTruYHCT.ReuLuoi_Mong == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("ReuLuoi_Uot", BenhAnNoiTruYHCT.ReuLuoi_Uot == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("ReuLuoi_Kho", BenhAnNoiTruYHCT.ReuLuoi_Kho == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("ReuLuoi_Dinh", BenhAnNoiTruYHCT.ReuLuoi_Dinh == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("ReuLuoi_Trang", BenhAnNoiTruYHCT.ReuLuoi_Trang == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("ReuLuoi_Vang", BenhAnNoiTruYHCT.ReuLuoi_Vang == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("ReuLuoi_Den", BenhAnNoiTruYHCT.ReuLuoi_Den == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("ReuLuoi_Khac", BenhAnNoiTruYHCT.ReuLuoi_Khac == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("MoTaVongChan", BenhAnNoiTruYHCT.MoTaVongChan));
            Command.Parameters.Add(new MDB.MDBParameter("TiengNoi_BinhThuong", BenhAnNoiTruYHCT.TiengNoi_BinhThuong == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("TiengNoi_To", BenhAnNoiTruYHCT.TiengNoi_To == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("TiengNoi_Nho", BenhAnNoiTruYHCT.TiengNoi_Nho == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("TiengNoi_DutQuang", BenhAnNoiTruYHCT.TiengNoi_DutQuang == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("TiengNoi_Khan", BenhAnNoiTruYHCT.TiengNoi_Khan == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("TiengNoi_Ngong", BenhAnNoiTruYHCT.TiengNoi_Ngong == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("TiengNoi_Mat", BenhAnNoiTruYHCT.TiengNoi_Mat == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("TiengNoi_Khac", BenhAnNoiTruYHCT.TiengNoi_Khac == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("HoiTho_BinhThuong", BenhAnNoiTruYHCT.HoiTho_BinhThuong == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("HoiTho_DutQuang", BenhAnNoiTruYHCT.HoiTho_DutQuang == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("HoiTho_Ngan", BenhAnNoiTruYHCT.HoiTho_Ngan == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("HoiTho_Manh", BenhAnNoiTruYHCT.HoiTho_Manh == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("HoiTho_Yeu", BenhAnNoiTruYHCT.HoiTho_Yeu == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("HoiTho_Tho", BenhAnNoiTruYHCT.HoiTho_Tho == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("HoiTho_Rit", BenhAnNoiTruYHCT.HoiTho_Rit == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("HoiTho_KhoKhe", BenhAnNoiTruYHCT.HoiTho_KhoKhe == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("HoiTho_Cham", BenhAnNoiTruYHCT.HoiTho_Cham == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("HoiTho_Gap", BenhAnNoiTruYHCT.HoiTho_Gap == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("HoiTho_Khac", BenhAnNoiTruYHCT.HoiTho_Khac == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("Ho", BenhAnNoiTruYHCT.Ho == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("Ho_HoLienTuc", BenhAnNoiTruYHCT.Ho_HoLienTuc == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("Ho_Con", BenhAnNoiTruYHCT.Ho_Con == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("Ho_It", BenhAnNoiTruYHCT.Ho_It == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("Ho_Nhieu", BenhAnNoiTruYHCT.Ho_Nhieu == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("Ho_Khan", BenhAnNoiTruYHCT.Ho_Khan == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("Ho_CoDom", BenhAnNoiTruYHCT.Ho_CoDom == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("Ho_Khac", BenhAnNoiTruYHCT.Ho_Khac == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("O", BenhAnNoiTruYHCT.O == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("Nac", BenhAnNoiTruYHCT.Nac == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("MuiCoThe", BenhAnNoiTruYHCT.MuiCoThe == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("MuiCoThe_Chua", BenhAnNoiTruYHCT.MuiCoThe_Chua == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("MuiCoThe_Kham", BenhAnNoiTruYHCT.MuiCoThe_Kham == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("MuiCoThe_Tanh", BenhAnNoiTruYHCT.MuiCoThe_Tanh == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("MuiCoThe_Thoi", BenhAnNoiTruYHCT.MuiCoThe_Thoi == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("MuiCoThe_Hoi", BenhAnNoiTruYHCT.MuiCoThe_Hoi == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("MuiCoThe_Khac", BenhAnNoiTruYHCT.MuiCoThe_Khac == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("ChatThaiBieuHienBenhLy", BenhAnNoiTruYHCT.ChatThaiBieuHienBenhLy == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("ChatThai_Dom", BenhAnNoiTruYHCT.ChatThai_Dom == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("ChatThai_ChatNon", BenhAnNoiTruYHCT.ChatThai_ChatNon == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("ChatThai_Phan", BenhAnNoiTruYHCT.ChatThai_Phan == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("ChatThai_NuocTieu", BenhAnNoiTruYHCT.ChatThai_NuocTieu == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("ChatThai_KhiHu", BenhAnNoiTruYHCT.ChatThai_KhiHu == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("ChatThai_KinhNguyet", BenhAnNoiTruYHCT.ChatThai_KinhNguyet == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("ChatThai_Khac", BenhAnNoiTruYHCT.ChatThai_Khac == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("MoTaVanChan", BenhAnNoiTruYHCT.MoTaVanChan));
            Command.Parameters.Add(new MDB.MDBParameter("HanNhiet_BinhThuong", BenhAnNoiTruYHCT.HanNhiet_BinhThuong == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("HanNhiet_Han", BenhAnNoiTruYHCT.HanNhiet_Han == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("HanNhiet_Nhiet", BenhAnNoiTruYHCT.HanNhiet_Nhiet == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("HanNhiet_Khac", BenhAnNoiTruYHCT.HanNhiet_Khac == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("HanNhiet_ThichNong", BenhAnNoiTruYHCT.HanNhiet_ThichNong == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("HanNhiet_SoNong", BenhAnNoiTruYHCT.HanNhiet_SoNong == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("HanNhiet_ThichMat", BenhAnNoiTruYHCT.HanNhiet_ThichMat == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("HanNhiet_SoLanh", BenhAnNoiTruYHCT.HanNhiet_SoLanh == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("HanNhiet_TrongNguoiNong", BenhAnNoiTruYHCT.HanNhiet_TrongNguoiNong == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("HanNhiet_TrongNguoiLanh", BenhAnNoiTruYHCT.HanNhiet_TrongNguoiLanh == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("HanNhiet_RetRun", BenhAnNoiTruYHCT.HanNhiet_RetRun == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("HanNhiet_HanNhietVangLai", BenhAnNoiTruYHCT.HanNhiet_HanNhietVangLai == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("HanNhiet_Khac2", BenhAnNoiTruYHCT.HanNhiet_Khac2 == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("MoHoi_BinhThuong_ThietChan", BenhAnNoiTruYHCT.MoHoi_BinhThuong_ThietChan == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("MoHoi_BinhThuong", BenhAnNoiTruYHCT.MoHoi_BinhThuong == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("MoHoi_KhongCoMoHoi", BenhAnNoiTruYHCT.MoHoi_KhongCoMoHoi == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("MoHoi_TuHan", BenhAnNoiTruYHCT.MoHoi_TuHan == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("MoHoi_DaoHan", BenhAnNoiTruYHCT.MoHoi_DaoHan == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("MoHoi_Nhieu", BenhAnNoiTruYHCT.MoHoi_Nhieu == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("MoHoi_It", BenhAnNoiTruYHCT.MoHoi_It == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("MoHoi_Khac", BenhAnNoiTruYHCT.MoHoi_Khac == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("DauMat", BenhAnNoiTruYHCT.DauMat == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("DauDau_MotCho", BenhAnNoiTruYHCT.DauDau_MotCho == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("DauDau_NuaDau", BenhAnNoiTruYHCT.DauDau_NuaDau == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("DauDau_CaDau", BenhAnNoiTruYHCT.DauDau_CaDau == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("DauDau_DiChuyen", BenhAnNoiTruYHCT.DauDau_DiChuyen == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("DauDau_EAmNhuBiBuocLai", BenhAnNoiTruYHCT.DauDau_EAmNhuBiBuocLai == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("DauDau_Nhoi", BenhAnNoiTruYHCT.DauDau_Nhoi == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("DauDau_Cang", BenhAnNoiTruYHCT.DauDau_Cang == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("DauDau_NangDau", BenhAnNoiTruYHCT.DauDau_NangDau == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("Mat_HoaMatChongMat", BenhAnNoiTruYHCT.Mat_HoaMatChongMat == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("Mat_NhinKhongRo", BenhAnNoiTruYHCT.Mat_NhinKhongRo == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("Tai_U", BenhAnNoiTruYHCT.Tai_U == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("Tai_Diec", BenhAnNoiTruYHCT.Tai_Diec == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("Tai_Nang", BenhAnNoiTruYHCT.Tai_Nang == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("Tai_", BenhAnNoiTruYHCT.Tai_ == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("Tai_Dau", BenhAnNoiTruYHCT.Tai_Dau == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("Mui_Ngat", BenhAnNoiTruYHCT.Mui_Ngat == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("Mui_ChayNuoc", BenhAnNoiTruYHCT.Mui_ChayNuoc == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("Mui_ChayMauCam", BenhAnNoiTruYHCT.Mui_ChayMauCam == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("Mui_Dau", BenhAnNoiTruYHCT.Mui_Dau == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("Hong_Dau", BenhAnNoiTruYHCT.Hong_Dau == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("Hong_Kho", BenhAnNoiTruYHCT.Hong_Kho == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("CoVai_Moi", BenhAnNoiTruYHCT.CoVai_Moi == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("CoVai_Dau", BenhAnNoiTruYHCT.CoVai_Dau == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("CoVai_KhoVanDong", BenhAnNoiTruYHCT.CoVai_KhoVanDong == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("CoVai_Khac", BenhAnNoiTruYHCT.CoVai_Khac == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("Lung", BenhAnNoiTruYHCT.Lung == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("Lung_Dau", BenhAnNoiTruYHCT.Lung_Dau == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("Lung_KhoVanDong", BenhAnNoiTruYHCT.Lung_KhoVanDong == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("Lung_CoCungCo", BenhAnNoiTruYHCT.Lung_CoCungCo == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("Lung_Khac", BenhAnNoiTruYHCT.Lung_Khac == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("BungVaUc", BenhAnNoiTruYHCT.BungVaUc == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("BungNguc_Tuc", BenhAnNoiTruYHCT.BungNguc_Tuc == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("BungNguc_Dau", BenhAnNoiTruYHCT.BungNguc_Dau == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("BungNguc_Soi", BenhAnNoiTruYHCT.BungNguc_Soi == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("BungNguc_NongRuot", BenhAnNoiTruYHCT.BungNguc_NongRuot == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("BungNguc_DayTruong", BenhAnNoiTruYHCT.BungNguc_DayTruong == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("BungNguc_NgotNgatKhoTho", BenhAnNoiTruYHCT.BungNguc_NgotNgatKhoTho == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("BungNguc_DauTucCanhSuon", BenhAnNoiTruYHCT.BungNguc_DauTucCanhSuon == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("BungNguc_BonChonKhongYen", BenhAnNoiTruYHCT.BungNguc_BonChonKhongYen == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("BungNguc_DanhTrongNguc", BenhAnNoiTruYHCT.BungNguc_DanhTrongNguc == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("BungNguc_Khac", BenhAnNoiTruYHCT.BungNguc_Khac == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("ChanTay", BenhAnNoiTruYHCT.ChanTay == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("An", BenhAnNoiTruYHCT.An == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("An_ThichNong", BenhAnNoiTruYHCT.An_ThichNong == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("An_ThichMat", BenhAnNoiTruYHCT.An_ThichMat == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("An_AnNhieu", BenhAnNoiTruYHCT.An_AnNhieu == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("An_AnIt", BenhAnNoiTruYHCT.An_AnIt == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("An_DangMieng", BenhAnNoiTruYHCT.An_DangMieng == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("An_NhatMieng", BenhAnNoiTruYHCT.An_NhatMieng == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("An_ThemAn", BenhAnNoiTruYHCT.An_ThemAn == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("An_ChanAn", BenhAnNoiTruYHCT.An_ChanAn == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("An_AnVaoBungChuong", BenhAnNoiTruYHCT.An_AnVaoBungChuong == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("An_Khac", BenhAnNoiTruYHCT.An_Khac == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("Uong", BenhAnNoiTruYHCT.Uong == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("Uong_Mat", BenhAnNoiTruYHCT.Uong_Mat == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("Uong_AmNong", BenhAnNoiTruYHCT.Uong_AmNong == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("Uong_Nhieu", BenhAnNoiTruYHCT.Uong_Nhieu == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("Uong_It", BenhAnNoiTruYHCT.Uong_It == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("Uong_Khac", BenhAnNoiTruYHCT.Uong_Khac == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("DaiTieuTien", BenhAnNoiTruYHCT.DaiTieuTien == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("Tieutien_Vang", BenhAnNoiTruYHCT.Tieutien_Vang == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("Tieutien_Do", BenhAnNoiTruYHCT.Tieutien_Do == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("Tieutien_Duc", BenhAnNoiTruYHCT.Tieutien_Duc == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("Tieutien_Buot", BenhAnNoiTruYHCT.Tieutien_Buot == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("Tieutien_Dat", BenhAnNoiTruYHCT.Tieutien_Dat == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("Tieutien_KhongTuChu", BenhAnNoiTruYHCT.Tieutien_KhongTuChu == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("Tieutien_Bi", BenhAnNoiTruYHCT.Tieutien_Bi == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("Tieutien_Khac", BenhAnNoiTruYHCT.Tieutien_Khac == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("Daitien_Tao", BenhAnNoiTruYHCT.Daitien_Tao == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("Daitien_Nhao", BenhAnNoiTruYHCT.Daitien_Nhao == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("Daitien_Song", BenhAnNoiTruYHCT.Daitien_Song == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("Daitien_ToanNuoc", BenhAnNoiTruYHCT.Daitien_ToanNuoc == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("Daitien_NhayMui", BenhAnNoiTruYHCT.Daitien_NhayMui == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("Daitien_Bi", BenhAnNoiTruYHCT.Daitien_Bi == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("Daitien_Khac", BenhAnNoiTruYHCT.Daitien_Khac == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("Ngu", BenhAnNoiTruYHCT.Ngu == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("Ngu_KhoVaoGiacNgu", BenhAnNoiTruYHCT.Ngu_KhoVaoGiacNgu == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("Ngu_HayTinh", BenhAnNoiTruYHCT.Ngu_HayTinh == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("Ngu_DaySom", BenhAnNoiTruYHCT.Ngu_DaySom == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("Ngu_HayMo", BenhAnNoiTruYHCT.Ngu_HayMo == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("Ngu_Khac", BenhAnNoiTruYHCT.Ngu_Khac == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("KinhNguyet", BenhAnNoiTruYHCT.KinhNguyet == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("KinhNguyet_DenTruocKy", BenhAnNoiTruYHCT.KinhNguyet_DenTruocKy == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("KinhNguyet_DenSauKy", BenhAnNoiTruYHCT.KinhNguyet_DenSauKy == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("KinhNguyet_LucDenTruocLucDenS", BenhAnNoiTruYHCT.KinhNguyet_LucDenTruocLucDenS == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("KinhNguyet_TacKinh", BenhAnNoiTruYHCT.KinhNguyet_TacKinh == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("KinhNguyet_Khac", BenhAnNoiTruYHCT.KinhNguyet_Khac == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("ThongKinh_DauTruocKy", BenhAnNoiTruYHCT.ThongKinh_DauTruocKy == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("ThongKinh_DauTrongKy", BenhAnNoiTruYHCT.ThongKinh_DauTrongKy == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("ThongKinh_DauSauKy", BenhAnNoiTruYHCT.ThongKinh_DauSauKy == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("ThongKinh_Khac", BenhAnNoiTruYHCT.ThongKinh_Khac == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("DoiHa_Vang", BenhAnNoiTruYHCT.DoiHa_Vang == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("DoiHa_Trang", BenhAnNoiTruYHCT.DoiHa_Trang == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("DoiHa_Hoi", BenhAnNoiTruYHCT.DoiHa_Hoi == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("DoiHa_Hong", BenhAnNoiTruYHCT.DoiHa_Hong == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("DoiHa_Khac", BenhAnNoiTruYHCT.DoiHa_Khac == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("RoiHanKhaNangSinhDuc", BenhAnNoiTruYHCT.RoiHanKhaNangSinhDuc));
            Command.Parameters.Add(new MDB.MDBParameter("Nam_YeuKhiGiaoHop", BenhAnNoiTruYHCT.Nam_YeuKhiGiaoHop == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("Nam_LietDuong", BenhAnNoiTruYHCT.Nam_LietDuong == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("Nam_DiTinh", BenhAnNoiTruYHCT.Nam_DiTinh == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("Nam_HoatTinh", BenhAnNoiTruYHCT.Nam_HoatTinh == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("Nam_MongTinh", BenhAnNoiTruYHCT.Nam_MongTinh == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("Nam_LanhTinh", BenhAnNoiTruYHCT.Nam_LanhTinh == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("Nu_KhongThuThai", BenhAnNoiTruYHCT.Nu_KhongThuThai == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("Nu_SayThai_DongThai", BenhAnNoiTruYHCT.Nu_SayThai_DongThai == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("Nu_SayThaiLienTiep", BenhAnNoiTruYHCT.Nu_SayThaiLienTiep == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("Nu_Khac", BenhAnNoiTruYHCT.Nu_Khac == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("DieuKienXuatHienBenh", BenhAnNoiTruYHCT.DieuKienXuatHienBenh == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("MoTaVaanChan", BenhAnNoiTruYHCT.MoTaVaanChan));
            Command.Parameters.Add(new MDB.MDBParameter("Da_BinhThuong", BenhAnNoiTruYHCT.Da_BinhThuong == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("Da_Kho", BenhAnNoiTruYHCT.Da_Kho == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("Da_Nong", BenhAnNoiTruYHCT.Da_Nong == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("Da_Lanh", BenhAnNoiTruYHCT.Da_Lanh == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("Da_Uot", BenhAnNoiTruYHCT.Da_Uot == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("Da_ChanTayNong", BenhAnNoiTruYHCT.Da_ChanTayNong == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("Da_ChanTayLanh", BenhAnNoiTruYHCT.Da_ChanTayLanh == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("Da_AnLom", BenhAnNoiTruYHCT.Da_AnLom == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("Da_AnDau", BenhAnNoiTruYHCT.Da_AnDau == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("Da_CucCung", BenhAnNoiTruYHCT.Da_CucCung == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("Da_Khac", BenhAnNoiTruYHCT.Da_Khac == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("MoHoi_ToanThan", BenhAnNoiTruYHCT.MoHoi_ToanThan == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("MoHoi_Tran", BenhAnNoiTruYHCT.MoHoi_Tran == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("MoHoi_TayChan", BenhAnNoiTruYHCT.MoHoi_TayChan == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("MoHoi_KhacXucChan", BenhAnNoiTruYHCT.MoHoi_KhacXucChan == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("CoXuongKhop_SanChac", BenhAnNoiTruYHCT.CoXuongKhop_SanChac == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("CoXuongKhop_Mem", BenhAnNoiTruYHCT.CoXuongKhop_Mem == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("CoXuongKhop_CangCung", BenhAnNoiTruYHCT.CoXuongKhop_CangCung == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("CoXuongKhop_CoCoAnDau", BenhAnNoiTruYHCT.CoXuongKhop_CoCoAnDau == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("CoXuongKhop_GanDau", BenhAnNoiTruYHCT.CoXuongKhop_GanDau == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("CoXuongKhop_XuongKhopDau", BenhAnNoiTruYHCT.CoXuongKhop_XuongKhopDau == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("CoXuongKhop_Khac", BenhAnNoiTruYHCT.CoXuongKhop_Khac == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("Bung_Mem", BenhAnNoiTruYHCT.Bung_Mem == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("Bung_Chuong", BenhAnNoiTruYHCT.Bung_Chuong == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("Bung_CoChuong", BenhAnNoiTruYHCT.Bung_CoChuong == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("Bung_CoHonCuc", BenhAnNoiTruYHCT.Bung_CoHonCuc == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("Bung_DauThienAn", BenhAnNoiTruYHCT.Bung_DauThienAn == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("Bung_DauCuAn", BenhAnNoiTruYHCT.Bung_DauCuAn == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("Bung_Khac", BenhAnNoiTruYHCT.Bung_Khac == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("MacChan_Phu", BenhAnNoiTruYHCT.MacChan_Phu == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("MacChan_Tram", BenhAnNoiTruYHCT.MacChan_Tram == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("MacChan_Tri", BenhAnNoiTruYHCT.MacChan_Tri == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("MacChan_Sac", BenhAnNoiTruYHCT.MacChan_Sac == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("MacChan_Te", BenhAnNoiTruYHCT.MacChan_Te == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("MacChan_Huyen", BenhAnNoiTruYHCT.MacChan_Huyen == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("MacChan_Hoat", BenhAnNoiTruYHCT.MacChan_Hoat == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("MacChan_VoLuc", BenhAnNoiTruYHCT.MacChan_VoLuc == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("MacChan_CoLuc", BenhAnNoiTruYHCT.MacChan_CoLuc == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("MacChan_Khac", BenhAnNoiTruYHCT.MacChan_Khac == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("BenPhai_TongKhan", BenhAnNoiTruYHCT.BenPhai_TongKhan));
            Command.Parameters.Add(new MDB.MDBParameter("BenTrai_TongKhan", BenhAnNoiTruYHCT.BenTrai_TongKhan));
            Command.Parameters.Add(new MDB.MDBParameter("Ma_BenPhai_TongKhan", BenhAnNoiTruYHCT.Ma_BenPhai_TongKhan));
            Command.Parameters.Add(new MDB.MDBParameter("Ma_BenTrai_TongKhan", BenhAnNoiTruYHCT.Ma_BenTrai_TongKhan));
            Command.Parameters.Add(new MDB.MDBParameter("MachTayTrai_Thon1", BenhAnNoiTruYHCT.MachTayTrai_Thon1));
            Command.Parameters.Add(new MDB.MDBParameter("MachTayTrai_Thon2", BenhAnNoiTruYHCT.MachTayTrai_Thon2));
            Command.Parameters.Add(new MDB.MDBParameter("MachTayTrai_Thon3", BenhAnNoiTruYHCT.MachTayTrai_Thon3));
            Command.Parameters.Add(new MDB.MDBParameter("MachTayTrai_Thon4", BenhAnNoiTruYHCT.MachTayTrai_Thon4));
            Command.Parameters.Add(new MDB.MDBParameter("MachTayTrai_Quan1", BenhAnNoiTruYHCT.MachTayTrai_Quan1));
            Command.Parameters.Add(new MDB.MDBParameter("MachTayTrai_Quan2", BenhAnNoiTruYHCT.MachTayTrai_Quan2));
            Command.Parameters.Add(new MDB.MDBParameter("MachTayTrai_Quan3", BenhAnNoiTruYHCT.MachTayTrai_Quan3));
            Command.Parameters.Add(new MDB.MDBParameter("MachTayTrai_Quan4", BenhAnNoiTruYHCT.MachTayTrai_Quan4));
            Command.Parameters.Add(new MDB.MDBParameter("MachTayTrai_Xich1", BenhAnNoiTruYHCT.MachTayTrai_Xich1));
            Command.Parameters.Add(new MDB.MDBParameter("MachTayTrai_Xich2", BenhAnNoiTruYHCT.MachTayTrai_Xich2));
            Command.Parameters.Add(new MDB.MDBParameter("MachTayTrai_Xich3", BenhAnNoiTruYHCT.MachTayTrai_Xich3));
            Command.Parameters.Add(new MDB.MDBParameter("MachTayTrai_Xich4", BenhAnNoiTruYHCT.MachTayTrai_Xich4));
            Command.Parameters.Add(new MDB.MDBParameter("MachTayPhai_Thon1", BenhAnNoiTruYHCT.MachTayPhai_Thon1));
            Command.Parameters.Add(new MDB.MDBParameter("MachTayPhai_Thon2", BenhAnNoiTruYHCT.MachTayPhai_Thon2));
            Command.Parameters.Add(new MDB.MDBParameter("MachTayPhai_Thon3", BenhAnNoiTruYHCT.MachTayPhai_Thon3));
            Command.Parameters.Add(new MDB.MDBParameter("MachTayPhai_Thon4", BenhAnNoiTruYHCT.MachTayPhai_Thon4));
            Command.Parameters.Add(new MDB.MDBParameter("MachTayPhai_Quan1", BenhAnNoiTruYHCT.MachTayPhai_Quan1));
            Command.Parameters.Add(new MDB.MDBParameter("MachTayPhai_Quan2", BenhAnNoiTruYHCT.MachTayPhai_Quan2));
            Command.Parameters.Add(new MDB.MDBParameter("MachTayPhai_Quan3", BenhAnNoiTruYHCT.MachTayPhai_Quan3));
            Command.Parameters.Add(new MDB.MDBParameter("MachTayPhai_Quan4", BenhAnNoiTruYHCT.MachTayPhai_Quan4));
            Command.Parameters.Add(new MDB.MDBParameter("MachTayPhai_Xich1", BenhAnNoiTruYHCT.MachTayPhai_Xich1));
            Command.Parameters.Add(new MDB.MDBParameter("MachTayPhai_Xich2", BenhAnNoiTruYHCT.MachTayPhai_Xich2));
            Command.Parameters.Add(new MDB.MDBParameter("MachTayPhai_Xich3", BenhAnNoiTruYHCT.MachTayPhai_Xich3));
            Command.Parameters.Add(new MDB.MDBParameter("MachTayPhai_Xich4", BenhAnNoiTruYHCT.MachTayPhai_Xich4));
            Command.Parameters.Add(new MDB.MDBParameter("MoTaThietChan", BenhAnNoiTruYHCT.MoTaThietChan));
            Command.Parameters.Add(new MDB.MDBParameter("TomTatTuChan", BenhAnNoiTruYHCT.TomTatTuChan));
            Command.Parameters.Add(new MDB.MDBParameter("BienPhapLuanTri", BenhAnNoiTruYHCT.BienPhapLuanTri));
            Command.Parameters.Add(new MDB.MDBParameter("BietDanh", BenhAnNoiTruYHCT.BietDanh));
            Command.Parameters.Add(new MDB.MDBParameter("BatCuong", BenhAnNoiTruYHCT.BatCuong));
            Command.Parameters.Add(new MDB.MDBParameter("TangPhuKinhLac", BenhAnNoiTruYHCT.TangPhuKinhLac));
            Command.Parameters.Add(new MDB.MDBParameter("NguyenNhan", BenhAnNoiTruYHCT.NguyenNhan));
            Command.Parameters.Add(new MDB.MDBParameter("DieuTriYHCT", BenhAnNoiTruYHCT.DieuTriYHCT == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("PhapDieuTri", BenhAnNoiTruYHCT.PhapDieuTri));
            Command.Parameters.Add(new MDB.MDBParameter("PhuongThuoc", BenhAnNoiTruYHCT.PhuongThuoc));
            Command.Parameters.Add(new MDB.MDBParameter("PhuongHuyet", BenhAnNoiTruYHCT.PhuongHuyet));
            Command.Parameters.Add(new MDB.MDBParameter("XoaBopBamHuyet", BenhAnNoiTruYHCT.XoaBopBamHuyet));
            Command.Parameters.Add(new MDB.MDBParameter("Khac_DieuTri", BenhAnNoiTruYHCT.Khac_DieuTri));
            Command.Parameters.Add(new MDB.MDBParameter("DieuTriKetHopVoiYHHD", BenhAnNoiTruYHCT.DieuTriKetHopVoiYHHD == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("DieuTriKetHopVoiYHHD_Text", BenhAnNoiTruYHCT.DieuTriKetHopVoiYHHD_Text));
            Command.Parameters.Add(new MDB.MDBParameter("CheDoDinhDuong", BenhAnNoiTruYHCT.CheDoDinhDuong));
            Command.Parameters.Add(new MDB.MDBParameter("CheDoChamSoc", BenhAnNoiTruYHCT.CheDoChamSoc));
            Command.Parameters.Add(new MDB.MDBParameter("ChanDoanVaoVienTheoYHCT", BenhAnNoiTruYHCT.ChanDoanVaoVienTheoYHCT));
            Command.Parameters.Add(new MDB.MDBParameter("ChanDoanVaoVienTheoYHHD", BenhAnNoiTruYHCT.ChanDoanVaoVienTheoYHHD));
            Command.Parameters.Add(new MDB.MDBParameter("PhuongPhapDieuTriTheoYHHD", BenhAnNoiTruYHCT.PhuongPhapDieuTriTheoYHHD));
            Command.Parameters.Add(new MDB.MDBParameter("PhuongPhapDieuTriTheoYHCT", BenhAnNoiTruYHCT.PhuongPhapDieuTriTheoYHCT));
            Command.Parameters.Add(new MDB.MDBParameter("ChanDoanRaVienTheoYHCT", BenhAnNoiTruYHCT.ChanDoanRaVienTheoYHCT));
            Command.Parameters.Add(new MDB.MDBParameter("ChanDoanRaVienTheoYHHD", BenhAnNoiTruYHCT.ChanDoanRaVienTheoYHHD));
            Command.Parameters.Add(new MDB.MDBParameter("KetQuaDieuTriID", BenhAnNoiTruYHCT.KetQuaDieuTriID));
            Command.Parameters.Add(new MDB.MDBParameter("TinhTrangNguoiBenhKhiRavien", BenhAnNoiTruYHCT.TinhTrangNguoiBenhKhiRavien));

            Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", BenhAnNoiTruYHCT.MaQuanLy));
            int n = Command.ExecuteNonQuery(); // C#
            return n > 0 ? true : false;
        }
        public static bool Delete(MDB.MDBConnection MyConnection, BenhAnNoiTruYHCT BenhAnNoiTruYHCT)
        {
            string sql = @"DELETE FROM BenhAnNoiTruYHCT 
                           WHERE MaQuanLy = :MaQuanLy";
            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
            Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", BenhAnNoiTruYHCT.MaQuanLy));

            int n = Command.ExecuteNonQuery(); // C#
            return n > 0 ? true : false;
        }
    }
}
