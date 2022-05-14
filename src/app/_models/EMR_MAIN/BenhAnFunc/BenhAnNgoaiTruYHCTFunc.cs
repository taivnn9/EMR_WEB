using System.Data;

namespace EMR_MAIN
{
    public class BenhAnNgoaiTruYHCTFunc
    {
        public static void WriteXml(MDB.MDBConnection MyConnection)
        {
            string sql =
                   @"
                  select  a.*,  CTScanner HoSo_CTScanner, SieuAm HoSo_SieuAm, XetNghiem HoSo_XetNghiem,  Khac HoSo_Khac,  Khac_Text HoSo_Khac_Text,  ToanBoHoSo HoSo_ToanBoHoSo, Mach DauSinhTon_Mach,  NhietDo DauSinhTon_NhietDo,  HuyetAp DauSinhTon_HuyetAp,  NhipTho DauSinhTon_NhipTho,  CanNang DauSinhTon_CanNang  
                  from BenhAnNgoaiTruYHCT a inner join thongtindieutri b on a.maquanly = b.maquanly
                  where rownum = 1
                    ";
            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
            MDB.MDBDataReader DataReader = Command.ExecuteReader();

            var DataTable = new DataTable { TableName = "BenhAnNgoaiTruYHCT" };
            DataTable.Load(DataReader as IDataReader);
            try
            {
                DataTable.WriteXml("rptBenhAnNgoaiTruYHCT.xml");
            }
            catch { }
        }
        public static DataSet SelectDataSet(MDB.MDBConnection MyConnection, decimal MaQuanLy)
        {
            string sql =
                    @"
                 select  a.*,f.hovaten BacSyLamBenhAnHoVaTen ,c.hovaten BacSyDieuTriHoVaTen,d.hovaten NguoiGiaoHoSoHoVaTen,e.hovaten NguoiNhanHoSoHoVaTen, b.XQuang HoSo_XQuang,   b.CTScanner HoSo_CTScanner, b.SieuAm HoSo_SieuAm, b.XetNghiem HoSo_XetNghiem,  b.Khac HoSo_Khac,  b.Khac_Text HoSo_Khac_Text,  b.ToanBoHoSo HoSo_ToanBoHoSo, b.Mach DauSinhTon_Mach, b.NhietDo DauSinhTon_NhietDo,  b.HuyetAp DauSinhTon_HuyetAp,  b.NhipTho DauSinhTon_NhipTho,  b.CanNang DauSinhTon_CanNang  , b.ChieuCao DauSinhTon_ChieuCao, b.BMI DauSinhTon_BMI, b.NgayRaVien 
                 from BenhAnNgoaiTruYHCT a 
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
        public static BenhAnNgoaiTruYHCT Select(MDB.MDBConnection MyConnection, decimal MaQuanLy)
        {
            #region
            string sql =
                      @"select * 
                        from BenhAnNgoaiTruYHCT a
                        where MaQuanLy = :MaQuanLy";
            #endregion
            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
            Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", MaQuanLy));
            MDB.MDBDataReader DataReader = Command.ExecuteReader();
            var value = new BenhAnNgoaiTruYHCT();
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
                value.BenhSu = DataReader["BenhSu"].ToString();
                value.CacBoPhan = DataReader["CacBoPhan"].ToString();
                value.TomTatKetQuaCanLamSang = DataReader["TomTatKetQuaCanLamSang"].ToString();
                value.MoTa_VongChan = DataReader["MoTa_VongChan"].ToString();
                value.MoTa_VanChan = DataReader["MoTa_VanChan"].ToString();
                value.MoTa_VaanChan = DataReader["MoTa_VaanChan"].ToString();
                value.MoTa_XucChan = DataReader["MoTa_XucChan"].ToString();
                value.MachTayTrai = DataReader["MachTayTrai"].ToString();
                value.MachTayPhai = DataReader["MachTayPhai"].ToString();
                value.TomTatTuChan = DataReader["TomTatTuChan"].ToString();
                value.BienPhapLuanTri = DataReader["BienPhapLuanTri"].ToString();
                value.BietDanh = DataReader["BietDanh"].ToString();
                value.BatCuong = DataReader["BatCuong"].ToString();
                value.TangPhuKinhLac = DataReader["TangPhuKinhLac"].ToString();
                value.NguyenNhan = DataReader["NguyenNhan"].ToString();
                value.DieuTriYHCT = DataReader["DieuTriYHCT"].ToString() == "1" ? true : false;
                value.PhapDieuTri = DataReader["PhapDieuTri"].ToString();
                value.PhuongThuoc = DataReader["PhuongThuoc"].ToString();
                value.PhuongHuyet = DataReader["PhuongHuyet"].ToString();
                value.DieuTriKetHopVoiYHHD = DataReader["DieuTriKetHopVoiYHHD"].ToString() == "1" ? true : false;
                value.DieuTriKetHopVoiYHHD_Text = DataReader["DieuTriKetHopVoiYHHD_Text"].ToString();
                value.CheDoDinhDuongTaiNha = DataReader["CheDoDinhDuongTaiNha"].ToString();
                value.CheDoHoLyTaiNha = DataReader["CheDoHoLyTaiNha"].ToString();
                value.KetQuaXetNghiemCanLamSang = DataReader["KetQuaXetNghiemCanLamSang"].ToString();
                value.ChanDoanVaoVienTheoYHCT = DataReader["ChanDoanVaoVienTheoYHCT"].ToString();
                value.ChanDoanVaoVienTheoYHHD = DataReader["ChanDoanVaoVienTheoYHHD"].ToString();
                value.PhuongPhapDieuTriTheoYHHD = DataReader["PhuongPhapDieuTriTheoYHHD"].ToString();
                value.PhuongPhapDieuTriTheoYHCT = DataReader["PhuongPhapDieuTriTheoYHCT"].ToString();
                value.ChanDoanRaVienTheoYHCT = DataReader["ChanDoanRaVienTheoYHCT"].ToString();
                value.ChanDoanRaVienTheoYHHD = DataReader["ChanDoanRaVienTheoYHHD"].ToString();
                value.KetQuaDieuTriID = DataReader.GetInt("KetQuaDieuTriID");
                value.TinhTrangNguoiBenhKhiRavien = DataReader["TinhTrangNguoiBenhKhiRavien"].ToString();
                value.ThoiGianDieuTri = DataReader.GetInt("ThoiGianDieuTri");
                value.ThoiGianDieuTriTuNgay = DataReader.GetDate("ThoiGianDieuTriTuNgay");
                value.ThoiGianDieuTriDenNgay = DataReader.GetDate("ThoiGianDieuTriDenNgay");
                value.MaSoKyTen = DataReader["masokyten"].ToString();
                value.MaSoKyTen_KB = DataReader["masokyten_kb"].ToString();
                value.MaSoKyTen_TK = DataReader["masokyten_tk"].ToString();
                // add
                value.MaICD_NoiChuyenDen = DataReader["MaICD_NoiChuyenDen"].ToString();
                value.MICD_BenhChinh = DataReader["MICD_BenhChinh"].ToString();
                value.MICD_BenhKemTheo = DataReader["MICD_BenhKemTheo"].ToString();
                value.KinhMach = DataReader["KinhMach"].ToString();
                value.DinhViBenh = DataReader["DinhViBenh"].ToString();
                value.MICDVaoVienTheoYHHD = DataReader["MICDVaoVienTheoYHHD"].ToString();
                value.CDBenhKemtheoVVYHHD = DataReader["CDBenhKemtheoVVYHHD"].ToString();
                value.MICDBenhKemtheoVVYHHD = DataReader["MICDBenhKemtheoVVYHHD"].ToString();
                value.MICDBenhChinhVVYHCT = DataReader["MICDBenhChinhVVYHCT"].ToString();
                value.CDBenhKemtheoVVYHCT = DataReader["CDBenhKemtheoVVYHCT"].ToString();
                value.MICDBenhKemTheoVVYHCT = DataReader["MICDBenhKemTheoVVYHCT"].ToString();
                value.MICDRaVienTheoYHHD = DataReader["MICDRaVienTheoYHHD"].ToString();
                value.CDBenhKemTheoRVYHHD = DataReader["CDBenhKemTheoRVYHHD"].ToString();
                value.MICDBenhChinhRVYHCT = DataReader["MICDBenhChinhRVYHCT"].ToString();
                value.CDBenhKemTheoRaVienTheoYHCT = DataReader["CDBenhKemTheoRaVienTheoYHCT"].ToString();
                value.MICDbenhKemTheoRaVienYHCT = DataReader["MICDbenhKemTheoRaVienYHCT"].ToString();
                value.MotaTienSuBanThan = DataReader["MotaTienSuBanThan"].ToString();
                value.MICDbenhKemTheoRaVienYHHD = DataReader["MICDbenhKemTheoRaVienYHHD"].ToString();
                value.MaICD_BenhKemTheo_RV_YHCT = DataReader["MaICD_BenhKemTheo_RV_YHCT"].ToString();
                value.MaICD_NoiChuyenDen_YHCT = DataReader["MaICD_NoiChuyenDen_YHCT"].ToString();
                value.ChanDoan_KKB_CapCuu_YHCT = DataReader["ChanDoan_KKB_CapCuu_YHCT"].ToString();
                value.MaICD_KKB_CapCuu_YHCT = DataReader["MaICD_KKB_CapCuu_YHCT"].ToString();
                value.MaICD_BenhChinh_YHCT = DataReader["MaICD_BenhChinh_YHCT"].ToString();
                value.BenhKemTheo_YHCT = DataReader["BenhKemTheo_YHCT"].ToString();
                value.MaICD_BenhKemTheo_YHCT = DataReader["MaICD_BenhKemTheo_YHCT"].ToString();
                value.MaICD_BenhChinh_RV_YHCT = DataReader["MaICD_BenhChinh_RV_YHCT"].ToString();
                value.BenhKemTheo_RV_YHCT = DataReader["BenhKemTheo_RV_YHCT"].ToString();
                value.MaICD_BenhKemTheo_YHHD = DataReader["MaICD_BenhKemTheo_YHHD"].ToString();
                value.TRUCTIEPVAO = DataReader["TRUCTIEPVAO"].ToString() == "1" ? true : false;
                value.TaiBien_YHCT = DataReader["TaiBien_YHCT"].ToString() == "1" ? true : false;
                value.BienChung_YHCT = DataReader["BienChung_YHCT"].ToString() == "1" ? true : false;
                value.ThuThuat_YHCT = DataReader["ThuThuat_YHCT"].ToString() == "1" ? true : false;
            }
            return value;
        }

