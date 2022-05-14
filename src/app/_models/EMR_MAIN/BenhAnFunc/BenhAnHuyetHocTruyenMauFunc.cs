using System.Data;

namespace EMR_MAIN
{
    public class BenhAnHuyetHocTruyenMauFunc
    {
        public static void WriteXml(MDB.MDBConnection MyConnection)
        {
            string sql =
                   @"
                  select  a.*,  CTScanner HoSo_CTScanner, SieuAm HoSo_SieuAm, XetNghiem HoSo_XetNghiem,  Khac HoSo_Khac,  Khac_Text HoSo_Khac_Text,  ToanBoHoSo HoSo_ToanBoHoSo, Mach DauSinhTon_Mach,  NhietDo DauSinhTon_NhietDo,  HuyetAp DauSinhTon_HuyetAp,  NhipTho DauSinhTon_NhipTho,  CanNang DauSinhTon_CanNang  
                  from BenhAnHuyetHocTruyenMau a inner join thongtindieutri b on a.maquanly = b.maquanly
                  where rownum = 1
                    ";
            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
            MDB.MDBDataReader DataReader = Command.ExecuteReader();

            var DataTable = new DataTable { TableName = "BenhAnHuyetHocTruyenMau" };
            DataTable.Load(DataReader as IDataReader);
            DataTable.WriteXml("rptBenhAnHuyetHocTruyenMau.xml");
        }
        public static DataSet SelectDataSet(MDB.MDBConnection MyConnection, decimal MaQuanLy)
        {
            string sql =
                   @"
                   select  a.*,f.hovaten BacSyLamBenhAnHoVaTen ,c.hovaten BacSyDieuTriHoVaTen,d.hovaten NguoiGiaoHoSoHoVaTen,e.hovaten NguoiNhanHoSoHoVaTen, b.XQuang HoSo_XQuang,   b.CTScanner HoSo_CTScanner, b.SieuAm HoSo_SieuAm, b.XetNghiem HoSo_XetNghiem,  b.Khac HoSo_Khac,  b.Khac_Text HoSo_Khac_Text,  b.ToanBoHoSo HoSo_ToanBoHoSo, b.Mach DauSinhTon_Mach, b.NhietDo DauSinhTon_NhietDo,  b.HuyetAp DauSinhTon_HuyetAp,  b.NhipTho DauSinhTon_NhipTho,  b.CanNang DauSinhTon_CanNang  , b.ChieuCao DauSinhTon_ChieuCao, b.BMI DauSinhTon_BMI, b.NgayRaVien 
                 from BenhAnHuyetHocTruyenMau a 
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
        public static BenhAnHuyetHocTruyenMau Select(MDB.MDBConnection MyConnection, decimal MaQuanLy)
        {
            #region
            string sql =
                      @"select * 
                        from BenhAnHuyetHocTruyenMau a
                        where MaQuanLy = :MaQuanLy";
            #endregion
            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
            Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", MaQuanLy));
            MDB.MDBDataReader DataReader = Command.ExecuteReader();
            var value = new BenhAnHuyetHocTruyenMau();
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
                value.TinhThanCuaNguoiBenh = DataReader["TinhThanCuaNguoiBenh"].ToString();
                value.HinhDangTuThe = DataReader["HinhDangTuThe"].ToString();
                value.DaNiemMac = DataReader["DaNiemMac"].ToString();
                value.TrieuChungXuatHuyet = DataReader["TrieuChungXuatHuyet"].ToString();
                value.HeThongLong_Toc_Mong = DataReader["HeThongLong_Toc_Mong"].ToString();
                value.TrieuChungPhu = DataReader["TrieuChungPhu"].ToString();
                value.TuyenGiap = DataReader["TuyenGiap"].ToString();
                value.KichThuoc_Gan = DataReader["KichThuoc_Gan"].ToString();
                value.MatDo_Gan = DataReader["MatDo_Gan"].ToString();
                value.Bo_Gan = DataReader["Bo_Gan"].ToString();
                value.MatGan_Gan = DataReader["MatGan_Gan"].ToString();
                value.Dau_Gan = DataReader["Dau_Gan"].ToString();
                value.KichThuoc_Lach = DataReader["KichThuoc_Lach"].ToString();
                value.MatDo_Lach = DataReader["MatDo_Lach"].ToString();
                value.Bo_Lach = DataReader["Bo_Lach"].ToString();
                value.MatGan_Lach = DataReader["MatGan_Lach"].ToString();
                value.Dau_Lach = DataReader["Dau_Lach"].ToString();
                value.ViTri_Hach = DataReader["ViTri_Hach"].ToString();
                value.KichThuoc_Hach = DataReader["KichThuoc_Hach"].ToString();
                value.SoLuong_Hach = DataReader["SoLuong_Hach"].ToString();
                value.DoDiDong_Hach = DataReader["DoDiDong_Hach"].ToString();
                value.MatHach_Hach = DataReader["MatHach_Hach"].ToString();
                value.Dau_Hach = DataReader["Dau_Hach"].ToString();
                value.HuyetDo = DataReader["HuyetDo"].ToString() == "1" ? true : false;
                value.TuyDo = DataReader["TuyDo"].ToString() == "1" ? true : false;
                value.SinhThietTuy = DataReader["SinhThietTuy"].ToString() == "1" ? true : false;
                value.SinhThietHach = DataReader["SinhThietHach"].ToString() == "1" ? true : false;
                value.DongMauToanBo = DataReader["DongMauToanBo"].ToString() == "1" ? true : false;
                value.DinhLuongYeuToMauDong = DataReader["DinhLuongYeuToMauDong"].ToString() == "1" ? true : false;
                value.DienDiHST = DataReader["DienDiHST"].ToString() == "1" ? true : false;
                value.NhiemSacThe = DataReader["NhiemSacThe"].ToString() == "1" ? true : false;
                value.NhomMau = DataReader["NhomMau"].ToString() == "1" ? true : false;
                value.CoombsTest = DataReader["CoombsTest"].ToString() == "1" ? true : false;
                value.KhangTheBatThuong = DataReader["KhangTheBatThuong"].ToString() == "1" ? true : false;
                value.SinhHoa = DataReader["SinhHoa"].ToString() == "1" ? true : false;
                value.GPB = DataReader["GPB"].ToString() == "1" ? true : false;
                value.ViSinh = DataReader["ViSinh"].ToString() == "1" ? true : false;
                value.XQuang = DataReader["XQuang"].ToString() == "1" ? true : false;
                value.KhoiHongCau = DataReader.GetInt("KhoiHongCau");
                value.HuyetTuuong = DataReader.GetInt("HuyetTuuong");
                value.HongCauRua = DataReader.GetInt("HongCauRua");
                value.HuyetTuongDongLanh = DataReader.GetInt("HuyetTuongDongLanh");
                value.KhoiTieuCau = DataReader.GetInt("KhoiTieuCau");
                value.TuaVIII = DataReader.GetInt("TuaVIII");
                value.KhoiBachCauHat = DataReader.GetInt("KhoiBachCauHat");
                value.TruyenMauToanPhan = DataReader.GetInt("TruyenMauToanPhan");
                value.CacPhanUngKhiTruyenMau = DataReader.GetInt("CacPhanUngKhiTruyenMau");
                value.PhanTichTeBao = DataReader["PhanTichTeBao"].ToString() == "1" ? true : false;

                value.MaSoKyTen = DataReader["masokyten"].ToString();
                value.MaSoKyTen_KB = DataReader["masokyten_kb"].ToString();
                value.MaSoKyTen_TK = DataReader["masokyten_tk"].ToString();
            }
            return value;
        }

