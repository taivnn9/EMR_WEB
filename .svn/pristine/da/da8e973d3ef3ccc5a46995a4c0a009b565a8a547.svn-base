using PMS.Access;
using System.Data;

namespace EMR_MAIN
{
    public class BenhAnUngBuouFunc
    {
        public static void WriteXml(MDB.MDBConnection MyConnection)
        {
            string sql =
                   @"
                  select  a.*,  CTScanner HoSo_CTScanner, SieuAm HoSo_SieuAm, XetNghiem HoSo_XetNghiem,  Khac HoSo_Khac,  Khac_Text HoSo_Khac_Text,  ToanBoHoSo HoSo_ToanBoHoSo, Mach DauSinhTon_Mach,  NhietDo DauSinhTon_NhietDo,  HuyetAp DauSinhTon_HuyetAp,  NhipTho DauSinhTon_NhipTho,  CanNang DauSinhTon_CanNang  
                  from BenhAnUngBuou a inner join thongtindieutri b on a.maquanly = b.maquanly
                  where rownum = 1
                    ";
            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
            MDB.MDBDataReader DataReader = Command.ExecuteReader();

            var DataTable = new DataTable { TableName = "BenhAnUngBuou" };
            DataTable.Load(DataReader as IDataReader);
            DataTable.WriteXml("rptBenhAnUngBuou.xml");
        }
        public static DataSet SelectDataSet(MDB.MDBConnection MyConnection, decimal MaQuanLy)
        {
            string sql =
                 @"
                  select  a.*,f.hovaten BacSyLamBenhAnHoVaTen ,c.hovaten BacSyDieuTriHoVaTen,d.hovaten NguoiGiaoHoSoHoVaTen,e.hovaten NguoiNhanHoSoHoVaTen, b.XQuang HoSo_XQuang,   b.CTScanner HoSo_CTScanner, b.SieuAm HoSo_SieuAm, b.XetNghiem HoSo_XetNghiem,  b.Khac HoSo_Khac,  b.Khac_Text HoSo_Khac_Text,  b.ToanBoHoSo HoSo_ToanBoHoSo, b.Mach DauSinhTon_Mach, b.NhietDo DauSinhTon_NhietDo,  b.HuyetAp DauSinhTon_HuyetAp,  b.NhipTho DauSinhTon_NhipTho,  b.CanNang DauSinhTon_CanNang  , b.ChieuCao DauSinhTon_ChieuCao, b.BMI DauSinhTon_BMI, b.NgayRaVien 
                 from BenhAnUngBuou a 
                 left join thongtindieutri b on a.maquanly = b.maquanly 
                  left join nhanvien c on a.bacsydieutri = c.manhanvien
                  left join nhanvien d on a.nguoigiaohoso = d.manhanvien
                  left join nhanvien e on a.nguoinhanhoso = e.manhanvien
                  left join nhanvien f on a.BacSyLamBenhAn = f.manhanvien
                  where a.maquanly = " + MaQuanLy.ToString(System.Globalization.CultureInfo.InvariantCulture);
            MDB.MDBDataAdapter adt = new MDB.MDBDataAdapter(sql, MyConnection);
            var ds = new DataSet();
            adt.Fill(ds, "Table");
            if (ds.Tables["Table"] != null && ds.Tables["Table"].Rows.Count > 0 && ERMDatabase.FTPImageString
                 != null)
                ds.Tables["Table"].Rows[0]["BoPhanTonThuongHinhAnh"] = ds.Tables["Table"].Rows[0]["BoPhanTonThuongHinhAnh"].ToString().Contains("PaintLibrary") ? ds.Tables["Table"].Rows[0]["BoPhanTonThuongHinhAnh"] : ERMDatabase.FTPImageString + ds.Tables["Table"].Rows[0]["BoPhanTonThuongHinhAnh"];

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
        public static BenhAnUngBuou Select(MDB.MDBConnection MyConnection, decimal MaQuanLy)
        {
            #region
            string sql =
                      @"select * 
                        from BenhAnUngBuou a
                        where MaQuanLy = :MaQuanLy";
            #endregion
            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
            Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", MaQuanLy));
            MDB.MDBDataReader DataReader = Command.ExecuteReader();
            var value = new BenhAnUngBuou();
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
                value.SinhDuc = DataReader["SinhDuc"].ToString();
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
                value.BoPhanTonThuong = DataReader["BoPhanTonThuong"].ToString();
                value.BoPhanTonThuongHinhAnh = ERMDatabase.FTPImageString + DataReader["BoPhanTonThuongHinhAnh"].ToString();
                value.BoPhanTonThuongMoTa = DataReader["BoPhanTonThuongMoTa"].ToString();
                value.BenhChinhT = DataReader["BenhChinhT"].ToString();
                value.BenhChinhM = DataReader["BenhChinhM"].ToString();
                value.BenhChinhN = DataReader["BenhChinhN"].ToString();
                value.GiaiDoan = DataReader["GiaiDoan"].ToString();
                value.XNMau = DataReader["XNMau"].ToString();
                value.XNTeBao = DataReader["XNTeBao"].ToString();
                value.XNBLGP = DataReader["XNBLGP"].ToString();
                value.Xquang = DataReader["Xquang"].ToString();
                value.SieuAm = DataReader["SieuAm"].ToString();
                value.XNKhac = DataReader["XNKhac"].ToString();
                value.DieuTriTrietDe = DataReader["DieuTriTrietDe"].ToString() == "1" ? true : false;
                value.DieuTriTrieuChung = DataReader["DieuTriTrieuChung"].ToString() == "1" ? true : false;
                value.TiaXaTienPhauTaiU = DataReader["TiaXaTienPhauTaiU"].ToString();
                value.TiaXaTienPhauTaiHach = DataReader["TiaXaTienPhauTaiHach"].ToString();
                value.TiaXaDonThuanTaiU = DataReader["TiaXaDonThuanTaiU"].ToString();
                value.TiaXaDonThuanTaiHach = DataReader["TiaXaDonThuanTaiHach"].ToString();
                value.PhauThuat = DataReader["PhauThuat"].ToString();
                value.TiaXaHauPhauTaiU = DataReader["TiaXaHauPhauTaiU"].ToString();
                value.TiaXaHauPhauTaiHach = DataReader["TiaXaHauPhauTaiHach"].ToString();
                value.HoaChat = DataReader["HoaChat"].ToString();
                value.SoDot = DataReader["SoDot"].ToString();
                value.DapUng = DataReader["DapUng"].ToString();
                value.DapUngID = DataReader.GetInt("DapUngID");
                value.DieuTriKhac = DataReader["DieuTriKhac"].ToString();
                value.MaSoKyTen = DataReader["masokyten"].ToString();
                value.MaSoKyTen_KB = DataReader["masokyten_kb"].ToString();
                value.MaSoKyTen_TK = DataReader["masokyten_tk"].ToString();
            }
            return value;
        }

