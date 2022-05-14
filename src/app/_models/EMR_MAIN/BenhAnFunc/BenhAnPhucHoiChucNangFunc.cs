using System.Data;

namespace EMR_MAIN
{
    public class BenhAnPhucHoiChucNangFunc
    {
        public static void WriteXml(MDB.MDBConnection MyConnection)
        {
            string sql =
                   @"
                  select  a.*,  CTScanner HoSo_CTScanner, SieuAm HoSo_SieuAm, XetNghiem HoSo_XetNghiem,  Khac HoSo_Khac,  Khac_Text HoSo_Khac_Text,  ToanBoHoSo HoSo_ToanBoHoSo, Mach DauSinhTon_Mach,  NhietDo DauSinhTon_NhietDo,  HuyetAp DauSinhTon_HuyetAp,  NhipTho DauSinhTon_NhipTho,  CanNang DauSinhTon_CanNang  
                  from BenhAnPhucHoiChucNang a inner join thongtindieutri b on a.maquanly = b.maquanly
                  where rownum = 1
                    ";
            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
            MDB.MDBDataReader DataReader = Command.ExecuteReader();

            var DataTable = new DataTable { TableName = "BenhAnPhucHoiChucNang" };
            DataTable.Load(DataReader as IDataReader);
            DataTable.WriteXml("rptBenhAnPhucHoiChucNang.xml");
        }
        public static DataSet SelectDataSet(MDB.MDBConnection MyConnection, decimal MaQuanLy)
        {
            string sql =
                  @"select  a.*,f.hovaten BacSyLamBenhAnHoVaTen ,c.hovaten BacSyDieuTriHoVaTen,d.hovaten NguoiGiaoHoSoHoVaTen,e.hovaten NguoiNhanHoSoHoVaTen, b.XQuang HoSo_XQuang,   b.CTScanner HoSo_CTScanner, b.SieuAm HoSo_SieuAm, b.XetNghiem HoSo_XetNghiem,  b.Khac HoSo_Khac,  b.Khac_Text HoSo_Khac_Text,  b.ToanBoHoSo HoSo_ToanBoHoSo, b.Mach DauSinhTon_Mach, b.NhietDo DauSinhTon_NhietDo,  b.HuyetAp DauSinhTon_HuyetAp,  b.NhipTho DauSinhTon_NhipTho,  b.CanNang DauSinhTon_CanNang  , b.ChieuCao DauSinhTon_ChieuCao, b.BMI DauSinhTon_BMI, b.NgayRaVien 
                 from BenhAnPhucHoiChucNang a 
                 left join thongtindieutri b on a.maquanly = b.maquanly 
                  left join nhanvien c on a.bacsydieutri = c.manhanvien
                  left join nhanvien d on a.nguoigiaohoso = d.manhanvien
                  left join nhanvien e on a.nguoinhanhoso = e.manhanvien
                  left join nhanvien f on a.BacSyLamBenhAn = f.manhanvien
                  where a.maquanly = " + MaQuanLy.ToString(System.Globalization.CultureInfo.InvariantCulture);
            MDB.MDBDataAdapter adt = new MDB.MDBDataAdapter(sql, MyConnection);
            var ds = new DataSet();
            adt.Fill(ds, "Table");
            if (ds.Tables["Table"] != null && ds.Tables["Table"].Rows.Count > 0 && ERMDatabase.FTPImageString != null)
                ds.Tables["Table"].Rows[0]["hinhvetonthuongkhivaovien"] = ds.Tables["Table"].Rows[0]["hinhvetonthuongkhivaovien"].ToString().Contains("PaintLibrary") ? ds.Tables["Table"].Rows[0]["hinhvetonthuongkhivaovien"] : ERMDatabase.FTPImageString + ds.Tables["Table"].Rows[0]["hinhvetonthuongkhivaovien"];

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
        public static BenhAnPhucHoiChucNang Select(MDB.MDBConnection MyConnection, decimal MaQuanLy)
        {
            #region
            string sql =
                      @"select * 
                        from BenhAnPhucHoiChucNang a
                        where MaQuanLy = :MaQuanLy";
            #endregion
            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
            Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", MaQuanLy));
            MDB.MDBDataReader DataReader = Command.ExecuteReader();
            var value = new BenhAnPhucHoiChucNang();
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
                value.PhauThuat = DataReader["PhauThuat"].ToString() == "1" ? true : false;
                value.ThuThuat = DataReader["ThuThuat"].ToString() == "1" ? true : false;
                value.AnUong = DataReader.GetInt("AnUong");
                value.ChaiToc = DataReader.GetInt("ChaiToc");
                value.DanhRang = DataReader.GetInt("DanhRang");
                value.Tam = DataReader.GetInt("Tam");
                value.MacQuanAo = DataReader.GetInt("MacQuanAo");
                value.DiVeSinh = DataReader.GetInt("DiVeSinh");
                value.NamNguaSap = DataReader.GetInt("NamNguaSap");
                value.NamNguaNgoi = DataReader.GetInt("NamNguaNgoi");
                value.DungNgoi = DataReader.GetInt("DungNgoi");
                value.TuSanDungLen = DataReader.GetInt("TuSanDungLen");
                value.KhaNangDiChuyen = DataReader.GetInt("KhaNangDiChuyen");
                value.DungCuTroGiup = DataReader.GetInt("DungCuTroGiup");
                value.Khac_ChucNangSinhHoat = DataReader["Khac_ChucNangSinhHoat"].ToString();
                value.CanDoiCacBoPhan = DataReader["CanDoiCacBoPhan"].ToString();
                value.CacKhuyetTatDacBiet = DataReader["CacKhuyetTatDacBiet"].ToString();
                value.VanDong = DataReader["VanDong"].ToString();
                value.CamGiac = DataReader["CamGiac"].ToString();
                value.PhanXa = DataReader["PhanXa"].ToString();
                value.CoTron = DataReader["CoTron"].ToString();
                value.ThanKinhSoNao = DataReader["ThanKinhSoNao"].ToString();
                value.RoiLoanChucNang = DataReader["RoiLoanChucNang"].ToString();
                value.NhipTim = DataReader["NhipTim"].ToString();
                value.TiengTim = DataReader["TiengTim"].ToString();
                value.RoiLoanChucNangTimMach = DataReader["RoiLoanChucNangTimMach"].ToString();
                value.LongNguc = DataReader["LongNguc"].ToString();
                value.TheTichKhi = DataReader["TheTichKhi"].ToString();
                value.TinhTrangBenhLy_HoHap = DataReader["TinhTrangBenhLy_HoHap"].ToString();
                value.RoiLoanChucNangHoHap = DataReader["RoiLoanChucNangHoHap"].ToString();
                value.TinhTrangBenhLy_TieuHoa = DataReader["TinhTrangBenhLy_TieuHoa"].ToString();
                value.RoiLoanChucNang_TieuHoa = DataReader["RoiLoanChucNang_TieuHoa"].ToString();
                value.HinhTheCacKhop = DataReader["HinhTheCacKhop"].ToString();
                value.TamHoatDongCacKhopLucVaoVien = DataReader["TamHoatDongCacKhopLucVaoVien"].ToString();
                value.TamHoatDongCacKhopLucRaVien = DataReader["TamHoatDongCacKhopLucRaVien"].ToString();
                value.TinhTrangBenhLy_Co = DataReader["TinhTrangBenhLy_Co"].ToString();
                value.RoiLoanChucNang_Co = DataReader["RoiLoanChucNang_Co"].ToString();
                value.CoDuocThu = DataReader["CoDuocThu"].ToString();
                value.BatCoThu = DataReader.GetInt("BatCoThu");
                value.TinhTrangBenhLy_CotSong = DataReader["TinhTrangBenhLy_CotSong"].ToString();
                value.Schober = DataReader["Schober"].ToString();
                value.Stibor = DataReader["Stibor"].ToString();
                value.RoiLoanChucNang_CotSong = DataReader["RoiLoanChucNang_CotSong"].ToString();
                value.HinhVeTonThuongKhiVaoVien = ERMDatabase.FTPImageString + DataReader["HinhVeTonThuongKhiVaoVien"].ToString();
                value.CacVanDeKhiemkhuyet = DataReader["CacVanDeKhiemkhuyet"].ToString();
                value.DaVaMoDuoiDa = DataReader["DaVaMoDuoiDa"].ToString();
                value.MucDichDieuTri = DataReader["MucDichDieuTri"].ToString();
                value.MaSoKyTen = DataReader["masokyten"].ToString();
                value.MaSoKyTen_KB = DataReader["masokyten_kb"].ToString();
                value.MaSoKyTen_TK = DataReader["masokyten_tk"].ToString();
            }
            return value;
        }