        public static bool InsertOrUpdate(MDB.MDBConnection MyConnection, BenhAnHuyetHocTruyenMau BenhAnHuyetHocTruyenMau)
        {
            string sql =
                      @"select MaQuanLy 
                        from BenhAnHuyetHocTruyenMau
                        where MaQuanLy = :MaQuanLy";
            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
            Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", BenhAnHuyetHocTruyenMau.MaQuanLy));
            MDB.MDBDataReader DataReader = Command.ExecuteReader();
            int rowCount = 0;
            while (DataReader.Read()) rowCount++;
            if (rowCount == 1) return Update(MyConnection, BenhAnHuyetHocTruyenMau);
            sql = @"
                   INSERT INTO BenhAnHuyetHocTruyenMau (MaQuanLy, LyDoVaoVien, VaoNgayThu, QuaTrinhBenhLy, TienSuBenhBanThan, TienSuBenhGiaDinh, ToanThan, TuanHoan, HoHap, TieuHoa, ThanTietNieuSinhDuc, ThanKinh, CoXuongKhop, TaiMuiHong, RangHamMat, Mat, Khac_CacCoQuan, CacXetNghiemCanLamSangCanLam, TomTatBenhAn, BenhChinh, BenhKemTheo, PhanBiet, TienLuong, HuongDieuTri, NgayKhamBenh, BacSyLamBenhAn, QuaTrinhBenhLyVaDienBien, TomTatKetQuaXetNghiem, PhuongPhapDieuTri, TinhTrangNguoiBenhRaVien, HuongDieuTriVaCacCheDoTiepTheo, NguoiNhanHoSo, NguoiGiaoHoSo, NgayTongKet, BacSyDieuTri, DiUng, DiUng_Text, MaTuy, MaTuy_Text, RuouBia, RuouBia_Text, ThuocLa, ThuocLa_Text, ThuocLao, ThuocLao_Text, Khac_DacDiemLienQuanBenh, Khac_DacDiemLienQuanBenh_Text, TinhThanCuaNguoiBenh, HinhDangTuThe, DaNiemMac, TrieuChungXuatHuyet, HeThongLong_Toc_Mong, TrieuChungPhu, TuyenGiap, KichThuoc_Gan, MatDo_Gan, Bo_Gan, MatGan_Gan, Dau_Gan, KichThuoc_Lach, MatDo_Lach, Bo_Lach, MatGan_Lach, Dau_Lach, ViTri_Hach, KichThuoc_Hach, SoLuong_Hach, DoDiDong_Hach, MatHach_Hach, Dau_Hach, HuyetDo, TuyDo, SinhThietTuy, SinhThietHach, DongMauToanBo, DinhLuongYeuToMauDong, DienDiHST, NhiemSacThe, NhomMau, CoombsTest, KhangTheBatThuong, SinhHoa, GPB, ViSinh, XQuang, KhoiHongCau, HuyetTuuong, HongCauRua, HuyetTuongDongLanh, KhoiTieuCau, TuaVIII, KhoiBachCauHat, TruyenMauToanPhan, CacPhanUngKhiTruyenMau, PhanTichTeBao)
                   VALUES(:MaQuanLy, :LyDoVaoVien, :VaoNgayThu, :QuaTrinhBenhLy, :TienSuBenhBanThan, :TienSuBenhGiaDinh, :ToanThan, :TuanHoan, :HoHap, :TieuHoa, :ThanTietNieuSinhDuc, :ThanKinh, :CoXuongKhop, :TaiMuiHong, :RangHamMat, :Mat, :Khac_CacCoQuan, :CacXetNghiemCanLamSangCanLam, :TomTatBenhAn, :BenhChinh, :BenhKemTheo, :PhanBiet, :TienLuong, :HuongDieuTri, :NgayKhamBenh, :BacSyLamBenhAn, :QuaTrinhBenhLyVaDienBien, :TomTatKetQuaXetNghiem, :PhuongPhapDieuTri, :TinhTrangNguoiBenhRaVien, :HuongDieuTriVaCacCheDoTiepTheo, :NguoiNhanHoSo, :NguoiGiaoHoSo, :NgayTongKet, :BacSyDieuTri, :DiUng, :DiUng_Text, :MaTuy, :MaTuy_Text, :RuouBia, :RuouBia_Text, :ThuocLa, :ThuocLa_Text, :ThuocLao, :ThuocLao_Text, :Khac_DacDiemLienQuanBenh, :Khac_DacDiemLienQuanBenh_Text, :TinhThanCuaNguoiBenh, :HinhDangTuThe, :DaNiemMac, :TrieuChungXuatHuyet, :HeThongLong_Toc_Mong, :TrieuChungPhu, :TuyenGiap, :KichThuoc_Gan, :MatDo_Gan, :Bo_Gan, :MatGan_Gan, :Dau_Gan, :KichThuoc_Lach, :MatDo_Lach, :Bo_Lach, :MatGan_Lach, :Dau_Lach, :ViTri_Hach, :KichThuoc_Hach, :SoLuong_Hach, :DoDiDong_Hach, :MatHach_Hach, :Dau_Hach, :HuyetDo, :TuyDo, :SinhThietTuy, :SinhThietHach, :DongMauToanBo, :DinhLuongYeuToMauDong, :DienDiHST, :NhiemSacThe, :NhomMau, :CoombsTest, :KhangTheBatThuong, :SinhHoa, :GPB, :ViSinh, :XQuang, :KhoiHongCau, :HuyetTuuong, :HongCauRua, :HuyetTuongDongLanh, :KhoiTieuCau, :TuaVIII, :KhoiBachCauHat, :TruyenMauToanPhan, :CacPhanUngKhiTruyenMau, :PhanTichTeBao)
                   ";
            Command = new MDB.MDBCommand(sql, MyConnection);
            Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", BenhAnHuyetHocTruyenMau.MaQuanLy));
            Command.Parameters.Add(new MDB.MDBParameter("LyDoVaoVien", BenhAnHuyetHocTruyenMau.LyDoVaoVien));
            Command.Parameters.Add(new MDB.MDBParameter("VaoNgayThu", BenhAnHuyetHocTruyenMau.VaoNgayThu));
            Command.Parameters.Add(new MDB.MDBParameter("QuaTrinhBenhLy", BenhAnHuyetHocTruyenMau.QuaTrinhBenhLy));
            Command.Parameters.Add(new MDB.MDBParameter("TienSuBenhBanThan", BenhAnHuyetHocTruyenMau.TienSuBenhBanThan));
            Command.Parameters.Add(new MDB.MDBParameter("TienSuBenhGiaDinh", BenhAnHuyetHocTruyenMau.TienSuBenhGiaDinh));
            Command.Parameters.Add(new MDB.MDBParameter("ToanThan", BenhAnHuyetHocTruyenMau.ToanThan));
            Command.Parameters.Add(new MDB.MDBParameter("TuanHoan", BenhAnHuyetHocTruyenMau.TuanHoan));
            Command.Parameters.Add(new MDB.MDBParameter("HoHap", BenhAnHuyetHocTruyenMau.HoHap));
            Command.Parameters.Add(new MDB.MDBParameter("TieuHoa", BenhAnHuyetHocTruyenMau.TieuHoa));
            Command.Parameters.Add(new MDB.MDBParameter("ThanTietNieuSinhDuc", BenhAnHuyetHocTruyenMau.ThanTietNieuSinhDuc));
            Command.Parameters.Add(new MDB.MDBParameter("ThanKinh", BenhAnHuyetHocTruyenMau.ThanKinh));
            Command.Parameters.Add(new MDB.MDBParameter("CoXuongKhop", BenhAnHuyetHocTruyenMau.CoXuongKhop));
            Command.Parameters.Add(new MDB.MDBParameter("TaiMuiHong", BenhAnHuyetHocTruyenMau.TaiMuiHong));
            Command.Parameters.Add(new MDB.MDBParameter("RangHamMat", BenhAnHuyetHocTruyenMau.RangHamMat));
            Command.Parameters.Add(new MDB.MDBParameter("Mat", BenhAnHuyetHocTruyenMau.Mat));
            Command.Parameters.Add(new MDB.MDBParameter("Khac_CacCoQuan", BenhAnHuyetHocTruyenMau.Khac_CacCoQuan));
            Command.Parameters.Add(new MDB.MDBParameter("CacXetNghiemCanLamSangCanLam", BenhAnHuyetHocTruyenMau.CacXetNghiemCanLamSangCanLam));
            Command.Parameters.Add(new MDB.MDBParameter("TomTatBenhAn", BenhAnHuyetHocTruyenMau.TomTatBenhAn));
            Command.Parameters.Add(new MDB.MDBParameter("BenhChinh", BenhAnHuyetHocTruyenMau.BenhChinh));
            Command.Parameters.Add(new MDB.MDBParameter("BenhKemTheo", BenhAnHuyetHocTruyenMau.BenhKemTheo));
            Command.Parameters.Add(new MDB.MDBParameter("PhanBiet", BenhAnHuyetHocTruyenMau.PhanBiet));
            Command.Parameters.Add(new MDB.MDBParameter("TienLuong", BenhAnHuyetHocTruyenMau.TienLuong));
            Command.Parameters.Add(new MDB.MDBParameter("HuongDieuTri", BenhAnHuyetHocTruyenMau.HuongDieuTri));
            Command.Parameters.Add(new MDB.MDBParameter("NgayKhamBenh", BenhAnHuyetHocTruyenMau.NgayKhamBenh));
            Command.Parameters.Add(new MDB.MDBParameter("BacSyLamBenhAn", BenhAnHuyetHocTruyenMau.BacSyLamBenhAn));
            Command.Parameters.Add(new MDB.MDBParameter("QuaTrinhBenhLyVaDienBien", BenhAnHuyetHocTruyenMau.QuaTrinhBenhLyVaDienBien));
            Command.Parameters.Add(new MDB.MDBParameter("TomTatKetQuaXetNghiem", BenhAnHuyetHocTruyenMau.TomTatKetQuaXetNghiem));
            Command.Parameters.Add(new MDB.MDBParameter("PhuongPhapDieuTri", BenhAnHuyetHocTruyenMau.PhuongPhapDieuTri));
            Command.Parameters.Add(new MDB.MDBParameter("TinhTrangNguoiBenhRaVien", BenhAnHuyetHocTruyenMau.TinhTrangNguoiBenhRaVien));
            Command.Parameters.Add(new MDB.MDBParameter("HuongDieuTriVaCacCheDoTiepTheo", BenhAnHuyetHocTruyenMau.HuongDieuTriVaCacCheDoTiepTheo));
            Command.Parameters.Add(new MDB.MDBParameter("NguoiNhanHoSo", BenhAnHuyetHocTruyenMau.NguoiNhanHoSo));
            Command.Parameters.Add(new MDB.MDBParameter("NguoiGiaoHoSo", BenhAnHuyetHocTruyenMau.NguoiGiaoHoSo));
            Command.Parameters.Add(new MDB.MDBParameter("NgayTongKet", BenhAnHuyetHocTruyenMau.NgayTongKet));
            Command.Parameters.Add(new MDB.MDBParameter("BacSyDieuTri", BenhAnHuyetHocTruyenMau.BacSyDieuTri));
            Command.Parameters.Add(new MDB.MDBParameter("DiUng", BenhAnHuyetHocTruyenMau.DacDiemLienQuanBenh.DiUng == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("DiUng_Text", BenhAnHuyetHocTruyenMau.DacDiemLienQuanBenh.DiUng_Text));
            Command.Parameters.Add(new MDB.MDBParameter("MaTuy", BenhAnHuyetHocTruyenMau.DacDiemLienQuanBenh.MaTuy == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("MaTuy_Text", BenhAnHuyetHocTruyenMau.DacDiemLienQuanBenh.MaTuy_Text));
            Command.Parameters.Add(new MDB.MDBParameter("RuouBia", BenhAnHuyetHocTruyenMau.DacDiemLienQuanBenh.RuouBia == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("RuouBia_Text", BenhAnHuyetHocTruyenMau.DacDiemLienQuanBenh.RuouBia_Text));
            Command.Parameters.Add(new MDB.MDBParameter("ThuocLa", BenhAnHuyetHocTruyenMau.DacDiemLienQuanBenh.ThuocLa == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("ThuocLa_Text", BenhAnHuyetHocTruyenMau.DacDiemLienQuanBenh.ThuocLa_Text));
            Command.Parameters.Add(new MDB.MDBParameter("ThuocLao", BenhAnHuyetHocTruyenMau.DacDiemLienQuanBenh.ThuocLao == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("ThuocLao_Text", BenhAnHuyetHocTruyenMau.DacDiemLienQuanBenh.ThuocLao_Text));
            Command.Parameters.Add(new MDB.MDBParameter("Khac_DacDiemLienQuanBenh", BenhAnHuyetHocTruyenMau.DacDiemLienQuanBenh.Khac_DacDiemLienQuanBenh == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("Khac_DacDiemLienQuanBenh_Text", BenhAnHuyetHocTruyenMau.DacDiemLienQuanBenh.Khac_DacDiemLienQuanBenh_Text));
            Command.Parameters.Add(new MDB.MDBParameter("TinhThanCuaNguoiBenh", BenhAnHuyetHocTruyenMau.TinhThanCuaNguoiBenh));
            Command.Parameters.Add(new MDB.MDBParameter("HinhDangTuThe", BenhAnHuyetHocTruyenMau.HinhDangTuThe));
            Command.Parameters.Add(new MDB.MDBParameter("DaNiemMac", BenhAnHuyetHocTruyenMau.DaNiemMac));
            Command.Parameters.Add(new MDB.MDBParameter("TrieuChungXuatHuyet", BenhAnHuyetHocTruyenMau.TrieuChungXuatHuyet));
            Command.Parameters.Add(new MDB.MDBParameter("HeThongLong_Toc_Mong", BenhAnHuyetHocTruyenMau.HeThongLong_Toc_Mong));
            Command.Parameters.Add(new MDB.MDBParameter("TrieuChungPhu", BenhAnHuyetHocTruyenMau.TrieuChungPhu));
            Command.Parameters.Add(new MDB.MDBParameter("TuyenGiap", BenhAnHuyetHocTruyenMau.TuyenGiap));
            Command.Parameters.Add(new MDB.MDBParameter("KichThuoc_Gan", BenhAnHuyetHocTruyenMau.KichThuoc_Gan));
            Command.Parameters.Add(new MDB.MDBParameter("MatDo_Gan", BenhAnHuyetHocTruyenMau.MatDo_Gan));
            Command.Parameters.Add(new MDB.MDBParameter("Bo_Gan", BenhAnHuyetHocTruyenMau.Bo_Gan));
            Command.Parameters.Add(new MDB.MDBParameter("MatGan_Gan", BenhAnHuyetHocTruyenMau.MatGan_Gan));
            Command.Parameters.Add(new MDB.MDBParameter("Dau_Gan", BenhAnHuyetHocTruyenMau.Dau_Gan));
            Command.Parameters.Add(new MDB.MDBParameter("KichThuoc_Lach", BenhAnHuyetHocTruyenMau.KichThuoc_Lach));
            Command.Parameters.Add(new MDB.MDBParameter("MatDo_Lach", BenhAnHuyetHocTruyenMau.MatDo_Lach));
            Command.Parameters.Add(new MDB.MDBParameter("Bo_Lach", BenhAnHuyetHocTruyenMau.Bo_Lach));
            Command.Parameters.Add(new MDB.MDBParameter("MatGan_Lach", BenhAnHuyetHocTruyenMau.MatGan_Lach));
            Command.Parameters.Add(new MDB.MDBParameter("Dau_Lach", BenhAnHuyetHocTruyenMau.Dau_Lach));
            Command.Parameters.Add(new MDB.MDBParameter("ViTri_Hach", BenhAnHuyetHocTruyenMau.ViTri_Hach));
            Command.Parameters.Add(new MDB.MDBParameter("KichThuoc_Hach", BenhAnHuyetHocTruyenMau.KichThuoc_Hach));
            Command.Parameters.Add(new MDB.MDBParameter("SoLuong_Hach", BenhAnHuyetHocTruyenMau.SoLuong_Hach));
            Command.Parameters.Add(new MDB.MDBParameter("DoDiDong_Hach", BenhAnHuyetHocTruyenMau.DoDiDong_Hach));
            Command.Parameters.Add(new MDB.MDBParameter("MatHach_Hach", BenhAnHuyetHocTruyenMau.MatHach_Hach));
            Command.Parameters.Add(new MDB.MDBParameter("Dau_Hach", BenhAnHuyetHocTruyenMau.Dau_Hach));
            Command.Parameters.Add(new MDB.MDBParameter("HuyetDo", BenhAnHuyetHocTruyenMau.HuyetDo == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("TuyDo", BenhAnHuyetHocTruyenMau.TuyDo == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("SinhThietTuy", BenhAnHuyetHocTruyenMau.SinhThietTuy == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("SinhThietHach", BenhAnHuyetHocTruyenMau.SinhThietHach == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("DongMauToanBo", BenhAnHuyetHocTruyenMau.DongMauToanBo == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("DinhLuongYeuToMauDong", BenhAnHuyetHocTruyenMau.DinhLuongYeuToMauDong == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("DienDiHST", BenhAnHuyetHocTruyenMau.DienDiHST == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("NhiemSacThe", BenhAnHuyetHocTruyenMau.NhiemSacThe == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("NhomMau", BenhAnHuyetHocTruyenMau.NhomMau == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("CoombsTest", BenhAnHuyetHocTruyenMau.CoombsTest == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("KhangTheBatThuong", BenhAnHuyetHocTruyenMau.KhangTheBatThuong == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("SinhHoa", BenhAnHuyetHocTruyenMau.SinhHoa == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("GPB", BenhAnHuyetHocTruyenMau.GPB == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("ViSinh", BenhAnHuyetHocTruyenMau.ViSinh == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("XQuang", BenhAnHuyetHocTruyenMau.XQuang == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("KhoiHongCau", BenhAnHuyetHocTruyenMau.KhoiHongCau));
            Command.Parameters.Add(new MDB.MDBParameter("HuyetTuuong", BenhAnHuyetHocTruyenMau.HuyetTuuong));
            Command.Parameters.Add(new MDB.MDBParameter("HongCauRua", BenhAnHuyetHocTruyenMau.HongCauRua));
            Command.Parameters.Add(new MDB.MDBParameter("HuyetTuongDongLanh", BenhAnHuyetHocTruyenMau.HuyetTuongDongLanh));
            Command.Parameters.Add(new MDB.MDBParameter("KhoiTieuCau", BenhAnHuyetHocTruyenMau.KhoiTieuCau));
            Command.Parameters.Add(new MDB.MDBParameter("TuaVIII", BenhAnHuyetHocTruyenMau.TuaVIII));
            Command.Parameters.Add(new MDB.MDBParameter("KhoiBachCauHat", BenhAnHuyetHocTruyenMau.KhoiBachCauHat));
            Command.Parameters.Add(new MDB.MDBParameter("TruyenMauToanPhan", BenhAnHuyetHocTruyenMau.TruyenMauToanPhan));
            Command.Parameters.Add(new MDB.MDBParameter("CacPhanUngKhiTruyenMau", BenhAnHuyetHocTruyenMau.CacPhanUngKhiTruyenMau));
            Command.Parameters.Add(new MDB.MDBParameter("PhanTichTeBao", BenhAnHuyetHocTruyenMau.PhanTichTeBao == true ? "1" : "0"));


            int n = Command.ExecuteNonQuery(); // C#
            return n > 0 ? true : false;
        }
        public static bool Update(MDB.MDBConnection MyConnection, BenhAnHuyetHocTruyenMau BenhAnHuyetHocTruyenMau)
        {
            string sql = @"UPDATE BenhAnHuyetHocTruyenMau SET 
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
TinhThanCuaNguoiBenh = :TinhThanCuaNguoiBenh,
HinhDangTuThe = :HinhDangTuThe,
DaNiemMac = :DaNiemMac,
TrieuChungXuatHuyet = :TrieuChungXuatHuyet,
HeThongLong_Toc_Mong = :HeThongLong_Toc_Mong,
TrieuChungPhu = :TrieuChungPhu,
TuyenGiap = :TuyenGiap,
KichThuoc_Gan = :KichThuoc_Gan,
MatDo_Gan = :MatDo_Gan,
Bo_Gan = :Bo_Gan,
MatGan_Gan = :MatGan_Gan,
Dau_Gan = :Dau_Gan,
KichThuoc_Lach = :KichThuoc_Lach,
MatDo_Lach = :MatDo_Lach,
Bo_Lach = :Bo_Lach,
MatGan_Lach = :MatGan_Lach,
Dau_Lach = :Dau_Lach,
ViTri_Hach = :ViTri_Hach,
KichThuoc_Hach = :KichThuoc_Hach,
SoLuong_Hach = :SoLuong_Hach,
DoDiDong_Hach = :DoDiDong_Hach,
MatHach_Hach = :MatHach_Hach,
Dau_Hach = :Dau_Hach,
HuyetDo = :HuyetDo,
TuyDo = :TuyDo,
SinhThietTuy = :SinhThietTuy,
SinhThietHach = :SinhThietHach,
DongMauToanBo = :DongMauToanBo,
DinhLuongYeuToMauDong = :DinhLuongYeuToMauDong,
DienDiHST = :DienDiHST,
NhiemSacThe = :NhiemSacThe,
NhomMau = :NhomMau,
CoombsTest = :CoombsTest,
KhangTheBatThuong = :KhangTheBatThuong,
SinhHoa = :SinhHoa,
GPB = :GPB,
ViSinh = :ViSinh,
XQuang = :XQuang,
KhoiHongCau = :KhoiHongCau,
HuyetTuuong = :HuyetTuuong,
HongCauRua = :HongCauRua,
HuyetTuongDongLanh = :HuyetTuongDongLanh,
KhoiTieuCau = :KhoiTieuCau,
TuaVIII = :TuaVIII,
KhoiBachCauHat = :KhoiBachCauHat,
TruyenMauToanPhan = :TruyenMauToanPhan,
CacPhanUngKhiTruyenMau = :CacPhanUngKhiTruyenMau,
PhanTichTeBao = :PhanTichTeBao
                        WHERE MaQuanLy = :MaQuanLy";
            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
            Command.Parameters.Add(new MDB.MDBParameter("LyDoVaoVien", BenhAnHuyetHocTruyenMau.LyDoVaoVien));
            Command.Parameters.Add(new MDB.MDBParameter("VaoNgayThu", BenhAnHuyetHocTruyenMau.VaoNgayThu));
            Command.Parameters.Add(new MDB.MDBParameter("QuaTrinhBenhLy", BenhAnHuyetHocTruyenMau.QuaTrinhBenhLy));
            Command.Parameters.Add(new MDB.MDBParameter("TienSuBenhBanThan", BenhAnHuyetHocTruyenMau.TienSuBenhBanThan));
            Command.Parameters.Add(new MDB.MDBParameter("TienSuBenhGiaDinh", BenhAnHuyetHocTruyenMau.TienSuBenhGiaDinh));
            Command.Parameters.Add(new MDB.MDBParameter("ToanThan", BenhAnHuyetHocTruyenMau.ToanThan));
            Command.Parameters.Add(new MDB.MDBParameter("TuanHoan", BenhAnHuyetHocTruyenMau.TuanHoan));
            Command.Parameters.Add(new MDB.MDBParameter("HoHap", BenhAnHuyetHocTruyenMau.HoHap));
            Command.Parameters.Add(new MDB.MDBParameter("TieuHoa", BenhAnHuyetHocTruyenMau.TieuHoa));
            Command.Parameters.Add(new MDB.MDBParameter("ThanTietNieuSinhDuc", BenhAnHuyetHocTruyenMau.ThanTietNieuSinhDuc));
            Command.Parameters.Add(new MDB.MDBParameter("ThanKinh", BenhAnHuyetHocTruyenMau.ThanKinh));
            Command.Parameters.Add(new MDB.MDBParameter("CoXuongKhop", BenhAnHuyetHocTruyenMau.CoXuongKhop));
            Command.Parameters.Add(new MDB.MDBParameter("TaiMuiHong", BenhAnHuyetHocTruyenMau.TaiMuiHong));
            Command.Parameters.Add(new MDB.MDBParameter("RangHamMat", BenhAnHuyetHocTruyenMau.RangHamMat));
            Command.Parameters.Add(new MDB.MDBParameter("Mat", BenhAnHuyetHocTruyenMau.Mat));
            Command.Parameters.Add(new MDB.MDBParameter("Khac_CacCoQuan", BenhAnHuyetHocTruyenMau.Khac_CacCoQuan));
            Command.Parameters.Add(new MDB.MDBParameter("CacXetNghiemCanLamSangCanLam", BenhAnHuyetHocTruyenMau.CacXetNghiemCanLamSangCanLam));
            Command.Parameters.Add(new MDB.MDBParameter("TomTatBenhAn", BenhAnHuyetHocTruyenMau.TomTatBenhAn));
            Command.Parameters.Add(new MDB.MDBParameter("BenhChinh", BenhAnHuyetHocTruyenMau.BenhChinh));
            Command.Parameters.Add(new MDB.MDBParameter("BenhKemTheo", BenhAnHuyetHocTruyenMau.BenhKemTheo));
            Command.Parameters.Add(new MDB.MDBParameter("PhanBiet", BenhAnHuyetHocTruyenMau.PhanBiet));
            Command.Parameters.Add(new MDB.MDBParameter("TienLuong", BenhAnHuyetHocTruyenMau.TienLuong));
            Command.Parameters.Add(new MDB.MDBParameter("HuongDieuTri", BenhAnHuyetHocTruyenMau.HuongDieuTri));
            Command.Parameters.Add(new MDB.MDBParameter("NgayKhamBenh", BenhAnHuyetHocTruyenMau.NgayKhamBenh));
            Command.Parameters.Add(new MDB.MDBParameter("BacSyLamBenhAn", BenhAnHuyetHocTruyenMau.BacSyLamBenhAn));
            Command.Parameters.Add(new MDB.MDBParameter("QuaTrinhBenhLyVaDienBien", BenhAnHuyetHocTruyenMau.QuaTrinhBenhLyVaDienBien));
            Command.Parameters.Add(new MDB.MDBParameter("TomTatKetQuaXetNghiem", BenhAnHuyetHocTruyenMau.TomTatKetQuaXetNghiem));
            Command.Parameters.Add(new MDB.MDBParameter("PhuongPhapDieuTri", BenhAnHuyetHocTruyenMau.PhuongPhapDieuTri));
            Command.Parameters.Add(new MDB.MDBParameter("TinhTrangNguoiBenhRaVien", BenhAnHuyetHocTruyenMau.TinhTrangNguoiBenhRaVien));
            Command.Parameters.Add(new MDB.MDBParameter("HuongDieuTriVaCacCheDoTiepTheo", BenhAnHuyetHocTruyenMau.HuongDieuTriVaCacCheDoTiepTheo));
            Command.Parameters.Add(new MDB.MDBParameter("NguoiNhanHoSo", BenhAnHuyetHocTruyenMau.NguoiNhanHoSo));
            Command.Parameters.Add(new MDB.MDBParameter("NguoiGiaoHoSo", BenhAnHuyetHocTruyenMau.NguoiGiaoHoSo));
            Command.Parameters.Add(new MDB.MDBParameter("NgayTongKet", BenhAnHuyetHocTruyenMau.NgayTongKet));
            Command.Parameters.Add(new MDB.MDBParameter("BacSyDieuTri", BenhAnHuyetHocTruyenMau.BacSyDieuTri));
            Command.Parameters.Add(new MDB.MDBParameter("DiUng", BenhAnHuyetHocTruyenMau.DacDiemLienQuanBenh.DiUng == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("DiUng_Text", BenhAnHuyetHocTruyenMau.DacDiemLienQuanBenh.DiUng_Text));
            Command.Parameters.Add(new MDB.MDBParameter("MaTuy", BenhAnHuyetHocTruyenMau.DacDiemLienQuanBenh.MaTuy == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("MaTuy_Text", BenhAnHuyetHocTruyenMau.DacDiemLienQuanBenh.MaTuy_Text));
            Command.Parameters.Add(new MDB.MDBParameter("RuouBia", BenhAnHuyetHocTruyenMau.DacDiemLienQuanBenh.RuouBia == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("RuouBia_Text", BenhAnHuyetHocTruyenMau.DacDiemLienQuanBenh.RuouBia_Text));
            Command.Parameters.Add(new MDB.MDBParameter("ThuocLa", BenhAnHuyetHocTruyenMau.DacDiemLienQuanBenh.ThuocLa == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("ThuocLa_Text", BenhAnHuyetHocTruyenMau.DacDiemLienQuanBenh.ThuocLa_Text));
            Command.Parameters.Add(new MDB.MDBParameter("ThuocLao", BenhAnHuyetHocTruyenMau.DacDiemLienQuanBenh.ThuocLao == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("ThuocLao_Text", BenhAnHuyetHocTruyenMau.DacDiemLienQuanBenh.ThuocLao_Text));
            Command.Parameters.Add(new MDB.MDBParameter("Khac_DacDiemLienQuanBenh", BenhAnHuyetHocTruyenMau.DacDiemLienQuanBenh.Khac_DacDiemLienQuanBenh == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("Khac_DacDiemLienQuanBenh_Text", BenhAnHuyetHocTruyenMau.DacDiemLienQuanBenh.Khac_DacDiemLienQuanBenh_Text));
            Command.Parameters.Add(new MDB.MDBParameter("TinhThanCuaNguoiBenh", BenhAnHuyetHocTruyenMau.TinhThanCuaNguoiBenh));
            Command.Parameters.Add(new MDB.MDBParameter("HinhDangTuThe", BenhAnHuyetHocTruyenMau.HinhDangTuThe));
            Command.Parameters.Add(new MDB.MDBParameter("DaNiemMac", BenhAnHuyetHocTruyenMau.DaNiemMac));
            Command.Parameters.Add(new MDB.MDBParameter("TrieuChungXuatHuyet", BenhAnHuyetHocTruyenMau.TrieuChungXuatHuyet));
            Command.Parameters.Add(new MDB.MDBParameter("HeThongLong_Toc_Mong", BenhAnHuyetHocTruyenMau.HeThongLong_Toc_Mong));
            Command.Parameters.Add(new MDB.MDBParameter("TrieuChungPhu", BenhAnHuyetHocTruyenMau.TrieuChungPhu));
            Command.Parameters.Add(new MDB.MDBParameter("TuyenGiap", BenhAnHuyetHocTruyenMau.TuyenGiap));
            Command.Parameters.Add(new MDB.MDBParameter("KichThuoc_Gan", BenhAnHuyetHocTruyenMau.KichThuoc_Gan));
            Command.Parameters.Add(new MDB.MDBParameter("MatDo_Gan", BenhAnHuyetHocTruyenMau.MatDo_Gan));
            Command.Parameters.Add(new MDB.MDBParameter("Bo_Gan", BenhAnHuyetHocTruyenMau.Bo_Gan));
            Command.Parameters.Add(new MDB.MDBParameter("MatGan_Gan", BenhAnHuyetHocTruyenMau.MatGan_Gan));
            Command.Parameters.Add(new MDB.MDBParameter("Dau_Gan", BenhAnHuyetHocTruyenMau.Dau_Gan));
            Command.Parameters.Add(new MDB.MDBParameter("KichThuoc_Lach", BenhAnHuyetHocTruyenMau.KichThuoc_Lach));
            Command.Parameters.Add(new MDB.MDBParameter("MatDo_Lach", BenhAnHuyetHocTruyenMau.MatDo_Lach));
            Command.Parameters.Add(new MDB.MDBParameter("Bo_Lach", BenhAnHuyetHocTruyenMau.Bo_Lach));
            Command.Parameters.Add(new MDB.MDBParameter("MatGan_Lach", BenhAnHuyetHocTruyenMau.MatGan_Lach));
            Command.Parameters.Add(new MDB.MDBParameter("Dau_Lach", BenhAnHuyetHocTruyenMau.Dau_Lach));
            Command.Parameters.Add(new MDB.MDBParameter("ViTri_Hach", BenhAnHuyetHocTruyenMau.ViTri_Hach));
            Command.Parameters.Add(new MDB.MDBParameter("KichThuoc_Hach", BenhAnHuyetHocTruyenMau.KichThuoc_Hach));
            Command.Parameters.Add(new MDB.MDBParameter("SoLuong_Hach", BenhAnHuyetHocTruyenMau.SoLuong_Hach));
            Command.Parameters.Add(new MDB.MDBParameter("DoDiDong_Hach", BenhAnHuyetHocTruyenMau.DoDiDong_Hach));
            Command.Parameters.Add(new MDB.MDBParameter("MatHach_Hach", BenhAnHuyetHocTruyenMau.MatHach_Hach));
            Command.Parameters.Add(new MDB.MDBParameter("Dau_Hach", BenhAnHuyetHocTruyenMau.Dau_Hach));
            Command.Parameters.Add(new MDB.MDBParameter("HuyetDo", BenhAnHuyetHocTruyenMau.HuyetDo == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("TuyDo", BenhAnHuyetHocTruyenMau.TuyDo == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("SinhThietTuy", BenhAnHuyetHocTruyenMau.SinhThietTuy == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("SinhThietHach", BenhAnHuyetHocTruyenMau.SinhThietHach == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("DongMauToanBo", BenhAnHuyetHocTruyenMau.DongMauToanBo == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("DinhLuongYeuToMauDong", BenhAnHuyetHocTruyenMau.DinhLuongYeuToMauDong == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("DienDiHST", BenhAnHuyetHocTruyenMau.DienDiHST == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("NhiemSacThe", BenhAnHuyetHocTruyenMau.NhiemSacThe == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("NhomMau", BenhAnHuyetHocTruyenMau.NhomMau == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("CoombsTest", BenhAnHuyetHocTruyenMau.CoombsTest == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("KhangTheBatThuong", BenhAnHuyetHocTruyenMau.KhangTheBatThuong == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("SinhHoa", BenhAnHuyetHocTruyenMau.SinhHoa == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("GPB", BenhAnHuyetHocTruyenMau.GPB == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("ViSinh", BenhAnHuyetHocTruyenMau.ViSinh == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("XQuang", BenhAnHuyetHocTruyenMau.XQuang == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("KhoiHongCau", BenhAnHuyetHocTruyenMau.KhoiHongCau));
            Command.Parameters.Add(new MDB.MDBParameter("HuyetTuuong", BenhAnHuyetHocTruyenMau.HuyetTuuong));
            Command.Parameters.Add(new MDB.MDBParameter("HongCauRua", BenhAnHuyetHocTruyenMau.HongCauRua));
            Command.Parameters.Add(new MDB.MDBParameter("HuyetTuongDongLanh", BenhAnHuyetHocTruyenMau.HuyetTuongDongLanh));
            Command.Parameters.Add(new MDB.MDBParameter("KhoiTieuCau", BenhAnHuyetHocTruyenMau.KhoiTieuCau));
            Command.Parameters.Add(new MDB.MDBParameter("TuaVIII", BenhAnHuyetHocTruyenMau.TuaVIII));
            Command.Parameters.Add(new MDB.MDBParameter("KhoiBachCauHat", BenhAnHuyetHocTruyenMau.KhoiBachCauHat));
            Command.Parameters.Add(new MDB.MDBParameter("TruyenMauToanPhan", BenhAnHuyetHocTruyenMau.TruyenMauToanPhan));
            Command.Parameters.Add(new MDB.MDBParameter("CacPhanUngKhiTruyenMau", BenhAnHuyetHocTruyenMau.CacPhanUngKhiTruyenMau));
            Command.Parameters.Add(new MDB.MDBParameter("PhanTichTeBao", BenhAnHuyetHocTruyenMau.PhanTichTeBao == true ? "1" : "0"));

            Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", BenhAnHuyetHocTruyenMau.MaQuanLy));
            int n = Command.ExecuteNonQuery(); // C#
            return n > 0 ? true : false;
        }
        public static bool Delete(MDB.MDBConnection MyConnection, BenhAnHuyetHocTruyenMau BenhAnHuyetHocTruyenMau)
        {
            string sql = @"DELETE FROM BenhAnHuyetHocTruyenMau 
                           WHERE MaQuanLy = :MaQuanLy";
            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
            Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", BenhAnHuyetHocTruyenMau.MaQuanLy));

            int n = Command.ExecuteNonQuery(); // C#
            return n > 0 ? true : false;
        }
    }
}
