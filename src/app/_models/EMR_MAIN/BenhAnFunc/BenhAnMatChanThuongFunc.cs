using System.Data;

namespace EMR_MAIN
{
    public class BenhAnMatChanThuongFunc
    {
        public static void WriteXml(MDB.MDBConnection MyConnection)
        {
            string sql =
                   @"
                  select  a.*,  CTScanner HoSo_CTScanner, SieuAm HoSo_SieuAm, XetNghiem HoSo_XetNghiem,  Khac HoSo_Khac,  Khac_Text HoSo_Khac_Text,  ToanBoHoSo HoSo_ToanBoHoSo, Mach DauSinhTon_Mach,  NhietDo DauSinhTon_NhietDo,  HuyetAp DauSinhTon_HuyetAp,  NhipTho DauSinhTon_NhipTho,  CanNang DauSinhTon_CanNang  
                  from BenhAnMatChanThuong a inner join thongtindieutri b on a.maquanly = b.maquanly
                  where rownum = 1
                    ";
            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
            MDB.MDBDataReader DataReader = Command.ExecuteReader();

            var DataTable = new DataTable { TableName = "BenhAnMatChanThuong" };
            DataTable.Load(DataReader as IDataReader);
            DataTable.WriteXml("rptBenhAnMatChanThuong.xml");
        }
        public static DataSet SelectDataSet(MDB.MDBConnection MyConnection, decimal MaQuanLy)
        {
            string sql =
                   @"
                  select  a.*,f.hovaten BacSyLamBenhAnHoVaTen ,c.hovaten BacSyDieuTriHoVaTen,d.hovaten NguoiGiaoHoSoHoVaTen,e.hovaten NguoiNhanHoSoHoVaTen, b.XQuang HoSo_XQuang,   b.CTScanner HoSo_CTScanner, b.SieuAm HoSo_SieuAm, b.XetNghiem HoSo_XetNghiem,  b.Khac HoSo_Khac,  b.Khac_Text HoSo_Khac_Text,  b.ToanBoHoSo HoSo_ToanBoHoSo, b.Mach DauSinhTon_Mach, b.NhietDo DauSinhTon_NhietDo,  b.HuyetAp DauSinhTon_HuyetAp,  b.NhipTho DauSinhTon_NhipTho,  b.CanNang DauSinhTon_CanNang  , b.ChieuCao DauSinhTon_ChieuCao, b.BMI DauSinhTon_BMI, b.NgayRaVien 
                 from BenhAnMatChanThuong a 
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
        public static BenhAnMatChanThuong Select(MDB.MDBConnection MyConnection, decimal MaQuanLy)
        {
            #region
            string sql =
                      @"select * 
                        from BenhAnMatChanThuong a
                        where MaQuanLy = :MaQuanLy";
            #endregion
            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
            Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", MaQuanLy));
            MDB.MDBDataReader DataReader = Command.ExecuteReader();
            var value = new BenhAnMatChanThuong();
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
                value.MiMat_MP = DataReader.GetInt("MiMat_MP");
                value.SupMi_MP = DataReader["SupMi_MP"].ToString() == "1" ? true : false;
                value.SupMi_MP_Text = DataReader["SupMi_MP_Text"].ToString();
                value.RachMi_MP = DataReader.GetInt("RachMi_MP");
                value.RachMi_Khau_MP = DataReader.GetInt("RachMi_Khau_MP");
                value.LeQuan_MP = DataReader.GetInt("LeQuan_MP");
                value.LeQuan_ID_MP = DataReader.GetInt("LeQuan_ID_MP");
                value.SeoMi_MP = DataReader["SeoMi_MP"].ToString() == "1" ? true : false;
                value.SeoMi_MP_Text = DataReader["SeoMi_MP_Text"].ToString();
                value.CacTonThuongKhac_MiMat_MP = DataReader["CacTonThuongKhac_MiMat_MP"].ToString();
                value.KetMac_MP = DataReader.GetInt("KetMac_MP");
                value.XuatHuyet_MP = DataReader["XuatHuyet_MP"].ToString() == "1" ? true : false;
                value.XuatHuyet_MP_Text = DataReader["XuatHuyet_MP_Text"].ToString();
                value.RachKetMac_MP = DataReader["RachKetMac_MP"].ToString() == "1" ? true : false;
                value.RachKetMac_MP_Text = DataReader["RachKetMac_MP_Text"].ToString();
                value.ThieuMau_MP = DataReader["ThieuMau_MP"].ToString() == "1" ? true : false;
                value.ThieuMau_MP_Text = DataReader["ThieuMau_MP_Text"].ToString();
                value.TonThuongKhac_KetMac_MP = DataReader["TonThuongKhac_KetMac_MP"].ToString();
                value.HinhVeMoTaTonThuongKVV_MP = DataReader["HinhVeMoTaTonThuongKVV_MP"].ToString();
                value.GiacMac_MP = DataReader.GetInt("GiacMac_MP");
                value.GiacMac_Seo_MP = DataReader["GiacMac_Seo_MP"].ToString() == "1" ? true : false;
                value.GiacMac_Seo_MP_Text = DataReader["GiacMac_Seo_MP_Text"].ToString();
                value.GiacMac_DiVat_MP = DataReader["GiacMac_DiVat_MP"].ToString() == "1" ? true : false;
                value.GiacMac_DiVat_MP_Text = DataReader["GiacMac_DiVat_MP_Text"].ToString();
                value.TuaSauGiacMac_MP = DataReader.GetInt("TuaSauGiacMac_MP");
                value.TuaSauGiacMac_ID_MP = DataReader.GetInt("TuaSauGiacMac_ID_MP");
                value.RachGiacMac_MP = DataReader["RachGiacMac_MP"].ToString() == "1" ? true : false;
                value.RachGiacMac_MP_Text = DataReader["RachGiacMac_MP_Text"].ToString();
                value.RachGiacMac_MP_Text2 = DataReader["RachGiacMac_MP_Text2"].ToString();
                value.RachGiacMac_ID_MP = DataReader.GetInt("RachGiacMac_ID_MP");
                value.DaKhauGiacMac_MP = DataReader["DaKhauGiacMac_MP"].ToString() == "1" ? true : false;
                value.DungGiaiPhauGiacMac_MP = DataReader.GetInt("DungGiaiPhauGiacMac_MP");
                value.TonThuongKhac_GiacMac_MP = DataReader["TonThuongKhac_GiacMac_MP"].ToString();
                value.CungMac_MP = DataReader.GetInt("CungMac_MP");
                value.RachCungMac_MP = DataReader["RachCungMac_MP"].ToString() == "1" ? true : false;
                value.RachCungMac_MP_Text = DataReader["RachCungMac_MP_Text"].ToString();
                value.RachCungMac_MP_Text2 = DataReader["RachCungMac_MP_Text2"].ToString();
                value.DaKhauCungMac_MP = DataReader.GetInt("DaKhauCungMac_MP");
                value.KetToChucCungMac_MP = DataReader["KetToChucCungMac_MP"].ToString() == "1" ? true : false;
                value.TonThuongKhac_CungMac_MP = DataReader["TonThuongKhac_CungMac_MP"].ToString();
                value.TienPhong_MP = DataReader.GetInt("TienPhong_MP");
                value.XuatTiet_TienPhong_MP = DataReader["XuatTiet_TienPhong_MP"].ToString() == "1" ? true : false;
                value.XuatTiet_TienPhong_Text_MP = DataReader["XuatTiet_TienPhong_Text_MP"].ToString();
                value.DiVat_TienPhong_MP = DataReader["DiVat_TienPhong_MP"].ToString() == "1" ? true : false;
                value.DiVat_TienPhong_Text_MP = DataReader["DiVat_TienPhong_Text_MP"].ToString();
                value.TonThuongKhac_TienPhong_MP = DataReader["TonThuongKhac_TienPhong_MP"].ToString();
                value.MongMat_MP = DataReader.GetInt("MongMat_MP");
                value.DutChanMongMat_MP = DataReader["DutChanMongMat_MP"].ToString() == "1" ? true : false;
                value.DutChanMongMat_Text_MP = DataReader["DutChanMongMat_Text_MP"].ToString();
                value.MatMongMat_MP = DataReader["MatMongMat_MP"].ToString() == "1" ? true : false;
                value.MatMongMat_Text_MP = DataReader["MatMongMat_Text_MP"].ToString();
                value.ThungMongMat_MP = DataReader["ThungMongMat_MP"].ToString() == "1" ? true : false;
                value.ThungMongMat_Text_MP = DataReader["ThungMongMat_Text_MP"].ToString();
                value.KichThuoc_DongTu_MP = DataReader["KichThuoc_DongTu_MP"].ToString();
                value.PXDT_MP = DataReader.GetInt("PXDT_MP");
                value.TronMeo_DongTu_MP = DataReader.GetInt("TronMeo_DongTu_MP");
                value.Dinh_DongTu_MP = DataReader["Dinh_DongTu_MP"].ToString() == "1" ? true : false;
                value.ViTri_DongTu_MP = DataReader["ViTri_DongTu_MP"].ToString();
                value.GianLiet_DongTu_MP = DataReader["GianLiet_DongTu_MP"].ToString() == "1" ? true : false;
                value.AnhDongTu_MP = DataReader["AnhDongTu_MP"].ToString();
                value.KhongQuanSatDuoc_ADT_MP = DataReader["KhongQuanSatDuoc_ADT_MP"].ToString() == "1" ? true : false;
                value.TheThuyTinh_MP = DataReader.GetInt("TheThuyTinh_MP");
                value.DiVat_TheThuyTinh_MP = DataReader["DiVat_TheThuyTinh_MP"].ToString() == "1" ? true : false;
                value.SaLech_TheThuyTinh_MP = DataReader["SaLech_TheThuyTinh_MP"].ToString() == "1" ? true : false;
                value.SaLechID_TheThuyTinh_MP = DataReader.GetInt("SaLechID_TheThuyTinh_MP");
                value.ViemMu_TheThuyTinh_MP = DataReader["ViemMu_TheThuyTinh_MP"].ToString() == "1" ? true : false;
                value.DaDatIOL_TheThuyTinh_MP = DataReader["DaDatIOL_TheThuyTinh_MP"].ToString() == "1" ? true : false;
                value.DaDatIOL_TheThuyTinh_Text_MP = DataReader["DaDatIOL_TheThuyTinh_Text_MP"].ToString();
                value.TonThuongKhac_TheThuyTinh_MP = DataReader["TonThuongKhac_TheThuyTinh_MP"].ToString();
                value.Duc_DichKinh_MP = DataReader["Duc_DichKinh_MP"].ToString() == "1" ? true : false;
                value.ViemMu_DichKinh_MP = DataReader["ViemMu_DichKinh_MP"].ToString() == "1" ? true : false;
                value.XuatHuyet_DichKinh_MP = DataReader["XuatHuyet_DichKinh_MP"].ToString() == "1" ? true : false;
                value.ToChucHoa_DichKinh_MP = DataReader["ToChucHoa_DichKinh_MP"].ToString() == "1" ? true : false;
                value.Bong_DichKinh_MP = DataReader["Bong_DichKinh_MP"].ToString() == "1" ? true : false;
                value.DiVat_DichKinh_MP = DataReader["DiVat_DichKinh_MP"].ToString() == "1" ? true : false;
                value.TonThuongKhac_DichKinh_MP = DataReader["TonThuongKhac_DichKinh_MP"].ToString();
                value.HeMach_DichKinh_MP = DataReader["HeMach_DichKinh_MP"].ToString();
                value.DiaThi_DichKinh_MP = DataReader["DiaThi_DichKinh_MP"].ToString();
                value.Phu_VongMac_MP = DataReader["Phu_VongMac_MP"].ToString() == "1" ? true : false;
                value.Phu_VongMac_Text_MP = DataReader["Phu_VongMac_Text_MP"].ToString();
                value.XuatHuyet_VongMac_MP = DataReader["XuatHuyet_VongMac_MP"].ToString() == "1" ? true : false;
                value.XuatHuyet_VongMac_Text_MP = DataReader["XuatHuyet_VongMac_Text_MP"].ToString();
                value.Bong_VongMac_MP = DataReader.GetInt("Bong_VongMac_MP");
                value.Bong_VongMac_Text_MP = DataReader["Bong_VongMac_Text_MP"].ToString();
                value.Rach_VongMac_MP = DataReader.GetInt("Rach_VongMac_MP");
                value.Rach_VongMac_Text_MP = DataReader["Rach_VongMac_Text_MP"].ToString();
                value.ViTriRach_VongMac_Text_MP = DataReader["ViTriRach_VongMac_Text_MP"].ToString();
                value.HinhThaiRach_VongMac_Text_MP = DataReader["HinhThaiRach_VongMac_Text_MP"].ToString();
                value.DiVat_VongMac_MP = DataReader["DiVat_VongMac_MP"].ToString() == "1" ? true : false;
                value.DiVat_VongMac_Text_MP = DataReader["DiVat_VongMac_Text_MP"].ToString();
                value.DiVat_VongMac_Text2_MP = DataReader["DiVat_VongMac_Text2_MP"].ToString();
                value.TonThuongKhac_VongMac_MP = DataReader["TonThuongKhac_VongMac_MP"].ToString();
                value.HocMat_MP = DataReader.GetInt("HocMat_MP");
                value.HocMat_Text_MP = DataReader["HocMat_Text_MP"].ToString();
                value.DiVat_HocMat_MP = DataReader["DiVat_HocMat_MP"].ToString() == "1" ? true : false;
                value.DiVat_HocMat_Text_MP = DataReader["DiVat_HocMat_Text_MP"].ToString();
                value.VanNhan_MP = DataReader.GetInt("VanNhan_MP");
                value.VanNhan_Text_MP = DataReader["VanNhan_Text_MP"].ToString();
                value.NhanCau_MP = DataReader.GetInt("NhanCau_MP");
                value.NhanCau_Text_MP = DataReader["NhanCau_Text_MP"].ToString();
                value.MiMat_MT = DataReader.GetInt("MiMat_MT");
                value.SupMi_MT = DataReader["SupMi_MT"].ToString() == "1" ? true : false;
                value.SupMi_MT_Text = DataReader["SupMi_MT_Text"].ToString();
                value.RachMi_MT = DataReader.GetInt("RachMi_MT");
                value.RachMi_Khau_MT = DataReader.GetInt("RachMi_Khau_MT");
                value.LeQuan_MT = DataReader.GetInt("LeQuan_MT");
                value.LeQuan_ID_MT = DataReader.GetInt("LeQuan_ID_MT");
                value.SeoMi_MT = DataReader["SeoMi_MT"].ToString() == "1" ? true : false;
                value.SeoMi_MT_Text = DataReader["SeoMi_MT_Text"].ToString();
                value.CacTonThuongKhac_MiMat_MT = DataReader["CacTonThuongKhac_MiMat_MT"].ToString();
                value.KetMac_MT = DataReader.GetInt("KetMac_MT");
                value.XuatHuyet_MT = DataReader["XuatHuyet_MT"].ToString() == "1" ? true : false;
                value.XuatHuyet_MT_Text = DataReader["XuatHuyet_MT_Text"].ToString();
                value.RachKetMac_MT = DataReader["RachKetMac_MT"].ToString() == "1" ? true : false;
                value.RachKetMac_MT_Text = DataReader["RachKetMac_MT_Text"].ToString();
                value.ThieuMau_MT = DataReader["ThieuMau_MT"].ToString() == "1" ? true : false;
                value.ThieuMau_MT_Text = DataReader["ThieuMau_MT_Text"].ToString();
                value.TonThuongKhac_KetMac_MT = DataReader["TonThuongKhac_KetMac_MT"].ToString();
                value.HinhVeMoTaTonThuongKVV_MT = DataReader["HinhVeMoTaTonThuongKVV_MT"].ToString();
                value.GiacMac_MT = DataReader.GetInt("GiacMac_MT");
                value.GiacMac_Seo_MT = DataReader["GiacMac_Seo_MT"].ToString() == "1" ? true : false;
                value.GiacMac_Seo_MT_Text = DataReader["GiacMac_Seo_MT_Text"].ToString();
                value.GiacMac_DiVat_MT = DataReader["GiacMac_DiVat_MT"].ToString() == "1" ? true : false;
                value.GiacMac_DiVat_MT_Text = DataReader["GiacMac_DiVat_MT_Text"].ToString();
                value.TuaSauGiacMac_MT = DataReader.GetInt("TuaSauGiacMac_MT");
                value.TuaSauGiacMac_ID_MT = DataReader.GetInt("TuaSauGiacMac_ID_MT");
                value.RachGiacMac_MT = DataReader["RachGiacMac_MT"].ToString() == "1" ? true : false;
                value.RachGiacMac_MT_Text = DataReader["RachGiacMac_MT_Text"].ToString();
                value.RachGiacMac_MT_Text2 = DataReader["RachGiacMac_MT_Text2"].ToString();
                value.RachGiacMac_ID_MT = DataReader.GetInt("RachGiacMac_ID_MT");
                value.DaKhauGiacMac_MT = DataReader["DaKhauGiacMac_MT"].ToString() == "1" ? true : false;
                value.DungGiaiPhauGiacMac_MT = DataReader.GetInt("DungGiaiPhauGiacMac_MT");
                value.TonThuongKhac_GiacMac_MT = DataReader["TonThuongKhac_GiacMac_MT"].ToString();
                value.CungMac_MT = DataReader.GetInt("CungMac_MT");
                value.RachCungMac_MT = DataReader["RachCungMac_MT"].ToString() == "1" ? true : false;
                value.RachCungMac_MT_Text = DataReader["RachCungMac_MT_Text"].ToString();
                value.RachCungMac_MT_Text2 = DataReader["RachCungMac_MT_Text2"].ToString();
                value.DaKhauCungMac_MT = DataReader.GetInt("DaKhauCungMac_MT");
                value.KetToChucCungMac_MT = DataReader["KetToChucCungMac_MT"].ToString() == "1" ? true : false;
                value.TonThuongKhac_CungMac_MT = DataReader["TonThuongKhac_CungMac_MT"].ToString();
                value.TienPhong_MT = DataReader.GetInt("TienPhong_MT");
                value.XuatTiet_TienPhong_MT = DataReader["XuatTiet_TienPhong_MT"].ToString() == "1" ? true : false;
                value.XuatTiet_TienPhong_Text_MT = DataReader["XuatTiet_TienPhong_Text_MT"].ToString();
                value.DiVat_TienPhong_MT = DataReader["DiVat_TienPhong_MT"].ToString() == "1" ? true : false;
                value.DiVat_TienPhong_Text_MT = DataReader["DiVat_TienPhong_Text_MT"].ToString();
                value.TonThuongKhac_TienPhong_MT = DataReader["TonThuongKhac_TienPhong_MT"].ToString();
                value.MongMat_MT = DataReader.GetInt("MongMat_MT");
                value.DutChanMongMat_MT = DataReader["DutChanMongMat_MT"].ToString() == "1" ? true : false;
                value.DutChanMongMat_Text_MT = DataReader["DutChanMongMat_Text_MT"].ToString();
                value.MatMongMat_MT = DataReader["MatMongMat_MT"].ToString() == "1" ? true : false;
                value.MatMongMat_Text_MT = DataReader["MatMongMat_Text_MT"].ToString();
                value.ThungMongMat_MT = DataReader["ThungMongMat_MT"].ToString() == "1" ? true : false;
                value.ThungMongMat_Text_MT = DataReader["ThungMongMat_Text_MT"].ToString();
                value.KichThuoc_DongTu_MT = DataReader["KichThuoc_DongTu_MT"].ToString();
                value.PXDT_MT = DataReader.GetInt("PXDT_MT");
                value.TronMeo_DongTu_MT = DataReader.GetInt("TronMeo_DongTu_MT");
                value.Dinh_DongTu_MT = DataReader["Dinh_DongTu_MT"].ToString() == "1" ? true : false;
                value.ViTri_DongTu_MT = DataReader["ViTri_DongTu_MT"].ToString();
                value.GianLiet_DongTu_MT = DataReader["GianLiet_DongTu_MT"].ToString() == "1" ? true : false;
                value.AnhDongTu_MT = DataReader["AnhDongTu_MT"].ToString();
                value.KhongQuanSatDuoc_ADT_MT = DataReader["KhongQuanSatDuoc_ADT_MT"].ToString() == "1" ? true : false;
                value.TheThuyTinh_MT = DataReader.GetInt("TheThuyTinh_MT");
                value.DiVat_TheThuyTinh_MT = DataReader["DiVat_TheThuyTinh_MT"].ToString() == "1" ? true : false;
                value.SaLech_TheThuyTinh_MT = DataReader["SaLech_TheThuyTinh_MT"].ToString() == "1" ? true : false;
                value.SaLechID_TheThuyTinh_MT = DataReader.GetInt("SaLechID_TheThuyTinh_MT");
                value.ViemMu_TheThuyTinh_MT = DataReader["ViemMu_TheThuyTinh_MT"].ToString() == "1" ? true : false;
                value.DaDatIOL_TheThuyTinh_MT = DataReader["DaDatIOL_TheThuyTinh_MT"].ToString() == "1" ? true : false;
                value.DaDatIOL_TheThuyTinh_Text_MT = DataReader["DaDatIOL_TheThuyTinh_Text_MT"].ToString();
                value.TonThuongKhac_TheThuyTinh_MT = DataReader["TonThuongKhac_TheThuyTinh_MT"].ToString();
                value.Duc_DichKinh_MT = DataReader["Duc_DichKinh_MT"].ToString() == "1" ? true : false;
                value.ViemMu_DichKinh_MT = DataReader["ViemMu_DichKinh_MT"].ToString() == "1" ? true : false;
                value.XuatHuyet_DichKinh_MT = DataReader["XuatHuyet_DichKinh_MT"].ToString() == "1" ? true : false;
                value.ToChucHoa_DichKinh_MT = DataReader["ToChucHoa_DichKinh_MT"].ToString() == "1" ? true : false;
                value.Bong_DichKinh_MT = DataReader["Bong_DichKinh_MT"].ToString() == "1" ? true : false;
                value.DiVat_DichKinh_MT = DataReader["DiVat_DichKinh_MT"].ToString() == "1" ? true : false;
                value.TonThuongKhac_DichKinh_MT = DataReader["TonThuongKhac_DichKinh_MT"].ToString();
                value.HeMach_DichKinh_MT = DataReader["HeMach_DichKinh_MT"].ToString();
                value.DiaThi_DichKinh_MT = DataReader["DiaThi_DichKinh_MT"].ToString();
                value.Phu_VongMac_MT = DataReader["Phu_VongMac_MT"].ToString() == "1" ? true : false;
                value.Phu_VongMac_Text_MT = DataReader["Phu_VongMac_Text_MT"].ToString();
                value.XuatHuyet_VongMac_MT = DataReader["XuatHuyet_VongMac_MT"].ToString() == "1" ? true : false;
                value.XuatHuyet_VongMac_Text_MT = DataReader["XuatHuyet_VongMac_Text_MT"].ToString();
                value.Bong_VongMac_MT = DataReader.GetInt("Bong_VongMac_MT");
                value.Bong_VongMac_Text_MT = DataReader["Bong_VongMac_Text_MT"].ToString();
                value.Rach_VongMac_MT = DataReader.GetInt("Rach_VongMac_MT");
                value.Rach_VongMac_Text_MT = DataReader["Rach_VongMac_Text_MT"].ToString();
                value.ViTriRach_VongMac_Text_MT = DataReader["ViTriRach_VongMac_Text_MT"].ToString();
                value.HinhThaiRach_VongMac_Text_MT = DataReader["HinhThaiRach_VongMac_Text_MT"].ToString();
                value.DiVat_VongMac_MT = DataReader["DiVat_VongMac_MT"].ToString() == "1" ? true : false;
                value.DiVat_VongMac_Text_MT = DataReader["DiVat_VongMac_Text_MT"].ToString();
                value.DiVat_VongMac_Text2_MT = DataReader["DiVat_VongMac_Text2_MT"].ToString();
                value.TonThuongKhac_VongMac_MT = DataReader["TonThuongKhac_VongMac_MT"].ToString();
                value.HocMat_MT = DataReader.GetInt("HocMat_MT");
                value.HocMat_Text_MT = DataReader["HocMat_Text_MT"].ToString();
                value.DiVat_HocMat_MT = DataReader["DiVat_HocMat_MT"].ToString() == "1" ? true : false;
                value.DiVat_HocMat_Text_MT = DataReader["DiVat_HocMat_Text_MT"].ToString();
                value.VanNhan_MT = DataReader.GetInt("VanNhan_MT");
                value.VanNhan_Text_MT = DataReader["VanNhan_Text_MT"].ToString();
                value.NhanCau_MT = DataReader.GetInt("NhanCau_MT");
                value.NhanCau_Text_MT = DataReader["NhanCau_Text_MT"].ToString();
                value.HinhVe_VongMac_MP = DataReader["HinhVe_VongMac_MP"].ToString();
                value.HinhVe_VongMac_MT = DataReader["HinhVe_VongMac_MT"].ToString();
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
                value.MaSoKyTen = DataReader["masokyten"].ToString();
                value.MaSoKyTen_KB = DataReader["masokyten_kb"].ToString();
                value.MaSoKyTen_TK = DataReader["masokyten_tk"].ToString();
                value.TuaMoi_MP = DataReader["TuaMoi_MP"].ToString().Equals("1") ? true:false;
                value.TuaMoi_MP_Text = DataReader["TuaMoi_MP_Text"].ToString();
                value.TuaMoi_MT = DataReader["TuaMoi_MT"].ToString().Equals("1") ? true : false;
                value.TuaMoi_MT_Text = DataReader["TuaMoi_MT_Text"].ToString();

                value.TuaCu_MP = DataReader["TuaCu_MP"].ToString().Equals("1") ? true : false;
                value.TuaCu_MP_Text = DataReader["TuaCu_MP_Text"].ToString();
                value.TuaCu_MT = DataReader["TuaCu_MT"].ToString().Equals("1") ? true : false;
                value.TuaCu_MT_Text = DataReader["TuaCu_MT_Text"].ToString();

                value.TienPhongMP_Sau_Text = DataReader["TienPhongMP_Sau_Text"].ToString();
                value.TienPhongMP_Mu_Text = DataReader["TienPhongMP_Mu_Text"].ToString();
                value.TienPhongMP_XuatTiet_Text = DataReader["TienPhongMP_XuatTiet_Text"].ToString();
                value.TienPhongMP_Tydall_Text = DataReader["TienPhongMP_Tydall_Text"].ToString();
                value.TienPhongMT_Sau_Text = DataReader["TienPhongMT_Sau_Text"].ToString();
                value.TienPhongMT_Mu_Text = DataReader["TienPhongMT_Mu_Text"].ToString();
                value.TienPhongMT_XuatTiet_Text = DataReader["TienPhongMT_XuatTiet_Text"].ToString();
                value.TienPhongMT_Tydall_Text = DataReader["TienPhongMT_Tydall_Text"].ToString();

                value.Trong_DichKinh_MP = DataReader["Trong_DichKinh_MP"].ToString().Equals("1") ? true : false;
                value.Duc_DichKinh_MP_Text = DataReader["Duc_DichKinh_MP_Text"].ToString();
                value.XuatHuyet_DichKinh_MP_Text = DataReader["XuatHuyet_DichKinh_MP_Text"].ToString();
                value.Trong_DichKinh_MT = DataReader["Trong_DichKinh_MT"].ToString().Equals("1") ? true : false;
                value.Duc_DichKinh_MT_Text = DataReader["Duc_DichKinh_MT_Text"].ToString();
                value.XuatHuyet_DichKinh_MT_Text = DataReader["XuatHuyet_DichKinh_MT_Text"].ToString();
                value.VongMac_BenhLy_MP = DataReader.GetInt("VongMac_BenhLy_MP");
                value.VongMac_BenhLy_MT = DataReader.GetInt("VongMac_BenhLy_MT");
                value.VoXuong_HocMat_MP = DataReader["VoXuong_HocMat_MP"].ToString().Equals("1") ? true : false;
                value.VoXuong_HocMat_Text_MP = DataReader["VoXuong_HocMat_Text_MP"].ToString();
                value.VoXuong_HocMat_MT = DataReader["VoXuong_HocMat_MT"].ToString().Equals("1") ? true : false;
                value.VoXuong_HocMat_Text_MT = DataReader["VoXuong_HocMat_Text_MT"].ToString();
                value.ViTri_Khau_MP = DataReader["ViTri_Khau_MP"].ToString();
                value.ViTri_Khau_MT = DataReader["ViTri_Khau_MT"].ToString();
                value.ThayBenhLy = DataReader["ThayBenhLy"].ToString().Equals("1") ? true : false;
                value.ChuaThayBenhLy = DataReader["ChuaThayBenhLy"].ToString().Equals("1") ? true : false;
            }
            return value;
        }

