using System.Data;

namespace EMR_MAIN
{
    public class BenhAnSoSinhFunc
    {
        public static void WriteXml(MDB.MDBConnection MyConnection)
        {
            string sql =
                   @"
                  select  a.*,  CTScanner HoSo_CTScanner, SieuAm HoSo_SieuAm, XetNghiem HoSo_XetNghiem,  Khac HoSo_Khac,  Khac_Text HoSo_Khac_Text,  ToanBoHoSo HoSo_ToanBoHoSo, Mach DauSinhTon_Mach,  NhietDo DauSinhTon_NhietDo,  HuyetAp DauSinhTon_HuyetAp,  NhipTho DauSinhTon_NhipTho,  CanNang DauSinhTon_CanNang  
                  from BenhAnSoSinh a inner join thongtindieutri b on a.maquanly = b.maquanly
                  where rownum = 1
                    ";
            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
            MDB.MDBDataReader DataReader = Command.ExecuteReader();

            var DataTable = new DataTable { TableName = "BenhAnSoSinh" };
            DataTable.Load(DataReader as IDataReader);
            DataTable.WriteXml("rptBenhAnSoSinh.xml");
        }
        public static DataSet SelectDataSet(MDB.MDBConnection MyConnection, decimal MaQuanLy)
        {
            string sql =
                  @"
                 select  a.*,f.hovaten BacSyLamBenhAnHoVaTen ,c.hovaten BacSyDieuTriHoVaTen,d.hovaten NguoiGiaoHoSoHoVaTen,e.hovaten NguoiNhanHoSoHoVaTen, b.XQuang HoSo_XQuang,   b.CTScanner HoSo_CTScanner, b.SieuAm HoSo_SieuAm, b.XetNghiem HoSo_XetNghiem,  b.Khac HoSo_Khac,  b.Khac_Text HoSo_Khac_Text,  b.ToanBoHoSo HoSo_ToanBoHoSo, b.Mach DauSinhTon_Mach, b.NhietDo DauSinhTon_NhietDo,  b.HuyetAp DauSinhTon_HuyetAp,  b.NhipTho DauSinhTon_NhipTho,  b.CanNang DauSinhTon_CanNang  , b.ChieuCao DauSinhTon_ChieuCao, b.BMI DauSinhTon_BMI, b.NgayRaVien 
                 from BenhAnSoSinh a 
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
        public static BenhAnSoSinh Select(MDB.MDBConnection MyConnection, decimal MaQuanLy)
        {
            #region
            string sql =
                      @"select * 
                        from BenhAnSoSinh a
                        where MaQuanLy = :MaQuanLy";
            #endregion
            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
            Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", MaQuanLy));
            MDB.MDBDataReader DataReader = Command.ExecuteReader();
            var value = new BenhAnSoSinh();
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
                value.HoiBenh = DataReader["HoiBenh"].ToString();
                value.OiVo = DataReader.GetDate("OiVo");
                value.MauSac = DataReader["MauSac"].ToString();
                value.iCachDeID = DataReader.GetInt("CachDeID");
                value.ThoiGianDe = DataReader.GetDate("ThoiGianDe");
                value.LyDoCanThiep = DataReader["LyDoCanThiep"].ToString();
                value.NguoiDoDe = DataReader["NguoiDoDe"].ToString();
                value.Apgar1 = DataReader["Apgar1"].ToString();
                value.Apgar5 = DataReader["Apgar5"].ToString();
                value.Apgar10 = DataReader["Apgar10"].ToString();
                value.CanNang =(double)DataReader.GetDecimal("CanNang");
                value.TinhTrangDinhDuong = DataReader["TinhTrangDinhDuong"].ToString();
                value.HutDich = DataReader["HutDich"].ToString() == "1" ? true : false;
                value.XoaBopTim = DataReader["XoaBopTim"].ToString() == "1" ? true : false;
                value.ThoO2 = DataReader["ThoO2"].ToString() == "1" ? true : false;
                value.DatNoiKhiQuan = DataReader["DatNoiKhiQuan"].ToString() == "1" ? true : false;
                value.BopBongO2 = DataReader["BopBongO2"].ToString() == "1" ? true : false;
                value.Khac = DataReader["Khac"].ToString() == "1" ? true : false;
                value.NguoiChuyenSoSinh = DataReader["NguoiChuyenSoSinh"].ToString();
                value.DiTatBamSinh = DataReader["DiTatBamSinh"].ToString() == "1" ? true : false;
                value.CoHauMon = DataReader["CoHauMon"].ToString() == "1" ? true : false;
                value.CuTheDiTat = DataReader["CuTheDiTat"].ToString();
                value.TinhHinhSoSinhKhiVaoKhoa = DataReader["TinhHinhSoSinhKhiVaoKhoa"].ToString();
                value.TinhTrangToanThan = DataReader["TinhTrangToanThan"].ToString();
                value.MauSacDaID = DataReader.GetInt("MauSacDaID");
                value.MauSacDa = DataReader["MauSacDa"].ToString();
                value.ChieuDai = DataReader.GetInt("ChieuDai");
                value.VongDau = DataReader.GetInt("VongDau");
                value.NhipTho = DataReader.GetInt("NhipTho");
                value.NhietDo = DataReader.GetInt("NhietDo");
                value.NghePhoi = DataReader["NghePhoi"].ToString();
                value.ChiSoSilverman = DataReader.GetInt("ChiSoSilverman");
                value.SuDanNoLongNgucID = DataReader.GetInt("SuDanNoLongNgucID");
                value.CoKeoCoLienSuonID = DataReader.GetInt("CoKeoCoLienSuonID");
                value.CoKeoMuiUcID = DataReader.GetInt("CoKeoMuiUcID");
                value.DapCanhMuiID = DataReader.GetInt("DapCanhMuiID");
                value.RenRiID = DataReader.GetInt("RenRiID");
                value.Bung = DataReader["Bung"].ToString();
                value.PhanXa = DataReader["PhanXa"].ToString();
                value.TruongLucCo = DataReader["TruongLucCo"].ToString();
                value.NhipTim = DataReader.GetInt("NhipTim");
                value.TinhTrangSoSinhKRDID = DataReader.GetInt("TinhTrangSoSinhKRDID");
                value.ChiDinhTheoDoi = DataReader["ChiDinhTheoDoi"].ToString();
                value.MaSoKyTen = DataReader["masokyten"].ToString();
                value.MaSoKyTen_KB = DataReader["masokyten_kb"].ToString();
                value.MaSoKyTen_TK = DataReader["masokyten_tk"].ToString();
            }
            return value;
        }

