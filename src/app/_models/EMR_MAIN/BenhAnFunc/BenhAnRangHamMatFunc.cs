using System.Data;

namespace EMR_MAIN
{
    public class BenhAnRangHamMatFunc
    {
        public static void WriteXml(MDB.MDBConnection MyConnection)
        {
            string sql =
                   @"
                  select  a.*,  CTScanner HoSo_CTScanner, SieuAm HoSo_SieuAm, XetNghiem HoSo_XetNghiem,  Khac HoSo_Khac,  Khac_Text HoSo_Khac_Text,  ToanBoHoSo HoSo_ToanBoHoSo, Mach DauSinhTon_Mach,  NhietDo DauSinhTon_NhietDo,  HuyetAp DauSinhTon_HuyetAp,  NhipTho DauSinhTon_NhipTho,  CanNang DauSinhTon_CanNang  
                  from BenhAnRangHamMat a inner join thongtindieutri b on a.maquanly = b.maquanly
                  where rownum = 1
                    ";
            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
            MDB.MDBDataReader DataReader = Command.ExecuteReader();

            var DataTable = new DataTable { TableName = "BenhAnRangHamMat" };
            DataTable.Load(DataReader as IDataReader);
            DataTable.WriteXml("rptBenhAnRangHamMat.xml");
        }
        public static DataSet SelectDataSet(MDB.MDBConnection MyConnection, decimal MaQuanLy)
        {
            string sql =
                    @"
                 select  a.*,f.hovaten BacSyLamBenhAnHoVaTen ,c.hovaten BacSyDieuTriHoVaTen,d.hovaten NguoiGiaoHoSoHoVaTen,e.hovaten NguoiNhanHoSoHoVaTen, b.XQuang HoSo_XQuang,   b.CTScanner HoSo_CTScanner, b.SieuAm HoSo_SieuAm, b.XetNghiem HoSo_XetNghiem,  b.Khac HoSo_Khac,  b.Khac_Text HoSo_Khac_Text,  b.ToanBoHoSo HoSo_ToanBoHoSo, b.Mach DauSinhTon_Mach, b.NhietDo DauSinhTon_NhietDo,  b.HuyetAp DauSinhTon_HuyetAp,  b.NhipTho DauSinhTon_NhipTho,  b.CanNang DauSinhTon_CanNang  , b.ChieuCao DauSinhTon_ChieuCao, b.BMI DauSinhTon_BMI, b.NgayRaVien 
                 from BenhAnRangHamMat a 
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
                ds.Tables["Table"].Rows[0]["Phai_HinhVe"] = ds.Tables["Table"].Rows[0]["Phai_HinhVe"].ToString().Contains("PaintLibrary") ? ds.Tables["Table"].Rows[0]["Phai_HinhVe"] : ERMDatabase.FTPImageString + ds.Tables["Table"].Rows[0]["Phai_HinhVe"];
                ds.Tables["Table"].Rows[0]["Thang_HinhVe"] = ds.Tables["Table"].Rows[0]["Thang_HinhVe"].ToString().Contains("PaintLibrary") ? ds.Tables["Table"].Rows[0]["Thang_HinhVe"] : ERMDatabase.FTPImageString + ds.Tables["Table"].Rows[0]["Thang_HinhVe"];
                ds.Tables["Table"].Rows[0]["Trai_HinhVe"] = ds.Tables["Table"].Rows[0]["Trai_HinhVe"].ToString().Contains("PaintLibrary") ? ds.Tables["Table"].Rows[0]["Trai_HinhVe"] : ERMDatabase.FTPImageString + ds.Tables["Table"].Rows[0]["Trai_HinhVe"];
                ds.Tables["Table"].Rows[0]["HamTrenVaHong_HinhVe"] = ds.Tables["Table"].Rows[0]["HamTrenVaHong_HinhVe"].ToString().Contains("PaintLibrary") ? ds.Tables["Table"].Rows[0]["HamTrenVaHong_HinhVe"] : ERMDatabase.FTPImageString + ds.Tables["Table"].Rows[0]["HamTrenVaHong_HinhVe"];
                ds.Tables["Table"].Rows[0]["HamDuoi_HinhVe"] = ds.Tables["Table"].Rows[0]["HamDuoi_HinhVe"].ToString().Contains("PaintLibrary") ? ds.Tables["Table"].Rows[0]["HamDuoi_HinhVe"] : ERMDatabase.FTPImageString + ds.Tables["Table"].Rows[0]["HamDuoi_HinhVe"];
                ds.Tables["Table"].Rows[0]["PhanLoai_HinhVe"] = ds.Tables["Table"].Rows[0]["PhanLoai_HinhVe"].ToString().Contains("PaintLibrary") ? ds.Tables["Table"].Rows[0]["PhanLoai_HinhVe"] : ERMDatabase.FTPImageString + ds.Tables["Table"].Rows[0]["PhanLoai_HinhVe"];
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
        public static BenhAnRangHamMat Select(MDB.MDBConnection MyConnection, decimal MaQuanLy)
        {
            #region
            string sql =
                      @"select * 
                        from BenhAnRangHamMat
                        where MaQuanLy = :MaQuanLy";
            #endregion
            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
            Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", MaQuanLy));
            MDB.MDBDataReader DataReader = Command.ExecuteReader();
            var value = new BenhAnRangHamMat();
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
                value.Phai_HinhVe = ERMDatabase.FTPImageString + DataReader["Phai_HinhVe"].ToString();
                value.Thang_HinhVe = ERMDatabase.FTPImageString + DataReader["Thang_HinhVe"].ToString();
                value.Trai_HinhVe = ERMDatabase.FTPImageString + DataReader["Trai_HinhVe"].ToString();
                value.HamTrenVaHong_HinhVe = ERMDatabase.FTPImageString + DataReader["HamTrenVaHong_HinhVe"].ToString();
                value.HamDuoi_HinhVe = ERMDatabase.FTPImageString + DataReader["HamDuoi_HinhVe"].ToString();
                value.PhanLoai_HinhVe = ERMDatabase.FTPImageString + DataReader["PhanLoai_HinhVe"].ToString();

                value.PhauThuat = DataReader["PhauThuat"].ToString() == "1" ? true : false;
                value.ThuThuat = DataReader["ThuThuat"].ToString() == "1" ? true : false;
                value.DinhDuong = DataReader["DinhDuong"].ToString();
                value.RangHamMatDinhDuong = DataReader["RangHamMatDinhDuong"].ToString();
                value.DaVaMoDuoiDa = DataReader["DaVaMoDuoiDa"].ToString();
                value.BenhChuyenKhoa = DataReader["BenhChuyenKhoa"].ToString();

                value.MaSoKyTen = DataReader["masokyten"].ToString();
                value.MaSoKyTen_KB = DataReader["masokyten_kb"].ToString();
                value.MaSoKyTen_TK = DataReader["masokyten_tk"].ToString();
            }
            return value;
        }

