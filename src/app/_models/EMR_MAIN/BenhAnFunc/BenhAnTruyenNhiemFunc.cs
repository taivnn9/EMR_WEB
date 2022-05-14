using System.Data;

namespace EMR_MAIN
{
    public class BenhAnTruyenNhiemFunc
    {
        public static void WriteXml(MDB.MDBConnection MyConnection)
        {
            string sql =
                   @"
                  select  a.*,  CTScanner HoSo_CTScanner, SieuAm HoSo_SieuAm, XetNghiem HoSo_XetNghiem,  Khac HoSo_Khac,  Khac_Text HoSo_Khac_Text,  ToanBoHoSo HoSo_ToanBoHoSo, Mach DauSinhTon_Mach,  NhietDo DauSinhTon_NhietDo,  HuyetAp DauSinhTon_HuyetAp,  NhipTho DauSinhTon_NhipTho,  CanNang DauSinhTon_CanNang  
                  from BenhAnTruyenNhiem a inner join thongtindieutri b on a.maquanly = b.maquanly
                  where rownum = 1
                    ";
            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
            MDB.MDBDataReader DataReader = Command.ExecuteReader();

            var DataTable = new DataTable { TableName = "BenhAnTruyenNhiem" };
            DataTable.Load(DataReader as IDataReader);
            DataTable.WriteXml("rptBenhAnTruyenNhiem.xml");
        }
        public static DataSet SelectDataSet(MDB.MDBConnection MyConnection, decimal MaQuanLy)
        {
            string sql =
                  @"
                  select  a.*,f.hovaten BacSyLamBenhAnHoVaTen ,c.hovaten BacSyDieuTriHoVaTen,d.hovaten NguoiGiaoHoSoHoVaTen,e.hovaten NguoiNhanHoSoHoVaTen, b.XQuang HoSo_XQuang,   b.CTScanner HoSo_CTScanner, b.SieuAm HoSo_SieuAm, b.XetNghiem HoSo_XetNghiem,  b.Khac HoSo_Khac,  b.Khac_Text HoSo_Khac_Text,  b.ToanBoHoSo HoSo_ToanBoHoSo, b.Mach DauSinhTon_Mach, b.NhietDo DauSinhTon_NhietDo,  b.HuyetAp DauSinhTon_HuyetAp,  b.NhipTho DauSinhTon_NhipTho,  b.CanNang DauSinhTon_CanNang  , b.ChieuCao DauSinhTon_ChieuCao, b.BMI DauSinhTon_BMI, b.NgayRaVien 
                 from BenhAnTruyenNhiem a 
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
        public static BenhAnTruyenNhiem Select(MDB.MDBConnection MyConnection, decimal MaQuanLy)
        {
            #region
            string sql =
                      @"select * 
                        from BenhAnTruyenNhiem a
                        where MaQuanLy = :MaQuanLy";
            #endregion
            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
            Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", MaQuanLy));
            MDB.MDBDataReader DataReader = Command.ExecuteReader();
            var value = new BenhAnTruyenNhiem();
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
                value.DichTe = DataReader["DichTe"].ToString();
                value.BenhCapTinhDangLuuHanh = DataReader["BenhCapTinhDangLuuHanh"].ToString();
                value.DaNoiONoiNao = DataReader["DaNoiONoiNao"].ToString();
                value.ThoiGianSongONoiPhatHienBenh = DataReader["ThoiGianSongONoiPhatHienBenh"].ToString();
                value.MoiSinh = DataReader["MoiSinh"].ToString();
                value.MaSoKyTen = DataReader["masokyten"].ToString();
            }
            return value;
        }

