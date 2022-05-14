using System.Data;

namespace EMR_MAIN
{
    public class BenhAnNgoaiTruTaiMuiHongFunc
    {
        public static void WriteXml(MDB.MDBConnection MyConnection)
        {
            string sql =
                   @"
                  select  a.*,  CTScanner HoSo_CTScanner, SieuAm HoSo_SieuAm, XetNghiem HoSo_XetNghiem,  Khac HoSo_Khac,  Khac_Text HoSo_Khac_Text,  ToanBoHoSo HoSo_ToanBoHoSo, Mach DauSinhTon_Mach,  NhietDo DauSinhTon_NhietDo,  HuyetAp DauSinhTon_HuyetAp,  NhipTho DauSinhTon_NhipTho,  CanNang DauSinhTon_CanNang  
                  from BenhAnNgoaiTruTaiMuiHong a inner join thongtindieutri b on a.maquanly = b.maquanly
                  where rownum = 1
                    ";
            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
            MDB.MDBDataReader DataReader = Command.ExecuteReader();

            var DataTable = new DataTable { TableName = "BenhAnNgoaiTruTaiMuiHong" };
            DataTable.Load(DataReader as IDataReader);
            DataTable.WriteXml("rptBenhAnNgoaiTruTaiMuiHong.xml");
        }
        public static DataSet SelectDataSet(MDB.MDBConnection MyConnection, decimal MaQuanLy)
        {
            string sql =
                    @"
                 select  a.*,g.hovaten GiamDocBenhVienHoVaTen, f.hovaten BacSyLamBenhAnHoVaTen ,c.hovaten BacSyDieuTriHoVaTen,d.hovaten NguoiGiaoHoSoHoVaTen,e.hovaten NguoiNhanHoSoHoVaTen, b.XQuang HoSo_XQuang,   b.CTScanner HoSo_CTScanner, b.SieuAm HoSo_SieuAm, b.XetNghiem HoSo_XetNghiem,  b.Khac HoSo_Khac,  b.Khac_Text HoSo_Khac_Text,  b.ToanBoHoSo HoSo_ToanBoHoSo, b.Mach DauSinhTon_Mach, b.NhietDo DauSinhTon_NhietDo,  b.HuyetAp DauSinhTon_HuyetAp,  b.NhipTho DauSinhTon_NhipTho,  b.CanNang DauSinhTon_CanNang  , b.ChieuCao DauSinhTon_ChieuCao, b.BMI DauSinhTon_BMI, b.NgayRaVien 
                  from BenhAnNgoaiTruTaiMuiHong a 
                  left join thongtindieutri b on a.maquanly = b.maquanly 
                  left join nhanvien c on a.bacsydieutri = c.manhanvien
                  left join nhanvien d on a.nguoigiaohoso = d.manhanvien
                  left join nhanvien e on a.nguoinhanhoso = e.manhanvien
                  left join nhanvien f on a.BacSyLamBenhAn = f.manhanvien
                  left join nhanvien g on b.MaGiamDocBenhVien = g.manhanvien
                  where a.maquanly = " + MaQuanLy.ToString(System.Globalization.CultureInfo.InvariantCulture);
            MDB.MDBDataAdapter adt = new MDB.MDBDataAdapter(sql, MyConnection);
            var ds = new DataSet();
            adt.Fill(ds, "Table");
            if (ds.Tables["Table"] != null && ds.Tables["Table"].Rows.Count > 0 && ERMDatabase.FTPImageString != null)
            {
                ds.Tables["Table"].Rows[0]["ManNhiPhai_HinhAnh"] = ds.Tables["Table"].Rows[0]["ManNhiPhai_HinhAnh"].ToString().Contains("PaintLibrary") ? ds.Tables["Table"].Rows[0]["ManNhiPhai_HinhAnh"] : ERMDatabase.FTPImageString + ds.Tables["Table"].Rows[0]["ManNhiPhai_HinhAnh"];
                ds.Tables["Table"].Rows[0]["ManNhiTrai_HinhAnh"] = ds.Tables["Table"].Rows[0]["ManNhiTrai_HinhAnh"].ToString().Contains("PaintLibrary") ? ds.Tables["Table"].Rows[0]["ManNhiTrai_HinhAnh"] : ERMDatabase.FTPImageString + ds.Tables["Table"].Rows[0]["ManNhiTrai_HinhAnh"];
                ds.Tables["Table"].Rows[0]["MuiTruoc_HinhAnh"] = ds.Tables["Table"].Rows[0]["MuiTruoc_HinhAnh"].ToString().Contains("PaintLibrary") ? ds.Tables["Table"].Rows[0]["MuiTruoc_HinhAnh"] : ERMDatabase.FTPImageString + ds.Tables["Table"].Rows[0]["MuiTruoc_HinhAnh"];
                ds.Tables["Table"].Rows[0]["MuiSau_HinhAnh"] = ds.Tables["Table"].Rows[0]["MuiSau_HinhAnh"].ToString().Contains("PaintLibrary") ? ds.Tables["Table"].Rows[0]["MuiSau_HinhAnh"] : ERMDatabase.FTPImageString + ds.Tables["Table"].Rows[0]["MuiSau_HinhAnh"];
                ds.Tables["Table"].Rows[0]["ThanhQuan_HinhAnh"] = ds.Tables["Table"].Rows[0]["ThanhQuan_HinhAnh"].ToString().Contains("PaintLibrary") ? ds.Tables["Table"].Rows[0]["ThanhQuan_HinhAnh"] : ERMDatabase.FTPImageString + ds.Tables["Table"].Rows[0]["ThanhQuan_HinhAnh"];
                ds.Tables["Table"].Rows[0]["Hong_HinhAnh"] = ds.Tables["Table"].Rows[0]["Hong_HinhAnh"].ToString().Contains("PaintLibrary") ? ds.Tables["Table"].Rows[0]["Hong_HinhAnh"] : ERMDatabase.FTPImageString + ds.Tables["Table"].Rows[0]["Hong_HinhAnh"];
                ds.Tables["Table"].Rows[0]["CoNghiengPhai_HinhAnh"] = ds.Tables["Table"].Rows[0]["CoNghiengPhai_HinhAnh"].ToString().Contains("PaintLibrary") ? ds.Tables["Table"].Rows[0]["CoNghiengPhai_HinhAnh"] : ERMDatabase.FTPImageString + ds.Tables["Table"].Rows[0]["CoNghiengPhai_HinhAnh"];
                ds.Tables["Table"].Rows[0]["CoNghiengTrai_HinhAnh"] = ds.Tables["Table"].Rows[0]["CoNghiengTrai_HinhAnh"].ToString().Contains("PaintLibrary") ? ds.Tables["Table"].Rows[0]["CoNghiengTrai_HinhAnh"] : ERMDatabase.FTPImageString + ds.Tables["Table"].Rows[0]["CoNghiengTrai_HinhAnh"];
            }

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
        public static BenhAnNgoaiTruTaiMuiHong Select(MDB.MDBConnection MyConnection, decimal MaQuanLy)
        {
            #region
            string sql =
                      @"select * 
                        from BenhAnNgoaiTruTaiMuiHong a
                        where MaQuanLy = :MaQuanLy";
            #endregion
            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
            Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", MaQuanLy));
            MDB.MDBDataReader DataReader = Command.ExecuteReader();
            var value = new BenhAnNgoaiTruTaiMuiHong();
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
                value.BenhChuyenKhoa = DataReader["BenhChuyenKhoa"].ToString();
                value.MaICD_BenhChinh = DataReader["MaICD_BenhChinh"].ToString();
                value.MaICD_BenhKemTheo = DataReader["MaICD_BenhKemTheo"].ToString();
                value.ManNhiPhai_HinhAnh = ERMDatabase.FTPImageString + DataReader["ManNhiPhai_HinhAnh"].ToString();
                value.ManNhiTrai_HinhAnh = ERMDatabase.FTPImageString + DataReader["ManNhiTrai_HinhAnh"].ToString();
                value.MuiTruoc_HinhAnh = ERMDatabase.FTPImageString + DataReader["MuiTruoc_HinhAnh"].ToString();
                value.MuiSau_HinhAnh = ERMDatabase.FTPImageString + DataReader["MuiSau_HinhAnh"].ToString();
                value.ThanhQuan_HinhAnh = ERMDatabase.FTPImageString + DataReader["ThanhQuan_HinhAnh"].ToString();
                value.Hong_HinhAnh = ERMDatabase.FTPImageString + DataReader["Hong_HinhAnh"].ToString();
                value.CoNghiengPhai_HinhAnh = ERMDatabase.FTPImageString + DataReader["CoNghiengPhai_HinhAnh"].ToString();
                value.CoNghiengTrai_HinhAnh = ERMDatabase.FTPImageString + DataReader["CoNghiengTrai_HinhAnh"].ToString();
                value.ChuanDoanPhongKham = DataReader["ChuanDoanPhongKham"].ToString();
                value.DaXuLy = DataReader["DaXuLy"].ToString();
                value.TaiCho= DataReader["TaiCho"].ToString();
                value.DieuTriNgoaiTru_TuNgay = DataReader.GetDate("DieuTriNgoaiTru_TuNgay");
                value.DieuTriNgoaiTru_DenNgay = DataReader.GetDate("DieuTriNgoaiTru_DenNgay");
                value.PhauThuat = DataReader["PhauThuat"].ToString() == "1" ? true : false;
                value.ThuThuat = DataReader["ThuThuat"].ToString() == "1" ? true : false;
                value.MaSoKyTen = DataReader["masokyten"].ToString();
                value.MaSoKyTen_KB = DataReader["masokyten_kb"].ToString();
                value.MaSoKyTen_TK = DataReader["masokyten_tk"].ToString();
            }
            return value;
        }

