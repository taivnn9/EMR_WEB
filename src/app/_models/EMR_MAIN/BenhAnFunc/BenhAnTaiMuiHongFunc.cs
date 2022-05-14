using System.Data;

namespace EMR_MAIN
{
    public class BenhAnTaiMuiHongFunc
    {
        public static void WriteXml(MDB.MDBConnection MyConnection)
        {
            string sql =
                   @"
                  select  a.*,  CTScanner HoSo_CTScanner, SieuAm HoSo_SieuAm, XetNghiem HoSo_XetNghiem,  Khac HoSo_Khac,  Khac_Text HoSo_Khac_Text,  ToanBoHoSo HoSo_ToanBoHoSo, Mach DauSinhTon_Mach,  NhietDo DauSinhTon_NhietDo,  HuyetAp DauSinhTon_HuyetAp,  NhipTho DauSinhTon_NhipTho,  CanNang DauSinhTon_CanNang  
                  from BenhAnTaiMuiHong a inner join thongtindieutri b on a.maquanly = b.maquanly
                  where rownum = 1
                    ";
            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
            MDB.MDBDataReader DataReader = Command.ExecuteReader();

            var DataTable = new DataTable { TableName = "BenhAnTaiMuiHong" };
            DataTable.Load(DataReader as IDataReader);
            DataTable.WriteXml("rptBenhAnTaiMuiHong.xml");
        }
        public static DataSet SelectDataSet(MDB.MDBConnection MyConnection, decimal MaQuanLy)
        {
            string sql =
                  @"
                  select  a.*,f.hovaten BacSyLamBenhAnHoVaTen ,c.hovaten BacSyDieuTriHoVaTen,d.hovaten NguoiGiaoHoSoHoVaTen,e.hovaten NguoiNhanHoSoHoVaTen, b.XQuang HoSo_XQuang,   b.CTScanner HoSo_CTScanner, b.SieuAm HoSo_SieuAm, b.XetNghiem HoSo_XetNghiem,  b.Khac HoSo_Khac,  b.Khac_Text HoSo_Khac_Text,  b.ToanBoHoSo HoSo_ToanBoHoSo, b.Mach DauSinhTon_Mach, b.NhietDo DauSinhTon_NhietDo,  b.HuyetAp DauSinhTon_HuyetAp,  b.NhipTho DauSinhTon_NhipTho,  b.CanNang DauSinhTon_CanNang  , b.ChieuCao DauSinhTon_ChieuCao, b.BMI DauSinhTon_BMI, b.NgayRaVien 
                 from BenhAnTaiMuiHong a 
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
        public static BenhAnTaiMuiHong Select(MDB.MDBConnection MyConnection, decimal MaQuanLy)
        {
            #region
            string sql =
                      @"select * 
                        from BenhAnTaiMuiHong a
                        where MaQuanLy = :MaQuanLy";
            #endregion
            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
            Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", MaQuanLy));
            MDB.MDBDataReader DataReader = Command.ExecuteReader();
            var value = new BenhAnTaiMuiHong();
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
                value.DaVaMoDuoiDa= DataReader["DaVaMoDuoiDa"].ToString();
                value.ManNhiPhai_HinhAnh = ERMDatabase.FTPImageString + DataReader["ManNhiPhai_HinhAnh"].ToString();
                value.ManNhiTrai_HinhAnh = ERMDatabase.FTPImageString + DataReader["ManNhiTrai_HinhAnh"].ToString();
                value.MuiTruoc_HinhAnh = ERMDatabase.FTPImageString + DataReader["MuiTruoc_HinhAnh"].ToString();
                value.MuiSau_HinhAnh = ERMDatabase.FTPImageString + DataReader["MuiSau_HinhAnh"].ToString();
                value.ThanhQuan_HinhAnh = ERMDatabase.FTPImageString + DataReader["ThanhQuan_HinhAnh"].ToString();
                value.Hong_HinhAnh = ERMDatabase.FTPImageString + DataReader["Hong_HinhAnh"].ToString();
                value.CoNghiengPhai_HinhAnh = ERMDatabase.FTPImageString + DataReader["CoNghiengPhai_HinhAnh"].ToString();
                value.CoNghiengTrai_HinhAnh = ERMDatabase.FTPImageString + DataReader["CoNghiengTrai_HinhAnh"].ToString();
                value.PhauThuat = DataReader["PhauThuat"].ToString() == "1" ? true : false;
                value.ThuThuat = DataReader["ThuThuat"].ToString() == "1" ? true : false;
                value.MaSoKyTen = DataReader["masokyten"].ToString();
                value.MaSoKyTen_KB = DataReader["masokyten_kb"].ToString();
                value.MaSoKyTen_TK = DataReader["masokyten_tk"].ToString();
            }
            return value;
        }