        public static bool InsertOrUpdate(MDB.MDBConnection MyConnection, BenhAnNgoaiTruYHCT BenhAnNgoaiTruYHCT)
        {
            string sql =
                      @"select MaQuanLy 
                        from BenhAnNgoaiTruYHCT
                        where MaQuanLy = :MaQuanLy";
            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
            Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", BenhAnNgoaiTruYHCT.MaQuanLy));
            MDB.MDBDataReader DataReader = Command.ExecuteReader();
            int rowCount = 0;
            while (DataReader.Read()) rowCount++;
            if (rowCount == 1) return Update(MyConnection, BenhAnNgoaiTruYHCT);
            sql = @"
               INSERT INTO BenhAnNgoaiTruYHCT (MaQuanLy, LyDoVaoVien, VaoNgayThu, QuaTrinhBenhLy, TienSuBenhBanThan, TienSuBenhGiaDinh, ToanThan, TuanHoan, HoHap, TieuHoa, ThanTietNieuSinhDuc, ThanKinh, CoXuongKhop, TaiMuiHong, RangHamMat, Mat, Khac_CacCoQuan, CacXetNghiemCanLamSangCanLam, TomTatBenhAn, BenhChinh, BenhKemTheo, PhanBiet, TienLuong, HuongDieuTri, NgayKhamBenh, BacSyLamBenhAn, QuaTrinhBenhLyVaDienBien, TomTatKetQuaXetNghiem, PhuongPhapDieuTri, TinhTrangNguoiBenhRaVien, HuongDieuTriVaCacCheDoTiepTheo, NguoiNhanHoSo, NguoiGiaoHoSo, NgayTongKet, BacSyDieuTri, DiUng, DiUng_Text, MaTuy, MaTuy_Text, RuouBia, RuouBia_Text, ThuocLa, ThuocLa_Text, ThuocLao, ThuocLao_Text, Khac_DacDiemLienQuanBenh, Khac_DacDiemLienQuanBenh_Text, BenhSu, CacBoPhan, TomTatKetQuaCanLamSang, MoTa_VongChan, MoTa_VanChan, MoTa_VaanChan, MoTa_XucChan, MachTayTrai, MachTayPhai, TomTatTuChan, BienPhapLuanTri, BietDanh, BatCuong, TangPhuKinhLac, NguyenNhan, DieuTriYHCT, PhapDieuTri, PhuongThuoc, PhuongHuyet, DieuTriKetHopVoiYHHD, DieuTriKetHopVoiYHHD_Text, CheDoDinhDuongTaiNha, CheDoHoLyTaiNha, KetQuaXetNghiemCanLamSang, ChanDoanVaoVienTheoYHCT, ChanDoanVaoVienTheoYHHD, PhuongPhapDieuTriTheoYHHD, PhuongPhapDieuTriTheoYHCT, ChanDoanRaVienTheoYHCT, ChanDoanRaVienTheoYHHD, KetQuaDieuTriID, TinhTrangNguoiBenhKhiRavien, ThoiGianDieuTri, ThoiGianDieuTriTuNgay, ThoiGianDieuTriDenNgay,MaICD_NoiChuyenDen,MICD_BenhChinh,MICD_BenhKemTheo,KinhMach,DinhViBenh,MICDVaoVienTheoYHHD,CDBenhKemtheoVVYHHD,MICDBenhKemtheoVVYHHD,MICDBenhChinhVVYHCT,CDBenhKemtheoVVYHCT,MICDBenhKemTheoVVYHCT,MICDRaVienTheoYHHD,CDBenhKemTheoRVYHHD,MICDBenhChinhRVYHCT,CDBenhKemTheoRaVienTheoYHCT,MICDbenhKemTheoRaVienYHCT,MotaTienSuBanThan,MICDbenhKemTheoRaVienYHHD,MaICD_BenhKemTheo_RV_YHCT,MaICD_NoiChuyenDen_YHCT,ChanDoan_KKB_CapCuu_YHCT,MaICD_KKB_CapCuu_YHCT,MaICD_BenhChinh_YHCT,BenhKemTheo_YHCT,MaICD_BenhKemTheo_YHCT,MaICD_BenhChinh_RV_YHCT,BenhKemTheo_RV_YHCT,MaICD_BenhKemTheo_YHHD,TRUCTIEPVAO,TaiBien_YHCT,BienChung_YHCT,ThuThuat_YHCT)
 VALUES(:MaQuanLy, :LyDoVaoVien, :VaoNgayThu, :QuaTrinhBenhLy, :TienSuBenhBanThan, :TienSuBenhGiaDinh, :ToanThan, :TuanHoan, :HoHap, :TieuHoa, :ThanTietNieuSinhDuc, :ThanKinh, :CoXuongKhop, :TaiMuiHong, :RangHamMat, :Mat, :Khac_CacCoQuan, :CacXetNghiemCanLamSangCanLam, :TomTatBenhAn, :BenhChinh, :BenhKemTheo, :PhanBiet, :TienLuong, :HuongDieuTri, :NgayKhamBenh, :BacSyLamBenhAn, :QuaTrinhBenhLyVaDienBien, :TomTatKetQuaXetNghiem, :PhuongPhapDieuTri, :TinhTrangNguoiBenhRaVien, :HuongDieuTriVaCacCheDoTiepTheo, :NguoiNhanHoSo, :NguoiGiaoHoSo, :NgayTongKet, :BacSyDieuTri, :DiUng, :DiUng_Text, :MaTuy, :MaTuy_Text, :RuouBia, :RuouBia_Text, :ThuocLa, :ThuocLa_Text, :ThuocLao, :ThuocLao_Text, :Khac_DacDiemLienQuanBenh, :Khac_DacDiemLienQuanBenh_Text, :BenhSu, :CacBoPhan, :TomTatKetQuaCanLamSang, :MoTa_VongChan, :MoTa_VanChan, :MoTa_VaanChan, :MoTa_XucChan, :MachTayTrai, :MachTayPhai, :TomTatTuChan, :BienPhapLuanTri, :BietDanh, :BatCuong, :TangPhuKinhLac, :NguyenNhan, :DieuTriYHCT, :PhapDieuTri, :PhuongThuoc, :PhuongHuyet, :DieuTriKetHopVoiYHHD, :DieuTriKetHopVoiYHHD_Text, :CheDoDinhDuongTaiNha, :CheDoHoLyTaiNha, :KetQuaXetNghiemCanLamSang, :ChanDoanVaoVienTheoYHCT, :ChanDoanVaoVienTheoYHHD, :PhuongPhapDieuTriTheoYHHD, :PhuongPhapDieuTriTheoYHCT, :ChanDoanRaVienTheoYHCT, :ChanDoanRaVienTheoYHHD, :KetQuaDieuTriID, :TinhTrangNguoiBenhKhiRavien, :ThoiGianDieuTri, :ThoiGianDieuTriTuNgay, :ThoiGianDieuTriDenNgay, :MaICD_NoiChuyenDen, :MICD_BenhChinh, :MICD_BenhKemTheo, :KinhMach, :DinhViBenh, :MICDVaoVienTheoYHHD, :CDBenhKemtheoVVYHHD, :MICDBenhKemtheoVVYHHD, :MICDBenhChinhVVYHCT, :CDBenhKemtheoVVYHCT, :MICDBenhKemTheoVVYHCT, :MICDRaVienTheoYHHD, :CDBenhKemTheoRVYHHD, :MICDBenhChinhRVYHCT, :CDBenhKemTheoRaVienTheoYHCT, :MICDbenhKemTheoRaVienYHCT, :MotaTienSuBanThan, :MICDbenhKemTheoRaVienYHHD, :MaICD_BenhKemTheo_RV_YHCT, :MaICD_NoiChuyenDen_YHCT, :ChanDoan_KKB_CapCuu_YHCT, :MaICD_KKB_CapCuu_YHCT, :MaICD_BenhChinh_YHCT, :BenhKemTheo_YHCT, :MaICD_BenhKemTheo_YHCT, :MaICD_BenhChinh_RV_YHCT, :BenhKemTheo_RV_YHCT, :MaICD_BenhKemTheo_YHHD, :TRUCTIEPVAO, :TaiBien_YHCT, :BienChung_YHCT, :ThuThuat_YHCT)             ";
            Command = new MDB.MDBCommand(sql, MyConnection);
            Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", BenhAnNgoaiTruYHCT.MaQuanLy));
            Command.Parameters.Add(new MDB.MDBParameter("LyDoVaoVien", BenhAnNgoaiTruYHCT.LyDoVaoVien));
            Command.Parameters.Add(new MDB.MDBParameter("VaoNgayThu", BenhAnNgoaiTruYHCT.VaoNgayThu));
            Command.Parameters.Add(new MDB.MDBParameter("QuaTrinhBenhLy", BenhAnNgoaiTruYHCT.QuaTrinhBenhLy));
            Command.Parameters.Add(new MDB.MDBParameter("TienSuBenhBanThan", BenhAnNgoaiTruYHCT.TienSuBenhBanThan));
            Command.Parameters.Add(new MDB.MDBParameter("TienSuBenhGiaDinh", BenhAnNgoaiTruYHCT.TienSuBenhGiaDinh));
            Command.Parameters.Add(new MDB.MDBParameter("ToanThan", BenhAnNgoaiTruYHCT.ToanThan));
            Command.Parameters.Add(new MDB.MDBParameter("TuanHoan", BenhAnNgoaiTruYHCT.TuanHoan));
            Command.Parameters.Add(new MDB.MDBParameter("HoHap", BenhAnNgoaiTruYHCT.HoHap));
            Command.Parameters.Add(new MDB.MDBParameter("TieuHoa", BenhAnNgoaiTruYHCT.TieuHoa));
            Command.Parameters.Add(new MDB.MDBParameter("ThanTietNieuSinhDuc", BenhAnNgoaiTruYHCT.ThanTietNieuSinhDuc));
            Command.Parameters.Add(new MDB.MDBParameter("ThanKinh", BenhAnNgoaiTruYHCT.ThanKinh));
            Command.Parameters.Add(new MDB.MDBParameter("CoXuongKhop", BenhAnNgoaiTruYHCT.CoXuongKhop));
            Command.Parameters.Add(new MDB.MDBParameter("TaiMuiHong", BenhAnNgoaiTruYHCT.TaiMuiHong));
            Command.Parameters.Add(new MDB.MDBParameter("RangHamMat", BenhAnNgoaiTruYHCT.RangHamMat));
            Command.Parameters.Add(new MDB.MDBParameter("Mat", BenhAnNgoaiTruYHCT.Mat));
            Command.Parameters.Add(new MDB.MDBParameter("Khac_CacCoQuan", BenhAnNgoaiTruYHCT.Khac_CacCoQuan));
            Command.Parameters.Add(new MDB.MDBParameter("CacXetNghiemCanLamSangCanLam", BenhAnNgoaiTruYHCT.CacXetNghiemCanLamSangCanLam));
            Command.Parameters.Add(new MDB.MDBParameter("TomTatBenhAn", BenhAnNgoaiTruYHCT.TomTatBenhAn));
            Command.Parameters.Add(new MDB.MDBParameter("BenhChinh", BenhAnNgoaiTruYHCT.BenhChinh));
            Command.Parameters.Add(new MDB.MDBParameter("BenhKemTheo", BenhAnNgoaiTruYHCT.BenhKemTheo));
            Command.Parameters.Add(new MDB.MDBParameter("PhanBiet", BenhAnNgoaiTruYHCT.PhanBiet));
            Command.Parameters.Add(new MDB.MDBParameter("TienLuong", BenhAnNgoaiTruYHCT.TienLuong));
            Command.Parameters.Add(new MDB.MDBParameter("HuongDieuTri", BenhAnNgoaiTruYHCT.HuongDieuTri));
            Command.Parameters.Add(new MDB.MDBParameter("NgayKhamBenh", BenhAnNgoaiTruYHCT.NgayKhamBenh));
            Command.Parameters.Add(new MDB.MDBParameter("BacSyLamBenhAn", BenhAnNgoaiTruYHCT.BacSyLamBenhAn));
            Command.Parameters.Add(new MDB.MDBParameter("QuaTrinhBenhLyVaDienBien", BenhAnNgoaiTruYHCT.QuaTrinhBenhLyVaDienBien));
            Command.Parameters.Add(new MDB.MDBParameter("TomTatKetQuaXetNghiem", BenhAnNgoaiTruYHCT.TomTatKetQuaXetNghiem));
            Command.Parameters.Add(new MDB.MDBParameter("PhuongPhapDieuTri", BenhAnNgoaiTruYHCT.PhuongPhapDieuTri));
            Command.Parameters.Add(new MDB.MDBParameter("TinhTrangNguoiBenhRaVien", BenhAnNgoaiTruYHCT.TinhTrangNguoiBenhRaVien));
            Command.Parameters.Add(new MDB.MDBParameter("HuongDieuTriVaCacCheDoTiepTheo", BenhAnNgoaiTruYHCT.HuongDieuTriVaCacCheDoTiepTheo));
            Command.Parameters.Add(new MDB.MDBParameter("NguoiNhanHoSo", BenhAnNgoaiTruYHCT.NguoiNhanHoSo));
            Command.Parameters.Add(new MDB.MDBParameter("NguoiGiaoHoSo", BenhAnNgoaiTruYHCT.NguoiGiaoHoSo));
            Command.Parameters.Add(new MDB.MDBParameter("NgayTongKet", BenhAnNgoaiTruYHCT.NgayTongKet));
            Command.Parameters.Add(new MDB.MDBParameter("BacSyDieuTri", BenhAnNgoaiTruYHCT.BacSyDieuTri));
            Command.Parameters.Add(new MDB.MDBParameter("DiUng", BenhAnNgoaiTruYHCT.DacDiemLienQuanBenh.DiUng == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("DiUng_Text", BenhAnNgoaiTruYHCT.DacDiemLienQuanBenh.DiUng_Text));
            Command.Parameters.Add(new MDB.MDBParameter("MaTuy", BenhAnNgoaiTruYHCT.DacDiemLienQuanBenh.MaTuy == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("MaTuy_Text", BenhAnNgoaiTruYHCT.DacDiemLienQuanBenh.MaTuy_Text));
            Command.Parameters.Add(new MDB.MDBParameter("RuouBia", BenhAnNgoaiTruYHCT.DacDiemLienQuanBenh.RuouBia == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("RuouBia_Text", BenhAnNgoaiTruYHCT.DacDiemLienQuanBenh.RuouBia_Text));
            Command.Parameters.Add(new MDB.MDBParameter("ThuocLa", BenhAnNgoaiTruYHCT.DacDiemLienQuanBenh.ThuocLa == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("ThuocLa_Text", BenhAnNgoaiTruYHCT.DacDiemLienQuanBenh.ThuocLa_Text));
            Command.Parameters.Add(new MDB.MDBParameter("ThuocLao", BenhAnNgoaiTruYHCT.DacDiemLienQuanBenh.ThuocLao == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("ThuocLao_Text", BenhAnNgoaiTruYHCT.DacDiemLienQuanBenh.ThuocLao_Text));
            Command.Parameters.Add(new MDB.MDBParameter("Khac_DacDiemLienQuanBenh", BenhAnNgoaiTruYHCT.DacDiemLienQuanBenh.Khac_DacDiemLienQuanBenh == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("Khac_DacDiemLienQuanBenh_Text", BenhAnNgoaiTruYHCT.DacDiemLienQuanBenh.Khac_DacDiemLienQuanBenh_Text));
            Command.Parameters.Add(new MDB.MDBParameter("BenhSu", BenhAnNgoaiTruYHCT.BenhSu));
            Command.Parameters.Add(new MDB.MDBParameter("CacBoPhan", BenhAnNgoaiTruYHCT.CacBoPhan));
            Command.Parameters.Add(new MDB.MDBParameter("TomTatKetQuaCanLamSang", BenhAnNgoaiTruYHCT.TomTatKetQuaCanLamSang));
            Command.Parameters.Add(new MDB.MDBParameter("MoTa_VongChan", BenhAnNgoaiTruYHCT.MoTa_VongChan));
            Command.Parameters.Add(new MDB.MDBParameter("MoTa_VanChan", BenhAnNgoaiTruYHCT.MoTa_VanChan));
            Command.Parameters.Add(new MDB.MDBParameter("MoTa_VaanChan", BenhAnNgoaiTruYHCT.MoTa_VaanChan));
            Command.Parameters.Add(new MDB.MDBParameter("MoTa_XucChan", BenhAnNgoaiTruYHCT.MoTa_XucChan));
            Command.Parameters.Add(new MDB.MDBParameter("MachTayTrai", BenhAnNgoaiTruYHCT.MachTayTrai));
            Command.Parameters.Add(new MDB.MDBParameter("MachTayPhai", BenhAnNgoaiTruYHCT.MachTayPhai));
            Command.Parameters.Add(new MDB.MDBParameter("TomTatTuChan", BenhAnNgoaiTruYHCT.TomTatTuChan));
            Command.Parameters.Add(new MDB.MDBParameter("BienPhapLuanTri", BenhAnNgoaiTruYHCT.BienPhapLuanTri));
            Command.Parameters.Add(new MDB.MDBParameter("BietDanh", BenhAnNgoaiTruYHCT.BietDanh));
            Command.Parameters.Add(new MDB.MDBParameter("BatCuong", BenhAnNgoaiTruYHCT.BatCuong));
            Command.Parameters.Add(new MDB.MDBParameter("TangPhuKinhLac", BenhAnNgoaiTruYHCT.TangPhuKinhLac));
            Command.Parameters.Add(new MDB.MDBParameter("NguyenNhan", BenhAnNgoaiTruYHCT.NguyenNhan));
            Command.Parameters.Add(new MDB.MDBParameter("DieuTriYHCT", BenhAnNgoaiTruYHCT.DieuTriYHCT == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("PhapDieuTri", BenhAnNgoaiTruYHCT.PhapDieuTri));
            Command.Parameters.Add(new MDB.MDBParameter("PhuongThuoc", BenhAnNgoaiTruYHCT.PhuongThuoc));
            Command.Parameters.Add(new MDB.MDBParameter("PhuongHuyet", BenhAnNgoaiTruYHCT.PhuongHuyet));
            Command.Parameters.Add(new MDB.MDBParameter("DieuTriKetHopVoiYHHD", BenhAnNgoaiTruYHCT.DieuTriKetHopVoiYHHD == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("DieuTriKetHopVoiYHHD_Text", BenhAnNgoaiTruYHCT.DieuTriKetHopVoiYHHD_Text));
            Command.Parameters.Add(new MDB.MDBParameter("CheDoDinhDuongTaiNha", BenhAnNgoaiTruYHCT.CheDoDinhDuongTaiNha));
            Command.Parameters.Add(new MDB.MDBParameter("CheDoHoLyTaiNha", BenhAnNgoaiTruYHCT.CheDoHoLyTaiNha));
            Command.Parameters.Add(new MDB.MDBParameter("KetQuaXetNghiemCanLamSang", BenhAnNgoaiTruYHCT.KetQuaXetNghiemCanLamSang));
            Command.Parameters.Add(new MDB.MDBParameter("ChanDoanVaoVienTheoYHCT", BenhAnNgoaiTruYHCT.ChanDoanVaoVienTheoYHCT));
            Command.Parameters.Add(new MDB.MDBParameter("ChanDoanVaoVienTheoYHHD", BenhAnNgoaiTruYHCT.ChanDoanVaoVienTheoYHHD));
            Command.Parameters.Add(new MDB.MDBParameter("PhuongPhapDieuTriTheoYHHD", BenhAnNgoaiTruYHCT.PhuongPhapDieuTriTheoYHHD));
            Command.Parameters.Add(new MDB.MDBParameter("PhuongPhapDieuTriTheoYHCT", BenhAnNgoaiTruYHCT.PhuongPhapDieuTriTheoYHCT));
            Command.Parameters.Add(new MDB.MDBParameter("ChanDoanRaVienTheoYHCT", BenhAnNgoaiTruYHCT.ChanDoanRaVienTheoYHCT));
            Command.Parameters.Add(new MDB.MDBParameter("ChanDoanRaVienTheoYHHD", BenhAnNgoaiTruYHCT.ChanDoanRaVienTheoYHHD));
            Command.Parameters.Add(new MDB.MDBParameter("KetQuaDieuTriID", BenhAnNgoaiTruYHCT.KetQuaDieuTriID));
            Command.Parameters.Add(new MDB.MDBParameter("TinhTrangNguoiBenhKhiRavien", BenhAnNgoaiTruYHCT.TinhTrangNguoiBenhKhiRavien));
            Command.Parameters.Add(new MDB.MDBParameter("ThoiGianDieuTri", BenhAnNgoaiTruYHCT.ThoiGianDieuTri));
            Command.Parameters.Add(new MDB.MDBParameter("ThoiGianDieuTriTuNgay", BenhAnNgoaiTruYHCT.ThoiGianDieuTriTuNgay));
            Command.Parameters.Add(new MDB.MDBParameter("ThoiGianDieuTriDenNgay", BenhAnNgoaiTruYHCT.ThoiGianDieuTriDenNgay));
            // add
            Command.Parameters.Add(new MDB.MDBParameter("MaICD_NoiChuyenDen", BenhAnNgoaiTruYHCT.MaICD_NoiChuyenDen));
            Command.Parameters.Add(new MDB.MDBParameter("MICD_BenhChinh", BenhAnNgoaiTruYHCT.MICD_BenhChinh));
            Command.Parameters.Add(new MDB.MDBParameter("MICD_BenhKemTheo", BenhAnNgoaiTruYHCT.MICD_BenhKemTheo));
            Command.Parameters.Add(new MDB.MDBParameter("KinhMach", BenhAnNgoaiTruYHCT.KinhMach));
            Command.Parameters.Add(new MDB.MDBParameter("DinhViBenh", BenhAnNgoaiTruYHCT.DinhViBenh));
            Command.Parameters.Add(new MDB.MDBParameter("MICDVaoVienTheoYHHD", BenhAnNgoaiTruYHCT.MICDVaoVienTheoYHHD));
            Command.Parameters.Add(new MDB.MDBParameter("CDBenhKemtheoVVYHHD", BenhAnNgoaiTruYHCT.CDBenhKemtheoVVYHHD));
            Command.Parameters.Add(new MDB.MDBParameter("MICDBenhKemtheoVVYHHD", BenhAnNgoaiTruYHCT.MICDBenhKemtheoVVYHHD));
            Command.Parameters.Add(new MDB.MDBParameter("MICDBenhChinhVVYHCT", BenhAnNgoaiTruYHCT.MICDBenhChinhVVYHCT));
            Command.Parameters.Add(new MDB.MDBParameter("CDBenhKemtheoVVYHCT", BenhAnNgoaiTruYHCT.CDBenhKemtheoVVYHCT));
            Command.Parameters.Add(new MDB.MDBParameter("MICDBenhKemTheoVVYHCT", BenhAnNgoaiTruYHCT.MICDBenhKemTheoVVYHCT));
            Command.Parameters.Add(new MDB.MDBParameter("MICDRaVienTheoYHHD", BenhAnNgoaiTruYHCT.MICDRaVienTheoYHHD));
            Command.Parameters.Add(new MDB.MDBParameter("CDBenhKemTheoRVYHHD", BenhAnNgoaiTruYHCT.CDBenhKemTheoRVYHHD));
            Command.Parameters.Add(new MDB.MDBParameter("MICDBenhChinhRVYHCT", BenhAnNgoaiTruYHCT.MICDBenhChinhRVYHCT));
            Command.Parameters.Add(new MDB.MDBParameter("CDBenhKemTheoRaVienTheoYHCT", BenhAnNgoaiTruYHCT.CDBenhKemTheoRaVienTheoYHCT));
            Command.Parameters.Add(new MDB.MDBParameter("MICDbenhKemTheoRaVienYHCT", BenhAnNgoaiTruYHCT.MICDbenhKemTheoRaVienYHCT));
            Command.Parameters.Add(new MDB.MDBParameter("MotaTienSuBanThan", BenhAnNgoaiTruYHCT.MotaTienSuBanThan));
            Command.Parameters.Add(new MDB.MDBParameter("MICDbenhKemTheoRaVienYHHD", BenhAnNgoaiTruYHCT.MICDbenhKemTheoRaVienYHHD));
            Command.Parameters.Add(new MDB.MDBParameter("MaICD_BenhKemTheo_RV_YHCT", BenhAnNgoaiTruYHCT.MaICD_BenhKemTheo_RV_YHCT));
            Command.Parameters.Add(new MDB.MDBParameter("MaICD_NoiChuyenDen_YHCT", BenhAnNgoaiTruYHCT.MaICD_NoiChuyenDen_YHCT));
            Command.Parameters.Add(new MDB.MDBParameter("ChanDoan_KKB_CapCuu_YHCT", BenhAnNgoaiTruYHCT.ChanDoan_KKB_CapCuu_YHCT));
            Command.Parameters.Add(new MDB.MDBParameter("MaICD_KKB_CapCuu_YHCT", BenhAnNgoaiTruYHCT.MaICD_KKB_CapCuu_YHCT));
            Command.Parameters.Add(new MDB.MDBParameter("MaICD_BenhChinh_YHCT", BenhAnNgoaiTruYHCT.MaICD_BenhChinh_YHCT));
            Command.Parameters.Add(new MDB.MDBParameter("BenhKemTheo_YHCT", BenhAnNgoaiTruYHCT.BenhKemTheo_YHCT));
            Command.Parameters.Add(new MDB.MDBParameter("MaICD_BenhKemTheo_YHCT", BenhAnNgoaiTruYHCT.MaICD_BenhKemTheo_YHCT));
            Command.Parameters.Add(new MDB.MDBParameter("MaICD_BenhChinh_RV_YHCT", BenhAnNgoaiTruYHCT.MaICD_BenhChinh_RV_YHCT));
            Command.Parameters.Add(new MDB.MDBParameter("BenhKemTheo_RV_YHCT", BenhAnNgoaiTruYHCT.BenhKemTheo_RV_YHCT));
            Command.Parameters.Add(new MDB.MDBParameter("MaICD_BenhKemTheo_YHHD", BenhAnNgoaiTruYHCT.MaICD_BenhKemTheo_YHHD));
            Command.Parameters.Add(new MDB.MDBParameter("TRUCTIEPVAO", BenhAnNgoaiTruYHCT.TRUCTIEPVAO == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("TaiBien_YHCT", BenhAnNgoaiTruYHCT.TaiBien_YHCT == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("BienChung_YHCT", BenhAnNgoaiTruYHCT.BienChung_YHCT == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("ThuThuat_YHCT", BenhAnNgoaiTruYHCT.ThuThuat_YHCT == true ? "1" : "0"));




            int n = Command.ExecuteNonQuery(); // C#
            return n > 0 ? true : false;
        }
        public static bool Update(MDB.MDBConnection MyConnection, BenhAnNgoaiTruYHCT BenhAnNgoaiTruYHCT)
        {
            string sql = @"UPDATE BenhAnNgoaiTruYHCT SET 
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
BenhSu = :BenhSu,
CacBoPhan = :CacBoPhan,
TomTatKetQuaCanLamSang = :TomTatKetQuaCanLamSang,
MoTa_VongChan = :MoTa_VongChan,
MoTa_VanChan = :MoTa_VanChan,
MoTa_VaanChan = :MoTa_VaanChan,
MoTa_XucChan = :MoTa_XucChan,
MachTayTrai = :MachTayTrai,
MachTayPhai = :MachTayPhai,
TomTatTuChan = :TomTatTuChan,
BienPhapLuanTri = :BienPhapLuanTri,
BietDanh = :BietDanh,
BatCuong = :BatCuong,
TangPhuKinhLac = :TangPhuKinhLac,
NguyenNhan = :NguyenNhan,
DieuTriYHCT = :DieuTriYHCT,
PhapDieuTri = :PhapDieuTri,
PhuongThuoc = :PhuongThuoc,
PhuongHuyet = :PhuongHuyet,
DieuTriKetHopVoiYHHD = :DieuTriKetHopVoiYHHD,
DieuTriKetHopVoiYHHD_Text = :DieuTriKetHopVoiYHHD_Text,
CheDoDinhDuongTaiNha = :CheDoDinhDuongTaiNha,
CheDoHoLyTaiNha = :CheDoHoLyTaiNha,
KetQuaXetNghiemCanLamSang = :KetQuaXetNghiemCanLamSang,
ChanDoanVaoVienTheoYHCT = :ChanDoanVaoVienTheoYHCT,
ChanDoanVaoVienTheoYHHD = :ChanDoanVaoVienTheoYHHD,
PhuongPhapDieuTriTheoYHHD = :PhuongPhapDieuTriTheoYHHD,
PhuongPhapDieuTriTheoYHCT = :PhuongPhapDieuTriTheoYHCT,
ChanDoanRaVienTheoYHCT = :ChanDoanRaVienTheoYHCT,
ChanDoanRaVienTheoYHHD = :ChanDoanRaVienTheoYHHD,
KetQuaDieuTriID = :KetQuaDieuTriID,
TinhTrangNguoiBenhKhiRavien = :TinhTrangNguoiBenhKhiRavien,
ThoiGianDieuTri = :ThoiGianDieuTri,
ThoiGianDieuTriTuNgay = :ThoiGianDieuTriTuNgay,
ThoiGianDieuTriDenNgay = :ThoiGianDieuTriDenNgay,
MaICD_NoiChuyenDen = :MaICD_NoiChuyenDen,
MICD_BenhChinh = :MICD_BenhChinh,
MICD_BenhKemTheo = :MICD_BenhKemTheo,
KinhMach = :KinhMach,
DinhViBenh = :DinhViBenh,
MICDVaoVienTheoYHHD = :MICDVaoVienTheoYHHD,
CDBenhKemtheoVVYHHD = :CDBenhKemtheoVVYHHD,
MICDBenhKemtheoVVYHHD = :MICDBenhKemtheoVVYHHD,
MICDBenhChinhVVYHCT = :MICDBenhChinhVVYHCT,
CDBenhKemtheoVVYHCT = :CDBenhKemtheoVVYHCT,
MICDBenhKemTheoVVYHCT = :MICDBenhKemTheoVVYHCT,
MICDRaVienTheoYHHD = :MICDRaVienTheoYHHD,
CDBenhKemTheoRVYHHD = :CDBenhKemTheoRVYHHD,
MICDBenhChinhRVYHCT = :MICDBenhChinhRVYHCT,
CDBenhKemTheoRaVienTheoYHCT = :CDBenhKemTheoRaVienTheoYHCT,
MICDbenhKemTheoRaVienYHCT = :MICDbenhKemTheoRaVienYHCT,
MotaTienSuBanThan = :MotaTienSuBanThan,
MICDbenhKemTheoRaVienYHHD = :MICDbenhKemTheoRaVienYHHD,
MaICD_BenhKemTheo_RV_YHCT = :MaICD_BenhKemTheo_RV_YHCT,
MaICD_NoiChuyenDen_YHCT = :MaICD_NoiChuyenDen_YHCT,
ChanDoan_KKB_CapCuu_YHCT = :ChanDoan_KKB_CapCuu_YHCT,
MaICD_KKB_CapCuu_YHCT = :MaICD_KKB_CapCuu_YHCT,
MaICD_BenhChinh_YHCT = :MaICD_BenhChinh_YHCT,
BenhKemTheo_YHCT = :BenhKemTheo_YHCT,
MaICD_BenhKemTheo_YHCT = :MaICD_BenhKemTheo_YHCT,
MaICD_BenhChinh_RV_YHCT = :MaICD_BenhChinh_RV_YHCT,
BenhKemTheo_RV_YHCT = :BenhKemTheo_RV_YHCT,
MaICD_BenhKemTheo_YHHD = :MaICD_BenhKemTheo_YHHD,
TRUCTIEPVAO = :TRUCTIEPVAO,
TaiBien_YHCT = :TaiBien_YHCT,
BienChung_YHCT = :BienChung_YHCT,
ThuThuat_YHCT = :ThuThuat_YHCT
                        WHERE MaQuanLy = :MaQuanLy";
            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
            Command.Parameters.Add(new MDB.MDBParameter("LyDoVaoVien", BenhAnNgoaiTruYHCT.LyDoVaoVien));
            Command.Parameters.Add(new MDB.MDBParameter("VaoNgayThu", BenhAnNgoaiTruYHCT.VaoNgayThu));
            Command.Parameters.Add(new MDB.MDBParameter("QuaTrinhBenhLy", BenhAnNgoaiTruYHCT.QuaTrinhBenhLy));
            Command.Parameters.Add(new MDB.MDBParameter("TienSuBenhBanThan", BenhAnNgoaiTruYHCT.TienSuBenhBanThan));
            Command.Parameters.Add(new MDB.MDBParameter("TienSuBenhGiaDinh", BenhAnNgoaiTruYHCT.TienSuBenhGiaDinh));
            Command.Parameters.Add(new MDB.MDBParameter("ToanThan", BenhAnNgoaiTruYHCT.ToanThan));
            Command.Parameters.Add(new MDB.MDBParameter("TuanHoan", BenhAnNgoaiTruYHCT.TuanHoan));
            Command.Parameters.Add(new MDB.MDBParameter("HoHap", BenhAnNgoaiTruYHCT.HoHap));
            Command.Parameters.Add(new MDB.MDBParameter("TieuHoa", BenhAnNgoaiTruYHCT.TieuHoa));
            Command.Parameters.Add(new MDB.MDBParameter("ThanTietNieuSinhDuc", BenhAnNgoaiTruYHCT.ThanTietNieuSinhDuc));
            Command.Parameters.Add(new MDB.MDBParameter("ThanKinh", BenhAnNgoaiTruYHCT.ThanKinh));
            Command.Parameters.Add(new MDB.MDBParameter("CoXuongKhop", BenhAnNgoaiTruYHCT.CoXuongKhop));
            Command.Parameters.Add(new MDB.MDBParameter("TaiMuiHong", BenhAnNgoaiTruYHCT.TaiMuiHong));
            Command.Parameters.Add(new MDB.MDBParameter("RangHamMat", BenhAnNgoaiTruYHCT.RangHamMat));
            Command.Parameters.Add(new MDB.MDBParameter("Mat", BenhAnNgoaiTruYHCT.Mat));
            Command.Parameters.Add(new MDB.MDBParameter("Khac_CacCoQuan", BenhAnNgoaiTruYHCT.Khac_CacCoQuan));
            Command.Parameters.Add(new MDB.MDBParameter("CacXetNghiemCanLamSangCanLam", BenhAnNgoaiTruYHCT.CacXetNghiemCanLamSangCanLam));
            Command.Parameters.Add(new MDB.MDBParameter("TomTatBenhAn", BenhAnNgoaiTruYHCT.TomTatBenhAn));
            Command.Parameters.Add(new MDB.MDBParameter("BenhChinh", BenhAnNgoaiTruYHCT.BenhChinh));
            Command.Parameters.Add(new MDB.MDBParameter("BenhKemTheo", BenhAnNgoaiTruYHCT.BenhKemTheo));
            Command.Parameters.Add(new MDB.MDBParameter("PhanBiet", BenhAnNgoaiTruYHCT.PhanBiet));
            Command.Parameters.Add(new MDB.MDBParameter("TienLuong", BenhAnNgoaiTruYHCT.TienLuong));
            Command.Parameters.Add(new MDB.MDBParameter("HuongDieuTri", BenhAnNgoaiTruYHCT.HuongDieuTri));
            Command.Parameters.Add(new MDB.MDBParameter("NgayKhamBenh", BenhAnNgoaiTruYHCT.NgayKhamBenh));
            Command.Parameters.Add(new MDB.MDBParameter("BacSyLamBenhAn", BenhAnNgoaiTruYHCT.BacSyLamBenhAn));
            Command.Parameters.Add(new MDB.MDBParameter("QuaTrinhBenhLyVaDienBien", BenhAnNgoaiTruYHCT.QuaTrinhBenhLyVaDienBien));
            Command.Parameters.Add(new MDB.MDBParameter("TomTatKetQuaXetNghiem", BenhAnNgoaiTruYHCT.TomTatKetQuaXetNghiem));
            Command.Parameters.Add(new MDB.MDBParameter("PhuongPhapDieuTri", BenhAnNgoaiTruYHCT.PhuongPhapDieuTri));
            Command.Parameters.Add(new MDB.MDBParameter("TinhTrangNguoiBenhRaVien", BenhAnNgoaiTruYHCT.TinhTrangNguoiBenhRaVien));
            Command.Parameters.Add(new MDB.MDBParameter("HuongDieuTriVaCacCheDoTiepTheo", BenhAnNgoaiTruYHCT.HuongDieuTriVaCacCheDoTiepTheo));
            Command.Parameters.Add(new MDB.MDBParameter("NguoiNhanHoSo", BenhAnNgoaiTruYHCT.NguoiNhanHoSo));
            Command.Parameters.Add(new MDB.MDBParameter("NguoiGiaoHoSo", BenhAnNgoaiTruYHCT.NguoiGiaoHoSo));
            Command.Parameters.Add(new MDB.MDBParameter("NgayTongKet", BenhAnNgoaiTruYHCT.NgayTongKet));
            Command.Parameters.Add(new MDB.MDBParameter("BacSyDieuTri", BenhAnNgoaiTruYHCT.BacSyDieuTri));
            Command.Parameters.Add(new MDB.MDBParameter("DiUng", BenhAnNgoaiTruYHCT.DacDiemLienQuanBenh.DiUng == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("DiUng_Text", BenhAnNgoaiTruYHCT.DacDiemLienQuanBenh.DiUng_Text));
            Command.Parameters.Add(new MDB.MDBParameter("MaTuy", BenhAnNgoaiTruYHCT.DacDiemLienQuanBenh.MaTuy == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("MaTuy_Text", BenhAnNgoaiTruYHCT.DacDiemLienQuanBenh.MaTuy_Text));
            Command.Parameters.Add(new MDB.MDBParameter("RuouBia", BenhAnNgoaiTruYHCT.DacDiemLienQuanBenh.RuouBia == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("RuouBia_Text", BenhAnNgoaiTruYHCT.DacDiemLienQuanBenh.RuouBia_Text));
            Command.Parameters.Add(new MDB.MDBParameter("ThuocLa", BenhAnNgoaiTruYHCT.DacDiemLienQuanBenh.ThuocLa == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("ThuocLa_Text", BenhAnNgoaiTruYHCT.DacDiemLienQuanBenh.ThuocLa_Text));
            Command.Parameters.Add(new MDB.MDBParameter("ThuocLao", BenhAnNgoaiTruYHCT.DacDiemLienQuanBenh.ThuocLao == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("ThuocLao_Text", BenhAnNgoaiTruYHCT.DacDiemLienQuanBenh.ThuocLao_Text));
            Command.Parameters.Add(new MDB.MDBParameter("Khac_DacDiemLienQuanBenh", BenhAnNgoaiTruYHCT.DacDiemLienQuanBenh.Khac_DacDiemLienQuanBenh == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("Khac_DacDiemLienQuanBenh_Text", BenhAnNgoaiTruYHCT.DacDiemLienQuanBenh.Khac_DacDiemLienQuanBenh_Text));
            Command.Parameters.Add(new MDB.MDBParameter("BenhSu", BenhAnNgoaiTruYHCT.BenhSu));
            Command.Parameters.Add(new MDB.MDBParameter("CacBoPhan", BenhAnNgoaiTruYHCT.CacBoPhan));
            Command.Parameters.Add(new MDB.MDBParameter("TomTatKetQuaCanLamSang", BenhAnNgoaiTruYHCT.TomTatKetQuaCanLamSang));
            Command.Parameters.Add(new MDB.MDBParameter("MoTa_VongChan", BenhAnNgoaiTruYHCT.MoTa_VongChan));
            Command.Parameters.Add(new MDB.MDBParameter("MoTa_VanChan", BenhAnNgoaiTruYHCT.MoTa_VanChan));
            Command.Parameters.Add(new MDB.MDBParameter("MoTa_VaanChan", BenhAnNgoaiTruYHCT.MoTa_VaanChan));
            Command.Parameters.Add(new MDB.MDBParameter("MoTa_XucChan", BenhAnNgoaiTruYHCT.MoTa_XucChan));
            Command.Parameters.Add(new MDB.MDBParameter("MachTayTrai", BenhAnNgoaiTruYHCT.MachTayTrai));
            Command.Parameters.Add(new MDB.MDBParameter("MachTayPhai", BenhAnNgoaiTruYHCT.MachTayPhai));
            Command.Parameters.Add(new MDB.MDBParameter("TomTatTuChan", BenhAnNgoaiTruYHCT.TomTatTuChan));
            Command.Parameters.Add(new MDB.MDBParameter("BienPhapLuanTri", BenhAnNgoaiTruYHCT.BienPhapLuanTri));
            Command.Parameters.Add(new MDB.MDBParameter("BietDanh", BenhAnNgoaiTruYHCT.BietDanh));
            Command.Parameters.Add(new MDB.MDBParameter("BatCuong", BenhAnNgoaiTruYHCT.BatCuong));
            Command.Parameters.Add(new MDB.MDBParameter("TangPhuKinhLac", BenhAnNgoaiTruYHCT.TangPhuKinhLac));
            Command.Parameters.Add(new MDB.MDBParameter("NguyenNhan", BenhAnNgoaiTruYHCT.NguyenNhan));
            Command.Parameters.Add(new MDB.MDBParameter("DieuTriYHCT", BenhAnNgoaiTruYHCT.DieuTriYHCT == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("PhapDieuTri", BenhAnNgoaiTruYHCT.PhapDieuTri));
            Command.Parameters.Add(new MDB.MDBParameter("PhuongThuoc", BenhAnNgoaiTruYHCT.PhuongThuoc));
            Command.Parameters.Add(new MDB.MDBParameter("PhuongHuyet", BenhAnNgoaiTruYHCT.PhuongHuyet));
            Command.Parameters.Add(new MDB.MDBParameter("DieuTriKetHopVoiYHHD", BenhAnNgoaiTruYHCT.DieuTriKetHopVoiYHHD == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("DieuTriKetHopVoiYHHD_Text", BenhAnNgoaiTruYHCT.DieuTriKetHopVoiYHHD_Text));
            Command.Parameters.Add(new MDB.MDBParameter("CheDoDinhDuongTaiNha", BenhAnNgoaiTruYHCT.CheDoDinhDuongTaiNha));
            Command.Parameters.Add(new MDB.MDBParameter("CheDoHoLyTaiNha", BenhAnNgoaiTruYHCT.CheDoHoLyTaiNha));
            Command.Parameters.Add(new MDB.MDBParameter("KetQuaXetNghiemCanLamSang", BenhAnNgoaiTruYHCT.KetQuaXetNghiemCanLamSang));
            Command.Parameters.Add(new MDB.MDBParameter("ChanDoanVaoVienTheoYHCT", BenhAnNgoaiTruYHCT.ChanDoanVaoVienTheoYHCT));
            Command.Parameters.Add(new MDB.MDBParameter("ChanDoanVaoVienTheoYHHD", BenhAnNgoaiTruYHCT.ChanDoanVaoVienTheoYHHD));
            Command.Parameters.Add(new MDB.MDBParameter("PhuongPhapDieuTriTheoYHHD", BenhAnNgoaiTruYHCT.PhuongPhapDieuTriTheoYHHD));
            Command.Parameters.Add(new MDB.MDBParameter("PhuongPhapDieuTriTheoYHCT", BenhAnNgoaiTruYHCT.PhuongPhapDieuTriTheoYHCT));
            Command.Parameters.Add(new MDB.MDBParameter("ChanDoanRaVienTheoYHCT", BenhAnNgoaiTruYHCT.ChanDoanRaVienTheoYHCT));
            Command.Parameters.Add(new MDB.MDBParameter("ChanDoanRaVienTheoYHHD", BenhAnNgoaiTruYHCT.ChanDoanRaVienTheoYHHD));
            Command.Parameters.Add(new MDB.MDBParameter("KetQuaDieuTriID", BenhAnNgoaiTruYHCT.KetQuaDieuTriID));
            Command.Parameters.Add(new MDB.MDBParameter("TinhTrangNguoiBenhKhiRavien", BenhAnNgoaiTruYHCT.TinhTrangNguoiBenhKhiRavien));
            Command.Parameters.Add(new MDB.MDBParameter("ThoiGianDieuTri", BenhAnNgoaiTruYHCT.ThoiGianDieuTri));
            Command.Parameters.Add(new MDB.MDBParameter("ThoiGianDieuTriTuNgay", BenhAnNgoaiTruYHCT.ThoiGianDieuTriTuNgay));
            Command.Parameters.Add(new MDB.MDBParameter("ThoiGianDieuTriDenNgay", BenhAnNgoaiTruYHCT.ThoiGianDieuTriDenNgay));
            // add
            Command.Parameters.Add(new MDB.MDBParameter("MaICD_NoiChuyenDen", BenhAnNgoaiTruYHCT.MaICD_NoiChuyenDen));
            Command.Parameters.Add(new MDB.MDBParameter("MICD_BenhChinh", BenhAnNgoaiTruYHCT.MICD_BenhChinh));
            Command.Parameters.Add(new MDB.MDBParameter("MICD_BenhKemTheo", BenhAnNgoaiTruYHCT.MICD_BenhKemTheo));
            Command.Parameters.Add(new MDB.MDBParameter("KinhMach", BenhAnNgoaiTruYHCT.KinhMach));
            Command.Parameters.Add(new MDB.MDBParameter("DinhViBenh", BenhAnNgoaiTruYHCT.DinhViBenh));
            Command.Parameters.Add(new MDB.MDBParameter("MICDVaoVienTheoYHHD", BenhAnNgoaiTruYHCT.MICDVaoVienTheoYHHD));
            Command.Parameters.Add(new MDB.MDBParameter("CDBenhKemtheoVVYHHD", BenhAnNgoaiTruYHCT.CDBenhKemtheoVVYHHD));
            Command.Parameters.Add(new MDB.MDBParameter("MICDBenhKemtheoVVYHHD", BenhAnNgoaiTruYHCT.MICDBenhKemtheoVVYHHD));
            Command.Parameters.Add(new MDB.MDBParameter("MICDBenhChinhVVYHCT", BenhAnNgoaiTruYHCT.MICDBenhChinhVVYHCT));
            Command.Parameters.Add(new MDB.MDBParameter("CDBenhKemtheoVVYHCT", BenhAnNgoaiTruYHCT.CDBenhKemtheoVVYHCT));
            Command.Parameters.Add(new MDB.MDBParameter("MICDBenhKemTheoVVYHCT", BenhAnNgoaiTruYHCT.MICDBenhKemTheoVVYHCT));
            Command.Parameters.Add(new MDB.MDBParameter("MICDRaVienTheoYHHD", BenhAnNgoaiTruYHCT.MICDRaVienTheoYHHD));
            Command.Parameters.Add(new MDB.MDBParameter("CDBenhKemTheoRVYHHD", BenhAnNgoaiTruYHCT.CDBenhKemTheoRVYHHD));
            Command.Parameters.Add(new MDB.MDBParameter("MICDBenhChinhRVYHCT", BenhAnNgoaiTruYHCT.MICDBenhChinhRVYHCT));
            Command.Parameters.Add(new MDB.MDBParameter("CDBenhKemTheoRaVienTheoYHCT", BenhAnNgoaiTruYHCT.CDBenhKemTheoRaVienTheoYHCT));
            Command.Parameters.Add(new MDB.MDBParameter("MICDbenhKemTheoRaVienYHCT", BenhAnNgoaiTruYHCT.MICDbenhKemTheoRaVienYHCT));
            Command.Parameters.Add(new MDB.MDBParameter("MotaTienSuBanThan", BenhAnNgoaiTruYHCT.MotaTienSuBanThan));
            Command.Parameters.Add(new MDB.MDBParameter("MICDbenhKemTheoRaVienYHHD", BenhAnNgoaiTruYHCT.MICDbenhKemTheoRaVienYHHD));
            Command.Parameters.Add(new MDB.MDBParameter("MaICD_BenhKemTheo_RV_YHCT", BenhAnNgoaiTruYHCT.MaICD_BenhKemTheo_RV_YHCT));
            Command.Parameters.Add(new MDB.MDBParameter("MaICD_NoiChuyenDen_YHCT", BenhAnNgoaiTruYHCT.MaICD_NoiChuyenDen_YHCT));
            Command.Parameters.Add(new MDB.MDBParameter("ChanDoan_KKB_CapCuu_YHCT", BenhAnNgoaiTruYHCT.ChanDoan_KKB_CapCuu_YHCT));
            Command.Parameters.Add(new MDB.MDBParameter("MaICD_KKB_CapCuu_YHCT", BenhAnNgoaiTruYHCT.MaICD_KKB_CapCuu_YHCT));
            Command.Parameters.Add(new MDB.MDBParameter("MaICD_BenhChinh_YHCT", BenhAnNgoaiTruYHCT.MaICD_BenhChinh_YHCT));
            Command.Parameters.Add(new MDB.MDBParameter("BenhKemTheo_YHCT", BenhAnNgoaiTruYHCT.BenhKemTheo_YHCT));
            Command.Parameters.Add(new MDB.MDBParameter("MaICD_BenhKemTheo_YHCT", BenhAnNgoaiTruYHCT.MaICD_BenhKemTheo_YHCT));
            Command.Parameters.Add(new MDB.MDBParameter("MaICD_BenhChinh_RV_YHCT", BenhAnNgoaiTruYHCT.MaICD_BenhChinh_RV_YHCT));
            Command.Parameters.Add(new MDB.MDBParameter("BenhKemTheo_RV_YHCT", BenhAnNgoaiTruYHCT.BenhKemTheo_RV_YHCT));
            Command.Parameters.Add(new MDB.MDBParameter("MaICD_BenhKemTheo_YHHD", BenhAnNgoaiTruYHCT.MaICD_BenhKemTheo_YHHD));
            Command.Parameters.Add(new MDB.MDBParameter("TRUCTIEPVAO", BenhAnNgoaiTruYHCT.TRUCTIEPVAO == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("TaiBien_YHCT", BenhAnNgoaiTruYHCT.TaiBien_YHCT == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("BienChung_YHCT", BenhAnNgoaiTruYHCT.BienChung_YHCT == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("ThuThuat_YHCT", BenhAnNgoaiTruYHCT.ThuThuat_YHCT == true ? "1" : "0"));


            Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", BenhAnNgoaiTruYHCT.MaQuanLy));
            int n = Command.ExecuteNonQuery(); // C#
            return n > 0 ? true : false;
        }
        public static bool Delete(MDB.MDBConnection MyConnection, BenhAnNgoaiTruYHCT BenhAnNgoaiTruYHCT)
        {
            string sql = @"DELETE FROM BenhAnNgoaiTruYHCT 
                           WHERE MaQuanLy = :MaQuanLy";
            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
            Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", BenhAnNgoaiTruYHCT.MaQuanLy));

            int n = Command.ExecuteNonQuery(); // C#
            return n > 0 ? true : false;
        }
    }
}