        public static bool InsertOrUpdate(MDB.MDBConnection MyConnection, BenhAnNgoaiTruTaiMuiHong BenhAnNgoaiTruTaiMuiHong)
        {
            string sql =
                      @"select MaQuanLy 
                        from BenhAnNgoaiTruTaiMuiHong
                        where MaQuanLy = :MaQuanLy";
            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
            Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", BenhAnNgoaiTruTaiMuiHong.MaQuanLy));
            MDB.MDBDataReader DataReader = Command.ExecuteReader();
            int rowCount = 0;
            while (DataReader.Read()) rowCount++;
            if (rowCount == 1) return Update(MyConnection, BenhAnNgoaiTruTaiMuiHong);
            sql = @"
                   INSERT INTO BenhAnNgoaiTruTaiMuiHong (MaQuanLy, LyDoVaoVien, VaoNgayThu, QuaTrinhBenhLy, TienSuBenhBanThan, TienSuBenhGiaDinh, ToanThan, TuanHoan, HoHap, TieuHoa, ThanTietNieuSinhDuc, ThanKinh, CoXuongKhop, TaiMuiHong, RangHamMat, Mat, Khac_CacCoQuan, CacXetNghiemCanLamSangCanLam, TomTatBenhAn, BenhChinh, BenhKemTheo, PhanBiet, TienLuong, HuongDieuTri, NgayKhamBenh, BacSyLamBenhAn, QuaTrinhBenhLyVaDienBien, TomTatKetQuaXetNghiem, PhuongPhapDieuTri, TinhTrangNguoiBenhRaVien, HuongDieuTriVaCacCheDoTiepTheo, NguoiNhanHoSo, NguoiGiaoHoSo, NgayTongKet, BacSyDieuTri, DiUng, DiUng_Text, MaTuy, MaTuy_Text, RuouBia, RuouBia_Text, ThuocLa, ThuocLa_Text, ThuocLao, ThuocLao_Text, Khac_DacDiemLienQuanBenh, Khac_DacDiemLienQuanBenh_Text,  PhauThuat, ThuThuat, BenhChuyenKhoa, MaICD_BenhChinh, MaICD_BenhKemTheo, ManNhiPhai_HinhAnh, ManNhiTrai_HinhAnh, MuiTruoc_HinhAnh, MuiSau_HinhAnh, ThanhQuan_HinhAnh, Hong_HinhAnh, CoNghiengPhai_HinhAnh, CoNghiengTrai_HinhAnh, ChuanDoanPhongKham, DaXuLy, TaiCho, DieuTriNgoaiTru_TuNgay, DieuTriNgoaiTru_DenNgay)
                   VALUES(:MaQuanLy, :LyDoVaoVien, :VaoNgayThu, :QuaTrinhBenhLy, :TienSuBenhBanThan, :TienSuBenhGiaDinh, :ToanThan, :TuanHoan, :HoHap, :TieuHoa, :ThanTietNieuSinhDuc, :ThanKinh, :CoXuongKhop, :TaiMuiHong, :RangHamMat, :Mat, :Khac_CacCoQuan, :CacXetNghiemCanLamSangCanLam, :TomTatBenhAn, :BenhChinh, :BenhKemTheo, :PhanBiet, :TienLuong, :HuongDieuTri, :NgayKhamBenh, :BacSyLamBenhAn, :QuaTrinhBenhLyVaDienBien, :TomTatKetQuaXetNghiem, :PhuongPhapDieuTri, :TinhTrangNguoiBenhRaVien, :HuongDieuTriVaCacCheDoTiepTheo, :NguoiNhanHoSo, :NguoiGiaoHoSo, :NgayTongKet, :BacSyDieuTri, :DiUng, :DiUng_Text, :MaTuy, :MaTuy_Text, :RuouBia, :RuouBia_Text, :ThuocLa, :ThuocLa_Text, :ThuocLao, :ThuocLao_Text, :Khac_DacDiemLienQuanBenh, :Khac_DacDiemLienQuanBenh_Text,  :PhauThuat, :ThuThuat, :BenhChuyenKhoa, :MaICD_BenhChinh, :MaICD_BenhKemTheo, :ManNhiPhai_HinhAnh, :ManNhiTrai_HinhAnh, :MuiTruoc_HinhAnh, :MuiSau_HinhAnh, :ThanhQuan_HinhAnh, :Hong_HinhAnh, :CoNghiengPhai_HinhAnh, :CoNghiengTrai_HinhAnh, :ChuanDoanPhongKham, :DaXuLy, :TaiCho, :DieuTriNgoaiTru_TuNgay, :DieuTriNgoaiTru_DenNgay)
                   ";
            Command = new MDB.MDBCommand(sql, MyConnection);
            Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", BenhAnNgoaiTruTaiMuiHong.MaQuanLy));
            Command.Parameters.Add(new MDB.MDBParameter("LyDoVaoVien", BenhAnNgoaiTruTaiMuiHong.LyDoVaoVien));
            Command.Parameters.Add(new MDB.MDBParameter("VaoNgayThu", BenhAnNgoaiTruTaiMuiHong.VaoNgayThu));
            Command.Parameters.Add(new MDB.MDBParameter("QuaTrinhBenhLy", BenhAnNgoaiTruTaiMuiHong.QuaTrinhBenhLy));
            Command.Parameters.Add(new MDB.MDBParameter("TienSuBenhBanThan", BenhAnNgoaiTruTaiMuiHong.TienSuBenhBanThan));
            Command.Parameters.Add(new MDB.MDBParameter("TienSuBenhGiaDinh", BenhAnNgoaiTruTaiMuiHong.TienSuBenhGiaDinh));
            Command.Parameters.Add(new MDB.MDBParameter("ToanThan", BenhAnNgoaiTruTaiMuiHong.ToanThan));
            Command.Parameters.Add(new MDB.MDBParameter("TuanHoan", BenhAnNgoaiTruTaiMuiHong.TuanHoan));
            Command.Parameters.Add(new MDB.MDBParameter("HoHap", BenhAnNgoaiTruTaiMuiHong.HoHap));
            Command.Parameters.Add(new MDB.MDBParameter("TieuHoa", BenhAnNgoaiTruTaiMuiHong.TieuHoa));
            Command.Parameters.Add(new MDB.MDBParameter("ThanTietNieuSinhDuc", BenhAnNgoaiTruTaiMuiHong.ThanTietNieuSinhDuc));
            Command.Parameters.Add(new MDB.MDBParameter("ThanKinh", BenhAnNgoaiTruTaiMuiHong.ThanKinh));
            Command.Parameters.Add(new MDB.MDBParameter("CoXuongKhop", BenhAnNgoaiTruTaiMuiHong.CoXuongKhop));
            Command.Parameters.Add(new MDB.MDBParameter("TaiMuiHong", BenhAnNgoaiTruTaiMuiHong.TaiMuiHong));
            Command.Parameters.Add(new MDB.MDBParameter("RangHamMat", BenhAnNgoaiTruTaiMuiHong.RangHamMat));
            Command.Parameters.Add(new MDB.MDBParameter("Mat", BenhAnNgoaiTruTaiMuiHong.Mat));
            Command.Parameters.Add(new MDB.MDBParameter("Khac_CacCoQuan", BenhAnNgoaiTruTaiMuiHong.Khac_CacCoQuan));
            Command.Parameters.Add(new MDB.MDBParameter("CacXetNghiemCanLamSangCanLam", BenhAnNgoaiTruTaiMuiHong.CacXetNghiemCanLamSangCanLam));
            Command.Parameters.Add(new MDB.MDBParameter("TomTatBenhAn", BenhAnNgoaiTruTaiMuiHong.TomTatBenhAn));
            Command.Parameters.Add(new MDB.MDBParameter("BenhChinh", BenhAnNgoaiTruTaiMuiHong.BenhChinh));
            Command.Parameters.Add(new MDB.MDBParameter("BenhKemTheo", BenhAnNgoaiTruTaiMuiHong.BenhKemTheo));
            Command.Parameters.Add(new MDB.MDBParameter("PhanBiet", BenhAnNgoaiTruTaiMuiHong.PhanBiet));
            Command.Parameters.Add(new MDB.MDBParameter("TienLuong", BenhAnNgoaiTruTaiMuiHong.TienLuong));
            Command.Parameters.Add(new MDB.MDBParameter("HuongDieuTri", BenhAnNgoaiTruTaiMuiHong.HuongDieuTri));
            Command.Parameters.Add(new MDB.MDBParameter("NgayKhamBenh", BenhAnNgoaiTruTaiMuiHong.NgayKhamBenh));
            Command.Parameters.Add(new MDB.MDBParameter("BacSyLamBenhAn", BenhAnNgoaiTruTaiMuiHong.BacSyLamBenhAn));
            Command.Parameters.Add(new MDB.MDBParameter("QuaTrinhBenhLyVaDienBien", BenhAnNgoaiTruTaiMuiHong.QuaTrinhBenhLyVaDienBien));
            Command.Parameters.Add(new MDB.MDBParameter("TomTatKetQuaXetNghiem", BenhAnNgoaiTruTaiMuiHong.TomTatKetQuaXetNghiem));
            Command.Parameters.Add(new MDB.MDBParameter("PhuongPhapDieuTri", BenhAnNgoaiTruTaiMuiHong.PhuongPhapDieuTri));
            Command.Parameters.Add(new MDB.MDBParameter("TinhTrangNguoiBenhRaVien", BenhAnNgoaiTruTaiMuiHong.TinhTrangNguoiBenhRaVien));
            Command.Parameters.Add(new MDB.MDBParameter("HuongDieuTriVaCacCheDoTiepTheo", BenhAnNgoaiTruTaiMuiHong.HuongDieuTriVaCacCheDoTiepTheo));
            Command.Parameters.Add(new MDB.MDBParameter("NguoiNhanHoSo", BenhAnNgoaiTruTaiMuiHong.NguoiNhanHoSo));
            Command.Parameters.Add(new MDB.MDBParameter("NguoiGiaoHoSo", BenhAnNgoaiTruTaiMuiHong.NguoiGiaoHoSo));
            Command.Parameters.Add(new MDB.MDBParameter("NgayTongKet", BenhAnNgoaiTruTaiMuiHong.NgayTongKet));
            Command.Parameters.Add(new MDB.MDBParameter("BacSyDieuTri", BenhAnNgoaiTruTaiMuiHong.BacSyDieuTri));
            Command.Parameters.Add(new MDB.MDBParameter("DiUng", BenhAnNgoaiTruTaiMuiHong.DacDiemLienQuanBenh.DiUng == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("DiUng_Text", BenhAnNgoaiTruTaiMuiHong.DacDiemLienQuanBenh.DiUng_Text));
            Command.Parameters.Add(new MDB.MDBParameter("MaTuy", BenhAnNgoaiTruTaiMuiHong.DacDiemLienQuanBenh.MaTuy == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("MaTuy_Text", BenhAnNgoaiTruTaiMuiHong.DacDiemLienQuanBenh.MaTuy_Text));
            Command.Parameters.Add(new MDB.MDBParameter("RuouBia", BenhAnNgoaiTruTaiMuiHong.DacDiemLienQuanBenh.RuouBia == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("RuouBia_Text", BenhAnNgoaiTruTaiMuiHong.DacDiemLienQuanBenh.RuouBia_Text));
            Command.Parameters.Add(new MDB.MDBParameter("ThuocLa", BenhAnNgoaiTruTaiMuiHong.DacDiemLienQuanBenh.ThuocLa == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("ThuocLa_Text", BenhAnNgoaiTruTaiMuiHong.DacDiemLienQuanBenh.ThuocLa_Text));
            Command.Parameters.Add(new MDB.MDBParameter("ThuocLao", BenhAnNgoaiTruTaiMuiHong.DacDiemLienQuanBenh.ThuocLao == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("ThuocLao_Text", BenhAnNgoaiTruTaiMuiHong.DacDiemLienQuanBenh.ThuocLao_Text));
            Command.Parameters.Add(new MDB.MDBParameter("Khac_DacDiemLienQuanBenh", BenhAnNgoaiTruTaiMuiHong.DacDiemLienQuanBenh.Khac_DacDiemLienQuanBenh == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("Khac_DacDiemLienQuanBenh_Text", BenhAnNgoaiTruTaiMuiHong.DacDiemLienQuanBenh.Khac_DacDiemLienQuanBenh_Text));
            Command.Parameters.Add(new MDB.MDBParameter("PhauThuat", BenhAnNgoaiTruTaiMuiHong.PhauThuat == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("ThuThuat", BenhAnNgoaiTruTaiMuiHong.ThuThuat == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("BenhChuyenKhoa", BenhAnNgoaiTruTaiMuiHong.BenhChuyenKhoa));
            Command.Parameters.Add(new MDB.MDBParameter("MaICD_BenhChinh", BenhAnNgoaiTruTaiMuiHong.MaICD_BenhChinh));
            Command.Parameters.Add(new MDB.MDBParameter("MaICD_BenhKemTheo", BenhAnNgoaiTruTaiMuiHong.MaICD_BenhKemTheo));
            Command.Parameters.Add(new MDB.MDBParameter("ManNhiPhai_HinhAnh", BenhAnNgoaiTruTaiMuiHong.ManNhiPhai_HinhAnh));
            Command.Parameters.Add(new MDB.MDBParameter("ManNhiTrai_HinhAnh", BenhAnNgoaiTruTaiMuiHong.ManNhiTrai_HinhAnh));
            Command.Parameters.Add(new MDB.MDBParameter("MuiTruoc_HinhAnh", BenhAnNgoaiTruTaiMuiHong.MuiTruoc_HinhAnh));
            Command.Parameters.Add(new MDB.MDBParameter("MuiSau_HinhAnh", BenhAnNgoaiTruTaiMuiHong.MuiSau_HinhAnh));
            Command.Parameters.Add(new MDB.MDBParameter("ThanhQuan_HinhAnh", BenhAnNgoaiTruTaiMuiHong.ThanhQuan_HinhAnh));
            Command.Parameters.Add(new MDB.MDBParameter("Hong_HinhAnh", BenhAnNgoaiTruTaiMuiHong.Hong_HinhAnh));
            Command.Parameters.Add(new MDB.MDBParameter("CoNghiengPhai_HinhAnh", BenhAnNgoaiTruTaiMuiHong.CoNghiengPhai_HinhAnh));
            Command.Parameters.Add(new MDB.MDBParameter("CoNghiengTrai_HinhAnh", BenhAnNgoaiTruTaiMuiHong.CoNghiengTrai_HinhAnh));
            Command.Parameters.Add(new MDB.MDBParameter("ChuanDoanPhongKham", BenhAnNgoaiTruTaiMuiHong.ChuanDoanPhongKham));
            Command.Parameters.Add(new MDB.MDBParameter("DaXuLy", BenhAnNgoaiTruTaiMuiHong.DaXuLy));
            Command.Parameters.Add(new MDB.MDBParameter("TaiCho", BenhAnNgoaiTruTaiMuiHong.TaiCho));
            Command.Parameters.Add(new MDB.MDBParameter("DieuTriNgoaiTru_TuNgay", BenhAnNgoaiTruTaiMuiHong.DieuTriNgoaiTru_TuNgay));
            Command.Parameters.Add(new MDB.MDBParameter("DieuTriNgoaiTru_DenNgay", BenhAnNgoaiTruTaiMuiHong.DieuTriNgoaiTru_DenNgay));

        

            int n = Command.ExecuteNonQuery(); // C#
            return n > 0 ? true : false;
        }
        public static bool Update(MDB.MDBConnection MyConnection, BenhAnNgoaiTruTaiMuiHong BenhAnNgoaiTruTaiMuiHong)
        {
            string sql = @"UPDATE BenhAnNgoaiTruTaiMuiHong SET 
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
BenhChuyenKhoa = :BenhChuyenKhoa,
MaICD_BenhChinh = :MaICD_BenhChinh,
MaICD_BenhKemTheo = :MaICD_BenhKemTheo,
ManNhiPhai_HinhAnh = :ManNhiPhai_HinhAnh,
ManNhiTrai_HinhAnh = :ManNhiTrai_HinhAnh,
MuiTruoc_HinhAnh = :MuiTruoc_HinhAnh,
MuiSau_HinhAnh = :MuiSau_HinhAnh,
ThanhQuan_HinhAnh = :ThanhQuan_HinhAnh,
Hong_HinhAnh = :Hong_HinhAnh,
CoNghiengPhai_HinhAnh = :CoNghiengPhai_HinhAnh,
CoNghiengTrai_HinhAnh = :CoNghiengTrai_HinhAnh,
ChuanDoanPhongKham = :ChuanDoanPhongKham,
DaXuLy = :DaXuLy,
TaiCho = :TaiCho,
DieuTriNgoaiTru_TuNgay = :DieuTriNgoaiTru_TuNgay,
DieuTriNgoaiTru_DenNgay = :DieuTriNgoaiTru_DenNgay,
PhauThuat = :PhauThuat,
ThuThuat = :ThuThuat

                        WHERE MaQuanLy = :MaQuanLy";
            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
            Command.Parameters.Add(new MDB.MDBParameter("LyDoVaoVien", BenhAnNgoaiTruTaiMuiHong.LyDoVaoVien));
            Command.Parameters.Add(new MDB.MDBParameter("VaoNgayThu", BenhAnNgoaiTruTaiMuiHong.VaoNgayThu));
            Command.Parameters.Add(new MDB.MDBParameter("QuaTrinhBenhLy", BenhAnNgoaiTruTaiMuiHong.QuaTrinhBenhLy));
            Command.Parameters.Add(new MDB.MDBParameter("TienSuBenhBanThan", BenhAnNgoaiTruTaiMuiHong.TienSuBenhBanThan));
            Command.Parameters.Add(new MDB.MDBParameter("TienSuBenhGiaDinh", BenhAnNgoaiTruTaiMuiHong.TienSuBenhGiaDinh));
            Command.Parameters.Add(new MDB.MDBParameter("ToanThan", BenhAnNgoaiTruTaiMuiHong.ToanThan));
            Command.Parameters.Add(new MDB.MDBParameter("TuanHoan", BenhAnNgoaiTruTaiMuiHong.TuanHoan));
            Command.Parameters.Add(new MDB.MDBParameter("HoHap", BenhAnNgoaiTruTaiMuiHong.HoHap));
            Command.Parameters.Add(new MDB.MDBParameter("TieuHoa", BenhAnNgoaiTruTaiMuiHong.TieuHoa));
            Command.Parameters.Add(new MDB.MDBParameter("ThanTietNieuSinhDuc", BenhAnNgoaiTruTaiMuiHong.ThanTietNieuSinhDuc));
            Command.Parameters.Add(new MDB.MDBParameter("ThanKinh", BenhAnNgoaiTruTaiMuiHong.ThanKinh));
            Command.Parameters.Add(new MDB.MDBParameter("CoXuongKhop", BenhAnNgoaiTruTaiMuiHong.CoXuongKhop));
            Command.Parameters.Add(new MDB.MDBParameter("TaiMuiHong", BenhAnNgoaiTruTaiMuiHong.TaiMuiHong));
            Command.Parameters.Add(new MDB.MDBParameter("RangHamMat", BenhAnNgoaiTruTaiMuiHong.RangHamMat));
            Command.Parameters.Add(new MDB.MDBParameter("Mat", BenhAnNgoaiTruTaiMuiHong.Mat));
            Command.Parameters.Add(new MDB.MDBParameter("Khac_CacCoQuan", BenhAnNgoaiTruTaiMuiHong.Khac_CacCoQuan));
            Command.Parameters.Add(new MDB.MDBParameter("CacXetNghiemCanLamSangCanLam", BenhAnNgoaiTruTaiMuiHong.CacXetNghiemCanLamSangCanLam));
            Command.Parameters.Add(new MDB.MDBParameter("TomTatBenhAn", BenhAnNgoaiTruTaiMuiHong.TomTatBenhAn));
            Command.Parameters.Add(new MDB.MDBParameter("BenhChinh", BenhAnNgoaiTruTaiMuiHong.BenhChinh));
            Command.Parameters.Add(new MDB.MDBParameter("BenhKemTheo", BenhAnNgoaiTruTaiMuiHong.BenhKemTheo));
            Command.Parameters.Add(new MDB.MDBParameter("PhanBiet", BenhAnNgoaiTruTaiMuiHong.PhanBiet));
            Command.Parameters.Add(new MDB.MDBParameter("TienLuong", BenhAnNgoaiTruTaiMuiHong.TienLuong));
            Command.Parameters.Add(new MDB.MDBParameter("HuongDieuTri", BenhAnNgoaiTruTaiMuiHong.HuongDieuTri));
            Command.Parameters.Add(new MDB.MDBParameter("NgayKhamBenh", BenhAnNgoaiTruTaiMuiHong.NgayKhamBenh));
            Command.Parameters.Add(new MDB.MDBParameter("BacSyLamBenhAn", BenhAnNgoaiTruTaiMuiHong.BacSyLamBenhAn));
            Command.Parameters.Add(new MDB.MDBParameter("QuaTrinhBenhLyVaDienBien", BenhAnNgoaiTruTaiMuiHong.QuaTrinhBenhLyVaDienBien));
            Command.Parameters.Add(new MDB.MDBParameter("TomTatKetQuaXetNghiem", BenhAnNgoaiTruTaiMuiHong.TomTatKetQuaXetNghiem));
            Command.Parameters.Add(new MDB.MDBParameter("PhuongPhapDieuTri", BenhAnNgoaiTruTaiMuiHong.PhuongPhapDieuTri));
            Command.Parameters.Add(new MDB.MDBParameter("TinhTrangNguoiBenhRaVien", BenhAnNgoaiTruTaiMuiHong.TinhTrangNguoiBenhRaVien));
            Command.Parameters.Add(new MDB.MDBParameter("HuongDieuTriVaCacCheDoTiepTheo", BenhAnNgoaiTruTaiMuiHong.HuongDieuTriVaCacCheDoTiepTheo));
            Command.Parameters.Add(new MDB.MDBParameter("NguoiNhanHoSo", BenhAnNgoaiTruTaiMuiHong.NguoiNhanHoSo));
            Command.Parameters.Add(new MDB.MDBParameter("NguoiGiaoHoSo", BenhAnNgoaiTruTaiMuiHong.NguoiGiaoHoSo));
            Command.Parameters.Add(new MDB.MDBParameter("NgayTongKet", BenhAnNgoaiTruTaiMuiHong.NgayTongKet));
            Command.Parameters.Add(new MDB.MDBParameter("BacSyDieuTri", BenhAnNgoaiTruTaiMuiHong.BacSyDieuTri));
            Command.Parameters.Add(new MDB.MDBParameter("DiUng", BenhAnNgoaiTruTaiMuiHong.DacDiemLienQuanBenh.DiUng == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("DiUng_Text", BenhAnNgoaiTruTaiMuiHong.DacDiemLienQuanBenh.DiUng_Text));
            Command.Parameters.Add(new MDB.MDBParameter("MaTuy", BenhAnNgoaiTruTaiMuiHong.DacDiemLienQuanBenh.MaTuy == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("MaTuy_Text", BenhAnNgoaiTruTaiMuiHong.DacDiemLienQuanBenh.MaTuy_Text));
            Command.Parameters.Add(new MDB.MDBParameter("RuouBia", BenhAnNgoaiTruTaiMuiHong.DacDiemLienQuanBenh.RuouBia == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("RuouBia_Text", BenhAnNgoaiTruTaiMuiHong.DacDiemLienQuanBenh.RuouBia_Text));
            Command.Parameters.Add(new MDB.MDBParameter("ThuocLa", BenhAnNgoaiTruTaiMuiHong.DacDiemLienQuanBenh.ThuocLa == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("ThuocLa_Text", BenhAnNgoaiTruTaiMuiHong.DacDiemLienQuanBenh.ThuocLa_Text));
            Command.Parameters.Add(new MDB.MDBParameter("ThuocLao", BenhAnNgoaiTruTaiMuiHong.DacDiemLienQuanBenh.ThuocLao == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("ThuocLao_Text", BenhAnNgoaiTruTaiMuiHong.DacDiemLienQuanBenh.ThuocLao_Text));
            Command.Parameters.Add(new MDB.MDBParameter("Khac_DacDiemLienQuanBenh", BenhAnNgoaiTruTaiMuiHong.DacDiemLienQuanBenh.Khac_DacDiemLienQuanBenh == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("Khac_DacDiemLienQuanBenh_Text", BenhAnNgoaiTruTaiMuiHong.DacDiemLienQuanBenh.Khac_DacDiemLienQuanBenh_Text));
            Command.Parameters.Add(new MDB.MDBParameter("BenhChuyenKhoa", BenhAnNgoaiTruTaiMuiHong.BenhChuyenKhoa));
            Command.Parameters.Add(new MDB.MDBParameter("MaICD_BenhChinh", BenhAnNgoaiTruTaiMuiHong.MaICD_BenhChinh));
            Command.Parameters.Add(new MDB.MDBParameter("MaICD_BenhKemTheo", BenhAnNgoaiTruTaiMuiHong.MaICD_BenhKemTheo));

            Command.Parameters.Add(new MDB.MDBParameter("ManNhiPhai_HinhAnh", BenhAnNgoaiTruTaiMuiHong.ManNhiPhai_HinhAnh.Replace(ERMDatabase.FTPImageString, "")));
            Command.Parameters.Add(new MDB.MDBParameter("ManNhiTrai_HinhAnh", BenhAnNgoaiTruTaiMuiHong.ManNhiTrai_HinhAnh.Replace(ERMDatabase.FTPImageString, "")));
            Command.Parameters.Add(new MDB.MDBParameter("MuiTruoc_HinhAnh", BenhAnNgoaiTruTaiMuiHong.MuiTruoc_HinhAnh.Replace(ERMDatabase.FTPImageString, "")));
            Command.Parameters.Add(new MDB.MDBParameter("MuiSau_HinhAnh", BenhAnNgoaiTruTaiMuiHong.MuiSau_HinhAnh.Replace(ERMDatabase.FTPImageString, "")));
            Command.Parameters.Add(new MDB.MDBParameter("ThanhQuan_HinhAnh", BenhAnNgoaiTruTaiMuiHong.ThanhQuan_HinhAnh.Replace(ERMDatabase.FTPImageString, "")));
            Command.Parameters.Add(new MDB.MDBParameter("Hong_HinhAnh", BenhAnNgoaiTruTaiMuiHong.Hong_HinhAnh.Replace(ERMDatabase.FTPImageString, "")));
            Command.Parameters.Add(new MDB.MDBParameter("CoNghiengPhai_HinhAnh", BenhAnNgoaiTruTaiMuiHong.CoNghiengPhai_HinhAnh.Replace(ERMDatabase.FTPImageString, "")));
            Command.Parameters.Add(new MDB.MDBParameter("CoNghiengTrai_HinhAnh", BenhAnNgoaiTruTaiMuiHong.CoNghiengTrai_HinhAnh.Replace(ERMDatabase.FTPImageString, "")));
            Command.Parameters.Add(new MDB.MDBParameter("ChuanDoanPhongKham", BenhAnNgoaiTruTaiMuiHong.ChuanDoanPhongKham));

            Command.Parameters.Add(new MDB.MDBParameter("DaXuLy", BenhAnNgoaiTruTaiMuiHong.DaXuLy));
            Command.Parameters.Add(new MDB.MDBParameter("TaiCho", BenhAnNgoaiTruTaiMuiHong.TaiCho));
            Command.Parameters.Add(new MDB.MDBParameter("DieuTriNgoaiTru_TuNgay", BenhAnNgoaiTruTaiMuiHong.DieuTriNgoaiTru_TuNgay));
            Command.Parameters.Add(new MDB.MDBParameter("DieuTriNgoaiTru_DenNgay", BenhAnNgoaiTruTaiMuiHong.DieuTriNgoaiTru_DenNgay));

            Command.Parameters.Add(new MDB.MDBParameter("PhauThuat", BenhAnNgoaiTruTaiMuiHong.PhauThuat == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("ThuThuat", BenhAnNgoaiTruTaiMuiHong.ThuThuat == true ? "1" : "0"));

            Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", BenhAnNgoaiTruTaiMuiHong.MaQuanLy));
            int n = Command.ExecuteNonQuery(); // C#
            return n > 0 ? true : false;
        }
        public static bool Delete(MDB.MDBConnection MyConnection, BenhAnNgoaiTruTaiMuiHong BenhAnNgoaiTruTaiMuiHong)
        {
            string sql = @"DELETE FROM BenhAnNgoaiTruTaiMuiHong 
                           WHERE MaQuanLy = :MaQuanLy";
            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
            Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", BenhAnNgoaiTruTaiMuiHong.MaQuanLy));

            int n = Command.ExecuteNonQuery(); // C#
            return n > 0 ? true : false;
        }
    }
}