        public static bool InsertOrUpdate(MDB.MDBConnection MyConnection, BenhAnTaiMuiHong BenhAnTaiMuiHong)
        {
            string sql =
                      @"select MaQuanLy 
                        from BenhAnTaiMuiHong
                        where MaQuanLy = :MaQuanLy";
            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
            Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", BenhAnTaiMuiHong.MaQuanLy));
            MDB.MDBDataReader DataReader = Command.ExecuteReader();
            int rowCount = 0;
            while (DataReader.Read()) rowCount++;
            if (rowCount == 1) return Update(MyConnection, BenhAnTaiMuiHong);
            sql = @"
                   INSERT INTO BenhAnTaiMuiHong (MaQuanLy, LyDoVaoVien, VaoNgayThu, QuaTrinhBenhLy, TienSuBenhBanThan, TienSuBenhGiaDinh, ToanThan, TuanHoan, HoHap, TieuHoa, ThanTietNieuSinhDuc, ThanKinh, CoXuongKhop, TaiMuiHong, RangHamMat, Mat, Khac_CacCoQuan, CacXetNghiemCanLamSangCanLam, TomTatBenhAn, BenhChinh, BenhKemTheo, PhanBiet, TienLuong, HuongDieuTri, NgayKhamBenh, BacSyLamBenhAn, QuaTrinhBenhLyVaDienBien, TomTatKetQuaXetNghiem, PhuongPhapDieuTri, TinhTrangNguoiBenhRaVien, HuongDieuTriVaCacCheDoTiepTheo, NguoiNhanHoSo, NguoiGiaoHoSo, NgayTongKet, BacSyDieuTri, DiUng, DiUng_Text, MaTuy, MaTuy_Text, RuouBia, RuouBia_Text, ThuocLa, ThuocLa_Text, ThuocLao, ThuocLao_Text, Khac_DacDiemLienQuanBenh, Khac_DacDiemLienQuanBenh_Text,  PhauThuat, ThuThuat, BenhChuyenKhoa, DaVaMoDuoiDa, ManNhiPhai_HinhAnh, ManNhiTrai_HinhAnh, MuiTruoc_HinhAnh, MuiSau_HinhAnh, ThanhQuan_HinhAnh, Hong_HinhAnh, CoNghiengPhai_HinhAnh, CoNghiengTrai_HinhAnh)
                   VALUES(:MaQuanLy, :LyDoVaoVien, :VaoNgayThu, :QuaTrinhBenhLy, :TienSuBenhBanThan, :TienSuBenhGiaDinh, :ToanThan, :TuanHoan, :HoHap, :TieuHoa, :ThanTietNieuSinhDuc, :ThanKinh, :CoXuongKhop, :TaiMuiHong, :RangHamMat, :Mat, :Khac_CacCoQuan, :CacXetNghiemCanLamSangCanLam, :TomTatBenhAn, :BenhChinh, :BenhKemTheo, :PhanBiet, :TienLuong, :HuongDieuTri, :NgayKhamBenh, :BacSyLamBenhAn, :QuaTrinhBenhLyVaDienBien, :TomTatKetQuaXetNghiem, :PhuongPhapDieuTri, :TinhTrangNguoiBenhRaVien, :HuongDieuTriVaCacCheDoTiepTheo, :NguoiNhanHoSo, :NguoiGiaoHoSo, :NgayTongKet, :BacSyDieuTri, :DiUng, :DiUng_Text, :MaTuy, :MaTuy_Text, :RuouBia, :RuouBia_Text, :ThuocLa, :ThuocLa_Text, :ThuocLao, :ThuocLao_Text, :Khac_DacDiemLienQuanBenh, :Khac_DacDiemLienQuanBenh_Text,  :PhauThuat, :ThuThuat, :BenhChuyenKhoa, :DaVaMoDuoiDa, :ManNhiPhai_HinhAnh, :ManNhiTrai_HinhAnh, :MuiTruoc_HinhAnh, :MuiSau_HinhAnh, :ThanhQuan_HinhAnh, :Hong_HinhAnh, :CoNghiengPhai_HinhAnh, :CoNghiengTrai_HinhAnh)
                   ";
            Command = new MDB.MDBCommand(sql, MyConnection);
            Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", BenhAnTaiMuiHong.MaQuanLy));
            Command.Parameters.Add(new MDB.MDBParameter("LyDoVaoVien", BenhAnTaiMuiHong.LyDoVaoVien));
            Command.Parameters.Add(new MDB.MDBParameter("VaoNgayThu", BenhAnTaiMuiHong.VaoNgayThu));
            Command.Parameters.Add(new MDB.MDBParameter("QuaTrinhBenhLy", BenhAnTaiMuiHong.QuaTrinhBenhLy));
            Command.Parameters.Add(new MDB.MDBParameter("TienSuBenhBanThan", BenhAnTaiMuiHong.TienSuBenhBanThan));
            Command.Parameters.Add(new MDB.MDBParameter("TienSuBenhGiaDinh", BenhAnTaiMuiHong.TienSuBenhGiaDinh));
            Command.Parameters.Add(new MDB.MDBParameter("ToanThan", BenhAnTaiMuiHong.ToanThan));
            Command.Parameters.Add(new MDB.MDBParameter("TuanHoan", BenhAnTaiMuiHong.TuanHoan));
            Command.Parameters.Add(new MDB.MDBParameter("HoHap", BenhAnTaiMuiHong.HoHap));
            Command.Parameters.Add(new MDB.MDBParameter("TieuHoa", BenhAnTaiMuiHong.TieuHoa));
            Command.Parameters.Add(new MDB.MDBParameter("ThanTietNieuSinhDuc", BenhAnTaiMuiHong.ThanTietNieuSinhDuc));
            Command.Parameters.Add(new MDB.MDBParameter("ThanKinh", BenhAnTaiMuiHong.ThanKinh));
            Command.Parameters.Add(new MDB.MDBParameter("CoXuongKhop", BenhAnTaiMuiHong.CoXuongKhop));
            Command.Parameters.Add(new MDB.MDBParameter("TaiMuiHong", BenhAnTaiMuiHong.TaiMuiHong));
            Command.Parameters.Add(new MDB.MDBParameter("RangHamMat", BenhAnTaiMuiHong.RangHamMat));
            Command.Parameters.Add(new MDB.MDBParameter("Mat", BenhAnTaiMuiHong.Mat));
            Command.Parameters.Add(new MDB.MDBParameter("Khac_CacCoQuan", BenhAnTaiMuiHong.Khac_CacCoQuan));
            Command.Parameters.Add(new MDB.MDBParameter("CacXetNghiemCanLamSangCanLam", BenhAnTaiMuiHong.CacXetNghiemCanLamSangCanLam));
            Command.Parameters.Add(new MDB.MDBParameter("TomTatBenhAn", BenhAnTaiMuiHong.TomTatBenhAn));
            Command.Parameters.Add(new MDB.MDBParameter("BenhChinh", BenhAnTaiMuiHong.BenhChinh));
            Command.Parameters.Add(new MDB.MDBParameter("BenhKemTheo", BenhAnTaiMuiHong.BenhKemTheo));
            Command.Parameters.Add(new MDB.MDBParameter("PhanBiet", BenhAnTaiMuiHong.PhanBiet));
            Command.Parameters.Add(new MDB.MDBParameter("TienLuong", BenhAnTaiMuiHong.TienLuong));
            Command.Parameters.Add(new MDB.MDBParameter("HuongDieuTri", BenhAnTaiMuiHong.HuongDieuTri));
            Command.Parameters.Add(new MDB.MDBParameter("NgayKhamBenh", BenhAnTaiMuiHong.NgayKhamBenh));
            Command.Parameters.Add(new MDB.MDBParameter("BacSyLamBenhAn", BenhAnTaiMuiHong.BacSyLamBenhAn));
            Command.Parameters.Add(new MDB.MDBParameter("QuaTrinhBenhLyVaDienBien", BenhAnTaiMuiHong.QuaTrinhBenhLyVaDienBien));
            Command.Parameters.Add(new MDB.MDBParameter("TomTatKetQuaXetNghiem", BenhAnTaiMuiHong.TomTatKetQuaXetNghiem));
            Command.Parameters.Add(new MDB.MDBParameter("PhuongPhapDieuTri", BenhAnTaiMuiHong.PhuongPhapDieuTri));
            Command.Parameters.Add(new MDB.MDBParameter("TinhTrangNguoiBenhRaVien", BenhAnTaiMuiHong.TinhTrangNguoiBenhRaVien));
            Command.Parameters.Add(new MDB.MDBParameter("HuongDieuTriVaCacCheDoTiepTheo", BenhAnTaiMuiHong.HuongDieuTriVaCacCheDoTiepTheo));
            Command.Parameters.Add(new MDB.MDBParameter("NguoiNhanHoSo", BenhAnTaiMuiHong.NguoiNhanHoSo));
            Command.Parameters.Add(new MDB.MDBParameter("NguoiGiaoHoSo", BenhAnTaiMuiHong.NguoiGiaoHoSo));
            Command.Parameters.Add(new MDB.MDBParameter("NgayTongKet", BenhAnTaiMuiHong.NgayTongKet));
            Command.Parameters.Add(new MDB.MDBParameter("BacSyDieuTri", BenhAnTaiMuiHong.BacSyDieuTri));
            Command.Parameters.Add(new MDB.MDBParameter("DiUng", BenhAnTaiMuiHong.DacDiemLienQuanBenh.DiUng == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("DiUng_Text", BenhAnTaiMuiHong.DacDiemLienQuanBenh.DiUng_Text));
            Command.Parameters.Add(new MDB.MDBParameter("MaTuy", BenhAnTaiMuiHong.DacDiemLienQuanBenh.MaTuy == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("MaTuy_Text", BenhAnTaiMuiHong.DacDiemLienQuanBenh.MaTuy_Text));
            Command.Parameters.Add(new MDB.MDBParameter("RuouBia", BenhAnTaiMuiHong.DacDiemLienQuanBenh.RuouBia == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("RuouBia_Text", BenhAnTaiMuiHong.DacDiemLienQuanBenh.RuouBia_Text));
            Command.Parameters.Add(new MDB.MDBParameter("ThuocLa", BenhAnTaiMuiHong.DacDiemLienQuanBenh.ThuocLa == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("ThuocLa_Text", BenhAnTaiMuiHong.DacDiemLienQuanBenh.ThuocLa_Text));
            Command.Parameters.Add(new MDB.MDBParameter("ThuocLao", BenhAnTaiMuiHong.DacDiemLienQuanBenh.ThuocLao == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("ThuocLao_Text", BenhAnTaiMuiHong.DacDiemLienQuanBenh.ThuocLao_Text));
            Command.Parameters.Add(new MDB.MDBParameter("Khac_DacDiemLienQuanBenh", BenhAnTaiMuiHong.DacDiemLienQuanBenh.Khac_DacDiemLienQuanBenh == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("Khac_DacDiemLienQuanBenh_Text", BenhAnTaiMuiHong.DacDiemLienQuanBenh.Khac_DacDiemLienQuanBenh_Text));
            Command.Parameters.Add(new MDB.MDBParameter("PhauThuat", BenhAnTaiMuiHong.PhauThuat == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("ThuThuat", BenhAnTaiMuiHong.ThuThuat == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("BenhChuyenKhoa", BenhAnTaiMuiHong.BenhChuyenKhoa));
            Command.Parameters.Add(new MDB.MDBParameter("DaVaMoDuoiDa", BenhAnTaiMuiHong.DaVaMoDuoiDa));
            Command.Parameters.Add(new MDB.MDBParameter("ManNhiPhai_HinhAnh", BenhAnTaiMuiHong.ManNhiPhai_HinhAnh != null ? BenhAnTaiMuiHong.ManNhiPhai_HinhAnh.Replace(ERMDatabase.FTPImageString, ""): ""));
            Command.Parameters.Add(new MDB.MDBParameter("ManNhiTrai_HinhAnh", BenhAnTaiMuiHong.ManNhiTrai_HinhAnh != null ? BenhAnTaiMuiHong.ManNhiTrai_HinhAnh.Replace(ERMDatabase.FTPImageString, "") : ""));
            Command.Parameters.Add(new MDB.MDBParameter("MuiTruoc_HinhAnh", BenhAnTaiMuiHong.MuiTruoc_HinhAnh != null ? BenhAnTaiMuiHong.MuiTruoc_HinhAnh.Replace(ERMDatabase.FTPImageString, "") : ""));
            Command.Parameters.Add(new MDB.MDBParameter("MuiSau_HinhAnh", BenhAnTaiMuiHong.MuiSau_HinhAnh != null ? BenhAnTaiMuiHong.MuiSau_HinhAnh.Replace(ERMDatabase.FTPImageString, "") : ""));
            Command.Parameters.Add(new MDB.MDBParameter("ThanhQuan_HinhAnh", BenhAnTaiMuiHong.ThanhQuan_HinhAnh != null? BenhAnTaiMuiHong.ThanhQuan_HinhAnh.Replace(ERMDatabase.FTPImageString, "") : ""));
            Command.Parameters.Add(new MDB.MDBParameter("Hong_HinhAnh", BenhAnTaiMuiHong.Hong_HinhAnh != null ? BenhAnTaiMuiHong.Hong_HinhAnh.Replace(ERMDatabase.FTPImageString, "") : ""));
            Command.Parameters.Add(new MDB.MDBParameter("CoNghiengPhai_HinhAnh", BenhAnTaiMuiHong.CoNghiengPhai_HinhAnh != null ? BenhAnTaiMuiHong.CoNghiengPhai_HinhAnh.Replace(ERMDatabase.FTPImageString, "") : ""));
            Command.Parameters.Add(new MDB.MDBParameter("CoNghiengTrai_HinhAnh", BenhAnTaiMuiHong.CoNghiengTrai_HinhAnh != null ? BenhAnTaiMuiHong.CoNghiengTrai_HinhAnh.Replace(ERMDatabase.FTPImageString, "") : ""));
            
            int n = Command.ExecuteNonQuery(); // C#
            return n > 0 ? true : false;
        }
        public static bool Update(MDB.MDBConnection MyConnection, BenhAnTaiMuiHong BenhAnTaiMuiHong)
        {
            string sql = @"UPDATE BenhAnTaiMuiHong SET 
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
                        DaVaMoDuoiDa = :DaVaMoDuoiDa,
                        ManNhiPhai_HinhAnh = :ManNhiPhai_HinhAnh,
                        ManNhiTrai_HinhAnh = :ManNhiTrai_HinhAnh,
                        MuiTruoc_HinhAnh = :MuiTruoc_HinhAnh,
                        MuiSau_HinhAnh = :MuiSau_HinhAnh,
                        ThanhQuan_HinhAnh = :ThanhQuan_HinhAnh,
                        Hong_HinhAnh = :Hong_HinhAnh,
                        CoNghiengPhai_HinhAnh = :CoNghiengPhai_HinhAnh,
                        CoNghiengTrai_HinhAnh = :CoNghiengTrai_HinhAnh,
                        PhauThuat = :PhauThuat,
                        ThuThuat = :ThuThuat
                        WHERE MaQuanLy = :MaQuanLy";
            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
            Command.Parameters.Add(new MDB.MDBParameter("LyDoVaoVien", BenhAnTaiMuiHong.LyDoVaoVien));
            Command.Parameters.Add(new MDB.MDBParameter("VaoNgayThu", BenhAnTaiMuiHong.VaoNgayThu));
            Command.Parameters.Add(new MDB.MDBParameter("QuaTrinhBenhLy", BenhAnTaiMuiHong.QuaTrinhBenhLy));
            Command.Parameters.Add(new MDB.MDBParameter("TienSuBenhBanThan", BenhAnTaiMuiHong.TienSuBenhBanThan));
            Command.Parameters.Add(new MDB.MDBParameter("TienSuBenhGiaDinh", BenhAnTaiMuiHong.TienSuBenhGiaDinh));
            Command.Parameters.Add(new MDB.MDBParameter("ToanThan", BenhAnTaiMuiHong.ToanThan));
            Command.Parameters.Add(new MDB.MDBParameter("TuanHoan", BenhAnTaiMuiHong.TuanHoan));
            Command.Parameters.Add(new MDB.MDBParameter("HoHap", BenhAnTaiMuiHong.HoHap));
            Command.Parameters.Add(new MDB.MDBParameter("TieuHoa", BenhAnTaiMuiHong.TieuHoa));
            Command.Parameters.Add(new MDB.MDBParameter("ThanTietNieuSinhDuc", BenhAnTaiMuiHong.ThanTietNieuSinhDuc));
            Command.Parameters.Add(new MDB.MDBParameter("ThanKinh", BenhAnTaiMuiHong.ThanKinh));
            Command.Parameters.Add(new MDB.MDBParameter("CoXuongKhop", BenhAnTaiMuiHong.CoXuongKhop));
            Command.Parameters.Add(new MDB.MDBParameter("TaiMuiHong", BenhAnTaiMuiHong.TaiMuiHong));
            Command.Parameters.Add(new MDB.MDBParameter("RangHamMat", BenhAnTaiMuiHong.RangHamMat));
            Command.Parameters.Add(new MDB.MDBParameter("Mat", BenhAnTaiMuiHong.Mat));
            Command.Parameters.Add(new MDB.MDBParameter("Khac_CacCoQuan", BenhAnTaiMuiHong.Khac_CacCoQuan));
            Command.Parameters.Add(new MDB.MDBParameter("CacXetNghiemCanLamSangCanLam", BenhAnTaiMuiHong.CacXetNghiemCanLamSangCanLam));
            Command.Parameters.Add(new MDB.MDBParameter("TomTatBenhAn", BenhAnTaiMuiHong.TomTatBenhAn));
            Command.Parameters.Add(new MDB.MDBParameter("BenhChinh", BenhAnTaiMuiHong.BenhChinh));
            Command.Parameters.Add(new MDB.MDBParameter("BenhKemTheo", BenhAnTaiMuiHong.BenhKemTheo));
            Command.Parameters.Add(new MDB.MDBParameter("PhanBiet", BenhAnTaiMuiHong.PhanBiet));
            Command.Parameters.Add(new MDB.MDBParameter("TienLuong", BenhAnTaiMuiHong.TienLuong));
            Command.Parameters.Add(new MDB.MDBParameter("HuongDieuTri", BenhAnTaiMuiHong.HuongDieuTri));
            Command.Parameters.Add(new MDB.MDBParameter("NgayKhamBenh", BenhAnTaiMuiHong.NgayKhamBenh));
            Command.Parameters.Add(new MDB.MDBParameter("BacSyLamBenhAn", BenhAnTaiMuiHong.BacSyLamBenhAn));
            Command.Parameters.Add(new MDB.MDBParameter("QuaTrinhBenhLyVaDienBien", BenhAnTaiMuiHong.QuaTrinhBenhLyVaDienBien));
            Command.Parameters.Add(new MDB.MDBParameter("TomTatKetQuaXetNghiem", BenhAnTaiMuiHong.TomTatKetQuaXetNghiem));
            Command.Parameters.Add(new MDB.MDBParameter("PhuongPhapDieuTri", BenhAnTaiMuiHong.PhuongPhapDieuTri));
            Command.Parameters.Add(new MDB.MDBParameter("TinhTrangNguoiBenhRaVien", BenhAnTaiMuiHong.TinhTrangNguoiBenhRaVien));
            Command.Parameters.Add(new MDB.MDBParameter("HuongDieuTriVaCacCheDoTiepTheo", BenhAnTaiMuiHong.HuongDieuTriVaCacCheDoTiepTheo));
            Command.Parameters.Add(new MDB.MDBParameter("NguoiNhanHoSo", BenhAnTaiMuiHong.NguoiNhanHoSo));
            Command.Parameters.Add(new MDB.MDBParameter("NguoiGiaoHoSo", BenhAnTaiMuiHong.NguoiGiaoHoSo));
            Command.Parameters.Add(new MDB.MDBParameter("NgayTongKet", BenhAnTaiMuiHong.NgayTongKet));
            Command.Parameters.Add(new MDB.MDBParameter("BacSyDieuTri", BenhAnTaiMuiHong.BacSyDieuTri));
            Command.Parameters.Add(new MDB.MDBParameter("DiUng", BenhAnTaiMuiHong.DacDiemLienQuanBenh.DiUng == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("DiUng_Text", BenhAnTaiMuiHong.DacDiemLienQuanBenh.DiUng_Text));
            Command.Parameters.Add(new MDB.MDBParameter("MaTuy", BenhAnTaiMuiHong.DacDiemLienQuanBenh.MaTuy == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("MaTuy_Text", BenhAnTaiMuiHong.DacDiemLienQuanBenh.MaTuy_Text));
            Command.Parameters.Add(new MDB.MDBParameter("RuouBia", BenhAnTaiMuiHong.DacDiemLienQuanBenh.RuouBia == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("RuouBia_Text", BenhAnTaiMuiHong.DacDiemLienQuanBenh.RuouBia_Text));
            Command.Parameters.Add(new MDB.MDBParameter("ThuocLa", BenhAnTaiMuiHong.DacDiemLienQuanBenh.ThuocLa == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("ThuocLa_Text", BenhAnTaiMuiHong.DacDiemLienQuanBenh.ThuocLa_Text));
            Command.Parameters.Add(new MDB.MDBParameter("ThuocLao", BenhAnTaiMuiHong.DacDiemLienQuanBenh.ThuocLao == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("ThuocLao_Text", BenhAnTaiMuiHong.DacDiemLienQuanBenh.ThuocLao_Text));
            Command.Parameters.Add(new MDB.MDBParameter("Khac_DacDiemLienQuanBenh", BenhAnTaiMuiHong.DacDiemLienQuanBenh.Khac_DacDiemLienQuanBenh == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("Khac_DacDiemLienQuanBenh_Text", BenhAnTaiMuiHong.DacDiemLienQuanBenh.Khac_DacDiemLienQuanBenh_Text));
            Command.Parameters.Add(new MDB.MDBParameter("BenhChuyenKhoa", BenhAnTaiMuiHong.BenhChuyenKhoa));
            Command.Parameters.Add(new MDB.MDBParameter("DaVaMoDuoiDa", BenhAnTaiMuiHong.DaVaMoDuoiDa));
            Command.Parameters.Add(new MDB.MDBParameter("ManNhiPhai_HinhAnh", BenhAnTaiMuiHong.ManNhiPhai_HinhAnh != null  ? BenhAnTaiMuiHong.ManNhiPhai_HinhAnh.Replace(ERMDatabase.FTPImageString, "") : ""));
            Command.Parameters.Add(new MDB.MDBParameter("ManNhiTrai_HinhAnh", BenhAnTaiMuiHong.ManNhiTrai_HinhAnh != null ? BenhAnTaiMuiHong.ManNhiTrai_HinhAnh.Replace(ERMDatabase.FTPImageString, "") : ""));
            Command.Parameters.Add(new MDB.MDBParameter("MuiTruoc_HinhAnh", BenhAnTaiMuiHong.MuiTruoc_HinhAnh != null ? BenhAnTaiMuiHong.MuiTruoc_HinhAnh.Replace(ERMDatabase.FTPImageString, "") : ""));
            Command.Parameters.Add(new MDB.MDBParameter("MuiSau_HinhAnh", BenhAnTaiMuiHong.MuiSau_HinhAnh != null ? BenhAnTaiMuiHong.MuiSau_HinhAnh.Replace(ERMDatabase.FTPImageString, "") : ""));
            Command.Parameters.Add(new MDB.MDBParameter("ThanhQuan_HinhAnh", BenhAnTaiMuiHong.ThanhQuan_HinhAnh != null ? BenhAnTaiMuiHong.ThanhQuan_HinhAnh.Replace(ERMDatabase.FTPImageString, "") : ""));
            Command.Parameters.Add(new MDB.MDBParameter("Hong_HinhAnh", BenhAnTaiMuiHong.Hong_HinhAnh != null ? BenhAnTaiMuiHong.Hong_HinhAnh.Replace(ERMDatabase.FTPImageString, "") : ""));
            Command.Parameters.Add(new MDB.MDBParameter("CoNghiengPhai_HinhAnh", BenhAnTaiMuiHong.CoNghiengPhai_HinhAnh != null ? BenhAnTaiMuiHong.CoNghiengPhai_HinhAnh.Replace(ERMDatabase.FTPImageString, "") : ""));
            Command.Parameters.Add(new MDB.MDBParameter("CoNghiengTrai_HinhAnh", BenhAnTaiMuiHong.CoNghiengTrai_HinhAnh != null ? BenhAnTaiMuiHong.CoNghiengTrai_HinhAnh.Replace(ERMDatabase.FTPImageString, "") : ""));
            Command.Parameters.Add(new MDB.MDBParameter("PhauThuat", BenhAnTaiMuiHong.PhauThuat == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("ThuThuat", BenhAnTaiMuiHong.ThuThuat == true ? "1" : "0"));

            Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", BenhAnTaiMuiHong.MaQuanLy));
            int n = Command.ExecuteNonQuery(); // C#
            return n > 0 ? true : false;
        }
        public static bool Delete(MDB.MDBConnection MyConnection, BenhAnTaiMuiHong BenhAnTaiMuiHong)
        {
            string sql = @"DELETE FROM BenhAnTaiMuiHong 
                           WHERE MaQuanLy = :MaQuanLy";
            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
            Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", BenhAnTaiMuiHong.MaQuanLy));

            int n = Command.ExecuteNonQuery(); // C#
            return n > 0 ? true : false;
        }
    }
}
