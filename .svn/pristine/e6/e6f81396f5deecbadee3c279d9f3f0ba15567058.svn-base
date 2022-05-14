using System.Data;

namespace EMR_MAIN
{
    public class BenhAnTamThanFunc
    {
        public static void WriteXml(MDB.MDBConnection MyConnection)
        {
            string sql =
                   @"
                  select  a.*,  CTScanner HoSo_CTScanner, SieuAm HoSo_SieuAm, XetNghiem HoSo_XetNghiem,  Khac HoSo_Khac,  Khac_Text HoSo_Khac_Text,  ToanBoHoSo HoSo_ToanBoHoSo, Mach DauSinhTon_Mach,  NhietDo DauSinhTon_NhietDo,  HuyetAp DauSinhTon_HuyetAp,  NhipTho DauSinhTon_NhipTho,  CanNang DauSinhTon_CanNang  
                  from BenhAnTamThan a inner join thongtindieutri b on a.maquanly = b.maquanly
                  where rownum = 1
                    ";
            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
            MDB.MDBDataReader DataReader = Command.ExecuteReader();

            var DataTable = new DataTable { TableName = "BenhAnTamThan" };
            DataTable.Load(DataReader as IDataReader);
            DataTable.WriteXml("rptBenhAnTamThan.xml");
        }
        public static DataSet SelectDataSet(MDB.MDBConnection MyConnection, decimal MaQuanLy)
        {
            string sql =
                   @"
                   select  a.*,f.hovaten BacSyLamBenhAnHoVaTen ,c.hovaten BacSyDieuTriHoVaTen,d.hovaten NguoiGiaoHoSoHoVaTen,e.hovaten NguoiNhanHoSoHoVaTen, b.XQuang HoSo_XQuang,   b.CTScanner HoSo_CTScanner, b.SieuAm HoSo_SieuAm, b.XetNghiem HoSo_XetNghiem,  b.Khac HoSo_Khac,  b.Khac_Text HoSo_Khac_Text,  b.ToanBoHoSo HoSo_ToanBoHoSo, b.Mach DauSinhTon_Mach, b.NhietDo DauSinhTon_NhietDo,  b.HuyetAp DauSinhTon_HuyetAp,  b.NhipTho DauSinhTon_NhipTho,  b.CanNang DauSinhTon_CanNang  , b.ChieuCao DauSinhTon_ChieuCao, b.BMI DauSinhTon_BMI, b.NgayRaVien 
                 from BenhAnTamThan a 
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
        public static BenhAnTamThan Select(MDB.MDBConnection MyConnection, decimal MaQuanLy)
        {
            #region
            string sql =
                      @"select * 
                        from BenhAnTamThan a
                        where MaQuanLy = :MaQuanLy";
            #endregion
            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
            Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", MaQuanLy));
            MDB.MDBDataReader DataReader = Command.ExecuteReader();
            var value = new BenhAnTamThan();
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
                value.DayThanKinhSoNao = DataReader["DayThanKinhSoNao"].ToString();
                value.DayMat = DataReader["DayMat"].ToString();
                value.VanDong = DataReader["VanDong"].ToString();
                value.TruongLucCo = DataReader["TruongLucCo"].ToString();
                value.CamGiac = DataReader["CamGiac"].ToString();
                value.PhanXa = DataReader["PhanXa"].ToString();
                value.BieuHienChung = DataReader["BieuHienChung"].ToString();
                value.KhongGian = DataReader["KhongGian"].ToString();
                value.ThoiGian = DataReader["ThoiGian"].ToString();
                value.BanThan = DataReader["BanThan"].ToString();
                value.TinhCamCamXuc = DataReader["TinhCamCamXuc"].ToString();
                value.TriGiac = DataReader["TriGiac"].ToString();
                value.HinhThuc = DataReader["HinhThuc"].ToString();
                value.NoiDung = DataReader["NoiDung"].ToString();
                value.HoatDongCoYChi = DataReader["HoatDongCoYChi"].ToString();
                value.HoatDongBanNang = DataReader["HoatDongBanNang"].ToString();
                value.NhoMayMoc = DataReader["NhoMayMoc"].ToString();
                value.NhoThongHieu = DataReader["NhoThongHieu"].ToString();
                value.KhaNangPhanTich = DataReader["KhaNangPhanTich"].ToString();
                value.KhaNangTongHop = DataReader["KhaNangTongHop"].ToString();
                value.ChuY = DataReader["ChuY"].ToString();
                value.GiaiPhauBenh = DataReader["GiaiPhauBenh"].ToString();
                value.GiaiPhauBenhID = DataReader.GetInt("GiaiPhauBenhID");
                value.MaSoKyTen = DataReader["masokyten"].ToString();
                value.MaSoKyTen_KB = DataReader["masokyten_kb"].ToString();
                value.MaSoKyTen_TK = DataReader["masokyten_tk"].ToString();
            }
            return value;
        }