        public static bool InsertOrUpdate(MDB.MDBConnection MyConnection, BenhAnMatChanThuong BenhAnMatChanThuong)
        {
            string sql =
                      @"select MaQuanLy 
                        from BenhAnMatChanThuong
                        where MaQuanLy = :MaQuanLy";
            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
            Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", BenhAnMatChanThuong.MaQuanLy));
            MDB.MDBDataReader DataReader = Command.ExecuteReader();
            int rowCount = 0;
            while (DataReader.Read()) rowCount++;
            if (rowCount == 1) return Update(MyConnection, BenhAnMatChanThuong);
            sql = @"
                   INSERT INTO BenhAnMatChanThuong (MaQuanLy, LyDoVaoVien, VaoNgayThu, QuaTrinhBenhLy, TienSuBenhBanThan, TienSuBenhGiaDinh, ToanThan, TuanHoan, HoHap, TieuHoa, ThanTietNieuSinhDuc, ThanKinh, CoXuongKhop, TaiMuiHong, RangHamMat, Mat, Khac_CacCoQuan, CacXetNghiemCanLamSangCanLam, TomTatBenhAn, BenhChinh, BenhKemTheo, PhanBiet, TienLuong, HuongDieuTri, NgayKhamBenh, BacSyLamBenhAn, QuaTrinhBenhLyVaDienBien, TomTatKetQuaXetNghiem, PhuongPhapDieuTri, TinhTrangNguoiBenhRaVien, HuongDieuTriVaCacCheDoTiepTheo, NguoiNhanHoSo, NguoiGiaoHoSo, NgayTongKet, BacSyDieuTri, DiUng, DiUng_Text, MaTuy, MaTuy_Text, RuouBia, RuouBia_Text, ThuocLa, ThuocLa_Text, ThuocLao, ThuocLao_Text, Khac_DacDiemLienQuanBenh, Khac_DacDiemLienQuanBenh_Text, ThiLucKhiVaoVien_KhongKinh_MP, ThiLucKhiVaoVien_KhongKinh_MT, ThiLucKhiVaoVien_CoKinh_MP, ThiLucKhiVaoVien_CoKinh_MT, NhanApVaoVien_MT, NhanApVaoVien_MP, ThiTruong_MP, ThiTruong_MT, MiMat_MP, SupMi_MP, SupMi_MP_Text, RachMi_MP, RachMi_Khau_MP, LeQuan_MP, LeQuan_ID_MP, SeoMi_MP, SeoMi_MP_Text, CacTonThuongKhac_MiMat_MP, KetMac_MP, XuatHuyet_MP, XuatHuyet_MP_Text, RachKetMac_MP, RachKetMac_MP_Text, ThieuMau_MP, ThieuMau_MP_Text, TonThuongKhac_KetMac_MP, HinhVeMoTaTonThuongKVV_MP, GiacMac_MP, GiacMac_Seo_MP, GiacMac_Seo_MP_Text, GiacMac_DiVat_MP, GiacMac_DiVat_MP_Text, TuaSauGiacMac_MP, TuaSauGiacMac_ID_MP, RachGiacMac_MP, RachGiacMac_MP_Text, RachGiacMac_MP_Text2, RachGiacMac_ID_MP, DaKhauGiacMac_MP, DungGiaiPhauGiacMac_MP, TonThuongKhac_GiacMac_MP, CungMac_MP, RachCungMac_MP, RachCungMac_MP_Text, RachCungMac_MP_Text2, DaKhauCungMac_MP, KetToChucCungMac_MP, TonThuongKhac_CungMac_MP, TienPhong_MP, XuatTiet_TienPhong_MP, XuatTiet_TienPhong_Text_MP, DiVat_TienPhong_MP, DiVat_TienPhong_Text_MP, TonThuongKhac_TienPhong_MP, MongMat_MP, DutChanMongMat_MP, DutChanMongMat_Text_MP, MatMongMat_MP, MatMongMat_Text_MP, ThungMongMat_MP, ThungMongMat_Text_MP, KichThuoc_DongTu_MP, PXDT_MP, TronMeo_DongTu_MP, Dinh_DongTu_MP, ViTri_DongTu_MP, GianLiet_DongTu_MP, AnhDongTu_MP, KhongQuanSatDuoc_ADT_MP, TheThuyTinh_MP, DiVat_TheThuyTinh_MP, SaLech_TheThuyTinh_MP, SaLechID_TheThuyTinh_MP, ViemMu_TheThuyTinh_MP, DaDatIOL_TheThuyTinh_MP, DaDatIOL_TheThuyTinh_Text_MP, TonThuongKhac_TheThuyTinh_MP, Duc_DichKinh_MP, ViemMu_DichKinh_MP, XuatHuyet_DichKinh_MP, ToChucHoa_DichKinh_MP, Bong_DichKinh_MP, DiVat_DichKinh_MP, TonThuongKhac_DichKinh_MP, HeMach_DichKinh_MP, DiaThi_DichKinh_MP, Phu_VongMac_MP, Phu_VongMac_Text_MP, XuatHuyet_VongMac_MP, XuatHuyet_VongMac_Text_MP, Bong_VongMac_MP, Bong_VongMac_Text_MP, Rach_VongMac_MP, Rach_VongMac_Text_MP, ViTriRach_VongMac_Text_MP, HinhThaiRach_VongMac_Text_MP, DiVat_VongMac_MP, DiVat_VongMac_Text_MP, DiVat_VongMac_Text2_MP, TonThuongKhac_VongMac_MP, HocMat_MP, HocMat_Text_MP, DiVat_HocMat_MP, DiVat_HocMat_Text_MP, VanNhan_MP, VanNhan_Text_MP, NhanCau_MP, NhanCau_Text_MP, MiMat_MT, SupMi_MT, SupMi_MT_Text, RachMi_MT, RachMi_Khau_MT, LeQuan_MT, LeQuan_ID_MT, SeoMi_MT, SeoMi_MT_Text, CacTonThuongKhac_MiMat_MT, KetMac_MT, XuatHuyet_MT, XuatHuyet_MT_Text, RachKetMac_MT, RachKetMac_MT_Text, ThieuMau_MT, ThieuMau_MT_Text, TonThuongKhac_KetMac_MT, HinhVeMoTaTonThuongKVV_MT, GiacMac_MT, GiacMac_Seo_MT, GiacMac_Seo_MT_Text, GiacMac_DiVat_MT, GiacMac_DiVat_MT_Text, TuaSauGiacMac_MT, TuaSauGiacMac_ID_MT, RachGiacMac_MT, RachGiacMac_MT_Text, RachGiacMac_MT_Text2, RachGiacMac_ID_MT, DaKhauGiacMac_MT, DungGiaiPhauGiacMac_MT, TonThuongKhac_GiacMac_MT, CungMac_MT, RachCungMac_MT, RachCungMac_MT_Text, RachCungMac_MT_Text2, DaKhauCungMac_MT, KetToChucCungMac_MT, TonThuongKhac_CungMac_MT, TienPhong_MT, XuatTiet_TienPhong_MT, XuatTiet_TienPhong_Text_MT, DiVat_TienPhong_MT, DiVat_TienPhong_Text_MT, TonThuongKhac_TienPhong_MT, MongMat_MT, DutChanMongMat_MT, DutChanMongMat_Text_MT, MatMongMat_MT, MatMongMat_Text_MT, ThungMongMat_MT, ThungMongMat_Text_MT, KichThuoc_DongTu_MT, PXDT_MT, TronMeo_DongTu_MT, Dinh_DongTu_MT, ViTri_DongTu_MT, GianLiet_DongTu_MT, AnhDongTu_MT, KhongQuanSatDuoc_ADT_MT, TheThuyTinh_MT, DiVat_TheThuyTinh_MT, SaLech_TheThuyTinh_MT, SaLechID_TheThuyTinh_MT, ViemMu_TheThuyTinh_MT, DaDatIOL_TheThuyTinh_MT, DaDatIOL_TheThuyTinh_Text_MT, TonThuongKhac_TheThuyTinh_MT, Duc_DichKinh_MT, ViemMu_DichKinh_MT, XuatHuyet_DichKinh_MT, ToChucHoa_DichKinh_MT, Bong_DichKinh_MT, DiVat_DichKinh_MT, TonThuongKhac_DichKinh_MT, HeMach_DichKinh_MT, DiaThi_DichKinh_MT, Phu_VongMac_MT, Phu_VongMac_Text_MT, XuatHuyet_VongMac_MT, XuatHuyet_VongMac_Text_MT, Bong_VongMac_MT, Bong_VongMac_Text_MT, Rach_VongMac_MT, Rach_VongMac_Text_MT, ViTriRach_VongMac_Text_MT, HinhThaiRach_VongMac_Text_MT, DiVat_VongMac_MT, DiVat_VongMac_Text_MT, DiVat_VongMac_Text2_MT, TonThuongKhac_VongMac_MT, HocMat_MT, HocMat_Text_MT, DiVat_HocMat_MT, DiVat_HocMat_Text_MT, VanNhan_MT, VanNhan_Text_MT, NhanCau_MT, NhanCau_Text_MT, HinhVe_VongMac_MP, HinhVe_VongMac_MT, ChuaCoBieuHienBenhLy, BenhLy, ChanDoanBenhChinh_LamSang, ChanDoanBenhChinh_NguyenNhan, QuaTrinhDieuTri_NoiKhoa, PhauThuat, ThuThuat, ThiLucRaVienKhongKinhMPTongKet, ThiLucRaVienKhongKinhMTTongKet, ThiLucRaVienCoKinhMPTongKet, ThiLucRaVienCoKinhMTTongKet, NhanApRaVienMPTongKet, NhanApRaVienMTTongKet, HuongDieuTriTiep, TuaMoi_MP, TuaMoi_MP_Text, TuaMoi_MT, TuaMoi_MT_Text, TuaCu_MP, TuaCu_MP_Text, TuaCu_MT, TuaCu_MT_Text,  TienPhongMP_Sau_Text, TienPhongMP_Mu_Text, TienPhongMP_XuatTiet_Text, TienPhongMP_Tydall_Text, TienPhongMT_Sau_Text, TienPhongMT_Mu_Text, TienPhongMT_XuatTiet_Text, TienPhongMT_Tydall_Text, Trong_DichKinh_MP, Duc_DichKinh_MP_Text, XuatHuyet_DichKinh_MP_Text, Trong_DichKinh_MT, Duc_DichKinh_MT_Text, XuatHuyet_DichKinh_MT_Text, VongMac_BenhLy_MP, VongMac_BenhLy_MT, VoXuong_HocMat_MP, VoXuong_HocMat_Text_MP, VoXuong_HocMat_MT, VoXuong_HocMat_Text_MT, ViTri_Khau_MP, ViTri_Khau_MT, ThayBenhLy, ChuaThayBenhLy)
                   VALUES(:MaQuanLy, :LyDoVaoVien, :VaoNgayThu, :QuaTrinhBenhLy, :TienSuBenhBanThan, :TienSuBenhGiaDinh, :ToanThan, :TuanHoan, :HoHap, :TieuHoa, :ThanTietNieuSinhDuc, :ThanKinh, :CoXuongKhop, :TaiMuiHong, :RangHamMat, :Mat, :Khac_CacCoQuan, :CacXetNghiemCanLamSangCanLam, :TomTatBenhAn, :BenhChinh, :BenhKemTheo, :PhanBiet, :TienLuong, :HuongDieuTri, :NgayKhamBenh, :BacSyLamBenhAn, :QuaTrinhBenhLyVaDienBien, :TomTatKetQuaXetNghiem, :PhuongPhapDieuTri, :TinhTrangNguoiBenhRaVien, :HuongDieuTriVaCacCheDoTiepTheo, :NguoiNhanHoSo, :NguoiGiaoHoSo, :NgayTongKet, :BacSyDieuTri, :DiUng, :DiUng_Text, :MaTuy, :MaTuy_Text, :RuouBia, :RuouBia_Text, :ThuocLa, :ThuocLa_Text, :ThuocLao, :ThuocLao_Text, :Khac_DacDiemLienQuanBenh, :Khac_DacDiemLienQuanBenh_Text, :ThiLucKhiVaoVien_KhongKinh_MP, :ThiLucKhiVaoVien_KhongKinh_MT, :ThiLucKhiVaoVien_CoKinh_MP, :ThiLucKhiVaoVien_CoKinh_MT, :NhanApVaoVien_MT, :NhanApVaoVien_MP, :ThiTruong_MP, :ThiTruong_MT, :MiMat_MP, :SupMi_MP, :SupMi_MP_Text, :RachMi_MP, :RachMi_Khau_MP, :LeQuan_MP, :LeQuan_ID_MP, :SeoMi_MP, :SeoMi_MP_Text, :CacTonThuongKhac_MiMat_MP, :KetMac_MP, :XuatHuyet_MP, :XuatHuyet_MP_Text, :RachKetMac_MP, :RachKetMac_MP_Text, :ThieuMau_MP, :ThieuMau_MP_Text, :TonThuongKhac_KetMac_MP, :HinhVeMoTaTonThuongKVV_MP, :GiacMac_MP, :GiacMac_Seo_MP, :GiacMac_Seo_MP_Text, :GiacMac_DiVat_MP, :GiacMac_DiVat_MP_Text, :TuaSauGiacMac_MP, :TuaSauGiacMac_ID_MP, :RachGiacMac_MP, :RachGiacMac_MP_Text, :RachGiacMac_MP_Text2, :RachGiacMac_ID_MP, :DaKhauGiacMac_MP, :DungGiaiPhauGiacMac_MP, :TonThuongKhac_GiacMac_MP, :CungMac_MP, :RachCungMac_MP, :RachCungMac_MP_Text, :RachCungMac_MP_Text2, :DaKhauCungMac_MP, :KetToChucCungMac_MP, :TonThuongKhac_CungMac_MP, :TienPhong_MP, :XuatTiet_TienPhong_MP, :XuatTiet_TienPhong_Text_MP, :DiVat_TienPhong_MP, :DiVat_TienPhong_Text_MP, :TonThuongKhac_TienPhong_MP, :MongMat_MP, :DutChanMongMat_MP, :DutChanMongMat_Text_MP, :MatMongMat_MP, :MatMongMat_Text_MP, :ThungMongMat_MP, :ThungMongMat_Text_MP, :KichThuoc_DongTu_MP, :PXDT_MP, :TronMeo_DongTu_MP, :Dinh_DongTu_MP, :ViTri_DongTu_MP, :GianLiet_DongTu_MP, :AnhDongTu_MP, :KhongQuanSatDuoc_ADT_MP, :TheThuyTinh_MP, :DiVat_TheThuyTinh_MP, :SaLech_TheThuyTinh_MP, :SaLechID_TheThuyTinh_MP, :ViemMu_TheThuyTinh_MP, :DaDatIOL_TheThuyTinh_MP, :DaDatIOL_TheThuyTinh_Text_MP, :TonThuongKhac_TheThuyTinh_MP, :Duc_DichKinh_MP, :ViemMu_DichKinh_MP, :XuatHuyet_DichKinh_MP, :ToChucHoa_DichKinh_MP, :Bong_DichKinh_MP, :DiVat_DichKinh_MP, :TonThuongKhac_DichKinh_MP, :HeMach_DichKinh_MP, :DiaThi_DichKinh_MP, :Phu_VongMac_MP, :Phu_VongMac_Text_MP, :XuatHuyet_VongMac_MP, :XuatHuyet_VongMac_Text_MP, :Bong_VongMac_MP, :Bong_VongMac_Text_MP, :Rach_VongMac_MP, :Rach_VongMac_Text_MP, :ViTriRach_VongMac_Text_MP, :HinhThaiRach_VongMac_Text_MP, :DiVat_VongMac_MP, :DiVat_VongMac_Text_MP, :DiVat_VongMac_Text2_MP, :TonThuongKhac_VongMac_MP, :HocMat_MP, :HocMat_Text_MP, :DiVat_HocMat_MP, :DiVat_HocMat_Text_MP, :VanNhan_MP, :VanNhan_Text_MP, :NhanCau_MP, :NhanCau_Text_MP, :MiMat_MT, :SupMi_MT, :SupMi_MT_Text, :RachMi_MT, :RachMi_Khau_MT, :LeQuan_MT, :LeQuan_ID_MT, :SeoMi_MT, :SeoMi_MT_Text, :CacTonThuongKhac_MiMat_MT, :KetMac_MT, :XuatHuyet_MT, :XuatHuyet_MT_Text, :RachKetMac_MT, :RachKetMac_MT_Text, :ThieuMau_MT, :ThieuMau_MT_Text, :TonThuongKhac_KetMac_MT, :HinhVeMoTaTonThuongKVV_MT, :GiacMac_MT, :GiacMac_Seo_MT, :GiacMac_Seo_MT_Text, :GiacMac_DiVat_MT, :GiacMac_DiVat_MT_Text, :TuaSauGiacMac_MT, :TuaSauGiacMac_ID_MT, :RachGiacMac_MT, :RachGiacMac_MT_Text, :RachGiacMac_MT_Text2, :RachGiacMac_ID_MT, :DaKhauGiacMac_MT, :DungGiaiPhauGiacMac_MT, :TonThuongKhac_GiacMac_MT, :CungMac_MT, :RachCungMac_MT, :RachCungMac_MT_Text, :RachCungMac_MT_Text2, :DaKhauCungMac_MT, :KetToChucCungMac_MT, :TonThuongKhac_CungMac_MT, :TienPhong_MT, :XuatTiet_TienPhong_MT, :XuatTiet_TienPhong_Text_MT, :DiVat_TienPhong_MT, :DiVat_TienPhong_Text_MT, :TonThuongKhac_TienPhong_MT, :MongMat_MT, :DutChanMongMat_MT, :DutChanMongMat_Text_MT, :MatMongMat_MT, :MatMongMat_Text_MT, :ThungMongMat_MT, :ThungMongMat_Text_MT, :KichThuoc_DongTu_MT, :PXDT_MT, :TronMeo_DongTu_MT, :Dinh_DongTu_MT, :ViTri_DongTu_MT, :GianLiet_DongTu_MT, :AnhDongTu_MT, :KhongQuanSatDuoc_ADT_MT, :TheThuyTinh_MT, :DiVat_TheThuyTinh_MT, :SaLech_TheThuyTinh_MT, :SaLechID_TheThuyTinh_MT, :ViemMu_TheThuyTinh_MT, :DaDatIOL_TheThuyTinh_MT, :DaDatIOL_TheThuyTinh_Text_MT, :TonThuongKhac_TheThuyTinh_MT, :Duc_DichKinh_MT, :ViemMu_DichKinh_MT, :XuatHuyet_DichKinh_MT, :ToChucHoa_DichKinh_MT, :Bong_DichKinh_MT, :DiVat_DichKinh_MT, :TonThuongKhac_DichKinh_MT, :HeMach_DichKinh_MT, :DiaThi_DichKinh_MT, :Phu_VongMac_MT, :Phu_VongMac_Text_MT, :XuatHuyet_VongMac_MT, :XuatHuyet_VongMac_Text_MT, :Bong_VongMac_MT, :Bong_VongMac_Text_MT, :Rach_VongMac_MT, :Rach_VongMac_Text_MT, :ViTriRach_VongMac_Text_MT, :HinhThaiRach_VongMac_Text_MT, :DiVat_VongMac_MT, :DiVat_VongMac_Text_MT, :DiVat_VongMac_Text2_MT, :TonThuongKhac_VongMac_MT, :HocMat_MT, :HocMat_Text_MT, :DiVat_HocMat_MT, :DiVat_HocMat_Text_MT, :VanNhan_MT, :VanNhan_Text_MT, :NhanCau_MT, :NhanCau_Text_MT, :HinhVe_VongMac_MP, :HinhVe_VongMac_MT, :ChuaCoBieuHienBenhLy, :BenhLy, :ChanDoanBenhChinh_LamSang, :ChanDoanBenhChinh_NguyenNhan, :QuaTrinhDieuTri_NoiKhoa, :PhauThuat, :ThuThuat, :ThiLucRaVienKhongKinhMPTongKet, :ThiLucRaVienKhongKinhMTTongKet, :ThiLucRaVienCoKinhMPTongKet, :ThiLucRaVienCoKinhMTTongKet, :NhanApRaVienMPTongKet, :NhanApRaVienMTTongKet, :HuongDieuTriTiep, :TuaMoi_MP, :TuaMoi_MP_Text, :TuaMoi_MT, :TuaMoi_MT_Text, :TuaCu_MP, :TuaCu_MP_Text, :TuaCu_MT, :TuaCu_MT_Text, :TienPhongMP_Sau_Text, :TienPhongMP_Mu_Text, :TienPhongMP_XuatTiet_Text, :TienPhongMP_Tydall_Text, :TienPhongMT_Sau_Text, :TienPhongMT_Mu_Text, :TienPhongMT_XuatTiet_Text, :TienPhongMT_Tydall_Text, :Trong_DichKinh_MP, :Duc_DichKinh_MP_Text, :XuatHuyet_DichKinh_MP_Text, :Trong_DichKinh_MT, :Duc_DichKinh_MT_Text, :XuatHuyet_DichKinh_MT_Text, :VongMac_BenhLy_MP, :VongMac_BenhLy_MT, :VoXuong_HocMat_MP, :VoXuong_HocMat_Text_MP, :VoXuong_HocMat_MT, :VoXuong_HocMat_Text_MT, :ViTri_Khau_MP, :ViTri_Khau_MT, :ThayBenhLy, :ChuaThayBenhLy)
                   ";
            Command = new MDB.MDBCommand(sql, MyConnection);
            Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", BenhAnMatChanThuong.MaQuanLy));
            Command.Parameters.Add(new MDB.MDBParameter("LyDoVaoVien", BenhAnMatChanThuong.LyDoVaoVien));
            Command.Parameters.Add(new MDB.MDBParameter("VaoNgayThu", BenhAnMatChanThuong.VaoNgayThu));
            Command.Parameters.Add(new MDB.MDBParameter("QuaTrinhBenhLy", BenhAnMatChanThuong.QuaTrinhBenhLy));
            Command.Parameters.Add(new MDB.MDBParameter("TienSuBenhBanThan", BenhAnMatChanThuong.TienSuBenhBanThan));
            Command.Parameters.Add(new MDB.MDBParameter("TienSuBenhGiaDinh", BenhAnMatChanThuong.TienSuBenhGiaDinh));
            Command.Parameters.Add(new MDB.MDBParameter("ToanThan", BenhAnMatChanThuong.ToanThan));
            Command.Parameters.Add(new MDB.MDBParameter("TuanHoan", BenhAnMatChanThuong.TuanHoan));
            Command.Parameters.Add(new MDB.MDBParameter("HoHap", BenhAnMatChanThuong.HoHap));
            Command.Parameters.Add(new MDB.MDBParameter("TieuHoa", BenhAnMatChanThuong.TieuHoa));
            Command.Parameters.Add(new MDB.MDBParameter("ThanTietNieuSinhDuc", BenhAnMatChanThuong.ThanTietNieuSinhDuc));
            Command.Parameters.Add(new MDB.MDBParameter("ThanKinh", BenhAnMatChanThuong.ThanKinh));
            Command.Parameters.Add(new MDB.MDBParameter("CoXuongKhop", BenhAnMatChanThuong.CoXuongKhop));
            Command.Parameters.Add(new MDB.MDBParameter("TaiMuiHong", BenhAnMatChanThuong.TaiMuiHong));
            Command.Parameters.Add(new MDB.MDBParameter("RangHamMat", BenhAnMatChanThuong.RangHamMat));
            Command.Parameters.Add(new MDB.MDBParameter("Mat", BenhAnMatChanThuong.Mat));
            Command.Parameters.Add(new MDB.MDBParameter("Khac_CacCoQuan", BenhAnMatChanThuong.Khac_CacCoQuan));
            Command.Parameters.Add(new MDB.MDBParameter("CacXetNghiemCanLamSangCanLam", BenhAnMatChanThuong.CacXetNghiemCanLamSangCanLam));
            Command.Parameters.Add(new MDB.MDBParameter("TomTatBenhAn", BenhAnMatChanThuong.TomTatBenhAn));
            Command.Parameters.Add(new MDB.MDBParameter("BenhChinh", BenhAnMatChanThuong.BenhChinh));
            Command.Parameters.Add(new MDB.MDBParameter("BenhKemTheo", BenhAnMatChanThuong.BenhKemTheo));
            Command.Parameters.Add(new MDB.MDBParameter("PhanBiet", BenhAnMatChanThuong.PhanBiet));
            Command.Parameters.Add(new MDB.MDBParameter("TienLuong", BenhAnMatChanThuong.TienLuong));
            Command.Parameters.Add(new MDB.MDBParameter("HuongDieuTri", BenhAnMatChanThuong.HuongDieuTri));
            Command.Parameters.Add(new MDB.MDBParameter("NgayKhamBenh", BenhAnMatChanThuong.NgayKhamBenh));
            Command.Parameters.Add(new MDB.MDBParameter("BacSyLamBenhAn", BenhAnMatChanThuong.BacSyLamBenhAn));
            Command.Parameters.Add(new MDB.MDBParameter("QuaTrinhBenhLyVaDienBien", BenhAnMatChanThuong.QuaTrinhBenhLyVaDienBien));
            Command.Parameters.Add(new MDB.MDBParameter("TomTatKetQuaXetNghiem", BenhAnMatChanThuong.TomTatKetQuaXetNghiem));
            Command.Parameters.Add(new MDB.MDBParameter("PhuongPhapDieuTri", BenhAnMatChanThuong.PhuongPhapDieuTri));
            Command.Parameters.Add(new MDB.MDBParameter("TinhTrangNguoiBenhRaVien", BenhAnMatChanThuong.TinhTrangNguoiBenhRaVien));
            Command.Parameters.Add(new MDB.MDBParameter("HuongDieuTriVaCacCheDoTiepTheo", BenhAnMatChanThuong.HuongDieuTriVaCacCheDoTiepTheo));
            Command.Parameters.Add(new MDB.MDBParameter("NguoiNhanHoSo", BenhAnMatChanThuong.NguoiNhanHoSo));
            Command.Parameters.Add(new MDB.MDBParameter("NguoiGiaoHoSo", BenhAnMatChanThuong.NguoiGiaoHoSo));
            Command.Parameters.Add(new MDB.MDBParameter("NgayTongKet", BenhAnMatChanThuong.NgayTongKet));
            Command.Parameters.Add(new MDB.MDBParameter("BacSyDieuTri", BenhAnMatChanThuong.BacSyDieuTri));
            Command.Parameters.Add(new MDB.MDBParameter("DiUng", BenhAnMatChanThuong.DacDiemLienQuanBenh.DiUng == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("DiUng_Text", BenhAnMatChanThuong.DacDiemLienQuanBenh.DiUng_Text));
            Command.Parameters.Add(new MDB.MDBParameter("MaTuy", BenhAnMatChanThuong.DacDiemLienQuanBenh.MaTuy == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("MaTuy_Text", BenhAnMatChanThuong.DacDiemLienQuanBenh.MaTuy_Text));
            Command.Parameters.Add(new MDB.MDBParameter("RuouBia", BenhAnMatChanThuong.DacDiemLienQuanBenh.RuouBia == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("RuouBia_Text", BenhAnMatChanThuong.DacDiemLienQuanBenh.RuouBia_Text));
            Command.Parameters.Add(new MDB.MDBParameter("ThuocLa", BenhAnMatChanThuong.DacDiemLienQuanBenh.ThuocLa == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("ThuocLa_Text", BenhAnMatChanThuong.DacDiemLienQuanBenh.ThuocLa_Text));
            Command.Parameters.Add(new MDB.MDBParameter("ThuocLao", BenhAnMatChanThuong.DacDiemLienQuanBenh.ThuocLao == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("ThuocLao_Text", BenhAnMatChanThuong.DacDiemLienQuanBenh.ThuocLao_Text));
            Command.Parameters.Add(new MDB.MDBParameter("Khac_DacDiemLienQuanBenh", BenhAnMatChanThuong.DacDiemLienQuanBenh.Khac_DacDiemLienQuanBenh == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("Khac_DacDiemLienQuanBenh_Text", BenhAnMatChanThuong.DacDiemLienQuanBenh.Khac_DacDiemLienQuanBenh_Text));
            Command.Parameters.Add(new MDB.MDBParameter("ThiLucKhiVaoVien_KhongKinh_MP", BenhAnMatChanThuong.ThiLucKhiVaoVien_KhongKinh_MP));
            Command.Parameters.Add(new MDB.MDBParameter("ThiLucKhiVaoVien_KhongKinh_MT", BenhAnMatChanThuong.ThiLucKhiVaoVien_KhongKinh_MT));
            Command.Parameters.Add(new MDB.MDBParameter("ThiLucKhiVaoVien_CoKinh_MP", BenhAnMatChanThuong.ThiLucKhiVaoVien_CoKinh_MP));
            Command.Parameters.Add(new MDB.MDBParameter("ThiLucKhiVaoVien_CoKinh_MT", BenhAnMatChanThuong.ThiLucKhiVaoVien_CoKinh_MT));
            Command.Parameters.Add(new MDB.MDBParameter("NhanApVaoVien_MT", BenhAnMatChanThuong.NhanApVaoVien_MT));
            Command.Parameters.Add(new MDB.MDBParameter("NhanApVaoVien_MP", BenhAnMatChanThuong.NhanApVaoVien_MP));
            Command.Parameters.Add(new MDB.MDBParameter("ThiTruong_MP", BenhAnMatChanThuong.ThiTruong_MP));
            Command.Parameters.Add(new MDB.MDBParameter("ThiTruong_MT", BenhAnMatChanThuong.ThiTruong_MT));
            Command.Parameters.Add(new MDB.MDBParameter("MiMat_MP", BenhAnMatChanThuong.MiMat_MP));
            Command.Parameters.Add(new MDB.MDBParameter("SupMi_MP", BenhAnMatChanThuong.SupMi_MP == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("SupMi_MP_Text", BenhAnMatChanThuong.SupMi_MP_Text));
            Command.Parameters.Add(new MDB.MDBParameter("RachMi_MP", BenhAnMatChanThuong.RachMi_MP));
            Command.Parameters.Add(new MDB.MDBParameter("RachMi_Khau_MP", BenhAnMatChanThuong.RachMi_Khau_MP));
            Command.Parameters.Add(new MDB.MDBParameter("LeQuan_MP", BenhAnMatChanThuong.LeQuan_MP));
            Command.Parameters.Add(new MDB.MDBParameter("LeQuan_ID_MP", BenhAnMatChanThuong.LeQuan_ID_MP));
            Command.Parameters.Add(new MDB.MDBParameter("SeoMi_MP", BenhAnMatChanThuong.SeoMi_MP == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("SeoMi_MP_Text", BenhAnMatChanThuong.SeoMi_MP_Text));
            Command.Parameters.Add(new MDB.MDBParameter("CacTonThuongKhac_MiMat_MP", BenhAnMatChanThuong.CacTonThuongKhac_MiMat_MP));
            Command.Parameters.Add(new MDB.MDBParameter("KetMac_MP", BenhAnMatChanThuong.KetMac_MP));
            Command.Parameters.Add(new MDB.MDBParameter("XuatHuyet_MP", BenhAnMatChanThuong.XuatHuyet_MP == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("XuatHuyet_MP_Text", BenhAnMatChanThuong.XuatHuyet_MP_Text));
            Command.Parameters.Add(new MDB.MDBParameter("RachKetMac_MP", BenhAnMatChanThuong.RachKetMac_MP == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("RachKetMac_MP_Text", BenhAnMatChanThuong.RachKetMac_MP_Text));
            Command.Parameters.Add(new MDB.MDBParameter("ThieuMau_MP", BenhAnMatChanThuong.ThieuMau_MP == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("ThieuMau_MP_Text", BenhAnMatChanThuong.ThieuMau_MP_Text));
            Command.Parameters.Add(new MDB.MDBParameter("TonThuongKhac_KetMac_MP", BenhAnMatChanThuong.TonThuongKhac_KetMac_MP));
            Command.Parameters.Add(new MDB.MDBParameter("HinhVeMoTaTonThuongKVV_MP", BenhAnMatChanThuong.HinhVeMoTaTonThuongKVV_MP));
            Command.Parameters.Add(new MDB.MDBParameter("GiacMac_MP", BenhAnMatChanThuong.GiacMac_MP));
            Command.Parameters.Add(new MDB.MDBParameter("GiacMac_Seo_MP", BenhAnMatChanThuong.GiacMac_Seo_MP == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("GiacMac_Seo_MP_Text", BenhAnMatChanThuong.GiacMac_Seo_MP_Text));
            Command.Parameters.Add(new MDB.MDBParameter("GiacMac_DiVat_MP", BenhAnMatChanThuong.GiacMac_DiVat_MP == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("GiacMac_DiVat_MP_Text", BenhAnMatChanThuong.GiacMac_DiVat_MP_Text));
            Command.Parameters.Add(new MDB.MDBParameter("TuaSauGiacMac_MP", BenhAnMatChanThuong.TuaSauGiacMac_MP));
            Command.Parameters.Add(new MDB.MDBParameter("TuaSauGiacMac_ID_MP", BenhAnMatChanThuong.TuaSauGiacMac_ID_MP));
            Command.Parameters.Add(new MDB.MDBParameter("RachGiacMac_MP", BenhAnMatChanThuong.RachGiacMac_MP == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("RachGiacMac_MP_Text", BenhAnMatChanThuong.RachGiacMac_MP_Text));
            Command.Parameters.Add(new MDB.MDBParameter("RachGiacMac_MP_Text2", BenhAnMatChanThuong.RachGiacMac_MP_Text2));
            Command.Parameters.Add(new MDB.MDBParameter("RachGiacMac_ID_MP", BenhAnMatChanThuong.RachGiacMac_ID_MP));
            Command.Parameters.Add(new MDB.MDBParameter("DaKhauGiacMac_MP", BenhAnMatChanThuong.DaKhauGiacMac_MP == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("DungGiaiPhauGiacMac_MP", BenhAnMatChanThuong.DungGiaiPhauGiacMac_MP));
            Command.Parameters.Add(new MDB.MDBParameter("TonThuongKhac_GiacMac_MP", BenhAnMatChanThuong.TonThuongKhac_GiacMac_MP));
            Command.Parameters.Add(new MDB.MDBParameter("CungMac_MP", BenhAnMatChanThuong.CungMac_MP));
            Command.Parameters.Add(new MDB.MDBParameter("RachCungMac_MP", BenhAnMatChanThuong.RachCungMac_MP == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("RachCungMac_MP_Text", BenhAnMatChanThuong.RachCungMac_MP_Text));
            Command.Parameters.Add(new MDB.MDBParameter("RachCungMac_MP_Text2", BenhAnMatChanThuong.RachCungMac_MP_Text2));
            Command.Parameters.Add(new MDB.MDBParameter("DaKhauCungMac_MP", BenhAnMatChanThuong.DaKhauCungMac_MP));
            Command.Parameters.Add(new MDB.MDBParameter("KetToChucCungMac_MP", BenhAnMatChanThuong.KetToChucCungMac_MP == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("TonThuongKhac_CungMac_MP", BenhAnMatChanThuong.TonThuongKhac_CungMac_MP));
            Command.Parameters.Add(new MDB.MDBParameter("TienPhong_MP", BenhAnMatChanThuong.TienPhong_MP));
            Command.Parameters.Add(new MDB.MDBParameter("XuatTiet_TienPhong_MP", BenhAnMatChanThuong.XuatTiet_TienPhong_MP == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("XuatTiet_TienPhong_Text_MP", BenhAnMatChanThuong.XuatTiet_TienPhong_Text_MP));
            Command.Parameters.Add(new MDB.MDBParameter("DiVat_TienPhong_MP", BenhAnMatChanThuong.DiVat_TienPhong_MP == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("DiVat_TienPhong_Text_MP", BenhAnMatChanThuong.DiVat_TienPhong_Text_MP));
            Command.Parameters.Add(new MDB.MDBParameter("TonThuongKhac_TienPhong_MP", BenhAnMatChanThuong.TonThuongKhac_TienPhong_MP));
            Command.Parameters.Add(new MDB.MDBParameter("MongMat_MP", BenhAnMatChanThuong.MongMat_MP));
            Command.Parameters.Add(new MDB.MDBParameter("DutChanMongMat_MP", BenhAnMatChanThuong.DutChanMongMat_MP == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("DutChanMongMat_Text_MP", BenhAnMatChanThuong.DutChanMongMat_Text_MP));
            Command.Parameters.Add(new MDB.MDBParameter("MatMongMat_MP", BenhAnMatChanThuong.MatMongMat_MP == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("MatMongMat_Text_MP", BenhAnMatChanThuong.MatMongMat_Text_MP));
            Command.Parameters.Add(new MDB.MDBParameter("ThungMongMat_MP", BenhAnMatChanThuong.ThungMongMat_MP == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("ThungMongMat_Text_MP", BenhAnMatChanThuong.ThungMongMat_Text_MP));
            Command.Parameters.Add(new MDB.MDBParameter("KichThuoc_DongTu_MP", BenhAnMatChanThuong.KichThuoc_DongTu_MP));
            Command.Parameters.Add(new MDB.MDBParameter("PXDT_MP", BenhAnMatChanThuong.PXDT_MP));
            Command.Parameters.Add(new MDB.MDBParameter("TronMeo_DongTu_MP", BenhAnMatChanThuong.TronMeo_DongTu_MP));
            Command.Parameters.Add(new MDB.MDBParameter("Dinh_DongTu_MP", BenhAnMatChanThuong.Dinh_DongTu_MP == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("ViTri_DongTu_MP", BenhAnMatChanThuong.ViTri_DongTu_MP));
            Command.Parameters.Add(new MDB.MDBParameter("GianLiet_DongTu_MP", BenhAnMatChanThuong.GianLiet_DongTu_MP == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("AnhDongTu_MP", BenhAnMatChanThuong.AnhDongTu_MP));
            Command.Parameters.Add(new MDB.MDBParameter("KhongQuanSatDuoc_ADT_MP", BenhAnMatChanThuong.KhongQuanSatDuoc_ADT_MP == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("TheThuyTinh_MP", BenhAnMatChanThuong.TheThuyTinh_MP));
            Command.Parameters.Add(new MDB.MDBParameter("DiVat_TheThuyTinh_MP", BenhAnMatChanThuong.DiVat_TheThuyTinh_MP == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("SaLech_TheThuyTinh_MP", BenhAnMatChanThuong.SaLech_TheThuyTinh_MP == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("SaLechID_TheThuyTinh_MP", BenhAnMatChanThuong.SaLechID_TheThuyTinh_MP));
            Command.Parameters.Add(new MDB.MDBParameter("ViemMu_TheThuyTinh_MP", BenhAnMatChanThuong.ViemMu_TheThuyTinh_MP == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("DaDatIOL_TheThuyTinh_MP", BenhAnMatChanThuong.DaDatIOL_TheThuyTinh_MP == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("DaDatIOL_TheThuyTinh_Text_MP", BenhAnMatChanThuong.DaDatIOL_TheThuyTinh_Text_MP));
            Command.Parameters.Add(new MDB.MDBParameter("TonThuongKhac_TheThuyTinh_MP", BenhAnMatChanThuong.TonThuongKhac_TheThuyTinh_MP));
            Command.Parameters.Add(new MDB.MDBParameter("Duc_DichKinh_MP", BenhAnMatChanThuong.Duc_DichKinh_MP == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("ViemMu_DichKinh_MP", BenhAnMatChanThuong.ViemMu_DichKinh_MP == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("XuatHuyet_DichKinh_MP", BenhAnMatChanThuong.XuatHuyet_DichKinh_MP == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("ToChucHoa_DichKinh_MP", BenhAnMatChanThuong.ToChucHoa_DichKinh_MP == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("Bong_DichKinh_MP", BenhAnMatChanThuong.Bong_DichKinh_MP == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("DiVat_DichKinh_MP", BenhAnMatChanThuong.DiVat_DichKinh_MP == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("TonThuongKhac_DichKinh_MP", BenhAnMatChanThuong.TonThuongKhac_DichKinh_MP));
            Command.Parameters.Add(new MDB.MDBParameter("HeMach_DichKinh_MP", BenhAnMatChanThuong.HeMach_DichKinh_MP));
            Command.Parameters.Add(new MDB.MDBParameter("DiaThi_DichKinh_MP", BenhAnMatChanThuong.DiaThi_DichKinh_MP));
            Command.Parameters.Add(new MDB.MDBParameter("Phu_VongMac_MP", BenhAnMatChanThuong.Phu_VongMac_MP == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("Phu_VongMac_Text_MP", BenhAnMatChanThuong.Phu_VongMac_Text_MP));
            Command.Parameters.Add(new MDB.MDBParameter("XuatHuyet_VongMac_MP", BenhAnMatChanThuong.XuatHuyet_VongMac_MP == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("XuatHuyet_VongMac_Text_MP", BenhAnMatChanThuong.XuatHuyet_VongMac_Text_MP));
            Command.Parameters.Add(new MDB.MDBParameter("Bong_VongMac_MP", BenhAnMatChanThuong.Bong_VongMac_MP));
            Command.Parameters.Add(new MDB.MDBParameter("Bong_VongMac_Text_MP", BenhAnMatChanThuong.Bong_VongMac_Text_MP));
            Command.Parameters.Add(new MDB.MDBParameter("Rach_VongMac_MP", BenhAnMatChanThuong.Rach_VongMac_MP));
            Command.Parameters.Add(new MDB.MDBParameter("Rach_VongMac_Text_MP", BenhAnMatChanThuong.Rach_VongMac_Text_MP));
            Command.Parameters.Add(new MDB.MDBParameter("ViTriRach_VongMac_Text_MP", BenhAnMatChanThuong.ViTriRach_VongMac_Text_MP));
            Command.Parameters.Add(new MDB.MDBParameter("HinhThaiRach_VongMac_Text_MP", BenhAnMatChanThuong.HinhThaiRach_VongMac_Text_MP));
            Command.Parameters.Add(new MDB.MDBParameter("DiVat_VongMac_MP", BenhAnMatChanThuong.DiVat_VongMac_MP == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("DiVat_VongMac_Text_MP", BenhAnMatChanThuong.DiVat_VongMac_Text_MP));
            Command.Parameters.Add(new MDB.MDBParameter("DiVat_VongMac_Text2_MP", BenhAnMatChanThuong.DiVat_VongMac_Text2_MP));
            Command.Parameters.Add(new MDB.MDBParameter("TonThuongKhac_VongMac_MP", BenhAnMatChanThuong.TonThuongKhac_VongMac_MP));
            Command.Parameters.Add(new MDB.MDBParameter("HocMat_MP", BenhAnMatChanThuong.HocMat_MP));
            Command.Parameters.Add(new MDB.MDBParameter("HocMat_Text_MP", BenhAnMatChanThuong.HocMat_Text_MP));
            Command.Parameters.Add(new MDB.MDBParameter("DiVat_HocMat_MP", BenhAnMatChanThuong.DiVat_HocMat_MP == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("DiVat_HocMat_Text_MP", BenhAnMatChanThuong.DiVat_HocMat_Text_MP));
            Command.Parameters.Add(new MDB.MDBParameter("VanNhan_MP", BenhAnMatChanThuong.VanNhan_MP));
            Command.Parameters.Add(new MDB.MDBParameter("VanNhan_Text_MP", BenhAnMatChanThuong.VanNhan_Text_MP));
            Command.Parameters.Add(new MDB.MDBParameter("NhanCau_MP", BenhAnMatChanThuong.NhanCau_MP));
            Command.Parameters.Add(new MDB.MDBParameter("NhanCau_Text_MP", BenhAnMatChanThuong.NhanCau_Text_MP));
            Command.Parameters.Add(new MDB.MDBParameter("MiMat_MT", BenhAnMatChanThuong.MiMat_MT));
            Command.Parameters.Add(new MDB.MDBParameter("SupMi_MT", BenhAnMatChanThuong.SupMi_MT == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("SupMi_MT_Text", BenhAnMatChanThuong.SupMi_MT_Text));
            Command.Parameters.Add(new MDB.MDBParameter("RachMi_MT", BenhAnMatChanThuong.RachMi_MT));
            Command.Parameters.Add(new MDB.MDBParameter("RachMi_Khau_MT", BenhAnMatChanThuong.RachMi_Khau_MT));
            Command.Parameters.Add(new MDB.MDBParameter("LeQuan_MT", BenhAnMatChanThuong.LeQuan_MT));
            Command.Parameters.Add(new MDB.MDBParameter("LeQuan_ID_MT", BenhAnMatChanThuong.LeQuan_ID_MT));
            Command.Parameters.Add(new MDB.MDBParameter("SeoMi_MT", BenhAnMatChanThuong.SeoMi_MT == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("SeoMi_MT_Text", BenhAnMatChanThuong.SeoMi_MT_Text));
            Command.Parameters.Add(new MDB.MDBParameter("CacTonThuongKhac_MiMat_MT", BenhAnMatChanThuong.CacTonThuongKhac_MiMat_MT));
            Command.Parameters.Add(new MDB.MDBParameter("KetMac_MT", BenhAnMatChanThuong.KetMac_MT));
            Command.Parameters.Add(new MDB.MDBParameter("XuatHuyet_MT", BenhAnMatChanThuong.XuatHuyet_MT == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("XuatHuyet_MT_Text", BenhAnMatChanThuong.XuatHuyet_MT_Text));
            Command.Parameters.Add(new MDB.MDBParameter("RachKetMac_MT", BenhAnMatChanThuong.RachKetMac_MT == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("RachKetMac_MT_Text", BenhAnMatChanThuong.RachKetMac_MT_Text));
            Command.Parameters.Add(new MDB.MDBParameter("ThieuMau_MT", BenhAnMatChanThuong.ThieuMau_MT == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("ThieuMau_MT_Text", BenhAnMatChanThuong.ThieuMau_MT_Text));
            Command.Parameters.Add(new MDB.MDBParameter("TonThuongKhac_KetMac_MT", BenhAnMatChanThuong.TonThuongKhac_KetMac_MT));
            Command.Parameters.Add(new MDB.MDBParameter("HinhVeMoTaTonThuongKVV_MT", BenhAnMatChanThuong.HinhVeMoTaTonThuongKVV_MT));
            Command.Parameters.Add(new MDB.MDBParameter("GiacMac_MT", BenhAnMatChanThuong.GiacMac_MT));
            Command.Parameters.Add(new MDB.MDBParameter("GiacMac_Seo_MT", BenhAnMatChanThuong.GiacMac_Seo_MT == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("GiacMac_Seo_MT_Text", BenhAnMatChanThuong.GiacMac_Seo_MT_Text));
            Command.Parameters.Add(new MDB.MDBParameter("GiacMac_DiVat_MT", BenhAnMatChanThuong.GiacMac_DiVat_MT == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("GiacMac_DiVat_MT_Text", BenhAnMatChanThuong.GiacMac_DiVat_MT_Text));
            Command.Parameters.Add(new MDB.MDBParameter("TuaSauGiacMac_MT", BenhAnMatChanThuong.TuaSauGiacMac_MT));
            Command.Parameters.Add(new MDB.MDBParameter("TuaSauGiacMac_ID_MT", BenhAnMatChanThuong.TuaSauGiacMac_ID_MT));
            Command.Parameters.Add(new MDB.MDBParameter("RachGiacMac_MT", BenhAnMatChanThuong.RachGiacMac_MT == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("RachGiacMac_MT_Text", BenhAnMatChanThuong.RachGiacMac_MT_Text));
            Command.Parameters.Add(new MDB.MDBParameter("RachGiacMac_MT_Text2", BenhAnMatChanThuong.RachGiacMac_MT_Text2));
            Command.Parameters.Add(new MDB.MDBParameter("RachGiacMac_ID_MT", BenhAnMatChanThuong.RachGiacMac_ID_MT));
            Command.Parameters.Add(new MDB.MDBParameter("DaKhauGiacMac_MT", BenhAnMatChanThuong.DaKhauGiacMac_MT == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("DungGiaiPhauGiacMac_MT", BenhAnMatChanThuong.DungGiaiPhauGiacMac_MT));
            Command.Parameters.Add(new MDB.MDBParameter("TonThuongKhac_GiacMac_MT", BenhAnMatChanThuong.TonThuongKhac_GiacMac_MT));
            Command.Parameters.Add(new MDB.MDBParameter("CungMac_MT", BenhAnMatChanThuong.CungMac_MT));
            Command.Parameters.Add(new MDB.MDBParameter("RachCungMac_MT", BenhAnMatChanThuong.RachCungMac_MT == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("RachCungMac_MT_Text", BenhAnMatChanThuong.RachCungMac_MT_Text));
            Command.Parameters.Add(new MDB.MDBParameter("RachCungMac_MT_Text2", BenhAnMatChanThuong.RachCungMac_MT_Text2));
            Command.Parameters.Add(new MDB.MDBParameter("DaKhauCungMac_MT", BenhAnMatChanThuong.DaKhauCungMac_MT));
            Command.Parameters.Add(new MDB.MDBParameter("KetToChucCungMac_MT", BenhAnMatChanThuong.KetToChucCungMac_MT == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("TonThuongKhac_CungMac_MT", BenhAnMatChanThuong.TonThuongKhac_CungMac_MT));
            Command.Parameters.Add(new MDB.MDBParameter("TienPhong_MT", BenhAnMatChanThuong.TienPhong_MT));
            Command.Parameters.Add(new MDB.MDBParameter("XuatTiet_TienPhong_MT", BenhAnMatChanThuong.XuatTiet_TienPhong_MT == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("XuatTiet_TienPhong_Text_MT", BenhAnMatChanThuong.XuatTiet_TienPhong_Text_MT));
            Command.Parameters.Add(new MDB.MDBParameter("DiVat_TienPhong_MT", BenhAnMatChanThuong.DiVat_TienPhong_MT == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("DiVat_TienPhong_Text_MT", BenhAnMatChanThuong.DiVat_TienPhong_Text_MT));
            Command.Parameters.Add(new MDB.MDBParameter("TonThuongKhac_TienPhong_MT", BenhAnMatChanThuong.TonThuongKhac_TienPhong_MT));
            Command.Parameters.Add(new MDB.MDBParameter("MongMat_MT", BenhAnMatChanThuong.MongMat_MT));
            Command.Parameters.Add(new MDB.MDBParameter("DutChanMongMat_MT", BenhAnMatChanThuong.DutChanMongMat_MT == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("DutChanMongMat_Text_MT", BenhAnMatChanThuong.DutChanMongMat_Text_MT));
            Command.Parameters.Add(new MDB.MDBParameter("MatMongMat_MT", BenhAnMatChanThuong.MatMongMat_MT == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("MatMongMat_Text_MT", BenhAnMatChanThuong.MatMongMat_Text_MT));
            Command.Parameters.Add(new MDB.MDBParameter("ThungMongMat_MT", BenhAnMatChanThuong.ThungMongMat_MT == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("ThungMongMat_Text_MT", BenhAnMatChanThuong.ThungMongMat_Text_MT));
            Command.Parameters.Add(new MDB.MDBParameter("KichThuoc_DongTu_MT", BenhAnMatChanThuong.KichThuoc_DongTu_MT));
            Command.Parameters.Add(new MDB.MDBParameter("PXDT_MT", BenhAnMatChanThuong.PXDT_MT));
            Command.Parameters.Add(new MDB.MDBParameter("TronMeo_DongTu_MT", BenhAnMatChanThuong.TronMeo_DongTu_MT));
            Command.Parameters.Add(new MDB.MDBParameter("Dinh_DongTu_MT", BenhAnMatChanThuong.Dinh_DongTu_MT == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("ViTri_DongTu_MT", BenhAnMatChanThuong.ViTri_DongTu_MT));
            Command.Parameters.Add(new MDB.MDBParameter("GianLiet_DongTu_MT", BenhAnMatChanThuong.GianLiet_DongTu_MT == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("AnhDongTu_MT", BenhAnMatChanThuong.AnhDongTu_MT));
            Command.Parameters.Add(new MDB.MDBParameter("KhongQuanSatDuoc_ADT_MT", BenhAnMatChanThuong.KhongQuanSatDuoc_ADT_MT == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("TheThuyTinh_MT", BenhAnMatChanThuong.TheThuyTinh_MT));
            Command.Parameters.Add(new MDB.MDBParameter("DiVat_TheThuyTinh_MT", BenhAnMatChanThuong.DiVat_TheThuyTinh_MT == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("SaLech_TheThuyTinh_MT", BenhAnMatChanThuong.SaLech_TheThuyTinh_MT == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("SaLechID_TheThuyTinh_MT", BenhAnMatChanThuong.SaLechID_TheThuyTinh_MT));
            Command.Parameters.Add(new MDB.MDBParameter("ViemMu_TheThuyTinh_MT", BenhAnMatChanThuong.ViemMu_TheThuyTinh_MT == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("DaDatIOL_TheThuyTinh_MT", BenhAnMatChanThuong.DaDatIOL_TheThuyTinh_MT == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("DaDatIOL_TheThuyTinh_Text_MT", BenhAnMatChanThuong.DaDatIOL_TheThuyTinh_Text_MT));
            Command.Parameters.Add(new MDB.MDBParameter("TonThuongKhac_TheThuyTinh_MT", BenhAnMatChanThuong.TonThuongKhac_TheThuyTinh_MT));
            Command.Parameters.Add(new MDB.MDBParameter("Duc_DichKinh_MT", BenhAnMatChanThuong.Duc_DichKinh_MT == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("ViemMu_DichKinh_MT", BenhAnMatChanThuong.ViemMu_DichKinh_MT == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("XuatHuyet_DichKinh_MT", BenhAnMatChanThuong.XuatHuyet_DichKinh_MT == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("ToChucHoa_DichKinh_MT", BenhAnMatChanThuong.ToChucHoa_DichKinh_MT == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("Bong_DichKinh_MT", BenhAnMatChanThuong.Bong_DichKinh_MT == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("DiVat_DichKinh_MT", BenhAnMatChanThuong.DiVat_DichKinh_MT == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("TonThuongKhac_DichKinh_MT", BenhAnMatChanThuong.TonThuongKhac_DichKinh_MT));
            Command.Parameters.Add(new MDB.MDBParameter("HeMach_DichKinh_MT", BenhAnMatChanThuong.HeMach_DichKinh_MT));
            Command.Parameters.Add(new MDB.MDBParameter("DiaThi_DichKinh_MT", BenhAnMatChanThuong.DiaThi_DichKinh_MT));
            Command.Parameters.Add(new MDB.MDBParameter("Phu_VongMac_MT", BenhAnMatChanThuong.Phu_VongMac_MT == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("Phu_VongMac_Text_MT", BenhAnMatChanThuong.Phu_VongMac_Text_MT));
            Command.Parameters.Add(new MDB.MDBParameter("XuatHuyet_VongMac_MT", BenhAnMatChanThuong.XuatHuyet_VongMac_MT == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("XuatHuyet_VongMac_Text_MT", BenhAnMatChanThuong.XuatHuyet_VongMac_Text_MT));
            Command.Parameters.Add(new MDB.MDBParameter("Bong_VongMac_MT", BenhAnMatChanThuong.Bong_VongMac_MT));
            Command.Parameters.Add(new MDB.MDBParameter("Bong_VongMac_Text_MT", BenhAnMatChanThuong.Bong_VongMac_Text_MT));
            Command.Parameters.Add(new MDB.MDBParameter("Rach_VongMac_MT", BenhAnMatChanThuong.Rach_VongMac_MT));
            Command.Parameters.Add(new MDB.MDBParameter("Rach_VongMac_Text_MT", BenhAnMatChanThuong.Rach_VongMac_Text_MT));
            Command.Parameters.Add(new MDB.MDBParameter("ViTriRach_VongMac_Text_MT", BenhAnMatChanThuong.ViTriRach_VongMac_Text_MT));
            Command.Parameters.Add(new MDB.MDBParameter("HinhThaiRach_VongMac_Text_MT", BenhAnMatChanThuong.HinhThaiRach_VongMac_Text_MT));
            Command.Parameters.Add(new MDB.MDBParameter("DiVat_VongMac_MT", BenhAnMatChanThuong.DiVat_VongMac_MT == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("DiVat_VongMac_Text_MT", BenhAnMatChanThuong.DiVat_VongMac_Text_MT));
            Command.Parameters.Add(new MDB.MDBParameter("DiVat_VongMac_Text2_MT", BenhAnMatChanThuong.DiVat_VongMac_Text2_MT));
            Command.Parameters.Add(new MDB.MDBParameter("TonThuongKhac_VongMac_MT", BenhAnMatChanThuong.TonThuongKhac_VongMac_MT));
            Command.Parameters.Add(new MDB.MDBParameter("HocMat_MT", BenhAnMatChanThuong.HocMat_MT));
            Command.Parameters.Add(new MDB.MDBParameter("HocMat_Text_MT", BenhAnMatChanThuong.HocMat_Text_MT));
            Command.Parameters.Add(new MDB.MDBParameter("DiVat_HocMat_MT", BenhAnMatChanThuong.DiVat_HocMat_MT == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("DiVat_HocMat_Text_MT", BenhAnMatChanThuong.DiVat_HocMat_Text_MT));
            Command.Parameters.Add(new MDB.MDBParameter("VanNhan_MT", BenhAnMatChanThuong.VanNhan_MT));
            Command.Parameters.Add(new MDB.MDBParameter("VanNhan_Text_MT", BenhAnMatChanThuong.VanNhan_Text_MT));
            Command.Parameters.Add(new MDB.MDBParameter("NhanCau_MT", BenhAnMatChanThuong.NhanCau_MT));
            Command.Parameters.Add(new MDB.MDBParameter("NhanCau_Text_MT", BenhAnMatChanThuong.NhanCau_Text_MT));
            Command.Parameters.Add(new MDB.MDBParameter("HinhVe_VongMac_MP", BenhAnMatChanThuong.HinhVe_VongMac_MP));
            Command.Parameters.Add(new MDB.MDBParameter("HinhVe_VongMac_MT", BenhAnMatChanThuong.HinhVe_VongMac_MT));
            Command.Parameters.Add(new MDB.MDBParameter("ChuaCoBieuHienBenhLy", BenhAnMatChanThuong.ChuaCoBieuHienBenhLy));
            Command.Parameters.Add(new MDB.MDBParameter("BenhLy", BenhAnMatChanThuong.BenhLy));
            Command.Parameters.Add(new MDB.MDBParameter("ChanDoanBenhChinh_LamSang", BenhAnMatChanThuong.ChanDoanBenhChinh_LamSang));
            Command.Parameters.Add(new MDB.MDBParameter("ChanDoanBenhChinh_NguyenNhan", BenhAnMatChanThuong.ChanDoanBenhChinh_NguyenNhan));
            Command.Parameters.Add(new MDB.MDBParameter("QuaTrinhDieuTri_NoiKhoa", BenhAnMatChanThuong.QuaTrinhDieuTri_NoiKhoa));
            Command.Parameters.Add(new MDB.MDBParameter("PhauThuat", BenhAnMatChanThuong.PhauThuat == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("ThuThuat", BenhAnMatChanThuong.ThuThuat == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("ThiLucRaVienKhongKinhMPTongKet", BenhAnMatChanThuong.ThiLucRaVienKhongKinhMPTongKet));
            Command.Parameters.Add(new MDB.MDBParameter("ThiLucRaVienKhongKinhMTTongKet", BenhAnMatChanThuong.ThiLucRaVienKhongKinhMTTongKet));
            Command.Parameters.Add(new MDB.MDBParameter("ThiLucRaVienCoKinhMPTongKet", BenhAnMatChanThuong.ThiLucRaVienCoKinhMPTongKet));
            Command.Parameters.Add(new MDB.MDBParameter("ThiLucRaVienCoKinhMTTongKet", BenhAnMatChanThuong.ThiLucRaVienCoKinhMTTongKet));
            Command.Parameters.Add(new MDB.MDBParameter("NhanApRaVienMPTongKet", BenhAnMatChanThuong.NhanApRaVienMPTongKet));
            Command.Parameters.Add(new MDB.MDBParameter("NhanApRaVienMTTongKet", BenhAnMatChanThuong.NhanApRaVienMTTongKet));
            Command.Parameters.Add(new MDB.MDBParameter("HuongDieuTriTiep", BenhAnMatChanThuong.HuongDieuTriTiep));
            Command.Parameters.Add(new MDB.MDBParameter("TuaMoi_MP", BenhAnMatChanThuong.TuaMoi_MP ? "1":"0"));
            Command.Parameters.Add(new MDB.MDBParameter("TuaMoi_MP_Text", BenhAnMatChanThuong.TuaMoi_MP_Text));
            Command.Parameters.Add(new MDB.MDBParameter("TuaMoi_MT", BenhAnMatChanThuong.TuaMoi_MT ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("TuaMoi_MT_Text", BenhAnMatChanThuong.TuaMoi_MT_Text));
            Command.Parameters.Add(new MDB.MDBParameter("TuaCu_MP", BenhAnMatChanThuong.TuaCu_MP ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("TuaCu_MP_Text", BenhAnMatChanThuong.TuaCu_MP_Text));
            Command.Parameters.Add(new MDB.MDBParameter("TuaCu_MT", BenhAnMatChanThuong.TuaCu_MT ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("TuaCu_MT_Text", BenhAnMatChanThuong.TuaCu_MT_Text));
            Command.Parameters.Add(new MDB.MDBParameter("TienPhongMP_Sau_Text", BenhAnMatChanThuong.TienPhongMP_Sau_Text));
            Command.Parameters.Add(new MDB.MDBParameter("TienPhongMP_Mu_Text", BenhAnMatChanThuong.TienPhongMP_Mu_Text));
            Command.Parameters.Add(new MDB.MDBParameter("TienPhongMP_XuatTiet_Text", BenhAnMatChanThuong.TienPhongMP_XuatTiet_Text));
            Command.Parameters.Add(new MDB.MDBParameter("TienPhongMP_Tydall_Text", BenhAnMatChanThuong.TienPhongMP_Tydall_Text));
            Command.Parameters.Add(new MDB.MDBParameter("TienPhongMT_Sau_Text", BenhAnMatChanThuong.TienPhongMT_Sau_Text));
            Command.Parameters.Add(new MDB.MDBParameter("TienPhongMT_Mu_Text", BenhAnMatChanThuong.TienPhongMT_Mu_Text));
            Command.Parameters.Add(new MDB.MDBParameter("TienPhongMT_XuatTiet_Text", BenhAnMatChanThuong.TienPhongMT_XuatTiet_Text));
            Command.Parameters.Add(new MDB.MDBParameter("TienPhongMT_Tydall_Text", BenhAnMatChanThuong.TienPhongMT_Tydall_Text));
            Command.Parameters.Add(new MDB.MDBParameter("Trong_DichKinh_MP", BenhAnMatChanThuong.Trong_DichKinh_MP ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("Duc_DichKinh_MP_Text", BenhAnMatChanThuong.Duc_DichKinh_MP_Text));
            Command.Parameters.Add(new MDB.MDBParameter("XuatHuyet_DichKinh_MP_Text", BenhAnMatChanThuong.XuatHuyet_DichKinh_MP_Text));
            Command.Parameters.Add(new MDB.MDBParameter("Trong_DichKinh_MT", BenhAnMatChanThuong.Trong_DichKinh_MT ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("Duc_DichKinh_MT_Text", BenhAnMatChanThuong.Duc_DichKinh_MT_Text));
            Command.Parameters.Add(new MDB.MDBParameter("XuatHuyet_DichKinh_MT_Text", BenhAnMatChanThuong.XuatHuyet_DichKinh_MT_Text));
            Command.Parameters.Add(new MDB.MDBParameter("VongMac_BenhLy_MP", BenhAnMatChanThuong.VongMac_BenhLy_MP));
            Command.Parameters.Add(new MDB.MDBParameter("VongMac_BenhLy_MT", BenhAnMatChanThuong.VongMac_BenhLy_MT));
            Command.Parameters.Add(new MDB.MDBParameter("VoXuong_HocMat_MP", BenhAnMatChanThuong.VoXuong_HocMat_MP ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("VoXuong_HocMat_Text_MP", BenhAnMatChanThuong.VoXuong_HocMat_Text_MP));
            Command.Parameters.Add(new MDB.MDBParameter("VoXuong_HocMat_MT", BenhAnMatChanThuong.VoXuong_HocMat_MT ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("VoXuong_HocMat_Text_MT", BenhAnMatChanThuong.VoXuong_HocMat_Text_MT));
            Command.Parameters.Add(new MDB.MDBParameter("ViTri_Khau_MP", BenhAnMatChanThuong.ViTri_Khau_MP));
            Command.Parameters.Add(new MDB.MDBParameter("ViTri_Khau_MT", BenhAnMatChanThuong.ViTri_Khau_MT));
            Command.Parameters.Add(new MDB.MDBParameter("ThayBenhLy", BenhAnMatChanThuong.ThayBenhLy ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("ChuaThayBenhLy", BenhAnMatChanThuong.ChuaThayBenhLy ? "1" : "0"));
            int n = Command.ExecuteNonQuery(); // C#
            return n > 0 ? true : false;
        }
        public static bool Update(MDB.MDBConnection MyConnection, BenhAnMatChanThuong BenhAnMatChanThuong)
        {
            string sql = @"UPDATE BenhAnMatChanThuong SET 
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
SupMi_MP = :SupMi_MP,
SupMi_MP_Text = :SupMi_MP_Text,
RachMi_MP = :RachMi_MP,
RachMi_Khau_MP = :RachMi_Khau_MP,
LeQuan_MP = :LeQuan_MP,
LeQuan_ID_MP = :LeQuan_ID_MP,
SeoMi_MP = :SeoMi_MP,
SeoMi_MP_Text = :SeoMi_MP_Text,
CacTonThuongKhac_MiMat_MP = :CacTonThuongKhac_MiMat_MP,
KetMac_MP = :KetMac_MP,
XuatHuyet_MP = :XuatHuyet_MP,
XuatHuyet_MP_Text = :XuatHuyet_MP_Text,
RachKetMac_MP = :RachKetMac_MP,
RachKetMac_MP_Text = :RachKetMac_MP_Text,
ThieuMau_MP = :ThieuMau_MP,
ThieuMau_MP_Text = :ThieuMau_MP_Text,
TonThuongKhac_KetMac_MP = :TonThuongKhac_KetMac_MP,
HinhVeMoTaTonThuongKVV_MP = :HinhVeMoTaTonThuongKVV_MP,
GiacMac_MP = :GiacMac_MP,
GiacMac_Seo_MP = :GiacMac_Seo_MP,
GiacMac_Seo_MP_Text = :GiacMac_Seo_MP_Text,
GiacMac_DiVat_MP = :GiacMac_DiVat_MP,
GiacMac_DiVat_MP_Text = :GiacMac_DiVat_MP_Text,
TuaSauGiacMac_MP = :TuaSauGiacMac_MP,
TuaSauGiacMac_ID_MP = :TuaSauGiacMac_ID_MP,
RachGiacMac_MP = :RachGiacMac_MP,
RachGiacMac_MP_Text = :RachGiacMac_MP_Text,
RachGiacMac_MP_Text2 = :RachGiacMac_MP_Text2,
RachGiacMac_ID_MP = :RachGiacMac_ID_MP,
DaKhauGiacMac_MP = :DaKhauGiacMac_MP,
DungGiaiPhauGiacMac_MP = :DungGiaiPhauGiacMac_MP,
TonThuongKhac_GiacMac_MP = :TonThuongKhac_GiacMac_MP,
CungMac_MP = :CungMac_MP,
RachCungMac_MP = :RachCungMac_MP,
RachCungMac_MP_Text = :RachCungMac_MP_Text,
RachCungMac_MP_Text2 = :RachCungMac_MP_Text2,
DaKhauCungMac_MP = :DaKhauCungMac_MP,
KetToChucCungMac_MP = :KetToChucCungMac_MP,
TonThuongKhac_CungMac_MP = :TonThuongKhac_CungMac_MP,
TienPhong_MP = :TienPhong_MP,
XuatTiet_TienPhong_MP = :XuatTiet_TienPhong_MP,
XuatTiet_TienPhong_Text_MP = :XuatTiet_TienPhong_Text_MP,
DiVat_TienPhong_MP = :DiVat_TienPhong_MP,
DiVat_TienPhong_Text_MP = :DiVat_TienPhong_Text_MP,
TonThuongKhac_TienPhong_MP = :TonThuongKhac_TienPhong_MP,
MongMat_MP = :MongMat_MP,
DutChanMongMat_MP = :DutChanMongMat_MP,
DutChanMongMat_Text_MP = :DutChanMongMat_Text_MP,
MatMongMat_MP = :MatMongMat_MP,
MatMongMat_Text_MP = :MatMongMat_Text_MP,
ThungMongMat_MP = :ThungMongMat_MP,
ThungMongMat_Text_MP = :ThungMongMat_Text_MP,
KichThuoc_DongTu_MP = :KichThuoc_DongTu_MP,
PXDT_MP = :PXDT_MP,
TronMeo_DongTu_MP = :TronMeo_DongTu_MP,
Dinh_DongTu_MP = :Dinh_DongTu_MP,
ViTri_DongTu_MP = :ViTri_DongTu_MP,
GianLiet_DongTu_MP = :GianLiet_DongTu_MP,
AnhDongTu_MP = :AnhDongTu_MP,
KhongQuanSatDuoc_ADT_MP = :KhongQuanSatDuoc_ADT_MP,
TheThuyTinh_MP = :TheThuyTinh_MP,
DiVat_TheThuyTinh_MP = :DiVat_TheThuyTinh_MP,
SaLech_TheThuyTinh_MP = :SaLech_TheThuyTinh_MP,
SaLechID_TheThuyTinh_MP = :SaLechID_TheThuyTinh_MP,
ViemMu_TheThuyTinh_MP = :ViemMu_TheThuyTinh_MP,
DaDatIOL_TheThuyTinh_MP = :DaDatIOL_TheThuyTinh_MP,
DaDatIOL_TheThuyTinh_Text_MP = :DaDatIOL_TheThuyTinh_Text_MP,
TonThuongKhac_TheThuyTinh_MP = :TonThuongKhac_TheThuyTinh_MP,
Duc_DichKinh_MP = :Duc_DichKinh_MP,
ViemMu_DichKinh_MP = :ViemMu_DichKinh_MP,
XuatHuyet_DichKinh_MP = :XuatHuyet_DichKinh_MP,
ToChucHoa_DichKinh_MP = :ToChucHoa_DichKinh_MP,
Bong_DichKinh_MP = :Bong_DichKinh_MP,
DiVat_DichKinh_MP = :DiVat_DichKinh_MP,
TonThuongKhac_DichKinh_MP = :TonThuongKhac_DichKinh_MP,
HeMach_DichKinh_MP = :HeMach_DichKinh_MP,
DiaThi_DichKinh_MP = :DiaThi_DichKinh_MP,
Phu_VongMac_MP = :Phu_VongMac_MP,
Phu_VongMac_Text_MP = :Phu_VongMac_Text_MP,
XuatHuyet_VongMac_MP = :XuatHuyet_VongMac_MP,
XuatHuyet_VongMac_Text_MP = :XuatHuyet_VongMac_Text_MP,
Bong_VongMac_MP = :Bong_VongMac_MP,
Bong_VongMac_Text_MP = :Bong_VongMac_Text_MP,
Rach_VongMac_MP = :Rach_VongMac_MP,
Rach_VongMac_Text_MP = :Rach_VongMac_Text_MP,
ViTriRach_VongMac_Text_MP = :ViTriRach_VongMac_Text_MP,
HinhThaiRach_VongMac_Text_MP = :HinhThaiRach_VongMac_Text_MP,
DiVat_VongMac_MP = :DiVat_VongMac_MP,
DiVat_VongMac_Text_MP = :DiVat_VongMac_Text_MP,
DiVat_VongMac_Text2_MP = :DiVat_VongMac_Text2_MP,
TonThuongKhac_VongMac_MP = :TonThuongKhac_VongMac_MP,
HocMat_MP = :HocMat_MP,
HocMat_Text_MP = :HocMat_Text_MP,
DiVat_HocMat_MP = :DiVat_HocMat_MP,
DiVat_HocMat_Text_MP = :DiVat_HocMat_Text_MP,
VanNhan_MP = :VanNhan_MP,
VanNhan_Text_MP = :VanNhan_Text_MP,
NhanCau_MP = :NhanCau_MP,
NhanCau_Text_MP = :NhanCau_Text_MP,
MiMat_MT = :MiMat_MT,
SupMi_MT = :SupMi_MT,
SupMi_MT_Text = :SupMi_MT_Text,
RachMi_MT = :RachMi_MT,
RachMi_Khau_MT = :RachMi_Khau_MT,
LeQuan_MT = :LeQuan_MT,
LeQuan_ID_MT = :LeQuan_ID_MT,
SeoMi_MT = :SeoMi_MT,
SeoMi_MT_Text = :SeoMi_MT_Text,
CacTonThuongKhac_MiMat_MT = :CacTonThuongKhac_MiMat_MT,
KetMac_MT = :KetMac_MT,
XuatHuyet_MT = :XuatHuyet_MT,
XuatHuyet_MT_Text = :XuatHuyet_MT_Text,
RachKetMac_MT = :RachKetMac_MT,
RachKetMac_MT_Text = :RachKetMac_MT_Text,
ThieuMau_MT = :ThieuMau_MT,
ThieuMau_MT_Text = :ThieuMau_MT_Text,
TonThuongKhac_KetMac_MT = :TonThuongKhac_KetMac_MT,
HinhVeMoTaTonThuongKVV_MT = :HinhVeMoTaTonThuongKVV_MT,
GiacMac_MT = :GiacMac_MT,
GiacMac_Seo_MT = :GiacMac_Seo_MT,
GiacMac_Seo_MT_Text = :GiacMac_Seo_MT_Text,
GiacMac_DiVat_MT = :GiacMac_DiVat_MT,
GiacMac_DiVat_MT_Text = :GiacMac_DiVat_MT_Text,
TuaSauGiacMac_MT = :TuaSauGiacMac_MT,
TuaSauGiacMac_ID_MT = :TuaSauGiacMac_ID_MT,
RachGiacMac_MT = :RachGiacMac_MT,
RachGiacMac_MT_Text = :RachGiacMac_MT_Text,
RachGiacMac_MT_Text2 = :RachGiacMac_MT_Text2,
RachGiacMac_ID_MT = :RachGiacMac_ID_MT,
DaKhauGiacMac_MT = :DaKhauGiacMac_MT,
DungGiaiPhauGiacMac_MT = :DungGiaiPhauGiacMac_MT,
TonThuongKhac_GiacMac_MT = :TonThuongKhac_GiacMac_MT,
CungMac_MT = :CungMac_MT,
RachCungMac_MT = :RachCungMac_MT,
RachCungMac_MT_Text = :RachCungMac_MT_Text,
RachCungMac_MT_Text2 = :RachCungMac_MT_Text2,
DaKhauCungMac_MT = :DaKhauCungMac_MT,
KetToChucCungMac_MT = :KetToChucCungMac_MT,
TonThuongKhac_CungMac_MT = :TonThuongKhac_CungMac_MT,
TienPhong_MT = :TienPhong_MT,
XuatTiet_TienPhong_MT = :XuatTiet_TienPhong_MT,
XuatTiet_TienPhong_Text_MT = :XuatTiet_TienPhong_Text_MT,
DiVat_TienPhong_MT = :DiVat_TienPhong_MT,
DiVat_TienPhong_Text_MT = :DiVat_TienPhong_Text_MT,
TonThuongKhac_TienPhong_MT = :TonThuongKhac_TienPhong_MT,
MongMat_MT = :MongMat_MT,
DutChanMongMat_MT = :DutChanMongMat_MT,
DutChanMongMat_Text_MT = :DutChanMongMat_Text_MT,
MatMongMat_MT = :MatMongMat_MT,
MatMongMat_Text_MT = :MatMongMat_Text_MT,
ThungMongMat_MT = :ThungMongMat_MT,
ThungMongMat_Text_MT = :ThungMongMat_Text_MT,
KichThuoc_DongTu_MT = :KichThuoc_DongTu_MT,
PXDT_MT = :PXDT_MT,
TronMeo_DongTu_MT = :TronMeo_DongTu_MT,
Dinh_DongTu_MT = :Dinh_DongTu_MT,
ViTri_DongTu_MT = :ViTri_DongTu_MT,
GianLiet_DongTu_MT = :GianLiet_DongTu_MT,
AnhDongTu_MT = :AnhDongTu_MT,
KhongQuanSatDuoc_ADT_MT = :KhongQuanSatDuoc_ADT_MT,
TheThuyTinh_MT = :TheThuyTinh_MT,
DiVat_TheThuyTinh_MT = :DiVat_TheThuyTinh_MT,
SaLech_TheThuyTinh_MT = :SaLech_TheThuyTinh_MT,
SaLechID_TheThuyTinh_MT = :SaLechID_TheThuyTinh_MT,
ViemMu_TheThuyTinh_MT = :ViemMu_TheThuyTinh_MT,
DaDatIOL_TheThuyTinh_MT = :DaDatIOL_TheThuyTinh_MT,
DaDatIOL_TheThuyTinh_Text_MT = :DaDatIOL_TheThuyTinh_Text_MT,
TonThuongKhac_TheThuyTinh_MT = :TonThuongKhac_TheThuyTinh_MT,
Duc_DichKinh_MT = :Duc_DichKinh_MT,
ViemMu_DichKinh_MT = :ViemMu_DichKinh_MT,
XuatHuyet_DichKinh_MT = :XuatHuyet_DichKinh_MT,
ToChucHoa_DichKinh_MT = :ToChucHoa_DichKinh_MT,
Bong_DichKinh_MT = :Bong_DichKinh_MT,
DiVat_DichKinh_MT = :DiVat_DichKinh_MT,
TonThuongKhac_DichKinh_MT = :TonThuongKhac_DichKinh_MT,
HeMach_DichKinh_MT = :HeMach_DichKinh_MT,
DiaThi_DichKinh_MT = :DiaThi_DichKinh_MT,
Phu_VongMac_MT = :Phu_VongMac_MT,
Phu_VongMac_Text_MT = :Phu_VongMac_Text_MT,
XuatHuyet_VongMac_MT = :XuatHuyet_VongMac_MT,
XuatHuyet_VongMac_Text_MT = :XuatHuyet_VongMac_Text_MT,
Bong_VongMac_MT = :Bong_VongMac_MT,
Bong_VongMac_Text_MT = :Bong_VongMac_Text_MT,
Rach_VongMac_MT = :Rach_VongMac_MT,
Rach_VongMac_Text_MT = :Rach_VongMac_Text_MT,
ViTriRach_VongMac_Text_MT = :ViTriRach_VongMac_Text_MT,
HinhThaiRach_VongMac_Text_MT = :HinhThaiRach_VongMac_Text_MT,
DiVat_VongMac_MT = :DiVat_VongMac_MT,
DiVat_VongMac_Text_MT = :DiVat_VongMac_Text_MT,
DiVat_VongMac_Text2_MT = :DiVat_VongMac_Text2_MT,
TonThuongKhac_VongMac_MT = :TonThuongKhac_VongMac_MT,
HocMat_MT = :HocMat_MT,
HocMat_Text_MT = :HocMat_Text_MT,
DiVat_HocMat_MT = :DiVat_HocMat_MT,
DiVat_HocMat_Text_MT = :DiVat_HocMat_Text_MT,
VanNhan_MT = :VanNhan_MT,
VanNhan_Text_MT = :VanNhan_Text_MT,
NhanCau_MT = :NhanCau_MT,
NhanCau_Text_MT = :NhanCau_Text_MT,
HinhVe_VongMac_MP = :HinhVe_VongMac_MP,
HinhVe_VongMac_MT = :HinhVe_VongMac_MT,
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
TuaMoi_MP = :TuaMoi_MP, 
TuaMoi_MP_Text = :TuaMoi_MP_Text, 
TuaMoi_MT = :TuaMoi_MT, 
TuaMoi_MT_Text = :TuaMoi_MT_Text, 
TuaCu_MP = :TuaCu_MP, 
TuaCu_MP_Text = :TuaCu_MP_Text, 
TuaCu_MT = :TuaCu_MT, 
TuaCu_MT_Text = :TuaCu_MT_Text,
TienPhongMP_Sau_Text = :TienPhongMP_Sau_Text,
TienPhongMP_Mu_Text = :TienPhongMP_Mu_Text,
TienPhongMP_XuatTiet_Text = :TienPhongMP_XuatTiet_Text,
TienPhongMP_Tydall_Text = :TienPhongMP_Tydall_Text,
TienPhongMT_Sau_Text = :TienPhongMT_Sau_Text,
TienPhongMT_Mu_Text = :TienPhongMT_Mu_Text,
TienPhongMT_XuatTiet_Text = :TienPhongMT_XuatTiet_Text,
TienPhongMT_Tydall_Text = :TienPhongMT_Tydall_Text,  
Trong_DichKinh_MP = :Trong_DichKinh_MP,
Duc_DichKinh_MP_Text = :Duc_DichKinh_MP_Text,
XuatHuyet_DichKinh_MP_Text = :XuatHuyet_DichKinh_MP_Text,
Trong_DichKinh_MT = :Trong_DichKinh_MT,
Duc_DichKinh_MT_Text = :Duc_DichKinh_MT_Text,
XuatHuyet_DichKinh_MT_Text = :XuatHuyet_DichKinh_MT_Text,
VongMac_BenhLy_MP = :VongMac_BenhLy_MP,
VongMac_BenhLy_MT = :VongMac_BenhLy_MT,
VoXuong_HocMat_MP = :VoXuong_HocMat_MP,
VoXuong_HocMat_Text_MP = :VoXuong_HocMat_Text_MP,
VoXuong_HocMat_MT = :VoXuong_HocMat_MT,
VoXuong_HocMat_Text_MT = :VoXuong_HocMat_Text_MT,
ViTri_Khau_MP = :ViTri_Khau_MP,
ViTri_Khau_MT = :ViTri_Khau_MT,
ThayBenhLy = :ThayBenhLy,
ChuaThayBenhLy = :ChuaThayBenhLy

                        WHERE MaQuanLy = :MaQuanLy";
            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
            Command.Parameters.Add(new MDB.MDBParameter("LyDoVaoVien", BenhAnMatChanThuong.LyDoVaoVien));
            Command.Parameters.Add(new MDB.MDBParameter("VaoNgayThu", BenhAnMatChanThuong.VaoNgayThu));
            Command.Parameters.Add(new MDB.MDBParameter("QuaTrinhBenhLy", BenhAnMatChanThuong.QuaTrinhBenhLy));
            Command.Parameters.Add(new MDB.MDBParameter("TienSuBenhBanThan", BenhAnMatChanThuong.TienSuBenhBanThan));
            Command.Parameters.Add(new MDB.MDBParameter("TienSuBenhGiaDinh", BenhAnMatChanThuong.TienSuBenhGiaDinh));
            Command.Parameters.Add(new MDB.MDBParameter("ToanThan", BenhAnMatChanThuong.ToanThan));
            Command.Parameters.Add(new MDB.MDBParameter("TuanHoan", BenhAnMatChanThuong.TuanHoan));
            Command.Parameters.Add(new MDB.MDBParameter("HoHap", BenhAnMatChanThuong.HoHap));
            Command.Parameters.Add(new MDB.MDBParameter("TieuHoa", BenhAnMatChanThuong.TieuHoa));
            Command.Parameters.Add(new MDB.MDBParameter("ThanTietNieuSinhDuc", BenhAnMatChanThuong.ThanTietNieuSinhDuc));
            Command.Parameters.Add(new MDB.MDBParameter("ThanKinh", BenhAnMatChanThuong.ThanKinh));
            Command.Parameters.Add(new MDB.MDBParameter("CoXuongKhop", BenhAnMatChanThuong.CoXuongKhop));
            Command.Parameters.Add(new MDB.MDBParameter("TaiMuiHong", BenhAnMatChanThuong.TaiMuiHong));
            Command.Parameters.Add(new MDB.MDBParameter("RangHamMat", BenhAnMatChanThuong.RangHamMat));
            Command.Parameters.Add(new MDB.MDBParameter("Mat", BenhAnMatChanThuong.Mat));
            Command.Parameters.Add(new MDB.MDBParameter("Khac_CacCoQuan", BenhAnMatChanThuong.Khac_CacCoQuan));
            Command.Parameters.Add(new MDB.MDBParameter("CacXetNghiemCanLamSangCanLam", BenhAnMatChanThuong.CacXetNghiemCanLamSangCanLam));
            Command.Parameters.Add(new MDB.MDBParameter("TomTatBenhAn", BenhAnMatChanThuong.TomTatBenhAn));
            Command.Parameters.Add(new MDB.MDBParameter("BenhChinh", BenhAnMatChanThuong.BenhChinh));
            Command.Parameters.Add(new MDB.MDBParameter("BenhKemTheo", BenhAnMatChanThuong.BenhKemTheo));
            Command.Parameters.Add(new MDB.MDBParameter("PhanBiet", BenhAnMatChanThuong.PhanBiet));
            Command.Parameters.Add(new MDB.MDBParameter("TienLuong", BenhAnMatChanThuong.TienLuong));
            Command.Parameters.Add(new MDB.MDBParameter("HuongDieuTri", BenhAnMatChanThuong.HuongDieuTri));
            Command.Parameters.Add(new MDB.MDBParameter("NgayKhamBenh", BenhAnMatChanThuong.NgayKhamBenh));
            Command.Parameters.Add(new MDB.MDBParameter("BacSyLamBenhAn", BenhAnMatChanThuong.BacSyLamBenhAn));
            Command.Parameters.Add(new MDB.MDBParameter("QuaTrinhBenhLyVaDienBien", BenhAnMatChanThuong.QuaTrinhBenhLyVaDienBien));
            Command.Parameters.Add(new MDB.MDBParameter("TomTatKetQuaXetNghiem", BenhAnMatChanThuong.TomTatKetQuaXetNghiem));
            Command.Parameters.Add(new MDB.MDBParameter("PhuongPhapDieuTri", BenhAnMatChanThuong.PhuongPhapDieuTri));
            Command.Parameters.Add(new MDB.MDBParameter("TinhTrangNguoiBenhRaVien", BenhAnMatChanThuong.TinhTrangNguoiBenhRaVien));
            Command.Parameters.Add(new MDB.MDBParameter("HuongDieuTriVaCacCheDoTiepTheo", BenhAnMatChanThuong.HuongDieuTriVaCacCheDoTiepTheo));
            Command.Parameters.Add(new MDB.MDBParameter("NguoiNhanHoSo", BenhAnMatChanThuong.NguoiNhanHoSo));
            Command.Parameters.Add(new MDB.MDBParameter("NguoiGiaoHoSo", BenhAnMatChanThuong.NguoiGiaoHoSo));
            Command.Parameters.Add(new MDB.MDBParameter("NgayTongKet", BenhAnMatChanThuong.NgayTongKet));
            Command.Parameters.Add(new MDB.MDBParameter("BacSyDieuTri", BenhAnMatChanThuong.BacSyDieuTri));
            Command.Parameters.Add(new MDB.MDBParameter("DiUng", BenhAnMatChanThuong.DacDiemLienQuanBenh.DiUng == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("DiUng_Text", BenhAnMatChanThuong.DacDiemLienQuanBenh.DiUng_Text));
            Command.Parameters.Add(new MDB.MDBParameter("MaTuy", BenhAnMatChanThuong.DacDiemLienQuanBenh.MaTuy == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("MaTuy_Text", BenhAnMatChanThuong.DacDiemLienQuanBenh.MaTuy_Text));
            Command.Parameters.Add(new MDB.MDBParameter("RuouBia", BenhAnMatChanThuong.DacDiemLienQuanBenh.RuouBia == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("RuouBia_Text", BenhAnMatChanThuong.DacDiemLienQuanBenh.RuouBia_Text));
            Command.Parameters.Add(new MDB.MDBParameter("ThuocLa", BenhAnMatChanThuong.DacDiemLienQuanBenh.ThuocLa == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("ThuocLa_Text", BenhAnMatChanThuong.DacDiemLienQuanBenh.ThuocLa_Text));
            Command.Parameters.Add(new MDB.MDBParameter("ThuocLao", BenhAnMatChanThuong.DacDiemLienQuanBenh.ThuocLao == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("ThuocLao_Text", BenhAnMatChanThuong.DacDiemLienQuanBenh.ThuocLao_Text));
            Command.Parameters.Add(new MDB.MDBParameter("Khac_DacDiemLienQuanBenh", BenhAnMatChanThuong.DacDiemLienQuanBenh.Khac_DacDiemLienQuanBenh == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("Khac_DacDiemLienQuanBenh_Text", BenhAnMatChanThuong.DacDiemLienQuanBenh.Khac_DacDiemLienQuanBenh_Text));
            Command.Parameters.Add(new MDB.MDBParameter("ThiLucKhiVaoVien_KhongKinh_MP", BenhAnMatChanThuong.ThiLucKhiVaoVien_KhongKinh_MP));
            Command.Parameters.Add(new MDB.MDBParameter("ThiLucKhiVaoVien_KhongKinh_MT", BenhAnMatChanThuong.ThiLucKhiVaoVien_KhongKinh_MT));
            Command.Parameters.Add(new MDB.MDBParameter("ThiLucKhiVaoVien_CoKinh_MP", BenhAnMatChanThuong.ThiLucKhiVaoVien_CoKinh_MP));
            Command.Parameters.Add(new MDB.MDBParameter("ThiLucKhiVaoVien_CoKinh_MT", BenhAnMatChanThuong.ThiLucKhiVaoVien_CoKinh_MT));
            Command.Parameters.Add(new MDB.MDBParameter("NhanApVaoVien_MT", BenhAnMatChanThuong.NhanApVaoVien_MT));
            Command.Parameters.Add(new MDB.MDBParameter("NhanApVaoVien_MP", BenhAnMatChanThuong.NhanApVaoVien_MP));
            Command.Parameters.Add(new MDB.MDBParameter("ThiTruong_MP", BenhAnMatChanThuong.ThiTruong_MP));
            Command.Parameters.Add(new MDB.MDBParameter("ThiTruong_MT", BenhAnMatChanThuong.ThiTruong_MT));
            Command.Parameters.Add(new MDB.MDBParameter("MiMat_MP", BenhAnMatChanThuong.MiMat_MP));
            Command.Parameters.Add(new MDB.MDBParameter("SupMi_MP", BenhAnMatChanThuong.SupMi_MP == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("SupMi_MP_Text", BenhAnMatChanThuong.SupMi_MP_Text));
            Command.Parameters.Add(new MDB.MDBParameter("RachMi_MP", BenhAnMatChanThuong.RachMi_MP));
            Command.Parameters.Add(new MDB.MDBParameter("RachMi_Khau_MP", BenhAnMatChanThuong.RachMi_Khau_MP));
            Command.Parameters.Add(new MDB.MDBParameter("LeQuan_MP", BenhAnMatChanThuong.LeQuan_MP));
            Command.Parameters.Add(new MDB.MDBParameter("LeQuan_ID_MP", BenhAnMatChanThuong.LeQuan_ID_MP));
            Command.Parameters.Add(new MDB.MDBParameter("SeoMi_MP", BenhAnMatChanThuong.SeoMi_MP == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("SeoMi_MP_Text", BenhAnMatChanThuong.SeoMi_MP_Text));
            Command.Parameters.Add(new MDB.MDBParameter("CacTonThuongKhac_MiMat_MP", BenhAnMatChanThuong.CacTonThuongKhac_MiMat_MP));
            Command.Parameters.Add(new MDB.MDBParameter("KetMac_MP", BenhAnMatChanThuong.KetMac_MP));
            Command.Parameters.Add(new MDB.MDBParameter("XuatHuyet_MP", BenhAnMatChanThuong.XuatHuyet_MP == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("XuatHuyet_MP_Text", BenhAnMatChanThuong.XuatHuyet_MP_Text));
            Command.Parameters.Add(new MDB.MDBParameter("RachKetMac_MP", BenhAnMatChanThuong.RachKetMac_MP == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("RachKetMac_MP_Text", BenhAnMatChanThuong.RachKetMac_MP_Text));
            Command.Parameters.Add(new MDB.MDBParameter("ThieuMau_MP", BenhAnMatChanThuong.ThieuMau_MP == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("ThieuMau_MP_Text", BenhAnMatChanThuong.ThieuMau_MP_Text));
            Command.Parameters.Add(new MDB.MDBParameter("TonThuongKhac_KetMac_MP", BenhAnMatChanThuong.TonThuongKhac_KetMac_MP));
            Command.Parameters.Add(new MDB.MDBParameter("HinhVeMoTaTonThuongKVV_MP", BenhAnMatChanThuong.HinhVeMoTaTonThuongKVV_MP));
            Command.Parameters.Add(new MDB.MDBParameter("GiacMac_MP", BenhAnMatChanThuong.GiacMac_MP));
            Command.Parameters.Add(new MDB.MDBParameter("GiacMac_Seo_MP", BenhAnMatChanThuong.GiacMac_Seo_MP == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("GiacMac_Seo_MP_Text", BenhAnMatChanThuong.GiacMac_Seo_MP_Text));
            Command.Parameters.Add(new MDB.MDBParameter("GiacMac_DiVat_MP", BenhAnMatChanThuong.GiacMac_DiVat_MP == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("GiacMac_DiVat_MP_Text", BenhAnMatChanThuong.GiacMac_DiVat_MP_Text));
            Command.Parameters.Add(new MDB.MDBParameter("TuaSauGiacMac_MP", BenhAnMatChanThuong.TuaSauGiacMac_MP));
            Command.Parameters.Add(new MDB.MDBParameter("TuaSauGiacMac_ID_MP", BenhAnMatChanThuong.TuaSauGiacMac_ID_MP));
            Command.Parameters.Add(new MDB.MDBParameter("RachGiacMac_MP", BenhAnMatChanThuong.RachGiacMac_MP == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("RachGiacMac_MP_Text", BenhAnMatChanThuong.RachGiacMac_MP_Text));
            Command.Parameters.Add(new MDB.MDBParameter("RachGiacMac_MP_Text2", BenhAnMatChanThuong.RachGiacMac_MP_Text2));
            Command.Parameters.Add(new MDB.MDBParameter("RachGiacMac_ID_MP", BenhAnMatChanThuong.RachGiacMac_ID_MP));
            Command.Parameters.Add(new MDB.MDBParameter("DaKhauGiacMac_MP", BenhAnMatChanThuong.DaKhauGiacMac_MP == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("DungGiaiPhauGiacMac_MP", BenhAnMatChanThuong.DungGiaiPhauGiacMac_MP));
            Command.Parameters.Add(new MDB.MDBParameter("TonThuongKhac_GiacMac_MP", BenhAnMatChanThuong.TonThuongKhac_GiacMac_MP));
            Command.Parameters.Add(new MDB.MDBParameter("CungMac_MP", BenhAnMatChanThuong.CungMac_MP));
            Command.Parameters.Add(new MDB.MDBParameter("RachCungMac_MP", BenhAnMatChanThuong.RachCungMac_MP == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("RachCungMac_MP_Text", BenhAnMatChanThuong.RachCungMac_MP_Text));
            Command.Parameters.Add(new MDB.MDBParameter("RachCungMac_MP_Text2", BenhAnMatChanThuong.RachCungMac_MP_Text2));
            Command.Parameters.Add(new MDB.MDBParameter("DaKhauCungMac_MP", BenhAnMatChanThuong.DaKhauCungMac_MP));
            Command.Parameters.Add(new MDB.MDBParameter("KetToChucCungMac_MP", BenhAnMatChanThuong.KetToChucCungMac_MP == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("TonThuongKhac_CungMac_MP", BenhAnMatChanThuong.TonThuongKhac_CungMac_MP));
            Command.Parameters.Add(new MDB.MDBParameter("TienPhong_MP", BenhAnMatChanThuong.TienPhong_MP));
            Command.Parameters.Add(new MDB.MDBParameter("XuatTiet_TienPhong_MP", BenhAnMatChanThuong.XuatTiet_TienPhong_MP == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("XuatTiet_TienPhong_Text_MP", BenhAnMatChanThuong.XuatTiet_TienPhong_Text_MP));
            Command.Parameters.Add(new MDB.MDBParameter("DiVat_TienPhong_MP", BenhAnMatChanThuong.DiVat_TienPhong_MP == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("DiVat_TienPhong_Text_MP", BenhAnMatChanThuong.DiVat_TienPhong_Text_MP));
            Command.Parameters.Add(new MDB.MDBParameter("TonThuongKhac_TienPhong_MP", BenhAnMatChanThuong.TonThuongKhac_TienPhong_MP));
            Command.Parameters.Add(new MDB.MDBParameter("MongMat_MP", BenhAnMatChanThuong.MongMat_MP));
            Command.Parameters.Add(new MDB.MDBParameter("DutChanMongMat_MP", BenhAnMatChanThuong.DutChanMongMat_MP == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("DutChanMongMat_Text_MP", BenhAnMatChanThuong.DutChanMongMat_Text_MP));
            Command.Parameters.Add(new MDB.MDBParameter("MatMongMat_MP", BenhAnMatChanThuong.MatMongMat_MP == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("MatMongMat_Text_MP", BenhAnMatChanThuong.MatMongMat_Text_MP));
            Command.Parameters.Add(new MDB.MDBParameter("ThungMongMat_MP", BenhAnMatChanThuong.ThungMongMat_MP == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("ThungMongMat_Text_MP", BenhAnMatChanThuong.ThungMongMat_Text_MP));
            Command.Parameters.Add(new MDB.MDBParameter("KichThuoc_DongTu_MP", BenhAnMatChanThuong.KichThuoc_DongTu_MP));
            Command.Parameters.Add(new MDB.MDBParameter("PXDT_MP", BenhAnMatChanThuong.PXDT_MP));
            Command.Parameters.Add(new MDB.MDBParameter("TronMeo_DongTu_MP", BenhAnMatChanThuong.TronMeo_DongTu_MP));
            Command.Parameters.Add(new MDB.MDBParameter("Dinh_DongTu_MP", BenhAnMatChanThuong.Dinh_DongTu_MP == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("ViTri_DongTu_MP", BenhAnMatChanThuong.ViTri_DongTu_MP));
            Command.Parameters.Add(new MDB.MDBParameter("GianLiet_DongTu_MP", BenhAnMatChanThuong.GianLiet_DongTu_MP == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("AnhDongTu_MP", BenhAnMatChanThuong.AnhDongTu_MP));
            Command.Parameters.Add(new MDB.MDBParameter("KhongQuanSatDuoc_ADT_MP", BenhAnMatChanThuong.KhongQuanSatDuoc_ADT_MP == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("TheThuyTinh_MP", BenhAnMatChanThuong.TheThuyTinh_MP));
            Command.Parameters.Add(new MDB.MDBParameter("DiVat_TheThuyTinh_MP", BenhAnMatChanThuong.DiVat_TheThuyTinh_MP == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("SaLech_TheThuyTinh_MP", BenhAnMatChanThuong.SaLech_TheThuyTinh_MP == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("SaLechID_TheThuyTinh_MP", BenhAnMatChanThuong.SaLechID_TheThuyTinh_MP));
            Command.Parameters.Add(new MDB.MDBParameter("ViemMu_TheThuyTinh_MP", BenhAnMatChanThuong.ViemMu_TheThuyTinh_MP == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("DaDatIOL_TheThuyTinh_MP", BenhAnMatChanThuong.DaDatIOL_TheThuyTinh_MP == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("DaDatIOL_TheThuyTinh_Text_MP", BenhAnMatChanThuong.DaDatIOL_TheThuyTinh_Text_MP));
            Command.Parameters.Add(new MDB.MDBParameter("TonThuongKhac_TheThuyTinh_MP", BenhAnMatChanThuong.TonThuongKhac_TheThuyTinh_MP));
            Command.Parameters.Add(new MDB.MDBParameter("Duc_DichKinh_MP", BenhAnMatChanThuong.Duc_DichKinh_MP == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("ViemMu_DichKinh_MP", BenhAnMatChanThuong.ViemMu_DichKinh_MP == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("XuatHuyet_DichKinh_MP", BenhAnMatChanThuong.XuatHuyet_DichKinh_MP == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("ToChucHoa_DichKinh_MP", BenhAnMatChanThuong.ToChucHoa_DichKinh_MP == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("Bong_DichKinh_MP", BenhAnMatChanThuong.Bong_DichKinh_MP == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("DiVat_DichKinh_MP", BenhAnMatChanThuong.DiVat_DichKinh_MP == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("TonThuongKhac_DichKinh_MP", BenhAnMatChanThuong.TonThuongKhac_DichKinh_MP));
            Command.Parameters.Add(new MDB.MDBParameter("HeMach_DichKinh_MP", BenhAnMatChanThuong.HeMach_DichKinh_MP));
            Command.Parameters.Add(new MDB.MDBParameter("DiaThi_DichKinh_MP", BenhAnMatChanThuong.DiaThi_DichKinh_MP));
            Command.Parameters.Add(new MDB.MDBParameter("Phu_VongMac_MP", BenhAnMatChanThuong.Phu_VongMac_MP == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("Phu_VongMac_Text_MP", BenhAnMatChanThuong.Phu_VongMac_Text_MP));
            Command.Parameters.Add(new MDB.MDBParameter("XuatHuyet_VongMac_MP", BenhAnMatChanThuong.XuatHuyet_VongMac_MP == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("XuatHuyet_VongMac_Text_MP", BenhAnMatChanThuong.XuatHuyet_VongMac_Text_MP));
            Command.Parameters.Add(new MDB.MDBParameter("Bong_VongMac_MP", BenhAnMatChanThuong.Bong_VongMac_MP));
            Command.Parameters.Add(new MDB.MDBParameter("Bong_VongMac_Text_MP", BenhAnMatChanThuong.Bong_VongMac_Text_MP));
            Command.Parameters.Add(new MDB.MDBParameter("Rach_VongMac_MP", BenhAnMatChanThuong.Rach_VongMac_MP));
            Command.Parameters.Add(new MDB.MDBParameter("Rach_VongMac_Text_MP", BenhAnMatChanThuong.Rach_VongMac_Text_MP));
            Command.Parameters.Add(new MDB.MDBParameter("ViTriRach_VongMac_Text_MP", BenhAnMatChanThuong.ViTriRach_VongMac_Text_MP));
            Command.Parameters.Add(new MDB.MDBParameter("HinhThaiRach_VongMac_Text_MP", BenhAnMatChanThuong.HinhThaiRach_VongMac_Text_MP));
            Command.Parameters.Add(new MDB.MDBParameter("DiVat_VongMac_MP", BenhAnMatChanThuong.DiVat_VongMac_MP == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("DiVat_VongMac_Text_MP", BenhAnMatChanThuong.DiVat_VongMac_Text_MP));
            Command.Parameters.Add(new MDB.MDBParameter("DiVat_VongMac_Text2_MP", BenhAnMatChanThuong.DiVat_VongMac_Text2_MP));
            Command.Parameters.Add(new MDB.MDBParameter("TonThuongKhac_VongMac_MP", BenhAnMatChanThuong.TonThuongKhac_VongMac_MP));
            Command.Parameters.Add(new MDB.MDBParameter("HocMat_MP", BenhAnMatChanThuong.HocMat_MP));
            Command.Parameters.Add(new MDB.MDBParameter("HocMat_Text_MP", BenhAnMatChanThuong.HocMat_Text_MP));
            Command.Parameters.Add(new MDB.MDBParameter("DiVat_HocMat_MP", BenhAnMatChanThuong.DiVat_HocMat_MP == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("DiVat_HocMat_Text_MP", BenhAnMatChanThuong.DiVat_HocMat_Text_MP));
            Command.Parameters.Add(new MDB.MDBParameter("VanNhan_MP", BenhAnMatChanThuong.VanNhan_MP));
            Command.Parameters.Add(new MDB.MDBParameter("VanNhan_Text_MP", BenhAnMatChanThuong.VanNhan_Text_MP));
            Command.Parameters.Add(new MDB.MDBParameter("NhanCau_MP", BenhAnMatChanThuong.NhanCau_MP));
            Command.Parameters.Add(new MDB.MDBParameter("NhanCau_Text_MP", BenhAnMatChanThuong.NhanCau_Text_MP));
            Command.Parameters.Add(new MDB.MDBParameter("MiMat_MT", BenhAnMatChanThuong.MiMat_MT));
            Command.Parameters.Add(new MDB.MDBParameter("SupMi_MT", BenhAnMatChanThuong.SupMi_MT == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("SupMi_MT_Text", BenhAnMatChanThuong.SupMi_MT_Text));
            Command.Parameters.Add(new MDB.MDBParameter("RachMi_MT", BenhAnMatChanThuong.RachMi_MT));
            Command.Parameters.Add(new MDB.MDBParameter("RachMi_Khau_MT", BenhAnMatChanThuong.RachMi_Khau_MT));
            Command.Parameters.Add(new MDB.MDBParameter("LeQuan_MT", BenhAnMatChanThuong.LeQuan_MT));
            Command.Parameters.Add(new MDB.MDBParameter("LeQuan_ID_MT", BenhAnMatChanThuong.LeQuan_ID_MT));
            Command.Parameters.Add(new MDB.MDBParameter("SeoMi_MT", BenhAnMatChanThuong.SeoMi_MT == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("SeoMi_MT_Text", BenhAnMatChanThuong.SeoMi_MT_Text));
            Command.Parameters.Add(new MDB.MDBParameter("CacTonThuongKhac_MiMat_MT", BenhAnMatChanThuong.CacTonThuongKhac_MiMat_MT));
            Command.Parameters.Add(new MDB.MDBParameter("KetMac_MT", BenhAnMatChanThuong.KetMac_MT));
            Command.Parameters.Add(new MDB.MDBParameter("XuatHuyet_MT", BenhAnMatChanThuong.XuatHuyet_MT == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("XuatHuyet_MT_Text", BenhAnMatChanThuong.XuatHuyet_MT_Text));
            Command.Parameters.Add(new MDB.MDBParameter("RachKetMac_MT", BenhAnMatChanThuong.RachKetMac_MT == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("RachKetMac_MT_Text", BenhAnMatChanThuong.RachKetMac_MT_Text));
            Command.Parameters.Add(new MDB.MDBParameter("ThieuMau_MT", BenhAnMatChanThuong.ThieuMau_MT == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("ThieuMau_MT_Text", BenhAnMatChanThuong.ThieuMau_MT_Text));
            Command.Parameters.Add(new MDB.MDBParameter("TonThuongKhac_KetMac_MT", BenhAnMatChanThuong.TonThuongKhac_KetMac_MT));
            Command.Parameters.Add(new MDB.MDBParameter("HinhVeMoTaTonThuongKVV_MT", BenhAnMatChanThuong.HinhVeMoTaTonThuongKVV_MT));
            Command.Parameters.Add(new MDB.MDBParameter("GiacMac_MT", BenhAnMatChanThuong.GiacMac_MT));
            Command.Parameters.Add(new MDB.MDBParameter("GiacMac_Seo_MT", BenhAnMatChanThuong.GiacMac_Seo_MT == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("GiacMac_Seo_MT_Text", BenhAnMatChanThuong.GiacMac_Seo_MT_Text));
            Command.Parameters.Add(new MDB.MDBParameter("GiacMac_DiVat_MT", BenhAnMatChanThuong.GiacMac_DiVat_MT == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("GiacMac_DiVat_MT_Text", BenhAnMatChanThuong.GiacMac_DiVat_MT_Text));
            Command.Parameters.Add(new MDB.MDBParameter("TuaSauGiacMac_MT", BenhAnMatChanThuong.TuaSauGiacMac_MT));
            Command.Parameters.Add(new MDB.MDBParameter("TuaSauGiacMac_ID_MT", BenhAnMatChanThuong.TuaSauGiacMac_ID_MT));
            Command.Parameters.Add(new MDB.MDBParameter("RachGiacMac_MT", BenhAnMatChanThuong.RachGiacMac_MT == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("RachGiacMac_MT_Text", BenhAnMatChanThuong.RachGiacMac_MT_Text));
            Command.Parameters.Add(new MDB.MDBParameter("RachGiacMac_MT_Text2", BenhAnMatChanThuong.RachGiacMac_MT_Text2));
            Command.Parameters.Add(new MDB.MDBParameter("RachGiacMac_ID_MT", BenhAnMatChanThuong.RachGiacMac_ID_MT));
            Command.Parameters.Add(new MDB.MDBParameter("DaKhauGiacMac_MT", BenhAnMatChanThuong.DaKhauGiacMac_MT == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("DungGiaiPhauGiacMac_MT", BenhAnMatChanThuong.DungGiaiPhauGiacMac_MT));
            Command.Parameters.Add(new MDB.MDBParameter("TonThuongKhac_GiacMac_MT", BenhAnMatChanThuong.TonThuongKhac_GiacMac_MT));
            Command.Parameters.Add(new MDB.MDBParameter("CungMac_MT", BenhAnMatChanThuong.CungMac_MT));
            Command.Parameters.Add(new MDB.MDBParameter("RachCungMac_MT", BenhAnMatChanThuong.RachCungMac_MT == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("RachCungMac_MT_Text", BenhAnMatChanThuong.RachCungMac_MT_Text));
            Command.Parameters.Add(new MDB.MDBParameter("RachCungMac_MT_Text2", BenhAnMatChanThuong.RachCungMac_MT_Text2));
            Command.Parameters.Add(new MDB.MDBParameter("DaKhauCungMac_MT", BenhAnMatChanThuong.DaKhauCungMac_MT));
            Command.Parameters.Add(new MDB.MDBParameter("KetToChucCungMac_MT", BenhAnMatChanThuong.KetToChucCungMac_MT == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("TonThuongKhac_CungMac_MT", BenhAnMatChanThuong.TonThuongKhac_CungMac_MT));
            Command.Parameters.Add(new MDB.MDBParameter("TienPhong_MT", BenhAnMatChanThuong.TienPhong_MT));
            Command.Parameters.Add(new MDB.MDBParameter("XuatTiet_TienPhong_MT", BenhAnMatChanThuong.XuatTiet_TienPhong_MT == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("XuatTiet_TienPhong_Text_MT", BenhAnMatChanThuong.XuatTiet_TienPhong_Text_MT));
            Command.Parameters.Add(new MDB.MDBParameter("DiVat_TienPhong_MT", BenhAnMatChanThuong.DiVat_TienPhong_MT == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("DiVat_TienPhong_Text_MT", BenhAnMatChanThuong.DiVat_TienPhong_Text_MT));
            Command.Parameters.Add(new MDB.MDBParameter("TonThuongKhac_TienPhong_MT", BenhAnMatChanThuong.TonThuongKhac_TienPhong_MT));
            Command.Parameters.Add(new MDB.MDBParameter("MongMat_MT", BenhAnMatChanThuong.MongMat_MT));
            Command.Parameters.Add(new MDB.MDBParameter("DutChanMongMat_MT", BenhAnMatChanThuong.DutChanMongMat_MT == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("DutChanMongMat_Text_MT", BenhAnMatChanThuong.DutChanMongMat_Text_MT));
            Command.Parameters.Add(new MDB.MDBParameter("MatMongMat_MT", BenhAnMatChanThuong.MatMongMat_MT == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("MatMongMat_Text_MT", BenhAnMatChanThuong.MatMongMat_Text_MT));
            Command.Parameters.Add(new MDB.MDBParameter("ThungMongMat_MT", BenhAnMatChanThuong.ThungMongMat_MT == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("ThungMongMat_Text_MT", BenhAnMatChanThuong.ThungMongMat_Text_MT));
            Command.Parameters.Add(new MDB.MDBParameter("KichThuoc_DongTu_MT", BenhAnMatChanThuong.KichThuoc_DongTu_MT));
            Command.Parameters.Add(new MDB.MDBParameter("PXDT_MT", BenhAnMatChanThuong.PXDT_MT));
            Command.Parameters.Add(new MDB.MDBParameter("TronMeo_DongTu_MT", BenhAnMatChanThuong.TronMeo_DongTu_MT));
            Command.Parameters.Add(new MDB.MDBParameter("Dinh_DongTu_MT", BenhAnMatChanThuong.Dinh_DongTu_MT == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("ViTri_DongTu_MT", BenhAnMatChanThuong.ViTri_DongTu_MT));
            Command.Parameters.Add(new MDB.MDBParameter("GianLiet_DongTu_MT", BenhAnMatChanThuong.GianLiet_DongTu_MT == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("AnhDongTu_MT", BenhAnMatChanThuong.AnhDongTu_MT));
            Command.Parameters.Add(new MDB.MDBParameter("KhongQuanSatDuoc_ADT_MT", BenhAnMatChanThuong.KhongQuanSatDuoc_ADT_MT == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("TheThuyTinh_MT", BenhAnMatChanThuong.TheThuyTinh_MT));
            Command.Parameters.Add(new MDB.MDBParameter("DiVat_TheThuyTinh_MT", BenhAnMatChanThuong.DiVat_TheThuyTinh_MT == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("SaLech_TheThuyTinh_MT", BenhAnMatChanThuong.SaLech_TheThuyTinh_MT == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("SaLechID_TheThuyTinh_MT", BenhAnMatChanThuong.SaLechID_TheThuyTinh_MT));
            Command.Parameters.Add(new MDB.MDBParameter("ViemMu_TheThuyTinh_MT", BenhAnMatChanThuong.ViemMu_TheThuyTinh_MT == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("DaDatIOL_TheThuyTinh_MT", BenhAnMatChanThuong.DaDatIOL_TheThuyTinh_MT == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("DaDatIOL_TheThuyTinh_Text_MT", BenhAnMatChanThuong.DaDatIOL_TheThuyTinh_Text_MT));
            Command.Parameters.Add(new MDB.MDBParameter("TonThuongKhac_TheThuyTinh_MT", BenhAnMatChanThuong.TonThuongKhac_TheThuyTinh_MT));
            Command.Parameters.Add(new MDB.MDBParameter("Duc_DichKinh_MT", BenhAnMatChanThuong.Duc_DichKinh_MT == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("ViemMu_DichKinh_MT", BenhAnMatChanThuong.ViemMu_DichKinh_MT == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("XuatHuyet_DichKinh_MT", BenhAnMatChanThuong.XuatHuyet_DichKinh_MT == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("ToChucHoa_DichKinh_MT", BenhAnMatChanThuong.ToChucHoa_DichKinh_MT == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("Bong_DichKinh_MT", BenhAnMatChanThuong.Bong_DichKinh_MT == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("DiVat_DichKinh_MT", BenhAnMatChanThuong.DiVat_DichKinh_MT == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("TonThuongKhac_DichKinh_MT", BenhAnMatChanThuong.TonThuongKhac_DichKinh_MT));
            Command.Parameters.Add(new MDB.MDBParameter("HeMach_DichKinh_MT", BenhAnMatChanThuong.HeMach_DichKinh_MT));
            Command.Parameters.Add(new MDB.MDBParameter("DiaThi_DichKinh_MT", BenhAnMatChanThuong.DiaThi_DichKinh_MT));
            Command.Parameters.Add(new MDB.MDBParameter("Phu_VongMac_MT", BenhAnMatChanThuong.Phu_VongMac_MT == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("Phu_VongMac_Text_MT", BenhAnMatChanThuong.Phu_VongMac_Text_MT));
            Command.Parameters.Add(new MDB.MDBParameter("XuatHuyet_VongMac_MT", BenhAnMatChanThuong.XuatHuyet_VongMac_MT == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("XuatHuyet_VongMac_Text_MT", BenhAnMatChanThuong.XuatHuyet_VongMac_Text_MT));
            Command.Parameters.Add(new MDB.MDBParameter("Bong_VongMac_MT", BenhAnMatChanThuong.Bong_VongMac_MT));
            Command.Parameters.Add(new MDB.MDBParameter("Bong_VongMac_Text_MT", BenhAnMatChanThuong.Bong_VongMac_Text_MT));
            Command.Parameters.Add(new MDB.MDBParameter("Rach_VongMac_MT", BenhAnMatChanThuong.Rach_VongMac_MT));
            Command.Parameters.Add(new MDB.MDBParameter("Rach_VongMac_Text_MT", BenhAnMatChanThuong.Rach_VongMac_Text_MT));
            Command.Parameters.Add(new MDB.MDBParameter("ViTriRach_VongMac_Text_MT", BenhAnMatChanThuong.ViTriRach_VongMac_Text_MT));
            Command.Parameters.Add(new MDB.MDBParameter("HinhThaiRach_VongMac_Text_MT", BenhAnMatChanThuong.HinhThaiRach_VongMac_Text_MT));
            Command.Parameters.Add(new MDB.MDBParameter("DiVat_VongMac_MT", BenhAnMatChanThuong.DiVat_VongMac_MT == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("DiVat_VongMac_Text_MT", BenhAnMatChanThuong.DiVat_VongMac_Text_MT));
            Command.Parameters.Add(new MDB.MDBParameter("DiVat_VongMac_Text2_MT", BenhAnMatChanThuong.DiVat_VongMac_Text2_MT));
            Command.Parameters.Add(new MDB.MDBParameter("TonThuongKhac_VongMac_MT", BenhAnMatChanThuong.TonThuongKhac_VongMac_MT));
            Command.Parameters.Add(new MDB.MDBParameter("HocMat_MT", BenhAnMatChanThuong.HocMat_MT));
            Command.Parameters.Add(new MDB.MDBParameter("HocMat_Text_MT", BenhAnMatChanThuong.HocMat_Text_MT));
            Command.Parameters.Add(new MDB.MDBParameter("DiVat_HocMat_MT", BenhAnMatChanThuong.DiVat_HocMat_MT == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("DiVat_HocMat_Text_MT", BenhAnMatChanThuong.DiVat_HocMat_Text_MT));
            Command.Parameters.Add(new MDB.MDBParameter("VanNhan_MT", BenhAnMatChanThuong.VanNhan_MT));
            Command.Parameters.Add(new MDB.MDBParameter("VanNhan_Text_MT", BenhAnMatChanThuong.VanNhan_Text_MT));
            Command.Parameters.Add(new MDB.MDBParameter("NhanCau_MT", BenhAnMatChanThuong.NhanCau_MT));
            Command.Parameters.Add(new MDB.MDBParameter("NhanCau_Text_MT", BenhAnMatChanThuong.NhanCau_Text_MT));
            Command.Parameters.Add(new MDB.MDBParameter("HinhVe_VongMac_MP", BenhAnMatChanThuong.HinhVe_VongMac_MP));
            Command.Parameters.Add(new MDB.MDBParameter("HinhVe_VongMac_MT", BenhAnMatChanThuong.HinhVe_VongMac_MT));
            Command.Parameters.Add(new MDB.MDBParameter("ChuaCoBieuHienBenhLy", BenhAnMatChanThuong.ChuaCoBieuHienBenhLy));
            Command.Parameters.Add(new MDB.MDBParameter("BenhLy", BenhAnMatChanThuong.BenhLy));
            Command.Parameters.Add(new MDB.MDBParameter("ChanDoanBenhChinh_LamSang", BenhAnMatChanThuong.ChanDoanBenhChinh_LamSang));
            Command.Parameters.Add(new MDB.MDBParameter("ChanDoanBenhChinh_NguyenNhan", BenhAnMatChanThuong.ChanDoanBenhChinh_NguyenNhan));
            Command.Parameters.Add(new MDB.MDBParameter("QuaTrinhDieuTri_NoiKhoa", BenhAnMatChanThuong.QuaTrinhDieuTri_NoiKhoa));
            Command.Parameters.Add(new MDB.MDBParameter("PhauThuat", BenhAnMatChanThuong.PhauThuat == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("ThuThuat", BenhAnMatChanThuong.ThuThuat == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("ThiLucRaVienKhongKinhMPTongKet", BenhAnMatChanThuong.ThiLucRaVienKhongKinhMPTongKet));
            Command.Parameters.Add(new MDB.MDBParameter("ThiLucRaVienKhongKinhMTTongKet", BenhAnMatChanThuong.ThiLucRaVienKhongKinhMTTongKet));
            Command.Parameters.Add(new MDB.MDBParameter("ThiLucRaVienCoKinhMPTongKet", BenhAnMatChanThuong.ThiLucRaVienCoKinhMPTongKet));
            Command.Parameters.Add(new MDB.MDBParameter("ThiLucRaVienCoKinhMTTongKet", BenhAnMatChanThuong.ThiLucRaVienCoKinhMTTongKet));
            Command.Parameters.Add(new MDB.MDBParameter("NhanApRaVienMPTongKet", BenhAnMatChanThuong.NhanApRaVienMPTongKet));
            Command.Parameters.Add(new MDB.MDBParameter("NhanApRaVienMTTongKet", BenhAnMatChanThuong.NhanApRaVienMTTongKet));
            Command.Parameters.Add(new MDB.MDBParameter("HuongDieuTriTiep", BenhAnMatChanThuong.HuongDieuTriTiep));

            Command.Parameters.Add(new MDB.MDBParameter("TuaMoi_MP", BenhAnMatChanThuong.TuaMoi_MP ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("TuaMoi_MP_Text", BenhAnMatChanThuong.TuaMoi_MP_Text));
            Command.Parameters.Add(new MDB.MDBParameter("TuaMoi_MT", BenhAnMatChanThuong.TuaMoi_MT ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("TuaMoi_MT_Text", BenhAnMatChanThuong.TuaMoi_MT_Text));
            Command.Parameters.Add(new MDB.MDBParameter("TuaCu_MP", BenhAnMatChanThuong.TuaCu_MP ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("TuaCu_MP_Text", BenhAnMatChanThuong.TuaCu_MP_Text));
            Command.Parameters.Add(new MDB.MDBParameter("TuaCu_MT", BenhAnMatChanThuong.TuaCu_MT ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("TuaCu_MT_Text", BenhAnMatChanThuong.TuaCu_MT_Text));
            Command.Parameters.Add(new MDB.MDBParameter("TienPhongMP_Sau_Text", BenhAnMatChanThuong.TienPhongMP_Sau_Text));
            Command.Parameters.Add(new MDB.MDBParameter("TienPhongMP_Mu_Text", BenhAnMatChanThuong.TienPhongMP_Mu_Text));
            Command.Parameters.Add(new MDB.MDBParameter("TienPhongMP_XuatTiet_Text", BenhAnMatChanThuong.TienPhongMP_XuatTiet_Text));
            Command.Parameters.Add(new MDB.MDBParameter("TienPhongMP_Tydall_Text", BenhAnMatChanThuong.TienPhongMP_Tydall_Text));
            Command.Parameters.Add(new MDB.MDBParameter("TienPhongMT_Sau_Text", BenhAnMatChanThuong.TienPhongMT_Sau_Text));
            Command.Parameters.Add(new MDB.MDBParameter("TienPhongMT_Mu_Text", BenhAnMatChanThuong.TienPhongMT_Mu_Text));
            Command.Parameters.Add(new MDB.MDBParameter("TienPhongMT_XuatTiet_Text", BenhAnMatChanThuong.TienPhongMT_XuatTiet_Text));
            Command.Parameters.Add(new MDB.MDBParameter("TienPhongMT_Tydall_Text", BenhAnMatChanThuong.TienPhongMT_Tydall_Text));
            
            Command.Parameters.Add(new MDB.MDBParameter("Trong_DichKinh_MP", BenhAnMatChanThuong.Trong_DichKinh_MP ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("Duc_DichKinh_MP_Text", BenhAnMatChanThuong.Duc_DichKinh_MP_Text));
            Command.Parameters.Add(new MDB.MDBParameter("XuatHuyet_DichKinh_MP_Text", BenhAnMatChanThuong.XuatHuyet_DichKinh_MP_Text));
            Command.Parameters.Add(new MDB.MDBParameter("Trong_DichKinh_MT", BenhAnMatChanThuong.Trong_DichKinh_MT ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("Duc_DichKinh_MT_Text", BenhAnMatChanThuong.Duc_DichKinh_MT_Text));
            Command.Parameters.Add(new MDB.MDBParameter("XuatHuyet_DichKinh_MT_Text", BenhAnMatChanThuong.XuatHuyet_DichKinh_MT_Text));
            Command.Parameters.Add(new MDB.MDBParameter("VongMac_BenhLy_MP", BenhAnMatChanThuong.VongMac_BenhLy_MP));
            Command.Parameters.Add(new MDB.MDBParameter("VongMac_BenhLy_MT", BenhAnMatChanThuong.VongMac_BenhLy_MT));
            Command.Parameters.Add(new MDB.MDBParameter("VoXuong_HocMat_MP", BenhAnMatChanThuong.VoXuong_HocMat_MP ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("VoXuong_HocMat_Text_MP", BenhAnMatChanThuong.VoXuong_HocMat_Text_MP));
            Command.Parameters.Add(new MDB.MDBParameter("VoXuong_HocMat_MT", BenhAnMatChanThuong.VoXuong_HocMat_MT ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("VoXuong_HocMat_Text_MT", BenhAnMatChanThuong.VoXuong_HocMat_Text_MT));
            Command.Parameters.Add(new MDB.MDBParameter("ViTri_Khau_MP", BenhAnMatChanThuong.ViTri_Khau_MP));
            Command.Parameters.Add(new MDB.MDBParameter("ViTri_Khau_MT", BenhAnMatChanThuong.ViTri_Khau_MT));
            Command.Parameters.Add(new MDB.MDBParameter("ThayBenhLy", BenhAnMatChanThuong.ThayBenhLy ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("ChuaThayBenhLy", BenhAnMatChanThuong.ChuaThayBenhLy ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", BenhAnMatChanThuong.MaQuanLy));
            int n = Command.ExecuteNonQuery(); // C#
            return n > 0 ? true : false;
        }
        public static bool Delete(MDB.MDBConnection MyConnection, BenhAnMatChanThuong BenhAnMatChanThuong)
        {
            string sql = @"DELETE FROM BenhAnMatChanThuong 
                           WHERE MaQuanLy = :MaQuanLy";
            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
            Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", BenhAnMatChanThuong.MaQuanLy));

            int n = Command.ExecuteNonQuery(); // C#
            return n > 0 ? true : false;
        }
    }
}
