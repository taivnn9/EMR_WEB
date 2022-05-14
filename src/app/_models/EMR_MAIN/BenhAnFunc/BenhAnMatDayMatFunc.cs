using System.Data;

namespace EMR_MAIN
{
    public class BenhAnMatDayMatFunc
    {
        public static void WriteXml(MDB.MDBConnection MyConnection)
        {
            string sql =
                   @"
                  select  a.*,  CTScanner HoSo_CTScanner, SieuAm HoSo_SieuAm, XetNghiem HoSo_XetNghiem,  Khac HoSo_Khac,  Khac_Text HoSo_Khac_Text,  ToanBoHoSo HoSo_ToanBoHoSo, Mach DauSinhTon_Mach,  NhietDo DauSinhTon_NhietDo,  HuyetAp DauSinhTon_HuyetAp,  NhipTho DauSinhTon_NhipTho,  CanNang DauSinhTon_CanNang  
                  from BenhAnMatDayMat a inner join thongtindieutri b on a.maquanly = b.maquanly
                  where rownum = 1
                    ";
            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
            MDB.MDBDataReader DataReader = Command.ExecuteReader();

            var DataTable = new DataTable { TableName = "BenhAnMatDayMat" };
            DataTable.Load(DataReader as IDataReader);
            DataTable.WriteXml("rptBenhAnMatDayMat.xml");
        }
        public static DataSet SelectDataSet(MDB.MDBConnection MyConnection, decimal MaQuanLy)
        {
            string sql =
                   @"
                  select  a.*,f.hovaten BacSyLamBenhAnHoVaTen ,c.hovaten BacSyDieuTriHoVaTen,d.hovaten NguoiGiaoHoSoHoVaTen,e.hovaten NguoiNhanHoSoHoVaTen, b.XQuang HoSo_XQuang,   b.CTScanner HoSo_CTScanner, b.SieuAm HoSo_SieuAm, b.XetNghiem HoSo_XetNghiem,  b.Khac HoSo_Khac,  b.Khac_Text HoSo_Khac_Text,  b.ToanBoHoSo HoSo_ToanBoHoSo, b.Mach DauSinhTon_Mach, b.NhietDo DauSinhTon_NhietDo,  b.HuyetAp DauSinhTon_HuyetAp,  b.NhipTho DauSinhTon_NhipTho,  b.CanNang DauSinhTon_CanNang  , b.ChieuCao DauSinhTon_ChieuCao, b.BMI DauSinhTon_BMI, b.NgayRaVien 
                 from BenhAnMatDayMat a 
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
        public static BenhAnMatDayMat Select(MDB.MDBConnection MyConnection, decimal MaQuanLy)
        {
            #region
            string sql =
                      @"select * 
                        from BenhAnMatDayMat a
                        where MaQuanLy = :MaQuanLy";
            #endregion
            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
            Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", MaQuanLy));
            MDB.MDBDataReader DataReader = Command.ExecuteReader();
            var value = new BenhAnMatDayMat();
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
                value.ThiLucKhiVaoVien_KhongKinh_MP = DataReader["ThiLucKhiVaoVien_KhongKinh_MP"].ToString();
                value.ThiLucKhiVaoVien_KhongKinh_MT = DataReader["ThiLucKhiVaoVien_KhongKinh_MT"].ToString();
                value.ThiLucKhiVaoVien_CoKinh_MP = DataReader["ThiLucKhiVaoVien_CoKinh_MP"].ToString();
                value.ThiLucKhiVaoVien_CoKinh_MT = DataReader["ThiLucKhiVaoVien_CoKinh_MT"].ToString();
                value.NhanApVaoVien_MT = DataReader["NhanApVaoVien_MT"].ToString();
                value.NhanApVaoVien_MP = DataReader["NhanApVaoVien_MP"].ToString();
                value.ThiTruong_MP = DataReader["ThiTruong_MP"].ToString();
                value.ThiTruong_MT = DataReader["ThiTruong_MT"].ToString();
                value.iMiMat_MP = DataReader.GetInt("MiMat_MP");
                value.PhanUngTheMi_MP = DataReader["PhanUngTheMi_MP"].ToString() == "1" ? true : false;
                value.BenhLyKhac_MP = DataReader["BenhLyKhac_MP"].ToString();
                value.KetMac_MP = DataReader.GetInt("KetMac_MP");
                value.XuatHuyet_MP = DataReader["XuatHuyet_MP"].ToString() == "1" ? true : false;
                value.XuatHuyet_MP_Text = DataReader["XuatHuyet_MP_Text"].ToString();
                value.SeoKetMac_MP = DataReader["SeoKetMac_MP"].ToString() == "1" ? true : false;
                value.SeoKetMac_MP_Text = DataReader["SeoKetMac_MP_Text"].ToString();
                value.BenhLyKhac_KetMac_MP = DataReader["BenhLyKhac_KetMac_MP"].ToString();
                value.GiacMac_Trong_MP = DataReader["GiacMac_Trong_MP"].ToString() == "1" ? true : false;
                value.GiacMac_Phu_MP = DataReader["GiacMac_Phu_MP"].ToString() == "1" ? true : false;
                value.GiacMac_Seo_MP = DataReader["GiacMac_Seo_MP"].ToString() == "1" ? true : false;
                value.iTuaSauGiacMac_MoiCu_MP = DataReader.GetInt("TuaSauGiacMac_MoiCu_MP");
                value.TuaSauGiacMac_MoCuu_MP = DataReader["TuaSauGiacMac_MoCuu_MP"].ToString() == "1" ? true : false;
                value.TuaSauGiacMac_SacTo_MP = DataReader["TuaSauGiacMac_SacTo_MP"].ToString() == "1" ? true : false;
                value.ViTriTua_MP = DataReader["ViTriTua_MP"].ToString();
                value.SeoGiacMac_MP = DataReader["SeoGiacMac_MP"].ToString() == "1" ? true : false;
                value.BenhLyKhac_GiacMac_MP = DataReader["BenhLyKhac_GiacMac_MP"].ToString();
                value.iCungMac_MP = DataReader.GetInt("CungMac_MP");
                value.BenhLyKhac_CungMac_MP = DataReader["BenhLyKhac_CungMac_MP"].ToString();
                value.TienPhong_SauSach_MP = DataReader["TienPhong_SauSach_MP"].ToString() == "1" ? true : false;
                value.TienPhong_XepTienPhong_MP = DataReader["TienPhong_XepTienPhong_MP"].ToString() == "1" ? true : false;
                value.XuatHuyet_TienPhong_MP = DataReader["XuatHuyet_TienPhong_MP"].ToString() == "1" ? true : false;
                value.XuatHuyet_TienPhong_Text_MP = DataReader["XuatHuyet_TienPhong_Text_MP"].ToString();
                value.XuatTuyet_TienPhong_MP = DataReader["XuatTuyet_TienPhong_MP"].ToString() == "1" ? true : false;
                value.XuatTuyet_TienPhong_Text_MP = DataReader["XuatTuyet_TienPhong_Text_MP"].ToString();
                value.Tyndall_TienPhong_MP = DataReader["Tyndall_TienPhong_MP"].ToString() == "1" ? true : false;
                value.Tyndall_TienPhong_Text_MP = DataReader["Tyndall_TienPhong_Text_MP"].ToString();
                value.GocTienPhong_MP = DataReader.GetInt("GocTienPhong_MP");
                value.TonThuongKhac_TienPhong_MP = DataReader["TonThuongKhac_TienPhong_MP"].ToString();
                value.MongMat_MP = DataReader["MongMat_MP"].ToString() == "1" ? true : false;
                value.TanMachMongMat_MP = DataReader["TanMachMongMat_MP"].ToString() == "1" ? true : false;
                value.TanMachMongMat_Text_MP = DataReader["TanMachMongMat_Text_MP"].ToString();
                value.HatKoeppiMongMat_MP = DataReader["HatKoeppiMongMat_MP"].ToString() == "1" ? true : false;
                value.HatKoeppiMongMat_Text_MP = DataReader["HatKoeppiMongMat_Text_MP"].ToString();
                value.HatBussacaMongMat_MP = DataReader["HatBussacaMongMat_MP"].ToString() == "1" ? true : false;
                value.HatBussacaMongMat_Text_MP = DataReader["HatBussacaMongMat_Text_MP"].ToString();
                value.KichThuoc_DongTu_MP = DataReader["KichThuoc_DongTu_MP"].ToString();
                value.AnhDongTu_DongTu_MP = DataReader["AnhDongTu_DongTu_MP"].ToString();
                value.TronMeo_DongTu_MP = DataReader["TronMeo_DongTu_MP"].ToString() == "1" ? true : false;
                value.Dinh_DongTu_MP = DataReader["Dinh_DongTu_MP"].ToString() == "1" ? true : false;
                value.ViTri_DongTu_MP = DataReader["ViTri_DongTu_MP"].ToString();
                value.PXDT_MP = DataReader["PXDT_MP"].ToString() == "1" ? true : false;
                value.GianLiet_DongTu_MP = DataReader["GianLiet_DongTu_MP"].ToString() == "1" ? true : false;
                value.BenhLyKhac_DongTu_MP = DataReader["BenhLyKhac_DongTu_MP"].ToString();
                value.TheThuyTinh_MP = DataReader.GetInt("TheThuyTinh_MP");
                value.DiVat_TheThuyTinh_MP = DataReader["DiVat_TheThuyTinh_MP"].ToString() == "1" ? true : false;
                value.SaLech_TheThuyTinh_MP = DataReader["SaLech_TheThuyTinh_MP"].ToString() == "1" ? true : false;
                value.SaLechID_TheThuyTinh_MP = DataReader["SaLechID_TheThuyTinh_MP"].ToString() == "1" ? true : false;
                value.DinhSacTo_TheThuyTinh_MP = DataReader["DinhSacTo_TheThuyTinh_MP"].ToString() == "1" ? true : false;
                value.ViemMu_TheThuyTinh_MP = DataReader["ViemMu_TheThuyTinh_MP"].ToString() == "1" ? true : false;
                value.TonThuongKhac_TheThuyTinh_MP = DataReader["TonThuongKhac_TheThuyTinh_MP"].ToString();
                value.DichKinh_MP = DataReader["DichKinh_MP"].ToString() == "1" ? true : false;
                value.DichKinh_MP_Text = DataReader["DichKinh_MP_Text"].ToString();
                value.ViemMu_DichKinh_MP = DataReader["ViemMu_DichKinh_MP"].ToString() == "1" ? true : false;
                value.ViemMu_DichKinh_MP_Text = DataReader["ViemMu_DichKinh_MP_Text"].ToString();
                value.XuatHuyet_DichKinh_MP = DataReader["XuatHuyet_DichKinh_MP"].ToString() == "1" ? true : false;
                value.ToChucHoa_DichKinh_MP = DataReader["ToChucHoa_DichKinh_MP"].ToString() == "1" ? true : false;
                value.Bong_DichKinh_MP = DataReader["Bong_DichKinh_MP"].ToString() == "1" ? true : false;
                value.TonThuongKhac_DichKinh_MP = DataReader["TonThuongKhac_DichKinh_MP"].ToString();
                value.HeMach_VongMac_MP = DataReader["HeMach_VongMac_MP"].ToString() == "1" ? true : false;
                value.TacDM_VongMac_MP = DataReader.GetInt("TacDM_VongMac_MP");
                value.TacTM_VongMac_MP = DataReader.GetInt("TacTM_VongMac_MP");
                value.TacTM_Phu_VongMac_MP = DataReader["TacTM_Phu_VongMac_MP"].ToString() == "1" ? true : false;
                value.TacTM_ThieuMau_VongMac_MP = DataReader["TacTM_ThieuMau_VongMac_MP"].ToString() == "1" ? true : false;
                value.TacTM_HonHop_VongMac_MP = DataReader["TacTM_HonHop_VongMac_MP"].ToString() == "1" ? true : false;
                value.ViemMaoMach_VongMac_MP = DataReader["ViemMaoMach_VongMac_MP"].ToString() == "1" ? true : false;
                value.TanMach_VongMac_MP = DataReader["TanMach_VongMac_MP"].ToString() == "1" ? true : false;
                value.TanMachHacMac_MP = Common.ConDB_Int( DataReader["TanMachHacMac_MP"]);
                value.DiaThi_VongMac_MP = DataReader["DiaThi_VongMac_MP"].ToString() == "1" ? true : false;
                value.DiaThiID_VongMac_MP = DataReader.GetInt("DiaThiID_VongMac_MP");
                value.TanMachGai_VongMac_MP = DataReader["TanMachGai_VongMac_MP"].ToString() == "1" ? true : false;
                value.TanMachGaiID_VongMac_MP = DataReader.GetInt("TanMachGaiID_VongMac_MP");
                value.HoangDiem_VongMac_MP = DataReader["HoangDiem_VongMac_MP"].ToString() == "1" ? true : false;
                value.HoangDiem_Phu_VongMac_MP = Common.ConDB_Int(DataReader["HoangDiem_Phu_VongMac_MP"]);
                value.HoangDiem_Lo_VongMac_MP = Common.ConDB_Int(DataReader["HoangDiem_Lo_VongMac_MP"]);
                value.HoangDiem_Lo_Do_VongMac_MP = DataReader["HoangDiem_Lo_Do_VongMac_MP"].ToString();
                value.HoangDiem_Seo_VongMac_MP = DataReader["HoangDiem_Seo_VongMac_MP"].ToString() == "1" ? true : false;
                value.ThoaiHoa_VongMac_MP = Common.ConDB_Int(DataReader["ThoaiHoa_VongMac_MP"]);
                value.ThoaiHoa_VongMac_MP_Text = DataReader["ThoaiHoa_VongMac_MP_Text"].ToString();
                value.XuatHuyet_VongMac_MP = DataReader.GetInt("XuatHuyet_VongMac_MP");
                value.XuatTiet_VongMac_MP = Common.ConDB_Int(DataReader["XuatTiet_VongMac_MP"]);
                value.BongThanhDich_VongMac_MP = Common.ConDB_Int(DataReader["BongThanhDich_VongMac_MP"]);
                value.OViemHacHac_MP = DataReader["OViemHacHac_MP"].ToString() == "1" ? true : false;
                value.OViemHacHac_MPText1 = DataReader["OViemHacHac_MPText1"].ToString() ;
                value.OViemHacHac_MPText2 = DataReader["OViemHacHac_MPText2"].ToString() ;
                value.BongVongMac_MP = DataReader["BongVongMac_MP"].ToString() == "1" ? true : false;
                value.BongVongMac_MP_Text = DataReader["BongVongMac_MP_Text"].ToString();
                value.RachVongMac_MP = DataReader["RachVongMac_MP"].ToString() == "1" ? true : false;
                value.RachVongMac_MP_Text = DataReader["RachVongMac_MP_Text"].ToString();
                value.RachVongMac_MP_Text1 = DataReader["RachVongMac_MP_Text1"].ToString();
                value.RachVongMac_MP_Text2 = DataReader["RachVongMac_MP_Text2"].ToString();
                value.RachVongMac_MP_Text3 = DataReader["RachVongMac_MP_Text3"].ToString();
                value.TonThuongPhoiHop_MP = DataReader["TonThuongPhoiHop_MP"].ToString();
                value.BenhLyKhac_VongMac_MP = DataReader["BenhLyKhac_VongMac_MP"].ToString();
                value.HocMat_MP = DataReader["HocMat_MP"].ToString() == "1" ? true : false;
                value.HocMat_Text_MP = DataReader["HocMat_Text_MP"].ToString();
                value.VanNhan_MP = DataReader["VanNhan_MP"].ToString() == "1" ? true : false;
                value.VanNhan_Text_MP = DataReader["VanNhan_Text_MP"].ToString();
                value.ChuaCoBieuHienBenhLy = DataReader["ChuaCoBieuHienBenhLy"].ToString();
                value.BenhLy = DataReader["BenhLy"].ToString();
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
                value.iMiMat_MT = DataReader.GetInt("MiMat_MT");
                value.PhanUngTheMi_MT = DataReader["PhanUngTheMi_MT"].ToString() == "1" ? true : false;
                value.BenhLyKhac_MT = DataReader["BenhLyKhac_MT"].ToString();
                value.KetMac_MT = DataReader.GetInt("KetMac_MT");
                value.XuatHuyet_MT = DataReader["XuatHuyet_MT"].ToString() == "1" ? true : false;
                value.XuatHuyet_MT_Text = DataReader["XuatHuyet_MT_Text"].ToString();
                value.SeoKetMac_MT = DataReader["SeoKetMac_MT"].ToString() == "1" ? true : false;
                value.SeoKetMac_MT_Text = DataReader["SeoKetMac_MT_Text"].ToString();
                value.BenhLyKhac_KetMac_MT = DataReader["BenhLyKhac_KetMac_MT"].ToString();
                value.GiacMac_Trong_MT = DataReader["GiacMac_Trong_MT"].ToString() == "1" ? true : false;
                value.GiacMac_Phu_MT = DataReader["GiacMac_Phu_MT"].ToString() == "1" ? true : false;
                value.GiacMac_Seo_MT = DataReader["GiacMac_Seo_MT"].ToString() == "1" ? true : false;
                value.iTuaSauGiacMac_MoiCu_MT = DataReader.GetInt("TuaSauGiacMac_MoiCu_MT");
                value.TuaSauGiacMac_MoCuu_MT = DataReader["TuaSauGiacMac_MoCuu_MT"].ToString() == "1" ? true : false;
                value.TuaSauGiacMac_SacTo_MT = DataReader["TuaSauGiacMac_SacTo_MT"].ToString() == "1" ? true : false;
                value.ViTriTua_MT = DataReader["ViTriTua_MT"].ToString();
                value.SeoGiacMac_MT = DataReader["SeoGiacMac_MT"].ToString() == "1" ? true : false;
                value.BenhLyKhac_GiacMac_MT = DataReader["BenhLyKhac_GiacMac_MT"].ToString();
                value.iCungMac_MT = DataReader.GetInt("CungMac_MT");
                value.BenhLyKhac_CungMac_MT = DataReader["BenhLyKhac_CungMac_MT"].ToString();
                value.TienPhong_SauSach_MT = DataReader["TienPhong_SauSach_MT"].ToString() == "1" ? true : false;
                value.TienPhong_XepTienPhong_MT = DataReader["TienPhong_XepTienPhong_MT"].ToString() == "1" ? true : false;
                value.XuatHuyet_TienPhong_MT = DataReader["XuatHuyet_TienPhong_MT"].ToString() == "1" ? true : false;
                value.XuatHuyet_TienPhong_Text_MT = DataReader["XuatHuyet_TienPhong_Text_MT"].ToString();
                value.XuatTuyet_TienPhong_MT = DataReader["XuatTuyet_TienPhong_MT"].ToString() == "1" ? true : false;
                value.XuatTuyet_TienPhong_Text_MT = DataReader["XuatTuyet_TienPhong_Text_MT"].ToString();
                value.Tyndall_TienPhong_MT = DataReader["Tyndall_TienPhong_MT"].ToString() == "1" ? true : false;
                value.Tyndall_TienPhong_Text_MT = DataReader["Tyndall_TienPhong_Text_MT"].ToString();
                value.GocTienPhong_MT = DataReader.GetInt("GocTienPhong_MT");
                value.TonThuongKhac_TienPhong_MT = DataReader["TonThuongKhac_TienPhong_MT"].ToString();
                value.MongMat_MT = DataReader["MongMat_MT"].ToString() == "1" ? true : false;
                value.TanMachMongMat_MT = DataReader["TanMachMongMat_MT"].ToString() == "1" ? true : false;
                value.TanMachMongMat_Text_MT = DataReader["TanMachMongMat_Text_MT"].ToString();
                value.HatKoeppiMongMat_MT = DataReader["HatKoeppiMongMat_MT"].ToString() == "1" ? true : false;
                value.HatKoeppiMongMat_Text_MT = DataReader["HatKoeppiMongMat_Text_MT"].ToString();
                value.HatBussacaMongMat_MT = DataReader["HatBussacaMongMat_MT"].ToString() == "1" ? true : false;
                value.HatBussacaMongMat_Text_MT = DataReader["HatBussacaMongMat_Text_MT"].ToString();
                value.KichThuoc_DongTu_MT = DataReader["KichThuoc_DongTu_MT"].ToString();
                value.AnhDongTu_DongTu_MT = DataReader["AnhDongTu_DongTu_MT"].ToString();
                value.TronMeo_DongTu_MT = DataReader["TronMeo_DongTu_MT"].ToString() == "1" ? true : false;
                value.Dinh_DongTu_MT = DataReader["Dinh_DongTu_MT"].ToString() == "1" ? true : false;
                value.ViTri_DongTu_MT = DataReader["ViTri_DongTu_MT"].ToString();
                value.PXDT_MT = DataReader["PXDT_MT"].ToString() == "1" ? true : false;
                value.GianLiet_DongTu_MT = DataReader["GianLiet_DongTu_MT"].ToString() == "1" ? true : false;
                value.BenhLyKhac_DongTu_MT = DataReader["BenhLyKhac_DongTu_MT"].ToString();
                value.TheThuyTinh_MT = DataReader.GetInt("TheThuyTinh_MT");
                value.DiVat_TheThuyTinh_MT = DataReader["DiVat_TheThuyTinh_MT"].ToString() == "1" ? true : false;
                value.SaLech_TheThuyTinh_MT = DataReader["SaLech_TheThuyTinh_MT"].ToString() == "1" ? true : false;
                value.SaLechID_TheThuyTinh_MT = DataReader["SaLechID_TheThuyTinh_MT"].ToString() == "1" ? true : false;
                value.DinhSacTo_TheThuyTinh_MT = DataReader["DinhSacTo_TheThuyTinh_MT"].ToString() == "1" ? true : false;
                value.ViemMu_TheThuyTinh_MT = DataReader["ViemMu_TheThuyTinh_MT"].ToString() == "1" ? true : false;
                value.TonThuongKhac_TheThuyTinh_MT = DataReader["TonThuongKhac_TheThuyTinh_MT"].ToString();
                value.DichKinh_MT = DataReader["DichKinh_MT"].ToString() == "1" ? true : false;
                value.DichKinh_MT_Text = DataReader["DichKinh_MT_Text"].ToString();
                value.ViemMu_DichKinh_MT = DataReader["ViemMu_DichKinh_MT"].ToString() == "1" ? true : false;
                value.ViemMu_DichKinh_MT_Text = DataReader["ViemMu_DichKinh_MT_Text"].ToString();
                value.XuatHuyet_DichKinh_MT = DataReader["XuatHuyet_DichKinh_MT"].ToString() == "1" ? true : false;
                value.ToChucHoa_DichKinh_MT = DataReader["ToChucHoa_DichKinh_MT"].ToString() == "1" ? true : false;
                value.Bong_DichKinh_MT = DataReader["Bong_DichKinh_MT"].ToString() == "1" ? true : false;
                value.TonThuongKhac_DichKinh_MT = DataReader["TonThuongKhac_DichKinh_MT"].ToString();
                value.HeMach_VongMac_MT = DataReader["HeMach_VongMac_MT"].ToString() == "1" ? true : false;
                value.TacDM_VongMac_MT = DataReader.GetInt("TacDM_VongMac_MT");
                value.TacTM_VongMac_MT = DataReader.GetInt("TacTM_VongMac_MT");
                value.TacTM_Phu_VongMac_MT = DataReader["TacTM_Phu_VongMac_MT"].ToString() == "1" ? true : false;
                value.TacTM_ThieuMau_VongMac_MT = DataReader["TacTM_ThieuMau_VongMac_MT"].ToString() == "1" ? true : false;
                value.TacTM_HonHop_VongMac_MT = DataReader["TacTM_HonHop_VongMac_MT"].ToString() == "1" ? true : false;
                value.ViemMaoMach_VongMac_MT = DataReader["ViemMaoMach_VongMac_MT"].ToString() == "1" ? true : false;
                value.TanMach_VongMac_MT = DataReader["TanMach_VongMac_MT"].ToString() == "1" ? true : false;
                value.TanMachHacMac_MT = Common.ConDB_Int(DataReader["TanMachHacMac_MT"]);
                value.DiaThi_VongMac_MT = DataReader["DiaThi_VongMac_MT"].ToString() == "1" ? true : false;
                value.DiaThiID_VongMac_MT = DataReader.GetInt("DiaThiID_VongMac_MT");
                value.TanMachGai_VongMac_MT = DataReader["TanMachGai_VongMac_MT"].ToString() == "1" ? true : false;
                value.TanMachGaiID_VongMac_MT = DataReader.GetInt("TanMachGaiID_VongMac_MT");
                value.HoangDiem_VongMac_MT = DataReader["HoangDiem_VongMac_MT"].ToString() == "1" ? true : false;
                value.HoangDiem_Phu_VongMac_MT = Common.ConDB_Int(DataReader["HoangDiem_Phu_VongMac_MT"]);
                value.HoangDiem_Lo_VongMac_MT = Common.ConDB_Int(DataReader["HoangDiem_Lo_VongMac_MT"]);
                value.HoangDiem_Lo_Do_VongMac_MT = DataReader["HoangDiem_Lo_Do_VongMac_MT"].ToString();
                value.HoangDiem_Seo_VongMac_MT = DataReader["HoangDiem_Seo_VongMac_MT"].ToString() == "1" ? true : false;
                value.ThoaiHoa_VongMac_MT = Common.ConDB_Int(DataReader["ThoaiHoa_VongMac_MT"]);
                value.ThoaiHoa_VongMac_MT_Text = DataReader["ThoaiHoa_VongMac_MT_Text"].ToString();
                value.XuatHuyet_VongMac_MT = DataReader.GetInt("XuatHuyet_VongMac_MT");
                value.XuatTiet_VongMac_MT = Common.ConDB_Int(DataReader["XuatTiet_VongMac_MT"]);
                value.BongThanhDich_VongMac_MT = Common.ConDB_Int(DataReader["BongThanhDich_VongMac_MT"]);
                value.OViemHacHac_MT = DataReader["OViemHacHac_MT"].ToString() == "1" ? true : false;
                value.OViemHacHac_MTText1 = DataReader["OViemHacHac_MTText1"].ToString() == "1" ? true : false;
                value.OViemHacHac_MTText2 = DataReader["OViemHacHac_MTText2"].ToString() == "1" ? true : false;
                value.BongVongMac_MT = DataReader["BongVongMac_MT"].ToString() == "1" ? true : false;
                value.BongVongMac_MT_Text = DataReader["BongVongMac_MT_Text"].ToString();
                value.RachVongMac_MT = DataReader["RachVongMac_MT"].ToString() == "1" ? true : false;
                value.RachVongMac_MT_Text = DataReader["RachVongMac_MT_Text"].ToString();
                value.RachVongMac_MT_Text1 = DataReader["RachVongMac_MT_Text1"].ToString();
                value.RachVongMac_MT_Text2 = DataReader["RachVongMac_MT_Text2"].ToString();
                value.RachVongMac_MT_Text3 = DataReader["RachVongMac_MT_Text3"].ToString();
                value.TonThuongPhoiHop_MT = DataReader["TonThuongPhoiHop_MT"].ToString();
                value.BenhLyKhac_VongMac_MT = DataReader["BenhLyKhac_VongMac_MT"].ToString();
                value.HocMat_MT = DataReader["HocMat_MT"].ToString() == "1" ? true : false;
                value.HocMat_Text_MT = DataReader["HocMat_Text_MT"].ToString();
                value.VanNhan_MT = DataReader["VanNhan_MT"].ToString() == "1" ? true : false;
                value.VanNhan_Text_MT = DataReader["VanNhan_Text_MT"].ToString();
                value.MaSoKyTen = DataReader["masokyten"].ToString();
                value.MaSoKyTen_KB = DataReader["masokyten_kb"].ToString();
                value.MaSoKyTen_TK = DataReader["masokyten_tk"].ToString();
                value.ThayBenhLy = DataReader["ThayBenhLy"].ToString() == "1" ? true : false;
                value.ChuaThayBenhLy = DataReader["ChuaThayBenhLy"].ToString() == "1" ? true : false;
                value.ThayBenhLy = DataReader["ThayBenhLy"].ToString() == "1" ? true : false;
                value.VongMac_BenhLy_MP = DataReader.GetInt("VongMac_BenhLy_MP");
                value.VongMac_BenhLy_MP_Text = DataReader["VongMac_BenhLy_MP_Text"].ToString();
                value.VongMac_BenhLy_MT = DataReader.GetInt("VongMac_BenhLy_MT");
                value.VongMac_BenhLy_MT_Text = DataReader["VongMac_BenhLy_MT_Text"].ToString();
            }
            return value;
        }