        public static bool InsertOrUpdate(MDB.MDBConnection MyConnection, BenhAnTamThan BenhAnTamThan)
        {
            string sql =
                      @"select MaQuanLy 
                        from BenhAnTamThan
                        where MaQuanLy = :MaQuanLy";
            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
            Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", BenhAnTamThan.MaQuanLy));
            MDB.MDBDataReader DataReader = Command.ExecuteReader();
            int rowCount = 0;
            while (DataReader.Read()) rowCount++;
            if (rowCount == 1) return Update(MyConnection, BenhAnTamThan);
            sql = @"
                   INSERT INTO BenhAnTamThan (MaQuanLy, LyDoVaoVien, VaoNgayThu, QuaTrinhBenhLy, TienSuBenhBanThan, TienSuBenhGiaDinh, ToanThan, TuanHoan, HoHap, TieuHoa, ThanTietNieuSinhDuc, ThanKinh, CoXuongKhop, TaiMuiHong, RangHamMat, Mat, Khac_CacCoQuan, CacXetNghiemCanLamSangCanLam, TomTatBenhAn, BenhChinh, BenhKemTheo, PhanBiet, TienLuong, HuongDieuTri, NgayKhamBenh, BacSyLamBenhAn, QuaTrinhBenhLyVaDienBien, TomTatKetQuaXetNghiem, PhuongPhapDieuTri, TinhTrangNguoiBenhRaVien, HuongDieuTriVaCacCheDoTiepTheo, NguoiNhanHoSo, NguoiGiaoHoSo, NgayTongKet, BacSyDieuTri, DiUng, DiUng_Text, MaTuy, MaTuy_Text, RuouBia, RuouBia_Text, ThuocLa, ThuocLa_Text, ThuocLao, ThuocLao_Text, Khac_DacDiemLienQuanBenh, Khac_DacDiemLienQuanBenh_Text, DayThanKinhSoNao, DayMat, VanDong, TruongLucCo, CamGiac, PhanXa, BieuHienChung, KhongGian, ThoiGian, BanThan, TinhCamCamXuc, TriGiac, HinhThuc, NoiDung, HoatDongCoYChi, HoatDongBanNang, NhoMayMoc, NhoThongHieu, KhaNangPhanTich, KhaNangTongHop, ChuY, GiaiPhauBenh, GiaiPhauBenhID)
                   VALUES(:MaQuanLy, :LyDoVaoVien, :VaoNgayThu, :QuaTrinhBenhLy, :TienSuBenhBanThan, :TienSuBenhGiaDinh, :ToanThan, :TuanHoan, :HoHap, :TieuHoa, :ThanTietNieuSinhDuc, :ThanKinh, :CoXuongKhop, :TaiMuiHong, :RangHamMat, :Mat, :Khac_CacCoQuan, :CacXetNghiemCanLamSangCanLam, :TomTatBenhAn, :BenhChinh, :BenhKemTheo, :PhanBiet, :TienLuong, :HuongDieuTri, :NgayKhamBenh, :BacSyLamBenhAn, :QuaTrinhBenhLyVaDienBien, :TomTatKetQuaXetNghiem, :PhuongPhapDieuTri, :TinhTrangNguoiBenhRaVien, :HuongDieuTriVaCacCheDoTiepTheo, :NguoiNhanHoSo, :NguoiGiaoHoSo, :NgayTongKet, :BacSyDieuTri, :DiUng, :DiUng_Text, :MaTuy, :MaTuy_Text, :RuouBia, :RuouBia_Text, :ThuocLa, :ThuocLa_Text, :ThuocLao, :ThuocLao_Text, :Khac_DacDiemLienQuanBenh, :Khac_DacDiemLienQuanBenh_Text, :DayThanKinhSoNao, :DayMat, :VanDong, :TruongLucCo, :CamGiac, :PhanXa, :BieuHienChung, :KhongGian, :ThoiGian, :BanThan, :TinhCamCamXuc, :TriGiac, :HinhThuc, :NoiDung, :HoatDongCoYChi, :HoatDongBanNang, :NhoMayMoc, :NhoThongHieu, :KhaNangPhanTich, :KhaNangTongHop, :ChuY, :GiaiPhauBenh, :GiaiPhauBenhID)
                   ";
            Command = new MDB.MDBCommand(sql, MyConnection);
            Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", BenhAnTamThan.MaQuanLy));
            Command.Parameters.Add(new MDB.MDBParameter("LyDoVaoVien", BenhAnTamThan.LyDoVaoVien));
            Command.Parameters.Add(new MDB.MDBParameter("VaoNgayThu", BenhAnTamThan.VaoNgayThu));
            Command.Parameters.Add(new MDB.MDBParameter("QuaTrinhBenhLy", BenhAnTamThan.QuaTrinhBenhLy));
            Command.Parameters.Add(new MDB.MDBParameter("TienSuBenhBanThan", BenhAnTamThan.TienSuBenhBanThan));
            Command.Parameters.Add(new MDB.MDBParameter("TienSuBenhGiaDinh", BenhAnTamThan.TienSuBenhGiaDinh));
            Command.Parameters.Add(new MDB.MDBParameter("ToanThan", BenhAnTamThan.ToanThan));
            Command.Parameters.Add(new MDB.MDBParameter("TuanHoan", BenhAnTamThan.TuanHoan));
            Command.Parameters.Add(new MDB.MDBParameter("HoHap", BenhAnTamThan.HoHap));
            Command.Parameters.Add(new MDB.MDBParameter("TieuHoa", BenhAnTamThan.TieuHoa));
            Command.Parameters.Add(new MDB.MDBParameter("ThanTietNieuSinhDuc", BenhAnTamThan.ThanTietNieuSinhDuc));
            Command.Parameters.Add(new MDB.MDBParameter("ThanKinh", BenhAnTamThan.ThanKinh));
            Command.Parameters.Add(new MDB.MDBParameter("CoXuongKhop", BenhAnTamThan.CoXuongKhop));
            Command.Parameters.Add(new MDB.MDBParameter("TaiMuiHong", BenhAnTamThan.TaiMuiHong));
            Command.Parameters.Add(new MDB.MDBParameter("RangHamMat", BenhAnTamThan.RangHamMat));
            Command.Parameters.Add(new MDB.MDBParameter("Mat", BenhAnTamThan.Mat));
            Command.Parameters.Add(new MDB.MDBParameter("Khac_CacCoQuan", BenhAnTamThan.Khac_CacCoQuan));
            Command.Parameters.Add(new MDB.MDBParameter("CacXetNghiemCanLamSangCanLam", BenhAnTamThan.CacXetNghiemCanLamSangCanLam));
            Command.Parameters.Add(new MDB.MDBParameter("TomTatBenhAn", BenhAnTamThan.TomTatBenhAn));
            Command.Parameters.Add(new MDB.MDBParameter("BenhChinh", BenhAnTamThan.BenhChinh));
            Command.Parameters.Add(new MDB.MDBParameter("BenhKemTheo", BenhAnTamThan.BenhKemTheo));
            Command.Parameters.Add(new MDB.MDBParameter("PhanBiet", BenhAnTamThan.PhanBiet));
            Command.Parameters.Add(new MDB.MDBParameter("TienLuong", BenhAnTamThan.TienLuong));
            Command.Parameters.Add(new MDB.MDBParameter("HuongDieuTri", BenhAnTamThan.HuongDieuTri));
            Command.Parameters.Add(new MDB.MDBParameter("NgayKhamBenh", BenhAnTamThan.NgayKhamBenh));
            Command.Parameters.Add(new MDB.MDBParameter("BacSyLamBenhAn", BenhAnTamThan.BacSyLamBenhAn));
            Command.Parameters.Add(new MDB.MDBParameter("QuaTrinhBenhLyVaDienBien", BenhAnTamThan.QuaTrinhBenhLyVaDienBien));
            Command.Parameters.Add(new MDB.MDBParameter("TomTatKetQuaXetNghiem", BenhAnTamThan.TomTatKetQuaXetNghiem));
            Command.Parameters.Add(new MDB.MDBParameter("PhuongPhapDieuTri", BenhAnTamThan.PhuongPhapDieuTri));
            Command.Parameters.Add(new MDB.MDBParameter("TinhTrangNguoiBenhRaVien", BenhAnTamThan.TinhTrangNguoiBenhRaVien));
            Command.Parameters.Add(new MDB.MDBParameter("HuongDieuTriVaCacCheDoTiepTheo", BenhAnTamThan.HuongDieuTriVaCacCheDoTiepTheo));
            Command.Parameters.Add(new MDB.MDBParameter("NguoiNhanHoSo", BenhAnTamThan.NguoiNhanHoSo));
            Command.Parameters.Add(new MDB.MDBParameter("NguoiGiaoHoSo", BenhAnTamThan.NguoiGiaoHoSo));
            Command.Parameters.Add(new MDB.MDBParameter("NgayTongKet", BenhAnTamThan.NgayTongKet));
            Command.Parameters.Add(new MDB.MDBParameter("BacSyDieuTri", BenhAnTamThan.BacSyDieuTri));
            Command.Parameters.Add(new MDB.MDBParameter("DiUng", BenhAnTamThan.DacDiemLienQuanBenh.DiUng == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("DiUng_Text", BenhAnTamThan.DacDiemLienQuanBenh.DiUng_Text));
            Command.Parameters.Add(new MDB.MDBParameter("MaTuy", BenhAnTamThan.DacDiemLienQuanBenh.MaTuy == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("MaTuy_Text", BenhAnTamThan.DacDiemLienQuanBenh.MaTuy_Text));
            Command.Parameters.Add(new MDB.MDBParameter("RuouBia", BenhAnTamThan.DacDiemLienQuanBenh.RuouBia == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("RuouBia_Text", BenhAnTamThan.DacDiemLienQuanBenh.RuouBia_Text));
            Command.Parameters.Add(new MDB.MDBParameter("ThuocLa", BenhAnTamThan.DacDiemLienQuanBenh.ThuocLa == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("ThuocLa_Text", BenhAnTamThan.DacDiemLienQuanBenh.ThuocLa_Text));
            Command.Parameters.Add(new MDB.MDBParameter("ThuocLao", BenhAnTamThan.DacDiemLienQuanBenh.ThuocLao == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("ThuocLao_Text", BenhAnTamThan.DacDiemLienQuanBenh.ThuocLao_Text));
            Command.Parameters.Add(new MDB.MDBParameter("Khac_DacDiemLienQuanBenh", BenhAnTamThan.DacDiemLienQuanBenh.Khac_DacDiemLienQuanBenh == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("Khac_DacDiemLienQuanBenh_Text", BenhAnTamThan.DacDiemLienQuanBenh.Khac_DacDiemLienQuanBenh_Text));
            Command.Parameters.Add(new MDB.MDBParameter("DayThanKinhSoNao", BenhAnTamThan.DayThanKinhSoNao));
            Command.Parameters.Add(new MDB.MDBParameter("DayMat", BenhAnTamThan.DayMat));
            Command.Parameters.Add(new MDB.MDBParameter("VanDong", BenhAnTamThan.VanDong));
            Command.Parameters.Add(new MDB.MDBParameter("TruongLucCo", BenhAnTamThan.TruongLucCo));
            Command.Parameters.Add(new MDB.MDBParameter("CamGiac", BenhAnTamThan.CamGiac));
            Command.Parameters.Add(new MDB.MDBParameter("PhanXa", BenhAnTamThan.PhanXa));
            Command.Parameters.Add(new MDB.MDBParameter("BieuHienChung", BenhAnTamThan.BieuHienChung));
            Command.Parameters.Add(new MDB.MDBParameter("KhongGian", BenhAnTamThan.KhongGian));
            Command.Parameters.Add(new MDB.MDBParameter("ThoiGian", BenhAnTamThan.ThoiGian));
            Command.Parameters.Add(new MDB.MDBParameter("BanThan", BenhAnTamThan.BanThan));
            Command.Parameters.Add(new MDB.MDBParameter("TinhCamCamXuc", BenhAnTamThan.TinhCamCamXuc));
            Command.Parameters.Add(new MDB.MDBParameter("TriGiac", BenhAnTamThan.TriGiac));
            Command.Parameters.Add(new MDB.MDBParameter("HinhThuc", BenhAnTamThan.HinhThuc));
            Command.Parameters.Add(new MDB.MDBParameter("NoiDung", BenhAnTamThan.NoiDung));
            Command.Parameters.Add(new MDB.MDBParameter("HoatDongCoYChi", BenhAnTamThan.HoatDongCoYChi));
            Command.Parameters.Add(new MDB.MDBParameter("HoatDongBanNang", BenhAnTamThan.HoatDongBanNang));
            Command.Parameters.Add(new MDB.MDBParameter("NhoMayMoc", BenhAnTamThan.NhoMayMoc));
            Command.Parameters.Add(new MDB.MDBParameter("NhoThongHieu", BenhAnTamThan.NhoThongHieu));
            Command.Parameters.Add(new MDB.MDBParameter("KhaNangPhanTich", BenhAnTamThan.KhaNangPhanTich));
            Command.Parameters.Add(new MDB.MDBParameter("KhaNangTongHop", BenhAnTamThan.KhaNangTongHop));
            Command.Parameters.Add(new MDB.MDBParameter("ChuY", BenhAnTamThan.ChuY));
            Command.Parameters.Add(new MDB.MDBParameter("GiaiPhauBenh", BenhAnTamThan.GiaiPhauBenh));
            Command.Parameters.Add(new MDB.MDBParameter("GiaiPhauBenhID", BenhAnTamThan.GiaiPhauBenhID));


            int n = Command.ExecuteNonQuery(); // C#
            return n > 0 ? true : false;
        }
        public static bool Update(MDB.MDBConnection MyConnection, BenhAnTamThan BenhAnTamThan)
        {
            string sql = @"UPDATE BenhAnTamThan SET 
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
DayThanKinhSoNao = :DayThanKinhSoNao,
DayMat = :DayMat,
VanDong = :VanDong,
TruongLucCo = :TruongLucCo,
CamGiac = :CamGiac,
PhanXa = :PhanXa,
BieuHienChung = :BieuHienChung,
KhongGian = :KhongGian,
ThoiGian = :ThoiGian,
BanThan = :BanThan,
TinhCamCamXuc = :TinhCamCamXuc,
TriGiac = :TriGiac,
HinhThuc = :HinhThuc,
NoiDung = :NoiDung,
HoatDongCoYChi = :HoatDongCoYChi,
HoatDongBanNang = :HoatDongBanNang,
NhoMayMoc = :NhoMayMoc,
NhoThongHieu = :NhoThongHieu,
KhaNangPhanTich = :KhaNangPhanTich,
KhaNangTongHop = :KhaNangTongHop,
ChuY = :ChuY,
GiaiPhauBenh = :GiaiPhauBenh,
GiaiPhauBenhID = :GiaiPhauBenhID
                        WHERE MaQuanLy = :MaQuanLy";
            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
            Command.Parameters.Add(new MDB.MDBParameter("LyDoVaoVien", BenhAnTamThan.LyDoVaoVien));
            Command.Parameters.Add(new MDB.MDBParameter("VaoNgayThu", BenhAnTamThan.VaoNgayThu));
            Command.Parameters.Add(new MDB.MDBParameter("QuaTrinhBenhLy", BenhAnTamThan.QuaTrinhBenhLy));
            Command.Parameters.Add(new MDB.MDBParameter("TienSuBenhBanThan", BenhAnTamThan.TienSuBenhBanThan));
            Command.Parameters.Add(new MDB.MDBParameter("TienSuBenhGiaDinh", BenhAnTamThan.TienSuBenhGiaDinh));
            Command.Parameters.Add(new MDB.MDBParameter("ToanThan", BenhAnTamThan.ToanThan));
            Command.Parameters.Add(new MDB.MDBParameter("TuanHoan", BenhAnTamThan.TuanHoan));
            Command.Parameters.Add(new MDB.MDBParameter("HoHap", BenhAnTamThan.HoHap));
            Command.Parameters.Add(new MDB.MDBParameter("TieuHoa", BenhAnTamThan.TieuHoa));
            Command.Parameters.Add(new MDB.MDBParameter("ThanTietNieuSinhDuc", BenhAnTamThan.ThanTietNieuSinhDuc));
            Command.Parameters.Add(new MDB.MDBParameter("ThanKinh", BenhAnTamThan.ThanKinh));
            Command.Parameters.Add(new MDB.MDBParameter("CoXuongKhop", BenhAnTamThan.CoXuongKhop));
            Command.Parameters.Add(new MDB.MDBParameter("TaiMuiHong", BenhAnTamThan.TaiMuiHong));
            Command.Parameters.Add(new MDB.MDBParameter("RangHamMat", BenhAnTamThan.RangHamMat));
            Command.Parameters.Add(new MDB.MDBParameter("Mat", BenhAnTamThan.Mat));
            Command.Parameters.Add(new MDB.MDBParameter("Khac_CacCoQuan", BenhAnTamThan.Khac_CacCoQuan));
            Command.Parameters.Add(new MDB.MDBParameter("CacXetNghiemCanLamSangCanLam", BenhAnTamThan.CacXetNghiemCanLamSangCanLam));
            Command.Parameters.Add(new MDB.MDBParameter("TomTatBenhAn", BenhAnTamThan.TomTatBenhAn));
            Command.Parameters.Add(new MDB.MDBParameter("BenhChinh", BenhAnTamThan.BenhChinh));
            Command.Parameters.Add(new MDB.MDBParameter("BenhKemTheo", BenhAnTamThan.BenhKemTheo));
            Command.Parameters.Add(new MDB.MDBParameter("PhanBiet", BenhAnTamThan.PhanBiet));
            Command.Parameters.Add(new MDB.MDBParameter("TienLuong", BenhAnTamThan.TienLuong));
            Command.Parameters.Add(new MDB.MDBParameter("HuongDieuTri", BenhAnTamThan.HuongDieuTri));
            Command.Parameters.Add(new MDB.MDBParameter("NgayKhamBenh", BenhAnTamThan.NgayKhamBenh));
            Command.Parameters.Add(new MDB.MDBParameter("BacSyLamBenhAn", BenhAnTamThan.BacSyLamBenhAn));
            Command.Parameters.Add(new MDB.MDBParameter("QuaTrinhBenhLyVaDienBien", BenhAnTamThan.QuaTrinhBenhLyVaDienBien));
            Command.Parameters.Add(new MDB.MDBParameter("TomTatKetQuaXetNghiem", BenhAnTamThan.TomTatKetQuaXetNghiem));
            Command.Parameters.Add(new MDB.MDBParameter("PhuongPhapDieuTri", BenhAnTamThan.PhuongPhapDieuTri));
            Command.Parameters.Add(new MDB.MDBParameter("TinhTrangNguoiBenhRaVien", BenhAnTamThan.TinhTrangNguoiBenhRaVien));
            Command.Parameters.Add(new MDB.MDBParameter("HuongDieuTriVaCacCheDoTiepTheo", BenhAnTamThan.HuongDieuTriVaCacCheDoTiepTheo));
            Command.Parameters.Add(new MDB.MDBParameter("NguoiNhanHoSo", BenhAnTamThan.NguoiNhanHoSo));
            Command.Parameters.Add(new MDB.MDBParameter("NguoiGiaoHoSo", BenhAnTamThan.NguoiGiaoHoSo));
            Command.Parameters.Add(new MDB.MDBParameter("NgayTongKet", BenhAnTamThan.NgayTongKet));
            Command.Parameters.Add(new MDB.MDBParameter("BacSyDieuTri", BenhAnTamThan.BacSyDieuTri));
            Command.Parameters.Add(new MDB.MDBParameter("DiUng", BenhAnTamThan.DacDiemLienQuanBenh.DiUng == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("DiUng_Text", BenhAnTamThan.DacDiemLienQuanBenh.DiUng_Text));
            Command.Parameters.Add(new MDB.MDBParameter("MaTuy", BenhAnTamThan.DacDiemLienQuanBenh.MaTuy == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("MaTuy_Text", BenhAnTamThan.DacDiemLienQuanBenh.MaTuy_Text));
            Command.Parameters.Add(new MDB.MDBParameter("RuouBia", BenhAnTamThan.DacDiemLienQuanBenh.RuouBia == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("RuouBia_Text", BenhAnTamThan.DacDiemLienQuanBenh.RuouBia_Text));
            Command.Parameters.Add(new MDB.MDBParameter("ThuocLa", BenhAnTamThan.DacDiemLienQuanBenh.ThuocLa == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("ThuocLa_Text", BenhAnTamThan.DacDiemLienQuanBenh.ThuocLa_Text));
            Command.Parameters.Add(new MDB.MDBParameter("ThuocLao", BenhAnTamThan.DacDiemLienQuanBenh.ThuocLao == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("ThuocLao_Text", BenhAnTamThan.DacDiemLienQuanBenh.ThuocLao_Text));
            Command.Parameters.Add(new MDB.MDBParameter("Khac_DacDiemLienQuanBenh", BenhAnTamThan.DacDiemLienQuanBenh.Khac_DacDiemLienQuanBenh == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("Khac_DacDiemLienQuanBenh_Text", BenhAnTamThan.DacDiemLienQuanBenh.Khac_DacDiemLienQuanBenh_Text));
            Command.Parameters.Add(new MDB.MDBParameter("DayThanKinhSoNao", BenhAnTamThan.DayThanKinhSoNao));
            Command.Parameters.Add(new MDB.MDBParameter("DayMat", BenhAnTamThan.DayMat));
            Command.Parameters.Add(new MDB.MDBParameter("VanDong", BenhAnTamThan.VanDong));
            Command.Parameters.Add(new MDB.MDBParameter("TruongLucCo", BenhAnTamThan.TruongLucCo));
            Command.Parameters.Add(new MDB.MDBParameter("CamGiac", BenhAnTamThan.CamGiac));
            Command.Parameters.Add(new MDB.MDBParameter("PhanXa", BenhAnTamThan.PhanXa));
            Command.Parameters.Add(new MDB.MDBParameter("BieuHienChung", BenhAnTamThan.BieuHienChung));
            Command.Parameters.Add(new MDB.MDBParameter("KhongGian", BenhAnTamThan.KhongGian));
            Command.Parameters.Add(new MDB.MDBParameter("ThoiGian", BenhAnTamThan.ThoiGian));
            Command.Parameters.Add(new MDB.MDBParameter("BanThan", BenhAnTamThan.BanThan));
            Command.Parameters.Add(new MDB.MDBParameter("TinhCamCamXuc", BenhAnTamThan.TinhCamCamXuc));
            Command.Parameters.Add(new MDB.MDBParameter("TriGiac", BenhAnTamThan.TriGiac));
            Command.Parameters.Add(new MDB.MDBParameter("HinhThuc", BenhAnTamThan.HinhThuc));
            Command.Parameters.Add(new MDB.MDBParameter("NoiDung", BenhAnTamThan.NoiDung));
            Command.Parameters.Add(new MDB.MDBParameter("HoatDongCoYChi", BenhAnTamThan.HoatDongCoYChi));
            Command.Parameters.Add(new MDB.MDBParameter("HoatDongBanNang", BenhAnTamThan.HoatDongBanNang));
            Command.Parameters.Add(new MDB.MDBParameter("NhoMayMoc", BenhAnTamThan.NhoMayMoc));
            Command.Parameters.Add(new MDB.MDBParameter("NhoThongHieu", BenhAnTamThan.NhoThongHieu));
            Command.Parameters.Add(new MDB.MDBParameter("KhaNangPhanTich", BenhAnTamThan.KhaNangPhanTich));
            Command.Parameters.Add(new MDB.MDBParameter("KhaNangTongHop", BenhAnTamThan.KhaNangTongHop));
            Command.Parameters.Add(new MDB.MDBParameter("ChuY", BenhAnTamThan.ChuY));
            Command.Parameters.Add(new MDB.MDBParameter("GiaiPhauBenh", BenhAnTamThan.GiaiPhauBenh));
            Command.Parameters.Add(new MDB.MDBParameter("GiaiPhauBenhID", BenhAnTamThan.GiaiPhauBenhID));

            Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", BenhAnTamThan.MaQuanLy));
            int n = Command.ExecuteNonQuery(); // C#
            return n > 0 ? true : false;
        }
        public static bool Delete(MDB.MDBConnection MyConnection, BenhAnTamThan BenhAnTamThan)
        {
            string sql = @"DELETE FROM BenhAnTamThan 
                           WHERE MaQuanLy = :MaQuanLy";
            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
            Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", BenhAnTamThan.MaQuanLy));

            int n = Command.ExecuteNonQuery(); // C#
            return n > 0 ? true : false;
        }
    }
}