        public static bool InsertOrUpdate(MDB.MDBConnection MyConnection, BenhAnSoSinh BenhAnSoSinh)
        {
            string sql =
                      @"select MaQuanLy 
                        from BenhAnSoSinh
                        where MaQuanLy = :MaQuanLy";
            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
            Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", BenhAnSoSinh.MaQuanLy));
            MDB.MDBDataReader DataReader = Command.ExecuteReader();
            int rowCount = 0;
            while (DataReader.Read()) rowCount++;
            if (rowCount == 1) return Update(MyConnection, BenhAnSoSinh);
            sql = @"
                   INSERT INTO BenhAnSoSinh (MaQuanLy, LyDoVaoVien, VaoNgayThu, QuaTrinhBenhLy, TienSuBenhBanThan, TienSuBenhGiaDinh, ToanThan, TuanHoan, HoHap, TieuHoa, ThanTietNieuSinhDuc, ThanKinh, CoXuongKhop, TaiMuiHong, RangHamMat, Mat, Khac_CacCoQuan, CacXetNghiemCanLamSangCanLam, TomTatBenhAn, BenhChinh, BenhKemTheo, PhanBiet, TienLuong, HuongDieuTri, NgayKhamBenh, BacSyLamBenhAn, QuaTrinhBenhLyVaDienBien, TomTatKetQuaXetNghiem, PhuongPhapDieuTri, TinhTrangNguoiBenhRaVien, HuongDieuTriVaCacCheDoTiepTheo, NguoiNhanHoSo, NguoiGiaoHoSo, NgayTongKet, BacSyDieuTri, DiUng, DiUng_Text, MaTuy, MaTuy_Text, RuouBia, RuouBia_Text, ThuocLa, ThuocLa_Text, ThuocLao, ThuocLao_Text, Khac_DacDiemLienQuanBenh, Khac_DacDiemLienQuanBenh_Text, HoiBenh, OiVo, MauSac, CachDeID, ThoiGianDe, LyDoCanThiep, NguoiDoDe, Apgar1, Apgar5, Apgar10, CanNang, TinhTrangDinhDuong, HutDich, XoaBopTim, ThoO2, DatNoiKhiQuan, BopBongO2, Khac, NguoiChuyenSoSinh, DiTatBamSinh, CoHauMon, CuTheDiTat, TinhHinhSoSinhKhiVaoKhoa, TinhTrangToanThan, MauSacDaID, MauSacDa, ChieuDai, VongDau, NhipTho, NhietDo, NghePhoi, ChiSoSilverman, SuDanNoLongNgucID, CoKeoCoLienSuonID, CoKeoMuiUcID, DapCanhMuiID, RenRiID, Bung, PhanXa, TruongLucCo, NhipTim, TinhTrangSoSinhKRDID, ChiDinhTheoDoi)
                   VALUES(:MaQuanLy, :LyDoVaoVien, :VaoNgayThu, :QuaTrinhBenhLy, :TienSuBenhBanThan, :TienSuBenhGiaDinh, :ToanThan, :TuanHoan, :HoHap, :TieuHoa, :ThanTietNieuSinhDuc, :ThanKinh, :CoXuongKhop, :TaiMuiHong, :RangHamMat, :Mat, :Khac_CacCoQuan, :CacXetNghiemCanLamSangCanLam, :TomTatBenhAn, :BenhChinh, :BenhKemTheo, :PhanBiet, :TienLuong, :HuongDieuTri, :NgayKhamBenh, :BacSyLamBenhAn, :QuaTrinhBenhLyVaDienBien, :TomTatKetQuaXetNghiem, :PhuongPhapDieuTri, :TinhTrangNguoiBenhRaVien, :HuongDieuTriVaCacCheDoTiepTheo, :NguoiNhanHoSo, :NguoiGiaoHoSo, :NgayTongKet, :BacSyDieuTri, :DiUng, :DiUng_Text, :MaTuy, :MaTuy_Text, :RuouBia, :RuouBia_Text, :ThuocLa, :ThuocLa_Text, :ThuocLao, :ThuocLao_Text, :Khac_DacDiemLienQuanBenh, :Khac_DacDiemLienQuanBenh_Text, :HoiBenh, :OiVo, :MauSac, :CachDeID, :ThoiGianDe, :LyDoCanThiep, :NguoiDoDe, :Apgar1, :Apgar5, :Apgar10, :CanNang, :TinhTrangDinhDuong, :HutDich, :XoaBopTim, :ThoO2, :DatNoiKhiQuan, :BopBongO2, :Khac, :NguoiChuyenSoSinh, :DiTatBamSinh, :CoHauMon, :CuTheDiTat, :TinhHinhSoSinhKhiVaoKhoa, :TinhTrangToanThan, :MauSacDaID, :MauSacDa, :ChieuDai, :VongDau, :NhipTho, :NhietDo, :NghePhoi, :ChiSoSilverman, :SuDanNoLongNgucID, :CoKeoCoLienSuonID, :CoKeoMuiUcID, :DapCanhMuiID, :RenRiID, :Bung, :PhanXa, :TruongLucCo, :NhipTim, :TinhTrangSoSinhKRDID, :ChiDinhTheoDoi)
                   ";
            Command = new MDB.MDBCommand(sql, MyConnection);
            Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", BenhAnSoSinh.MaQuanLy));
            Command.Parameters.Add(new MDB.MDBParameter("LyDoVaoVien", BenhAnSoSinh.LyDoVaoVien));
            Command.Parameters.Add(new MDB.MDBParameter("VaoNgayThu", BenhAnSoSinh.VaoNgayThu));
            Command.Parameters.Add(new MDB.MDBParameter("QuaTrinhBenhLy", BenhAnSoSinh.QuaTrinhBenhLy));
            Command.Parameters.Add(new MDB.MDBParameter("TienSuBenhBanThan", BenhAnSoSinh.TienSuBenhBanThan));
            Command.Parameters.Add(new MDB.MDBParameter("TienSuBenhGiaDinh", BenhAnSoSinh.TienSuBenhGiaDinh));
            Command.Parameters.Add(new MDB.MDBParameter("ToanThan", BenhAnSoSinh.ToanThan));
            Command.Parameters.Add(new MDB.MDBParameter("TuanHoan", BenhAnSoSinh.TuanHoan));
            Command.Parameters.Add(new MDB.MDBParameter("HoHap", BenhAnSoSinh.HoHap));
            Command.Parameters.Add(new MDB.MDBParameter("TieuHoa", BenhAnSoSinh.TieuHoa));
            Command.Parameters.Add(new MDB.MDBParameter("ThanTietNieuSinhDuc", BenhAnSoSinh.ThanTietNieuSinhDuc));
            Command.Parameters.Add(new MDB.MDBParameter("ThanKinh", BenhAnSoSinh.ThanKinh));
            Command.Parameters.Add(new MDB.MDBParameter("CoXuongKhop", BenhAnSoSinh.CoXuongKhop));
            Command.Parameters.Add(new MDB.MDBParameter("TaiMuiHong", BenhAnSoSinh.TaiMuiHong));
            Command.Parameters.Add(new MDB.MDBParameter("RangHamMat", BenhAnSoSinh.RangHamMat));
            Command.Parameters.Add(new MDB.MDBParameter("Mat", BenhAnSoSinh.Mat));
            Command.Parameters.Add(new MDB.MDBParameter("Khac_CacCoQuan", BenhAnSoSinh.Khac_CacCoQuan));
            Command.Parameters.Add(new MDB.MDBParameter("CacXetNghiemCanLamSangCanLam", BenhAnSoSinh.CacXetNghiemCanLamSangCanLam));
            Command.Parameters.Add(new MDB.MDBParameter("TomTatBenhAn", BenhAnSoSinh.TomTatBenhAn));
            Command.Parameters.Add(new MDB.MDBParameter("BenhChinh", BenhAnSoSinh.BenhChinh));
            Command.Parameters.Add(new MDB.MDBParameter("BenhKemTheo", BenhAnSoSinh.BenhKemTheo));
            Command.Parameters.Add(new MDB.MDBParameter("PhanBiet", BenhAnSoSinh.PhanBiet));
            Command.Parameters.Add(new MDB.MDBParameter("TienLuong", BenhAnSoSinh.TienLuong));
            Command.Parameters.Add(new MDB.MDBParameter("HuongDieuTri", BenhAnSoSinh.HuongDieuTri));
            Command.Parameters.Add(new MDB.MDBParameter("NgayKhamBenh", BenhAnSoSinh.NgayKhamBenh));
            Command.Parameters.Add(new MDB.MDBParameter("BacSyLamBenhAn", BenhAnSoSinh.BacSyLamBenhAn));
            Command.Parameters.Add(new MDB.MDBParameter("QuaTrinhBenhLyVaDienBien", BenhAnSoSinh.QuaTrinhBenhLyVaDienBien));
            Command.Parameters.Add(new MDB.MDBParameter("TomTatKetQuaXetNghiem", BenhAnSoSinh.TomTatKetQuaXetNghiem));
            Command.Parameters.Add(new MDB.MDBParameter("PhuongPhapDieuTri", BenhAnSoSinh.PhuongPhapDieuTri));
            Command.Parameters.Add(new MDB.MDBParameter("TinhTrangNguoiBenhRaVien", BenhAnSoSinh.TinhTrangNguoiBenhRaVien));
            Command.Parameters.Add(new MDB.MDBParameter("HuongDieuTriVaCacCheDoTiepTheo", BenhAnSoSinh.HuongDieuTriVaCacCheDoTiepTheo));
            Command.Parameters.Add(new MDB.MDBParameter("NguoiNhanHoSo", BenhAnSoSinh.NguoiNhanHoSo));
            Command.Parameters.Add(new MDB.MDBParameter("NguoiGiaoHoSo", BenhAnSoSinh.NguoiGiaoHoSo));
            Command.Parameters.Add(new MDB.MDBParameter("NgayTongKet", BenhAnSoSinh.NgayTongKet));
            Command.Parameters.Add(new MDB.MDBParameter("BacSyDieuTri", BenhAnSoSinh.BacSyDieuTri));
            Command.Parameters.Add(new MDB.MDBParameter("DiUng", BenhAnSoSinh.DacDiemLienQuanBenh.DiUng == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("DiUng_Text", BenhAnSoSinh.DacDiemLienQuanBenh.DiUng_Text));
            Command.Parameters.Add(new MDB.MDBParameter("MaTuy", BenhAnSoSinh.DacDiemLienQuanBenh.MaTuy == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("MaTuy_Text", BenhAnSoSinh.DacDiemLienQuanBenh.MaTuy_Text));
            Command.Parameters.Add(new MDB.MDBParameter("RuouBia", BenhAnSoSinh.DacDiemLienQuanBenh.RuouBia == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("RuouBia_Text", BenhAnSoSinh.DacDiemLienQuanBenh.RuouBia_Text));
            Command.Parameters.Add(new MDB.MDBParameter("ThuocLa", BenhAnSoSinh.DacDiemLienQuanBenh.ThuocLa == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("ThuocLa_Text", BenhAnSoSinh.DacDiemLienQuanBenh.ThuocLa_Text));
            Command.Parameters.Add(new MDB.MDBParameter("ThuocLao", BenhAnSoSinh.DacDiemLienQuanBenh.ThuocLao == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("ThuocLao_Text", BenhAnSoSinh.DacDiemLienQuanBenh.ThuocLao_Text));
            Command.Parameters.Add(new MDB.MDBParameter("Khac_DacDiemLienQuanBenh", BenhAnSoSinh.DacDiemLienQuanBenh.Khac_DacDiemLienQuanBenh == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("Khac_DacDiemLienQuanBenh_Text", BenhAnSoSinh.DacDiemLienQuanBenh.Khac_DacDiemLienQuanBenh_Text));
            Command.Parameters.Add(new MDB.MDBParameter("HoiBenh", BenhAnSoSinh.HoiBenh));
            Command.Parameters.Add(new MDB.MDBParameter("OiVo", BenhAnSoSinh.OiVo));
            Command.Parameters.Add(new MDB.MDBParameter("MauSac", BenhAnSoSinh.MauSac));
            Command.Parameters.Add(new MDB.MDBParameter("CachDeID", BenhAnSoSinh.iCachDeID));
            Command.Parameters.Add(new MDB.MDBParameter("ThoiGianDe", BenhAnSoSinh.ThoiGianDe));
            Command.Parameters.Add(new MDB.MDBParameter("LyDoCanThiep", BenhAnSoSinh.LyDoCanThiep));
            Command.Parameters.Add(new MDB.MDBParameter("NguoiDoDe", BenhAnSoSinh.NguoiDoDe));
            Command.Parameters.Add(new MDB.MDBParameter("Apgar1", BenhAnSoSinh.Apgar1));
            Command.Parameters.Add(new MDB.MDBParameter("Apgar5", BenhAnSoSinh.Apgar5));
            Command.Parameters.Add(new MDB.MDBParameter("Apgar10", BenhAnSoSinh.Apgar10));
            Command.Parameters.Add(new MDB.MDBParameter("CanNang", BenhAnSoSinh.CanNang));
            Command.Parameters.Add(new MDB.MDBParameter("TinhTrangDinhDuong", BenhAnSoSinh.TinhTrangDinhDuong));
            Command.Parameters.Add(new MDB.MDBParameter("HutDich", BenhAnSoSinh.HutDich == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("XoaBopTim", BenhAnSoSinh.XoaBopTim == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("ThoO2", BenhAnSoSinh.ThoO2 == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("DatNoiKhiQuan", BenhAnSoSinh.DatNoiKhiQuan == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("BopBongO2", BenhAnSoSinh.BopBongO2 == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("Khac", BenhAnSoSinh.Khac == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("NguoiChuyenSoSinh", BenhAnSoSinh.NguoiChuyenSoSinh));
            Command.Parameters.Add(new MDB.MDBParameter("DiTatBamSinh", BenhAnSoSinh.DiTatBamSinh == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("CoHauMon", BenhAnSoSinh.CoHauMon == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("CuTheDiTat", BenhAnSoSinh.CuTheDiTat));
            Command.Parameters.Add(new MDB.MDBParameter("TinhHinhSoSinhKhiVaoKhoa", BenhAnSoSinh.TinhHinhSoSinhKhiVaoKhoa));
            Command.Parameters.Add(new MDB.MDBParameter("TinhTrangToanThan", BenhAnSoSinh.TinhTrangToanThan));
            Command.Parameters.Add(new MDB.MDBParameter("MauSacDaID", BenhAnSoSinh.MauSacDaID));
            Command.Parameters.Add(new MDB.MDBParameter("MauSacDa", BenhAnSoSinh.MauSacDa));
            Command.Parameters.Add(new MDB.MDBParameter("ChieuDai", BenhAnSoSinh.ChieuDai));
            Command.Parameters.Add(new MDB.MDBParameter("VongDau", BenhAnSoSinh.VongDau));
            Command.Parameters.Add(new MDB.MDBParameter("NhipTho", BenhAnSoSinh.NhipTho));
            Command.Parameters.Add(new MDB.MDBParameter("NhietDo", BenhAnSoSinh.NhietDo));
            Command.Parameters.Add(new MDB.MDBParameter("NghePhoi", BenhAnSoSinh.NghePhoi));
            Command.Parameters.Add(new MDB.MDBParameter("ChiSoSilverman", BenhAnSoSinh.ChiSoSilverman));
            Command.Parameters.Add(new MDB.MDBParameter("SuDanNoLongNgucID", BenhAnSoSinh.SuDanNoLongNgucID));
            Command.Parameters.Add(new MDB.MDBParameter("CoKeoCoLienSuonID", BenhAnSoSinh.CoKeoCoLienSuonID));
            Command.Parameters.Add(new MDB.MDBParameter("CoKeoMuiUcID", BenhAnSoSinh.CoKeoMuiUcID));
            Command.Parameters.Add(new MDB.MDBParameter("DapCanhMuiID", BenhAnSoSinh.DapCanhMuiID));
            Command.Parameters.Add(new MDB.MDBParameter("RenRiID", BenhAnSoSinh.RenRiID));
            Command.Parameters.Add(new MDB.MDBParameter("Bung", BenhAnSoSinh.Bung));
            Command.Parameters.Add(new MDB.MDBParameter("PhanXa", BenhAnSoSinh.PhanXa));
            Command.Parameters.Add(new MDB.MDBParameter("TruongLucCo", BenhAnSoSinh.TruongLucCo));
            Command.Parameters.Add(new MDB.MDBParameter("NhipTim", BenhAnSoSinh.NhipTim));
            Command.Parameters.Add(new MDB.MDBParameter("TinhTrangSoSinhKRDID", BenhAnSoSinh.TinhTrangSoSinhKRDID));
            Command.Parameters.Add(new MDB.MDBParameter("ChiDinhTheoDoi", BenhAnSoSinh.ChiDinhTheoDoi));

            int n = Command.ExecuteNonQuery(); // C#
            return n > 0 ? true : false;
        }
        public static bool Update(MDB.MDBConnection MyConnection, BenhAnSoSinh BenhAnSoSinh)
        {
            string sql = @"UPDATE BenhAnSoSinh SET 
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
                        HoiBenh = :HoiBenh,
                        OiVo = :OiVo,
                        MauSac = :MauSac,
                        CachDeID = :CachDeID,
                        ThoiGianDe = :ThoiGianDe,
                        LyDoCanThiep = :LyDoCanThiep,
                        NguoiDoDe = :NguoiDoDe,
                        Apgar1 = :Apgar1,
                        Apgar5 = :Apgar5,
                        Apgar10 = :Apgar10,
                        CanNang = :CanNang,
                        TinhTrangDinhDuong = :TinhTrangDinhDuong,
                        HutDich = :HutDich,
                        XoaBopTim = :XoaBopTim,
                        ThoO2 = :ThoO2,
                        DatNoiKhiQuan = :DatNoiKhiQuan,
                        BopBongO2 = :BopBongO2,
                        Khac = :Khac,
                        NguoiChuyenSoSinh = :NguoiChuyenSoSinh,
                        DiTatBamSinh = :DiTatBamSinh,
                        CoHauMon = :CoHauMon,
                        CuTheDiTat = :CuTheDiTat,
                        TinhHinhSoSinhKhiVaoKhoa = :TinhHinhSoSinhKhiVaoKhoa,
                        TinhTrangToanThan = :TinhTrangToanThan,
                        MauSacDaID = :MauSacDaID,
                        MauSacDa = :MauSacDa,
                        ChieuDai = :ChieuDai,
                        VongDau = :VongDau,
                        NhipTho = :NhipTho,
                        NhietDo = :NhietDo,
                        NghePhoi = :NghePhoi,
                        ChiSoSilverman = :ChiSoSilverman,
                        SuDanNoLongNgucID = :SuDanNoLongNgucID,
                        CoKeoCoLienSuonID = :CoKeoCoLienSuonID,
                        CoKeoMuiUcID = :CoKeoMuiUcID,
                        DapCanhMuiID = :DapCanhMuiID,
                        RenRiID = :RenRiID,
                        Bung = :Bung,
                        PhanXa = :PhanXa,
                        TruongLucCo = :TruongLucCo,
                        NhipTim = :NhipTim,
                        TinhTrangSoSinhKRDID = :TinhTrangSoSinhKRDID,
                        ChiDinhTheoDoi = :ChiDinhTheoDoi
                        WHERE MaQuanLy = :MaQuanLy";
            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
            Command.Parameters.Add(new MDB.MDBParameter("LyDoVaoVien", BenhAnSoSinh.LyDoVaoVien));
            Command.Parameters.Add(new MDB.MDBParameter("VaoNgayThu", BenhAnSoSinh.VaoNgayThu));
            Command.Parameters.Add(new MDB.MDBParameter("QuaTrinhBenhLy", BenhAnSoSinh.QuaTrinhBenhLy));
            Command.Parameters.Add(new MDB.MDBParameter("TienSuBenhBanThan", BenhAnSoSinh.TienSuBenhBanThan));
            Command.Parameters.Add(new MDB.MDBParameter("TienSuBenhGiaDinh", BenhAnSoSinh.TienSuBenhGiaDinh));
            Command.Parameters.Add(new MDB.MDBParameter("ToanThan", BenhAnSoSinh.ToanThan));
            Command.Parameters.Add(new MDB.MDBParameter("TuanHoan", BenhAnSoSinh.TuanHoan));
            Command.Parameters.Add(new MDB.MDBParameter("HoHap", BenhAnSoSinh.HoHap));
            Command.Parameters.Add(new MDB.MDBParameter("TieuHoa", BenhAnSoSinh.TieuHoa));
            Command.Parameters.Add(new MDB.MDBParameter("ThanTietNieuSinhDuc", BenhAnSoSinh.ThanTietNieuSinhDuc));
            Command.Parameters.Add(new MDB.MDBParameter("ThanKinh", BenhAnSoSinh.ThanKinh));
            Command.Parameters.Add(new MDB.MDBParameter("CoXuongKhop", BenhAnSoSinh.CoXuongKhop));
            Command.Parameters.Add(new MDB.MDBParameter("TaiMuiHong", BenhAnSoSinh.TaiMuiHong));
            Command.Parameters.Add(new MDB.MDBParameter("RangHamMat", BenhAnSoSinh.RangHamMat));
            Command.Parameters.Add(new MDB.MDBParameter("Mat", BenhAnSoSinh.Mat));
            Command.Parameters.Add(new MDB.MDBParameter("Khac_CacCoQuan", BenhAnSoSinh.Khac_CacCoQuan));
            Command.Parameters.Add(new MDB.MDBParameter("CacXetNghiemCanLamSangCanLam", BenhAnSoSinh.CacXetNghiemCanLamSangCanLam));
            Command.Parameters.Add(new MDB.MDBParameter("TomTatBenhAn", BenhAnSoSinh.TomTatBenhAn));
            Command.Parameters.Add(new MDB.MDBParameter("BenhChinh", BenhAnSoSinh.BenhChinh));
            Command.Parameters.Add(new MDB.MDBParameter("BenhKemTheo", BenhAnSoSinh.BenhKemTheo));
            Command.Parameters.Add(new MDB.MDBParameter("PhanBiet", BenhAnSoSinh.PhanBiet));
            Command.Parameters.Add(new MDB.MDBParameter("TienLuong", BenhAnSoSinh.TienLuong));
            Command.Parameters.Add(new MDB.MDBParameter("HuongDieuTri", BenhAnSoSinh.HuongDieuTri));
            Command.Parameters.Add(new MDB.MDBParameter("NgayKhamBenh", BenhAnSoSinh.NgayKhamBenh));
            Command.Parameters.Add(new MDB.MDBParameter("BacSyLamBenhAn", BenhAnSoSinh.BacSyLamBenhAn));
            Command.Parameters.Add(new MDB.MDBParameter("QuaTrinhBenhLyVaDienBien", BenhAnSoSinh.QuaTrinhBenhLyVaDienBien));
            Command.Parameters.Add(new MDB.MDBParameter("TomTatKetQuaXetNghiem", BenhAnSoSinh.TomTatKetQuaXetNghiem));
            Command.Parameters.Add(new MDB.MDBParameter("PhuongPhapDieuTri", BenhAnSoSinh.PhuongPhapDieuTri));
            Command.Parameters.Add(new MDB.MDBParameter("TinhTrangNguoiBenhRaVien", BenhAnSoSinh.TinhTrangNguoiBenhRaVien));
            Command.Parameters.Add(new MDB.MDBParameter("HuongDieuTriVaCacCheDoTiepTheo", BenhAnSoSinh.HuongDieuTriVaCacCheDoTiepTheo));
            Command.Parameters.Add(new MDB.MDBParameter("NguoiNhanHoSo", BenhAnSoSinh.NguoiNhanHoSo));
            Command.Parameters.Add(new MDB.MDBParameter("NguoiGiaoHoSo", BenhAnSoSinh.NguoiGiaoHoSo));
            Command.Parameters.Add(new MDB.MDBParameter("NgayTongKet", BenhAnSoSinh.NgayTongKet));
            Command.Parameters.Add(new MDB.MDBParameter("BacSyDieuTri", BenhAnSoSinh.BacSyDieuTri));
            Command.Parameters.Add(new MDB.MDBParameter("DiUng", BenhAnSoSinh.DacDiemLienQuanBenh.DiUng == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("DiUng_Text", BenhAnSoSinh.DacDiemLienQuanBenh.DiUng_Text));
            Command.Parameters.Add(new MDB.MDBParameter("MaTuy", BenhAnSoSinh.DacDiemLienQuanBenh.MaTuy == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("MaTuy_Text", BenhAnSoSinh.DacDiemLienQuanBenh.MaTuy_Text));
            Command.Parameters.Add(new MDB.MDBParameter("RuouBia", BenhAnSoSinh.DacDiemLienQuanBenh.RuouBia == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("RuouBia_Text", BenhAnSoSinh.DacDiemLienQuanBenh.RuouBia_Text));
            Command.Parameters.Add(new MDB.MDBParameter("ThuocLa", BenhAnSoSinh.DacDiemLienQuanBenh.ThuocLa == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("ThuocLa_Text", BenhAnSoSinh.DacDiemLienQuanBenh.ThuocLa_Text));
            Command.Parameters.Add(new MDB.MDBParameter("ThuocLao", BenhAnSoSinh.DacDiemLienQuanBenh.ThuocLao == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("ThuocLao_Text", BenhAnSoSinh.DacDiemLienQuanBenh.ThuocLao_Text));
            Command.Parameters.Add(new MDB.MDBParameter("Khac_DacDiemLienQuanBenh", BenhAnSoSinh.DacDiemLienQuanBenh.Khac_DacDiemLienQuanBenh == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("Khac_DacDiemLienQuanBenh_Text", BenhAnSoSinh.DacDiemLienQuanBenh.Khac_DacDiemLienQuanBenh_Text));
            Command.Parameters.Add(new MDB.MDBParameter("HoiBenh", BenhAnSoSinh.HoiBenh));
            Command.Parameters.Add(new MDB.MDBParameter("OiVo", BenhAnSoSinh.OiVo));
            Command.Parameters.Add(new MDB.MDBParameter("MauSac", BenhAnSoSinh.MauSac));
            Command.Parameters.Add(new MDB.MDBParameter("CachDeID", BenhAnSoSinh.iCachDeID));
            Command.Parameters.Add(new MDB.MDBParameter("ThoiGianDe", BenhAnSoSinh.ThoiGianDe));
            Command.Parameters.Add(new MDB.MDBParameter("LyDoCanThiep", BenhAnSoSinh.LyDoCanThiep));
            Command.Parameters.Add(new MDB.MDBParameter("NguoiDoDe", BenhAnSoSinh.NguoiDoDe));
            Command.Parameters.Add(new MDB.MDBParameter("Apgar1", BenhAnSoSinh.Apgar1));
            Command.Parameters.Add(new MDB.MDBParameter("Apgar5", BenhAnSoSinh.Apgar5));
            Command.Parameters.Add(new MDB.MDBParameter("Apgar10", BenhAnSoSinh.Apgar10));
            Command.Parameters.Add(new MDB.MDBParameter("CanNang", BenhAnSoSinh.CanNang));
            Command.Parameters.Add(new MDB.MDBParameter("TinhTrangDinhDuong", BenhAnSoSinh.TinhTrangDinhDuong));
            Command.Parameters.Add(new MDB.MDBParameter("HutDich", BenhAnSoSinh.HutDich == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("XoaBopTim", BenhAnSoSinh.XoaBopTim == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("ThoO2", BenhAnSoSinh.ThoO2 == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("DatNoiKhiQuan", BenhAnSoSinh.DatNoiKhiQuan == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("BopBongO2", BenhAnSoSinh.BopBongO2 == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("Khac", BenhAnSoSinh.Khac == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("NguoiChuyenSoSinh", BenhAnSoSinh.NguoiChuyenSoSinh));
            Command.Parameters.Add(new MDB.MDBParameter("DiTatBamSinh", BenhAnSoSinh.DiTatBamSinh == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("CoHauMon", BenhAnSoSinh.CoHauMon == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("CuTheDiTat", BenhAnSoSinh.CuTheDiTat));
            Command.Parameters.Add(new MDB.MDBParameter("TinhHinhSoSinhKhiVaoKhoa", BenhAnSoSinh.TinhHinhSoSinhKhiVaoKhoa));
            Command.Parameters.Add(new MDB.MDBParameter("TinhTrangToanThan", BenhAnSoSinh.TinhTrangToanThan));
            Command.Parameters.Add(new MDB.MDBParameter("MauSacDaID", BenhAnSoSinh.MauSacDaID));
            Command.Parameters.Add(new MDB.MDBParameter("MauSacDa", BenhAnSoSinh.MauSacDa));
            Command.Parameters.Add(new MDB.MDBParameter("ChieuDai", BenhAnSoSinh.ChieuDai));
            Command.Parameters.Add(new MDB.MDBParameter("VongDau", BenhAnSoSinh.VongDau));
            Command.Parameters.Add(new MDB.MDBParameter("NhipTho", BenhAnSoSinh.NhipTho));
            Command.Parameters.Add(new MDB.MDBParameter("NhietDo", BenhAnSoSinh.NhietDo));
            Command.Parameters.Add(new MDB.MDBParameter("NghePhoi", BenhAnSoSinh.NghePhoi));
            Command.Parameters.Add(new MDB.MDBParameter("ChiSoSilverman", BenhAnSoSinh.ChiSoSilverman));
            Command.Parameters.Add(new MDB.MDBParameter("SuDanNoLongNgucID", BenhAnSoSinh.SuDanNoLongNgucID));
            Command.Parameters.Add(new MDB.MDBParameter("CoKeoCoLienSuonID", BenhAnSoSinh.CoKeoCoLienSuonID));
            Command.Parameters.Add(new MDB.MDBParameter("CoKeoMuiUcID", BenhAnSoSinh.CoKeoMuiUcID));
            Command.Parameters.Add(new MDB.MDBParameter("DapCanhMuiID", BenhAnSoSinh.DapCanhMuiID));
            Command.Parameters.Add(new MDB.MDBParameter("RenRiID", BenhAnSoSinh.RenRiID));
            Command.Parameters.Add(new MDB.MDBParameter("Bung", BenhAnSoSinh.Bung));
            Command.Parameters.Add(new MDB.MDBParameter("PhanXa", BenhAnSoSinh.PhanXa));
            Command.Parameters.Add(new MDB.MDBParameter("TruongLucCo", BenhAnSoSinh.TruongLucCo));
            Command.Parameters.Add(new MDB.MDBParameter("NhipTim", BenhAnSoSinh.NhipTim));
            Command.Parameters.Add(new MDB.MDBParameter("TinhTrangSoSinhKRDID", BenhAnSoSinh.TinhTrangSoSinhKRDID));
            Command.Parameters.Add(new MDB.MDBParameter("ChiDinhTheoDoi", BenhAnSoSinh.ChiDinhTheoDoi));

            Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", BenhAnSoSinh.MaQuanLy));
            int n = Command.ExecuteNonQuery(); // C#

            return n > 0 ? true : false;
        }
        public static bool Delete(MDB.MDBConnection MyConnection, BenhAnSoSinh BenhAnSoSinh)
        {
            string sql = @"DELETE FROM BenhAnSoSinh 
                           WHERE MaQuanLy = :MaQuanLy";
            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
            Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", BenhAnSoSinh.MaQuanLy));

            int n = Command.ExecuteNonQuery(); // C#
            return n > 0 ? true : false;
        }
    }
}