        public static bool InsertOrUpdate(MDB.MDBConnection MyConnection, BenhAnMatDayMat BenhAnMatDayMat)
        {
            string sql =
                      @"select MaQuanLy 
                        from BenhAnMatDayMat
                        where MaQuanLy = :MaQuanLy";
            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
            Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", BenhAnMatDayMat.MaQuanLy));
            MDB.MDBDataReader DataReader = Command.ExecuteReader();
            int rowCount = 0;
            while (DataReader.Read()) rowCount++;
            if (rowCount == 1) return Update(MyConnection, BenhAnMatDayMat);
            sql = @"
                   INSERT INTO BenhAnMatDayMat (MaQuanLy, LyDoVaoVien, VaoNgayThu, QuaTrinhBenhLy, TienSuBenhBanThan, TienSuBenhGiaDinh, ToanThan, TuanHoan, HoHap, TieuHoa, ThanTietNieuSinhDuc, ThanKinh, CoXuongKhop, TaiMuiHong, RangHamMat, Mat, Khac_CacCoQuan, CacXetNghiemCanLamSangCanLam, TomTatBenhAn, BenhChinh, BenhKemTheo, PhanBiet, TienLuong, HuongDieuTri, NgayKhamBenh, BacSyLamBenhAn, QuaTrinhBenhLyVaDienBien, TomTatKetQuaXetNghiem, PhuongPhapDieuTri, TinhTrangNguoiBenhRaVien, HuongDieuTriVaCacCheDoTiepTheo, NguoiNhanHoSo, NguoiGiaoHoSo, NgayTongKet, BacSyDieuTri, DiUng, DiUng_Text, MaTuy, MaTuy_Text, RuouBia, RuouBia_Text, ThuocLa, ThuocLa_Text, ThuocLao, ThuocLao_Text, Khac_DacDiemLienQuanBenh, Khac_DacDiemLienQuanBenh_Text, ThiLucKhiVaoVien_KhongKinh_MP, ThiLucKhiVaoVien_KhongKinh_MT, ThiLucKhiVaoVien_CoKinh_MP, ThiLucKhiVaoVien_CoKinh_MT, NhanApVaoVien_MT, NhanApVaoVien_MP, ThiTruong_MP, ThiTruong_MT, MiMat_MP, PhanUngTheMi_MP, BenhLyKhac_MP, KetMac_MP, XuatHuyet_MP, XuatHuyet_MP_Text, SeoKetMac_MP, SeoKetMac_MP_Text, BenhLyKhac_KetMac_MP, GiacMac_Trong_MP, GiacMac_Phu_MP, GiacMac_Seo_MP, TuaSauGiacMac_MoiCu_MP, TuaSauGiacMac_MoCuu_MP, TuaSauGiacMac_SacTo_MP, ViTriTua_MP, SeoGiacMac_MP, BenhLyKhac_GiacMac_MP, CungMac_MP, BenhLyKhac_CungMac_MP, TienPhong_SauSach_MP, TienPhong_XepTienPhong_MP, XuatHuyet_TienPhong_MP, XuatHuyet_TienPhong_Text_MP, XuatTuyet_TienPhong_MP, XuatTuyet_TienPhong_Text_MP, Tyndall_TienPhong_MP, Tyndall_TienPhong_Text_MP, GocTienPhong_MP, TonThuongKhac_TienPhong_MP, MongMat_MP, TanMachMongMat_MP, TanMachMongMat_Text_MP, HatKoeppiMongMat_MP, HatKoeppiMongMat_Text_MP, HatBussacaMongMat_MP, HatBussacaMongMat_Text_MP, KichThuoc_DongTu_MP, AnhDongTu_DongTu_MP, TronMeo_DongTu_MP, Dinh_DongTu_MP, ViTri_DongTu_MP, PXDT_MP, GianLiet_DongTu_MP, BenhLyKhac_DongTu_MP, TheThuyTinh_MP, DiVat_TheThuyTinh_MP, SaLech_TheThuyTinh_MP, SaLechID_TheThuyTinh_MP, DinhSacTo_TheThuyTinh_MP, ViemMu_TheThuyTinh_MP, TonThuongKhac_TheThuyTinh_MP, DichKinh_MP, DichKinh_MP_Text, ViemMu_DichKinh_MP, ViemMu_DichKinh_MP_Text, XuatHuyet_DichKinh_MP, ToChucHoa_DichKinh_MP, Bong_DichKinh_MP, TonThuongKhac_DichKinh_MP, HeMach_VongMac_MP, TacDM_VongMac_MP, TacTM_VongMac_MP, TacTM_Phu_VongMac_MP, TacTM_ThieuMau_VongMac_MP, TacTM_HonHop_VongMac_MP, ViemMaoMach_VongMac_MP, TanMach_VongMac_MP, TanMachHacMac_MP, DiaThi_VongMac_MP, DiaThiID_VongMac_MP, TanMachGai_VongMac_MP, TanMachGaiID_VongMac_MP, HoangDiem_VongMac_MP, HoangDiem_Phu_VongMac_MP, HoangDiem_Lo_VongMac_MP, HoangDiem_Lo_Do_VongMac_MP, HoangDiem_Seo_VongMac_MP, ThoaiHoa_VongMac_MP, ThoaiHoa_VongMac_MP_Text, XuatHuyet_VongMac_MP, XuatTiet_VongMac_MP, BongThanhDich_VongMac_MP, OViemHacHac_MP, OViemHacHac_MPText1, OViemHacHac_MPText2, BongVongMac_MP, BongVongMac_MP_Text, RachVongMac_MP, RachVongMac_MP_Text, RachVongMac_MP_Text1, RachVongMac_MP_Text2, RachVongMac_MP_Text3, TonThuongPhoiHop_MP, BenhLyKhac_VongMac_MP, HocMat_MP, HocMat_Text_MP, VanNhan_MP, VanNhan_Text_MP, ChuaCoBieuHienBenhLy, BenhLy, ChanDoanBenhChinh_LamSang, ChanDoanBenhChinh_NguyenNhan, QuaTrinhDieuTri_NoiKhoa, PhauThuat, ThuThuat, ThiLucRaVienKhongKinhMPTongKet, ThiLucRaVienKhongKinhMTTongKet, ThiLucRaVienCoKinhMPTongKet, ThiLucRaVienCoKinhMTTongKet, NhanApRaVienMPTongKet, NhanApRaVienMTTongKet, HuongDieuTriTiep, MiMat_MT, PhanUngTheMi_MT, BenhLyKhac_MT, KetMac_MT, XuatHuyet_MT, XuatHuyet_MT_Text, SeoKetMac_MT, SeoKetMac_MT_Text, BenhLyKhac_KetMac_MT, GiacMac_Trong_MT, GiacMac_Phu_MT, GiacMac_Seo_MT, TuaSauGiacMac_MoiCu_MT, TuaSauGiacMac_MoCuu_MT, TuaSauGiacMac_SacTo_MT, ViTriTua_MT, SeoGiacMac_MT, BenhLyKhac_GiacMac_MT, CungMac_MT, BenhLyKhac_CungMac_MT, TienPhong_SauSach_MT, TienPhong_XepTienPhong_MT, XuatHuyet_TienPhong_MT, XuatHuyet_TienPhong_Text_MT, XuatTuyet_TienPhong_MT, XuatTuyet_TienPhong_Text_MT, Tyndall_TienPhong_MT, Tyndall_TienPhong_Text_MT, GocTienPhong_MT, TonThuongKhac_TienPhong_MT, MongMat_MT, TanMachMongMat_MT, TanMachMongMat_Text_MT, HatKoeppiMongMat_MT, HatKoeppiMongMat_Text_MT, HatBussacaMongMat_MT, HatBussacaMongMat_Text_MT, KichThuoc_DongTu_MT, AnhDongTu_DongTu_MT, TronMeo_DongTu_MT, Dinh_DongTu_MT, ViTri_DongTu_MT, PXDT_MT, GianLiet_DongTu_MT, BenhLyKhac_DongTu_MT, TheThuyTinh_MT, DiVat_TheThuyTinh_MT, SaLech_TheThuyTinh_MT, SaLechID_TheThuyTinh_MT, DinhSacTo_TheThuyTinh_MT, ViemMu_TheThuyTinh_MT, TonThuongKhac_TheThuyTinh_MT, DichKinh_MT, DichKinh_MT_Text, ViemMu_DichKinh_MT, ViemMu_DichKinh_MT_Text, XuatHuyet_DichKinh_MT, ToChucHoa_DichKinh_MT, Bong_DichKinh_MT, TonThuongKhac_DichKinh_MT, HeMach_VongMac_MT, TacDM_VongMac_MT, TacTM_VongMac_MT, TacTM_Phu_VongMac_MT, TacTM_ThieuMau_VongMac_MT, TacTM_HonHop_VongMac_MT, ViemMaoMach_VongMac_MT, TanMach_VongMac_MT, TanMachHacMac_MT, DiaThi_VongMac_MT, DiaThiID_VongMac_MT, TanMachGai_VongMac_MT, TanMachGaiID_VongMac_MT, HoangDiem_VongMac_MT, HoangDiem_Phu_VongMac_MT, HoangDiem_Lo_VongMac_MT, HoangDiem_Lo_Do_VongMac_MT, HoangDiem_Seo_VongMac_MT, ThoaiHoa_VongMac_MT, ThoaiHoa_VongMac_MT_Text, XuatHuyet_VongMac_MT, XuatTiet_VongMac_MT, BongThanhDich_VongMac_MT, OViemHacHac_MT, OViemHacHac_MTText1, OViemHacHac_MTText2, BongVongMac_MT, BongVongMac_MT_Text, RachVongMac_MT, RachVongMac_MT_Text, RachVongMac_MT_Text1, RachVongMac_MT_Text2, RachVongMac_MT_Text3, TonThuongPhoiHop_MT, BenhLyKhac_VongMac_MT, HocMat_MT, HocMat_Text_MT, VanNhan_MT, VanNhan_Text_MT, ThayBenhLy, ChuaThayBenhLy, VongMac_BenhLy_MP, VongMac_BenhLy_MP_Text, VongMac_BenhLy_MT, VongMac_BenhLy_MT_Text)
                   VALUES(:MaQuanLy, :LyDoVaoVien, :VaoNgayThu, :QuaTrinhBenhLy, :TienSuBenhBanThan, :TienSuBenhGiaDinh, :ToanThan, :TuanHoan, :HoHap, :TieuHoa, :ThanTietNieuSinhDuc, :ThanKinh, :CoXuongKhop, :TaiMuiHong, :RangHamMat, :Mat, :Khac_CacCoQuan, :CacXetNghiemCanLamSangCanLam, :TomTatBenhAn, :BenhChinh, :BenhKemTheo, :PhanBiet, :TienLuong, :HuongDieuTri, :NgayKhamBenh, :BacSyLamBenhAn, :QuaTrinhBenhLyVaDienBien, :TomTatKetQuaXetNghiem, :PhuongPhapDieuTri, :TinhTrangNguoiBenhRaVien, :HuongDieuTriVaCacCheDoTiepTheo, :NguoiNhanHoSo, :NguoiGiaoHoSo, :NgayTongKet, :BacSyDieuTri, :DiUng, :DiUng_Text, :MaTuy, :MaTuy_Text, :RuouBia, :RuouBia_Text, :ThuocLa, :ThuocLa_Text, :ThuocLao, :ThuocLao_Text, :Khac_DacDiemLienQuanBenh, :Khac_DacDiemLienQuanBenh_Text, :ThiLucKhiVaoVien_KhongKinh_MP, :ThiLucKhiVaoVien_KhongKinh_MT, :ThiLucKhiVaoVien_CoKinh_MP, :ThiLucKhiVaoVien_CoKinh_MT, :NhanApVaoVien_MT, :NhanApVaoVien_MP, :ThiTruong_MP, :ThiTruong_MT, :MiMat_MP, :PhanUngTheMi_MP, :BenhLyKhac_MP, :KetMac_MP, :XuatHuyet_MP, :XuatHuyet_MP_Text, :SeoKetMac_MP, :SeoKetMac_MP_Text, :BenhLyKhac_KetMac_MP, :GiacMac_Trong_MP, :GiacMac_Phu_MP, :GiacMac_Seo_MP, :TuaSauGiacMac_MoiCu_MP, :TuaSauGiacMac_MoCuu_MP, :TuaSauGiacMac_SacTo_MP, :ViTriTua_MP, :SeoGiacMac_MP, :BenhLyKhac_GiacMac_MP, :CungMac_MP, :BenhLyKhac_CungMac_MP, :TienPhong_SauSach_MP, :TienPhong_XepTienPhong_MP, :XuatHuyet_TienPhong_MP, :XuatHuyet_TienPhong_Text_MP, :XuatTuyet_TienPhong_MP, :XuatTuyet_TienPhong_Text_MP, :Tyndall_TienPhong_MP, :Tyndall_TienPhong_Text_MP, :GocTienPhong_MP, :TonThuongKhac_TienPhong_MP, :MongMat_MP, :TanMachMongMat_MP, :TanMachMongMat_Text_MP, :HatKoeppiMongMat_MP, :HatKoeppiMongMat_Text_MP, :HatBussacaMongMat_MP, :HatBussacaMongMat_Text_MP, :KichThuoc_DongTu_MP, :AnhDongTu_DongTu_MP, :TronMeo_DongTu_MP, :Dinh_DongTu_MP, :ViTri_DongTu_MP, :PXDT_MP, :GianLiet_DongTu_MP, :BenhLyKhac_DongTu_MP, :TheThuyTinh_MP, :DiVat_TheThuyTinh_MP, :SaLech_TheThuyTinh_MP, :SaLechID_TheThuyTinh_MP, :DinhSacTo_TheThuyTinh_MP, :ViemMu_TheThuyTinh_MP, :TonThuongKhac_TheThuyTinh_MP, :DichKinh_MP, :DichKinh_MP_Text, :ViemMu_DichKinh_MP, :ViemMu_DichKinh_MP_Text, :XuatHuyet_DichKinh_MP, :ToChucHoa_DichKinh_MP, :Bong_DichKinh_MP, :TonThuongKhac_DichKinh_MP, :HeMach_VongMac_MP, :TacDM_VongMac_MP, :TacTM_VongMac_MP, :TacTM_Phu_VongMac_MP, :TacTM_ThieuMau_VongMac_MP, :TacTM_HonHop_VongMac_MP, :ViemMaoMach_VongMac_MP, :TanMach_VongMac_MP, :TanMachHacMac_MP, :DiaThi_VongMac_MP, :DiaThiID_VongMac_MP, :TanMachGai_VongMac_MP, :TanMachGaiID_VongMac_MP, :HoangDiem_VongMac_MP, :HoangDiem_Phu_VongMac_MP, :HoangDiem_Lo_VongMac_MP, :HoangDiem_Lo_Do_VongMac_MP, :HoangDiem_Seo_VongMac_MP, :ThoaiHoa_VongMac_MP, :ThoaiHoa_VongMac_MP_Text, :XuatHuyet_VongMac_MP, :XuatTiet_VongMac_MP, :BongThanhDich_VongMac_MP, :OViemHacHac_MP, :OViemHacHac_MPText1, :OViemHacHac_MPText2, :BongVongMac_MP, :BongVongMac_MP_Text, :RachVongMac_MP, :RachVongMac_MP_Text, :RachVongMac_MP_Text1, :RachVongMac_MP_Text2, :RachVongMac_MP_Text3, :TonThuongPhoiHop_MP, :BenhLyKhac_VongMac_MP, :HocMat_MP, :HocMat_Text_MP, :VanNhan_MP, :VanNhan_Text_MP, :ChuaCoBieuHienBenhLy, :BenhLy, :ChanDoanBenhChinh_LamSang, :ChanDoanBenhChinh_NguyenNhan, :QuaTrinhDieuTri_NoiKhoa, :PhauThuat, :ThuThuat, :ThiLucRaVienKhongKinhMPTongKet, :ThiLucRaVienKhongKinhMTTongKet, :ThiLucRaVienCoKinhMPTongKet, :ThiLucRaVienCoKinhMTTongKet, :NhanApRaVienMPTongKet, :NhanApRaVienMTTongKet, :HuongDieuTriTiep, :MiMat_MT, :PhanUngTheMi_MT, :BenhLyKhac_MT, :KetMac_MT, :XuatHuyet_MT, :XuatHuyet_MT_Text, :SeoKetMac_MT, :SeoKetMac_MT_Text, :BenhLyKhac_KetMac_MT, :GiacMac_Trong_MT, :GiacMac_Phu_MT, :GiacMac_Seo_MT, :TuaSauGiacMac_MoiCu_MT, :TuaSauGiacMac_MoCuu_MT, :TuaSauGiacMac_SacTo_MT, :ViTriTua_MT, :SeoGiacMac_MT, :BenhLyKhac_GiacMac_MT, :CungMac_MT, :BenhLyKhac_CungMac_MT, :TienPhong_SauSach_MT, :TienPhong_XepTienPhong_MT, :XuatHuyet_TienPhong_MT, :XuatHuyet_TienPhong_Text_MT, :XuatTuyet_TienPhong_MT, :XuatTuyet_TienPhong_Text_MT, :Tyndall_TienPhong_MT, :Tyndall_TienPhong_Text_MT, :GocTienPhong_MT, :TonThuongKhac_TienPhong_MT, :MongMat_MT, :TanMachMongMat_MT, :TanMachMongMat_Text_MT, :HatKoeppiMongMat_MT, :HatKoeppiMongMat_Text_MT, :HatBussacaMongMat_MT, :HatBussacaMongMat_Text_MT, :KichThuoc_DongTu_MT, :AnhDongTu_DongTu_MT, :TronMeo_DongTu_MT, :Dinh_DongTu_MT, :ViTri_DongTu_MT, :PXDT_MT, :GianLiet_DongTu_MT, :BenhLyKhac_DongTu_MT, :TheThuyTinh_MT, :DiVat_TheThuyTinh_MT, :SaLech_TheThuyTinh_MT, :SaLechID_TheThuyTinh_MT, :DinhSacTo_TheThuyTinh_MT, :ViemMu_TheThuyTinh_MT, :TonThuongKhac_TheThuyTinh_MT, :DichKinh_MT, :DichKinh_MT_Text, :ViemMu_DichKinh_MT, :ViemMu_DichKinh_MT_Text, :XuatHuyet_DichKinh_MT, :ToChucHoa_DichKinh_MT, :Bong_DichKinh_MT, :TonThuongKhac_DichKinh_MT, :HeMach_VongMac_MT, :TacDM_VongMac_MT, :TacTM_VongMac_MT, :TacTM_Phu_VongMac_MT, :TacTM_ThieuMau_VongMac_MT, :TacTM_HonHop_VongMac_MT, :ViemMaoMach_VongMac_MT, :TanMach_VongMac_MT, :TanMachHacMac_MT, :DiaThi_VongMac_MT, :DiaThiID_VongMac_MT, :TanMachGai_VongMac_MT, :TanMachGaiID_VongMac_MT, :HoangDiem_VongMac_MT, :HoangDiem_Phu_VongMac_MT, :HoangDiem_Lo_VongMac_MT, :HoangDiem_Lo_Do_VongMac_MT, :HoangDiem_Seo_VongMac_MT, :ThoaiHoa_VongMac_MT, :ThoaiHoa_VongMac_MT_Text, :XuatHuyet_VongMac_MT, :XuatTiet_VongMac_MT, :BongThanhDich_VongMac_MT, :OViemHacHac_MT, :OViemHacHac_MTText1, :OViemHacHac_MTText2, :BongVongMac_MT, :BongVongMac_MT_Text, :RachVongMac_MT, :RachVongMac_MT_Text, :RachVongMac_MT_Text1, :RachVongMac_MT_Text2, :RachVongMac_MT_Text3, :TonThuongPhoiHop_MT, :BenhLyKhac_VongMac_MT, :HocMat_MT, :HocMat_Text_MT, :VanNhan_MT, :VanNhan_Text_MT,  :ThayBenhLy, :ChuaThayBenhLy, :VongMac_BenhLy_MP, :VongMac_BenhLy_MP_Text, :VongMac_BenhLy_MT, :VongMac_BenhLy_MT_Text)
                   ";
            Command = new MDB.MDBCommand(sql, MyConnection);
            Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", BenhAnMatDayMat.MaQuanLy));
            Command.Parameters.Add(new MDB.MDBParameter("LyDoVaoVien", BenhAnMatDayMat.LyDoVaoVien));
            Command.Parameters.Add(new MDB.MDBParameter("VaoNgayThu", BenhAnMatDayMat.VaoNgayThu));
            Command.Parameters.Add(new MDB.MDBParameter("QuaTrinhBenhLy", BenhAnMatDayMat.QuaTrinhBenhLy));
            Command.Parameters.Add(new MDB.MDBParameter("TienSuBenhBanThan", BenhAnMatDayMat.TienSuBenhBanThan));
            Command.Parameters.Add(new MDB.MDBParameter("TienSuBenhGiaDinh", BenhAnMatDayMat.TienSuBenhGiaDinh));
            Command.Parameters.Add(new MDB.MDBParameter("ToanThan", BenhAnMatDayMat.ToanThan));
            Command.Parameters.Add(new MDB.MDBParameter("TuanHoan", BenhAnMatDayMat.TuanHoan));
            Command.Parameters.Add(new MDB.MDBParameter("HoHap", BenhAnMatDayMat.HoHap));
            Command.Parameters.Add(new MDB.MDBParameter("TieuHoa", BenhAnMatDayMat.TieuHoa));
            Command.Parameters.Add(new MDB.MDBParameter("ThanTietNieuSinhDuc", BenhAnMatDayMat.ThanTietNieuSinhDuc));
            Command.Parameters.Add(new MDB.MDBParameter("ThanKinh", BenhAnMatDayMat.ThanKinh));
            Command.Parameters.Add(new MDB.MDBParameter("CoXuongKhop", BenhAnMatDayMat.CoXuongKhop));
            Command.Parameters.Add(new MDB.MDBParameter("TaiMuiHong", BenhAnMatDayMat.TaiMuiHong));
            Command.Parameters.Add(new MDB.MDBParameter("RangHamMat", BenhAnMatDayMat.RangHamMat));
            Command.Parameters.Add(new MDB.MDBParameter("Mat", BenhAnMatDayMat.Mat));
            Command.Parameters.Add(new MDB.MDBParameter("Khac_CacCoQuan", BenhAnMatDayMat.Khac_CacCoQuan));
            Command.Parameters.Add(new MDB.MDBParameter("CacXetNghiemCanLamSangCanLam", BenhAnMatDayMat.CacXetNghiemCanLamSangCanLam));
            Command.Parameters.Add(new MDB.MDBParameter("TomTatBenhAn", BenhAnMatDayMat.TomTatBenhAn));
            Command.Parameters.Add(new MDB.MDBParameter("BenhChinh", BenhAnMatDayMat.BenhChinh));
            Command.Parameters.Add(new MDB.MDBParameter("BenhKemTheo", BenhAnMatDayMat.BenhKemTheo));
            Command.Parameters.Add(new MDB.MDBParameter("PhanBiet", BenhAnMatDayMat.PhanBiet));
            Command.Parameters.Add(new MDB.MDBParameter("TienLuong", BenhAnMatDayMat.TienLuong));
            Command.Parameters.Add(new MDB.MDBParameter("HuongDieuTri", BenhAnMatDayMat.HuongDieuTri));
            Command.Parameters.Add(new MDB.MDBParameter("NgayKhamBenh", BenhAnMatDayMat.NgayKhamBenh));
            Command.Parameters.Add(new MDB.MDBParameter("BacSyLamBenhAn", BenhAnMatDayMat.BacSyLamBenhAn));
            Command.Parameters.Add(new MDB.MDBParameter("QuaTrinhBenhLyVaDienBien", BenhAnMatDayMat.QuaTrinhBenhLyVaDienBien));
            Command.Parameters.Add(new MDB.MDBParameter("TomTatKetQuaXetNghiem", BenhAnMatDayMat.TomTatKetQuaXetNghiem));
            Command.Parameters.Add(new MDB.MDBParameter("PhuongPhapDieuTri", BenhAnMatDayMat.PhuongPhapDieuTri));
            Command.Parameters.Add(new MDB.MDBParameter("TinhTrangNguoiBenhRaVien", BenhAnMatDayMat.TinhTrangNguoiBenhRaVien));
            Command.Parameters.Add(new MDB.MDBParameter("HuongDieuTriVaCacCheDoTiepTheo", BenhAnMatDayMat.HuongDieuTriVaCacCheDoTiepTheo));
            Command.Parameters.Add(new MDB.MDBParameter("NguoiNhanHoSo", BenhAnMatDayMat.NguoiNhanHoSo));
            Command.Parameters.Add(new MDB.MDBParameter("NguoiGiaoHoSo", BenhAnMatDayMat.NguoiGiaoHoSo));
            Command.Parameters.Add(new MDB.MDBParameter("NgayTongKet", BenhAnMatDayMat.NgayTongKet));
            Command.Parameters.Add(new MDB.MDBParameter("BacSyDieuTri", BenhAnMatDayMat.BacSyDieuTri));
            Command.Parameters.Add(new MDB.MDBParameter("DiUng", BenhAnMatDayMat.DacDiemLienQuanBenh.DiUng == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("DiUng_Text", BenhAnMatDayMat.DacDiemLienQuanBenh.DiUng_Text));
            Command.Parameters.Add(new MDB.MDBParameter("MaTuy", BenhAnMatDayMat.DacDiemLienQuanBenh.MaTuy == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("MaTuy_Text", BenhAnMatDayMat.DacDiemLienQuanBenh.MaTuy_Text));
            Command.Parameters.Add(new MDB.MDBParameter("RuouBia", BenhAnMatDayMat.DacDiemLienQuanBenh.RuouBia == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("RuouBia_Text", BenhAnMatDayMat.DacDiemLienQuanBenh.RuouBia_Text));
            Command.Parameters.Add(new MDB.MDBParameter("ThuocLa", BenhAnMatDayMat.DacDiemLienQuanBenh.ThuocLa == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("ThuocLa_Text", BenhAnMatDayMat.DacDiemLienQuanBenh.ThuocLa_Text));
            Command.Parameters.Add(new MDB.MDBParameter("ThuocLao", BenhAnMatDayMat.DacDiemLienQuanBenh.ThuocLao == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("ThuocLao_Text", BenhAnMatDayMat.DacDiemLienQuanBenh.ThuocLao_Text));
            Command.Parameters.Add(new MDB.MDBParameter("Khac_DacDiemLienQuanBenh", BenhAnMatDayMat.DacDiemLienQuanBenh.Khac_DacDiemLienQuanBenh == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("Khac_DacDiemLienQuanBenh_Text", BenhAnMatDayMat.DacDiemLienQuanBenh.Khac_DacDiemLienQuanBenh_Text));
            Command.Parameters.Add(new MDB.MDBParameter("ThiLucKhiVaoVien_KhongKinh_MP", BenhAnMatDayMat.ThiLucKhiVaoVien_KhongKinh_MP));
            Command.Parameters.Add(new MDB.MDBParameter("ThiLucKhiVaoVien_KhongKinh_MT", BenhAnMatDayMat.ThiLucKhiVaoVien_KhongKinh_MT));
            Command.Parameters.Add(new MDB.MDBParameter("ThiLucKhiVaoVien_CoKinh_MP", BenhAnMatDayMat.ThiLucKhiVaoVien_CoKinh_MP));
            Command.Parameters.Add(new MDB.MDBParameter("ThiLucKhiVaoVien_CoKinh_MT", BenhAnMatDayMat.ThiLucKhiVaoVien_CoKinh_MT));
            Command.Parameters.Add(new MDB.MDBParameter("NhanApVaoVien_MT", BenhAnMatDayMat.NhanApVaoVien_MT));
            Command.Parameters.Add(new MDB.MDBParameter("NhanApVaoVien_MP", BenhAnMatDayMat.NhanApVaoVien_MP));
            Command.Parameters.Add(new MDB.MDBParameter("ThiTruong_MP", BenhAnMatDayMat.ThiTruong_MP));
            Command.Parameters.Add(new MDB.MDBParameter("ThiTruong_MT", BenhAnMatDayMat.ThiTruong_MT));
            Command.Parameters.Add(new MDB.MDBParameter("MiMat_MP", BenhAnMatDayMat.iMiMat_MP));
            Command.Parameters.Add(new MDB.MDBParameter("PhanUngTheMi_MP", BenhAnMatDayMat.PhanUngTheMi_MP == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("BenhLyKhac_MP", BenhAnMatDayMat.BenhLyKhac_MP));
            Command.Parameters.Add(new MDB.MDBParameter("KetMac_MP", BenhAnMatDayMat.KetMac_MP));
            Command.Parameters.Add(new MDB.MDBParameter("XuatHuyet_MP", BenhAnMatDayMat.XuatHuyet_MP == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("XuatHuyet_MP_Text", BenhAnMatDayMat.XuatHuyet_MP_Text));
            Command.Parameters.Add(new MDB.MDBParameter("SeoKetMac_MP", BenhAnMatDayMat.SeoKetMac_MP == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("SeoKetMac_MP_Text", BenhAnMatDayMat.SeoKetMac_MP_Text));
            Command.Parameters.Add(new MDB.MDBParameter("BenhLyKhac_KetMac_MP", BenhAnMatDayMat.BenhLyKhac_KetMac_MP));
            Command.Parameters.Add(new MDB.MDBParameter("GiacMac_Trong_MP", BenhAnMatDayMat.GiacMac_Trong_MP == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("GiacMac_Phu_MP", BenhAnMatDayMat.GiacMac_Phu_MP == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("GiacMac_Seo_MP", BenhAnMatDayMat.GiacMac_Seo_MP == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("TuaSauGiacMac_MoiCu_MP", BenhAnMatDayMat.iTuaSauGiacMac_MoiCu_MP));
            Command.Parameters.Add(new MDB.MDBParameter("TuaSauGiacMac_MoCuu_MP", BenhAnMatDayMat.TuaSauGiacMac_MoCuu_MP == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("TuaSauGiacMac_SacTo_MP", BenhAnMatDayMat.TuaSauGiacMac_SacTo_MP == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("ViTriTua_MP", BenhAnMatDayMat.ViTriTua_MP));
            Command.Parameters.Add(new MDB.MDBParameter("SeoGiacMac_MP", BenhAnMatDayMat.SeoGiacMac_MP == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("BenhLyKhac_GiacMac_MP", BenhAnMatDayMat.BenhLyKhac_GiacMac_MP));
            Command.Parameters.Add(new MDB.MDBParameter("CungMac_MP", BenhAnMatDayMat.iCungMac_MP));
            Command.Parameters.Add(new MDB.MDBParameter("BenhLyKhac_CungMac_MP", BenhAnMatDayMat.BenhLyKhac_CungMac_MP));
            Command.Parameters.Add(new MDB.MDBParameter("TienPhong_SauSach_MP", BenhAnMatDayMat.TienPhong_SauSach_MP == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("TienPhong_XepTienPhong_MP", BenhAnMatDayMat.TienPhong_XepTienPhong_MP == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("XuatHuyet_TienPhong_MP", BenhAnMatDayMat.XuatHuyet_TienPhong_MP == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("XuatHuyet_TienPhong_Text_MP", BenhAnMatDayMat.XuatHuyet_TienPhong_Text_MP));
            Command.Parameters.Add(new MDB.MDBParameter("XuatTuyet_TienPhong_MP", BenhAnMatDayMat.XuatTuyet_TienPhong_MP == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("XuatTuyet_TienPhong_Text_MP", BenhAnMatDayMat.XuatTuyet_TienPhong_Text_MP));
            Command.Parameters.Add(new MDB.MDBParameter("Tyndall_TienPhong_MP", BenhAnMatDayMat.Tyndall_TienPhong_MP == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("Tyndall_TienPhong_Text_MP", BenhAnMatDayMat.Tyndall_TienPhong_Text_MP));
            Command.Parameters.Add(new MDB.MDBParameter("GocTienPhong_MP", BenhAnMatDayMat.GocTienPhong_MP));
            Command.Parameters.Add(new MDB.MDBParameter("TonThuongKhac_TienPhong_MP", BenhAnMatDayMat.TonThuongKhac_TienPhong_MP));
            Command.Parameters.Add(new MDB.MDBParameter("MongMat_MP", BenhAnMatDayMat.MongMat_MP == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("TanMachMongMat_MP", BenhAnMatDayMat.TanMachMongMat_MP == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("TanMachMongMat_Text_MP", BenhAnMatDayMat.TanMachMongMat_Text_MP));
            Command.Parameters.Add(new MDB.MDBParameter("HatKoeppiMongMat_MP", BenhAnMatDayMat.HatKoeppiMongMat_MP == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("HatKoeppiMongMat_Text_MP", BenhAnMatDayMat.HatKoeppiMongMat_Text_MP));
            Command.Parameters.Add(new MDB.MDBParameter("HatBussacaMongMat_MP", BenhAnMatDayMat.HatBussacaMongMat_MP == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("HatBussacaMongMat_Text_MP", BenhAnMatDayMat.HatBussacaMongMat_Text_MP));
            Command.Parameters.Add(new MDB.MDBParameter("KichThuoc_DongTu_MP", BenhAnMatDayMat.KichThuoc_DongTu_MP));
            Command.Parameters.Add(new MDB.MDBParameter("AnhDongTu_DongTu_MP", BenhAnMatDayMat.AnhDongTu_DongTu_MP));
            Command.Parameters.Add(new MDB.MDBParameter("TronMeo_DongTu_MP", BenhAnMatDayMat.TronMeo_DongTu_MP == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("Dinh_DongTu_MP", BenhAnMatDayMat.Dinh_DongTu_MP == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("ViTri_DongTu_MP", BenhAnMatDayMat.ViTri_DongTu_MP));
            Command.Parameters.Add(new MDB.MDBParameter("PXDT_MP", BenhAnMatDayMat.PXDT_MP == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("GianLiet_DongTu_MP", BenhAnMatDayMat.GianLiet_DongTu_MP == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("BenhLyKhac_DongTu_MP", BenhAnMatDayMat.BenhLyKhac_DongTu_MP));
            Command.Parameters.Add(new MDB.MDBParameter("TheThuyTinh_MP", BenhAnMatDayMat.TheThuyTinh_MP));
            Command.Parameters.Add(new MDB.MDBParameter("DiVat_TheThuyTinh_MP", BenhAnMatDayMat.DiVat_TheThuyTinh_MP == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("SaLech_TheThuyTinh_MP", BenhAnMatDayMat.SaLech_TheThuyTinh_MP == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("SaLechID_TheThuyTinh_MP", BenhAnMatDayMat.SaLechID_TheThuyTinh_MP == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("DinhSacTo_TheThuyTinh_MP", BenhAnMatDayMat.DinhSacTo_TheThuyTinh_MP == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("ViemMu_TheThuyTinh_MP", BenhAnMatDayMat.ViemMu_TheThuyTinh_MP == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("TonThuongKhac_TheThuyTinh_MP", BenhAnMatDayMat.TonThuongKhac_TheThuyTinh_MP));
            Command.Parameters.Add(new MDB.MDBParameter("DichKinh_MP", BenhAnMatDayMat.DichKinh_MP == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("DichKinh_MP_Text", BenhAnMatDayMat.DichKinh_MP_Text));
            Command.Parameters.Add(new MDB.MDBParameter("ViemMu_DichKinh_MP", BenhAnMatDayMat.ViemMu_DichKinh_MP == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("ViemMu_DichKinh_MP_Text", BenhAnMatDayMat.ViemMu_DichKinh_MP_Text));
            Command.Parameters.Add(new MDB.MDBParameter("XuatHuyet_DichKinh_MP", BenhAnMatDayMat.XuatHuyet_DichKinh_MP == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("ToChucHoa_DichKinh_MP", BenhAnMatDayMat.ToChucHoa_DichKinh_MP == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("Bong_DichKinh_MP", BenhAnMatDayMat.Bong_DichKinh_MP == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("TonThuongKhac_DichKinh_MP", BenhAnMatDayMat.TonThuongKhac_DichKinh_MP));
            Command.Parameters.Add(new MDB.MDBParameter("HeMach_VongMac_MP", BenhAnMatDayMat.HeMach_VongMac_MP == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("TacDM_VongMac_MP", BenhAnMatDayMat.TacDM_VongMac_MP));
            Command.Parameters.Add(new MDB.MDBParameter("TacTM_VongMac_MP", BenhAnMatDayMat.TacTM_VongMac_MP));
            Command.Parameters.Add(new MDB.MDBParameter("TacTM_Phu_VongMac_MP", BenhAnMatDayMat.TacTM_Phu_VongMac_MP == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("TacTM_ThieuMau_VongMac_MP", BenhAnMatDayMat.TacTM_ThieuMau_VongMac_MP == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("TacTM_HonHop_VongMac_MP", BenhAnMatDayMat.TacTM_HonHop_VongMac_MP == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("ViemMaoMach_VongMac_MP", BenhAnMatDayMat.ViemMaoMach_VongMac_MP == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("TanMach_VongMac_MP", BenhAnMatDayMat.TanMach_VongMac_MP == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("TanMachHacMac_MP", BenhAnMatDayMat.TanMachHacMac_MP));
            Command.Parameters.Add(new MDB.MDBParameter("DiaThi_VongMac_MP", BenhAnMatDayMat.DiaThi_VongMac_MP == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("DiaThiID_VongMac_MP", BenhAnMatDayMat.DiaThiID_VongMac_MP));
            Command.Parameters.Add(new MDB.MDBParameter("TanMachGai_VongMac_MP", BenhAnMatDayMat.TanMachGai_VongMac_MP == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("TanMachGaiID_VongMac_MP", BenhAnMatDayMat.TanMachGaiID_VongMac_MP));
            Command.Parameters.Add(new MDB.MDBParameter("HoangDiem_VongMac_MP", BenhAnMatDayMat.HoangDiem_VongMac_MP == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("HoangDiem_Phu_VongMac_MP", BenhAnMatDayMat.HoangDiem_Phu_VongMac_MP));
            Command.Parameters.Add(new MDB.MDBParameter("HoangDiem_Lo_VongMac_MP", BenhAnMatDayMat.HoangDiem_Lo_VongMac_MP));
            Command.Parameters.Add(new MDB.MDBParameter("HoangDiem_Lo_Do_VongMac_MP", BenhAnMatDayMat.HoangDiem_Lo_Do_VongMac_MP));
            Command.Parameters.Add(new MDB.MDBParameter("HoangDiem_Seo_VongMac_MP", BenhAnMatDayMat.HoangDiem_Seo_VongMac_MP == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("ThoaiHoa_VongMac_MP", BenhAnMatDayMat.ThoaiHoa_VongMac_MP));
            Command.Parameters.Add(new MDB.MDBParameter("ThoaiHoa_VongMac_MP_Text", BenhAnMatDayMat.ThoaiHoa_VongMac_MP_Text));
            Command.Parameters.Add(new MDB.MDBParameter("XuatHuyet_VongMac_MP", BenhAnMatDayMat.XuatHuyet_VongMac_MP));
            Command.Parameters.Add(new MDB.MDBParameter("XuatTiet_VongMac_MP", BenhAnMatDayMat.XuatTiet_VongMac_MP));
            Command.Parameters.Add(new MDB.MDBParameter("BongThanhDich_VongMac_MP", BenhAnMatDayMat.BongThanhDich_VongMac_MP));
            Command.Parameters.Add(new MDB.MDBParameter("OViemHacHac_MP", BenhAnMatDayMat.OViemHacHac_MP == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("OViemHacHac_MPText1", BenhAnMatDayMat.OViemHacHac_MPText1));
            Command.Parameters.Add(new MDB.MDBParameter("OViemHacHac_MPText2", BenhAnMatDayMat.OViemHacHac_MPText2));
            Command.Parameters.Add(new MDB.MDBParameter("BongVongMac_MP", BenhAnMatDayMat.BongVongMac_MP == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("BongVongMac_MP_Text", BenhAnMatDayMat.BongVongMac_MP_Text));
            Command.Parameters.Add(new MDB.MDBParameter("RachVongMac_MP", BenhAnMatDayMat.RachVongMac_MP == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("RachVongMac_MP_Text", BenhAnMatDayMat.RachVongMac_MP_Text));
            Command.Parameters.Add(new MDB.MDBParameter("RachVongMac_MP_Text1", BenhAnMatDayMat.RachVongMac_MP_Text1));
            Command.Parameters.Add(new MDB.MDBParameter("RachVongMac_MP_Text2", BenhAnMatDayMat.RachVongMac_MP_Text2));
            Command.Parameters.Add(new MDB.MDBParameter("RachVongMac_MP_Text3", BenhAnMatDayMat.RachVongMac_MP_Text3));
            Command.Parameters.Add(new MDB.MDBParameter("TonThuongPhoiHop_MP", BenhAnMatDayMat.TonThuongPhoiHop_MP));
            Command.Parameters.Add(new MDB.MDBParameter("BenhLyKhac_VongMac_MP", BenhAnMatDayMat.BenhLyKhac_VongMac_MP));
            Command.Parameters.Add(new MDB.MDBParameter("HocMat_MP", BenhAnMatDayMat.HocMat_MP == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("HocMat_Text_MP", BenhAnMatDayMat.HocMat_Text_MP));
            Command.Parameters.Add(new MDB.MDBParameter("VanNhan_MP", BenhAnMatDayMat.VanNhan_MP == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("VanNhan_Text_MP", BenhAnMatDayMat.VanNhan_Text_MP));
            Command.Parameters.Add(new MDB.MDBParameter("ChuaCoBieuHienBenhLy", BenhAnMatDayMat.ChuaCoBieuHienBenhLy));
            Command.Parameters.Add(new MDB.MDBParameter("BenhLy", BenhAnMatDayMat.BenhLy));
            Command.Parameters.Add(new MDB.MDBParameter("ChanDoanBenhChinh_LamSang", BenhAnMatDayMat.ChanDoanBenhChinh_LamSang));
            Command.Parameters.Add(new MDB.MDBParameter("ChanDoanBenhChinh_NguyenNhan", BenhAnMatDayMat.ChanDoanBenhChinh_NguyenNhan));
            Command.Parameters.Add(new MDB.MDBParameter("QuaTrinhDieuTri_NoiKhoa", BenhAnMatDayMat.QuaTrinhDieuTri_NoiKhoa));
            Command.Parameters.Add(new MDB.MDBParameter("PhauThuat", BenhAnMatDayMat.PhauThuat == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("ThuThuat", BenhAnMatDayMat.ThuThuat == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("ThiLucRaVienKhongKinhMPTongKet", BenhAnMatDayMat.ThiLucRaVienKhongKinhMPTongKet));
            Command.Parameters.Add(new MDB.MDBParameter("ThiLucRaVienKhongKinhMTTongKet", BenhAnMatDayMat.ThiLucRaVienKhongKinhMTTongKet));
            Command.Parameters.Add(new MDB.MDBParameter("ThiLucRaVienCoKinhMPTongKet", BenhAnMatDayMat.ThiLucRaVienCoKinhMPTongKet));
            Command.Parameters.Add(new MDB.MDBParameter("ThiLucRaVienCoKinhMTTongKet", BenhAnMatDayMat.ThiLucRaVienCoKinhMTTongKet));
            Command.Parameters.Add(new MDB.MDBParameter("NhanApRaVienMPTongKet", BenhAnMatDayMat.NhanApRaVienMPTongKet));
            Command.Parameters.Add(new MDB.MDBParameter("NhanApRaVienMTTongKet", BenhAnMatDayMat.NhanApRaVienMTTongKet));
            Command.Parameters.Add(new MDB.MDBParameter("HuongDieuTriTiep", BenhAnMatDayMat.HuongDieuTriTiep));
            Command.Parameters.Add(new MDB.MDBParameter("MiMat_MT", BenhAnMatDayMat.iMiMat_MT));
            Command.Parameters.Add(new MDB.MDBParameter("PhanUngTheMi_MT", BenhAnMatDayMat.PhanUngTheMi_MT == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("BenhLyKhac_MT", BenhAnMatDayMat.BenhLyKhac_MT));
            Command.Parameters.Add(new MDB.MDBParameter("KetMac_MT", BenhAnMatDayMat.KetMac_MT));
            Command.Parameters.Add(new MDB.MDBParameter("XuatHuyet_MT", BenhAnMatDayMat.XuatHuyet_MT == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("XuatHuyet_MT_Text", BenhAnMatDayMat.XuatHuyet_MT_Text));
            Command.Parameters.Add(new MDB.MDBParameter("SeoKetMac_MT", BenhAnMatDayMat.SeoKetMac_MT == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("SeoKetMac_MT_Text", BenhAnMatDayMat.SeoKetMac_MT_Text));
            Command.Parameters.Add(new MDB.MDBParameter("BenhLyKhac_KetMac_MT", BenhAnMatDayMat.BenhLyKhac_KetMac_MT));
            Command.Parameters.Add(new MDB.MDBParameter("GiacMac_Trong_MT", BenhAnMatDayMat.GiacMac_Trong_MT == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("GiacMac_Phu_MT", BenhAnMatDayMat.GiacMac_Phu_MT == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("GiacMac_Seo_MT", BenhAnMatDayMat.GiacMac_Seo_MT == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("TuaSauGiacMac_MoiCu_MT", BenhAnMatDayMat.iTuaSauGiacMac_MoiCu_MT));
            Command.Parameters.Add(new MDB.MDBParameter("TuaSauGiacMac_MoCuu_MT", BenhAnMatDayMat.TuaSauGiacMac_MoCuu_MT == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("TuaSauGiacMac_SacTo_MT", BenhAnMatDayMat.TuaSauGiacMac_SacTo_MT == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("ViTriTua_MT", BenhAnMatDayMat.ViTriTua_MT));
            Command.Parameters.Add(new MDB.MDBParameter("SeoGiacMac_MT", BenhAnMatDayMat.SeoGiacMac_MT == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("BenhLyKhac_GiacMac_MT", BenhAnMatDayMat.BenhLyKhac_GiacMac_MT));
            Command.Parameters.Add(new MDB.MDBParameter("CungMac_MT", BenhAnMatDayMat.iCungMac_MT));
            Command.Parameters.Add(new MDB.MDBParameter("BenhLyKhac_CungMac_MT", BenhAnMatDayMat.BenhLyKhac_CungMac_MT));
            Command.Parameters.Add(new MDB.MDBParameter("TienPhong_SauSach_MT", BenhAnMatDayMat.TienPhong_SauSach_MT == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("TienPhong_XepTienPhong_MT", BenhAnMatDayMat.TienPhong_XepTienPhong_MT == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("XuatHuyet_TienPhong_MT", BenhAnMatDayMat.XuatHuyet_TienPhong_MT == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("XuatHuyet_TienPhong_Text_MT", BenhAnMatDayMat.XuatHuyet_TienPhong_Text_MT));
            Command.Parameters.Add(new MDB.MDBParameter("XuatTuyet_TienPhong_MT", BenhAnMatDayMat.XuatTuyet_TienPhong_MT == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("XuatTuyet_TienPhong_Text_MT", BenhAnMatDayMat.XuatTuyet_TienPhong_Text_MT));
            Command.Parameters.Add(new MDB.MDBParameter("Tyndall_TienPhong_MT", BenhAnMatDayMat.Tyndall_TienPhong_MT == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("Tyndall_TienPhong_Text_MT", BenhAnMatDayMat.Tyndall_TienPhong_Text_MT));
            Command.Parameters.Add(new MDB.MDBParameter("GocTienPhong_MT", BenhAnMatDayMat.GocTienPhong_MT));
            Command.Parameters.Add(new MDB.MDBParameter("TonThuongKhac_TienPhong_MT", BenhAnMatDayMat.TonThuongKhac_TienPhong_MT));
            Command.Parameters.Add(new MDB.MDBParameter("MongMat_MT", BenhAnMatDayMat.MongMat_MT == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("TanMachMongMat_MT", BenhAnMatDayMat.TanMachMongMat_MT == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("TanMachMongMat_Text_MT", BenhAnMatDayMat.TanMachMongMat_Text_MT));
            Command.Parameters.Add(new MDB.MDBParameter("HatKoeppiMongMat_MT", BenhAnMatDayMat.HatKoeppiMongMat_MT == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("HatKoeppiMongMat_Text_MT", BenhAnMatDayMat.HatKoeppiMongMat_Text_MT));
            Command.Parameters.Add(new MDB.MDBParameter("HatBussacaMongMat_MT", BenhAnMatDayMat.HatBussacaMongMat_MT == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("HatBussacaMongMat_Text_MT", BenhAnMatDayMat.HatBussacaMongMat_Text_MT));
            Command.Parameters.Add(new MDB.MDBParameter("KichThuoc_DongTu_MT", BenhAnMatDayMat.KichThuoc_DongTu_MT));
            Command.Parameters.Add(new MDB.MDBParameter("AnhDongTu_DongTu_MT", BenhAnMatDayMat.AnhDongTu_DongTu_MT));
            Command.Parameters.Add(new MDB.MDBParameter("TronMeo_DongTu_MT", BenhAnMatDayMat.TronMeo_DongTu_MT == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("Dinh_DongTu_MT", BenhAnMatDayMat.Dinh_DongTu_MT == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("ViTri_DongTu_MT", BenhAnMatDayMat.ViTri_DongTu_MT));
            Command.Parameters.Add(new MDB.MDBParameter("PXDT_MT", BenhAnMatDayMat.PXDT_MT == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("GianLiet_DongTu_MT", BenhAnMatDayMat.GianLiet_DongTu_MT == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("BenhLyKhac_DongTu_MT", BenhAnMatDayMat.BenhLyKhac_DongTu_MT));
            Command.Parameters.Add(new MDB.MDBParameter("TheThuyTinh_MT", BenhAnMatDayMat.TheThuyTinh_MT));
            Command.Parameters.Add(new MDB.MDBParameter("DiVat_TheThuyTinh_MT", BenhAnMatDayMat.DiVat_TheThuyTinh_MT == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("SaLech_TheThuyTinh_MT", BenhAnMatDayMat.SaLech_TheThuyTinh_MT == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("SaLechID_TheThuyTinh_MT", BenhAnMatDayMat.SaLechID_TheThuyTinh_MT == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("DinhSacTo_TheThuyTinh_MT", BenhAnMatDayMat.DinhSacTo_TheThuyTinh_MT == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("ViemMu_TheThuyTinh_MT", BenhAnMatDayMat.ViemMu_TheThuyTinh_MT == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("TonThuongKhac_TheThuyTinh_MT", BenhAnMatDayMat.TonThuongKhac_TheThuyTinh_MT));
            Command.Parameters.Add(new MDB.MDBParameter("DichKinh_MT", BenhAnMatDayMat.DichKinh_MT == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("DichKinh_MT_Text", BenhAnMatDayMat.DichKinh_MT_Text));
            Command.Parameters.Add(new MDB.MDBParameter("ViemMu_DichKinh_MT", BenhAnMatDayMat.ViemMu_DichKinh_MT == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("ViemMu_DichKinh_MT_Text", BenhAnMatDayMat.ViemMu_DichKinh_MT_Text));
            Command.Parameters.Add(new MDB.MDBParameter("XuatHuyet_DichKinh_MT", BenhAnMatDayMat.XuatHuyet_DichKinh_MT == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("ToChucHoa_DichKinh_MT", BenhAnMatDayMat.ToChucHoa_DichKinh_MT == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("Bong_DichKinh_MT", BenhAnMatDayMat.Bong_DichKinh_MT == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("TonThuongKhac_DichKinh_MT", BenhAnMatDayMat.TonThuongKhac_DichKinh_MT));
            Command.Parameters.Add(new MDB.MDBParameter("HeMach_VongMac_MT", BenhAnMatDayMat.HeMach_VongMac_MT == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("TacDM_VongMac_MT", BenhAnMatDayMat.TacDM_VongMac_MT));
            Command.Parameters.Add(new MDB.MDBParameter("TacTM_VongMac_MT", BenhAnMatDayMat.TacTM_VongMac_MT));
            Command.Parameters.Add(new MDB.MDBParameter("TacTM_Phu_VongMac_MT", BenhAnMatDayMat.TacTM_Phu_VongMac_MT == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("TacTM_ThieuMau_VongMac_MT", BenhAnMatDayMat.TacTM_ThieuMau_VongMac_MT == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("TacTM_HonHop_VongMac_MT", BenhAnMatDayMat.TacTM_HonHop_VongMac_MT == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("ViemMaoMach_VongMac_MT", BenhAnMatDayMat.ViemMaoMach_VongMac_MT == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("TanMach_VongMac_MT", BenhAnMatDayMat.TanMach_VongMac_MT == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("TanMachHacMac_MT", BenhAnMatDayMat.TanMachHacMac_MT));
            Command.Parameters.Add(new MDB.MDBParameter("DiaThi_VongMac_MT", BenhAnMatDayMat.DiaThi_VongMac_MT == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("DiaThiID_VongMac_MT", BenhAnMatDayMat.DiaThiID_VongMac_MT));
            Command.Parameters.Add(new MDB.MDBParameter("TanMachGai_VongMac_MT", BenhAnMatDayMat.TanMachGai_VongMac_MT == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("TanMachGaiID_VongMac_MT", BenhAnMatDayMat.TanMachGaiID_VongMac_MT));
            Command.Parameters.Add(new MDB.MDBParameter("HoangDiem_VongMac_MT", BenhAnMatDayMat.HoangDiem_VongMac_MT == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("HoangDiem_Phu_VongMac_MT", BenhAnMatDayMat.HoangDiem_Phu_VongMac_MT));
            Command.Parameters.Add(new MDB.MDBParameter("HoangDiem_Lo_VongMac_MT", BenhAnMatDayMat.HoangDiem_Lo_VongMac_MT));
            Command.Parameters.Add(new MDB.MDBParameter("HoangDiem_Lo_Do_VongMac_MT", BenhAnMatDayMat.HoangDiem_Lo_Do_VongMac_MT));
            Command.Parameters.Add(new MDB.MDBParameter("HoangDiem_Seo_VongMac_MT", BenhAnMatDayMat.HoangDiem_Seo_VongMac_MT == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("ThoaiHoa_VongMac_MT", BenhAnMatDayMat.ThoaiHoa_VongMac_MT));
            Command.Parameters.Add(new MDB.MDBParameter("ThoaiHoa_VongMac_MT_Text", BenhAnMatDayMat.ThoaiHoa_VongMac_MT_Text));
            Command.Parameters.Add(new MDB.MDBParameter("XuatHuyet_VongMac_MT", BenhAnMatDayMat.XuatHuyet_VongMac_MT));
            Command.Parameters.Add(new MDB.MDBParameter("XuatTiet_VongMac_MT", BenhAnMatDayMat.XuatTiet_VongMac_MT));
            Command.Parameters.Add(new MDB.MDBParameter("BongThanhDich_VongMac_MT", BenhAnMatDayMat.BongThanhDich_VongMac_MT));
            Command.Parameters.Add(new MDB.MDBParameter("OViemHacHac_MT", BenhAnMatDayMat.OViemHacHac_MT == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("OViemHacHac_MTText1", BenhAnMatDayMat.OViemHacHac_MTText1 == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("OViemHacHac_MTText2", BenhAnMatDayMat.OViemHacHac_MTText2 == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("BongVongMac_MT", BenhAnMatDayMat.BongVongMac_MT == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("BongVongMac_MT_Text", BenhAnMatDayMat.BongVongMac_MT_Text));
            Command.Parameters.Add(new MDB.MDBParameter("RachVongMac_MT", BenhAnMatDayMat.RachVongMac_MT == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("RachVongMac_MT_Text", BenhAnMatDayMat.RachVongMac_MT_Text));
            Command.Parameters.Add(new MDB.MDBParameter("RachVongMac_MT_Text1", BenhAnMatDayMat.RachVongMac_MT_Text1));
            Command.Parameters.Add(new MDB.MDBParameter("RachVongMac_MT_Text2", BenhAnMatDayMat.RachVongMac_MT_Text2));
            Command.Parameters.Add(new MDB.MDBParameter("RachVongMac_MT_Text3", BenhAnMatDayMat.RachVongMac_MT_Text3));
            Command.Parameters.Add(new MDB.MDBParameter("TonThuongPhoiHop_MT", BenhAnMatDayMat.TonThuongPhoiHop_MT));
            Command.Parameters.Add(new MDB.MDBParameter("BenhLyKhac_VongMac_MT", BenhAnMatDayMat.BenhLyKhac_VongMac_MT));
            Command.Parameters.Add(new MDB.MDBParameter("HocMat_MT", BenhAnMatDayMat.HocMat_MT == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("HocMat_Text_MT", BenhAnMatDayMat.HocMat_Text_MT));
            Command.Parameters.Add(new MDB.MDBParameter("VanNhan_MT", BenhAnMatDayMat.VanNhan_MT == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("VanNhan_Text_MT", BenhAnMatDayMat.VanNhan_Text_MT));
            Command.Parameters.Add(new MDB.MDBParameter("ThayBenhLy", BenhAnMatDayMat.ThayBenhLy == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("ChuaThayBenhLy", BenhAnMatDayMat.ChuaThayBenhLy == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("VongMac_BenhLy_MP", BenhAnMatDayMat.VongMac_BenhLy_MP));
            Command.Parameters.Add(new MDB.MDBParameter("VongMac_BenhLy_MP_Text", BenhAnMatDayMat.VongMac_BenhLy_MP_Text));
            Command.Parameters.Add(new MDB.MDBParameter("VongMac_BenhLy_MT", BenhAnMatDayMat.VongMac_BenhLy_MT));
            Command.Parameters.Add(new MDB.MDBParameter("VongMac_BenhLy_MT_Text", BenhAnMatDayMat.VongMac_BenhLy_MT_Text));

            int n = Command.ExecuteNonQuery(); // C#
            return n > 0 ? true : false;
        }
        public static bool Update(MDB.MDBConnection MyConnection, BenhAnMatDayMat BenhAnMatDayMat)
        {
            string sql = @"UPDATE BenhAnMatDayMat SET 
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
ThiLucKhiVaoVien_KhongKinh_MP = :ThiLucKhiVaoVien_KhongKinh_MP,
ThiLucKhiVaoVien_KhongKinh_MT = :ThiLucKhiVaoVien_KhongKinh_MT,
ThiLucKhiVaoVien_CoKinh_MP = :ThiLucKhiVaoVien_CoKinh_MP,
ThiLucKhiVaoVien_CoKinh_MT = :ThiLucKhiVaoVien_CoKinh_MT,
NhanApVaoVien_MT = :NhanApVaoVien_MT,
NhanApVaoVien_MP = :NhanApVaoVien_MP,
ThiTruong_MP = :ThiTruong_MP,
ThiTruong_MT = :ThiTruong_MT,
MiMat_MP = :MiMat_MP,
PhanUngTheMi_MP = :PhanUngTheMi_MP,
BenhLyKhac_MP = :BenhLyKhac_MP,
KetMac_MP = :KetMac_MP,
XuatHuyet_MP = :XuatHuyet_MP,
XuatHuyet_MP_Text = :XuatHuyet_MP_Text,
SeoKetMac_MP = :SeoKetMac_MP,
SeoKetMac_MP_Text = :SeoKetMac_MP_Text,
BenhLyKhac_KetMac_MP = :BenhLyKhac_KetMac_MP,
GiacMac_Trong_MP = :GiacMac_Trong_MP,
GiacMac_Phu_MP = :GiacMac_Phu_MP,
GiacMac_Seo_MP = :GiacMac_Seo_MP,
TuaSauGiacMac_MoiCu_MP = :TuaSauGiacMac_MoiCu_MP,
TuaSauGiacMac_MoCuu_MP = :TuaSauGiacMac_MoCuu_MP,
TuaSauGiacMac_SacTo_MP = :TuaSauGiacMac_SacTo_MP,
ViTriTua_MP = :ViTriTua_MP,
SeoGiacMac_MP = :SeoGiacMac_MP,
BenhLyKhac_GiacMac_MP = :BenhLyKhac_GiacMac_MP,
CungMac_MP = :CungMac_MP,
BenhLyKhac_CungMac_MP = :BenhLyKhac_CungMac_MP,
TienPhong_SauSach_MP = :TienPhong_SauSach_MP,
TienPhong_XepTienPhong_MP = :TienPhong_XepTienPhong_MP,
XuatHuyet_TienPhong_MP = :XuatHuyet_TienPhong_MP,
XuatHuyet_TienPhong_Text_MP = :XuatHuyet_TienPhong_Text_MP,
XuatTuyet_TienPhong_MP = :XuatTuyet_TienPhong_MP,
XuatTuyet_TienPhong_Text_MP = :XuatTuyet_TienPhong_Text_MP,
Tyndall_TienPhong_MP = :Tyndall_TienPhong_MP,
Tyndall_TienPhong_Text_MP = :Tyndall_TienPhong_Text_MP,
GocTienPhong_MP = :GocTienPhong_MP,
TonThuongKhac_TienPhong_MP = :TonThuongKhac_TienPhong_MP,
MongMat_MP = :MongMat_MP,
TanMachMongMat_MP = :TanMachMongMat_MP,
TanMachMongMat_Text_MP = :TanMachMongMat_Text_MP,
HatKoeppiMongMat_MP = :HatKoeppiMongMat_MP,
HatKoeppiMongMat_Text_MP = :HatKoeppiMongMat_Text_MP,
HatBussacaMongMat_MP = :HatBussacaMongMat_MP,
HatBussacaMongMat_Text_MP = :HatBussacaMongMat_Text_MP,
KichThuoc_DongTu_MP = :KichThuoc_DongTu_MP,
AnhDongTu_DongTu_MP = :AnhDongTu_DongTu_MP,
TronMeo_DongTu_MP = :TronMeo_DongTu_MP,
Dinh_DongTu_MP = :Dinh_DongTu_MP,
ViTri_DongTu_MP = :ViTri_DongTu_MP,
PXDT_MP = :PXDT_MP,
GianLiet_DongTu_MP = :GianLiet_DongTu_MP,
BenhLyKhac_DongTu_MP = :BenhLyKhac_DongTu_MP,
TheThuyTinh_MP = :TheThuyTinh_MP,
DiVat_TheThuyTinh_MP = :DiVat_TheThuyTinh_MP,
SaLech_TheThuyTinh_MP = :SaLech_TheThuyTinh_MP,
SaLechID_TheThuyTinh_MP = :SaLechID_TheThuyTinh_MP,
DinhSacTo_TheThuyTinh_MP = :DinhSacTo_TheThuyTinh_MP,
ViemMu_TheThuyTinh_MP = :ViemMu_TheThuyTinh_MP,
TonThuongKhac_TheThuyTinh_MP = :TonThuongKhac_TheThuyTinh_MP,
DichKinh_MP = :DichKinh_MP,
DichKinh_MP_Text = :DichKinh_MP_Text,
ViemMu_DichKinh_MP = :ViemMu_DichKinh_MP,
ViemMu_DichKinh_MP_Text = :ViemMu_DichKinh_MP_Text,
XuatHuyet_DichKinh_MP = :XuatHuyet_DichKinh_MP,
ToChucHoa_DichKinh_MP = :ToChucHoa_DichKinh_MP,
Bong_DichKinh_MP = :Bong_DichKinh_MP,
TonThuongKhac_DichKinh_MP = :TonThuongKhac_DichKinh_MP,
HeMach_VongMac_MP = :HeMach_VongMac_MP,
TacDM_VongMac_MP = :TacDM_VongMac_MP,
TacTM_VongMac_MP = :TacTM_VongMac_MP,
TacTM_Phu_VongMac_MP = :TacTM_Phu_VongMac_MP,
TacTM_ThieuMau_VongMac_MP = :TacTM_ThieuMau_VongMac_MP,
TacTM_HonHop_VongMac_MP = :TacTM_HonHop_VongMac_MP,
ViemMaoMach_VongMac_MP = :ViemMaoMach_VongMac_MP,
TanMach_VongMac_MP = :TanMach_VongMac_MP,
TanMachHacMac_MP = :TanMachHacMac_MP,
DiaThi_VongMac_MP = :DiaThi_VongMac_MP,
DiaThiID_VongMac_MP = :DiaThiID_VongMac_MP,
TanMachGai_VongMac_MP = :TanMachGai_VongMac_MP,
TanMachGaiID_VongMac_MP = :TanMachGaiID_VongMac_MP,
HoangDiem_VongMac_MP = :HoangDiem_VongMac_MP,
HoangDiem_Phu_VongMac_MP = :HoangDiem_Phu_VongMac_MP,
HoangDiem_Lo_VongMac_MP = :HoangDiem_Lo_VongMac_MP,
HoangDiem_Lo_Do_VongMac_MP = :HoangDiem_Lo_Do_VongMac_MP,
HoangDiem_Seo_VongMac_MP = :HoangDiem_Seo_VongMac_MP,
ThoaiHoa_VongMac_MP = :ThoaiHoa_VongMac_MP,
ThoaiHoa_VongMac_MP_Text = :ThoaiHoa_VongMac_MP_Text,
XuatHuyet_VongMac_MP = :XuatHuyet_VongMac_MP,
XuatTiet_VongMac_MP = :XuatTiet_VongMac_MP,
BongThanhDich_VongMac_MP = :BongThanhDich_VongMac_MP,
OViemHacHac_MP = :OViemHacHac_MP,
OViemHacHac_MPText1 = :OViemHacHac_MPText1,
OViemHacHac_MPText2 = :OViemHacHac_MPText2,
BongVongMac_MP = :BongVongMac_MP,
BongVongMac_MP_Text = :BongVongMac_MP_Text,
RachVongMac_MP = :RachVongMac_MP,
RachVongMac_MP_Text = :RachVongMac_MP_Text,
RachVongMac_MP_Text1 = :RachVongMac_MP_Text1,
RachVongMac_MP_Text2 = :RachVongMac_MP_Text2,
RachVongMac_MP_Text3 = :RachVongMac_MP_Text3,
TonThuongPhoiHop_MP = :TonThuongPhoiHop_MP,
BenhLyKhac_VongMac_MP = :BenhLyKhac_VongMac_MP,
HocMat_MP = :HocMat_MP,
HocMat_Text_MP = :HocMat_Text_MP,
VanNhan_MP = :VanNhan_MP,
VanNhan_Text_MP = :VanNhan_Text_MP,
ChuaCoBieuHienBenhLy = :ChuaCoBieuHienBenhLy,
BenhLy = :BenhLy,
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
MiMat_MT = :MiMat_MT,
PhanUngTheMi_MT = :PhanUngTheMi_MT,
BenhLyKhac_MT = :BenhLyKhac_MT,
KetMac_MT = :KetMac_MT,
XuatHuyet_MT = :XuatHuyet_MT,
XuatHuyet_MT_Text = :XuatHuyet_MT_Text,
SeoKetMac_MT = :SeoKetMac_MT,
SeoKetMac_MT_Text = :SeoKetMac_MT_Text,
BenhLyKhac_KetMac_MT = :BenhLyKhac_KetMac_MT,
GiacMac_Trong_MT = :GiacMac_Trong_MT,
GiacMac_Phu_MT = :GiacMac_Phu_MT,
GiacMac_Seo_MT = :GiacMac_Seo_MT,
TuaSauGiacMac_MoiCu_MT = :TuaSauGiacMac_MoiCu_MT,
TuaSauGiacMac_MoCuu_MT = :TuaSauGiacMac_MoCuu_MT,
TuaSauGiacMac_SacTo_MT = :TuaSauGiacMac_SacTo_MT,
ViTriTua_MT = :ViTriTua_MT,
SeoGiacMac_MT = :SeoGiacMac_MT,
BenhLyKhac_GiacMac_MT = :BenhLyKhac_GiacMac_MT,
CungMac_MT = :CungMac_MT,
BenhLyKhac_CungMac_MT = :BenhLyKhac_CungMac_MT,
TienPhong_SauSach_MT = :TienPhong_SauSach_MT,
TienPhong_XepTienPhong_MT = :TienPhong_XepTienPhong_MT,
XuatHuyet_TienPhong_MT = :XuatHuyet_TienPhong_MT,
XuatHuyet_TienPhong_Text_MT = :XuatHuyet_TienPhong_Text_MT,
XuatTuyet_TienPhong_MT = :XuatTuyet_TienPhong_MT,
XuatTuyet_TienPhong_Text_MT = :XuatTuyet_TienPhong_Text_MT,
Tyndall_TienPhong_MT = :Tyndall_TienPhong_MT,
Tyndall_TienPhong_Text_MT = :Tyndall_TienPhong_Text_MT,
GocTienPhong_MT = :GocTienPhong_MT,
TonThuongKhac_TienPhong_MT = :TonThuongKhac_TienPhong_MT,
MongMat_MT = :MongMat_MT,
TanMachMongMat_MT = :TanMachMongMat_MT,
TanMachMongMat_Text_MT = :TanMachMongMat_Text_MT,
HatKoeppiMongMat_MT = :HatKoeppiMongMat_MT,
HatKoeppiMongMat_Text_MT = :HatKoeppiMongMat_Text_MT,
HatBussacaMongMat_MT = :HatBussacaMongMat_MT,
HatBussacaMongMat_Text_MT = :HatBussacaMongMat_Text_MT,
KichThuoc_DongTu_MT = :KichThuoc_DongTu_MT,
AnhDongTu_DongTu_MT = :AnhDongTu_DongTu_MT,
TronMeo_DongTu_MT = :TronMeo_DongTu_MT,
Dinh_DongTu_MT = :Dinh_DongTu_MT,
ViTri_DongTu_MT = :ViTri_DongTu_MT,
PXDT_MT = :PXDT_MT,
GianLiet_DongTu_MT = :GianLiet_DongTu_MT,
BenhLyKhac_DongTu_MT = :BenhLyKhac_DongTu_MT,
TheThuyTinh_MT = :TheThuyTinh_MT,
DiVat_TheThuyTinh_MT = :DiVat_TheThuyTinh_MT,
SaLech_TheThuyTinh_MT = :SaLech_TheThuyTinh_MT,
SaLechID_TheThuyTinh_MT = :SaLechID_TheThuyTinh_MT,
DinhSacTo_TheThuyTinh_MT = :DinhSacTo_TheThuyTinh_MT,
ViemMu_TheThuyTinh_MT = :ViemMu_TheThuyTinh_MT,
TonThuongKhac_TheThuyTinh_MT = :TonThuongKhac_TheThuyTinh_MT,
DichKinh_MT = :DichKinh_MT,
DichKinh_MT_Text = :DichKinh_MT_Text,
ViemMu_DichKinh_MT = :ViemMu_DichKinh_MT,
ViemMu_DichKinh_MT_Text = :ViemMu_DichKinh_MT_Text,
XuatHuyet_DichKinh_MT = :XuatHuyet_DichKinh_MT,
ToChucHoa_DichKinh_MT = :ToChucHoa_DichKinh_MT,
Bong_DichKinh_MT = :Bong_DichKinh_MT,
TonThuongKhac_DichKinh_MT = :TonThuongKhac_DichKinh_MT,
HeMach_VongMac_MT = :HeMach_VongMac_MT,
TacDM_VongMac_MT = :TacDM_VongMac_MT,
TacTM_VongMac_MT = :TacTM_VongMac_MT,
TacTM_Phu_VongMac_MT = :TacTM_Phu_VongMac_MT,
TacTM_ThieuMau_VongMac_MT = :TacTM_ThieuMau_VongMac_MT,
TacTM_HonHop_VongMac_MT = :TacTM_HonHop_VongMac_MT,
ViemMaoMach_VongMac_MT = :ViemMaoMach_VongMac_MT,
TanMach_VongMac_MT = :TanMach_VongMac_MT,
TanMachHacMac_MT = :TanMachHacMac_MT,
DiaThi_VongMac_MT = :DiaThi_VongMac_MT,
DiaThiID_VongMac_MT = :DiaThiID_VongMac_MT,
TanMachGai_VongMac_MT = :TanMachGai_VongMac_MT,
TanMachGaiID_VongMac_MT = :TanMachGaiID_VongMac_MT,
HoangDiem_VongMac_MT = :HoangDiem_VongMac_MT,
HoangDiem_Phu_VongMac_MT = :HoangDiem_Phu_VongMac_MT,
HoangDiem_Lo_VongMac_MT = :HoangDiem_Lo_VongMac_MT,
HoangDiem_Lo_Do_VongMac_MT = :HoangDiem_Lo_Do_VongMac_MT,
HoangDiem_Seo_VongMac_MT = :HoangDiem_Seo_VongMac_MT,
ThoaiHoa_VongMac_MT = :ThoaiHoa_VongMac_MT,
ThoaiHoa_VongMac_MT_Text = :ThoaiHoa_VongMac_MT_Text,
XuatHuyet_VongMac_MT = :XuatHuyet_VongMac_MT,
XuatTiet_VongMac_MT = :XuatTiet_VongMac_MT,
BongThanhDich_VongMac_MT = :BongThanhDich_VongMac_MT,
OViemHacHac_MT = :OViemHacHac_MT,
OViemHacHac_MTText1 = :OViemHacHac_MTText1,
OViemHacHac_MTText2 = :OViemHacHac_MTText2,
BongVongMac_MT = :BongVongMac_MT,
BongVongMac_MT_Text = :BongVongMac_MT_Text,
RachVongMac_MT = :RachVongMac_MT,
RachVongMac_MT_Text = :RachVongMac_MT_Text,
RachVongMac_MT_Text1 = :RachVongMac_MT_Text1,
RachVongMac_MT_Text2 = :RachVongMac_MT_Text2,
RachVongMac_MT_Text3 = :RachVongMac_MT_Text3,
TonThuongPhoiHop_MT = :TonThuongPhoiHop_MT,
BenhLyKhac_VongMac_MT = :BenhLyKhac_VongMac_MT,
HocMat_MT = :HocMat_MT,
HocMat_Text_MT = :HocMat_Text_MT,
VanNhan_MT = :VanNhan_MT,
VanNhan_Text_MT = :VanNhan_Text_MT,
ThayBenhLy = :ThayBenhLy,
ChuaThayBenhLy = :ChuaThayBenhLy,
VongMac_BenhLy_MP = :VongMac_BenhLy_MP,
VongMac_BenhLy_MP_Text = :VongMac_BenhLy_MP_Text,
VongMac_BenhLy_MT = :VongMac_BenhLy_MT,
VongMac_BenhLy_MT_Text = :VongMac_BenhLy_MT_Text

                        WHERE MaQuanLy = :MaQuanLy";
            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
            Command.Parameters.Add(new MDB.MDBParameter("LyDoVaoVien", BenhAnMatDayMat.LyDoVaoVien));
            Command.Parameters.Add(new MDB.MDBParameter("VaoNgayThu", BenhAnMatDayMat.VaoNgayThu));
            Command.Parameters.Add(new MDB.MDBParameter("QuaTrinhBenhLy", BenhAnMatDayMat.QuaTrinhBenhLy));
            Command.Parameters.Add(new MDB.MDBParameter("TienSuBenhBanThan", BenhAnMatDayMat.TienSuBenhBanThan));
            Command.Parameters.Add(new MDB.MDBParameter("TienSuBenhGiaDinh", BenhAnMatDayMat.TienSuBenhGiaDinh));
            Command.Parameters.Add(new MDB.MDBParameter("ToanThan", BenhAnMatDayMat.ToanThan));
            Command.Parameters.Add(new MDB.MDBParameter("TuanHoan", BenhAnMatDayMat.TuanHoan));
            Command.Parameters.Add(new MDB.MDBParameter("HoHap", BenhAnMatDayMat.HoHap));
            Command.Parameters.Add(new MDB.MDBParameter("TieuHoa", BenhAnMatDayMat.TieuHoa));
            Command.Parameters.Add(new MDB.MDBParameter("ThanTietNieuSinhDuc", BenhAnMatDayMat.ThanTietNieuSinhDuc));
            Command.Parameters.Add(new MDB.MDBParameter("ThanKinh", BenhAnMatDayMat.ThanKinh));
            Command.Parameters.Add(new MDB.MDBParameter("CoXuongKhop", BenhAnMatDayMat.CoXuongKhop));
            Command.Parameters.Add(new MDB.MDBParameter("TaiMuiHong", BenhAnMatDayMat.TaiMuiHong));
            Command.Parameters.Add(new MDB.MDBParameter("RangHamMat", BenhAnMatDayMat.RangHamMat));
            Command.Parameters.Add(new MDB.MDBParameter("Mat", BenhAnMatDayMat.Mat));
            Command.Parameters.Add(new MDB.MDBParameter("Khac_CacCoQuan", BenhAnMatDayMat.Khac_CacCoQuan));
            Command.Parameters.Add(new MDB.MDBParameter("CacXetNghiemCanLamSangCanLam", BenhAnMatDayMat.CacXetNghiemCanLamSangCanLam));
            Command.Parameters.Add(new MDB.MDBParameter("TomTatBenhAn", BenhAnMatDayMat.TomTatBenhAn));
            Command.Parameters.Add(new MDB.MDBParameter("BenhChinh", BenhAnMatDayMat.BenhChinh));
            Command.Parameters.Add(new MDB.MDBParameter("BenhKemTheo", BenhAnMatDayMat.BenhKemTheo));
            Command.Parameters.Add(new MDB.MDBParameter("PhanBiet", BenhAnMatDayMat.PhanBiet));
            Command.Parameters.Add(new MDB.MDBParameter("TienLuong", BenhAnMatDayMat.TienLuong));
            Command.Parameters.Add(new MDB.MDBParameter("HuongDieuTri", BenhAnMatDayMat.HuongDieuTri));
            Command.Parameters.Add(new MDB.MDBParameter("NgayKhamBenh", BenhAnMatDayMat.NgayKhamBenh));
            Command.Parameters.Add(new MDB.MDBParameter("BacSyLamBenhAn", BenhAnMatDayMat.BacSyLamBenhAn));
            Command.Parameters.Add(new MDB.MDBParameter("QuaTrinhBenhLyVaDienBien", BenhAnMatDayMat.QuaTrinhBenhLyVaDienBien));
            Command.Parameters.Add(new MDB.MDBParameter("TomTatKetQuaXetNghiem", BenhAnMatDayMat.TomTatKetQuaXetNghiem));
            Command.Parameters.Add(new MDB.MDBParameter("PhuongPhapDieuTri", BenhAnMatDayMat.PhuongPhapDieuTri));
            Command.Parameters.Add(new MDB.MDBParameter("TinhTrangNguoiBenhRaVien", BenhAnMatDayMat.TinhTrangNguoiBenhRaVien));
            Command.Parameters.Add(new MDB.MDBParameter("HuongDieuTriVaCacCheDoTiepTheo", BenhAnMatDayMat.HuongDieuTriVaCacCheDoTiepTheo));
            Command.Parameters.Add(new MDB.MDBParameter("NguoiNhanHoSo", BenhAnMatDayMat.NguoiNhanHoSo));
            Command.Parameters.Add(new MDB.MDBParameter("NguoiGiaoHoSo", BenhAnMatDayMat.NguoiGiaoHoSo));
            Command.Parameters.Add(new MDB.MDBParameter("NgayTongKet", BenhAnMatDayMat.NgayTongKet));
            Command.Parameters.Add(new MDB.MDBParameter("BacSyDieuTri", BenhAnMatDayMat.BacSyDieuTri));
            Command.Parameters.Add(new MDB.MDBParameter("DiUng", BenhAnMatDayMat.DacDiemLienQuanBenh.DiUng == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("DiUng_Text", BenhAnMatDayMat.DacDiemLienQuanBenh.DiUng_Text));
            Command.Parameters.Add(new MDB.MDBParameter("MaTuy", BenhAnMatDayMat.DacDiemLienQuanBenh.MaTuy == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("MaTuy_Text", BenhAnMatDayMat.DacDiemLienQuanBenh.MaTuy_Text));
            Command.Parameters.Add(new MDB.MDBParameter("RuouBia", BenhAnMatDayMat.DacDiemLienQuanBenh.RuouBia == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("RuouBia_Text", BenhAnMatDayMat.DacDiemLienQuanBenh.RuouBia_Text));
            Command.Parameters.Add(new MDB.MDBParameter("ThuocLa", BenhAnMatDayMat.DacDiemLienQuanBenh.ThuocLa == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("ThuocLa_Text", BenhAnMatDayMat.DacDiemLienQuanBenh.ThuocLa_Text));
            Command.Parameters.Add(new MDB.MDBParameter("ThuocLao", BenhAnMatDayMat.DacDiemLienQuanBenh.ThuocLao == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("ThuocLao_Text", BenhAnMatDayMat.DacDiemLienQuanBenh.ThuocLao_Text));
            Command.Parameters.Add(new MDB.MDBParameter("Khac_DacDiemLienQuanBenh", BenhAnMatDayMat.DacDiemLienQuanBenh.Khac_DacDiemLienQuanBenh == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("Khac_DacDiemLienQuanBenh_Text", BenhAnMatDayMat.DacDiemLienQuanBenh.Khac_DacDiemLienQuanBenh_Text));
            Command.Parameters.Add(new MDB.MDBParameter("ThiLucKhiVaoVien_KhongKinh_MP", BenhAnMatDayMat.ThiLucKhiVaoVien_KhongKinh_MP));
            Command.Parameters.Add(new MDB.MDBParameter("ThiLucKhiVaoVien_KhongKinh_MT", BenhAnMatDayMat.ThiLucKhiVaoVien_KhongKinh_MT));
            Command.Parameters.Add(new MDB.MDBParameter("ThiLucKhiVaoVien_CoKinh_MP", BenhAnMatDayMat.ThiLucKhiVaoVien_CoKinh_MP));
            Command.Parameters.Add(new MDB.MDBParameter("ThiLucKhiVaoVien_CoKinh_MT", BenhAnMatDayMat.ThiLucKhiVaoVien_CoKinh_MT));
            Command.Parameters.Add(new MDB.MDBParameter("NhanApVaoVien_MT", BenhAnMatDayMat.NhanApVaoVien_MT));
            Command.Parameters.Add(new MDB.MDBParameter("NhanApVaoVien_MP", BenhAnMatDayMat.NhanApVaoVien_MP));
            Command.Parameters.Add(new MDB.MDBParameter("ThiTruong_MP", BenhAnMatDayMat.ThiTruong_MP));
            Command.Parameters.Add(new MDB.MDBParameter("ThiTruong_MT", BenhAnMatDayMat.ThiTruong_MT));
            Command.Parameters.Add(new MDB.MDBParameter("MiMat_MP", BenhAnMatDayMat.iMiMat_MP));
            Command.Parameters.Add(new MDB.MDBParameter("PhanUngTheMi_MP", BenhAnMatDayMat.PhanUngTheMi_MP == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("BenhLyKhac_MP", BenhAnMatDayMat.BenhLyKhac_MP));
            Command.Parameters.Add(new MDB.MDBParameter("KetMac_MP", BenhAnMatDayMat.KetMac_MP));
            Command.Parameters.Add(new MDB.MDBParameter("XuatHuyet_MP", BenhAnMatDayMat.XuatHuyet_MP == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("XuatHuyet_MP_Text", BenhAnMatDayMat.XuatHuyet_MP_Text));
            Command.Parameters.Add(new MDB.MDBParameter("SeoKetMac_MP", BenhAnMatDayMat.SeoKetMac_MP == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("SeoKetMac_MP_Text", BenhAnMatDayMat.SeoKetMac_MP_Text));
            Command.Parameters.Add(new MDB.MDBParameter("BenhLyKhac_KetMac_MP", BenhAnMatDayMat.BenhLyKhac_KetMac_MP));
            Command.Parameters.Add(new MDB.MDBParameter("GiacMac_Trong_MP", BenhAnMatDayMat.GiacMac_Trong_MP == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("GiacMac_Phu_MP", BenhAnMatDayMat.GiacMac_Phu_MP == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("GiacMac_Seo_MP", BenhAnMatDayMat.GiacMac_Seo_MP == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("TuaSauGiacMac_MoiCu_MP", BenhAnMatDayMat.iTuaSauGiacMac_MoiCu_MP));
            Command.Parameters.Add(new MDB.MDBParameter("TuaSauGiacMac_MoCuu_MP", BenhAnMatDayMat.TuaSauGiacMac_MoCuu_MP == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("TuaSauGiacMac_SacTo_MP", BenhAnMatDayMat.TuaSauGiacMac_SacTo_MP == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("ViTriTua_MP", BenhAnMatDayMat.ViTriTua_MP));
            Command.Parameters.Add(new MDB.MDBParameter("SeoGiacMac_MP", BenhAnMatDayMat.SeoGiacMac_MP == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("BenhLyKhac_GiacMac_MP", BenhAnMatDayMat.BenhLyKhac_GiacMac_MP));
            Command.Parameters.Add(new MDB.MDBParameter("CungMac_MP", BenhAnMatDayMat.iCungMac_MP));
            Command.Parameters.Add(new MDB.MDBParameter("BenhLyKhac_CungMac_MP", BenhAnMatDayMat.BenhLyKhac_CungMac_MP));
            Command.Parameters.Add(new MDB.MDBParameter("TienPhong_SauSach_MP", BenhAnMatDayMat.TienPhong_SauSach_MP == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("TienPhong_XepTienPhong_MP", BenhAnMatDayMat.TienPhong_XepTienPhong_MP == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("XuatHuyet_TienPhong_MP", BenhAnMatDayMat.XuatHuyet_TienPhong_MP == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("XuatHuyet_TienPhong_Text_MP", BenhAnMatDayMat.XuatHuyet_TienPhong_Text_MP));
            Command.Parameters.Add(new MDB.MDBParameter("XuatTuyet_TienPhong_MP", BenhAnMatDayMat.XuatTuyet_TienPhong_MP == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("XuatTuyet_TienPhong_Text_MP", BenhAnMatDayMat.XuatTuyet_TienPhong_Text_MP));
            Command.Parameters.Add(new MDB.MDBParameter("Tyndall_TienPhong_MP", BenhAnMatDayMat.Tyndall_TienPhong_MP == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("Tyndall_TienPhong_Text_MP", BenhAnMatDayMat.Tyndall_TienPhong_Text_MP));
            Command.Parameters.Add(new MDB.MDBParameter("GocTienPhong_MP", BenhAnMatDayMat.GocTienPhong_MP));
            Command.Parameters.Add(new MDB.MDBParameter("TonThuongKhac_TienPhong_MP", BenhAnMatDayMat.TonThuongKhac_TienPhong_MP));
            Command.Parameters.Add(new MDB.MDBParameter("MongMat_MP", BenhAnMatDayMat.MongMat_MP == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("TanMachMongMat_MP", BenhAnMatDayMat.TanMachMongMat_MP == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("TanMachMongMat_Text_MP", BenhAnMatDayMat.TanMachMongMat_Text_MP));
            Command.Parameters.Add(new MDB.MDBParameter("HatKoeppiMongMat_MP", BenhAnMatDayMat.HatKoeppiMongMat_MP == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("HatKoeppiMongMat_Text_MP", BenhAnMatDayMat.HatKoeppiMongMat_Text_MP));
            Command.Parameters.Add(new MDB.MDBParameter("HatBussacaMongMat_MP", BenhAnMatDayMat.HatBussacaMongMat_MP == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("HatBussacaMongMat_Text_MP", BenhAnMatDayMat.HatBussacaMongMat_Text_MP));
            Command.Parameters.Add(new MDB.MDBParameter("KichThuoc_DongTu_MP", BenhAnMatDayMat.KichThuoc_DongTu_MP));
            Command.Parameters.Add(new MDB.MDBParameter("AnhDongTu_DongTu_MP", BenhAnMatDayMat.AnhDongTu_DongTu_MP));
            Command.Parameters.Add(new MDB.MDBParameter("TronMeo_DongTu_MP", BenhAnMatDayMat.TronMeo_DongTu_MP == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("Dinh_DongTu_MP", BenhAnMatDayMat.Dinh_DongTu_MP == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("ViTri_DongTu_MP", BenhAnMatDayMat.ViTri_DongTu_MP));
            Command.Parameters.Add(new MDB.MDBParameter("PXDT_MP", BenhAnMatDayMat.PXDT_MP == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("GianLiet_DongTu_MP", BenhAnMatDayMat.GianLiet_DongTu_MP == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("BenhLyKhac_DongTu_MP", BenhAnMatDayMat.BenhLyKhac_DongTu_MP));
            Command.Parameters.Add(new MDB.MDBParameter("TheThuyTinh_MP", BenhAnMatDayMat.TheThuyTinh_MP));
            Command.Parameters.Add(new MDB.MDBParameter("DiVat_TheThuyTinh_MP", BenhAnMatDayMat.DiVat_TheThuyTinh_MP == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("SaLech_TheThuyTinh_MP", BenhAnMatDayMat.SaLech_TheThuyTinh_MP == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("SaLechID_TheThuyTinh_MP", BenhAnMatDayMat.SaLechID_TheThuyTinh_MP == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("DinhSacTo_TheThuyTinh_MP", BenhAnMatDayMat.DinhSacTo_TheThuyTinh_MP == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("ViemMu_TheThuyTinh_MP", BenhAnMatDayMat.ViemMu_TheThuyTinh_MP == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("TonThuongKhac_TheThuyTinh_MP", BenhAnMatDayMat.TonThuongKhac_TheThuyTinh_MP));
            Command.Parameters.Add(new MDB.MDBParameter("DichKinh_MP", BenhAnMatDayMat.DichKinh_MP == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("DichKinh_MP_Text", BenhAnMatDayMat.DichKinh_MP_Text));
            Command.Parameters.Add(new MDB.MDBParameter("ViemMu_DichKinh_MP", BenhAnMatDayMat.ViemMu_DichKinh_MP == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("ViemMu_DichKinh_MP_Text", BenhAnMatDayMat.ViemMu_DichKinh_MP_Text));
            Command.Parameters.Add(new MDB.MDBParameter("XuatHuyet_DichKinh_MP", BenhAnMatDayMat.XuatHuyet_DichKinh_MP == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("ToChucHoa_DichKinh_MP", BenhAnMatDayMat.ToChucHoa_DichKinh_MP == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("Bong_DichKinh_MP", BenhAnMatDayMat.Bong_DichKinh_MP == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("TonThuongKhac_DichKinh_MP", BenhAnMatDayMat.TonThuongKhac_DichKinh_MP));
            Command.Parameters.Add(new MDB.MDBParameter("HeMach_VongMac_MP", BenhAnMatDayMat.HeMach_VongMac_MP == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("TacDM_VongMac_MP", BenhAnMatDayMat.TacDM_VongMac_MP));
            Command.Parameters.Add(new MDB.MDBParameter("TacTM_VongMac_MP", BenhAnMatDayMat.TacTM_VongMac_MP));
            Command.Parameters.Add(new MDB.MDBParameter("TacTM_Phu_VongMac_MP", BenhAnMatDayMat.TacTM_Phu_VongMac_MP == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("TacTM_ThieuMau_VongMac_MP", BenhAnMatDayMat.TacTM_ThieuMau_VongMac_MP == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("TacTM_HonHop_VongMac_MP", BenhAnMatDayMat.TacTM_HonHop_VongMac_MP == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("ViemMaoMach_VongMac_MP", BenhAnMatDayMat.ViemMaoMach_VongMac_MP == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("TanMach_VongMac_MP", BenhAnMatDayMat.TanMach_VongMac_MP == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("TanMachHacMac_MP", BenhAnMatDayMat.TanMachHacMac_MP));
            Command.Parameters.Add(new MDB.MDBParameter("DiaThi_VongMac_MP", BenhAnMatDayMat.DiaThi_VongMac_MP == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("DiaThiID_VongMac_MP", BenhAnMatDayMat.DiaThiID_VongMac_MP));
            Command.Parameters.Add(new MDB.MDBParameter("TanMachGai_VongMac_MP", BenhAnMatDayMat.TanMachGai_VongMac_MP == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("TanMachGaiID_VongMac_MP", BenhAnMatDayMat.TanMachGaiID_VongMac_MP));
            Command.Parameters.Add(new MDB.MDBParameter("HoangDiem_VongMac_MP", BenhAnMatDayMat.HoangDiem_VongMac_MP == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("HoangDiem_Phu_VongMac_MP", BenhAnMatDayMat.HoangDiem_Phu_VongMac_MP));
            Command.Parameters.Add(new MDB.MDBParameter("HoangDiem_Lo_VongMac_MP", BenhAnMatDayMat.HoangDiem_Lo_VongMac_MP));
            Command.Parameters.Add(new MDB.MDBParameter("HoangDiem_Lo_Do_VongMac_MP", BenhAnMatDayMat.HoangDiem_Lo_Do_VongMac_MP));
            Command.Parameters.Add(new MDB.MDBParameter("HoangDiem_Seo_VongMac_MP", BenhAnMatDayMat.HoangDiem_Seo_VongMac_MP == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("ThoaiHoa_VongMac_MP", BenhAnMatDayMat.ThoaiHoa_VongMac_MP));
            Command.Parameters.Add(new MDB.MDBParameter("ThoaiHoa_VongMac_MP_Text", BenhAnMatDayMat.ThoaiHoa_VongMac_MP_Text));
            Command.Parameters.Add(new MDB.MDBParameter("XuatHuyet_VongMac_MP", BenhAnMatDayMat.XuatHuyet_VongMac_MP));
            Command.Parameters.Add(new MDB.MDBParameter("XuatTiet_VongMac_MP", BenhAnMatDayMat.XuatTiet_VongMac_MP));
            Command.Parameters.Add(new MDB.MDBParameter("BongThanhDich_VongMac_MP", BenhAnMatDayMat.BongThanhDich_VongMac_MP));
            Command.Parameters.Add(new MDB.MDBParameter("OViemHacHac_MP", BenhAnMatDayMat.OViemHacHac_MP == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("OViemHacHac_MPText1", BenhAnMatDayMat.OViemHacHac_MPText1));
            Command.Parameters.Add(new MDB.MDBParameter("OViemHacHac_MPText2", BenhAnMatDayMat.OViemHacHac_MPText2));
            Command.Parameters.Add(new MDB.MDBParameter("BongVongMac_MP", BenhAnMatDayMat.BongVongMac_MP == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("BongVongMac_MP_Text", BenhAnMatDayMat.BongVongMac_MP_Text));
            Command.Parameters.Add(new MDB.MDBParameter("RachVongMac_MP", BenhAnMatDayMat.RachVongMac_MP == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("RachVongMac_MP_Text", BenhAnMatDayMat.RachVongMac_MP_Text));
            Command.Parameters.Add(new MDB.MDBParameter("RachVongMac_MP_Text1", BenhAnMatDayMat.RachVongMac_MP_Text1));
            Command.Parameters.Add(new MDB.MDBParameter("RachVongMac_MP_Text2", BenhAnMatDayMat.RachVongMac_MP_Text2));
            Command.Parameters.Add(new MDB.MDBParameter("RachVongMac_MP_Text3", BenhAnMatDayMat.RachVongMac_MP_Text3));
            Command.Parameters.Add(new MDB.MDBParameter("TonThuongPhoiHop_MP", BenhAnMatDayMat.TonThuongPhoiHop_MP));
            Command.Parameters.Add(new MDB.MDBParameter("BenhLyKhac_VongMac_MP", BenhAnMatDayMat.BenhLyKhac_VongMac_MP));
            Command.Parameters.Add(new MDB.MDBParameter("HocMat_MP", BenhAnMatDayMat.HocMat_MP == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("HocMat_Text_MP", BenhAnMatDayMat.HocMat_Text_MP));
            Command.Parameters.Add(new MDB.MDBParameter("VanNhan_MP", BenhAnMatDayMat.VanNhan_MP == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("VanNhan_Text_MP", BenhAnMatDayMat.VanNhan_Text_MP));
            Command.Parameters.Add(new MDB.MDBParameter("ChuaCoBieuHienBenhLy", BenhAnMatDayMat.ChuaCoBieuHienBenhLy));
            Command.Parameters.Add(new MDB.MDBParameter("BenhLy", BenhAnMatDayMat.BenhLy));
            Command.Parameters.Add(new MDB.MDBParameter("ChanDoanBenhChinh_LamSang", BenhAnMatDayMat.ChanDoanBenhChinh_LamSang));
            Command.Parameters.Add(new MDB.MDBParameter("ChanDoanBenhChinh_NguyenNhan", BenhAnMatDayMat.ChanDoanBenhChinh_NguyenNhan));
            Command.Parameters.Add(new MDB.MDBParameter("QuaTrinhDieuTri_NoiKhoa", BenhAnMatDayMat.QuaTrinhDieuTri_NoiKhoa));
            Command.Parameters.Add(new MDB.MDBParameter("PhauThuat", BenhAnMatDayMat.PhauThuat == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("ThuThuat", BenhAnMatDayMat.ThuThuat == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("ThiLucRaVienKhongKinhMPTongKet", BenhAnMatDayMat.ThiLucRaVienKhongKinhMPTongKet));
            Command.Parameters.Add(new MDB.MDBParameter("ThiLucRaVienKhongKinhMTTongKet", BenhAnMatDayMat.ThiLucRaVienKhongKinhMTTongKet));
            Command.Parameters.Add(new MDB.MDBParameter("ThiLucRaVienCoKinhMPTongKet", BenhAnMatDayMat.ThiLucRaVienCoKinhMPTongKet));
            Command.Parameters.Add(new MDB.MDBParameter("ThiLucRaVienCoKinhMTTongKet", BenhAnMatDayMat.ThiLucRaVienCoKinhMTTongKet));
            Command.Parameters.Add(new MDB.MDBParameter("NhanApRaVienMPTongKet", BenhAnMatDayMat.NhanApRaVienMPTongKet));
            Command.Parameters.Add(new MDB.MDBParameter("NhanApRaVienMTTongKet", BenhAnMatDayMat.NhanApRaVienMTTongKet));
            Command.Parameters.Add(new MDB.MDBParameter("HuongDieuTriTiep", BenhAnMatDayMat.HuongDieuTriTiep));
            Command.Parameters.Add(new MDB.MDBParameter("MiMat_MT", BenhAnMatDayMat.iMiMat_MT));
            Command.Parameters.Add(new MDB.MDBParameter("PhanUngTheMi_MT", BenhAnMatDayMat.PhanUngTheMi_MT == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("BenhLyKhac_MT", BenhAnMatDayMat.BenhLyKhac_MT));
            Command.Parameters.Add(new MDB.MDBParameter("KetMac_MT", BenhAnMatDayMat.KetMac_MT));
            Command.Parameters.Add(new MDB.MDBParameter("XuatHuyet_MT", BenhAnMatDayMat.XuatHuyet_MT == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("XuatHuyet_MT_Text", BenhAnMatDayMat.XuatHuyet_MT_Text));
            Command.Parameters.Add(new MDB.MDBParameter("SeoKetMac_MT", BenhAnMatDayMat.SeoKetMac_MT == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("SeoKetMac_MT_Text", BenhAnMatDayMat.SeoKetMac_MT_Text));
            Command.Parameters.Add(new MDB.MDBParameter("BenhLyKhac_KetMac_MT", BenhAnMatDayMat.BenhLyKhac_KetMac_MT));
            Command.Parameters.Add(new MDB.MDBParameter("GiacMac_Trong_MT", BenhAnMatDayMat.GiacMac_Trong_MT == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("GiacMac_Phu_MT", BenhAnMatDayMat.GiacMac_Phu_MT == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("GiacMac_Seo_MT", BenhAnMatDayMat.GiacMac_Seo_MT == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("TuaSauGiacMac_MoiCu_MT", BenhAnMatDayMat.iTuaSauGiacMac_MoiCu_MT));
            Command.Parameters.Add(new MDB.MDBParameter("TuaSauGiacMac_MoCuu_MT", BenhAnMatDayMat.TuaSauGiacMac_MoCuu_MT == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("TuaSauGiacMac_SacTo_MT", BenhAnMatDayMat.TuaSauGiacMac_SacTo_MT == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("ViTriTua_MT", BenhAnMatDayMat.ViTriTua_MT));
            Command.Parameters.Add(new MDB.MDBParameter("SeoGiacMac_MT", BenhAnMatDayMat.SeoGiacMac_MT == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("BenhLyKhac_GiacMac_MT", BenhAnMatDayMat.BenhLyKhac_GiacMac_MT));
            Command.Parameters.Add(new MDB.MDBParameter("CungMac_MT", BenhAnMatDayMat.iCungMac_MT));
            Command.Parameters.Add(new MDB.MDBParameter("BenhLyKhac_CungMac_MT", BenhAnMatDayMat.BenhLyKhac_CungMac_MT));
            Command.Parameters.Add(new MDB.MDBParameter("TienPhong_SauSach_MT", BenhAnMatDayMat.TienPhong_SauSach_MT == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("TienPhong_XepTienPhong_MT", BenhAnMatDayMat.TienPhong_XepTienPhong_MT == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("XuatHuyet_TienPhong_MT", BenhAnMatDayMat.XuatHuyet_TienPhong_MT == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("XuatHuyet_TienPhong_Text_MT", BenhAnMatDayMat.XuatHuyet_TienPhong_Text_MT));
            Command.Parameters.Add(new MDB.MDBParameter("XuatTuyet_TienPhong_MT", BenhAnMatDayMat.XuatTuyet_TienPhong_MT == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("XuatTuyet_TienPhong_Text_MT", BenhAnMatDayMat.XuatTuyet_TienPhong_Text_MT));
            Command.Parameters.Add(new MDB.MDBParameter("Tyndall_TienPhong_MT", BenhAnMatDayMat.Tyndall_TienPhong_MT == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("Tyndall_TienPhong_Text_MT", BenhAnMatDayMat.Tyndall_TienPhong_Text_MT));
            Command.Parameters.Add(new MDB.MDBParameter("GocTienPhong_MT", BenhAnMatDayMat.GocTienPhong_MT));
            Command.Parameters.Add(new MDB.MDBParameter("TonThuongKhac_TienPhong_MT", BenhAnMatDayMat.TonThuongKhac_TienPhong_MT));
            Command.Parameters.Add(new MDB.MDBParameter("MongMat_MT", BenhAnMatDayMat.MongMat_MT == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("TanMachMongMat_MT", BenhAnMatDayMat.TanMachMongMat_MT == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("TanMachMongMat_Text_MT", BenhAnMatDayMat.TanMachMongMat_Text_MT));
            Command.Parameters.Add(new MDB.MDBParameter("HatKoeppiMongMat_MT", BenhAnMatDayMat.HatKoeppiMongMat_MT == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("HatKoeppiMongMat_Text_MT", BenhAnMatDayMat.HatKoeppiMongMat_Text_MT));
            Command.Parameters.Add(new MDB.MDBParameter("HatBussacaMongMat_MT", BenhAnMatDayMat.HatBussacaMongMat_MT == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("HatBussacaMongMat_Text_MT", BenhAnMatDayMat.HatBussacaMongMat_Text_MT));
            Command.Parameters.Add(new MDB.MDBParameter("KichThuoc_DongTu_MT", BenhAnMatDayMat.KichThuoc_DongTu_MT));
            Command.Parameters.Add(new MDB.MDBParameter("AnhDongTu_DongTu_MT", BenhAnMatDayMat.AnhDongTu_DongTu_MT));
            Command.Parameters.Add(new MDB.MDBParameter("TronMeo_DongTu_MT", BenhAnMatDayMat.TronMeo_DongTu_MT == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("Dinh_DongTu_MT", BenhAnMatDayMat.Dinh_DongTu_MT == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("ViTri_DongTu_MT", BenhAnMatDayMat.ViTri_DongTu_MT));
            Command.Parameters.Add(new MDB.MDBParameter("PXDT_MT", BenhAnMatDayMat.PXDT_MT == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("GianLiet_DongTu_MT", BenhAnMatDayMat.GianLiet_DongTu_MT == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("BenhLyKhac_DongTu_MT", BenhAnMatDayMat.BenhLyKhac_DongTu_MT));
            Command.Parameters.Add(new MDB.MDBParameter("TheThuyTinh_MT", BenhAnMatDayMat.TheThuyTinh_MT));
            Command.Parameters.Add(new MDB.MDBParameter("DiVat_TheThuyTinh_MT", BenhAnMatDayMat.DiVat_TheThuyTinh_MT == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("SaLech_TheThuyTinh_MT", BenhAnMatDayMat.SaLech_TheThuyTinh_MT == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("SaLechID_TheThuyTinh_MT", BenhAnMatDayMat.SaLechID_TheThuyTinh_MT == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("DinhSacTo_TheThuyTinh_MT", BenhAnMatDayMat.DinhSacTo_TheThuyTinh_MT == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("ViemMu_TheThuyTinh_MT", BenhAnMatDayMat.ViemMu_TheThuyTinh_MT == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("TonThuongKhac_TheThuyTinh_MT", BenhAnMatDayMat.TonThuongKhac_TheThuyTinh_MT));
            Command.Parameters.Add(new MDB.MDBParameter("DichKinh_MT", BenhAnMatDayMat.DichKinh_MT == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("DichKinh_MT_Text", BenhAnMatDayMat.DichKinh_MT_Text));
            Command.Parameters.Add(new MDB.MDBParameter("ViemMu_DichKinh_MT", BenhAnMatDayMat.ViemMu_DichKinh_MT == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("ViemMu_DichKinh_MT_Text", BenhAnMatDayMat.ViemMu_DichKinh_MT_Text));
            Command.Parameters.Add(new MDB.MDBParameter("XuatHuyet_DichKinh_MT", BenhAnMatDayMat.XuatHuyet_DichKinh_MT == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("ToChucHoa_DichKinh_MT", BenhAnMatDayMat.ToChucHoa_DichKinh_MT == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("Bong_DichKinh_MT", BenhAnMatDayMat.Bong_DichKinh_MT == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("TonThuongKhac_DichKinh_MT", BenhAnMatDayMat.TonThuongKhac_DichKinh_MT));
            Command.Parameters.Add(new MDB.MDBParameter("HeMach_VongMac_MT", BenhAnMatDayMat.HeMach_VongMac_MT == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("TacDM_VongMac_MT", BenhAnMatDayMat.TacDM_VongMac_MT));
            Command.Parameters.Add(new MDB.MDBParameter("TacTM_VongMac_MT", BenhAnMatDayMat.TacTM_VongMac_MT));
            Command.Parameters.Add(new MDB.MDBParameter("TacTM_Phu_VongMac_MT", BenhAnMatDayMat.TacTM_Phu_VongMac_MT == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("TacTM_ThieuMau_VongMac_MT", BenhAnMatDayMat.TacTM_ThieuMau_VongMac_MT == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("TacTM_HonHop_VongMac_MT", BenhAnMatDayMat.TacTM_HonHop_VongMac_MT == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("ViemMaoMach_VongMac_MT", BenhAnMatDayMat.ViemMaoMach_VongMac_MT == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("TanMach_VongMac_MT", BenhAnMatDayMat.TanMach_VongMac_MT == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("TanMachHacMac_MT", BenhAnMatDayMat.TanMachHacMac_MT));
            Command.Parameters.Add(new MDB.MDBParameter("DiaThi_VongMac_MT", BenhAnMatDayMat.DiaThi_VongMac_MT == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("DiaThiID_VongMac_MT", BenhAnMatDayMat.DiaThiID_VongMac_MT));
            Command.Parameters.Add(new MDB.MDBParameter("TanMachGai_VongMac_MT", BenhAnMatDayMat.TanMachGai_VongMac_MT == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("TanMachGaiID_VongMac_MT", BenhAnMatDayMat.TanMachGaiID_VongMac_MT));
            Command.Parameters.Add(new MDB.MDBParameter("HoangDiem_VongMac_MT", BenhAnMatDayMat.HoangDiem_VongMac_MT == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("HoangDiem_Phu_VongMac_MT", BenhAnMatDayMat.HoangDiem_Phu_VongMac_MT));
            Command.Parameters.Add(new MDB.MDBParameter("HoangDiem_Lo_VongMac_MT", BenhAnMatDayMat.HoangDiem_Lo_VongMac_MT));
            Command.Parameters.Add(new MDB.MDBParameter("HoangDiem_Lo_Do_VongMac_MT", BenhAnMatDayMat.HoangDiem_Lo_Do_VongMac_MT));
            Command.Parameters.Add(new MDB.MDBParameter("HoangDiem_Seo_VongMac_MT", BenhAnMatDayMat.HoangDiem_Seo_VongMac_MT == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("ThoaiHoa_VongMac_MT", BenhAnMatDayMat.ThoaiHoa_VongMac_MT));
            Command.Parameters.Add(new MDB.MDBParameter("ThoaiHoa_VongMac_MT_Text", BenhAnMatDayMat.ThoaiHoa_VongMac_MT_Text));
            Command.Parameters.Add(new MDB.MDBParameter("XuatHuyet_VongMac_MT", BenhAnMatDayMat.XuatHuyet_VongMac_MT));
            Command.Parameters.Add(new MDB.MDBParameter("XuatTiet_VongMac_MT", BenhAnMatDayMat.XuatTiet_VongMac_MT));
            Command.Parameters.Add(new MDB.MDBParameter("BongThanhDich_VongMac_MT", BenhAnMatDayMat.BongThanhDich_VongMac_MT));
            Command.Parameters.Add(new MDB.MDBParameter("OViemHacHac_MT", BenhAnMatDayMat.OViemHacHac_MT == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("OViemHacHac_MTText1", BenhAnMatDayMat.OViemHacHac_MTText1 == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("OViemHacHac_MTText2", BenhAnMatDayMat.OViemHacHac_MTText2 == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("BongVongMac_MT", BenhAnMatDayMat.BongVongMac_MT == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("BongVongMac_MT_Text", BenhAnMatDayMat.BongVongMac_MT_Text));
            Command.Parameters.Add(new MDB.MDBParameter("RachVongMac_MT", BenhAnMatDayMat.RachVongMac_MT == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("RachVongMac_MT_Text", BenhAnMatDayMat.RachVongMac_MT_Text));
            Command.Parameters.Add(new MDB.MDBParameter("RachVongMac_MT_Text1", BenhAnMatDayMat.RachVongMac_MT_Text1));
            Command.Parameters.Add(new MDB.MDBParameter("RachVongMac_MT_Text2", BenhAnMatDayMat.RachVongMac_MT_Text2));
            Command.Parameters.Add(new MDB.MDBParameter("RachVongMac_MT_Text3", BenhAnMatDayMat.RachVongMac_MT_Text3));
            Command.Parameters.Add(new MDB.MDBParameter("TonThuongPhoiHop_MT", BenhAnMatDayMat.TonThuongPhoiHop_MT));
            Command.Parameters.Add(new MDB.MDBParameter("BenhLyKhac_VongMac_MT", BenhAnMatDayMat.BenhLyKhac_VongMac_MT));
            Command.Parameters.Add(new MDB.MDBParameter("HocMat_MT", BenhAnMatDayMat.HocMat_MT == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("HocMat_Text_MT", BenhAnMatDayMat.HocMat_Text_MT));
            Command.Parameters.Add(new MDB.MDBParameter("VanNhan_MT", BenhAnMatDayMat.VanNhan_MT == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("VanNhan_Text_MT", BenhAnMatDayMat.VanNhan_Text_MT));
            Command.Parameters.Add(new MDB.MDBParameter("ThayBenhLy", BenhAnMatDayMat.ThayBenhLy == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("ChuaThayBenhLy", BenhAnMatDayMat.ChuaThayBenhLy == true ? "1" : "0"));

            Command.Parameters.Add(new MDB.MDBParameter("VongMac_BenhLy_MP", BenhAnMatDayMat.VongMac_BenhLy_MP));
            Command.Parameters.Add(new MDB.MDBParameter("VongMac_BenhLy_MP_Text", BenhAnMatDayMat.VongMac_BenhLy_MP_Text));
            Command.Parameters.Add(new MDB.MDBParameter("VongMac_BenhLy_MT", BenhAnMatDayMat.VongMac_BenhLy_MT));
            Command.Parameters.Add(new MDB.MDBParameter("VongMac_BenhLy_MT_Text", BenhAnMatDayMat.VongMac_BenhLy_MT_Text));

            Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", BenhAnMatDayMat.MaQuanLy));
            int n = Command.ExecuteNonQuery(); // C#
            return n > 0 ? true : false;
        }
        public static bool Delete(MDB.MDBConnection MyConnection, BenhAnMatDayMat BenhAnMatDayMat)
        {
            string sql = @"DELETE FROM BenhAnMatDayMat 
                           WHERE MaQuanLy = :MaQuanLy";
            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
            Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", BenhAnMatDayMat.MaQuanLy));

            int n = Command.ExecuteNonQuery(); // C#
            return n > 0 ? true : false;
        }
    }
}