        public static bool InsertOrUpdate(MDB.MDBConnection MyConnection, BenhAnUngBuou BenhAnUngBuou)
        {
            if (BenhAnUngBuou == null) return false;
            if (BenhAnUngBuou.DacDiemLienQuanBenh == null) BenhAnUngBuou.DacDiemLienQuanBenh = new DacDiemLienQuanBenh();
            string sql =
                      @"select MaQuanLy 
                        from BenhAnUngBuou
                        where MaQuanLy = :MaQuanLy";
            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
            Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", BenhAnUngBuou.MaQuanLy));
            MDB.MDBDataReader DataReader = Command.ExecuteReader();
            int rowCount = 0;
            while (DataReader.Read()) rowCount++;
            if (rowCount == 1) return Update(MyConnection, BenhAnUngBuou);
            sql = @"
                   INSERT INTO BenhAnUngBuou (MaQuanLy, LyDoVaoVien, VaoNgayThu, QuaTrinhBenhLy, TienSuBenhBanThan, TienSuBenhGiaDinh, ToanThan, TuanHoan, HoHap, TieuHoa, ThanTietNieuSinhDuc, SinhDuc, ThanKinh, CoXuongKhop, TaiMuiHong, RangHamMat, Mat, Khac_CacCoQuan, CacXetNghiemCanLamSangCanLam, TomTatBenhAn, BenhChinh, BenhKemTheo, PhanBiet, TienLuong, HuongDieuTri, NgayKhamBenh, BacSyLamBenhAn, QuaTrinhBenhLyVaDienBien, TomTatKetQuaXetNghiem, PhuongPhapDieuTri, TinhTrangNguoiBenhRaVien, HuongDieuTriVaCacCheDoTiepTheo, NguoiNhanHoSo, NguoiGiaoHoSo, NgayTongKet, BacSyDieuTri, DiUng, DiUng_Text, MaTuy, MaTuy_Text, RuouBia, RuouBia_Text, ThuocLa, ThuocLa_Text, ThuocLao, ThuocLao_Text, Khac_DacDiemLienQuanBenh, Khac_DacDiemLienQuanBenh_Text, BoPhanTonThuong, BoPhanTonThuongHinhAnh, BoPhanTonThuongMoTa, BenhChinhT, BenhChinhM, BenhChinhN, XNMau, XNTeBao, XNBLGP, Xquang, SieuAm, XNKhac, DieuTriTrietDe, DieuTriTrieuChung, TiaXaTienPhauTaiU, TiaXaTienPhauTaiHach, TiaXaDonThuanTaiU, TiaXaDonThuanTaiHach, PhauThuat, TiaXaHauPhauTaiU, TiaXaHauPhauTaiHach, HoaChat, SoDot, DapUng, DapUngID, DieuTriKhac, GiaiDoan)
                   VALUES(:MaQuanLy, :LyDoVaoVien, :VaoNgayThu, :QuaTrinhBenhLy, :TienSuBenhBanThan, :TienSuBenhGiaDinh, :ToanThan, :TuanHoan, :HoHap, :TieuHoa, :ThanTietNieuSinhDuc, :SinhDuc, :ThanKinh, :CoXuongKhop, :TaiMuiHong, :RangHamMat, :Mat, :Khac_CacCoQuan, :CacXetNghiemCanLamSangCanLam, :TomTatBenhAn, :BenhChinh, :BenhKemTheo, :PhanBiet, :TienLuong, :HuongDieuTri, :NgayKhamBenh, :BacSyLamBenhAn, :QuaTrinhBenhLyVaDienBien, :TomTatKetQuaXetNghiem, :PhuongPhapDieuTri, :TinhTrangNguoiBenhRaVien, :HuongDieuTriVaCacCheDoTiepTheo, :NguoiNhanHoSo, :NguoiGiaoHoSo, :NgayTongKet, :BacSyDieuTri, :DiUng, :DiUng_Text, :MaTuy, :MaTuy_Text, :RuouBia, :RuouBia_Text, :ThuocLa, :ThuocLa_Text, :ThuocLao, :ThuocLao_Text, :Khac_DacDiemLienQuanBenh, :Khac_DacDiemLienQuanBenh_Text, :BoPhanTonThuong, :BoPhanTonThuongHinhAnh, :BoPhanTonThuongMoTa, :BenhChinhT, :BenhChinhM, :BenhChinhN, :XNMau, :XNTeBao, :XNBLGP, :Xquang, :SieuAm, :XNKhac, :DieuTriTrietDe, :DieuTriTrieuChung, :TiaXaTienPhauTaiU, :TiaXaTienPhauTaiHach, :TiaXaDonThuanTaiU, :TiaXaDonThuanTaiHach, :PhauThuat, :TiaXaHauPhauTaiU, :TiaXaHauPhauTaiHach, :HoaChat, :SoDot, :DapUng, :DapUngID, :DieuTriKhac, :GiaiDoan)
                   ";
            Command = new MDB.MDBCommand(sql, MyConnection);
            Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", BenhAnUngBuou.MaQuanLy));
            Command.Parameters.Add(new MDB.MDBParameter("LyDoVaoVien", BenhAnUngBuou.LyDoVaoVien));
            Command.Parameters.Add(new MDB.MDBParameter("VaoNgayThu", BenhAnUngBuou.VaoNgayThu));
            Command.Parameters.Add(new MDB.MDBParameter("QuaTrinhBenhLy", BenhAnUngBuou.QuaTrinhBenhLy));
            Command.Parameters.Add(new MDB.MDBParameter("TienSuBenhBanThan", BenhAnUngBuou.TienSuBenhBanThan));
            Command.Parameters.Add(new MDB.MDBParameter("TienSuBenhGiaDinh", BenhAnUngBuou.TienSuBenhGiaDinh));
            Command.Parameters.Add(new MDB.MDBParameter("ToanThan", BenhAnUngBuou.ToanThan));
            Command.Parameters.Add(new MDB.MDBParameter("TuanHoan", BenhAnUngBuou.TuanHoan));
            Command.Parameters.Add(new MDB.MDBParameter("HoHap", BenhAnUngBuou.HoHap));
            Command.Parameters.Add(new MDB.MDBParameter("TieuHoa", BenhAnUngBuou.TieuHoa));
            Command.Parameters.Add(new MDB.MDBParameter("ThanTietNieuSinhDuc", BenhAnUngBuou.ThanTietNieuSinhDuc));
            Command.Parameters.Add(new MDB.MDBParameter("SinhDuc", BenhAnUngBuou.SinhDuc));
            Command.Parameters.Add(new MDB.MDBParameter("ThanKinh", BenhAnUngBuou.ThanKinh));
            Command.Parameters.Add(new MDB.MDBParameter("CoXuongKhop", BenhAnUngBuou.CoXuongKhop));
            Command.Parameters.Add(new MDB.MDBParameter("TaiMuiHong", BenhAnUngBuou.TaiMuiHong));
            Command.Parameters.Add(new MDB.MDBParameter("RangHamMat", BenhAnUngBuou.RangHamMat));
            Command.Parameters.Add(new MDB.MDBParameter("Mat", BenhAnUngBuou.Mat));
            Command.Parameters.Add(new MDB.MDBParameter("Khac_CacCoQuan", BenhAnUngBuou.Khac_CacCoQuan));
            Command.Parameters.Add(new MDB.MDBParameter("CacXetNghiemCanLamSangCanLam", BenhAnUngBuou.CacXetNghiemCanLamSangCanLam));
            Command.Parameters.Add(new MDB.MDBParameter("TomTatBenhAn", BenhAnUngBuou.TomTatBenhAn));
            Command.Parameters.Add(new MDB.MDBParameter("BenhChinh", BenhAnUngBuou.BenhChinh));
            Command.Parameters.Add(new MDB.MDBParameter("BenhKemTheo", BenhAnUngBuou.BenhKemTheo));
            Command.Parameters.Add(new MDB.MDBParameter("PhanBiet", BenhAnUngBuou.PhanBiet));
            Command.Parameters.Add(new MDB.MDBParameter("TienLuong", BenhAnUngBuou.TienLuong));
            Command.Parameters.Add(new MDB.MDBParameter("HuongDieuTri", BenhAnUngBuou.HuongDieuTri));
            Command.Parameters.Add(new MDB.MDBParameter("NgayKhamBenh", BenhAnUngBuou.NgayKhamBenh));
            Command.Parameters.Add(new MDB.MDBParameter("BacSyLamBenhAn", BenhAnUngBuou.BacSyLamBenhAn));
            Command.Parameters.Add(new MDB.MDBParameter("QuaTrinhBenhLyVaDienBien", BenhAnUngBuou.QuaTrinhBenhLyVaDienBien));
            Command.Parameters.Add(new MDB.MDBParameter("TomTatKetQuaXetNghiem", BenhAnUngBuou.TomTatKetQuaXetNghiem));
            Command.Parameters.Add(new MDB.MDBParameter("PhuongPhapDieuTri", BenhAnUngBuou.PhuongPhapDieuTri));
            Command.Parameters.Add(new MDB.MDBParameter("TinhTrangNguoiBenhRaVien", BenhAnUngBuou.TinhTrangNguoiBenhRaVien));
            Command.Parameters.Add(new MDB.MDBParameter("HuongDieuTriVaCacCheDoTiepTheo", BenhAnUngBuou.HuongDieuTriVaCacCheDoTiepTheo));
            Command.Parameters.Add(new MDB.MDBParameter("NguoiNhanHoSo", BenhAnUngBuou.NguoiNhanHoSo));
            Command.Parameters.Add(new MDB.MDBParameter("NguoiGiaoHoSo", BenhAnUngBuou.NguoiGiaoHoSo));
            Command.Parameters.Add(new MDB.MDBParameter("NgayTongKet", BenhAnUngBuou.NgayTongKet));
            Command.Parameters.Add(new MDB.MDBParameter("BacSyDieuTri", BenhAnUngBuou.BacSyDieuTri));
            Command.Parameters.Add(new MDB.MDBParameter("DiUng", BenhAnUngBuou.DacDiemLienQuanBenh.DiUng == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("DiUng_Text", BenhAnUngBuou.DacDiemLienQuanBenh.DiUng_Text));
            Command.Parameters.Add(new MDB.MDBParameter("MaTuy", BenhAnUngBuou.DacDiemLienQuanBenh.MaTuy == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("MaTuy_Text", BenhAnUngBuou.DacDiemLienQuanBenh.MaTuy_Text));
            Command.Parameters.Add(new MDB.MDBParameter("RuouBia", BenhAnUngBuou.DacDiemLienQuanBenh.RuouBia == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("RuouBia_Text", BenhAnUngBuou.DacDiemLienQuanBenh.RuouBia_Text));
            Command.Parameters.Add(new MDB.MDBParameter("ThuocLa", BenhAnUngBuou.DacDiemLienQuanBenh.ThuocLa == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("ThuocLa_Text", BenhAnUngBuou.DacDiemLienQuanBenh.ThuocLa_Text));
            Command.Parameters.Add(new MDB.MDBParameter("ThuocLao", BenhAnUngBuou.DacDiemLienQuanBenh.ThuocLao == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("ThuocLao_Text", BenhAnUngBuou.DacDiemLienQuanBenh.ThuocLao_Text));
            Command.Parameters.Add(new MDB.MDBParameter("Khac_DacDiemLienQuanBenh", BenhAnUngBuou.DacDiemLienQuanBenh.Khac_DacDiemLienQuanBenh == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("Khac_DacDiemLienQuanBenh_Text", BenhAnUngBuou.DacDiemLienQuanBenh.Khac_DacDiemLienQuanBenh_Text));
            Command.Parameters.Add(new MDB.MDBParameter("BoPhanTonThuong", BenhAnUngBuou.BoPhanTonThuong));
            Command.Parameters.Add(new MDB.MDBParameter("BoPhanTonThuongHinhAnh", BenhAnUngBuou.BoPhanTonThuongHinhAnh == null ? "" : ((ERMDatabase.FTPImageString.IsNullOrEmpty()) ? "default":BenhAnUngBuou.BoPhanTonThuongHinhAnh.Replace(ERMDatabase.FTPImageString,""))));
            Command.Parameters.Add(new MDB.MDBParameter("BoPhanTonThuongMoTa", BenhAnUngBuou.BoPhanTonThuongMoTa));
            Command.Parameters.Add(new MDB.MDBParameter("BenhChinhT", BenhAnUngBuou.BenhChinhT));
            Command.Parameters.Add(new MDB.MDBParameter("BenhChinhM", BenhAnUngBuou.BenhChinhM));
            Command.Parameters.Add(new MDB.MDBParameter("BenhChinhN", BenhAnUngBuou.BenhChinhN));
            Command.Parameters.Add(new MDB.MDBParameter("XNMau", BenhAnUngBuou.XNMau));
            Command.Parameters.Add(new MDB.MDBParameter("XNTeBao", BenhAnUngBuou.XNTeBao));
            Command.Parameters.Add(new MDB.MDBParameter("XNBLGP", BenhAnUngBuou.XNBLGP));
            Command.Parameters.Add(new MDB.MDBParameter("Xquang", BenhAnUngBuou.Xquang));
            Command.Parameters.Add(new MDB.MDBParameter("SieuAm", BenhAnUngBuou.SieuAm));
            Command.Parameters.Add(new MDB.MDBParameter("XNKhac", BenhAnUngBuou.XNKhac));
            Command.Parameters.Add(new MDB.MDBParameter("DieuTriTrietDe", BenhAnUngBuou.DieuTriTrietDe == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("DieuTriTrieuChung", BenhAnUngBuou.DieuTriTrieuChung == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("TiaXaTienPhauTaiU", BenhAnUngBuou.TiaXaTienPhauTaiU));
            Command.Parameters.Add(new MDB.MDBParameter("TiaXaTienPhauTaiHach", BenhAnUngBuou.TiaXaTienPhauTaiHach));
            Command.Parameters.Add(new MDB.MDBParameter("TiaXaDonThuanTaiU", BenhAnUngBuou.TiaXaDonThuanTaiU));
            Command.Parameters.Add(new MDB.MDBParameter("TiaXaDonThuanTaiHach", BenhAnUngBuou.TiaXaDonThuanTaiHach));
            Command.Parameters.Add(new MDB.MDBParameter("PhauThuat", BenhAnUngBuou.PhauThuat));
            Command.Parameters.Add(new MDB.MDBParameter("TiaXaHauPhauTaiU", BenhAnUngBuou.TiaXaHauPhauTaiU));
            Command.Parameters.Add(new MDB.MDBParameter("TiaXaHauPhauTaiHach", BenhAnUngBuou.TiaXaHauPhauTaiHach));
            Command.Parameters.Add(new MDB.MDBParameter("HoaChat", BenhAnUngBuou.HoaChat));
            Command.Parameters.Add(new MDB.MDBParameter("SoDot", BenhAnUngBuou.SoDot));
            Command.Parameters.Add(new MDB.MDBParameter("DapUng", BenhAnUngBuou.DapUng));
            Command.Parameters.Add(new MDB.MDBParameter("DapUngID", BenhAnUngBuou.DapUngID));
            Command.Parameters.Add(new MDB.MDBParameter("DieuTriKhac", BenhAnUngBuou.DieuTriKhac));
            Command.Parameters.Add(new MDB.MDBParameter("GiaiDoan", BenhAnUngBuou.GiaiDoan));


            int n = Command.ExecuteNonQuery(); // C#
            return n > 0 ? true : false;
        }
        public static bool Update(MDB.MDBConnection MyConnection, BenhAnUngBuou BenhAnUngBuou)
        {
            string sql = @"UPDATE BenhAnUngBuou SET 
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
                        SinhDuc= :SinhDuc,
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
                        BoPhanTonThuong = :BoPhanTonThuong,
                        BoPhanTonThuongHinhAnh = :BoPhanTonThuongHinhAnh,
                        BoPhanTonThuongMoTa = :BoPhanTonThuongMoTa,
                        BenhChinhT = :BenhChinhT,
                        BenhChinhM = :BenhChinhM,
                        BenhChinhN = :BenhChinhN,
                        XNMau = :XNMau,
                        XNTeBao = :XNTeBao,
                        XNBLGP = :XNBLGP,
                        Xquang = :Xquang,
                        SieuAm = :SieuAm,
                        XNKhac = :XNKhac,
                        DieuTriTrietDe = :DieuTriTrietDe,
                        DieuTriTrieuChung = :DieuTriTrieuChung,
                        TiaXaTienPhauTaiU = :TiaXaTienPhauTaiU,
                        TiaXaTienPhauTaiHach = :TiaXaTienPhauTaiHach,
                        TiaXaDonThuanTaiU = :TiaXaDonThuanTaiU,
                        TiaXaDonThuanTaiHach = :TiaXaDonThuanTaiHach,
                        PhauThuat = :PhauThuat,
                        TiaXaHauPhauTaiU = :TiaXaHauPhauTaiU,
                        TiaXaHauPhauTaiHach = :TiaXaHauPhauTaiHach,
                        HoaChat = :HoaChat,
                        SoDot = :SoDot,
                        DapUng = :DapUng,
                        DapUngID = :DapUngID,
                        DieuTriKhac = :DieuTriKhac,
                        GiaiDoan = :GiaiDoan

                        WHERE MaQuanLy = :MaQuanLy";
            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
            Command.Parameters.Add(new MDB.MDBParameter("LyDoVaoVien", BenhAnUngBuou.LyDoVaoVien));
            Command.Parameters.Add(new MDB.MDBParameter("VaoNgayThu", BenhAnUngBuou.VaoNgayThu));
            Command.Parameters.Add(new MDB.MDBParameter("QuaTrinhBenhLy", BenhAnUngBuou.QuaTrinhBenhLy));
            Command.Parameters.Add(new MDB.MDBParameter("TienSuBenhBanThan", BenhAnUngBuou.TienSuBenhBanThan));
            Command.Parameters.Add(new MDB.MDBParameter("TienSuBenhGiaDinh", BenhAnUngBuou.TienSuBenhGiaDinh));
            Command.Parameters.Add(new MDB.MDBParameter("ToanThan", BenhAnUngBuou.ToanThan));
            Command.Parameters.Add(new MDB.MDBParameter("TuanHoan", BenhAnUngBuou.TuanHoan));
            Command.Parameters.Add(new MDB.MDBParameter("HoHap", BenhAnUngBuou.HoHap));
            Command.Parameters.Add(new MDB.MDBParameter("TieuHoa", BenhAnUngBuou.TieuHoa));
            Command.Parameters.Add(new MDB.MDBParameter("ThanTietNieuSinhDuc", BenhAnUngBuou.ThanTietNieuSinhDuc));
            Command.Parameters.Add(new MDB.MDBParameter("SinhDuc", BenhAnUngBuou.SinhDuc));
            Command.Parameters.Add(new MDB.MDBParameter("ThanKinh", BenhAnUngBuou.ThanKinh));
            Command.Parameters.Add(new MDB.MDBParameter("CoXuongKhop", BenhAnUngBuou.CoXuongKhop));
            Command.Parameters.Add(new MDB.MDBParameter("TaiMuiHong", BenhAnUngBuou.TaiMuiHong));
            Command.Parameters.Add(new MDB.MDBParameter("RangHamMat", BenhAnUngBuou.RangHamMat));
            Command.Parameters.Add(new MDB.MDBParameter("Mat", BenhAnUngBuou.Mat));
            Command.Parameters.Add(new MDB.MDBParameter("Khac_CacCoQuan", BenhAnUngBuou.Khac_CacCoQuan));
            Command.Parameters.Add(new MDB.MDBParameter("CacXetNghiemCanLamSangCanLam", BenhAnUngBuou.CacXetNghiemCanLamSangCanLam));
            Command.Parameters.Add(new MDB.MDBParameter("TomTatBenhAn", BenhAnUngBuou.TomTatBenhAn));
            Command.Parameters.Add(new MDB.MDBParameter("BenhChinh", BenhAnUngBuou.BenhChinh));
            Command.Parameters.Add(new MDB.MDBParameter("BenhKemTheo", BenhAnUngBuou.BenhKemTheo));
            Command.Parameters.Add(new MDB.MDBParameter("PhanBiet", BenhAnUngBuou.PhanBiet));
            Command.Parameters.Add(new MDB.MDBParameter("TienLuong", BenhAnUngBuou.TienLuong));
            Command.Parameters.Add(new MDB.MDBParameter("HuongDieuTri", BenhAnUngBuou.HuongDieuTri));
            Command.Parameters.Add(new MDB.MDBParameter("NgayKhamBenh", BenhAnUngBuou.NgayKhamBenh));
            Command.Parameters.Add(new MDB.MDBParameter("BacSyLamBenhAn", BenhAnUngBuou.BacSyLamBenhAn));
            Command.Parameters.Add(new MDB.MDBParameter("QuaTrinhBenhLyVaDienBien", BenhAnUngBuou.QuaTrinhBenhLyVaDienBien));
            Command.Parameters.Add(new MDB.MDBParameter("TomTatKetQuaXetNghiem", BenhAnUngBuou.TomTatKetQuaXetNghiem));
            Command.Parameters.Add(new MDB.MDBParameter("PhuongPhapDieuTri", BenhAnUngBuou.PhuongPhapDieuTri));
            Command.Parameters.Add(new MDB.MDBParameter("TinhTrangNguoiBenhRaVien", BenhAnUngBuou.TinhTrangNguoiBenhRaVien));
            Command.Parameters.Add(new MDB.MDBParameter("HuongDieuTriVaCacCheDoTiepTheo", BenhAnUngBuou.HuongDieuTriVaCacCheDoTiepTheo));
            Command.Parameters.Add(new MDB.MDBParameter("NguoiNhanHoSo", BenhAnUngBuou.NguoiNhanHoSo));
            Command.Parameters.Add(new MDB.MDBParameter("NguoiGiaoHoSo", BenhAnUngBuou.NguoiGiaoHoSo));
            Command.Parameters.Add(new MDB.MDBParameter("NgayTongKet", BenhAnUngBuou.NgayTongKet));
            Command.Parameters.Add(new MDB.MDBParameter("BacSyDieuTri", BenhAnUngBuou.BacSyDieuTri));
            Command.Parameters.Add(new MDB.MDBParameter("DiUng", BenhAnUngBuou.DacDiemLienQuanBenh.DiUng == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("DiUng_Text", BenhAnUngBuou.DacDiemLienQuanBenh.DiUng_Text));
            Command.Parameters.Add(new MDB.MDBParameter("MaTuy", BenhAnUngBuou.DacDiemLienQuanBenh.MaTuy == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("MaTuy_Text", BenhAnUngBuou.DacDiemLienQuanBenh.MaTuy_Text));
            Command.Parameters.Add(new MDB.MDBParameter("RuouBia", BenhAnUngBuou.DacDiemLienQuanBenh.RuouBia == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("RuouBia_Text", BenhAnUngBuou.DacDiemLienQuanBenh.RuouBia_Text));
            Command.Parameters.Add(new MDB.MDBParameter("ThuocLa", BenhAnUngBuou.DacDiemLienQuanBenh.ThuocLa == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("ThuocLa_Text", BenhAnUngBuou.DacDiemLienQuanBenh.ThuocLa_Text));
            Command.Parameters.Add(new MDB.MDBParameter("ThuocLao", BenhAnUngBuou.DacDiemLienQuanBenh.ThuocLao == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("ThuocLao_Text", BenhAnUngBuou.DacDiemLienQuanBenh.ThuocLao_Text));
            Command.Parameters.Add(new MDB.MDBParameter("Khac_DacDiemLienQuanBenh", BenhAnUngBuou.DacDiemLienQuanBenh.Khac_DacDiemLienQuanBenh == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("Khac_DacDiemLienQuanBenh_Text", BenhAnUngBuou.DacDiemLienQuanBenh.Khac_DacDiemLienQuanBenh_Text));
            Command.Parameters.Add(new MDB.MDBParameter("BoPhanTonThuong", BenhAnUngBuou.BoPhanTonThuong));
            Command.Parameters.Add(new MDB.MDBParameter("BoPhanTonThuongHinhAnh", BenhAnUngBuou.BoPhanTonThuongHinhAnh == null ? "" : BenhAnUngBuou.BoPhanTonThuongHinhAnh.Replace(ERMDatabase.FTPImageString, "")));
            Command.Parameters.Add(new MDB.MDBParameter("BoPhanTonThuongMoTa", BenhAnUngBuou.BoPhanTonThuongMoTa));
            Command.Parameters.Add(new MDB.MDBParameter("BenhChinhT", BenhAnUngBuou.BenhChinhT));
            Command.Parameters.Add(new MDB.MDBParameter("BenhChinhM", BenhAnUngBuou.BenhChinhM));
            Command.Parameters.Add(new MDB.MDBParameter("BenhChinhN", BenhAnUngBuou.BenhChinhN));
            Command.Parameters.Add(new MDB.MDBParameter("XNMau", BenhAnUngBuou.XNMau));
            Command.Parameters.Add(new MDB.MDBParameter("XNTeBao", BenhAnUngBuou.XNTeBao));
            Command.Parameters.Add(new MDB.MDBParameter("XNBLGP", BenhAnUngBuou.XNBLGP));
            Command.Parameters.Add(new MDB.MDBParameter("Xquang", BenhAnUngBuou.Xquang));
            Command.Parameters.Add(new MDB.MDBParameter("SieuAm", BenhAnUngBuou.SieuAm));
            Command.Parameters.Add(new MDB.MDBParameter("XNKhac", BenhAnUngBuou.XNKhac));
            Command.Parameters.Add(new MDB.MDBParameter("DieuTriTrietDe", BenhAnUngBuou.DieuTriTrietDe == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("DieuTriTrieuChung", BenhAnUngBuou.DieuTriTrieuChung == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("TiaXaTienPhauTaiU", BenhAnUngBuou.TiaXaTienPhauTaiU));
            Command.Parameters.Add(new MDB.MDBParameter("TiaXaTienPhauTaiHach", BenhAnUngBuou.TiaXaTienPhauTaiHach));
            Command.Parameters.Add(new MDB.MDBParameter("TiaXaDonThuanTaiU", BenhAnUngBuou.TiaXaDonThuanTaiU));
            Command.Parameters.Add(new MDB.MDBParameter("TiaXaDonThuanTaiHach", BenhAnUngBuou.TiaXaDonThuanTaiHach));
            Command.Parameters.Add(new MDB.MDBParameter("PhauThuat", BenhAnUngBuou.PhauThuat));
            Command.Parameters.Add(new MDB.MDBParameter("TiaXaHauPhauTaiU", BenhAnUngBuou.TiaXaHauPhauTaiU));
            Command.Parameters.Add(new MDB.MDBParameter("TiaXaHauPhauTaiHach", BenhAnUngBuou.TiaXaHauPhauTaiHach));
            Command.Parameters.Add(new MDB.MDBParameter("HoaChat", BenhAnUngBuou.HoaChat));
            Command.Parameters.Add(new MDB.MDBParameter("SoDot", BenhAnUngBuou.SoDot));
            Command.Parameters.Add(new MDB.MDBParameter("DapUng", BenhAnUngBuou.DapUng));
            Command.Parameters.Add(new MDB.MDBParameter("DapUngID", BenhAnUngBuou.DapUngID));
            Command.Parameters.Add(new MDB.MDBParameter("DieuTriKhac", BenhAnUngBuou.DieuTriKhac));
            Command.Parameters.Add(new MDB.MDBParameter("GiaiDoan", BenhAnUngBuou.GiaiDoan));
            Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", BenhAnUngBuou.MaQuanLy));
            int n = Command.ExecuteNonQuery(); // C#
            return n > 0 ? true : false;
        }
        public static bool Delete(MDB.MDBConnection MyConnection, BenhAnUngBuou BenhAnUngBuou)
        {
            string sql = @"DELETE FROM BenhAnUngBuou 
                           WHERE MaQuanLy = :MaQuanLy";
            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
            Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", BenhAnUngBuou.MaQuanLy));

            int n = Command.ExecuteNonQuery(); // C#
            return n > 0 ? true : false;
        }
    }
}