        public static bool InsertOrUpdate(MDB.MDBConnection MyConnection, BenhAnTruyenNhiem BenhAnTruyenNhiem)
        {
            string sql =
                      @"select MaQuanLy 
                        from BenhAnTruyenNhiem
                        where MaQuanLy = :MaQuanLy";
            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
            Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", BenhAnTruyenNhiem.MaQuanLy));
            MDB.MDBDataReader DataReader = Command.ExecuteReader();
            int rowCount = 0;
            while (DataReader.Read()) rowCount++;
            if (rowCount == 1) return Update(MyConnection, BenhAnTruyenNhiem);
            sql = @"
                   INSERT INTO BenhAnTruyenNhiem (MaQuanLy, LyDoVaoVien, VaoNgayThu, QuaTrinhBenhLy, TienSuBenhBanThan, TienSuBenhGiaDinh, ToanThan, TuanHoan, HoHap, TieuHoa, ThanTietNieuSinhDuc, ThanKinh, CoXuongKhop, TaiMuiHong, RangHamMat, Mat, Khac_CacCoQuan, CacXetNghiemCanLamSangCanLam, TomTatBenhAn, BenhChinh, BenhKemTheo, PhanBiet, TienLuong, HuongDieuTri, NgayKhamBenh, BacSyLamBenhAn, QuaTrinhBenhLyVaDienBien, TomTatKetQuaXetNghiem, PhuongPhapDieuTri, TinhTrangNguoiBenhRaVien, HuongDieuTriVaCacCheDoTiepTheo, NguoiNhanHoSo, NguoiGiaoHoSo, NgayTongKet, BacSyDieuTri, DiUng, DiUng_Text, MaTuy, MaTuy_Text, RuouBia, RuouBia_Text, ThuocLa, ThuocLa_Text, ThuocLao, ThuocLao_Text, Khac_DacDiemLienQuanBenh, Khac_DacDiemLienQuanBenh_Text, DichTe, BenhCapTinhDangLuuHanh, DaNoiONoiNao, ThoiGianSongONoiPhatHienBenh, MoiSinh)
                   VALUES(:MaQuanLy, :LyDoVaoVien, :VaoNgayThu, :QuaTrinhBenhLy, :TienSuBenhBanThan, :TienSuBenhGiaDinh, :ToanThan, :TuanHoan, :HoHap, :TieuHoa, :ThanTietNieuSinhDuc, :ThanKinh, :CoXuongKhop, :TaiMuiHong, :RangHamMat, :Mat, :Khac_CacCoQuan, :CacXetNghiemCanLamSangCanLam, :TomTatBenhAn, :BenhChinh, :BenhKemTheo, :PhanBiet, :TienLuong, :HuongDieuTri, :NgayKhamBenh, :BacSyLamBenhAn, :QuaTrinhBenhLyVaDienBien, :TomTatKetQuaXetNghiem, :PhuongPhapDieuTri, :TinhTrangNguoiBenhRaVien, :HuongDieuTriVaCacCheDoTiepTheo, :NguoiNhanHoSo, :NguoiGiaoHoSo, :NgayTongKet, :BacSyDieuTri, :DiUng, :DiUng_Text, :MaTuy, :MaTuy_Text, :RuouBia, :RuouBia_Text, :ThuocLa, :ThuocLa_Text, :ThuocLao, :ThuocLao_Text, :Khac_DacDiemLienQuanBenh, :Khac_DacDiemLienQuanBenh_Text,:DichTe, :BenhCapTinhDangLuuHanh, :DaNoiONoiNao, :ThoiGianSongONoiPhatHienBenh, :MoiSinh)
                   ";
            Command = new MDB.MDBCommand(sql, MyConnection);
            Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", BenhAnTruyenNhiem.MaQuanLy));
            Command.Parameters.Add(new MDB.MDBParameter("LyDoVaoVien", BenhAnTruyenNhiem.LyDoVaoVien));
            Command.Parameters.Add(new MDB.MDBParameter("VaoNgayThu", BenhAnTruyenNhiem.VaoNgayThu));
            Command.Parameters.Add(new MDB.MDBParameter("QuaTrinhBenhLy", BenhAnTruyenNhiem.QuaTrinhBenhLy));
            Command.Parameters.Add(new MDB.MDBParameter("TienSuBenhBanThan", BenhAnTruyenNhiem.TienSuBenhBanThan));
            Command.Parameters.Add(new MDB.MDBParameter("TienSuBenhGiaDinh", BenhAnTruyenNhiem.TienSuBenhGiaDinh));
            Command.Parameters.Add(new MDB.MDBParameter("ToanThan", BenhAnTruyenNhiem.ToanThan));
            Command.Parameters.Add(new MDB.MDBParameter("TuanHoan", BenhAnTruyenNhiem.TuanHoan));
            Command.Parameters.Add(new MDB.MDBParameter("HoHap", BenhAnTruyenNhiem.HoHap));
            Command.Parameters.Add(new MDB.MDBParameter("TieuHoa", BenhAnTruyenNhiem.TieuHoa));
            Command.Parameters.Add(new MDB.MDBParameter("ThanTietNieuSinhDuc", BenhAnTruyenNhiem.ThanTietNieuSinhDuc));
            Command.Parameters.Add(new MDB.MDBParameter("ThanKinh", BenhAnTruyenNhiem.ThanKinh));
            Command.Parameters.Add(new MDB.MDBParameter("CoXuongKhop", BenhAnTruyenNhiem.CoXuongKhop));
            Command.Parameters.Add(new MDB.MDBParameter("TaiMuiHong", BenhAnTruyenNhiem.TaiMuiHong));
            Command.Parameters.Add(new MDB.MDBParameter("RangHamMat", BenhAnTruyenNhiem.RangHamMat));
            Command.Parameters.Add(new MDB.MDBParameter("Mat", BenhAnTruyenNhiem.Mat));
            Command.Parameters.Add(new MDB.MDBParameter("Khac_CacCoQuan", BenhAnTruyenNhiem.Khac_CacCoQuan));
            Command.Parameters.Add(new MDB.MDBParameter("CacXetNghiemCanLamSangCanLam", BenhAnTruyenNhiem.CacXetNghiemCanLamSangCanLam));
            Command.Parameters.Add(new MDB.MDBParameter("TomTatBenhAn", BenhAnTruyenNhiem.TomTatBenhAn));
            Command.Parameters.Add(new MDB.MDBParameter("BenhChinh", BenhAnTruyenNhiem.BenhChinh));
            Command.Parameters.Add(new MDB.MDBParameter("BenhKemTheo", BenhAnTruyenNhiem.BenhKemTheo));
            Command.Parameters.Add(new MDB.MDBParameter("PhanBiet", BenhAnTruyenNhiem.PhanBiet));
            Command.Parameters.Add(new MDB.MDBParameter("TienLuong", BenhAnTruyenNhiem.TienLuong));
            Command.Parameters.Add(new MDB.MDBParameter("HuongDieuTri", BenhAnTruyenNhiem.HuongDieuTri));
            Command.Parameters.Add(new MDB.MDBParameter("NgayKhamBenh", BenhAnTruyenNhiem.NgayKhamBenh));
            Command.Parameters.Add(new MDB.MDBParameter("BacSyLamBenhAn", BenhAnTruyenNhiem.BacSyLamBenhAn));
            Command.Parameters.Add(new MDB.MDBParameter("QuaTrinhBenhLyVaDienBien", BenhAnTruyenNhiem.QuaTrinhBenhLyVaDienBien));
            Command.Parameters.Add(new MDB.MDBParameter("TomTatKetQuaXetNghiem", BenhAnTruyenNhiem.TomTatKetQuaXetNghiem));
            Command.Parameters.Add(new MDB.MDBParameter("PhuongPhapDieuTri", BenhAnTruyenNhiem.PhuongPhapDieuTri));
            Command.Parameters.Add(new MDB.MDBParameter("TinhTrangNguoiBenhRaVien", BenhAnTruyenNhiem.TinhTrangNguoiBenhRaVien));
            Command.Parameters.Add(new MDB.MDBParameter("HuongDieuTriVaCacCheDoTiepTheo", BenhAnTruyenNhiem.HuongDieuTriVaCacCheDoTiepTheo));
            Command.Parameters.Add(new MDB.MDBParameter("NguoiNhanHoSo", BenhAnTruyenNhiem.NguoiNhanHoSo));
            Command.Parameters.Add(new MDB.MDBParameter("NguoiGiaoHoSo", BenhAnTruyenNhiem.NguoiGiaoHoSo));
            Command.Parameters.Add(new MDB.MDBParameter("NgayTongKet", BenhAnTruyenNhiem.NgayTongKet));
            Command.Parameters.Add(new MDB.MDBParameter("BacSyDieuTri", BenhAnTruyenNhiem.BacSyDieuTri));
            Command.Parameters.Add(new MDB.MDBParameter("DiUng", BenhAnTruyenNhiem.DacDiemLienQuanBenh.DiUng == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("DiUng_Text", BenhAnTruyenNhiem.DacDiemLienQuanBenh.DiUng_Text));
            Command.Parameters.Add(new MDB.MDBParameter("MaTuy", BenhAnTruyenNhiem.DacDiemLienQuanBenh.MaTuy == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("MaTuy_Text", BenhAnTruyenNhiem.DacDiemLienQuanBenh.MaTuy_Text));
            Command.Parameters.Add(new MDB.MDBParameter("RuouBia", BenhAnTruyenNhiem.DacDiemLienQuanBenh.RuouBia == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("RuouBia_Text", BenhAnTruyenNhiem.DacDiemLienQuanBenh.RuouBia_Text));
            Command.Parameters.Add(new MDB.MDBParameter("ThuocLa", BenhAnTruyenNhiem.DacDiemLienQuanBenh.ThuocLa == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("ThuocLa_Text", BenhAnTruyenNhiem.DacDiemLienQuanBenh.ThuocLa_Text));
            Command.Parameters.Add(new MDB.MDBParameter("ThuocLao", BenhAnTruyenNhiem.DacDiemLienQuanBenh.ThuocLao == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("ThuocLao_Text", BenhAnTruyenNhiem.DacDiemLienQuanBenh.ThuocLao_Text));
            Command.Parameters.Add(new MDB.MDBParameter("Khac_DacDiemLienQuanBenh", BenhAnTruyenNhiem.DacDiemLienQuanBenh.Khac_DacDiemLienQuanBenh == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("Khac_DacDiemLienQuanBenh_Text", BenhAnTruyenNhiem.DacDiemLienQuanBenh.Khac_DacDiemLienQuanBenh_Text));
            Command.Parameters.Add(new MDB.MDBParameter("DichTe", BenhAnTruyenNhiem.DichTe));
            Command.Parameters.Add(new MDB.MDBParameter("BenhCapTinhDangLuuHanh", BenhAnTruyenNhiem.BenhCapTinhDangLuuHanh));
            Command.Parameters.Add(new MDB.MDBParameter("DaNoiONoiNao", BenhAnTruyenNhiem.DaNoiONoiNao));
            Command.Parameters.Add(new MDB.MDBParameter("ThoiGianSongONoiPhatHienBenh", BenhAnTruyenNhiem.ThoiGianSongONoiPhatHienBenh));
            Command.Parameters.Add(new MDB.MDBParameter("MoiSinh", BenhAnTruyenNhiem.MoiSinh));



            int n = Command.ExecuteNonQuery(); // C#
            return n > 0 ? true : false;
        }
        public static bool Update(MDB.MDBConnection MyConnection, BenhAnTruyenNhiem BenhAnTruyenNhiem)
        {
            string sql = @"UPDATE BenhAnTruyenNhiem SET 
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
DichTe = :DichTe,
BenhCapTinhDangLuuHanh = :BenhCapTinhDangLuuHanh,
DaNoiONoiNao = :DaNoiONoiNao,
ThoiGianSongONoiPhatHienBenh = :ThoiGianSongONoiPhatHienBenh,
MoiSinh = :MoiSinh

                        WHERE MaQuanLy = :MaQuanLy";
            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
            Command.Parameters.Add(new MDB.MDBParameter("LyDoVaoVien", BenhAnTruyenNhiem.LyDoVaoVien));
            Command.Parameters.Add(new MDB.MDBParameter("VaoNgayThu", BenhAnTruyenNhiem.VaoNgayThu));
            Command.Parameters.Add(new MDB.MDBParameter("QuaTrinhBenhLy", BenhAnTruyenNhiem.QuaTrinhBenhLy));
            Command.Parameters.Add(new MDB.MDBParameter("TienSuBenhBanThan", BenhAnTruyenNhiem.TienSuBenhBanThan));
            Command.Parameters.Add(new MDB.MDBParameter("TienSuBenhGiaDinh", BenhAnTruyenNhiem.TienSuBenhGiaDinh));
            Command.Parameters.Add(new MDB.MDBParameter("ToanThan", BenhAnTruyenNhiem.ToanThan));
            Command.Parameters.Add(new MDB.MDBParameter("TuanHoan", BenhAnTruyenNhiem.TuanHoan));
            Command.Parameters.Add(new MDB.MDBParameter("HoHap", BenhAnTruyenNhiem.HoHap));
            Command.Parameters.Add(new MDB.MDBParameter("TieuHoa", BenhAnTruyenNhiem.TieuHoa));
            Command.Parameters.Add(new MDB.MDBParameter("ThanTietNieuSinhDuc", BenhAnTruyenNhiem.ThanTietNieuSinhDuc));
            Command.Parameters.Add(new MDB.MDBParameter("ThanKinh", BenhAnTruyenNhiem.ThanKinh));
            Command.Parameters.Add(new MDB.MDBParameter("CoXuongKhop", BenhAnTruyenNhiem.CoXuongKhop));
            Command.Parameters.Add(new MDB.MDBParameter("TaiMuiHong", BenhAnTruyenNhiem.TaiMuiHong));
            Command.Parameters.Add(new MDB.MDBParameter("RangHamMat", BenhAnTruyenNhiem.RangHamMat));
            Command.Parameters.Add(new MDB.MDBParameter("Mat", BenhAnTruyenNhiem.Mat));
            Command.Parameters.Add(new MDB.MDBParameter("Khac_CacCoQuan", BenhAnTruyenNhiem.Khac_CacCoQuan));
            Command.Parameters.Add(new MDB.MDBParameter("CacXetNghiemCanLamSangCanLam", BenhAnTruyenNhiem.CacXetNghiemCanLamSangCanLam));
            Command.Parameters.Add(new MDB.MDBParameter("TomTatBenhAn", BenhAnTruyenNhiem.TomTatBenhAn));
            Command.Parameters.Add(new MDB.MDBParameter("BenhChinh", BenhAnTruyenNhiem.BenhChinh));
            Command.Parameters.Add(new MDB.MDBParameter("BenhKemTheo", BenhAnTruyenNhiem.BenhKemTheo));
            Command.Parameters.Add(new MDB.MDBParameter("PhanBiet", BenhAnTruyenNhiem.PhanBiet));
            Command.Parameters.Add(new MDB.MDBParameter("TienLuong", BenhAnTruyenNhiem.TienLuong));
            Command.Parameters.Add(new MDB.MDBParameter("HuongDieuTri", BenhAnTruyenNhiem.HuongDieuTri));
            Command.Parameters.Add(new MDB.MDBParameter("NgayKhamBenh", BenhAnTruyenNhiem.NgayKhamBenh));
            Command.Parameters.Add(new MDB.MDBParameter("BacSyLamBenhAn", BenhAnTruyenNhiem.BacSyLamBenhAn));
            Command.Parameters.Add(new MDB.MDBParameter("QuaTrinhBenhLyVaDienBien", BenhAnTruyenNhiem.QuaTrinhBenhLyVaDienBien));
            Command.Parameters.Add(new MDB.MDBParameter("TomTatKetQuaXetNghiem", BenhAnTruyenNhiem.TomTatKetQuaXetNghiem));
            Command.Parameters.Add(new MDB.MDBParameter("PhuongPhapDieuTri", BenhAnTruyenNhiem.PhuongPhapDieuTri));
            Command.Parameters.Add(new MDB.MDBParameter("TinhTrangNguoiBenhRaVien", BenhAnTruyenNhiem.TinhTrangNguoiBenhRaVien));
            Command.Parameters.Add(new MDB.MDBParameter("HuongDieuTriVaCacCheDoTiepTheo", BenhAnTruyenNhiem.HuongDieuTriVaCacCheDoTiepTheo));
            Command.Parameters.Add(new MDB.MDBParameter("NguoiNhanHoSo", BenhAnTruyenNhiem.NguoiNhanHoSo));
            Command.Parameters.Add(new MDB.MDBParameter("NguoiGiaoHoSo", BenhAnTruyenNhiem.NguoiGiaoHoSo));
            Command.Parameters.Add(new MDB.MDBParameter("NgayTongKet", BenhAnTruyenNhiem.NgayTongKet));
            Command.Parameters.Add(new MDB.MDBParameter("BacSyDieuTri", BenhAnTruyenNhiem.BacSyDieuTri));
            Command.Parameters.Add(new MDB.MDBParameter("DiUng", BenhAnTruyenNhiem.DacDiemLienQuanBenh.DiUng == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("DiUng_Text", BenhAnTruyenNhiem.DacDiemLienQuanBenh.DiUng_Text));
            Command.Parameters.Add(new MDB.MDBParameter("MaTuy", BenhAnTruyenNhiem.DacDiemLienQuanBenh.MaTuy == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("MaTuy_Text", BenhAnTruyenNhiem.DacDiemLienQuanBenh.MaTuy_Text));
            Command.Parameters.Add(new MDB.MDBParameter("RuouBia", BenhAnTruyenNhiem.DacDiemLienQuanBenh.RuouBia == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("RuouBia_Text", BenhAnTruyenNhiem.DacDiemLienQuanBenh.RuouBia_Text));
            Command.Parameters.Add(new MDB.MDBParameter("ThuocLa", BenhAnTruyenNhiem.DacDiemLienQuanBenh.ThuocLa == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("ThuocLa_Text", BenhAnTruyenNhiem.DacDiemLienQuanBenh.ThuocLa_Text));
            Command.Parameters.Add(new MDB.MDBParameter("ThuocLao", BenhAnTruyenNhiem.DacDiemLienQuanBenh.ThuocLao == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("ThuocLao_Text", BenhAnTruyenNhiem.DacDiemLienQuanBenh.ThuocLao_Text));
            Command.Parameters.Add(new MDB.MDBParameter("Khac_DacDiemLienQuanBenh", BenhAnTruyenNhiem.DacDiemLienQuanBenh.Khac_DacDiemLienQuanBenh == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("Khac_DacDiemLienQuanBenh_Text", BenhAnTruyenNhiem.DacDiemLienQuanBenh.Khac_DacDiemLienQuanBenh_Text));
            Command.Parameters.Add(new MDB.MDBParameter("DichTe", BenhAnTruyenNhiem.DichTe));
            Command.Parameters.Add(new MDB.MDBParameter("BenhCapTinhDangLuuHanh", BenhAnTruyenNhiem.BenhCapTinhDangLuuHanh));
            Command.Parameters.Add(new MDB.MDBParameter("DaNoiONoiNao", BenhAnTruyenNhiem.DaNoiONoiNao));
            Command.Parameters.Add(new MDB.MDBParameter("ThoiGianSongONoiPhatHienBenh", BenhAnTruyenNhiem.ThoiGianSongONoiPhatHienBenh));
            Command.Parameters.Add(new MDB.MDBParameter("MoiSinh", BenhAnTruyenNhiem.MoiSinh));

            Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", BenhAnTruyenNhiem.MaQuanLy));
            int n = Command.ExecuteNonQuery(); // C#
            return n > 0 ? true : false;
        }
        public static bool Delete(MDB.MDBConnection MyConnection, BenhAnTruyenNhiem BenhAnTruyenNhiem)
        {
            string sql = @"DELETE FROM BenhAnTruyenNhiem 
                           WHERE MaQuanLy = :MaQuanLy";
            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
            Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", BenhAnTruyenNhiem.MaQuanLy));

            int n = Command.ExecuteNonQuery(); // C#
            return n > 0 ? true : false;
        }
    }
}
