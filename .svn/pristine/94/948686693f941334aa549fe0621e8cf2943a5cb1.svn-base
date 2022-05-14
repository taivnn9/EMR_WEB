using System;
using System.Data;

namespace EMR_MAIN
{
    public class BenhAnNhiKhoaFunc
    {
        public static void WriteXml(MDB.MDBConnection MyConnection)
        {
            string sql =
                   @"
                  select  a.*,  CTScanner HoSo_CTScanner, SieuAm HoSo_SieuAm, XetNghiem HoSo_XetNghiem,  Khac HoSo_Khac,  Khac_Text HoSo_Khac_Text,  ToanBoHoSo HoSo_ToanBoHoSo, Mach DauSinhTon_Mach,  NhietDo DauSinhTon_NhietDo,  HuyetAp DauSinhTon_HuyetAp,  NhipTho DauSinhTon_NhipTho,  CanNang DauSinhTon_CanNang  
                  from BenhAnNhiKhoa a inner join thongtindieutri b on a.maquanly = b.maquanly
                  where rownum = 1
                    ";
            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
            MDB.MDBDataReader DataReader = Command.ExecuteReader();

            var DataTable = new DataTable { TableName = "BenhAnNhiKhoa" };
            DataTable.Load(DataReader as IDataReader);
            DataTable.WriteXml("rptBenhAnNhiKhoa.xml");
        }
        public static DataSet SelectDataSet(MDB.MDBConnection MyConnection, decimal MaQuanLy)
        {
            string sql =
                    @"
                  select  a.*,f.hovaten BacSyLamBenhAnHoVaTen ,c.hovaten BacSyDieuTriHoVaTen,d.hovaten NguoiGiaoHoSoHoVaTen,e.hovaten NguoiNhanHoSoHoVaTen, b.XQuang HoSo_XQuang,   b.CTScanner HoSo_CTScanner, b.SieuAm HoSo_SieuAm, b.XetNghiem HoSo_XetNghiem,  b.Khac HoSo_Khac,  b.Khac_Text HoSo_Khac_Text,  b.ToanBoHoSo HoSo_ToanBoHoSo, b.Mach DauSinhTon_Mach, b.NhietDo DauSinhTon_NhietDo,  b.HuyetAp DauSinhTon_HuyetAp,  b.NhipTho DauSinhTon_NhipTho,  b.CanNang DauSinhTon_CanNang  , b.ChieuCao DauSinhTon_ChieuCao, b.BMI DauSinhTon_BMI, b.NgayRaVien 
                 from BenhAnNhiKhoa a 
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
        public static BenhAnNhiKhoa Select(MDB.MDBConnection MyConnection, decimal MaQuanLy)
        {
            #region
            string sql =
                      @"select  c.HoVaTenBo, c.HoVaTenMe, c.NgheNghiepBo, c.NgheNghiepMe, c.TrinhDoVanHoaBo, c.TrinhDoVanHoaMe,  a.*  
                        from BenhAnNhiKhoa a left join ThongTinDieuTri b on a.maquanly = b.maquanly left join hanhchinhbenhnhan c on b.MaBenhNhan = c.MaBenhNhan
                        where a.MaQuanLy = :MaQuanLy";
            #endregion
            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
            Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", MaQuanLy));
            MDB.MDBDataReader DataReader = Command.ExecuteReader();
            var value = new BenhAnNhiKhoa();
            value.DacDiemLienQuanBenh = new DacDiemLienQuanBenh();
            while (DataReader.Read())
            {
                value.MaQuanLy = DataReader.GetDecimal("MaQuanLy");
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
                value.DinhDuong = DataReader["DinhDuong"].ToString();
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
                value.ConThuMay = DataReader.GetInt("ConThuMay");
                //value.TienThaiPara = DataReader.GetInt("TienThaiPara");
                value.TienThaiPara = DataReader["TienThaiPara"].ToString();
                value.TinhTrangKhiSinhID = DataReader.GetInt("TinhTrangKhiSinhID");
                value.CanNangLucSinh = DataReader.GetDecimal("CanNangLucSinh_Fix");
                value.DiTatBamSinh_Text = DataReader["DiTatBamSinh_Text"].ToString();
                value.PhatTrienTinhThan = DataReader["PhatTrienTinhThan"].ToString();
                value.PhatTrienVanDong = DataReader["PhatTrienVanDong"].ToString();
                value.CacBenhLyKhac = DataReader["CacBenhLyKhac"].ToString();
                value.NuoiDuongID = DataReader.GetInt("NuoiDuongID");
                value.CaiSuaThang = DataReader.GetInt("CaiSuaThang");
                value.ChamSocID = DataReader["ChamSocID"].ToString() == "1" ? true : false;
                value.BenhKhacDuocTiemChungKhac = DataReader["BenhKhacDuocTiemChungKhac"].ToString();
                value.ChieuCao = DataReader.GetInt("ChieuCao");
                value.VongNguc = DataReader.GetInt("VongNguc");
                value.VongDau = DataReader.GetInt("VongDau");
                value.Lao = DataReader["Lao"].ToString() == "1" ? true : false;
                value.BaiLiet = DataReader["BaiLiet"].ToString() == "1" ? true : false;
                value.Soi = DataReader["Soi"].ToString() == "1" ? true : false;
                value.HoGa = DataReader["HoGa"].ToString() == "1" ? true : false;
                value.UonVan = DataReader["UonVan"].ToString() == "1" ? true : false;
                value.BachHau = DataReader["BachHau"].ToString() == "1" ? true : false;
                value.DiTatBamSinh = DataReader["DiTatBamSinh"].ToString() == "1" ? true : false;
                value.TiemChungKhac = DataReader["TiemChungKhac"].ToString() == "1" ? true : false;
                value.MaSoKyTen = DataReader["masokyten"].ToString();
                value.MaSoKyTen_KB = DataReader["masokyten_kb"].ToString();
                value.MaSoKyTen_TK = DataReader["masokyten_tk"].ToString();
                value.ParaSinh = DataReader["ParaSinh"].ToString();
                
                  if (string.IsNullOrEmpty(value.ParaSinh) && value.TienThaiParaSinh)
                    value.ParaSinh = "1";
                value.ParaSom = DataReader["ParaSom"].ToString();
                if (string.IsNullOrEmpty(value.ParaSom) && value.TienThaiParaSom)
                    value.ParaSom = "1";
                value.ParaSay = DataReader["ParaSay"].ToString();
                if (string.IsNullOrEmpty(value.ParaSay) && value.TienThaiParaSay)
                    value.ParaSay = "1";
                value.ParaSong = DataReader["ParaSong"].ToString();
                if (string.IsNullOrEmpty(value.ParaSong) && value.TienThaiParaSong)
                    value.ParaSong = "1";
                value.HoVaTenBo = DataReader["HoVaTenBo"].ToString();
                value.HoVaTenMe = DataReader["HoVaTenMe"].ToString();
                // Tunght 01-07-2020 Sua loi benh an nhi khoa khong lay duoc ten bo me, nghe nghiep sau khi luu
                try
                {
                    if (XemBenhAn._HanhChinhBenhNhan == null)
                    {
                        XemBenhAn._HanhChinhBenhNhan = new HanhChinhBenhNhan();
                    }
                    if (!String.IsNullOrEmpty(DataReader["HoVaTenBo"].ToString()))
                    {
                        XemBenhAn._HanhChinhBenhNhan.HoVaTenBo = DataReader["HoVaTenBo"].ToString();
                    }
                    if (!String.IsNullOrEmpty(DataReader["HoVaTenMe"].ToString()))
                    {
                        XemBenhAn._HanhChinhBenhNhan.HoVaTenMe = DataReader["HoVaTenMe"].ToString();
                    }
                    if (!String.IsNullOrEmpty(DataReader["NgheNghiepBo"].ToString()))
                    {
                        XemBenhAn._HanhChinhBenhNhan.NgheNghiepBo = DataReader["NgheNghiepBo"].ToString();
                    }
                    if (!String.IsNullOrEmpty(DataReader["NgheNghiepMe"].ToString()))
                    {
                        XemBenhAn._HanhChinhBenhNhan.NgheNghiepMe = DataReader["NgheNghiepMe"].ToString();
                    }
                    if (!String.IsNullOrEmpty(DataReader["TrinhDoVanHoaBo"].ToString()))
                    {
                        XemBenhAn._HanhChinhBenhNhan.TrinhDoVanHoaBo = DataReader["TrinhDoVanHoaBo"].ToString();
                    }
                    if (!String.IsNullOrEmpty(DataReader["TrinhDoVanHoaMe"].ToString()))
                    {
                        XemBenhAn._HanhChinhBenhNhan.TrinhDoVanHoaMe = DataReader["TrinhDoVanHoaMe"].ToString();
                    }
                }
                catch { }
                 
            }

        
            return value;
        }

        public static bool InsertOrUpdate(MDB.MDBConnection MyConnection, BenhAnNhiKhoa BenhAnNhiKhoa)
        {
            string sql =
                      @"select MaQuanLy 
                        from BenhAnNhiKhoa
                        where MaQuanLy = :MaQuanLy";
            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
            Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", BenhAnNhiKhoa.MaQuanLy));
            MDB.MDBDataReader DataReader = Command.ExecuteReader();
            int rowCount = 0;
            while (DataReader.Read()) rowCount++;
            if (rowCount == 1) return Update(MyConnection, BenhAnNhiKhoa);
            sql = @"
                   INSERT INTO BenhAnNhiKhoa (MaQuanLy, LyDoVaoVien, VaoNgayThu, QuaTrinhBenhLy, TienSuBenhBanThan, TienSuBenhGiaDinh, ToanThan, TuanHoan, HoHap, TieuHoa, ThanTietNieuSinhDuc, ThanKinh, CoXuongKhop, TaiMuiHong, RangHamMat, DinhDuong, Mat, Khac_CacCoQuan, CacXetNghiemCanLamSangCanLam, TomTatBenhAn, BenhChinh, BenhKemTheo, PhanBiet, TienLuong, HuongDieuTri, NgayKhamBenh, BacSyLamBenhAn, QuaTrinhBenhLyVaDienBien, TomTatKetQuaXetNghiem, PhuongPhapDieuTri, TinhTrangNguoiBenhRaVien, HuongDieuTriVaCacCheDoTiepTheo, NguoiNhanHoSo, NguoiGiaoHoSo, NgayTongKet, BacSyDieuTri, DiUng, DiUng_Text, MaTuy, MaTuy_Text, RuouBia, RuouBia_Text, ThuocLa, ThuocLa_Text, ThuocLao, ThuocLao_Text, Khac_DacDiemLienQuanBenh, Khac_DacDiemLienQuanBenh_Text,ConThuMay, TienThaiPara, TinhTrangKhiSinhID, CanNangLucSinh_Fix, DiTatBamSinh_Text, PhatTrienTinhThan, PhatTrienVanDong, CacBenhLyKhac, NuoiDuongID, CaiSuaThang, ChamSocID, BenhKhacDuocTiemChungKhac, ChieuCao, VongNguc, VongDau, Lao, BaiLiet, Soi, HoGa, UonVan, BachHau, DiTatBamSinh, TiemChungKhac, ParaSinh, ParaSom, ParaSay, ParaSong, HoVaTenBo, HoVaTenMe)
                   VALUES(:MaQuanLy, :LyDoVaoVien, :VaoNgayThu, :QuaTrinhBenhLy, :TienSuBenhBanThan, :TienSuBenhGiaDinh, :ToanThan, :TuanHoan, :HoHap, :TieuHoa, :ThanTietNieuSinhDuc, :ThanKinh, :CoXuongKhop, :TaiMuiHong, :RangHamMat, :DinhDuong, :Mat, :Khac_CacCoQuan, :CacXetNghiemCanLamSangCanLam, :TomTatBenhAn, :BenhChinh, :BenhKemTheo, :PhanBiet, :TienLuong, :HuongDieuTri, :NgayKhamBenh, :BacSyLamBenhAn, :QuaTrinhBenhLyVaDienBien, :TomTatKetQuaXetNghiem, :PhuongPhapDieuTri, :TinhTrangNguoiBenhRaVien, :HuongDieuTriVaCacCheDoTiepTheo, :NguoiNhanHoSo, :NguoiGiaoHoSo, :NgayTongKet, :BacSyDieuTri, :DiUng, :DiUng_Text, :MaTuy, :MaTuy_Text, :RuouBia, :RuouBia_Text, :ThuocLa, :ThuocLa_Text, :ThuocLao, :ThuocLao_Text, :Khac_DacDiemLienQuanBenh, :Khac_DacDiemLienQuanBenh_Text, :ConThuMay, :TienThaiPara, :TinhTrangKhiSinhID, :CanNangLucSinh_Fix, :DiTatBamSinh_Text, :PhatTrienTinhThan, :PhatTrienVanDong, :CacBenhLyKhac, :NuoiDuongID, :CaiSuaThang, :ChamSocID, :BenhKhacDuocTiemChungKhac, :ChieuCao, :VongNguc, :VongDau, :Lao, :BaiLiet, :Soi, :HoGa, :UonVan, :BachHau, :DiTatBamSinh, :TiemChungKhac, :ParaSinh, :ParaSom, :ParaSay, :ParaSong, :HoVaTenBo, :HoVaTenMe)
                   ";
            Command = new MDB.MDBCommand(sql, MyConnection);
            Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", BenhAnNhiKhoa.MaQuanLy));
            Command.Parameters.Add(new MDB.MDBParameter("LyDoVaoVien", BenhAnNhiKhoa.LyDoVaoVien));
            Command.Parameters.Add(new MDB.MDBParameter("VaoNgayThu", BenhAnNhiKhoa.VaoNgayThu));
            Command.Parameters.Add(new MDB.MDBParameter("QuaTrinhBenhLy", BenhAnNhiKhoa.QuaTrinhBenhLy));
            Command.Parameters.Add(new MDB.MDBParameter("TienSuBenhBanThan", BenhAnNhiKhoa.TienSuBenhBanThan));
            Command.Parameters.Add(new MDB.MDBParameter("TienSuBenhGiaDinh", BenhAnNhiKhoa.TienSuBenhGiaDinh));
            Command.Parameters.Add(new MDB.MDBParameter("ToanThan", BenhAnNhiKhoa.ToanThan));
            Command.Parameters.Add(new MDB.MDBParameter("TuanHoan", BenhAnNhiKhoa.TuanHoan));
            Command.Parameters.Add(new MDB.MDBParameter("HoHap", BenhAnNhiKhoa.HoHap));
            Command.Parameters.Add(new MDB.MDBParameter("TieuHoa", BenhAnNhiKhoa.TieuHoa));
            Command.Parameters.Add(new MDB.MDBParameter("ThanTietNieuSinhDuc", BenhAnNhiKhoa.ThanTietNieuSinhDuc));
            Command.Parameters.Add(new MDB.MDBParameter("ThanKinh", BenhAnNhiKhoa.ThanKinh));
            Command.Parameters.Add(new MDB.MDBParameter("CoXuongKhop", BenhAnNhiKhoa.CoXuongKhop));
            Command.Parameters.Add(new MDB.MDBParameter("TaiMuiHong", BenhAnNhiKhoa.TaiMuiHong));
            Command.Parameters.Add(new MDB.MDBParameter("RangHamMat", BenhAnNhiKhoa.RangHamMat));
            Command.Parameters.Add(new MDB.MDBParameter("DinhDuong", BenhAnNhiKhoa.DinhDuong));
            Command.Parameters.Add(new MDB.MDBParameter("Mat", BenhAnNhiKhoa.Mat));
            Command.Parameters.Add(new MDB.MDBParameter("Khac_CacCoQuan", BenhAnNhiKhoa.Khac_CacCoQuan));
            Command.Parameters.Add(new MDB.MDBParameter("CacXetNghiemCanLamSangCanLam", BenhAnNhiKhoa.CacXetNghiemCanLamSangCanLam));
            Command.Parameters.Add(new MDB.MDBParameter("TomTatBenhAn", BenhAnNhiKhoa.TomTatBenhAn));
            Command.Parameters.Add(new MDB.MDBParameter("BenhChinh", BenhAnNhiKhoa.BenhChinh));
            Command.Parameters.Add(new MDB.MDBParameter("BenhKemTheo", BenhAnNhiKhoa.BenhKemTheo));
            Command.Parameters.Add(new MDB.MDBParameter("PhanBiet", BenhAnNhiKhoa.PhanBiet));
            Command.Parameters.Add(new MDB.MDBParameter("TienLuong", BenhAnNhiKhoa.TienLuong));
            Command.Parameters.Add(new MDB.MDBParameter("HuongDieuTri", BenhAnNhiKhoa.HuongDieuTri));
            Command.Parameters.Add(new MDB.MDBParameter("NgayKhamBenh", BenhAnNhiKhoa.NgayKhamBenh));
            Command.Parameters.Add(new MDB.MDBParameter("BacSyLamBenhAn", BenhAnNhiKhoa.BacSyLamBenhAn));
            Command.Parameters.Add(new MDB.MDBParameter("QuaTrinhBenhLyVaDienBien", BenhAnNhiKhoa.QuaTrinhBenhLyVaDienBien));
            Command.Parameters.Add(new MDB.MDBParameter("TomTatKetQuaXetNghiem", BenhAnNhiKhoa.TomTatKetQuaXetNghiem));
            Command.Parameters.Add(new MDB.MDBParameter("PhuongPhapDieuTri", BenhAnNhiKhoa.PhuongPhapDieuTri));
            Command.Parameters.Add(new MDB.MDBParameter("TinhTrangNguoiBenhRaVien", BenhAnNhiKhoa.TinhTrangNguoiBenhRaVien));
            Command.Parameters.Add(new MDB.MDBParameter("HuongDieuTriVaCacCheDoTiepTheo", BenhAnNhiKhoa.HuongDieuTriVaCacCheDoTiepTheo));
            Command.Parameters.Add(new MDB.MDBParameter("NguoiNhanHoSo", BenhAnNhiKhoa.NguoiNhanHoSo));
            Command.Parameters.Add(new MDB.MDBParameter("NguoiGiaoHoSo", BenhAnNhiKhoa.NguoiGiaoHoSo));
            Command.Parameters.Add(new MDB.MDBParameter("NgayTongKet", BenhAnNhiKhoa.NgayTongKet));
            Command.Parameters.Add(new MDB.MDBParameter("BacSyDieuTri", BenhAnNhiKhoa.BacSyDieuTri));
            Command.Parameters.Add(new MDB.MDBParameter("DiUng", BenhAnNhiKhoa.DacDiemLienQuanBenh.DiUng == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("DiUng_Text", BenhAnNhiKhoa.DacDiemLienQuanBenh.DiUng_Text));
            Command.Parameters.Add(new MDB.MDBParameter("MaTuy", BenhAnNhiKhoa.DacDiemLienQuanBenh.MaTuy == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("MaTuy_Text", BenhAnNhiKhoa.DacDiemLienQuanBenh.MaTuy_Text));
            Command.Parameters.Add(new MDB.MDBParameter("RuouBia", BenhAnNhiKhoa.DacDiemLienQuanBenh.RuouBia == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("RuouBia_Text", BenhAnNhiKhoa.DacDiemLienQuanBenh.RuouBia_Text));
            Command.Parameters.Add(new MDB.MDBParameter("ThuocLa", BenhAnNhiKhoa.DacDiemLienQuanBenh.ThuocLa == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("ThuocLa_Text", BenhAnNhiKhoa.DacDiemLienQuanBenh.ThuocLa_Text));
            Command.Parameters.Add(new MDB.MDBParameter("ThuocLao", BenhAnNhiKhoa.DacDiemLienQuanBenh.ThuocLao == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("ThuocLao_Text", BenhAnNhiKhoa.DacDiemLienQuanBenh.ThuocLao_Text));
            Command.Parameters.Add(new MDB.MDBParameter("Khac_DacDiemLienQuanBenh", BenhAnNhiKhoa.DacDiemLienQuanBenh.Khac_DacDiemLienQuanBenh == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("Khac_DacDiemLienQuanBenh_Text", BenhAnNhiKhoa.DacDiemLienQuanBenh.Khac_DacDiemLienQuanBenh_Text));
            Command.Parameters.Add(new MDB.MDBParameter("ConThuMay", BenhAnNhiKhoa.ConThuMay));
            Command.Parameters.Add(new MDB.MDBParameter("TienThaiPara", BenhAnNhiKhoa.TienThaiPara));
            Command.Parameters.Add(new MDB.MDBParameter("TinhTrangKhiSinhID", BenhAnNhiKhoa.TinhTrangKhiSinhID));
            Command.Parameters.Add(new MDB.MDBParameter("CanNangLucSinh_Fix", BenhAnNhiKhoa.CanNangLucSinh));
            Command.Parameters.Add(new MDB.MDBParameter("DiTatBamSinh_Text", BenhAnNhiKhoa.DiTatBamSinh_Text));
            Command.Parameters.Add(new MDB.MDBParameter("PhatTrienTinhThan", BenhAnNhiKhoa.PhatTrienTinhThan));
            Command.Parameters.Add(new MDB.MDBParameter("PhatTrienVanDong", BenhAnNhiKhoa.PhatTrienVanDong));
            Command.Parameters.Add(new MDB.MDBParameter("CacBenhLyKhac", BenhAnNhiKhoa.CacBenhLyKhac));
            Command.Parameters.Add(new MDB.MDBParameter("NuoiDuongID", BenhAnNhiKhoa.NuoiDuongID));
            Command.Parameters.Add(new MDB.MDBParameter("CaiSuaThang", BenhAnNhiKhoa.CaiSuaThang));
            Command.Parameters.Add(new MDB.MDBParameter("ChamSocID", BenhAnNhiKhoa.ChamSocID == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("BenhKhacDuocTiemChungKhac", BenhAnNhiKhoa.BenhKhacDuocTiemChungKhac));
            Command.Parameters.Add(new MDB.MDBParameter("ChieuCao", BenhAnNhiKhoa.ChieuCao));
            Command.Parameters.Add(new MDB.MDBParameter("VongNguc", BenhAnNhiKhoa.VongNguc));
            Command.Parameters.Add(new MDB.MDBParameter("VongDau", BenhAnNhiKhoa.VongDau));
            Command.Parameters.Add(new MDB.MDBParameter("Lao", BenhAnNhiKhoa.Lao == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("BaiLiet", BenhAnNhiKhoa.BaiLiet == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("Soi", BenhAnNhiKhoa.Soi == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("HoGa", BenhAnNhiKhoa.HoGa == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("UonVan", BenhAnNhiKhoa.UonVan == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("BachHau", BenhAnNhiKhoa.BachHau == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("DiTatBamSinh", BenhAnNhiKhoa.DiTatBamSinh == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("TiemChungKhac", BenhAnNhiKhoa.TiemChungKhac == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("ParaSinh", BenhAnNhiKhoa.ParaSinh));
            Command.Parameters.Add(new MDB.MDBParameter("ParaSom", BenhAnNhiKhoa.ParaSom));
            Command.Parameters.Add(new MDB.MDBParameter("ParaSay", BenhAnNhiKhoa.ParaSay));
            Command.Parameters.Add(new MDB.MDBParameter("ParaSong", BenhAnNhiKhoa.ParaSong));
            Command.Parameters.Add(new MDB.MDBParameter("HoVaTenBo", BenhAnNhiKhoa.HoVaTenBo));
            Command.Parameters.Add(new MDB.MDBParameter("HoVaTenMe", BenhAnNhiKhoa.HoVaTenMe));


            int n = Command.ExecuteNonQuery(); // C#
            return n > 0 ? true : false;
        }
        public static bool Update(MDB.MDBConnection MyConnection, BenhAnNhiKhoa BenhAnNhiKhoa)
        {
            string sql = @"UPDATE BenhAnNhiKhoa SET 
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
                        DinhDuong = :DinhDuong,
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
ConThuMay = :ConThuMay,
TienThaiPara = :TienThaiPara,
TinhTrangKhiSinhID = :TinhTrangKhiSinhID,
CanNangLucSinh_Fix = :CanNangLucSinh_Fix,
DiTatBamSinh_Text = :DiTatBamSinh_Text,
PhatTrienTinhThan = :PhatTrienTinhThan,
PhatTrienVanDong = :PhatTrienVanDong,
CacBenhLyKhac = :CacBenhLyKhac,
NuoiDuongID = :NuoiDuongID,
CaiSuaThang = :CaiSuaThang,
ChamSocID = :ChamSocID,
BenhKhacDuocTiemChungKhac = :BenhKhacDuocTiemChungKhac,
ChieuCao = :ChieuCao,
VongNguc = :VongNguc,
VongDau = :VongDau,
Lao = :Lao,
BaiLiet = :BaiLiet,
Soi = :Soi,
HoGa = :HoGa,
UonVan = :UonVan,
BachHau = :BachHau,
DiTatBamSinh = :DiTatBamSinh,
TiemChungKhac = :TiemChungKhac,
ParaSinh = :ParaSinh,
ParaSom = :ParaSom,
ParaSay = :ParaSay,
ParaSong = :ParaSong,
HoVaTenBo = :HoVaTenBo,
HoVaTenMe = :HoVaTenMe
                        WHERE MaQuanLy = :MaQuanLy";
            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
            Command.Parameters.Add(new MDB.MDBParameter("LyDoVaoVien", BenhAnNhiKhoa.LyDoVaoVien));
            Command.Parameters.Add(new MDB.MDBParameter("VaoNgayThu", BenhAnNhiKhoa.VaoNgayThu));
            Command.Parameters.Add(new MDB.MDBParameter("QuaTrinhBenhLy", BenhAnNhiKhoa.QuaTrinhBenhLy));
            Command.Parameters.Add(new MDB.MDBParameter("TienSuBenhBanThan", BenhAnNhiKhoa.TienSuBenhBanThan));
            Command.Parameters.Add(new MDB.MDBParameter("TienSuBenhGiaDinh", BenhAnNhiKhoa.TienSuBenhGiaDinh));
            Command.Parameters.Add(new MDB.MDBParameter("ToanThan", BenhAnNhiKhoa.ToanThan));
            Command.Parameters.Add(new MDB.MDBParameter("TuanHoan", BenhAnNhiKhoa.TuanHoan));
            Command.Parameters.Add(new MDB.MDBParameter("HoHap", BenhAnNhiKhoa.HoHap));
            Command.Parameters.Add(new MDB.MDBParameter("TieuHoa", BenhAnNhiKhoa.TieuHoa));
            Command.Parameters.Add(new MDB.MDBParameter("ThanTietNieuSinhDuc", BenhAnNhiKhoa.ThanTietNieuSinhDuc));
            Command.Parameters.Add(new MDB.MDBParameter("ThanKinh", BenhAnNhiKhoa.ThanKinh));
            Command.Parameters.Add(new MDB.MDBParameter("CoXuongKhop", BenhAnNhiKhoa.CoXuongKhop));
            Command.Parameters.Add(new MDB.MDBParameter("TaiMuiHong", BenhAnNhiKhoa.TaiMuiHong));
            Command.Parameters.Add(new MDB.MDBParameter("RangHamMat", BenhAnNhiKhoa.RangHamMat));
            Command.Parameters.Add(new MDB.MDBParameter("DinhDuong", BenhAnNhiKhoa.DinhDuong));
            Command.Parameters.Add(new MDB.MDBParameter("Mat", BenhAnNhiKhoa.Mat));
            Command.Parameters.Add(new MDB.MDBParameter("Khac_CacCoQuan", BenhAnNhiKhoa.Khac_CacCoQuan));
            Command.Parameters.Add(new MDB.MDBParameter("CacXetNghiemCanLamSangCanLam", BenhAnNhiKhoa.CacXetNghiemCanLamSangCanLam));
            Command.Parameters.Add(new MDB.MDBParameter("TomTatBenhAn", BenhAnNhiKhoa.TomTatBenhAn));
            Command.Parameters.Add(new MDB.MDBParameter("BenhChinh", BenhAnNhiKhoa.BenhChinh));
            Command.Parameters.Add(new MDB.MDBParameter("BenhKemTheo", BenhAnNhiKhoa.BenhKemTheo));
            Command.Parameters.Add(new MDB.MDBParameter("PhanBiet", BenhAnNhiKhoa.PhanBiet));
            Command.Parameters.Add(new MDB.MDBParameter("TienLuong", BenhAnNhiKhoa.TienLuong));
            Command.Parameters.Add(new MDB.MDBParameter("HuongDieuTri", BenhAnNhiKhoa.HuongDieuTri));
            Command.Parameters.Add(new MDB.MDBParameter("NgayKhamBenh", BenhAnNhiKhoa.NgayKhamBenh));
            Command.Parameters.Add(new MDB.MDBParameter("BacSyLamBenhAn", BenhAnNhiKhoa.BacSyLamBenhAn));
            Command.Parameters.Add(new MDB.MDBParameter("QuaTrinhBenhLyVaDienBien", BenhAnNhiKhoa.QuaTrinhBenhLyVaDienBien));
            Command.Parameters.Add(new MDB.MDBParameter("TomTatKetQuaXetNghiem", BenhAnNhiKhoa.TomTatKetQuaXetNghiem));
            Command.Parameters.Add(new MDB.MDBParameter("PhuongPhapDieuTri", BenhAnNhiKhoa.PhuongPhapDieuTri));
            Command.Parameters.Add(new MDB.MDBParameter("TinhTrangNguoiBenhRaVien", BenhAnNhiKhoa.TinhTrangNguoiBenhRaVien));
            Command.Parameters.Add(new MDB.MDBParameter("HuongDieuTriVaCacCheDoTiepTheo", BenhAnNhiKhoa.HuongDieuTriVaCacCheDoTiepTheo));
            Command.Parameters.Add(new MDB.MDBParameter("NguoiNhanHoSo", BenhAnNhiKhoa.NguoiNhanHoSo));
            Command.Parameters.Add(new MDB.MDBParameter("NguoiGiaoHoSo", BenhAnNhiKhoa.NguoiGiaoHoSo));
            Command.Parameters.Add(new MDB.MDBParameter("NgayTongKet", BenhAnNhiKhoa.NgayTongKet));
            Command.Parameters.Add(new MDB.MDBParameter("BacSyDieuTri", BenhAnNhiKhoa.BacSyDieuTri));
            Command.Parameters.Add(new MDB.MDBParameter("DiUng", BenhAnNhiKhoa.DacDiemLienQuanBenh.DiUng == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("DiUng_Text", BenhAnNhiKhoa.DacDiemLienQuanBenh.DiUng_Text));
            Command.Parameters.Add(new MDB.MDBParameter("MaTuy", BenhAnNhiKhoa.DacDiemLienQuanBenh.MaTuy == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("MaTuy_Text", BenhAnNhiKhoa.DacDiemLienQuanBenh.MaTuy_Text));
            Command.Parameters.Add(new MDB.MDBParameter("RuouBia", BenhAnNhiKhoa.DacDiemLienQuanBenh.RuouBia == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("RuouBia_Text", BenhAnNhiKhoa.DacDiemLienQuanBenh.RuouBia_Text));
            Command.Parameters.Add(new MDB.MDBParameter("ThuocLa", BenhAnNhiKhoa.DacDiemLienQuanBenh.ThuocLa == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("ThuocLa_Text", BenhAnNhiKhoa.DacDiemLienQuanBenh.ThuocLa_Text));
            Command.Parameters.Add(new MDB.MDBParameter("ThuocLao", BenhAnNhiKhoa.DacDiemLienQuanBenh.ThuocLao == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("ThuocLao_Text", BenhAnNhiKhoa.DacDiemLienQuanBenh.ThuocLao_Text));
            Command.Parameters.Add(new MDB.MDBParameter("Khac_DacDiemLienQuanBenh", BenhAnNhiKhoa.DacDiemLienQuanBenh.Khac_DacDiemLienQuanBenh == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("Khac_DacDiemLienQuanBenh_Text", BenhAnNhiKhoa.DacDiemLienQuanBenh.Khac_DacDiemLienQuanBenh_Text));
            Command.Parameters.Add(new MDB.MDBParameter("ConThuMay", BenhAnNhiKhoa.ConThuMay));
            Command.Parameters.Add(new MDB.MDBParameter("TienThaiPara", BenhAnNhiKhoa.TienThaiPara));
            Command.Parameters.Add(new MDB.MDBParameter("TinhTrangKhiSinhID", BenhAnNhiKhoa.TinhTrangKhiSinhID));
            Command.Parameters.Add(new MDB.MDBParameter("CanNangLucSinh_Fix", BenhAnNhiKhoa.CanNangLucSinh));
            Command.Parameters.Add(new MDB.MDBParameter("DiTatBamSinh_Text", BenhAnNhiKhoa.DiTatBamSinh_Text));
            Command.Parameters.Add(new MDB.MDBParameter("PhatTrienTinhThan", BenhAnNhiKhoa.PhatTrienTinhThan));
            Command.Parameters.Add(new MDB.MDBParameter("PhatTrienVanDong", BenhAnNhiKhoa.PhatTrienVanDong));
            Command.Parameters.Add(new MDB.MDBParameter("CacBenhLyKhac", BenhAnNhiKhoa.CacBenhLyKhac));
            Command.Parameters.Add(new MDB.MDBParameter("NuoiDuongID", BenhAnNhiKhoa.NuoiDuongID));
            Command.Parameters.Add(new MDB.MDBParameter("CaiSuaThang", BenhAnNhiKhoa.CaiSuaThang));
            Command.Parameters.Add(new MDB.MDBParameter("ChamSocID", BenhAnNhiKhoa.ChamSocID == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("BenhKhacDuocTiemChungKhac", BenhAnNhiKhoa.BenhKhacDuocTiemChungKhac));
            Command.Parameters.Add(new MDB.MDBParameter("ChieuCao", BenhAnNhiKhoa.ChieuCao));
            Command.Parameters.Add(new MDB.MDBParameter("VongNguc", BenhAnNhiKhoa.VongNguc));
            Command.Parameters.Add(new MDB.MDBParameter("VongDau", BenhAnNhiKhoa.VongDau));
            Command.Parameters.Add(new MDB.MDBParameter("Lao", BenhAnNhiKhoa.Lao == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("BaiLiet", BenhAnNhiKhoa.BaiLiet == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("Soi", BenhAnNhiKhoa.Soi == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("HoGa", BenhAnNhiKhoa.HoGa == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("UonVan", BenhAnNhiKhoa.UonVan == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("BachHau", BenhAnNhiKhoa.BachHau == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("DiTatBamSinh", BenhAnNhiKhoa.DiTatBamSinh == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("TiemChungKhac", BenhAnNhiKhoa.TiemChungKhac == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("ParaSinh", BenhAnNhiKhoa.ParaSinh));
            Command.Parameters.Add(new MDB.MDBParameter("ParaSom", BenhAnNhiKhoa.ParaSom));
            Command.Parameters.Add(new MDB.MDBParameter("ParaSay", BenhAnNhiKhoa.ParaSay));
            Command.Parameters.Add(new MDB.MDBParameter("ParaSong", BenhAnNhiKhoa.ParaSong));
            Command.Parameters.Add(new MDB.MDBParameter("HoVaTenBo", BenhAnNhiKhoa.HoVaTenBo));
            Command.Parameters.Add(new MDB.MDBParameter("HoVaTenMe", BenhAnNhiKhoa.HoVaTenMe));

            Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", BenhAnNhiKhoa.MaQuanLy));
            int n = Command.ExecuteNonQuery(); // C#
            return n > 0 ? true : false;
        }
        public static bool Delete(MDB.MDBConnection MyConnection, BenhAnNhiKhoa BenhAnNhiKhoa)
        {
            string sql = @"DELETE FROM BenhAnNhiKhoa 
                           WHERE MaQuanLy = :MaQuanLy";
            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
            Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", BenhAnNhiKhoa.MaQuanLy));

            int n = Command.ExecuteNonQuery(); // C#
            return n > 0 ? true : false;
        }
    }
}