        public static bool InsertOrUpdate(MDB.MDBConnection MyConnection, BenhAnRangHamMat BenhAnRangHamMat)
        {
            string sql =
                      @"select MaQuanLy 
                        from BenhAnRangHamMat
                        where MaQuanLy = :MaQuanLy";
            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
            Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", BenhAnRangHamMat.MaQuanLy));
            MDB.MDBDataReader DataReader = Command.ExecuteReader();
            int rowCount = 0;
            while (DataReader.Read()) rowCount++;
            if (rowCount == 1) return Update(MyConnection, BenhAnRangHamMat);
            sql = @"
                   INSERT INTO BenhAnRangHamMat (MaQuanLy, LyDoVaoVien, VaoNgayThu, QuaTrinhBenhLy, TienSuBenhBanThan, TienSuBenhGiaDinh, ToanThan, TuanHoan, HoHap, TieuHoa, ThanTietNieuSinhDuc, ThanKinh, CoXuongKhop, TaiMuiHong, RangHamMat, Mat, Khac_CacCoQuan, CacXetNghiemCanLamSangCanLam, TomTatBenhAn, BenhChinh, BenhKemTheo, PhanBiet, TienLuong, HuongDieuTri, NgayKhamBenh, BacSyLamBenhAn, QuaTrinhBenhLyVaDienBien, TomTatKetQuaXetNghiem, PhuongPhapDieuTri, TinhTrangNguoiBenhRaVien, HuongDieuTriVaCacCheDoTiepTheo, NguoiNhanHoSo, NguoiGiaoHoSo, NgayTongKet, BacSyDieuTri, DiUng, DiUng_Text, MaTuy, MaTuy_Text, RuouBia, RuouBia_Text, ThuocLa, ThuocLa_Text, ThuocLao, ThuocLao_Text, Khac_DacDiemLienQuanBenh, Khac_DacDiemLienQuanBenh_Text, Phai_HinhVe, Thang_HinhVe, Trai_HinhVe, HamTrenVaHong_HinhVe, HamDuoi_HinhVe, PhanLoai_HinhVe,  PhauThuat, ThuThuat,DinhDuong,RangHamMatDinhDuong, DaVaMoDuoiDa, BenhChuyenKhoa)
                   VALUES(:MaQuanLy, :LyDoVaoVien, :VaoNgayThu, :QuaTrinhBenhLy, :TienSuBenhBanThan, :TienSuBenhGiaDinh, :ToanThan, :TuanHoan, :HoHap, :TieuHoa, :ThanTietNieuSinhDuc, :ThanKinh, :CoXuongKhop, :TaiMuiHong, :RangHamMat, :Mat, :Khac_CacCoQuan, :CacXetNghiemCanLamSangCanLam, :TomTatBenhAn, :BenhChinh, :BenhKemTheo, :PhanBiet, :TienLuong, :HuongDieuTri, :NgayKhamBenh, :BacSyLamBenhAn, :QuaTrinhBenhLyVaDienBien, :TomTatKetQuaXetNghiem, :PhuongPhapDieuTri, :TinhTrangNguoiBenhRaVien, :HuongDieuTriVaCacCheDoTiepTheo, :NguoiNhanHoSo, :NguoiGiaoHoSo, :NgayTongKet, :BacSyDieuTri, :DiUng, :DiUng_Text, :MaTuy, :MaTuy_Text, :RuouBia, :RuouBia_Text, :ThuocLa, :ThuocLa_Text, :ThuocLao, :ThuocLao_Text, :Khac_DacDiemLienQuanBenh, :Khac_DacDiemLienQuanBenh_Text, :Phai_HinhVe, :Thang_HinhVe, :Trai_HinhVe, :HamTrenVaHong_HinhVe, :HamDuoi_HinhVe, :PhanLoai_HinhVe, :PhauThuat, :ThuThuat, :DinhDuong, :RangHamMatDinhDuong, :DaVaMoDuoiDa, :BenhChuyenKhoa)
                   ";
            Command = new MDB.MDBCommand(sql, MyConnection);
            Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", BenhAnRangHamMat.MaQuanLy));
            Command.Parameters.Add(new MDB.MDBParameter("LyDoVaoVien", BenhAnRangHamMat.LyDoVaoVien));
            Command.Parameters.Add(new MDB.MDBParameter("VaoNgayThu", BenhAnRangHamMat.VaoNgayThu));
            Command.Parameters.Add(new MDB.MDBParameter("QuaTrinhBenhLy", BenhAnRangHamMat.QuaTrinhBenhLy));
            Command.Parameters.Add(new MDB.MDBParameter("TienSuBenhBanThan", BenhAnRangHamMat.TienSuBenhBanThan));
            Command.Parameters.Add(new MDB.MDBParameter("TienSuBenhGiaDinh", BenhAnRangHamMat.TienSuBenhGiaDinh));
            Command.Parameters.Add(new MDB.MDBParameter("ToanThan", BenhAnRangHamMat.ToanThan));
            Command.Parameters.Add(new MDB.MDBParameter("TuanHoan", BenhAnRangHamMat.TuanHoan));
            Command.Parameters.Add(new MDB.MDBParameter("HoHap", BenhAnRangHamMat.HoHap));
            Command.Parameters.Add(new MDB.MDBParameter("TieuHoa", BenhAnRangHamMat.TieuHoa));
            Command.Parameters.Add(new MDB.MDBParameter("ThanTietNieuSinhDuc", BenhAnRangHamMat.ThanTietNieuSinhDuc));
            Command.Parameters.Add(new MDB.MDBParameter("ThanKinh", BenhAnRangHamMat.ThanKinh));
            Command.Parameters.Add(new MDB.MDBParameter("CoXuongKhop", BenhAnRangHamMat.CoXuongKhop));
            Command.Parameters.Add(new MDB.MDBParameter("TaiMuiHong", BenhAnRangHamMat.TaiMuiHong));
            Command.Parameters.Add(new MDB.MDBParameter("RangHamMat", BenhAnRangHamMat.RangHamMat));
            Command.Parameters.Add(new MDB.MDBParameter("Mat", BenhAnRangHamMat.Mat));
            Command.Parameters.Add(new MDB.MDBParameter("Khac_CacCoQuan", BenhAnRangHamMat.Khac_CacCoQuan));
            Command.Parameters.Add(new MDB.MDBParameter("CacXetNghiemCanLamSangCanLam", BenhAnRangHamMat.CacXetNghiemCanLamSangCanLam));
            Command.Parameters.Add(new MDB.MDBParameter("TomTatBenhAn", BenhAnRangHamMat.TomTatBenhAn));
            Command.Parameters.Add(new MDB.MDBParameter("BenhChinh", BenhAnRangHamMat.BenhChinh));
            Command.Parameters.Add(new MDB.MDBParameter("BenhKemTheo", BenhAnRangHamMat.BenhKemTheo));
            Command.Parameters.Add(new MDB.MDBParameter("PhanBiet", BenhAnRangHamMat.PhanBiet));
            Command.Parameters.Add(new MDB.MDBParameter("TienLuong", BenhAnRangHamMat.TienLuong));
            Command.Parameters.Add(new MDB.MDBParameter("HuongDieuTri", BenhAnRangHamMat.HuongDieuTri));
            Command.Parameters.Add(new MDB.MDBParameter("NgayKhamBenh", BenhAnRangHamMat.NgayKhamBenh));
            Command.Parameters.Add(new MDB.MDBParameter("BacSyLamBenhAn", BenhAnRangHamMat.BacSyLamBenhAn));
            Command.Parameters.Add(new MDB.MDBParameter("QuaTrinhBenhLyVaDienBien", BenhAnRangHamMat.QuaTrinhBenhLyVaDienBien));
            Command.Parameters.Add(new MDB.MDBParameter("TomTatKetQuaXetNghiem", BenhAnRangHamMat.TomTatKetQuaXetNghiem));
            Command.Parameters.Add(new MDB.MDBParameter("PhuongPhapDieuTri", BenhAnRangHamMat.PhuongPhapDieuTri));
            Command.Parameters.Add(new MDB.MDBParameter("TinhTrangNguoiBenhRaVien", BenhAnRangHamMat.TinhTrangNguoiBenhRaVien));
            Command.Parameters.Add(new MDB.MDBParameter("HuongDieuTriVaCacCheDoTiepTheo", BenhAnRangHamMat.HuongDieuTriVaCacCheDoTiepTheo));
            Command.Parameters.Add(new MDB.MDBParameter("NguoiNhanHoSo", BenhAnRangHamMat.NguoiNhanHoSo));
            Command.Parameters.Add(new MDB.MDBParameter("NguoiGiaoHoSo", BenhAnRangHamMat.NguoiGiaoHoSo));
            Command.Parameters.Add(new MDB.MDBParameter("NgayTongKet", BenhAnRangHamMat.NgayTongKet));
            Command.Parameters.Add(new MDB.MDBParameter("BacSyDieuTri", BenhAnRangHamMat.BacSyDieuTri));
            Command.Parameters.Add(new MDB.MDBParameter("DiUng", BenhAnRangHamMat.DacDiemLienQuanBenh.DiUng == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("DiUng_Text", BenhAnRangHamMat.DacDiemLienQuanBenh.DiUng_Text));
            Command.Parameters.Add(new MDB.MDBParameter("MaTuy", BenhAnRangHamMat.DacDiemLienQuanBenh.MaTuy == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("MaTuy_Text", BenhAnRangHamMat.DacDiemLienQuanBenh.MaTuy_Text));
            Command.Parameters.Add(new MDB.MDBParameter("RuouBia", BenhAnRangHamMat.DacDiemLienQuanBenh.RuouBia == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("RuouBia_Text", BenhAnRangHamMat.DacDiemLienQuanBenh.RuouBia_Text));
            Command.Parameters.Add(new MDB.MDBParameter("ThuocLa", BenhAnRangHamMat.DacDiemLienQuanBenh.ThuocLa == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("ThuocLa_Text", BenhAnRangHamMat.DacDiemLienQuanBenh.ThuocLa_Text));
            Command.Parameters.Add(new MDB.MDBParameter("ThuocLao", BenhAnRangHamMat.DacDiemLienQuanBenh.ThuocLao == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("ThuocLao_Text", BenhAnRangHamMat.DacDiemLienQuanBenh.ThuocLao_Text));
            Command.Parameters.Add(new MDB.MDBParameter("Khac_DacDiemLienQuanBenh", BenhAnRangHamMat.DacDiemLienQuanBenh.Khac_DacDiemLienQuanBenh == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("Khac_DacDiemLienQuanBenh_Text", BenhAnRangHamMat.DacDiemLienQuanBenh.Khac_DacDiemLienQuanBenh_Text));
            Command.Parameters.Add(new MDB.MDBParameter("Phai_HinhVe", BenhAnRangHamMat.Phai_HinhVe != null ? BenhAnRangHamMat.Phai_HinhVe.Replace(ERMDatabase.FTPImageString, "") : ""));
            Command.Parameters.Add(new MDB.MDBParameter("Thang_HinhVe", BenhAnRangHamMat.Thang_HinhVe != null ? BenhAnRangHamMat.Thang_HinhVe.Replace(ERMDatabase.FTPImageString, "") : ""));
            Command.Parameters.Add(new MDB.MDBParameter("Trai_HinhVe", BenhAnRangHamMat.Trai_HinhVe != null ? BenhAnRangHamMat.Trai_HinhVe.Replace(ERMDatabase.FTPImageString, "") : ""));
            Command.Parameters.Add(new MDB.MDBParameter("HamTrenVaHong_HinhVe", BenhAnRangHamMat.HamTrenVaHong_HinhVe != null ? BenhAnRangHamMat.HamTrenVaHong_HinhVe.Replace(ERMDatabase.FTPImageString, "") : ""));
            Command.Parameters.Add(new MDB.MDBParameter("HamDuoi_HinhVe", BenhAnRangHamMat.HamDuoi_HinhVe != null ? BenhAnRangHamMat.HamDuoi_HinhVe.Replace(ERMDatabase.FTPImageString, "") : ""));
            Command.Parameters.Add(new MDB.MDBParameter("PhanLoai_HinhVe", BenhAnRangHamMat.PhanLoai_HinhVe != null ? BenhAnRangHamMat.PhanLoai_HinhVe.Replace(ERMDatabase.FTPImageString, "") : ""));
            Command.Parameters.Add(new MDB.MDBParameter("PhauThuat", BenhAnRangHamMat.PhauThuat == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("ThuThuat", BenhAnRangHamMat.ThuThuat == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("DinhDuong", BenhAnRangHamMat.DinhDuong));
            Command.Parameters.Add(new MDB.MDBParameter("RangHamMatDinhDuong", BenhAnRangHamMat.RangHamMatDinhDuong));
            Command.Parameters.Add(new MDB.MDBParameter("DaVaMoDuoiDa", BenhAnRangHamMat.DaVaMoDuoiDa));
            Command.Parameters.Add(new MDB.MDBParameter("BenhChuyenKhoa", BenhAnRangHamMat.BenhChuyenKhoa));


            int n = Command.ExecuteNonQuery(); // C#
            return n > 0 ? true : false;
        }
        public static bool Update(MDB.MDBConnection MyConnection, BenhAnRangHamMat BenhAnRangHamMat)
        {
            string sql = @"UPDATE BenhAnRangHamMat SET 
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
                        Phai_HinhVe = :Phai_HinhVe,
                        Thang_HinhVe = :Thang_HinhVe,
                        Trai_HinhVe = :Trai_HinhVe,
                        HamTrenVaHong_HinhVe = :HamTrenVaHong_HinhVe,
                        HamDuoi_HinhVe = :HamDuoi_HinhVe,
                        PhanLoai_HinhVe = :PhanLoai_HinhVe,
                        PhauThuat = :PhauThuat,
                        ThuThuat = :ThuThuat,
                        DinhDuong =  :DinhDuong,
                        RangHamMatDinhDuong = :RangHamMatDinhDuong,
                        DaVaMoDuoiDa = :DaVaMoDuoiDa,
                        BenhChuyenKhoa = :BenhChuyenKhoa
                        WHERE MaQuanLy = :MaQuanLy";
            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
            Command.Parameters.Add(new MDB.MDBParameter("LyDoVaoVien", BenhAnRangHamMat.LyDoVaoVien));
            Command.Parameters.Add(new MDB.MDBParameter("VaoNgayThu", BenhAnRangHamMat.VaoNgayThu));
            Command.Parameters.Add(new MDB.MDBParameter("QuaTrinhBenhLy", BenhAnRangHamMat.QuaTrinhBenhLy));
            Command.Parameters.Add(new MDB.MDBParameter("TienSuBenhBanThan", BenhAnRangHamMat.TienSuBenhBanThan));
            Command.Parameters.Add(new MDB.MDBParameter("TienSuBenhGiaDinh", BenhAnRangHamMat.TienSuBenhGiaDinh));
            Command.Parameters.Add(new MDB.MDBParameter("ToanThan", BenhAnRangHamMat.ToanThan));
            Command.Parameters.Add(new MDB.MDBParameter("TuanHoan", BenhAnRangHamMat.TuanHoan));
            Command.Parameters.Add(new MDB.MDBParameter("HoHap", BenhAnRangHamMat.HoHap));
            Command.Parameters.Add(new MDB.MDBParameter("TieuHoa", BenhAnRangHamMat.TieuHoa));
            Command.Parameters.Add(new MDB.MDBParameter("ThanTietNieuSinhDuc", BenhAnRangHamMat.ThanTietNieuSinhDuc));
            Command.Parameters.Add(new MDB.MDBParameter("ThanKinh", BenhAnRangHamMat.ThanKinh));
            Command.Parameters.Add(new MDB.MDBParameter("CoXuongKhop", BenhAnRangHamMat.CoXuongKhop));
            Command.Parameters.Add(new MDB.MDBParameter("TaiMuiHong", BenhAnRangHamMat.TaiMuiHong));
            Command.Parameters.Add(new MDB.MDBParameter("RangHamMat", BenhAnRangHamMat.RangHamMat));
            Command.Parameters.Add(new MDB.MDBParameter("Mat", BenhAnRangHamMat.Mat));
            Command.Parameters.Add(new MDB.MDBParameter("Khac_CacCoQuan", BenhAnRangHamMat.Khac_CacCoQuan));
            Command.Parameters.Add(new MDB.MDBParameter("CacXetNghiemCanLamSangCanLam", BenhAnRangHamMat.CacXetNghiemCanLamSangCanLam));
            Command.Parameters.Add(new MDB.MDBParameter("TomTatBenhAn", BenhAnRangHamMat.TomTatBenhAn));
            Command.Parameters.Add(new MDB.MDBParameter("BenhChinh", BenhAnRangHamMat.BenhChinh));
            Command.Parameters.Add(new MDB.MDBParameter("BenhKemTheo", BenhAnRangHamMat.BenhKemTheo));
            Command.Parameters.Add(new MDB.MDBParameter("PhanBiet", BenhAnRangHamMat.PhanBiet));
            Command.Parameters.Add(new MDB.MDBParameter("TienLuong", BenhAnRangHamMat.TienLuong));
            Command.Parameters.Add(new MDB.MDBParameter("HuongDieuTri", BenhAnRangHamMat.HuongDieuTri));
            Command.Parameters.Add(new MDB.MDBParameter("NgayKhamBenh", BenhAnRangHamMat.NgayKhamBenh));
            Command.Parameters.Add(new MDB.MDBParameter("BacSyLamBenhAn", BenhAnRangHamMat.BacSyLamBenhAn));
            Command.Parameters.Add(new MDB.MDBParameter("QuaTrinhBenhLyVaDienBien", BenhAnRangHamMat.QuaTrinhBenhLyVaDienBien));
            Command.Parameters.Add(new MDB.MDBParameter("TomTatKetQuaXetNghiem", BenhAnRangHamMat.TomTatKetQuaXetNghiem));
            Command.Parameters.Add(new MDB.MDBParameter("PhuongPhapDieuTri", BenhAnRangHamMat.PhuongPhapDieuTri));
            Command.Parameters.Add(new MDB.MDBParameter("TinhTrangNguoiBenhRaVien", BenhAnRangHamMat.TinhTrangNguoiBenhRaVien));
            Command.Parameters.Add(new MDB.MDBParameter("HuongDieuTriVaCacCheDoTiepTheo", BenhAnRangHamMat.HuongDieuTriVaCacCheDoTiepTheo));
            Command.Parameters.Add(new MDB.MDBParameter("NguoiNhanHoSo", BenhAnRangHamMat.NguoiNhanHoSo));
            Command.Parameters.Add(new MDB.MDBParameter("NguoiGiaoHoSo", BenhAnRangHamMat.NguoiGiaoHoSo));
            Command.Parameters.Add(new MDB.MDBParameter("NgayTongKet", BenhAnRangHamMat.NgayTongKet));
            Command.Parameters.Add(new MDB.MDBParameter("BacSyDieuTri", BenhAnRangHamMat.BacSyDieuTri));
            Command.Parameters.Add(new MDB.MDBParameter("DiUng", BenhAnRangHamMat.DacDiemLienQuanBenh.DiUng == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("DiUng_Text", BenhAnRangHamMat.DacDiemLienQuanBenh.DiUng_Text));
            Command.Parameters.Add(new MDB.MDBParameter("MaTuy", BenhAnRangHamMat.DacDiemLienQuanBenh.MaTuy == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("MaTuy_Text", BenhAnRangHamMat.DacDiemLienQuanBenh.MaTuy_Text));
            Command.Parameters.Add(new MDB.MDBParameter("RuouBia", BenhAnRangHamMat.DacDiemLienQuanBenh.RuouBia == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("RuouBia_Text", BenhAnRangHamMat.DacDiemLienQuanBenh.RuouBia_Text));
            Command.Parameters.Add(new MDB.MDBParameter("ThuocLa", BenhAnRangHamMat.DacDiemLienQuanBenh.ThuocLa == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("ThuocLa_Text", BenhAnRangHamMat.DacDiemLienQuanBenh.ThuocLa_Text));
            Command.Parameters.Add(new MDB.MDBParameter("ThuocLao", BenhAnRangHamMat.DacDiemLienQuanBenh.ThuocLao == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("ThuocLao_Text", BenhAnRangHamMat.DacDiemLienQuanBenh.ThuocLao_Text));
            Command.Parameters.Add(new MDB.MDBParameter("Khac_DacDiemLienQuanBenh", BenhAnRangHamMat.DacDiemLienQuanBenh.Khac_DacDiemLienQuanBenh == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("Khac_DacDiemLienQuanBenh_Text", BenhAnRangHamMat.DacDiemLienQuanBenh.Khac_DacDiemLienQuanBenh_Text));
            Command.Parameters.Add(new MDB.MDBParameter("Phai_HinhVe", BenhAnRangHamMat.Phai_HinhVe != null ? BenhAnRangHamMat.Phai_HinhVe.Replace(ERMDatabase.FTPImageString, "") : ""));
            Command.Parameters.Add(new MDB.MDBParameter("Thang_HinhVe", BenhAnRangHamMat.Thang_HinhVe != null ? BenhAnRangHamMat.Thang_HinhVe.Replace(ERMDatabase.FTPImageString, "") : ""));
            Command.Parameters.Add(new MDB.MDBParameter("Trai_HinhVe", BenhAnRangHamMat.Trai_HinhVe != null ? BenhAnRangHamMat.Trai_HinhVe.Replace(ERMDatabase.FTPImageString, "") : ""));
            Command.Parameters.Add(new MDB.MDBParameter("HamTrenVaHong_HinhVe", BenhAnRangHamMat.HamTrenVaHong_HinhVe != null ? BenhAnRangHamMat.HamTrenVaHong_HinhVe.Replace(ERMDatabase.FTPImageString, "") : ""));
            Command.Parameters.Add(new MDB.MDBParameter("HamDuoi_HinhVe", BenhAnRangHamMat.HamDuoi_HinhVe != null ? BenhAnRangHamMat.HamDuoi_HinhVe.Replace(ERMDatabase.FTPImageString, "") : ""));
            Command.Parameters.Add(new MDB.MDBParameter("PhanLoai_HinhVe", BenhAnRangHamMat.PhanLoai_HinhVe != null ? BenhAnRangHamMat.PhanLoai_HinhVe.Replace(ERMDatabase.FTPImageString, "") : ""));
            Command.Parameters.Add(new MDB.MDBParameter("PhauThuat", BenhAnRangHamMat.PhauThuat == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("ThuThuat", BenhAnRangHamMat.ThuThuat == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("DinhDuong", BenhAnRangHamMat.DinhDuong));
            Command.Parameters.Add(new MDB.MDBParameter("RangHamMatDinhDuong", BenhAnRangHamMat.RangHamMatDinhDuong));
            Command.Parameters.Add(new MDB.MDBParameter("DaVaMoDuoiDa", BenhAnRangHamMat.DaVaMoDuoiDa));
            Command.Parameters.Add(new MDB.MDBParameter("BenhChuyenKhoa", BenhAnRangHamMat.BenhChuyenKhoa));

            Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", BenhAnRangHamMat.MaQuanLy));
            int n = Command.ExecuteNonQuery(); // C#
            return n > 0 ? true : false;
        }
        public static bool Delete(MDB.MDBConnection MyConnection, BenhAnRangHamMat BenhAnRangHamMat)
        {
            string sql = @"DELETE FROM BenhAnRangHamMat 
                           WHERE MaQuanLy = :MaQuanLy";
            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
            Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", BenhAnRangHamMat.MaQuanLy));

            int n = Command.ExecuteNonQuery(); // C#
            return n > 0 ? true : false;
        }
    }
}