        public static bool InsertOrUpdate(MDB.MDBConnection MyConnection, BenhAnPhucHoiChucNang BenhAnPhucHoiChucNang)
        {
            string sql =
                      @"select MaQuanLy 
                        from BenhAnPhucHoiChucNang
                        where MaQuanLy = :MaQuanLy";
            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
            Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", BenhAnPhucHoiChucNang.MaQuanLy));
            MDB.MDBDataReader DataReader = Command.ExecuteReader();
            int rowCount = 0;
            while (DataReader.Read()) rowCount++;
            if (rowCount == 1) return Update(MyConnection, BenhAnPhucHoiChucNang);
            sql = @"
                  INSERT INTO BenhAnPhucHoiChucNang (MaQuanLy, LyDoVaoVien, VaoNgayThu, QuaTrinhBenhLy, TienSuBenhBanThan, TienSuBenhGiaDinh, ToanThan, TuanHoan, HoHap, TieuHoa, ThanTietNieuSinhDuc, ThanKinh, CoXuongKhop, TaiMuiHong, RangHamMat, Mat, Khac_CacCoQuan, CacXetNghiemCanLamSangCanLam, TomTatBenhAn, BenhChinh, BenhKemTheo, PhanBiet, TienLuong, HuongDieuTri, NgayKhamBenh, BacSyLamBenhAn, QuaTrinhBenhLyVaDienBien, TomTatKetQuaXetNghiem, PhuongPhapDieuTri, TinhTrangNguoiBenhRaVien, HuongDieuTriVaCacCheDoTiepTheo, NguoiNhanHoSo, NguoiGiaoHoSo, NgayTongKet, BacSyDieuTri, DiUng, DiUng_Text, MaTuy, MaTuy_Text, RuouBia, RuouBia_Text, ThuocLa, ThuocLa_Text, ThuocLao, ThuocLao_Text, Khac_DacDiemLienQuanBenh, Khac_DacDiemLienQuanBenh_Text, PhauThuat, ThuThuat, AnUong, ChaiToc, DanhRang, Tam, MacQuanAo, DiVeSinh, NamNguaSap, NamNguaNgoi, DungNgoi, TuSanDungLen, KhaNangDiChuyen, DungCuTroGiup, Khac_ChucNangSinhHoat, CanDoiCacBoPhan, CacKhuyetTatDacBiet, VanDong, CamGiac, PhanXa, CoTron, ThanKinhSoNao, RoiLoanChucNang, NhipTim, TiengTim, RoiLoanChucNangTimMach, LongNguc, TheTichKhi, TinhTrangBenhLy_HoHap, RoiLoanChucNangHoHap, TinhTrangBenhLy_TieuHoa, RoiLoanChucNang_TieuHoa, HinhTheCacKhop, TamHoatDongCacKhopLucVaoVien, TamHoatDongCacKhopLucRaVien, TinhTrangBenhLy_Co, RoiLoanChucNang_Co, CoDuocThu, BatCoThu, TinhTrangBenhLy_CotSong, Schober, Stibor, RoiLoanChucNang_CotSong, HinhVeTonThuongKhiVaoVien, CacVanDeKhiemkhuyet, DaVaMoDuoiDa, MucDichDieuTri) 
                    VALUES( :MaQuanLy, :LyDoVaoVien, :VaoNgayThu, :QuaTrinhBenhLy, :TienSuBenhBanThan, :TienSuBenhGiaDinh, :ToanThan, :TuanHoan, :HoHap, :TieuHoa, :ThanTietNieuSinhDuc, :ThanKinh, :CoXuongKhop, :TaiMuiHong, :RangHamMat, :Mat, :Khac_CacCoQuan, :CacXetNghiemCanLamSangCanLam, :TomTatBenhAn, :BenhChinh, :BenhKemTheo, :PhanBiet, :TienLuong, :HuongDieuTri, :NgayKhamBenh, :BacSyLamBenhAn, :QuaTrinhBenhLyVaDienBien, :TomTatKetQuaXetNghiem, :PhuongPhapDieuTri, :TinhTrangNguoiBenhRaVien, :HuongDieuTriVaCacCheDoTiepTheo, :NguoiNhanHoSo, :NguoiGiaoHoSo, :NgayTongKet, :BacSyDieuTri, :DiUng, :DiUng_Text, :MaTuy, :MaTuy_Text, :RuouBia, :RuouBia_Text, :ThuocLa, :ThuocLa_Text, :ThuocLao, :ThuocLao_Text, :Khac_DacDiemLienQuanBenh, :Khac_DacDiemLienQuanBenh_Text, :PhauThuat, :ThuThuat, :AnUong, :ChaiToc, :DanhRang, :Tam, :MacQuanAo, :DiVeSinh, :NamNguaSap, :NamNguaNgoi, :DungNgoi, :TuSanDungLen, :KhaNangDiChuyen, :DungCuTroGiup, :Khac_ChucNangSinhHoat, :CanDoiCacBoPhan, :CacKhuyetTatDacBiet, :VanDong, :CamGiac, :PhanXa, :CoTron, :ThanKinhSoNao, :RoiLoanChucNang, :NhipTim, :TiengTim, :RoiLoanChucNangTimMach, :LongNguc, :TheTichKhi, :TinhTrangBenhLy_HoHap, :RoiLoanChucNangHoHap, :TinhTrangBenhLy_TieuHoa, :RoiLoanChucNang_TieuHoa, :HinhTheCacKhop, :TamHoatDongCacKhopLucVaoVien, :TamHoatDongCacKhopLucRaVien, :TinhTrangBenhLy_Co, :RoiLoanChucNang_Co, :CoDuocThu, :BatCoThu, :TinhTrangBenhLy_CotSong, :Schober, :Stibor, :RoiLoanChucNang_CotSong, :HinhVeTonThuongKhiVaoVien, :CacVanDeKhiemkhuyet, :DaVaMoDuoiDa, :MucDichDieuTri)";
            Command = new MDB.MDBCommand(sql, MyConnection);
            Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", BenhAnPhucHoiChucNang.MaQuanLy));
            Command.Parameters.Add(new MDB.MDBParameter("LyDoVaoVien", BenhAnPhucHoiChucNang.LyDoVaoVien));
            Command.Parameters.Add(new MDB.MDBParameter("VaoNgayThu", BenhAnPhucHoiChucNang.VaoNgayThu));
            Command.Parameters.Add(new MDB.MDBParameter("QuaTrinhBenhLy", BenhAnPhucHoiChucNang.QuaTrinhBenhLy));
            Command.Parameters.Add(new MDB.MDBParameter("TienSuBenhBanThan", BenhAnPhucHoiChucNang.TienSuBenhBanThan));
            Command.Parameters.Add(new MDB.MDBParameter("TienSuBenhGiaDinh", BenhAnPhucHoiChucNang.TienSuBenhGiaDinh));
            Command.Parameters.Add(new MDB.MDBParameter("ToanThan", BenhAnPhucHoiChucNang.ToanThan));
            Command.Parameters.Add(new MDB.MDBParameter("TuanHoan", BenhAnPhucHoiChucNang.TuanHoan));
            Command.Parameters.Add(new MDB.MDBParameter("HoHap", BenhAnPhucHoiChucNang.HoHap));
            Command.Parameters.Add(new MDB.MDBParameter("TieuHoa", BenhAnPhucHoiChucNang.TieuHoa));
            Command.Parameters.Add(new MDB.MDBParameter("ThanTietNieuSinhDuc", BenhAnPhucHoiChucNang.ThanTietNieuSinhDuc));
            Command.Parameters.Add(new MDB.MDBParameter("ThanKinh", BenhAnPhucHoiChucNang.ThanKinh));
            Command.Parameters.Add(new MDB.MDBParameter("CoXuongKhop", BenhAnPhucHoiChucNang.CoXuongKhop));
            Command.Parameters.Add(new MDB.MDBParameter("TaiMuiHong", BenhAnPhucHoiChucNang.TaiMuiHong));
            Command.Parameters.Add(new MDB.MDBParameter("RangHamMat", BenhAnPhucHoiChucNang.RangHamMat));
            Command.Parameters.Add(new MDB.MDBParameter("Mat", BenhAnPhucHoiChucNang.Mat));
            Command.Parameters.Add(new MDB.MDBParameter("Khac_CacCoQuan", BenhAnPhucHoiChucNang.Khac_CacCoQuan));
            Command.Parameters.Add(new MDB.MDBParameter("CacXetNghiemCanLamSangCanLam", BenhAnPhucHoiChucNang.CacXetNghiemCanLamSangCanLam));
            Command.Parameters.Add(new MDB.MDBParameter("TomTatBenhAn", BenhAnPhucHoiChucNang.TomTatBenhAn));
            Command.Parameters.Add(new MDB.MDBParameter("BenhChinh", BenhAnPhucHoiChucNang.BenhChinh));
            Command.Parameters.Add(new MDB.MDBParameter("BenhKemTheo", BenhAnPhucHoiChucNang.BenhKemTheo));
            Command.Parameters.Add(new MDB.MDBParameter("PhanBiet", BenhAnPhucHoiChucNang.PhanBiet));
            Command.Parameters.Add(new MDB.MDBParameter("TienLuong", BenhAnPhucHoiChucNang.TienLuong));
            Command.Parameters.Add(new MDB.MDBParameter("HuongDieuTri", BenhAnPhucHoiChucNang.HuongDieuTri));
            Command.Parameters.Add(new MDB.MDBParameter("NgayKhamBenh", BenhAnPhucHoiChucNang.NgayKhamBenh));
            Command.Parameters.Add(new MDB.MDBParameter("BacSyLamBenhAn", BenhAnPhucHoiChucNang.BacSyLamBenhAn));
            Command.Parameters.Add(new MDB.MDBParameter("QuaTrinhBenhLyVaDienBien", BenhAnPhucHoiChucNang.QuaTrinhBenhLyVaDienBien));
            Command.Parameters.Add(new MDB.MDBParameter("TomTatKetQuaXetNghiem", BenhAnPhucHoiChucNang.TomTatKetQuaXetNghiem));
            Command.Parameters.Add(new MDB.MDBParameter("PhuongPhapDieuTri", BenhAnPhucHoiChucNang.PhuongPhapDieuTri));
            Command.Parameters.Add(new MDB.MDBParameter("TinhTrangNguoiBenhRaVien", BenhAnPhucHoiChucNang.TinhTrangNguoiBenhRaVien));
            Command.Parameters.Add(new MDB.MDBParameter("HuongDieuTriVaCacCheDoTiepTheo", BenhAnPhucHoiChucNang.HuongDieuTriVaCacCheDoTiepTheo));
            Command.Parameters.Add(new MDB.MDBParameter("NguoiNhanHoSo", BenhAnPhucHoiChucNang.NguoiNhanHoSo));
            Command.Parameters.Add(new MDB.MDBParameter("NguoiGiaoHoSo", BenhAnPhucHoiChucNang.NguoiGiaoHoSo));
            Command.Parameters.Add(new MDB.MDBParameter("NgayTongKet", BenhAnPhucHoiChucNang.NgayTongKet));
            Command.Parameters.Add(new MDB.MDBParameter("BacSyDieuTri", BenhAnPhucHoiChucNang.BacSyDieuTri));
            Command.Parameters.Add(new MDB.MDBParameter("DiUng", BenhAnPhucHoiChucNang.DacDiemLienQuanBenh.DiUng == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("DiUng_Text", BenhAnPhucHoiChucNang.DacDiemLienQuanBenh.DiUng_Text));
            Command.Parameters.Add(new MDB.MDBParameter("MaTuy", BenhAnPhucHoiChucNang.DacDiemLienQuanBenh.MaTuy == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("MaTuy_Text", BenhAnPhucHoiChucNang.DacDiemLienQuanBenh.MaTuy_Text));
            Command.Parameters.Add(new MDB.MDBParameter("RuouBia", BenhAnPhucHoiChucNang.DacDiemLienQuanBenh.RuouBia == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("RuouBia_Text", BenhAnPhucHoiChucNang.DacDiemLienQuanBenh.RuouBia_Text));
            Command.Parameters.Add(new MDB.MDBParameter("ThuocLa", BenhAnPhucHoiChucNang.DacDiemLienQuanBenh.ThuocLa == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("ThuocLa_Text", BenhAnPhucHoiChucNang.DacDiemLienQuanBenh.ThuocLa_Text));
            Command.Parameters.Add(new MDB.MDBParameter("ThuocLao", BenhAnPhucHoiChucNang.DacDiemLienQuanBenh.ThuocLao == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("ThuocLao_Text", BenhAnPhucHoiChucNang.DacDiemLienQuanBenh.ThuocLao_Text));
            Command.Parameters.Add(new MDB.MDBParameter("Khac_DacDiemLienQuanBenh", BenhAnPhucHoiChucNang.DacDiemLienQuanBenh.Khac_DacDiemLienQuanBenh == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("Khac_DacDiemLienQuanBenh_Text", BenhAnPhucHoiChucNang.DacDiemLienQuanBenh.Khac_DacDiemLienQuanBenh_Text));
            Command.Parameters.Add(new MDB.MDBParameter("PhauThuat", BenhAnPhucHoiChucNang.PhauThuat == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("ThuThuat", BenhAnPhucHoiChucNang.ThuThuat == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("AnUong", BenhAnPhucHoiChucNang.AnUong));
            Command.Parameters.Add(new MDB.MDBParameter("ChaiToc", BenhAnPhucHoiChucNang.ChaiToc));
            Command.Parameters.Add(new MDB.MDBParameter("DanhRang", BenhAnPhucHoiChucNang.DanhRang));
            Command.Parameters.Add(new MDB.MDBParameter("Tam", BenhAnPhucHoiChucNang.Tam));
            Command.Parameters.Add(new MDB.MDBParameter("MacQuanAo", BenhAnPhucHoiChucNang.MacQuanAo));
            Command.Parameters.Add(new MDB.MDBParameter("DiVeSinh", BenhAnPhucHoiChucNang.DiVeSinh));
            Command.Parameters.Add(new MDB.MDBParameter("NamNguaSap", BenhAnPhucHoiChucNang.NamNguaSap));
            Command.Parameters.Add(new MDB.MDBParameter("NamNguaNgoi", BenhAnPhucHoiChucNang.NamNguaNgoi));
            Command.Parameters.Add(new MDB.MDBParameter("DungNgoi", BenhAnPhucHoiChucNang.DungNgoi));
            Command.Parameters.Add(new MDB.MDBParameter("TuSanDungLen", BenhAnPhucHoiChucNang.TuSanDungLen));
            Command.Parameters.Add(new MDB.MDBParameter("KhaNangDiChuyen", BenhAnPhucHoiChucNang.KhaNangDiChuyen));
            Command.Parameters.Add(new MDB.MDBParameter("DungCuTroGiup", BenhAnPhucHoiChucNang.DungCuTroGiup));
            Command.Parameters.Add(new MDB.MDBParameter("Khac_ChucNangSinhHoat", BenhAnPhucHoiChucNang.Khac_ChucNangSinhHoat));
            Command.Parameters.Add(new MDB.MDBParameter("CanDoiCacBoPhan", BenhAnPhucHoiChucNang.CanDoiCacBoPhan));
            Command.Parameters.Add(new MDB.MDBParameter("CacKhuyetTatDacBiet", BenhAnPhucHoiChucNang.CacKhuyetTatDacBiet));
            Command.Parameters.Add(new MDB.MDBParameter("VanDong", BenhAnPhucHoiChucNang.VanDong));
            Command.Parameters.Add(new MDB.MDBParameter("CamGiac", BenhAnPhucHoiChucNang.CamGiac));
            Command.Parameters.Add(new MDB.MDBParameter("PhanXa", BenhAnPhucHoiChucNang.PhanXa));
            Command.Parameters.Add(new MDB.MDBParameter("CoTron", BenhAnPhucHoiChucNang.CoTron));
            Command.Parameters.Add(new MDB.MDBParameter("ThanKinhSoNao", BenhAnPhucHoiChucNang.ThanKinhSoNao));
            Command.Parameters.Add(new MDB.MDBParameter("RoiLoanChucNang", BenhAnPhucHoiChucNang.RoiLoanChucNang));
            Command.Parameters.Add(new MDB.MDBParameter("NhipTim", BenhAnPhucHoiChucNang.NhipTim));
            Command.Parameters.Add(new MDB.MDBParameter("TiengTim", BenhAnPhucHoiChucNang.TiengTim));
            Command.Parameters.Add(new MDB.MDBParameter("RoiLoanChucNangTimMach", BenhAnPhucHoiChucNang.RoiLoanChucNangTimMach));
            Command.Parameters.Add(new MDB.MDBParameter("LongNguc", BenhAnPhucHoiChucNang.LongNguc));
            Command.Parameters.Add(new MDB.MDBParameter("TheTichKhi", BenhAnPhucHoiChucNang.TheTichKhi));
            Command.Parameters.Add(new MDB.MDBParameter("TinhTrangBenhLy_HoHap", BenhAnPhucHoiChucNang.TinhTrangBenhLy_HoHap));
            Command.Parameters.Add(new MDB.MDBParameter("RoiLoanChucNangHoHap", BenhAnPhucHoiChucNang.RoiLoanChucNangHoHap));
            Command.Parameters.Add(new MDB.MDBParameter("TinhTrangBenhLy_TieuHoa", BenhAnPhucHoiChucNang.TinhTrangBenhLy_TieuHoa));
            Command.Parameters.Add(new MDB.MDBParameter("RoiLoanChucNang_TieuHoa", BenhAnPhucHoiChucNang.RoiLoanChucNang_TieuHoa));
            Command.Parameters.Add(new MDB.MDBParameter("HinhTheCacKhop", BenhAnPhucHoiChucNang.HinhTheCacKhop));
            Command.Parameters.Add(new MDB.MDBParameter("TamHoatDongCacKhopLucVaoVien", BenhAnPhucHoiChucNang.TamHoatDongCacKhopLucVaoVien));
            Command.Parameters.Add(new MDB.MDBParameter("TamHoatDongCacKhopLucRaVien", BenhAnPhucHoiChucNang.TamHoatDongCacKhopLucRaVien));
            Command.Parameters.Add(new MDB.MDBParameter("TinhTrangBenhLy_Co", BenhAnPhucHoiChucNang.TinhTrangBenhLy_Co));
            Command.Parameters.Add(new MDB.MDBParameter("RoiLoanChucNang_Co", BenhAnPhucHoiChucNang.RoiLoanChucNang_Co));
            Command.Parameters.Add(new MDB.MDBParameter("CoDuocThu", BenhAnPhucHoiChucNang.CoDuocThu));
            Command.Parameters.Add(new MDB.MDBParameter("BatCoThu", BenhAnPhucHoiChucNang.BatCoThu));
            Command.Parameters.Add(new MDB.MDBParameter("TinhTrangBenhLy_CotSong", BenhAnPhucHoiChucNang.TinhTrangBenhLy_CotSong));
            Command.Parameters.Add(new MDB.MDBParameter("Schober", BenhAnPhucHoiChucNang.Schober));
            Command.Parameters.Add(new MDB.MDBParameter("Stibor", BenhAnPhucHoiChucNang.Stibor));
            Command.Parameters.Add(new MDB.MDBParameter("RoiLoanChucNang_CotSong", BenhAnPhucHoiChucNang.RoiLoanChucNang_CotSong));
            Command.Parameters.Add(new MDB.MDBParameter("HinhVeTonThuongKhiVaoVien", BenhAnPhucHoiChucNang.HinhVeTonThuongKhiVaoVien.Replace(ERMDatabase.FTPImageString, "")));
            Command.Parameters.Add(new MDB.MDBParameter("CacVanDeKhiemkhuyet", BenhAnPhucHoiChucNang.CacVanDeKhiemkhuyet));
            Command.Parameters.Add(new MDB.MDBParameter("DaVaMoDuoiDa", BenhAnPhucHoiChucNang.DaVaMoDuoiDa));
            Command.Parameters.Add(new MDB.MDBParameter("MucDichDieuTri", BenhAnPhucHoiChucNang.MucDichDieuTri));

            int n = Command.ExecuteNonQuery(); // C#
            return n > 0 ? true : false;
        }
        public static bool Update(MDB.MDBConnection MyConnection, BenhAnPhucHoiChucNang BenhAnPhucHoiChucNang)
        {
            string sql = @"UPDATE BenhAnPhucHoiChucNang SET 
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
                        PhauThuat = :PhauThuat,
                        ThuThuat = :ThuThuat,
                        AnUong = :AnUong,
                        ChaiToc = :ChaiToc,
                        DanhRang = :DanhRang,
                        Tam = :Tam,
                        MacQuanAo = :MacQuanAo,
                        DiVeSinh = :DiVeSinh,
                        NamNguaSap = :NamNguaSap,
                        NamNguaNgoi = :NamNguaNgoi,
                        DungNgoi = :DungNgoi,
                        TuSanDungLen = :TuSanDungLen,
                        KhaNangDiChuyen = :KhaNangDiChuyen,
                        DungCuTroGiup = :DungCuTroGiup,
                        Khac_ChucNangSinhHoat = :Khac_ChucNangSinhHoat,
                        CanDoiCacBoPhan = :CanDoiCacBoPhan,
                        CacKhuyetTatDacBiet = :CacKhuyetTatDacBiet,
                        VanDong = :VanDong,
                        CamGiac = :CamGiac,
                        PhanXa = :PhanXa,
                        CoTron = :CoTron,
                        ThanKinhSoNao = :ThanKinhSoNao,
                        RoiLoanChucNang = :RoiLoanChucNang,
                        NhipTim = :NhipTim,
                        TiengTim = :TiengTim,
                        RoiLoanChucNangTimMach = :RoiLoanChucNangTimMach,
                        LongNguc = :LongNguc,
                        TheTichKhi = :TheTichKhi,
                        TinhTrangBenhLy_HoHap = :TinhTrangBenhLy_HoHap,
                        RoiLoanChucNangHoHap = :RoiLoanChucNangHoHap,
                        TinhTrangBenhLy_TieuHoa = :TinhTrangBenhLy_TieuHoa,
                        RoiLoanChucNang_TieuHoa = :RoiLoanChucNang_TieuHoa,
                        HinhTheCacKhop = :HinhTheCacKhop,
                        TamHoatDongCacKhopLucVaoVien = :TamHoatDongCacKhopLucVaoVien,
                        TamHoatDongCacKhopLucRaVien = :TamHoatDongCacKhopLucRaVien,
                        TinhTrangBenhLy_Co = :TinhTrangBenhLy_Co,
                        RoiLoanChucNang_Co = :RoiLoanChucNang_Co,
                        CoDuocThu = :CoDuocThu,
                        BatCoThu = :BatCoThu,
                        TinhTrangBenhLy_CotSong = :TinhTrangBenhLy_CotSong,
                        Schober = :Schober,
                        Stibor = :Stibor,
                        RoiLoanChucNang_CotSong = :RoiLoanChucNang_CotSong,
                        HinhVeTonThuongKhiVaoVien = :HinhVeTonThuongKhiVaoVien,
                        CacVanDeKhiemkhuyet = :CacVanDeKhiemkhuyet,
                        DaVaMoDuoiDa = :DaVaMoDuoiDa,
                        MucDichDieuTri = :MucDichDieuTri
                        WHERE MaQuanLy = :MaQuanLy";
            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
            Command.Parameters.Add(new MDB.MDBParameter("LyDoVaoVien", BenhAnPhucHoiChucNang.LyDoVaoVien));
            Command.Parameters.Add(new MDB.MDBParameter("VaoNgayThu", BenhAnPhucHoiChucNang.VaoNgayThu));
            Command.Parameters.Add(new MDB.MDBParameter("QuaTrinhBenhLy", BenhAnPhucHoiChucNang.QuaTrinhBenhLy));
            Command.Parameters.Add(new MDB.MDBParameter("TienSuBenhBanThan", BenhAnPhucHoiChucNang.TienSuBenhBanThan));
            Command.Parameters.Add(new MDB.MDBParameter("TienSuBenhGiaDinh", BenhAnPhucHoiChucNang.TienSuBenhGiaDinh));
            Command.Parameters.Add(new MDB.MDBParameter("ToanThan", BenhAnPhucHoiChucNang.ToanThan));
            Command.Parameters.Add(new MDB.MDBParameter("TuanHoan", BenhAnPhucHoiChucNang.TuanHoan));
            Command.Parameters.Add(new MDB.MDBParameter("HoHap", BenhAnPhucHoiChucNang.HoHap));
            Command.Parameters.Add(new MDB.MDBParameter("TieuHoa", BenhAnPhucHoiChucNang.TieuHoa));
            Command.Parameters.Add(new MDB.MDBParameter("ThanTietNieuSinhDuc", BenhAnPhucHoiChucNang.ThanTietNieuSinhDuc));
            Command.Parameters.Add(new MDB.MDBParameter("ThanKinh", BenhAnPhucHoiChucNang.ThanKinh));
            Command.Parameters.Add(new MDB.MDBParameter("CoXuongKhop", BenhAnPhucHoiChucNang.CoXuongKhop));
            Command.Parameters.Add(new MDB.MDBParameter("TaiMuiHong", BenhAnPhucHoiChucNang.TaiMuiHong));
            Command.Parameters.Add(new MDB.MDBParameter("RangHamMat", BenhAnPhucHoiChucNang.RangHamMat));
            Command.Parameters.Add(new MDB.MDBParameter("Mat", BenhAnPhucHoiChucNang.Mat));
            Command.Parameters.Add(new MDB.MDBParameter("Khac_CacCoQuan", BenhAnPhucHoiChucNang.Khac_CacCoQuan));
            Command.Parameters.Add(new MDB.MDBParameter("CacXetNghiemCanLamSangCanLam", BenhAnPhucHoiChucNang.CacXetNghiemCanLamSangCanLam));
            Command.Parameters.Add(new MDB.MDBParameter("TomTatBenhAn", BenhAnPhucHoiChucNang.TomTatBenhAn));
            Command.Parameters.Add(new MDB.MDBParameter("BenhChinh", BenhAnPhucHoiChucNang.BenhChinh));
            Command.Parameters.Add(new MDB.MDBParameter("BenhKemTheo", BenhAnPhucHoiChucNang.BenhKemTheo));
            Command.Parameters.Add(new MDB.MDBParameter("PhanBiet", BenhAnPhucHoiChucNang.PhanBiet));
            Command.Parameters.Add(new MDB.MDBParameter("TienLuong", BenhAnPhucHoiChucNang.TienLuong));
            Command.Parameters.Add(new MDB.MDBParameter("HuongDieuTri", BenhAnPhucHoiChucNang.HuongDieuTri));
            Command.Parameters.Add(new MDB.MDBParameter("NgayKhamBenh", BenhAnPhucHoiChucNang.NgayKhamBenh));
            Command.Parameters.Add(new MDB.MDBParameter("BacSyLamBenhAn", BenhAnPhucHoiChucNang.BacSyLamBenhAn));
            Command.Parameters.Add(new MDB.MDBParameter("QuaTrinhBenhLyVaDienBien", BenhAnPhucHoiChucNang.QuaTrinhBenhLyVaDienBien));
            Command.Parameters.Add(new MDB.MDBParameter("TomTatKetQuaXetNghiem", BenhAnPhucHoiChucNang.TomTatKetQuaXetNghiem));
            Command.Parameters.Add(new MDB.MDBParameter("PhuongPhapDieuTri", BenhAnPhucHoiChucNang.PhuongPhapDieuTri));
            Command.Parameters.Add(new MDB.MDBParameter("TinhTrangNguoiBenhRaVien", BenhAnPhucHoiChucNang.TinhTrangNguoiBenhRaVien));
            Command.Parameters.Add(new MDB.MDBParameter("HuongDieuTriVaCacCheDoTiepTheo", BenhAnPhucHoiChucNang.HuongDieuTriVaCacCheDoTiepTheo));
            Command.Parameters.Add(new MDB.MDBParameter("NguoiNhanHoSo", BenhAnPhucHoiChucNang.NguoiNhanHoSo));
            Command.Parameters.Add(new MDB.MDBParameter("NguoiGiaoHoSo", BenhAnPhucHoiChucNang.NguoiGiaoHoSo));
            Command.Parameters.Add(new MDB.MDBParameter("NgayTongKet", BenhAnPhucHoiChucNang.NgayTongKet));
            Command.Parameters.Add(new MDB.MDBParameter("BacSyDieuTri", BenhAnPhucHoiChucNang.BacSyDieuTri));
            Command.Parameters.Add(new MDB.MDBParameter("DiUng", BenhAnPhucHoiChucNang.DacDiemLienQuanBenh.DiUng == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("DiUng_Text", BenhAnPhucHoiChucNang.DacDiemLienQuanBenh.DiUng_Text));
            Command.Parameters.Add(new MDB.MDBParameter("MaTuy", BenhAnPhucHoiChucNang.DacDiemLienQuanBenh.MaTuy == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("MaTuy_Text", BenhAnPhucHoiChucNang.DacDiemLienQuanBenh.MaTuy_Text));
            Command.Parameters.Add(new MDB.MDBParameter("RuouBia", BenhAnPhucHoiChucNang.DacDiemLienQuanBenh.RuouBia == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("RuouBia_Text", BenhAnPhucHoiChucNang.DacDiemLienQuanBenh.RuouBia_Text));
            Command.Parameters.Add(new MDB.MDBParameter("ThuocLa", BenhAnPhucHoiChucNang.DacDiemLienQuanBenh.ThuocLa == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("ThuocLa_Text", BenhAnPhucHoiChucNang.DacDiemLienQuanBenh.ThuocLa_Text));
            Command.Parameters.Add(new MDB.MDBParameter("ThuocLao", BenhAnPhucHoiChucNang.DacDiemLienQuanBenh.ThuocLao == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("ThuocLao_Text", BenhAnPhucHoiChucNang.DacDiemLienQuanBenh.ThuocLao_Text));
            Command.Parameters.Add(new MDB.MDBParameter("Khac_DacDiemLienQuanBenh", BenhAnPhucHoiChucNang.DacDiemLienQuanBenh.Khac_DacDiemLienQuanBenh == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("Khac_DacDiemLienQuanBenh_Text", BenhAnPhucHoiChucNang.DacDiemLienQuanBenh.Khac_DacDiemLienQuanBenh_Text));
            Command.Parameters.Add(new MDB.MDBParameter("PhauThuat", BenhAnPhucHoiChucNang.PhauThuat == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("ThuThuat", BenhAnPhucHoiChucNang.ThuThuat == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("AnUong", BenhAnPhucHoiChucNang.AnUong));
            Command.Parameters.Add(new MDB.MDBParameter("ChaiToc", BenhAnPhucHoiChucNang.ChaiToc));
            Command.Parameters.Add(new MDB.MDBParameter("DanhRang", BenhAnPhucHoiChucNang.DanhRang));
            Command.Parameters.Add(new MDB.MDBParameter("Tam", BenhAnPhucHoiChucNang.Tam));
            Command.Parameters.Add(new MDB.MDBParameter("MacQuanAo", BenhAnPhucHoiChucNang.MacQuanAo));
            Command.Parameters.Add(new MDB.MDBParameter("DiVeSinh", BenhAnPhucHoiChucNang.DiVeSinh));
            Command.Parameters.Add(new MDB.MDBParameter("NamNguaSap", BenhAnPhucHoiChucNang.NamNguaSap));
            Command.Parameters.Add(new MDB.MDBParameter("NamNguaNgoi", BenhAnPhucHoiChucNang.NamNguaNgoi));
            Command.Parameters.Add(new MDB.MDBParameter("DungNgoi", BenhAnPhucHoiChucNang.DungNgoi));
            Command.Parameters.Add(new MDB.MDBParameter("TuSanDungLen", BenhAnPhucHoiChucNang.TuSanDungLen));
            Command.Parameters.Add(new MDB.MDBParameter("KhaNangDiChuyen", BenhAnPhucHoiChucNang.KhaNangDiChuyen));
            Command.Parameters.Add(new MDB.MDBParameter("DungCuTroGiup", BenhAnPhucHoiChucNang.DungCuTroGiup));
            Command.Parameters.Add(new MDB.MDBParameter("Khac_ChucNangSinhHoat", BenhAnPhucHoiChucNang.Khac_ChucNangSinhHoat));
            Command.Parameters.Add(new MDB.MDBParameter("CanDoiCacBoPhan", BenhAnPhucHoiChucNang.CanDoiCacBoPhan));
            Command.Parameters.Add(new MDB.MDBParameter("CacKhuyetTatDacBiet", BenhAnPhucHoiChucNang.CacKhuyetTatDacBiet));
            Command.Parameters.Add(new MDB.MDBParameter("VanDong", BenhAnPhucHoiChucNang.VanDong));
            Command.Parameters.Add(new MDB.MDBParameter("CamGiac", BenhAnPhucHoiChucNang.CamGiac));
            Command.Parameters.Add(new MDB.MDBParameter("PhanXa", BenhAnPhucHoiChucNang.PhanXa));
            Command.Parameters.Add(new MDB.MDBParameter("CoTron", BenhAnPhucHoiChucNang.CoTron));
            Command.Parameters.Add(new MDB.MDBParameter("ThanKinhSoNao", BenhAnPhucHoiChucNang.ThanKinhSoNao));
            Command.Parameters.Add(new MDB.MDBParameter("RoiLoanChucNang", BenhAnPhucHoiChucNang.RoiLoanChucNang));
            Command.Parameters.Add(new MDB.MDBParameter("NhipTim", BenhAnPhucHoiChucNang.NhipTim));
            Command.Parameters.Add(new MDB.MDBParameter("TiengTim", BenhAnPhucHoiChucNang.TiengTim));
            Command.Parameters.Add(new MDB.MDBParameter("RoiLoanChucNangTimMach", BenhAnPhucHoiChucNang.RoiLoanChucNangTimMach));
            Command.Parameters.Add(new MDB.MDBParameter("LongNguc", BenhAnPhucHoiChucNang.LongNguc));
            Command.Parameters.Add(new MDB.MDBParameter("TheTichKhi", BenhAnPhucHoiChucNang.TheTichKhi));
            Command.Parameters.Add(new MDB.MDBParameter("TinhTrangBenhLy_HoHap", BenhAnPhucHoiChucNang.TinhTrangBenhLy_HoHap));
            Command.Parameters.Add(new MDB.MDBParameter("RoiLoanChucNangHoHap", BenhAnPhucHoiChucNang.RoiLoanChucNangHoHap));
            Command.Parameters.Add(new MDB.MDBParameter("TinhTrangBenhLy_TieuHoa", BenhAnPhucHoiChucNang.TinhTrangBenhLy_TieuHoa));
            Command.Parameters.Add(new MDB.MDBParameter("RoiLoanChucNang_TieuHoa", BenhAnPhucHoiChucNang.RoiLoanChucNang_TieuHoa));
            Command.Parameters.Add(new MDB.MDBParameter("HinhTheCacKhop", BenhAnPhucHoiChucNang.HinhTheCacKhop));
            Command.Parameters.Add(new MDB.MDBParameter("TamHoatDongCacKhopLucVaoVien", BenhAnPhucHoiChucNang.TamHoatDongCacKhopLucVaoVien));
            Command.Parameters.Add(new MDB.MDBParameter("TamHoatDongCacKhopLucRaVien", BenhAnPhucHoiChucNang.TamHoatDongCacKhopLucRaVien));
            Command.Parameters.Add(new MDB.MDBParameter("TinhTrangBenhLy_Co", BenhAnPhucHoiChucNang.TinhTrangBenhLy_Co));
            Command.Parameters.Add(new MDB.MDBParameter("RoiLoanChucNang_Co", BenhAnPhucHoiChucNang.RoiLoanChucNang_Co));
            Command.Parameters.Add(new MDB.MDBParameter("CoDuocThu", BenhAnPhucHoiChucNang.CoDuocThu));
            Command.Parameters.Add(new MDB.MDBParameter("BatCoThu", BenhAnPhucHoiChucNang.BatCoThu));
            Command.Parameters.Add(new MDB.MDBParameter("TinhTrangBenhLy_CotSong", BenhAnPhucHoiChucNang.TinhTrangBenhLy_CotSong));
            Command.Parameters.Add(new MDB.MDBParameter("Schober", BenhAnPhucHoiChucNang.Schober));
            Command.Parameters.Add(new MDB.MDBParameter("Stibor", BenhAnPhucHoiChucNang.Stibor));
            Command.Parameters.Add(new MDB.MDBParameter("RoiLoanChucNang_CotSong", BenhAnPhucHoiChucNang.RoiLoanChucNang_CotSong));
            Command.Parameters.Add(new MDB.MDBParameter("HinhVeTonThuongKhiVaoVien", BenhAnPhucHoiChucNang.HinhVeTonThuongKhiVaoVien.Replace(ERMDatabase.FTPImageString == null? "ImageString":ERMDatabase.FTPImageString, "")));
            Command.Parameters.Add(new MDB.MDBParameter("CacVanDeKhiemkhuyet", BenhAnPhucHoiChucNang.CacVanDeKhiemkhuyet));
            Command.Parameters.Add(new MDB.MDBParameter("DaVaMoDuoiDa", BenhAnPhucHoiChucNang.DaVaMoDuoiDa));
            Command.Parameters.Add(new MDB.MDBParameter("MucDichDieuTri", BenhAnPhucHoiChucNang.MucDichDieuTri));


            Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", BenhAnPhucHoiChucNang.MaQuanLy));
            int n = Command.ExecuteNonQuery(); // C#
            return n > 0 ? true : false;
        }
        public static bool Delete(MDB.MDBConnection MyConnection, BenhAnPhucHoiChucNang BenhAnPhucHoiChucNang)
        {
            string sql = @"DELETE FROM BenhAnPhucHoiChucNang 
                           WHERE MaQuanLy = :MaQuanLy";
            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
            Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", BenhAnPhucHoiChucNang.MaQuanLy));

            int n = Command.ExecuteNonQuery(); // C#
            return n > 0 ? true : false;
        }
    }
}
